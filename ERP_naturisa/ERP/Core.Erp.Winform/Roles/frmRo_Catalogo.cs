using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;


namespace Core.Erp.Winform.Roles
{

    public partial class frmRo_Catalogo : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_CatalogoTipo_Bus _CatTipo_B = new ro_CatalogoTipo_Bus();
        ro_Catalogo_Bus Bus = new ro_Catalogo_Bus();
        ro_CatalogoTipo_Info infoTipo = new ro_CatalogoTipo_Info();
        ro_Catalogo_Info InfoCatalogo = new ro_Catalogo_Info();
        ro_Catalogo_Info Info = new ro_Catalogo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        int IdEmpresa;
        #endregion

        public frmRo_Catalogo()
        {
            try
            {
                InitializeComponent();
                var CataTipo = _CatTipo_B.ConsultaGeneral(IdEmpresa);
                CataTipo.ForEach(var => var.tc_Descripcion = "[" + var.Codigo + "] - " + var.tc_Descripcion);
                lstbox_TipoCatalogo.DataSource = CataTipo;
                gridControlCatalogo.DataSource = Bus.Get_List_Catalogo_x_Tipo(CataTipo.First().IdTipoCatalogo);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmRo_Catalogo_Mant ofrm = new frmRo_Catalogo_Mant(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));
                ofrm.Event_frmRo_Catalogo_Mant_FormClosing += new frmRo_Catalogo_Mant.delegate_frmRo_Catalogo_Mant_FormClosing(ofrm_Event_frmRo_Catalogo_Mant_FormClosing);                             
                ofrm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                // ofrm.MdiParent = this.MdiParent;
                ofrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
                var Info1 = (ro_Catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  
                else
                {
                    frmRo_Catalogo_Mant ofrm = new frmRo_Catalogo_Mant(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));
                    ofrm.Event_frmRo_Catalogo_Mant_FormClosing += new frmRo_Catalogo_Mant.delegate_frmRo_Catalogo_Mant_FormClosing(ofrm_Event_frmRo_Catalogo_Mant_FormClosing);
                    ofrm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    ofrm._SetInfo = Info;
                  //  ofrm.MdiParent = this.MdiParent;
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info1 = (ro_Catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {

                    frmRo_Catalogo_Mant ofrm = new frmRo_Catalogo_Mant(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));
                    ofrm.Event_frmRo_Catalogo_Mant_FormClosing += new frmRo_Catalogo_Mant.delegate_frmRo_Catalogo_Mant_FormClosing(ofrm_Event_frmRo_Catalogo_Mant_FormClosing);
                    ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.consultar);
                    ofrm._SetInfo = Info;             
                    //ofrm.MdiParent = this.MdiParent;
                    ofrm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                var Info1 = (ro_Catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show("Debe seleccionar una fila, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                else if (Info1.ca_estado == "I")
                    MessageBox.Show("El Catálogo No. " + Info1.CodCatalogo + ". \r ya ha sido Anulado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                else if (MessageBox.Show("¿Está seguro que desea anular Catálogo...?", "ANULACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Motivo por Anulación
                    frmRo_Catalogo_Mant ofrm = new frmRo_Catalogo_Mant(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));
                    ofrm.Event_frmRo_Catalogo_Mant_FormClosing += new frmRo_Catalogo_Mant.delegate_frmRo_Catalogo_Mant_FormClosing(ofrm_Event_frmRo_Catalogo_Mant_FormClosing);
                    string motiAnulacion = "";
                    FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                    fr.ShowDialog();
                    motiAnulacion = fr.motivoAnulacion;
                    Info.MotiAnula = motiAnulacion;
                    // Anulación
                    
                    ofrm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    ofrm.Info = Info;

                    if (Bus.AnularDB(Info))
                    {
                        MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridControlCatalogo.DataSource = Bus.Get_List_Catalogo_x_Tipo(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));
                    }
                    else
                        MessageBox.Show("Imposible anular el Catálogo, revise porf avor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                   // ofrm.MdiParent = this.MdiParent;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewTipo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                 //gridControlCatalogo.DataSource = _Cata_B.ObtenerCatalogoTipo(Convert.ToInt32(gridViewTipo.GetFocusedRowCellValue(colIdTipoCatalogo)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void lstbox_TipoCatalogo_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    Point p = new Point(e.X, e.Y);
                    if (infoTipo != null)
                    {
                        menuTipo.Show(lstbox_TipoCatalogo, p);
                    }
                }
                else
                {

                    gridControlCatalogo.DataSource = Bus.Get_List_Catalogo_x_Tipo(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        private void lstbox_TipoCatalogo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                infoTipo = (ro_CatalogoTipo_Info)lstbox_TipoCatalogo.SelectedItem;
                gridViewCatalogo.SelectRows(0, 1); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }
        
        private void gridViewCatalogo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ofrm_Event_frmRo_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gridControlCatalogo.DataSource = Bus.Get_List_Catalogo_x_Tipo(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void frmRo_Catalogo_Load(object sender, EventArgs e)
        {
            try
            {
                //lstbox_TipoCatalogo.SelectedIndex = 0;
                lstbox_TipoCatalogo_SelectedValueChanged(new Object(), new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_CatalogoTipoMant ofrm = new frmRo_CatalogoTipoMant();
                ofrm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                ofrm.Event_frmRo_CatalogoTipoMant_FormClosing += new frmRo_CatalogoTipoMant.delegate_frmRo_CatalogoTipoMant_FormClosing(ofrm_Event_frmRo_CatalogoTipoMant_FormClosing);
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void ofrm_Event_frmRo_CatalogoTipoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                lstbox_TipoCatalogo.DataSource = Bus.Get_List_Catalogo(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_CatalogoTipoMant ofrm = new frmRo_CatalogoTipoMant();
                ofrm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                ofrm.Event_frmRo_CatalogoTipoMant_FormClosing += new frmRo_CatalogoTipoMant.delegate_frmRo_CatalogoTipoMant_FormClosing(ofrm_Event_frmRo_CatalogoTipoMant_FormClosing);
                ofrm._SetInfo = infoTipo;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void gridViewCatalogo_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Info = (ro_Catalogo_Info)gridViewCatalogo.GetFocusedRow();
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void gridViewCatalogo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCatalogo.GetRow(e.RowHandle) as ro_Catalogo_Info;
                if (data == null)
                    return;
                if (data.ca_estado == "I")
                    e.Appearance.ForeColor = Color.Red;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void lstbox_TipoCatalogo_SelectedIndexChanged(object sender, EventArgs e){}

    }
}
