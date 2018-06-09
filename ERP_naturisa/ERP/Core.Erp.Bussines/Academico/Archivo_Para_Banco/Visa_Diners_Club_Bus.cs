using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Info.Academico.Archivo_Para_Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Academico.Archivo_Para_Banco
{
   public class Visa_Diners_Club_Bus
    {
       string mensaje = "";


       ba_Archivo_Transferencia_Det_Info Info_pacifico = new ba_Archivo_Transferencia_Det_Info();
       public bool Grabar(List<ba_Archivo_Transferencia_Det_Info> lista, string nombreArchivo, ebanco_procesos_bancarios_tipo codigo_proceso)
       {
           try
           {
               string msg = "";
               int secuenia = 0;
               switch (codigo_proceso)
               {
                   case ebanco_procesos_bancarios_tipo.PAGO_BANCO_PACIFICO_BPA:
                       break;
  

                   case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BOL:
                       break;
                   case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BP:
                       
                       break;
                   case ebanco_procesos_bancarios_tipo.PREAVISO_CHEQ:
                       break;
                   case ebanco_procesos_bancarios_tipo.ROL_ELECTRONICO_BG:
                       break;
                   case ebanco_procesos_bancarios_tipo.TRANSF_BANCARIA_BP:
                       break;
                   
                   case ebanco_procesos_bancarios_tipo.DINER_PICHINCHA:
                       foreach (var item in lista)
                       {
                           secuenia++;
                           Grabar_fille(ValidarLineas_Pacifico(item), nombreArchivo, "", ref msg, secuenia);
                       }
                       break;
                   default:
                       break;
               }
               return true;
           }
           catch (Exception)
           {

               return false;
           }
       }




       #region  DINER CLUB
       public Visa_Diners_Club_Info ValidarLineas_Pacifico(ba_Archivo_Transferencia_Det_Info info)
       {
           try
           {
               Visa_Diners_Club_Info Diner_Info = new Visa_Diners_Club_Info();

               string aux="";
               // cabecera
               Diner_Info.TipodeRegistro_Cab = "1";
               Diner_Info.CodigodeComercio_Cab = "00000000";
               Diner_Info.FechadeTransmision_Cab = info.Fecha.Year.ToString().Substring(2,2) + info.Fecha.Month.ToString().PadLeft(2, '0') + info.Fecha.Day.ToString().PadLeft(2, '0');
               Diner_Info.Numero_Lote_Recap_Cab = "555555555555555";
               Diner_Info.NombredeConvenio_Cab = "ALEMAN    ";
               Diner_Info.Filler_Cab = aux.PadLeft(356,' ');
               // Detalle ***************************************************************************************************
               Diner_Info.TipodeRegistro = "2";
               Diner_Info.NumerodeTarjeta = info.Numero_Documento.PadRight(19,' ');
               Diner_Info.CodigodeTransaccion = "003000";
               Diner_Info.FechaTransaccion = info.Fecha.Year.ToString().Substring(2, 2) + info.Fecha.Month.ToString().PadLeft(2, '0') + info.Fecha.Day.ToString().PadLeft(2, '0');
               Diner_Info.HoraTransaccion = DateTime.Now.Hour.ToString()+DateTime.Now.Minute.ToString()+DateTime.Now.Second.ToString();
               Diner_Info.NumerodeVale =  "000001234567890";
               Diner_Info.CodigodeAprobacion = "813127";

                decimal valor = Convert.ToDecimal(info.vt_total);
                Diner_Info.MontoTotalTransaccion = string.Format("{0:0.00}", valor);
                Diner_Info.MontoTotalTransaccion = Diner_Info.MontoTotalTransaccion.ToString().Replace(".", "");
                Diner_Info.Authorizationsourcecode    = "1";
                Diner_Info.NumerodeCuotas = "00";
                Diner_Info.TipodeLectura = "051";
                Diner_Info.TipodeMoneda = "840";

                decimal iva = Convert.ToDecimal(info.vt_iva_valor);
                Diner_Info.ValorIVA = string.Format("{0:0.00}", iva);
                Diner_Info.MontoTotalTransaccion = Diner_Info.ValorIVA.ToString().Replace(".", "");
                Diner_Info.Valorservicio = "0000000000000";
                Diner_Info.Valorpropina = "0000000000000";
                Diner_Info.Valorinteres = "0000000000000";
                Diner_Info.Valor1 = "0000000000000";
                Diner_Info.CodigoPromocion = "00";

                Diner_Info.PuntosPromocion = "000";
                Diner_Info.ValorICE = "0000000000000";
                Diner_Info.ValorOtrosimpuestos = "0000000000000";
                Diner_Info.Valor2 = "00";
                Diner_Info.Filler = aux.PadLeft(11,' ');
                Diner_Info.Fecha_Vencimiento = info.Fecha.Year.ToString().Substring(2, 2) + info.Fecha.Month.ToString().PadLeft(2, '0') + info.Fecha.Day.ToString().PadLeft(2, '0');
                Diner_Info.Capital12 = "00000000000000";
                Diner_Info.Capital0 = "00000000000000";


                Diner_Info.Tipoderegistro_Tot = "3";
                Diner_Info.Codigodecomercio_Tot = "7890100";
                Diner_Info.Fechadetransmicion_tot = info.Fecha.Year.ToString().Substring(2, 2) + info.Fecha.Month.ToString().PadLeft(2, '0') + info.Fecha.Day.ToString().PadLeft(2, '0');
                Diner_Info.NumerodeLote = "7890100";
                Diner_Info.Numeroderegistros_Tot = "0000000";
                Diner_Info.Filler_Tot = aux.PadLeft(168, ' ');


               return Diner_Info;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ValidarLineaSAT", ex.Message), ex) { EntityType = typeof(Visa_Diners_Club_Bus) };

           }
       }
       public Boolean Grabar_fille(Visa_Diners_Club_Info info, string nombreArchivo, string carSeparador, ref string msg, int secuencia)
       {
           try
           {


               string linea = "";

               if (secuencia == 1)
               {
                   linea += info.TipodeRegistro_Cab + carSeparador;
                   linea += info.CodigodeComercio_Cab + carSeparador;
                   linea += info.FechadeTransmision_Cab + carSeparador;
                   linea += info.Numero_Lote_Recap_Cab + carSeparador;
                   linea += info.NombredeConvenio_Cab + carSeparador;
                   linea += info.Filler_Cab + carSeparador;
                   using (System.IO.StreamWriter file = new System.IO.StreamWriter(nombreArchivo , true))
                   {
                       file.WriteLine(linea);
                       file.Close();
                   }

                   linea = "";
                   linea += info.TipodeRegistro + carSeparador;
                   linea += info.NumerodeTarjeta + carSeparador;
                   linea += info.CodigodeTransaccion + carSeparador;
                   linea += info.FechaTransaccion + carSeparador;
                   linea += info.HoraTransaccion + carSeparador;
                   linea += info.NumerodeVale + carSeparador;
                   linea += info.CodigodeAprobacion + carSeparador;
                   linea += info.MontoTotalTransaccion + carSeparador;
                   linea += info.Authorizationsourcecode + carSeparador;
                   linea += info.TipodeCredito + carSeparador;
                   linea += info.NumerodeCuotas + carSeparador;
                   linea += info.TipodeLectura + carSeparador;
                   linea += info.TipodeMoneda + carSeparador;
                   linea += info.ValorIVA + carSeparador;
                   linea += info.Valorservicio + carSeparador;
                   linea += info.Valorpropina + carSeparador;
                   linea += info.Valorinteres + carSeparador;
                   linea += info.Valor1 + carSeparador;
                   linea += info.Filler + carSeparador;
                   linea += info.CodigoPromocion + carSeparador;
                   linea += info.PuntosPromocion + carSeparador;
                   linea += info.Valor2 + carSeparador;
                   linea += info.ValorICE + carSeparador;
                   linea += info.ValorOtrosimpuestos + carSeparador;
                   linea += info.Valor + carSeparador;
                   linea += info.Filler + carSeparador;
                   linea += info.Capital12 + carSeparador;
                   linea += info.Capital0 + carSeparador;
                   linea += info.Fecha_Vencimiento + carSeparador;

                   using (System.IO.StreamWriter file = new System.IO.StreamWriter(nombreArchivo + "prueba.txt", true))
                   {
                       file.WriteLine(linea);
                       file.Close();
                   }


               }
               else
               {
                   linea += info.TipodeRegistro + carSeparador;
                   linea += info.NumerodeTarjeta + carSeparador;
                   linea += info.CodigodeTransaccion + carSeparador;
                   linea += info.FechaTransaccion + carSeparador;
                   linea += info.HoraTransaccion + carSeparador;
                   linea += info.NumerodeVale + carSeparador;
                   linea += info.CodigodeAprobacion + carSeparador;
                   linea += info.MontoTotalTransaccion + carSeparador;
                   linea += info.Authorizationsourcecode + carSeparador;
                   linea += info.TipodeCredito + carSeparador;
                   linea += info.NumerodeCuotas + carSeparador;
                   linea += info.TipodeLectura + carSeparador;
                   linea += info.TipodeMoneda + carSeparador;
                   linea += info.ValorIVA + carSeparador;
                   linea += info.Valorservicio + carSeparador;
                   linea += info.Valorpropina + carSeparador;
                   linea += info.Valorinteres + carSeparador;
                   linea += info.Valor1 + carSeparador;
                   linea += info.Filler + carSeparador;
                   linea += info.CodigoPromocion + carSeparador;
                   linea += info.PuntosPromocion + carSeparador;
                   linea += info.Valor2 + carSeparador;
                   linea += info.ValorICE + carSeparador;
                   linea += info.ValorOtrosimpuestos + carSeparador;
                   linea += info.Valor + carSeparador;
                   linea += info.Filler + carSeparador;
                   linea += info.Capital12 + carSeparador;
                   linea += info.Capital0 + carSeparador;
                   linea += info.Fecha_Vencimiento + carSeparador;
                   /*
                   linea += info.Tipoderegistro_Tot + carSeparador;
                   linea += info.Fechadetransmicion_tot + carSeparador;
                   linea += info.NumerodeLote + carSeparador;
                   linea += info.Numeroderegistros_Tot + carSeparador;
                   linea += info.Filler_Tot + carSeparador;
                   */

                   using (System.IO.StreamWriter file = new System.IO.StreamWriter(nombreArchivo , true))
                   {
                       file.WriteLine(linea);
                       file.Close();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Bus oDataLog = new tb_sis_Log_Error_Vzen_Bus();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }


       #endregion


    }
}
