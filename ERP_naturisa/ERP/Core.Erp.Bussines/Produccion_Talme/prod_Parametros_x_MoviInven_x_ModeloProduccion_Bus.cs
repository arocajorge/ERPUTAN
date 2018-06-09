using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Produccion_Talme
{
    public class prod_Parametros_x_MoviInven_x_ModeloProduccion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prod_Parametros_x_MoviInven_x_ModeloProduccion_Data Data = new prod_Parametros_x_MoviInven_x_ModeloProduccion_Data();


        public prod_Parametros_x_MoviInven_x_ModeloProduccion_Info ObtenerObjeto(int IdEmpresa, int IdModeloProd)
        {
            try
            {
              return Data.ObtenerObjeto(IdEmpresa, IdModeloProd);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(prod_Parametros_x_MoviInven_x_ModeloProduccion_Bus) };

            }

        }
        public List<prod_Parametros_x_MoviInven_x_ModeloProduccion_Info> ConsultaGeneral(int IdEmpresa)
        {
            try
            {
                 return Data.ConsultaGeneral(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prod_Parametros_x_MoviInven_x_ModeloProduccion_Bus) };

            }

        }
    }
}
