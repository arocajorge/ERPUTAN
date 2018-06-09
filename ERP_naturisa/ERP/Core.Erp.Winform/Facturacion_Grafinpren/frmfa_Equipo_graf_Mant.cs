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
using Core.Erp.Winform.General;
using Core.Erp.Info.Facturacion_Grafinpren;
using Core.Erp.Business.Facturacion_Grafinpren;

namespace Core.Erp.Winform.Facturacion_Grafinpren
{
    public partial class frmfa_Equipo_graf_Mant : Form
    {
        #region Declaracion de Variables
        
        //generales
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;

        //clases bus
        fa_Equipo_graf_Bus Bus_Equipo = new fa_Equipo_graf_Bus();

        //clases info
        fa_Equipo_graf_Info Info_Equipo = new fa_Equipo_graf_Info();

        //delegates and events
        public delegate void delegate_frmfa_Equipo_graf_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmfa_Equipo_graf_Mant_FormClosing event_delegate_frmfa_Equipo_graf_Mant_FormClosing;

        //otros
        string mensaje = "";
        int IdEquipo = 0;

        #endregion

        public frmfa_Equipo_graf_Mant()
        {
            InitializeComponent();
            event_delegate_frmfa_Equipo_graf_Mant_FormClosing += frmfa_Equipo_graf_Mant_event_delegate_frmfa_Equipo_graf_Mant_FormClosing;
        }

        void frmfa_Equipo_graf_Mant_event_delegate_frmfa_Equipo_graf_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmfa_Equipo_graf_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_delegate_frmfa_Equipo_graf_Mant_FormClosing(sender, e);
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

        public void Set_Info(fa_Equipo_graf_Info _Info_Equipo)
        {
            try
            {
                Info_Equipo = _Info_Equipo;
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
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = false;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = true;
                        chk_estado.Enabled = false;
                        chk_estado.Checked = true;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = true;
                        chk_estado.Enabled = true;
                        Set_Info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = false;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
                        
                        Set_Info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
                        chk_estado.Enabled = false;

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
                txt_IdEquipo.Text = Info_Equipo.IdEquipo.ToString();
                txt_Nombre_Equipo.Text = Info_Equipo.nom_Equipo;
                chk_estado.Checked = Info_Equipo.estado;
                lblanulado.Visible = (Info_Equipo.estado == false) ? true : false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public fa_Equipo_graf_Info Get_Equipo()
        {
            try
            {
                Info_Equipo.IdEmpresa = param.IdEmpresa;
                Info_Equipo.nom_Equipo = txt_Nombre_Equipo.Text;
                Info_Equipo.estado = chk_estado.Checked;
                Info_Equipo.nom_pc = param.nom_pc;
                Info_Equipo.ip = param.ip;

                return Info_Equipo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_Equipo_graf_Info();
            }
        }

        #endregion

        #region Funciones Guardar, Modificar, Alunar, Validar, limpiar

        Boolean Guardar_Datos()
        {
            try
            {
                Boolean respuesta = false;
                txt_IdEquipo.Focus();
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
                Get_Equipo();
                Info_Equipo.IdUsuario = param.IdUsuario;
                Info_Equipo.Fecha_Transaccion = DateTime.Now;
                if (validar())
                {
                    respuesta = Bus_Equipo.GuardarDB(Info_Equipo, ref IdEquipo, ref mensaje);
                    if (respuesta)
                    {
                        Info_Equipo.IdEquipo = IdEquipo;
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " el Equipo # " + Info_Equipo.IdEquipo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
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
                Get_Equipo();
                Info_Equipo.IdUsuarioUltModi = param.IdUsuario;
                Info_Equipo.Fecha_UltMod = DateTime.Now;
                if (validar())
                {
                    respuesta = Bus_Equipo.ModificarDB(Info_Equipo, ref mensaje);
                    if (respuesta)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el Equipo # " + Info_Equipo.IdEquipo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + " el Equipo #: " + Info_Equipo.IdEquipo + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oFrm.ShowDialog();
                    Info_Equipo.IdUsuarioUltAnu = param.IdUsuario;
                    Info_Equipo.Fecha_UltAnu = DateTime.Now;
                    Info_Equipo.MotivoAnulacion = oFrm.motivoAnulacion;
                    resultado = Bus_Equipo.AnularDB(Info_Equipo, ref mensaje);
                    if (resultado)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " el Equipo # " + Info_Equipo.IdEquipo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Info_Equipo.estado = false;
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
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
                if (txt_Nombre_Equipo.EditValue == null || txt_Nombre_Equipo.Text == "")
                {
                    MessageBox.Show("Ingrese un Nombre para el Equipo", param.Nombre_sistema);
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
                txt_IdEquipo.Text = "";
                txt_Nombre_Equipo.Text = "";
                chk_estado.Checked = true;
                chk_estado.Enabled = false;
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

        private void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_Superior_Mant_event_btnlimpiar_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_Superior_Mant_event_btnAnular_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
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

        private void frmfa_Equipo_graf_Mant_Load(object sender, EventArgs e)
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
    }
}
