using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Catalogo_Consul : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        ba_CatalogoTipo_Bus CatalogoTipoBus = new ba_CatalogoTipo_Bus();
        ba_Catalogo_Bus CatalogoBus = new ba_Catalogo_Bus();
        BindingList<ba_Catalogo_Info> CatalogoInfo = new BindingList<ba_Catalogo_Info>();
        List<ba_CatalogoTipo_info> CatalogoTipoInfo = new List<ba_CatalogoTipo_info>();

        #endregion
       
        public FrmBA_Catalogo_Consul()
        {
            try
            {
                InitializeComponent();
                CatalogoTipoInfo = CatalogoTipoBus.Get_List_CatalogoTipo();
                CatalogoTipoInfo.ForEach(var => var.tc_descripcion = "[" + var.IdTipoCatalogo + "] - " + var.tc_descripcion);
                lstbox_TipoCatalogo.DataSource = CatalogoTipoInfo;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmBA_Catalogo_Mant frmCataMant = new FrmBA_Catalogo_Mant((string)lstbox_TipoCatalogo.SelectedValue);
                frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frmCataMant.Event_FrmBA_Catalogo_Mantenimiento_FormClosing += new FrmBA_Catalogo_Mant.delegate_FrmBA_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_FrmBA_Catalogo_Mantenimiento_FormClosing);
                frmCataMant.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info1 = (ba_Catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info1.ca_estado == "I")
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_modif_regis_Inac), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmBA_Catalogo_Mant frmCataMant = new FrmBA_Catalogo_Mant((string)lstbox_TipoCatalogo.SelectedValue);
                    frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frmCataMant.setInfo = Info1;
                    frmCataMant.Event_FrmBA_Catalogo_Mantenimiento_FormClosing += new FrmBA_Catalogo_Mant.delegate_FrmBA_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_FrmBA_Catalogo_Mantenimiento_FormClosing);
                    frmCataMant.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                var Info1 = (ba_Catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    FrmBA_Catalogo_Mant frmCataMant = new FrmBA_Catalogo_Mant((string)lstbox_TipoCatalogo.SelectedValue);
                    frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                    frmCataMant.setInfo = Info1;
                    frmCataMant.Event_FrmBA_Catalogo_Mantenimiento_FormClosing += new FrmBA_Catalogo_Mant.delegate_FrmBA_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_FrmBA_Catalogo_Mantenimiento_FormClosing);
                    frmCataMant.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                var Info1 = (ba_Catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else if (Info1.ca_estado == "I")
                    MessageBox.Show("El Catálogo # : " + Info1.IdCatalogo + " ya fue anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    FrmBA_Catalogo_Mant frmCataMant = new FrmBA_Catalogo_Mant((string)lstbox_TipoCatalogo.SelectedValue);
                    frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                    frmCataMant.setInfo = Info1;
                    frmCataMant.Event_FrmBA_Catalogo_Mantenimiento_FormClosing += new FrmBA_Catalogo_Mant.delegate_FrmBA_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_FrmBA_Catalogo_Mantenimiento_FormClosing);
                    frmCataMant.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void lstbox_TipoCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CatalogoInfo = new BindingList<ba_Catalogo_Info>(CatalogoBus.Get_List_Catalogo(Convert.ToString(lstbox_TipoCatalogo.SelectedValue)));
                gridControlCatalogo.DataSource = CatalogoInfo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void gridViewCatalogo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCatalogo.GetRow(e.RowHandle) as ba_Catalogo_Info;
                if (data == null)
                    return;
                if (data.ca_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmCataMant_Event_FrmBA_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gridControlCatalogo.DataSource = CatalogoBus.Get_List_Catalogo(Convert.ToString(lstbox_TipoCatalogo.SelectedValue));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void FrmBA_CatalogoTipoMant_Event_FrmBA_CatalogoTipoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CatalogoTipoInfo = CatalogoTipoBus.Get_List_CatalogoTipo();
                CatalogoTipoInfo.ForEach(var => var.tc_descripcion = "[" + var.IdTipoCatalogo + "] - " + var.tc_descripcion);
                lstbox_TipoCatalogo.DataSource = CatalogoTipoInfo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_NuevoTipoCatalogo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBA_CatalogoTipo_Mant frmCataTipoMant = new FrmBA_CatalogoTipo_Mant();
                frmCataTipoMant.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frmCataTipoMant.Event_FrmBA_CatalogoTipo_Mant_FormClosing += new FrmBA_CatalogoTipo_Mant.delegate_FrmBA_CatalogoTipo_Mant_FormClosing(FrmBA_CatalogoTipoMant_Event_FrmBA_CatalogoTipoMant_FormClosing);
                frmCataTipoMant.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_ModificarTipoCatalogo_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = (string)this.lstbox_TipoCatalogo.SelectedValue;
                ba_CatalogoTipo_info Info = (ba_CatalogoTipo_info)CatalogoTipoBus.Get_Info_Catalogo(cod);

                if (Info == null)
                    MessageBox.Show("No Exite el Tipo de Catalogo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmBA_CatalogoTipo_Mant frmCataTipoMant = new FrmBA_CatalogoTipo_Mant();
                    frmCataTipoMant.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frmCataTipoMant._SetInfo = Info;
                    frmCataTipoMant.Event_FrmBA_CatalogoTipo_Mant_FormClosing += new FrmBA_CatalogoTipo_Mant.delegate_FrmBA_CatalogoTipo_Mant_FormClosing(FrmBA_CatalogoTipoMant_Event_FrmBA_CatalogoTipoMant_FormClosing);
                    frmCataTipoMant.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
       
    }
}
