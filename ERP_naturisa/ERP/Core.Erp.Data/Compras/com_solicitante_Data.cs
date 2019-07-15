using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Data.Compras
{
   public class com_solicitante_Data
    {

        string mensaje = "";

        public decimal GetIdSolicitante(int IdEmpresa, ref string mensaje)
        {
            decimal Id = 0;
            try
            {
                EntitiesCompras contex = new EntitiesCompras();
                var selecte = contex.com_solicitante.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.com_solicitante
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdSolicitante).Max();
                    Id = Convert.ToDecimal(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(com_solicitante_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCompras Context = new EntitiesCompras())
                {
                    Context.com_solicitante.Add(new com_solicitante
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdSolicitante = info.IdSolicitante = GetIdSolicitante(info.IdEmpresa,ref mensaje),
                        IdDepartamento = info.IdDepartamento,
                        estado = "A",
                        nom_solicitante = info.nom_solicitante,
                        IdUsuario = info.IdUsuario,
                        ConsultaDepartamento = info.ConsultaDepartamento,
                        Fecha_Transac = DateTime.Now,
                        IdUsuarioUltMod =  info.IdUsuarioUltMod
                    });
                    int secuencia = 1;
                    foreach (var item in info.ListaDetalle)
                    {
                        Context.com_solicitante_aprobador.Add(new com_solicitante_aprobador
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdSolicitante = info.IdSolicitante,
                            IdUsuario = item.IdUsuario,
                            IdDepartamento = item.IdDepartamento,
                            MontoMax = item.MontoMax,
                            MontoMin = item.MontoMin,
                            Secuencia = secuencia++
                        });
                    }
                    secuencia = 1;
                    foreach (var item in info.ListaDepartamento)
                    {
                        Context.com_solicitante_x_com_departamento.Add(new com_solicitante_x_com_departamento
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdSolicitante = info.IdSolicitante,
                            Secuencia = secuencia++,
                            IdDepartamento = item.IdDepartamento
                        });
                    }
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(com_solicitante_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_solicitante.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdSolicitante == info.IdSolicitante);

                    if (contact != null)
                    {
                        contact.nom_solicitante = info.nom_solicitante;
                        contact.IdUsuario = info.IdUsuario;
                        contact.IdDepartamento = info.IdDepartamento;
                        contact.ConsultaDepartamento = info.ConsultaDepartamento;

                        var lst = context.com_solicitante_aprobador.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSolicitante == info.IdSolicitante).ToList();
                        foreach (var item in lst)
                        {
                            context.com_solicitante_aprobador.Remove(item);
                        }
                        
                        int secuencia = 1;
                        foreach (var item in info.ListaDetalle)
                        {
                            context.com_solicitante_aprobador.Add(new com_solicitante_aprobador
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdSolicitante = info.IdSolicitante,
                                IdUsuario = item.IdUsuario,
                                IdDepartamento = item.IdDepartamento,
                                MontoMax = item.MontoMax,
                                MontoMin = item.MontoMin,
                                Secuencia = secuencia++
                            });
                        }
                        var lstD = context.com_solicitante_x_com_departamento.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSolicitante == info.IdSolicitante).ToList();
                        foreach (var item in lstD)
                        {
                            context.com_solicitante_x_com_departamento.Remove(item);
                        }
                        secuencia = 1;
                        foreach (var item in info.ListaDepartamento)
                        {
                            context.com_solicitante_x_com_departamento.Add(new com_solicitante_x_com_departamento
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdSolicitante = info.IdSolicitante,
                                Secuencia = secuencia++,
                                IdDepartamento = item.IdDepartamento
                            });
                        }
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(com_solicitante_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_solicitante.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdSolicitante == info.IdSolicitante);

                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltMod;
                        contact.MotiAnula = info.MotiAnula;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.estado = "I";
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_solicitante_Info> Get_List_Solicitante(int IdEmpresa)
        {
            List<com_solicitante_Info> Lst;
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lst = db.vwcom_solicitante.Where(q => q.IdEmpresa == IdEmpresa).Select(q => new com_solicitante_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdSolicitante = q.IdSolicitante,
                        nom_solicitante = q.nom_solicitante,
                        nom_departamento = q.nom_departamento,
                        estado = q.estado,
                        SEstado = q.estado == "A" ? "ACTIVO" : "ANULADO",
                        IdUsuario = q.IdUsuario,
                        IdDepartamento = q.IdDepartamento,
                        ConsultaDepartamento = q.ConsultaDepartamento
                    }).ToList();
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public com_solicitante_Info GetInfo(int IdEmpresa, decimal IdSolicitante)
        {
            try
            {
                com_solicitante_Info info;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    info = db.com_solicitante.Where(q => q.IdEmpresa == IdEmpresa && q.IdSolicitante == IdSolicitante).Select(q => new com_solicitante_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdSolicitante = q.IdSolicitante,
                        nom_solicitante = q.nom_solicitante,
                        estado = q.estado,
                        IdUsuario = q.IdUsuario,
                        ConsultaDepartamento = q.ConsultaDepartamento
                    }).FirstOrDefault();
                }

                return info;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public com_solicitante_Info GetInfo(int IdEmpresa, string IdUsuario)
        {
            try
            {
                com_solicitante_Info info;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    info = db.com_solicitante.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario).Select(q => new com_solicitante_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdSolicitante = q.IdSolicitante,
                        nom_solicitante = q.nom_solicitante,
                        estado = q.estado,
                        IdUsuario = q.IdUsuario,
                        IdDepartamento = q.IdDepartamento,
                        ConsultaDepartamento = q.ConsultaDepartamento
                    }).FirstOrDefault();
                }

                return info;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
