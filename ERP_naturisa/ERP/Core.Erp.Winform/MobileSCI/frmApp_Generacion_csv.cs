using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using Core.Erp.Info.MobileSCI;
using Core.Erp.Business.MobileSCI;
using System.Linq;
using System.IO;

namespace Core.Erp.Winform.MobileSCI
{
    public partial class frmApp_Generacion_csv : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        cl_parametrosGenerales_Bus param;
        BindingList<tbl_movimientos_det_Info> blst_csv;
        tbl_movimientos_det_Bus bus_det;
        tb_Sucursal_Bus bus_sucursal;
        tb_Bodega_Bus bus_bodega;
        #endregion

        public frmApp_Generacion_csv()
        {
            InitializeComponent();
            param = cl_parametrosGenerales_Bus.Instance;
            bus_bodega = new tb_Bodega_Bus();
            bus_det = new tbl_movimientos_det_Bus();
        }

        private void frmApp_Generacion_csv_Load(object sender, EventArgs e)
        {
            cargar_combos();
        }

        private void cmb_sucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_sucursal.EditValue == null)
                    cmb_bodega.Properties.DataSource = null;
                else
                    cmb_bodega.Properties.DataSource = bus_bodega.Get_List_Bodega(param.IdEmpresa, Convert.ToInt32(cmb_sucursal.EditValue));

                cmb_bodega.EditValue = null;
            }
            catch (Exception)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btn_generar_csv_Click(object sender, EventArgs e)
        {
            try
            {

                if (File.Exists(cmbRuta.Text + param.InfoEmpresa.NombreComercial + de_Fecha_ini.DateTime.ToString("yyyyMMdd") + de_Fecha_fin.DateTime.ToString("yyyyMMdd") + ".csv"))
                {
                    File.Delete(cmbRuta.Text + param.InfoEmpresa.NombreComercial + de_Fecha_ini.DateTime.ToString("yyyyMMdd") + de_Fecha_fin.DateTime.ToString("yyyyMMdd") + ".csv");
                }

                char carSeparador = '|';
                

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(cmbRuta.Text + param.InfoEmpresa.NombreComercial + de_Fecha_ini.DateTime.ToString("yyyyMMdd") + de_Fecha_fin.DateTime.ToString("yyyyMMdd") + ".csv", true))
                {
                    foreach (var item in blst_csv.Where(q => q.Checked_A == true).ToList())
                    {
                        string linea = "";
                        linea += item.CodProduccionPro + carSeparador;
                        linea += item.CodProduccionSC + carSeparador;
                        linea += item.Fecha.ToString("dd/MM/yyyy") + carSeparador;
                        double Entero = Math.Truncate(item.cantidad);
                        linea += Entero.ToString() + "." + Math.Round(item.cantidad - Entero, 10, MidpointRounding.AwayFromZero).ToString();
                        linea.Trim();
                        file.WriteLine(linea);
                    }                    
                    file.Close();
                }

                MessageBox.Show("Archivo generado exitósamente",param.Nombre_sistema,MessageBoxButtons.OK);
                
            }
            catch (Exception)
            {
            }
        
        }


        #region Metodos
        private void cargar_combos()
        {
            try
            {
                bus_sucursal = new tb_Sucursal_Bus();
                cmb_sucursal.Properties.DataSource = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_sucursal.EditValue = null;
                de_Fecha_ini.DateTime = DateTime.Now.Date.AddMonths(-1);
                de_Fecha_fin.DateTime = DateTime.Now.Date;
                blst_csv = new BindingList<tbl_movimientos_det_Info>();
                gc_generacion.DataSource = blst_csv;

                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                cmbRuta.Text = filePath + @"\";
            }
            catch (Exception)
            {
                
            }
        }
        private void buscar()
        {
            try
            {
                var lst_det = bus_det.get_list_csv(param.IdEmpresa, cmb_sucursal.EditValue == null ? 0 : Convert.ToInt32(cmb_sucursal.EditValue), cmb_bodega.EditValue == null ? 0 : Convert.ToInt32(cmb_bodega.EditValue), de_Fecha_ini.DateTime, de_Fecha_fin.DateTime);
                blst_csv = new BindingList<tbl_movimientos_det_Info>(lst_det);
                gc_generacion.DataSource = blst_csv;
            }
            catch (Exception)
            {

            }
        }
        #endregion

        private void gv_generacion_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                tbl_movimientos_det_Info row = (tbl_movimientos_det_Info)gv_generacion.GetRow(e.RowHandle);
                if (row == null)
                    return;
                gc_generacion.RefreshDataSource();
            }
            catch (Exception)
            {
                
            }            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbRuta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (FolderBrowserDialog dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "Select a folder";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {

                        cmbRuta.Text = dlg.SelectedPath + @"\";
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        
    }
}