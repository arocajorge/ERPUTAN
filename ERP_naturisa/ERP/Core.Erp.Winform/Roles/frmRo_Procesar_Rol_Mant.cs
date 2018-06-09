
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using System.Threading;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;

using Core.Erp.Reportes.Roles;
using Core.Erp.Recursos.Properties;
using System.Threading.Tasks;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Procesar_Rol_Mant : Form
    {
        
        #region  Declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        

        ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();
        ro_periodo_Bus Bus_Periodo = new ro_periodo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        ro_Nomina_Tipoliqui_Bus Bus_TipoL = new ro_Nomina_Tipoliqui_Bus();
        List<ro_Nomina_Tipoliqui_Info> InfoTipoLiqui = new List<ro_Nomina_Tipoliqui_Info>();
        List<ro_Empleado_Info> oLstRo_Empleado_Info = new List<ro_Empleado_Info>();


        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo_para_saldo_neg = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

        BindingList<ro_Empleado_Novedad_Info> listaNovedadSaldoNeg = new BindingList<ro_Empleado_Novedad_Info>();

        //01/11/2013
        BindingList<ro_Empleado_Info> oBindingLstEmpleado = new BindingList<ro_Empleado_Info>();
        
        //VARIABLES
        int _idNomina = 0;
        int _idNominaLiqui = 0;
        int _idPeriodo =0 ;
        int _idEmpresa=0;
        string mensaje = "";

        //INFO
        ro_Rol_Info oRo_Rol_Info = new ro_Rol_Info();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info oRo_PeriodoInfo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

        List<ro_nomina_tipo_liqui_orden_Info> oListRo_nomina_tipo_liqui_orden_Info = new List<ro_nomina_tipo_liqui_orden_Info>();
        List<ro_Catalogo_Info> oListRo_Catalogo_Info = new List<ro_Catalogo_Info>();

        List<ro_rubro_tipo_Info> oListRo_rubro_tipo_Info = new List<ro_rubro_tipo_Info>();
        List<ro_periodo_Info> oLst_InfoPeriodo = new List<ro_periodo_Info>();
        List<ro_Rol_Detalle_Info> oListRo_Rol_Detalle_Info = new List<ro_Rol_Detalle_Info>();
        List<ro_empleado_x_ro_rubro_Info> oListRo_empleado_x_ro_rubro_Info = new List<ro_empleado_x_ro_rubro_Info>();
        List<ro_prestamo_detalle_Info> oListRo_prestamo_detalle_Info = new List<ro_prestamo_detalle_Info>();


        //BUS
        ro_nomina_tipo_liqui_orden_Bus oRo_nomina_tipo_liqui_orden_Bus = new ro_nomina_tipo_liqui_orden_Bus();
        ro_Catalogo_Bus oCatalogoBus = new ro_Catalogo_Bus();
        ro_rubro_tipo_Bus oRo_rubro_tipo_Bus = new ro_rubro_tipo_Bus();
        ro_HistoricoSueldo_Bus oHistoricoSueldoBus = new ro_HistoricoSueldo_Bus();
        ro_Empleado_Novedad_Bus Bus_Novedad = new ro_Empleado_Novedad_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        ro_Rol_Bus oRo_Rol_Bus = new ro_Rol_Bus();
        
        ro_Rol_Detalle_Bus oRo_Rol_Detalle_Bus = new ro_Rol_Detalle_Bus();
        ro_empleado_x_ro_rubro_Bus oRo_empleado_x_ro_rubro_Bus = new ro_empleado_x_ro_rubro_Bus();
        ro_prestamo_detalle_Bus oRo_prestamo_detalle_Bus = new ro_prestamo_detalle_Bus();
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();
        ro_Procesar_Rol_Bus oRo_Procesar_Rol_Bus = new ro_Procesar_Rol_Bus();
        ro_ConfRubrosAcumulados_Bus oRo_ConfRubrosAcumulados_Bus = new ro_ConfRubrosAcumulados_Bus();
  

        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        }; 

       
       
        
        int contador;
        int i;//bandera para controlar check
        int j;//bandera para validar si se esta selccionando un check

        public delegate void delegate_frmRo_Procesar_Rol_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Procesar_Rol_Mant_FormClosing Event_frmRo_Procesar_Rol_Mant_FormClosing;



        #endregion  
        //05/11/2013 D
        public frmRo_Procesar_Rol_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                Event_frmRo_Procesar_Rol_Mant_FormClosing += frmRo_Procesar_Rol_Mant_Event_frmRo_Procesar_Rol_Mant_FormClosing;

                pu_CargarInicial();
       
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void pu_Imprimir() {
            try {

                XROL_Rpt002_frm oXROL_Rpt002_frm = new XROL_Rpt002_frm();
                oXROL_Rpt002_frm.setInfo(_idEmpresa,_idNomina,_idNominaLiqui,_idPeriodo);
                oXROL_Rpt002_frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
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

        void frmRo_Procesar_Rol_Mant_Event_frmRo_Procesar_Rol_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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

        public Boolean pu_Validar() { 
             try
            {
                if (cmbnomina.EditValue == null) { MessageBox.Show("Debe seleccionar la Nómina a procesar, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop); return false; }
                if (cmbnominaTipo.EditValue== null) { MessageBox.Show("Debe seleccionar el Proceso a ejecutar, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop); return false; }
                if (cmbPeriodos.EditValue==null) { MessageBox.Show("Debe seleccionar el Período a liquidar, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop); return false; }
                 
                 return true;             
             }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            } 
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               // pu_ProcesarSeleccionados(); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void pu_CargarInicial()
        {
            try
            {
            
                    _idEmpresa = param.IdEmpresa;
                    lblStatus.Text = "0.00%";
                    progressBar.Value = 0;

                    cmdCargar.Enabled = true;
                    cmdProcesar.Enabled = false;
                    cmdDetener.Enabled = false;



                    //INICIALIZA LOS EVENTOS DELEGADOS DE LA BARRA DE PROGRESO
                    bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
                    bw.RunWorkerCompleted += bw_RunWorkerCompleted;
                    bw.DoWork += bw_DoWork;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }          
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {

                int i = 0;
                int numFila = 0;
                double percent = 0;
                mensaje = "";

                //VALIDACIONES
                if (pu_Validar())
                {

                    //VALIDA SI PUEDO CARGAR CABECERA
                    if (pu_GetInfoCabecera())
                    {
                        //INSTANCIAR EL OBJETO ROL
                        oRo_Rol_Bus = new ro_Rol_Bus(oRo_Rol_Info, oRo_PeriodoInfo);

                        //GUARDA LA CABECERA EN LA B/D
                        if (oRo_Rol_Bus.GuardarBD(ref mensaje))
                        {
                           
                            //VERIFICA SI ESTA SELECCIONADO PROCESAR TODOS 
                            numFila = oBindingLstEmpleado.Count;
                            i = 0;

                            if (checkTodos.Checked == true)
                            {
                                foreach (ro_Empleado_Info item in oBindingLstEmpleado)
                                {
                                    //DETIENE EL PROCESO SOLICTADO POR EL USUARIO
                                    if (bw.CancellationPending)
                                    {
                                        e.Cancel = true;
                                        return;
                                    }

                                    //EJECUTA EL PROCESO DE GENERACION DE ROL
                                    oRo_Rol_Bus.pu_ProcesarRol(item);

                                    i++;
                                    percent = (Convert.ToDouble(i) / Convert.ToDouble(numFila)) * 100;
                                    bw.ReportProgress((int)percent);

                                }

                            }
                            else
                            {
                                foreach (ro_Empleado_Info item in oBindingLstEmpleado)
                                {
                                    //DETIENE EL PROCESO SOLICTADO POR EL USUARIO
                                    if (bw.CancellationPending)
                                    {
                                        e.Cancel = true;
                                        return;
                                    }

                                    //SE PROCESAN UNICAMENTE LOS REGISTROS SELECCIONADOS
                                    if (item.check == true)
                                    {
                                        //EJECUTA EL PROCESO DE GENERACION DE ROL
                                        oRo_Rol_Bus.pu_ProcesarRol(item);
                                    }

                                    i++;
                                    percent = (Convert.ToDouble(i) / Convert.ToDouble(numFila)) * 100;
                                    bw.ReportProgress((int)percent);

                                }
                            }


                        }
                        else
                        {
                            MessageBox.Show(mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    MessageBox.Show("El proceso ha sido detenido por el usuario, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (e.Error != null) { MessageBox.Show(e.Error.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {

                    cmdCargar.Enabled = true;
                    cmdProcesar.Enabled = true;
                    cmdDetener.Enabled = false;

                    //MUESTRA TODOS LOS REPORTES DE ERRORES 
                    pu_AgregarMensajeLog(oRo_Rol_Detalle_Bus.GetListConsultaPorRol(_idEmpresa, _idNomina, _idNominaLiqui, _idPeriodo, ref mensaje));

                    //CAMBIA EL ESTADO DEL ROL A PROCESADO
                    oRo_PeriodoInfo.Procesado="S";
                    oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.GuardarDB(oRo_PeriodoInfo);

                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewEmpleado_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e){}

        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {            
            try
            {
                if (checkTodos.Checked == true)
                {
                   foreach (var item in oBindingLstEmpleado)
                   {                    
                       item.check = true;
                       contador++;
                       j = 1;

                       if (item.em_fecha_inicio_contrato_Actual > oRo_PeriodoInfo.pe_FechaFin)
                       {
                           item.check = false;
                       }
                   }
                }
                else
                {
                    if (i == 0)
                    {
                        foreach (var item in oBindingLstEmpleado)
                        {
                            item.check = false;
                            contador = 0;                            
                        }
                    }
                    i = 0;
                    j = 0;
                }
                    gridControlEmpleado.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        public void pu_CargarDatosNomina() { 
            try{
                _idEmpresa = param.IdEmpresa;
                _idNomina =Convert.ToInt32( cmbnomina.EditValue);
                _idNominaLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                _idPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return;
            }
        }
     
        public Boolean pu_GetInfoCabecera()
        {
            try
            {
                pu_CargarDatosNomina();

                //_idPeriodo = Convert.ToInt32(cmbPeriodo.getIdPeriodo() == null ? 0 : Convert.ToInt32(cmbPeriodo.getIdPeriodo()));

                if (cmbPeriodos.EditValue!= null)
                     {
                         _idPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                         oRo_PeriodoInfo= (ro_periodo_x_ro_Nomina_TipoLiqui_Info)  cmbPeriodos.Properties.View.GetFocusedRow();
                     }

                //OBTIENE LOS DATOS DE LA CABECERA;
                oRo_Rol_Info = new ro_Rol_Info();

                oRo_Rol_Info.IdEmpresa = _idEmpresa;
                oRo_Rol_Info.IdNominaTipo = _idNomina;
                oRo_Rol_Info.IdNominaTipoLiqui = _idNominaLiqui;
                oRo_Rol_Info.IdPeriodo = _idPeriodo;
                oRo_Rol_Info.Observacion= txtObservacion.Text.Trim();
                oRo_Rol_Info.Descripcion = txtDescripcion.Text.Trim();
                

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void pu_AgregarMensajeLog(List<ro_Rol_Detalle_Info> oListRo_Rol_Detalle_Info)
    {
        try
        {
            decimal idNovedad = 0;
            listaNovedadSaldoNeg = new BindingList<ro_Empleado_Novedad_Info>();
            oListRo_Rol_Detalle_Info= oListRo_Rol_Detalle_Info.Where(a => a.Observacion.Length > 0).ToList();
            listaNovedadSaldoNeg = new BindingList<ro_Empleado_Novedad_Info>();

            foreach (ro_Rol_Detalle_Info info in oListRo_Rol_Detalle_Info)
                {
                    if (info.Observacion.Length > 0)
                    {
                        ro_Empleado_Novedad_Info info_novedad=new ro_Empleado_Novedad_Info();
                      
                       

                        info_novedad.IdEmpresa = param.IdEmpresa;
                        info_novedad.IdEmpleado = info.IdEmpleado;
                        info_novedad.TotalValor = info.Valor;
                        listaNovedadSaldoNeg.Add(info_novedad);


                    }
                 }


            gridControl_Saldo_Neg.DataSource = listaNovedadSaldoNeg; 
           
                   
        }
        catch (Exception ex)
        {
            Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString());
        }
        
    }

        private void gridViewEmpleado_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e){}

        private void gridViewEmpleado_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == colcheck && Convert.ToBoolean(e.Value) == false)
                    {
                        i = 1;
                        checkTodos.Checked = false;                
                    }

                    if (e.Column == colcheck && Convert.ToBoolean(e.Value) == true)
                    {
                        if (j < 0) { j = 0; }
                        j++;
                    }
                    else
                    {
                        j--;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }         
        }

        private void cmbTipoLiq_EditValueChanged(object sender, EventArgs e){
            try {
                pu_CargarDatosNomina();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            } 
        }
   
        private void frmRo_Procesar_Rol_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmRo_Procesar_Rol_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_Procesar_Rol_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmRo_Procesar_Rol_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
                pu_Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        #region Funciones Estáticas de Rol
        
        #endregion

        private void pu_CargarNominaEmpleados() {
            try 
            {
                pu_GetInfoCabecera();

              if (pu_Validar())
                {
                    //PERMITE CARGAR UNICAMENTE LOS EMPLEADOS ACTIVOS Y QUE NO ESTE LIQUIDADO
                    oLstRo_Empleado_Info = oRo_Empleado_Bus.Get_List_Empleado_x_Nomina_Liquidar(_idEmpresa, _idNomina, oRo_PeriodoInfo);
                    oBindingLstEmpleado.Clear();
                    oBindingLstEmpleado = new BindingList<ro_Empleado_Info>(oLstRo_Empleado_Info);
                    gridControlEmpleado.DataSource = oBindingLstEmpleado;

                  // empleados

                    cmb_empleado.DataSource = oBindingLstEmpleado;
                    cmb_empleado.ValueMember = "IdEmpleado";
                    cmb_empleado.DisplayMember = "InfoPersona.pe_nombreCompleto";
                }                


                }catch (Exception ex){
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString());
                }
        }

        private Boolean pu_ValidarPeriodo() { 
            try{
                Boolean valorRetornar = false;

                oRo_PeriodoInfo =(ro_periodo_x_ro_Nomina_TipoLiqui_Info)  cmbPeriodos.Properties.View.GetFocusedRow();

                if (oRo_PeriodoInfo.Cerrado == "N")
                { 
                    valorRetornar = true; 
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private Boolean pu_GuardarCabecera() {
            try {
                Boolean valorRetornar=false;

                //GUARDAR EN LA B/D
                valorRetornar = oRo_Rol_Bus.GuardarBD(oRo_Rol_Info, ref mensaje);

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        
        
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
      {
          try
          {
              if (e.ProgressPercentage <= progressBar.Maximum)
              {
                  progressBar.Value = e.ProgressPercentage;
                  lblStatus.Text = e.ProgressPercentage.ToString() + "%";     
              }
          }
          catch (Exception ex)
          {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
          }
          

      
      }

        private void pu_ProcesarSeleccionados()
       {
           try
           {

               //INICIALIZA LOS VALORES
               progressBar.Maximum = 100;
               progressBar.Value = 0;

               cmdCargar.Enabled = false;
               cmdProcesar.Enabled = false;
               cmdDetener.Enabled = true;

               //VERIFICA QUE LA TAREA EN BACKGROUND ESTA EJECUTANDOSE ASINCRONICAMENTE
               if (bw.IsBusy) { return; }
               
               //EMPIEZA A EJECUTAR LA TAREA EN BACKGROUND
               bw.RunWorkerAsync();
           }
           catch (Exception ex)
           {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
           }

      }

        private void pu_Limpiar() {
          try {


              cmdProcesar.Enabled = false;
              txtDescripcion.Enabled = false;
              txtObservacion.Enabled = false;
              cmdDetener.Enabled = false;

              oBindingLstEmpleado.Clear();

              txtDescripcion.Text = "";
              txtObservacion.Text = "";

              checkTodos.Checked = false;

              progressBar.Value = 0;

          }
          catch (Exception ex)
          {
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString());
              return;
          }
      }

      private void pu_Cargar()
      {
          try
          {
              if (pu_Validar())
              {
                  if (cmbPeriodos.EditValue != null && cmbnominaTipo.EditValue != null && cmbnomina.EditValue != null)
                  {
                      pu_Limpiar();

                      //OBTIENE LA NOMINA DE LOS EMPLEDOS DE LA NOMINA SELECCIONADA
                      pu_CargarNominaEmpleados();
                      cmdProcesar.Enabled = true;

                      //OBTIENE EL ROL 
                      oRo_Rol_Info = oRo_Rol_Bus.GetInfoConsultaPorRol(_idEmpresa, _idNomina, _idNominaLiqui, _idPeriodo, ref mensaje);
                          if (oRo_Rol_Info!=null)
                          {
                              txtDescripcion.Text = (oRo_Rol_Info.Descripcion == null) ? "" : oRo_Rol_Info.Descripcion.Trim();
                              txtObservacion.Text = (oRo_Rol_Info.Observacion == null) ? "" : oRo_Rol_Info.Observacion.Trim();

                              txtDescripcion.Enabled = true;
                              txtObservacion.Enabled = true;
                          }
                      
                  }
              }
          }
          catch (Exception ex)
          {
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString());
              return;
          }

      }

       

        private void cmdCargar_Click_1(object sender, EventArgs e)
      {
          try
          {
              pu_Cargar();
          }
          catch (Exception ex)
          {
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString());
          }
      }

        private void cmdProcesar_Click_1(object sender, EventArgs e)
       {
          try
          {
              bool B_validaEstado = false;
              if (pu_ValidarPeriodo())
              {
                  foreach (var item in oLstRo_Empleado_Info)
                  {
                      if (item.em_status == "EST_VAC" || item.em_status == "EST_SUB")
                      {

                          B_validaEstado = true;
                      }
                      
                  }

                  if (B_validaEstado)
                  {
                      if (MessageBox.Show("Existen empleados en estado de vacaciones o en subsidio ¿Desea Revisar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                      {
                      }
                      else
                      {
                          pu_ProcesarSeleccionados();
                      }
                  }
                  else
                  {
                      pu_ProcesarSeleccionados();

                  }


                
              }
              else
              {
                  MessageBox.Show("El Período está Cerrado no puede continuar con el proceso, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
              }
              B_validaEstado = false;
          }
          catch (Exception ex)
          {
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString());
          }
      }

       private void cmdDetener_Click_1(object sender, EventArgs e)
      {
          try
          {
              if (bw.WorkerSupportsCancellation)
              {

                  if (MessageBox.Show("Está seguro que desea detener el Proceso de Generación del Rol...?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                  {
                      bw.CancelAsync();

                      cmdCargar.Enabled = true;
                      cmdProcesar.Enabled = true;
                      cmdDetener.Enabled = false;
                  }
              }
          }
          catch (Exception ex)
          {
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString());
          }
      }

       private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
       {
           try
           {
               listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
               cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v=>v.Cerrado=="N"&&v.Contabilizado=="N").ToList();
           }
           catch (System.Exception ex)
           {

               MessageBox.Show(ex.ToString());
           }
       }

       private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
       {
           try
           {
               if (cmbPeriodos.EditValue != null && cmbnomina.EditValue!= null && cmbnominaTipo.EditValue != null)
               {
                   _idPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                   pu_Cargar();
               }
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString());
           }
       }

       private void cmbnomina_EditValueChanged(object sender, EventArgs e)
       {
           try
           {
               ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
               cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;
               cmb_proc.DataSource = ListadoTipoLiquidacion;

           }
           catch (System.Exception ex)
           {

               MessageBox.Show(ex.ToString());
           }
       }

     



       private bool GuardarNovedad()
       {
           try
           {
               decimal idnnoveda = 0;

               bool bandera = false;
                Bus_Novedad.EliminarNovedadSaldoNegativos(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue),"S"+cmbPeriodos.EditValue.ToString());


                foreach (var item in listaNovedadSaldoNeg)
                {
                    ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();


                    DateTime Fecha_descuento;
                    string IdCalendario = "";
                    info_periodo = listadoPeriodo_para_saldo_neg.Where(v => v.IdPeriodo == item.IdPeriodo).FirstOrDefault();
                    IdCalendario = info_periodo.IdPeriodo.ToString();
                    Fecha_descuento = info_periodo.pe_FechaIni.AddDays(1);
                    item.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                    item.IdUsuario = param.IdUsuario;
                    item.Fecha_Transac = DateTime.Now;
                    item.Fecha = Fecha_descuento;
                    item.IdCalendario = "S" + cmbPeriodos.EditValue.ToString();
                    item.Fecha_PrimerPago = Fecha_descuento;
                    item.IdRubro = "1007";
                    if (item.IdNomina_TipoLiqui == null || item.IdNomina_TipoLiqui == 0)
                    {
                        MessageBox.Show("Faltan datos en los registros", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                    if (item.IdPeriodo == null || item.IdPeriodo == 0)
                    {
                         MessageBox.Show("Faltan datos en los registros", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                  bandera=  Bus_Novedad.GrabarDB_SaldosNegativos(item, ref idnnoveda);





                }

                return bandera;
              
           }
           catch (Exception ex)
           {
               
                MessageBox.Show(ex.ToString());
                return false;
           }
       }

       private void ucGe_Menu_event_btnGuardar_Click_1(object sender, EventArgs e)
       {
           try
           {
               if (GuardarNovedad())
               {
                   MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
                   MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           catch (Exception ex)
           {
               
               MessageBox.Show(ex.ToString());
           }
       }

       private void cmb_procesos_EditValueChanged(object sender, EventArgs e)
       {

           try
           {
               listadoPeriodo_para_saldo_neg = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
               cmb_period.DataSource = listadoPeriodo_para_saldo_neg.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
               cmb_period.ValueMember = "IdPeriodo";
               cmb_period.DisplayMember = "pe_Descripcion";
           }
           catch (System.Exception ex)
           {

               MessageBox.Show(ex.ToString());
           }
       }

       private void cmb_proc_EditValueChanged(object sender, EventArgs e)
       {
           try
           {/*
               listadoPeriodo_para_saldo_neg = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
               cmb_period.DataSource = listadoPeriodo_para_saldo_neg.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
               cmb_period.ValueMember = "IdPeriodo";
               cmb_period.DisplayMember = "pe_Descripcion";
             * */
           }
           catch (System.Exception ex)
           {

               MessageBox.Show(ex.ToString());
           }

       }

       private void gridView_Saldo_Neg_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
       {


           try
           {
               if (e.Column.Name == "Col_IdNomina_TipoLiqui")
               {
                   ro_Empleado_Novedad_Info info = (ro_Empleado_Novedad_Info)gridView_Saldo_Neg.GetFocusedRow();

                   listadoPeriodo_para_saldo_neg = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(info.IdNomina_TipoLiqui));
                   cmb_period.DataSource = listadoPeriodo_para_saldo_neg.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
                   cmb_period.ValueMember = "IdPeriodo";
                   cmb_period.DisplayMember = "pe_Descripcion";

               }
           }
           catch (System.Exception ex)
           {

               MessageBox.Show(ex.ToString());
           }
          

       }
    }
}