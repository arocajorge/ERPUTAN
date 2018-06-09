using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar.Archivos_Pagos_Bancos;
using Core.Erp.Info.General;
using Core.Erp.Info.Bancos;
namespace Core.Erp.Business.CuentasxPagar.Archivos_Bancos
{
   public class cp_Archivo_Banco_Pichincha_Pago_Bus
    {
       public string pu_RellenarCaracter(string cadena, string caracter, int num, string lado)
       {
           try
           {
               string valorDevolver = "";
               string subCadena = "";
               int contCadena = 0;
               contCadena = cadena.Count();

               if (num > contCadena)
               {
                   num = num - contCadena;

                   for (int i = 0; i < num; i++)
                   {
                       subCadena += caracter;
                   }

                   if (lado == "I")
                   {
                       valorDevolver = subCadena + cadena;
                   }
                   else
                   {
                       if (lado == "D")
                       {
                           valorDevolver = cadena + subCadena;
                       }
                   }



               }
               else
               {
                   valorDevolver = cadena;
               }

               return valorDevolver;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_RellenarCaracter", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Pichincha_Pago_Bus) };

           }

       }


       // GENERACION DE ARCHIVOS PARA  TRANSFERENCIA Y PAGOS A PROVEEDORES (BANCO PICHINCHA) 
        public bool Validar_Linea_archivo_BP(Archivo_Banco_Pichincha_Pago_Info info_)
        {

            try
            {
                info_.codigoOrientacion = info_.codigoOrientacion.Trim();
                info_.contraPartida = info_.contraPartida.Trim();
                info_.moneda = info_.moneda;
                info_.valor = info_.valor;

                info_.formaCobroPago = info_.formaCobroPago;
                info_.tipoCuenta = info_.tipoCuenta;
                if (info_.tipoCuenta == "COR")
                    info_.tipoCuenta = "CTE";
                info_.numeroCuenta = info_.numeroCuenta;

                info_.referencia = info_.referencia;
                info_.tipoIdCliente = info_.tipoIdCliente;

                info_.numeroIdCliente = info_.numeroIdCliente;
                info_.nombreCliente = info_.nombreCliente;
                info_.pagoCodigoBanco = info_.pagoCodigoBanco;


                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Pichincha_Pago_Bus) };
            }
        }
        public Boolean Generar_archivo_BP(Archivo_Banco_Pichincha_Pago_Info info, string patch,string nombre_File, string carSeparador)
        {
            try
            {


                string linea = "";
                linea += info.codigoOrientacion + "\t";
                linea += info.contraPartida + "\t";
                linea += info.moneda + "\t";
                linea += info.valor.PadLeft(13,'0') + "\t";
                linea += info.formaCobroPago + "\t";
                linea += info.tipoCuenta + "\t";
                linea += info.numeroCuenta + "\t";
                linea += info.referencia + "\t";
                linea += info.tipoIdCliente + "\t";
                linea += info.numeroIdCliente + "\t";
                linea += info.nombreCliente + "\t";
                linea += info.pagoCodigoBanco.PadLeft(4,'0') ;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(patch+nombre_File+".txt", true))
                {
                    file.WriteLine(linea);
                    file.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Pichincha_Pago_Bus) };

            }
        }
        public Boolean Guardar_Archivo_Banco_Pichinca(Archivo_Banco_Pichincha_Pago_Info info,tb_banco_procesos_bancarios_x_empresa_Info info_proceso, string patch,string nombre_file, string carSeparador)
        {
            try
            {

                switch (info_proceso.cod_Proceso)
                {

                    case ebanco_procesos_bancarios_tipo.TRANSF_BANCARIA_BP:

                        if (Validar_Linea_archivo_BP(info))
                        {
                            Generar_archivo_BP(info, patch, nombre_file, carSeparador);
                        }
                        break;

                    case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BP:
                        if (Validar_Linea_archivo_BP(info))
                        {
                            Generar_archivo_BP(info, patch, nombre_file, carSeparador);
                        }
                        break;
                    default:
                        break;
                }
                return true;
            }

            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Pichincha_Pago_Bus) };

            }
        }
      
       
       



    }
}
