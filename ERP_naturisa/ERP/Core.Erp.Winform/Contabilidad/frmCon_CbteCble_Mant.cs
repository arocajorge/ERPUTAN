using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.Importacion;

using Core.Erp.Winform.General;


using Core.Erp.Reportes.Contabilidad;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Cus.Erp.Reports.Naturisa.Contabilidad;
using System.IO;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_CbteCble_Mant : Form
    {

        string MensajeError = "";

        #region 'Declaracion Generales param '


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public delegate void delegate_frmCon_CbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_CbteCble_Mant_FormClosing event_frmCon_CbteCble_Mant_FormClosing;

        Cl_Enumeradores.eTipo_action _Accion;


        public Cl_MotivoAnulacion Cl_Motivo = new Cl_MotivoAnulacion();

        #endregion

        #region Declaración de Info, Bus y Listas

        ct_Cbtecble_Bus BusCbteCble = new ct_Cbtecble_Bus();
        ct_Cbtecble_Info InfoCbteCble = new ct_Cbtecble_Info();

        ct_Cbtecble_tipo_Bus cbtipobus = new ct_Cbtecble_tipo_Bus();
        List<ct_Cbtecble_tipo_Info> List_Tipo_Comprobante = new List<ct_Cbtecble_tipo_Info>();
       
        ct_Periodo_Bus BusPeriodo = new ct_Periodo_Bus();
        ct_Periodo_Info InfoPeriodo = new ct_Periodo_Info();

       

        #endregion
        
        void inhabilitar()
        {
            try
            {
                btn_bucarPLantilla.Enabled = false;
                txt_codCbteCble.Enabled = false; txt_codCbteCble.ForeColor = Color.Black;
                txt_concepto.Enabled = false; txt_concepto.ForeColor = Color.Black;
                cmb_tipocomprobante.Enabled = false; cmb_tipocomprobante.ForeColor = Color.Black;
                dtFecha.Enabled = false; dtFecha.ForeColor = Color.Black;
                UC_Diario.setAccion(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        
        }

        private void set_Accion_x_Controles()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        UC_Diario.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        this.Text = this.Text + "***Actualizar***";
                        ucGe_Menu.Visible_bntImprimir = true;
                        this.Text = this.Text + "***Guardar***";
                        cmb_tipocomprobante.Enabled = false; cmb_tipocomprobante.ForeColor = Color.Black;
                        ucGe_Menu.Visible_bntAnular = false;
                        UC_Diario.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                        set_Info_en_Controles();
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.Text = this.Text + "***Anular***";
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        inhabilitar();
                        UC_Diario.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                        set_Info_en_Controles();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.Text = this.Text + "***Consulta***";
                        inhabilitar();
                        UC_Diario.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                        set_Info_en_Controles();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                
                
            }

        }

        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        public frmCon_CbteCble_Mant()
        {
            try
            {
                InitializeComponent();
                
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmCon_CbteCble_Mant_FormClosing += frmCon_CbteCble_Mant_event_frmCon_CbteCble_Mant_FormClosing;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LImpiarDatos();
                setAccion(Cl_Enumeradores.eTipo_action.grabar);
                set_Accion_x_Controles();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmCon_CbteCble_Mant_event_frmCon_CbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                int IdEmpresa = 0;
                int IdTipoCbte = 0;
                decimal IdCbteCble = 0;

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        XCONTA_NATU_Rpt002_Rpt reporte_personalizado = new XCONTA_NATU_Rpt002_Rpt();

                        IdEmpresa = param.IdEmpresa;
                        IdTipoCbte = Convert.ToInt32(cmb_tipocomprobante.EditValue);
                        IdCbteCble = Convert.ToDecimal(lbl_no_comprobante.Text);

                        reporte_personalizado.PIdEmpresa.Value = param.IdEmpresa;
                        reporte_personalizado.PIdTipoCbte.Value = IdTipoCbte;
                        reporte_personalizado.PIdCbteCble.Value = IdCbteCble;
                        reporte_personalizado.RequestParameters = false;
                        reporte_personalizado.PIdEmpresa.Visible = false;
                        reporte_personalizado.PIdTipoCbte.Visible = false;
                        reporte_personalizado.PIdCbteCble.Visible = false;
                        reporte_personalizado.ShowPreviewDialog();
                        break;
                    default:
                        XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();

                        IdEmpresa = param.IdEmpresa;
                        IdTipoCbte = Convert.ToInt32(cmb_tipocomprobante.EditValue);
                        IdCbteCble = Convert.ToDecimal(lbl_no_comprobante.Text);

                        reporte.set_parametros(IdEmpresa, IdTipoCbte, IdCbteCble);
                        reporte.RequestParameters = false;
                        reporte.ShowPreviewDialog();
                        break;
                }




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

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    LImpiarDatos();
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
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
                ct_Cbtecble_tipo_Bus tipo_bus = new ct_Cbtecble_tipo_Bus();
                if (!tipo_bus.Get_Es_Interno(param.IdEmpresa, InfoCbteCble.IdTipoCbte, ref MensajeError))
                {
                    MessageBox.Show("Este comprobante no se puede eliminar, debido que es generado de otro modulo");
                    return;
                }
                if (InfoCbteCble.Estado != "A")
                {
                    MessageBox.Show("No se pudo anular el Comprobante Contable: " + InfoCbteCble.IdCbteCble.ToString() + " debido a que ya se encuentra anulado", "Anulación de Cbte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("¿Está seguro que desea anular dicho comprobante contable?", "Anulación de Cbte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (InfoCbteCble.Mayorizado == "S")
                    {
                        MessageBox.Show("No se puede anular el Comprobante Contable porque ya se encuentra Mayorizado, deberia reversar la mayorización para poder efectuar dicha anulación", "Anulación de Cbte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    

                    if (BusPeriodo.Get_Periodo_Esta_Cerrado(InfoCbteCble.IdEmpresa, InfoCbteCble.cb_Fecha, ref MensajeError) == true)
                    {
                        MessageBox.Show("No se puede anular el Comprobante Contable porque el período se encuentra cerrado", "Anulación de Cbte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    FrmGe_MotivoAnulacion frmAnul = new FrmGe_MotivoAnulacion();
                    frmAnul.ShowDialog();
                    InfoCbteCble.IdUsuarioAnu = param.IdUsuario;
                    InfoCbteCble.cb_FechaAnu = param.Fecha_Transac;
                    InfoCbteCble.cb_MotivoAnu = frmAnul.motivoAnulacion;

                    
                    ct_Cbtecble_tipo_Info tipoComp = List_Tipo_Comprobante.First(q => q.IdTipoCbte == (Convert.ToInt32(cmb_tipocomprobante.EditValue)));
                    decimal IdCbteCntablerev = 0;
                    string msj = "";

                    if (BusCbteCble.ReversoCbteCble(param.IdEmpresa, Convert.ToDecimal(lbl_no_comprobante.Text), (int)cmb_tipocomprobante.EditValue,
                        Convert.ToInt16(tipoComp.IdTipoCbte_Anul), ref IdCbteCntablerev, ref msj, param.IdUsuario, Cl_Motivo.motivo_anulacion))
                    {
                        // se procede actualizar los campos 
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "Comprobante Contable: ", InfoCbteCble.IdCbteCble.ToString());
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        set_Info_en_Controles(); 

                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular el Comprobante Contable: " + InfoCbteCble.IdCbteCble.ToString(), "Anulación de Cbte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UC_Diario_event_btnImprimir_Click(object sender, EventArgs e)
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

        public ct_Cbtecble_Info get_CbteCbleInfo()
        {
            InfoCbteCble = new ct_Cbtecble_Info();
            try
            {

                string codigo;
                string MensajeError = "";
                InfoPeriodo = BusPeriodo.Get_Info_Periodo(param.IdEmpresa, dtFecha.Value, ref MensajeError);

                if (InfoPeriodo != null && InfoPeriodo.pe_cerrado != "S")
                {
                    InfoCbteCble.IdEmpresa = param.IdEmpresa;
                    InfoCbteCble.IdUsuario = param.IdUsuario;
                    codigo = cbtipobus.Get_Codigo_x_CbtCble_tipo(param.IdEmpresa,Convert.ToInt32(this.cmb_tipocomprobante.EditValue), ref MensajeError).Trim();
                    InfoCbteCble.IdPeriodo = InfoPeriodo.IdPeriodo;
                    InfoCbteCble.Anio = InfoPeriodo.IdanioFiscal;
                    InfoCbteCble.Mes = InfoPeriodo.pe_mes;
                    InfoCbteCble.IdTipoCbte = Convert.ToInt32(this.cmb_tipocomprobante.EditValue);
                    InfoCbteCble.CodCbteCble = txt_codCbteCble.Text;
                    InfoCbteCble.cb_Fecha = Convert.ToDateTime(this.dtFecha.Value.ToShortDateString());
                    InfoCbteCble.cb_FechaTransac = param.GetDateServer();
                    InfoCbteCble.Mayorizado = "N";
                    InfoCbteCble.cb_Observacion = this.txt_concepto.Text;
                    InfoCbteCble.Secuencia = BusCbteCble.Get_IdSecuencia(ref MensajeError);
                    InfoCbteCble.Estado = "A";

                    InfoCbteCble._cbteCble_det_lista_info = UC_Diario.Get_List_Cbtecble_det();

                    return InfoCbteCble;
                }
                else
                {
                    MessageBox.Show("El periodo de la fecha está cerrado.. No podrá grabar..");
                    InfoCbteCble = new ct_Cbtecble_Info();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InfoCbteCble = new ct_Cbtecble_Info();
            }
            return InfoCbteCble;
        }

        public void CargarCombos()
        {
            try
            {
                ct_Cbtecble_tipo_Bus _CbteCbleTipo_bus = new ct_Cbtecble_tipo_Bus();
                List_Tipo_Comprobante = _CbteCbleTipo_bus.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);
                List_Tipo_Comprobante.ForEach(var => var.tc_TipoCbte = "[" + var.CodTipoCbte + "]- " + var.tc_TipoCbte + " -[" + var.IdTipoCbte + "]");
                this.cmb_tipocomprobante.Properties.DataSource = List_Tipo_Comprobante;
                this.cmb_tipocomprobante.EditValue = List_Tipo_Comprobante.First().IdTipoCbte;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean Accion_Grabar()
        {
            Boolean res = false;
            try
            {
                txt_concepto.Focus();

                
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res = Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res = Actualizar();
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }

        private Boolean Validar()
        {
            try
            {
                Boolean respuesta = true;

                InfoPeriodo = BusPeriodo.Get_Info_Periodo(param.IdEmpresa, dtFecha.Value, ref MensajeError);
                if (InfoPeriodo == null || InfoPeriodo.pe_cerrado == "S")
                {
                    MessageBox.Show("No se puede grabar el comprobante contable debido a que el periodo se encuentra cerrado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    respuesta= false;
                }

                if (cmb_tipocomprobante.EditValue == null || cmb_tipocomprobante.EditValue == "")
                {
                    MessageBox.Show("Debe Seleecionar un Tipo de Comprobante ",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    respuesta = false;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa,Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(dtFecha.Value)))
                    return false;

                return respuesta;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
        
        private Boolean  Guardar()
        {
            Boolean res = false;
            try
            {
                string codContable2 = "";

                res=Validar();

                if (res)
                {

                    get_CbteCbleInfo();


                    codContable2 = txt_codCbteCble.Text;
                    double valorCbteCble = 0;
                    valorCbteCble = UC_Diario.Get_ValorCbteCble();

                    decimal IdCbteCntable = 0;
                    string msg = "";

                    res = BusCbteCble.GrabarDB(InfoCbteCble, ref IdCbteCntable, ref msg);
                    if (res)
                    {
                        set_Info_en_Controles();
                        lbl_no_comprobante.Text = IdCbteCntable.ToString();
                        txt_codCbteCble.Text = (txt_codCbteCble.Text == "") ? InfoCbteCble.CodCbteCble : txt_codCbteCble.Text;
                        MessageBox.Show("Grabado Comprobante Ok");

                        if (MessageBox.Show("¿Desear Imprimir el Comprobante..?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            ucGe_Menu_event_btnImprimir_Click(new object(), new EventArgs());
                        }


                    }
                    else { MessageBox.Show(msg); }

                }
                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }

        private Boolean Actualizar()
        {
            Boolean res = false;
            try
            {
                string msj = "";


                res=Validar();

                if (res)
                {

                    ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();

                    get_CbteCbleInfo();

                    InfoCbteCble.IdCbteCble = Convert.ToDecimal(lbl_no_comprobante.Text);
                    res = bus.ModificarDB(InfoCbteCble, ref msj);
                    if (res)
                    {
                        MessageBox.Show("Se actualizo el Comprobante Contable #: " + InfoCbteCble.IdCbteCble.ToString() + " con éxito");

                        this.dtFecha.Enabled = false;
                        this.txt_codCbteCble.Enabled = false;
                        ucGe_Menu.Enabled_bntImprimir = true;
                        this.cmb_tipocomprobante.Enabled = false;

                        if (MessageBox.Show("¿Desear Imprimir el Comprobante..?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            ucGe_Menu_event_btnImprimir_Click(new object(), new EventArgs());
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el Comprobante Contable. " + msj);
                    }

                }

                return res;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            return res;
        }

        private void LImpiarDatos()
        {
            try
            {
                
                InfoCbteCble =  new ct_Cbtecble_Info();
                 this.cmb_tipocomprobante.EditValue = "";
                lbl_no_comprobante.Text = "";
                txt_codCbteCble.Text = "";
                this.txt_concepto.Text = "";
                UC_Diario.LimpiarGrid();
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ct_Cbtecble_Info Get_Info_FormClosing()
        {
            try
            {
                return InfoCbteCble;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void set_Info(ct_Cbtecble_Info _Info)
        {
            try
            {
                InfoCbteCble = _Info;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void set_Info_en_Controles()
        {
            try
            {
                if (InfoCbteCble != null)
                {
                    if (InfoCbteCble.IdCbteCble != 0)
                    {
                        ct_Cbtecble_det_Bus _CbteCbleBus = new ct_Cbtecble_det_Bus();
                        List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                        lbl_no_comprobante.Text = InfoCbteCble.IdCbteCble.ToString();
                        txt_codCbteCble.Text = InfoCbteCble.CodCbteCble.ToString();
                        cmb_tipocomprobante.EditValue = InfoCbteCble.IdTipoCbte;

                        ct_Cbtecble_tipo_Info a = List_Tipo_Comprobante.FirstOrDefault(q => q.IdTipoCbte == InfoCbteCble.IdTipoCbte);

                        dtFecha.Value = InfoCbteCble.cb_Fecha;
                        txt_concepto.Text = InfoCbteCble.cb_Observacion;
                        UC_Diario.setInfo(param.IdEmpresa, InfoCbteCble.IdTipoCbte, InfoCbteCble.IdCbteCble);
                        ct_cbtecble_Reversado_Bus BusReverso = new ct_cbtecble_Reversado_Bus();
                        var DiarioReverso = BusReverso.Get_Info_cbtecble_Reversado(param.IdEmpresa, InfoCbteCble.IdTipoCbte, InfoCbteCble.IdCbteCble);
                        if (DiarioReverso.IdCbteCble_Anu != 0)
                        {
                            lblEstado.Text = "Reversado Con el Diario # " + DiarioReverso.IdCbteCble_Anu.ToString();
                            lblEstado.Visible = true;
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

        private void cmb_tipocomprobante_SelectionChanged(object sender, EventArgs e)
        {
            ct_Cbtecble_tipo_Bus _CbteCbleTipo_bus = new ct_Cbtecble_tipo_Bus();
            try
            {
                if (_Accion != Cl_Enumeradores.eTipo_action.consultar)
                {
                    // verifica si el tipo de comprobante es interno o no
                    if (!_CbteCbleTipo_bus.Get_Es_Interno(param.IdEmpresa,Convert.ToInt32(this.cmb_tipocomprobante.EditValue), ref MensajeError)) 
                    {
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                    }
                    else
                    {
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void btn_bucarPLantilla_Click(object sender, EventArgs e)
        {
            try
            {
                ct_cbtecble_Plantilla_Info InfoPlan = new ct_cbtecble_Plantilla_Info();

                if (txt_no_plantillacomprobante.Text == "0" || txt_no_plantillacomprobante.Text == "")
                {
                    frmCon_cbtecble_Plantilla_Consulta frm = new frmCon_cbtecble_Plantilla_Consulta();
                    frm.LlamaOtraPantalla = true;
                    frm.ShowDialog();
                    InfoCbteCble = frm.Get_Info_CbteCble();
                    
                }
                else
                {
                    ct_cbtecble_Plantilla_Bus Pla_B = new ct_cbtecble_Plantilla_Bus();
                    InfoCbteCble = Pla_B.Get_Info_Plantilla_CbteCble(param.IdEmpresa, Convert.ToInt32(this.cmb_tipocomprobante.EditValue), Convert.ToDecimal(txt_no_plantillacomprobante.Text));
                }



                if (InfoCbteCble != null)
                {
                    if (InfoCbteCble.cb_Fecha != new DateTime(1, 1, 1))
                    {
                        List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                        lm = InfoCbteCble._cbteCble_det_lista_info;
                        this.cmb_tipocomprobante.EditValue = InfoCbteCble.IdTipoCbte;
                        dtFecha.Value = InfoCbteCble.cb_Fecha;
                        txt_concepto.Text = InfoCbteCble.cb_Observacion;
                        UC_Diario.setDetalle(lm);
                    }
                    else
                    {
                        MessageBox.Show("Usted ha seleccionado mas de una plantilla, por favor intente de nuevo.",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        LImpiarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_no_plantillacomprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '\r')
                {
                    btn_bucarPLantilla_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_tipocomprobante_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion==Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (cmb_tipocomprobante.EditValue != null)
                    {
                        if (cmb_tipocomprobante.EditValue != "")
                        {

                            ct_Cbtecble_tipo_Info Tipos = List_Tipo_Comprobante.Find(v => v.IdTipoCbte == Convert.ToInt32(cmb_tipocomprobante.EditValue));
                            if (Tipos.tc_Interno == "N")
                            {
                                ucGe_Menu.Visible_btnGuardar = false;
                                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            }
                            else if (Tipos.tc_Interno == "S")
                            {
                                ucGe_Menu.Visible_btnGuardar = true;
                                ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            }
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

        private void frmCon_CbteCble_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }

                CargarCombos();
                set_Accion_x_Controles();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_CbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCon_CbteCble_Mant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_descargar_excel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string filePath = null;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_diario);
                    MessageBox.Show("Archivo descargado con exito.\r\n\r\n" + filePath, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
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