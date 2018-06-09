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

using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Genera_Guia_x_Traspaso_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;
        int RowHanlde = 0;
        FrmIn_Genera_Guia_x_Traspaso_Mant frm = new FrmIn_Genera_Guia_x_Traspaso_Mant();

        in_Guia_x_traspaso_bodega_Bus busGuiaTrasp = new in_Guia_x_traspaso_bodega_Bus();

        in_Guia_x_traspaso_bodega_Info InfoGuia = new in_Guia_x_traspaso_bodega_Info();
        List<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info> lst_trans_x_guia = new List<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info>();
        in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Bus bus_trans_x_guia = new in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Bus();

        
        public FrmIn_Genera_Guia_x_Traspaso_Cons()
        {
            InitializeComponent();

      
            //frm.event_frmGuia_Traspaso_FormClosing += frm_event_frmGuia_Traspaso_FormClosing;
            //cargagrid();

            ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click;
        }

        void frm_event_frmGuia_Traspaso_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargagrid()
        {
            try
            {
                List<in_Guia_x_traspaso_bodega_Info> LstOC = new List<in_Guia_x_traspaso_bodega_Info>();
                LstOC = busGuiaTrasp.Get_List_Guia_x_traspaso_bodega(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta);
                gridControlGuiaCons.DataSource = LstOC;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoGuia = (in_Guia_x_traspaso_bodega_Info)gridViewGuiaCons.GetFocusedRow();
                if (InfoGuia != null)
                {
                    if (InfoGuia.Estado=="I")
                    {
                        MessageBox.Show("No se pueden modificar registros inactivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                    else
                    {
                        if (!Validar_guia_x_transferencia())
                            return;

                       frm = new FrmIn_Genera_Guia_x_Traspaso_Mant();
                       frm.Set_Info(InfoGuia);
                       frm.Set_Accion(Cl_Enumeradores.eTipo_action.actualizar); frm.MdiParent = this.MdiParent;
                       frm.Show();
                       frm.event_frmGuia_Traspaso_FormClosing += frm_event_frmGuia_Traspaso_FormClosing;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new FrmIn_Genera_Guia_x_Traspaso_Mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.Show(); frm.MdiParent = this.MdiParent;
                frm.event_frmGuia_Traspaso_FormClosing+=frm_event_frmGuia_Traspaso_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoGuia = (in_Guia_x_traspaso_bodega_Info)gridViewGuiaCons.GetFocusedRow();
                if (InfoGuia != null)
                {
                    frm = new FrmIn_Genera_Guia_x_Traspaso_Mant();
                    frm.Set_Info(InfoGuia);
                    frm.Set_Accion(Cl_Enumeradores.eTipo_action.consultar); frm.MdiParent = this.MdiParent;
                    frm.Show();
                    frm.event_frmGuia_Traspaso_FormClosing += frm_event_frmGuia_Traspaso_FormClosing;

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewGuiaCons.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoGuia = (in_Guia_x_traspaso_bodega_Info)gridViewGuiaCons.GetFocusedRow();
                if (InfoGuia != null)
                {
                    if (InfoGuia.Estado != "I")
                    {
                        frm = new FrmIn_Genera_Guia_x_Traspaso_Mant();
                        frm.Set_Info(InfoGuia);
                        frm.Set_Accion(Cl_Enumeradores.eTipo_action.Anular); frm.MdiParent = this.MdiParent;
                        frm.event_frmGuia_Traspaso_FormClosing += frm_event_frmGuia_Traspaso_FormClosing;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                    }
                    else
                        MessageBox.Show("El registro seleccionado ya se encuentra anulado.\nPor favor seleccione otro registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Genera_Guia_x_Traspaso_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewGuiaCons_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                 var data = gridViewGuiaCons.GetRow(e.RowHandle) as in_Guia_x_traspaso_bodega_Info;
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

        private void gridViewGuiaCons_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                InfoGuia = (in_Guia_x_traspaso_bodega_Info)gridViewGuiaCons.GetFocusedRow();
            }
            catch (Exception ex)
            {               
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_Load(object sender, EventArgs e)
        {

        }

        private bool Validar_guia_x_transferencia()
        {
            try
            {
                InfoGuia = (in_Guia_x_traspaso_bodega_Info)gridViewGuiaCons.GetRow(RowHanlde);
                if (InfoGuia!=null)
                {
                    lst_trans_x_guia = bus_trans_x_guia.Get_list_trans_x_guia(InfoGuia.IdEmpresa, InfoGuia.IdGuia);
                    string mensaje = "GR# " + InfoGuia.IdGuia + ", no puede ser modificada debido a que está siendo utilizada en las siguientes transferencias:";
                    foreach (var item in lst_trans_x_guia)
                    {
                        mensaje += "\nSucursal: "+item.Su_Descripcion.Trim()+" Bodega: "+item.bo_Descripcion.Trim()+" Transferencia #:"+item.IdTransferencia_trans+"\n ["+item.pr_codigo+"] "+item.pr_descripcion;
                    }
                    if (mensaje != "GR# " + InfoGuia.IdGuia + ", no puede ser modificada debido a que está siendo utilizada en las siguientes transferencias:")
                    {
                        MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void gridViewGuiaCons_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHanlde = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
