using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Info.class_sri.GuiaRemision;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri;

using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;


using System.Xml.Serialization;
using System.IO;
using System.Data;




namespace Core.Erp.Business.Inventario
{
   public class in_Guia_x_traspaso_bodega_Bus
    {
       string mensaje = "";
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       in_Guia_x_traspaso_bodega_Data odata = new in_Guia_x_traspaso_bodega_Data();
       
       public Boolean GuardarDB(in_Guia_x_traspaso_bodega_Info info,ref decimal IdGuia, ref string mensaje)
       {
           try
           {
               Boolean res = true;
               if (Validar_y_corregir_objeto(ref info, ref mensaje))
              {
                  res = odata.GuardarDB(info, ref IdGuia, ref  mensaje);
                  tb_sis_Documento_Tipo_Talonario_Bus busTalonario = new tb_sis_Documento_Tipo_Talonario_Bus();
                  busTalonario.Modificar_Estado_Usado(info.IdEmpresa, info.CodDocumentoTipo, info.IdEstablecimiento, info.IdPuntoEmision, info.NumDocumento_Guia, ref mensaje);

              }
              else
              {
                  res = false; 
              }
               return res;
              
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };
           }
       }

       public Boolean ModificarDB(in_Guia_x_traspaso_bodega_Info info, ref string mensaje)
       {
           try
           {

               Boolean res = true;
               if (Validar_y_corregir_objeto(ref info, ref mensaje))
               {
                   res = odata.ModificarDB(info, ref  mensaje);
                   tb_sis_Documento_Tipo_Talonario_Bus busTalonario = new tb_sis_Documento_Tipo_Talonario_Bus();
                   busTalonario.Modificar_Estado_Usado(info.IdEmpresa, info.CodDocumentoTipo, info.IdEstablecimiento, info.IdPuntoEmision, info.NumDocumento_Guia, ref mensaje);
               }
               else
               {
                   res = false;
               }
               return res;
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };

           }
       }

       public Boolean AnularDB(in_Guia_x_traspaso_bodega_Info info, ref string mensaje)
       {
           try
           {
                return odata.AnularDB(info, ref  mensaje);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };

           }
       }

       public List<in_Guia_x_traspaso_bodega_Info> Get_List_OC_x_in_Guia(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
       {
           try
           {
               return odata.Get_List_OC_x_in_Guia(IdEmpresa, IdSucursal, IdOrdenCompra);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };

           }
       }

       public List<in_Guia_x_traspaso_bodega_Info> Get_List_Guia_x_traspaso_bodega(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
       {
           try
           {
               return odata.Get_List_Guia_x_traspaso_bodega(IdEmpresa, FechaIni, FechaFin);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListGuixTrasBod", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };

           }
       }

       Boolean Validar_y_corregir_objeto(ref in_Guia_x_traspaso_bodega_Info Info_Guia, ref string msg)
       {
           try
           {
               #region 'Validaciones'
               /*--- validaciones */



               if (Info_Guia.IdEmpresa == 0)
               {
                   msg = "La variable estan en cero... IdEmpresa == 0  ";
                   return false;
               }



               foreach (var item in Info_Guia.list_detalle_Guia)
               {
                   if (item.Cantidad_enviar == 0 || item.Cantidad_enviar == null)
                   {
                       msg = "Ingrese la cantidad de traspaso para el item : " + item.pr_descripcion + "  ";
                       return false;
                   }
               }



               foreach (var item in Info_Guia.list_detalle_Guia_Sin_OC)
               {
                   if (item.Cantidad_enviar == 0 || item.Cantidad_enviar == null)
                   {
                       msg = "Ingrese la cantidad de traspaso para el item : " + item.nom_producto + "  ";
                       return false;
                   }

               }        


               if (Info_Guia.IdEmpresa <= 0 && Info_Guia.IdSucursal_Partida <= 0 && Info_Guia.IdSucursal_Llegada <= 0)
               {
                   msg = "Error en la cabecera de fact uno de los PK es <=0";
                   throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validaciones", msg)) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };
               }


               if (Info_Guia.IdTransportista <= 0 )
               {
                   msg = "Erro en la cabecera de guia IdTransportista es <=0";
                   throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validaciones", msg)) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };
               }


               if (Info_Guia.IdMotivo_Traslado =="")
               {
                   msg = "Erro en la cabecera de IdMotivo_Traslado esta en blanco";
                   throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validaciones", msg)) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };
               }


               if (Info_Guia.list_detalle_Guia.Count == 0 && Info_Guia.list_detalle_Guia_Sin_OC.Count==0)
               {
                   msg = "la guia  no tiene detalle ";
                   throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validaciones", msg)) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };
               }

              

               /*--- Fin validaciones */


               /*--- corrigiendo data */

               Info_Guia.Estado = (string.IsNullOrEmpty(Info_Guia.Estado) == true) ? "A" : Info_Guia.Estado;
               Info_Guia.Fecha = Convert.ToDateTime(Info_Guia.Fecha.ToShortDateString());



               tb_sis_Documento_Tipo_Talonario_Bus busTalonario = new tb_sis_Documento_Tipo_Talonario_Bus();
               tb_sis_Documento_Tipo_Talonario_Info infoTalonario = new tb_sis_Documento_Tipo_Talonario_Info();
               tb_Sucursal_Bus Bus_Sucu = new tb_Sucursal_Bus();
               tb_Bodega_Bus Bus_bodega = new tb_Bodega_Bus();

               string mensajeDocumentoDupli = "";
               string cod_estable = "";
               string cod_pto_emision = "";

               Info_Guia.CodDocumentoTipo=Cl_Enumeradores.eTipoDocumento_Talonario.GUIA.ToString();


               // el objeto viene sin serie o sin # factura tomo el ultimo num de factura del talonario
               if (Info_Guia.IdEstablecimiento == "" || Info_Guia.IdEstablecimiento == null || Info_Guia.IdPuntoEmision == "" || Info_Guia.IdPuntoEmision == null
                   || Info_Guia.NumDocumento_Guia == "" || Info_Guia.NumDocumento_Guia == null)
               {


                   cod_estable = Bus_Sucu.Get_Cod_Establecimiento_x_Sucursal(Info_Guia.IdEmpresa,Convert.ToInt32(Info_Guia.IdSucursal_Partida));
                   cod_pto_emision = Bus_bodega.Get_cod_pto_emision_x_Bodega(Info_Guia.IdEmpresa,Convert.ToInt32(Info_Guia.IdSucursal_Partida), 1); // la tabla no tiene bodega 
                   infoTalonario = busTalonario.Get_Info_Primer_Documento_no_usado(Info_Guia.IdEmpresa, cod_pto_emision, cod_estable, Info_Guia.CodDocumentoTipo, Info_Guia.Es_electronica);

                   if (infoTalonario.NumDocumento == null)
                   {
                       msg = "No hay talonarios para Establecimiento=" + cod_estable + " y punto de emision=" + cod_pto_emision;
                       throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "no hay talonario activos", msg)) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };
                   }

                   Info_Guia.IdEstablecimiento = infoTalonario.Establecimiento;
                   Info_Guia.IdPuntoEmision = infoTalonario.PuntoEmision;
                   Info_Guia.NumDocumento_Guia = infoTalonario.NumDocumento;

               }
               else
               {

                   // se puede dar si mas de un usario estan haciendo la factura y tienen en memoria o en la pantalla el mismo talonario
                   //verifico el numero de factura si esta usado
                   infoTalonario.Establecimiento = Info_Guia.IdEstablecimiento;
                   infoTalonario.PuntoEmision = Info_Guia.IdPuntoEmision;
                   infoTalonario.NumDocumento = Info_Guia.NumDocumento_Guia;
                   infoTalonario.IdEmpresa = Info_Guia.IdEmpresa;
                   infoTalonario.CodDocumentoTipo = Info_Guia.CodDocumentoTipo;
                   infoTalonario.es_Documento_electronico = Info_Guia.Es_electronica;


                   if (busTalonario.Documento_talonario_esta_Usado(infoTalonario, ref msg, ref mensajeDocumentoDupli))
                   {
                       //si esta en usado busco el siguiente
                       cod_estable = Bus_Sucu.Get_Cod_Establecimiento_x_Sucursal(Info_Guia.IdEmpresa, Convert.ToInt32(Info_Guia.IdSucursal_Partida));
                       cod_pto_emision = Bus_bodega.Get_cod_pto_emision_x_Bodega(Info_Guia.IdEmpresa,Convert.ToInt32(Info_Guia.IdPuntoEmision), 1);

                       infoTalonario = busTalonario.Get_Info_Primer_Documento_no_usado(Info_Guia.IdEmpresa, cod_pto_emision, cod_estable, Info_Guia.CodDocumentoTipo, Info_Guia.Es_electronica);

                       if (infoTalonario.NumDocumento == null)
                       {
                           throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "no hay talonario activos", msg)) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };
                       }

                       Info_Guia.IdEstablecimiento = infoTalonario.Establecimiento;
                       Info_Guia.IdPuntoEmision = infoTalonario.PuntoEmision;
                       Info_Guia.NumDocumento_Guia = infoTalonario.NumDocumento;
                   }
               }


               /*--- corrigiendo data */

               #endregion

               return true;

           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_y_corregir_objeto", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };


           }
       }

       public in_Guia_x_traspaso_bodega_Info Get_Info_x_in_Guia(int IdEmpresa, decimal IdGuia)
       {
           try
           {
               return odata.Get_Info_x_in_Guia(IdEmpresa, IdGuia);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };

           }
       }

       private List<guiaRemision> Get_Xml_Guia_x_Traspaso(int IdEmpresa, decimal IdGuia )
       {
           try
           {
               
               tb_Bodega_Bus Bus_Bodega = new tb_Bodega_Bus();
               tb_Bodega_Info Info_Bodega = new tb_Bodega_Info();

               in_Guia_x_traspaso_bodega_Info Info_Guia = new in_Guia_x_traspaso_bodega_Info();
               Info_Guia = Get_Info_x_in_Guia(IdEmpresa, IdGuia);

               Info_Bodega = Bus_Bodega.Get_Info_Bodega(IdEmpresa,Convert.ToInt32(Info_Guia.IdSucursal_Partida), 1);

               List<guiaRemision> listaaux = new List<guiaRemision>();
               List<guiaRemision> lista = new List<guiaRemision>();
               guiaRemisionDestinatarios destinatarios = new guiaRemisionDestinatarios();
               guiaRemision myObject = new guiaRemision();


               myObject.destinatarios = destinatarios;
               destinatarios.destinatario = new List<destinatario>();
               destinatario destinatari = new destinatario();
               destinatarioDetalles destinatariodet = new destinatarioDetalles();
               destinatari.detalles = destinatariodet;
               destinatari.detalles.detalle = new List<detalle>();
               
               string correo = "";
               string format = "dd/MM/yyyy";



                       myObject.id = guiaRemisionID.comprobante;
                       myObject.version = "1.1.0";
                       myObject.id = guiaRemisionID.comprobante;
                       infoTributaria info = new infoTributaria();
                       myObject.infoGuiaRemision = new guiaRemisionInfoGuiaRemision();
                       //información tributaria
                       myObject.infoTributaria = info;
                       info.ambiente = "1";
                       myObject.infoTributaria.tipoEmision = "1";

                       myObject.infoTributaria.razonSocial =string.IsNullOrEmpty(Info_Guia.razon_social_empresa)?"": Info_Guia.razon_social_empresa.Trim();
                       myObject.infoTributaria.nombreComercial =string.IsNullOrEmpty(Info_Guia.nom_comercial_empresa)?"": Info_Guia.nom_comercial_empresa.Trim();
                       myObject.infoTributaria.ruc = Info_Guia.ruc_empresa;
                       
                       myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                       myObject.infoTributaria.codDoc = "06";
                       myObject.infoTributaria.estab = Convert.ToString(Info_Guia.IdEstablecimiento);
                       myObject.infoTributaria.ptoEmi = Info_Guia.IdPuntoEmision;
                       myObject.infoTributaria.secuencial = Info_Guia.NumDocumento_Guia;

                       myObject.infoTributaria.dirMatriz =string.IsNullOrEmpty(Info_Guia.direc_empresa)?"": Info_Guia.direc_empresa.Trim();
                       //datos de la guía de remisión
                       myObject.infoGuiaRemision.dirEstablecimiento = string.IsNullOrEmpty(Info_Guia.Direc_sucu_Partida) ? "" : Info_Guia.Direc_sucu_Partida.Trim();
                       myObject.infoGuiaRemision.dirPartida = string.IsNullOrEmpty(Info_Guia.Direc_sucu_Partida) ? "" : Info_Guia.Direc_sucu_Partida.Trim();

                       myObject.infoGuiaRemision.razonSocialTransportista = string.IsNullOrEmpty(Info_Guia.nom_transportista) ? "" : Info_Guia.nom_transportista.Trim();
                       myObject.infoGuiaRemision.tipoIdentificacionTransportista = "05";
                       myObject.infoGuiaRemision.rucTransportista = Info_Guia.ced_transportista;
                       myObject.infoGuiaRemision.placa = Info_Guia.Placa;
                      

               //        myObject.infoGuiaRemision.obligadoContabilidad = (Info_Guia.obligado_conta_empresa == "SI" || Info_Guia.obligado_conta_empresa=="S") ?"S":"N";
                 //      myObject.infoGuiaRemision.contribuyenteEspecial = Info_Guia.contrib_especial_empresa;


                       myObject.infoGuiaRemision.fechaIniTransporte = Info_Guia.Fecha_Traslado.ToString(format);
                       myObject.infoGuiaRemision.fechaFinTransporte = Info_Guia.Fecha_llegada.ToString(format);
                      
                       
                       //datos del destinatario
                       destinatari.identificacionDestinatario = Info_Guia.ruc_empresa;
                       destinatari.razonSocialDestinatario =string.IsNullOrEmpty(Info_Guia.razon_social_empresa)?"": Info_Guia.razon_social_empresa.Trim();
                       destinatari.dirDestinatario =string.IsNullOrEmpty(Info_Guia.direc_empresa)?"": Info_Guia.direc_empresa.Trim();
                       destinatari.motivoTraslado =string.IsNullOrEmpty(Info_Guia.nom_Motivo_Traslado)?"": Info_Guia.nom_Motivo_Traslado.Trim();
                       //destinatari.ruta = "";

                    //destinatari.detalles.detalle
                    //myObject.infoGuiaRemision
                    //para extraer el detalle de la hoja, multiples lineas de producto

                       in_Guia_x_traspaso_bodega_det_Bus BusDetalle_Guia = new in_Guia_x_traspaso_bodega_det_Bus();
                       List<in_Guia_x_traspaso_bodega_det_Info> ListInfoDetalle_Guia = new List<in_Guia_x_traspaso_bodega_det_Info>();
                       ListInfoDetalle_Guia=BusDetalle_Guia.Get_List_Guia_x_traspaso_bodega_x_OC_det(IdEmpresa, IdGuia);

                       //if (ListInfoDetalle_Guia.Count() > 0)
                       //{
                           foreach (var item in ListInfoDetalle_Guia)
                           {
                               detalle det = new detalle();
                               det.codigoInterno = item.IdProducto.ToString();
                               det.codigoAdicional = item.pr_codigo;
                               det.descripcion = item.nom_producto.Trim() + (item.obs_OCompra == null ? "" : item.obs_OCompra.Trim()) + "(OC#" + item.IdOrdenCompra + ")";
                               det.cantidad = Convert.ToDecimal(item.Cantidad_enviar);
                               destinatari.detalles.detalle.Add(det);
                           }
                       //}
                       //else
                       //{

                           in_Guia_x_traspaso_bodega_det_sin_oc_Bus BusDetalle_Guia_SOC = new in_Guia_x_traspaso_bodega_det_sin_oc_Bus();
                           List<in_Guia_x_traspaso_bodega_det_sin_oc_Info> ListInfoDetalle_Guia_SOC = new List<in_Guia_x_traspaso_bodega_det_sin_oc_Info>();
                           ListInfoDetalle_Guia_SOC = BusDetalle_Guia_SOC.Get_List_Guia_x_traspaso_bodega_det_sin_oc(IdEmpresa, IdGuia);

                           foreach (var item in ListInfoDetalle_Guia_SOC)
                           {
                               detalle det = new detalle();
                               det.codigoInterno = (item.IdProducto == null) ? item.Num_Fact : Convert.ToDecimal(item.IdProducto).ToString();
                               det.codigoAdicional = item.Num_Fact;
                               det.descripcion = item.nom_producto.Trim() + (item.observacion == null ? "" : item.observacion.Trim()) + "(Prove:" + item.nom_proveedor + ")";
                               det.cantidad = Convert.ToDecimal(item.Cantidad_enviar);
                               destinatari.detalles.detalle.Add(det);
                           }
                       //}



                   //campos adicionales guía de remisión
                   guiaRemisionCampoAdicional compoadicional = new guiaRemisionCampoAdicional();
                   Cl_ValidarEmail_Info datosAdc = new Cl_ValidarEmail_Info();
                   if (datosAdc.email_bien_escrito(correo) == true)
                   {
                       compoadicional.nombre = "MAIL";
                       compoadicional.Value = correo;
                       myObject.infoAdicional = new List<guiaRemisionCampoAdicional>();
                       myObject.infoAdicional.Add(compoadicional);
                   }
                   //punto de llegada
                   if (Info_Guia.Direc_sucu_Llegada != "")                                                   //(dtrcabGuiaRe.IsDBNull(27) == false)
                   {
                       compoadicional = new guiaRemisionCampoAdicional();
                       compoadicional.nombre = "DESTINO";
                       compoadicional.Value =string.IsNullOrEmpty(Info_Guia.Direc_sucu_Llegada)?"": Info_Guia.Direc_sucu_Llegada;
                       myObject.infoAdicional = new List<guiaRemisionCampoAdicional>();
                       myObject.infoAdicional.Add(compoadicional);
                   }

                   destinatarios.destinatario.Add(destinatari);
                   lista.Add(myObject);

               return lista; ;

           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerParaGuiaRemision", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_Bus) };
           }

       }

       public Boolean Generar_Guardar_Xml_Guia_x_Traspaso(int IdEmpresa, decimal IdGuia, ref string msg)
       {
           try
           {
               string sIdCbte_x_Guia = "";

               string RutaDescarga = "";
               fa_parametro_Bus BusParamxFac = new fa_parametro_Bus();
               fa_parametro_info InfoParamxFac = new fa_parametro_info();

               InfoParamxFac = BusParamxFac.Get_Info_parametro(IdEmpresa);
               RutaDescarga =  InfoParamxFac.pa_ruta_descarga_xml_fac_elct;
              

              if (string.IsNullOrEmpty(RutaDescarga) == false)
              {
                  List<guiaRemision> lista = new List<guiaRemision>();
                  lista = Get_Xml_Guia_x_Traspaso(IdEmpresa, IdGuia);

                  if (lista.Count != 0)
                  {
                      foreach (var item in lista)
                      {

                        //  RutaDescarga = "";
                          sIdCbte_x_Guia = item.infoTributaria.razonSocial.Substring(0, 3) + "-" + Cl_Enumeradores.eTipoCodComprobante.GUI + "-" + item.infoTributaria.estab + "-" + item.infoTributaria.ptoEmi + "-" + item.infoTributaria.secuencial;
                          XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                          NamespaceObject.Add("", "");
                          XmlSerializer mySerializer = new XmlSerializer(typeof(guiaRemision));
                          StreamWriter myWriter = new StreamWriter(RutaDescarga + sIdCbte_x_Guia + ".xml");
                          mySerializer.Serialize(myWriter, item, NamespaceObject);
                          myWriter.Close();
                      }
                  }

                  return true;
              }
              else
              {
                  msg = "No hay ruta para descarga del archivo.";
                  return false;
              }
           }
           catch (Exception ex)
           {
               msg = ex.ToString();
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GenerarXml_notaCreDeb", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
           }
       }
    
   
   }
}
