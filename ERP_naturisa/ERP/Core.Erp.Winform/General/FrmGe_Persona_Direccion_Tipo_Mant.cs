using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Persona_Direccion_Tipo_Mant : Form
    {
          #region Declaración de variables

            public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
            
            tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

            private Cl_Enumeradores.eTipo_action _Accion;

            tb_persona_direccion_tipo_Info info;
            tb_persona_direccion_tipo_Bus Bus_Dir_tipo = new tb_persona_direccion_tipo_Bus();

            public delegate void delegate_FrmGe_Persona_Direccion_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e);
            public event delegate_FrmGe_Persona_Direccion_Tipo_Mant_FormClosing event_FrmGe_Persona_Direccion_Tipo_Mant_FormClosing;

            string msg = "";
        #endregion

        public FrmGe_Persona_Direccion_Tipo_Mant()
        {
            InitializeComponent();
            event_FrmGe_Persona_Direccion_Tipo_Mant_FormClosing += FrmGe_Persona_Direccion_Tipo_Mant_event_FrmGe_Persona_Direccion_Tipo_Mant_FormClosing;
        }

        void FrmGe_Persona_Direccion_Tipo_Mant_event_FrmGe_Persona_Direccion_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmGe_Persona_Direccion_Tipo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }
                Set_Accion_in_Controls();
                Set_Info_In_Controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    LimpiarDatos();
                    Set_Accion_in_Controls();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void Set_Accion_in_Controls()
        {
            try
            {

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.txtId.Text = "0";
                        this.txtId.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.txtId.Text = "0";
                        this.txtId.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        this.txtId.Text = "0";
                        this.txtId.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.txtId.Enabled = false;
                        this.txtnombre.Enabled = false;
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

        private bool Accion_Grabar()
        {
            bool res = false;
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res = Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res=Actualizar();
                        break;
                    default:
                        break;
                }

                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Grabar()
        {
            try
            {
                
                int id = 0;
                Boolean bolResult = false;
                Get_Info();

                bolResult = Bus_Dir_tipo.GuardarDB(info, ref id, ref msg);

                if (bolResult)
                {
                    MessageBox.Show("Grabado ok..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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

        private bool Actualizar()
       {
           try
           {
               int id = 0;
               Boolean bolResult = false;
               Get_Info();

               bolResult=Bus_Dir_tipo.ModificarDB(info, ref msg);
               
                if (bolResult)
                {
                    MessageBox.Show("Moficacion ok..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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

        private void LimpiarDatos()
        {
            try
            {
                info = new tb_persona_direccion_tipo_Info();
                this.txtId.Text = "";
                this.txtnombre.Text = "";
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action iAccion)
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

        public void Set_Info(tb_persona_direccion_tipo_Info _Info)
        {
            try
            {
                info = _Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_Info_In_Controls()
        {
            try
            {
                if (info != null)
                {
                    this.txtId.Text = info.IdTipoDireccion.ToString();
                    this.txtnombre.Text = info.nom_TipoDireccion.ToString();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public tb_persona_direccion_tipo_Info Get_Info()
        {
            try
            {
                info = new tb_persona_direccion_tipo_Info();

                info.IdTipoDireccion = (this.txtId.Text != "") ? Convert.ToInt32(this.txtId.Text) : 0; 
                info.nom_TipoDireccion = this.txtnombre.Text;
                
                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new tb_persona_direccion_tipo_Info();
            }

        }

        private void FrmGe_Persona_Direccion_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmGe_Persona_Direccion_Tipo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

    
    }
}
