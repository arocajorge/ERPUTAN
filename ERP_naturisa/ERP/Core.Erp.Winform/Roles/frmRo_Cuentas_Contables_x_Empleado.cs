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
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Recursos.Properties;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Cuentas_Contables_x_Empleado : Form
    {
        string MensajeError = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Empleado_Info> lis_empleados = new List<ro_Empleado_Info>();
        ro_Empleado_Bus empleado_bus = new ro_Empleado_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<ro_rubro_tipo_Info> List_Rubros = new List<ro_rubro_tipo_Info>();
        ro_rubro_tipo_Bus Rubro_bus = new ro_rubro_tipo_Bus();
        List<ct_Plancta_Info> List_plan_Cuenta = new List<ct_Plancta_Info>();
        ct_Plancta_Bus pla_cuenta_bus = new ct_Plancta_Bus();
        BindingList<ro_Cuentas_contables_x_empleado_Info> lista = new BindingList<ro_Cuentas_contables_x_empleado_Info>();
        ro_Cuentas_contables_x_empleado_Bus Cuentas_bus = new ro_Cuentas_contables_x_empleado_Bus();
        public frmRo_Cuentas_Contables_x_Empleado()
        {
            InitializeComponent();
        }

        public void CargarEmpleados()
        {
            try
            {
                //Carga combo Empleado
                lis_empleados = empleado_bus.Get_List_Empleado_(param.IdEmpresa);
                this.cmbEmpleado.Properties.DataSource = lis_empleados;

                List_Rubros = Rubro_bus.ConsultaGeneralPorEmpresa(param.IdEmpresa).Where(v => v.rub_Contabiliza_x_empleado == true && v.rub_nocontab == true).ToList();
                cmbRubro.DataSource = List_Rubros;
                cmbRubro.DisplayMember = "ru_descripcion";
                cmbRubro.ValueMember = "IdRubro";

                List_plan_Cuenta = pla_cuenta_bus.Get_List_Plancta(param.IdEmpresa, ref MensajeError);
                cmb_cuentas .DataSource= List_plan_Cuenta;
                cmb_cuentas.DisplayMember = "pc_Cuenta";
                cmb_cuentas.ValueMember = "IdCtaCble";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);

            }
        }

        private void frmRo_Cuentas_Contables_x_Empleado_Load(object sender, EventArgs e)
        {
            try
            {
                gridControlCuentas_Contables_x_empleado.DataSource = lista;
                CargarEmpleados();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
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
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
                {
                    cmbEmpleado.EditValue = 0;
                    lista = new BindingList<ro_Cuentas_contables_x_empleado_Info>();
                    gridControlCuentas_Contables_x_empleado.DataSource = lista;
                    MessageBox.Show("Se asignaron las cuentas correctamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al asignar las cuentas al empleado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
                {
                    this.Close();
                    MessageBox.Show("Se asignaron las cuentas correctamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al asignar las cuentas al empleado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                
                 
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);  
            }
        }

        public void Get()
        {
            try
            {
                foreach (var item in lista)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdEmpleado =Convert.ToInt32( cmbEmpleado.EditValue);
                }

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);       
            }
        }


        public bool Guardar()
        {
            cmbEmpleado.Focus();
            try
            {
                Get();
                Cuentas_bus.EliminarDB(param.IdEmpresa, Convert.ToDecimal(cmbEmpleado.EditValue));
                return Cuentas_bus.GuardarDB(lista.ToList());
            }
            catch (Exception  ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
        }

        private void cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(cmbEmpleado.EditValue) != 0)
                {
                    lista= new BindingList<ro_Cuentas_contables_x_empleado_Info>( Cuentas_bus.Get_List_Cuentas_contables_x_empleados(param.IdEmpresa, Convert.ToDecimal(cmbEmpleado.EditValue)));
                    gridControlCuentas_Contables_x_empleado.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void gridView_Contables_x_empleado_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {


                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_Contables_x_empleado.DeleteSelectedRows();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

       

        private void gridView_Contables_x_empleado_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                ro_Cuentas_contables_x_empleado_Info info = new ro_Cuentas_contables_x_empleado_Info();
                info = (ro_Cuentas_contables_x_empleado_Info)gridView_Contables_x_empleado.GetRow(e.RowHandle);
                if (info != null)
                {
                    if (e.Column == Col_cmb_rubro)
                    {
                        int con = lista.Where(v => v.IdRubro == info.IdRubro).Count();
                        if (con > 1)
                        {
                            MessageBox.Show("No Puede Seleccionar un rubro mas de una vez", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            gridView_Contables_x_empleado.DeleteRow(e.RowHandle);
                        }
                    }





                    if (e.Column == ColIdCtaCble)
                    {
                        int con = lista.Where(v => v.IdCtaCble == info.IdCtaCble).Count();
                        if (con > 1)
                        {
                            MessageBox.Show("No Puede Seleccionar una cuenta mas de una vez", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            gridView_Contables_x_empleado.DeleteRow(e.RowHandle);
                        }
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

       

    }
}
