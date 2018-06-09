using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Business.Inventario ;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario_Cidersus ;
using Cus.Erp.Reports.Cidersus;
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_EnsambladoProductoFinal_Mantenimiento : Form
    {

        #region declaraciones de variables
        in_movi_inve_Info mv_cab = new in_movi_inve_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<prd_SubGrupoTrabajo_Info> lstGT = new List<prd_SubGrupoTrabajo_Info>();
        prd_OrdenTaller_Info OT = new prd_OrdenTaller_Info();
        Dictionary<string, decimal> LstDicProd = new Dictionary<string, decimal>();
        tb_Bodega_Info _bodegaInfo = new tb_Bodega_Info();
        tb_Sucursal_Info _sucursalInfo = new tb_Sucursal_Info();
        prd_parametros_CusCidersus_Info paramCidersus = new prd_parametros_CusCidersus_Info();
        prd_parametros_CusCidersus_Bus Busparam = new prd_parametros_CusCidersus_Bus();
        tb_Bodega_Bus BusBod = new tb_Bodega_Bus();
        tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();
        UCIn_Sucursal_Bodega UCSuc_Bod = new UCIn_Sucursal_Bodega();
        prd_Ensamblado_CusCider_Info Ensamblado = new prd_Ensamblado_CusCider_Info();
        prd_Ensamblado_CusCider_Bus BusEnsamblado = new prd_Ensamblado_CusCider_Bus();
        prd_OrdenTaller_Bus busOT = new prd_OrdenTaller_Bus();
        prd_SubGrupoTrabajo_Info GT = new prd_SubGrupoTrabajo_Info();
        prd_SubGrupoTrabajo_Bus busGT = new prd_SubGrupoTrabajo_Bus();
        List<in_Producto_Info> LstProd = new List<in_Producto_Info>();
        in_producto_x_tb_bodega_Bus Bus_prodxbod = new in_producto_x_tb_bodega_Bus();
        in_movi_inve_Bus Bus_mv = new in_movi_inve_Bus();
        in_movi_inve_detalle_Bus Bus_mv_det = new in_movi_inve_detalle_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Bus Bus_mv_detXpro = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_Producto_Info Prod_Term = new in_Producto_Info();
        List<in_movi_inve_detalle_Info> Lst_mv_detalle_ing = new List<in_movi_inve_detalle_Info>();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> Lst_mv_detalleXprod_eg = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        List<in_movi_inve_detalle_Info> Lst_mv_detalle_eg = new List<in_movi_inve_detalle_Info>();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> Lst_mv_detalleXprod_ing = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        List<prd_Ensamblado_Det_CusCider_Info> DetalleEnsam = new List<prd_Ensamblado_Det_CusCider_Info>();
        prd_ensamblado_cusCider_x_in_movi_inven_Info infoTI = new prd_ensamblado_cusCider_x_in_movi_inven_Info();
        prd_ensamblado_cusCider_x_in_movi_inven_Bus busTI = new prd_ensamblado_cusCider_x_in_movi_inven_Bus();
        in_producto_Bus busprod = new in_producto_Bus();
        BindingList<in_Producto_Info> ListadoDisponible = new BindingList<in_Producto_Info>();
        List< in_movi_inve_detalle_Info >in_movi_inve_detalle = new List< in_movi_inve_detalle_Info>();
        Cl_Enumeradores.eTipo_action iAccion = new Cl_Enumeradores.eTipo_action(); cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        UCPrd_Obra UCObra = new UCPrd_Obra();
        #endregion
        public FrmPrd_EnsambladoProductoFinal_Mantenimiento()
        {
            try
            {
                     InitializeComponent();
                    gridControlDisponible.DataSource = ListadoDisponible;
                    ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                    ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                    ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                    ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            
                  //Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing += new Delegate_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing(FrmPrd_EnsambladoProductoFinal_Mantenimiento_Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
          
        }



        private void groupBox2_Enter(object sender, EventArgs e){}

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

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaciones() == false)
                {
                    MessageBox.Show("No se guardo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    grabar();
                }
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
               anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaciones() == false)
                {
                    MessageBox.Show("No se guardo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    grabar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e){}

        private void FrmPrd_EnsambladoProductoFinal_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                paramCidersus = Busparam.ObtenerObjeto(param.IdEmpresa);
                    _sucursalInfo.IdEmpresa = _bodegaInfo.IdEmpresa = param.IdEmpresa;
                    _sucursalInfo.IdSucursal = _bodegaInfo.IdSucursal = paramCidersus.IdSucursal_Produccion;
                  _bodegaInfo.IdBodega = paramCidersus.IdBodega_Produccion;

                    cargacontroles();
                    //cargacombos();

                    UCSuc_Bod.Event_cmb_bodega_SelectedIndexChanged += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectedIndexChanged(UCSuc_Bod_Event_cmb_bodega_SelectedIndexChanged);
                    UCSuc_Bod.Event_cmb_sucursal_SelectedIndexChanged += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectedIndexChanged(UCSuc_Bod_Event_cmb_sucursal_SelectedIndexChanged);
                    UCObra.Event_UCObra_SelectionChanged
                       += new UCPrd_Obra.delegadoUCObra_SelectionChanged(UCObra_Event_UCObra_SelectionChanged);
                    UCObra.Event_UCObra_Validating += new UCPrd_Obra.delegadoUCObra_Validating(UCObra_Event_UCObra_Validating);
                    Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing += new Delegate_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing(FrmPrd_EnsambladoProductoFinal_Mantenimiento_Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
            
        }

        void FrmPrd_EnsambladoProductoFinal_Mantenimiento_Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e){}

        void UCObra_Event_UCObra_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (UCObra.get_item_info() == null)
                {
                    gridLkUOrdenTaller.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        
            
        }

        void UCSuc_Bod_Event_cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //getSucBod();
             //cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void UCSuc_Bod_Event_cmb_bodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //getSucBod();
                //cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

                
        void UCObra_Event_UCObra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                List<prd_OrdenTaller_Info> lstOt = new List<prd_OrdenTaller_Info>();
                ListadoDisponible = new BindingList<in_Producto_Info>();
                gridControlDisponible.DataSource = ListadoDisponible;
                  
                lstOt = busOT.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, UCObra.get_item());
                 gridLkUOrdenTaller.Properties.DataSource = lstOt;
                    
               // CARGAR LISTADO 

                             }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        
        }

        public delegate void Delegate_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing;

        private void FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                   Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        
        }
      
        public void ObtenerIdBodegaSucursal()
        {
            try
            {
                _sucursalInfo = UCSuc_Bod.get_sucursal();
                _bodegaInfo = UCSuc_Bod.get_bodega();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void cargacontroles()
        {
            try
            {
                UCSuc_Bod.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                UCSuc_Bod.cargar_sucursal(param.IdEmpresa);
                UCSuc_Bod.Dock = DockStyle.Bottom;
                UCSuc_Bod.set_sucursal(_sucursalInfo);
                UCSuc_Bod.set_bodega(_bodegaInfo);
                UCObra.cargaCmb_Obra();
                panelObra.Controls.Add(UCObra);
                UCObra.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        
        }

        void cargacombos()
        {
            try
            {

                List<prd_OrdenTaller_Info> lstOt = new List<prd_OrdenTaller_Info>();
                lstOt = busOT.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, UCObra.get_item());
                gridLkUOrdenTaller.Properties.DataSource =  lstOt;
                


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        
        
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action Accion)
        {

            try
            {
                iAccion = Accion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        //this.btn_guardar.Text = "Grabar Registro";
                       // this.btn_guardarysalir.Text = "Grabar y Salir";
                       // this.mnu_anular.Visible = false;
                      //  toolStripSeparator3.Visible = false;
                        break;
                   
                    case Cl_Enumeradores.eTipo_action.consultar:
                      //  this.mnu_anular.Visible = false;
                       // toolStripSeparator3.Visible = false;
                       // this.btn_guardar.Enabled = false;
                       // this.btn_guardarysalir.Enabled = false;
                        gridLkUOrdenTaller.Enabled = false;
                        gridLkUGrupoTrabajo.Enabled = false;
                     //   UCObra.UC_Obra.Enabled = false;
                        UCSuc_Bod.cmb_sucursal.Enabled = false;
                        UCSuc_Bod.cmb_bodega.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                      //  this.mnu_anular.Visible = true;
                      //  this.toolStripSeparator3.Visible = true;
                       // this.btn_guardar.Enabled = false;
                       // this.btn_guardarysalir.Enabled = false;
                        gridLkUOrdenTaller.Enabled = false;
                        gridLkUGrupoTrabajo.Enabled = false;
                       // UCObra.UC_Obra.Enabled = false;
                        UCSuc_Bod.cmb_sucursal.Enabled = false;
                        UCSuc_Bod.cmb_bodega.Enabled = false;

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
        
        public void setCab(prd_Ensamblado_CusCider_Info Info)
        {
            try
            {
                Ensamblado = Info;
                _sucursalInfo.IdEmpresa = _bodegaInfo.IdEmpresa = Info.IdEmpresa;
                ucIn_Sucursal_Bodega.set_Idsucursal(Info.IdSucursal);
                ucIn_Sucursal_Bodega.set_Idbodega(Info.IdSucursal,Info.IdBodega);
                UCObra.set_item(Info.CodObra);
                UCSuc_Bod.set_sucursal(_sucursalInfo);
                UCSuc_Bod.set_bodega(_bodegaInfo);
                gridLkUOrdenTaller.EditValue = Info.IdOrdenTaller; ;
                GT = busGT.OBtenerGT(param.IdEmpresa, Info.IdSucursal,
                    Info .IdGrupoTrabajo);
              
                txtEnsamblado.Text = Convert.ToString(Info.IdEnsamblado);
                txtObservacion.Text = Info.Observacion;
                txtCodBarra.Text = Info.CodigoBarra;
                dtPfecha.Value = Info.FechaTransac;
                prd_Ensamblado_Det_CusCider_Bus busDetEns = new prd_Ensamblado_Det_CusCider_Bus();
                DetalleEnsam = busDetEns.ConsultaEnsamblado(Info .IdEmpresa,
                    Info.IdSucursal, Info.IdEnsamblado,ref msg);
                cargagrid(DetalleEnsam);

                List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info> LstMov = new List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info>();
                LstMov = Bus_mv_detXpro.ConsultaMovimienosxEnsamblado(Ensamblado.IdEnsamblado, Ensamblado.IdSucursal, Ensamblado.IdEmpresa);
                gridCtrlMov.DataSource = LstMov;
                gridLkUGrupoTrabajo.EditValue = GT.IdGrupoTrabajo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        
        
        }



        void cargadataproducto(prd_OrdenTaller_Info info)
        {
            try
            {
                txtProducto.Text = busprod.Get_DescripcionTot_Producto(param.IdEmpresa, OT.IdProducto);
                ObtenerCantAProd(OT);
        
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            
        
        }
        
        void cargagrid(List<prd_Ensamblado_Det_CusCider_Info > Det)
        {
            try
            {

                foreach (var item in Det)
                {
                    in_Producto_Info prod = new in_Producto_Info();
                    prod.IdEmpresa = item.IdEmpresa;
                    prod.IdSucursal = item.IdSucursal;
                    prod.IdProducto = item.IdProducto;
                    prod.pr_descripcion = busprod.Get_DescripcionTot_Producto(item.IdEmpresa, item.IdProducto);
                    prod.pr_codigo_barra = item.CodigoBarra;
                    prod.CantidadAjustada = item.en_cantidad;
                    prod.pr_observacion = item.Observacion;
                    LstProd.Add(prod);

                }

                ListadoDisponible = new BindingList<in_Producto_Info>(LstProd);
                gridControlDisponible.DataSource = ListadoDisponible;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        
        
        }

        string msg = "";

        private int ObtenerCantAProd(prd_OrdenTaller_Info info)
        {
            try
            {
                vwprd_CantidadEnsamblada_x_OT_CusCider_Info CantEnsam = new vwprd_CantidadEnsamblada_x_OT_CusCider_Info();
                int Cant = 0;
                
                CantEnsam = BusEnsamblado.TraerCantEnsamb(info, ref msg);
                txtCantAProducir.Text = Convert.ToString  ( CantEnsam.CantidadPieza - CantEnsam.CantEnsamblada);
                
                if (Convert.ToDecimal(txtCantAProducir.Text) <= 0)
               
                    txtCantAProducir.ForeColor  = Color.Red;
                    
                else
                    txtCantAProducir.ForeColor = Color.Black;

                if (Convert.ToDecimal(txtCantAProducir.Text) <= 0 && iAccion == Cl_Enumeradores.eTipo_action.grabar)
                
                    lblNoEnsamblar.Visible = true;

                
                else
                    lblNoEnsamblar.Visible = false;

                
                return Cant;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + msg + ex.InnerException.ToString());
                return 0; 
            }

        }
        
        private void gridLkUOrdenTaller_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (gridLkUOrdenTaller.EditValue == null)
                {
                    gridLkUOrdenTaller.Text = "";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        
        private int etapaanterior(int etapaensamblado, int idprocprod)
        {
            try
            {
                prd_EtapaProduccion_Bus BusEta = new prd_EtapaProduccion_Bus();
                prd_EtapaProduccion_Info etaorig = new prd_EtapaProduccion_Info();
                List<prd_EtapaProduccion_Info> ListEtapas = new List<prd_EtapaProduccion_Info>();
                    etaorig = BusEta.ObtenerEtapa(param.IdEmpresa, etapaensamblado, idprocprod );
                    ListEtapas = BusEta.ObtenerListaEtapas(param.IdEmpresa, idprocprod);

                    foreach (var item in ListEtapas)
                    {
                        if (etaorig.Posicion - 1 == item.Posicion)
                        {
                            return item.IdEtapa;
                            
                        
                        }
                        
                    }
                    return 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return 0;
            }
        
        
        }

        void grabar() 
        {
            try
            {
                txtObservacion.Focus();
                decimal idEnsamb = 0;
                decimal idMovIng = 0;
                decimal idMovEg = 0;
                string msg = "";
                string mensaje_cbte_cble = ""; 
                mv_cab.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_egr_Ensamblado);
                mv_cab.cm_tipo = "-";
                mv_cab.cm_observacion = " Egr Suc " + UCSuc_Bod.cmb_sucursal.Text + " Bod " + UCSuc_Bod.cmb_bodega.Text + Ensamblado.Observacion;
                mv_cab.listmovi_inve_detalle_Info = Lst_mv_detalle_eg;
                if (Bus_mv.GrabarDB(mv_cab, ref idMovEg, ref mensaje_cbte_cble, ref msg))
                {
                    Lst_mv_detalle_eg.ForEach(var => var.IdNumMovi = idMovEg);
                    int et_anterior = etapaanterior(GT.IdEtapa, GT.IdProcesoProductivo);
                    if (et_anterior == 0)
                        Lst_mv_detalleXprod_eg.ForEach(var => var.IdNumMovi = idMovEg);
                    else
                    {


                        Lst_mv_detalleXprod_eg.ForEach(var =>
                        {
                            var.et_IdEmpresa = param.IdEmpresa;
                            var.IdNumMovi = idMovEg;
                            var.et_IdProcesoProductivo = GT.IdProcesoProductivo;
                            var.et_IdEtapa = et_anterior;

                        });
                    }
                }

                {
                    mv_cab.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_ing_Ensamblado);
                    mv_cab.cm_tipo = "+";
                    mv_cab.cm_observacion = " Ing Suc " + UCSuc_Bod.cmb_sucursal.Text +
                        " Bod " + UCSuc_Bod.cmb_bodega.Text + Ensamblado.Observacion;
                }
                mv_cab.IdNumMovi = 0;




                if (Bus_mv.GrabarDB(mv_cab, ref idMovIng, ref mensaje_cbte_cble, ref msg))
                {
                    Lst_mv_detalle_ing.ForEach(var => var.IdNumMovi = idMovIng);
                    Lst_mv_detalleXprod_ing.ForEach(var => var.IdNumMovi = idMovIng);

                    if (Bus_mv_det.GrabarDB(Lst_mv_detalle_ing, ref msg))
                    {
                        Lst_mv_detalleXprod_ing.ForEach(var =>
                        {
                            var.et_IdEmpresa = GT.IdEmpresa;
                            var.et_IdProcesoProductivo = GT.IdProcesoProductivo;
                            var.et_IdEtapa = GT.IdEtapa;
                        });

                        if (Bus_mv_detXpro.GuardarDB(Lst_mv_detalleXprod_ing, ref msg))
                            if (Bus_prodxbod.ActualizarStock_x_Bodega_con_moviInven(Lst_mv_detalle_ing, ref msg))
                                MessageBox.Show("Movimiento Inventario No. " + idMovIng
                                    + " Ingreso de Bodega de Produccion por Etapa de Ensamblado. \n Grabado Satisfactoriamente",
                                    "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }



                var detalleingreso = Bus_mv_detXpro.ConsultaxMovInvTipo(param.IdEmpresa,
                    mv_cab.IdSucursal, mv_cab.IdBodega, idMovIng, mv_cab.IdMovi_inven_tipo);
                foreach (var item in detalleingreso)
                {
                    txtCodBarra.Text = item.CodigoBarra;
                }
                Ensamblado.CodigoBarra = txtCodBarra.Text;
                Ensamblado.Observacion = Ensamblado.Observacion + "Mov Eg" + idMovEg + "Mov Ing" + idMovIng;

                if (BusEnsamblado.GuardarDB(Ensamblado, DetalleEnsam, ref idEnsamb, ref msg))
                {
                    infoTI.en_IdEmpresa = infoTI.IdEmpresa = Ensamblado.IdEmpresa;
                    infoTI.en_IdSucursal = infoTI.IdSucursal = Ensamblado.IdSucursal;
                    infoTI.en_IdEnsamblado = idEnsamb;
                    infoTI.IdBodega = mv_cab.IdBodega;
                    infoTI.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_egr_Ensamblado);
                    infoTI.IdNumMovi = idMovEg;


                    if (busTI.GuardarDB(infoTI, ref msg))
                    {
                        infoTI.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_ing_Ensamblado);
                        infoTI.IdNumMovi = idMovIng;

                        if (busTI.GuardarDB(infoTI, ref msg))
                        {
                            MessageBox.Show("Ensamblado No. " + idEnsamb + "\n Grabado Satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEnsamblado.Text = Convert.ToString(idEnsamb);
                            set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                            Ensamblado.IdEnsamblado = idEnsamb;
                            setCab(Ensamblado);
                        }
                    }
                }

                else
                { }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString()); 
            }
        } 

        private Boolean getCab()
        {
            try
            {
                Ensamblado.IdEmpresa = param.IdEmpresa;
                Ensamblado.IdSucursal = _sucursalInfo.IdSucursal;
                Ensamblado.IdEnsamblado = 0;
                Ensamblado.IdBodega = _bodegaInfo.IdBodega;
                Ensamblado.IdGrupoTrabajo = Convert.ToDecimal(gridLkUGrupoTrabajo.EditValue);
                Ensamblado.IdProducto = OT.IdProducto;
                Ensamblado.CodObra = UCObra.get_item();
                Ensamblado.IdOrdenTaller = Convert.ToDecimal(gridLkUOrdenTaller.EditValue);
                Ensamblado.IdUsuario = param.IdUsuario;
                Ensamblado.FechaTransac =  DateTime.Now;
                Ensamblado.Estado = "A";
                //var prod = busprod.Get_Info_BuscarProducto(Ensamblado.IdProducto, param.IdEmpresa);
                        
                Ensamblado.Observacion = txtObservacion.Text +
                    " Ens Prod "+ txtProducto.Text+
                    " x Ob " + UCObra.get_item()+
                    " Ot " + gridLkUOrdenTaller.Text+
                    " Gt " + gridLkUGrupoTrabajo.Text
                    ;
                return getDet();

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.ToString()); 
                return false; 
            }
       
        }

        private Boolean getDet()
        {
            int Sec = 0;
            try
            {
                
                DetalleEnsam = new List<prd_Ensamblado_Det_CusCider_Info>();
                string observacioncab = "";
                foreach (var item in ListaGrabar)
                {
                    prd_Ensamblado_Det_CusCider_Info info = new prd_Ensamblado_Det_CusCider_Info();
                    info.IdProducto = item.IdProducto;
                    var prod = busprod.Get_Info_BuscarProducto(info.IdProducto, param.IdEmpresa);
                    info.CodigoBarra = item.pr_codigo_barra;
                    info.Observacion = item.pr_observacion + " " +
                        Ensamblado.Observacion +
                        " con Prod " + prod.pr_descripcion +
                        " CB " + item.pr_codigo_barra;
                    info.en_cantidad = 1;
                    observacioncab = observacioncab +
                        " con Prod " + prod.pr_descripcion +
                        " CB " + item.pr_codigo_barra;
                    DetalleEnsam.Add(info);
                    
                }
               
                Ensamblado.Observacion = Ensamblado.Observacion + observacioncab;

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:"+ex.InnerException.ToString());
                return false; 
            }
        }

        List<in_Producto_Info> ListaGrabar = new List<in_Producto_Info>();

        private Boolean  validaciones()
        {
            try
            {

                if(lblNoEnsamblar.Visible == true)
                {
                    MessageBox.Show("Debe seleccionar otra Orden de Taller. No tiene cantidades disponibles a Ensamblar.",
                        "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridLkUOrdenTaller.Focus();
                    return false;
                }
                if (UCObra.get_item_info() == null)
                {
                    MessageBox.Show("Debe seleccionar una Obra", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    panelObra.Focus();
                    return false;
                }
                else if (gridLkUOrdenTaller.EditValue == null||gridLkUOrdenTaller.EditValue=="")
                {
                    MessageBox.Show("Debe seleccionar una Orden de Taller", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridLkUOrdenTaller.Focus();
                    return false;
                }
                else if (gridLkUGrupoTrabajo.EditValue == null || gridLkUGrupoTrabajo.EditValue == "")
                {
                    MessageBox.Show("Debe seleccionar un Grupo de Trabajo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridLkUGrupoTrabajo.Focus();
                    return false;
                }
                else if (UCSuc_Bod.get_sucursal() == null)
                {
                    MessageBox.Show("Debe seleccionar una Sucursal", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridLkUOrdenTaller.Focus();
                    UCSuc_Bod.cmb_sucursal.Focus();
                    return false;
                }
                else if (UCSuc_Bod.get_bodega() == null)
                {
                    MessageBox.Show("Debe seleccionar una Bodega", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UCSuc_Bod.cmb_bodega.Focus();
                    return false;
                }

                ListaGrabar = new List<in_Producto_Info>();
                foreach (var item in ListadoDisponible)
                {
                    if (item.Cheked == true)
                        ListaGrabar.Add(item);
                    
                }
                if (ListaGrabar.Count <= 0)
                { MessageBox.Show("Ingrese los elementos a ensamblar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                
                if (getCab())
                {
                    return getprod_mov();

                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString()); 
                return false;
            }
        
        }
       



        void anular()
        {

            
                try
                {
                    if (Ensamblado  != null)
                    {
                        FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                        
                        if (Ensamblado.Estado == "A")
                        {
                            if (MessageBox.Show("¿Está seguro que desea anular el Ensamblado No.: " + Ensamblado.IdEnsamblado+ " ?", 
                                "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string msg = "";
                                oFrm.ShowDialog();
                                Ensamblado.Observacion = "***ANULADO****" + Ensamblado.Observacion;
                                Ensamblado.MotivoAnu= oFrm.motivoAnulacion;
                                Ensamblado.IdUsuarioAnu = param.IdUsuario;
                                Ensamblado.FechaAnu = DateTime.Now;

                                if (BusEnsamblado.AnularEnsamb_Mov(Ensamblado, ref msg))
                                {
                                    MessageBox.Show("Anulado con exito el Ensamblado No. " + Ensamblado.IdEnsamblado);
                                    Ensamblado.Estado = "I";

                                    lblAnulado.Visible = true;
                                    set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                }

                            }


                        }
                        else
                        {
                            MessageBox.Show("No se pudo anular el Ensamblado No.: " + Ensamblado.IdEnsamblado+" debido a que ya se encuentra anulado", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }

                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString());

                }
            }
        
        private Boolean  getprod_mov()
        {
            try{
                
                
                //Cabecera del movimiento
                mv_cab.IdEmpresa = param.IdEmpresa;
                mv_cab.IdSucursal = _sucursalInfo.IdSucursal;
                mv_cab.IdBodega = _bodegaInfo.IdBodega;
                mv_cab.cm_observacion = Ensamblado.Observacion;
                mv_cab.cm_fecha = Convert.ToDateTime(dtPfecha.Value);
                mv_cab.cm_mes = mv_cab.cm_fecha.Month;
                mv_cab.cm_anio = mv_cab.cm_fecha.Year;
                mv_cab.Fecha_Transac = DateTime.Now;

                mv_cab.IdUsuario = param.IdUsuario;
                mv_cab.nom_pc = param.nom_pc;
                mv_cab.ip = param.ip;
                mv_cab.Estado = "A";

                if (getingresomov() == false)
                    return false;
                if (getegresomov() == false)
                    return false;
                return true;
         }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString());
                return false; 
            }
        
        }

        private Boolean getegresomov()
        {

            try
            {

                //obtengo el Lst_mv_detalle_eg Detalle del movimiento de egreso
                int sec = 0;
                foreach (var item in DetalleEnsam)
                {
                    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                    in_movi_inve_detalle_x_Producto_CusCider_Info infoxprod = new in_movi_inve_detalle_x_Producto_CusCider_Info();

                    info.IdEmpresa = infoxprod.IdEmpresa = Convert.ToInt32(param.IdEmpresa);
                    infoxprod.ot_IdEmpresa = Convert.ToInt32(param.IdEmpresa);
                    info.IdSucursal = infoxprod.IdSucursal =  _sucursalInfo.IdSucursal;
                    infoxprod.ot_IdSucursal = _sucursalInfo.IdSucursal;
                    info.IdBodega = infoxprod.IdBodega = _bodegaInfo.IdBodega;
                    info.IdProducto = infoxprod.IdProducto = item.IdProducto;
                    infoxprod.CodigoBarra = item.CodigoBarra;
                    info.Secuencia = infoxprod.mv_Secuencia = ++sec;
                    info.IdMovi_inven_tipo = infoxprod.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_egr_Ensamblado);
                    info.mv_tipo_movi = infoxprod.mv_tipo_movi = "-";
                    info.dm_cantidad = infoxprod.dm_cantidad = -1;

                    var saldo = Bus_prodxbod.Get_Info_Producto_x_Producto(param.IdEmpresa, _sucursalInfo.IdSucursal, _bodegaInfo.IdBodega, item.IdProducto);
                   
                    info.dm_stock_ante = saldo.pr_stock;
                    info.dm_stock_actu = info.dm_stock_ante + info.dm_cantidad;

                    in_Producto_Info prodtemp = new in_Producto_Info();
                    prodtemp = busprod.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                    info.dm_precio = infoxprod.dm_precio = prodtemp.pr_precio_publico == null ? 0 : Convert.ToDouble(prodtemp.pr_precio_publico);
                    info.mv_costo = info.dm_precio;
                    infoxprod.mv_costo = infoxprod.mv_costo = prodtemp.pr_costo_promedio == null ? 0 : Convert.ToDouble(prodtemp.pr_precio_publico);
                    info.dm_observacion = infoxprod.dm_observacion = 
                        " Egr Suc " + UCSuc_Bod.cmb_sucursal.Text+
                        " Bod "+ UCSuc_Bod.cmb_bodega.Text +" "+
                         item.Observacion;
                    infoxprod.ot_CodObra = UCObra.get_item();
                    infoxprod.ot_IdOrdenTaller = OT.IdOrdenTaller;

                    Lst_mv_detalleXprod_eg.Add(infoxprod);
                    Lst_mv_detalle_eg.Add(info);

                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString()); 
                return false;
            }
        }

        private Boolean getingresomov()
        {
            try {

                //obtengo el Lst_mv_detalle_ing Detalle del movimiento de ingreso
                int sec = 0;
                
                    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                    in_movi_inve_detalle_x_Producto_CusCider_Info infoxprod = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    info.IdEmpresa =  infoxprod.IdEmpresa = param.IdEmpresa;
                    infoxprod.ot_IdEmpresa = param.IdEmpresa;
                    info.IdSucursal = infoxprod.IdSucursal = _sucursalInfo.IdSucursal;
                    infoxprod.ot_IdSucursal = _sucursalInfo.IdSucursal;
                    info.IdBodega = infoxprod.IdBodega = _bodegaInfo.IdBodega;
                    info.IdProducto = infoxprod.IdProducto = OT.IdProducto;
                    info.Secuencia = infoxprod.mv_Secuencia = ++sec;
                    info.IdMovi_inven_tipo = infoxprod.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_ing_Ensamblado);
                    info.mv_tipo_movi = infoxprod.mv_tipo_movi = "+";
                    info.dm_cantidad = infoxprod.dm_cantidad = 1;
                    var saldo = Bus_prodxbod.Get_Info_Producto_x_Producto(param.IdEmpresa, _sucursalInfo.IdSucursal, _bodegaInfo.IdBodega, OT.IdProducto);
                    
                    info.dm_stock_ante = saldo.pr_stock;
                    info.dm_stock_actu = info.dm_stock_ante + info.dm_cantidad;

                    in_Producto_Info prodtemp = new in_Producto_Info();

                    prodtemp = busprod.Get_Info_BuscarProducto(OT.IdProducto, param.IdEmpresa);
                    if (prodtemp != null)
                    {
                        info.dm_precio = infoxprod.dm_precio = prodtemp.pr_precio_publico == null ? 0 : Convert.ToDouble(prodtemp.pr_precio_publico);
                        info.mv_costo = info.dm_precio;
                        infoxprod.mv_costo = infoxprod.mv_costo = prodtemp.pr_costo_promedio == null ? 0 : Convert.ToDouble(prodtemp.pr_precio_publico);
                        info.dm_observacion = infoxprod.dm_observacion =
                            " Ing Suc " + UCSuc_Bod.cmb_sucursal.Text +
                        " Bod " + UCSuc_Bod.cmb_bodega.Text +
                        Ensamblado.Observacion;
                    }
                    infoxprod.ot_CodObra = UCObra.get_item();
                    infoxprod.ot_IdOrdenTaller = OT.IdOrdenTaller;
                    Lst_mv_detalleXprod_ing.Add(infoxprod);
                    Lst_mv_detalle_ing.Add(info);

                return true; }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); 
                return false; 
            }
        }

        private void gridLkUGrupoTrabajo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (gridLkUGrupoTrabajo.EditValue == null)
                {
                    gridLkUGrupoTrabajo.Text = "";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

   
       


        private void toolStripStatusLabel1_Click(object sender, EventArgs e){}

       

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Superior_Mant2_Load(object sender, EventArgs e)
        {

        }

 

        private void gridLkUOrdenTaller_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 UCSuc_Bod.get_bodega();
                ListadoDisponible = new BindingList<in_Producto_Info>();
                gridControlDisponible.DataSource = ListadoDisponible;

                if (gridLkUOrdenTaller.EditValue != null && gridLkUOrdenTaller.EditValue != "")
                {
                    OT = busOT.ObtenerUnaOT(param.IdEmpresa, _sucursalInfo.IdSucursal,
                        Convert.ToDecimal(gridLkUOrdenTaller.EditValue), UCObra.get_item());
                    lstGT = busGT.ObtenerGrupoTrabajoCab_x_OT(param.IdEmpresa, Convert.ToInt32(UCSuc_Bod.cmb_sucursal.EditValue), Convert.ToDecimal(gridLkUOrdenTaller.EditValue));
                    gridLkUGrupoTrabajo.Properties.DataSource = lstGT;
                   
                    cargadataproducto(OT);
                }
                else
                {

                    gridLkUGrupoTrabajo.Text = "";
                    txtCantAProducir.Text = "";
                    txtProducto.Text = "";

                }
                //*********************
                 CargarData();


                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        private void gridLkUGrupoTrabajo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                    GT = (prd_SubGrupoTrabajo_Info)gridLkUGrupoTrabajo.Properties.View.GetFocusedRow();
                    int et_anterior = etapaanterior(GT.IdEtapa, GT.IdProcesoProductivo);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public void CargarData()
        {
            try
            {

                if (gridLkUOrdenTaller.EditValue != null && gridLkUOrdenTaller.EditValue != "")
                {
                    
                    ListadoDisponible = new BindingList<in_Producto_Info>();
                    List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> LstDetxProd = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
                  
                    
                    in_movi_inve_detalle_x_Producto_CusCider_Bus BusDetxProd = new in_movi_inve_detalle_x_Producto_CusCider_Bus();

                    LstDetxProd = BusDetxProd.ObtenerMateriaPrima(param.IdEmpresa, param.IdSucursal,Convert.ToInt32( ucIn_Sucursal_Bodega.cmb_bodega.EditValue), Convert.ToInt32(OT.CodObra), Convert.ToInt32(OT.IdOrdenTaller));
                    gridControlDisponible.DataSource = LstDetxProd;

                    foreach (var item in LstDetxProd)
                    {
                        in_Producto_Info prod = new in_Producto_Info();

                        prod.pr_codigo_barra = item.CodigoBarra;
                        prod.IdProducto = item.IdProducto;
                        prod.IdEmpresa = item.IdEmpresa;
                        prod.IdSucursal = item.IdSucursal;
                        prod.IdBodega = item.IdBodega;
                        prod.pr_descripcion = item.pr_descripcion;// busprod.DescripcionTot_Producto(item.IdEmpresa, item.IdProducto);
                        ListadoDisponible.Add(prod);

                    }

                    gridControlDisponible.DataSource = ListadoDisponible;



                }
                else
                {
                    MessageBox.Show("No hay codigos de Barra para OT Seleccionada");
                    ListadoDisponible = new BindingList<in_Producto_Info>();
                    gridControlDisponible.DataSource = ListadoDisponible;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                //-- CARLOS ACTALIZACION

                List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListaP = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                ListaP = Bus_mv_detXpro.ImpresionCBProductoTerminado(param.IdEmpresa, param.IdSucursal, Convert.ToInt32(txtEnsamblado.Text));



                XRpt_prd_CodigoBarraProductoTerminado Reporte = new XRpt_prd_CodigoBarraProductoTerminado();



                if (ListaP != null)
                {


                    Reporte.loadData(ListaP.ToArray());
                    Reporte.ShowPreviewDialog();

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al cargar los datos. "
                        + "Por favor comuniquese con sistemas...");
                }



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
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

    }
}
