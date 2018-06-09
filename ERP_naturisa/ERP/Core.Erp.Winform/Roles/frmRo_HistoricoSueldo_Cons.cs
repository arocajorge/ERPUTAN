using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_HistoricoSueldo_Cons : Form
    {

        #region Declaración_Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_HistoricoSueldo_Bus OHBus = new ro_HistoricoSueldo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Empleado_Info oEmpInfo = new ro_Empleado_Info();

        #endregion

        public frmRo_HistoricoSueldo_Cons()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public delegate void delegate_frmRo_HistoricoSueldo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_HistoricoSueldo_Mant_FormClosing Event_frmRo_HistoricoSueldo_Mant_FormClosing;

        private void frmRo_HistoricoSueldo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmRo_HistoricoSueldo_Mant_FormClosing(sender, e);
                Load_Datos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_HistoricoSueldo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Event_frmRo_HistoricoSueldo_Mant_FormClosing += new delegate_frmRo_HistoricoSueldo_Mant_FormClosing(Event_frmRo_HistoricoSueldo_Mant_FormClosing);
                this.Fecha.OptionsColumn.AllowEdit = false;
                Load_Datos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
              this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void Load_Datos()
        {
            try
            {
               // this.grdLista.DataSource = OHBus.ConsultaGeneral(param.IdEmpresa, info.IdEmpleado); un empleado
                
               //varios empleados
                List<ro_HistoricoSueldo_Info> historicogeneral = new List<ro_HistoricoSueldo_Info>();
                foreach (var item in ListEmp)
                {
                    var historico = OHBus.Get_List_HistoricoSueldo(param.IdEmpresa, item.IdEmpleado);
                    foreach (var reg in historico)
                    {
                        historicogeneral.Add(reg);
                    }    
                }              
                this.grdLista.DataSource = historicogeneral;
                //varios empleados
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        List<ro_Empleado_Info> ListEmp = new List<ro_Empleado_Info>();
        //public void set_Info(ro_Empleado_Info Info) un empleado
            public void set_Info(List<ro_Empleado_Info> listadoEmpl)
        {
            try
            {
                ListEmp = listadoEmpl;
                //oEmpInfo.IdEmpleado = info.IdEmpleado;  un empleado
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());

            }


        }

            private void frmRo_HistoricoSueldo_Cons_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == (char)(Keys.Escape))
                {
                    this.Close();
                }
            }

    }
}
