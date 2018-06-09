using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_Conciliacion_Cons : Form
    {
       //Bus

        cxc_conciliacion_Bus Bus_conciliacion = new cxc_conciliacion_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //Listas
        List<cxc_conciliacion_Info> lista_Conciliacion = new List<cxc_conciliacion_Info>();


        cxc_conciliacion_Info Info = new cxc_conciliacion_Info();
      
        public frmCxc_Conciliacion_Cons()
        {
            try
            {
                InitializeComponent();
                frmMant.event_frmcxc_Conciliacion_cxc_FormClosing+=frmMant_event_frmcxc_Conciliacion_cxc_FormClosing;
                carga_Conciliacion();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string mensaje = "";
                Info = (cxc_conciliacion_Info)this.gridViewConciliacion.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.Estado == "I")
                    MessageBox.Show("La conciliación # : " + Info.IdConciliacion + " ya fue anulada", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    frmMant = new frmCxc_Conciliacion_cxc(Cl_Enumeradores.eTipo_action.Anular);
                    frmMant.event_frmcxc_Conciliacion_cxc_FormClosing += frmMant_event_frmcxc_Conciliacion_cxc_FormClosing;
                    Info.Detalle = cargarDetalleConciliacion(Info.IdConciliacion, ref mensaje);
                    frmMant.Text = frmMant.Text + " ***ANULAR REGISTRO***";
                    frmMant.SETINFO_ = Info;
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
                string mensaje = "";
                frmMant = new frmCxc_Conciliacion_cxc(Cl_Enumeradores.eTipo_action.consultar);
                frmMant.event_frmcxc_Conciliacion_cxc_FormClosing += frmMant_event_frmcxc_Conciliacion_cxc_FormClosing;
                frmMant.Text = frmMant.Text + " ***CONSULTAR REGISTRO***";
                Info.Detalle = cargarDetalleConciliacion(Info.IdConciliacion, ref mensaje);
                frmMant.SETINFO_ = Info;
                frmMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }


        private List<cxc_conciliacion_det_Info> cargarDetalleConciliacion(decimal IdConciliacion, ref string mensaje)
        {
            try
            {
                cxc_conciliacion_det_Bus conDetBus = new cxc_conciliacion_det_Bus();
                return conDetBus.Get_List_conciliacion_det(param.IdEmpresa, param.IdSucursal, IdConciliacion, ref mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<cxc_conciliacion_det_Info>();
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmMant = new frmCxc_Conciliacion_cxc(Cl_Enumeradores.eTipo_action.grabar);
                frmMant.event_frmcxc_Conciliacion_cxc_FormClosing += frmMant_event_frmcxc_Conciliacion_cxc_FormClosing;
                frmMant.Text = frmMant.Text + " ***NUEVO REGISTRO***";
                frmMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }


        void frmMant_event_frmcxc_Conciliacion_cxc_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                carga_Conciliacion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void carga_Conciliacion()
        {
            try
            {
                string mensaje = "";
                lista_Conciliacion = Bus_conciliacion.Get_List_conciliacion(param.IdEmpresa,ref mensaje);
                gridControlConciliacion.DataSource = lista_Conciliacion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                  
        }

        private void frmcxc_Conciliacion_Cons_Load(object sender, EventArgs e)
        {
            try
            {
               carga_Conciliacion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }



        frmCxc_Conciliacion_cxc frmMant = new frmCxc_Conciliacion_cxc();


        private void gridViewConciliacion_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewConciliacion.GetRow(e.RowHandle) as cxc_conciliacion_Info;
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

        private void gridViewConciliacion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = new cxc_conciliacion_Info();
                Info = this.gridViewConciliacion.GetFocusedRow() as cxc_conciliacion_Info;
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }
    }
}
