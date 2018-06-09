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
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAf_Activo_Fijo_Grupo_Mant : Form
    {
        #region Variables

        public Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Af_Activo_Fijo_Grupo_Info Info_Grupo = new Af_Activo_Fijo_Grupo_Info();
        Af_Activo_Fijo_Grupo_Bus BusGrupo = new Af_Activo_Fijo_Grupo_Bus();

        public delegate void delegate_frmAf_Activo_Fijo_Grupo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmAf_Activo_Fijo_Grupo_Mant_FormClosing event_frmAf_Activo_Fijo_Grupo_Mant_FormClosing;

        #endregion

        public frmAf_Activo_Fijo_Grupo_Mant()
        {
            InitializeComponent();
            event_frmAf_Activo_Fijo_Grupo_Mant_FormClosing += frmAf_Activo_Fijo_Grupo_Mant_event_frmAf_Activo_Fijo_Grupo_Mant_FormClosing;
        }

        void frmAf_Activo_Fijo_Grupo_Mant_event_frmAf_Activo_Fijo_Grupo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmAf_Activo_Fijo_Grupo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmAf_Activo_Fijo_Grupo_Mant_FormClosing(sender, e);
        }

        #region Set y Get
        
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Af_Grupo(Af_Activo_Fijo_Grupo_Info Info)
        {
            try
            {
                Info_Grupo = Info;
                
                //llenando los campos
                txtId_Af_Grupo.Text = Info.IdGrupoActivoFijo.ToString();
                txtCod_Af_Grupo.Text = Info.codGrupoActivoFijo;
                txtNombre_Af_Grupo.Text = Info.nom_GrupoActivoFijo;
                if (Info.estado == "A")
                {
                    chkEstado.Checked = true;
                    lblAnulado.Visible = false;
                }
                else
                {
                    chkEstado.Checked = false;
                    lblAnulado.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Af_Activo_Fijo_Grupo_Info Get_Af_Grupo(ref string mensaje)
        {
            Af_Activo_Fijo_Grupo_Info Info= new Af_Activo_Fijo_Grupo_Info();
            try
            {
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdGrupoActivoFijo = (txtId_Af_Grupo.Text == "") ? 0 : Convert.ToInt32(txtId_Af_Grupo.Text);
                Info.codGrupoActivoFijo = txtCod_Af_Grupo.Text;
                Info.nom_GrupoActivoFijo = txtNombre_Af_Grupo.Text;
                Info.estado = (chkEstado.Checked == true) ? "A" : "I";
                
                return Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception();
            }
        }

        #endregion

        #region Procesos y Funciones

        public void Cargar_Datos()
        {
            try
            {
                //llenando los campos
                txtId_Af_Grupo.Text = Info_Grupo.IdGrupoActivoFijo.ToString();
                txtCod_Af_Grupo.Text = Info_Grupo.codGrupoActivoFijo;
                txtNombre_Af_Grupo.Text = Info_Grupo.nom_GrupoActivoFijo;
                if (Info_Grupo.estado == "A")
                {
                    chkEstado.Checked = true;
                    lblAnulado.Visible = false;
                }
                else
                {
                    chkEstado.Checked = false;
                    lblAnulado.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar()
        {
            txtCod_Af_Grupo.Text = "";
            txtNombre_Af_Grupo.Text = "";
        }

        public Boolean Grabar_DB()
        {
            try
            {
                bool resultado = false;
                string mensaje = string.Empty;
                Af_Activo_Fijo_Grupo_Info Info = new Af_Activo_Fijo_Grupo_Info();

                Info = Get_Af_Grupo(ref mensaje);
                Info.UsuarioCreacion = param.IdUsuario;
                Info.FechaCreacion = DateTime.Now;

                resultado = BusGrupo.GrabarDB(Info, ref mensaje);

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                    this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                    this.Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
                    return true;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean Actualizar_DB()
        {
            try
            {
                bool resultado = false;
                string mensaje = string.Empty;
                Af_Activo_Fijo_Grupo_Info Info = new Af_Activo_Fijo_Grupo_Info();

                Info = Get_Af_Grupo(ref mensaje);
                Info.UsuarioModificacion = param.IdUsuario;
                Info.FechaModificacion = DateTime.Now;

                resultado = BusGrupo.ModificarDB(Info, ref mensaje);

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                    this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                    this.Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
                    return true;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean Anular_DB()
        {
            try
            {
                if (Info_Grupo.estado != "I")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) + " Grupo de Activo Fijo " + txtId_Af_Grupo.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        bool resultado = false;
                        string mensaje = string.Empty;
                        Af_Activo_Fijo_Grupo_Info Info = new Af_Activo_Fijo_Grupo_Info();

                        Info = Get_Af_Grupo(ref mensaje);
                        Info.UsuarioAnulacion = param.IdUsuario;
                        Info.FechaAnulacion = DateTime.Now;
                        resultado = BusGrupo.AnularDB(Info, ref mensaje);

                        if (resultado == true)
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                            return true;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + mensaje + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }

                    }
                    else
                        return false;
                }
                else
                {
                    MessageBox.Show("El Periodo Lectivo " + txtId_Af_Grupo.Text.Trim() + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Guardar_Datos()
        {
            try
            {
                Boolean respuesta = false;
                if (txtNombre_Af_Grupo.Text != "")
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            respuesta = Grabar_DB();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            respuesta = Actualizar_DB();
                            break;
                    }
                }
                return respuesta;
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Eventos menu

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (Guardar_Datos())
                Close();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (Guardar_Datos())
                Limpiar();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            if (Anular_DB())
                Close();
        }

        private void frmAf_Activo_Fijo_Grupo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        lblAnulado.Visible = false;
                        chkEstado.Enabled = false;
                        chkEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Cargar_Datos();
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Cargar_Datos();
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Cargar_Datos();
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
