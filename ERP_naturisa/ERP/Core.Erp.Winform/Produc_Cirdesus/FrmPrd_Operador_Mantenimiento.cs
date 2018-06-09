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
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Winform.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Roles;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_Operador_Mantenimiento : Form
    {
        public FrmPrd_Operador_Mantenimiento()
        {
            InitializeComponent();
        }


        string MensajeErrorr = "";
        Cl_Enumeradores.eTipo_action Accion;
        prd_Operador_Info infoOperador = new prd_Operador_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_Operador_Bus BusOperador = new prd_Operador_Bus();
        ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();

        prd_Operador_Info Set_Info = new prd_Operador_Info();
        public delegate void delegate_FrmPrd_PuenteGruaMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_PuenteGruaMantenimiento_FormClosing event_FrmPrd_PuenteGruaMantenimiento_FormClosing;     
        private void FrmPrd_Operador_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combo();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); 
            }
        }
        public void set_Acccion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {

                Accion = _Accion;


                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        // txtCodigo.Text = Bus_Tip_movi.ObtenerIdObra(ref msg).ToString();
                        get_Operador();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;

                        // txtCodigo.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;


                        break;
                    default:
                        break;
                }



            }
            catch (Exception ex)
            {


            }

        }
        public void set_Info(prd_Operador_Info Oper)
        {
            try
            {



                infoOperador = new prd_Operador_Info();

                infoOperador = Oper;

                txtIdOperador.Text = infoOperador.IdOperador.ToString();
                cmbEmpleados.EditValue = infoOperador.IdEmpleado;
                txtNombre_operador.Text = infoOperador.NomEmpleado;
                if (infoOperador.Estado == "A")
                {
                    checkEstado.Checked = true;
                }
                else
                {
                    checkEstado.Checked = false;
                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());

            }
        }
        public void get_Operador()
        {
            try
            {


                infoOperador = new prd_Operador_Info();
                infoOperador.IdEmpleado =Convert.ToInt32( cmbEmpleados.EditValue);
                infoOperador.IdOperador =Convert.ToInt32( txtIdOperador.Text);
                infoOperador.NomEmpleado = txtNombre_operador.Text;
                infoOperador.Fecha_Transac = DateTime.Now;
                if (checkEstado.Checked == true)
                {
                    infoOperador.Estado = "A";
                }
                else
                {
                    infoOperador.Estado = "I";
                }
                infoOperador.nom_pc = param.nom_pc;
                infoOperador.ip = param.ip;
                infoOperador.IdUsuario = param.IdUsuario;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());

            }
        }
        private Boolean Grabar()
        {
            try
            {

                get_Operador();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (BusOperador.GuardarDB(infoOperador, ref MensajeErrorr))
                        {
                            MessageBox.Show("Registro Nº " + txtIdOperador.Text + " Se Grabo con Exito");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Registro Nº " + txtIdOperador.Text + " No se puedo Generar");
                            return false;
                        }


                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (BusOperador.ModificarDB(infoOperador, ref MensajeErrorr))
                        {
                            MessageBox.Show("Registro Nº " + txtIdOperador.Text+ " Se Grabo con Exito");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Registro Nº " + txtIdOperador.Text + " No se puedo Generar");
                            return false;
                        }
                    case Cl_Enumeradores.eTipo_action.Anular:
                        infoOperador.Estado = "I";
                        infoOperador.IdUsuario = param.IdUsuario;
                        infoOperador.Fecha_UltAnu = DateTime.Now;
                        if (BusOperador.AnularDB(infoOperador, ref MensajeErrorr))
                        {
                            MessageBox.Show("Se ha anulado correctamente el Operador: " + infoOperador.NomEmpleado);
                            set_Acccion(Cl_Enumeradores.eTipo_action.consultar);
                            return true;
                        }
                        else
                            MessageBox.Show("El operador " + infoOperador.NomEmpleado + " No se puedo Anular");
                        return false;
                    default:
                        return false;

                }




            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); return false;
            }


        }
        public void Cargar_Combo()
        {
            try
            {
                cmbEmpleados.Properties.DataSource = BusEmpleado.Get_List_Empleado_( param.IdEmpresa);

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); 
            }
        }
        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();

            }
            catch (Exception ex)
            {
                
                 
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
        private void cmbEmpleados_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtNombre_operador.Text = cmbEmpleados.Text;

            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
        public void GedIdOperador()
        { try
          {

            txtIdOperador.Text=Convert.ToString( BusOperador.GedId(ref MensajeErrorr));

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }


        }
        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
                this.Close();

            }
            catch (Exception ex)
            {


                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
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


                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        public bool ValidarObjeto()
        {
            bool B_valida = false;
            try
            {
                if (cmbEmpleados.Text == "")
                {
                    errorPValidaObjetos.SetError(cmbEmpleados,"Escoja empleado");
                    B_valida = true;
                }

                if (txtNombre_operador.Text == "")
                {
                    errorPValidaObjetos.SetError(txtNombre_operador, "Falta Nombre Operador");
                    B_valida = true;
                }



                return B_valida;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return B_valida;
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
                this.Close();

            }
            catch (Exception ex)
            {


                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

    }
}
