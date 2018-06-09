using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Talonario_cheques_x_bancoConsulta : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ba_Talonario_cheques_x_banco_Info Info = new ba_Talonario_cheques_x_banco_Info();
        ba_Talonario_cheques_x_banco_Bus ba_Talonario_cheques_x_banco_B = new ba_Talonario_cheques_x_banco_Bus();
        BindingList<ba_Talonario_cheques_x_banco_Info> lista = new BindingList<ba_Talonario_cheques_x_banco_Info>();
        FrmBA_Talonario_cheques_x_bancoMant ofrm = new FrmBA_Talonario_cheques_x_bancoMant();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        #endregion

        public FrmBA_Talonario_cheques_x_bancoConsulta()
        {
            InitializeComponent();
            ucGe_Menu.event_btnLoteChq_ItemClick += ucGe_Menu_event_btnLoteChq_ItemClick;
            ucGe_Menu.event_btnNuevoChq_ItemClick += ucGe_Menu_event_btnNuevoChq_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            //ofrm.Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing+=ofrm_Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing;
            //frm2.Event_FrmBA_Talonario_Lote_cheques_x_banco_FormClosing += frm2_Event_FrmBA_Talonario_Lote_cheques_x_banco_FormClosing;

        }

        void frm2_Event_FrmBA_Talonario_Lote_cheques_x_banco_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargardata();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        void ucGe_Menu_event_btnNuevoChq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new FrmBA_Talonario_cheques_x_bancoMant();
                ofrm.Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing += new FrmBA_Talonario_cheques_x_bancoMant.delegate_FrmBA_Talonario_cheques_x_bancoMant_FormClosing(ofrm_Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing);                
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ofrm_Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargardata();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new FrmBA_Talonario_cheques_x_bancoMant();
                ofrm.Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing += new FrmBA_Talonario_cheques_x_bancoMant.delegate_FrmBA_Talonario_cheques_x_bancoMant_FormClosing(ofrm_Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing);                
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.consultar);
                ofrm.set_Info(Info);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new FrmBA_Talonario_cheques_x_bancoMant();
                ofrm.Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing += new FrmBA_Talonario_cheques_x_bancoMant.delegate_FrmBA_Talonario_cheques_x_bancoMant_FormClosing(ofrm_Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing);               
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.Anular);
                ofrm.set_Info(Info);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new FrmBA_Talonario_cheques_x_bancoMant();
                ofrm.Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing += new FrmBA_Talonario_cheques_x_bancoMant.delegate_FrmBA_Talonario_cheques_x_bancoMant_FormClosing(ofrm_Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing);                
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                ofrm.set_Info(Info);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnLoteChq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmBA_Talonario_Lote_cheques_x_banco frm2 = new FrmBA_Talonario_Lote_cheques_x_banco();
                frm2.Event_FrmBA_Talonario_Lote_cheques_x_banco_FormClosing += new FrmBA_Talonario_Lote_cheques_x_banco.delegate_FrmBA_Talonario_Lote_cheques_x_banco_FormClosing(frm2_Event_FrmBA_Talonario_Lote_cheques_x_banco_FormClosing);
                frm2.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
                
        private void gridViewClaveCont_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            try
            {
                Info = (ba_Talonario_cheques_x_banco_Info)gridViewtalonario.GetFocusedRow();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cargardata()
        {
            try
            {                
                string msg = "";

                lista = new BindingList<ba_Talonario_cheques_x_banco_Info>(ba_Talonario_cheques_x_banco_B.Get_List_Talonario_cheques_x_banco(param.IdEmpresa, ref msg));

               
                if (lista.Count > 0)
                {
                                     
                    gridControltalonario.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("No registros que mostrar" + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gridControltalonario.DataSource = null;
                    gridControltalonario.RefreshDataSource();
                }


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
                    
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {                               
            }
        }

        private void FrmBA_Talonario_cheques_x_bancoConsulta_Load(object sender, EventArgs e)
        {
            try
            {                
                cargardata();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnNuevoChq_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBA_Talonario_cheques_x_bancoMant talon = new FrmBA_Talonario_cheques_x_bancoMant();
                talon.ShowDialog();
                cargardata();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private ba_Talonario_cheques_x_banco_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {

            try
            {
                return (ba_Talonario_cheques_x_banco_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Talonario_cheques_x_banco_Info();
            }
        }

        private void gridViewtalonario_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewtalonario_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewtalonario.GetRow(e.RowHandle) as ba_Talonario_cheques_x_banco_Info;
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

        private void gridViewtalonario_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = (ba_Talonario_cheques_x_banco_Info)gridViewtalonario.GetFocusedRow();
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
