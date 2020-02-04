using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_factura_TerminoPago_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_TerminoPago_Bus terminoBus = new fa_TerminoPago_Bus();

        fa_TerminoPago_Info _Info = new fa_TerminoPago_Info();
        
        public frmFa_factura_TerminoPago_Consulta()
        {
            try
            {
                 InitializeComponent();
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
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
                ShowFormulario(Cl_Enumeradores.eTipo_action.consultar);
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
                ShowFormulario(Cl_Enumeradores.eTipo_action.actualizar);
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
                ShowFormulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ShowFormulario(Cl_Enumeradores.eTipo_action accion)
        {
            try
            {
                frmFa_factura_TerminoPago_Mant frm = new frmFa_factura_TerminoPago_Mant();
                frm.Event_frmFa_factura_TerminoPago_Mantenimiento_FormClosing += new frmFa_factura_TerminoPago_Mant.delegate_frmFa_factura_TerminoPago_Mantenimiento_FormClosing(event_frmFa_factura_TerminoPago_Mantenimiento_FormClosing);
                frm._Accion = accion;
                if (accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    _Info = gridViewGridTerminoPago.GetFocusedRow() as fa_TerminoPago_Info;
                    frm.setInfo(_Info);
                }
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void frmFa_factura_TerminoPago_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                gridControlTerminoPago.DataSource = terminoBus.Get_List_TerminoPago(Cl_Enumeradores.eTipoCreditoCliente.AMB.ToString());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void event_frmFa_factura_TerminoPago_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gridControlTerminoPago.DataSource = terminoBus.Get_List_TerminoPago(Cl_Enumeradores.eTipoCreditoCliente.AMB.ToString());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
