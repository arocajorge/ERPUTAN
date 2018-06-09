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
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaSede_Mant : Form
    {
        #region "Variables"
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Aca_Sede_Info SedeInfo = new Aca_Sede_Info();
        int IdInstitucion;
        public delegate void delegate_FrmAcaSede_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaSede_Mant_FormClosing event_FrmAcaSede_Mant_FormClosing;
        #endregion

        public FrmAcaSede_Mant()
        {
            InitializeComponent();
            event_FrmAcaSede_Mant_FormClosing+=FrmAcaSede_Mant_event_FrmAcaSede_Mant_FormClosing;
        }

        void FrmAcaSede_Mant_event_FrmAcaSede_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
        
        }



        private void FrmAcaSede_Mant_Load(object sender, EventArgs e)
        {
            try
            {          
            CargarComboInstitucion();
            CargarDatos();

         
            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:

                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Enabled_bntImprimir = false;
                    chkActivo.Checked = true;
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
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Sede(Aca_Sede_Info info)
        {
            try
            {
                SedeInfo = info;
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
        public Aca_Sede_Info GetSede(ref string mensaje)
        {
            try
            {
                SedeInfo = new Aca_Sede_Info();
                SedeInfo.IdInstitucion = IdInstitucion;
                SedeInfo.IdSede = string.IsNullOrEmpty(txtIdSede.Text) ? 0 : Convert.ToInt16(txtIdSede.Text);
                SedeInfo.CodSede = string.IsNullOrEmpty(txtCodigoSede.Text) ? SedeInfo.IdSede.ToString() : txtCodigoSede.Text.Trim();
                SedeInfo.DescripcionSede = txtDescripcion.Text.Trim();
                SedeInfo.IdInstitucion = Convert.ToInt16(cmbInstitucion.EditValue);
                SedeInfo.UsuarioModificacion = param.IdUsuario;
                SedeInfo.UsuarioCreacion = param.IdUsuario;
                SedeInfo.UsuarioAnulacion = param.IdUsuario;
                SedeInfo.IdEmpresa = param.IdEmpresa;
                SedeInfo.IdSucursal = ucGe_Sucursal_combo1.Get_IdSucursal();


                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkActivo.Checked = true;
                }

                SedeInfo.Estado = (chkActivo.Checked == true) ? "A" : "I";
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
            return SedeInfo;
        }
        #endregion

        #region "Cargar Datos"
        private void CargarComboInstitucion()
        {
            try
            {
                Aca_Institucion_Bus neg = new Aca_Institucion_Bus();
                List<Aca_Institucion_Info> lista = new List<Aca_Institucion_Info>();
                lista = neg.Get_List_Institucion(param.IdEmpresa);
                cmbInstitucion.Properties.DataSource = lista;
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

        private void CargarDatos()
        {
            try
            {
                txtIdSede.Text = "0";
                cmbInstitucion.EditValue = SedeInfo.IdInstitucion;
                
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    txtIdSede.Text = SedeInfo.IdSede.ToString();
                    txtDescripcion.Text = SedeInfo.DescripcionSede;
                    txtCodigoSede.Text = SedeInfo.CodSede;
                }

                chkActivo.Checked = (SedeInfo.Estado == "A") ? true : (SedeInfo.Estado == null) ? true:false;
                if (SedeInfo.Estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (SedeInfo.Estado != null)
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
        #region "Grabar,Actualizar,Eliminar"
        public void Grabar()
        {
            try
            {
                Aca_Sede_Info infoSede = new Aca_Sede_Info();

                string mensaje = string.Empty;
                int id = 0;

                infoSede = GetSede(ref mensaje);
                Aca_Sede_Bus neg = new Aca_Sede_Bus();
                bool resultado = neg.GrabarDB(infoSede, ref id, ref mensaje);
                txtIdSede.Text = id.ToString();

                if (resultado == true)
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

        public void Actualizar()
        {
            try
            {
                Aca_Sede_Bus neg = new Aca_Sede_Bus();
                Aca_Sede_Info infoSede = new Aca_Sede_Info();
                string mensaje = string.Empty;

                infoSede = GetSede(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool resultado = neg.ActualizarDB(infoSede, ref mensaje);
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
                if (SedeInfo.Estado != "I")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Está_seguro_que_desea_anular_la) +" Sede #:" + txtIdSede.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();   
                        
                        Aca_Sede_Bus neg = new Aca_Sede_Bus();
                        Aca_Sede_Info sedInfo = new Aca_Sede_Info();
                        string mensaje = string.Empty;

                        sedInfo = GetSede(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        sedInfo.UsuarioAnulacion = param.IdUsuario;
                        sedInfo.MotivoAnulacion = fr.motivoAnulacion;
                        bool resultado = neg.EliminarDB(sedInfo, ref mensaje);
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
                    MessageBox.Show("La sede #:"+ txtIdSede.Text.Trim() + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulada), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public bool validaciones()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " Descripción ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(cmbInstitucion.EditValue.ToString()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Institución ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbInstitucion.Focus();
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

        #region "Eventos"
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
            guardarDatos(); Close();
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }       

        private void FrmAcaSede_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FrmAcaSede_Mant_event_FrmAcaSede_Mant_FormClosing(sender, e);
                event_FrmAcaSede_Mant_FormClosing(sender, e);
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
    }
}
