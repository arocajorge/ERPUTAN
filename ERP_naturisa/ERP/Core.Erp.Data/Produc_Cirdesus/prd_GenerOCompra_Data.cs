using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Data.Compras;


namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_GenerOCompra_Data
    {
        string mensaje = "";
        public Boolean GrabarDB(com_GeneracionOCompra_Info info, ref string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    //var contact = com_GenerOCompra.Createcom_GenerOCompra(0, 0, 0, DateTime.Now, "", "");
                    var address = new com_GenerOCompra();
                   // decimal idEmp = getId(info.IdEmpresa);
                 //   id = idEmp;
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdTransaccion = info.IdTransaccion;
                    address.IdEmpresa = info.IdEmpresa;
                    address.FechaReg = info.FechaReg;
                    address.Usuario = info.Usuario;
                    address.g_ocObservacion = info.g_ocObservacion;
                    if (info.g_ocObservacion.Length > 1000)
                        address.g_ocObservacion = info.g_ocObservacion.Substring(0, 1000);
                    address.Estado = "A";


                    context.com_GenerOCompra.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el Listado de Materiales #: " + info.IdTransaccion + " exitosamente.";
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int getId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesCompras OEProd = new EntitiesCompras();
                var select = from q in OEProd.com_GenerOCompra
                             where q.IdEmpresa == IdEmpresa

                             select q;

                if (select.ToList().Count == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProd.com_GenerOCompra
                                     where q.IdEmpresa == IdEmpresa

                                     select q.IdTransaccion).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
