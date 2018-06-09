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
using Core.Erp.Winform.General;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_TipoCargo_Consulta : Form
    {
        #region Declaracion de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Cargo_Info InfoTipCargo = new ro_Cargo_Info();
        ro_Cargo_Bus BusTipoCargo = new ro_Cargo_Bus();
        List<ro_Cargo_Info> LstInfoTipCargo = new List<ro_Cargo_Info>();
        private Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmRo_TipoCargo_Mant frm;
        #endregion

        public frmRo_TipoCargo_Consulta()
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
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoTipCargo != null)
                {
                   llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                }
                else
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoTipCargo != null)
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.consultar);
                }
                else
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (InfoTipCargo == null)
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    InfoTipCargo = (ro_Cargo_Info)gridViewCargo.GetFocusedRow();
                    if (InfoTipCargo.IdCargo > 0)
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el Cargo ID : " + InfoTipCargo.IdCargo + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (InfoTipCargo.Estado == "A")
                            {
                                string msg = "";
                                getparamanular();

                                FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                                oFrm.ShowDialog();
                                string motivoAnulacion = oFrm.motivoAnulacion;
                                InfoTipCargo.MotivoAnulacion = motivoAnulacion;
                                BusTipoCargo.EliminarDB(InfoTipCargo, ref msg);

                                MessageBox.Show(msg, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargaTipoCargo();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo anular el cargo ID : " + InfoTipCargo.IdCargo + " debido a que ya se encuentra anulado", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_ConsultaTipoCargo_Load(object sender, EventArgs e)
        {
            try
            {
                 CargaTipoCargo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }
        
        private void CargaTipoCargo()
        {
            try
            {
                LstInfoTipCargo = BusTipoCargo.ObtenerLstCargo(param.IdEmpresa);
             
                gridCtrlTipoCargo.DataSource  = LstInfoTipCargo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void getparamanular()
        {
            try
            {
                InfoTipCargo.Fecha_UltAnu = param.Fecha_Transac;
                InfoTipCargo.IdUsuarioUltAnu = param.IdUsuario;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }
    
        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmRo_TipoCargo_Mant();
                frm.event_frmRo_TipoCargo_Mant_FormClosing += new frmRo_TipoCargo_Mant.delegate_frmRo_TipoCargo_Mant_FormClosing (frm_event_frmRo_TipoCargo_Mant_FormClosing);
                //frm.MdiParent = this.MdiParent;
                frm.setTipoCargo = InfoTipCargo;
                frm.set_Accion(Accion);
                //frm.Show();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void frm_event_frmRo_TipoCargo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 CargaTipoCargo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void gridViewCargo_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewCargo.GetRow(e.RowHandle) as ro_Cargo_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewCargo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoTipCargo = (ro_Cargo_Info)gridViewCargo.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        }

        /// <summary>
        /// Prog: Eliana Veliz
        /// Ult Mod: 16/10/2014  15:10
        /// </summary>
        ///              
    }
}
