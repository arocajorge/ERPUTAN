using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using Cus.Erp.Reports.Naturisa.CuentasxPagar;

//DEREK MEJIA 17/03/2014
//Modificado por Pedro Salinas 08/04/2016
namespace Core.Erp.Winform.CuentasxPagar
{    

    public partial class frmCP_ImprimirRetencionLote : DevExpress.XtraEditors.XtraForm
    {
        cp_proveedor_Bus proveedorBus = new cp_proveedor_Bus();
        cp_catalogo_Bus catalogoBus = new cp_catalogo_Bus();
        List<cp_proveedor_Info> proveedorInfoList = new List<cp_proveedor_Info>();
        List<cp_catalogo_Info> catalogoInfoList = new List<cp_catalogo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string TipodeCatalogo = "T_IMPR_RET";
        vwcp_Retenciones_x_tipo_impresion_Bus impresionBus = new vwcp_Retenciones_x_tipo_impresion_Bus();
        BindingList<vwcp_Retenciones_x_tipo_impresion_Info> impresionInfoBL = new BindingList<vwcp_Retenciones_x_tipo_impresion_Info>();
        vwcp_Retenciones_x_tipo_impresion_Info impresionInfo = new vwcp_Retenciones_x_tipo_impresion_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //DEREK MEJIA 20/03/2014
        cp_retencion_Bus retencionBus = new cp_retencion_Bus();       
        cp_retencion_Info retencionInfo = new cp_retencion_Info();
        int inicio = 0;
        int IdProveedor = 0;

        public frmCP_ImprimirRetencionLote()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void frmCP_ImprimirRetencionLote_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void load() {
            try
            {
                proveedorInfoList = new List<cp_proveedor_Info>();
                proveedorInfoList = proveedorBus.Get_List_proveedor(param.IdEmpresa);                                

                //cmbProveedor.Properties.DataSource = proveedorInfoList;
                
                catalogoInfoList = new List<cp_catalogo_Info>();
                catalogoInfoList = catalogoBus.Get_List_catalogo(TipodeCatalogo);
                cmbEstado.Properties.DataSource = catalogoInfoList;
                cmbEstado.EditValue = "NO IMPRESO";

                CargarGrillaGeneral();

                DateTime Fecha = DateTime.Now.Date;
                Fecha = Fecha.AddMonths(+1);
                dtpDesde.EditValue = DateTime.Now.Date;
                dtpHasta.EditValue = Fecha;

               
                UC_Retencion.IdEstablecimiento = "001";
                UC_Retencion.IdPuntoEmision = "001";
                UC_Retencion.Get_Ult_Documento_no_usado();

                inicio = 1;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                    IdProveedor = 0;
                else
                    IdProveedor = Convert.ToInt32(ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);
                //{
                    CargarGrilla();
                    chkAplicarGrilla.Checked = false;
                    inicio = 2;
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarGrilla() 
        {
            try
            {
                IdProveedor = (ucCp_Proveedor1.get_ProveedorInfo() == null) ? 0 : Convert.ToInt32(ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);
                impresionInfoBL = new BindingList<vwcp_Retenciones_x_tipo_impresion_Info>(impresionBus.Get_List_Retenciones_x_tipo_impresion(param.IdEmpresa, IdProveedor, Convert.ToDateTime(dtpDesde.EditValue), Convert.ToDateTime(dtpHasta.EditValue), Convert.ToString(cmbEstado.EditValue)));
                                
                foreach (var item in impresionInfoBL)
                {                    
                    item.Ico = (Bitmap)imageList1.Images[0];
                    item.chek = false;
                    item.FechaRT = Convert.ToDateTime(dtp_fechaEmisionRetencion.Text).Date;
                }
                gridControlIretención.DataSource = impresionInfoBL;

             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarConCheckGrilla() {
            try
            {
                IdProveedor = (ucCp_Proveedor1.get_ProveedorInfo() == null) ? 0 : Convert.ToInt32(ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);
                impresionInfoBL = new BindingList<vwcp_Retenciones_x_tipo_impresion_Info>(impresionBus.Get_List_Retenciones_x_tipo_impresion(param.IdEmpresa, IdProveedor, Convert.ToDateTime(dtpDesde.EditValue), Convert.ToDateTime(dtpHasta.EditValue), Convert.ToString(cmbEstado.EditValue)));                
                int cont = 0;
                int inicio = 1;
                int numero = Convert.ToInt32(UC_Retencion.txtNumDoc.Text);
                
                for (int i = 0; i < UC_Retencion.txtNumDoc.Text.Length; i++)
                {
                    if (UC_Retencion.txtNumDoc.Text.Substring(i, 1) == "0")
                        cont++;
                    else
                        i = UC_Retencion.txtNumDoc.Text.Length;
                }
                foreach (var item in impresionInfoBL)
                {
                    string cadena = "";
                    item.Ico = (Bitmap)imageList1.Images[0];
                    item.chek = false;
                    item.FechaRT = Convert.ToDateTime(dtp_fechaEmisionRetencion.Text).Date;
                    //item.NAutorizacion = UC_Retencion.txtAutorizacion.Text;

                    item.serie = Convert.ToString(UC_Retencion.txe_Serie.EditValue);
                    if (inicio == 1)
	                {
                        item.NumRetencion = UC_Retencion.txtNumDoc.Text;
                        inicio++;
                    }
                    else
                    {
                        numero = numero + 1;
                        for (int i = 0; i < cont; i++)
                        {
                            cadena = cadena + Convert.ToString(0);
                        }
                        cadena = cadena + numero;
                        item.NumRetencion = cadena;                        
                    }
                    
                }
                gridControlIretención.DataSource = impresionInfoBL;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        public void CargarGrillaGeneral() {
            try
            {
                impresionInfoBL = new BindingList<vwcp_Retenciones_x_tipo_impresion_Info>(impresionBus.Get_List_Retenciones_x_tipo_impresion(param.IdEmpresa, Convert.ToString(cmbEstado.EditValue)));

                foreach (var item in impresionInfoBL)
                {
                    item.Ico = (Bitmap)imageList1.Images[0];
                    item.chek = false;
                    item.FechaRT = Convert.ToDateTime(dtp_fechaEmisionRetencion.Text).Date;
                }
                gridControlIretención.DataSource = impresionInfoBL;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEstado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(cmbEstado.EditValue) == "IMPRESO")                
                    groupBox3.Visible = false;
                else
                    groupBox3.Visible = true;
                chkAplicarGrilla.Checked = false;
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewIretención_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                impresionInfo = new vwcp_Retenciones_x_tipo_impresion_Info();
                impresionInfo = (vwcp_Retenciones_x_tipo_impresion_Info)gridViewIretención.GetFocusedRow();

                if (e.HitInfo.Column.Name == "colchek")
                {
                    foreach (var item in impresionInfoBL)
                    {
                        if (item.IdProveedor == impresionInfo.IdProveedor && item.NumCbteCXP == impresionInfo.NumCbteCXP && item.IdRetencion == impresionInfo.IdRetencion)
                        {
                            if (item.chek == true)                                                     
                                gridViewIretención.SetFocusedRowCellValue(colchek,false);
                            else                                                    
                                gridViewIretención.SetFocusedRowCellValue(colchek, true);                            
                        }
                    }
                }

                if (e.HitInfo.Column.Name == "colIco")
                {
                    
                        XCXP_NATU_Rpt005_Rpt reporte = new XCXP_NATU_Rpt005_Rpt();

                        reporte.set_parametros(Convert.ToInt32(impresionInfo.IdEmpresa), Convert.ToDecimal(impresionInfo.IdCbteCble_Ogiro), Convert.ToInt32(impresionInfo.IdTipoCbte_Ogiro));
                        reporte.RequestParameters = true;
                        reporte.ShowPreviewDialog();
                 
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dtpDesde_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpHasta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkTodos.Checked == true)
                {
                    foreach (var item in impresionInfoBL)
                    {
                        item.chek = true;
                    }
                }
                else
                {
                    foreach (var item in impresionInfoBL)
                    {
                        item.chek = false;
                    }
                }
                gridControlIretención.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp_fechaEmisionRetencion_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        string mensaje = "";
      
        public Boolean ActualizarTabla() {
            try
            {
                string nombreProveedor = "";
                foreach (var item in proveedorInfoList)
	            {
                    IdProveedor = (ucCp_Proveedor1.get_ProveedorInfo() == null) ? 0 : Convert.ToInt32(ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);
                    if (IdProveedor == item.IdProveedor)
	                {
		                nombreProveedor = item.responsable;
                        break;
	                }
	            }
                foreach (var item in impresionInfoBL)
                {
                    if (item.chek == true && item.sImpresion=="NO IMPRESO")
                    {
                        item.sImpresion = "IMPRESO";                        
                        retencionInfo = new cp_retencion_Info();
                        retencionInfo.IdEmpresa = item.IdEmpresa;
                        retencionInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        retencionInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        retencionInfo.IdRetencion = item.IdRetencion;
                        retencionInfo.fecha = item.co_FechaFactura;
                        retencionInfo.NAutorizacion = item.NAutorizacion;
                       // retencionInfo.serie = Convert.ToString(UC_Retencion.txe_Serie.EditValue);

                        retencionInfo.serie1 = item.serie.Substring(0, 3);
                        retencionInfo.serie2 = item.serie.Substring(4, 3);
                        retencionInfo.NumRetencion = item.NumRetencion;
                        retencionInfo.IdUsuario = param.IdUsuario;
                        retencionInfo.IdUsuarioUltAnu = null;
                        retencionInfo.observacion = "Ret. x prove:" + nombreProveedor;

                        retencionInfo.re_EstaImpresa = "S";

                        retencionBus.Modificar_Num_Retencion(retencionInfo, ref mensaje );
                    }                    
                    //retencionInfoL.Add(retencionInfo);
                }
                gridControlIretención.RefreshDataSource();
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        
        }

        public void limpiar() {
            try
            {
                //CargarGrillaGeneral();
                if (inicio == 2)
                {
                   impresionInfoBL = new BindingList<vwcp_Retenciones_x_tipo_impresion_Info>();
                   gridControlIretención.DataSource = impresionInfoBL; 
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkAplicarGrilla_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (impresionInfoBL != null)
                {
                    if (chkAplicarGrilla.Checked == true)
                    {
                        CargarConCheckGrilla();
                    }
                    else
                    {
                        CargarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("No se han cargado datos.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnImpLote_Click(object sender, EventArgs e)
        {
            try
            {
                if (impresionInfoBL.Count == 0 || impresionInfoBL == null)
                {
                    MessageBox.Show("No existen registros cargados en la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Boolean verdad = false;

                int focus = gridViewIretención.FocusedRowHandle;
                gridViewIretención.FocusedRowHandle = focus + 1;


                foreach (var item in impresionInfoBL)
                {
                    if (item.chek == true)
                    {
                        verdad = true;
                    }
                }
                if (verdad == false)
                {
                    MessageBox.Show("Seleccione un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var item in impresionInfoBL)
                {
                    if (item.chek == true)
                    {
                        if (item.serie == null)
                        {
                            MessageBox.Show("Ingrese la serie de Retención", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;

                        }

                        if (item.NumRetencion == null)
                        {
                            MessageBox.Show("Ingrese el nùmero de Retención", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;

                        }
                    }
                }

                if (ActualizarTabla())
                    MessageBox.Show("Se imprimió con éxito", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se imprimieron los registros", "Operación no Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            if (ucCp_Proveedor1.get_ProveedorInfo() != null)
                CargarGrilla();
            else
                CargarGrillaGeneral();
        }
    }
}