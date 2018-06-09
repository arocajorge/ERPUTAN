using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;






namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Proveedor_Clase_Consul : Form
    {


        List<cp_proveedor_clase_Info> listProvee_clase= new List<cp_proveedor_clase_Info>();
        cp_proveedor_clase_Bus Prove_clase_bus= new cp_proveedor_clase_Bus();

        Cl_Enumeradores.eTipo_action eAccion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        cp_proveedor_clase_Info Info = new cp_proveedor_clase_Info();
        frmCP_Proveedor_Clase_Mant frm = new frmCP_Proveedor_Clase_Mant();


        public frmCP_Proveedor_Clase_Consul()
        {
            InitializeComponent();
            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_event_btnImprimir_ItemClick;

        }

        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewClaseProveedor.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (cp_proveedor_clase_Info)gridViewClaseProveedor.GetFocusedRow();

                if (Info != null)
                {
                    if (Info.Estado == "I")
                    { MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                    else
                    {
                        frm = new frmCP_Proveedor_Clase_Mant();
                        frm.Text = frm.Text + "***ANULAR REGISTRO***";
                        frm.InfoProveedor_clase = Info;
                        frm.Accion = Cl_Enumeradores.eTipo_action.Anular;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_frmCP_Proveedor_Clase_Mant_FormClosing += frm_event_frmCP_Proveedor_Clase_Mant_FormClosing;

                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void frm_event_frmCP_Proveedor_Clase_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {

                Info = (cp_proveedor_clase_Info)gridViewClaseProveedor.GetFocusedRow();

                if (Info != null)
                {
                    frm = new frmCP_Proveedor_Clase_Mant();
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm.InfoProveedor_clase = Info;
                    frm.Accion = Cl_Enumeradores.eTipo_action.consultar;
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_frmCP_Proveedor_Clase_Mant_FormClosing += frm_event_frmCP_Proveedor_Clase_Mant_FormClosing;

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                Info = (cp_proveedor_clase_Info)gridViewClaseProveedor.GetFocusedRow();

                if (Info != null)
                {
                    //if (Info.Estado == "I")
                    //{ MessageBox.Show("No se pueden modificar registros inactivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                    //else
                    //{

                        frm = new frmCP_Proveedor_Clase_Mant();
                        frm.Text = frm.Text + "***ACTUALIZAR REGISTRO***";
                        frm.InfoProveedor_clase = Info;
                        frm.Accion = Cl_Enumeradores.eTipo_action.actualizar;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_frmCP_Proveedor_Clase_Mant_FormClosing += frm_event_frmCP_Proveedor_Clase_Mant_FormClosing;
                    //}

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmCP_Proveedor_Clase_Mant();
                frm.Accion= Cl_Enumeradores.eTipo_action.grabar;
                frm.Text = frm.Text + "*** NUEVO REGISTRO ***";
                frm.Show();
                frm.MdiParent = this.MdiParent;
                frm.event_frmCP_Proveedor_Clase_Mant_FormClosing += frm_event_frmCP_Proveedor_Clase_Mant_FormClosing;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



        private void cargar_grid()
        {
            try
            {
                listProvee_clase = Prove_clase_bus.Get_List_proveedor_clase(param.IdEmpresa);
                gridControlClaseProveedor.DataSource=listProvee_clase;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }

        private void gridControlClaseProveedor_Click(object sender, EventArgs e)
        {

        }

        private void frmCP_Proveedor_Clase_Consul_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void gridViewClaseProveedor_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewClaseProveedor.GetRow(e.RowHandle) as cp_proveedor_clase_Info;
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

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
