using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_ProductoTipo_Mant : UserControl
    {
        public UCIn_ProductoTipo_Mant()
        {
            try
            {
                InitializeComponent();
                iniciar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        private Cl_Enumeradores.eTipo_action _Accion;
        in_ProductoTipo_Info info = new in_ProductoTipo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public void iniciar()
        {
            try
            {
              _Accion = Cl_Enumeradores.eTipo_action.actualizar;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
              _Accion = iAccion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }



        public void set_ProductoTipo(in_ProductoTipo_Info obj)
        {
            try
            {
                info = new in_ProductoTipo_Info();
                this.lbl_idProductoTipo.Text = obj.IdProductoTipo.ToString();
                this.txt_descripcion.Text = obj.tp_descripcion;
                info = obj;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public in_ProductoTipo_Info get_ProductoTipo()
        {
            try
            {
                info = new in_ProductoTipo_Info();
                info.IdEmpresa= param.IdEmpresa;
                info.IdProductoTipo = (this.lbl_idProductoTipo.Text != "") ? Convert.ToInt32(this.lbl_idProductoTipo.Text) : 0;
                info.tp_descripcion = this.txt_descripcion.Text;
                //info.tp_EsCombo = this.chk_escombo.Checked;
                //info.tp_ManejaInven = this.chk_maneja_inventario.Checked;
                //info.Estado = this.chk_estado.Checked;
                info.IdUsuario = param.IdUsuario;
                info.Fecha_Transac = DateTime.Now;
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_UltAnu = DateTime.Now;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.Fecha_UltMod = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                return info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new in_ProductoTipo_Info();
            }
        }

        private void Grabar()
        {
            in_ProductoTipo_Bus bus_producto_tipo = new in_ProductoTipo_Bus();
            int id=0;
            string msg="";
            try
            {
                if (this.txt_descripcion.Text != "")
                {
                    get_ProductoTipo();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            bus_producto_tipo.GrabarDB(info, ref id, ref msg);
                            this.lbl_idProductoTipo.Text = id.ToString();
                            MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                            this.btn_grabar.Text = "Actualizar Registro";
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            bus_producto_tipo.ModificarDB(info, ref msg);
                            MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                            break;
                       
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese la descripción del producto", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_descripcion.Focus();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void UCInv_ProductoTipo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.btn_grabar.Text = "Grabar Registro";
                        this.chk_estado.Checked = true;
                        this.chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        this.btn_grabar.Text = "Actualizar Registro";

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.btn_grabar.Enabled = false;
                        this.toolStripButton1.Enabled = false;
                        this.txt_descripcion.Enabled = false;
                        this.chk_escombo.Enabled = false;
                        this.chk_maneja_inventario.Enabled = false;
                        this.chk_estado.Enabled = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                 this.Parent.Dispose();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
                this.Parent.Dispose();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_idProductoTipo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
