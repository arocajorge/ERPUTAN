using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Inventario;


namespace Core.Erp.Winform.Inventario
{
    public partial class frmIn_Tipo_Movi_Inven_Consulta : Form
    {
        public frmIn_Tipo_Movi_Inven_Consulta()
        {
            try
            {
                 InitializeComponent();
                frm = new FrmIn_Tipo_Movi_Inven_Mantenimiento();
                frm.Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing += frm_Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridView_tipoMovi_Inven.ShowPrintPreview();
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string mensaje = "";
                moviI = gridView_tipoMovi_Inven.GetFocusedRow() as in_movi_inven_tipo_Info;
               // if (moviI.IdMovi_inven_tipo == 0)
               if (moviI == null)
                {
                    MessageBox.Show("Seleccione un registro", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else if (moviB.Cons_MovimientoInventario(moviI, ref mensaje))
                {
                    MessageBox.Show(mensaje);
                }
                else if (moviI.cm_interno == "S")
                {
                    MessageBox.Show("No se procedió con la Anulación porque es Usado Por El Sistema", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (moviI.Estado == "I")
                {
                    MessageBox.Show("No se procedió con la Anulación porque ya está Anulado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (MessageBox.Show("¿Está seguro que desea anular dicho Movimiento Tipo Inventario ?", "Anulación de Movimiento Tipo Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Core.Erp.Winform.General.FrmGe_MotivoAnulacion omot = new General.FrmGe_MotivoAnulacion();
                    omot.ShowDialog();
                    FrmIn_Tipo_Movi_Inven_Mantenimiento frm = new FrmIn_Tipo_Movi_Inven_Mantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    moviI = gridView_tipoMovi_Inven.GetFocusedRow() as in_movi_inven_tipo_Info;

                    frm.MoviInveI = moviI;
                    moviI.MotiAnula = omot.motivoAnulacion;
                    //  in_movi_inven_tipo_Bus moviB = new in_movi_inven_tipo_Bus();
                    if (moviB.AnularDB(moviI))
                    {
                        MessageBox.Show("Anulado ok", "Operación Exitosa");
                    }
                    else
                    {
                        MessageBox.Show("No se ha Anulado", "Operación Fallida");
                    }
                    cargar_grid();
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
                moviI = gridView_tipoMovi_Inven.GetFocusedRow() as in_movi_inven_tipo_Info;

                if (moviI == null)
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                FrmIn_Tipo_Movi_Inven_Mantenimiento frm = new FrmIn_Tipo_Movi_Inven_Mantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                //moviI = gridView1.GetFocusedRow() as in_movi_inven_tipo_Info;
                frm.set_Info(moviI);
                frm.Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing += frm_Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing;
                frm.MdiParent = this.MdiParent;
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
                moviI = gridView_tipoMovi_Inven.GetFocusedRow() as in_movi_inven_tipo_Info;
                
                if (moviI == null)
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    if (moviI.Estado == "I")
                    {
                        MessageBox.Show("No se pueden modificar registros inactivos", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        FrmIn_Tipo_Movi_Inven_Mantenimiento frm = new FrmIn_Tipo_Movi_Inven_Mantenimiento();
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        //moviI = gridView1.GetFocusedRow() as in_movi_inven_tipo_Info;
                        frm.set_Info(moviI);

                        frm.Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing += frm_Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing;
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }

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
                frm = new FrmIn_Tipo_Movi_Inven_Mantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing += frm_Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
         DataTable dt = new DataTable();
        in_movi_inven_tipo_Bus moviB = new in_movi_inven_tipo_Bus();
        List<in_movi_inven_tipo_Info> listMovi_Inve_Tipo = new List<in_movi_inven_tipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_movi_inven_tipo_Info moviI = new in_movi_inven_tipo_Info();
        FrmIn_Tipo_Movi_Inven_Mantenimiento frm;

        private void FrmIn_Tipo_Movi_Inven_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
               cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void cargar_grid()
        {
            try
            {                
                listMovi_Inve_Tipo = moviB.Get_list_movi_inven_tipo(param.IdEmpresa,"","","");
               gridControl.DataSource = listMovi_Inve_Tipo;
                              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        

        

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_tipoMovi_Inven.GetRow(e.RowHandle) as in_movi_inven_tipo_Info;
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
