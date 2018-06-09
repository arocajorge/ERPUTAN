using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Produc_Cirdesus;
using DevExpress.XtraPrinting;
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class frmPrd_Trazabilidad : Form
    {

        //variables declaradas
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus busProducto = new in_producto_Bus();
        in_Producto_Info producto = new in_Producto_Info();

        List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstItems = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus busItems = new in_movi_inve_detalle_x_Producto_CusCider_Bus();

        public frmPrd_Trazabilidad()
        {
            try
            {
               InitializeComponent();
               ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
               ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
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

        
        

        in_marca_bus busmarca = new in_marca_bus();
        in_ProductoTipo_Bus bustipo = new in_ProductoTipo_Bus();
        in_categorias_bus buscateg = new in_categorias_bus();
        private  Boolean traerproducto()
        {
            try
            {
                if (txtCodigoBarra.Text != string.Empty)
                {
                    var mov_items = (in_movi_inve_detalle_x_Producto_CusCider_Info)busItems.TraeProductoxCodigoBarra(txtCodigoBarra.Text, param.IdEmpresa);


                     txtMarca.Text = mov_items.Marca;
                    txtId.Text = Convert.ToString(producto.IdProducto);
                     txtObservacion.Text = mov_items.pr_observacion;
                     txtCodigo.Text = mov_items.pr_codigo;
                    txtPeso.Text = Convert.ToString(mov_items.pr_peso);
                    txtObservacion.Text = mov_items.pr_Observacion;
                    txtCategoria.Text = mov_items.ca_Categoria;
                    txtpr_descripcion.Text = mov_items.pr_descripcion;
                    txtBodega.Text = mov_items.bo_descripcion;
                    TxtSucursal.Text = mov_items.su_descripcion;
                    txtCategoria.Text = mov_items.ca_Categoria;
                    txtTipo.Text = mov_items.tp_descripcion;
                    txtMarca.Text = mov_items.Marca;
                    return true;
                }
                else
                {
                    MessageBox.Show("Verifique Codigo Barra");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;

            }
        }

        void setearenblanco()
        {
            try
            {
                txtMarca.Text = "";
                txtId.Text = "";
                txtObservacion.Text = "";
                txtCodigo.Text = "";
                txtPeso.Text = "";
                txtTipo.Text = "";
                txtCategoria.Text = "";
                txtpr_descripcion.Text = "";

                gridCtrlTrazabilidad.DataSource = null;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        void buscarHistorico()
        {

            try
            {
                if (txtId.Text != string.Empty)
                {

                    LstItems = busItems.ReimpresionCodigoBarra(txtCodigoBarra.Text, param.IdEmpresa);
                    gridCtrlTrazabilidad.DataSource = LstItems;
                }
                else {
                    MessageBox.Show("Por favor verifique el código ingresado.");
                               
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        
        }
        private void btnBuscar_Click(object sender, EventArgs e){}

        
        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    setearenblanco();
                    if (traerproducto())
                        buscarHistorico();
                }
                else {
                    setearenblanco();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
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
                gridVwTrazabilidad.ViewCaption = "Trazabilidad del Producto: "+txtpr_descripcion.Text  + " Cód: "
                    + txtCodigo.Text+
                    " Cód Barra: "+txtCodigoBarra.Text;
                fte = new System.Drawing.Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point);
                gridVwTrazabilidad.Appearance.ViewCaption.Font  = fte;
                printableComponentLink1.Component = gridCtrlTrazabilidad;
                printableComponentLink1.ShowPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                setearenblanco();
                if (traerproducto())
                    buscarHistorico();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
