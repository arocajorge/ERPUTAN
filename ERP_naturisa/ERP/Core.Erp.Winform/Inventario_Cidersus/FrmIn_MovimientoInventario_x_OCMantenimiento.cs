using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Produc_Cirdesus ;
using Core.Erp.Business.Inventario_Cidersus;
using Cus.Erp.Reports.Cidersus;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.Produc_Cirdesus;
using Cus.Erp.Reports.Cidersus.Produccion;
using Core.Erp.Business.CuentasxPagar;


namespace Core.Erp.Winform.Inventario_Cidersus
{
    public partial class FrmIn_MovimientoInventario_x_OCMantenimiento : Form
    {
       
        public FrmIn_MovimientoInventario_x_OCMantenimiento()
        {
            try
            {
              InitializeComponent();
                cargacontrol();
                paramCus= BusParam.ObtenerObjeto(param.IdEmpresa);
                if (paramCus == null||paramCus.IdMovi_inven_tipo_ing_suc_princ == null)
                {
                   
                    MessageBox.Show("Parametrice el Movimiento de Ingreso de Inventario a Sucursal Principal");
                }
     

                UCSuc_Bod.Event_cmb_bodega_SelectedIndexChanged+=new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectedIndexChanged(UCSuc_Bod_Event_cmb_bodega_SelectedIndexChanged);
                UCSuc_Bod.Event_cmb_sucursal_SelectedIndexChanged  +=new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectedIndexChanged(UCSuc_Bod_Event_cmb_sucursal_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void UCProveedor_Event_ultraCmboE_Proveedor_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        void  UCSuc_Bod_Event_cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
 	           if(UCSuc_Bod.get_sucursal() != null)
                    infosuc  = UCSuc_Bod.get_sucursal();
                else 
                {
                    UCSuc_Bod.cmb_sucursal.Text ="";
                    MessageBox.Show("Seleccione una sucursal correcta");
                }
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //variables de los combos
        List<in_Producto_Info> ListadoProductos = new List<in_Producto_Info>();
        tb_Bodega_Info infobodega = new tb_Bodega_Info(); tb_Bodega_Bus BusBod = new tb_Bodega_Bus();
        tb_Sucursal_Info infosuc = new tb_Sucursal_Info();tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();
        UCIn_Sucursal_Bodega UCSuc_Bod = new UCIn_Sucursal_Bodega();
        cp_proveedor_Info infoprove= new cp_proveedor_Info();
        com_ordencompra_local_Bus busOC = new com_ordencompra_local_Bus();
        
        in_producto_Bus Busprod = new in_producto_Bus();
        
        // variables Tabla de OC Detalle
        List<com_ordencompra_local_det_Info> LstDetOC = new List<com_ordencompra_local_det_Info>();
        com_ordencompra_local_det_Bus BusDetOC = new com_ordencompra_local_det_Bus();
        
        //variables Tabla Mov Inv x items
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstDetMovi = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus BusDetxProd = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        
        // variables Tabla Intermedia
        in_movi_inve_detalle_x_com_ordencompra_local_det_Bus BusTAbInt = new in_movi_inve_detalle_x_com_ordencompra_local_det_Bus();
        
        //variables de Table Mov Inv Detalle
        in_movi_inve_detalle_Bus BusDetMOvINv = new in_movi_inve_detalle_Bus();
        List<in_movi_inve_detalle_Info> LStDet = new List<in_movi_inve_detalle_Info>();

        //variables de Table Mov Inv 
        in_movi_inve_Bus BusCabMOvINv = new in_movi_inve_Bus();
        in_movi_inve_Info InfoCabMovInv = new in_movi_inve_Info();
        in_producto_x_tb_bodega_Info InfoProdxBod = new in_producto_x_tb_bodega_Info();

        //variables de instancia
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action(); cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_proveedor_Bus BusProveedor = new cp_proveedor_Bus();
        #endregion
        void  UCSuc_Bod_Event_cmb_bodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(UCSuc_Bod.get_bodega() != null)
                    infobodega = UCSuc_Bod.get_bodega();
                else 
                {
                    UCSuc_Bod.cmb_bodega.Text ="";
                    MessageBox.Show("Seleccione una bodega correcta");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        #region delegado

        private void FrmIn_MovientoInventario_x_OCMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                Event_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing += new Delegate_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing(FrmIn_MovientoInventario_x_OCMantenimiento_Event_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing);
               
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
         
        }

        void FrmIn_MovientoInventario_x_OCMantenimiento_Event_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing(object sender, FormClosingEventArgs e){}
        public delegate void Delegate_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing Event_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing;
        
        private void FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              Event_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        #endregion
        
        void cargacontrol()
        {
            try
            {
                UCSuc_Bod.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                UCSuc_Bod.cargar_sucursal(param.IdEmpresa);
                UCSuc_Bod.cmb_sucursal.EditValue = 1;
                UCSuc_Bod.Dock = DockStyle.Bottom;
                PanelSuc_bodega.Controls.Add(UCSuc_Bod);
                //UCProveedor.cargaproveedor(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

            
        }

        void cargagrid(int IdProveedor)
        {
            try
            {// cargo los producto

               
                //prod = Busprod.BuscarProducto(item.IdProducto, item.IdEmpresa);
                ListadoProductos = Busprod.Get_list_Producto(param.IdEmpresa);



                    List<com_ordencompra_local_det_Info> temp = new List<com_ordencompra_local_det_Info>();

                    com_ordencompra_local_Bus busOC = new com_ordencompra_local_Bus();
                    LstDetOC = BusDetOC.Get_List_OC_local_det_x_Saldos_x_Proveedor_x_Obra_x_OT(param.IdEmpresa, UCSuc_Bod.get_sucursal().IdSucursal, ucCp_Proveedor.get_ProveedorInfo().IdProveedor);
                    LstDetOC = LstDetOC.FindAll(var =>  
                        var.SaldoxRecibir > 0);
                    int sec = 1;
                    LstDetOC.ForEach(var => { var.producto = Busprod.Get_DescripcionTot_Producto(var.IdEmpresa, var.IdProducto); var.mv_observacion = ""; var.mv_sec = sec++; var.dm_cantidad = 0; var.oc_NumDocumento = "[" + var.IdOrdenCompra + "/" + var.oc_NumDocumento + "]"; });

                    gridCtrlMoviInvDet.DataSource = LstDetOC;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
            
           

        }

        public void set_Action(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;

                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       
                        this.coldm_cantidad.Visible = false;
                        txtID.Text = Convert.ToString(BusCabMOvINv.GetMovimientIngresoEmpresa(param.IdEmpresa));
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        
                        this.coldm_cantidad_pendiente.Visible = false;
                        this.coldm_cantidad1.Visible = false;
                        this.coldm_cantidad.OptionsColumn.AllowEdit = false;
                        this.coldm_observacion.OptionsColumn.AllowEdit = false;
                        this.coldm_cantidad.Visible = true;
                       
                        
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ;
                        this.coldm_cantidad_pendiente.Visible = false;
                        this.coldm_cantidad1.Visible = false;
                        this.coldm_cantidad.OptionsColumn.AllowEdit = false;
                        this.coldm_observacion.OptionsColumn.AllowEdit = false;
                        this.coldm_cantidad.Visible = true;
                       
                        
                       
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

        public void setcab(in_movi_inve_Info Info)
        {
            try
            {
                    InfoCabMovInv = Info;
                    txtID.Text  = Convert.ToString(Info.IdNumMovi);
                    infobodega.IdSucursal = Info.IdSucursal;
                    infobodega.IdBodega = infobodega.IdBodega;
                    ucCp_Proveedor.set_ProveedorInfo(Convert.ToDecimal( Info.IdProvedor));
                    UCSuc_Bod.cmb_sucursal.EditValue = Info.IdSucursal;
                   // UCSuc_Bod.cmb_sucursal.SelectedItem  = Info.IdSucursal;
                    UCSuc_Bod.cmb_bodega.EditValue = Info.IdBodega;
                   // UCSuc_Bod.cmb_bodega.SelectedItem = Info.IdBodega;
                    dtPfecha.Value = Convert.ToDateTime(Info.Fecha_Transac);
                    txtGuiaDesp.Text = Info.NumDocumentoRelacionado;
                    txtFact.Text = Info.NumFactura;
                    txtObservacion.Text = Info.cm_observacion;
                    if (Info.Estado == "I") lblAnulado.Visible = true; else lblAnulado.Visible = false;
                    LStDet = new List<in_movi_inve_detalle_Info>();
                    LStDet  = BusDetMOvINv.Get_list_Movi_inven_det(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdMovi_inven_tipo, Info.IdNumMovi);
                    int sec = 1;
                    com_ordencompra_local_Bus busOC = new com_ordencompra_local_Bus();
                    LstDetOC = new List<com_ordencompra_local_det_Info>();
                    foreach (var item in LStDet)
                    {
                        com_ordencompra_local_det_Info DetOC = new com_ordencompra_local_det_Info();
                        in_movi_inve_detalle_x_com_ordencompra_local_det_Info InfoTabInt = new in_movi_inve_detalle_x_com_ordencompra_local_det_Info();
                        InfoTabInt = BusTAbInt.Get_Info_in_movi_inve_detalle_x_com_ordencompra_local_det(item);
                        DetOC = BusDetOC.Get_Info_ordencompra_local_det(InfoTabInt.ocd_IdEmpresa, InfoTabInt.ocd_IdSucursal, InfoTabInt.ocd_IdOrdenCompra, InfoTabInt.ocd_Secuencia);
                        var OC = busOC.Get_Info_ordencompra_local(InfoTabInt.ocd_IdEmpresa, InfoTabInt.ocd_IdSucursal, InfoTabInt.ocd_IdOrdenCompra);
                        if (OC != null)
                        {
                            DetOC.oc_observacion = OC.oc_observacion;
                            DetOC.oc_NumDocumento = OC.oc_NumDocumento;
                            DetOC.UsuarioAprueba = OC.IdUsuario_Aprueba;
                            DetOC.FechaAprob = Convert.ToDateTime(OC.co_fecha_aprobacion);
                        }
                        DetOC.do_CantidadOC = DetOC.do_Cantidad;
                        DetOC.dm_cantidad_Inv = item.dm_cantidad;
                        DetOC.mv_observacion = item.dm_observacion;
                        DetOC.producto = Busprod.Get_DescripcionTot_Producto(DetOC.IdEmpresa, DetOC.IdProducto);
                        DetOC.oc_NumDocumento = "[" + DetOC.IdOrdenCompra + "/" + DetOC.oc_NumDocumento + "]";
                
                        DetOC.mv_sec = sec++;
                        LstDetOC.Add(DetOC);
 
                    }

                    gridCtrlMoviInvDet.DataSource = LstDetOC;
                    LstDetMovi = BusDetxProd.ConsultaxMovInvTipo(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdNumMovi, Info.IdMovi_inven_tipo);
            

                    List<vwIn_Movi_Inven_CusCider_Cab_Info> LstMov = new List<vwIn_Movi_Inven_CusCider_Cab_Info>();

                    LstMov = BusDetxProd.ConsultaMovimientos(InfoCabMovInv.IdEmpresa,
                        InfoCabMovInv.IdSucursal, InfoCabMovInv.IdBodega, InfoCabMovInv.IdNumMovi, InfoCabMovInv.IdMovi_inven_tipo);
            
                    gridCtrlMov.DataSource = LstMov;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
           
        
        }

        in_producto_x_tb_bodega_Bus BusProdxBod = new in_producto_x_tb_bodega_Bus();
        prd_parametros_CusCidersus_Bus BusParam = new prd_parametros_CusCidersus_Bus();
        prd_parametros_CusCidersus_Info paramCus = new prd_parametros_CusCidersus_Info();
        private Boolean  validaciones()
        {
            try
            {
                cp_proveedor_Info provee = new cp_proveedor_Info();
                //provee = UCProveedor.getitem();
                if (UCSuc_Bod.get_sucursal() == null)
                {
                    MessageBox.Show("Debe seleccionar una Sucursal para la Recepcion de Material ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    UCSuc_Bod.cmb_sucursal.Focus(); return false;

                }
                else if (UCSuc_Bod.get_bodega () == null)
                {
                    MessageBox.Show("Debe seleccionar una Bodega para la Recepcion de Material.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    UCSuc_Bod.cmb_bodega.Focus(); return false;

                }
                //else if (UCProveedor.getitem() == null || UCProveedor.ultraCmboE_Proveedor.Text == "")
                //{
                //    MessageBox.Show("Debe seleccionar un Proveedorpara la Recepcion de Material.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //    UCProveedor.ultraCmboE_Proveedor.Focus(); return false;

                //}
                else if (txtGuiaDesp.Text =="")
                {
                    MessageBox.Show("Ingrese #Guia de Despacho para la Recepcion de Material.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtGuiaDesp.Focus(); return false;

                }
              
                //else if (txtFact.Text == "")
                //{
                //    MessageBox.Show("Ingrese #Fact para la Recepcion de Material.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //    txtFact.Focus(); return false;

                //}
                else if (txtObservacion.Text == "")
                {
                    MessageBox.Show("Ingrese una Observación para la Recepcion de Material.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtObservacion.Focus(); return false;

                }
                else if (LstDetOC.Count > 0)
                {
                    Boolean flag = false;
                    foreach (var item in LstDetOC)
                    {
                        if (item.dm_cantidad >= 0 && item.SaldoxRecibir >= item.dm_cantidad)
                            flag = true;
                        else
                        { flag = false; break; }

                        InfoProdxBod = new in_producto_x_tb_bodega_Info();
                        InfoProdxBod = BusProdxBod.Get_Info_Producto_x_Producto(param.IdEmpresa, UCSuc_Bod.get_sucursal().IdSucursal, UCSuc_Bod.get_bodega().IdBodega, item.IdProducto);
                        if (InfoProdxBod == null)
                        {
                            MessageBox.Show("El producto "+Busprod.Get_DescripcionTot_Producto(param.IdEmpresa,item.IdProducto) +
                                " no está asignado a la Bodega" +UCSuc_Bod.get_bodega().bo_Descripcion , "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                    }
                    if (flag == false)
                    {
                        MessageBox.Show("Verifique las unidades que esta ingresando en la Recepcion de Material.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gridCtrlMoviInvDet.Focus(); return false;
                    }

                    try
                    {
                        var row = LstDetOC.First(var => var.dm_cantidad > 0);
                       
                    }
                    catch (Exception ex)
                    {

                        Log_Error_bus.Log_Error(ex.ToString());
                        MessageBox.Show("No hay valores para registrar, verifique las unidades a registrar.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridCtrlMoviInvDet.Focus(); return false;
                    } 

                }
                else
                {
                    MessageBox.Show("No hay valores para registrar.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridCtrlMoviInvDet.Focus(); return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false ;
            }
          
 
        
        
        }

        private Boolean getInfo()
        {
            try
            {
                InfoCabMovInv = new in_movi_inve_Info();
                //datos de la cabecera
                InfoCabMovInv.IdEmpresa = param.IdEmpresa;
                InfoCabMovInv.IdSucursal = UCSuc_Bod.get_sucursal().IdSucursal;
                InfoCabMovInv.IdBodega = UCSuc_Bod.get_bodega().IdBodega;
                InfoCabMovInv.Fecha_Transac = param.Fecha_Transac;
                InfoCabMovInv.IdProvedor = ucCp_Proveedor.get_ProveedorInfo().IdProveedor;
                InfoCabMovInv.IdMovi_inven_tipo  = Convert.ToInt32(paramCus.IdMovi_inven_tipo_ing_suc_princ);
                InfoCabMovInv.cm_observacion = txtObservacion.Text + " Ing Bod FAC.#" + txtFact.Text;
                InfoCabMovInv.NumDocumentoRelacionado = txtGuiaDesp.Text;
                InfoCabMovInv.NumFactura = txtFact.Text;
                InfoCabMovInv.cm_anio = InfoCabMovInv.Fecha_Transac.Value.Year;
                InfoCabMovInv.cm_fecha = dtPfecha.Value;
                InfoCabMovInv.cm_mes = InfoCabMovInv.Fecha_Transac.Value.Month;
                InfoCabMovInv.cm_tipo = "+";
                InfoCabMovInv.IdUsuario = param.IdUsuario;
                InfoCabMovInv.Estado = "A";

                //datos del detalle
                List<com_ordencompra_local_det_Info> TempLstDetOC = new List<com_ordencompra_local_det_Info>();
                LstDetOC = new List<com_ordencompra_local_det_Info>();
                TempLstDetOC = (List<com_ordencompra_local_det_Info>)gridCtrlMoviInvDet.DataSource;
                int sec = 0;

                //los datos de la grilla lo pasamos a la Lista del Detalle de O/C
                foreach (var item in TempLstDetOC)
                {
                    if (item.dm_cantidad > 0)
                    {

                        item.mv_sec = ++sec;
                        LstDetOC.Add(item);
                    
                    }
                }

                sec = 0;
                //los datos de la Lista del Detalle de O/C lo pasamos al Detalle del Movi Inventario
                LStDet = new List<in_movi_inve_detalle_Info>();
                foreach (var item in LstDetOC)
                {
                    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info ();
                    info.IdEmpresa = InfoCabMovInv.IdEmpresa; 
                    info.IdSucursal = InfoCabMovInv.IdSucursal;
                    info.IdBodega = InfoCabMovInv.IdBodega;
                    info.IdMovi_inven_tipo = Convert.ToInt32(paramCus.IdMovi_inven_tipo_ing_suc_princ); 
                    info.Secuencia = item.mv_sec;
                    info.oc_IdEmpresa = item.IdEmpresa;
                    info.oc_IdOrdenCompra = item.IdOrdenCompra;
                    info.oc_IdSucursal = item.IdSucursal;
                    info.oc_Secuencial = item.Secuencia;
                    info.oc_NumDocumento = item.oc_NumDocumento;
                    info.mv_tipo_movi = "+";
                    info.IdProducto = item.IdProducto;
                    info.dm_cantidad = item.dm_cantidad;
                    var prodxbod = BusProdxBod.Get_Info_Producto_x_Producto(param.IdEmpresa,InfoCabMovInv.IdSucursal , InfoCabMovInv.IdBodega ,item.IdProducto);
                    info.dm_stock_ante = prodxbod.pr_stock;
                    info.dm_stock_actu = prodxbod.pr_stock + item.dm_cantidad;

                    var prod = Busprod.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                    InfoCabMovInv.cm_observacion = txtObservacion.Text + " Ing Bod FAC.#" + txtFact.Text;
                    info.dm_precio = prod.pr_precio_publico;
                    info.mv_costo = prod.pr_costo_promedio;
                    info.CodObra_preasignada = item.CodObra_preasignada;
                    info.IdOrdenTaller_preasignada = item.IdOrdenTaller_preasignada;

                    LStDet.Add(info);
                    
                }

                InfoCabMovInv.listmovi_inve_detalle_Info = LStDet;

                //los datos del Detalle del Movi Inventario lo pasamos a la Lista de Detalle x items
               
                LstDetMovi = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                foreach (var item in LStDet)
                {
                    sec = 0;
                    for (int i = 0; i < item.dm_cantidad; i++)
                    {                         
                        in_Producto_Info infoSle = new in_Producto_Info();

                         infoSle =   ListadoProductos.FirstOrDefault(V=>V.IdProducto == item.IdProducto);
                        if (infoSle.pr_ManejaSeries == "S")
                        {
                            sec = sec + 1;
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = InfoCabMovInv.IdEmpresa;
                            info.IdSucursal = InfoCabMovInv.IdSucursal;
                            info.IdBodega = InfoCabMovInv.IdBodega;
                            info.IdMovi_inven_tipo = Convert.ToInt32(paramCus.IdMovi_inven_tipo_ing_suc_princ); 
                            info.mv_tipo_movi = "+";
                            info.mv_Secuencia = item.Secuencia;
                            info.Secuencia = sec;
                            if (txtID.Text != "")
                            {
                                info.IdNumMovi = Convert.ToUInt32(txtID.Text);
                            }
                            else
                            {
                                info.IdNumMovi = 0;
                            }
                            info.IdProducto = item.IdProducto;
                            info.dm_cantidad = 1;
                            info.dm_observacion = item.dm_observacion;
                            info.dm_precio = infoSle.pr_precio_publico == null ? 0 : Convert.ToDouble(infoSle.pr_precio_publico);
                            info.mv_costo = infoSle.pr_costo_promedio == null ? 0 : Convert.ToDouble(infoSle.pr_costo_promedio);
                            info.CodObra_preasignada = item.CodObra_preasignada;
                            info.IdOrdenTaller_preasignada = item.IdOrdenTaller_preasignada;
                            LstDetMovi.Add(info);
                        }
                    }
                   
                }


                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            } 
        
        }

        private Boolean grabar()
        {
            try
            {
                decimal idMoviInven =0;
                txtObservacion.Focus();
                string msg="";
                string mensaje_cbte_cble = "";
                decimal idOrdenCompra = 0;
                string NumGuiaProveedor = "";
                string NumFacturaProveedor = "";

                if (validaciones() == false)
                {
                    MessageBox.Show("No se guardó", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {  // SI SE GRABA CABECERA Y DETALLE DE LAS TABLAS in_movi_inve Y in_movi_inve_detalle
                    getInfo();
                    if (BusCabMOvINv.GrabarDB(InfoCabMovInv, ref idMoviInven,ref mensaje_cbte_cble, ref msg))
                    {
                        InfoCabMovInv.IdNumMovi = idMoviInven;
                        NumGuiaProveedor = InfoCabMovInv.NumDocumentoRelacionado;
                        NumFacturaProveedor = InfoCabMovInv.NumFactura;
                        // SI GRABA EN LA TABLA in_movi_inve_detalle_x_com_ordencompra_local_det
                            if (BusTAbInt.GuardarDB(LStDet))
                            {

                                foreach (var item in LStDet)
                                {
                                    var OC = busOC.Get_Info_ordencompra_local(item.IdEmpresa, item.oc_IdSucursal, item.oc_IdOrdenCompra);
                                    OC.IdEstadoRecepcion_cat = "REC";
                                    busOC.ModificarDB(OC, ref msg);
                                    idOrdenCompra = item.oc_IdOrdenCompra;
                                    
                                }
                                // GRABA TABLA INTERMEDIA
                                foreach (var item in LstDetMovi)
                                {
                                    item.IdNumMovi = idMoviInven;
                                    item.ocd_IdOrdenCompra = idOrdenCompra;
                                    item.NumFacturaProveedor = NumFacturaProveedor;
                                    item.NumDocumentoRelacionadoProveedor = NumGuiaProveedor;
                                }
                                if (BusDetxProd.GuardarDB(LstDetMovi,ref msg))
                                {
                                    if (BusProdxBod.ActualizarStock_x_Bodega_con_moviInven(LStDet, ref msg))
                                    {
                                        this.txtID.Text = Convert.ToString(idMoviInven);
                                        MessageBox.Show("Se ha realizado correctamente la transacción #: " + idMoviInven.ToString(), "Operación Exitosa");
                                        setcab(InfoCabMovInv);
                                        set_Action(Cl_Enumeradores.eTipo_action.consultar);
                                        imprimircodigo();
                                       
                                    }
                                }
                            }
                    
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
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


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
              this.grabar();
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
              imprimircodigo();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void imprimircodigo()
        {
            try
            {
                if (LstDetMovi.Count > 0)
                {
                    if (MessageBox.Show("¿Se procedera a  imprimir los codigos de barra de los productos especiales?", "Impresión de Codigo de Barra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        //-- CARLOS ACTALIZACION

                        List<XPRO_CUS_CID_Rpt001_Info> listData = new List<XPRO_CUS_CID_Rpt001_Info>();
                        XPRO_CUS_CID_Rpt001_Bus Bus_Codigo_barra = new XPRO_CUS_CID_Rpt001_Bus();
                        listData = Bus_Codigo_barra.Get_Codigo_Barra(param.IdEmpresa, InfoCabMovInv.IdSucursal, InfoCabMovInv.IdBodega,
                        InfoCabMovInv.IdMovi_inven_tipo,Convert.ToInt32( InfoCabMovInv.IdNumMovi));
                        XPRO_CUS_CID_Rpt001 CRpt = new XPRO_CUS_CID_Rpt001();
                        CRpt.loadData(listData);
                        CRpt.ShowPreviewDialog();
                    }
                }

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                    {
                        LstDetOC.ForEach(var => var.dm_cantidad = var.SaldoxRecibir);
                        //coldm_cantidad1.OptionsColumn.AllowEdit = false;
                        gridCtrlMoviInvDet.DataSource = null;
                        gridCtrlMoviInvDet.DataSource = LstDetOC;
                
 
                    }
                    else
                    {
                        //coldm_cantidad1.OptionsColumn.AllowEdit = true;
                        LstDetOC.ForEach(var => var.dm_cantidad = 0);
                        gridCtrlMoviInvDet.DataSource = null;
                        gridCtrlMoviInvDet.DataSource = LstDetOC;
                    }
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

       

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
              imprimircodigo();

            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridVwMoviInvDet_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                    gridVwMoviInvDet.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void mnu_anular_Click(object sender, EventArgs e)
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

        void anular()
        {


            try
            {
                if (InfoCabMovInv != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (InfoCabMovInv.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular la Recepcion de Materiales No: "
                            + InfoCabMovInv.IdNumMovi + " ?",
                            "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();
                            InfoCabMovInv.cm_observacion = oFrm.motivoAnulacion +"***ANULADO****" + InfoCabMovInv.cm_observacion;
                            InfoCabMovInv.IdusuarioUltAnu = param.IdUsuario;
                            InfoCabMovInv.Fecha_UltAnu = DateTime.Now;

                            if (BusCabMOvINv.AnularDB(InfoCabMovInv,Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref msg))
                            {
                                var prodxitrems = BusDetxProd.ConsultaxMovInvTipo(InfoCabMovInv.IdEmpresa, InfoCabMovInv.IdSucursal,
                                    InfoCabMovInv.IdBodega, InfoCabMovInv.IdNumMovi, InfoCabMovInv.IdMovi_inven_tipo);
                                if (prodxitrems != null)
                                {
                                    if (BusDetxProd.AnularDB(InfoCabMovInv.IdEmpresa, InfoCabMovInv.IdSucursal,
                                       InfoCabMovInv.IdBodega, InfoCabMovInv.IdNumMovi, InfoCabMovInv.IdMovi_inven_tipo, ref msg))
                                    {
                                        MessageBox.Show("Anulado con exito  la Recepcion de Materiales No:" + InfoCabMovInv.IdNumMovi);
                                        InfoCabMovInv.Estado = "I";

                                        lblAnulado.Visible = true;
                                        set_Action(Cl_Enumeradores.eTipo_action.consultar);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Anulado con exito la Recepcion de Materiales No:  "
                                        + InfoCabMovInv.IdNumMovi);
                                    InfoCabMovInv.Estado = "I";

                                    lblAnulado.Visible = true;
                                    set_Action(Cl_Enumeradores.eTipo_action.consultar);
                                }
                            }

                        }


                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular la Recepcion de Materiales No: " + InfoCabMovInv.IdNumMovi + " debido a que ya se encuentra anulado", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());

            }
        }

        private void mnu_printAju_Click(object sender, EventArgs e)
        {
            try
            {
                //-- CARLOS ACTALIZACION


                //XPRO_CUS_CID_Rpt008 XReport = new XPRO_CUS_CID_Rpt008();
                //List<tbPRO_CUS_CID_Rpt008_Info> data = new List<Info.Produc_Cirdesus.tbPRO_CUS_CID_Rpt008_Info>();
                //prd_ObtenerReporte_Bus busSpRpt = new Business.Produc_Cirdesus.prd_ObtenerReporte_Bus();

                //data = busSpRpt.OptenerData_spPRD_Rpt_RPRD008(param.IdEmpresa, InfoCabMovInv.IdSucursal, InfoCabMovInv.IdBodega,
                //    InfoCabMovInv.IdMovi_inven_tipo, InfoCabMovInv.IdNumMovi,param.IdUsuario, param.nom_pc);
                //XReport.loadData(data.ToArray());
                //XReport.ShowPreviewDialog();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }


        private void cmbProveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

                MessageBox.Show(ex.Message);
            }
        }

        private void ucCp_Proveedor_event_cmb_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargagrid(Convert.ToInt32( ucCp_Proveedor.get_ProveedorInfo().IdProveedor));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                grabar();
                   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                imprimircodigo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

      
       
    }
}
