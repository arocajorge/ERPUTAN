using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Winform.General;



namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAf_Activo_fijo_Categoria_Mant : Form
    {

        string MensajeError = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action _Accion { get; set; }



        Af_Activo_fijo_Categoria_Bus BusCategoriaAF = new Af_Activo_fijo_Categoria_Bus();
        Af_Activo_fijo_Categoria_Info InfoAf = new Af_Activo_fijo_Categoria_Info();
        Af_Activo_fijo_tipo_Bus BusTipoAF = new Af_Activo_fijo_tipo_Bus();


        public delegate void delegate_frmAf_Activo_fijo_Categoria_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmAf_Activo_fijo_Categoria_Mant_FormClosing event_frmAf_Activo_fijo_Categoria_Mant_FormClosing;


        private Boolean validar()
        {
            try
            {

                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Debe ingresar la descripcion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescripcion.Focus();
                    return false;
                }

                if (cmb_tipoAF.EditValue == null)
                {
                    MessageBox.Show("Debe seleccionar el tipo de activo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_tipoAF.Focus();
                    return false;
                }



                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Af_Activo_fijo_Categoria_Info Get_Info()
        {
            try
            {
                InfoAf.IdEmpresa = param.IdEmpresa;
                if (txtId.Text != "")
                {
                    InfoAf.IdCategoriaAF = Convert.ToInt32(txtId.Text);
                }
                InfoAf.Descripcion = txtDescripcion.Text;
                if (txtId.Text != "")
                {
                    InfoAf.CodCategoriaAF = txtCodigo.Text;
                }
                InfoAf.Estado  = (chkEstado.Checked)? "A": "I";
                InfoAf.IdActivoFijoTipo = Convert.ToInt32(cmb_tipoAF.EditValue);

                return InfoAf;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return InfoAf;
            }
        }

        public void Set_Info_Categoria(Af_Activo_fijo_Categoria_Info _Info)
        {
            try
            {
                InfoAf = _Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Set_Info()
        {
            try
            {
                txtId.Text = InfoAf.IdCategoriaAF.ToString();
                txtDescripcion.Text = InfoAf.Descripcion;
                txtCodigo.Text = InfoAf.CodCategoriaAF;
                chkEstado.Checked = (InfoAf.Estado == "A") ? true : false;
                lblAnulado.Visible= (InfoAf.Estado == "I") ? true: false;
                cmb_tipoAF.EditValue = InfoAf.IdActivoFijoTipo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void anular()
        {
            try
            {
                if (InfoAf != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (InfoAf.Estado == "A")
                    {
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_Eliminar), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();

                            //InfoAf.MotivoAnulacion = oFrm.motivoAnulacion;

                            InfoAf.Fecha_UltAnu = param.Fecha_Transac;
                            InfoAf.IdUsuarioUltAnu = param.IdUsuario;

                            if (BusCategoriaAF.AnularDB(InfoAf, ref msg))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "", InfoAf.IdCategoriaAF);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                InfoAf.Estado = "I";
                                ucGe_Menu_Superior.Visible_bntAnular = false;
                                lblAnulado.Visible = true;

                                _Accion = Cl_Enumeradores.eTipo_action.consultar;

                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular,MensajeError);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (InfoAf.Estado == "I")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular_registro) + InfoAf.IdCategoriaAF + param.Get_Mensaje_sys(enum_Mensajes_sys.Debido_q_ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmAf_Activo_fijo_Categoria_Mant()
        {
            InitializeComponent();
            event_frmAf_Activo_fijo_Categoria_Mant_FormClosing += frmAf_Activo_fijo_Categoria_Mant_event_frmAf_Activo_fijo_Categoria_Mant_FormClosing;
        }

        void frmAf_Activo_fijo_Categoria_Mant_event_frmAf_Activo_fijo_Categoria_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmAf_Activo_fijo_Categoria_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combo();
                set_accion();                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void set_accion()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.txtId.Enabled = false;
                        this.txtId.BackColor = System.Drawing.Color.White;
                        this.txtId.ForeColor = System.Drawing.Color.Black;                        
                        ucGe_Menu_Superior.Visible_bntAnular = false;
                        ucGe_Menu_Superior.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior.Visible_btnGuardar = true;
                        lblAnulado.Visible = false;
                        chkEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu_Superior.Visible_bntAnular = false;
                        ucGe_Menu_Superior.Visible_bntLimpiar = false;


                        this.txtId.Enabled = false;
                        this.txtId.BackColor = System.Drawing.Color.White;
                        this.txtId.ForeColor = System.Drawing.Color.Black;

                        Set_Info();

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu_Superior.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior.Visible_btnGuardar = false;
                        ucGe_Menu_Superior.Visible_bntGuardar_y_Salir = false;

                        this.txtId.Enabled = false;
                        this.txtId.BackColor = System.Drawing.Color.White;
                        this.txtId.ForeColor = System.Drawing.Color.Black;



                        Set_Info();

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior.Visible_btnGuardar = false;
                        ucGe_Menu_Superior.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior.Visible_bntAnular = false;


                        this.txtId.Enabled = false;
                        this.txtId.BackColor = System.Drawing.Color.White;
                        this.txtId.ForeColor = System.Drawing.Color.Black;



                        Set_Info();
                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        Boolean grabar()
        {
            try
            {
                Boolean respuesta = false;

                txtId.Focus();
                Get_Info();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        respuesta=Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        respuesta=Actualizar();
                        break;

                    default:
                        break;
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean Guardar()
        {
            try
            {
                Boolean respuesta;

                InfoAf.Fecha_Transac = param.Fecha_Transac;
                int IdCateAF = 0;

                respuesta=BusCategoriaAF.GrabarDB(InfoAf, ref IdCateAF, ref  MensajeError);

                if (respuesta)
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "", InfoAf.IdCategoriaAF);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    txtId.Text = InfoAf.IdCategoriaAF.ToString();

                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, MensajeError);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return respuesta;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        Boolean Actualizar()
        {
            try
            {
                Boolean respuesta;


                InfoAf.Fecha_UltMod = param.Fecha_Transac;
                InfoAf.IdUsuarioUltMod = param.IdUsuario;

                respuesta=BusCategoriaAF.ModificarDB(InfoAf, ref  MensajeError);

                if (respuesta)
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Devolución", InfoAf.IdCategoriaAF);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    LimpiarDatos();
                    

                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar, MensajeError);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void cargar_combo()
        {
            try
            {
                cmb_tipoAF.Properties.DataSource = BusTipoAF.Get_List_ActivoFijoTipo(param.IdEmpresa);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarDatos()
        {
            try
            {
                InfoAf = new Af_Activo_fijo_Categoria_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion();
                txtId.Text = "";
                txtDescripcion.Text = "";
                txtCodigo.Text = "";
                chkEstado.Checked =  true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    if (grabar())
                    {
                        _Accion = Cl_Enumeradores.eTipo_action.grabar;
                        set_accion();
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_Superior_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    if (grabar())
                    {
                        this.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_event_btnlimpiar_Click(object sender, EventArgs e)
        {

            try
            {
                LimpiarDatos();                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_Superior_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmAf_Activo_fijo_Categoria_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmAf_Activo_fijo_Categoria_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }
    }
}
