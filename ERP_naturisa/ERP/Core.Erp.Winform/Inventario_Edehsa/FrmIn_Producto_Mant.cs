using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.Inventario_Edehsa;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList.Nodes;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.Controles;
using System.IO;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Winform.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Inventario_Edehsa;
using NCalc;

namespace Core.Erp.Winform.Inventario_Edehsa
{
    public partial class FrmIn_Producto_Mant : Form
    {
        #region Declaración de Variables


        FrmGe_MotivoAnulacion ofrmAnulacion = new FrmGe_MotivoAnulacion();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;


        vwtb_Bodega_x_Sucursal_TreeList_Info info_Bodega_x_Sucursal = new vwtb_Bodega_x_Sucursal_TreeList_Info();


        ct_Plancta_Bus plnCta_B = new ct_Plancta_Bus();

        BindingList<in_producto_x_cp_proveedor_Info> LBinProxProve;
        BindingList<in_Producto_Composicion_Info> LBinProComposi;
        List<in_producto_x_cp_proveedor_Info> listaProd_x_prove;


        in_producto_Bus Bus_Producto = new in_producto_Bus();
        in_Producto_Info Info_Producto = new in_Producto_Info();

        List<ct_Plancta_Info> listPlanCta = new List<ct_Plancta_Info>();
        ct_Plancta_Bus BusPlanCta = new ct_Plancta_Bus();

        List<ct_Centro_costo_Info> listCentroCosto_Info = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus BusCentroCosto = new ct_Centro_costo_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> list_SubCentroCosto_Info = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus BusSubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();


        //BLOQUE CATEGORIA_X_FORMULA
        string sIdCategoria;
        string sFormula_x_Categoria;
        int iIdCategoria;
        double dPesoTeorico;
        List<in_Categoria_x_Formula_Info> Categoria_x_FormulaList = new List<in_Categoria_x_Formula_Info>();
        in_Categoria_x_Formula_Info Categoria_x_FormulaInfo = new in_Categoria_x_Formula_Info();
        in_Categoria_x_Formula_bus Categoria_x_FormulaBus = new in_Categoria_x_Formula_bus();
        int iAlto;
        int iAncho;
        int iCeja;
        int iEspesor;
        int iLargo;
        int iDiametro;


        string MensajeError = "";


        ct_Plancta_Bus _PlanCta_bus1 = new ct_Plancta_Bus();
        List<ct_Plancta_Info> listaPlan = new List<ct_Plancta_Info>();
        //lista producto x proveedor
        List<in_producto_x_cp_proveedor_Info> lm_prod_x_prove = new List<in_producto_x_cp_proveedor_Info>();
        List<in_producto_x_cp_proveedor_Info> _lm_prod_x_prove = new List<in_producto_x_cp_proveedor_Info>();
        in_producto_x_cp_proveedor_Bus pxp_bus = new in_producto_x_cp_proveedor_Bus();

        //lista producto composicion
        List<in_Producto_Composicion_Info> lsComposicionProducto = new List<in_Producto_Composicion_Info>();
        List<in_Producto_Composicion_Info> _lsComposicionProducto = new List<in_Producto_Composicion_Info>();
        //lista producto x bodega
        List<in_producto_x_tb_bodega_Info> lsProductoBodega_Insert = new List<in_producto_x_tb_bodega_Info>();
        List<in_producto_x_tb_bodega_Info> lsProductoBodega_Update = new List<in_producto_x_tb_bodega_Info>();
        List<in_producto_x_tb_bodega_Info> _lsProductoBodega_Anterior = new List<in_producto_x_tb_bodega_Info>();
        in_producto_x_tb_bodega_Bus busProductoBodega = new in_producto_x_tb_bodega_Bus();
        vwtb_Bodega_x_Sucursal_TreeList_Bus busBod_x_Suc = new vwtb_Bodega_x_Sucursal_TreeList_Bus();
        List<vwtb_Bodega_x_Sucursal_TreeList_Info> lst_Bod_x_Suc = new List<vwtb_Bodega_x_Sucursal_TreeList_Info>();

        fa_catalogo_Bus busFactCata = new fa_catalogo_Bus();
        List<fa_catalogo_Info> lstFactCata = new List<fa_catalogo_Info>();


        public delegate void delegate_FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info);
        public event delegate_FrmIn_Producto_Mant_FormClosing event_FrmIn_Producto_Mant_FormClosing;



        #endregion

        
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            _Accion = iAccion;
        }


        private void set_Accion_in_controls()
        {

            switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                    ucGe_Menu.Visible_btnGuardar = true;
                    chkActivo.Checked = true;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                    ucGe_Menu.Visible_btnGuardar = true;
                    set_producto_in_controls();
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    ucGe_Menu.Enabled_bntAnular = true;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                    set_producto_in_controls();
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                    set_producto_in_controls();
                    break;
                default:
                    break;
            }


        }

        public void set_Info_producto(in_Producto_Info iProdu)
        {
            Info_Producto = iProdu;
        }

        private void set_producto_in_controls()
        {
            try
            {
                lblIdProducto.Text = Info_Producto.IdProducto.ToString();
                txtDescripcion2.Text = Info_Producto.pr_descripcion_2;
                txePesoEspecifico.EditValue = Info_Producto.PesoEspecifico;
                txeCeja.EditValue = Info_Producto.AnchoEspecifico;
                txtCodigo.Enabled = false;


                cmbMarca.set_MarcaInfo(Info_Producto.IdMarca);
                cmbUnidadMedida_Consumo.set_IdUnidadMedida(Info_Producto.IdUnidadMedida_Consumo);
                cmbUnidadMedida.set_IdUnidadMedida(Info_Producto.IdUnidadMedida);
                ucIn_Presentacion.set_PresentacionInfo(Info_Producto.IdPresentacion);
                cmb_tipoProducto.set_TipoProductoInfo(Info_Producto.IdProductoTipo);

                txeAlto.EditValue = Info_Producto.pr_alto;
                txtCodigo.Text = Info_Producto.pr_codigo;
                txtCodigoBarra.Text = Info_Producto.pr_codigo_barra;
                txeCostoCIF.EditValue = Convert.ToDouble(Info_Producto.pr_costo_CIF);
                txeCostoFOB.EditValue = Convert.ToDouble(Info_Producto.pr_costo_fob);
                txeCostoPromedio.EditValue = Convert.ToDouble(Info_Producto.pr_costo_promedio);
                txtNombre.Text = Info_Producto.pr_descripcion;
                txtDiasAereo.Value = Info_Producto.pr_DiasAereo;
                txtDiasMaritimo.Value = Info_Producto.pr_DiasMaritimo;
                txtDiasTerrestre.Value = Info_Producto.pr_DiasTerrestre;

                chkActivo.Checked = (Info_Producto.Estado == "A") ? true : false;

                cmbCodImp_IVA.EditValue = Info_Producto.IdCod_Impuesto_Iva;
                cmbCodImpt_ICE.EditValue = Info_Producto.IdCod_Impuesto_Ice;

                chkManejaKardex.Checked = (Info_Producto.ManejaKardex == "S") ? true : false;

                txeLargo.EditValue = Info_Producto.pr_largo;
                txtObservacion.Text = Info_Producto.pr_observacion;
                txtPartidaArancelaria.Text = Info_Producto.pr_partidaArancel;
                txePeso.EditValue = Info_Producto.pr_peso;
                txtPorPartidaArancelaria.Value = Info_Producto.pr_porcentajeArancel;
                txePrecioMayor.EditValue = Convert.ToDouble(Info_Producto.pr_precio_mayor);
                txePrecioMinimo.EditValue = Convert.ToDouble(Info_Producto.pr_precio_minimo);
                txePrecioPublico.EditValue = Convert.ToDouble(Info_Producto.pr_precio_publico);
                txeAncho.EditValue = Info_Producto.pr_profundidad;
                txeStockMaximo.EditValue = Convert.ToDecimal(Info_Producto.pr_stock_maximo);

                txeStockminimo.EditValue = Convert.ToDecimal(Info_Producto.pr_stock_minimo);

                ucIn_Linea_Grup_SubGr.set_item_Catgoria(Info_Producto.IdCategoria);
                ucIn_Linea_Grup_SubGr.set_item_Linea(Convert.ToInt32(Info_Producto.IdLinea));
                ucIn_Linea_Grup_SubGr.set_item_Grupo(Convert.ToInt32(Info_Producto.IdGrupo));
                ucIn_Linea_Grup_SubGr.set_item_SubGrupo(Convert.ToInt32(Info_Producto.IdSubGrupo));

                carga_dgvProductoBodega();


                pibx_imagenPequeña.Image = Funciones.ArrayAImage(Info_Producto.pr_imagenPeque);

                if (Info_Producto.Estado == "I")
                { lblAnulado.Visible = true; }
                else { lblAnulado.Visible = false; }

                ucFa_Motivo_venta.set_Info(Info_Producto.IdMotivo_Vta);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public in_Producto_Info Get_producto()
        {
            try
            {
                Info_Producto = new in_Producto_Info();
                Info_Producto.IdEmpresa = param.IdEmpresa;
                Info_Producto.Estado = (chkActivo.Checked == true) ? "A" : "I";
                Info_Producto.pr_descripcion = txtNombre.Text.Trim();
                Info_Producto.IdPresentacion = null;
                Info_Producto.pr_descripcion_2 = txtDescripcion2.Text;
                Info_Producto.PesoEspecifico = Convert.ToDouble(txePesoEspecifico.EditValue);
                Info_Producto.AnchoEspecifico = Convert.ToDouble(txeCeja.EditValue);

                Info_Producto.IdPresentacion = ucIn_Presentacion.Get_PresentacionInfo().IdPresentacion;

                byte[] arr = Funciones.ImageAArray(pibx_imagenPequeña.Image);

                Info_Producto.pr_imagenPeque = arr;

                Info_Producto.IdUnidadMedida_Consumo = cmbUnidadMedida_Consumo.Get_Info_UnidadMedida().IdUnidadMedida;



                Info_Producto.IdCategoria = ucIn_Linea_Grup_SubGr.get_item_Categria();
                Info_Producto.IdLinea = ucIn_Linea_Grup_SubGr.get_item_Linea();
                Info_Producto.IdGrupo = ucIn_Linea_Grup_SubGr.get_item_Grupo();
                Info_Producto.IdSubGrupo = ucIn_Linea_Grup_SubGr.get_item_SubGrupo();

                Info_Producto.IdCtaCble_Inventario = (ucIn_Linea_Grup_SubGr.SubGrupoInfo == null) ? null : ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Inve;
                Info_Producto.IdCtaCble_Costo = (ucIn_Linea_Grup_SubGr.SubGrupoInfo == null) ? null : ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Costo;
                Info_Producto.IdCtaCble_Gasto_x_cxp = (ucIn_Linea_Grup_SubGr.SubGrupoInfo == null) ? null : ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Gasto_x_cxp;



                //haac 01/08/2014

                Info_Producto.IdProducto = Convert.ToDecimal(lblIdProducto.Text);
                Info_Producto.IdProductoTipo = cmb_tipoProducto.get_TipoProductoInfo().IdProductoTipo;
                Info_Producto.IdUnidadMedida = (cmbUnidadMedida.Get_Info_UnidadMedida().IdUnidadMedida == null) ? "UNI" : cmbUnidadMedida.Get_Info_UnidadMedida().IdUnidadMedida;
                Info_Producto.pr_alto = Convert.ToDouble(txeAlto.EditValue);
                Info_Producto.pr_codigo = txtCodigo.Text.Trim();
                Info_Producto.pr_codigo_barra = txtCodigoBarra.Text.Trim();
                Info_Producto.pr_costo_CIF = Convert.ToDouble(txeCostoCIF.EditValue);
                Info_Producto.pr_costo_fob = Convert.ToDouble(txeCostoFOB.EditValue);
                Info_Producto.pr_costo_promedio = Convert.ToDouble(txeCostoPromedio.EditValue);


                Info_Producto.IdCod_Impuesto_Iva = Convert.ToString(cmbCodImp_IVA.EditValue);
                Info_Producto.IdCod_Impuesto_Ice = Convert.ToString(cmbCodImpt_ICE.EditValue);


                Info_Producto.pr_DiasAereo = Convert.ToInt32(txtDiasAereo.Value);
                Info_Producto.pr_DiasMaritimo = Convert.ToInt32(txtDiasMaritimo.Value);
                Info_Producto.pr_DiasTerrestre = Convert.ToInt32(txtDiasTerrestre.Value);
                Info_Producto.pr_largo = Convert.ToInt32(txeLargo.EditValue);
                Info_Producto.pr_observacion = txtObservacion.Text.Trim();
                Info_Producto.pr_partidaArancel = txtPartidaArancelaria.Text.Trim();
                Info_Producto.pr_pedidos = 0;
                Info_Producto.pr_peso = Convert.ToDouble(txePeso.EditValue);
                Info_Producto.pr_porcentajeArancel = txtPorPartidaArancelaria.Value;
                Info_Producto.pr_precio_mayor = Convert.ToDouble(txePrecioMayor.EditValue);
                Info_Producto.pr_precio_minimo = Convert.ToDouble(txePrecioMinimo.EditValue);
                Info_Producto.pr_precio_publico = Convert.ToDouble(txePrecioPublico.EditValue);
                Info_Producto.pr_profundidad = Convert.ToDouble(txeAncho.EditValue);
                Info_Producto.pr_stock = 0;
                Info_Producto.pr_stock_maximo = Convert.ToDouble(txeStockMaximo.EditValue);
                Info_Producto.pr_stock_minimo = Convert.ToDouble(txeStockminimo.EditValue);
                Info_Producto.IdUsuarioUltMod = param.IdUsuario;



                Info_Producto.ManejaKardex = (chkManejaKardex.Checked) ? "S" : "N";

                Info_Producto.IdMarca = cmbMarca.get_MarcaInfo().IdMarca;

                Info_Producto.IdMotivo_Vta = (ucFa_Motivo_venta.get_Info() == null) ? 1 : ucFa_Motivo_venta.get_Info().IdMotivo_Vta;

                return Info_Producto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new in_Producto_Info();
            }
        }

        public List<in_producto_x_cp_proveedor_Info> get_Producto_x_provee_del_grid()
        {
            try
            {
                List<in_producto_x_cp_proveedor_Info> lss = new List<in_producto_x_cp_proveedor_Info>();

                int focus = this.gridViewProveedor.FocusedRowHandle;
                gridViewProveedor.FocusedRowHandle = focus + 1;

                foreach (var item in LBinProxProve)
                {
                    if (item.NomProducto_en_Proveedor != "")
                    {
                        in_producto_x_cp_proveedor_Info pxp_inf = new in_producto_x_cp_proveedor_Info();

                        pxp_inf.IdEmpresa_prod = param.IdEmpresa;
                        pxp_inf.IdEmpresa_prov = param.IdEmpresa;
                        pxp_inf.IdProducto = Convert.ToInt32(lblIdProducto.Text);
                        pxp_inf.IdProveedor = item.IdProveedor;
                        pxp_inf.NomProducto_en_Proveedor = item.NomProducto_en_Proveedor;
                        lss.Add(pxp_inf);
                    }
                }

                lm_prod_x_prove = lss;

                return lss;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<in_producto_x_cp_proveedor_Info>();
            }
        }

        public Boolean Validaciones()
        {
            try
            {
                Boolean Valido = true;

                if (cmbUnidadMedida.Get_Info_UnidadMedida() == null)
                {
                    MessageBox.Show("Seleccione unidad de medida ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbUnidadMedida.Focus();
                    return false;
                }



                if (ucIn_Presentacion.Get_PresentacionInfo() == null)
                {
                    MessageBox.Show("Por Favor seleccione presentacion de producto", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_tipoProducto.Focus();
                    return false;
                }


                if (cmb_tipoProducto.get_TipoProductoInfo() == null)
                {
                    MessageBox.Show("Por Favor seleccione el tipo de producto", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_tipoProducto.Focus();
                    return false;
                }

                if (cmbMarca.get_MarcaInfo() == null)
                {
                    MessageBox.Show("Seleccione una marca válida", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbMarca.Focus();
                    return false;
                }

                if (cmbUnidadMedida_Consumo.Get_Info_UnidadMedida() == null)
                {
                    MessageBox.Show("Seleccione un Tipo de Consumo válido", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbUnidadMedida_Consumo.Focus();
                    return false;
                }

                //if (cmbCodImp_IVA.EditValue == null )
                //{
                //    MessageBox.Show("Seleccione el Tipo de Impuesto IVA", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    cmbCodImp_IVA.Focus();
                //    return false;
                //}

                if (txtNombre.Text == "")
                {
                    MessageBox.Show("debe Ingresar el nombre del producto", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus();
                    return false;
                }



                if (String.IsNullOrEmpty(ucIn_Linea_Grup_SubGr.get_item_Categria()))
                {

                    MessageBox.Show("Seleccione una categoria ....", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_Linea_Grup_SubGr.get_item_Categria() == "000")
                {

                    MessageBox.Show("La Categoria no puede ser Todos", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                //if (Catei.IdCategoria == "" || Catei.IdCategoria == null)
                //{
                //    MessageBox.Show("Seleccione una categoria ....", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return false;
                //}

                //if (Catei.IdCategoria == "000")
                //{
                //    MessageBox.Show("La Categoria no puede ser Todos", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return false;
                //}

                foreach (var item in LBinProxProve)
                {
                    if (string.IsNullOrEmpty(item.NomProducto_en_Proveedor))
                    {
                        MessageBox.Show("Por favor ingrese descripcion del producto por proveedor", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }



                in_producto_Bus prob = new in_producto_Bus();
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (!prob.ValidarNombreItem(param.IdEmpresa, txtNombre.Text.Trim()))
                    {
                        MessageBox.Show("El Nombre del Propducto " + txtNombre.Text.Trim() + " Ya se Encuentra Ingresado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }


                return Valido;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean Anular()
        {
            try
            {
                if (!(Info_Producto == null))
                {
                    Get_producto();
                    in_producto_Bus perBu = new in_producto_Bus();

                    ofrmAnulacion.ShowDialog();

                    Info_Producto.pr_motivoAnulacion = ofrmAnulacion.motivoAnulacion;
                    return perBu.AnularDB(Info_Producto, ref MensajeError);
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean Actualizar()
        {
            try
            {
                if (Validaciones() == false)
                {
                    return false;
                }

                if (!(Info_Producto == null))
                {
                    Get_producto();
                    get_Producto_x_provee_del_grid();
                    get_Producto_x_composicion_del_grid();
                    get_ProductoxBodega_del_grid();

                    in_producto_Bus perBu = new in_producto_Bus();
                    in_producto_x_cp_proveedor_Bus pxpbus = new in_producto_x_cp_proveedor_Bus();
                    in_Producto_Composicion_Bus busComposicion = new in_Producto_Composicion_Bus();
                    in_producto_x_tb_bodega_Bus busProductoBodega = new in_producto_x_tb_bodega_Bus();



                    perBu.ModificarDB(Info_Producto, ref MensajeError);


                    pxpbus.eliminarRegistro_x_producto(param.IdEmpresa, Convert.ToInt32(this.lblIdProducto.Text), ref MensajeError);
                    pxpbus.Grabar_Producto_Proveedor_lista(lm_prod_x_prove, param.IdEmpresa, Convert.ToInt32(this.lblIdProducto.Text), ref MensajeError);

                    busComposicion.eliminarRegistro_x_producto(param.IdEmpresa, Convert.ToInt32(lblIdProducto.Text), ref MensajeError);
                    busComposicion.GrabarDB(lsComposicionProducto, Convert.ToInt32(lblIdProducto.Text), ref MensajeError);



                    foreach (var item in lsProductoBodega_Insert)
                    {
                        item.IdEmpresa = param.IdEmpresa;
                        if (busProductoBodega.VerificarExisteProductoXSucursalXBodega(param.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdProducto))
                        {

                            busProductoBodega.ModificarDB(item, ref MensajeError);
                        }
                        else
                        {
                            busProductoBodega.GrabaDB(item, param.IdEmpresa, ref MensajeError);
                        }


                    }



                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El producto ", Info_Producto.IdProducto);
                    MessageBox.Show(smensaje, param.Nombre_sistema);

                    LimpiarDatos();
                    return true;

                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        public Boolean grabar()
        {
            try
            {
                Boolean resultB;

                if (Validaciones() == false)
                {
                    return false;
                }
                Info_Producto = Get_producto();
                if (!(Info_Producto == null))
                {
                    decimal idProducto;
                    idProducto = 0;

                    get_Producto_x_provee_del_grid();
                    get_Producto_x_composicion_del_grid();
                    get_ProductoxBodega_del_grid();


                    in_producto_x_cp_proveedor_Bus pxpbus = new in_producto_x_cp_proveedor_Bus();
                    in_Producto_Composicion_Bus busComposicion = new in_Producto_Composicion_Bus();

                    if (Bus_Producto.GrabarDB(Info_Producto, ref  idProducto, ref MensajeError))
                    {

                        lblIdProducto.Text = idProducto.ToString();
                        Info_Producto.IdProducto = idProducto;

                        pxpbus.Grabar_Producto_Proveedor_lista(lm_prod_x_prove, param.IdEmpresa, idProducto, ref MensajeError);
                        busComposicion.GrabarDB(lsComposicionProducto, Convert.ToInt32(lblIdProducto.Text), ref MensajeError);

                        foreach (var item in lsProductoBodega_Insert)
                        {
                            item.IdProducto = idProducto;
                        }
                        if (busProductoBodega.GrabaDB(lsProductoBodega_Insert, param.IdEmpresa, ref MensajeError))
                        {

                        }

                        LimpiarDatos();

                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El producto ", idProducto);
                        MessageBox.Show(smensaje, param.Nombre_sistema);
                        resultB = true;
                    }
                    else
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultB = false;
                    }

                    return resultB;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public FrmIn_Producto_Mant()
        {
            try
            {
                InitializeComponent();

                event_FrmIn_Producto_Mant_FormClosing += FrmIn_Producto_Mant_event_FrmIn_Producto_Mant_FormClosing;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucIn_Linea_Grup_SubGr.event_cmb_subgrupo_EditValueChanged += ucIn_Linea_Grup_SubGr_event_cmb_subgrupo_EditValueChanged;
                ucIn_Linea_Grup_SubGr.event_delegate_cmb_categoria_EditValueChanged += ucIn_Linea_Grup_SubGr_event_delegate_cmb_categoria_EditValueChanged;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      

      
        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void ucIn_Linea_Grup_SubGr_event_cmb_subgrupo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucIn_Linea_Grup_SubGr.SubGrupoInfo != null)
                {
                    if (lst_Bod_x_Suc != null)
                    {
                        foreach (var item in lst_Bod_x_Suc)
                        {
                            item.IdCtaCble_Inven = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Inve;
                            item.IdCtaCble_Costo = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Costo;
                            item.IdCtaCble_Gasto_x_cxp = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Gasto_x_cxp;

                            item.IdCentro_Costo_Inventario = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCentro_Costo_Inv;
                            item.IdCentro_Costo_Costo = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCentro_Costo_Cost;
                            item.IdCentroCosto_x_Gasto_x_cxp = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCentro_Costo_x_Gasto_x_cxp;

                            item.IdCentroCosto_sub_centro_costo_inv = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCentroCosto_sub_centro_costo_inv;
                            item.IdCentroCosto_sub_centro_costo_cost = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCentroCosto_sub_centro_costo_cost;
                            item.IdCentroCosto_sub_centro_costo_cxp = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCentroCosto_sub_centro_costo_cxp;

                            item.IdCtaCble_Vta = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_Vta;
                            item.IdCtaCble_CosBaseIva = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_CosBaseIva;
                            item.IdCtaCble_CosBase0 = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_CosBase0;
                            item.IdCtaCble_VenIva = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_VenIva;
                            item.IdCtaCble_Ven0 = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_Ven0;
                            item.IdCtaCble_DesIva = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_DesIva;
                            item.IdCtaCble_Des0 = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_Des0;
                            item.IdCtaCble_DevIva = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_DevIva;
                            item.IdCtaCble_Dev0 = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_Dev0;
                        }
                        info_Bodega_x_Sucursal = lst_Bod_x_Suc.Where(q => q.Nivel == 2).FirstOrDefault();
                        setCtasCbles_Combos();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Focus();

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (grabar() == true)
                    { this.Close(); }
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (Actualizar() == true)
                    { this.Close(); }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Focus();
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    grabar();
                    return;
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    Actualizar();
                    return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Esta seguro que desea eliminar el Item", "Sistemas", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    if (Anular())
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        MessageBox.Show("Anulacion Exitosa");
                    }
                    else { MessageBox.Show("Error al anular "); }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmIn_Producto_Mant_event_FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info)
        {

        }

        void UCCategoria_Event_treeListCategoria_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            var info = (in_categorias_Info)sender;
            switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:

                    foreach (var item in lst_Bod_x_Suc)
                    {
                        item.IdCtaCble_Inven = info.IdCtaCtble_Inve;
                        item.IdCentro_Costo_Inventario = info.IdCentro_Costo_Inventario;
                        item.IdCtaCble_Costo = info.IdCtaCtble_Costo;
                        item.IdCentro_Costo_Costo = info.IdCentro_Costo_Costo;
                    }

                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:

                    foreach (var item in lst_Bod_x_Suc)
                    {
                        item.IdCtaCble_Inven = info.IdCtaCtble_Inve;
                        item.IdCentro_Costo_Inventario = info.IdCentro_Costo_Inventario;
                        item.IdCtaCble_Costo = info.IdCtaCtble_Costo;
                        item.IdCentro_Costo_Costo = info.IdCentro_Costo_Costo;

                    }
                    break;
            }
        }

        private void CargarCombo()
        {
            try
            {

                tb_sis_impuesto_Bus busSriCod = new tb_sis_impuesto_Bus();
                List<tb_sis_impuesto_Info> lstInfoCodSri_Iva = new List<tb_sis_impuesto_Info>();
                List<tb_sis_impuesto_Info> lstInfoCodSri_Ice = new List<tb_sis_impuesto_Info>();

                lstInfoCodSri_Iva = busSriCod.Get_List_impuesto("IVA");
                lstInfoCodSri_Ice = busSriCod.Get_List_impuesto("ICE");

                cmbCodImpt_ICE.Properties.DataSource = lstInfoCodSri_Ice;
                cmbCodImp_IVA.Properties.DataSource = lstInfoCodSri_Iva;

                lstFactCata = busFactCata.Get_List_catalogo(7);


                listPlanCta = new List<ct_Plancta_Info>();
                listPlanCta = BusPlanCta.Get_Cuentas_de_Movimiento(param.IdEmpresa, ref MensajeError);
                ucmb_CtaCbleInven.Properties.DataSource = listPlanCta;
                ucmb_CtaCbleGastos.Properties.DataSource = listPlanCta;
                ucmb_CtaCbleCostos.Properties.DataSource = listPlanCta;
                ucCon_PlanCta_VentaIva.Properties.DataSource = listPlanCta;
                ucCon_PlanCta_Venta0.Properties.DataSource = listPlanCta;
                ucCon_PlanCta_CostoBaseIva.Properties.DataSource = listPlanCta;
                ucCon_PlanCta_CostoBase0.Properties.DataSource = listPlanCta;
                ucCon_PlanCta_Venta.Properties.DataSource = listPlanCta;
                ucCon_PlanCta_DescIva.Properties.DataSource = listPlanCta;
                ucCon_PlanCta_Desc0.Properties.DataSource = listPlanCta;
                ucCon_PlanCta_DevIva.Properties.DataSource = listPlanCta;
                ucCon_PlanCta_Dev0.Properties.DataSource = listPlanCta;



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_ProductoMantenimiento_Load(object sender, EventArgs e)
        {

            try
            {
                CargarCombo();

                LBinProxProve = new BindingList<in_producto_x_cp_proveedor_Info>();
                gridControlProveedor.DataSource = LBinProxProve;

                tabControl_Producto.TabPages.Remove(tab_Costos);

                tabControl_Producto.TabPages.Remove(tab_DatosContables);

                load_grid();
                carga_ultragrid_composicion();

                if (_Accion == null || _Accion == 0)
                { _Accion = Cl_Enumeradores.eTipo_action.grabar; }
                carga_dgvProductoBodega();
                set_Accion_in_controls();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void load_grid()
        {
            try
            {
                carga_cmb_proveedor();

                _lm_prod_x_prove = pxp_bus.ObtenerProducto_Proveedor(param.IdEmpresa);

                listaProd_x_prove = new List<in_producto_x_cp_proveedor_Info>();
                listaProd_x_prove = _lm_prod_x_prove.FindAll(q => q.IdProducto == Convert.ToDecimal(lblIdProducto.Text));

                LBinProxProve = new BindingList<in_producto_x_cp_proveedor_Info>(listaProd_x_prove);
                gridControlProveedor.DataSource = LBinProxProve;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
            codigoBarraProducto.Text = txtCodigoBarra.Text;
            codigoBarraProducto.Refresh();
        }

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            codigoBarraProducto.Text = txtCodigoBarra.Text;
            codigoBarraProducto.Refresh();

        }

        private void carga_cmb_proveedor()
        {

            try
            {
                List<cp_proveedor_Info> ListProveedorInfo = new List<cp_proveedor_Info>();
                cp_proveedor_Bus _ProveedorBus = new cp_proveedor_Bus();
                ListProveedorInfo = _ProveedorBus.Get_List_proveedor(param.IdEmpresa);

                cmbProveedor_grid.DisplayMember = "pr_nombre";
                cmbProveedor_grid.ValueMember = "IdProveedor";
                cmbProveedor_grid.DataSource = ListProveedorInfo;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carga_ultragrid_composicion()
        {
            try
            {
                in_Producto_Composicion_Bus bus = new in_Producto_Composicion_Bus();

                carga_cmb_ProductoHijo();
                _lsComposicionProducto = bus.ObtenerListProductoComposicion(param.IdEmpresa, Convert.ToInt32(lblIdProducto.Text));


                LBinProComposi = new BindingList<in_Producto_Composicion_Info>(_lsComposicionProducto);
                gridControlComposicion.DataSource = LBinProComposi;
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carga_cmb_ProductoHijo()
        {
            try
            {

                List<in_Producto_Info> ls = new List<in_Producto_Info>();
                in_producto_Bus bus = new in_producto_Bus();
                ls = bus.Get_list_Producto(param.IdEmpresa);
                List<in_Producto_Info> itemComp = ls.FindAll(q => q.IdProducto != Convert.ToDecimal(lblIdProducto.Text));
                cmbProductoHijo_grid.DisplayMember = "pr_descripcion";
                cmbProductoHijo_grid.ValueMember = "IdProducto";
                cmbProductoHijo_grid.DataSource = itemComp;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public List<in_Producto_Composicion_Info> get_Producto_x_composicion_del_grid()
        {
            try
            {
                List<in_Producto_Composicion_Info> lss = new List<in_Producto_Composicion_Info>();


                int focus = this.gridViewComposicion.FocusedRowHandle;
                gridViewComposicion.FocusedRowHandle = focus + 1;

                foreach (var item in LBinProComposi)
                {
                    if (item.Cantidad != 0)
                    {
                        in_Producto_Composicion_Info info = new in_Producto_Composicion_Info();
                        info.IdEmpresa = param.IdEmpresa;
                        info.IdProductoPadre = Convert.ToDecimal(lblIdProducto.Text);
                        info.Cantidad = item.Cantidad;
                        info.IdProductoHijo = item.IdProductoHijo;

                        lss.Add(info);
                    }
                }

                lsComposicionProducto = lss;
                return lsComposicionProducto;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<in_Producto_Composicion_Info>();
            }
        }

        private void carga_TodasBodegas(List<vwtb_Bodega_x_Sucursal_TreeList_Info> lstBod_x_Suc)
        {
            try
            {
                treeList_Bodega_x_Sucursal.DataSource = lstBod_x_Suc;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void carga_dgvProductoBodega()
        {
            try
            {
                List<vwtb_Bodega_x_Sucursal_TreeList_Info> lstProd_x_bod = new List<vwtb_Bodega_x_Sucursal_TreeList_Info>();
                tb_Bodega_Bus bus = new tb_Bodega_Bus();

                lst_Bod_x_Suc = busBod_x_Suc.Get_List_Bodega_x_Sucursal(param.IdEmpresa);

                if (Convert.ToDecimal(lblIdProducto.Text) == 0)
                {
                    carga_TodasBodegas(lst_Bod_x_Suc);
                }
                else
                {
                    carga_TodasBodegas(lst_Bod_x_Suc);

                    List<in_producto_x_tb_bodega_Info> lsProdBodega = new List<in_producto_x_tb_bodega_Info>();
                    lsProdBodega = busProductoBodega.Get_list_Productos_x_Bodega(param.IdEmpresa, Convert.ToDecimal(lblIdProducto.Text));

                    foreach (var item1 in lst_Bod_x_Suc)
                    {
                        vwtb_Bodega_x_Sucursal_TreeList_Info Info = new vwtb_Bodega_x_Sucursal_TreeList_Info();
                        Info.IdEmpresa = item1.IdEmpresa;
                        Info.ID = item1.ID;
                        Info.IdPadre = item1.IdPadre;
                        Info.Nombre = item1.Nombre;
                        Info.Estado = item1.Estado;
                        Info.Nivel = item1.Nivel;
                        Info.IdSucursal = item1.IdSucursal;
                        Info.IdBodega = item1.IdBodega;
                        item1.Checked = Info.Checked = false;
                        item1.EstaEnBase = Info.EstaEnBase = false;
                        foreach (var item in lsProdBodega)
                        {
                            if (item.IdBodega == item1.IdBodega && item.IdSucursal == item1.IdSucursal)
                            {
                                item1.Checked = Info.Checked = true;
                                item1.EstaEnBase = Info.EstaEnBase = true;
                                item1.IdCtaCble_Vta = Info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                                item1.IdCtaCble_CosBaseIva = Info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                                item1.IdCtaCble_CosBase0 = Info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                                item1.IdCtaCble_VenIva = Info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                                item1.IdCtaCble_Ven0 = Info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                                item1.IdCtaCble_DesIva = Info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                                item1.IdCtaCble_Des0 = Info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                                item1.IdCtaCble_DevIva = Info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                                item1.IdCtaCble_Dev0 = Info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                                item1.IdCtaCble_Inven = Info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                                item1.IdCtaCble_Costo = Info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                                item1.IdCtaCble_Gasto_x_cxp = Info.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;
                                item1.IdCentro_Costo_Costo = Info.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                                item1.IdCentro_Costo_Inventario = Info.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                                item1.IdCentroCosto_x_Gasto_x_cxp = Info.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;
                                item1.IdCentroCosto_sub_centro_costo_inv = Info.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                                item1.IdCentroCosto_sub_centro_costo_cost = Info.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                                item1.IdCentroCosto_sub_centro_costo_cxp = Info.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                                item1.pr_precio_publico = Info.pr_precio_publico = Convert.ToDouble(item.pr_precio_publico);
                            }
                        }
                        lstProd_x_bod.Add(Info);
                    }

                    treeList_Bodega_x_Sucursal.DataSource = lst_Bod_x_Suc;
                }
                treeList_Bodega_x_Sucursal.ExpandAll();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void get_ProductoxBodega_del_grid()
        {
            try
            {
                lsProductoBodega_Insert = new List<in_producto_x_tb_bodega_Info>();
                lsProductoBodega_Update = new List<in_producto_x_tb_bodega_Info>();

                foreach (var item in lst_Bod_x_Suc)
                {
                    if (item.Nivel == 2)
                    {
                        in_producto_x_tb_bodega_Info info = new in_producto_x_tb_bodega_Info();
                        info.IdEmpresa = param.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdProducto = Convert.ToInt32(lblIdProducto.Text);

                        info.pr_precio_publico = item.pr_precio_publico;

                        info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                        info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                        info.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;


                        info.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                        info.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                        info.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;

                        info.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                        info.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                        info.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                        info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                        info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                        info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                        info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                        info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                        info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                        info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                        info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                        info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;

                        info.Estado = "A";

                        //  if (item.EstaEnBase == true)
                        if (item.Checked == true)
                        {
                            // lsProductoBodega_Update.Add(info);
                            lsProductoBodega_Insert.Add(info);

                        }
                        else
                        {
                            lsProductoBodega_Update.Add(info);
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

        private void txtPrecioPublico_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in lst_Bod_x_Suc)
                {
                    item.pr_precio_publico = Convert.ToDouble(txePrecioPublico.EditValue);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmIn_Producto_Mant_FormClosing(sender, e, Info_Producto);
        }

        private void txePrecioPublico_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (lst_Bod_x_Suc != null)
                    foreach (var item in lst_Bod_x_Suc)
                    {
                        item.pr_precio_publico = Convert.ToDouble(txePrecioPublico.EditValue);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imgGrande_Click_1(object sender, EventArgs e)
        {
            try
            {
                openFileDialogImagenGrande.Filter = "JPG|*.jpg";
                openFileDialogImagenGrande.ShowDialog();
                if (!string.IsNullOrEmpty(openFileDialogImagenGrande.FileName))
                {
                    if (File.Exists(openFileDialogImagenGrande.FileName))
                    {
                        Image Imagen = Image.FromFile(openFileDialogImagenGrande.FileName);
                        pibx_imagenPequeña.Image = Imagen;
                        pibx_imagenPequeña.SizeMode = PictureBoxSizeMode.StretchImage;
                        byte[] arr = Funciones.ImageAArray(Imagen);
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void treeList_Bodega_x_Sucursal_BeforeFocusNode(object sender, DevExpress.XtraTreeList.BeforeFocusNodeEventArgs e)
        {
            try
            {
                TreeListNode nodeSeleccionado = (TreeListNode)e.Node;
                info_Bodega_x_Sucursal = new vwtb_Bodega_x_Sucursal_TreeList_Info();
                info_Bodega_x_Sucursal = (vwtb_Bodega_x_Sucursal_TreeList_Info)this.treeList_Bodega_x_Sucursal.GetDataRecordByNode(nodeSeleccionado);
                if (info_Bodega_x_Sucursal.Nivel == 1)
                {
                    info_Bodega_x_Sucursal = (vwtb_Bodega_x_Sucursal_TreeList_Info)this.treeList_Bodega_x_Sucursal.GetDataRecordByNode(nodeSeleccionado.LastNode);
                }
                if (info_Bodega_x_Sucursal != null)
                    setCtasCbles_Combos();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setCtasCbles_Combos()
        {
            try
            {
                if (info_Bodega_x_Sucursal != null)
                {
                    if (info_Bodega_x_Sucursal.Nivel == 2)
                    {
                        groupControl1.Text = groupControl1.Text + " : Bodega " + info_Bodega_x_Sucursal.Nombre;
                        groupControl2.Text = groupControl2.Text + " : Bodega " + info_Bodega_x_Sucursal.Nombre;
                        groupControl3.Text = groupControl3.Text + " : Bodega " + info_Bodega_x_Sucursal.Nombre;
                        groupControl4.Text = groupControl4.Text + " : Bodega " + info_Bodega_x_Sucursal.Nombre;

                        var item = lst_Bod_x_Suc.Where(q => q.IdSucursal == info_Bodega_x_Sucursal.IdSucursal && q.IdBodega == info_Bodega_x_Sucursal.IdBodega).First();

                        ucmb_CtaCbleInven.EditValue = (item.IdCtaCble_Inven);
                        ucmb_CtaCbleCostos.EditValue = (item.IdCtaCble_Costo);
                        ucmb_CtaCbleGastos.EditValue = (item.IdCtaCble_Gasto_x_cxp);

                        ucCon_PlanCta_Venta.EditValue = (item.IdCtaCble_Vta);
                        ucCon_PlanCta_CostoBaseIva.EditValue = (item.IdCtaCble_CosBaseIva);
                        ucCon_PlanCta_CostoBase0.EditValue = (item.IdCtaCble_CosBase0);
                        ucCon_PlanCta_VentaIva.EditValue = (item.IdCtaCble_VenIva);
                        ucCon_PlanCta_Venta0.EditValue = (item.IdCtaCble_Ven0);
                        ucCon_PlanCta_DescIva.EditValue = (item.IdCtaCble_DesIva);
                        ucCon_PlanCta_Desc0.EditValue = (item.IdCtaCble_Des0);
                        ucCon_PlanCta_DevIva.EditValue = (item.IdCtaCble_DevIva);
                        ucCon_PlanCta_Dev0.EditValue = (item.IdCtaCble_Dev0);

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarCta_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in lst_Bod_x_Suc)
                {
                    if (item.IdSucursal == info_Bodega_x_Sucursal.IdSucursal && item.IdBodega == info_Bodega_x_Sucursal.IdBodega)
                    {
                        item.IdCtaCble_Inven = Convert.ToString(ucmb_CtaCbleInven.EditValue);
                        item.IdCtaCble_Costo = Convert.ToString(ucmb_CtaCbleCostos.EditValue);
                        item.IdCtaCble_Gasto_x_cxp = Convert.ToString(ucmb_CtaCbleGastos.EditValue);

                        item.IdCentro_Costo_Inventario = null;
                        item.IdCentro_Costo_Costo = null;
                        item.IdCentroCosto_x_Gasto_x_cxp = null;

                        item.IdCentroCosto_sub_centro_costo_inv = null;
                        item.IdCentroCosto_sub_centro_costo_cost = null;
                        item.IdCentroCosto_sub_centro_costo_cxp = null;

                        item.IdCtaCble_Vta = Convert.ToString(ucCon_PlanCta_Venta.EditValue);
                        item.IdCtaCble_CosBaseIva = Convert.ToString(ucCon_PlanCta_CostoBaseIva.EditValue);
                        item.IdCtaCble_CosBase0 = Convert.ToString(ucCon_PlanCta_CostoBase0.EditValue);
                        item.IdCtaCble_VenIva = Convert.ToString(ucCon_PlanCta_VentaIva.EditValue);
                        item.IdCtaCble_Ven0 = Convert.ToString(ucCon_PlanCta_Venta0.EditValue);
                        item.IdCtaCble_DesIva = Convert.ToString(ucCon_PlanCta_DescIva.EditValue);
                        item.IdCtaCble_Des0 = Convert.ToString(ucCon_PlanCta_Desc0.EditValue);
                        item.IdCtaCble_DevIva = Convert.ToString(ucCon_PlanCta_DevIva.EditValue);
                        item.IdCtaCble_Dev0 = Convert.ToString(ucCon_PlanCta_Dev0.EditValue);
                    }
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCodImp_IVA_EditValueChanged(object sender, EventArgs e)
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

        private void gridViewProveedor_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewProveedor.GetRow(e.RowHandle) as cp_proveedor_Info;
                if (data == null)
                    return;

                if (data.pr_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView1.GetRow(e.RowHandle) as cp_proveedor_Info;
                if (data == null)
                    return;

                if (data.pr_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbUnidadMedida_event_cmbUnidadMedida_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string IdUnidadMedida = "";
                IdUnidadMedida = cmbUnidadMedida.Get_Info_UnidadMedida().IdUnidadMedida;
                cmbUnidadMedida_Consumo.CargarUnidadMedida_Equiv(IdUnidadMedida);
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
                Info_Producto = new in_Producto_Info();

                chkActivo.Checked = true;
                chkManejaKardex.Checked = true;
                txtNombre.Text = "";
                txtDescripcion2.Text = "";
                txePesoEspecifico.EditValue = "";
                txeCeja.EditValue = "";
                lblIdProducto.Text = "";
                txeAlto.EditValue = "";
                txtCodigo.Text = "";
                txtCodigoBarra.Text = "";
                txeCostoCIF.EditValue = "";
                txeCostoFOB.EditValue = "";
                txeCostoPromedio.EditValue = "";
                txtDiasAereo.Value = 0;
                txtDiasMaritimo.Value = 0;
                txtDiasTerrestre.Value = 0;
                txeLargo.EditValue = "";
                txtObservacion.Text = "";
                txtPartidaArancelaria.Text = "";
                txePeso.EditValue = "";
                txtPorPartidaArancelaria.Value = 0;
                txePrecioMayor.EditValue = "";
                txePrecioMinimo.EditValue = "";
                txePrecioPublico.EditValue = 0;
                txeAncho.EditValue = "";
                txeStockMaximo.EditValue = "";
                txeStockminimo.EditValue = "";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //EVENTO AL CAMBIAR COMBO CATEGORIA /////////////////////////////////////////////////////////////////
        void ucIn_Linea_Grup_SubGr_event_delegate_cmb_categoria_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                sIdCategoria = ucIn_Linea_Grup_SubGr.get_item_Categria();
                iIdCategoria = Int32.Parse(sIdCategoria);
                Categoria_x_FormulaList = Categoria_x_FormulaBus.Get_List_Categoria_x_Formula(param.IdEmpresa, iIdCategoria);

                txeAlto.Enabled = (bool)Categoria_x_FormulaList[0].tiene_alto;
                txeAncho.Enabled = (bool)Categoria_x_FormulaList[0].tiene_ancho;
                txeCeja.Enabled = (bool)Categoria_x_FormulaList[0].tiene_ceja;
                txeEspesor.Enabled = (bool)Categoria_x_FormulaList[0].tiene_ancho;
                txeLargo.Enabled = (bool)Categoria_x_FormulaList[0].tiene_longitud;
                txeDiametro.Enabled = (bool)Categoria_x_FormulaList[0].tiene_diametro;

                // /// BLOQUE DE OBTNER FORMULA /////
                // sFormula_x_Categoria = Categoria_x_FormulaList[0].formula;
                ///// EXPRESION uso de LIBRERIA NCALC
                // Expression pesoTeorico = new Expression(sFormula_x_Categoria);
                // pesoTeorico.Parameters["Largo"] = int.Parse(txeLargo.Text);
                // pesoTeorico.Parameters["Ancho"] = int.Parse(txeAncho.Text);
                // pesoTeorico.Parameters["Espesor"] = int.Parse(txeEspesor.Text);


                
                ///FIN BLOQUE OBTENER FORMULA///
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txePesoEspecifico_Leave(object sender, EventArgs e)
        {
            iAlto = (txeAlto.Text == "") ? 0 : Convert.ToInt32(txeAlto.Text);
            iAncho = (txeAncho.Text == "") ? 0 : Convert.ToInt32(txeAncho.Text);
            iCeja = (txeCeja.Text == "") ? 0 : Convert.ToInt32(txeCeja.Text);
            iLargo = (txeLargo.Text == "") ? 0 : Convert.ToInt32(txeLargo.Text);
            iEspesor = (txeEspesor.Text == "") ? 0 : Convert.ToInt32(txeEspesor.Text);
            iDiametro = (txeDiametro.Text == "") ? 0 : Convert.ToInt32(txeDiametro.Text);

            dPesoTeorico = Categoria_x_FormulaBus.CalcularPesoTeorico(param.IdEmpresa, iIdCategoria, iAlto, iAncho, iCeja, iLargo, iEspesor, iDiametro);

            txePeso.Text = dPesoTeorico.ToString();
        }

        


    }
}
