using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Facturacion
{ 
    public partial class frmFa_Secuencia_Documento_Talonario_Consulta : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        ////fa_Secuencia_Documento_Talonario_Bus busDocTalo = new fa_Secuencia_Documento_Talonario_Bus();
        ////fa_Secuencia_Documento_Talonario_Info info = new fa_Secuencia_Documento_Talonario_Info();

        //tb_sis_Documento_Tipo_Talonario_Bus busDocTalo = new tb_sis_Documento_Tipo_Talonario_Bus();
        //tb_sis_Documento_Tipo_Talonario_Info info = new tb_sis_Documento_Tipo_Talonario_Info();


        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        #endregion

        public frmFa_Secuencia_Documento_Talonario_Consulta()
        {
            try
            {
                InitializeComponent();
                //ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                //ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                //ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                //ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        //void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        //void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        frmFa_Secuencia_Documento_Talonario_Mant frm = new frmFa_Secuencia_Documento_Talonario_Mant();
        //        frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
        //        if (info.DocInicial == null) { MessageBox.Show("Seleccione un Registro"); ; return; }
        //        frm.info = info;

        //        frm.listaDocTalo = (List<fa_Secuencia_Documento_Talonario_Info>)gridConsulta.DataSource;
        //        //frm.ultraCmbE_TipoDoc.Enabled = false;
               
        //        frm.panel1.Enabled = false;
        //        frm.ShowDialog();
        //        cargar();
        //        info = new fa_Secuencia_Documento_Talonario_Info();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        //void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        frmFa_Secuencia_Documento_Talonario_Mant frm = new frmFa_Secuencia_Documento_Talonario_Mant();
        //        frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
        //        if (info == null) { return; }
        //        frm.info = info;
        //        frm.ShowDialog();
        //        info = new fa_Secuencia_Documento_Talonario_Info();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        //void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        frmFa_Secuencia_Documento_Talonario_Mant frm = new frmFa_Secuencia_Documento_Talonario_Mant();
        //        frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
        //        frm.listaDocTalo = (List<fa_Secuencia_Documento_Talonario_Info>)gridConsulta.DataSource;
        //        frm.ShowDialog(); cargar();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}
    
        private void frmFA_Secuencia_Documento_Talonario_Consulta_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    cargar();
            //}
            //catch (Exception ex)
            //{
            //    Log_Error_bus.Log_Error(ex.ToString());
            //}
        }

        //public void cargar() 
        //{
        //    try
        //    {
        //        gridConsulta.DataSource = busDocTalo.Get_List_fa_Secuencia_Documento_Talonario(param.IdEmpresa);
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        //private void gridViewConsulta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        //{
        //    try
        //    {
        //        var data = gridViewConsulta.GetRow(e.RowHandle) as fa_Secuencia_Documento_Talonario_Info;
        //        if (data == null)
        //            return;

        //        if (data.Estado == "I")
        //        {
        //            e.Appearance.ForeColor = Color.Red;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        //private fa_Secuencia_Documento_Talonario_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        //{
        //    try
        //    {
        //        return (fa_Secuencia_Documento_Talonario_Info)view.GetRow(view.FocusedRowHandle);
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        return new fa_Secuencia_Documento_Talonario_Info();
        //    }
        //}

        //private void gridViewConsulta_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    try
        //    {
        //        info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());

        //    }
        //}
  
    }
}
