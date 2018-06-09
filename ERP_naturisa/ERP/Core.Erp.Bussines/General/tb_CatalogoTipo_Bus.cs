using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_CatalogoTipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<tb_CatalogoTipo_Info> ObtenerList_Tipo()
        {

            try
            {
                tb_CatalogoTipo_Data data = new tb_CatalogoTipo_Data();
                return data.Get_List_CatalogoTipo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_Tipo", ex.Message), ex) { EntityType = typeof(tb_CatalogoTipo_Bus) };
         
            }

        }
        
        public Boolean GrabaItem(tb_CatalogoTipo_Info info, ref string msg , ref int IdCatalgoTipo)
        {
            try
            {
                tb_CatalogoTipo_Data data = new tb_CatalogoTipo_Data();
                return data.GrabaDB(info, ref msg, ref IdCatalgoTipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabaItem", ex.Message), ex) { EntityType = typeof(tb_CatalogoTipo_Bus) };
         
            }
        }

        public Boolean ModificaItem(tb_CatalogoTipo_Info info, ref string msg)
        {
            try
            {
                tb_CatalogoTipo_Data data = new tb_CatalogoTipo_Data();
                return data.ModificaDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificaItem", ex.Message), ex) { EntityType = typeof(tb_CatalogoTipo_Bus) };
         
            }
        }
        public tb_CatalogoTipo_Bus() {
            try
            {

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "tb_CatalogoTipo_Bus", ex.Message), ex) { EntityType = typeof(tb_CatalogoTipo_Bus) };
         
            }
        }
    }
}
