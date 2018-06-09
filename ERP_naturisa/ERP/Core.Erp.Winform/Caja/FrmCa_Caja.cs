using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Caja;
using Core.Erp.Business.Caja;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.SeguridadAcceso;


namespace Core.Erp.Winform.Caja
{
    public partial class FrmCa_Caja : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_FrmCa_Caja_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCa_Caja_FormClosing event_FrmCa_Caja_FormClosing;
        tb_Sucursal_Bus sucur_B = new tb_Sucursal_Bus();
        tb_moneda_Bus moneda_B = new tb_moneda_Bus();
        caj_Caja_Info caja_I = new caj_Caja_Info();
        caj_Caja_Bus caja_B = new caj_Caja_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        ct_Plancta_Bus _PlanCta_bus = new ct_Plancta_Bus();
        seg_usuario_bus BusUsuario = new seg_usuario_bus();

        int idCaja = 0;
        string motiAnulacion = "";
        string MensajeError = "";

        #region Enventos delegados locales

        void FrmCa_Caja_Movimiento_event_FrmCa_Caja_Movimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        #endregion
        #endregion
        
        public FrmCa_Caja()
        {
            try
            {
                     InitializeComponent();


                     this.ultraCmbE_responsable.Properties.DataSource = BusUsuario.Get_List_Usuario(ref MensajeError);
                    this.ultraCmbE_responsable.Properties.DisplayMember = "Nombre";
                    this.ultraCmbE_responsable.Properties.ValueMember = "IdUsuario";

                    this.ultraCmbE_moneda.Properties.DataSource = moneda_B.Get_List_Moneda();
                    this.ultraCmbE_moneda.Properties.DisplayMember = "im_descripcion";
                    this.ultraCmbE_moneda.Properties.ValueMember = "IdMoneda";

                    ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
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
                if (Grabar())
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
                Grabar();
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
                _Accion = Cl_Enumeradores.eTipo_action.Anular;
                Grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        private caj_Caja_Info get_Caja()
        {
            try
            {
                caja_I.ca_Codigo = txt_codigo.Text.Trim();
                caja_I.ca_Descripcion = txt_descripcion.Text.Trim();
                caja_I.ca_Moneda = this.ultraCmbE_moneda.Text.ToString();
                caja_I.IdMoneda = Convert.ToInt32(this.ultraCmbE_moneda.EditValue);
                caja_I.Estado = (this.chk_estado.Checked == true) ? "A" : "I";                
                lb_Anulado.Visible = (this.chk_estado.Checked == true) ? false : true;
                caja_I.Fecha_Transac =param.Fecha_Transac;
                caja_I.Fecha_UltAnu=param.Fecha_Transac;
                caja_I.Fecha_UltMod=param.Fecha_Transac;
                caja_I.IdCaja=Convert.ToInt32(txt_idCaja.Text);
                caja_I.IdCtaCble = ucCon_PlanCtaCmb1.get_PlanCtaInfo().IdCtaCble;
                caja_I.IdEmpresa=param.IdEmpresa;
                caja_I.IdUsuario=param.IdUsuario;                
                caja_I.IdUsuario_Responsable = ultraCmbE_responsable.EditValue.ToString();
                caja_I.IdUsuarioUltAnu=param.IdUsuario;
                caja_I.IdUsuarioUltMod=param.IdUsuario;
                caja_I.ip=param.ip;
                caja_I.nom_pc=param.nom_pc;
                caja_I.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;

                if (uCct_Pto_Cargo_Grupo1.Get_info_grupo() != null) caja_I.IdPunto_cargo_grupo = uCct_Pto_Cargo_Grupo1.Get_info_grupo().IdPunto_cargo_grupo;
                if (uCct_Pto_Cargo_Grupo1.Get_info_punto_cargo() != null) caja_I.IdPunto_cargo = uCct_Pto_Cargo_Grupo1.Get_info_punto_cargo().IdPunto_cargo;

                return caja_I;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new caj_Caja_Info();
            }
        }

        public void set_Caja(caj_Caja_Info info)
        {
            try
            {
                uCct_Pto_Cargo_Grupo1.Cargar_combos();

                txt_idCaja.Text = info.IdCaja.ToString();
                txt_codigo.Text = info.ca_Codigo;
                txt_descripcion.Text = info.ca_Descripcion;
                ultraCmbE_moneda.EditValue = info.IdMoneda;
                this.chk_estado.Checked = (info.Estado == "I") ? false : true;
                lb_Anulado.Visible = (info.Estado == "I") ? true : false;
                ucCon_PlanCtaCmb1.set_PlanCtarInfo(info.IdCtaCble);
                ultraCmbE_responsable.EditValue = info.IdUsuario_Responsable;
                ucGe_Sucursal_combo1.set_SucursalInfo(Convert.ToInt32(info.IdSucursal));
                uCct_Pto_Cargo_Grupo1.Set_info_grupo(info.IdPunto_cargo_grupo);
                uCct_Pto_Cargo_Grupo1.Set_info_punto_cargo(info.IdPunto_cargo);

                caja_I = info;

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean validaColumna()
       {
           try
           {
               Boolean estado = true;

               if (ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal == null)
               {
                   MessageBox.Show("Antes de continuar debe Seleccionar la Sucursal de la Caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   ucGe_Sucursal_combo1.Focus();
                   estado = false;
                   return estado;
               }

               if (ultraCmbE_moneda.EditValue == null)
              {
                  MessageBox.Show("Antes de continuar debe Seleccionar la Moneda de la Caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                  ultraCmbE_moneda.Focus();
                   estado = false;
                   return estado; 
              }

               if (this.ucCon_PlanCtaCmb1.get_PlanCtaInfo() == null)
              {
                   MessageBox.Show("Antes de continuar debe seleccionar la Cuenta de la Caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   ucCon_PlanCtaCmb1.Focus();
                   estado = false;
                   return estado;                   
              }

               if (this.ultraCmbE_responsable.EditValue == null)
              {
                   MessageBox.Show("Antes de continuar debe seleccionar la Persona Responsable de la Caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   ultraCmbE_responsable.Focus();
                   estado = false;
                   return estado;                   
              }
           
             if( txt_descripcion.Text =="")
             {
                  MessageBox.Show("Antes de continuar debe ingresar Descripción de Caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                  txt_descripcion.Focus();
                  estado = false;
                   return estado; 
             }

               return estado;
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
           }
       }

        private Boolean Grabar()
       {
           try
           {
               Boolean bolResult = false;
               if (validaColumna())
               {
                   get_Caja();
                   string msg = "";
                   string msg2 = "";
                  
                   if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                   {
                       if(caja_B.GrabarDB(caja_I,ref idCaja, ref  MensajeError))
                       {
                           txt_idCaja.Text = idCaja.ToString();
                           txt_codigo.Text = (txt_codigo.Text == "") ? txt_idCaja.Text : txt_codigo.Text;
                           string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Caja ", txt_idCaja.Text);
                           MessageBox.Show(smensaje, param.Nombre_sistema);
                           //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                           //ucGe_Menu.Visible_btnGuardar = false;
                           //_Accion = Cl_Enumeradores.eTipo_action.actualizar;
                           bolResult = true;
                           LimpiarDatos();
                       }
                       else
                       {
                           string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                           MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
                   }
                   if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                   {
                       if (caja_B.ModificarDB(caja_I, ref  MensajeError))
                       {
                           string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "Caja ", txt_idCaja.Text);
                           MessageBox.Show(smensaje, param.Nombre_sistema);
                           //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                           //ucGe_Menu.Visible_btnGuardar = false;
                           bolResult = true;
                           LimpiarDatos();
                       }
                       else 
                       {
                           string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                           MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                           
                       }
                   }

                   if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                   {
                       if (caja_I.Estado != "I")
                       {
                           if (MessageBox.Show("¿Está seguro que desea anular la Caja #: " + txt_idCaja.Text  + " ?", "Anulación de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                           {
                               FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                               fr.ShowDialog();
                               motiAnulacion = fr.motivoAnulacion;
                               caja_I.MotivoAnu = motiAnulacion;
                               caja_I.IdUsuarioUltAnu = param.IdUsuario;
                               caja_I.Fecha_UltAnu = param.Fecha_Transac;

                               if (caja_B.Anular(caja_I, ref  MensajeError))
                               {
                                   string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "Caja ", txt_idCaja.Text);
                                   MessageBox.Show(smensaje, param.Nombre_sistema);                                   
                                   lb_Anulado.Visible = true;
                                   ucGe_Menu.Visible_bntAnular = false;
                                   bolResult = true;
                               }
                               else
                               {
                                   string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                                   MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                                  
                               }
                                  
                           }
                       }
                       else
                           MessageBox.Show("Esta Caja ya esta Anulada...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               }  
               else
               MessageBox.Show("No se puede Grabar...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

               return bolResult;
           }
           catch (Exception ex )
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
                caja_I = new caj_Caja_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion(_Accion);
                txt_idCaja.Text = "";
                txt_codigo.Text = "";
                txt_descripcion.Text = "";               
                
                this.chk_estado.Checked = true;                
                ucCon_PlanCtaCmb1.Inicializar_cmbPlanCta();
                caja_I.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;

                uCct_Pto_Cargo_Grupo1.Inicializar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCa_Caja_Load(object sender, EventArgs e)
        {
            try
            {
                this.event_FrmCa_Caja_FormClosing+=new delegate_FrmCa_Caja_FormClosing(FrmCa_Caja_event_FrmCa_Caja_FormClosing);
                if (_Accion==Cl_Enumeradores.eTipo_action.grabar)
                {
                    uCct_Pto_Cargo_Grupo1.Cargar_combos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }

        void FrmCa_Caja_event_FrmCa_Caja_FormClosing(object sender, FormClosingEventArgs e)
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
      
        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        chk_estado.Checked = true;
                        chk_estado.Enabled = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                       ucGe_Menu.Visible_btnGuardar = false;
                       ucGe_Menu.Visible_bntAnular = false;
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

        private void chk_estado_CheckedChanged(object sender, EventArgs e)
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
       
        private void ultraCmbE_moneda_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmbE_moneda.EditValue == null)
                    ultraCmbE_moneda.EditValue = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ultraCmb_Cta_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //if (this.ultraCmb_Cta.EditValue == null)
                //    ultraCmb_Cta.EditValue = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ultraCmbE_responsable_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmbE_responsable.EditValue == null)
                    ultraCmbE_responsable.EditValue = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ultraCmbE_sucursal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal == null)
                    ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal = 1;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCa_Caja_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              this.event_FrmCa_Caja_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
}
