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
    public partial class FrmAcaMatriculaTipoDocumento_Mant : Form
    {
        #region "Variable"
        public delegate void delegate_FrmAcaMatriculaTipoDocumento_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaMatriculaTipoDocumento_Mant_FormClosing event_FrmAcaMatriculaTipoDocumentoMant_FormClosing;
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Aca_Matricula_Tipo_Documento_Info TipoDocumentoInfo = new Aca_Matricula_Tipo_Documento_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        public FrmAcaMatriculaTipoDocumento_Mant()
        {
            InitializeComponent();
            event_FrmAcaMatriculaTipoDocumentoMant_FormClosing += FrmAcaMatriculaTipoDocumento_Mant_event_FrmAcaMatriculaTipoDocumentoMant_FormClosing;
        }

        #region "CargarDatos"
        public void CargarTipoDocumento() {
            try
            {
                txtIdTipoDocumento.Text = TipoDocumentoInfo.IdTipoDocumento.ToString();
                txtCodigoTipoDocumento.Text = TipoDocumentoInfo.CodTipoDocumento;
                txtDescripcion.Text = TipoDocumentoInfo.Descripcion;
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkEstado.Checked = true;
                }
                else
                {
                    chkEstado.Checked = (TipoDocumentoInfo.Estado == "A") ? true : false;
                }

                if (TipoDocumentoInfo.Estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (TipoDocumentoInfo.Estado != null)
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

        public void set_tipoDocumento(Aca_Matricula_Tipo_Documento_Info info)
        {
            try
            {
                TipoDocumentoInfo = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Get"
        public Aca_Matricula_Tipo_Documento_Info Get_MatriculaTipoDocumento(ref string mensaje) {
            Aca_Matricula_Tipo_Documento_Info info = new Aca_Matricula_Tipo_Documento_Info();
            try
            {            
                info.IdTipoDocumento = Convert.ToInt16( txtIdTipoDocumento.Text);
                info.CodTipoDocumento = txtCodigoTipoDocumento.Text;
                info.Descripcion = txtDescripcion.Text;
                info.UsuarioCreacion = param.IdUsuario;
                info.Estado = chkEstado.Checked == true ? "A" : "I";                
            }
            catch (Exception ex)
            {
                mensaje = ex.Message.ToString();
            }
            return info;
        }
        #endregion

        #region "Eventos"

        void FrmAcaMatriculaTipoDocumento_Mant_event_FrmAcaMatriculaTipoDocumentoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAcaMatriculaTipoDocumento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAcaMatriculaTipoDocumentoMant_FormClosing(sender,e);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FrmAcaMatriculaTipoDocumento_Mant_Load(object sender, EventArgs e)
        {
            CargarTipoDocumento();
            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Enabled_bntImprimir = false;
                    LimpiarControles();
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            bool valida = guardarDatos();
            if (valida)
            {
                Close();
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        #endregion

        #region "Proceso"

        public bool validaciones()
        {
            try
            {
                if (txtDescripcion.Text.Trim() == "")
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

        public bool guardarDatos()
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
                    return true;
                }
                else { return false; }
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Grabar()
        {
            try
            {
                Aca_Matricula_Tipo_Documento_Info tipoDocInfo = new Aca_Matricula_Tipo_Documento_Info();

                string mensaje = string.Empty;
                int id = 0;

                tipoDocInfo = Get_MatriculaTipoDocumento(ref mensaje);

                Aca_Material_Tipo_Documento_Bus neg = new Aca_Material_Tipo_Documento_Bus();
                bool resultado = neg.GrabarDB(tipoDocInfo, ref id, ref mensaje);
                txtIdTipoDocumento.Text = id.ToString();

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
                Aca_Material_Tipo_Documento_Bus neg = new Aca_Material_Tipo_Documento_Bus();
                Aca_Matricula_Tipo_Documento_Info tipoDocInfo = new Aca_Matricula_Tipo_Documento_Info();
                string mensaje = string.Empty;

                tipoDocInfo = Get_MatriculaTipoDocumento(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return;
                }
                tipoDocInfo.UsuarioModificacion = param.IdUsuario;
                bool resultado = neg.ActualizarDB(tipoDocInfo, ref mensaje);
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
        }

        private void Anular()
        {
            try
            {
                if (TipoDocumentoInfo.Estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el documento # " + txtIdTipoDocumento.Text.Trim() + " ?", "Anulación de Mantenimiento Documento Matricula", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();  

                        Aca_Material_Tipo_Documento_Bus neg = new Aca_Material_Tipo_Documento_Bus();
                        Aca_Matricula_Tipo_Documento_Info tipoDocInfo = new Aca_Matricula_Tipo_Documento_Info();
                        string mensaje = string.Empty;

                        tipoDocInfo = Get_MatriculaTipoDocumento(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                        tipoDocInfo.UsuarioAnulacion = param.IdUsuario;
                        tipoDocInfo.MotivoAnulacion = fr.motivoAnulacion;
                        bool resultado = neg.EliminarDB(tipoDocInfo, ref mensaje);
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
                    MessageBox.Show("El documento de la matricula # " + txtIdTipoDocumento.Text.Trim()+" ya se encuentra anulado.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarControles() {
            txtDescripcion.Text = string.Empty;
            txtCodigoTipoDocumento.Text = string.Empty;
        }
        #endregion
    }
}
