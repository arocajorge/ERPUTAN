using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Business.General;
//ultima version 24 junio 2013

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_cbtecble_Plantilla : Form
    {
        #region Declaración de Variables

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Cl_Enumeradores.eTipo_action _Accion;
        public ct_cbtecble_Plantilla_Info Info_Plantilla = new ct_cbtecble_Plantilla_Info();

        List<ct_cbtecble_Plantilla_det_Info> ListDetalle = new List<ct_cbtecble_Plantilla_det_Info>();
        
        ct_Plancta_Bus BusPlanCta = new ct_Plancta_Bus();
        
        List<ct_Plancta_Info> listPlanCuenta = new List<ct_Plancta_Info>();
        ct_Centro_costo_Bus BusCentroCosto = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> listCentroCosto = new List<ct_Centro_costo_Info>();
        List<ct_Cbtecble_tipo_Info> List_Tipo_Comprobante = new List<ct_Cbtecble_tipo_Info>();
        

        ct_centro_costo_sub_centro_costo_Bus BusSubCentro = new ct_centro_costo_sub_centro_costo_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> listSubCentro = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_cbtecble_Plantilla_det_Bus _CbteCble_Plantilla_Bus = new ct_cbtecble_Plantilla_det_Bus();
        ct_cbtecble_Plantilla_Bus Pla_B = new ct_cbtecble_Plantilla_Bus();


        string MensajeError = "";
        decimal IdPlantilla;

        public delegate void delegate_frmCon_cbtecble_Plantilla_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_cbtecble_Plantilla_FormClosing event_frmCon_cbtecble_Plantilla_FormClosing;

        
        #endregion

        public frmCon_cbtecble_Plantilla()
        {
            try
            {
                InitializeComponent();
                event_frmCon_cbtecble_Plantilla_FormClosing += frmCon_cbtecble_Plantilla_event_frmCon_cbtecble_Plantilla_FormClosing;

                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }
                
                CargarCombos();           
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void frmCon_cbtecble_Plantilla_event_frmCon_cbtecble_Plantilla_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public void CargarCombos()
        {
            try
            {
                ct_Cbtecble_tipo_Bus _CbteCbleTipo_bus = new ct_Cbtecble_tipo_Bus();
                var TiposComprobantes = _CbteCbleTipo_bus.Get_list_Cbtecble_tipo(param.IdEmpresa, Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);
                TiposComprobantes.ForEach(var => var.tc_TipoCbte = "[" + var.CodTipoCbte + "]- " + var.tc_TipoCbte + " -[" + var.IdTipoCbte + "]");

                cmbTipoCbte.Properties.DataSource = TiposComprobantes;
                cmbTipoCbte.Properties.DisplayMember = "tc_TipoCbte";
                cmbTipoCbte.Properties.ValueMember = "IdTipoCbte";
                cmbTipoCbte.EditValue = TiposComprobantes.First().IdTipoCbte;

                //listPlanCuenta = BusPlanCta.Get_Cuentas_de_Movimiento(param.IdEmpresa, ref MensajeError);
                //cmb_planCta.DataSource = listPlanCuenta;
                //cmb_planCta.DisplayMember = "pc_Cuenta2";
                //cmb_planCta.ValueMember = "IdCtaCble";

                //listCentroCosto = BusCentroCosto.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);
                //cmbcentrocosto.DataSource = listCentroCosto;
                //cmbcentrocosto.DisplayMember = "Centro_costo";
                //cmbcentrocosto.ValueMember = "IdCentroCosto";


                //ct_Cbtecble_tipo_Bus _CbteCbleTipo_bus = new ct_Cbtecble_tipo_Bus();
                //List_Tipo_Comprobante = _CbteCbleTipo_bus.Get_list_Cbtecble_tipo(param.IdEmpresa, Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);
                //List_Tipo_Comprobante.ForEach(var => var.tc_TipoCbte = "[" + var.CodTipoCbte + "]- " + var.tc_TipoCbte + " -[" + var.IdTipoCbte + "]");
                //this.cmb_tipocomprobante.Properties.DataSource = List_Tipo_Comprobante;
                //this.cmb_tipocomprobante.EditValue = List_Tipo_Comprobante.First().IdTipoCbte;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        private void setAccion()
        {
            try
            {
                

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        CargarCombos();
                        //gridControlDiario.DataSource = BingListDetalle;
                        //lbl_no_comprobante.Text = Pla_B.Get_Info_Plantilla(param.IdEmpresa).ToString();
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_CbteCbleInfo();
                        ucGe_Menu.Visible_bntAnular = false;
                        cmbTipoCbte.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        set_CbteCbleInfo();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        set_CbteCbleInfo();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        Boolean Accion_Boton()
        {
            try
            {
                Boolean bolResult = true;
                lbl_no_comprobante.Focus();
                GetInfo();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        bolResult = Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        bolResult = Actualizar();
                        break;

                    default:
                        break;
                }

                return bolResult;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean Grabar()
        {
            try
            {
                Boolean bolResult = false;
                string msj = "";
                IdPlantilla = Convert.ToDecimal(lbl_no_comprobante.Text);

                bolResult=Pla_B.GrabarDB(Info_Plantilla, ref IdPlantilla, ref msj);
                if (bolResult)
                {
                    lblAnulado.Visible = false;
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Plantilla ", IdPlantilla);
                    MessageBox.Show(smensaje, param.Nombre_sistema);                    
                    LimpiarDatos();
                    bolResult = true;
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return bolResult;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        Boolean Actualizar()
        {
            try
            {
                Boolean bolResult = false;
                Info_Plantilla.cb_FechaUltModi = DateTime.Now;
                Info_Plantilla.IdUsuarioUltModi = param.IdUsuario;

                bolResult=Pla_B.ModificarDB(Info_Plantilla);

                if (bolResult)
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Plantilla", Info_Plantilla.IdPlantilla);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    bolResult = true;
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        void Anular()
        {
            try
            {
                if (Info_Plantilla.IdPlantilla != 0)
                {
                    if (lblAnulado.Visible == true)
                    {
                        MessageBox.Show("El registro ya se encuentra Anulado");
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular La plantilla #: " + Info_Plantilla.IdPlantilla + " ?", "Anulación de Plantilla ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                            ofrm.ShowDialog();

                            Info_Plantilla.IdUsuarioAnu = param.IdUsuario;
                            Info_Plantilla.cb_FechaAnu = DateTime.Now;
                            Info_Plantilla.cb_MotivoAnu = ofrm.motivoAnulacion;

                            if (Info_Plantilla.cb_Estado == "A")
                            {
                                if (Pla_B.EliminarDB(Info_Plantilla))
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Plantilla", Info_Plantilla.IdPlantilla);
                                    MessageBox.Show(smensaje, param.Nombre_sistema);
                                    ucGe_Menu.Visible_bntAnular = false;
                                    lblAnulado.Visible = true;
                                }
                                else
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo anular la Plantilla:  " + Info_Plantilla.IdPlantilla + " debido a que ya se encuentra anulada", "Anulación de Plantilla ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Por favor, seleccione un item a anular", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void set_CbteCbleInfo()
        {
            try
            {
                if (Info_Plantilla.IdPlantilla != 0)
                {
                    List<ct_Cbtecble_det_Info> List_Diario = new List<ct_Cbtecble_det_Info>();
                    lbl_no_comprobante.Text = Info_Plantilla.IdPlantilla.ToString();
                    cmbTipoCbte.EditValue = Info_Plantilla.IdTipoCbte;
                    dtFecha.Value = Convert.ToDateTime(Info_Plantilla.cb_Fecha.ToShortDateString());
                    txt_concepto.Text = Info_Plantilla.cb_Observacion;
                    lblAnulado.Visible = (Info_Plantilla.cb_Estado == "I") ? true : false;
                    ListDetalle = _CbteCble_Plantilla_Bus.Get_list_Cbtecble_det(Info_Plantilla.IdEmpresa, Info_Plantilla.IdTipoCbte, Info_Plantilla.IdPlantilla);
                    foreach (var item in ListDetalle)
                    {
                        ct_Cbtecble_det_Info Info_diario = new ct_Cbtecble_det_Info();
                        Info_diario.IdEmpresa = item.IdEmpresa;
                        Info_diario.IdTipoCbte = item.IdTipoCbte;
                        Info_diario.IdCtaCble = item.IdCtaCble;
                        Info_diario.IdCentroCosto = item.IdCentroCosto;
                        Info_diario.dc_Valor = item.dc_Valor;
                        Info_diario.dc_Observacion = item.dc_Observacion;
                        Info_diario.dc_Valor_D = item.Debe_Aux;
                        Info_diario.dc_Valor_H = item.Haber_Aux;
                        Info_diario.IdPunto_cargo = item.IdPunto_cargo;
                        Info_diario.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;

                        List_Diario.Add(Info_diario);
                    }
                    
                    uc_GridDiarioContable.setDetalle(List_Diario);
                    //gridControlDiario.DataSource = BingListDetalle;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmCon_cbtecble_Plantilla_Load(object sender, EventArgs e)
        {
            try
            {
                    this.event_frmCon_cbtecble_Plantilla_FormClosing += new delegate_frmCon_cbtecble_Plantilla_FormClosing(frmCon_cbtecble_Plantilla_event_frmCon_cbtecble_Plantilla);                    
                    setAccion();


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
          
        }

        void frmCon_cbtecble_Plantilla_event_frmCon_cbtecble_Plantilla(object sender, FormClosingEventArgs e)
        {
           
        }

        private void frmCon_cbtecble_Plantilla_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              this.event_frmCon_cbtecble_Plantilla_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
      
        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Boton())
                {
                    LimpiarDatos();
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Boton())
                    Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        //private void gridViewDiario_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    try
        //    {
        //        ct_cbtecble_Plantilla_det_Info row = new ct_cbtecble_Plantilla_det_Info();

        //        row = (ct_cbtecble_Plantilla_det_Info)gridViewDiario.GetFocusedRow();
        //        if (row != null)
        //        {
        //            if (e.Column == colDebe)
        //            {
        //                decimal valor = 0;
        //                valor = Math.Abs(Convert.ToDecimal(e.Value));
        //                if (Convert.ToDecimal(e.Value) < 0) gridViewDiario.SetFocusedRowCellValue(colDebe, valor);
        //                if (valor > 0)
        //                {
        //                    gridViewDiario.SetFocusedRowCellValue(colHaber, 0);
        //                }
        //            }
        //            else if (e.Column == colHaber)
        //            {
        //                decimal valor = 0;
        //                valor = Math.Abs(Convert.ToDecimal(e.Value));
        //                if (Convert.ToDecimal(e.Value) < 0) gridViewDiario.SetFocusedRowCellValue(colHaber, valor);
        //                if (valor > 0) { gridViewDiario.SetFocusedRowCellValue(colDebe, 0); }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}
       
        public void GetInfo()
        {
            try
            {
                int IdSecuencia = 0;
                //List_Diario = uc_GridDiarioContable.Get_Obtener_ct_Cbtecble_det();
                ListDetalle = new List<ct_cbtecble_Plantilla_det_Info>();
                List<ct_Cbtecble_det_Info> list_detalle= new List<ct_Cbtecble_det_Info>();
                 List<ct_Cbtecble_det_Info> lista= new List<ct_Cbtecble_det_Info>();
                lista=uc_GridDiarioContable.Get_List_Cbtecble_det();
                list_detalle = lista.Where(q=>q.IdCtaCble!=null).ToList();


                foreach (var item in list_detalle)
                {
                    ct_cbtecble_Plantilla_det_Info Detalle_Plantilla= new ct_cbtecble_Plantilla_det_Info();
                    IdSecuencia++;
                    Detalle_Plantilla.IdEmpresa = item.IdEmpresa;
                    Detalle_Plantilla.IdTipoCbte = item.IdTipoCbte;
                    Detalle_Plantilla.secuencia = IdSecuencia;
                    Detalle_Plantilla.IdCtaCble = item.IdCtaCble;
                    Detalle_Plantilla.IdCentroCosto = item.IdCentroCosto;
                    Detalle_Plantilla.dc_Valor = item.dc_Valor;
                    Detalle_Plantilla.dc_Observacion = item.dc_Observacion;
                    Detalle_Plantilla.Debe_Aux = item.dc_Valor_D;
                    Detalle_Plantilla.Haber_Aux = item.dc_Valor_H;
                    Detalle_Plantilla.IdPunto_cargo = (item.IdPunto_cargo == 0) ? null : item.IdPunto_cargo;
                    Detalle_Plantilla.IdPunto_cargo_grupo = (item.IdPunto_cargo_grupo == 0) ? null : item.IdPunto_cargo_grupo;

                    ListDetalle.Add(Detalle_Plantilla);
                }

                Info_Plantilla.LstDet = ListDetalle;
                Info_Plantilla.IdTipoCbte = Convert.ToInt32(cmbTipoCbte.EditValue); //((ct_Cbtecble_tipo_Info)cmbTipoCbte.EditValue).IdTipoCbte;
                Info_Plantilla.IdPlantilla = Convert.ToInt32(lbl_no_comprobante.Text);
                Info_Plantilla.cb_Fecha = Convert.ToDateTime(dtFecha.Value.ToShortDateString());  
                Info_Plantilla.cb_Observacion = txt_concepto.Text;
                Info_Plantilla.IdUsuario = param.IdUsuario;
                Info_Plantilla.IdUsuarioAnu = param.IdUsuario;
                Info_Plantilla.IdUsuarioUltModi = param.IdUsuario;
                Info_Plantilla.cb_FechaTransac = DateTime.Now;
                Info_Plantilla.cb_FechaAnu = DateTime.Now;
                Info_Plantilla.cb_FechaUltModi = DateTime.Now;
                Info_Plantilla.IdEmpresa = param.IdEmpresa;
                lblAnulado.Visible = (Info_Plantilla.cb_Estado == "A") ? false : true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }          
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Info_Plantilla = new ct_cbtecble_Plantilla_Info();
                ListDetalle = new List<ct_cbtecble_Plantilla_det_Info>();
                //gridControlDiario.DataSource = BingListDetalle;
                
                cmbTipoCbte.EditValue =  null; 
                lbl_no_comprobante.Text = "0";                
                txt_concepto.Text = "";
                dtFecha.Value = DateTime.Now;
                
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        //private void gridControlDiario_KeyDown(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        if (e.KeyValue.ToString() == "46")
        //        {
        //            if (MessageBox.Show("Está seguro que desea eliminar el registro", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                gridViewDiario.DeleteSelectedRows();
        //                gridControlDiario.RefreshDataSource();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}
    }
}
