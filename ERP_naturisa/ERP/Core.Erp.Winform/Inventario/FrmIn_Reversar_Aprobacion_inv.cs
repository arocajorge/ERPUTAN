using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Reversar_Aprobacion_inv : Form
    {
        #region
        BindingList<in_Ing_Egr_Inven_Info> blist_ing_egr = new BindingList<in_Ing_Egr_Inven_Info>();
        in_Ing_Egr_Inven_Bus bus_ingr_egr = new in_Ing_Egr_Inven_Bus();
        in_Ing_Egr_Inven_det_Bus bus_ingr_egr_det = new in_Ing_Egr_Inven_det_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<in_Ing_Egr_Inven_Info> list_validar = new List<in_Ing_Egr_Inven_Info>();
        List<in_Ing_Egr_Inven_Info> list_reversar = new List<in_Ing_Egr_Inven_Info>();
        in_Ing_Egr_Inven_Info Info_reversar = new in_Ing_Egr_Inven_Info();
        vwin_Ingr_Egr_Inven_det_Bus bus_IngEgrDet = new vwin_Ingr_Egr_Inven_det_Bus();

        int IdSucursal = 0;
        int IdBodega = 0;
        string Signo = "";
        int IdTipoMovi = 0;
        DateTime FechaIni, FechaFin;
        string tipo = "";
        #endregion

        public FrmIn_Reversar_Aprobacion_inv()
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
                        Buscar();
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
                dt_F_Desde.Focus();

                if (blist_ing_egr.Where(q => q.Checked == true).Count() == 0)
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
                Get_trans_checked();

                string mensaje = "";
                if (MessageBox.Show("¿Desea reversar los comprobantes seleccionados?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    foreach (var item in list_reversar)
                    {
                        if (bus_ingr_egr.Reversar_Aprobacion(item.IdEmpresa, item.IdSucursal, item.IdMovi_inven_tipo, item.IdNumMovi, item.Genera_Movi_Inven))
                        {
                            MessageBox.Show("El IdNumMovi #: " + item.IdNumMovi + " de la sucursal #: " + item.IdSucursal + " ha sido reversado con éxito.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el movimiento, " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
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
                IdSucursal = ucGe_Sucursal_combo.get_SucursalInfo() == null ? 0 : ucGe_Sucursal_combo.get_SucursalInfo().IdSucursal;

                FechaIni = Convert.ToDateTime(dt_F_Desde.EditValue);
                FechaFin = Convert.ToDateTime(dt_F_Hasta.EditValue);


                blist_ing_egr = new BindingList<in_Ing_Egr_Inven_Info>(bus_ingr_egr.Get_List_Ing_Egr_Inven_x_in_movi_inve(param.IdEmpresa, IdSucursal, FechaIni, FechaFin, Signo).ToList());
                gridControlAprobación.DataSource = blist_ing_egr;

                if (blist_ing_egr.Count == 0)
                {
                    MessageBox.Show("No existen movimientos aprobados para reversar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

        private void Get_trans_checked()
        {
            try
            {
                dt_F_Desde.Focus();
                list_reversar = new List<in_Ing_Egr_Inven_Info>();
                list_validar = new List<in_Ing_Egr_Inven_Info>(blist_ing_egr.Where(q => q.Checked == true).ToList());
                
                Buscar();
                foreach (var item in list_validar)
                {
                    Info_reversar = blist_ing_egr.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi);

                    if (Info_reversar != null)
                    {
                        blist_ing_egr.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi).Checked = true;
                        list_reversar.Add(Info_reversar);
                    }
                }
                gridControlAprobación.DataSource = blist_ing_egr;
                gridControlAprobación.RefreshDataSource();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < gridViewAprobacion.RowCount; i++)
                {
                    gridViewAprobacion.SetRowCellValue(i, colCheck, chk_seleccionar_visibles.Checked);
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Reversar_Aprobacion_inv_Load(object sender, EventArgs e)
        {
            try
            {
                ucGe_Menu_Superior_Mant1.btnAprobar.Text = "Reversar";
                ucGe_Menu_Superior_Mant1.btnAprobarGuardarSalir.Text = "Reversar y salir";
                dt_F_Desde.EditValue = DateTime.Now.Date.AddMonths(-1);
                dt_F_Hasta.EditValue = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
    }
}
