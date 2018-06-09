
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Permisos_x_Empleado_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<ro_permiso_x_empleado_Info> DataSource = new BindingList<ro_permiso_x_empleado_Info>();
        ro_permiso_x_empleado_Info infoPermiso = new ro_permiso_x_empleado_Info();
        ro_permiso_x_empleado_Bus oRo_permiso_x_empleado_Bus = new ro_permiso_x_empleado_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //frmRo_Permisos_x_Empleado_Mant permisoMant = new frmRo_Permisos_x_Empleado_Mant()

        public frmRo_Permisos_x_Empleado_Cons()
        {
            try
            {
                InitializeComponent();
               
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
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
                Dispose();
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
                PU_LLAMAR_FORM(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                PU_LLAMAR_FORM(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewPermiso.ShowPrintPreview();
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
                PU_LLAMAR_FORM(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             try{

               var info = (ro_permiso_x_empleado_Info)this.gridViewPermiso.GetFocusedRow();

               if (info == null){
                   MessageBox.Show("Debe seleccionar un registro, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }else if (info.Estado == "I"){
                   MessageBox.Show("El Registro  No. : " + info.IdPermiso.ToString() + " ya ha sido anulado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }else{
                   frmRo_Novedad_x_Novedad_Mant frm = new frmRo_Novedad_x_Novedad_Mant();
                   PU_LLAMAR_FORM(Cl_Enumeradores.eTipo_action.Anular);
               }              
            }catch (Exception ex){
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
 
        }



     private void PU_LLAMAR_FORM(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                
                frmRo_Permisos_x_Empleado_Mant frm = new frmRo_Permisos_x_Empleado_Mant();
                frm.event_frmRo_Permisos_x_Empleado_Mant_FormClosing += new frmRo_Permisos_x_Empleado_Mant.delegate_frmRo_Permisos_x_Empleado_Mant_FormClosing(frm_event_frmRo_Permisos_x_Empleado_Mant_FormClosing);
     
                frm.setAccion(Accion);
      
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    infoPermiso = (ro_permiso_x_empleado_Info)this.gridViewPermiso.GetFocusedRow();
                    frm.setInfo(infoPermiso);               
                }
                
                frm.ShowDialog();

  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void frm_event_frmRo_Permisos_x_Empleado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //throw new NotImplementedException();
               PU_CARGAR();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void permisoMant_event_frmRo_Permisos_x_Empleado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  //throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void PU_CARGAR() 
        {
            try
            {
                List<ro_permiso_x_empleado_Info> listado = oRo_permiso_x_empleado_Bus.ConsultaGeneral(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario.fecha_desde,ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
                gridControlPermiso.DataSource = listado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


            private void gridViewPermiso_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewPermiso.GetRow(e.RowHandle) as ro_permiso_x_empleado_Info;
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

            private void frmRo_Permisos_x_Empleado_Cons_Load(object sender, EventArgs e)
            {
                try
                {
                     PU_CARGAR();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                    Log_Error_bus.Log_Error(ex.ToString());
                }
            }

            private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
            {
                try
                {
                    PU_CARGAR();
                }
                catch (Exception ex)
                {
                    
                   MessageBox.Show(ex.ToString());
                    Log_Error_bus.Log_Error(ex.ToString());
                }    
            }

    
    }
}
