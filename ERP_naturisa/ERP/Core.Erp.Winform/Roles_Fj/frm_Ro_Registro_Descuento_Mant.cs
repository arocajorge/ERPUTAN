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
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frm_Ro_Registro_Descuento_Mant : Form
    {

        public delegate void delegate_frm_Ro_Registro_Descuento_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frm_Ro_Registro_Descuento_Mant_FormClosing event_frm_Ro_Registro_Descuento_Mant_FormClosing;
        public frm_Ro_Registro_Descuento_Mant()
        {
            InitializeComponent();
            event_frm_Ro_Registro_Descuento_Mant_FormClosing += frm_Ro_Registro_Descuento_Mant_event_frm_Ro_Registro_Descuento_Mant_FormClosing;
            Cargar_data();
        }

        void frm_Ro_Registro_Descuento_Mant_event_frm_Ro_Registro_Descuento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        int iddescuento = 0;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public  Cl_Enumeradores.eTipo_action Accion { get; set; }
        string mensaje = "";
        decimal _idEmpleado = 0;



        ro_Empleado_Info info_empleado = new ro_Empleado_Info();
        List<ro_Empleado_Info> lista_empleado = new List<ro_Empleado_Info>();
        List<ro_rubro_tipo_Info> lista_rubro = new List<ro_rubro_tipo_Info>();
        ro_Empleado_Bus bus_empleado = new ro_Empleado_Bus();
        ro_rubro_tipo_Bus bus_tipo = new ro_rubro_tipo_Bus();

        ro_descuento_no_planificados_Info info_descuento = new ro_descuento_no_planificados_Info();
        ro_descuento_no_planificados_Bus bus_descuento = new ro_descuento_no_planificados_Bus();
        private void frm_Ro_Registro_Descuento_Mant_Load(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        public void Cargar_data()
        {
            try
            {
                lista_empleado = bus_empleado.Get_List_Empleado_(param.IdEmpresa);
                cmbEmpleado.Properties.DataSource = lista_empleado;


                lista_rubro = bus_tipo.Get_list_rubros_concepto(param.IdEmpresa);
                cmb_rubro.Properties.DataSource = lista_rubro;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void frm_Ro_Registro_Descuento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frm_Ro_Registro_Descuento_Mant_FormClosing(sender, e);
        }

        private void Get()
        {
            try
            {
                if (!Validar())
                    return;
                info_descuento = new ro_descuento_no_planificados_Info();
                info_descuento.IdEmpresa = param.IdEmpresa;
                info_descuento.IdNomina_Tipo = info_empleado.IdNomina_Tipo;
                info_descuento.IdEmpleado = info_empleado.IdEmpleado;
                info_descuento.Observacion = txt_observacion.EditValue.ToString();
                info_descuento.IdRubro = cmb_rubro.EditValue.ToString();
                info_descuento.Valor =Convert.ToDouble( txt_multa.EditValue);
                info_descuento.IdUsuario = param.IdUsuario;
                info_descuento.Fecha_Transaccion = DateTime.Now;
                if (txtid.EditValue != null && txtid.EditValue != "")
                    info_descuento.IdDescuento =Convert.ToInt32( txtid.EditValue);
                info_descuento.Fecha_Incidente = dtp_es_fecha_registro.Value;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private bool Validar()
        {
            try
            {
                bool ban = true;

                if(cmb_rubro.EditValue==null || cmb_rubro.EditValue=="")
                {
                    ban = false;
                    MessageBox.Show(param.Nombre_sistema, param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Rubro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ban;
                }



                if (cmbEmpleado.EditValue == null || cmbEmpleado.EditValue == "")
                {
                    ban = false;
                    MessageBox.Show(param.Nombre_sistema, param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ban;

                }

                if (txt_multa.EditValue == null || txt_multa.EditValue == "")
                {
                    ban = false;
                    MessageBox.Show(param.Nombre_sistema, param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " valor a descontar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ban;

                }
                if (dtp_es_fecha_registro.Value == null )
                {
                    ban = false;
                    MessageBox.Show(param.Nombre_sistema, param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ban;

                }
               return ban;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);

                return false;
            }
        }
        public void Set(ro_descuento_no_planificados_Info info)
        {
            try
            {
                _idEmpleado = info.IdEmpleado;
                cmb_rubro.EditValue = info.IdRubro;
                cmbEmpleado.EditValue = info.IdEmpleado;
                txt_multa.EditValue = info.Valor;
                txtid.EditValue = info.IdDescuento;
                txt_observacion.EditValue = info.Observacion;
                dtp_es_fecha_registro.Value = info.Fecha_Incidente;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_empleado = (ro_Empleado_Info)cmbEmpleado.Properties.View.GetFocusedRow();
                if (info_empleado == null)
                    info_empleado = lista_empleado.Where(v => v.IdEmpleado == _idEmpleado).FirstOrDefault();
                txtcedula.EditValue = info_empleado.InfoPersona.pe_cedulaRuc;
                txt_departamento.EditValue = info_empleado.de_descripcion;
                txt_cargo.EditValue = info_empleado.cargo;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

       
        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);

            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar_Datos();

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
                Guardar_Datos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);

            }
        }


        private bool Grabar()
        {
            try
            {
                if (bus_descuento.Guardar_DB(info_descuento, ref iddescuento))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
        }
        private bool Modificar()
        {
            try
            {
                if( bus_descuento.Modificar_DB(info_descuento))
                    {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
        }
        private bool Anular()
        {
            try
            {
                if( bus_descuento.Anular_DB(info_descuento))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Anulada_corectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;

            }
        }


        private bool Guardar_Datos()
        {
            try
            {
                Get();
                
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        return Grabar();
                    case Cl_Enumeradores.eTipo_action.actualizar:
                       return Modificar();
                    case Cl_Enumeradores.eTipo_action.Anular:
                       return Anular();
                    case Cl_Enumeradores.eTipo_action.consultar:
                       return false;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        break;
                    
                    default:
                       return false;
                }

                return false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;

            }

        }


    }
}
