using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Winform.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;
using Cus.Erp.Reports.Naturisa.Bancos;
using DevExpress.XtraReports.UI;
using Core.Erp.Reportes.Bancos;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Debito_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
        ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        List<ba_Cbte_Ban_Info> LstCbteBan_I = new List<ba_Cbte_Ban_Info>();
        List<ba_TipoFlujo_Info> lst_tipo_flujo = new List<ba_TipoFlujo_Info>();
        ba_TipoFlujo_Bus bus_tipo_flujo = new ba_TipoFlujo_Bus();

        string motiAnulacion, msg2;
        int IdTipoCbteRev = 0;
        decimal IdCbteCbleRev;

        int IdTipoCbteRev_ND = 39;

       
        string MensajeError = "";


        FrmBA_Debito_Mant frmND;
        
        
        public FrmBA_Debito_Cons()
        {
            InitializeComponent();

            ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                CbteBan_I = (ba_Cbte_Ban_Info)UltraGridCbteBanDep.GetFocusedRow();

                if (CbteBan_I== null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (CbteBan_I.Estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_modif_regis_Inac), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    PrepararFrm(Cl_Enumeradores.eTipo_action.actualizar, CbteBan_I);
                }



            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlCbteBanDep.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                CbteBan_I = (ba_Cbte_Ban_Info)UltraGridCbteBanDep.GetFocusedRow();

                if (CbteBan_I == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (CbteBan_I.Estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    PrepararFrm(Cl_Enumeradores.eTipo_action.Anular, CbteBan_I);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                CbteBan_I = (ba_Cbte_Ban_Info)UltraGridCbteBanDep.GetFocusedRow();

                if (CbteBan_I == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                    PrepararFrm(Cl_Enumeradores.eTipo_action.consultar, CbteBan_I);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void load_data()
        {
            try
            {
                List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> paramBa_I = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus paramBa_B = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();

                paramBa_I = paramBa_B.Get_List_Banco_Parametros(param.IdEmpresa);

                int nd = 0;

                nd = paramBa_I.First(q => q.CodTipoCbteBan == "NDBA").IdTipoCbteCble;


                List<ba_Cbte_Ban_Info> listado = new List<ba_Cbte_Ban_Info>();

                List<ba_Cbte_Ban_Info> nd_ = new List<ba_Cbte_Ban_Info>();

                nd_ = CbteBan_B.Get_List_Cbte_Ban(param.IdEmpresa, nd, nd
                      , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta, ref MensajeError);

                listado.AddRange(nd_);
                gridControlCbteBanDep.DataSource = listado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void PrepararFrm(Cl_Enumeradores.eTipo_action Accion, ba_Cbte_Ban_Info Info)
        {
            try
            {

                frmND = new FrmBA_Debito_Mant();

                frmND.event_FrmBA_Debito_Mant_FormClosing += frmND_event_FrmBA_Debito_Mant_FormClosing;
                frmND.set_Accion(Accion);
                frmND.MdiParent = this.MdiParent;
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frmND.set_Info(Info);
                }
                frmND.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmND_event_FrmBA_Debito_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                PrepararFrm(Cl_Enumeradores.eTipo_action.grabar, CbteBan_I);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        private void cargar_combos()
        {
            try
            {
                lst_tipo_flujo = bus_tipo_flujo.Get_List_TipoFlujo(param.IdEmpresa);
                cmb_tipo_flujo.DataSource = lst_tipo_flujo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        private void FrmBA_Debito_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                //dtp_desde.Value = dtp_desde.Value.AddDays(-30);
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        col_tipo_flujo.Visible = true;
                        cargar_combos();
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        col_tipo_flujo.Visible = true;
                        cargar_combos();
                        break;
                    default:
                        col_tipo_flujo.Visible = false;
                        break;
                }       
                load_data();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private ba_Cbte_Ban_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (ba_Cbte_Ban_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Cbte_Ban_Info();
            }
        }

        private void UltraGridCbteBanDep_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = UltraGridCbteBanDep.GetRow(e.RowHandle) as ba_Cbte_Ban_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UltraGridCbteBanDep_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                CbteBan_I = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UltraGridCbteBanDep_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                CbteBan_I = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btn_imprimir_lote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (UltraGridCbteBanDep.RowCount == 0)
                {
                    MessageBox.Show("Actualmente no se muestran débitos en la consulta para imprimir", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (MessageBox.Show("Se procederá a imprimir los [" + UltraGridCbteBanDep.RowCount + "] débitos que se muestran en la consulta \n¿ Desea Continuar ?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool Mostrar_preview = false;
                    if (MessageBox.Show("¿Desea visualizar cada débito antes de imprimir?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Mostrar_preview = true;

                    for (int i = 0; i < UltraGridCbteBanDep.RowCount; i++)
                    {
                        ba_Cbte_Ban_Info row = new ba_Cbte_Ban_Info();
                        row = (ba_Cbte_Ban_Info)UltraGridCbteBanDep.GetRow(i);
                        if (row!=null)
                        {
                            switch (param.IdCliente_Ven_x_Default)
                            {
                                case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                    XBAN_NAT_Rpt001_Rpt Reporte_nat = new XBAN_NAT_Rpt001_Rpt();
                                    Reporte_nat.RequestParameters = false;
                                    ReportPrintTool natu = new ReportPrintTool(Reporte_nat);
                                    natu.AutoShowParametersPanel = false;
                                    
                                    Reporte_nat.Parameters["PIdEmpresa"].Value = row.IdEmpresa;
                                    Reporte_nat.Parameters["PIdTipoCbte"].Value = row.IdTipocbte;
                                    Reporte_nat.Parameters["PIdCbteCble"].Value = row.IdCbteCble;
                                     
                                    Reporte_nat.Parameters["PNombreReporte"].Value = "NOTA DE DEBITO";
                                    if (Mostrar_preview)
                                        Reporte_nat.ShowPreviewDialog();
                                    else
                                        Reporte_nat.Print();
                                    break;
                                default:
                                    XBAN_Rpt013_rpt Reporte = new XBAN_Rpt013_rpt();
                                    Reporte.RequestParameters = false;
                                    ReportPrintTool pt = new ReportPrintTool(Reporte);
                                    pt.AutoShowParametersPanel = false;
                                    Reporte.Parameters["PIdEmpresa"].Value = row.IdEmpresa;
                                    Reporte.Parameters["PIdTipoCbte"].Value = row.IdTipocbte;
                                    Reporte.Parameters["PIdCbteCble"].Value = row.IdCbteCble;
                                    if (Mostrar_preview)
                                        Reporte.ShowPreviewDialog();
                                    else
                                        Reporte.Print();
                                    break;
                            }    
                        }                        
                    }                    
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UltraGridCbteBanDep_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                ba_Cbte_Ban_Info row = (ba_Cbte_Ban_Info)UltraGridCbteBanDep.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_tipo_flujo)
                {
                    if (MessageBox.Show("¿Está seguro que desea modificar el tipo de flujo del Cbte # " + row.IdCbteCble.ToString() + "?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (e.Value == null)
                            CbteBan_B.Modificar_tipo_flujo(row.IdEmpresa, row.IdTipocbte, row.IdCbteCble, null);
                        else
                            CbteBan_B.Modificar_tipo_flujo(row.IdEmpresa, row.IdTipocbte, row.IdCbteCble, Convert.ToDecimal(e.Value));
                    }
                    load_data();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UltraGridCbteBanDep_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_tipo_flujo)
                {
                    UltraGridCbteBanDep.SetRowCellValue(e.RowHandle, col_tipo_flujo, e.Value);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
