using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Recursos.Properties;
using Core.Erp.Reportes.Roles;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.Facturacion_FJ;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Relacion_Activo_Fijo_x_Empleado_Mant : Form
    {
        fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Bus bus_Activos_en_tarifarios = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<ro_Empleado_Info> listados_Empleados_actuales = new List<ro_Empleado_Info>();
        ro_Empleado_Bus bus_empleado = new Business.Roles.ro_Empleado_Bus();
        List<Af_Activo_fijo_Info> listado_activo_fijo = new List<Af_Activo_fijo_Info>();
        Af_Activo_fijo_Bus bus_activo_Fijo = new Af_Activo_fijo_Bus();
        BindingList<ro_empleado_x_Activo_Fijo_Info> lista_empleados_actual_x_AF = new BindingList<ro_empleado_x_Activo_Fijo_Info>();
        ro_empleado_x_Activo_Fijo_Bus bus_empleado_actuales_AF = new ro_empleado_x_Activo_Fijo_Bus();
        List<ro_empleado_x_Activo_Fijo_Historico_Info> lista_a_grabar_empleados_x_activos_hist = new List<ro_empleado_x_Activo_Fijo_Historico_Info>();


        Af_Activo_fijo_Info info_activoFijo = new Af_Activo_fijo_Info();

        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        List<ro_empleado_x_Activo_Fijo_Historico_Info> lista_empleados_Historico_x_AF = new List<ro_empleado_x_Activo_Fijo_Historico_Info>();
        ro_empleado_x_Activo_Fijo_Historico_Bus bus_empleado_historico_AF = new ro_empleado_x_Activo_Fijo_Historico_Bus();
        int IdEmpleado = 0;
        int Empleados_max_x_activo = 0;
        public frmRo_Relacion_Activo_Fijo_x_Empleado_Mant()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void frmRo_Relacion_Activo_Fijo_x_Empleado_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl_empleados_Actuales.DataSource = lista_empleados_actual_x_AF;

                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public void CargarEmpleados()
        {
            try
            {
                listados_Empleados_actuales = bus_empleado.Get_List_Empleado_(param.IdEmpresa);
                cmb_empleado.DataSource = listados_Empleados_actuales;
                cmb_empleado.DisplayMember = "pe_NomCompleto";
                cmb_empleado.ValueMember = "IdEmpleado";
               listado_activo_fijo= bus_activo_Fijo.Get_List_ActivoFijo(param.IdEmpresa);
                cmb_activo_Fijo.Properties.DataSource = listado_activo_fijo;
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
                if(Validar_Maximo_Empleado())
                Grabar();
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
                if(Grabar())
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        public void Get_empleados_actuales_x_Activos()
        {
            try
            {
                foreach (var item in lista_empleados_actual_x_AF)
                {
                    if (item.check == true)
                    {
                        ro_empleado_x_centro_costo_Info info = new ro_empleado_x_centro_costo_Info();
                        info.IdEmpresa = param.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdCentroCosto = info_activoFijo.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = info_activoFijo.IdCentroCosto_sub_centro_costo;
                        info.UsuarioIngresa = param.IdUsuario;
                        info.FechaIngresa = DateTime.Now;
                        item.Info_Centro_costo_x_empleado = info;


                        item.IdEmpresa = param.IdEmpresa;
                        item.IdActivo_fijo = Convert.ToInt32(cmb_activo_Fijo.EditValue);
                        item.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                        item.IdNomina_tipo = Convert.ToInt32(cmbnomina.EditValue);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public void Get_empleados_Historico_x_Activos()
        {
            try
            {
                foreach (var item in lista_empleados_actual_x_AF)
                {
                    if (item.check ==false)
                    {
                        ro_empleado_x_Activo_Fijo_Historico_Info info = new ro_empleado_x_Activo_Fijo_Historico_Info();
                        info.IdEmpresa = param.IdEmpresa;
                        info.IdActivo_fijo = Convert.ToInt32(cmb_activo_Fijo.EditValue);
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdNomina_tipo = item.IdNomina_tipo;
                        info.IdPeriodo = item.IdPeriodo;
                        info.Fecha_Asignacion = item.Fecha_Asignacion;
                        info.Fecha_Hasta = item.Fecha_Hasta;
                        lista_a_grabar_empleados_x_activos_hist.Add(info);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public bool Grabar()
        {
            try
            {
                cmb_activo_Fijo.Focus();
                bool bandera = false;

                Get_empleados_actuales_x_Activos();
                if(bus_empleado_actuales_AF.Eliminar(param.IdEmpresa,Convert.ToInt32(cmb_activo_Fijo.EditValue)))
                {
                foreach (var item in lista_empleados_actual_x_AF)
                {
                    if (item.check == true)
                    {

                        bandera = bus_empleado_actuales_AF.Guardar_DB(item);
                    }
                }
                }

                 if (bandera)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return bandera;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
        }

        private void cmb_pasar_historico_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar_Historico())
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo mover el empleado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                
            }
        }





        public bool Grabar_Historico()
        {
            try
            {
                Get_empleados_Historico_x_Activos();
                foreach (var item in lista_a_grabar_empleados_x_activos_hist)
                {

                    bus_empleado_historico_AF.Guardar_DB(item);                   
                }

                Get_empleados_actuales_x_Activos();
                if(bus_empleado_actuales_AF.Eliminar(param.IdEmpresa,Convert.ToInt32(cmb_activo_Fijo.EditValue)))
                {
                foreach (var item in lista_empleados_actual_x_AF)
                {
                    if (item.check == true)
                    {
                        bus_empleado_actuales_AF.Guardar_DB(item);
                    }
                }
                }
                Consultar();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
        }

        private void cmb_activo_Fijo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {


                info_activoFijo = (Af_Activo_fijo_Info)cmb_activo_Fijo.Properties.View.GetFocusedRow();
                Consultar();
                Validar_Maximo_Empleado();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
               
            }
        }


        public void Consultar()
        {
            try
            {
                lista_empleados_actual_x_AF = new BindingList<ro_empleado_x_Activo_Fijo_Info>(bus_empleado_actuales_AF.listado_Grupos(param.IdEmpresa, Convert.ToInt32(cmb_activo_Fijo.EditValue)));
                gridControl_empleados_Actuales.DataSource = lista_empleados_actual_x_AF;




                lista_empleados_Historico_x_AF = bus_empleado_historico_AF.listado_Grupos(param.IdEmpresa, Convert.ToInt32(cmb_activo_Fijo.EditValue));
                gridControl_Historico_empleados_x_activo.DataSource = lista_empleados_Historico_x_AF;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);

            }
        }
        
        private void cmb_empleado_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {

                IdEmpleado = Convert.ToInt32(e.NewValue);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void gridView_empleados_actuales_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "col_idEmpleado" )
                {
                   
                   
                    ro_Empleado_Info info_empleado = new ro_Empleado_Info();
                    info_empleado = listados_Empleados_actuales.Where(v => v.IdEmpleado == Convert.ToDecimal(IdEmpleado)).FirstOrDefault();                   
                    gridView_empleados_actuales.SetFocusedRowCellValue(col_cargo, info_empleado.cargo);


                  

                    foreach (var item in lista_empleados_actual_x_AF)
                    {
                        if (item.IdEmpleado == info_empleado.IdEmpleado)
                        {

                            item.Fecha_Asignacion = info_periodo.pe_FechaIni;
                            item.Fecha_Hasta = info_periodo.pe_FechaFin;
                           
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


        public bool Validar_Maximo_Empleado()
        {
            try
            {
                int Empleado_seleccionados = 0;
               Empleados_max_x_activo=   bus_Activos_en_tarifarios.Validar_Activos_x_tarifario(param.IdEmpresa, Convert.ToInt32(cmb_activo_Fijo.EditValue));

              Empleado_seleccionados= lista_empleados_actual_x_AF.Where(v => v.check == true).Count();
              if (Empleado_seleccionados > Empleados_max_x_activo)
               {

                  // MessageBox.Show(" El Numero de empleado seleccionado es mayor a lo establecido en el tarifario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  return true;

               }
               else
               {
                   return true;
               }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_periodo = (ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();
            }
            catch (Exception ex)
            {
                
           
              MessageBox.Show(ex.ToString());
            }
        }

    }
}
