using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Data.SqlClient;
using Core.Erp.Data;



namespace Core.Erp.Reportes.Compras
{
   public class XCOMP_Rpt004_Data
    {

       public List<XCOMP_Rpt004_Info> Cargar_data(int idempresa , DateTime FechaIni ,DateTime FechaFin)
       {

           try
           {

               List<XCOMP_Rpt004_Info> listadedatos = new List<XCOMP_Rpt004_Info>();
               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

               using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
               {
                   connection.Open();
                   SqlCommand command = new SqlCommand();
                   command.Connection = connection;
                   command.CommandText = "SELECT  dbo.com_ordencompra_local.IdEmpresa, dbo.com_ordencompra_local.IdSucursal, dbo.com_ordencompra_local.IdOrdenCompra, com_ordencompra_local_det.Secuencia, dbo.com_ordencompra_local.oc_NumDocumento AS documento, "
                                        + " dbo.com_ordencompra_local.oc_fecha, dbo.com_ordencompra_local.oc_observacion, dbo.com_comprador.IdComprador, dbo.com_comprador.Descripcion AS nom_comprador, dbo.cp_proveedor.IdProveedor, "
                                        + " dbo.cp_proveedor.pr_nombre AS nom_proveedor, dbo.com_ordencompra_local.IdEstadoAprobacion_cat, dbo.com_Motivo_Orden_Compra.IdMotivo, dbo.com_Motivo_Orden_Compra.Descripcion AS Nom_motivo_oc, "
                                        + " dbo.in_Producto.IdProducto, dbo.in_Producto.pr_descripcion AS nom_producto, dbo.com_ordencompra_local_det.do_Cantidad, dbo.com_ordencompra_local_det.do_precioCompra AS precio, "
                                        + " dbo.com_ordencompra_local_det.do_subtotal, dbo.com_ordencompra_local_det.do_iva, dbo.com_ordencompra_local_det.do_total, dbo.ct_punto_cargo.IdPunto_cargo, dbo.ct_punto_cargo.nom_punto_cargo, "
                                        + " dbo.ct_centro_costo.IdCentroCosto, dbo.ct_centro_costo.Centro_costo, dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS sub_centro_costo,"
                                        + " i.CantIng, com_ordencompra_local_det.do_Cantidad - isnull(i.CantIng,0) as Saldo, isnull(i.CantIng,0) as Ingreso, isnull(i.CantIng,0) * com_ordencompra_local_det.do_precioFinal as yTotalIngresado,"
                                        + " (com_ordencompra_local_det.do_Cantidad - isnull(i.CantIng,0)) * com_ordencompra_local_det.do_precioFinal as yTotalPorIngresar, f.fa_Descripcion"
                                        + " FROM   dbo.ct_punto_cargo with (nolock) RIGHT OUTER JOIN"
                                        + " dbo.in_Producto with (nolock) INNER JOIN"
                                        + " dbo.com_ordencompra_local with (nolock) INNER JOIN"
                                        + " dbo.com_ordencompra_local_det with (nolock) ON dbo.com_ordencompra_local.IdEmpresa = dbo.com_ordencompra_local_det.IdEmpresa AND dbo.com_ordencompra_local.IdSucursal = dbo.com_ordencompra_local_det.IdSucursal AND "
                                        + " dbo.com_ordencompra_local.IdOrdenCompra = dbo.com_ordencompra_local_det.IdOrdenCompra ON dbo.in_Producto.IdEmpresa = dbo.com_ordencompra_local_det.IdEmpresa AND "
                                        + " dbo.in_Producto.IdProducto = dbo.com_ordencompra_local_det.IdProducto INNER JOIN"
                                        + " dbo.tb_sucursal with (nolock) INNER JOIN"
                                        + " dbo.tb_empresa with (nolock) ON dbo.tb_sucursal.IdEmpresa = dbo.tb_empresa.IdEmpresa ON dbo.com_ordencompra_local.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND "
                                        + " dbo.com_ordencompra_local.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN"
                                        + " dbo.cp_proveedor with (nolock) ON dbo.com_ordencompra_local.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.com_ordencompra_local.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN"
                                        + " dbo.com_comprador with (nolock) ON dbo.com_ordencompra_local.IdEmpresa = dbo.com_comprador.IdEmpresa AND dbo.com_ordencompra_local.IdComprador = dbo.com_comprador.IdComprador LEFT OUTER JOIN"
                                        + " dbo.com_Motivo_Orden_Compra with (nolock) ON dbo.com_ordencompra_local.IdEmpresa = dbo.com_Motivo_Orden_Compra.IdEmpresa AND dbo.com_ordencompra_local.IdMotivo = dbo.com_Motivo_Orden_Compra.IdMotivo ON "
                                        + " dbo.ct_punto_cargo.IdEmpresa = dbo.com_ordencompra_local_det.IdEmpresa AND dbo.ct_punto_cargo.IdPunto_cargo = dbo.com_ordencompra_local_det.IdPunto_cargo LEFT OUTER JOIN"
                                        + " dbo.ct_centro_costo with (nolock) RIGHT OUTER JOIN"
                                        + " dbo.ct_centro_costo_sub_centro_costo with (nolock) ON dbo.ct_centro_costo.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND dbo.ct_centro_costo.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto ON"
                                        + " dbo.com_ordencompra_local_det.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND dbo.com_ordencompra_local_det.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND "
                                        + " dbo.com_ordencompra_local_det.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo left join"
                                        + " ("
                                        + " select x.IdEmpresa, x.IdSucursal_oc, x.IdOrdenCompra, x.Secuencia_oc, sum(x.dm_cantidad_sinConversion) CantIng"
                                        + " from in_Ing_Egr_Inven_det x with (nolock)"
                                        + " group by x.IdEmpresa, x.IdSucursal_oc, x.IdOrdenCompra, x.Secuencia_oc"
                                        + ") as i on i.IdEmpresa = com_ordencompra_local_det.IdEmpresa and i.IdSucursal_oc = com_ordencompra_local_det.IdSucursal and i.IdOrdenCompra = com_ordencompra_local_det.IdOrdenCompra and i.Secuencia_oc = com_ordencompra_local_det.Secuencia"
                                        + " left join in_familia as f with (nolock) on f.IdEmpresa = in_Producto.IdEmpresa and f.IdFamilia = in_Producto.IdFamilia"
                                        + " where com_ordencompra_local.IdEmpresa = "+idempresa.ToString()+" and com_ordencompra_local.oc_fecha between datefromparts(" + FechaIni.Year.ToString() + "," + FechaIni.Month.ToString() + "," + FechaIni.Day.ToString() + ") and datefromparts(" + FechaFin.Year.ToString() + "," + FechaFin.Month.ToString() + "," + FechaFin.Day.ToString() + ")";
                   SqlDataReader reader = command.ExecuteReader();
                   while (reader.Read())
                   {
                       listadedatos.Add(new XCOMP_Rpt004_Info
                       {
                           IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                           IdSucursal =  Convert.ToInt32(reader["IdSucursal"]),
                           IdOrdenCompra = Convert.ToDecimal(reader["IdOrdenCompra"]),
                           documento = Convert.ToString(reader["documento"]),
                           oc_fecha = Convert.ToDateTime(reader["oc_fecha"]),
                           oc_observacion = Convert.ToString(reader["oc_observacion"]),
                           IdComprador = Convert.ToInt32(reader["IdComprador"]),
                           nom_comprador = Convert.ToString(reader["nom_comprador"]),
                           IdProveedor = Convert.ToDecimal(reader["IdProveedor"]),
                           nom_proveedor = Convert.ToString(reader["nom_proveedor"]),
                           IdMotivo = reader["IdMotivo"] == DBNull.Value ? 0 : Convert.ToInt32(reader["IdMotivo"]),
                           Nom_motivo_oc = Convert.ToString(reader["Nom_motivo_oc"]),
                           IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                           nom_producto = Convert.ToString(reader["nom_producto"]),
                           do_Cantidad = reader["do_Cantidad"] == DBNull.Value ? 0 : Convert.ToDouble(reader["do_Cantidad"]),
                           precio = reader["precio"] == DBNull.Value ? 0 : Convert.ToDouble(reader["precio"]),
                           do_subtotal = reader["do_subtotal"] == DBNull.Value ? 0 : Convert.ToDouble(reader["do_subtotal"]),
                           do_iva = reader["do_iva"] == DBNull.Value ? 0 : Convert.ToDouble(reader["do_iva"]),
                           do_total = reader["do_total"] == DBNull.Value ? 0 : Convert.ToDouble(reader["do_total"]),
                           IdPunto_cargo = reader["IdPunto_cargo"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["IdPunto_cargo"]),
                           nom_punto_cargo = Convert.ToString(reader["nom_punto_cargo"]),
                           IdCentroCosto = Convert.ToString(reader["IdCentroCosto"]),
                           Centro_costo = Convert.ToString(reader["Centro_costo"]),
                           IdCentroCosto_sub_centro_costo = Convert.ToString(reader["IdCentroCosto_sub_centro_costo"]),
                           sub_centro_costo = Convert.ToString(reader["sub_centro_costo"]),
                           Anio = Convert.ToDateTime(reader["oc_fecha"]).Year,
                           Mes = Convert.ToDateTime(reader["oc_fecha"]).Month,
                           Dia = Convert.ToDateTime(reader["oc_fecha"]).Day,
                           CantIng = reader["CantIng"] == DBNull.Value ? 0 : Convert.ToDouble(reader["CantIng"]),
                           Saldo = reader["Saldo"] == DBNull.Value ? 0 : Convert.ToDouble(reader["Saldo"]),
                           yTotalIngresado = reader["yTotalIngresado"] == DBNull.Value ? 0 : Convert.ToDouble(reader["yTotalIngresado"]),
                           yTotalPorIngresar = reader["yTotalPorIngresar"] == DBNull.Value ? 0 : Convert.ToDouble(reader["yTotalPorIngresar"]),
                           fa_Descripcion = reader["fa_Descripcion"].ToString(),
                       });
                   }
                   reader.Close();
               }
               return listadedatos;
           }
           catch (Exception ex)
           {
               string MensajeError = "";
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
               MensajeError = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt004_Data) };
           }
           
       
       }

    }
}
