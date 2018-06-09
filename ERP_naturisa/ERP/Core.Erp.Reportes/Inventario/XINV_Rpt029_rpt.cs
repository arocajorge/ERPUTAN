using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;
using System.Collections.Generic;
using System.IO;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt029_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<int> lst_bod = new List<int>();

        public XINV_Rpt029_rpt()
        {
            InitializeComponent();
        }

        public void set_lista(List<int> _lst_bod)
        {
            try
            {
                lst_bod = _lst_bod;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_lista", ex.Message), ex) { EntityType = typeof(XINV_Rpt029_rpt) };
            }
        }

        private void XINV_Rpt029_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblUsuario.Text = param.IdUsuario;
                lblFecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
                lblEmpresa.Text = param.NombreEmpresa;

                string msg = "";
                XINV_Rpt029_Bus Bus = new XINV_Rpt029_Bus();
                List<XINV_Rpt029_Info> lista = new List<XINV_Rpt029_Info>();

                int IdEmpresa = 0;
                int IdSucursal = 0;
                int IdSucursalFin = 0;
                Boolean Registro_Cero = false;
                DateTime Fecha_corte = DateTime.Now;
                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                Registro_Cero = Convert.ToBoolean(this.PRegistro_Cero.Value);
                Fecha_corte = Convert.ToDateTime(FechaFin.Value);

                lista = Bus.Get_data(IdEmpresa, IdSucursal, lst_bod,  Registro_Cero,Fecha_corte, ref msg);
                
                Mostrar_celdas(Convert.ToBoolean(P_toma_física.Value));

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt029_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt029_rpt) };
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
                    float width_cel_cab_cant = cel_cab_costo.WidthF + cel_cab_total.WidthF + cel_cab_cant.WidthF;
                    float width_cel_det_cant = cel_det_costo.WidthF + cel_det_total.WidthF + cel_det_cant.WidthF;

                    //Costo
                    if(tbl_cab.Rows[0].Cells.Contains(cel_cab_costo))
                        tbl_cab.Rows[0].Cells.Remove(cel_cab_costo);
                    if(tbl_det.Rows[0].Cells.Contains(cel_det_costo))
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

                    cel_bod_total.Visible = true;
                    cel_suc_total.Visible = true;
                    cel_rpt_total.Visible = true;
                }

                tbl_cab.WidthF = width_cab;
                tbl_det.WidthF = width_det;
                
                

                float width_nom = cel_det_id.WidthF + cel_det_cod.WidthF + cel_det_pro.WidthF + cel_det_uni.WidthF;
                cel_bod_nom.WidthF = width_nom;
                cel_suc_nom.WidthF = width_nom;
                cel_rpt_nom.WidthF = width_nom;

                float width_stock = cel_det_stock.WidthF;
                cel_bod_stock.WidthF = width_stock;
                cel_suc_stock.WidthF = width_stock;
                cel_rpt_stock.WidthF = width_stock;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt029_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt029_rpt) };
            }
        }

    }
}
