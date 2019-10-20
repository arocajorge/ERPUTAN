using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Info.General;
using DevExpress.XtraPrinting;

using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Cus.Erp.Reports.Naturisa.Compras;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Winform.Compras
{
    public partial class frmCom_OrdenCompra_Cons : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        com_ordencompra_local_Bus Bus_OC = new com_ordencompra_local_Bus();
        com_ordencompra_local_consulta Info_OC = new com_ordencompra_local_consulta();
        frmCom_OrdenCompra_Mant frm = new frmCom_OrdenCompra_Mant();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_ordencompra_local_Info OC = new com_ordencompra_local_Info();
        in_Ing_Egr_Inven_det_Bus bus_IngEgr = new in_Ing_Egr_Inven_det_Bus();
        int IdSucursal = 0;
        #endregion
       
        public frmCom_OrdenCompra_Cons()
        {
            try
            {
                InitializeComponent();
               
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
              
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
                IdSucursal = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                cargagrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
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
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
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
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
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
                gridViewOrdenCompra.ShowPrintPreview();
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_frmCom_OrdenCompra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cargagrid()
        {
            try
            {
                List<com_ordencompra_local_consulta> LstOC = new List<com_ordencompra_local_consulta>();
                LstOC = Bus_OC.Get_List_ordencompra_local(param.IdEmpresa,  ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
                gridControlOrdenCompra.DataSource = LstOC ;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    
        private void gridViewOrdenCompra_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

            try
            {
                var data = gridViewOrdenCompra.GetRow(e.RowHandle) as com_ordencompra_local_consulta;
                if (data == null)
                    return;
                if (data.Estado == "I" || data.IdEstadoAprobacion_cat == "REP")
                    e.Appearance.ForeColor = Color.Red;
                else
                if (data.IdEstado_cierre == "ABI" && data.IdEstadoAprobacion_cat=="APRO")
                {
                    e.Appearance.ForeColor = Color.Blue;
                }
                else
                if (data.IdEstado_cierre == "CERR")
                {
                    e.Appearance.ForeColor = Color.DarkGreen;
                }
                else
                if (data.IdEstado_cierre == "PEN")
                {
                    e.Appearance.ForeColor = Color.DarkOrange;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmCom_OrdenCompraConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                IdSucursal = 0;
                cargagrid();
                ucGe_Menu_Mantenimiento_x_usuario.carga_Sucursal_Todas();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewOrdenCompra_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
                   
        private void gridViewOrdenCompra_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                string mensajeFrm = "";

                Info_OC = new com_ordencompra_local_consulta();

                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        mensajeFrm = "REGISTRO NUEVO";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        mensajeFrm = "MODIFICAR REGISTRO";
                        Info_OC = (com_ordencompra_local_consulta)gridViewOrdenCompra.GetFocusedRow();
                        
                        
                        if (Info_OC != null)
                        {
                            
                            bool TieneIngresos = bus_IngEgr.ValidarOcTieneIngresos(Info_OC.IdEmpresa, Info_OC.IdSucursal, Info_OC.IdOrdenCompra);

                            if (Info_OC.IdEstadoAprobacion_cat == "APRO")
                            {
                                MessageBox.Show("La Orden de compra Nº " + Info_OC.Codigo +
                                     " ya fue Aprobada. No se puede modificar.");
                                return;
                            }
                            else
                            {
                                if (TieneIngresos)
                                {
                                    MessageBox.Show("La Orden de compra Nº " + Info_OC.Codigo +
                                         " tiene Ingresos a Bodega. No se puede modificar.");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un Registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        mensajeFrm = "ANULAR REGISTRO";
                        Info_OC = (com_ordencompra_local_consulta)gridViewOrdenCompra.GetFocusedRow();
                        bool TieneIngresosAnular = bus_IngEgr.ValidarOcTieneIngresos(Info_OC.IdEmpresa, Info_OC.IdSucursal, Info_OC.IdOrdenCompra);
                        if (TieneIngresosAnular)
                        {
                            MessageBox.Show("La Orden de compra Nº " + Info_OC.Codigo +
                                 " tiene Ingresos a Bodega. No se puede anular.");
                            return;
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        mensajeFrm = "CONSULTAR REGISTRO";
                        Info_OC = (com_ordencompra_local_consulta)gridViewOrdenCompra.GetFocusedRow();
                        
                        break;
                    default:
                        break;
                }

                if (Info_OC != null)
                {
                    OC = Bus_OC.Get_Info_ordencompra_local(Info_OC.IdEmpresa, Info_OC.IdSucursal, Info_OC.IdOrdenCompra);
                    frm = new frmCom_OrdenCompra_Mant();
                    frm.Text = frm.Text + "***" + mensajeFrm + "***";
                    frm.Set_Accion(iAccion);                    
                    frm.Set_Info(OC);
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_frmCom_OrdenCompra_Mant_FormClosing+=frm_event_frmCom_OrdenCompra_Mant_FormClosing;
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbImgGuia_Click(object sender, EventArgs e)
        {
            try
            {
                Info_OC = (com_ordencompra_local_consulta)gridViewOrdenCompra.GetFocusedRow();
                if (Info_OC != null)
                {
                    FrmCom_OrdenCompra_x_Guia_x_traspaso_Cons frm = new FrmCom_OrdenCompra_x_Guia_x_traspaso_Cons();
                    OC = Bus_OC.Get_Info_ordencompra_local(Info_OC.IdEmpresa, Info_OC.IdSucursal, Info_OC.IdOrdenCompra);
                    frm.Set_info_OC(OC);
                    frm.ShowDialog();    
                }
                
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
                Info_OC = (com_ordencompra_local_consulta)gridViewOrdenCompra.GetFocusedRow();
                if (Info_OC == null)
                    return;

                XCOMP_NATU_Rpt007_Rpt Reporte_Natu = new XCOMP_NATU_Rpt007_Rpt();
                Reporte_Natu.RequestParameters = false;
                ReportPrintTool pt_Natu = new ReportPrintTool(Reporte_Natu);
                pt_Natu.AutoShowParametersPanel = false;
                Reporte_Natu.PIdEmpresa.Value = param.IdEmpresa;
                Reporte_Natu.PIdSucursal.Value = Info_OC.IdSucursal;
                Reporte_Natu.PIdOrdenCompra.Value = Info_OC.IdOrdenCompra;
                Reporte_Natu.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_delegate_beiCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info_OC = (com_ordencompra_local_consulta)gridViewOrdenCompra.GetFocusedRow();
                
                if (Info_OC == null)
                {
                    MessageBox.Show("Seleccione un registro",param.NombreEmpresa,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                if (Info_OC.IdEstado_cierre == "CERR")
                {
                    MessageBox.Show("La orden de compra "+Info_OC.Codigo+" ya se encuentra cerrada",param.NombreEmpresa,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                if (MessageBox.Show("¿ Está seguro que desea cerrar la orden de compra " + Info_OC.Codigo + "?", param.NombreEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Bus_OC.CerrarOC(Info_OC.IdEmpresa, Info_OC.IdSucursal, Info_OC.IdOrdenCompra))
                    {
                        Info_OC.IdEstado_cierre = "CERR";
                        Info_OC.EstadoCierre = "Cerrado";
                        gridControlOrdenCompra.RefreshDataSource();
                        MessageBox.Show("Registro actualizado exitósamente", param.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //cargagrid();
                    }    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
