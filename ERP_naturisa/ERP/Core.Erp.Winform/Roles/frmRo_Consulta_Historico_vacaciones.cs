using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Consulta_Historico_vacaciones : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ro_SolicitudVacaciones_Bus busSolicitudVaca = new ro_SolicitudVacaciones_Bus();
        BindingList<ro_historico_vacaciones_x_empleado_Info> Datasource = new BindingList<ro_historico_vacaciones_x_empleado_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public frmRo_Consulta_Historico_vacaciones()
        {
            try
            {
                 InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
 
        }

        public void Consultar(ro_Empleado_Info empinfoVaca,ro_historico_vacaciones_x_empleado_Info histoInfo)
        {
            try
            {
                Datasource = new BindingList<ro_historico_vacaciones_x_empleado_Info>(busSolicitudVaca.CalculoDiasTrabajosDetalle(param.IdEmpresa, histoInfo.FechaInicio, histoInfo.FechaFin, empinfoVaca.IdEmpleado));
                gridControlConsultaH.DataSource = Datasource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmRo_Consulta_Historico_vacaciones_FormClosing(object sender, FormClosingEventArgs e){}

        private void frmRo_Consulta_Historico_vacaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
            }
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
