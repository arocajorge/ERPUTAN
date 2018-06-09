using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt007_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

        public List<XINV_Rpt007_Info> Obtener_Data(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdAjustefisico) 
        {
            List<XINV_Rpt007_Info> lista= new List<XINV_Rpt007_Info>();
            try
            {
                using (Entities_Inventario_General conexion = new Entities_Inventario_General())
                {
                    var Items = from q in conexion.vwINV_Rpt007
                                where q.IdEmpresa == IdEmpresa 
                                && q.IdSucursal == IdSucursal
                                && q.IdBodega == IdBodega
                                && q.IdAjusteFisico == IdAjustefisico
                                select q;
                    
                    foreach (var item in Items)
                    {
                        XINV_Rpt007_Info Info= new XINV_Rpt007_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdAjusteFisico = item.IdAjusteFisico;
                        Info.CodAjusteFisico = item.CodAjusteFisico;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdBodega = item.IdBodega;
                        if (item.IdNumMovi_Ing != null) Info.IdNumMovi_Ing = item.IdNumMovi_Ing;
                        if (item.IdNumMovi_Ing != null) Info.IdMovi_inven_tipo_Ing = item.IdMovi_inven_tipo_Ing;
                        if (item.IdNumMovi_Egr != null) Info.IdNumMovi_Egr = item.IdNumMovi_Egr = item.IdNumMovi_Egr;
                        if (item.IdNumMovi_Egr != null) Info.IdMovi_inven_tipo_Egr = item.IdMovi_inven_tipo_Egr;
                        Info.IdProducto = item.IdProducto;
                        Info.pr_codigo = item.pr_codigo;
                        Info.pr_descripcion = item.pr_descripcion;
                        Info.StockFisico = item.StockFisico;
                        Info.StockSistema = item.StockSistema;
                        Info.CantidadAjustada = item.CantidadAjustada;
                        Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        Info.nom_estado_aprobacion = item.nom_estado_aprobacion;
                        Info.Observacion = item.Observacion;
                        Info.Fecha = item.Fecha;
                        Info.Estado = item.Estado;
                        Info.IdCentroCosto = item.IdCentroCosto;
                        Info.IdCategoria = item.IdCategoria;
                        Info.ca_Categoria = item.ca_Categoria;
                        Info.IdLinea = item.IdLinea;
                        Info.nom_linea = item.nom_linea;
                        Info.Centro_costo = item.Centro_costo;
                        if (item.IdNumMovi_Ing != null) Info.Tipo_ingreso = item.Tipo_ingreso;
                        if (item.IdNumMovi_Egr != null) Info.Tipo_egreso = item.Tipo_egreso;
                        Info.bo_Descripcion = "["+item.IdBodega.ToString()+"] "+item.bo_Descripcion;
                        Info.Su_Descripcion = "[" + item.IdSucursal.ToString() + "] " + item.Su_Descripcion;
                        Info.nom_unidad_medida = item.nom_unidad_medida;
                        Info.costo = item.costo;
                        Info.Total_costo = item.Total_costo;
                        Info.Tipo_ingreso = item.Tipo_ingreso;
                        Info.Tipo_egreso = item.Tipo_egreso;


                        lista.Add(Info);
                    }
                    return lista;
                }
            }
            catch (Exception)
            {

                return new List<XINV_Rpt007_Info>();
            }
        }
    }
}
