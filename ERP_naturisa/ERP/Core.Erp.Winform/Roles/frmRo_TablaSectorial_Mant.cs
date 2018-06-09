using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_TablaSectorial_Mant : Form
    {

        #region Declaracion de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_TablaSectorial_Bus Bus = new ro_TablaSectorial_Bus();
        public delegate void delegate_frmRo_TablaSectorial_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_TablaSectorial_Mant_FormClosing event_frmRo_TablaSectorial_Mant_FormClosing;
        ro_TablaSectorial_Info _GetInfo = new ro_TablaSectorial_Info();

        #endregion

        public frmRo_TablaSectorial_Mant()
        {
            try
            {
                 InitializeComponent();
                 ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                 ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                 ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                 ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    this.ucGe_Menu_event_btnGuardar_Click(sender, e);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Actualizar();
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
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {          
            try
            {
                string mensaje = "";

                if (lblEstado.Visible == true)
                {
                    ucGe_Menu.Enabled_bntAnular = false;
                    MessageBox.Show("No se puede anular debido a que ya se encuentra anulado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Get();
                    if (MessageBox.Show("¿Está seguro que desea anular Tabla Sectorial...?", "Anulación de Tabla Sectorial  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        _GetInfo.IdUsuarioUltAnu = param.IdUsuario;
                        _GetInfo.Fecha_UltMod = DateTime.Now;
                        _GetInfo.MotiAnula = ofrm.motivoAnulacion;

                        if (Bus.AnularDB((_GetInfo)))
                        {
                            MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblEstado.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Error al ANULAR Tabla Sectorial verifique con sistemas ...: " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }        
        }

        public ro_TablaSectorial_Info _SetInfo { get; set; }

        void Set()
        {
            try
            {
                txtIdSectorial.Text = _SetInfo.IdCodSectorial.ToString();
                textCodigo.Text = _SetInfo.CodigoIESS;
                textActividad.Text = _SetInfo.Actividad;
                textEstructura.Text = _SetInfo.EstructuraOcupacional;
                CheckEstado.Checked = (_SetInfo.Estado == "A") ? true : false;
                if (_SetInfo.Estado == "I")
                {
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    //ucGe_Menu.Visible_btnGuardar = false;
                    lblEstado.Visible = true;
                }
                else
                {
                    lblEstado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
       
        void Get()
         {
             try
             {
                _GetInfo.IdCodSectorial = Convert.ToInt32((txtIdSectorial.Text == "")?"0":txtIdSectorial.Text);
                _GetInfo.CodigoIESS = textCodigo.Text;
                _GetInfo.Actividad = textActividad.Text;
                _GetInfo.EstructuraOcupacional = textEstructura.Text;
                _GetInfo.Estado = (CheckEstado.Checked == true) ? "A" : "I";
             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString());
             }
        }

        void Guardar()
        {
            try
            {
                if (Validar())
                {
                   if (Bus.GuardarDB(ref _GetInfo))
                    {
                        txtIdSectorial.Text = _GetInfo.IdCodSectorial.ToString();
//                        MessageBox.Show("Se ha guardado con éxito el registro # :" + _GetInfo.IdCodSectorial);
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        //ucGe_Menu.Visible_btnGuardar = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void Actualizar()
        {
            try
            {
                Get();
                if (Bus.ModificarDB(_GetInfo))
                {
                    txtIdSectorial.Text = _GetInfo.IdCodSectorial.ToString();
                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Se ha modificado con éxito el registro # :" + _GetInfo.IdCodSectorial);
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    //ucGe_Menu.Visible_btnGuardar = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


        }

        Boolean Validar()
        {
            try
            {
                if (textCodigo.Text == null || textCodigo.Text == "")
                {
                    MessageBox.Show("El Código del IESS es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (textActividad.Text == null || textActividad.Text == "")
                {
                    MessageBox.Show("La Actividad es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (textEstructura.Text == null || textEstructura.Text == "")
                {
                    MessageBox.Show("La Estructura Ocupacional es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        //private void btn_guardar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //         Get();
        //            switch (Accion)
        //            {
        //                case Cl_Enumeradores.eTipo_action.grabar:
        //                    Guardar();
        //                    break;
        //                case Cl_Enumeradores.eTipo_action.actualizar:
        //                    Actualizar();
        //                    break;
        //                case Cl_Enumeradores.eTipo_action.consultar:
        //                    break;
        //                default:
        //                    break;

        //            }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
            
        //}

        //private void btn_guardarysalir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Validar())
        //        {
        //            btn_guardar_Click(sender, e);
        //            Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }

        //}

        //private void btn_salir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //            this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }

        //}

        //private void btnAnular_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Get();
        //        if (MessageBox.Show("Está seguro que desea anular el código sectorial ?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        {
        //            if (Bus.AnularDB(_GetInfo))
        //            {
        //                MessageBox.Show("Anulado exitosamente");
        //                lblEstado.Visible = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex )
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString());
        //    }
           
        //}

        private void frmRo_TablaSectorial_Mant_Load(object sender, EventArgs e)
        {
            try
            {
               this.event_frmRo_TablaSectorial_Mant_FormClosing += new delegate_frmRo_TablaSectorial_Mant_FormClosing(frmRo_TablaSectorial_Mant_event_frmRo_TablaSectorial_Mant_FormClosing);
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        lblEstado.Visible = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                       
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        textCodigo.Enabled = false;
                        textActividad.Enabled = false;
                        textEstructura.Enabled = false;
                        CheckEstado.Enabled = false;

                        this.txtIdSectorial.ReadOnly = true;
                        this.txtIdSectorial.BackColor = System.Drawing.Color.White;

                         this.textCodigo.ReadOnly = true;
                         this.textCodigo.BackColor = System.Drawing.Color.White;

                         this.textActividad.ReadOnly = true;
                         this.textActividad.BackColor = System.Drawing.Color.White;

                         this.textEstructura.ReadOnly = true;
                         this.textEstructura.BackColor = System.Drawing.Color.White;


                        Set();
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        }

        void frmRo_TablaSectorial_Mant_event_frmRo_TablaSectorial_Mant_FormClosing(object sender, FormClosingEventArgs e){}
      
        private void frmRo_TablaSectorial_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 event_frmRo_TablaSectorial_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_TablaSectorial_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)(Keys.Escape))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        }

        ///Sumary Modificación de Codigo
        ///Progra : Eliana Veliz
        ///20/10/2014
        ///15:00
    }
}
