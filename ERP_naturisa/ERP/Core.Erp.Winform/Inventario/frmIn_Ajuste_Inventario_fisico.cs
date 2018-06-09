using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Reports.Inventario;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Inventario
{


    public partial class frmIn_Ajuste_Inventario_fisico : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //Version 1.1
        public Boolean HayIngresos { get; set; }
        public Boolean HayEgresos { get; set; }
        decimal IdAjusteFisico = 0;
        decimal IdNumMovi_Egr = 0;
        decimal IdNumMovi_Ing = 0;
        List<in_movi_inve_detalle_Info> listDetMoviIngreso = new List<in_movi_inve_detalle_Info>();
        List<in_AjusteFisico_Detalle_Info> ListaAjuste = new List<in_AjusteFisico_Detalle_Info>();
        private Cl_Enumeradores.eTipo_action _Accion;
        in_producto_x_tb_bodega_Bus PrxBoBUS = new in_producto_x_tb_bodega_Bus();

        List<in_Producto_Info> Datasource = new List<Info.Inventario.in_Producto_Info>();

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
             _Accion = iAccion;
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
            }           
        }

        public frmIn_Ajuste_Inventario_fisico()
        {
            try
            {
                InitializeComponent();
            
                Ctrl_SucBod.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(Ctrl_SucBod_Event_cmb_sucursal_SelectionChangeCommitted);
                Ctrl_SucBod.Event_cmb_bodega_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectionChangeCommitted(Ctrl_SucBod_Event_cmb_bodega_SelectionChangeCommitted);
                in_Catalogo_Bus BusCata = new in_Catalogo_Bus();
                in_Parametro_Bus parametrosInventari_B = new in_Parametro_Bus();
                var parmetros_I = parametrosInventari_B.ObtenerParametros(param.IdEmpresa);
                cmbEstadoAprob.DataSource= BusCata.ConsultaxTipoCatalogo(1);
                if (parmetros_I.ApruebaAjusteFisicoAuto == "S")
                    cmbEstadoAprob.SelectedValue = "APRO";
                else
                    cmbEstadoAprob.SelectedValue = "XAPRO";
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void Ctrl_SucBod_Event_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CargarListProd();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void Ctrl_SucBod_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CargarListProd();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        #region Declaraciones

        in_AjusteFisico_Detalle_Bus BusAjusDeta = new in_AjusteFisico_Detalle_Bus();
        UCIn_Sucursal_Bodega Ctrl_SucBod = new UCIn_Sucursal_Bodega();
        UCIn_TipoMoviInventario Ctrl_MoviIngreso = new UCIn_TipoMoviInventario();
        UCIn_TipoMoviInventario Ctrl_MoviEgreso = new UCIn_TipoMoviInventario();
        in_AjusteFisico_Bus oBusAjustFisico = new in_AjusteFisico_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_ajusteFisico_Info _Info = new in_ajusteFisico_Info();
        in_AjusteFisico_Bus BusAjusteFisico = new in_AjusteFisico_Bus();
        tb_Bodega_Info _InfoBodega = new tb_Bodega_Info();
        tb_Sucursal_Info _InfoSucursal = new tb_Sucursal_Info();
        in_movi_inve_Bus BusMoviInven = new in_movi_inve_Bus();
        in_producto_Bus _ProductoBus = new in_producto_Bus();
        List<in_Producto_Info> Lista_producto = new List<in_Producto_Info>();
        DataTable TablaProducto = new DataTable("Productos");
        DataTable dt = new DataTable("detalle");
        List<in_Producto_Info> ListaPorductos = new List<Info.Inventario.in_Producto_Info>();
        in_movi_inve_detalle_Bus BusDetMOvi = new in_movi_inve_detalle_Bus();

        List<in_movi_inve_detalle_Info> listDetMoviEgreso = new List<in_movi_inve_detalle_Info>();
        public in_ajusteFisico_Info InfoSet { get; set; }


        #endregion
        #region FuncionesCargarControles
        public void CargarControleSucBod()
        {
            try
            {
                Ctrl_SucBod.Dock = DockStyle.Fill;
            Ctrl_SucBod.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
            pnlSucBod.Controls.Add(Ctrl_SucBod);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               
            }

        }
        public void CargarControlMoviEgreso()
        {
            try
            {
                
            Ctrl_MoviEgreso.Dock = DockStyle.Fill;
            Ctrl_MoviEgreso.IdSucursal =1;
            Ctrl_MoviEgreso.IdBodega = 1;
            Ctrl_MoviEgreso.sTipoMoviInven = "-";
            Ctrl_MoviEgreso.SInterno = "";
            grbMovEgreso.Controls.Add(Ctrl_MoviEgreso);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }
        public void CargarCotrlMoviIngreso()
        {
            try
            {
                            Ctrl_MoviIngreso.Dock = DockStyle.Fill;
            Ctrl_MoviIngreso.IdSucursal = 1;
            Ctrl_MoviIngreso.IdBodega = 1;
            Ctrl_MoviIngreso.sTipoMoviInven = "+";
            Ctrl_MoviIngreso.SInterno = "";
            grbMovIngres.Controls.Add(Ctrl_MoviIngreso);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public void CargarControles()
        {
            try
            {
                            CargarControleSucBod();
            CargarCotrlMoviIngreso();
            CargarControlMoviEgreso();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        #endregion

        private void frmIn_Ajuste_Inventario_fisico_Load(object sender, EventArgs e)
        {
            try
            {
            Event_frmIn_Ajuste_Inventario_fisico_FormClosing += frmIn_Ajuste_Inventario_fisico_Event_frmIn_Ajuste_Inventario_fisico_FormClosing;
            load_grid();
            CargarControles();
            CargarListProd();
            //Ctrl_SucBod.cmb_bodega_SelectionChangeCommitted(new Object(), new EventArgs()); 
            switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    this.btn_ok.Text = "Grabar";
                    this.btn_ok.Enabled = true;
                    break;

                case Cl_Enumeradores.eTipo_action.borrar:
                    this.btn_ok.Text = "Anular";
                    this.btn_ok.Enabled = true;
                    
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    this.btn_ok.Text = "Consultar";
                    Set_Info();
                    this.btn_ok.Enabled = false;
                    this.btnGrabarySalir.Enabled = false;
                    break;
                default:
                    break;
            }          

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frmIn_Ajuste_Inventario_fisico_Event_frmIn_Ajuste_Inventario_fisico_FormClosing(object sender, FormClosingEventArgs e){}

        public in_ajusteFisico_Info Get_info()
        {
            try
            {
                ListaPorductos = new List<Info.Inventario.in_Producto_Info>();
                _Info = new Info.Inventario.in_ajusteFisico_Info();
                            _Info.IdEmpresa = param.IdEmpresa;
                _InfoBodega = Ctrl_SucBod.get_bodega();
                _InfoSucursal = Ctrl_SucBod.get_sucursal();
                _Info.Observacion = txtObservacion.Text;
                _Info.IdBodega = _InfoBodega.IdBodega;
                _Info.IdSucursal = _InfoSucursal.IdSucursal;
                _Info.IdMovi_inven_tipo_Egr = Ctrl_MoviEgreso.get_TipoMovi();
                _Info.IdMovi_inven_tipo_Ing = Ctrl_MoviIngreso.get_TipoMovi();
                _Info.Estado = (lblAnulado.Visible == true) ? "I" : "A";
                _Info.Fecha = dtp_fecha.Value;
                _Info.IdEstadoAprobacion = cmbEstadoAprob.SelectedValue.ToString();
            
            /// opteniendo el detalle
            
            for (int i = 0; i < gridViewAjusteInventario.RowCount; i++)
            {
                var data = gridViewAjusteInventario.GetRow(i) as in_Producto_Info;

                if (data.CantidadAjustada != 0)
                {
                    ListaPorductos.Add(data);

                }
            }
                decimal En=0;
                if (decimal.TryParse(txtNumMoviAjustEgreso.Text, out En))
                    _Info.IdNumMovi_Egr = En;

                decimal Ing = 0;
                if (decimal.TryParse(txtMoviAjustIngreso.Text, out Ing))
                    _Info.IdNumMovi_Ing = Ing;

            return _Info;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new in_ajusteFisico_Info();
            }
        }

        public void Set_Info()
        {
            try
            {
                Ctrl_SucBod.cmb_sucursal.SelectedValue = InfoSet.IdSucursal;
                Ctrl_SucBod.cmb_bodega.SelectedValue = InfoSet.IdBodega;
                _Info.IdSucursal = InfoSet.IdSucursal;
                _Info.IdBodega = InfoSet.IdBodega;
              
                CargarListProd();
               
                txtMoviAjustIngreso.Text = InfoSet.IdNumMovi_Ing.ToString();
                txtNumMoviAjustEgreso.Text = InfoSet.IdNumMovi_Egr.ToString();
                txtNumAjusteFisico.Text = InfoSet.IdAjusteFisico.ToString();
                txtObservacion.Text = InfoSet.Observacion;
                Ctrl_MoviIngreso.Set_tipoMovi(InfoSet.IdMovi_inven_tipo_Ing);
                Ctrl_MoviEgreso.Set_tipoMovi(InfoSet.IdMovi_inven_tipo_Egr);
                if (InfoSet.IdEstadoAprobacion.Substring(0, 4) == "APRO")
                    {
                        cmbEstadoAprob.SelectedValue = "APRO";
                        btnAprobar.Enabled = false;
                    }
                else
                    cmbEstadoAprob.SelectedValue = "XAPRO";

                if (InfoSet.Estado == "I")
                {
                    lblAnulado.Visible = true;
                    btnAprobar.Enabled = false;
                    btn_ok.Enabled = false;
                    btnGrabarySalir.Enabled = false;
                }
                else
                {
                    lblAnulado.Visible = false;
                }

         List<in_AjusteFisico_Detalle_Info> listaAjusteFisicoDetalle = new List<Info.Inventario.in_AjusteFisico_Detalle_Info>();

                    listaAjusteFisicoDetalle = BusAjusDeta.ConsultaDetalleAjuste(InfoSet);

                    var CodProd = from q in listaAjusteFisicoDetalle
                                 select q.IdProducto;

                    var Constains = from q in Lista_producto 
                                    where CodProd.Contains(q.IdProducto)
                                        select q;


                    var datosStock = from q in listaAjusteFisicoDetalle
                                  select q;

                    foreach (var item in Constains)
                    {
                        in_Producto_Info oPxB = new in_Producto_Info();
                        oPxB.pr_codigo = item.pr_codigo;
                        oPxB.pr_descripcion = item.pr_descripcion;
                        oPxB.RutaPadre = item.RutaPadre;
                        oPxB.Marca = item.Marca;
                        oPxB.IdProducto = item.IdProducto;
                        foreach (var item1 in datosStock)
                        {
                            if (item.IdProducto == item1.IdProducto)
                            {

                                oPxB.StockFisico = Convert.ToDecimal(item1.StockFisico);
                                oPxB.CantidadAjustada = (decimal)item1.CantidadAjustada;
                                oPxB.pr_stock = Convert.ToDouble(item.StockFisico);
                                Datasource.Add(oPxB);

                            }
                        }
                       

                    }
                   
                    Ctrl_SucBod.cmb_bodega.Refresh();
                    var Consulta = BusDetMOvi.ObjtenerStockAFecha(param.IdEmpresa, Convert.ToInt32(Ctrl_SucBod.cmb_sucursal.SelectedValue), Convert.ToInt32(Ctrl_SucBod.cmb_bodega.SelectedValue), Convert.ToDateTime(dtp_fecha.Value.ToShortDateString()));

                    Datasource.ForEach(v =>
                    {
                        foreach (var c in Consulta)
                        {

                            if (c.IdProducto == v.IdProducto)
                            {
                                v.pr_stock = c.dm_cantidad;
                                break;
                            }
                        }

                    });
                    gridControl1.DataSource = Datasource;
                   
                    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                txtMoviAjustIngreso.Focus();
                Acciones();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void Acciones()
        {
            try
            {
                 Get_info();
            if (Esta_Valido() == true)
            {
                guardar();
            }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }
        
        private void ultraComboProdXBod_Click(object sender, EventArgs e){}

        public void CargarListProd()
        {
            try
            {
                Get_info();
                
            Lista_producto = _ProductoBus.Obtener_Productoss(param.IdEmpresa, _Info.IdBodega, _Info.IdSucursal);
            Lista_producto.ForEach(v => v.StockFisico = Convert.ToDecimal(v.pr_stock));

            //var Consulta = BusDetMOvi.ObjtenerStockAFecha(param.IdEmpresa, Convert.ToInt32(Ctrl_SucBod.cmb_sucursal.SelectedValue), Convert.ToInt32(Ctrl_SucBod.cmb_bodega.SelectedValue), Convert.ToDateTime(dtp_fecha.Value.ToShortDateString()));
                
            //    Lista_producto.ForEach(v => 
            //    { 
            //        v.StockFisico = Convert.ToDecimal(v.pr_stock);
            //        foreach (var c in Consulta)
            //        {

            //            if(c.IdProducto == v.IdProducto)
            //            {
            //                v.pr_stock = c.dm_cantidad;
            //            //.dm_cantidad; 
            //            break;
            //            }
            //        }
                    
            //    });


            gridControl1.DataSource = Lista_producto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }


        private void load_grid()
        {
            try
            {
               dt.Columns.Add("Codigo_Producto", typeof(string));
               dt.Columns.Add("Producto", typeof(string));
               dt.Columns.Add("Stock Sistema", typeof(double));
               dt.Columns.Add("Stock Fisico", typeof(double));
               dt.Columns.Add("Tipo Movimiento", typeof(string));
               dt.Columns.Add("Marca", typeof(string));
                dt.Columns.Add("Cantidad Ajustada", typeof(Double));
             
                dt.AcceptChanges();        

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewAjusteInventario.GetRow(e.RowHandle) as in_Producto_Info;
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

        private void gridViewAjusteInventario_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                 if (e.Column.Caption == "Stock Fisico")
            {
                var data = gridViewAjusteInventario.GetRow(e.RowHandle) as in_Producto_Info;
                data.CantidadAjustada = data.StockFisico - Convert.ToDecimal(data.pr_stock);


            }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


            

               


        }
        

        private Boolean Esta_Valido()
        {

            try
            {
                if (((List<in_Producto_Info>)(gridControl1.DataSource)).FindAll(z => z.CantidadAjustada != 0).Count() == 0)
                {
                    MessageBox.Show("Por favor Ingrese Stock Fisico en al menos un producto");
                    return false;
                }
                foreach (var item in ((List<in_Producto_Info>)(gridControl1.DataSource)))
                {
                    if (item.CantidadAjustada < 0)
                    {
                        var Temp = Ctrl_MoviEgreso.get_TipoMovi();
                        if (Temp == 0)
                        {
                            MessageBox.Show("Por favor Selecciones Tipo Movimiento Inventario de Egreso");
                            return false;
                        }
                    }
                }

                foreach (var item in ((List<in_Producto_Info>)(gridControl1.DataSource)))
                {
                    if (item.CantidadAjustada > 0)
                    {
                         var Temp = Ctrl_MoviIngreso.get_TipoMovi();
                         if (Temp == 0)
                         {
                             MessageBox.Show("Por favor Selecciones Tipo Movimiento Inventario de Ingreso");
                             return false;
                         }
                    }
                 }
                 if (string.IsNullOrWhiteSpace(txtObservacion.Text)) 
                 {
                     MessageBox.Show("Por favor Ingrese Observacion");
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



        private void guardar()
        {
            try
            {
                
         //    Get_info();



            string mensaje = "";
            if (cmbEstadoAprob.SelectedValue.ToString() == "APRO")
            {
                var TIngreso = (from q in ListaPorductos
                                where q.CantidadAjustada > 0
                                select q).Count();

                var TEgresos = (from q in ListaPorductos
                                where q.CantidadAjustada < 0
                                select q).Count();


                HayIngresos = (Convert.ToDouble(TIngreso) > 0) ? true : false;

                #region HayIngreso

                if (HayIngresos == true)
                {
                    in_movi_inve_Info InfoMOviIngreso = new in_movi_inve_Info();

                    #region InfoMoviIngres
                    InfoMOviIngreso.IdEmpresa = param.IdEmpresa;
                    InfoMOviIngreso.IdSucursal = _Info.IdSucursal;
                    InfoMOviIngreso.IdBodega = _Info.IdBodega;
                    InfoMOviIngreso.IdMovi_inven_tipo = _Info.IdMovi_inven_tipo_Ing;
                    InfoMOviIngreso.cm_tipo = "+";
                    InfoMOviIngreso.cm_observacion = _Info.Observacion;
                    InfoMOviIngreso.IdUsuario = param.IdUsuario;
                    InfoMOviIngreso.nom_pc = param.nom_pc;
                    InfoMOviIngreso.ip = param.ip;
                    InfoMOviIngreso.Estado = "A";
                    InfoMOviIngreso.cm_fecha = dtp_fecha.Value;
                    InfoMOviIngreso.CodMoviInven = "AJU";

                    #endregion



                    /// opteniendo el detalle del movimiento de invetario 
                    var SelectDetMoviIng = from q in ListaPorductos
                                           where q.CantidadAjustada > 0
                                           select q;

                    int c = 1;
                    foreach (var item in SelectDetMoviIng)
                    {

                        in_movi_inve_detalle_Info detMovInfo = new in_movi_inve_detalle_Info();


                        detMovInfo.peso = item.pr_peso;
                        detMovInfo.dm_stock_ante = item.pr_stock;
                        detMovInfo.dm_stock_actu = Convert.ToDouble(item.StockFisico);
                        detMovInfo.dm_cantidad = Convert.ToDouble(item.CantidadAjustada);
                        detMovInfo.IdProducto = item.IdProducto;
                        detMovInfo.Secuencia = c;
                        detMovInfo.IdEmpresa = param.IdEmpresa;
                        detMovInfo.IdBodega = InfoMOviIngreso.IdBodega;
                        detMovInfo.IdSucursal = InfoMOviIngreso.IdSucursal;
                        detMovInfo.IdMovi_inven_tipo = InfoMOviIngreso.IdMovi_inven_tipo;
                        detMovInfo.IdNumMovi = IdNumMovi_Ing;
                        detMovInfo.mv_tipo_movi = InfoMOviIngreso.cm_tipo;
                        detMovInfo.dm_observacion = _Info.Observacion;
                        detMovInfo.dm_precio = item.pr_precio_publico;
                        detMovInfo.mv_costo = item.pr_costo_promedio;
                        listDetMoviIngreso.Add(detMovInfo);
                        c++;
                    }


                    InfoMOviIngreso.listmovi_inve_detalle_Info = listDetMoviIngreso;
                    BusMoviInven.GrabarDB(InfoMOviIngreso, ref IdNumMovi_Ing, ref mensaje);

                }

                #endregion
                #region HayEgreso
                HayEgresos = (Convert.ToDouble(TEgresos) > 0) ? true : false;

                if (HayEgresos == true)
                {
                    #region InfoMoviEgreso
                    in_movi_inve_Info InfoMOviEgres = new in_movi_inve_Info();
                    InfoMOviEgres.IdEmpresa = param.IdEmpresa;
                    InfoMOviEgres.IdSucursal = _Info.IdSucursal;
                    InfoMOviEgres.IdBodega = _Info.IdBodega;
                    InfoMOviEgres.IdMovi_inven_tipo = _Info.IdMovi_inven_tipo_Egr;
                    InfoMOviEgres.cm_tipo = "-";
                    InfoMOviEgres.cm_observacion = _Info.Observacion;
                    InfoMOviEgres.IdUsuario = param.IdUsuario;
                    InfoMOviEgres.nom_pc = param.nom_pc;
                    InfoMOviEgres.ip = param.ip;
                    InfoMOviEgres.Estado = "A";
                    InfoMOviEgres.cm_fecha = dtp_fecha.Value;
                    InfoMOviEgres.CodMoviInven = "AJU";
                    #endregion


                    /// encontrando el detalle de inventario 
                    /// 
                    var SelectDetMoviEgre = from q in ListaPorductos
                                            where q.CantidadAjustada < 0
                                            select q;



                    int c = 1;

                    foreach (var item in SelectDetMoviEgre)
                    {

                        in_movi_inve_detalle_Info detMovInfo = new in_movi_inve_detalle_Info();
                        detMovInfo.IdEmpresa = param.IdEmpresa;
                        detMovInfo.IdBodega = InfoMOviEgres.IdBodega;
                        detMovInfo.IdSucursal = InfoMOviEgres.IdSucursal;
                        detMovInfo.IdMovi_inven_tipo = InfoMOviEgres.IdMovi_inven_tipo;
                        detMovInfo.IdNumMovi = IdNumMovi_Egr;
                        detMovInfo.peso = item.pr_peso;
                        detMovInfo.Secuencia = c;
                        c++;
                        detMovInfo.mv_tipo_movi = InfoMOviEgres.cm_tipo;
                        detMovInfo.IdProducto = item.IdProducto;
                        detMovInfo.dm_cantidad = Convert.ToDouble(item.CantidadAjustada) * -1;
                        detMovInfo.dm_stock_actu = Convert.ToDouble(item.StockFisico);
                        detMovInfo.dm_stock_ante = item.pr_stock;
                        detMovInfo.dm_observacion = _Info.Observacion;
                        detMovInfo.dm_precio = item.pr_precio_publico;
                        detMovInfo.mv_costo = item.pr_costo_promedio;

                        listDetMoviEgreso.Add(detMovInfo);


                    }

                    InfoMOviEgres.listmovi_inve_detalle_Info = listDetMoviEgreso;
                    BusMoviInven.GrabarDB(InfoMOviEgres, ref IdNumMovi_Egr, ref mensaje);

                }
                #endregion

            }




            if (BusAjusteFisico.GuardarAjusteFisico(_Info, ref IdAjusteFisico, ref IdNumMovi_Egr, ref IdNumMovi_Ing))
            {
                txtNumAjusteFisico.Text = IdAjusteFisico.ToString();
                _Info.IdAjusteFisico = IdAjusteFisico;
                txtMoviAjustIngreso.Text = IdNumMovi_Ing.ToString();
                txtNumMoviAjustEgreso.Text = IdNumMovi_Egr.ToString();
                int c = 1;

               
                foreach (var item in ListaPorductos)
                {
                    in_AjusteFisico_Detalle_Info infoAjusteDetalle = new in_AjusteFisico_Detalle_Info();
                    infoAjusteDetalle.IdAjusteFisico = IdAjusteFisico;
                    infoAjusteDetalle.IdEmpresa = param.IdEmpresa;
                    infoAjusteDetalle.Secuencia = c;
                    infoAjusteDetalle.IdProducto = item.IdProducto;
                    infoAjusteDetalle.CantidadAjustada = Convert.ToDouble(item.CantidadAjustada);
                    infoAjusteDetalle.StockFisico = Convert.ToDouble(item.StockFisico);
                    infoAjusteDetalle.StockSistema = item.pr_stock;
                    c++;
                    ListaAjuste.Add(infoAjusteDetalle);
                }
                
                
                BusAjusDeta.GuardarBase(ListaAjuste);


                MessageBox.Show("Guardado OK");
                btn_ok.Enabled = false;
                btnGrabarySalir.Enabled = false;
            }
                
            //in_producto_x_tb_bodega_Bus _BusProdXBode = new in_producto_x_tb_bodega_Bus();

            //string Mensaje = "";

 
        
            ListaPorductos = new List<Info.Inventario.in_Producto_Info>(); ;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }

        }

        
        private void btnGrabarySalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Esta_Valido()) 
                {
                    Acciones();
                    Close();
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
                Get_info();
                string mensaje = "";
                if (_Info.Estado == "I")
                {
                    MessageBox.Show("No se puede anular ya que el ajuste se encuentra anulado");
                    return;
                }




                if (MessageBox.Show("¿Está seguro que desea anular el ajuste fisico ?", "Anulación de Ajuste fisico " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    frmGe_MotivoAnulacion ofrm = new frmGe_MotivoAnulacion();
                    ofrm.ShowDialog();


                    _Info.IdAjusteFisico = Convert.ToDecimal(txtNumAjusteFisico.Text);
                    _Info.ip = param.ip;
                    _Info.nom_pc = param.nom_pc;
                    _Info.IdUsuarioAnulacion = param.IdUsuario;
                    _Info.motivo_anula = ofrm.motivoAnulacion;
                    _Info.FechaAnulacion = DateTime.Now;

                    if (BusAjusteFisico.Anular(_Info))
                    {
                        in_movi_inve_Info InfoMoviInve = new Info.Inventario.in_movi_inve_Info();
                        InfoMoviInve.IdNumMovi = _Info.IdNumMovi_Egr;
                        InfoMoviInve.IdEmpresa = _Info.IdEmpresa;
                        InfoMoviInve.IdSucursal = _Info.IdSucursal;
                        InfoMoviInve.IdBodega = _Info.IdBodega;
                        InfoMoviInve.IdMovi_inven_tipo = _Info.IdMovi_inven_tipo_Egr;
                        InfoMoviInve.IdNumMovi = _Info.IdNumMovi_Egr;
                        BusMoviInven.AnularDB(InfoMoviInve, Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref mensaje);

                        InfoMoviInve.IdNumMovi = _Info.IdNumMovi_Ing;
                        InfoMoviInve.IdMovi_inven_tipo = _Info.IdMovi_inven_tipo_Ing;
                        InfoMoviInve.IdNumMovi = _Info.IdNumMovi_Ing;
                        BusMoviInven.AnularDB(InfoMoviInve, Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref mensaje);


                        MessageBox.Show("Ajuste Fisico Anulado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }
        

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
             XRpt_in_AjusteFisico xprt = new XRpt_in_AjusteFisico();
            in_rpt_AjusteFisico InfoReport = new in_rpt_AjusteFisico();

            List<in_rpt_AjusteFisico> lstReport = new List<in_rpt_AjusteFisico>();


            InfoReport.InfoEmpresa = param.EmpresaInfo;
            InfoReport.InfoAjusteFisico = InfoSet;
            InfoReport.ListaProducto =Datasource ;
            InfoReport.InfoAjusteFisico.IdUsuario = param.IdUsuario;

            lstReport.Add(InfoReport);

            xprt.loadData(lstReport.ToArray());
            xprt.ShowPreviewDialog();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
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

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

            try
            {
                Get_info();

                BusAjusDeta.Eliminar(param.IdEmpresa, Convert.ToDecimal(txtNumAjusteFisico.Text));
                int s=1;
                ListaAjuste = new List<Info.Inventario.in_AjusteFisico_Detalle_Info>();
                foreach (var item in ListaPorductos)
                {
                    in_AjusteFisico_Detalle_Info infoAjusteDetalle = new in_AjusteFisico_Detalle_Info();
                    infoAjusteDetalle.IdAjusteFisico = Convert.ToDecimal(txtNumAjusteFisico.Text);
                    infoAjusteDetalle.IdEmpresa = param.IdEmpresa;
                    infoAjusteDetalle.Secuencia = s;
                    infoAjusteDetalle.IdProducto = item.IdProducto;
                    infoAjusteDetalle.CantidadAjustada = Convert.ToDouble(item.CantidadAjustada);
                    infoAjusteDetalle.StockFisico = Convert.ToDouble(item.StockFisico);
                    infoAjusteDetalle.StockSistema = item.pr_stock;
                    s++;
                    ListaAjuste.Add(infoAjusteDetalle);
                }
               // ListaAjuste.ForEach(v=>v.IdAjusteFisico = );

                BusAjusDeta.GuardarBase(ListaAjuste);
                //string MenMovi ="";
                //in_movi_inve_Info movi_I = new in_movi_inve_Info();
                //movi_I.IdEmpresa = param.IdEmpresa;
                //movi_I.IdSucursal = _Info.IdSucursal;
                //movi_I.IdBodega = _Info.IdBodega;

                //BusMoviInven.AnularCabeceraYDetalleyActualizaStock(movi_I, ref MenMovi);

                string mensaje = "";
                
                var TIngreso = (from q in ListaPorductos
                                where q.CantidadAjustada > 0
                                select q).Count();

                var TEgresos = (from q in ListaPorductos
                                where q.CantidadAjustada < 0
                                select q).Count();


                HayIngresos = (Convert.ToDouble(TIngreso) > 0) ? true : false;

                #region HayIngreso

                if (HayIngresos == true)
                {
                    in_movi_inve_Info InfoMOviIngreso = new in_movi_inve_Info();

                    #region InfoMoviIngres
                    InfoMOviIngreso.IdEmpresa = param.IdEmpresa;
                    InfoMOviIngreso.IdSucursal = _Info.IdSucursal;
                    InfoMOviIngreso.IdBodega = _Info.IdBodega;
                    InfoMOviIngreso.IdMovi_inven_tipo = _Info.IdMovi_inven_tipo_Ing;
                    InfoMOviIngreso.cm_tipo = "+";
                    InfoMOviIngreso.cm_observacion = _Info.Observacion;
                    InfoMOviIngreso.IdUsuario = param.IdUsuario;
                    InfoMOviIngreso.nom_pc = param.nom_pc;
                    InfoMOviIngreso.ip = param.ip;
                    InfoMOviIngreso.Estado = "A";
                    InfoMOviIngreso.cm_fecha = dtp_fecha.Value;
                    InfoMOviIngreso.CodMoviInven = "AJU";

                    #endregion
                    if (BusMoviInven.GrabarDB(InfoMOviIngreso, ref IdNumMovi_Ing, ref mensaje))
                    {
                        var SelectDetMoviIng = from q in ListaPorductos
                                               where q.CantidadAjustada > 0
                                               select q;

                        int c = 1;
                        foreach (var item in SelectDetMoviIng)
                        {

                            in_movi_inve_detalle_Info detMovInfo = new in_movi_inve_detalle_Info();



                            detMovInfo.dm_stock_ante = item.pr_stock;
                            detMovInfo.dm_stock_actu = Convert.ToDouble(item.StockFisico);
                            detMovInfo.dm_cantidad = Convert.ToDouble(item.CantidadAjustada);
                            detMovInfo.IdProducto = item.IdProducto;
                            detMovInfo.Secuencia = c;
                            detMovInfo.IdEmpresa = param.IdEmpresa;
                            detMovInfo.IdBodega = InfoMOviIngreso.IdBodega;
                            detMovInfo.IdSucursal = InfoMOviIngreso.IdSucursal;
                            detMovInfo.IdMovi_inven_tipo = InfoMOviIngreso.IdMovi_inven_tipo;
                            detMovInfo.IdNumMovi = IdNumMovi_Ing;
                            detMovInfo.mv_tipo_movi = InfoMOviIngreso.cm_tipo;
                            detMovInfo.dm_observacion = _Info.Observacion;
                            detMovInfo.dm_precio = item.pr_precio_publico;
                            detMovInfo.mv_costo = item.pr_costo_promedio;


                            listDetMoviIngreso.Add(detMovInfo);




                            c++;

                        }
                        //guarda los ingresos 
                        BusDetMOvi.GrabarDB(listDetMoviIngreso, ref mensaje);

                        // actualizo el stokc x bodega


                        PrxBoBUS.ActualizarStock_x_Bodega_con_moviInven(listDetMoviIngreso, ref mensaje);



                    }


                }

                #endregion
                #region HayEgreso
                HayEgresos = (Convert.ToDouble(TEgresos) > 0) ? true : false;

                if (HayEgresos == true)
                {
                    #region InfoMoviEgreso
                    in_movi_inve_Info InfoMOviEgres = new in_movi_inve_Info();
                    InfoMOviEgres.IdEmpresa = param.IdEmpresa;
                    InfoMOviEgres.IdSucursal = _Info.IdSucursal;
                    InfoMOviEgres.IdBodega = _Info.IdBodega;
                    InfoMOviEgres.IdMovi_inven_tipo = _Info.IdMovi_inven_tipo_Egr;
                    InfoMOviEgres.cm_tipo = "-";
                    InfoMOviEgres.cm_observacion = _Info.Observacion;
                    InfoMOviEgres.IdUsuario = param.IdUsuario;
                    InfoMOviEgres.nom_pc = param.nom_pc;
                    InfoMOviEgres.ip = param.ip;
                    InfoMOviEgres.Estado = "A";
                    InfoMOviEgres.cm_fecha = dtp_fecha.Value;
                    InfoMOviEgres.CodMoviInven = "AJU";
                    #endregion
                    if (BusMoviInven.GrabarDB(InfoMOviEgres, ref IdNumMovi_Egr, ref mensaje))
                    {
                        var SelectDetMoviEgre = from q in ListaPorductos
                                                where q.CantidadAjustada < 0
                                                select q;



                        int c = 1;

                        foreach (var item in SelectDetMoviEgre)
                        {

                            in_movi_inve_detalle_Info detMovInfo = new in_movi_inve_detalle_Info();
                            detMovInfo.IdEmpresa = param.IdEmpresa;
                            detMovInfo.IdBodega = InfoMOviEgres.IdBodega;
                            detMovInfo.IdSucursal = InfoMOviEgres.IdSucursal;
                            detMovInfo.IdMovi_inven_tipo = InfoMOviEgres.IdMovi_inven_tipo;
                            detMovInfo.IdNumMovi = IdNumMovi_Egr;
                            detMovInfo.Secuencia = c;
                            c++;
                            detMovInfo.mv_tipo_movi = InfoMOviEgres.cm_tipo;
                            detMovInfo.IdProducto = item.IdProducto;
                            detMovInfo.dm_cantidad = Convert.ToDouble(item.CantidadAjustada);
                            detMovInfo.dm_stock_actu = Convert.ToDouble(item.StockFisico);
                            detMovInfo.dm_stock_ante = item.pr_stock;
                            detMovInfo.dm_observacion = _Info.Observacion;
                            detMovInfo.dm_precio = item.pr_precio_publico;
                            detMovInfo.mv_costo = item.pr_costo_promedio;

                            listDetMoviEgreso.Add(detMovInfo);






                        }

                        BusDetMOvi.GrabarDB(listDetMoviEgreso, ref mensaje);
                        PrxBoBUS.ActualizarStock_x_Bodega_con_moviInven(listDetMoviEgreso, ref mensaje);
                    }


                }
                #endregion

                if (BusAjusteFisico.Modificar(param.IdEmpresa, Convert.ToDecimal(txtNumAjusteFisico.Text), "APRO", IdNumMovi_Egr, IdNumMovi_Ing))
                {
                    MessageBox.Show("Aprobado Con exito..");
                }
                else 
                {
                    MessageBox.Show("Error Al Aprobar");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }

        private void TspMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                //Ctrl_SucBod.cmb_bodega.SelectedValue = 10;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
               dtp_fecha_Leave(sender, e);
            }
            catch (Exception ex)
            {
              Log_Error_bus.Log_Error(ex.ToString());
            }           
        }

        private void dtp_fecha_KeyPress(object sender, KeyPressEventArgs e){}

        //public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        //{
        //    return listToClone.Select(item => (T)item.Clone()).ToList();
        //}

        private void dtp_fecha_Leave(object sender, EventArgs e)
        {
            try
            {
                    gridControl1.DataSource = null;
                  //  var CLONA = Lista_producto.Select(item => (in_Producto_Info)item.Clone()).ToList();
           
                    var Consulta = BusDetMOvi.ObjtenerStockAFecha(param.IdEmpresa, Convert.ToInt32(Ctrl_SucBod.cmb_sucursal.SelectedValue), Convert.ToInt32(Ctrl_SucBod.cmb_bodega.SelectedValue), Convert.ToDateTime(dtp_fecha.Value.ToShortDateString()));

                    if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                    {
                        // var Consulta = BusDetMOvi.ObjtenerStockAFecha(param.IdEmpresa, Convert.ToInt32(Ctrl_SucBod.cmb_sucursal.SelectedValue), Convert.ToInt32(Ctrl_SucBod.cmb_bodega.SelectedValue), Convert.ToDateTime(dtp_fecha.Value.ToShortDateString()));

                        Datasource.ForEach(v =>
                        {
                            //v.StockFisico = Convert.ToDecimal(v.pr_stock);
                            foreach (var c in Consulta)
                            {

                                if (c.IdProducto == v.IdProducto)
                                {
                                    v.pr_stock = c.dm_cantidad;
                                    //.dm_cantidad; 
                                    break;
                                }
                                else
                                {
                                    v.pr_stock = 0;
                                }
                            }

                        });

                        gridControl1.DataSource = Datasource;
                        gridControl1.RefreshDataSource();
                    }
                    else
                    {

                        Lista_producto.ForEach(v =>
                        {
                            // v.StockFisico = Convert.ToDecimal(v.pr_stock);
                            foreach (var c in Consulta)
                            {

                                if (c.IdProducto == v.IdProducto)
                                {
                                    v.pr_stock = c.dm_cantidad;
                                    //.dm_cantidad; 
                                    break;
                                }
                                else
                                {
                                    v.pr_stock = 0;
                                }
                            }

                        });
                        gridControl1.DataSource = Lista_producto;
                    }

                    gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void gridViewAjusteInventario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                 if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (e.KeyCode == Keys.Delete)
                        {
                            if (MessageBox.Show("¿Está seguro que desea Eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                gridViewAjusteInventario.DeleteSelectedRows();
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }
        public delegate void Delegate_frmIn_Ajuste_Inventario_fisico_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmIn_Ajuste_Inventario_fisico_FormClosing Event_frmIn_Ajuste_Inventario_fisico_FormClosing;
        private void frmIn_Ajuste_Inventario_fisico_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmIn_Ajuste_Inventario_fisico_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                     Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void toolStripButton2_Click_2(object sender, EventArgs e){}
        

       

        
    }
}
