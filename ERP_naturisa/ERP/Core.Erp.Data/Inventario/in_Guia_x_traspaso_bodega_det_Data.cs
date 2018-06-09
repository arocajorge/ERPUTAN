using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;
using Core.Erp.Info.Compras;

namespace Core.Erp.Data.Inventario
{
   public class in_Guia_x_traspaso_bodega_det_Data
    {

       string mensaje = "";
       public Boolean GuardarDB(List<in_Guia_x_traspaso_bodega_det_Info> LstInfo)
       {
           try
           {
               try
               {
                   int sec = 0;

                   foreach (var item in LstInfo)
                   {
                       using (EntitiesInventario Context = new EntitiesInventario())
                       {
                           sec = sec + 1;

                           var Address = new in_Guia_x_traspaso_bodega_det();

                           Address.IdEmpresa = item.IdEmpresa;
                           Address.IdGuia = item.IdGuia;
                           Address.secuencia = sec;
                           Address.IdEmpresa_OC = item.IdEmpresa_OC;
                           Address.IdSucursal_OC = item.IdSucursal_OC;
                           Address.IdOrdenCompra_OC = item.IdOrdenCompra_OC;
                           Address.Secuencia_OC = item.Secuencia_OC;
                           Address.observacion = item.observacion;
                           Address.Cantidad_enviar = item.Cantidad_enviar;
                           Address.Referencia = item.Referencia;

                           Context.in_Guia_x_traspaso_bodega_det.Add(Address);
                           Context.SaveChanges();

                       }
                   }

                   return true;
               }
               catch (DbEntityValidationException ex)
               {
                   string arreglo = ToString();
                   tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                   tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                   oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                   mensaje = ex.ToString() + " " + ex.Message;
                   mensaje = "Error al Grabar" + ex.Message;
                   throw new Exception(ex.ToString());
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean EliminarDB(int IdEmpresa,decimal IdGuia)
       {
           try
           {
              
               EntitiesInventario Oent = new EntitiesInventario();

               string Query = "delete  in_Guia_x_traspaso_bodega_det where IdEmpresa = " + IdEmpresa + "   and IdGuia= " + IdGuia + "";
             //  var Consulta = Oent.Database.SqlQuery<in_Guia_x_traspaso_bodega_det_Info>(Query);
               Oent.Database.ExecuteSqlCommand(Query);
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.ToString() + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }

       }

       public List<in_Guia_x_traspaso_bodega_det_Info> Get_List_Guia_x_traspaso_bodega_det(int IdEmpresa, decimal IdGuia)
       {
           List<in_Guia_x_traspaso_bodega_det_Info> Lst = new List<in_Guia_x_traspaso_bodega_det_Info>();
           EntitiesInventario oEnti = new EntitiesInventario();
           try
           {
               var Query = from q in oEnti.in_Guia_x_traspaso_bodega_det
                           where q.IdEmpresa == IdEmpresa && q.IdGuia == IdGuia
                           select q;
               foreach (var item in Query)
               {
                   in_Guia_x_traspaso_bodega_det_Info Obj = new in_Guia_x_traspaso_bodega_det_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdGuia = item.IdGuia;               
                   Obj.secuencia = item.secuencia;
                   Obj.IdEmpresa_OC = Convert.ToInt32(item.IdEmpresa_OC);
                   Obj.IdSucursal_OC = Convert.ToInt32(item.IdSucursal_OC);
                   Obj.IdOrdenCompra_OC = Convert.ToDecimal(item.IdOrdenCompra_OC);
                   Obj.Secuencia_OC = Convert.ToInt32(item.Secuencia_OC);
                   Obj.observacion = item.observacion;
                   Obj.Cantidad_enviar = Convert.ToDouble(item.Cantidad_enviar);
                   Obj.Referencia = item.Referencia;
                   Lst.Add(Obj);
               }
               return Lst;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }

       }

       public bool Existe_OC_en_guia(com_ordencompra_local_Info info_OC,ref string sGuiasRelacionadas)
       {
           try
           {
               bool respuesta = false;

               using (EntitiesInventario Context = new EntitiesInventario() )
               {
                   var lst = from q in Context.in_Guia_x_traspaso_bodega_det
                             where q.IdEmpresa_OC == info_OC.IdEmpresa
                             && q.IdSucursal_OC == info_OC.IdSucursal
                             && q.IdOrdenCompra_OC == info_OC.IdOrdenCompra
                             select q;

                   if (lst.Count() == 0)
                   {
                    respuesta=false;
                   }
                   else
                   {

                       foreach (var item in lst)
                       {
                           sGuiasRelacionadas = sGuiasRelacionadas + "; #"+ item.IdGuia;
                       }

                       respuesta = true;
                   }

                   return respuesta;
               }               
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public List<in_Guia_x_traspaso_bodega_det_Info> Get_List_Guia_x_traspaso_bodega_x_OC_det(int IdEmpresa, decimal IdGuia)
       {
           List<in_Guia_x_traspaso_bodega_det_Info> Lst = new List<in_Guia_x_traspaso_bodega_det_Info>();
           EntitiesInventario oEnti = new EntitiesInventario();
           try
           {
               var Query = from q in oEnti.vwin_Guia_x_traspaso_bodega_x_ordencompra_local_det
                           where q.IdEmpresa == IdEmpresa && q.IdGuia == IdGuia
                           select q;
               foreach (var item in Query)
               {
                   in_Guia_x_traspaso_bodega_det_Info Obj = new in_Guia_x_traspaso_bodega_det_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdGuia = item.IdGuia;
                   Obj.secuencia = item.secuencia;
                   Obj.IdEmpresa_OC = Convert.ToInt32(item.IdEmpresa_OC);
                   Obj.IdSucursal_OC = Convert.ToInt32(item.IdSucursal_OC);
                   Obj.IdOrdenCompra_OC = Convert.ToDecimal(item.IdOrdenCompra_OC);
                   Obj.Secuencia_OC = Convert.ToInt32(item.Secuencia_OC);
                   Obj.observacion = item.observacion;
                   Obj.Cantidad_enviar = Convert.ToDouble(item.Cantidad_enviar);
                   Obj.IdProducto = item.IdProducto;
                   Obj.IdPunto_cargo = item.IdPunto_cargo;
                   Obj.IdUnidadMedida = item.IdUnidadMedida;
                   Obj.pr_codigo = item.pr_codigo;
                   Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                   Obj.IdCentroCosto = item.IdCentroCosto;
                   Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                   Obj.do_precioCompra = item.do_precioCompra;
                   Obj.Referencia = item.Referencia;
                   Obj.cod_producto = item.cod_producto;
                   Obj.nom_producto = item.nom_producto;
                   Obj.obs_OCompra = item.obs_OCompra;
                   Obj.IdOrdenCompra = item.IdOrdenCompra;
                   Lst.Add(Obj);
               }
               return Lst;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }

       }

       public List<in_Guia_x_traspaso_bodega_det_Info> Get_List_Guia_x_traspaso_bodega_sin_transferencia_det(int IdEmpresa, decimal IdGuia)
       {
           List<in_Guia_x_traspaso_bodega_det_Info> Lst = new List<in_Guia_x_traspaso_bodega_det_Info>();
           EntitiesInventario oEnti = new EntitiesInventario();
           try
           {
               var Query = from q in oEnti.vwin_Guia_x_traspaso_bodega_det_sin_Transferencia
                           where q.IdEmpresa == IdEmpresa && q.IdGuia == IdGuia
                           select q;
               foreach (var item in Query)
               {
                   in_Guia_x_traspaso_bodega_det_Info Obj = new in_Guia_x_traspaso_bodega_det_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdGuia = item.IdGuia;
                   Obj.secuencia = item.secuencia;
                   Obj.IdEmpresa_OC = Convert.ToInt32(item.IdEmpresa_OC);
                   Obj.IdSucursal_OC = Convert.ToInt32(item.IdSucursal_OC);
                   Obj.IdOrdenCompra_OC = Convert.ToDecimal(item.IdOrdenCompra_OC);
                   Obj.Secuencia_OC = Convert.ToInt32(item.Secuencia_OC);
                   Obj.observacion = item.observacion;
                   Obj.Cantidad_enviar = Convert.ToDouble(item.Cantidad_enviar);
                   Obj.IdProducto = item.IdProducto;
                   Obj.IdPunto_cargo = item.IdPunto_cargo;
                   Obj.IdUnidadMedida = item.IdUnidadMedida;
                   Obj.pr_codigo = item.pr_codigo;
                   Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                   Obj.IdCentroCosto = item.IdCentroCosto;
                   Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                   Obj.do_precioCompra = item.do_precioCompra;


                   Lst.Add(Obj);
               }
               return Lst;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }

       }
    }
}
