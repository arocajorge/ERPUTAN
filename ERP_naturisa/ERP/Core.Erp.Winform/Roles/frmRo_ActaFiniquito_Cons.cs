

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

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_ActaFiniquito_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        //INFO
        ro_Acta_Finiquito_Info oRo_Acta_Finiquito_Info = new ro_Acta_Finiquito_Info(); 
        
        //BUS
        ro_Acta_Finiquito_Bus oRo_Acta_Finiquito_Bus = new ro_Acta_Finiquito_Bus();


        public frmRo_ActaFiniquito_Cons()
        {
            InitializeComponent();

            ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
        
            ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oRo_Acta_Finiquito_Info != null)
                {
                    pu_setForm(Cl_Enumeradores.eTipo_action.consultar);
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
                if (oRo_Acta_Finiquito_Info != null)
                {

                    if (oRo_Acta_Finiquito_Info.Estado == "A")
                    {
                        pu_setForm(Cl_Enumeradores.eTipo_action.Anular);
                    }
                    else
                    {
                        MessageBox.Show("El Registro # : " + oRo_Acta_Finiquito_Info.IdActaFiniquito.ToString() + " ya fue anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
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


        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (oRo_Acta_Finiquito_Info != null)
            {
                pu_setForm(Cl_Enumeradores.eTipo_action.actualizar);
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


        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pu_setForm(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
         }


        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void pu_setForm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmRo_ActaFiniquito frm = new frmRo_ActaFiniquito();
                frm.Event_frmRo_ActaFiniquito_FormClosing += frm_Event_frmRo_ActaFiniquito_FormClosing;
                
                if(Accion!= Cl_Enumeradores.eTipo_action.grabar){
                   frm.setInfo(oRo_Acta_Finiquito_Info);
                }
                frm.setAccion(Accion);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        void frm_Event_frmRo_ActaFiniquito_FormClosing(object sender, FormClosingEventArgs e)
        {
            pu_CargarDatos();
        }


        private void pu_CargarDatos() {
            try {

                List<ro_Acta_Finiquito_Info> oListRo_Acta_Finiquito_Info = new List<ro_Acta_Finiquito_Info>();
                oListRo_Acta_Finiquito_Info = oRo_Acta_Finiquito_Bus.GetListConsultaGeneral(param.IdEmpresa);
                gridFiniquito.DataSource = oListRo_Acta_Finiquito_Info;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void frmRo_ActaFiniquito_Cons_Load(object sender, EventArgs e)
        {
            pu_CargarDatos();
        }

        private void viewFiniquito_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                oRo_Acta_Finiquito_Info = (ro_Acta_Finiquito_Info)viewFiniquito.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void viewFiniquito_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = viewFiniquito.GetRow(e.RowHandle) as ro_Acta_Finiquito_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



    }
}
