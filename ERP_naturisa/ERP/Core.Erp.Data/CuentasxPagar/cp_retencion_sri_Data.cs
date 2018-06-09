using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.class_sri.Retencion;

using Core.Erp.Info.class_sri.Factura;

using Core.Erp.Info.class_sri;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;



namespace Core.Erp.Data.CuentasxPagar
{
  public  class cp_retencion_sri_Data
    {


      //string campoAdicional = null;
      //string format = "dd/MM/yyyy";

      //public List<comprobanteRetencion> GenerarXmlRetencion(int IdEmpresa, decimal IdRetencion, ref string msg)
      //{

      //    try
      //    {
      //        List<comprobanteRetencion> lista = new List<comprobanteRetencion>();

      //        EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();


      //        var consulta = from selec in ECXP.vwcp_Retencion_sri
      //                       where selec.IdEmpresa == IdEmpresa
      //                              && selec.IdRetencion == IdRetencion
      //                       select selec;


      //        foreach (var item in consulta)
      //        {
      //            comprobanteRetencion myObjectRete = new comprobanteRetencion();


      //            myObjectRete.version = "1.0.0";
      //            myObjectRete.idSpecified = true;
      //            myObjectRete.infoTributaria = new infoTributaria();
      //            myObjectRete.infoCompRetencion = new comprobanteRetencionInfoCompRetencion();
      //            myObjectRete.impuestos = new List<Info.class_sri.Retencion.impuesto>();
      //            myObjectRete.infoTributaria.ambiente = "1";
      //            myObjectRete.infoTributaria.tipoEmision = "1";
      //            myObjectRete.infoTributaria.razonSocial = item.RazonSocial;  //empresa validar
      //            myObjectRete.infoTributaria.nombreComercial = item.NombreComercial; //empresa validar
      //            myObjectRete.infoTributaria.ruc = item.em_ruc; //empresa validar
      //            myObjectRete.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
      //            myObjectRete.infoTributaria.codDoc = "07";

      //            string[] serie = Convert.ToString(item.serie).Split('-');

      //            myObjectRete.infoTributaria.estab = serie[0].Trim();  // retencion
      //            myObjectRete.infoTributaria.ptoEmi = serie[1].Trim(); ; // retencion
                 

      //            myObjectRete.infoTributaria.secuencial = item.NumRetencion; // retencion validar ceros a la izquierda

      //            myObjectRete.infoTributaria.dirMatriz = item.em_direccion;  //empresa validar
             
                
      //            myObjectRete.infoCompRetencion.fechaEmision = item.co_FechaFactura.ToString(format); // factura
                     
                  
      //            myObjectRete.infoCompRetencion.dirEstablecimiento = item.pe_direccion; ///sucursal
      //            myObjectRete.infoCompRetencion.contribuyenteEspecial =item.ContribuyenteEspecial; //empresa   
      //            myObjectRete.infoCompRetencion.obligadoContabilidad = item.ObligadoAllevarConta;                      
                                            
      //            switch (item.IdTipoDocumento)
      //            {
      //                case "CED":
      //                    myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = "05";
      //                    break;
      //                case "PAS":
      //                     myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido ="06";
      //                    break;

      //                case "RUC":
      //                    myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = "04";
      //                    break;
      //                default:                       
      //                    break;
      //            }

      //            myObjectRete.infoCompRetencion.razonSocialSujetoRetenido = item.pe_razonSocial; // proveedor
      //            myObjectRete.infoCompRetencion.identificacionSujetoRetenido = item.pe_cedulaRuc;  // cedula o ruc
      //            myObjectRete.infoCompRetencion.periodoFiscal = Convert.ToString(myObjectRete.infoCompRetencion.fechaEmision).Substring(3, 7); // factura


      //            // consultar detalle Retencion

      //            cp_retencion_det_Data odata = new cp_retencion_det_Data();
      //            List<cp_retencion_det_Info> listaDetReten = new List<cp_retencion_det_Info>();

      //            listaDetReten = odata.ObtenerListRetencionReport(IdEmpresa, IdRetencion, ref msg);

      //            if (listaDetReten.Count !=0)
      //            {
                     
      //                foreach (var itemDET in listaDetReten)
      //                {
      //                     Info.class_sri.Retencion.impuesto imp = new Info.class_sri.Retencion.impuesto();

      //                    if(itemDET.re_tipoRet=="IVA")
      //                    {
      //                       imp.codigo = "2";


      //                       switch (Convert.ToString(itemDET.re_Porcen_retencion))
      //                       {
      //                           case "30":
      //                              imp.codigoRetencion = "1";
      //                              imp.porcentajeRetener =30;
      //                               break;
      //                           case "70":
      //                               imp.codigoRetencion = "2";
      //                               imp.porcentajeRetener = 70;
      //                               break;

      //                           case "100":
      //                                imp.codigoRetencion = "3";
      //                                imp.porcentajeRetener = 100;
      //                               break;
      //                           default:
      //                               break;
      //                       }                                                     
      //                    }

      //                    if (itemDET.re_tipoRet == "RTF")
      //                    {
      //                        imp.codigo = "1";
      //                        imp.codigoRetencion = itemDET.re_Codigo_impuesto;
      //                        imp.porcentajeRetener = Convert.ToDecimal(itemDET.re_Porcen_retencion);

      //                    }
                      
      //                    imp.baseImponible = Convert.ToDecimal(itemDET.re_baseRetencion);                       
      //                    imp.valorRetenido = Convert.ToDecimal(itemDET.re_valor_retencion);
      //                    imp.codDocSustento = item.IdOrden_giro_Tipo;   //si factura es 01 y 


                         
      //                    // para validar ceros a la izquierda
      //                    //string aux = "";
      //                    //string aux2 = "";
                                              
      //                    //if (item.co_factura.Length < 9)
      //                    //{
      //                    //    int conta = item.co_factura.Length;
      //                    //    int diferencia = 9 - conta;

      //                    //    aux = aux.PadLeft(diferencia, '0');
      //                    //    aux2 = aux + item.co_factura;

      //                    //}

                         
                                     
      //                    string[] serieFact = Convert.ToString(item.co_serie).Split('-');
                                                                 
      //                    imp.numDocSustento = serieFact[0].Trim() + serieFact[1].Trim() + Convert.ToString(item.co_factura).Trim();

      //                    myObjectRete.infoCompRetencion.fechaEmision = item.co_FechaFactura.ToString(format);
      //                    myObjectRete.impuestos.Add(imp);

      //                    //if (dtrDetalleRet.IsDBNull(8) == false)
      //                    //{
      //                    //    campoAdicional = dtrDetalleRet.GetString(8);
      //                    //}

      //                }
                                                          
      //            }


      //            // campos adicionales 

      //           // revisar
      //            //Cl_ValidarEmail_Info datosAdc = new Cl_ValidarEmail_Info();
      //            //if (datosAdc.email_bien_escrito(campoAdicional) == true)
      //            //{
      //            //    comprobanteRetencionCampoAdicional compoadicional = new comprobanteRetencionCampoAdicional();
      //            //    compoadicional.nombre = "MAIL";
      //            //    compoadicional.Value = campoAdicional;
      //            //    myObjectRete.infoAdicional = new List<comprobanteRetencionCampoAdicional>();
      //            //    myObjectRete.infoAdicional.Add(compoadicional);
      //            //}
                 
                 
      //            lista.Add(myObjectRete);
      //        }

      //        msg = "Archivo XML de Retención Generado con Exito";         
      //        return lista;
             
      //    }
      //    catch (Exception ex)
      //    {

      //        string arreglo = ToString();
      //         tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      //         tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
      //              "", "", "", "", DateTime.Now);
      //         oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
      //         msg = ex.InnerException + " " + ex.Message;
              
      //        return new List<comprobanteRetencion>();
      //    }               
      //}


      //public List<vwcp_Retencion_sri_Info> Get_list_Retencion_Sri(int IdEmpresa, decimal IdRetencion, ref string msg)
      //{
      //    try
      //    {
      //        List<vwcp_Retencion_sri_Info> lista = new List<vwcp_Retencion_sri_Info>();

      //        EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();


      //        var consulta = from selec in ECXP.vwcp_Retencion_sri
      //                       where selec.IdEmpresa == IdEmpresa
      //                              && selec.IdRetencion == IdRetencion
      //                       select selec;


      //        foreach (var item in consulta)
      //        {

      //            vwcp_Retencion_sri_Info info = new vwcp_Retencion_sri_Info();

      //               info.IdEmpresa =item.IdEmpresa;
      //               info.IdRetencion = item.IdRetencion;
      //               info.serie = item.serie;
      //               info.NumRetencion = item.NumRetencion;
      //               info.fecha = item.fecha;
      //               info.pe_nombreCompleto = item.pe_nombreCompleto;
      //               info.pe_razonSocial = item.pe_razonSocial;
      //               info.pe_cedulaRuc = item.pe_cedulaRuc;
      //               info.pe_correo = item.pe_correo;
      //               info.IdProveedor = item.IdProveedor;
      //               info.co_FechaFactura = item.co_FechaFactura;
      //               info.pe_direccion = item.pe_direccion;
      //               info.pe_telfono_Contacto = item.pe_telfono_Contacto;
      //               info.co_serie = item.co_serie;
      //               info.co_factura = item.co_factura;
      //               info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
      //               info.RazonSocial = item.RazonSocial;
      //               info.NombreComercial = item.NombreComercial;
      //               info.ContribuyenteEspecial = item.ContribuyenteEspecial;
      //               info.ObligadoAllevarConta = item.ObligadoAllevarConta;
      //               info.em_ruc = item.em_ruc;
      //               info.em_direccion = item.em_direccion;
      //               info.IdTipoDocumento = item.IdTipoDocumento;

      //            lista.Add(info);
      //        }

      //        return lista;

      //    }
      //    catch (Exception ex)
      //    {
      //        string arreglo = ToString();
      //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
      //             "", "", "", "", DateTime.Now);
      //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
      //        msg = ex.InnerException + " " + ex.Message;

      //        return new List<vwcp_Retencion_sri_Info>();
             
      //    }
      
      //}


    }
}
