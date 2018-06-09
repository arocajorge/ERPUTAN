using Core.Erp.Business.General;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Info.Produccion_Talme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_ChatarraTipo_CusTalme_Mant : Form
    {
        #region Declaracion Variable
        
        private Cl_Enumeradores.eTipo_action _Accion;
        prod_ChatarraTipo_CusTalme_Info Info_ChatarraTipo = new prod_ChatarraTipo_CusTalme_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prod_ChatarraTipo_CusTalme_Bus Bus_ChatarraTipo = new prod_ChatarraTipo_CusTalme_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        #endregion

        public delegate void delegate_frmProd_ChatarraTipo_CusTalme_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmProd_ChatarraTipo_CusTalme_Mant_FormClosing event_frmProd_ChatarraTipo_CusTalme_Mant_FormClosing;

        public frmProd_ChatarraTipo_CusTalme_Mant()
        {
            try
            {
              InitializeComponent();
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmProd_ChatarraTipo_CusTalme_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            this.btn_guardar.Text = "Grabar Registro";
                            this.btn_guardarysalir.Text = "Grabar y Salir";
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            this.btn_guardar.Text = "Actualizar Registro";
                            this.btn_guardarysalir.Text = "Actualizar y Salir";
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                            this.btn_guardar.Text = "Actualizar Registro";
                            this.btn_guardarysalir.Text = "Actualizar y Salir";
                            btnAnular.Visible = false;
                            this.btn_guardar.Visible = false;
                            this.btn_guardarysalir.Visible = false;
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            this.btn_guardar.Visible = false;
                            this.btn_guardarysalir.Visible = false;
                            break;
                        default:
                            break;

                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmProd_ChatarraTipo_CusTalme_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  this.event_frmProd_ChatarraTipo_CusTalme_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                       
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Set_InfoTipoChatarra(prod_ChatarraTipo_CusTalme_Info info)
        {
            try
            {
                txtId.Text = info.IdTipoChatarra.ToString();
                txtDescripcion.Text = info.Descripcion;
                txtPrecio.Text = info.Precio.ToString();
                if (info.Estado == "A")
                {
                    chkEstado.Checked = true;
                    lblEstado.Visible = false;
                }
                else
                {
                    chkEstado.Checked = false;
                    lblEstado.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
               Grabar();
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void Grabar()
        {
            try
            {
                // Controlar los datos
                if (ControlDatos())
                {

                    // Extraer Información 
                    get_Info();

                    // variable de mensaje
                    string msg = "";
                    int Id = 0;


                    // Accion para grabar el registro
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (Bus_ChatarraTipo.GrabarDB(Info_ChatarraTipo, ref Id, ref msg))
                        {
                            txtId.Text = Id.ToString();
                            MessageBox.Show("Tipo de Chatarra # " + txtId.Text + " Guardado correctamente");
                            btn_guardar.Visible = false;
                            btn_guardarysalir.Visible = false;
                            BloquearControles();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Grabar el Tipo de Chatarra ");
                        }
                    }

                    // Accion para actualizar el registro
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (Bus_ChatarraTipo.ModificarDB(Info_ChatarraTipo, ref msg))
                        {
                            MessageBox.Show("Tipo de Chatarra # " + txtId.Text + " Modificada correctamente");
                            if (Info_ChatarraTipo.Estado == "I")
                            {
                                lblEstado.Visible = true;
                            }
                            btn_guardar.Visible = false;
                            btn_guardarysalir.Visible = false;
                            btnAnular.Visible = false;
                            BloquearControles();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Modificar el Tipo de Chatarra # " + txtId.Text);
                        }
                    }

                    // Accion para anular el registro
                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        if (MessageBox.Show("Esta Seguro que desea Anular el tipo de chatarra # " + txtId.Text, "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (Bus_ChatarraTipo.Anular(Info_ChatarraTipo))
                            {
                                MessageBox.Show("Tipo de Chatarra # " + txtId.Text + " Anulado correctamente");
                                lblEstado.Visible = true;
                                btn_guardar.Visible = false;
                                btn_guardarysalir.Visible = false;
                                btnAnular.Visible = false;
                                BloquearControles();

                            }
                            else
                            {
                                MessageBox.Show("No se pudo Anular el Tipo de Chatarra # " + txtId.Text);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {            
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        public Boolean ControlDatos()
        {
            try
            {
                  if (txtDescripcion.Text == "")
                    {
                        MessageBox.Show("No se ha asignado el empleado para el Contrato..", "Ingrese el empleado ");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
            }
            catch (Exception ex)
            {
                    Log_Error_bus.Log_Error(ex.ToString());
                    return false;
            }
            
        }

        public prod_ChatarraTipo_CusTalme_Info get_Info()
        {

            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info_ChatarraTipo.IdEmpresa = param.IdEmpresa;
                    Info_ChatarraTipo.Descripcion = txtDescripcion.Text;
                    Info_ChatarraTipo.Precio = Convert.ToDouble(txtPrecio.Text);
                    Info_ChatarraTipo.Estado = (chkEstado.Checked == true) ? "A" : "I";
                }
                else
                {
                    Info_ChatarraTipo.IdEmpresa = param.IdEmpresa;
                    Info_ChatarraTipo.IdTipoChatarra = Convert.ToInt32(txtId.Text);
                    Info_ChatarraTipo.Descripcion = txtDescripcion.Text;
                    Info_ChatarraTipo.Precio = Convert.ToDouble(txtPrecio.Text);
                    Info_ChatarraTipo.Estado = (chkEstado.Checked == true) ? "A" : "I";
                }


                return Info_ChatarraTipo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new prod_ChatarraTipo_CusTalme_Info();
            }

        }

        void BloquearControles()
        {
            try
            {
                txtDescripcion.Enabled = false;
                lblEstado.Enabled = false;
                btn_guardar.Enabled = false;
                btn_guardarysalir.Enabled = false;
                btnAnular.Enabled = false;
                txtPrecio.Enabled = false;
                chkEstado.Enabled = false;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                  this.Close();
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btn_guardarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

    }
}
