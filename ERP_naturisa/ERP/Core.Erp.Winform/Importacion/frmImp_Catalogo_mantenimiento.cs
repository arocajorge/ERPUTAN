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
    public partial class frmImp_Catalogo_mantenimiento : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public frmImp_Catalogo_mantenimiento()
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
        imp_catalogo_Bus Bus = new imp_catalogo_Bus();
        imp_catalogo_Info info = new imp_catalogo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
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
        private void frmImp_Catalogo_mantenimiento_Load(object sender, EventArgs e)
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
                        this.chbEstado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.txtNombreIngles.Enabled = false;
                        this.txtAbreviatura.Enabled = false;
                        this.txtIdCat.Enabled = false;
                        this.txtNombre.Enabled = false;
                        this.txtCatTipo.Enabled = false;
                        this.chbEstado.Enabled = false;
                        this.btnOk.Text = "Anular";
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.txtNombreIngles.Enabled = false;
                        this.txtAbreviatura.Enabled = false;
                        this.txtIdCat.Enabled = false;
                        this.txtNombre.Enabled = false;
                        this.txtCatTipo.Enabled = false;
                        this.chbEstado.Enabled = false;
                        this.btnOk.Visible =false;                        
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
        public imp_catalogo_Info get_Tipo()
        {
            try
            {
                //info.IdCatalogoImport_tipo = Convert.ToInt32(this.txtCodigo.Text);
                info.IdCatalogoImport = this.txtIdCat.Text;
                //info.IdCatalogoImport_tipo = Convert.ToInt32(this.txtCatTipo.Text);
                info.Nombre = this.txtNombre.Text;
                info.ip = param.ip;
                info.nom_pc = param.nom_pc;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.IdUsuario = param.IdUsuario;
                if (chbEstado.Checked == true)
                    info.Estado = "A";
                else
                    info.Estado = "I";
                info.Abrebiatura = this.txtAbreviatura.Text;
                info.NombreIngles = this.txtNombreIngles.Text;
                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new imp_catalogo_Info();
            }
        }

        public void setTipo(imp_catalogo_Info inf)
        {
            try
            {
                this.txtIdCat.Text = inf.IdCatalogoImport;
                this.txtCatTipo.Text = inf.IdCatalogoImport_tipo.ToString();
                this.txtNombre.Text = inf.Nombre;
                this.txtAbreviatura.Text = inf.Abrebiatura;
                this.txtNombreIngles.Text = inf.NombreIngles;
                try
                {
                    if (inf.Estado == "A")
                        this.chbEstado.Checked = true;
                    else
                        this.chbEstado.Checked = false;
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }            
            info = inf;
        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                get_Tipo();
                string msg = "";
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    if (Bus.GrabarDB(info, ref msg))
                    {
                        btnOk.Enabled = false;
                        MessageBox.Show("Registro grabado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show(msg);
                    }
                }
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        btnOk.Enabled = false;
                        Bus.ModificarDB(info);
                        MessageBox.Show("Actualizado ok");
                    }
                    //else
                    //{
                    //    MessageBox.Show("No se Actualizo el registro");
                    //}
                    
                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        
                        Bus.AnularDB(info);
                        MessageBox.Show("Anulado ok");
                    }
                    //else
                    //{
                    //    MessageBox.Show("No se Anular el registro");
                    //}
              //  else
                    //MessageBox.Show(msg);
              //  this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtIdCat_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (txtIdCat.Text == "NNN")
                    txtIdCat.Text = "";
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
