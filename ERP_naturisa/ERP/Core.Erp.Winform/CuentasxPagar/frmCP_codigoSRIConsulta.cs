using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_codigoSRIConsulta : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCCp_Tipo_codigo_SRI UC_TipCodSRI = new UCCp_Tipo_codigo_SRI();
        cp_codigo_SRI_Info codSRI_Info = new cp_codigo_SRI_Info();
        cp_codigo_SRI_x_CtaCble_Info codcta = new cp_codigo_SRI_x_CtaCble_Info();
        #endregion
        
        public frmCP_codigoSRIConsulta()
        {
            try
            {
                InitializeComponent();

                this.UC_TipCodSRI.Event_cmb_tipo_cod_SRI_SelectedIndexChanged += new UCCp_Tipo_codigo_SRI.delegatecmb_tipo_cod_SRI_SelectedIndexChanged(cmb_tipo_cod_SRI_SelectedIndexChanged);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
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
                this.Close();
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
                frmCP_MantCodigoSRI frm = new frmCP_MantCodigoSRI();
                frm.set_accion(Cl_Enumeradores.eTipo_action.grabar);
                //frm.UCMC.set_accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                load_datos("");
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
                if (codSRI_Info.IdCodigo_SRI == 0)
                {
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                
                        frmCP_MantCodigoSRI frm = new frmCP_MantCodigoSRI();
                        frm.set_Info(codSRI_Info);

                        frm.set_accion(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.ShowDialog();
                        load_datos("");                                                                   
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
                if (codSRI_Info.IdCodigo_SRI == 0)
                {
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    frmCP_MantCodigoSRI frm = new frmCP_MantCodigoSRI();
                    frm.set_Info(codSRI_Info);
                    frm.set_accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.ShowDialog();
                    load_datos("");
                }
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
                if (codSRI_Info.IdCodigo_SRI == 0)
                {
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (codSRI_Info.co_estado == "I")
                {
                    MessageBox.Show("No se procedió con la Anulación porque ya está Anulado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    frmCP_MantCodigoSRI frm = new frmCP_MantCodigoSRI();
                    frm.set_Info(codSRI_Info);
                    frm.set_accion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.ShowDialog();
                    load_datos("");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void cmb_tipo_cod_SRI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_datos(this.UC_TipCodSRI._Tipo.IdTipoSRI);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void load_datos(string cod)
        {
            try
            {
                cp_codigo_SRI_Bus dat_ti = new cp_codigo_SRI_Bus();

                List<cp_codigo_SRI_Info> lista = new List<cp_codigo_SRI_Info>();
                lista = dat_ti.Get_List_codigo_SRI((cod.Trim() == "T") ? "" : cod);

                foreach (var item in lista)
                {
                    item.FecValiDesde = item.co_f_vigente_desde.ToString();
                    item.FecValiHasta = item.co_f_vigente_hasta.ToString();
                }

                gridControlSRI.DataSource = lista;
                
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void frmCP_codigo_SRI_Load(object sender, EventArgs e)
        {
            try
            {
                    pn_tipo_codigo.Controls.Add(UC_TipCodSRI);
                    load_datos("");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
 
        private void gridViewSRI_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                codSRI_Info = new cp_codigo_SRI_Info();
                codSRI_Info = this.gridViewSRI.GetFocusedRow() as cp_codigo_SRI_Info;
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewSRI_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewSRI.GetRow(e.RowHandle) as cp_codigo_SRI_Info;
                if (data == null)
                    return;
                if (data.co_estado == "I")
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
