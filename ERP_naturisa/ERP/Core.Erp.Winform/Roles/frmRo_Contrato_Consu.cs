using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Roles;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Contrato_Consulta : Form
    {
        #region
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ro_contrato_bus OCBus = new ro_contrato_bus();
        ro_contrato_Info Info = new ro_contrato_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_contrato_Info> listCon = new List<ro_contrato_Info>();
        frmRo_Contrato_Mant frm ;

        
        #endregion

        public frmRo_Contrato_Consulta()
        {
            try
            {
                  InitializeComponent();
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
                this.Close();
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
                frm = new frmRo_Contrato_Mant();
                frm.Event_frmRo_Contrato_Mant_FormClosing += new frmRo_Contrato_Mant.delegate_frmRo_Contrato_Mant_FormClosing(frm_Event_frmRo_Contrato_Mant_FormClosing);
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);            
                frm.ShowDialog();
                load_datos();
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
                if (Info == null)
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }    
                    else
                    {


                        if (Info.Estado == "I")
                        {
                            MessageBox.Show("No se Puede Modificar un Registro Anulado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            frm = new frmRo_Contrato_Mant();
                            frm.Event_frmRo_Contrato_Mant_FormClosing += new frmRo_Contrato_Mant.delegate_frmRo_Contrato_Mant_FormClosing(frm_Event_frmRo_Contrato_Mant_FormClosing);
                            frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                            frm.set_Info(Info);
                            frm.ShowDialog();
                        }
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
                if (Info == null)
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    frm = new frmRo_Contrato_Mant();
                    frm.Event_frmRo_Contrato_Mant_FormClosing += new frmRo_Contrato_Mant.delegate_frmRo_Contrato_Mant_FormClosing(frm_Event_frmRo_Contrato_Mant_FormClosing);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.set_Info(Info);
                    frm.ShowDialog();
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
                frm = new frmRo_Contrato_Mant();
                frm.Event_frmRo_Contrato_Mant_FormClosing += new frmRo_Contrato_Mant.delegate_frmRo_Contrato_Mant_FormClosing(frm_Event_frmRo_Contrato_Mant_FormClosing);
                //   if (Info_Contrato.IdContrato == 0)
                if (Info == null)
                {
                    MessageBox.Show("Selecciones un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (Info.Estado == "I")
                {
                    MessageBox.Show("No se procedió con la anulación porque ya está anulado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (MessageBox.Show("¿Está seguro que desea anular dicho contrato?", "Anulación de Contrato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Motivo por Anulación
                    string motiAnulacion = "";
                    FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                    fr.ShowDialog();
                    motiAnulacion = fr.motivoAnulacion;
                    Info.MotiAnula = motiAnulacion;
                    // Anulación
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.InfoContrato = Info;
                    if (OCBus.Anular(Info))
                        MessageBox.Show("Contrato anulado exitosamente", "Operación Exitosa");
                    else
                        MessageBox.Show("Error al anular el contrato", "Operación Fallida");
                    frm.MdiParent = this.MdiParent;
                    load_datos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frm_Event_frmRo_Contrato_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               load_datos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_Contrato_Consu_Load(object sender, EventArgs e)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void load_datos()
        {
            try
            {
                this.grdLista.DataSource = OCBus.ConsultaGeneral(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private ro_contrato_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {

            try
            {
                return (ro_contrato_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
                return new ro_contrato_Info();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView.GetRow(e.RowHandle) as ro_contrato_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                 Info = (ro_contrato_Info)gridView.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void preparar_formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmRo_Contrato_Mant();
                if (Accion == Cl_Enumeradores.eTipo_action.actualizar || Accion == Cl_Enumeradores.eTipo_action.consultar || Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (Info.IdEmpresa == 0 & Info.IdContrato == 0)
                    {
                        MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    frm.set_Info(Info);
                }
                if (Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (Info.Estado == "I")
                    {
                        MessageBox.Show("El contrato ya fue anulado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;

                    }
                    frm.set_Info(Info);
                }
                frm.set_Accion(Accion);
                frm.MdiParent = this.MdiParent;
                frm.Event_frmRo_Contrato_Mant_FormClosing+=frm_Event_frmRo_Contrato_Mant_FormClosing;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmdGenerarFiniquito_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmRo_ActaFiniquito oFrmRo_ActaFiniquito = new frmRo_ActaFiniquito();
            oFrmRo_ActaFiniquito.ShowDialog();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

      

    }
}
