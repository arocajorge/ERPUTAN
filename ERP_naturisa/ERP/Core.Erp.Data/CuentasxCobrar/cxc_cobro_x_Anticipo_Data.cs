using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_cobro_x_Anticipo_Data
    {
        string mensaje = "";

        public List<cxc_cobro_x_Anticipo_Info> Get_List_cobro_x_Anticipo(int IdEmpresa, ref string mensaje)
        {
            try
            {
                List<cxc_cobro_x_Anticipo_Info> Lst = new List<cxc_cobro_x_Anticipo_Info>();
                List<cxc_cobro_x_Anticipo_Info> Lista = new List<cxc_cobro_x_Anticipo_Info>();
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var consultar = from q in cxc.vwcxc_cobro_x_Anticipo_x_Persona
                                    where q.IdEmpresa == IdEmpresa
                                    select q;
                    foreach (var item in consultar)
                    {
                        cxc_cobro_x_Anticipo_Info info = new cxc_cobro_x_Anticipo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdAnticipo = item.IdAnticipo;
                        info.IdCliente = item.IdCliente;
                        info.nombreCliente = item.pe_nombreCompleto;
                        info.Observacion = item.Observacion;
                        info.Fecha = item.Fecha;

                        //info.IdCbteCble_Caja = item.IdCbteCble_Caja;
                        //info.IdEmpresa_Caja = item.IdEmpresa_Caja;

                        info.IdSucursal = item.IdSucursal;
                        info.Fecha_Transac = item.Fecha_Transac;
                        info.IdUsuario = item.IdUsuario;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = item.Fecha_UltAnu;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.Estado = item.Estado;
                        info.IdCaja = Convert.ToInt32(item.IdCaja);
                        Lst.Add(info);
                    }
                    Lista = new List<cxc_cobro_x_Anticipo_Info>(Lst.OrderByDescending(d=>d.IdAnticipo));
                }
                return Lista;
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

        public Boolean GrabarDB(cxc_cobro_x_Anticipo_Info info, ref string mensaje)
        {
            try
            {
               
                    using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                    {
                        cxc_cobro_x_Anticipo data = new cxc_cobro_x_Anticipo();
                        data.IdEmpresa = info.IdEmpresa;
                        data.IdAnticipo = info.IdAnticipo= GetId(ref mensaje);
                        data.IdCliente = Convert.ToDecimal(info.IdCliente);
                        data.Observacion = info.Observacion;
                        data.Fecha = info.Fecha;
                        //data.IdCbteCble_Caja = info.IdCbteCble_Caja;
                        //data.IdEmpresa_Caja = info.IdEmpresa_Caja;
                        data.IdSucursal = info.IdSucursal;
                        data.Fecha_Transac = info.Fecha_Transac;
                        data.IdUsuario = info.IdUsuario;
                        data.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        data.Fecha_UltMod = info.Fecha_UltMod;
                        data.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        data.Fecha_UltAnu = info.Fecha_UltAnu;
                        data.nom_pc = info.nom_pc;
                        data.ip = info.ip;
                        data.Estado = info.Estado;
                        data.IdCaja = info.IdCaja;
                        cxc.cxc_cobro_x_Anticipo.Add(data);
                        cxc.SaveChanges();
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

        public Boolean ModificarDB(cxc_cobro_x_Anticipo_Info info,ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    cxc_cobro_x_Anticipo mod = cxc.cxc_cobro_x_Anticipo.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa 
                        && v.IdCliente == info.IdCliente 
                        && v.IdAnticipo==info.IdAnticipo);

                    if (mod != null)
                    {
                        mod.Observacion = info.Observacion;
                        mod.Fecha = info.Fecha;
                        //mod.IdCbteCble_Caja = info.IdCbteCble_Caja;
                        //mod.IdEmpresa_Caja = info.IdEmpresa_Caja;
                        mod.IdSucursal = info.IdSucursal;
                        mod.Fecha_Transac = info.Fecha_Transac;
                        mod.IdUsuario = info.IdUsuario;
                        mod.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        mod.Fecha_UltMod = info.Fecha_UltMod;
                        mod.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        mod.Fecha_UltAnu = info.Fecha_UltAnu;
                        mod.nom_pc = info.nom_pc;
                        mod.ip = info.ip;
                        mod.Estado = info.Estado;
                        mod.IdCaja = info.IdCaja;
                        cxc.SaveChanges();
                        res = true;
                    }
                }
                return res;
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

        public decimal Existe(int IdCliente, ref string mensaje)
        {
            try
            {
                decimal numero = 0;
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var consu = from q in cxc.cxc_cobro_x_Anticipo
                                where q.IdCliente == IdCliente
                                select q;
                    foreach (var item in consu)
                    {
                        numero = item.IdAnticipo;
                    }
                }
                return numero;
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

        public decimal GetId(ref string mensaje)
        {
            try
            {
                decimal id = 0;
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var cons = from q in cxc.cxc_cobro_x_Anticipo
                               select q;
                    id = cons.ToList().Count + 1;
                }
                return id;
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

        public List<cxc_cobro_x_Anticipo_Info> Get_List_cobro_x_Anticipo(int IdEmpresa, int IdAnticipo, ref string mensaje)
        {
            try
            {
                List<cxc_cobro_x_Anticipo_Info> lM = new List<cxc_cobro_x_Anticipo_Info>();
                EntitiesCuentas_x_Cobrar Base = new EntitiesCuentas_x_Cobrar();

                var select_ = from T in Base.vwcxc_Cobro_x_anticipo_x_cobros
                              where T.IdEmpresa == IdEmpresa
                              && T.IdAnticipo == IdAnticipo
                              select T;

                foreach (var item in select_)
                {
                    //cxc_cobro_Info dat = new cxc_cobro_Info();

                    //dat.IdEmpresa = item.IdEmpresa;
                    //dat.IdSucursal = item.IdSucursal;
                    //dat.IdCobro = item.IdCobro;
                    //dat.IdCobro_tipo = item.IdCobro_tipo;
                    //dat.IdCliente = item.IdCliente;
                    //dat.cr_TotalCobro = item.cr_TotalCobro;
                    //dat.cr_fecha = item.cr_fecha;
                    //dat.cr_fechaCobro = item.cr_fechaCobro;
                    //dat.cr_fechaDocu = item.cr_fechaDocu;
                    //dat.cr_observacion = item.cr_observacion;
                    //dat.cr_Banco = item.cr_Banco;
                    //dat.IdBanco = Convert.ToInt32(item.IdBanco);
                    //dat.cr_cuenta = item.cr_cuenta;
                    //dat.cr_NumDocumento = item.cr_NumDocumento;
                    //dat.cr_Tarjeta = item.cr_Tarjeta;
                    //dat.cr_estado = item.cr_estado;
                    //dat.cr_recibo = item.cr_recibo;
                    //dat.nSucursal = item.nSucursal;
                    //dat.nCliente = item.nCliente;
                    //dat.chek = false;

                    cxc_cobro_x_Anticipo_Info dat = new cxc_cobro_x_Anticipo_Info();

                    dat.IdEmpresa2 = item.IdEmpresa;
                    dat.IdAnticipo = item.IdAnticipo;
                    dat.Secuencia = item.Secuencia;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdEmpresa_Cobro = Convert.ToInt32(item.IdEmpresa_Cobro);
                    dat.IdSucursal_cobro = Convert.ToInt32(item.IdSucursal_cobro);
                    dat.IdCobro_cobro = Convert.ToInt32(item.IdCobro_cobro);
                    dat.IdCliente2 = item.IdCliente;
                    dat.cr_fecha = item.cr_fecha;
                    dat.cr_fechaDocu = item.cr_fechaDocu;
                    dat.cr_fechaCobro = item.cr_fechaCobro;
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_Banco = item.cr_Banco;
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.cr_NumDocumento = item.cr_NumDocumento;
                    dat.cr_Tarjeta = item.cr_Tarjeta;
                    dat.cr_propietarioCta = item.cr_propietarioCta;
                    dat.mcj_IdEmpresa = Convert.ToInt32(item.mcj_IdEmpresa);
                    dat.mcj_IdCbteCble = Convert.ToInt32(item.mcj_IdCbteCble);
                    dat.mcj_IdTipocbte = Convert.ToInt32(item.mcj_IdTipocbte);
                    dat.Valor = Convert.ToDouble(item.cr_TotalCobro);
                    dat.IdBanco = item.IdBanco;
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
    }
}
