using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_notaCreDeb_det_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(fa_notaCreDeb_Info Info) 
        {
            try
            {
                int c = 1;
                Info.ListaDetalles.ForEach(var => { var.Secuencia = c; c++; });
                foreach (var item in Info.ListaDetalles)
                {
                    using (EntitiesFacturacion Context = new EntitiesFacturacion()) 
                    {
                        fa_notaCreDeb_det Address = new fa_notaCreDeb_det(); 
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdSucursal = item.IdSucursal;
                        Address.IdBodega = item.IdBodega;
                        Address.IdNota = item.IdNota;
                        Address.Secuencia = item.Secuencia;
                        Address.IdProducto = item.IdProducto;
                        Address.sc_cantidad = item.sc_cantidad;
                        Address.sc_Precio = item.sc_Precio;
                        Address.sc_descUni = item.sc_descUni;
                        Address.sc_PordescUni = item.sc_PordescUni;
                        Address.sc_precioFinal = (item.sc_precioFinal == 0) ? item.sc_Precio : item.sc_precioFinal;
                        Address.sc_subtotal = item.sc_subtotal;
                        Address.sc_iva = item.sc_iva;
                        Address.sc_total = item.sc_total;
                        Address.sc_costo = item.sc_costo;                      
                        Address.sc_estado = "A";
                        Address.vt_por_iva = item.vt_por_iva;
                        Address.IdPunto_Cargo = item.IdPunto_cargo;
                        Address.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;

                        Address.IdCod_Impuesto_Iva=item.IdCod_Impuesto_Iva;
                        Address.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                        Address.IdCentroCosto = item.IdCentroCosto;
                        Address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                        if (item.DetallexItems==null)
                        { Address.sc_observacion = ""; }
                        else { Address.sc_observacion = item.DetallexItems; }

                        Context.fa_notaCreDeb_det.Add(Address);
                        Context.SaveChanges();
                        Context.Dispose();
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

        public List<fa_notaCreDeb_det_Info> Get_List_notaCreDeb_det(fa_notaCreDeb_Info Info)
        {
            try
            {
                List<fa_notaCreDeb_det_Info> lst = new List<fa_notaCreDeb_det_Info>();

                EntitiesFacturacion oEnti = new EntitiesFacturacion();
                var cons = from q in oEnti.fa_notaCreDeb_det
                           where q.IdEmpresa == Info.IdEmpresa && q.IdSucursal == Info.IdSucursal && q.IdBodega == Info.IdBodega && q.IdNota == Info.IdNota
                           select q;
                
                foreach ( var item  in cons)
                {
                    fa_notaCreDeb_det_Info infogrid = new fa_notaCreDeb_det_Info();
                    infogrid.IdNota = item.IdNota;
                    infogrid.IdEmpresa = item.IdEmpresa;
                    infogrid.IdProducto = (decimal)item.IdProducto;
                    infogrid.IdBodega = item.IdBodega;
                    infogrid.IdSucursal = item.IdSucursal;
                    infogrid.sc_cantidad = (float)item.sc_cantidad;
                    infogrid.sc_descUni = (float)item.sc_descUni;
                    infogrid.sc_observacion = item.sc_observacion;
                    infogrid.sc_iva = (float)item.sc_iva;
                    infogrid.sc_PordescUni = (float)item.sc_PordescUni;
                    infogrid.sc_Precio = (float)item.sc_Precio;
                    infogrid.sc_precioFinal = (float)item.sc_precioFinal;
                    infogrid.sc_subtotal = (float)item.sc_subtotal;
                    infogrid.sc_total = (float)item.sc_total;
                    infogrid.IdPunto_cargo = item.IdPunto_Cargo;
                    infogrid.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    infogrid.Secuencia = item.Secuencia;
                    infogrid.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    infogrid.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                    infogrid.IdCentroCosto = item.IdCentroCosto;
                    infogrid.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    lst.Add(infogrid);
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

        public List<fa_notaCreDeb_det_Info> Get_List_notaCreDeb_det(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                List<fa_notaCreDeb_det_Info> lst = new List<fa_notaCreDeb_det_Info>();

                EntitiesFacturacion oEnti = new EntitiesFacturacion();
                var cons = from q in oEnti.vwfa_notaCreDeb_det_sri
                           where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdNota == IdNota
                           select q;

                foreach (var item in cons)
                {
                    fa_notaCreDeb_det_Info infogrid = new fa_notaCreDeb_det_Info();
                    infogrid.IdNota = item.IdNota;
                    infogrid.IdEmpresa = item.IdEmpresa;
                    infogrid.IdProducto = item.IdProducto;
                    infogrid.Secuencia = item.Secuencia;
                    infogrid.IdBodega = item.IdBodega;
                    infogrid.IdSucursal = item.IdSucursal;
                    infogrid.sc_cantidad = item.sc_cantidad;
                    infogrid.sc_Precio = item.sc_Precio;
                    infogrid.sc_descUni = item.sc_descUni;
                    infogrid.sc_PordescUni = item.sc_PordescUni;
                    infogrid.sc_precioFinal = item.sc_precioFinal;
                    infogrid.sc_subtotal = item.sc_subtotal;
                    infogrid.sc_iva = item.sc_iva;

                    infogrid.sc_total = item.sc_total;
                    infogrid.sc_estado = item.sc_estado;

                    infogrid.pr_codigo = item.pr_codigo;
                    infogrid.pr_descripcion = item.pr_descripcion;
                    infogrid.vt_por_iva = item.vt_por_iva;

                    infogrid.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    infogrid.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                    infogrid.DetallexItems = item.sc_observacion;
                    infogrid.IdCentroCosto = item.IdCentroCosto;
                    infogrid.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    lst.Add(infogrid);
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

        public Boolean EliminarDB(fa_notaCreDeb_Info info)
        {
            try
            {
                List<fa_notaCreDeb_det_Info> ListaEliminar = new List<fa_notaCreDeb_det_Info>();
                ListaEliminar = Get_List_notaCreDeb_det(info);

                foreach (var item in ListaEliminar)
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        var contact = context.fa_notaCreDeb_det.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdBodega == info.IdBodega && obj.IdNota == item.IdNota && obj.Secuencia == item.Secuencia);
                        if (contact != null)
                        {
                            context.fa_notaCreDeb_det.Remove(contact);
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

        public List<vwfa_ContabilizarNotaCredDeb_x_Item_Info> Get_List_fa_ContabilizarNotaCredDeb_Items(int IdEmpresa, int IdSucursal, int IdBodega, Decimal IdNota) 
        {
            try
            {
                List<vwfa_ContabilizarNotaCredDeb_x_Item_Info> lista= new List<vwfa_ContabilizarNotaCredDeb_x_Item_Info>();

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    IQueryable<vwfa_ContabilizarNotaCredDeb_x_Item> Consulta = from q in entity.vwfa_ContabilizarNotaCredDeb_x_Item
                                                                             where q.IdEmpresa == IdEmpresa 
                                                                             && q.IdSucursal == IdSucursal 
                                                                             && q.IdBodega == IdBodega 
                                                                             && q.IdNota == IdNota
                                                                             select q;

                    foreach (var item in Consulta)
                    {

                        vwfa_ContabilizarNotaCredDeb_x_Item_Info Info= new vwfa_ContabilizarNotaCredDeb_x_Item_Info();
                            Info.IdEmpresa=item.IdEmpresa;
                            Info.IdSucursal=item.IdSucursal;
                            Info.IdBodega=item.IdBodega;
                            Info.IdNota=item.IdNota;
                            Info.Iva=item.Iva;
                            Info.Sub_total=item.Sub_total;
                            Info.Total=item.Total;
                            Info.Des_total=item.Des_total;
                            Info.IdPunto_cargo_grupo=item.IdPunto_cargo_grupo;
                            Info.IdPunto_Cargo=item.IdPunto_Cargo;
                            Info.IdProducto=item.IdProducto;
                            Info.IdCtaCble_Vta=item.IdCtaCble_Vta;
                            Info.IdCtaCble_Des0=item.IdCtaCble_Des0;
                            Info.IdCtaCble_DesIva=item.IdCtaCble_DesIva;
                            Info.IdCod_Impuesto_Iva=item.IdCod_Impuesto_Iva;
                            Info.IdCod_Impuesto_Ice=item.IdCod_Impuesto_Ice;
                            Info.IdCentroCosto=item.IdCentroCosto;
                            Info.IdCentroCosto_sub_centro_costo=item.IdCentroCosto_sub_centro_costo;
                            Info.IdCtaCble_Iva=item.IdCtaCble_Iva;
                            Info.IdCtaCble_Ice = item.IdCtaCble_Ice;
                            lista.Add(Info);
                        
                    }


                    return lista;
                }
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

        public List<vwfa_ContabilizarNotaCredDeb_x_sucursal_Info> Get_List_ParaContabilizar_x_sucursal(int IdEmpresa, int IdSucursal, int IdBodega, Decimal IdNota)
        {
            try
            {

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    IQueryable<vwfa_ContabilizarNotaCredDeb_x_sucursal_Info> Consulta = from q in entity.vwfa_ContabilizarNotaCredDeb_x_sucursal
                                                                             where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdNota == IdNota
                                                                                        select new vwfa_ContabilizarNotaCredDeb_x_sucursal_Info
                                                                             {
                                                                                 descuentototal = q.descuentototal,
                                                                                 IdBodega = q.IdBodega,
                                                                                 IdEmpresa = q.IdEmpresa,
                                                                                 IdNota = q.IdNota,
                                                                                 IdSucursal = q.IdSucursal,
                                                                                 IVA = q.IVA,
                                                                                 SUBTOTAL = q.SUBTOTAL,
                                                                                 tOTAL = q.tOTAL
                                                                             };
                    return Consulta.ToList();
                }
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
