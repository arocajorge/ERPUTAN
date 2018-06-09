/*CLASE: frmRo_TipoCargo_Mant
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 30-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{

   
    public partial class frmRo_TipoCargo_Mant : Form
    {

         #region Declarar Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action Accion;
        ro_Cargo_Bus BusTipCargo = new ro_Cargo_Bus();
        ro_Cargo_Info InfoTipCargo = new ro_Cargo_Info();
        ro_Departamento_Bus BusDep = new ro_Departamento_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        //DELEGADOS
        public delegate void delegate_frmRo_TipoCargo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_TipoCargo_Mant_FormClosing event_frmRo_TipoCargo_Mant_FormClosing;

        #endregion

        public frmRo_TipoCargo_Mant()
        {
            try
            {
                InitializeComponent();

                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                event_frmRo_TipoCargo_Mant_FormClosing+=frmRo_TipoCargo_Mant_event_frmRo_TipoCargo_Mant_FormClosing;
             }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Grabar();
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }    
        }

        private void pu_Grabar()
        {
            try
            {
               int id = 0;

               
               if (!Validar()){return;}


               getInfo();

               if (BusTipCargo.GrabarDB(InfoTipCargo, ref id, ref mensaje))
                    {
                        txtIdCargo.Text = id.ToString();
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Accion = Cl_Enumeradores.eTipo_action.grabar;
                        Limpiar();    
               }
            }               
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        Boolean Validar()
        {
            try
            {
                if (txtDescCargo.Text == null || txtDescCargo.Text == "")
                {
                    MessageBox.Show("El Cargo es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

             /*   if (CheckEstado.Text.Length == 0)
                {
                    MessageBox.Show("El Estado es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }*/

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
        }

        private void Limpiar()
        {
            try
            {
                txtDescCargo.Text = "";
                txtIdCargo.Text = "";
                CheckEstado.Checked = true;  
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public ro_Cargo_Info setTipoCargo { get; set; }

        public void Set()
        {
            try
            {
                if (setTipoCargo != null)
                {
                    if (setTipoCargo.IdCargo > 0)
                    {
                        txtIdCargo.Text = Convert.ToString(setTipoCargo.IdCargo);
                    }
                }
                txtDescCargo.Text = setTipoCargo.ca_descripcion;
                CheckEstado.Checked = (setTipoCargo.Estado == "A") ? true : false;
                lblEstado.Visible = (setTipoCargo.Estado == "I") ? true : false;

                if (setTipoCargo.Estado == "I")
                {
                    lblEstado.Visible = true;

                }
                else
                {
                    lblEstado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        public void getInfo()
        {
            try
            {
                InfoTipCargo.IdCargo = Convert.ToInt32((txtIdCargo.Text == "") ? "0" : txtIdCargo.Text);
                InfoTipCargo.ca_descripcion = txtDescCargo.Text;
                if (CheckEstado.Checked == true)
                {
                    InfoTipCargo.Estado = "A";
                }
                else
                {
                    InfoTipCargo.Estado = "I";
                }
                
                getParametros();
                
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void getParametros()
        {
            try
            {
                InfoTipCargo.IdEmpresa = param.IdEmpresa;
                InfoTipCargo.ip = param.ip;
                InfoTipCargo.nom_pc = param.nom_pc;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        InfoTipCargo.IdUsuario = param.IdUsuario;
                        InfoTipCargo.Fecha_Transac = param.Fecha_Transac;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        InfoTipCargo.Fecha_UltMod = param.Fecha_Transac;
                        InfoTipCargo.IdUsuarioUltMod = param.IdUsuario;
                        InfoTipCargo.IdUsuario = param.IdUsuario;
                        break;

                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_MantTipoCargo_Load(object sender, EventArgs e)
        {
            try
            {
                this.event_frmRo_TipoCargo_Mant_FormClosing += new delegate_frmRo_TipoCargo_Mant_FormClosing(frmRo_TipoCargo_Mant_event_frmRo_TipoCargo_Mant_FormClosing);
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        lblEstado.Visible = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        

                        this.txtIdCargo.ForeColor = System.Drawing.Color.Black;

                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
               
                        

                        this.txtIdCargo.ForeColor = System.Drawing.Color.Black;

                         this.txtDescCargo.ReadOnly = true;
                        this.txtDescCargo.BackColor = System.Drawing.Color.White;
                        Set();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            

        }

        void frmRo_TipoCargo_Mant_event_frmRo_TipoCargo_Mant_FormClosing(object sender, FormClosingEventArgs e){}
        
        private void frmRo_TipoCargo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_TipoCargo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {

                Accion = _Accion;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Limpiar();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        txtDescCargo.Enabled = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                          txtIdCargo.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtDescCargo.Enabled = false;
                        CheckEstado.Enabled = false;
                        lblEstado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtDescCargo.Enabled = false;
                        CheckEstado.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }



        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void frmRo_TipoCargo_Mant_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void frmRo_TipoCargo_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            } 
        }

        

    }
}
