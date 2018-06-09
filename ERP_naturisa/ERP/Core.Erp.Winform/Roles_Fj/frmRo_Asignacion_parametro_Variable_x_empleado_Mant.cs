using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Asignacion_parametro_Variable_x_empleado_Mant : Form
    {
        public frmRo_Asignacion_parametro_Variable_x_empleado_Mant()
        {
            InitializeComponent();
        }

        List<ro_Empleado_Info> lista_empleado = new List<ro_Empleado_Info>();
        List<ro_parametro_x_pago_variable_Info> lista_parametros_x_variables = new List<ro_parametro_x_pago_variable_Info>();
        ro_parametro_x_pago_variable_Bus bus_variable_param = new ro_parametro_x_pago_variable_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Empleado_Bus bus_empleado = new ro_Empleado_Bus();

        ro_empleado_x_parametro_x_pago_variable_Info Info_ro_empleado_x_parametro_x_pago_variable = new ro_empleado_x_parametro_x_pago_variable_Info();
        List<ro_empleado_x_parametro_x_pago_variable_Det_Info> Detalle = new List<ro_empleado_x_parametro_x_pago_variable_Det_Info>();

        BindingList<ro_empleado_x_parametro_x_pago_variable_Info> lista_empleados_x_parametros = new BindingList<ro_empleado_x_parametro_x_pago_variable_Info>();
        ro_empleado_x_parametro_x_pago_variable_Bus bus_empleado_x_parametro_pago_variable = new ro_empleado_x_parametro_x_pago_variable_Bus();
        ro_empleado_x_parametro_x_pago_variable_Det_Bus bus_empleado_x_parametro_pago_variable_detalle = new ro_empleado_x_parametro_x_pago_variable_Det_Bus();

        private void frmRo_Asignacion_parametro_Variable_x_empleado_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Datos();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Cargar_Datos()
        {
            try
            {
                lista_empleado = bus_empleado.get_lista_emp_con_sueldo_actual_para_calculo_HE(param.IdEmpresa);
                cmb_empleados.DataSource = lista_empleado;
                cmb_empleados.DisplayMember = "InfoPersona.pe_nombreCompleto";
                cmb_empleados.ValueMember = "IdEmpleado";

                lista_parametros_x_variables = bus_variable_param.listado_parametro_pago_variable(param.IdEmpresa);
                cmb_parametros_variable.Properties.DataSource = lista_parametros_x_variables;



                lista_empleados_x_parametros =new BindingList<ro_empleado_x_parametro_x_pago_variable_Info>( bus_empleado_x_parametro_pago_variable.listado_empleado_x_parametro_variables(param.IdEmpresa));
                gridControl_Empleados.DataSource = lista_empleados_x_parametros;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (lista_empleados_x_parametros.Count() == 0)
                {
                    MessageBox.Show("No existe ningun empleado seleccionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (lista_empleados_x_parametros.Where(v=>v.check == true).Count()==0)
                    {
                        MessageBox.Show("No existe ningun empleado seleccionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                ro_empleado_x_parametro_x_pago_variable_Det_Info info_parametrso_x_empleado = new ro_empleado_x_parametro_x_pago_variable_Det_Info();

                ro_parametro_x_pago_variable_Info info = (ro_parametro_x_pago_variable_Info)cmb_parametros_variable.Properties.View.GetFocusedRow();
                if(info!=null)
                {
                    var query = Detalle.Where(v => v.Id_Tipo_Pago_Variable == info.Id_Tipo_Pago_Variable);
                    if (query.Count() > 0)
                    {
                        MessageBox.Show("El registro seleccionado ya se encuebtra en la lsita", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        ro_empleado_x_parametro_x_pago_variable_Det_Info info_de = new ro_empleado_x_parametro_x_pago_variable_Det_Info();
                        info_de.IdEmpresa = info.IdEmpresa;
                        info_de.Nombre = info.Nombre;
                        info_de.Id_Tipo_Pago_Variable = info.Id_Tipo_Pago_Variable;
                        info_de.icono_eliminar = true;
                        Detalle.Add(info_de);
                    }
                }


                gridControl_parametros_variables.DataSource = Detalle;
                gridControl_parametros_variables.RefreshDataSource();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_Empleados_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {

                if (e.HitInfo.Column.Name == "check")
                {
                    gridView_Empleados.SetFocusedRowCellValue(Colicono_eliminar, true);
                    if ((bool)gridView_Empleados.GetFocusedRowCellValue(Col_check))
                    {
                        gridView_Empleados.SetFocusedRowCellValue(Col_check, false);
                    }
                }
                if (e.HitInfo.Column.Name == "Colicono_eliminar")
                {
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Info_ro_empleado_x_parametro_x_pago_variable = (ro_empleado_x_parametro_x_pago_variable_Info)gridView_Empleados.GetFocusedRow();
                        gridView_Empleados.DeleteSelectedRows();

                        bus_empleado_x_parametro_pago_variable.Anular_DB(Info_ro_empleado_x_parametro_x_pago_variable);
                    }
                }

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_parametros_variables_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gridView_parametros_variables_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "Col_icono_eliminar")
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gridView_parametros_variables.DeleteSelectedRows();
                    }

                }
                catch (Exception ex)
                {

                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void gridView_Empleados_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "Colicono_eliminar")
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gridView_parametros_variables.DeleteSelectedRows();
                    }

                }
                catch (Exception ex)
                {

                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void repositoryItemCheckEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                gridView_Empleados.SetFocusedRowCellValue(Colicono_eliminar, true);
                foreach (var item in lista_empleados_x_parametros)
                {
                    item.check = false;
                }
                Info_ro_empleado_x_parametro_x_pago_variable =(ro_empleado_x_parametro_x_pago_variable_Info) gridView_Empleados.GetFocusedRow();
                Detalle = bus_empleado_x_parametro_pago_variable_detalle.lista_paramatrso_x_empleados(Info_ro_empleado_x_parametro_x_pago_variable.IdEmpresa, Info_ro_empleado_x_parametro_x_pago_variable.IdNomina_Tipo,Convert.ToInt32( Info_ro_empleado_x_parametro_x_pago_variable.IdEmpleado));
                gridControl_parametros_variables.DataSource = Detalle;
                gridControl_Empleados.RefreshDataSource();
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        public void Get()
        {
            try
            {
                if (lista_empleados_x_parametros.Where(v => v.check == true).Count() == 0)
                {
                    MessageBox.Show("No existe ningun empleado seleccionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Info_ro_empleado_x_parametro_x_pago_variable = new ro_empleado_x_parametro_x_pago_variable_Info();

                    Info_ro_empleado_x_parametro_x_pago_variable =lista_empleados_x_parametros.Where(v=>v.check==true) .FirstOrDefault();
                    Info_ro_empleado_x_parametro_x_pago_variable.IdEmpresa=param.IdEmpresa;
                    Info_ro_empleado_x_parametro_x_pago_variable.IdNomina_Tipo = Get_idemNomina(Info_ro_empleado_x_parametro_x_pago_variable.IdEmpleado);
                    Info_ro_empleado_x_parametro_x_pago_variable.Lista = Detalle;
                }
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int Get_idemNomina( decimal idemepleado)
        {
            try
            {
                return lista_empleado.Where(v => v.IdEmpleado == idemepleado).FirstOrDefault().IdNomina_Tipo;
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
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
                Grabar();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool Grabar()
        {
            try
            {
                Get();

                if (bus_empleado_x_parametro_pago_variable.Guardar_DB(Info_ro_empleado_x_parametro_x_pago_variable))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                
              Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
