using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Grupo_Mant : Form
    {
        #region variables
        //Bus

        in_categorias_bus bus_Categoria = new in_categorias_bus();
        in_linea_Bus bus_Linea = new in_linea_Bus();
        in_grupo_Bus bus_Grupo = new in_grupo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //Listas
        List<in_categorias_Info> listCategoria = new List<in_categorias_Info>();
        List<in_linea_info> listlinea = new List<in_linea_info>();

        //Infos
        in_grupo_info infoGrupo = new in_grupo_info();

        //Variables
        string mensaje = "";
        int IdGrupo = 0;

        public delegate void DelegadoFrmIn_Grupo_Mant();
        public event DelegadoFrmIn_Grupo_Mant Delegado_FrmIn_Grupo_Mant;

        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        public in_grupo_info _SetInfo { get; set; }

        #endregion
                        
        public FrmIn_Grupo_Mant()
        {
            InitializeComponent();
            
        }

          public FrmIn_Grupo_Mant(Cl_Enumeradores.eTipo_action Numerador)
            : this()
          {
              try
              {
                   enu = Numerador;
              }
              catch (Exception ex)
              {
                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
          }

        void Carga_Combos()
        {
            try
            {
                listCategoria = bus_Categoria.Get_List_categorias(param.IdEmpresa);
                cmbCategoria.Properties.DataSource = listCategoria;
                cmbCategoria.Properties.DisplayMember = "ca_Categoria";
                cmbCategoria.Properties.ValueMember = "IdCategoria";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmIn_Grupo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Carga_Combos();

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        txtIdGrupo.Focus();

                        txtIdGrupo.Enabled = false;
                        txtIdGrupo.BackColor = System.Drawing.Color.White;
                        txtIdGrupo.ForeColor = System.Drawing.Color.Black;

                        ucGe_Menu.Visible_bntAnular = false;


                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Visible_bntAnular = false;


                        txtIdGrupo.Enabled = false;
                        txtIdGrupo.BackColor = System.Drawing.Color.White;
                        txtIdGrupo.ForeColor = System.Drawing.Color.Black;

                        cmbCategoria.Enabled = false;
                        cmbCategoria.BackColor = System.Drawing.Color.White;
                        cmbCategoria.ForeColor = System.Drawing.Color.Black;

                        cmbLinea.Enabled = false;
                        cmbLinea.BackColor = System.Drawing.Color.White;
                        cmbLinea.ForeColor = System.Drawing.Color.Black;

                        checkActivo.Enabled = false;

                        setGrupo();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        Inhabilita_Campos();

                        setGrupo();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;

                        Inhabilita_Campos();

                        setGrupo();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {               
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Inhabilita_Campos()
        {
            try
            {
                txtIdGrupo.Enabled = false;
                txtIdGrupo.BackColor = System.Drawing.Color.White;
                txtIdGrupo.ForeColor = System.Drawing.Color.Black;

                cmbCategoria.Enabled = false;
                cmbCategoria.BackColor = System.Drawing.Color.White;
                cmbCategoria.ForeColor = System.Drawing.Color.Black;

                cmbLinea.Enabled = false;
                cmbLinea.BackColor = System.Drawing.Color.White;
                cmbLinea.ForeColor = System.Drawing.Color.Black;

                txtCodGrupo.Enabled = false;
                txtCodGrupo.BackColor = System.Drawing.Color.White;
                txtCodGrupo.ForeColor = System.Drawing.Color.Black;

                txtDescripcion.Enabled = false;
                txtDescripcion.BackColor = System.Drawing.Color.White;
                txtDescripcion.ForeColor = System.Drawing.Color.Black;

                txtAbreviatura.Enabled = false;
                txtAbreviatura.BackColor = System.Drawing.Color.White;
                txtAbreviatura.ForeColor = System.Drawing.Color.Black;

                txtObservacion.Enabled = false;
                txtObservacion.BackColor = System.Drawing.Color.White;
                txtObservacion.ForeColor = System.Drawing.Color.Black;

                checkActivo.Enabled = false;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void getGrupo()
        {
            try
            {
                infoGrupo.IdEmpresa = param.IdEmpresa;
                infoGrupo.IdGrupo = Convert.ToInt32((txtIdGrupo.Text == "") ? 0 : Convert.ToInt32(txtIdGrupo.Text));

                infoGrupo.cod_grupo = txtCodGrupo.Text;
                infoGrupo.nom_grupo = txtDescripcion.Text;
                infoGrupo.abreviatura = txtAbreviatura.Text;
                infoGrupo.observacion = txtObservacion.Text;
                infoGrupo.IdCategoria = Convert.ToString(cmbCategoria.EditValue);
                infoGrupo.IdLinea = Convert.ToInt32(cmbLinea.EditValue);

                infoGrupo.IdUsuario = param.IdUsuario;
                infoGrupo.Fecha_Transac = param.Fecha_Transac;
                infoGrupo.nom_pc = param.nom_pc;
                infoGrupo.ip = param.ip;
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }
              
        void setGrupo()
        {
            try
            {
                txtIdGrupo.Text = _SetInfo.IdGrupo.ToString();
                txtCodGrupo.Text = _SetInfo.cod_grupo;
                txtDescripcion.Text = _SetInfo.nom_grupo;
                txtAbreviatura.Text = _SetInfo.abreviatura;
                txtObservacion.Text = _SetInfo.observacion;

                cmbCategoria.EditValue = _SetInfo.IdCategoria;
                cmbLinea.EditValue = _SetInfo.IdLinea;

                if (_SetInfo.Estado.TrimEnd() == "I")
                {
                    this.checkActivo.Checked = false;
                     lblAnulado.Visible = true;
                }
                else
                {
                    checkActivo.Checked = true;
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }

        void grabar()
        {
            try
            {
                txtIdGrupo.Focus();
                getGrupo();

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        Guardar();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:


                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Guardar()
        {
            try
            {
                string msgRecurso;
                if (bus_Grupo.GrabarDB(infoGrupo, ref IdGrupo, ref mensaje))
                {
                    msgRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                    MessageBox.Show(msgRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Registro guardado con éxito", "Sistemas");
                    txtIdGrupo.Text = IdGrupo.ToString();
                    this.checkActivo.Checked = true;
                    LimpiarDatos();

                }
                else
                {
                    msgRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Grabar;
                    MessageBox.Show(msgRecurso+"\n"+mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Error al Grabar. " + mensaje + " ", "Sistemas");

                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Actualizar()
        {
            try
            {

                infoGrupo.IdUsuarioUltMod = param.IdUsuario;
                infoGrupo.Fecha_UltMod = param.Fecha_Transac;
                string msgRecurso;
                if (bus_Grupo.ModificarDB(infoGrupo, ref mensaje))
                {
                    msgRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                    MessageBox.Show(msgRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatos();
                }
                else
                {
                    msgRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Modificar;
                    MessageBox.Show(msgRecurso+ " \n"+mensaje, param.Nombre_sistema);
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Anular()
        {
            try
            {
                getGrupo();
                
                infoGrupo.IdUsuarioUltAnu = param.IdUsuario;
                infoGrupo.Fecha_UltAnu = param.Fecha_Transac;

                string msgRecurso;
                if (bus_Grupo.AnularDB(infoGrupo, ref mensaje))
                {
                    msgRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaAnulacionOk;
                    MessageBox.Show(msgRecurso, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    lblAnulado.Visible = true;
                    ucGe_Menu.Visible_bntAnular = false;
                }
                else
                {
                    msgRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Anular;
                    MessageBox.Show(msgRecurso + " \n " + mensaje , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategoria_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listlinea = bus_Linea.Get_List_Linea(param.IdEmpresa, Convert.ToString(cmbCategoria.EditValue));
                cmbLinea.Properties.DataSource = listlinea;
                cmbLinea.Properties.DisplayMember = "nom_linea";
                cmbLinea.Properties.ValueMember = "IdLinea";
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Grupo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Delegado_FrmIn_Grupo_Mant();
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {

            try
            {
                Anular();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
                Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void LimpiarDatos()
        {
            try
            {
                enu = Cl_Enumeradores.eTipo_action.grabar;
                txtIdGrupo.Text = "";
                txtCodGrupo.Text = "";
                cmbCategoria.EditValue = null;
                cmbLinea.EditValue = null;
                txtDescripcion.Text = "";
                txtAbreviatura.Text = "";
                txtObservacion.Text = "";
                infoGrupo = new in_grupo_info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
