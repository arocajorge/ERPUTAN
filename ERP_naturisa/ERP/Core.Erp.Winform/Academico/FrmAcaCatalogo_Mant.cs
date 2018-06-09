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
    public partial class FrmAcaCatalogo_Mant : Form
    {
        #region "Variables"
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Aca_Catalogo_Bus BusCatalogo = new Aca_Catalogo_Bus();
        Aca_Catalogo_Info InfoCatalogo = new Aca_Catalogo_Info();
        Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public delegate void delegate_FrmAcaCatalogo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaCatalogo_Mant_FormClosing event_FrmAcaCatalogo_Mant_FormClosing;
        #endregion

        #region "Set"
        //metodo para grabar la informacion del enumerador
        public void Set_Accion(Cl_Enumeradores.eTipo_action accion)
        {
            try
            {
                Accion = accion;
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
        public void Set_Info(Aca_Catalogo_Info InfoCatalogo_)
        {
            try
            {
                InfoCatalogo = InfoCatalogo_;
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
        //metodo para obtener la informacion
        public Aca_Catalogo_Info Get_Info(ref string mensaje)
        {
            try
            {
                InfoCatalogo.IdCatalogo = txtIdCatalogo.Text;
                InfoCatalogo.IdTipoCatalogo = cmbTipoCatalogo.EditValue.ToString();
                InfoCatalogo.Descripcion = txtDescripcion.Text;
                InfoCatalogo.Orden = Convert.ToInt16( txtOrden.Text);
                if (chkbEstado.Checked == true)
                {
                    InfoCatalogo.Estado = "A";
                }
                else
                {
                    InfoCatalogo.Estado = "I";
                }
                return InfoCatalogo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return InfoCatalogo;
            }
        }
        #endregion
        //metodo para grabar la informacion       
      
        #region "Proceso"
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
                          resultado=  Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                          resultado=  Actualizar();
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
                Aca_Catalogo_Info infoCatalogo = new Aca_Catalogo_Info();
                Aca_Catalogo_Bus negCatalogo = new Aca_Catalogo_Bus();
                        
                string mensaje = string.Empty;
                infoCatalogo = Get_Info(ref mensaje);

                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                        
                infoCatalogo.IdUsuarioUltMod = param.IdUsuario;
                bool resultado = negCatalogo.GrabarDB(infoCatalogo,ref mensaje);                        

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) +":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Aca_Catalogo_Bus negCatalogo = new Aca_Catalogo_Bus();
                Aca_Catalogo_Info infoCatalogo = new Aca_Catalogo_Info();
                string mensaje = string.Empty;

                infoCatalogo = Get_Info(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }
                bool resultado = negCatalogo.ActualizarDB(infoCatalogo, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el catalogo: " + txtIdCatalogo.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnGuardar = false;
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
                if (InfoCatalogo.Estado != "I")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) +" catálogo # " + txtIdCatalogo.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        string motiAnulacion = fr.motivoAnulacion;


                        Aca_Catalogo_Bus negCatalogo = new Aca_Catalogo_Bus();
                        Aca_Catalogo_Info infoCatalogo = new Aca_Catalogo_Info();
                        string mensaje = string.Empty;

                        infoCatalogo = Get_Info(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        InfoCatalogo.MotiAnula = motiAnulacion;
                        InfoCatalogo.IdUsuarioUltAnu = param.IdUsuario;
                        bool resultado = negCatalogo.EliminarDB(infoCatalogo, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) +" el catalogo: " + txtIdCatalogo.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu_Superior_Catalogo_Mant.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else {
                    MessageBox.Show("El catálogo # : " + txtIdCatalogo.Text + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                
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

        public void CargarComboCatalogoTipo()
        {
            try
            {
                Aca_CatalogoTipo_Bus neg = new Aca_CatalogoTipo_Bus();
                List<Aca_CatalogoTipo_Info> lista = new List<Aca_CatalogoTipo_Info>();
                lista = neg.Get_List_CatalogoTipo();
                cmbTipoCatalogo.Properties.DataSource = lista;

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

        void Cargar_Controles()
        {
            try
            {
                txtIdCatalogo.Text = InfoCatalogo.IdCatalogo;
                cmbTipoCatalogo.EditValue = InfoCatalogo.IdTipoCatalogo;
                txtDescripcion.Text = InfoCatalogo.Descripcion;
                txtOrden.Text = InfoCatalogo.Orden.ToString();

                if (InfoCatalogo.Estado == "I")
                {
                    ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntAnular = false;
                    lblEstado.Visible = true;
                    chkbEstado.Checked = false;
                }
                else
                {
                    lblEstado.Visible = false;
                    chkbEstado.Checked = true;
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

        private void Limpiar()
        {
            try
            {
                //encerar todos los txt del formulario
                //
                cmbTipoCatalogo.Text = "";
                txtDescripcion.Text = "";
                chkbEstado.Checked = false;
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
                if (txtIdCatalogo.EditValue == null|| txtIdCatalogo.Text.Trim()=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) +" Id Catalogo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdCatalogo.Focus();
                    return false;
                }

                if (txtDescripcion.EditValue == null || txtDescripcion.Text.Trim()=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) +" descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus();
                    return false;
                }

                if (txtOrden.EditValue == null || txtOrden.Text.Trim()=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " orden", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtOrden.Focus();
                    return false;
                }

                if (cmbTipoCatalogo.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " tipo catalogo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoCatalogo.Focus();
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
                ucGe_Menu_Superior_Catalogo_Mant.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu_Superior_Catalogo_Mant.Visible_btnGuardar = false;
                
                txtIdCatalogo.Enabled = false;
                cmbTipoCatalogo.Enabled = false;
                txtDescripcion.Enabled = false;
                chkbEstado.Checked = false;
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

        #region "Eventos"
        public FrmAcaCatalogo_Mant()
        {
            InitializeComponent();
            event_FrmAcaCatalogo_Mant_FormClosing += FrmAcaCatalogo_Mant_event_FrmAcaCatalogo_Mant_FormClosing;
        }

        void FrmAcaCatalogo_Mant_event_FrmAcaCatalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
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
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        
        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        private void FrmAcaCatalogo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                CargarComboCatalogoTipo();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Catalogo_Mant.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntAnular = false;
                        Cargar_Controles();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Cargar_Controles();
                        chkbEstado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntAnular = false;
                        cmbTipoCatalogo.EditValue = InfoCatalogo.IdTipoCatalogo;
                        chkbEstado.Checked = true;
                        chkbEstado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        BloquearDatos();
                        Cargar_Controles();
                        ucGe_Menu_Superior_Catalogo_Mant.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Catalogo_Mant.Enabled_btnGuardar = false;

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

        private void ucGe_Menu_Superior_Catalogo_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();
        }

        private void ucGe_Menu_Superior_Catalogo_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
           bool resultado = guardarDatos();
           if (resultado)
           {
               Close();
           }
        
        }

        private void ucGe_Menu_Superior_Catalogo_Mant_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void txtOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
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

        private void FrmAcaCatalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
