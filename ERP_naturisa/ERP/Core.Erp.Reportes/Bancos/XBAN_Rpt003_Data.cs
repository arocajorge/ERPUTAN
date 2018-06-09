using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt003_Data
    {

        List<XBAN_Rpt003_Info> listadedatos = new List<XBAN_Rpt003_Info>();

        public List<XBAN_Rpt003_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin, int idBancoIni, int idBancoFin, string TipoCbte, /*string girado_A*/decimal IdPersona_Girado, string SchkImpreso, string Schkfacs, string Cheque)
        {

            try
            {
                List<XBAN_Rpt003_Info> lista = new List<XBAN_Rpt003_Info>();
               
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());


                decimal idPersona_GiradoIni = 0;

                decimal idPersona_GiradoFin = 0;

                


                using (EntitiesBancos_Reporte_Ge ListadoCbte = new EntitiesBancos_Reporte_Ge())
                {

                    if (IdPersona_Girado == 0)
                    {

                        IQueryable<XBAN_Rpt003_Info> consulta = from h in ListadoCbte.vwBAN_Rpt003
                                                                where h.IdEmpresa == idempresa
                                                                && h.Fch_Cbte >= FechaIni && h.Fch_Cbte <= FechaFin
                                                                && h.IdBanco >= idBancoIni && h.IdBanco <= idBancoFin
                                                                && h.Tipo_Cbte.Contains(TipoCbte)
                                                                    //&& (girado_A != "" ? h.Chq_Girado_A.Contains(girado_A) : true)
                                                                    // && h.IdPersona_Girado_a >= idPersona_GiradoIni && h.IdPersona_Girado_a <= idPersona_GiradoFin
                                                                && h.Es_Chq_Impreso.StartsWith(SchkImpreso)
                                                                && h.TipoRegistro.Contains(Schkfacs)
                                                                && h.Cheque.Contains(Cheque)
                                                                orderby h.IdReg

                                                                select new XBAN_Rpt003_Info
                                                                {
                                                                    IdEmpresa = h.IdEmpresa,
                                                                    Tipo_Cbte = h.Tipo_Cbte,
                                                                    Num_Cbte = h.Num_Cbte,
                                                                    IdBanco = h.IdBanco,
                                                                    Banco = h.Banco,
                                                                    Fch_Cbte = h.Fch_Cbte,
                                                                    Observacion = h.Observacion,
                                                                    Valor = h.Valor,
                                                                    Cheque = h.Cheque,
                                                                    Chq_Girado_A = h.Chq_Girado_A,
                                                                    IdTipoFlujo = h.IdTipoFlujo,
                                                                    Tipo_Flujo = h.Tipo_Flujo,
                                                                    IdTipoNota = h.IdTipoNota,
                                                                    Tipo_Nota = h.Tipo_Nota,
                                                                    Fch_PostFechado = h.Fch_PostFechado,
                                                                    Es_Chq_Impreso = h.Es_Chq_Impreso,
                                                                    Fch_Chq = h.Fch_Chq,
                                                                    Cta_Cble_Banco = h.Cta_Cble_Banco,
                                                                    IdCalendario = h.IdCalendario,
                                                                    AnioFiscal = h.AnioFiscal,
                                                                    NombreMes = h.NombreMes,
                                                                    NombreCortoFecha = h.NombreCortoFecha,
                                                                    IdMes = h.IdMes,
                                                                    pc_Cuenta = h.pc_Cuenta,
                                                                    MontoAplicado = h.MontoAplicado,
                                                                    IdOrdenPago_op = h.IdOrdenPago_op,
                                                                    Secuencia_op = h.Secuencia_op,
                                                                    Referencia = h.Referencia,
                                                                    Fecha_Venc_Fac_Prov = h.Fecha_Venc_Fac_Prov,
                                                                    Observacion_FP = h.Observacion_FP,
                                                                    TipoRegistro = h.TipoRegistro,
                                                                    debe = h.debe,
                                                                    haber = h.haber,
                                                                    saldo = h.saldo,
                                                                    IdPersona_Girado_a = h.IdPersona_Girado_a
                                                                };

                        lista = consulta.ToList();

                        if (String.IsNullOrEmpty(Schkfacs))
                        {
                            List<XBAN_Rpt004_Info> lista2 = new List<XBAN_Rpt004_Info>();
                            listadedatos = lista.FindAll(q => q.MontoAplicado != 0);
                        }
                        else
                        {
                            listadedatos = lista;
                        } 
                    }
                    else
                    {
                        idPersona_GiradoIni = IdPersona_Girado;
                        idPersona_GiradoFin = IdPersona_Girado;



                        IQueryable<XBAN_Rpt003_Info> consulta = from h in ListadoCbte.vwBAN_Rpt003
                                                                where h.IdEmpresa == idempresa
                                                                && h.Fch_Cbte >= FechaIni && h.Fch_Cbte <= FechaFin
                                                                && h.IdBanco >= idBancoIni && h.IdBanco <= idBancoFin
                                                                && h.Tipo_Cbte.Contains(TipoCbte)
                                                                    //&& (girado_A != "" ? h.Chq_Girado_A.Contains(girado_A) : true)
                                                                && h.IdPersona_Girado_a >= idPersona_GiradoIni && h.IdPersona_Girado_a <= idPersona_GiradoFin
                                                                && h.Es_Chq_Impreso.StartsWith(SchkImpreso)
                                                                && h.TipoRegistro.Contains(Schkfacs)
                                                                && h.Cheque.Contains(Cheque)
                                                                orderby h.IdReg

                                                                select new XBAN_Rpt003_Info
                                                                {
                                                                    IdEmpresa = h.IdEmpresa,
                                                                    Tipo_Cbte = h.Tipo_Cbte,
                                                                    Num_Cbte = h.Num_Cbte,
                                                                    IdBanco = h.IdBanco,
                                                                    Banco = h.Banco,
                                                                    Fch_Cbte = h.Fch_Cbte,
                                                                    Observacion = h.Observacion,
                                                                    Valor = h.Valor,
                                                                    Cheque = h.Cheque,
                                                                    Chq_Girado_A = h.Chq_Girado_A,
                                                                    IdTipoFlujo = h.IdTipoFlujo,
                                                                    Tipo_Flujo = h.Tipo_Flujo,
                                                                    IdTipoNota = h.IdTipoNota,
                                                                    Tipo_Nota = h.Tipo_Nota,
                                                                    Fch_PostFechado = h.Fch_PostFechado,
                                                                    Es_Chq_Impreso = h.Es_Chq_Impreso,
                                                                    Fch_Chq = h.Fch_Chq,
                                                                    Cta_Cble_Banco = h.Cta_Cble_Banco,
                                                                    IdCalendario = h.IdCalendario,
                                                                    AnioFiscal = h.AnioFiscal,
                                                                    NombreMes = h.NombreMes,
                                                                    NombreCortoFecha = h.NombreCortoFecha,
                                                                    IdMes = h.IdMes,
                                                                    pc_Cuenta = h.pc_Cuenta,
                                                                    MontoAplicado = h.MontoAplicado,
                                                                    IdOrdenPago_op = h.IdOrdenPago_op,
                                                                    Secuencia_op = h.Secuencia_op,
                                                                    Referencia = h.Referencia,
                                                                    Fecha_Venc_Fac_Prov = h.Fecha_Venc_Fac_Prov,
                                                                    Observacion_FP = h.Observacion_FP,
                                                                    TipoRegistro = h.TipoRegistro,
                                                                    debe = h.debe,
                                                                    haber = h.haber,
                                                                    saldo = h.saldo,
                                                                    IdPersona_Girado_a = h.IdPersona_Girado_a
                                                                };

                        lista = consulta.ToList();

                        if (String.IsNullOrEmpty(Schkfacs))
                        {
                            List<XBAN_Rpt004_Info> lista2 = new List<XBAN_Rpt004_Info>();
                            listadedatos = lista.FindAll(q => q.MontoAplicado != 0);
                        }
                        else
                        {
                            listadedatos = lista;
                        } 

                    }

                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_Rpt014_Data) };
            }


        }
    }
}
