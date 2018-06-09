using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Business.Bancos
{
   public class ba_prestamo_detalle_cancelacion_Bus
    {

        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_prestamo_detalle_cancelacion_Data oData = new ba_prestamo_detalle_cancelacion_Data();
       
       public Boolean ActualizarDetallePrestamosCancelados(ba_prestamo_detalle_Info Info, ref string msg)
        {
            try
            {
                return oData.ActualizarDetallePrestamosCancelados(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDetallePrestamosCancelados", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_cancelacion_Bus) };
            }

        }

        public Boolean AnularDetallePrestamosCancelados(ba_prestamo_detalle_Info Info, ref string msg)
        {
            try
            {
                return oData.AnularDetallePrestamosCancelados(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDetallePrestamosCancelados", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_cancelacion_Bus) };
            }

        }

        public Boolean GuardarDetallePrestamosCancelados(List<ba_prestamo_detalle_Info> Listado, ref string msg)
        {
            try
            {
                //grabar diario de la nota de debito
                ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
              
                foreach (var item in Listado )
                {
                   
                    decimal idCbteCble = 0;

                    ct_Cbtecble_Info CbteCble = item.Lista_CbteCble.FirstOrDefault();

                    if (CbteCble_B.GrabarDB(CbteCble, ref idCbteCble, ref msg))
                     {
                         // grabar en tabla ba_Cbte_Ban
                         ba_Cbte_Ban_Info CbteBan = item.Lista_CbteBan.FirstOrDefault();
                         CbteBan.IdCbteCble = idCbteCble;

                         ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
                         if (CbteBan_B.GrabarDB(CbteBan, ref msg))
                         {
                             if (oData.GuardarDetallePrestamosCancelados(item, ref msg))
                             { 
                             
                             
                             }
                         
                         }

                     }
                                    
                }

                return true;
                   
               // return oData.GuardarDetallePrestamosCancelados(Listado, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDetallePrestamosCancelados", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_cancelacion_Bus) };
            }

        }

        public Boolean GuardarDetallePrestamosCancelados(ba_prestamo_detalle_Info info, ref string msg)
        {
            try
            {
                Boolean res = true;
                
                //grabar diario de la nota de debito
                ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();

                    decimal idCbteCble = 0;
                    string cod_CbteCble = "";

                    ct_Cbtecble_Info CbteCble = info.Info_CbteCble;

                    if (CbteCble_B.GrabarDB(CbteCble, ref idCbteCble, ref msg))
                    {
                        // grabar en tabla ba_Cbte_Ban
                        ba_Cbte_Ban_Info CbteBan = info.Info_CbteBan;
                        CbteBan.IdCbteCble = idCbteCble;

                        ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
                        if (CbteBan_B.GrabarDB(CbteBan, ref msg))
                        {
                            if (oData.GuardarDetallePrestamosCancelados(info, ref msg))
                            {
                                ba_prestamo_detalle_Data odata = new ba_prestamo_detalle_Data();
                                if (!odata.CancelarEstadoDetallePrestamo(info, ref msg))
                                {
                                    res = false; 
                                }

                            }
                            else 
                            { res = false; }

                        }
                        else
                        {
                            res = false;                       
                        }

                    }
                    else
                    {
                        res = false;
                    }
                    return res;
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDetallePrestamosCancelados", ex.Message), ex) { EntityType = typeof(ba_prestamo_detalle_cancelacion_Bus) };
            }

        }


    }
}
