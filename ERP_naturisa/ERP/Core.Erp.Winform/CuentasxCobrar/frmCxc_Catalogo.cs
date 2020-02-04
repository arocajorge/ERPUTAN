using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_Catalogo : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cxc_CatalogoTipo_Bus CatalogoTipoBus = new cxc_CatalogoTipo_Bus();
        cxc_catalogo_Bus CatalogoBus = new cxc_catalogo_Bus();
        BindingList<cxc_catalogo_Info> CatalogoInfo = new BindingList<cxc_catalogo_Info>();
        List<cxc_CatalogoTipo_Info> CatalogoTipoInfo = new List<cxc_CatalogoTipo_Info>();
        #endregion
       
        public frmCxc_Catalogo()
        {
            try
            {
                InitializeComponent();
                CatalogoTipoInfo = CatalogoTipoBus.Get_List_CatalogoTipo();
                CatalogoTipoInfo.ForEach(var => var.Descripcion = "[" + var.IdCatalogo_tipo + "] - " + var.Descripcion);
                lstbox_TipoCatalogo.DataSource = CatalogoTipoInfo;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info1 = (cxc_catalogo_Info)gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else if (Info1.Estado == "I")
                    MessageBox.Show("El Catálogo # : " + Info1.IdCatalogo + " ya fue anulado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    frmCxc_Catalogo_Mantenimiento frmCataMant = new frmCxc_Catalogo_Mantenimiento((string)lstbox_TipoCatalogo.SelectedValue);
                    frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                    frmCataMant.setInfo = Info1;
                    frmCataMant.Event_frmCxc_Catalogo_Mantenimiento_FormClosing += new frmCxc_Catalogo_Mantenimiento.delegate_Event_frmCxc_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_frmCxc_Catalogo_Mantenimiento_FormClosing);
                    frmCataMant.Show();
                }
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
                var Info1 = (cxc_catalogo_Info)gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info1.Estado == "I")
                    MessageBox.Show("No se pueden Modificar registros Inactivos ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmCxc_Catalogo_Mantenimiento frmCataMant = new frmCxc_Catalogo_Mantenimiento((string)lstbox_TipoCatalogo.SelectedValue);
                    frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frmCataMant.setInfo = Info1;
                    frmCataMant.Event_frmCxc_Catalogo_Mantenimiento_FormClosing += new frmCxc_Catalogo_Mantenimiento.delegate_Event_frmCxc_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_frmCxc_Catalogo_Mantenimiento_FormClosing);
                    frmCataMant.Show();
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
                var Info1 = (cxc_catalogo_Info)gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    frmCxc_Catalogo_Mantenimiento frmCataMant = new frmCxc_Catalogo_Mantenimiento((string)lstbox_TipoCatalogo.SelectedValue);
                    frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                    frmCataMant.setInfo = Info1;
                    frmCataMant.Event_frmCxc_Catalogo_Mantenimiento_FormClosing += new frmCxc_Catalogo_Mantenimiento.delegate_Event_frmCxc_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_frmCxc_Catalogo_Mantenimiento_FormClosing);
                    frmCataMant.Show();
                }
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
                frmCxc_Catalogo_Mantenimiento frmCataMant = new frmCxc_Catalogo_Mantenimiento((string)lstbox_TipoCatalogo.SelectedValue);
                frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frmCataMant.Event_frmCxc_Catalogo_Mantenimiento_FormClosing += new frmCxc_Catalogo_Mantenimiento.delegate_Event_frmCxc_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_frmCxc_Catalogo_Mantenimiento_FormClosing);
                frmCataMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstbox_TipoCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CatalogoInfo = new BindingList<cxc_catalogo_Info>(CatalogoBus.ObtenerIdTipoLista(Convert.ToString(lstbox_TipoCatalogo.SelectedValue)));
                gridControlCatalogo.DataSource = CatalogoInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gridViewCatalogo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCatalogo.GetRow(e.RowHandle) as cxc_catalogo_Info;
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

        void frmCataMant_Event_frmCxc_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gridControlCatalogo.DataSource = CatalogoBus.ObtenerIdTipoLista(Convert.ToString(lstbox_TipoCatalogo.SelectedValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void FrmBA_CatalogoTipoMant_Event_frmCxc_CatalogoTipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CatalogoTipoInfo = CatalogoTipoBus.Get_List_CatalogoTipo();
                CatalogoTipoInfo.ForEach(var => var.Descripcion = "[" + var.IdCatalogo_tipo + "] - " + var.Descripcion);
                lstbox_TipoCatalogo.DataSource = CatalogoTipoInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_NuevoTipoCatalogo_Click(object sender, EventArgs e)
        {
            try
            {
                frmCxc_CatalogoTipo_Mantenimiento frmCataTipoMant = new frmCxc_CatalogoTipo_Mantenimiento();
                frmCataTipoMant.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frmCataTipoMant.Event_frmCxc_CatalogoTipo_Mantenimiento_FormClosing += new frmCxc_CatalogoTipo_Mantenimiento.delegate_frmCxc_CatalogoTipo_Mantenimiento_FormClosing(FrmBA_CatalogoTipoMant_Event_frmCxc_CatalogoTipo_Mantenimiento_FormClosing);
                frmCataTipoMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ModificarTipoCatalogo_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = (string)lstbox_TipoCatalogo.SelectedValue;
                cxc_CatalogoTipo_Info Info = (cxc_CatalogoTipo_Info)CatalogoTipoBus.Get_Info_CatalogoTipo(cod);

                if (Info == null)
                    MessageBox.Show("No Existe el Tipo de Catálogo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmCxc_CatalogoTipo_Mantenimiento frmCataTipoMant = new frmCxc_CatalogoTipo_Mantenimiento();
                    frmCataTipoMant.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frmCataTipoMant._SetInfo = Info;
                    frmCataTipoMant.Event_frmCxc_CatalogoTipo_Mantenimiento_FormClosing += new frmCxc_CatalogoTipo_Mantenimiento.delegate_frmCxc_CatalogoTipo_Mantenimiento_FormClosing(FrmBA_CatalogoTipoMant_Event_frmCxc_CatalogoTipo_Mantenimiento_FormClosing);
                    frmCataTipoMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_c_ButtonClick(object sender, EventArgs e)
        {

        }

    }
}
