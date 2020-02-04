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
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_NotaCredito_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus ;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_nota_DebCre_Info notaCr_I = new cp_nota_DebCre_Info();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        cp_nota_DebCre_Bus notaCr_B = new cp_nota_DebCre_Bus();
        List<cp_nota_DebCre_Info> lista_Nota_DebCre = new List<cp_nota_DebCre_Info>();

        int IdTipoCbteRev = 34;
        decimal IdCbteCbleRev;
        string motiAnulacion, msg2 = "";
        
        public frmCP_NotaCredito_Cons()
        {
            InitializeComponent();

            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick;
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewCredito.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
     
        frmCP_NotaCredito_Mant frm;

        private void llamaFRM(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmCP_NotaCredito_Mant();
                frm.event_frmCP_NotaCredito_Mant_FormClosing += frm_event_frmCP_NotaCredito_Mant_FormClosing;
                frm.set_accion(Accion);
                frm.MdiParent = this.MdiParent;
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_info(notaCr_I);
                }
                frm.Show();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        void frm_event_frmCP_NotaCredito_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {               
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_datos()
        {
            try
            {
                DateTime FechaIni=ucGe_Menu.fecha_desde;
                DateTime FechaFin=ucGe_Menu.fecha_hasta;
                string DebCre="C";

                lista_Nota_DebCre = notaCr_B.Get_List_nota_DebCre(param.IdEmpresa, FechaIni, FechaFin, DebCre);

                this.gridControlCredito.DataSource = lista_Nota_DebCre;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFRM(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (notaCr_I == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (notaCr_I.Estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                llamaFRM(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (notaCr_I == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }               
                llamaFRM(Cl_Enumeradores.eTipo_action.consultar);
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (notaCr_I == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (notaCr_I.Estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                llamaFRM(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_NotaCredito_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCredito_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                notaCr_I = new cp_nota_DebCre_Info();
                notaCr_I = this.gridViewCredito.GetFocusedRow() as cp_nota_DebCre_Info;
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCredito_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                 var data = gridViewCredito.GetRow(e.RowHandle) as cp_nota_DebCre_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
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
