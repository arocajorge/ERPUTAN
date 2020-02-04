using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_PlanCuenta_Niveles_Consulta : Form
    {
        #region Declaración de Variables
        ct_Plancta_nivel_Bus _PlanCtaNivelBus = new ct_Plancta_nivel_Bus();
        ct_Plancta_nivel_Info _PlanCtaNivelInfo = new ct_Plancta_nivel_Info();
        cl_parametrosGenerales_Bus Parametros = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmCon_PlanCuenta_Niveles_Mant frm = new frmCon_PlanCuenta_Niveles_Mant();

        #endregion
        
        public frmCon_PlanCuenta_Niveles_Consulta()
        {
            InitializeComponent();
        }

        public void cargargrid()
        {
            try
            {
                gridNivel.DataSource = _PlanCtaNivelBus.Get_list_Plancta_nivel(Parametros.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void frmCon_PlanCuenta_Niveles_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                cargargrid();
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmCon_PlanCuenta_Niveles_Mant();
                frm.event_frmCon_PlanCuenta_Niveles_Mant_FormClosing += frm_event_frmCon_PlanCuenta_Niveles_Mant_FormClosing;
                frm.Text = frm.Text + "***NUEVO REGISTRO***";
                frm._PlanCtaNivel_info = _PlanCtaNivelInfo;
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 

            }
        }

        void frm_event_frmCon_PlanCuenta_Niveles_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargargrid();
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

                _PlanCtaNivelInfo = (ct_Plancta_nivel_Info)gridViewNivel.GetFocusedRow();

                if (_PlanCtaNivelInfo != null)
                {
                    frm = new frmCon_PlanCuenta_Niveles_Mant();
                    frm.event_frmCon_PlanCuenta_Niveles_Mant_FormClosing += frm_event_frmCon_PlanCuenta_Niveles_Mant_FormClosing;
                    frm.Text = frm.Text + "***MODIFICAR REGISTRO***";
                    frm._PlanCtaNivel_info = _PlanCtaNivelInfo;
                    frm.set_PlanCtaNivel(_PlanCtaNivelInfo);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

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

                _PlanCtaNivelInfo = (ct_Plancta_nivel_Info)gridViewNivel.GetFocusedRow();

                if (_PlanCtaNivelInfo != null)
                {
                    frm = new frmCon_PlanCuenta_Niveles_Mant();
                    frm.event_frmCon_PlanCuenta_Niveles_Mant_FormClosing += frm_event_frmCon_PlanCuenta_Niveles_Mant_FormClosing;
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm._PlanCtaNivel_info = _PlanCtaNivelInfo;
                    frm.set_PlanCtaNivel(_PlanCtaNivelInfo);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);                    
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

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

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                _PlanCtaNivelInfo = (ct_Plancta_nivel_Info)gridViewNivel.GetFocusedRow();

                if (_PlanCtaNivelInfo != null)
                {
                    frm = new frmCon_PlanCuenta_Niveles_Mant();
                    frm.event_frmCon_PlanCuenta_Niveles_Mant_FormClosing += frm_event_frmCon_PlanCuenta_Niveles_Mant_FormClosing;
                    frm.Text = frm.Text + "***ANULAR REGISTRO***";
                    frm._PlanCtaNivel_info = _PlanCtaNivelInfo;
                    frm.set_PlanCtaNivel(_PlanCtaNivelInfo);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

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

                gridViewNivel.ShowRibbonPrintPreview();
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

        private void gridViewNivel_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewNivel.GetRow(e.RowHandle) as ct_Plancta_nivel_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void gridViewNivel_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _PlanCtaNivelInfo = (ct_Plancta_nivel_Info)gridViewNivel.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

    
    }
}
