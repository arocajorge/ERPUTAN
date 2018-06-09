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
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Winform.Produc_Cirdesus;
namespace Core.Erp.Winform.Inventario_Cidersus
{
    public partial class frmIn_EgresoInventario_x_Produccion_Mantenimiento : Form
    {
        #region variables
        in_movi_inve_detalle_x_Producto_CusCider_Bus BusCodBAr = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info> LstSaldoxOT = new List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info>();
        List<in_movi_inve_detalle_Info> LstProdGrid = new List<in_movi_inve_detalle_Info>();
        in_producto_Bus busProducto = new in_producto_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Bodega_Info _bodegaInfo = new tb_Bodega_Info();
        tb_Sucursal_Info _sucursalInfo = new tb_Sucursal_Info();
        prd_parametros_CusCidersus_Info paramCidersus = new prd_parametros_CusCidersus_Info();
        prd_parametros_CusCidersus_Bus Busparam = new prd_parametros_CusCidersus_Bus();
        tb_Bodega_Bus BusBod = new tb_Bodega_Bus();
        tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();
        prd_OrdenTaller_Bus busOT = new prd_OrdenTaller_Bus();
        prd_OrdenTaller_Info OT = new prd_OrdenTaller_Info();
        in_movi_inve_Info MovEgreso = new in_movi_inve_Info();
        in_movi_inve_Info MovIngreso = new in_movi_inve_Info();
        List<in_movi_inve_detalle_Info> LstDetMovIngreso = new List<in_movi_inve_detalle_Info>();
        List<in_movi_inve_detalle_Info> LstDetMovEgreso = new List<in_movi_inve_detalle_Info>();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info > LstDetxItemsIng = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstDetxItemsEgr = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        in_movi_inve_Bus BusMov = new in_movi_inve_Bus();
        in_movi_inve_detalle_Bus BusMovDet = new in_movi_inve_detalle_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Bus BusDetxItems = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        BindingList<in_movi_inve_detalle_Info> Grid = new BindingList<in_movi_inve_detalle_Info>();
        UCPrd_Obra UCObra = new UCPrd_Obra();
        List<vwprd_Ensamblado_CabDet_CusCider_Info> LstEnsab = new List<vwprd_Ensamblado_CabDet_CusCider_Info>();
        prd_Ensamblado_CusCider_Bus BusEnsa = new prd_Ensamblado_CusCider_Bus();
        BindingList<in_movi_inve_detalle_Info> ListadoDisponible = new BindingList<in_movi_inve_detalle_Info>();
        in_movi_inven_x_in_movi_inven_CusCidersus_Bus busTI = new in_movi_inven_x_in_movi_inven_CusCidersus_Bus();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListTI = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        List<in_movi_inve_Info> LstConsultaMovi = new List<in_movi_inve_Info>();
        Cl_Enumeradores.eTipo_action iAccion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_movi_inve_detalle_Info agregado = new in_movi_inve_detalle_Info();
        List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> ListadoProductos = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
        in_producto_x_tb_bodega_Bus Bus_prodxbod = new in_producto_x_tb_bodega_Bus();
        tb_Bodega_Bus busbod = new tb_Bodega_Bus();
        prd_ProcesoProductivo_Bus ProcesPBus = new prd_ProcesoProductivo_Bus();
        List<prd_ProcesoProductivo_Info> ListProcesoP = new List<Info.Produc_Cirdesus.prd_ProcesoProductivo_Info>();
        public delegate void delegate_frmIn_EgresoInventario_x_Produccion_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmIn_EgresoInventario_x_Produccion_Mantenimiento_FormClosing event_frmIn_EgresoInventario_x_Produccion_Mantenimiento_FormClosing;
        string mensaje = "";
        #endregion

        public frmIn_EgresoInventario_x_Produccion_Mantenimiento()
        {
            try
            {
                InitializeComponent();
                cargacontroles();
                paramCidersus = Busparam.ObtenerObjeto(param.IdEmpresa);

                ctrl_Sucbod.Event_cmb_sucursal_SelectedIndexChanged += ctrl_Sucbod_Event_cmb_sucursal_SelectedIndexChanged;
                //ctrl_Sucbod.Event_cmb_bodega_SelectedIndexChanged += ctrl_Sucbod_Event_cmb_bodega_SelectedIndexChanged;
               
                UCObra.Event_UCObra_SelectionChanged += UCObra_Event_UCObra_SelectionChanged;
                UCObra.Event_UCObra_Validating += UCObra_Event_UCObra_Validating;
                ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                this.event_frmIn_EgresoInventario_x_Produccion_Mantenimiento_FormClosing +=
                    frmIn_EgresoInventario_x_Produccion_Mantenimiento_event_frmIn_EgresoInventario_x_Produccion_Mantenimiento_FormClosing;
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

           
        }

        void cargadisponible()
        {
            try
            {
                if (iAccion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    getSucBod();

                    /////// SE CAMBIA DE SaldosxItemsxCodBarra POR ObtenerMateriaPrima
                    ListadoProductos = BusDetxItems.SaldosxItemsxCodBarra(param.IdEmpresa, dtpFecha.Value, ctrl_Sucbod.get_bodega().IdBodega, ctrl_Sucbod.get_sucursal().IdSucursal);
                    ////REVISAR SI SE USA SaldosxItemsxCodBarra o SaldosxItemsxCodBarra_x_Obra
                    //ListadoProductos = BusDetxItems.SaldosxItemsxCodBarra_x_Obra(param.IdEmpresa, dtpFecha.Value, ctrl_Sucbod.get_sucursal().IdSucursal, ctrl_Sucbod.get_bodega().IdBodega, UCObra.get_item());

                    //ListadoProductos = BusDetxItems.SaldosxItemsxCodBarraxOT(param.IdEmpresa, dtpFecha.Value, ctrl_Sucbod.get_sucursal().IdSucursal, ctrl_Sucbod.get_bodega().IdBodega, UCObra.get_item(), Convert.ToInt32(CmbOrdenTaller.EditValue));
                    
                                       gridControlDisponible.DataSource = ListadoProductos;
                    gridControlDisponible.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void frmIn_EgresoInventario_x_Produccion_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                if (Cl_Enumeradores.eTipo_action.grabar == iAccion)
                {
                    // LOS ELEMENTOS DISPONIBLES DEBEN DE CARGAR CUANDO SE ELIJA LA OT
                    //cargadisponible();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }            
        }
        private void frmIn_EgresoInventario_x_Produccion_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               event_frmIn_EgresoInventario_x_Produccion_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        void frmIn_EgresoInventario_x_Produccion_Mantenimiento_event_frmIn_EgresoInventario_x_Produccion_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e){}
        void UCObra_Event_UCObra_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (UCObra.get_item_info() == null)
                {
                    CmbOrdenTaller.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        void cargalistadodisponible()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
                
            }
        
        
        }
        void cargacmbot()
        {
            try
            {
                if (!string.IsNullOrEmpty(Convert.ToString(ctrl_Sucbod.cmb_sucursal.EditValue)))
                {
                    List<prd_OrdenTaller_Info> lstOt = new List<prd_OrdenTaller_Info>();
                    lstOt = busOT.ObtenerListaOT(param.IdEmpresa).FindAll(var =>var.IdSucursal == Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue)
                                && var.CodObra == UCObra.get_item());
                    CmbOrdenTaller.Properties.DataSource = lstOt;

                    ListProcesoP = ProcesPBus.ObtenerProcesProductivo(param.IdEmpresa);
                    CmbProcesoProductivo.Properties.DataSource = ListProcesoP;
                }                     
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
                cargacmbot();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }
        void ctrl_Sucbod_Event_cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cargacmbot();
                cargadisponible();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }               
        void getSucBod()
        {

            try
            {
                _sucursalInfo = ctrl_Sucbod.get_sucursal();
                _bodegaInfo = ctrl_Sucbod.get_bodega();
            }
            catch (Exception ex)
            {                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message); 
            }
        }       
        void cargacontroles()
        {
            try
            {
                
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
        public void set_Accion(Cl_Enumeradores.eTipo_action Accion)
        {

            try
            {
                iAccion = Accion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;

                        bloquearcamposconsulta();


                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        bloquearcamposconsulta();

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
        void bloquearcamposconsulta()
        {
            try
            {

                ctrl_Sucbod.cmb_bodega.Enabled = false;
                ctrl_Sucbod.cmb_sucursal.Enabled = false;
                CmbOrdenTaller.Enabled = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }              
        public void setCab(in_movi_inve_Info Info)
        {
            try
            {
                MovEgreso = Info;
                ctrl_Sucbod.cmb_sucursal.EditValue = Info.IdSucursal;
                ctrl_Sucbod.cmb_bodega.EditValue = Info.IdBodega;
                LstProdGrid = BusCodBAr.ConsultaGeneral(Info);
                gridControlDisponible.DataSource = LstProdGrid;
                in_movi_inve_detalle_Info inf = new in_movi_inve_detalle_Info();
                inf = LstProdGrid.FirstOrDefault();              
                UCObra.set_item(inf.ot_CodObra);
                CmbOrdenTaller.EditValue = inf.ot_IdordenTaller;
                txtObservacion.Text = inf.observacion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
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
        public string msg = "";        
        string autoriza = "";
        private Boolean PedirAutorizacion()
        {
            try
            {
                frmPrd_UsuarioAutoriza frm = new frmPrd_UsuarioAutoriza();
                frm.ShowDialog();
                autoriza = frm.Usuario;
                return frm.Autorizado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }
        private void gridLkUOrdenTaller_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LstSaldoxOT = new List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info>();
                getSucBod();
                if (CmbOrdenTaller.EditValue != "")
                {
                    LstSaldoxOT = BusDetxItems.DisponiblesxReqOt(param.IdEmpresa, UCObra.get_item(), _sucursalInfo.IdSucursal,
                               Convert.ToDecimal(CmbOrdenTaller.EditValue), ref msg);
                    if (LstSaldoxOT != null)
                    {
                        LstSaldoxOT.ForEach(var => var.saldo = (var.saldo == null) ? var.ped_saldo : var.saldo);
                    }
                    

                    cargadisponible();

                    prd_OrdenTaller_Bus BusOT = new prd_OrdenTaller_Bus();
                    OT = BusOT.ObtenerUnaOT(param.IdEmpresa, ctrl_Sucbod.get_sucursal().IdSucursal,
                        Convert.ToDecimal(CmbOrdenTaller.EditValue), UCObra.get_item());
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               // MessageBox.Show(ex.InnerException.ToString());
                
            }
            
        }
        private Boolean validar()
       {
     try
     {
         if (UCObra.get_item_info() == null)
         {
             MessageBox.Show("Debe seleccionar la Obra Asignada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             panelObra.Focus();
             return false;
         }
         else if (CmbOrdenTaller.EditValue == null)
         {
             MessageBox.Show("Debe seleccionar la Orden de Taller Asignada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             CmbOrdenTaller.Focus();
             return false;
         }
         else
             return true;
     }
     catch (Exception ex)
     {
         Log_Error_bus.Log_Error(ex.ToString());
         return false;

     }

 }                 
        private Boolean getCab()
        {
            try
            {
                MovEgreso = new in_movi_inve_Info();
                MovEgreso.Idobra = UCObra.get_item_info().CodObra;
                MovEgreso.IdordenTaller =Convert.ToInt32( CmbOrdenTaller.EditValue);
                MovIngreso.IdEmpresa = MovEgreso.IdEmpresa = param.IdEmpresa;
                MovEgreso.IdSucursal = _sucursalInfo.IdSucursal;
                MovIngreso.IdSucursal = paramCidersus.IdSucursal_Produccion;
                MovEgreso.IdBodega = _bodegaInfo.IdBodega;
                MovIngreso.IdBodega = paramCidersus.IdBodega_Produccion;
                MovIngreso.cm_anio =  MovEgreso.cm_anio = dtpFecha.Value.Year;
                MovIngreso.cm_fecha= MovEgreso.cm_fecha = dtpFecha.Value;
                MovIngreso.cm_mes = MovEgreso.cm_mes = dtpFecha.Value.Month;
                MovEgreso.cm_tipo = "-";
                MovIngreso.cm_tipo = "+";
                MovIngreso.Estado = MovEgreso.Estado = "A";
                MovEgreso.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_egr_consumoprod);
                MovIngreso.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_ing_consumoprod);

                var bod = busbod.Get_Info_Bodega(param.IdEmpresa,
                    paramCidersus.IdSucursal_Produccion, paramCidersus.IdBodega_Produccion);

                
                MovEgreso.IdUsuario  =MovIngreso.IdUsuario = param.IdUsuario;
                MovEgreso.nom_pc = MovIngreso.nom_pc = param.nom_pc;
                MovEgreso.ip = MovIngreso.ip = param.ip;
                MovEgreso.Fecha_Transac = MovIngreso.Fecha_Transac = param.Fecha_Transac;

                int sec = 0;

                LstProdGrid = new List<in_movi_inve_detalle_Info>();
                foreach (var item in ListadoDisponible)
                {
                    
                        LstProdGrid.Add(item);
                  
                }

                foreach (var item in LstProdGrid)
                {
                    in_movi_inve_detalle_Info ing = new in_movi_inve_detalle_Info();
                    in_movi_inve_detalle_Info egr = new in_movi_inve_detalle_Info();
                    in_movi_inve_detalle_x_Producto_CusCider_Info ItemCodBarIng = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                  in_movi_inve_detalle_x_Producto_CusCider_Info ItemCodBarEgr = new in_movi_inve_detalle_x_Producto_CusCider_Info();
             
                    ItemCodBarIng.IdEmpresa= ItemCodBarEgr.IdEmpresa = ing.IdEmpresa = egr.IdEmpresa = param.IdEmpresa;
                    ItemCodBarIng.IdSucursal = ing.IdSucursal = MovIngreso.IdSucursal;
                    ItemCodBarEgr.IdSucursal = egr.IdSucursal = MovEgreso.IdSucursal;
                    ItemCodBarIng.IdBodega =ing.IdBodega = MovIngreso.IdBodega;
                    ItemCodBarEgr.IdBodega =egr.IdBodega = MovEgreso.IdBodega;
                    ing.dm_cantidad = ItemCodBarIng.dm_cantidad = 1;
                    egr.dm_cantidad = ItemCodBarEgr.dm_cantidad = -1;
                    ing.IdMovi_inven_tipo = ItemCodBarIng.IdMovi_inven_tipo = MovIngreso.IdMovi_inven_tipo;
                    egr.IdMovi_inven_tipo = ItemCodBarEgr.IdMovi_inven_tipo = MovEgreso.IdMovi_inven_tipo;
                    egr.Secuencia = ing.Secuencia = ItemCodBarEgr.mv_Secuencia = ItemCodBarIng.mv_Secuencia = ++sec;
                    
                    var saldoing = Bus_prodxbod.Get_Info_Producto_x_Producto(param.IdEmpresa, MovIngreso.IdSucursal, MovIngreso.IdBodega, item.IdProducto);
                    var saldoegr = Bus_prodxbod.Get_Info_Producto_x_Producto(param.IdEmpresa, MovEgreso.IdSucursal, MovEgreso.IdBodega, item.IdProducto);
                    ing.dm_stock_ante = saldoing.pr_stock;
                    ing.dm_stock_actu = saldoing.pr_stock + ing.dm_cantidad;
                    egr.dm_stock_ante = saldoegr.pr_stock;
                    egr.dm_stock_actu = saldoegr.pr_stock - egr.dm_cantidad;

                    ItemCodBarIng.ot_IdEmpresa = param.IdEmpresa;
                    ItemCodBarIng.ot_IdSucursal = OT.IdSucursal;
                    ItemCodBarIng.ot_IdOrdenTaller = OT.IdOrdenTaller;
                    ItemCodBarIng.ot_CodObra = OT.CodObra;
                    ing.IdProducto = egr.IdProducto= ItemCodBarEgr.IdProducto= ItemCodBarIng.IdProducto = item.IdProducto;
                    ItemCodBarEgr.CodigoBarra = ItemCodBarIng.CodigoBarra = item.CodBarra;
                    ing.mv_tipo_movi = ItemCodBarIng.mv_tipo_movi = MovIngreso.cm_tipo;
                    egr.mv_tipo_movi = ItemCodBarEgr.mv_tipo_movi = MovEgreso.cm_tipo;

                    in_Producto_Info prod = new in_Producto_Info();
                    prod = busProducto.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);


                    ItemCodBarEgr.dm_observacion = egr.dm_observacion = item.dm_observacion +
                         " Eg Prod " + prod.pr_descripcion;
                    ItemCodBarIng.dm_observacion = ing.dm_observacion = item.dm_observacion +
                       " Ing Prod " + prod.pr_descripcion;
                    if (item.valida == true )
                    {
                        ItemCodBarEgr.dm_observacion = egr.dm_observacion = "Aut x: " + item.oc_observacion + "-" + egr.dm_observacion;
                        ItemCodBarIng.dm_observacion = ing.dm_observacion = "Aut x: " + item.oc_observacion + "-"+ing.dm_observacion;
                    
                    }
                    MovEgreso.cm_observacion = MovEgreso.cm_observacion + egr.dm_observacion;
                    MovIngreso.cm_observacion = MovIngreso.cm_observacion + ing.dm_observacion;
                    
                    ItemCodBarEgr.dm_observacion = egr.dm_observacion =  "Eg Suc " + ctrl_Sucbod.cmb_sucursal.Text.Trim() +
                   " Bod " + ctrl_Sucbod.cmb_bodega.Text.Trim() +
                   " Egr x Cons Prod -" + MovEgreso.cm_observacion + " "+txtObservacion.Text + egr.dm_observacion ;

                    ItemCodBarIng.dm_observacion = ing.dm_observacion ="Ing Suc " + bod.NomSucursal.Trim() +
                  " Bod " + bod.bo_Descripcion.Trim() +
                  " Ing x Cons Prod -" + MovIngreso.cm_observacion + " " + txtObservacion.Text + ing.dm_observacion;

                    egr.dm_precio = item.dm_precio;
                    egr.mv_costo = item.dm_precio;

                    ing.dm_precio = item.dm_precio;
                    ing.mv_costo = item.dm_precio;

                    ItemCodBarEgr.et_IdProcesoProductivo = (Int32) CmbProcesoProductivo.EditValue;
                    ItemCodBarIng.et_IdProcesoProductivo = (Int32)CmbProcesoProductivo.EditValue;
                    LstDetMovEgreso.Add(egr);
                    LstDetMovIngreso.Add(ing);
                    LstDetxItemsEgr.Add(ItemCodBarEgr);
                    LstDetxItemsIng.Add(ItemCodBarIng);

                }
                MovEgreso.cm_observacion = txtObservacion.Text + "Eg Suc " + ctrl_Sucbod.cmb_sucursal.Text.Trim() +
                   " Bod " + ctrl_Sucbod.cmb_bodega.Text.Trim() +
                   " Egr x Cons Prod -" + MovEgreso.cm_observacion;
                MovIngreso.cm_observacion = txtObservacion.Text + "Ing Suc " + bod.NomSucursal.Trim() +
                  " Bod " + bod.bo_Descripcion.Trim() +
                  " Ing x Cons Prod -" + MovIngreso.cm_observacion;

                MovEgreso.listmovi_inve_detalle_Info = LstDetMovEgreso;
                MovIngreso.listmovi_inve_detalle_Info = LstDetMovIngreso;
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        
        }
        private Boolean validaciones()
        {
            try
            {
                if (txtObservacion.Text == "")
                {
                    MessageBox.Show("Debe ingresar una observacion", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return  false;
                }
                if (CmbOrdenTaller.EditValue == null)
                {
                    MessageBox.Show("Escoja la Orden de Taller a la que van destinados los productos ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return  false;
                }
                
                
                return getCab();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error en:" + ex.ToString());
                return false;
            }

        
        }        
        private Boolean  grabar()
        {
            bool B_SiGrabo = false;
            try
            {
                string mensaje_cbte_cble = "";
                if (validaciones())
                {
                    decimal idAjusteOut;
                    idAjusteOut = 0;
                    decimal idAjusteIng;
                    idAjusteIng = 0;
                    if (BusMov.GrabarDB(MovEgreso, ref idAjusteOut, ref mensaje_cbte_cble, ref msg))
                    {
                     
                        foreach (var item in LstDetxItemsEgr)
                        {
                            item.IdNumMovi = MovEgreso.IdNumMovi;
                            item.ot_CodObra = UCObra.get_item_info().CodObra;
                            item.ot_IdOrdenTaller =Convert.ToDecimal( CmbOrdenTaller.EditValue);
                        }
                        if (BusDetxItems.GuardarDB(LstDetxItemsEgr, ref msg))
                        { 

                          txtNumAjuste.Text = Convert.ToString(idAjusteOut);
                          MessageBox.Show("Ajuste # " + idAjusteOut + ". Egreso por Consumo de Producción."
                          + " Grabado Satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          setCab(MovEgreso);
                           set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                            
                        }
                         else
                         {
                          MessageBox.Show("Ajuste # " + idAjusteOut + ". Egreso por Consumo de Producción."
                          + " No se Grabo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         setCab(MovEgreso);
                         set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                         B_SiGrabo= false;
                       }                                     
                    }
                }
                return B_SiGrabo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;

            }
           
               
        }
        void anular()
        {
            try
            {
                bool anulado = false;
                if (MovEgreso  != null)
                {
                    if (MovEgreso.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el Ajuste de Inventario No.: " + MovEgreso.IdNumMovi + " ?",
                                    "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                            oFrm.ShowDialog();
                            MovEgreso.cm_observacion = "***ANULADO***" +
                               oFrm.motivoAnulacion + MovEgreso.cm_observacion;
                            MovEgreso.IdusuarioUltAnu = param.IdUsuario;
                            MovEgreso.Fecha_UltAnu = param.Fecha_Transac;

                            if (BusMov.AnularDB(MovEgreso,Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref msg))
                            {
                                if (BusCodBAr.ConsultaxMovInvTipo(MovEgreso.IdEmpresa, MovEgreso.IdSucursal, MovEgreso.IdBodega,
                                                                       MovEgreso.IdNumMovi, MovEgreso.IdMovi_inven_tipo) != null)
                                {
                                    if (BusCodBAr.AnularDB(MovEgreso.IdEmpresa, MovEgreso.IdSucursal, MovEgreso.IdBodega,
                                      MovEgreso.IdNumMovi, MovEgreso.IdMovi_inven_tipo, ref msg))
                                    {
                                        if (LstConsultaMovi.Count > 0)
                                        {
                                            foreach (var item in LstConsultaMovi)
                                            {
                                                item.cm_observacion = "***ANULADO***" +
                                                oFrm.motivoAnulacion + item.cm_observacion;
                                                item.IdusuarioUltAnu = param.IdUsuario;
                                                item.Fecha_UltAnu = param.Fecha_Transac;

                                                if (BusMov.AnularDB(item, Convert.ToDateTime(DateTime.Now.ToShortDateString()),ref msg) == false) { anulado = false; break; }
                                                if (BusCodBAr.ConsultaxMovInvTipo(item.IdEmpresa, item.IdSucursal, item.IdBodega,
                                                    item.IdNumMovi, item.IdMovi_inven_tipo) != null)
                                                {
                                                    if (BusCodBAr.AnularDB(item.IdEmpresa, item.IdSucursal, item.IdBodega,
                                                      item.IdNumMovi, item.IdMovi_inven_tipo, ref msg) == false)
                                                    {
                                                        anulado = false; break;
                                                    }
                                                }
                                                anulado = true;


                                            }
                                            if (anulado == true)
                                            {
                                                MessageBox.Show("Anulado con exito el Ajuste de Inventario No. " + MovEgreso.IdNumMovi);
                                                MovEgreso.Estado = "I";

                                                lblAnulado.Visible = true;
                                                set_Accion(Cl_Enumeradores.eTipo_action.consultar);

                                            }
                                            else
                                                MessageBox.Show("Ha ocurrido un error al anular el Ajuste de Inventario No. " + MovEgreso.IdNumMovi + " " + msg);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Anulado con exito el Ajuste de Inventario No. " + MovEgreso.IdNumMovi);
                                        }
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Anulado con exito el Ajuste de Inventario No. " + MovEgreso.IdNumMovi);
                                }
                            }
                            else MessageBox.Show("Ha ocurrido un error al anular el Ajuste de Inventario No. " + MovEgreso.IdNumMovi + " " + msg);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular el Ajuste de Inventario No.: " + MovEgreso.IdNumMovi +
                            " debido a que ya se encuentra anulado",
                            "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                if (ListadoDisponible.Count == 0)
                {
                    MessageBox.Show("Error seleccione al menos un registro");
                    return;
                }
                grabar();
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
                buscarenlistado();
                if (ListadoDisponible.Count == 0)
                {
                    MessageBox.Show("Error seleccione al menos un registro");
                    return;
                }
                if (grabar())
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
               anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        private void gridViewDisponible_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewDisponible.GetRow(e.RowHandle) as in_movi_inve_detalle_Info ;
                if (data == null)
                    return;
                if (data.valida == true)
                    e.Appearance.ForeColor = Color.Red;
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

                //XPRO_CUS_CID_Rpt007 XReport = new XPRO_CUS_CID_Rpt007();
                //List<tbPRO_CUS_CID_Rpt007_Info> data = new List<tbPRO_CUS_CID_Rpt007_Info>();
                //prd_ObtenerReporte_Bus busSpRpt = new prd_ObtenerReporte_Bus();

                //data = busSpRpt.OptenerData_spPRD_Rpt_RPRD007(param.IdEmpresa, param.IdSucursal, MovEgreso.IdBodega, MovEgreso.IdMovi_inven_tipo,
                //    MovEgreso.IdNumMovi, param.IdUsuario, param.nom_pc);
                //XReport.loaddata(data.ToArray());
                //XReport.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }
        void buscarenlistado()
        {
            
           // List<in_movi_inve_detalle_Info> listatemp = new List<in_movi_inve_detalle_Info>();
               
            try
            { 
                if (validar())
                {
                    
                        if (ListadoProductos.Count > 0)
                        {
                            foreach (var item in ListadoProductos)
                            { 
                               
                                   
                                    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();

                                    info.CodBarra = item.CodigoBarra;
                                    info.IdProducto = item.IdProducto;
                                    info.dm_cantidad = Convert.ToDouble(item.dm_cantidad);
                                    info.CodProducto = item.CodigoProducto.ToString();
                                    info.NomProducto = item.pr_descripcion;
                                    info.dm_precio = item.dm_precio;
                                    info.mv_costo = item.dm_precio;
                                    if (item.Checked == true)
                                    {
                                        ListadoDisponible.Add(info);
                                    }
                                    
                                    gridControlDisponible.DataSource = ListadoProductos;
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
     
    
        private void ctrl_Sucbod_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                cargadisponible();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        
    }
}
