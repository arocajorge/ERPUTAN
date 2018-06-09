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
    public partial class FrmAcaCatalogoTipo_Mant : Form
    {

        Aca_CatalogoTipo_Bus BusCatTipo = new Aca_CatalogoTipo_Bus();
        Aca_CatalogoTipo_Info InfoCatalogoTipo = new Aca_CatalogoTipo_Info();
        Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_FrmAcaCatalogoTipoMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaCatalogoTipoMant_FormClosing event_FrmAcaCatalogo_Mant_FormClosing;

        #region "Set"
        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion_)
        {
            try
            {
                Accion = Accion_;
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

        public void Set_Info(Aca_CatalogoTipo_Info InfoCatalogoTipo_)
        {
            try
            {
                InfoCatalogoTipo = InfoCatalogoTipo_;

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
        public Aca_CatalogoTipo_Info Get_Info(ref string mensaje)
        {
            try
            {
                InfoCatalogoTipo.Descripcion = txt_descripcion.Text;
                InfoCatalogoTipo.IdTipoCatalogo = txt_codigo.Text;
                InfoCatalogoTipo.IdUsuario = param.IdUsuario;
                InfoCatalogoTipo.nom_pc = param.nom_pc;
                InfoCatalogoTipo.ip = param.ip;

                if (chkEstado.Checked == true)
                {
                    InfoCatalogoTipo.estado = "A";
                }
                else
                {
                    InfoCatalogoTipo.estado = "I";
                }

                return InfoCatalogoTipo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return InfoCatalogoTipo;
            }
        }
        #endregion

        #region "CargarDatos"

        void Cargar_controles()
        {
            try
            {
                txt_codigo.Text = InfoCatalogoTipo.IdTipoCatalogo;
                txt_descripcion.Text = InfoCatalogoTipo.Descripcion;

                if (InfoCatalogoTipo.estado == "I")
                {
                    ucGe_Menu.Enabled_bntAnular = false;
                    lblEstado.Visible = true;
                    chkEstado.Checked = false;
                }
                else
                {
                    lblEstado.Visible = false;
                    chkEstado.Checked = true;
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
        public FrmAcaCatalogoTipo_Mant()
        {
            InitializeComponent();
            event_FrmAcaCatalogo_Mant_FormClosing += FrmAcaCatalogoTipo_Mant_event_FrmAcaCatalogo_Mant_FormClosing;
        }

        private void Limpiar()
        {
            try
            {
                txt_descripcion.Text = "";
                txt_codigo.Text = "";
                chkEstado.Checked = false;
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

        private Boolean validaciones()
        {
            try
            {
                if (txt_codigo.EditValue == null || txt_codigo.Text.Trim() == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " Id Catalogo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_codigo.Focus();
                    return false;
                }

                if (txt_descripcion.EditValue == null || txt_descripcion.Text.Trim() == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_descripcion.Focus();
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

        public void BloquearDatos()
        {
            try
            {
                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu.Visible_btnGuardar = false;

                txt_codigo.Enabled = false;
                txt_descripcion.Enabled = false;
                chkEstado.Checked = false;
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


        #region "Eventos"

        private void FrmAcaCatalogoTipo_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                Limpiar();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;


                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        BloquearDatos();

                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Cargar_controles();
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();
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
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void FrmAcaCatalogoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAcaCatalogo_Mant_FormClosing(sender, e);
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

        void FrmAcaCatalogoTipo_Mant_event_FrmAcaCatalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

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


        #region "Grabar,Actualizar,Eliminar"
        public bool guardarDatos()
        {
            bool resultado = false;
            try
            {
                if (validaciones())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            resultado = Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            resultado = Actualizar();
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
            return resultado;
        }

        private bool Grabar()
        {
            try
            {
                Aca_CatalogoTipo_Info infoCatalogoTipo = new Aca_CatalogoTipo_Info();
                Aca_CatalogoTipo_Bus negCatalogoTipo = new Aca_CatalogoTipo_Bus();

                string mensaje = string.Empty;
                infoCatalogoTipo = Get_Info(ref mensaje);

                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                infoCatalogoTipo.IdUsuarioUltMod = param.IdUsuario;
                bool resultado = negCatalogoTipo.GrabarDB(infoCatalogoTipo, ref mensaje);

                if (resultado == true)
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

        private bool Actualizar()
        {
            try
            {
                Aca_CatalogoTipo_Bus negCatalogo = new Aca_CatalogoTipo_Bus();
                Aca_CatalogoTipo_Info infoCatalogoTipo = new Aca_CatalogoTipo_Info();
                string mensaje = string.Empty;

                infoCatalogoTipo = Get_Info(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }
                bool resultado = negCatalogo.ActualizarDB(infoCatalogoTipo, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el catalogo: " + txt_codigo.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (InfoCatalogoTipo.estado != "I")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) + " catálogo # " + txt_codigo.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        string motiAnulacion = fr.motivoAnulacion;


                        Aca_CatalogoTipo_Bus negCatalogoTipo = new Aca_CatalogoTipo_Bus();
                        Aca_CatalogoTipo_Info infoCatalogoTipo = new Aca_CatalogoTipo_Info();
                        string mensaje = string.Empty;

                        infoCatalogoTipo = Get_Info(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        infoCatalogoTipo.MotiAnula = motiAnulacion;
                        infoCatalogoTipo.IdUsuarioUltAnu = param.IdUsuario;
                        bool resultado = negCatalogoTipo.EliminarDB(infoCatalogoTipo, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " el catalogo: " + txt_codigo.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("El catálogo # : " + txt_codigo.Text + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            bool resultado = guardarDatos();
            if (resultado)
            {
                Close();
            }
        }




    }
}
