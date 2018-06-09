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

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_Punto_Cargo_Cons : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_punto_cargo_Info Info = new ct_punto_cargo_Info();
        ct_punto_cargo_Bus Bus = new ct_punto_cargo_Bus();
        frmCon_Punto_Cargo_Mant frm = new frmCon_Punto_Cargo_Mant();
        List<ct_punto_cargo_Info> LstInfo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Info Info_punto_cargo = new ct_punto_cargo_Info();
        bool Cargar_solo_grid = false;
        public Boolean Tipo_grilla { get { return this.Cargar_solo_grid; } set { this.Cargar_solo_grid = value; } }
        int RowHandle = 0;

        public frmCon_Punto_Cargo_Cons()
        {
            InitializeComponent(); System.GC.Collect();


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
                        frm = new frmCon_Punto_Cargo_Mant(Cl_Enumeradores.eTipo_action.Anular);
                        frm.Text = frm.Text + "***ANULAR REGISTRO***";
                        frm._SetInfo = Info;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_frmCon_Punto_Cargo_Mant_FormClosing += frm_event_frmCon_Punto_Cargo_Mant_FormClosing; 
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

                    frm = new frmCon_Punto_Cargo_Mant(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm._SetInfo = Info;
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_frmCon_Punto_Cargo_Mant_FormClosing += frm_event_frmCon_Punto_Cargo_Mant_FormClosing; 

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
                        frm = new frmCon_Punto_Cargo_Mant(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.Text = frm.Text + "***ACTUALIZAR REGISTRO***";
                        frm._SetInfo = Info;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_frmCon_Punto_Cargo_Mant_FormClosing += frm_event_frmCon_Punto_Cargo_Mant_FormClosing; 
                    
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
                frm = new frmCon_Punto_Cargo_Mant(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.Show();
                frm.MdiParent = this.MdiParent;
                frm.event_frmCon_Punto_Cargo_Mant_FormClosing += frm_event_frmCon_Punto_Cargo_Mant_FormClosing; 
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
                if (!Cargar_solo_grid)
                {
                    cargagrid();
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cargar_grid_x_grupo(int IdGrupo)
        {
            try
            {
                Cargar_solo_grid = true;
                this.WindowState = FormWindowState.Normal;                
                this.ControlBox = false;
                this.ucGe_Menu.Hide();
                this.ucGe_BarraEstado.Hide();
                this.toolStrip1.Visible = true;
                this.btnVaciar.Visible = true;
                this.Text = "";
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                LstInfo = Bus.Get_list_PuntoCargo_x_grupo(param.IdEmpresa,IdGrupo);
                gridControl_Punto_Cargo.DataSource = LstInfo;
                gridView_Punto_Cargo.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cargar_Puntos_Cargos()
        {
            try
            {
                Cargar_solo_grid = true;
                this.WindowState = FormWindowState.Normal;
                this.ControlBox = false;
                this.ucGe_Menu.Hide();
                this.ucGe_BarraEstado.Hide();
                this.toolStrip1.Visible = true;
                this.btnVaciar.Visible = true;
                this.Text = "";
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                LstInfo = Bus.Get_list_PuntoCargo_x_grupo(param.IdEmpresa);
                gridControl_Punto_Cargo.DataSource = LstInfo;
                gridView_Punto_Cargo.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
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
                LstInfo = Bus.Get_List_PuntoCargo(param.IdEmpresa);
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

        private void gridView_Punto_Cargo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Cargar_solo_grid)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ct_punto_cargo_Info Get_Info()
        {
            try
            {
                if (Info_punto_cargo!=null)
                {
                    Info_punto_cargo = Info_punto_cargo.IdEmpresa == 0 ? null : Info_punto_cargo;
                }

                return Info_punto_cargo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void gridView_Punto_Cargo_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Info_punto_cargo = (ct_punto_cargo_Info)gridView_Punto_Cargo.GetRow(e.RowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnVaciar.Visible)
                {
                    Info_punto_cargo = null;
                    this.Close();    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salir_cons_Click(object sender, EventArgs e)
        {
            Info_punto_cargo = null;
            this.Close();
        }

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Cargar_solo_grid)
                {
                    cargagrid();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_Punto_Cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Cargar_solo_grid)
                {
                    if (e.KeyChar == (char)Keys.Enter)
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

        private void gridView_Punto_Cargo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                 RowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_Punto_Cargo_Cons_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Info_punto_cargo = (ct_punto_cargo_Info)gridView_Punto_Cargo.GetRow(RowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void disposed()
        {
            try
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_Punto_Cargo_Cons_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                disposed();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void Cargar_grid_x_punto_cargo()
        {
            try
            {
                Cargar_solo_grid = true;
                this.WindowState = FormWindowState.Normal;
                this.ControlBox = false;
                this.ucGe_Menu.Hide();
                this.ucGe_BarraEstado.Hide();
                this.toolStrip1.Visible = true;
                this.btnVaciar.Visible = true;
                this.Text = "";
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                LstInfo = Bus.Get_List_punto_Cargo_con_subcentro(param.IdEmpresa);
                gridControl_Punto_Cargo.DataSource = LstInfo;
                gridView_Punto_Cargo.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }    
}
