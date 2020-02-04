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

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_CatalogoConsulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        tb_Catalogo_Bus BusCatalogo = new tb_Catalogo_Bus();
        List<tb_Catalogo_Info> ListCatalogoFiltrada = new List<tb_Catalogo_Info>();
        List<tb_CatalogoTipo_Info> ListaTipoCat = new List<tb_CatalogoTipo_Info>();
        tb_CatalogoTipo_Bus DataTipoCat = new tb_CatalogoTipo_Bus();
        tb_Catalogo_Info InfoCatalogo = new tb_Catalogo_Info();

        Cl_Enumeradores.TipoCatalogo EnumTipo;

        //nuevo
        BindingList<tb_Catalogo_Info> BinListCatalogo = new BindingList<tb_Catalogo_Info>();


        public FrmGe_CatalogoConsulta()
        {
            try
            {
               InitializeComponent();
              // CargaListaTipo();

               //cargaLista();
               ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
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

       //nuevo
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new FrmGe_CatalogoTipo_man(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));
                ofrm.Event_frmGe_CatalogoTipo_man_FormClosing += ofrm_Event_frmGe_CatalogoTipo_man_FormClosing;
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.consultar);
                ofrm.SetInfo = gridViewCatalogo.GetFocusedRow() as tb_Catalogo_Info;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

       //nuevo
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                ofrm = new FrmGe_CatalogoTipo_man(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));
                ofrm.Event_frmGe_CatalogoTipo_man_FormClosing += ofrm_Event_frmGe_CatalogoTipo_man_FormClosing;
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                ofrm.SetInfo = gridViewCatalogo.GetFocusedRow() as tb_Catalogo_Info;
                ofrm.Show();
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
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

       //nuevo

        FrmGe_CatalogoTipo_man ofrm = new FrmGe_CatalogoTipo_man();
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new FrmGe_CatalogoTipo_man(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));
                ofrm.Event_frmGe_CatalogoTipo_man_FormClosing += ofrm_Event_frmGe_CatalogoTipo_man_FormClosing;
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        void ofrm_Event_frmGe_CatalogoTipo_man_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargaLista();
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
                    ofrm = new FrmGe_CatalogoTipo_man(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));
                    ofrm.Event_frmGe_CatalogoTipo_man_FormClosing += ofrm_Event_frmGe_CatalogoTipo_man_FormClosing;
                    ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.Anular);
                    ofrm.SetInfo = gridViewCatalogo.GetFocusedRow() as tb_Catalogo_Info;
                    ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

           
        private void FrmGe_CatalogoConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                cargaLista();
                this.lstbox_TipoCatalogo.Focus();

                
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
                string tipo = lstbox_TipoCatalogo.SelectedValue.ToString();
                if (lstbox_TipoCatalogo.SelectedValue != null)
                {
                    if (lstbox_TipoCatalogo.ValueMember != "")
                    {
                        BinListCatalogo = new BindingList<tb_Catalogo_Info>(BusCatalogo.Get_CatalogoPorTipo(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue)));
                        gridControlCatalogo.DataSource = BinListCatalogo;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }


        FrmGe_CatalogoMant frmCataTipoMant = new FrmGe_CatalogoMant();

        private void btnNuevo_TipoCat_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                frmCataTipoMant = new FrmGe_CatalogoMant();
                frmCataTipoMant.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frmCataTipoMant.Event_frmGE_CatalogoMant_FormClosing += frmCataTipoMant_Event_frmGE_CatalogoMant_FormClosing;
                frmCataTipoMant.Text = frmCataTipoMant.Text + " ***NUEVO REGISTRO***";
                frmCataTipoMant.Show();

            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        void frmCataTipoMant_Event_frmGE_CatalogoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargaLista();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        List<tb_CatalogoTipo_Info> CatalogoTipoInfo = new List<tb_CatalogoTipo_Info>();       
        void cargaLista()
        {

            try
            {
                CatalogoTipoInfo = DataTipoCat.ObtenerList_Tipo();
                CatalogoTipoInfo.ForEach(var => var.tc_Descripcion = "[" + var.IdTipoCatalogo.ToString() + "] - " + var.tc_Descripcion);
                lstbox_TipoCatalogo.DataSource = CatalogoTipoInfo;            
                lstbox_TipoCatalogo.DisplayMember = "tc_Descripcion";
                lstbox_TipoCatalogo.ValueMember = "IdTipoCatalogo";
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
                var data = gridViewCatalogo.GetRow(e.RowHandle) as tb_Catalogo_Info;
                if (data == null)
                    return;
                if (data.ca_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
    
    }
}
