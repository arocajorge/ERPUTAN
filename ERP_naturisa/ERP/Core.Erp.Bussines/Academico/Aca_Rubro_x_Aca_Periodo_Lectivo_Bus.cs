using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;

namespace Core.Erp.Business.Academico
{
    public class Aca_Rubro_x_Aca_Periodo_Lectivo_Bus
    {
        Aca_Rubro_x_Aca_Periodo_Lectivo_Data oData = new Aca_Rubro_x_Aca_Periodo_Lectivo_Data();

        public BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> Get_List_rubro_x_periodo(int IdIstitucuion, int IdRubro)
        {
            try
            {
                return oData.Get_List_rubro_x_periodo(IdIstitucuion, IdRubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_rubro_x_periodo", ex.Message), ex) { EntityType = typeof(Aca_Rubro_x_Aca_Periodo_Lectivo_Bus) };
            }
        }

        public Aca_Rubro_x_Aca_Periodo_Lectivo_Info Get_Rubro_x_PeriodoLectivo(decimal IdRubro)
        {
            try
            {
                return oData.Get_Rubro_x_PeriodoLectivo(IdRubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Rubro_x_PeriodoLectivo", ex.Message), ex) { EntityType = typeof(Aca_Rubro_x_Aca_Periodo_Lectivo_Bus) };
            }
        }


        public bool GrabarDB(BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> lstRubroxPeriodo, ref string msj)
        {
            try
            {
                return oData.GrabarDB(lstRubroxPeriodo, ref msj);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Rubro_x_Aca_Periodo_Lectivo_Bus) };
            }
        }

        public bool EliminarDB(int IdInstitucion, int IdRubro, ref string msj)
        {
            try
            {
                return oData.EliminarDB(IdInstitucion, IdRubro, ref msj);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_Rubro_x_Aca_Periodo_Lectivo_Bus) };
            }
        }
    }
}
