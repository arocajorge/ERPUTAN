using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Registro_valores_pago_variables_Mant : Form
    {

        #region variable
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Cl_Enumeradores.eTipo_action Accion { get; set; }


        ro_periodo_x_ro_Nomina_TipoLiqui_Info ro_periodo_info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

        ro_Nomina_Tipoliqui_Bus Bus_TipoL = new ro_Nomina_Tipoliqui_Bus();
        List<ro_Nomina_Tipoliqui_Info> InfoTipoLiqui = new List<ro_Nomina_Tipoliqui_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        
        
        ro_fectividad_x_empleado_Adm_x_periodo_Info info_efectividad_entrega = new ro_fectividad_x_empleado_Adm_x_periodo_Info();
        BindingList<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista_detalle = new BindingList<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info>();
        ro_fectividad_x_empleado_Adm_x_periodo_Bus bus = new ro_fectividad_x_empleado_Adm_x_periodo_Bus();
        ro_fectividad_x_empleado_Adm_x_periodo_Det_Bus bus_detalle = new ro_fectividad_x_empleado_Adm_x_periodo_Det_Bus();




        #endregion
     
        public frmRo_Registro_valores_pago_variables_Mant()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmRo_Registro_valores_pago_variables_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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






        void Get()
        {
            try
            {
                info_efectividad_entrega = new ro_fectividad_x_empleado_Adm_x_periodo_Info();
                info_efectividad_entrega.detalle = new List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info>();
                info_efectividad_entrega.IdEmpresa = param.IdEmpresa;
                info_efectividad_entrega.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                info_efectividad_entrega.IdNomina_Tipo_Liq = Convert.ToInt32(cmbnominaTipo.EditValue);
                info_efectividad_entrega.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                info_efectividad_entrega.Observacion = txt_observacion.Text;
                info_efectividad_entrega.IdUsuario = param.IdUsuario;
                info_efectividad_entrega.Fecha_Transaccion = DateTime.Now;
                info_efectividad_entrega.IdUsuarioUltModi = param.IdUsuario;
                info_efectividad_entrega.Fecha_UltMod = DateTime.Now;

                foreach (var item in lista_detalle)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                    item.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                    item.IdNomina_Tipo_Liq = Convert.ToInt32(cmbnominaTipo.EditValue);
                    item.fechaPago = ro_periodo_info.pe_FechaIni.AddDays(1);
                }

                info_efectividad_entrega.detalle = lista_detalle.ToList();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool Validar()
        {
            try
            {
                if (cmbnomina.EditValue == null || cmbnomina.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbnominaTipo.EditValue == null || cmbnominaTipo.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbPeriodos.EditValue == null || cmbPeriodos.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Seleccione el periodo para la planificación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txt_observacion.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Ingrese una observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        bool Grabar()
        {
            try
            {
                Get();
                if (bus.Guardar_DB(info_efectividad_entrega))
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        bool Modificar()
        {
            try
            {
                Get();
                if (bus.Modificar_DB(info_efectividad_entrega))
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        bool Anular()
        {
            try
            {
                Get();
                if (bus.Anular_DB(info_efectividad_entrega))
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        bool Guardar_Datos()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        return Grabar();
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        return Modificar();
                    case Cl_Enumeradores.eTipo_action.Anular:
                        return Anular();
                  
                    default:
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



        public void Set(ro_fectividad_x_empleado_Adm_x_periodo_Info info)
        {
            try
            {
                txt_observacion.Text = info.Observacion;
                cmbnomina.EditValue = info.IdNomina_Tipo;
                cmbnominaTipo.EditValue = info.IdNomina_Tipo_Liq;
                cmbPeriodos.EditValue = info.IdPeriodo;

                lista_detalle = new BindingList<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info>(bus_detalle.lista_Efectividad_x_empleado_x_periodod(param.IdEmpresa, info.IdNomina_Tipo,info.IdNomina_Tipo_Liq,info.IdPeriodo));
                gridControl_empleados.DataSource = lista_detalle;

                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 switch (Accion)
                {


                    case Cl_Enumeradores.eTipo_action.grabar:
                        Calcular();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                
                  Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_recalcular_MouseHover(object sender, EventArgs e)
        {
           
        }


        public void Calcular()
        {
            try
            {
                         ro_periodo_info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();        
                         ro_periodo_info=(ro_periodo_x_ro_Nomina_TipoLiqui_Info) cmbPeriodos.Properties.View.GetFocusedRow();
                         lista_detalle = new BindingList<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info>(bus_detalle.lista_Efectividad_x_empleado_x_periodod( ro_periodo_info));
                         gridControl_empleados.DataSource = lista_detalle;
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_recalcular_Click(object sender, EventArgs e)
        {
            try
            {
              gridControl_empleados.DataSource=  bus_detalle.Calcular(lista_detalle.ToList(),ro_periodo_info);
            }
            catch (Exception ex)
            {
                
              Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {  if(Validar())
                if (Guardar_Datos())
                    this.Close();
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
                if (Validar())
                    Guardar_Datos();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
