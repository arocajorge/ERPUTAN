using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Bancos;
namespace Core.Erp.Data.Academico
{
   public class Aca_Pre_Facturacion_det_Data
   {
       string MensajeError = "";
       public bool Guardar_DB(List<Aca_Pre_Facturacion_det_Info> lista)
       {
           try
           {
               using (Entities_Academico db = new Entities_Academico())
               {
                   foreach (var item in lista)
                   {
                       Aca_Pre_Facturacion_det add = new Aca_Pre_Facturacion_det();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.secuencia = item.secuencia;
                       add.IdInstitucion_contra = item.IdInstitucion_contra;
                       add.IdContrato = item.IdContrato;
                       add.IdRubro = item.IdRubro;
                       add.IdInstitucion_Per = item.IdInstitucion_Per;
                       add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.IdProducto=item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.vt_Precio = item.vt_Precio;
                       add.vt_PorDescUnitario = item.vt_PorDescUnitario;
                       add.vt_DescUnitario = item.vt_DescUnitario;
                       add.vt_PrecioFinal = item.vt_PrecioFinal;
                       add.vt_Subtotal=item.vt_Subtotal;
                       add.vt_iva_valor = item.vt_iva_valor;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.observacion_det=item.observacion_det;
                       db.Aca_Pre_Facturacion_det.Add(add);
                       db.SaveChanges();

                   }
                   return true;

               }
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }

       public bool ActualizarDB(Aca_Pre_Facturacion_det_Info info, ref string mensaje)
       {
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var vInstitucion = Base.Aca_Pre_Facturacion_det.FirstOrDefault(o => o.IdInstitucion == info.IdInstitucion && o.IdPreFacturacion == info.IdPreFacturacion && o.Secuencia_Proce == info.Secuencia_Proce && o.secuencia ==info.secuencia );

                   if (vInstitucion != null)
                   {
                       vInstitucion.IdEmpresa_fac = info.IdEmpresa_fac;
                       vInstitucion.IdSucursal_fac = info.IdSucursal_fac;
                       vInstitucion.IdBodega_fac = info.IdBodega_fac;
                       vInstitucion.IdCbteVta_fac = info.IdCbteVta_fac;
                       
                       Base.SaveChanges();
                       mensaje = "Se ha procedido actualizar la Institución #: " + info.IdInstitucion.ToString() + " exitosamente.";
                   }
               }
               return true;
           }

           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
       public List<Aca_Pre_Facturacion_det_Info> Get_list(int IdInstitucion, int IdPrefacturacion)
       {
           try
           {
               List<Aca_Pre_Facturacion_det_Info> lista = new List<Aca_Pre_Facturacion_det_Info>();


               using (Entities_Academico Context = new Entities_Academico())
               {

                   var contact = from q in Context.vwAca_Pre_Facturacion_det
                                 where q.IdInstitucion == IdInstitucion
                                 && q.IdPreFacturacion == IdPrefacturacion

                                 select q;

                   foreach (var item in contact)
                   {
                       Aca_Pre_Facturacion_det_Info add = new Aca_Pre_Facturacion_det_Info();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.secuencia = item.secuencia;
                       add.IdInstitucion_contra = item.IdInstitucion_contra;
                       add.IdContrato = item.IdContrato;
                       add.IdRubro = item.IdRubro;
                       add.IdInstitucion_Per = item.IdInstitucion_Per;
                       add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.IdProducto = item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.vt_Precio = item.vt_Precio;
                       add.vt_PorDescUnitario = item.vt_PorDescUnitario;
                       add.vt_DescUnitario = item.vt_DescUnitario;
                       add.vt_PrecioFinal = item.vt_PrecioFinal;
                       add.vt_Subtotal = item.vt_Subtotal;
                       add.vt_iva_valor = item.vt_iva_valor;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.observacion_det = item.observacion_det;
                       add.pe_cedulaRuc = item.pe_cedulaRuc;
                       add.pe_nombre = item.pe_nombre;
                       add.pe_apellido = item.pe_apellido;
                       add.pe_nombreCompleto = item.pe_apellido+" "+item.pe_nombre;


                       add.Descripcion_paralelo = item.Descripcion_paralelo;
                       add.Descripcion_cur = item.Descripcion_cur;
                       add.Descripcion_secc = item.Descripcion_secc;
                       add.Descripcion_Jor = item.Descripcion_Jor;



                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
         
       public bool Eliminar(Aca_Pre_Facturacion_det_Info info)
       {
           try
           {
               int secuencia = 0;
               using (Entities_Academico db = new Entities_Academico())
               {

                   db.Database.ExecuteSqlCommand("delete Fj_servindustrias.Aca_Pre_Facturacion_det where IdEmpresa='" + info.IdInstitucion + "' and IdNomina_Tipo='" + info.IdPreFacturacion + "' ");

               }
               return true;
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }

       public List<Aca_Pre_Facturacion_det_Info> Get_list_Pre_Fact_a_Fecturar(int IdInstitucion, int IdPrefacturacion)
       {
           try
           {
               List<Aca_Pre_Facturacion_det_Info> lista = new List<Aca_Pre_Facturacion_det_Info>();


               using (Entities_Academico Context = new Entities_Academico())
               {

                   var contact = from q in Context.vwAca_Pre_Facturacion_det_A_Facturar
                                 where q.IdInstitucion == IdInstitucion
                                 && q.IdPreFacturacion == IdPrefacturacion

                                 select q;

                   foreach (var item in contact)
                   {
                       Aca_Pre_Facturacion_det_Info add = new Aca_Pre_Facturacion_det_Info();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.IdInstitucion_contra = item.IdInstitucion_contra;
                       add.IdContrato = item.IdContrato;
                       add.IdRubro = item.IdRubro;
                       add.IdInstitucion_Per = item.IdInstitucion_Per;
                       add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.IdProducto = item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.IdCliente = item.IdCliente;
                       add.IdVendedor = item.IdVendedor;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.pe_cedulaRuc = item.pe_cedulaRuc;
                       add.pe_nombre = item.pe_nombre;
                       add.pe_apellido = item.pe_apellido;
                       add.pe_nombreCompleto = item.pe_nombreCompleto;
                       add.vt_Subtotal =Convert.ToDouble( item.vt_Subtotal);
                       add.vt_total =Convert.ToDouble( item.vt_total);
                       add.vt_Precio =Convert.ToDouble( item.vt_Precio);
                       add.vt_PrecioFinal =Convert.ToDouble( item.vt_PrecioFinal);
                       add.nom_GrupoFe = item.nom_GrupoFe;
                       add.IdParentesco_cat = item.IdParentesco_cat;
                       add.IdEstudiante = item.IdEstudiante;
                       add.IdFamiliar = item.IdFamiliar;
                       add.IdCentroCosto_ct = item.IdCentroCosto_ct;
                       add.Secuencia_Proce = item.Secuencia_Proce;
                       add.secuencia = item.secuencia;
                        


                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }





       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
           try
           {
               List<ba_Archivo_Transferencia_Det_Info> lista = new List<ba_Archivo_Transferencia_Det_Info>();


               using (Entities_Academico Context = new Entities_Academico())
               {

                   var contact = from q in Context.vwAca_Pre_Facturacion_det_Generar_Archivo_Banco
                                 where q.IdInstitucion == IdInstitucion
                                 && q.IdSede == Idsede
                                 && q.IdAnioLectivo_Per == IdAnioLectivo
                                 && q.IdPeriodo_Per==IdPeriodo
                                 && q.IdBanco==IdBanco
                                 &&q.IdDocumento_Bancario==IdDocumento

                                 select q;

                   foreach (var item in contact)
                   {
                       ba_Archivo_Transferencia_Det_Info add = new ba_Archivo_Transferencia_Det_Info();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.IdInstitucion_contra = item.IdInstitucion_contra;
                       add.IdContrato = item.IdContrato;
                       add.IdRubro_col = item.IdRubro;
                       add.IdInstitucion_Per = item.IdInstitucion_Per;
                       add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.IdRubro_Col = item.IdRubro;
                       add.IdProducto = item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.pe_cedulaRuc = item.pe_cedulaRuc;
                       add.pe_nombre = item.pe_nombre;
                       add.pe_apellido = item.pe_apellido;
                       add.pe_nombreCompleto = item.pe_nombreCompleto;
                       add.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                       add.vt_total = Convert.ToDouble(item.vt_total);
                       add.vt_Precio = Convert.ToDouble(item.vt_Precio);
                       add.vt_PrecioFinal = Convert.ToDouble(item.vt_PrecioFinal);
                       add.Fecha = DateTime.Now;
                       add.observacion_det = item.observacion_det;
                       add.Numero_Documento = item.Numero_Documento;
                       add.IdTipoDocumento = item.IdTipoDocumento;
                       add.Tipo_documento_cat = item.Tipo_documento_cat;
                       add.Descripcion_paralelo = item.Descripcion_paralelo;
                       add.Descripcion_cur = item.Descripcion_cur;
                       add.Descripcion_secc = item.Descripcion_secc;
                       add.Descripcion_Jor = item.Descripcion_Jor;
                       add.IdEstudiante_Col = item.IdEstudiante;

                       add.IdPreFacturacion_col = item.IdPreFacturacion;
                       add.Secuencia_Proce_col = item.Secuencia_Proce;
                       add.secuencia_col = item.secuencia;
                       add.codigo_unico_estudiante = item.codigo_unico_estudiante;

                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int IdAnioLectivo, int IdPeriodo, int IdBanco, string IdProceso_Bancario_Tipo)
       {
           try
           {
               List<ba_Archivo_Transferencia_Det_Info> lista = new List<ba_Archivo_Transferencia_Det_Info>();


               using (Entities_Academico Context = new Entities_Academico())
               {

                   var contact = from q in Context.vwAca_Pre_Facturacion_det_Generar_Archivo_Banco
                                 where q.IdInstitucion == IdInstitucion
                                 && q.IdSede == Idsede
                                 && q.IdAnioLectivo_Per == IdAnioLectivo
                                 && q.IdPeriodo_Per == IdPeriodo
                                 && q.IdBanco == IdBanco
                                 && q.idProceso_Bancario_Tipo == IdProceso_Bancario_Tipo
                                 && q.saldos < 0
                                 select q;

                   foreach (var item in contact)
                   {
                       ba_Archivo_Transferencia_Det_Info add = new ba_Archivo_Transferencia_Det_Info();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdInstitucion_Col = item.IdInstitucion;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.IdInstitucion_contra = item.IdInstitucion_contra;
                       
                       add.IdContrato = item.IdContrato;
                       add.IdRubro_col = item.IdRubro;
                       add.IdInstitucion_Per = item.IdInstitucion_Per;
                       add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.IdRubro_Col = item.IdRubro;
                       add.IdProducto = item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.pe_cedulaRuc = item.pe_cedulaRuc;
                       add.pe_nombre = item.pe_nombre;
                       add.pe_apellido = item.pe_apellido;
                       add.pe_nombreCompleto = item.pe_nombreCompleto;
                       add.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                       add.vt_total = Convert.ToDouble(item.vt_total);
                       add.vt_Precio = Convert.ToDouble(item.vt_Precio);
                       add.vt_PrecioFinal = Convert.ToDouble(item.vt_PrecioFinal);
                       add.Fecha = DateTime.Now;
                       add.observacion_det = item.observacion_det;
                       add.Numero_Documento = item.Numero_Documento;
                       add.IdTipoDocumento = item.IdTipoDocumento;
                       add.Tipo_documento_cat = item.Tipo_documento_cat;
                       add.Descripcion_paralelo = item.Descripcion_paralelo;
                       add.Descripcion_cur = item.Descripcion_cur;
                       add.Descripcion_secc = item.Descripcion_secc;
                       add.Descripcion_Jor = item.Descripcion_Jor;
                       add.IdEstudiante_Col = item.IdEstudiante;

                       add.IdPreFacturacion_col = item.IdPreFacturacion;
                       add.Secuencia_Proce_col = item.Secuencia_Proce;
                       add.secuencia_col = item.secuencia;
                       add.codigo_unico_estudiante = item.codigo_unico_estudiante;

                       add.Valor = Convert.ToDecimal(item.vt_total);
                      

                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
       public List<ba_Archivo_Transferencia_Det_Info> Get_listGarantizados_Rubro_Pension(int IdInstitucion, int Idsede, int IdAnioLectivo, int IdPeriodo, int IdBanco, string IdProceso_Bancario_Tipo)
       {
           try
           {
               List<ba_Archivo_Transferencia_Det_Info> lista = new List<ba_Archivo_Transferencia_Det_Info>();


               using (Entities_Academico Context = new Entities_Academico())
               {

                   var contact = from q in Context.vwAca_Generar_Archivo_Banco_Garantizados
                                 where q.IdInstitucion == IdInstitucion
                                 && q.IdSede == Idsede
                                 && q.IdAnioLectivo == IdAnioLectivo
                                 //&& q.IdPeriodo_Per == IdPeriodo
                                 && q.IdBanco == IdBanco
                                 && q.idProceso_Bancario_Tipo == IdProceso_Bancario_Tipo
                                 && q.concepto_estado_cuenta == "PENSION"
                                 //&& q.saldos < 0
                                 select q;

                   foreach (var item in contact)
                   {
                       ba_Archivo_Transferencia_Det_Info add = new ba_Archivo_Transferencia_Det_Info();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdInstitucion_Col = item.IdInstitucion;
                       //add.IdPreFacturacion = item.IdPreFacturacion;
                       //add.IdInstitucion_contra = item.IdInstitucion_contra;

                       add.IdContrato = item.IdContrato;
                       add.IdRubro_col = Convert.ToInt16(item.IdRubro);
                       
                       //add.IdInstitucion_Per = item.IdInstitucion_Per;
                       //add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       //add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdAnioLectivo_Col = item.IdAnioLectivo;
                      

                       
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.IdRubro_Col = Convert.ToInt16(item.IdRubro);
                       add.concepto_estado_cuenta = item.concepto_estado_cuenta;

                       add.IdProducto = item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.pe_cedulaRuc = item.pe_cedulaRuc;
                       add.pe_nombre = item.pe_nombre;
                       add.pe_apellido = item.pe_apellido;
                       add.pe_nombreCompleto = item.pe_nombreCompleto;
                       add.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                       add.vt_total = Convert.ToDouble(item.vt_total);
                       add.vt_Precio = Convert.ToDouble(item.vt_Precio);
                       add.vt_PrecioFinal = Convert.ToDouble(item.vt_PrecioFinal);
                       add.Fecha = DateTime.Now;
                       add.observacion_det = item.Descripcion_rubro;
                       add.Numero_Documento = item.Numero_Documento;
                       add.IdTipoDocumento = item.IdTipoDocumento;
                       add.Tipo_documento_cat = item.Tipo_documento_cat;
                       add.Descripcion_paralelo = item.Descripcion_paralelo;
                       add.Descripcion_cur = item.Descripcion_cur;
                       add.Descripcion_secc = item.Descripcion_secc;
                       add.Descripcion_Jor = item.Descripcion_Jor;
                       add.IdEstudiante_Col = item.IdEstudiante;

                       //add.IdPreFacturacion_col = item.IdPreFacturacion;
                       //add.Secuencia_Proce_col = item.Secuencia_Proce;
                       //add.secuencia_col = item.secuencia;
                       add.codigo_unico_estudiante = item.codigo_unico_estudiante;

                       add.Valor = Convert.ToDecimal(item.vt_total);


                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }


       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int IdAnioLectivo, int IdPeriodo, int IdBanco, string IdProceso_Bancario_Tipo, int esta_en_Archivo)
       {
           try
           {
               List<ba_Archivo_Transferencia_Det_Info> lista = new List<ba_Archivo_Transferencia_Det_Info>();


               using (Entities_Academico Context = new Entities_Academico())
               {

                   var contact = from q in Context.vwAca_Pre_Facturacion_det_Generar_Archivo_Banco
                                 where q.IdInstitucion == IdInstitucion
                                 && q.IdSede == Idsede
                                 && q.IdAnioLectivo_Per == IdAnioLectivo
                                 && q.IdPeriodo_Per == IdPeriodo
                                 && q.IdBanco == IdBanco
                                 && q.idProceso_Bancario_Tipo == IdProceso_Bancario_Tipo
                                 && q.esta_en_archivo == esta_en_Archivo
                                 && q.saldos < 0
                                 select q;

                   foreach (var item in contact)
                   {
                       ba_Archivo_Transferencia_Det_Info add = new ba_Archivo_Transferencia_Det_Info();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdInstitucion_Col = item.IdInstitucion;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.IdInstitucion_contra = item.IdInstitucion_contra;

                       add.IdContrato = item.IdContrato;
                       add.IdRubro_col = item.IdRubro;
                       add.IdInstitucion_Per = item.IdInstitucion_Per;
                       add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.concepto_estado_cuenta = item.concepto_estado_cuenta;
                       add.IdRubro_Col = item.IdRubro;
                       add.IdProducto = item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.pe_cedulaRuc = item.pe_cedulaRuc;
                       add.pe_nombre = item.pe_nombre;
                       add.pe_apellido = item.pe_apellido;
                       add.pe_nombreCompleto = item.pe_nombreCompleto;
                       add.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                       add.vt_total = Convert.ToDouble(item.vt_total);
                       add.vt_Precio = Convert.ToDouble(item.vt_Precio);
                       add.vt_PrecioFinal = Convert.ToDouble(item.vt_PrecioFinal);
                       add.Fecha = DateTime.Now;
                       add.observacion_det = item.observacion_det;
                       add.Numero_Documento = item.Numero_Documento;
                       add.IdTipoDocumento = item.IdTipoDocumento;
                       add.Tipo_documento_cat = item.Tipo_documento_cat;
                       add.Descripcion_paralelo = item.Descripcion_paralelo;
                       add.Descripcion_cur = item.Descripcion_cur;
                       add.Descripcion_secc = item.Descripcion_secc;
                       add.Descripcion_Jor = item.Descripcion_Jor;
                       add.IdEstudiante_Col = item.IdEstudiante;

                       add.IdPreFacturacion_col = item.IdPreFacturacion;
                       add.Secuencia_Proce_col = item.Secuencia_Proce;
                       add.secuencia_col = item.secuencia;
                       add.codigo_unico_estudiante = item.codigo_unico_estudiante;

                       add.Valor = Convert.ToDecimal(item.vt_total);
                       add.Saldo = Convert.ToDecimal(item.saldos);


                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int idjornada, int idseccion, int idcurso, int idparalelo, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
           try
           {
               List<ba_Archivo_Transferencia_Det_Info> lista = new List<ba_Archivo_Transferencia_Det_Info>();


               using (Entities_Academico Context = new Entities_Academico())
               {

                   var contact = from q in Context.vwAca_Pre_Facturacion_det_Generar_Archivo_Banco
                                 where q.IdInstitucion == IdInstitucion
                                 && q.IdSede == Idsede
                                 &&q.IdJornada==idjornada
                                 &&q.IdSeccion==idseccion
                                 &&q.IdCurso==idcurso
                                 &&q.IdParalelo==idparalelo
                                 && q.IdAnioLectivo_Per == IdAnioLectivo
                                 && q.IdPeriodo_Per == IdPeriodo
                                 && q.IdBanco == IdBanco
                                 && q.IdDocumento_Bancario == IdDocumento


                                 select q;

                   foreach (var item in contact)
                   {
                       ba_Archivo_Transferencia_Det_Info add = new ba_Archivo_Transferencia_Det_Info();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.IdInstitucion_contra = item.IdInstitucion_contra;
                       add.IdContrato = item.IdContrato;
                       add.IdRubro_col = item.IdRubro;
                       add.IdInstitucion_Per = item.IdInstitucion_Per;
                       add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.concepto_estado_cuenta = item.concepto_estado_cuenta;
                       add.IdRubro_Col = item.IdRubro;
                       add.IdProducto = item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.pe_cedulaRuc = item.pe_cedulaRuc;
                       add.pe_nombre = item.pe_nombre;
                       add.pe_apellido = item.pe_apellido;
                       add.pe_nombreCompleto = item.pe_nombreCompleto;
                       add.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                       add.vt_total = Convert.ToDouble(item.vt_total);
                       add.vt_Precio = Convert.ToDouble(item.vt_Precio);
                       add.vt_PrecioFinal = Convert.ToDouble(item.vt_PrecioFinal);
                       add.Fecha = DateTime.Now;
                       add.observacion_det = item.observacion_det;
                       add.Numero_Documento = item.Numero_Documento;
                       add.IdTipoDocumento = item.IdTipoDocumento;
                       add.Tipo_documento_cat = item.Tipo_documento_cat;
                       add.Descripcion_paralelo = item.Descripcion_paralelo;
                       add.Descripcion_cur = item.Descripcion_cur;
                       add.Descripcion_secc = item.Descripcion_secc;
                       add.Descripcion_Jor = item.Descripcion_Jor;
                       add.IdEstudiante_Col = item.IdEstudiante;

                       add.IdPreFacturacion_col = item.IdPreFacturacion;
                       add.Secuencia_Proce_col = item.Secuencia_Proce;
                       add.secuencia_col = item.secuencia;
                       add.codigo_unico_estudiante = item.codigo_unico_estudiante;

                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int idjornada, int idseccion, int idcurso, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
           try
           {
               List<ba_Archivo_Transferencia_Det_Info> lista = new List<ba_Archivo_Transferencia_Det_Info>();


               using (Entities_Academico Context = new Entities_Academico())
               {

                   var contact = from q in Context.vwAca_Pre_Facturacion_det_Generar_Archivo_Banco
                                 where q.IdInstitucion == IdInstitucion
                                 && q.IdSede == Idsede
                                 && q.IdJornada == idjornada
                                 && q.IdSeccion == idseccion
                                 && q.IdCurso == idcurso
                                 && q.IdAnioLectivo_Per == IdAnioLectivo
                                 && q.IdPeriodo_Per == IdPeriodo
                                 && q.IdBanco == IdBanco
                                 && q.IdDocumento_Bancario == IdDocumento


                                 select q;

                   foreach (var item in contact)
                   {
                       ba_Archivo_Transferencia_Det_Info add = new ba_Archivo_Transferencia_Det_Info();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.IdInstitucion_contra = item.IdInstitucion_contra;
                       add.IdContrato = item.IdContrato;
                       add.IdRubro_col = item.IdRubro;
                       add.IdInstitucion_Per = item.IdInstitucion_Per;
                       add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.concepto_estado_cuenta = item.concepto_estado_cuenta;
                       add.IdRubro_Col = item.IdRubro;
                       add.IdProducto = item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.pe_cedulaRuc = item.pe_cedulaRuc;
                       add.pe_nombre = item.pe_nombre;
                       add.pe_apellido = item.pe_apellido;
                       add.pe_nombreCompleto = item.pe_nombreCompleto;
                       add.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                       add.vt_total = Convert.ToDouble(item.vt_total);
                       add.vt_Precio = Convert.ToDouble(item.vt_Precio);
                       add.vt_PrecioFinal = Convert.ToDouble(item.vt_PrecioFinal);
                       add.Fecha = DateTime.Now;
                       add.observacion_det = item.observacion_det;
                       add.Numero_Documento = item.Numero_Documento;
                       add.IdTipoDocumento = item.IdTipoDocumento;
                       add.Tipo_documento_cat = item.Tipo_documento_cat;
                       add.Descripcion_paralelo = item.Descripcion_paralelo;
                       add.Descripcion_cur = item.Descripcion_cur;
                       add.Descripcion_secc = item.Descripcion_secc;
                       add.Descripcion_Jor = item.Descripcion_Jor;
                       add.IdEstudiante_Col = item.IdEstudiante;

                       add.IdPreFacturacion_col = item.IdPreFacturacion;
                       add.Secuencia_Proce_col = item.Secuencia_Proce;
                       add.secuencia_col = item.secuencia;
                       add.codigo_unico_estudiante = item.codigo_unico_estudiante;

                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int idjornada, int idseccion, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
           try
           {
               List<ba_Archivo_Transferencia_Det_Info> lista = new List<ba_Archivo_Transferencia_Det_Info>();


               using (Entities_Academico Context = new Entities_Academico())
               {

                   var contact = from q in Context.vwAca_Pre_Facturacion_det_Generar_Archivo_Banco
                                 where q.IdInstitucion == IdInstitucion
                                 && q.IdSede == Idsede
                                 && q.IdJornada == idjornada
                                 && q.IdSeccion == idseccion
                                 && q.IdAnioLectivo_Per == IdAnioLectivo
                                 && q.IdPeriodo_Per == IdPeriodo
                                 && q.IdBanco == IdBanco
                                 && q.IdDocumento_Bancario == IdDocumento


                                 select q;

                   foreach (var item in contact)
                   {
                       ba_Archivo_Transferencia_Det_Info add = new ba_Archivo_Transferencia_Det_Info();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.IdInstitucion_contra = item.IdInstitucion_contra;
                       add.IdContrato = item.IdContrato;
                       add.IdRubro_col = item.IdRubro;
                       add.IdInstitucion_Per = item.IdInstitucion_Per;
                       add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.concepto_estado_cuenta = item.concepto_estado_cuenta;
                       add.IdRubro_Col = item.IdRubro;
                       add.IdProducto = item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.pe_cedulaRuc = item.pe_cedulaRuc;
                       add.pe_nombre = item.pe_nombre;
                       add.pe_apellido = item.pe_apellido;
                       add.pe_nombreCompleto = item.pe_nombreCompleto;
                       add.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                       add.vt_total = Convert.ToDouble(item.vt_total);
                       add.vt_Precio = Convert.ToDouble(item.vt_Precio);
                       add.vt_PrecioFinal = Convert.ToDouble(item.vt_PrecioFinal);
                       add.Fecha = DateTime.Now;
                       add.observacion_det = item.observacion_det;
                       add.Numero_Documento = item.Numero_Documento;
                       add.IdTipoDocumento = item.IdTipoDocumento;
                       add.Tipo_documento_cat = item.Tipo_documento_cat;
                       add.Descripcion_paralelo = item.Descripcion_paralelo;
                       add.Descripcion_cur = item.Descripcion_cur;
                       add.Descripcion_secc = item.Descripcion_secc;
                       add.Descripcion_Jor = item.Descripcion_Jor;
                       add.IdEstudiante_Col = item.IdEstudiante;

                       add.IdPreFacturacion_col = item.IdPreFacturacion;
                       add.Secuencia_Proce_col = item.Secuencia_Proce;
                       add.secuencia_col = item.secuencia;

                       add.IdPreFacturacion_col = item.IdPreFacturacion;
                       add.Secuencia_Proce_col = item.Secuencia_Proce;
                       add.secuencia_col = item.secuencia;
                       add.codigo_unico_estudiante = item.codigo_unico_estudiante;

                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int Idsede, int idjornada, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
           try
           {
               List<ba_Archivo_Transferencia_Det_Info> lista = new List<ba_Archivo_Transferencia_Det_Info>();


               using (Entities_Academico Context = new Entities_Academico())
               {

                   var contact = from q in Context.vwAca_Pre_Facturacion_det_Generar_Archivo_Banco
                                 where q.IdInstitucion == IdInstitucion
                                 && q.IdSede == Idsede
                                 && q.IdJornada == idjornada
                                 && q.IdAnioLectivo_Per == IdAnioLectivo
                                 && q.IdPeriodo_Per == IdPeriodo
                                 && q.IdBanco == IdBanco
                                 && q.IdDocumento_Bancario == IdDocumento


                                 select q;

                   foreach (var item in contact)
                   {
                       ba_Archivo_Transferencia_Det_Info add = new ba_Archivo_Transferencia_Det_Info();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.IdInstitucion_contra = item.IdInstitucion_contra;
                       add.IdContrato = item.IdContrato;
                       add.IdRubro_col = item.IdRubro;
                       add.IdInstitucion_Per = item.IdInstitucion_Per;
                       add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.concepto_estado_cuenta = item.concepto_estado_cuenta;
                       add.IdRubro_Col = item.IdRubro;
                       add.IdProducto = item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.pe_cedulaRuc = item.pe_cedulaRuc;
                       add.pe_nombre = item.pe_nombre;
                       add.pe_apellido = item.pe_apellido;
                       add.pe_nombreCompleto = item.pe_nombreCompleto;
                       add.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                       add.vt_total = Convert.ToDouble(item.vt_total);
                       add.vt_Precio = Convert.ToDouble(item.vt_Precio);
                       add.vt_PrecioFinal = Convert.ToDouble(item.vt_PrecioFinal);
                       add.Fecha = DateTime.Now;
                       add.observacion_det = item.observacion_det;
                       add.Numero_Documento = item.Numero_Documento;
                       add.IdTipoDocumento = item.IdTipoDocumento;
                       add.Tipo_documento_cat = item.Tipo_documento_cat;
                       add.Descripcion_paralelo = item.Descripcion_paralelo;
                       add.Descripcion_cur = item.Descripcion_cur;
                       add.Descripcion_secc = item.Descripcion_secc;
                       add.Descripcion_Jor = item.Descripcion_Jor;
                       add.IdEstudiante_Col = item.IdEstudiante;

                       add.IdPreFacturacion_col = item.IdPreFacturacion;
                       add.Secuencia_Proce_col = item.Secuencia_Proce;
                       add.secuencia_col = item.secuencia;
                       add.codigo_unico_estudiante = item.codigo_unico_estudiante;

                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
       public List<ba_Archivo_Transferencia_Det_Info> Get_list_Generar_Archivo_Banco_Det(int IdInstitucion, int IdAnioLectivo, int IdPeriodo, int IdBanco, int IdDocumento)
       {
           try
           {
               List<ba_Archivo_Transferencia_Det_Info> lista = new List<ba_Archivo_Transferencia_Det_Info>();


               using (Entities_Academico Context = new Entities_Academico())
               {

                   var contact = from q in Context.vwAca_Pre_Facturacion_det_Generar_Archivo_Banco
                                 where q.IdInstitucion == IdInstitucion
                                 && q.IdAnioLectivo_Per == IdAnioLectivo
                                 && q.IdPeriodo_Per == IdPeriodo
                                 && q.IdBanco == IdBanco
                                 && q.IdDocumento_Bancario == IdDocumento


                                 select q;

                   foreach (var item in contact)
                   {
                       ba_Archivo_Transferencia_Det_Info add = new ba_Archivo_Transferencia_Det_Info();
                       add.IdInstitucion = item.IdInstitucion;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.IdInstitucion_contra = item.IdInstitucion_contra;
                       add.IdContrato = item.IdContrato;
                       add.IdRubro_col = item.IdRubro;
                       add.IdInstitucion_Per = item.IdInstitucion_Per;
                       add.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                       add.IdPeriodo_Per = item.IdPeriodo_Per;
                       add.IdGrupoFE = item.IdGrupoFE;
                       add.concepto_estado_cuenta = item.concepto_estado_cuenta;
                       add.IdRubro_Col = item.IdRubro;
                       add.IdProducto = item.IdProducto;
                       add.vt_cantidad = item.vt_cantidad;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                       add.pe_cedulaRuc = item.pe_cedulaRuc;
                       add.pe_nombre = item.pe_nombre;
                       add.pe_apellido = item.pe_apellido;
                       add.pe_nombreCompleto = item.pe_nombreCompleto;
                       add.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                       add.vt_total = Convert.ToDouble(item.vt_total);
                       add.vt_Precio = Convert.ToDouble(item.vt_Precio);
                       add.vt_PrecioFinal = Convert.ToDouble(item.vt_PrecioFinal);
                       add.Fecha = DateTime.Now;
                       add.observacion_det = item.observacion_det;
                       add.Numero_Documento = item.Numero_Documento;
                       add.IdTipoDocumento = item.IdTipoDocumento;
                       add.Tipo_documento_cat = item.Tipo_documento_cat;
                       add.Descripcion_paralelo = item.Descripcion_paralelo;
                       add.Descripcion_cur = item.Descripcion_cur;
                       add.Descripcion_secc = item.Descripcion_secc;
                       add.Descripcion_Jor = item.Descripcion_Jor;
                       add.IdEstudiante_Col = item.IdEstudiante;

                       add.IdPreFacturacion_col = item.IdPreFacturacion;
                       add.Secuencia_Proce_col = item.Secuencia_Proce;
                       add.secuencia_col = item.secuencia;
                       add.codigo_unico_estudiante = item.codigo_unico_estudiante;

                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
     
    }
}
