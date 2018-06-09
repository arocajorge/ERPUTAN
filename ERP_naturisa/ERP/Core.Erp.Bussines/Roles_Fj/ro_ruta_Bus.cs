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
    public class ro_ruta_Bus
    {
        string mensaje;
        ro_ruta_Data oData = new ro_ruta_Data();

        public List<ro_ruta_Info> Get_List_Ruta(int IdEmpresa)
        {
            try
            {
                return oData.Get_List_Ruta(IdEmpresa);
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

        public List<ro_ruta_Info> Get_List_Ruta(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                return oData.Get_List_Ruta(IdEmpresa, FechaIni, FechaFin, ref mensaje);
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

        public ro_ruta_Info Get_Info_Ruta(int IdEmpresa, int IdRuta)
        {
            try
            {
                return oData.Get_Info_Ruta(IdEmpresa, IdRuta);
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

        public bool GuardarDB(ro_ruta_Info Info, ref int IdRuta, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Info, ref IdRuta, ref mensaje);
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

        public bool ModificarDB(ro_ruta_Info Info, ref string mensaje)
        {
            try
            {
                return oData.ModificarDB(Info, ref mensaje);
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

        public bool AnularDB(ro_ruta_Info Info, ref string mensaje)
        {
            try
            {
                return oData.AnularDB(Info, ref mensaje);
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
