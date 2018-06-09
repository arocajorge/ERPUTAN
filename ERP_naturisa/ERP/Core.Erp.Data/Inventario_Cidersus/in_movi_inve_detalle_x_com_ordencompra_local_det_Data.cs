using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario_Cidersus
{
    public class in_movi_inve_detalle_x_com_ordencompra_local_det_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(List<in_movi_inve_detalle_Info> Lst)
        { 
            try
            {
                foreach (var item in Lst)
                {

                    using (EntitiesInventario Context = new EntitiesInventario())
                    {                       
                        in_movi_inve_detalle_x_com_ordencompra_local_det Address = new in_movi_inve_detalle_x_com_ordencompra_local_det();

                        Address.mi_IdEmpresa = item.IdEmpresa;
                        Address.mi_IdSucursal = item.IdSucursal;
                        Address.mi_IdBodega = item.IdBodega;
                        Address.mi_IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        Address.mi_IdNumMovi = item.IdNumMovi;
                        Address.mi_Secuencia = item.Secuencia;
                        Address.ocd_IdEmpresa = item.oc_IdEmpresa;
                        Address.ocd_IdSucursal = item.oc_IdSucursal;
                        Address.ocd_IdOrdenCompra = item.oc_IdOrdenCompra;
                        Address.ocd_Secuencia = item.oc_Secuencial;

                        if (item.dm_observacion == null || item.dm_observacion =="")
                        {
                            Address.observacion="" ;
                        }
                        else
                        {
                          Address.observacion= item.dm_observacion;                        
                        }                       
                      
                        Context.in_movi_inve_detalle_x_com_ordencompra_local_det.Add(Address);
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public in_movi_inve_detalle_x_com_ordencompra_local_det_Info Get_Info_in_movi_inve_detalle_x_com_ordencompra_local_det(in_movi_inve_detalle_Info MovInv)
        {
            try
            {
                in_movi_inve_detalle_x_com_ordencompra_local_det_Info Obj = new in_movi_inve_detalle_x_com_ordencompra_local_det_Info();
                EntitiesInventario oEnti = new EntitiesInventario();
                var Query = from q in oEnti.in_movi_inve_detalle_x_com_ordencompra_local_det
                            where q.mi_IdEmpresa == MovInv.IdEmpresa
                            && q.mi_IdSucursal == MovInv.IdSucursal
                            && q.mi_IdBodega == MovInv.IdBodega
                            && q.mi_IdMovi_inven_tipo == MovInv.IdMovi_inven_tipo
                            && q.mi_IdNumMovi == MovInv.IdNumMovi
                            && q.mi_Secuencia == MovInv.Secuencia

                            select q;
                foreach (var item in Query)
                {
                    Obj.mi_IdEmpresa = item.mi_IdEmpresa;
                    Obj.mi_IdSucursal = item.mi_IdSucursal;
                    Obj.mi_IdBodega = item.mi_IdBodega;
                    Obj.mi_IdMovi_inven_tipo = item.mi_IdMovi_inven_tipo;
                    Obj.mi_IdNumMovi = item.mi_IdNumMovi;
                    Obj.mi_Secuencia = item.mi_Secuencia;
                    Obj.ocd_IdEmpresa = item.ocd_IdEmpresa;
                    Obj.ocd_IdSucursal = item.ocd_IdSucursal;
                    Obj.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                    Obj.ocd_Secuencia = item.ocd_Secuencia;
                }
                return Obj;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
