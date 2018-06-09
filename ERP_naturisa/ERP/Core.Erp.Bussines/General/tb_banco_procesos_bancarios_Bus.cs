using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Business.General
{
    public class tb_banco_procesos_bancarios_Bus
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //string mensaje = "";
        tb_banco_procesos_bancarios_Data oData = new tb_banco_procesos_bancarios_Data();

        public int getId(int IdBanco)
        {
            try
            {
                return oData.getId(IdBanco);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_Bus) };
            }
        }
        
        public List<tb_banco_procesos_bancarios_Info> Get_List()
        {
            try
            {
                return oData.Get_List();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_Bus) };
            }
        }

        public List<tb_banco_procesos_bancarios_Info> Get_List(int IdBanco)
        {
            try
            {
                return oData.Get_List(IdBanco);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_Bus) };
            }
        }

        public Boolean GrabarDB(tb_banco_procesos_bancarios_Info Info, int IdBanco, ref string Mensaje)
        {
            try
            {
                return oData.GrabarDB(Info, IdBanco, ref Mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_Bus) };
            }
        }

        public Boolean GrabarDB(List<tb_banco_procesos_bancarios_Info> Lista_Info, int IdBanco, ref string mensaje)
        {
            try
            {
                oData.ModificarDB(Lista_Info.Where(v => v.EstaEnBase == true).ToList(), IdBanco, ref mensaje);
                oData.GrabarDB(Lista_Info.Where(v => v.EstaEnBase == false).ToList(), IdBanco, ref mensaje);
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_Bus) };
            }
        }

        public Boolean ModificarDB(List<tb_banco_procesos_bancarios_Info> Lista_Info, int IdBanco, ref string mensaje)
        {
            try
            {
                return oData.ModificarDB(Lista_Info.Where(v => v.EstaEnBase == true).ToList(), IdBanco, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_Bus) };
            }
        }

        public Boolean ModificarDB(tb_banco_procesos_bancarios_Info Info, int IdBanco, ref string msg)
        {
            try
            {
                return oData.ModificarDB(Info, IdBanco, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_Bus) };
            }
        }

        public Boolean EliminarDB(int IdBanco, ref string mensaje)
        {
            try
            {
                return oData.EliminarDB(IdBanco, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_Bus) };
            }
        }
    }
}
