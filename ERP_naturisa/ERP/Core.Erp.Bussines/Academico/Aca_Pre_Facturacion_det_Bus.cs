using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
namespace Core.Erp.Business.Academico
{
   public class Aca_Pre_Facturacion_det_Bus
   {
       cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

       Aca_Pre_Facturacion_det_Data data = new Aca_Pre_Facturacion_det_Data();
       List<Aca_Pre_Facturacion_det_Info> lista_a_facturar = new List<Aca_Pre_Facturacion_det_Info>();
       fa_factura_Bus bus_factura = new fa_factura_Bus();
       fa_parametro_info info_param = new fa_parametro_info();
       fa_parametro_Bus bus_fa_param = new fa_parametro_Bus();
       tb_sis_Documento_Tipo_Talonario_Bus bus_talonario = new tb_sis_Documento_Tipo_Talonario_Bus();
       tb_sis_Documento_Tipo_Talonario_Info info_talonario =new tb_sis_Documento_Tipo_Talonario_Info();
       fa_factura_aca_Info info_factura = new fa_factura_aca_Info();
       fa_factura_aca_Bus bus_factura_ACA = new fa_factura_aca_Bus();
       fa_parametro_Bus bus_partametro_fa = new fa_parametro_Bus();
       fa_parametro_info info_parametro_fa = new fa_parametro_info();
       
       public bool Guardar_DB(List<Aca_Pre_Facturacion_det_Info> lista)
       {
           try
           {

               return data.Guardar_DB(lista);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };
    

           }
       }
       public List<Aca_Pre_Facturacion_det_Info> Get_list(int IdInstitucion, int IdPrefacturacion)
       {
           try
           {

               return data.Get_list(IdInstitucion, IdPrefacturacion);

              
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };
     
           }
       }

       public bool Generar_Factura(Aca_Pre_Facturacion_det_Info info_afacturar)
       {
           try
           {
               info_parametro_fa = bus_partametro_fa.Get_Info_parametro(param.IdEmpresa);
               decimal idcomprobanteVta=0;
               string msg="";
               string numDoc = "";
               fa_factura_Info item=new fa_factura_Info();
               item=Get_convertir_Pre_Fact_A_Factuta(info_afacturar);
               // grabando FACTURA

               if (bus_factura.GuardarDB(item, ref idcomprobanteVta, ref numDoc, ref msg, ref msg))
                   {
                       // GRABANDO EN LA TABLA PERSONALIZADA
                       info_factura = new fa_factura_aca_Info();
                       info_factura.IdEmpresa = item.IdEmpresa;
                       info_factura.IdSucursal = item.IdSucursal;
                       info_factura.IdBodega = item.IdBodega;
                       info_factura.IdCbteVta = idcomprobanteVta;
                       info_factura.IdEstudiante = item.IdEstudiante;
                       info_factura.IdParentesco_cat = item.IdParentesco_cat;
                       info_factura.IdInstitucion = item.IdEmpresa;
                       info_factura.IdFamiliar = item.IdFamiliar;
                   
                       //info_factura.IdAnioLectivo =Convert.ToString( item.vt_anio);
                       info_factura.IdAnioLectivo = item.vt_anio;
                    
                       info_factura.IdPeriodo = item.IdPeriodo;
                       info_factura.IdRubro = item.IdRubro;
                        
                       bus_factura_ACA.GrabarDB(info_factura, ref msg);


                       
                       info_afacturar.IdEmpresa_fac = item.IdEmpresa;
                       info_afacturar.IdSucursal_fac = item.IdSucursal;
                       info_afacturar.IdBodega_fac = item.IdBodega;
                       info_afacturar.IdCbteVta_fac = idcomprobanteVta;

                       data.ActualizarDB(info_afacturar, ref msg);
                       // generar el xml 

                       bus_factura.GenerarXml_Factura(item.IdEmpresa, item.IdSucursal, item.IdBodega, idcomprobanteVta, @"C:\Xml\", ref msg);
                       //bus_factura.GenerarXml_Factura(item.IdEmpresa, item.IdSucursal, item.IdBodega, idcomprobanteVta,info_parametro_fa.pa_ruta_descarga_xml_fac_elct, ref msg);
                   }
               
               

            return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };

           }
       }

       private fa_factura_Info Get_convertir_Pre_Fact_A_Factuta(Aca_Pre_Facturacion_det_Info item)
       {
           try
           {           
                       // string stab = "001";
                       // string ptoem = "002";  
                       info_param = bus_fa_param.Get_Info_parametro(param.IdEmpresa);
                       //info_talonario = bus_talonario.Get_Info_Ult_Documento_no_usado(param.IdEmpresa, "001", "002", "FACT", true);
                       info_talonario = bus_talonario.Get_Info_Ult_Documento_no_usado(param.IdEmpresa,item.cod_PuntoVta_fact, item.Su_CodigoEstablecimiento, "FACT", true);
                      
                       fa_factura_Info info_fac = new fa_factura_Info();
                       info_fac.IdEmpresa = param.IdEmpresa;
                       //info_fac.IdSucursal = param.IdSucursal;
                       info_fac.IdSucursal = item.IdSucursal;
                       info_fac.IdCliente = item.IdCliente;
                       info_fac.IdVendedor = item.IdVendedor;
                       info_fac.IdBodega = Convert.ToInt16(item.IdBodega_fac) == 0 ? 1 : Convert.ToInt16(item.IdBodega_fac);
                       info_fac.IdCbteVta = info_fac.IdCbteVta;
                       info_fac.CodCbteVta = "";
                       info_fac.vt_tipo_venta = "CON";
                       info_fac.vt_tipoDoc = "FACT";
                        //BUSCAR ETABLECIMIENTO Y PUNTO DE EMISION DESDE LA PREFACTURACION
                       //info_fac.vt_serie1 = stab;
                       //info_fac.vt_serie2 = ptoem;
                       info_fac.vt_serie1 = item.Su_CodigoEstablecimiento;
                       info_fac.vt_serie2 = item.cod_PuntoVta_fact;
                       info_fac.IdPuntoVta = item.idPtoEmision;

                       info_fac.vt_NumFactura = info_talonario.NumDocumento;
                       info_fac.vt_fecha = DateTime.Now;//*********************************
                       info_fac.vt_plazo = item.cl_plazo;
                       info_fac.vt_fech_venc = DateTime.Now;//*********************************
                       info_fac.vt_Observacion = item.nom_GrupoFe;
                       info_fac.IdPeriodo = item.IdPeriodo_Per;
                       info_fac.vt_anio = Convert.ToInt32(item.IdAnioLectivo);
                       info_fac.vt_Observacion = "Factura # " + info_fac.vt_NumFactura+ " " + item.Descripcion_rubro;
                       info_fac.vt_flete = 0;
                       info_fac.vt_interes = 0;
                       info_fac.vt_seguro = 0;
                       info_fac.vt_OtroValor1 = 0;
                       info_fac.vt_OtroValor2 = 0;
                       info_fac.Estado = "A";
                       info_fac.IdCaja = info_param.IdCaja_Default_Factura;
                       info_fac.IdUsuario = param.IdUsuario;
                       info_fac.Fecha_Transaccion = DateTime.Now;
                       info_fac.IdEstudiante = item.IdEstudiante;
                       info_fac.IdParentesco_cat = item.IdParentesco_cat;
                       info_fac.IdFamiliar = item.IdFamiliar;

                       //info_factura.IdRubro = item.IdRubro;
                       info_fac.IdRubro = item.IdRubro;

                       // detalle
                       fa_factura_det_info info_det = new fa_factura_det_info();
                       info_det.IdEmpresa = param.IdEmpresa;
                       info_det.IdSucursal = item.IdSucursal;
                       info_det.vt_cantidad = 1;
                       info_det.Cant_Venta = 1;
                       info_det.IdBodega = Convert.ToInt16(item.IdBodega_fac) == 0 ? 1 : Convert.ToInt16(item.IdBodega_fac);
                       //info_det.IdBodega = Convert.ToInt16(item.IdBodega_fac);
                       info_det.IdProducto = Convert.ToDecimal(item.IdProducto);
                       info_det.Cant_Venta = item.vt_cantidad;
                       info_det.vt_Precio = item.vt_Precio;
                       info_det.vt_DescUnitario = item.vt_DescUnitario;
                       info_det.vt_PorDescUnitario = item.vt_PorDescUnitario;
                       info_det.vt_PrecioFinal = item.vt_PrecioFinal;
                       info_det.vt_Subtotal = item.vt_Subtotal;
                       info_det.vt_iva = item.vt_iva_valor;
                       info_det.vt_total = item.vt_total;
                       info_det.vt_estado = "A";
                       info_det.vt_detallexItems = item.nom_GrupoFe;
                       info_det.vt_Peso = 0;
                       info_det.vt_por_iva = 0;
                       info_det.IdCod_Impuesto_Iva = "IVA0";
                       info_det.IdRubro = item.IdRubro;

                       info_det.IdCentroCosto = item.IdCentroCosto_ct;
                        
                       // Forma de Pago
                       fa_factura_x_formaPago_Info info_forma_pago = new fa_factura_x_formaPago_Info();
                       info_forma_pago.IdEmpresa = param.IdEmpresa;
                       info_forma_pago.IdSucursal = item.IdSucursal;
                       info_forma_pago.IdBodega = Convert.ToInt16(item.IdBodega_fac) == 0 ? 1 : Convert.ToInt16(item.IdBodega_fac);
                       info_forma_pago.IdFormaPago = "20";
                       info_fac.lista_formaPago_x_Factura.Add(info_forma_pago);

                       // Termino de pago
                       fa_factura_x_fa_TerminoPago_Info info_ermino_pago = new fa_factura_x_fa_TerminoPago_Info();
                       info_ermino_pago.IdEmpresa = param.IdEmpresa;
                       info_ermino_pago.IdSucursal = item.IdSucursal;
                       info_forma_pago.IdBodega = Convert.ToInt16(item.IdBodega_fac) == 0 ? 1 : Convert.ToInt16(item.IdBodega_fac);
                       info_ermino_pago.IdTerminoPago = "CRE";
                       info_ermino_pago.Secuencia = 1;
                       info_ermino_pago.Dias_Plazo = 0;
                       info_ermino_pago.Fecha = info_fac.vt_fecha;
                       info_ermino_pago.Fecha_vct = info_fac.vt_fech_venc;
                       info_fac.DetformaPago_list.Add(info_ermino_pago);
                       info_fac.DetFactura_List.Add(info_det);




                       return info_fac;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };

           }
       }



       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
           try
           {

               return data.Get_list_Generar_Archivo_Banco_Det(IdInstitucion, Idsede, IdAnioLectivo, IdPeriodo, IdBanco, IdDocumento);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };


           }
       }
       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int IdAnioLectivo, int IdPeriodo, int IdBanco, string IdProceso_Bancario_Tipo)
       {
           try
           {

               return data.Get_list_Generar_Archivo_Banco_Det(IdInstitucion, Idsede, IdAnioLectivo, IdPeriodo, IdBanco, IdProceso_Bancario_Tipo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };


           }
       }
       public List<ba_Archivo_Transferencia_Det_Info> Get_listGarantizados_Rubro_Pension(int IdInstitucion, int Idsede, int IdAnioLectivo, int IdPeriodo, int IdBanco, string IdProceso_Bancario_Tipo)
       {
           try
           {

               return data.Get_listGarantizados_Rubro_Pension(IdInstitucion, Idsede, IdAnioLectivo, IdPeriodo, IdBanco, IdProceso_Bancario_Tipo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };


           }
       }


       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int IdAnioLectivo, int IdPeriodo, int IdBanco, string IdProceso_Bancario_Tipo, int esta_en_Archivo)
       {
           try
           {

               return data.Get_list_Generar_Archivo_Banco_Det(IdInstitucion, Idsede, IdAnioLectivo, IdPeriodo, IdBanco, IdProceso_Bancario_Tipo, esta_en_Archivo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };


           }
       }

       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int idjornada, int idseccion, int idcurso, int idparalelo, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
        
           try
           {

               return data.Get_list_Generar_Archivo_Banco_Det(IdInstitucion, Idsede, idjornada, idcurso, idparalelo, IdAnioLectivo, IdPeriodo, IdBanco, IdDocumento);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };


           }
       }


       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int idjornada, int idseccion, int idcurso, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
           try
           {

               return data.Get_list_Generar_Archivo_Banco_Det(IdInstitucion, Idsede, idjornada, idseccion, idcurso, IdAnioLectivo, IdPeriodo, IdBanco, IdDocumento);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };


           }
       }

       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int idjornada, int idseccion, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
           try
           {

               return data.Get_list_Generar_Archivo_Banco_Det(IdInstitucion, Idsede, idjornada, idseccion, IdAnioLectivo, IdPeriodo, IdBanco, IdDocumento);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };


           }
       }



       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int idjornada, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
           try
           {

               return data.Get_list_Generar_Archivo_Banco_Det(IdInstitucion, Idsede, idjornada, IdAnioLectivo, IdPeriodo, IdBanco, IdDocumento);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };


           }
       }



       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
           try
           {

               return data.Get_list_Generar_Archivo_Banco_Det(IdInstitucion, IdAnioLectivo, IdPeriodo, IdBanco, IdDocumento);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };


           }
       }
       public List<Aca_Pre_Facturacion_det_Info> Get_list_Pre_Fact_a_Fecturar(int IdInstitucion, int IdPrefacturacion)
       {
           try
           {

               return data.Get_list_Pre_Fact_a_Fecturar(IdInstitucion, IdPrefacturacion);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };


           }
       }

      
   }
}
