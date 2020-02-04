using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion ;
using Core.Erp.Business.Facturacion;

namespace Core.Erp.Winform.General
{ 
    public partial class FrmGe_Secuencia_Documento_Talonario_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCIn_Sucursal_Bodega UCSucursal = new UCIn_Sucursal_Bodega();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        //fa_Secuencia_Documento_Talonario_Bus busTipoDoc = new fa_Secuencia_Documento_Talonario_Bus();

        
        
        
        tb_sis_Documento_Tipo_Talonario_Bus busTalonario = new tb_sis_Documento_Tipo_Talonario_Bus();
        public tb_sis_Documento_Tipo_Talonario_Info info;

        //public List<tb_sis_Documento_Tipo_Info> listaDocTalo = new List<tb_sis_Documento_Tipo_Info>();
        List<tb_sis_Documento_Tipo_Info> list_Docu_Tipo = new List<tb_sis_Documento_Tipo_Info>();
        tb_sis_Documento_Tipo_Bus Bus_Doc_Tipo = new tb_sis_Documento_Tipo_Bus();



        DataTable tablaTipoDoc = new DataTable();
        private Cl_Enumeradores.eTipo_action _Accion;
        public delegate void Delegate_frmFa_Secuencia_Documento_Talonario_Mant_FormClosing();
        public event Delegate_frmFa_Secuencia_Documento_Talonario_Mant_FormClosing event_frmFa_Secuencia_Documento_Talonario_Mant_FormClosing;
        int numDocActual = 0;

        #endregion

        public FrmGe_Secuencia_Documento_Talonario_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                if (guardarDatos())
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
                guardarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean guardarDatos()
        {
            try
            {
                Boolean bolResult = false;
                string msjRetorno = "";
                getTalonario();
                if (validar())
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (busTalonario.Modificar(info))
                        {
                            MessageBox.Show("Registro Actualizado Correctamente", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            bolResult = true;
                            LimpiarDatos();
                        }
                    }
                    else
                        if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                        {

                            if (busTalonario.grabar(info, Convert.ToInt32(txtGenerar.Text), ref msjRetorno))
                            {
                                MessageBox.Show(msjRetorno, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                                
                                bolResult = true;
                                LimpiarDatos();
                            }
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
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                info = new tb_sis_Documento_Tipo_Talonario_Info();
                
                ultraCmbE_TipoDoc.EditValue = null;
                txtEstablecimiento.Text = "";
                txtpuntoEmision.Text = "";
                txtnumeroDoc.Text = "";
                txtUltDoc.Text = string.Empty;
                txtGenerar.Text = string.Empty;
                txtDocFinal.Text = string.Empty;
                chkestado.Checked = true;
                txtNumeroAut.Text = "";
                chkelectronica.Checked = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getTalonario()
        {
            try
            {
                if (ultraCmbE_TipoDoc.EditValue != null)
                {
                    info = new tb_sis_Documento_Tipo_Talonario_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.CodDocumentoTipo = ultraCmbE_TipoDoc.EditValue.ToString();
                    info.Establecimiento = txtEstablecimiento.Text;
                    info.PuntoEmision = txtpuntoEmision.Text;
                    info.NumDocumento = txtnumeroDoc.Text;
                    info.FechaCaducidad = dtFechaCad.Value;
                    
                    if (chkestado.Checked)
                        info.Estado = "A";
                    else
                        info.Estado = "I";

                    if (chkUsado.Checked)
                        info.Usado = true;
                    else
                        info.Usado = false;


                    if (chkelectronica.Checked)
                        info.es_Documento_electronico = true;
                    else
                        info.es_Documento_electronico = false;

                    info.IdSucursal = param.IdSucursal;
                    info.NumAutorizacion = txtNumeroAut.Text;
                    string pE = "000000"+ info.PuntoEmision;
                    if (_Accion != Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (pE != txtUltDoc.Text)
                        {
                            info.NumDocumento = txtUltDoc.Text;
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

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void set_Controls()
        {
            try
            {
                ultraCmbE_TipoDoc.EditValue = info.CodDocumentoTipo;
                UCSucursal.cmb_sucursal.EditValue = info.IdSucursal;
                txtNumeroAut.Text = info.NumAutorizacion;
                txtEstablecimiento.Text = info.Establecimiento;
                txtnumeroDoc.Text = info.NumDocumento;
                dtFechaCad.Value = Convert.ToDateTime(info.FechaCaducidad);
                txtpuntoEmision.Text = info.PuntoEmision;
                chkestado.Checked = (info.Estado == "A") ? true : false;
                chkUsado.Checked = (info.Usado  == true  ) ? true : false;
                chkelectronica.Checked = (info.es_Documento_electronico == true) ? true : false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                ultraCmbE_TipoDoc.EditValue = "FAC";
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void cargar_combo_tipo_docu()
        {
            try
            {

                list_Docu_Tipo = Bus_Doc_Tipo.Get_List_Documento_Tipo_ApareceTalonario(param.IdEmpresa);
                this.ultraCmbE_TipoDoc.Properties.DataSource = list_Docu_Tipo;
                this.ultraCmbE_TipoDoc.Properties.DisplayMember = "descripcion";
                this.ultraCmbE_TipoDoc.Properties.ValueMember = "codDocumentoTipo";


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean validar()
        {
            try
            {
                if (txtpuntoEmision.Text == "" || txtpuntoEmision.Text == null) 
                {
                    MessageBox.Show("Ingrese el Punto de Emision", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txtEstablecimiento.Text == "" || txtEstablecimiento.Text == null)
                {
                    MessageBox.Show("Ingrese el Establecimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    if (Convert.ToInt32(txtGenerar.Text) <= 0 || txtGenerar.Text == null)
                    {
                        MessageBox.Show("La Cantidad a Generar Tiene que ser mayor a 1", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                if (chkUsado.Checked)
                {
                    if (MessageBox.Show("¿Está seguro que desea generar talonarios usados?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return false;
                    }
                }

                if (!chkestado.Checked)
                {
                    if (MessageBox.Show("¿Está seguro que desea generar talonarios anulados?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return false;
                    }
                }


                if (dtFechaCad.Value ==  null)
                {
                    MessageBox.Show("Ingrese la Fecha de Caducidad", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (!chkelectronica.Checked && txtNumeroAut.Text.Trim() == "")
                {
                    MessageBox.Show("Para los talonarios manuales, debe ingresar el número de autorización",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }


                if (ultraCmbE_TipoDoc.EditValue == null || ultraCmbE_TipoDoc.EditValue == "")
                {
                    MessageBox.Show("Ingrese el Tipo de Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false; ;
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

        private void ultraCmbE_TipoDoc_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmbE_TipoDoc.EditValue == null)
                {
                    ultraCmbE_TipoDoc.EditValue = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bloquear()
        {
            try
            {
                ucGe_Menu.Visible_btnGuardar = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGenerar_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((txtUltDoc.Text != "") && (txtGenerar.Text != ""))
                {
                    string final = Convert.ToString(Convert.ToDouble(txtUltDoc.Text) + Convert.ToDouble(txtGenerar.Text));
                    txtDocFinal.Text = final.PadLeft(9, '0');

                }
                else
                {
                    txtDocFinal.Text = "";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
       
        private void FrmGe_Secuencia_Documento_Talonario_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                UCSucursal.Dock = DockStyle.Fill;
                UCSucursal.TipoCarga = Info.General.Cl_Enumeradores.eTipoFiltro.Normal;

                cargar_combo_tipo_docu();
                
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        chkestado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        visibleCajas(false);
                        txtpuntoEmision.Properties.ReadOnly = true;
                        txtEstablecimiento.Properties.ReadOnly = true;
                        txtGenerar.Properties.ReadOnly = true;
                       
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ultraCmbE_TipoDoc.Enabled = false;
                        set_Controls();        
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntAnular = true;
                        set_Controls();        
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        visibleCajas(false);
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        set_Controls();        
                        break;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void visibleCajas(Boolean opcVisible)
        {
            try
            {
                label4.Visible = opcVisible;
                label5.Visible = opcVisible;
                label6.Visible = opcVisible;
                txtGenerar.Visible = opcVisible;
                txtUltDoc.Visible = opcVisible;
                txtDocFinal.Visible = opcVisible;
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpuntoEmision_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 58) || (txtpuntoEmision.Text).Length > 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    base.OnKeyPress(e);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEstablecimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
                try
                {
                    if (e.KeyChar != 8)
                    {
                        if ((e.KeyChar < 48 || e.KeyChar > 58) || (txtEstablecimiento.Text).Length > 2)
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        base.OnKeyPress(e);
                    }

                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void txtGenerar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 58) || (txtGenerar.Text).Length >8)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    base.OnKeyPress(e);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumeroAut_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 58) || (txtnumeroDoc.Text).Length > 8)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    base.OnKeyPress(e);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEstablecimiento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtEstablecimiento.Text != "" && txtEstablecimiento.Text != "0")
                   obtenerUltimoDocumento();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void obtenerUltimoDocumento()
        {
            try
            {
                string StrNumDoc = "";
                
                int numDocActual = 0;

                if (ultraCmbE_TipoDoc.EditValue != null)
                {
                    if (txtpuntoEmision.Text != "" && txtEstablecimiento.Text != "" && ultraCmbE_TipoDoc.EditValue.ToString() != "")
                    {
                        tb_sis_Documento_Tipo_Talonario_Info InfoNumUltiDoc = busTalonario.Get_Info_Ult_Documento(param.IdEmpresa, txtpuntoEmision.Text, txtEstablecimiento.Text, ultraCmbE_TipoDoc.EditValue.ToString());
                        if (InfoNumUltiDoc != null)
                        {
                            if (InfoNumUltiDoc.NumDocumento != null)
                            {
                                numDocActual = Convert.ToInt32(InfoNumUltiDoc.NumDocumento);
                            }
                            else
                            { numDocActual = 1; }
                        }
                        StrNumDoc = Convert.ToString(numDocActual);
                        txtUltDoc.Text = StrNumDoc.PadLeft(9, '0');
                        if (txtGenerar.Text != "")
                        {
                            StrNumDoc = Convert.ToString(numDocActual + Convert.ToInt32(txtGenerar.Text));
                            txtDocFinal.Text = StrNumDoc.PadLeft(9, '0');
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

        private void txtpuntoEmision_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtpuntoEmision.Text != "" && txtpuntoEmision.Text != "0")
                  obtenerUltimoDocumento();
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ultraCmbE_TipoDoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                   obtenerUltimoDocumento();
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUltDoc_EditValueChanged(object sender, EventArgs e)
        {
            string StrNumDoc = "";            
            if (ultraCmbE_TipoDoc.EditValue != null)
            {
                if (ultraCmbE_TipoDoc.EditValue.ToString() != "")
                {    
                       if (txtUltDoc.Text != "")
                       {
                            numDocActual = Convert.ToInt32(txtUltDoc.Text.Trim());
                            StrNumDoc = Convert.ToString(numDocActual);
                            txtUltDoc.Text = StrNumDoc.PadLeft(9, '0');
                            if (txtGenerar.Text != "")
                            {
                                StrNumDoc = Convert.ToString(numDocActual + Convert.ToInt32(txtGenerar.Text));
                                txtDocFinal.Text = StrNumDoc.PadLeft(9, '0');
                            }
                       }                                           
                }
            }
        }
    }
}

