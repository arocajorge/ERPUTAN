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
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Catalogo : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        com_CatalogoTipo_Bus CatalogoTipoBus = new com_CatalogoTipo_Bus();
        com_Catalogo_Bus CatalogoBus = new com_Catalogo_Bus();
        BindingList<com_Catalogo_Info> CatalogoInfo = new BindingList<com_Catalogo_Info>();
        List<com_CatalogoTipo_Info> CatalogoTipoInfo = new List<com_CatalogoTipo_Info>();
        #endregion

        public FrmCom_Catalogo()
        {
            InitializeComponent();            
            CatalogoTipoInfo = CatalogoTipoBus.Get_List_CatalogoTipo();
            CatalogoTipoInfo.ForEach(var => var.Descripcion = "[" + var.IdCatalogocompra_tipo + "] - " + var.Descripcion);
            lstbox_TipoCatalogo.DataSource = CatalogoTipoInfo;
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info1 = (com_Catalogo_Info)gridViewCatalogo.GetFocusedRow();

                //FrmCom_Catalogo_Mantenimiento FrmCataMant = new FrmCom_Catalogo_Mantenimiento(Convert.ToString( lstbox_TipoCatalogo.SelectedValue));
                FrmCom_Catalogo_Mantenimiento FrmCataMant = new FrmCom_Catalogo_Mantenimiento(Convert.ToString(Info1.IdCatalogocompra_tipo));
                FrmCataMant.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                FrmCataMant.Event_FrmCom_Catalogo_Mantenimiento_FormClosing += new FrmCom_Catalogo_Mantenimiento.delegate_Event_FrmCom_Catalogo_Mantenimiento_FormClosing(FrmCataMant_Event_FrmCom_Catalogo_Mantenimiento_FormClosing);
                FrmCataMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info1 = (com_Catalogo_Info)gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               else
                {
                   // FrmCom_Catalogo_Mantenimiento FrmCataMant = new FrmCom_Catalogo_Mantenimiento(Convert.ToString(lstbox_TipoCatalogo.SelectedValue));
                    FrmCom_Catalogo_Mantenimiento FrmCataMant = new FrmCom_Catalogo_Mantenimiento(Convert.ToString(Info1.IdCatalogocompra_tipo));
                    FrmCataMant.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    FrmCataMant.setInfo = Info1;
                    FrmCataMant.Event_FrmCom_Catalogo_Mantenimiento_FormClosing += new FrmCom_Catalogo_Mantenimiento.delegate_Event_FrmCom_Catalogo_Mantenimiento_FormClosing(FrmCataMant_Event_FrmCom_Catalogo_Mantenimiento_FormClosing);
                    FrmCataMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info1 = (com_Catalogo_Info)gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                  //  FrmCom_Catalogo_Mantenimiento FrmCataMant = new FrmCom_Catalogo_Mantenimiento(Convert.ToString(lstbox_TipoCatalogo.SelectedValue));
                    FrmCom_Catalogo_Mantenimiento FrmCataMant = new FrmCom_Catalogo_Mantenimiento(Convert.ToString(Info1.IdCatalogocompra_tipo));
                    FrmCataMant.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                    FrmCataMant.setInfo = Info1;
                    FrmCataMant.Event_FrmCom_Catalogo_Mantenimiento_FormClosing += new FrmCom_Catalogo_Mantenimiento.delegate_Event_FrmCom_Catalogo_Mantenimiento_FormClosing(FrmCataMant_Event_FrmCom_Catalogo_Mantenimiento_FormClosing);
                    FrmCataMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info1 = (com_Catalogo_Info)gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else if (Info1.estado == "I")
                    MessageBox.Show("El Catálogo # : " + Info1.IdCatalogocompra + " ya fue anulado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                   // FrmCom_Catalogo_Mantenimiento FrmCataMant = new FrmCom_Catalogo_Mantenimiento((string)lstbox_TipoCatalogo.SelectedValue);
                    FrmCom_Catalogo_Mantenimiento FrmCataMant = new FrmCom_Catalogo_Mantenimiento(Convert.ToString(Info1.IdCatalogocompra_tipo));
                    FrmCataMant.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                    FrmCataMant.setInfo = Info1;
                    FrmCataMant.Event_FrmCom_Catalogo_Mantenimiento_FormClosing += new FrmCom_Catalogo_Mantenimiento.delegate_Event_FrmCom_Catalogo_Mantenimiento_FormClosing(FrmCataMant_Event_FrmCom_Catalogo_Mantenimiento_FormClosing);
                    FrmCataMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmCataMant_Event_FrmCom_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                com_CatalogoTipo_Info cod = (com_CatalogoTipo_Info)this.lstbox_TipoCatalogo.SelectedValue;
                gridControlCatalogo.DataSource = CatalogoBus.Get_IdTipoLista(Convert.ToString(cod.IdCatalogocompra_tipo));
                gridControlCatalogo.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lstbox_TipoCatalogo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                com_CatalogoTipo_Info cod = (com_CatalogoTipo_Info)this.lstbox_TipoCatalogo.SelectedValue;                             
                CatalogoInfo = new BindingList<com_Catalogo_Info>(CatalogoBus.Get_IdTipoLista(Convert.ToString(cod.IdCatalogocompra_tipo)));
                gridControlCatalogo.DataSource = CatalogoInfo;
                gridControlCatalogo.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCatalogo_RowCellStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCatalogo.GetRow(e.RowHandle) as com_Catalogo_Info;
                if (data == null)
                    return;
                if (data.estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmCom_CatalogoTipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CatalogoTipoInfo = CatalogoTipoBus.Get_List_CatalogoTipo();
                CatalogoTipoInfo.ForEach(var => var.Descripcion = "[" + var.IdCatalogocompra_tipo + "] - " + var.Descripcion);
                lstbox_TipoCatalogo.DataSource = CatalogoTipoInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnNuevo_c_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCom_CatalogoTipo_Mantenimiento frmCataTipoMant = new FrmCom_CatalogoTipo_Mantenimiento();
                frmCataTipoMant.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frmCataTipoMant.Event_FrmCom_CatalogoTipo_Mantenimiento_FormClosing += new FrmCom_CatalogoTipo_Mantenimiento.delegate_FrmCom_CatalogoTipo_Mantenimiento_FormClosing(FrmCom_CatalogoTipo_Mantenimiento_FormClosing);
                frmCataTipoMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_c_Click(object sender, EventArgs e)
        {
            try
            {
                //string cod = (string)lstbox_TipoCatalogo.SelectedValue;
                com_CatalogoTipo_Info cod = (com_CatalogoTipo_Info)this.lstbox_TipoCatalogo.SelectedValue;       
                com_CatalogoTipo_Info Info = (com_CatalogoTipo_Info)CatalogoTipoBus.Get_Info_CatalogoTipo(cod.IdCatalogocompra_tipo);

                if (Info == null)
                    MessageBox.Show("No Existe el Tipo de Catálogo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmCom_CatalogoTipo_Mantenimiento frmCataTipoMant = new FrmCom_CatalogoTipo_Mantenimiento();
                    frmCataTipoMant.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frmCataTipoMant.Set( Info);
                    frmCataTipoMant.Event_FrmCom_CatalogoTipo_Mantenimiento_FormClosing += new FrmCom_CatalogoTipo_Mantenimiento.delegate_FrmCom_CatalogoTipo_Mantenimiento_FormClosing(FrmCom_CatalogoTipo_Mantenimiento_FormClosing);
                    frmCataTipoMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargalista()
        {
             try
            {
                CatalogoTipoInfo = CatalogoTipoBus.Get_List_CatalogoTipo();
                CatalogoTipoInfo.ForEach(var => var.Descripcion = "[" + var.IdCatalogocompra_tipo + "] - " + var.Descripcion);
                lstbox_TipoCatalogo.DataSource = CatalogoTipoInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCom_Catalogo_Load(object sender, EventArgs e)
        {
            try
            {
                cargalista();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       


    }
}
