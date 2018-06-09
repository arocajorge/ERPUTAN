using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
//DEREK MEJIA 21/03/2014
namespace Core.Erp.Data.CuentasxPagar
{
    public class vwcp_Retenciones_x_tipo_impresion_Data
    {
        string mensaje = "";

        public List<vwcp_Retenciones_x_tipo_impresion_Info> Get_List_Retenciones_x_tipo_impresion(int IdEmpresa, int IdProveedor, DateTime Desde, DateTime Hasta, string Impresion)
        {
            try
            {
                int IdProveedorIni;
                int IdProveedorFin;
                if (IdProveedor == 0)
                {
                    IdProveedorIni = 0;
                    IdProveedorFin = 99999999;
                }
                else
                {
                    IdProveedorIni = IdProveedor;
                    IdProveedorFin = IdProveedor;
                }
                List<vwcp_Retenciones_x_tipo_impresion_Info> Lst = new List<vwcp_Retenciones_x_tipo_impresion_Info>();
                using(EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
	            {
                    var Consultar = from q in CxP.vwcp_Retenciones_x_tipo_impresion
                                    where q.IdEmpresa == IdEmpresa
                                    && q.IdProveedor >= IdProveedorIni
                                    && q.IdProveedor <= IdProveedorFin
                                    && q.co_FechaFactura >= Desde
                                    && q.co_FechaFactura <= Hasta
                                    && q.sImpresion == Impresion
                                    select q;

                    foreach (var item in Consultar)
                    {
                        vwcp_Retenciones_x_tipo_impresion_Info info = new vwcp_Retenciones_x_tipo_impresion_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.Sucursal = item.Sucursal;
                        info.IdProveedor = item.IdProveedor;
                        info.Proveedor = item.Proveedor;
                        info.NumCbteCXP = item.NumCbteCXP;
                        info.NumDocumento = item.NumDocumento;
                        info.co_FechaFactura = item.co_FechaFactura;
                        info.co_FechaFactura_vct = item.co_FechaFactura_vct;
                        info.Referencia = item.Referencia;
                        info.co_total = item.co_total;
                        info.co_valorpagar = item.co_valorpagar;
                        info.IdRetencion = item.IdRetencion;
                        info.NAutorizacion = item.NAutorizacion;
                        info.NumRetencion = item.NumRetencion;
                        info.FechaRT = item.FechaRT;
                        info.sImpresion = item.sImpresion;
                        info.TipoImpresion = item.TipoImpresion;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.serie = item.serie;
                        Lst.Add(info);
                    }
	            }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        
        }

        public List<vwcp_Retenciones_x_tipo_impresion_Info> Get_List_Retenciones_x_tipo_impresion(int IdEmpresa, DateTime Desde, DateTime Hasta, string Impresion)
        {
            try
            {
                List<vwcp_Retenciones_x_tipo_impresion_Info> Lst = new List<vwcp_Retenciones_x_tipo_impresion_Info>();
                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    var Consultar = from q in CxP.vwcp_Retenciones_x_tipo_impresion
                                    where q.IdEmpresa == IdEmpresa
                                    && q.co_FechaFactura >= Desde
                                    && q.co_FechaFactura <= Hasta
                                    && q.sImpresion == Impresion
                                    select q;

                    foreach (var item in Consultar)
                    {
                        vwcp_Retenciones_x_tipo_impresion_Info info = new vwcp_Retenciones_x_tipo_impresion_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.Sucursal = item.Sucursal;
                        info.IdProveedor = item.IdProveedor;
                        info.Proveedor = item.Proveedor;
                        info.NumCbteCXP = item.NumCbteCXP;
                        info.NumDocumento = item.NumDocumento;
                        info.co_FechaFactura = item.co_FechaFactura;
                        info.co_FechaFactura_vct = item.co_FechaFactura_vct;
                        info.Referencia = item.Referencia;
                        info.co_total = item.co_total;
                        info.co_valorpagar = item.co_valorpagar;
                        info.IdRetencion = item.IdRetencion;
                        info.NAutorizacion = item.NAutorizacion;
                        info.NumRetencion = item.NumRetencion;
                        info.FechaRT = item.FechaRT;
                        info.sImpresion = item.sImpresion;
                        info.TipoImpresion = item.TipoImpresion;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.serie = item.serie;
                        Lst.Add(info);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_Retenciones_x_tipo_impresion_Info> Get_List_Retenciones_x_tipo_impresion(int IdEmpresa, string Impresion)
        {
            try
            {
                List<vwcp_Retenciones_x_tipo_impresion_Info> Lst = new List<vwcp_Retenciones_x_tipo_impresion_Info>();
                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    var Consultar = from q in CxP.vwcp_Retenciones_x_tipo_impresion
                                    where q.IdEmpresa == IdEmpresa                                    
                                    && q.sImpresion == Impresion
                                    select q;

                    foreach (var item in Consultar)
                    {
                        vwcp_Retenciones_x_tipo_impresion_Info info = new vwcp_Retenciones_x_tipo_impresion_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.Sucursal = item.Sucursal;
                        info.IdProveedor = item.IdProveedor;
                        info.Proveedor = item.Proveedor;
                        info.NumCbteCXP = item.NumCbteCXP;
                        info.NumDocumento = item.NumDocumento;
                        info.co_FechaFactura = item.co_FechaFactura;
                        info.co_FechaFactura_vct = item.co_FechaFactura_vct;
                        info.Referencia = item.Referencia;
                        info.co_total = item.co_total;
                        info.co_valorpagar = item.co_valorpagar;
                        info.IdRetencion = item.IdRetencion;
                        info.NAutorizacion = item.NAutorizacion;
                        info.NumRetencion = item.NumRetencion;
                        info.FechaRT = item.FechaRT;
                        info.sImpresion = item.sImpresion;
                        info.TipoImpresion = item.TipoImpresion;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.serie = item.serie;
                        Lst.Add(info);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
