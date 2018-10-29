using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

using Core.Erp.Data.General;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri;
using System.Data.Entity.Validation;
using Core.Erp.Data.Academico;
namespace Core.Erp.Data.Facturacion
{
    public class fa_Factura_Data
    {
        string mensaje = "";
        
        string format = "dd/MM/yyyy";
        tb_sis_Documento_Tipo_Talonario_Data Data_sisDocTipoTalo = new tb_sis_Documento_Tipo_Talonario_Data();
        tb_sis_Documento_Tipo_Talonario_Info Info_sisDocTipoTalo = new tb_sis_Documento_Tipo_Talonario_Info(); 

        public Boolean GuardarDB(fa_factura_Info info, ref decimal IdCbt_vta, ref string NumDocFactura ,ref string MensajeError)
        {
            try
            {
                try
                {
                            int num_fact = 0;
                            num_fact = (info.vt_NumFactura==null || info.vt_NumFactura == "") ? 0 : Convert.ToInt32(info.vt_NumFactura);

                            using (EntitiesFacturacion context = new EntitiesFacturacion())
                            {
                                EntitiesFacturacion fact = new EntitiesFacturacion();
                  
                                var addressG = new fa_factura();
                                addressG.IdEmpresa = info.IdEmpresa;
                                addressG.IdSucursal = info.IdSucursal;
                                addressG.IdBodega = info.IdBodega;
                                addressG.IdCbteVta = IdCbt_vta = GetId(info.IdEmpresa, info.IdSucursal, info.IdBodega);
                                addressG.CodCbteVta = "FAC#" + (num_fact == 0 ? info.IdCbteVta.ToString() : num_fact.ToString());
                                addressG.vt_tipoDoc = info.vt_tipoDoc;
                                addressG.vt_autorizacion = info.vt_autorizacion;
                                addressG.vt_serie1 = info.vt_serie1;
                                addressG.vt_serie2 = info.vt_serie2;
                                addressG.vt_NumFactura = info.vt_NumFactura;
                                NumDocFactura = info.vt_serie1 + "-" + info.vt_serie2 + "-" + info.vt_NumFactura;
                                addressG.IdCliente = info.IdCliente;
                                addressG.IdVendedor = info.IdVendedor;
                                addressG.vt_fecha = Convert.ToDateTime(info.vt_fecha.ToShortDateString());
                                addressG.vt_plazo = info.vt_plazo;
                                addressG.vt_fech_venc = Convert.ToDateTime(info.vt_fech_venc.ToShortDateString());
                                addressG.vt_tipo_venta = info.vt_tipo_venta;
                                addressG.vt_Observacion = info.vt_Observacion;//
                                addressG.IdPeriodo = info.IdPeriodo;
                                addressG.vt_anio = info.vt_anio;
                                addressG.vt_mes = info.vt_mes;
                                addressG.vt_seguro = info.vt_seguro;
                                addressG.vt_flete = info.vt_flete;
                                addressG.vt_interes = info.vt_interes;
                                addressG.vt_OtroValor1 = info.vt_OtroValor1;
                                addressG.vt_OtroValor2 = info.vt_OtroValor2;
                    
                                addressG.Estado = info.Estado;
                                addressG.Fecha_Transaccion = DateTime.Now;
                                addressG.ip = info.ip;
                                addressG.IdUsuario = info.IdUsuario;
                                addressG.nom_pc = info.nom_pc;
                                addressG.IdCaja = Convert.ToInt32(info.IdCaja);
                                addressG.IdEmpresa_nc_anu = null;
                                addressG.IdSucursal_nc_anu = null;
                                addressG.IdBodega_nc_anu = null;
                                addressG.IdNota_nc_anu = null;
                                addressG.IdPuntoVta = info.IdPuntoVta;


                                
                    
                                context.fa_factura.Add(addressG);
                                context.SaveChanges();                    
                                //Guarda Detalle Factura
                                if (info.DetFactura_List!= null)
                                {
                                    decimal Id = addressG.IdCbteVta;                                  
                                    fa_factura_det_Data oData = new fa_factura_det_Data();
                                    oData.GuardarDB(info.DetFactura_List, ref Id, ref MensajeError);
                                }
                                //modifico el estatus de usado al numero de la factura
                                Info_sisDocTipoTalo.Establecimiento = info.vt_serie1;
                                Info_sisDocTipoTalo.PuntoEmision = info.vt_serie2;
                                Info_sisDocTipoTalo.NumDocumento = info.vt_NumFactura;
                                Info_sisDocTipoTalo.IdEmpresa = info.IdEmpresa;
                                Info_sisDocTipoTalo.CodDocumentoTipo = info.vt_tipoDoc;
                                Data_sisDocTipoTalo.Modificar_Estado_Usado(Info_sisDocTipoTalo, ref MensajeError);

                                int secuencia = 1;
                                foreach (var q in info.ListDetSubCentros)
                                {
                                    context.fa_factura_det_subcentro.Add(new fa_factura_det_subcentro
                                    {
                                        IdEmpresa = info.IdEmpresa,
                                        IdSucursal = info.IdSucursal,
                                        IdBodega = info.IdBodega,
                                        IdCbteVta = IdCbt_vta,
                                        Secuencia = secuencia++,
                                        vt_cantidad = q.vt_cantidad,
                                        vt_Precio = q.vt_Precio,
                                        vt_PorDescUnitario = q.vt_PorDescUnitario,
                                        vt_DescUnitario = q.vt_DescUnitario,
                                        vt_PrecioFinal = q.vt_PrecioFinal,
                                        vt_Subtotal = q.vt_Subtotal,
                                        IdCod_Impuesto_Iva = q.IdCod_Impuesto_Iva,
                                        vt_por_iva = q.vt_por_iva,
                                        vt_iva = q.vt_iva,
                                        vt_total = q.vt_total,
                                        IdCentroCosto = q.IdCentroCosto,
                                        IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                    });
                                }
                                context.SaveChanges();
                            }

                }
                catch (DbEntityValidationException ex_db)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex_db.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                    MensajeError = ex_db.ToString();
                    throw new Exception(ex_db.ToString());
                }


                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
      
        public Boolean ValidarNumFact(fa_factura_Info info)
        {
            try
            {

                EntitiesFacturacion OEGeneral = new EntitiesFacturacion();
                var q = (from A in OEGeneral.fa_factura
                         where A.vt_NumFactura == info.vt_NumFactura && A.IdEmpresa == info.IdEmpresa && A.IdSucursal == info.IdSucursal && A.IdBodega == info.IdBodega && A.vt_serie1 == info.vt_serie1 && A.vt_serie2 == info.vt_serie2
                         select A).Count();
                if (q > 0) { return true; }
                return false;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public List<fa_factura_Info> Get_List_factura(int IdEmpresa, int IdSucursal ,int IdBodega , DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<fa_factura_Info> FacturaInfo = new List<fa_factura_Info>();
                EntitiesFacturacion OEFAC = new EntitiesFacturacion();

                int IdSucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
                int IdSucursalFin = (IdSucursal == 0) ? 99999 : IdSucursal;
                int IdBodegaIni = (IdBodega == 0) ? 1 : IdBodega;
                int IdBodegaFin = (IdBodega == 0) ? 99999 : IdBodega;

              
                       var SelectFactura = from q in OEFAC.vwfa_factura
                                        where q.IdEmpresa == IdEmpresa
                                        && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                                        && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                        && q.vt_fecha >= FechaIni && q.vt_fecha <= FechaFin
                                        select q;


                foreach (var item in SelectFactura)
                {
                    fa_factura_Info info = new fa_factura_Info();

                    List<fa_factura_det_info> ListDet = new List<fa_factura_det_info>();


                    info.IdCbteVta = item.IdCbteVta;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.vt_serie1 = item.vt_serie1;
                    info.vt_serie2 = item.vt_serie2;
                    info.vt_tipo_venta = item.vt_tipo_venta;
                    info.Bodega = item.bo_Descripcion;
                    info.vt_NumFactura = item.vt_NumFactura;
                    info.Cliente = item.pe_nombreCompleto;
                    info.Vendedor = item.Ve_Vendedor;
                    info.Sucursal = item.Su_Descripcion;
                    info.vt_autorizacion = item.vt_autorizacion;
                    info.IdCliente = item.IdCliente;
                    info.vt_fecha = item.vt_fecha;
                    info.IdVendedor = item.IdVendedor;
                    info.CodCbteVta = item.CodCbteVta;
                    info.vt_fech_venc = item.vt_fech_venc;
                    info.vt_plazo = item.vt_plazo;
                    info.IdUsuario = item.IdUsuario;
                    info.vt_Observacion = item.vt_Observacion;
                    info.Subtotal = Convert.ToDouble(item.vt_Subtotal);
                    info.vt_OtroValor1 = item.vt_OtroValor1;
                    info.vt_OtroValor2 = item.vt_OtroValor2;
                    info.vt_flete = item.vt_flete;
                    info.vt_interes = item.vt_interes;
                    info.vt_seguro = item.vt_seguro;
                    info.vt_tipoDoc = item.vt_tipoDoc;
                    info.Estado = item.Estado;
                    info.IVA = Convert.ToDouble(item.vt_iva);
                    info.Total = Convert.ToDouble(item.vt_total);
                    info.IdCaja = item.IdCaja;
                    info.IdPuntoVta = item.IdPuntoVta;
                  

                    info.IdEmpresa_nc_anu=Convert.ToInt32(item.IdEmpresa_nc_anu);
                    info.IdSucursal_nc_anu = Convert.ToInt32(item.IdSucursal_nc_anu);
                    info.IdBodega_nc_anu = Convert.ToInt32(item.IdBodega_nc_anu);
                    info.IdNota_nc_anu = Convert.ToDecimal(item.IdNota_nc_anu);

                    FacturaInfo.Add(info);

                }

                return FacturaInfo;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public fa_factura_Info Get_Info_factura(int idEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                fa_factura_Info info = new fa_factura_Info();

                EntitiesFacturacion OEFAC = new EntitiesFacturacion();
                //
                var SelectFactura = from q in OEFAC.vwfa_factura select q;

                //
                SelectFactura = from q in OEFAC.vwfa_factura
                                where q.IdEmpresa == idEmpresa
                                && q.IdBodega == IdBodega
                                && q.IdSucursal == IdSucursal
                                && q.IdCbteVta == IdCbteVta
                                select q;



                foreach (var item in SelectFactura)
                {
                    info = new fa_factura_Info();
                    info.IdCbteVta = item.IdCbteVta;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.vt_serie1 = item.vt_serie1;
                    info.vt_serie2 = item.vt_serie2;
                    info.vt_tipo_venta = item.vt_tipo_venta;
                    info.Bodega = item.bo_Descripcion;
                    info.vt_NumFactura = item.vt_NumFactura;
                    info.Cliente = item.pe_nombreCompleto;
                    info.Vendedor = item.Ve_Vendedor;
                    info.Sucursal = item.Su_Descripcion;
                    info.vt_autorizacion = item.vt_autorizacion;
                    info.IdCliente = item.IdCliente;
                    info.vt_fecha = item.vt_fecha;
                    info.IdVendedor = item.IdVendedor;
                    info.CodCbteVta = item.CodCbteVta;
                    info.vt_fech_venc = item.vt_fech_venc;
                    info.vt_plazo = item.vt_plazo;
                    info.IdUsuario = item.IdUsuario;
                    info.vt_Observacion = item.vt_Observacion;
                    info.Subtotal = Convert.ToDouble(item.vt_Subtotal);
                    info.vt_OtroValor1 = item.vt_OtroValor1;
                    info.vt_OtroValor2 = item.vt_OtroValor2;
                    info.vt_flete = item.vt_flete;
                    info.vt_interes = item.vt_interes;
                    info.vt_seguro = item.vt_seguro;
                    info.vt_tipoDoc = item.vt_tipoDoc;
                    info.Estado = item.Estado;
                    info.IVA = Convert.ToDouble(item.vt_iva);
                    info.Total = Convert.ToDouble(item.vt_total);
                    info.IdCaja = Convert.ToInt32(item.IdCaja);
                    info.IdEmpresa_nc_anu = Convert.ToInt32(item.IdEmpresa_nc_anu);
                    info.IdSucursal_nc_anu = Convert.ToInt32(item.IdSucursal_nc_anu);
                    info.IdBodega_nc_anu = Convert.ToInt32(item.IdBodega_nc_anu);
                    info.IdNota_nc_anu = Convert.ToDecimal(item.IdNota_nc_anu);

                    info.IdPuntoVta = item.IdPuntoVta;

                }

                return info;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public fa_factura_Info Get_Info_factura_x_Numero_Factura(int IdEmpresa, int IdSucursal, int IdBodega, string NumFac)
        {
            try
            {
                fa_factura_Info info = new fa_factura_Info();

                EntitiesFacturacion OEFAC = new EntitiesFacturacion();
                //
                var SelectFactura = from q in OEFAC.vwfa_factura select q;

               
                SelectFactura = from q in OEFAC.vwfa_factura
                                where q.IdEmpresa == IdEmpresa
                                && q.IdBodega == IdBodega
                                && q.IdSucursal == IdSucursal
                                && q.vt_NumFactura == NumFac
                                select q;




                foreach (var item in SelectFactura)
                {
                    info = new fa_factura_Info();

                    info.IdCbteVta = item.IdCbteVta;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.vt_serie1 = item.vt_serie1;
                    info.vt_serie2 = item.vt_serie2;
                    info.vt_tipo_venta = item.vt_tipo_venta;
                    info.Bodega = item.bo_Descripcion;
                    info.vt_NumFactura = item.vt_NumFactura;
                    info.Cliente = item.pe_nombreCompleto;
                    info.Vendedor = item.Ve_Vendedor;
                    info.Sucursal = item.Su_Descripcion;
                    info.vt_autorizacion = item.vt_autorizacion;
                    info.IdCliente = item.IdCliente;
                    info.vt_fecha = item.vt_fecha;
                    info.IdVendedor = item.IdVendedor;
                    info.CodCbteVta = item.CodCbteVta;
                    info.vt_fech_venc = item.vt_fech_venc;
                    info.vt_plazo = item.vt_plazo;
                    info.IdUsuario = item.IdUsuario;
                    info.vt_Observacion = item.vt_Observacion;
                    info.Subtotal = Convert.ToDouble(item.vt_Subtotal);
                    info.vt_OtroValor1 = item.vt_OtroValor1;
                    info.vt_OtroValor2 = item.vt_OtroValor2;
                    info.vt_flete = item.vt_flete;
                    info.vt_interes = item.vt_interes;
                    info.vt_seguro = item.vt_seguro;
                    info.vt_tipoDoc = item.vt_tipoDoc;
                    info.Estado = item.Estado;
                    info.IVA = Convert.ToDouble(item.vt_iva);
                    info.Total = Convert.ToDouble(item.vt_total);
                    info.IdCaja = Convert.ToInt32(item.IdCaja);
                    info.IdEmpresa_nc_anu = Convert.ToInt32(item.IdEmpresa_nc_anu);
                    info.IdSucursal_nc_anu = Convert.ToInt32(item.IdSucursal_nc_anu);
                    info.IdBodega_nc_anu = Convert.ToInt32(item.IdBodega_nc_anu);
                    info.IdNota_nc_anu = Convert.ToDecimal(item.IdNota_nc_anu);

                    info.IdPuntoVta = item.IdPuntoVta;

                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_factura_Info info, ref string msgs)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_factura.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdCbteVta == info.IdCbteVta && cot.IdSucursal == info.IdSucursal && cot.IdBodega == info.IdBodega);

                    if (contact != null)
                    {
                        contact.IdCliente = info.IdCliente;
                        contact.IdVendedor = info.IdVendedor;
                        contact.vt_fecha = Convert.ToDateTime(info.vt_fecha.ToShortDateString());
                        contact.vt_plazo = Convert.ToInt32(info.vt_plazo);
                        contact.IdPeriodo = info.IdPeriodo;
                        contact.vt_anio = info.vt_anio;
                        contact.vt_fech_venc = info.vt_fech_venc;
                        contact.vt_fecha = info.vt_fecha;
                        contact.vt_flete = info.vt_flete;
                        contact.vt_seguro = info.vt_seguro;
                        contact.vt_interes = info.vt_interes;
                        contact.vt_mes = info.vt_mes;
                        contact.vt_NumFactura = info.vt_NumFactura;
                        contact.vt_Observacion = info.vt_Observacion;
                        contact.vt_OtroValor1 = info.vt_OtroValor1;
                        contact.vt_OtroValor2 = info.vt_OtroValor2;
                        contact.vt_serie1 = info.vt_serie1;
                        contact.vt_serie2 = info.vt_serie2;
                        contact.vt_tipo_venta = info.vt_tipo_venta;
                        contact.vt_tipoDoc = info.vt_tipoDoc;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.IdUsuarioUltModi = info.IdUsuarioUltModi;
                        contact.IdCaja = Convert.ToInt32(info.IdCaja);

                        contact.IdPuntoVta = info.IdPuntoVta;

                        context.fa_factura_det_subcentro.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdBodega == info.IdBodega && q.IdCbteVta == info.IdCbteVta).ToList().ForEach(q=> context.fa_factura_det_subcentro.Remove(q));
                        
                        int secuencia = 1;
                        foreach (var q in info.ListDetSubCentros)
                        {
                            context.fa_factura_det_subcentro.Add(new fa_factura_det_subcentro
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdSucursal = info.IdSucursal,
                                IdBodega = info.IdBodega,
                                IdCbteVta = info.IdCbteVta,
                                Secuencia = secuencia++,
                                vt_cantidad = q.vt_cantidad,
                                vt_Precio = q.vt_Precio,
                                vt_PorDescUnitario = q.vt_PorDescUnitario,
                                vt_DescUnitario = q.vt_DescUnitario,
                                vt_PrecioFinal = q.vt_PrecioFinal,
                                vt_Subtotal = q.vt_Subtotal,
                                IdCod_Impuesto_Iva = q.IdCod_Impuesto_Iva,
                                vt_por_iva = q.vt_por_iva,
                                vt_iva = q.vt_iva,
                                vt_total = q.vt_total,
                                IdCentroCosto = q.IdCentroCosto,
                                IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                            });
                        }
                        context.SaveChanges();                        
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
                msgs = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(fa_factura_Info info)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_factura.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdCbteVta == info.IdCbteVta && cot.IdSucursal == info.IdSucursal && cot.IdBodega == info.IdBodega);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        /*contact.IdEmpresa_nc_anu = info.IdEmpresa_nc_anu;
                        contact.IdSucursal_nc_anu = info.IdSucursal_nc_anu;
                        contact.IdBodega_nc_anu = info.IdBodega_nc_anu;
                        contact.IdNota_nc_anu = info.IdNota_nc_anu;
                        contact.vt_Observacion = "**Anulado con la Nota Credito#:" + info.IdNota_nc_anu + " " + contact.vt_Observacion;
                        */
                        contact.vt_Observacion = "***ANULADO*** "+info.vt_Observacion;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
                        contact.IdUsuarioUltAnu = info.IdUsuario;
                        context.SaveChanges();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean validar(fa_guia_remision_Info infoGuir, fa_cotizacion_info infoCot)
        {
            try
            {
                EntitiesFacturacion aux = new EntitiesFacturacion();
                var x = (from q in aux.fa_factura_x_fa_guia_remision
                         where q.gi_IdEmpresa == infoGuir.IdEmpresa && q.gi_IdSucursal == infoGuir.IdSucursal && q.gi_IdBodega == infoGuir.IdBodega && q.gi_IdGuiaRemision == infoGuir.IdGuiaRemision
                         select q).Count();

                var y = (from q in aux.fa_factura_x_fa_cotizacion
                         where q.cc_IdEmpresa == infoCot.IdEmpresa && q.cc_IdSucursal == infoCot.IdSucursal && q.cc_IdBodega == infoCot.IdBodega && q.cc_IdCotizacion == infoCot.IdCotizacion
                         select q).Count();
                if (x > 0) { return true; }
                if (y > 0) { return true; }
                return false;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",  "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_factura_Info> Get_Lits_FacturaDEV(int IdEmpresa, int IdSucursal, int IdBodega
            , DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                

                List<fa_factura_Info> ListFacturaInfo = new List<fa_factura_Info>();


                EntitiesFacturacion OEFAC = new EntitiesFacturacion();

                int IdSucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
                int IdSucursalFin = (IdSucursal == 0) ? 99999 : IdSucursal;
                int IdBodegaIni = (IdBodega == 0) ? 1 : IdBodega;
                int IdBodegaFin = (IdBodega == 0) ? 99999 : IdBodega;

                

                   var CabeceraFactura = from cab in OEFAC.vwfa_Factura_Dev
                                         where cab.IdEmpresa == IdEmpresa
                                            && cab.vt_fecha >= FechaIni && cab.vt_fecha <= FechaFin
                                            && cab.IdSucursal >= IdSucursalIni && cab.IdSucursal <= IdSucursalFin
                                            && cab.IdBodega >= IdBodegaIni && cab.IdBodega <= IdBodegaFin
                                      group cab by new
                                      {
                                          cab.IdEmpresa,
                                          cab.IdSucursal,
                                          cab.IdBodega,
                                          cab.bo_Descripcion,
                                          cab.IdCbteVta,
                                          cab.vt_NumFactura,
                                          cab.IdCliente,
                                          cab.vt_tipoDoc,
                                          cab.vt_flete,
                                          cab.vt_serie1,
                                          cab.vt_autorizacion,
                                          cab.vt_serie2,
                                          cab.IdUsuario,
                                          cab.pe_nombreCompleto,
                                          cab.IdVendedor,
                                          cab.Ve_Vendedor,
                                          cab.vt_tipo_venta,
                                          cab.Su_Descripcion,
                                          cab.vt_OtroValor1,
                                          cab.vt_OtroValor2,
                                          cab.CodCbteVta,
                                          cab.vt_interes,
                                          cab.vt_fecha,
                                          cab.vt_fech_venc,
                                          cab.vt_plazo,
                                          cab.vt_Observacion
                                       ,
                                          cab.Estado                                          
                                      }
                                          into grouping
                                          select new { grouping.Key, subototal = grouping.Sum(p => p.vt_Subtotal), iva = grouping.Sum(p => p.vt_iva), Total = grouping.Sum(p => p.vt_total), CANT = grouping.Sum(p => p.vt_cantidad) };


                int x = 0;
                foreach (var item in CabeceraFactura)
                {
                    fa_factura_Info info = new fa_factura_Info();

                    List<fa_factura_det_info> ListDet = new List<fa_factura_det_info>();
                    EntitiesFacturacion dev = new EntitiesFacturacion();

                    info.IdCbteVta = item.Key.IdCbteVta;
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.IdBodega = item.Key.IdBodega;
                    info.vt_serie1 = item.Key.vt_serie1;
                    info.vt_serie2 = item.Key.vt_serie2;
                    info.vt_tipo_venta = item.Key.vt_tipo_venta;
                    info.Bodega = item.Key.bo_Descripcion;
                    info.vt_NumFactura = item.Key.vt_NumFactura;
                    info.Cliente = item.Key.pe_nombreCompleto;
                    info.Vendedor = item.Key.Ve_Vendedor;
                    info.Sucursal = item.Key.Su_Descripcion;
                    info.vt_autorizacion = item.Key.vt_autorizacion;
                    info.IdCliente = item.Key.IdCliente;
                    info.vt_fecha = item.Key.vt_fecha;
                    info.IdVendedor = item.Key.IdVendedor;
                    info.CodCbteVta = item.Key.CodCbteVta;
                    info.vt_fech_venc = item.Key.vt_fech_venc;
                    info.vt_plazo = item.Key.vt_plazo;
                    info.IdUsuario = item.Key.IdUsuario;
                    info.vt_Observacion = item.Key.vt_Observacion;
                    info.Subtotal = Convert.ToDouble(item.subototal);
                    info.vt_OtroValor1 = item.Key.vt_OtroValor1;
                    info.vt_OtroValor2 = item.Key.vt_OtroValor2;
                    info.vt_flete = item.Key.vt_flete;
                    info.vt_interes = item.Key.vt_interes;
                    info.vt_tipoDoc = item.Key.vt_tipoDoc;
                    info.Estado = item.Key.Estado;
                    info.IVA = Convert.ToDouble(item.iva);
                    info.Total = Convert.ToDouble(item.Total);


                   
                    ListFacturaInfo.Add(info);

                }

                return ListFacturaInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public fa_factura_Info Get_Info_FactuXGuia(fa_guia_remision_Info info)
        {
            try
            {
                fa_factura_Info obj = new fa_factura_Info();
                EntitiesFacturacion OEFAC = new EntitiesFacturacion();

                var ent = OEFAC.fa_factura_x_fa_guia_remision.First(var => var.gi_IdEmpresa == info.IdEmpresa && var.gi_IdSucursal == info.IdSucursal && var.gi_IdBodega == info.IdSucursal && var.gi_IdGuiaRemision == info.IdGuiaRemision);
                var fac = OEFAC.fa_factura.First(var => var.IdCbteVta == ent.fa_IdCbteVta && var.IdEmpresa == ent.fa_IdEmpresa);

                obj.IdCbteVta = fac.IdCbteVta;
                obj.vt_fecha = fac.vt_fecha;
                obj.vt_serie1 = fac.vt_serie1;
                obj.vt_serie2 = fac.vt_serie2;
                obj.vt_NumFactura = fac.vt_NumFactura;
                obj.vt_Observacion = fac.vt_Observacion;
                obj.IdCaja = Convert.ToInt32(fac.IdCaja);
                

                return obj;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
            
            
          
        }


        public List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleVentas> Get_List_VentasParaATS(int IdEmpresa, int anio, int mes)
        {
            try
            {
                List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleVentas> Lista= new List<Info.CuentasxPagar.xmlATS_V_1_1_4.detalleVentas>();

                fa_Cliente_Data OdataCliente = new fa_Cliente_Data();



                using (EntitiesFacturacion OEFAC = new EntitiesFacturacion())
                {

                    OEFAC.SetCommandTimeOut(3000);

                    var SelectFactura = from cab in OEFAC.vwFa_Documento_DeclaracionSRI_DATA
                                        where cab.IdEmpresa == IdEmpresa
                                        && cab.anio == anio
                                        && cab.mes == mes
                                        select cab;



                    foreach (var item in SelectFactura)
                    {
                        Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleVentas Info= new Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleVentas();

                        Info.baseImpGrav = Convert.ToDecimal(item.baseImpGrav);
                        Info.baseImponible = Convert.ToDecimal(item.baseNoGraIva);
                        Info.baseNoGraIva = 0;

                        if (OdataCliente.Get_Cliente_Es_Parte_Relacionada(IdEmpresa, item.idCliente))
                        {
                            Info.parteRelVtas = Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.parteRelType.SI;
                        }
                        else
                        {
                            Info.parteRelVtas = Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.parteRelType.NO;
                        }
                        
                        
                        Info.idCliente = item.idCliente;
                        Info.montoIce = 0;
                        Info.montoIva = Convert.ToDecimal(item.montoIva);
                        Info.numeroComprobantes = item.numeroComprobantes;

                        
                       
                        Info.tipoComprobante = item.tipoComprobante;
                        Info.formasDePago = null;


                        if (item.tipoComprobante=="18")//los tipo forma pago x factura
                        {
                            Info.formasDePago = Get_list_Forma_Pago_x_Cliente(IdEmpresa, item.idCliente, anio, mes);
                        }

                        if (item.tipoComprobante == "05")//los tipo de forma de pago por debito no esta programado terminar de programar en la pantalla de VZEN 
                        {
                            string[] AFormaPago = { "20" }; //quemo para los notas debito porq el dimmm me lo pide
                            Info.formasDePago = AFormaPago;
                        }


                        Info.tipoEmision = Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.tipoEmisionType.F;
                        
                        
                        Info.tpIdCliente = item.tpIdCliente;

                        if (Info.tpIdCliente == "06")
                        {
                            Info.denoCli = item.Razon_Social;
                            if (Info.denoCli.Length > 0)
                            {

                                Info.denoCli=Info.denoCli.Replace(".", "");
                                Info.denoCli = Info.denoCli.Trim();
                            }
                            else
                            {
                                Info.denoCli = "cliente";
                            }

                            if (item.idCliente.Length > 10)
                            {
                                Info.tipoCliente = "02";
                            }
                            else
                            {
                                Info.tipoCliente = "01";
                            }
                        }



                        Info.valorRetIva = "0.00";
                        Info.valorRetRenta = "0.00";


                        using (EntitiesCuentas_x_Cobrar OECXC = new EntitiesCuentas_x_Cobrar())
                        {

                            if (item.tipoComprobante == "18")//los tipo forma pago x factura
                            {


                                var SelectRet = from cab in OECXC.vwcxc_cobros_x_vta_x_RetFte_x_Cliente_x_AnioMes
                                                where cab.IdEmpresa == IdEmpresa
                                                && cab.IdAnioRT == anio
                                                && cab.IdMes == mes
                                                && cab.pe_cedulaRuc == item.idCliente
                                                select cab;

                                if (item.idCliente == "0992328495001")
                                {
                                    item.idCliente = item.idCliente;
                                }

                                foreach (var itemRT in SelectRet)
                                {
                                    Info.valorRetRenta = Math.Round(Convert.ToDecimal(itemRT.Valor_ret), 2, MidpointRounding.AwayFromZero).ToString();
                                }



                                var SelectRetIva = from cab in OECXC.vwcxc_cobros_x_vta_x_RetIva_x_Cliente_x_AnioMes
                                                   where cab.IdEmpresa == IdEmpresa
                                                   && cab.IdAnioRT == anio
                                                   && cab.IdMes == mes
                                                   && cab.pe_cedulaRuc == item.idCliente
                                                   select cab;



                                foreach (var itemRTIva in SelectRetIva)
                                {
                                    Info.valorRetIva = Math.Round(Convert.ToDecimal(itemRTIva.Valor_ret), 2, MidpointRounding.AwayFromZero).ToString();
                                }


                            }

                            if (item.tipoComprobante == "05")//las retenciones x Nota Deb
                            {


                                var SelectRet = from cab in OECXC.vwcxc_cobros_x_ND_x_RetFte_x_Cliente_x_AnioMes
                                                where cab.IdEmpresa == IdEmpresa
                                                && cab.IdAnioRT == anio
                                                && cab.IdMes == mes
                                                && cab.pe_cedulaRuc == item.idCliente
                                                select cab;

                                if (item.idCliente == "0992328495001")
                                {
                                    item.idCliente = item.idCliente;
                                }

                                foreach (var itemRT in SelectRet)
                                {
                                    Info.valorRetRenta = Math.Round(Convert.ToDecimal(itemRT.Valor_ret), 2, MidpointRounding.AwayFromZero).ToString();
                                }



                                var SelectRetIva = from cab in OECXC.vwcxc_cobros_x_ND_x_RetIva_x_Cliente_x_AnioMes
                                                   where cab.IdEmpresa == IdEmpresa
                                                   && cab.IdAnioRT == anio
                                                   && cab.IdMes == mes
                                                   && cab.pe_cedulaRuc == item.idCliente
                                                   select cab;



                                foreach (var itemRTIva in SelectRetIva)
                                {
                                    Info.valorRetIva = Math.Round(Convert.ToDecimal(itemRTIva.Valor_ret), 2, MidpointRounding.AwayFromZero).ToString();
                                }

                            }


                        }//fin using










                        Lista.Add(Info);
                    }



                    


                    return Lista;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        private string[] Get_list_Forma_Pago_x_Cliente(int IdEmpresa, string cedula, int IdAnio, int IdMes)
        {
            
            try
            {
                List<string> lista = new List<string>();
                string[] lista_final = { ""};



                using (EntitiesFacturacion OEFAC = new EntitiesFacturacion())
                {
                    var SelectFactura = from cab in OEFAC.vwFa_Formas_Pago_x_Factura_DeclaracionSRI
                                        where cab.IdEmpresa == IdEmpresa
                                        && cab.Idanio == IdAnio
                                        && cab.IdMes == IdMes
                                        && cab.pe_cedulaRuc == cedula
                                        select cab;


                    foreach (var item in SelectFactura)
                    {

                        lista.Add(item.IdFormaPago);
                    }


                }

                if (lista.Count() > 0)
                {
                    int indice = 0;

                    Array.Resize(ref lista_final, lista.Count);

                    foreach (string item in lista)
                    {
                        lista_final[indice] = item;
                        indice++;
                    }
                }
                else
                {
                    Array.Resize(ref lista_final, 1);
                    lista_final[0] = "01";
                    
                }


                return lista_final;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
                
            }

        }

        public List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.ventaEst> Get_List_VentasXEstablecimientoParaATS(int IdEmpresa, int anio, int mes)
        {
            try
            {
                using (EntitiesFacturacion enty = new EntitiesFacturacion())
                {
                   

                    string query = " select T1.vt_serie1 as codEstab,  convert(decimal(18,2),sum(case when RTRIM(LTRIM(T1.vt_tipoDoc))='C' then T1.total*-1 else  T1.total end) ) as ventasEstab   ";
                    query = query + " from (select vt_tipoDoc,vt_serie1,sum(baseNoGraIva)+ Sum(baseImpGrav) as total  from vwFa_Documento_DeclaracionSRI   ";
                    query = query + " where idempresa= " + IdEmpresa;
                    query = query + " and Year(vt_fecha)= " + anio ;
                    query = query + " and month(vt_fecha)=" + mes ;
                    query = query + " group by  vt_tipoDoc,vt_serie1)T1  group by T1.vt_serie1 ";


                    IEnumerable<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.ventaEst> dat = enty.Database.SqlQuery<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.ventaEst>(query);
                    return dat.ToList();
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<vwfa_ContabilizacionFactura_Info> Get_List_Contabilizacion_x_Categoria(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdFactura)
        {
            try
            {

                List<vwfa_ContabilizacionFactura_Info> lista = new List<vwfa_ContabilizacionFactura_Info>();

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    var SQuerry = from q in entity.vwfa_ContabilizacionFactura
                                  where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega
                                  && q.IdCbteVta == IdFactura
                                  select q;

                    foreach (var item in SQuerry)
                    {
                        vwfa_ContabilizacionFactura_Info Info = new vwfa_ContabilizacionFactura_Info();
                        Info.IdBodega = item.IdBodega;
                        Info.IdCategoria = item.IdCategoria;
                        Info.IdCbteVta = item.IdCbteVta;
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.iva = item.iva;
                        Info.Subtotal = item.Subtotal;
                        Info.Total = item.Total;
                        Info.Descuento = item.Descuento;

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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<vwfa_ContabilizacionFactura_x_Sucursal_Info> Get_List_Contabilizacion_x_Sucursal(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdFactura)
        {

            try
            {


                List<vwfa_ContabilizacionFactura_x_Sucursal_Info> lista = new List<vwfa_ContabilizacionFactura_x_Sucursal_Info>();

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    var SQuerry = from q in entity.vwfa_ContabilizacionFactura_x_Sucursal
                                  where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega
                                  && q.IdCbteVta == IdFactura
                                  select q;

                    foreach (var item in SQuerry)
                    {
                        vwfa_ContabilizacionFactura_x_Sucursal_Info Info = new vwfa_ContabilizacionFactura_x_Sucursal_Info();

                        Info.IdBodega = item.IdBodega;
                        Info.IdCbteVta = item.IdCbteVta;
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.iva = item.iva;
                        Info.Subtotal = item.Subtotal;
                        Info.Total = item.Total;
                        
                        Info.Descuento = item.Descuento;

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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<vwfa_ContabilizacionFactura_x_Item_Info> Get_List_Contabilizacion_x_Item(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdFactura)
        {

            try
            {
                List<vwfa_ContabilizacionFactura_x_Item_Info> lista= new List<vwfa_ContabilizacionFactura_x_Item_Info>();

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    lista = entity.vwfa_ContabilizacionFactura_x_Subcentro.Where(q => q.IdEmpresa == IdEmpresa
                        && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdCbteVta == IdFactura).Select(q => new vwfa_ContabilizacionFactura_x_Item_Info
                        {
                             IdBodega = q.IdBodega,
                             IdCbteVta = q.IdCbteVta,
                             IdEmpresa = q.IdEmpresa,
                             IdSucursal = q.IdSucursal,
                             iva = q.iva,
                             Subtotal = q.Subtotal,
                             Total = q.Total,
                            
                             Descuento = q.Descuento,
                             IdCtaCble_Ven0 = q.IdCtaCble_Ven0,
                             IdCtaCble_VenIva = q.IdCtaCble_VenIva,
                             vt_tipo_venta = q.vt_tipo_venta,
                             vt_plazo = q.vt_plazo,
                             IdCod_Impuesto_Iva = q.IdCod_Impuesto_Iva,

                             IdCentroCosto = q.IdCentroCosto,
                             IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                             IdCtaCble_Imp_Iva = q.IdCtaCble_Imp_Iva,
                        }).ToList();

                    if (lista.Count == 0)
                    {
                        lista = entity.vwfa_ContabilizacionFactura_x_Item.Where(q => q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdCbteVta == IdFactura).Select(q => new vwfa_ContabilizacionFactura_x_Item_Info
                            {
                                IdBodega = q.IdBodega,
                                IdCbteVta = q.IdCbteVta,
                                IdEmpresa = q.IdEmpresa,
                                IdSucursal = q.IdSucursal,
                                iva = q.iva,
                                IdCtaCble_DesIva = q.IdCtaCble_DesIva,
                                IdCtaCble_Des0 = q.IdCtaCble_Des0,
                                Subtotal = q.Subtotal,
                                Total = q.Total,

                                Descuento = q.Descuento,
                                IdCtaCble_Ven0 = q.IdCtaCble_Ven0,
                                IdCtaCble_VenIva = q.IdCtaCble_VenIva,
                                vt_tipo_venta = q.vt_tipo_venta,
                                vt_plazo = q.vt_plazo,
                                IdCod_Impuesto_Iva = q.IdCod_Impuesto_Iva,

                                IdCentroCosto = q.IdCentroCosto,
                                IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                IdCtaCble_Imp_Iva = q.IdCtaCble_Imp_Iva,
                            }).ToList();    
                    }
                
                return lista;
                }
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<vwfa_ContabilizacionFactura_x_Costo_Info> Get_List_Contabilizacion_x_Costo_x_Venta(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdFactura)
        {

            try
            {
                List<vwfa_ContabilizacionFactura_x_Costo_Info> lista = new List<vwfa_ContabilizacionFactura_x_Costo_Info>();

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    var SQuerry = from q in entity.vwfa_ContabilizacionFactura_x_Costo
                                  where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega
                                  && q.IdCbteVta == IdFactura
                                  select q;

                    foreach (var item in SQuerry)
                    {
                        vwfa_ContabilizacionFactura_x_Costo_Info Info = new vwfa_ContabilizacionFactura_x_Costo_Info();

                        Info.IdBodega = item.IdBodega;
                        Info.IdCbteVta = item.IdCbteVta;
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdProducto = item.IdProducto;
                        Info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                        Info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                        Info.vt_costo = item.vt_costo;
                        Info.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                        Info.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Get_Keys_CteCble_x_Costo(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, ref int ct_IdEmpresa, ref int ct_IdTipoCbte, ref decimal ct_IdCbteCble)
        {
            try
            {
                fa_factura_x_in_movi_inve_Info factMoviInfo = new fa_factura_x_in_movi_inve_Info();
                in_movi_inve_x_ct_cbteCble_Info moviInveInfo = new in_movi_inve_x_ct_cbteCble_Info();
                in_movi_inve_x_ct_cbteCble_Data DataMoviInve = new in_movi_inve_x_ct_cbteCble_Data();
                fa_factura_x_in_movi_inve_Data data_fac_x_movi_inv = new fa_factura_x_in_movi_inve_Data();


                factMoviInfo = data_fac_x_movi_inv.Get_Info_fa_factura_x_in_movi_inve_x_Factura_(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
                moviInveInfo = DataMoviInve.Get_Info_x_Movi_Inven(factMoviInfo.inv_IdEmpresa, factMoviInfo.inv_IdSucursal, factMoviInfo.inv_IdBodega, factMoviInfo.inv_IdMovi_inven_tipo, factMoviInfo.inv_IdNumMovi);

               ct_IdEmpresa = moviInveInfo.IdEmpresa;
               ct_IdTipoCbte = moviInveInfo.IdTipoCbte;
               ct_IdCbteCble = moviInveInfo.IdCbteCble;

                return true;
                
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                int Id;
                EntitiesFacturacion OECompras = new EntitiesFacturacion();
                var select = from q in OECompras.fa_factura
                             where q.IdEmpresa == IdEmpresa &&
                                     q.IdSucursal == IdSucursal
                                     && q.IdBodega == IdBodega
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OECompras.fa_factura
                                     where q.IdEmpresa == IdEmpresa &&
                                         q.IdSucursal == IdSucursal
                                         && q.IdBodega == IdBodega
                                     select q.IdCbteVta).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                    Id = (Id == 0) ? 1 : Id;
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }



        // consulta de Factura CAH

        public List<fa_factura_Info> Get_List_factura_CAH(int IdEmpresa, int IdSucursal, int IdBodega, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<fa_factura_Info> FacturaInfo = new List<fa_factura_Info>();
                Entities_Academico OEFAC = new  Entities_Academico ();

                int IdSucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
                int IdSucursalFin = (IdSucursal == 0) ? 99999 : IdSucursal;
                int IdBodegaIni = (IdBodega == 0) ? 1 : IdBodega;
                int IdBodegaFin = (IdBodega == 0) ? 99999 : IdBodega;


                var SelectFactura = from q in OEFAC.vwfa_factura_CAH
                                    where q.IdEmpresa == IdEmpresa
                                    && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                                    && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                    && q.vt_fecha >= FechaIni && q.vt_fecha <= FechaFin
                                    select q;


                foreach (var item in SelectFactura)
                {
                    fa_factura_Info info = new fa_factura_Info();

                    List<fa_factura_det_info> ListDet = new List<fa_factura_det_info>();


                    info.IdCbteVta = item.IdCbteVta;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.vt_serie1 = item.vt_serie1;
                    info.vt_serie2 = item.vt_serie2;
                    info.vt_tipo_venta = item.vt_tipo_venta;
                    info.Bodega = item.bo_Descripcion;
                    info.vt_NumFactura = item.vt_NumFactura;
                    info.Cliente = item.pe_nombreCompleto;
                    info.Vendedor = item.Ve_Vendedor;
                    info.Sucursal = item.Su_Descripcion;
                    info.vt_autorizacion = item.vt_autorizacion;
                    info.IdCliente = item.IdCliente;
                    info.vt_fecha = item.vt_fecha;
                    info.IdVendedor = item.IdVendedor;
                    info.CodCbteVta = item.CodCbteVta;
                    info.vt_fech_venc = item.vt_fech_venc;
                    info.vt_plazo = item.vt_plazo;
                    info.IdUsuario = item.IdUsuario;
                    info.vt_Observacion = item.vt_Observacion;
                    info.Subtotal = Convert.ToDouble(item.vt_Subtotal);
                    info.vt_OtroValor1 = item.vt_OtroValor1;
                    info.vt_OtroValor2 = item.vt_OtroValor2;
                    info.vt_flete = item.vt_flete;
                    info.vt_interes = item.vt_interes;
                    info.vt_seguro = item.vt_seguro;
                    info.vt_tipoDoc = item.vt_tipoDoc;
                    info.Estado = item.Estado;
                    info.IVA = Convert.ToDouble(item.vt_iva);
                    info.Total = Convert.ToDouble(item.vt_total);
                    info.IdCaja = item.IdCaja;
                    info.IdPuntoVta = item.IdPuntoVta;
                    info.Estudiante = item.pe_apellido + " " + item.pe_nombre;

                    info.IdEmpresa_nc_anu = Convert.ToInt32(item.IdEmpresa_nc_anu);
                    info.IdSucursal_nc_anu = Convert.ToInt32(item.IdSucursal_nc_anu);
                    info.IdBodega_nc_anu = Convert.ToInt32(item.IdBodega_nc_anu);
                    info.IdNota_nc_anu = Convert.ToDecimal(item.IdNota_nc_anu);

                    FacturaInfo.Add(info);

                }

                return FacturaInfo;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

    }
}
