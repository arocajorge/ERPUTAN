/*CLASE: frmRo_Departamento_Consulta
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 22-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using DevExpress.XtraTreeList.Nodes;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Departamento_Consulta : Form
    {

        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Departamento_Bus BusDep = new ro_Departamento_Bus();
        List<ro_Departamento_Info> LstInfoDep = new List<ro_Departamento_Info>();
        private Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param =  cl_parametrosGenerales_Bus.Instance;
        frmRo_Departamento_Mant frm;
        ro_Departamento_Info oRo_Departamento_Info = new ro_Departamento_Info();
        ro_Departamento_Info _iDepartamentoPadre = new ro_Departamento_Info();
        UCRo_Departamento UCRDep = new UCRo_Departamento();
        #endregion

        public frmRo_Departamento_Consulta()
        {
            try
            {
                InitializeComponent();

                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;

                pu_CargarDatos();

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
              //  llama_frm(Cl_Enumeradores.eTipo_action.grabar);


                frm = new frmRo_Departamento_Mant();
                frm.Event_frmRo_Departamento_Mant_FormClosing += frm_Event_frmRo_Departamento_Mant_FormClosing;
               
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
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
                if (oRo_Departamento_Info != null)
                {
                  //  llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                    frm = new frmRo_Departamento_Mant();
                    frm.Event_frmRo_Departamento_Mant_FormClosing += frm_Event_frmRo_Departamento_Mant_FormClosing;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);

                    frm.set_Info(oRo_Departamento_Info);
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oRo_Departamento_Info != null)
                {
                  //  llama_frm(Cl_Enumeradores.eTipo_action.consultar);

                    frm = new frmRo_Departamento_Mant();
                    frm.Event_frmRo_Departamento_Mant_FormClosing += frm_Event_frmRo_Departamento_Mant_FormClosing;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);

                    frm.set_Info(oRo_Departamento_Info);
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
                frm = new frmRo_Departamento_Mant();
                frm.Event_frmRo_Departamento_Mant_FormClosing += frm_Event_frmRo_Departamento_Mant_FormClosing;
                frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                frm.set_Info(oRo_Departamento_Info);
                frm.ShowDialog();
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

  

    
   

        private void frmRo_Departamento_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                pu_CargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void pu_CargarDatos()
        {
            try
            {
                LstInfoDep = BusDep.Get_List_Departamento(param.IdEmpresa);
                gridDepartamento.DataSource = LstInfoDep;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        void frm_Event_frmRo_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            pu_CargarDatos();
        }

        private void viewDepartamento_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = viewDepartamento.GetRow(e.RowHandle) as ro_Departamento_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void viewDepartamento_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                oRo_Departamento_Info = (ro_Departamento_Info)viewDepartamento.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }






       
    }
}
