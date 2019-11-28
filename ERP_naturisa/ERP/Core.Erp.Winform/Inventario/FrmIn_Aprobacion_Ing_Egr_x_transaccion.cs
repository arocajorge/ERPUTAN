using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Aprobacion_Ing_Egr_x_transaccion : Form
    {
        #region
        BindingList<in_Ing_Egr_Inven_Info> blist_ing_egr = new BindingList<in_Ing_Egr_Inven_Info>();
        in_Ing_Egr_Inven_Bus bus_ingr_egr = new in_Ing_Egr_Inven_Bus();
        in_Ing_Egr_Inven_det_Bus bus_ingr_egr_det = new in_Ing_Egr_Inven_det_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<in_Ing_Egr_Inven_Info> list_validar = new List<in_Ing_Egr_Inven_Info>();
        List<in_Ing_Egr_Inven_det_Info> list_aprobar = new List<in_Ing_Egr_Inven_det_Info>();
        in_Ing_Egr_Inven_Info Info_validar = new in_Ing_Egr_Inven_Info();
        vwin_Ingr_Egr_Inven_det_Bus bus_IngEgrDet = new vwin_Ingr_Egr_Inven_det_Bus();
        in_movi_inve_Bus bus_movi = new in_movi_inve_Bus();
        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();
        List<in_producto_x_tb_bodega_Info> ListaParametrizacion = new List<in_producto_x_tb_bodega_Info>();
        in_producto_x_tb_bodega_Bus bus_productoPorBodega = new in_producto_x_tb_bodega_Bus();
         string Signo = "";
        #endregion

        public FrmIn_Aprobacion_Ing_Egr_x_transaccion()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (Aprobar())
                    {
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (Aprobar())
                    {
                        this.Close();
                    }                    
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            try
            {
                if (blist_ing_egr.Where(q=>q.Checked==true).Count()==0)
                {
                    MessageBox.Show("Debe seleccionar una transacción para aprobar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Aprobar()
        {
            try
            {
                ListaParametrizacion = new List<in_producto_x_tb_bodega_Info>();

                string mensaje = string.Empty;
                ProgressBar_recosteo.EditValue = 0;
                ProgressBar_recosteo.Properties.Minimum = 1;
                ProgressBar_recosteo.Properties.Maximum = blist_ing_egr.Where(q => q.Checked == true).ToList().Count;
                ProgressBar_recosteo.Properties.Step = 1;
                ProgressBar_recosteo.Properties.PercentView = true;



                foreach (var item in blist_ing_egr.Where(q => q.Checked == true).ToList())
                {
                    ListaParametrizacion.AddRange(bus_productoPorBodega.GetListMovimientosSinParametrizacion(item.IdEmpresa, item.IdSucursal, item.IdMovi_inven_tipo, item.IdNumMovi));

                    if (!bus_movi.AprobarData(item.IdEmpresa, item.IdSucursal, item.IdMovi_inven_tipo, item.IdNumMovi, item.signo, param.IdUsuario, ref mensaje))                    
                    {
                        MessageBox.Show("Error al Actualizar Estados, " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Buscar();
                        return false;
                    }
                    ProgressBar_recosteo.PerformStep();
                    ProgressBar_recosteo.Update();
                    Application.DoEvents();
                }
                MessageBox.Show("Registros aprobados exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (ListaParametrizacion.Count > 0)
                {
                    FrmIn_ProductoPorBodegaParametrizados frm = new FrmIn_ProductoPorBodegaParametrizados();
                    frm.ListaDetalle = ListaParametrizacion;
                    frm.ShowDialog();
                }

                Buscar();
                return true;
            }
            catch (Exception ex)
            {
                Buscar();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Limpiar()
        {
            try
            {
                blist_ing_egr = new BindingList<in_Ing_Egr_Inven_Info>();
                gridControlAprobación.DataSource = blist_ing_egr;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar()
        {
            try
            {
                Get_signo();
                int IdSucursal = cmb_sucursal.EditValue == null ? 0 : Convert.ToInt32(cmb_sucursal.EditValue);
                blist_ing_egr = new BindingList<in_Ing_Egr_Inven_Info>(bus_ingr_egr.Get_List_aprobacion_x_transaccion(param.IdEmpresa,IdSucursal, Signo, de_Fecha_ini.DateTime.Date, de_Fecha_fin.DateTime.Date));
                gridControlAprobación.DataSource = null;
                gridControlAprobación.DataSource = blist_ing_egr;
              
                if (blist_ing_egr.Count==0)
                {
                    MessageBox.Show("No existen movimientos pendientes por aprobar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                var lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_sucursal.Properties.DataSource = lst_sucursal;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void opt_ingreso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Get_signo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void opt_egreso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Get_signo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Sucursal_Bodega_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_signo()
        {
            try
            {
                if (opt_egreso.Checked)
                    Signo = "-";
                else
                    if (opt_ingreso.Checked)
                        Signo = "+";
                    else
                        Signo = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_Aprobacion_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                gridViewAprobacion.SetRowCellValue(gridViewAprobacion.FocusedRowHandle, colCheck, e.NewValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Aprobacion_Ing_Egr_x_transaccion_Load(object sender, EventArgs e)
        {
            de_Fecha_ini.DateTime = DateTime.Now.Date.AddMonths(-1);
            de_Fecha_fin.DateTime = DateTime.Now.Date;
            cargar_combos();
        }

        private void chk_seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewAprobacion.RowCount; i++)
            {
                gridViewAprobacion.SetRowCellValue(i, colCheck, chk_seleccionar_visibles.Checked);
            }
        }

        private void gridViewAprobacion_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == colCheck)
                {
                    gridViewAprobacion.SetRowCellValue(e.RowHandle, colCheck, e.Value);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void gridControlAprobación_Click(object sender, EventArgs e)
        {

        }
    }
}
