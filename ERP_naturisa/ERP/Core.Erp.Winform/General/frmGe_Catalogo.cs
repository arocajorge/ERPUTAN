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
    public partial class FrmGe_Catalogo : Form
    {
        public FrmGe_Catalogo()
        {
            try
            {
                  InitializeComponent();
                    listBoxTipo.DataSource = BusCat.ObtenerList_Tipo();
                    ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new FrmGe_CatalogoTipo_man(Convert.ToInt32(listBoxTipo.SelectedValue));
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new FrmGe_CatalogoTipo_man(Convert.ToInt32(listBoxTipo.SelectedValue));
                ofrm.Event_frmGe_CatalogoTipo_man_FormClosing += ofrm_Event_frmGe_CatalogoTipo_man_FormClosing;
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                ofrm.SetInfo = gridViewcatalogoTipo.GetFocusedRow() as tb_Catalogo_Info;
                ofrm.Show();
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
                ofrm = new FrmGe_CatalogoTipo_man(Convert.ToInt32(listBoxTipo.SelectedValue));
                ofrm.Event_frmGe_CatalogoTipo_man_FormClosing += ofrm_Event_frmGe_CatalogoTipo_man_FormClosing;
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.consultar);
                ofrm.SetInfo = gridViewcatalogoTipo.GetFocusedRow() as tb_Catalogo_Info;
                ofrm.Show();
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
                ofrm = new FrmGe_CatalogoTipo_man(Convert.ToInt32(listBoxTipo.SelectedValue));
                ofrm.Event_frmGe_CatalogoTipo_man_FormClosing += ofrm_Event_frmGe_CatalogoTipo_man_FormClosing;
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.Anular);
                ofrm.SetInfo = gridViewcatalogoTipo.GetFocusedRow() as tb_Catalogo_Info;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        FrmGe_CatalogoTipo_man ofrm = new FrmGe_CatalogoTipo_man();
        tb_CatalogoTipo_Bus BusCat = new tb_CatalogoTipo_Bus();
        tb_Catalogo_Bus BUSCAT_TIPO = new tb_Catalogo_Bus();
        void CargarGrid() 
        {
            try
            {
                gridControl1.DataSource = BUSCAT_TIPO.Get_CatalogoPorTipo(Convert.ToInt32(listBoxTipo.SelectedValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }          
        }


        private void listBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
             
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        void ofrm_Event_frmGe_CatalogoTipo_man_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        
        }

      
        FrmGe_CatalogoMant ofrmCatalogo = new FrmGe_CatalogoMant();

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ofrmCatalogo = new FrmGe_CatalogoMant();
                ofrmCatalogo.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                ofrmCatalogo.Event_frmGE_CatalogoMant_FormClosing += ofrmCatalogo_Event_frmGE_CatalogoMant_FormClosing;
                ofrmCatalogo.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
           
        }

        void ofrmCatalogo_Event_frmGE_CatalogoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 listBoxTipo.DataSource = BusCat.ObtenerList_Tipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
           
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ofrmCatalogo = new FrmGe_CatalogoMant();
                ofrmCatalogo.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                ofrmCatalogo.Event_frmGE_CatalogoMant_FormClosing += ofrmCatalogo_Event_frmGE_CatalogoMant_FormClosing;
                ofrmCatalogo.SetInfo = listBoxTipo.SelectedItem as tb_CatalogoTipo_Info;
                ofrmCatalogo.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                 ofrmCatalogo = new FrmGe_CatalogoMant();
                ofrmCatalogo.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                ofrmCatalogo.Event_frmGE_CatalogoMant_FormClosing += ofrmCatalogo_Event_frmGE_CatalogoMant_FormClosing;
                ofrmCatalogo.SetInfo = listBoxTipo.SelectedItem as tb_CatalogoTipo_Info;
                ofrmCatalogo.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
           
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ofrmCatalogo = new FrmGe_CatalogoMant();
                ofrmCatalogo.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                ofrmCatalogo.Event_frmGE_CatalogoMant_FormClosing += ofrmCatalogo_Event_frmGE_CatalogoMant_FormClosing;
                ofrmCatalogo.SetInfo = listBoxTipo.SelectedItem as tb_CatalogoTipo_Info;
                ofrmCatalogo.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
           
        }
    }
}
