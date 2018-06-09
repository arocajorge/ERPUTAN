/*CLASE: frmRo_RDEP_Mant
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 07-07-2015
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
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Contabilizar_Rol : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";
        

        int _idEmpresa=0;
        int _idNominaTipo=0;
        int _idNominaTipoLiqui=0;
        int _idPeriodo=0;
        DateTime _fechaContabiliza;


        //BUS
        ro_Rol_Bus ro_Rol_Bus = new ro_Rol_Bus();
        ro_Nomina_Tipo_Bus Bus_TipoNo = new ro_Nomina_Tipo_Bus();
        ro_periodo_Bus Bus_Periodo = new ro_periodo_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus Bus_PerNomTipoliq = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
        ro_Nomina_Tipoliqui_Bus Bus_TipoNominaLiqui = new ro_Nomina_Tipoliqui_Bus();
        ro_division_Bus busDivision = new ro_division_Bus();

        //INFO
        ro_periodo_x_ro_Nomina_TipoLiqui_Info Info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info InfoAnterior = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info InfoDespues = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> InfoPeriodo = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        //  List<ro_periodo_Info> InfoPeriodo = new List<ro_periodo_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> InfoPeriodoTipo = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        List<ro_division_Info> infoDivision = new List<ro_division_Info>();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info periodoActual = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();




        public frmRo_Contabilizar_Rol()
        {
            try
            {
                  InitializeComponent();

                  ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (cmbNomina.EditValue != null)
                //{
                //    int numero;
                //    numero = Convert.ToInt32(cmbNomina.EditValue);

                //    // Cargando Combo Proceso 
                //    List<ro_Nomina_Tipoliqui_Info> InfoNominaTipoliqui = new List<ro_Nomina_Tipoliqui_Info>();
                //    InfoNominaTipoliqui = Bus_TipoNominaLiqui.ObtenerLstxNomina_Tipo(param.IdEmpresa, numero);
                //    this.cmbTipoNomina.Properties.DataSource = InfoNominaTipoliqui;
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       

        void pu_CargaInicial()
        {
            try
            {
                ucRo_Periodo.setIdEmpresa(param.IdEmpresa);
                dteFechaContabilidad.EditValue = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmRo_Contabilizar_Rol_Load(object sender, EventArgs e)
        {
            try
            {
                pu_CargaInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private Boolean ValidarAnterior()
        {
            try
            {
                //IdNomina_Tipo = Convert.ToInt32(this.cmbNomina.EditValue);
                //Idnomina_TipoLiqui = Convert.ToInt32(this.cmbTipoNomina.EditValue);
                //IdPeriodo = Convert.ToInt32(this.cmbPeriodo.EditValue);
                //InfoAnterior = Bus_PerNomTipoliq.ObtenerPeriodoAnterior(param.IdEmpresa, IdPeriodo, IdNomina_Tipo, Idnomina_TipoLiqui);
               
                if (InfoAnterior.Cerrado != null)
                {
                    if (InfoAnterior.Contabilizado == "N")
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
            return true;
        }

        


        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                 Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbTipoNomina_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {
                //IdNomina_Tipo = Convert.ToInt32(this.cmbNomina.EditValue);
                //Idnomina_TipoLiqui = Convert.ToInt32(this.cmbTipoNomina.EditValue);

                //InfoPeriodo = Bus_PerNomTipoliq.ConsultaPerNomTipLiq(param.IdEmpresa, IdNomina_Tipo, Idnomina_TipoLiqui);
                //this.cmbPeriodo.Properties.DataSource = InfoPeriodo;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        

  

        public Boolean Validar()
        {
            try
            {

                
                if (this.dteFechaContabilidad.EditValue == null || this.dteFechaContabilidad.EditValue == "")
                {
                    MessageBox.Show("Ingrese la Fecha. Por favor verifique", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }


        private void cmbTipoNomina_EditValueChanged(object sender, EventArgs e){}

        private void frmRo_Contabilizar_Rol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
            }
        }

        private Boolean getInfo() {
            try {

                _idEmpresa = param.IdEmpresa;
                _idNominaTipo = Convert.ToInt32(ucRo_Periodo.getIdNominaTipo());
                _idNominaTipoLiqui = Convert.ToInt32(ucRo_Periodo.getIdNominaTipoLiqui());
                _idPeriodo= Convert.ToInt32(ucRo_Periodo.getIdPeriodo());
                _fechaContabiliza = Convert.ToDateTime(dteFechaContabilidad.EditValue);
                return true;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }


        private Boolean pu_Validar() {
            try
            {
                if (ucRo_Periodo.getIdNominaTipo().ToString()=="") {
                    MessageBox.Show("La Nómina es obligatoria, revise por favor","ATENCION", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return false;
                }

                if (ucRo_Periodo.getIdNominaTipoLiqui().ToString() == "")
                {
                    MessageBox.Show("El Proceso de Liquidación es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (ucRo_Periodo.getIdPeriodo().ToString() == "")
                {
                    MessageBox.Show("El Período es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                periodoActual = ucRo_Periodo.getPeriodoXNomina();

                if (periodoActual.Cerrado == "N")
                {
                    MessageBox.Show("El Período aun no está cerrado, para poder contabilizar debe primero cerrar el período correspondiente, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;                                
                }

                if (periodoActual.Contabilizado == "S")
                {
                    MessageBox.Show("El Período ya se encuentra contabilizado, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }


               
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }


        }








        private void pu_Contabilizar() {
            try {

                if (MessageBox.Show("Está seguro que desea Contabilizar el Rol...?","ATENCION",MessageBoxButtons.YesNo,MessageBoxIcon.Question )==DialogResult.Yes)
                {

                    if (pu_Validar())
                    {
                        if (getInfo())
                        {

                            periodoActual = ucRo_Periodo.getPeriodoXNomina();

                            if (ro_Rol_Bus.pu_ContabilizarRol(_idEmpresa, _idNominaTipo, _idNominaTipoLiqui, periodoActual, _fechaContabiliza, ref mensaje))
                            {
                                MessageBox.Show("El Rol ha sido Contabilizado con éxito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else {
                                MessageBox.Show("Ocurrio un error: " + mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);                            
                            }
                            

                        }
                    }
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }           
        }

        private void cmdContabilizar_Click(object sender, EventArgs e)
        {
           try 
	       {	        
		 pu_Contabilizar();
	       }
	      catch (Exception ex)
	      {
		
	     	 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
	      }
        }

 











    }
}
