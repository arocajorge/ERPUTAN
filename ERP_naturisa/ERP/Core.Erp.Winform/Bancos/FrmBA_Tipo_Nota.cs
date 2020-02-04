using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Tipo_Nota : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_tipo_nota_Bus bus_TipoNota = new ba_tipo_nota_Bus();
        ba_tipo_nota_Info _Info = new ba_tipo_nota_Info();


        public FrmBA_Tipo_Nota()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cargarInfo();
                FrmBA_Tipo_Nota_Mantenimiento TipoNotaMant = new FrmBA_Tipo_Nota_Mantenimiento();
                TipoNotaMant._Accion = Info.General.Cl_Enumeradores.eTipo_action.consultar;
                TipoNotaMant.Event_FrmBA_Catalogo_Mantenimiento_FormClosing += new FrmBA_Tipo_Nota_Mantenimiento.delegate_FrmBA_Tipo_Nota_Mantenimiento_FormClosing(TipoNotaMant_Event_FrmBA_Catalogo_Mantenimiento_FormClosing);
                TipoNotaMant._Info(_Info);
                TipoNotaMant.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cargarInfo();
                FrmBA_Tipo_Nota_Mantenimiento TipoNotaMant = new FrmBA_Tipo_Nota_Mantenimiento();
                TipoNotaMant._Accion = Info.General.Cl_Enumeradores.eTipo_action.actualizar;
                TipoNotaMant._Info(_Info);
                TipoNotaMant.Event_FrmBA_Catalogo_Mantenimiento_FormClosing += new FrmBA_Tipo_Nota_Mantenimiento.delegate_FrmBA_Tipo_Nota_Mantenimiento_FormClosing(TipoNotaMant_Event_FrmBA_Catalogo_Mantenimiento_FormClosing);
                TipoNotaMant.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cargarInfo();
                FrmBA_Tipo_Nota_Mantenimiento TipoNotaMant = new FrmBA_Tipo_Nota_Mantenimiento();
                TipoNotaMant._Accion = Info.General.Cl_Enumeradores.eTipo_action.Anular;
                TipoNotaMant._Info(_Info);
                TipoNotaMant.Event_FrmBA_Catalogo_Mantenimiento_FormClosing += new FrmBA_Tipo_Nota_Mantenimiento.delegate_FrmBA_Tipo_Nota_Mantenimiento_FormClosing(TipoNotaMant_Event_FrmBA_Catalogo_Mantenimiento_FormClosing);
                TipoNotaMant.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmBA_Tipo_Nota_Mantenimiento TipoNotaMant = new FrmBA_Tipo_Nota_Mantenimiento();
                TipoNotaMant._Accion = Info.General.Cl_Enumeradores.eTipo_action.grabar;
                TipoNotaMant.Event_FrmBA_Catalogo_Mantenimiento_FormClosing += new FrmBA_Tipo_Nota_Mantenimiento.delegate_FrmBA_Tipo_Nota_Mantenimiento_FormClosing(TipoNotaMant_Event_FrmBA_Catalogo_Mantenimiento_FormClosing);
                TipoNotaMant.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmBA_Tipo_Nota_Load(object sender, EventArgs e)
        {
            try
            {
                gridControlTipoNota.DataSource = bus_TipoNota.Get_List_tipo_nota(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void cargarInfo()
        {
            try
            {
                var info = (ba_tipo_nota_Info)gridViewTipoNota.GetFocusedRow();
                _Info.IdTipoNota = info.IdTipoNota;
                _Info.Descripcion = info.Descripcion;
                _Info.Tipo = info.Tipo;
                _Info.IdCtaCble = info.IdCtaCble;
                _Info.IdCentroCosto = info.IdCentroCosto;
                _Info.IdEmpresa = info.IdEmpresa;
                _Info.Estado = info.Estado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void TipoNotaMant_Event_FrmBA_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gridControlTipoNota.DataSource = bus_TipoNota.Get_List_tipo_nota(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewTipoNota_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewTipoNota.GetRow(e.RowHandle) as ba_tipo_nota_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
