using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Contabilidad
{
    public class frmCon_ct_centro_costo_sub_centro_costo_Cons_Handler
    {
        #region Declaracion de controles
        public DevExpress.XtraGrid.GridControl gridControlSubCentro;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewSubCentro;
        public System.Windows.Forms.BindingSource ctcentrocostosubcentrocostoInfoBindingSource;
        public DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        public DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        public DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_sub_centro_costo;
        public DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        public DevExpress.XtraGrid.Columns.GridColumn colpc_Estado;
        public DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.Panel panel1;
        public Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        public System.Windows.Forms.Panel panel2;
        #endregion

        #region Variables y atributos
        ct_centro_costo_sub_centro_costo_Bus SubCentroCostoBus = new ct_centro_costo_sub_centro_costo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        frmCon_CentroCosto_SubCentroCosto_Mant frmMant;
        frmCon_CentroCosto_SubCentroCosto_Mant_FJ frmMant_FJ;

        ct_centro_costo_sub_centro_costo_Info Info = new ct_centro_costo_sub_centro_costo_Info();
        #endregion

        Form frmChildren;
        Form frmParent;
        Cl_Enumeradores.eCliente_Vzen eCliente;

        #region Set
        public void Set_frmChildren(Form _frmChildren)
        {
            try
            {
                frmChildren = _frmChildren;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        public void Set_frmParent(Form _frmParent)
        {
            try
            {
                frmParent = _frmParent;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        public void Set_Cliente_VZEN(Cl_Enumeradores.eCliente_Vzen _eCliente)
        {
            try
            {
                eCliente = _eCliente;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion  

        public frmCon_ct_centro_costo_sub_centro_costo_Cons_Handler()
        {
            try
            {
                if (eCliente == 0)
                {
                    eCliente = Cl_Enumeradores.eCliente_Vzen.GENERAL;
                }
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
                frmChildren.Close();
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
                List<ct_centro_costo_sub_centro_costo_Info> LstInfo = new List<ct_centro_costo_sub_centro_costo_Info>();
                LstInfo = SubCentroCostoBus.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
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

        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                switch (eCliente)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        LlamarFormulario_FJ(Accion);
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                        LlamarFormulario_GE(Accion);
                        break;
                    default:
                        LlamarFormulario_GE(Accion);
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        private void LlamarFormulario_GE( Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmMant = new frmCon_CentroCosto_SubCentroCosto_Mant();
                frmMant.enu = Accion;
                if (Accion!=Cl_Enumeradores.eTipo_action.grabar)
                {
                    frmMant.SetInfo = Info;
                }
                frmMant.MdiParent = frmParent;
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

        private void LlamarFormulario_FJ(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmMant_FJ = new frmCon_CentroCosto_SubCentroCosto_Mant_FJ();
                frmMant_FJ.enu = Accion;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frmMant_FJ.SetInfo = Info;
                }
                frmMant_FJ.MdiParent = frmParent;
                frmMant_FJ.Show();
                frmMant_FJ.event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing += frmMant_event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing;

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
