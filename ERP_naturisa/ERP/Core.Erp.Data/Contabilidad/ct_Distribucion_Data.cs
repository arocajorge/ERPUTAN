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

                    string query = "select IdEmpresa, IdDistribucion, Fecha, Observacion, Estado, IdTipoCbte, IdCbteCble"
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
                            IdCbteCble = Convert.ToDecimal(reader["IdCbteCble"])
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

                    string query = "select top 1 IdEmpresa, IdDistribucion, Fecha, Observacion, Estado, IdTipoCbte, IdCbteCble"
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
                            IdCbteCble = Convert.ToDecimal(reader["IdCbteCble"])
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

                    info.IdDistribucion = GetID(info.IdEmpresa);
                    string query = "Insert into ct_Distribucion ([IdEmpresa],[IdDistribucion],[Fecha],[Observacion],[Estado],[IdTipoCbte],[IdCbteCble],[IdUsuarioCreacion],[FechaCreacion], [IdCtaCble])"
                        + " values  ("+info.IdEmpresa.ToString()+","+info.IdDistribucion.ToString()+",DATEFROMPARTS("+info.Fecha.Year.ToString()+","+info.Fecha.Month.ToString()+","+info.Fecha.Day.ToString()+"),'"+info.Observacion+"',true,"+info.IdTipoCbte.ToString()+","+info.IdCbteCble.ToString()+",'"+info.IdUsuario+"',GETDATE(),"+(string.IsNullOrEmpty(info.IdCtaCble) ? "NULL" : "'"+info.IdCtaCble+"'")+");";
                    int Secuencia = 1;
                    foreach (var item in info.ListaDistribuido)
                    {
                        query += "INSERT INTO [dbo].[ct_DistribucionDetDistribuido]([IdEmpresa],[IdDistribucion],[Secuencia],[IdCtaCble],[IdCentroCosto_sub_centro_costo],[IdCentroCosto],[F1],[F2], [Observacion])"
                            + " VALUES(" + info.IdEmpresa.ToString() + "," + info.IdDistribucion.ToString() + "," + Secuencia.ToString() + ",'" + item.IdCtaCble + "'," + (string.IsNullOrEmpty(item.IdCentroCosto) ? "NULL" : "'" + item.IdCentroCosto + "'") + "," + (string.IsNullOrEmpty(item.IdCentroCosto_sub_centro_costo) ? "NULL" : "'" + item.IdCentroCosto_sub_centro_costo + "'") + "," + item.F1.ToString() + "," + item.F2.ToString() + ","+item.Observacion+");";
                        Secuencia++;
                    }
                    Secuencia = 1;
                    foreach (var item in info.ListaPorDistribuir)
                    {
                        query += "INSERT INTO [dbo].[ct_DistribucionDetPorDistribuir]([IdEmpresa],[IdDistribucion],[Secuencia],[IdCtaCble],[IdCentroCosto_sub_centro_costo],[IdCentroCosto],[Valor])"
                            + " VALUES(" + info.IdEmpresa.ToString() + "," + info.IdDistribucion.ToString() + "," + Secuencia.ToString() + ",'" + item.IdCtaCble + "'," + (string.IsNullOrEmpty(item.IdCentroCosto) ? "NULL" : "'" + item.IdCentroCosto + "'") + "," + (string.IsNullOrEmpty(item.IdCentroCosto_sub_centro_costo) ? "NULL" : "'" + item.IdCentroCosto_sub_centro_costo + "'") + "," + item.Valor.ToString() + ");";
                        Secuencia++;
                    }
                    
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
