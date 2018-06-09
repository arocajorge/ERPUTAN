using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;


namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAf_Activo_fijo_Categoria_Consul : Form
    {

        string MensajeError = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        Af_Activo_fijo_Categoria_Bus busVta = new Af_Activo_fijo_Categoria_Bus();
        List<Af_Activo_fijo_Categoria_Info> lstInfo = new List<Af_Activo_fijo_Categoria_Info>();

        Af_Activo_fijo_Categoria_Info InfoAf = new Af_Activo_fijo_Categoria_Info();



        frmAf_Activo_fijo_Categoria_Mant frm;


        public frmAf_Activo_fijo_Categoria_Consul()
        {
            InitializeComponent();
        }

        private void frmAf_Activo_fijo_Categoria_Consul_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }

        void CargarGrid()
        {
            try
            {
                lstInfo = busVta.Get_List_Activo_fijo_Categoria(param.IdEmpresa, ref MensajeError);
                gridControlCategoriaAF.DataSource= lstInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Af_Activo_fijo_Categoria_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (Af_Activo_fijo_Categoria_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Af_Activo_fijo_Categoria_Info();
            }
        }

        private void gridViewCategoriaAF_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                InfoAf = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCategoriaAF_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCategoriaAF.GetRow(e.RowHandle) as Af_Activo_fijo_Categoria_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                frm = new frmAf_Activo_fijo_Categoria_Mant();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + "*** NUEVO REGISTRO ***";
                frm.Show();
                frm.MdiParent = this.MdiParent;
                frm.event_frmAf_Activo_fijo_Categoria_Mant_FormClosing += frm_event_frmAf_Activo_fijo_Categoria_Mant_FormClosing;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void frm_event_frmAf_Activo_fijo_Categoria_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoAf = (Af_Activo_fijo_Categoria_Info)gridViewCategoriaAF.GetFocusedRow();

                if (InfoAf != null)
                {
                    frm = new frmAf_Activo_fijo_Categoria_Mant();
                    frm.event_frmAf_Activo_fijo_Categoria_Mant_FormClosing+=frm_event_frmAf_Activo_fijo_Categoria_Mant_FormClosing;
                    frm.Text = frm.Text + "***ACTUALIZAR REGISTRO***";
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.Set_Info_Categoria(InfoAf);
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoAf = (Af_Activo_fijo_Categoria_Info)gridViewCategoriaAF.GetFocusedRow();

                if (InfoAf != null)
                {
                    frm = new frmAf_Activo_fijo_Categoria_Mant();
                    frm.event_frmAf_Activo_fijo_Categoria_Mant_FormClosing += frm_event_frmAf_Activo_fijo_Categoria_Mant_FormClosing;
                    frm.Text = frm.Text + "***CONSULTA DE REGISTRO***";
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Set_Info_Categoria(InfoAf);
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoAf = (Af_Activo_fijo_Categoria_Info)gridViewCategoriaAF.GetFocusedRow();

                if (InfoAf != null)
                {
                    frm = new frmAf_Activo_fijo_Categoria_Mant();
                    frm.event_frmAf_Activo_fijo_Categoria_Mant_FormClosing += frm_event_frmAf_Activo_fijo_Categoria_Mant_FormClosing;
                    frm.Text = frm.Text + "***ANULAR REGISTRO***";
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.Set_Info_Categoria(InfoAf);
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlCategoriaAF.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
