using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_ActivoFijoTipo_General : Form
    {
        #region Declaración de Varibles
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Af_Activo_fijo_tipo_Info info = new Af_Activo_fijo_tipo_Info();
        List<Af_Activo_fijo_tipo_Info> lm = new List<Af_Activo_fijo_tipo_Info>();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion
       
        public frmAF_ActivoFijoTipo_General()
        {
            try
            {
                InitializeComponent();
                load_ActivoFijoTipo();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                load_ActivoFijoTipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmAF_ActivoFijoTipo_Mant frm = new frmAF_ActivoFijoTipo_Mant();
                frm.MdiParent = this.MdiParent;
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Show();
                frm.event_frmAF_ActivoFijoTipo_Mant_FormClosing += new frmAF_ActivoFijoTipo_Mant.delegate_frmAF_ActivoFijoTipo_Mant_FormClosing(frm_event_frmAF_ActivoFijoTipo_Mant_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                load_ActivoFijoTipo();
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdActivoFijoTipo != 0)
                {
                    frmAF_ActivoFijoTipo_Mant frm = new frmAF_ActivoFijoTipo_Mant();
                    frm.MdiParent = this.MdiParent;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.set_ActivoFijoTipo(info);
                    frm.Show();
                    frm.event_frmAF_ActivoFijoTipo_Mant_FormClosing += new frmAF_ActivoFijoTipo_Mant.delegate_frmAF_ActivoFijoTipo_Mant_FormClosing(frm_event_frmAF_ActivoFijoTipo_Mant_FormClosing);
                }
                else
                    //Por_favor_seleccione_item_a_modi
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdActivoFijoTipo != 0)
                {
                    frmAF_ActivoFijoTipo_Mant frm = new frmAF_ActivoFijoTipo_Mant();
                    frm.MdiParent = this.MdiParent;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.set_ActivoFijoTipo(info);
                    frm.Show();
                }
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdActivoFijoTipo != 0)
                {
                    frmAF_ActivoFijoTipo_Mant frm = new frmAF_ActivoFijoTipo_Mant();
                    frm.MdiParent = this.MdiParent;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.set_ActivoFijoTipo(info);
                    frm.Show();
                    frm.event_frmAF_ActivoFijoTipo_Mant_FormClosing += new frmAF_ActivoFijoTipo_Mant.delegate_frmAF_ActivoFijoTipo_Mant_FormClosing(frm_event_frmAF_ActivoFijoTipo_Mant_FormClosing);
                }
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_ActivoFijoTipo()
        {
            try
            {
                Af_Activo_fijo_tipo_Bus bus_act_fij_tip = new Af_Activo_fijo_tipo_Bus();
                lm = bus_act_fij_tip.Get_List_ActivoFijoTipo(param.IdEmpresa);
                this.dgActivoFijo.DataSource = lm;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void frm_event_frmAF_ActivoFijoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_ActivoFijoTipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAF_ActivoFijoTipo_General_Load(object sender, EventArgs e)
        {
            try
            {
                load_ActivoFijoTipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gridViewActivoFijo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewActivoFijo.GetRow(e.RowHandle) as Af_Activo_fijo_tipo_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    //if (data.Estado == false)
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewActivoFijo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                info = (Af_Activo_fijo_tipo_Info)gridViewActivoFijo.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Af_Activo_fijo_tipo_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {

            try
            {
                return (Af_Activo_fijo_tipo_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Af_Activo_fijo_tipo_Info();
            }
        }

        private void gridViewActivoFijo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
