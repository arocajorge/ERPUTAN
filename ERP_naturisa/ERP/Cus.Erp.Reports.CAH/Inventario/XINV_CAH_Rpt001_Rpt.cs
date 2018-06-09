using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Collections.Generic;
using System.IO;

namespace Cus.Erp.Reports.CAH.Inventario
{
    public partial class XINV_CAH_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_CAH_Rpt001_Rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XINV_CAH_Rpt001_Rpt";
        }

        private void XINV_CAH_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
                lblEmpresa.Text = param.NombreEmpresa;
                lblReporte.Text = "LISTADO DE INVENTARIO FISICO";

                string msg = "";
                XINV_CAH_Rpt001_Bus Bus = new XINV_CAH_Rpt001_Bus();
                List<XINV_CAH_Rpt001_Info> lista = new List<XINV_CAH_Rpt001_Info>();

                int IdEmpresa = 0;
                int IdBodega = 0;
                int IdSucursal = 0;
                int IdBodegaFin = 0;
                int IdSucursalFin = 0;
                string IdCategoria = "";
                int IdLinea = 0;
                Boolean Registro_Cero = false;
                DateTime Fecha_corte = DateTime.Now;
                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                IdBodega = Convert.ToInt32(PIdBodega.Value);
                IdSucursal = Convert.ToInt32(PIdSucursal.Value);
                IdBodegaFin = Convert.ToInt32(PIdBodegaFin.Value);
                IdSucursalFin = Convert.ToInt32(PIdSucursalFin.Value);
                IdCategoria = Convert.ToString(this.PIdCategoria.Value);
                IdLinea = Convert.ToInt32(this.PIdLinea.Value);
                Registro_Cero = Convert.ToBoolean(this.PRegistro_Cero.Value);
                Fecha_corte = Convert.ToDateTime(PFechaFin.Value);
                lista = Bus.Get_data(IdEmpresa, IdSucursal, IdBodega, IdCategoria, IdLinea, Registro_Cero, Fecha_corte, ref msg);

                Mostrar_celdas(Convert.ToBoolean(PToma_Física.Value));

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_CAH_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_CAH_Rpt001_Rpt) };
            }
        }

        private void Mostrar_celdas(bool Toma_fisica)
        {
            try
            {
                float width_cab = tbl_cab.WidthF;
                float width_det = tbl_det.WidthF;

                if (Toma_fisica)
                {
                    lblReporte.Text = "LISTADO DE INVENTARIO PARA TOMA FISICA";

                    float width_cel_cab_cant = cel_cab_costo.WidthF + cel_cab_total.WidthF + cel_cab_cant.WidthF;
                    float width_cel_det_cant = cel_det_costo.WidthF + cel_det_total.WidthF + cel_det_cant.WidthF;

                    //Costo
                    if (tbl_cab.Rows[0].Cells.Contains(cel_cab_costo))
                        tbl_cab.Rows[0].Cells.Remove(cel_cab_costo);
                    if (tbl_det.Rows[0].Cells.Contains(cel_det_costo))
                        tbl_det.Rows[0].Cells.Remove(cel_det_costo);
                    //Total
                    if (tbl_cab.Rows[0].Cells.Contains(cel_cab_total))
                        tbl_cab.Rows[0].Cells.Remove(cel_cab_total);
                    if (tbl_det.Rows[0].Cells.Contains(cel_det_total))
                        tbl_det.Rows[0].Cells.Remove(cel_det_total);

                    //Cantidad física
                    if (!tbl_cab.Rows[0].Cells.Contains(cel_cab_cant))
                        tbl_cab.Rows[0].Cells.Add(cel_cab_cant);
                    if (!tbl_det.Rows[0].Cells.Contains(cel_det_cant))
                        tbl_det.Rows[0].Cells.Add(cel_det_cant);


                    cel_lin_total.Visible = false;
                    cel_cat_total.Visible = false;
                    cel_bod_total.Visible = false;
                    cel_suc_total.Visible = false;
                    cel_rpt_total.Visible = false;

                    cel_cab_cant.WidthF = width_cel_cab_cant;
                    cel_det_cant.WidthF = width_cel_det_cant;
                }
                else
                {
                    float width_cel_cab_total = cel_cab_total.WidthF + cel_cab_cant.WidthF;
                    float width_cel_det_total = cel_det_total.WidthF + cel_det_cant.WidthF;

                    //Costo
                    if (!tbl_cab.Rows[0].Cells.Contains(cel_cab_costo))
                        tbl_cab.Rows[0].Cells.Add(cel_cab_costo);
                    if (!tbl_det.Rows[0].Cells.Contains(cel_det_costo))
                        tbl_det.Rows[0].Cells.Add(cel_det_costo);
                    //Total
                    if (!tbl_cab.Rows[0].Cells.Contains(cel_cab_total))
                        tbl_cab.Rows[0].Cells.Add(cel_cab_total);
                    if (!tbl_det.Rows[0].Cells.Contains(cel_det_total))
                        tbl_det.Rows[0].Cells.Add(cel_det_total);
                    //Cantidad
                    if (tbl_cab.Rows[0].Cells.Contains(cel_cab_cant))
                        tbl_cab.Rows[0].Cells.Remove(cel_cab_cant);
                    if (tbl_det.Rows[0].Cells.Contains(cel_det_cant))
                        tbl_det.Rows[0].Cells.Remove(cel_det_cant);

                    cel_cab_total.WidthF = width_cel_cab_total;
                    cel_det_total.WidthF = width_cel_det_total;


                    cel_lin_total.Visible = true;
                    cel_cat_total.Visible = true;
                    cel_bod_total.Visible = true;
                    cel_suc_total.Visible = true;
                    cel_rpt_total.Visible = true;
                }
                tbl_cab.WidthF = width_cab;
                tbl_det.WidthF = width_det;

                float width_nom = cel_det_id.WidthF + cel_det_cod.WidthF + cel_det_pro.WidthF + cel_det_uni.WidthF;
                cel_lin_nom.WidthF = width_nom;
                cel_cat_nom.WidthF = width_nom;
                cel_bod_nom.WidthF = width_nom;
                cel_suc_nom.WidthF = width_nom;
                cel_rpt_nom.WidthF = width_nom;

                float width_stock = cel_det_stock.WidthF;
                cel_lin_stock.WidthF = width_stock;
                cel_cat_stock.WidthF = width_stock;
                cel_bod_stock.WidthF = width_stock;
                cel_suc_stock.WidthF = width_stock;
                cel_rpt_stock.WidthF = width_stock;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_CAH_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_CAH_Rpt001_Rpt) };
            }
        }
    }
}
