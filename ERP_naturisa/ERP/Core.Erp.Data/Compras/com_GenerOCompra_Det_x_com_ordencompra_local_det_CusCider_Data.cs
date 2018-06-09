using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Compras
{
    public class com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Data
    {
        string mensaje = "";
        public Boolean GrabarxitemDB(com_GenerOCompraDet_Info  GO, com_ordencompra_local_det_Info OC, ref string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {

                    var address = new com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider();
                    address.goc_IdEmpresa = GO.IdEmpresa;
                    address.goc_IdDetTrans = GO.IdDetTrans;
                    address.goc_IdTransaccion = GO.IdTransaccion;
                    address.oc_IdEmpresa = OC.IdEmpresa;
                    address.oc_IdSucursal  = OC.IdSucursal;
                    address.oc_IdOrdenCompra = OC.IdOrdenCompra;
                    address.oc_Secuencia = OC.Secuencia;
                    context.com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro exitosamente.";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msg = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(List<com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Info> Lst, ref string msg)
        {
            try
            {
                
                foreach (var item in Lst)
                {


                    using (EntitiesCompras context = new EntitiesCompras())
                    {
                        var address = new com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider();
                        address.goc_IdEmpresa = item.goc_IdEmpresa;
                        address.goc_IdDetTrans =item.oc_Secuencia;
                        address.goc_IdTransaccion = item.goc_IdTransaccion;
                        address.oc_IdEmpresa = item.goc_IdEmpresa;
                        address.oc_IdSucursal = item.oc_IdSucursal;
                        address.oc_IdOrdenCompra = item.oc_IdOrdenCompra;
                        address.oc_Secuencia = item.oc_Secuencia;
                        context.com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider.Add(address);
                        context.SaveChanges();
                        msg = "Se ha procedido a grabar el registro exitosamente.";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msg = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Info Get_List_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider(com_ordencompra_local_det_Info OC, ref string msg)
        {
                com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Info info = new com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Info();
                EntitiesCompras oEnti = new EntitiesCompras();
            try
            {
                var select = from A in oEnti.com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider 
                             where A.oc_IdEmpresa == OC.IdEmpresa
                             && A.oc_IdSucursal == OC.IdSucursal
                             && A.oc_IdOrdenCompra == OC.IdOrdenCompra
                             && A.oc_Secuencia  == OC.Secuencia

                             select A;

                foreach (var item in select)
                {
                    info.oc_IdEmpresa   = item.oc_IdEmpresa ;
                    info.oc_IdSucursal = item.oc_IdSucursal;
                    info.oc_IdOrdenCompra = item.oc_IdOrdenCompra;
                    info.oc_Secuencia = item.oc_Secuencia;
                    info.goc_IdEmpresa = item.goc_IdEmpresa;
                    info.goc_IdTransaccion = item.goc_IdTransaccion;
                    info.goc_IdDetTrans = item.goc_IdDetTrans;
                }
                return (info);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;

                msg = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
