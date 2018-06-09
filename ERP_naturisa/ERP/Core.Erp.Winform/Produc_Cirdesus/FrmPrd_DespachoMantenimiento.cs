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
using Core.Erp.Business.Produccion_Edehsa;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using DevExpress.XtraPrinting;
using Cus.Erp.Reports.Cidersus;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Produccion_Edehsa;
using Core.Erp.Info.SRI;
using System.Xml.Serialization;
using System.IO;
using Core.Erp.Info.class_sri.GuiaRemision;

//version 09082013 09:32

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_DespachoMantenimiento : Form
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //instancias de centro de costo
        prd_Despacho_Info InfoCabDespacho = new prd_Despacho_Info(); //esta es para el get
        prd_Despacho_Bus BusCabDespacho = new prd_Despacho_Bus();
        Boolean preguntar = false;
        FrmPrd_PuenteGruaMovilizacion_Mantenimiento frm = new FrmPrd_PuenteGruaMovilizacion_Mantenimiento();
        BindingList<prd_DespachoDetalle_Info> Prod = new BindingList<prd_DespachoDetalle_Info>();
        List<vwprd_MovPteGruaSaldo_Info> LstSaldos = new List<vwprd_MovPteGruaSaldo_Info>();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListProdDisp = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus busProdDisp = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        prd_OrdenTaller_Bus BusOT = new prd_OrdenTaller_Bus();
        List<prd_OrdenTaller_Info> ListOT = new List<prd_OrdenTaller_Info>();
        prd_OrdenTaller_Info infoOT = new prd_OrdenTaller_Info();
        tb_Sucursal_Info suc = new tb_Sucursal_Info();    
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
        List<prd_DespachoDetalle_Info> listatemp = new List<prd_DespachoDetalle_Info>();
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
        List<vwprd_Ensamblado_CabDet_CusCider_Info> LstEnsab = new List<vwprd_Ensamblado_CabDet_CusCider_Info>();
        prd_Ensamblado_CusCider_Bus BusEnsa = new prd_Ensamblado_CusCider_Bus();

        fa_guia_remision_Bus BusGuiaRemision = new fa_guia_remision_Bus();
        List<fa_guia_remision_det_Info> ListTemp = new List<fa_guia_remision_det_Info>();
        fa_guia_remision_Info _InfoGuiaRemision = new fa_guia_remision_Info();
        fa_guia_remision_det_bus BusDetalle = new fa_guia_remision_det_bus();

        prd_MotivoTraslado_Bus BusMotivoTraslado = new prd_MotivoTraslado_Bus();
        tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();
        tb_Empresa_Info EmpresaInfo = new tb_Empresa_Info();

        vwprd_Guia_Remision_Electronica_Bus BusVW_GuiaRemisionElectronica = new vwprd_Guia_Remision_Electronica_Bus();
        List<vwprd_Guia_Remision_Electronica_Info> ListVW_GuiaRemisionElectroncia_Info = new List<vwprd_Guia_Remision_Electronica_Info>();

        List<Info.class_sri.GuiaRemision.guiaRemision> LstGuiaRemisionElectronicaSRI = new List<Info.class_sri.GuiaRemision.guiaRemision>();

        #endregion

        private void FrmPrd_DespachoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  event_FrmPrd_DespachoMantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        public delegate void delegate_FrmPrd_DespachoMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_DespachoMantenimiento_FormClosing event_FrmPrd_DespachoMantenimiento_FormClosing;

        public FrmPrd_DespachoMantenimiento()
        {
            try
            {
                InitializeComponent();
                
                //ctrl_Sucbod.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                gridCtrlMov.DataSource = MovBind;
                this.event_FrmPrd_DespachoMantenimiento_FormClosing +=FrmPrd_DespachoMantenimiento_event_FrmPrd_DespachoMantenimiento_FormClosing;
                ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                 ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu_Superior_Mant1.event_btnImprimir_guia_Click += ucGe_Menu_event_btnImprimir_guia_Click;

                
                iniciar_controles();
                //ctrl_Sucbod.cargar_sucursal(param.IdEmpresa);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
           
        }

        void FrmPrd_DespachoMantenimiento_event_FrmPrd_DespachoMantenimiento_FormClosing(object sender, FormClosingEventArgs e){}


        private void iniciar_controles()
        {
            try
            {

               
                CmbObra.Dock = DockStyle.Fill;
                panel_cliente.Controls.Add(UCFa_Cliente);
                UCFa_Cliente.Dock = DockStyle.Fill;
                UCFa_Cliente.cmb_cliente.Size = new System.Drawing.Size(380, 20);

                cmbMotivoTraslado.Properties.DataSource = BusMotivoTraslado.ObtenerMotivoTraslado(param.IdEmpresa);

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
                          //  this.btnGrabar.Text = "Grabar Registro";
                          //  this.btnGrabarySalir.Text = "Grabar y Salir";
                            this.txtNumDespacho.Text = "0";
                            //sep1.Visible = false;
                          //  this.mnu_anular.Visible = false;
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                          //  this.btnGrabar.Text = "Actualizar";
                           // this.btnGrabarySalir.Text = "Actualizar y Salir";
                          //  this.mnu_anular.Visible = false;sep1.Visible = false;
                            CmbObra.Enabled = false;
                            this.ctrl_Sucbod.cmb_bodega.Enabled = false;
                            this.ctrl_Sucbod.cmb_sucursal.Enabled = false;
                    
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                          //  this.btnGrabar.Enabled = false;
                          //  this.btnGrabarySalir.Enabled = false;
                          //  this.mnu_anular.Visible = false;
                            CmbObra.Enabled = false;
                         //   sep1.Visible = false;
                            colObservacion.OptionsColumn.ReadOnly = true;
                            colCodBarra.OptionsColumn.ReadOnly = true;
                              this.ctrl_Sucbod.cmb_bodega.Enabled = false;
                            this.ctrl_Sucbod.cmb_sucursal.Enabled = false;
                   
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                           // this.btnGrabar.Enabled = false;
                           // this.btnGrabarySalir.Enabled = false;
                           // this.mnu_anular.Visible = true;sep1.Visible = true;
                            CmbObra.Enabled = false;
                            colObservacion.OptionsColumn.ReadOnly = true;
                            colCodBarra.OptionsColumn.ReadOnly = true;
                              this.ctrl_Sucbod.cmb_bodega.Enabled = false;
                            this.ctrl_Sucbod.cmb_sucursal.Enabled = false;
                   
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
        
      
        prd_EtapaProduccion_Info etapa = new prd_EtapaProduccion_Info();
        void cargadata()
        {
            try
            {
                //etapa = new prd_EtapaProduccion_Info();
                ListProdDisp = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
               
                //prd_EtapaProduccion_Bus busEta = new prd_EtapaProduccion_Bus();
                //var listetapa = (List<prd_EtapaProduccion_Info>)busEta.EtapaMaxObra(CmbObra.get_item(), ref msg);
                //etapa = listetapa.First();

                ListProdDisp = busProdDisp.ConsultaSaldosxDespachoxObra(param.IdEmpresa, param.IdSucursal, Convert.ToInt32( ctrl_Sucbod.cmb_bodega.EditValue), CmbObra.get_item());
                ListadoDisponible = new BindingList<prd_DespachoDetalle_Info>();
                

                foreach (var item in ListProdDisp)
                {
                    prd_DespachoDetalle_Info info = new prd_DespachoDetalle_Info();
                    info.Cantidad = 1;
                    info.CodigoBarraMaestro = item.CodigoBarra;
                    info.IdProducto = item.IdProducto;
                    info.IdOrdenTaller = item.ot_IdOrdenTaller;
                    var ot = BusOT.ObtenerUnaOT(param.IdEmpresa, Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue), Convert.ToDecimal(info.IdOrdenTaller), CmbObra.get_item());
                    info.ot_descripcion = ot.Codigo;
                    info.peso = ot.PesoUnitario;
                    info.CodigoBarraMaestro = info.CodigoBarraMaestro;
                    info.pr_descripcion = item.pr_descripcion;
                    info.precio =(decimal) item.dm_precio;
                    info.Observacion = item.dm_observacion;
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
        void buscarenlistado()
        {
            try
            {
                    if (ListadoDisponible.Count > 0)
                    {
                       
                        foreach (var item in ListadoDisponible)
                        {
                            if (item.Checked == true)
                                {
                                    item.CodigoBarra = item.CodigoBarraMaestro;
                                    string[] Time = DateTime.Now.ToString("hh:mm").Split(':');
                                    item.Hora = new TimeSpan(Convert.ToInt32(Time[0]), Convert.ToInt32(Time[1]), 0);                                   
                                     listatemp.Add(item);
                                    gridControlDisponible.RefreshDataSource();
                                }
                        }

                    }
                }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        private void FrmPrd_DespachoMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                CmbObra.cargaCmb_Obra();
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
                txtNumFact.Text = info.NumFactura;
                ctrl_Sucbod.set_sucursal(_sucursalInfo);
                ctrl_Sucbod.set_bodega(_bodegaInfo);
                CmbObra.set_item(info.CodObra); //UCObra
                txtPuntoPartida.Text = info.PuntoPartida;
                cmbTipTransporte.Text = info.TipoTransporte; 
                txtPuntoLLegada.Text = info.PuntoLLegada;
                txtPlaca.Text = info.Placa;
                //txtChofer.Text = info.Chofer;
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
                    if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                        item.Checked = true;

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

                    gridCtrlMov.DataSource = Lstmov;
                
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());  
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                buscarenlistado();
              grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

           
        }

        private Boolean  validar()
        {
            try
            {
                tb_transportista_Info infotransportista = new tb_transportista_Info();
                infotransportista = ucGe_Transportista_Cmb1.get_Transportistas();
                InfoCabDespacho.IdCliente = Convert.ToDecimal(UCFa_Cliente.cmb_cliente.EditValue);
                if (CmbObra.get_item_info() == null)
                {
                    MessageBox.Show("Seleccione una Obra.",
                          "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                    else if (UCFa_Cliente.cmb_cliente.EditValue == null)
                    {
                        MessageBox.Show("Seleccione el Cliente.",
                                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        UCFa_Cliente.cmb_cliente.Focus();
                        return false;
                    }
                    else if (String.IsNullOrEmpty(txtGuia.Text))
                    {
                        MessageBox.Show("Por favor, Ingrese la Guia de Remisión.",
                                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtGuia.Focus();
                        return false;
                    }
                    else if (cmbTipTransporte.Text == String.Empty)
                    {
                        MessageBox.Show("Seleccione el Tipo de Transporte.",
                                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        UCFa_Cliente.cmb_cliente.Focus();
                        return false;
                    }
                    else if (txtPlaca.Text == string.Empty)
                    {
                        MessageBox.Show("Por favor, Ingrese la Placa.",
                                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPlaca.Focus();
                        return false;
                    }
                    else if (txtPuntoLLegada.Text == string.Empty)
                    {
                        MessageBox.Show("Por favor, Ingrese el Punto de Llegada.",
                                 "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPuntoLLegada.Focus();
                        return false;
                    }
                    else if (txtPuntoPartida.Text == string.Empty)
                    {
                        MessageBox.Show("Por favor, Ingrese el Punto de Partida.",
                                 "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPuntoPartida.Focus();
                        return false;
                    }

                    //else if (txtChofer.Text == string.Empty)
                    //{
                    //    MessageBox.Show("Por favor, Ingrese el Nombre del Chofer.",
                    //             "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    txtChofer.Focus();
                    //    return false;
                    //}
                    else if (infotransportista == null)
                    {
                        MessageBox.Show("Por favor, Elija el Chofer.",
                                 "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //txtChofer.Focus();
                        return false;
                    }


                else
                {// valida que haya registros en la tabla

                    Boolean  valida = false;
                    foreach (var item in ListadoDisponible )
                    {
                        if (item.Checked == true)
                        {
                            
                            valida = true;
                        }
                    }
 
                } return getDespacho();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); 
                return false; 
            }
        }
        private Boolean getDespacho() {

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
                InfoCabDespacho.CodObra = CmbObra.get_item();
                InfoCabDespacho.FechaReg = dtpFechaReg.Value;
                InfoCabDespacho.FechaIniTras = dtpFInicio.Value;
                InfoCabDespacho.FechaFinTras = dtpFFin.Value;
                InfoCabDespacho.TipoTransporte = cmbTipTransporte.Text;
                InfoCabDespacho.Placa = txtPlaca.Text;
                InfoCabDespacho.PuntoLLegada = txtPuntoLLegada.Text ;
                InfoCabDespacho.PuntoPartida = txtPuntoPartida.Text;

                //InfoCabDespacho.Chofer = txtChofer.Text;
                InfoCabDespacho.Chofer = ucGe_Transportista_Cmb1.get_Transportistas().pe_nombreCompleto;

                InfoCabDespacho.NumGuiaRemision = txtGuia.Text;
                InfoCabDespacho.NumFactura = txtNumFact.Text;
                InfoCabDespacho.NumDespacho = txtNumDespacho.Text;
               
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    InfoCabDespacho.Observacion = txtObservacion.Text + " Eg Suc " + ctrl_Sucbod.cmb_sucursal.Text +
                    " Bod " + ctrl_Sucbod.cmb_bodega.Text +
                    " x Desp Cli " + UCFa_Cliente.cmb_cliente.Text +
                    " Ch " + ucGe_Transportista_Cmb1.get_Transportistas().pe_nombreCompleto +
                    " PL " + txtPlaca.Text +
                    " x PP " + txtPuntoPartida.Text +
                    " - PLl " + txtPuntoLLegada.Text +
                    "x Ob " + CmbObra.get_item();
                }
                //datos para auditoria
                InfoCabDespacho.IdUsuario = param.IdUsuario;
                InfoCabDespacho.FechaTransac = param.Fecha_Transac;

                //datos para la guia
                InfoCabDespacho.idMotivo_traslado = Convert.ToInt16(cmbMotivoTraslado.EditValue);

                List<prd_DespachoDetalle_Info >listado = new List<prd_DespachoDetalle_Info>();
                foreach (var item in ListadoDisponible)
                {
                    if (item.Checked == true)
                    {
                        item.IdEmpresa = param.IdEmpresa;
                        item.IdSucursal = InfoCabDespacho.IdSucursal;
                        var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);

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

        private fa_guia_remision_Info getGuiaRemision(int IdEmpresa,  int IdSucursal, decimal IdDespacho)
        {
            try
            {

                _InfoGuiaRemision.IdEmpresa = param.IdEmpresa;
                _InfoGuiaRemision.IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue);
                _InfoGuiaRemision.IdBodega = Convert.ToInt32(ctrl_Sucbod.cmb_bodega.EditValue);

                _InfoGuiaRemision.gi_fecha = Convert.ToDateTime(dtpFechaReg.Value.ToShortDateString());
                //_Info.gi_fecha = DateTime.Now;
                //_Info.gi_fech_venc = dtpFechaReg.Value;

                _InfoGuiaRemision.gi_FecIniTraslado = dtpFInicio.Value;
                _InfoGuiaRemision.gi_FecFinTraslado = dtpFFin.Value;

                _InfoGuiaRemision.CodGuiaRemision = txtGuia.Text;
                _InfoGuiaRemision.CodDocumentoTipo = "06";

                _InfoGuiaRemision.IdGuiaRemision = Convert.ToDecimal((txtGuia.Text == "") ? "0" : txtGuia.Text);
                ////////////////_InfoGuiaRemision.IdGuiaRemision = 00100130000;

                _InfoGuiaRemision.IdVendedor = Convert.ToInt32(ucGe_Transportista_Cmb1.get_Transportistas().IdTransportista);
                _InfoGuiaRemision.IdCliente = Convert.ToDecimal((UCFa_Cliente.cmb_cliente.EditValue == null) ? 0 : UCFa_Cliente.cmb_cliente.EditValue);
                
                //_Info.gi_TotalQuintales = Convert.ToDouble(txtquintales.EditValue);
                //_Info.gi_TotalKilos = Convert.ToDouble(txtKilos.EditValue);

                _InfoGuiaRemision.IdTransportista = ucGe_Transportista_Cmb1.get_Transportistas().IdTransportista;
                _InfoGuiaRemision.placa = txtPlaca.Text;
                _InfoGuiaRemision.gi_Observacion = txtObservacion.Text;

                _InfoGuiaRemision.IdUsuario = param.IdUsuario;
                _InfoGuiaRemision.Fecha_Transac = param.Fecha_Transac;
                _InfoGuiaRemision.nom_pc = param.nom_pc;
                _InfoGuiaRemision.ip = param.ip;
                _InfoGuiaRemision.Estado = "A";
                //rEVISAR IDPERIODO
                _InfoGuiaRemision.IdPeriodo = 2016035;
                _InfoGuiaRemision.gi_flete = 0;
                _InfoGuiaRemision.gi_interes = 0;
                _InfoGuiaRemision.gi_seguro = 0;
                _InfoGuiaRemision.gi_OtroValor1 = 0;
                _InfoGuiaRemision.gi_OtroValor2 = 0;

                // Se tiene que poner la ruta
                _InfoGuiaRemision.ruta = "";
                _InfoGuiaRemision.Direccion_Origen = txtPuntoPartida.Text;
                _InfoGuiaRemision.Direccion_Destino = txtPuntoLLegada.Text;
                _InfoGuiaRemision.idMotivo_traslado = Convert.ToInt16(cmbMotivoTraslado.EditValue);

                //fa_guia_remision_det_Info GuiaRemisionDet_Info = new fa_guia_remision_det_Info();
                List<fa_guia_remision_det_Info> LstGuiaRemisionDet = new List<fa_guia_remision_det_Info>();



                int sec_guia_det=0;

                List<prd_DespachoDetalle_Info> ListDetDespacho_para_Guia = new List<prd_DespachoDetalle_Info>();

                ListDetDespacho_para_Guia = BusDetDespacho.ObtenerDespachoDetalle_para_GuiaRemision(IdDespacho, IdEmpresa, IdSucursal);

                foreach (var item in ListDetDespacho_para_Guia)
                {
                    fa_guia_remision_det_Info GuiaRemisionDet_Info = new fa_guia_remision_det_Info();
                    GuiaRemisionDet_Info.IdEmpresa = IdEmpresa;
                    GuiaRemisionDet_Info.IdSucursal = IdSucursal;
                    GuiaRemisionDet_Info.IdGuiaRemision = Convert.ToDecimal(txtGuia.Text);
                    GuiaRemisionDet_Info.Secuencia = sec_guia_det++;
                    GuiaRemisionDet_Info.IdProducto = item.IdProducto;
                    GuiaRemisionDet_Info.gi_cantidad = item.Cantidad;
                    GuiaRemisionDet_Info.gi_Precio = 0;
                    GuiaRemisionDet_Info.gi_PorDescUnitario = 0;
                    GuiaRemisionDet_Info.gi_DescUnitario = 0;
                    GuiaRemisionDet_Info.gi_PrecioFinal = 0;
                    GuiaRemisionDet_Info.Subtotal = 0;
                    GuiaRemisionDet_Info.gi_total = 0;
                    GuiaRemisionDet_Info.gi_costo = 0;
                    GuiaRemisionDet_Info.gi_detallexItems = "";

                    var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, item.IdEmpresa);


                    LstGuiaRemisionDet.Add(GuiaRemisionDet_Info);

                }



                _InfoGuiaRemision.ListaDetalle = LstGuiaRemisionDet;
                return _InfoGuiaRemision;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return _InfoGuiaRemision;
            }
        }
        private Boolean getmov()
        {
        try
        {
            CabMov = new in_movi_inve_Info();
            LstMovxProd = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
            CabMov.IdEmpresa = param.IdEmpresa;
            CabMov.IdSucursal = Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue);
            CabMov.IdBodega = Convert.ToInt32(ctrl_Sucbod.cmb_bodega.EditValue);
            CabMov.IdMovi_inven_tipo =Convert.ToInt32( paramCidersus.IdMovi_invent_tipo_egr_Despacho);
            CabMov.cm_tipo = "-";
            CabMov.cm_fecha = dtpFechaReg.Value;
            CabMov.cm_mes = CabMov.cm_fecha.Month;
            CabMov.cm_anio  = CabMov.cm_fecha.Year;
            CabMov.cm_observacion = txtObservacion.Text +
                " Eg Suc " + ctrl_Sucbod.cmb_sucursal.Text +
                " Bod " + ctrl_Sucbod.cmb_bodega.Text +
                " x Desp Cli " + UCFa_Cliente.cmb_cliente.Text +
                " Ch " + ucGe_Transportista_Cmb1.get_Transportistas().pe_nombreCompleto +
                " PL "+ txtPlaca.Text +
                " x PP "+ txtPuntoPartida.Text +
                " - PLl " + txtPuntoLLegada.Text+
                "x Ob " + CmbObra.get_item() 
                
                ;
            CabMov.IdUsuario = param.IdUsuario;
            CabMov.Fecha_Transac = param.Fecha_Transac;
            CabMov.nom_pc = param.nom_pc;
            CabMov.ip = param.ip;


            int sec = 0;
            //funcion retorna agrupada la Lista

            return funcionagrupadetalle(LstDetDespacho); 

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
                    foreach (var item in Lista )
                    {
                        info.dm_precio = (double)item.precio;
                        info.mv_costo = (double)item.precio;
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
                            xitems.ot_CodObra = CmbObra.get_item();
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
                            info.dm_precio =(double) item.precio;
                            LstMovxProd.Add(xitems);
                        
                        }
                    }

                    info.IdEmpresa = param.IdEmpresa;
                    info.IdSucursal =CabMov.IdSucursal;
                    info.IdBodega = CabMov.IdBodega;
                    info.IdMovi_inven_tipo =
                        Convert.ToInt32(paramCidersus.IdMovi_invent_tipo_egr_Despacho);
                    info.IdProducto = reg.Key;
                    info.mv_tipo_movi  = "-";
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
                string mensaje_cbte_cble = "";

                decimal  IdDespacho = 0;
               
                if (validar() == false)
                {
                    MessageBox.Show("No se guardo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (BusCabDespacho.GrabarCabeceraDB(InfoCabDespacho, listatemp, ref msg, ref IdDespacho))
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


                                            MessageBox.Show("Despacho No. " + IdDespacho + "\n Grabado Satisfactoriamente", "Sistemas",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txtNumDespacho.Text = InfoCabDespacho.NumDespacho;
                                            txtId.Text = Convert.ToString(IdDespacho);


                                            set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                            InfoCabDespacho.IdDespacho = IdDespacho;
                                            setCab(InfoCabDespacho);

                                            // PROCESO DE GENERACION DE XML PARA LA GUIA DE REMISION
                                            //1) llamar a funcion que convertir despacho en info_guia_remision
                                            //2) 

                                            if (grabarGuiaRemision(CabMov.IdEmpresa, CabMov.IdSucursal, IdDespacho)) 
                                            {
                                                return true;
                                            }
                                            else return error();

                                           
                                        }
                                        else return error();
                                    }
                                    else return error();
                                }
                                else return error();
                            }
                            else return error();

                        case Cl_Enumeradores.eTipo_action.actualizar:

                            if (BusCabDespacho.ModificarDB(InfoCabDespacho, ref msg))
                            {
                                if (BusDetDespacho.eliminarregistrotabla(LstDetDespachoModif, param.IdEmpresa, InfoCabDespacho.IdDespacho, ref msg))
                                {
                                    if (BusDetDespacho.grabarDB(LstDetDespachoModif, param.IdEmpresa, InfoCabDespacho.IdDespacho, ref msg))
                                    {
                                        MessageBox.Show("Despacho No. " + txtId.Text + "\n Grabado Satisfactoriamente", "Sistemas",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                        setCab(InfoCabDespacho);
                                        return true;
                                    }
                                    else return error();
                                }
                                else return error();
                            }
                            else return error();
                        default :
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
         private Boolean grabarGuiaRemision(int IdEmpresa, int IdSucursal, decimal IdDespacho)
         {
             try
             {
                 string numDocFactu = "";
                 decimal id = 0;
                 string ms = "";
                 fa_guia_remision_Info GuiRem_Info = new fa_guia_remision_Info();

                 if (txtGuia.Text != "")
                 {
                     if (BusGuiaRemision.VerificarCodigo(txtGuia.Text, param.IdEmpresa))
                     {
                         MessageBox.Show("El código Ingresado Ya existe por favor ingrese uno diferente", param.Nombre_sistema);
                         //return;
                     }
                 }

                 GuiRem_Info = getGuiaRemision(IdEmpresa, IdSucursal, IdDespacho);

                 if (BusGuiaRemision.GrabarDB(GuiRem_Info, ref id, ref numDocFactu, ref ms))
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             
             }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
             
         }

        private Boolean valida()
        {
            try
            {

                if (CmbObra.get_item_info() == null)
                {
                    MessageBox.Show("Debe seleccionar la Obra Asignada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   // PanelObra.Focus();
                    return false;


                }
                else if (CmbObra.get_item_info() == null)
                {
                    MessageBox.Show("Debe seleccionar la Obra Asignada ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   // PanelObra.Focus();
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
        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
              if (grabar()) this.Close();
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
        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {

            try
            {
                if (InfoCabDespacho != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (InfoCabDespacho.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el Despacho No.: " + InfoCabDespacho.NumDespacho 
                            + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();
                            InfoCabDespacho.Observacion = "***ANULADO****" + InfoCabDespacho.Observacion;
                            InfoCabDespacho.MotivoAnu = oFrm.motivoAnulacion;
                            InfoCabDespacho.IdUsuarioAnu = param.IdUsuario;
                            InfoCabDespacho.FechaAnu = DateTime.Now;

                            
                            prd_Despacho_cusCidersus_x_in_movi_inven_Info TI = new prd_Despacho_cusCidersus_x_in_movi_inven_Info();
                            prd_Despacho_cusCidersus_x_in_movi_inven_Bus busTI = new prd_Despacho_cusCidersus_x_in_movi_inven_Bus();

                            TI = busTI.TI_x_Despacho(InfoCabDespacho, ref msg);
                            in_movi_inve_Info mov = new in_movi_inve_Info();
                            mov.IdEmpresa = TI.IdEmpresa ;
                            mov.IdSucursal = TI.IdSucursal;
                            mov.IdBodega = TI.IdBodega;
                            mov.IdMovi_inven_tipo = TI.IdMovi_inven_tipo;
                            mov.IdNumMovi = TI.IdNumMovi;

                            if (busMov.AnularDB(mov,Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref msg))
                            {
                                if (busMovxProd.AnularDB(mov.IdEmpresa, mov.IdSucursal, mov.IdBodega, mov.IdNumMovi, mov.IdMovi_inven_tipo, ref msg))
                                {
                                    if (BusCabDespacho.AnularReactiva(InfoCabDespacho, ref msg))
                                    {
                                        MessageBox.Show("Anulado con exito el Despacho No. " + InfoCabDespacho.NumDespacho);
                                        InfoCabDespacho.Estado = "I";

                                        lblAnulado.Visible = true;
                                        set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                    }
                                    else error();
                                }
                                else error();
                            }
                            else error();
                        }


                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular el Ensamblado No.: " + InfoCabDespacho.NumDespacho + " debido a que ya se encuentra anulado", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());

            }
        }
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
        void ucGe_Menu_event_btnImprimir_guia_Click(object sender, EventArgs e)
        {
            try
            {
                
                //-- CARLOS ACTALIZACION

                //XPRO_CUS_CID_Rpt005 Xreport = new XPRO_CUS_CID_Rpt005();
                //prd_ObtenerReporte_Bus BusSpRep = new prd_ObtenerReporte_Bus();
                //List<tbPRO_CUS_CID_Rpt005_Info> data = new List<Info.Produc_Cirdesus.tbPRO_CUS_CID_Rpt005_Info>();
                //data = BusSpRep.OptenerData_spPRD_Rpt_RPRD005(param.IdEmpresa, InfoCabDespacho.IdSucursal, InfoCabDespacho.IdDespacho);
                //if (data == null)
                //{
                //    MessageBox.Show("Ha ocurrido un error al cargar el reporte...\n Comuniquese con Sistemas", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                //    Xreport.loaddata(data.ToArray());
                //    Xreport.ShowPreviewDialog();
                //}
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

                //-- CARLOS ACTALIZACION

                //XPRO_CUS_CID_Rpt011 Xreport = new XPRO_CUS_CID_Rpt011();
                //prd_ObtenerReporte_Bus BusSpRep = new prd_ObtenerReporte_Bus();
                //List<tbPRO_CUS_CID_Rpt005_Info> data = new List<Info.Produc_Cirdesus.tbPRO_CUS_CID_Rpt005_Info>();
                //data = BusSpRep.OptenerData_spPRD_Rpt_RPRD005(param.IdEmpresa, InfoCabDespacho.IdSucursal, InfoCabDespacho.IdDespacho);
                //if (data == null)
                //{
                //    MessageBox.Show("Ha ocurrido un error al cargar el reporte...\n Comuniquese con Sistemas", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                //    Xreport.loadData(data.ToArray());
                //    Xreport.ShowPreviewDialog();
                //}

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

                        var reg = (prd_DespachoDetalle_Info)gridViewDisponible.GetFocusedRow();
                        if (reg != null && reg.CodigoBarraMaestro != null)
                        { }

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void ucGe_Menu_Superior_Mant1_event_btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void txtIngCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var car = e.KeyChar.ToString();
                if (e.KeyChar.ToString() == "\r")
                {
                    preguntar = true;
                    buscarenlistado();
                }
                else preguntar = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void panel_cliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmbObra_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Superior_Mant1_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        private void CmbObra_Event_UCObra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbObra.get_item_info() != null)
                {
                    UCFa_Cliente.cmb_cliente.EditValue = CmbObra.get_item_info().IdCliente;
                    cargadata();

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_guia_Click(object sender, EventArgs e)
        {
            //aqui va lo de la guia de remision electronica
            BindingList<Comprobante_Info> listado_cbtes_info = null;
            try
            {
                ListVW_GuiaRemisionElectroncia_Info = BusVW_GuiaRemisionElectronica.Get_List_vwprd_Guia_Remision_Electronica(txtGuia.Text);
                LstGuiaRemisionElectronicaSRI = BusGuiaRemision.GenerarXmlGuiaRemision(ListVW_GuiaRemisionElectroncia_Info);

                listado_cbtes_info = new BindingList<Comprobante_Info>();



                foreach (var item in LstGuiaRemisionElectronicaSRI)
                {
                    try
                    {
                        listado_cbtes_info.Add(new Comprobante_Info(item.infoTributaria.secuencial
                             , Convert.ToDateTime(item.infoGuiaRemision.fechaIniTransporte), Core.Erp.Info.General.Cl_Enumeradores.eTipoComprobante.Guia
                             , item.infoGuiaRemision.razonSocialTransportista, item));
                    }
                    catch (Exception ex) { }
                }

                foreach (var item in listado_cbtes_info)
                {
                    string sIdCbteFact = "";
                    try
                    {
                        if (item.TipoCbte == Core.Erp.Info.General.Cl_Enumeradores.eTipoComprobante.Guia)
                        {
                            try
                            {
                                sIdCbteFact = item.cbtGR.infoTributaria.razonSocial.Substring(0, 3) + "-" + Core.Erp.Info.General.Cl_Enumeradores.eTipoCodComprobante.GUI + "-" + item.cbtGR.infoTributaria.estab + "-" + item.cbtGR.infoTributaria.ptoEmi + "-" + item.cbtGR.infoTributaria.secuencial;
                                XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                                NamespaceObject.Add("", "");
                                XmlSerializer mySerializer = new XmlSerializer(typeof(guiaRemision));
                                StreamWriter myWriter = new StreamWriter(@"C:\xml\xml" + sIdCbteFact + ".xml");
                                mySerializer.Serialize(myWriter, item.cbtGR, NamespaceObject);
                                myWriter.Close();

                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }
                    }
                    catch (Exception ex) { }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                //throw;
            }

        }

        
        
    }
}
