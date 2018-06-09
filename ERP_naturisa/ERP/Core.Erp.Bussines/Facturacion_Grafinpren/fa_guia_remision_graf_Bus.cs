using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Data.Facturacion_Grafinpren;
using Core.Erp.Info.class_sri.GuiaRemision;
using Core.Erp.Business.Facturacion;
using System.Xml.Serialization;
using System.Collections;
using System.Threading;
using System.Globalization;
using System.IO;
using Core.Erp.Info.General;
namespace Core.Erp.Business.Facturacion_Grafinpren
{
    /// <summary>
    /// Clase personalizada para guias de remision en Grafinprent 
    /// usa la guia general cabecera y detalle 
    /// los get_list son cruzados con la tabla [Grafinpren].[fa_guia_remision]
    /// </summary>
   public class fa_guia_remision_graf_Bus
    {
       fa_guia_remision_Info info_Guia_remision = new fa_guia_remision_Info();
       Core.Erp.Business.Facturacion.fa_guia_remision_Bus BusGuiaRemision_General = new Facturacion.fa_guia_remision_Bus();

        public Boolean ActualizarEstado(int idempresa, fa_guia_remision_Info oGuia)
       {
           try
           {
               return BusGuiaRemision_General.ActualizarEstado(idempresa, oGuia);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstado", ex.Message), ex) { EntityType = typeof(fa_guia_remision_graf_Bus) };
           }
       }
 
        public Boolean GrabarDB(fa_guia_remision_Info info, ref decimal id, ref string numDocFactu, ref string msg)
        {
            try
            {
                Boolean res = false;
                
                    res = BusGuiaRemision_General.GrabarDB(info, ref id, ref numDocFactu ,ref msg);
                    if (res)
                    {
                        Core.Erp.Data.Facturacion_Grafinpren.fa_guia_remision_graf_Data OdataGuia_Graf= new Data.Facturacion_Grafinpren.fa_guia_remision_graf_Data();
                        OdataGuia_Graf.GrabarDB(info.Info_Guia_Remision_x_Grafinpren, ref id, ref msg);
                        res = true;
                    }
                
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_guia_remision_graf_Bus) };
            }

        }

        public Boolean ModificarDB(fa_guia_remision_Info info, ref string msg)
        {
            try
            {
                Boolean res = false;

                res = BusGuiaRemision_General.ModificarDB(info, ref msg);
                if (res)
                {
                    Core.Erp.Data.Facturacion_Grafinpren.fa_guia_remision_graf_Data OdataGuia_Graf = new Data.Facturacion_Grafinpren.fa_guia_remision_graf_Data();
                    OdataGuia_Graf.ModificarDB(info.Info_Guia_Remision_x_Grafinpren, ref msg);
                }
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_guia_remision_graf_Bus) };
            }

        }

        public Boolean VerificarCodigo(string Codigo, int idempresa)
        {
            try
            {
                return BusGuiaRemision_General.VerificarCodigo(Codigo, idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarCodigo", ex.Message), ex) { EntityType = typeof(fa_guia_remision_graf_Bus) };
            }

        }

        public Boolean Imprimir(fa_guia_remision_Info info, ref  string msg)
        {
            try
            {
                return BusGuiaRemision_General.Imprimir(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Imprimir", ex.Message), ex) { EntityType = typeof(fa_guia_remision_graf_Bus) };
            }

        }

        public List<fa_guia_remision_Info> Get_List_guia_remision(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                Core.Erp.Data.Facturacion_Grafinpren.fa_guia_remision_graf_Data data = new Data.Facturacion_Grafinpren.fa_guia_remision_graf_Data();
                return data.Get_List_guia_remision(idEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, FechaIni, FechaFin);
            } 
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_guia_remision", ex.Message), ex) { EntityType = typeof(fa_guia_remision_graf_Bus) };

            }

        }

        public fa_guia_remision_Info Gat_info_Guia(int idEmpresa, int idSucursalIni, int IdGuia)
        {
            try
            {
                fa_guia_remision_Info info_guia_remision = new fa_guia_remision_Info();
                fa_guia_remision_graf_Data data = new fa_guia_remision_graf_Data();
                fa_guia_remision_det_bus Bus_detalle_guia = new fa_guia_remision_det_bus();

                info_guia_remision = data.Gat_info_Guia(idEmpresa, idSucursalIni, IdGuia);// obtengo cabecera
                info_guia_remision .ListaDetalle= Bus_detalle_guia.Get_List_guia_remision_det(idEmpresa, idSucursalIni, IdGuia);// obtengo el detalle
                return info_guia_remision;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_guia_remision", ex.Message), ex) { EntityType = typeof(fa_guia_remision_graf_Bus) };

            }
        }
        public bool GenerarXML(int IdEmpresa,int IdSucursal, int IdGuia)
        {
            try
            {
                fa_parametro_info info_parametro = new fa_parametro_info();
                fa_parametro_Bus bus_parametro = new fa_parametro_Bus();
                info_parametro = bus_parametro.Get_Info_parametro(IdEmpresa);
                tb_Empresa_Info info_empresa = new tb_Empresa_Info();
                tb_Empresa_Bus bus_empresa = new tb_Empresa_Bus();
                info_empresa = bus_empresa.Get_Info_Empresa(IdEmpresa);



                StreamWriter myWriter;
                fa_guia_remision_Info info_guia = new fa_guia_remision_Info();
                info_guia = Gat_info_Guia(IdEmpresa, IdSucursal, IdGuia);

                // cabecera del xml
                guiaRemision myObject = new guiaRemision();
                myObject.id = guiaRemisionID.comprobante;
                myObject.version = "1.1.0";
                myObject.id = guiaRemisionID.comprobante;
                myObject.infoTributaria = new Info.class_sri.FacturaV2.infoTributaria();
                myObject.infoGuiaRemision = new guiaRemisionInfoGuiaRemision();
                myObject.infoTributaria.ambiente = "1";
                myObject.infoTributaria.tipoEmision = "1";
                myObject.infoTributaria.razonSocial = info_guia.RazonSocial;
                myObject.infoTributaria.nombreComercial = info_guia.NombreComercial;
                myObject.infoTributaria.ruc = info_guia.em_ruc;
                myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                myObject.infoTributaria.codDoc = "06"; 
                myObject.infoTributaria.estab = info_guia.Serie1;
                myObject.infoTributaria.ptoEmi = info_guia.Serie2;
                myObject.infoTributaria.secuencial = info_guia.NumGuia_Preimpresa;
                myObject.infoTributaria.dirMatriz = info_guia.Direccion_Origen;
                myObject.infoGuiaRemision.dirEstablecimiento = info_guia.Direccion_Origen;
                myObject.infoGuiaRemision.dirPartida = info_guia.Direccion_Destino;
                myObject.infoGuiaRemision.razonSocialTransportista = info_guia.nom_Transportista;
                if (info_guia.Cedula.Length == 10)
                {
                    myObject.infoGuiaRemision.tipoIdentificacionTransportista = "05";
                }
                else
                {
                    myObject.infoGuiaRemision.tipoIdentificacionTransportista = "04";
                }
                myObject.infoGuiaRemision.rucTransportista = info_guia.Cedula;
                myObject.infoGuiaRemision.obligadoContabilidad = "SI";
                myObject.infoGuiaRemision.contribuyenteEspecial = info_empresa.ContribuyenteEspecial;
                myObject.infoGuiaRemision.fechaIniTransporte =info_guia.gi_FecIniTraslado.ToString().Substring(0,10);
                myObject.infoGuiaRemision.fechaFinTransporte =info_guia.gi_FecFinTraslado.ToString().Substring(0,10);
                myObject.infoGuiaRemision.placa = info_guia.placa;

                // datos del destinatario
                myObject.destinatarios = new guiaRemisionDestinatarios();
                myObject.destinatarios.destinatario = new List<destinatario>();
                destinatario destinatario_ = new destinatario();
                destinatario_.detalles = new destinatarioDetalles();
                destinatario_.detalles.detalle = new List<detalle>();
                destinatario_.identificacionDestinatario = info_guia.pe_cedulaRuc;
                destinatario_.razonSocialDestinatario = info_guia.pe_nombreCompleto;
                destinatario_.dirDestinatario = info_guia.Direccion_Destino;
                destinatario_.motivoTraslado = info_guia.gi_Observacion;
                
                // datos si la guia tiene factura

                //destinatario_.codEstabDestino = "";
                //destinatario_.ruta = "";
                //destinatario_.codDocSustento = "";
                //destinatario_.numDocSustento = "";
                //destinatario_.numAutDocSustento = "";
                //destinatario_.fechaEmisionDocSustento = "";
                //destinatario_.numAutDocSustento = "";

                myObject.destinatarios.destinatario.Add(destinatario_);

                foreach (var item in info_guia.ListaDetalle)
                {
                    detalle det = new detalle();
                    det.codigoInterno = item.pr_codigo;
                    det.codigoAdicional = item.pr_codigo;
                    det.descripcion = item.pr_descripcion;
                    det.cantidad =(decimal) item.gi_cantidad;
                    det.cantidad =Convert.ToDecimal( string.Format("{0:0.0000}", item.gi_cantidad));
                    destinatario_.detalles.detalle.Add(det);

                    
                }

                myObject.destinatarios.destinatario.Add(destinatario_);

               

                // SEREALIZO EL XML
                string sIdCbteRet = "";

                info_parametro.pa_ruta_descarga_xml_fac_elct = @"C:\Users\Administrador.Desarrollo-PC\Desktop\xml\";


                sIdCbteRet = myObject.infoTributaria.razonSocial.Substring(0, 3) + "-GUI-" + myObject.infoTributaria.estab + "-" + myObject.infoTributaria.ptoEmi + "-" + myObject.infoTributaria.secuencial;
                XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                NamespaceObject.Add("", "");
                XmlSerializer mySerializer = new XmlSerializer(typeof(guiaRemision));
                myWriter = new StreamWriter(info_parametro.pa_ruta_descarga_xml_fac_elct + sIdCbteRet + ".xml");
                mySerializer.Serialize(myWriter, myObject, NamespaceObject);
                myWriter.Close();



                return true;

            }
            catch (Exception ex)
            {
                
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_guia_remision", ex.Message), ex) { EntityType = typeof(fa_guia_remision_graf_Bus) };

            }
        }
    }
}
