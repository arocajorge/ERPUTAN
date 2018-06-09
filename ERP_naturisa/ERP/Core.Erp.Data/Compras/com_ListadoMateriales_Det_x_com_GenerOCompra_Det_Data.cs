using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Compras
{
    public class com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Data
    {
        string mensaje = "";
        public Boolean GrabarDB(com_ListadoMateriales_Det_Info Info, com_ListadoMateriales_Det_Info Info_, ref string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var address = new com_ListadoMateriales_Det_x_com_GenerOCompra_Det();

                    address.go_IdEmpresa = Info.IdEmpresa;
                    address.go_IdDetTrans = Info.IdDetTrans;
                    address.go_IdTransaccion = Info.IdTransaccion;
                    address.lm_IdEmpresa = Info_.IdEmpresa;
                    address.lm_IdListadoMateriales = Info_.IdListadoMateriales;
                    address.lm_IdDetalle = Info_.IdDetalle;
                    context.com_ListadoMateriales_Det_x_com_GenerOCompra_Det.Add(address);
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

        public com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Info Get_Info_ListadoMateriales_Det_x_com_GenerOCompra_Det(com_ListadoMateriales_Det_Info Info, ref string msg)
        {
                com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Info info = new com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Info();
                EntitiesCompras oEnti = new EntitiesCompras();
            try
            {
                var select = from A in oEnti.com_ListadoMateriales_Det_x_com_GenerOCompra_Det
                             where A.go_IdEmpresa  == Info.IdEmpresa
                             && A.go_IdTransaccion == Info.IdTransaccion
                             && A.go_IdDetTrans == Info.IdDetTrans 
                             select A;

                foreach (var item in select)
                {
                    info.go_IdEmpresa = item.go_IdEmpresa;
                    info.go_IdTransaccion = item.go_IdTransaccion;
                    info.go_IdDetTrans = item.go_IdDetTrans;
                    info.lm_IdEmpresa = item.lm_IdEmpresa;
                    info.lm_IdListadoMateriales = item.lm_IdListadoMateriales;
                    info.lm_IdDetalle = item.lm_IdDetalle;

                    
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
