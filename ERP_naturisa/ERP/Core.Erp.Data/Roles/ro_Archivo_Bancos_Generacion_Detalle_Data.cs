
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Roles.Archivos_para_Bancos;
namespace Core.Erp.Data.Roles
{
    public class ro_Archivo_Bancos_Generacion_Detalle_Data
    {
        private string mensaje = "";

        public Boolean Generar_archivo_Banco_Bolivariano(ro_Banco_bolivariano_Info info, string nombreArchivo, string carSeparador, ref string msg)
        {
            try {
               

                string linea = "";
                linea += info.tipoRegistro + carSeparador;
                linea += info.numSecuencial + carSeparador;
                linea += info.codBeneficiario + carSeparador;
                linea += info.tipoIdentificacion + carSeparador;
                linea += info.numIdentificacion + carSeparador;
                linea += info.nombreBeneficiario + carSeparador;
                linea += info.formaPago + carSeparador;
                linea += info.codPais + carSeparador;
                linea += info.codBanco + carSeparador;
                linea += info.tipoCuenta + carSeparador;
                linea += info.numCuenta + carSeparador;
                linea += info.codMoneda + carSeparador;
                linea += info.valorPago + carSeparador;
                linea += info.concepto + carSeparador;
                linea += info.numComprobante + carSeparador;
                linea += info.numComprobanteRetencion + carSeparador;
                linea += info.numComprobanteIVA + carSeparador;
                linea += info.numComprobanteFacturaSRI + carSeparador;
                linea += info.codGrupo + carSeparador;
                linea += info.descripcionGrupo + carSeparador;
                linea += info.direccionBeneficiario + carSeparador;
                linea += info.telefono + carSeparador;
                linea += info.codServicio + carSeparador;
                linea += info.cedula1 + carSeparador;
                linea += info.cedula2 + carSeparador;
                linea += info.cedula3 + carSeparador;
                linea += info.controlHorarioAtencion + carSeparador;
                linea += info.codEmpresa + carSeparador;
                linea += info.nemonicoSubEmpresa + carSeparador;
                linea += info.subMotivoPagoCobro;
               // linea += "\n";  //FIN DE LINEA

                using (System.IO.StreamWriter file = new System.IO.StreamWriter( nombreArchivo, true))
                {
                    file.WriteLine(linea);                                
                    file.Close();
                }
   
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
       
        public Boolean Generar_archivo_Banco_Pacifico(ro_Banco_pacifico_Info info, string nombreArchivo, string carSeparador, ref string msg)
        {
            try
            {




                string linea = "";
                linea += info.Localidad + carSeparador;
                linea += info.Transacción + carSeparador;
                linea += info.Codigo_de_Servicio + carSeparador;
                linea += info.Tipo_de_Cuenta + carSeparador;
                linea += info.Numero_de_cuenta + carSeparador;
                linea += info.Valor + carSeparador;
                linea += info.Identificacion_del_Servicio + carSeparador;
                linea += info.Referencia_para_el_estado_de_cuenta + carSeparador;
                linea += info.Forma_de_pago + carSeparador;
                linea += info.Moneda_del_movimiento + carSeparador;
               

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
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
       
        public Boolean Generar_archivo_Rol_electronico_BG(List<ro_Archivo_Banco_Guayaquil_Pagos_Info> Lista, string nombre_File, string carSeparador)
        {
            try
            {
                int i = 0;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(nombre_File , true))
                {
                    foreach (var item in Lista)
                    {
                        string linea = "";
                        i++;
                        if (i == 1)
                        {
                            //item.Rol_Elect_Nombre=item.Rol_Elect_Nombre.Replace("CIA."," ");
                            linea += item.Rol_Elect_TipoRegistro;
                            linea += item.Rol_Elect_CodigoEmpresa;
                            linea += item.Rol_Elect_NumCtaEmpresa;
                            linea += item.Rol_Elect_Nombre;
                            linea += item.Rol_Elect_CobroServicio;
                            linea += item.Rol_Elect_Monto;
                            linea += item.Rol_Elect_Fecha_Envio;
                            linea += item.Rol_Elect_NumCreditos;

                        }
                        else
                        {
                            linea += item.Rol_Elect_TipoRegistro;
                            linea += item.Rol_Elect_CodigoEmpresa;
                            linea += item.Rol_Elect_CodigoEmpleado;
                            linea += item.Rol_Elect_Nombre+" ";
                            linea += item.Rol_Elect_CobroServicio;
                            linea += item.Rol_Elect_Filler;
                            linea += item.Rol_Elect_CodigoProceso;
                            linea += item.Rol_Elect_Monto;

                            linea += item.Rol_Elect_Motivo3;
                            linea += "        ";
                            linea += item.Rol_Elect_Email+"  ";
                            linea += item.Rol_Elect_Celular;


                        }
                        file.WriteLine(linea);
                    }
                    file.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Data) };

            }
        }
        public Boolean Generar_archivo_Multichast_BG(ro_Archivo_Banco_Guayaquil_Pagos_Info info, string nombre_File, string carSeparador)
        {
            try
            {


                string linea = "";
                info.Multi_nombreClienteBeneficiario = info.Multi_nombreClienteBeneficiario + "\t";
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
                linea += info.Multi_referenciaAdicional + carSeparador;




                using (System.IO.StreamWriter file = new System.IO.StreamWriter( nombre_File , true))
                {
                    file.WriteLine(linea);
                    file.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Data) };

            }
        }
        public Boolean Generar_archivo_NCR_OTROS_BCO(ro_Archivo_Banco_Guayaquil_Pagos_Info info, string nombre_File, string carSeparador)
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
                linea += info.NCR_CodigoBancoParaPagoInterbancario + carSeparador;
                linea += info.NCR_NumeroCuentaOtrosBancos + carSeparador;
                linea += info.NCR_NombreTitularCuentaOtrosBancos + carSeparador;
                linea += info.NCR_NuevoMotivo + carSeparador;
                linea += info.NCR_Email + carSeparador;
                linea += info.NCR_Celular + carSeparador;
                linea += info.NCR_BancoDestinopagointerbancario + carSeparador;
                linea += info.NCR_TipoIdentificaciónBeneficiario + carSeparador;
                linea += info.NCR_NúmeroIdentificacionBeneficiario + carSeparador;






                using (System.IO.StreamWriter file = new System.IO.StreamWriter(nombre_File + ".txt", true))
                {
                    file.WriteLine(linea);
                    file.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Data) };

            }
        }
        public Boolean Generar_archivo_NCR(ro_Archivo_Banco_Guayaquil_Pagos_Info info, string nombre_File, string carSeparador)
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
                //linea += info.NCR_CodigoBancoParaPagoInterbancario + carSeparador;
               // linea += info.NCR_NumeroCuentaOtrosBancos + carSeparador;
                linea += info.NCR_NombreTitularCuentaOtrosBancos + carSeparador;
                linea += info.NCR_NuevoMotivo + carSeparador;
                //linea += info.NCR_Email + carSeparador;
                //linea += info.NCR_Celular + carSeparador;
               // linea += info.NCR_BancoDestinopagointerbancario + carSeparador;
               // linea += info.NCR_TipoIdentificaciónBeneficiario + carSeparador;
               // linea += info.NCR_NúmeroIdentificacionBeneficiario + carSeparador;






                using (System.IO.StreamWriter file = new System.IO.StreamWriter(nombre_File , true))
                {
                    file.WriteLine(linea);
                    file.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Data) };

            }
        }
      

        public Boolean Generar_archivo_BP(ro_Archivo_Banco_Pichincha_Pago_Info info, string nombre_File, string carSeparador)
        {
            try
            {


                string linea = "";
                linea += info.codigoOrientacion + "\t";
                linea += info.contraPartida + "\t";
                linea += info.moneda + "\t";
                linea += info.valor + "\t";
                linea += info.formaCobroPago + "\t";
                linea += info.tipoCuenta + "\t";
                linea += info.numeroCuenta + "\t";
                linea += info.referencia + "\t";
                linea += info.tipoIdCliente + "\t";
                linea += info.numeroIdCliente + "\t";
                linea += info.nombreCliente + "\t";
                linea += info.pagoCodigoBanco;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter( nombre_File , true))
                {
                    file.WriteLine(linea.Trim());
                    file.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Data) };

            }
        }



    }
}
