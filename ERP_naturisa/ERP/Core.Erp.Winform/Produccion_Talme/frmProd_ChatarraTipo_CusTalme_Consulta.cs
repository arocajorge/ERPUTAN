using Core.Erp.Business.General;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Info.Produccion_Talme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_ChatarraTipo_CusTalme_Consulta : Form
    {
        #region Declaracion Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //Conexion
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prod_ChatarraTipo_CusTalme_Bus Bus_TipoChatarra = new prod_ChatarraTipo_CusTalme_Bus();
        frmProd_ChatarraTipo_CusTalme_Mant frm;
        prod_ChatarraTipo_CusTalme_Info Info_TipoChatarra = new prod_ChatarraTipo_CusTalme_Info();

        //Variables
        string motiAnulacion, msg2 = "";

        #endregion

        public frmProd_ChatarraTipo_CusTalme_Consulta()
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
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFRM(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info_TipoChatarra == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    llamaFRM(Cl_Enumeradores.eTipo_action.actualizar);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info_TipoChatarra == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    llamaFRM(Cl_Enumeradores.eTipo_action.consultar);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info_TipoChatarra == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Info_TipoChatarra.Estado != "I")
                    {
                        llamaFRM(Cl_Enumeradores.eTipo_action.Anular);                        
                    }
                    else
                        MessageBox.Show("Este Tipo de Chatarra ya esta Anulada...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        

        private void load_datos()
        {
            try
            {
                this.gridTipoChatarra.DataSource = Bus_TipoChatarra.ConsultaGeneral(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmProd_ChatarraTipo_CusTalme_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                 load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void llamaFRM(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmProd_ChatarraTipo_CusTalme_Mant();                                
                frm.MdiParent = this.MdiParent;
                frm.set_accion(Accion);
                frm.event_frmProd_ChatarraTipo_CusTalme_Mant_FormClosing += new frmProd_ChatarraTipo_CusTalme_Mant.delegate_frmProd_ChatarraTipo_CusTalme_Mant_FormClosing(frm_event_frmProd_ChatarraTipo_CusTalme_Mant_FormClosing);
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.Set_InfoTipoChatarra(Info_TipoChatarra);
                }
                frm.Show();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

        void frm_event_frmProd_ChatarraTipo_CusTalme_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }  

        private void UltraGrid_TipoChatarra_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
               Info_TipoChatarra = (prod_ChatarraTipo_CusTalme_Info)GridView_TipoChatarra.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void GridView_TipoChatarra_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = GridView_TipoChatarra.GetRow(e.RowHandle) as prod_ChatarraTipo_CusTalme_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

    }
}
