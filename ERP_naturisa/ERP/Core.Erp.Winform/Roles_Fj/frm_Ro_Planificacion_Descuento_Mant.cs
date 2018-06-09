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
    public partial class frm_Ro_Planificacion_Descuento_Mant : Form
    {
        public frm_Ro_Planificacion_Descuento_Mant()
        {
            InitializeComponent();
            Cargar_data();
        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public Cl_Enumeradores.eTipo_action Accion { get; set; }
        string mensaje = "";
        decimal _idEmpleado = 0;



        ro_Empleado_Info info_empleado = new ro_Empleado_Info();
        List<ro_Empleado_Info> lista_empleado = new List<ro_Empleado_Info>();
        ro_Empleado_Bus bus_empleado = new ro_Empleado_Bus();
        ro_descuento_no_planificados_Info info_descuento = new ro_descuento_no_planificados_Info();
        ro_descuento_no_planificados_Bus bus_descuento = new ro_descuento_no_planificados_Bus();
        List<ro_descuento_no_planificados_Info> lista_descuento = new List<ro_descuento_no_planificados_Info>();




        BindingList<ro_descuento_no_planificados_Det_Info> lista_descuento_Det = new BindingList<ro_descuento_no_planificados_Det_Info>();
        ro_descuento_no_planificados_Det_Bus bus_detalle = new ro_descuento_no_planificados_Det_Bus();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        ro_Nomina_Tipoliqui_Bus bus_nomina_tipo_liq = new ro_Nomina_Tipoliqui_Bus();


        private void frm_Ro_Planificacion_Descuento_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                gridControl_descuento_planificado.DataSource = lista_descuento_Det;
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
                cmb_nomina_tipo_liq.DisplayMember = "DescripcionProcesoNomina";
                cmb_nomina_tipo_liq.ValueMember = "IdNomina_TipoLiqui";


                info_empleado = (ro_Empleado_Info)cmbEmpleado.Properties.View.GetFocusedRow();
                if (info_empleado == null)
                    info_empleado = lista_empleado.Where(v => v.IdEmpleado == _idEmpleado).FirstOrDefault();

                lista_descuento = bus_descuento.listado_Descuento(param.IdEmpresa, info_empleado.IdNomina_Tipo, Convert.ToInt32(_idEmpleado));
                cmb_descuento.Properties.DataSource = lista_descuento;


                ListadoTipoLiquidacion = bus_nomina_tipo_liq.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(info_empleado.IdNomina_Tipo));
                cmb_nomina_tipo_liq.DataSource = ListadoTipoLiquidacion;

                txt_cargo.EditValue = info_empleado.cargo;
                txt_cedula.EditValue = info_empleado.InfoPersona.pe_cedulaRuc;
                txt_departamento.EditValue = info_empleado.de_descripcion;
  

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
                txt_cargo.Focus();
                
                if (bus_descuento.Guardar_DB(info_descuento))
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
      

        private void Get()
        {
            try
            {
                
                info_descuento.IdUsuario = param.IdUsuario;
                info_descuento.Fecha_Transaccion = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                foreach (var item in lista_descuento_Det)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdEmpleado = _idEmpleado;
                    item.IdNomina_Tipo = info_empleado.IdNomina_Tipo;
                    item.IdRubro = info_descuento.IdRubro;
                    
                }
                info_descuento.lista = lista_descuento_Det.ToList();
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

                if (cmb_descuento.EditValue == null || cmb_descuento.EditValue == "")
                {
                    ban = false;
                    MessageBox.Show( param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Rubro",param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ban;
                }



                if (cmbEmpleado.EditValue == null || cmbEmpleado.EditValue == "")
                {
                    ban = false;
                    MessageBox.Show( param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Empleado",param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ban;

                }

                if (cmb_descuento.EditValue == null || cmb_descuento.EditValue == "")
                {
                    ban = false;
                    MessageBox.Show( param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " valor a descontar",param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ban;

                }

                if (Convert.ToDouble( txt_valor.EditValue)>lista_descuento_Det.Sum(v=>v.Valor) )
                {
                    ban = false;
                    MessageBox.Show( "El Valor del detalle es menor que el total",param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ban;

                }
                if (Convert.ToDouble(txt_valor.EditValue) < lista_descuento_Det.Sum(v => v.Valor))
                {
                    ban = false;
                    MessageBox.Show("El Valor del detalle es mayor que el total", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                info_descuento = info;
                _idEmpleado = info.IdEmpleado;
                cmbEmpleado.EditValue = info.IdEmpleado;
                cmb_descuento.EditValue = info.IdRubro;
                txt_valor.EditValue = info.Valor;
                


                lista_descuento_Det =new BindingList<ro_descuento_no_planificados_Det_Info>( bus_detalle.listado_Descuento(info_descuento.IdEmpresa, info_descuento.IdNomina_Tipo, info_descuento.IdEmpleado, info_descuento.IdDescuento));
                gridControl_descuento_planificado.DataSource = lista_descuento_Det.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
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
                        return Grabar();
                        return false;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        return false;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Planificar descuento")
                    grop_box_detalle.Visible = true;
                else
                    grop_box_detalle.Visible = false;
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

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                Guardar_Datos();
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
                if (!Validar())
                    return;
                if (Guardar_Datos())
                    this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void gridView_descuento_planificado_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //eliminar

            if (e.Column.Name == "Col_eliminar")
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gridView_descuento_planificado.DeleteSelectedRows();
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
