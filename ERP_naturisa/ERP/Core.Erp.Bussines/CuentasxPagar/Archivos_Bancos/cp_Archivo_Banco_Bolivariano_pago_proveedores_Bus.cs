using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar.Archivos_Pagos_Bancos;
using Core.Erp.Info.Bancos.Archivos_PreAviso_x_Banco;
using Core.Erp.Info.General;
using Core.Erp.Info.Bancos;
namespace Core.Erp.Business.CuentasxPagar.Archivos_Bancos
{
    public class cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus
    {
        public Boolean Generar_archivo_pago_proveedores_BB(Archivo_Banco_Bolivariano_pago_proveedores_Info info, string patch, string nombre_File)
        {
            try
            {


                string linea = "";
                linea += info.PagTer_BZDET;
                linea += info.PagTer_secuencial.PadLeft(6,'0');
                linea += info.PagTer_codigoBeneficiario.PadRight(18, ' ');
                linea += info.PagTer_tipoIdentificacion;
                linea += info.PagTer_numeroIdentificacion.PadRight(14,' ');
                linea += info.PagTer_nombreBeneficiario.Length > 60 ? info.PagTer_nombreBeneficiario.Substring(0, 60) : info.PagTer_nombreBeneficiario.PadRight(60,' ');
                linea += info.PagTer_formaPago;
                linea += info.PagTer_codigoPais;
                linea += info.PagTer_codigoBanco.PadRight(2,' ');
                linea += info.PagTer_tipoCuenta.PadRight(2,' ');
                linea += info.PagTer_numeroCuenta.PadRight(20,' ');
                linea += info.PagTer_codigoMoneda;
                linea += info.PagTer_valorTotalPago.PadRight(15,'0');
                linea += info.PagTer_concepto.Length > 60 ? info.PagTer_concepto.Substring(0,60) : info.PagTer_concepto.PadRight(60,' ');
                linea += info.PagTer_numeroComprobante.PadLeft(15,'0');
                linea += info.PagTer_numeroComprobanteRetencion.PadLeft(15,'0');
                linea += info.PagTer_numeroComprobanteIVA.PadLeft(15,'0');
                linea += info.PagTer_numeroFacturaSRI.PadLeft(20,'0');
                linea += info.PagTer_codigoGrupo.PadRight(10,' ');
                linea += info.PagTer_descripcionGrupo.PadRight(50,' ');
                linea += info.PagTer_direccionBeneficiario.Length > 50 ? info.PagTer_direccionBeneficiario.Substring(0,50) : info.PagTer_direccionBeneficiario.PadRight(50,' ');
                linea += info.PagTer_telefono.PadRight(20,' ');
                linea += info.PagTer_codigoServicio;
                linea += info.PagTer_cedula1PersonaRetirarChequePago.PadRight(10,' ');
                linea += info.PagTer_cedula2PersonaRetirarChequePago.PadRight(10, ' ');
                linea += info.PagTer_cedula3PersonaRetirarChequePago.PadRight(10, ' ');
                linea += info.PagTer_seniaControlHorarioAtencion.PadRight(1,' ');
                linea += info.PagTer_codigoEmpresaAsignadoPorBanco.PadLeft(5, '0');
                linea += info.PagTer_nemonicoSubEmpresaQuienOrdenaPago.PadRight(6, ' ');
                linea += info.PagTer_subMotivoPagoCobro;
                
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(patch + nombre_File + ".BIZ", true))
                {
                    file.WriteLine(linea);
                    file.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus) };
            }
        }


        public Boolean Generar_archivo_PreAviso_Cheq_BB_(Archivo_Banco_Bolivariano_preAviso_Cheq_Info info, string patch, string nombre_File)
        {
            try
            {


                string linea = "";
                linea += info.PagTer_BZDET;
                linea += info.PagTer_secuencial.PadLeft(6, '0');
                linea += info.PagTer_codigoBeneficiario.PadRight(18, ' ');
                linea += info.PagTer_tipoIdentificacion;
                linea += info.PagTer_numeroIdentificacion.PadRight(14, ' ');
                linea += info.PagTer_nombreBeneficiario.Length > 60 ? info.PagTer_nombreBeneficiario.Substring(0, 60) : info.PagTer_nombreBeneficiario.PadRight(60, ' ');
                linea += info.PagTer_formaPago;
                linea += info.PagTer_codigoPais;
                linea += info.PagTer_codigoBanco.PadRight(2, ' ');
                linea += info.PagTer_tipoCuenta.PadRight(2, ' ');
                linea += info.PagTer_numeroCuenta.PadLeft(10, '0');
                linea += info.PagTer_numeroCheque.PadLeft(10, '0');
                linea += info.PagTer_codigoMoneda.PadLeft(1,' ');
                linea += info.PagTer_valorCheq_Ordenado.PadLeft(15, '0');
                linea += info.PagTer_concepto.Length > 60 ? info.PagTer_concepto.Substring(0, 60) : info.PagTer_concepto.PadRight(60, ' ');
                linea += info.PagTer_espacio_blanco1.PadLeft(195,' ');
                linea += info.PagTer_codigoServicio;
                linea += info.PagTer_espacio_blanco2.PadLeft(30, ' ');
                linea += info.PagTer_Tipo_de_cheque;
                linea += info.PagTer_codigoEmpresaAsignadoPorBanco.PadLeft(5, '0');
                linea = linea.Trim();

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(patch + nombre_File + ".BIZ", true))
                {
                    file.WriteLine(linea);
                    file.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus) };
            }
        }

        public bool Validar_Linea_archivo_BB(Archivo_Banco_Bolivariano_pago_proveedores_Info info_)
        {
            try
            {
                info_.PagTer_nombreBeneficiario = info_.PagTer_nombreBeneficiario.Replace('Ñ', 'N').Replace('ñ', 'n');

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus) };
            }
        }



        public bool Validar_Linea_archivo_BB_PreAviso_Cheq(Archivo_Banco_Bolivariano_preAviso_Cheq_Info info_)
        {
            try
            {
                info_.PagTer_nombreBeneficiario = info_.PagTer_nombreBeneficiario.Replace('Ñ', 'N').Replace('ñ', 'n');
                info_.PagTer_nombreBeneficiario = info_.PagTer_nombreBeneficiario.Replace('É', 'E').Replace('é', 'e');

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus) };
            }
        }

        public Boolean Guardar_Archivo_Banco_Bolivariano(Archivo_Banco_Bolivariano_pago_proveedores_Info info, tb_banco_procesos_bancarios_x_empresa_Info Info_proceso, string patch, string nombre_file)
        {
            try
            {
                if (Validar_Linea_archivo_BB(info))
                {
                    switch (Info_proceso.cod_Proceso)
                    {
                        case ebanco_procesos_bancarios_tipo.ROL_ELECTRONICO_BG:
                            break;
                        
                        
                        case ebanco_procesos_bancarios_tipo.TRANSF_BANCARIA_BP:
                            break;
                        case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BOL:// pago a proveedores banco bolivariano
                            Generar_archivo_pago_proveedores_BB(info, patch, nombre_file);
                            break;
                        case ebanco_procesos_bancarios_tipo.PREAVISO_CHEQ:
                            break;
                        case ebanco_procesos_bancarios_tipo.PAGO_BANCO_PACIFICO_BPA:
                            break;
                        default:
                            break;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus) };
            }
        }


        public Boolean Guardar_Archivo_Banco_Bolivariano_PreAviso(Archivo_Banco_Bolivariano_preAviso_Cheq_Info info, string patch, string nombre_file)
        {
            try
            {
                if (Validar_Linea_archivo_BB_PreAviso_Cheq(info))
                {
                   
                   Generar_archivo_PreAviso_Cheq_BB_(info, patch, nombre_file);
                   
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_archivo", ex.Message), ex) { EntityType = typeof(cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus) };
            }
        }
    }
}
