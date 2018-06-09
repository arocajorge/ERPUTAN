using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;


namespace Core.Erp.Data.General
{
    public class vwtb_Ubicacion_Geografica_Data
    {
        string mensaje = "";

        public List<vwtb_Ubicacion_Geografica_Info> Get_List_Ubicacion_Geo()
        {
            try
            {
                List<vwtb_Ubicacion_Geografica_Info> lstInfo = new List<vwtb_Ubicacion_Geografica_Info>();

                using (EntitiesGeneral listado = new EntitiesGeneral())
                {
                    var select = from q in listado.vwtb_Ubicacion_Geografica
                                 select q;

                    foreach (var item in select)
                    {
                        vwtb_Ubicacion_Geografica_Info Info = new vwtb_Ubicacion_Geografica_Info();
                        Info.ID = item.Id;
                        Info.IdPadre = item.IdPadre;
                        Info.Codigo = item.Codigo;
                        Info.Nombre = item.Nombre;
                        Info.Nacionalidad = item.Nacionalidad;
                        Info.Estado = item.Estado;
                        Info.Nivel = item.Nivel;
                        Info.IdProvincia = item.IdProvincia;
                        Info.IdCiudad = item.IdCiudad;
                        Info.IdPais = item.IdPais;
                        lstInfo.Add(Info);
                    }
                }

                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
