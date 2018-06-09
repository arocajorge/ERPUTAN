using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.CuentasxCobrar
{
    public class vwcxc_conciliacion_Det_Cobro_Data
    {

        public List<vwcxc_conciliacion_Det_Cobro_Info> Get_List_conciliacion_Det_Cobro(int IdEmpresa, int IdSucursal, decimal IdConciliacion, ref string mensaje)
        {
            try
            {
                List<vwcxc_conciliacion_Det_Cobro_Info> lstDetConciliaInfo = new List<vwcxc_conciliacion_Det_Cobro_Info>();                
                EntitiesCuentas_x_Cobrar ECXC = new EntitiesCuentas_x_Cobrar();

                var Conciliacion = from selec in ECXC.vwcxc_conciliacion_Det_Cobro
                                   where selec.IdEmpresa == IdEmpresa 
                                   && selec.IdSucursal == IdSucursal 
                                   && selec.IdConciliacion == IdConciliacion                                    
                                   select selec;

                foreach (var item in Conciliacion)
                {
                    vwcxc_conciliacion_Det_Cobro_Info info = new vwcxc_conciliacion_Det_Cobro_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdConciliacion = item.IdConciliacion;
                    info.IdCobro = Convert.ToDecimal(item.IdCobro);
                    info.IdBodega = Convert.ToInt32(item.IdBodega);
                    info.vt_tipoDoc = item.vt_tipoDoc;
                    info.vt_NunDocumento = item.vt_NunDocumento;
                    info.Referencia = item.Referencia;
                    info.IdComprobante = item.IdComprobante;
                    info.CodComprobante = item.CodComprobante;
                    info.Su_Descripcion = item.Su_Descripcion;
                    info.IdCliente = item.IdCliente;
                    info.vt_fecha = item.vt_fecha;
                    info.vt_total =Convert.ToDouble(item.vt_total);
                    info.Saldo = item.Saldo;
                    info.TotalxCobrado = item.TotalxCobrado;
                    info.Bodega = item.Bodega;
                    info.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                    info.vt_iva = Convert.ToDouble(item.vt_iva);
                    info.vt_fech_venc = Convert.ToDateTime(item.vt_fech_venc);
                    info.dc_ValorRetFu = item.dc_ValorRetFu;
                    info.dc_ValorRetIva = item.dc_ValorRetIva;
                    info.CodCliente = item.CodCliente;
                    info.NomCliente = item.NomCliente;
                    info.em_nombre = item.em_nombre;

                    lstDetConciliaInfo.Add(info);
                }
  
                return lstDetConciliaInfo;
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
