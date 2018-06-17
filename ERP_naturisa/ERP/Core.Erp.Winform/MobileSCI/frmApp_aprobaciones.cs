using Core.Erp.Business.General;
using Core.Erp.Business.MobileSCI;
using Core.Erp.Info.MobileSCI;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Core.Erp.Winform.MobileSCI
{
    public partial class frmApp_aprobaciones : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        cl_parametrosGenerales_Bus param;
        BindingList<tbl_movimientos_det_Info> blst_correccion;
        BindingList<tbl_movimientos_det_Info> blst_aprobacion;
        tbl_movimientos_det_Bus bus_det;
        tb_Sucursal_Bus bus_sucursal;
        tb_Bodega_Bus bus_bodega;
        #endregion

        public frmApp_aprobaciones()
        {
            InitializeComponent();
            param = cl_parametrosGenerales_Bus.Instance;
            bus_bodega = new tb_Bodega_Bus();
            bus_det = new tbl_movimientos_det_Bus();
        }

        #region Eventos
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
        private void frmApp_aprobaciones_Load(object sender, EventArgs e)
        {
            cargar_combos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        private void chk_aprobar_correccion_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_correccion.RowCount; i++)
            {
                gv_correccion.SetRowCellValue(i, A_correccion, chk_aprobar_correccion.Checked);
            }
        }

        private void chk_reprobar_correccion_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_correccion.RowCount; i++)
            {
                gv_correccion.SetRowCellValue(i, R_correccion, chk_reprobar_correccion.Checked);
            }
        }

        private void chk_aprobar_apro_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_aprobacion.RowCount; i++)
            {
                gv_aprobacion.SetRowCellValue(i, A_aprobacion, chk_aprobar_apro.Checked);
            }
        }

        private void chk_reprobar_apro_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_aprobacion.RowCount; i++)
            {
                gv_aprobacion.SetRowCellValue(i, R_aprobacion, chk_reprobar_apro.Checked);
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_correccion_Click(object sender, EventArgs e)
        {
            cmb_sucursal.Focus();
            if (correccion())
            {
                buscar();
            }
        }

        private void btn_aprobacion_Click(object sender, EventArgs e)
        {
            cmb_sucursal.Focus();
            if (aprobacion())
            {
                buscar();
            }
        }

        private void gv_correccion_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                tbl_movimientos_det_Info row = (tbl_movimientos_det_Info)gv_correccion.GetRow(e.RowHandle);
                if (row == null)
                    return;
                if (e.Column == A_correccion)
                    row.Checked_R = false;

                if (e.Column == R_correccion)
                    row.Checked_A = false;

                gc_correccion.RefreshDataSource();
            }
            catch (Exception)
            {

            }
        }

        private void gv_aprobacion_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                tbl_movimientos_det_Info row = (tbl_movimientos_det_Info)gv_aprobacion.GetRow(e.RowHandle);
                if (row == null)
                    return;
                if (e.Column == A_aprobacion)
                    row.Checked_R = false;

                if (e.Column == R_aprobacion)
                    row.Checked_A = false;

                gc_aprobacion.RefreshDataSource();
            }
            catch (Exception)
            {

            }
        }

        private void gv_correccion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                tbl_movimientos_det_Info row = (tbl_movimientos_det_Info)gv_correccion.GetRow(e.RowHandle);
                if (row == null)
                    return;
                if (e.Column == A_correccion)
                    row.Checked_R = false;

                if (e.Column == R_correccion)
                    row.Checked_A = false;

                gc_correccion.RefreshDataSource();
            }
            catch (Exception)
            {

            }
        }

        private void gv_aprobacion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                tbl_movimientos_det_Info row = (tbl_movimientos_det_Info)gv_aprobacion.GetRow(e.RowHandle);
                if (row == null)
                    return;
                if (e.Column == A_aprobacion)
                    row.Checked_R = false;

                if (e.Column == R_aprobacion)
                    row.Checked_A = false;

                gc_aprobacion.RefreshDataSource();
            }
            catch (Exception)
            {

            }
        }
        #endregion
        

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
                blst_aprobacion = new BindingList<tbl_movimientos_det_Info>();
                gc_aprobacion.DataSource = blst_aprobacion;
                blst_correccion = new BindingList<tbl_movimientos_det_Info>();
                gc_correccion.DataSource = blst_correccion;
            }
            catch (Exception)
            {
                
            }
        }
        private void buscar()
        {
            try
            {
                var lst_det = bus_det.get_list(param.IdEmpresa, cmb_sucursal.EditValue == null ? 0 : Convert.ToInt32(cmb_sucursal.EditValue), cmb_bodega.EditValue == null ? 0 : Convert.ToInt32(cmb_bodega.EditValue), de_Fecha_ini.DateTime, de_Fecha_fin.DateTime);
                blst_correccion = new BindingList<tbl_movimientos_det_Info>(lst_det.Where(q => q.Estado == "P").ToList());
                gc_correccion.DataSource = blst_correccion;
                blst_aprobacion = new BindingList<tbl_movimientos_det_Info>(lst_det.Where(q => q.Estado == "A").ToList());
                gc_aprobacion.DataSource = blst_aprobacion;
            }
            catch (Exception)
            {
                
            }
        }
        private bool aprobacion()
        {
            try
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                splashScreenManager1.ShowWaitForm();

                bus_det.Modificar_estado(blst_aprobacion.Where(q => q.Checked_R == true).ToList(), "I");
                bus_det.Aprobar(param.IdEmpresa, blst_aprobacion.Where(q => q.Checked_A == true).ToList());
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                MessageBox.Show("Registros aprobados exitósamente",param.Nombre_sistema,MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;
            }
            catch (Exception)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                MessageBox.Show("No todos los registros pudieron ser aprobados exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
        }
        private bool correccion()
        {
            try
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                splashScreenManager1.ShowWaitForm();

                bus_det.Modificar_estado(blst_correccion.Where(q => q.Checked_R == true).ToList(),"I");
                bus_det.Modificar_estado(blst_correccion.Where(q => q.Checked_A == true).ToList(), "A");

                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }

                MessageBox.Show("Registros aprobados exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;
            }
            catch (Exception)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                MessageBox.Show("No todos los registros pudieron ser aprobados exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
        }
        #endregion

        
    }
}