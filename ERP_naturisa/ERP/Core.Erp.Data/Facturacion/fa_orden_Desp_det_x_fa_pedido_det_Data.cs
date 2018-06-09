using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_orden_Desp_det_x_fa_pedido_det_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(fa_orden_Desp_Info Info) 
        {
            try
            {
                if (Info.ListaDetalle.Count()==0)
                { return false; }
                               
                foreach (var item in Info.ListaDetalle)
                {
                    using(EntitiesFacturacion Context = new EntitiesFacturacion())
                    {

                        
                        var Address = new fa_orden_Desp_det_x_fa_pedido_det();

                        Address.od_IdEmpresa = item.IdEmpresa;
                        Address.od_IdSucursal = item.IdSucursal;
                        Address.od_IdBodega = item.IdBodega;
                        Address.od_IdProducto = item.IdProducto;
                        Address.od_IdOrdenDespacho = item.IdOrdenDespacho;
                        Address.od_Secuencia = item.Secuencia;                      
                        Address.od_cantidad = item.od_cantidad;
                        Address.pe_IdEmpresa = item.IdEmpresa;
                        Address.pe_IdSucursal = item.IdSucursal;
                        Address.pe_IdBodega = item.IdBodega;
                        Address.pe_IdProducto = item.IdProducto;
                        Address.pe_IdPedido = (decimal)item.IdPedido;
                        Address.pe_Secuencia = item.SecuenciaPedido;

                        Context.fa_orden_Desp_det_x_fa_pedido_det.Add(Address);
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
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        
        }

        public Boolean EliminarDB(fa_orden_Desp_Info info) 
        {
            try
            {
                foreach (var item in info.ListaAuxiliar)
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        var contact = context.fa_orden_Desp_det_x_fa_pedido_det.FirstOrDefault(obj => obj.od_IdEmpresa == item.od_IdEmpresa && obj.od_IdSucursal == item.od_IdSucursal && obj.od_IdBodega == item.od_IdBodega && obj.od_IdOrdenDespacho == item.od_IdOrdenDespacho && obj.od_Secuencia == item.od_Secuencia&& obj.od_IdProducto == item.od_IdProducto&&
                                                                                             obj.pe_IdEmpresa == item.pe_IdEmpresa && obj.pe_IdSucursal == item.pe_IdSucursal && obj.pe_IdBodega == item.pe_IdBodega && obj.pe_IdPedido == item.pe_IdPedido               &&  obj.pe_Secuencia == item.pe_Secuencia && obj.pe_IdProducto == item.pe_IdProducto );
                        if (contact != null)
                        {
                            context.fa_orden_Desp_det_x_fa_pedido_det.Remove(contact);
                            context.SaveChanges();
                            context.Dispose();
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

        public List<fa_orden_Desp_det_x_fa_pedido_det_Info> Get_List_fa_orden_Desp_det_x_fa_pedido_det(fa_orden_Desp_Info info)
        {
            List<fa_orden_Desp_det_x_fa_pedido_det_Info> lst = new List<fa_orden_Desp_det_x_fa_pedido_det_Info>();
            try
            {             
            
                foreach (var item in info.ListaDetalle)
                {
                    fa_orden_Desp_det_x_fa_pedido_det_Info temp = new fa_orden_Desp_det_x_fa_pedido_det_Info();
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        var contact = context.fa_orden_Desp_det_x_fa_pedido_det.First(obj => obj.od_IdEmpresa == item.IdEmpresa && obj.od_IdSucursal == item.IdSucursal && obj.od_IdBodega == item.IdBodega && obj.od_IdOrdenDespacho == item.IdOrdenDespacho && obj.od_Secuencia == item.Secuencia && obj.od_IdProducto == item.IdProducto &&
                                                                                             obj.pe_IdEmpresa == item.IdEmpresa && obj.pe_IdSucursal == item.IdSucursal && obj.pe_IdBodega == item.IdBodega && obj.pe_IdPedido == item.IdPedido && obj.pe_Secuencia == item.SecuenciaPedido && obj.pe_IdProducto == item.IdProducto);


                        temp.od_cantidad = contact.od_cantidad;
                        temp.od_IdBodega = contact.od_IdBodega;
                        temp.od_IdEmpresa = contact.od_IdEmpresa;
                        temp.od_IdOrdenDespacho = contact.od_IdOrdenDespacho;
                        temp.od_IdProducto = contact.od_IdProducto;
                        temp.od_IdSucursal = contact.od_IdSucursal;
                        temp.od_Secuencia = contact.od_Secuencia;
                        temp.pe_IdBodega = contact.pe_IdBodega;
                        temp.pe_IdEmpresa = contact.pe_IdEmpresa;
                        temp.pe_IdPedido = contact.pe_IdPedido;
                        temp.pe_IdProducto = contact.pe_IdProducto;
                        temp.pe_IdSucursal = contact.pe_IdSucursal;
                        temp.pe_Secuencia = contact.pe_Secuencia;

                        lst.Add(temp);
                    }
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

        public List<fa_orden_Desp_det_x_fa_pedido_det_Info> Get_List_fa_orden_Desp_det_x_fa_pedido_det_x_Producto(fa_orden_Desp_Info info)
        {
            List<fa_orden_Desp_det_x_fa_pedido_det_Info> lst = new List<fa_orden_Desp_det_x_fa_pedido_det_Info>();
            try
            {              
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                                                                                           
                        var contact = from q in context.fa_orden_Desp_det_x_fa_pedido_det

                                      where q.pe_IdEmpresa == info.IdEmpresa
                                         && q.pe_IdSucursal == info.IdSucursal
                                         && q.pe_IdBodega == info.IdBodega
                                         && q.pe_IdPedido == info.IdPedido
                                         && q.pe_IdProducto == info.IdProducto

                                      select q;

                        foreach (var item in contact)
                        {
                            fa_orden_Desp_det_x_fa_pedido_det_Info temp = new fa_orden_Desp_det_x_fa_pedido_det_Info();

                            temp.od_cantidad = item.od_cantidad;
                            temp.od_IdBodega = item.od_IdBodega;
                            temp.od_IdEmpresa = item.od_IdEmpresa;
                            temp.od_IdOrdenDespacho = item.od_IdOrdenDespacho;
                            temp.od_IdProducto = item.od_IdProducto;
                            temp.od_IdSucursal = item.od_IdSucursal;
                            temp.od_Secuencia = item.od_Secuencia;
                            temp.pe_IdBodega = item.pe_IdBodega;
                            temp.pe_IdEmpresa = item.pe_IdEmpresa;
                            temp.pe_IdPedido = item.pe_IdPedido;
                            temp.pe_IdProducto = item.pe_IdProducto;
                            temp.pe_IdSucursal = item.pe_IdSucursal;
                            temp.pe_Secuencia = item.pe_Secuencia;

                            lst.Add(temp);                           
                        }                                            
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

        public List<fa_orden_Desp_det_x_fa_pedido_det_Info> Get_List_fa_orden_Desp_det_x_fa_pedido_det_x_Pedido(fa_orden_Desp_Info info)
        {
            List<fa_orden_Desp_det_x_fa_pedido_det_Info> lst = new List<fa_orden_Desp_det_x_fa_pedido_det_Info>();
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {

                    var contact = from q in context.fa_orden_Desp_det_x_fa_pedido_det

                                  where q.pe_IdEmpresa == info.IdEmpresa
                                     && q.pe_IdSucursal == info.IdSucursal
                                     && q.pe_IdBodega == info.IdBodega
                                     && q.pe_IdPedido == info.IdPedido
                                  select q;

                    foreach (var item in contact)
                    {
                        fa_orden_Desp_det_x_fa_pedido_det_Info temp = new fa_orden_Desp_det_x_fa_pedido_det_Info();

                        temp.od_cantidad = item.od_cantidad;
                        temp.od_IdBodega = item.od_IdBodega;
                        temp.od_IdEmpresa = item.od_IdEmpresa;
                        temp.od_IdOrdenDespacho = item.od_IdOrdenDespacho;
                        temp.od_IdProducto = item.od_IdProducto;
                        temp.od_IdSucursal = item.od_IdSucursal;
                        temp.od_Secuencia = item.od_Secuencia;
                        temp.pe_IdBodega = item.pe_IdBodega;
                        temp.pe_IdEmpresa = item.pe_IdEmpresa;
                        temp.pe_IdPedido = item.pe_IdPedido;
                        temp.pe_IdProducto = item.pe_IdProducto;
                        temp.pe_IdSucursal = item.pe_IdSucursal;
                        temp.pe_Secuencia = item.pe_Secuencia;

                        lst.Add(temp);
                    }
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
