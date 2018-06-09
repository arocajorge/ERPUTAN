using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Inventario
{
    public class vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Data OData = new vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Data();


        public List<vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Info> Get_List_In_Ajuste_fisico_x_relacion_inven_x_cbteCble
            (int IdEmpresa, decimal IdAjusteFisico, ref string mensaje)
        {
            try
            {
                return OData.Get_List_In_Ajuste_fisico_x_relacion_inven_x_cbteCble(IdEmpresa, IdAjusteFisico, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consultar_Relacion_Inven_Conta", ex.Message), ex) { EntityType = typeof(vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Bus) };

            }

        }
    }
}
