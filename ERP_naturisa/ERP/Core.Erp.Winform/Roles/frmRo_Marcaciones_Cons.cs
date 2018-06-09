using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//haac
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Winform.Roles_Fj;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Marcaciones_Cons : Form
    {
        #region
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_marcaciones_x_empleado_Bus Bus_Marcacion = new ro_marcaciones_x_empleado_Bus();
        ro_marcaciones_x_empleado_Info Info = new ro_marcaciones_x_empleado_Info();
        frmRo_Marcaciones_Mant frmMant = new frmRo_Marcaciones_Mant();
        #endregion

        public frmRo_Marcaciones_Cons()
        {
            try
            {
                InitializeComponent();
                cargagrid();
                frmMant.event_frmRo_Marcaciones_Mant_FormClosing += frmMant_event_frmRo_Marcaciones_Mant_FormClosing;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnCargaMarcaciónExcel_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnCargaMarcaciónExcel_ItemClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnCargaMarcaciónExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmRo_Importacion_Marcaciones_EXCEL oFrm = new frmRo_Importacion_Marcaciones_EXCEL();
                oFrm.MdiParent = this.MdiParent;
                oFrm.Show();

               
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
                frmMant = new frmRo_Marcaciones_Mant(Cl_Enumeradores.eTipo_action.grabar);
                // frmMant.event_frmRo_Turno_Mant_FormClosing += frmMant_event_frmRo_Turno_Mant_FormClosing;

                frmMant.event_frmRo_Marcaciones_Mant_FormClosing += frmMant_event_frmRo_Marcaciones_Mant_FormClosing;
                frmMant.Text = frmMant.Text + " ***NUEVO REGISTRO*** ";
                //frmMant.MdiParent = MdiParent;
                //frmMant.Show();
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
            try
            {
                var Info = (ro_marcaciones_x_empleado_Info)this.gridViewMarcacion.GetFocusedRow();
                if (Info == null)
                {
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    frmMant = new frmRo_Marcaciones_Mant(Cl_Enumeradores.eTipo_action.actualizar);
                    frmMant.event_frmRo_Marcaciones_Mant_FormClosing += frmMant_event_frmRo_Marcaciones_Mant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***ACTUALIZAR REGISTRO***";
                    frmMant._SetInfo = Info;
//                    frmMant.MdiParent = MdiParent;
//                    frmMant.Show();
                    frmMant.ShowDialog();
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
                var Info = (ro_marcaciones_x_empleado_Info)this.gridViewMarcacion.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmMant = new frmRo_Marcaciones_Mant(Cl_Enumeradores.eTipo_action.consultar);
                    //frmMant.event_frmRo_Turno_Mant_FormClosing += frmMant_event_frmRo_Turno_Mant_FormClosing;

                    frmMant.event_frmRo_Marcaciones_Mant_FormClosing += frmMant_event_frmRo_Marcaciones_Mant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***CONSULTAR REGISTRO***";
                    frmMant._SetInfo = Info;
                    //frmMant.MdiParent = MdiParent;
                    //frmMant.Show();
                    frmMant.ShowDialog();
                }
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
                cargagrid();
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
                var Info = (ro_marcaciones_x_empleado_Info)this.gridViewMarcacion.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmMant = new frmRo_Marcaciones_Mant(Cl_Enumeradores.eTipo_action.Anular);
                    frmMant.event_frmRo_Marcaciones_Mant_FormClosing += frmMant_event_frmRo_Marcaciones_Mant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***ANULAR REGISTRO***";
                    frmMant._SetInfo = Info;
                    //frmMant.MdiParent = MdiParent;
                    //frmMant.Show();
                    frmMant.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frmMant_event_frmRo_Marcaciones_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cargagrid()
        {
            try
            {
                var listado = Bus_Marcacion.Get_List_marcaciones_x_empleado(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
                gridControlMarcacion.DataSource = listado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e){}

        private void frmRo_Marcaciones_Cons_Load(object sender, EventArgs e)
        {
            try
            {
            
                cargagrid();

                this.gridViewMarcacion.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewMarcacion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = new ro_marcaciones_x_empleado_Info();
                Info = this.gridViewMarcacion.GetFocusedRow() as ro_marcaciones_x_empleado_Info;
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

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnDescargar_Marca_Base_exter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmRo_Marcaciones_Descarga_Base_externa Frm = new frmRo_Marcaciones_Descarga_Base_externa();
                Frm.MdiParent = MdiParent;
                Frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

    }
}
