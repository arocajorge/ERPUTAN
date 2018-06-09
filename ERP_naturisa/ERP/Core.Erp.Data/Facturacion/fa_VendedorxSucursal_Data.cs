using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_VendedorxSucursal_Data
    {
        string mensaje = "";

        public List<fa_VendedorxSucursal_Info> Get_List_VendedoresxSucursal(int idempresa, int id)
        {
            try
            {
                List<fa_VendedorxSucursal_Info> lM = new List<fa_VendedorxSucursal_Info>();
                EntitiesFacturacion OEPVendedorxSucursal = new EntitiesFacturacion();

                var select_pv = from A in OEPVendedorxSucursal.fa_VendedorxSucursal
                                where A.IdEmpresa==idempresa && A.IdVendedor==id 
                                select A;

                foreach (var item in select_pv)
                {
                    fa_VendedorxSucursal_Info info = new fa_VendedorxSucursal_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdVendedor = item.IdVendedor;
                    info.IdSucursal = item.IdSucursal;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex) 
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<fa_VendedorxSucursal_Info> lista_antigua, List<fa_VendedorxSucursal_Info> lista_nueva, ref string msg)
        {
            try
            {
                foreach (var item in lista_antigua)
                {
                    EliminarDB(item, ref msg);
                }
                foreach (var item1 in lista_nueva)
                {
                    GrabarDB(item1, ref msg);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        

        public Boolean GrabarDB(fa_VendedorxSucursal_Info info, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var address = new fa_VendedorxSucursal();
                    
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdVendedor = info.IdVendedor;
                    address.IdSucursal = info.IdSucursal;
                    context.fa_VendedorxSucursal.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro exitosamente.";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(fa_VendedorxSucursal_Info info, ref  string msg)
        {
            try
            {
                EntitiesFacturacion OEPVendedorxSucursal = new EntitiesFacturacion();
                var select = from q in OEPVendedorxSucursal.fa_VendedorxSucursal
                             where q.IdEmpresa == info.IdEmpresa && q.IdVendedor == info.IdVendedor 
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        var contact = context.fa_VendedorxSucursal.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdVendedor == info.IdVendedor && obj.IdSucursal == info.IdSucursal);
                        if (contact != null)
                        {
                            context.fa_VendedorxSucursal.Remove(contact);
                            context.SaveChanges();
                            msg = "Se ha procedido anular el registro exitosamente";
                        }
                    }

                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro debido a que no se encuentra.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }


        public fa_VendedorxSucursal_Data() { }
    }
}
