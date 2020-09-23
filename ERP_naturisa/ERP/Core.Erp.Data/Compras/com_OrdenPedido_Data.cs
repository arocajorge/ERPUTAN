using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_OrdenPedido_Data
    {
        Funciones Fx = new Funciones();
        

        public List<com_OrdenPedido_Info> GetList(int IdEmpresa, string IdUsuario, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<com_OrdenPedido_Info> Lista = new List<com_OrdenPedido_Info>();
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var solicitante = db.com_solicitante.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario).FirstOrDefault();
                    if (solicitante == null)
                        return new List<com_OrdenPedido_Info>();

                    var DepartamentosPorUsuario = db.com_solicitante_x_com_departamento.Where(q => q.IdEmpresa == IdEmpresa && q.IdSolicitante == solicitante.IdSolicitante).Count();
                    solicitante.ConsultaDepartamento = DepartamentosPorUsuario > 0 ? true : false;

                    if (!solicitante.ConsultaDepartamento)
                        Lista = db.vwcom_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario && FechaIni <= q.op_Fecha && q.op_Fecha <= FechaFin).Select(q => new com_OrdenPedido_Info
                        {
                            IdEmpresa = q.IdEmpresa,
                            IdOrdenPedido = q.IdOrdenPedido,
                            op_Codigo = q.op_Codigo,
                            op_Fecha = q.op_Fecha,
                            op_Observacion = q.op_Observacion,

                            nom_departamento = q.nom_departamento,
                            nom_solicitante = q.nom_solicitante,
                            Estado = q.Estado,
                            CatalogoEstado = q.CatalogoEstado,
                            IdCatalogoEstado = q.IdCatalogoEstado,
                            EsCompraUrgente = q.EsCompraUrgente ?? false,
                            nom_punto_cargo = q.nom_punto_cargo
                        }).ToList();
                    else
                    {
                        var lst_Dep = db.com_solicitante_x_com_departamento.Where(q => q.IdEmpresa == solicitante.IdEmpresa && q.IdSolicitante == solicitante.IdSolicitante).ToList();
                        foreach (var item in lst_Dep)
                        {
                            Lista.AddRange(db.vwcom_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdDepartamento == item.IdDepartamento && FechaIni <= q.op_Fecha && q.op_Fecha <= FechaFin && q.IdUsuario != IdUsuario).Select(q => new com_OrdenPedido_Info
                            {
                                IdEmpresa = q.IdEmpresa,
                                IdOrdenPedido = q.IdOrdenPedido,
                                op_Codigo = q.op_Codigo,
                                op_Fecha = q.op_Fecha,
                                op_Observacion = q.op_Observacion,

                                nom_departamento = q.nom_departamento,
                                nom_solicitante = q.nom_solicitante,
                                Estado = q.Estado,
                                CatalogoEstado = q.CatalogoEstado,
                                IdCatalogoEstado = q.IdCatalogoEstado,
                                EsCompraUrgente = q.EsCompraUrgente ?? false,
                                nom_punto_cargo = q.nom_punto_cargo
                            }).ToList());
                        }
                        Lista.AddRange(db.vwcom_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario && FechaIni <= q.op_Fecha && q.op_Fecha <= FechaFin).Select(q => new com_OrdenPedido_Info
                        {
                            IdEmpresa = q.IdEmpresa,
                            IdOrdenPedido = q.IdOrdenPedido,
                            op_Codigo = q.op_Codigo,
                            op_Fecha = q.op_Fecha,
                            op_Observacion = q.op_Observacion,

                            nom_departamento = q.nom_departamento,
                            nom_solicitante = q.nom_solicitante,
                            Estado = q.Estado,
                            CatalogoEstado = q.CatalogoEstado,
                            IdCatalogoEstado = q.IdCatalogoEstado,
                            EsCompraUrgente = q.EsCompraUrgente ?? false,
                            nom_punto_cargo = q.nom_punto_cargo
                        }).ToList());
                    }
                }

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<com_OrdenPedido_Info> GetListRegularizacion(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<com_OrdenPedido_Info> Lista = new List<com_OrdenPedido_Info>();
                string CadenaConexion = ConexionERP.GetConnectionString();
                using (SqlConnection connection = new SqlConnection(CadenaConexion))
                {
                    connection.Open();
                    string query = "select a.IdEmpresa, a.IdOrdenPedido, a.IdCatalogoEstado, b.Nombre, a.op_Fecha, a.op_Observacion, c.nom_solicitante, d.nom_departamento, a.Estado, e.nom_punto_cargo"
                                + " from com_OrdenPedido as a left join"
                                + " com_catalogo as b on a.IdCatalogoEstado = b.IdCatalogocompra left join"
                                + " com_solicitante as c on a.IdEmpresa = c.IdEmpresa and a.IdSolicitante = c.IdSolicitante left join"
                                + " com_departamento as d on a.IdEmpresa = d.IdEmpresa and a.IdDepartamento = d.IdDepartamento left join"
                                + " ct_punto_cargo as e on a.IdEmpresa = e.IdEmpresa and a.IdPunto_cargo = e.IdPunto_cargo left join"
                                + " com_OrdenPedidoDet as f on a.IdEmpresa = f.IdEmpresa and a.IdOrdenPedido = f.IdOrdenPedido left join"
                                + " com_OrdenPedidoDet as g on f.IdEmpresa = g.IdEmpresa and f.IdOrdenPedido = g.IdOrdenPedidoReg and f.Secuencia = g.SecuenciaReg"
                                + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.IdCatalogoEstado = 'EST_OP_CER' and a.op_Fecha > DATEFROMPARTS(2020,09,01) and g.IdOrdenPedido is null"
                                + " and a.op_Fecha between DATEFROMPARTS(" + FechaIni.Year.ToString() + "," + FechaIni.Month.ToString() + "," + FechaIni.Day.ToString() + ") and DATEFROMPARTS(" + FechaFin.Year.ToString() + "," + FechaFin.Month.ToString() + "," + FechaFin.Day.ToString() + ")"
                                + " group by a.IdEmpresa, a.IdOrdenPedido, a.IdCatalogoEstado, b.Nombre, a.op_Fecha, a.op_Observacion, c.nom_solicitante, d.nom_departamento, a.Estado, e.nom_punto_cargo";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new com_OrdenPedido_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader[0]),
                            IdOrdenPedido = Convert.ToDecimal(reader[1]),
                            IdCatalogoEstado = reader[2].ToString(),
                            CatalogoEstado = reader[3].ToString(),
                            op_Fecha = Convert.ToDateTime(reader[4]),
                            op_Observacion = (reader[5] ?? "").ToString(),
                            nom_solicitante = reader[6].ToString(),
                            nom_departamento = reader[7].ToString(),
                            Estado = Convert.ToBoolean(reader[8]),
                            nom_punto_cargo = (reader[9] ?? "").ToString(),
                        });
                    }
                    reader.Close();
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_OrdenPedido_Info> GetList(int IdEmpresa, string IdUsuario)
        {
            try
            {
                List<com_OrdenPedido_Info> Lista = new List<com_OrdenPedido_Info>();
                List<com_solicitante_aprobador_Info> ListaAprobador = new List<com_solicitante_aprobador_Info>();
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    
                    string QuerySolicitantes = "select IdEmpresa, IdSolicitante from com_solicitante_aprobador where IdEmpresa = " + IdEmpresa.ToString() + " and idusuario = '" + IdUsuario + "' and MontoMax > 0 GROUP BY IdEmpresa, IdSolicitante";
                    SqlCommand commandSolicitantes = new SqlCommand(QuerySolicitantes, connection);
                    SqlDataReader readerSolicitantes = commandSolicitantes.ExecuteReader();
                    string WhereIn = string.Empty;
                    while (readerSolicitantes.Read())
                    {
                        if (string.IsNullOrEmpty(WhereIn))
                        {
                            WhereIn += readerSolicitantes["IdSolicitante"].ToString();
                        }
                        else
                            WhereIn += "," + readerSolicitantes["IdSolicitante"].ToString();
                    }

                    if (string.IsNullOrEmpty(WhereIn))
                        return new List<com_OrdenPedido_Info>();
                    

                    string QueryConsulta = "SELECT dbo.com_OrdenPedido.IdEmpresa, dbo.com_OrdenPedido.IdOrdenPedido, dbo.com_OrdenPedido.EsCompraUrgente, dbo.com_OrdenPedido.op_Codigo, dbo.com_OrdenPedido.op_Fecha, dbo.com_OrdenPedido.op_Observacion, "
                                            + " dbo.com_OrdenPedido.IdDepartamento, dbo.com_OrdenPedido.IdSolicitante, CASE WHEN COUNT(*) - A.Cont = 0 THEN 'PRECIO APROBADO' ELSE '' END AS IdCatalogoEstado, dbo.com_OrdenPedido.Estado, "
                                            + " dbo.com_OrdenPedido.IdPunto_cargo, dbo.ct_punto_cargo.nom_punto_cargo, dbo.com_departamento.nom_departamento, dbo.com_solicitante.nom_solicitante, ISNULL(A.cd_total, 0) "
                                            + " AS cd_total"
                                            + " FROM     dbo.com_OrdenPedidoDet INNER JOIN"
                                            + " dbo.com_OrdenPedido ON dbo.com_OrdenPedidoDet.IdEmpresa = dbo.com_OrdenPedido.IdEmpresa AND dbo.com_OrdenPedidoDet.IdOrdenPedido = dbo.com_OrdenPedido.IdOrdenPedido INNER JOIN"
                                            + " dbo.com_solicitante ON dbo.com_OrdenPedido.IdEmpresa = dbo.com_solicitante.IdEmpresa AND dbo.com_OrdenPedido.IdSolicitante = dbo.com_solicitante.IdSolicitante INNER JOIN"
                                            + " dbo.com_departamento ON dbo.com_OrdenPedido.IdEmpresa = dbo.com_departamento.IdEmpresa AND dbo.com_OrdenPedido.IdDepartamento = dbo.com_departamento.IdDepartamento LEFT OUTER JOIN"
                                            + " dbo.ct_punto_cargo ON dbo.com_OrdenPedido.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo AND dbo.com_OrdenPedido.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa LEFT OUTER JOIN"
                                            + " (SELECT d.IdEmpresa, d.IdOrdenPedido, COUNT(d.IdOrdenPedido) AS Cont, SUM(c.cd_subtotal) AS cd_total"
                                            + " FROM      dbo.com_OrdenPedidoDet AS d LEFT OUTER JOIN"
                                            + " dbo.com_CotizacionPedidoDet AS c ON c.IdEmpresa = d.IdEmpresa AND c.opd_IdOrdenPedido = d.IdOrdenPedido AND c.opd_Secuencia = d.Secuencia AND c.EstadoJC = 1"
                                            + " WHERE   (d.opd_EstadoProceso = 'AJC')"
                                            + " GROUP BY d.IdEmpresa, d.IdOrdenPedido) AS A ON dbo.com_OrdenPedido.IdEmpresa = A.IdEmpresa AND dbo.com_OrdenPedido.IdOrdenPedido = A.IdOrdenPedido"
                                            + " WHERE  (dbo.com_OrdenPedidoDet.opd_EstadoProceso NOT IN ('RA', 'RC', 'RGA', 'C', 'I', 'T')) AND (dbo.com_OrdenPedido.IdCatalogoEstado = 'EST_OP_PRO') "
                                            + " and com_OrdenPedidoDet.IdEmpresa = " + IdEmpresa.ToString() + " and com_OrdenPedido.IdSolicitante in ("+WhereIn+")"
                                            + " GROUP BY dbo.com_OrdenPedido.IdEmpresa, dbo.com_OrdenPedido.IdOrdenPedido, dbo.com_OrdenPedido.op_Codigo, dbo.com_OrdenPedido.op_Fecha, dbo.com_OrdenPedido.op_Observacion, dbo.com_OrdenPedido.IdDepartamento, "
                                            + " dbo.com_OrdenPedido.IdSolicitante, dbo.com_OrdenPedido.IdCatalogoEstado, dbo.com_OrdenPedido.IdPunto_cargo, dbo.ct_punto_cargo.nom_punto_cargo, "
                                            + " dbo.com_departamento.nom_departamento, dbo.com_OrdenPedido.EsCompraUrgente, dbo.com_OrdenPedido.Estado, dbo.com_solicitante.nom_solicitante, A.Cont, A.cd_total"
                                            + " order by dbo.com_OrdenPedido.IdOrdenPedido";
                    SqlCommand commandConsulta = new SqlCommand(QueryConsulta, connection);
                    SqlDataReader readerConsulta = commandConsulta.ExecuteReader();

                    while (readerConsulta.Read())
                    {
                        Lista.Add(new com_OrdenPedido_Info
                        {
                            IdEmpresa = Convert.ToInt32(readerConsulta["IdEmpresa"]),
                            IdOrdenPedido = Convert.ToDecimal(readerConsulta["IdOrdenPedido"]),
                            EsCompraUrgente = Convert.ToBoolean(readerConsulta["EsCompraUrgente"]),
                            op_Codigo = Convert.ToString(readerConsulta["op_Codigo"]),
                            op_Fecha = Convert.ToDateTime(readerConsulta["op_Fecha"]),
                            op_Observacion = Convert.ToString(readerConsulta["op_Observacion"]),
                            nom_punto_cargo = Convert.ToString(readerConsulta["nom_punto_cargo"]),
                            nom_departamento = Convert.ToString(readerConsulta["nom_departamento"]),
                            nom_solicitante = Convert.ToString(readerConsulta["nom_solicitante"]),
                            cd_total = Convert.ToDouble(readerConsulta["cd_total"]),
                            IdCatalogoEstado = Convert.ToString(readerConsulta["IdCatalogoEstado"])
                        });
                    }
                }
                /*
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    db.SetCommandTimeOut(3000);


                    string sql = "select IdEmpresa,IdOrdenPedido,EsCompraUrgente,op_Codigo,op_Fecha,op_Observacion,IdDepartamento,IdSolicitante,IdCatalogoEstado,Estado,IdPunto_cargo,IdUsuario,nom_punto_cargo,nom_departamento,nom_solicitante,cd_total ";
                    sql += "from vwcom_ordenpedidoaprobar where idempresa = " + IdEmpresa.ToString() + " and IdUsuario = '" + IdUsuario + "'";
                    var result = db.Database.SqlQuery<com_OrdenPedido_Info>(sql).ToList();
                    Lista = result;
                    
                }*/

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal ID = 1;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var lst = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa).Select(q => q.IdOrdenPedido).ToList();
                    if (lst.Count != 0)
                        ID = lst.Max() + 1;
                }

                return ID;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool GuardarDB(com_OrdenPedido_Info info)
        {
            try
            {
                com_parametro_Info param = new com_parametro_Data().Get_Info_parametro(info.IdEmpresa);
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    db.com_OrdenPedido.Add(new com_OrdenPedido
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdOrdenPedido = info.IdOrdenPedido = GetId(info.IdEmpresa),
                        op_Codigo = info.op_Codigo,
                        op_Fecha = info.op_Fecha,
                        op_Observacion = info.op_Observacion,
                        IdDepartamento = info.IdDepartamento,
                        IdSolicitante = info.IdSolicitante,
                        IdCatalogoEstado = info.IdCatalogoEstado = (info.EsCompraUrgente == true ? "EST_OP_PRO" : "EST_OP_ABI"),
                        Estado = true,
                        IdUsuarioCreacion = info.IdUsuarioCreacion,
                        FechaCreacion = DateTime.Now,
                        EsCompraUrgente = info.EsCompraUrgente,
                        IdPunto_cargo = info.IdPunto_cargo
                    });
                    int Secuencia = 1;
                    foreach (var item in info.ListaDetalle)
                    {
                        db.com_OrdenPedidoDet.Add(new com_OrdenPedidoDet
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdOrdenPedido = info.IdOrdenPedido,
                            Secuencia = item.Secuencia = Secuencia++,
                            IdSucursalOrigen = item.IdSucursalOrigen,
                            IdSucursalDestino = item.IdSucursalDestino,
                            IdProducto = item.IdProducto,
                            IdPunto_cargo = item.IdPunto_cargo,
                            IdUnidadMedida = item.IdUnidadMedida,
                            opd_EstadoProceso = item.opd_EstadoProceso = (info.EsCompraUrgente == true ? "A" : "P"),
                            FechaCantidad = (info.EsCompraUrgente == true ? DateTime.Now : (Nullable<DateTime>)null),
                            IdUsuarioCantidad = (info.EsCompraUrgente == true ? info.IdUsuarioCreacion : null),
                            pr_descripcion = item.pr_descripcion,
                            opd_Detalle = item.opd_Detalle,
                            opd_Cantidad = item.opd_Cantidad,
                            opd_CantidadApro = info.EsCompraUrgente == true ? item.opd_Cantidad : 0,
                            Adjunto = item.Adjunto,
                            NombreArchivo = !string.IsNullOrEmpty(item.NombreArchivo) ? Path.GetFileName(item.NombreArchivo) : item.NombreArchivo
                        });
                    }
                    db.SaveChanges();

                    if (SaltarPaso2(info.IdEmpresa, info.IdOrdenPedido, info.IdUsuarioCreacion))
                    {
                        ValidarProceso(info.IdEmpresa, info.IdOrdenPedido);
                    }


                    try
                    {
                        #region Adjuntos
                        var lst_adjuntos = info.ListaDetalle.Where(q => q.Adjunto == true).ToList();

                        if (param != null && !string.IsNullOrEmpty(param.UbicacionArchivosPedido))
                        {
                            string Comando = "/c Net Use " + param.FileDominio + " /USER:" + param.FileUsuario + " " + param.FileContrasenia;
                            Fx.ExecuteCommand(@"" + Comando);
                            Directory.CreateDirectory(param.UbicacionArchivosPedido + @"\" + info.IdOrdenPedido.ToString());
                            foreach (var item in lst_adjuntos)
                            {
                                var ext = Path.GetFileName(item.NombreArchivo);
                                System.IO.File.Copy(item.NombreArchivo, param.UbicacionArchivosPedido + @"\" + info.IdOrdenPedido.ToString() + @"\" + ext, true);
                            }

                            Comando = "/c Net Use /DELETE " + param.FileDominio + " /USER:" + param.FileUsuario + " " + param.FileContrasenia;
                            Fx.ExecuteCommand(@"" + Comando);
                        }
                        #endregion
                    }
                    catch (Exception)
                    {
                        var Entity = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenPedido == info.IdOrdenPedido).ToList();
                        foreach (var item in Entity)
                        {
                            item.Adjunto = false;
                            item.NombreArchivo = null;
                        }
                        db.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return true;
            }
        }

        public bool RegularizarDB(com_OrdenPedido_Info info)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    db.com_OrdenPedido.Add(new com_OrdenPedido
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdOrdenPedido = info.IdOrdenPedido = GetId(info.IdEmpresa),
                        op_Codigo = info.op_Codigo,
                        op_Fecha = info.op_Fecha,
                        op_Observacion = info.op_Observacion,
                        IdDepartamento = info.IdDepartamento,
                        IdSolicitante = info.IdSolicitante,
                        IdCatalogoEstado = "EST_OP_PRO",
                        Estado = true,
                        IdUsuarioCreacion = info.IdUsuarioCreacion,
                        FechaCreacion = DateTime.Now,
                        EsCompraUrgente = info.EsCompraUrgente,
                        IdPunto_cargo = info.IdPunto_cargo,
                        IdOrdenPedidoReg = info.IdOrdenPedidoReg
                    });
                    foreach (var item in info.ListaDetalle)
                    {
                        db.com_OrdenPedidoDet.Add(new com_OrdenPedidoDet
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdOrdenPedido = info.IdOrdenPedido,
                            Secuencia = item.Secuencia,
                            IdSucursalOrigen = item.IdSucursalOrigen,
                            IdSucursalDestino = item.IdSucursalDestino,
                            IdProducto = item.IdProducto,
                            IdPunto_cargo = item.IdPunto_cargo,
                            IdUnidadMedida = item.IdUnidadMedida,
                            opd_EstadoProceso = "A",
                            FechaCantidad = DateTime.Now,
                            IdUsuarioCantidad = info.IdUsuarioCreacion,
                            pr_descripcion = item.pr_descripcion,
                            opd_Detalle = item.opd_Detalle,
                            opd_Cantidad = item.opd_Cantidad,
                            opd_CantidadApro = item.opd_Cantidad,
                            Adjunto = false,
                            NombreArchivo = null,

                            IdOrdenPedidoReg = info.IdOrdenPedidoReg,
                            SecuenciaReg = item.Secuencia
                        });
                    }
                    db.SaveChanges();

                    var Entity = db.com_OrdenPedido.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenPedido == info.IdOrdenPedidoReg).FirstOrDefault();
                    if (Entity == null)
                    {
                        Entity.FechaReg = DateTime.Now;
                        Entity.IdUsuarioReg = info.IdUsuarioCreacion;
                        db.SaveChanges();
                    }

                    if (SaltarPaso3(info.IdEmpresa, info.IdOrdenPedido, info.IdUsuarioCreacion))
                    {
                        ValidarProceso(info.IdEmpresa, info.IdOrdenPedido);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return true;
            }
        }

        public bool ModificarDB(com_OrdenPedido_Info info)
        {
            try
            {
                com_parametro_Info param = new com_parametro_Data().Get_Info_parametro(info.IdEmpresa);
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    com_OrdenPedido Entity = db.com_OrdenPedido.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenPedido == info.IdOrdenPedido).FirstOrDefault();
                    if (Entity != null)
                    {
                        Entity.op_Codigo = info.op_Codigo;
                        Entity.op_Fecha = info.op_Fecha;
                        Entity.op_Observacion = info.op_Observacion;
                        Entity.IdDepartamento = info.IdDepartamento;
                        Entity.IdUsuarioUltModi = info.IdUsuarioCreacion;
                        Entity.FechaUltModi = DateTime.Now;
                        Entity.IdPunto_cargo = info.IdPunto_cargo;
                    }
                    var lst = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenPedido == info.IdOrdenPedido).ToList();
                    foreach (var item in lst)
                    {
                        db.com_OrdenPedidoDet.Remove(item);
                    }
                    int Secuencia = 1;
                    foreach (var item in info.ListaDetalle)
                    {
                        db.com_OrdenPedidoDet.Add(new com_OrdenPedidoDet
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdOrdenPedido = info.IdOrdenPedido,
                            Secuencia = Secuencia++,
                            IdSucursalOrigen = item.IdSucursalOrigen,
                            IdSucursalDestino = item.IdSucursalDestino,
                            IdProducto = item.IdProducto,
                            IdPunto_cargo = item.IdPunto_cargo,
                            IdUnidadMedida = item.IdUnidadMedida,
                            opd_EstadoProceso = item.opd_EstadoProceso = (info.EsCompraUrgente == true ? "A" : "P"),
                            FechaCantidad = (info.EsCompraUrgente == true ? DateTime.Now : (Nullable<DateTime>)null),
                            IdUsuarioCantidad = (info.EsCompraUrgente == true ? info.IdUsuarioCreacion : null),
                            pr_descripcion = item.pr_descripcion,
                            opd_Detalle = item.opd_Detalle,
                            opd_Cantidad = item.opd_Cantidad,
                            opd_CantidadApro = info.EsCompraUrgente == true ? item.opd_Cantidad : 0,
                            Adjunto = !string.IsNullOrEmpty(item.NombreArchivo) ? true : false,
                            NombreArchivo = item.NuevoAdjunto ? Path.GetFileName(item.NombreArchivo) : item.NombreArchivo
                        });
                    }
                    db.SaveChanges();

                    if (SaltarPaso2(info.IdEmpresa, info.IdOrdenPedido, info.IdUsuarioCreacion))
                    {
                        ValidarProceso(info.IdEmpresa, info.IdOrdenPedido);
                    }
                }
                try
                {
                    #region Adjuntos
                    var lst_adjuntos = info.ListaDetalle.Where(q => q.NuevoAdjunto == true).ToList();
                    if (param != null && !string.IsNullOrEmpty(param.UbicacionArchivosPedido))
                    {
                        string Comando = "/c Net Use " + param.FileDominio + " /USER:" + param.FileUsuario + " " + param.FileContrasenia;
                        Fx.ExecuteCommand(@"" + Comando);
                        Directory.CreateDirectory(param.UbicacionArchivosPedido + @"\" + info.IdOrdenPedido.ToString());
                        foreach (var item in lst_adjuntos)
                        {
                            var ext = Path.GetFileName(item.NombreArchivo);
                            System.IO.File.Copy(item.NombreArchivo, param.UbicacionArchivosPedido + @"\" + info.IdOrdenPedido.ToString() + @"\" + ext, true);
                        }

                        Comando = "/c Net Use /DELETE " + param.FileDominio + " /USER:" + param.FileUsuario + " " + param.FileContrasenia;
                        Fx.ExecuteCommand(@"" + Comando);
                    }
                    #endregion
                }
                catch (Exception)
                {
                    
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AnularDB(com_OrdenPedido_Info info)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    com_OrdenPedido Entity = db.com_OrdenPedido.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenPedido == info.IdOrdenPedido).FirstOrDefault();
                    if (Entity != null)
                    {
                        Entity.Estado = false;
                        Entity.IdUsuarioAnu = info.IdUsuarioCreacion;
                        Entity.FechaUltAnu = DateTime.Now;
                        Entity.MotivoAnu = info.MotivoAnu;
                    }
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public com_OrdenPedido_Info GetInfo(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                com_OrdenPedido_Info info = new com_OrdenPedido_Info();
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Entity = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                    if (Entity != null)
                    {
                        info = new com_OrdenPedido_Info
                        {
                            IdEmpresa = Entity.IdEmpresa,
                            IdOrdenPedido = Entity.IdOrdenPedido,
                            op_Fecha = Entity.op_Fecha,
                            op_Observacion = Entity.op_Observacion,
                            op_Codigo = Entity.op_Codigo,
                            IdDepartamento = Entity.IdDepartamento,
                            IdSolicitante = Entity.IdSolicitante,
                            IdCatalogoEstado = Entity.IdCatalogoEstado,
                            Estado = Entity.Estado,
                            EsCompraUrgente = Entity.EsCompraUrgente ?? false,
                            IdPunto_cargo = Entity.IdPunto_cargo,
                            ObservacionGA = Entity.ObservacionGA,
                            IdUsuarioAprobacion = Entity.IdUsuarioAprobacion
                        };
                        info.ObservacionGA = (info.IdUsuarioAprobacion ?? "") +".- "+ (info.ObservacionGA ?? "");
                        return info;
                    }
                }
                return info;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ValidarProceso(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var cont = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && (q.opd_EstadoProceso == "A" || q.opd_EstadoProceso == "AC" || q.opd_EstadoProceso == "AJC")).Count();
                    var contR = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && (q.opd_EstadoProceso == "RA" || q.opd_EstadoProceso == "RC" || q.opd_EstadoProceso == "RGA")).Count();
                    var contT = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).Count();
                    var contP = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && q.opd_EstadoProceso == "P").Count();

                    if (contT > 0)
                    {
                        if (cont > 0)
                        {
                            var pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                            if (pedido != null)
                                pedido.IdCatalogoEstado = "EST_OP_PRO";

                            db.SaveChanges();
                        }
                        else
                        {
                            if (contR != contT)
                            {
                                var pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                                if (pedido != null)
                                    pedido.IdCatalogoEstado = "EST_OP_CER";

                                db.SaveChanges();
                            }
                            else
                                if (contR == contT)
                                {
                                    var pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                                    if (pedido != null)
                                        pedido.IdCatalogoEstado = "EST_OP_REC";

                                    db.SaveChanges();
                                }
                                else
                                    if (contP == contT)
                                    {
                                        var pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                                        if (pedido != null)
                                            pedido.IdCatalogoEstado = "EST_OP_ABI";

                                        db.SaveChanges();
                                    }
                                    else
                                    {
                                        var pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                                        if (pedido != null)
                                            pedido.IdCatalogoEstado = "EST_OP_CER";

                                        db.SaveChanges();
                                    }
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ValidarProceso(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, int Secuencia)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var lst = db.vwcom_OrdenPedidoDet_PorOC.Where(q => q.IdEmpresa_oc == IdEmpresa && q.IdSucursal_oc == IdSucursal && q.IdOrdenCompra == IdOrdenCompra && q.Secuencia_oc == Secuencia).ToList();

                    var lsg = lst.GroupBy(q => new { q.IdEmpresa_oc, q.IdOrdenPedido, q.Secuencia_pd }).Select(q => new
                    {
                        IdEmpresa = q.Key.IdEmpresa_oc,
                        IdOrdenPedido = q.Key.IdOrdenPedido,
                        Secuencoia = q.Key.Secuencia_pd,
                        Contador = q.Count()
                    }).FirstOrDefault();

                    var pedido = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == lsg.IdEmpresa && q.IdOrdenPedido == lsg.IdOrdenPedido && q.Secuencia == lsg.Secuencoia).FirstOrDefault();
                    if (pedido != null)
                    {
                        int ContadorT = db.vwcom_OrdenPedidoDet_PorTR.Where(q => q.IdEmpresa_oc == IdEmpresa && q.IdSucursal_oc == IdSucursal && q.IdOrdenCompra == IdOrdenCompra && q.Secuencia_oc == Secuencia).Count();

                        pedido.opd_EstadoProceso = ContadorT > 0 ? "T" : (lsg.Contador > 0 ? "I" : "C");
                        db.SaveChanges();
                    }

                    
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaltarPaso2(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Lista = db.vwcom_OrdenPedidoConvenioPrecios.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && q.opd_EstadoProceso == "P" && q.SaltaPaso2).ToList();
                    foreach (var item in Lista)
                    {
                        var Entity = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdOrdenPedido == item.IdOrdenPedido && q.Secuencia == item.Secuencia).FirstOrDefault();
                        if (Entity != null)
                        {
                            Entity.opd_EstadoProceso = "A";
                            Entity.FechaCantidad = DateTime.Now;
                            Entity.IdUsuarioCantidad = IdUsuario;
                            Entity.opd_CantidadApro = Entity.opd_Cantidad;
                        }
                    }
                    db.SaveChanges();
                }

                if (SaltarPaso3(IdEmpresa,IdOrdenPedido,IdUsuario))
                {
                    
                }

                if (ValidarProceso(IdEmpresa,IdOrdenPedido))
                {
                    
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SaltarPaso3(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                cp_proveedor_Data data_prov = new cp_proveedor_Data();
                com_CotizacionPedido_Data data_cot = new com_CotizacionPedido_Data();
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Lista = db.vwcom_OrdenPedidoConvenioPrecios.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && q.opd_EstadoProceso == "A" && q.SaltaPaso3).ToList();
                   
                    var ListaAgrupada = Lista.GroupBy(q => new { q.IdProveedor, q.IdDepartamento, q.IdSolicitante, q.IdSucursalOrigen, q.IdComprador, q.IdOrdenPedido, q.IdSucursalDestino, q.IdTerminoPago, q.TiempoEntrega, q.SaltoPaso4 }).Select(q => new
                    {
                        q.Key.IdSolicitante,
                        q.Key.IdDepartamento,
                        q.Key.IdProveedor,
                        q.Key.IdSucursalOrigen,
                        q.Key.IdComprador,
                        q.Key.IdOrdenPedido,
                        q.Key.IdSucursalDestino,
                        q.Key.IdTerminoPago,
                        q.Key.TiempoEntrega,
                        q.Key.SaltoPaso4
                    }).ToList();


                    var lst_termino = db.com_TerminoPago.Where(q => q.Estado == "A").ToList();
                    foreach (var item in ListaAgrupada)
                    {
                        var proveedor = data_prov.Get_Info_Proveedor(IdEmpresa, item.IdProveedor);
                        if (proveedor == null)
                            return false;
                        var Pedido = Lista.Where(q => q.IdOrdenPedido == item.IdOrdenPedido).FirstOrDefault();
                        string Observacion = (Pedido != null ? Pedido.op_Observacion : string.Empty);
                        com_CotizacionPedido_Info cab = new com_CotizacionPedido_Info
                        {
                            IdEmpresa = IdEmpresa,
                            IdSucursal = item.IdSucursalOrigen,
                            IdProveedor = item.IdProveedor,
                            cp_Fecha = DateTime.Now.Date,
                            cp_Observacion = Observacion,
                            IdDepartamento = item.IdDepartamento,
                            IdSolicitante = item.IdSolicitante,
                            IdComprador = item.IdComprador,
                            IdTerminoPago = item.IdTerminoPago,
                            cp_Plazo = lst_termino.Where(q=> q.IdTerminoPago == item.IdTerminoPago).FirstOrDefault().Dias,
                            pe_correo = proveedor.Persona_Info.pe_correo_secundario1,
                            IdPersona = proveedor.IdPersona,                            
                            IdUsuario = IdUsuario,
                            IdOrdenPedido = item.IdOrdenPedido,
                            cp_PlazoEntrega = item.TiempoEntrega,
                            ListaDetalle = new List<com_CotizacionPedidoDet_Info>()
                        };

                        cab.ListaDetalle = Lista.Where(q => q.IdProveedor == item.IdProveedor 
                            && q.IdDepartamento == item.IdDepartamento 
                            && q.IdSolicitante == item.IdSolicitante 
                            && q.IdSucursalOrigen == item.IdSucursalOrigen 
                            && q.IdOrdenPedido == item.IdOrdenPedido
                            && q.IdSucursalDestino == item.IdSucursalDestino
                            && q.IdTerminoPago == item.IdTerminoPago
                            && q.TiempoEntrega == item.TiempoEntrega
                            && q.SaltoPaso4 == item.SaltoPaso4
                            && q.IdComprador == item.IdComprador).Select(q => new com_CotizacionPedidoDet_Info
                        {
                            IdEmpresa = IdEmpresa,
                            opd_IdEmpresa = q.IdEmpresa,
                            opd_IdOrdenPedido = q.IdOrdenPedido,
                            opd_Secuencia = q.Secuencia,
                            IdProducto = q.IdProducto ?? 0,
                            cd_Cantidad = q.opd_CantidadApro,
                            cd_precioCompra = q.PrecioUnitario,
                            cd_porc_des = q.PorDescuento,
                            cd_descuento = q.Descuento,
                            cd_precioFinal = q.PrecioFinal,
                            cd_subtotal = q.Subtotal,
                            IdCod_Impuesto = q.IdCod_Impuesto_Iva,
                            Por_Iva = q.porcentaje,
                            cd_iva = q.Iva,
                            cd_total = q.Total,
                            IdUnidadMedida = q.IdUnidadMedida,
                            IdPunto_cargo = q.IdPunto_cargo,
                            cd_DetallePorItem = q.opd_Detalle,
                            IdSucursalDestino = q.IdSucursalDestino,
                            IdSucursalOrigen = q.IdSucursalOrigen
                        }).ToList();

                        data_cot.GuardarDB(cab);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SaltarPaso4(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Lista = db.vwcom_CotizacionPedidoConvenioPrecios.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).ToList();
                    foreach (var item in Lista)
                    {
                        var cab = db.com_CotizacionPedido.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdCotizacion == item.IdCotizacion).FirstOrDefault();
                        if (cab != null)
                        {
                            cab.IdUsuarioJC = IdUsuario;
                            cab.FechaJC = DateTime.Now;
                            cab.EstadoJC = "A";

                            var ListaDet = db.com_CotizacionPedidoDet.Where(q => q.IdEmpresa == cab.IdEmpresa && q.IdCotizacion == cab.IdCotizacion).ToList();
                            foreach (var det in ListaDet)
                            {
                                det.EstadoJC = true;

                                var detOP = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == det.opd_IdEmpresa && q.IdOrdenPedido == det.opd_IdOrdenPedido && q.Secuencia == det.opd_Secuencia).FirstOrDefault();
                                if (detOP != null)
                                {
                                    detOP.opd_EstadoProceso = "AJC";
                                }
                            }
                        }
                    }
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SaltarPaso5(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                decimal IdOrdenPedidoAnt = 0;
                #region Validación
                string query = "select b.IdEmpresa, b.IdOrdenPedido"
                        + " from com_OrdenPedido as a inner join"
                        + " com_OrdenPedidoDet as b on a.IdEmpresa = b.IdEmpresa and a.IdOrdenPedido = b.IdOrdenPedido left join"
                        + " ("
                            + " select x1.opd_IdEmpresa, x1.opd_IdOrdenPedido, count(*) Cont"
                            + " from com_CotizacionPedidoDet x1"
                            + " where x1.opd_IdEmpresa = " + IdEmpresa.ToString() + " and x1.opd_IdOrdenPedido = " + IdOrdenPedido.ToString() + " AND X1.EstadoJC = 1 AND X1.EstadoGA = 0"
                            + " group by x1.opd_IdEmpresa, x1.opd_IdOrdenPedido"
                        + " )as c on b.IdEmpresa = c.opd_IdEmpresa and b.IdOrdenPedido = c.opd_IdOrdenPedido"
                        + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.IdOrdenPedido = " + IdOrdenPedido.ToString() + " and b.IdOrdenPedidoReg is not null"
                        + " group by b.IdEmpresa, b.IdOrdenPedido,cont"
                        + " having cont = count(*)";
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    var returnValue = command.ExecuteScalar();
                    if (returnValue == null)
                        return false;
                }
                #endregion

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var lst = db.com_CotizacionPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && q.EstadoJC == "A" && q.EstadoGA == "P").ToList();
                    var SolPed = db.com_OrdenPedido.Where(q=> q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault(); 
                    IdOrdenPedidoAnt = SolPed.IdOrdenPedidoReg ?? 0;
                    foreach (var item in lst)
                    {
                        com_CotizacionPedido_Info info;

                        var lstDet = db.com_CotizacionPedidoDet.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdCotizacion == item.IdCotizacion && q.EstadoJC == true && q.EstadoGA == false).ToList();
                        if (lstDet.Count > 0)
                        {
                            #region Cabecera
                            info = new com_CotizacionPedido_Info
                            {
                                IdEmpresa = item.IdEmpresa,
                                IdSucursal = item.IdSucursal,
                                IdProveedor = item.IdProveedor,
                                IdCotizacion = item.IdCotizacion,
                                IdTerminoPago = item.IdTerminoPago,
                                cp_Plazo = item.cp_Plazo,
                                cp_PlazoEntrega = item.cp_PlazoEntrega,
                                cp_Fecha = item.cp_Fecha,
                                cp_Observacion = item.cp_Observacion,
                                IdDepartamento = item.IdDepartamento,
                                IdComprador = item.IdComprador,
                                IdUsuario = IdUsuario,
                                IdOrdenPedido = item.IdOrdenPedido,
                                ObservacionAprobador = "Aprobado por regularización",
                                ListaDetalle = new List<com_CotizacionPedidoDet_Info>(),
                                EstadoGA = "A"
                            };
                            #endregion

                            #region Detalle
                            foreach (var det in lstDet)
                            {
                                info.ListaDetalle.Add(new com_CotizacionPedidoDet_Info
                                {
                                    IdEmpresa = det.IdEmpresa,
                                    IdSucursalDestino = det.com_OrdenPedidoDet.IdSucursalDestino,
                                    Secuencia = det.Secuencia,
                                    opd_Secuencia = det.opd_Secuencia,
                                    opd_IdOrdenPedido = det.opd_IdOrdenPedido,
                                    opd_IdEmpresa = det.IdEmpresa,
                                    IdProducto = det.IdProducto,
                                    cd_Cantidad = det.cd_Cantidad,
                                    cd_precioCompra = det.cd_precioCompra,
                                    cd_porc_des = det.cd_porc_des,
                                    cd_descuento = det.cd_descuento,
                                    cd_precioFinal = det.cd_precioFinal,
                                    cd_subtotal = det.cd_subtotal,
                                    cd_iva = det.cd_iva,
                                    cd_total = det.cd_total,
                                    IdPunto_cargo = det.IdPunto_cargo,
                                    IdUnidadMedida = det.IdUnidadMedida,
                                    Por_Iva = det.Por_Iva,
                                    IdCod_Impuesto = det.IdCod_Impuesto,
                                    cd_DetallePorItem = det.cd_DetallePorItem,
                                    opd_Detalle = det.com_OrdenPedidoDet.opd_Detalle,
                                    A = true,
                                    EstadoGA = true
                                });
                            }
                            #endregion
                            com_CotizacionPedido_Data odataCotizacion = new com_CotizacionPedido_Data();
                            odataCotizacion.AprobarDB(info, "GA");
                        }
                    }
                }

                AnularOCOrdenPedidoAnterior(IdEmpresa, IdOrdenPedido, IdUsuario, IdOrdenPedidoAnt);
                
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AnularOCOrdenPedidoAnterior(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario, decimal IdOrdenPedidoReg)
        {
            try
            {
                string query = "update com_ordencompra_local set Estado = 'I', oc_observacion = 'Regularizada con SOLPED # " + IdOrdenPedido.ToString() + " ' +oc_observacion, IdUsuarioUltAnu = '" + IdUsuario + "', FechaHoraAnul = GETDATE()"
                            + " FROM("
                            + " select E.IdEmpresa, E.IdSucursal, E.IdOrdenCompra"
                            + " from com_OrdenPedidoDet as a inner join"
                            + " com_OrdenPedidoDet as b on a.IdEmpresa = b.IdEmpresa and a.IdOrdenPedidoReg = b.IdOrdenPedido and a.SecuenciaReg = b.Secuencia inner join"
                            + " com_CotizacionPedidoDet as c on c.opd_IdEmpresa = b.IdEmpresa and c.opd_IdOrdenPedido = b.IdOrdenPedido and c.opd_Secuencia = b.Secuencia inner join"
                            + " com_CotizacionPedido as d on c.IdEmpresa = d.IdEmpresa and c.IdCotizacion = d.IdCotizacion inner join"
                            + " com_ordencompra_local as e on d.IdEmpresa = e.IdEmpresa and d.oc_IdOrdenCompra = E.IdOrdenCompra AND d.IdSucursal = e.IdSucursal"
                            + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.IdOrdenPedido = " + IdOrdenPedido.ToString()
                            + " GROUP BY E.IdEmpresa, E.IdSucursal, E.IdOrdenCompra"
                            + " ) A"
                            + " WHERE com_ordencompra_local.IdEmpresa = A.IdEmpresa"
                            + " AND com_ordencompra_local.IdSucursal = A.IdSucursal"
                            + " AND com_ordencompra_local.IdOrdenCompra = A.IdOrdenCompra";

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
