using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Roles
{
    public partial class FrmRo_Solicitud_Tarjetas_Rol_Electronico_Cons : Form
    {
        #region Variables

        FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant frm;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Archivo_Transferencia_Bus BusArchivo = new ba_Archivo_Transferencia_Bus();
        List<ba_Archivo_Transferencia_Info> Lista = new List<ba_Archivo_Transferencia_Info>();
        ba_Archivo_Transferencia_Info Archivo = new ba_Archivo_Transferencia_Info();

        #endregion

        public FrmRo_Solicitud_Tarjetas_Rol_Electronico_Cons()
        {
            InitializeComponent();
        }

        void frm_event_FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void Cargar_Datos()
        {
            try
            {
                Lista = new List<ba_Archivo_Transferencia_Info>();
                Lista = BusArchivo.Get_List_Archivo_transferencia(1, 4, "NCR", "RRHH");
                gridControlSolicitud.DataSource = Lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmRo_Solicitud_Tarjetas_Rol_Electronico_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridControlSolicitud.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Archivo = (ba_Archivo_Transferencia_Info)gridViewSolicitud.GetFocusedRow();
                if (Archivo == null)
                {
                    MessageBox.Show("Para poder continuar por favor seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {

                frm = new FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant();
                frm.MdiParent = this.MdiParent;
                frm.event_FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_FormClosing+=frm_event_FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.Set_Archivo(Archivo);

                }
                frm.set_Accion(Accion);
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Archivo = (ba_Archivo_Transferencia_Info)gridViewSolicitud.GetFocusedRow();
                if (Archivo == null)
                {
                    MessageBox.Show("Para poder continuar por favor seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Archivo = (ba_Archivo_Transferencia_Info)gridViewSolicitud.GetFocusedRow();
                if (Archivo == null)
                {
                    MessageBox.Show("Para poder continuar por favor seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
