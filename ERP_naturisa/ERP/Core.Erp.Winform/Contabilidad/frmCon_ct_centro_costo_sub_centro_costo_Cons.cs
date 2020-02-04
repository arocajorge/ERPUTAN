using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_ct_centro_costo_sub_centro_costo_Cons : Form
    {        
        #region Variables y atributos
        ct_centro_costo_sub_centro_costo_Bus SubCentroCostoBus = new ct_centro_costo_sub_centro_costo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        bool Es_consulta = true;
        int RowHandle = 0;        
        frmCon_CentroCosto_SubCentroCosto_Mant frmMant;
        ct_centro_costo_sub_centro_costo_Info Info = new ct_centro_costo_sub_centro_costo_Info();
        List<ct_centro_costo_sub_centro_costo_Info> LstInfo = new List<ct_centro_costo_sub_centro_costo_Info>();
        #endregion

        public void Set_config_combo(List<ct_centro_costo_sub_centro_costo_Info> Lista)
        {
            try
            {
                this.Text = "";
                this.ControlBox = false;
                LstInfo = Lista;
                ucGe_Menu_Mantenimiento_x_usuario.Hide();

                gridColumn0.Visible = false;
                gridColumn1.Visible = false;
                gridColumn2.Visible = false;
                gridColumn3.Visible = false;

                btn_vaciar.Visible = true;
                Es_consulta = false;

                gridViewSubCentro.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public frmCon_ct_centro_costo_sub_centro_costo_Cons()
        {
            try
            {
                InitializeComponent(); System.GC.Collect();

               // frmMant.event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing += frmMant_event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

                this.gridViewSubCentro.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewSubCentro_RowCellStyle);
                this.gridViewSubCentro.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSubCentro_FocusedRowChanged);
                this.Load += new System.EventHandler(this.frmCon_ct_centro_costo_sub_centro_costo_Cons_Load);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LlamarFormulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info = (ct_centro_costo_sub_centro_costo_Info)this.gridViewSubCentro.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.pc_Estado == "I")
                    MessageBox.Show("No se pueden modificar sub centros de costos inactivos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    LlamarFormulario(Cl_Enumeradores.eTipo_action.actualizar);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridViewSubCentro.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info = (ct_centro_costo_sub_centro_costo_Info)this.gridViewSubCentro.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    LlamarFormulario(Cl_Enumeradores.eTipo_action.consultar);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info = (ct_centro_costo_sub_centro_costo_Info)this.gridViewSubCentro.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.pc_Estado == "I")
                    MessageBox.Show("El sub centro de costo  : " + Info.IdCentroCosto + " ya fue anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    LlamarFormulario(Cl_Enumeradores.eTipo_action.Anular);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void frmMant_event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void frmCon_ct_centro_costo_sub_centro_costo_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void CargarGrid()
        {
            try
            {
                if (Es_consulta)
                {
                    LstInfo = SubCentroCostoBus.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                }
                gridControlSubCentro.DataSource = LstInfo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void gridViewSubCentro_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;
                Info = new ct_centro_costo_sub_centro_costo_Info();
                Info = this.gridViewSubCentro.GetFocusedRow() as ct_centro_costo_sub_centro_costo_Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void gridViewSubCentro_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewSubCentro.GetRow(e.RowHandle) as ct_centro_costo_sub_centro_costo_Info;
                if (data == null)
                    return;
                if (data.pc_Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void LlamarFormulario( Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmMant = new frmCon_CentroCosto_SubCentroCosto_Mant();
                frmMant.enu = Accion;
                if (Accion!=Cl_Enumeradores.eTipo_action.grabar)
                {
                    frmMant.SetInfo = Info;
                }
                frmMant.MdiParent = this.MdiParent;
                frmMant.Show();
                frmMant.event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing += frmMant_event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ct_centro_costo_sub_centro_costo_Info Get_info_centro_sub_centro_costo()
        {
            try
            {
                return Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        private void gridViewSubCentro_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (!Es_consulta)
                {
                    Info = (ct_centro_costo_sub_centro_costo_Info)gridViewSubCentro.GetRow(RowHandle);
                    if (Info!=null)
                    {
                        Info = Info.IdEmpresa == 0 ? null : Info;
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_vaciar_Click(object sender, EventArgs e)
        {
            try
            {
                Info = null;
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                LlamarFormulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
              
        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewSubCentro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Es_consulta)
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewSubCentro_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void disposed()
        {
            try
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_ct_centro_costo_sub_centro_costo_Cons_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                disposed();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
