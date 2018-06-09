using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{ 
    public class cp_parametros_Data
    {
        string mensaje = "";

        public Boolean ModificarDB(cp_parametros_Info info)
        {
            try  
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar param = new EntitiesCuentasxPagar();
                    var selectBaParam = (from C in param.cp_parametros
                                         where C.IdEmpresa == info.IdEmpresa
                                         select C).Count();

                    if (selectBaParam == 0)
                    {
                        cp_parametros addressG = new cp_parametros();
                        addressG.IdEmpresa = info.IdEmpresa;
                        addressG.pa_TipoCbte_OG = info.pa_TipoCbte_OG;
                        addressG.pa_TipoCbte_OG_anulacion = info.pa_TipoCbte_OG_anulacion;
                        addressG.pa_ctacble_deudora = (info.pa_ctacble_deudora == "") ? null : info.pa_ctacble_deudora;
                        addressG.pa_ctacble_iva = (info.pa_ctacble_iva=="")?null:info.pa_ctacble_iva;
                        addressG.pa_TipoEgrMoviCaja_Conciliacion = info.pa_TipoEgrMoviCaja_Conciliacion;                        
                        addressG.ip = info.ip;
                        addressG.IdUsuario = info.IdUsuario;
                        addressG.nom_pc = info.nom_pc;
                        addressG.pa_ctacble_Proveedores_default = info.pa_ctacble_Proveedores_default;
                        addressG.pa_TipoCbte_NC = info.pa_TipoCbte_NC;
                        addressG.pa_TipoCbte_NC_anulacion = info.pa_TipoCbte_NC_anulacion;
                        addressG.pa_TipoCbte_ND = info.pa_TipoCbte_ND;
                        addressG.pa_TipoCbte_ND_anulacion = info.pa_TipoCbte_ND_anulacion;
                        addressG.pa_obligaOC = info.pa_obligaOC;
                        addressG.pa_xsd_de_atsSRI = info.pa_xsd_de_atsSRI;
                        addressG.pa_Formulario103_104 = info.pa_Formulario103_104;
                        addressG.pa_IdTipoCbte_x_Anu_Retencion = info.pa_IdTipoCbte_x_Anu_Retencion;
                        addressG.pa_IdTipoCbte_x_Retencion = info.pa_IdTipoCbte_x_Retencion;
                        addressG.pa_TipoCbte_para_conci_x_antcipo = info.pa_TipoCbte_para_conci_x_antcipo;
                        addressG.pa_TipoCbte_para_conci_anulacion_x_antcipo = info.pa_TipoCbte_para_conci_anulacion_x_antcipo;
                        addressG.pa_ruta_descarga_xml_fac_elct = info.pa_ruta_descarga_xml_fac_elct;
                        addressG.pa_ctacble_x_RetIva_default = info.pa_ctacble_x_RetIva_default;
                        addressG.pa_ctacble_x_RetIva_default = info.pa_ctacble_x_RetIva_default;
                        addressG.pa_IdBancoCuenta_default_para_OP = info.pa_IdBancoCuenta_default_para_OP == null ? 0 : info.pa_IdBancoCuenta_default_para_OP; 
                        addressG.archivo_diseño_reporte = info.archivo_diseño_reporte;
                        
                        addressG.pa_X_Defecto_la_Retencion_es_cbte_elect = info.pa_X_Defecto_la_Retencion_es_cbte_elect;

                        context.cp_parametros.Add(addressG);
                        context.SaveChanges();
                    }
                    else
                    {
                        var contact = context.cp_parametros.FirstOrDefault(para => para.IdEmpresa == info.IdEmpresa);
                        if (contact != null)
                        {
                            contact.IdEmpresa = info.IdEmpresa;
                            contact.pa_TipoCbte_OG = info.pa_TipoCbte_OG;
                            contact.pa_TipoCbte_OG_anulacion = info.pa_TipoCbte_OG_anulacion;
                            contact.pa_ctacble_deudora = (info.pa_ctacble_deudora == "") ? null : info.pa_ctacble_deudora;
                            contact.pa_ctacble_iva = (info.pa_ctacble_iva == "") ? null : info.pa_ctacble_iva;
                            contact.pa_ctacble_Proveedores_default = info.pa_ctacble_Proveedores_default;
                            contact.pa_TipoEgrMoviCaja_Conciliacion = info.pa_TipoEgrMoviCaja_Conciliacion;
                            contact.pa_TipoCbte_NC = info.pa_TipoCbte_NC;
                            contact.pa_TipoCbte_NC_anulacion = info.pa_TipoCbte_NC_anulacion;
                            contact.pa_TipoCbte_ND = info.pa_TipoCbte_ND;
                            contact.pa_TipoCbte_ND_anulacion = info.pa_TipoCbte_ND_anulacion;
                            contact.pa_obligaOC = info.pa_obligaOC;
                            contact.FechaUltMod = DateTime.Now;
                            contact.IdUsuarioUltMod = info.IdUsuario;
                            contact.pa_xsd_de_atsSRI = info.pa_xsd_de_atsSRI;
                            contact.pa_Formulario103_104 = info.pa_Formulario103_104;
                            contact.pa_IdTipoCbte_x_Anu_Retencion = info.pa_IdTipoCbte_x_Anu_Retencion;
                            contact.pa_IdTipoCbte_x_Retencion = info.pa_IdTipoCbte_x_Retencion;
                            contact.pa_TipoCbte_para_conci_x_antcipo = info.pa_TipoCbte_para_conci_x_antcipo;
                            contact.pa_TipoCbte_para_conci_anulacion_x_antcipo = info.pa_TipoCbte_para_conci_anulacion_x_antcipo;
                            contact.pa_ruta_descarga_xml_fac_elct = info.pa_ruta_descarga_xml_fac_elct;
                            contact.pa_ctacble_x_RetFte_default = info.pa_ctacble_x_RetFte_default;
                            contact.pa_ctacble_x_RetIva_default = info.pa_ctacble_x_RetIva_default;
                            contact.pa_IdBancoCuenta_default_para_OP = info.pa_IdBancoCuenta_default_para_OP == 0 ? null : info.pa_IdBancoCuenta_default_para_OP;
                            contact.archivo_diseño_reporte = info.archivo_diseño_reporte;
                            contact.pa_X_Defecto_la_Retencion_es_cbte_elect = info.pa_X_Defecto_la_Retencion_es_cbte_elect;
                            context.SaveChanges();
                        }
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_Diseño_reporte(cp_parametros_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {                
                    EntitiesCuentasxPagar param = new EntitiesCuentasxPagar();
                  
                    var contact = context.cp_parametros.FirstOrDefault(para => para.IdEmpresa == info.IdEmpresa);
                    if (contact != null)
                    {
                        contact.archivo_diseño_reporte = info.archivo_diseño_reporte;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public cp_parametros_Info Get_Info_parametros(int IdEmpresa)
        {
            try
            {
                cp_parametros_Info Cbt = new cp_parametros_Info();
                EntitiesCuentasxPagar param = new EntitiesCuentasxPagar();
                var selectBaParam = from C in param.cp_parametros
                                    where C.IdEmpresa == IdEmpresa 
                                    select C;
                
                foreach (var item in selectBaParam)
                {
                    
                    Cbt.pa_TipoCbte_OG = Convert.ToInt32(item.pa_TipoCbte_OG);
                    Cbt.pa_TipoCbte_OG_anulacion = Convert.ToInt32(item.pa_TipoCbte_OG_anulacion);
                    Cbt.pa_ctacble_deudora = item.pa_ctacble_deudora;
                    Cbt.pa_ctacble_iva = item.pa_ctacble_iva;
                    Cbt.pa_TipoEgrMoviCaja_Conciliacion = item.pa_TipoEgrMoviCaja_Conciliacion;
                    Cbt.pa_ctacble_Proveedores_default = item.pa_ctacble_Proveedores_default;
                    Cbt.pa_TipoEgrMoviCaja_Conciliacion = item.pa_TipoEgrMoviCaja_Conciliacion;
                    Cbt.pa_obligaOC = item.pa_obligaOC;
                    Cbt.pa_TipoCbte_NC = item.pa_TipoCbte_NC;
                    Cbt.pa_TipoCbte_NC_anulacion = item.pa_TipoCbte_NC_anulacion;
                    Cbt.pa_TipoCbte_ND = item.pa_TipoCbte_ND;
                    Cbt.pa_TipoCbte_ND_anulacion = item.pa_TipoCbte_ND_anulacion;
                    Cbt.pa_xsd_de_atsSRI = item.pa_xsd_de_atsSRI;
                    Cbt.pa_Formulario103_104 = item.pa_Formulario103_104;
                    Cbt.pa_IdTipoCbte_x_Retencion = item.pa_IdTipoCbte_x_Retencion;
                    Cbt.pa_IdTipoCbte_x_Anu_Retencion = item.pa_IdTipoCbte_x_Anu_Retencion;
                    Cbt.pa_TipoCbte_para_conci_x_antcipo = Convert.ToInt32(item.pa_TipoCbte_para_conci_x_antcipo);
                    Cbt.pa_ruta_descarga_xml_fac_elct = item.pa_ruta_descarga_xml_fac_elct;
                    Cbt.pa_ctacble_x_RetFte_default = item.pa_ctacble_x_RetFte_default;
                    Cbt.pa_ctacble_x_RetIva_default = item.pa_ctacble_x_RetIva_default;
                    Cbt.pa_IdBancoCuenta_default_para_OP = item.pa_IdBancoCuenta_default_para_OP;
                    Cbt.archivo_diseño_reporte = item.archivo_diseño_reporte;
                    Cbt.pa_X_Defecto_la_Retencion_es_cbte_elect = item.pa_X_Defecto_la_Retencion_es_cbte_elect;
                    Cbt.pa_TipoCbte_para_conci_anulacion_x_antcipo = item.pa_TipoCbte_para_conci_anulacion_x_antcipo;
                    Cbt.pa_X_Defecto_la_Retencion_es_cbte_elect = item.pa_X_Defecto_la_Retencion_es_cbte_elect;

                    Cbt.IdEmpresa = IdEmpresa;

                }
                return(Cbt);
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
