using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Conciliacion_Ing_Bod_x_OG_Mant : DevExpress.XtraEditors.XtraForm
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_frmCP_Conciliacion_Ing_Bod_x_OG_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_Conciliacion_Ing_Bod_x_OG_Mant_FormClosing event_delegate_frmCP_Conciliacion;
        Cl_Enumeradores.eTipo_action _Accion;        
        public cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info _InfoConci { get; set; }
        BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info> list_Aprob = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
        cp_Aprobacion_Ing_Bod_x_OC_det_Bus Bus_Aprob = new cp_Aprobacion_Ing_Bod_x_OC_det_Bus();
        cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus busConciliacion = new cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus();
        BindingList<vwcp_Orden_Giro_Pendiente_Conciliar_Info> lstPendiFact = new BindingList<vwcp_Orden_Giro_Pendiente_Conciliar_Info>();
        cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info Info_Ing_Bod = new cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info();

        double ValorFacturas = 0;
        double valorIngresos = 0;


        public frmCP_Conciliacion_Ing_Bod_x_OG_Mant()
        {
            InitializeComponent();
            event_delegate_frmCP_Conciliacion += new delegate_frmCP_Conciliacion_Ing_Bod_x_OG_Mant_FormClosing(frmCP_Conciliacion_Ing_Bod_x_OG_Mant_event_delegate_frmCP_Conciliacion);
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
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
                if (GuardarConciliacion())
                    this.Close();
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
                GuardarConciliacion();
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
                AnularConciliacion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCP_Conciliacion_Ing_Bod_x_OG_Mant_event_delegate_frmCP_Conciliacion(object sender, FormClosingEventArgs e)
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


        public void setAccion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmCP_Conciliacion_Ing_Bod_x_OG_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:                        
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;                        
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Conciliacion_Ing_Bod_x_OG_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmCP_Conciliacion_Ing_Bod_x_OG_Mant_event_delegate_frmCP_Conciliacion(sender, e);
                event_delegate_frmCP_Conciliacion(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Info()
        {
            try
            {
                lstPendiFact = new BindingList<vwcp_Orden_Giro_Pendiente_Conciliar_Info>();
                txtIdConciliacion.EditValue = _InfoConci.IdConciliacion;
                dtpFechaConciliacion.Value = _InfoConci.Fecha_Conciliacion;
                cmbProveedor.set_ProveedorInfo(_InfoConci.IdProveedor);
                txtObservacion.EditValue = _InfoConci.Observacion;

                lstPendiFact = new BindingList<vwcp_Orden_Giro_Pendiente_Conciliar_Info>(busConciliacion.Get_List_OG_Facturas_Conciliadas(_InfoConci.IdEmpresa, _InfoConci.IdConciliacion));
                gridFacturaProveedor.DataSource = lstPendiFact;
                this.col_Checked_fac.OptionsColumn.ReadOnly = true;
                //gridFacturaProveedor.Enabled = false;

                list_Aprob = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>(busConciliacion.Get_List_Ing_Bod_x_OC_Conciliadas(_InfoConci.IdEmpresa, _InfoConci.IdConciliacion));
                
                gridIngresoBodega.DataSource = list_Aprob;
                this.col_Checked_ing.OptionsColumn.ReadOnly = true;
                //gridIngresoBodega.Enabled = false;
    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void get_Info()
        {
            try
            {
                Info_Ing_Bod.IdEmpresa =  param.IdEmpresa;
                Info_Ing_Bod.IdConciliacion =  (txtIdConciliacion.EditValue == null) ? 0 : Convert.ToDecimal(txtIdConciliacion.EditValue);
                Info_Ing_Bod.Fecha_Conciliacion = dtpFechaConciliacion.Value;
                Info_Ing_Bod.IdProveedor = cmbProveedor.get_ProveedorInfo().IdProveedor;
                Info_Ing_Bod.Observacion = Convert.ToString(txtObservacion.EditValue);
                Info_Ing_Bod.IdEmpresa_Apro_Ing = 0;
                Info_Ing_Bod.IdAprobacion_Apro_Ing = 0;
                Info_Ing_Bod.IdUsuario = param.IdUsuario;
                Info_Ing_Bod.nom_pc = param.nom_pc;
                Info_Ing_Bod.ip = param.ip;
                Info_Ing_Bod.Estado = "A";
                
                Info_Ing_Bod.cp_Aprobacion_Ing_Bod_x_OC = new cp_Aprobacion_Ing_Bod_x_OC_Info();
                Info_Ing_Bod.cp_Aprobacion_Ing_Bod_x_OC = get_Aprobacion_Ing();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private cp_Aprobacion_Ing_Bod_x_OC_Info get_Aprobacion_Ing()
        {
            try
            {
                cp_Aprobacion_Ing_Bod_x_OC_Info Info_Ing_x_OC = new cp_Aprobacion_Ing_Bod_x_OC_Info();
                Info_Ing_x_OC.IdEmpresa = param.IdEmpresa;
                Info_Ing_x_OC.IdAprobacion = 0;                
                Info_Ing_x_OC.Fecha_aprobacion = Convert.ToDateTime(dtpFechaConciliacion.Value);
                Info_Ing_x_OC.IdProveedor = cmbProveedor.get_ProveedorInfo().IdProveedor;

                foreach (var item in lstPendiFact)
                {
                    if (item.Checked == true)
                    {
                        Info_Ing_x_OC.Fecha_Factura = item.co_FechaFactura;
                        Info_Ing_x_OC.IdEmpresa_Ogiro = item.IdEmpresa;
                        Info_Ing_x_OC.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        Info_Ing_x_OC.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        Info_Ing_x_OC.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        Info_Ing_x_OC.IdIden_credito = item.IdIden_credito;
                        Info_Ing_x_OC.Observacion = item.co_observacion;
                        Info_Ing_x_OC.Serie = item.Serie;
                        Info_Ing_x_OC.Serie2 = item.Serie2;
                        Info_Ing_x_OC.num_documento = item.numDocFactura;
                        Info_Ing_x_OC.num_auto_Proveedor = (item.Num_Autorizacion == null || item.Num_Autorizacion == "") ? " " : item.Num_Autorizacion;
                        Info_Ing_x_OC.num_auto_Imprenta = (item.Num_Autorizacion_Imprenta == null || item.Num_Autorizacion_Imprenta == "") ? " " : item.Num_Autorizacion_Imprenta;
                        Info_Ing_x_OC.co_subtotal_iva = item.co_subtotal_iva;
                        Info_Ing_x_OC.co_subtotal_siniva = item.co_subtotal_siniva;
                        Info_Ing_x_OC.Descuento = item.co_OtroValor_a_descontar;
                        Info_Ing_x_OC.co_baseImponible = item.co_baseImponible;
                        Info_Ing_x_OC.co_Por_iva = item.co_Por_iva;
                        Info_Ing_x_OC.co_valoriva = item.co_valoriva;
                        Info_Ing_x_OC.co_total = item.co_total;
                        Info_Ing_x_OC.fecha_autorizacion = item.fecha_autorizacion;
                        Info_Ing_x_OC.IdCtaCble_CXP = cmbProveedor.get_ProveedorInfo().IdCtaCble_CXP;
                        Info_Ing_x_OC.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                        Info_Ing_x_OC.pa_ctacble_iva = item.IdCtaCble_IVA;
                    }
                }

                Info_Ing_x_OC.listDetalle = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
                Info_Ing_x_OC.listDetalle = GetDetalle(Info_Ing_x_OC.IdCtaCble_Gasto, Info_Ing_x_OC.pa_ctacble_iva);

                return Info_Ing_x_OC;
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new cp_Aprobacion_Ing_Bod_x_OC_Info();
            }
        }

        private List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> GetDetalle(string IdCtaCble_Gasto, string IdCtaCble_IVA)
        {
            try
            {
                List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>  lista = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();

                int focus = gridViewIngresoBodega.FocusedRowHandle;
                gridViewIngresoBodega.FocusedRowHandle = focus + 1;
                
                foreach (var item in list_Aprob)
                {
                    cp_Aprobacion_Ing_Bod_x_OC_det_Info info = new cp_Aprobacion_Ing_Bod_x_OC_det_Info();

                    if (item.Checked == true)
                    {
                        info.IdEmpresa_Ing_Egr_Inv = item.IdEmpresa_Ing_Egr_Inv;
                        info.IdSucursal_Ing_Egr_Inv = item.IdSucursal_Ing_Egr_Inv;
                        info.IdNumMovi_Ing_Egr_Inv = item.IdNumMovi_Ing_Egr_Inv;
                        info.IdMovi_inven_tipo_Ing_Egr_Inv = item.IdMovi_inven_tipo_Ing_Egr_Inv;
                        info.Secuencia_Ing_Egr_Inv = item.Secuencia_Ing_Egr_Inv;

                        info.IdSucursal_OC = item.IdSucursal_OC;
                        info.IdOrdenCompra = item.IdOrdenCompra;
                        info.Secuencia_OC = item.Secuencia_OC;

                        info.Cantidad = item.Cantidad;
                        info.Costo_uni = item.Costo_uni;
                        info.Descuento = item.Descuento;
                        info.SubTotal = item.SubTotal;
                        info.PorIva = item.PorIva;
                        info.valor_Iva = item.valor_Iva;
                        info.Total = item.Total;
                        info.IdCtaCble_Gasto = IdCtaCble_Gasto;
                        info.IdCtaCble_IVA = IdCtaCble_IVA;

                        lista.Add(info);
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
            }
        }


        Boolean ValidarDatos()
        {
            try
            {
                txtIdConciliacion.Focus();

                int contRegis = 0;
                if (cmbProveedor.get_ProveedorInfo() == null)
                {
                    MessageBox.Show("Seleccione el Proveedor.", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbProveedor.Focus();
                    return false;
                }

                if (dtpFechaConciliacion.Value == null)
                {
                    MessageBox.Show("Seleccione la fecha de conciliación.", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpFechaConciliacion.Focus();
                    return false;
                }

                if (txtObservacion.EditValue == "" || txtObservacion.EditValue == null)
                {
                    MessageBox.Show("Ingrese la Observación.", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtObservacion.Focus();
                    return false;
                }

                valorIngresos = 0;
                ValorFacturas = 0;

                foreach (var item in list_Aprob)
                {
                    if (item.Checked == true)
                    {
                        contRegis = contRegis + 1;
                        valorIngresos = valorIngresos +item.Total;
                    }
                }

                if (contRegis == 0)
                {
                    MessageBox.Show("Seleccione por lo menos un Item de los O.C. por Ingresos a Bodega.", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    return false;
                }
                contRegis = 0;
                foreach (var item in lstPendiFact)
                {
                    if (item.Checked == true)
                    {
                        contRegis = contRegis + 1;
                        ValorFacturas = ValorFacturas + item.co_total;
                    }
                }
                if (contRegis != 1)
                {
                    MessageBox.Show("Seleccion una Factura para poder Conciliar.", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(dtpFechaConciliacion.Value)))
                    return false;
               
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        Boolean GuardarConciliacion()
        {
            try
            {
                Boolean bolResult = false;
                decimal IdConciliacion = 0;
                decimal IdIdAprobacion = 0;
                string msjError = "";
                if (ValidarDatos())
                { valorIngresos = Math.Round(valorIngresos,2, MidpointRounding.AwayFromZero);
                    if(valorIngresos != ValorFacturas)
                    {
                        if (MessageBox.Show("El valor de los ingresos es ["+valorIngresos+"] \nEl valor de la factura es ["+ValorFacturas+"] \n¿Desea continuar?" , "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return false;
                        }
                    }

                    get_Info();

                    if (busConciliacion.GuardarDB(Info_Ing_Bod, ref IdConciliacion, ref IdIdAprobacion, ref msjError))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Conciliación ", IdConciliacion);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdConciliacion.EditValue = IdConciliacion;
                        LimpiarDatos();

                    }
                    else
                    {
                        MessageBox.Show(msjError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        void LimpiarDatos()
        {
            try
            {
                Info_Ing_Bod = new cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;

                
                txtIdConciliacion.EditValue = null;
                
                cmbProveedor.Inicializar_cmbProveedor();
                txtObservacion.EditValue = "";

                lstPendiFact = new BindingList<vwcp_Orden_Giro_Pendiente_Conciliar_Info>();
                gridFacturaProveedor.DataSource = lstPendiFact;
                list_Aprob = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
                gridIngresoBodega.DataSource = list_Aprob;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean AnularConciliacion()
        {
            try
            {
                Boolean bolResult = false;
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Buscar()
        {
            try
            {
                if (cmbProveedor.get_ProveedorInfo() == null)
                {
                    MessageBox.Show("Seleccione el Proveedor");
                    return;
                }
                get_OC_x_Ingreso_Bodega();
                get_OG_x_Factura();
                Calcular_factura();
                Calcular_ingresos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void get_OC_x_Ingreso_Bodega()
        {
            try
            {

                list_Aprob = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>(Bus_Aprob.Get_List_Aprobacion_Ing_Bod_x_OC_det_x_Proveedor(param.IdEmpresa, cmbProveedor.get_ProveedorInfo().IdProveedor));              

              if (list_Aprob.Count==0)
              {
                  MessageBox.Show("No existen Datos de Consulta para el Proveedor: " + cmbProveedor.get_ProveedorInfo().pr_nombre);
                  return;
              }
              
              foreach (var item in list_Aprob)
              {
                  //calculos
                  if (item.do_porc_des != 0)
                  {
                      /*
                      item.Descuento = (item.Cantidad * item.Costo_uni) * (item.do_porc_des / 100);
                      item.SubTotal = (item.Cantidad * item.Costo_uni) - item.Descuento;
                       * */
                      item.SubTotal = (item.Cantidad * item.Costo_uni);
                  }
                  else
                  {
                      item.SubTotal = (item.Cantidad * item.Costo_uni);
                  }

                  if (item.PorIva>0)
                  {

                      item.valor_Iva = item.SubTotal * (item.PorIva / 100);
                      item.subtotaliva = item.SubTotal + item.valor_Iva;
                  }
                  else
                  {
                      item.PorIva = 0;
                      item.valor_Iva = 0;
                      item.subtotal0 = item.SubTotal;
                  }
                  item.Total = item.SubTotal + item.valor_Iva;                                
              }       
       
              gridIngresoBodega.DataSource = list_Aprob;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void get_OG_x_Factura()
        {
            try
            {
                lstPendiFact = new BindingList<vwcp_Orden_Giro_Pendiente_Conciliar_Info>(busConciliacion.Get_List_OG_Pendiente_Conciliar(param.IdEmpresa, cmbProveedor.get_ProveedorInfo().IdProveedor));
                gridFacturaProveedor.DataSource = lstPendiFact;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewFacturaProveedor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                e.HitInfo.Column.FieldName = gridViewFacturaProveedor.FocusedColumn.FieldName;
                if (e.HitInfo.Column.FieldName == "Checked")
                {
                    if ((bool)gridViewFacturaProveedor.GetFocusedRowCellValue(col_Checked_fac))
                    {
                        gridViewFacturaProveedor.SetFocusedRowCellValue(col_Checked_fac, false);
                        get_OG_x_Factura();
                    }

                    else
                    {
                        checkTodosFalse();
                        gridViewFacturaProveedor.SetFocusedRowCellValue(col_Checked_fac, true);
                      
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void checkTodosFalse()
        {
            try
            {
                foreach (var item in lstPendiFact)
                {
                    item.Checked = false;
                }
                gridFacturaProveedor.RefreshDataSource();
                gridFacturaProveedor.DataSource = lstPendiFact;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProveedor_event_cmb_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewIngresoBodega_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_Checked_ing)
                {
                    Calcular_ingresos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewFacturaProveedor_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_Checked_fac)
                {
                    Calcular_factura();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Calcular_factura()
        {
            try
            {
                double total = 0;
                foreach (var item in lstPendiFact)
                {
                    if (item.Checked)
                    {
                        total += item.co_total;
                    }
                }
                txt_total_factura.Text = total.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Calcular_ingresos()
        {
            try
            {
                double total = 0;
                foreach (var item in list_Aprob)
                {
                    if (item.Checked)
                    {
                        total += item.Total;
                    }
                }
                txt_total_ingresos.Text = total.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewIngresoBodega_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_Checked_ing)
                {
                    gridViewIngresoBodega.SetRowCellValue(e.RowHandle, col_Checked_ing, e.Value);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewFacturaProveedor_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_Checked_fac)
                {
                    gridViewFacturaProveedor.SetRowCellValue(e.RowHandle, col_Checked_fac, e.Value);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}