

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
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Controles;
using Core.Erp.Recursos.Properties;
using Core.Erp.Reportes.Roles;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_calculo_vacacionesActafiniquito : Form
    {

        DateTime ro_corte_actual =DateTime.Now ;
        DateTime ro_periodo = DateTime.Now;
        DateTime Fecha_Anio_Inicio ;
        DateTime Fecha_Anio_Fin;

        #region Declaración de variables
        //
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }




        UCRo_Historico_Vacaciones ctrl = new UCRo_Historico_Vacaciones();
 
        public delegate void delegate_frmRo_Solicitud_Vacaciones_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Solicitud_Vacaciones_Mant_FormClosing event_frmRo_Solicitud_Vacaciones_Mant_FormClosing;
        

       
        BindingList<ro_historico_vacaciones_x_empleado_Info> RoHistoricoVacaInfoLst = new BindingList<ro_historico_vacaciones_x_empleado_Info>();
        ro_historico_vacaciones_x_empleado_Info infoHistoricoVac = new ro_historico_vacaciones_x_empleado_Info();
        
        ro_SolicitudVacaciones_Info info = new ro_SolicitudVacaciones_Info();

        //BUS
        ro_historico_vacaciones_x_empleado_Bus oRo_historico_vacaciones_x_empleado_Bus = new ro_historico_vacaciones_x_empleado_Bus();
        ro_historico_vacaciones_x_empleado_Bus RoHistoricoVacaBus = new ro_historico_vacaciones_x_empleado_Bus();
        ro_SolicitudVacaciones_Bus oRo_SolicitudVacaciones_Bus = new ro_SolicitudVacaciones_Bus();


       XROL_Rpt013_Info InfoReporte = new XROL_Rpt013_Info();
       List< XROL_Rpt013_Info> List_Reporte = new List<XROL_Rpt013_Info>();
       XROL_Rpt013_Bus BusReporte = new XROL_Rpt013_Bus();

     
        #endregion

       public frmRo_calculo_vacacionesActafiniquito()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmRo_Solicitud_Vacaciones_Mant_FormClosing += frmRo_Solicitud_Vacaciones_Mant_event_frmRo_Solicitud_Vacaciones_Mant_FormClosing;
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
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
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

    
         
        private void frmRo_Solicitud_Vacaciones_Mant_event_frmRo_Solicitud_Vacaciones_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              //throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }     

        public Boolean Get()
        {
            try
            {

                info = new ro_SolicitudVacaciones_Info();

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

     


     
    
       



        private Boolean pu_GrabarHistorico()
        {
            try {

                int id=0;

                foreach (ro_historico_vacaciones_x_empleado_Info item in RoHistoricoVacaInfoLst)
                {
                    if (!oRo_historico_vacaciones_x_empleado_Bus.GrabarBD(item, ref id, ref mensaje)) {return false; }
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


       


        private Boolean pu_Validar()
        {
            try
            {


                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }


        }

     

        private void frmRo_Solicitud_Vacaciones_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_Solicitud_Vacaciones_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        
        public void pu_MostrarDetalle(ro_Empleado_Info oRo_Empleado_Info)
        {
            try
            {
                
                        oRo_historico_vacaciones_x_empleado_Bus.GenerarVacacionesPorEmpleado(oRo_Empleado_Info, ref mensaje);
                        RoHistoricoVacaInfoLst = new BindingList<ro_historico_vacaciones_x_empleado_Info>(oRo_historico_vacaciones_x_empleado_Bus.ConsultarHistoricoVaca(oRo_Empleado_Info.IdEmpleado, oRo_Empleado_Info.IdEmpresa));
                        gridVacaciones.DataSource = RoHistoricoVacaInfoLst;

                    

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }        
          
        
        private void frmRo_Solicitud_Vacaciones_Mant_Load(object sender, EventArgs e)
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

        
     

        private void txtDiasCorresponde_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmRo_Solicitud_Vacaciones_Mant_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dtpFechaInicio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                    
                    ObtenerFecha();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            } 
        }

        private void dtpFechaFinal_EditValueChanged(object sender, EventArgs e)
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

        private void cmbEstado_EditValueChanged(object sender, EventArgs e)
        {
           
        }


     

        

      

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Limpiar()
        {
            try
            {
            }
            catch (Exception ex)
            {
                
                  MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_empleado_autoriza_EditValueChanged(object sender, EventArgs e)
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



        public void ObtenerFecha()
        {
            try
            {

                foreach (var item in RoHistoricoVacaInfoLst.Where(v=>v.check==true).ToList())
                {
                    Fecha_Anio_Inicio=item.FechaInicio;
                    Fecha_Anio_Fin=item.FechaFin;
                }
                 
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbt_pagadas_CheckedChanged(object sender, EventArgs e)
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

        private void txtDiaDisfrutar_EditValueChanged(object sender, EventArgs e)
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

        private void viewVacaciones_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double iess = 0;

                if (e.Column.Name == "Col_Remuneracion" || e.Column.Name == "colDiasTomados" || e.Column.Name == "colDiasGanados")
                {
                    int Dias_Pendientes=0;
                    int Dias_Ganados = 0;
                    int dias_tomados = 0;
                    double TotalRemuneracion = 0;
                    double vacaciones = 0;
                    Dias_Ganados = (Convert.ToInt32(viewVacaciones.GetFocusedRowCellValue(colDiasGanados)));
                    dias_tomados = (Convert.ToInt32(viewVacaciones.GetFocusedRowCellValue(colDiasTomados)));
                    Dias_Pendientes = Dias_Ganados - dias_tomados;
                    viewVacaciones.SetFocusedRowCellValue(colDiasPendientes, (Dias_Pendientes));

                    TotalRemuneracion = (Convert.ToDouble(viewVacaciones.GetFocusedRowCellValue(Col_Remuneracion)));
                    vacaciones = (( TotalRemuneracion / 24)/15) * Dias_Pendientes;
                   


                  
                    
                    viewVacaciones.SetFocusedRowCellValue(Col_vacaciones, (vacaciones));





                  
                   
                     
                }
            }
            catch (Exception ex)
            {


            }
        }
    }
}
