using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
//version 09082013 09:32

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_MovilDespacho : Form
    {
        public FrmPrd_MovilDespacho()
        {
              try
            {
                InitializeComponent();
                gridControlDisponible.DataSource = Prod;
                iniciar_controles();
                cambiacontroles();

            }
            catch (Exception ex)
              {
                  Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                 grabar();
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
                
                
                //UCObra.UC_Obra.Size = new Size(170, 18);
                //UCObra.UC_Obra.Font = fte;
                //UCObra.label.Font = fte;
                //UCObra.label.Text = "OB:";
                //UCObra.label.Location = new Point(0, 3);
                //UCObra.UC_Obra.Location = new Point(27, 3);

                UCFa_Cliente.cmb_cliente.Size = new Size(170, 18);
                UCFa_Cliente.label1.Text = "CLI:";
                UCFa_Cliente.label1.Location = new Point(0, 3);
                UCFa_Cliente.cmb_cliente.Location = new Point(27, 3);

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
                  this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //instancias de centro de costo
        UCPrd_Obra UCObra = new UCPrd_Obra();

        prd_Despacho_Info InfoCabDespacho = new prd_Despacho_Info(); //esta es para el get
        prd_Despacho_Bus BusCabDespacho = new prd_Despacho_Bus();


        //instancias de cliente
        UCFa_Cliente_Facturacion UCFa_Cliente = new UCFa_Cliente_Facturacion();

        //instancicas de bodega y sucursal
        tb_Bodega_Info _bodegaInfo = new tb_Bodega_Info();
        tb_Sucursal_Info _sucursalInfo = new tb_Sucursal_Info();
        tb_Bodega_Bus BusBod = new tb_Bodega_Bus();
        tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();

        //instancias para la grid
        BindingList<prd_DespachoDetalle_Info> LstBindingDespachoDet = new BindingList<prd_DespachoDetalle_Info>();
        BindingList<prd_DespachoDetalle_Info> ListadoDisponible = new BindingList<prd_DespachoDetalle_Info>();
        List<prd_DespachoDetalle_Info> LstDetDespacho = new List<prd_DespachoDetalle_Info>();
        List<prd_DespachoDetalle_Info> LstDetDespachoModif = new List<prd_DespachoDetalle_Info>();
        prd_DespachoDetalle_Bus BusDetDespacho = new prd_DespachoDetalle_Bus();

        //instancias generales
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;
        prd_parametros_CusCidersus_Info paramCidersus = new prd_parametros_CusCidersus_Info();
        prd_parametros_CusCidersus_Bus Busparam = new prd_parametros_CusCidersus_Bus();


        in_movi_inve_Info CabMov = new in_movi_inve_Info();
        in_movi_inve_Bus busMov = new in_movi_inve_Bus();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstMovxProd = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus busMovxProd = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        BindingList<vwIn_Movi_Inven_CusCider_Cab_Info> MovBind = new BindingList<vwIn_Movi_Inven_CusCider_Cab_Info>();
        #endregion


        void UCObra_Event_UCObra_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (UCObra.get_item_info() == null)
                {
                    ListadoDisponible = new BindingList<prd_DespachoDetalle_Info>();
                    gridControlDisponible.DataSource = ListadoDisponible;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void iniciar_controles()
        {
            try
            {
                //carga obra
                UCObra.cargaCmb_Obra();
                PanelObra.Controls.Add(UCObra);
                UCObra.Dock = DockStyle.Fill;
                UCObra.Event_UCObra_SelectionChanged += new UCPrd_Obra.delegadoUCObra_SelectionChanged(UCObra_Event_UCObra_SelectionChanged);
                //carga clientes
                panel_cliente.Controls.Add(UCFa_Cliente);
                UCFa_Cliente.Dock = DockStyle.Fill;
              //  UCObra.label.Location = new Point(13, 0);
                UCObra.UC_Obra.Location = new Point(86, 1);
                UCObra.UC_Obra.Size = new System.Drawing.Size(374, 20);
                UCFa_Cliente.cmb_cliente.Location = new Point(86, 1);
                UCFa_Cliente.cmb_cliente.Size = new System.Drawing.Size(374, 20);
                UCFa_Cliente.label1.Location = new Point(13, 4);
             

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
             Accion = iAccion;
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                           this.txtNumDespacho.Text = "0";
                            break;
              
                    
                        default:
                            break;
                    }
            }
            catch ( Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }

        void UCObra_Event_UCObra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                  cargadata();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        prd_EtapaProduccion_Info etapa = new prd_EtapaProduccion_Info();
        void cargadata()
        {
            try
            {
                etapa = new prd_EtapaProduccion_Info();
                ListProdDisp = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();

                prd_EtapaProduccion_Bus busEta = new prd_EtapaProduccion_Bus();
                var listetapa = (List<prd_EtapaProduccion_Info>)busEta.EtapaMaxObra(UCObra.get_item(), ref msg);
                etapa = listetapa.First();

                //ListProdDisp = busProdDisp.ConsultaSaldosxDespachoxObra(param.IdEmpresa,
                //    etapa.IdEtapa, etapa.IdProcesoProductivo, param.IdEmpresa, UCObra.get_item(),
                //    Convert.ToInt32(ctrl_Sucbod.cmb_bodega.EditValue),
                //    Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue), ref msg);
                ListadoDisponible = new BindingList<prd_DespachoDetalle_Info>();
                foreach (var item in ListProdDisp)
                {
                    prd_DespachoDetalle_Info info = new prd_DespachoDetalle_Info();
                    info.Cantidad = 1;
                    info.CodigoBarraMaestro = item.CodigoBarra;
                    info.IdProducto = item.IdProducto;
                    info.IdOrdenTaller = item.ot_IdOrdenTaller;
                    var ot = BusOT.ObtenerUnaOT(param.IdEmpresa, Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue), Convert.ToDecimal(info.IdOrdenTaller), UCObra.get_item());
                    info.ot_descripcion = ot.Codigo;
                    info.peso = ot.PesoUnitario;
                    var Prodaaa = busProd.Get_info_Product(param.IdEmpresa, item.IdProducto);
                    info.CodigoBarraMaestro = info.CodigoBarraMaestro;
                    info.pr_descripcion = Prodaaa.pr_descripcion;
                    ListadoDisponible.Add(info);

                }

                gridControlDisponible.DataSource = ListadoDisponible;
                gridControlDisponible.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        List<vwprd_Ensamblado_CabDet_CusCider_Info> LstEnsab = new List<vwprd_Ensamblado_CabDet_CusCider_Info>();
        prd_Ensamblado_CusCider_Bus BusEnsa = new prd_Ensamblado_CusCider_Bus();


        void buscarenlistado()
        {
            try
            {
                if (UCObra.get_item_info() == null)
                {
                    MessageBox.Show("Seleccione una Obra.",
                          "Sistema", MessageBoxButtons.OK);
                    return;
                }

                if (!String.IsNullOrEmpty(txtIngCB.Text) || !String.IsNullOrWhiteSpace(txtIngCB.Text))
                {
                    Boolean Find = false;

                    if (ListadoDisponible.Count > 0)
                    {
                        var codbarramaestro = BusEnsa.buscacodbarramaestro(param.IdEmpresa, txtIngCB.Text, ref msg);

                        prd_DespachoDetalle_Info agregado = new prd_DespachoDetalle_Info();

                        foreach (var item in ListadoDisponible)
                        {
                            if (codbarramaestro != null)
                            {
                                if (item.CodigoBarraMaestro == codbarramaestro.CodigoBarra || item.CodigoBarraMaestro == codbarramaestro.CBMaestro)
                                {
                                    item.Checked = true; item.CodigoBarra = txtIngCB.Text;
                                    string[] Time = DateTime.Now.ToString("hh:mm").Split(':');
                                    item.Hora = new TimeSpan(Convert.ToInt32(Time[0]), Convert.ToInt32(Time[1]), 0);
                                    agregado = item; Find = true;
                                }
                            }
                            else
                                if (item.CodigoBarraMaestro == txtIngCB.Text)
                                {
                                    item.Checked = true; item.CodigoBarra = txtIngCB.Text;
                                    string[] Time = DateTime.Now.ToString("hh:mm").Split(':');
                                    item.Hora = new TimeSpan(Convert.ToInt32(Time[0]), Convert.ToInt32(Time[1]), 0);
                                    agregado = item; Find = true;
                                }

                        }
                        if (Find == true)
                        {
                            List<prd_DespachoDetalle_Info> listatemp = new List<prd_DespachoDetalle_Info>();
                            foreach (var item in ListadoDisponible)
                            {
                                if (item.CodigoBarraMaestro != agregado.CodigoBarraMaestro)
                                    listatemp.Add(item);
                            }

                            ListadoDisponible = new BindingList<prd_DespachoDetalle_Info>();
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
        //
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
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListProdDisp = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus busProdDisp = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        prd_OrdenTaller_Bus BusOT = new prd_OrdenTaller_Bus();

        List<prd_OrdenTaller_Info> ListOT = new List<prd_OrdenTaller_Info>();
        prd_OrdenTaller_Info infoOT = new prd_OrdenTaller_Info();
        tb_Sucursal_Info suc = new tb_Sucursal_Info();
        //
        private void FrmPrd_DespachoMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                //iniciar_controles();
                //ctrl_Sucbod.cargar_sucursal(param.IdEmpresa );
                paramCidersus = Busparam.ObtenerObjeto(param.IdEmpresa);
                ctrl_Sucbod.cmb_sucursal.EditValue = paramCidersus.IdSucursal_Produccion;
                ctrl_Sucbod.cmb_bodega.EditValue = paramCidersus.IdBodega_Produccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public void setCab(prd_Despacho_Info info)
        {
            try
            {
                InfoCabDespacho = info;
                { _sucursalInfo.IdEmpresa = _bodegaInfo.IdEmpresa = info.IdEmpresa; _sucursalInfo.IdSucursal = _bodegaInfo.IdSucursal = info.IdSucursal; _bodegaInfo.IdBodega = info.IdBodega; }

                txtId.Text = Convert.ToString(info.IdDespacho);
                txtNumDespacho.Text = info.NumDespacho;
                txtGuia.Text = info.NumGuiaRemision;
                
                ctrl_Sucbod.set_sucursal(_sucursalInfo);
                ctrl_Sucbod.set_bodega(_bodegaInfo);
                UCObra.set_item(info.CodObra);
                txtPuntoPartida.Text = info.PuntoPartida;
                cmbTipTransporte.Text = info.TipoTransporte;
                txtPuntoLLegada.Text = info.PuntoLLegada;
                txtPlaca.Text = info.Placa;
                txtChofer.Text = info.Chofer;
                txtObservacion.Text = info.Observacion;
                dtpFechaReg.Value = info.FechaReg;
                dtpFInicio.Value = info.FechaIniTras;
                dtpFFin.Value = info.FechaFinTras;
                UCFa_Cliente.cmb_cliente.EditValue = info.IdCliente;
                LstDetDespacho = BusDetDespacho.ObtenerDespachoDetalle(info.IdDespacho, info.IdEmpresa, info.IdSucursal);
                if (info.Estado == "I") lblAnulado.Visible = true; else lblAnulado.Visible = false;
                foreach (var item in LstDetDespacho)
                {
                    var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, item.IdEmpresa);
                    var ot = BusOT.ObtenerUnaOT(item.IdEmpresa, item.IdSucursal, Convert.ToDecimal(item.IdOrdenTaller), info.CodObra);
                    item.pr_descripcion = prod.pr_descripcion;
                    item.ot_descripcion = ot.Codigo;

                }

                ListadoDisponible = new BindingList<prd_DespachoDetalle_Info>();
                ListadoDisponible = new BindingList<prd_DespachoDetalle_Info>(LstDetDespacho);
                gridControlDisponible.DataSource = ListadoDisponible;

                prd_Despacho_cusCidersus_x_in_movi_inven_Bus busTI = new prd_Despacho_cusCidersus_x_in_movi_inven_Bus();
                prd_Despacho_cusCidersus_x_in_movi_inven_Info TI = new prd_Despacho_cusCidersus_x_in_movi_inven_Info();


                {
                    TI = busTI.TI_x_Despacho(info, ref msg);
                    List<vwIn_Movi_Inven_CusCider_Cab_Info> Lstmov = new List<vwIn_Movi_Inven_CusCider_Cab_Info>();

                    Lstmov = busMovxProd.ConsultaMovimientos(TI.IdEmpresa, TI.IdSucursal, TI.IdBodega,
                        TI.IdNumMovi, TI.IdMovi_inven_tipo);

            

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); 
            }
        }


        private Boolean validar()
        {
            try
            {
                InfoCabDespacho.IdCliente = Convert.ToDecimal(UCFa_Cliente.cmb_cliente.EditValue);
                if (UCObra.get_item_info() == null)
                {
                    MessageBox.Show("Seleccione una Obra.",
                          "Sistema", MessageBoxButtons.OK);
                    return false;
                }
                else if (UCFa_Cliente.cmb_cliente.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Cliente.",
                            "Sistema", MessageBoxButtons.OK);
                    UCFa_Cliente.cmb_cliente.Focus();
                    return false;
                }
                else if (String.IsNullOrEmpty(txtGuia.Text))
                {
                    MessageBox.Show("Por favor, Ingrese la Guia de Remisión.",
                            "Sistema", MessageBoxButtons.OK);
                    txtGuia.Focus();
                    return false;
                }
                else if (cmbTipTransporte.Text == String.Empty)
                {
                    MessageBox.Show("Seleccione el Tipo de Transporte.",
                            "Sistema", MessageBoxButtons.OK);
                    UCFa_Cliente.cmb_cliente.Focus();
                    return false;
                }
                else if (txtPlaca.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, Ingrese la Placa.",
                            "Sistema", MessageBoxButtons.OK);
                    txtPlaca.Focus();
                    return false;
                }
                else if (txtPuntoLLegada.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, Ingrese el Punto de Llegada.",
                             "Sistema", MessageBoxButtons.OK);
                    txtPuntoLLegada.Focus();
                    return false;
                }
                else if (txtPuntoPartida.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, Ingrese el Punto de Partida.",
                             "Sistema", MessageBoxButtons.OK);
                    txtPuntoPartida.Focus();
                    return false;
                }
                else if (txtChofer.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, Ingrese el Nombre del Chofer.",
                             "Sistema", MessageBoxButtons.OK);
                    txtChofer.Focus();
                    return false;
                }
                else
                {// valida que haya registros en la tabla

                    Boolean valida = false;
                    foreach (var item in ListadoDisponible)
                    {
                        if (item.Checked == true)
                        {

                            valida = true;
                        }
                    }
                    if (valida == false)
                    {
                        MessageBox.Show("Por favor, Ingrese los productos a despachar.",
                                     "Sistema", MessageBoxButtons.OK);
                        return false;
                    }
                    //
                    //if (gridVwDespacho.DataSource != null)
                    //{
                    //   for (int i = 0; i < gridVwDespacho.RowCount; i++)
                    //    {
                    //        var item = (prd_DespachoDetalle_Info) gridVwDespacho.GetRow(i);
                    //        if(item!= null)
                    //            if (item.IdProducto == null || item.IdProducto == 0)
                    //            {
                    //                MessageBox.Show("Por favor, Ingrese productos validos.",
                    //                   "Sistema", MessageBoxButtons.OK);

                    //                return false;
                    //            }
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Por favor, Ingrese los productos a despachar.",
                    //             "Sistema", MessageBoxButtons.OK);

                    //    return false;
                    //}
                } return getDespacho();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); 
                return false; 
            }
        }
        private Boolean getDespacho()
        {

            try
            {
                LstDetDespacho = new List<prd_DespachoDetalle_Info>();
                InfoCabDespacho = new prd_Despacho_Info();
                if (String.IsNullOrEmpty(txtId.Text)) InfoCabDespacho.IdDespacho = 0;
                else InfoCabDespacho.IdDespacho = Convert.ToDecimal(txtId.Text);
                InfoCabDespacho.IdEmpresa = param.IdEmpresa;
                InfoCabDespacho.IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue);
                InfoCabDespacho.IdBodega = Convert.ToInt32(ctrl_Sucbod.cmb_bodega.EditValue);
                InfoCabDespacho.IdCliente = Convert.ToDecimal(UCFa_Cliente.cmb_cliente.EditValue);
                InfoCabDespacho.CodObra = UCObra.get_item();
                InfoCabDespacho.FechaReg = dtpFechaReg.Value;
                InfoCabDespacho.FechaIniTras = dtpFInicio.Value;
                InfoCabDespacho.FechaFinTras = dtpFFin.Value;
                InfoCabDespacho.TipoTransporte = cmbTipTransporte.Text;
                InfoCabDespacho.Placa = txtPlaca.Text;
                InfoCabDespacho.PuntoLLegada = txtPuntoLLegada.Text;
                InfoCabDespacho.PuntoPartida = txtPuntoPartida.Text;
                InfoCabDespacho.Chofer = txtChofer.Text;
                InfoCabDespacho.NumGuiaRemision = txtGuia.Text;
                InfoCabDespacho.NumFactura = "";
                InfoCabDespacho.NumDespacho = txtNumDespacho.Text;
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    InfoCabDespacho.Observacion = txtObservacion.Text + " Eg Suc " + ctrl_Sucbod.cmb_sucursal.Text +
                    " Bod " + ctrl_Sucbod.cmb_bodega.Text +
                    " x Desp Cli " + UCFa_Cliente.cmb_cliente.Text +
                    " Ch " + txtChofer.Text +
                    " PL " + txtPlaca.Text +
                    " x PP " + txtPuntoPartida.Text +
                    " - PLl " + txtPuntoLLegada.Text +
                    "x Ob " + UCObra.get_item();
                }
                //datos para auditoria
                InfoCabDespacho.IdUsuario = param.IdUsuario;
                InfoCabDespacho.FechaTransac = param.Fecha_Transac;

                //detalle
                //LstDetDespacho = (List<prd_DespachoDetalle_Info>)gridCtrlDespacho.DataSource;
                List<prd_DespachoDetalle_Info> listado = new List<prd_DespachoDetalle_Info>();
                foreach (var item in ListadoDisponible)
                {
                    if (item.Checked == true)
                    {
                        item.IdEmpresa = param.IdEmpresa;
                        item.IdSucursal = InfoCabDespacho.IdSucursal;
                        var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);

                        //string cambio = item.CodigoBarra;
                        //item.CodigoBarra = item.CodigoBarraMaestro;
                        //item.CodigoBarraMaestro = cambio;

                        if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                        {
                            LstDetDespacho.Add(item);
                            item.Observacion = InfoCabDespacho.Observacion +
                               " Prod " + prod.pr_descripcion;

                        }
                        else if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                        {
                            item.Observacion = item.Observacion;
                            item.IdDespacho = Convert.ToDecimal(txtId.Text);
                            LstDetDespachoModif.Add(item);
                        }


                    }

                }


                //for (int i = 0; i < gridVwDespacho.RowCount; i++)
                //{
                //    var item = (prd_DespachoDetalle_Info)gridVwDespacho.GetRow(i);
                //    if (item != null)
                //    {
                //        item.IdEmpresa = param.IdEmpresa;
                //        item.IdSucursal = InfoCabDespacho.IdSucursal;
                //        var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);

                //        string cambio = item.CodigoBarra;
                //        item.CodigoBarra = item.CodigoBarraMaestro;
                //        item.CodigoBarraMaestro = cambio;

                //        if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                //        { LstDetDespacho.Add(item); 
                //         item.Observacion = InfoCabDespacho.Observacion +
                //            " Prod " + prod.pr_descripcion;

                //        }
                //        else if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                //        {
                //            item.Observacion = item.Observacion;
                //            item.IdDespacho = Convert.ToDecimal(txtId.Text);
                //            LstDetDespachoModif.Add(item);
                //        }
                //    }
                //}
                if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    InfoCabDespacho.Observacion = txtObservacion.Text;
                    return true;
                }
                return getmov();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); 
                return false;
            }
        }

        string msg = "";

        private Boolean getmov()
        {
            try
            {
                CabMov = new in_movi_inve_Info();
                LstMovxProd = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                CabMov.IdEmpresa = param.IdEmpresa;
                CabMov.IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue);
                CabMov.IdBodega = Convert.ToInt32(ctrl_Sucbod.cmb_bodega.EditValue);
                CabMov.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_invent_tipo_egr_Despacho);
                CabMov.cm_tipo = "-";
                CabMov.cm_fecha = dtpFechaReg.Value;
                CabMov.cm_mes = CabMov.cm_fecha.Month;
                CabMov.cm_anio = CabMov.cm_fecha.Year;
                CabMov.cm_observacion = txtObservacion.Text +
                    " Eg Suc " + ctrl_Sucbod.cmb_sucursal.Text +
                    " Bod " + ctrl_Sucbod.cmb_bodega.Text +
                    " x Desp Cli " + UCFa_Cliente.cmb_cliente.Text +
                    " Ch " + txtChofer.Text +
                    " PL " + txtPlaca.Text +
                    " x PP " + txtPuntoPartida.Text +
                    " - PLl " + txtPuntoLLegada.Text +
                    "x Ob " + UCObra.get_item()

                    ;
                CabMov.IdUsuario = param.IdUsuario;
                CabMov.Fecha_Transac = param.Fecha_Transac;
                CabMov.nom_pc = param.nom_pc;
                CabMov.ip = param.ip;


                int sec = 0;
                //funcion retorna agrupada la Lista

                return funcionagrupadetalle(LstDetDespacho);

                //fin
                //foreach (var item in LstDetDespacho)
                //{
                //    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                //    in_movi_inve_detalle_x_Producto_CusCider_Info xitems = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                //    info.IdEmpresa = xitems.IdEmpresa = param.IdEmpresa;
                //    info.IdSucursal =xitems.IdSucursal= CabMov.IdSucursal;
                //    info.IdBodega = xitems.IdBodega = CabMov.IdBodega;
                //    info.IdMovi_inven_tipo = xitems.IdMovi_inven_tipo =
                //        Convert.ToInt32( paramCidersus.IdMovi_invent_tipo_egr_Despacho);
                //    xitems.mv_Secuencia  = ++sec;
                //    info.mv_tipo_movi  = xitems.mv_tipo_movi = "-";
                //    info.IdProducto = xitems.IdProducto = item.IdProducto ;
                //    info.dm_cantidad  = xitems.dm_cantidad=-1;
                //    info.dm_stock_ante = info.dm_stock_actu;
                //    info.dm_stock_actu = info.dm_stock_actu - 1;
                //    xitems.CodigoBarra = item.CodigoBarra;
                //    xitems.et_IdEmpresa = param.IdEmpresa;
                //    xitems.et_IdEtapa = etapa.IdEtapa ;
                //    xitems.et_IdProcesoProductivo = etapa.IdProcesoProductivo;
                //    xitems.ot_CodObra = UCObra.get_item();
                //    xitems.ot_IdOrdenTaller = item.IdOrdenTaller;
                //    xitems.ot_IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.SelectedValue);
                //    xitems.ot_IdEmpresa = param.IdEmpresa;
                //    var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                //    info.dm_observacion = xitems.dm_observacion =
                //        CabMov.cm_observacion +
                //        " Ot " + item.ot_descripcion +
                //        " Et " + etapa.NombreEtapa +
                //        " Prod " + prod.pr_descripcion
                //        ;
                //    CabMov.listmovi_inve_detalle_Info.Add(info);
                //    LstMovxProd.Add(xitems);


                //}

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }
        private Boolean funcionagrupadetalle(List<prd_DespachoDetalle_Info> Lista)
        {
            try
            {
                in_producto_x_tb_bodega_Bus busBodxProd = new in_producto_x_tb_bodega_Bus();
                var listadetalle = Lista.GroupBy(key => key.IdProducto);
                int sec = 0;
                foreach (var reg in listadetalle)
                {
                    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                    ++sec; int cant = 0;
                    foreach (var item in Lista)
                    {

                        if (reg.Key == item.IdProducto)
                        {
                            cant++;
                            in_movi_inve_detalle_x_Producto_CusCider_Info xitems = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            xitems.IdEmpresa = param.IdEmpresa;
                            xitems.IdSucursal = CabMov.IdSucursal;
                            xitems.IdBodega = CabMov.IdBodega;
                            xitems.IdMovi_inven_tipo =
                                Convert.ToInt32(paramCidersus.IdMovi_invent_tipo_egr_Despacho);
                            xitems.mv_Secuencia = sec;
                            xitems.mv_tipo_movi = "-";
                            xitems.IdProducto = item.IdProducto;
                            xitems.dm_cantidad = -1;

                            xitems.CodigoBarra = item.CodigoBarraMaestro;
                            xitems.et_IdEmpresa = param.IdEmpresa;
                            xitems.et_IdEtapa = etapa.IdEtapa;
                            xitems.et_IdProcesoProductivo = etapa.IdProcesoProductivo;
                            xitems.ot_CodObra = UCObra.get_item();
                            xitems.ot_IdOrdenTaller = item.IdOrdenTaller;
                            xitems.ot_IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue);
                            xitems.ot_IdEmpresa = param.IdEmpresa;
                            var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                            xitems.dm_observacion =
                               CabMov.cm_observacion +
                               " Ot " + item.ot_descripcion +
                               " Et " + etapa.NombreEtapa +
                               " Prod " + prod.pr_descripcion
                               ;
                            info.dm_observacion = info.dm_observacion + xitems.dm_observacion;

                            LstMovxProd.Add(xitems);

                        }
                    }

                    info.IdEmpresa = param.IdEmpresa;
                    info.IdSucursal = CabMov.IdSucursal;
                    info.IdBodega = CabMov.IdBodega;
                    info.IdMovi_inven_tipo =
                        Convert.ToInt32(paramCidersus.IdMovi_invent_tipo_egr_Despacho);
                    info.IdProducto = reg.Key;
                    info.mv_tipo_movi = "-";
                    info.dm_cantidad = cant * -1;
                    var bodxprod = busBodxProd.Get_Info_Producto_x_Producto(param.IdEmpresa, CabMov.IdSucursal, CabMov.IdBodega, reg.Key);
                    if (bodxprod != null)
                    {
                        info.dm_stock_ante = bodxprod.pr_stock;
                        info.dm_stock_actu = info.dm_stock_ante - cant;
                    }

                    CabMov.listmovi_inve_detalle_Info.Add(info);
                }
                return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }
        private Boolean grabar()
        {
            try
            {
                decimal IdDespacho = 0;
                string mensaje_cbte_cble = "";


                if (validar() == false)
                {
                    return false;
                }
                else
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (BusCabDespacho.GrabarCabeceraDB(InfoCabDespacho, LstDetDespacho, ref msg, ref IdDespacho))
                            {
                                decimal idmov = 0;
                                CabMov.cm_observacion = CabMov.cm_observacion + " Desp#" + IdDespacho;
                                CabMov.listmovi_inve_detalle_Info.ForEach(var =>
                                    var.dm_observacion = var.dm_observacion + " Desp# " + IdDespacho);
                                if (busMov.GrabarDB(CabMov, ref idmov,ref mensaje_cbte_cble, ref msg))
                                {
                                    LstMovxProd.ForEach(var => var.IdNumMovi = idmov);
                                    if (busMovxProd.GuardarDB(LstMovxProd, ref msg))
                                    {//get TI

                                        prd_Despacho_cusCidersus_x_in_movi_inven_Bus busTI = new prd_Despacho_cusCidersus_x_in_movi_inven_Bus();
                                        prd_Despacho_cusCidersus_x_in_movi_inven_Info TI = new prd_Despacho_cusCidersus_x_in_movi_inven_Info();
                                        {
                                            TI.dp_IdEmpresa = InfoCabDespacho.IdEmpresa;
                                            TI.dp_IdSucursal = InfoCabDespacho.IdSucursal;
                                            TI.dp_IdDespacho = IdDespacho;
                                            TI.IdEmpresa = CabMov.IdEmpresa;
                                            TI.IdSucursal = CabMov.IdSucursal;
                                            TI.IdBodega = CabMov.IdBodega;
                                            TI.IdMovi_inven_tipo = CabMov.IdMovi_inven_tipo;
                                            TI.IdNumMovi = CabMov.IdNumMovi;
                                        }
                                        if (busTI.GuardarDB(TI, ref msg))
                                        {


                                            MessageBox.Show("Grabado Satisfactoriamente", "Sistemas",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txtNumDespacho.Text = InfoCabDespacho.NumDespacho;
                                            txtId.Text = Convert.ToString(IdDespacho);
                                            btn_guardar.Enabled = false;
                                            InfoCabDespacho.IdDespacho = IdDespacho;
                                            setCab(InfoCabDespacho);
                                            return true;
                                        }
                                        else return error();
                                    }
                                    else return error();
                                }
                                else return error();
                            }
                            else return error();

                   
                        default:
                            return false;
                    }


                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
                return false;
            }
        }


        FrmPrd_PuenteGruaMovilizacion_Mantenimiento frm = new FrmPrd_PuenteGruaMovilizacion_Mantenimiento();
        BindingList<prd_DespachoDetalle_Info> Prod = new BindingList<prd_DespachoDetalle_Info>();


        List<vwprd_MovPteGruaSaldo_Info> LstSaldos = new List<vwprd_MovPteGruaSaldo_Info>();
      
        private Boolean valida()
        {
            try
            {

                if (UCObra.get_item_info() == null)
                {
                    MessageBox.Show("Debe seleccionar la Obra Asignada", "Sistema", MessageBoxButtons.OK);
                    PanelObra.Focus();
                    return false;


                }
                else if (UCObra.get_item_info() == null)
                {
                    MessageBox.Show("Debe seleccionar la Obra Asignada ", "Sistema", MessageBoxButtons.OK);
                    PanelObra.Focus();
                    return false;

                }

                return true;

            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); return false;
            }
        }
        in_producto_Bus busProd = new in_producto_Bus();



        public Boolean error()
        {
            try
            {
               MessageBox.Show("Ocurrio un error:" + msg, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
 
        }


      //

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

                        var reg = (prd_DespachoDetalle_Info)gridViewDisponible.GetFocusedRow();
                        if (reg != null && reg.CodigoBarraMaestro != null)
                        { txtIngCB.Text = reg.CodigoBarraMaestro; txtIngCB_KeyPress(sender, v); }

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        

        //#region variables

        ////instancias de centro de costo
        //UCPrd_Obra UCObra = new UCPrd_Obra();

        //prd_Despacho_Info InfoCabDespacho = new prd_Despacho_Info(); //esta es para el get
        //prd_Despacho_Bus BusCabDespacho = new prd_Despacho_Bus();


        ////instancias de cliente
        //UCFA_Cliente_Facturacion UCFa_Cliente = new UCFA_Cliente_Facturacion();

        ////instancicas de bodega y sucursal
        //tb_Bodega_Info _bodegaInfo = new tb_Bodega_Info();
        //tb_Sucursal_Info _sucursalInfo = new tb_Sucursal_Info();
        // tb_Bodega_Bus BusBod = new tb_Bodega_Bus();
        //tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();

        ////instancias para la grid
        //BindingList<prd_DespachoDetalle_Info> LstBindingDespachoDet = new BindingList<prd_DespachoDetalle_Info>();
        //List<prd_DespachoDetalle_Info> LstDetDespacho = new List<prd_DespachoDetalle_Info>();
        //prd_DespachoDetalle_Bus BusDetDespacho = new prd_DespachoDetalle_Bus();

        ////instancias generales
        //cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //private Cl_Enumeradores.eTipo_action Accion;
        //prd_parametros_CusCidersus_Info paramCidersus = new prd_parametros_CusCidersus_Info();
        //prd_parametros_CusCidersus_Bus Busparam = new prd_parametros_CusCidersus_Bus();


        //in_movi_inve_Info CabMov = new in_movi_inve_Info();
        //in_movi_inve_Bus busMov = new in_movi_inve_Bus();
        //List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstMovxProd = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        //in_movi_inve_detalle_x_Producto_CusCider_Bus busMovxProd = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        //BindingList<vwIn_Movi_Inven_CusCider_Cab_Info> MovBind = new BindingList<vwIn_Movi_Inven_CusCider_Cab_Info>();
        //#endregion
        //void UCObra_Event_UCObra_Validating(object sender, CancelEventArgs e)
        //{
        //    if (UCObra.get_item_info() == null)
        //    {
        //        Prod = new BindingList<prd_DespachoDetalle_Info>();
        //        gridCtrlDespacho.DataSource = Prod;
        //    }
        //}
         
        //private void iniciar_controles()
        //{
        //    try
        //    {
        //        //carga obra
        //        UCObra.cargaCmb_Obra();
        //        PanelObra.Controls.Add(UCObra);
        //        UCObra.Dock = DockStyle.Fill;
        //        UCObra.Event_UCObra_SelectionChanged += new UCPrd_Obra.delegadoUCObra_SelectionChanged(UCObra_Event_UCObra_SelectionChanged);
        //        //carga clientes
        //        panel_cliente.Controls.Add(UCFa_Cliente);
        //        UCFa_Cliente.Dock = DockStyle.Fill;
               
               
               
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}
        
        //public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        //{
        //    Accion = iAccion;
        //    switch (Accion)
        //    {
        //        case Cl_Enumeradores.eTipo_action.grabar:
        //            this.btn_guardar.Text = "Grabar Registro";
                  
        //            this.txtNumDespacho.Text = "0";
        //            break;
        //        case Cl_Enumeradores.eTipo_action.consultar:
        //            this.btn_guardar.Visible = false;
                   
        //            break;
        //        case Cl_Enumeradores.eTipo_action.borrar:
        //            this.btn_guardar.Visible = false;
                   
        //            break;
        //        default:
        //            break;
        //    }
        //}
        
        //void UCObra_Event_UCObra_SelectionChanged(object sender, EventArgs e)
        //{

        //    cargadata();
        //}
        //prd_EtapaProduccion_Info etapa = new prd_EtapaProduccion_Info();
        //void cargadata()
        //{
        //    try
        //    {
        //        etapa = new prd_EtapaProduccion_Info();
        //        ListProdDisp = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
               
        //        prd_EtapaProduccion_Bus busEta = new prd_EtapaProduccion_Bus();
        //        var listetapa = (List<prd_EtapaProduccion_Info>)busEta.EtapaMaxObra(UCObra.get_item(), ref msg);
        //        etapa = listetapa.First();

        //        ListProdDisp = busProdDisp.ConsultaSaldosxDespachoxObra(param.IdEmpresa,
        //            etapa.IdEtapa, etapa.IdProcesoProductivo, param.IdEmpresa, UCObra.get_item(), 
        //            Convert.ToInt32 (ctrl_Sucbod.cmb_bodega.SelectedValue),
        //            Convert.ToInt32 (ctrl_Sucbod.cmb_sucursal.SelectedValue), ref msg);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.InnerException.ToString());
        //    }
        //}

        //List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListProdDisp = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        //in_movi_inve_detalle_x_Producto_CusCider_Bus busProdDisp = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        //prd_OrdenTaller_Bus BusOT = new prd_OrdenTaller_Bus();
        
        //List<prd_OrdenTaller_Info> ListOT = new List<prd_OrdenTaller_Info>();
        //prd_OrdenTaller_Info infoOT= new prd_OrdenTaller_Info();
        //tb_Sucursal_Info suc = new tb_Sucursal_Info();

        //private void FrmPrd_DespachoMantenimiento_Load(object sender, EventArgs e)
        //{
        //    //iniciar_controles();
        //    //ctrl_Sucbod.cargar_sucursal(param.IdEmpresa );
        //    paramCidersus = Busparam.ObtenerObjeto(param.IdEmpresa);
        //    ctrl_Sucbod.cmb_sucursal.SelectedValue = paramCidersus.IdSucursal_Produccion;
        //    ctrl_Sucbod.cmb_bodega.SelectedValue = paramCidersus.IdBodega_Produccion;
            
           
           
        //}


        //public void setCab(prd_Despacho_Info info)
        //{
        //    try
        //    {
        //        InfoCabDespacho = info;
        //        { _sucursalInfo.IdEmpresa = _bodegaInfo.IdEmpresa = info.IdEmpresa; _sucursalInfo.IdSucursal = _bodegaInfo.IdSucursal = info.IdSucursal; _bodegaInfo.IdBodega = info.IdBodega; }

        //        txtId.Text = Convert.ToString(info.IdDespacho);
        //        txtNumDespacho.Text = info.NumDespacho;
        //        txtGuia.Text = info.NumGuiaRemision;
        //        ctrl_Sucbod.set_sucursal(_sucursalInfo);
        //        ctrl_Sucbod.set_bodega(_bodegaInfo);
        //        UCObra.set_item(info.CodObra);
        //        txtPuntoPartida.Text = info.PuntoPartida;
        //        txtPuntoLLegada.Text = info.PuntoLLegada;
        //        txtPlaca.Text = info.Placa;

        //        cmbTipTransporte.Text = info.TipoTransporte; 
        //        txtChofer.Text = info.Chofer;
        //        txtObservacion.Text = info.Observacion;
        //        dtpFechaReg.Value = info.FechaReg;
        //        dtpFInicio.Value = info.FechaIniTras;
        //        dtpFFin.Value = info.FechaFinTras;
        //        UCFa_Cliente.cmb_cliente.Value = info.IdCliente;
        //        LstDetDespacho = BusDetDespacho.ObtenerDespachoDetalle(info.IdDespacho, info.IdEmpresa, info.IdSucursal);
        //        if (info.Estado == "I") lblAnulado.Visible = true; else lblAnulado.Visible = false;
        //        foreach (var item in LstDetDespacho)
        //        {
        //            var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, item.IdEmpresa);
        //            var ot = BusOT.ObtenerUnaOT(item.IdEmpresa, item.IdSucursal, Convert.ToDecimal( item.IdOrdenTaller), info.CodObra);
        //            item.pr_descripcion = prod.pr_descripcion;
        //            item.ot_descripcion = ot.Codigo;

        //        }
        //        gridCtrlDespacho.DataSource = LstDetDespacho;

        //        prd_Despacho_cusCidersus_x_in_movi_inven_Bus busTI = new prd_Despacho_cusCidersus_x_in_movi_inven_Bus();
        //        prd_Despacho_cusCidersus_x_in_movi_inven_Info TI = new prd_Despacho_cusCidersus_x_in_movi_inven_Info();


        //        {
        //            TI = busTI.TI_x_Despacho(info, ref msg);
        //            List<vwIn_Movi_Inven_CusCider_Cab_Info> Lstmov = new List<vwIn_Movi_Inven_CusCider_Cab_Info>();

        //            Lstmov = busMovxProd.ConsultaMovimientos(TI.IdEmpresa, TI.IdSucursal, TI.IdBodega,
        //                TI.IdNumMovi, TI.IdMovi_inven_tipo);

                  

        //        }

        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.InnerException.ToString()); }
        //}

        //private Boolean  validar()
        //{
        //    try
        //    {
        //        InfoCabDespacho.IdCliente = Convert.ToDecimal(UCFa_Cliente.cmb_cliente.Value);
        //        if (UCObra.get_item_info() == null)
        //        {
        //            MessageBox.Show("Seleccione una Obra.",
        //                  "Sistema", MessageBoxButtons.OK);
        //            return false;
        //        }
        //        else if (UCFa_Cliente.cmb_cliente.Value == null)
        //        {
        //            MessageBox.Show("Seleccione el Cliente.",
        //                    "Sistema", MessageBoxButtons.OK);
        //            UCFa_Cliente.cmb_cliente.Focus();
        //            return false;
        //        }
        //        else if (String.IsNullOrEmpty(txtGuia.Text))
        //        {
        //            MessageBox.Show("Por favor, Ingrese la Guia de Remisión.",
        //                    "Sistema", MessageBoxButtons.OK);
        //            txtGuia.Focus();
        //            return false;
        //        }
        //        else if (cmbTipTransporte.Text == String.Empty)
        //        {
        //            MessageBox.Show("Seleccione el Tipo de Transporte.",
        //                    "Sistema", MessageBoxButtons.OK);
        //            UCFa_Cliente.cmb_cliente.Focus();
        //            return false;
        //        }
        //        else if (txtPlaca.Text == string.Empty)
        //        {
        //            MessageBox.Show("Por favor, Ingrese la Placa.",
        //                    "Sistema", MessageBoxButtons.OK);
        //            txtPlaca.Focus();
        //            return false;
        //        }
        //        else if (txtPuntoLLegada.Text == string.Empty)
        //        {
        //            MessageBox.Show("Por favor, Ingrese el Punto de Llegada.",
        //                     "Sistema", MessageBoxButtons.OK);
        //            txtPuntoLLegada.Focus();
        //            return false;
        //        }
        //        else if (txtPuntoPartida.Text == string.Empty)
        //        {
        //            MessageBox.Show("Por favor, Ingrese el Punto de Partida.",
        //                     "Sistema", MessageBoxButtons.OK);
        //            txtPuntoPartida.Focus();
        //            return false;
        //        }
        //        else if (txtChofer.Text == string.Empty)
        //        {
        //            MessageBox.Show("Por favor, Ingrese el Nombre del Chofer.",
        //                     "Sistema", MessageBoxButtons.OK);
        //            txtChofer.Focus();
        //            return false;
        //        }
        //        else
        //        {// valida que haya registros en la tabla
        //            if (gridViewDisponible.DataSource != null)
        //            {
        //               for (int i = 0; i < gridViewDisponible.RowCount; i++)
        //                {
        //                    var item = (prd_DespachoDetalle_Info) gridViewDisponible.GetRow(i);
        //                    if(item!= null)
        //                        if (item.IdProducto == null || item.IdProducto == 0)
        //                        {
        //                            MessageBox.Show("Por favor, Ingrese productos validos.",
        //                               "Sistema", MessageBoxButtons.OK);

        //                            return false;
        //                        }
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Por favor, Ingrese los productos a despachar.",
        //                         "Sistema", MessageBoxButtons.OK);

        //                return false;
        //            }
        //        } return getDespacho();
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.InnerException.ToString()); return false; }
        //}

        //private Boolean getDespacho()
        //{

        //    try
        //    {

        //        InfoCabDespacho = new prd_Despacho_Info();
        //        InfoCabDespacho.IdEmpresa = param.IdEmpresa;
        //        InfoCabDespacho.IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.SelectedValue);
        //        InfoCabDespacho.IdBodega = Convert.ToInt32(ctrl_Sucbod.cmb_bodega.SelectedValue);
        //        InfoCabDespacho.IdCliente = Convert.ToDecimal(UCFa_Cliente.cmb_cliente.Value);
        //        InfoCabDespacho.CodObra = UCObra.get_item();
        //        InfoCabDespacho.FechaReg = dtpFechaReg.Value;
        //        InfoCabDespacho.FechaIniTras = dtpFInicio.Value;
        //        InfoCabDespacho.FechaFinTras = dtpFFin.Value;
        //        InfoCabDespacho.TipoTransporte = cmbTipTransporte.Text;
        //        InfoCabDespacho.Placa = txtPlaca.Text;
        //        InfoCabDespacho.PuntoLLegada = txtPuntoLLegada.Text;
        //        InfoCabDespacho.PuntoPartida = txtPuntoPartida.Text;
        //        InfoCabDespacho.Chofer = txtChofer.Text;
        //        InfoCabDespacho.NumGuiaRemision = txtGuia.Text;
        //        InfoCabDespacho.Observacion = txtObservacion.Text + " Eg Suc " + ctrl_Sucbod.cmb_sucursal.Text +
        //        " Bod " + ctrl_Sucbod.cmb_bodega.Text +
        //        " x Desp Cli " + UCFa_Cliente.cmb_cliente.Text +
        //        " Ch " + txtChofer.Text +
        //        " PL " + txtPlaca.Text +
        //        " x PP " + txtPuntoPartida.Text +
        //        " - PLl " + txtPuntoLLegada.Text +
        //        "x Ob " + UCObra.get_item();

        //        //datos para auditoria
        //        InfoCabDespacho.IdUsuario = param.IdUsuario;
        //        InfoCabDespacho.FechaTransac = param.Fecha_Transac;

        //        //detalle
        //        //LstDetDespacho = (List<prd_DespachoDetalle_Info>)gridCtrlDespacho.DataSource;
        //        for (int i = 0; i < gridViewDisponible.RowCount; i++)
        //        {
        //            var item = (prd_DespachoDetalle_Info)gridViewDisponible.GetRow(i);
        //            if (item != null)
        //            {
        //                item.IdEmpresa = param.IdEmpresa;
        //                item.IdSucursal = InfoCabDespacho.IdSucursal;
        //                var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
        //                item.Observacion = InfoCabDespacho.Observacion +
        //                    " Prod " + prod.pr_descripcion;
        //                string cambio = item.CodigoBarra;
        //                item.CodigoBarra = item.CodigoBarraMaestro;
        //                item.CodigoBarraMaestro = cambio;
        //                LstDetDespacho.Add(item);
        //            }
        //        }

        //        return getmov();
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.InnerException.ToString()); return false; }
        //}

        //string msg = "";

        //private Boolean getmov()
        //{
        //try
        //{
        //    CabMov = new in_movi_inve_Info();
        //    LstMovxProd = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        //    CabMov.IdEmpresa = param.IdEmpresa;
        //    CabMov.IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.SelectedValue);
        //    CabMov.IdBodega = Convert.ToInt32(ctrl_Sucbod.cmb_bodega.SelectedValue);
        //    CabMov.IdMovi_inven_tipo =Convert.ToInt32( paramCidersus.IdMovi_invent_tipo_egr_Despacho);
        //    CabMov.cm_tipo = "-";
        //    CabMov.cm_fecha = dtpFechaReg.Value;
        //    CabMov.cm_mes = CabMov.cm_fecha.Month;
        //    CabMov.cm_anio  = CabMov.cm_fecha.Year;
        //    CabMov.cm_observacion = txtObservacion.Text +
        //        " Eg Suc " + ctrl_Sucbod.cmb_sucursal.Text +
        //        " Bod " + ctrl_Sucbod.cmb_bodega.Text +
        //        " x Desp Cli " + UCFa_Cliente.cmb_cliente.Text +
        //        " Ch " + txtChofer.Text +
        //        " PL "+ txtPlaca.Text +
        //        " x PP "+ txtPuntoPartida.Text +
        //        " - PLl " + txtPuntoLLegada.Text+                 
        //        "x Ob " + UCObra.get_item() 
                
        //        ;
        //    CabMov.IdUsuario = param.IdUsuario;
        //    CabMov.Fecha_Transac = param.Fecha_Transac;
        //    CabMov.nom_pc = param.nom_pc;
        //    CabMov.ip = param.ip;


        //    int sec = 0;
        //    //funcion retorna agrupada la Lista

        //    return funcionagrupadetalle(LstDetDespacho); 

        //    //fin
        //    foreach (var item in LstDetDespacho)
        //    {
        //        in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
        //        in_movi_inve_detalle_x_Producto_CusCider_Info xitems = new in_movi_inve_detalle_x_Producto_CusCider_Info();
        //        info.IdEmpresa = xitems.IdEmpresa = param.IdEmpresa;
        //        info.IdSucursal =xitems.IdSucursal= CabMov.IdSucursal;
        //        info.IdBodega = xitems.IdBodega = CabMov.IdBodega;
        //        info.IdMovi_inven_tipo = xitems.IdMovi_inven_tipo =
        //            Convert.ToInt32( paramCidersus.IdMovi_invent_tipo_egr_Despacho);
        //        xitems.mv_Secuencia  = ++sec;
        //        info.mv_tipo_movi  = xitems.mv_tipo_movi = "-";
        //        info.IdProducto = xitems.IdProducto = item.IdProducto ;
        //        info.dm_cantidad  = xitems.dm_cantidad=-1;
        //        info.dm_stock_ante = info.dm_stock_actu;
        //        info.dm_stock_actu = info.dm_stock_actu - 1;
        //        xitems.CodigoBarra = item.CodigoBarra;
        //        xitems.et_IdEmpresa = param.IdEmpresa;
        //        xitems.et_IdEtapa = etapa.IdEtapa ;
        //        xitems.et_IdProcesoProductivo = etapa.IdProcesoProductivo;
        //        xitems.ot_CodObra = UCObra.get_item();
        //        xitems.ot_IdOrdenTaller = item.IdOrdenTaller;
        //        xitems.ot_IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.SelectedValue);
        //        xitems.ot_IdEmpresa = param.IdEmpresa;
        //        var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
        //        info.dm_observacion = xitems.dm_observacion =
        //            CabMov.cm_observacion +
        //            " Ot " + item.ot_descripcion +
        //            " Et " + etapa.NombreEtapa +
        //            " Prod " + prod.pr_descripcion
        //            ;
        //        CabMov.listmovi_inve_detalle_Info.Add(info);
        //        LstMovxProd.Add(xitems);


        //    }

        //    return true;
        //}
        //catch (Exception ex)
        //{

        //    return false;
        //}
        
        //}

        //private Boolean funcionagrupadetalle(List<prd_DespachoDetalle_Info> Lista)
        //{
        //    try
        //    {
        //        in_producto_x_tb_bodega_Bus busBodxProd = new in_producto_x_tb_bodega_Bus();
        //        var listadetalle = Lista.GroupBy(key => key.IdProducto);
        //        int sec = 0;
        //        foreach (var reg in listadetalle)
        //        {
        //            in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
        //            ++sec; int cant = 0;
        //            foreach (var item in Lista )
        //            {
                        
        //                if (reg.Key == item.IdProducto)
        //                {
        //                    cant++;
        //                    in_movi_inve_detalle_x_Producto_CusCider_Info xitems = new in_movi_inve_detalle_x_Producto_CusCider_Info();
        //                    xitems.IdEmpresa = param.IdEmpresa;
        //                    xitems.IdSucursal = CabMov.IdSucursal;
        //                    xitems.IdBodega = CabMov.IdBodega;
        //                    xitems.IdMovi_inven_tipo =
        //                        Convert.ToInt32(paramCidersus.IdMovi_invent_tipo_egr_Despacho);
        //                    xitems.mv_Secuencia = sec;
        //                    xitems.mv_tipo_movi = "-";
        //                    xitems.IdProducto = item.IdProducto;
        //                    xitems.dm_cantidad = -1;
                            
        //                    xitems.CodigoBarra = item.CodigoBarra;
        //                    xitems.et_IdEmpresa = param.IdEmpresa;
        //                    xitems.et_IdEtapa = etapa.IdEtapa;
        //                    xitems.et_IdProcesoProductivo = etapa.IdProcesoProductivo;
        //                    xitems.ot_CodObra = UCObra.get_item();
        //                    xitems.ot_IdOrdenTaller = item.IdOrdenTaller;
        //                    xitems.ot_IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.SelectedValue);
        //                    xitems.ot_IdEmpresa = param.IdEmpresa;  
        //                    var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
        //                     xitems.dm_observacion =
        //                        CabMov.cm_observacion +
        //                        " Ot " + item.ot_descripcion +
        //                        " Et " + etapa.NombreEtapa +
        //                        " Prod " + prod.pr_descripcion
        //                        ;
        //                    info.dm_observacion = info.dm_observacion + xitems.dm_observacion;
                            
        //                    LstMovxProd.Add(xitems);
                        
        //                }
        //            }

        //            info.IdEmpresa = param.IdEmpresa;
        //            info.IdSucursal =CabMov.IdSucursal;
        //            info.IdBodega = CabMov.IdBodega;
        //            info.IdMovi_inven_tipo =
        //                Convert.ToInt32(paramCidersus.IdMovi_invent_tipo_egr_Despacho);
        //            info.IdProducto = reg.Key;
        //            info.mv_tipo_movi  = "-";
        //            info.dm_cantidad = cant * -1;
        //            var bodxprod = busBodxProd.ObtenerObjeto(param.IdEmpresa, CabMov.IdSucursal, CabMov.IdBodega, reg.Key);
        //            if (bodxprod != null)
        //            {
        //                info.dm_stock_ante = bodxprod.pr_stock;
        //                info.dm_stock_actu = info.dm_stock_ante - cant;
        //            }

        //            CabMov.listmovi_inve_detalle_Info.Add(info);
        //        }
        //        return true;

        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
            
        //}

        // private Boolean grabar()
        //{
        //    try
        //    {
        //        decimal  IdDespacho = 0;

        //        if (validar() == false)
        //        {
        //            MessageBox.Show("No se guardo", "Sistema", MessageBoxButtons.OK);
        //            return false;
        //        }else{
        //            if (BusCabDespacho.GrabarCabeceraDB(InfoCabDespacho, LstDetDespacho, ref msg, ref IdDespacho))
        //            {
        //                decimal idmov = 0;
        //                CabMov.cm_observacion = CabMov.cm_observacion +" Desp#" + IdDespacho;
        //                CabMov.listmovi_inve_detalle_Info.ForEach(var =>
        //                    var.dm_observacion = var.dm_observacion + " Desp# " + IdDespacho);
        //                if (busMov.GuardarMovimientoInvetarioCabYDetYActuStock(CabMov, ref idmov, ref msg))
        //                {
        //                    LstMovxProd.ForEach(var => var.IdNumMovi = idmov);
        //                    if (busMovxProd.GuardarDB(LstMovxProd, ref msg))
        //                    {//get TI

        //                        prd_Despacho_cusCidersus_x_in_movi_inven_Bus busTI = new prd_Despacho_cusCidersus_x_in_movi_inven_Bus();
        //                        prd_Despacho_cusCidersus_x_in_movi_inven_Info TI = new prd_Despacho_cusCidersus_x_in_movi_inven_Info();
        //                        {
        //                            TI.dp_IdEmpresa = InfoCabDespacho.IdEmpresa;
        //                            TI.dp_IdSucursal = InfoCabDespacho.IdSucursal;
        //                            TI.dp_IdDespacho = IdDespacho;
        //                            TI.IdEmpresa = CabMov.IdEmpresa;
        //                            TI.IdSucursal = CabMov.IdSucursal;
        //                            TI.IdBodega = CabMov.IdBodega;
        //                            TI.IdMovi_inven_tipo = CabMov.IdMovi_inven_tipo;
        //                            TI.IdNumMovi = CabMov.IdNumMovi;
        //                        }
        //                        if (busTI.GuardarDB(TI, ref msg))
        //                        {


        //                            MessageBox.Show("Despacho No. " + IdDespacho + "\n Grabado Satisfactoriamente", "Sistemas", 
        //                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                            txtNumDespacho.Text = InfoCabDespacho.NumDespacho;
        //                            txtId.Text = Convert.ToString(IdDespacho);


        //                            set_Accion(Cl_Enumeradores.eTipo_action.consultar);
        //                            InfoCabDespacho.IdDespacho = IdDespacho;
        //                            setCab(InfoCabDespacho);
        //                            return true;
        //                        }
        //                        else return error();
        //                    }
        //                    else return error();
        //                }
        //                else return error();
        //            }
        //            else return error();

                    
        //        }

        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.InnerException.ToString()); return false; }
        //} 
           
               
        //FrmPrd_PuenteGruaMovilizacion_Mantenimiento frm = new FrmPrd_PuenteGruaMovilizacion_Mantenimiento();

        //private void gridVwDespacho_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
           
            
        //}
       
        //BindingList<prd_DespachoDetalle_Info > Prod = new BindingList<prd_DespachoDetalle_Info> ();
        
        
        //List<vwprd_MovPteGruaSaldo_Info> LstSaldos = new List<vwprd_MovPteGruaSaldo_Info>();
        
        //prd_MovPteGrua_Bus BusMovPteGruaCab = new prd_MovPteGrua_Bus();
        
        //private Boolean valida()
        //{
        //    try
        //    {

        //        if (UCObra.get_item_info() == null)
        //        {
        //            MessageBox.Show("Debe seleccionar la Obra Asignada", "Sistema", MessageBoxButtons.OK);
        //            PanelObra.Focus();
        //            return false;


        //        }
        //        else if (UCObra.get_item_info() == null)
        //        {
        //            MessageBox.Show("Debe seleccionar la Obra Asignada ", "Sistema", MessageBoxButtons.OK);
        //            PanelObra.Focus();
        //            return false;

        //        }
                
        //        return true;

        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.InnerException.ToString()); return false;
        //    }
        //}
       
        //in_producto_Bus busProd = new in_producto_Bus();


        //private void gridVwDespacho_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Delete")
        //        gridViewDisponible.DeleteSelectedRows();
        //}

     
        //public Boolean error() { MessageBox.Show("Ocurrio un error:" + msg, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information); return false; }

        //private void gridVwDespacho_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    try
        //    {
        //        // Prod = new BindingList<prd_DespachoDetalle_Info>();
        //        if (e.Column == colCodigoBarra)
        //        {
        //             if (valida())
        //                {
        //                    List<prd_DespachoDetalle_Info> codigos = new List<prd_DespachoDetalle_Info>();
        //                    for (int i = 0; i < gridViewDisponible.RowCount; i++)
        //                    {
        //                        var Item = (prd_DespachoDetalle_Info)gridViewDisponible.GetRow(i);

        //                        if (Item != null)
        //                        {
        //                            if (Item.CodigoBarra != "")
        //                            {

        //                                codigos.Add(Item);
        //                            }
        //                            else
        //                                gridViewDisponible.DeleteRow(i);
        //                        }

        //                    }
        //                    var co = from q in codigos
        //                             where q.CodigoBarra == e.Value.ToString()
        //                             select q;
        //                    if (co.Count() == 0)
        //                    {
        //                        string codbarra = ""; 
        //                        codbarra = e.Value.ToString();
        //                        if (codbarra != "")
        //                        {
        //                            prd_Ensamblado_CusCider_Bus BusEnsa = new prd_Ensamblado_CusCider_Bus();
        //                            prd_DespachoDetalle_Info obj = new prd_DespachoDetalle_Info();
        //                            // var codbarramaestro = frm.buscacodbarramaestro(param.IdEmpresa, codbarra);
        //                            var codbarramaestro = BusEnsa.buscacodbarramaestro(param.IdEmpresa, codbarra, ref msg);

        //                            if (codbarramaestro != null)
        //                            {
        //                                if (codbarramaestro.CBMaestro == codbarra)
        //                                {
        //                                    obj.CodigoBarra = codbarramaestro.CBMaestro;
        //                                }
        //                                else if (codbarramaestro.CodigoBarra == codbarra)
        //                                {
        //                                    obj.CodigoBarra = codbarramaestro.CodigoBarra;
        //                                }

        //                                var Prodaaa = busProd.Obtener_lProd(param.IdEmpresa, codbarramaestro.cab_IdProducto);
        //                                obj.CodigoBarraMaestro = codbarramaestro.CBMaestro;
        //                                obj.pr_descripcion = Prodaaa.pr_descripcion;
        //                                obj.IdProducto = codbarramaestro.cab_IdProducto;
        //                                obj.IdOrdenTaller = codbarramaestro.IdOrdenTaller;
        //                                var ot = BusOT.ObtenerUnaOT(param.IdEmpresa, Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.SelectedValue),Convert.ToDecimal(obj.IdOrdenTaller), UCObra.get_item());
        //                                obj.ot_descripcion = ot.Codigo;
        //                                obj.Cantidad = 1;
        //                                string[] Time = DateTime.Now.ToString("hh:mm").Split(':');
        //                                obj.Hora = new TimeSpan(Convert.ToInt32(Time[0]), Convert.ToInt32(Time[1]), 0);

        //                                try
        //                                {
        //                                    in_movi_inve_detalle_x_Producto_CusCider_Info saldos = ListProdDisp.First(var => var.CodigoBarra.Trim() == obj.CodigoBarraMaestro.Trim());
        //                                    if (saldos != null)
        //                                    {
        //                                        gridViewDisponible.SetFocusedRowCellValue(colCodigoBarraMaestro , obj.CodigoBarraMaestro);
        //                                       // gridVwDespacho.SetFocusedRowCellValue(colCodigoBarra, obj.CodigoBarra);
        //                                        gridViewDisponible.SetFocusedRowCellValue(colpr_descripcion, obj.pr_descripcion);
        //                                        gridViewDisponible.SetFocusedRowCellValue(colIdProducto, obj.IdProducto);
        //                                        gridViewDisponible.SetFocusedRowCellValue(colIdOrdenTaller, obj.IdOrdenTaller);
        //                                        gridViewDisponible.SetFocusedRowCellValue(colot_descripcion , obj.ot_descripcion);
        //                                        gridViewDisponible.SetFocusedRowCellValue(colHora , obj.Hora);

        //                                        //Prod.Add(obj);
        //                                        //gridCtrlDespacho.DataSource = Prod;
        //                                    }
        //                                }
        //                                catch (Exception ex)
        //                                {
        //                                    gridViewDisponible.DeleteRow(gridViewDisponible.FocusedRowHandle);
        //                                    MessageBox.Show("No hay productos para el despacho");
        //                                }
        //                            }
        //                            else
        //                            {
        //                                try
        //                                {
        //                                    in_movi_inve_detalle_x_Producto_CusCider_Info saldos = ListProdDisp.First(var => var.CodigoBarra == codbarra);
        //                                    if (saldos != null)
        //                                    {
        //                                        var Prodaaa = busProd.Obtener_lProd(param.IdEmpresa, saldos.IdProducto);
        //                                        obj.CodigoBarra = codbarra;
        //                                        obj.CodigoBarraMaestro = codbarra;
        //                                        obj.pr_descripcion = Prodaaa.pr_descripcion;
        //                                        obj.IdProducto = saldos.IdProducto;
        //                                        obj.IdOrdenTaller = Convert.ToDecimal(saldos.ot_IdOrdenTaller);

        //                                        obj.Cantidad = 1;
        //                                        string[] Time = DateTime.Now.ToString("hh:mm").Split(':');
        //                                        obj.Hora = new TimeSpan(Convert.ToInt32(Time[0]), Convert.ToInt32(Time[1]), 0);
        //                                        //Prod.Add(obj);
        //                                        gridViewDisponible.SetFocusedRowCellValue(colCodigoBarraMaestro, obj.CodigoBarraMaestro);
        //                                        //gridVwDespacho.SetFocusedRowCellValue(colCodigoBarra, obj.CodigoBarra);
        //                                        gridViewDisponible.SetFocusedRowCellValue(colpr_descripcion, obj.pr_descripcion);
        //                                        gridViewDisponible.SetFocusedRowCellValue(colIdProducto, obj.IdProducto);
        //                                        gridViewDisponible.SetFocusedRowCellValue(colIdOrdenTaller, obj.IdOrdenTaller);
        //                                        gridViewDisponible.SetFocusedRowCellValue(colot_descripcion, obj.ot_descripcion);
        //                                        gridViewDisponible.SetFocusedRowCellValue(colHora, obj.Hora);


        //                                    }
        //                                }
        //                                catch (Exception ex)
        //                                {
        //                                    gridViewDisponible.DeleteRow(gridViewDisponible.FocusedRowHandle);
        //                                    MessageBox.Show("Codigo de Barra no asignado");
        //                                }

        //                            }


        //                        }
        //                    }
        //                    else
        //                    {

        //                        MessageBox.Show("El Codigo ya se encuentra Ingresado ");
        //                        gridViewDisponible.DeleteRow(gridViewDisponible.FocusedRowHandle);
        //                        //gridVwMovPteGruaDet.SetFocusedRowCellValue("IdProducto", 0);
        //                        //gridVwMovPteGruaDet.SetFocusedRowCellValue("pr_descripcion", "");
        //                        //gridVwMovPteGruaDet.SetFocusedRowCellValue("Hora", DateTime.Now.ToString("00:00"));

        //                    }
                        
        //            }
        //            else gridViewDisponible.DeleteRow(gridViewDisponible.FocusedRowHandle);
        //        }
        //    }
        //    catch (Exception ex) { }
        //}
        
    }
}
