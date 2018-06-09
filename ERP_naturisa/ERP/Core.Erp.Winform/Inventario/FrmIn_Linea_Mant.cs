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
    public partial class FrmIn_Linea_Mant : Form
    {
        #region Declaraciones
        //Bus

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_categorias_bus bus_Categoria = new in_categorias_bus();
        in_linea_Bus bus_Linea = new in_linea_Bus();

        //Infos
        in_linea_info infoLinea = new in_linea_info();
       
        //Listas       
        List<in_categorias_Info> listCategoria = new List<in_categorias_Info>();

        //Variables
        string mensaje = "";
        int IdLinea = 0;
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        public in_linea_info _SetInfo { get; set; }
        public delegate void DelegadoFrmIn_Linea_Mant();
        public event DelegadoFrmIn_Linea_Mant Delegado_FrmIn_Linea_Mant;
        #endregion

        public FrmIn_Linea_Mant()
        {
            InitializeComponent();
            Delegado_FrmIn_Linea_Mant += FrmIn_Linea_Mant_Delegado_FrmIn_Linea_Mant;
            
        }

        void FrmIn_Linea_Mant_Delegado_FrmIn_Linea_Mant()
        {
           
        }
                   
        public FrmIn_Linea_Mant(Cl_Enumeradores.eTipo_action Numerador)
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
      
        void Carga_Combo()
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
       
       void getLinea()
        {
            try
            {                            
                infoLinea.IdEmpresa = param.IdEmpresa;
                infoLinea.IdLinea = Convert.ToInt32((txtIdLinea.Text == "") ? 0 : Convert.ToInt32(txtIdLinea.Text));
                infoLinea.cod_linea = txtCodLinea.Text;
                infoLinea.nom_linea = txtNombre.Text;
                infoLinea.abreviatura = txtAbreviatura.Text;
                infoLinea.Observacion = txtObservacion.Text;
                infoLinea.IdCategoria = Convert.ToString(cmbCategoria.EditValue);

                infoLinea.IdUsuario = param.IdUsuario;
                infoLinea.Fecha_Transac = param.Fecha_Transac;
                infoLinea.nom_pc = param.nom_pc;
                infoLinea.ip = param.ip;
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }        
        }
      
       void SetLinea()
       {
           try
           {
               txtIdLinea.Text = _SetInfo.IdLinea.ToString();
               txtCodLinea.Text = _SetInfo.cod_linea;
               txtNombre.Text = _SetInfo.nom_linea;
               txtAbreviatura.Text = _SetInfo.abreviatura;
               txtObservacion.Text = _SetInfo.Observacion;

               cmbCategoria.EditValue = _SetInfo.IdCategoria;

               if (_SetInfo.Estado.TrimEnd() == "I")
               {
                   this.chkActivo.Checked = false;
                   lblAnulado.Visible = true;
               }
               else
               {
                   chkActivo.Checked = true;
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
               txtIdLinea.Focus();
               this.getLinea();

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
               string msgRecurso = "";
                            
               if (bus_Linea.GrabarDB(infoLinea,ref IdLinea, ref mensaje))
               {
                   msgRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                   MessageBox.Show(msgRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   //MessageBox.Show("Registro guardado con éxito", "Sistemas");
                   txtIdLinea.Text = IdLinea.ToString();
                   this.chkActivo.Checked = true;
                   LimpiarDatos();
               }
               else
               {
                   MessageBox.Show("Error al Grabar. " + mensaje+ " ", "Sistemas");
               
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
               string msgRecurso = "";
               infoLinea.IdUsuarioUltMod = param.IdUsuario;
               infoLinea.Fecha_UltMod = param.Fecha_Transac;

               if (bus_Linea.ModificarDB(infoLinea,ref mensaje))
               {
                   msgRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                   MessageBox.Show(msgRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   //MessageBox.Show("Registro actualizado con éxito", "Sistemas");
                   LimpiarDatos();
               }
               else
               {
                   MessageBox.Show("Error al Actualizar", "Sistemas");
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
               getLinea();
               
               infoLinea.IdUsuarioUltAnu = param.IdUsuario;
               infoLinea.Fecha_UltAnu = param.Fecha_Transac;

               string msgRecurso = "";
               if (bus_Linea.AnularDB(infoLinea, ref mensaje))
               {
                   msgRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaAnulacionOk;
                   MessageBox.Show(msgRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   //MessageBox.Show("Registro anulado con éxito", "Sistemas");
                   lblAnulado.Visible = true;
                   ucGe_Menu.Visible_bntAnular = false;
               }
               else
               {
                   msgRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Anular;
                   MessageBox.Show(msgRecurso, param.Nombre_sistema);
               }
           }
           catch (Exception ex)
           {

               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void FrmIn_Linea_Mant_Load(object sender, EventArgs e)
       {
           try
           {
               Carga_Combo();

               switch (enu)
               {
                   case Cl_Enumeradores.eTipo_action.grabar:
                  
                       txtIdLinea.Focus();

                       txtIdLinea.Enabled = false;
                       txtIdLinea.BackColor = System.Drawing.Color.White;
                       txtIdLinea.ForeColor = System.Drawing.Color.Black;

                       ucGe_Menu.Visible_bntAnular = false;

                       break;
                   case Cl_Enumeradores.eTipo_action.actualizar:

                       ucGe_Menu.Visible_bntAnular = false;

                       txtIdLinea.Enabled = false;
                       txtIdLinea.BackColor = System.Drawing.Color.White;
                       txtIdLinea.ForeColor = System.Drawing.Color.Black;

                       cmbCategoria.Enabled = false;
                       cmbCategoria.BackColor = System.Drawing.Color.White;
                       cmbCategoria.ForeColor = System.Drawing.Color.Black;

                       chkActivo.Enabled = false;
                
                       SetLinea();
                       break;
                   case Cl_Enumeradores.eTipo_action.Anular:

                      ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                       ucGe_Menu.Visible_btnGuardar = false;
                                                     
                       Inhabilita_Campos();

                       SetLinea();
                       break;
                   case Cl_Enumeradores.eTipo_action.consultar:

                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                       ucGe_Menu.Visible_btnGuardar = false;
                       ucGe_Menu.Visible_bntAnular = false;
                                       
                       Inhabilita_Campos();

                       SetLinea();
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
               txtIdLinea.Enabled = false;
               txtIdLinea.BackColor = System.Drawing.Color.White;
               txtIdLinea.ForeColor = System.Drawing.Color.Black;

               cmbCategoria.Enabled = false;
               cmbCategoria.BackColor = System.Drawing.Color.White;
               cmbCategoria.ForeColor = System.Drawing.Color.Black;

               txtCodLinea.Enabled = false;
               txtCodLinea.BackColor = System.Drawing.Color.White;
               txtCodLinea.ForeColor = System.Drawing.Color.Black;

               txtNombre.Enabled = false;
               txtNombre.BackColor = System.Drawing.Color.White;
               txtNombre.ForeColor = System.Drawing.Color.Black;

               txtAbreviatura.Enabled = false;
               txtAbreviatura.BackColor = System.Drawing.Color.White;
               txtAbreviatura.ForeColor = System.Drawing.Color.Black;

               txtObservacion.Enabled = false;
               txtObservacion.BackColor = System.Drawing.Color.White;
               txtObservacion.ForeColor = System.Drawing.Color.Black;

               chkActivo.Enabled = false;

           }
           catch (Exception ex)
           {
               
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }                          
       }

       private void FrmIn_Linea_Mant_FormClosing(object sender, FormClosingEventArgs e)
       {
           Delegado_FrmIn_Linea_Mant();
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
               txtIdLinea.Text = "";
               txtCodLinea.Text = "";
               txtNombre.Text = "";
               txtAbreviatura.Text = "";
               txtObservacion.Text = "";
               cmbCategoria.EditValue = null;
               infoLinea = new in_linea_info();
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
