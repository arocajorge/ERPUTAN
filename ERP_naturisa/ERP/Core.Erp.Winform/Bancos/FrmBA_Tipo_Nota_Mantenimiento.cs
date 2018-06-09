using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Tipo_Nota_Mantenimiento : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public Cl_Enumeradores.eTipo_action _Accion { get; set; }
        private ba_tipo_nota_Info Info = new ba_tipo_nota_Info();
        ba_Cbte_Ban_tipo_Bus busTipo = new ba_Cbte_Ban_tipo_Bus();
        ct_Plancta_Bus planCtaBus = new ct_Plancta_Bus();
        ct_Centro_costo_Bus ccBus = new ct_Centro_costo_Bus();
        ba_tipo_nota_Bus bus_Tipo_Nota = new ba_tipo_nota_Bus();
        BindingList<ct_Plancta_Info> binPlanCta = new BindingList<ct_Plancta_Info>();
        public delegate void delegate_FrmBA_Tipo_Nota_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBA_Tipo_Nota_Mantenimiento_FormClosing Event_FrmBA_Catalogo_Mantenimiento_FormClosing;
        string MensajeError = "";
        string mensaje = "";

        #endregion

        public FrmBA_Tipo_Nota_Mantenimiento()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Guardar()) this.Close();
                }
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (Actualizar()) Close(); 
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Guardar();
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                    ucGe_Menu.Visible_btnGuardar = true;
                }
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    Actualizar();
                    Close();
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        public void set_combo_tipo_nota(Cl_Enumeradores.eTipoNotaBanco TipoNota)
        {
            try
            {
                cmbTipo.EditValue = TipoNota.ToString();
                cmbTipo.Enabled = false;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void _Info(ba_tipo_nota_Info Info)
        {
            try
            {
                this.Info = Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmBA_Tipo_Nota_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTipo.Properties.DataSource = busTipo.Get_list_Cbte_Ban_Tipo_x_NCBA_NDBA();
                txtId.Enabled = false;
                txtId.ForeColor = Color.Black;
                txtId.BackColor = Color.White;
                load();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }       
        
        void editCmb()
        {
            try
            {
                string mensaje="";
                cmbTipo.Properties.DataSource = busTipo.Get_list_Cbte_Ban_Tipo_x_NCBA_NDBA();
                cmbTipo.EditValue = Info.Tipo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }
        
        void load()
        {
            try
            {
                switch (_Accion)
                {   
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        Set();
                        editCmb();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Bloquear_Datos();
                        ucGe_Menu.Visible_bntAnular = false;
                        Set();
                        editCmb();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Bloquear_Datos();
                        ucGe_Menu.Visible_bntAnular = true;
                        Set();
                        editCmb();
                        break;
                }
            }
            catch (Exception ex )
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Limpiar_Datos()
        {
            try
            {
                txtDescripcion.Text = "";
                cmbCuentaContable.set_PlanCtarInfo("");
                cmbCuentaCosto.set_IdCentroCosto("");
                cmbTipo.EditValue = 0;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }
        void Bloquear_Datos()
        {
            try
            {
                
                txtId.Enabled = false;
                txtId.ForeColor = Color.Black;
                txtId.BackColor = Color.White;

                txtDescripcion.Enabled = false;
                txtDescripcion.ForeColor = Color.Black;
                txtDescripcion.BackColor = Color.White;

                cmbCuentaContable.Enabled = false;
                cmbCuentaContable.ForeColor = Color.Black;
                cmbCuentaContable.BackColor = Color.White;

                cmbCuentaCosto.Enabled = false;
                cmbCuentaCosto.ForeColor = Color.Black;
                cmbCuentaCosto.BackColor = Color.White;

                cmbTipo.Enabled = false;
                cmbTipo.ForeColor = Color.Black;
                cmbTipo.BackColor = Color.White;
                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu.Visible_btnGuardar = false;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Set()
        {
            try
            {
                txtId.Text = Info.IdTipoNota.ToString();
                txtDescripcion.Text = Info.Descripcion;
                cmbTipo.EditValue = Info.Tipo;
                cmbCuentaContable.set_PlanCtarInfo(Info.IdCtaCble);
                cmbCuentaCosto.set_item(Info.IdCentroCosto);
                chkEstado.Checked = (Info.Estado == "A") ? true : false;

                if (chkEstado.Checked)
                    lblEstado.Visible = false;
                else
                    lblEstado.Visible = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        void Get()
        {
            try
            {
                Info.IdEmpresa = param.IdEmpresa;
                Info.Descripcion = txtDescripcion.Text;
                Info.Tipo = cmbTipo.EditValue.ToString();
                Info.IdCtaCble = cmbCuentaContable.get_PlanCtaInfo().IdCtaCble;
                Info.IdCentroCosto = cmbCuentaCosto.get_item();
                
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkEstado.Checked = true;
                }
                
                Info.Estado = (chkEstado.Checked == true) ? "A" : "I";
        
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        Boolean validar()
        {
            try
            {
                
                if (String.IsNullOrEmpty(Convert.ToString(txtDescripcion.EditValue).Trim()))
                {
                    MessageBox.Show("Por favor ingrese descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (cmbTipo.EditValue == null)
                {
                    MessageBox.Show("Por favor seleccione el tipo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

            return true;
        }

        public  bool Guardar()
        {
            try
            {
                if (validar())
                {
                    Get();
                    
                    
                    if (bus_Tipo_Nota.GuardarDB(Info))
                    {
                        //Bloquear_Datos();
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro", Info.IdTipoNota);
                        MessageBox.Show(smensaje, param.Nombre_sistema);
                        Limpiar_Datos();
                        return true;
                    }
                    return true;
                }
                else 
                    return false;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public bool Actualizar()
        {
            try
            {
                if (validar())
                {
                    Get();
                    if (bus_Tipo_Nota.ActualizarDB(Info))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El registro ", Info.IdTipoNota);
                        MessageBox.Show(smensaje, param.Nombre_sistema);                        
                        //MessageBox.Show("El registro #" + Info.IdTipoNota + " ha sido Actualizado correctamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    return true;
                } 
                else 
                    return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public bool Anular()
        {
            try
            {
                if (Info.Estado == "I")
                {
                    MessageBox.Show("El registro ya se encuentra anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Tipo de Rubro #:" + txtId.Text.Trim() + " ?", "Anulación de Mantenimiento Tipo Rubro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ba_tipo_nota_Bus neg = new ba_tipo_nota_Bus();
                        
                        bool resultado = neg.Eliminar(Info, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu.Visible_btnGuardar = false;
                        }
                        else
                        {
                            string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + mensaje + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Log_Error_bus.Log_Error(NameMetodo + " - " + mensaje.ToString());
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void FrmBA_Tipo_Nota_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_FrmBA_Catalogo_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Anular())
                    MessageBox.Show("El registro se anuló satisfactoriamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro no se anuló.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                throw;
            }
        }
    }
}
