using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxCobrar
{
    
    public class cxc_cobro_x_ct_cbtecble_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(cxc_cobro_x_ct_cbtecble_Info info)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                    var addressG = new cxc_cobro_x_ct_cbtecble();
                    addressG.cbr_IdEmpresa = info.cbr_IdEmpresa;
                    addressG.cbr_IdSucursal = info.cbr_IdSucursal;
                    addressG.cbr_IdCobro = info.cbr_IdCobro;
                    addressG.ct_IdEmpresa = info.ct_IdEmpresa;
                    addressG.ct_IdTipoCbte = info.ct_IdTipoCbte;
                    addressG.ct_IdCbteCble = info.ct_IdCbteCble;
                    context.cxc_cobro_x_ct_cbtecble.Add(addressG);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GuardarCbr_x_Cbte_Reverso(cxc_cobro_x_ct_cbtecble_Info info)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                   
                    var addressG = new cxc_cobro_x_ct_cbtecble_x_Anulado();
                    addressG.cbr_IdEmpresa = info.cbr_IdEmpresa;
                    addressG.cbr_IdSucursal = info.cbr_IdSucursal;
                    addressG.cbr_IdCobro = info.cbr_IdCobro;
                    addressG.ct_IdEmpresa = info.ct_IdEmpresa; 
                    addressG.ct_IdTipoCbte = info.ct_IdTipoCbte;
                    addressG.ct_IdCbteCble = info.ct_IdCbteCble;
                    context.cxc_cobro_x_ct_cbtecble_x_Anulado.Add(addressG);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public cxc_cobro_x_ct_cbtecble_Info Get_Info_cobro_x_ct_cbtecble(int IdEmpresa, int IdSucuersal, decimal IdCobro)
        {
            try
            {
                cxc_cobro_x_ct_cbtecble_Info Info = new cxc_cobro_x_ct_cbtecble_Info();
                EntitiesCuentas_x_Cobrar fac = new EntitiesCuentas_x_Cobrar();
                var select = from q in fac.cxc_cobro_x_ct_cbtecble 
                             where q.cbr_IdEmpresa == IdEmpresa 
                             && q.cbr_IdSucursal == IdSucuersal 
                             && q.cbr_IdCobro == IdCobro 
                             select q;

                foreach (var item in select)
                {
                    Info.cbr_IdCobro = item.cbr_IdCobro;
                    Info.cbr_IdEmpresa = item.cbr_IdEmpresa;
                    Info.cbr_IdSucursal = item.cbr_IdSucursal;
                    Info.ct_IdCbteCble = item.ct_IdCbteCble;
                    Info.ct_IdEmpresa = item.ct_IdEmpresa;
                    Info.ct_IdTipoCbte = item.ct_IdTipoCbte;
                }
                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public cxc_cobro_x_ct_cbtecble_Info Get_List_cobro_x_ct_cbtecble_x_Reverso(int IdEmpresa, int IdSucuersal, decimal IdCobro)
        {
            try
            {
                cxc_cobro_x_ct_cbtecble_Info Info = new cxc_cobro_x_ct_cbtecble_Info();
                EntitiesCuentas_x_Cobrar fac = new EntitiesCuentas_x_Cobrar();
                var select = from q in fac.cxc_cobro_x_ct_cbtecble_x_Anulado 
                             where q.cbr_IdEmpresa == IdEmpresa && q.cbr_IdSucursal == IdSucuersal && q.cbr_IdCobro == IdCobro select q;
                foreach (var item in select)
                {
                    Info.cbr_IdCobro = item.cbr_IdCobro;
                    Info.cbr_IdEmpresa = item.cbr_IdEmpresa;
                    Info.cbr_IdSucursal = item.cbr_IdSucursal;
                    Info.ct_IdCbteCble = item.ct_IdCbteCble;
                    Info.ct_IdEmpresa = item.ct_IdEmpresa;
                    Info.ct_IdTipoCbte = item.ct_IdTipoCbte;
                }
                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}