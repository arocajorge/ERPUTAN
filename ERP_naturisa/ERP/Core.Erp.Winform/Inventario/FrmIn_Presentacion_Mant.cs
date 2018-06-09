using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Presentacion_Mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();

        in_presentacion_Bus BusPresentacion = new in_presentacion_Bus();
        in_presentacion_Info InfoPresentacion = new in_presentacion_Info();



        int C = 0;
        public delegate void delegate_FrmIn_Presentacion_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Presentacion_Mant_FormClosing event_FrmIn_Presentacion_Mant_FormClosing;
        #endregion

        public FrmIn_Presentacion_Mant()
        {
            InitializeComponent();
             ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            event_FrmIn_Presentacion_Mant_FormClosing += FrmIn_Presentacion_Mant_event_FrmIn_Presentacion_Mant_FormClosing;
        }

        void FrmIn_Presentacion_Mant_event_FrmIn_Presentacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmIn_Presentacion_Mant_Load(object sender, EventArgs e)
        {

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

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (grabar() == true)
                    {
                        this.Close();
                    }
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
                if (Validar())
                {
                    if (grabar() == true)
                    {

                    } 
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Boolean Validar()
        {
            try
            {
                Boolean res = true;
            
                

                
                if (txt_nombre.Text.Trim() == "" || txt_nombre.Text == null)
                {
                    MessageBox.Show("Ingrese el nombre del Catalogo", "Sistemas");
                    txt_nombre.Focus();
                    res = false;
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

        Boolean grabar()
        {
            Boolean var = false;
            try
            {
                txt_codigo.Focus();
                GetInfo_Presentacion();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        var = Guardar();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        var = Actualizar();

                        break;
                    default:
                        break;
                }
                
                return var;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean Guardar()
        {
           string msg = "";
           try
           {
                if (BusPresentacion.GuardarDB(InfoPresentacion, ref msg))
                {
                    
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema); 
                    txt_codigo.Text = InfoPresentacion.IdPresentacion;
                    LimpiarDatos();
                    return true;
                }
                else
                {

                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);          
                    return false;
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        Boolean Actualizar()
        {
            try
            {
                if (BusPresentacion.ModificarDB(InfoPresentacion))
                {
                    
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente), param.Nombre_sistema);
                    LimpiarDatos();
                    return true;
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);   
                    return false;
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

               
       private void FrmIn_Catalogo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        txt_codigo.Focus();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        SetInfo_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = true;

                        ucGe_Menu.Enabled_bntLimpiar = false;
                       
                        SetInfo_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;

                        
                        SetInfo_in_controls();
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

       public void SetInfo_Presentacion(in_presentacion_Info _Info)
       {
           InfoPresentacion = _Info;
       }

       public void SetAccion(Cl_Enumeradores.eTipo_action _Accion)
       {
           Accion = _Accion;
       }

       private void SetInfo_in_controls()
        {
            try
            {
                
                txt_codigo.Text = InfoPresentacion.IdPresentacion;
                txt_nombre.Text = InfoPresentacion.nom_presentacion;

                if (InfoPresentacion.estado.TrimEnd() == "I")
                {
                    this.ckbActivo.Checked = false;
                    lblAnulado.Visible = true;
                }
                else
                {
                    ckbActivo.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       public in_presentacion_Info GetInfo_Presentacion()
        {
            try
            {
                InfoPresentacion = new in_presentacion_Info();
                InfoPresentacion.IdEmpresa = param.IdEmpresa;
                InfoPresentacion.IdPresentacion = txt_codigo.Text.Trim();
                InfoPresentacion.nom_presentacion = txt_nombre.Text.Trim();
                InfoPresentacion.estado = (ckbActivo.Checked == true) ? "A" : "I";

                return InfoPresentacion;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new in_presentacion_Info();
            }
        }
       

        void LimpiarDatos()
        {
            try
            {
                txt_codigo.Text = "";
                txt_nombre.Text = "";
                InfoPresentacion = new in_presentacion_Info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Presentacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmIn_Presentacion_Mant_FormClosing(sender, e);
        }


    }
}
