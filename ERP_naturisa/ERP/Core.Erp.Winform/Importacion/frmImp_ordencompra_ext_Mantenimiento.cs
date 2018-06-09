using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Importacion;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar ;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.General;
using System.Collections.Specialized;

namespace Core.Erp.Winform.Importacion
{

    

    public partial class frmImp_ordencompra_ext_Mantenimiento : Form
    {
        #region Declaración de Variables
        string ban = "A";
        Boolean bandera = true;
        public Boolean GenDiarioTipImpo;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<imp_ordencompra_ext_x_Condiciones_Pago_Info> DataSourceCondicionesPago;
        cp_proveedor_Info InfoProveedor = new cp_proveedor_Info();
        imp_Parametros_Info ParemtrosImportacion = new imp_Parametros_Info();
        imp_Parametros_Bus BusParametros = new imp_Parametros_Bus();
        List<in_Producto_Info> lista = new List<in_Producto_Info>();
        imp_ordencompra_ext_x_ct_cbtecble_Bus _BusImpxCbte = new imp_ordencompra_ext_x_ct_cbtecble_Bus();
        BindingList<imp_ordencompra_ext_det_Info> DataSourceProducto = new BindingList<imp_ordencompra_ext_det_Info>();
        ba_Banco_Cuenta_Bus BusBanco = new ba_Banco_Cuenta_Bus();
        //List<tb_ubicacion_Info> Paises = new List<tb_ubicacion_Info>();
        List<tb_moneda_info> ListaMoneda = new List<tb_moneda_info>();
        double IVa;
        ct_Cbtecble_Bus Buscbte = new ct_Cbtecble_Bus();
        decimal Subtotal;
        imp_ordencompra_ext_x_imp_gastosxImport_Bus BusGastos = new imp_ordencompra_ext_x_imp_gastosxImport_Bus();
        //tb_ubicacion_Bus oBus = new tb_ubicacion_Bus();
        imp_ordencompra_ext_det_Bus BusOrdenCompraDeta = new imp_ordencompra_ext_det_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        public imp_ordencompra_ext_Info _infoset { get; set; }
        imp_DatosEmbarque_bus BusDatoEmbarque = new imp_DatosEmbarque_bus();
        public delegate void delegate_frmImp_ordencompra_ext_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmImp_ordencompra_ext_Mantenimiento_FormClosing Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing;
        tb_Sucursal_Bus Bus_Sucursal = new tb_Sucursal_Bus();
        tb_Sucursal_Info Info_Sucursal = new tb_Sucursal_Info();
        imp_ordencompra_ext_Info _Info = new imp_ordencompra_ext_Info();


        List<cp_proveedor_Info> ListaPersonas = new List<cp_proveedor_Info>();

        UCGe_Pais UCPaisOrigen = new UCGe_Pais();
        UCGe_Pais UCPaisDestino = new UCGe_Pais();
        imp_Embarcador_Bus EmbUs = new imp_Embarcador_Bus();
        ct_Plancta_Bus _PlanCta_bus1 = new ct_Plancta_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //tb_persona_bus oBusPErsona = new tb_persona_bus();
        cp_proveedor_Bus oBusPErsona = new cp_proveedor_Bus();

        imp_catalogo_Bus ObusCatalogo = new imp_catalogo_Bus();
        List<imp_catalogo_Info> ListCatalogo = new List<imp_catalogo_Info>();
        tb_moneda_Bus BusMoneda = new tb_moneda_Bus();
        DataTable dt = new DataTable("detalle");
        DataTable dtProd = new DataTable("producto");
        DataTable dtGastos = new DataTable("GastosImportacion");
        imp_Ciclo_Bus oBusCiclo = new imp_Ciclo_Bus();
        in_producto_Bus BusProducto = new in_producto_Bus();
        List<imp_DatosEmbarque_Info> ListaDatoEmbarque = new List<imp_DatosEmbarque_Info>();
        imp_ordencompra_ext_Bus BUS = new imp_ordencompra_ext_Bus();
        string MensajeError = "";

        #endregion

        public frmImp_ordencompra_ext_Mantenimiento()
        {
            try
            {
                InitializeComponent();
                ParemtrosImportacion = BusParametros.Get_Info_Parametros(param.IdEmpresa);
                DataSourceCondicionesPago = new BindingList<imp_ordencompra_ext_x_Condiciones_Pago_Info>();
                gridControlCondicionespago.DataSource = DataSourceCondicionesPago;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

            
        }

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
        
        #region Combos
   
       
        public void ObtenerCombosCatalogoTipo(int IdTipoCatalogo , DevExpress.XtraEditors.SearchLookUpEdit  Combo)
        {

            try
            {
                var catalogo = from q in ListCatalogo
                               where q.IdCatalogoImport_tipo == IdTipoCatalogo
                               select q;
                Combo.Properties.DataSource = catalogo.ToList();
                Combo.Properties.ValueMember = "IdCatalogoImport";
                Combo.Properties.DisplayMember = "Nombre";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

           

        }



        public List<imp_catalogo_Info> ObtenerCatalogoTipo(int IdTipoCatalogo)
        {
            try
            {
                var catalogo = from q in ListCatalogo
                               where q.IdCatalogoImport_tipo == IdTipoCatalogo
                               select q;
                return catalogo.ToList();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return new List<imp_catalogo_Info>();
            }

        }
        
        public void SetDataSourceComboPais(DevExpress.XtraEditors.SearchLookUpEdit  Combo)
        {
            try
            {
                //Combo.Properties.DataSource = Paises;
                //Combo.Properties.ValueMember = "IdUbicacion";
                //Combo.Properties.DisplayMember = "ub_descripcion";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                
            }
        }


        public void cargarPais()
        {
            try
            {
                  SetDataSourceComboPais(ultraComboEditorPaisDestino);
                  SetDataSourceComboPais(ultraComboEditorPaisOrigen);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
            
        }


        public void CargarSucursal()
        {
            try
            {
                ultraComboEditorSucursal.Properties.DataSource = Bus_Sucursal.Get_List_Sucursal(param.IdEmpresa);
                ultraComboEditorSucursal.Properties.DisplayMember = "Su_Descripcion";
                ultraComboEditorSucursal.Properties.ValueMember = "IdSucursal";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }


        public void CargarTerminoPago()
        {
            try
            {

            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        public void CargarCiclo()
        {
            try
            {
                ObtenerCombosCatalogoTipo(1, ultraComboEditorCiclo);
                ultraComboEditorCiclo.EditValue = "CLNIG";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }


        public void CargarVia()
        {
            try
            {
               
                ObtenerCombosCatalogoTipo(7, ultraComboEditorVia);
                ultraComboEditorVia.EditValue = 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
        public void CargarProveedores()
        {
            try
            {
                var Proveedores = oBusPErsona.Get_List_proveedor(param.IdEmpresa);

                Proveedores.ForEach(var => var.pr_nombre = "[" + var.IdProveedor + "] " + var.pr_nombre);
                ListaPersonas = Proveedores;
                gridLookUpEditProveedor.Properties.DataSource = ListaPersonas;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());                
            }
            

        }
        public void CargarEmbarcadores()
        {
            try
            {

                ultraComboEditorEmbarcador.Properties.DataSource = EmbUs.ListaEmbarcadores();
                ultraComboEditorEmbarcador.Properties.ValueMember = "IdEmbarcador";
                ultraComboEditorEmbarcador.Properties.DisplayMember = "em_descripcion";
                ultraComboEditorEmbarcador.EditValue = 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }

        }
        public void CargarCtaCble()
        {

            try
            {
                this.ultraComboEditorCtaCble.Properties.DataSource = _PlanCta_bus1.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                this.ultraComboEditorCtaCble.Properties.DisplayMember = "pc_Cuenta2";
                this.ultraComboEditorCtaCble.Properties.ValueMember = "IdCtaCble";
                ultraComboEditorCtaCble.EditValue = ParemtrosImportacion.IdCtaCble_para_Importaciones;
                ultraComboEditorCtaCble.Enabled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }

        }
        public void SetDataSourceCombosMonedas(DevExpress.XtraEditors.SearchLookUpEdit  Combo) 
        {
            try
            {
                Combo.Properties.DataSource = ListaMoneda;
                Combo.Properties.DisplayMember = "im_descripcion";
                Combo.Properties.ValueMember = "IdMoneda";
            }   
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
        public void CagarCombosMoneda()
        {
            try
            {
                SetDataSourceCombosMonedas(ultraComboEditorMonedaLocal);
                SetDataSourceCombosMonedas(ultraComboEditorMonedaOrigen);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
        public void cargarComboGrilla() 
        {
            try
            {
                repositoryItemGridLookUpEdit2.DataSource = ObtenerCatalogoTipo(3);
                repositoryItemGridLookUpEdit1.DataSource = ObtenerCatalogoTipo(8);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        List<in_categorias_Info> listaCategoria = new List<in_categorias_Info>();
        public void CargarCategorias() 
        {
            try
            {
                in_categorias_bus BusCategoria = new in_categorias_bus();

                 listaCategoria = BusCategoria.Get_List_categorias(param.IdEmpresa) ;

             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion
        
        public void CargarCombos()
        {
            try
            {
                CargarCategorias();
                //Paises = oBus.Get_List_Pais();
                ListaMoneda = BusMoneda.Get_List_Moneda();
                cargarComboGrilla();
                cargarPais();
                CargarSucursal();
                CargarProveedores();
                CargarEmbarcadores();
                CargarCiclo();
                CargarCtaCble();
                CagarCombosMoneda();
                CargarVia();
                CargarTerminoPago();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
        
        public void CargarControles()
        {
            try
            {
                UCPaisOrigen.Dock = DockStyle.Fill;
                UCPaisDestino.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        private void frmImp_ordencompra_ext_Mantenimiento_Load(object sender, EventArgs e)
        {

            try
            {
                DataSourceProducto = new BindingList<imp_ordencompra_ext_det_Info>();
                gridControlProductos.DataSource = DataSourceProducto;
                cmbTipoImportacion.SelectedIndex = 1;
                ultraComboEditorSucursal.EditValue = 1;
                txtLugarEmbarque.Text = "";
                txtNumeroFacturaProvedor.Text = "0";
                txtObservacion.Text = "";
                
                this.Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing += new delegate_frmImp_ordencompra_ext_Mantenimiento_FormClosing(frmImp_ordencompra_ext_Mantenimiento_Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing);
                ListCatalogo = ObusCatalogo.Get_List_catalogo();
                CargarCombos();
                CargarControles();
                load_gridUtgTipoEmbarque();
              
                LaoadGridgastos();
                cmbCategoria.DataSource =listaCategoria;
                cmbProducto.DataSource= BusProducto.Get_list_Producto(param.IdEmpresa);
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ultraComboEditorSucursal.Enabled = false;
                        btnOk.Text = "Actualizar";
                        if (_infoset.Estado == "I")
                        {
                            lbl_Estado.Visible = true;
                            btnAnular.Enabled = false;
                            btnOk.Enabled = false;
                            BtnGuardarYsalir.Enabled = false;
                        }
                        setInfo();
                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:
                        btnOk.Text = "Guardar";
                        btnImprimir.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ultraComboEditorSucursal.Enabled = false;
                        btnOk.Enabled = false;
                        btnAnular.Enabled = false;
                        BtnGuardarYsalir.Enabled = false;
                        if (_infoset.Estado == "I")
                        {
                            lbl_Estado.Visible = true;
                            btnAnular.Enabled = false;
                            btnOk.Enabled = false;
                            BtnGuardarYsalir.Enabled = false;
                        }
                        setInfo();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ultraComboEditorSucursal.Enabled = false;
                        btnOk.Enabled = false;
                        BtnGuardarYsalir.Enabled = false;
                        if (_infoset.Estado == "I")
                        {
                            lbl_Estado.Visible = true;
                            btnAnular.Enabled = false;
                            btnOk.Enabled = false;
                            BtnGuardarYsalir.Enabled = false;
                        }
                        setInfo();
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

        void frmImp_ordencompra_ext_Mantenimiento_Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    
        #region Metodo Set Y Get
        #region GetInfo
        public void Get_Info()
        {
            try
            {
            #region Cabecera
                _Info = new imp_ordencompra_ext_Info();
                _Info.Fecha_Maximo_Despacho = dtpFechaMaxiDeDespacho.Value;
                _Info.ListaDetalleOrdeCompraEx.Clear();
                _Info.CodOrdenCompraExt = (txtCodigo.Text == "") ? "" : txtCodigo.Text.ToString();
                _Info.ci_fecha_llegada = Convert.ToDateTime(dateTimePickerci_fecha_llegada.Value.ToShortDateString());
                _Info.ci_LugarEmbarque = txtLugarEmbarque.Text; 
                _Info.ci_tonelaje = Convert.ToDouble((txtTonelaje.Text == "") ? "0" : txtTonelaje.Text);
                _Info.NumFacturaProvedor = txtNumeroFacturaProvedor.Text;
                _Info.IdSucusal = Convert.ToInt32((ultraComboEditorSucursal.EditValue == null) ? 0 : ultraComboEditorSucursal.EditValue);
                _Info.ci_fechaFirmaContrato = Convert.ToDateTime(dtpFirmaContrato.Value.ToShortDateString());
               
                _Info.Tipo_Importacion = cmbTipoImportacion.Text;

                _Info.IdProveedor = Convert.ToDecimal((gridLookUpEditProveedor.EditValue == null) ? 0 : gridLookUpEditProveedor.EditValue);
                _Info.IdEmbarcador = Convert.ToInt32((ultraComboEditorEmbarcador.EditValue == null) ? 0 : ultraComboEditorEmbarcador.EditValue);
                _Info.IdCtaCble_import = (ultraComboEditorCtaCble.EditValue == null) ? "" : ultraComboEditorCtaCble.EditValue.ToString();
                _Info.ci_Observacion = txtObservacion.Text;
 
                //_Info.IdBanco = Convert.ToDecimal((ultraComboEditorBanco.Value == null) ? 0 : ultraComboEditorBanco.Value);
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdPaisOrgCarga = (ultraComboEditorPaisOrigen.EditValue == null) ? "" : ultraComboEditorPaisOrigen.EditValue.ToString();
                _Info.IdPaisProceCarga = (ultraComboEditorPaisDestino.EditValue == null) ? "" : ultraComboEditorPaisDestino.EditValue.ToString();
                _Info.ci_fecha = Convert.ToDateTime(dtpFechaTransaccion.Value.ToShortDateString());
                _Info.Fecha_Transac = dtpFechaTransaccion.Value;
                _Info.IdCicloImportacion = (ultraComboEditorCiclo.EditValue == null) ? "" : ultraComboEditorCiclo.EditValue.ToString();
                _Info.IdMonedaOrigen = Convert.ToInt32((ultraComboEditorMonedaOrigen.EditValue == null) ? 0 : ultraComboEditorMonedaOrigen.EditValue);
                _Info.IdMonedaCambiaria = Convert.ToInt32((ultraComboEditorMonedaLocal.EditValue == null) ? 0 : ultraComboEditorMonedaLocal.EditValue);
                #endregion
                #region PreEmbarque
                _Info.ci_fecha_aprobacion = dtp_fecha_aprobacion.Value;
                _Info.IdVia = (ultraComboEditorVia.EditValue == null) ? "" : ultraComboEditorVia.EditValue.ToString(); ;
            //    _Info.ci_valor_derecho = Convert.ToDouble(txtValorFacturaProve.Text);
                _Info.ci_fechaFactProv = dtpFechaFactProve.Value;
                _Info.ci_fechVenciFact = dtpFechaVenciFact.Value;
               // _Info.ci_diasFecFacProv = Convert.ToInt32(txtDiasFacPreEmbar.Text);
                _Info.ci_fec_est_llegada = Convert.ToDateTime(dtpFec_est_llegada.Value.ToShortDateString());
               // _Info.IdTerminoPago = (ultraComboEditorFormaPago.Value==null)?"":ultraComboEditorFormaPago.Value.ToString();
                #endregion PreEmbarque
                #region Embarque
                _Info.ci_fechaDespProv = dtpFechaDespProv.Value;
                //_Info.ci_DiasEmbarque = Convert.ToInt32(txtDiasEmbarque.Text);
                _Info.ci_fechaRecEmb = dtpFechaRecEmb.Value;
                _Info.ci_fechaAproxSal = dtpFechaAproxSal.Value;
                _Info.ci_fec_est_llegada = dtpFec_est_llegada.Value;
              //  _Info.ci_dias_estimados = Convert.ToInt32(txtDiasEstimados.Text);
                _Info.ci_fecha_llegada_Bodega = dtp_Fecha_Bodega.Value;
                #endregion Embarque
                #region PosEmbarque
                _Info.ci_fechaRealArri = dtp_FecharealArri.Value;
                _Info.ci_fechaDocAAA = dtp_fehaDocAAA.Value;
                _Info.ci_fecha_liquidacion = dtp_Fecha_liquidacion.Value;
                _Info.ci_fecha_sal_aduana = dtp_Fecha_sal_Aduana.Value;
              //  _Info.ci_diasNaciona = Convert.ToInt32(txtDiasNacionalizacion.Text);
            
                #endregion PosEmbarque
                Get_InfoDatoEmbarque();
                Get_GridProducto();
                //GetGastos();
                _Info.ListaDetalleOrdeCompraEx.ForEach(var => var.IdSucursal = Convert.ToInt32(ultraComboEditorSucursal.EditValue));
              
                int s= 1;
                DataSourceCondicionesPago = new BindingList<imp_ordencompra_ext_x_Condiciones_Pago_Info>();
                gridControlCondicionespago.DataSource = DataSourceCondicionesPago;
                _Info.ListCondicionPago = DataSourceCondicionesPago.ToList();
                _Info.ListCondicionPago.ForEach(c => { c.Secuencia = s; s++; c.IdEmpresa = param.IdEmpresa; c.IdSucursal = Convert.ToInt16(ultraComboEditorSucursal.EditValue); if (string.IsNullOrEmpty(c.Observacion)) c.Observacion = ""; });
                _Info.Buque = txtBuque.Text;
                _Info.Naviera = txtNaviera.Text;
                _Info.ci_costo_Flete_externo = Convert.ToDouble((txtFlete.EditValue == null) ? 0 : txtFlete.EditValue);
                _Info.FOB = Convert.ToDouble((txtFOB.EditValue == null) ? 0 : txtFOB.EditValue) ;
                _Info.CFR = Convert.ToDouble((txtCFR.EditValue == null) ? 0 : txtCFR.EditValue);
           
                _Info.IdOrdenCompraExt = Convert.ToDecimal((txtIdImportacion.Text == "") ? "0" : txtIdImportacion.Text);
                _Info.IdOrdenCompraExt = Convert.ToDecimal((txtIdImportacion.Text == "") ?"0" : txtIdImportacion.Text);
              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
               
            }


        }
        public void Get_InfoDatoEmbarque() 
        {
            try
            {
                //for (int i = 0; i < UtgTipoEmbarque.Rows.Count; i++)
                //{
                //    imp_DatosEmbarque_Info _InfoDatosEmbarque = new imp_DatosEmbarque_Info();
                //    _InfoDatosEmbarque.IdEmpresa = param.IdEmpresa;
                //    _InfoDatosEmbarque.IdSucursal = Convert.ToInt32(ultraComboEditorSucursal.EditValue);
                //    _InfoDatosEmbarque.cp_TipoConten = UtgTipoEmbarque.Rows[i].Cells["Tipo Contenedor"].Value.ToString();
                //    _InfoDatosEmbarque.cp_TipoEmbarque = UtgTipoEmbarque.Rows[i].Cells["Tipo Embarque"].Value.ToString();
                //    _InfoDatosEmbarque.cp_secuencia = i + 1;
                //    _InfoDatosEmbarque.cp_cantidad = (UtgTipoEmbarque.Rows[i].Cells["Cantidad"].Value.ToString() == "") ? 0 : Convert.ToDouble(UtgTipoEmbarque.Rows[i].Cells["Cantidad"].Value);
                //    _InfoDatosEmbarque.cp_Kiligramo = Convert.ToDouble((UtgTipoEmbarque.Rows[i].Cells["Kilogramos"].Value.ToString() == "") ? 0 : UtgTipoEmbarque.Rows[i].Cells["Kilogramos"].Value);
                //    _InfoDatosEmbarque.cp_MCubicos = Convert.ToDouble((UtgTipoEmbarque.Rows[i].Cells["Metros Cubicos"].Value.ToString() == "") ? 0 : UtgTipoEmbarque.Rows[i].Cells["Metros Cubicos"].Value);
                //    _InfoDatosEmbarque.cp_ValorFlete = Convert.ToDouble((UtgTipoEmbarque.Rows[i].Cells["Valor Flete"].Value.ToString() == "") ? 0 : UtgTipoEmbarque.Rows[i].Cells["Valor Flete"].Value);
                //    _Info.ListaDatoEmbarque.Add(_InfoDatosEmbarque);
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }

        
        }
        public  List<imp_ordencompra_ext_det_Info> Get_GridProducto() 
        {
            try
            {
                int i = 1;
                DataSourceProducto.ToList().ForEach(v => { v.IdEmpresa = param.IdEmpresa; v.Secuencia = i++; });
                _Info.ListaDetalleOrdeCompraEx = DataSourceProducto.ToList();
            return  DataSourceProducto.ToList();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<imp_ordencompra_ext_det_Info>();
            }
        }
        #endregion GetInfo
        #region SetInfo
        public void setInfo()
        {
            try
            {

                if (BUS.Get_Info_ordencompra_ext(param.IdEmpresa, _infoset.IdSucusal, _infoset.IdOrdenCompraExt).IdEstadoLiquidacion != "XLQDAR") 
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar || _Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        MessageBox.Show("La Importacion Ya se Encuentra Liquidada No se podra Actualizar Ni Anular");
                        BtnGuardarYsalir.Enabled = false;
                        btnAnular.Enabled = false;
                        btnOk.Enabled = false;
                        lblLiquidado.Visible = true;
                    }
                }

                if (_infoset.Tipo_Importacion == "IMPORTACION")
                {
                    GenDiarioTipImpo = true;

                }
                else
                {
                    GenDiarioTipImpo = false;

                }


               // cmbTipoImportacion.Enabled = false;
                #region Cabecera
                dtpFechaMaxiDeDespacho.Value = Convert.ToDateTime(_infoset.Fecha_Maximo_Despacho);
                cmbTipoImportacion.Text = _infoset.Tipo_Importacion;
                dtpFirmaContrato.Value = Convert.ToDateTime(_infoset.ci_fechaFirmaContrato);
                txtCodigo.Text = _infoset.CodOrdenCompraExt;
                dateTimePickerci_fecha_llegada.Value = _infoset.ci_fecha_llegada;
                txtLugarEmbarque.Text = _infoset.ci_LugarEmbarque;
                txtIdImportacion.Text = _infoset.IdOrdenCompraExt.ToString();
                gridLookUpEditProveedor.EditValue = _infoset.IdProveedor;
                ultraComboEditorEmbarcador.EditValue = _infoset.IdEmbarcador;
                ultraComboEditorCtaCble.EditValue = _infoset.IdCtaCble_import;
                txtObservacion.Text = _infoset.ci_Observacion;
                ultraComboEditorPaisOrigen.EditValue = _infoset.IdPaisOrgCarga;
                ultraComboEditorPaisDestino.EditValue = _infoset.IdPaisProceCarga;
                ultraComboEditorSucursal.EditValue = _infoset.IdSucusal;
                ultraComboEditorMonedaLocal.EditValue = _infoset.IdMonedaCambiaria;
                ultraComboEditorMonedaOrigen.EditValue = _infoset.IdMonedaOrigen;
                //ultraComboEditorBanco.Value = _infoset.IdBanco;
                txtNumeroFacturaProvedor.Text = _infoset.NumFacturaProvedor.ToString();
                txtTonelaje.Text = _infoset.ci_tonelaje.ToString();
                dtpFechaTransaccion.Value = _infoset.ci_fecha;
                #endregion Cabecera
                ultraComboEditorCiclo.EditValue = _infoset.IdCicloImportacion;
                txtNaviera.Text = _infoset.Naviera;
                txtBuque.Text = _infoset.Buque;
                #region PreEmbarque
                dtp_fecha_aprobacion.Value = _infoset.ci_fecha_aprobacion;
                dtpFec_est_llegada.Value = _infoset.ci_fec_est_llegada;
                ultraComboEditorVia.EditValue = _infoset.IdVia;
                //ultraComboEditorFormaPago.Value = _infoset.IdTerminoPago;
                //txtValorFacturaProve.Text = _infoset.ci_valor_derecho.ToString();
                dtpFechaFactProve.Value = _infoset.ci_fechaFactProv;
              //  txtDiasFacPreEmbar.Text = _infoset.ci_diasFecFacProv.ToString();
                dtpFechaVenciFact.Value = _infoset.ci_fechVenciFact;
                gridLookUpEditProveedor_EditValueChanged(new Object(),new EventArgs());
                #endregion PreEmbarque
                #region Embarque
                dtpFechaDespProv.Value = _infoset.ci_fechaDespProv;
               // txtDiasEmbarque.Text = _infoset.ci_DiasEmbarque.ToString() ;
                dtpFechaRecEmb.Value = _infoset.ci_fechaRecEmb;
                dtpFechaAproxSal.Value = _infoset.ci_fechaAproxSal;
              //  txtDiasEstimados.Text = _infoset.ci_dias_estimados.ToString();
                dtp_Fecha_Bodega.Value = _infoset.ci_fecha_llegada_Bodega;

                #endregion Embarque
                #region Pos-Embarque
                dtp_FecharealArri.Value = _infoset.ci_fechaRealArri;
                dtp_fehaDocAAA.Value = _infoset.ci_fechaDocAAA;
                dtp_Fecha_liquidacion.Value = _infoset.ci_fecha_liquidacion;
                dtp_Fecha_sal_Aduana.Value = _infoset.ci_fecha_sal_aduana;
             //   txtDiasNacionalizacion.Text = _infoset.ci_diasNaciona.ToString();
                #endregion Pos-Embarque
                #region GridProductos

                _infoset.ListaDatoEmbarque = BusDatoEmbarque.Get_List_DatosEmbarque(_infoset);
                _infoset.ListaDetalleOrdeCompraEx = BusOrdenCompraDeta.Get_List_ordencompra_ext_det(_infoset);
                SetDatosGridProductos(_infoset.ListaDetalleOrdeCompraEx);
                set_DatosgridDatosEmbarque(_infoset.ListaDatoEmbarque);
                
                #endregion GridProductos
                imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus BusGasto = new imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus();
                imp_ordencompra_ext_x_Condiciones_Pago_Bus BusCondPago = new imp_ordencompra_ext_x_Condiciones_Pago_Bus();
                _infoset.ListaGastos = BusGasto.Get_List_ordencompra_ext_x_imp_gastosxImport_Det_x_OC(_infoset);

                setDatosGridGastos(_infoset.ListaGastos);
                DataSourceCondicionesPago = new BindingList<imp_ordencompra_ext_x_Condiciones_Pago_Info>(BusCondPago.Get_List_ordencompra_ext_x_Condiciones_Pago(_infoset));
                gridControlCondicionespago.DataSource = DataSourceCondicionesPago;
                gridControlCondicionespago.RefreshDataSource();

                txtCFR.EditValue = Convert.ToDecimal(_infoset.CFR);
                txtFOB.EditValue = Convert.ToDecimal(_infoset.FOB);
                txtFlete.EditValue = Convert.ToDecimal(_infoset.ci_costo_Flete_externo);

                //for (int i = 0; i < ultraGridGastos.Rows.Count(); i++)
                //{
                //    ultraGridGastos.DisplayLayout.Rows[i].Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;    
                //}
          
                Bitmap imgImprimir = global::Core.Erp.Winform.Properties.Resources.imprimir;
                var asd = BUS.Get_List_DiariosxImportacion(param.IdEmpresa, _infoset.IdSucusal, _infoset.IdOrdenCompraExt);
                foreach (var item in asd)
                {
                    item.imp = imgImprimir;
                } 
                gridControlDiarios.DataSource = asd;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }

        }
        
        private void setDatosGridGastos(List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> Lst) 
        {
            try
            {
                foreach (var item in Lst)
                {
                    DataRow Filas;
                    Filas = dtGastos.NewRow();
                    Filas[0] = item.IdGastoImp;
                    Filas[1] = item.Valor;
                    Filas[2] = item.Banco;
                    Filas[3] = item.Proveedor;
                    Filas[4] = item.Fecha;
                    Filas[5] = item.IdRegistroGasto;
                    Filas[7] = item.Observacion;
                    Filas[8] = item.CodDocu_Pago;
                    dtGastos.Rows.Add(Filas);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void SetDatosGridProductos(List<imp_ordencompra_ext_det_Info> Lst)
        {
            try
            {
                DataSourceProducto = new BindingList<imp_ordencompra_ext_det_Info>(Lst);
                gridControlProductos.DataSource = DataSourceProducto;
            }
            #region Catch
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


            #endregion
        }

        private void set_DatosgridDatosEmbarque(List<imp_DatosEmbarque_Info> dats)
        {
            try
            {
                dt.Clear();
                foreach (var item in dats)
                {
                    DataRow filas;
                    filas = dt.NewRow();
                    filas[0] = item.cp_TipoEmbarque;
                    filas[1] = item.cp_cantidad;
                    filas[2] = item.cp_TipoConten;
                    filas[3] = item.cp_Kiligramo;
                    filas[4] = item.cp_MCubicos;
                    filas[5] = item.cp_ValorFlete;
                    dt.Rows.Add(filas);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        #endregion
        #endregion
        
        private void LaoadGridgastos() 
        {

            try
            {
                dtGastos.Columns.Add("Tipo Gasto", typeof(string));
                dtGastos.Columns.Add("Valor", typeof(decimal));

                dtGastos.Columns.Add("Banco", typeof(string));
                dtGastos.Columns.Add("Proveedor", typeof(string));
                dtGastos.Columns.Add("Fecha", typeof(DateTime));
                dtGastos.Columns.Add("# Registro", typeof(decimal));
                dtGastos.Columns.Add("...", typeof(string));
                dtGastos.Columns.Add("Observacion", typeof(string));
                dtGastos.Columns.Add("CodDocu_Pago", typeof(string));

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                dtGastos.AcceptChanges();
                //ultraGridGastos.DataSource = dtGastos;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        private void load_gridUtgTipoEmbarque()
        {
            try
            {
                dt.Columns.Add("Tipo Embarque", typeof(string));
                dt.Columns.Add("Cantidad", typeof(decimal));
                dt.Columns.Add("Tipo Contenedor", typeof(string));
                dt.Columns.Add("Kilogramos", typeof(double));
                dt.Columns.Add("Metros Cubicos", typeof(double));
                dt.Columns.Add("Valor Flete", typeof(double));
                dt.AcceptChanges();
              //  this.UtgTipoEmbarque.DataSource = dt;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
           
        private void creaTablaProveedores(List<cp_proveedor_Info> Lista, ref DataTable tablaNCombo)
        {
            try
            {
                tablaNCombo.Columns.Add("Codigo", typeof(string));
                tablaNCombo.Columns.Add("Descripcion                                                            .", typeof(string));
                tablaNCombo.Columns.Add("IdProveedor", typeof(int));


                foreach (var item in Lista)
                {
                    DataRow filas;
                    filas = tablaNCombo.NewRow();
                    filas[0] = item.pr_codigo;
                    filas[1] = item.pr_nombre;
                    filas[2] = item.IdProveedor;


                    tablaNCombo.Rows.Add(filas);
                    tablaNCombo.AcceptChanges();
                }



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
                dtProd = new DataTable("Producto");
                tablaNCombo.Columns.Add("idProducto", typeof(int));
                tablaNCombo.Columns.Add("Codigo_Producto", typeof(string));
                DataColumn des = new DataColumn("Descripcion", typeof(string));
                des.Caption = "Descripcion                                                             .";
                tablaNCombo.Columns.Add(des);
                
                tablaNCombo.Columns.Add("productInfo", typeof(object));

                foreach (var item in Lista)
                {
                    DataRow filas;
                    filas = tablaNCombo.NewRow();
                    filas[1] = item.pr_codigo;
                    filas[2] = item.pr_descripcion;
                    filas[0] = item.IdProducto;
                    filas[3] = item;

                    tablaNCombo.Rows.Add(filas);
                    tablaNCombo.AcceptChanges();
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

                tabControl1.SelectedIndex = 1;
                gridViewCondicionespago.Focus();
                txtObservacion.Focus();
                tabControl1.SelectedIndex = 0;
                //return;
                
                Get_Info();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        AccionActualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:
                        AccionGuardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;

                }
                gridControlDiarios.DataSource = null;
                Bitmap imgImprimir = global::Core.Erp.Winform.Properties.Resources.imprimir;
                var asd = BUS.Get_List_DiariosxImportacion(param.IdEmpresa, Convert.ToInt32(ultraComboEditorSucursal.EditValue), Convert.ToDecimal(txtIdImportacion.Text));
                foreach (var item in asd)
                {
                    item.imp = imgImprimir;
                }
                gridControlDiarios.DataSource = asd;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               
            }
  
        }
        
        public void AccionActualizar() 
        {
            try
            {
                if (Valida())
                {

                    var idproveedor = gridLookUpEditProveedor.EditValue;
                    _Info.IdCtaCble_CXP = ((List<cp_proveedor_Info>)gridLookUpEditProveedor.Properties.DataSource).First(var => var.IdProveedor == Convert.ToDecimal(idproveedor)).IdCtaCble_CXP;

                    _Info.GenDiarioTipImpo = GenDiarioTipImpo;
                    _Info.setFOB = _infoset.FOB;
                 
                    
                    if (BUS.ModificarDB(_Info))
                    {
                        if (_Info.msgReversoCbteCble !=null)
                        {
                            MessageBox.Show(_Info.msgReversoCbteCble,"Sistemas");                        
                        }

                        if ( _Info.msgGenerarDiarioFOB !=null)
                        {                           
                            MessageBox.Show(_Info.msgGenerarDiarioFOB, "Sistemas");
                        }
                      
                      
                        MessageBox.Show("Se ha Actualizado correctamente la Orden # " + _Info.IdOrdenCompraExt);
                    }
                    else
                    {
                        MessageBox.Show("Error Actualizar la Orden # " + _Info.IdOrdenCompraExt);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        
        public void AccionGuardar()
        {
            try
            {
                Get_Info();
                if (BUS.VerificarCodigo(_Info.CodOrdenCompraExt, param.IdEmpresa))
                {
                    decimal IdOrdeExte = 0;
                    if (Valida())
                    {
                        if (BUS.GuardarDB(_Info, ref IdOrdeExte))
                        {
                            if (_Info.ci_tonelaje==0)
                            {
                                if (MessageBox.Show("¿Está seguro que desea guardar el Tonelaje en 0 ", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {}
                                else
                                { return; }                                                       
                            }
                            
                            if (GenDiarioTipImpo == true)
                            {
                                string msg = "";
                                decimal idCbteCble = 0;
                                if (BUS.GenerarDiarioFOB(param.IdEmpresa, _Info.IdSucusal, IdOrdeExte, ref msg, ref idCbteCble, InfoProveedor.IdCtaCble_CXP) == false)
                                { 
                                    MessageBox.Show(msg); 
                                }
                            }

                            txtIdImportacion.Text = IdOrdeExte.ToString();
                           
                            if (txtCodigo.Text == "")
                            {
                                txtCodigo.Text = "IMP" + IdOrdeExte;
                            }
                            if (MessageBox.Show("Se a guardado correctamente la Importación # " + IdOrdeExte + "\n Desea Imprimir La Importación", "Mensajer ERP", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                toolStripButton3_Click(new Object(), new EventArgs());

                            }
                            BtnGuardarYsalir.Enabled = false;
                            btnOk.Enabled = false;
                            btnImprimir.Enabled = true;
                        }
                        else {
                            MessageBox.Show("Error Al guardar la importación");
                        
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El código ingresado ya existe por favor ingrese uno diferente");

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }

        public void AccionAnular()
        {
            try
            {

                Get_Info();
                if (BUS.AnularDB(_Info))
                {

                    MessageBox.Show("Se anulado exitosamente la orden de compra #" + _Info.IdOrdenCompraExt);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                imp_ordencompra_ext_det_Bus BUSDetalleOrdencompra = new imp_ordencompra_ext_det_Bus();
                List<imp_rpt_ordencompra_ext_Info> log = new List<imp_rpt_ordencompra_ext_Info>();
                imp_rpt_ordencompra_ext_Info InfoRepot = new imp_rpt_ordencompra_ext_Info();
                Get_Info();
                _Info.Sucursal = ultraComboEditorSucursal.EditValue.ToString();//.DisplayText;
                InfoRepot.InfoOrdeCompra = _Info;
                InfoRepot.ListaDetalle = BUSDetalleOrdencompra.Get_List_ordencompra_ext_det(_Info);
                InfoRepot.ListaDetalle = _Info.ListaDetalleOrdeCompraEx;

                (from q in InfoRepot.ListaDetalle select q).ToList().ForEach(var => var.descripcion = BusProducto.Get_Descripcion_Producto(param.IdEmpresa, var.IdProducto));


                InfoRepot.InfoEmpresa = param.InfoEmpresa;



                log.Add(InfoRepot);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        public void CalcularTotales()
        {
            try
            {
                double subtotal = 0;
              

                     foreach (var item in DataSourceProducto)
                        {
                            subtotal += item.di_subtotal;
                        }



                     txtFOB.EditValue = (decimal)subtotal;
          //  txtCFR.Value = (decimal)subtotal;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());              
            }

        }

        #region CalculoFechas


       

        private void dtpFechaFactProve_ValueChanged_1(object sender, EventArgs e)
        {
            
        }
        private void txtDiasFacPreEmbar_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void dtpFechaVenciFact_ValueChanged_1(object sender, EventArgs e)
        {

            try
            {
            

                    if (dtpFechaVenciFact.Value < dtpFechaFactProve.Value)
                    {
                        dtpFechaVenciFact.Value = dtpFechaFactProve.Value;
                    }
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
          
        }


        private void dtpFec_est_llegada_ValueChanged(object sender, EventArgs e)
        {
        }
        private void txtDiasEstimados_TextChanged(object sender, EventArgs e)
        {
        }
        private void dtp_Fecha_Bodega_ValueChanged_1(object sender, EventArgs e)
        {
        }


        private void dtpFechaDespProv_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpFechaRecEmb.Value < dtpFechaDespProv.Value)
                {
                    dtpFechaRecEmb.Value = dtpFechaDespProv.Value;
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtDiasEmbarque_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void dtpFechaRecEmb_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        #endregion CalculoFechas
        
        private void frmImp_ordencompra_ext_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        public Boolean Valida() 
        {
            try
            {
               if(_Info.ci_Observacion==null|| _Info.ci_Observacion=="")
               {
                   MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " obseravición", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   return false;
               }
                if ( _Info.IdSucusal == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if(_Info.IdProveedor == 0)
                {
                    MessageBox.Show("Por Favor seleccione Proveedor");
                    return false;                
                }
              
                
                if (_Info.Naviera == null || _Info.Naviera =="")
                {
                    MessageBox.Show("Por Favor Ingrese Naviera");
                    return false;
                }
             
                if(DataSourceProducto.Count <=0)
                {
                    MessageBox.Show("Por Favor seleccione al menos un producto");
                    return false;                
                }
                int Rows = 0;
                foreach (var item in DataSourceProducto)
                {
                    Rows++;
                    if(Convert.ToInt32(item.di_cantidad)== 0)
                    {
                        MessageBox.Show("Por Favor Ingrese cantidad al/los Producutos");
                        return false;         
                    }
                    
                  

                    if (Convert.ToDouble(item.di_costo) == 0)
                    {
                        if (MessageBox.Show("El pructo " + ((List<in_Producto_Info>)(cmbProducto.DataSource)).First(c=>c.IdProducto == item.IdProducto).pr_descripcion + "No tiene Precio desea Continuar?", "Mensaje ERP", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            return true;
                        }
                        else 
                        {
                            return false;
                        }
                    }
                }
               

                

                foreach (var item in DataSourceCondicionesPago)
                {
                    if (item.IdConfirmacion_Pago == null) 
                    {
                        MessageBox.Show("Por Favor Seleccione Confirmacion de pago");
                        return false;
                    }
                    if (item.Por_Pago == 0 ) 
                    {
                        MessageBox.Show("Por favor ingrese valor pago");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Por Favor Ingrese cantidad al/los Producutos");
                return false;
            }
        }

        private void txtAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Get_Info();
                if (MessageBox.Show("Está Seguro que desea Eliminar la Importación ?", "Anulación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    imp_ordencompra_ext_x_imp_gastosxImport_Bus BusCobte = new imp_ordencompra_ext_x_imp_gastosxImport_Bus();
                    var cbtes = BusCobte.Get_List_ordencompra_ext_x_imp_gastosxImport(param.IdEmpresa, _Info.IdSucusal, _Info.IdOrdenCompraExt).FindAll(var => var.Estado == "A");
                    if (cbtes.Count > 0)
                    {

                        MessageBox.Show("No se puede anular ya que tiene Gastos asigandos");
                        return;
                    }
                    string motiAnulacion = "";
                    FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                    fr.ShowDialog();
                    motiAnulacion = fr.motivoAnulacion;
                    _Info.MotiAnula = motiAnulacion;
                    _Info.GenDiarioTipImpo = GenDiarioTipImpo;
                    
                    if (BUS.AnularDB(_Info))
                    {
                        MessageBox.Show("Se ha eliminado con éxito la Orden Número #: " + _Info.IdOrdenCompraExt);
                                               
                
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
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
     
        private void gridViewCondicionespago_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridViewCondicionespago.SetFocusedRowCellValue(colFecha_Pago, DateTime.Now);
                gridViewCondicionespago.SetFocusedRowCellValue(colValor_Pago, txtCFR.EditValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtTotal_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                
                for (int i = 0; i < gridViewCondicionespago.RowCount; i++)
                {
                    gridViewCondicionespago.RefreshRow(i);
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }

        private void txtFlete_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
                txtCFR.EditValue = Convert.ToDecimal(txtFOB.EditValue) + Convert.ToDecimal(txtFlete.EditValue);//+ txtFOB.Value;/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                txtBaseCalculo.EditValue = txtCFR.EditValue;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewCondicionespago_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                double porcentaje = DataSourceCondicionesPago.ToList().Sum(v => v.Por_Pago);
                if (porcentaje > 100)
                {
                    MessageBox.Show("El porcentaje no puede exceder el %100");
                    var ob =DataSourceCondicionesPago.ToList();
                    ob.RemoveAt(e.RowHandle);
                    double VALOR = 100 - ob.Sum(v=>v.Por_Pago) ;
                    if (VALOR < 0)
                        VALOR = 0;
                    gridViewCondicionespago.SetFocusedValue(VALOR);
                    return;


                }
                if (ban != "A")
                {

                    ban = "A";
                    gridViewCondicionespago.SetFocusedRowCellValue(colValor_Pago, Convert.ToDecimal(txtBaseCalculo.EditValue) * ((Convert.ToDecimal(porcentaje) / 100)));

                }
                ban = "C";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }
     
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                decimal c = Convert.ToDecimal(txtCFR.EditValue); 
                gridViewCondicionespago.SetFocusedRowCellValue(colValor_Pago, c);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void ultraComboEditorProveedores_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoProveedor = (cp_proveedor_Info)gridLookUpEditProveedor.GetSelectedDataRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bandera)
                {
                    bandera = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewCondicionespago_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.ToString() == "46")
                    gridViewCondicionespago.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (BUS.Get_Info_ordencompra_ext(param.IdEmpresa, _infoset.IdSucusal, _infoset.IdOrdenCompraExt).IdEstadoLiquidacion != "XLQDAR")
                    {
                        MessageBox.Show("La Importacion Ya se Encuentra Liquidada No se puede crear Gastos");

                    }
                    else
                    {

                        frmImp_GastosImportacion_Mant ofrm = new frmImp_GastosImportacion_Mant();
                        ofrm.Event_frmImp_RegistroGastosImportacion_Mant_FormClosing += new frmImp_GastosImportacion_Mant.Delegate_frmImp_RegistroGastosImportacion_Mant_FormClosing(ofrm_Event_frmImp_RegistroGastosImportacion_Mant_FormClosing);
                        ofrm.searchLookUpEditImportacion.EditValue = txtIdImportacion.Text;
                        ofrm.SetAccion(Cl_Enumeradores.eTipo_action.grabar);
                        ofrm.MdiParent = this.MdiParent;
                        ofrm.Show();
                    }
                }
                else if (_Accion == Cl_Enumeradores.eTipo_action.consultar || _Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    frmImp_GastosImportacion_Mant ofrm = new frmImp_GastosImportacion_Mant();
                    ofrm.Event_frmImp_RegistroGastosImportacion_Mant_FormClosing += new frmImp_GastosImportacion_Mant.Delegate_frmImp_RegistroGastosImportacion_Mant_FormClosing(ofrm_Event_frmImp_RegistroGastosImportacion_Mant_FormClosing);
                    ofrm.searchLookUpEditImportacion.EditValue = txtIdImportacion.Text;
                    ofrm.SetAccion(Cl_Enumeradores.eTipo_action.consultar);
                    ofrm.MdiParent = this.MdiParent;
                    ofrm.Show();
                }
                else
                {
                    MessageBox.Show("Para Poder Agregar Gastos primero deber guardar la la importacion", "Sistema ERP");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ofrm_Event_frmImp_RegistroGastosImportacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus BusGasto = new imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus();
                imp_ordencompra_ext_x_Condiciones_Pago_Bus BusCondPago = new imp_ordencompra_ext_x_Condiciones_Pago_Bus();
                Get_Info();
                _infoset.ListaGastos = BusGasto.Get_List_ordencompra_ext_x_imp_gastosxImport_Det_x_OC(_Info);
               // ultraGridGastos.DataSource = null;
                dtGastos.Clear();
                setDatosGridGastos(_infoset.ListaGastos);
                gridControlDiarios.DataSource = null;
                Bitmap imgImprimir = global::Core.Erp.Winform.Properties.Resources.imprimir;
                var asd = BUS.Get_List_DiariosxImportacion(param.IdEmpresa, Convert.ToInt32(ultraComboEditorSucursal.EditValue), Convert.ToDecimal(txtIdImportacion.Text));
                foreach (var item in asd)
                {
                    item.imp = imgImprimir;
                }
                gridControlDiarios.DataSource = asd;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtDiasEmbarque_ValueChanged(object sender, EventArgs e)
        {
            
            
        }
   
        private void ultraComboEditorCiclo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (ultraComboEditorCiclo.EditValue == null)
                {
                    ultraComboEditorCiclo.EditValue = null;
                    ultraComboEditorCiclo.EditValue = 0;
                        
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridLookUpEditProveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoProveedor = (cp_proveedor_Info)searchLookUpEdit1View.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraComboEditorCtaCble_ValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraComboEditorSucursal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (ultraComboEditorSucursal.EditValue == null)
                {
                    ultraComboEditorSucursal.EditValue = null;
                    ultraComboEditorSucursal.EditValue = 0;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraComboEditorEmbarcador_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (ultraComboEditorEmbarcador.EditValue == null)
                {
                    ultraComboEditorEmbarcador.EditValue = null;
                    ultraComboEditorEmbarcador.EditValue = 0;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucmb_productos_Validating(object sender, CancelEventArgs e)
        {
            
        }
        
        private void BtnGuardarYsalir_Click(object sender, EventArgs e)
        {
            try
            {
                Get_Info();
                if(Valida())
                {
                    toolStripButton1_Click(sender, e);
                    Close();
                }    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        private void ultraComboEditorEmbarcador_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ultraComboEditorVia_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (ultraComboEditorVia.EditValue == null)
                {
                    ultraComboEditorVia.EditValue = null;
                    ultraComboEditorVia.EditValue = 0;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UtgTipoEmbarque_BeforeCellDeactivate(object sender, CancelEventArgs e)
        {
            try
            {
                
                


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtDiasFacPreEmbar_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void repositoryItemPictureEdit2_MouseDown(object sender, MouseEventArgs e)
        {

            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewDiario_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.HitInfo.Column.Caption == "gridColumn1")
                {
                
                    

                
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbTipoImportacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoImportacion.Text == "IMPORTACION")
                {
                    GenDiarioTipImpo = true;

                }
                else 
                {
                    GenDiarioTipImpo = false;
                
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewProductos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void gridViewProductos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            try
            {
                foreach (var item in DataSourceProducto)
                {
                    item.di_subtotal = item.di_cantidad * item.di_costo;

                    item.IdCategoria = ((List<in_Producto_Info>)(cmbProducto.DataSource)).First(c => c.IdProducto == item.IdProducto).IdCategoria;
                }

                gridControlProductos.RefreshDataSource();
                txtFlete_ValueChanged(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());             
            }
        }

        private void gridViewProductos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 46) 
                {
                    if(MessageBox.Show("Esta seguro que desea eliminar el item","Sistemas",MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
                    gridViewProductos.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }

        private void txtTonelaje_ValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraComboEditorSucursal_Validating_1(object sender, CancelEventArgs e)
        {
            try
            {
                if (ultraComboEditorSucursal.EditValue == null)
                {
                    ultraComboEditorSucursal.EditValue = null;
                    ultraComboEditorSucursal.EditValue = 0;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraComboEditorCtaCble_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (ultraComboEditorCiclo.EditValue == null)
                {
                    ultraComboEditorCiclo.EditValue = null;
                    ultraComboEditorCiclo.EditValue = 0;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraComboEditorVia_Validating_1(object sender, CancelEventArgs e)
        {
            try
            {
                if (ultraComboEditorVia.EditValue == null)
                {
                    ultraComboEditorVia.EditValue = null;
                    ultraComboEditorVia.EditValue = 0;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraComboEditorEmbarcador_Validating_1(object sender, CancelEventArgs e)
        {
            try
            {
                if (ultraComboEditorEmbarcador.EditValue == null)
                {
                    ultraComboEditorEmbarcador.EditValue = null;
                    ultraComboEditorEmbarcador.EditValue = 0;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtFlete_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
                txtCFR.EditValue = Convert.ToDecimal(txtFOB.EditValue) + Convert.ToDecimal(txtFlete.EditValue);//+ txtFOB.Value;/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                txtBaseCalculo.EditValue = txtCFR.EditValue;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFOB_EditValueChanged(object sender, EventArgs e)
        {

        }
        
    }
}
