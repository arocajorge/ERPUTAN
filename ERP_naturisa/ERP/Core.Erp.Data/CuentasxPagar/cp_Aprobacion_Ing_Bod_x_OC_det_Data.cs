using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.SqlClient;


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

               using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
               {
                   connection.Open();
                   SqlCommand command = new SqlCommand();
                   command.Connection = connection;
                   command.CommandText = "SELECT        d.IdEmpresa, d.IdSucursal, d.IdMovi_inven_tipo, d.IdNumMovi, d.Secuencia, d.IdBodega, d.IdProducto, p.pr_descripcion, d.dm_cantidad_sinConversion, d.mv_costo_sinConversion, doc.do_porc_des, c.cm_fecha, p.IdCategoria, "
                                        +" p.IdLinea, p.IdGrupo, p.IdSubGrupo, s.Su_Descripcion, b.bo_Descripcion, doc.IdSucursal AS IdSucursal_oc, doc.IdOrdenCompra, doc.Secuencia AS Secuencia_oc, d.IdCentroCosto, d.IdCentroCosto_sub_centro_costo, "
                                        +" d.IdPunto_cargo, d.IdPunto_cargo_grupo, doc.Por_Iva, d.IdUnidadMedida_sinConversion, coc.IdProveedor, coc.oc_plazo, per.pe_nombreCompleto, mot.es_Inven_o_Consumo, "
                                        +" CASE WHEN mot.es_Inven_o_Consumo = 'TIC_CONSU' THEN cc.IdCtaCble ELSE b.IdCtaCtble_Inve END AS IdCtaCble_Gasto, d.dm_cantidad_sinConversion * d.mv_costo_sinConversion AS Subtotal, "
                                        +" (d.dm_cantidad_sinConversion * d.mv_costo_sinConversion) * (doc.Por_Iva / 100) AS ValorIVA, d.dm_cantidad_sinConversion * d.mv_costo_sinConversion + (d.dm_cantidad_sinConversion * d.mv_costo_sinConversion) "
                                        + " * (doc.Por_Iva / 100) AS Total, provic.IdCtaCble as IdCtaCble_Provision, case when doc.Por_Iva > 0 then d.dm_cantidad_sinConversion * d.mv_costo_sinConversion else 0 end as subtotal0 "
                                        + " case when doc.Por_Iva = 0 then d.dm_cantidad_sinConversion * d.mv_costo_sinConversion else 0 end as subtotaliva"
                                        +" FROM            dbo.in_Ing_Egr_Inven_det AS d INNER JOIN"
                                        +" dbo.in_Producto AS p ON d.IdEmpresa = p.IdEmpresa AND d.IdProducto = p.IdProducto INNER JOIN"
                                        +" dbo.com_ordencompra_local_det AS doc ON doc.IdEmpresa = d.IdEmpresa_oc AND doc.IdSucursal = d.IdSucursal_oc AND doc.IdOrdenCompra = d.IdOrdenCompra AND doc.Secuencia = d.Secuencia_oc INNER JOIN"
                                        +" dbo.in_Ing_Egr_Inven AS c ON c.IdEmpresa = d.IdEmpresa AND c.IdSucursal = d.IdSucursal AND c.IdMovi_inven_tipo = d.IdMovi_inven_tipo AND c.IdNumMovi = d.IdNumMovi INNER JOIN"
                                        +" dbo.tb_bodega AS b ON b.IdEmpresa = d.IdEmpresa AND b.IdSucursal = d.IdSucursal AND b.IdBodega = d.IdBodega INNER JOIN"
                                        +" dbo.tb_sucursal AS s ON s.IdEmpresa = b.IdEmpresa AND s.IdSucursal = b.IdSucursal INNER JOIN"
                                        +" dbo.com_ordencompra_local AS coc ON coc.IdEmpresa = doc.IdEmpresa AND coc.IdSucursal = doc.IdSucursal AND coc.IdOrdenCompra = doc.IdOrdenCompra INNER JOIN"
                                        +" dbo.cp_proveedor AS pro ON pro.IdEmpresa = coc.IdEmpresa AND pro.IdProveedor = coc.IdProveedor INNER JOIN"
                                        +" dbo.tb_persona AS per ON pro.IdPersona = per.IdPersona INNER JOIN"
                                        +" dbo.in_Motivo_Inven AS mot ON mot.IdEmpresa = c.IdEmpresa AND mot.IdMotivo_Inv = c.IdMotivo_Inv LEFT OUTER JOIN"
                                        +" dbo.in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble AS cc ON cc.IdEmpresa = p.IdEmpresa AND cc.IdCategoria = p.IdCategoria AND cc.IdLinea = p.IdLinea AND cc.IdGrupo = p.IdGrupo AND "
                                        +" cc.IdSubgrupo = p.IdSubGrupo AND d.IdCentroCosto = cc.IdCentroCosto AND d.IdCentroCosto_sub_centro_costo = cc.IdSub_centro_costo LEFT OUTER JOIN"
                                        +" dbo.cp_Aprobacion_Ing_Bod_x_OC_det AS apro ON apro.IdEmpresa_Ing_Egr_Inv = d.IdEmpresa AND apro.IdSucursal_Ing_Egr_Inv = d.IdSucursal AND apro.IdMovi_inven_tipo_Ing_Egr_Inv = d.IdMovi_inven_tipo AND "
                                        +" apro.IdNumMovi_Ing_Egr_Inv = d.IdNumMovi AND apro.Secuencia_Ing_Egr_Inv = d.Secuencia left join"
                                        +" in_ProvisionIngresosPorOCDet as provi on provi.IdEmpresa = d.IdEmpresa and provi.IdSucursal = d.IdSucursal and provi.IdMovi_inven_tipo = d.IdMovi_inven_tipo and provi.IdNumMovi = d.IdNumMovi and provi.Secuencia = d.Secuencia left join"
                                        +" in_ProvisionIngresosPorOC as provic on provic.IdEmpresa = provi.IdEmpresa and provic.IdProvision = provi.IdProvision "
                                        +" WHERE        d.IdEmpresa = "+IdEmpresa.ToString()+" and coc.IdProveedor = "+IdProveedor.ToString()+" and (apro.IdAprobacion IS NULL)";
                   SqlDataReader reader = command.ExecuteReader();
                   while (reader.Read())
                   {
                       Lst.Add(new cp_Aprobacion_Ing_Bod_x_OC_det_Info
                       {
                           IdEmpresa_Ing_Egr_Inv = Convert.ToInt32(reader["IdEmpresa"]),
                           IdSucursal_Ing_Egr_Inv = Convert.ToInt32(reader["IdSucursal"]),
                           IdMovi_inven_tipo_Ing_Egr_Inv = Convert.ToInt32(reader["IdMovi_inven_tipo"]),
                           IdNumMovi_Ing_Egr_Inv = Convert.ToDecimal(reader["IdNumMovi"]),
                           Secuencia_Ing_Egr_Inv = Convert.ToInt32(reader["Secuencia"]),
                           IdBodega = Convert.ToInt32(reader["IdBodega"]),
                           Fecha_Ing_Bod = Convert.ToDateTime(reader["cm_fecha"]),
                           IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                           nom_producto = Convert.ToString(reader["pr_descripcion"]),
                           Cantidad = Convert.ToDouble(reader["dm_cantidad_sinConversion"]),
                           Costo_uni = reader["mv_costo_sinConversion"] == DBNull.Value ? 0 : Convert.ToDouble(reader["mv_costo_sinConversion"]),
                           //Campos para contabilizacion de Naturisa
                           IdCategoria = reader["IdCategoria"].ToString(),
                           IdLinea = Convert.ToInt32(reader["IdLinea"]),
                           IdGrupo = Convert.ToInt32(reader["IdGrupo"]),
                           IdSubGrupo = Convert.ToInt32(reader["IdSubGrupo"]),
                           nom_bodega = reader["bo_Descripcion"].ToString(),
                           nom_sucursal = reader["Su_Descripcion"].ToString(),
                           do_porc_des = Convert.ToDouble(reader["do_porc_des"]),
                           //Campos para el diario de gastos
                           IdCentro_Costo = reader["IdCentroCosto"] == DBNull.Value ? null : reader["IdCentroCosto"].ToString(),
                           IdCentroCosto_sub_centro_costo = reader["IdCentroCosto_sub_centro_costo"] == DBNull.Value ? null : reader["IdCentroCosto_sub_centro_costo"].ToString(),
                           IdPunto_cargo_grupo = reader["IdPunto_cargo_grupo"] == DBNull.Value ? null : (int?)reader["IdPunto_cargo_grupo"],
                           IdPunto_cargo = reader["IdPunto_cargo"] == DBNull.Value ? null : (int?)reader["IdPunto_cargo"],
                           Secuencia_OC = Convert.ToInt32(reader["item.Secuencia_oc"]),
                           IdSucursal_OC = Convert.ToInt32(reader["item.IdSucursal_oc"]),
                           IdOrdenCompra = Convert.ToDecimal(reader["item.IdOrdenCompra"]),
                           PorIva = Convert.ToDouble(reader["item.Por_Iva"]),
                           IdUnidadMedida = reader["IdUnidadMedida_sinConversion"] == DBNull.Value ? null : reader["IdUnidadMedida_sinConversion"].ToString(),
                           //  nom_medida = item.nom_medida,
                           IdProveedor = Convert.ToDecimal(reader["item.IdProveedor"]),
                           nom_proveedor = reader["pe_nombreCompleto"].ToString(),
                           Dias =  Convert.ToInt32(reader["oc_plazo"]),
                           IdCtaCble_Gasto = reader["IdCtaCble_Gasto"] == DBNull.Value ? null : reader["IdCtaCble_Gasto"].ToString(),
                           IdRegistro = (reader["IdCentroCosto"] == DBNull.Value ? null : (reader["IdCentroCosto"].ToString() + "-" + reader["IdCentroCosto_sub_centro_costo"].ToString())),

                           SubTotal = reader["Subtotal"] == DBNull.Value ? 0 : Convert.ToDouble(reader["Subtotal"]),
                           valor_Iva = reader["ValorIVA"] == DBNull.Value ? 0 : Convert.ToDouble(reader["ValorIVA"]),
                           Total = reader["Total"] == DBNull.Value ? 0 : Convert.ToDouble(reader["Total"]),
                           subtotal0 = reader["subtotal0"] == DBNull.Value ? 0 : Convert.ToDouble(reader["subtotal0"]),
                           subtotaliva = reader["subtotaliva"] == DBNull.Value ? 0 : Convert.ToDouble(reader["subtotaliva"]),
                           IdCtaCble_Provision = reader["IdCtaCble_Provision"] == DBNull.Value ? null : reader["IdCtaCble_Provision"].ToString(),
                           S_es_Inven_o_Consumo = reader["es_Inven_o_Consumo"].ToString()
                       });
                   }
                   reader.Close();
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
