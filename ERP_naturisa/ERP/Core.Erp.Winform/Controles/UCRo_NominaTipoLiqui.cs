/*CLASE: UCRo_NominaTipoLiqui
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
    public partial class UCRo_NominaTipoLiqui : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string MensajeError = "";
        int _NominaTipo;
        int _NominaTipoLiqui;

    
        //NominaTipo
        List<ro_Nomina_Tipoliqui_Info> oListRo_Nomina_Tipoliqui_Info = new List<ro_Nomina_Tipoliqui_Info>();
        ro_Nomina_Tipoliqui_Bus oRo_Nomina_Tipoliqui_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_Nomina_Tipoliqui_Info oRo_Nomina_Tipoliqui_Info = new ro_Nomina_Tipoliqui_Info();

        //DELEGADOS
        public delegate void delegate_cmbNominaTipoLiqui_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbNominaTipoLiqui_EditValueChanged event_cmbNominaTipoLiqui_EditValueChanged;


        public UCRo_NominaTipoLiqui()
        {
            InitializeComponent();
            event_cmbNominaTipoLiqui_EditValueChanged += UCRo_NominaTipoLiqui_event_cmbNominaTipoLiqui_EditValueChanged;
        }


        public string getNominaTipoLiqui()
        {
            try
            {
                return cmbNominaTipoLiqui.EditValue.ToString();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }
        }

        public void setIdNominaTipo(int idNominaTipo)
        {
            try
            {
                _NominaTipo = idNominaTipo;
                pu_CargaInicial();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return;
            }
        }



        public void setIdNominaTipoLiqui(int idNominaTipoLiqui)
        {
            try
            {
                _NominaTipoLiqui = idNominaTipoLiqui;
                cmbNominaTipoLiqui.EditValue = _NominaTipoLiqui;
                pu_CargaInicial();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        private void pu_CargaInicial() {
            try
            {
                oListRo_Nomina_Tipoliqui_Info = oRo_Nomina_Tipoliqui_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, _NominaTipo);
                cmbNominaTipoLiqui.Properties.DataSource = oListRo_Nomina_Tipoliqui_Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void UCRo_NominaTipoLiqui_event_cmbNominaTipoLiqui_EditValueChanged(object sender, EventArgs e)
        { }

        private void cmbNominaTipoLiqui_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbNominaTipoLiqui_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        private void UCRo_NominaTipoLiqui_Load(object sender, EventArgs e)
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
    }
}
