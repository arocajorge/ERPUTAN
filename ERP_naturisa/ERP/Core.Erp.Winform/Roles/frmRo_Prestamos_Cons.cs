using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//haac 30/04/2014
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Prestamos_Cons : Form
    {
        #region Declaración de Variables
        ro_prestamo_Bus cab = new ro_prestamo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_prestamo_Info Info = new ro_prestamo_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmRo_Prestamos frmMant = new frmRo_Prestamos();
        #endregion

        public frmRo_Prestamos_Cons()
        {
            try
            {
                 InitializeComponent();
                 frmMant.event_frmRo_Prestamos_FormClosing +=frmMant_event_frmRo_Prestamos_FormClosing;
                 CargarGrid();
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmMant = new frmRo_Prestamos(Cl_Enumeradores.eTipo_action.grabar);
                frmMant.event_frmRo_Prestamos_FormClosing += frmMant_event_frmRo_Prestamos_FormClosing;
                frmMant.Text = frmMant.Text + " ***NUEVO REGISTRO***";
                frmMant.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }  
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // var Info = (vwRo_Prestamo_Info)this.gridViewCons.GetFocusedRow();
            try
            {
                Info = (ro_prestamo_Info)this.gridViewCons.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               else
                {
                    if (Info.Estado == "I")
                    {
                        MessageBox.Show("No se Puede modificar El Registro Esta Anulado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {

                        frmMant = new frmRo_Prestamos(Cl_Enumeradores.eTipo_action.actualizar);
                        frmMant.event_frmRo_Prestamos_FormClosing += frmMant_event_frmRo_Prestamos_FormClosing;
                        frmMant.Text = frmMant.Text + " ***ACTUALIZAR REGISTRO***";
                        frmMant.SETINFO_ = Info;
                        frmMant.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmMant = new frmRo_Prestamos(Cl_Enumeradores.eTipo_action.consultar);
                frmMant.event_frmRo_Prestamos_FormClosing += frmMant_event_frmRo_Prestamos_FormClosing;
                frmMant.Text = frmMant.Text + " ***CONSULTAR REGISTRO***";
                frmMant.SETINFO_ = Info;
                frmMant.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }  
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (ro_prestamo_Info)this.gridViewCons.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.Estado == "I")
                    MessageBox.Show("El préstamo # : " + Info.IdPrestamo + " ya fue anulado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    frmMant = new frmRo_Prestamos(Cl_Enumeradores.eTipo_action.Anular);
                    frmMant.event_frmRo_Prestamos_FormClosing += frmMant_event_frmRo_Prestamos_FormClosing;
                    frmMant.Text = frmMant.Text + " ***ANULAR REGISTRO***";
                    frmMant.SETINFO_ = Info;
                    frmMant.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }  
        }

        void frmMant_event_frmRo_Prestamos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void CargarGrid()
        {
            try
            {
                this.gridControlCons.DataSource = cab.ConsultarCabeceraPrestamo(param.IdEmpresa,    
                 ucGe_Menu_Mantenimiento_x_usuario.fecha_desde
                 , ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }          
        }

        private void frmRo_Prestamos_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
          
        }
      
        void frm_event_frmRo_Prestamos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridControlCons_Click(object sender, EventArgs e){}
   
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}

        //capturo el registro de la grilla
        private void gridViewCons_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = new ro_prestamo_Info();
                Info = this.gridViewCons.GetFocusedRow() as ro_prestamo_Info;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }                     
        }
     

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void gridViewCons_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCons.GetRow(e.RowHandle) as ro_prestamo_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewCons.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

      
       
    }
}
