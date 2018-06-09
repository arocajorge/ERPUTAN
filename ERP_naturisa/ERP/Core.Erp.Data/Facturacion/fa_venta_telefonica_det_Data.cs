using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_venta_telefonica_det_Data
    {
        string mensaje = "";

        public List<fa_venta_telefonica_det_Info> Get_List_venta_telefonica_det(int IdEmpresa, int IdSucursal, decimal IdVenta_Tel)
        {
            try
            {
                List<fa_venta_telefonica_det_Info> lst = new List<fa_venta_telefonica_det_Info>();
                EntitiesFacturacion context = new EntitiesFacturacion();

                fa_venta_telefonica_det_Info Info;

                var select = from q in context.vwfa_venta_telefonica_det
                             where q.IdEmpresa == IdEmpresa
                                && q.IdVenta_tel == IdVenta_Tel
                                && q.IdSucursal == IdSucursal
                            
                             select q;                    

                foreach (var item in select)
                {
                    Info = new fa_venta_telefonica_det_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdVenta_tel = item.IdVenta_tel;
                    Info.IdSucursal = item.IdSucursal;
                    Info.Secuencia = item.Secuencia;
                    Info.IdProducto = item.IdProducto;
                    Info.Observacion = item.Observacion;
                    Info.Cantidad = Convert.ToDouble(item.Cantidad);
                    Info.Descripcion = item.nom_producto;
                    Info.Base = item.Viene_Base;
                    lst.Add(Info);

                }
                return lst;
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

        public Boolean GuardarDB(fa_venta_telefonica_det_Info Info)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();

                var address = new fa_venta_telefonica_det();

                address.IdEmpresa = Info.IdEmpresa;
                address.IdVenta_tel = Info.IdVenta_tel;
                address.IdSucursal = Info.IdSucursal;
                address.Secuencia = Convert.ToInt32(Info.Secuencia);
                address.IdProducto = Info.IdProducto;
                address.Observacion = Info.Observacion;
                address.Cantidad = Convert.ToDouble(Info.Cantidad);
                context.fa_venta_telefonica_det.Add(address);
                context.SaveChanges();
                return true;
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

        public Boolean ModificarDB(fa_venta_telefonica_det_Info Info)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();

                var address = context.fa_venta_telefonica_det.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa
                                                                   && var.IdVenta_tel == Info.IdVenta_tel
                                                                   && var.IdSucursal == Info.IdSucursal);
                if (address != null)
                {
                    address.IdEmpresa = Info.IdEmpresa;
                    address.IdVenta_tel = Info.IdVenta_tel;
                    address.IdSucursal = Info.IdSucursal;
                    address.Secuencia = Convert.ToInt32(Info.Secuencia);
                    address.IdProducto = Info.IdProducto;
                    address.Observacion = Info.Observacion;
                    address.Cantidad = Convert.ToDouble(Info.Cantidad);
                    context.SaveChanges();
                }
                return true;
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

        public Boolean EliminarDetalle(int IdEmpresa, int IdSucursal,decimal IdVenta_Tel)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();

                var select = from q in context.fa_venta_telefonica_det
                             where q.IdEmpresa == IdEmpresa
                                && q.IdVenta_tel == IdVenta_Tel
                                && q.IdSucursal == IdSucursal
                             select q;

                if (select.ToList().Count > 0)
                {
                    foreach (var item in select)
                    {
                        context = new EntitiesFacturacion();
                        var address = context.fa_venta_telefonica_det.FirstOrDefault( var => var.IdEmpresa == IdEmpresa
                                 && var.IdVenta_tel == IdVenta_Tel
                                 && var.IdSucursal == IdSucursal);
                        if (address != null)
                        {
                            context.fa_venta_telefonica_det.Remove(address);
                            context.SaveChanges();
                        }
                    }                   
                }
                return true;
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
    }
}
