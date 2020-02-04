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

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_transportista_Consulta : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        FrmGe_transportista_Mant frm = new FrmGe_transportista_Mant();

        tb_persona_bus personaBus = new tb_persona_bus();
        List<tb_persona_Info> listaPers;
        tb_transportista_Bus transBus = new tb_transportista_Bus();
        tb_transportista_Info infoTrans = new tb_transportista_Info();
        List<tb_transportista_Info> listaTrans;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        public FrmGe_transportista_Consulta()
        {
            try
            {
                 InitializeComponent();
                 ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                 ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                 ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                 ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
                 ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_event_btnImprimir_ItemClick;
                 ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
                 
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
                infoTrans = (tb_transportista_Info)gridViewTransportista.GetFocusedRow();
                if (infoTrans != null)
                {
                    if (infoTrans.Estado == "I")
                    {
                        MessageBox.Show("El registro ya fue Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                    else
                    {
                        frm = new FrmGe_transportista_Mant(Cl_Enumeradores.eTipo_action.Anular);
                        frm.Text = frm.Text + "***ANULAR REGISTRO***";
                        frm.SetInfo = infoTrans;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_FrmGe_transportista_Mant_FormClosing += frm_event_FrmGe_transportista_Mant_FormClosing;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewTransportista.ShowPrintPreview();
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
                infoTrans = (tb_transportista_Info)gridViewTransportista.GetFocusedRow();
                if (infoTrans != null)
                {

                    frm = new FrmGe_transportista_Mant(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm.SetInfo = infoTrans;
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_FrmGe_transportista_Mant_FormClosing += frm_event_FrmGe_transportista_Mant_FormClosing;

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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new FrmGe_transportista_Mant(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_FrmGe_transportista_Mant_FormClosing += frm_event_FrmGe_transportista_Mant_FormClosing;
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
                infoTrans = (tb_transportista_Info)gridViewTransportista.GetFocusedRow();
                if (infoTrans != null)
                {
                    
                        frm = new FrmGe_transportista_Mant(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.Text = frm.Text + "***ACTUALIZAR REGISTRO***";
                        frm.SetInfo = infoTrans;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_FrmGe_transportista_Mant_FormClosing += frm_event_FrmGe_transportista_Mant_FormClosing;
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmGe_transportista_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                loadGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGE_transportista_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                loadGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadGrid() {
            try
            {
                listaTrans = new List<tb_transportista_Info>();
                listaPers = new List<tb_persona_Info>();
                listaTrans = transBus.Get_List_transportista(param.IdEmpresa);
                listaPers = personaBus.Get_List_Persona();
                foreach (var item in listaPers)
                {
                    foreach (var item2 in listaTrans)
                    {
                        if (item.IdPersona == item2.IdPersona)
                        {
                            item2.Nombre = item.pe_nombreCompleto;
                            item2.Cedula = item.pe_cedulaRuc;
                        }
                    }
                }
                gridTransportista.DataSource = listaTrans;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewTransportista_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                infoTrans = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private tb_transportista_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (tb_transportista_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new tb_transportista_Info();
            }
        }
        private void gridViewTransportista_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewTransportista.GetRow(e.RowHandle) as tb_transportista_Info;
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

    }
}
