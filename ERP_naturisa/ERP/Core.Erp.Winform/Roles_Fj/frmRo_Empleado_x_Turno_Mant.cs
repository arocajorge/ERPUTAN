using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using System.Threading;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Reportes.Roles;
using Core.Erp.Recursos.Properties;
using System.Threading.Tasks;

namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Empleado_x_Turno_Mant : Form
    {
        public frmRo_Empleado_x_Turno_Mant()
        {
            InitializeComponent();
            Carga_Inicial();
        }
        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_planificacion_x_jornada_desfasada_empleado_Info> lista_empleado = new List<ro_planificacion_x_jornada_desfasada_empleado_Info>();
        ro_planificacion_x_jornada_desfasada_empleado_Bus Bus_empleado = new ro_planificacion_x_jornada_desfasada_empleado_Bus();
        List<ro_turno_Info> lista_turnos = new List<ro_turno_Info>();
        ro_turno_Bus bus_turno = new ro_turno_Bus();
        List<ro_Cargo_Info> lista_cargo = new List<ro_Cargo_Info>();
        ro_Cargo_Bus Bus_cargo = new ro_Cargo_Bus();
        List<ro_periodo_Info> lista_periodo = new List<ro_periodo_Info>();
        ro_periodo_Bus bus_periodo = new ro_periodo_Bus();

        ro_periodo_Info info_Periodo = new ro_periodo_Info();
        ro_planificacion_x_jornada_desfasada_Info Info_planificacion = new ro_planificacion_x_jornada_desfasada_Info();
        ro_planificacion_x_jornada_desfasada_Bus Bus_planificacion = new ro_planificacion_x_jornada_desfasada_Bus();



        List<ro_division_Info> ListaDivision = new System.Collections.Generic.List<ro_division_Info>();
        ro_division_Bus Bus_division = new ro_division_Bus();


        public Cl_Enumeradores.eTipo_action Accion { get; set; }


        private void frmRo_Empleado_x_Turno_Mant_Load(object sender, EventArgs e)
        {
            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    cmb_periodo.Properties.ReadOnly = true;
                    cmb_turnos.Properties.ReadOnly = true;
                    cmbnomina.Properties.ReadOnly = true;
              
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                      cmb_periodo.Properties.ReadOnly = true;
                    cmb_turnos.Properties.ReadOnly = true;
                    cmbnomina.Properties.ReadOnly = true;
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    cmb_periodo.Properties.ReadOnly = true;
                    cmb_turnos.Properties.ReadOnly = true;
                    cmbnomina.Properties.ReadOnly = true;
                    break;
                case Cl_Enumeradores.eTipo_action.duplicar:
                    break;
                default:
                    break;
            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (info_Periodo == null)
                    info_Periodo = lista_periodo.Where(v => v.IdPeriodo == Info_planificacion.IdPeriodo).FirstOrDefault();
                // si no exite departamento y cargo selecionado


                if (cmb_division.EditValue != null)
                {
                    lista_empleado = Bus_empleado.Get_list_empleado_con_jornada_desfasada_car(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), info_Periodo, Convert.ToDecimal(cmb_division.EditValue),  Convert.ToInt32(cmb_turnos_cambia_usuario.EditValue));
                    gridControl_Turnos.DataSource = lista_empleado;
                }


                if ((cmb_cargo.EditValue != "" && cmb_cargo.EditValue != null) && (cmb_departamento.get_departamentoInfo() == null))
                {
                    lista_empleado = Bus_empleado.Get_list_empleado_con_jornada_desfasada(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), info_Periodo, Convert.ToInt32(cmb_turnos_cambia_usuario.EditValue));
                    gridControl_Turnos.DataSource = lista_empleado;
                    return;
                }

                // si existe departamento y cargo selecionado
                if ((cmb_cargo.EditValue != "" && cmb_cargo.EditValue != null) && (cmb_departamento.get_departamentoInfo()!=null))
                {
                    lista_empleado = Bus_empleado.Get_list_empleado_con_jornada_desfasada(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), info_Periodo, Convert.ToInt32(cmb_departamento.get_departamentoInfo().IdDepartamento), Convert.ToInt32(cmb_cargo.EditValue), Convert.ToInt32(cmb_turnos_cambia_usuario.EditValue));
                    gridControl_Turnos.DataSource = lista_empleado;
                    return;
                }

                // si existe departamento seleccionado y no cargo
                if ((cmb_cargo.EditValue != "" && cmb_cargo.EditValue != null) && (cmb_departamento.get_departamentoInfo() != null))
                {
                    lista_empleado = Bus_empleado.Get_list_empleado_con_jornada_desfasada_dep(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), info_Periodo, Convert.ToInt32(cmb_departamento.get_departamentoInfo().IdDepartamento), Convert.ToInt32(cmb_turnos_cambia_usuario.EditValue));
                    gridControl_Turnos.DataSource = lista_empleado;
                    return;
                }

                // si existe cargo y no departamentos
                if ((cmb_cargo.EditValue != "" && cmb_cargo.EditValue != null) && (cmb_departamento.get_departamentoInfo()==null))
                {
                    lista_empleado = Bus_empleado.Get_list_empleado_con_jornada_desfasada_car(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), info_Periodo, Convert.ToInt32(cmb_cargo.EditValue), Convert.ToInt32(cmb_turnos_cambia_usuario.EditValue));
                    gridControl_Turnos.DataSource = lista_empleado;
                    return;
                }

               


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }
        private void cmb_periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_Periodo = (ro_periodo_Info)cmb_periodo.Properties.View.GetFocusedRow();
                if (info_Periodo == null)
                    info_Periodo = lista_periodo.Where(v => v.IdPeriodo == Info_planificacion.IdPeriodo).FirstOrDefault();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        public void Get()
        {
            try
            {

                Info_planificacion.IdEmpresa = param.IdEmpresa;
                Info_planificacion.IdPeriodo =Convert.ToInt32( cmb_periodo.EditValue);
                Info_planificacion.Observación = txtobservacion.EditValue.ToString();
                Info_planificacion.IdUsuario = param.IdUsuario;
                Info_planificacion.IdNomina_Tipo=Convert.ToInt32(cmbnomina.EditValue);
                
                foreach (var item in lista_empleado)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdPeriodo = info_Periodo.IdPeriodo;
                    item.IdMes = info_Periodo.pe_mes;
                    item.IdAnio = info_Periodo.pe_anio;                    
                }
                Info_planificacion.Lista = lista_empleado;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        public void Set(ro_planificacion_x_jornada_desfasada_Info info_)
        {
            try
            {
                Info_planificacion = info_;
                cmb_periodo.EditValue = info_.IdPeriodo;
                txtobservacion.EditValue = info_.Observación;
                cmbnomina.EditValue = info_.IdNomina_Tipo;
                if (Info_planificacion.Esta_Proceso == "ABIERTO")
                    lb_estado.Text = " PLANIFICACIÓN ABIERTA";
                else
                    lb_estado.Text = " PLANIFICACIÓN CERRADA";
                // busca el detalle

                lista_empleado = Bus_empleado.Listado_planificacion_x_periodo(param.IdEmpresa, info_.IdNomina_Tipo, info_.IdPeriodo);
                gridControl_Turnos.DataSource = lista_empleado;
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        public void Carga_Inicial()
        {
            try
            {
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
                lista_turnos = bus_turno.ConsListTurno(param.IdEmpresa);
                cmb_turnos.DataSource = lista_turnos;
                cmb_turnos.ValueMember = "IdTurno";
                cmb_turnos.DisplayMember = "tu_descripcion";
                cmb_turnos_cambia_usuario.Properties.DataSource = lista_turnos;
                lista_cargo = Bus_cargo.ObtenerLstCargo(param.IdEmpresa);
                cmb_cargo.Properties.DataSource = lista_cargo;

                lista_periodo = bus_periodo.Get_periodos(param.IdEmpresa);
                cmb_periodo.Properties.DataSource = lista_periodo;


                ListaDivision = Bus_division.ConsultaGeneral(param.IdEmpresa);
                cmb_division.Properties.DataSource = ListaDivision;


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        public bool Grabar()
        {
            try
            {

                if (Bus_planificacion.Guardar_DB(Info_planificacion))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return false;
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        
        }
        public bool modificar()
        {
            try
            {

                if (Bus_planificacion.Modificar_DB(Info_planificacion))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return false;
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        public bool Guardar()
        {
            try
            {
                Get();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       return Grabar();

                    case Cl_Enumeradores.eTipo_action.actualizar:
                       return modificar();
                  
                    default:
                       return false;
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
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
                MessageBox.Show(ex.ToString());
            }
        }
        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                    if (Guardar())
                        Limpiar();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmb_cerrar_planificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (Bus_planificacion.Cerrar_Planificacion(Info_planificacion))
                {
                    MessageBox.Show("La planificacion fue cerrada exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al intentar cerrar laplanificación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridView_turnos_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                var data = gridView_turnos.GetRow(e.RowHandle) as ro_planificacion_x_jornada_desfasada_empleado_Info ;
                if (data == null)
                    return;

                if (data.Num_jornada_desfasada >= 1 && data.Num_jornada_desfasada <=2)
                    e.Appearance.ForeColor = Color.Orange;
                if (data.Num_jornada_desfasada >= 3&& data.Num_jornada_desfasada <=5)
                    
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        public void Limpiar()
        {
            try
            {
                lista_empleado = new List<ro_planificacion_x_jornada_desfasada_empleado_Info>();
                gridControl_Turnos.DataSource = lista_empleado;
                txtobservacion.EditValue = "";
                cmb_periodo.EditValue = null;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public bool Validar()
        {
            bool ba_sicorrecto = true;
            try
            {
                if (txtobservacion.EditValue == null || txtobservacion.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la)+" observación",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ba_sicorrecto=false;
                }


                 if (lista_empleado.Count()==0)
                {
                    MessageBox.Show("No hay registro para guardar",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ba_sicorrecto=false;
                }


                 if (cmb_periodo.EditValue==null || cmb_periodo.EditValue=="")
                 {
                     MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                     ba_sicorrecto = false;
                 }

                 return ba_sicorrecto;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
