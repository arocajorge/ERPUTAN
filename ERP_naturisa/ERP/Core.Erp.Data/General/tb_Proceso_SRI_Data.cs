using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;

using Core.Erp.Info.General;
using Core.Erp.Data.General;

using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri.NotaCredito;

namespace Core.Erp.Data.General
{
  public  class tb_Proceso_SRI_Data
    {

        string mensaje = "";
        public factura Deserializar_factura_SRI(string path, ref string numAutorizacion, ref DateTime fechAutoriza, ref string mensaje)
        {
            XmlDocument xmlComprobanteOrigen = new XmlDocument();

            try
            {
                factura info_factura = new factura();

                DateTime sFechaAuto = DateTime.Now;
                string sNum_Autorizacion = "";

                //leyendo el xml de la base 
                
                xmlComprobanteOrigen.Load(new StreamReader(path));

                //ENCONTRANDO EL NODO TOKEN CON ESTE SE FIRMARA

                XmlNode xmlNode_f;
                XmlNode xmlNode_N_Auto;


                XmlElement root = xmlComprobanteOrigen.DocumentElement;
                xmlNode_f = root.SelectSingleNode("//fechaAutorizacion");

                if (xmlNode_f != null)// es un xml q fue recibido y tiene soap
                {
                    sFechaAuto = Convert.ToDateTime(xmlNode_f.FirstChild.Value);

                    fechAutoriza = sFechaAuto;

                    xmlNode_N_Auto = root.SelectSingleNode("//numeroAutorizacion");
                    if (xmlNode_N_Auto == null) // no esta autorizado
                    {
                        sNum_Autorizacion = "NO AUTORIZADO";
                    }
                    else
                    {
                        sNum_Autorizacion = xmlNode_N_Auto.FirstChild.Value;
                    }

                    numAutorizacion = sNum_Autorizacion;


                    string sXml_a_descerializar;
                    sXml_a_descerializar = Quitar_a_xml_CDATA_y_Signature(xmlComprobanteOrigen.GetElementsByTagName("comprobante")[0].InnerXml);

                  

                        XmlDocument xmlCbte_a_descr = new XmlDocument();
                        xmlCbte_a_descr.Load(new StringReader(sXml_a_descerializar));

                  

                    info_factura = (factura)Deserialize(xmlCbte_a_descr, info_factura.GetType());

                }
                else
                {
                    info_factura = (factura)Deserialize(xmlComprobanteOrigen, info_factura.GetType());
                }

                return info_factura;
            }

            catch (Exception ex)
            {

                xmlComprobanteOrigen = null;
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                return new factura();
            }
        }

        public notaCredito Deserializar_NotaCredito_SRI(string path, ref string numAutorizacion, ref DateTime fechAutoriza)
        {
            try
            {
                notaCredito info_NotaCredito = new notaCredito();

                DateTime sFechaAuto = DateTime.Now;
                string sNum_Autorizacion = "";

                //leyendo el xml de la base 
                XmlDocument xmlComprobanteOrigen = new XmlDocument();
                xmlComprobanteOrigen.Load(new StreamReader(path));

                //ENCONTRANDO EL NODO TOKEN CON ESTE SE FIRMARA

                XmlNode xmlNode_f;
                XmlNode xmlNode_N_Auto;


                XmlElement root = xmlComprobanteOrigen.DocumentElement;
                xmlNode_f = root.SelectSingleNode("//fechaAutorizacion");

                if (xmlNode_f != null)// es un xml q fue recibido y tiene soap
                {
                    sFechaAuto = Convert.ToDateTime(xmlNode_f.FirstChild.Value);

                    fechAutoriza = sFechaAuto;

                    xmlNode_N_Auto = root.SelectSingleNode("//numeroAutorizacion");
                    if (xmlNode_N_Auto == null) // no esta autorizado
                    {
                        sNum_Autorizacion = "NO AUTORIZADO";
                    }
                    else
                    {
                        sNum_Autorizacion = xmlNode_N_Auto.FirstChild.Value;
                    }

                    numAutorizacion = sNum_Autorizacion;


                    string sXml_a_descerializar;
                   
                    sXml_a_descerializar = Quitar_a_xml_CDATA_y_Signature(xmlComprobanteOrigen.GetElementsByTagName("comprobante")[0].InnerXml);

                    XmlDocument xmlCbte_a_descr = new XmlDocument();
                    xmlCbte_a_descr.Load(new StringReader(sXml_a_descerializar));

                    info_NotaCredito = (notaCredito)Deserialize(xmlCbte_a_descr, info_NotaCredito.GetType());

                }
                else
                {
                    info_NotaCredito = (notaCredito)Deserialize(xmlComprobanteOrigen, info_NotaCredito.GetType());
                }

                return info_NotaCredito;
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                return new notaCredito();
            }
        }


        public string Quitar_a_xml_CDATA_y_Signature(string InnerXml_Cbte)
        {
            try
            {

                string sXml_a_descerializar = InnerXml_Cbte;
                string sValor_a_Reemplezar_cdata = "<![CDATA[";

                sXml_a_descerializar = sXml_a_descerializar.Replace(sValor_a_Reemplezar_cdata, "");
                sValor_a_Reemplezar_cdata = "]]>";
                sXml_a_descerializar = sXml_a_descerializar.Replace(sValor_a_Reemplezar_cdata, "");

                XmlDocument xml_valido = new System.Xml.XmlDocument();
                xml_valido.LoadXml(sXml_a_descerializar);

                // removiendo los datos de la firma 
                XmlNodeList nodeFirma = xml_valido.GetElementsByTagName("ds:Signature");
                nodeFirma.Item(0).RemoveAll();

                string valorareem = "<ds:Signature xmlns:ds=\"http://www.w3.org/2000/09/xmldsig#\"></ds:Signature>";

                sXml_a_descerializar = xml_valido.InnerXml;
                sXml_a_descerializar = sXml_a_descerializar.Replace(valorareem, "");


                return sXml_a_descerializar;

            }
            catch (Exception ex)
            {
                mensaje = "Quitar_a_xml_CDATA_y_Signature: " + ex;
                return "";
            }
        }

        public static object Deserialize(XmlDocument xml, Type type)
        {
            XmlSerializer s = new XmlSerializer(type);
            string xmlString = xml.OuterXml.ToString();
            byte[] buffer = ASCIIEncoding.UTF8.GetBytes(xmlString);
            MemoryStream ms = new MemoryStream(buffer);
            XmlReader reader = new XmlTextReader(ms);
            Exception caught = null;

            try
            {
                object o = s.Deserialize(reader);
                return o;
            }

            catch (Exception e)
            {
                caught = e;
            }
            finally
            {
                reader.Close();

                if (caught != null)
                    throw caught;
            }
            return null;
        }

    }
}
