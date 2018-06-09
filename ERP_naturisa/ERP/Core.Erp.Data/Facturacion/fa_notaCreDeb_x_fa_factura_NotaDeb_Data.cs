using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class fa_notaCreDeb_x_fa_factura_NotaDeb_Data
    {
        public List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Get_list_docs_x_NC(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Lista = new List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info>();

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.vwfa_notaCreDeb_x_fa_factura_NotaDeb_x_NC
                              where IdEmpresa == q.IdEmpresa_nt
                              && IdSucursal == q.IdSucursal_fac_nd_doc_mod
                              && IdBodega == q.IdBodega_nt
                              && IdNota == q.IdNota_nt
                              select q;

                    foreach (var item in lst)
                    {
                        fa_notaCreDeb_x_fa_factura_NotaDeb_Info info = new fa_notaCreDeb_x_fa_factura_NotaDeb_Info();

                        info.IdEmpresa_nt = item.IdEmpresa_nt;
                        info.IdSucursal_nt = item.IdSucursal_nt;
                        info.IdBodega_nt = item.IdBodega_nt;
                        info.IdNota_nt = item.IdNota_nt;
                        info.secuencia = item.secuencia;
                        info.IdEmpresa_fac_nd_doc_mod = item.IdEmpresa_fac_nd_doc_mod;
                        info.IdSucursal_fac_nd_doc_mod = item.IdSucursal_fac_nd_doc_mod;
                        info.IdBodega_fac_nd_doc_mod = item.IdBodega_fac_nd_doc_mod;
                        info.IdCbteVta_fac_nd_doc_mod = item.IdCbteVta_fac_nd_doc_mod;
                        info.vt_tipoDoc = item.vt_tipoDoc;
                        info.Valor_Aplicado = item.Valor_Aplicado;
                        info.fecha_cruce = (DateTime)item.fecha_cruce;

                        info.vt_serie1 = item.vt_serie1;
                        info.vt_serie2 = item.vt_serie2;
                        info.vt_NumFactura = item.vt_NumFactura;
                        info.IdCliente = item.IdCliente;
                        info.nom_Cliente = item.nom_Cliente;
                        info.vt_fecha = item.vt_fecha;
                        info.vt_fech_venc = item.vt_fech_venc;
                        info.vt_Observacion = item.vt_Observacion;
                        info.vt_total = item.vt_total;
                        info.num_doc = item.num_doc;
                        info.esta_en_base = true;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Get_list_docs_x_cruzar(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Lista = new List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info>();

                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    var lst = from q in Context.vwcxc_cartera_x_cobrar
                              where IdEmpresa == q.IdEmpresa
                              && IdCliente == q.IdCliente
                              && q.Saldo != 0
                              select q;
                    foreach (var item in lst)
                    {
                        fa_notaCreDeb_x_fa_factura_NotaDeb_Info info = new fa_notaCreDeb_x_fa_factura_NotaDeb_Info();

                        info.IdEmpresa_fac_nd_doc_mod = item.IdEmpresa;
                        info.IdSucursal_fac_nd_doc_mod = item.IdSucursal;
                        info.IdBodega_fac_nd_doc_mod = item.IdBodega;
                        info.IdCbteVta_fac_nd_doc_mod = item.IdComprobante;                        
                        info.vt_tipoDoc = item.vt_tipoDoc;
                        info.saldo = item.Saldo == null ? 0 : (double)item.Saldo;
                        info.vt_NumFactura = item.vt_NunDocumento;
                        info.IdCliente = item.IdCliente;
                        info.nom_Cliente = item.NomCliente;
                        info.vt_fecha = item.vt_fecha;
                        info.vt_fech_venc = item.vt_fech_venc;
                        info.vt_Observacion = item.Referencia;
                        info.vt_total = item.vt_total;
                        info.num_doc = item.vt_NunDocumento;
                        info.esta_en_base = false;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Lista)
        {
            try
            {
                int sec = 1;
                foreach (var item in Lista)
                {
                    item.secuencia = sec;
                    GuardarDB(item);
                    sec++;
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(fa_notaCreDeb_x_fa_factura_NotaDeb_Info info)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    fa_notaCreDeb_x_fa_factura_NotaDeb Entity = new fa_notaCreDeb_x_fa_factura_NotaDeb();

                    Entity.IdEmpresa_nt = info.IdEmpresa_nt;
                    Entity.IdSucursal_nt = info.IdSucursal_nt;
                    Entity.IdBodega_nt = info.IdBodega_nt;
                    Entity.IdNota_nt = info.IdNota_nt;
                    Entity.secuencia = info.secuencia;
                    Entity.IdEmpresa_fac_nd_doc_mod = info.IdEmpresa_fac_nd_doc_mod;
                    Entity.IdSucursal_fac_nd_doc_mod = info.IdSucursal_fac_nd_doc_mod;
                    Entity.IdBodega_fac_nd_doc_mod = info.IdBodega_fac_nd_doc_mod;
                    Entity.IdCbteVta_fac_nd_doc_mod = info.IdCbteVta_fac_nd_doc_mod;
                    Entity.vt_tipoDoc = info.vt_tipoDoc;
                    Entity.Valor_Aplicado = info.Valor_Aplicado;
                    Entity.fecha_cruce = DateTime.Now;
                    Context.fa_notaCreDeb_x_fa_factura_NotaDeb.Add(Entity);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Get_list_docs_x_NC_x_cobro(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> lista = new List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info>();
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.vwfa_notaCreDeb_x_fa_factura_NotaDeb_x_cxc_cobro
                              where q.IdEmpresa_nt == IdEmpresa
                              && q.IdSucursal_nt == IdSucursal
                              && q.IdBodega_nt == IdBodega
                              && q.IdNota_nt == IdNota
                              select q;

                    foreach (var item in lst)
                    {
                        fa_notaCreDeb_x_fa_factura_NotaDeb_Info info = new fa_notaCreDeb_x_fa_factura_NotaDeb_Info();

                        info.IdEmpresa_nt = item.IdEmpresa_nt;
                        info.IdSucursal_nt = item.IdSucursal_nt;
                        info.IdBodega_nt = item.IdBodega_nt;
                        info.IdNota_nt = item.IdNota_nt;
                        info.IdEmpresa_fac_nd_doc_mod = item.IdEmpresa_fac_nd_doc_mod;
                        info.IdSucursal_fac_nd_doc_mod = item.IdSucursal_fac_nd_doc_mod;
                        info.IdBodega_fac_nd_doc_mod = item.IdBodega_fac_nd_doc_mod;
                        info.IdCbteVta_fac_nd_doc_mod = item.IdCbteVta_fac_nd_doc_mod;
                        info.vt_tipoDoc = item.vt_tipoDoc;
                        info.IdEmpresa_cbr = item.IdEmpresa_cbr;
                        info.IdSucursal_cbr = item.IdSucursal_cbr;
                        info.IdCobro_cbr = item.IdCobro_cbr;
                        info.Valor_Aplicado = item.Valor_Aplicado;
                        lista.Add(info);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
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
