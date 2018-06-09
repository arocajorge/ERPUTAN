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
    public class ro_Calculo_Pago_Variable_Porcentaje_Bus
    {
        string mensaje;
        ro_Calculo_Pago_Variable_Porcentaje_Data oData = new ro_Calculo_Pago_Variable_Porcentaje_Data();

        public ro_Calculo_Pago_Variable_Porcentaje_Info Get_Info_Calculo_Pago_Porcentaje(int IdEmpresa, int IdTipo_Nomina)
        {
            try
            {
                return oData.Get_Info_Calculo_Pago_Porcentaje(IdEmpresa, IdTipo_Nomina);
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<ro_Calculo_Pago_Variable_Porcentaje_Info> Get_List_Calculo_Pago_Porcentaje(int IdEmpresa, int IdTipo_Nomina)
        {
            try
            {
                return oData.Get_List_Calculo_Pago_Porcentaje(IdEmpresa, IdTipo_Nomina);
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int Get_Id(int IdEmpresa, int IdTipo_Nomina, ref string mensaje)
        {
            try
            {
                return oData.Get_Id(IdEmpresa, IdTipo_Nomina, ref mensaje);
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(ro_Calculo_Pago_Variable_Porcentaje_Info Info, int IdTipo_Nomina, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Info, IdTipo_Nomina, ref mensaje);
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(List<ro_Calculo_Pago_Variable_Porcentaje_Info> List_Info, int IdTipo_Nomina, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(List_Info, IdTipo_Nomina, ref mensaje);
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(int IdEmpresa, int IdTipo_Nomina, List<ro_Calculo_Pago_Variable_Porcentaje_Info> List_Info, ref string mensaje)
        {
            try
            {
                Boolean resGrabar = false;
                resGrabar = EliminarDB(IdEmpresa, IdTipo_Nomina, ref mensaje);
                resGrabar = GuardarDB(List_Info, IdTipo_Nomina, ref mensaje);
                return resGrabar;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(ro_Calculo_Pago_Variable_Porcentaje_Info Info, ref string mensaje)
        {
            try
            {
                return oData.AnularDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool EliminarDB(int IdEmpresa, int IdTipo_Nomina, ref string mensaje)
        {
            try
            {
                return oData.EliminarDB(IdEmpresa, IdTipo_Nomina, ref mensaje);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
