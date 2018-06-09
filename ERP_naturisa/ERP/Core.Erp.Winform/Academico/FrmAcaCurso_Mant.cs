using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaCurso_Mant : Form
    {
        #region "Variables"

        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Curso_Info CursoInfo = new Aca_Curso_Info();

        public delegate void delegate_FrmAca_Curso_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAca_Curso_Mant_FormClosing event_FrmAca_Curso_Mant_FormClosing;
        #endregion

        public FrmAcaCurso_Mant()
        {
            InitializeComponent();
            event_FrmAca_Curso_Mant_FormClosing += FrmAcaCurso_Mant_event_FrmAca_Curso_Mant_FormClosing;
        }

        void FrmAcaCurso_Mant_event_FrmAca_Curso_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FrmAcaCurso_Mant_Load(object sender, EventArgs e)
        {

            CargarCombo();
            CargarDatos();
            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Enabled_bntImprimir = false;
                    this.chkActivo.Checked = true;

                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucGe_Menu.Enabled_bntAnular = false;


                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_btnGuardar = false;

                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_btnGuardar = false;
                    ucGe_Menu.Enabled_bntAnular = false;

                    break;
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
            }
        }

        public void set_curso(Aca_Curso_Info info)
        {
            try
            {
                CursoInfo = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Get"
        public Aca_Curso_Info GetCurso(ref string mensaje)
        {
            try
            {
                CursoInfo = new Aca_Curso_Info();
                CursoInfo.IdInstitucion = param.IdInstitucion;
                CursoInfo.IdCurso = string.IsNullOrEmpty(txtIdCurso.Text) ? 0 : Convert.ToInt16(txtIdCurso.Text);
                //CursoInfo.CodCurso = string.IsNullOrEmpty(txtCodCurso.Text) ? txtIdCurso.Text : txtCodCurso.Text;
                CursoInfo.CodCurso = txtCodCurso.Text;
                CursoInfo.DescripcionCurso = txtDescripcion.Text;
                CursoInfo.IdSeccion = Convert.ToInt16(cmbSeccion.EditValue.ToString());
                CursoInfo.UsuarioAnulacion = param.IdUsuario;
                CursoInfo.UsuarioCreacion = param.IdUsuario;
                CursoInfo.UsuarioModificacion = param.IdUsuario;

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkActivo.Checked = true;
                }

                CursoInfo.Estado = (chkActivo.Checked == true) ? "A" : "I";
                if (chkActivo.Checked)
                {
                    lblAnulado.Visible = false;
                }
                else { lblAnulado.Visible = true; }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return CursoInfo;
        }
        #endregion

        #region "Cargar Datos"
        public void CargarComboJornada() {
            try
            {
                //Jornada
                Aca_Jornada_Bus negJ = new Aca_Jornada_Bus();
                List<Aca_Jornada_Info> listaJornada = new List<Aca_Jornada_Info>();

                listaJornada = negJ.Get_List_Jornada(param.IdInstitucion, Convert.ToInt16( cmbSede.EditValue));
                cmbJornada.Properties.DataSource = listaJornada;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public void CargarComboSeccion() {
            try
            {
                //Sección
                Aca_Seccion_Bus neg = new Aca_Seccion_Bus();
                List<Aca_Seccion_Info> listaSeccion = new List<Aca_Seccion_Info>();
                
                listaSeccion = neg.Get_List_Seccion(param.IdInstitucion, Convert.ToInt16( cmbJornada.EditValue));
                cmbSeccion.Properties.DataSource = listaSeccion;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void CargarCombo() {
            try
            {
                //Institución
                Aca_Institucion_Bus negIns = new Aca_Institucion_Bus();
                List<Aca_Institucion_Info> listaI = new List<Aca_Institucion_Info>();
                listaI= negIns.Get_List_Institucion(param.IdEmpresa);
                cmbInstitucion.Properties.DataSource = listaI;
                //Sede
                Aca_Sede_Bus negSed = new Aca_Sede_Bus();
                List<Aca_Sede_Info> listaS = new List<Aca_Sede_Info>();
                listaS = negSed.Get_List_Sede(CursoInfo.IdInstitucion);
                cmbSede.Properties.DataSource = listaS; 
              
           
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

        public void CargarDatos()
        {
            try
            {
                txtIdCurso.Text = "0";                

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    txtIdCurso.Text = CursoInfo.IdCurso.ToString();
                    txtCodCurso.Text = string.IsNullOrEmpty(CursoInfo.CodCurso) ? CursoInfo.IdCurso.ToString() : CursoInfo.CodCurso.ToString();
                    txtDescripcion.Text = CursoInfo.DescripcionCurso;                   
                }

                cmbInstitucion.EditValue = CursoInfo.IdInstitucion;
                cmbJornada.EditValue = CursoInfo.IdJornada;
                cmbSeccion.EditValue = CursoInfo.IdSeccion;
                cmbSede.EditValue = CursoInfo.IdSede;

                chkActivo.Checked = (CursoInfo.Estado == "A") ? true : false;
                if (CursoInfo.Estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (CursoInfo.Estado != null)
                    {
                        lblAnulado.Visible = true;
                    }
                }
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

        #region "Proceso"
        public void Grabar()
        {
            try
            {
                Aca_Curso_Info CursoInfo = new Aca_Curso_Info();

                string mensaje = string.Empty;
                int id = 0;

                CursoInfo = GetCurso(ref mensaje);
                Aca_Curso_Bus neg = new Aca_Curso_Bus();
                bool resultado = neg.GrabarDB(CursoInfo, ref id, ref mensaje);
                txtIdCurso.Text = id.ToString();

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, " Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualizar()
        {
            try
            {
                Aca_Curso_Bus neg = new Aca_Curso_Bus();
                Aca_Curso_Info cursoInfo = new Aca_Curso_Info();
                string mensaje = string.Empty;

                cursoInfo = GetCurso(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return;
                }
                bool resultado = neg.ActualizarDB(cursoInfo, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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


        private void Anular()
        {
            try
            {
                if (CursoInfo.Estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el curso # " + txtIdCurso.Text.Trim() + " ?", "Anulación de Mantenimiento Curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();                       

                        Aca_Curso_Bus neg = new Aca_Curso_Bus();
                        Aca_Curso_Info cursoInfo = new Aca_Curso_Info();
                        string mensaje = string.Empty;

                        cursoInfo = GetCurso(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        cursoInfo.MotivoAnulacion = fr.motivoAnulacion; 
                        cursoInfo.UsuarioAnulacion = param.IdUsuario;
                        bool resultado = neg.EliminarDB(cursoInfo, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else {
                    MessageBox.Show("El curso #: "+txtIdCurso.Text.Trim()+" ya se encuentra anulado.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void guardarDatos()
        {
            try
            {
                if (validaciones())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            Actualizar();
                            break;
                    }
                }
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        public bool validaciones()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Digite Descripción", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(cmbInstitucion.EditValue.ToString()))
                {
                    MessageBox.Show("Seleccione una Institución", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbInstitucion.Focus();
                    return false;
                }
                if (cmbSede.EditValue==null || cmbSede.EditValue=="")
                {
                    MessageBox.Show("Seleccione una Sede", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbSede.Focus();
                    return false;
                }

                if (cmbJornada.EditValue==null|| cmbJornada.EditValue=="")
                {
                    MessageBox.Show("Seleccione una Jornada", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbJornada.Focus();
                    return false;
                }

                if (cmbSeccion.EditValue==null|| cmbSeccion.EditValue=="")
                {
                    MessageBox.Show("Seleccione una Sección", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbSeccion.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region "Evento"
        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            guardarDatos();
            Close();
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }
        
        private void cmbSede_EditValueChanged(object sender, EventArgs e)
        {
            CursoInfo.IdSede = cmbSede.EditValue == null ? 0 : Convert.ToInt16(cmbSede.EditValue);
            CargarComboJornada();
        }

        private void cmbJornada_EditValueChanged(object sender, EventArgs e)
        {
            CursoInfo.IdJornada = cmbJornada.EditValue == null ? 0 : Convert.ToInt16(cmbJornada.EditValue);
            CargarComboSeccion();
        }

        private void FrmAcaCurso_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAca_Curso_Mant_FormClosing(sender, e);
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

        


    }
}
