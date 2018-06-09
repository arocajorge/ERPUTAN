using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaSeccion_Mant : Form
    {
        #region "Variable"
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Seccion_Info SeccionInfo = new Aca_Seccion_Info();

        public delegate void delegate_FrmAcaSeccion_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaSeccion_Mant_FormClosing event_FrmAcaSeccion_Mant_FormClosing;        
        

        #endregion

        public FrmAcaSeccion_Mant()
        {
            InitializeComponent();
            event_FrmAcaSeccion_Mant_FormClosing += FrmAcaSeccion_Mant_event_FrmAcaSeccion_Mant_FormClosing;
            
        }

        void FrmAcaSeccion_Mant_event_FrmAcaSeccion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
           
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void set_Accion_In_Controls(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
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

        public void set_Seccion(Aca_Seccion_Info info)
        {
            try
            {
                SeccionInfo = info;
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
        #endregion

        #region "Get"
        public Aca_Seccion_Info Get_Info_Seccion(ref string mensaje)
        {
            try
            {
                SeccionInfo = new Aca_Seccion_Info();
                SeccionInfo.IdSeccion = string.IsNullOrEmpty(txtIdSeccion.Text) ? 0 : Convert.ToInt16(txtIdSeccion.Text);
                SeccionInfo.CodSeccion = txtCodigoSeccion.Text;
                SeccionInfo.DescripcionSeccion = txtDescripcion.Text;
                SeccionInfo.IdJornada = Convert.ToInt32(cmbJornada.EditValue);
                SeccionInfo.UsuarioCreacion = param.IdUsuario;
                SeccionInfo.UsuarioModificacion = param.IdUsuario;
                SeccionInfo.UsuarioAnulacion = param.IdUsuario;

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkActivo.Checked = true;
                }

                SeccionInfo.Estado = (chkActivo.Checked == true) ? "A" : "I";
                if (chkActivo.Checked)
                {
                    lblAnulado.Visible = false;
                }
                else { lblAnulado.Visible = true; }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return SeccionInfo;
        }
        #endregion

        #region "Cargar Datos"
        private void CargarJornada()
        {
            try
            {
                Aca_Jornada_Bus negJ = new Aca_Jornada_Bus();
                List<Aca_Jornada_Info> listaJornada = new List<Aca_Jornada_Info>();
                
                listaJornada = negJ.Get_List_Jornada(param.IdInstitucion, SeccionInfo.IdSede);
                cmbInstitucion.EditValue =  SeccionInfo.IdInstitucion;
                cmbJornada.Properties.DataSource = null;
                cmbJornada.Properties.DataSource = listaJornada;
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

        private void CargarCombo()
        {
            try
            {
                Aca_Institucion_Bus negIns = new Aca_Institucion_Bus();
                List<Aca_Institucion_Info> listaI = new List<Aca_Institucion_Info>();
                listaI = negIns.Get_List_Institucion(param.IdEmpresa);
                cmbInstitucion.Properties.DataSource = listaI;
                Aca_Sede_Bus negSed = new Aca_Sede_Bus();
                List<Aca_Sede_Info> listaS = new List<Aca_Sede_Info>();
                listaS = negSed.Get_List_Sede(SeccionInfo.IdInstitucion);
                cmbSede.Properties.DataSource = listaS;

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

        private void Set_Info_in_Controls()
        {
            try
            {

                txtIdSeccion.Text = "0";               

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    txtIdSeccion.Text = SeccionInfo.IdSeccion.ToString();
                    txtDescripcion.Text = SeccionInfo.DescripcionSeccion;
                    txtCodigoSeccion.Text = SeccionInfo.CodSeccion;                    
                }

                cmbInstitucion.EditValue = SeccionInfo.IdInstitucion;
                cmbSede.EditValue = SeccionInfo.IdSede;
                cmbJornada.EditValue = SeccionInfo.IdJornada;          

                chkActivo.Checked = (SeccionInfo.Estado == "A") ? true : false;
                if (SeccionInfo.Estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (SeccionInfo.Estado != null)
                    {
                        lblAnulado.Visible = true;
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
        #endregion

        #region "Proceso"
        public Boolean Grabar()
        {
            try
            {
                Aca_Seccion_Info infoSeccion = new Aca_Seccion_Info();
                bool resultado = false;

                string mensaje = string.Empty;
                int id = 0;

                infoSeccion = Get_Info_Seccion(ref mensaje);
                Aca_Seccion_Bus neg = new Aca_Seccion_Bus();
                resultado = neg.GrabarDB(infoSeccion, ref id, ref mensaje);
                txtIdSeccion.Text = id.ToString();

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean Actualizar()
        {
            try
            {
                bool resultado = false;



                Aca_Seccion_Bus neg = new Aca_Seccion_Bus();
                Aca_Seccion_Info infoSeccion = new Aca_Seccion_Info();
                string mensaje = string.Empty;

                infoSeccion = Get_Info_Seccion(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = false;
                }

                resultado = neg.ActualizarDB(infoSeccion, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void Anular()
        {
            try
            {
                if (SeccionInfo.Estado != "I")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Está_seguro_que_desea_anular_la) + " Sección # " + txtIdSeccion.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();   
                        
                        Aca_Seccion_Bus neg = new Aca_Seccion_Bus();
                        Aca_Seccion_Info seccionInfo = new Aca_Seccion_Info();
                        string mensaje = string.Empty;

                        seccionInfo = Get_Info_Seccion(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        seccionInfo.MotivoAnulacion = fr.motivoAnulacion;
                        seccionInfo.UsuarioAnulacion = param.IdUsuario;
                        bool resultado = neg.EliminarDB(seccionInfo, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else {
                    MessageBox.Show("La sección #: "+txtIdSeccion.Text.Trim() + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulada), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public Boolean Accion_Guardar()
        {
            Boolean respuesta = false;
            try
            {

                if (validaciones())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            respuesta=Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            respuesta=Actualizar();
                            break;
                    }
                }
                return respuesta;
            }

            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return respuesta;
            }
        }

        public bool validaciones()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show( param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " Descripción ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus();
                    return false;
                }

                if (cmbInstitucion.EditValue == null )
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Institución ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbInstitucion.Focus();
                    return false;
                }

                if (cmbSede.EditValue==null )
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Sede ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbSede.Focus();
                    return false;
                }

                if (cmbJornada.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Jornada ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbJornada.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Accion_Guardar();
            

        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (Accion_Guardar()==true)
            {
                Close();
            }
        }

        private void Set_Accion_in_controls()
        {
            try
            {
                

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        chkActivo.Checked = true;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        Set_Info_in_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        Set_Info_in_Controls();

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        Set_Info_in_Controls();
                        break;
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

        private void FrmAcaSeccion_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == 0) { Accion = Cl_Enumeradores.eTipo_action.grabar; }
                CargarCombo();
                CargarJornada();
                Set_Accion_in_controls();
                
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

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void cmbSede_EditValueChanged(object sender, EventArgs e)
        {
            SeccionInfo.IdSede =  cmbSede.EditValue==null?0:Convert.ToInt16(cmbSede.EditValue);
            CargarJornada();
        }
        #endregion

        private void FrmAcaSeccion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FrmAcaSeccion_Mant_event_FrmAcaSeccion_Mant_FormClosing(sender, e);
                event_FrmAcaSeccion_Mant_FormClosing(sender, e);
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
