using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_Catalogo_Tipo_mantenimiento : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public frmImp_Catalogo_Tipo_mantenimiento()
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
        private Cl_Enumeradores.eTipo_action _Accion;
        imp_Catalogo_tipo_Bus Bus = new imp_Catalogo_tipo_Bus();
        imp_Catalogo_tipo_info info = new imp_Catalogo_tipo_info();
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
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
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

                get_Tipo();
                string msg = "";
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Bus.GrabarDB(info))
                    {
                        MessageBox.Show("Registro grabado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se grabo el registro");
                    }

                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {                    
                    Bus.ModificarDB(info);
                    MessageBox.Show("Actualizado ok");
                }
                                    
                else
                    MessageBox.Show(msg);
                this.Parent.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public imp_Catalogo_tipo_info get_Tipo()
        {
            try
            {
                  //info.IdCatalogoImport_tipo = Convert.ToInt32(this.txtCodigo.Text);
                    info.Descripcion = this.txtDesc.Text;
                    if (chbEstado.Checked == true)
                    {
                        info.Estado = "A";
                    }
                    else
                    { info.Estado = "I"; }
            
                    return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new imp_Catalogo_tipo_info();
            }
        }


        public void setTipo(imp_Catalogo_tipo_info inf)
        {
            try
            {
                    this.txtCodigo.Text = inf.IdCatalogoImport_tipo.ToString();
                    this.txtDesc.Text = inf.Descripcion;
                    try
                    {
                        if (inf.Estado == "A")
                        {
                            this.chbEstado.Checked = true;
                        }
                        else
                        { this.chbEstado.Checked = false; }
                    }
                    catch (Exception ex)
                    {
                        Log_Error_bus.Log_Error(ex.ToString());
                    }
                    info = inf;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }


        public void setCodigo(imp_Catalogo_tipo_info inf)
        {

            try
            {
                this.txtCodigo.Text = inf.IdCatalogoImport_tipo.ToString();           
                //info = inf;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        public void cargarid() {
            try
            {
               txtCodigo.Text = Convert.ToString(Bus.GetId(info));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        private void frmImp_Catalogo_Tipo_mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.btnOk.Text = "Grabar";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        this.btnOk.Text = "Actualizar";
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

        private void Salir_Click(object sender, EventArgs e)
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


    }
}
