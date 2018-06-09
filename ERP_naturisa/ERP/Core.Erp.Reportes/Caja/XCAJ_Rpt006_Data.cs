using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt006_Data
    {
        public List<XCAJ_Rpt006_Info> Get_list_reporte(int IdEmpresa, int IdCaja, int IdTipoMovi, decimal IdConciliacion, DateTime Fecha_ini, DateTime Fecha_fin, int IdPunto_Cargo)
        {
            try
            {
                List<XCAJ_Rpt006_Info> Lista = new List<XCAJ_Rpt006_Info>();
                int IdCaja_ini = IdCaja;
                int IdCaja_fin = IdCaja == 0 ? 999 : IdCaja;

                int IdTipoMovi_ini = IdTipoMovi;
                int IdTipoMovi_fin = IdTipoMovi == 0 ? 999 : IdTipoMovi;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                decimal IdConciliacion_ini = IdConciliacion;
                decimal IdConciliacion_fin = IdConciliacion == 0 ? 99999:IdConciliacion;

                using (EntitiesCaja_General Context = new EntitiesCaja_General())
                {
                    IQueryable<vwCAJ_Rpt006> lst;
                    if(IdPunto_Cargo == 0)
                    lst = from q in Context.vwCAJ_Rpt006
                              where q.IdEmpresa == IdEmpresa
                              && IdCaja_ini <= q.IdCaja && q.IdCaja <= IdCaja_fin
                              && IdTipoMovi_ini <= q.IdTipoMovi && q.IdTipoMovi <= IdTipoMovi_fin
                              && IdConciliacion_ini <= q.IdConciliacion_Caja && q.IdConciliacion_Caja <= IdConciliacion_fin
                              && Fecha_ini <= q.co_fechaOg && q.co_fechaOg <= Fecha_fin
                              select q;
                    else
                        lst = from q in Context.vwCAJ_Rpt006
                              where q.IdEmpresa == IdEmpresa
                              && IdCaja_ini <= q.IdCaja && q.IdCaja <= IdCaja_fin
                              && IdTipoMovi_ini <= q.IdTipoMovi && q.IdTipoMovi <= IdTipoMovi_fin
                              && IdConciliacion_ini <= q.IdConciliacion_Caja && q.IdConciliacion_Caja <= IdConciliacion_fin
                              && Fecha_ini <= q.co_fechaOg && q.co_fechaOg <= Fecha_fin
                              && q.IdPunto_cargo == IdPunto_Cargo
                              select q;

                    foreach (var item in lst)
                    {
                        XCAJ_Rpt006_Info info = new XCAJ_Rpt006_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdConciliacion_Caja = item.IdConciliacion_Caja;
                        info.Secuencia = item.Secuencia;
                        info.IdEmpresa_OGiro = item.IdEmpresa_OGiro;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.co_fechaOg = item.co_fechaOg;
                        info.IdProveedor = item.IdProveedor;
                        info.pr_codigo = item.pr_codigo;
                        info.IdPersona = item.IdPersona;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.IdTipoMovi = item.IdTipoMovi;
                        info.nom_tipo_movi = item.nom_tipo_movi;
                        info.co_factura = item.co_factura;
                        info.Num_Autorizacion = item.Num_Autorizacion;
                        info.co_subtotal_iva = item.co_subtotal_iva;
                        info.co_subtotal_siniva = item.co_subtotal_siniva;
                        info.co_valoriva = item.co_valoriva;
                        info.co_valorpagar = item.co_valorpagar;
                        info.Valor_a_aplicar = item.Valor_a_aplicar;
                        info.IdCaja = item.IdCaja;
                        info.nom_caja = item.nom_caja;
                        info.IdPeriodo = item.IdPeriodo;
                        info.Fecha_ini = item.Fecha_ini;
                        info.Fecha_fin = item.Fecha_fin;
                        info.Fecha_conci = item.Fecha_conci;
                        info.IdEstadoCierre = item.IdEstadoCierre;
                        info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        info.tipo_documento = item.tipo_documento;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        Lista.Add(info);
                    }
                  
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt005_Data) };
            }
        }
    }
}
