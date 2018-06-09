using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Catalogo_cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_catalogo_tipo_Bus CatalogoTipoBus = new fa_catalogo_tipo_Bus();

        fa_catalogo_Bus CatalogoBus = new fa_catalogo_Bus();
        List<fa_catalogo_tipo_Info> CatalogoTipoInfo = new List<fa_catalogo_tipo_Info>();
        BindingList<fa_catalogo_Info> CatalogoInfo = new BindingList<fa_catalogo_Info>();
       
        public frmFa_Catalogo_cons()
        {
            try
            {
                InitializeComponent();

                frmCataTipoMant.event_frmFA_CatalogoTipo_Mant_FormClosing += frmCataTipoMant_event_frmFA_CatalogoTipo_Mant_FormClosing;

                cargaLista();

                frmFa_Catalogo_Mant frm = new frmFa_Catalogo_Mant((int)lstbox_TipoCatalogo.SelectedValue);
                frm.event_frmFA_Catalogo_Mant_FormClosing += frm_event_frmFA_Catalogo_Mant_FormClosing;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;

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

                fa_catalogo_Info Info = (fa_catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else if (Info.Estado == "I")
                    MessageBox.Show("El catálogo # : " + Info.IdCatalogo + " ya fue anulado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    frmFa_Catalogo_Mant frm = new frmFa_Catalogo_Mant((int)lstbox_TipoCatalogo.SelectedValue);
                    frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.setInfo = Info;
                    frm.event_frmFA_Catalogo_Mant_FormClosing += frm_event_frmFA_Catalogo_Mant_FormClosing;
                    frm.Text = frm.Text + " ***ANULAR REGISTRO***";
                    frm.Show();
                }
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                fa_catalogo_Info Info = (fa_catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    frmFa_Catalogo_Mant frm = new frmFa_Catalogo_Mant((int)lstbox_TipoCatalogo.SelectedValue);
                    frm.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.setInfo = Info;
                    frm.event_frmFA_Catalogo_Mant_FormClosing += frm_event_frmFA_Catalogo_Mant_FormClosing;
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                    frm.Show();
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
                fa_catalogo_Info Info = (fa_catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.Estado == "I")
                    MessageBox.Show("No se pueden modificar registros inactivos ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmFa_Catalogo_Mant frm = new frmFa_Catalogo_Mant((int)lstbox_TipoCatalogo.SelectedValue);
                    frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.setInfo = Info;
                    frm.event_frmFA_Catalogo_Mant_FormClosing += frm_event_frmFA_Catalogo_Mant_FormClosing;
                    frm.Text = frm.Text + " ***ACTUALIZAR REGISTRO***";
                    frm.Show();
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
                frmFa_Catalogo_Mant frm = new frmFa_Catalogo_Mant((int)lstbox_TipoCatalogo.SelectedValue);
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.event_frmFA_Catalogo_Mant_FormClosing += frm_event_frmFA_Catalogo_Mant_FormClosing;
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmFA_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
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

        void cargaLista()
        {

            try
            {
                CatalogoTipoInfo = CatalogoTipoBus.Get_List_catalogo_tip();
                CatalogoTipoInfo.ForEach(var => var.Descripcion = "[" + var.IdCatalogo_tipo + "] - " + var.Descripcion);
                lstbox_TipoCatalogo.DataSource = CatalogoTipoInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        void frmCataTipoMant_event_frmFA_CatalogoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
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


        private void lstbox_TipoCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CatalogoInfo = new BindingList<fa_catalogo_Info>(CatalogoBus.Get_List_catalogo(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue)));
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
                var data = gridViewCatalogo.GetRow(e.RowHandle) as fa_catalogo_Info;
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

        frmFa_CatalogoTipo_Mant frmCataTipoMant = new frmFa_CatalogoTipo_Mant();

       

        private void btnNuevo_c_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                frmCataTipoMant = new frmFa_CatalogoTipo_Mant();
                frmCataTipoMant.setAccion(Cl_Enumeradores.eTipo_action.grabar);           
                frmCataTipoMant.event_frmFA_CatalogoTipo_Mant_FormClosing += frmCataTipoMant_event_frmFA_CatalogoTipo_Mant_FormClosing;
                frmCataTipoMant.Text = frmCataTipoMant.Text + " ***NUEVO REGISTRO***";                                                                                                                                                    
                frmCataTipoMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_c_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                int cod = (int)this.lstbox_TipoCatalogo.SelectedValue;
                fa_catalogo_tipo_Info Info = (fa_catalogo_tipo_Info)CatalogoTipoBus.Get_Info_catalogo_tipo(cod);

                if (Info == null)
                    MessageBox.Show("No existe el tipo de catálogo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmCataTipoMant = new frmFa_CatalogoTipo_Mant();
                    frmCataTipoMant.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frmCataTipoMant._SetInfo = Info;                 
                    frmCataTipoMant.event_frmFA_CatalogoTipo_Mant_FormClosing += frmCataTipoMant_event_frmFA_CatalogoTipo_Mant_FormClosing;
                    frmCataTipoMant.Text = frmCataTipoMant.Text + " ***ACTUALIZAR REGISTRO***";
                    frmCataTipoMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmFa_Catalogo_Load(object sender, EventArgs e)
        {

        }


    }
}
