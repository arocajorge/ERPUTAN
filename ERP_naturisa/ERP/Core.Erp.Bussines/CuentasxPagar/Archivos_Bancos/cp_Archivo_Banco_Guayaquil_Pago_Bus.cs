using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar.Archivos_Pagos_Bancos;
using System.Collections;
using System.Collections.Generic;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
namespace Core.Erp.Business.CuentasxPagar.Archivos_Bancos
{
  public  class cp_Archivo_Banco_Guayaquil_Pago_Bus
    {

        // generacion de archivo para pagos a proveedores y trasnferencia al mismo banco (BANCO DE GUAYAQUIL)
        // FORMATO DE ARCHIVO MULTICAST
        public bool Validar_Linea_archivo_Multichast_BG(Archivo_Banco_Guayaquil_Pagos_Info info_)
        {

            try
            {
                info_.Multi_nombreClienteBeneficiario = info_.Multi_nombreClienteBeneficiario.Trim();


                info_.Multi_codigoOrientación = info_.Multi_codigoOrientación + "\t";
                info_.Multi_cuentaEmpresa = info_.Multi_cuentaEmpresa.PadLeft(10,'0') + "\t";
                info_.Multi_secuencialPago = info_.Multi_secuencialPago + "\t";
                info_.Multi_comprobantedePago = info_.Multi_comprobantedePago + "\t";
                info_.Multi_codigo = info_.Multi_codigo + "\t";
                info_.Multi_moneda = info_.Multi_moneda + "\t";
                info_.valor = info_.valor.ToString().PadLeft(13, '0') + "\t";
                info_.Multi_formaPago = info_.Multi_formaPago + "\t";
                if (info_.Multi_codigoDeInstitucionFinanciera == null)
                    info_.Multi_codigoDeInstitucionFinanciera = "17";
                info_.Multi_codigoDeInstitucionFinanciera = info_.Multi_codigoDeInstitucionFinanciera.ToString().PadLeft(4, '0') + "\t";
                if (info_.Multi_tipoCuenta == "COR")
                    info_.Multi_tipoCuenta = "CTE" + "\t";
                else
                info_.Multi_tipoCuenta = info_.Multi_tipoCuenta + "\t";
                info_.Multi_numeroDeCuenta = info_.Multi_numeroDeCuenta + "\t";
                info_.Multi_tipoIdClienteBeneficiario = info_.Multi_tipoIdClienteBeneficiario + "\t";
                info_.Multi_numeroIdClienteBeneficiario = info_.Multi_numeroIdClienteBeneficiario + "\t";
                info_.Multi_nombreClienteBeneficiario = info_.Multi_nombreClienteBeneficiario + "\t";
                info_.Multi_direccionBeneficiario = info_.Multi_direccionBeneficiario + "\t";
                info_.Multi_ciudadBeneficiario = info_.Multi_ciudadBeneficiario + "\t";
                info_.Multi_telefonoBeneficiario = info_.Multi_telefonoBeneficiario + "\t";
                info_.Multi_localidadPago = info_.Multi_localidadPago + "\t";
                info_.Multi_referencia = info_.Multi_referencia ;
                info_.Multi_referenciaAdicional = info_.Multi_referenciaAdicional;




                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Pichincha_Pago_Bus) };
            }
        }
        public Boolean Generar_archivo_Multichast_BG(Archivo_Banco_Guayaquil_Pagos_Info info, string patch, string nombre_File, string carSeparador)
        {
            try
            {


                string linea = "";
              
                linea += info.Multi_codigoOrientación + carSeparador;
                linea += info.Multi_cuentaEmpresa + carSeparador;
                linea += info.Multi_secuencialPago + carSeparador;
                linea += info.Multi_comprobantedePago + carSeparador;
                linea += info.Multi_codigo + carSeparador;
                linea += info.Multi_moneda + carSeparador;
                linea += info.valor + carSeparador;
                linea += info.Multi_formaPago + carSeparador;
                linea += info.Multi_codigoDeInstitucionFinanciera + carSeparador;
                linea += info.Multi_tipoCuenta + carSeparador;
                linea += info.Multi_numeroDeCuenta + carSeparador;
                linea += info.Multi_tipoIdClienteBeneficiario + carSeparador;
                linea += info.Multi_numeroIdClienteBeneficiario + carSeparador;
                linea += info.Multi_nombreClienteBeneficiario + carSeparador;
                linea += info.Multi_direccionBeneficiario + carSeparador;
                linea += info.Multi_ciudadBeneficiario + carSeparador;
                linea += info.Multi_telefonoBeneficiario + carSeparador;
                linea += info.Multi_localidadPago + carSeparador;
                linea += info.Multi_referencia + carSeparador;




                using (System.IO.StreamWriter file = new System.IO.StreamWriter(patch + nombre_File + ".txt", true))
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
        public Boolean Guardar_Archivo_BG(Archivo_Banco_Guayaquil_Pagos_Info info,tb_banco_procesos_bancarios_x_empresa_Info proceso_info , string patch, string nombre_file, string carSeparador)
        {
            try
            {
                switch (proceso_info.cod_Proceso)
                {
                    case ebanco_procesos_bancarios_tipo.PAGOS_MULTICASH:
                        if (Validar_Linea_archivo_Multichast_BG(info))
                        {
                            Generar_archivo_Multichast_BG(info, patch, nombre_file, carSeparador);

                        }

                        break;

                    case ebanco_procesos_bancarios_tipo.NCR:
                        if (Validar_Linea_archivo_NCR_BG(info))
                        {
                            Generar_archivo_NCR_BG(info, patch, nombre_file, carSeparador);

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


        // GENERACION DE ARCHIVOS PARA TRANSFERENCIA Y PAGOS A TROS BANCOS (BANCO GUAYAQUIL)
        // FORMATO DE ARCHIVO NCR
        public Boolean Generar_archivo_NCR_BG(Archivo_Banco_Guayaquil_Pagos_Info info, string patch, string nombre_File, string carSeparador)
        {
            try
            {


                string linea = "";
                linea += info.NCR_TiposdeCuenta + carSeparador;
                linea += info.NCR_NumerodeCuentaBancoGuayaquil + carSeparador;
                linea += info.valor + carSeparador;
                linea += info.NCR_Motivo + carSeparador;
                linea += info.NCR_TipoNota + carSeparador;
                linea += info.NCR_Agencia + carSeparador;
                linea += "                    ";
               // linea += info.NCR_CodigoBancoParaPagoInterbancario + carSeparador;
               // linea += info.NCR_NumeroCuentaOtrosBancos + carSeparador;
                linea += info.NCR_NombreTitularCuentaOtrosBancos + carSeparador;
                linea += info.NCR_NuevoMotivo + carSeparador;
               // linea += info.NCR_Email + carSeparador;
               // linea += info.NCR_Celular + carSeparador;
               // linea += info.NCR_BancoDestinopagointerbancario + carSeparador;
               // linea += info.NCR_TipoIdentificaciónBeneficiario + carSeparador;
                //linea += info.NCR_NúmeroIdentificacionBeneficiario + carSeparador;






                using (System.IO.StreamWriter file = new System.IO.StreamWriter(patch + nombre_File + ".txt", true))
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
        public bool Validar_Linea_archivo_NCR_BG(Archivo_Banco_Guayaquil_Pagos_Info info_)
        {

            try
            {

                info_.NCR_TiposdeCuenta = info_.NCR_TiposdeCuenta;
                info_.NCR_NumerodeCuentaBancoGuayaquil = info_.NCR_NumerodeCuentaBancoGuayaquil.PadLeft(10, '0');
                info_.valor = info_.valor.PadLeft(15, '0');
                info_.NCR_Motivo = "XX";
                info_.NCR_TipoNota = "Y";
                info_.NCR_Agencia = "01";
                info_.NCR_CodigoBancoParaPagoInterbancario = "XX";
                info_.NCR_NumeroCuentaOtrosBancos = info_.NCR_NumeroCuentaOtrosBancos.PadLeft(18, '0');
                info_.NCR_NombreTitularCuentaOtrosBancos = info_.NCR_NombreTitularCuentaOtrosBancos.Trim();
                if (info_.NCR_NombreTitularCuentaOtrosBancos.Length > 18)
                {

                    info_.NCR_NombreTitularCuentaOtrosBancos = info_.NCR_NombreTitularCuentaOtrosBancos.Substring(0, 17);
                }
                else
                {
                    info_.NCR_NombreTitularCuentaOtrosBancos = info_.NCR_NombreTitularCuentaOtrosBancos.PadRight(18, ' ');

                }
                info_.NCR_NuevoMotivo = info_.NCR_NuevoMotivo;
                if (info_.NCR_Email.Length > 30)
                {
                    info_.NCR_Email = info_.NCR_Email.Substring(0, 29);
                }
                else
                {
                    info_.NCR_Email = info_.NCR_Email.PadRight(30, ' ');
                }

                info_.NCR_Celular = "";
                if (info_.NCR_CodigoBancoParaPagoInterbancario == "17")
                {
                    info_.NCR_BancoDestinopagointerbancario = info_.NCR_CodigoBancoParaPagoInterbancario.PadLeft(3, '0');
                }
                else
                {
                    info_.NCR_BancoDestinopagointerbancario = "";
                }
                //info_.NCR_TipoIdentificaciónBeneficiario = info_.NCR_TipoIdentificaciónBeneficiario;
               // info_.NCR_NúmeroIdentificacionBeneficiario = info_.NCR_NúmeroIdentificacionBeneficiario;



                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Pichincha_Pago_Bus) };
            }
        }


        // GENERACION DE ARCHIVO ROL_ELECTRONICO PARA TRANSFERENCIA A CUENTAS VIRTUALES DEL BANCO DE GUAYAQUIL
        // FORMATO DE ARCHIVO ROL
        public Boolean Generar_archivo_Rol_electronico_BG(List< Archivo_Banco_Guayaquil_Pagos_Info> Lista, string patch, string nombre_File, string carSeparador)
        {
            try
            {
                int i = 0;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(patch + nombre_File + ".txt", true))
                {
                    foreach (var item in Lista)
                    {
                        string linea = "";
                        i++;
                        if (i == 1)
                        {
                            linea += item.Rol_Elect_TipoRegistro;
                            linea += item.Rol_Elect_CodigoEmpresa;
                            linea += item.Rol_Elect_NumCtaEmpresa;
                            linea += item.Rol_Elect_Nombre;
                            linea += item.Rol_Elect_CobroServicio;
                            linea += item.Rol_Elect_Monto;
                            linea += item.Rol_Elect_Fecha_Envio;
                            linea += item.Rol_Elect_NumCreditos;
                            linea.Trim();
                        }
                        else
                        {
                            item.Rol_Elect_Email=item.Rol_Elect_Email.PadRight(30, ' ');
                            linea += item.Rol_Elect_TipoRegistro;
                            linea += item.Rol_Elect_CodigoEmpresa;
                            linea += item.Rol_Elect_CodigoEmpleado;
                            linea += item.Rol_Elect_Nombre;
                            linea += "C";
                            linea += item.Rol_Elect_Filler;
                            linea += item.Rol_Elect_CodigoProceso;
                            linea += item.Rol_Elect_Monto;
                            linea += item.Rol_Elect_Filler2;
                            linea += item.Rol_Elect_Email;
                            linea += item.Rol_Elect_Celular;
                        }
                        file.WriteLine(linea.Trim());
                    }
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
        public bool Validar_Linea_archivo_Rol_electronico_BG(List<Archivo_Banco_Guayaquil_Pagos_Info> Lista)
        {

            try
            {
                int i = 0;
                foreach (var item in Lista)
                {
                    i++;
                    if (i == 1)
                    {
                         item.Rol_Elect_TipoRegistro="C";
                         item.Rol_Elect_CodigoEmpresa=item.Rol_Elect_CodigoEmpresa.PadLeft(2,' ');
                         item.Rol_Elect_NumCtaEmpresa = item.Rol_Elect_NumCtaEmpresa.PadLeft(10, '0');
                        if(item.Rol_Elect_Nombre.Length>38)
                        {
                         item.Rol_Elect_Nombre=item.Rol_Elect_Nombre.Substring(0,38);
                        }
                        else
                        {
                            item.Rol_Elect_Nombre=item.Rol_Elect_Nombre.PadRight(38,' ');

                        }
                         item.Rol_Elect_CobroServicio="C";
                         item.Rol_Elect_Monto=  item.Rol_Elect_Monto.PadLeft(15,'0'); 
                         item.Rol_Elect_Fecha_Envio=item.Rol_Elect_Fecha_Envio;
                        item.Rol_Elect_NumCreditos=item.Rol_Elect_NumCreditos.PadLeft(5,'0');
                    }
                    else
                    {
                         item.Rol_Elect_TipoRegistro="D";
                         item.Rol_Elect_CodigoEmpresa=item.Rol_Elect_CodigoEmpresa;
                         item.Rol_Elect_CodigoEmpleado=item.Rol_Elect_CodigoEmpleado.PadLeft(10,'0');
                         if(item.Rol_Elect_Nombre.Length>17)
                        {
                         item.Rol_Elect_Nombre=item.Rol_Elect_Nombre.Substring(0,17);
                        }
                        else
                        {
                            item.Rol_Elect_Nombre = item.Rol_Elect_Nombre.PadRight(17, ' ').ToUpper();

                        }
                         
                        // item.Rol_Elect_CobroServicio="C";
                         item.Rol_Elect_Filler = item.Rol_Elect_Filler = "";
                         item.Rol_Elect_Filler2 = item.Rol_Elect_Filler2 = "";
                         item.Rol_Elect_Filler=item.Rol_Elect_Filler.PadLeft(20,' ');
                         item.Rol_Elect_CodigoProceso="N";
                         item.Rol_Elect_Monto = item.Rol_Elect_Monto.PadLeft(15, '0');
                         item.Rol_Elect_Filler2 = item.Rol_Elect_Filler2.PadLeft(13, ' ');

                         if (item.Rol_Elect_Email != null)
                         {
                             item.Rol_Elect_Email = item.Rol_Elect_Email;
                         }
                         else
                         {
                             item.Rol_Elect_Email = "";

                         }
                         item.Rol_Elect_Celular = item.Rol_Elect_Celular.PadLeft(10, '0');

                    }
                }



                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Pichincha_Pago_Bus) };
            }
        }
        public Boolean Guardar_Archivo_BG(List<Archivo_Banco_Guayaquil_Pagos_Info> Lista, tb_banco_procesos_bancarios_x_empresa_Info proceso_info, string patch, string nombre_file, string carSeparador)
        {
            try
            {

                switch (proceso_info.cod_Proceso)
                {
                    case ebanco_procesos_bancarios_tipo.ROL_ELECTRONICO_BG:

                        if (Validar_Linea_archivo_Rol_electronico_BG(Lista))
                        {
                            Generar_archivo_Rol_electronico_BG(Lista, patch, nombre_file, carSeparador);

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
