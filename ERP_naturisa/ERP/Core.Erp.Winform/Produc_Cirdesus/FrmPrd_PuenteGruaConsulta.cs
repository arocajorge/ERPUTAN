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
    public partial class FrmPrd_PuenteGruaConsulta : Form
    {

        #region Declaracion Variable
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<prd_PuenteGrua_Info> ListadoPuenteGrua = new BindingList<prd_PuenteGrua_Info>();
        prd_PuenteGrua_Info Info = new prd_PuenteGrua_Info(); 
        prd_PuenteGrua_Bus BusPuenteGrua = new prd_PuenteGrua_Bus();
        #endregion

        public FrmPrd_PuenteGruaConsulta()
        {
            InitializeComponent();
        }

        private void FrmPrd_PuenteGruaConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrilla();
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info.idEmpresa == 0)
                {
                    MessageBox.Show("Seleccione un Registro");
                    return;

                }
                FrmPrd_PuenteGruaMantenimiento frm = new FrmPrd_PuenteGruaMantenimiento();
                frm.set_Acccion(Cl_Enumeradores.eTipo_action.consultar);
                frm.Text = frm.Text + " ***EDITAR REGISTRO***";
                frm.set_Info(Info);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_FrmPrd_PuenteGruaMantenimiento_FormClosing += frm_event_FrmPrd_PuenteGruaMantenimiento_FormClosing;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmPrd_PuenteGruaMantenimiento frm = new FrmPrd_PuenteGruaMantenimiento();
                frm.set_Acccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.GetId();
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

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info.idEmpresa == 0)
                {
                    MessageBox.Show("Seleccione un Registro");
                    return;

                }
                FrmPrd_PuenteGruaMantenimiento frm = new FrmPrd_PuenteGruaMantenimiento();
                frm.set_Acccion(Cl_Enumeradores.eTipo_action.actualizar);
                frm.Text = frm.Text + " ***EDITAR REGISTRO***";
                frm.set_Info(Info);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_FrmPrd_PuenteGruaMantenimiento_FormClosing += frm_event_FrmPrd_PuenteGruaMantenimiento_FormClosing;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        void frm_event_FrmPrd_PuenteGruaMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrilla();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
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
                Log_Error_bus.Log_Error(ex.Message);
               
            }
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }



        public void CargarGrilla()
        {
            try
            {
                ListadoPuenteGrua =new BindingList<prd_PuenteGrua_Info>( BusPuenteGrua.ListadoPuenteGrua(param.IdEmpresa));
                gridControlPuenteGrua.DataSource = ListadoPuenteGrua;
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                 Info = (prd_PuenteGrua_Info)gridViewPuenteGrua.GetFocusedRow();
                
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void gridViewPuenteGrua_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewPuenteGrua.GetRow(e.RowHandle) as prd_PuenteGrua_Info;
                if (data == null)
                    return;
                if (data.estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
