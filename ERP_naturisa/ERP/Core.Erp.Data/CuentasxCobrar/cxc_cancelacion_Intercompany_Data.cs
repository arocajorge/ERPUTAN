using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

///Prog: Derek Mejia
///V 22 02 2014 12.18

//ULT. MOD = DEREK MEJIA 12/02/2014info
namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_cancelacion_Intercompany_Data
    {
        string mensaje = "";
        decimal Id = 0;

        public List<cxc_cancelacion_Intercompany_Info> Get_List_cancelacion_Intercompany(int IdEmpresa)
        {
            try
            {
                List<cxc_cancelacion_Intercompany_Info> Lst = new List<cxc_cancelacion_Intercompany_Info>();
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var consulta = from q in cxc.vwcxc_cancelacion_Intercompany
                                   where q.IdEmpresa == IdEmpresa
                                   select q;
                    foreach (var item in consulta)
                    {
                        cxc_cancelacion_Intercompany_Info info = new cxc_cancelacion_Intercompany_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCancelacion = item.IdCancelacion;
                        info.IdCliente = item.IdCliente;
                        info.IdCobro_tipo = item.IdCobro_tipo;
                        info.IdBanco_Deposito = item.IdBanco_Deposito;
                        info.Observacion = item.Observacion;
                        info.PapeletaDeposito = item.PapeletaDeposito;
                        info.cbteban_IdEmpresa = item.cbteban_IdEmpresa;
                        info.cbteban_IdCbteCble = item.cbteban_IdCbteCble;
                        info.cbteban_IdTipocbte = item.cbteban_IdTipocbte;
                        info.cr_TotalCobro = item.cr_TotalCobro;
                        info.cr_fecha = item.cr_fecha;
                        info.cr_fechaDocu = item.cr_fechaDocu;
                        info.cr_fechaCobro = item.cr_fechaCobro;
                        info.Observacion = item.Observacion;
                        info.cr_observacion = item.cr_observacion;
                        info.cr_Banco = item.cr_Banco;
                        info.cr_cuenta = item.cr_cuenta;
                        info.cr_NumDocumento = item.cr_NumDocumento;
                        info.cr_Tarjeta = item.cr_Tarjeta;
                        info.cr_propietarioCta = item.cr_propietarioCta;
                        info.cr_estado = item.cr_estado;
                        info.Fecha_Transac = item.Fecha_Transac;
                        info.IdUsuario = item.IdUsuario;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = item.Fecha_UltAnu;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.IdSucursal = item.IdSucursal;
                        info.GeneraDeps = item.GeneraDeps;
                        info.NombreCliente = item.pe_nombreCompleto;
                        info.NombreSucursal = item.Su_Descripcion;
                        info.NombreTipoCobro = item.tc_descripcion;
                        info.IdTipoNotaCredito = item.IdTipoNotaCredito;
                        info.IdCaja = item.IdCaja;
                        info.NomEmp = item.em_nombre;
                        Lst.Add(info);
                    }
                }
                return Lst;
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

        public Boolean GuardarDB(cxc_cancelacion_Intercompany_Info info) {
            try
            {
                if (Modificar(info)==false)
                {
                    using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                    {
                        cxc_cancelacion_Intercompany data = new cxc_cancelacion_Intercompany();
                        data.IdEmpresa = info.IdEmpresa;
                        data.IdCancelacion = info.IdCancelacion;
                        data.IdCliente = info.IdCliente;
                        data.IdCobro_tipo = info.IdCobro_tipo;
                        data.IdBanco_Deposito = info.IdBanco_Deposito;
                        data.Observacion = info.Observacion;
                        data.PapeletaDeposito = info.PapeletaDeposito;
                        data.cbteban_IdEmpresa = info.cbteban_IdEmpresa;
                        data.cbteban_IdCbteCble = info.cbteban_IdCbteCble;
                        data.cbteban_IdTipocbte = info.cbteban_IdTipocbte;
                        data.cr_TotalCobro = info.cr_TotalCobro;
                        data.cr_fecha = info.cr_fecha;
                        data.cr_fechaDocu = info.cr_fechaDocu;
                        data.cr_fechaCobro = info.cr_fechaCobro;
                        data.cr_observacion = info.cr_observacion;
                        data.cr_Banco = info.cr_Banco;
                        data.cr_cuenta = info.cr_cuenta;
                        data.cr_NumDocumento = info.cr_NumDocumento;
                        data.cr_Tarjeta = info.cr_Tarjeta;
                        data.cr_propietarioCta = info.cr_propietarioCta;
                        data.cr_estado = info.cr_estado;
                        data.Fecha_Transac = info.Fecha_Transac;
                        data.IdUsuario = info.IdUsuario;
                        data.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        data.Fecha_UltMod = info.Fecha_UltMod;
                        data.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        data.Fecha_UltAnu = info.Fecha_UltAnu;
                        data.nom_pc = info.nom_pc;
                        data.ip = info.ip;
                        data.IdSucursal = info.IdSucursal;
                        data.GeneraDeps = info.GeneraDeps;
                        data.IdTipoNotaCredito = info.IdTipoNotaCredito;
                        data.IdCaja = info.IdCaja;
                        cxc.cxc_cancelacion_Intercompany.Add(data);
                        cxc.SaveChanges();
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

        public Boolean Modificar(cxc_cancelacion_Intercompany_Info info) 
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var modificar = cxc.cxc_cancelacion_Intercompany.FirstOrDefault(v => v.IdEmpresa==info.IdEmpresa && v.IdCancelacion==info.IdCancelacion);
                    if (modificar != null)
                    {
                        modificar.cr_observacion = info.cr_observacion;
                        modificar.Observacion = info.Observacion;
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
        
        public decimal GetId(decimal IdEmpresa) {
            try
            {                                
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    Id = (from q in cxc.cxc_cancelacion_Intercompany
                                  where q.IdEmpresa == IdEmpresa
                                  select q.IdCancelacion).Max();
                     Id = Id + 1;                    
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

        public List<vwcxc_cancelacion_Intercompany_x_cxc_cobro_det_Info> Get_List_cancelacion_Intercompany_x_cxc_cobro_det(int IdEmpresa, decimal IdCancelacion)
        {
            try
            {
                List<vwcxc_cancelacion_Intercompany_x_cxc_cobro_det_Info> Lst = new List<vwcxc_cancelacion_Intercompany_x_cxc_cobro_det_Info>();
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var cons = from q in cxc.vwcxc_cancelacion_Intercompany_x_cxc_cobro_det
                               where q.IdEmpresa == IdEmpresa && q.IdCancelacion == IdCancelacion
                               select q;
                    foreach (var item in cons)
                    {
                        vwcxc_cancelacion_Intercompany_x_cxc_cobro_det_Info info = new vwcxc_cancelacion_Intercompany_x_cxc_cobro_det_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCancelacion = item.IdCancelacion;
                        info.Secuencia = item.Secuencia;
                        info.IdCobro = item.IdCobro;
                        info.cr_fecha = item.cr_fecha;
                        info.cr_fechaDocu = item.cr_fechaDocu;
                        info.cr_fechaCobro = item.cr_fechaCobro;
                        info.cr_observacion = item.cr_observacion;
                        info.cr_Banco = item.cr_Banco;
                        info.cr_cuenta = item.cr_cuenta;
                        info.cr_NumDocumento = item.cr_NumDocumento;
                        info.cr_Tarjeta = item.cr_Tarjeta;
                        info.IdCliente = item.IdCliente;
                        info.NomCliente = item.NomCliente;
                        info.Valor_Aplicado = item.Valor_Aplicado;
                        info.Referencia = item.Referencia;
                        Lst.Add(info);
                    }
                }
                return Lst;
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
