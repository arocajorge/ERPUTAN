using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Winform.Contabilidad;

namespace Core.Erp.Winform.Contabilidad_FJ
{
    public partial class frmCon_Punto_Cargo_Cons_FJ : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_punto_cargo_Info Info = new ct_punto_cargo_Info();
        ct_punto_cargo_Bus Bus = new ct_punto_cargo_Bus();
        frmCon_Punto_Cargo_Mant_FJ frm = new frmCon_Punto_Cargo_Mant_FJ();


        public frmCon_Punto_Cargo_Cons_FJ()
        {
            InitializeComponent();

            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_event_btnImprimir_ItemClick;
        }

        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridView_Punto_Cargo.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (ct_punto_cargo_Info)gridView_Punto_Cargo.GetFocusedRow();
                if (Info != null)
                {
                    if (Info.Estado == "I")
                    {
                        MessageBox.Show("El registro ya fue Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                    else
                    {
                        frm = new frmCon_Punto_Cargo_Mant_FJ(Cl_Enumeradores.eTipo_action.Anular);
                        frm.Text = frm.Text + "***ANULAR REGISTRO***";
                        frm._SetInfo = Info;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_frmCon_Punto_Cargo_Mant_FJ_FormClosing += frm_event_frmCon_Punto_Cargo_Mant_FormClosing; 
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (ct_punto_cargo_Info)gridView_Punto_Cargo.GetFocusedRow();
                if (Info != null)
                {

                    frm = new frmCon_Punto_Cargo_Mant_FJ(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm._SetInfo = Info;
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_frmCon_Punto_Cargo_Mant_FJ_FormClosing += frm_event_frmCon_Punto_Cargo_Mant_FormClosing; 

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (ct_punto_cargo_Info)gridView_Punto_Cargo.GetFocusedRow();
                if (Info != null)
                {
                        frm = new frmCon_Punto_Cargo_Mant_FJ(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.Text = frm.Text + "***ACTUALIZAR REGISTRO***";
                        frm._SetInfo = Info;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_frmCon_Punto_Cargo_Mant_FJ_FormClosing += frm_event_frmCon_Punto_Cargo_Mant_FormClosing; 
                    
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmCon_Punto_Cargo_Mant_FJ(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.Show();
                frm.MdiParent = this.MdiParent;
                frm.event_frmCon_Punto_Cargo_Mant_FJ_FormClosing += frm_event_frmCon_Punto_Cargo_Mant_FormClosing; 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }             
        }

        void frm_event_frmCon_Punto_Cargo_Mant_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmCon_Punto_Cargo_Cons_Load(object sender, EventArgs e)
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

        private void cargagrid()
        {
            try
            {
                List<ct_punto_cargo_Info> LstInfo = new List<ct_punto_cargo_Info>();
                LstInfo = Bus.Get_List_punto_Cargo_con_subcentro(param.IdEmpresa);
                gridControl_Punto_Cargo.DataSource = LstInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_Punto_Cargo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = (ct_punto_cargo_Info)gridView_Punto_Cargo.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_Punto_Cargo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_Punto_Cargo.GetRow(e.RowHandle) as ct_punto_cargo_Info;
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




    }
}
