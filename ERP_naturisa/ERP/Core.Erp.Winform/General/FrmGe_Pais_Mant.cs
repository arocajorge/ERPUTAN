using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Pais_Mant : Form
    {
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_pais_Bus busPais = new tb_pais_Bus();
        tb_pais_Info InfoPais = new tb_pais_Info();
        Cl_Enumeradores.eTipo_action _Accion;
        public delegate void delegate_FrmGe_Pais_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_Pais_Mant_FormClosing event_FrmGe_Pais_Mant_FormClosing;
              

        public FrmGe_Pais_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            event_FrmGe_Pais_Mant_FormClosing += FrmGe_Pais_Mant_event_FrmGe_Pais_Mant_FormClosing;
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void FrmGe_Pais_Mant_event_FrmGe_Pais_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarData())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblAnulado.Visible)
                {
                    MessageBox.Show("El registro ya se encuentra anulado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Menu.Enabled_bntAnular = false;
                }
                else
                    AnularDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void FrmGe_Pais_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
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
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean GuardarData()
        {
            try
            {
                Boolean bolResult = false;
                string IdPais = "";
                string msjError = "";
                if (ValidarDatos())
                {
                    GetInfo();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (busPais.GuardarDB(InfoPais, ref IdPais, ref msjError))
                            {
                                txtIdPais.EditValue = IdPais;
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                bolResult = true;
                                MessageBox.Show("Se Guardo Exitosamente el Pais # " + IdPais, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:

                            InfoPais.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            InfoPais.IdUsuarioUltMod = param.IdUsuario;

                            if (busPais.ModificarDB(InfoPais, ref msjError))
                            {
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                bolResult = true;
                                MessageBox.Show("Se Modifico Exitosamente el Pais", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean ValidarDatos()
        {
            try
            {
                if (txtNacionalidad.EditValue == null || txtNacionalidad.EditValue == "")
                {
                    MessageBox.Show("Ingrese la Nacionalidad", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNacionalidad.Focus();
                    return false;
                }

                if (txtDescripcion.EditValue == null || txtDescripcion.EditValue == "")
                {
                    MessageBox.Show("Ingrese el Nombre de la Provincia", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescripcion.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        Boolean AnularDatos()
        {
            try
            {
                Boolean bolResult = false;
                string msjError = "";
                if (ValidarDatos())
                {
                    GetInfo();
                    FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                    frm.ShowDialog();
                    InfoPais.MotivoAnula = frm.motivoAnulacion;
                    InfoPais.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    InfoPais.IdUsuarioUltAnu = param.IdUsuario;

                    if (busPais.AnularDB(InfoPais, ref msjError))
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        bolResult = true;
                        lblAnulado.Visible = true;
                        MessageBox.Show("Se Anulo Exitosamente el Pais", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void GetInfo()
        {
            try
            {
                
                InfoPais.IdPais = (txtIdPais.EditValue == "") ? null : Convert.ToString(txtIdPais.EditValue);
                InfoPais.CodPais = (txtCodPais.EditValue == "") ? null : Convert.ToString(txtCodPais.EditValue);
                InfoPais.Nombre = Convert.ToString(txtDescripcion.EditValue);
                InfoPais.Nacionalidad = Convert.ToString(txtNacionalidad.EditValue);

                InfoPais.IdUsuario = param.IdUsuario;
                InfoPais.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                InfoPais.nom_pc = param.nom_pc;
                InfoPais.ip = param.ip;
                InfoPais.IdUsuarioUltMod = param.IdUsuario;
                InfoPais.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SeInfo(tb_pais_Info Info_Pais)
        {
            try
            {
                txtNacionalidad.EditValue = Info_Pais.Nacionalidad;
                txtIdPais.EditValue = Info_Pais.IdPais;
                txtCodPais.EditValue = Info_Pais.CodPais;
                txtDescripcion.EditValue = Info_Pais.Nombre;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setAccion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_Pais_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FrmGe_Pais_Mant_event_FrmGe_Pais_Mant_FormClosing(sender, e);
                event_FrmGe_Pais_Mant_FormClosing(sender, e);
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
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                InfoPais = new tb_pais_Info();
                txtIdPais.EditValue = "";
                txtCodPais.EditValue = "";
                txtDescripcion.EditValue = "";
                txtNacionalidad.EditValue = "";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
