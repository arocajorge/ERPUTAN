using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Data.Produccion_Edehsa;
using Core.Erp.Info.Produccion_Edehsa;

using Core.Erp.Info.class_sri.GuiaRemision;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri;


namespace Core.Erp.Business.Facturacion
{
    public class fa_guia_remision_Bus
    {

        string mensaje = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        fa_guia_remision_Data oData = new fa_guia_remision_Data();
        fa_guia_remision_det_x_fa_orden_Desp_det_Data GuiaxOrdeData = new fa_guia_remision_det_x_fa_orden_Desp_det_Data();

        public List<fa_guia_remision_Info> Get_List_guia_remision(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin
           , DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oData.Get_List_guia_remision(idEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLista", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
               
            }
            
        }

        public Boolean ActualizarEstado(int idempresa, fa_guia_remision_Info oGuia)
        {
            try
            {
                return oData.ActualizarEstado(idempresa, oGuia);
            }
            catch (Exception ex )
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstado", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }
        }

        public Boolean Validar_Objeto(fa_guia_remision_Info info,ref string msg)
        {
            try
            {
                Boolean res=true;

                if (info.IdEmpresa == 0 || info.IdSucursal == 0 || info.IdBodega == 0 || info.IdCliente == 0)
                {
                    msg = "el IdEmpresa==0 o info.IdSucursal == 0  info.IdBodega == 0 || info.IdCliente == 0) son cero estos son PK no pueden ser cero ";
                    res = false;
                }

                if (info.ListaDetalle.Count == 0)
                {
                    msg = "la guia de remision no tiene items ";
                    res = false;
                }


                return res;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_Objeto", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }
        }

        /// <summary>
        /// Esta funcion tiene reglanes de negocio dependiendo del cliente 
        /// graba cab y det de guia de remision fa_guia_remision y fa_guia_remision_det
        /// </summary>
        /// <param name="info">info de guia de remision donde debe de estar lleno tanto cabecera como detalle hay validacion de q si no se envia detalle rebota
        /// </param>
        /// <param name="id"> secuencial de sistema q retorna luego de grabar </param>
        /// <param name="msg">variable de mensaje en caso de novedad</param>
        /// <returns></returns>

        public Boolean GrabarDB(fa_guia_remision_Info info, ref decimal id, ref string numDocFactu, ref string msg)
        {
            try
            {
                Boolean res = true;
                
                if (Validar_Objeto(info,ref msg))
                {
                    //grabacion general de guia de remision
                    res = oData.GrabarDB(info, ref id, ref msg);
                    /////////////////////////////////////
                    if (res)//grabando detalle
                    {
                        fa_guia_remision_det_bus BusDetGuia = new fa_guia_remision_det_bus();
                        res = BusDetGuia.GuardarDB(info.ListaDetalle);
                    }


                }
                else
                {
                    res =false;
                }
                

                return res;


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }

        }

        public Boolean VerificarCodigo(string Codigo, int idempresa)
        {
            try
            {
                return oData.VerificarCodigo(Codigo, idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarCodigo", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }

        }

        public Boolean ModificarDB(fa_guia_remision_Info info, ref string msg)
        {
            try
            {
              return oData.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }

        }

        public Boolean Imprimir(fa_guia_remision_Info info, ref  string msg)
        {
            try
            {
               return oData.Imprimir(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Imprimir", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }

        }

        public Boolean VerificarNumguia(fa_guia_remision_Info info)
        {
            try
            {
                return oData.VerificarNumguia(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarNumguia", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }
            
        }

        public fa_guia_remision_Info ConsultaIdGuiaRemision(fa_orden_Desp_Info Info)
        {
            try
            {
              return oData.Get_Info_guia_remision(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaIdGuiaRemision", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }

        }

        public List<fa_guia_remision_Info> Get_List_guia_remision(int idEmpresa, int idSucursal, int idBodega, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return oData.Get_List_guia_remision(idEmpresa, idSucursal, idBodega, fechaIni, fechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerParaFactura", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }
            
        }

        public fa_guia_remision_Info Get_Info_guia_remision(int idEmpresa, int idSucursal, int idBodega, decimal idGuir)
        {
            try
            {
                return oData.Get_Info_guia_remision(idEmpresa, idSucursal, idBodega, idGuir);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerParaFacturaGuir", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }
            
        }

        public List<Info.class_sri.GuiaRemision.guiaRemision> GenerarXmlGuiaRemision(List<vwprd_Guia_Remision_Electronica_Info> LstGuia_Remision_Electronica_Info)
        {
            try
            {
                char pad_Cero = '0';


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
                int cont = 0;
                string correo = "";

                foreach (var item in LstGuia_Remision_Electronica_Info)
                {

                    if (cont == 0)
                    {
                        cont = 1;
                        myObject.id = guiaRemisionID.comprobante;
                        myObject.version = "1.1.0";
                        myObject.id = guiaRemisionID.comprobante;
                        infoTributaria info = new infoTributaria();
                        myObject.infoGuiaRemision = new guiaRemisionInfoGuiaRemision();
                        // myObject.destinatarios = new guiaRemisionDestinatarios();
                        //información tributaria
                        myObject.infoTributaria = info;
                        info.ambiente = "1";
                        myObject.infoTributaria.tipoEmision = "1";
                        myObject.infoTributaria.razonSocial = item.RazonSocial;
                        myObject.infoTributaria.nombreComercial = item.NombreComercial;
                        myObject.infoTributaria.ruc = item.em_ruc;
                        myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                        myObject.infoTributaria.codDoc = item.CodDocumentoTipo;
                        myObject.infoTributaria.estab = Convert.ToString(item.IdSucursal).PadLeft(3, pad_Cero);              //dtrcabGuiaRe.GetString(1).Substring(0, 3);//001 x tener una sola sucursale -  coger codigo tb_sucursal

                        myObject.infoTributaria.ptoEmi = Convert.ToString(item.IdSucursal).PadLeft(3, pad_Cero);             //dtrcabGuiaRe.GetString(1).Substring(3, 3);//001 x tener una sola punto de venta o caja
                        myObject.infoTributaria.secuencial = Convert.ToString(item.IdGuiaRemision).PadLeft(9,pad_Cero);     // dtrcabGuiaRe.GetString(1).Substring(6, 9);

                        myObject.infoTributaria.dirMatriz = item.em_direccion;                          //dtrcabGuiaRe.GetString(6);//tb_empresa
                        //datos de la guía de remisión
                        myObject.infoGuiaRemision.dirEstablecimiento = item.Su_Direccion;               //dtrcabGuiaRe.GetString(6);//tb_empresa
                        myObject.infoGuiaRemision.dirPartida = item.Direccion_Origen;                   //dtrcabGuiaRe.GetString(7);
                        myObject.infoGuiaRemision.razonSocialTransportista = item.Nombre_Transportista; //dtrcabGuiaRe.GetString(8);//tb_persona
                        myObject.infoGuiaRemision.tipoIdentificacionTransportista = "05";               //dtrcabGuiaRe.GetString(9);//ficha sri que tipo de ID-CC pendiente
                        myObject.infoGuiaRemision.rucTransportista = item.Cedula_Transportista;         //dtrcabGuiaRe.GetString(10);//tb_persona
                        myObject.infoGuiaRemision.obligadoContabilidad = item.ObligadoAllevarConta;     //obliconta;//tb_empresa - conversion S por SI o N por NO
                        myObject.infoGuiaRemision.contribuyenteEspecial = item.ContribuyenteEspecial;   //contspecia;
                        myObject.infoGuiaRemision.fechaIniTransporte = Convert.ToString(item.gi_FechaIniTraslado);          //dtrcabGuiaRe.GetString(11);
                        myObject.infoGuiaRemision.fechaFinTransporte = Convert.ToString(item.gi_FechaFinTraslado);          //dtrcabGuiaRe.GetString(12);
                        myObject.infoGuiaRemision.placa = item.placa;                                                       //dtrcabGuiaRe.GetString(13);
                        //datos del destinatario
                        destinatari.identificacionDestinatario = item.pe_cedulaRuc;                     //dtrcabGuiaRe.GetString(15);
                        destinatari.razonSocialDestinatario = item.pe_razonSocial;                      //dtrcabGuiaRe.GetString(16);
                        destinatari.dirDestinatario = item.pe_direccion;                                //dtrcabGuiaRe.GetString(17);
                        destinatari.motivoTraslado = item.descripcion_motivo_traslado;                  //dtrcabGuiaRe.GetString(18);
                        destinatari.ruta = item.ruta;                                                   //dtrcabGuiaRe.GetString(19);
                        // si la guia de remision tiene factura 




                    }

                    //para extraer el detalle de la hoja, multiples lineas de producto
                    detalle det = new detalle();
                    det.codigoInterno = item.pr_codigo;                                                 //dtrcabGuiaRe.GetString(21);
                    det.codigoAdicional = item.pr_descripcion;                                          //dtrcabGuiaRe.GetString(22);
                    det.descripcion = item.pr_descripcion_2;                                            //dtrcabGuiaRe.GetString(23);
                    det.cantidad = Convert.ToDecimal(item.gi_cantidad);                                 //Convert.ToDecimal(dtrcabGuiaRe.GetDouble(24));
                    // DETALLES ADICIONALES
                    det.detallesAdicionales = new List<detalleDetAdicional>();
                    detalleDetAdicional DtelleAd = new detalleDetAdicional();
                    DtelleAd.nombre = item.unidad_medida_consumo;                                       //dtrcabGuiaRe.GetString(25);
                    DtelleAd.valor = item.unidad_medida_consumo;                                       //dtrcabGuiaRe.GetString(25);
                    det.detallesAdicionales.Add(DtelleAd);
                    destinatari.detalles.detalle.Add(det);




                    if (item.pe_correo != null)
                    {
                        correo = item.pe_correo;                                                        //dtrcabGuiaRe.GetString(26);
                    }
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
                    if (item.Direccion_Destino != "")                                                   //(dtrcabGuiaRe.IsDBNull(27) == false)
                    {
                        compoadicional = new guiaRemisionCampoAdicional();
                        compoadicional.nombre = "DESTINO";
                        compoadicional.Value = item.Direccion_Destino;
                        myObject.infoAdicional = new List<guiaRemisionCampoAdicional>();
                        myObject.infoAdicional.Add(compoadicional);
                    }
                    //Obra de referencia
                    if (item.descripcion_obra != "")                                                    //(dtrcabGuiaRe.IsDBNull(28) == false)
                    {
                        compoadicional = new guiaRemisionCampoAdicional();
                        compoadicional.nombre = "OBRA";
                        compoadicional.Value = item.descripcion_obra;                                   //dtrcabGuiaRe.GetString(28);
                        myObject.infoAdicional = new List<guiaRemisionCampoAdicional>();
                        myObject.infoAdicional.Add(compoadicional);
                    }


                    destinatarios.destinatario.Add(destinatari);
                    lista.Add(myObject);
                }



                return lista; ;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerParaGuiaRemision", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }

        }

    }
}
