using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Genera_Guia_x_Traspaso_Cons_Fj : Form
    {

        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;

        FrmIn_Genera_Guia_x_Traspaso_Mant_Fj frm = new FrmIn_Genera_Guia_x_Traspaso_Mant_Fj();

        in_Guia_x_traspaso_bodega_Bus busGuiaTrasp = new in_Guia_x_traspaso_bodega_Bus();

        in_Guia_x_traspaso_bodega_Info InfoGuia = new in_Guia_x_traspaso_bodega_Info();
        #endregion

        public FrmIn_Genera_Guia_x_Traspaso_Cons_Fj()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoGuia = (in_Guia_x_traspaso_bodega_Info)gridViewGuiaCons.GetFocusedRow();
                if (InfoGuia != null)
                {
                    if (InfoGuia.Estado != "I")
                    {
                        frm = new FrmIn_Genera_Guia_x_Traspaso_Mant_Fj();
                        frm._SetInfo = InfoGuia;
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular); frm.MdiParent = this.MdiParent;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        //frm.event_frmGuia_Traspaso_FormClosing += frm_event_frmGuia_Traspaso_FormClosing;
                    }
                    else
                        MessageBox.Show("El registro seleccionado ya se encuentra anulado.\nPor favor seleccione otro registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoGuia = (in_Guia_x_traspaso_bodega_Info)gridViewGuiaCons.GetFocusedRow();
                if (InfoGuia != null)
                {
                    if (InfoGuia.Estado == "I")
                    {
                        MessageBox.Show("No se pueden modificar registros inactivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                    else
                    {
                        FrmIn_Genera_Guia_x_Traspaso_Mant_Fj frm = new FrmIn_Genera_Guia_x_Traspaso_Mant_Fj();
                        frm._SetInfo = InfoGuia;
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar); frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
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

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         try
            {
                frm = new FrmIn_Genera_Guia_x_Traspaso_Mant_Fj();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.Show(); frm.MdiParent = this.MdiParent;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex )
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cargagrid()
        {
            try
            {
                List<in_Guia_x_traspaso_bodega_Info> LstOC = new List<in_Guia_x_traspaso_bodega_Info>();
                LstOC = busGuiaTrasp.Get_List_Guia_x_traspaso_bodega(param.IdEmpresa, ucGe_Menu.fecha_desde, ucGe_Menu.fecha_hasta);
                gridControlGuiaCons.DataSource = LstOC;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoGuia = (in_Guia_x_traspaso_bodega_Info)gridViewGuiaCons.GetFocusedRow();
                if (InfoGuia != null)
                {
                    frm = new FrmIn_Genera_Guia_x_Traspaso_Mant_Fj();
                    frm._SetInfo = InfoGuia;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar); frm.MdiParent = this.MdiParent;
                    frm.Show();

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

        private void FrmIn_Genera_Guia_x_Traspaso_Cons_Fj_Load(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gridViewGuiaCons_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewGuiaCons.GetRow(e.RowHandle) as in_Guia_x_traspaso_bodega_Info;
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
