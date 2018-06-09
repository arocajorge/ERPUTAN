using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Facturacion;
using Core.Erp.Winform.Inventario;

//vewrsion 24062013 1627
namespace Core.Erp.Winform.Inventario_Cidersus
{
    public partial class UCInv_Grid_Movi_Detalle : UserControl
    {
        int flag = 0;

        public enum eTipoMovi
        {
            Ingreso = 1,
            Egreso = 2
        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_uGrid_Pedido_det_AfterCellUpdate(object sender, EventArgs e);
        public event delegate_uGrid_Pedido_det_AfterCellUpdate Event_uGrid_Pedido_det_AfterCellUpdate;

    
    
        public Boolean VisiblePeso { get; set; }
        public Boolean VisibleStock { get; set; }
        public Boolean VisibleStockAnterior { get; set; }
        public Boolean VisibleCosto { get; set; }
        public Boolean VisibleCodigo { get; set; }

        public Boolean VisibleCodBarra { get; set; }
        public Boolean  VisibleBusCodBarra { get; set; }

        public int idBodega { get; set; }
        public int idSucursal { get; set; }
        public int idInvMov { get; set; }
        public decimal idproducto { get; set; }


        public UCInv_Grid_Movi_Detalle()
        {
            try
            {
                 InitializeComponent();
                
                frm.Event_FrmIn_CodigoBarra_Busqueda_FormClosing+=new FrmIn_CodigoBarra_Busqueda.Delegate_FrmIn_CodigoBarra_Busqueda_FormClosing(frm_Event_FrmIn_CodigoBarra_Busqueda_FormClosing);
                Event_uGrid_Pedido_det_AfterCellUpdate += new delegate_uGrid_Pedido_det_AfterCellUpdate(UCInv_Grid_Movi_Detalle_Event_uGrid_Pedido_det_AfterCellUpdate);
                
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }

        
        void UCInv_Grid_Movi_Detalle_Event_uGrid_Pedido_det_AfterCellUpdate(object sender, EventArgs e){}

        
        public eTipoMovi _tipomovi { get; set; }
        public void tipomoviser(eTipoMovi tip)
        {
            try
            {
                _tipomovi = tip;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }





        DataTable dt = new DataTable("detalle");

        List<in_Producto_Info> Lista_producto = new List<in_Producto_Info>();

        DataTable TablaProducto = new DataTable("Productos");
        DataTable TablaProducto2 = new DataTable("Productos2");
        DataTable TablaCodBarra = new DataTable("CodBarra");
        in_producto_Bus bus_producto = new in_producto_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        in_producto_Bus _ProductoBus = new in_producto_Bus();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstInfoCodB = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus BUsCodB = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        FrmIn_CodigoBarra_Busqueda frm = new FrmIn_CodigoBarra_Busqueda();
        in_Producto_Info Productoinfo = new in_Producto_Info();
    

        private void load_grid()
        {
            try
            {
                dt.Columns.Add("Codigo_Producto", typeof(string));
                dt.Columns.Add("Producto", typeof(string));

                dt.Columns.Add("Peso", typeof(double));
                dt.Columns.Add("Cantidad", typeof(int));
                dt.Columns.Add("Costo", typeof(double));
                dt.Columns.Add("Stock Actual", typeof(double));
                dt.Columns.Add("Stock Anterior", typeof(double));
                dt.Columns.Add("Observacion", typeof(string));
                dt.Columns.Add("idProducto", typeof(string));
                dt.Columns.Add("CodBarra", typeof(string));
                dt.AcceptChanges();
               // this.ultraGridMinvDetalle.DataSource = dt;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Nueva_fila()
        {
            try
            {
                DataRow filas;
                filas = dt.NewRow();
                dt.Rows.Add(filas);
                dt.AcceptChanges();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }




        private void creaTabla(List<in_Producto_Info> Lista, ref DataTable tablaNCombo)
        {
            try
            {
                dt = new DataTable("detalle");
                tablaNCombo.Columns.Add("Codigo_Producto", typeof(string));


                


                DataColumn des = new DataColumn("Descripcion", typeof(string));
                des.Caption = "Descripcion                                                             .";

                tablaNCombo.Columns.Add(des);
                tablaNCombo.Columns.Add("Stock_General");
                tablaNCombo.Columns.Add("Stock");
                tablaNCombo.Columns.Add("Pedidos");
                tablaNCombo.Columns.Add("Disponibles", typeof(double));
                tablaNCombo.Columns.Add("PVP", typeof(double));
                tablaNCombo.Columns.Add("Precio_Mayor", typeof(double));
                tablaNCombo.Columns.Add("Precio_Minimo", typeof(double));
                tablaNCombo.Columns.Add("productInfo", typeof(object));
                tablaNCombo.Columns.Add("idProducto", typeof(int));
                tablaNCombo.Columns.Add("idBodega", typeof(int));
                tablaNCombo.Columns.Add("idSucursal", typeof(int));
                tablaNCombo.Columns.Add("CodBarra", typeof(string));
                
                


                foreach (var item in Lista)
                {
                    DataRow filas;
                    filas = tablaNCombo.NewRow();
                    filas[0] = item.pr_codigo;
                    filas[1] = item.pr_descripcion;
                    filas[2] = item.pr_stock;
                    filas[3] = item.pr_stock;
                    filas[4] = item.pr_pedidos;
                    filas[5] = item.pr_stock - item.pr_pedidos;
                    filas[6] = item.pr_precio_publico;
                    filas[7] = item.pr_precio_mayor;
                    filas[8] = item.pr_precio_minimo;
                    filas[9] = item;
                    filas[10] = item.IdProducto;
                    filas[11] = item.IdBodega;
                    filas[12] = item.IdSucursal;
                    filas[13] = item.CodBarra;

                    tablaNCombo.Rows.Add(filas);

                    tablaNCombo.AcceptChanges();
                }



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }


        public void load_Producto()
        {
            try
            {

                Lista_producto = _ProductoBus.Get_list_Producto(param.IdEmpresa, idSucursal, idBodega);
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                lista = Lista_producto;
                TablaProducto = new DataTable("Productos");


                creaTabla(lista, ref TablaProducto);

                
               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        
        private void UCInv_grid_movi_detalle_Load(object sender, EventArgs e)
        {
            try
            {
                load_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }




        }
        private Boolean Existe_Stock_Producto_Bodega(string cod_producto, ref string msg, ref double cantidad)
        {
            try
            {
                var q = from A in Lista_producto
                        where A.pr_codigo.Contains(cod_producto.Trim())
                        select A;
                if (q.ToList().Count > 0)
                {
                    foreach (var item in q)
                    {
                        cantidad = item.pr_stock == null ? 0 : Convert.ToDouble(item.pr_stock);
                    }
                    msg = "Stock disponible: " + cantidad.ToString();


                    return true;
                }
                else
                {
                    msg = "No existe la cantidad suficiente en stock";
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                msg = "Mensaje de Error: " + ex.Message;
                return false;
            }
        }
        

        public int getrows_data()
        {
            int filas = 0;
            try
            {
                //for (int i = 0; i < ultraGridMinvDetalle.Rows.Count; i++)
                //{
                //    if (ultraGridMinvDetalle.Rows[i].Cells[0].Text != "")
                //        filas++;
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            return filas;
        }

        //public int getrows_grid()
        //{
        //    try
        //    {
        //       // return ultraGridMinvDetalle.Rows.Count;
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        return -1;
        //    }
        //}

        
        public void CargaDatosAgrid(in_Producto_Info tmp, int fila)
        {
            try
            {

        
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //public void CargaDatosAgrid(in_movi_inve_detalle_x_Producto_CusCider_Info dettmp, int fila)
        //{
        //    try
        //    {
        //        in_Producto_Info tmp = new in_Producto_Info();
        //        if (_tipomovi == eTipoMovi.Egreso)
        //        {
        //            tmp = bus_producto.BuscarProducto(dettmp.IdProducto, dettmp.IdEmpresa);
                    
        //            this.ultraGridMinvDetalle.Rows[fila].Cells[8].Value = dettmp.IdProducto;
        //            this.ultraGridMinvDetalle.Rows[fila].Cells[0].Value = tmp.pr_codigo;
        //            this.ultraGridMinvDetalle.Rows[fila].Cells[1].Value = tmp.pr_descripcion;
        //            this.ultraGridMinvDetalle.Rows[fila].Cells[2].Value = tmp.pr_peso;
        //            if (dettmp.CodigoBarra != "")
        //                this.ultraGridMinvDetalle.Rows[fila].Cells[3].Value = 1;
        //            else
        //                this.ultraGridMinvDetalle.Rows[fila].Cells[3].Value = 0;
        //            this.ultraGridMinvDetalle.Rows[fila].Cells[4].Value = tmp.pr_costo_promedio;
        //            this.ultraGridMinvDetalle.Rows[fila].Cells[5].Value = tmp.pr_stock;
        //            this.ultraGridMinvDetalle.Rows[fila].Cells[6].Value = tmp.pr_stock;
        //            this.ultraGridMinvDetalle.Rows[fila].Cells[7].Value = " "; flag = 1;
        //            this.ultraGridMinvDetalle.Rows[fila].Cells[9].Value = dettmp.CodigoBarra;
        //        } flag = 1;

        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        
        
        void frm_Event_gridVwCodBarra_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var Info = (in_movi_inve_detalle_x_Producto_CusCider_Info)sender;
                if (Info != null && Info.CodigoBarra != "")
                { funcion(Info); } 
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void frm_Event_FrmIn_CodigoBarra_Busqueda_FormClosing(object sender, FormClosingEventArgs e, in_movi_inve_detalle_x_Producto_CusCider_Info Info)
        {
            try
            {
                if (Info != null&&Info.CodigoBarra !="")
                { funcion(Info); }  //validarepetidos(); }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        
        
        

        
        void funcion(in_movi_inve_detalle_x_Producto_CusCider_Info CBar)
        {
            try
            {
                //int fila = ultraGridMinvDetalle.ActiveRow.Index;
                //if (fila != -1)
                //{
                //    //in_Producto_Info tmp = new in_Producto_Info();
                //    //DataRowView tb;
                //    //tb = (DataRowView)ucmb_productos.SelectedRow.ListObject;

                //    //tmp = (in_Producto_Info)tb.Row.ItemArray[9];
                //    CargaDatosAgrid(CBar, fila);
                    
                    
                //    if (getrows_data() == getrows_grid())
                //    {
                //        Nueva_fila();
                //    }                   
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        

      
        public void ultraGridMinvDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //if (ultraGridMinvDetalle.ActiveCell.Column.Index == 3)
                //{
                //    if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                //    {
                //        e.Handled = false;
                //    }
                //    else
                //    {
                //        e.Handled = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        
        private void ucmb_productos_Validating(object sender, CancelEventArgs e){}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        
        public List<in_movi_inve_detalle_Info> get_DatosGrid()
        {
            List<in_movi_inve_detalle_Info> lss = new List<in_movi_inve_detalle_Info>();

            try
            {
           
                //for (int i = 0; i < ultraGridMinvDetalle.Rows.Count -1 ; i++)
                //{
                //    in_movi_inve_detalle_Info moviInfo = new in_movi_inve_detalle_Info();
                //    moviInfo.IdEmpresa = param.IdEmpresa;
                //    moviInfo.dm_cantidad = Convert.ToDouble(this.ultraGridMinvDetalle.Rows[i].Cells[3].Value);
                //    moviInfo.mv_costo = Convert.ToDouble(this.ultraGridMinvDetalle.Rows[i].Cells[4].Value);
                //    moviInfo.dm_stock_ante = Convert.ToDouble(this.ultraGridMinvDetalle.Rows[i].Cells[5].Value);
                //    moviInfo.dm_stock_actu = Convert.ToDouble(this.ultraGridMinvDetalle.Rows[i].Cells[6].Value);
                //    moviInfo.dm_observacion = this.ultraGridMinvDetalle.Rows[i].Cells[7].Value.ToString();
                //    moviInfo.IdProducto = Convert.ToInt32(this.ultraGridMinvDetalle.Rows[i].Cells[8].Value);
                //    moviInfo.CodBarra = Convert.ToString (this.ultraGridMinvDetalle.Rows[i].Cells[9].Value);
                    
                //    lss.Add(moviInfo);


                //}
                return lss;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<in_movi_inve_detalle_Info>();
            }
        }

        public void set_Datosgrid(List<in_movi_inve_detalle_Info> dats)
        {
            try
            {
                in_movi_inve_detalle_Bus oBus = new in_movi_inve_detalle_Bus();

                dt.Clear();
                foreach (var item in dats)
                {
                    DataRow filas;
                    in_movi_inve_detalle_Info dtos = new in_movi_inve_detalle_Info();

                    filas = dt.NewRow();

                    filas[0] = item.IdProducto;
                    filas[1] = item.IdProducto;
                    filas[2] = item.peso;
                    filas[3] = item.dm_cantidad;
                    filas[6] = item.dm_stock_ante;
                    filas[5] = item.dm_stock_actu;
                    filas[4] = item.mv_costo;
                    filas[7] = item.dm_observacion;
                    filas[8] = item.IdProducto;
                    filas[9] = item.CodBarra;
                    ////////////////////////////////////////////////////////////

                    ////////////////////////////////////////////////////////////
                    dt.Rows.Add(filas);



                }
                Nueva_fila();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        public void set_Datosgrid(in_Producto_Info tmp)
        {
            try
            {
                 decimal id = tmp.IdProducto;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public void LimpiarGrid()
        {
            try
            {
                dt.Clear();
                load_grid();
                Nueva_fila();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e){ }

        
        
        void validarepetidos()
        {

            try
            {
                List<in_movi_inve_detalle_Info> Lst = new List<in_movi_inve_detalle_Info>();
              //  ucmb_productos.Focus();
                Lst = get_DatosGrid();
                if (Lst.Count > 0 || Lst != null)
                {
                    //var select = from C in Lst.GroupBy
                    //             (i=> i).Select 
                    //             (i=> new{Barra= i.Key.CodBarra,Produc = i.Key.IdProducto, 
                    //             Count = i.Count()});


                    var Select = from C in Lst
                                 group C by new { C.IdProducto, C.NomProducto, C.CodBarra }
                                     into grp
                                     select new
                                     {
                                         producto = grp.Key,
                                         Count = grp.Count()

                                     };
                    foreach (var item in Select)
                    {
                        if (item.Count > 1)
                        {
                            MessageBox.Show("Verifique los productos. Producto Repetido: "
                                + item.producto.NomProducto + "Codigo de Barra: " +
                                item.producto.CodBarra, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                           // ultraGridMinvDetalle.ActiveRow.Delete();
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

    
    
    }
}
