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
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaParalelo_Mant : Form
    {
        #region "Variables"
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Paralelo_Info paraleloInfo = new Aca_Paralelo_Info();

        public delegate void delegate_FrmAca_Paralelo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAca_Paralelo_Mant_FormClosing event_FrmAca_Paralelo_Mant_FormClosing;
        #endregion


        public FrmAcaParalelo_Mant()
        {
            InitializeComponent();
            event_FrmAca_Paralelo_Mant_FormClosing += FrmAcaParalelo_Mant_event_FrmAca_Paralelo_Mant_FormClosing;
        }

        void FrmAcaParalelo_Mant_event_FrmAca_Paralelo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #region "CargoCombos"

        public void CargarComboJornada() {
            try
            {
                  //Jornada
                Aca_Jornada_Bus negJ = new Aca_Jornada_Bus();
                List<Aca_Jornada_Info> listaJornada = new List<Aca_Jornada_Info>();
                listaJornada = negJ.Get_List_Jornada(param.IdInstitucion, paraleloInfo.IdSede);
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
                listaSeccion = neg.Get_List_Seccion(param.IdInstitucion, paraleloInfo.IdJornada);
                cmbSeccion.Properties.DataSource = listaSeccion;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void CargarComboCurso() {
            try
            {                
                //Curso
                Aca_Curso_Bus negC = new Aca_Curso_Bus();
                List<Aca_Curso_Info> listaCur = new List<Aca_Curso_Info>();
                listaCur = negC.Get_List_Curso(param.IdInstitucion, paraleloInfo.IdSeccion);
                cmbCurso.Properties.DataSource = listaCur;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void CargarCombo()
        {
            try
            {
                //Institución
                Aca_Institucion_Bus negIns = new Aca_Institucion_Bus();
                List<Aca_Institucion_Info> listaI = new List<Aca_Institucion_Info>();
                listaI = negIns.Get_List_Institucion(param.IdEmpresa);
                cmbInstitucion.Properties.DataSource = listaI;
                //Sede
                Aca_Sede_Bus negSed = new Aca_Sede_Bus();
                List<Aca_Sede_Info> listaS = new List<Aca_Sede_Info>();
                listaS = negSed.Get_List_Sede(paraleloInfo.IdInstitucion);
                cmbSede.Properties.DataSource = listaS;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        private void FrmAcaParalelo_Load(object sender, EventArgs e)
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

        public void set_Paralelo(Aca_Paralelo_Info info)
        {
            try
            {
                paraleloInfo = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Get"
        public Aca_Paralelo_Info GetParalelo(ref string mensaje)
        {
            try
            {
                paraleloInfo = new Aca_Paralelo_Info();
                paraleloInfo.IdInstitucion = param.IdInstitucion;
                paraleloInfo.IdParalelo= string.IsNullOrEmpty(txtIdParalelo.Text) ? 0 : Convert.ToInt16(txtIdParalelo.Text);
                paraleloInfo.CodParalelo = string.IsNullOrEmpty(txtCodParalelo.Text) ? paraleloInfo.IdParalelo.ToString() : txtCodParalelo.Text.Trim();
                paraleloInfo.DescripcionParalelo = txtDescripcion.Text;
                paraleloInfo.IdCurso = Convert.ToInt16(cmbCurso.EditValue);
                paraleloInfo.UsuarioCreacion = param.IdUsuario;
                paraleloInfo.UsuarioModificacion = param.IdUsuario;
                paraleloInfo.UsuarioAnulacion = param.IdUsuario;

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkActivo.Checked = true;
                }

                paraleloInfo.Estado = (chkActivo.Checked == true) ? "A" : "I";
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
                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return paraleloInfo;
        }
        #endregion


        #region "Cargar Datos"
        public void CargarDatos()
        {
            try
            {

                txtIdParalelo.Text = "0";               

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    txtIdParalelo.Text = paraleloInfo.IdParalelo.ToString();
                    txtDescripcion.Text = paraleloInfo.DescripcionParalelo;
                    txtCodParalelo.Text = paraleloInfo.CodParalelo;
                }

                cmbCurso.EditValue = paraleloInfo.IdCurso;                
                cmbInstitucion.EditValue = paraleloInfo.IdInstitucion;
                cmbJornada.EditValue = paraleloInfo.IdJornada;
                cmbSeccion.EditValue = paraleloInfo.IdSeccion;
                cmbSede.EditValue = paraleloInfo.IdSede;


                chkActivo.Checked = (paraleloInfo.Estado == "A") ? true : false;
                if (paraleloInfo.Estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (paraleloInfo.Estado != null)
                    {
                        lblAnulado.Visible = true;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region "Proceso"
        public void Grabar()
        {
            try
            {
                Aca_Paralelo_Info infoSeccion = new Aca_Paralelo_Info();

                string mensaje = string.Empty;
                int id = 0;

                paraleloInfo = GetParalelo(ref mensaje);
                Aca_Paralelo_Bus neg = new Aca_Paralelo_Bus();
                bool resultado = neg.GrabarDB(paraleloInfo, ref id, ref mensaje);
                txtIdParalelo.Text = id.ToString();

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, " Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Actualizar()
        {
            try
            {
                Aca_Paralelo_Bus neg = new Aca_Paralelo_Bus();
                Aca_Paralelo_Info paraleloInf = new Aca_Paralelo_Info();
                string mensaje = string.Empty;

                paraleloInf = GetParalelo(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return;
                }
                bool resultado = neg.ActualizarDB(paraleloInf, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Anular()
        {
            try
            {
                if (paraleloInfo.Estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Paralelo # " + txtIdParalelo.Text.Trim() + " ?", "Anulación de Mantenimiento Paralelo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();   

                        Aca_Paralelo_Bus neg = new Aca_Paralelo_Bus();
                        Aca_Paralelo_Info parInfo = new Aca_Paralelo_Info();
                        string mensaje = string.Empty;

                        parInfo = GetParalelo(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        parInfo.UsuarioAnulacion = param.IdUsuario;
                        parInfo.MotivoAnulacion = fr.motivoAnulacion;
                        bool resultado = neg.EliminarDB(parInfo, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else { 
                
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validaciones()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " Descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus();
                    return false;
                }

                
                if (string.IsNullOrEmpty(cmbInstitucion.EditValue.ToString()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Institución", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbInstitucion.Focus();
                    return false;
                }

                if (cmbSede.EditValue==null || cmbSede.EditValue=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Sede", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbSede.Focus();
                    return false;
                }

                if (cmbJornada.EditValue==null|| cmbJornada.EditValue=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Jornada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbJornada.Focus();
                    return false;
                }

                if (cmbSeccion.EditValue==null|| cmbSeccion.EditValue=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Sección", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbSeccion.Focus();
                    return false;
                }

                if (cmbCurso.EditValue==null || cmbCurso.EditValue=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " curso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbCurso.Focus();
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
        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            guardarDatos();
            Close();
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void cmbSede_EditValueChanged(object sender, EventArgs e)
        {
            paraleloInfo.IdSede = cmbSede.EditValue == null ? 0 : Convert.ToInt16(cmbSede.EditValue);
            CargarComboJornada();
        }

        private void cmbJornada_EditValueChanged(object sender, EventArgs e)
        {
            paraleloInfo.IdJornada = cmbJornada.EditValue == null ? 0 : Convert.ToInt16(cmbJornada.EditValue);
            CargarComboSeccion();
        }

        private void cmbSeccion_EditValueChanged(object sender, EventArgs e)
        {
            paraleloInfo.IdSeccion = cmbSeccion.EditValue == null ? 0 : Convert.ToInt16(cmbSeccion.EditValue);
            CargarComboCurso();
        }

        #endregion 

        private void FrmAcaParalelo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FrmAcaParalelo_Mant_event_FrmAca_Paralelo_Mant_FormClosing(sender, e);
                event_FrmAca_Paralelo_Mant_FormClosing(sender, e);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
