using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario_Cidersus;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Reports.Produc_Cirdesus;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class Frm_Prd_ReimpresionCodigos : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Bus busSuc = new tb_Sucursal_Bus();
        tb_Bodega_Bus busBod = new tb_Bodega_Bus();
        List<tb_Sucursal_Info> sucursales = new List<tb_Sucursal_Info>();
        List<tb_Bodega_Info> bodegas = new List<tb_Bodega_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus busxItems = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_movi_inve_detalle_Bus busMovDet = new in_movi_inve_detalle_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public Frm_Prd_ReimpresionCodigos()
        {
            try
            {
               InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        List<in_movi_inve_detalle_x_Producto_CusCider_Info> items = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        private void cmbBodega_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //setear el grid
                items = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlConsulta.DataSource = items;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void dtpFechaIni_ValueChanged(object sender, EventArgs e)
        {
          try
            {
                
                //setear el grid
                items  = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlConsulta.DataSource = items; chkTodos.Checked = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }

        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {try
            {
                
                //setear el grid
                items  = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlConsulta.DataSource = items; chkTodos.Checked = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }

        }
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkTodos.Checked == true)
                {
                    items.ForEach(var => var.check = true);
                    gridCtrlConsulta .DataSource = null;
                    gridCtrlConsulta.DataSource = items;
                }
                else
                {
                    items.ForEach(var => var.check = false);
                    gridCtrlConsulta.DataSource = null;
                    gridCtrlConsulta.DataSource = items;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void mnu_salir_Click(object sender, EventArgs e)
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

        private void mnu_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
               buscar(); chkTodos.Checked = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        void buscar()
        {
            try
            {
                if (validar())
                {
                    items = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();

                    buscar_x_sucursal_x_bodega();

                    if (items.Count<=0)
                    {
                        MessageBox.Show("No se encontraron resultados para esas opciones");
                    }

                    gridCtrlConsulta.DataSource = items;
                }
                    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        string msg = "";
        in_movi_inven_tipo_Bus busTipMov = new in_movi_inven_tipo_Bus();
        in_producto_Bus busProducto = new in_producto_Bus();
        
        void buscar_x_tipomovi(int idsucursal, int idbodega,string nomsucursal, string nombodega)
        {

            try
            {
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> result = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                if (Convert.ToInt32(cmbTipMov.EditValue) == 0)
                {

                    var lsttipomov = busTipMov.Obtener_list_movi_inven_tipo_x_bodega(param.IdEmpresa, idsucursal, idbodega, "+", "N");
                    foreach (var tipo in lsttipomov)
                    {

                        if (txtNumMov.Text == string.Empty)
                            result = busxItems.Obtener_CodBarrasReimpresion(param.IdEmpresa, dtpFechaIni.Value, dtpFechaFin.Value, idsucursal,
                                   idbodega, Convert.ToDecimal(cmbProducto.EditValue), tipo.IdMovi_inven_tipo, txtCodbarra.Text, ref msg);
                        else
                            result = busxItems.Obtener_CodBarrasReimpresion(param.IdEmpresa, dtpFechaIni.Value, dtpFechaFin.Value, idsucursal,
                                idbodega, Convert.ToDecimal(cmbProducto.EditValue), tipo.IdMovi_inven_tipo, Convert.ToDecimal(txtNumMov.Text), 
                                txtCodbarra.Text, ref msg);

                        foreach (var item in result)
                        {
                            item.mvtp_descripcion = tipo.tm_descripcion;
                            item.su_descripcion = nomsucursal;
                            item.bo_descripcion = nombodega;
                            var producto = busProducto.BuscarProducto(item.IdProducto, param.IdEmpresa);
                            item.pr_descripcion = producto.pr_descripcion;
                            items.Add(item);
                        }
                    }

                }
                else
                {
                    if (txtNumMov.Text == string.Empty)
                        result = busxItems.Obtener_CodBarrasReimpresion(param.IdEmpresa, dtpFechaIni.Value, dtpFechaFin.Value, idsucursal,
                                idbodega, Convert.ToDecimal(cmbProducto.EditValue), Convert.ToInt32(cmbTipMov.EditValue), txtCodbarra.Text, ref msg);
                    else
                        result = busxItems.Obtener_CodBarrasReimpresion(param.IdEmpresa, dtpFechaIni.Value, dtpFechaFin.Value, idsucursal,
                                idbodega, Convert.ToDecimal(cmbProducto.EditValue), Convert.ToInt32(cmbTipMov.EditValue),Convert.ToDecimal(txtNumMov.Text),
                                txtCodbarra.Text, ref msg);

                    foreach (var item in result)
                    {
                        item.mvtp_descripcion = cmbTipMov.Text;
                        item.su_descripcion = nomsucursal;
                        item.bo_descripcion = nombodega;
                        var producto = busProducto.BuscarProducto(item.IdProducto, param.IdEmpresa);
                        item.pr_descripcion = producto.pr_descripcion;
                        items.Add(item);
                    }

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        void buscar_x_sucursal_x_bodega()
        {
            try
            {
                  if (Convert.ToInt32(cmbSucursal.EditValue) == 0)
                    {
                        var sucursales = busSuc.Obtener_Sucursal(param.IdEmpresa);
                        foreach (var suc in sucursales)
                        {
                            var bodegas = busBod.Obtener_Bodegas(param.IdEmpresa, suc.IdSucursal);
                            foreach (var bod in bodegas)
                            {
                                buscar_x_tipomovi(suc.IdSucursal, bod.IdBodega,suc.Su_Descripcion,bod.bo_Descripcion);   
                            }

                        }

                    }
                    else if (Convert.ToInt32(cmbBodega.EditValue) == 0)
                    {

                        var bodegas = busBod.Obtener_Bodegas(param.IdEmpresa, Convert.ToInt32(cmbSucursal.EditValue));
                        foreach (var bod in bodegas)
                        {
                            buscar_x_tipomovi(Convert.ToInt32(cmbSucursal.EditValue), bod.IdBodega,cmbSucursal.Text,bod.bo_Descripcion);
                        }

                    }
                    else
                    {
                            buscar_x_tipomovi(Convert.ToInt32(cmbSucursal.EditValue), Convert.ToInt32(cmbBodega.EditValue), cmbSucursal.Text, cmbBodega.Text);
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }
        
        private Boolean validar()
        {

            try
            {
                if (Convert.ToInt32(cmbSucursal.EditValue) == 0 && Convert.ToInt32(cmbBodega.EditValue) == 0
                    && Convert.ToInt32(cmbTipMov.EditValue) == 0 && Convert.ToDecimal(cmbProducto.EditValue) == 0
                    && txtCodbarra.Text == string.Empty)
                {
                    MessageBox.Show("Seleccione un filtro para la Búsqueda");
                    return false;
                }
                return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }
        
        private void mnu_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                imprimir();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

    /*    void imprimir1()
        {
            try
            {
                XRpt_prd_ReimpresionCodBarra XRpt_Reimpresion = new XRpt_prd_ReimpresionCodBarra();
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListadoCodBarra = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                txtCodbarra.Focus();
                var temp = (List<in_movi_inve_detalle_x_Producto_CusCider_Info>)gridCtrlConsulta.DataSource;

                foreach (var item in temp)
                {
                    if (item.check == true)
                        ListadoCodBarra.Add(item);
                }

                if (ListadoCodBarra.Count > 0)
                {

                    prd_ObtenerReporte_Bus busRpt = new prd_ObtenerReporte_Bus();
                    List<tbPRD_Rpt_RPRD001_Info> listData = new List<tbPRD_Rpt_RPRD001_Info>();
                    foreach (var item in ListadoCodBarra)
                    {
                        tbPRD_Rpt_RPRD001_Info info = new tbPRD_Rpt_RPRD001_Info();
                        info.CodigoBarra = item.CodigoBarra;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        info.Fecha_Transac = item.cm_fecha;
                        info.IdSucursal = item.IdSucursal;
                        info.IdNumMovi = item.IdNumMovi;
                        info.Secuencia = item.Secuencia;
                        info.IdProducto = item.IdProducto;
                        info.IdBodega = item.IdBodega;
                        info.pr_descripcion = item.pr_descripcion;
                        listData.Add(info);
                    }

                    listData = busRpt.ObtenerData_ReimpresionCodigo(listData, param.IdUsuario, param.nom_pc);


                    XRpt_Reimpresion.loadData(listData.ToArray(), "");
                    XRpt_Reimpresion.ShowPreviewDialog();

                }
                else {
                    MessageBox.Show("No tiene seleccionado ningún codigos de barra a imprimir");
                }
            }
            catch (Exception ex)
            {
                
                
            }
        }*/


        void imprimir()
        {
            try
            {
                XRpt_prd_ReimpresionCodBarra XRpt_Reimpresion = new XRpt_prd_ReimpresionCodBarra();
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListadoCodBarra = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                txtCodbarra.Focus();
                var temp = (List<in_movi_inve_detalle_x_Producto_CusCider_Info>)gridCtrlConsulta.DataSource;

                foreach (var item in temp)
                {
                    if (item.check == true)
                        ListadoCodBarra.Add(item);
                }

                if (ListadoCodBarra.Count > 0)
                {
                    XRpt_Reimpresion.loadData(ListadoCodBarra.ToArray(), "");
                    XRpt_Reimpresion.ShowPreviewDialog();

                }
                else
                {
                    MessageBox.Show("No tiene seleccionado ningún codigos de barra a imprimir");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }
        private void Frm_Prd_ReimpresionCodigos_Load(object sender, EventArgs e)
        {
            try
            {
                cargacombos();
                dtpFechaIni.Value = DateTime.Now.AddDays(-30);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void cargacombos()
        {
            try
            {
                sucursales = busSuc.Obtener_Sucursal(param.IdEmpresa, Cl_Enumeradores.eTipoFiltro.todos);
                if (sucursales != null || sucursales.Count > 0)
                {
                    cmbSucursal.Properties.DataSource = sucursales;
                    cmbSucursal.EditValue = sucursales[0].IdSucursal;
                }

                in_producto_Bus busProd = new in_producto_Bus();
                List<in_Producto_Info> productos = new List<in_Producto_Info>();
                
                productos  = busProd.Obtener_listProductoManejaSeries(param.IdEmpresa);
                in_Producto_Info prod = new in_Producto_Info();
                prod.pr_descripcion = "Todos";
                prod.IdProducto = 0;
                productos.Add(prod);
                cmbProducto.Properties.DataSource = productos;
                cmbProducto.EditValue = 0;

                in_movi_inven_tipo_Bus busTipMov = new in_movi_inven_tipo_Bus();
                List<in_movi_inven_tipo_Info> LstTipMov = new List<in_movi_inven_tipo_Info>();
                LstTipMov = busTipMov.Obtener_list_movi_inven_tipo(param.IdEmpresa,"+","N","Todos");
                cmbTipMov.Properties.DataSource = LstTipMov;
                cmbTipMov.EditValue = 0;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }


        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {


                if (Convert.ToInt32(cmbSucursal.EditValue) <= 0)
                {
                    cmbBodega.Properties.DataSource = null;
                }
                else
                {
                    bodegas = busBod.Obtener_Bodegas(param.IdEmpresa, Convert.ToInt32(cmbSucursal.EditValue));
                    if (bodegas != null)
                    {
                        tb_Bodega_Info bod = new tb_Bodega_Info();
                        bod.bo_Descripcion = "TODAS LAS BODEGAS";
                        bod.IdBodega = 0;
                        bodegas.Add(bod);
                        cmbBodega.Properties.DataSource = bodegas;

                    }

                }

                //setear el grid
                items  = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlConsulta.DataSource = items; chkTodos.Checked = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        private void cmbBodega_EditValueChanged_1(object sender, EventArgs e)
        {

            try
            {
                
                //setear el grid
                items  = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlConsulta.DataSource = items; chkTodos.Checked = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }

        private void cmbTipMov_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                //setear el grid
                items = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlConsulta.DataSource = items; chkTodos.Checked = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void cmbProducto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                //setear el grid
                items = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlConsulta.DataSource = items; chkTodos.Checked = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void txtCodbarra_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //setear el grid
                items = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlConsulta.DataSource = items; chkTodos.Checked = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void txtNumMov_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //setear el grid
                items = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlConsulta.DataSource = items;
                chkTodos.Checked = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void gridVwConsulta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridVwConsulta.GetRow(e.RowHandle) as in_movi_inve_detalle_x_Producto_CusCider_Info;
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

    }
}
