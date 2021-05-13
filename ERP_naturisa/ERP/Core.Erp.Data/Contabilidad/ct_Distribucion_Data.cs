using Core.Erp.Info.Contabilidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_Distribucion_Data
    {
        ct_Cbtecble_Data odatact = new ct_Cbtecble_Data();
        string MensajeError = string.Empty;
        public List<ct_Distribucion_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;

                List<ct_Distribucion_Info> Lista = new List<ct_Distribucion_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    string query = "select IdEmpresa, IdDistribucion, Fecha, FechaDesde, FechaHasta , Observacion, Estado, IdTipoCbte, IdCbteCble, IdCtaCble"
                                + " from ct_Distribucion"
                                + " where IdEmpresa = " + IdEmpresa.ToString() + " and Fecha between DATEFROMPARTS(" + FechaIni.Year.ToString() + "," + FechaIni.Month.ToString() + "," + FechaIni.Day.ToString() + ") and DATEFROMPARTS(" + FechaFin.Year.ToString() + "," + FechaFin.Month.ToString() + "," + FechaFin.Day.ToString() + ")";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new ct_Distribucion_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdDistribucion = Convert.ToDecimal(reader["IdDistribucion"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Observacion = Convert.ToString(reader["Observacion"]),
                            Estado = Convert.ToBoolean(reader["Estado"]),
                            IdTipoCbte = Convert.ToInt32(reader["IdTipoCbte"]),
                            IdCbteCble = Convert.ToDecimal(reader["IdCbteCble"]),
                            FechaDesde = Convert.ToDateTime(reader["FechaDesde"]),
                            FechaHasta = Convert.ToDateTime(reader["FechaHasta"]),
                            IdCtaCble = reader["IdCtaCble"] == DBNull.Value ? null : reader["IdCtaCble"].ToString()
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

        public ct_Distribucion_Info GetInfo(int IdEmpresa, decimal IdDistribucion)
        {
            try
            {
                ct_Distribucion_Info info = new ct_Distribucion_Info();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    string query = "select top 1 IdEmpresa, IdDistribucion, Fecha, FechaDesde, FechaHasta, Observacion, Estado, IdTipoCbte, IdCbteCble"
                                + " from ct_Distribucion"
                                + " where IdEmpresa = " + IdEmpresa.ToString() + " and IdDistribucion = "+IdDistribucion.ToString();
                    SqlCommand command = new SqlCommand(query, connection);
                    var ValidateValue = command.ExecuteScalar();
                    if (ValidateValue == null)
                        return null;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        info = new ct_Distribucion_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdDistribucion = Convert.ToDecimal(reader["IdDistribucion"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Observacion = Convert.ToString(reader["Observacion"]),
                            Estado = Convert.ToBoolean(reader["Estado"]),
                            IdTipoCbte = Convert.ToInt32(reader["IdTipoCbte"]),
                            IdCbteCble = Convert.ToDecimal(reader["IdCbteCble"]),
                            FechaDesde = Convert.ToDateTime(reader["FechaDesde"]),
                            FechaHasta = Convert.ToDateTime(reader["FechaHasta"]),
                            IdCtaCble = reader["IdCtaCble"] == DBNull.Value ? null : reader["IdCtaCble"].ToString()
                        };
                    }
                    reader.Close();
                }

                return info;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public decimal GetID(int IdEmpresa)
        {
            try
            {
                decimal ID = 1;
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    string query = "select IdEmpresa, max(IdDistribucion) IdDistribucion"
                                + " from ct_Distribucion"
                                + " where IdEmpresa = " + IdEmpresa.ToString()
                                + " group by IdEmpresa";

                    SqlCommand command = new SqlCommand(query, connection);
                    var ValidateValue = command.ExecuteScalar();
                    if (ValidateValue == null)
                        return 1;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ID = Convert.ToDecimal(reader["IdDistribucion"]) + 1;
                    }
                    reader.Close();
                }
                return ID;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(ct_Distribucion_Info info)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    #region Diario
                    info.IdCbteCble = odatact.Get_IdCbteCble(info.IdEmpresa, info.IdTipoCbte, ref MensajeError);
                    command.CommandText = "INSERT INTO [dbo].[ct_cbtecble]([IdEmpresa],[IdTipoCbte],[IdCbteCble],[CodCbteCble],[IdPeriodo],[cb_Fecha],[cb_Valor],[cb_Observacion],[cb_Secuencia],[cb_Estado],[cb_Anio],[cb_mes]"
                                        + " ,[IdUsuario],[IdUsuarioAnu],[cb_MotivoAnu],[IdUsuarioUltModi],[cb_FechaAnu],[cb_FechaTransac],[cb_FechaUltModi],[cb_Mayorizado],[cb_para_conciliar],[IdSucursal])"
                                        + " VALUES("+info.IdEmpresa.ToString()+","+info.IdTipoCbte.ToString()+","+info.IdCbteCble.ToString()+",'',"+info.Fecha.ToString("yyyyMM").ToString()+",DATEFROMPARTS("+info.Fecha.Year.ToString()+","+info.Fecha.Month.ToString()+","+info.Fecha.Day.ToString()+"),"+info.ListaDiario.Where(q=> q.dc_Valor > 0).Sum(q=> q.dc_Valor).ToString()+",'"+info.Observacion+"',0,'A',"+info.Fecha.Year.ToString()+","+info.Fecha.Month.ToString()
                                        + " ,'"+info.IdUsuario+"',NULL,NULL,NULL,NULL,GETDATE(),NULL,0,0,1);";
                    command.ExecuteNonQuery();
                    int Secuencia = 1;
                    command.CommandText = string.Empty;
                    foreach (var item in info.ListaDiario)
                    {
                        command.CommandText += "INSERT INTO [dbo].[ct_cbtecble_det]"
                                            +" ([IdEmpresa],[IdTipoCbte],[IdCbteCble],[secuencia],[IdCtaCble],[IdCentroCosto],[IdCentroCosto_sub_centro_costo],[dc_Valor],[dc_Observacion],[dc_Numconciliacion],[dc_EstaConciliado],[IdPunto_cargo],[IdPunto_cargo_grupo],[dc_para_conciliar])"
                                            +" VALUES("+info.IdEmpresa.ToString()+","+info.IdTipoCbte.ToString()+","+info.IdCbteCble.ToString()+","+Secuencia.ToString()+",'"+item.IdCtaCble+"',"+(string.IsNullOrEmpty(item.IdCentroCosto) ? "NULL" : "'"+item.IdCentroCosto+"'")+","+(string.IsNullOrEmpty(item.IdCentroCosto_sub_centro_costo) ? "NULL" : "'"+item.IdCentroCosto_sub_centro_costo+"'")+","+item.dc_Valor.ToString()+",'"+item.dc_Observacion+"',NULL,NULL,"+(item.IdPunto_cargo == null ? "NULL" : item.IdPunto_cargo.ToString())+","+(item.IdPunto_cargo_grupo == null ? "NULL" : item.IdPunto_cargo_grupo.ToString())+",NULL);";
                        Secuencia++;
                    }
                    command.ExecuteNonQuery();
                    #endregion
                    command.CommandText = string.Empty;
                    #region Distribucion
                    info.IdDistribucion = GetID(info.IdEmpresa);
                    command.CommandText += "Insert into ct_Distribucion ([IdEmpresa],[IdDistribucion],[Fecha], FechaDesde, FechaHasta,[Observacion],[Estado],[IdTipoCbte],[IdCbteCble],[IdUsuarioCreacion],[FechaCreacion], [IdCtaCble])"
                        + " values  (" + info.IdEmpresa.ToString() + "," + info.IdDistribucion.ToString() + ",DATEFROMPARTS(" + info.Fecha.Year.ToString() + "," + info.Fecha.Month.ToString() + "," + info.Fecha.Day.ToString() + "),DATEFROMPARTS(" + info.FechaDesde.Year.ToString() + "," + info.FechaDesde.Month.ToString() + "," + info.FechaDesde.Day.ToString() + "), DATEFROMPARTS(" + info.FechaHasta.Year.ToString() + "," + info.FechaHasta.Month.ToString() + "," + info.FechaHasta.Day.ToString() + "),'" + info.Observacion + "',1," + info.IdTipoCbte.ToString() + "," + info.IdCbteCble.ToString() + ",'" + info.IdUsuario + "',GETDATE()," + (string.IsNullOrEmpty(info.IdCtaCble) ? "NULL" : "'" + info.IdCtaCble + "'") + ");";
                    Secuencia = 1;
                    foreach (var item in info.ListaDistribuido)
                    {
                        command.CommandText += "INSERT INTO [dbo].[ct_DistribucionDetDistribuido]([IdEmpresa],[IdDistribucion],[Secuencia],[IdCtaCble],[IdCentroCosto],[IdCentroCosto_sub_centro_costo],[F1],[F2], [Observacion])"
                            + " VALUES(" + info.IdEmpresa.ToString() + "," + info.IdDistribucion.ToString() + "," + Secuencia.ToString() + ",'" + item.IdCtaCble + "'," + (string.IsNullOrEmpty(item.IdCentroCosto) ? "NULL" : "'" + item.IdCentroCosto + "'") + "," + (string.IsNullOrEmpty(item.IdCentroCosto_sub_centro_costo) ? "NULL" : "'" + item.IdCentroCosto_sub_centro_costo + "'") + "," + item.F1.ToString() + "," + item.F2.ToString() + ",'" + item.Observacion + "');";
                        Secuencia++;
                    }
                    Secuencia = 1;
                    foreach (var item in info.ListaPorDistribuir)
                    {
                        command.CommandText += "INSERT INTO [dbo].[ct_DistribucionDetPorDistribuir]([IdEmpresa],[IdDistribucion],[Secuencia],[IdCtaCble],[IdCentroCosto],[IdCentroCosto_sub_centro_costo],[Valor])"
                            + " VALUES(" + info.IdEmpresa.ToString() + "," + info.IdDistribucion.ToString() + "," + Secuencia.ToString() + ",'" + item.IdCtaCble + "'," + (string.IsNullOrEmpty(item.IdCentroCosto) ? "NULL" : "'" + item.IdCentroCosto + "'") + "," + (string.IsNullOrEmpty(item.IdCentroCosto_sub_centro_costo) ? "NULL" : "'" + item.IdCentroCosto_sub_centro_costo + "'") + "," + item.Valor.ToString() + ");";
                        Secuencia++;
                    }
                    #endregion
                    
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public bool ModificarDB(ct_Distribucion_Info info)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    #region Diario
                    command.CommandText += "UPDATE [dbo].[ct_cbtecble]"
                                        +" SET [IdPeriodo] = "+info.Fecha.ToString("yyyyMM")
                                        +" ,[cb_Fecha] = DATEFROMPARTS("+info.Fecha.Year.ToString()+","+info.Fecha.Month.ToString()+","+info.Fecha.Day.ToString()+")"
                                        +" ,[cb_Valor] = "+info.ListaDiario.Where(q=> q.dc_Valor > 0).Sum(q=> q.dc_Valor).ToString()
                                        +" ,[cb_Observacion] = '"+info.Observacion+"'"
                                        +" ,[cb_Anio] = "+info.Fecha.Year.ToString()
                                        +" ,[cb_mes] = "+info.Fecha.Month.ToString()
                                        +" ,[IdUsuarioUltModi] = '"+info.IdUsuario+"'"
                                        +" ,[cb_FechaUltModi] = GETDATE()"
                                        +" WHERE IdEmpresa = "+info.IdEmpresa.ToString()+" AND IdTipoCbte = "+info.IdTipoCbte.ToString()+" AND IdCbteCble = "+info.IdCbteCble.ToString()+";";

                    command.CommandText += "DELETE [dbo].[ct_cbtecble_det]  WHERE IdEmpresa = " + info.IdEmpresa.ToString() + " AND IdTipoCbte = " + info.IdTipoCbte.ToString() + " AND IdCbteCble = " + info.IdCbteCble.ToString() + ";";
                    int Secuencia = 1;
                    foreach (var item in info.ListaDiario)
                    {
                        command.CommandText += " INSERT INTO [dbo].[ct_cbtecble_det]"
                                            +" ([IdEmpresa],[IdTipoCbte],[IdCbteCble],[secuencia],[IdCtaCble],[IdCentroCosto],[IdCentroCosto_sub_centro_costo],[dc_Valor],[dc_Observacion],[dc_Numconciliacion],[dc_EstaConciliado],[IdPunto_cargo],[IdPunto_cargo_grupo],[dc_para_conciliar])"
                                            +" VALUES("+info.IdEmpresa.ToString()+","+info.IdTipoCbte.ToString()+","+info.IdCbteCble.ToString()+","+Secuencia.ToString()+",'"+item.IdCtaCble+"',"+(string.IsNullOrEmpty(item.IdCentroCosto) ? "NULL" : "'"+item.IdCentroCosto+"'")+","+(string.IsNullOrEmpty(item.IdCentroCosto_sub_centro_costo) ? "NULL" : "'"+item.IdCentroCosto_sub_centro_costo+"'")+","+item.dc_Valor.ToString()+",'"+item.dc_Observacion+"',NULL,NULL,"+(item.IdPunto_cargo == null ? "NULL" : item.IdPunto_cargo.ToString())+","+(item.IdPunto_cargo_grupo == null ? "NULL" : item.IdPunto_cargo_grupo.ToString())+",NULL);";
                        Secuencia++;
                    }                     
                    #endregion
                    

                    #region Distribucion
                    command.CommandText += "UPDATE [dbo].[ct_Distribucion]"
                                        + " SET [Fecha] = DATEFROMPARTS(" + info.Fecha.Year.ToString() + "," + info.Fecha.Month.ToString() + "," + info.Fecha.Day.ToString() + ")"
                                        + " ,[FechaDesde] = DATEFROMPARTS(" + info.FechaDesde.Year.ToString() + "," + info.FechaDesde.Month.ToString() + "," + info.FechaDesde.Day.ToString() + ")"
                                        + " ,[FechaHasta] = DATEFROMPARTS(" + info.FechaHasta.Year.ToString() + "," + info.FechaHasta.Month.ToString() + "," + info.FechaHasta.Day.ToString() + ")"
                                        + " ,[Observacion] = '" + info.Observacion + "'"
                                        + " ,[IdCtaCble] = " + (string.IsNullOrEmpty(info.IdCtaCble) ? "NULL" : "'" + info.IdCtaCble + "'")
                                        + " ,[IdUsuarioModificacion] = '" + info.IdUsuario + "'"
                                        + " ,[FechaModificacion] = GETDATE()"
                                        + " WHERE [IdEmpresa] = " + info.IdEmpresa.ToString() + " and [IdDistribucion] = " + info.IdDistribucion.ToString()+";";
                    
                    command.CommandText += "DELETE [dbo].[ct_DistribucionDetDistribuido] WHERE [IdEmpresa] = " + info.IdEmpresa.ToString() + " and [IdDistribucion] = " + info.IdDistribucion.ToString()+";";
                    command.CommandText += "DELETE [dbo].[ct_DistribucionDetPorDistribuir] WHERE [IdEmpresa] = " + info.IdEmpresa.ToString() + " and [IdDistribucion] = " + info.IdDistribucion.ToString() + ";";

                    Secuencia = 1;
                    foreach (var item in info.ListaDistribuido)
                    {
                        command.CommandText += "INSERT INTO [dbo].[ct_DistribucionDetDistribuido]([IdEmpresa],[IdDistribucion],[Secuencia],[IdCtaCble],[IdCentroCosto], [IdCentroCosto_sub_centro_costo],[F1],[F2], [Observacion])"
                            + " VALUES(" + info.IdEmpresa.ToString() + "," + info.IdDistribucion.ToString() + "," + Secuencia.ToString() + ",'" + item.IdCtaCble + "'," + (string.IsNullOrEmpty(item.IdCentroCosto) ? "NULL" : "'" + item.IdCentroCosto + "'") + "," + (string.IsNullOrEmpty(item.IdCentroCosto_sub_centro_costo) ? "NULL" : "'" + item.IdCentroCosto_sub_centro_costo + "'") + "," + item.F1.ToString() + "," + item.F2.ToString() + ",'" + item.Observacion + "');";
                        Secuencia++;
                    }
                    Secuencia = 1;
                    foreach (var item in info.ListaPorDistribuir)
                    {
                        command.CommandText += "INSERT INTO [dbo].[ct_DistribucionDetPorDistribuir]([IdEmpresa],[IdDistribucion],[Secuencia],[IdCtaCble],[IdCentroCosto], [IdCentroCosto_sub_centro_costo],[Valor])"
                            + " VALUES(" + info.IdEmpresa.ToString() + "," + info.IdDistribucion.ToString() + "," + Secuencia.ToString() + ",'" + item.IdCtaCble + "'," + (string.IsNullOrEmpty(item.IdCentroCosto) ? "NULL" : "'" + item.IdCentroCosto + "'") + "," + (string.IsNullOrEmpty(item.IdCentroCosto_sub_centro_costo) ? "NULL" : "'" + item.IdCentroCosto_sub_centro_costo + "'") + "," + item.Valor.ToString() + ");";
                        Secuencia++;
                    }

                    #endregion
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool AnularDB(ct_Distribucion_Info info)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "UPDATE [dbo].[ct_Distribucion]"
                                        + " SET [Estado] = 0"
                                        + " ,[IdUsuarioAnulacion] = '" + info.IdUsuario + "'"
                                        + " ,[FechaAnulacion] = GETDATE()"
                                        + " WHERE IdEmpresa = " + info.IdEmpresa.ToString() + " AND IdDistribucion = " + info.IdDistribucion.ToString() + ";";

                    decimal IdCbteCble_rev = 0;
                    odatact.ReversoCbteCble(info.IdEmpresa,
                        info.IdCbteCble,
                        info.IdTipoCbte,
                        1,
                        ref IdCbteCble_rev,
                        ref MensajeError,
                        info.IdUsuario,
                        info.IdUsuario
                    );

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
