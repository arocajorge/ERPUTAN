using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Nomina_Tipo_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Nomina_Tipo_Info Cab = new ro_Nomina_Tipo_Info();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Nomina_Tipo_Bus busTipo = new ro_Nomina_Tipo_Bus();
        string msg = "";
        public delegate void delegate_frmro_Nomina_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmro_Nomina_Tipo_Mant_FormClosing event_frmro_Nomina_Tipo_Mant_FormClosing;

        #endregion

        public frmRo_Nomina_Tipo_Mant()
        {
            try
            {
               InitializeComponent();
               ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
               ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
               ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
               ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
               event_frmro_Nomina_Tipo_Mant_FormClosing += frmRo_Nomina_Tipo_Mant_event_frmro_Nomina_Tipo_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.grabar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                anular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }

        void frmRo_Nomina_Tipo_Mant_event_frmro_Nomina_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
       
        public void setCab(ro_Nomina_Tipo_Info Info)
        {
            try
            {
                Cab = Info;
                txtId.Text = Convert.ToString(Info.IdNomina_Tipo);
                txtDescripcion.Text = Info.Descripcion;
                checkBoxEstado.Checked = (Info.Estado == "A") ? true : false;
                if (Info.Estado == "I" && Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    checkBoxEstado.Enabled = true;

         
                if (Info.Estado == "I")
                {
                    lblAnulado.Visible = true;
                    
                }
                else
                {
                    lblAnulado.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private Boolean getInfo()
        {
            try
            {
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("La Descripción  es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                else
                {
                    Cab.IdEmpresa = param.IdEmpresa;
                    Cab.Descripcion = txtDescripcion.Text;
                    Cab.Estado = (checkBoxEstado.Checked== true)?"A":"I";
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            Cab.FechaUltModi = param.Fecha_Transac;
                            Cab.IdUsuarioUltModi = param.IdUsuario;
                            Cab.IdNomina_Tipo = Convert.ToInt32(txtId.Text);
                            
                            return true; ;
                        case Cl_Enumeradores.eTipo_action.grabar:
                            Cab.FechaTransac = param.Fecha_Transac;
                            Cab.IdUsuario = param.IdUsuario;
                            return true; ;
                        default:
                            return false; ;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
                return false;
            }

        }
        
        private Boolean grabar()
        {
            try
            {
                if (getInfo())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            if (busTipo.ModificaDB(Cab, ref msg))
                            {
                                txtId.Text = Convert.ToString(Cab.IdNomina_Tipo);
                                //MessageBox.Show("Se ha guardado con éxito el registro # " + Cab.IdNomina_Tipo);
                                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                ucGe_Menu.Visible_btnGuardar = false;
                                ucGe_Menu.Enabled_bntSalir = true;
                                
                                return true;
                            }
                            else return false;


                        case Cl_Enumeradores.eTipo_action.grabar:
                            int id = 0;
                            if (busTipo.GrabarDB(Cab, ref id, ref msg))
                            {
                                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Accion = Cl_Enumeradores.eTipo_action.grabar;
                                Limpiar();
                               
                                return true;
                            }
                            else return false;

                        default:
                            return false;

                    }

                }
                else return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
                return false;
            }



        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { Accion = iAccion; }

        private void frmro_Nomina_Tipo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                event_frmro_Nomina_Tipo_Mant_FormClosing += frmro_Nomina_Tipo_Mant_event_frmro_Nomina_Tipo_Mant_FormClosing;

                this.lblAnulado.Visible = false;

                    if (Accion == Cl_Enumeradores.eTipo_action.consultar)
                    {
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Enabled_bntSalir = true;
                        this.txtDescripcion.ReadOnly = true;
                        this.txtDescripcion.BackColor = System.Drawing.Color.White; 
                                        
                    }else
                    if (Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntSalir = true;

                        this.txtDescripcion.ReadOnly = true;
                        this.txtDescripcion.BackColor = System.Drawing.Color.White;

                    }
                    else
                        if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                        {
                            ucGe_Menu.Visible_bntAnular = false;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = false;
                            ucGe_Menu.Enabled_bntSalir = true;
                            this.txtDescripcion.ReadOnly = false;

                            this.txtDescripcion.BackColor = System.Drawing.Color.White;

                        }
                    if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntSalir = true;
                        this.txtDescripcion.ReadOnly = false;

                        this.txtDescripcion.BackColor = System.Drawing.Color.White;

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
          
        }

        void frmro_Nomina_Tipo_Mant_event_frmro_Nomina_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e){}

        private void frmro_Nomina_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              event_frmro_Nomina_Tipo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                  MessageBox.Show(ex.Message);
            }

        }
        

        void anular()
        {
            try
            {
                if (Cab != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (Cab.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el reg #: " + Cab.IdNomina_Tipo + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();
                            Cab.MotivoAnu = oFrm.motivoAnulacion;
                            Cab.IdUsuarioAnu = param.IdUsuario;
                            Cab.FechaAnu = param.Fecha_Transac;
                            if (busTipo.AnularDB(Cab, ref msg))
                            {
                                MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                
                            }
                            else MessageBox.Show("No se pudo anular el reg #: " + Cab.IdNomina_Tipo + " debido a: "
                                + msg, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular el reg #: " + Cab.IdNomina_Tipo, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e){}

        private void frmRo_Nomina_Tipo_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        public void Limpiar()
        {
            try
            {
                txtDescripcion.Text = "";
                txtId.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
