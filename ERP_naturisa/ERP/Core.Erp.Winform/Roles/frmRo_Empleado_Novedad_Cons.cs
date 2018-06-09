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
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Empleado_Novedad_Cons : Form
    {

        #region Declaracion Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ro_Empleado_Novedad_Bus OEmpDCabecera = new ro_Empleado_Novedad_Bus();
        ro_Empleado_Novedad_Det_Bus Bus_NovedadDet = new ro_Empleado_Novedad_Det_Bus();
        ro_Empleado_Novedad_Info Info_CabNovedad = new ro_Empleado_Novedad_Info();
        ro_Empleado_Novedad_Det_Info Info_DetNovedad = new ro_Empleado_Novedad_Det_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_contrato_Info> listCon = new List<ro_contrato_Info>();
        frmRo_Empleado_Novedad_Mant frm;
        #endregion


        public frmRo_Empleado_Novedad_Cons()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
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
                frm = new frmRo_Empleado_Novedad_Mant();
                frm.Event_frmRo_Empleado_Novedad_Mant_FormClosing += new frmRo_Empleado_Novedad_Mant.delegate_frmRo_Empleado_Novedad_Mant_FormClosing(frm_Event_frmRo_Empleado_Novedad_Mant_FormClosing);
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info_CabNovedad.IdNovedad == 0)
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    frm = new frmRo_Empleado_Novedad_Mant();
                    frm.Event_frmRo_Empleado_Novedad_Mant_FormClosing += new frmRo_Empleado_Novedad_Mant.delegate_frmRo_Empleado_Novedad_Mant_FormClosing(frm_Event_frmRo_Empleado_Novedad_Mant_FormClosing);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.set_Info(Info_CabNovedad);
                    frm.ShowDialog();
                }
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
                if (Info_CabNovedad.IdNovedad == null)
                {
                    MessageBox.Show("Selecciones una fila.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Info_CabNovedad.Estado == "I")
                    {
                        MessageBox.Show("El Registro esta anulado no se puede modificar.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {

                        frm = new frmRo_Empleado_Novedad_Mant();
                        frm.Event_frmRo_Empleado_Novedad_Mant_FormClosing += new frmRo_Empleado_Novedad_Mant.delegate_frmRo_Empleado_Novedad_Mant_FormClosing(frm_Event_frmRo_Empleado_Novedad_Mant_FormClosing);
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.set_Info(Info_CabNovedad);
                        frm.ShowDialog();
                    }
                }
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
                gridView.ShowPrintPreview();
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
                if (Info_CabNovedad.IdNovedad == null)
                {
                    MessageBox.Show("Selecciones una fila.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Info_CabNovedad.Estado == "I")
                    {
                        MessageBox.Show("la Novedad ya Fue anulada.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        frm = new frmRo_Empleado_Novedad_Mant();
                        frm.Event_frmRo_Empleado_Novedad_Mant_FormClosing += new frmRo_Empleado_Novedad_Mant.delegate_frmRo_Empleado_Novedad_Mant_FormClosing(frm_Event_frmRo_Empleado_Novedad_Mant_FormClosing);
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                        frm.set_Info(Info_CabNovedad);
                        frm.ShowDialog();
                    }



                    
                }
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
                this.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void mnu_salir_Click(object sender, EventArgs e)
        {
            try
            {
                 this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void pu_CargarNovedadesPeriodoActual() { 
        
        }


        private void frmRo_Empleado_Novedad_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                 load_datos();
                 pu_CargarNovedadesPeriodoActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void load_datos()
        {
            try
            {
                grdLista.DataSource = OEmpDCabecera.Get_List_Empleado_Novedad_Cab(param.IdEmpresa,Convert.ToDateTime( ucGe_Menu_Mantenimiento_x_usuario.fecha_desde),Convert.ToDateTime( ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


     

        void frm_Event_frmRo_Empleado_Novedad_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void ANULADO() 
        
        {

            try
            {
                // Motivo por Anulación
                string motiAnulacion = "";
                FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                fr.ShowDialog();
                motiAnulacion = fr.motivoAnulacion;
                Info_CabNovedad.MotiAnula = motiAnulacion;
                Info_CabNovedad.InfoNovedadDet.Observacion = motiAnulacion;
                Info_CabNovedad.InfoNovedadDet.IdEmpleado = Info_CabNovedad.IdEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
          
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info_CabNovedad = new ro_Empleado_Novedad_Info();
                Info_CabNovedad = gridView.GetFocusedRow() as ro_Empleado_Novedad_Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView.GetRow(e.RowHandle) as ro_Empleado_Novedad_Info;
                if (data == null)
                    return;
                if (data.InfoNovedadDet.Estado == "I" )
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void grdLista_Click(object sender, EventArgs e){}

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    
    }
}
