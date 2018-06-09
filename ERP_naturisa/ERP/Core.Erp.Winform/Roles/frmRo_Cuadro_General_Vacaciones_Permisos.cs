/*CLASE: frmRo_Cuadro_General_Vacaciones_Permisos
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 08-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Cuadro_General_Vacaciones_Permisos : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //INFO
        List<ro_Empleado_Info> oRo_Empleado_Info = new List<ro_Empleado_Info>();

        //BUS
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();



        
        public frmRo_Cuadro_General_Vacaciones_Permisos()
        {
            try
            {
                 InitializeComponent();
                 ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                 ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.gridViewVacaciones.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

   

        private void frmRo_Cuadro_General_Vacaciones_Permisos_Load(object sender, EventArgs e)
        {
            try
            {
              dteFechaHasta.EditValue = DateTime.Now.AddDays(-275);
              dteFechaDesde.EditValue = DateTime.Now.AddDays(-365);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
          
        }


        void pu_Consultar()
        {
           try
            {

                ro_historico_vacaciones_x_empleado_Bus oRo_historico_vacaciones_x_empleado_Bus = new ro_historico_vacaciones_x_empleado_Bus();
                oRo_Empleado_Info=oRo_historico_vacaciones_x_empleado_Bus.GenerarVacacionesTodos(Convert.ToDateTime(dteFechaDesde.EditValue), Convert.ToDateTime(this.dteFechaHasta.EditValue));
                gridControlVacaciones.DataSource = oRo_Empleado_Info;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);          
            }
                
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

  



    }
}
