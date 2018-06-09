using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_orden_Desp_det_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(fa_orden_Desp_Info Info) 
        {
            try
            {
                foreach (var item in Info.ListaDetalle)
                {
                    using(EntitiesFacturacion Contex = new EntitiesFacturacion())
                    {

                       
                        var Address = new fa_orden_Desp_det();


                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdSucursal = item.IdSucursal;
                        Address.od_peso = item.Peso;
                        Address.IdBodega = item.IdBodega;
                        Address.IdOrdenDespacho = item.IdOrdenDespacho;
                        Address.Secuencia = item.Secuencia;
                        Address.IdProducto = item.IdProducto;
                        Address.od_cantidad = item.od_cantidad;
                        Address.od_Precio = item.od_Precio;
                        Address.od_PorDescUnitario = item.od_PorDescUnitario;
                        Address.od_DescUnitario = item.od_DescUnitario;
                        Address.od_PrecioFinal = item.od_PrecioFinal;
                        Address.od_Subtotal = item.od_Subtotal;
                        Address.od_iva = item.od_iva;
                        Address.od_total = item.od_total;
                        Address.od_costo = item.od_costo;
                        Address.od_tieneIVA = item.od_tieneIVA;
                        Address.od_detallexItems = item.od_detallexItems;

                        Contex.fa_orden_Desp_det.Add(Address);
                        Contex.SaveChanges();
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

        public List<fa_orden_Desp_det_Info> Get_List_orden_Desp_det(fa_orden_Desp_Info Info) 
        {
            try
            {
                List<fa_orden_Desp_det_Info> lst = new List<fa_orden_Desp_det_Info>();
                EntitiesFacturacion oenti = new EntitiesFacturacion();
                var detalle = from q in oenti.vwfa_orden_Desp_det_x_Pedido_det
                              where q.IdBodega == Info.IdBodega && q.IdSucursal == Info.IdSucursal && q.IdOrdenDespacho == Info.IdOrdenDespacho &&
                                    q.IdEmpresa == Info.IdEmpresa
                              select q;
                foreach (var item in detalle)
                {
                    fa_orden_Desp_det_Info set = new fa_orden_Desp_det_Info();
                    set.IdPedido = Convert.ToDecimal((item.pe_IdPedido==null)? 0:item.pe_IdPedido);
                    set.IdEmpresa = item.IdEmpresa;
                    set.IdSucursal = item.IdSucursal;
                    set.IdBodega = item.IdBodega;
                    set.IdOrdenDespacho = item.IdOrdenDespacho;
                    set.Peso = (float)item.od_peso;
                    set.Secuencia = item.Secuencia;
                    set.IdProducto = item.IdProducto;
                    set.od_cantidad = item.od_cantidad;
                    set.od_Precio = item.od_Precio;
                    set.od_PorDescUnitario = item.od_PorDescUnitario;
                    set.od_DescUnitario = item.od_DescUnitario;
                    set.od_PrecioFinal = item.od_PrecioFinal;
                    set.od_Subtotal = item.od_Subtotal;
                    set.od_iva = item.od_iva;
                    set.od_total = item.od_total;
                    set.od_costo = item.od_costo;
                    set.od_tieneIVA = item.od_tieneIVA;
                    set.od_detallexItems = item.od_detallexItems;
                    set.IdPedido = Convert.ToDecimal((item.pe_IdPedido==null)?0:item.pe_IdPedido);
                    set.SecuenciaPedido = Convert.ToInt32((item.pe_Secuencia==null)?0:item.pe_Secuencia);
                    set.pr_descripcion = item.pr_descripcion;

                    set.pr_descripcion = item.pr_descripcion;

                    set.Tiene_guia = item.Tiene_guia;

                    lst.Add(set);
                    
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

        public Boolean EliminarDB(fa_orden_Desp_Info Info) 
        {
            try
            {
                EntitiesFacturacion Oent = new EntitiesFacturacion();
            
                string Query = "delete from fa_orden_desp_det where IdEmpresa = " + Info.IdEmpresa + " and IdBodega =" + Info.IdBodega + " and IdSucursal =" + Info.IdSucursal + " and IdOrdenDespacho= " +Info.IdOrdenDespacho +"";
                var Consulta = Oent.Database.SqlQuery<fa_orden_Desp_Info>(Query);
                   
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

        public List<fa_orden_Desp_det_Info> Get_List_orden_Desp_x_Pedido(fa_pedido_Info Info)
        {
            try
            {
                List<fa_orden_Desp_det_Info> lst = new List<fa_orden_Desp_det_Info>();
                EntitiesFacturacion oenti = new EntitiesFacturacion();
                var detalle = from q in oenti.vwfa_orden_Desp_det_x_Pedido_det
                              join cab in oenti.fa_orden_Desp
                              on new { q.IdEmpresa,q.IdSucursal,q.IdBodega,q.IdOrdenDespacho} equals new { cab.IdEmpresa,cab.IdSucursal,cab.IdBodega,cab.IdOrdenDespacho}
                              where q.IdBodega == Info.IdBodega && q.IdSucursal == Info.IdSucursal && q.pe_IdPedido == Info.IdPedido &&
                                    q.IdEmpresa == Info.IdEmpresa && cab.Estado == "A"
                              select q;
                foreach (var item in detalle)
                {
                    fa_orden_Desp_det_Info set = new fa_orden_Desp_det_Info();
                    set.IdPedido = (decimal)item.pe_IdPedido;
                    set.IdEmpresa = item.IdEmpresa;
                    set.IdSucursal = item.IdSucursal;
                    set.IdBodega = item.IdBodega;
                    set.IdOrdenDespacho = item.IdOrdenDespacho;
                    set.Secuencia = item.Secuencia;
                    set.IdProducto = item.IdProducto;
                    set.od_cantidad = (float)item.od_cantidad;
                    set.od_Precio = (float)item.od_Precio;
                    set.od_PorDescUnitario = (float)item.od_PorDescUnitario;
                    set.od_DescUnitario = (float)item.od_DescUnitario;
                    set.od_PrecioFinal = (float)item.od_PrecioFinal;
                    set.od_Subtotal = (float)item.od_Subtotal;
                    set.od_iva = (float)item.od_iva;
                    set.od_total = (float)item.od_total;
                    set.od_costo = (float)item.od_costo;
                    set.od_tieneIVA = item.od_tieneIVA;
                    set.od_detallexItems = item.od_detallexItems;

                    set.pr_descripcion = item.pr_descripcion;
                    lst.Add(set);

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
    }
}
