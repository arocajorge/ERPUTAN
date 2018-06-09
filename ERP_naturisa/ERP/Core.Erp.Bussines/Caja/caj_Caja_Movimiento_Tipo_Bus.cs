using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Caja;
using Core.Erp.Data.Caja;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.Caja
{
    public class caj_Caja_Movimiento_Tipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";
        caj_Caja_Movimiento_Tipo_Data data = new caj_Caja_Movimiento_Tipo_Data();

        public List<caj_Caja_Movimiento_Tipo_Info> Get_list_Caja_Movimiento_Tipo(ref string MensajeError)
        {
            try
            {
               return data.Get_list_Caja_Movimiento_Tipo( ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Caja_Movimiento_Tipo", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_Bus) };
            }

        }

        public List<caj_Caja_Movimiento_Tipo_Info> Get_list_Caja_Movimiento_Tipo(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                return data.Get_list_Caja_Movimiento_Tipo(IdEmpresa, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Caja_Movimiento_Tipo", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_Bus) };
            }

        }

        public List<caj_Caja_Movimiento_Tipo_Info> Get_list_Caja_Movimiento_Tipo(int IdEmpresa, Cl_Enumeradores.eTipo_Ing_Egr eTipo, ref string MensajeError)
        {
            try
            {
                return data.Get_list_Caja_Movimiento_Tipo(IdEmpresa,eTipo, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Caja_Movimiento_Tipo", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_Bus) };
            }
        
        }
        
        public caj_Caja_Movimiento_Tipo_Info Get_Info_Movimiento_Tipo(int IdTipoMovi, int IdEmpresa, ref string MensajeError)
        {
            try
            {
                  return data.Get_Info_Movimiento_Tipo(IdTipoMovi, IdEmpresa, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Movimiento_Tipo", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_Bus) };
            }

        }

        public Boolean GrabarDB(caj_Caja_Movimiento_Tipo_Info info,ref int id, ref string MensajeError)
        {
            try
            {
                 return data.GrabarDB(info,ref id, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_Bus) };
            }

        }

        public Boolean ModificarDB(caj_Caja_Movimiento_Tipo_Info info, ref string MensajeError)
        {
            try
            {
                return data.ModificarDB(info, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_Bus) };
            }

        }

        public Boolean AnularDB(caj_Caja_Movimiento_Tipo_Info info, ref string MensajeError)
        {
            try
            {
            return data.AnularDB(info, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_Bus) };
            }

        }


        public caj_Caja_Movimiento_Tipo_Bus(){}
    }
}
