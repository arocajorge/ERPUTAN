using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;

namespace Core.Erp.Winform.General
{
    public partial class frmGe_banco_procesos_bancarios_tipo_mant : Form
    {
        #region Variables, Eventos y Delegados

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action _Accion;

        tb_banco_procesos_bancarios_tipo_Info Info_Proceso = new tb_banco_procesos_bancarios_tipo_Info();
        tb_banco_procesos_bancarios_tipo_Bus Bus_Proceso_Bancario = new tb_banco_procesos_bancarios_tipo_Bus();
        List<tb_banco_procesos_bancarios_tipo_Info> Lista_Tipo_Proceso_Bancarios = new List<tb_banco_procesos_bancarios_tipo_Info>();

        public delegate void delegate_frmGe_banco_procesos_bancarios_tipo_mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmGe_banco_procesos_bancarios_tipo_mant_FormClosing event_frmGe_banco_procesos_bancarios_tipo_mant_FormClosing;

        string mensaje = "";
        int count = 0;

        #endregion
        public frmGe_banco_procesos_bancarios_tipo_mant()
        {
            InitializeComponent();
            event_frmGe_banco_procesos_bancarios_tipo_mant_FormClosing += frmGe_banco_procesos_bancarios_tipo_mant_event_frmGe_banco_procesos_bancarios_tipo_mant_FormClosing;
        }

        void frmGe_banco_procesos_bancarios_tipo_mant_event_frmGe_banco_procesos_bancarios_tipo_mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmGe_banco_procesos_bancarios_tipo_mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_frmGe_banco_procesos_bancarios_tipo_mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region metodos Get y Set

        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Info(tb_banco_procesos_bancarios_tipo_Info _Info_Proceso)
        {
            try
            {
                Info_Proceso = _Info_Proceso;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_Accion_in_controls()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        txt_Id_Tipo_Procesos_Banc.Properties.ReadOnly = false;
                        txt_InicialesArchivo.Properties.ReadOnly = false;
                        txt_Nombre_Proceso.Properties.ReadOnly = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        txt_Id_Tipo_Procesos_Banc.Properties.ReadOnly = true;
                        txt_InicialesArchivo.Properties.ReadOnly = false;
                        txt_Nombre_Proceso.Properties.ReadOnly = false;

                        Set_Info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled = false;
                        txt_Id_Tipo_Procesos_Banc.Properties.ReadOnly = true;
                        txt_InicialesArchivo.Properties.ReadOnly = true;
                        txt_Nombre_Proceso.Properties.ReadOnly = true;

                        Set_Info_in_controls();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_Info_in_controls()
        {
            try
            {
                txt_InicialesArchivo.Text = Info_Proceso.Iniciales_Archivo;
                txt_Id_Tipo_Procesos_Banc.Text = Info_Proceso.IdProceso_bancario_tipo;
                txt_Nombre_Proceso.Text = Info_Proceso.nom_proceso_bancario;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public tb_banco_procesos_bancarios_tipo_Info Get_Tipo_Procesos()
        {
            try
            {
                Info_Proceso.Iniciales_Archivo = txt_InicialesArchivo.Text;
                Info_Proceso.IdProceso_bancario_tipo = txt_Id_Tipo_Procesos_Banc.Text;
                Info_Proceso.nom_proceso_bancario = txt_Nombre_Proceso.Text;

                return Info_Proceso;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_banco_procesos_bancarios_tipo_Info();
            }
        }

        #endregion

        #region Funciones Guardar, Modificar, Validar, limpiar

        Boolean Guardar_Datos()
        {
            try
            {
                Boolean respuesta = false;
                txt_Id_Tipo_Procesos_Banc.Focus();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        respuesta = GuardarDB();
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        respuesta = ModificarDB();
                        break;
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean GuardarDB()
        {
            try
            {
                Boolean respuesta = false;
                Get_Tipo_Procesos();

                if (validar())
                {
                    respuesta = Bus_Proceso_Bancario.GuardarDB(Info_Proceso, ref mensaje);
                    if (respuesta)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " el Tipo de proceso bancario: " + Info_Proceso.IdProceso_bancario_tipo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return respuesta;
                    }
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean ModificarDB()
        {
            try
            {
                bool respuesta = false;
                Get_Tipo_Procesos();
                if (validar())
                {
                    respuesta = Bus_Proceso_Bancario.ModificarDB(Info_Proceso, ref mensaje);
                    if (respuesta)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el tipo de proceso bancario es: # " + Info_Proceso.IdProceso_bancario_tipo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return respuesta;
                    }
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public Boolean validar()
        {
            try
            {
                if (txt_Id_Tipo_Procesos_Banc.EditValue == null || txt_Id_Tipo_Procesos_Banc.Text == "")
                {
                    MessageBox.Show("Ingrese un Id de Tipo de proceso bancario", param.Nombre_sistema);
                    return false;
                }

                if (txt_Nombre_Proceso.EditValue == null || txt_Nombre_Proceso.Text == "")
                {
                    MessageBox.Show("Ingrese un nombre al tipo de proceso bancario", param.Nombre_sistema);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void limpiar()
        {
            try
            {
                txt_Id_Tipo_Procesos_Banc.Text = "";
                txt_InicialesArchivo.Text = "";
                txt_Nombre_Proceso.Text = "";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion

        private void frmGe_banco_procesos_bancarios_tipo_mant_Load(object sender, EventArgs e)
        {
            try
            {
                Set_Accion_in_controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
