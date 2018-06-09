using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;

// haac
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;

namespace Core.Erp.Winform.Roles
{
    
    public partial class frmXROL_NominaGeneral : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Nomina_Tipo_Bus Bus_TipoNo = new ro_Nomina_Tipo_Bus();
        ro_periodo_Bus Bus_Periodo = new ro_periodo_Bus();
        ro_Nomina_Tipoliqui_Bus Bus_TipoNominaLiqui = new ro_Nomina_Tipoliqui_Bus();
        ro_division_Bus Bus_Division = new ro_division_Bus();
        /*catalogos de ro_depatamento */
        UCRo_Departamento UCRDep = new UCRo_Departamento();
        public ro_Departamento_Info _dptInfoPadre { get; set; }
        List<ro_periodo_Info> InfoPeriodo = new List<ro_periodo_Info>();
        ro_ObtenerReporte_Bus busObtRpt = new ro_ObtenerReporte_Bus();
        List<tbROL_NominaGeneral_Info> lista = new List<tbROL_NominaGeneral_Info>();

        #endregion
               
        public frmXROL_NominaGeneral()
        {
            try
            {
                 InitializeComponent();
                 ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void IniciarControles()
        {
            try
            {

                UCRDep.set_Treelist_SelectMultiple(true);
                UCRDep.TreeListDepartamento.OptionsSelection.MultiSelect = true;
                UCRDep._Solo_chequea_unItem = false;

                UCRDep.set_Treelist_AllowRecursiveNodeChecking(true);
                UCRDep.Dock = DockStyle.Fill;

                panelDepartamento.Controls.Add(UCRDep);
                UCRDep.ExpandAll();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }       

        void Load_datos()
        {
            try
            {
                // Cargando Combo de Tipo de Nomina
                List<ro_Nomina_Tipo_Info> InfoTipoNomina = new List<ro_Nomina_Tipo_Info>();
                InfoTipoNomina = Bus_TipoNo.Get_List_Nomina_Tipo(param.IdEmpresa);
                this.cmbNomina.Properties.DataSource = InfoTipoNomina;

                // Cargando Combo periodo
                InfoPeriodo = Bus_Periodo.Get_periodos(param.IdEmpresa);
                this.cmbPeriodo.Properties.DataSource = InfoPeriodo;

                // Cargando Combo Division
                List<ro_division_Info> InfoDivision = new List<ro_division_Info>();
                InfoDivision = Bus_Division.ConsultaGeneral(param.IdEmpresa);
                this.cmbDivision.Properties.DataSource = InfoDivision;

                UCRDep.set_Treelist_SelectMultiple(true);
                UCRDep._Solo_chequea_unItem = false;
                UCRDep.Dock = DockStyle.Fill;

                panelDepartamento.Controls.Add(UCRDep);
                UCRDep.ExpandAll();
                UCRDep.set_Treelist_AllowRecursiveNodeChecking(true); UCRDep.set_DepartamentoCheckedSelection(_dptInfoPadre);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void frmXROL_NominaGeneral_Load(object sender, EventArgs e)
        {
            try
            {
                 Load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void cmbNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbNomina.EditValue != null)
                {
                    int numero;
                    numero = Convert.ToInt32(cmbNomina.EditValue);

                    // Cargando Combo Proceso 
                    List<ro_Nomina_Tipoliqui_Info> InfoNominaTipoliqui = new List<ro_Nomina_Tipoliqui_Info>();
                    InfoNominaTipoliqui = Bus_TipoNominaLiqui.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, numero);
                    this.cmbProceso.Properties.DataSource = InfoNominaTipoliqui;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
       
        void procesar()
        {
            try
            {
                
                int divisionini = 0;
                int divisionfin = 0;
                if (Convert.ToInt32(cmbDivision.EditValue) != 0)
                {
                    divisionini = Convert.ToInt32(cmbDivision.EditValue);
                    divisionfin = Convert.ToInt32(cmbDivision.EditValue);

                }
                else
                {
                    divisionini = 0;
                    divisionfin = 9000;
                }

                lista = busObtRpt.OptenerData_spROL_NominaGeneral(param.IdEmpresa, Convert.ToInt32(cmbPeriodo.EditValue),
                    Convert.ToInt32(cmbNomina.EditValue), Convert.ToInt32(cmbProceso.EditValue),
                    divisionini, divisionfin,
                    0, 50000, param.IdUsuario, param.nom_pc);
                string ordenado = "E";
                if (cmbOrdenado.Text.Trim() != "Empleado")
                    ordenado = "D";

                 
                string tiporpte = "Det";
                if (cmbTpRpte.Text.Trim() != "Detallado")
                    tiporpte = "Res";
                List<ro_Departamento_Info> departamentos = new List<ro_Departamento_Info>();
                departamentos = UCRDep.get_Departamentosinfo();
                if (departamentos == null || departamentos.Count == 0)
                {
                    var a= UCRDep.TreeListDepartamento.DataSource;
                    if(a!= null)
                    {
                        departamentos = (List<ro_Departamento_Info>)a;
                    }
                }
                //departamentos = UCRDep.
                List<tbROL_NominaGeneral_Info> temp = new List<tbROL_NominaGeneral_Info>();
                foreach (var item in lista)
                {
                    foreach (var dep in departamentos)
                    {
                        if (item.IdDepartamento == dep.IdDepartamento)
                            temp.Add(item);
                    }
                }

                
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        
        }

        private void btnProcesaRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaciones())
                {
                    procesar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               UCRDep.set_Treelist_SelectMultiple(true);
                UCRDep._Solo_chequea_unItem = false;
                //UCRDep.Dock = DockStyle.Fill;

                //panelDepartamento.Controls.Add(UCRDep);
                UCRDep.ExpandAll();
                UCRDep.set_Treelist_AllowRecursiveNodeChecking(true); UCRDep.set_DepartamentoCheckedSelection(_dptInfoPadre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }     
        }

        private Boolean validaciones()
        {
            Boolean res = false;
            try
            {
                if (cmbNomina .EditValue == null)
                {
                    MessageBox.Show("Ingrese la Nómina por favor.", "Sistema");
                    cmbNomina.Focus();
                    return false;
                }
                if (cmbProceso.EditValue == null)
                {
                    MessageBox.Show("Ingrese el proceso por favor.", "Sistema");
                    cmbProceso.Focus();
                    return false;
                }
                
                if (cmbPeriodo.EditValue == null) {
                    MessageBox.Show("Ingrese el periodo por favor.","Sistema");
                    cmbPeriodo.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(cmbTpRpte.Text))
                {
                    MessageBox.Show("Ingrese el Tipo de Reporte por favor.", "Sistema");
                    cmbTpRpte.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(cmbOrdenado.Text))
                {
                    MessageBox.Show("Ingrese el Ordenado por favor.", "Sistema");
                    cmbOrdenado.Focus();
                    return false;
                }
                res = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
            return res;
        }

        //private void btnSalir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}
    
    }
}
