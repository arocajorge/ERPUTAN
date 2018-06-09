using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt002_Data
    {
        string format = "dd/MM/yyyy";

       

        public List<XBAN_Rpt002_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin, int idBancoIni, int idBancoFin, string TipoCbte,decimal IdPersona_Girado)
        {

            try
            {

                decimal IdPersona_GiradoIni = 0;
                decimal IdPersona_GiradoFin = 0;

                List<XBAN_Rpt002_Info> listadedatos = new List<XBAN_Rpt002_Info>();
               
                
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());



                using (EntitiesBancos_Reporte_Ge ListadoCbte = new EntitiesBancos_Reporte_Ge())
                {                
                    if (IdPersona_Girado == 0)
                    {
                        
                        IQueryable<XBAN_Rpt002_Info> consulta = from h in ListadoCbte.vwBAN_Rpt002
                                                                where h.IdEmpresa == idempresa
                                                                && h.Fch_Cbte >= FechaIni && h.Fch_Cbte <= FechaFin
                                                                && h.IdBanco >= idBancoIni && h.IdBanco <= idBancoFin
                                                                && h.Tipo_Cbte.Contains(TipoCbte)
                                                                //&& (girado_A != "" ? h.Chq_Girado_A.Contains(girado_A) : true)
                                                         
                                                                select new XBAN_Rpt002_Info
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
                                                                  //  SFch_Cbte = h.Fch_Cbte.ToString(format),
                                                                    debe = h.debe,
                                                                    haber = h.haber,
                                                                    saldo = h.saldo,
                                                                    IdPersona_Girado_a = h.IdPersona_Girado_a
                                                                };

                        listadedatos = consulta.ToList();

                    }
                    else
                    {

                        IdPersona_GiradoIni = IdPersona_Girado;
                        IdPersona_GiradoFin = IdPersona_Girado;

                        IQueryable<XBAN_Rpt002_Info> consulta = from h in ListadoCbte.vwBAN_Rpt002
                                                                where h.IdEmpresa == idempresa
                                                                && h.Fch_Cbte >= FechaIni && h.Fch_Cbte <= FechaFin
                                                                && h.IdBanco >= idBancoIni && h.IdBanco <= idBancoFin
                                                                && h.Tipo_Cbte.Contains(TipoCbte)
                                                                //&& (girado_A != "" ? h.Chq_Girado_A.Contains(girado_A) : true)
                                                                 && h.IdPersona_Girado_a >= IdPersona_GiradoIni && h.IdPersona_Girado_a <= IdPersona_GiradoFin

                                                                select new XBAN_Rpt002_Info
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
                                                                   // SFch_Cbte = h.Fch_Cbte.ToString(format),
                                                                    debe = h.debe,
                                                                    haber = h.haber,
                                                                    saldo = h.saldo,
                                                                    IdPersona_Girado_a = h.IdPersona_Girado_a
                                                                };

                        listadedatos = consulta.ToList();
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
