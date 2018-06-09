using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Business.Compras;
using Core.Erp.Business.Roles;
using Core.Erp.Business.Inventario;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Inventario;

using Cus.Erp.Reports.Naturisa.Compras;


using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;

using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Contabilidad;

using Core.Erp.Info.Facturacion;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_SolicitudCompra_Mant : Form
    {
        #region Declaracion de Variables

        int RowHandle = 0;
        string MensajeError = "";
        // Bus
        cp_proveedor_Bus Bus_Prove = new cp_proveedor_Bus();
        tb_persona_bus Bus_Perso = new tb_persona_bus();
        com_comprador_Bus Bus_Comprador = new com_comprador_Bus();
        
        tb_Sucursal_Bus Bus_Sucursal = new tb_Sucursal_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus Bus_Prod = new in_producto_Bus();
        com_solicitud_compra_det_Bus Bus_DetSolCom = new com_solicitud_compra_det_Bus();
        com_solicitud_compra_Bus Bus_SolicitudCompra = new com_solicitud_compra_Bus();
        com_parametro_Bus bus_parametro = new com_parametro_Bus();
        ct_punto_cargo_Bus bus_puntoCargo = new ct_punto_cargo_Bus();
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_Solicitud = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
        in_UnidadMedida_Bus bus_UniMedida = new in_UnidadMedida_Bus();
        com_comprador_Bus busCom = new com_comprador_Bus();
        List<com_comprador_Info> listComprador = new List<com_comprador_Info>();
        List<com_comprador_Info> listCompradorActivos = new List<com_comprador_Info>();
        // Listas
        List<ct_Centro_costo_Info> listCentroCosto;
        

        List<tb_persona_Info> ListPersona;
        List<tb_persona_Info> ListPersonaActivo = new List<tb_persona_Info>();
        
   
        List<com_departamento_Info> ListDepartamento = new List<com_departamento_Info>();
        
        List<tb_Sucursal_Info> ListSucursalActivos = new List<tb_Sucursal_Info>();
        List<in_Producto_Info> ListProducto;
        List<in_Producto_Info> ListProductoActivo = new List<in_Producto_Info>();
        BindingList<com_solicitud_compra_det_Info> ListDetSolCom;
        
        List<ct_punto_cargo_Info> listPuntoCargo;
        List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listSolicitud = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
        List<in_UnidadMedida_Info> listUniMedidad = new List<in_UnidadMedida_Info>();
        // Info
        com_solicitud_compra_Info Info = new com_solicitud_compra_Info();
        com_parametro_Info info = new com_parametro_Info();
        ct_Centro_costo_Bus BusCentroCosto;
        BindingList<ct_centro_costo_sub_centro_costo_Info> BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();
        ct_punto_cargo_Info Info_punto_cargo = new ct_punto_cargo_Info();
        ct_punto_cargo_grupo_Bus BusPunto_Cargo_grupo = new ct_punto_cargo_grupo_Bus();
        List<ct_punto_cargo_grupo_Info> listaPuntoCargo_grupo = new List<ct_punto_cargo_grupo_Info>();

        // Variables      

        string IdEstAprSolComp = "";
        BindingList<in_Producto_Info> listDetTabla;
        public com_solicitud_compra_Info _SetInfo { get; set; }
        in_Producto_Info Item;
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        public delegate void delegate_FrmCom_SolicitudCompraMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCom_SolicitudCompraMantenimiento_FormClosing event_FrmCom_SolicitudCompraMantenimiento_FormClosing;

        List<com_ordencompra_local_Info> lstOrdenCompra = new List<com_ordencompra_local_Info>();
        com_ordencompra_local_Bus busOrdenCompra = new com_ordencompra_local_Bus();

        #endregion

        public FrmCom_SolicitudCompra_Mant()
        {
            InitializeComponent();

            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;

            event_FrmCom_SolicitudCompraMantenimiento_FormClosing += FrmCom_SolicitudCompraMantenimiento_event_FrmCom_SolicitudCompraMantenimiento_FormClosing;
            if ( enu==0)
            {
                enu = Cl_Enumeradores.eTipo_action.grabar;
            }
        }
       
        void FrmCom_SolicitudCompraMantenimiento_event_FrmCom_SolicitudCompraMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
       
         public FrmCom_SolicitudCompra_Mant(Cl_Enumeradores.eTipo_action Numerador)
             : this()
          {
              try
              {
                   enu = Numerador;
              }
              catch (Exception ex)
              {
                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
              }
          }

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                
                Anular();
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();

                ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void limpiar()
        {
            try
            {
                txtIdSolicitud.EditValue = "";
                txtNumDocumento.EditValue = "";                          
                txtObservacion.Text = "";
                ucGe_Sucursal_combo1.set_SucursalInfo(0);
                cmbDepartamento.set_DepartamentoInfo(0);
                ucCom_Comprador1.set_CompradorInfo(0);
                cmbSolicitante.set_SolicitanteInfo(0);
                dtpFecha.Value = DateTime.Now;

                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                     
                ListDetSolCom = new BindingList<com_solicitud_compra_det_Info>();
                gridControlSolicitudCompra.DataSource = ListDetSolCom;

                lstOrdenCompra = new List<com_ordencompra_local_Info>();
                gridControlOrdenCompra.DataSource = lstOrdenCompra;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void Imprimir()
        {
            try
            {
               
                tb_Sucursal_Info InfoSucu=ucGe_Sucursal_combo1.get_SucursalInfo();
                if (InfoSucu != null)
                {
                    if (InfoSucu.IdSucursal != 0)
                    {
                        XCOMP_Rpt002_Rpt reporte = new XCOMP_Rpt002_Rpt();

                        int IdEmpresa = 0;
                        int IdSucursal = 0;
                        decimal IdSolicitudCompra = 0;
                        IdEmpresa = param.IdEmpresa;
                        IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;//Convert.ToInt32(cmbSucursal.EditValue);
                        IdSolicitudCompra = Convert.ToDecimal(txtIdSolicitud.EditValue);

                        reporte.set_parametros(IdEmpresa, IdSucursal, IdSolicitudCompra);
                        reporte.RequestParameters = true;

                        reporte.ShowPreviewDialog();
                    }
                }
                else
                    MessageBox.Show("No puede imprimir un registro en blanco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {               
             Log_Error_bus.Log_Error(ex.ToString());
             MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (grabar())
                    {
                        this.Close();
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    grabar();
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        
        void Carga_Combos()
        {
            try
            {           
                ListProducto = new List<in_Producto_Info>();
                ListProducto = Bus_Prod.Get_list_Producto(param.IdEmpresa);
                          
                cmbProducto.DataSource = ListProducto;
                cmbProducto.DisplayMember = "pr_codigo";
                cmbProducto.ValueMember = "IdProducto";

                listaPuntoCargo_grupo = BusPunto_Cargo_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_grupo_punto_cargo.DataSource = listaPuntoCargo_grupo;
                      
                listPuntoCargo = new List<ct_punto_cargo_Info>();
                listPuntoCargo= bus_puntoCargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmbPuntoCargo.DataSource = listPuntoCargo;

                cmb_punto_cargo_fj.DataSource = listPuntoCargo;

                //carga combo unidad medida en detalle solicitud              
                listUniMedidad = new List<in_UnidadMedida_Info>();
                listUniMedidad = bus_UniMedida.Get_list_UnidadMedida();
                //listUniMedidad.Add(

                cmbUniMedida_grid.DataSource = listUniMedidad;
                cmbUniMedida_grid.DisplayMember ="Descripcion";
                cmbUniMedida_grid.ValueMember ="IdUnidadMedida";

                BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();

                BusCentroCosto = new ct_Centro_costo_Bus();
                listCentroCosto = new List<ct_Centro_costo_Info>();
                listCentroCosto = BusCentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                listCentroCosto.Add(new ct_Centro_costo_Info(param.IdEmpresa, "-999", "***NUEVO REGISTRO**"));
                cmb_centro_costo.DataSource = listCentroCosto;


                cmbDepartamento.Cargar_Departamento = true;
                
                                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public Boolean Validar() 
        {
            try
            {
                ucGe_Sucursal_combo1.Focus();

                if (String.IsNullOrEmpty(IdEstAprSolComp))
                {
                    MessageBox.Show("No Existe Estado Aprobación de Solicitud de Compras en Parámetros de Compras. Por favor verifique dicho Estado en Parámetros de Compras", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucGe_Sucursal_combo1.get_SucursalInfo() == null) 
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_sucursal), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucGe_Sucursal_combo1.Focus();
                    return false;
                }
                if (cmbDepartamento.Get_Info_Departamento() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Departamento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbDepartamento.Focus();
                    return false;
                }
                if (cmbSolicitante.get_SolicitanteInfo() == null )
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Solicitante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbSolicitante.Focus();
                    return false;
                }
                if (ucCom_Comprador1.get_CompradorInfo() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Comprador", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucCom_Comprador1.Focus();
                    return false;
                }

                if (ListDetSolCom.Count == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Detalle de la Solicitud", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ListDetSolCom.Count != 0)
                {
                                  
                    if(ListDetSolCom.Where(v=>v.do_Cantidad ==0).Count()>0)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " cantidad del producto: " + ListDetSolCom.First(c => c.do_Cantidad == 0).NomProducto, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                         return false; 
                    }

                    if (ListDetSolCom.Where(v => v.IdUnidadMedida == null).Count() > 0)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " unidad de medida del producto: " + ListDetSolCom.First(c => c.IdUnidadMedida == null).NomProducto, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (ListDetSolCom.Where(v => v.do_Cantidad != 0 && v.NomProducto == null).Count() > 0)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " producto para la cantidad " + ListDetSolCom.FirstOrDefault(c => c.do_Cantidad != 0).do_Cantidad, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    
                                                      
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }        
        }
        
        Boolean grabar()
        {
            try
            {
                Boolean res = true;

                txtIdSolicitud.Focus();
                Get();
    
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       res= Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (lblAnulado.Visible == true)
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado) + ". No se podrá efectuar cambios", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            res = true;
                        }
                        else
                            res= Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                      //  Anular();
                        break;
                    default:
                        break;
                }

                return res;
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }
        }

        void Set()
        {
            try
            {
                txtIdSolicitud.EditValue = _SetInfo.IdSolicitudCompra;
                txtNumDocumento.EditValue = _SetInfo.NumDocumento;
                txtObservacion.Text = _SetInfo.observacion;
                dtpFecha.Value= _SetInfo.fecha;
                ucGe_Sucursal_combo1.set_SucursalInfo(_SetInfo.IdSucursal);
                cmbDepartamento.set_DepartamentoInfo(_SetInfo.IdDepartamento);
                cmbSolicitante.set_SolicitanteInfo(_SetInfo.IdSolicitante);
                ucCom_Comprador1.set_CompradorInfo(_SetInfo.IdComprador);

                ListDetSolCom = new BindingList<com_solicitud_compra_det_Info>(Bus_DetSolCom.Get_list_DetalleLstSolicitudCompra(param.IdEmpresa, _SetInfo.IdSucursal, _SetInfo.IdSolicitudCompra));

                gridControlSolicitudCompra.DataSource = ListDetSolCom;
                             
                if (_SetInfo.Estado.TrimEnd() == "I")
                {
                    lblAnulado.Visible = true;
                }
                else
                {
                    lblAnulado.Visible = false;
                }

                listSolicitud = bus_Solicitud.ConsultaDetalleSolicitud_x_Solicitud(_SetInfo.IdEmpresa, _SetInfo.IdSucursal, _SetInfo.IdSolicitudCompra);

                if (listSolicitud.Count() != 0)
                {                  
                    this.gridViewSolicitudCompra.OptionsBehavior.Editable = false;     
                }

                lstOrdenCompra = new List<com_ordencompra_local_Info>();
                lstOrdenCompra = busOrdenCompra.Get_List_ordencompra_local_x_Solicitud(_SetInfo.IdEmpresa, _SetInfo.IdSucursal, _SetInfo.IdSolicitudCompra);
                gridControlOrdenCompra.DataSource = lstOrdenCompra;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
       
        public void convertir_infotabla(List<com_solicitud_compra_det_Info> ListaDetOC)
        {
            try
            {               
                listDetTabla = new BindingList<in_Producto_Info>();
                foreach (var item in ListaDetOC)
                {
                    in_Producto_Info info = new in_Producto_Info();

                    info.IdProducto = Convert.ToDecimal(item.IdProducto);
                    info.do_Cantidad = item.do_Cantidad;
                    info.pr_descripcion = item.pr_descripcion;                                   

                    if (item.do_Cantidad != 0)
                    {
                        listDetTabla.Add(info);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void Get()
        {
            try
            {
                Info.IdSolicitudCompra = Convert.ToDecimal((this.txtIdSolicitud.EditValue == "") ? "0" : txtIdSolicitud.EditValue);
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                Info.NumDocumento = Convert.ToString(txtNumDocumento.EditValue)==null ? "" : Convert.ToString(txtNumDocumento.EditValue);         
                Info.IdSolicitante = Convert.ToDecimal(cmbSolicitante.get_SolicitanteInfo().IdSolicitante);
                Info.IdComprador = ucCom_Comprador1.get_CompradorInfo().IdComprador;
                Info.IdDepartamento = cmbDepartamento.Get_Info_Departamento().IdDepartamento;
                Info.fecha = dtpFecha.Value;             
                Info.observacion = txtObservacion.Text;
                Info.IdEstadoAprobacion= IdEstAprSolComp;
                Info.Estado = "A";
                int focus = this.gridViewSolicitudCompra.FocusedRowHandle;
                gridViewSolicitudCompra.FocusedRowHandle = focus + 1;

                int fila = 0;
                foreach (var item in ListDetSolCom)
                {
                    item.Secuencia = fila++;
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdSucursal = Info.IdSucursal;
                    item.IdSolicitudCompra = Info.IdSolicitudCompra;
                    
                }
                Info.DetSolicitudCompra = new List<com_solicitud_compra_det_Info>(ListDetSolCom);                                      
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
                           
        Boolean Guardar()
        {
            try
            {
                Boolean res = true;

                Info.Fecha_Transac = param.Fecha_Transac;
                if (Bus_SolicitudCompra.GuardarDB(Info ,ref  MensajeError))
                {
                    res = true;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la Solicitud de Compra " + Info.IdSolicitudCompra, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIdSolicitud.EditValue = Info.IdSolicitudCompra;


                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Desea_Imprimir), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Imprimir();
                    }
                    limpiar();
                }
                else
                {
                    res = false;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos) + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        Boolean Actualizar()
        {
            try
            {
                Boolean res = true;

                Info.Fecha_UltMod = param.Fecha_Transac;
                Info.IdUsuarioUltMod = param.IdUsuario;

                if (Bus_SolicitudCompra.ModificarDB(Info, ref  MensajeError))
                {
                    res = true;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " la Solicitud de Compra " + Info.IdSolicitudCompra, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    limpiar();
                }
                else
                {
                    res = false;
                    MessageBox.Show("Error al modificar " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                }

                return res;
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }
        }

        Boolean Anular()
        {            
                try
                {
                    Boolean res = true;
                    string msg = "";
                    if (Info.IdSolicitudCompra != 0)
                    {
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Está_seguro_que_desea_anular_la) + " Solicitud #: " + Info.IdSolicitudCompra + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                            ofrm.ShowDialog();

                            Info.IdUsuarioUltAnu = param.IdUsuario;
                            Info.FechaHoraAnul = DateTime.Now;
                            Info.MotivoAnulacion = ofrm.motivoAnulacion;

                            if (Info.Estado == "A")
                            {

                                if (Bus_SolicitudCompra.AnularDB(Info, ref msg))
                                {
                                    res = true;
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Anulada_corectamente) + " La Solicitud de Compra " + Info.IdSolicitudCompra, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lblAnulado.Visible = true;
                                }
                                else
                                {
                                    res = false;
                                    MessageBox.Show("Error al Anular" + msg, param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                res = false;
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) + " la solicitud: " + Info.IdSolicitudCompra + param.Get_Mensaje_sys(enum_Mensajes_sys.Debido_q_ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        res = false;
                    }
                    return res;
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            
        }
    
        private void FrmCom_SolicitudCompraMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                Carga_Combos();

                info = bus_parametro.Get_Info_parametro(param.IdEmpresa);
                IdEstAprSolComp = info.IdEstadoAprobacion_SolCompra;

                ListDetSolCom = new BindingList<com_solicitud_compra_det_Info>();
                gridControlSolicitudCompra.DataSource = ListDetSolCom;

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            
                        this.txtIdSolicitud.Enabled = false;
                        this.txtIdSolicitud.BackColor = System.Drawing.Color.White;
                        this.txtIdSolicitud.ForeColor = System.Drawing.Color.Black;
                
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (lblAnulado.Visible == true)
                        {

                            ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                            ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                            ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                            ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                        }
                        else
                        {
                            ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                            ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                            //ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                            this.txtIdSolicitud.Enabled = false;
                            this.txtIdSolicitud.BackColor = System.Drawing.Color.White;
                            this.txtIdSolicitud.ForeColor = System.Drawing.Color.Black;

                            this.ucGe_Sucursal_combo1.Enabled = false;
                            this.ucGe_Sucursal_combo1.BackColor = System.Drawing.Color.White;
                            this.ucGe_Sucursal_combo1.ForeColor = System.Drawing.Color.Black;

                            
                        }

                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                        Inhabilita_Controles();

                        Set();

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;  
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;

                        Inhabilita_Controles();
                    
                        Set();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {               
             Log_Error_bus.Log_Error(ex.ToString());
             MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void Inhabilita_Controles()
        {
            try
            {
                        txtIdSolicitud.Enabled = false;
                        txtIdSolicitud.BackColor = System.Drawing.Color.White;
                        txtIdSolicitud.ForeColor = System.Drawing.Color.Black;

                        txtNumDocumento.Enabled = false;
                        txtNumDocumento.BackColor = System.Drawing.Color.White;
                        txtNumDocumento.ForeColor = System.Drawing.Color.Black;

                        txtObservacion.Enabled = false;
                        txtObservacion.BackColor = System.Drawing.Color.White;
                        txtObservacion.ForeColor = System.Drawing.Color.Black;

                        dtpFecha.Enabled = false;

                        ucGe_Sucursal_combo1.Enabled = false;
                        ucGe_Sucursal_combo1.BackColor = System.Drawing.Color.White;
                        ucGe_Sucursal_combo1.ForeColor = System.Drawing.Color.Black;

                        cmbDepartamento.Enabled = false;
                        cmbDepartamento.BackColor = System.Drawing.Color.White;
                        cmbDepartamento.ForeColor = System.Drawing.Color.Black;

                        cmbSolicitante.Enabled = false;
                        cmbSolicitante.BackColor = System.Drawing.Color.White;
                        cmbSolicitante.ForeColor = System.Drawing.Color.Black;

                        ucCom_Comprador1.Enabled = false;
                        ucCom_Comprador1.BackColor = System.Drawing.Color.White;
                        ucCom_Comprador1.ForeColor = System.Drawing.Color.Black;

                        gridViewSolicitudCompra.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
               
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }               
        }
      
        private void gridViewSolicitudCompra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                com_solicitud_compra_det_Info row = new com_solicitud_compra_det_Info();
                row = (com_solicitud_compra_det_Info)gridViewSolicitudCompra.GetFocusedRow();
                                                                     
                int cont = 0;

                if (row != null)
                {
                    if (!String.IsNullOrEmpty(Convert.ToString(row.IdPunto_cargo)) && !String.IsNullOrEmpty(Convert.ToString(row.IdCentroCosto)))
                    {
                        if (row.IdProducto == null)
                        {                          
                           cont = ListDetSolCom.Where(q => q.NomProducto.Trim() == row.NomProducto.Trim() && q.IdPunto_cargo == row.IdPunto_cargo && q.IdCentroCosto == row.IdCentroCosto).Count();                        
                        }
                        else
                        {
                            cont = ListDetSolCom.Where(q => q.IdProducto == row.IdProducto && q.IdPunto_cargo == row.IdPunto_cargo && q.IdCentroCosto == row.IdCentroCosto).Count();
                        
                        }
                      
                      
                    }
                }
                if (cont > 1)
                {
                    MessageBox.Show("El registro : " + gridViewSolicitudCompra.GetFocusedRowCellValue(colpr_descripcion) + " ya se encuentra en el Detalle. Se procederá a Eliminar", param.Nombre_sistema);
                    gridViewSolicitudCompra.DeleteSelectedRows();
                }

            

                
               

                if (e.Column.Name == "colIdProducto")
                {
                    Item = ListProducto.First(v => v.IdProducto == Convert.ToDecimal(e.Value));
                    gridViewSolicitudCompra.SetFocusedRowCellValue(coldo_Cantidad, 0);
                    gridViewSolicitudCompra.SetFocusedRowCellValue(colpr_descripcion, Item.pr_descripcion);
                    gridViewSolicitudCompra.SetFocusedRowCellValue(colIdUnidadMedida, Item.IdUnidadMedida);
                    gridViewSolicitudCompra.SetFocusedRowCellValue(colStock, Item.pr_stock);                                      
                }
                else
                {
                    if (e.Column.Name == "coldo_Cantidad")
                    {
                        if (Convert.ToDouble(gridViewSolicitudCompra.GetFocusedRowCellValue(coldo_Cantidad)) < 0)
                        {
                            gridViewSolicitudCompra.SetFocusedRowCellValue(coldo_Cantidad, Convert.ToDouble(gridViewSolicitudCompra.GetFocusedRowCellValue(coldo_Cantidad)) * -1);
                        }
                    }
                    else
                    {
                        if (e.Column.Name == "colpr_descripcion")
                        {
                            
                        }
                    }                
                }

                ct_centro_costo_sub_centro_costo_Bus busSubCen = new ct_centro_costo_sub_centro_costo_Bus();

               if (e.Column == colIdCentroCosto)
                    {

                   string IdCentroCosto= Convert.ToString(e.Value);

                        if (IdCentroCosto=="-999") // esta creando un registro nuevo
                        {
                            frmCon_CentroCostos_Man frmCentroCosto = new frmCon_CentroCostos_Man();
                            frmCentroCosto.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                            frmCentroCosto.event_frmCon_CentroCostos_Man_FormClosing += frmCentroCosto_event_frmCon_CentroCostos_Man_FormClosing;
                            frmCentroCosto.ShowDialog();
                            gridViewSolicitudCompra.SetFocusedRowCellValue(colIdCentroCosto , "");                                      
                        }
                    }

               if (e.Column == col_IdPuntoCargo_FJ)
               {
                   switch (param.IdCliente_Ven_x_Default)
                   {
                      case Cl_Enumeradores.eCliente_Vzen.FJ:
                           if (row.IdPunto_cargo != 0 && row.IdPunto_cargo != null)
                           {
                               ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
                               ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
                               info_punto_cargo = bus_punto_cargo.Get_info_punto_Cargo_con_subcentro(param.IdEmpresa, Convert.ToInt32(row.IdPunto_cargo));
                               row.IdPunto_cargo_grupo = info_punto_cargo.IdPunto_cargo_grupo;
                               row.IdCentroCosto = info_punto_cargo.IdCentroCosto_Scc;
                               row.IdCentroCosto_sub_centro_costo = info_punto_cargo.IdCentroCosto_sub_centro_costo_Scc;
                           }
                           else
                           {
                               row.IdPunto_cargo_grupo = null;
                               row.IdCentroCosto = null;
                               row.IdCentroCosto_sub_centro_costo = null;
                           }
                           break;
                      default:
                           break;
                   }
               }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }         
        }

        void frmCentroCosto_event_frmCon_CentroCostos_Man_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                BusCentroCosto = new ct_Centro_costo_Bus();
                listCentroCosto = new List<ct_Centro_costo_Info>();
                listCentroCosto = BusCentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                listCentroCosto.Add(new ct_Centro_costo_Info(param.IdEmpresa, "-999", "***NUEVO REGISTRO**"));
                cmb_centro_costo.DataSource = listCentroCosto;
            }
            catch (Exception ex)
            {
                
            }
            
        }
       
        private void FrmCom_SolicitudCompraMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmCom_SolicitudCompraMantenimiento_FormClosing(sender,e);
            }
            catch (Exception ex)
            {               
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void gridViewSolicitudCompra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (enu == Cl_Enumeradores.eTipo_action.consultar || enu == Cl_Enumeradores.eTipo_action.Anular)
                { return; }

                if (e.KeyValue.ToString() == "46")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) + " registro", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewSolicitudCompra.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {               
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }                    
        }

        private void gridViewSolicitudCompra_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (enu == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (e.HitInfo.Column != null)
                    {
                        e.HitInfo.Column.FieldName = gridViewSolicitudCompra.FocusedColumn.FieldName;
                        if (e.HitInfo.Column.FieldName == "IdProducto" || e.HitInfo.Column.FieldName == "NomProducto" || e.HitInfo.Column.FieldName == "do_Cantidad" || e.HitInfo.Column.FieldName == "IdPunto_cargo")
                        {
                            if (listSolicitud.Count() != 0)
                            {
                                MessageBox.Show("La solicitud #: [" + _SetInfo.IdSolicitudCompra + "], tiene asociada una Orden de Compra. No se puede modificar el Detalle ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                            }
                        }
                    }
                }                           
            }
            catch (Exception ex)
            {               
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void cmbSolicitante_EditValueChanged(object sender, EventArgs e)
        {
            // sss
        }

        private void gridViewSolicitudCompra_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void gridViewSolicitudCompra_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colIdProducto")
                {
                    Item = ListProducto.First(v => v.IdProducto == Convert.ToDecimal(e.Value));
                    gridViewSolicitudCompra.SetFocusedRowCellValue(colpr_descripcion, Item.pr_descripcion);
                    gridViewSolicitudCompra.SetFocusedRowCellValue(coldo_Cantidad, 0);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void cmbPuntoCargo_Click(object sender, EventArgs e)
        {
            try
            {
                int IdPuntoCargoGrupo = 0;
                IdPuntoCargoGrupo = Convert.ToInt32(gridViewSolicitudCompra.GetRowCellValue(RowHandle, colIdPunto_cargo_grupo));
                frmCon_Punto_Cargo_Cons frm_cons = new frmCon_Punto_Cargo_Cons();

                frm_cons.Cargar_grid_x_grupo(IdPuntoCargoGrupo);


                frm_cons.ShowDialog();
                Info_punto_cargo = frm_cons.Get_Info();
                if (Info_punto_cargo != null)
                {
                    gridViewSolicitudCompra.SetFocusedRowCellValue(colIdPunto_Cargo, Info_punto_cargo.IdPunto_cargo);
                }
                else
                    gridViewSolicitudCompra.SetFocusedRowCellValue(colIdPunto_Cargo, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
