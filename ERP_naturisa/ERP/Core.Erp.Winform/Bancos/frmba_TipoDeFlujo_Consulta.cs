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
using Core.Erp.Info.General;
using Core.Erp.Info.Bancos;
namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_TipoDeFlujo_Consulta : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_TipoFlujo_Bus Bus = new ba_TipoFlujo_Bus();
        Cl_Enumeradores.eTipo_action _Accion;
        FrmBA_TipoDeFlujoMant frm = new FrmBA_TipoDeFlujoMant();
        #endregion

        public FrmBA_TipoDeFlujo_Consulta()
        {
            try
            {
                InitializeComponent();
                Cargargrid();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //ba_TipoFlujo_Info Itemanular = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as ba_TipoFlujo_Info;
                //if (Itemanular.Estado == "I")
                //{
                //    MessageBox.Show("El registro ya se encuentra anulado", "Sistemas");
                //    return;
                //}
                //if (Bus.Anular(Itemanular))
                //{
                //    MessageBox.Show("Registro Anulado Exisamente");
                //}
                frm = new FrmBA_TipoDeFlujoMant();
                frm.Event_frmba_TipoDeFlujoMant_FormClosing += new FrmBA_TipoDeFlujoMant.delegate_frmba_TipoDeFlujoMant_FormClosing(Event_frmba_TipoDeFlujoMant_FormClosing);
                frm.SetAccion(Cl_Enumeradores.eTipo_action.Anular);
                frm.SetInfo = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as ba_TipoFlujo_Info;
                //  frm.Parent = this.MdiParent;
                frm.Show();

                Cargargrid();
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
                frm = new FrmBA_TipoDeFlujoMant();
                frm.Event_frmba_TipoDeFlujoMant_FormClosing += new FrmBA_TipoDeFlujoMant.delegate_frmba_TipoDeFlujoMant_FormClosing(Event_frmba_TipoDeFlujoMant_FormClosing);
                frm.SetAccion(Cl_Enumeradores.eTipo_action.consultar);
                frm.SetInfo = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as ba_TipoFlujo_Info;
                //  frm.Parent = this.MdiParent;
                frm.Show();
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
                frm = new FrmBA_TipoDeFlujoMant();
                frm.Event_frmba_TipoDeFlujoMant_FormClosing += new FrmBA_TipoDeFlujoMant.delegate_frmba_TipoDeFlujoMant_FormClosing(Event_frmba_TipoDeFlujoMant_FormClosing);
                frm.SetAccion(Cl_Enumeradores.eTipo_action.actualizar);
                frm.SetInfo = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as ba_TipoFlujo_Info;
                // frm.Parent = this.MdiParent;
                frm.Show();
                Cargargrid();
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
                frm = new FrmBA_TipoDeFlujoMant();
                frm.Event_frmba_TipoDeFlujoMant_FormClosing += new FrmBA_TipoDeFlujoMant.delegate_frmba_TipoDeFlujoMant_FormClosing(Event_frmba_TipoDeFlujoMant_FormClosing);
                //frm.Event_frmba_TipoDeFlujoMant_FormClosing += frm_Event_frmba_TipoDeFlujoMant_FormClosing;
                frm.SetAccion(Cl_Enumeradores.eTipo_action.grabar);
                //frm.Parent = this.MdiParent;
                frm.Show();
                Cargargrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Cargargrid() 
        {
            try
            {
                treeList1.DataSource = Bus.Get_List_TipoFlujo(param.IdEmpresa);
                treeList1.ExpandAll();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void Event_frmba_TipoDeFlujoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              Cargargrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void treeList1_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            try
            {
                if (Convert.ToString(e.Node.GetValue(e.Column.AbsoluteIndex)) == "I")
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmBA_TipoDeFlujo_Consulta_Load(object sender, EventArgs e)
        {

        }
    }
}
