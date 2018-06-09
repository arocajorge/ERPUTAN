using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_Tipo_Depreciacion_Consul : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<Af_Tipo_Depreciacion_Info> lm = new List<Af_Tipo_Depreciacion_Info>();
        Af_Tipo_Depreciacion_Info info = new Af_Tipo_Depreciacion_Info();
        #endregion

        public frmAF_Tipo_Depreciacion_Consul()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
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
                if (info.IdTipoDepreciacion != 0)
                {
                    frmAF_Tipo_Depreciacion frm = new frmAF_Tipo_Depreciacion();
                    frm.MdiParent = this.MdiParent;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.set_Af_Tipo_Depreciacion(info);
                    frm.Show();
                    frm.event_frmAF_Tipo_Depreciacion_FormClosing += new frmAF_Tipo_Depreciacion.delegate_frmAF_Tipo_Depreciacion_FormClosing(frm_event_frmAF_Tipo_Depreciacion_FormClosing);                   
                }
                else
                    //Por_favor_seleccione_item_a_anular
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdTipoDepreciacion != 0)
                {
                    frmAF_Tipo_Depreciacion frm = new frmAF_Tipo_Depreciacion();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.MdiParent = this.MdiParent;
                    frm.set_Af_Tipo_Depreciacion(info);
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdTipoDepreciacion != 0)
                {
                    frmAF_Tipo_Depreciacion frm = new frmAF_Tipo_Depreciacion();
                    frm.MdiParent = this.MdiParent;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.set_Af_Tipo_Depreciacion(info);
                    frm.Show();
                    frm.event_frmAF_Tipo_Depreciacion_FormClosing += new frmAF_Tipo_Depreciacion.delegate_frmAF_Tipo_Depreciacion_FormClosing(frm_event_frmAF_Tipo_Depreciacion_FormClosing);                   
                }
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                frmAF_Tipo_Depreciacion frm = new frmAF_Tipo_Depreciacion();
                frm.MdiParent = this.MdiParent;
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Show();
                frm.event_frmAF_Tipo_Depreciacion_FormClosing += new frmAF_Tipo_Depreciacion.delegate_frmAF_Tipo_Depreciacion_FormClosing(frm_event_frmAF_Tipo_Depreciacion_FormClosing);                   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void frm_event_frmAF_Tipo_Depreciacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_ActivoFijo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void load_ActivoFijo()
        {
            try
            {
                Af_Tipo_Depreciacion_Bus bus_activo_fijo = new Af_Tipo_Depreciacion_Bus();
                lm = bus_activo_fijo.Get_List_ActivoFijo(param.IdEmpresa);
                this.dgActivoFijo.DataSource = lm;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAF_Tipo_Depreciacion_Consul_Load(object sender, EventArgs e)
        {
            try
            {
                load_ActivoFijo();
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
                info = (Af_Tipo_Depreciacion_Info)gridViewActivoFijo.GetFocusedRow();
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
                var data = gridViewActivoFijo.GetRow(e.RowHandle) as Af_Tipo_Depreciacion_Info;
                if (data == null)
                    return;
                if (data.estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
