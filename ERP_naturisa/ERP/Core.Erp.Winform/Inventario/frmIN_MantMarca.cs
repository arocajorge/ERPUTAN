using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;


namespace Core.Erp.Winform.Inventario
{


    public partial class frmIN_MantMarca : Form
    {

        public frmIN_MantMarca()
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

        private Cl_Enumeradores.eTipo_action _Accion;
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                 _Accion = iAccion; 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            } 
 
        }
        public in_Marca_Info marcaI = new in_Marca_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        private void frmIN_MantMarca_Load(object sender, EventArgs e)
        {
            try
            {
                txt_descripcion.Focus();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            btn_ok.Text = "Grabar";
                            chk_estado.Checked = true;
                            chk_estado.Enabled = false;
                    
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            btn_ok.Text = "Actualizar";
                    
                            break;
                        case Cl_Enumeradores.eTipo_action.borrar:
                            btn_ok.Enabled = false;
                            btnGrabarySalir.Enabled = false;
                            btn_ok.Text = "Anular";
                    
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                            btn_ok.Enabled = false;
                            btnGrabarySalir.Enabled = false;
                            btn_ok.Text = "Consultar";
                            btn_ok.Enabled = false;
                    
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

        public void set_Info(in_Marca_Info info)
        {
            try
            {
                txt_idMarca.Text = info.IdMarca.ToString();
                txt_descripcion.Text = info.Descripcion;                              
                chk_estado.Checked = (info.Estado == "A") ? true : false;
               
                marcaI= info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public in_Marca_Info get_Info()
        {

            try
            {

                marcaI.IdEmpresa = param.IdEmpresa;
                marcaI.IdMarca = Convert.ToInt32(txt_idMarca.Text);
                marcaI.Descripcion = txt_descripcion.Text.Trim();
                marcaI.Estado = (chk_estado.Checked == true) ? "A" : "I";


                return marcaI;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new in_Marca_Info();

            }

        }

        public void Grabar()
        {
            try
            {
                 if (txt_descripcion.Text == "")
                    {
                        MessageBox.Show("Descripción sin datos..", "Favor ingrese datos");
                        return;
                    }
                    get_Info();

                    string msg ="";
            
                    in_marca_bus marcaB = new in_marca_bus();
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (marcaB.GrabarDB(marcaI,ref msg))
                        {
                            MessageBox.Show("Grabo ok", "Operación Exitosa");
                            btn_ok.Enabled = false;
                            btnGrabarySalir.Enabled = false;
                   
                        }
                        else
                        {
                            MessageBox.Show("No se grabo", "Operación Fallida");
                        }
                    }



                        if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                        {
                            if (marcaB.ModificarDB(marcaI, ref msg))
                            {
                                MessageBox.Show("Actualizado ok", "Operación Exitosa");
                                btn_ok.Enabled = false;
                                btnGrabarySalir.Enabled = false;
                     

                            }
                            else
                            {
                                MessageBox.Show("No se Actualizado", "Operación Fallida");
                            }

                        }
                        if (_Accion == Cl_Enumeradores.eTipo_action.borrar)
                        {
                            if (marcaB.Anular(marcaI))
                            {
                                MessageBox.Show("Anulado ok", "Operación Exitosa");
                                this.Parent.Parent.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("No se Anulado", "Operación Fallida");
                            }
                        }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }           

           
        }

   

        private void btn_ok_Click(object sender, EventArgs e)
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

        private void txt_idMarca_TextChanged(object sender, EventArgs e){}

        private void txt_descripcion_TextChanged(object sender, EventArgs e){}

        private void txt_idMarca_TextChanged_1(object sender, EventArgs e){}

        private void btnGrabarySalir_Click(object sender, EventArgs e)
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
