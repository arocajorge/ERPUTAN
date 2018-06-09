using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Business.Caja;
using Core.Erp.Info.Caja;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Winform.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.Inventario;


namespace Core.Erp.Winform.Controles
{
    public partial class UCCxc_Parametros : UserControl
    {
        #region Declaración de variables
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Bus sucursal_B = new tb_Sucursal_Bus();
        List<ct_Cbtecble_tipo_Info> lstCbte = new List<ct_Cbtecble_tipo_Info>();
        ct_Cbtecble_tipo_Bus busTipo = new ct_Cbtecble_tipo_Bus();
        caj_Caja_Movimiento_Tipo_Bus caja_B = new caj_Caja_Movimiento_Tipo_Bus();
        List<caj_Caja_Movimiento_Tipo_Info> lstMoviCaja = new List<caj_Caja_Movimiento_Tipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<fa_TipoNota_Info> lstTipoNota = new List<fa_TipoNota_Info>();
        fa_TipoNota_Bus TipoNota_B = new fa_TipoNota_Bus();
        caj_Caja_Bus Caja_B = new caj_Caja_Bus();
        tb_Bodega_Info Bodega_I = new tb_Bodega_Info();
        in_Producto_Info Producto_I = new in_Producto_Info();
        cxc_parametro_Info param_I = new cxc_parametro_Info();
        cxc_parametro_Bus param_B = new cxc_parametro_Bus();
        cxc_cobro_tipo_Bus CobroBus = new cxc_cobro_tipo_Bus();
        List<cxc_cobro_tipo_Info> CobroInfo = new List<cxc_cobro_tipo_Info>();
        #endregion
        
        public UCCxc_Parametros()
        {
            InitializeComponent();
            
            try 
	        {
                lstTipoNota = TipoNota_B.Get_List_TipoNota(param.IdEmpresa);
                gridLookUpEdit_tipoNotaD.Properties.DataSource = lstTipoNota.FindAll(c => c.Estado=="A" && c.Tipo == "D");
                

                gridLookUpEdit_caja.Properties.DataSource = Caja_B.Get_list_caja(param.IdEmpresa, ref  MensajeError).FindAll(c=> c.Estado=="A");
               
                lstMoviCaja = caja_B.Get_list_Caja_Movimiento_Tipo(param.IdEmpresa,Cl_Enumeradores.eTipo_Ing_Egr.INGRESOS, ref MensajeError);
                gridLookUpEdit_tipoMovCaja.Properties.DataSource = lstMoviCaja.FindAll(c => c.Estado == "A" && c.IngEgr == "Ingreso");
                lstCbte = busTipo.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);


                repositoryItemGridLookUpEdit_sucursal.DataSource = sucursal_B.Get_List_Sucursal(param.IdEmpresa).FindAll(c=> c.Estado==true);

                CobroInfo = CobroBus.Get_List_Cobro_Tipo();
                gridLookUpEdit_TipoCobroTarjeta.Properties.DataSource = CobroInfo;
                gridLookUpEdit_TipoCobroDefault.Properties.DataSource = CobroInfo;
            }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
	        }
        }
        
        void llamaFR_Bodega()
        {
            try
            {
                var c = gridView_ParamXCheqProtesto.GetFocusedRowCellValue(colpa_IdSucursal_x_default_x_cheqProtes);
                
                if (c == null)
                {
                    MessageBox.Show("Antes de Seleccionar la Bodega debe seleccionar la Sucursal..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmFa_Bodega_Consulta fr = new frmFa_Bodega_Consulta(param.IdEmpresa,Convert.ToInt32(c));
                    fr.ShowDialog();
                    Bodega_I = fr.Bodega_I;
                    if (Bodega_I != null)
                    {
                        limpiarCell("bodega");
                        gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colpa_IdBodega_x_default_x_cheqProtes, Bodega_I.IdBodega);
                        gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colBodega, Bodega_I.bo_Descripcion);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        void llamaFR_Producto(string col)
        {
            try
            {
                var c = gridView_ParamXCheqProtesto.GetFocusedRowCellValue(colpa_IdSucursal_x_default_x_cheqProtes);
                var d=gridView_ParamXCheqProtesto.GetFocusedRowCellValue(colpa_IdBodega_x_default_x_cheqProtes);
               
                if (c == null)
                {
                    MessageBox.Show("Antes de Seleccionar el Producto debe seleccionar la Sucursal..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(d==null)
                {
                    MessageBox.Show("Antes de Seleccionar el Producto debe seleccionar la Bodega..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FrmIn_ProductoConsultaXBodega fr = new FrmIn_ProductoConsultaXBodega(param.IdEmpresa,Convert.ToInt32(d), Convert.ToInt32(c));
                    fr.ShowDialog();
                    Producto_I = fr.Producto_I;
                    if (Producto_I!=null)
                        if (col == "NC")
                        {
                            gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colpa_IdProducto_x_NC_x_Cobro, Producto_I.IdProducto);
                            gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colProductoNC, Producto_I.pr_descripcion);
                        }
                        else if (col == "ND")
                        {
                            gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colpa_IdProducto_x_ND_x_CheqProtes, Producto_I.IdProducto);
                            gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colProductoND, Producto_I.pr_descripcion);
                        }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        void limpiarCell(string cell)
        {
            try
            {
                if (cell=="sucursal")
                {
                    gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colpa_IdBodega_x_default_x_cheqProtes, 0);
                    gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colBodega,"");
                    gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colpa_IdProducto_x_NC_x_Cobro, 0);
                    gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colProductoNC,"");
                    gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colpa_IdProducto_x_ND_x_CheqProtes, 0);
                    gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colProductoND,"");
                }
                else if (cell=="bodega")
                {
                    gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colpa_IdProducto_x_NC_x_Cobro, 0);
                    gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colProductoNC, "");
                    gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colpa_IdProducto_x_ND_x_CheqProtes, 0);
                    gridView_ParamXCheqProtesto.SetFocusedRowCellValue(colProductoND, "");
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void repositoryItemButtonEdit_Bodega_Click(object sender, EventArgs e)
        {
            try
            {
                   llamaFR_Bodega();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
 
        }

        private void repositoryItemButtonEdit_Bodega_Enter(object sender, EventArgs e)
        {
            try
            {
               llamaFR_Bodega();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        private void repositoryItemButtonEdit_Producto_Click(object sender, EventArgs e)
        {
            try
            {
                llamaFR_Producto("NC");
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        private void repositoryItemButtonEdit_Producto_Enter(object sender, EventArgs e)
        {
            try
            {
                llamaFR_Producto("NC");
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        private void repositoryItemButtonEdit_ProductoND_Enter(object sender, EventArgs e)
        {
            try
            {
               llamaFR_Producto("ND");
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        private void repositoryItemButtonEdit_ProductoND_Click(object sender, EventArgs e)
        {
            try
            {
               llamaFR_Producto("ND");
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        private void gridView_ParamXCheqProtesto_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colpa_IdSucursal_x_default_x_cheqProtes")
                    limpiarCell("sucursal");
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
               Grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        public void Grabar()
        {
            try
            {
                gridLookUpEdit_tipoNotaD.Focus();
                if (validar())
                {
                    get_paramCXC();
                    if (param_B.GuardarDB(param_I))
                    {
                        MessageBox.Show("Parametros de Cuentas por Cobrar ingresados con Exito");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Guardar los parametros de Cuentas por Cobrar", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        bool validar()
        {
            try 
	        {
                if (gridLookUpEdit_tipoNotaD.EditValue == "")
                {
                    MessageBox.Show("Seleccione el Tipo de nota de debito para cheque protestado ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (gridLookUpEdit_TipoCbteCbleConcilia.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Seleccione el Tipo de Comprobante Contable que Genera Conciliacion ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (gridLookUpEdit_TipoCobroTarjeta.EditValue == "")
                {
                    MessageBox.Show("Seleccione el Tipo de Cobro de Comision de la Tarjeta de Credito ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
	        }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
                return false;
	        }
        }

        public void set_paramCXC()
        {
            try
            {
                param_I=param_B.Get_Info_parametro(param.IdEmpresa);
                gridLookUpEdit_tipoNotaD.EditValue=param_I.pa_tipoND_x_CheqProtestado;
                gridLookUpEdit_caja.EditValue=param_I.pa_IdCaja_x_cobros_x_CXC;
                gridLookUpEdit_tipoMovCaja.EditValue=param_I.pa_IdTipoMoviCaja_x_Cobros_x_cliente;
                gridLookUpEdit_tipoCbte.set_TipoCbteCble(param_I.pa_IdTipoCbteCble_CxC);
                gridLookUpEdit_tipoCbteAnu.set_TipoCbteCble(param_I.pa_IdTipoCbteCble_CxC_ANU);                
                gridLookUpEdit_TipoCbteCbleConcilia.set_TipoCbteCble(Convert.ToInt32(param_I.pa_IdTipoCbte_x_conciliacion));
                gridLookUpEdit_TipoCobroTarjeta.EditValue = param_I.pa_IdCobro_tipo_Comision_TC;
                gridLookUpEdit_TipoCobroDefault.EditValue = param_I.pa_IdCobro_tipo_default;
                set_ParamCheqProtesto(param_I.LstParamProtesto);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public void set_ParamCheqProtesto(List<cxc_Parametros_x_cheqProtesto_Info> lst)
        {
            try
            {
                if (lst != null)
                {
                    gridView_ParamXCheqProtesto.SelectAll();
                    gridView_ParamXCheqProtesto.DeleteSelectedRows();

                    BindingList<cxc_Parametros_x_cheqProtesto_Info> sd = new BindingList<cxc_Parametros_x_cheqProtesto_Info>(lst);
                    gridControl_ParamXCheqProtesto.DataSource = sd;

                    int focus = gridView_ParamXCheqProtesto.FocusedRowHandle;
                    gridView_ParamXCheqProtesto.FocusedRowHandle = focus + 1;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public void get_paramCXC()
        {
            try
            {
                List<cxc_Parametros_x_cheqProtesto_Info> LstParamGuardar = new List<cxc_Parametros_x_cheqProtesto_Info>();
                
                param_I.IdEmpresa = param.IdEmpresa;
                
                param_I.pa_tipoND_x_CheqProtestado = (gridLookUpEdit_tipoNotaD.EditValue!="")?Convert.ToInt32(gridLookUpEdit_tipoNotaD.EditValue):0;
                param_I.pa_IdCaja_x_cobros_x_CXC =(gridLookUpEdit_caja.EditValue!="")?Convert.ToInt32(gridLookUpEdit_caja.EditValue):0;
                param_I.pa_IdTipoMoviCaja_x_Cobros_x_cliente =(gridLookUpEdit_tipoMovCaja.EditValue!="")?Convert.ToInt32(gridLookUpEdit_tipoMovCaja.EditValue):0;
                param_I.pa_IdTipoCbteCble_CxC = gridLookUpEdit_tipoCbte.get_TipoCbteCble().IdTipoCbte;
                param_I.pa_IdTipoCbteCble_CxC_ANU = gridLookUpEdit_tipoCbteAnu.get_TipoCbteCble().IdTipoCbte;

                param_I.pa_IdTipoCbte_x_conciliacion = gridLookUpEdit_TipoCbteCbleConcilia.get_TipoCbteCble().IdTipoCbte;
                param_I.IdUsuarioUltMod = param.IdUsuario;
                param_I.FechaUltMod = param.Fecha_Transac;

                param_I.pa_IdCobro_tipo_Comision_TC = (gridLookUpEdit_TipoCobroTarjeta.EditValue != "") ? Convert.ToString(gridLookUpEdit_TipoCobroTarjeta.EditValue) : null;
                param_I.pa_IdCobro_tipo_default = (gridLookUpEdit_TipoCobroDefault.EditValue != "") ? Convert.ToString(gridLookUpEdit_TipoCobroDefault.EditValue) : null; 
                for (int i = 0; i < gridView_ParamXCheqProtesto.RowCount - 1; i++)
                {
                    cxc_Parametros_x_cheqProtesto_Info info = (cxc_Parametros_x_cheqProtesto_Info)gridView_ParamXCheqProtesto.GetRow(i);                    
                    if (info != null)
                    {
                        info.IdEmpresa = param.IdEmpresa;                        
                        LstParamGuardar.Add(info);
                    }
                }
                param_I.LstParamProtesto = new List<cxc_Parametros_x_cheqProtesto_Info>();
                param_I.LstParamProtesto = LstParamGuardar;
                set_ParamCheqProtesto(LstParamGuardar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void UCCXC_Parametros_Load(object sender, EventArgs e){}

        private void gridView_ParamXCheqProtesto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea Eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_ParamXCheqProtesto.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit_tipoNotaD_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

 

    }
}
