using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_disco_mant : Form
    {
        #region varibales
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action _Accion;

        ro_disco_Info Info_Disco = new ro_disco_Info();
        ro_disco_Bus bus_Disco = new ro_disco_Bus();
               
        public delegate void delegate_frmRo_disco_mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_disco_mant_FormClosing event_frmRo_disco_mant_FormClosing;

        string mensaje = "";
        int IdDisco = 0;
        #endregion

        public frmRo_disco_mant()
        {
            InitializeComponent();
            event_frmRo_disco_mant_FormClosing += frmRo_disco_mant_event_frmRo_disco_mant_FormClosing;
        }

        void frmRo_disco_mant_event_frmRo_disco_mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmRo_disco_mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_frmRo_disco_mant_FormClosing(sender, e);
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

        public void Set_Info(ro_disco_Info _Info_Disco)
        {
            try
            {
                Info_Disco = _Info_Disco;
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
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntLimpiar = true;
                        chkEstado.Enabled = false;
                        chkEstado.Checked = true;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntImprimir = true;
                        ucGe_Menu.Visible_bntLimpiar = true;
                        chkEstado.Enabled = true;
                        Set_Info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;

                        Set_Info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntImprimir = true;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        chkEstado.Enabled = false;

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
                txtId_disco.Text = Info_Disco.IdDisco.ToString();
                txt_disco.Text = Info_Disco.Disco;
                chkEstado.Checked = Info_Disco.Estado;
                lblanulado.Visible = (Info_Disco.Estado == false) ? true : false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ro_disco_Info Get_Disco()
        {
            try
            {
                Info_Disco.IdEmpresa = param.IdEmpresa;
                Info_Disco.Disco = txt_disco.Text;
                Info_Disco.Estado = chkEstado.Checked;
                Info_Disco.nom_pc = param.nom_pc;
                Info_Disco.ip = param.ip;

                return Info_Disco;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ro_disco_Info();
            }
        }

        #endregion

        #region Funciones Guardar, Modificar, Alunar, Validar, limpiar

        Boolean Guardar_Datos()
        {
            try
            {
                Boolean respuesta = false;
                txtId_disco.Focus();
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
                Get_Disco();
                Info_Disco.IdUsuario = param.IdUsuario;
                Info_Disco.Fecha_Transaccion = DateTime.Now;
                if (validar())
                {
                    respuesta = bus_Disco.GuardarDB(Info_Disco, ref IdDisco, ref mensaje);
                    if (respuesta)
                    {
                        Info_Disco.IdDisco = IdDisco;
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " el Disco # " + Info_Disco.IdDisco, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                //txt_IdGrupo.Focus();
                Get_Disco();
                Info_Disco.IdUsuarioUltModi = param.IdUsuario;
                Info_Disco.Fecha_UltMod = DateTime.Now;
                if (validar())
                {
                    respuesta = bus_Disco.ModificarDB(Info_Disco, ref mensaje);
                    if (respuesta)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el Disco # " + Info_Disco.IdDisco, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private Boolean AnularDB()
        {
            try
            {
                Boolean resultado = false;
                FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + " el Disco #: " + Info_Disco.IdDisco + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oFrm.ShowDialog();
                    Info_Disco.IdUsuarioUltAnu = param.IdUsuario;
                    Info_Disco.Fecha_UltAnu = DateTime.Now;
                    Info_Disco.MotivoAnulacion = oFrm.motivoAnulacion;
                    resultado = bus_Disco.AnularDB(Info_Disco, ref mensaje);
                    if (resultado)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " el Disco # " + Info_Disco.IdDisco, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Info_Disco.Estado = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        lblanulado.Visible = true;
                        Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                        return true;
                    }
                }
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

        public Boolean validar()
        {
            try
            {
                if (txt_disco.EditValue == null || txt_disco.Text == "")
                {
                    MessageBox.Show("Ingrese un número de Disco", param.Nombre_sistema);
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
                txtId_disco.Text = "";
                txt_disco.Text = "";
                chkEstado.Checked = true;
                chkEstado.Enabled = false;
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

        #region Eventos del formulario

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                AnularDB();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        private void frmRo_disco_mant_Load(object sender, EventArgs e)
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
 
        #endregion
    }
}
