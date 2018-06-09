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
               EntitiesInventario oEnti = new EntitiesInventario();

               var Query = from q in oEnti.vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det_x_cp_Aprobacion_Ing_Bod_x_OC_det
                           where q.IdEmpresa == IdEmpresa
                           && q.IdProveedor == IdProveedor
                           select q;

               foreach (var item in Query)
               {
                   cp_Aprobacion_Ing_Bod_x_OC_det_Info Obj = new cp_Aprobacion_Ing_Bod_x_OC_det_Info();

                   Obj.IdEmpresa_Ing_Egr_Inv = item.IdEmpresa;
                   Obj.IdSucursal_Ing_Egr_Inv = item.IdSucursal;
                   Obj.IdMovi_inven_tipo_Ing_Egr_Inv = Convert.ToInt32(item.IdMovi_inven_tipo);
                   Obj.IdNumMovi_Ing_Egr_Inv = item.IdNumMovi;
                   Obj.Secuencia_Ing_Egr_Inv = item.Secuencia;
                   Obj.IdBodega = item.IdBodega;
                   Obj.Fecha_Ing_Bod = (item.cm_fecha == null) ? DateTime.Now : Convert.ToDateTime(item.cm_fecha);
                   Obj.IdProducto = item.IdProducto;
                   Obj.nom_producto = item.nom_producto;
                   Obj.IdUnidadMedida = item.IdUnidadMedida;
                   Obj.nom_medida = item.nom_medida;
                   Obj.nom_bodega = item.nom_bodega;
                   Obj.nom_sucursal = item.nom_sucursal;                  
                   Obj.Cantidad = item.dm_cantidad;
                   Obj.Costo_uni = Convert.ToDouble((item.mv_costo==null)?0: item.mv_costo);
                   Obj.do_porc_des = item.do_porc_des;
                   Obj.PorIva = item.Por_Iva;                   
                   Obj.IdProveedor = item.IdProveedor;
                   Obj.nom_proveedor = item.nom_proveedor;
                   Obj.PorIva = item.Por_Iva;

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


                   Obj.IdCtaCtble_Gasto_x_cxp_x_Produc = item.IdCtaCtble_Gasto_x_cxp_x_Produc;
                   Obj.IdCtaCble_Inven_x_Produc = item.IdCtaCble_Inven_x_Produc;
                   Obj.IdCtaCtble_Inve_x_Bodega = item.IdCtaCtble_Inve_x_Bodega;
                   Obj.IdCtaCble_Inven_x_Motivo = item.IdCtaCble_Inven_x_Motivo;
                   Obj.IdCtaCble_Costo_x_Motivo = item.IdCtaCble_Costo_x_Motivo;
                   //Campos para contabilizacion de Naturisa
                   Obj.IdCategoria = item.IdCategoria;
                   Obj.IdLinea = item.IdLinea;
                   Obj.IdGrupo = item.IdGrupo;
                   Obj.IdSubGrupo = item.IdSubGrupo;
                   //Campos para el diario de gastos
                   Obj.IdCentro_Costo = item.IdCentroCosto;
                   Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                   Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                   Obj.IdPunto_cargo = item.IdPunto_cargo;
                   
                   Obj.Secuencia_OC = item.Secuencia_oc == null ? 1 : (int)item.Secuencia_oc;
                   Obj.IdSucursal_OC = item.IdSucursal_oc == null ? 1 : (int)item.IdSucursal_oc;
                   Obj.IdOrdenCompra = Convert.ToDecimal(item.IdOrdenCompra);
                   Obj.Dias = item.Dias;          
                   Lst.Add(Obj);
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
