using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Gastos_Personales_Techo_Mant : Form
    {
        string MensajeError = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        BindingList<ro_tipo_gastos_personales_tabla_valores_x_anio_Info> ListaGastos = new BindingList<ro_tipo_gastos_personales_tabla_valores_x_anio_Info>();
        ro_tipo_gastos_personales_tabla_valores_x_anio_Info Info = new ro_tipo_gastos_personales_tabla_valores_x_anio_Info();
        ro_tipo_gastos_personales_tabla_valores_x_anio_Bus BusGastos = new ro_tipo_gastos_personales_tabla_valores_x_anio_Bus();
        public frmRo_Gastos_Personales_Techo_Mant()
        {
            InitializeComponent();
        }

        private void frmRo_Gastos_Personales_Techo_Mant_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbAnioFiscal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarData();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }



        public void CargarData()
        {
            try
            {
                int anio = DateTime.Now.Year;
                ListaGastos = new BindingList<ro_tipo_gastos_personales_tabla_valores_x_anio_Info>(BusGastos.ConsultaGeneral(Convert.ToInt32(cmbAnioFiscal.Text)));
                gridControlMaxGastosPersonales.DataSource = ListaGastos;
                TxtObservacion.Text = ListaGastos.FirstOrDefault().observacion;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        public bool Validar()
        {
            bool Bandera = false;
            try
            {
                if (TxtObservacion.Text == "")
                {
                    MessageBox.Show("Ingrese una Observacion ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TxtObservacion.Focus();
                    Bandera = true;
                   return Bandera;
                }


                if (cmbAnioFiscal.Text == "")
                {
                    MessageBox.Show("Escoja un Año Fiscal ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TxtObservacion.Focus();
                    Bandera = true;
                    return Bandera;
                }

                foreach (var item in ListaGastos)
                {
                    if (item.Monto_max == 0)
                    {
                        MessageBox.Show("Ingrese Monto Para Cada Item ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    
                }

                return Bandera;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return Bandera;
            }
        }
        

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    return;
                }
                TxtObservacion.Focus();
                Grabar();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                TxtObservacion.Focus();
                if (Validar())
                {
                    return;
                }
                Grabar();
                this.Close(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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


        public void Grabar()
        {
            try
            {
                if (!BusGastos.SiExiste(Convert.ToInt32(cmbAnioFiscal.Text)))
                {

                    foreach (var item in ListaGastos)
                    {
                        item.Fecha_Transac = DateTime.Now;
                        item.estado = "A";
                        item.IdUsuario = param.IdUsuario;
                        item.observacion = TxtObservacion.Text;

                    }

                    if (BusGastos.GuardarDB(ListaGastos.ToList(), ref MensajeError))
                    {
                        MessageBox.Show("Se Guardaron Correctamente los Datos ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Guardaron Correctamente los Datos ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    foreach (var item in ListaGastos)
                    {
                        item.Fecha_UltMod = DateTime.Now;
                        item.estado = "A";
                        item.IdUsuarioUltMod = param.IdUsuario;
                        item.observacion = TxtObservacion.Text;
                    }

                    if (BusGastos.ModificarDB(ListaGastos.ToList(), ref MensajeError))
                    {
                        MessageBox.Show("Se Guardaron Correctamente los Datos ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Guardaron Correctamente los Datos ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
      
    }
}
