using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxCobrar
{ 
    public class cxc_cobro_x_caj_Caja_Movimiento_Data
    {
        string mensaje = "";

        public List<cxc_cobro_x_caj_Caja_Movimiento_Info> Get_List_cobro_x_caj_Caja_Movimiento(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<cxc_cobro_x_caj_Caja_Movimiento_Info> lM = new List<cxc_cobro_x_caj_Caja_Movimiento_Info>();
                
                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

                var select = from q in CxC.cxc_cobro_x_caj_Caja_Movimiento 
                             where q.cbr_IdEmpresa == IdEmpresa && q.cbr_IdSucursal == IdSucursal 
                             select q;

                foreach (var item in select)
                {
                    cxc_cobro_x_caj_Caja_Movimiento_Info info = new cxc_cobro_x_caj_Caja_Movimiento_Info();
                    info.cbr_IdCobro = item.cbr_IdCobro;
                    info.cbr_IdEmpresa = item.cbr_IdEmpresa;
                    info.cbr_IdSucursal = item.cbr_IdSucursal;
                    info.mcj_IdCbteCble = item.mcj_IdCbteCble;
                    info.mcj_IdEmpresa = item.mcj_IdEmpresa;
                    info.mcj_IdTipocbte = item.mcj_IdTipocbte;

                    lM.Add(info);
                }
                return lM;
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

        public List<cxc_cobro_x_caj_Caja_Movimiento_Info> Get_List_cobro_x_caj_Caja_Movimiento(int IdEmpresa)
        {
            try
            {
                List<cxc_cobro_x_caj_Caja_Movimiento_Info> lM = new List<cxc_cobro_x_caj_Caja_Movimiento_Info>();

                EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

              //  var select = from q in CxC.vwcxc_cobro_x_caj_Caja_Movimiento
                              var select = from q in CxC.vwcxc_cobro_x_movi_caja_x_cbtecble
                            // where q.cbr_IdEmpresa == IdEmpresa
                                           where q.IdEmpresa== IdEmpresa 
                             //&& q.cbr_IdSucursal == IdSucursal
                             //&& q.cbr_IdCobro == IdCobro
                             select q;

                foreach (var item in select)
                {
                    cxc_cobro_x_caj_Caja_Movimiento_Info info = new cxc_cobro_x_caj_Caja_Movimiento_Info();
                   
                    info.cbr_IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                    info.cbr_IdCobro = Convert.ToDecimal(item.IdCobro);
                    info.IdCobro_tipo = item.IdCobro_tipo;
                    info.cr_TotalCobro = item.cr_TotalCobro;
                    info.cr_fecha = Convert.ToDateTime(item.cr_fecha);
                    info.cr_Banco = item.cr_Banco;
                    info.cr_cuenta = item.cr_cuenta;
                    info.cr_NumDocumento = item.cr_NumDocumento;
                    info.tc_TipoCbte2 = item.tc_TipoCbte;
                    info.Num_CbteCble = item.Num_CbteCble;
                    info.IdCaja = Convert.ToInt32(item.IdCaja);
                    info.ca_Descripcion = item.ca_Descripcion;
                    info.Movi_Caja = Convert.ToDecimal(item.Movi_Caja);
                    info.tm_descripcion = item.tm_descripcion;
                    lM.Add(info);
                }
                return lM;
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
                
        public Boolean GuardarDB(cxc_cobro_x_caj_Caja_Movimiento_Info info) {
            try
            {
                using (EntitiesCuentas_x_Cobrar context=new EntitiesCuentas_x_Cobrar())
                {

                    //var contactG = cxc_cobro_x_caj_Caja_Movimiento.Createcxc_cobro_x_caj_Caja_Movimiento(0,0,0,0,0,0);
                    
                    var addressG = new cxc_cobro_x_caj_Caja_Movimiento();
                    addressG.cbr_IdCobro = info.cbr_IdCobro;
                    addressG.cbr_IdEmpresa = info.cbr_IdEmpresa;
                    addressG.cbr_IdSucursal = info.cbr_IdSucursal;
                    addressG.mcj_IdTipocbte = info.mcj_IdTipocbte;
                    addressG.mcj_IdCbteCble = info.mcj_IdCbteCble;
                    addressG.mcj_IdEmpresa= info.mcj_IdEmpresa;

                    //contactG = addressG;
                    context.cxc_cobro_x_caj_Caja_Movimiento.Add(addressG);
                    context.SaveChanges();
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

        public cxc_cobro_x_caj_Caja_Movimiento_Info Get_Info_cobro_x_caj_Caja_Movimiento(int IdEmpresa, int IdSucursal, decimal IdCobro)
        {
            try
            {
                cxc_cobro_x_caj_Caja_Movimiento_Info info = new cxc_cobro_x_caj_Caja_Movimiento_Info();
                    EntitiesCuentas_x_Cobrar CxC = new EntitiesCuentas_x_Cobrar();

                    var select = from q in CxC.cxc_cobro_x_caj_Caja_Movimiento where q.cbr_IdEmpresa==IdEmpresa && q.cbr_IdSucursal==IdSucursal && q.cbr_IdCobro==IdCobro select q;
                    foreach (var item in select)
                    {
                        info.cbr_IdCobro = item.cbr_IdCobro;
                        info.cbr_IdEmpresa = item.cbr_IdEmpresa;
                        info.cbr_IdSucursal = item.cbr_IdSucursal;
                        info.mcj_IdCbteCble = item.mcj_IdCbteCble;
                        info.mcj_IdEmpresa = item.mcj_IdEmpresa;
                        info.mcj_IdTipocbte = item.mcj_IdTipocbte;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
