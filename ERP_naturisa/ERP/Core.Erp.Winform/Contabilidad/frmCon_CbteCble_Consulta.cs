using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Bancos;


namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_CbteCble_Consulta : Form
    {
        frmCon_CbteCble_Mant FrmMant = new frmCon_CbteCble_Mant();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        #region Declaración de Variables

        public decimal fila;
       
        
        ct_Cbtecble_Info InfoCbteCble = new ct_Cbtecble_Info();
        ct_Cbtecble_Bus BusCbteCble = new ct_Cbtecble_Bus();
        List<ct_Cbtecble_Info> ListInfoCbteCble = new List<ct_Cbtecble_Info>();

        ba_Conciliacion_det_IngEgr_Bus bus_Conci_bancaria = new ba_Conciliacion_det_IngEgr_Bus();
        #endregion
       
        public frmCon_CbteCble_Consulta()
        {
            InitializeComponent();
            try
            {
                
                
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
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
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ofrm_event_frmCon_CbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_grid();
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
                if (InfoCbteCble != null)
                {
                    InfoCbteCble = (ct_Cbtecble_Info)gridViewCbte.GetFocusedRow();

                    if (bus_Conci_bancaria.Cbte_existe_en_conciliacion(InfoCbteCble.IdEmpresa, InfoCbteCble.IdTipoCbte, InfoCbteCble.IdCbteCble))
                    {
                        MessageBox.Show("Uno de los registros de este comprobante existe en la conciliación del módulo de bancos, Debe tener presente que no podrá modificar el número de registros del comprobante, asi como la cuenta y el valor del registro conciliado.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
                        return;
                    }
                    else
                        llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
                }
                else
                {
                    MessageBox.Show("Selecciones una fila", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                griCbte.ShowRibbonPrintPreview();
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
                
                if (InfoCbteCble != null)
                {
                    llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
                
                }
                else
                {
                    MessageBox.Show("Selecciones una fila", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
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
                load_grid();
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
                
                if (InfoCbteCble != null)
                {
                    llamar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
                }
                else
                {
                    MessageBox.Show("Selecciones una fila", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_grid()
        {
            try
            {
                string MensajeError = "";

                ListInfoCbteCble = BusCbteCble.Get_list_Cbtecble(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta
                    , 1, 999999999999999, "", 0, 999, "", "", ref MensajeError);
                
                griCbte.DataSource = ListInfoCbteCble;
                griCbte.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void frmCon_CbteCble_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                load_grid();
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCbte_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                InfoCbteCble = (ct_Cbtecble_Info)gridViewCbte.GetRow(e.RowHandle);
                if (InfoCbteCble != null)
                {
                    if (InfoCbteCble.Estado == "I")
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                FrmMant = new frmCon_CbteCble_Mant();

                FrmMant.event_frmCon_CbteCble_Mant_FormClosing += FrmMant_event_frmCon_CbteCble_Mant_FormClosing;
                FrmMant.MdiParent = this.MdiParent;
                FrmMant.setAccion(Accion);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    InfoCbteCble = (ct_Cbtecble_Info)gridViewCbte.GetFocusedRow();
                    FrmMant.set_Info(InfoCbteCble);
               }

                FrmMant.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmMant_event_frmCon_CbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            load_grid();
        }

        private void gridViewCbte_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoCbteCble = (ct_Cbtecble_Info)gridViewCbte.GetRow(e.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
