using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Importacion;
using Core.Erp.Business.General;
using Core.Erp.Winform.Importacion;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_GastosImportacion_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        imp_ordencompra_ext_x_imp_gastosxImport_Bus Bus = new imp_ordencompra_ext_x_imp_gastosxImport_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmImp_GastosImportacion_Mant ofrm = new frmImp_GastosImportacion_Mant();
        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        public frmImp_GastosImportacion_Consulta()
        {
            try
            {
                 InitializeComponent();
                ofrm.Event_frmImp_RegistroGastosImportacion_Mant_FormClosing += new frmImp_GastosImportacion_Mant.Delegate_frmImp_RegistroGastosImportacion_Mant_FormClosing(ofrm_Event_frmImp_RegistroGastosImportacion_Mant_FormClosing);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
         
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmImp_GastosImportacion_Mant();
                ofrm.SetAccion(Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.MdiParent = this.MdiParent;
                ofrm.SetAccion(Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.Event_frmImp_RegistroGastosImportacion_Mant_FormClosing += new frmImp_GastosImportacion_Mant.Delegate_frmImp_RegistroGastosImportacion_Mant_FormClosing(ofrm_Event_frmImp_RegistroGastosImportacion_Mant_FormClosing);
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlOrdeGastos.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmImp_GastosImportacion_Mant();
                ofrm.Event_frmImp_RegistroGastosImportacion_Mant_FormClosing += new frmImp_GastosImportacion_Mant.Delegate_frmImp_RegistroGastosImportacion_Mant_FormClosing(ofrm_Event_frmImp_RegistroGastosImportacion_Mant_FormClosing);
                ofrm.SetAccion(Erp.Info.General.Cl_Enumeradores.eTipo_action.consultar);
                ofrm._SetInfo = Info;
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                ofrm = new frmImp_GastosImportacion_Mant();
                ofrm.Event_frmImp_RegistroGastosImportacion_Mant_FormClosing += new frmImp_GastosImportacion_Mant.Delegate_frmImp_RegistroGastosImportacion_Mant_FormClosing(ofrm_Event_frmImp_RegistroGastosImportacion_Mant_FormClosing);
                ofrm.SetAccion(Erp.Info.General.Cl_Enumeradores.eTipo_action.Anular);
                ofrm._SetInfo = Info;
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ofrm_Event_frmImp_RegistroGastosImportacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

  

        public void CargarGrid()
        {
            try
            {

                DateTime FechaIni = Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_desde);
                DateTime FechaFin = Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
                gridControlOrdeGastos.DataSource = Bus.Get_List_ordencompra_ext_x_imp_gastosxImpor(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        imp_ordencompra_ext_x_imp_gastosxImport_Info Info = new imp_ordencompra_ext_x_imp_gastosxImport_Info();
        private void gridViewPedidos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = (imp_ordencompra_ext_x_imp_gastosxImport_Info)gridViewGastos.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }


        private void frmImp_GastosImportacion_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }

        }

        private void gridViewGastos_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = (imp_ordencompra_ext_x_imp_gastosxImport_Info)gridViewGastos.GetRow(e.RowHandle);
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }



       
    }
}
