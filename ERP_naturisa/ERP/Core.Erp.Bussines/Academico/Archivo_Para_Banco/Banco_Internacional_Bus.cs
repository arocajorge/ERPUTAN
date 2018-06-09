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
   
public class Banco_Internacional_Bus
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
                 
                    case ebanco_procesos_bancarios_tipo.BANCO_INTERNACIONAL:
                        foreach (var item in lista)
                        {
                            sec++;

                            Grabar_fille(ValidarLineas_Pacifico(item,Num_cuenta,sec), nombreArchivo, "\t", ref msg);
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
        public Banco_Internacional_Info ValidarLineas_Pacifico(ba_Archivo_Transferencia_Det_Info info, string Num_Cuentaempresa, int Secuencia)
        {
            try
            {
                Banco_Internacional_Info Diner_Info = new Banco_Internacional_Info();

                string aux = "";
                decimal valor = 0;
                // cabecera
                Diner_Info.codigodeorientacion = "CO";
                Diner_Info.cuentadelaempresa = Num_Cuentaempresa.PadLeft(20,'0');
                Diner_Info.secuencial = Secuencia.ToString().PadLeft(7, '0');
                Diner_Info.comprobantedecobro = info.pe_cedulaRuc.PadLeft(20,'0');
                Diner_Info.contrapartida = info.IdRubro_Col.ToString().PadLeft(20, '0');
                Diner_Info.moneda = "USD";
                 valor = Convert.ToDecimal(info.vt_total);
                Diner_Info.valor = string.Format("{0:0.00}", valor);
                Diner_Info.valor = Diner_Info.valor.ToString().Replace(".", "");
                Diner_Info.formadecobro ="CTA";
                Diner_Info.codigodebanco = "32";
                Diner_Info.tipodecuenta = "AHO";
                Diner_Info.numerodecuenta = info.Numero_Documento.PadLeft(20, '0');
                if (info.IdTipoDocumento == "CED")
                {
                    Diner_Info.tipoidcliente = "C";
                }
                else
                {
                    if (info.IdTipoDocumento == "RUC")
                    {
                        Diner_Info.tipoidcliente = "R";
                    }
                    else
                        Diner_Info.tipoidcliente = "P";

                }
                Diner_Info.numerodeidcliente = info.pe_cedulaRuc.PadLeft(14, '0');
                if(info.pe_nombreCompleto.Length>40)
                Diner_Info.nombredeldeudor = info.pe_nombreCompleto.Substring(0,40);
                else
                Diner_Info.nombredeldeudor = info.pe_nombreCompleto.PadRight(40,' ');
                Diner_Info.referencia = info.observacion_det.PadRight(200, ' ');
                Diner_Info.referencia = Diner_Info.referencia.Replace("\n", " ");



                valor = Convert.ToDecimal(info.vt_total);
                Diner_Info.baeimponiblebienes = string.Format("{0:0.00}", valor);
                Diner_Info.baeimponiblebienes = Diner_Info.baeimponiblebienes.ToString().Replace(".", "");


                valor = Convert.ToDecimal(info.vt_iva_valor);
                Diner_Info.ivabienes = string.Format("{0:0.00}", valor);
                Diner_Info.ivabienes = Diner_Info.ivabienes.ToString().Replace(".", "");


                valor = Convert.ToDecimal(info.vt_total);
                Diner_Info.baseimponibleservicios = string.Format("{0:0.00}", valor);
                Diner_Info.baseimponibleservicios = Diner_Info.baseimponibleservicios.ToString().Replace(".", "");



                valor = Convert.ToDecimal(info.vt_iva_valor);
                Diner_Info.ivaservicios = string.Format("{0:0.00}", valor);
                Diner_Info.ivaservicios = Diner_Info.ivaservicios.ToString().Replace(".", "");

                return Diner_Info;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ValidarLineaSAT", ex.Message), ex) { EntityType = typeof(Visa_Diners_Club_Bus) };

            }
        }
        public Boolean Grabar_fille(Banco_Internacional_Info info, string nombreArchivo, string carSeparador, ref string msg)
        {
            try
            {


                string linea = "";

                linea += info.codigodeorientacion + carSeparador;
                linea += info.cuentadelaempresa + carSeparador;
                linea += info.secuencial + carSeparador;
                linea += info.comprobantedecobro + carSeparador;
                linea += info.contrapartida + carSeparador;
                linea += info.moneda + carSeparador;
                linea += info.valor + carSeparador;
                linea += info.formadecobro + carSeparador;
                linea += info.codigodebanco + carSeparador;
                linea += info.tipodecuenta + carSeparador;
                linea += info.numerodecuenta + carSeparador;
                linea += info.tipoidcliente + carSeparador;
                linea += info.numerodeidcliente + carSeparador;
                linea += info.nombredeldeudor + carSeparador;
                linea += info.referencia + carSeparador;
                linea += info.baeimponiblebienes + carSeparador;
                linea += info.ivabienes + carSeparador;
                linea += info.baseimponibleservicios + carSeparador;
                linea += info.ivaservicios + carSeparador;
                


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
