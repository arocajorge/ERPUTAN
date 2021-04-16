using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data;
using System.Data.SqlClient;


namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt002_Data
    {
        public List<XCXP_NATU_Rpt002_Info> consultar_data
            (int IdEmpresa, Decimal IdProveedorIni, Decimal IdProveedorFin, DateTime Fecha_Ini, DateTime Fecha_Fin, int IdClaseProveedorIni, int IdClaseProveedorFin, bool Filtrar_fecha_emi, ref String mensaje, int IdSucursal)
        {
            try
            {
                List<XCXP_NATU_Rpt002_Info> listadedatos = new List<XCXP_NATU_Rpt002_Info>();


                DateTime FechaIni = Convert.ToDateTime(Fecha_Ini.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(Fecha_Fin.ToShortDateString());


                string SNombreProveedorFiltro = "";
                decimal ProveIni = 0;
                decimal ProveFin = 0;
                int IdSucursalFin = IdSucursal == 0 ? 99999 : IdSucursal;
                if (IdProveedorIni == 0 && IdProveedorFin == 0)
                {
                    ProveIni = 1;
                    ProveFin = 900000;
                    SNombreProveedorFiltro = "TODOS";
                }
                else
                {
                    ProveIni = IdProveedorIni;
                    ProveFin = IdProveedorFin;
                    SNombreProveedorFiltro = "POR RANGO DE PROVEEDOR";
                }

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "DECLARE @IdEmpresa int = "+IdEmpresa.ToString()+","
                                        + " @FechaIni date = datefromparts(" + FechaIni.Year.ToString() + "," + FechaIni.Month.ToString() + "," + FechaIni.Day.ToString()+ "),"
                                        +" @FechaFin date = datefromparts("+FechaFin.Year.ToString()+","+FechaFin.Month.ToString()+","+FechaFin.Day.ToString()+"),"
                                        +" @IdSucursalIni int = "+IdSucursal.ToString()+","
                                        +" @IdSucursalFin int = "+IdSucursalFin.ToString()+","
                                        +" @IdClaseProveedorIni int = "+IdClaseProveedorIni.ToString()+","
                                        +" @IdClaseProveedorFin int = "+IdClaseProveedorFin.ToString()+","
                                        +" @IdProveedorIni numeric = "+IdProveedorIni.ToString()+","
                                        +" @IdProveedorFin numeric = "+IdProveedorFin.ToString()+","
                                        + " @FiltrarPorEmision bit = " + (Filtrar_fecha_emi ? "1" : "0")
                                        +" SELECT        dbo.cp_orden_giro.IdEmpresa, NULL AS IdOrdenPago, dbo.cp_orden_giro.IdCbteCble_Ogiro, dbo.cp_orden_giro.IdTipoCbte_Ogiro, dbo.cp_orden_giro.IdOrden_giro_Tipo, 'FACT' AS cod_tipo_doc, 'Factura' AS tipo_doc, 'FAC#' + cast(cast(dbo.cp_orden_giro.co_factura AS numeric) AS varchar(20)) AS Documento, cast(dbo.cp_orden_giro.co_fechaOg AS date) AS Fecha, cast(dbo.cp_orden_giro.co_FechaFactura_vct AS date) co_FechaFactura_vct, "
                                        +" dbo.cp_orden_giro.co_observacion AS Observacion, dbo.cp_proveedor.IdPersona, dbo.cp_proveedor.IdProveedor, dbo.cp_proveedor.pr_nombre AS Nom_Proveedor, dbo.cp_orden_giro.co_baseImponible AS SubTotal, "
                                        +" dbo.cp_orden_giro.co_valoriva AS Iva, dbo.cp_orden_giro.co_total AS Total, dbo.cp_orden_giro.co_valorpagar AS Total_a_Pagar, CASE WHEN ROUND(dbo.vwcp_orden_giro_total_saldo.SaldoOG, 2) BETWEEN - 0.01 AND "
                                        +" 0.01 THEN 0 ELSE ROUND(dbo.vwcp_orden_giro_total_saldo.SaldoOG, 2) END AS Saldo_x_pagar, dbo.cp_proveedor_clase.IdClaseProveedor, dbo.cp_proveedor_clase.descripcion_clas_prove, cp_orden_giro.IdSucursal, "
                                        +" S.Su_Descripcion"
                                        +" FROM            dbo.cp_orden_giro INNER JOIN"
                                        +" dbo.tb_sucursal ON dbo.cp_orden_giro.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.cp_orden_giro.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN"
                                        +" dbo.cp_proveedor ON dbo.cp_orden_giro.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.cp_orden_giro.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN"
                                        +" dbo.cp_proveedor_clase ON dbo.cp_proveedor.IdEmpresa = dbo.cp_proveedor_clase.IdEmpresa AND dbo.cp_proveedor.IdClaseProveedor = dbo.cp_proveedor_clase.IdClaseProveedor INNER JOIN"
                                        +" dbo.vwcp_orden_giro_total_saldo ON dbo.cp_orden_giro.IdEmpresa = dbo.vwcp_orden_giro_total_saldo.IdEmpresa AND dbo.cp_orden_giro.IdCbteCble_Ogiro = dbo.vwcp_orden_giro_total_saldo.IdCbteCble_Ogiro AND "
                                        +" dbo.cp_orden_giro.IdTipoCbte_Ogiro = dbo.vwcp_orden_giro_total_saldo.IdTipoCbte_Ogiro AND dbo.cp_orden_giro.IdOrden_giro_Tipo = dbo.vwcp_orden_giro_total_saldo.IdOrden_giro_Tipo AND "
                                        +" dbo.cp_orden_giro.IdProveedor = dbo.vwcp_orden_giro_total_saldo.IdProveedor INNER JOIN"
                                        +" tb_sucursal AS S ON cp_orden_giro.IdEmpresa = S.IdEmpresa AND cp_orden_giro.IdSucursal = S.IdSucursal"
                                        +" WHERE        dbo.cp_orden_giro.Estado = 'A' AND CASE WHEN ROUND(dbo.vwcp_orden_giro_total_saldo.SaldoOG, 2) BETWEEN - 0.01 AND "
                                        +" 0.01 THEN 0 ELSE ROUND(dbo.vwcp_orden_giro_total_saldo.SaldoOG, 2) end != 0"
                                        +" and cp_orden_giro.IdEmpresa = @IdEmpresa"
                                        +" and cp_orden_giro.IdSucursal between @IdSucursalIni and @IdSucursalFin"
                                        +" and case when @FiltrarPorEmision = 1 then cast(dbo.cp_orden_giro.co_fechaOg AS date) else cast(dbo.cp_orden_giro.co_FechaFactura_vct AS date) end between @FechaIni and @FechaFin"
                                        +" and  cp_proveedor.IdClaseProveedor between @IdClaseProveedorIni and @IdClaseProveedorFin"
                                        +" and cp_orden_giro.IdProveedor between @IdProveedorIni and @IdProveedorFin"
                                        +" UNION "
                                        +" SELECT        dbo.cp_nota_DebCre.IdEmpresa, NULL AS IdOrdenPago, dbo.cp_nota_DebCre.IdCbteCble_Nota, dbo.cp_nota_DebCre.IdTipoCbte_Nota, '05', 'ND' AS cod_tipo_doc, 'Nota de débito' AS tipo_doc, "
                                        +" CASE WHEN cp_nota_DebCre.cn_serie1 IS NULL THEN 'ND#' + cast(cast(dbo.cp_nota_DebCre.cod_nota AS numeric) AS varchar(20)) ELSE 'ND' + cast(cast(cp_nota_DebCre.cn_Nota AS numeric) AS varchar(20)) "
                                        +" END AS Documento, cast(dbo.cp_nota_DebCre.cn_fecha AS date) AS Fecha, cast(dbo.cp_nota_DebCre.cn_Fecha_vcto AS date) cn_Fecha_vcto, dbo.cp_nota_DebCre.cn_observacion AS Observacion, "
                                        +" dbo.cp_proveedor.IdPersona, dbo.cp_proveedor.IdProveedor, ltrim(rtrim(dbo.cp_proveedor.pr_nombre)) AS Nom_Proveedor, dbo.cp_nota_DebCre.cn_baseImponible AS SubTotal, dbo.cp_nota_DebCre.cn_valoriva AS Iva, "
                                        +" dbo.cp_nota_DebCre.cn_total AS Total, vwcp_nota_DebCre_total_saldo.valorpagar AS Total_a_pagar, round(dbo.vwcp_nota_DebCre_total_saldo.SaldoOG, 2) AS Saldo_x_pagar, dbo.cp_proveedor_clase.IdClaseProveedor, "
                                        +" dbo.cp_proveedor_clase.descripcion_clas_prove, cp_nota_DebCre.IdSucursal, S.Su_Descripcion"
                                        +" FROM            dbo.cp_nota_DebCre INNER JOIN"
                                        +" dbo.tb_sucursal ON dbo.cp_nota_DebCre.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.cp_nota_DebCre.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN"
                                        +" dbo.cp_proveedor ON dbo.cp_nota_DebCre.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.cp_nota_DebCre.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN"
                                        +" dbo.cp_proveedor_clase ON dbo.cp_proveedor.IdEmpresa = dbo.cp_proveedor_clase.IdEmpresa AND dbo.cp_proveedor.IdClaseProveedor = dbo.cp_proveedor_clase.IdClaseProveedor INNER JOIN"
                                        +" dbo.vwcp_nota_DebCre_total_saldo ON dbo.cp_nota_DebCre.IdEmpresa = dbo.vwcp_nota_DebCre_total_saldo.IdEmpresa AND dbo.cp_nota_DebCre.IdCbteCble_Nota = dbo.vwcp_nota_DebCre_total_saldo.IdCbteCble_Nota AND "
                                        +" dbo.cp_nota_DebCre.IdTipoCbte_Nota = dbo.vwcp_nota_DebCre_total_saldo.IdTipoCbte_Nota AND dbo.cp_nota_DebCre.IdProveedor = dbo.vwcp_nota_DebCre_total_saldo.IdProveedor INNER JOIN"
                                        +" tb_sucursal AS S ON cp_nota_DebCre.IdEmpresa = S.IdEmpresa AND cp_nota_DebCre.IdSucursal = S.IdSucursal"
                                        +" WHERE        dbo.cp_nota_DebCre.Estado = 'A' AND dbo.cp_nota_DebCre.DebCre = 'D' AND  round(dbo.vwcp_nota_DebCre_total_saldo.SaldoOG,2) != 0"
                                        +" and cp_nota_DebCre.IdEmpresa = @IdEmpresa"
                                        +" and cp_nota_DebCre.IdSucursal between @IdSucursalIni and @IdSucursalFin"
                                        +" and case when @FiltrarPorEmision = 1 then cast(dbo.cp_nota_DebCre.cn_Fecha AS date) else cast(dbo.cp_nota_DebCre.cn_Fecha_vcto AS date) end between @FechaIni and @FechaFin"
                                        +" and  cp_proveedor.IdClaseProveedor between @IdClaseProveedorIni and @IdClaseProveedorFin"
                                        +" and cp_nota_DebCre.IdProveedor between @IdProveedorIni and @IdProveedorFin"
                                        +" UNION "
                                        +" SELECT        A.IdEmpresa, A.IdOrdenPago, NULL AS IdCbteCble_Ogiro, NULL AS IdTipoCbte_Ogiro, NULL AS IdOrden_giro_Tipo, A.IdTipo_op, A.IdTipo_op, 'OP#:' + cast(A.IdOrdenPago AS varchar(20)), cast(A.Fecha AS date), "
                                        +" cast(A.Fecha_Pago AS date), A.Observacion, A.IdPersona, A.IdEntidad, ltrim(rtrim(A.pe_nombreCompleto)) pe_nombreCompleto, A.Total_OP, 0 AS Iva, A.Total_OP, A.Total_cancelado, A.Saldo, "
                                        +" c.IdClaseProveedor AS IdClaseProveedor, d .descripcion_clas_prove AS descr, SU.IdSucursal, SU.Su_Descripcion"
                                        +" FROM            vwcp_orden_pago A LEFT JOIN"
                                        +" (SELECT        D .IdEmpresa, D .IdOrdenPago, MAX(C.IdSucursal) IdSucursal, MAX(S.Su_Descripcion) Su_Descripcion"
                                        +" FROM            ct_cbtecble C INNER JOIN"
                                        +" cp_orden_pago_det AS D ON C.IdEmpresa = D .IdEmpresa AND C.IdTipoCbte = D .IdTipoCbte_cxp AND C.IdCbteCble = D .IdCbteCble_cxp INNER JOIN"
                                        +" tb_sucursal AS S ON C.IdEmpresa = S.IdEmpresa AND C.IdSucursal = S.IdSucursal"
                                        +" GROUP BY D .IdEmpresa, D .IdOrdenPago) AS SU ON SU.IdEmpresa = A.IdEmpresa AND SU.IdOrdenPago = A.IdOrdenPago LEFT JOIN"
                                        +" cp_proveedor AS c ON c.IdEmpresa = a.IdEmpresa AND c.IdProveedor = a.IdEntidad LEFT JOIN"
                                        +" cp_proveedor_clase AS d ON c.IdEmpresa = d .IdEmpresa AND c.IdClaseProveedor = d .IdClaseProveedor"
                                        + " WHERE        A.IdTipo_op <> 'FACT_PROVEE' AND A.Estado = 'A' AND round(a.saldo,2) != 0 AND a.IdTipo_Persona = 'PROVEE'"
                                        +" and A.IdEmpresa = @IdEmpresa"
                                        +" and A.IdSucursal between @IdSucursalIni and @IdSucursalFin"
                                        + " and case when @FiltrarPorEmision = 1 then cast(A.Fecha AS date) else cast(A.Fecha_Pago AS date) end between @FechaIni and @FechaFin"
                                        + " and c.IdClaseProveedor between @IdClaseProveedorIni and @IdClaseProveedorFin"
                                        +" and A.IdEntidad between @IdProveedorIni and @IdProveedorFin";

                    
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listadedatos.Add(new XCXP_NATU_Rpt002_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            co_FechaFactura_vct = Convert.ToDateTime(reader["co_FechaFactura_vct"]),
                            cod_tipo_doc = Convert.ToString(reader["cod_tipo_doc"]),
                            Documento = Convert.ToString(reader["Documento"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            IdCbteCble_Ogiro = reader["IdCbteCble_Ogiro"] == DBNull.Value ? null : (decimal?)(reader["IdCbteCble_Ogiro"]),
                            IdOrden_giro_Tipo = Convert.ToString(reader["IdOrden_giro_Tipo"]),
                            IdProveedor = Convert.ToDecimal(reader["IdProveedor"]),
                            IdTipoCbte_Ogiro = reader["IdTipoCbte_Ogiro"] == DBNull.Value ? null : (int?)(reader["IdTipoCbte_Ogiro"]),
                            Iva = Convert.ToDouble(reader["Iva"]),
                            Nom_Proveedor = Convert.ToString(reader["Nom_Proveedor"]),
                            Observacion = Convert.ToString(reader["Observacion"]),
                            Saldo_x_pagar = Convert.ToDouble(reader["Saldo_x_pagar"]),
                            SubTotal = Convert.ToDouble(reader["SubTotal"]),
                            tipo_doc = Convert.ToString(reader["tipo_doc"]),
                            Total = Convert.ToDouble(reader["Total"]),
                            Total_a_Pagar = Convert.ToDouble(reader["Total_a_Pagar"]),
                            IdClaseProveedor = Convert.ToInt32(reader["IdClaseProveedor"]),
                            descripcion_clas_prove = Convert.ToString(reader["descripcion_clas_prove"]),
                            IdOrdenPago = reader["IdOrdenPago"] == DBNull.Value ? 0 : (decimal)(reader["IdOrdenPago"]),
                            IdPersona = Convert.ToDecimal(reader["IdPersona"]),
                            IdSucursal = reader["IdSucursal"] == DBNull.Value ? 0 : Convert.ToInt32(reader["IdSucursal"]),
                            Su_Descripcion = Convert.ToString(reader["Su_Descripcion"])
                        });
                    }
                    reader.Close();
                }
                return listadedatos;
            }

            catch (Exception ex)
            {
                return new List<XCXP_NATU_Rpt002_Info>();
            }
        }

        public enum eEstadosFiltro
        {
            Todos = 0,
            Pendiente = 1,
            Cancelado
        }
    }
}
