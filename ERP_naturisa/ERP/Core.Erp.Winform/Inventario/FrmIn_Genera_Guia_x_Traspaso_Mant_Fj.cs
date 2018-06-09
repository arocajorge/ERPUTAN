using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

using Core.Erp.Winform.Compras;

using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

using Cus.Erp.Reports.FJ.CuentasxPagar;

namespace Core.Erp.Winform.Inventario
{


 
    public partial class FrmIn_Genera_Guia_x_Traspaso_Mant_Fj : Form
    {

        #region
        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus buSucursal = new tb_Sucursal_Bus();
        in_Guia_x_traspaso_bodega_Bus bus_GuixTrasBod = new in_Guia_x_traspaso_bodega_Bus();
        com_ordencompra_local_Bus BusOC = new com_ordencompra_local_Bus();
        cp_proveedor_Bus BusProv = new cp_proveedor_Bus();
        in_producto_Bus busProducto = new in_producto_Bus();
        in_Guia_x_traspaso_bodega_det_Bus busGuiaconOC = new in_Guia_x_traspaso_bodega_det_Bus();
        in_Guia_x_traspaso_bodega_det_sin_oc_Bus busGuiasinOC = new in_Guia_x_traspaso_bodega_det_sin_oc_Bus();
        tb_transportista_Bus busTraspor = new tb_transportista_Bus();
        vwIn_Motivo_traslado_bodega_Bus bus_MotiTrasBod = new vwIn_Motivo_traslado_bodega_Bus();
        in_transferencia_bus Bus_Transferencia = new Business.Inventario.in_transferencia_bus();

        in_Guia_x_traspaso_bodega_x_in_transferencia_det_Bus Bus_guiaDetalle = new Business.Inventario.in_Guia_x_traspaso_bodega_x_in_transferencia_det_Bus();
        //Listas
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        List<in_Guia_x_traspaso_bodega_det_Info> listDet_OC;
        List<in_Guia_x_traspaso_bodega_det_sin_oc_Info> listDetSin_OC;
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
        List<cp_proveedor_Info> LstInfoProv = new List<cp_proveedor_Info>();
        List<in_Guia_x_traspaso_bodega_det_Info> listGuiaDetconOC = new List<in_Guia_x_traspaso_bodega_det_Info>();
        List<in_Guia_x_traspaso_bodega_det_sin_oc_Info> listGuiaDetsinOC = new List<in_Guia_x_traspaso_bodega_det_sin_oc_Info>();

        BindingList<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info> Lista_Detalle_transferencia = new BindingList<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info>();
        List<in_transferencia_det_Info> Lista_Detalle_transferencia_tmp = new List <in_transferencia_det_Info>();
        List<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info> Lista_Grabar = new List<Info.Inventario.in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info>();
        //Infos
        in_Guia_x_traspaso_bodega_Info Info_GuiaBodega = new in_Guia_x_traspaso_bodega_Info();
        in_transferencia_Info info_Transf = new Info.Inventario.in_transferencia_Info();

        //Varibales
        private Cl_Enumeradores.eTipo_action Accion;
        public in_Guia_x_traspaso_bodega_Info _SetInfo { get; set; }
        string mensaje = "";
        #endregion
        public FrmIn_Genera_Guia_x_Traspaso_Mant_Fj()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (grabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (grabar())
                {
                    LimpiarDatos();
                    set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                    ucGe_Menu_();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {

                if (Anular())
                    Close();

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
                set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                txtIdGuia.Text = "";
                txtNumGuia.Text = "";
                txtDirPuntoPart.Text = "";
                txtDirPuntoLlega.Text = "";
                txtNumOC_Quitar.Text = "";
                cmbPuntoPartida.EditValue = null;
                cmbPuntoLlega.EditValue = null;
                cmbTrasnportador.set_TransportistaInfo(0);
                cmbMotivoTras.set_CatalogosInfo("");
                dtpFecha.Value = DateTime.Now;
                dtpFechaTras.Value = DateTime.Now;
                dtpFechaLlega.Value = DateTime.Now;

                timeHoraLlegada.EditValue = DateTime.Now;
                timeHoraTraslado.EditValue = DateTime.Now;

            

                Info_GuiaBodega = new in_Guia_x_traspaso_bodega_Info();
                Info_GuiaBodega.list_detalle_Guia_Sin_OC = new List<in_Guia_x_traspaso_bodega_det_sin_oc_Info>();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean grabar()
        {
            try
            {
                Boolean boolResult = false;


                boolResult = ValidarDatos();

                if (boolResult)
                {


                    Get();
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:

                            this.txtIdGuia.Focus();
                            decimal idGuia = 0;

                            if( bus_GuixTrasBod.GuardarDB(Info_GuiaBodega, ref idGuia, ref mensaje))
                            {
                                
                                
                                txtIdGuia.Text = Convert.ToString(idGuia);
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Guía de Traspaso a Bodega ", idGuia.ToString());
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                            else
                            {
                                MessageBox.Show("Error al grabar la Guía de Traspaso a Bodega, " + mensaje, param.Nombre_sistema);
                            }

                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:

                            Info_GuiaBodega.IdUsuarioUltMod = param.IdUsuario;
                            Info_GuiaBodega.Fecha_UltMod = param.Fecha_Transac;

                            if( bus_GuixTrasBod.ModificarDB(Info_GuiaBodega, ref mensaje))                           
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Guía de Traspaso a Bodega ", Info_GuiaBodega.IdGuia.ToString());
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                boolResult = true;
                            }
                            else
                            {
                                MessageBox.Show("Error al Actualizar la Guía de Traspaso a Bodega, " + mensaje, param.Nombre_sistema);
                            }
                            break;

                        case Cl_Enumeradores.eTipo_action.Anular:
                            
                          
                            break;
                        default:
                            break;
                    }
                }

                return boolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        void Get()
        {
            try
            {
                Info_GuiaBodega.IdEmpresa = param.IdEmpresa;
                Info_GuiaBodega.IdGuia = Convert.ToDecimal((txtIdGuia.Text == "") ? "0" : txtIdGuia.Text);
                Info_GuiaBodega.NumGuia = txtNumGuia.Text;
                Info_GuiaBodega.IdSucursal_Partida = Convert.ToInt32(cmbPuntoPartida.EditValue);
                Info_GuiaBodega.IdSucursal_Llegada = Convert.ToInt32(cmbPuntoLlega.EditValue);
                Info_GuiaBodega.Direc_sucu_Partida = txtDirPuntoPart.Text;
                Info_GuiaBodega.Direc_sucu_Llegada = txtDirPuntoLlega.Text;
                Info_GuiaBodega.IdTransportista = cmbTrasnportador.get_Transportistas().IdTransportista;
                Info_GuiaBodega.Fecha = dtpFecha.Value;
                Info_GuiaBodega.Fecha_Traslado = dtpFechaTras.Value;
                Info_GuiaBodega.Fecha_llegada = dtpFechaLlega.Value;
                Info_GuiaBodega.IdMotivo_Traslado = cmbMotivoTras.Get_CatalogosInfo().IdCatalogo;
                Info_GuiaBodega.IdUsuario = param.IdUsuario;
                Info_GuiaBodega.Fecha_Transac = param.Fecha_Transac;
                Info_GuiaBodega.nom_pc = param.nom_pc;
                Info_GuiaBodega.ip = param.ip;

                DateTime FechI = (DateTime)timeHoraLlegada.EditValue;
                DateTime FechF = (DateTime)timeHoraTraslado.EditValue;

                Info_GuiaBodega.Hora_Llegada = FechI.TimeOfDay;
                Info_GuiaBodega.Hora_Traslado = FechF.TimeOfDay;


                Get_detalle();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Set()
        {
            try
            {
                txtIdGuia.Text = _SetInfo.IdGuia.ToString();
                txtNumGuia.Text = _SetInfo.NumGuia;
                cmbPuntoPartida.EditValue = _SetInfo.IdSucursal_Partida;
                cmbPuntoLlega.EditValue = _SetInfo.IdSucursal_Llegada;
                txtDirPuntoPart.Text = _SetInfo.Direc_sucu_Partida;
                txtDirPuntoLlega.Text = _SetInfo.Direc_sucu_Llegada;
                cmbTrasnportador.set_TransportistaInfo(Convert.ToDecimal(_SetInfo.IdTransportista));
                dtpFecha.Value = _SetInfo.Fecha;
                dtpFechaTras.Value = _SetInfo.Fecha_Traslado;
                dtpFechaLlega.Value = _SetInfo.Fecha_llegada;
                cmbMotivoTras.set_CatalogosInfo(_SetInfo.IdMotivo_Traslado);


                DateTime FH_lle = new DateTime(_SetInfo.Fecha_Traslado.Year, _SetInfo.Fecha_Traslado.Month, _SetInfo.Fecha_Traslado.Day, 0, 0, 0);
                DateTime FH_Tras = new DateTime(_SetInfo.Fecha_Traslado.Year, _SetInfo.Fecha_Traslado.Month, _SetInfo.Fecha_Traslado.Day, 0, 0, 0);

                if (_SetInfo.Hora_Llegada == null)
                {
                    timeHoraLlegada.EditValue = FH_lle;
                }
                else
                {
                    timeHoraLlegada.EditValue = new DateTime(_SetInfo.Fecha_Traslado.Year, _SetInfo.Fecha_Traslado.Month, _SetInfo.Fecha_Traslado.Day, _SetInfo.Hora_Llegada.Value.Hours, _SetInfo.Hora_Llegada.Value.Minutes, _SetInfo.Hora_Llegada.Value.Seconds);
                }

                if (_SetInfo.Hora_Traslado == null)
                {
                    timeHoraTraslado.EditValue = FH_Tras;
                }
                else
                {
                    timeHoraTraslado.EditValue = new DateTime(_SetInfo.Fecha_Traslado.Year, _SetInfo.Fecha_Traslado.Month, _SetInfo.Fecha_Traslado.Day, _SetInfo.Hora_Traslado.Value.Hours, _SetInfo.Hora_Traslado.Value.Minutes, _SetInfo.Hora_Traslado.Value.Seconds);
                }


                if (_SetInfo.Estado.TrimEnd() == "I")
                {
                    lblAnulado.Visible = true;
                }
                else
                {
                    lblAnulado.Visible = false;
                }

                //consulta detalles

                 
                Lista_Detalle_transferencia=new BindingList<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info>( Bus_guiaDetalle.Get_lista(_SetInfo.IdEmpresa,Convert.ToInt32( _SetInfo.IdGuia)));
                gridControlConsulta.DataSource = Lista_Detalle_transferencia;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void carga_combos()
        {
            try
            {
                listSucursal = buSucursal.Get_List_Sucursal(param.IdEmpresa);
                cmbPuntoPartida.Properties.DataSource = listSucursal;
                cmbPuntoLlega.Properties.DataSource = listSucursal;

                LstInfoProv = BusProv.Get_List_proveedor(param.IdEmpresa);
               // cmbProveedor_grid.DataSource = LstInfoProv;

                listProducto = busProducto.Get_list_Producto(param.IdEmpresa);
                cmb_productos.DataSource = listProducto;

                cmbMotivoTras.cargar_Catalogos(3);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Inhabilita_Controles()
        {
            try
            {
                txtIdGuia.Enabled = false;
                txtIdGuia.BackColor = System.Drawing.Color.White;
                txtIdGuia.ForeColor = System.Drawing.Color.Black;

                txtNumGuia.Enabled = false;
                txtNumGuia.BackColor = System.Drawing.Color.White;
                txtNumGuia.ForeColor = System.Drawing.Color.Black;

                cmbPuntoPartida.Enabled = false;
                cmbPuntoPartida.BackColor = System.Drawing.Color.White;
                cmbPuntoPartida.ForeColor = System.Drawing.Color.Black;

                cmbPuntoLlega.Enabled = false;
                cmbPuntoLlega.BackColor = System.Drawing.Color.White;
                cmbPuntoLlega.ForeColor = System.Drawing.Color.Black;

                cmbTrasnportador.Enabled = false;
                cmbTrasnportador.BackColor = Color.White;
                cmbTrasnportador.ForeColor = Color.Black;

                txtDirPuntoPart.Enabled = false;
                txtDirPuntoPart.BackColor = System.Drawing.Color.White;
                txtDirPuntoPart.ForeColor = System.Drawing.Color.Black;

                txtDirPuntoLlega.Enabled = false;
                txtDirPuntoLlega.BackColor = System.Drawing.Color.White;
                txtDirPuntoLlega.ForeColor = System.Drawing.Color.Black;


                cmbMotivoTras.Enabled = false;
                cmbMotivoTras.BackColor = System.Drawing.Color.White;
                cmbMotivoTras.ForeColor = System.Drawing.Color.Black;

                dtpFecha.Enabled = false;
                dtpFechaTras.Enabled = false;
                dtpFechaLlega.Enabled = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ucGe_Menu_()
        {
            try
            {

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu.Enabled_btnGuardar = true;
                        ucGe_Menu.Enabled_bntLimpiar = false;

                      
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu.Enabled_btnGuardar = true;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Inhabilita_Controles();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Inhabilita_Controles();
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        Set();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        Boolean ValidarDatos()
        {
            try
            {
                if (cmbPuntoPartida.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Punto de Partida", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (cmbPuntoLlega.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Punto de Llegada", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (cmbTrasnportador.get_Transportistas() == null)
                {
                    MessageBox.Show("Seleccione el Transportista", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (cmbMotivoTras.Get_CatalogosInfo() == null)
                {
                    MessageBox.Show("Seleccione el Motivo del Traslado", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (cmbTrasnportador.get_Transportistas() == null)
                {
                    MessageBox.Show("Seleccione el Transportista", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (dtpFecha.Value == null)
                {
                    MessageBox.Show("Seleccione la Fecha", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (dtpFechaTras.Value == null)
                {
                    MessageBox.Show("Seleccione la Fecha del Traslado", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (dtpFechaLlega.Value == null)
                {
                    MessageBox.Show("Seleccione la Fecha de Llegada", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }



                

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnAgregar_OC_Click(object sender, EventArgs e)
        {

            try
            {
                //checkTodos.Checked = false;
                FrmIn_Transferencia_Sin_Guia_Cons frm = new FrmIn_Transferencia_Sin_Guia_Cons();
                frm.ShowDialog();

                info_Transf = frm.info_Transferencia;
                cmbPuntoPartida.EditValue = info_Transf.IdSucursalDest;
                cmbPuntoLlega.EditValue = info_Transf.IdSucursalOrigen;
                Lista_Detalle_transferencia_tmp = Bus_Transferencia.Get_List_transferencia_det_sin_Guia(info_Transf, info_Transf.IdEmpresa);
                if (Lista_Detalle_transferencia_tmp.Count() == 0)
                {
                    MessageBox.Show("La transferencia no tiene detalle o fue ligada a otra Guia de remision, " , param.Nombre_sistema);
                    return;
                }
                foreach (var item in Lista_Detalle_transferencia_tmp)
                {
                    in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info info = new Info.Inventario.in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info();

                    info.Sucursal_Destino = info_Transf.Sucursal_Destino;
                    info.bo_Descripcion_origen = info_Transf.Bodega_Origen;
                    info.IdTransferencia = item.IdTransferencia;
                    info.pr_descripcion = item.pr_descripcion;
                    info.dt_cantidad = item.dt_cantidad;
                    info.observacion = item.tr_Observacion;
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdEmpresa_tras = item.IdEmpresa;
                    info.IdBodegaOrigen = item.IdBodegaOrigen;
                    info.dt_secuencia = item.dt_secuencia;
                    info.IdSucursalOrigen = item.IdSucursalOrigen;
                    //item.check = true;

                    if (Lista_Detalle_transferencia.Where(v => v.IdTransferencia == item.IdTransferencia && v.dt_secuencia == item.dt_secuencia).Count() == 0)
                    {
                        Lista_Detalle_transferencia.Add(info);
                    }
                }
                gridControlConsulta.DataSource = Lista_Detalle_transferencia;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void convertir_infotabla(List<com_ordencompra_local_Info> ListOCSinGuia, string STipoConsulta)
        {
            try
            {

                foreach (var item in ListOCSinGuia)
                {
                    in_Guia_x_traspaso_bodega_det_Info info = new in_Guia_x_traspaso_bodega_det_Info();

                    if (item.do_Cantidad != 0)
                    {
                        info.IdEmpresa_OC = item.IdEmpresa;
                        info.IdSucursal_OC = item.IdSucursal;
                        info.IdOrdenCompra_OC = item.IdOrdenCompra;

                        info.oc_NumDocumento = item.oc_NumDocumento;
                        info.pr_nombre = item.nom_proveedor;
                        info.IdProducto = item.IdProducto;
                        info.pr_descripcion = item.nom_producto;
                        info.Secuencia_OC = item.Secuencia;

                        if (STipoConsulta == "xOC")
                        {
                            info.Cantidad_enviar = item.do_Cantidad;

                        }
                        else
                        {
                            info.Cantidad_enviar = item.Cantidad_enviar;

                        }




                        info.Cantidad_Saldo = item.do_Cantidad - item.Cantidad_enviar;
                        info.Cantidad_Saldo_Auxi = info.Cantidad_Saldo;
                        info.Cantidad_OC = item.do_Cantidad;


                        info.observacion = item.oc_observacion;
                        info.Check_OG = true;

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Genera_Guia_x_Traspaso_Mant_Fj_Load(object sender, EventArgs e)
        {
            try
            {

                carga_combos();
                set_accion_controls();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void set_accion_controls()
        {
            try
            {

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu.Enabled_btnGuardar = true;
                        ucGe_Menu.Enabled_bntLimpiar = false;


                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu.Enabled_btnGuardar = true;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Inhabilita_Controles();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Inhabilita_Controles();
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        Set();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridViewConsulta_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           
        }

        private void gridViewConsulta_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info row = new Info.Inventario.in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info();
                row = (in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info)gridViewConsulta.GetFocusedRow();


                if (e.Column.Name == "colcheck")
                {
                    if (row.check == true)
                    {
                        gridViewConsulta.SetFocusedRowCellValue(Colcantidad_enviar, row.dt_cantidad);
                        gridViewConsulta.SetFocusedRowCellValue(Col_Diferencia, 0);
                        gridViewConsulta.SetFocusedRowCellValue(Col_Diferencia, 0);
                    }
                    else
                    {
                        gridViewConsulta.SetFocusedRowCellValue(Colcantidad_enviar, 0);

                    }


                  
                    //diferencia
                }


                if (e.Column.Name == "Colcantidad_enviar")
                {
                    decimal dife = 0;

                    dife = Convert.ToDecimal(Convert.ToDecimal(row.dt_cantidad) - Convert.ToDecimal(gridViewConsulta.GetFocusedRowCellValue(Colcantidad_enviar)));
                    gridViewConsulta.SetFocusedRowCellValue(Col_Diferencia, dife);
                }


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Get_detalle()
        {
            try
            {
                Info_GuiaBodega.Lista_Detalle_Transferencia = new List<Info.Inventario.in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info>();
                foreach (var item in Lista_Detalle_transferencia)
                {
                    if (item.check == true)
                    {
                        in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info info_ = new Info.Inventario.in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info();
                        info_.IdEmpresa = param.IdEmpresa;
                        info_.IdEmpresa_tras = item.IdEmpresa;
                        info_.IdSucursalOrigen = item.IdSucursalOrigen;
                        info_.IdBodegaOrigen = item.IdBodegaOrigen;
                        info_.IdTransferencia = item.IdTransferencia;
                        info_.cantidad = item.cantidad;
                        info_.dt_secuencia = item.dt_secuencia;
                        info_.observacion = cmbPuntoLlega.Text + " " + cmbPuntoPartida.Text;
                        info_.IdGuia = item.IdGuia;
                        Info_GuiaBodega.Lista_Detalle_Transferencia.Add(info_);
                    }
                }

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private Boolean Anular()
        {
            try
            {
                Boolean Respuesta = false;

                Get();

                   

                    if (MessageBox.Show("¿Está seguro que desea anular el registro", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                        oFrm.ShowDialog();
                        Info_GuiaBodega.MotiAnula = oFrm.motivoAnulacion;






                        Respuesta = ValidarDatos();
                        if (Respuesta)
                        {

                            Info_GuiaBodega.IdUsuarioUltAnu = param.IdUsuario;
                            Info_GuiaBodega.Fecha_UltAnu = param.Fecha_Transac;
                            if (Respuesta = bus_GuixTrasBod.AnularDB(Info_GuiaBodega, ref mensaje))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Guía de Traspaso a Bodega ", Info_GuiaBodega.IdGuia.ToString());
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ucGe_Menu.Enabled_bntAnular = false;
                                lblAnulado.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Error al Anular la Guía de Traspaso a Bodega, " + mensaje, param.Nombre_sistema);
                            }
                        }
                    }
                return Respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XCXP_FJ_Rpt001_Rpt rpt = new XCXP_FJ_Rpt001_Rpt();
                Get();
                rpt.Parameters["idGuia"].Value = Convert.ToDecimal(txtIdGuia.Text);
                rpt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
 }
}
