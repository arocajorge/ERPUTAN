using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Grupo_empleado_Consul : Form
    {
        public frmRo_Grupo_empleado_Consul()
        {
            InitializeComponent();
        }
        ro_Grupo_empleado_Info info = new ro_Grupo_empleado_Info();
        ro_Grupo_empleado_Bus bus = new ro_Grupo_empleado_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<ro_Grupo_empleado_Info> lista = new List<ro_Grupo_empleado_Info>();
        frmRo_Grupo_empleado_Mant frm;

        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmRo_Grupo_empleado_Mant();
                frm.event_frmRo_Grupo_empleado_Mant_FormClosing += frm_event_frmRo_Grupo_empleado_Mant_FormClosing;

                frm.accion = Accion;
                frm.MdiParent = this.MdiParent;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.Cargar_datos();
                    frm.set(info);
                    frm.Show();
                }
                else
                {
                    frm.Cargar_datos();
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmRo_Grupo_empleado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_data();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (ro_Grupo_empleado_Info)gridView_grupo.GetFocusedRow();
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (ro_Grupo_empleado_Info)gridView_grupo.GetFocusedRow();
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = (ro_Grupo_empleado_Info)gridView_grupo.GetFocusedRow();
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridView_grupo_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridView_grupo.GetRow(e.RowHandle) as ro_Grupo_empleado_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void gridView_grupo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                info = new ro_Grupo_empleado_Info();
                info = (ro_Grupo_empleado_Info)gridView_grupo.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void cargar_data()
        {
            try
            {
                lista = bus.listado_Grupos(param.IdEmpresa);
                gridControl_grupo.DataSource = lista;
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_Grupo_empleado_Consul_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_data();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
            }
        }

        private void gridView_grupo_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                info = new ro_Grupo_empleado_Info();
                info = (ro_Grupo_empleado_Info)gridView_grupo.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
