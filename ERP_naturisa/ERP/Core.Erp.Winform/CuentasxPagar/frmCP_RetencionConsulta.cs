using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_RetencionConsulta : Form
    {
        
        #region DEclaración de variables
        //Bus       
        cp_retencion_Bus BusReten = new cp_retencion_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //BindingList
        BindingList<cp_retencion_Info> BindinReten = new BindingList<cp_retencion_Info>();
        cp_retencion_Info Info = new cp_retencion_Info();
        frmCP_RetencionMant frmMant = new frmCP_RetencionMant();
        #endregion
        
        
        public frmCP_RetencionConsulta()
        {
            InitializeComponent();
            frmMant.event_frmCP_RetencionMant_FormClosing+=frmMant_event_frmCP_RetencionMant_FormClosing;
            
            

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmMant = new frmCP_RetencionMant();
                frmMant.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frmMant.event_frmCP_RetencionMant_FormClosing += frmMant_event_frmCP_RetencionMant_FormClosing;
                frmMant.Text = frmMant.Text + " ***NUEVO REGISTRO***";
                frmMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (cp_retencion_Info)this.gridViewConsRet.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un Registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.Estado == "I")
                    MessageBox.Show("No se pueden modificar Retenciones Inactivas", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                        frmMant = new frmCP_RetencionMant();
                        frmMant.Set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        frmMant.event_frmCP_RetencionMant_FormClosing += frmMant_event_frmCP_RetencionMant_FormClosing;
                        frmMant.Text = frmMant.Text + " ***ACTUALIZAR REGISTRO***";
                        frmMant.Set_Info_Retencion(Info);
                        frmMant.Show();
                   
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (cp_retencion_Info)this.gridViewConsRet.GetFocusedRow();
                if (Info == null)
                {
                    MessageBox.Show("Seleccione un Registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else                 
                {
                    frmMant = new frmCP_RetencionMant();
                    frmMant.Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frmMant.event_frmCP_RetencionMant_FormClosing += frmMant_event_frmCP_RetencionMant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***CONSULTAR REGISTRO***";
                    frmMant.Set_Info_Retencion(Info);
                    frmMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (cp_retencion_Info)this.gridViewConsRet.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un Registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.Estado == "I")
                    MessageBox.Show("La Retención # : " + Info.IdCbte_CXP + " ya fue Anulada", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmMant = new frmCP_RetencionMant();
                    frmMant.Set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frmMant.event_frmCP_RetencionMant_FormClosing += frmMant_event_frmCP_RetencionMant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***ANULAR REGISTRO***";
                    frmMant.Set_Info_Retencion(Info);
                    frmMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        void frmMant_event_frmCP_RetencionMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargaGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void cargaGrid()
        {
            try
            {
                DateTime FechaIni = ucGe_Menu.fecha_desde;
                DateTime FechaFin = ucGe_Menu.fecha_hasta;
                List<cp_retencion_Info> lista = new List<cp_retencion_Info>();
                lista = BusReten.Get_List_retencion(param.IdEmpresa, FechaIni, FechaFin);
                BindinReten = new BindingList<cp_retencion_Info>(lista);
                gridControlConsRet.DataSource = BindinReten;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                          
        }

        private void frmCP_RetencionConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                
                
                cargaGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConsRet_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = new cp_retencion_Info();
                Info = this.gridViewConsRet.GetFocusedRow() as cp_retencion_Info;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConsRet_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewConsRet.GetRow(e.RowHandle) as cp_retencion_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                { e.Appearance.ForeColor = Color.Red; }

                if (data.Estado_Auto == "AUTORIZADA")
                { e.Appearance.ForeColor = Color.Blue; }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            cargaGrid();
        }
    }
}
