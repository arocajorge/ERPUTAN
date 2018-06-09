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

using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

using Core.Erp.Winform.Compras;

using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Cus.Erp.Reports.Naturisa.Inventario;

using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;


namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Genera_Guia_x_Traspaso_Mant : Form
    {

        string mensaje = "";
        decimal idGuia = 0;

        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus buSucursal = new tb_Sucursal_Bus();
        in_Guia_x_traspaso_bodega_Bus bus_GuixTrasBod = new in_Guia_x_traspaso_bodega_Bus();
        com_ordencompra_local_Bus BusOC = new com_ordencompra_local_Bus();
        in_producto_Bus bus_Producto = new in_producto_Bus();
        cp_proveedor_Bus BusProv = new cp_proveedor_Bus();
        in_producto_Bus busProducto = new in_producto_Bus();
        in_Guia_x_traspaso_bodega_det_Bus busGuiaconOC = new in_Guia_x_traspaso_bodega_det_Bus();
        in_Guia_x_traspaso_bodega_det_sin_oc_Bus busGuiasinOC = new in_Guia_x_traspaso_bodega_det_sin_oc_Bus();
        tb_transportista_Bus busTraspor = new tb_transportista_Bus();
        vwIn_Motivo_traslado_bodega_Bus bus_MotiTrasBod = new vwIn_Motivo_traslado_bodega_Bus();

        //Listas
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        List<in_Guia_x_traspaso_bodega_det_Info> listDet_OC;
        List<in_Guia_x_traspaso_bodega_det_sin_oc_Info> listDetSin_OC;
        List<com_ordencompra_local_Info> LstOCSinGuia = new List<com_ordencompra_local_Info>();
        List<com_ordencompra_local_Info> LstOCSinGuiaxTrasBod = new List<com_ordencompra_local_Info>();
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
        List<cp_proveedor_Info> LstInfoProv = new List<cp_proveedor_Info>();
        List<in_Guia_x_traspaso_bodega_det_Info> listGuiaDetconOC = new List<in_Guia_x_traspaso_bodega_det_Info>();
        List<in_Guia_x_traspaso_bodega_det_sin_oc_Info> listGuiaDetsinOC = new List<in_Guia_x_traspaso_bodega_det_sin_oc_Info>();

        BindingList<in_Guia_x_traspaso_bodega_det_Info> ListBindDet_OC = new BindingList<in_Guia_x_traspaso_bodega_det_Info>();
        BindingList<in_Guia_x_traspaso_bodega_det_sin_oc_Info> ListBindDetSin_OC;

        //Infos
        in_Guia_x_traspaso_bodega_Info Info_GuiaBodega = new in_Guia_x_traspaso_bodega_Info();
        

        //Varibales
        Cl_Enumeradores.eTipo_action Accion;

        public delegate void delegate_frmGuia_Traspaso_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmGuia_Traspaso_FormClosing event_frmGuia_Traspaso_FormClosing;

        public FrmIn_Genera_Guia_x_Traspaso_Mant()
        {
            InitializeComponent();

            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            event_frmGuia_Traspaso_FormClosing += FrmIn_Genera_Guia_x_Traspaso_Mant_event_frmGuia_Traspaso_FormClosing;

        }

        void FrmIn_Genera_Guia_x_Traspaso_Mant_event_frmGuia_Traspaso_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (AnularDB())
                    Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (idGuia == 0)
                    idGuia = Info_GuiaBodega.IdGuia;

                XINV_NAT_Rpt001_Rpt Reporte = new XINV_NAT_Rpt001_Rpt();
                Reporte.PIdEmpresa.Value = param.IdEmpresa;
                Reporte.PIdGuia.Value = idGuia;

                Reporte.RequestParameters = false;
                DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.ShowPreviewDialog();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
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

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Accion_Grabar())
                {
                    LimpiarDatos();
                    Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                    Set_Accion_controls();
                }
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

                txtNumOC_Quitar.Enabled = false;
                txtNumOC_Quitar.BackColor = Color.White;
                txtNumOC_Quitar.ForeColor = Color.Black;

                cmbMotivoTras.Enabled = false;
                cmbMotivoTras.BackColor = System.Drawing.Color.White;
                cmbMotivoTras.ForeColor = System.Drawing.Color.Black;

                btnAgregar_OC.Enabled = false;
                btnQuitarOC.Enabled = false;
                dtpFecha.Enabled = false;
                dtpFechaTras.Enabled = false;
                dtpFechaLlega.Enabled = false;

                gridViewConOrdComp.OptionsBehavior.Editable = false;
                gridViewSinOrdComp.OptionsBehavior.Editable = false;
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
                Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
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

                ListBindDet_OC = new BindingList<in_Guia_x_traspaso_bodega_det_Info>();
                gridControlConOrdComp.DataSource = ListBindDet_OC;

                ListBindDetSin_OC = new BindingList<in_Guia_x_traspaso_bodega_det_sin_oc_Info>();
                gridControlSinOrdComp.DataSource = ListBindDetSin_OC;

                Info_GuiaBodega = new in_Guia_x_traspaso_bodega_Info();
                Info_GuiaBodega.list_detalle_Guia = new List<in_Guia_x_traspaso_bodega_det_Info>();
                Info_GuiaBodega.list_detalle_Guia_Sin_OC = new List<in_Guia_x_traspaso_bodega_det_sin_oc_Info>();

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
                cmbProveedor_grid.DataSource = LstInfoProv;

                listProducto = busProducto.Get_list_Producto(param.IdEmpresa);
                cmbProducto_grid.DataSource = listProducto;

                cmbMotivoTras.cargar_Catalogos(3);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get_Info()
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

                GetDetalle_OC();
                GetDetalle_Sin_OC();

                Info_GuiaBodega.list_detalle_Guia = listDet_OC;
                Info_GuiaBodega.list_detalle_Guia_Sin_OC = listDetSin_OC;


                Info_GuiaBodega.CodDocumentoTipo = ucGe_Doc_talo_x_Guia.Get_Info_Talonario().CodDocumentoTipo;
                Info_GuiaBodega.IdEstablecimiento = ucGe_Doc_talo_x_Guia.Get_Info_Talonario().Establecimiento;
                Info_GuiaBodega.IdPuntoEmision =  ucGe_Doc_talo_x_Guia.Get_Info_Talonario().PuntoEmision;
                Info_GuiaBodega.NumDocumento_Guia = ucGe_Doc_talo_x_Guia.Get_Info_Talonario().NumDocumento;
                Info_GuiaBodega.Es_electronica = (ucGe_Doc_talo_x_Guia.Get_Info_Talonario().es_Documento_electronico == null) ? false : Convert.ToBoolean(ucGe_Doc_talo_x_Guia.Get_Info_Talonario().es_Documento_electronico);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetDetalle_OC()
        {
            try
            {
                listDet_OC = new List<in_Guia_x_traspaso_bodega_det_Info>();

                int focus = this.gridViewConOrdComp.FocusedRowHandle;
                gridViewConOrdComp.FocusedRowHandle = focus + 1;

                foreach (var item in ListBindDet_OC)
                {
                    if (item.Check_OG == true)
                    {
                        in_Guia_x_traspaso_bodega_det_Info info = new in_Guia_x_traspaso_bodega_det_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpresa_OC = item.IdEmpresa_OC;
                        info.IdSucursal_OC = item.IdSucursal_OC;
                        info.IdOrdenCompra_OC = item.IdOrdenCompra_OC;
                        info.Secuencia_OC = item.Secuencia_OC;
                        info.observacion = item.observacion;
                        info.Cantidad_enviar = item.Cantidad_enviar;
                        info.Referencia = item.Referencia;
                        info.pr_descripcion = item.pr_descripcion;

                        listDet_OC.Add(info);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetDetalle_Sin_OC()
        {
            try
            {
                listDetSin_OC = new List<in_Guia_x_traspaso_bodega_det_sin_oc_Info>();

                int focus = this.gridViewSinOrdComp.FocusedRowHandle;
                gridViewSinOrdComp.FocusedRowHandle = focus + 1;

                foreach (var item in ListBindDetSin_OC)
                {
                    in_Guia_x_traspaso_bodega_det_sin_oc_Info info = new in_Guia_x_traspaso_bodega_det_sin_oc_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.Num_Fact = item.Num_Fact;
                    info.IdProveedor = item.IdProveedor;
                    info.nom_proveedor = item.nom_proveedor;
                    info.IdProducto = item.IdProducto;
                    info.nom_producto = item.nom_producto;
                    info.Cantidad_enviar = item.Cantidad_enviar;
                    info.observacion = item.observacion;
                    
                    info.nom_producto = item.nom_producto;

                    listDetSin_OC.Add(info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean AnularDB()
        {
            try
            {
                Boolean Respuesta = false;

                Get_Info();

                Respuesta = ValidarDatos();
                if (Respuesta)
                {

                    Info_GuiaBodega.IdUsuarioUltAnu = param.IdUsuario;
                    Info_GuiaBodega.Fecha_UltAnu = param.Fecha_Transac;

                    Respuesta = bus_GuixTrasBod.AnularDB(Info_GuiaBodega, ref mensaje);

                    if (Respuesta)
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Guía de Traspaso a Bodega ", Info_GuiaBodega.IdGuia.ToString());
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        lblAnulado.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al Anular la Guía de Traspaso a Bodega, " + mensaje, param.Nombre_sistema);
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



                foreach (var item in ListBindDetSin_OC)
                {
                    /*if (item.IdProducto == 0)
                    {
                        MessageBox.Show("En la lista de productos sin OC hay un registro q no se asigno a un producto verfique antes de grabar", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }*/

                    //if (item.IdProveedor == 0)
                    //{
                    //    MessageBox.Show("En la lista de productos sin OC hay un registro q no se asigno el proveedor verfique antes de grabar", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    return false;
                    //}

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

        private Boolean Accion_Grabar()
        {
            try
            {
                    Boolean boolResult = false;
                    Get_Info();
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            boolResult = GrabarDB();
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            boolResult = ModificarDB();
                            break;
                        default:
                            break;
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

        private Boolean GrabarDB()
        {
            try
            {
                Boolean boolResult = false;
                boolResult = ValidarDatos();

                if (boolResult)
                {
                            Get_Info();
                    
                            this.txtIdGuia.Focus();
                            boolResult = bus_GuixTrasBod.GuardarDB(Info_GuiaBodega, ref idGuia, ref mensaje);

                            if (boolResult)
                            {
                                txtIdGuia.Text = Convert.ToString(idGuia);
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Guía de Traspaso a Bodega ", idGuia.ToString());
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (MessageBox.Show("Desea Imprimir el Ingreso", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {

                                    ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(null, null);
                                }
                                LimpiarDatos();
                            }
                            else
                            {
                                MessageBox.Show("Error al grabar la Guía de Traspaso a Bodega, " + mensaje, param.Nombre_sistema);
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

        private Boolean ModificarDB()
        {
            try
            {
                Boolean boolResult = false;
                boolResult = ValidarDatos();

                if (boolResult)
                {
                    Get_Info();

                            Info_GuiaBodega.IdUsuarioUltMod = param.IdUsuario;
                            Info_GuiaBodega.Fecha_UltMod = param.Fecha_Transac;

                            boolResult = bus_GuixTrasBod.ModificarDB(Info_GuiaBodega, ref mensaje);

                            if (boolResult)
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Guía de Traspaso a Bodega ", Info_GuiaBodega.IdGuia.ToString());
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                boolResult = true;
                            }
                            else
                            {
                                MessageBox.Show("Error al Actualizar la Guía de Traspaso a Bodega, " + mensaje, param.Nombre_sistema);
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

        public void Set_Accion(Cl_Enumeradores.eTipo_action iAccion)
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
        
        private void Set_Accion_controls()
        {
            try
            {

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        cargarNumDoc();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
                        Set_Info_in_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Inhabilita_Controles();
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
                        Set_Info_in_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Inhabilita_Controles();
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
                        Set_Info_in_Controls();
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

        private void Set_Info_in_Controls()
        {
            try
            {
                txtIdGuia.Text = Info_GuiaBodega.IdGuia.ToString();
                txtNumGuia.Text = Info_GuiaBodega.NumGuia;
                cmbPuntoPartida.EditValue = Info_GuiaBodega.IdSucursal_Partida;
                cmbPuntoLlega.EditValue = Info_GuiaBodega.IdSucursal_Llegada;
                txtDirPuntoPart.Text = Info_GuiaBodega.Direc_sucu_Partida;
                txtDirPuntoLlega.Text = Info_GuiaBodega.Direc_sucu_Llegada;
                cmbTrasnportador.set_TransportistaInfo(Convert.ToDecimal(Info_GuiaBodega.IdTransportista));
                dtpFecha.Value = Info_GuiaBodega.Fecha;
                dtpFechaTras.Value = Info_GuiaBodega.Fecha_Traslado;
                dtpFechaLlega.Value = Info_GuiaBodega.Fecha_llegada;
                cmbMotivoTras.set_CatalogosInfo(Info_GuiaBodega.IdMotivo_Traslado);


                DateTime FH_lle = new DateTime(Info_GuiaBodega.Fecha_Traslado.Year, Info_GuiaBodega.Fecha_Traslado.Month, Info_GuiaBodega.Fecha_Traslado.Day, 0, 0, 0);
                DateTime FH_Tras = new DateTime(Info_GuiaBodega.Fecha_Traslado.Year, Info_GuiaBodega.Fecha_Traslado.Month, Info_GuiaBodega.Fecha_Traslado.Day, 0, 0, 0);

                if (Info_GuiaBodega.Hora_Llegada == null)
                {
                    timeHoraLlegada.EditValue = FH_lle;
                }
                else
                {
                    timeHoraLlegada.EditValue = new DateTime(Info_GuiaBodega.Fecha_Traslado.Year, Info_GuiaBodega.Fecha_Traslado.Month, Info_GuiaBodega.Fecha_Traslado.Day, Info_GuiaBodega.Hora_Llegada.Value.Hours, Info_GuiaBodega.Hora_Llegada.Value.Minutes, Info_GuiaBodega.Hora_Llegada.Value.Seconds);
                }

                if (Info_GuiaBodega.Hora_Traslado == null)
                {
                    timeHoraTraslado.EditValue = FH_Tras;
                }
                else
                {
                    timeHoraTraslado.EditValue = new DateTime(Info_GuiaBodega.Fecha_Traslado.Year, Info_GuiaBodega.Fecha_Traslado.Month, Info_GuiaBodega.Fecha_Traslado.Day, Info_GuiaBodega.Hora_Traslado.Value.Hours, Info_GuiaBodega.Hora_Traslado.Value.Minutes, Info_GuiaBodega.Hora_Traslado.Value.Seconds);
                }


                if (Info_GuiaBodega.Estado.TrimEnd() == "I")
                {
                    lblAnulado.Visible = true;
                }
                else
                {
                    lblAnulado.Visible = false;
                }



                tb_sis_Documento_Tipo_Talonario_Bus BusTalonario = new tb_sis_Documento_Tipo_Talonario_Bus();
                tb_sis_Documento_Tipo_Talonario_Info InfoTalonario_Grabado = new tb_sis_Documento_Tipo_Talonario_Info();
                InfoTalonario_Grabado = BusTalonario.Get_Info_Documento_Tipo_Talonario(Info_GuiaBodega.IdEmpresa, Info_GuiaBodega.CodDocumentoTipo, Info_GuiaBodega.IdEstablecimiento, Info_GuiaBodega.IdPuntoEmision, Info_GuiaBodega.NumDocumento_Guia);

                if (Convert.ToBoolean(InfoTalonario_Grabado.es_Documento_electronico) == true)
                {
                    ucGe_Doc_talo_x_Guia.rbt_doc_Electronico.Checked = true;
                }
                else
                { ucGe_Doc_talo_x_Guia.rbt_pre_impresa.Checked = true; }

                ucGe_Doc_talo_x_Guia.txe_Serie.EditValue = Info_GuiaBodega.IdEstablecimiento + "-" + Info_GuiaBodega.IdPuntoEmision;
                ucGe_Doc_talo_x_Guia.txtNumDoc.EditValue = Info_GuiaBodega.NumDocumento_Guia;
                ucGe_Doc_talo_x_Guia.btnBuscar.Enabled = false;
                ucGe_Doc_talo_x_Guia.Set_Serie_Num_Documento(Info_GuiaBodega.IdEstablecimiento, Info_GuiaBodega.IdPuntoEmision, Info_GuiaBodega.NumDocumento_Guia);


                
                //consulta detalles          

                LstOCSinGuiaxTrasBod = BusOC.Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega(Info_GuiaBodega.IdEmpresa, Info_GuiaBodega.IdGuia);
                convertir_infotabla(LstOCSinGuiaxTrasBod, "xConsulta");

                gridControlConOrdComp.DataSource = ListBindDet_OC;

                listGuiaDetsinOC = busGuiasinOC.Get_List_Guia_x_traspaso_bodega_det_sin_oc(param.IdEmpresa, Info_GuiaBodega.IdGuia);
                ListBindDetSin_OC = new BindingList<in_Guia_x_traspaso_bodega_det_sin_oc_Info>(listGuiaDetsinOC);

                gridControlSinOrdComp.DataSource = ListBindDetSin_OC;

                txt_num_registros_con_OC.EditValue = ListBindDet_OC.Where(q => q.Check_OG == true).Count();
                txt_num_registros_sin_OC.EditValue = ListBindDetSin_OC.Count;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Info(in_Guia_x_traspaso_bodega_Info _Info_GuiaBodega)
        {
            Info_GuiaBodega = _Info_GuiaBodega;
        }

        private void FrmIn_Genera_Guia_x_Traspaso_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                ListBindDetSin_OC = new BindingList<in_Guia_x_traspaso_bodega_det_sin_oc_Info>();
                gridControlSinOrdComp.DataSource = ListBindDetSin_OC;
                txt_num_registros_con_OC.EditValue = 0;
                carga_combos();
                Set_Accion_controls();

                ucGe_Doc_talo_x_Guia.IdEstablecimiento = "001";
                ucGe_Doc_talo_x_Guia.IdPuntoEmision = "001";



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPuntoPartida_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPuntoPartida.EditValue != null)
                {
                    var itemPartida = listSucursal.FirstOrDefault(q => q.IdSucursal == Convert.ToInt32(cmbPuntoPartida.EditValue));
                    txtDirPuntoPart.Text = itemPartida.Su_Direccion;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPuntoLlega_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPuntoLlega.EditValue != null)
                {
                    var itemLlegada = listSucursal.FirstOrDefault(q => q.IdSucursal == Convert.ToInt32(cmbPuntoLlega.EditValue));
                    txtDirPuntoLlega.Text = itemLlegada.Su_Direccion;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_OC_Click(object sender, EventArgs e)
        {
            try
            {                
                FrmCom_OrdenCompra_Sin_Guia_Cons frm = new FrmCom_OrdenCompra_Sin_Guia_Cons();
                frm.ShowDialog();

                LstOCSinGuia = BusOC.Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega_det(frm.idempresa, frm.idsucursal, frm.idOrdenCompra);
                
                  convertir_infotabla(LstOCSinGuia, "xOC");
                              
                    
                gridControlConOrdComp.DataSource = ListBindDet_OC;     

                

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
                    if (ListBindDet_OC.Where(q => q.IdEmpresa_OC == item.IdEmpresa && q.IdSucursal_OC == item.IdSucursal && q.IdOrdenCompra_OC == item.IdOrdenCompra && q.Secuencia_OC == item.Secuencia).Count() == 0)
                    {
                        in_Guia_x_traspaso_bodega_det_Info info = new in_Guia_x_traspaso_bodega_det_Info();

                        if (item.do_Cantidad != 0)
                        {
                            info.IdEmpresa_OC = item.IdEmpresa;
                            info.IdSucursal_OC = item.IdSucursal;
                            info.IdOrdenCompra_OC = item.IdOrdenCompra;

                            info.oc_NumDocumento = item.oc_NumDocumento;
                            info.pr_nombre = item.nom_proveedor;
                            if (item.IdProducto != 0) info.IdProducto = item.IdProducto;
                            info.pr_descripcion = item.nom_producto;
                            info.Secuencia_OC = item.Secuencia;
                            
                            if (STipoConsulta == "xOC")
                            {
                                info.Cantidad_enviar = item.do_Cantidad;
                                info.observacion = item.oc_observacion;
                                info.Referencia = item.oc_NumDocumento;
                            }
                            else
                            {
                                info.Cantidad_enviar = item.Cantidad_enviar;
                                info.observacion = item.observacion_det_gui;
                                info.Referencia = item.Referencia_guia;
                            }

                            info.Cantidad_Saldo = item.do_Cantidad - item.Cantidad_enviar;
                            info.Cantidad_Saldo_Auxi = info.Cantidad_Saldo;
                            info.Cantidad_OC = item.do_Cantidad;

                            
                            info.Check_OG = true;

                            ListBindDet_OC.Add(info);
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

        private void gridViewSinOrdComp_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colIdProveedor_sin_oc")
                {
                    foreach (var item in ListBindDetSin_OC)
                    {
                        var itemProveedor = LstInfoProv.FirstOrDefault(p => p.IdProveedor == item.IdProveedor);
                        if (itemProveedor != null) item.nom_proveedor = itemProveedor.pr_nombre;
                    }
                }

                if (e.Column.Name == "colIdProducto_sin_oc")
                {
                    foreach (var item in ListBindDetSin_OC)
                    {
                        var itemProducto = listProducto.FirstOrDefault(p => p.IdProducto == item.IdProducto);
                        if (itemProducto != null) item.nom_producto = itemProducto.pr_descripcion;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Genera_Guia_x_Traspaso_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmGuia_Traspaso_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                List<in_Guia_x_traspaso_bodega_det_Info> lstDetOC_ = new List<in_Guia_x_traspaso_bodega_det_Info>();
                lstDetOC_ = ListBindDet_OC.ToList();

                if (txtNumOC_Quitar.EditValue != null)
                {
                    foreach (var item in lstDetOC_)
                    {
                        if (item.IdOrdenCompra_OC == Convert.ToDecimal(txtNumOC_Quitar.EditValue))
                            ListBindDet_OC.Remove(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConOrdComp_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double Saldo_Aux = 0;
                double Saldo = 0;
                double CantOC = 0;
                double Cant_a_Enviar = 0;





                if (e.Column.Name == colCantidad_enviar.Name)
                {

                    Saldo_Aux = Convert.ToDouble(gridViewConOrdComp.GetFocusedRowCellValue(colSaldo_Aux));
                    //Saldo = Convert.ToDouble(gridViewConOrdComp.GetFocusedRowCellValue(colSaldo));
                    CantOC = Convert.ToDouble(gridViewConOrdComp.GetFocusedRowCellValue(colCant_Pedida));
                    Cant_a_Enviar = Convert.ToDouble(gridViewConOrdComp.GetFocusedRowCellValue(colCantidad_enviar));

                    Saldo = CantOC - Cant_a_Enviar;

                    if (Saldo < 0)
                    {
                        MessageBox.Show("La cantidad a Enviar no puede ser mayor al saldo disponible", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gridViewConOrdComp.SetFocusedRowCellValue(colCantidad_enviar, CantOC);
                        gridViewConOrdComp.SetFocusedRowCellValue(colSaldo, Saldo_Aux);
                        return;
                    }


                    gridViewConOrdComp.SetFocusedRowCellValue(colSaldo, Saldo);                  
                }
                if (e.Column == colCheck)
                {
                    txt_num_registros_con_OC.EditValue = ListBindDet_OC.Where(q => q.Check_OG == true).Count();
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void gridViewSinOrdComp_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewSinOrdComp.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewConOrdComp_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewConOrdComp.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public void cargarNumDoc()
        {
            try
            {
                if (Accion==Cl_Enumeradores.eTipo_action.grabar)
                {
                        ucGe_Doc_talo_x_Guia.IdTipoDocumento = Cl_Enumeradores.eTipoDocumento_Talonario.GUIA;
                        ucGe_Doc_talo_x_Guia.IdEstablecimiento = "001";
                        ucGe_Doc_talo_x_Guia.IdPuntoEmision = "001";
                        ucGe_Doc_talo_x_Guia.Get_Primer_Documento_no_usado();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btn_Generar_XML_Click(object sender, EventArgs e)
        {
            try
            {

                Generar_Xml();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());


            }
        }


        public void Generar_Xml()
        {
            try
            {
                string mensaje = "";

                if (bus_GuixTrasBod.Generar_Guardar_Xml_Guia_x_Traspaso(param.IdEmpresa, Info_GuiaBodega.IdGuia, ref mensaje))
                {
                    MessageBox.Show("Generacion de Xml por Guia ok...",param.Nombre_sistema,MessageBoxButtons.OK);
                }
                else
                { MessageBox.Show(mensaje,param.NombreEmpresa,MessageBoxButtons.OK,MessageBoxIcon.Error); }


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewConOrdComp_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == colCheck)
                {
                    gridViewConOrdComp.SetRowCellValue(e.RowHandle, colCheck, e.Value);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewConOrdComp_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                txt_num_registros_con_OC.EditValue = ListBindDet_OC.Where(q => q.Check_OG == true).Count();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewSinOrdComp_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                txt_num_registros_sin_OC.EditValue = ListBindDetSin_OC.Count;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

    }
}
