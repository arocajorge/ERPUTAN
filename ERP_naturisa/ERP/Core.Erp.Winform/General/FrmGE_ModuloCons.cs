using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.General
{
    public partial class FrmGE_ModuloCons : Form
    {
        #region Declaración de Variables
        tb_modulo_Bus bus_modulo = new tb_modulo_Bus();
        tb_modulo_Info info_modulo = new tb_modulo_Info();
        cl_parametrosGenerales_Bus Parametros = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        FrmGE_ModuloMant frm;
        #endregion

        public FrmGE_ModuloCons()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new FrmGE_ModuloMant();
                frm.event_FrmGE_ModuloMant_FormClosing += frm_event_FrmGE_ModuloMant_FormClosing;                
                frm.Text = frm.Text + "***NUEVO REGISTRO***";
                frm.info_mod = info_modulo;
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmGE_ModuloMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrid();
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

                info_modulo = (tb_modulo_Info)gridViewmodulo.GetFocusedRow();

                if (info_modulo != null)
                {
                    frm = new FrmGE_ModuloMant();
                    frm.event_FrmGE_ModuloMant_FormClosing += frm_event_FrmGE_ModuloMant_FormClosing;                
                    frm.Text = frm.Text + "***MODIFICAR REGISTRO***";
                    frm.info_mod = info_modulo;
                    frm.set_Modulo(info_modulo);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
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

                info_modulo = (tb_modulo_Info)gridViewmodulo.GetFocusedRow();

                if (info_modulo != null)
                {
                    frm = new FrmGE_ModuloMant();
                    frm.event_FrmGE_ModuloMant_FormClosing += frm_event_FrmGE_ModuloMant_FormClosing;
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm.info_mod = info_modulo;
                    frm.set_Modulo(info_modulo);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
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
                gridControlmodulo.ShowRibbonPrintPreview();                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGE_ModuloCons_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarGrid()
        {
            try
            {
                gridControlmodulo.DataSource = bus_modulo.Get_list_Modulo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
