using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

using Core.Erp.Info.class_sri.NotaCredito;
using Core.Erp.Info.class_sri.NotaDebito;
using Core.Erp.Info.class_sri;
using Core.Erp.Info.class_sri.FacturaV2;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Facturacion
{
    public class fa_notaCreDeb_Data
    {
        string mensaje = "";
        string campoAdicional = null;
        string format = "dd/MM/yyyy";
        
        fa_notaCreDeb_det_Data datanDetalle = new fa_notaCreDeb_det_Data();
        tb_sis_Documento_Tipo_Talonario_Data Data_sisDocTipoTalo = new tb_sis_Documento_Tipo_Talonario_Data();

        public List<fa_notaCreDeb_Info> Get_List_notaCreDeb
            (int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, DateTime FechaIni, DateTime FechaFin,string Tipo) 
        {
            try
            {
                List<fa_notaCreDeb_Info> lst = new List<fa_notaCreDeb_Info>();

                EntitiesFacturacion oENt = new EntitiesFacturacion();

                if (IdSucursalFin == 0)
                {
                    IdSucursalIni = 0;
                    IdSucursalFin = 5000;
                }

                if (IdBodegaFin == 0)
                {
                    IdBodegaIni = 0;
                    IdBodegaFin = 5000;
                }

                var SelectNota = from q in oENt.vwfa_Nota_Credito
                                 where q.IdEmpresa == IdEmpresa
                            && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                            && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                            && q.no_fecha >= FechaIni && q.no_fecha <= FechaFin
                            && q.CreDeb.Contains(Tipo)
                                 select q;




                foreach (var item in SelectNota)
                {
                    fa_notaCreDeb_Info info = new fa_notaCreDeb_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdSucursal = item.IdSucursal;
                    info.Bodega = item.bo_Descripcion;
                    info.Sucursal = item.Su_Descripcion;
                    info.Vendedor = item.Ve_Vendedor;
                    info.Cliente= item.pe_nombre+" "+ item.pe_apellido;
                    info.IdNota = item.IdNota;
                    info.NaturalezaNota = item.NaturalezaNota;
                    info.Serie1 = item.Serie1;
                    info.Serie2 = item.Serie2;
                    info.NumNota_Impresa = item.NumNota_Impresa;
                    info.sc_observacion = item.sc_observacion;
                    info.no_fecha = item.no_fecha;
                    info.CreDeb = item.CreDeb;

                    info.Subtotal = Convert.ToDouble(item.sc_subtotal);
                    info.Iva = Convert.ToDouble(item.sc_iva);
                    info.Total = Convert.ToDouble(item.sc_total);

                    info.IdTipoNota = item.IdTipoNota;
                  
                    info.IdVendedor = item.IdVendedor;
                    info.IdCliente = item.IdCliente;
                    info.no_dev_venta = item.no_dev_venta;
                    info.flete = Convert.ToDouble(item.flete);
                    info.interes = Convert.ToDouble(item.interes);
                    info.valor1 = Convert.ToDouble(item.valor1);
                    info.valor2 = Convert.ToDouble(item.valor2);
                    info.CodNota = item.CodNota;
                    info.no_fecha_venc = (DateTime)item.no_fecha_venc;

                    info.IdEmpresa_fac_doc_mod = info.IdEmpresa_fac_doc_mod;
                    info.IdSucursal_fac_doc_mod = info.IdSucursal_fac_doc_mod;
                    info.IdBodega_fac_doc_mod = info.IdBodega_fac_doc_mod;
                    info.IdCbteVta_fac_doc_mod = info.IdCbteVta_fac_doc_mod;

                    info.IdCaja = Convert.ToInt32(item.IdCaja);
                    info.Estado = item.Estado;
                    info.IdCtaCble_TipoNota = item.IdCtaCble_TipoNota;
                    info.IdUsuario = item.IdUsuario;
                    
                    lst.Add(info);
                }

                return lst;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",  "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public fa_notaCreDeb_Info Get_Info_notaCreDeb(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                EntitiesFacturacion oENt = new EntitiesFacturacion();
                fa_notaCreDeb_Info info = new fa_notaCreDeb_Info();
                fa_notaCreDeb_det_Data dataDetNota = new fa_notaCreDeb_det_Data();
                List<fa_notaCreDeb_det_Info> LstFaNota = new List<fa_notaCreDeb_det_Info>();

                var SelectNota = from q in oENt.fa_notaCreDeb
                                 where q.IdEmpresa == IdEmpresa
                            && q.IdBodega == IdBodega && q.IdSucursal == IdSucursal
                            && q.IdNota == IdNota
                                 select q;

                foreach (var item in SelectNota)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;                    
                    info.IdSucursal = item.IdSucursal;
                    info.IdNota = item.IdNota;

                    info.NaturalezaNota = item.NaturalezaNota;
                    info.CodNota = item.CodNota;
                    info.CreDeb = item.CreDeb;
                    info.Serie1 = item.Serie1;
                    info.Serie2 = item.Serie2;
                    info.NumNota_Impresa = item.NumNota_Impresa;
                    info.NumAutorizacion = item.NumAutorizacion;
                    info.IdCliente = item.IdCliente;
                    info.IdVendedor = item.IdVendedor;
                    info.no_fecha = item.no_fecha;
                    info.IdTipoNota = item.IdTipoNota;
                    info.sc_observacion = item.sc_observacion;
                    info.no_dev_venta = item.no_dev_venta;
                    
                    
                    info.flete = Convert.ToDouble(item.flete);
                    info.interes = Convert.ToDouble(item.interes);
                    info.valor1 = Convert.ToDouble(item.valor1);
                    info.valor2 = Convert.ToDouble(item.valor2);
                    info.CodNota = item.CodNota;
                    info.no_fecha_venc = Convert.ToDateTime(item.no_fecha_venc);
                    info.fecha_Ctble = Convert.ToDateTime(item.fecha_Ctble);
                    info.IdCaja = Convert.ToInt32(item.IdCaja);
                    info.Estado = item.Estado;

                    info.IdEmpresa_fac_doc_mod = item.IdEmpresa_fac_doc_mod;
                    info.IdSucursal_fac_doc_mod = item.IdSucursal_fac_doc_mod;
                    info.IdBodega_fac_doc_mod = item.IdBodega_fac_doc_mod;
                    info.IdCbteVta_fac_doc_mod = item.IdCbteVta_fac_doc_mod;
                    info.IdCtaCble_TipoNota = item.IdCtaCble_TipoNota;
                }
                
                info.ListaDetalles = dataDetNota.Get_List_notaCreDeb_det(info);

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

        public Boolean AnularDB(fa_notaCreDeb_Info oDeT)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_notaCreDeb.FirstOrDefault(minfo => minfo.IdEmpresa == oDeT.IdEmpresa && minfo.IdNota == oDeT.IdNota && minfo.IdSucursal == oDeT.IdSucursal && minfo.IdBodega == oDeT.IdBodega);
                    if (contact != null)
                    {
                        contact.MotiAnula = oDeT.MotiAnula;
                        contact.Fecha_UltAnu = oDeT.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = oDeT.IdUsuarioUltAnu;
                        contact.Estado = "I";
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

        public Boolean VerificarCodigo(string Codigo)
        {

            try
            {

                EntitiesFacturacion oen = new EntitiesFacturacion();

                var select = from q in oen.fa_notaCreDeb
                             where q.CodNota == Codigo && q.CodNota !=""
                             select q;

                if (select.ToList().Count() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        public decimal GetId(fa_notaCreDeb_Info Info) 
        {
            try
            {
                decimal Id;
                EntitiesFacturacion OEP = new EntitiesFacturacion();
                var select = from q in OEP.fa_notaCreDeb
                             where q.IdEmpresa == Info.IdEmpresa 
                             && q.IdSucursal== Info.IdSucursal 
                             && q.IdBodega == Info.IdBodega
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEP.fa_notaCreDeb
                                     where q.IdEmpresa == Info.IdEmpresa && q.IdSucursal == Info.IdSucursal && q.IdBodega == Info.IdBodega
                                     select q.IdNota).Max();
                    Id = Convert.ToDecimal(select_pv.ToString()) + 1;
                }
                return Id;
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

        public Boolean GuardarDB(fa_notaCreDeb_Info Info, ref decimal idnota, ref string mensajeError)
        {
            try
            {
                try
                {
                    using (EntitiesFacturacion Context = new EntitiesFacturacion())
                    {
                        var address = new fa_notaCreDeb();
                        address.IdEmpresa = Info.IdEmpresa;
                        address.IdSucursal = Info.IdSucursal;
                        address.IdBodega = Info.IdBodega;
                        Info.IdNota = idnota = address.IdNota = GetId(Info);
                        address.CodNota = Info.CodNota = (Info.CodNota == "") ? Info.IdTipoDoc + address.IdNota : Info.CodNota;

                        address.Serie1 = Info.Serie1;
                        address.Serie2 = Info.Serie2;
                        address.NumNota_Impresa = Info.NumNota_Impresa;
                        address.NumAutorizacion = Info.NumAutorizacion;
                        address.NaturalezaNota = Info.NaturalezaNota;
                        address.no_dev_venta = Info.no_dev_venta;
                        address.IdCliente = Info.IdCliente;
                        address.IdVendedor = Info.IdVendedor;
                        address.no_fecha_venc = Info.no_fecha_venc;
                        address.fecha_Ctble = Info.fecha_Ctble;
                        address.no_dev_venta = null;
                        address.IdTipoNota = Info.IdTipoNota;
                        address.sc_observacion = Info.sc_observacion;
                        address.IdDevolucion = Info.IdDevolucion;
                        address.Estado = "A";
                        address.flete = Info.flete;
                        address.interes = Info.interes;
                        address.valor1 = Info.valor1;
                        address.valor2 = Info.valor2;
                        address.IdEmpresa_fac_doc_mod = Info.IdEmpresa_fac_doc_mod;
                        address.IdSucursal_fac_doc_mod = Info.IdSucursal_fac_doc_mod;
                        address.IdBodega_fac_doc_mod = Info.IdBodega_fac_doc_mod;
                        address.IdCbteVta_fac_doc_mod = Info.IdCbteVta_fac_doc_mod;
                        address.IdCaja = Info.IdCaja;
                        address.CodDocumentoTipo = Info.CodDocumentoTipo;

                        address.CreDeb = Info.CreDeb;
                        address.no_fecha = (DateTime)Info.no_fecha;

                        address.nom_pc = Info.nom_pc;
                        address.ip = Info.ip;


                        address.IdUsuario = Info.sc_usuario;
                        address.IdCtaCble_TipoNota = Info.IdCtaCble_TipoNota;

                        Context.fa_notaCreDeb.Add(address);
                        Context.SaveChanges();



                        Info.ListaDetalles.ForEach(var => { var.IdEmpresa = address.IdEmpresa; var.IdNota = address.IdNota; var.IdBodega = address.IdBodega; var.IdSucursal = address.IdSucursal; });

                        if (datanDetalle.GuardarDB(Info))
                        {
                            //modifico el estatus de usado al numero de la factura
                            if (Info.NaturalezaNota == "SRI")
                            {
                                Data_sisDocTipoTalo.Modificar_Estado_Usado(Info.Info_sisDocTipoTalo, ref mensajeError);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                mensajeError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ActualizarDB(fa_notaCreDeb_Info Info, ref string mensajeError) 
        {

            try
            {
                Boolean res = false;

                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_notaCreDeb.FirstOrDefault(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdNota  == Info.IdNota && minfo.IdSucursal == Info.IdSucursal && minfo.IdBodega == Info.IdBodega);
                    if (contact != null)
                    {
                        contact.no_dev_venta = Info.no_dev_venta;
                        contact.CreDeb = Info.CreDeb;
                        contact.IdCliente = Info.IdCliente;
                        contact.IdVendedor = Info.IdVendedor;


                        contact.Serie1 = Info.Serie1;
                        contact.Serie2 = Info.Serie2;
                        contact.NumNota_Impresa = Info.NumNota_Impresa;
                        contact.NumAutorizacion = Info.NumAutorizacion;
                        contact.NaturalezaNota = Info.NaturalezaNota;


                        contact.no_fecha = (DateTime)Info.no_fecha;
                        contact.no_fecha_venc = Info.no_fecha_venc;
                        contact.no_dev_venta = (Info.no_dev_venta == null) ? "a" : Info.no_dev_venta;
                        contact.IdTipoNota = Info.IdTipoNota;
                        contact.sc_observacion = Info.sc_observacion;
                        contact.IdUsuarioUltMod = Info.sc_usuario;
                        contact.IdDevolucion = Info.IdDevolucion;
                        contact.nom_pc = Info.nom_pc;
                        contact.ip = Info.ip;
                        contact.flete = Info.flete;
                        contact.interes = Info.interes;
                        contact.valor1 = Info.valor1;
                        contact.valor2 = Info.valor2;
                        contact.IdCaja = Info.IdCaja;
                        contact.IdCtaCble_TipoNota = Info.IdCtaCble_TipoNota;
                        contact.Estado = Info.Estado;
                        contact.IdEmpresa_fac_doc_mod = Info.IdEmpresa_fac_doc_mod;
                        contact.IdSucursal_fac_doc_mod = Info.IdSucursal_fac_doc_mod;
                        contact.IdBodega_fac_doc_mod = Info.IdBodega_fac_doc_mod;
                        contact.IdCbteVta_fac_doc_mod = Info.IdCbteVta_fac_doc_mod;
                        contact.fecha_Ctble = Info.fecha_Ctble;
                        if (datanDetalle.EliminarDB(Info))
                        {
                            //(from q in Info.ListaDetalles select q).ToList().ForEach(var => var.IdNota = Info.IdNota);
                            Info.ListaDetalles.ForEach(var => { var.IdEmpresa = Info.IdEmpresa; var.IdNota = Info.IdNota; var.IdBodega = Info.IdBodega; var.IdSucursal = Info.IdSucursal; });
                            if (datanDetalle.GuardarDB(Info))
                            {
                                context.SaveChanges();
                                res= true;
                            }
                            else
                            {
                                res= false;
                            }

                        }
                        else
                        {
                            res= false;
                        }
                    }
                   

                }

                return res;
              
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                mensajeError = mensaje;
                throw new Exception(ex.ToString());
            }       
        }

        public fa_notaCreDeb_Info Get_Info_notaCreDeb_x_ND(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {             
                EntitiesFacturacion oENt = new EntitiesFacturacion();
                var SelectNota = from q in oENt.vwfa_Nota_Credito
                                 where q.IdEmpresa == IdEmpresa 
                            && q.IdBodega == IdBodega && q.IdSucursal == IdSucursal 
                            && q.IdNota == IdNota
                                 select q;

                

                fa_notaCreDeb_Info info = new fa_notaCreDeb_Info();
                foreach (var item in SelectNota)
                {                    
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdSucursal = item.IdSucursal;
                    info.Bodega = item.bo_Descripcion;
                    info.Sucursal = item.Su_Descripcion;
                    info.Vendedor = item.Ve_Vendedor;
                    
                    info.Serie1 = item.Serie1;
                    info.Serie2 = item.Serie2;
                    info.NumNota_Impresa = item.NumNota_Impresa;

                    info.Cliente = item.pe_nombre + " " + item.pe_apellido;
                    info.IdNota = item.IdNota;
                    info.sc_observacion = item.sc_observacion;
                    info.no_fecha = item.no_fecha;
                    info.NaturalezaNota = item.NaturalezaNota;
                    info.CreDeb = item.CreDeb;
                    info.Subtotal = Convert.ToDouble(item.sc_subtotal);
                    info.Iva = Convert.ToDouble(item.sc_iva);
                    info.Total = Convert.ToDouble(item.sc_total);
                    info.IdTipoNota = item.IdTipoNota;                  
                    info.IdVendedor = item.IdVendedor;
                    info.IdCliente = item.IdCliente;
                    info.no_dev_venta = item.no_dev_venta;
                    info.flete = Convert.ToDouble(item.flete);
                    info.interes = Convert.ToDouble(item.interes);
                    info.valor1 = Convert.ToDouble(item.valor1);
                    info.valor2 = Convert.ToDouble(item.valor2);
                    info.CodNota = item.CodNota;
                    info.no_fecha_venc = (DateTime)item.no_fecha_venc;
                    info.fecha_Ctble = (DateTime)item.fecha_Ctble;
                    
                    info.Estado = item.Estado;
                    info.IdCaja = Convert.ToInt32(item.IdCaja);
                    info.IdEmpresa_fac_doc_mod = item.IdEmpresa_fac_doc_mod;
                    info.IdSucursal_fac_doc_mod = item.IdSucursal_fac_doc_mod;
                    info.IdBodega_fac_doc_mod = item.IdBodega_fac_doc_mod;
                    info.IdCbteVta_fac_doc_mod = item.IdCbteVta_fac_doc_mod;
                    info.IdCtaCble_TipoNota = item.IdCtaCble_TipoNota;
                    
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

      
        public List<vwfa_notaCreDeb_sri_Info> Get_list_NotaCreDeb_Sri(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota,string CreDeb , ref string msg)
        {
            try
            {
                List<vwfa_notaCreDeb_sri_Info> lista = new List<vwfa_notaCreDeb_sri_Info>();
                EntitiesFacturacion OEFAC = new EntitiesFacturacion();
                var consulta = from h in OEFAC.vwfa_notaCreDeb_sri
                                where h.IdEmpresa == IdEmpresa
                                && h.IdSucursal == IdSucursal
                                && h.IdBodega == IdBodega
                                && h.IdNota == IdNota
                                && h.CreDeb == CreDeb
                                select new
                                {
                                    h.IdEmpresa,                h.IdSucursal,               h.IdBodega,                 h.IdNota,
                                    h.CreDeb,                   h.CodNota,                  h.Serie1,                   h.Serie2,
                                    h.IdCliente,                h.no_fecha,                 h.Estado,                   h.NaturalezaNota,
                                    h.NumAutorizacion,          h.RazonSocial,              h.NombreComercial,          h.ContribuyenteEspecial,
                                    h.ObligadoAllevarConta,     h.em_ruc,                   h.em_direccion,             h.Su_Descripcion,
                                    h.Su_Direccion,             h.cl_RazonSocial,           h.pe_nombreCompleto,        h.IdTipoDocumento,
                                    h.pe_cedulaRuc,             h.pe_correo,                h.NumNota_Impresa,          h.num_Factura,
                                    h.fecha_fact,               h.obser_fact,               h.obser_Nota,               h.nc_Motivo
                                };
                foreach (var item in consulta)
                {
                    vwfa_notaCreDeb_sri_Info info_Sri= new vwfa_notaCreDeb_sri_Info();
                    info_Sri.IdEmpresa = item.IdEmpresa;
                    info_Sri.IdSucursal = item.IdSucursal;
                    info_Sri.IdBodega = item.IdBodega;
                    info_Sri.IdNota = item.IdNota;
                    info_Sri.CreDeb = item.CreDeb;
                    info_Sri.CodNota = item.CodNota;
                    info_Sri.Serie1 = item.Serie1;
                    info_Sri.Serie2 = item.Serie2;
                    info_Sri.IdCliente = item.IdCliente;
                    info_Sri.no_fecha = item.no_fecha;
                    info_Sri.Estado = item.Estado;
                    info_Sri.NaturalezaNota = item.NaturalezaNota;
                    info_Sri.NumAutorizacion = item.NumAutorizacion;
                    info_Sri.RazonSocial = item.RazonSocial;
                    info_Sri.NombreComercial = item.NombreComercial;
                    info_Sri.ContribuyenteEspecial = item.ContribuyenteEspecial;
                    info_Sri.ObligadoAllevarConta = item.ObligadoAllevarConta;
                    info_Sri.em_ruc = item.em_ruc;
                    info_Sri.em_direccion = item.em_direccion;
                    info_Sri.Su_Descripcion = item.Su_Descripcion;
                    info_Sri.Su_Direccion = item.Su_Direccion;
                    info_Sri.cl_RazonSocial = item.cl_RazonSocial;
                    info_Sri.pe_nombreCompleto = item.pe_nombreCompleto;
                    info_Sri.IdTipoDocumento = item.IdTipoDocumento;
                    info_Sri.pe_cedulaRuc = item.pe_cedulaRuc;
                    info_Sri.pe_correo = item.pe_correo;
                    info_Sri.NumNota_Impresa = item.NumNota_Impresa;
                    info_Sri.NumDocModificado = item.num_Factura;
                    info_Sri.fechaEmisionDocSustento = item.fecha_fact;
                    info_Sri.observacion_factura = item.obser_fact;
                    info_Sri.observacion_Nota = item.obser_Nota;
                    info_Sri.nc_Motivo = item.nc_Motivo;
                    lista.Add(info_Sri);
                }
                return lista;
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
