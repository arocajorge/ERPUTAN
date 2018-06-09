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


//using Infragistics.Win.UltraWinGrid;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Empleado_Cons : Form
    {
        #region Declaracion de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public ro_Empleado_Info info = new ro_Empleado_Info();
        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        ro_Empleado_Bus bus_empleado = new ro_Empleado_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;
        frmRo_Empleado_Mant frm;
        frmRo_Empleado_ImportacionWizard frmWizard;
        #endregion
              
        public frmRo_Empleado_Cons()
        {
     
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImpExcel_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImpExcel_ItemClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }       
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (ro_Empleado_Info)this.gridViewConsEmp.GetFocusedRow();

                if (info == null)
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmRo_Empleado_Mant();
                frm.event_frmRo_MantEmpleado_FormClosing += new frmRo_Empleado_Mant.delegate_frmRo_MantEmpleado_FormClosing(frm_event_frmRo_MantEmpleado_FormClosing);

               
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();



            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

 
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info != null)
                {
                    frmRo_Empleado_Mant frm = new frmRo_Empleado_Mant();
                    frm.set_Empleado(info);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el empleado ID # : " + info.IdEmpleado + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    
                         if (info.em_estado == "A")
                         {
                            string msg = "";
                            FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                            oFrm.ShowDialog();
                            string motivoAnulacion = oFrm.motivoAnulacion;
                            info.MotivoAnulacion = motivoAnulacion;
                            if (bus_empleado.AnularDB(info, ref msg)) {
                                MessageBox.Show(msg, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            carga_empleado();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo anular el empleado ID # : " + info.IdEmpleado + " debido a que ya se encuentra anulado", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        

                    }
                }

                else
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImpExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                frmWizard = new frmRo_Empleado_ImportacionWizard();
                frmWizard.event_frmRo_Empleado_ImportacionWizard_FormClosing += new frmRo_Empleado_ImportacionWizard.delegate_frmRo_Empleado_ImportacionWizard_FormClosing(frm_event_frmRo_Empleado_ImportacionWizard_FormClosing);
                frmWizard.Show();

                //ACTUALIZAR
                carga_empleado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        //carga ultragrid
        public void carga_empleado()
        {
            try
            {
                ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();
                List<ro_Empleado_Info> listEmpleado = new List<ro_Empleado_Info>();
                listEmpleado=bus_empleado.Get_List_Empleado_(param.IdEmpresa);
                this.gridControlconsultaEmp.DataSource = listEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmRo_Empleado_Mant();
                frm.event_frmRo_MantEmpleado_FormClosing += frm_event_frmRo_MantEmpleado_FormClosing;
                  frm.set_Accion(Accion);
                    frm.set_Empleado(info);

                    frm.ShowDialog();
            
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void frm_event_frmRo_MantEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                carga_empleado();
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

       
        void frm_event_frmRo_Empleado_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                this.gridControlconsultaEmp.DataSource = null;
                carga_empleado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void frmRo_ConsultaEmpleado_Load(object sender, EventArgs e)
        {
           try
            {
                   carga_empleado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

              
       
        private void gridViewConsEmp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                info = new ro_Empleado_Info();
                info = (ro_Empleado_Info)gridViewConsEmp.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());

            }
        }

        private void gridViewConsEmp_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewConsEmp.GetRow(e.RowHandle) as ro_Empleado_Info;
                if (data == null)
                    return;

                  if (data.em_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
   

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewConsEmp.ShowRibbonPrintPreview();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btn_imprimir_lote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlconsultaEmp.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }


    }
}
