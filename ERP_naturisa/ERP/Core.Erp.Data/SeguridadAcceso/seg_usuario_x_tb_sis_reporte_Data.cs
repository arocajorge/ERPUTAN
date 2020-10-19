using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.SqlClient;


namespace Core.Erp.Data.SeguridadAcceso
{
   public class seg_usuario_x_tb_sis_reporte_Data
    {

        public List<seg_usuario_x_tb_sis_reporte_Info> Get_List_Menu(string IdUsuario)
        {
            List<seg_usuario_x_tb_sis_reporte_Info> returnValue = new List<seg_usuario_x_tb_sis_reporte_Info>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select a.CodReporte, a.Nombre "
                                        +" from tb_sis_reporte as a inner join"
                                        +" seg_usuario_x_tb_sis_reporte as b on a.CodReporte = b.CodReporte"
                                        +" where a.se_Muestra_Admin_Reporte = 1 and a.Estado = 'A' and b.IdUsuario = '"+IdUsuario+"'";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnValue.Add(new seg_usuario_x_tb_sis_reporte_Info
                        {
                            CodReporte = Convert.ToString(reader["CodReporte"]),
                            InfoReporte = new tb_sis_reporte_Info
                            {
                                CodReporte = Convert.ToString(reader["CodReporte"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                                esta_en_base = true
                            }
                        });
                    }
                    command.CommandText = "select a.CodReporte, a.Nombre "
                                        +" from tb_sis_reporte as a "
                                        +" where a.se_Muestra_Admin_Reporte = 1 and a.Estado = 'A'"
                                        +" and NOT EXISTS("
                                        +" SELECT b.CodReporte FROM seg_usuario_x_tb_sis_reporte as b"
                                        +" where a.CodReporte = b.CodReporte and b.IdUsuario = '"+IdUsuario+"')";
                    reader.Close();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnValue.Add(new seg_usuario_x_tb_sis_reporte_Info
                        {
                            CodReporte = Convert.ToString(reader["CodReporte"]),
                            InfoReporte = new tb_sis_reporte_Info
                            {
                                CodReporte = Convert.ToString(reader["CodReporte"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                                esta_en_base = false
                            }
                        });
                    }
                    reader.Close();
                }

                return (returnValue);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref arreglo);
                throw new Exception(ex.ToString());
            }
        }

        public seg_usuario_x_tb_sis_reporte_Info Get_Info_Menu(string IdUsuario,string CodReporte, ref string MensajeError)
        {
            seg_usuario_x_tb_sis_reporte_Info info = new seg_usuario_x_tb_sis_reporte_Info();
            try
            {
                EntitiesSeguAcceso OESeguridad = new EntitiesSeguAcceso();

                var selectMenu = from C in OESeguridad.seg_usuario_x_tb_sis_reporte
                                 select C;

                foreach (var item in selectMenu)
                {
                    seg_usuario_x_tb_sis_reporte_Info oM = new seg_usuario_x_tb_sis_reporte_Info();
                    oM.IdUsuario = item.IdUsuario;
                    oM.CodReporte = item.CodReporte;
                    oM.observacion = item.observacion;
                    info = oM;
                }

                return info;
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }

        }

       
         public Boolean GrabarDB(seg_usuario_x_tb_sis_reporte_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    var address = new seg_usuario_x_tb_sis_reporte();

                    address.IdUsuario = info.IdUsuario;
                    address.CodReporte = info.CodReporte;
                    address.observacion = "";

                    context.seg_usuario_x_tb_sis_reporte.Add(address);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }


         public Boolean GrabarDB(List<seg_usuario_x_tb_sis_reporte_Info> ListInfo, ref string MensajeError)
         {
             try
             {

                 foreach (var item in ListInfo)
                 {
                     GrabarDB(item, ref MensajeError);
                 }

                 return true;
             }
             catch (Exception ex)
             {
                 string arreglo = ToString();
                 tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                 tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                 MensajeError = ex.ToString();
                 oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                 throw new Exception(ex.ToString());
             }
         }



         public Boolean EliminarDB(string IdUsuario, ref string MensajeError)
         {
             try
             {
                 using (EntitiesCompras Entity = new EntitiesCompras())
                 {
                     int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete from seg_usuario_x_tb_sis_reporte where IdUsuario='" + IdUsuario + "'");
                 }
                 
                 return true;
             }
             catch (Exception ex)
             {
                 string arreglo = ToString();
                 tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                 tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                 MensajeError = ex.ToString();
                 oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                 throw new Exception(ex.ToString());
             }
         }

     
        
    }
}
