/*CLASE: UCRo_PeriodoXNomina
 *CREADO POR: ALBERTO MENA
 *FECHA: 30-04-2015
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
    public partial class UCRo_PeriodoXNomina : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        int _idEmpresa;
        int _idNominaTipo;
        int _idNominaTipoLiqui;
        int _idPeriodo;

        //INFO
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> oListRo_periodo_x_ro_Nomina_TipoLiqui_Info = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

        //BUS
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();


        //DELEGADOS
        public delegate void delegate_cmbPeriodo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbPeriodo_EditValueChanged event_cmbPeriodo_EditValueChanged;
    

        public UCRo_PeriodoXNomina()
        {            
            InitializeComponent();
            event_cmbPeriodo_EditValueChanged += UCRo_PeriodoXNomina_event_cmbPeriodo_EditValueChanged;
        }

        public UCRo_PeriodoXNomina(int idEmpresa)
        {
            InitializeComponent();
            _idEmpresa = idEmpresa;
            _idEmpresa = param.IdEmpresa;
            event_cmbPeriodo_EditValueChanged += UCRo_PeriodoXNomina_event_cmbPeriodo_EditValueChanged;
        }

        void pu_CargaInicial()
        {
            try
            {
                oListRo_periodo_x_ro_Nomina_TipoLiqui_Info = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
                oListRo_periodo_x_ro_Nomina_TipoLiqui_Info = oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.ConsultaPerNomTipLiq(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui);
                cmbPeriodo.Properties.DataSource = oListRo_periodo_x_ro_Nomina_TipoLiqui_Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

     
 
        private void UCRo_PeriodoXNomina_Load(object sender, EventArgs e)
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
            pu_CargaInicial();
        }


        ////EVENTOS
        private void cmbPeriodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbPeriodo_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }        
        }

        void UCRo_PeriodoXNomina_event_cmbPeriodo_EditValueChanged(object sender, EventArgs e)
        {}

        public string getIdPeriodo()
        {
            try
            {
                return cmbPeriodo.EditValue.ToString();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }
        }

        public string getIdNominaTipo()
        {
            try
            {

                return cmbTipoNomina.getIdNominaTipo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }
        }


         public string getIdNominaTipoLiqui()
        {
            try
            {
                return cmbNominaLiqui.getNominaTipoLiqui();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }
        }


        public ro_periodo_x_ro_Nomina_TipoLiqui_Info getPeriodoXNomina()
        {
            try
            {

                ro_periodo_x_ro_Nomina_TipoLiqui_Info info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

                _idPeriodo = Convert.ToInt32(cmbPeriodo.EditValue);

                info = (from a in oListRo_periodo_x_ro_Nomina_TipoLiqui_Info
                        where a.IdPeriodo == _idPeriodo
                        select a).FirstOrDefault();
 
                return info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
            }
        }



        public void setDataPeriodo(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui)
        {
            try
            {
                _idEmpresa = idEmpresa;
                _idNominaTipo = idNominaTipo;
                _idNominaTipoLiqui = idNominaTipoLiqui;

                pu_CargaInicial();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void setInfo(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo)
        {
            try
            {
                _idEmpresa = idEmpresa;
                _idNominaTipo = idNominaTipo;
                _idNominaTipoLiqui = idNominaTipoLiqui;
                _idPeriodo = idPeriodo;

                cmbTipoNomina.setIdNominaTipo(_idNominaTipo);
                cmbNominaLiqui.setIdNominaTipo(_idNominaTipo);
                cmbNominaLiqui.setIdNominaTipoLiqui(_idNominaTipoLiqui);

                //CARGA EL PERIODO
                pu_CargaInicial();

                cmbPeriodo.EditValue = _idPeriodo;
            
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }



        public void setIdEmpresa(int idEmpresa)
        {
            try
            {
                _idEmpresa = idEmpresa;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void setIdPeriodo(int idPeriodo)
        {
            try
            {
                if(cmbPeriodo.EditValue!=null){
                    cmbPeriodo.EditValue = idPeriodo;
                }

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
                if (cmbTipoNomina.getIdNominaTipo() != null)
                {
                    cmbTipoNomina.setIdNominaTipo(idNominaTipo);
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void setIdNominaTipoLiqui(int idNominaTipoLiqui)
        {
            try
            {
                if (cmbNominaLiqui.getNominaTipoLiqui() != null)
                {
                    cmbNominaLiqui.setIdNominaTipoLiqui(idNominaTipoLiqui);
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbNominaTipo_event_cmbNominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoNomina.getIdNominaTipo() != null)
                {
                    _idNominaTipo = Convert.ToInt32(cmbTipoNomina.getIdNominaTipo());
                    cmbNominaLiqui.setIdNominaTipo(_idNominaTipo);
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }       

        }

        private void cmbNominaTipoLiqui_event_cmbNominaTipoLiqui_EditValueChanged(object sender, EventArgs e)
        {
            try {
                    if (cmbNominaLiqui.getNominaTipoLiqui() != null)
                    {

                        _idNominaTipoLiqui = Convert.ToInt32(cmbNominaLiqui.getNominaTipoLiqui());

                         pu_CargaInicial();
                    }
               }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                }  
            
            }

        private void cmbTipoNomina_Load(object sender, EventArgs e)
        {

        }
       
    
    
    
    }
}
