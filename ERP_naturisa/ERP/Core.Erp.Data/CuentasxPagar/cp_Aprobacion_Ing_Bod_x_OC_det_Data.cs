using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.CuentasxPagar
{
   public class cp_Aprobacion_Ing_Bod_x_OC_det_Data
    {
       string mensaje = "";     

       public Boolean GuardarDB(List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> LstInfo, ref string msg)
       {
           try
           {
               int sec = 0;

               foreach (var item in LstInfo)
               {
                   using (EntitiesCuentasxPagar OECxP = new EntitiesCuentasxPagar())
                   {
                       sec = sec + 1;

                       var Address = new cp_Aprobacion_Ing_Bod_x_OC_det();

                         Address.IdEmpresa = item.IdEmpresa;
                         Address.IdAprobacion= item.IdAprobacion;                     
                         Address.Secuencia = sec;
                         Address.IdEmpresa_Ing_Egr_Inv = item.IdEmpresa_Ing_Egr_Inv;
                         Address.IdSucursal_Ing_Egr_Inv = item.IdSucursal_Ing_Egr_Inv;
                         Address.IdMovi_inven_tipo_Ing_Egr_Inv = item.IdMovi_inven_tipo_Ing_Egr_Inv;
                         Address.IdNumMovi_Ing_Egr_Inv = item.IdNumMovi_Ing_Egr_Inv;
                         Address.Secuencia_Ing_Egr_Inv = item.Secuencia_Ing_Egr_Inv;
                         Address.Cantidad = item.Cantidad;
                         Address.Costo_uni = item.Costo_uni;
                         Address.Descuento = item.Descuento;
                         Address.SubTotal = item.SubTotal;
                         Address.PorIva = item.PorIva;
                         Address.valor_Iva = item.valor_Iva;
                         Address.Total = item.Total;
                         Address.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                         Address.IdCtaCble_IVA = item.IdCtaCble_IVA;                         
                         Address.IdCentro_Costo_x_Gasto_x_cxp = item.IdCentro_Costo;
                         Address.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo;


                       OECxP.cp_Aprobacion_Ing_Bod_x_OC_det.Add(Address);
                       OECxP.SaveChanges();
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
               throw new Exception(ex.InnerException.ToString());
           }
       }       

       public List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> Get_List_Aprobacion_Ing_Bod_x_OC_det(int IdEmpresa, decimal IdAprobacion)
       {
           List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> Lst = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
           EntitiesCuentasxPagar OECxP = new EntitiesCuentasxPagar();
           try
           {
                                      
               var Query = from q in OECxP.vwcp_Aprobacion_Ing_Bod_x_OC_det
                           where q.IdEmpresa == IdEmpresa && q.IdAprobacion== IdAprobacion                        
                           select q;
               foreach (var item in Query)
               {
                   cp_Aprobacion_Ing_Bod_x_OC_det_Info Obj = new cp_Aprobacion_Ing_Bod_x_OC_det_Info();
           
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdAprobacion = item.IdAprobacion;
                   Obj.Secuencia =item.Secuencia;
                   Obj.IdEmpresa_Ing_Egr_Inv = item.IdEmpresa_Ing_Egr_Inv;
                   Obj.IdSucursal_Ing_Egr_Inv = item.IdSucursal_Ing_Egr_Inv;
                   Obj.IdMovi_inven_tipo_Ing_Egr_Inv = item.IdMovi_inven_tipo_Ing_Egr_Inv;
                   Obj.IdNumMovi_Ing_Egr_Inv = item.IdNumMovi_Ing_Egr_Inv;
                   Obj.Secuencia_Ing_Egr_Inv = item.Secuencia_Ing_Egr_Inv;
                   Obj.Cantidad = item.Cantidad;
                   Obj.Costo_uni = item.Costo_uni;
                   Obj.Descuento = item.Descuento;
                   Obj.SubTotal = item.SubTotal;
                   Obj.PorIva = item.PorIva;
                   Obj.valor_Iva = item.valor_Iva;
                   Obj.Total = item.Total;
                   Obj.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                   Obj.IdCtaCble_IVA = item.IdCtaCble_IVA;
                   Obj.IdCentro_Costo = item.IdCentro_Costo_x_Gasto_x_cxp;
                   Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo_cxp;
                   Obj.IdSucursal_OC = item.IdSucursal_Ing_Egr_Inv;
                   Obj.nom_sucursal = item.nom_sucursal;

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
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> Get_List_Aprobacion_Ing_Bod_x_OC_det_x_Proveedor(int IdEmpresa, decimal IdProveedor)
       {
           try
           {
               List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> Lst = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
               EntitiesCuentasxPagar oEnti = new EntitiesCuentasxPagar();

               oEnti.SetCommandTimeOut(5000);

               var Query = oEnti.vwcp_Aprobacion_Ing_Bod_x_OC_det_PorAprobar.Where(q => q.idempresa == IdEmpresa
                           && q.IdProveedor == IdProveedor).ToList();

               foreach (var item in Query)
               {
                   Lst.Add(new cp_Aprobacion_Ing_Bod_x_OC_det_Info
                   {

                       IdEmpresa_Ing_Egr_Inv = item.idempresa,
                       IdSucursal_Ing_Egr_Inv = item.idsucursal,
                       IdMovi_inven_tipo_Ing_Egr_Inv = item.idmovi_inven_tipo,
                       IdNumMovi_Ing_Egr_Inv = item.IdNumMovi,
                       Secuencia_Ing_Egr_Inv = item.Secuencia,
                       IdBodega = item.IdBodega,
                       Fecha_Ing_Bod = item.cm_fecha,
                       IdProducto = item.IdProducto,
                       nom_producto = item.pr_descripcion,
                       Cantidad = item.dm_cantidad_sinConversion,
                       Costo_uni = item.mv_costo_sinConversion ?? 0,
                       //Campos para contabilizacion de Naturisa
                       IdCategoria = item.idcategoria,
                       IdLinea = item.IdLinea,
                       IdGrupo = item.IdGrupo,
                       IdSubGrupo = item.IdSubGrupo,
                       nom_bodega = item.bo_Descripcion,
                       nom_sucursal = item.su_descripcion,
                       do_porc_des = item.do_porc_des,
                       //Campos para el diario de gastos
                       IdCentro_Costo = item.idcentrocosto,
                       IdCentroCosto_sub_centro_costo = item.idcentrocosto_sub_centro_costo,
                       IdPunto_cargo_grupo = item.idpunto_cargo_grupo,
                       IdPunto_cargo = item.idpunto_cargo,
                       Secuencia_OC = item.Secuencia_oc,
                       IdSucursal_OC = item.IdSucursal_oc,
                       IdOrdenCompra = item.IdOrdenCompra,
                       PorIva = item.Por_Iva,
                       IdUnidadMedida = item.IdUnidadMedida_sinConversion,
                       //  nom_medida = item.nom_medida,
                       IdProveedor = item.IdProveedor,
                       nom_proveedor = item.pe_nombreCompleto,
                       Dias = item.oc_Plazo,
                       IdCtaCble_Gasto = item.IdCtaCble_Gasto,

                       /**
                       Obj.IdCtaCtble_Gasto_x_cxp_x_Produc = item.IdCtaCtble_Gasto_x_cxp_x_Produc;
                       Obj.IdCtaCble_Inven_x_Produc = item.IdCtaCble_Inven_x_Produc;
                       Obj.IdCtaCtble_Inve_x_Bodega = item.IdCtaCtble_Inve_x_Bodega;
                       Obj.IdCtaCble_Inven_x_Motivo = item.IdCtaCble_Inven_x_Motivo;
                       Obj.IdCtaCble_Costo_x_Motivo = item.IdCtaCble_Costo_x_Motivo;
                       ein_Inventario_O_Consumo Tipo_Inve_o_Consu;

                       try
                       {
                           Tipo_Inve_o_Consu = (ein_Inventario_O_Consumo)Enum.Parse(typeof(ein_Inventario_O_Consumo), item.es_Inven_o_Consumo);
                       }
                       catch (Exception ex)
                       {
                           Tipo_Inve_o_Consu = ein_Inventario_O_Consumo.TIC_INVEN;
                       }

                       Obj.S_es_Inven_o_Consumo = item.es_Inven_o_Consumo;
                       Obj.es_Inven_o_Consumo = Tipo_Inve_o_Consu;
                          */
                   });
               }

               return Lst;
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }


       }

       public Boolean EliminarDB(int IdEmpresa, decimal IdAprobacion, ref string msg)
       {
           try
           {
               using (EntitiesCuentasxPagar Entity = new EntitiesCuentasxPagar())
               {
                   int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete cp_Aprobacion_Ing_Bod_x_OC_det where IdEmpresa = " + IdEmpresa
                       + " and IdAprobacion = " + IdAprobacion);
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
               msg = "Error no se guardó " + ex.Message + " ";
               throw new Exception(ex.ToString());
           }
       }

       public  cp_Aprobacion_Ing_Bod_x_OC_det_Data(){}
    }
}
