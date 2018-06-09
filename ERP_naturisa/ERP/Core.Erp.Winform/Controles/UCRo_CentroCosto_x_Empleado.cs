/*CLASE: UCRo_CentroCosto_x_Empleado
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
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCRo_CentroCosto_x_Empleado : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string MensajeError = "";
        public decimal _idEmpleado;
        private int IdEmpresa;
        public Cl_Enumeradores.eTipo_action Accion;

        //CENTRO DE COSTO X EMPLEADO
        List<ro_empleado_x_centro_costo_Info> oListRo_empleado_x_centro_costo_Info = new List<ro_empleado_x_centro_costo_Info>();
        ro_empleado_x_centro_costo_Bus oRo_empleado_x_centro_costo_Bus = new ro_empleado_x_centro_costo_Bus();
        ro_empleado_x_centro_costo_Info oRo_empleado_x_centro_costo_Info = new ro_empleado_x_centro_costo_Info();

        //DELEGADOS
        public  delegate void delegate_cmbCentroCosto_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbCentroCosto_EditValueChanged event_cmbCentroCosto_EditValueChanged;

        public void setCentroCosto(string idCentroCosto)
        {
            try
            {
                cmbCentroCosto.EditValue = idCentroCosto;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void setCentroCosto(int IdEmpresa_, decimal idEmpleado)
        {
            try
            {
                _idEmpleado = idEmpleado;
                IdEmpresa = IdEmpresa_;
                pu_CargaInicial();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public string getIdCentroCosto()
        {
            try
            {
                return cmbCentroCosto.EditValue.ToString();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }
        }



        public ro_empleado_x_centro_costo_Info getInfoCentroCosto()
        {
            try
            {
                oRo_empleado_x_centro_costo_Info = oListRo_empleado_x_centro_costo_Info.FirstOrDefault(v => v.IdCentroCosto == Convert.ToString(cmbCentroCosto.EditValue));
              //  Info = (ct_Centro_costo_Info)cmb_centrocosto.Properties.View.GetFocusedRow();
                return oRo_empleado_x_centro_costo_Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ro_empleado_x_centro_costo_Info();
            }
        }


        public UCRo_CentroCosto_x_Empleado()
        {
            InitializeComponent();
            event_cmbCentroCosto_EditValueChanged += UCRo_CentroCosto_x_Empleado_event_cmbCentroCosto_EditValueChanged;

        }

        void UCRo_CentroCosto_x_Empleado_event_cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
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
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                         oListRo_empleado_x_centro_costo_Info = oRo_empleado_x_centro_costo_Bus.Get_List_empleado_x_centro_costo(param.IdEmpresa, ref MensajeError);
                        cmbCentroCosto.Properties.DataSource = oListRo_empleado_x_centro_costo_Info;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        oListRo_empleado_x_centro_costo_Info = oRo_empleado_x_centro_costo_Bus.Get_List_CentroCosto_X_emplead(param.IdEmpresa,_idEmpleado, ref MensajeError);
                        cmbCentroCosto.Properties.DataSource = oListRo_empleado_x_centro_costo_Info;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        oListRo_empleado_x_centro_costo_Info = oRo_empleado_x_centro_costo_Bus.Get_List_CentroCosto_X_emplead(param.IdEmpresa, _idEmpleado, ref MensajeError);
                       cmbCentroCosto.Properties.DataSource = oListRo_empleado_x_centro_costo_Info;
                        break;
                    default:
                        break;
                }

                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCRo_CentroCosto_x_Empleado_Load(object sender, EventArgs e)
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

        private void cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        {try
            {
            event_cmbCentroCosto_EditValueChanged(sender, e);
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
