using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_cancelacion_Intercompany_Det_Data
    {
        string mensaje = "";
        public List<cxc_cancelacion_Intercompany_det_Info> Get_List_cancelacion_Intercompany_det(int IdEmpresa, decimal IdCancelacion)
        {
            try
            {
                List<cxc_cancelacion_Intercompany_det_Info> Lst = new List<cxc_cancelacion_Intercompany_det_Info>();
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var Consultar = from q in cxc.cxc_cancelacion_Intercompany_det
                                    where q.IdEmpresa == IdEmpresa &&
                                    q.IdCancelacion == IdCancelacion
                                    select q;
                    foreach (var item in Consultar)
                    {
                        cxc_cancelacion_Intercompany_det_Info info = new cxc_cancelacion_Intercompany_det_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCancelacion = item.IdCancelacion;
                        info.Secuencia = item.Secuencia;
                        info.cbteVta_IdEmpresa = item.cbteVta_IdEmpresa;
                        info.cbteVta_IdSucursal = item.cbteVta_IdSucursal;
                        info.cbteVta_IdBodega = item.cbteVta_IdBodega;
                        info.cbteVta_TipoDoc = item.cbteVta_TipoDoc;
                        info.cbteVta_IdCbteVta = item.cbteVta_IdCbteVta;
                        info.cbr_IdEmpresa = item.cbr_IdEmpresa;
                        info.cbr_IdSucursal = item.cbr_IdSucursal;
                        info.cbr_IdCobro = item.cbr_IdCobro;
                        info.Valor_Aplicado = item.Valor_Aplicado;
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

        public cxc_cancelacion_Intercompany_det_Info Get_List_cancelacion_Intercompany_det(int IdEmpresa, decimal IdCancelacion, int Secuencia)
        {
            try
            {
                cxc_cancelacion_Intercompany_det_Info info = new cxc_cancelacion_Intercompany_det_Info();          
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var Consultar = from q in cxc.cxc_cancelacion_Intercompany_det
                                    where q.IdEmpresa == IdEmpresa &&
                                    q.IdCancelacion == IdCancelacion &&
                                    q.Secuencia == Secuencia
                                    select q;                    
                    foreach (var item in Consultar)
                    {                        
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCancelacion = item.IdCancelacion;
                        info.Secuencia = item.Secuencia;
                        info.cbteVta_IdEmpresa = item.cbteVta_IdEmpresa;
                        info.cbteVta_IdSucursal = item.cbteVta_IdSucursal;
                        info.cbteVta_IdBodega = item.cbteVta_IdBodega;
                        info.cbteVta_TipoDoc = item.cbteVta_TipoDoc;
                        info.cbteVta_IdCbteVta = item.cbteVta_IdCbteVta;
                        info.cbr_IdEmpresa = item.cbr_IdEmpresa;
                        info.cbr_IdSucursal = item.cbr_IdSucursal;
                        info.cbr_IdCobro = item.cbr_IdCobro;
                        info.Valor_Aplicado = item.Valor_Aplicado;
                    }
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

        public Boolean GuardarDB(List<cxc_cancelacion_Intercompany_det_Info> info) {
            try
            {
                EliminarDB(info); 
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    foreach (var item in info)
                    {
                        cxc_cancelacion_Intercompany_det data = new cxc_cancelacion_Intercompany_det();
                        data.IdEmpresa = item.IdEmpresa;
                        data.IdCancelacion = item.IdCancelacion;
                        data.Secuencia = item.Secuencia;
                        data.cbteVta_IdEmpresa = item.cbteVta_IdEmpresa;
                        data.cbteVta_IdSucursal = item.cbteVta_IdSucursal;
                        data.cbteVta_IdBodega = item.cbteVta_IdBodega;
                        data.cbteVta_TipoDoc = item.cbteVta_TipoDoc;
                        data.cbteVta_IdCbteVta = item.cbteVta_IdCbteVta;
                        data.cbr_IdEmpresa = item.cbr_IdEmpresa;
                        data.cbr_IdSucursal = item.cbr_IdSucursal;
                        data.cbr_IdCobro = item.cbr_IdCobro;
                        data.Valor_Aplicado = item.Valor_Aplicado;
                        cxc.cxc_cancelacion_Intercompany_det.Add(data);
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

        public Boolean EliminarDB(List<cxc_cancelacion_Intercompany_det_Info> info) 
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    foreach (var item in info)
                    {
                        var data = cxc.cxc_cancelacion_Intercompany_det.FirstOrDefault(v => v.IdEmpresa == item.IdEmpresa && v.IdCancelacion == item.IdCancelacion && v.Secuencia == item.Secuencia);
                        if (data != null)
                        {
                            cxc.cxc_cancelacion_Intercompany_det.Remove(data);
                            cxc.SaveChanges();
                            res = true;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
