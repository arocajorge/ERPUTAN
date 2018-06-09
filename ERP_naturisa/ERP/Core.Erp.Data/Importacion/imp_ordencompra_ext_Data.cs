using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Importacion
{
    public class imp_ordencompra_ext_Data
    {
        string mensaje = "";
        public decimal IdOrdeExte { get; set; }
        imp_DatosEmbarque_Data DataDatosEmbarque = new imp_DatosEmbarque_Data();
        imp_ordencompra_ext_det_Data DataOrdeCompraDetalle = new imp_ordencompra_ext_det_Data();
        imp_ordencompra_ext_x_imp_gastosxImport_Data DataGastos = new imp_ordencompra_ext_x_imp_gastosxImport_Data();
        imp_ordencompra_ext_x_Condiciones_Pago_Data DataCondicionPago = new imp_ordencompra_ext_x_Condiciones_Pago_Data();

        public Boolean AnularDB(imp_ordencompra_ext_Info Info) 
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    var contact = context.imp_ordencompra_ext.FirstOrDefault(Impo => Impo.IdEmpresa == Info.IdEmpresa && Impo.IdOrdenCompraExt == Info.IdOrdenCompraExt && Impo.IdSucusal == Info.IdSucusal);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.ci_Observacion = " ***ANULADO***" + contact.ci_Observacion;
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.MotiAnula = Info.MotiAnula;
                        context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(imp_ordencompra_ext_Info Info, ref decimal IdOrdeExte) 
        {
            try
            {

                using(EntitiesImportacion Contex = new EntitiesImportacion()){
                    var Address = new imp_ordencompra_ext();
                    IdOrdeExte = GetId(Info);
                    Info.IdOrdenCompraExt = IdOrdeExte;
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucusal = Info.IdSucusal;
                    Address.IdOrdenCompraExt = IdOrdeExte;
                    Address.NumFacturaProvedor = Info.NumFacturaProvedor;
                    if (Info.CodOrdenCompraExt == "")
                    { Address.CodOrdenCompraExt = "IMP"+Info.IdOrdenCompraExt.ToString(); }
                    else 
                    {
                        Address.CodOrdenCompraExt = Info.CodOrdenCompraExt;
                    }
                    Address.Fecha_Maximo_Despacho = Info.Fecha_Maximo_Despacho;
                    Address.ci_diasEmbarque = Info.ci_DiasEmbarque;
                    Address.IdEstadoLiquidacion = "XLQDAR";
                    Address.ci_plazo = Info.ci_plazo;
                    Address.ci_fecha = Convert.ToDateTime(Info.ci_fecha.ToShortDateString());
                    Address.IdProveedor = Info.IdProveedor;
                    Address.ci_Observacion = Info.ci_Observacion;
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    Address.Estado ="A";
                    Address.IdUsuario = Info.IdUsuario;
                    Address.ci_costo_Flete_externo = Info.ci_costo_Flete_externo;
                    Address.ci_costo_Flete_interno = Info.ci_costo_Flete_interno;
                    Address.ci_costoSeguro = Info.ci_costoSeguro;
                    Address.ci_costoCif = Info.ci_costoCif;
                    Address.ci_GastosTotales = Info.ci_GastosTotales;
                    Address.IdVia = Info.IdVia;
                    Address.ci_fecha_aprobacion = Info.ci_fecha_aprobacion;
                    Address.ci_fechaFactProv = Info.ci_fechaFactProv;
                    Address.ci_fechVenciFact = Info.ci_fechVenciFact;
                    Address.ci_fechaDespProv = Info.ci_fechaDespProv;
                    Address.ci_fechaRecEmb = Info.ci_fechaRecEmb;
                    Address.ci_fechaAproxSal = Info.ci_fechaAproxSal;
                    Address.ci_fec_est_llegada = Info.ci_fec_est_llegada;
                    Address.ci_fecha_llegada_Bodega = Info.ci_fecha_llegada_Bodega;
                    Address.ci_fechaRealArri = Info.ci_fechaRealArri;
                    Address.ci_fechaDocAAA = Info.ci_fechaDocAAA;
                    Address.ci_fecha_liquidacion = Info.ci_fecha_liquidacion;
                    Address.ci_fecha_sal_aduana = Info.ci_fecha_sal_aduana;
                    Address.ci_diasFecFacProv = Info.ci_diasFecFacProv;
                    Address.ci_diasFecDespProv = Info.ci_diasFecDespProv;
                    Address.ci_diasFecAproxSal = Info.ci_diasFecAproxSal;
                    Address.ci_diasFecAproxLleg = Info.ci_diasFecAproxLleg;
                    Address.ci_diasNaciona = Info.ci_diasNaciona;
                    Address.ci_fecha_pago = DateTime.Now;
                    Address.ci_fecha_salida = DateTime.Now;
                    Address.ci_fecha_llegada = Info.ci_fecha_llegada;
                    Address.ci_fecha_despacho = DateTime.Now;
                    Address.ci_dias_estimados = Info.ci_dias_estimados;
                    Address.ci_valor_derecho = Info.ci_valor_derecho;
                    Address.IdMonedaOrigen = Info.IdMonedaOrigen;
                    Address.IdMonedaCambiaria = Info.IdMonedaCambiaria;
                    Address.ci_EquivalenciaMoneda = Info.ci_EquivalenciaMoneda;
                    Address.IdCicloImportacion = Info.IdCicloImportacion;
                    Address.IdCtaCble_Inven = Info.IdCtaCble_Inven;
                    Address.IdCtaCble_import = Info.IdCtaCble_import;
                    Address.IdEmbarcador = Info.IdEmbarcador;
                    Address.ci_contabilizada = Info.ci_contabilizada;
                    Address.ci_Idfecha_Bodega = Info.ci_Idfecha_Bodega;
                    Address.ci_fechaRegsis = DateTime.Now;
                    Address.ci_ultFechaModi = DateTime.Now;
                    Address.ci_ultUserModi = Info.ci_ultUserModi;
                    Address.IdPaisOrgCarga = Info.IdPaisOrgCarga;
                    Address.IdPaisProceCarga = Info.IdPaisProceCarga;
                    Address.ci_dui = Info.ci_dui;
                    Address.ci_anio = Info.ci_anio;
                    Address.ci_mes = Info.ci_mes;
                    Address.ci_FechaCosteo = DateTime.Now;
                    Address.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    Address.Fecha_UltMod = DateTime.Now;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Address.Buque = Info.Buque;
                    Address.Naviera = Info.Naviera;
                   // Address.IdTerminoPago = Info.IdTerminoPago;
                   // Address.IdBanco = Info.IdBanco;
                    Address.ci_fechaFirmaContrato = Info.ci_fechaFirmaContrato;
                    Address.NumFacturaProvedor = Info.NumFacturaProvedor;
                    Address.ci_tonelaje = Info.ci_tonelaje;
                    Address.ci_lugarEmbarque = Info.ci_LugarEmbarque;
                    Address.CFR = Info.CFR;
                    Address.ci_Total = Info.FOB;
                    Address.ci_costo_Flete_externo = Info.ci_costo_Flete_externo;
                    Address.IdCategoria = Info.IdCategoria;

                    Address.Tipo_Importacion = Info.Tipo_Importacion;
                    (from q in Info.ListaDatoEmbarque select q).ToList().ForEach(var => var.IdOrdenCompraExt = (decimal)Info.IdOrdenCompraExt);
                    if (DataDatosEmbarque.GuardarDB(Info.ListaDatoEmbarque))
                    {

                        Contex.imp_ordencompra_ext.Add(Address);
                        Contex.SaveChanges();
                        (from q in Info.ListaDetalleOrdeCompraEx select q).ToList().ForEach(var => var.IdOrdenCompraExt = (decimal)Info.IdOrdenCompraExt);
                        if (DataOrdeCompraDetalle.GuardarDB(Info.ListaDetalleOrdeCompraEx))
                        {
                            (from q in Info.ListaGastos select q).ToList().ForEach(var => { var.IdOrdenCompraExt = (decimal)Info.IdOrdenCompraExt; var.IdEmpresa = Info.IdEmpresa; var.IdSucusal = Info.IdSucusal; });
                           
                                Info.ListCondicionPago.ForEach(var => var.IdOrdenCompraExt = Address.IdOrdenCompraExt);
                                if(DataCondicionPago.GuardarDB(Info))
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                           
                           
                        }
                        else
                        {
                            return false;
                        }
                      
                    }
                    else
                    {
                        return false;
                    }
                }
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

        public decimal GetId(imp_ordencompra_ext_Info Info) 
        
        {
            try
            {
                decimal ID = 0;

                EntitiesImportacion oEntities = new EntitiesImportacion();
                var select = from q in oEntities.imp_ordencompra_ext
                             where q.IdEmpresa == Info.IdEmpresa && q.IdSucusal == Info.IdSucusal
                             select q;
                if (select.ToList().Count < 1)
                {
                    IdOrdeExte = ID = 1;
                }
                else
                {
                    var GetiD = (from q in oEntities.imp_ordencompra_ext
                                 where q.IdEmpresa == Info.IdEmpresa && q.IdSucusal == Info.IdSucusal

                                 select q.IdOrdenCompraExt).Max();

                    IdOrdeExte = ID = Convert.ToDecimal(GetiD.ToString()) + 1;
                }
                return ID;
            
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

        public List<imp_ordencompra_ext_Info> Get_List_ordencompra_ext(int idempresa, int idSucursal, DateTime FechaIn, DateTime FechaFin) 
        {
            List<imp_ordencompra_ext_Info> lista = new List<imp_ordencompra_ext_Info>();
                EntitiesImportacion oEntities = new EntitiesImportacion();
            try
            {   
                var select = from q in oEntities.vwIMP_Orden_Compra
                             where q.IdEmpresa == idempresa && q.IdSucusal == idSucursal && q.ci_fecha >= FechaIn
                             && q.ci_fecha <= FechaFin
                             select q;
                foreach (var item in select)
                {
                    imp_ordencompra_ext_Info info = new imp_ordencompra_ext_Info();
                    info.Tipo_Importacion = item.Tipo_Importacion;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucusal = item.IdSucusal;
                    info.ci_fechaFirmaContrato = item.ci_fechaFirmaContrato;
                    info.IdOrdenCompraExt = item.C__Orden_Compra;
                    info.CodOrdenCompraExt = item.Codigo;
                    info.ci_plazo = (int)item.ci_plazo;
                    info.ci_fecha = (DateTime)item.ci_fecha;
                    info.IdProveedor = (int)item.IdProveedor;
                    info.NumFacturaProvedor = item.NumFacturaProvedor;
                    info.ci_Observacion = item.Observacion;
                    info.Fecha_Transac = (DateTime)item.Fecha;
                    info.Estado = item.Estado;
                    info.Sucursal = item.Sucursal;
                    info.Proveedor = item.Proveedor;
                    info.IdUsuario = item.IdUsuario;
                    info.ci_costo_Flete_externo = (double)item.ci_costo_Flete_externo;
                    info.ci_costo_Flete_interno = (double)item.ci_costo_Flete_interno;
                    info.ci_costoSeguro = (double)item.ci_costoSeguro;
                    info.ci_costoCif = (double)item.ci_costoCif;
                    info.ci_GastosTotales = (double)item.ci_GastosTotales;
                    info.IdVia = item.IdVia;
                    info.ci_fecha_aprobacion = (DateTime)item.ci_fecha_aprobacion;
                    info.ci_fechaFactProv = (DateTime)item.ci_fechaFactProv;
                    info.ci_fechVenciFact = (DateTime)item.ci_fechVenciFact;
                    info.ci_fechaDespProv = (DateTime)item.ci_fechaDespProv;
                    info.ci_fechaRecEmb = (DateTime)item.ci_fechaRecEmb;
                    info.ci_fechaAproxSal = (DateTime)item.ci_fechaAproxSal;
                    info.ci_fec_est_llegada = (DateTime)item.ci_fec_est_llegada;
                    info.ci_fecha_llegada_Bodega = (DateTime)item.ci_fecha_llegada_Bodega;
                    info.ci_fechaRealArri = (DateTime)item.ci_fechaRealArri;
                    info.ci_fechaDocAAA = (DateTime)item.ci_fechaDocAAA;
                    info.ci_fecha_liquidacion = (DateTime)item.ci_fecha_liquidacion;
                    info.ci_fecha_sal_aduana = (DateTime)item.ci_fecha_sal_aduana;
                    info.ci_diasFecFacProv = (int)item.ci_diasFecFacProv;
                    info.ci_diasFecDespProv = (int)item.ci_diasFecDespProv;
                    info.ci_diasFecAproxSal = (int)item.ci_diasFecAproxSal;
                    info.ci_diasFecAproxLleg = (int)item.ci_diasFecAproxLleg;
                    info.ci_diasNaciona = (int)item.ci_diasNaciona;
                    info.ci_fecha_pago = (DateTime)item.ci_fecha_pago;
                    info.ci_fecha_salida = (DateTime)item.ci_fecha_salida;
                    info.ci_fecha_llegada = (DateTime)item.ci_fecha_llegada;
                    info.ci_fecha_despacho = (DateTime)item.ci_fecha_despacho;
                    info.ci_dias_estimados = (int)item.ci_dias_estimados;
                    info.ci_valor_derecho = (double)item.ci_valor_derecho;
                    info.IdMonedaOrigen = (int)item.IdMonedaOrigen;
                    info.IdMonedaCambiaria = (int)item.IdMonedaCambiaria;
                    info.ci_EquivalenciaMoneda = (double)item.ci_EquivalenciaMoneda;
                    info.IdCicloImportacion = item.IdCicloImportacion;
                    info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                    info.IdCtaCble_import = (item.IdCtaCble_import == null) ? "" : item.IdCtaCble_import;
                    info.IdEmbarcador = (int)item.IdEmbarcador;
                    info.ci_contabilizada = item.ci_contabilizada;
                    info.ci_Idfecha_Bodega = (decimal)item.ci_Idfecha_Bodega;
                    info.ci_fechaRegsis = (DateTime)item.ci_fechaRegsis;
                    info.ci_ultFechaModi = (DateTime)item.ci_ultFechaModi;
                    info.ci_ultUserModi = item.ci_ultUserModi;
                    info.IdPaisOrgCarga = item.IdPaisOrgCarga;
                    info.IdPaisProceCarga = item.IdPaisProceCarga;
                    info.ci_dui = item.ci_dui;
                    info.ci_anio = (int)item.ci_anio;
                    info.ci_mes = (int)item.ci_mes;
                    info.ci_FechaCosteo = (DateTime)item.ci_FechaCosteo;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.ci_tonelaje = Convert.ToDouble((item.ci_tonelaje == null) ? 0 : item.ci_tonelaje);
                    info.ci_LugarEmbarque = (item.ci_lugarEmbarque == null) ? "" : item.ci_lugarEmbarque.Trim();
                    info.ci_fecha_llegada = (DateTime)item.ci_fecha_llegada;
                    info.Buque = item.Buque;
                    info.Naviera = item.Naviera;
                    info.FOB = Convert.ToDouble((item.ci_Total == null) ? 0 : item.ci_Total);
                    info.ci_costo_Flete_externo = Convert.ToDouble((item.ci_costo_Flete_externo == null) ? 0 : item.ci_costo_Flete_externo);
                    info.CFR = Convert.ToDouble((item.CFR==null)?0:item.CFR);
                    info.IdCategoria = (item.IdCategoria== null)?"":item.IdCategoria;
                    info.IdEstadoLiquidacion = item.IdEstadoLiquidacion;
                    info.Fecha_Maximo_Despacho = item.Fecha_Maximo_Despacho;
                    info.ci_Total = Convert.ToDouble(item.ci_Total);
                    lista.Add(info);
                }
                return lista;
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

        public Boolean ModificarDB(imp_ordencompra_ext_Info Info ) 
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    var contact = context.imp_ordencompra_ext.FirstOrDefault(Impo => Impo.IdEmpresa == Info.IdEmpresa && Impo.IdOrdenCompraExt == Info.IdOrdenCompraExt && Impo.IdSucusal == Info.IdSucusal);
                    if (contact != null)
                    {
                        contact.Fecha_Maximo_Despacho = Info.Fecha_Maximo_Despacho;
                        contact.ci_plazo = Info.ci_plazo;
                        contact.ci_fecha = Info.ci_fecha;
                        contact.IdProveedor = Info.IdProveedor;
                        contact.ci_fechaFirmaContrato = Info.ci_fechaFirmaContrato;
                        contact.ci_diasEmbarque = Info.ci_DiasEmbarque;
                        contact.NumFacturaProvedor = Info.NumFacturaProvedor;
                        contact.ci_Observacion = Info.ci_Observacion;
                        contact.Fecha_Transac = Info.Fecha_Transac;
                        contact.ci_costo_Flete_externo = Info.ci_costo_Flete_externo;
                        contact.ci_costo_Flete_interno = Info.ci_costo_Flete_interno;
                        contact.ci_costoSeguro = Info.ci_costoSeguro;
                        contact.ci_costoCif = Info.ci_costoCif;
                        contact.ci_GastosTotales = Info.ci_GastosTotales;
                        contact.IdVia = Info.IdVia;
                        contact.ci_fecha_aprobacion = Info.ci_fecha_aprobacion;
                        contact.ci_fechaFactProv = Info.ci_fechaFactProv;
                        contact.ci_fechVenciFact = Info.ci_fechVenciFact;
                        contact.ci_fechaDespProv = Info.ci_fechaDespProv;
                        contact.ci_fechaRecEmb = Info.ci_fechaRecEmb;
                        contact.ci_fechaAproxSal = Info.ci_fechaAproxSal;
                        contact.ci_fec_est_llegada = Info.ci_fec_est_llegada;
                        contact.ci_fecha_llegada_Bodega = Info.ci_fecha_llegada_Bodega;
                        contact.ci_fechaRealArri = Info.ci_fechaRealArri;
                        contact.ci_fechaDocAAA = Info.ci_fechaDocAAA;
                        contact.ci_fecha_liquidacion = Info.ci_fecha_liquidacion;
                        contact.ci_fecha_sal_aduana = Info.ci_fecha_sal_aduana;
                        contact.ci_diasFecFacProv = Info.ci_diasFecFacProv;
                        contact.ci_diasFecDespProv = Info.ci_diasFecDespProv;
                        contact.ci_diasFecAproxSal = Info.ci_diasFecAproxSal;
                        contact.ci_diasFecAproxLleg = Info.ci_diasFecAproxLleg;
                        contact.ci_diasNaciona = Info.ci_diasNaciona;
                        contact.ci_fecha_pago = DateTime.Now;
                        contact.ci_fecha_salida = DateTime.Now;
                        contact.ci_fecha_llegada = Info.ci_fecha_llegada;
                        contact.ci_fecha_despacho = DateTime.Now;
                        contact.ci_dias_estimados = Info.ci_dias_estimados;
                        contact.ci_valor_derecho = Info.ci_valor_derecho;
                        contact.IdMonedaOrigen = Info.IdMonedaOrigen;
                        contact.IdMonedaCambiaria = Info.IdMonedaCambiaria;
                        contact.ci_EquivalenciaMoneda = Info.ci_EquivalenciaMoneda;
                        contact.IdCicloImportacion = Info.IdCicloImportacion;
                        contact.IdCtaCble_Inven = Info.IdCtaCble_Inven;
                        contact.IdCtaCble_import = Info.IdCtaCble_import;
                        contact.IdEmbarcador = Info.IdEmbarcador;
                        contact.ci_contabilizada = Info.ci_contabilizada;
                        contact.ci_Idfecha_Bodega = Info.ci_Idfecha_Bodega;
                        //contact.IdBanco = Info.IdBanco;
                        contact.ci_ultFechaModi = DateTime.Now;
                        contact.ci_ultUserModi = Info.ci_ultUserModi;
                        contact.IdPaisOrgCarga = Info.IdPaisOrgCarga;
                        contact.IdPaisProceCarga = Info.IdPaisProceCarga;
                        contact.ci_dui = Info.ci_dui;
                        contact.ci_anio = Info.ci_anio;
                        contact.ci_mes = Info.ci_mes;
                        contact.ci_FechaCosteo = DateTime.Now;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.nom_pc = Info.nom_pc;
                        contact.ip = Info.ip;
                        contact.ci_tonelaje = Info.ci_tonelaje;
                        //contact.IdTerminoPago = Info.IdTerminoPago;
                        contact.ci_lugarEmbarque = Info.ci_LugarEmbarque;
                        contact.Buque = Info.Buque;
                        contact.Naviera = Info.Naviera;
                        contact.ci_Total = Info.FOB;
                        contact.ci_costo_Flete_externo = Info.ci_costo_Flete_externo;
                        contact.CFR = Info.CFR;
                        contact.IdCategoria = Info.IdCategoria;
                        contact.Tipo_Importacion = Info.Tipo_Importacion;
                        if (DataDatosEmbarque.EliminarDB(Info))
                        {
                            (from q in Info.ListaDatoEmbarque select q).ToList().ForEach(Vari => Vari.IdOrdenCompraExt = Info.IdOrdenCompraExt);

                            if (DataDatosEmbarque.GuardarDB(Info.ListaDatoEmbarque))
                            {
                                if (DataOrdeCompraDetalle.EliminarDB(Info))
                                {
                                    (from q in Info.ListaDetalleOrdeCompraEx select q).ToList().ForEach(Vari => Vari.IdOrdenCompraExt = Info.IdOrdenCompraExt);

                                    if (DataOrdeCompraDetalle.GuardarDB(Info.ListaDetalleOrdeCompraEx))
                                    {
                                        (from q in Info.ListaGastos select q).ToList().ForEach(var => { var.IdOrdenCompraExt = (decimal)Info.IdOrdenCompraExt; var.IdEmpresa = Info.IdEmpresa; var.IdSucusal = Info.IdSucusal; });
                                        if (DataCondicionPago.EliminarDB(Info))
                                        {
                                            if (DataCondicionPago.GuardarDB(Info))
                                            {
                                                context.SaveChanges();
                                                return true;
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    { return false; }
                                }
                                else
                                { return false; }

                            }
                            else
                            { return false; }

                        }
                        else
                        { return false; }
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VerificarCodigo(string Codigo, int IdEmpresa) 
        {
            try
            {
                EntitiesImportacion oEnti = new EntitiesImportacion();

                var codigo = from q in oEnti.imp_ordencompra_ext
                             where q.CodOrdenCompraExt == Codigo && q.IdEmpresa == IdEmpresa
                             select q;
                if (codigo.ToList().Count() >= 1)
                {

                    return false;
                }
                else 
                {
                    return true;
                }
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

        public List<imp_ordencompra_ext_Info> Get_List_ordencompra_ext(int idempresa)
        {
            List<imp_ordencompra_ext_Info> lista = new List<imp_ordencompra_ext_Info>();
            try
            {
                EntitiesImportacion oEntities = new EntitiesImportacion();

                var select = from q in oEntities.vwIMP_Orden_Compra
                             where q.IdEmpresa == idempresa 
                             select q;
                foreach (var item in select)
                {
                    imp_ordencompra_ext_Info info = new imp_ordencompra_ext_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucusal = item.IdSucusal;
                    info.IdOrdenCompraExt = item.C__Orden_Compra;
                    info.CodOrdenCompraExt = item.Codigo;
                    info.ci_plazo = (item.ci_plazo == null) ? 0 : (int)item.ci_plazo;
                    info.ci_fecha = Convert.ToDateTime((item.ci_fecha == null) ? Convert.ToDateTime("00/00/00") : item.ci_fecha);
                    info.IdProveedor = (item.IdProveedor == null) ? 0 : (decimal)item.IdProveedor;
                    info.NumFacturaProvedor = item.NumFacturaProvedor;
                    info.ci_Observacion = item.Observacion;
                    info.Fecha_Transac = Convert.ToDateTime((item.Fecha == null) ? Convert.ToDateTime("00/00/00") : item.Fecha); 
                    info.Estado = item.Estado;
                    info.Sucursal = item.Sucursal;
                    info.Proveedor = item.Proveedor;
                    info.IdUsuario = item.IdUsuario;
                    info.ci_costo_Flete_externo = Convert.ToDouble((item.ci_costo_Flete_externo == null) ? 0 : item.ci_costo_Flete_externo);
                    info.ci_costo_Flete_interno = Convert.ToDouble((item.ci_costo_Flete_interno == null) ? 0 : item.ci_costo_Flete_interno);
                    info.ci_costoSeguro = Convert.ToDouble((item.ci_costoSeguro == null) ? 0 : item.ci_costoSeguro); ;
                    info.ci_costoCif = (item.ci_costoCif == null) ? 0 : (double)item.ci_costoCif;
                    info.ci_GastosTotales = (item.ci_GastosTotales == null) ? 0 : (double)item.ci_GastosTotales;
                    info.IdVia = item.IdVia;
                    info.Tipo_Importacion = item.Tipo_Importacion;
                    //info.ci_fecha_aprobacion = Convert.ToDateTime((item.ci_fecha_aprobacion == null) ? Convert.ToDateTime("00/00/00") : item.ci_fecha_aprobacion);
                    //info.ci_fechaFactProv = Convert.ToDateTime((item.ci_fechaFactProv == null) ? Convert.ToDateTime("00/00/00") : item.ci_fechaFactProv); 
                    info.ci_fechaFirmaContrato = item.ci_fechaFirmaContrato;
                    //info.ci_fechVenciFact = item.ci_fechVenciFact;
                    //info.ci_fechaDespProv = item.ci_fechaDespProv;
                    //info.ci_fechaRecEmb = item.ci_fechaRecEmb;
                    //info.ci_fechaAproxSal = item.ci_fechaAproxSal;
                    //info.ci_fec_est_llegada = item.ci_fec_est_llegada;
                    //info.ci_fecha_llegada_Bodega = item.ci_fecha_llegada_Bodega;
                    //info.ci_fechaRealArri = item.ci_fechaRealArri;
                    //info.ci_fechaDocAAA = item.ci_fechaDocAAA;
                    //info.ci_fecha_liquidacion = item.ci_fecha_liquidacion;
                    //info.ci_fecha_sal_aduana = item.ci_fecha_sal_aduana;
                    info.ci_diasFecFacProv = (item.ci_diasFecFacProv == null) ? 0 : (int)item.ci_diasFecFacProv;
                    info.ci_diasFecDespProv = (item.ci_diasFecDespProv == null) ? 0 : (int)item.ci_diasFecDespProv;
                    info.ci_diasFecAproxSal = (item.ci_diasFecAproxSal == null) ? 0 : (int)item.ci_diasFecAproxSal;
                    info.ci_diasFecAproxLleg = (item.ci_diasFecAproxLleg == null) ? 0 : (int)item.ci_diasFecAproxLleg;
                    info.ci_diasNaciona = (item.ci_diasNaciona == null) ? 0 : (int)item.ci_diasNaciona;
                    //info.ci_fecha_pago = item.ci_fecha_pago;
                    //info.ci_fecha_salida = item.ci_fecha_salida;
                    //info.ci_fecha_llegada = item.ci_fecha_llegada;
                    //info.ci_fecha_despacho = item.ci_fecha_despacho;
                    info.ci_dias_estimados = (item.ci_dias_estimados == null) ? 0 : (int)item.ci_dias_estimados;
                    info.ci_valor_derecho = (item.ci_valor_derecho == null) ? 0 : (double)item.ci_valor_derecho;
                    info.IdMonedaOrigen = (item.IdMonedaOrigen == null) ? 0 : (int)item.IdMonedaOrigen;
                    info.IdMonedaCambiaria = (item.IdMonedaCambiaria == null) ? 0 : (int)item.IdMonedaCambiaria;
                    info.ci_EquivalenciaMoneda = (item.ci_EquivalenciaMoneda == null) ? 0 : (double)item.ci_EquivalenciaMoneda;
                    info.IdCicloImportacion = item.IdCicloImportacion;
                    info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                    info.IdCtaCble_import = (item.IdCtaCble_import == null) ? "" : item.IdCtaCble_import;
                    info.IdEmbarcador = (item.IdEmbarcador == null) ? 0 : (int)item.IdEmbarcador;
                    info.ci_contabilizada = item.ci_contabilizada;
                    info.ci_Idfecha_Bodega = (item.ci_Idfecha_Bodega == null) ? 0 : (decimal)item.ci_Idfecha_Bodega;
                    //info.ci_fechaRegsis = item.ci_fechaRegsis;
                    info.IdPaisOrgCarga = item.IdPaisOrgCarga;
                    info.IdPaisProceCarga = item.IdPaisProceCarga;
                    info.ci_dui = item.ci_dui;
                    info.ci_anio = (item.ci_anio == null) ? 0 : (int)item.ci_anio;
                    info.ci_mes = (item.ci_mes == null) ? 0 : (int)item.ci_mes;
                    //info.ci_FechaCosteo = item.ci_FechaCosteo;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.ci_tonelaje = Convert.ToDouble((item.ci_tonelaje == null) ? 0 : item.ci_tonelaje);
                    info.ci_LugarEmbarque = (item.ci_lugarEmbarque == null) ? "" : item.ci_lugarEmbarque.Trim();
                    //info.ci_fecha_llegada = item.ci_fecha_llegada;
                    info.Importacion = "IMP #:"+item.Codigo +" / "+ item.C__Orden_Compra + " - SUC: "+item.Sucursal.Trim() +" - PROVE: "+ item.Proveedor.Trim();
                    info.Buque = item.Buque;
                    info.Naviera = item.Naviera;
                    info.Fecha_Maximo_Despacho = item.Fecha_Maximo_Despacho;
                    lista.Add(info);
                }
                return lista;
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

        public imp_ordencompra_ext_Info Get_Info_ordencompra_ext(int IdEmpresa, string codigoOrdenCompra, int idSucursal)
        {
                imp_ordencompra_ext_Info info = new imp_ordencompra_ext_Info();
            try
            {

                EntitiesImportacion imp =new EntitiesImportacion();
                var OrdenCompra = imp.imp_ordencompra_ext.FirstOrDefault(obj => obj.IdEmpresa == IdEmpresa && obj.CodOrdenCompraExt == codigoOrdenCompra && obj.IdSucusal == idSucursal);
                if(OrdenCompra!=null)
                    info.IdOrdenCompraExt = OrdenCompra.IdOrdenCompraExt;

                return info;
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

        public List<imp_ordencompra_ext_Info> Get_List_ordencompra_ext_x_Gastos(int idempresa)
        {
            List<imp_ordencompra_ext_Info> lista = new List<imp_ordencompra_ext_Info>();
            try
            {
                EntitiesImportacion oEntities = new EntitiesImportacion();
                var select = from q in oEntities.vwIMP_Orden_Compra
                             where q.IdEmpresa == idempresa
                             select q;
                foreach (var item in select)
                {
                    imp_ordencompra_ext_Info info = new imp_ordencompra_ext_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucusal = item.IdSucusal;
                    info.IdOrdenCompraExt = item.C__Orden_Compra;
                    info.CodOrdenCompraExt = item.Codigo;
                    info.ci_plazo = (int)item.ci_plazo;
                    info.ci_fecha = (DateTime)item.ci_fecha;
                    info.IdProveedor = (int)item.IdProveedor;
                    info.NumFacturaProvedor = item.NumFacturaProvedor;
                    info.ci_Observacion = item.Observacion;
                    info.Naviera = item.Naviera;
                    info.FOB = Convert.ToDouble((item.ci_Total == null) ? 0 : item.ci_Total);
                    info.ci_costo_Flete_externo = Convert.ToDouble((item.ci_costo_Flete_externo == null) ? 0 : item.ci_costo_Flete_externo);
                    info.CFR = Convert.ToDouble((item.CFR == null) ? 0 : item.CFR);
                    info.IdCategoria = (item.IdCategoria == null) ? "" : item.IdCategoria;
                    info.Sucursal = item.Sucursal;
                    info.IdEstadoLiquidacion = item.IdEstadoLiquidacion;
                    info.Estado = item.Estado;
                    info.ci_fechaFirmaContrato = item.ci_fechaFirmaContrato;
                    info.Tipo_Importacion = item.Tipo_Importacion;
                    info.Proveedor = item.Proveedor;
                    info.Fecha_Maximo_Despacho = item.Fecha_Maximo_Despacho;
                    
                    lista.Add(info);
                }
                return lista;
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

        public imp_ordencompra_ext_Info Get_Info_ordencompra_ext(int idempresa, int IdSucursal, Decimal IdOrdenCompra)
        {
            try
            {
                EntitiesImportacion oEntities = new EntitiesImportacion();
                imp_ordencompra_ext_Info info = new imp_ordencompra_ext_Info();
                var item = oEntities.imp_ordencompra_ext.FirstOrDefault(var => var.IdEmpresa == idempresa && var.IdSucusal == IdSucursal && var.IdOrdenCompraExt == IdOrdenCompra);
                if (item != null)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucusal = item.IdSucusal;
                    info.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    info.CodOrdenCompraExt = " " + item.CodOrdenCompraExt;
                    info.ci_plazo = (int)item.ci_plazo;
                    info.ci_fecha = (DateTime)item.ci_fecha;
                    info.IdProveedor = (int)item.IdProveedor;
                    info.NumFacturaProvedor = item.NumFacturaProvedor;
                    info.ci_Observacion = " " + item.ci_Observacion;
                    info.Naviera = item.Naviera;
                    info.FOB = Convert.ToDouble((item.ci_Total == null) ? 0 : item.ci_Total);
                    info.ci_costo_Flete_externo = Convert.ToDouble((item.ci_costo_Flete_externo == null) ? 0 : item.ci_costo_Flete_externo);
                    info.CFR = Convert.ToDouble((item.CFR == null) ? 0 : item.CFR);
                    info.IdCategoria = (item.IdCategoria == null) ? "" : item.IdCategoria;
                    info.IdCtaCble_import = item.IdCtaCble_import;
                    info.IdEstadoLiquidacion = item.IdEstadoLiquidacion;
                    info.ci_fechaFirmaContrato = item.ci_fechaFirmaContrato;
                    info.Fecha_Maximo_Despacho = item.Fecha_Maximo_Despacho;
                }
                return info;
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

        public List<vwImp_OrdenCompraExt_X_CbteCble_Info> Get_List_DiariosxImportacion (int idempresa, int IdSucursal, Decimal IdOrdenCompra )
        {
               List<vwImp_OrdenCompraExt_X_CbteCble_Info> lst = new List<vwImp_OrdenCompraExt_X_CbteCble_Info>();
            try
            { 
                EntitiesImportacion Imp = new EntitiesImportacion();
                var Consulta = from q in Imp.vwImp_OrdenCompraExt_X_CbteCble
                               where q.imp_IdEmpresa == idempresa && q.imp_IdSucusal == IdSucursal && q.imp_IdOrdenCompraExt == IdOrdenCompra
                               select q;


                    foreach (var item in Consulta)
                {
                    vwImp_OrdenCompraExt_X_CbteCble_Info obj = new vwImp_OrdenCompraExt_X_CbteCble_Info();
                    obj.IdCbte = item.IdCbteCble;
                    obj.IdEmpresa = item.imp_IdEmpresa;
                    obj.IdSucursal = item.imp_IdSucusal;
                    obj.Observacion = item.cb_Observacion;
                    obj.TipoComprobanteContable = item.tc_TipoCbte;
                    obj.Valor = item.cb_Valor;
                    obj.CodCbte = item.CodCbteCble;
                    obj.IdOrdenCompraExt = item.imp_IdOrdenCompraExt;
                    obj.Fecha = item.cb_Fecha;
                    obj.Estado = item.cb_Estado;
                    obj.TipoReg = item.TipoReg;
                    obj.ct_IdTipoCbte=item.ct_IdTipoCbte;
                    lst.Add(obj);
                }
                return lst;
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

        public Boolean Liquidar(imp_ordencompra_ext_Info Obj, ref string mensaje)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    var contact = context.imp_ordencompra_ext.FirstOrDefault(Impo => Impo.IdEmpresa == Obj.IdEmpresa && Impo.IdOrdenCompraExt == Obj.IdOrdenCompraExt && Impo.IdSucusal == Obj.IdSucusal);
                    if (contact != null)
                    {
                        contact.IdEstadoLiquidacion = Obj.IdEstadoLiquidacion;
                        contact.ci_fecha_liquidacion = Obj.Fecha_Transac;
                        context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
