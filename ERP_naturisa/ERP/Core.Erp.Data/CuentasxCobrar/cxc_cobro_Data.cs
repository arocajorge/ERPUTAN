using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_cobro_Data
    {
        string mensaje = "";

        public List<cxc_cobro_Info> Get_List_cobro_x_Client(int IdEmpresa, int IdCliente, DateTime Fecha)
        {
            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();

                var select_ = from T in Base.vwcxc_cobro
                              where T.IdEmpresa == IdEmpresa
                              && T.IdCliente == IdCliente
                              && T.cr_fecha == Fecha//Cambio
                              select T;

                foreach (var item in select_)
                {
                    cxc_cobro_Info dat = new cxc_cobro_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = item.IdCliente;
                    dat.cr_TotalCobro = item.cr_TotalCobro;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaCobro = item.cr_fechaCobro;
                    dat.cr_fechaDocu = item.cr_fechaDocu;
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_es_anticipo = item.cr_es_anticipo;
                    dat.cr_Banco = item.cr_Banco;                    
                    dat.IdBanco = Convert.ToInt32 (item.IdBanco);
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.cr_NumDocumento = item.cr_NumDocumento;
                    dat.cr_Tarjeta = item.cr_Tarjeta;
                    dat.cr_estado = item.cr_estado;
                    dat.cr_recibo = item.cr_recibo;
                    dat.nSucursal = item.nSucursal;
                    dat.nCliente = item.nCliente;
                    dat.cr_Tarjeta = Convert.ToString(item.cr_Tarjeta);
                    dat.chek = false;
                    
                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public decimal GetId(int IdEmpresa, int IdSucursal)
        {
            try
            {
                decimal Id;
                EntitiesCuentas_x_Cobrar ocxc = new EntitiesCuentas_x_Cobrar();

                var select = (from q in ocxc.cxc_cobro
                                    where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                    select q.IdCobro).Count();
                
                if (select==0)
                {
                    Id = 1;
                }
                else
                {
                    var select_IdCXC = (from q in ocxc.cxc_cobro
                                        where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                        select q.IdCobro).Max();
                    Id = Convert.ToInt32(select_IdCXC.ToString()) + 1;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public decimal GetRecibo(int IdEmpresa, int IdSucursal)
        {
            try
            {
                decimal Recibo;
                EntitiesCuentas_x_Cobrar ocxc = new EntitiesCuentas_x_Cobrar();

                var select = (from q in ocxc.cxc_cobro
                             where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                     select q.cr_recibo).Count();

                if (select==0)
                {
                    Recibo = 1;
                }
                else
                {
                    var select_Recibo = (from q in ocxc.cxc_cobro
                                         where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                         select q.cr_recibo).Max();

                    Recibo = Convert.ToInt32(select_Recibo.ToString()) + 1;
                }
                return Recibo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean AnularDB(cxc_cobro_Info info)
        {
            try
            {
                Boolean res=false;
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                    var contact = context.cxc_cobro.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdSucursal == info.IdSucursal && cot.IdCobro == info.IdCobro);
                    if (contact != null)
                    {
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.cr_estado = "I";
                        contact.MotiAnula = info.MotiAnula;
                        contact.cr_observacion = "REVERSADO" + info.cr_observacion;
                        context.SaveChanges();
                        res = true;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        

        public Boolean GuardarDB(cxc_cobro_Info Info,ref decimal IdCobro,ref string mensajeError )
        {

            try
            {
                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {

                    
                    var Address = new cxc_cobro();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdCobro = Info.IdCobro = IdCobro = GetId(Info.IdEmpresa, Info.IdSucursal);
                    Address.cr_Codigo = (Info.cr_Codigo == "" || Info.cr_Codigo == null) ? "CXC" + Address.IdCobro : Info.cr_Codigo;
                    Address.cr_recibo = Info.cr_recibo = GetRecibo(Info.IdEmpresa, Info.IdSucursal);
                    Address.IdCobro_tipo = Info.IdCobro_tipo;
                    Address.IdCliente = Info.IdCliente;
                    Address.cr_TotalCobro = Info.cr_TotalCobro;
                    Address.cr_es_anticipo = Info.cr_es_anticipo;
                    

                    Address.cr_fecha = Convert.ToDateTime(Info.cr_fecha);
                    Address.cr_fechaCobro = Convert.ToDateTime(Info.cr_fechaCobro);
                    Address.cr_fechaDocu = Convert.ToDateTime(Info.cr_fechaDocu);
                    
                    Address.cr_observacion = (string.IsNullOrEmpty(Info.cr_observacion) ? "" : Info.cr_observacion);
                    Address.cr_Banco = Info.cr_Banco;
                    Address.cr_cuenta = Info.cr_cuenta;
                    Address.cr_NumDocumento = Info.cr_NumDocumento;
                    Address.cr_Tarjeta = Info.cr_Tarjeta;
                    Address.cr_estado = "A";
                    Address.IdBanco = Info.IdBanco;
                    Address.cr_propietarioCta = Info.cr_propietarioCta;
                    Address.cr_recibo = Info.cr_recibo;
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Address.IdCaja = Info.IdCaja;
                    if (Info.IdTipoNotaCredito == 0)
                    {
                        Address.IdTipoNotaCredito = null;
                    }
                    else
                    {
                        Address.IdTipoNotaCredito = Info.IdTipoNotaCredito;
                    }
                    
                    Address.cr_es_anticipo = Info.cr_es_anticipo;
                    if (Info.IdCobro_a_aplicar==0)
                    {
                        Address.IdCobro_a_aplicar = null;
                    }
                    else
                    {
                        Address.IdCobro_a_aplicar = Info.IdCobro_a_aplicar;
                    }
                                                   
                    //contact = Address;
                    Context.cxc_cobro.Add(Address);
                    Context.SaveChanges();

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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }        
        
        public Boolean ModificarDB(cxc_cobro_Info Info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    var contact = Context.cxc_cobro.FirstOrDefault(cxc => cxc.IdEmpresa == Info.IdEmpresa && cxc.IdCobro == Info.IdCobro && cxc.IdSucursal == Info.IdSucursal);
                    if (contact != null)
                    {
                        contact.cr_observacion = Info.cr_observacion;
                        contact.cr_NumDocumento = Info.cr_NumDocumento;
                        contact.cr_fecha = Info.cr_fecha;
                        contact.cr_fechaDocu = Info.cr_fechaDocu;
                        contact.cr_fechaCobro = Info.cr_fechaCobro;
                        Context.SaveChanges();
                        res = true;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<vwcxc_cartera_x_cobrar_Info> NotasCreditoConFacturaXCobrar(int IdEmpresa, int IdSucursal, decimal IdCliente)
        {
            try
            {


                List<vwcxc_cartera_x_cobrar_Info> lst = new List<vwcxc_cartera_x_cobrar_Info>();
                EntitiesCuentas_x_Cobrar oCXC = new EntitiesCuentas_x_Cobrar();

                var sele = from q in oCXC.vwcxc_cartera_x_cobrar
                           where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdCliente == IdCliente
                           select q;

                foreach(var item in sele)
                {
                    vwcxc_cartera_x_cobrar_Info Info = new vwcxc_cartera_x_cobrar_Info();

                    Info.IdBodega = item.IdBodega;
                    Info.vt_NunDocumento = item.vt_NunDocumento;
                    Info.IdCbteVta = item.IdComprobante;
                    Info.IdCliente = item.IdCliente;
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.Observacion = item.Referencia;
                    Info.Saldo = Convert.ToDouble(item.Saldo);
                    Info.SaldoAUX = Convert.ToDouble(item.Saldo);
                    Info.Sucursal = item.Su_Descripcion;
                    Info.TipoDoc = item.vt_tipoDoc;
                    Info.Total = Convert.ToDouble((item.vt_total == null) ? 0 : item.vt_total);
                    Info.TotalxCobrado = item.TotalxCobrado;
                    Info.Check = false;
                    Info.Fecha = item.vt_fecha;
                    Info.vt_fech_venc = Convert.ToDateTime(item.vt_fech_venc);
                    Info.vt_iva = Convert.ToDouble (item.vt_iva);
                    Info.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                    Info.vt_total = Convert.ToDouble(item.vt_total);
                    Info.dc_ValorRetFu = item.dc_ValorRetFu;
                    Info.dc_ValorRetIva = item.dc_ValorRetIva;
                    Info.Estado = item.Estado;
                    lst.Add(Info);
                }
                return lst;
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcxc_cartera_x_cobrar_Info> NotasCreditoConFacturaXCodigoCLi(String CodCliente)
        {
            try
            {
                List<vwcxc_cartera_x_cobrar_Info> lst = new List<vwcxc_cartera_x_cobrar_Info>();
                EntitiesCuentas_x_Cobrar oCXC = new EntitiesCuentas_x_Cobrar();

                var sele = from q in oCXC.vwcxc_cartera_x_cobrar
                           where q.CodCliente == CodCliente
                           select q;

                foreach (var item in sele)
                {
                    vwcxc_cartera_x_cobrar_Info Info = new vwcxc_cartera_x_cobrar_Info();

                    Info.IdBodega = item.IdBodega;
                    Info.vt_NunDocumento = item.vt_NunDocumento;
                    Info.IdCbteVta = item.IdComprobante;
                    Info.IdCliente = item.IdCliente;
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.Observacion = item.Referencia;
                    Info.Saldo = Convert.ToDouble(item.Saldo);
                    Info.SaldoAUX = Convert.ToDouble(item.Saldo);
                    Info.Sucursal = item.Su_Descripcion;
                    Info.TipoDoc = item.vt_tipoDoc;
                    Info.Total = Convert.ToDouble((item.vt_total == null) ? 0 : item.vt_total);
                    Info.TotalxCobrado = item.TotalxCobrado;
                    Info.Check = false;
                    Info.Fecha = item.vt_fecha;
                    Info.vt_tipoDoc = item.vt_tipoDoc;
                    Info.vt_fech_venc = Convert.ToDateTime(item.vt_fech_venc);
                    Info.vt_iva = Convert.ToDouble(item.vt_iva);
                    Info.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                    Info.vt_total = Convert.ToDouble(item.vt_total);
                    Info.dc_ValorRetFu = item.dc_ValorRetFu;
                    Info.dc_ValorRetIva = item.dc_ValorRetIva;
                    Info.NombCli = item.NomCliente;
                    Info.NombEmp = item.em_nombre;
                    Info.IdComprobante = item.IdComprobante;
                    Info.Estado = item.Estado;
                    lst.Add(Info);
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public cxc_cobro_Info Get_Info_Cobro(int IdEmpresa, int IdSucursal, decimal IdCobro)
        {
            try
            {
                cxc_cobro_Info dat = new cxc_cobro_Info();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();

                var select_ = from T in Base.cxc_cobro
                              where T.IdEmpresa == IdEmpresa && T.IdSucursal == IdSucursal && T.IdCobro == IdCobro
                              select T;

                foreach (var item in select_)
                {
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = item.IdCliente;
                    dat.cr_TotalCobro = item.cr_TotalCobro;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaCobro = item.cr_fechaCobro;
                    dat.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu);
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_Banco = item.cr_Banco;
                    dat.cr_propietarioCta = item.cr_propietarioCta;
                    dat.cr_es_anticipo = item.cr_es_anticipo;
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.IdBanco = Convert.ToInt32(item.IdBanco);
                    dat.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
                    dat.cr_NumDocumento = item.cr_NumDocumento;
                    dat.cr_estado = item.cr_estado;
                    dat.cr_recibo = item.cr_recibo;
                    dat.cr_Tarjeta = item.cr_Tarjeta;
                    dat.IdUsuario = item.IdUsuario;
                    dat.IdCaja = item.IdCaja;
                    /////////////////
                }
                return (dat);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            } 
        }
        
        public List<cxc_cobro_Info> Get_List_Cobros_x_depositar(int IdEmpresa)
        {
         
            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesCaja Base = new EntitiesCaja();
                
                var select_ = from T in Base.vwcaj_Movi_x_Despositar
                              where T.IdEmpresa == IdEmpresa
                              select T;

                foreach (var item in select_)
                {
                   
                    cxc_cobro_Info dat = new cxc_cobro_Info();
                  
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = item.IdCliente;
                    dat.cr_TotalCobro = (item.tm_Signo == "-") ? -1 * item.cr_TotalCobro : item.cr_TotalCobro;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaCobro = Convert.ToDateTime((item.cr_fechaCobro == null) ? DateTime.Now : item.cr_fechaCobro);
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_Banco = item.cr_Banco;
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.cr_NumDocumento = item.cr_NumDocumento;
                    dat.cr_estado = item.cr_estado;
                    dat.cr_recibo = item.cr_recibo;
                    dat.nSucursal = item.nSucursal;
                    dat.nCliente = item.nCliente;
                    dat.Caja = item.ca_Descripcion;
                    dat.IdCbteCble_MoviCaja = item.IdCbteCble_MoviCaja;
                    dat.IdTipocbte_MoviCaja = item.IdTipocbte_MoviCaja;
                    dat.Tipo = (item.tm_Signo == "-") ? "Egreso" : "Ingreso";
                    dat.Secuencia_MoviCaja = item.Secuencia;
                    dat.chek = false;

                    dat.IdCtaCble = item.IdCtaCble;

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_cobro_Info> Get_List_Cobros_x_depositar(int IdEmpresa,string TipoMovCaj)
        {

            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesCaja Base = new EntitiesCaja();
                string STipo_Ing = "";
                if (TipoMovCaj=="INGRESOS")
               {
                   STipo_Ing = "+";
             
               }

                if (TipoMovCaj == "EGRESOS")
                {
                    STipo_Ing = "-";

                }

                var select_ = from T in Base.vwcaj_Movi_x_Despositar
                              where T.IdEmpresa == IdEmpresa 
                              && T.tm_Signo.Contains(STipo_Ing)
                              && T.cr_estado == "A"
                              && T.SeDeposita==true
                              select T;
                                    
                foreach (var item in select_)
                {

                    cxc_cobro_Info dat = new cxc_cobro_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = item.IdCliente;
                    dat.cr_TotalCobro = (item.tm_Signo == "-") ? -1 * item.cr_TotalCobro : item.cr_TotalCobro;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaCobro = Convert.ToDateTime((item.cr_fechaCobro == null) ? DateTime.Now : item.cr_fechaCobro);
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_Banco = item.cr_Banco;
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.cr_NumDocumento = item.cr_NumDocumento;
                    dat.cr_estado = item.cr_estado;
                    dat.cr_recibo = item.cr_recibo;
                    dat.nSucursal = item.nSucursal;
                    dat.nCliente = item.nCliente;
                    dat.Caja = item.ca_Descripcion;
                    dat.IdCbteCble_MoviCaja = item.IdCbteCble_MoviCaja;
                    dat.IdTipocbte_MoviCaja = item.IdTipocbte_MoviCaja;
                    dat.Tipo = (item.tm_Signo == "-") ? "Egreso" : "Ingreso";
                    dat.Secuencia_MoviCaja = item.Secuencia;


                    dat.chek = false;

                    dat.IdCtaCble = item.IdCtaCble;

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_cobro_Info> Get_List_Cobros(int IdEmpresa)
        {
            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();

                var select_ = from T in Base.vwcxc_cobro
                              where T.IdEmpresa == IdEmpresa
                              select T;

                foreach (var item in select_)
                {
                    cxc_cobro_Info dat = new cxc_cobro_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = item.IdCliente;
                    dat.cr_TotalCobro = item.cr_TotalCobro;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaCobro = item.cr_fechaCobro;
                    dat.cr_fechaDocu = (DateTime)item.cr_fechaDocu;
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_Banco = item.cr_Banco;
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.cr_NumDocumento = item.cr_NumDocumento;
                    dat.cr_es_anticipo = item.cr_es_anticipo;
                    dat.cr_estado = item.cr_estado;
                    dat.cr_recibo = item.cr_recibo;
                    //dat.cr_estadoCobro = item.cr_estadoCobro;
                    dat.cr_Tarjeta = Convert.ToString(item.cr_Tarjeta);
                    dat.nSucursal = item.nSucursal;
                    dat.nCliente = item.nCliente;
                    dat.chek = false;

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_EstadoCobro_Info> Get_List_CobroEstado()
        {
            try
            {
                List<cxc_EstadoCobro_Info> lM = new List<cxc_EstadoCobro_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();

                var select_ = from T in Base.cxc_EstadoCobro
                              select T;

                foreach (var item in select_)
                {
                    cxc_EstadoCobro_Info dat = new cxc_EstadoCobro_Info();

                    dat.IdEstadoCobro = item.IdEstadoCobro;
                    dat.posicion = Convert.ToInt32(item.posicion);
                    dat.Descripcion = item.Descripcion;
                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        
        public List<cxc_cobro_Info> Get_List_cobro_x_Cheques(int IdEmpresa, string tipoCheque, string EstadoCheque, DateTime desde, DateTime hasta, int porfecha)
        {
            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();
                
                var select_ = from T in Base.vwcxc_cobro_x_EstadoCobro select T;
                
                var tipo = from q in Base.cxc_cobro_tipo 
                           where q.tc_seMuestraManCheque == "S" select q;

                string a = "";
                string b = "";
                string c = "";
                int x = 0;

                foreach (var item in tipo)
                {
                    if (x == 0) { a = item.IdCobro_tipo; }
                    if (x == 1) { b = item.IdCobro_tipo; }
                    if (x == 2) { c = item.IdCobro_tipo; }
                    x = x + 1;
                }

                if (tipoCheque == "-1")
                {
                    if (porfecha == 0)
                    {
                        select_ = from T in Base.vwcxc_cobro_x_EstadoCobro
                                  where T.IdEmpresa == IdEmpresa && T.IdEstadoCobro == EstadoCheque
                                  && T.cr_fecha >= desde && T.cr_fecha <= hasta && (T.IdCobro_tipo == a || T.IdCobro_tipo == b || T.IdCobro_tipo == c)
                                  select T;
                    }
                    else
                    {
                        select_ = from T in Base.vwcxc_cobro_x_EstadoCobro
                                  where T.IdEmpresa == IdEmpresa && T.IdEstadoCobro == EstadoCheque
                                  && T.cr_fechaCobro >= desde && T.cr_fechaCobro <= hasta && (T.IdCobro_tipo == a || T.IdCobro_tipo == b || T.IdCobro_tipo == c)
                                  select T;
                    }
                }
                else
                {
                    if (porfecha == 0)
                    {
                        select_ = from T in Base.vwcxc_cobro_x_EstadoCobro
                                  where T.IdEmpresa == IdEmpresa && T.IdCobro_tipo == tipoCheque && T.IdEstadoCobro == EstadoCheque
                                  && T.cr_fecha >= desde && T.cr_fecha <= hasta
                                  select T;
                    }
                    else
                    {

                        select_ = from T in Base.vwcxc_cobro_x_EstadoCobro
                                  where T.IdEmpresa == IdEmpresa && T.IdCobro_tipo == tipoCheque && T.IdEstadoCobro == EstadoCheque
                                  && T.Fecha_Cobro >= desde && T.Fecha_Cobro <= hasta
                                  select T;
                    }
                }



                foreach(var item in select_)
                {
                    cxc_cobro_Info dat = new cxc_cobro_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = item.IdCliente;
                    dat.cr_TotalCobro = item.cr_TotalCobro;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaCobro = item.cr_fechaCobro;
                    //dat.Fecha_Cobro = Convert.ToDateTime(item.Fecha_Cobro);
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_Banco = item.cr_Banco;
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.cr_NumDocumento = item.cr_NumDocumento;
                    dat.cr_Tarjeta = Convert.ToString(item.cr_Tarjeta);
                    dat.cr_estado = item.cr_estado;
                    dat.cr_recibo = item.cr_recibo;
                    dat.nSucursal = item.nSucursal.Substring(0, 3);
                    dat.nCliente = item.nCliente.Trim();
                    dat.IdEstadoCobro = item.IdEstadoCobro;
                    
                    dat.IdCaja = item.IdCaja;
                    dat.IdVendedorCliente = item.IdVendedorCliente;
                    dat.chek = false;

                    lM.Add(dat);
                }
                return(lM);
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_cobro_Info> Get_List_Cobros_para_Consulta(int IdEmpresa, int IdSucursal, DateTime Fecha_Ini, DateTime Fecha_Fin)
        {
            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();
                int IdsucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
                int IdsucursalFin = (IdSucursal == 0) ? 99999 : IdSucursal;

                Fecha_Ini = Convert.ToDateTime(Fecha_Ini.ToShortDateString());
                Fecha_Fin = Convert.ToDateTime(Fecha_Fin.ToShortDateString());


                var select_ = from T in Base.vwcxc_cobro
                              where T.IdEmpresa == IdEmpresa
                              && T.IdSucursal >= IdsucursalIni 
                              && T.IdSucursal <= IdsucursalFin
                              && T.cr_fecha >= Fecha_Ini && T.cr_fecha <= Fecha_Fin
                              select T;
                foreach (var item in select_)
                {
                    cxc_cobro_Info dat = new cxc_cobro_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = item.IdCliente;
                    dat.cr_TotalCobro = item.cr_TotalCobro;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaCobro = item.cr_fechaCobro;
                    dat.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu);
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_Banco = item.cr_Banco;
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.cr_NumDocumento = item.cr_NumDocumento;
                    dat.cr_estado = item.cr_estado;
                    dat.cr_recibo = item.cr_recibo;
                    dat.cr_Codigo = item.cr_Codigo;
                    dat.IdCaja = item.IdCaja;
                    dat.IdBanco = Convert.ToInt32(item.IdBanco);
                    dat.cr_propietarioCta = item.cr_propietarioCta;
                    dat.cr_es_anticipo = item.cr_es_anticipo;
                    dat.cr_Tarjeta = Convert.ToString(item.cr_Tarjeta);
                    //dat.cr_estadoCobro = item.cr_estadoCobro;
                    dat.nSucursal = item.nSucursal;
                    dat.nCliente = item.nCliente;
                    dat.chek = false;

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_cobro_Info> Get_List_cobros_x_depositados(int IdEmpresa, int idsucursal, decimal idcobro)
        {
            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();
                cxc_cobro_Info Info = new cxc_cobro_Info();
                var select_ = from T in Base.vwcxc_Detalle_Deposito
                              where T.IdEmpresa == IdEmpresa && T.IdSucursal == idsucursal && T.IdCobro == idcobro
                              select T;
                ba_Banco_Cuenta_Info ba = new ba_Banco_Cuenta_Info();
                foreach (var item in select_)
                {
                    cxc_cobro_Info dat = new cxc_cobro_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = item.IdCliente;
                    dat.cr_TotalCobro = item.cr_TotalCobro;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaCobro = item.cr_fechaCobro;
                    //dat.cr_fechaEdicion =item.cr_fechaEdicion;
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_Banco = item.cr_Banco;
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.cr_NumDocumento = item.cr_NumDocumento;
                    //dat.cr_Tarjeta	 =item.cr_Tarjeta;
                    //dat.cr_numTarj	 =item.cr_numTarj;
                    dat.cr_estado = item.cr_estado;
                    dat.cr_recibo = item.cr_recibo;
                    //dat.cr_estadoCobro =item.cr_estadoCobro;
                    dat.cr_Tarjeta = Convert.ToString(item.cr_Tarjeta);
                    dat.nSucursal = item.nSucursal;
                    dat.nCliente = item.nCliente;
                    ba.ba_descripcion = item.ba_descripcion;
                    ba.ba_Num_Cuenta = item.ba_Num_Cuenta;
                    ba.IdCtaCble = item.IdCbteCble.ToString();
                    dat.BancoCuenta = ba;
                    dat.chek = false;

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_cobro_Info> Get_List_cobro_x_Tarjeta(int IdEmpresa, string tipoCheque, string EstadoCheque, DateTime desde, DateTime hasta)
        {
            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();

                var select_ = from T in Base.vwcxc_cobro_x_cobro_det
                                  where T.IdEmpresa == IdEmpresa && T.IdCobro_tipo == tipoCheque && T.IdEstadoCobro == EstadoCheque
                                  && T.cr_fecha >= desde && T.cr_fecha <= hasta
                                  select T;
              

                foreach (var item in select_)
                {
                    cxc_cobro_Info dat = new cxc_cobro_Info();
                    
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = item.IdCliente;
                    
                    dat.cr_TotalCobro =item.dc_ValorPago;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaCobro = item.cr_fechaCobro;
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_Banco = item.cr_Banco;
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.cr_NumDocumento = item.cr_NumDocumento;
          
                    dat.cr_Tarjeta = Convert.ToString(item.cr_Tarjeta);
   
                    dat.cr_estado = item.cr_estado;
                    dat.cr_recibo = item.cr_recibo;
                    dat.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_Cbte);
                    dat.nSucursal = item.nSucursal.Substring(0, 3);
                    dat.nCliente = item.nCliente.Trim();
                    dat.IdCaja = item.IdCaja;
                    dat.IdEstadoCobro = item.IdEstadoCobro;
                    dat.dc_TipoDocumento = item.dc_TipoDocumento;
                    dat.IdCbte_vta_nota = item.IdCbte_vta_nota;
                    dat.ValorCheque = item.cr_TotalCobro;
                    dat.chek = false;

                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_cobro_Info> Get_List_cobros_x_Factura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble, string TipoDoc)
        {
            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();
                
                var select_ = from A in Base.cxc_cobro
                              join B in Base.cxc_cobro_det
                              on new {A.IdEmpresa, A.IdSucursal, A.IdCobro} equals new {B.IdEmpresa, B.IdSucursal, B.IdCobro}
                              where A.IdEmpresa == IdEmpresa && A.IdSucursal == IdSucursal && B.IdCbte_vta_nota == IdCbteCble && B.dc_TipoDocumento == TipoDoc
                              select new {A, B};

                foreach (var item in select_)
                {
                    cxc_cobro_Info dat = new cxc_cobro_Info();
                    dat.IdEmpresa = item.A.IdEmpresa ;
                    dat.IdSucursal = item.A.IdSucursal;
                    dat.IdCobro = item.A.IdCobro;
                   
                    dat.dc_TipoDocumento = item.B.dc_TipoDocumento;
                    dat.dc_ValorPago = item.B.dc_ValorPago;
                    dat.estado = item.A.cr_estado;
                   // dat.cr_fechaEdicion =item.B.cr_fechaEdicion;
                    dat.IdBodega_Cbte = Convert.ToInt32(item.B.IdBodega_Cbte);
                    dat.IdCbte_vta_nota = item.B.IdCbte_vta_nota;
                    dat.secuencial = item.B.secuencial;
                    dat.IdCobro_tipo = item.A.IdCobro_tipo;
                    dat.cr_Banco = item.A.cr_Banco;
                    dat.cr_NumDocumento = item.A.cr_NumDocumento;
                    dat.cr_cuenta = item.A.cr_cuenta;
                    dat.cr_observacion = item.A.cr_observacion;
                    dat.cr_fechaDocu = item.A.cr_fechaDocu;
                    dat.cr_fechaCobro = item.A.cr_fechaCobro;
                    dat.cr_Tarjeta = Convert.ToString(item.A.cr_Tarjeta);
                    dat.IdCaja = item.A.IdCaja;

                    lM.Add(dat);
                }
                return(lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_cobro_Info> Get_List_cobro_x_Factura_x_DocxCobrar(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble, string TipoDoc, decimal IdCobro_doc_x_cobrar)
        {
            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();

                var select_ = from A in Base.cxc_cobro
                              join B in Base.cxc_cobro_det
                              on new { A.IdEmpresa, A.IdSucursal, A.IdCobro } equals new { B.IdEmpresa, B.IdSucursal, B.IdCobro }
                              where A.IdEmpresa == IdEmpresa && A.IdSucursal == IdSucursal && B.IdCbte_vta_nota == IdCbteCble && B.dc_TipoDocumento == TipoDoc
                              && A.IdCobro_a_aplicar == IdCobro_doc_x_cobrar
                              select new { A, B };

                foreach (var item in select_)
                {
                    cxc_cobro_Info dat = new cxc_cobro_Info();
                    dat.IdEmpresa = item.A.IdEmpresa;
                    dat.IdSucursal = item.A.IdSucursal;
                    dat.IdCobro = item.A.IdCobro;

                    dat.dc_TipoDocumento = item.B.dc_TipoDocumento;
                    dat.dc_ValorPago = item.A.cr_TotalCobro; //item.B.dc_ValorPago;
                    dat.estado = item.A.cr_estado;
                    dat.cr_fecha = item.A.cr_fecha;
                    dat.IdBodega_Cbte = Convert.ToInt32(item.B.IdBodega_Cbte);
                    dat.IdCbte_vta_nota = item.B.IdCbte_vta_nota;
                    dat.secuencial = item.B.secuencial;
                    dat.IdCobro_tipo = item.A.IdCobro_tipo;
                    dat.cr_Banco = item.A.cr_Banco;
                    dat.cr_NumDocumento = item.A.cr_NumDocumento;
                    dat.cr_cuenta = item.A.cr_cuenta;
                    dat.cr_observacion = item.A.cr_observacion;
                    dat.cr_fechaDocu = item.A.cr_fechaDocu;
                    dat.cr_fechaCobro = item.A.cr_fechaCobro;
                    dat.cr_Tarjeta = Convert.ToString(item.A.cr_Tarjeta);
                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(List<cxc_cobro_Info> Lst, ref List<cxc_cobro_Info> rLst )
        {
            try
            {
                foreach (var item in Lst)
                {
                    using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                    {
                        var Address = new cxc_cobro();
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdSucursal = item.IdSucursal;

                        Address.IdCobro = item.IdCobro = GetId(item.IdEmpresa, item.IdSucursal);

                        Address.cr_Codigo = (item.cr_Codigo == "") ? "CXC" + Address.IdCobro : item.cr_Codigo;

                        Address.cr_recibo = item.cr_recibo = GetRecibo(item.IdEmpresa, item.IdSucursal);
                        Address.cr_es_anticipo = item.cr_es_anticipo;
                        Address.IdCobro_tipo = item.IdCobro_tipo;
                        Address.IdCliente = item.IdCliente;
                        Address.cr_TotalCobro = item.cr_TotalCobro;
                        Address.cr_fecha = Convert.ToDateTime(item.cr_fecha.ToShortDateString());
                        Address.cr_fechaCobro =Convert.ToDateTime(item.cr_fechaCobro.ToShortDateString());
                        Address.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                        Address.cr_observacion = item.cr_observacion;
                        Address.cr_Banco = item.cr_Banco;
                        Address.cr_cuenta = item.cr_cuenta;
                        Address.cr_NumDocumento = item.cr_NumDocumento;
                        Address.cr_Tarjeta = item.cr_Tarjeta;
                        Address.cr_estado = "A";
                        Address.IdBanco = item.IdBanco;
                        Address.cr_propietarioCta = item.cr_propietarioCta;
                        Address.cr_recibo = item.cr_recibo;
                        Address.Fecha_Transac = item.Fecha_Transac;
                        Address.IdUsuario = item.IdUsuario;
                        Address.nom_pc = item.nom_pc;
                        Address.ip = item.ip;
                        Address.IdTipoNotaCredito = item.IdTipoNotaCredito;
                        
                        // haac 24/01/2014
                        Address.IdCaja = item.IdCaja;
                        // haac 24/01/2014

                        
                        //contact = Address;
                        Context.cxc_cobro.Add(Address);
                        Context.SaveChanges();


                        //var Contac = cxc_cobro_det.Createcxc_cobro_det(0, 0, 0, 0, 0, 0);
                        var address = new cxc_cobro_det();
                    
                        address.IdEmpresa = item.IdEmpresa;
                        address.IdSucursal = item.IdSucursal;
                        address.IdCobro = item.IdCobro;
                        address.secuencial = item.secuencial;//secuencia;
                        address.dc_TipoDocumento = item.dc_TipoDocumento;
                        address.IdBodega_Cbte = item.IdBodega_Cbte;
                        address.IdCbte_vta_nota = item.IdCbte_vta_nota;
                        address.dc_ValorPago = item.dc_ValorPago;
                        address.IdUsuario = item.IdUsuario;
                     // address.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        address.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                    
                        address.nom_pc = item.nom_pc;
                        address.ip = item.ip;

                       
                        rLst.Add(item);


                        //Contac = address;
                        Context.cxc_cobro_det.Add(address);
                        Context.SaveChanges();

                        

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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ValidarFacturaConCobros(int Idempresa , decimal IdCbte_vta_nota ) 
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar conexion = new EntitiesCuentas_x_Cobrar())
                {

                    var Cantid = (from q in conexion.cxc_cobro_det
                                  where q.IdCbte_vta_nota == IdCbte_vta_nota && q.IdEmpresa == Idempresa
                                  select q).Take(1);
                    //bv 
                    if (Cantid.Count() != 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
      
        public Boolean ExisteCobro(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble, string TipoDoc)
        {
            try
            {
                Boolean Existe;

                Existe = false;

                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();

                var select_ = from A in Base.cxc_cobro
                              join B in Base.cxc_cobro_det
                              on new { A.IdEmpresa, A.IdSucursal, A.IdCobro } equals new { B.IdEmpresa, B.IdSucursal, B.IdCobro }
                              where A.IdEmpresa == IdEmpresa && A.IdSucursal == IdSucursal && B.IdCbte_vta_nota == IdCbteCble && B.dc_TipoDocumento == TipoDoc
                              select new { A, B };
                foreach (var item in select_)
                {
                    Existe = true;
                }
                return Existe;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }//haac 24/01/2014  
      
        public cxc_cobro_Info Get_Info_cobro_x_cliente(int IdEmpresa, int IdSucursal, decimal IdCobro, int IdCliente)
        {
            try
            {
                //List<cxc_cobro_Info> Lst = new List<cxc_cobro_Info>();
                cxc_cobro_Info info = new cxc_cobro_Info();
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var select_ = from T in cxc.cxc_cobro
                                  where T.IdEmpresa == IdEmpresa && T.IdSucursal == IdSucursal && T.IdCobro == IdCobro
                                  && T.IdCliente == IdCliente
                                  select T;

                    foreach (var item in select_)
                    {
                        //cxc_cobro_Info info = new cxc_cobro_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdCobro = item.IdCobro;
                        info.IdCobro_tipo = item.IdCobro_tipo;
                        info.IdCliente = item.IdCliente;
                        info.cr_TotalCobro = item.cr_TotalCobro;
                        info.cr_fecha = item.cr_fecha;
                        info.cr_fechaCobro = item.cr_fechaCobro;
                        info.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu);
                        info.cr_observacion = item.cr_observacion;
                        info.cr_Banco = item.cr_Banco;
                        info.cr_propietarioCta = item.cr_propietarioCta;
                        info.cr_cuenta = item.cr_cuenta;
                        info.IdBanco = Convert.ToInt32(item.IdBanco);
                        info.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
                        info.cr_NumDocumento = item.cr_NumDocumento;
                        info.cr_estado = item.cr_estado;
                        info.cr_recibo = item.cr_recibo;
                        info.cr_Tarjeta = item.cr_Tarjeta;
                        info.IdUsuario = item.IdUsuario;
                        info.IdCaja = item.IdCaja;
                        info.cr_Codigo = item.cr_Codigo;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.IdTipoNotaCredito = Convert.ToInt32((item.IdTipoNotaCredito== null)? 0 :item.IdTipoNotaCredito);
                        info.cr_es_anticipo = item.cr_es_anticipo;
                        //Lst.Add(info);
                        /////////////////
                    }                                                          
                }
                //return Lst; 
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        
        }
      
        public List<vwcxc_cobros_x_vta_nota_x_Ret_Info>Get_List_cobro_x_RteFte(int IdEmpresa, int IdSucursal, int IdBodega_Cbte, decimal IdCbte_vta_nota,string TipoDoc)
        {
            List<vwcxc_cobros_x_vta_nota_x_Ret_Info> Listado = new List<vwcxc_cobros_x_vta_nota_x_Ret_Info>();
            try
            {
                string query = "select * from vwcxc_cobros_x_vta_nota_x_RetFuente " +
                    "where IdEmpresa =" + IdEmpresa + " and IdSucursal =" + IdSucursal + " and IdBodega_Cbte = " + IdBodega_Cbte + " and IdCbte_vta_nota =" + IdCbte_vta_nota
                    + " and dc_TipoDocumento='" + TipoDoc + "'";

                EntitiesCuentas_x_Cobrar Oent = new EntitiesCuentas_x_Cobrar();
                Listado = Oent.Database.SqlQuery<vwcxc_cobros_x_vta_nota_x_Ret_Info>(query).ToList();
                return Listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcxc_cobros_x_vta_nota_x_Ret_Info> Get_List_cobro_x_RteIVA(int IdEmpresa, int IdSucursal, int IdBodega_Cbte, decimal IdCbte_vta_nota, string TipoDoc)
        {
            List<vwcxc_cobros_x_vta_nota_x_Ret_Info> Listado = new List<vwcxc_cobros_x_vta_nota_x_Ret_Info>();
            try
            {
                string query = "select * from vwcxc_cobros_x_vta_nota_x_RetIVA " +
                    "where IdEmpresa ="+IdEmpresa+" and IdSucursal ="+IdSucursal +" and IdBodega_Cbte = "+IdBodega_Cbte+" and IdCbte_vta_nota ="+IdCbte_vta_nota
                +" and dc_TipoDocumento='" + TipoDoc + "'";
                EntitiesCuentas_x_Cobrar Oent = new EntitiesCuentas_x_Cobrar();
                Listado = Oent.Database.SqlQuery<vwcxc_cobros_x_vta_nota_x_Ret_Info>(query).ToList();
                return Listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        public cxc_cobro_Data(){ }

        public bool Valida_cobro_x_deposito(cxc_cobro_Info info,ref ba_Cbte_Ban_Info InfoCbteBan_del_deposito)
        {
            try
            {
                bool Tiene_deposito=false;

                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                    var lst = from q in context.vwcxc_cobros_x_cheque_deposito
                              where q.IdEmpresa == info.IdEmpresa &&
                              q.IdSucursal == info.IdSucursal && q.IdCobro == info.IdCobro
                              && q.ba_IdCbteCble!=null
                              select q;

                    

                    if (lst.Count() == 0)
                    {
                        Tiene_deposito= false;
                    }
                    else
                    {
                        Tiene_deposito= true;
                        foreach (var item in lst)
                        {
                            InfoCbteBan_del_deposito.IdEmpresa = item.IdEmpresa;
                            InfoCbteBan_del_deposito.IdTipocbte = Convert.ToInt32(item.ba_IdTipocbte);
                            InfoCbteBan_del_deposito.IdCbteCble = Convert.ToDecimal(item.ba_IdCbteCble);
                            InfoCbteBan_del_deposito.Banco = item.Banco_deposito;
                            InfoCbteBan_del_deposito.cb_Fecha = Convert.ToDateTime(item.Fecha_dep);
                       }
                    }
                }

                return Tiene_deposito;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
