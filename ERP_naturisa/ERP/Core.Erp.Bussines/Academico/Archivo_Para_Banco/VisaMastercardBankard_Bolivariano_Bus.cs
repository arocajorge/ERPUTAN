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
   public class VisaMastercardBankard_Bolivariano_Bus
    {
       string mensaje="";
       ba_Archivo_Transferencia_Det_Info Info_pacifico = new ba_Archivo_Transferencia_Det_Info();
       public bool Grabar(List<ba_Archivo_Transferencia_Det_Info> lista, string nombreArchivo, ebanco_procesos_bancarios_tipo codigo_proceso)
       {
           try
           {
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
                   
                   case ebanco_procesos_bancarios_tipo.MASTERCARD_BOLIVARIANO:
                       foreach (var item in lista)
                       {

                           Grabar_fille(ValidarLineas_Pacifico(item), nombreArchivo, "", ref msg);
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



       #region  MASTERCARD BANCARD DEL PACIFICO
       public VisaMastercardBankard_Bolivariano_Info ValidarLineas_Pacifico(ba_Archivo_Transferencia_Det_Info info)
       {
           try
           {
               VisaMastercardBankard_Bolivariano_Info Pacificar_info = new VisaMastercardBankard_Bolivariano_Info();

               Pacificar_info.Tarjeta = info.Numero_Documento.PadLeft(16,'0');
               Pacificar_info.Comercio = "00000000";
               Pacificar_info.FechadeConsumo = info.Fecha.Year.ToString() + info.Fecha.Month.ToString().PadLeft(2, '0') + info.Fecha.Day.ToString().PadLeft(2, '0');

               decimal valor = Convert.ToDecimal(info.vt_total);
               Pacificar_info.ValorConsumo = string.Format("{0:0.00}", valor);
               Pacificar_info.ValorConsumo = Pacificar_info.ValorConsumo.ToString().Replace(".", "");
               Pacificar_info.ValorConsumo = Pacificar_info.ValorConsumo.PadLeft(19, '0');
               Pacificar_info.ICE = "000000000000000";
               Pacificar_info.TipoConsumo = "001";
               Pacificar_info.NumerodeAutorizacion = "111111";
               Pacificar_info.NumeroMesesDiferido = "01";
               Pacificar_info.NumeroPagare = "5555555555";
               Pacificar_info.Filler = "000000";
               Pacificar_info.FechaExpiracion = info.Fecha.Year.ToString() + info.Fecha.Month.ToString().PadLeft(2, '0') + info.Fecha.Day.ToString().PadLeft(2, '0');
               Pacificar_info.Iva = "00000000000000000";
               Pacificar_info.TipodeDiferido = "01";
               Pacificar_info.Moneda = "D";
               Pacificar_info.Filer = "0000";
               Pacificar_info.MontoGravaIva = "0000000000000";
               Pacificar_info.MontoNoGravaIVA =  "0000000000000";



               return Pacificar_info;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ValidarLineaSAT", ex.Message), ex) { EntityType = typeof(VisaMastercardBankard_Bolivariano_Bus) };

           }
       }
       public Boolean Grabar_fille(VisaMastercardBankard_Bolivariano_Info info, string nombreArchivo, string carSeparador, ref string msg)
       {
           try
           {


               string linea = "";
               linea += info.Tarjeta + carSeparador;
               linea += info.Comercio + carSeparador;
               linea += info.FechadeConsumo + carSeparador;
               linea += info.ValorConsumo + carSeparador;
               linea += info.ICE + carSeparador;
               linea += info.NumerodeAutorizacion + carSeparador;
               linea += info.NumeroMesesDiferido + carSeparador;
               linea += info.NumeroPagare + carSeparador;
               linea += info.Filler + carSeparador;
               linea += info.FechaExpiracion + carSeparador;
               linea += info.Iva + carSeparador;
               linea += info.TipodeDiferido + carSeparador;
               linea += info.Moneda + carSeparador;
               linea += info.MontoGravaIva + carSeparador;
               linea += info.MontoNoGravaIVA + carSeparador;


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
