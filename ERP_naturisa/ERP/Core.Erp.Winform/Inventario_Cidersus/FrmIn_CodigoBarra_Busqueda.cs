using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Inventario_Cidersus;

namespace Core.Erp.Winform.Inventario_Cidersus
{
    public partial class FrmIn_CodigoBarra_Busqueda : Form
    {
        //declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
        List<in_Producto_Info> LstProducto = new List<in_Producto_Info>();
        in_producto_Bus BusProducto = new in_producto_Bus();
        List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> SaldosCBarra = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> LStCodBarra = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus BusCodBarra = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_Producto_Info Producto = new in_Producto_Info();
        int IdSucursal = 0;
        int IdBodega = 0;

        //delegados
        public delegate void Delegate_FrmIn_CodigoBarra_Busqueda_FormClosing(object sender, FormClosingEventArgs e, in_movi_inve_detalle_x_Producto_CusCider_Info info);
        public event Delegate_FrmIn_CodigoBarra_Busqueda_FormClosing Event_FrmIn_CodigoBarra_Busqueda_FormClosing;
        private void FrmIn_CodigoBarra_Busqueda_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                //info = (in_movi_inve_detalle_x_Producto_CusCider_Info)gridVwCodBarra.GetFocusedRow();
                //info.ot_CodObra = "";
                Event_FrmIn_CodigoBarra_Busqueda_FormClosing(sender, e, info);
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
            
            
        }


        public FrmIn_CodigoBarra_Busqueda()
        {
            try
            {
                InitializeComponent();
                this.BtnSeleccionar.Visible = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

            
        }
        private void FrmIn_CodigoBarra_Busqueda_Load(object sender, EventArgs e)
        {
            try
            {
                 Event_gridVwCodBarra_DoubleClick += FrmIn_CodigoBarra_Busqueda_Event_gridVwCodBarra_DoubleClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public delegate void delegate_gridVwCodBarra_DoubleClick(object sender, EventArgs e);
        public event delegate_gridVwCodBarra_DoubleClick Event_gridVwCodBarra_DoubleClick;

        private void gridVwCodBarra_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                info = (in_movi_inve_detalle_x_Producto_CusCider_Info)gridVwCodBarra.GetFocusedRow();
                Prod_CB = info;
                Event_gridVwCodBarra_DoubleClick(info, e);
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        void FrmIn_CodigoBarra_Busqueda_Event_gridVwCodBarra_DoubleClick(object sender, EventArgs e){}

        public void loadproducto(int idsucursal, int idbodega)
        {

            try
            {
               List<in_Producto_Info> tempLstProd = new List<in_Producto_Info>();
                IdSucursal = idsucursal;
                IdBodega = idbodega;
                tempLstProd = BusProducto.Get_list_Producto(param.IdEmpresa, IdSucursal, IdBodega);
                SaldosCBarra = BusCodBarra.SaldosxItemsxCodBarra(param.IdEmpresa,DateTime.Now,1,1);

              

                var select2 = from C in tempLstProd
                              join B in SaldosCBarra
                              on new { C.IdEmpresa, C.IdSucursal, C.IdBodega, C.IdProducto }
                              equals new { B.IdEmpresa, B.IdSucursal, B.IdBodega, B.IdProducto }
                              
                              where C.IdEmpresa == param.IdEmpresa
                                     && C.IdBodega == idbodega
                                     && C.IdSucursal == idsucursal
                                     
                            select new { C.IdEmpresa, C.IdSucursal, C.IdBodega, C.IdProducto,C.pr_descripcion , B.dm_cantidad};

                
                foreach (var item in select2  )
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.IdProducto = item.IdProducto;
                    info.pr_descripcion = item.pr_descripcion ;

                    LstProducto.Add(info);
                }

                var select3 = from CB in LstProducto
                              group CB by new { CB.IdEmpresa, CB.IdProducto , CB.IdBodega, CB.IdSucursal };

                LstProducto = new List<in_Producto_Info>();
                foreach (var item in select3)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.IdBodega = item.Key.IdBodega;
                    info.IdProducto = item.Key.IdProducto;
                    info.pr_descripcion = BusProducto.Get_DescripcionTot_Producto(info.IdEmpresa, info.IdProducto);
                    LstProducto.Add(info);
                }

                //cmbProducto.DataSource = LstProducto;
                //cmbProducto.DisplayMember = "Producto";
                //cmbProducto.ValueMember = "IdProducto";

                _cmbProducto.Properties.DataSource = LstProducto;
                _cmbProducto.Properties.DataSource = "Producto";
                _cmbProducto.Properties.DataSource = "IdProducto";

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        
        
        }
        
        public void setparametros(int idsucursal, int idbodega)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
           
        
        }

        //private void cmbProducto_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbProducto.Value != null)
        //        {
                    
        //                 int sec=0;
        //            Producto.IdProducto  = (decimal)cmbProducto.Value;
        //            LStCodBarra = BusCodBarra.TraeCodBarraxProd(param.IdEmpresa, Producto.IdProducto);
                    

        //            var select2 = from C in LStCodBarra
        //                          join B in SaldosCBarra
        //                          on new { C.IdEmpresa, C.IdSucursal, C.IdBodega, C.IdProducto, C.CodigoBarra}
        //                          equals new { B.IdEmpresa, B.IdSucursal, B.IdBodega, B.IdProducto ,B.CodigoBarra}
        //                          where B.dm_cantidad >0
        //                          && B.IdBodega == IdBodega 
        //                          && B.IdEmpresa == param.IdEmpresa 
        //                          && B.IdSucursal == IdSucursal 
        //                          select new { C.IdEmpresa, C.IdSucursal, C.IdBodega, C.IdProducto, C.CodigoBarra,
        //                          B.dm_cantidad};

        //            LStCodBarra = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();

        //            foreach (var item in select2)
        //            {
        //                in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
        //                info.IdEmpresa = item.IdEmpresa;
        //                info.IdSucursal = item.IdSucursal;
        //                info.IdBodega = item.IdBodega;
        //                info.CodigoBarra = item.CodigoBarra;
        //                info.IdProducto = item.IdProducto;
        //                info.dm_cantidad = (double)item.dm_cantidad;
        //                LStCodBarra.Add(info);
        //            }
        //            LStCodBarra.ForEach(var => var.Secuencia = ++sec);
        //            gridCtrlCodBarra.DataSource = LStCodBarra;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());

        //    }
            
        //}

        //private void cmbProducto_Validating(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        if (cmbProducto.Value == null)
        //        {
        //            cmbProducto.Text = "";
                
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
                
        //    }

        //}

        //private void btnSalir_Click(object sender, EventArgs e)
        //{
            
        //}
                    
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                info = (in_movi_inve_detalle_x_Producto_CusCider_Info)gridVwCodBarra.GetFocusedRow();
                if (info == null)
                    MessageBox.Show("Seleccione un item para agregar", "Sistema");
                else
                {
                    Prod_CB = info;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

            
        }

       
        private void toolStripButton1_Click(object sender, EventArgs e)
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

        public in_movi_inve_detalle_x_Producto_CusCider_Info Prod_CB { get; set; }

        private void _cmbProducto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_cmbProducto.EditValue != null)
                {

                    int sec = 0;
                    Producto.IdProducto = Convert.ToDecimal(_cmbProducto.EditValue);
                    LStCodBarra = BusCodBarra.TraeCodBarraxProd(param.IdEmpresa, Producto.IdProducto);


                    var select2 = from C in LStCodBarra
                                  join B in SaldosCBarra
                                  on new { C.IdEmpresa, C.IdSucursal, C.IdBodega, C.IdProducto, C.CodigoBarra }
                                  equals new { B.IdEmpresa, B.IdSucursal, B.IdBodega, B.IdProducto, B.CodigoBarra }
                                  where B.dm_cantidad > 0
                                  && B.IdBodega == IdBodega
                                  && B.IdEmpresa == param.IdEmpresa
                                  && B.IdSucursal == IdSucursal
                                  select new
                                  {
                                      C.IdEmpresa,
                                      C.IdSucursal,
                                      C.IdBodega,
                                      C.IdProducto,
                                      C.CodigoBarra,
                                      B.dm_cantidad
                                  };

                    LStCodBarra = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();

                    foreach (var item in select2)
                    {
                        in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.CodigoBarra = item.CodigoBarra;
                        info.IdProducto = item.IdProducto;
                        info.dm_cantidad = (double)item.dm_cantidad;
                        LStCodBarra.Add(info);
                    }
                    LStCodBarra.ForEach(var => var.Secuencia = ++sec);
                    gridCtrlCodBarra.DataSource = LStCodBarra;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
           
        }

        private void _cmbProducto_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (_cmbProducto.EditValue == null)
                {
                    _cmbProducto.Text = "";

                }

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

      

       
       

    }
}
