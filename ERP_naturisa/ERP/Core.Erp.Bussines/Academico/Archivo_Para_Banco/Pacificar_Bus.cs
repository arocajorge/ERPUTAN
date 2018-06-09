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
using System.Globalization;


namespace Core.Erp.Business.Academico.Archivo_Para_Banco
{
   public class Pacificar_Bus
   {
       string mensaje = "";


       ba_Archivo_Transferencia_Det_Info Info_pacifico = new ba_Archivo_Transferencia_Det_Info();
       public bool Grabar(List<ba_Archivo_Transferencia_Det_Info> lista, string nombreArchivo, ebanco_procesos_bancarios_tipo codigo_proceso, string Num_cuenta)
       {
           try
           {
               int sec = 0;
               string msg = "";
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
                   
                   case ebanco_procesos_bancarios_tipo.PACIFICAR:
                       foreach (var item in lista)
                       {
                           sec++;

                           //Grabar_fille(ValidarLineas_Pacifico(item, Num_cuenta, sec), nombreArchivo, "\t", ref msg);
                           Grabar_fille(ValidarLineas_Pacifico(item, Num_cuenta, sec), nombreArchivo, "\t", ref msg);

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




       #region  GENERACION DE ARCHIVO DE COBRO PARA EL BANCO INTERNACIONAL
       public Pacificar_Info ValidarLineas_Pacifico(ba_Archivo_Transferencia_Det_Info info, string Num_Cuentaempresa, int Secuencia)
       {
           try
           {
               Pacificar_Info Diner_Info = new Pacificar_Info();
               string p = "";
               DateTime dtPeriodo;
               string sPeriodo="";
               string nombreMesPeriodo = "";
               decimal valor = 0;
               DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
               

               // cabecera
               //Diner_Info.Identificacionclientes = info.pe_cedulaRuc.PadRight(19,' ' );
               Diner_Info.Identificacionclientes = info.codigo_unico_estudiante.PadLeft(19, '0');
               //Diner_Info.NumerodeTarjeta = Num_Cuentaempresa.PadLeft(19, '0');
               Diner_Info.NumerodeTarjeta = info.Numero_Documento.PadLeft(19, '0');
               Diner_Info.CdigodeMoneda = "02";

               valor = Convert.ToDecimal(info.vt_Subtotal);
               //Diner_Info.Valorconsumotarifa12 = string.Format("{0:0.00}", valor);
               //Diner_Info.Valorconsumotarifa12 = Diner_Info.Valorconsumotarifa12.ToString().Replace(".", "");
               Diner_Info.Valorconsumotarifa12 = "0".PadLeft(11,'0');

               Diner_Info.ValorIVA = "0".PadLeft(11,'0');

               //Diner_Info.CodigoRazontransacción = "COB";
               Diner_Info.CodigoRazontransacción = "001";
               //info.IdPeriodo;
               //info.IdGrupoFE;
               //Diner_Info.Conceptoestadodecuenta = info.observacion_det.ToString().PadLeft(20, '0').Trim();
               //sPeriodo = info.IdPeriodo_Per + "01";
               sPeriodo = info.IdPeriodo_Per.ToString().Substring(4, 2);
               nombreMesPeriodo = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(formatoFecha.GetMonthName(Convert.ToInt16(sPeriodo)));


               Diner_Info.Conceptoestadodecuenta = "CAH: " + nombreMesPeriodo.PadRight(10,' ') + info.concepto_estado_cuenta.PadRight(17,' ') + "0010****";

               //Diner_Info.FechaTransaccion = Convert.ToString(DateTime.Now).Substring(0, 10);
               Diner_Info.FechaTransaccion = DateTime.Now.ToString("yyyymmdd");

               Diner_Info.Numerosecuencialregistro = Secuencia.ToString().PadLeft(4,'0');
               Diner_Info.FechaVenceTarjeta = info.Fecha.ToString().Substring(0, 10);
               Diner_Info.FechaVenceTarjeta = info.Fecha.ToString("yyyymmdd");


               valor = Convert.ToDecimal(info.vt_Subtotal);
               Diner_Info.Valorconsumotarifa0 = string.Format("{0:0.00}", valor).PadLeft(11, '0');
               Diner_Info.ValorICE = "0".PadLeft(11,'0');
               Diner_Info.Filler = "0".PadLeft(11, '0');

               //Diner_Info.ValorIVA = string.Format("{0:0.00}", valor);
               //Diner_Info.ValorIVA = Diner_Info.ValorIVA.ToString().Replace(".", "");
               //info.vt_total = 0;
               //valor = Convert.ToDecimal(info.vt_total);
               //Diner_Info.Valorconsumotarifa0 = string.Format("{0:0.00}", valor);
               //Diner_Info.Valorconsumotarifa0 = Diner_Info.Valorconsumotarifa0.ToString().Replace(".", "");

               //valor = Convert.ToDecimal(info.vt_iva_valor);
               //Diner_Info.ValorIVA = string.Format("{0:0.00}", valor);
               //Diner_Info.ValorIVA = Diner_Info.ValorIVA.ToString().Replace(".", "");

               return Diner_Info;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ValidarLineaSAT", ex.Message), ex) { EntityType = typeof(Visa_Diners_Club_Bus) };

           }
       }
       public Boolean Grabar_fille(Pacificar_Info info, string nombreArchivo, string carSeparador, ref string msg)
       {
           try
           {


               string linea = "";

               //linea += info.Identificacionclientes + carSeparador;
               linea += info.Identificacionclientes;
               //linea += info.NumerodeTarjeta + carSeparador;
               linea += info.NumerodeTarjeta;
               //linea += info.CdigodeMoneda + carSeparador;
               linea += info.CdigodeMoneda;
               //linea += info.Valorconsumotarifa12 + carSeparador;
               linea += info.Valorconsumotarifa12;
               //linea += info.ValorIVA + carSeparador;
               linea += info.ValorIVA;
               //linea += info.CodigoRazontransacción + carSeparador;
               linea += info.CodigoRazontransacción;

               //linea += info.Conceptoestadodecuenta + carSeparador;
               linea += info.Conceptoestadodecuenta;

               //linea += info.Numerosecuenciaregistro + carSeparador;
               linea += info.Numerosecuenciaregistro;
               //linea += info.FechaVenceTarjeta + carSeparador;
               linea += info.FechaVenceTarjeta;
               //linea += info.consumotarifa + carSeparador;
               linea += info.consumotarifa;
               //linea += info.ValorICE + carSeparador;
               linea += info.ValorICE;
               //linea += info.Filler + carSeparador;
               linea += info.Filler;
               

               using (System.IO.StreamWriter file = new System.IO.StreamWriter(nombreArchivo, true))
               {
                   file.WriteLine(linea);
                   file.Close();
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
