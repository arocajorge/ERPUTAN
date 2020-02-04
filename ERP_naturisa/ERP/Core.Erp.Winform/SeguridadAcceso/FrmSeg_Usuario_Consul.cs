using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.SeguridadAcceso
{
    public partial class FrmSeg_Usuario_Consul : Form
    {

        #region "Variables y Propiedades"
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        List<seg_usuario_info> ListInfo_usuarios = new List<seg_usuario_info>();
        seg_usuario_bus bus = new seg_usuario_bus();
        seg_usuario_info info = new seg_usuario_info();
        FrmSeg_Usuario_Mant frm;

        string MensajeError = "";
        #endregion

        #region "Constructor"
        public FrmSeg_Usuario_Consul()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region " Eventos "
        void uC_Menu_Consultas1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void uC_Menu_Consultas1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (seg_usuario_info)gridViewUsuario.GetFocusedRow();
                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) + " Usuario " + info.IdUsuario + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {               
                    if (info.estado != "I")
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();                        

                        info.IdUsuarioUltAnu = param.IdUsuario;
                        info.MotivoAnulacion = fr.motivoAnulacion;
                        info.Fecha_UltAnu = DateTime.Now;
                        new seg_usuario_bus().Anular(info, ref MensajeError);
                        if (MensajeError != "")
                            MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " el usuario " + info.IdUsuario, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        this.gridControlUsuario.DataSource = bus.Get_List_Usuario(ref MensajeError);
                    }
                    else
                    {
                        MessageBox.Show("El Usuario " + info.IdUsuario + " " +param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        void uC_Menu_Consultas1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Visualizar(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void uC_Menu_Consultas1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Visualizar(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void uC_Menu_Consultas1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Visualizar(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void frm_event_FrmSeg_Usuario_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            cargar_grid();
        }

        private void uC_Menu_Consultas1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void uC_Menu_Consultas1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlUsuario.ShowPrintPreview();
        }

        private void gridViewUsuario_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewUsuario.GetRow(e.RowHandle) as seg_usuario_info;
                if (data == null)
                    return;
                if (data.estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion 
        
        #region " Llamar Formulario "
        private void Visualizar(Cl_Enumeradores.eTipo_action miAccion)
        {
            try
            {

                info = (seg_usuario_info)gridViewUsuario.GetFocusedRow();

                frm = new FrmSeg_Usuario_Mant();
                frm.MdiParent = this.MdiParent;

                frm.set_Info(info);
                frm.set_accion(miAccion);
                frm.event_FrmSeg_Usuario_Mant_FormClosing += frm_event_FrmSeg_Usuario_Mant_FormClosing;
                frm.Show();   
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Load"
        private void FrmSeg_Usuario_Consul_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region " Cargar Combo"
        private void cargar_grid()
        {
            try
            {
                string MensajeError = "";
                ListInfo_usuarios=bus.Get_List_Usuario(ref MensajeError);
                this.gridControlUsuario.DataSource = ListInfo_usuarios;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        #endregion

    }
}
