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
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Reportes.ActivoFijo;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_ActivoFijo_Mant : DevExpress.XtraEditors.XtraForm
    {
        #region 'Declaracion de Variables Generales'
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;
        
        #endregion

        #region Declaración de Variables
        string codActivoFijo = "";
        string msg = "";
        int id = 0;
        string MensajeError = "";
        #endregion

        #region 'Declaracion delegados'
        public delegate void delegate_frmAF_ActivoFijo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmAF_ActivoFijo_Mant_FormClosing event_frmAF_ActivoFijo_Mant_FormClosing;
        #endregion

        #region Declaración de Info y Listas


        Af_Activo_fijo_CtasCbles_Bus BusCtas_x_AF = new Af_Activo_fijo_CtasCbles_Bus();
        BindingList<Af_Activo_fijo_CtasCbles_Info> BindingListCtas_x_AF = new BindingList<Af_Activo_fijo_CtasCbles_Info>();


        List<tb_Sucursal_Info> lista_sucursal = new List<tb_Sucursal_Info>();

        Af_Activo_fijo_Info Info_AF = new Af_Activo_fijo_Info();
        Af_Activo_fijo_Bus Bus_AF = new Af_Activo_fijo_Bus();

        ct_punto_cargo_Info info_Punto_cargo = new ct_punto_cargo_Info();
        ct_punto_cargo_Bus bus_Punto_cargo = new ct_punto_cargo_Bus();

        List<Af_Activo_fijo_tipo_Info> lista_tipo_activo_fijo = new List<Af_Activo_fijo_tipo_Info>();

        List<ct_Plancta_Info> List_PLanCta = new List<ct_Plancta_Info>();
        List<Af_Departamento_Info> List_dpto = new List<Af_Departamento_Info>();
        List<Af_Tipo_Depreciacion_Info> lista_depre = new List<Af_Tipo_Depreciacion_Info>();
        List<Af_PeriodoDepreciacion_Info> lista_periodo = new List<Af_PeriodoDepreciacion_Info>();

        cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();
        List<cp_proveedor_Info> List_Proveedor = new List<cp_proveedor_Info>();

        List<in_UnidadMedida_Info> Lista_UnidadMedida = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Bus bus_UnidadMedida = new in_UnidadMedida_Bus();

        List<Af_Activo_fijo_Info> lista_activo_Fijo = new List<Af_Activo_fijo_Info>();

        ro_Empleado_Bus BusEmple = new ro_Empleado_Bus();
        List<ro_Empleado_Info> Lista_Empleado = new List<ro_Empleado_Info>();

        Af_Catalogo_Bus BusCata = new Af_Catalogo_Bus();
        List<Af_Catalogo_Info> List_Catalogo = new List<Af_Catalogo_Info>();
        List<Af_Activo_fijo_Categoria_Info> List_Activo_Fijo_Categoria = new List<Af_Activo_fijo_Categoria_Info>();
        Af_Activo_fijo_Categoria_Bus BusCategoria = new Af_Activo_fijo_Categoria_Bus();

        vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info infoFactura_SinCruce = new vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info();

        List<vwAf_CambioUbicacion_Info> lstVwcambioubi_info = new List<vwAf_CambioUbicacion_Info>();
        Af_CambioUbicacion_Activo_Bus busCambio = new Af_CambioUbicacion_Activo_Bus();

        ct_centro_costo_sub_centro_costo_Info info_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Info();
        ct_centro_costo_sub_centro_costo_Bus bus_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Bus();

        BindingList<Af_Activo_fijo_x_Af_Activo_fijo_Info> Lista_activos_relacionados = new BindingList<Af_Activo_fijo_x_Af_Activo_fijo_Info>();
        Af_Activo_fijo_x_Af_Activo_fijo_Bus Activos_Relacionado_bus = new Af_Activo_fijo_x_Af_Activo_fijo_Bus();
        Af_Activo_fijo_Info Activo_Fijo_Seleccionado_info = new Af_Activo_fijo_Info();

        #endregion

        public frmAF_ActivoFijo_Mant()
        {
            try
            {
                InitializeComponent();
                event_frmAF_ActivoFijo_Mant_FormClosing +=frmAF_ActivoFijo_Mant_event_frmAF_ActivoFijo_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmAF_ActivoFijo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmAF_ActivoFijo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void frmAF_ActivoFijo_Mant_event_frmAF_ActivoFijo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #region Get y Set

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_Accion_Controls()
        {
            try
            {

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        
                        this.chk_estado.Checked = true;
                        dtFechaCompra.Enabled = true;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.cmbProveedor.Enabled = true;
                        ucGe_Sucursal_combo1.Enabled = true;
                        
                        //if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
                        //{
                        //    ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(false);
                        //}
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Sucursal_combo1.Enabled = false;
                        ucaF_Activo_fijo_Tipo_cmb.Enabled = true;
                        //cmbCategoriaAF.Properties.ReadOnly = true;
                        cmbProveedor.Enabled = false;
                        dtFechaCompra.Enabled = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.lbl_title_id.Visible = true;
                        this.lbl_id_activo.Visible = true;
                        this.chk_estado.Enabled = true;
                        //if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
                        //{
                        //    ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
                        //}
                        set_ActivoFijo_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        this.lbl_title_id.Visible = true;
                        this.lbl_id_activo.Visible = true;
                        this.txt_nombre.Enabled = false;
                        this.txt_codigo_activofijo.Enabled = false;
                        this.cmbColor.Enabled = false;
                        this.cmbModelo.Enabled = false;
                        this.txt_num_serie.Enabled = false;
                        this.cmbMarca.Enabled = false;
                        this.cmbUbicacion.Enabled = false;
                        this.ucGe_Sucursal_combo1.Enabled = false;
                        //if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
                        //{
                        //    ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
                        //}
                        this.ucaF_Activo_fijo_Tipo_cmb.Enabled = false;
                        //this.cmbCategoriaAF.Enabled = false;
                        this.cmb_TipoDepreciacion.Enabled = false;
                        this.txt_DescCorta.Enabled = false;

                        this.dtFechaCompra.Enabled = false;
                        this.dtFecha_ini_depreciacion.Enabled = false;
                        this.dtFecha_fin_depreciacion.Enabled = false;
                        this.txt_costo_historico.Enabled = false;
                        this.txt_costo_compra.Enabled = false;
                        this.txt_vida_util.Enabled = false;
                        this.txt_meses_depreciar.Enabled = false;
                        this.txt_porc_depreciacion.Enabled = false;
                        this.txt_observacion.Enabled = false;
                        this.txt_observacion.Enabled = false;
                        this.txt_num_placa.Enabled = false;
                        this.txt_anio_fabrica.Enabled = false;


                        this.chk_estado.Enabled = false;
                        set_ActivoFijo_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        this.lbl_title_id.Visible = true;
                        this.lbl_id_activo.Visible = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        //if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
                        //{
                        //    ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
                        //}
                        set_ActivoFijo_in_controls();
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_ActivoFijo(Af_Activo_fijo_Info obj)
        {
            try
            {
                Info_AF = obj;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_ActivoFijo_in_controls()
        {
            try
            {

                CargarGridUbicacion(param.IdEmpresa, Info_AF.IdActivoFijo);

                this.lbl_id_activo.Text = Info_AF.IdActivoFijo.ToString();

                this.cmbUbicacion.set_CatalogosInfo(Info_AF.IdTipoCatalogo_Ubicacion);
                ucAf_Departamento.Inicializar_cmb_departamento();
                ucAf_Departamento.set_Info(Convert.ToInt16(Info_AF.IdDepartamento));

                this.txt_codigo_activofijo.Text = Info_AF.CodActivoFijo;
                this.txt_nombre.Text = Info_AF.Af_Nombre;
                this.cmbMarca.set_CatalogosInfo(Info_AF.IdCatalogo_Marca);
                this.cmbModelo.set_CatalogosInfo(Info_AF.IdCatalogo_Modelo);
                this.txt_num_serie.EditValue = Info_AF.Af_NumSerie;
                this.cmbColor.set_CatalogosInfo(Info_AF.IdCatalogo_Color);
                ucGe_Sucursal_combo1.set_SucursalInfo(Info_AF.IdSucursal);
                this.ucaF_Activo_fijo_Tipo_cmb.set_Info(Info_AF.IdActijoFijoTipo);
                ucaF_Activo_Categoria_cmb.set_info(Info_AF.IdCategoriaAF == null ? 0 : (int)Info_AF.IdCategoriaAF);
                this.dtFechaCompra.Value = Info_AF.Af_fecha_compra;
                this.dtFecha_ini_depreciacion.Value = Info_AF.Af_fecha_ini_depre;
                this.dtFecha_fin_depreciacion.Value = Info_AF.Af_fecha_fin_depre;
                this.txt_costo_historico.Text = Info_AF.Af_Costo_historico.ToString();
                this.txt_costo_compra.Text = Info_AF.Af_costo_compra.ToString();
                this.txt_vida_util.Text = Info_AF.Af_Vida_Util.ToString();
                this.txt_meses_depreciar.Text = Info_AF.Af_Meses_depreciar.ToString();
                this.txt_porc_depreciacion.Text = Info_AF.Af_porcentaje_deprec.ToString();
                this.txt_observacion.Text = Info_AF.Af_observacion;
                this.txt_num_placa.Text = Info_AF.Af_NumPlaca;
                this.txt_anio_fabrica.Text = Info_AF.Af_Anio_fabrica.ToString();
                this.chk_estado.Checked = (Info_AF.Estado == "A") ? true : false;
                lblEstado.Visible = (Info_AF.Estado == "I") ? true : false;
                this.cmb_TipoDepreciacion.EditValue = Info_AF.IdTipoDepreciacion;
                if (Info_AF.Af_foto != null) { picFoto.Image = Funciones.ArrayAImage(Info_AF.Af_foto); }
                this.txt_DescCorta.Text = Info_AF.Af_DescripcionCorta;
                this.cmbPeriodo.EditValue = Info_AF.IdPeriodoDeprec;
                this.txtParte.Text = Convert.ToString(Info_AF.Af_Codigo_Parte);
                this.txtBarra.Text = Info_AF.Af_Codigo_Barra;

                txtDescripTecnica.EditValue = Info_AF.Af_DescripcionTecnica;
                cmbProveedor.set_ProveedorInfo(Info_AF.IdProveedor == null ? 0 : (int)Info_AF.IdProveedor);
                dtpFecPoliza.Value = Info_AF.Af_FechaPoliza == null ? DateTime.Now : Convert.ToDateTime(Info_AF.Af_FechaPoliza);
                txtValorPoliza.EditValue = Info_AF.Af_ValorPoliza;
                txtValorVenta.EditValue = Info_AF.Af_ValorVenta;
                txtPoliza.EditValue = Info_AF.Af_NumPoliza;
                dtpFecVenta.Value = Info_AF.Af_Fecha_Venta == null ? DateTime.Now : Convert.ToDateTime(Info_AF.Af_Fecha_Venta);
                dtpFecVencimiento.Value = Info_AF.Af_Fecha_Vencimiento == null ? DateTime.Now : Convert.ToDateTime(Info_AF.Af_Fecha_Vencimiento);
                dtpFecRetiro.Value = Info_AF.Af_Fecha_Retiro == null ? DateTime.Now : Convert.ToDateTime(Info_AF.Af_Fecha_Retiro);

                txtValorSalvamento.EditValue = Info_AF.Af_ValorSalvamento;
                txtValorResidual.EditValue = Info_AF.Af_ValorResidual;

                lblIdEmpresaOC.Text = Convert.ToString(Info_AF.IdEmpresa_oc);
                lblIdProducto.Text = Convert.ToString(Info_AF.IdProducto);
                lblIdEmpresa_Ogiro.Text = Convert.ToString(Info_AF.IdEmpresa_Ogiro);
                txtNumDocOC.EditValue = Info_AF.numDocumento;
                txtCantidadOC.EditValue = Info_AF.Cantidad;
                txtCostoOC.EditValue = Info_AF.Costo_uni;
                txtSubtotalOC.EditValue = Info_AF.SubTotal;
                txtIvaOC.EditValue = Info_AF.valor_Iva;
                txtTotalOC.EditValue = Info_AF.Total;
                txtIdOC.EditValue = Info_AF.IdOrdenCompra;
                cmbSucursalOC.set_SucursalInfo(Info_AF.IdSucursal_oc == null ? 0 : (int)Info_AF.IdSucursal_oc);
                txtSecuenciaOC.EditValue = Info_AF.Secuencia_oc;
                txtIdOrdenGiro.EditValue = Info_AF.IdCbteCble_Ogiro;
                txtIdTipoOG.EditValue = Info_AF.IdTipoCbte_Ogiro;
                txtTipoOG.EditValue = Info_AF.IdOrden_giro_Tipo;

                txtSerieChasis.EditValue = Info_AF.Af_NumSerie_Chasis;
                txtSerieMotor.EditValue = Info_AF.Af_NumSerie_Motor;
                
                ucAf_Encargado.set_Info(Info_AF.IdEncargado == null ? 0 : (int)Info_AF.IdEncargado);

                BindingListCtas_x_AF = new BindingList<Af_Activo_fijo_CtasCbles_Info>(BusCtas_x_AF.Get_List_Activo_fijo_CtasCbles(Info_AF.IdEmpresa, Info_AF.IdActivoFijo));
                gridControlCtasCbles.DataSource = BindingListCtas_x_AF;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }

        public Af_Activo_fijo_Info get_ActivoFijo()
        {
            try
            {
                
               
                Info_AF = new Af_Activo_fijo_Info();
                Info_AF.IdEmpresa = param.IdEmpresa;
                Info_AF.IdActivoFijo = (this.lbl_id_activo.Text != "") ? Convert.ToInt32(this.lbl_id_activo.Text) : 0;
                Info_AF.CodActivoFijo = (this.txt_codigo_activofijo.Text == "") ? codActivoFijo : txt_codigo_activofijo.Text;
                Info_AF.Af_Nombre = this.txt_nombre.Text;
                Info_AF.IdCatalogo_Marca = cmbMarca.get_CatalogosInfo().IdCatalogo;
                Info_AF.IdCatalogo_Modelo = cmbModelo.get_CatalogosInfo().IdCatalogo;
                Info_AF.Af_NumSerie = Convert.ToString(txt_num_serie.EditValue);
                Info_AF.IdCatalogo_Color = cmbColor.get_CatalogosInfo().IdCatalogo;

                Info_AF.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                Info_AF.IdActijoFijoTipo = Convert.ToInt32(this.ucaF_Activo_fijo_Tipo_cmb.get_Info().IdActivoFijoTipo);

                if (ucaF_Activo_Categoria_cmb.get_info() != null) 
                    Info_AF.IdCategoriaAF = ucaF_Activo_Categoria_cmb.get_info().IdCategoriaAF;

                Info_AF.Af_fecha_compra = this.dtFechaCompra.Value;
                Info_AF.Af_fecha_ini_depre = this.dtFecha_ini_depreciacion.Value;
                Info_AF.Af_fecha_fin_depre = this.dtFecha_fin_depreciacion.Value;
                Info_AF.Af_Costo_historico = (this.txt_costo_historico.Text != "") ? Convert.ToDouble(this.txt_costo_historico.Text) : 0;
                Info_AF.Af_costo_compra = (this.txt_costo_compra.Text != "") ? Convert.ToDouble(this.txt_costo_compra.Text) : 0;
                Info_AF.Af_Vida_Util = (this.txt_vida_util.Text != "") ? Convert.ToInt32(this.txt_vida_util.Text) : 0;
                Info_AF.Af_Meses_depreciar = (this.txt_meses_depreciar.Text != "") ? Convert.ToInt32(this.txt_meses_depreciar.Text) : 0;
                Info_AF.Af_porcentaje_deprec = (this.txt_porc_depreciacion.Text != "") ? Convert.ToDouble(this.txt_porc_depreciacion.Text) : 0;
                Info_AF.Af_observacion = (this.txt_observacion.Text != "") ? this.txt_observacion.Text : " ";
                Info_AF.Af_NumPlaca = (this.txt_num_placa.Text != "") ? this.txt_num_placa.Text : " ";
                Info_AF.Af_Anio_fabrica = (this.txt_anio_fabrica.Text != "") ? Convert.ToInt32(this.txt_anio_fabrica.Text) : 0;
                Info_AF.Estado = (chk_estado.Checked) ? "A" : "I";
                Info_AF.IdEmpresa = param.IdEmpresa;
                Info_AF.IdUsuario = param.IdUsuario;
                Info_AF.Fecha_Transac = DateTime.Now;

                Info_AF.nom_pc = param.nom_pc;
                Info_AF.ip = param.ip;
                Info_AF.IdTipoDepreciacion = Convert.ToInt32(this.cmb_TipoDepreciacion.EditValue);

                if (picFoto.Image != null) { Info_AF.Af_foto = Funciones.ImageAArray(picFoto.Image); } else Info_AF.Af_foto = null;
                Info_AF.Af_DescripcionCorta = this.txt_DescCorta.Text;
                Info_AF.IdPeriodoDeprec = Convert.ToString(this.cmbPeriodo.EditValue);
                Info_AF.Af_Codigo_Parte = (this.txtParte.Text == "" || this.txtParte.Text == null) ? "" : Convert.ToString(this.txtParte.Text);
                Info_AF.Af_Codigo_Barra = this.txtBarra.Text;

                Info_AF.Af_DescripcionTecnica = txtDescripTecnica.EditValue.ToString();

                if (cmbProveedor.get_ProveedorInfo()==null)
                {
                    Info_AF.IdProveedor = null;
                }
                else
                {
                    Info_AF.IdProveedor = cmbProveedor.get_ProveedorInfo().IdProveedor;
                }


                

                Info_AF.Af_FechaPoliza = dtpFecPoliza.Value;
                Info_AF.Af_ValorPoliza = (txtValorPoliza.EditValue == "" || txtValorPoliza.EditValue == null) ? 0 : Convert.ToDouble(txtValorPoliza.EditValue);
                Info_AF.Af_ValorVenta = (txtValorVenta.EditValue == "" || txtValorVenta.EditValue == null) ? 0 : Convert.ToDouble(txtValorVenta.EditValue);
                Info_AF.Af_NumPoliza = (txtPoliza.EditValue == "" || txtPoliza.EditValue == null) ? "" : txtPoliza.EditValue.ToString();
                Info_AF.Af_Fecha_Venta = dtpFecVenta.Value;
                Info_AF.Af_Fecha_Vencimiento = dtpFecVencimiento.Value;
                Info_AF.Af_Fecha_Retiro = dtpFecRetiro.Value;
                Info_AF.Estado_Proceso = Cl_Enumeradores.eEstadoActivoFijo.TIP_ESTADO_AF_ACTIVO.ToString();
                Info_AF.Af_ValorSalvamento = (txtValorSalvamento.EditValue == "" || txtValorSalvamento.EditValue == null) ? 0 : Convert.ToDouble(txtValorSalvamento.EditValue);
                Info_AF.Af_ValorResidual = (txtValorResidual.EditValue == "" || txtValorResidual.EditValue == null) ? 0 : Convert.ToDouble(txtValorResidual.EditValue);

                Info_AF.IdEmpresa_oc = (lblIdEmpresaOC.Text == "" || lblIdEmpresaOC.Text == null) ? 0 : Convert.ToInt32(lblIdEmpresaOC.Text);
                Info_AF.IdProducto = (lblIdProducto.Text == "" || lblIdProducto.Text == null) ? 0 : Convert.ToDecimal(lblIdProducto.Text);
                Info_AF.IdEmpresa_Ogiro = (lblIdEmpresa_Ogiro.Text == "" || lblIdEmpresa_Ogiro.Text == null) ? 0 : Convert.ToInt32(lblIdEmpresa_Ogiro.Text);
                Info_AF.numDocumento = Convert.ToString(txtNumDocOC.EditValue);
                Info_AF.Cantidad = (txtCantidadOC.EditValue == "" || txtCantidadOC.EditValue == null) ? 0 : Convert.ToDouble(txtCantidadOC.EditValue);
                Info_AF.Costo_uni = (txtCostoOC.EditValue == "" || txtCostoOC.EditValue == null) ? 0 : Convert.ToDouble(txtCostoOC.EditValue);
                Info_AF.SubTotal = (txtSubtotalOC.EditValue == "" || txtSubtotalOC.EditValue == null) ? 0 : Convert.ToDouble(txtSubtotalOC.EditValue);
                Info_AF.valor_Iva = (txtIvaOC.EditValue == "" || txtIvaOC.EditValue == null) ? 0 : Convert.ToDouble(txtIvaOC.EditValue);
                Info_AF.Total = (txtTotalOC.EditValue == "" || txtTotalOC.EditValue == null) ? 0 : Convert.ToDouble(txtTotalOC.EditValue);
                Info_AF.IdOrdenCompra = (txtIdOC.EditValue == "" || txtIdOC.EditValue == null) ? 0 : Convert.ToDecimal(txtIdOC.EditValue);
                Info_AF.Secuencia_oc = (txtSecuenciaOC.EditValue == "" || txtSecuenciaOC.EditValue == null) ? 0 : Convert.ToInt32(txtSecuenciaOC.EditValue);
                Info_AF.IdCbteCble_Ogiro = (txtIdOrdenGiro.EditValue == "" || txtIdOrdenGiro.EditValue == null) ? 0 : Convert.ToDecimal(txtIdOrdenGiro.EditValue);
                Info_AF.IdTipoCbte_Ogiro = (txtIdTipoOG.EditValue == "" || txtIdTipoOG.EditValue == null) ? 0 : Convert.ToInt32(txtIdTipoOG.EditValue);
                Info_AF.IdOrden_giro_Tipo = Convert.ToString(txtTipoOG.EditValue);

                

                if (cmbSucursalOC.get_SucursalInfo() == null)
                    Info_AF.IdSucursal_oc = Convert.ToInt32(null);
                else
                    Info_AF.IdSucursal_oc = cmbSucursalOC.get_SucursalInfo().IdSucursal;
                

                Info_AF.Af_NumSerie_Chasis = Convert.ToString(txtSerieChasis.EditValue);
                Info_AF.Af_NumSerie_Motor = Convert.ToString(txtSerieMotor.EditValue);


                if (ucAf_Encargado.get_Info() != null) Info_AF.IdEncargado = ucAf_Encargado.get_Info().IdEncargado;

                Info_AF.IdTipoCatalogo_Ubicacion = cmbUbicacion.get_CatalogosInfo().IdCatalogo;
                if (ucAf_Departamento.get_Info() != null) Info_AF.IdDepartamento = ucAf_Departamento.get_Info().IdDepartamento;


                foreach (var item in BindingListCtas_x_AF)
                {
                    item.IdEmpresa = Info_AF.IdEmpresa;
                    item.IdActivoFijo = Info_AF.IdActivoFijo;
                }

                Info_AF.ListAf_Activo_fijo_CtasCbles = new List<Af_Activo_fijo_CtasCbles_Info>(BindingListCtas_x_AF);

                
                return Info_AF;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Af_Activo_fijo_Info();
            }
        }

        #endregion

        private Boolean Guardar()
        {
            try
            {
                string CodActivo = "";
                Boolean bolResult = false;
                if (Validar())
                {
                    get_ActivoFijo();
                    bolResult = Bus_AF.GrabarDB(Info_AF, ref id, ref CodActivo, ref msg);
                    if (bolResult)
                    {
                        lbl_id_activo.Text = Convert.ToString(id);
                        txt_codigo_activofijo.Text = CodActivo;
                        txtBarra.Text = (txtBarra.Text == "" || txtBarra.Text == null) ? CodActivo : txtBarra.Text;
                        MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean Actualizar()
        {
            try
            {
                Boolean bolResult = false;
                if (Validar())
                {
                    get_ActivoFijo();

                    Info_AF.IdUsuarioUltMod = param.IdUsuario;
                    Info_AF.Fecha_UltMod = DateTime.Now;

                    bolResult = Bus_AF.ModificarDB(Info_AF, ref msg);
                    //bolResult = Crear_Punto_cargo();
                    if (bolResult)
                    {
                        bolResult = true;
                        MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        private Boolean Anular()
        {

            try
            {

                Boolean bolResult = false;
                get_ActivoFijo();


                FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                frm.ShowDialog();
                Info_AF.MotiAnula = frm.motivoAnulacion;
                Info_AF.IdUsuarioUltAnu = param.IdUsuario;
                Info_AF.Fecha_UltAnu = DateTime.Now;
                bolResult = Bus_AF.EliminarDB(Info_AF, ref msg);

                if (bolResult)
                {
                    MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }





                return bolResult;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public Boolean GuardarDatos()
        {
            try
            {
                Boolean respuesta = false;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        respuesta = Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        respuesta = Actualizar();
                        break;
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                Info_AF = new Af_Activo_fijo_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_Accion(_Accion);


                this.lbl_id_activo.Text = "";
                this.txt_codigo_activofijo.Text = "";
                this.txt_nombre.Text = "";
                
                cmbMarca.Inicializar_Catalogos();
                cmbModelo.Inicializar_Catalogos();
                txt_num_serie.EditValue = "";
                cmbColor.Inicializar_Catalogos();
                ucaF_Activo_Categoria_cmb.inicializar_cmb_activofijo_Categoria();
                ucaF_Activo_fijo_Tipo_cmb.Inicializar_cmb_ActivoFijo();
                ucAf_Encargado.Inicializar_Encargado();
                this.txt_costo_historico.Text = "0";
                this.txt_costo_compra.Text = "0";
                this.txt_observacion.Text = "";
                this.txt_num_placa.Text = "";
                this.txt_anio_fabrica.Text = "";
                chk_estado.Checked = true;
                this.txt_DescCorta.Text = "";
                this.txtParte.Text = "";
                this.txtBarra.Text = "";
                txtDescripTecnica.EditValue = "";

                txtValorPoliza.EditValue = "";
                txtValorVenta.EditValue = "";
                txtPoliza.EditValue = "";
                txtValorSalvamento.EditValue = "";
                txtValorResidual.EditValue = "";
                lblIdEmpresaOC.Text = "";
                lblIdProducto.Text = "";
                lblIdEmpresa_Ogiro.Text = "";
                txtNumDocOC.EditValue = "";
                txtCantidadOC.EditValue = "";
                txtCostoOC.EditValue = "";
                txtSubtotalOC.EditValue = "";
                txtIvaOC.EditValue = "";
                txtTotalOC.EditValue = "";
                txtIdOC.EditValue = "";
                txtSecuenciaOC.EditValue = "";
                txtIdOrdenGiro.EditValue = "";
                txtIdTipoOG.EditValue = "";
                txtTipoOG.EditValue = "";

                txtSerieChasis.EditValue = "";
                txtSerieMotor.EditValue = "";

                cmbUbicacion.Inicializar_Catalogos();
                
              
                set_Accion_Controls();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean Validar()
        {
            try
            {
                txt_codigo_activofijo.Focus();


                if (this.txt_nombre.Text == "")
                {
                    MessageBox.Show("Por favor ingrese el nombre del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_nombre.Focus();
                    return false;
                }

                if (this.ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal == null)
                {
                    MessageBox.Show("Por favor escoja la sucursal donde se encuentra el Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.ucGe_Sucursal_combo1.Focus();
                    return false;
                }

                if (ucaF_Activo_fijo_Tipo_cmb.get_Info().IdActivoFijoTipo == null)
                {
                    MessageBox.Show("Por favor escoja el Tipo de Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.ucaF_Activo_fijo_Tipo_cmb.Focus();
                    return false;
                }

                if (ucaF_Activo_Categoria_cmb.get_info().IdCategoriaAF == null)
                {
                    MessageBox.Show("Por favor escoja la Categoria", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.ucaF_Activo_fijo_Tipo_cmb.Focus();
                    return false;
                }

                if (cmb_TipoDepreciacion.EditValue == "" || cmb_TipoDepreciacion.EditValue == null)
                {
                    MessageBox.Show("Por favor escoja el Tipo de Depreciacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.cmb_TipoDepreciacion.Focus();
                    return false;
                }

                if (this.txt_costo_historico.Text == "")
                {
                    MessageBox.Show("Por favor ingrese el costo histórico del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_costo_historico.Focus();
                    return false;
                }

                if (this.txt_costo_compra.Text == "")
                {
                    MessageBox.Show("Por favor ingrese el costo de compra del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_costo_compra.Focus();
                    return false;
                }

                if (this.txt_vida_util.Text == "")
                {
                    MessageBox.Show("Por favor ingrese la vida útil del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_vida_util.Focus();
                    return false;
                }

                if (this.txt_meses_depreciar.Text == "")
                {
                    MessageBox.Show("Por favor ingrese los meses a depreciar el Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_meses_depreciar.Focus();
                    return false;
                }

                if (this.txt_porc_depreciacion.Text == "")
                {
                    MessageBox.Show("Por favor ingrese el % depreciación del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_porc_depreciacion.Focus();
                    return false;
                }

                if (this.txt_observacion.Text == "")
                {
                    MessageBox.Show("Por favor ingrese la observación del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_observacion.Focus();
                    return false;
                }

                if (cmbMarca.get_CatalogosInfo() == null)
                {
                    MessageBox.Show("Por favor ingrese la marca del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.cmbMarca.Focus();
                    return false;
                }

                if (cmbModelo.get_CatalogosInfo() == null)
                {
                    MessageBox.Show("Por favor ingrese el modelo del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.cmbModelo.Focus();
                    return false;
                }

                if (cmbColor.get_CatalogosInfo() == null)
                {
                    MessageBox.Show("Por favor ingrese el color del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.cmbColor.Focus();
                    return false;
                }

                if (txtDescripTecnica.EditValue == null)
                {
                    MessageBox.Show("Por favor ingrese la Descripcion Tecnica", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripTecnica.Focus();
                    return false;
                }

                if (cmbUbicacion.get_CatalogosInfo() == null)
                {
                    MessageBox.Show("Por favor ingrese la ubicación del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.cmbUbicacion.Focus();
                    return false;
                }


                if (this.cmbPeriodo.EditValue==null)
                {
                    MessageBox.Show("Por favor ingrese el periodo para depreciacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.cmbPeriodo.Focus();
                    return false;
                }


                if (this.ucAf_Encargado.get_Info().IdEncargado == 0)
                {
                    MessageBox.Show("Por favor ingrese el encargado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.ucAf_Encargado.Focus();
                    return false;
                }



                var Total_x_ctas = from Cb in BindingListCtas_x_AF
                                   group Cb by new {  Cb.IdTipoCuenta }
                                       into grouping
                                       select new { grouping.Key, totalxCta_ = grouping.Sum(p => p.porc_distribucion) };


                foreach (var item in Total_x_ctas)
                {
                    if (item.totalxCta_ != 100)
                    {
                        MessageBox.Show("El tipo de cuenta:" + item.Key.IdTipoCuenta + " debe ser del 100%", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gridControlCtasCbles.Focus();
                        return false;
                    }
                }


                foreach (var item in BindingListCtas_x_AF)
                {
                    if (string.IsNullOrEmpty(item.IdCtaCble))
                    {
                        MessageBox.Show("falta la cuenta contable para:" + item.IdTipoCuenta , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gridControlCtasCbles.Focus();
                        return false;
                    }
                }
                
               
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void iniciar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.actualizar;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void load_combos()
        {
            try
            {
                ct_Plancta_Bus _PlanCta_bus1 = new ct_Plancta_Bus();
                List<ct_Plancta_Info> _ListPlanCta = new List<ct_Plancta_Info>();
                _ListPlanCta=_PlanCta_bus1.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                cmb_PlanCuenta.DataSource = _ListPlanCta;

                Af_Activo_fijo_CtasCbles_Tipo_Bus BusTipoCta_x_AF = new Af_Activo_fijo_CtasCbles_Tipo_Bus();
                List<Af_Activo_fijo_CtasCbles_Tipo_Info> ListInfoTipoCta_x_AF = new List<Af_Activo_fijo_CtasCbles_Tipo_Info>();
                ListInfoTipoCta_x_AF = BusTipoCta_x_AF.Get_List_Activo_fijo_CtasCbles_Tipo();

                cmbTipoCta.DataSource = ListInfoTipoCta_x_AF;


                cmbMarca.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_MARCA.ToString());
                cmbModelo.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_DISEÑO.ToString());
                cmbColor.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_COLOR.ToString());

                Af_Activo_fijo_tipo_Bus bus_tipo_ActFij = new Af_Activo_fijo_tipo_Bus();
                lista_tipo_activo_fijo = bus_tipo_ActFij.Get_List_ActivoFijoTipo(param.IdEmpresa);
                ucaF_Activo_fijo_Tipo_cmb.cargar();

                string msjError = "";
                List_Activo_Fijo_Categoria = BusCategoria.Get_List_Activo_fijo_Categoria(param.IdEmpresa, ref msjError);

                tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();
                lista_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);

                Af_Tipo_Depreciacion_Bus bus_depre = new Af_Tipo_Depreciacion_Bus();
                lista_depre = bus_depre.Get_List_ActivoFijo(param.IdEmpresa);

                cmb_TipoDepreciacion.Properties.DataSource = lista_depre;

                Af_PeriodoDepreciacion_Bus bus_periodo = new Af_PeriodoDepreciacion_Bus();
                lista_periodo = bus_periodo.Get_List_PeriodoDepreciacion();
                cmbPeriodo.Properties.DataSource = lista_periodo;


                BindingListCtas_x_AF = new BindingList<Af_Activo_fijo_CtasCbles_Info>();

                Af_Activo_fijo_CtasCbles_Info info_tipo_Cta_activo = new Af_Activo_fijo_CtasCbles_Info();
                info_tipo_Cta_activo.IdEmpresa = param.IdEmpresa;
                info_tipo_Cta_activo.IdTipoCuenta = "CTA_ACTIVO";
                info_tipo_Cta_activo.porc_distribucion = 100;
                BindingListCtas_x_AF.Add(info_tipo_Cta_activo);

                Af_Activo_fijo_CtasCbles_Info info_tipo_Cta_depreciacion = new Af_Activo_fijo_CtasCbles_Info();
                info_tipo_Cta_depreciacion.IdEmpresa = param.IdEmpresa;
                info_tipo_Cta_depreciacion.IdTipoCuenta = "CTA_DEPRE_ACUM";
                info_tipo_Cta_depreciacion.porc_distribucion = 100;
                BindingListCtas_x_AF.Add(info_tipo_Cta_depreciacion);

                Af_Activo_fijo_CtasCbles_Info info_tipo_Cta_gasto = new Af_Activo_fijo_CtasCbles_Info();
                info_tipo_Cta_gasto.IdEmpresa = param.IdEmpresa;
                info_tipo_Cta_gasto.IdTipoCuenta = "CTA_GASTOS_DEPRE";
                info_tipo_Cta_gasto.porc_distribucion = 100;
                BindingListCtas_x_AF.Add(info_tipo_Cta_gasto);

                gridControlCtasCbles.DataSource = BindingListCtas_x_AF;

                bool flag = false;


                cmbUbicacion.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_UBICACION.ToString());
                ucAf_Departamento.cargar();
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        
        private void CargarGridUbicacion(int IdEmpresa, int IdActivo)
        {
            try
            {
                lstVwcambioubi_info = busCambio.Get_List_CambioUbicacion(IdEmpresa, IdActivo);
                if (lstVwcambioubi_info.Count() != 0)
                    gridcUbicacionActivo.DataSource = lstVwcambioubi_info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmAF_ActivoFijo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                load_combos();
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }
                ucGe_Sucursal_combo1.set_SucursalInfo(param.IdSucursal);
                set_Accion_Controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XACTF_Rpt009_rpt Reporte = new XACTF_Rpt009_rpt();
                XACTF_Rpt009_Bus busRpt = new XACTF_Rpt009_Bus();
                List<XACTF_Rpt009_Info> infoRpt = new List<XACTF_Rpt009_Info>();

                Reporte.RequestParameters = false;
                infoRpt = busRpt.get_CodigoBarra(param.IdEmpresa, Convert.ToInt32(lbl_id_activo.Text));
                Reporte.infoRpt = infoRpt;

                Reporte.CreateDocument();
                Reporte.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDatos())
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDatos())
                {
                    LimpiarDatos();
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    set_Accion_Controls();
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Info_AF.IdActivoFijo != 0)
                {
                    if (lblEstado.Visible == true)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema);
                    }
                    else
                    {

                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + Info_AF.Af_Nombre + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                            ofrm.ShowDialog();

                            Info_AF.IdUsuarioUltAnu = param.IdUsuario;
                            Info_AF.Fecha_UltAnu = DateTime.Now;
                            Info_AF.MotiAnula = ofrm.motivoAnulacion;

                            if (Info_AF.Estado == "A")
                            {
                                string msg = "";
                                Af_Activo_fijo_Bus bus_act_fij = new Af_Activo_fijo_Bus();
                                if (bus_act_fij.EliminarDB(Info_AF, ref msg))
                                {
                                    lblEstado.Visible = true;
                                    ucGe_Menu.Enabled_bntAnular = false;
                                }
                                MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) + Info_AF.Af_Nombre + param.Get_Mensaje_sys(enum_Mensajes_sys.Debido_q_ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                    }
                }
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucaF_Activo_fijo_Tipo_cmb_event_cmbActivoFijo_Tipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int IdActivoFijo = (ucaF_Activo_fijo_Tipo_cmb.get_Info() == null) ? 0 : ucaF_Activo_fijo_Tipo_cmb.get_Info().IdActivoFijoTipo;
                cargarParametrosTipo_AF();
                ucaF_Activo_Categoria_cmb.cargar(IdActivoFijo);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cargarParametrosTipo_AF()
        {
            try
            {
                int IdActivoTipo = (ucaF_Activo_fijo_Tipo_cmb.get_Info() == null) ? 0 : ucaF_Activo_fijo_Tipo_cmb.get_Info().IdActivoFijoTipo;
                var select = lista_tipo_activo_fijo.Where(q => q.IdActivoFijoTipo == IdActivoTipo).FirstOrDefault();

                tb_Sucursal_Info InfoSucu = ucGe_Sucursal_combo1.get_SucursalInfo();

                if (select != null)
                {

                    codActivoFijo = select.CodActivoFijo + ((InfoSucu == null) ? "" : InfoSucu.codigo);

                    txt_vida_util.EditValue = select.Af_anio_depreciacion;
                    txt_meses_depreciar.EditValue = select.Af_anio_depreciacion * 12;
                    txt_porc_depreciacion.EditValue = select.Af_Porcentaje_depre;

                    dtFecha_fin_depreciacion.Value = dtFecha_ini_depreciacion.Value.AddMonths(Convert.ToInt32(txt_meses_depreciar.EditValue));




                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnFactura_OC_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProveedor.get_ProveedorInfo() != null)
                {
                    frmAF_ActivoFijo_x_OC_x_Factura frm = new frmAF_ActivoFijo_x_OC_x_Factura();

                    infoFactura_SinCruce = new vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info();
                    frm.set_OC_Factura_Activo(param.IdEmpresa, cmbProveedor.get_ProveedorInfo().IdProveedor);
                    frm.ShowDialog();

                    infoFactura_SinCruce = frm.getObtenerDatos();

                    if (infoFactura_SinCruce != null)
                    {
                        if (infoFactura_SinCruce.IdEmpresa != 0)
                        {
                            txt_costo_compra.EditValue = infoFactura_SinCruce.Saldo_Factu;
                            txt_costo_historico.EditValue = 0;
                            dtFechaCompra.Value = infoFactura_SinCruce.Fecha_Ing_Bod;
                            dtFecha_ini_depreciacion.Value = infoFactura_SinCruce.Fecha_Ing_Bod;
                            txt_observacion.Text = infoFactura_SinCruce.dm_observacion;
                            ucGe_Sucursal_combo1.set_SucursalInfo(infoFactura_SinCruce.IdSucursal_oc);
                            txt_nombre.Text = infoFactura_SinCruce.nom_producto;

                            lblIdEmpresaOC.Text = Convert.ToString(infoFactura_SinCruce.IdEmpresa_oc);
                            lblIdProducto.Text = Convert.ToString(infoFactura_SinCruce.IdProducto);
                            lblIdEmpresa_Ogiro.Text = Convert.ToString(infoFactura_SinCruce.IdEmpresa_Ogiro);
                            txtNumDocOC.EditValue = infoFactura_SinCruce.numDocumento;
                            txtCantidadOC.EditValue = infoFactura_SinCruce.Cantidad;
                            txtCostoOC.EditValue = infoFactura_SinCruce.Costo_uni;
                            txtSubtotalOC.EditValue = infoFactura_SinCruce.SubTotal;
                            txtIvaOC.EditValue = infoFactura_SinCruce.valor_Iva;
                            txtTotalOC.EditValue = infoFactura_SinCruce.Total;
                            txtIdOC.EditValue = infoFactura_SinCruce.IdOrdenCompra;
                            cmbSucursalOC.set_SucursalInfo(infoFactura_SinCruce.IdSucursal_oc);
                            txtSecuenciaOC.EditValue = infoFactura_SinCruce.Secuencia_oc;
                            txtIdOrdenGiro.EditValue = infoFactura_SinCruce.IdCbteCble_Ogiro;
                            txtIdTipoOG.EditValue = infoFactura_SinCruce.IdTipoCbte_Ogiro;
                            txtTipoOG.EditValue = infoFactura_SinCruce.IdOrden_giro_Tipo;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_proveedor), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void dtFecha_ini_depreciacion_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtFecha_fin_depreciacion.Value = dtFecha_ini_depreciacion.Value.AddMonths(Convert.ToInt32(txt_meses_depreciar.EditValue));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridControlCtasCbles_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea Eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       gridViewCtasCbles.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
