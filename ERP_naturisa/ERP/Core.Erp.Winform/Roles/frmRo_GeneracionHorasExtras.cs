/*CLASE: frmRo_GeneracionHorasExtras
 *CREADO POR: ALBERTO MENA
 *FECHA: 10-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using System.Collections;
using Core.Erp.Recursos.Properties;
using Core.Erp.Reportes.Roles;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_GeneracionHorasExtras : Form
    {

        #region Declaración de Variables
            ro_marcaciones_Equipo_Bus ro_MarEquipoBus = new ro_marcaciones_Equipo_Bus();
            tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;




            ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
            ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
            ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

            List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
            List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
            List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();



            string mensaje = "";
            int _idNominaTipo=0;
            int _idNominaTipoLiqui = 0;
            int _idPeriodo= 0;

            Boolean banderaProceso=false;
            Boolean bandera_si_Periodo_procesao = false;

        //BUS
            ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();
            ro_Nomina_X_Horas_Extras_Bus oRo_Nomina_X_Horas_Extras_Bus = new ro_Nomina_X_Horas_Extras_Bus();
            ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();


        //INFO
            ro_periodo_x_ro_Nomina_TipoLiqui_Info oRo_PeriodoInfo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
            ro_marcaciones_Equipo_Info Info = new ro_marcaciones_Equipo_Info();
            BindingList<ro_Empleado_Info> oListRo_Empleado_Info = new BindingList<ro_Empleado_Info>();
            BindingList<ro_Nomina_X_Horas_Extras_Info> oBindingListRo_Nomina_X_Horas_Extras_Info = new BindingList<ro_Nomina_X_Horas_Extras_Info>();
        //DATA

            BackgroundWorker bw = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

        #endregion

        public frmRo_GeneracionHorasExtras()
        {
           
            try
            {
                InitializeComponent();

                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            pu_Imprimir();
        }


        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pu_Imprimir() { 
            try{
                _idNominaTipo = Convert.ToInt32(cmbnomina.EditValue);
                _idNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                _idPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);

                XROL_Rpt006_frm oXROL_Rpt006_frm = new XROL_Rpt006_frm();
                oXROL_Rpt006_frm.setInfo(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo);
                oXROL_Rpt006_frm.Show();

            }catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }


        private void pu_CalcularHorasExtras() {
            try
            {               
                    _idNominaTipo = Convert.ToInt32(cmbnomina.EditValue);
                    _idNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                    _idPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);

                    cmdCalcular.Enabled = false;
                    cmdDetener.Enabled = true;
                    cmdAgregarNovedad.Enabled = false;

                    pu_CargarNomina();

                    banderaProceso = true;

                    //VERIFICA QUE LA TAREA EN BACKGROUND ESTA EJECUTANDOSE ASINCRONICAMENTE
                    if (bw.IsBusy) { return; }

                    //EMPIEZA A EJECUTAR LA TAREA EN BACKGROUND
                    bw.RunWorkerAsync();               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }

        private void frmRo_GeneracionHorasExtras_Load(object sender, EventArgs e)
        {
          
            try
            {
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
                pu_CargaInicial();

            }
            catch (Exception ex)
            {
                
                 
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void viewEmpleado_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = viewEmpleado.GetRow(e.RowHandle) as ro_Nomina_X_Horas_Extras_Info;
                if (data == null)
                    return;

                int dia_semana = ((int)data.FechaRegistro.DayOfWeek == 0) ? 7 : (int)data.FechaRegistro.DayOfWeek;

                if (dia_semana == 6 | dia_semana == 7) //REPRESENTA SABADO Y DOMINGO                     
                {
                    e.Appearance.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }




        private void pu_AgregarNovedad() 
        {
            try 
            {            
                    if (MessageBox.Show("Está seguro que desea enviar al Rol del Empleado los valores generados por Horas Extras, recuerde que se creará una nueva novedad", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        _idNominaTipo = Convert.ToInt32(cmbnomina.EditValue);
                        _idNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                        _idPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);

                        cmdDetener.Enabled = true;
                        cmdAgregarNovedad.Enabled = false;
                        cmdCalcular.Enabled = false;

                        pu_CargarNomina();

                        banderaProceso = false;

                        //VERIFICA QUE LA TAREA EN BACKGROUND ESTA EJECUTANDOSE ASINCRONICAMENTE
                        if (bw.IsBusy) { return; }

                        //EMPIEZA A EJECUTAR LA TAREA EN BACKGROUND
                        bw.RunWorkerAsync();
                    }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage <= progressBar.Maximum)
            {
                progressBar.Value = e.ProgressPercentage;
                lblStatus.Text = e.ProgressPercentage.ToString() + "%";
            } 
        }

        private void pu_CargaInicial() {
            try {

                cmdCalcular.Enabled = true;
                cmdDetener.Enabled = false;
                cmdAgregarNovedad.Enabled = false;

                
                //INICIALIZA LOS EVENTOS DELEGADOS DE LA BARRA DE PROGRESO
                bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
                bw.RunWorkerCompleted += bw_RunWorkerCompleted;
                bw.DoWork += bw_DoWork;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }

        private void pu_CargarNomina() { 
            try{

                if (pu_Validar())
                {
                    _idNominaTipo = Convert.ToInt32(cmbnomina.EditValue);
                    _idNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                    _idPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);

                    //OBTENER LISTADO DE EMPLEADOS DE LA NOMINA SELECCIONADA
                    oListRo_Empleado_Info =new BindingList<ro_Empleado_Info>( oRo_Empleado_Bus.Get_List_Empleado_x_Nomina(param.IdEmpresa, _idNominaTipo));

                    //OBTENER EL PERIODO
                    oRo_PeriodoInfo = oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.ConsultaPerNomTipLiq(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui).Where(v => v.IdPeriodo == _idPeriodo).FirstOrDefault();
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        
        }



        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                int i = 0;
                int numFila = 0;
                double percent = 0;
                mensaje = "";


                //VERIFICA SI ESTA SELECCIONADO PROCESAR TODOS 
                numFila = oListRo_Empleado_Info.Count;
                i = 0;

              //RECORRER LA NOMINA
                foreach (ro_Empleado_Info item in oListRo_Empleado_Info)
                {
                    //DETIENE EL PROCESO SOLICTADO POR EL USUARIO
                    if (bw.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    //EJECUTA EL PROCESO DE GENERACION DE ROL
                    if (banderaProceso)
                    {
                        oRo_Nomina_X_Horas_Extras_Bus.pu_CalcularHorasExtras(item.IdEmpresa, item.IdEmpleado, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo, oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin, Convert.ToBoolean(item.es_AcreditaHorasExtras));
                    }
                    else
                    { 

                              if (item.es_AcreditaHorasExtras == true)
                                {


                                    // actualizar si es autorizada ora extra
                                    List<ro_Nomina_X_Horas_Extras_Info> ListaActualiza = new List<ro_Nomina_X_Horas_Extras_Info>();

                                    ListaActualiza = oBindingListRo_Nomina_X_Horas_Extras_Info.Where(v => v.IdEmpleado == item.IdEmpleado).ToList();
                                    foreach (var item_Actaliza in ListaActualiza)
                                    {
                                        if (item_Actaliza.es_HorasExtrasAutorizadas == true)
                                        {
                                        }
                                        oRo_Nomina_X_Horas_Extras_Bus.GuardarBD(item_Actaliza, ref mensaje);
                                    }




                                    oRo_Nomina_X_Horas_Extras_Bus.pu_AgregarNovedadPorEmpleado(item.IdEmpresa, item.IdEmpleado, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo, oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin, Convert.ToBoolean(item.es_AcreditaHorasExtras));
                                }
                      
                       
                    }

                    i++;
                    percent = (Convert.ToDouble(i) / Convert.ToDouble(numFila)) * 100;
                    bw.ReportProgress((int)percent);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("El proceso ha sido detenido por el usuario, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (e.Error != null) { MessageBox.Show(e.Error.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {

                oBindingListRo_Nomina_X_Horas_Extras_Info = new BindingList<ro_Nomina_X_Horas_Extras_Info>(oRo_Nomina_X_Horas_Extras_Bus.Get_List_Nomina_X_Horas_Extras(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo, ref mensaje));
                gridEmpleado.DataSource = oBindingListRo_Nomina_X_Horas_Extras_Info;
                gridEmpleado.RefreshDataSource();

                cmdCalcular.Enabled = true;
                cmdDetener.Enabled = false;
                cmdAgregarNovedad.Enabled = true;


                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
        }



        private void pu_DetenerProceso()
        {
            try
            {
                if (bw.WorkerSupportsCancellation)
                {

                    if (MessageBox.Show("Está seguro que desea detener el Proceso de Cálculo de Horas Extras...?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bw.CancelAsync();
                       
                        cmdCalcular.Enabled = true;
                        cmdDetener.Enabled = false;
                        cmdAgregarNovedad.Enabled = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }




        private Boolean pu_Validar() { 
            try{

                if (cmbnomina.EditValue==null)
                {
                    MessageBox.Show("La Nómina es obligatorio, revise por favor","ATENCION", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return false;
                }


                if (cmbnominaTipo.EditValue==null)
                {
                    MessageBox.Show("El Proceso es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }


                if (cmbPeriodos.EditValue==null)
                {
                    MessageBox.Show("El Período es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }



                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }                
        }

        private Boolean pu_ValidarPeriodo()
        {
            try
            {
                Boolean valorRetornar = false;

                oRo_PeriodoInfo =(ro_periodo_x_ro_Nomina_TipoLiqui_Info) cmbPeriodos.Properties.View.GetFocusedRow();

                if (oRo_PeriodoInfo.Cerrado == "N")
                {
                    valorRetornar = true;
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (bandera_si_Periodo_procesao)
                {
                    if (MessageBox.Show("Periodo seleccionado ya fue ejecutado!!!, [SE ACTUALIZARAN LAS NOVEDADES QUE FUERON CREADAS EN BASE A ESTE PROCESO] ¿Deseas continuar?", "Horas Extras", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        if (pu_Validar())
                        {
                            if (pu_ValidarPeriodo())
                            {
                                pu_CalcularHorasExtras();
                            }
                            else
                            {
                                MessageBox.Show("El Período está Cerrado no puede continuar con el proceso, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                }
                else
                {
                    if (pu_Validar())
                    {
                        if (pu_ValidarPeriodo())
                        {
                            pu_CalcularHorasExtras();
                        }
                        else
                        {
                            MessageBox.Show("El Período está Cerrado no puede continuar con el proceso, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmdAgregarNovedad_Click(object sender, EventArgs e)
        {
            try
            {
                cmdDetener.Focus();
                if (pu_Validar())
               {
                if (pu_ValidarPeriodo())
                {
                    pu_AgregarNovedad();
                }
                else
                {
                    MessageBox.Show("El Período está Cerrado no puede continuar con el proceso, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmdDetener_Click(object sender, EventArgs e)
        {
            try
            {            pu_DetenerProceso();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void checkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkSeleccionarTodos.Checked == true)
                {
                    if (MessageBox.Show("Esta Seguro que desea seleccionar todos los registro?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        foreach (var item in oBindingListRo_Nomina_X_Horas_Extras_Info)
                        {

                            item.es_HorasExtrasAutorizadas = true;
                        }
                    }
                    else
                    {
                        checkSeleccionarTodos.Checked = false;
                    }
                }
                else
                {
                    if (MessageBox.Show("Esta Seguro que desea deseleccionar todos los registro?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        foreach (var item in oBindingListRo_Nomina_X_Horas_Extras_Info)
                        {

                            item.es_HorasExtrasAutorizadas = false;
                        }
                    }
                    else
                    {
                      //  checkSeleccionarTodos.Checked = true;
                    }

                }

               

                gridEmpleado.RefreshDataSource();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucRo_PeriodoXNomina_event_cmbPeriodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                oBindingListRo_Nomina_X_Horas_Extras_Info = new BindingList<ro_Nomina_X_Horas_Extras_Info>(oRo_Nomina_X_Horas_Extras_Bus.Get_List_Nomina_X_Horas_Extras(param.IdEmpresa,Convert.ToInt32( cmbnomina.EditValue),Convert.ToInt32( cmbnominaTipo.EditValue),Convert.ToInt32(cmbPeriodos.EditValue), ref mensaje));
                gridEmpleado.DataSource = oBindingListRo_Nomina_X_Horas_Extras_Info;
                gridEmpleado.RefreshDataSource();

                if (oBindingListRo_Nomina_X_Horas_Extras_Info.Count() > 0)
                {
                    bandera_si_Periodo_procesao = true;
                    cmdAgregarNovedad.Enabled = true;
                }
                else
                {
                    bandera_si_Periodo_procesao = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                
                
            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {

        }
        
        private void Calcular_total_autorizados()
        {
            try
            {
                labelControl1.Focus();
                double H25 = 0;
                double H50 = 0;
                double H100 = 0;

                for (int i = 0; i < viewEmpleado.DataRowCount; i++)
                {
                    var data = viewEmpleado.GetRow(i) as ro_Nomina_X_Horas_Extras_Info;
                    if (data.es_HorasExtrasAutorizadas == true)
                    {
                        H25 += data.hora_extra25;
                        H50 += data.hora_extra50;
                        H100 += data.hora_extra100;
                    }
                }

                txtH25.Text = H25.ToString();
                txtH50.Text = H50.ToString();
                txtH100.Text = H100.ToString();


              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void viewEmpleado_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Calcular_total_autorizados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void viewEmpleado_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
               // Calcular_total_autorizados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }                            
    }
}
