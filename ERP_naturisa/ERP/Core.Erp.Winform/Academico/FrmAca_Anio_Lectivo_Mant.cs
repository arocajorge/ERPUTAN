using Core.Erp.Business.Academico;
using Core.Erp.Business.General;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Anio_Lectivo_Mant : Form
    {

        #region Variables
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Anio_Lectivo_Info Info_Anio_Lectivo = new Aca_Anio_Lectivo_Info();
        Aca_Anio_Lectivo_Bus Bus_Anio_Lectivo = new Aca_Anio_Lectivo_Bus();

        public delegate void delegate_FrmAca_Anio_Lectivo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAca_Anio_Lectivo_Mant_FormClosing event_FrmAca_Anio_Lectivo_Mant_FormClosing;
        #endregion

        public FrmAca_Anio_Lectivo_Mant()
        {
            InitializeComponent();
            event_FrmAca_Anio_Lectivo_Mant_FormClosing += FrmAca_Anio_Lectivo_Mant_event_FrmAca_Anio_Lectivo_Mant_FormClosing;
        }

        void FrmAca_Anio_Lectivo_Mant_event_FrmAca_Anio_Lectivo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void FrmAca_Anio_Lectivo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAca_Anio_Lectivo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #region "Set"
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

        public void set_PeriodoLectivo(Aca_Anio_Lectivo_Info info)
        {
            try
            {
                Info_Anio_Lectivo = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Cargar Datos"
        public void CargarDatosPeriodoLectivo()
        {
            try
            {
                txtIdAnioLectivo.Text = Info_Anio_Lectivo.IdAnioLectivo.ToString();
                txtDescripcion.Text = Info_Anio_Lectivo.Descripcion;
                dtFechaFinalClase.DateTime = Info_Anio_Lectivo.FechaFin;
                dtFechaInicioClase.DateTime = Info_Anio_Lectivo.FechaInicio;
                lblAnulado.Visible = (Info_Anio_Lectivo.Estado == "A" || string.IsNullOrEmpty(Info_Anio_Lectivo.Estado)) ? lblAnulado.Visible = false : lblAnulado.Visible = true;

                if (string.IsNullOrEmpty(Info_Anio_Lectivo.Estado) || Info_Anio_Lectivo.Estado == "A")
                {
                    chkActivo.Checked = true;
                }
                else { chkActivo.Checked = false; }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region  "Get"
        public Aca_Anio_Lectivo_Info GetPeriodoLectivo(ref string mensaje)
        {
            Aca_Anio_Lectivo_Info infoPeriodo = new Aca_Anio_Lectivo_Info();
            try
            {
                infoPeriodo.IdInstitucion = param.IdInstitucion;
                infoPeriodo.IdAnioLectivo = Convert.ToInt16(txtIdAnioLectivo.Text.Trim());
                infoPeriodo.Descripcion = txtDescripcion.Text.Trim();
                infoPeriodo.FechaFin = Convert.ToDateTime(dtFechaFinalClase.Text.Trim());
                infoPeriodo.FechaInicio = Convert.ToDateTime(dtFechaInicioClase.Text.Trim());
                infoPeriodo.Estado = chkActivo.Checked == true ? "A" : "I";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return infoPeriodo;
        }
        #endregion

        #region "Eventos"
        private void FrmAca_Anio_Lectivo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        chkActivo.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        CargarDatosPeriodoLectivo();
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        CargarDatosPeriodoLectivo();
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        CargarDatosPeriodoLectivo();
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        txtIdAnioLectivo.Properties.ReadOnly = true;
                        txtDescripcion.Properties.ReadOnly = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtFechaFinalClase_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtFechaFinalClase.EditValue) < Convert.ToDateTime(dtFechaInicioClase.EditValue))
            {
                //MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.msj0046_fecha_final_de_clase_debe_ser_mayor_que_fecha_inicial), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtFechaFinalClase.Focus();
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if(guardarDatos())
            Close();
        }

        private void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();
        }


        private void ucGe_Menu_Superior_Mant_event_btnAnular_Click(object sender, EventArgs e)
        {
            if(Eliminar())
            Close();
        }
        #endregion

        #region "Grabar,Actualizar,Eliminar"
        private Boolean guardarDatos()
        {
            try
            {
                Boolean respuesta = false;
                if (Validaciones())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            respuesta = Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            respuesta = Actualizar();
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

        private Boolean Grabar()
        {
            try
            {
                string mensaje = string.Empty;
                Aca_Anio_Lectivo_Info infoAnio = new Aca_Anio_Lectivo_Info();
                Bus_Anio_Lectivo = new Aca_Anio_Lectivo_Bus();

                infoAnio = GetPeriodoLectivo(ref mensaje);
                infoAnio.FechaCreacion = DateTime.Now;
                infoAnio.UsuarioCreacion = param.IdUsuario;
                bool resultado = Bus_Anio_Lectivo.GrabarDB(infoAnio, ref mensaje);
                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
                    this.ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
                    this.Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
                    return true;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) +":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private Boolean Actualizar()
        {
            try
            {
                string mensaje = string.Empty;
                Aca_Anio_Lectivo_Info infoAnio = new Aca_Anio_Lectivo_Info();
                Bus_Anio_Lectivo = new Aca_Anio_Lectivo_Bus();

                infoAnio = GetPeriodoLectivo(ref mensaje);
                infoAnio.UsuarioModificacion = param.IdUsuario;
                infoAnio.FechaModificacion = DateTime.Now;
                bool resultado = Bus_Anio_Lectivo.ActualizarDB(infoAnio, ref mensaje);
                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
                    this.ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
                    this.Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
                    return true;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private Boolean Eliminar()
        {
            try
            {
                if (Info_Anio_Lectivo.Estado != "I")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) + " Periodo Lectivo " + txtIdAnioLectivo.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        string mensaje = string.Empty;
                        Aca_Anio_Lectivo_Info infoAnio = new Aca_Anio_Lectivo_Info();
                        Bus_Anio_Lectivo = new Aca_Anio_Lectivo_Bus();

                        infoAnio = GetPeriodoLectivo(ref mensaje);
                        infoAnio.UsuarioAnulacion = param.IdUsuario;
                        infoAnio.MotivoAnulacion = fr.motivoAnulacion;
                        bool resultado = Bus_Anio_Lectivo.EliminarDB(infoAnio, ref mensaje);
                        if (resultado == true)
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu_Superior_Mant.Visible_btnGuardar = false;
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
                    MessageBox.Show("El Periodo Lectivo "  + txtIdAnioLectivo.Text.Trim() + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void Limpiar()
        {
            txtIdAnioLectivo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            dtFechaFinalClase.Text = null;
            dtFechaInicioClase.Text = null;
            chkActivo.Checked = true;
        }
        #endregion

        #region "Validaciones"
        private bool Validaciones()
        {
            bool correcto = true;
            if (dtFechaFinalClase.EditValue == null)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " fecha final ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtFechaFinalClase.Focus();
                return false;
            }

            if (dtFechaInicioClase.EditValue == null)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " fecha inicial ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtFechaInicioClase.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.EditValue.ToString()))
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " descripción ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return  false;
            }

            if (string.IsNullOrEmpty(txtIdAnioLectivo.EditValue.ToString()))
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " periodo lectivo ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdAnioLectivo.Focus();
                return false;
            }

            if (chkActivo.Checked == false)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " active el estado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                chkActivo.Focus();
                return false;
            }
            return correcto;
        }
        #endregion
    }
}
