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

namespace Core.Erp.Winform.Inventario
{

    public partial class FrmIn_Producto_Mant : Form
    {
        #region Declaración de Variables


        FrmGe_MotivoAnulacion ofrmAnulacion = new FrmGe_MotivoAnulacion();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;
        in_Familia_Bus bus_familia = new in_Familia_Bus();
        

                vwtb_Bodega_x_Sucursal_TreeList_Info info_Bodega_x_Sucursal = new vwtb_Bodega_x_Sucursal_TreeList_Info();
                

                BindingList<in_Producto_Composicion_Info> LBinProComposi;
                

                in_producto_Bus Bus_Producto = new in_producto_Bus();
                in_Producto_Info Info_Producto = new in_Producto_Info();
        
                string MensajeError = "";
                
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
               
                
                cmbMarca.set_MarcaInfo(Info_Producto.IdMarca);
                cmbUnidadMedida_Consumo.set_IdUnidadMedida(Info_Producto.IdUnidadMedida_Consumo);
                cmbUnidadMedida.set_IdUnidadMedida(Info_Producto.IdUnidadMedida);
                ucIn_Presentacion.set_PresentacionInfo(Info_Producto.IdPresentacion);
                cmb_tipoProducto.set_TipoProductoInfo(Info_Producto.IdProductoTipo);                
                
                txtCodigo.Text = Info_Producto.pr_codigo;
                txtCodigoBarra.Text = Info_Producto.pr_codigo_barra;             
                txtNombre.Text = Info_Producto.pr_descripcion;
                cmb_familia.EditValue = Info_Producto.IdFamilia;
                chkActivo.Checked = (Info_Producto.Estado == "A") ? true : false;

                cmbCodImp_IVA.EditValue = Info_Producto.IdCod_Impuesto_Iva;
                cmbCodImpt_ICE.EditValue = Info_Producto.IdCod_Impuesto_Ice;

                chkManejaKardex.Checked = (Info_Producto.ManejaKardex == "S") ? true : false;

                txtObservacion.Text = Info_Producto.pr_observacion;
                ucIn_Linea_Grup_SubGr.set_item_Catgoria(Info_Producto.IdCategoria);
                ucIn_Linea_Grup_SubGr.set_item_Linea(Convert.ToInt32(Info_Producto.IdLinea));
                ucIn_Linea_Grup_SubGr.set_item_Grupo(Convert.ToInt32(Info_Producto.IdGrupo));
                ucIn_Linea_Grup_SubGr.set_item_SubGrupo(Convert.ToInt32(Info_Producto.IdSubGrupo));

                carga_dgvProductoBodega();               
                
             
                pibx_imagenPequeña.Image =Funciones.ArrayAImage(Info_Producto.pr_imagenPeque);

                if (Info_Producto.Estado=="I")
                {lblAnulado.Visible=true;}
                else { lblAnulado.Visible = false; }

                ucFa_Motivo_venta.set_Info(Info_Producto.IdMotivo_Vta);

                chkModulo_AF.Checked = Info_Producto.Aparece_modu_Activo_F;
                chkModulo_Compras.Checked = Info_Producto.Aparece_modu_Compras;
                chkModulo_Inven.Checked = Info_Producto.Aparece_modu_Inventario;
                chkModulo_Venta.Checked = Info_Producto.Aparece_modu_Ventas;
                
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
                Info_Producto.IdPresentacion = ucIn_Presentacion.Get_PresentacionInfo().IdPresentacion;
                byte[] arr =Funciones.ImageAArray(pibx_imagenPequeña.Image);
                Info_Producto.pr_imagenPeque = arr;
                Info_Producto.IdUnidadMedida_Consumo = cmbUnidadMedida_Consumo.Get_Info_UnidadMedida().IdUnidadMedida;
                Info_Producto.IdCategoria = ucIn_Linea_Grup_SubGr.get_item_Categria();
                Info_Producto.IdLinea = ucIn_Linea_Grup_SubGr.get_item_Linea();
                Info_Producto.IdGrupo = ucIn_Linea_Grup_SubGr.get_item_Grupo();
                Info_Producto.IdSubGrupo = ucIn_Linea_Grup_SubGr.get_item_SubGrupo();
                Info_Producto.IdCtaCble_Inventario = (ucIn_Linea_Grup_SubGr.SubGrupoInfo == null)? null: ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Inve;
                Info_Producto.IdCtaCble_Costo = (ucIn_Linea_Grup_SubGr.SubGrupoInfo == null) ? null : ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Costo;
                Info_Producto.IdCtaCble_Gasto_x_cxp = (ucIn_Linea_Grup_SubGr.SubGrupoInfo == null) ? null : ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Gasto_x_cxp;
                Info_Producto.IdProducto = lblIdProducto.Text=="" ? 0 : Convert.ToDecimal(lblIdProducto.Text);
                Info_Producto.IdProductoTipo = cmb_tipoProducto.get_TipoProductoInfo().IdProductoTipo;
                Info_Producto.IdUnidadMedida = (cmbUnidadMedida.Get_Info_UnidadMedida().IdUnidadMedida == null) ? "UNI" : cmbUnidadMedida.Get_Info_UnidadMedida().IdUnidadMedida;
                Info_Producto.pr_codigo = txtCodigo.Text.Trim();
                Info_Producto.pr_codigo_barra = txtCodigoBarra.Text.Trim();
                Info_Producto.IdCod_Impuesto_Iva = Convert.ToString(cmbCodImp_IVA.EditValue);
                Info_Producto.IdCod_Impuesto_Ice = cmbCodImpt_ICE.EditValue == "" ? null : Convert.ToString(cmbCodImpt_ICE.EditValue);
                Info_Producto.pr_observacion = txtObservacion.Text.Trim();
                Info_Producto.pr_stock = 0;
                Info_Producto.IdUsuarioUltMod = param.IdUsuario;
                Info_Producto.ManejaKardex = (chkManejaKardex.Checked) ? "S" : "N";
                Info_Producto.IdMarca = cmbMarca.get_MarcaInfo().IdMarca;
                Info_Producto.IdMotivo_Vta = (ucFa_Motivo_venta.get_Info() ==null) ? 1:ucFa_Motivo_venta.get_Info().IdMotivo_Vta;
                Info_Producto.Aparece_modu_Activo_F = chkModulo_AF.Checked;
                Info_Producto.Aparece_modu_Compras = chkModulo_Compras.Checked;
                Info_Producto.Aparece_modu_Inventario = chkModulo_Inven.Checked;
                Info_Producto.Aparece_modu_Ventas = chkModulo_Venta.Checked;
                
                if (cmb_familia.EditValue == null)
                    Info_Producto.IdFamilia = null;
                else
                    Info_Producto.IdFamilia = Convert.ToInt32(cmb_familia.EditValue);

                #region Campos que hay que borrar luego
                Info_Producto.PesoEspecifico = 0;
                Info_Producto.AnchoEspecifico = 0;
                Info_Producto.pr_stock_maximo = 0;
                Info_Producto.pr_stock_minimo = 0;
                Info_Producto.pr_partidaArancel = null;
                Info_Producto.pr_pedidos = 0;
                Info_Producto.pr_peso = 0;
                Info_Producto.pr_porcentajeArancel = 0;
                Info_Producto.pr_precio_mayor = 0;
                Info_Producto.pr_precio_minimo = 0;
                Info_Producto.pr_precio_publico = 0;
                Info_Producto.pr_profundidad = 0;
                Info_Producto.pr_DiasAereo = 0;
                Info_Producto.pr_DiasMaritimo = 0;
                Info_Producto.pr_DiasTerrestre = 0;
                Info_Producto.pr_largo = 0;
                Info_Producto.pr_alto = 0;
                Info_Producto.pr_costo_CIF = 0;
                Info_Producto.pr_costo_fob = 0;
                Info_Producto.pr_costo_promedio = 0;
                #endregion


                return Info_Producto;
            }
            catch (Exception  ex )
            {
                return null;
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

                if (cmbCodImpt_ICE.EditValue==null || cmbCodImpt_ICE.Text=="")
                {
                    MessageBox.Show("Seleccione el Tipo de Impuesto ICE", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbCodImp_IVA.Focus();
                    return false;    
                }

                if (String.IsNullOrEmpty(ucIn_Linea_Grup_SubGr.get_item_Categria()))
                {

                    MessageBox.Show("Seleccione una categoria ....", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      return false;
                }

                if (ucIn_Linea_Grup_SubGr.get_item_Categria()=="000")
                {

                    MessageBox.Show("La Categoria no puede ser Todos", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
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

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (prob.ValidaExisteMovimiento(param.IdEmpresa, Convert.ToDecimal(lblIdProducto.ToString())))
                    {
                        MessageBox.Show("El producto " + txtNombre.Text.Trim() + " ha sido utilizado en movimientos de inventario por lo que no puede ser modificado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                if (cmb_familia.EditValue == null)
                {
                    MessageBox.Show("El campo familia es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
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
                    get_Producto_x_composicion_del_grid();
                    get_ProductoxBodega_del_grid();

                    in_producto_Bus perBu = new in_producto_Bus();
                    in_producto_x_cp_proveedor_Bus pxpbus = new in_producto_x_cp_proveedor_Bus();
                    in_Producto_Composicion_Bus busComposicion = new in_Producto_Composicion_Bus();
                    in_producto_x_tb_bodega_Bus busProductoBodega = new in_producto_x_tb_bodega_Bus();


                    Info_Producto.IdUsuario = param.IdUsuario;
                    perBu.ModificarDB(Info_Producto, ref MensajeError);

                    busComposicion.eliminarRegistro_x_producto(param.IdEmpresa, Convert.ToInt32(lblIdProducto.Text), ref MensajeError);
                    busComposicion.GrabarDB(lsComposicionProducto, Convert.ToInt32(lblIdProducto.Text), ref MensajeError);
            
                    foreach (var item in lsProductoBodega_Insert)
                    {
                        item.IdEmpresa = param.IdEmpresa;
                        if (busProductoBodega.VerificarExisteProductoXSucursalXBodega(param.IdEmpresa,item.IdSucursal,item.IdBodega,item.IdProducto))
                        {
                            
                                busProductoBodega.ModificarDB(item,ref MensajeError);
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

                    get_Producto_x_composicion_del_grid();
                    get_ProductoxBodega_del_grid();

                    
                    in_producto_x_cp_proveedor_Bus pxpbus = new in_producto_x_cp_proveedor_Bus();
                    in_Producto_Composicion_Bus busComposicion = new in_Producto_Composicion_Bus();

                    if (Bus_Producto.GrabarDB(Info_Producto, ref  idProducto, ref MensajeError))
                    {
                                              
                        lblIdProducto.Text = idProducto.ToString();
                        Info_Producto.IdProducto = idProducto;
                    
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
                        //string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                        MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);      
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
                System.GC.Collect();// junto al disposed 

                
                event_FrmIn_Producto_Mant_FormClosing += FrmIn_Producto_Mant_event_FrmIn_Producto_Mant_FormClosing;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucIn_Linea_Grup_SubGr.event_cmb_subgrupo_EditValueChanged += ucIn_Linea_Grup_SubGr_event_cmb_subgrupo_EditValueChanged;
                
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
                if (ucIn_Linea_Grup_SubGr.SubGrupoInfo !=null)
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

                if (MessageBox.Show("Esta seguro que desea eliminar el Item","Sistemas", MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes)
                {
                    
                    if (Anular()) 
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        MessageBox.Show("Anulacion Exitosa"); 
                    } else { MessageBox.Show("Error al anular "); }
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

                cmb_familia.Properties.DataSource = bus_familia.GetList(param.IdEmpresa);
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
             /*    
                List<in_Producto_Info> ls = new List<in_Producto_Info>();
                in_producto_Bus bus = new in_producto_Bus();
                ls = bus.Get_list_Producto(param.IdEmpresa);
                List<in_Producto_Info> itemComp = ls.FindAll(q => q.IdProducto != Convert.ToDecimal(lblIdProducto.Text));
                cmbProductoHijo_grid.DisplayMember = "pr_descripcion";
                cmbProductoHijo_grid.ValueMember = "IdProducto";
                cmbProductoHijo_grid.DataSource = itemComp;*/
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
                    if (item.Cantidad!= 0)
                    {
                        in_Producto_Composicion_Info info = new in_Producto_Composicion_Info();
                        info.IdEmpresa = param.IdEmpresa;
                        info.IdProductoPadre = Convert.ToDecimal(lblIdProducto.Text);
                        info.Cantidad = item.Cantidad;
                        info.IdProductoHijo =item.IdProductoHijo;

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
               
                if(Convert.ToDecimal(lblIdProducto.Text)==0)
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
                lsProductoBodega_Insert  = new List<in_producto_x_tb_bodega_Info>();
                lsProductoBodega_Update = new List<in_producto_x_tb_bodega_Info>();

                foreach (var item in lst_Bod_x_Suc)
                {
                    if (item.Nivel == 2)
                    {
                        in_producto_x_tb_bodega_Info info = new in_producto_x_tb_bodega_Info();
                        info.IdEmpresa = param.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdProducto = lblIdProducto.Text=="" ? 0 : Convert.ToInt32(lblIdProducto.Text);

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
                        info.IdCtaCble_CosBaseIva =item.IdCtaCble_CosBaseIva=="" ? null : item.IdCtaCble_CosBaseIva;
                        info.IdCtaCble_CosBase0 =item.IdCtaCble_CosBase0=="" ? null : item.IdCtaCble_CosBase0;
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
        
       
        private void FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmIn_Producto_Mant_FormClosing(sender, e, Info_Producto);
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
                lblIdProducto.Text = "";
                txtCodigo.Text = "";
                txtCodigoBarra.Text = "";
                txtObservacion.Text = "";
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Producto_Mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                disposed();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        ///  metodo para liberar memoria
        ///  se lo llama en el formclosed, pero es mas efectivo en el formclosing
        /// </summary>
        public void disposed()
        {
             try
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
