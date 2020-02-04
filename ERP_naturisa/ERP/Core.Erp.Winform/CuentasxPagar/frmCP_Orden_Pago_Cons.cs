using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Bancos;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Orden_Pago_Cons : Form
    {
        string mensajeFrm = "";
        string mensaje = "";

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_orden_pago_Info Info = new cp_orden_pago_Info();
        cp_orden_pago_Bus Bus_OrdenPago = new cp_orden_pago_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_orden_pago_cancelaciones_Bus bus_can = new cp_orden_pago_cancelaciones_Bus();
        List<cp_orden_pago_cancelaciones_Info> lista_can = new List<cp_orden_pago_cancelaciones_Info>();
        ba_TipoFlujo_Bus bus_tipo_flujo = new ba_TipoFlujo_Bus();
        List<ba_TipoFlujo_Info> lst_tipo_flujo = new List<ba_TipoFlujo_Info>();

        frmCP_Orden_Pago_Mant frm = new frmCP_Orden_Pago_Mant();
        
        public frmCP_Orden_Pago_Cons()
        {
            try
            {
                InitializeComponent();
                frm.event_frmCP_Orden_Pago_Mant_FormClosing+=frmMant_event_frmCP_Orden_Pago_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlConsulta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info == null)
                {
                    MessageBox.Show("Seleccione un Registro ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                    return;
                }

                if (Info.Estado.ToString() == "I")
                {
                    MessageBox.Show("No se pueden modificar órdenes de pagos inactivos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info == null)
                {
                    MessageBox.Show("Seleccione un Registro ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info == null)
                {
                    MessageBox.Show("Seleccione un Registro ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.Anular);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        
        void frmMant_event_frmCP_Orden_Pago_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void CargarGrid()
        {
            try
            {
                string mensaje = "";
                List<cp_orden_pago_Info> lst_op = new List<cp_orden_pago_Info>();
                lst_op =Bus_OrdenPago.Get_List_orden_pago (param.IdEmpresa,
                Convert.ToDateTime(ucGe_Menu.fecha_desde), Convert.ToDateTime(ucGe_Menu.fecha_hasta),ref mensaje);
                this.gridControlConsulta.DataSource = lst_op;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConsulta_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = new cp_orden_pago_Info();
                Info = this.gridViewConsulta.GetRow(e.FocusedRowHandle) as cp_orden_pago_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmCP_Orden_Pago_Cons_Load(object sender, EventArgs e)
        {
            try
            {

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        col_tipo_flujo.Visible = true;
                        Cargar_combos();
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        col_tipo_flujo.Visible = true;
                        Cargar_combos();
                        break;
                    default:
                        col_tipo_flujo.Visible = false;
                        break;
                }       
                CargarGrid();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewConsulta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewConsulta.GetRow(e.RowHandle) as cp_orden_pago_Info;
                if (data == null)
                    return;
                if (data.Estado.ToString() == "I")
                    e.Appearance.ForeColor = Color.Red;
                else
                {
                    if (data.EstadoCancelacion.ToString() == "CANCELADA")
                        e.Appearance.ForeColor = Color.Blue;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Info = new cp_orden_pago_Info();
                Info = this.gridViewConsulta.GetRow(gridViewConsulta.FocusedRowHandle) as cp_orden_pago_Info;

                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        mensajeFrm = "REGISTRO NUEVO";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        mensajeFrm = "MODIFICAR REGISTRO";                                                              
                        // consulta cancelaciones
                        lista_can = bus_can.ConsultaGeneralOPCxOP(Info.IdEmpresa, Info.IdOrdenPago, ref mensaje);
                        if (lista_can.Count > 0)
                        {
                            MessageBox.Show("Existen Cancelaciones de Ordenes de Pagos. No se puede Modificar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        mensajeFrm = "ANULAR REGISTRO";                                                
                        // consulta cancelaciones
                        if (Info.IdTipo_op == "ANTI_PROVEE")
                        {
                            vwct_cbtecble_con_saldo_cxp_Bus bus_cbte = new vwct_cbtecble_con_saldo_cxp_Bus();
                            vwct_cbtecble_con_saldo_cxp_Info info = new vwct_cbtecble_con_saldo_cxp_Info();
                            info = bus_cbte.Get_Info_cbtecble_con_saldo_cxp(Info.IdEmpresa, Info.IdOrdenPago, "ANTPROV", ref mensaje);

                            if (info.IdOrdenPagoOP != null)
                            {
                                lista_can = bus_can.ConsultaGeneral_Cancelacion_x_Pagos_Anticipos(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdTipocbte), Convert.ToDecimal(info.IdCbteCble), ref mensaje);
                            }
                        }
                        else
                        {
                            lista_can = bus_can.ConsultaGeneralOPCxOP(Info.IdEmpresa, Info.IdOrdenPago, ref mensaje);
                        }

                        if (lista_can.Count > 0)
                        {
                            MessageBox.Show("Existen Cancelaciones de Ordenes de Pagos. No se puede Anular", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            frm = new frmCP_Orden_Pago_Mant();
                            frm.Text = frm.Text + "***" + mensajeFrm + "***";
                            frm.Set_Accion(iAccion);
                            frm.Set_Info(Info);
                            frm.Show();
                            frm.MdiParent = this.MdiParent;
                            frm.event_frmCP_Orden_Pago_Mant_FormClosing += frm_event_frmCP_Orden_Pago_Mant_FormClosing;
                            return;
                        }
                    break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        mensajeFrm = "CONSULTAR REGISTRO";
                        break;
                    default:
                        break;
                }

                if (Info != null && iAccion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm = new frmCP_Orden_Pago_Mant();
                    frm.Text = frm.Text + "***" + mensajeFrm + "***";
                    frm.Set_Accion(iAccion);
                    frm.Set_Info(Info);
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_frmCP_Orden_Pago_Mant_FormClosing += frm_event_frmCP_Orden_Pago_Mant_FormClosing;
                }
                else
                    if (iAccion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        frm = new frmCP_Orden_Pago_Mant();
                        frm.Text = frm.Text + "***" + mensajeFrm + "***";
                        frm.Set_Accion(iAccion);
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_frmCP_Orden_Pago_Mant_FormClosing += frm_event_frmCP_Orden_Pago_Mant_FormClosing;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un Registro ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCP_Orden_Pago_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cargar_combos()
        {
            try
            {
                lst_tipo_flujo = bus_tipo_flujo.Get_List_TipoFlujo(param.IdEmpresa);
                cmb_tipo_flujo.DataSource = lst_tipo_flujo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConsulta_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                cp_orden_pago_Info row = (cp_orden_pago_Info)gridViewConsulta.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_tipo_flujo)
                {
                    if (MessageBox.Show("¿Está seguro que desea modificar el tipo de flujo para la OP# " + row.IdOrdenPago.ToString() + "?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (e.Value == null)
                            Bus_OrdenPago.Modificar_tipo_flujo(row.IdEmpresa, row.IdOrdenPago, null);
                        else
                            Bus_OrdenPago.Modificar_tipo_flujo(row.IdEmpresa, row.IdOrdenPago, Convert.ToDecimal(e.Value));
                    }
                    CargarGrid();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConsulta_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_tipo_flujo)
                {
                    gridViewConsulta.SetRowCellValue(e.RowHandle, col_tipo_flujo, e.Value);    
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
