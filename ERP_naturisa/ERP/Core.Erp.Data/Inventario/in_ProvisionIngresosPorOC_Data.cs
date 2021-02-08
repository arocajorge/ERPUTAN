using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Contabilidad;

namespace Core.Erp.Data.Inventario
{
    public class in_ProvisionIngresosPorOC_Data
    {
        ct_Cbtecble_Data odatact = new ct_Cbtecble_Data();
        string MensajeError = string.Empty;
        public List<in_ProvisionIngresosPorOC_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<in_ProvisionIngresosPorOC_Info> Lista = new List<in_ProvisionIngresosPorOC_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select IdEmpresa,IdProvision,IdCtaCble,Fecha,Observacion,IdTipoCbte,IdCbteCble,FechaIni,FechaFin,Estado "
                                        +" from in_ProvisionIngresosPorOC"
                                        + " where IdEmpresa = " + IdEmpresa.ToString() + " and Fecha between DATEFROMPARTS("+FechaIni.Year.ToString()+","+FechaIni.Month.ToString()+","+FechaIni.Day.ToString()+") and DATEFROMPARTS("+FechaFin.Year.ToString()+","+FechaFin.Month.ToString()+","+FechaFin.Day.ToString()+")";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new in_ProvisionIngresosPorOC_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdProvision = Convert.ToDecimal(reader["IdProvision"]),
                            IdCtaCble = Convert.ToString(reader["IdCtaCble"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Observacion = Convert.ToString(reader["Observacion"]),
                            IdTipoCbte = Convert.ToInt32(reader["IdTipoCbte"]),
                            IdCbteCble = Convert.ToDecimal(reader["IdCbteCble"]),
                            FechaIni = Convert.ToDateTime(reader["FechaIni"]),
                            FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                            Estado = Convert.ToBoolean(reader["Estado"])
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

        private decimal GetID(int IdEmpresa)
        {
            try
            {
                decimal ID = 1;

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select IdEmpresa,max(IdProvision) IdProvision"
                                        +" from in_ProvisionIngresosPorOC"
                                        +" where IdEmpresa = "+IdEmpresa.ToString()
                                        +" group by IdEmpresa";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ID = Convert.ToDecimal(reader["IdProvision"]) + 1;
                    }
                }

                return ID;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public in_ProvisionIngresosPorOC_Info GetInfo(int IdEmpresa, decimal IdProvision)
        {
            try
            {
                in_ProvisionIngresosPorOC_Info info = new in_ProvisionIngresosPorOC_Info();
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select IdEmpresa,IdProvision,IdCtaCble,Fecha,Observacion,IdTipoCbte,IdCbteCble,FechaIni,FechaFin,Estado "
                                        + " from in_ProvisionIngresosPorOC"
                                        + " where IdEmpresa = " + IdEmpresa.ToString() + " and IdProvision = "+IdProvision.ToString();

                    var ResultValue = command.ExecuteScalar();
                    if (ResultValue == null)
                        return null;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        info = new in_ProvisionIngresosPorOC_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdProvision = Convert.ToDecimal(reader["IdProvision"]),
                            IdCtaCble = Convert.ToString(reader["IdCtaCble"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Observacion = Convert.ToString(reader["Observacion"]),
                            IdTipoCbte = Convert.ToInt32(reader["IdTipoCbte"]),
                            IdCbteCble = Convert.ToDecimal(reader["IdCbteCble"]),
                            FechaIni = Convert.ToDateTime(reader["FechaIni"]),
                            FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                            Estado = Convert.ToBoolean(reader["Estado"])
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

        public bool GuardarDB(in_ProvisionIngresosPorOC_Info info)
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
                                        + " VALUES(" + info.IdEmpresa.ToString() + "," + info.IdTipoCbte.ToString() + "," + info.IdCbteCble.ToString() + ",''," + info.Fecha.ToString("yyyyMM").ToString() + ",DATEFROMPARTS(" + info.Fecha.Year.ToString() + "," + info.Fecha.Month.ToString() + "," + info.Fecha.Day.ToString() + ")," + info.ListaDiario.Where(q => q.dc_Valor > 0).Sum(q => q.dc_Valor).ToString() + ",'" + info.Observacion + "',0,'A'," + info.Fecha.Year.ToString() + "," + info.Fecha.Month.ToString()
                                        + " ,'" + info.IdUsuario + "',NULL,NULL,NULL,NULL,GETDATE(),NULL,0,0,1);";
                    command.ExecuteNonQuery();
                    int Secuencia = 1;
                    command.CommandText = string.Empty;
                    foreach (var item in info.ListaDiario)
                    {
                        command.CommandText += "INSERT INTO [dbo].[ct_cbtecble_det]"
                                            + " ([IdEmpresa],[IdTipoCbte],[IdCbteCble],[secuencia],[IdCtaCble],[IdCentroCosto],[IdCentroCosto_sub_centro_costo],[dc_Valor],[dc_Observacion],[dc_Numconciliacion],[dc_EstaConciliado],[IdPunto_cargo],[IdPunto_cargo_grupo],[dc_para_conciliar])"
                                            + " VALUES(" + info.IdEmpresa.ToString() + "," + info.IdTipoCbte.ToString() + "," + info.IdCbteCble.ToString() + "," + Secuencia.ToString() + ",'" + item.IdCtaCble + "'," + (string.IsNullOrEmpty(item.IdCentroCosto) ? "NULL" : "'" + item.IdCentroCosto + "'") + "," + (string.IsNullOrEmpty(item.IdCentroCosto_sub_centro_costo) ? "NULL" : "'" + item.IdCentroCosto_sub_centro_costo + "'") + "," + item.dc_Valor.ToString() + ",'" + item.dc_Observacion + "',NULL,NULL," + (item.IdPunto_cargo == null ? "NULL" : item.IdPunto_cargo.ToString()) + "," + (item.IdPunto_cargo_grupo == null ? "NULL" : item.IdPunto_cargo_grupo.ToString()) + ",NULL);";
                        Secuencia++;
                    }
                    command.ExecuteNonQuery();
                    #endregion

                    #region Provision
                    info.IdProvision = GetID(info.IdEmpresa);
                    command.CommandText = "INSERT INTO [dbo].[in_ProvisionIngresosPorOC]([IdEmpresa],[IdProvision],[IdCtaCble],[Fecha],[Observacion],[IdTipoCbte],[IdCbteCble],[FechaIni],[FechaFin],[Estado],[IdUsuarioCreacion],[FechaCreacion])"
                    + " VALUES(" + info.IdEmpresa.ToString() + "," + info.IdProvision.ToString() + ",'" + info.IdCtaCble + "',DATEFROMPARTS(" + info.Fecha.Year.ToString() + "," + info.Fecha.Month.ToString() + "," + info.Fecha.Day.ToString() + "),'" + info.Observacion + "'," + info.IdTipoCbte.ToString() + "," + info.IdCbteCble.ToString() + ",DATEFROMPARTS(" + info.FechaIni.Year.ToString() + "," + info.FechaIni.Month.ToString() + "," + info.FechaIni.Day.ToString() + "),DATEFROMPARTS(" + info.FechaFin.Year.ToString() + "," + info.FechaFin.Month.ToString() + "," + info.FechaFin.Day.ToString() + "),1,'" + info.IdUsuario + "',GETDATE())";
                    command.ExecuteNonQuery();
                    Secuencia = 1;
                    command.CommandText = string.Empty;
                    foreach (var item in info.ListaDetalle)
                    {
                        command.CommandText += "INSERT INTO [dbo].[in_ProvisionIngresosPorOCDet]([IdEmpresa],[IdProvision],[Secuencia],[IdSucursal],[IdMovi_inven_tipo],[IdNumMovi],[Secuencia_inv],[Costo])"
                                            +" VALUES("+info.IdEmpresa.ToString()+","+info.IdProvision.ToString()+","+(Secuencia++).ToString()+","+item.IdSucursal.ToString()+","+item.IdMovi_inven_tipo.ToString()+","+item.IdNumMovi.ToString()+","+item.Secuencia_inv.ToString()+","+item.Costo.ToString()+");";
                    }
                    command.ExecuteNonQuery();
                    #endregion
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ModificarDB(in_ProvisionIngresosPorOC_Info info)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    #region Diario
                    command.CommandText = "UPDATE [dbo].[ct_cbtecble]"
                                        + " SET [IdPeriodo] = "+info.Fecha.ToString("yyyyMM")
                                        + " ,[cb_Fecha] = datefromparts("+info.Fecha.Year.ToString()+","+info.Fecha.Month.ToString()+","+info.Fecha.Day.ToString()+")"
                                        + " ,[cb_Valor] = "+info.ListaDiario.Sum(q=> q.dc_Valor_D).ToString()
                                        + " ,[cb_Observacion] = '"+info.Observacion+"'"
                                        + " ,[cb_Anio] = "+info.Fecha.Year.ToString()
                                        + " ,[cb_mes] = "+info.Fecha.Month.ToString()
                                        + " ,[IdUsuarioUltModi] = '"+info.IdUsuario+"'"
                                        + " ,[cb_FechaUltModi] = GETDATE()"
                                        + " WHERE IdEmpresa = "+info.IdEmpresa.ToString()+" AND IdTipoCbte = "+info.IdTipoCbte.ToString()+" AND IdCbteCble = "+info.IdCbteCble.ToString()+";";

                    command.CommandText += "DELETE [dbo].[ct_cbtecble_det] WHERE IdEmpresa = " + info.IdEmpresa.ToString() + " AND IdTipoCbte = " + info.IdTipoCbte.ToString() + " AND IdCbteCble = " + info.IdCbteCble.ToString() + ";";
                    int Secuencia = 1;
                    command.CommandText = string.Empty;
                    foreach (var item in info.ListaDiario)
                    {
                        command.CommandText += "INSERT INTO [dbo].[ct_cbtecble_det]"
                                            + " ([IdEmpresa],[IdTipoCbte],[IdCbteCble],[secuencia],[IdCtaCble],[IdCentroCosto],[IdCentroCosto_sub_centro_costo],[dc_Valor],[dc_Observacion],[dc_Numconciliacion],[dc_EstaConciliado],[IdPunto_cargo],[IdPunto_cargo_grupo],[dc_para_conciliar])"
                                            + " VALUES(" + info.IdEmpresa.ToString() + "," + info.IdTipoCbte.ToString() + "," + info.IdCbteCble.ToString() + "," + Secuencia.ToString() + ",'" + item.IdCtaCble + "'," + (string.IsNullOrEmpty(item.IdCentroCosto) ? "NULL" : "'" + item.IdCentroCosto + "'") + "," + (string.IsNullOrEmpty(item.IdCentroCosto_sub_centro_costo) ? "NULL" : "'" + item.IdCentroCosto_sub_centro_costo + "'") + "," + item.dc_Valor.ToString() + ",'" + item.dc_Observacion + "',NULL,NULL," + (item.IdPunto_cargo == null ? "NULL" : item.IdPunto_cargo.ToString()) + "," + (item.IdPunto_cargo_grupo == null ? "NULL" : item.IdPunto_cargo_grupo.ToString()) + ",NULL);";
                        Secuencia++;
                    }
                    #endregion

                    #region Provision

                    command.CommandText += "UPDATE [dbo].[in_ProvisionIngresosPorOC]"
                                        +" SET [IdCtaCble] = '"+info.IdCtaCble+"'"
                                        +" [Fecha] = DATEFROMPARTS("+info.Fecha.Year.ToString()+","+info.Fecha.Month.ToString()+","+info.Fecha.Day.ToString()+")"
                                        +" ,[Observacion] = '"+info.Observacion+"'"
                                        +" ,[FechaIni] = DATEFROMPARTS("+info.FechaIni.Year.ToString()+","+info.FechaIni.Month.ToString()+","+info.FechaIni.Day.ToString()+")"
                                        + " ,[FechaFin] = DATEFROMPARTS(" + info.FechaFin.Year.ToString() + "," + info.FechaFin.Month.ToString() + "," + info.FechaFin.Day.ToString() + ")"
                                        +" ,[IdUsuarioMod] = '"+info.IdUsuario+"'"
                                        +" ,[FechaModificacion] = GETDATE()"
                                        +" WHERE IdEmpresa = "+info.IdEmpresa.ToString()+" and idprovision = "+info.IdProvision.ToString()+";";
                    
                    Secuencia = 1;
                    command.CommandText = string.Empty;
                    command.CommandText += "DELETE [dbo].[in_ProvisionIngresosPorOCDet] WHERE IdEmpresa = " + info.IdEmpresa.ToString() + " and idprovision = " + info.IdProvision.ToString() + ";";
                    foreach (var item in info.ListaDetalle)
                    {
                        command.CommandText += "INSERT INTO [dbo].[in_ProvisionIngresosPorOCDet]([IdEmpresa],[IdProvision],[Secuencia],[IdSucursal],[IdMovi_inven_tipo],[IdNumMovi],[Secuencia_inv],[Costo])"
                                            + " VALUES(" + info.IdEmpresa.ToString() + "," + info.IdProvision.ToString() + "," + (Secuencia++).ToString() + "," + item.IdSucursal.ToString() + "," + item.IdMovi_inven_tipo.ToString() + "," + item.IdNumMovi.ToString() + "," + item.Secuencia_inv.ToString() + "," + item.Costo.ToString() + ");";
                    }
                    command.ExecuteNonQuery();
                    #endregion
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AnularDB(in_ProvisionIngresosPorOC_Info info)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "UPDATE [dbo].[in_ProvisionIngresosPorOC]"
                                        + " SET  Estado = 0"
                                        + " ,[IdUsuarioAnulacion] = '" + info.IdUsuario + "'"
                                        + " ,[FechaAnulacion] = GETDATE()"
                                        + " WHERE IdEmpresa = " + info.IdEmpresa.ToString() + " and idprovision = " + info.IdProvision.ToString() + ";";

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
