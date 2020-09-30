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

using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.General;
using Core.Erp.Reportes.Inventario; 

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Ajuste_Inven_fisico_Mant : Form
    {
        #region Declaraciones

        string MensajeError = "";
      
        public delegate void Delegate_frmIn_Ajuste_Inventario_fisico_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmIn_Ajuste_Inventario_fisico_FormClosing Event_frmIn_Ajuste_Inventario_fisico_FormClosing;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public Boolean HayIngresos { get; set; }
        public Boolean HayEgresos { get; set; }
        decimal IdAjusteFisico = 0;
        decimal IdNumMovi_Egr = 0;
        decimal IdNumMovi_Ing = 0;


        
        List<in_movi_inve_detalle_Info> listDetMoviIngreso = new List<in_movi_inve_detalle_Info>();
        List<in_AjusteFisico_Detalle_Info> ListaAjuste = new List<in_AjusteFisico_Detalle_Info>();

        BindingList<in_Producto_Info> BindingList_Producto = new BindingList<Info.Inventario.in_Producto_Info>();

        List<in_movi_inve_detalle_Info> listDetMoviEgreso = new List<in_movi_inve_detalle_Info>();
        //-----------------------------------------------------------------------------------------
        Cl_Enumeradores.eTipo_action _Accion = new Cl_Enumeradores.eTipo_action();
        //-----------------------------------------------------------------------------------------
        
        in_producto_x_tb_bodega_Bus Bus_Producto_x_Bodega = new in_producto_x_tb_bodega_Bus();
        in_producto_Bus Bus_Producto_ = new in_producto_Bus();

        in_Catalogo_Bus Bus_Catalogo = new in_Catalogo_Bus();

        in_Parametro_Bus Bus_ParamInve = new in_Parametro_Bus();
        in_Parametro_Info Info_ParmeInven = new in_Parametro_Info();

        in_AjusteFisico_Bus Bus_AjustFisico = new in_AjusteFisico_Bus();
        in_ajusteFisico_Info Info_AjusteFisico = new in_ajusteFisico_Info();


        tb_Bodega_Info Info_Bodega = new tb_Bodega_Info();
        tb_Sucursal_Info Info_Sucursal = new tb_Sucursal_Info();

        in_movi_inve_Bus Bus_MoviInven = new in_movi_inve_Bus();
        in_movi_inve_detalle_Bus Bus_DetMovi = new in_movi_inve_detalle_Bus();


        List<ct_Centro_costo_Info> list_centro_costo = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();

        

        
        #endregion

        #region FuncionesCargarControles

        public void CargarControlMoviEgreso()
        {
            try
            {
                Ctrl_MoviEgreso.cargar_TipoMotivo(Ctrl_SucBod.get_sucursal().IdSucursal, Ctrl_SucBod.get_bodega().IdBodega, "-", "");
                if (Info_ParmeInven.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa != null) Ctrl_MoviEgreso.set_TipoMoviInvInfo(Convert.ToInt32(Info_ParmeInven.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa));
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
                Ctrl_MoviIngreso.cargar_TipoMotivo(Ctrl_SucBod.get_sucursal().IdSucursal, Ctrl_SucBod.get_bodega().IdBodega, "+", "");
                if (Info_ParmeInven.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa != null) Ctrl_MoviIngreso.set_TipoMoviInvInfo(Convert.ToInt32(Info_ParmeInven.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa));
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
                list_centro_costo = bus_centro_costo.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);
                cmb_CentroCosto.DataSource = list_centro_costo;
                
                ucIn_Catalogos_Cmb1.cargar_Catalogos(1);
                string IdCatalogo = "";
                IdCatalogo = (Info_ParmeInven.ApruebaAjusteFisicoAuto == "S") ? "APRO" : "XAPRO"; 
                ucIn_Catalogos_Cmb1.set_CatalogosInfo(IdCatalogo);


                CargarCotrlMoviIngreso();
                CargarControlMoviEgreso();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #endregion

        public FrmIn_Ajuste_Inven_fisico_Mant()
        {
            InitializeComponent();

            Ctrl_SucBod.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(Ctrl_SucBod_Event_cmb_sucursal_SelectionChangeCommitted);
            Ctrl_SucBod.Event_cmb_bodega_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectionChangeCommitted(Ctrl_SucBod_Event_cmb_bodega_SelectionChangeCommitted);
            Event_frmIn_Ajuste_Inventario_fisico_FormClosing += FrmIn_Ajuste_Inven_fisico_Mant_Event_frmIn_Ajuste_Inventario_fisico_FormClosing;
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void Ctrl_SucBod_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CargarCotrlMoviIngreso();
                CargarControlMoviEgreso();
                CargarListProd();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            _Accion = iAccion;

        }

        private void set_Accion_In_Controls()
        {
            switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Visible_bntAnular = false;
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    Set_Info();
                    Ctrl_SucBod.Bloquerar_Combos();
                    ucGe_Menu.Visible_btnGuardar = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_bntAprobar = false;
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    Set_Info();
                    Ctrl_SucBod.Bloquerar_Combos();
                    ucGe_Menu.Visible_btnGuardar = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_bntAnular = false;
                    ucGe_Menu.Visible_bntAprobar = false;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    Set_Info();
                    Ctrl_SucBod.Bloquerar_Combos();
                    ucGe_Menu.Visible_bntAnular = false;
                    break;
                default:
                    break;
            }

        }
        
        private void frmIn_Ajuste_Inventario_fisico_Load(object sender, EventArgs e)
        {
            try
            {
                
                Info_ParmeInven = Bus_ParamInve.Get_Info_Parametro(param.IdEmpresa);
                
                
                CargarControles();
                CargarListProd();
                set_Accion_In_Controls();
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmIn_Ajuste_Inven_fisico_Mant_Event_frmIn_Ajuste_Inventario_fisico_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {                
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }
       
        public in_ajusteFisico_Info Get_info()
        {
            try
            {
                
                Info_AjusteFisico = new Info.Inventario.in_ajusteFisico_Info();
                Info_AjusteFisico.IdEmpresa = param.IdEmpresa;
                Info_AjusteFisico.IdAjusteFisico = txtNumAjusteFisico.Text == "" ? 0 : Convert.ToDecimal(txtNumAjusteFisico.Text);
                gridViewAjusteInventario.ActiveFilterString = "";

                Info_Bodega = Ctrl_SucBod.get_bodega();
                Info_Sucursal = Ctrl_SucBod.get_sucursal();
                Info_AjusteFisico.Observacion = txtObservacion.Text;
                Info_AjusteFisico.IdBodega = Info_Bodega.IdBodega;
                Info_AjusteFisico.IdSucursal = Info_Sucursal.IdSucursal;
                Info_AjusteFisico.IdMovi_inven_tipo_Egr = Ctrl_MoviEgreso.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                Info_AjusteFisico.IdMovi_inven_tipo_Ing = Ctrl_MoviIngreso.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                Info_AjusteFisico.Estado = (lblAnulado.Visible == true) ? "I" : "A";
                Info_AjusteFisico.Fecha = dtp_fecha.Value;
                Info_AjusteFisico.IdEstadoAprobacion = ucIn_Catalogos_Cmb1.Get_CatalogosInfo().IdCatalogo;



                decimal En = 0;
                if (decimal.TryParse(txtNumMoviAjustEgreso.Text, out En))
                    Info_AjusteFisico.IdNumMovi_Egr = En;

                decimal Ing = 0;
                if (decimal.TryParse(txtMoviAjustIngreso.Text, out Ing))
                    Info_AjusteFisico.IdNumMovi_Ing = Ing;

                foreach (var item in BindingList_Producto)
                {
                    in_AjusteFisico_Detalle_Info infoAjusteDetalle = new in_AjusteFisico_Detalle_Info();
                    infoAjusteDetalle.IdAjusteFisico = IdAjusteFisico;
                    infoAjusteDetalle.IdEmpresa = param.IdEmpresa;
                    infoAjusteDetalle.IdProducto = item.IdProducto;
                    infoAjusteDetalle.CantidadAjustada = Convert.ToDouble(item.CantidadAjustada);
                    infoAjusteDetalle.StockFisico = Convert.ToDouble(item.StockFisico);
                    infoAjusteDetalle.StockSistema = item.pr_stock == null ? 0 : Convert.ToDouble(item.pr_stock);
                    infoAjusteDetalle.IdCentroCosto = item.IdCentroCosto;
                    Info_AjusteFisico.list_det_AjusteFisico.Add(infoAjusteDetalle);
                }

                return Info_AjusteFisico;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new in_ajusteFisico_Info();
            }
        }

        public void Set_Info(in_ajusteFisico_Info _Info_AjusteFisico)
        {
            Info_AjusteFisico = _Info_AjusteFisico;
        }


        private void Set_Info()
        {
            try
            {
                Ctrl_SucBod.cmb_sucursal.EditValue = Info_AjusteFisico.IdSucursal;
                Ctrl_SucBod.cmb_bodega.EditValue = Info_AjusteFisico.IdBodega;
                Info_AjusteFisico.IdSucursal = Info_AjusteFisico.IdSucursal;
                Info_AjusteFisico.IdBodega = Info_AjusteFisico.IdBodega;

                txtMoviAjustIngreso.Text = Info_AjusteFisico.IdNumMovi_Ing.ToString();
                txtNumMoviAjustEgreso.Text = Info_AjusteFisico.IdNumMovi_Egr.ToString();
                txtNumAjusteFisico.Text = Info_AjusteFisico.IdAjusteFisico.ToString();
                txtObservacion.Text = Info_AjusteFisico.Observacion;
                Ctrl_MoviIngreso.set_TipoMoviInvInfo(Info_AjusteFisico.IdMovi_inven_tipo_Ing);
                Ctrl_MoviEgreso.set_TipoMoviInvInfo(Info_AjusteFisico.IdMovi_inven_tipo_Egr);
                dtp_fecha.Value = Info_AjusteFisico.Fecha;
                ucIn_Catalogos_Cmb1.set_CatalogosInfo(Info_AjusteFisico.IdEstadoAprobacion);


                if (Info_AjusteFisico.Estado == "I")
                {
                    lblAnulado.Visible = true;
                    ucGe_Menu.Visible_bntAprobar = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    lblAnulado.Visible = false;
                }

                

                List<in_AjusteFisico_Detalle_Info> listaAjusteFisicoDetalle = new List<in_AjusteFisico_Detalle_Info>();
                in_AjusteFisico_Detalle_Bus BusAjusDeta = new in_AjusteFisico_Detalle_Bus();

                listaAjusteFisicoDetalle = BusAjusDeta.Get_List_AjusteFisico_Detalle(Info_AjusteFisico.IdEmpresa, Info_AjusteFisico.IdAjusteFisico);

                
                var Productos_x_Ajust_Stock = from q in listaAjusteFisicoDetalle
                                 select q;
                

                foreach (var item in BindingList_Producto)
                {
                    foreach (var item1 in Productos_x_Ajust_Stock)
                    {
                        if (item.IdProducto == item1.IdProducto)
                        {
                            item.StockFisico = Convert.ToDecimal(item1.StockFisico);
                            item.CantidadAjustada = (decimal)item1.CantidadAjustada;
                            item.pr_stock = Convert.ToDouble(item.StockFisico);                                                
                        }
                    }
                }


                //var Consulta = Bus_DetMovi.Get_List_StockAFecha(param.IdEmpresa, 
                //    Convert.ToInt32(Ctrl_SucBod.cmb_sucursal.EditValue), 
                //    Convert.ToInt32(Ctrl_SucBod.cmb_bodega.EditValue), Convert.ToDateTime(dtp_fecha.Value.ToShortDateString()));


                gridControl_producto.DataSource = BindingList_Producto;                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Acciones()
        {
            try
            {
                bool res = false;
                Get_info();
                if (Esta_Valido() == true)
                {
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            res = Guardar();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            res = Modificar();
                            break;
                        default:
                            break;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
                
        public void CargarListProd()
        {
            try
            {
                int IdSucursal = 0;
                int IdBodega = 0;

                IdSucursal = (Ctrl_SucBod.cmb_sucursal.EditValue == null) ? -999999 : Convert.ToInt32(Ctrl_SucBod.cmb_sucursal.EditValue);
                IdBodega=(Ctrl_SucBod.cmb_bodega.EditValue==null)?-999999: Convert.ToInt32(Ctrl_SucBod.cmb_bodega.EditValue);

                BindingList_Producto = new BindingList<in_Producto_Info>(Bus_Producto_.Get_list_Producto_modulo_x_inventario(param.IdEmpresa, IdSucursal, IdBodega));

                foreach (var item in BindingList_Producto)
                {
                    item.StockFisico = null;
                }

                gridControl_producto.DataSource = BindingList_Producto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAjusteInventario_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == colStockFisico.Name)
                {
                    
                    var data = gridViewAjusteInventario.GetRow(e.RowHandle) as in_Producto_Info;

                    decimal v_StockFisico=( data.StockFisico ==null)?0:Convert.ToDecimal(data.StockFisico );

                    data.CantidadAjustada =(v_StockFisico - Convert.ToDecimal(data.pr_stock));
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Boolean Esta_Valido()
        {

            try
            {
                

                List<in_Producto_Info> lista= new List<in_Producto_Info>();
                lista = new List<in_Producto_Info>(BindingList_Producto);

                if (lista.FindAll(z => z.StockFisico != null).Count() == 0)
                {
                    MessageBox.Show("Por favor Ingrese Stock Fisico en al menos un producto");
                    return false;
                }


                foreach (var item in lista)
                {
                    if (item.CantidadAjustada < 0)
                    {
                        var Temp = Ctrl_MoviEgreso.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                        if (Temp == 0)
                        {
                            MessageBox.Show("Por favor Selecciones Tipo Movimiento Inventario de Egreso");
                            return false;
                        }
                    }
                }

                foreach (var item in lista)
                {
                    if (item.CantidadAjustada > 0)
                    {
                        var Temp = Ctrl_MoviIngreso.get_TipoMoviInvInfo().IdMovi_inven_tipo;
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

                 if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(dtp_fecha.Value)))
                     return false;
                 
            return true;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
            }
        }

        private bool Guardar()
        {
            try
            {
                if (Bus_AjustFisico.GuardarDB(Info_AjusteFisico, ref IdAjusteFisico, ref IdNumMovi_Egr, ref IdNumMovi_Ing))
                {
                    txtNumAjusteFisico.Text = IdAjusteFisico.ToString();
                    Info_AjusteFisico.IdAjusteFisico = IdAjusteFisico;
                    txtMoviAjustIngreso.Text = IdNumMovi_Ing.ToString();
                    txtNumMoviAjustEgreso.Text = IdNumMovi_Egr.ToString();

                    string mensaje_ing = "# Ingreso: " + IdNumMovi_Ing + "\n";
                    string mensaje_egr = "# Egreso: " + IdNumMovi_Egr + "\n";
                    string mensaje = "Ajuste #" + IdAjusteFisico + " realizado exitosamente.";
                    if (IdNumMovi_Egr != 0) mensaje += "\n" + mensaje_egr;
                    if (IdNumMovi_Ing != 0) mensaje += "\n" + mensaje_ing;
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (MessageBox.Show("¿Desea Imprimir el Ajuste a Inventario # " + IdAjusteFisico + "\n" + "Imprimir", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ucGe_Menu_event_btnImprimir_Click(null, null);
                    }

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private bool Modificar()
        {
            try
            {
                if (Bus_AjustFisico.ModificarDB(Info_AjusteFisico, ref IdAjusteFisico, ref IdNumMovi_Egr, ref IdNumMovi_Ing))
                {
                    txtNumAjusteFisico.Text = IdAjusteFisico.ToString();                    
                    txtMoviAjustIngreso.Text = IdNumMovi_Ing.ToString();
                    txtNumMoviAjustEgreso.Text = IdNumMovi_Egr.ToString();

                    string mensaje_ing = "# Ingreso: " + IdNumMovi_Ing + "\n";
                    string mensaje_egr = "# Egreso: " + IdNumMovi_Egr + "\n";
                    string mensaje = "Ajuste #" + Info_AjusteFisico.IdAjusteFisico + " realizado exitosamente.";
                    if (IdNumMovi_Egr != 0) mensaje += "\n" + mensaje_egr;
                    if (IdNumMovi_Ing != 0) mensaje += "\n" + mensaje_ing;
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (MessageBox.Show("¿Desea Imprimir el Ajuste a Inventario # " + IdAjusteFisico + "\n" + "Imprimir", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ucGe_Menu_event_btnImprimir_Click(null, null);
                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
                       
        private void TspMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ucGe_Menu.Visible_btnGuardar = true;
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            dtp_fecha_Leave(sender, e);
           
        }

        private void dtp_fecha_Leave(object sender, EventArgs e)
        {
            gridControl_producto.DataSource = null;
            var Consulta = Bus_DetMovi.Get_List_StockAFecha(param.IdEmpresa, Convert.ToInt32(Ctrl_SucBod.cmb_sucursal.EditValue), Convert.ToInt32(Ctrl_SucBod.cmb_bodega.EditValue), Convert.ToDateTime(dtp_fecha.Value.ToShortDateString()));

            if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
            {

                //List_Producto. ForEach(v =>
                //{
                //    foreach  (var c in Consulta)
                //    {

                //        if (c.IdProducto == v.IdProducto)
                //        {
                //            v.pr_stock = c.dm_cantidad;
                //            break;
                //        }
                //        else
                //        {
                //            v.pr_stock = 0;
                //        }
                //    }

                //});

                gridControl_producto.DataSource = BindingList_Producto;
                gridControl_producto.RefreshDataSource();
            }
            else
            {

                //Lista_producto.ForEach(v =>
                //{
                //    foreach (var c in Consulta)
                //    {

                //        if (c.IdProducto == v.IdProducto)
                //        {
                //            v.pr_stock = c.dm_cantidad;
                //            break;
                //        }
                //        else
                //        {
                //            v.pr_stock = 0;
                //        }
                //    }

                //});


                gridControl_producto.DataSource = BindingList_Producto;
            }

            gridControl_producto.RefreshDataSource();
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void frmIn_Ajuste_Inventario_fisico_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmIn_Ajuste_Inventario_fisico_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private void ucGe_Menu_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {

                string mensaje_cbte_cble_ing = "";
                string mensaje_cbte_cble_egr = "";

                Get_info();

                
                in_AjusteFisico_Detalle_Bus BusAjusDeta = new in_AjusteFisico_Detalle_Bus();
                BusAjusDeta.EliminarDB(param.IdEmpresa, Convert.ToDecimal(txtNumAjusteFisico.Text));
                int s = 1;
                ListaAjuste = new List<in_AjusteFisico_Detalle_Info>();
                foreach (var item in BindingList_Producto)
                {
                    in_AjusteFisico_Detalle_Info infoAjusteDetalle = new in_AjusteFisico_Detalle_Info();
                    infoAjusteDetalle.IdAjusteFisico = Convert.ToDecimal(txtNumAjusteFisico.Text);
                    infoAjusteDetalle.IdEmpresa = param.IdEmpresa;
                    infoAjusteDetalle.Secuencia = s;
                    infoAjusteDetalle.IdProducto = item.IdProducto;
                    infoAjusteDetalle.CantidadAjustada = Convert.ToDouble(item.CantidadAjustada);
                    infoAjusteDetalle.StockFisico = Convert.ToDouble(item.StockFisico);
                    infoAjusteDetalle.StockSistema = item.pr_stock == null ? 0 : Convert.ToDouble(item.pr_stock);
                    s++;
                    ListaAjuste.Add(infoAjusteDetalle);
                }

                BusAjusDeta.GuardarDB(ListaAjuste);

                string mensaje = "";

                var TIngreso = (from q in BindingList_Producto
                                where q.CantidadAjustada > 0
                                select q).Count();

                var TEgresos = (from q in BindingList_Producto
                                where q.CantidadAjustada < 0
                                select q).Count();


                HayIngresos = (Convert.ToDouble(TIngreso) > 0) ? true : false;

                #region HayIngreso

                if (HayIngresos == true)
                {
                    in_movi_inve_Info InfoMOviIngreso = new in_movi_inve_Info();

                    #region InfoMoviIngres
                    InfoMOviIngreso.IdEmpresa = param.IdEmpresa;
                    InfoMOviIngreso.IdSucursal = Info_AjusteFisico.IdSucursal;
                    InfoMOviIngreso.IdBodega = Info_AjusteFisico.IdBodega;
                    InfoMOviIngreso.IdMovi_inven_tipo = Info_AjusteFisico.IdMovi_inven_tipo_Ing;
                    InfoMOviIngreso.cm_tipo = "+";
                    InfoMOviIngreso.cm_observacion = Info_AjusteFisico.Observacion;
                    InfoMOviIngreso.IdUsuario = param.IdUsuario;
                    InfoMOviIngreso.nom_pc = param.nom_pc;
                    InfoMOviIngreso.ip = param.ip;
                    InfoMOviIngreso.Estado = "A";
                    InfoMOviIngreso.cm_fecha = dtp_fecha.Value;
                    InfoMOviIngreso.CodMoviInven = "AJU";

                    #endregion
                   
                    var SelectDetMoviIng = from q in BindingList_Producto
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
                        detMovInfo.IdNumMovi = 0;
                        detMovInfo.mv_tipo_movi = InfoMOviIngreso.cm_tipo;
                        detMovInfo.dm_observacion = Info_AjusteFisico.Observacion;
                        detMovInfo.dm_precio = item.pr_precio_publico;
                        detMovInfo.mv_costo = item.pr_costo_promedio;

                        listDetMoviIngreso.Add(detMovInfo);

                        c++;

                    }

                    InfoMOviIngreso.listmovi_inve_detalle_Info = listDetMoviIngreso;
                    
                    Bus_MoviInven.GrabarDB(InfoMOviIngreso, ref IdNumMovi_Ing, ref mensaje_cbte_cble_ing, ref mensaje);



                }

                #endregion
                #region HayEgreso
                HayEgresos = (Convert.ToDouble(TEgresos) > 0) ? true : false;

                if (HayEgresos == true)
                {
                    #region InfoMoviEgreso
                    in_movi_inve_Info InfoMOviEgres = new in_movi_inve_Info();
                    InfoMOviEgres.IdEmpresa = param.IdEmpresa;
                    InfoMOviEgres.IdSucursal = Info_AjusteFisico.IdSucursal;
                    InfoMOviEgres.IdBodega = Info_AjusteFisico.IdBodega;
                    InfoMOviEgres.IdMovi_inven_tipo = Info_AjusteFisico.IdMovi_inven_tipo_Egr;
                    InfoMOviEgres.cm_tipo = "-";
                    InfoMOviEgres.cm_observacion = Info_AjusteFisico.Observacion;
                    InfoMOviEgres.IdUsuario = param.IdUsuario;
                    InfoMOviEgres.nom_pc = param.nom_pc;
                    InfoMOviEgres.ip = param.ip;
                    InfoMOviEgres.Estado = "A";
                    InfoMOviEgres.cm_fecha = dtp_fecha.Value;
                    InfoMOviEgres.CodMoviInven = "AJU";
                    #endregion
                    
                    var SelectDetMoviEgre = from q in BindingList_Producto
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
                        detMovInfo.dm_observacion = Info_AjusteFisico.Observacion;
                        detMovInfo.dm_precio = item.pr_precio_publico;
                        detMovInfo.mv_costo = item.pr_costo_promedio;
                        listDetMoviEgreso.Add(detMovInfo);
                    }


                    InfoMOviEgres.listmovi_inve_detalle_Info = listDetMoviEgreso;
                    Bus_MoviInven.GrabarDB(InfoMOviEgres, ref IdNumMovi_Egr, ref mensaje_cbte_cble_egr, ref mensaje);

                    //}


                }
                #endregion

                if (Bus_AjustFisico.ModificarDB(param.IdEmpresa, Convert.ToDecimal(txtNumAjusteFisico.Text), "APRO", IdNumMovi_Egr, IdNumMovi_Ing))
                {
                    MessageBox.Show("Ajuste Fisico Aprobado Con exito.. Ajuste#:" + Convert.ToDecimal(txtNumAjusteFisico.Text) + " Ingreso Inventario#:" + IdNumMovi_Ing
                  + " Egreso Inventario#:" + IdNumMovi_Egr + " Diarios Contables" + mensaje_cbte_cble_ing + " " + mensaje_cbte_cble_egr);
                    ucGe_Menu.Enabled_btnGuardar = false;
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                }
                else
                {
                    MessageBox.Show("Error Al Aprobar");
                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Esta_Valido())
                {
                    txtMoviAjustIngreso.Focus();
                    Acciones();
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XINV_Rpt007_rpt Reporte = new XINV_Rpt007_rpt();
                Reporte.RequestParameters = false;
                Reporte.IdEmpresa.Value = param.IdEmpresa;
                Reporte.IdSucursal.Value = Convert.ToInt32(Ctrl_SucBod.cmb_sucursal.EditValue);
                Reporte.IdBodega.Value = Convert.ToInt32(Ctrl_SucBod.cmb_bodega.EditValue);
                Reporte.IdNunAjusteFisico.Value = Convert.ToDecimal(txtNumAjusteFisico.Text);
                Reporte.TipoMovimientoIngreso.Value = Ctrl_MoviIngreso.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                Reporte.TipoMovimientoEgreso.Value = Ctrl_MoviEgreso.get_TipoMoviInvInfo().IdMovi_inven_tipo;

                DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;
                Reporte.ShowPreviewDialog();

                return;
               

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Get_info();
                string mensaje = "";
                if (Info_AjusteFisico.Estado == "I")
                {
                    MessageBox.Show("No se puede anular ya que el ajuste se encuentra anulado");
                    return;
                }

                if (MessageBox.Show("¿Está seguro que desea anular el ajuste fisico ?", "Anulación de Ajuste fisico " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();


                    Info_AjusteFisico.IdAjusteFisico = Convert.ToDecimal(txtNumAjusteFisico.Text);
                    Info_AjusteFisico.ip = param.ip;
                    Info_AjusteFisico.nom_pc = param.nom_pc;
                    Info_AjusteFisico.IdUsuarioAnulacion = param.IdUsuario;
                    Info_AjusteFisico.motivo_anula = ofrm.motivoAnulacion;
                    Info_AjusteFisico.FechaAnulacion = DateTime.Now;

                    if (Bus_AjustFisico.AnularDB(Info_AjusteFisico))
                    {
                        in_movi_inve_Info InfoMoviInve = new in_movi_inve_Info();

                        InfoMoviInve.IdEmpresa = Info_AjusteFisico.IdEmpresa;
                        InfoMoviInve.IdSucursal = Info_AjusteFisico.IdSucursal;
                        InfoMoviInve.IdBodega = Info_AjusteFisico.IdBodega;                                                 
                        InfoMoviInve.IdMovi_inven_tipo = Info_AjusteFisico.IdMovi_inven_tipo_Egr;
                        InfoMoviInve.IdNumMovi = (Info_AjusteFisico.IdNumMovi_Egr == null) ? 0 : Convert.ToDecimal(Info_AjusteFisico.IdNumMovi_Egr);
                        Bus_MoviInven.AnularDB(InfoMoviInve, Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref mensaje);
                        InfoMoviInve.IdMovi_inven_tipo = Info_AjusteFisico.IdMovi_inven_tipo_Ing;
                        InfoMoviInve.IdNumMovi = (Info_AjusteFisico.IdNumMovi_Ing == null) ? 0 : Convert.ToDecimal(Info_AjusteFisico.IdNumMovi_Ing);
                        Bus_MoviInven.AnularDB(InfoMoviInve, Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref mensaje);
                        ucGe_Menu.Enabled_bntAnular = false;
                        MessageBox.Show("Ajuste Fisico Anulado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

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
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ctrl_SucBod_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarListProd();
                CargarControles();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ctrl_SucBod_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarListProd();
                CargarControles();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAjusteInventario_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewAjusteInventario.GetRow(e.RowHandle) as in_Ing_Egr_Inven_det_Info;
                if (data == null)
                    return;

                if (data.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    e.Appearance.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Ctrl_SucBod_Event_cmb_sucursal_SelectionChangeCommitted(null, null);
                Ctrl_SucBod_Event_cmb_bodega_SelectionChangeCommitted(null, null);
                txtMoviAjustIngreso.Text = "";
                txtNumMoviAjustEgreso.Text = "";
                txtNumAjusteFisico.Text = "";
                txtObservacion.Text = "";
                BindingList_Producto = new BindingList<in_Producto_Info>();
                gridControl_producto.DataSource = BindingList_Producto;
                Info_AjusteFisico = new in_ajusteFisico_Info();                
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
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
