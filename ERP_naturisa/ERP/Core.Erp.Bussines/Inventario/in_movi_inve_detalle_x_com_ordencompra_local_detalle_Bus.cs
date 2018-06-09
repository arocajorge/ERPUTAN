using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;


namespace Core.Erp.Business.Inventario
{
  public  class in_movi_inve_detalle_x_com_ordencompra_local_detalle_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        in_movi_inve_detalle_x_com_ordencompra_local_detalle_Data odata = new in_movi_inve_detalle_x_com_ordencompra_local_detalle_Data();

        public Boolean GrabarDB(List<in_movi_inve_detalle_x_com_ordencompra_local_detalle_Info> lista, ref string mensaje)
        {

            try
            {
                Boolean res = true;

                res=odata.GrabarDB(lista, ref  mensaje);
                               
                int IdEmpresa = 0;
                int IdSucursal = 0;
                decimal IdOrdenCompra = 0;

                List<in_movi_inve_detalle_Info> listInvMovDet = new List<in_movi_inve_detalle_Info>();
                vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_Data data= new vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_Data();
                if (res)
                {
                    foreach (var item in lista)
                    {
                         IdEmpresa = item.ocd_IdEmpresa;
                         IdSucursal = item.ocd_IdSucursal;
                         IdOrdenCompra = item.ocd_IdOrdenCompra;
                    }

                    listInvMovDet = data.Get_List_movi_inve_detalle(IdEmpresa, IdSucursal, IdOrdenCompra);
                                
                    var TAgrupacionEstado = from cb in listInvMovDet
                                group cb by new { cb.IdEstadoRecepcion }
                                    into grouping
                                    select new { grouping.Key };

                    string IdEstado = "";

                    if (TAgrupacionEstado.Count() ==1)
                    { 
                           
                        foreach (var item in TAgrupacionEstado)
                        {
                            IdEstado = item.Key.IdEstadoRecepcion;
                        }
                     
                    }

                    if (TAgrupacionEstado.Count() > 1)
                    {
                        IdEstado = "PEN_X_RECI";
                    }

                    // actualiza cabecera OC con el estado    
                    
                    com_ordencompra_local_Data OdataOC = new com_ordencompra_local_Data();

                    com_ordencompra_local_Info info = new com_ordencompra_local_Info();

                    string msg = "";
                    
                    info.IdEmpresa = IdEmpresa;
                    info.IdSucursal = IdSucursal;
                    info.IdOrdenCompra = IdOrdenCompra;
                    info.IdEstadoRecepcion_cat = IdEstado;

                    if (OdataOC.Modificar_Estado_Recep(info, ref msg))
                    { 
                    
                    }                                                              
                }

                return res;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };

            }
        }

        public Boolean AnularDB(in_movi_inve_Info Info, ref string mensaje)
        {
            try
            {
                return odata.AnularDB( Info, ref mensaje);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };

            }
        }

    }
}
