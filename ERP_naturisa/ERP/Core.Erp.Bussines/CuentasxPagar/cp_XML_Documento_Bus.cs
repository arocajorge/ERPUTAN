using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.class_sri.Retencion;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_XML_Documento_Bus
    {
        cp_XML_Documento_Data odata = new cp_XML_Documento_Data();
        cp_XML_Documento_Retencion_Data odata_ret = new cp_XML_Documento_Retencion_Data();

        public bool GuardarDB(cp_XML_Documento_Info info, ref bool GenerarXML)
        {
            try
            {
                return odata.GuardarDB(info,ref GenerarXML);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool AnularDB(cp_XML_Documento_Info info)
        {
            try
            {
                return odata.AnularDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ModificarDB(cp_XML_Documento_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int Existe(int IdEmpresa, string Ruc, string CodDocumento, string Establecimiento, string PuntoEmision, string secuencial)
        {
            try
            {
                return odata.Existe(IdEmpresa, Ruc, CodDocumento, Establecimiento, PuntoEmision, secuencial);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<cp_XML_Documento_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return odata.GetList(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Boolean Generacion_xml_SRI(int IdEmpresa, decimal IdDocumento, ref string MensajeError)
        {
            try
            {

                cp_parametros_Info cp_parametro = new cp_parametros_Info();
                cp_parametros_Bus bus_cp_parametro = new cp_parametros_Bus();
                cp_parametro = bus_cp_parametro.Get_Info_parametros(IdEmpresa);
                string sIdCbteFact = "";

                List<cp_XML_Documento_Info> lista_Retencion_sri = new List<cp_XML_Documento_Info>();

                lista_Retencion_sri = odata.Get_list_Retencion_Sri(IdEmpresa, IdDocumento);

                if (lista_Retencion_sri.Count != 0)
                {
                    // validar objeto

                    if (!ValidarObjeto_XML_Retencion(lista_Retencion_sri, ref  MensajeError))
                        return false;


                    List<comprobanteRetencion> lista = new List<comprobanteRetencion>();
                    lista = odata_ret.GenerarXmlRetencion(lista_Retencion_sri,IdEmpresa,  IdDocumento);

                    if (lista.Count != 0)
                    {
                        foreach (var item in lista)
                        {

                            sIdCbteFact = item.infoTributaria.razonSocial.Substring(0, 3) + "-" + Cl_Enumeradores.eTipoCodComprobante.RET + "-" + item.infoTributaria.estab + "-" + item.infoTributaria.ptoEmi + "-" + item.infoTributaria.secuencial;
                            XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                            NamespaceObject.Add("", "");
                            XmlSerializer mySerializer = new XmlSerializer(typeof(comprobanteRetencion));
                            StreamWriter myWriter = new StreamWriter(cp_parametro.pa_ruta_descarga_xml_fac_elct + sIdCbteFact + ".xml");
                            mySerializer.Serialize(myWriter, item, NamespaceObject);
                            myWriter.Close();


                        }
                    }


                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generacion_xml_SRI", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }

        public Boolean ValidarObjeto_XML_Retencion(List<cp_XML_Documento_Info> lista, ref string MensajeError)
        {
            try
            {
                Boolean res = true;

                foreach (var item in lista)
                {

                    if (String.IsNullOrEmpty(item.RazonSocial))
                    {
                        MensajeError = "Falta Razón Social Empresa. Por Favor verifique";
                        res = false;
                        return res;

                    }
                    if (String.IsNullOrEmpty(item.NombreComercial))
                    {
                        MensajeError = "Falta Nombre Comercial Empresa. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    if (String.IsNullOrEmpty(item.em_direccion))
                    {
                        MensajeError = "Falta Dirección Matriz Empresa. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    if (String.IsNullOrEmpty(item.em_ruc))
                    {
                        MensajeError = "Falta Tipo de Identificación Empresa. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    if (String.IsNullOrEmpty(item.ContribuyenteEspecial))
                    {
                        MensajeError = "Falta Número de Contribuyente Especial Empresa. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    //Retencion
                    if (String.IsNullOrEmpty(item.serie))
                    {
                        MensajeError = "Falta serie del Documento o la Retención no ha sido Impresa. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    if (String.IsNullOrEmpty(item.ret_NumeroDocumento))
                    {
                        MensajeError = "Falta Secuencial del Documento o la Retención no ha sido Impresa. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    //Proveedor
                    if (String.IsNullOrEmpty(item.Su_Direccion))
                    {
                        MensajeError = "Falta Dirección Establecimiento. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    if (String.IsNullOrEmpty(item.RazonSocial))
                    {
                        MensajeError = "Falta Razón Social del Sujeto a Retener. Por Favor verifique";
                        res = false;
                        return res;

                    }

                    if (String.IsNullOrEmpty(item.emi_Ruc))
                    {
                        MensajeError = "Falta Identificación del Sujeto Retenido. Por Favor verifique";
                        res = false;
                        return res;

                    }


                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarObjeto_XML_Retencion", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }


        }

        public cp_XML_Documento_Info GetInfo(int IdEmpresa, string CodDocumento, string pe_cedulaRuc, string Establecimiento, string PuntoEmision, string NumeroDocumento)
        {
            try
            {
                return odata.GetInfo(IdEmpresa, CodDocumento, pe_cedulaRuc, Establecimiento, PuntoEmision, NumeroDocumento);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public cp_XML_Documento_Info GetInfo(int IdEmpresa, string CodDocumento, string Comprobante, string pe_cedulaRuc)
        {
            try
            {
                return odata.GetInfo(IdEmpresa, CodDocumento, Comprobante, pe_cedulaRuc);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<cp_XML_Documento_Info> GetList(int IdEmpresa, string pe_cedulaRuc)
        {
            try
            {
                return odata.GetList(IdEmpresa, pe_cedulaRuc);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ContabilizarDocumento(int IdEmpresa, decimal IdDocumento, int IdTipoCbte, decimal IdCbteCble, string IdUsuario, bool GenerarRetencion)
        {
            try
            {
                return odata.ContabilizarDocumento(IdEmpresa, IdDocumento, IdTipoCbte, IdCbteCble, IdUsuario, GenerarRetencion);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool EliminarRetencion(int IdEmpresa, decimal IdDocumento, string IdUsuario)
        {
            try
            {
                return odata.EliminarRetencion(IdEmpresa, IdDocumento, IdUsuario);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
