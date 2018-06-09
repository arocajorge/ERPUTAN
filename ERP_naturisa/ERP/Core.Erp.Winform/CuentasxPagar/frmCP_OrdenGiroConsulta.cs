using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Cus.Erp.Reports.Naturisa.CuentasxPagar;
using DevExpress.XtraReports.UI;
using Core.Erp.Reportes.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_OrdenGiroConsulta : Form
    {

        string msg2 = "";
        string motiAnulacion = "";

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_orden_giro_Bus OrdenGiro_B = new cp_orden_giro_Bus();
        cp_orden_giro_Info Info_OrdenGiro = new cp_orden_giro_Info();
        frmCP_OrdenGiroMantenimiento frm = new frmCP_OrdenGiroMantenimiento();
        ba_TipoFlujo_Bus bus_tipo_flujo = new ba_TipoFlujo_Bus();
        List<ba_TipoFlujo_Info> lst_tipo_flujo = new List<ba_TipoFlujo_Info>();
        

        public frmCP_OrdenGiroConsulta()
        {
            try
            {
                InitializeComponent();
        
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
                this.Close();
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
                llamaFRM(Cl_Enumeradores.eTipo_action.grabar, Info_OrdenGiro);
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
                Info_OrdenGiro = (cp_orden_giro_Info)UltraGrid_OrdenGiro.GetFocusedRow();

                if (Info_OrdenGiro == null)
                {
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (Info_OrdenGiro.Estado == "I")
                    {
                        MessageBox.Show("La Factura #: " + Info_OrdenGiro.co_serie + "-" + Info_OrdenGiro.co_factura + "/" + Info_OrdenGiro.IdCbteCble_Ogiro +  " está anulada, solo puede consultar.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        llamaFRM(Cl_Enumeradores.eTipo_action.consultar, Info_OrdenGiro);
                    }
                    else
                    {
                        cp_orden_pago_det_Bus bus_opDet = new cp_orden_pago_det_Bus();
                        List<cp_orden_pago_det_Info> lista_opDet = new List<cp_orden_pago_det_Info>();
                        string mensaje = "";
                        lista_opDet = bus_opDet.Get_List_OrdenPagoDetalle(Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdCbteCble_Ogiro, Info_OrdenGiro.IdTipoCbte_Ogiro, ref mensaje);

                        if (lista_opDet.Count !=0)
                        {
                            MessageBox.Show("La Factura #: " + Info_OrdenGiro.co_serie + "-" + Info_OrdenGiro.co_factura + "/" + Info_OrdenGiro.IdCbteCble_Ogiro + " tiene asociadas Ordenes de Pago. No se puede modificar completamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            llamaFRM(Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado, Info_OrdenGiro);
                            return;
                          
                        }
                                                                   
                        cp_retencion_Bus bus_Retencion = new cp_retencion_Bus();
                        cp_retencion_Info info = new cp_retencion_Info();

                        info = bus_Retencion.Get_Info_retencion(Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdCbteCble_Ogiro, Info_OrdenGiro.IdTipoCbte_Ogiro);

                        if (info !=null)
                        {
                                llamaFRM(Cl_Enumeradores.eTipo_action.actualizar, Info_OrdenGiro);
                        }                                       
                    }                                                               
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
                Info_OrdenGiro = (cp_orden_giro_Info)UltraGrid_OrdenGiro.GetFocusedRow();

                if (Info_OrdenGiro == null)
                {
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    llamaFRM(Cl_Enumeradores.eTipo_action.consultar, Info_OrdenGiro);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                load_datos();
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
                Info_OrdenGiro = (cp_orden_giro_Info)UltraGrid_OrdenGiro.GetFocusedRow();
                if (Info_OrdenGiro == null)
                {
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                    if (Info_OrdenGiro.Estado_Cancelacion != "PAGADA")
                    {
                        if (Info_OrdenGiro.Estado != "I")
                        {
                            llamaFRM(Cl_Enumeradores.eTipo_action.Anular, Info_OrdenGiro);
                        }
                        else
                            MessageBox.Show("Esta Factura ya está Anulada...", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                        MessageBox.Show("Esta Factura ya está Cancelada. No puede ser anulada", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_datos()
        {
            try
            {
                gridControlOG.DataSource = OrdenGiro_B.Get_List_orden_giro(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde
                    , ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta);
                gridControlOG.RefreshDataSource();
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_OrdenGiroConsulta_Load(object sender, EventArgs e)
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
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UltraGrid_OrdenGiro_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = UltraGrid_OrdenGiro.GetRow(e.RowHandle) as cp_orden_giro_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                {
                    e.Appearance.ForeColor = Color.Red;
                    return;
                }

                if (data.saldo <=0)
                {
                    e.Appearance.ForeColor = Color.Blue;
                    return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                    load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                    load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UltraGrid_OrdenGiro_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                
                Info_OrdenGiro = (cp_orden_giro_Info)UltraGrid_OrdenGiro.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llamaFRM(Cl_Enumeradores.eTipo_action Accion, cp_orden_giro_Info info)
        {
            try
            {
                frm = new frmCP_OrdenGiroMantenimiento();
                //frm.event_frmCP_MantOrdenGiro_FormClosing += new frmCP_OrdenGiroMantenimiento.delegate_frmCP_MantOrdenGiro_FormClosing(frm_event_frmCP_MantOrdenGiro_FormClosing);
                frm.event_frmCP_MantOrdenGiro_FormClosing += frm_event_frmCP_MantOrdenGiro_FormClosing;
               
                frm.set_accion(Accion);
                
                frm.MdiParent = this.MdiParent;
                if(!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_ordenGiro(info);
                }

                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCP_MantOrdenGiro_FormClosing(object sender, FormClosingEventArgs e, cp_orden_giro_Info _Info_Orgen_Giro)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlOG.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UltraGrid_OrdenGiro_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            try
            {

                if (e.Column.Name == colTotal_Retencion.Name)
                {

                    Info_OrdenGiro = (cp_orden_giro_Info)UltraGrid_OrdenGiro.GetFocusedRow();
                    cp_retencion_Info InfoRetencion = new cp_retencion_Info();
                    cp_retencion_Bus BusRetencion = new cp_retencion_Bus();
                    InfoRetencion = BusRetencion.Get_Info_retencion(Convert.ToInt32(Info_OrdenGiro.IdEmpresa_ret), Convert.ToDecimal(Info_OrdenGiro.IdRetencion));
                    frmCP_RetencionMant frm = new frmCP_RetencionMant();
                    frm.Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Set_Info_Retencion(InfoRetencion);
                    frm.ShowDialog();
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void UltraGrid_OrdenGiro_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                cp_orden_giro_Info row = (cp_orden_giro_Info)UltraGrid_OrdenGiro.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (e.Column == col_tipo_flujo)
                {
                    if (MessageBox.Show("¿Está seguro que desea modificar el tipo de flujo para la F# "+row.IdCbteCble_Ogiro.ToString()+"?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        if (e.Value == null)
                            OrdenGiro_B.Modificar_tipo_flujo(row.IdEmpresa, row.IdTipoCbte_Ogiro, row.IdCbteCble_Ogiro, null);
                        else
                            OrdenGiro_B.Modificar_tipo_flujo(row.IdEmpresa, row.IdTipoCbte_Ogiro, row.IdCbteCble_Ogiro, Convert.ToDecimal(e.Value));
                        
                    }
                    load_datos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UltraGrid_OrdenGiro_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_tipo_flujo)
                {
                    UltraGrid_OrdenGiro.SetRowCellValue(e.RowHandle, col_tipo_flujo, e.Value);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_tiene_ingresos_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                cp_orden_giro_Info row = (cp_orden_giro_Info)UltraGrid_OrdenGiro.GetFocusedRow();
                if (row == null)
                    return;
                splashScreenManager1.ShowWaitForm();

                if (MessageBox.Show("Desea Imprimir la Factura del proveedor", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XCXP_NATU_Rpt009_Rpt rpt1 = new XCXP_NATU_Rpt009_Rpt();
                    rpt1.PIdEmpresa.Value = param.IdEmpresa;
                    rpt1.PIdTipoCbte_OG.Value = row.IdTipoCbte_Ogiro;
                    rpt1.PIdCbteCble_OG.Value = row.IdCbteCble_Ogiro;
                    ReportPrintTool pt = new ReportPrintTool(rpt1);
                    pt.AutoShowParametersPanel = false;
                    rpt1.RequestParameters = false;
                    rpt1.ShowPreviewDialog();
                }                

                if (MessageBox.Show("Desea Imprimir el Comprobante de Diario Factura Proveedor", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XCXP_NATU_Rpt011_rpt reporte_natu = new XCXP_NATU_Rpt011_rpt();
                    reporte_natu.set_parametros(param.IdEmpresa, row.IdTipoCbte_Ogiro, row.IdCbteCble_Ogiro);
                    reporte_natu.RequestParameters = true;
                    reporte_natu.ShowPreviewDialog();
                }

                if (MessageBox.Show("Desea Imprimir la Retención Proveedor", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XCXP_Rpt004_Rpt reporte = new XCXP_Rpt004_Rpt();
                    reporte.set_parametros(param.IdEmpresa, row.IdTipoCbte_Ogiro, row.IdCbteCble_Ogiro);
                    reporte.RequestParameters = true;
                    reporte.ShowPreviewDialog();
                }

                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                if(splashScreenManager1.IsSplashFormVisible)
                    splashScreenManager1.CloseWaitForm();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

