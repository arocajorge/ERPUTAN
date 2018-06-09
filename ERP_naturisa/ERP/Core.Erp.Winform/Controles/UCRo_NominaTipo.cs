/*CLASE: UCRo_NominaTipo
 *CREADO POR: ALBERTO MENA
 *FECHA: 22-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCRo_NominaTipo : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string MensajeError = "";
        decimal _idEmpleado=0;

        //NominaTipo
        List<ro_Empleado_TipoNomina_Info> InfoTipoNomina = new List<ro_Empleado_TipoNomina_Info>();
        ro_Empleado_TipoNomina_Bus Bus_Tnomina = new ro_Empleado_TipoNomina_Bus();

        //DELEGADOS
        public delegate void delegate_cmbNominaTipo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbNominaTipo_EditValueChanged event_cmbNominaTipo_EditValueChanged;

        public UCRo_NominaTipo()
        {
            InitializeComponent();
            event_cmbNominaTipo_EditValueChanged += UCRo_NominaTipo_event_cmbNominaTipo_EditValueChanged;
        }

        void UCRo_NominaTipo_event_cmbNominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void pu_CargaInicial()
        {
            try
            {
                if (_idEmpleado==0)
                    {

                        ro_Nomina_Tipo_Bus Bus_TipoNo = new ro_Nomina_Tipo_Bus();
                        List<ro_Nomina_Tipo_Info> InfoTipoNomina = new List<ro_Nomina_Tipo_Info>();
                        InfoTipoNomina = Bus_TipoNo.Get_List_Nomina_Tipo(param.IdEmpresa);
                        cmbNominaTipo.Properties.DataSource = InfoTipoNomina;


                }else{
                    InfoTipoNomina = Bus_Tnomina.Get_List_Empleado_TipoNomina_x_IdEmpleado(param.IdEmpresa, _idEmpleado);
                    cmbNominaTipo.Properties.DataSource = InfoTipoNomina;
                }            
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCRo_NominaTipo_Load(object sender, EventArgs e)
        {
            try
            {
                pu_CargaInicial();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public string getIdNominaTipo()
        {
            try
            {

                return cmbNominaTipo.EditValue.ToString();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }
        }


        public void setIdNominaTipo()
        {
            try
            {
                pu_CargaInicial();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void setIdNominaTipo(int idNominaTipo)
        {
            try
            {
                cmbNominaTipo.EditValue = idNominaTipo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void setIdEmpleado(decimal idEmpleado)
        {
            try
            {
                _idEmpleado = idEmpleado;
                pu_CargaInicial();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        private void cmbNominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbNominaTipo_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        
    }
}
