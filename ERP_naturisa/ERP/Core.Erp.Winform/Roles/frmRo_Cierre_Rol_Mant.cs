
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
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;

using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Cierre_Rol_Mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info infoPeriodoAnterior = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info infoPeriodoDespues = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info infoPeriodoActual = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        int idNominaTipo = 0;
        int idNominaTipoLiqui = 0;
        int idPeriodo = 0;
        #endregion
       
        public frmRo_Cierre_Rol_Mant()
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

        void pu_CargaInicial()
        {
            try
            {
 
                cmbPeriodo.setIdEmpresa(param.IdEmpresa);
    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());                             
            }                    
        }
  
        private void frmRo_Cierre_Rol_Mant_Load(object sender, EventArgs e)
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

        public Boolean pu_Validar()
        {
            try
            {

                if (cmbPeriodo.getIdNominaTipo() == null || cmbPeriodo.getIdNominaTipo()== "")
                {
                    MessageBox.Show("Ingrese la nómina. Por favor verifique", "ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbPeriodo.getIdNominaTipoLiqui() == null || cmbPeriodo.getIdNominaTipoLiqui() == "")
                {
                    MessageBox.Show("Ingrese el tipo de nómina. Por favor verifique", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbPeriodo.getIdPeriodo() == null || cmbPeriodo.getIdPeriodo() == "")
                {
                    MessageBox.Show("Ingrese el periodo. Por favor verifique", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void getInfo() {
            try {

                idNominaTipo = Convert.ToInt32(cmbPeriodo.getIdNominaTipo());
                idNominaTipoLiqui = Convert.ToInt32(cmbPeriodo.getIdNominaTipoLiqui());
                idPeriodo = Convert.ToInt32(cmbPeriodo.getIdPeriodo());

                infoPeriodoActual = cmbPeriodo.getPeriodoXNomina();

                cmdCierreRol.Enabled = true;
                cmdReversoRol.Enabled = true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void pu_CierreRol() {
            try
            {
                if (pu_Validar())
                {

                    getInfo();

                    //VALIDA QUE EL PERIODO YA ESTA PROCESADO
                    if (infoPeriodoActual.Procesado == "S")
                    {

                        //OBTENER PERIODO ANTERIOR
                        infoPeriodoAnterior = oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.GetInfoPeriodoAnterior(param.IdEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo);

                        //VALIDAR SI EL PERIODO ANTERIOR ESTA CERRADO
                        if (infoPeriodoAnterior.Cerrado == "S" || infoPeriodoAnterior.Cerrado==null)
                        {
                            if (infoPeriodoActual.Cerrado == "N")
                            {
                                if (MessageBox.Show("Está seguro que desea cerrar el período seleccionado?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    infoPeriodoActual.Cerrado = "S";
                                    oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.ModificarDB(infoPeriodoActual);

                                    cmdCierreRol.Enabled = false;
                                    cmdReversoRol.Enabled = true;
                                    MessageBox.Show("El período seleccionado ha sido CERRADO con éxito, continue por favor", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                            else {
                                MessageBox.Show("El período seleccionado ya esta CERRADO, continue por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El período anterior: " + infoPeriodoAnterior.IdPeriodo.ToString() + " debe estar CERRADO, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else {
                        MessageBox.Show("El período seleccionado aún no ha sido PROCESADO, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                cmbPeriodo.setIdEmpresa(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }                
        
        }

        private void pu_ReversoRol()
        {
            try
            {
                if (pu_Validar())
                {
                    getInfo();

                     //OBTENER PERIODO DESPUES
                     infoPeriodoDespues = oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.GetInfoPeriodoDespues(param.IdEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo);


                     if (infoPeriodoDespues.Cerrado=="N")
                     {
                        if(infoPeriodoActual.Cerrado=="S"){

                            infoPeriodoActual.Cerrado = "N";
                            oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.ModificarDB(infoPeriodoActual);

                            cmdCierreRol.Enabled = true;
                            cmdReversoRol.Enabled = false;
                            MessageBox.Show("El período seleccionado ha sido REVERSADO con éxito, continue por favor", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      

                        }else{
                            MessageBox.Show("El período seleccionado no está CERRADO, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }else{

                        MessageBox.Show("El período siguiente "+infoPeriodoDespues.IdPeriodo.ToString()+" está CERRADO, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                cmbPeriodo.setIdEmpresa(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_Cierre_Rol_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
            }
        }

        private void cmbPeriodo_event_cmbPeriodo_EditValueChanged(object sender, EventArgs e)
        {
           
            try
            {
                getInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmdCierreRol_Click_1(object sender, EventArgs e)
        {
            try
            {
                 pu_CierreRol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmdReversoRol_Click_1(object sender, EventArgs e)
        {
            try
            {
                 pu_ReversoRol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       
    }
}
