using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Business.Roles_Fj
{
    public class ro_parametro_x_pago_variable_tipo_Bus
    {
        string mensaje;

        ro_parametro_x_pago_variable_tipo_Data data = new ro_parametro_x_pago_variable_tipo_Data();

        public bool Modificar_DB(List<ro_parametro_x_pago_variable_tipo_Info> lista)
        {
            try
            {
                return data.Modificar_DB(lista);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public List<ro_parametro_x_pago_variable_tipo_Info> Get_lista_tipo_pago_variable(int IdEmpresa)
        {
            try
            {
                return data.Get_lista_tipo_pago_variable(IdEmpresa);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
    }
}
