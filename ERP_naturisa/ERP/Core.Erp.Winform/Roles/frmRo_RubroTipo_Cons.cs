using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_RubroTipo_Cons : Form
    {
        #region Declaracion de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmRo_RubroTipo_Mant frm;
        ro_rubro_tipo_Info InfoTipRubro = new ro_rubro_tipo_Info();
        ro_rubro_tipo_Bus BusTipoRubro = new ro_rubro_tipo_Bus();

        #endregion
        
        public frmRo_RubroTipo_Cons()
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
                if (InfoTipRubro != null)
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
                // if (InfoTipRubro.IdRubro != null)
                if (InfoTipRubro != null)
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


                if (InfoTipRubro == null)
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (InfoTipRubro.IdRubro != null)
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el Rubro ID : " + InfoTipRubro.IdRubro + " ? ", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (InfoTipRubro.ru_estado == "A")
                            {
                                string msg = "Anulado existosamente";
                                getparamanular();

                                BusTipoRubro.AnularDB(InfoTipRubro);

                                MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarGrid();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo anular el rubro ID : " + InfoTipRubro.IdRubro + ". \r El rubro ya se encuentra anulado", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CargarGrid()
        {
            try
            {
                this.gridCtrlRubro.DataSource = BusTipoRubro.ConsultaGeneral(param.IdEmpresa);

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
                    frm = new frmRo_RubroTipo_Mant();
                    frm.event_frmRo_RubroTipo_Mant_FormClosing += new frmRo_RubroTipo_Mant.delegate_frmRo_RubroTipo_Mant_FormClosing(frm_event_frmRo_RubroTipo_Mant_FormClosing);
                    //frm.MdiParent = this.MdiParent;
                    frm._SetInfo = InfoTipRubro;
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

        void frm_event_frmRo_RubroTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
             CargarGrid();
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
                InfoTipRubro.Fecha_UltAnu = param.Fecha_Transac;
                InfoTipRubro.IdUsuarioUltAnu = param.IdUsuario;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void frm_Event_frmRo_RubroTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                
                    CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmRo_RubroTipo_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                  CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void gridViewRubro_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoTipRubro = (ro_rubro_tipo_Info)gridViewRubro.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
 
        }

        private void gridViewRubro_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewRubro.GetRow(e.RowHandle) as ro_rubro_tipo_Info;
                if (data == null)
                    return;

                if (data.ru_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        ///Sumary Modificación de Codigo
        ///Progra : Eliana Veliz
        ///17/10/2014
        ///12:10
    }
}
/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 26/02/2014  12:09
/// LIN 221
/// </summary>
/// 
