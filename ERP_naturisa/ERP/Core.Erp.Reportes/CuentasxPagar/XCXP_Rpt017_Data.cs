using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt017_Data
    {
        string mensaje = "";


        public List<XCXP_Rpt017_Info> get_Reporte_Estado_Cuenta_Proveedor_con_Dias_Vencidos(int IdEmpresa, DateTime FechaCorte,decimal IdProveedorIni,decimal IdProveedorFin)
        {
            try
            {
                string format = "dd/MM/yyyy";
                FechaCorte = FechaCorte.Date;
              //  infoRpt.S_fECHA = item.fecha == null ? "" : Convert.ToDateTime(item.fecha).ToString(format);       
               
                
                List<XCXP_Rpt017_Info> lstRpt = new List<XCXP_Rpt017_Info>();

                using (EntitiesCXP_General listado = new EntitiesCXP_General())
                {
                    var select = from q in listado.spCXP_Rpt017(IdEmpresa, FechaCorte, IdProveedorIni, IdProveedorFin)
                                 where  q.Saldo>0
                                 select q;

                    foreach (var item in select)
                    {
                        XCXP_Rpt017_Info infoRpt = new XCXP_Rpt017_Info();
                        infoRpt.IdRow = item.IdRow;
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        infoRpt.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        infoRpt.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        infoRpt.Documento = item.Documento;
                        infoRpt.nom_tipo_doc = item.nom_tipo_doc;
                        infoRpt.cod_tipo_doc = item.cod_tipo_doc;
                        infoRpt.IdProveedor = item.IdProveedor;
                        infoRpt.nom_proveedor = item.nom_proveedor;
                        infoRpt.Valor_a_pagar = item.Valor_a_pagar;
                        infoRpt.MontoAplicado = item.MontoAplicado;
                        infoRpt.Saldo = item.Saldo;
                        infoRpt.Observacion = item.Observacion;
                        infoRpt.Ruc_Proveedor = item.Ruc_Proveedor;
                        infoRpt.representante_legal = item.representante_legal;
                        infoRpt.Tipo_cbte = item.Tipo_cbte;
                        infoRpt.Plazo_fact = item.Plazo_fact;
                        infoRpt.co_fechaOg = item.co_fechaOg;
                        infoRpt.co_FechaFactura_vct = item.co_FechaFactura_vct;
                        infoRpt.Dias_Vcto = item.Dias_Vcto;
                        infoRpt.Fecha_corte = item.Fecha_corte;
                        infoRpt.x_Vencer = item.x_Vencer;
                        infoRpt.Vencido_1_30 = item.Vencido_1_30;
                        infoRpt.Vencido_31_60 = item.Vencido_31_60;
                        infoRpt.Vencido_61_180 = item.Vencido_61_180;
                        infoRpt.Vencido_Mayor_181 = item.Vencido_Mayor_181;
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
                return new List<XCXP_Rpt017_Info>();
            }
        }
    }
}
