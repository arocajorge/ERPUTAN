using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
namespace Core.Erp.Business.Inventario
{
   public class in_Guia_x_traspaso_bodega_x_in_transferencia_det_Bus
    {
       in_Guia_x_traspaso_bodega_x_in_transferencia_det_Data data = new in_Guia_x_traspaso_bodega_x_in_transferencia_det_Data();

       public bool Guardar(List<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info> Info)
        {
            try
            {
                return data.Guardar(Info);
            }
                
            
            catch (Exception ex)
            {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarTransferecia", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }
        }






        public bool Eliminar(in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info Info)
        {
            try
            {
              return  data.Eliminar(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }
        }




        public bool Anular(List<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info> Info)
        {
            try
            {
                return data.Anular(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }
        }




        public List<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info> Get_lista(int idEmpresa, int idGuia)
        {
            try
            {
                return data.Get_lista( idEmpresa,  idGuia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }

        }
    }
}
