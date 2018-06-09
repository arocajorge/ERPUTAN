using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Cus.Erp.Reports.Naturisa.Compras;
using Cus.Erp.Reports.Naturisa.Inventario;
using Core.Erp.Winform.Contabilidad;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Ingreso_x_OrdenCompra_Mant : Form
    {
        #region Declaración de Variables
        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        int RowHandle = 0;
        //cp_proveedor_Bus bus_Proveedor;
        in_Ingreso_x_OrdenCompra_det_Bus bus_IngxCompDet;
        in_Ing_Egr_Inven_det_Bus Bus_IngEgrDet;
        in_Ing_Egr_Inven_Bus Bus_IngEgr;
        ct_Centro_costo_Bus Bus_CentroCosto;
        ct_punto_cargo_Bus bus_puntoCargo;
        in_movi_inve_x_ct_cbteCble_Bus bus_InMovxCble;
        in_UnidadMedida_Bus Bus_Uni_Med;
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        com_parametro_Bus bus_Comparam;
        in_Motivo_Inven_Bus bus_MotivoInv;
        in_movi_inve_Bus bus_MovInv;
        in_Parametro_Bus parametros_B = new in_Parametro_Bus();
        string MensajeError = "";

        //Listas
        //List<cp_proveedor_Info> list_Proveedor;
        List<in_Ingreso_x_OrdenCompra_det_Info> list;
        List<ct_Centro_costo_Info> list_centroCosto;
        List<ct_punto_cargo_Info> listPuntoCargo = new List<ct_punto_cargo_Info>();
        List<in_UnidadMedida_Info> list_UniMe;
        List<in_Motivo_Inven_Info> list_MotivoInv;
        List<in_Ing_Egr_Inven_det_Info> lista_IngEgrInv;
        List<ct_centro_costo_sub_centro_costo_Info> list_subcentro = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Info info_subcentro = new ct_centro_costo_sub_centro_costo_Info();
        BindingList<in_Ing_Egr_Inven_det_Info> ListaBind;
        List<ct_centro_costo_sub_centro_costo_Info> list_subcentro_combo = new List<ct_centro_costo_sub_centro_costo_Info>();
        List<ct_punto_cargo_grupo_Info> list_grupo = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus bus_grupo = new ct_punto_cargo_grupo_Bus();
        //Infos
        in_movi_inve_x_ct_cbteCble_Info info_InMovxCble;
        com_parametro_Info info_Comparam;
        in_movi_inve_Info infoMovInv;
        in_Motivo_Inven_Info info_MotivoInv;
        //Variables
        private Cl_Enumeradores.eTipo_action Accion;
        double cant_aux = 0;
        int i;
        int j;
        int contador;
        in_Ing_Egr_Inven_det_Info Info;
        public in_Ing_Egr_Inven_Info SETINFO_ { get; set; }
        in_Ing_Egr_Inven_Info info_IngComp = new in_Ing_Egr_Inven_Info();
        List<in_Ing_Egr_Inven_det_Info> list_IngxComp;
        public delegate void delegate_FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing event_FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing;
        vwIn_UnidadMedida_Equivalencia_Bus busUniEqui = new vwIn_UnidadMedida_Equivalencia_Bus();        
        BindingList<vwIn_UnidadMedida_Equivalencia_Info> BindListaUnidadMedida = new BindingList<vwIn_UnidadMedida_Equivalencia_Info>();
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
        #endregion
       
        public FrmIn_Ingreso_x_OrdenCompra_Mant()
        {
            try
            {
                InitializeComponent();

                ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
                ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
                ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
                ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;

                event_FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing += FrmIn_Ingreso_x_OrdenCompra_Mant_event_FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing;
                gridViewIngreso.CellValueChanging += gridViewIngreso_CellValueChanging;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
      
        public Boolean ValidarParametros() 
        {
            try
            {
                var itemparam = parametros_B.Get_Info_Parametro(param.IdEmpresa);

                if (string.IsNullOrEmpty( itemparam.ApruebaAjusteFisicoAuto )) 
                {
                    return false;
                }
               
                if (string.IsNullOrEmpty(itemparam.IdCtaCble_CostoInven)) 
                {
                    return false;
                }
                //if (string.IsNullOrEmpty(itemparam.IdCtaCble_Inven)) 
                //{
                //    return false;
                //}
                if (!itemparam.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa.HasValue)
                {
                    return false;
                }
                if (!itemparam.IdMovi_inven_tipo_egresoAjuste.HasValue) 
                {
                    return false;
                }
                if (!itemparam.IdMovi_inven_tipo_egresoBodegaOrigen.HasValue) 
                {
                    return false;
                }
                if (!itemparam.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa.HasValue) 
                {
                    return false;
                }
                if (!itemparam.IdMovi_inven_tipo_ingresoAjuste.HasValue) 
                {
                    return false;
                }
                if (!itemparam.IdMovi_inven_tipo_ingresoBodegaDestino.HasValue) 
                {
                    return false;
                }
                if (!itemparam.IdMovi_Inven_tipo_x_anu_Egr.HasValue) 
                {
                    return false;
                }
                if (!itemparam.IdMovi_Inven_tipo_x_anu_Ing.HasValue) 
                {
                    return false;
                }
                if (itemparam.IdSucursalSuministro == 0) 
                {
                    return false;
                }
                if (!itemparam.IdTipoCbte_CostoInven.HasValue) 
                {
                    return false;
                }
                if (!itemparam.IdTipoCbte_CostoInven_Reverso.HasValue)
                {
                    return false;
                }
                if (string.IsNullOrEmpty(itemparam.Maneja_Stock_Negativo)) 
                {
                    return false;
                }
                if (string.IsNullOrEmpty(itemparam.Mostrar_CentroCosto_en_transacciones)) 
                {
                    return false;
                }
                 
                

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
     
        void gridViewIngreso_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {               
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        void FrmIn_Ingreso_x_OrdenCompra_Mant_event_FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
      
        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                string mensaje = "";
                info_IngComp.IdusuarioUltAnu = param.IdUsuario;
                info_IngComp.Fecha_UltAnu = param.Fecha_Transac;
                if (MessageBox.Show("Esta Seguro que desea eliminar el Item","Sistemas ERP",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
                if (lblAnulado.Visible)
                {
                    MessageBox.Show("No se puede Anular un item anulado");
                    return;
                }

                Winform.General.FrmGe_MotivoAnulacion ofrm = new General.FrmGe_MotivoAnulacion();
                ofrm.ShowDialog();
                info_IngComp.MotivoAnulacion = ofrm.motivoAnulacion;
                Bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                if (Bus_IngEgr.AnularDB(info_IngComp, ref mensaje))
                {
                    MessageBox.Show(mensaje, "Sistemas");
                    lblAnulado.Visible = true;
                  
                }
                else
                {
                    string msgRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Anular;
                    MessageBox.Show(msgRecurso, param.Nombre_sistema);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Imprimir()
        {
            try
            {
                int IdEmpresa = 0;
                int IdSucursal = 0;
                int IdBodega = 0;
                int IdMovi_inven_tipo = 0;
                decimal IdNumMovi = 0;
                bus_Comparam = new com_parametro_Bus();
                info_Comparam = bus_Comparam.Get_Info_parametro(param.IdEmpresa);

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        XINV_NAT_Rpt004_Rpt reporte_personalizado = new XINV_NAT_Rpt004_Rpt();

                        IdEmpresa = param.IdEmpresa;
                        IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                        IdBodega = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                        IdNumMovi = Convert.ToDecimal(txtNumIngreso.Text);
                        IdMovi_inven_tipo = Convert.ToInt32(info_Comparam.IdMovi_inven_tipo_OC);

                        reporte_personalizado.PIdEmpresa.Value = IdEmpresa;
                        reporte_personalizado.PIdSucursal.Value = IdSucursal;
                        reporte_personalizado.PIdBodega.Value = IdBodega;
                        reporte_personalizado.PIdNumMovi.Value = IdNumMovi;
                        reporte_personalizado.PIdMovi_inven_tipo.Value = IdMovi_inven_tipo;

                        reporte_personalizado.PIdEmpresa.Visible = false;
                        reporte_personalizado.PIdSucursal.Visible = false;
                        reporte_personalizado.PIdBodega.Visible = false;
                        reporte_personalizado.PIdNumMovi.Visible = false;
                        reporte_personalizado.PIdMovi_inven_tipo.Visible = false;

                        reporte_personalizado.RequestParameters = false;

                        reporte_personalizado.ShowPreviewDialog();

                        break;
                    default:
                        XCOMP_Rpt003_Rpt reporte = new XCOMP_Rpt003_Rpt();

                        IdEmpresa = param.IdEmpresa;
                        IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                        IdBodega = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                        IdNumMovi = Convert.ToDecimal(txtNumIngreso.Text);
                        IdMovi_inven_tipo = Convert.ToInt32(info_Comparam.IdMovi_inven_tipo_OC);

                        reporte.set_parametros(IdEmpresa, IdSucursal, IdBodega, IdNumMovi, IdMovi_inven_tipo);
                        reporte.RequestParameters = true;

                        reporte.ShowPreviewDialog();
                        break;
                }                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (grabar())
                    { Close(); }                 
                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (grabar()) { };    
                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void carga_Combos()
        {
            try
            {
               
                //carga centro costo                           
                Bus_CentroCosto = new ct_Centro_costo_Bus();
                list_centroCosto = new List<ct_Centro_costo_Info>();
                list_centroCosto = Bus_CentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmbCentroCosto_grid.DataSource = list_centroCosto;

                list_subcentro_combo = Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_sub_centro_costo.DataSource = list_subcentro_combo;

                bus_puntoCargo = new ct_punto_cargo_Bus();
                listPuntoCargo = new List<ct_punto_cargo_Info>();
                listPuntoCargo = bus_puntoCargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmbPuntoCargo_grid.DataSource = listPuntoCargo;

                list_grupo = bus_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_grupo_punto_cargo.DataSource = list_grupo;

                
                
                Bus_Uni_Med = new in_UnidadMedida_Bus();
                list_UniMe = new List<in_UnidadMedida_Info>();
                list_UniMe=Bus_Uni_Med.Get_list_UnidadMedida();
                cmb_unidad_medida.DataSource = list_UniMe;
                cmb_unidad_medida.DisplayMember = "Descripcion";
                cmb_unidad_medida.ValueMember = "IdUnidadMedida";

                //carga Motivo Inventario  
                bus_MotivoInv = new in_Motivo_Inven_Bus();
                list_MotivoInv = new List<in_Motivo_Inven_Info>();
                list_MotivoInv = bus_MotivoInv.Get_List_Motivo_Inven(param.IdEmpresa);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }               
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                        this.txtNumIngreso.Enabled = false;
                        this.txtNumIngreso.BackColor = System.Drawing.Color.White;
                        this.txtNumIngreso.ForeColor = System.Drawing.Color.Black;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                        Inhabilita_Controles();

                        checkTodos.Enabled = false;                 
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;

                        Inhabilita_Controles();

                        dtpFecha.Enabled = false;

                        txtObservacion.Enabled = false;
                        txtObservacion.BackColor = System.Drawing.Color.White;
                        txtObservacion.ForeColor = System.Drawing.Color.Black;

                        checkTodos.Enabled = false;
                  
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                        Inhabilita_Controles();

                        dtpFecha.Enabled = false;

                        txtObservacion.Enabled = false;
                        txtObservacion.BackColor = System.Drawing.Color.White;
                        txtObservacion.ForeColor = System.Drawing.Color.Black;

                        checkTodos.Enabled = false;                   
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Inhabilita_Controles()
        {
            try
            {            
                txtCodigo.Enabled = false;
                txtCodigo.BackColor = System.Drawing.Color.White;
                txtCodigo.ForeColor = System.Drawing.Color.Black;
                cmbMotivoInv.Enabled = false;
                cmbMotivoInv.BackColor = System.Drawing.Color.White;
                cmbMotivoInv.ForeColor = System.Drawing.Color.Black;

                
                

                ucIn_Sucursal_Bodega1.cmb_sucursal.Enabled = false;
                ucIn_Sucursal_Bodega1.cmb_bodega.Enabled = false;

                txtNumIngreso.Enabled = false;
                txtNumIngreso.BackColor = System.Drawing.Color.White;
                txtNumIngreso.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Ingreso_x_OrdenCompra_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlIngreso.DataSource = ListaBind;
                
                carga_Combos();

                switch (param.IdCliente_Ven_x_Default)
                {
                   case Cl_Enumeradores.eCliente_Vzen.CAH:
                        colIdCentroCosto_sub_centro_costo.Visible = false;
                        col_grupo_pto_cargo.Visible = true;
                        colIdPunto_cargo.Visible = true;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        col_grupo_pto_cargo.Visible = false;
                        colIdPunto_cargo.Visible = false;
                        break;
                    default:
                        break;
                }
              
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        setInfo();
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                        Buscar_Orden_Compra_();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        setInfo();
                        Inhabilita_Controles();
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        setInfo();
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                txtNumIngreso.Text = "";
                ucCp_Proveedor.set_ProveedorInfo(-1);
                cmbMotivoInv.Inicializar_cmbMotivoInv();
                txtObservacion.Text = "";
                txtCodigo.Text = "";
                dtpFecha.Value = DateTime.Now;
                info_IngComp = new in_Ing_Egr_Inven_Info();
                info_IngComp.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();
                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlIngreso.DataSource = ListaBind;
                ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(0, 0, 0, 0, 0);
                ucIn_Sucursal_Bodega1.InicializarBodega();
                ucIn_Sucursal_Bodega1.InicializarSucursal();
                Buscar_Orden_Compra_();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
        void Get()
        {
            try
            {
                info_IngComp.IdEmpresa = param.IdEmpresa;
                info_IngComp.IdNumMovi = Convert.ToDecimal((txtNumIngreso.Text == "") ? "0" : txtNumIngreso.Text);
                info_IngComp.IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                info_IngComp.IdBodega = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                info_IngComp.CodMoviInven= txtCodigo.Text;                
                info_IngComp.IdMotivo_Inv = cmbMotivoInv.get_MotivoInvInfo().IdMotivo_Inv;
                info_IngComp.cm_observacion= txtObservacion.Text;
                info_IngComp.cm_fecha= dtpFecha.Value;
                info_IngComp.signo= "+";

                bus_Comparam = new com_parametro_Bus();
                info_Comparam = new com_parametro_Info();
                info_Comparam = bus_Comparam.Get_Info_parametro(param.IdEmpresa);

                info_IngComp.IdMovi_inven_tipo = info_Comparam.IdMovi_inven_tipo_OC;                    
                info_IngComp.Fecha_Transac = param.Fecha_Transac;
                info_IngComp.nom_pc=param.nom_pc;
                info_IngComp.ip = param.ip;
                info_IngComp.IdUsuario = param.IdUsuario;
  
                GetDetalle();

                info_IngComp.listIng_Egr= list_IngxComp;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetDetalle()
        {
            try
            {
                list_IngxComp = new List<in_Ing_Egr_Inven_det_Info>();

                int focus = gridViewIngreso.FocusedRowHandle;
                gridViewIngreso.FocusedRowHandle = focus + 1;

                foreach (var item in ListaBind)
                {
                    if (item.IdEstadoAproba == null || item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString())
                    {
                        in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();

                        if (item.Checked == true)
                        {
                            info.Checked = item.Checked;
                            info.IdEmpresa_oc = item.IdEmpresa_oc;
                            info.IdSucursal_oc = item.IdSucursal_oc;
                            info.IdOrdenCompra = item.IdOrdenCompra;
                            info.Secuencia_oc = item.Secuencia_oc;
                            info.IdOrdenCompra = item.IdOrdenCompra;

                            info.IdProducto = item.IdProducto;                            
                            info.dm_stock_ante = item.dm_stock_ante;
                            info.dm_stock_actu = item.dm_stock_actu;
                            info.dm_observacion = item.dm_observacion;
                            
                            info.dm_precio = item.dm_precio;
                            info.mv_costo_sinConversion = item.mv_costo;
                            info.mv_costo = item.mv_costo;

                            info.dm_peso = item.dm_peso;

                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = (item.IdCentroCosto_sub_centro_costo == null) ? null : list_subcentro_combo.FirstOrDefault(v => v.IdCentroCosto == item.IdCentroCosto && v.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).IdCentroCosto_sub_centro_costo;

                            info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                            info.IdPunto_cargo = item.IdPunto_cargo;
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdNumMovi = item.IdNumMovi;
                            info.Secuencia = item.Secuencia;
                            info.IdBodega = item.IdBodega;
                            info.pr_descripcion = item.pr_descripcion;

                            
                            info.dm_cantidad_sinConversion = item.dm_cantidad;
                            info.IdUnidadMedida_sinConversion = item.IdUnidadMedida;
                            

                            info.dm_cantidad = item.dm_cantidad;
                            info.IdUnidadMedida = item.IdUnidadMedida;
                            info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                            

                            list_IngxComp.Add(info);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setInfo()
        {
            try
            {
               
                txtNumIngreso.Text = Convert.ToString(SETINFO_.IdNumMovi);
                ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue = SETINFO_.IdSucursal;
                ucIn_Sucursal_Bodega1.cmb_bodega.EditValue = SETINFO_.IdBodega;
                dtpFecha.Value = SETINFO_.cm_fecha;                        
                cmbMotivoInv.set_MotivoInvInfo(Convert.ToInt32(SETINFO_.IdMotivo_Inv));
                modifica_grilla();
               
                
                txtObservacion.Text = SETINFO_.cm_observacion;
                txtCodigo.Text = SETINFO_.CodMoviInven;
           
                lblAnulado.Visible = SETINFO_.Estado == "I"? true:false;
                                      
                //consulta detalle          
                Bus_IngEgrDet = new in_Ing_Egr_Inven_det_Bus();
                lista_IngEgrInv = new List<in_Ing_Egr_Inven_det_Info>();
                lista_IngEgrInv = Bus_IngEgrDet.Get_List_Ing_Egr_Inven_det_x_Num_Movimiento(param.IdEmpresa, SETINFO_.IdSucursal, SETINFO_.IdMovi_inven_tipo, SETINFO_.IdNumMovi);

                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>(lista_IngEgrInv);
                gridControlIngreso.DataSource = ListaBind;

          
                //var item = lista_IngEgrInv.FirstOrDefault();
                //ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdSucursal), Convert.ToInt32(item.IdBodega), Convert.ToInt32(item.IdMovi_inven_tipo), Convert.ToDecimal(item.IdNumMovi));
               //ucCp_Proveedor.set_ProveedorInfo((int)item.IdProveedor);

                                                  
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Validar()
        {
            try
            {
                if (ucIn_Sucursal_Bodega1.get_sucursal()==null || ucIn_Sucursal_Bodega1.get_sucursal().IdSucursal==0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " una sucursal",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                tb_Sucursal_Info info_Sucursal = new tb_Sucursal_Info();
                info_Sucursal = ucIn_Sucursal_Bodega1.get_sucursal();
                
                tb_Bodega_Info info_Bodega = new tb_Bodega_Info();
                info_Bodega = ucIn_Sucursal_Bodega1.get_bodega();
                if (MessageBox.Show("¿Está seguro que desea generar el ingreso a la bodega [" + info_Bodega.IdBodega + "] " + info_Bodega.bo_Descripcion + "?", param.Nombre_sistema
,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
                {
                    return false;
                }
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        foreach (var item in ListaBind.Where(q=>q.Checked == true).ToList())
                        {
                            if (cmbMotivoInv.get_MotivoInvInfo().es_Inven_o_Consumo == ein_Inventario_O_Consumo.TIC_CONSU)
                            {
                                if (item.IdCentroCosto == null || item.IdCentroCosto == "")
                                {
                                    MessageBox.Show("Existen registros sin centro de costo, por favor corrija",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                    return false;
                                }
                                if (item.IdCentroCosto_sub_centro_costo == null || item.IdCentroCosto_sub_centro_costo == "")
                                {
                                    MessageBox.Show("Existen registros sin sub centro de costo, por favor corrija", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
                

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(dtpFecha.Value)))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean grabar()
        {
            try
            {
                
                txtNumIngreso.Focus();
                Get();
                string mensaje = "";
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        Boolean resultB;
                        resultB = true;

                        decimal IdIngreso_oc = 0;
                        Bus_IngEgr = new in_Ing_Egr_Inven_Bus();

                        if (Bus_IngEgr.GuardarDB(info_IngComp, ref   IdIngreso_oc, ref mensaje))
                        {                            
                            txtNumIngreso.Text = Convert.ToString(IdIngreso_oc);
                            string smensaje ="";
                            if (mensaje == "")
                                smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro del Ingreso a Bodega ", IdIngreso_oc.ToString());
                            else
                                smensaje = mensaje;
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            //consulta detalle
                            var item = info_IngComp.listIng_Egr.FirstOrDefault();
                            //ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdSucursal), Convert.ToInt32(item.IdBodega), Convert.ToInt32(item.IdMovi_inven_tipo), Convert.ToDecimal(item.IdNumMovi));
            

                            
                            // actualizar estado cierre cabecera OC

                            Bus_IngEgrDet= new in_Ing_Egr_Inven_det_Bus();
                         
                            List<in_Ing_Egr_Inven_det_Info> lista_IngEgr = new List<in_Ing_Egr_Inven_det_Info>();
                            lista_IngEgr = Bus_IngEgrDet.Get_List_Ing_Egr_det_x_OC_Agrupado(Convert.ToInt32(item.IdEmpresa_oc), Convert.ToInt32(item.IdSucursal_oc), Convert.ToDecimal(item.IdOrdenCompra));

                            if (lista_IngEgr.Count !=0)
                            {
                                string Estado_cierre = "";

                                foreach (var item2 in lista_IngEgr)
                                {                                   
                                    //consulta detalle OC
                                    com_ordencompra_local_det_Bus bus_detoc = new com_ordencompra_local_det_Bus();
                                    com_ordencompra_local_Bus bus_oc = new com_ordencompra_local_Bus();

                                    List<com_ordencompra_local_det_Info> lista_oc = new List<com_ordencompra_local_det_Info>();
                                    lista_oc = bus_detoc.Get_List_ordencompra_local_det_Agrupado(Convert.ToInt32(item2.IdEmpresa_oc), Convert.ToInt32(item2.IdSucursal_oc), Convert.ToDecimal(item2.IdOrdenCompra));

                                    if (lista_oc.Count !=0)
                                    {
                                        com_ordencompra_local_det_Info itemDet = lista_oc.FirstOrDefault(q => q.IdEmpresa == item2.IdEmpresa_oc && q.IdSucursal == item2.IdSucursal_oc && q.IdOrdenCompra == item2.IdOrdenCompra);
                                        
                                      if (item2.dm_cantidad > 1 && item2.dm_cantidad < itemDet.do_Cantidad)
                                        {
                                            // actualizar cabecera OC estado cierre="PEN"
                                            Estado_cierre = "PEN";
                                            bus_oc.Modificar_Estado_Cierre(Convert.ToInt32(item2.IdEmpresa_oc), Convert.ToInt32(item2.IdSucursal_oc), Convert.ToDecimal(item2.IdOrdenCompra), Estado_cierre);
                                        }
                                      else
                                        if (item2.dm_cantidad == itemDet.do_Cantidad)
                                        {
                                            // actualizar cabecera OC estado cierre="CERR"
                                            Estado_cierre = "CERR";
                                            bus_oc.Modificar_Estado_Cierre(Convert.ToInt32(item2.IdEmpresa_oc), Convert.ToInt32(item2.IdSucursal_oc), Convert.ToDecimal(item2.IdOrdenCompra), Estado_cierre);
                                        }                                   
                                    }                                                                                                     
                                }                                                       
                            }

                            if (MessageBox.Show("¿Desea Imprimir el Ingreso a Bodega x OC. # " + IdIngreso_oc + "\n" + "Imprimir", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(null, null);
                            }
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al grabar el Ingreso a Bodega, " + mensaje, param.Nombre_sistema);
                            return false;
                        }
                      
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        info_IngComp.IdUsuarioUltModi = param.IdUsuario;
                        info_IngComp.Fecha_UltMod = param.Fecha_Transac;
                        Bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                        if (Bus_IngEgr.ModificarDB(info_IngComp, ref mensaje))
                        {
                            //ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                            //ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                            MessageBox.Show(mensaje, "Sistemas");
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el registro: ", "Operación Fallida");
                            return false;
                        }

                        break;
                    default:
                        break;
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }               
        }
       
        private void gridViewIngreso_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = (in_Ing_Egr_Inven_det_Info)this.gridViewIngreso.GetRow(e.RowHandle);
                if (Info == null) return;

                Accion = Cl_Enumeradores.eTipo_action.grabar;

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (e.HitInfo.Column != null)
                    {

                        e.HitInfo.Column.FieldName = gridViewIngreso.FocusedColumn.FieldName;

                        if (e.HitInfo.Column.FieldName == "Checked")
                        {
                            if ((Boolean)gridViewIngreso.GetFocusedRowCellValue(colChecked))
                            {
                                gridViewIngreso.SetFocusedRowCellValue(colChecked, false);

                                if ((Boolean)gridViewIngreso.GetFocusedRowCellValue(colChecked) == false)
                                {
                                    var asd = gridViewIngreso.GetRow(gridViewIngreso.FocusedRowHandle);
                                }

                                gridViewIngreso.SetFocusedRowCellValue(colSaldo_x_Ing_OC, gridViewIngreso.GetFocusedRowCellValue(colSaldo_x_Ing_OC_AUX));
                                gridViewIngreso.SetFocusedRowCellValue(coldm_cantidad, 0);
                                cargarDescripcion();
                                return;
                            }
                            else
                            {
                                gridViewIngreso.SetFocusedRowCellValue(colSaldo_x_Ing_OC, 0);
                                gridViewIngreso.SetFocusedRowCellValue(coldm_cantidad, gridViewIngreso.GetFocusedRowCellValue(colSaldo_x_Ing_OC_AUX));

                                gridViewIngreso.SetFocusedRowCellValue(colChecked, true);

                                if (Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(coldm_cantidad)) == 0)
                                {
                                    gridViewIngreso.SetFocusedRowCellValue(colChecked, false);
                                }
                            }
                        }
                        cargarDescripcion();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cargarDescripcion()
        {
            try
            {
                BindingList<in_Ing_Egr_Inven_det_Info> lstDetInfo_Ing = new BindingList<in_Ing_Egr_Inven_det_Info>();
                lstDetInfo_Ing = ListaBind;
                string strObservacion = "";
                
                var select = from lstDet in lstDetInfo_Ing
                             group lstDet by new
                             {
                                 lstDet.IdEmpresa,
                                 lstDet.IdOrdenCompra,
                                 lstDet.Checked,
                                 lstDet.oc_observacion,
                             } into grouping
                             select new { grouping.Key };

                foreach (var item in select)
                {
                    if (item.Key.Checked)
                    {
                        if (strObservacion != "")
                            strObservacion = strObservacion + " - " + item.Key.oc_observacion;
                        else
                            strObservacion = item.Key.oc_observacion;
                    }
                }
                txtObservacion.Text = strObservacion;                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewIngreso_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
         {
            try
            {
                Info = (in_Ing_Egr_Inven_det_Info)this.gridViewIngreso.GetRow(e.RowHandle);
                if (Info == null)
                    return;
                
              if (e.Column.Name == "coldm_cantidad")
                {

                    double cantidad_ing_a_Inven = Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(coldm_cantidad));

                    if (Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(coldm_cantidad)) == 0)
                    {                     
                        gridViewIngreso.SetFocusedRowCellValue(colSaldo_x_Ing_OC, Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(colSaldo_x_Ing_OC_AUX)));
                        gridViewIngreso.SetFocusedRowCellValue(colChecked, false);
                       
                        return;
                    }
                    
                    if (Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(coldm_cantidad)) < 0)
                    {                   
                      gridViewIngreso.SetFocusedRowCellValue(coldm_cantidad, 0);
                      gridViewIngreso.SetFocusedRowCellValue(colChecked, false);
                     return;
                    }

                    double cantidad_pedida_OC = Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(colcantidad_pedida_OC));

                    if (Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(coldm_cantidad)) > Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(colcantidad_pedida_OC)))
                    {
                        cant_aux = Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(colSaldo_x_Ing_OC_AUX));

                        gridViewIngreso.SetFocusedRowCellValue(colSaldo_x_Ing_OC, Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(colSaldo_x_Ing_OC_AUX)));

                      double  Saldo_x_Ing_OC = Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(colSaldo_x_Ing_OC));

                      gridViewIngreso.SetFocusedRowCellValue(coldm_cantidad, 0);
                      gridViewIngreso.SetFocusedRowCellValue(colChecked, false);
                        return;
                    }
                  
                    if(Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(coldm_cantidad)) <= Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(colcantidad_pedida_OC)))
                    {

                        gridViewIngreso.SetFocusedRowCellValue(colSaldo_x_Ing_OC, Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(colSaldo_x_Ing_OC_AUX)) - Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(coldm_cantidad)));

                        double resul =Convert.ToDouble( gridViewIngreso.GetFocusedRowCellValue(colSaldo_x_Ing_OC));

                        if (resul < 0)
                        {
                            gridViewIngreso.SetFocusedRowCellValue(coldm_cantidad, 0);
                            gridViewIngreso.SetFocusedRowCellValue(colSaldo_x_Ing_OC, Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(colSaldo_x_Ing_OC_AUX)));

                            gridViewIngreso.SetFocusedRowCellValue(colChecked, false);
                        }
                        else
                        {
                            gridViewIngreso.SetFocusedRowCellValue(colChecked, true);
                        }
                    }                 
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewIngreso_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var Item = (in_Ing_Egr_Inven_det_Info)gridViewIngreso.GetRow(e.FocusedRowHandle);
                RowHandle = e.FocusedRowHandle;
                if (Item != null)
                {
                    if (Item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    {
                        coldm_cantidad.OptionsColumn.AllowEdit = false;
                        colIdCentroCosto.OptionsColumn.AllowEdit = false;
                        colIdPunto_cargo.OptionsColumn.AllowEdit = false;
                        //colUnidadMedida_Grid.OptionsColumn.AllowEdit = false;
                        colIdProducto.OptionsColumn.AllowEdit = false;
                        coldm_cantidad.OptionsColumn.AllowEdit = false;
                        colIdPunto_cargo.OptionsColumn.AllowEdit = false;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_Load(object sender, EventArgs e)
        {

        }

        private void checkTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                gridViewIngreso.MoveNext();
                for (int i = 0; i < gridViewIngreso.RowCount; i++)
                {                    
                    {
                        gridViewIngreso.SetRowCellValue(i, colChecked, checkTodos.Checked);

                        if (checkTodos.Checked)
                        {
                            gridViewIngreso.SetRowCellValue(i, coldm_cantidad, gridViewIngreso.GetRowCellValue(i, colSaldo_x_Ing_OC_AUX));
                            gridViewIngreso.SetRowCellValue(i, colSaldo_x_Ing_OC, 0);
                        }
                        else
                        {
                            gridViewIngreso.SetRowCellValue(i, colSaldo_x_Ing_OC, gridViewIngreso.GetRowCellValue(i, coldm_cantidad));
                            gridViewIngreso.SetRowCellValue(i, coldm_cantidad, 0);
                        }    
                    }                    
                }

                gridControlIngreso.DataSource = ListaBind;
                gridControlIngreso.RefreshDataSource();
                cargarDescripcion();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar_Orden_Compra_()
        {
            try
            {
                decimal IdProveedor = 0;
                IdProveedor=(ucCp_Proveedor.get_ProveedorInfo() == null)?0:ucCp_Proveedor.get_ProveedorInfo().IdProveedor;

                bus_IngxCompDet = new in_Ingreso_x_OrdenCompra_det_Bus();
                list = new List<in_Ingreso_x_OrdenCompra_det_Info>();
                list = bus_IngxCompDet.Get_List_Ingreso_x_OrdenCompra_det_x_proveedor(param.IdEmpresa, IdProveedor);

                if (list.Count() == 0)
                {
                    MessageBox.Show("No hay órdenes de compras pendientes por ingresar", "Sistemas");
                    ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>();
                    gridControlIngreso.DataSource = ListaBind;
                    return;
                }

                // convertir 
                List<in_Ing_Egr_Inven_det_Info> lista_AUX = new List<in_Ing_Egr_Inven_det_Info>();
                foreach (var item in list)
                {
                    in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();

                    info.IdEmpresa_oc = item.IdEmpresa;
                    info.IdSucursal_oc = item.IdSucursal;
                    info.IdOrdenCompra = item.IdOrdenCompra;
                    info.Secuencia_oc = item.secuencia_oc_det;
                    info.nom_sucu = item.nom_sucu;
                    info.IdProveedor = item.IdProveedor;
                    info.nom_proveedor = item.nom_proveedor;
                    info.oc_observacion = item.oc_observacion;
                    info.cod_producto = item.cod_producto;
                    info.nom_producto = item.nom_producto;
                    info.IdProducto = item.IdProducto;
                    
                    info.dm_precio = item.oc_precio;
                    info.mv_costo = item.oc_precio;


                    info.cantidad_pedida_OC = item.cantidad_pedida_OC;
                    info.dm_cantidad = item.cantidad_ing_a_Inven;
                    info.Saldo_x_Ing_OC = item.Saldo_x_Ing_OC;
                    info.dm_stock_ante = item.pr_stock;
                    info.dm_stock_actu = item.pr_stock + info.dm_cantidad;
                    info.dm_peso = item.pr_peso;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    info.IdPunto_cargo = item.IdPunto_cargo;
                    info.Saldo_x_Ing_OC_AUX = item.Saldo_x_Ing_OC_AUX;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.IdMotivo_OC = item.IdMotivo_OC;
                    info.Nom_Motivo = item.Nom_Motivo;
                    
                    info.dm_observacion = "Ingreso por Orden de Compra";
                    info.oc_fecha = item.oc_fecha;

                    info.IdEstado_cierre = item.IdEstado_cierre;
                    info.nom_estado_cierre = item.nom_estado_cierre;

                    info.IdRegistro = item.Nomsub_centro_costo;
                    info.Ref_OC = item.Ref_OC;
                    info.do_descuento = Convert.ToDouble(item.do_descuento);
                    info.do_subtotal = Convert.ToDouble(item.do_subtotal);
                    info.do_iva = Convert.ToDouble(item.do_iva);
                    info.do_total = Convert.ToDouble(item.do_total);

                    info.nom_UnidadMedida = item.Descripcion;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.oc_NumDocumento = item.oc_NumDocumento;
                    lista_AUX.Add(info);
                }

                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>(lista_AUX);
                gridControlIngreso.DataSource = ListaBind;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {



                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewIngreso.DeleteSelectedRows();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucCp_Proveedor_event_cmb_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Buscar_Orden_Compra_();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Llamar_a_pantalla_subcentro()
        {
            try
            {
                in_Ing_Egr_Inven_det_Info Row = (in_Ing_Egr_Inven_det_Info)gridViewIngreso.GetRow(RowHandle);
                if (Row != null)
                {
                    if (Row.IdCentroCosto != null)
                    {
                        List<ct_centro_costo_sub_centro_costo_Info> Lista_subcentro_consulta = new List<ct_centro_costo_sub_centro_costo_Info>();
                        Lista_subcentro_consulta = list_subcentro_combo.Where(q => q.IdEmpresa == param.IdEmpresa && q.IdCentroCosto == Row.IdCentroCosto).ToList();
                        if (Lista_subcentro_consulta != null && Lista_subcentro_consulta.Count != 0)
                        {
                            frmCon_ct_centro_costo_sub_centro_costo_Cons frm_combo = new frmCon_ct_centro_costo_sub_centro_costo_Cons();
                            frm_combo.Set_config_combo(Lista_subcentro_consulta);
                            frm_combo.ShowDialog();
                            info_subcentro = frm_combo.Get_info_centro_sub_centro_costo();
                            gridViewIngreso.SetRowCellValue(RowHandle, colIdCentroCosto_sub_centro_costo, info_subcentro == null ? null : info_subcentro.IdRegistro);
                            gridViewIngreso.SetRowCellValue(RowHandle, col_IDSUBCENTRO, info_subcentro == null ? null : info_subcentro.IdCentroCosto_sub_centro_costo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_sub_centro_costo_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_a_pantalla_subcentro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbPuntoCargo_grid_Click(object sender, EventArgs e)
        {
            try
            {
                 in_Ing_Egr_Inven_det_Info Row = (in_Ing_Egr_Inven_det_Info)gridViewIngreso.GetRow(RowHandle);
                 if (Row != null)
                 {
                     if (Row.IdPunto_cargo_grupo != null)
                     {
                         carga_Combos();
                         frmCon_Punto_Cargo_Cons frm_combo = new frmCon_Punto_Cargo_Cons();
                         frm_combo.Cargar_grid_x_grupo(Convert.ToInt32(Row.IdPunto_cargo_grupo));
                         frm_combo.ShowDialog();
                         info_punto_cargo = frm_combo.Get_Info();
                         if (info_punto_cargo != null) 
                             gridViewIngreso.SetRowCellValue(RowHandle, colIdPunto_cargo, info_punto_cargo.IdPunto_cargo);
                         else 
                             gridViewIngreso.SetRowCellValue(RowHandle, colIdPunto_cargo, null); 
                     }
                     //RowHandle=
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbMotivoInv_event_cmbMotivoInv_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                modifica_grilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

         private void modifica_grilla()
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {

                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        
                        bool mueve = false;

                        info_MotivoInv = cmbMotivoInv.get_MotivoInvInfo();
                        if (info_MotivoInv != null)
                        {
                            mueve = Convert.ToBoolean(info_MotivoInv.Genera_Movi_Inven.Equals("S") ? true : false);

                            if (mueve)
                            {                                
                                colIdCentroCosto_sub_centro_costo.Visible = false;
                                colIdCentroCosto.Visible = false;
                            }
                            else
                            {
                                colIdCentroCosto.Visible = true;
                                colIdCentroCosto_sub_centro_costo.Visible = true;
                            } 
                        }
                        
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_sub_centro_costo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Llamar_a_pantalla_subcentro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
