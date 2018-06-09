using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
namespace Core.Erp.Business.CuentasxPagar
{

    public class cp_trans_a_generar_x_FormaPago_OP_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
            string mensaje="";
        cp_trans_a_generar_x_FormaPago_OP_Data data = new cp_trans_a_generar_x_FormaPago_OP_Data();
        public List<cp_trans_a_generar_x_FormaPago_OP_Info> Get_List_trans_a_generar_x_FormaPago_OP()
        {
            try
            {
                return data.Get_List_trans_a_generar_x_FormaPago_OP();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_trans_a_generar_x_FormaPago_OP", ex.Message), ex) { EntityType = typeof(cp_trans_a_generar_x_FormaPago_OP_Bus) };
            }
        }

        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                return data.ValidarCodigoExiste(Cod);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(cp_trans_a_generar_x_FormaPago_OP_Bus) };
            }

        }

        public Boolean ModificarDB(List<cp_trans_a_generar_x_FormaPago_OP_Info> lst)
        {
            try
            {
                return data.ModificarDB(lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_trans_a_generar_x_FormaPago_OP_Bus) };
            }
        }
        public cp_trans_a_generar_x_FormaPago_OP_Info Get_Info_trans_a_generar_x_FormaPago_OP(string IdTipoTransaccion)
        {
            try
            {
                return data.Get_Info_trans_a_generar_x_FormaPago_OP(IdTipoTransaccion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_trans_a_generar_x_FormaPago_OP", ex.Message), ex) { EntityType = typeof(cp_trans_a_generar_x_FormaPago_OP_Bus) };
            }
        }
        public Boolean Guardar(cp_trans_a_generar_x_FormaPago_OP_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_trans_a_generar_x_FormaPago_OP_Bus) };
            }
        }

        public Boolean ModificarDB(cp_trans_a_generar_x_FormaPago_OP_Info Info)
        {
            try
            {
                return data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_trans_a_generar_x_FormaPago_OP_Bus) };
            }
        }
    }
}
