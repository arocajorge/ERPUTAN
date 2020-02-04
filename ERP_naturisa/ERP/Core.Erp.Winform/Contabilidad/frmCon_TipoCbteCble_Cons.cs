using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
//10 juni 2013 15H54
namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_TipoCbteCble_Cons : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Cbtecble_tipo_Info Info = new ct_Cbtecble_tipo_Info();
        ct_Cbtecble_tipo_Bus Bus = new ct_Cbtecble_tipo_Bus();
        frmCon_TipoCbteCble_Mant frm;
        string MensajeError = "";
        #endregion

        public frmCon_TipoCbteCble_Cons()
        {
            InitializeComponent();

            
        }
      
        private void frmCon_TipoCbteCble_Load(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                PrepararForm(Cl_Enumeradores.eTipo_action.grabar, Info);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PrepararForm(Cl_Enumeradores.eTipo_action.actualizar, Info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PrepararForm(Cl_Enumeradores.eTipo_action.consultar, Info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PrepararForm(Cl_Enumeradores.eTipo_action.Anular, Info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewTipoCble.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargagrid()
        {
            try
            {
                List<ct_Cbtecble_tipo_Info> LstTCble = new List<ct_Cbtecble_tipo_Info>();
                LstTCble = Bus.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);
                gridControlTipoCble.DataSource = LstTCble;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewTipoCble_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewTipoCble.GetRow(e.RowHandle) as ct_Cbtecble_tipo_Info;
                if (data == null)
                    return;
                if (data.tc_Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewTipoCble_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrepararForm(Cl_Enumeradores.eTipo_action Accion, ct_Cbtecble_tipo_Info InfoTipoCble)
        {
            try
            {
                frm = new frmCon_TipoCbteCble_Mant();
                frm.event_frmCon_TipoCbteCble_Mant_FormClosing += new frmCon_TipoCbteCble_Mant.delegate_frmCon_TipoCbteCble_Mant_FormClosing(frm_event_frmCon_TipoCbteCble_Mant_FormClosing);
                frm.set_accion(Accion);
                frm.MdiParent = this.MdiParent;

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_TipoCbtecble(InfoTipoCble);
                }
               // frm.ShowDialog();

                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCon_TipoCbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ct_Cbtecble_tipo_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (ct_Cbtecble_tipo_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Cbtecble_tipo_Info();
            }
        }
    }
}
