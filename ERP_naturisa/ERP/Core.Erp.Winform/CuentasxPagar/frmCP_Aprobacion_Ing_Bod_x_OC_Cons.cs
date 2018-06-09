using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Aprobacion_Ing_Bod_x_OC_Cons : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        cp_Aprobacion_Ing_Bod_x_OC_Info Info = new cp_Aprobacion_Ing_Bod_x_OC_Info();
        #endregion
       
        public frmCP_Aprobacion_Ing_Bod_x_OC_Cons()
        {
            InitializeComponent();

            ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick;       
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click;
                 
        }

        private void cargagrid()
        {
            try
            {
                List<cp_Aprobacion_Ing_Bod_x_OC_Info> lista = new List<cp_Aprobacion_Ing_Bod_x_OC_Info>();
                cp_Aprobacion_Ing_Bod_x_OC_Bus Bus = new cp_Aprobacion_Ing_Bod_x_OC_Bus();
                lista = Bus.Get_List_Aprobacion_Ing_Bod_x_OC(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta).OrderByDescending(q=>q.IdAprobacion).ToList();
                gridControlConsulta.DataSource = lista;
                      
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlConsulta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.consultar);            
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preparar_formulario(Cl_Enumeradores.eTipo_action _Accion)
        {         
            try
            {
                frmCP_Aprobacion_Ing_Bod_x_OC_Mant frm = new frmCP_Aprobacion_Ing_Bod_x_OC_Mant();
                Info = (cp_Aprobacion_Ing_Bod_x_OC_Info)gridViewConsulta.GetFocusedRow();

                if (_Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    if (Info != null)
                    {
                        frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un Registro a Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (Info != null)
                    {
                        frm.Text = frm.Text + "***ELIMINAR REGISTRO***";
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un Registro a Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                }

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:                     
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        frm._SetInfo=Info;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        frm._SetInfo = Info;
                        break;
                }
                       
                frm.set_Accion(_Accion);
                frm.MdiParent = this.MdiParent;
                frm.event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing += frm_event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing;
                frm.Show();
                                                      
            }
            catch (Exception ex)
            {                
                 Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        void frm_event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Aprobacion_Ing_Bod_x_OC_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                 cargagrid();
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
