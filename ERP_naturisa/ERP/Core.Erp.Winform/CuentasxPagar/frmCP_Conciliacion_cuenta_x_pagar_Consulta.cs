using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//DEREK MEJIA SORIA 05/03/2014-MOD 11/03/2014
namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Conciliacion_cuenta_x_pagar_Consulta : Form
    {
        frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento mant = new frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento();
        cp_conciliacion_Bus ConciliacionBus = new cp_conciliacion_Bus();
        //cp_orden_pago_cancelacion_Bus CP_OrdenPagoCancelacionBUS = new cp_orden_pago_cancelacion_Bus();
        BindingList<cp_conciliacion_Info> ConciliacionInfoBL = new BindingList<cp_conciliacion_Info>();
        List<cp_orden_pago_cancelacion_Info> CP_OrdenPagoCancelacionINFO = new List<cp_orden_pago_cancelacion_Info>();
        cp_conciliacion_Info info = new cp_conciliacion_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public frmCP_Conciliacion_cuenta_x_pagar_Consulta()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
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
                llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
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
                llama_frm(Cl_Enumeradores.eTipo_action.consultar);
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
                
                CP_OrdenPagoCancelacionINFO = new List<cp_orden_pago_cancelacion_Info>();
                
                if (info == null)
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (info.Estado == "I")
                    MessageBox.Show("La conciliación # : " + info.IdConciliacion + " ya fue anulada", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.Anular);
                }
                load();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                mant = new frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento();
                mant.event_frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento_FormClosing += new frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento.delegate_frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento_FormClosing(frm_event_frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento_FormClosing);
                mant.MdiParent = this.MdiParent;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    mant.SETINFO_ = info;
                }
                mant.set_Accion(Accion);
                mant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_event_frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento_FormClosing()
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void load() {
            try
            {
                string mensaje = "";
                ConciliacionInfoBL = new BindingList<cp_conciliacion_Info>(ConciliacionBus.Get_List_conciliacion (param.IdEmpresa,ref mensaje));
                gridControlConciliacionCP.DataSource = ConciliacionInfoBL;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

      

        private void gridViewConciliacionCP_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                info = new cp_conciliacion_Info();
                info = (cp_conciliacion_Info)gridViewConciliacionCP.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmCP_Conciliacion_cuenta_x_pagar_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gridViewConciliacionCP_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                 var data = gridViewConciliacionCP.GetRow(e.RowHandle) as cp_conciliacion_Info;
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
    }
}
