using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_OperadorConsulta : Form
    {
        public FrmPrd_OperadorConsulta()
        {
            InitializeComponent();
        }


        #region Declaracion Variable
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<prd_Operador_Info> ListadoOperadores = new BindingList<prd_Operador_Info>();
        prd_Operador_Info Info = new prd_Operador_Info();
        prd_Operador_Bus BusOperador = new prd_Operador_Bus();
        #endregion


        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmPrd_Operador_Mantenimiento frm = new FrmPrd_Operador_Mantenimiento();
                frm.set_Acccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.MdiParent = this.MdiParent;
                frm.GedIdOperador();
                frm.Show();
                // frm.event_FrmPrd_ObraMantemiento_FormClosing += frm_event_FrmPrd_ObraMantemiento_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }



        public void CargarGrid()
        {
            try
            {
                ListadoOperadores= new BindingList<prd_Operador_Info>( BusOperador.ListadoOperadores());
                gridControlOperador.DataSource = ListadoOperadores;
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void FrmPrd_OperadorConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmPrd_Operador_Mantenimiento frm = new FrmPrd_Operador_Mantenimiento();
                frm.set_Acccion(Cl_Enumeradores.eTipo_action.actualizar);
                frm.Text = frm.Text + " ***EDITAR REGISTRO***";
                frm.set_Info(Info);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                // frm.event_FrmPrd_ObraMantemiento_FormClosing += frm_event_FrmPrd_ObraMantemiento_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void gridViewOperador_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                Info = (prd_Operador_Info)gridViewOperador.GetFocusedRow();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void gridViewOperador_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewOperador.GetRow(e.RowHandle) as prd_Operador_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmPrd_Operador_Mantenimiento frm = new FrmPrd_Operador_Mantenimiento();
                frm.set_Acccion(Cl_Enumeradores.eTipo_action.consultar);
                frm.Text = frm.Text + " ***CONSULTA REGISTRO***";
                frm.set_Info(Info);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                // frm.event_FrmPrd_ObraMantemiento_FormClosing += frm_event_FrmPrd_ObraMantemiento_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmPrd_Operador_Mantenimiento frm = new FrmPrd_Operador_Mantenimiento();
                frm.set_Acccion(Cl_Enumeradores.eTipo_action.Anular);
                frm.Text = frm.Text + " ***ELIMINAR REGISTRO***";
                frm.set_Info(Info);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                // frm.event_FrmPrd_ObraMantemiento_FormClosing += frm_event_FrmPrd_ObraMantemiento_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
    }
}
