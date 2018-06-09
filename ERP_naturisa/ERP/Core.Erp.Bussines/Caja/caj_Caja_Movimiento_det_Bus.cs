using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Caja;
using Core.Erp.Data.Caja;
using Core.Erp.Business.General;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Business.Caja
{
   public class caj_Caja_Movimiento_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
       caj_Caja_Movimiento_det_Data data = new caj_Caja_Movimiento_det_Data();
       

       public List<vwcaj_Caja_Movimiento_det_cancelado_Info> Get_list_Caja_Movimiento_det_cancelado(int IdEmpresa, decimal IdCbteCble, int IdTipocbte, ref string MensajeError)
       {
           try
           {
                return data.Get_list_Caja_Movimiento_det_cancelado(IdEmpresa, IdCbteCble, IdTipocbte, ref  MensajeError);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Caja_Movimiento_det_cancelado", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_det_Bus) };
           }
       
       
       }

       public List<caj_Caja_Movimiento_det_Info> Get_listDetalle(int IdEmpresa, decimal IdCbteCble, int IdTipocbte, ref string MensajeError)
       {
           try
           {
               return data.Get_listDetalle(IdEmpresa, IdCbteCble, IdTipocbte, ref  MensajeError);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_listDetalle", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_det_Bus) };
           }

       }

       public Boolean GrabarDBDetalle(List<caj_Caja_Movimiento_det_Info> Lista, ref string MensajeError)
       {
           try
           {
               return data.GrabarDB(Lista, ref MensajeError);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDBDetalle", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_det_Bus) };
           }

       }

       public Boolean ModificarDBDetalle(List<caj_Caja_Movimiento_det_Info> Lista, ref string MensajeError)
       {
           try
           {
               return data.ModificarDB(Lista, ref  MensajeError);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDBDetalle", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_det_Bus) };
           }

       }

       public Boolean ModificarDB_IdOP_x_Det(int IdEmpresa_Caj, decimal IdCbteCble_Caj, int IdTipocbte_Caj, int Secuencia_caj, int IdEmpresa_OP, decimal IdOrdenPago, ref string MensajeError)
       {
           try
           {
               return data.ModificarDB_IdOP_x_Det(IdEmpresa_Caj, IdCbteCble_Caj, IdTipocbte_Caj,Secuencia_caj, IdEmpresa_OP ,IdOrdenPago, ref  MensajeError);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDBDetalle", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_det_Bus) };
           }

       }



       public Boolean EliminarRegistroDetalle(caj_Caja_Movimiento_det_Info Info, ref string MensajeError)
       {
           try
           {
               return data.EliminarDB(Info, ref  MensajeError);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarRegistroDetalle", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_det_Bus) };
           }

       }



    }
}
