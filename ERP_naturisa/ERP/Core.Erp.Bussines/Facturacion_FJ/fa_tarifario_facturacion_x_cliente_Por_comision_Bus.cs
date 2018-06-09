using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;
namespace Core.Erp.Business.Facturacion_FJ
{
   public class fa_tarifario_facturacion_x_cliente_Por_comision_Bus
   {
       fa_tarifario_facturacion_x_cliente_Por_comision_Data data = new fa_tarifario_facturacion_x_cliente_Por_comision_Data();
        public bool Guardar(List<fa_tarifario_facturacion_x_cliente_Por_comision_Info> lista)
        {
            try
            {
                return data.Guardar(lista);
            }

            
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_det_Bus) };
        

            }
        }

        public bool Eliminar(int IdEmpresa, int IdTarifario)
        {
            try
            {
                return data.Eliminar(IdEmpresa, IdTarifario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_det_Bus) };
        

               
            }
        }

        public List<fa_tarifario_facturacion_x_cliente_Por_comision_Info> Get_List_Tarifarios_Porcentaje_Ganancia(int idempresa, decimal idtarifario)
        {
            try
            {
              return  data.Get_List_Tarifarios_Porcentaje_Ganancia(idempresa, idtarifario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Tarifarios_Porcentaje_Ganancia", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_det_Bus) };
        
               
            }
        }
        public double Get_Fee(int idempresa, int Idanio, decimal IdCliente)
        {
            try
            {
                return data.Get_Fee(idempresa, Idanio, IdCliente);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Tarifarios_Porcentaje_Ganancia", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_det_Bus) };


            }
        }
    }
}
