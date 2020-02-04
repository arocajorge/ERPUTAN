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
using Core.Erp.Business.Caja;
using Core.Erp.Info.Caja;
using Core.Erp.Winform.General ;


namespace Core.Erp.Winform.Caja
{
    public partial class FrmCa_caj_Caja_MoviTipoConsulta : Form
    {
        #region Declaración de Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        caj_Caja_Movimiento_Tipo_Info moviTipo_I = new caj_Caja_Movimiento_Tipo_Info();
        caj_Caja_Movimiento_Tipo_Bus moviTipo_B = new caj_Caja_Movimiento_Tipo_Bus();
        string motiAnulacion = "";
        FrmCa_caj_Caja_Movimiento_Tipo frm = new FrmCa_caj_Caja_Movimiento_Tipo();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        string MensajeError = "";
        #endregion
        
        public FrmCa_caj_Caja_MoviTipoConsulta()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
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
                if (moviTipo_I == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (moviTipo_I.Estado != "I")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el Tipo Movimiento de caja #: " + moviTipo_I.IdTipoMovi + " ?", "Anulación de Tipo Movimiento de caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                            fr.ShowDialog();
                            motiAnulacion = fr.motivoAnulacion;

                            moviTipo_I.MotivoAnulacion = motiAnulacion;
                            moviTipo_I.IdUsuarioUltAnu = param.IdUsuario;
                            moviTipo_I.Fecha_UltAnu = param.Fecha_Transac;
                            if (moviTipo_B.AnularDB(moviTipo_I, ref  MensajeError))
                            {
                                MessageBox.Show("Tipo Movimiento de caja #: " + moviTipo_I.IdTipoMovi + " Anulada correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_data();
                            }
                            else
                                MessageBox.Show("No se puedo Anular el Tipo Movimiento de caja #: " + moviTipo_I.IdTipoMovi, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Esta Caja ya esta Anulada...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                this.gridControl_CajaMoviTipo.ShowPrintPreview();
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
                if (moviTipo_I == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PrepararForm(Cl_Enumeradores.eTipo_action.consultar, moviTipo_I);
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
                if (moviTipo_I == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PrepararForm(Cl_Enumeradores.eTipo_action.actualizar, moviTipo_I);
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

                PrepararForm(Cl_Enumeradores.eTipo_action.grabar, moviTipo_I);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_data()
        {
            try
            {
                this.gridControl_CajaMoviTipo.DataSource = moviTipo_B.Get_list_Caja_Movimiento_Tipo(param.IdEmpresa, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrepararForm(Cl_Enumeradores.eTipo_action Accion, caj_Caja_Movimiento_Tipo_Info cajInfo)
        {
            try
            {
                frm = new FrmCa_caj_Caja_Movimiento_Tipo();
                frm.event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing += new FrmCa_caj_Caja_Movimiento_Tipo.delegate_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing(frm_event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing);
                frm.set_accion(Accion);
                frm.MdiParent = this.MdiParent;
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_TipoMovi(moviTipo_I);
                }
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void frm_event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            load_data();
        }

        private void FrmCa_caj_Caja_MoviTipoConsulta_Load(object sender, EventArgs e)
        {
            try
            {
               load_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UltraGrid_CajaMoviTipo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = UltraGrid_CajaMoviTipo.GetRow(e.RowHandle) as caj_Caja_Movimiento_Tipo_Info;
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

        private caj_Caja_Movimiento_Tipo_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (caj_Caja_Movimiento_Tipo_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new caj_Caja_Movimiento_Tipo_Info();
            }
        }

        private void UltraGrid_CajaMoviTipo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                moviTipo_I = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
