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
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Winform.Produc_Cirdesus;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_Movil_EgresoInventario : Form
    {
        public FrmPrd_Movil_EgresoInventario()
        {
            try
            {
                InitializeComponent();
                cargacontroles();
                paramCidersus = Busparam.ObtenerObjeto(param.IdEmpresa);
                gridControlDisponible.DataSource = Grid;
                ctrl_Sucbod.Event_cmb_sucursal_SelectedIndexChanged += ctrl_Sucbod_Event_cmb_sucursal_SelectedIndexChanged;
                UCObra.Event_UCObra_SelectionChanged += UCObra_Event_UCObra_SelectionChanged;
                UCObra.Event_UCObra_Validating += UCObra_Event_UCObra_Validating;
                cambiacontroles();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        #region variables
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
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstDetxItemsIng = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstDetxItemsEgr = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        in_movi_inve_Bus BusMov = new in_movi_inve_Bus();
        in_movi_inve_detalle_Bus BusMovDet = new in_movi_inve_detalle_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Bus BusDetxItems = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        BindingList<in_movi_inve_detalle_Info> Grid = new BindingList<in_movi_inve_detalle_Info>();
        UCPrd_Obra UCObra = new UCPrd_Obra();

        //variables de instancia
        Cl_Enumeradores.eTipo_action iAccion = new Cl_Enumeradores.eTipo_action(); cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public delegate void delegate_frmIn_EgresoInventario_x_Produccion_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmIn_EgresoInventario_x_Produccion_Mantenimiento_FormClosing event_frmIn_EgresoInventario_x_Produccion_Mantenimiento_FormClosing;

        #endregion

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

                    LstDetxProdSaldo = BusDetxItems.SaldosxItemsxCodBarra(param.IdEmpresa,DateTime.Now,1,1).FindAll(var =>
                    var.IdSucursal == _sucursalInfo.IdSucursal
                    && var.IdBodega == _bodegaInfo.IdBodega
                    && var.dm_cantidad > 0);
                    ListadoDisponible = new BindingList<in_movi_inve_detalle_Info>();
                    foreach (var item in LstDetxProdSaldo)
                    {
                        in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                        info.CodBarra = item.CodigoBarra;
                        info.IdProducto = item.IdProducto;
                        info.dm_cantidad = Convert.ToDouble(item.dm_cantidad);
                        var prod = busProducto.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                        info.CodProducto = prod.pr_codigo;
                        info.NomProducto = prod.pr_descripcion;
                        ListadoDisponible.Add(info);
                    }

                    gridControlDisponible.DataSource = ListadoDisponible;
                    gridControlDisponible.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        void ctrl_Sucbod_Event_cmb_bodega_SelectedIndexChanged(object sender, EventArgs e)
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

        private void frmIn_EgresoInventario_x_Produccion_Mantenimiento_Load(object sender, EventArgs e)
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
                    gridLkUOrdenTaller.EditValue = null;
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
                if (string.IsNullOrEmpty(Convert.ToString(ctrl_Sucbod.cmb_sucursal.EditValue)))
                {
                    if (UCObra.get_item_info() != null)
                    {
                        try
                        {
                            List<prd_OrdenTaller_Info> lstOt = new List<prd_OrdenTaller_Info>();
                            lstOt = busOT.ObtenerListaOT(param.IdEmpresa).FindAll(var =>
                                        var.IdSucursal == Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.EditValue)
                                        && var.CodObra == UCObra.get_item());
                            gridLkUOrdenTaller.Properties.DataSource = lstOt;
                            gridLkUOrdenTaller.Text = "";
                        }
                        catch (Exception ex)
                        {
                            Log_Error_bus.Log_Error(ex.ToString());
                            gridLkUOrdenTaller.Properties.DataSource = null;
                        }



                    }
                    else
                        gridLkUOrdenTaller.Properties.DataSource = null;
                }
                else
                    gridLkUOrdenTaller.Properties.DataSource = null;
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
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
                //UCObra.UC_Obra.Location = new Point(79, 1);
                //UCObra.UC_Obra.Size = new System.Drawing.Size(307, 20);

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
                 
                    case Cl_Enumeradores.eTipo_action.consultar:
                      
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
                this.btn_guardar.Enabled = false;
                //this.UCObra.UC_Obra.Enabled = false;
                ctrl_Sucbod.cmb_bodega.Enabled = false;
                ctrl_Sucbod.cmb_sucursal.Enabled = false;
                gridLkUOrdenTaller.Enabled = false;
                var color = txtIngCB.BackColor;
                txtIngCB.Enabled = false;
                txtIngCB.BackColor = color;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        in_movi_inve_detalle_x_Producto_CusCider_Bus BusCodBAr = new in_movi_inve_detalle_x_Producto_CusCider_Bus();

        public void setCab(in_movi_inve_Info Info)
        {
            try
            {

                MovEgreso = Info;


                ctrl_Sucbod.cmb_sucursal.EditValue = Info.IdSucursal;
                ctrl_Sucbod.cmb_bodega.EditValue = Info.IdBodega;

                List<vwIn_Movi_Inven_x_CodBarra_CusCider_Info> consultacodbar = new List<vwIn_Movi_Inven_x_CodBarra_CusCider_Info>();
              //  consultacodbar = BusCodBAr.ConsultaGeneral(MovEgreso);
                LstDetMovEgreso = new List<in_movi_inve_detalle_Info>();
                vwIn_Movi_Inven_x_CodBarra_CusCider_Info ot = new vwIn_Movi_Inven_x_CodBarra_CusCider_Info();

                foreach (var item in consultacodbar)
                {
                    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                    ot.ot_CodObra = item.ot_CodObra;
                    ot.ot_IdOrdenTaller = item.ot_IdOrdenTaller;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    info.IdNumMovi = item.IdNumMovi;
                    info.CodMoviInven = item.CodMoviInven;
                    if (item.dm_cantidadCodBarra == null)
                    {
                        info.dm_cantidad = item.dm_cantidad;
                        info.CodBarra = "";
                    }
                    else
                    {
                        info.dm_cantidad = (double)item.dm_cantidadCodBarra;
                        info.CodBarra = item.CodigoBarra;
                    }
                    info.dm_observacion = item.dm_observacion;
                    info.dm_precio = item.dm_precio;
                    info.dm_stock_actu = item.dm_stock_actu;
                    info.dm_stock_ante = item.dm_stock_ante;

                    var prod = busProducto.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                    info.NomProducto = prod.pr_descripcion;
                    info.CodProducto = prod.pr_codigo;

                    LstDetMovEgreso.Add(info);
                }


                UCObra.set_item(ot.ot_CodObra);
                cargacmbot();
                gridLkUOrdenTaller.EditValue = ot.ot_IdOrdenTaller;

                ListadoDisponible = new BindingList<in_movi_inve_detalle_Info>(LstDetMovEgreso);
                gridControlDisponible.DataSource = ListadoDisponible;



                txtNumAjuste.Text = Convert.ToString(Info.IdNumMovi);
                txtcodigoAjuste.Text = Info.CodMoviInven;
                txtObservacion.Text = Info.cm_observacion;

                dtpFecha.Value = Convert.ToDateTime(Info.Fecha_Transac);


                ListTI = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                LstConsultaMovi = new List<in_movi_inve_Info>();
                ListTI = busTI.ConsultaTIMovim_EgresoConsumo(Info);
                foreach (var item in ListTI)
                {
                    in_movi_inve_Info info = new in_movi_inve_Info();
                    if (item.IdEmpresa == Info.IdEmpresa &&
                        item.IdSucursal == Info.IdSucursal &&
                        item.IdBodega == Info.IdBodega &&
                        item.IdMovi_inven_tipo == Info.IdMovi_inven_tipo &&
                        item.IdNumMovi == Info.IdNumMovi)

                        info = BusMov.Get_Info_Movi_inven_Report(item.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdMovi_inven_tipo, item.IdNumMovi);
                    else if (item.IdEmpresa == Info.IdEmpresa &&
                      item.IdSucursal == Info.IdSucursal &&
                      item.IdBodega == Info.IdBodega &&
                      item.IdMovi_inven_tipo == Info.IdMovi_inven_tipo &&
                      item.IdNumMovi == Info.IdNumMovi)

                        info = BusMov.Get_Info_Movi_inven_Report(item.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdMovi_inven_tipo, item.IdNumMovi);

                    if (info != null)
                    {

                        LstConsultaMovi.Add(info);
                    }
                }
                if (ot.ot_IdOrdenTaller == null)
                {
                    //consultacodbar = BusCodBAr.ConsultaGeneral(LstConsultaMovi[0]);
                    foreach (var item in consultacodbar)
                    {

                        ot.ot_CodObra = item.ot_CodObra;
                        ot.ot_IdOrdenTaller = item.ot_IdOrdenTaller;
                    }
                    UCObra.set_item(ot.ot_CodObra);
                    cargacmbot();
                    gridLkUOrdenTaller.EditValue = ot.ot_IdOrdenTaller;

                    ListadoDisponible = new BindingList<in_movi_inve_detalle_Info>(LstDetMovEgreso);
                    gridControlDisponible.DataSource = ListadoDisponible;


                }

                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }


        }

        in_movi_inven_x_in_movi_inven_CusCidersus_Bus busTI = new in_movi_inven_x_in_movi_inven_CusCidersus_Bus();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListTI = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        List<in_movi_inve_Info> LstConsultaMovi = new List<in_movi_inve_Info>();
        private void btnSalir_Click(object sender, EventArgs e)
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

        List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info> LstSaldoxOT = new List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info>();
        List<in_movi_inve_detalle_Info> LstProdGrid = new List<in_movi_inve_detalle_Info>();

        in_producto_Bus busProducto = new in_producto_Bus();
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
                if (gridLkUOrdenTaller.EditValue != "")
                {
                    LstSaldoxOT = BusDetxItems.DisponiblesxReqOt(param.IdEmpresa, UCObra.get_item(), _sucursalInfo.IdSucursal,
                               Convert.ToDecimal(gridLkUOrdenTaller.EditValue), ref msg);
                    if (LstSaldoxOT != null)
                    {
                        LstSaldoxOT.ForEach(var => var.saldo = (var.saldo == null) ? var.ped_saldo : var.saldo);
                    }


                    cargadisponible();

                    prd_OrdenTaller_Bus BusOT = new prd_OrdenTaller_Bus();
                    OT = BusOT.ObtenerUnaOT(param.IdEmpresa, ctrl_Sucbod.get_sucursal().IdSucursal,
                        Convert.ToDecimal(gridLkUOrdenTaller.EditValue), UCObra.get_item());
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                // MessageBox.Show(ex.InnerException.ToString());

            }

        }
        List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> LstDetxProdSaldo = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();

        private Boolean validar()
        {
            try
            {
                if (UCObra.get_item_info() == null)
                {
                    MessageBox.Show("Seleccione una Obra", "Sistema");
                    panelObra.Focus();
                    return false;
                }
                else if (gridLkUOrdenTaller.EditValue == null )
                {
                    MessageBox.Show("Seleccione una OT", "Sistema");
                    gridLkUOrdenTaller.Focus();
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


        in_producto_x_tb_bodega_Bus Bus_prodxbod = new in_producto_x_tb_bodega_Bus();

        tb_Bodega_Bus busbod = new tb_Bodega_Bus();

        private Boolean getCab()
        {
            try
            {
                MovEgreso = new in_movi_inve_Info();
                getSucBod();
                MovIngreso.IdEmpresa = MovEgreso.IdEmpresa = param.IdEmpresa;
                MovEgreso.IdSucursal = _sucursalInfo.IdSucursal;
                MovIngreso.IdSucursal = paramCidersus.IdSucursal_Produccion;
                MovEgreso.IdBodega = _bodegaInfo.IdBodega;
                MovIngreso.IdBodega = paramCidersus.IdBodega_Produccion;
                MovIngreso.cm_anio = MovEgreso.cm_anio = dtpFecha.Value.Year;
                MovIngreso.cm_fecha = MovEgreso.cm_fecha = dtpFecha.Value;
                MovIngreso.cm_mes = MovEgreso.cm_mes = dtpFecha.Value.Month;
                MovEgreso.cm_tipo = "-";
                MovIngreso.cm_tipo = "+";
                MovIngreso.Estado = MovEgreso.Estado = "A";
                MovEgreso.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_egr_consumoprod);
                MovIngreso.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_ing_consumoprod);

                var bod = busbod.Get_Info_Bodega(param.IdEmpresa,
                    paramCidersus.IdSucursal_Produccion, paramCidersus.IdBodega_Produccion);


                MovEgreso.IdUsuario = MovIngreso.IdUsuario = param.IdUsuario;
                MovEgreso.nom_pc = MovIngreso.nom_pc = param.nom_pc;
                MovEgreso.ip = MovIngreso.ip = param.ip;
                MovEgreso.Fecha_Transac = MovIngreso.Fecha_Transac = param.Fecha_Transac;

                int sec = 0;

                LstProdGrid = new List<in_movi_inve_detalle_Info>();
                foreach (var item in ListadoDisponible)
                {
                    if (item.Checked == true)
                    {
                        LstProdGrid.Add(item);
                    }
                }

                foreach (var item in LstProdGrid)
                {
                    in_movi_inve_detalle_Info ing = new in_movi_inve_detalle_Info();
                    in_movi_inve_detalle_Info egr = new in_movi_inve_detalle_Info();
                    in_movi_inve_detalle_x_Producto_CusCider_Info ItemCodBarIng = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    in_movi_inve_detalle_x_Producto_CusCider_Info ItemCodBarEgr = new in_movi_inve_detalle_x_Producto_CusCider_Info();

                    ItemCodBarIng.IdEmpresa = ItemCodBarEgr.IdEmpresa = ing.IdEmpresa = egr.IdEmpresa = param.IdEmpresa;
                    ItemCodBarIng.IdSucursal = ing.IdSucursal = MovIngreso.IdSucursal;
                    ItemCodBarEgr.IdSucursal = egr.IdSucursal = MovEgreso.IdSucursal;
                    ItemCodBarIng.IdBodega = ing.IdBodega = MovIngreso.IdBodega;
                    ItemCodBarEgr.IdBodega = egr.IdBodega = MovEgreso.IdBodega;
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
                    ing.IdProducto = egr.IdProducto = ItemCodBarEgr.IdProducto = ItemCodBarIng.IdProducto = item.IdProducto;
                    ItemCodBarEgr.CodigoBarra = ItemCodBarIng.CodigoBarra = item.CodBarra;
                    ing.mv_tipo_movi = ItemCodBarIng.mv_tipo_movi = MovIngreso.cm_tipo;
                    egr.mv_tipo_movi = ItemCodBarEgr.mv_tipo_movi = MovEgreso.cm_tipo;

                    in_Producto_Info prod = new in_Producto_Info();
                    prod = busProducto.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);


                    ItemCodBarEgr.dm_observacion = egr.dm_observacion = item.dm_observacion +
                         " Eg Prod " + prod.pr_descripcion;
                    ItemCodBarIng.dm_observacion = ing.dm_observacion = item.dm_observacion +
                       " Ing Prod " + prod.pr_descripcion;
                    if (item.valida == true)
                    {
                        ItemCodBarEgr.dm_observacion = egr.dm_observacion = "Aut x: " + item.oc_observacion + "-" + egr.dm_observacion;
                        ItemCodBarIng.dm_observacion = ing.dm_observacion = "Aut x: " + item.oc_observacion + "-" + ing.dm_observacion;

                    }
                    MovEgreso.cm_observacion = MovEgreso.cm_observacion + egr.dm_observacion;
                    MovIngreso.cm_observacion = MovIngreso.cm_observacion + ing.dm_observacion;

                    ItemCodBarEgr.dm_observacion = egr.dm_observacion = "Eg Suc " + ctrl_Sucbod.cmb_sucursal.Text.Trim() +
                   " Bod " + ctrl_Sucbod.cmb_bodega.Text.Trim() +
                   " Egr x Cons Prod -" + MovEgreso.cm_observacion + " " + txtObservacion.Text + egr.dm_observacion;

                    ItemCodBarIng.dm_observacion = ing.dm_observacion = "Ing Suc " + bod.NomSucursal.Trim() +
                  " Bod " + bod.bo_Descripcion.Trim() +
                  " Ing x Cons Prod -" + MovIngreso.cm_observacion + " " + txtObservacion.Text + ing.dm_observacion;

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
                    return false;
                }
                if (gridLkUOrdenTaller.EditValue == null)
                {
                    MessageBox.Show("Escoja la Orden de Taller a la que van destinados los productos ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                int items = 0;
                foreach (var item in ListadoDisponible)
                {
                    if (item.Checked == true)
                    {
                        items++;
                        break;

                    }
                }
                if (items == 0)
                {
                    MessageBox.Show("Ingrese productos para Grabar.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                foreach (var item in ListadoDisponible)
                {
                    if (item.Checked == true)
                    {
                        in_producto_x_tb_bodega_Bus Busprodxbod = new in_producto_x_tb_bodega_Bus();
                        List<in_producto_x_tb_bodega_Info> LstProdxBod = new List<in_producto_x_tb_bodega_Info>();
                        Boolean existeenbod = false;
                        LstProdxBod = Busprodxbod.Get_list_Productos_x_Bodega(param.IdEmpresa, item.IdProducto);
                        if (LstProdxBod != null)
                        {
                            foreach (var ProdxBodega in LstProdxBod)
                            {
                                if (ProdxBodega.IdBodega == paramCidersus.IdBodega_Produccion)
                                    existeenbod = true;

                            }
                            if (existeenbod == false)
                            {

                                MessageBox.Show("Asigne el producto " + item.NomProducto + " a la bodega de Producción", "Sistema"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                return false;
                            }

                        }
                        else
                        {

                            MessageBox.Show("Asigne el producto " + item.NomProducto + " a la bodega de Producción", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            return false;
                        }
                    }
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

        private Boolean grabar()
        {
            try
            {
                string mensaje_cbte_cble = "";


                if (validaciones())
                {
                    decimal idAjusteOut;
                    idAjusteOut = 0;
                    decimal idAjusteIng;
                    idAjusteIng = 0;
                    if (MovEgreso.cm_observacion.Length > 980) MovEgreso.cm_observacion = MovEgreso.cm_observacion.Substring(0, 980);
                    foreach (var item in MovEgreso.listmovi_inve_detalle_Info)
                    {
                        if (item.dm_observacion.Length > 980) item.dm_observacion = item.dm_observacion.Substring(0, 980);

                    }
                    if (BusMov.GrabarDB(MovEgreso, ref idAjusteOut,ref mensaje_cbte_cble, ref msg))
                    {
                        foreach (var item in LstDetxItemsEgr)
                        {
                            item.IdNumMovi = idAjusteOut;
                            if (item.dm_observacion.Length > 980) item.dm_observacion = item.dm_observacion.Substring(0, 980);

                        }
                        if (BusDetxItems.GuardarDB(LstDetxItemsEgr, ref msg))
                        {
                            if (MovIngreso.cm_observacion.Length > 980) MovIngreso.cm_observacion = MovIngreso.cm_observacion.Substring(0, 980);
                            foreach (var item in MovIngreso.listmovi_inve_detalle_Info)
                            {
                                if (item.dm_observacion.Length > 980) item.dm_observacion = item.dm_observacion.Substring(0, 980);

                            }
                            if (BusMov.GrabarDB(MovIngreso, ref idAjusteIng,ref mensaje_cbte_cble, ref msg))
                            {

                                foreach (var item in LstDetxItemsIng)
                                {
                                    item.IdNumMovi = idAjusteIng;
                                    if (item.dm_observacion.Length > 980) item.dm_observacion = item.dm_observacion.Substring(0, 980);

                                }
                                if (BusDetxItems.GuardarDB(LstDetxItemsIng, ref msg))
                                {
                                    in_movi_inve_detalle_x_Producto_CusCider_Info TI = new in_movi_inve_detalle_x_Producto_CusCider_Info();

                                    TI.IdEmpresa = MovEgreso.IdEmpresa;
                                    TI.IdSucursal = MovEgreso.IdSucursal;
                                    TI.IdBodega = MovEgreso.IdBodega;
                                    TI.IdMovi_inven_tipo = MovEgreso.IdMovi_inven_tipo;
                                    TI.IdNumMovi = MovEgreso.IdNumMovi;
                                    TI.IdEmpresa = MovIngreso.IdEmpresa;
                                    TI.IdSucursal = MovIngreso.IdSucursal;
                                    TI.IdBodega = MovIngreso.IdBodega;
                                    TI.IdMovi_inven_tipo = MovIngreso.IdMovi_inven_tipo;
                                    TI.IdNumMovi = MovIngreso.IdNumMovi;

                                    if (busTI.GuardarTIMovim_EgresoConsumo(TI))
                                    {
                                        txtNumAjuste.Text = Convert.ToString(idAjusteOut);
                                        MessageBox.Show("Grabado Satisfactoriamente", "Sistemas");
                                        setCab(MovEgreso);
                                        set_Accion(Cl_Enumeradores.eTipo_action.consultar);

                                        return true;
                                    }
                                    else return false;
                                }
                                else return false;

                            }
                            else return false;
                        }
                        else return false;

                    }
                    else return false;
                }
                else return false;
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
                if (MovEgreso != null)
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

                            if (BusMov.AnularDB(MovEgreso, Convert.ToDateTime(DateTime.Now.ToShortDateString()),ref msg))
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

        private void btn_guardarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                    this.Close();
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

        private void gridViewDisponible_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewDisponible.GetRow(e.RowHandle) as in_movi_inve_detalle_Info;
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

    

        List<vwprd_Ensamblado_CabDet_CusCider_Info> LstEnsab = new List<vwprd_Ensamblado_CabDet_CusCider_Info>();
        prd_Ensamblado_CusCider_Bus BusEnsa = new prd_Ensamblado_CusCider_Bus();
        BindingList<in_movi_inve_detalle_Info> ListadoDisponible = new BindingList<in_movi_inve_detalle_Info>();
        void buscarenlistado()
        {
            try
            {
                if (validar())
                {
                    if (!String.IsNullOrEmpty(txtIngCB.Text) || !String.IsNullOrWhiteSpace(txtIngCB.Text))
                    {
                        Boolean Find = false;

                        if (ListadoDisponible.Count > 0)
                        {
                            in_movi_inve_detalle_Info agregado = new in_movi_inve_detalle_Info();

                            foreach (var item in ListadoDisponible)
                            {
                                if (item.CodBarra == txtIngCB.Text && Find == false)
                                {

                                    bool flag = false;
                                    foreach (var item1 in LstSaldoxOT)
                                    {
                                        if (item1.ped_IdProducto == item.IdProducto)
                                        {
                                            int cantsolicitada = 0;

                                            foreach (var reg in ListadoDisponible)
                                            {
                                                if (reg.IdProducto == item.IdProducto && reg.Checked == true)
                                                    cantsolicitada++;
                                            }


                                            if (cantsolicitada <= item1.saldo)
                                            {

                                                item.valida = false;
                                                item.Checked = true; agregado = item; Find = true;
                                                flag = true;
                                                break;
                                            }
                                            else
                                            {
                                                if (MessageBox.Show("La OT ha sobrepasado la \rcant de ese producto.\r¿Desea pedir autorización?", "Sistema",
                                            MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                                {
                                                    if (PedirAutorizacion())
                                                    {
                                                        item.valida = true;
                                                        item.Checked = true; item.dm_observacion = "Aut: " + autoriza;
                                                        agregado = item; Find = true; flag = true;
                                                        break;
                                                    }
                                                }
                                                else return;
                                            }
                                        }

                                    }
                                    if (flag == false)
                                    {
                                        if (MessageBox.Show("La OT no tiene asignado\r ese producto.\r¿Desea pedir autorización?", "Sistema",
                                                  MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                        {
                                            if (PedirAutorizacion())
                                            {
                                                item.valida = true;
                                                item.Checked = true; item.dm_observacion = "Aut: " + autoriza;
                                                agregado = item; Find = true;
                                            }
                                        }
                                        else return;
                                    }
                                }
                            }
                            if (Find == true)
                            {
                                List<in_movi_inve_detalle_Info> listatemp = new List<in_movi_inve_detalle_Info>();
                                foreach (var item in ListadoDisponible)
                                {
                                    if (item.CodBarra != agregado.CodBarra)
                                        listatemp.Add(item);
                                }

                                ListadoDisponible = new BindingList<in_movi_inve_detalle_Info>();
                                ListadoDisponible.Add(agregado);
                                foreach (var item in listatemp)
                                {
                                    ListadoDisponible.Add(item);
                                }

                                gridControlDisponible.DataSource = ListadoDisponible;
                                gridControlDisponible.RefreshDataSource();

                                MessageBox.Show("Agregado", "Sistema");
                                txtIngCB.Text = "";

                            }
                            else if (preguntar == true)
                            {
                                MessageBox.Show("Código no encontrado", "Sistema");

                            }
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

                        var reg = (in_movi_inve_detalle_Info)gridViewDisponible.GetFocusedRow();
                        if (reg != null && reg.CodBarra != null)
                        { txtIngCB.Text = reg.CodBarra; txtIngCB_KeyPress(sender, v); }

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //private void frmIn_EgresoInventario_x_Produccion_Mantenimiento_Load(object sender, EventArgs e)
        //{
            
        //}

      
        //void UCObra_Event_UCObra_Validating(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        if (UCObra.get_item_info() == null)
        //        {
        //            gridLkUOrdenTaller.EditValue = null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //void cargacmbot()
        //{
        //    try
        //    {
        //        if (ctrl_Sucbod.cmb_sucursal.SelectedIndex != -1)
        //        {
        //            if (UCObra.get_item_info() != null)
        //            {
        //                try
        //                {
        //                    List<prd_OrdenTaller_Info> lstOt = new List<prd_OrdenTaller_Info>();
        //                    lstOt = busOT.ObtenerListaOT(param.IdEmpresa).FindAll(var =>
        //                                var.IdSucursal == Convert.ToInt32(ctrl_Sucbod.cmb_sucursal.SelectedValue)
        //                                && var.CodObra == UCObra.get_item());
        //                    gridLkUOrdenTaller.Properties.DataSource = lstOt;
        //                    gridLkUOrdenTaller.Text = "";
        //                }
        //                catch (Exception ex)
        //                {
        //                    gridLkUOrdenTaller.Properties.DataSource = null;
        //                }



        //            }
        //            else
        //                gridLkUOrdenTaller.Properties.DataSource = null;
        //        }
        //        else
        //            gridLkUOrdenTaller.Properties.DataSource = null;
        //    }
        //    catch (Exception ex)
        //    {
                
                
        //    }
         
        //}

        //void UCObra_Event_UCObra_SelectionChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cargacmbot();
        //    }
        //    catch (Exception ex)
        //    {


        //    }
           
        //}

        //void ctrl_Sucbod_Event_cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cargacmbot();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
                
        //void getSucBod()
        //{

        //    try
        //    {
        //        _sucursalInfo = ctrl_Sucbod.get_sucursal();
        //        _bodegaInfo = ctrl_Sucbod.get_bodega();
        //    }
        //    catch (Exception e) { MessageBox.Show(e.Message); }
        //}
        
        //void cargacontroles()
        //{
        //    try
        //    {
                
        //        UCObra.cargaCmb_Obra();
        //        panelObra.Controls.Add(UCObra);
        //        UCObra.Dock = DockStyle.Fill;

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }

        //}

        //public void set_Accion(Cl_Enumeradores.eTipo_action Accion)
        //{

        //    try
        //    {
        //        iAccion = Accion;
        //        switch (Accion)
        //        {
        //            case Cl_Enumeradores.eTipo_action.grabar:
        //                this.btn_guardar.Text = "Grabar Registro";

        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.ToString());
        //    }

        //}

        //in_movi_inve_detalle_x_Producto_CusCider_Bus BusCodBAr = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        
        //public void setCab(in_movi_inve_Info Info)
        //{
        //    try
        //    {

        //        MovEgreso  = Info;
              

        //        ctrl_Sucbod.cmb_sucursal.SelectedValue = Info.IdSucursal;
        //        ctrl_Sucbod.cmb_bodega.SelectedValue = Info.IdBodega; 
                
        //        List<vwIn_Movi_Inven_x_CodBarra_CusCider_Info> consultacodbar = new List<vwIn_Movi_Inven_x_CodBarra_CusCider_Info>();
        //        consultacodbar = BusCodBAr.ConsultaGeneral(MovEgreso);
        //        LstDetMovEgreso  = new List<in_movi_inve_detalle_Info>();
        //        vwIn_Movi_Inven_x_CodBarra_CusCider_Info ot = new vwIn_Movi_Inven_x_CodBarra_CusCider_Info();
                
        //        foreach (var item in consultacodbar)
        //        {
        //            in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
        //            ot.ot_CodObra = item.ot_CodObra;
        //            ot.ot_IdOrdenTaller = item.ot_IdOrdenTaller;
        //            info.IdEmpresa = item.IdEmpresa;
        //            info.IdProducto = item.IdProducto;
        //            info.IdSucursal = item.IdSucursal;
        //            info.IdBodega = item.IdBodega;
        //            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
        //            info.IdNumMovi = item.IdNumMovi;
        //            info.CodMoviInven = item.CodMoviInven;
        //            if (item.dm_cantidadCodBarra == null)
        //            {
        //                info.dm_cantidad = item.dm_cantidad;
        //                info.CodBarra = "";
        //            }
        //            else
        //            {
        //                info.dm_cantidad = (double)item.dm_cantidadCodBarra;
        //                info.CodBarra = item.CodigoBarra;
        //            }
        //            info.dm_observacion = item.dm_observacion;
        //            info.dm_precio = item.dm_precio;
        //            info.dm_stock_actu = item.dm_stock_actu;
        //            info.dm_stock_ante = item.dm_stock_ante;
                    
        //            var prod = busProducto.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa );
        //            info.NomProducto = prod.pr_descripcion;
        //            info.CodProducto = prod.pr_codigo;

        //            LstDetMovEgreso.Add(info);
        //        }
               
                
        //        UCObra.set_item(ot.ot_CodObra);
        //        cargacmbot();
        //        gridLkUOrdenTaller.EditValue = ot.ot_IdOrdenTaller;
                

        //        //gridCtrlEgxProd.DataSource = LstDetMovEgreso;
        //        Grid = new BindingList<in_movi_inve_detalle_Info>();
        //        Grid = new BindingList<in_movi_inve_detalle_Info>(LstDetMovEgreso);
        //        gridControlDisponible.DataSource = Grid;


        //        txtNumAjuste.Text = Convert.ToString(Info.IdNumMovi);
        //        txtcodigoAjuste.Text  = Info.CodMoviInven;
        //        txtObservacion.Text = Info.cm_observacion ;
                
        //        dtpFecha.Value = Convert.ToDateTime(Info.Fecha_Transac);


        //        ListTI = new List<in_movi_inven_x_in_movi_inven_CusCidersus_Info>();
        //        LstConsultaMovi = new List<in_movi_inve_Info>();
        //        ListTI = busTI.ConsultaTIMovim_EgresoConsumo(Info);
        //        foreach (var item in ListTI)
        //        {
        //            in_movi_inve_Info info = new in_movi_inve_Info();
        //            if (item.IdEmpresa1 == Info.IdEmpresa &&
        //                item.IdSucursal1 == Info.IdSucursal &&
        //                item.IdBodega1 == Info.IdBodega &&
        //                item.IdMovi_inven_tipo1 == Info.IdMovi_inven_tipo &&
        //                item.IdNumMovi1 == Info.IdNumMovi)

        //                info = BusMov.Obtener_list_Movi_inven_Reporte(item.IdEmpresa2, item.IdSucursal2, item.IdBodega2, item.IdMovi_inven_tipo2, item.IdNumMovi2);
        //            else if (item.IdEmpresa2 == Info.IdEmpresa &&
        //              item.IdSucursal2 == Info.IdSucursal &&
        //              item.IdBodega2 == Info.IdBodega &&
        //              item.IdMovi_inven_tipo2 == Info.IdMovi_inven_tipo &&
        //              item.IdNumMovi2 == Info.IdNumMovi)

        //                info = BusMov.Obtener_list_Movi_inven_Reporte(item.IdEmpresa1, item.IdSucursal1, item.IdBodega1, item.IdMovi_inven_tipo1, item.IdNumMovi1);

        //            if (info != null)
        //            {
                        
        //                LstConsultaMovi.Add(info);
        //            }
        //        }
        //        if (ot.ot_IdOrdenTaller == null)
        //        {
        //            consultacodbar = BusCodBAr.ConsultaGeneral(LstConsultaMovi[0]);
        //            foreach (var item in consultacodbar)
        //            {

        //                ot.ot_CodObra = item.ot_CodObra;
        //                ot.ot_IdOrdenTaller = item.ot_IdOrdenTaller;
        //            }
        //            UCObra.set_item(ot.ot_CodObra);
        //            cargacmbot();
        //            gridLkUOrdenTaller.EditValue = ot.ot_IdOrdenTaller;

        //            Grid = new BindingList<in_movi_inve_detalle_Info>();
        //            Grid = new BindingList<in_movi_inve_detalle_Info>(LstDetMovEgreso);
        //            gridControlDisponible.DataSource = Grid;

        //        }

               

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }


        //}

        //in_movi_inven_x_in_movi_inven_CusCidersus_Bus busTI = new in_movi_inven_x_in_movi_inven_CusCidersus_Bus();
        //List<in_movi_inven_x_in_movi_inven_CusCidersus_Info> ListTI = new List<in_movi_inven_x_in_movi_inven_CusCidersus_Info>();
        //List<in_movi_inve_Info> LstConsultaMovi = new List<in_movi_inve_Info>();
        //private void btnSalir_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //Dictionary<string, decimal> LstDicProd = new Dictionary<string, decimal>();
       
        //void validarepetidos()
        //{
        //    try
        //    {
        //        LstDicProd.Clear();
        //        for (int i = 0; i < gridViewDisponible.RowCount; i++)
        //        {
        //            in_Producto_Info info = (in_Producto_Info)gridViewDisponible.GetRow(i);
        //            if (info != null)
        //            {
        //                string c = info.IdProducto.ToString() + info.pr_codigo_barra;
        //                LstDicProd.Add(c, 1);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("El Registro está repetido, \n Se procedio con su eliminación", "Eliminacion de registro repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        gridViewDisponible.DeleteRow(gridViewDisponible.FocusedRowHandle);
        //    }



        //}

        //private void gridVwEgxProd_RowCountChanged(object sender, EventArgs e)
        //{
        //    //validarepetidos();
        //}

        //private void gridVwEgxProd_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.ToString() == "Delete")
        //        gridViewDisponible.DeleteSelectedRows();
        //}
        
        //public string msg = "";
        
        //List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info> LstSaldoxOT = new List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info>();
        //List<in_movi_inve_detalle_Info> LstProdGrid = new List<in_movi_inve_detalle_Info>();
        
        //in_producto_Bus busProducto = new in_producto_Bus();
        //string autoriza = "";

        //private Boolean PedirAutorizacion()
        //{
        //    try
        //    {
        //        frmPrd_UsuarioAutoriza frm = new frmPrd_UsuarioAutoriza();
        //        frm.ShowDialog();
        //        autoriza = frm.Usuario;
        //        return frm.Autorizado;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }

        //}

        //private void gridVwEgxProd_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    try
        //    {
        //        row = (in_movi_inve_detalle_Info)gridViewDisponible.GetRow(e.RowHandle);
        //        string codbarra = "";
        //        List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> LstDetxProdSaldo = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
        //        vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info ProdCB = new vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info();
        //        if (e.Column.Name  == "colpr_codigo_barra")
        //        {
        //            if (UCObra.get_item_info() == null)
        //            {
        //                MessageBox.Show("Debe seleccionar la Obra Asignada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                panelObra.Focus();

        //            }
        //            else if (gridLkUOrdenTaller.EditValue == null)
        //            {
        //                MessageBox.Show("Debe seleccionar la Orden de Taller Asignada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                gridLkUOrdenTaller.Focus();

        //            }

        //            else
        //            {
        //                List<in_movi_inve_detalle_Info> codigos = new List<in_movi_inve_detalle_Info>();
        //                for (int i = 0; i < gridViewDisponible.RowCount; i++)
        //                {
        //                    var Item = (in_movi_inve_detalle_Info)gridViewDisponible.GetRow(i);
        //                    if (Item != null)
        //                    {
        //                        if (Item.CodBarra != null)
        //                            codigos.Add(Item);
        //                        else
        //                            gridViewDisponible.DeleteRow(i);
        //                    }
        //                }
        //                var co = from q in codigos
        //                         where q.CodBarra == e.Value.ToString()
        //                         select q;

        //                if (co.Count() == 0)
        //                {


        //                    //codbarra = Convert.ToString(e.Value);
        //                    codbarra = row.CodBarra;
        //                    if (row.CodBarra != "")
        //                    {

        //                        getSucBod();

        //                        LstDetxProdSaldo = BusDetxItems.SaldosxItemsxCodBarra(param.IdEmpresa).FindAll(var =>
        //                        var.IdEmpresa == param.IdEmpresa
        //                        && var.IdSucursal == _sucursalInfo.IdSucursal
        //                        && var.IdBodega == _bodegaInfo.IdBodega
        //                        && var.dm_cantidad > 0);

        //                        if (LstDetxProdSaldo.Count <= 0)
        //                        {
        //                            MessageBox.Show("El producto no existe en la bodega " + ctrl_Sucbod.get_bodega().bo_Descripcion,
        //                                   "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                            gridViewDisponible.DeleteRow(gridViewDisponible.FocusedRowHandle);
        //                        }
        //                        else
        //                        {
        //                            try
        //                            {
        //                                //obtengo el producto que tiene ese codigo de barra
        //                                ProdCB = LstDetxProdSaldo.First(var => var.CodigoBarra == codbarra);

        //                            }
        //                            catch (Exception ex)
        //                            {
        //                                MessageBox.Show("El producto no existe en la bodega " + ctrl_Sucbod.get_bodega().bo_Descripcion,
        //                                   "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                                gridViewDisponible.DeleteRow(gridViewDisponible.FocusedRowHandle);
        //                                ProdCB = null;
        //                            }
        //                            if (ProdCB != null)
        //                            {
        //                                if (LstSaldoxOT.Count <= 0)
        //                                {
        //                                    if (MessageBox.Show("La Orden de Taller " + gridLkUOrdenTaller.Text
        //                                        + " no tiene productos pendientes por entregar. ¿Desea pedir autorización?",
        //                                          "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
        //                                    {
        //                                        if (PedirAutorizacion())
        //                                        {

        //                                            //realizar ingreso del producto al grid
        //                                            var producto = busProducto.Get_Info_BuscarProducto(ProdCB.IdProducto, param.IdEmpresa);
        //                                            in_movi_inve_detalle_Info obj = new in_movi_inve_detalle_Info();
        //                                            obj.NomProducto = producto.pr_descripcion;
        //                                            obj.CodProducto = producto.pr_codigo;
        //                                            obj.CodBarra = codbarra;
        //                                            obj.IdProducto = producto.IdProducto;
        //                                            obj.valida = true;
        //                                            obj.oc_observacion = autoriza;
        //                                            LstProdGrid.Add(obj);

        //                                            gridViewDisponible.SetFocusedRowCellValue(colCodProducto, obj.CodProducto);
        //                                            gridViewDisponible.SetFocusedRowCellValue(colNomProducto, obj.NomProducto);
        //                                            gridViewDisponible.SetFocusedRowCellValue(codbarra, obj.CodBarra);
        //                                            gridViewDisponible.SetFocusedRowCellValue(colIdProducto, obj.IdProducto);
        //                                            gridViewDisponible.SetFocusedRowCellValue(colvalida, obj.valida);
        //                                            gridViewDisponible.SetFocusedRowCellValue(colpr_observacion, obj.oc_observacion);
        //                                            //Grid.Add(obj);
        //                                           // gridCtrlEgxProd.DataSource = Grid;



        //                                        }
        //                                    }
        //                                    else
        //                                        gridViewDisponible.DeleteRow(gridViewDisponible.FocusedRowHandle);
        //                                }
        //                                else
        //                                {



        //                                    //verifica que el producto que se ingresa se encuentre asignado  a la Ot
        //                                    bool flag = false;
        //                                    foreach (var item in LstSaldoxOT)
        //                                    {
        //                                        if (item.ped_IdProducto == ProdCB.IdProducto)
        //                                        {
        //                                            int cantsolicitada;
        //                                            try
        //                                            {
        //                                                cantsolicitada = LstProdGrid.FindAll(var => var.IdProducto == ProdCB.IdProducto).Count;
        //                                            }
        //                                            catch (Exception)
        //                                            {
        //                                                cantsolicitada = 0;
        //                                            }

        //                                            if (cantsolicitada <= item.saldo)
        //                                            {
        //                                                //realizar ingreso del producto al grid
        //                                                var producto = busProducto.Get_Info_BuscarProducto(ProdCB.IdProducto, param.IdEmpresa);
        //                                                in_movi_inve_detalle_Info obj = new in_movi_inve_detalle_Info();
        //                                                obj.NomProducto = producto.pr_descripcion;
        //                                                obj.CodProducto = producto.pr_codigo;
        //                                                obj.CodBarra = codbarra;
        //                                                obj.IdProducto = producto.IdProducto;
        //                                                obj.valida = false;
        //                                                obj.oc_observacion = "";
        //                                                LstProdGrid.Add(obj);



        //                                                gridViewDisponible.SetFocusedRowCellValue(colCodProducto, obj.CodProducto);
        //                                                gridViewDisponible.SetFocusedRowCellValue(colNomProducto, obj.NomProducto);
        //                                                gridViewDisponible.SetFocusedRowCellValue(codbarra, obj.CodBarra);
        //                                                gridViewDisponible.SetFocusedRowCellValue(colIdProducto, obj.IdProducto);
        //                                                gridViewDisponible.SetFocusedRowCellValue(colvalida, obj.valida);
        //                                                gridViewDisponible.SetFocusedRowCellValue(colpr_observacion, obj.oc_observacion);
        //                                                //Grid.Add(obj);
        //                                                // gridCtrlEgxProd.DataSource = Grid;


        //                                                flag = true;
        //                                                break;
        //                                            }
        //                                            else
        //                                            {
        //                                                if (MessageBox.Show("La Orden de Taller" + gridLkUOrdenTaller.Text
        //                                            + " ha sobrepasado la cant de ese producto. ¿Desea pedir autorización?", "Sistema",
        //                                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
        //                                                {
        //                                                    if (PedirAutorizacion())
        //                                                    {

        //                                                        //realizar ingreso del producto al grid
        //                                                        var producto = busProducto.Get_Info_BuscarProducto(ProdCB.IdProducto, param.IdEmpresa);
        //                                                        in_movi_inve_detalle_Info obj = new in_movi_inve_detalle_Info();
        //                                                        obj.NomProducto = producto.pr_descripcion;
        //                                                        obj.CodProducto = producto.pr_codigo;
        //                                                        obj.CodBarra = codbarra;
        //                                                        obj.IdProducto = producto.IdProducto;
        //                                                        obj.valida = true;
        //                                                        obj.oc_observacion = autoriza;
        //                                                        LstProdGrid.Add(obj);


        //                                                        gridViewDisponible.SetFocusedRowCellValue(colCodProducto, obj.CodProducto);
        //                                                        gridViewDisponible.SetFocusedRowCellValue(colNomProducto, obj.NomProducto);
        //                                                        gridViewDisponible.SetFocusedRowCellValue(codbarra, obj.CodBarra);
        //                                                        gridViewDisponible.SetFocusedRowCellValue(colIdProducto, obj.IdProducto);
        //                                                        gridViewDisponible.SetFocusedRowCellValue(colvalida, obj.valida);
        //                                                        gridViewDisponible.SetFocusedRowCellValue(colpr_observacion, obj.oc_observacion);
        //                                                        //Grid.Add(obj);
        //                                                        // gridCtrlEgxProd.DataSource = Grid;


        //                                                        flag = true;
        //                                                        break;

        //                                                    }
        //                                                }
        //                                                else
        //                                                    gridViewDisponible.DeleteRow(gridViewDisponible.FocusedRowHandle);

        //                                            }

        //                                        }
        //                                        else flag = false;
        //                                    }
        //                                    if (flag == false)
        //                                    {
        //                                        if (MessageBox.Show("La Orden de Taller" + gridLkUOrdenTaller.Text
        //                                        + " no tiene asignado ese producto. ¿Desea pedir autorización?", "Sistema",
        //                                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
        //                                        {
        //                                            if (PedirAutorizacion())
        //                                            {

        //                                                //realizar ingreso del producto al grid
        //                                                var producto = busProducto.Get_Info_BuscarProducto(ProdCB.IdProducto, param.IdEmpresa);
        //                                                in_movi_inve_detalle_Info obj = new in_movi_inve_detalle_Info();
        //                                                obj.NomProducto = producto.pr_descripcion;
        //                                                obj.CodProducto = producto.pr_codigo;
        //                                                obj.CodBarra = codbarra;
        //                                                obj.IdProducto = producto.IdProducto;
        //                                                obj.valida = true;
        //                                                obj.oc_observacion = autoriza;
        //                                                LstProdGrid.Add(obj);


        //                                                gridViewDisponible.SetFocusedRowCellValue(colCodProducto, obj.CodProducto);
        //                                                gridViewDisponible.SetFocusedRowCellValue(colNomProducto, obj.NomProducto);
        //                                                gridViewDisponible.SetFocusedRowCellValue(codbarra, obj.CodBarra);
        //                                                gridViewDisponible.SetFocusedRowCellValue(colIdProducto, obj.IdProducto);
        //                                                gridViewDisponible.SetFocusedRowCellValue(colvalida, obj.valida);
        //                                                gridViewDisponible.SetFocusedRowCellValue(colpr_observacion, obj.oc_observacion);
        //                                                //Grid.Add(obj);
        //                                                // gridCtrlEgxProd.DataSource = Grid;



        //                                            }
        //                                        }
        //                                        else
        //                                            gridViewDisponible.DeleteRow(gridViewDisponible.FocusedRowHandle);





        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("El Registro está repetido, \n Se procedio con su eliminación", "Eliminacion de registro repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                    gridViewDisponible.DeleteRow(gridViewDisponible.FocusedRowHandle);
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //private void gridLkUOrdenTaller_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        LstSaldoxOT = new List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info>();
        //        getSucBod();
        //        if (gridLkUOrdenTaller.EditValue != "")
        //        {
        //            LstSaldoxOT = BusDetxItems.DisponiblesxReqOt(param.IdEmpresa, UCObra.get_item(), _sucursalInfo.IdSucursal,
        //                       Convert.ToDecimal(gridLkUOrdenTaller.EditValue), ref msg);
        //            if (LstSaldoxOT != null)
        //            {
        //                LstSaldoxOT.ForEach(var => var.saldo = (var.saldo == null) ? var.ped_saldo : var.saldo);
        //            }
        //            Grid = new BindingList<in_movi_inve_detalle_Info>();
        //            gridControlDisponible.DataSource = Grid;

        //            prd_OrdenTaller_Bus BusOT = new prd_OrdenTaller_Bus();
        //            OT = BusOT.ObtenerUnaOT(param.IdEmpresa, ctrl_Sucbod.get_sucursal().IdSucursal,
        //                Convert.ToDecimal(gridLkUOrdenTaller.EditValue), UCObra.get_item());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //       // MessageBox.Show(ex.InnerException.ToString());
                
        //    }
            
        //}

       
        //in_producto_x_tb_bodega_Bus Bus_prodxbod = new in_producto_x_tb_bodega_Bus();
        
        //tb_Bodega_Bus busbod = new tb_Bodega_Bus();
        
        //private Boolean getCab()
        //{
        //    try
        //    {
        //        MovEgreso = new in_movi_inve_Info();
        //        getSucBod();
        //        MovIngreso.IdEmpresa = MovEgreso.IdEmpresa = param.IdEmpresa;
        //        MovEgreso.IdSucursal = _sucursalInfo.IdSucursal;
        //        MovIngreso.IdSucursal = paramCidersus.IdSucursal_Produccion;
        //        MovEgreso.IdBodega = _bodegaInfo.IdBodega;
        //        MovIngreso.IdBodega = paramCidersus.IdBodega_Produccion;
        //        MovIngreso.cm_anio =  MovEgreso.cm_anio = dtpFecha.Value.Year;
        //        MovIngreso.cm_fecha= MovEgreso.cm_fecha = dtpFecha.Value;
        //        MovIngreso.cm_mes = MovEgreso.cm_mes = dtpFecha.Value.Month;
        //        MovEgreso.cm_tipo = "-";
        //        MovIngreso.cm_tipo = "+";
        //        MovIngreso.Estado = MovEgreso.Estado = "A";
        //        MovEgreso.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_egr_consumoprod);
        //        MovIngreso.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_ing_consumoprod);

        //        var bod = busbod.Obtener_Objeto(param.IdEmpresa,
        //            paramCidersus.IdSucursal_Produccion, paramCidersus.IdBodega_Produccion);

               
                
        //        MovEgreso.IdUsuario  =MovIngreso.IdUsuario = param.IdUsuario;
        //        MovEgreso.nom_pc = MovIngreso.nom_pc = param.nom_pc;
        //        MovEgreso.ip = MovIngreso.ip = param.ip;
        //        MovEgreso.Fecha_Transac = MovIngreso.Fecha_Transac = param.Fecha_Transac;

        //        int sec = 0;

        //        foreach (var item in LstProdGrid)
        //        {
        //            in_movi_inve_detalle_Info ing = new in_movi_inve_detalle_Info();
        //            in_movi_inve_detalle_Info egr = new in_movi_inve_detalle_Info();
        //            in_movi_inve_detalle_x_Producto_CusCider_Info ItemCodBarIng = new in_movi_inve_detalle_x_Producto_CusCider_Info();
        //                   in_movi_inve_detalle_x_Producto_CusCider_Info ItemCodBarEgr = new in_movi_inve_detalle_x_Producto_CusCider_Info();
             
        //            ItemCodBarIng.IdEmpresa= ItemCodBarEgr.IdEmpresa = ing.IdEmpresa = egr.IdEmpresa = param.IdEmpresa;
        //            ItemCodBarIng.IdSucursal = ing.IdSucursal = MovIngreso.IdSucursal;
        //            ItemCodBarEgr.IdSucursal = egr.IdSucursal = MovEgreso.IdSucursal;
        //            ItemCodBarIng.IdBodega =ing.IdBodega = MovIngreso.IdBodega;
        //            ItemCodBarEgr.IdBodega =egr.IdBodega = MovEgreso.IdBodega;
        //            ing.dm_cantidad = ItemCodBarIng.dm_cantidad = 1;
        //            egr.dm_cantidad = ItemCodBarEgr.dm_cantidad = -1;
        //            ing.IdMovi_inven_tipo = ItemCodBarIng.IdMovi_inven_tipo = MovIngreso.IdMovi_inven_tipo;
        //            egr.IdMovi_inven_tipo = ItemCodBarEgr.IdMovi_inven_tipo = MovEgreso.IdMovi_inven_tipo;
        //            egr.Secuencia = ing.Secuencia = ItemCodBarEgr.mv_Secuencia = ItemCodBarIng.mv_Secuencia = ++sec;
                    
        //            var saldoing = Bus_prodxbod.ObtenerObjeto(param.IdEmpresa, MovIngreso.IdSucursal, MovIngreso.IdBodega, item.IdProducto);
        //            var saldoegr = Bus_prodxbod.ObtenerObjeto(param.IdEmpresa, MovEgreso.IdSucursal, MovEgreso.IdBodega, item.IdProducto);
        //            ing.dm_stock_ante = saldoing.pr_stock;
        //            ing.dm_stock_actu = saldoing.pr_stock + ing.dm_cantidad;
        //            egr.dm_stock_ante = saldoegr.pr_stock;
        //            egr.dm_stock_actu = saldoegr.pr_stock - egr.dm_cantidad;

        //            ItemCodBarIng.ot_IdEmpresa = param.IdEmpresa;
        //            ItemCodBarIng.ot_IdSucursal = OT.IdSucursal;
        //            ItemCodBarIng.ot_IdOrdenTaller = OT.IdOrdenTaller;
        //            ItemCodBarIng.ot_CodObra = OT.CodObra;
        //            ing.IdProducto = egr.IdProducto= ItemCodBarEgr.IdProducto= ItemCodBarIng.IdProducto = item.IdProducto;
        //            ItemCodBarEgr.CodigoBarra = ItemCodBarIng.CodigoBarra = item.CodBarra;
        //            ing.mv_tipo_movi = ItemCodBarIng.mv_tipo_movi = MovIngreso.cm_tipo;
        //            egr.mv_tipo_movi = ItemCodBarEgr.mv_tipo_movi = MovEgreso.cm_tipo;

        //            in_Producto_Info prod = new in_Producto_Info();
        //            prod = busProducto.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);


        //            ItemCodBarEgr.dm_observacion = egr.dm_observacion = item.dm_observacion +
        //                 " Eg Prod " + prod.pr_descripcion;
        //            ItemCodBarIng.dm_observacion = ing.dm_observacion = item.dm_observacion +
        //               " Ing Prod " + prod.pr_descripcion;
        //            if (item.valida == true )
        //            {
        //                ItemCodBarEgr.dm_observacion = egr.dm_observacion = "Aut x: " + item.oc_observacion + "-" + egr.dm_observacion;
        //                ItemCodBarIng.dm_observacion = ing.dm_observacion = "Aut x: " + item.oc_observacion + "-"+ing.dm_observacion;
                    
        //            }
        //            MovEgreso.cm_observacion = MovEgreso.cm_observacion + egr.dm_observacion;
        //            MovIngreso.cm_observacion = MovIngreso.cm_observacion + ing.dm_observacion;
                    
        //            ItemCodBarEgr.dm_observacion = egr.dm_observacion =  "Eg Suc " + ctrl_Sucbod.cmb_sucursal.Text.Trim() +
        //           " Bod " + ctrl_Sucbod.cmb_bodega.Text.Trim() +
        //           " Egr x Cons Prod -" + MovEgreso.cm_observacion + " "+txtObservacion.Text + egr.dm_observacion ;

        //            ItemCodBarIng.dm_observacion = ing.dm_observacion ="Ing Suc " + bod.NomSucursal.Trim() +
        //          " Bod " + bod.bo_Descripcion.Trim() +
        //          " Ing x Cons Prod -" + MovIngreso.cm_observacion + " " + txtObservacion.Text + ing.dm_observacion;
                    
        //            LstDetMovEgreso.Add(egr);
        //            LstDetMovIngreso.Add(ing);
        //            LstDetxItemsEgr.Add(ItemCodBarEgr);
        //            LstDetxItemsIng.Add(ItemCodBarIng);

        //        }
        //        MovEgreso.cm_observacion = txtObservacion.Text + "Eg Suc " + ctrl_Sucbod.cmb_sucursal.Text.Trim() +
        //           " Bod " + ctrl_Sucbod.cmb_bodega.Text.Trim() +
        //           " Egr x Cons Prod -" + MovEgreso.cm_observacion;
        //        MovIngreso.cm_observacion = txtObservacion.Text + "Ing Suc " + bod.NomSucursal.Trim() +
        //          " Bod " + bod.bo_Descripcion.Trim() +
        //          " Ing x Cons Prod -" + MovIngreso.cm_observacion;

        //        MovEgreso.listmovi_inve_detalle_Info = LstDetMovEgreso;
        //        MovIngreso.listmovi_inve_detalle_Info = LstDetMovIngreso;
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {

        //        return false;
        //    }
        
        
        //}

        //private Boolean validaciones()
        //{
        //    try
        //    {
        //        if (txtObservacion.Text == "")
        //        {
        //            MessageBox.Show("Debe ingresar una observacion", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            return  false;
        //        }
        //        if (gridLkUOrdenTaller.EditValue == null)
        //        {
        //            MessageBox.Show("Escoja la Orden de Taller a la que van destinados los productos ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            return  false;
        //        }
        //        if (LstProdGrid != null)
        //        {
        //            if (LstProdGrid.Count <= 0)
        //            {
        //                MessageBox.Show("Debe existir al menos 1 item verifique ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                return false;
        //            }
        //        }
        //        else 
        //        {
        //            MessageBox.Show("Debe existir al menos 1 item verifique ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            return false;
        //        }
        //        foreach (var item in LstProdGrid)
        //        {
                    
        //                        in_producto_x_tb_bodega_Bus Busprodxbod = new in_producto_x_tb_bodega_Bus();
        //                        List<in_producto_x_tb_bodega_Info> LstProdxBod = new List<in_producto_x_tb_bodega_Info>();
        //                        Boolean existeenbod = false;
        //                        LstProdxBod = Busprodxbod.ObtenerExisteProductoxBodega(param.IdEmpresa, item.IdProducto);
        //                        if (LstProdxBod != null)
        //                        {
        //                            foreach (var ProdxBodega in LstProdxBod)
        //                            {
        //                                if (ProdxBodega.IdBodega == paramCidersus.IdBodega_Produccion)
        //                                    existeenbod = true;

        //                            }
        //                            if (existeenbod == false)
        //                            {
        //                                var prod = busProducto.Get_Info_BuscarProducto(item.IdProducto, item.IdEmpresa);
        //                                MessageBox.Show("Asigne el producto " + prod.pr_descripcion  + " a la bodega de Producción", "Sistema"
        //                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //                                return false;
        //                            }
        //                        }
        //                        else
        //                        {
        //                            var prod = busProducto.Get_Info_BuscarProducto(item.IdProducto, item.IdEmpresa);
                                       
        //                            MessageBox.Show("Asigne el producto " + prod.pr_descripcion + " a la bodega de Producción", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //                            return false;
        //                        }
        //        }
        //        return getCab();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ha ocurrido un error en:" + ex.ToString());
        //        return false;
        //    }

        
        //}
        
        //private Boolean  grabar()
        //{
        //    try
        //    {
        //        if (validaciones())
        //        {
        //            decimal idAjusteOut;
        //            idAjusteOut = 0;
        //            decimal idAjusteIng;
        //            idAjusteIng = 0;
        //            if (BusMov.GuardarMovimientoInvetarioCabYDetYActuStock(MovEgreso, ref idAjusteOut,
        //                ref msg))
        //            {
        //                LstDetxItemsEgr.ForEach(var => var.IdNumMovi = idAjusteOut);
        //                if (BusDetxItems.GuardarDB(LstDetxItemsEgr, ref msg))
        //                {
        //                    if (BusMov.GuardarMovimientoInvetarioCabYDetYActuStock(MovIngreso, ref idAjusteIng, ref msg))
        //                    {
        //                        LstDetxItemsIng.ForEach(var => var.IdNumMovi = idAjusteIng);
        //                        if (BusDetxItems.GuardarDB(LstDetxItemsIng, ref msg))
        //                        {
        //                            in_movi_inven_x_in_movi_inven_CusCidersus_Info TI = new in_movi_inven_x_in_movi_inven_CusCidersus_Info();

        //                            TI.IdEmpresa1 = MovEgreso.IdEmpresa;
        //                            TI.IdSucursal1 = MovEgreso.IdSucursal;
        //                            TI.IdBodega1 = MovEgreso.IdBodega;
        //                            TI.IdMovi_inven_tipo1 = MovEgreso.IdMovi_inven_tipo;
        //                            TI.IdNumMovi1 = MovEgreso.IdNumMovi;
        //                            TI.IdEmpresa2 = MovIngreso.IdEmpresa;
        //                            TI.IdSucursal2 = MovIngreso.IdSucursal;
        //                            TI.IdBodega2 = MovIngreso.IdBodega;
        //                            TI.IdMovi_inven_tipo2 = MovIngreso.IdMovi_inven_tipo;
        //                            TI.IdNumMovi2 = MovIngreso.IdNumMovi;

        //                            if (busTI.GuardarTIMovim_EgresoConsumo(TI))
        //                            {
        //                                txtNumAjuste.Text = Convert.ToString(idAjusteOut);
        //                                MessageBox.Show("Ajuste # " + idAjusteOut + ". Egreso por Consumo de Producción."
        //                                    + " Grabado Satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                                setCab(MovEgreso);
        //                                set_Accion(Cl_Enumeradores.eTipo_action.consultar);

        //                                return true;
        //                            }
        //                            else return false;
        //                        }
        //                        else return false;

        //                    }
        //                    else return false;
        //                }
        //                else return false;

        //            }
        //            else return false;
        //        }
        //        else return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;

        //    }
           
               
        //}


        //private void btn_guardar_Click(object sender, EventArgs e)
        //{
        //    grabar();
        //}

        //private void gridVwEgxProd_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        //{
        //    var data = gridViewDisponible.GetRow(e.RowHandle) as in_movi_inve_detalle_Info ;
        //    if (data == null)
        //        return;
        //    if (data.valida == true)
        //        e.Appearance.ForeColor = Color.Red;
        //}

        //private void txtIngCB_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //}

        //private void gridViewDisponible_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        //{

        //}

 
        
    }
}
