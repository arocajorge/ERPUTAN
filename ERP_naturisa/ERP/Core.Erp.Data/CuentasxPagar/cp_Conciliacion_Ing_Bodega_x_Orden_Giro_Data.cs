using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info Info, ref decimal IdConciliacion, ref string msjError)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var Address = new cp_Conciliacion_Ing_Bodega_x_Orden_Giro();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdConciliacion = Info.IdConciliacion = IdConciliacion = GetId(Info.IdEmpresa);
                    Address.Fecha_Conciliacion = Info.Fecha_Conciliacion;
                    Address.IdProveedor = Info.IdProveedor;
                    Address.Observacion = Info.Observacion;
                    Address.IdEmpresa_Apro_Ing = Info.IdEmpresa_Apro_Ing;
                    Address.IdAprobacion_Apro_Ing = Info.IdAprobacion_Apro_Ing;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Address.Estado = Info.Estado;

                    Context.cp_Conciliacion_Ing_Bodega_x_Orden_Giro.Add(Address);
                    Context.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesCuentasxPagar cpEnti = new EntitiesCuentasxPagar();
                var select = (from q in cpEnti.cp_Conciliacion_Ing_Bodega_x_Orden_Giro
                              where q.IdEmpresa == IdEmpresa 
                              select q.IdConciliacion).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_IdCXC = (from q in cpEnti.cp_Conciliacion_Ing_Bodega_x_Orden_Giro
                                        where q.IdEmpresa == IdEmpresa
                                        select q.IdConciliacion).Max();
                    Id = Convert.ToInt32(select_IdCXC.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public Boolean AnularDB(cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info Info, ref string msjError)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var contact = Context.cp_Conciliacion_Ing_Bodega_x_Orden_Giro.FirstOrDefault(co => co.IdEmpresa == Info.IdEmpresa && co.IdConciliacion == Info.IdConciliacion);
                    if (contact != null)
                    {
                        contact.MotiAnula = Info.MotiAnula;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Estado = "I";
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info Get_Info_Conciliacion_Ing(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info Info = new cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info();
                
                using (EntitiesCuentasxPagar listado = new EntitiesCuentasxPagar())
                {
                    var select = from q in listado.cp_Conciliacion_Ing_Bodega_x_Orden_Giro
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdConciliacion == IdConciliacion
                                 select q;

                    foreach (var item in select)
                    {
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdConciliacion = item.IdConciliacion;
                        Info.Fecha_Conciliacion = item.Fecha_Conciliacion;
                        Info.IdProveedor = item.IdProveedor;
                        Info.Observacion = item.Observacion;
                        Info.IdEmpresa_Apro_Ing = item.IdEmpresa_Apro_Ing;
                        Info.IdAprobacion_Apro_Ing = item.IdAprobacion_Apro_Ing;
                        Info.IdUsuario = item.IdUsuario;
                        Info.nom_pc = item.nom_pc;
                        Info.ip = item.ip;
                        Info.Estado = item.Estado;
                        Info.MotiAnula = item.MotiAnula;
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = Convert.ToDateTime(item.Fecha_UltAnu);
                    }
                    
                }
                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info> Get_List_Conciliacion(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info> lstinfo = new List<vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info>();
                
                using (EntitiesCuentasxPagar listado = new EntitiesCuentasxPagar())
                {
                    var select = from q in listado.vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro
                                 where q.IdEmpresa == IdEmpresa
                                 && q.Fecha_Conciliacion >= FechaIni && q.Fecha_Conciliacion <= FechaFin
                                 select q;

                    foreach (var item in select)
                    {
                        vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info Info = new vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdConciliacion = item.IdConciliacion;
                        Info.IdProveedor = item.IdProveedor;
                        Info.pr_nombre = item.pr_nombre;
                        Info.IdEmpresa_Apro_Ing = item.IdEmpresa_Apro_Ing;
                        Info.IdAprobacion_Apro_Ing = item.IdAprobacion_Apro_Ing;
                        Info.IdEmpresa_Ogiro = Convert.ToInt32(item.IdEmpresa_Ogiro);
                        Info.IdCbteCble_Ogiro = Convert.ToInt32(item.IdCbteCble_Ogiro);
                        Info.IdTipoCbte_Ogiro = Convert.ToInt32(item.IdTipoCbte_Ogiro);
                        Info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        Info.Serie = item.Serie;
                        Info.Serie2 = item.Serie2;
                        Info.num_documento = item.num_documento;
                        Info.num_Factura = item.num_Factura;
                        Info.num_auto_Proveedor = item.num_auto_Proveedor;
                        Info.num_auto_Imprenta = item.num_auto_Imprenta;
                        Info.Fecha_Factura = item.Fecha_Factura;
                        Info.co_subtotal_iva = item.co_subtotal_iva;
                        Info.co_subtotal_siniva = item.co_subtotal_siniva;
                        Info.Descuento = item.Descuento;
                        Info.co_baseImponible = item.co_baseImponible;
                        Info.co_Por_iva = item.co_Por_iva;
                        Info.co_valoriva = item.co_valoriva;
                        Info.co_total = item.co_total;
                        Info.Fecha_Conciliacion = item.Fecha_Conciliacion;
                        Info.Observacion = item.Observacion;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Estado = item.Estado;

                        lstinfo.Add(Info);
                    }
                }

                return lstinfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<vwcp_Orden_Giro_Pendiente_Conciliar_Info> Get_List_OG_Pendiente_Conciliar(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                List<vwcp_Orden_Giro_Pendiente_Conciliar_Info> lstInfo = new List<vwcp_Orden_Giro_Pendiente_Conciliar_Info>();

                using (EntitiesCuentasxPagar listado = new EntitiesCuentasxPagar())
                {
                    var select = from q in listado.vwcp_Orden_Giro_Pendiente_Conciliar
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdProveedor == IdProveedor
                                 select q;

                    foreach (var item in select)
                    {
                        vwcp_Orden_Giro_Pendiente_Conciliar_Info Info = new vwcp_Orden_Giro_Pendiente_Conciliar_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        Info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        Info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        Info.IdProveedor = item.IdProveedor;
                        Info.nombreProveedor = item.nombreProveedor;
                        Info.co_fechaOg = item.co_fechaOg;
                        Info.co_factura = item.co_factura;
                        Info.co_FechaFactura = item.co_FechaFactura;
                        Info.co_observacion = item.co_observacion;
                        Info.co_subtotal_iva = item.co_subtotal_iva;
                        Info.co_subtotal_siniva = item.co_subtotal_siniva;
                        Info.co_baseImponible = item.co_baseImponible;
                        Info.co_total = item.co_total;
                        Info.Estado = item.Estado;
                        Info.IdEmpresa_ret = Convert.ToInt32(item.IdEmpresa_ret);
                        Info.IdRetencion = Convert.ToDecimal(item.IdRetencion);
                        Info.re_serie = item.re_serie;
                        Info.re_NumRetencion = item.re_NumRetencion;
                        Info.re_EstaImpresa = item.re_EstaImpresa;
                        Info.TipoFlujo = item.TipoFlujo;
                        Info.Checked = false;

                        Info.IdIden_credito = Convert.ToInt32(item.IdIden_credito);
                        Info.Serie = item.Serie;
                        Info.Serie2 = item.Serie2;
                        Info.numDocFactura = item.numDocFactura;
                        Info.Num_Autorizacion = item.Num_Autorizacion;
                        Info.Num_Autorizacion_Imprenta = item.Num_Autorizacion_Imprenta;
                        Info.co_OtroValor_a_descontar = item.co_OtroValor_a_descontar;
                        Info.co_Por_iva = item.co_Por_iva;
                        Info.co_valoriva = item.co_valoriva;
                        Info.fecha_autorizacion = Convert.ToDateTime(item.fecha_autorizacion);
                        Info.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                        Info.IdCtaCble_IVA = item.IdCtaCble_IVA;


                        lstInfo.Add(Info);
                    }
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<vwcp_Orden_Giro_Pendiente_Conciliar_Info> Get_List_OG_Facturas_Conciliadas(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                List<vwcp_Orden_Giro_Pendiente_Conciliar_Info> lstInfo = new List<vwcp_Orden_Giro_Pendiente_Conciliar_Info>();

                using (EntitiesCuentasxPagar listado = new EntitiesCuentasxPagar())
                {
                    var select = from q in listado.vwcp_Orden_Giro_Conciliado_x_Factura
                                 where q.IdEmpresaConciliacion == IdEmpresa
                                 && q.IdConciliacion == IdConciliacion
                                 select q;

                    foreach (var item in select)
                    {
                        vwcp_Orden_Giro_Pendiente_Conciliar_Info Info = new vwcp_Orden_Giro_Pendiente_Conciliar_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        Info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        Info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        Info.IdProveedor = item.IdProveedor;
                        Info.nombreProveedor = item.nombreProveedor;
                        Info.co_fechaOg = item.co_fechaOg;
                        Info.co_factura = item.co_factura;
                        Info.co_FechaFactura = item.co_FechaFactura;
                        Info.co_observacion = item.co_observacion;
                        Info.co_subtotal_iva = item.co_subtotal_iva;
                        Info.co_subtotal_siniva = item.co_subtotal_siniva;
                        Info.co_baseImponible = item.co_baseImponible;
                        Info.co_total = item.co_total;
                        Info.Estado = item.Estado;
                        Info.IdEmpresa_ret = Convert.ToInt32(item.IdEmpresa_ret);
                        Info.IdRetencion = Convert.ToDecimal(item.IdRetencion);
                        Info.re_serie = item.re_serie;
                        Info.re_NumRetencion = item.re_NumRetencion;
                        Info.re_EstaImpresa = item.re_EstaImpresa;
                        Info.TipoFlujo = item.TipoFlujo;
                        Info.Checked = true;

                        Info.IdIden_credito = Convert.ToInt32(item.IdIden_credito);
                        Info.Serie = item.Serie;
                        Info.Serie2 = item.Serie2;
                        Info.numDocFactura = item.numDocFactura;
                        Info.Num_Autorizacion = item.Num_Autorizacion;
                        Info.Num_Autorizacion_Imprenta = item.Num_Autorizacion_Imprenta;
                        Info.co_OtroValor_a_descontar = item.co_OtroValor_a_descontar;
                        Info.co_Por_iva = item.co_Por_iva;
                        Info.co_valoriva = item.co_valoriva;
                        Info.fecha_autorizacion = Convert.ToDateTime(item.fecha_autorizacion);
                        Info.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                        Info.IdCtaCble_IVA = item.IdCtaCble_IVA;
                        lstInfo.Add(Info);
                    }
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> Get_List_Ing_Bod_x_OC_Conciliadas(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> Lst = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
                EntitiesCuentasxPagar oEnti = new EntitiesCuentasxPagar();

                var Query = from q in oEnti.vwcp_Orden_Giro_Conciliado_x_Ing_Bod_x_OC
                            where q.IdEmpresa == IdEmpresa
                            && q.IdConciliacion == IdConciliacion

                            select q;

                foreach (var item in Query)
                {
                    cp_Aprobacion_Ing_Bod_x_OC_det_Info Obj = new cp_Aprobacion_Ing_Bod_x_OC_det_Info();
                    Obj.IdEmpresa_Ing_Egr_Inv = item.IdEmpresa;
                    Obj.IdSucursal_Ing_Egr_Inv = item.IdSucursal_Ing_Egr_Inv;
                    Obj.IdNumMovi_Ing_Egr_Inv = item.IdNumMovi_Ing_Egr_Inv;
                    Obj.Secuencia_Ing_Egr_Inv = item.Secuencia_Ing_Egr_Inv;
                    Obj.IdBodega = item.IdBodega;
                    Obj.Fecha_Ing_Bod = Convert.ToDateTime(item.Fecha_Ing_Bod);
                    Obj.IdProducto = item.IdProducto;
                    Obj.nom_producto = item.nom_producto;
                    Obj.IdUnidadMedida = item.IdUnidadMedida;
                    Obj.nom_medida = item.nom_medida;
                    Obj.nom_bodega = item.nom_bodega;
                    Obj.nom_sucursal = item.nom_sucursal;
                    Obj.Cantidad = item.Cantidad;
                    Obj.Costo_uni = item.Costo_uni;
                    Obj.do_porc_des = item.do_porc_des;

                    //Obj.do_ManejaIva = item.do_ManejaIva;//
                    Obj.IdProveedor = item.IdProveedor;
                    Obj.nom_proveedor = item.pr_nombre;
                    Obj.Checked = true;
                    Obj.IdOrdenCompra = Convert.ToDecimal(item.IdOrdenCompra);
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
