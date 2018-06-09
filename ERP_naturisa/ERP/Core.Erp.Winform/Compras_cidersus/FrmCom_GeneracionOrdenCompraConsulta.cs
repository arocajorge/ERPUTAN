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





namespace Core.Erp.Winform.Compras_cidersus
{
    public partial class FrmCom_GeneracionOrdenCompraConsulta : Form
    {

        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        com_ordencompra_local_Bus BusOC = new com_ordencompra_local_Bus();
        com_ordencompra_local_Info InfoOC = new com_ordencompra_local_Info();
        FrmCom_GeneracionOrdenCompraMantenimiento frm = new FrmCom_GeneracionOrdenCompraMantenimiento();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;
        int IdSucursal = 0;
        #endregion
       

        public FrmCom_GeneracionOrdenCompraConsulta()
        {
            try
            {
             InitializeComponent();
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void frm_Event_FrmCom_GeneracionOrdenCompraMantenimiento(object sender, FormClosingEventArgs e)
        {
            

        }
        private void FrmCom_GeneracionOrdenCompraConsulta_Load(object sender, EventArgs e)
        {           
        }     
        com_GeneracionOCompra_Info Info = new com_GeneracionOCompra_Info();
        private void gridViewListGenerOC_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            
        }


        private void cargagrid()
        {
            try
            {
                List<com_ordencompra_local_Info> LstOC = new List<com_ordencompra_local_Info>();
                LstOC = BusOC.Get_List_ordencompra_local(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta, "", "");
                gridControlOrdenCompra.DataSource = LstOC;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                frm = new FrmCom_GeneracionOrdenCompraMantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.Show(); frm.MdiParent = this.MdiParent;
               // frm.event_frmCom_OrdenCompra_Mant_FormClosing += frm_event_frmCom_OrdenCompra_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                InfoOC = (com_ordencompra_local_Info)gridViewOrdenCompra.GetFocusedRow();
                if (InfoOC != null)
                {
                    in_Ing_Egr_Inven_det_Bus bus_IngEgr = new in_Ing_Egr_Inven_det_Bus();
                    List<in_Ing_Egr_Inven_det_Info> list_IngEgr = new List<in_Ing_Egr_Inven_det_Info>();
                    list_IngEgr = bus_IngEgr.Get_List_Ing_Egr_Inven_det_x_OrdenCompra(InfoOC.IdEmpresa, InfoOC.IdSucursal, InfoOC.IdOrdenCompra);

                    if (InfoOC.Estado == "I")
                    {
                        MessageBox.Show("No se puede modificar Orden de Compra Anulada ");
                    }
                    else
                    {

                        if (list_IngEgr.Count != 0)
                        {
                            MessageBox.Show("La Orden de compra Nº " + InfoOC.oc_NumDocumento +
                                 " tiene Ingresos a Bodega. No se puede modificar.");
                        }
                        else
                        {
                            frm = new FrmCom_GeneracionOrdenCompraMantenimiento();
                            frm.InfoCab = InfoOC;
                            frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                            frm.Text = frm.Text + " ***MODIFICAR***";
                            frm.Show(); frm.MdiParent = this.MdiParent;
                            frm.event_frmCom_OrdenCompra_Mant_FormClosing += frm_event_frmCom_OrdenCompra_Mant_FormClosing;

                        }
                    }



                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoOC = (com_ordencompra_local_Info)gridViewOrdenCompra.GetFocusedRow();
                if (InfoOC != null)
                {
                    frm = new FrmCom_GeneracionOrdenCompraMantenimiento();
                    frm.InfoCab = InfoOC;

                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular); frm.MdiParent = this.MdiParent;
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                   // frm.event_frmCom_OrdenCompra_Mant_FormClosing += frm_event_frmCom_OrdenCompra_Mant_FormClosing;
                    frm.event_frmCom_OrdenCompra_Mant_FormClosing += frm_event_frmCom_OrdenCompra_Mant_FormClosing;
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoOC = (com_ordencompra_local_Info)gridViewOrdenCompra.GetFocusedRow();
                if (InfoOC != null)
                {
                    frm = new FrmCom_GeneracionOrdenCompraMantenimiento();
                    frm.InfoCab = InfoOC;

                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar); frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IdSucursal = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;


                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewOrdenCompra_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewOrdenCompra.GetRow(e.RowHandle) as com_ordencompra_local_Info;
                if (data == null)
                    return;
                if (data.Estado == "I" || data.IdEstadoAprobacion_cat == "REP")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
    }
}
