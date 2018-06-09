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
using Core.Erp.Info.Inventario ;
using Core.Erp.Business.Inventario ;
using Core.Erp.Business.Inventario_Cidersus;
using DevExpress.XtraPrinting;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_Kardex : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Bus busSuc = new tb_Sucursal_Bus();
        tb_Bodega_Bus busBod = new tb_Bodega_Bus();
        List<tb_Sucursal_Info> sucursales = new List<tb_Sucursal_Info>();
        List<tb_Bodega_Info> bodegas = new List<tb_Bodega_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus busxItems = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_movi_inve_detalle_Bus busMovDet = new in_movi_inve_detalle_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Boolean BusqxCodBarra;
        string msg = "";
        double existencia = 0;
        in_producto_Bus busProd = new in_producto_Bus();
        List<in_Producto_Info> productos = new List<in_Producto_Info>();

        List<in_Producto_Info> LstCodbar = new List<in_Producto_Info>();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> items = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                in_movi_inve_detalle_x_Producto_CusCider_Info saldoinicial = new in_movi_inve_detalle_x_Producto_CusCider_Info();

                List<in_movi_inve_detalle_x_Producto_CusCider_Info> kardex = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();

        public FrmPrd_Kardex()
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

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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
    
        private void FrmPrd_Kardex_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                dtpFechaIni.Value = DateTime.Now.AddDays(-30);
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
                    
                    if (bodegas != null)
                    {
                        tb_Bodega_Info bod = new tb_Bodega_Info();
                        bod.bo_Descripcion = "TODAS LAS BODEGAS";
                        bod.IdBodega = 0;
                        bodegas.Add(bod);
                        cmbBodega.Properties.DataSource = bodegas; }

                }
                //setear el grid
                kardex = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlKardex.DataSource = kardex;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }
            
        private List<in_movi_inve_detalle_x_Producto_CusCider_Info> agregarsaldoskardex(int tipo, List<in_movi_inve_detalle_x_Producto_CusCider_Info> kardex)
        {

            try
            {
                in_movi_inve_detalle_x_Producto_CusCider_Info saldo = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                if (tipo == 0)//saldo inicial
                {
                    List<in_movi_inve_detalle_x_Producto_CusCider_Info> temporalkardex = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                    temporalkardex = kardex;
                    kardex = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
               
                    saldo.dm_observacion = "Saldo Inicial";
                    saldo.cm_fecha = dtpFechaIni.Value;
                    saldo.existencia = existencia;
                    saldo.mv_tipo_movi = "";
                    kardex.Add(saldo);


                    foreach (var item in temporalkardex)
                    {
                        kardex.Add(item);
                    }
                }
                else { //saldo  final

                    saldo.dm_observacion = "Saldo Final";
                    saldo.cm_fecha = dtpFechaFin.Value;
                    saldo.existencia = existencia; saldo.mv_tipo_movi = "";
                    kardex.Add(saldo);
                
                
                }
                return kardex;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
            }
        }

        private List<in_movi_inve_detalle_x_Producto_CusCider_Info> calcularexistencia(List<in_movi_inve_detalle_x_Producto_CusCider_Info> kardex)
        {
            try
            {
                foreach (var item in kardex)
                {
                    if (item.mv_tipo_movi.Trim() == "+")
                    {
                        item.existencia = existencia = existencia  + item.entrada;
                    }
                    else if (item.mv_tipo_movi.Trim() == "-")
                    {

                        item.existencia = existencia =  existencia + item.salida;
                    }
                }
                return kardex;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                
            }
        }

       
        void buscar(int idsucursal, int idbodega)
        {
            try
            {

                var itemsinCb = busxItems.GetKardexConsultaCidersus(param.IdEmpresa, param.IdSucursal, Convert.ToInt32(cmbBodega.EditValue), Convert.ToInt32(cmbProducto.EditValue), dtpFechaIni.Value, dtpFechaFin.Value);

            //    var saldo = busMovDet.Obtener_Saldo_x_Prod_x_Fecha(param.IdEmpresa, dtpFechaIni.Value, idsucursal, idbodega, Convert.ToDecimal(cmbProducto.EditValue), ref msg);

                if (itemsinCb.Count > 0)
                {
                    gridCtrlKardex.DataSource = itemsinCb;
                }
                else
                {
                    MessageBox.Show("NO UBIERON DATOS QUE MOSTRAR PARA LA CONSULTA");
                    gridCtrlKardex.DataSource = itemsinCb;
                    gridCtrlKardex.RefreshDataSource();
                }



            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
            }
        }       
        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e) //es boton guardar hay que cambiar
        
        {
            
        }
        private void gridVwKardex_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
            var data = (in_movi_inve_detalle_x_Producto_CusCider_Info )gridVwKardex.GetRow(e.RowHandle);
                            if( data != null)
                            {
                                if (data.dm_observacion == "Saldo Inicial")
                                {
                                    e.Appearance.Font = new Font("Bold",9);
                       
                                }
                                else if (data.dm_observacion == "Saldo Final")
                                {
                                    e.Appearance.Font = new Font("Bold", 9);
                                    e.Appearance.BackColor = Color.LemonChiffon;
                                }
                
                            }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }
        private void cmbBodega_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //setear el grid
                kardex = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlKardex.DataSource = kardex;
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
                kardex = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlKardex.DataSource = kardex;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //setear el grid
                kardex = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                gridCtrlKardex.DataSource = kardex;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }



         private void ucGe_Menu_Superior_Mant1_event_btnImpFrm_Click(object sender, EventArgs e)
         {

         }

         private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
         {

         }

         private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             try
             {
                 this.Close();
             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }
         }

         private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             try
             {
                 buscar(Convert.ToInt32( cmbSucursal.EditValue),Convert.ToInt32( cmbBodega.EditValue));
                            
             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }

         }



         public void CargarCombos()
         {
             try
             {
                 sucursales = busSuc.Get_List_Sucursal_Todos(param.IdEmpresa);
                 if (sucursales != null || sucursales.Count > 0)
                 {
                     cmbSucursal.Properties.DataSource = sucursales;
                     cmbSucursal.EditValue = sucursales[0].IdSucursal;
                 }
                 productos = busProd.Get_list_Producto(param.IdEmpresa);
                 cmbProducto.Properties.DataSource = productos;
                 cmbBodega.Properties.DataSource = busBod.Get_List_Bodega(param.IdEmpresa, Convert.ToInt32(cmbSucursal.EditValue));
             }
             catch (Exception ex)
             {
                 
                 MessageBox.Show(ex.Message);
             }
         }

         private void ucGe_Menu_Load(object sender, EventArgs e)
         {

         }

         private void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             try
             {
                 //gridControlObra.ShowPrintPreview();
                 string leftColumn = "Fecha: [Date Printed][Time Printed]";
                 string middleColumn = "Página:[Page # of Pages #]";
                 string rightColumn = "Usuario:" + param.IdUsuario;

                 // Create a PageHeaderFooter object and initializing it with
                 // the link's PageHeaderFooter.

                 PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;

                 // Clear the PageHeaderFooter's contents.
                 phf.Header.Content.Clear();
                 phf.Footer.Content.Clear();
                 Font fte = new System.Drawing.Font("Tahoma", 8.5f, FontStyle.Bold, GraphicsUnit.Point);

                 // Add custom information to the link's header.
                 phf.Header.Font = fte;
                 phf.Footer.Font = fte;
                 phf.Header.Content.AddRange(new string[] { leftColumn, "", rightColumn, "hola" });
                 phf.Header.LineAlignment = BrickAlignment.Center;
                 phf.Footer.Content.AddRange(new string[] { "", "", middleColumn });
                 phf.Footer.LineAlignment = BrickAlignment.Center;
                 printableComponentLink1.Landscape = true;
                 printableComponentLink1.Component = gridCtrlKardex;

             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
             }
            
         }

         private void cmbProducto_EditValueChanged(object sender, EventArgs e)
         {

         }
    }
}
