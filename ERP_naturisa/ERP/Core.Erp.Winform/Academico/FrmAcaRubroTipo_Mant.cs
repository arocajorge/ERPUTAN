using Core.Erp.Business.General;
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
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaRubroTipo_Mant : Form
    {
        #region "Variables"
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_RubroTipo_Info rubroTipoInfo = new Aca_RubroTipo_Info();

        public delegate void delegate_FrmAcaRubroTipo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaRubroTipo_Mant_FormClosing event_FrmAcaRubroTipo_Mant_FormClosing;
        #endregion

        public FrmAcaRubroTipo_Mant()
        {
            InitializeComponent();
            event_FrmAcaRubroTipo_Mant_FormClosing += FrmAcaRubroTipo_Mant_event_FrmAcaRubroTipo_Mant_FormClosing;
        }

        void FrmAcaRubroTipo_Mant_event_FrmAcaRubroTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        #region "Set"

        private void set_Accion_in_controls()
        {
            try
            {

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        this.chkActivo.Checked = true;
                        Limpiar();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        Set_Info_In_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        Set_Info_In_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        Set_Info_In_Controls();
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }     
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }     
        }

        public void set_Rubro(Aca_RubroTipo_Info info)
        {
            try
            {
                rubroTipoInfo = info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }     
        }

        public void Set_Info_In_Controls()
        {
            try
            {
                txtIdTipoRubro.Text = "0";
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    txtIdTipoRubro.Text = rubroTipoInfo.IdTipoRubro.ToString();
                }
                txtDescripcion.Text = rubroTipoInfo.DescripcionTipoRubro;
                txtCodigoTipoRubro.Text = rubroTipoInfo.CodTipoRubro;
                chkActivo.Checked = (rubroTipoInfo.Estado == "A") ? true : false;
                ucAca_Catalogo_cmb1.Set_info_catalogo(rubroTipoInfo.IdRubroComportamiento_cat);
                if (rubroTipoInfo.Estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (rubroTipoInfo.Estado != null)
                    {
                        lblAnulado.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }      
        }

        #endregion

        #region "Get"
        public Aca_RubroTipo_Info GetRubroTipo(ref string mensaje)
        {
            Aca_RubroTipo_Info rInfo = new Aca_RubroTipo_Info();
            try
            {
                rInfo.IdTipoRubro = Convert.ToInt16(txtIdTipoRubro.Text);
                rInfo.DescripcionTipoRubro = txtDescripcion.Text;                
                rInfo.CodTipoRubro = txtCodigoTipoRubro.Text;                                
                rInfo.UsuarioCreacion = param.IdUsuario;
                rInfo.UsuarioModificacion = param.IdUsuario;

                if (ucAca_Catalogo_cmb1.Get_info_catalogo() != null) rInfo.IdRubroComportamiento_cat = ucAca_Catalogo_cmb1.Get_info_catalogo().IdCatalogo; else rInfo.IdRubroComportamiento_cat = null;
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkActivo.Checked = true;
                }

                rInfo.Estado = (chkActivo.Checked == true) ? "A" : "I";
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
            return rInfo;
        }
        #endregion

        
        
        

        #region "Proceso"
        public bool Grabar()
        {
            bool resultado = false;
            try
            {
                Aca_RubroTipo_Info ruInfo = new Aca_RubroTipo_Info();

                string mensaje = string.Empty;
                int id = 0;

                ruInfo = GetRubroTipo(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }

                Aca_RubroTipo_Bus neg = new Aca_RubroTipo_Bus();
                resultado = neg.GrabarDB(ruInfo, ref id, ref mensaje);
                txtIdTipoRubro.Text = id.ToString();

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, " Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    //this.ucGe_Menu.Visible_btnGuardar = false;
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
            return resultado;
        }

        public bool Actualizar()
        {
            bool resultado = false;
            try
            {
                Aca_RubroTipo_Bus neg = new Aca_RubroTipo_Bus();
                Aca_RubroTipo_Info ruInfo = new Aca_RubroTipo_Info();
                string mensaje = string.Empty;

                ruInfo = GetRubroTipo(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }

                resultado = neg.ActualizarDB(ruInfo, ref mensaje);
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
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        private void Anular()
        {
            try
            {
                if (rubroTipoInfo.Estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Tipo de Rubro #:" + txtIdTipoRubro.Text.Trim() + " ?", "Anulación de Mantenimiento Tipo Rubro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        Aca_RubroTipo_Bus neg = new Aca_RubroTipo_Bus();
                        Aca_RubroTipo_Info ruInfo = new Aca_RubroTipo_Info();
                        string mensaje = string.Empty;

                        ruInfo = GetRubroTipo(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                        ruInfo.UsuarioAnulacion = param.IdUsuario;
                        ruInfo.MotivoAnulacion = fr.motivoAnulacion;
                        bool resultado = neg.EliminarDB(ruInfo, ref mensaje);
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
                    MessageBox.Show("El rubro #:" + txtIdTipoRubro.Text.Trim() + " ya se encuentra anulado." , "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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
                            Limpiar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            resultado = Actualizar();
                            break;
                    }
                }
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
            return resultado;
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

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Limpiar()
        {
            txtCodigoTipoRubro.Text = "";
            txtDescripcion.Text = "";
            ucAca_Catalogo_cmb1.Set_info_catalogo(""); //Se sete el parametro IdCatalogo en vacio para limpiar
            txtIdTipoRubro.Text = "0";
        }
        #endregion

        #region "Evento"
        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }   
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = guardarDatos();
                if (resultado)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }   
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }               
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }               
        }

        private void FrmAcaRubroTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAcaRubroTipo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }     
        }

        #endregion

        private void FrmAcaRubroTipo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                ucAca_Catalogo_cmb1.cargar_combos("TIPO_COMP_RUBRO");
                Set_Info_In_Controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
