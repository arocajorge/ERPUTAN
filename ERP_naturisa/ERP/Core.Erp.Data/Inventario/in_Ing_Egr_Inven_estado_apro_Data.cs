using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
    public class in_Ing_Egr_Inven_estado_apro_Data
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();


        public List<in_Ing_Egr_Inven_estado_apro_Info> Get_List_Ing_Egr_Inven_estado_apro()
        {
            try
            {
                List<in_Ing_Egr_Inven_estado_apro_Info> lstInfo = new List<in_Ing_Egr_Inven_estado_apro_Info>();
                using (EntitiesInventario listado = new EntitiesInventario())
                {
                    var select = from q in listado.in_Ing_Egr_Inven_estado_apro
                                 select q;

                    foreach (var item in select)
                    {
                        in_Ing_Egr_Inven_estado_apro_Info Info = new in_Ing_Egr_Inven_estado_apro_Info();
                        Info.IdEstadoAproba = item.IdEstadoAproba;
                        Info.Descripcion = item.Descripcion;
                        Info.estado = item.estado;
                        lstInfo.Add(Info);
                    }
                }

                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
