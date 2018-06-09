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
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frm_Ro_Abono_Prestamos : Form
    {
        #region Variables
        List<ro_prestamo_detalle_Info> detalle = new List<ro_prestamo_detalle_Info>();
        ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();
        ro_prestamo_detalle_Bus Prestamo_Detalle_Bus = new ro_prestamo_detalle_Bus();
        List<ro_Empleado_Info> InfoSup = new List<ro_Empleado_Info>();
        ro_rubro_tipo_Bus busRubro = new ro_rubro_tipo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Nomina_Tipo_Bus Bus_TipoNo = new ro_Nomina_Tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Catalogo_Bus BusPrestamo_Pago = new ro_Catalogo_Bus();
        List<ro_prestamo_detalle_Info> DetallePrestamo = new List<ro_prestamo_detalle_Info>();
        List<ro_prestamo_detalle_Info> DetallePrestamo_Cuotas_a_cancelar = new List<ro_prestamo_detalle_Info>();
        string mensaje = "";

        #endregion
        public frm_Ro_Abono_Prestamos()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtCuota.Checked == true)
                {
                    if (MessageBox.Show("¿Esta seguro que desea realizar abono al préstamo?", "ABONO A PRESTAMO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Modificar_Cuotas();
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Esta seguro que desea realizar la cancelacion total del préstamo?", "CANCELACION DE PRESTAMO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Modificar_Cuotas();
                    }
                }
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

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControlDetalle_Click(object sender, EventArgs e)
        {

        }

        public void Cargar_Datos()
        {
            try
            {


                // Cargando combo de Rubros Prestamos
                var lstRubro = busRubro.ConsultaRubrosPrestamo(param.IdEmpresa);
                this.cmbRubro.Properties.DataSource = lstRubro;


                // Cargando combo de Empleado
                List<ro_Empleado_Info> InfoSup = new List<ro_Empleado_Info>();
                InfoSup = BusEmpleado.Get_List_Empleado_(param.IdEmpresa);
                this.cmbEmpleados.Properties.DataSource = InfoSup;
                // Cargando Combo de Tipo de Nomina
                List<ro_Nomina_Tipo_Info> InfoTipoNomina = new List<ro_Nomina_Tipo_Info>();
                InfoTipoNomina = Bus_TipoNo.Get_List_Nomina_Tipo(param.IdEmpresa);
                this.cmbTipoNomi.Properties.DataSource = InfoTipoNomina;


                // Cargando estado de pago prestamos
                var lstEstado = BusPrestamo_Pago.Get_List_CatalogoEstadoPrestamo();
                //  this.cmbEstado.DataSource = lstEstado;
                this.cmbestadoPago.DataSource = lstEstado;

            }
            catch (Exception ex)
            {
                
                  MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Set(ro_prestamo_Info info)
        {
            try
            {

                cmbEmpleados.EditValue = info.IdEmpleado;
                cmbRubro.EditValue = info.IdRubro;
                cmbTipoNomi.EditValue = info.IdNomina_Tipo;
                txtObservacion.Text = info.Observacion;
                info.Detalle = Prestamo_Detalle_Bus.ConsultaxIdPrestamo(param.IdEmpresa, info.IdPrestamo);
                DetallePrestamo= info.Detalle.Where(v=>v.EstadoPago=="PEN").ToList();

                gridControlDetalle.DataSource = DetallePrestamo;

                if (DetallePrestamo.Count() > 0)
                {
                    txtTotal_Pendiente.Text = DetallePrestamo.Sum(v=>v.TotalCuota).ToString();
                    txtNumCuotaPendiente.Text = DetallePrestamo.Count().ToString();

                }
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void rbtCuota_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtCuota.Checked == true)
                {
                    txtCuota_a_abonar.Enabled = true;
                }
                else
                {
                    txtCuota_a_abonar.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public void Modificar_Cuotas()
        {
            try
            {
                DetallePrestamo_Cuotas_a_cancelar = new List<ro_prestamo_detalle_Info>();
                if (rbtCuota.Checked == true)
                {
                    int contador = 0;
                    foreach (var item in DetallePrestamo)
                    {
                        contador = contador + 1;
                        item.EstadoPago = "ABO";
                        item.Fecha_UltMod = DateTime.Now;
                        item.IdUsuarioUltMod = param.IdUsuario;
                        DetallePrestamo_Cuotas_a_cancelar.Add(item);

                        if (contador == Convert.ToInt32(txtCuota_a_abonar.Text))
                        {
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var item in DetallePrestamo)
                    {
                        item.EstadoPago = "ABO";
                        DetallePrestamo_Cuotas_a_cancelar.Add(item);
                    }

                }

                mensaje = "";
                if (Prestamo_Detalle_Bus.Abono_Prestamo(DetallePrestamo_Cuotas_a_cancelar, ref mensaje))
                {
                    MessageBox.Show("Se modifico correctamente el préstamo","ABONO A PRESTAMO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo modifico  el préstamo", "ABONO A PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
