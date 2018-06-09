using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produccion_Talme;
//using Core.Erp.Business.Produccion;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Reports.Produccion_Talme;
using Core.Erp.Reports.Inventario;
namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_Diaria_Man : Form
    {
        public frmProd_Diaria_Man()
        {
            InitializeComponent();
            Paramestros_I = _Bus_Parametros.ConsultaGeneral(param.IdEmpresa);
        }
        in_producto_x_tb_bodega_Bus _BusPROxBOD = new in_producto_x_tb_bodega_Bus();
        prod_Parametro_Bus _Bus_Parametros = new prod_Parametro_Bus();
        prod_Parametro_Info Paramestros_I = new prod_Parametro_Info();
        prod_Turno_Bus _BusTurno_B = new prod_Turno_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus _Produ_B = new in_producto_Bus();
        prod_TipoParada_CusTalme_Bus _ProducTipoParada_B = new prod_TipoParada_CusTalme_Bus();
        ro_Empleado_Bus _Role_Bus = new ro_Empleado_Bus();
        prod_GestionProductivaLaminado_CusTalme_Bus _Bus = new prod_GestionProductivaLaminado_CusTalme_Bus();
      
        prod_GestionProductivaLaminado_x_paradas_CusTalme_Bus _Detalle_B = new prod_GestionProductivaLaminado_x_paradas_CusTalme_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            _Accion = iAccion;
        }
        private void frmProd_Diaria_Load(object sender, EventArgs e)
        {
            try
            {

                cmbMateriaPrima.Properties.DataSource = _Produ_B.ObtenerMateriaPrima_X_ModeloDeProduccion(param.IdEmpresa,1);
                var ProdTerminados = _Produ_B.ObtenerProductoTerminado_X_ModeloDeProduccion(param.IdEmpresa,1);
                repositoryItemSearchLookUpEdit1.DataSource = _ProducTipoParada_B.ObtenerLista();
                cmbProducto.Properties.DataSource = ProdTerminados;
                cmbProduct2.Properties.DataSource = ProdTerminados;
                txtIdGestioProductiva.EditValue = 0;
                cmbJefeTurno.Properties.DataSource = _Role_Bus.Obtener_Empleado(param.IdEmpresa);
                cmbTurno.Properties.DataSource = _BusTurno_B.ConsultaGeneral(param.IdEmpresa);
                dtpFecha.EditValue = DateTime.Now;
                Event_frmProd_Diaria_FormClosing += new delegate_frmProd_Diaria_FormClosing(frmProd_Diaria_Event_frmProd_Diaria_FormClosing);
                gridControl.Enabled = false;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:
                        btnAnular.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        BtnGuardar.Enabled = false; btnGuardarySalir.Enabled = false;
                        btnAnular.Enabled = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.borrar:
                           BtnGuardar.Enabled = false; btnGuardarySalir.Enabled = false;
                        Set();
                        break;
                    default:
                        break;

                }
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        void frmProd_Diaria_Event_frmProd_Diaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        #region Calculos
        
        

        private void txtCarga_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMateriaPrima.EditValue != null)
                {
                    var Peso = (in_Producto_Info)searchLookUpEdit1View.GetFocusedRow();
                    txtProducto.EditValue = Math.Round((Peso.pr_peso * Convert.ToDouble(txtCarga.EditValue)),2);
                }
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void cmbMateriaPrima_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtCarga_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtUnidadesPro1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.EditValue != null)
                {
                    var Peso = (in_Producto_Info)gridView1.GetFocusedRow();
                    txtValorprod1.EditValue = Math.Round((Peso.pr_peso * Convert.ToDouble(txtUnidadesPro1.EditValue)),2);
                }
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtUnidadesPro2_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct2.EditValue != null)
                {
                    var Peso = (in_Producto_Info)gridView2.GetFocusedRow();
                    txtValorProd2.EditValue = Math.Round((Peso.pr_peso * Convert.ToDouble(txtUnidadesPro2.EditValue)), 2); ;
                }
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void cmbProducto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtUnidadesPro1_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void cmbProduct2_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtUnidadesPro2_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtRetazoPorcentaje_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCarga.EditValue != null)
                {

                    txtRetazoValor.EditValue = Math.Round((Convert.ToDouble(txtRetazoPorcentaje.EditValue) * Convert.ToDouble(txtCarga.EditValue)),2);
                }
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtChatarraPorc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCarga.EditValue != null)
                {

                    txtChatarraValor.EditValue = Math.Round((Convert.ToDouble(txtChatarraPorc.EditValue) * Convert.ToDouble(txtCarga.EditValue)),2);
                }
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtOxidacionPorc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCarga.EditValue != null)
                {

                    txtOxidacionValor.EditValue = Math.Round((Convert.ToDouble(txtOxidacionPorc.EditValue) * Convert.ToDouble(txtCarga.EditValue)),2);
                }
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtHistorico_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtCarga.EditValue != null)
                {
                    txtReal.EditValue = Math.Round((Convert.ToDouble(txtProducto.EditValue) / Convert.ToDouble(txtCarga.EditValue)),2);
                    txtDiferencia.EditValue = (-Convert.ToDouble(txtReal.EditValue) + Convert.ToDouble(txtHistorico.EditValue));
                }
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtCambioReal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtPorcentaje.EditValue = Math.Round(((Convert.ToDouble(txtProgramado.EditValue) / Convert.ToDouble(txtCambioReal.EditValue))) * 100,2);
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtProgramado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtPorcentaje.EditValue = Math.Round(((Convert.ToDouble(txtProgramado.EditValue) / Convert.ToDouble(txtCambioReal.EditValue))) * 100,2);
                if (txtPorcentaje.EditValue.ToString() == "Infinito")
                {
                    txtPorcentaje.EditValue = 0;
                }
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtJornada_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCambioReal.EditValue != null)
                {
                    txtProductiva.EditValue = Math.Round(Convert.ToDouble(txtJornada.EditValue) - Convert.ToDouble(txtCambioReal.EditValue), 2);
                }
                gridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtNeta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNeta.EditValue != null && txtNeta.EditValue != "")
                {
                    txtEficienciaProduccion.EditValue = Math.Round((Convert.ToDouble(txtNeta.EditValue) / Convert.ToDouble(txtProductiva.EditValue) * 100), 2);
                    txtHrsNeta.EditValue =Math.Round( Convert.ToDouble(txtProducto.EditValue) / Convert.ToDouble(txtNeta.EditValue),2);
                }
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void txtTonProgramada_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTonReal.EditValue = Math.Round((Convert.ToDouble(txtProducto.EditValue) / Convert.ToDouble(txtProductiva.EditValue)),2);
                txtEficiencia.EditValue = Math.Round((Convert.ToDouble(txtTonReal.EditValue) / Convert.ToDouble(txtTonProgramada.EditValue)),2);
                if (txtTonReal.EditValue.ToString() == "Infinito") 
                {
                    txtTonReal.EditValue = 0;
                }
                if (txtEficiencia.EditValue.ToString() == "Infinito")
                {
                    txtEficiencia.EditValue = 0;
                }
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        double TotalHrasProduc;
        in_movi_inve_Bus _Movi_B= new in_movi_inve_Bus();
        in_movi_inve_detalle_Bus _MoviDet_B = new in_movi_inve_detalle_Bus();
        in_movi_inve_Info _Movi_I= new Info.Inventario.in_movi_inve_Info();
        List<in_movi_inve_detalle_Info> List_MoviDet_I = new List<in_movi_inve_detalle_Info>();
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                 txtIdGestioProductiva.Focus();
            Get();
           
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        btnAnular.Enabled = true;
                        break;

                }
            
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }
        public void Guardar() 
        {
            try
            {
                string Mensaje = "";
                decimal IdGestion = 0;
                decimal Id = 0;
                if (Validar())
                {  
                    if (_Bus.GuardarDB(_Info, ref IdGestion, ref Mensaje))
                    {
                    txtIdGestioProductiva.EditValue = IdGestion;
                    MessageBox.Show(Mensaje);
                    #region MovimientoInventarioEgreso
                    _Movi_I = new Info.Inventario.in_movi_inve_Info();
                    _Movi_I = new Info.Inventario.in_movi_inve_Info();
                    _Movi_I.IdEmpresa = param.IdEmpresa;
                    _Movi_I.IdSucursal = Paramestros_I.IdSucursal_IngxProduc;
                    _Movi_I.IdBodega = Paramestros_I.IdBodega_IngxProduc;
                    _Movi_I.IdMovi_inven_tipo = Paramestros_I.IdMovi_inven_tipo_x_EgrxProduc_MatPri;
                    _Movi_I.IdUsuario = param.IdUsuario;
                    _Movi_I.cm_fecha = Convert.ToDateTime(Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString());
                    _Movi_I.Fecha_Transac = param.Fecha_Transac;
                    _Movi_I.Fecha_UltMod = param.Fecha_Transac;
                    _Movi_I.IdUsuarioUltModi = param.IdUsuario;
                    _Movi_I.ip = param.ip;
                    _Movi_I.nom_pc = param.nom_pc;
                    _Movi_I.cm_tipo = "-";
                    if (_Movi_B.GrabarDB(_Movi_I, ref Id, ref Mensaje))
                    {
                        var Prod1 = _BusPROxBOD.ObtenerObjeto(param.IdEmpresa, Convert.ToInt32(Paramestros_I.IdSucursal_EgrxMateriaPrima), Convert.ToInt32(Paramestros_I.IdBodega_EgrxMateriaPrima), _Info.IdProducto_MateriaPrima);
                        in_movi_inve_detalle_Info Obj = new in_movi_inve_detalle_Info();

                        Obj.IdEmpresa = param.IdEmpresa;
                        Obj.IdSucursal = Paramestros_I.IdSucursal_IngxProduc;
                        Obj.IdBodega = Paramestros_I.IdBodega_IngxProduc;
                        Obj.IdMovi_inven_tipo = Paramestros_I.IdMovi_inven_tipo_x_EgrxProduc_MatPri;
                        Obj.IdNumMovi = Id;
                        Obj.IdProducto = _Info.IdProducto_MateriaPrima;
                        Obj.Secuencia = 1;
                        Obj.mv_tipo_movi = "-";
                        Obj.dm_cantidad = _Info.kg_Cargados;
                        Obj.dm_observacion = _Movi_I.cm_observacion;
                        Obj.dm_precio = Prod1.pr_precio_publico;
                        Obj.mv_costo = Prod1.pr_costo_promedio;
                        Obj.dm_stock_ante = Prod1.pr_stock;
                        Obj.dm_stock_actu = Prod1.pr_stock - _Info.kg_Cargados;
                        List_MoviDet_I.Add(Obj);
                        if (_MoviDet_B.GrabarDB(List_MoviDet_I, ref Mensaje))
                        {
                            if (_BusPROxBOD.ActualizarStock_x_Bodega_con_moviInven(List_MoviDet_I, ref Mensaje))
                            {
                                in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info Info = new Info.Inventario.in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info();
                                in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus Bus = new Business.Inventario.in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus();
                                Info.prod_IdEmpresa = param.IdEmpresa;
                                Info.mov_IdEmpresa = param.IdEmpresa;
                                Info.mov_IdMovi_inven_tipo = Paramestros_I.IdMovi_inven_tipo_x_EgrxProduc_MatPri;
                                Info.mov_IdSucursal = Convert.ToInt32(Paramestros_I.IdSucursal_EgrxMateriaPrima);
                                Info.mov_IdBodega = Convert.ToInt32(Paramestros_I.IdBodega_EgrxMateriaPrima);
                                Info.mov_IdNumMovi = Id;
                                Info.prod_IdGestionProductiva = IdGestion;
                                Bus.GuardarDB(Info);

                            }
                        }

                    }

                    #endregion

                    #region MovimientoInventarioIngreso
                    _Movi_I = new Info.Inventario.in_movi_inve_Info();
                    _Movi_I.IdEmpresa = param.IdEmpresa;
                    _Movi_I.IdSucursal = Paramestros_I.IdSucursal_IngxProduc;
                    _Movi_I.IdBodega = Paramestros_I.IdBodega_IngxProduc;
                    _Movi_I.IdMovi_inven_tipo = Paramestros_I.IdMovi_inven_tipo_x_IngxProduc_ProdTermi;
                    _Movi_I.IdUsuario = param.IdUsuario;
                    _Movi_I.cm_fecha = Convert.ToDateTime(Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString());
                    _Movi_I.Fecha_Transac = param.Fecha_Transac;
                    _Movi_I.Fecha_UltMod = param.Fecha_Transac;
                    _Movi_I.IdUsuarioUltModi = param.IdUsuario;
                    _Movi_I.ip = param.ip;
                    _Movi_I.nom_pc = param.nom_pc;
                    _Movi_I.cm_tipo = "+";
                    _Movi_I.cm_observacion = "Ingreso A bodega Por La Gestion de Produccion Laminados #" + IdGestion;
                    if (_Movi_B.GrabarDB(_Movi_I, ref Id, ref Mensaje))
                    {


                        var Prod1 = _BusPROxBOD.ObtenerObjeto(param.IdEmpresa, Paramestros_I.IdSucursal_IngxProduc, Paramestros_I.IdBodega_IngxProduc, _Info.IdProducto_Producido1);
                        var Prod2 = _BusPROxBOD.ObtenerObjeto(param.IdEmpresa, Paramestros_I.IdSucursal_IngxProduc, Paramestros_I.IdBodega_IngxProduc, _Info.IdProducto_Producido2);
                        in_movi_inve_detalle_Info Obj = new in_movi_inve_detalle_Info();

                        Obj.IdEmpresa = param.IdEmpresa;
                        Obj.IdSucursal = Paramestros_I.IdSucursal_IngxProduc;
                        Obj.IdBodega = Paramestros_I.IdBodega_IngxProduc;
                        Obj.IdMovi_inven_tipo = Paramestros_I.IdMovi_inven_tipo_x_IngxProduc_ProdTermi;
                        Obj.IdNumMovi = Id;
                        Obj.IdProducto = _Info.IdProducto_Producido1;
                        Obj.Secuencia = 1;
                        Obj.mv_tipo_movi = "+";
                        Obj.dm_cantidad = _Info.unidades_prd_1;
                        Obj.dm_observacion = _Movi_I.cm_observacion;
                        Obj.dm_precio = Prod1.pr_precio_publico;
                        Obj.mv_costo = Prod1.pr_costo_promedio;
                        Obj.dm_stock_ante = Prod1.pr_stock;
                        Obj.dm_stock_actu = Prod1.pr_stock + _Info.unidades_prd_1;
                        List_MoviDet_I.Add(Obj);

                        Obj = new in_movi_inve_detalle_Info();
                        Obj.IdEmpresa = param.IdEmpresa;
                        Obj.IdSucursal = Paramestros_I.IdSucursal_IngxProduc;
                        Obj.IdBodega = Paramestros_I.IdBodega_IngxProduc;
                        Obj.IdMovi_inven_tipo = Paramestros_I.IdMovi_inven_tipo_x_IngxProduc_ProdTermi;
                        Obj.IdNumMovi = Id;
                        Obj.IdProducto = _Info.IdProducto_Producido1;
                        Obj.Secuencia = 2;
                        Obj.mv_tipo_movi = "+";
                        Obj.dm_cantidad = _Info.unidades_prd_2;
                        Obj.dm_observacion = _Movi_I.cm_observacion;
                        Obj.dm_precio = Prod1.pr_precio_publico;
                        Obj.mv_costo = Prod1.pr_costo_promedio;
                        Obj.dm_stock_ante = Prod2.pr_stock;
                        Obj.dm_stock_actu = Prod2.pr_stock + _Info.unidades_prd_2;
                        List_MoviDet_I.Add(Obj);

                        if (_MoviDet_B.GrabarDB(List_MoviDet_I, ref Mensaje))
                        {
                            if (_BusPROxBOD.ActualizarStock_x_Bodega_con_moviInven(List_MoviDet_I, ref Mensaje))
                            {
                                in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info Info = new Info.Inventario.in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info();
                                in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus Bus = new Business.Inventario.in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus();
                                Info.prod_IdEmpresa = param.IdEmpresa;
                                Info.mov_IdEmpresa = param.IdEmpresa;
                                Info.mov_IdMovi_inven_tipo = Paramestros_I.IdMovi_inven_tipo_x_IngxProduc_ProdTermi;
                                Info.mov_IdSucursal = Paramestros_I.IdSucursal_IngxProduc;
                                Info.mov_IdBodega = Paramestros_I.IdBodega_IngxProduc;
                                Info.mov_IdNumMovi = Id;
                                Info.prod_IdGestionProductiva = IdGestion;
                                Bus.GuardarDB(Info);

                            }
                        }

                    }
                    #endregion
                    BtnGuardar.Enabled = false; btnGuardarySalir.Enabled = false;
               

                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    } 
                }
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }
        public void Actualizar()
        {
            try
            {
                string Mensaje = "";
                if (_Bus.ModificarDB(_Info))
                {
                    MessageBox.Show(Mensaje);

                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtParos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtNeta.EditValue = Convert.ToDouble(txtProducto.EditValue) + TotalHrasProduc;
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void gridView_RowCountChanged(object sender, EventArgs e)
        {

            try
            {
                if (gridView.RowCount != 0)
                {
                    txtParos.EditValue = gridView.RowCount-1;
                    Calcular();
                }
                else 
                {
                
                }
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Calcular();
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        void Calcular() 
        {
            try
            {
                List<prod_GestionProductivaLaminado_x_paradas_CusTalme_Info> List = new List<prod_GestionProductivaLaminado_x_paradas_CusTalme_Info>();
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    var asasd = (prod_GestionProductivaLaminado_x_paradas_CusTalme_Info)gridView.GetRow(i);
                    if (asasd != null)
                        List.Add(asasd);
                }
                TimeSpan TotalHoras = new TimeSpan(0, 0, 0);
                double TotalMinutos = 0;
                foreach (var item in List)
                {

                    TotalHoras = item.HoraIni.Subtract(item.HoraFin);
                    TotalMinutos += TotalHoras.Duration().TotalMinutes;
                }
               
                TotalHrasProduc = Math.Round((TotalMinutos / 60), 2);
                txtNeta.EditValue = Convert.ToDouble(txtProducto.EditValue) + TotalHrasProduc;
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void txtTurnoIni_Leave(object sender, EventArgs e)
        {
            try
            {
                txtTurnoIni.Text = txtTurnoIni.Text;
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtTurnoFin_Leave(object sender, EventArgs e)
        {
            try
            {
                txtTurnoFin.Text = txtTurnoFin.Text;
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtKilowatios_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtKwtn.EditValue = Math.Round(Convert.ToDouble(txtKilowatios.EditValue) / Convert.ToDouble(txtProducto.EditValue),2);
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtGalones_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtGlsTon.EditValue = Math.Round(Convert.ToDouble(txtGalones.EditValue) / Convert.ToDouble(txtProducto.EditValue),2);
            }
            catch (Exception ex)
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                    Visor.GuardarVisor(this.ToString(), ex);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        #endregion

        Boolean Validar() 
        {
            try
            {
                if (cmbJefeTurno.EditValue == null) 
                {
                    MessageBox.Show("Seleccione Jefe De turno");
                    return false;
                }
                if (cmbTurno.EditValue == null)
                {
                    MessageBox.Show("Seleccione turno");
                    return false;
                }
                if (cmbMateriaPrima.EditValue == null)
                {
                    MessageBox.Show("Seleccione Materia Prima");
                    return false;
                }
                if (txtCarga.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar (Kg) Carga ");
                    return false;
                }
                if (cmbProducto.EditValue == null)
                {
                    MessageBox.Show("Por favor seleccion Producto Uno");
                    return false;
                }
                if (txtUnidadesPro1.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Unidades Producto Uno ");
                    return false;
                }
                if (cmbProduct2.EditValue == null)
                {
                    MessageBox.Show("Por favor seleccion Producto dos");
                    return false;
                }
                if (txtUnidadesPro2.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Unidades Producto dos");
                    return false;
                }
                if (txtRetazoPorcentaje.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar % Retazo");
                    return false;
                }
                if (txtChatarraPorc.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar % Chatarra");
                    return false;
                }
                if (txtOxidacionPorc.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar % Oxidacion");
                    return false;
                }
                if (txtHistorico.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Historico ");
                    return false;
                }
                if (txtKilowatios.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Kilowatios ");
                    return false;
                }
                if (txtGalones.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Galones ");
                    return false;
                }
                if (txtProgramado.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Programado \" Cambio Y prueba\" ");
                    return false;
                }
                if (txtCambioReal.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Real \" Cambio Y prueba\" ");
                    return false;
                }
                if (txtTurnoIni.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Horario Turno ");
                    return false;
                }
                if (txtTurnoFin.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Horario Turno ");
                    return false;
                }

                if (txtJornada.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Jornada ");
                    return false;
                }

                if (txtTonProgramada.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Programada \" Ton/Hora\" ");
                    return false;
                }
                if (txtTonReal.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Real  \" Ton/Hora\" ");
                    return false;
                }

                if (txtHrsNeta.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingresar Ton Horas Neta \" Ton/Hora\" ");
                    return false;
                }

                foreach (var item in _Info.ListDetalle)
                {
                    if (item.IdTipoParada == null)
                    {
                        MessageBox.Show("Seleccione Tipo Parada ");
                        return false;
                    }
                    if (item.Descripcion == null)
                    {
                        MessageBox.Show("Ingrese Descripcion En el Detalle");
                        return false;
                    }

                    if (item.causa == null) 
                    {
                        MessageBox.Show("Ingrese Causa En el Detalle");
                        return false;
                    }
                                        
                }
                

                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        prod_GestionProductivaLaminado_CusTalme_Info _Info = new prod_GestionProductivaLaminado_CusTalme_Info();
        void Get()
        {
            try
            {
                _Info = new prod_GestionProductivaLaminado_CusTalme_Info();
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdGestionProductiva = Convert.ToDecimal(txtIdGestioProductiva.EditValue);
                _Info.IdProducto_MateriaPrima = Convert.ToDecimal(cmbMateriaPrima.EditValue);
                _Info.IdEmpleado_JefeTurno = Convert.ToDecimal(cmbJefeTurno.EditValue);
                _Info.Id_Bobina = txtIdBobina.Text;
                _Info.kg_Cargados = Convert.ToDouble(txtCarga.EditValue);
                _Info.Num_Orden = txtNOrden.Text;
                _Info.kg_producidos = Convert.ToDouble(txtProducto.EditValue);
                _Info.IdProducto_Producido1 = Convert.ToDecimal(cmbProducto.EditValue);
                _Info.unidades_prd_1 = Convert.ToDouble(txtUnidadesPro1.EditValue);
                _Info.pesokg_prd_1 = Convert.ToDouble(txtValorprod1.EditValue);
                _Info.IdProducto_Producido2 = Convert.ToDecimal(cmbProduct2.EditValue);
                _Info.unidades_prd_2 = Convert.ToDouble(txtUnidadesPro2.EditValue);
                _Info.pesokg_prd_2 = Convert.ToDouble(txtValorProd2.EditValue);
                _Info.kg_retazo_porcen = Convert.ToDouble(txtRetazoPorcentaje.EditValue);
                _Info.kg_retazo_valor = Convert.ToDouble(txtRetazoValor.EditValue);
                _Info.kg_chatarra_porcen = Convert.ToDouble(txtChatarraPorc.EditValue);
                _Info.kg_chatarra_valor = Convert.ToDouble((txtChatarraValor.EditValue == "")?"0":txtChatarraValor.EditValue);
                _Info.kg_oxidacion_porcen = Convert.ToDouble(txtOxidacionPorc.EditValue);
                _Info.kg_oxidacion_valor = Convert.ToDouble(txtOxidacionValor.EditValue);
                _Info.rendi_metal_historico = Convert.ToDouble(txtHistorico.EditValue);
                _Info.rendi_metal_real = Convert.ToDouble(txtReal.EditValue);
                _Info.rendi_metal_Diferencia = Convert.ToDouble(txtDiferencia.EditValue);
                _Info.consumo_kilowatios = Convert.ToDouble(txtKilowatios.EditValue);
                _Info.consumo_galones = Convert.ToDouble(txtGalones.EditValue);
                _Info.cambio_prue_programado = Convert.ToDouble(txtProgramado.EditValue);
                _Info.cambio_prue_real = Convert.ToDouble(txtCambioReal.EditValue);
                _Info.cambio_prue_porcentaje = Convert.ToDouble(txtPorcentaje.EditValue);
                if (txtTurnoIni.Text != "")
                {
                    string[] I = txtTurnoIni.Text.Split(':');
                    TimeSpan hrI = new TimeSpan(Convert.ToInt16(I[0]), Convert.ToInt16(I[1]), 0);
                    _Info.hora_turno_ini = hrI;
                }
                if (txtTurnoFin.Text != "")
                {
                    string[] F = txtTurnoFin.Text.Split(':');
                    TimeSpan hrF = new TimeSpan(Convert.ToInt16(F[0]), Convert.ToInt16(F[1]), 0);
                    _Info.hora_turno_fin = hrF;
                }
                _Info.hora_jornada = Convert.ToDouble(txtJornada.EditValue);
                _Info.hora_productiva = Convert.ToDouble(txtProductiva.EditValue);
                _Info.hora_Paros = Convert.ToDouble(txtParos.EditValue);
                _Info.hora_Neta = Convert.ToDouble(txtNeta.EditValue);
                _Info.hora_Hrs_Maquina = Convert.ToDouble(txtHrsMaq.EditValue);
                _Info.EficienciaProduccion = Convert.ToDouble(txtEficienciaProduccion.EditValue);
                _Info.Ton_Programada = Convert.ToDouble(txtTonProgramada.EditValue);
                _Info.Ton_real = Convert.ToDouble(txtTonReal.EditValue);
                _Info.Ton_Eficiencia = Convert.ToDouble(txtEficiencia.EditValue);
                _Info.Ton_TnHrNeta = Convert.ToDouble(txtHrsNeta.EditValue);
                _Info.Ton_kwTon = Convert.ToDouble(txtKwtn.EditValue);
                _Info.Ton_GlsTon = Convert.ToDouble(txtGlsTon.EditValue);
                _Info.IdTurno = Convert.ToInt32(cmbTurno.EditValue);
                _Info.Fecha = Convert.ToDateTime(Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString());
                _Info.IdTurno = Convert.ToInt32(cmbTurno.EditValue);
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    var asasd = (prod_GestionProductivaLaminado_x_paradas_CusTalme_Info)gridView.GetRow(i);
                    if (asasd != null)
                        _Info.ListDetalle.Add(asasd);
                }
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        public prod_GestionProductivaLaminado_CusTalme_Info  _SetInfo { get; set; }
        void Set() 
        {
            try
            {
                txtIdGestioProductiva.EditValue = _SetInfo.IdGestionProductiva;
                cmbJefeTurno.EditValue = _SetInfo.IdEmpleado_JefeTurno;
                cmbTurno.EditValue = _SetInfo.IdTurno;
                cmbMateriaPrima.EditValue = _SetInfo.IdProducto_MateriaPrima;
                txtIdBobina.EditValue = _SetInfo.Id_Bobina;
                txtNOrden.EditValue = _SetInfo.Num_Orden;
                txtCarga.EditValue = _SetInfo.kg_Cargados;
                txtProducto.EditValue = _SetInfo.kg_producidos;
                cmbProducto.EditValue = _SetInfo.IdProducto_Producido1;
                txtUnidadesPro1.EditValue = _SetInfo.unidades_prd_1;
                txtValorprod1.EditValue = _SetInfo.pesokg_prd_1;
                cmbProduct2.EditValue = _SetInfo.IdProducto_Producido2;
                txtUnidadesPro2.EditValue = _SetInfo.unidades_prd_2;
                txtValorProd2.EditValue = _SetInfo.pesokg_prd_2;
                txtRetazoPorcentaje.EditValue = _SetInfo.kg_retazo_porcen;
                txtRetazoValor.EditValue = _SetInfo.kg_retazo_valor;
                txtChatarraPorc.EditValue = _SetInfo.kg_chatarra_porcen;
                txtChatarraValor.EditValue = _SetInfo.kg_chatarra_valor;
                txtOxidacionPorc.EditValue = _SetInfo.kg_oxidacion_porcen;
                txtOxidacionValor.EditValue = _SetInfo.kg_oxidacion_valor;
                txtHistorico.EditValue = _SetInfo.rendi_metal_historico;
                txtReal.EditValue = _SetInfo.rendi_metal_real;
                txtDiferencia.EditValue = _SetInfo.rendi_metal_Diferencia;
                txtKilowatios.EditValue = _SetInfo.consumo_kilowatios;
                txtGalones.EditValue = _SetInfo.consumo_galones;
                txtProgramado.EditValue = _SetInfo.cambio_prue_programado;
                txtCambioReal.EditValue = _SetInfo.cambio_prue_real;
                txtPorcentaje.EditValue = _SetInfo.cambio_prue_porcentaje;
                txtTurnoIni.Text = _SetInfo.hora_turno_ini.ToString();
                txtTurnoFin.Text = _SetInfo.hora_turno_fin.ToString();
                txtJornada.EditValue = _SetInfo.hora_jornada;
                txtProductiva.EditValue = _SetInfo.hora_productiva;
                txtParos.EditValue = _SetInfo.hora_Paros;
                txtNeta.EditValue = _SetInfo.hora_Neta;
                txtHrsMaq.EditValue = _SetInfo.hora_Hrs_Maquina;
                txtTonProgramada.EditValue = _SetInfo.Ton_Programada;
                txtTonReal.EditValue = _SetInfo.Ton_real;
                txtEficiencia.EditValue = _SetInfo.Ton_Eficiencia;
                txtHrsNeta.EditValue = _SetInfo.Ton_TnHrNeta;
                txtKwtn.EditValue = _SetInfo.Ton_kwTon;
                txtGlsTon.EditValue = _SetInfo.Ton_GlsTon;
                txtEficienciaProduccion.EditValue = _SetInfo.EficienciaProduccion;
                dtpFecha.EditValue = _SetInfo.Fecha;
                in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus Bus = new Business.Inventario.in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus();
                gridControl.DataSource = _Detalle_B.Consultar(param.IdEmpresa, _SetInfo.IdGestionProductiva);
                var Info = Bus.ConsultarObjeto(param.IdEmpresa, _SetInfo.IdGestionProductiva);
                if (Info != null)
                {

                    var Datasourcer = _Movi_B.Obtener_list_Movi_inven_x_ProdDiariaLaminadosTalme(param.IdEmpresa, Info.mov_IdSucursal, Info.mov_IdBodega, Info.mov_IdMovi_inven_tipo, Info.mov_IdNumMovi);
                    Datasourcer.ForEach(var => var.Icono = global::Core.Erp.Winform.Properties.Resources.imprimir);
                    gridControlMovi.DataSource = Datasourcer;
                }


                in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus BusDeta = new in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus();
                List<in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info> Movimientos = new List<Info.Inventario.in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info>();
                Movimientos.Add(BusDeta.ConsultarObjeto(param.IdEmpresa,_SetInfo.IdGestionProductiva));
                //prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus BusMoviCon = new prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus();
                //var Movimientos = BusMoviCon.ObjtenerListaPorGestion(param.IdEmpresa, _SetInfo.IdGestionProductiva);
                List<in_movi_inve_Info> lstMovi = new List<in_movi_inve_Info>();
                foreach (var item in Movimientos)
                {
                    var Movi = _Movi_B.Obtener_list_Movi_inven_Reporte(item.mov_IdEmpresa, item.mov_IdSucursal, item.mov_IdBodega, item.mov_IdMovi_inven_tipo, item.mov_IdNumMovi);
                    Movi.IconImprimir = global::Core.Erp.Winform.Properties.Resources.imprimir;

                    lstMovi.Add(Movi);
                }

                gridControlMovi.DataSource = lstMovi;
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                string men = "";
                if (_Bus.Anular(_Info.IdEmpresa, _Info.IdGestionProductiva))
                {
                    MessageBox.Show("Anulado Ok");

                    in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus Bus = new Business.Inventario.in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus();
                    var Info = Bus.ConsultarObjeto(param.IdEmpresa, _Info.IdGestionProductiva);
                    if (Info != null)
                    {
                        var Movi = _Movi_B.Obtener_list_Movi_inven_Reporte(Info.mov_IdEmpresa, Info.mov_IdSucursal, Info.mov_IdBodega, Info.mov_IdMovi_inven_tipo, Info.mov_IdNumMovi);
                        if (_Movi_B.AnularDB(Movi, ref men))
                        {
                            if (_MoviDet_B.AnularDB(Movi.listmovi_inve_detalle_Info, ref men))
                            {
                                Movi.listmovi_inve_detalle_Info.ForEach(var => var.dm_cantidad = var.dm_cantidad * -1);
                                _BusPROxBOD.ActualizarStock_x_Bodega_con_moviInven(Movi.listmovi_inve_detalle_Info, ref men);
                                Bus.Eliminar(Info);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Error al Anular");
                }
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }


        public delegate void delegate_frmProd_Diaria_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmProd_Diaria_FormClosing Event_frmProd_Diaria_FormClosing;

        private void frmProd_Diaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Event_frmProd_Diaria_FormClosing(searchLookUpEdit1View, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarySalir_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click(sender, e);
            Close();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                _Bus.EjecutarSpReporte(param.IdEmpresa, Convert.ToDecimal (txtIdGestioProductiva.EditValue), param.IdUsuario, param.nom_pc);
                XtraReport1 x = new XtraReport1(param.IdUsuario, param.nom_pc, param.EmpresaInfo);
                x.ShowPreview();
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtProductiva_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular();
                txtHrsMaq.EditValue = Convert.ToDouble(txtProductiva.EditValue )- TotalHrasProduc;
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridView5_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "...")
                {
                    in_movi_inve_Bus MoviB = new in_movi_inve_Bus();
                    in_movi_inve_Info DataMoviInven = new in_movi_inve_Info();
                    List<in_movi_inve_Info> listMoviIn = new List<in_movi_inve_Info>();

                    in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus Bus = new Business.Inventario.in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus();
                    var Info = Bus.ConsultarObjeto(param.IdEmpresa, _SetInfo.IdGestionProductiva);

                    DataMoviInven = MoviB.Obtener_list_Movi_inven_Reporte(param.IdEmpresa, Info.mov_IdSucursal, Info.mov_IdBodega, Info.mov_IdMovi_inven_tipo, Info.mov_IdNumMovi);
                    //_Produ_B.Des_Producto
                    DataMoviInven.listmovi_inve_detalle_Info.ForEach(var => { var.NomProducto = _Produ_B.Des_Producto(param.IdEmpresa, var.IdProducto); var.CodProducto = _Produ_B.Cod_Producto(param.IdEmpresa, var.IdProducto); });

                    listMoviIn.Add(DataMoviInven);


                    XRpt_in_Ajuste_inventario RptAjuste = new XRpt_in_Ajuste_inventario();

                    RptAjuste.cargarData(listMoviIn.ToArray());
                    RptAjuste.ShowPreviewDialog();

                }
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtEficiencia_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void gridViewMovi_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Caption == "*")
            {
                Get();
                in_movi_inve_Bus MoviB = new in_movi_inve_Bus();
                in_movi_inve_Info DataMoviInven = new in_movi_inve_Info();
                List<in_movi_inve_Info> listMoviIn = new List<in_movi_inve_Info>();
                in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus BusDeta = new in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus();
                List<in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info> Movimientos = new List<Info.Inventario.in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info>();
                Movimientos.Add(BusDeta.ConsultarObjeto(param.IdEmpresa,_SetInfo.IdGestionProductiva));
                foreach (var item in Movimientos)
                {
                    DataMoviInven = MoviB.Obtener_list_Movi_inven_Reporte(param.IdEmpresa, item.mov_IdSucursal, item.mov_IdBodega, item.mov_IdMovi_inven_tipo, item.mov_IdNumMovi);
                    listMoviIn.Add(DataMoviInven);
                }
                XRpt_in_Ajuste_inventario RptAjuste = new XRpt_in_Ajuste_inventario();
                RptAjuste.cargarData(listMoviIn.ToArray());
                RptAjuste.ShowPreviewDialog();



            }
        }
        
    }
}
