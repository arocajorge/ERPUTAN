using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;



namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_EstadoCobro : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cxc_EstadoCobro_Bus estBus = new cxc_EstadoCobro_Bus();
        cxc_EstadoCobro_Info Info = new cxc_EstadoCobro_Info();

        public frmCxc_EstadoCobro()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString() , "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Get();
                frmCxc_EstadoCobro_Mantenimiento frmCxcEstado = new frmCxc_EstadoCobro_Mantenimiento();
                frmCxcEstado._Accion = Cl_Enumeradores.eTipo_action.actualizar;
                frmCxcEstado.setInfo(Info);
                frmCxcEstado.Event_FrmGe_Tarjeta_Mantenimiento_FormClosing += new frmCxc_EstadoCobro_Mantenimiento.delegate_FrmGe_Tarjeta_Mantenimiento_FormClosing(frmCxcEstadoC_Event_FrmGe_Tarjeta_Mantenimiento_FormClosing);
                frmCxcEstado.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Get();
                frmCxc_EstadoCobro_Mantenimiento frmCxcEstado = new frmCxc_EstadoCobro_Mantenimiento();
                frmCxcEstado._Accion = Cl_Enumeradores.eTipo_action.consultar;
                frmCxcEstado.setInfo(Info);
                frmCxcEstado.Event_FrmGe_Tarjeta_Mantenimiento_FormClosing += new frmCxc_EstadoCobro_Mantenimiento.delegate_FrmGe_Tarjeta_Mantenimiento_FormClosing(frmCxcEstadoC_Event_FrmGe_Tarjeta_Mantenimiento_FormClosing);
                frmCxcEstado.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCxc_EstadoCobro_Mantenimiento frmCxcEstado = new frmCxc_EstadoCobro_Mantenimiento();
                frmCxcEstado._Accion = Cl_Enumeradores.eTipo_action.grabar;
                frmCxcEstado.Event_FrmGe_Tarjeta_Mantenimiento_FormClosing += new frmCxc_EstadoCobro_Mantenimiento.delegate_FrmGe_Tarjeta_Mantenimiento_FormClosing(frmCxcEstadoC_Event_FrmGe_Tarjeta_Mantenimiento_FormClosing);
                frmCxcEstado.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void frmCxcEstadoC_Event_FrmGe_Tarjeta_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmCxc_EstadoCobro_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ActualizarGrid()
        {
            try
            {
                gridControlEstadoCobro.DataSource = estBus.Get_List_EstadoCobro();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        void Get()
        {
            try
            {
                var _Info = (cxc_EstadoCobro_Info)gridViewEstadoCobro.GetFocusedRow();
                Info.IdEstadoCobro = _Info.IdEstadoCobro;
                Info.Descripcion = _Info.Descripcion;
                Info.posicion = _Info.posicion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show("Error \n" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

       }
}
