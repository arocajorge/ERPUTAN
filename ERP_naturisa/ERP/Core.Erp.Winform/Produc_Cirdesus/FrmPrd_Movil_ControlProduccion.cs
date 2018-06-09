using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_Movil_ControlProduccion : Form
    {

        public FrmPrd_Movil_ControlProduccion()
        {
            try
            {
                InitializeComponent();

                cmbObra.Properties.DataSource = Obra_B.ObtenerListaObra(param.IdEmpresa);
                cambiacontroles();
                gridControlDisponible.DataSource = ListadoDisponible;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

         void cambiacontroles()
        {
            try
            {
                Font fte = new System.Drawing.Font("Microsoft Sans Serif", 6.5f);
                
                ctrl_Sucbod.cmb_bodega.Size = new System.Drawing.Size(170, 18);
                ctrl_Sucbod.cmb_sucursal.Size = new System.Drawing.Size(170, 18);
                ctrl_Sucbod.label1.Text = "SUC:";
                ctrl_Sucbod.lblBodega.Text = "BOD:";
                ctrl_Sucbod.label1.Location = new Point(0, 8);
                ctrl_Sucbod.lblBodega.Location = new Point(0, 30);
                ctrl_Sucbod.label1.Font = fte;
                ctrl_Sucbod.lblBodega.Font = fte;
                ctrl_Sucbod.cmb_bodega.Font = fte;
                ctrl_Sucbod.cmb_sucursal.Font = fte;
                ctrl_Sucbod.cmb_sucursal.Location = new Point(27, 5);
                ctrl_Sucbod.cmb_bodega.Location = new Point(27, 27);
               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

         tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        prd_Obra_Bus Obra_B = new prd_Obra_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_OrdenTaller_Bus OrdeTaller_B = new prd_OrdenTaller_Bus();
        prd_SubGrupoTrabajo_Bus GrupoTrabajo_B = new prd_SubGrupoTrabajo_Bus();
        prd_EtapaProduccion_Bus Etapa_B = new prd_EtapaProduccion_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Bus BusInve = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> ProductosXEtapa = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        BindingList<prd_ControlProduccionObreroDetalle_Info> ListadoDisponible = new BindingList<prd_ControlProduccionObreroDetalle_Info>();
        prd_ControlProduccionObrero_Bus Bus = new prd_ControlProduccionObrero_Bus();
        prd_EtapaProduccion_Info Etapa = new prd_EtapaProduccion_Info();
        prd_EtapaProduccion_Info EtapaAnterior = new prd_EtapaProduccion_Info();
        prd_ControlProduccion_Obrero_x_in_movi_inve_Bus Contr_x_movi_B = new prd_ControlProduccion_Obrero_x_in_movi_inve_Bus();
        List<prd_ControlProduccion_Obrero_x_in_movi_inve_Info> listMovi = new List<prd_ControlProduccion_Obrero_x_in_movi_inve_Info>();
        private Cl_Enumeradores.eTipo_action _Accion;
        FrmPrd_BusquedaCodigoBarraDisponible frmBusqueda = new FrmPrd_BusquedaCodigoBarraDisponible();
        prd_parametros_CusCidersus_Bus BusParmetros = new prd_parametros_CusCidersus_Bus();

        BindingList<prd_MovPteGrua_Det_Info> Prod = new BindingList<prd_MovPteGrua_Det_Info>();
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
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
      

        void frmBusqueda_event_frmPrd_BusquedaCodigoBarraDisponible_FormClosing(object info, EventArgs e)
        {
            try
            {
                   MessageBox.Show(((in_movi_inve_detalle_x_Producto_CusCider_Info)(info)).IdProducto.ToString());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

           
        }

        private void cmbObra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbOrdenTaller.Properties.DataSource = OrdeTaller_B.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, cmbObra.EditValue.ToString());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbOrdenTaller_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbGrupoAsignado.Properties.DataSource = GrupoTrabajo_B.ObtenerGrupoTrabajoCab_x_OT(
                    param.IdEmpresa, Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue), Convert.ToDecimal(cmbOrdenTaller.EditValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbGrupoAsignado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Etapa = new prd_EtapaProduccion_Info();
                EtapaAnterior = new prd_EtapaProduccion_Info();
                var Grupo = ((List<prd_SubGrupoTrabajo_Info>)(cmbGrupoAsignado.Properties.DataSource)).First(V => V.IdGrupoTrabajo == Convert.ToDecimal(cmbGrupoAsignado.EditValue));
                Etapa = Etapa_B.ObtenerEtapa(param.IdEmpresa, Grupo.IdEtapa, Grupo.IdProcesoProductivo);
                txtEtapa.Text = Etapa.NombreEtapa;
                EtapaAnterior = Etapa_B.ObtenerEtapaAnterior(param.IdEmpresa, (Etapa.Posicion - 1), Etapa.IdProcesoProductivo);
                if (EtapaAnterior != null && EtapaAnterior.NombreEtapa != null)
                {
                    txtEtapaAnterior.Text = EtapaAnterior.NombreEtapa;

                    in_movi_inve_detalle_x_Producto_CusCider_Info Info = new in_movi_inve_detalle_x_Producto_CusCider_Info();

                    var OrdenTaller = ((List<prd_OrdenTaller_Info>)(cmbOrdenTaller.Properties.DataSource)).First(v => v.IdOrdenTaller == Convert.ToDecimal(cmbOrdenTaller.EditValue));
                    Info.ot_IdOrdenTaller = OrdenTaller.IdOrdenTaller;
                    Info.ot_IdEmpresa = OrdenTaller.IdEmpresa;
                    Info.ot_IdSucursal = OrdenTaller.IdSucursal;
                    Info.et_IdEtapa = EtapaAnterior.IdEtapa;
                    Info.et_IdEmpresa = EtapaAnterior.IdEmpresa;
                    Info.et_IdProcesoProductivo = EtapaAnterior.IdProcesoProductivo;
                    Info.IdEmpresa = param.IdEmpresa;
                    Info.IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue);
                    Info.IdBodega = Convert.ToInt32(ctrl_Sucbod.cmb_bodega.EditValue);

                    ProductosXEtapa = BusInve.ConsultaSaldosxCtrlProd(Convert.ToInt32(Info.ot_IdEmpresa), Convert.ToInt32(Info.et_IdEmpresa), Convert.ToInt32(Info.et_IdEtapa), Convert.ToInt32(Info.et_IdProcesoProductivo), Convert.ToInt32(Info.ot_IdEmpresa),
                        Info.IdSucursal, cmbObra.EditValue.ToString(), Convert.ToDecimal(Info.ot_IdOrdenTaller)).FindAll(v => v.dm_cantidad > 0);
                    ListadoDisponible = new BindingList<prd_ControlProduccionObreroDetalle_Info>();
                    foreach (var item in ProductosXEtapa)
                    {
                        prd_ControlProduccionObreroDetalle_Info info = new prd_ControlProduccionObreroDetalle_Info();
                        info.CodBarraMaestro = item.CodigoBarra;
                        info.Cantidad = 1;
                        var Producto = Prod_b.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                        info.pr_descripcion = Producto.pr_descripcion;
                        info.IdProducto = item.IdProducto;
                        info.IdEmpresa = param.IdEmpresa;
                        ListadoDisponible.Add(info);
                    }

                    gridControlDisponible.DataSource = ListadoDisponible;
                    gridControlDisponible.RefreshDataSource();

                    txtCantDisponible.Text = ProductosXEtapa.ToList().Count.ToString();
                    List<prd_ControlProduccionObreroDetalle_Info> LstDet = new List<prd_ControlProduccionObreroDetalle_Info>();
                    foreach (var item in ProductosXEtapa)
                    {
                        prd_ControlProduccionObreroDetalle_Info Ob = new prd_ControlProduccionObreroDetalle_Info();
                        LstDet.Add(Ob);
                    }

                }
                else
                {
                    txtEtapaAnterior.Text = "";
                    txtCantDisponible.Text = "0";
                    ListadoDisponible = new BindingList<prd_ControlProduccionObreroDetalle_Info>();
                    gridControlDisponible.DataSource = ListadoDisponible;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }




        }

        in_producto_Bus Prod_b = new in_producto_Bus();
       
        public prd_ControlProduccionObrero_Info _SetInfo { get; set; }
        void Set() 
        {
            try
            {
                txtId.Text = _SetInfo.IdControlProduccionObrero.ToString();
                ctrl_Sucbod.Enabled = false;
                if (_SetInfo.Estado == "I")
                {
                    lblAnulado.Visible = true;
                    
                }
                in_producto_Bus PrdBus = new in_producto_Bus();
                ctrl_Sucbod.cmb_sucursal.EditValue = _SetInfo.IdSucursal;

                ctrl_Sucbod.cmb_bodega.EditValue = _SetInfo.IdBodega;
                txtCantDisponible.Text = _SetInfo.CantAsignada.ToString();
                cmbObra.EditValue = _SetInfo.CodObra;
                cmbOrdenTaller.EditValue = _SetInfo.IdOrdenTaller;
                cmbGrupoAsignado.EditValue = _SetInfo.IdGrupoTrabajo;
                txtObservacion.Text = _SetInfo.Observacion;
                prd_ControlProduccionObreroDetalle_Bus detBus = new prd_ControlProduccionObreroDetalle_Bus();
                var Detalle = detBus.ObtenerCtrlPrdDetalle(_SetInfo.IdControlProduccionObrero, param.IdEmpresa, _SetInfo.IdSucursal);
                foreach (var item in Detalle)
                {
                    item.pr_descripcion = PrdBus.Get_Descripcion_Producto(param.IdEmpresa, item.IdProducto);
                }
  
                ListadoDisponible = new BindingList<prd_ControlProduccionObreroDetalle_Info>();
                ListadoDisponible = new BindingList<prd_ControlProduccionObreroDetalle_Info>(Detalle);
                gridControlDisponible.DataSource = ListadoDisponible;
                gridControlDisponible.RefreshDataSource();

                var Movimientos = BusInve.ConsultaMovimienosxCtrlProd(_SetInfo.IdControlProduccionObrero,
                    _SetInfo.IdSucursal, _SetInfo.IdEmpresa, ref msgs);

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }

        }
       
        prd_ControlProduccionObrero_Info _Info;
        List<prd_ControlProduccionObreroDetalle_Info> _ListDetalle ;
        void Get() 
        {
            try
            {
                _Info = new prd_ControlProduccionObrero_Info();
                _ListDetalle = new List<prd_ControlProduccionObreroDetalle_Info>();
                _Info.CantAsignada = Convert.ToDouble(txtCantDisponible.Text);
                _Info.CodObra = cmbObra.EditValue.ToString();
                _Info.FechaRegistro = Convert.ToDateTime(dtpFecha.Value);
                _Info.IdEmpleado = ((List<prd_SubGrupoTrabajo_Info>)(cmbGrupoAsignado.Properties.DataSource)).First(V => V.IdGrupoTrabajo == Convert.ToDecimal(cmbGrupoAsignado.EditValue)).IdLider;
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdGrupoTrabajo = Convert.ToDecimal(cmbGrupoAsignado.EditValue);
                _Info.IdOrdenTaller = Convert.ToDecimal(cmbOrdenTaller.EditValue);
                _Info.IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue);
                _Info.IdBodega = Convert.ToInt32(ctrl_Sucbod.cmb_bodega.EditValue);
                _Info.Observacion = txtObservacion.Text + 
                    " Prd x Ob" + cmbObra.Text+
                    " Ot "+ cmbOrdenTaller.Text+
                    " Gt "+ cmbGrupoAsignado.Text +
                    " Et I "+txtEtapaAnterior.Text+
                    " Et F "+ txtEtapa.Text
                    ;


                //_ListDetalle = ((List<prd_ControlProduccionObreroDetalle_Info>)(gridControlDetalle.DataSource)).FindAll(v => v.CodBarra != "" && v.pr_descripcion != "" && v.Cantidad != 0);
                foreach (var item in ListadoDisponible)
                {
                    if (item.Checked == true)
                    { 
                        item.IdEmpresa = param.IdEmpresa;
                        item.IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue);
                    _ListDetalle.Add(item);
                    }
                }
                 
                
                _Info.IdControlProduccionObrero = Convert.ToDecimal((txtId.Text == "") ? "0" : txtId.Text);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
            
        }
        string msgs = "";

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txtEtapa.Focus();
                if (Validar())
                {
                    Get();
                    string mnj = "";
                    decimal Id = 0;
                    if (_ListDetalle.Count != 0)
                    {
                        if (Bus.GrabarCabeceraDB(param.IdEmpresa, _Info, _ListDetalle, ref mnj, ref Id))
                        {
                            txtId.Text = Id.ToString();


                            GenerarMovimientoInvenario();
                            listMovi.ForEach(v => { v.cp_IdEmpresa = param.IdEmpresa; v.cp_IdControlProduccionObrero = Id; v.cp_IdSucursal = _Info.IdSucursal; });
                            foreach (var item in listMovi)
                            {
                                Contr_x_movi_B.GuardarDB(item);
                            }
                            
                            MessageBox.Show(mnj);
                            {
                                setAccion(Cl_Enumeradores.eTipo_action.consultar);
                                _SetInfo = _Info;
                                _SetInfo.IdControlProduccionObrero = Id;
                               
                                Set();
                                this.frmPrd_ControlProduccionxGrupo_Mant_Load(sender,e );
                            
                            
                            }

                        }
                        else
                        {
                            MessageBox.Show(mnj);
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Ingrese Al menos Un Producto");
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
        void GenerarMovimientoInvenario() 
        {

            try
            {
                decimal IdMoviInvenIngres = 0;
                string mensaje_cbte_cble = "";

                in_producto_x_tb_bodega_Bus prod_B = new in_producto_x_tb_bodega_Bus();
                in_movi_inve_detalle_x_Producto_CusCider_Bus CusCidersus_B = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
               
                in_movi_inve_Bus in_Movi_B = new in_movi_inve_Bus();
                in_movi_inve_detalle_x_Producto_CusCider_Bus BusCusCidersu = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
                var OrdenTaller = ((List<prd_OrdenTaller_Info>)(cmbOrdenTaller.Properties.DataSource)).First(v => v.IdOrdenTaller == Convert.ToDecimal(cmbOrdenTaller.EditValue));
                var Parametros = BusParmetros.ObtenerObjeto(param.IdEmpresa);
                prd_ControlProduccion_Obrero_x_in_movi_inve_Info MoviXcConv;
                in_movi_inve_Info MoviInfo = new in_movi_inve_Info();
                MoviInfo.IdEmpresa = param.IdEmpresa;
                MoviInfo.cm_fecha = Convert.ToDateTime(dtpFecha.Value);
                MoviInfo.cm_observacion = txtObservacion.Text +
                    " Eg x Prd x Ob" + cmbObra.Text +
                    " Ot " + cmbOrdenTaller.Text +
                    " Gt " + cmbGrupoAsignado.Text +
                    " Et I " + txtEtapaAnterior.Text +
                    " Et F " + txtEtapa.Text
                    ;
                MoviInfo.cm_tipo = "-";
                MoviInfo.IdBodega = Convert.ToInt32(ctrl_Sucbod.cmb_bodega.EditValue);
                MoviInfo.IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue);
                MoviInfo.IdMovi_inven_tipo = Convert.ToInt32(Parametros.IdMovi_inven_tipo_egr_ContrlProduccion);

                in_producto_Bus busprod = new in_producto_Bus();
                List<in_movi_inve_detalle_Info> Listdetalle = new List<in_movi_inve_detalle_Info>();
                
                foreach (var item in _ListDetalle)
                {
                    in_movi_inve_detalle_Info Obj = new in_movi_inve_detalle_Info();

                    var Producto = prod_B.Get_Info_Producto_x_Producto(param.IdEmpresa, MoviInfo.IdSucursal, MoviInfo.IdBodega, item.IdProducto);
                    Obj.IdProducto = item.IdProducto;
                    Obj.IdSucursal = MoviInfo.IdSucursal;
                    Obj.IdBodega = MoviInfo.IdBodega;
                    Obj.IdEmpresa = param.IdEmpresa;
                    Obj.IdMovi_inven_tipo = MoviInfo.IdMovi_inven_tipo;
                    Obj.IdProducto = item.IdProducto;
                    Obj.mv_costo = ProductosXEtapa.First(v => v.IdProducto == item.IdProducto).mv_costo;
                    Obj.dm_precio = ProductosXEtapa.First(v => v.IdProducto == item.IdProducto).dm_precio;
                    Obj.mv_tipo_movi = "-";
                    Obj.dm_stock_actu = Producto.pr_stock - 1;
                    Obj.dm_stock_ante = Producto.pr_stock;
                    
                    var prod = busprod.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                    Obj.dm_observacion = " Prod " + prod.pr_descripcion;
                    Obj.dm_observacion = MoviInfo.cm_observacion + Obj.dm_observacion;
                    
                    Obj.dm_cantidad = -1;


                    MoviInfo.listmovi_inve_detalle_Info.Add(Obj);
                }

                decimal IdMoviInven = 0;
                string Msj = "";
                int c = 1;
                
                if (in_Movi_B.GrabarDB(MoviInfo, ref IdMoviInven, ref mensaje_cbte_cble ,ref Msj) == false)
                {
                    MessageBox.Show(Msj, "Movimiento Egreso");
                }
                else
                {
                    MoviXcConv = new prd_ControlProduccion_Obrero_x_in_movi_inve_Info();
                    MoviXcConv.mv_IdBodega = MoviInfo.IdBodega;
                    MoviXcConv.mv_IdEmpresa = MoviInfo.IdEmpresa;
                    MoviXcConv.mv_IdMovi_inven_tipo = MoviInfo.IdMovi_inven_tipo;
                    MoviXcConv.mv_IdNumMovi = IdMoviInven;
                    MoviXcConv.mv_IdSucursal = MoviInfo.IdSucursal;
                    listMovi.Add(MoviXcConv);
                    
                    MoviInfo.cm_tipo = "+";
                    MoviInfo.IdNumMovi = 0;
                    MoviInfo.IdMovi_inven_tipo = Convert.ToInt32(Parametros.IdMovi_inven_tipo_ing_ContrlProduccion);
                    MoviInfo.cm_observacion = txtObservacion.Text +
                    " Ing x Prd x Ob" + cmbObra.Text +
                    " Ot " + cmbOrdenTaller.Text +
                    " Gt " + cmbGrupoAsignado.Text +
                    " Et I " + txtEtapaAnterior.Text +
                    " Et F " + txtEtapa.Text
                    ;

                    foreach (var v in MoviInfo.listmovi_inve_detalle_Info)
                    {
                        v.mv_tipo_movi = "+"; v.IdMovi_inven_tipo = MoviInfo.IdMovi_inven_tipo; v.dm_cantidad = 1;
                        v.dm_stock_actu = v.dm_stock_actu + 1;
                        v.dm_stock_ante = v.dm_stock_actu;
                        var prod = busprod.Get_Info_BuscarProducto(v.IdProducto, param.IdEmpresa);
                        v.dm_observacion = " Prod " + prod.pr_descripcion;
                        v.dm_observacion = MoviInfo.cm_observacion + v.dm_observacion;
                    }
                
                    if (in_Movi_B.GrabarDB(MoviInfo, ref IdMoviInvenIngres,ref mensaje_cbte_cble, ref Msj) == false)
                    {
                        MessageBox.Show(Msj, "Movimiento Ingreso");
                    }
                    MoviXcConv = new prd_ControlProduccion_Obrero_x_in_movi_inve_Info();
                    MoviXcConv.mv_IdBodega = MoviInfo.IdBodega;
                    MoviXcConv.mv_IdEmpresa = MoviInfo.IdEmpresa;
                    MoviXcConv.mv_IdMovi_inven_tipo = MoviInfo.IdMovi_inven_tipo;
                    MoviXcConv.mv_IdNumMovi = IdMoviInvenIngres;
                    MoviXcConv.mv_IdSucursal = MoviInfo.IdSucursal;
                    listMovi.Add(MoviXcConv);
                }

                List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListCidersusInfo = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                foreach (var item in _ListDetalle)
                {
                    in_movi_inve_detalle_x_Producto_CusCider_Info CusCidersusInfo = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    CusCidersusInfo.IdEmpresa = param.IdEmpresa;
                    CusCidersusInfo.CodigoBarra = item.CodBarraMaestro;
                    CusCidersusInfo.dm_cantidad = -1;
                    //CusCidersusInfo.dm_observacion = MoviInfo.cm_observacion;
                    var prod = busprod.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                    CusCidersusInfo.dm_observacion =
                        txtObservacion.Text +
                    " Eg x Prd x Ob" + cmbObra.Text +
                    " Ot " + cmbOrdenTaller.Text +
                    " Gt " + cmbGrupoAsignado.Text +
                    " Et I " + txtEtapaAnterior.Text +
                    " Et F " + txtEtapa.Text+
                    " Prod " + prod.pr_descripcion
                        ;
                   
                    CusCidersusInfo.dm_precio = ProductosXEtapa.First(v => v.IdProducto == item.IdProducto).dm_precio;
                    CusCidersusInfo.et_IdEmpresa = param.IdEmpresa;
                    CusCidersusInfo.et_IdEtapa = EtapaAnterior.IdEtapa;
                    CusCidersusInfo.et_IdProcesoProductivo = EtapaAnterior.IdProcesoProductivo;
                    CusCidersusInfo.IdBodega = MoviInfo.IdBodega;
                    CusCidersusInfo.IdSucursal = MoviInfo.IdSucursal;
                    CusCidersusInfo.IdMovi_inven_tipo = Convert.ToInt32(Parametros.IdMovi_inven_tipo_egr_ContrlProduccion);
                    CusCidersusInfo.IdNumMovi = IdMoviInven;
                    CusCidersusInfo.IdProducto = item.IdProducto;
                    CusCidersusInfo.mv_costo = ProductosXEtapa.First(v => v.IdProducto == item.IdProducto).mv_costo;
                    CusCidersusInfo.ot_CodObra = OrdenTaller.CodObra;
                    CusCidersusInfo.ot_IdEmpresa = OrdenTaller.IdEmpresa;
                    CusCidersusInfo.ot_IdOrdenTaller = OrdenTaller.IdOrdenTaller;
                    CusCidersusInfo.ot_IdSucursal = OrdenTaller.IdSucursal;
                    CusCidersusInfo.mv_Secuencia = c;
                    CusCidersusInfo.mv_tipo_movi = "-";
                    c++;
                    ListCidersusInfo.Add(CusCidersusInfo);
                }


                if (BusCusCidersu.GuardarDB(ListCidersusInfo, ref Msj) == false)
                { MessageBox.Show(Msj, "Cus Cidersus Egreso"); }
                else
                {
                    foreach (var v in ListCidersusInfo)
                    {
                        v.dm_cantidad = 1;
                        v.et_IdEtapa = Etapa.IdEtapa; 
                        v.et_IdProcesoProductivo = Etapa.IdProcesoProductivo; 
                        v.IdMovi_inven_tipo = Convert.ToInt32(Parametros.IdMovi_inven_tipo_ing_ContrlProduccion);
                        v.IdNumMovi = IdMoviInvenIngres; v.mv_tipo_movi = "+";
                        var prod = busprod.Get_Info_BuscarProducto(v.IdProducto, param.IdEmpresa);
                        v.dm_observacion =
                            txtObservacion.Text +
                        " Ing x Prd x Ob" + cmbObra.Text +
                        " Ot " + cmbOrdenTaller.Text +
                        " Gt " + cmbGrupoAsignado.Text +
                        " Et I " + txtEtapaAnterior.Text +
                        " Et F " + txtEtapa.Text +
                        " Prod " + prod.pr_descripcion
                            ;
                    }
                    
                    if (BusCusCidersu.GuardarDB(ListCidersusInfo, ref Msj) == false)
                    { MessageBox.Show(Msj, "Cus Cidersus Ingreso"); }
                }


                //Contr_x_movi_B.
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }


        }


        public Boolean Validar() 
        {
            try
            {
                if (string.IsNullOrEmpty(txtObservacion.Text)) 
                {
                    MessageBox.Show("Ingrese Observacion");
                    return false;
                }
                if (string.IsNullOrEmpty(cmbGrupoAsignado.Text)) 
                {
                    MessageBox.Show("Seleccione GT");
                    return false;
                }
                if (cmbObra.EditValue == null || cmbObra.Text == "[Vacio]" || cmbObra.Text == "")
                {
                    MessageBox.Show("Seleccione Obra");
                    return false;
                }
                if (cmbOrdenTaller.EditValue == null || cmbOrdenTaller.Text == "[Vacio]" || cmbOrdenTaller.Text == "")
                {
                    MessageBox.Show("Seleccione OT");
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

        private void frmPrd_ControlProduccionxGrupo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
               
                var Parametros = BusParmetros.ObtenerObjeto(param.IdEmpresa);
                ctrl_Sucbod.cmb_sucursal.EditValue = Parametros.IdSucursal_Produccion;
                ctrl_Sucbod.cmb_bodega.EditValue = Parametros.IdBodega_Produccion;

                switch (_Accion)
                {
                   
                    case Cl_Enumeradores.eTipo_action.consultar:
                        btn_guardar.Enabled = false;
                        cmbGrupoAsignado.Enabled = false;
                        cmbObra.Enabled = false;
                        cmbOrdenTaller.Enabled = false;
                        ctrl_Sucbod.cmb_bodega.Enabled = false;
                        ctrl_Sucbod.cmb_sucursal.Enabled = false;
                        Set();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
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

      
           void cargacodbarra(in_movi_inve_detalle_x_Producto_CusCider_Info info){}
        
        string msg = "";

        List<vwprd_Ensamblado_CabDet_CusCider_Info> LstEnsab = new List<vwprd_Ensamblado_CabDet_CusCider_Info>();
        prd_Ensamblado_CusCider_Bus BusEnsa = new prd_Ensamblado_CusCider_Bus();
        Boolean Find = false;
        void buscarenlistado()
        {
            try
            {
                if (string.IsNullOrEmpty(cmbGrupoAsignado.Text) || cmbGrupoAsignado.Text == "[Vacío]" || cmbGrupoAsignado.Text == "")
                {
                    MessageBox.Show("Seleccione GT");
                    return ;
                }
                if (cmbObra.EditValue == null || cmbObra.Text == "[Vacio]" || cmbObra.Text == "")
                {
                    MessageBox.Show("Seleccione Obra");
                    return ;
                }
                if (cmbOrdenTaller.EditValue == null || cmbOrdenTaller.Text == "[Vacio]" || cmbOrdenTaller.Text == "")
                {
                    MessageBox.Show("Seleccione OT");
                    return ;
                }

                if (!String.IsNullOrEmpty(txtIngCB.Text) || !String.IsNullOrWhiteSpace(txtIngCB.Text))
                {

                    Find = false;
                    if (ListadoDisponible.Count > 0)
                    {
                        var codbarramaestro = BusEnsa.buscacodbarramaestro(param.IdEmpresa, txtIngCB.Text, ref msg);

                        prd_ControlProduccionObreroDetalle_Info agregado = new prd_ControlProduccionObreroDetalle_Info();

                        foreach (var item in ListadoDisponible)
                        {
                            if (codbarramaestro != null)
                            {
                                if (item.CodBarraMaestro == codbarramaestro.CodigoBarra || item.CodBarraMaestro == codbarramaestro.CBMaestro)
                                {
                                    item.Checked = true; item.CodBarra = txtIngCB.Text;
                                    string[] Time = DateTime.Now.ToString("hh:mm").Split(':');
                                    item.HoraInicio = new TimeSpan(Convert.ToInt32(Time[0]), Convert.ToInt32(Time[1]), 0);
                                    agregado = item; Find = true;
                                }
                            }
                            else
                                if (item.CodBarraMaestro == txtIngCB.Text)
                                {
                                    item.Checked = true; item.CodBarra = txtIngCB.Text;
                                    string[] Time = DateTime.Now.ToString("hh:mm").Split(':');
                                    item.HoraInicio = new TimeSpan(Convert.ToInt32(Time[0]), Convert.ToInt32(Time[1]), 0);
                                    agregado = item; Find = true;
                                }

                        }
                        if (Find == true)
                        {
                            List<prd_ControlProduccionObreroDetalle_Info> listatemp = new List<prd_ControlProduccionObreroDetalle_Info>();
                            foreach (var item in ListadoDisponible)
                            {
                                if (item.CodBarraMaestro != agregado.CodBarraMaestro)
                                    listatemp.Add(item);
                            }

                            ListadoDisponible = new BindingList<prd_ControlProduccionObreroDetalle_Info>();
                            ListadoDisponible.Add(agregado);
                            foreach (var item in listatemp)
                            {
                                ListadoDisponible.Add(item);
                            }

                            gridControlDisponible.DataSource = ListadoDisponible;
                            gridControlDisponible.RefreshDataSource();
                            MessageBox.Show("Agregado","Sistema");
                            txtIngCB.Text = "";

                        }
                        else if (preguntar == true)
                        {
                            MessageBox.Show("Código no encontrado","Sistema");


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        Boolean preguntar = false;
        private void txtIngCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var car = e.KeyChar.ToString();
                if (e.KeyChar.ToString() == "\r")
                { preguntar = true; buscarenlistado(); }
                else preguntar = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewDisponible_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Checked")
                {
                    KeyPressEventArgs v = new KeyPressEventArgs(Convert.ToChar("\r"));

                    //
                    if (Convert.ToBoolean(e.CellValue) == true)
                    {
                        gridViewDisponible.SetFocusedRowCellValue("Checked", false);
                    }
                    else
                    {

                        var reg = (prd_ControlProduccionObreroDetalle_Info)gridViewDisponible.GetFocusedRow();
                        if (reg != null && reg.CodBarraMaestro != null)
                        { txtIngCB.Text = reg.CodBarraMaestro; txtIngCB_KeyPress(sender, v); }

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
