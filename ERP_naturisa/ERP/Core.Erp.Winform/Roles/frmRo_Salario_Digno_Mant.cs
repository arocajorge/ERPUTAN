using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Reportes.Roles;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Salario_Digno_Mant : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        //INFO
        BindingList<ro_Empleado_Info> oListRo_Empleado_Info = new BindingList<ro_Empleado_Info>();
        ro_Salario_Digno_Info _Info = new ro_Salario_Digno_Info();

        //BUS
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();

        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();

        public frmRo_Salario_Digno_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Superior_Mant.event_btnSalir_Click += ucGe_Menu_Superior_Mant_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant.event_btnImprimir_Click += ucGe_Menu_Superior_Mant_event_btnImprimir_Click;
                ucGe_Menu_Superior_Mant.event_btnGuardar_Click += ucGe_Menu_Superior_Mant_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Guardar();
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Guardar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        void ucGe_Menu_Superior_Mant_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Imprimir();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        public Boolean getInfo() 
        {
            try 
            {
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdNominaTipo = Convert.ToInt32(ucRo_NominaTipo.getIdNominaTipo());
                _Info.IdPeriodo = Convert.ToInt32(cmbPeriodo.Text);
                _Info.SueldoDigno = Convert.ToDouble(txtSueldoDigno.Text);
                _Info.Observacion = txtObservacion.Text.Trim();
                _Info.UtilidadRepartir = Convert.ToDouble(txtUtilidadRepartir.Text);

                _Info.oListRo_Salario_Digno_Empleado_Info.Clear();

                foreach (ro_Empleado_Info item in oListRo_Empleado_Info)
                {
                    ro_Salario_Digno_Empleado_Info detalle = new ro_Salario_Digno_Empleado_Info();
                    detalle.IdEmpresa = _Info.IdEmpresa;
                    detalle.IdNominaTipo = _Info.IdNominaTipo;
                    detalle.IdPeriodo = _Info.IdPeriodo;
                    detalle.IdEmpleado= item.IdEmpleado;
                    detalle.Valor= item.valorEntregar;

                    _Info.oListRo_Salario_Digno_Empleado_Info.Add(detalle);
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }        
        }



        private void pu_Guardar()
        {
            try
            {

                if (getInfo())
                {
                    ro_Salario_Digno_Bus oRo_Salario_Digno_Bus = new ro_Salario_Digno_Bus();

                    if (oRo_Salario_Digno_Bus.GuardarBD(_Info, ref mensaje))
                    {
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("El registro no se pudo guardar, revise por favor: ", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }



        private void pu_Imprimir() {
            try
            {
                if (getInfo())
                {
                    XROL_Rpt009_frm oXROL_Rpt009_frm = new XROL_Rpt009_frm();
                    oXROL_Rpt009_frm.setInfo(_Info.IdEmpresa, _Info.IdNominaTipo, _Info.IdPeriodo);
                    oXROL_Rpt009_frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }         
        }


        private Boolean pu_Validar() {
            try {
                if (txtSueldoDigno.Text == "")
                {
                    MessageBox.Show("El Valor del Sueldo Digno es Obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtSueldoDigno.Focus();
                    return false;
                }

                if (Convert.ToDouble(txtSueldoDigno.Text) <=0)
                {
                    MessageBox.Show("El Valor del Sueldo Digno debe ser mayor que cero, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtSueldoDigno.Focus(); 
                    return false;
                }

                if (ucRo_NominaTipo.getIdNominaTipo()=="")
                {
                    MessageBox.Show("Debe seleccionar la Nómina, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    ucRo_NominaTipo.Focus();
                    return false;
                }




                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }          
        }


        private void pu_CargarEmpleados() {
            try {

                if (pu_Validar())
                {
                    if (ucRo_NominaTipo.getIdNominaTipo() != null)
                    {
                        oListRo_Empleado_Info = new BindingList<ro_Empleado_Info>(oRo_Empleado_Bus.Get_List_Empleado_x_NominaSueldoDigno(param.IdEmpresa, Convert.ToInt32(ucRo_NominaTipo.getIdNominaTipo()), Convert.ToDouble(txtSueldoDigno.Text), Convert.ToInt32(cmbPeriodo.Text)));
                        gridEmpleado.DataSource = oListRo_Empleado_Info;
                    }

                    txtUtilidadRepartir.Text = Convert.ToDouble(colCompensacion.SummaryText).ToString("N2");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }              
        }



        private void cmdCargarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                pu_CargarEmpleados();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }



        }

        private void pu_CargarInicial(){
            try {

                int anioActual = 0;
                anioActual = param.Fecha_Transac.Year;

                for (int i = 5; i > 0;i--)
                {
                    cmbPeriodo.Items.Add(anioActual);
                    anioActual-=1;
                }

                if(cmbPeriodo.Items.Count>0){
                    cmbPeriodo.SelectedIndex = 0;               
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }      
        }


        private void frmRo_Salario_Digno_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                pu_CargarInicial();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        private void pu_CalcularSueldoDigno() {
            try {

                double totalCompensacion = 0;
                double totalUtilidad = 0;

                totalCompensacion = Convert.ToDouble(colCompensacion.SummaryText);
                totalUtilidad = Convert.ToDouble(txtUtilidadRepartir.Text);
            
                 foreach (ro_Empleado_Info item in oListRo_Empleado_Info)
                {
                    item.proporcionalUtilidad = item.compensacion / totalCompensacion;
                    item.valorEntregar = item.proporcionalUtilidad * totalUtilidad;                  
                }

                gridEmpleado.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }  
        }



        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                pu_CalcularSueldoDigno();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }



    }
}
