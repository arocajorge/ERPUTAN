using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

namespace Core.Erp.Business.Inventario
{
    public class vwIn_UnidadMedida_Equivalencia_Bus
    {
        vwIn_UnidadMedida_Equivalencia_Data dataUni = new vwIn_UnidadMedida_Equivalencia_Data();

        public List<vwIn_UnidadMedida_Equivalencia_Info> Get_List_UnidadMedida_Equivalencia(string IdUnidadMedida)
        {
            try
            {
                return dataUni.Get_List_UnidadMedida_Equivalencia(IdUnidadMedida);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_LstUnidadEquivalencia", ex.Message), ex) { EntityType = typeof(vwIn_UnidadMedida_Equivalencia_Bus) };

            }
        }

        public List<vwIn_UnidadMedida_Equivalencia_Info> Get_List_UnidadMedida_Equivalencia_x_Uni_Consumo(string IdUnidadConsumo)
        {
            try
            {
                return dataUni.Get_List_UnidadMedida_Equivalencia_x_Uni_Consumo(IdUnidadConsumo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_LstUnidadConsumo", ex.Message), ex) { EntityType = typeof(vwIn_UnidadMedida_Equivalencia_Bus) };

            }
        }

        public vwIn_UnidadMedida_Equivalencia_Bus()
        {

        }
    }
}
