using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;


using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Conciliacion_Caja_Consulta : Form
    {
        #region Declaración de Variables
         tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_conciliacion_caja_Bus conciCaj_B = new cp_conciliacion_caja_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_conciliacion_caja_Bus ConciCaj_B = new cp_conciliacion_caja_Bus();
        cp_conciliacion_caja_Info Info = new cp_conciliacion_caja_Info();
        frmCP_Conciliacion_Caja frm = new frmCP_Conciliacion_Caja();
        int RowHandle = 0;
        #endregion

        public frmCP_Conciliacion_Caja_Consulta()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cp_conciliacion_caja_Info Info = (cp_conciliacion_caja_Info)gridView_ConciCaja.GetFocusedRow();

                if (Info != null)
                {
                    if (Info.IdEstadoCierre == "EST_CIE_CER")
                    {

                        MessageBox.Show("La Conciliación de Caja #: " +Info.IdConciliacion_Caja +" está CERRADA con la Orden de Pago #: " +Info.IdOrdenPago_op  + ". No se puede Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);                        
                    }

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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                loadData();
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
                gridControl_ConciCaja.ShowPrintPreview();
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
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadData()
        {
            try
            {
                gridControl_ConciCaja.DataSource = conciCaj_B.Get_List_Conciliacion_Caja(param.IdEmpresa
                    , Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_desde)
                    , Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta));
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCP_Conciliacion_Caja_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                    loadData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void frm_event_frmCP_Conciliacion_Caja_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                loadData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action iAccion)
        {

            try
            {

                string mensajeFrm = "";

                Info = new cp_conciliacion_caja_Info();

                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        mensajeFrm = "REGISTRO NUEVO";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        mensajeFrm = "MODIFICAR REGISTRO";
                        Info = (cp_conciliacion_caja_Info)gridView_ConciCaja.GetFocusedRow();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        mensajeFrm = "ANULAR REGISTRO";
                        Info = (cp_conciliacion_caja_Info)gridView_ConciCaja.GetFocusedRow();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        mensajeFrm = "CONSULTAR REGISTRO";
                        Info = (cp_conciliacion_caja_Info)gridView_ConciCaja.GetFocusedRow();
                        break;
                    default:
                        break;
                }


                if (Info != null)
                {
                    frm = new frmCP_Conciliacion_Caja();
                    frm.Text = frm.Text + "***" + mensajeFrm + "***";
                    frm.set_Accion(iAccion);
                    frm.set_Info_ConciliacionCaja(Info);
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_frmCP_Conciliacion_Caja_FormClosing+=frm_event_frmCP_Conciliacion_Caja_FormClosing;

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }




            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_ConciCaja_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                cp_conciliacion_caja_Info row = (cp_conciliacion_caja_Info)gridView_ConciCaja.GetRow(e.RowHandle);
                if (row != null)
                {
                    if (row.IdEstadoCierre == "EST_CIE_CER" && row.IdOrdenPago_op != null)
                    {
                        e.Appearance.ForeColor = Color.Blue;
                        return;
                    }
                    if (row.IdEstadoCierre == "EST_CIE_CER")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_ConciCaja_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
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

        private void cmb_ingreso_img_Click(object sender, EventArgs e)
        {
            try
            {
                Info = (cp_conciliacion_caja_Info)gridView_ConciCaja.GetRow(RowHandle);
                string mensaje = "";
                if (Info != null)
                {                   
                    if (Info.IdCbteCble_mov_caj == null)
                    {
                        if (MessageBox.Show("¿Está seguro que desea realizar el ingreso por reposición de caja de la conciliación # " + Info.IdConciliacion_Caja.ToString() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (ConciCaj_B.Crear_ingreso_x_reposicion(Info, ref mensaje))
                            {
                                MessageBox.Show("Ingreso por reposición de caja para conciliación # "+Info.IdConciliacion_Caja.ToString()+" creado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                                MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_ConciCaja_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
