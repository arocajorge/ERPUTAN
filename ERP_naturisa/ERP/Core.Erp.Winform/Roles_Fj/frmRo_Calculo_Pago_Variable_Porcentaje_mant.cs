using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Business.Roles_Fj;

namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Calculo_Pago_Variable_Porcentaje_mant : Form
    {
        #region Declaracion de variables
        //generales
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        //Tipo de Nomina General
        ro_Nomina_Tipo_Bus Bus_NominaTipo = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipo_Info Info_NominaTipo = new ro_Nomina_Tipo_Info();
        List<ro_Nomina_Tipo_Info> List_NominaTipo = new List<ro_Nomina_Tipo_Info>();

        //Calculo de Pago vporcentaje
        ro_Calculo_Pago_Variable_Porcentaje_Bus Bus_Calculo = new ro_Calculo_Pago_Variable_Porcentaje_Bus();
        ro_Calculo_Pago_Variable_Porcentaje_Info Info_Calculo = new ro_Calculo_Pago_Variable_Porcentaje_Info();
        List<ro_Calculo_Pago_Variable_Porcentaje_Info> Lista_Calculo = new List<ro_Calculo_Pago_Variable_Porcentaje_Info>();
        BindingList<ro_Calculo_Pago_Variable_Porcentaje_Info> Bind_Lista_Calculo = new BindingList<ro_Calculo_Pago_Variable_Porcentaje_Info>();

        string mensaje = "";
        int IdTipo_Nomina = 0;
        #endregion

        void Cargar_Combos()
        {
            try
            {
                List_NominaTipo = new List<ro_Nomina_Tipo_Info>();
                List_NominaTipo = Bus_NominaTipo.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmb_tipo_nomina.Properties.DataSource = List_NominaTipo;

                //gc_ro_Calculo_Pago_Variable_Porcentaje.DataSource = Bind_Lista_Calculo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get_Info()
        {
            try
            {
                Lista_Calculo = new List<ro_Calculo_Pago_Variable_Porcentaje_Info>();

                foreach (var item in Bind_Lista_Calculo)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdTipo_Nomina = Convert.ToInt32(cmb_tipo_nomina.EditValue);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean Grabar()
        {
            try
            {
                if (cmb_tipo_nomina.EditValue != null)
                {
                    Get_Info();
                    IdTipo_Nomina = Convert.ToInt32(cmb_tipo_nomina.EditValue);
                    Bus_Calculo.ModificarDB(param.IdEmpresa, IdTipo_Nomina, Bind_Lista_Calculo.ToList(), ref mensaje);
                    return true;
                }
                else
                {
                    MessageBox.Show("Escoja un Tipo de nomina para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void Limpiar()
        {
            try
            {
                Cargar_Combos();
                cmb_tipo_nomina.EditValue = null;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmRo_Calculo_Pago_Variable_Porcentaje_mant()
        {
            InitializeComponent();
        }

        private void frmRo_Calculo_Pago_Variable_Porcentaje_mant_Load(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gc_ro_Calculo_Pago_Variable_Porcentaje.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        private void cmb_tipo_nomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                Bind_Lista_Calculo = new BindingList<ro_Calculo_Pago_Variable_Porcentaje_Info>(Bus_Calculo.Get_List_Calculo_Pago_Porcentaje(param.IdEmpresa, Convert.ToInt32(cmb_tipo_nomina.EditValue)));
                gc_ro_Calculo_Pago_Variable_Porcentaje.DataSource = Bind_Lista_Calculo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvw_ro_Calculo_Pago_Variable_Porcentaje_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.ToString() == "46")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gvw_ro_Calculo_Pago_Variable_Porcentaje.DeleteSelectedRows();
                    }
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
