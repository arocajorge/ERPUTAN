using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Business.General;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;


namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_ProgramaProd_Consulta : Form
    {

        #region Declaracion de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prod_ProgramaProd_Bus Bus_Programa = new prod_ProgramaProd_Bus();
        prod_ProgramaProd_Info Info_Programa = new prod_ProgramaProd_Info();
        List<prod_ProgramaProd_Info> Lista = new List<prod_ProgramaProd_Info>();
        #endregion


        public frmProd_ProgramaProd_Consulta()
        {
            try
            {
                InitializeComponent();
                ucGe_Men_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Men_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Men_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Men_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Men_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Men_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Men_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Men_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Men_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Men_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Men_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Men_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Men_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Men_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }          
        }



        void ucGe_Men_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Men_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info_Programa = (prod_ProgramaProd_Info)gridViewProgramaP.GetFocusedRow();
                if (Info_Programa == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info_Programa.Estado == "I")
                    MessageBox.Show("El Programa de Prod#: " + Info_Programa.IdProgramaProd + " ya fue anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmProd_ProgramaProd_Mant frm = new frmProd_ProgramaProd_Mant();
                    frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.Text = frm.Text + " ***ANULAR REGISTRO***";
                    frm.Show(); frm.set(Info_Programa);
                    frm.event_frmProd_ProgramaProd_Mant_FormClosing += frm_event_frmProd_ProgramaProd_Mant_FormClosing;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        void ucGe_Men_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridCtrPrograma.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Men_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                carga_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Men_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info_Programa = (prod_ProgramaProd_Info)gridViewProgramaP.GetFocusedRow();
                if (Info_Programa == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmProd_ProgramaProd_Mant frm = new frmProd_ProgramaProd_Mant();
                    frm.setAccion(Cl_Enumeradores.eTipo_action.consultar); frm.MdiParent = this.MdiParent;
                    frm.set(Info_Programa);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        void ucGe_Men_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info_Programa = (prod_ProgramaProd_Info)gridViewProgramaP.GetFocusedRow();
                if (Info_Programa == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmProd_ProgramaProd_Mant frm = new frmProd_ProgramaProd_Mant();
                    frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.set(Info_Programa);
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show();
                    frm.event_frmProd_ProgramaProd_Mant_FormClosing += frm_event_frmProd_ProgramaProd_Mant_FormClosing;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        void ucGe_Men_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info_Programa = new prod_ProgramaProd_Info();
                frmProd_ProgramaProd_Mant frm = new frmProd_ProgramaProd_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_frmProd_ProgramaProd_Mant_FormClosing += frm_event_frmProd_ProgramaProd_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }



        private void frmProd_ProgramaProd_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
              
                carga_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }           
        }

        private void carga_data()
        {
            try
            {
                Lista = new List<prod_ProgramaProd_Info>();
                Lista = Bus_Programa.ConsultaGeneral(param.IdEmpresa, ucGe_Men_Mantenimiento_x_usuario.fecha_desde, ucGe_Men_Mantenimiento_x_usuario.fecha_hasta);
                gridCtrPrograma.DataSource = Lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());   
            }            
        }    

        private void gridViewProgramaP_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewProgramaP .GetRow(e.RowHandle) as prod_ProgramaProd_Info;
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
         

        void frm_event_frmProd_ProgramaProd_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              carga_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
  
    }
}
