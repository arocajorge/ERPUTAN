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
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Parametro_Pago_Variable_Adm_Mant : Form
    {
        public frmRo_Parametro_Pago_Variable_Adm_Mant()
        {
            InitializeComponent();
        }
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        ro_parametro_x_pago_variable_Det_Bus bus_detalle = new ro_parametro_x_pago_variable_Det_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        BindingList<ro_parametro_x_pago_variable_Det_Info> lista_detalle = new BindingList<ro_parametro_x_pago_variable_Det_Info>();
        ro_parametro_x_pago_variable_Info Info = new ro_parametro_x_pago_variable_Info();
        ro_parametro_x_pago_variable_Bus bus = new ro_parametro_x_pago_variable_Bus();
        public Cl_Enumeradores.eTipo_action Accion { get; set; }
        List<ro_parametro_x_pago_variable_tipo_Info> lista_tipo_pago_variable = new List<ro_parametro_x_pago_variable_tipo_Info>();
        ro_parametro_x_pago_variable_tipo_Bus bus_Tipo_pago_variable = new ro_parametro_x_pago_variable_tipo_Bus();

        private void frmRo_Parametro_Pago_Variable_Adm_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
                gridControl_Variable.DataSource = lista_detalle;


                lista_tipo_pago_variable = bus_Tipo_pago_variable.Get_lista_tipo_pago_variable(param.IdEmpresa);
                cmb_tipo_pago_variable.ValueMember = "cod_Pago_Variable";
                cmb_tipo_pago_variable.DisplayMember = "nom_Pago_Variable";
                cmb_tipo_pago_variable.DataSource = lista_tipo_pago_variable;


                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
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
                MessageBox.Show(ex.ToString());
            }

        }

        public bool Validar()
        {
            bool banderara = true;
            try
            {
                if (cmbnomina.EditValue == null || cmbnomina.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(Erp.Info.General.enum_Mensajes_sys.Seleccione_la) + " Nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    banderara = false;
                    return banderara;
                }

                if (txtNombre.EditValue == null || txtNombre.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(Erp.Info.General.enum_Mensajes_sys.Ingrese_el) + " Nombre", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    banderara = false;
                    return banderara;
                }

                return banderara;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public void Get()
        {
            try
            {
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdNomina_Tipo =Convert.ToInt32( cmbnomina.EditValue);
                Info.Nombre = txtNombre.EditValue.ToString();
                Info.IdUsuario = param.IdUsuario;
                Info.Fecha_Transaccion = DateTime.Now;
                if(Accion!=Cl_Enumeradores.eTipo_action.grabar)
                Info.Id_Tipo_Pago_Variable =Convert.ToInt32( txtid.EditValue);
                Info.detalle = lista_detalle.ToList();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString()); 
               
            }
        }

        public bool Guardar_Datos()
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

        public bool Grabar()
        {
            try
            {
                int Id_Tipo_Pago_Variable = 0;

                if (bus.Guardar_DB(Info, ref Id_Tipo_Pago_Variable))
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

        public bool Modificar()
        {
            try
            {
                int Id_Tipo_Pago_Variable = 0;

                if (bus.Modificar_DB(Info))
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

        public bool Anular()
        {
            try
            {
                int Id_Tipo_Pago_Variable = 0;

                if (bus.Anular_DB(Info))
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }


        public void Set(ro_parametro_x_pago_variable_Info info_)
        {
            try
            {
                Info = info_;
                cmbnomina.EditValue = Info.IdNomina_Tipo;
                txtNombre.EditValue = Info.Nombre;
                txtid.EditValue = Info.Id_Tipo_Pago_Variable;
                lista_detalle =new BindingList<ro_parametro_x_pago_variable_Det_Info>( bus_detalle.Get_lista_oaram_pago_variable(info_.IdEmpresa, info_.IdNomina_Tipo, info_.Id_Tipo_Pago_Variable));
                gridControl_Variable.DataSource = lista_detalle;
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmb_catalogo_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                foreach (var item in lista_detalle)
                {
                    item.icono_eliminar = true;
                }
              //  gridControl_Variable.RefreshDataSource();
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridView_Variable_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "col_icono_eliminar")
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gridView_Variable.DeleteSelectedRows();
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
