using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.SeguridadAcceso
{
   public class seg_usuario_x_tb_sis_reporte_Data
    {

        public List<seg_usuario_x_tb_sis_reporte_Info> Get_List_Menu(string IdUsuario)
        {
            List<seg_usuario_x_tb_sis_reporte_Info> returnValue = new List<seg_usuario_x_tb_sis_reporte_Info>();
            try
            {
                EntitiesSeguAcceso OESeguridad = new EntitiesSeguAcceso();

                var selectMenu = from C in OESeguridad.vwseg_usuario_x_tb_sis_reporte
                                 where C.IdUsuario==IdUsuario
                                 select C;

                foreach (var item in selectMenu)
                {
                    seg_usuario_x_tb_sis_reporte_Info oM = new seg_usuario_x_tb_sis_reporte_Info();
                    oM.IdUsuario = item.IdUsuario;
                    oM.CodReporte = item.CodReporte;
                    oM.InfoReporte.Class_Bus = item.Class_Bus;
                    oM.InfoReporte.Class_Data = item.Class_Data;
                    oM.InfoReporte.Class_Info = item.Class_Info;
                    oM.InfoReporte.Class_NomReporte = item.Class_NomReporte;
                    oM.InfoReporte.CodReporte = item.CodReporte;
                    oM.InfoReporte.Estado = item.Estado;
                    oM.InfoReporte.Formulario = item.Formulario;
                    oM.InfoReporte.Modulo = item.Modulo;
                    oM.InfoReporte.nom_Asembly = item.nom_Asembly;
                    oM.InfoReporte.Nombre = item.Nombre;
                    oM.InfoReporte.NombreCorto = item.NombreCorto;
                    oM.InfoReporte.Observacion = item.Observacion;
                    oM.InfoReporte.Orden = item.Orden;
                    oM.InfoReporte.se_Muestra_Admin_Reporte = (item.se_Muestra_Admin_Reporte == null) ? false : Convert.ToBoolean(item.se_Muestra_Admin_Reporte);
                    oM.InfoReporte.Se_Muestra_Icono = true;
                    oM.InfoReporte.Tipo_Balance = item.Tipo_Balance;
                    oM.InfoReporte.VersionActual = 0;
                    oM.InfoReporte.VistaRpt = item.VistaRpt;
                    oM.InfoReporte.esta_en_base = (item.esta_en_base == null) ? false : Convert.ToBoolean(item.esta_en_base);

                    returnValue.Add(oM);
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
