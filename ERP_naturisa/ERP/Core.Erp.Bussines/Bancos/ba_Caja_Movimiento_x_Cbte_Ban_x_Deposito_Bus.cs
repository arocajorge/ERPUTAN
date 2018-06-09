using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
using Core.Erp.Info.Caja;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Bancos
{
    public class ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus
    {

        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Data data = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Data();

        public Boolean GrabarDB(List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> lista)
        {
            try
            {
                return data.GrabarDB(lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus) };
            }

        }

        public Boolean GrabarDB(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info Info)
        {
            try
            {
                 return data.GrabarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus) };
            }

        
        }
        public Boolean  GrabarListadoMovCaja_x_Deposito(List<caj_Caja_Movimiento_Info> Lst,int IdtipoCbteCble_Bco, decimal IdCbteCble_Bco)
        {
            try
            {
              return data.GrabarListadoMovCaja_x_Deposito(Lst, IdtipoCbteCble_Bco,  IdCbteCble_Bco);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarListadoMovCaja_x_Deposito", ex.Message), ex) { EntityType = typeof(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus) };
            }


        }
         public ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus(){
            
         }
         public Boolean EliminarCobros_x_deposito(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
         {
             try
             {
                 return data.EliminarCobros_x_deposito(IdEmpresa, IdTipoCbte, IdCbteCble);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus) };
             }
         }
    }
}
