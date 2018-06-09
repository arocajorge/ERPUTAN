using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_Embarcador_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public frmImp_Embarcador_Consulta()
        {
            try
            {
                InitializeComponent();
                ofrm.Event_frmImp_Embarcador_Mant_FormClosing += new frmImp_Embarcador_Mant.Delegate_frmImp_Embarcador_Mant_FormClosing(ofrm_Event_frmImp_Embarcador_Mant_FormClosing);

                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlEmbarcador.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
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
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmImp_Embarcador_Mant();
                ofrm.Event_frmImp_Embarcador_Mant_FormClosing += new frmImp_Embarcador_Mant.Delegate_frmImp_Embarcador_Mant_FormClosing(ofrm_Event_frmImp_Embarcador_Mant_FormClosing);
                ofrm.SetAccion(Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (_Info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (_Info.Estado == "I")
                    MessageBox.Show("No se pueden modificar registros inactivos", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    ofrm = new frmImp_Embarcador_Mant();
                    ofrm.Event_frmImp_Embarcador_Mant_FormClosing += new frmImp_Embarcador_Mant.Delegate_frmImp_Embarcador_Mant_FormClosing(ofrm_Event_frmImp_Embarcador_Mant_FormClosing);
                    ofrm.SetAccion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                    ofrm._InfoSet = _Info;
                    ofrm.MdiParent = this.MdiParent;
                    ofrm.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_Info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    ofrm = new frmImp_Embarcador_Mant();
                    ofrm.Event_frmImp_Embarcador_Mant_FormClosing += new frmImp_Embarcador_Mant.Delegate_frmImp_Embarcador_Mant_FormClosing(ofrm_Event_frmImp_Embarcador_Mant_FormClosing);
                    ofrm.SetAccion(Info.General.Cl_Enumeradores.eTipo_action.consultar);
                    ofrm._InfoSet = _Info;
                    ofrm.MdiParent = this.MdiParent;
                    ofrm.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (_Info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (_Info.Estado == "I")
                    MessageBox.Show("El registro ya fue anulado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {


                    ofrm = new frmImp_Embarcador_Mant();
                    ofrm.Event_frmImp_Embarcador_Mant_FormClosing += new frmImp_Embarcador_Mant.Delegate_frmImp_Embarcador_Mant_FormClosing(ofrm_Event_frmImp_Embarcador_Mant_FormClosing);
                    ofrm.SetAccion(Info.General.Cl_Enumeradores.eTipo_action.Anular);
                    ofrm._InfoSet = _Info;
                    ofrm.MdiParent = this.MdiParent;
                    ofrm.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }



        void ofrm_Event_frmImp_Embarcador_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gridControlEmbarcador.DataSource = Bus.ListaEmbarcadores();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }


        imp_Embarcador_Bus Bus = new imp_Embarcador_Bus();
        frmImp_Embarcador_Mant ofrm = new frmImp_Embarcador_Mant();
       
        private void frmImp_Embarcador_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                gridControlEmbarcador.DataSource = Bus.ListaEmbarcadores();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }


        imp_Embarcador_Info _Info = new imp_Embarcador_Info();
        private void gridViewEmbarcador_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
              _Info = (imp_Embarcador_Info)gridViewEmbarcador.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }



        private void gridViewEmbarcador_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewEmbarcador.GetRow(e.RowHandle) as imp_Embarcador_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
