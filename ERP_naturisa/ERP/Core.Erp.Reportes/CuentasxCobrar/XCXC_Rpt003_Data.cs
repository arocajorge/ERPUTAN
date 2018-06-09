using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt003_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XCXC_Rpt003_Info> get_ImpresionConciliacion(int IdEmpresa, int IdSucursal, decimal IdConciliacion)
        {
            try
            {
                List<XCXC_Rpt003_Info> lstRpt = new List<XCXC_Rpt003_Info>();

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.vwCXC_Rpt003
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal == IdSucursal && q.IdConciliacion == IdConciliacion
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt003_Info infoRpt = new XCXC_Rpt003_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdConciliacion = item.IdConciliacion;
                        infoRpt.Fecha = item.Fecha;
                        infoRpt.IdTipoConciliacion = item.IdTipoConciliacion;
                        infoRpt.Saldo_por_aplicar = item.Saldo_por_aplicar;
                        infoRpt.Valor_Aplicado = item.Valor_Aplicado;
                        infoRpt.TipoDoc_vta = item.TipoDoc_vta;
                        infoRpt.Observacion = item.Observacion;
                        infoRpt.IdCliente = Convert.ToDecimal(item.IdCliente);
                        infoRpt.IdUsuario = item.IdUsuario;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.pe_telefonoCasa = item.pe_telefonoCasa;
                        infoRpt.pe_direccion = item.pe_direccion;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.IdEmpresa_cbte_cble = Convert.ToInt32(item.IdEmpresa_cbte_cble);
                        infoRpt.IdTipoCbte_cbte_cble = Convert.ToInt32(item.IdTipoCbte_cbte_cble);
                        infoRpt.IdCbteCble_cbte_cble = Convert.ToDecimal(item.IdCbteCble_cbte_cble);
                        infoRpt.Logo = Cbt.em_logo_Image;
                        infoRpt.numDocumento = item.numDocumento;

                        lstRpt.Add(infoRpt);
                    }
                   
                }

                return lstRpt;
            }                
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje); 
                return new List<XCXC_Rpt003_Info>();
            }
        }


    }
}
