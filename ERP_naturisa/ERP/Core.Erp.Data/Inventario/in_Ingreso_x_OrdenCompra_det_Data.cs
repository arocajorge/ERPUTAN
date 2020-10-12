using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using System.Data.SqlClient;



namespace Core.Erp.Data.Inventario
{
  public  class in_Ingreso_x_OrdenCompra_det_Data
    {

        string mensaje = "";

        public List<in_Ingreso_x_OrdenCompra_det_Info> Get_List_Ingreso_x_OrdenCompra_det(int Idempresa, decimal IdIngreso_x_oc)
        {
            List<in_Ingreso_x_OrdenCompra_det_Info> lM = new List<in_Ingreso_x_OrdenCompra_det_Info>();             

            try
            {
                //EntitiesInventario OEInventario = new EntitiesInventario();


                //var select = from C in OEInventario.vwin_Ingreso_x_OrdenCompra_det
                //             where C.IdEmpresa == Idempresa && C.IdIngreso_x_oc == IdIngreso_x_oc
                //             orderby C.Secuencia ascending
                //             select C;

                //foreach (var item in select)
                //{
                //    in_Ingreso_x_OrdenCompra_det_Info info = new in_Ingreso_x_OrdenCompra_det_Info();

                //    info.IdEmpresa = item.IdEmpresa;
                //    info.IdIngreso_x_oc = item.IdIngreso_x_oc;
                //    info.Secuencia = item.Secuencia;
                //    info.IdProducto = item.IdProducto;
                //    info.Cant = item.Cant;
                //    info.Cant_a_recibir = item.Cant_a_recibir;
                //    info.IdEmpresa_oc = Convert.ToInt32(item.IdEmpresa_oc);
                //    info.IdSucursal_oc = Convert.ToInt32(item.IdSucursal_oc);
                //    info.IdOrdenCompra = Convert.ToDecimal(item.IdOrdenCompra);
                //    info.Secuencia_oc = Convert.ToInt32(item.Secuencia_oc);

                //    info.IdCentroCosto = item.IdCentroCosto;
                //    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                //    info.IdPunto_cargo = Convert.ToInt32(item.IdPunto_cargo);

                //    info.nom_sucu = item.nom_sucursal;
                //    info.nom_producto = item.nom_producto;

                //    info.cantidad_pedida_OC = item.Cant;
                //    info.cantidad_ing_a_Inven = item.Cant_a_recibir;
                //    info.IdUnidadMedida = item.IdUnidadMedida;



                //    lM.Add(info);
                //}
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Ing_Egr_Inven_det_Info> Get_List_Ingreso_x_OrdenCompra_det_x_proveedor(int IdEmpresa, decimal IdProveedor)
      {
          try
          {
              decimal IdProveedorIni = 0;
              decimal IdProveedorFin = 0;

              IdProveedorIni = (IdProveedor == 0) ? 1 : IdProveedor;
              IdProveedorFin = (IdProveedor == 0) ? 9999999 : IdProveedor;
              List<in_Ing_Egr_Inven_det_Info> Lst = new List<in_Ing_Egr_Inven_det_Info>();            

              using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
              {
                  connection.Open();

                  string query = "SELECT        b.IdEmpresa, b.IdSucursal, b.IdOrdenCompra, b.Secuencia, d.codigo + '-' + CAST(b.IdOrdenCompra AS varchar(20)) AS oc_NumDocumento, d.Su_Descripcion, a.IdProveedor, f.pe_nombreCompleto, a.oc_fecha, a.oc_observacion, "
                                + " b.IdProducto, g.pr_codigo, g.pr_descripcion, b.do_precioFinal, b.do_Cantidad, ISNULL(c.dm_cantidad, 0) AS CantidadIngresada, b.do_Cantidad - ISNULL(c.dm_cantidad, 0) AS Saldo, b.IdCentroCosto, "
                                + " b.IdCentroCosto_sub_centro_costo, b.IdPunto_cargo, b.IdPunto_cargo_grupo, b.IdUnidadMedida, a.IdEstado_cierre, 'OC# ' + d.codigo + '-' + CAST(b.IdOrdenCompra AS varchar(20)) + ' Fecha: ' + CONVERT(varchar, a.oc_fecha, "
                                + " 103) + ' Proveedor: ' + LTRIM(RTRIM(f.pe_nombreCompleto)) AS RefOC, g.IdUnidadMedida_Consumo, h.codigo AS CodSucDestino, h.Su_Descripcion AS SucursalDestino, i.Descripcion as NomUnidadMedida"
                                + " FROM            dbo.com_ordencompra_local AS a INNER JOIN"
                                + " dbo.com_ordencompra_local_det AS b ON a.IdEmpresa = b.IdEmpresa AND a.IdSucursal = b.IdSucursal AND a.IdOrdenCompra = b.IdOrdenCompra LEFT OUTER JOIN"
                                + " (SELECT        IdEmpresa_oc, IdSucursal_oc, IdOrdenCompra, Secuencia_oc, SUM(dm_cantidad_sinConversion) AS dm_cantidad"
                                + " FROM            dbo.in_Ing_Egr_Inven_det AS d"
                                + " WHERE        d.IdEmpresa = " + IdEmpresa.ToString() + " and (IdOrdenCompra IS NOT NULL)"
                                + " GROUP BY IdEmpresa_oc, IdSucursal_oc, IdOrdenCompra, Secuencia_oc) AS c ON b.IdEmpresa = c.IdEmpresa_oc AND b.IdSucursal = c.IdSucursal_oc AND b.IdOrdenCompra = c.IdOrdenCompra AND "
                                + " b.Secuencia = c.Secuencia_oc LEFT OUTER JOIN"
                                + " dbo.tb_sucursal AS d ON b.IdEmpresa = d.IdEmpresa AND b.IdSucursal = d.IdSucursal LEFT OUTER JOIN"
                                + " dbo.cp_proveedor AS e ON a.IdEmpresa = e.IdEmpresa AND a.IdProveedor = e.IdProveedor LEFT OUTER JOIN"
                                + " dbo.tb_persona AS f ON e.IdPersona = f.IdPersona INNER JOIN"
                                + " dbo.in_Producto AS g ON b.IdEmpresa = g.IdEmpresa AND b.IdProducto = g.IdProducto LEFT OUTER JOIN"
                                + " dbo.tb_sucursal AS h ON b.IdEmpresa = h.IdEmpresa AND b.IdSucursalDestino = h.IdSucursal LEFT JOIN"
                                + " dbo.in_UnidadMedida as i on b.IdUnidadMedida = i.IdUnidadMedida"
                                + " WHERE        (a.Estado = 'A') AND (a.IdEstado_cierre <> 'CERR') AND (a.IdEstadoAprobacion_cat = 'APRO') AND (ROUND(b.do_Cantidad - ISNULL(c.dm_cantidad, 0), 2) > 0) and b.IdEmpresa = " + IdEmpresa.ToString();

                                if (IdProveedor != 0)
	                            {
		                             query+= " and a.IdProveedor = "+IdProveedor.ToString();
	                            }
                                

                  SqlCommand command = new SqlCommand(query,connection);
                  SqlDataReader reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      Lst.Add(new in_Ing_Egr_Inven_det_Info
                      {
                          IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                          IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                          IdEmpresa_oc = Convert.ToInt32(reader["IdEmpresa"]),
                          IdSucursal_oc = Convert.ToInt32(reader["IdSucursal"]),
                          IdOrdenCompra = Convert.ToDecimal(reader["IdOrdenCompra"]),
                          Secuencia_oc = Convert.ToInt32(reader["Secuencia"]),
                          nom_sucu = Convert.ToString(reader["Su_Descripcion"]),
                          IdProveedor = Convert.ToDecimal(reader["IdProveedor"]),
                          nom_proveedor = Convert.ToString(reader["pe_nombreCompleto"]),
                          oc_fecha = Convert.ToDateTime(reader["oc_fecha"]),
                          oc_observacion = Convert.ToString(reader["oc_observacion"]),
                          cod_producto = Convert.ToString(reader["pr_codigo"]),
                          nom_producto = Convert.ToString(reader["pr_descripcion"]),
                          IdProducto = Convert.ToInt32(reader["IdProducto"]),
                          dm_cantidad = 0,
                          oc_NumDocumento = Convert.ToString(reader["oc_NumDocumento"]),
                          dm_precio = Convert.ToDouble(reader["do_precioFinal"]),
                          mv_costo = Convert.ToDouble(reader["do_precioFinal"]),

                          cantidad_pedida_OC = Convert.ToDouble(reader["do_Cantidad"]),
                          Saldo_x_Ing_OC = Convert.ToDouble(reader["Saldo"]),
                          Saldo_x_Ing_OC_AUX = Convert.ToDouble(reader["Saldo"]),
                          dm_stock_ante = 0,
                          dm_stock_actu = 0,
                          IdCentroCosto = string.IsNullOrEmpty(reader["IdCentroCosto"].ToString()) ? null : Convert.ToString(reader["IdCentroCosto"]),
                          IdCentroCosto_sub_centro_costo = string.IsNullOrEmpty(reader["IdCentroCosto_sub_centro_costo"].ToString()) ? null : Convert.ToString(reader["IdCentroCosto_sub_centro_costo"]),

                          IdPunto_cargo_grupo = string.IsNullOrEmpty(reader["IdPunto_cargo_grupo"].ToString()) ? null : (int?)(reader["IdPunto_cargo_grupo"]),
                          IdPunto_cargo =  string.IsNullOrEmpty(reader["IdPunto_cargo"].ToString()) ? null : (int?)(reader["IdPunto_cargo"]),
                          IdUnidadMedida = Convert.ToString(reader["IdUnidadMedida"]),
                          cantidad_ingresada = Convert.ToDouble(reader["CantidadIngresada"]),
                          IdEstado_cierre = Convert.ToString(reader["IdEstado_cierre"]),
                          Ref_OC = Convert.ToString(reader["RefOC"]),
                          IdUnidadMedida_Consumo = Convert.ToString(reader["IdUnidadMedida_Consumo"]),
                          Nomsub_centro_costo = (string.IsNullOrEmpty(reader["IdCentroCosto"].ToString()) ? null : Convert.ToString(reader["IdCentroCosto"])) + "-" + (string.IsNullOrEmpty(reader["IdCentroCosto_sub_centro_costo"].ToString()) ? null : Convert.ToString(reader["IdCentroCosto_sub_centro_costo"])),
                          SucursalDestino = Convert.ToString(reader["SucursalDestino"]),
                          nom_UnidadMedida = reader["NomUnidadMedida"].ToString()
                      });
                  }
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
