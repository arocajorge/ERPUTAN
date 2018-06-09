using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles.Archivos_para_Bancos;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Roles
{
    public class ro_Archivo_Bancos_Generacion_Detalle_Bus
    {


        
            tb_Empresa_Info Cbt = new tb_Empresa_Info();
            tb_Empresa_Bus empresaData = new tb_Empresa_Bus();
            tb_Calendario_Bus bus_calendario = new General.tb_Calendario_Bus();
            tb_Calendario_Info info_calendario = new Info.General.tb_Calendario_Info();
        ro_Archivo_Bancos_Generacion_Detalle_Data oData = new ro_Archivo_Bancos_Generacion_Detalle_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ro_Banco_bolivariano_Info Info_bolivariano = new ro_Banco_bolivariano_Info();
        ro_Banco_pacifico_Info Info_pacifico = new ro_Banco_pacifico_Info();
        List<ro_Archivo_Banco_Guayaquil_Pagos_Info> lista_rol_electronico = new List<ro_Archivo_Banco_Guayaquil_Pagos_Info>();

       
        public string pu_RellenarCaracter(string cadena, string caracter, int num, string lado="L")
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

                    if(lado=="L")
                    {
                        valorDevolver = subCadena + cadena;
                    }
                    else
                    {
                        if(lado=="R")
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_RellenarCaracter", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Bus) };

            }

        }
        #region GENARAR ARCHIVO PLANO SEGUN EL BANCO Y TIPOS DE PROCESO (PROCESO POR BANCOS)
        public Boolean GrabarBD(List<ro_Rol_Detalle_Info> lista, ba_Banco_Cuenta_Info Banco, tb_banco_procesos_bancarios_x_empresa_Info Info_proceso, string nombreArchivo, string carSeparador, string codigo_empresa, ref string msg)
        {
            try
            {
                lista = lista.OrderByDescending(v => v.pe_apellido).ToList();
                
                switch (Banco.CodigoLegal)
                {
                    case "34":  //BANCO BOLIVARIANO

                        switch (Info_proceso.cod_Proceso)
	                        {
                                case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BOL:
                                    foreach (var item in Get_Bolivariano(lista, codigo_empresa))
                                    {
                                        if (ValidarLineas_Bolivariano(item))
                                            oData.Generar_archivo_Banco_Bolivariano(item, nombreArchivo, carSeparador, ref msg);

                                    }
                                break;
                         
                            default:
                                break;
	                    }
                       
                        break;
                    case "30"://BANCO DEL PACIFICO
                        switch (Info_proceso.cod_Proceso)
	                            {
                                case ebanco_procesos_bancarios_tipo.PAGO_BANCO_PACIFICO_BPA:
                                        foreach (var item in Get_pacifico(lista))
                                        {
                                            if (ValidarLineas_Pacifico(item))
                                                oData.Generar_archivo_Banco_Pacifico(item, nombreArchivo, carSeparador, ref msg);
                                        }
                                    break;
                                default:
                                    break;
	                        }
                        break;
                    case "17"://BANCO DE GUAYAQUIL
                        switch (Info_proceso.cod_Proceso)
                        {
                            case  ebanco_procesos_bancarios_tipo.ROL_ELECTRONICO_BG://"ROL_ELECTRONICO_BG":                               
                                if (Validar_Linea_archivo_Rol_electronico_BG(Get_Rol_electronico_BG(lista, Banco.ba_Num_Cuenta, Info_proceso)))
                                        oData.Generar_archivo_Rol_electronico_BG(lista_rol_electronico, nombreArchivo, carSeparador);
                                
                                break;
                            case ebanco_procesos_bancarios_tipo.PAGOS_MULTICASH://"PAGO_VENTANILLA_BG":
                                foreach (var item in Get_Multicas_BG(lista,Banco))
                                {
                                    if (Validar_Linea_archivo_Multichast_BG(item))
                                        oData.Generar_archivo_Multichast_BG(item, nombreArchivo, carSeparador);
                                }
                                break;

                            case  ebanco_procesos_bancarios_tipo.NCR://"TRANSF_CTA_OTROS_BANCO_BG":
                                foreach (var item in Get_NCR(lista, Banco, Info_proceso.Codigo_Empresa))
                                {
                                    if (Validar_Linea_archivo_NCR(item))
                                        oData.Generar_archivo_NCR(item, nombreArchivo, carSeparador);
                                }
                                break;

                            case ebanco_procesos_bancarios_tipo.NCR_OTROS_BCO://"TRANSF_CTA_OTROS_BANCO_BG":
                                foreach (var item in Get_NCR_OTROS_BCO(lista, Banco, Info_proceso.Codigo_Empresa))
                                {
                                    if (Validar_Linea_archivo_NCR_OTROS_BCO(item))
                                        oData.Generar_archivo_NCR_OTROS_BCO(item, nombreArchivo, carSeparador);
                                }
                                break;

                            
                            default:
                                break;
                        }

                        break;
                    case "10"://BANCO DEL PICHINCHA
                        switch (Info_proceso.cod_Proceso)
	                        {
                            case ebanco_procesos_bancarios_tipo.TRANSF_BANCARIA_BP://"TRANSF_BANCARIA_BP":
                                    foreach (var item in Get_Banco_Pichincha(lista, Banco.ba_Num_Cuenta))
                                    {
                                        if (Validar_Linea_archivo_BP(item))
                                            oData.Generar_archivo_BP(item, nombreArchivo, carSeparador);
                                    }
                               break;
                                default:
                                    break;
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Bus) };

            }
        }
        #endregion


        #region VALIDACIONES PARA EL FORMATO DEL ARCHIVO SEGUN EL BANCO


        // VALIDAR BANCO BOLIVARIANO
        public Boolean ValidarLineas_Bolivariano(ro_Banco_bolivariano_Info info)
        {
            try
            {
                Info_bolivariano = info;

                Info_bolivariano.numSecuencial = pu_RellenarCaracter(info.numSecuencial, "0", 6);
                Info_bolivariano.codBeneficiario = pu_RellenarCaracter(info.codBeneficiario, "0", 18);

                //TIPO DE IDENTIFICACION
                if (Info_bolivariano.tipoIdentificacion == "CED" | Info_bolivariano.tipoIdentificacion == "RUC")
                {
                    Info_bolivariano.tipoIdentificacion = "C";
                }
                else
                {
                    if (Info_bolivariano.tipoIdentificacion == "PAS")
                    {
                        Info_bolivariano.tipoIdentificacion = "P";
                    }
                }

                Info_bolivariano.numIdentificacion = pu_RellenarCaracter(info.numIdentificacion, " ", 14, "R");
                Info_bolivariano.nombreBeneficiario = pu_RellenarCaracter(info.nombreBeneficiario, " ", 60, "R");

                //VALIDAR FORMA DE PAGO
                string tipoCuenta = Info_bolivariano.tipoCuenta;

                if (Info_bolivariano.codBanco == "14")
                {
                    Info_bolivariano.codBanco = "34";
                }

                if (Info_bolivariano.codBanco == "34")//CORRESPONDE AL BOLIVARIANO
                {
                    if (tipoCuenta == "AHO" | tipoCuenta == "COR")
                    {
                        Info_bolivariano.formaPago = "CUE";//CREDITO A CUENTA

                        if (tipoCuenta == "COR")
                        {
                            Info_bolivariano.tipoCuenta = "03"; //CUENTA CORRIENTE
                        }
                        else
                        {
                            if (tipoCuenta == "AHO")
                            {
                                Info_bolivariano.tipoCuenta = "04"; //CUENTA DE AHORROS
                            }
                        }

                    }
                    else
                    {
                        if (tipoCuenta == "VRT")
                        {
                            Info_bolivariano.formaPago = "EFE";//CREDITO A CUENTA
                            Info_bolivariano.tipoCuenta = "  "; //TARJETA DE PAGO
                            // _Info.numCuenta = pu_RellenarCaracter(pu_RellenarCaracter(info.numCuenta, "0", 10), " ", 20, "R");
                            Info_bolivariano.numCuenta = "                    ";
                            Info_bolivariano.codBanco = "  ";

                        }
                    }
                }
                else
                {
                    Info_bolivariano.formaPago = "COB";  //CREDITO EN OTROS BANCOS
                    Info_bolivariano.tipoCuenta = "00";
                }

                Info_bolivariano.codPais = "001";      //CODIGO DEL PAIS
                if (tipoCuenta == "AHO" || tipoCuenta == "COR")
                {
                    Info_bolivariano.numCuenta = pu_RellenarCaracter(pu_RellenarCaracter(info.numCuenta, "0", 10), " ", 20, "R");
                }
                Info_bolivariano.codMoneda = "1";

                //VALOR TOTAL DE PAGO : LONG.15 CAR.
                //13 ENTEROS Y 2 DECIMALES

                double valor = Convert.ToDouble(Info_bolivariano.valorPago);
                double valorEntero = Math.Floor(valor);
                double valorDecimal = Convert.ToDouble((valor - valorEntero).ToString("N2")) * 100;

                Info_bolivariano.valorPago = pu_RellenarCaracter(valorEntero.ToString(), "0", 13) + pu_RellenarCaracter(valorDecimal.ToString(), "0", 2);

                Info_bolivariano.concepto = pu_RellenarCaracter(Info_bolivariano.concepto, " ", 60, "R");
                Info_bolivariano.numComprobante = pu_RellenarCaracter(Info_bolivariano.numComprobante, "0", 15);
                Info_bolivariano.numComprobanteRetencion = pu_RellenarCaracter(Info_bolivariano.numComprobanteRetencion, "0", 15);
                Info_bolivariano.numComprobanteIVA = pu_RellenarCaracter(Info_bolivariano.numComprobanteIVA, "0", 15);
                Info_bolivariano.numComprobanteFacturaSRI = pu_RellenarCaracter(Info_bolivariano.numComprobanteFacturaSRI, "0", 20);
                Info_bolivariano.codGrupo = pu_RellenarCaracter(Info_bolivariano.codGrupo, " ", 10);
                Info_bolivariano.descripcionGrupo = pu_RellenarCaracter(Info_bolivariano.descripcionGrupo, " ", 50);
                Info_bolivariano.direccionBeneficiario = pu_RellenarCaracter(Info_bolivariano.direccionBeneficiario, " ", 50);
                Info_bolivariano.telefono = pu_RellenarCaracter(Info_bolivariano.telefono, " ", 20);
                Info_bolivariano.codServicio = "RPA";
                Info_bolivariano.cedula1 = pu_RellenarCaracter(Info_bolivariano.cedula1, " ", 10);
                Info_bolivariano.cedula2 = pu_RellenarCaracter(Info_bolivariano.cedula2, " ", 10);
                Info_bolivariano.cedula3 = pu_RellenarCaracter(Info_bolivariano.cedula3, " ", 10);
                Info_bolivariano.controlHorarioAtencion = pu_RellenarCaracter(Info_bolivariano.controlHorarioAtencion, " ", 1);
                Info_bolivariano.codEmpresa = pu_RellenarCaracter(Info_bolivariano.codEmpresa, "0", 5);
                Info_bolivariano.nemonicoSubEmpresa = pu_RellenarCaracter(Info_bolivariano.nemonicoSubEmpresa, " ", 6);
                Info_bolivariano.subMotivoPagoCobro = pu_RellenarCaracter(Info_bolivariano.subMotivoPagoCobro, " ", 3);

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ValidarLineaSAT", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Bus) };

            }
        }


        // VALIDAR BANCO PACIFICO
        public Boolean ValidarLineas_Pacifico(ro_Banco_pacifico_Info info)
        {
            try
            {
                Info_pacifico = info;
                if (info.Tipo_de_Cuenta == "COR")
                {
                    Info_pacifico.Tipo_de_Cuenta = "00";
                }
                if (info.Tipo_de_Cuenta == "AHO")
                {
                    Info_pacifico.Tipo_de_Cuenta = "10";
                }
                if (info.Tipo_de_Cuenta != "AHO" && info.Tipo_de_Cuenta == "COR")
                {
                    Info_pacifico.Tipo_de_Cuenta = "  ";
                }


                Info_pacifico.Numero_de_cuenta = info.Numero_de_cuenta.ToString().PadLeft(8, '0');
                if (Info_pacifico.Numero_de_cuenta.Length > 8)
                    Info_pacifico.Numero_de_cuenta = Info_pacifico.Numero_de_cuenta.Substring(0, 8);
                Info_pacifico.Valor = info.Valor.ToString().PadLeft(15, '0');
                Info_pacifico.Identificacion_del_Servicio = info.Identificacion_del_Servicio.Substring(0, 15);
                Info_pacifico.Referencia_para_el_estado_de_cuenta = info.Referencia_para_el_estado_de_cuenta.ToString().PadLeft(20, ' ');



                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_ValidarLineaSAT", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Bus) };

            }
        }


        // VALIDAR ARCHIVO BANCO GUAYAQUIL DE PAGO MULTICASH
        public bool Validar_Linea_archivo_Multichast_BG(ro_Archivo_Banco_Guayaquil_Pagos_Info info_)
        {

            try
            {
                info_.Multi_nombreClienteBeneficiario = info_.Multi_nombreClienteBeneficiario.Trim();


                info_.Multi_codigoOrientación = info_.Multi_codigoOrientación + "\t";
                info_.Multi_cuentaEmpresa = info_.Multi_cuentaEmpresa.PadLeft(10, '0') + "\t";
                info_.Multi_secuencialPago = info_.Multi_secuencialPago + "\t";
                info_.Multi_comprobantedePago = info_.Multi_comprobantedePago + "\t";
                info_.Multi_codigo = info_.Multi_codigo + "\t";
                info_.Multi_moneda = info_.Multi_moneda + "\t";
                info_.valor = info_.valor.ToString().PadLeft(13, '0') + "\t";
                info_.Multi_formaPago = info_.Multi_formaPago + "\t";
                info_.Multi_codigoDeInstitucionFinanciera = info_.Multi_codigoDeInstitucionFinanciera.ToString().PadLeft(4, '0') + "\t"+"\t";
                info_.Multi_tipoCuenta = info_.Multi_tipoCuenta + "\t";
                if(info_.Multi_numeroDeCuenta!=null)
                info_.Multi_numeroDeCuenta = info_.Multi_numeroDeCuenta.PadLeft(10,'0') + "\t";
                info_.Multi_tipoIdClienteBeneficiario = info_.Multi_tipoIdClienteBeneficiario + "\t";
                info_.Multi_numeroIdClienteBeneficiario = info_.Multi_numeroIdClienteBeneficiario + "\t";
                if (info_.Multi_nombreClienteBeneficiario.Length > 16)
                {
                    info_.Multi_nombreClienteBeneficiario = info_.Multi_nombreClienteBeneficiario.Substring(0, 16) + "\t";
                }
                info_.Multi_direccionBeneficiario = info_.Multi_direccionBeneficiario + "\t";
                info_.Multi_ciudadBeneficiario = info_.Multi_ciudadBeneficiario + "\t";
                info_.Multi_telefonoBeneficiario = info_.Multi_telefonoBeneficiario + "\t";
                info_.Multi_localidadPago = info_.Multi_localidadPago + "\t";
                info_.Multi_referencia = info_.Multi_referencia + "\t";
                info_.Multi_referenciaAdicional = info_.Multi_referenciaAdicional;




                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Bus) };
            }
        }


        // VALIDAR ARCHIVO BANCO GUAYAQUIL DE PAGO NCR AL MISMO BANCO
        public bool Validar_Linea_archivo_NCR_OTROS_BCO(ro_Archivo_Banco_Guayaquil_Pagos_Info info_)
        {

            try
            {

                info_.NCR_TiposdeCuenta = info_.NCR_TiposdeCuenta;
                info_.NCR_NumerodeCuentaBancoGuayaquil = info_.NCR_NumerodeCuentaBancoGuayaquil.PadLeft(10, '0');
                info_.valor = info_.valor.PadLeft(15, '0');
                info_.NCR_Motivo = "XX";
                info_.NCR_TipoNota = "Y";
                info_.NCR_Agencia = "01";
                info_.NCR_CodigoBancoParaPagoInterbancario = "  ";
                info_.NCR_NumeroCuentaOtrosBancos = "";
                info_.NCR_NumeroCuentaOtrosBancos = info_.NCR_NumeroCuentaOtrosBancos.PadLeft(18, ' ');
                info_.NCR_NombreTitularCuentaOtrosBancos = info_.NCR_NombreTitularCuentaOtrosBancos.Trim();
                if (info_.NCR_NombreTitularCuentaOtrosBancos.Length > 18)
                {

                    info_.NCR_NombreTitularCuentaOtrosBancos = info_.NCR_NombreTitularCuentaOtrosBancos.Substring(0, 17);
                    info_.NCR_NombreTitularCuentaOtrosBancos = info_.NCR_NombreTitularCuentaOtrosBancos + " ";
                }
                else
                {
                    info_.NCR_NombreTitularCuentaOtrosBancos = info_.NCR_NombreTitularCuentaOtrosBancos.PadRight(18, ' ');

                }
                info_.NCR_NuevoMotivo = info_.NCR_NuevoMotivo;
                info_.NCR_Email = " ";
                info_.NCR_Celular = "";
                info_.NCR_BancoDestinopagointerbancario = " ";
              
                info_.NCR_TipoIdentificaciónBeneficiario ="";
                info_.NCR_NúmeroIdentificacionBeneficiario = "";



                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Bus) };
            }
        }

        // VALIDAR ARCHIVO BANCO GUAYAQUIL DE PAGO NCR AL OTROS BANCO

        public bool Validar_Linea_archivo_NCR(ro_Archivo_Banco_Guayaquil_Pagos_Info info_)
        {

            try
            {

                info_.NCR_TiposdeCuenta = info_.NCR_TiposdeCuenta;
                info_.NCR_NumerodeCuentaBancoGuayaquil = info_.NCR_NumeroCuentaOtrosBancos.PadLeft(10, '0');
                info_.valor = info_.valor.PadLeft(15, '0');
                info_.NCR_Motivo = "XX";
                info_.NCR_TipoNota = "Y";
                info_.NCR_Agencia = "01";
                info_.NCR_CodigoBancoParaPagoInterbancario = info_.NCR_CodigoBancoParaPagoInterbancario;
                info_.NCR_NumerodeCuentaBancoGuayaquil = info_.NCR_NumerodeCuentaBancoGuayaquil.PadLeft(10, '0');
                info_.NCR_NumeroCuentaOtrosBancos = info_.NCR_NumeroCuentaOtrosBancos.PadLeft(18, '0');
                info_.NCR_NombreTitularCuentaOtrosBancos = info_.NCR_NombreTitularCuentaOtrosBancos.Trim();
                if (info_.NCR_NombreTitularCuentaOtrosBancos.Length > 18)
                {

                    info_.NCR_NombreTitularCuentaOtrosBancos = info_.NCR_NombreTitularCuentaOtrosBancos.Substring(0, 16)+"  ";
                }
                else
                {
                    info_.NCR_NombreTitularCuentaOtrosBancos = info_.NCR_NombreTitularCuentaOtrosBancos.PadRight(18, ' ');

                }
                info_.NCR_NuevoMotivo = info_.NCR_NuevoMotivo;
                info_.NCR_Email = " ";
                info_.NCR_Celular = "";
                info_.NCR_BancoDestinopagointerbancario = " ";

                info_.NCR_TipoIdentificaciónBeneficiario = info_.NCR_TipoIdentificaciónBeneficiario;
                info_.NCR_NúmeroIdentificacionBeneficiario = info_.NCR_NúmeroIdentificacionBeneficiario;



                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Bus) };
            }
        }

        // VALIDAR ARCHIVO BANCO GUAYAQUIL DE PAGO ROL ELECTRONICO
        public bool Validar_Linea_archivo_Rol_electronico_BG(List<ro_Archivo_Banco_Guayaquil_Pagos_Info> Lista)
        {
            lista_rol_electronico = new List<ro_Archivo_Banco_Guayaquil_Pagos_Info>();
            try
            {
                int i = 0;
                foreach (var item in Lista)
                {
                    i++;
                    if (i == 1)
                    {
                        item.Rol_Elect_Nombre = item.Rol_Elect_Nombre.Trim();
                        item.Rol_Elect_Nombre = item.Rol_Elect_Nombre.Replace(" ","");

                        item.Rol_Elect_TipoRegistro = "C";
                        item.Rol_Elect_CodigoEmpresa = item.Rol_Elect_CodigoEmpresa.PadLeft(2, ' ');
                        item.Rol_Elect_NumCtaEmpresa = item.Rol_Elect_NumCtaEmpresa.PadLeft(10, '0');
                        if (item.Rol_Elect_Nombre.Length > 38)
                        {
                            item.Rol_Elect_Nombre = item.Rol_Elect_Nombre.Substring(0, 38);
                        }
                        else
                        {
                            item.Rol_Elect_Nombre = item.Rol_Elect_Nombre.PadRight(38, ' ');

                        }
                        item.Rol_Elect_CobroServicio = "C";
                        item.Rol_Elect_Monto = item.Rol_Elect_Monto.PadLeft(15, '0');
                        item.Rol_Elect_Fecha_Envio = item.Rol_Elect_Fecha_Envio;
                        item.Rol_Elect_NumCreditos = item.Rol_Elect_NumCreditos.PadLeft(5, '0');
                    }
                    else
                    {
                        item.Rol_Elect_TipoRegistro = "D";
                        item.Rol_Elect_CodigoEmpresa = item.Rol_Elect_CodigoEmpresa;
                        item.Rol_Elect_CodigoEmpleado = item.Rol_Elect_CodigoEmpleado.PadLeft(10, '0');
                        if (item.Rol_Elect_Nombre.Length > 17)
                        {
                            item.Rol_Elect_Nombre = item.Rol_Elect_Nombre.Substring(0, 16);
                        }
                        else
                        {
                            item.Rol_Elect_Nombre = item.Rol_Elect_Nombre.PadRight(17, ' ').ToUpper();

                        }

                        item.Rol_Elect_CobroServicio = "C";
                        item.Rol_Elect_Filler = item.Rol_Elect_Filler = "";
                        item.Rol_Elect_Filler = item.Rol_Elect_Filler2 = "";
                        item.Rol_Elect_Filler = item.Rol_Elect_Filler.PadLeft(20, ' ');
                        item.Rol_Elect_CodigoProceso = "N";
                        item.Rol_Elect_Monto = item.Rol_Elect_Monto.PadLeft(15, '0');
                        item.Rol_Elect_Motivo3 = item.Rol_Elect_Motivo3.PadLeft(3, ' ');
                        item.Rol_Elect_Motivo3 = item.Rol_Elect_Motivo3.PadLeft(3, ' ');
                        item.Rol_Elect_Filler2 = item.Rol_Elect_Filler2.PadLeft(10, ' ');

                        item.Rol_Elect_Email=param.em_Email.PadLeft(30, ' ');
                        item.Rol_Elect_Celular = item.Rol_Elect_Celular.PadLeft(10, '0');

                    }
                    lista_rol_electronico.Add(item);
                }



                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Bus) };
            }
        }


        // VALIDAR ARCHIVO BANCO PICHINCHA 

        public bool Validar_Linea_archivo_BP(ro_Archivo_Banco_Pichincha_Pago_Info info_)
        {

            try
            {
                if (info_.contraPartida == "0703018374")
                {
                }
                info_.codigoOrientacion = info_.codigoOrientacion.Trim();
                info_.contraPartida = info_.contraPartida.Trim();
                info_.moneda = info_.moneda;
                info_.valor = info_.valor;
                info_.formaCobroPago = info_.formaCobroPago;
                info_.tipoCuenta = info_.tipoCuenta;
                info_.numeroCuenta = info_.numeroCuenta;
                info_.referencia = info_.referencia;
                info_.tipoIdCliente = info_.tipoIdCliente;
                info_.numeroIdCliente = info_.numeroIdCliente;
                if(info_.nombreCliente.Length>16)
                info_.nombreCliente = info_.nombreCliente.Substring(0, 16);
                info_.pagoCodigoBanco = info_.pagoCodigoBanco;


                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Bus) };
            }
        }
     

        #endregion








        #region GET PARA ARCHIVO PLANO SEGUN EL BANCO Y TIPOS DE PROCESO (PROCESO POR BANCOS)

        // GENERAR ARCHIVO TXT PARA EL BANCO BOLIVARIANO
        public List<ro_Banco_bolivariano_Info> Get_Bolivariano(List<ro_Rol_Detalle_Info> lista, string Codig_empresa)
        {
            try
            {
                int secuencia = 0;
                List<ro_Banco_bolivariano_Info> lista_banco_bolivriano = new List<ro_Banco_bolivariano_Info>();
                foreach (var item in lista)
                {

                    ro_Banco_bolivariano_Info linea = new ro_Banco_bolivariano_Info();
                    //AQUI PREPARAR EL FOMATO DEL ARCHIVO
                    secuencia += 1;
                    linea.tipoRegistro = "BZDET";
                    linea.numSecuencial = secuencia.ToString();
                    linea.codBeneficiario = item.IdEmpleado.ToString();
                    linea.tipoIdentificacion = item.TipoIdentificacion.Trim();
                    linea.numIdentificacion = item.CedulaRuc.Trim();
                    item.NombreCompleto = item.NombreCompleto.ToUpper();
                    item.NombreCompleto = item.NombreCompleto.Replace("Ñ", "N");
                    item.NombreCompleto = item.NombreCompleto.Replace("Í", "I");
                    linea.nombreBeneficiario = item.NombreCompleto;
                    linea.codPais = "001";
                    linea.codBanco = item.IdBanco;      //REVISAR CON OTRA TABLA
                    linea.tipoCuenta = item.TipoCuenta.Trim();
                    linea.numCuenta = item.NumCuenta.Trim();
                    linea.codMoneda = "1";
                    linea.valorPago = item.Valor.ToString();
                    linea.concepto = " - R" + item.FechaIni.ToString("yyyyMMdd") + " - " + item.FechaFin.ToString("yyyyMMdd");
                    linea.numComprobante = "";
                    linea.numComprobanteRetencion = "";
                    linea.numComprobanteIVA = "";
                    linea.numComprobanteFacturaSRI = "";
                    linea.codGrupo = "";
                    linea.descripcionGrupo = "";
                    linea.direccionBeneficiario = "";
                    linea.telefono = "";
                    linea.codServicio = "";
                    linea.cedula1 = "";
                    linea.cedula2 = "";
                    linea.cedula3 = "";
                    linea.controlHorarioAtencion = "";
                    linea.codEmpresa = Codig_empresa;
                    linea.nemonicoSubEmpresa = "";
                    linea.subMotivoPagoCobro = "";
                    lista_banco_bolivriano.Add(linea);
                }

                return lista_banco_bolivriano;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Bus) };

            }
        }



        // GENERAR ARCHIVO TXT PARA EL BANCO PACIFICO
        public List<ro_Banco_pacifico_Info> Get_pacifico(List<ro_Rol_Detalle_Info> lista)
        {
            try
            {
                int secuencia = 0;
                List<ro_Banco_pacifico_Info> lista_banco_bolivriano = new List<ro_Banco_pacifico_Info>();
                foreach (var item in lista)
                {

                    ro_Banco_pacifico_Info linea = new ro_Banco_pacifico_Info();
                    secuencia += 1;
                    linea.Localidad = "1";
                    linea.Transacción = "OCP";
                    linea.Codigo_de_Servicio = "RP";

                    linea.Tipo_de_Cuenta = item.TipoCuenta;

                    linea.Numero_de_cuenta = item.NumCuenta.Trim();

                    double valor = Convert.ToDouble(item.Valor);
                    double valorEntero = Math.Floor(valor);
                    double valorDecimal = Convert.ToDouble((valor - valorEntero).ToString("N2")) * 100;



                    linea.Valor = pu_RellenarCaracter(valorEntero.ToString(), "0", 13) + pu_RellenarCaracter(valorDecimal.ToString(), "0", 2);
                    item.NombreCompleto = item.NombreCompleto.Replace("Ñ", "N");
                    item.NombreCompleto = item.NombreCompleto.Replace("Í", "I");
                    linea.Identificacion_del_Servicio = item.NombreCompleto;
                    linea.Referencia_para_el_estado_de_cuenta = "ORDEN DE PAGO";
                    linea.Forma_de_pago = "CU";      //REVISAR CON OTRA TABLA
                    linea.Moneda_del_movimiento = "USD";

                    lista_banco_bolivriano.Add(linea);
                }

                return lista_banco_bolivriano;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_Archivo_Bancos_Generacion_Detalle_Bus) };

            }
        }


        // ARCHIVOS BANCO GUAYAQUL FORMATO DE ARCHIVO MULTICHAS (TRANSFERENCIA AL MISMO BANCO)
        public List<ro_Archivo_Banco_Guayaquil_Pagos_Info> Get_Multicas_BG(List<ro_Rol_Detalle_Info> lista, ba_Banco_Cuenta_Info Banco)
        {
            try
            {
                string msg = "";
                int Secuencia = 0;

                List<ro_Archivo_Banco_Guayaquil_Pagos_Info> lista_ = new List<ro_Archivo_Banco_Guayaquil_Pagos_Info>();
                info_calendario = bus_calendario.Get_Info_Calendario(lista.FirstOrDefault().FechaIni);

                foreach (var item in lista)
                {

                    Secuencia = Secuencia + 1;

                    ro_Archivo_Banco_Guayaquil_Pagos_Info info_guayaquil = new ro_Archivo_Banco_Guayaquil_Pagos_Info();
                    info_guayaquil.Multi_codigoOrientación = "PA";
                    info_guayaquil.Multi_cuentaEmpresa = Banco.ba_Num_Cuenta;
                    info_guayaquil.Multi_secuencialPago = "1";
                    info_guayaquil.Multi_comprobantedePago = "";
                    if (item.TipoCuenta == "AHO" || item.TipoCuenta == "COR")
                    {
                        info_guayaquil.Multi_codigo = item.NumCuenta.PadLeft(10,'0');
                    }
                    else
                    {
                        info_guayaquil.Multi_codigo = item.CedulaRuc.PadLeft(10, '0'); ;
                    }
                    info_guayaquil.Multi_moneda = "USD";
                    decimal valor = Convert.ToDecimal(item.Valor);
                    info_guayaquil.valor = string.Format("{0:0.00}", valor);
                    info_guayaquil.valor = info_guayaquil.valor.ToString().Replace(".", "");
                    info_guayaquil.valor = info_guayaquil.valor.PadLeft(12, '0');
                    if (item.TipoCuenta != "CHE")
                    {


                        if (item.TipoCuenta == "EFE")
                        {
                            info_guayaquil.Multi_formaPago = "EFE";
                        }
                        else
                        {
                            info_guayaquil.Multi_formaPago = "CTA";
                            info_guayaquil.Multi_numeroDeCuenta = item.NumCuenta;
                            info_guayaquil.Multi_tipoCuenta = item.TipoCuenta;

                        }
                    }

                    else//PAGO EN CHEQUE
                    {

                    }


                    if (item.TipoCuenta == "EFE" || item.TipoCuenta == "CHQ")
                    {
                        info_guayaquil.Multi_codigoDeInstitucionFinanciera = item.CodigoLegal.PadLeft(4, '0');// item.CodigoLegal;
                    }
                    else
                    {
                        info_guayaquil.Multi_codigoDeInstitucionFinanciera = item.CodigoLegal.PadLeft(4,'0');// item.CodigoLegal;

                    }
                    if (item.TipoCuenta == "CTE " || item.TipoCuenta == "AHO")
                    {
                        info_guayaquil.Multi_tipoCuenta = item.TipoCuenta;
                    }
                    if (item.TipoCuenta == "CTE " || item.TipoCuenta == "AHO")
                    {
                        if (item.CodigoLegal == "17")
                        {

                            info_guayaquil.Multi_numeroDeCuenta = item.NumCuenta.ToString().PadLeft(4, '0');

                        }
                    }



                    if (item.TipoIdentificacion == "RUC")
                    {

                        info_guayaquil.Multi_tipoIdClienteBeneficiario = "R";
                    }
                    else
                    {
                        if (item.TipoIdentificacion == "CED")
                        {
                            info_guayaquil.Multi_tipoIdClienteBeneficiario = "C";
                        }
                        else
                            if (item.TipoIdentificacion == "PAS")
                            {
                                info_guayaquil.Multi_tipoIdClienteBeneficiario = "P";
                            }
                            else
                            {
                                info_guayaquil.Multi_tipoIdClienteBeneficiario = "N";
                            }
                    }
                    info_guayaquil.Multi_numeroIdClienteBeneficiario = item.CedulaRuc;
                    info_guayaquil.Multi_nombreClienteBeneficiario = item.NombreCompleto.Replace("Ñ", "N").ToUpper();
                    info_guayaquil.Multi_nombreClienteBeneficiario = info_guayaquil.Multi_nombreClienteBeneficiario.Substring(0, 16);
                    info_guayaquil.Multi_direccionBeneficiario = "";
                    info_guayaquil.Multi_ciudadBeneficiario = "";
                    info_guayaquil.Multi_telefonoBeneficiario = "";
                    info_guayaquil.Multi_localidadPago = "";
                    if (item.IdNominaTipoLiqui == 1)
                    {
                        info_guayaquil.Multi_referencia ="QUINCENA DE "+info_calendario.NombreMes.ToUpper();
                    }
                    else
                    {
                        info_guayaquil.Multi_referencia = "FIN DE " + info_calendario.NombreMes.ToUpper();

                    }
                    info_guayaquil.Multi_referenciaAdicional = "";





                    lista_.Add(info_guayaquil);

                }




                return lista_;

            }
            catch (Exception ex)
            {
                return new List<ro_Archivo_Banco_Guayaquil_Pagos_Info>();
            }



        }



        // ARCHIVOS BANCO DE GUAYAQUIL FORMATO NCR (TRANSFERENCIA OTROS BANCOS)
        public List<ro_Archivo_Banco_Guayaquil_Pagos_Info> Get_NCR(List<ro_Rol_Detalle_Info> lista, ba_Banco_Cuenta_Info Banco, string Codigo_banco)
        {
            try
            {
                int Secuencia = 0;

                List<ro_Archivo_Banco_Guayaquil_Pagos_Info> lista_ = new List<ro_Archivo_Banco_Guayaquil_Pagos_Info>();
                foreach (var item in lista)
                {
                    Secuencia = Secuencia + 1;
                    ro_Archivo_Banco_Guayaquil_Pagos_Info info_guayaquil = new ro_Archivo_Banco_Guayaquil_Pagos_Info();
                    if (item.TipoCuenta == "AHO")
                    {
                        info_guayaquil.NCR_TiposdeCuenta = "A";
                    }
                    else
                    {
                        if (item.TipoCuenta == "COR")
                        {
                            info_guayaquil.NCR_TiposdeCuenta = "C";

                        }
                    }

                    info_guayaquil.NCR_NumeroCuentaOtrosBancos =item.NumCuenta;
                    info_guayaquil.NCR_Motivo = "XX";
                    info_guayaquil.NCR_TipoNota = "Y";
                    info_guayaquil.NCR_Agencia = "01";
                    info_guayaquil.NCR_CodigoBancoParaPagoInterbancario = item.CodigoLegal;
                    info_guayaquil.NCR_NumeroCuentaOtrosBancos = item.NumCuenta;
                    info_guayaquil.NCR_NombreTitularCuentaOtrosBancos = item.NombreCompleto.ToUpper();
                    info_guayaquil.NCR_NuevoMotivo = Codigo_banco;
                    info_guayaquil.NCR_Email = "";
                    info_guayaquil.NCR_Celular = "";
                    info_guayaquil.NCR_BancoDestinopagointerbancario = "";//item.CodigoLegal;
                    decimal valor = Convert.ToDecimal(item.Valor);
                    info_guayaquil.valor = string.Format("{0:0.00}", valor);
                    info_guayaquil.valor = info_guayaquil.valor.ToString().Replace(".", "");
                    if (item.TipoIdentificacion == "RUC")
                    {

                        info_guayaquil.NCR_TipoIdentificaciónBeneficiario = "R";
                    }
                    else
                    {
                        if (item.TipoIdentificacion == "CED")
                        {
                            info_guayaquil.NCR_TipoIdentificaciónBeneficiario = "C";
                        }
                        else
                            if (item.TipoIdentificacion == "PAS")
                            {
                                info_guayaquil.NCR_TipoIdentificaciónBeneficiario = "P";
                            }
                            else
                            {
                                info_guayaquil.NCR_TipoIdentificaciónBeneficiario = "N";
                            }
                    }
                    info_guayaquil.NCR_NúmeroIdentificacionBeneficiario = item.CedulaRuc;




                    lista_.Add(info_guayaquil);

                }



                return lista_;


            }
            catch (Exception ex)
            {
                return new List<ro_Archivo_Banco_Guayaquil_Pagos_Info>(9);
            }



        }


        // ARCHIVOS BANCO DE GUAYAQUIL FORMATO NCR (TRANSFERENCIA MIMOS BANCOS)
        public List<ro_Archivo_Banco_Guayaquil_Pagos_Info> Get_NCR_OTROS_BCO(List<ro_Rol_Detalle_Info> lista, ba_Banco_Cuenta_Info Banco, String Codigo_Banco)
        {
            try
            {
                int Secuencia = 0;

                List<ro_Archivo_Banco_Guayaquil_Pagos_Info> lista_ = new List<ro_Archivo_Banco_Guayaquil_Pagos_Info>();
                foreach (var item in lista)
                {
                    Secuencia = Secuencia + 1;
                    ro_Archivo_Banco_Guayaquil_Pagos_Info info_guayaquil = new ro_Archivo_Banco_Guayaquil_Pagos_Info();
                    if (item.TipoCuenta == "AHO")
                    {
                        info_guayaquil.NCR_TiposdeCuenta = "A";
                    }
                    else
                    {
                        if (item.TipoCuenta == "COR")
                        {
                            info_guayaquil.NCR_TiposdeCuenta = "C";

                        }
                    }

                    info_guayaquil.NCR_NumerodeCuentaBancoGuayaquil = item.NumCuenta;
                    info_guayaquil.NCR_Motivo = "XX";
                    info_guayaquil.NCR_TipoNota = "Y";
                    info_guayaquil.NCR_Agencia = "01";
                    info_guayaquil.NCR_CodigoBancoParaPagoInterbancario = item.CodigoLegal;
                    info_guayaquil.NCR_NumeroCuentaOtrosBancos = item.NumCuenta;
                    info_guayaquil.NCR_NombreTitularCuentaOtrosBancos = item.NombreCompleto.ToUpper();
                    info_guayaquil.NCR_NuevoMotivo = Codigo_Banco;
                    info_guayaquil.NCR_Email = "";
                    info_guayaquil.NCR_Celular = "";
                    info_guayaquil.NCR_BancoDestinopagointerbancario = "";//item.CodigoLegal;
                    decimal valor = Convert.ToDecimal(item.Valor);
                    info_guayaquil.valor = string.Format("{0:0.00}", valor);
                    info_guayaquil.valor = info_guayaquil.valor.ToString().Replace(".", "");
                    if (item.TipoIdentificacion == "RUC")
                    {

                        info_guayaquil.NCR_TipoIdentificaciónBeneficiario = "R";
                    }
                    else
                    {
                        if (item.TipoIdentificacion == "CED")
                        {
                            info_guayaquil.NCR_TipoIdentificaciónBeneficiario = "C";
                        }
                        else
                            if (item.TipoIdentificacion == "PAS")
                            {
                                info_guayaquil.NCR_TipoIdentificaciónBeneficiario = "P";
                            }
                            else
                            {
                                info_guayaquil.NCR_TipoIdentificaciónBeneficiario = "N";
                            }
                    }
                    info_guayaquil.NCR_NúmeroIdentificacionBeneficiario = item.CedulaRuc;




                    lista_.Add(info_guayaquil);

                }



                return lista_;


            }
            catch (Exception ex)
            {
                return new List<ro_Archivo_Banco_Guayaquil_Pagos_Info>(9);
            }



        }






        // ARCHIVO PARA EL BANCO DE GUAYAQUIL FORMATO ROL ELECTRONICO (PAGOS A CUENTAS VIRTUALES)
        public List<ro_Archivo_Banco_Guayaquil_Pagos_Info> Get_Rol_electronico_BG(List<ro_Rol_Detalle_Info> lista,string Num_cuenta_empresa, tb_banco_procesos_bancarios_x_empresa_Info info_proceso)
        {
            List<ro_Archivo_Banco_Guayaquil_Pagos_Info> Lista_Banco_G = new List<ro_Archivo_Banco_Guayaquil_Pagos_Info>();
            Cbt = empresaData.Get_Info_Empresa(param.IdEmpresa);
            try
            {

                // crea la cabcerara del archivo 
                if (lista.ToList().Count > 0)
                {


                    ro_Archivo_Banco_Guayaquil_Pagos_Info info_guayaquil = new ro_Archivo_Banco_Guayaquil_Pagos_Info();
                    info_guayaquil.Rol_Elect_TipoRegistro = "C";
                    info_guayaquil.Rol_Elect_CodigoEmpresa = info_proceso.Codigo_Empresa;
                    info_guayaquil.Rol_Elect_NumCtaEmpresa = Num_cuenta_empresa;

                    Cbt.RazonSocial = Cbt.RazonSocial.Replace("S.A", "").PadRight(38, ' ');
                    Cbt.RazonSocial = Cbt.RazonSocial.Replace("CIA.", "").PadRight(38, ' ');
                    Cbt.RazonSocial = Cbt.RazonSocial.Replace("LTDA.", "").PadRight(38, ' ');

                    info_guayaquil.Rol_Elect_Nombre = Cbt.RazonSocial;

                    info_guayaquil.Rol_Elect_CobroServicio = "E";
                    decimal valor = Convert.ToDecimal(lista.Sum(v => v.Valor));
                    info_guayaquil.Rol_Elect_Monto = string.Format("{0:0.00}", valor);
                    info_guayaquil.Rol_Elect_Monto = info_guayaquil.Rol_Elect_Monto.ToString().Replace(".", "");
                    DateTime FechaEnvio = DateTime.Now;
                    info_guayaquil.Rol_Elect_Fecha_Envio = Convert.ToString(FechaEnvio.Year) + Convert.ToString(FechaEnvio.Month).PadLeft(2, '0') + Convert.ToString(FechaEnvio.Day).PadLeft(2, '0');
                    info_guayaquil.Rol_Elect_NumCreditos = Convert.ToString(lista.Count());
                    info_guayaquil.NCR_NuevoMotivo = "";
                    Lista_Banco_G.Add(info_guayaquil);
                }
                foreach (var item in lista)
                {
                    ro_Archivo_Banco_Guayaquil_Pagos_Info info_guayaquil = new ro_Archivo_Banco_Guayaquil_Pagos_Info();
                    info_guayaquil.Rol_Elect_TipoRegistro = "D";
                    info_guayaquil.Rol_Elect_CodigoEmpresa = info_proceso.Codigo_Empresa;
                    info_guayaquil.Rol_Elect_CodigoEmpleado = item.CedulaRuc;
                    info_guayaquil.Rol_Elect_NumCtaEmpresa = "";// Banco_Info.ba_Num_Cuenta;
                    info_guayaquil.Rol_Elect_Nombre = item.NombreCompleto.Replace("Ñ", "N").ToUpper();
                    info_guayaquil.Rol_Elect_CobroServicio = "C";
                    decimal valor = Convert.ToDecimal(lista.Sum(v => v.Valor));
                    info_guayaquil.Rol_Elect_Monto = string.Format("{0:0.00}", item.Valor);
                    info_guayaquil.Rol_Elect_Monto = info_guayaquil.Rol_Elect_Monto.ToString().Replace(".", "");
                    DateTime FechaEnvio = DateTime.Now;
                    info_guayaquil.Rol_Elect_Fecha_Envio = Convert.ToString(FechaEnvio.Year) + Convert.ToString(FechaEnvio.Month).PadLeft(2, '0') + Convert.ToString(FechaEnvio.Day).PadLeft(2, '0');
                    info_guayaquil.Rol_Elect_NumCreditos = Convert.ToString(lista.Count());

                    info_guayaquil.Rol_Elect_Motivo3 = "";
                    info_guayaquil.Rol_Elect_Filler = "";
                    info_guayaquil.Rol_Elect_Email = "";
                    info_guayaquil.Rol_Elect_Celular = "";

                    info_guayaquil.Rol_Elect_Motivo3 = info_guayaquil.Rol_Elect_Motivo3.PadLeft(3,' ');
                    info_guayaquil.Rol_Elect_Filler = info_guayaquil.Rol_Elect_Filler.PadLeft(10, ' ');
                    info_guayaquil.Rol_Elect_Email = info_guayaquil.Rol_Elect_Email.PadLeft(30, ' ');
                    info_guayaquil.Rol_Elect_Celular = info_guayaquil.Rol_Elect_Celular.PadLeft(10, '0'); 
                    if (item.CedulaRuc.Length == 10)
                    {
                        Lista_Banco_G.Add(info_guayaquil);
                    }
                }

                return Lista_Banco_G;

            }
            catch (Exception ex)
            {
                return new List<ro_Archivo_Banco_Guayaquil_Pagos_Info>();
            }



        }


        // ARCHIVO PARA EL BANCO DE PICHINCHA 
        public List<ro_Archivo_Banco_Pichincha_Pago_Info> Get_Banco_Pichincha(List<ro_Rol_Detalle_Info> lista, string Num_cuenta_empresa)
        {
            List<ro_Archivo_Banco_Pichincha_Pago_Info> Lista_Banco_G = new List<ro_Archivo_Banco_Pichincha_Pago_Info>();
            Cbt = empresaData.Get_Info_Empresa(param.IdEmpresa);
            info_calendario = bus_calendario.Get_Info_Calendario(lista.FirstOrDefault().FechaIni);
            try
            {

                
                foreach (var item in lista)
                {
                    ro_Archivo_Banco_Pichincha_Pago_Info info_pichincha = new ro_Archivo_Banco_Pichincha_Pago_Info();
                    info_pichincha.codigoOrientacion = "PA";
                    info_pichincha.contraPartida = item.CedulaRuc.ToString();
                    info_pichincha.moneda = "USD";
                    decimal valor =Convert.ToDecimal( item.Valor);
                    info_pichincha.valor = string.Format("{0:0.00}", valor);
                    info_pichincha.valor = info_pichincha.valor.ToString().Replace(".", "");
                    if (item.TipoCuenta == "COR" || item.TipoCuenta == "AHO")
                    {
                        info_pichincha.formaCobroPago = "CTA";
                        info_pichincha.numeroCuenta = item.NumCuenta;
                        if(item.TipoCuenta == "COR")
                        info_pichincha.tipoCuenta = "CTE";
                        else
                        info_pichincha.tipoCuenta = item.TipoCuenta;


                    }
                    else
                    {
                    }
                    if (item.IdNominaTipoLiqui == 1)
                    {
                        info_pichincha.referencia = "QUINCENA DE"+ info_calendario.NombreMes.ToUpper();
                    }
                    if (item.IdNominaTipoLiqui == 2)
                    {
                        info_pichincha.referencia = "FIN DE " + info_calendario.NombreMes.ToUpper();
                    }
                    if (item.TipoIdentificacion == "RUC")
                    {

                        info_pichincha.tipoIdCliente = "R";
                    }
                    else
                    {
                        if (item.TipoIdentificacion == "CED")
                        {
                            info_pichincha.tipoIdCliente = "C";
                        }
                        else
                            if (item.TipoIdentificacion == "PAS")
                            {
                                info_pichincha.tipoIdCliente = "P";
                            }
                            else
                            {
                                info_pichincha.tipoIdCliente = "N";
                            }
                    }

                    info_pichincha.numeroIdCliente = item.CedulaRuc;
                    info_pichincha.nombreCliente = item.NombreCompleto.ToUpper().Replace("Ñ", "N");
                    info_pichincha.cobroBaseImponible = item.Valor.ToString();
                    info_pichincha.cobroBaseImponible = item.Valor.ToString();
                    info_pichincha.pagoCodigoBanco = item.CodigoLegal;

                    Lista_Banco_G.Add(info_pichincha);
                }

                return Lista_Banco_G;

            }
            catch (Exception ex)
            {
                return new List<ro_Archivo_Banco_Pichincha_Pago_Info>();
            }



        }


        #endregion








        

        

    }
}
