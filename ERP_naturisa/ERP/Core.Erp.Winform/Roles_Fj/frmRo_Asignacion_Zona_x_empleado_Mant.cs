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
    public partial class frmRo_Asignacion_Zona_x_empleado_Mant : Form
    {
        public frmRo_Asignacion_Zona_x_empleado_Mant()
        {
            InitializeComponent();
        }

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        List<ro_zona_Info> lista_zonas = new List<ro_zona_Info>();
        ro_zona_Bus bus_zona = new ro_zona_Bus();


        List<ro_empleado_x_parametro_x_pago_variable_Info> lista_empleado_x_parametro_variable = new List<ro_empleado_x_parametro_x_pago_variable_Info>();
        ro_empleado_x_parametro_x_pago_variable_Bus bus_empleado_parametro_variable = new ro_empleado_x_parametro_x_pago_variable_Bus();

        ro_empleado_x_rutas_asignadas_Info info = new ro_empleado_x_rutas_asignadas_Info();

        BindingList<ro_empleado_x_rutas_asignadas_Info> lista_empleado_por_zonas = new BindingList<ro_empleado_x_rutas_asignadas_Info>();
        ro_empleado_x_rutas_asignadas_Bus bus_empleado_x_zona = new ro_empleado_x_rutas_asignadas_Bus();

        

        BindingList<ro_empleado_x_rutas_asignadas_Det_Info> lista_zonas_x_empleados = new BindingList<ro_empleado_x_rutas_asignadas_Det_Info>();
        ro_empleado_x_rutas_asignadas_Det_Bus bus_zonas_x_empleados = new ro_empleado_x_rutas_asignadas_Det_Bus();

        private void frmRo_Asignacion_Zona_x_empleado_Mant_Load(object sender, EventArgs e)
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

        public bool Grabar()
        {
            try
            {
                Get();

                if (bus_empleado_x_zona.Guardar_DB(info))
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
        public void Get()
        {
            try
            {
                if (lista_empleado_por_zonas.Where(v => v.check == true).Count() == 0)
                {
                    MessageBox.Show("No existe ningun empleado seleccionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    info = new ro_empleado_x_rutas_asignadas_Info();

                    info.IdEmpleado = lista_empleado_por_zonas.Where(v => v.check == true).FirstOrDefault().IdEmpleado;
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdNomina_Tipo = Get_idemNomina(info.IdEmpleado);
                    info.detalle = lista_zonas_x_empleados.ToList();
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int Get_idemNomina(decimal idemepleado)
        {
            try
            {
                return lista_empleado_x_parametro_variable.Where(v => v.IdEmpleado == idemepleado).FirstOrDefault().IdNomina_Tipo;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public void Cargar_Datos()
        {
            try
            {


                lista_empleado_x_parametro_variable = bus_empleado_parametro_variable.listado_empleado_x_parametro_variables(param.IdEmpresa);
                cmb_empleados.DataSource = lista_empleado_x_parametro_variable;
                cmb_empleados.DisplayMember = "pe_nombreCompleto";
                cmb_empleados.ValueMember = "IdEmpleado";

                lista_zonas = bus_zona.Get_List_Zona(param.IdEmpresa);
                cmb_parametros_variable.Properties.DataSource = lista_zonas;



                lista_empleado_por_zonas = new BindingList<ro_empleado_x_rutas_asignadas_Info>(bus_empleado_x_zona.listado_parametro_pago_variable(param.IdEmpresa));
                gridControl_Empleados.DataSource = lista_empleado_por_zonas;
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

                if (lista_empleado_por_zonas.Count() == 0) 
                {
                    MessageBox.Show("No existe ningun empleado seleccionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (lista_empleado_por_zonas.Where(v => v.check == true).Count() == 0)
                    {
                        MessageBox.Show("No existe ningun empleado seleccionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                ro_zona_Info info_parametrso_x_empleado = new ro_zona_Info();

                ro_zona_Info info = (ro_zona_Info)cmb_parametros_variable.Properties.View.GetFocusedRow();
                if (info != null)
                {
                    var query = lista_zonas_x_empleados.Where(v => v.id_ruta == info.IdZona);
                    if (query.Count() > 0)
                    {
                        MessageBox.Show("El registro seleccionado ya se encuebtra en la lsita", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        ro_empleado_x_rutas_asignadas_Det_Info info_de = new ro_empleado_x_rutas_asignadas_Det_Info();
                        info_de.IdEmpresa = info.IdEmpresa;
                        info_de.ru_descripcion = info.zo_descripcion;
                        info_de.id_ruta = info.IdZona;
                        info_de.icono_eliminar = true;
                        lista_zonas_x_empleados.Add(info_de); 
                    }
                }


                gridControl_parametros_variables.DataSource = lista_zonas_x_empleados;
                gridControl_parametros_variables.RefreshDataSource();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        info = (ro_empleado_x_rutas_asignadas_Info)gridView_Empleados.GetFocusedRow();
                        gridView_Empleados.DeleteSelectedRows();

                        bus_empleado_x_zona.Anular_DB(info);
                        
                    }
                }

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

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    this.Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

       

        private void repositoryItemCheckEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                gridView_Empleados.SetFocusedRowCellValue(Colicono_eliminar, true);
                foreach (var item in lista_empleado_por_zonas)
                {
                    item.check = false;
                }
                info = (ro_empleado_x_rutas_asignadas_Info)gridView_Empleados.GetFocusedRow();
                lista_zonas_x_empleados = new BindingList<ro_empleado_x_rutas_asignadas_Det_Info>(bus_zonas_x_empleados.lista_paramatrso_x_empleados(info.IdEmpresa, info.IdNomina_Tipo, Convert.ToInt32(info.IdEmpleado)));
                gridControl_parametros_variables.DataSource = lista_zonas_x_empleados;
                gridControl_Empleados.RefreshDataSource();
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

    }
}
