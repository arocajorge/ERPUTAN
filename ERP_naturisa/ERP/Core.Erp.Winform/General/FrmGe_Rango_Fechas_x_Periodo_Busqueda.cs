using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using System.Globalization;



namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Rango_Fechas_x_Periodo_Busqueda : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        

        public FrmGe_Rango_Fechas_x_Periodo_Busqueda()
        {
            InitializeComponent();
        }

        public DateTime Fecha_desde { get; set; }
        public DateTime Fecha_hast { get; set; }

        private void FrmGe_Rango_Fechas_x_Periodo_Busqueda_Load(object sender, EventArgs e)
        {
            try
            {
                Fecha_desde = DateTime.Now;
                Fecha_hast = DateTime.Now;
                this.dtpDesde.Value = Fecha_desde;
                this.dtpHasta.Value = Fecha_hast;

                cargar_combo();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            


        }


        tb_rango_fecha_busqueda_x_periodo_Bus OBus = new tb_rango_fecha_busqueda_x_periodo_Bus();
        List<tb_rango_fecha_busqueda_x_periodo_Info> list_Ran_fec = new List<tb_rango_fecha_busqueda_x_periodo_Info>();



        private void cargar_combo()
        {
            try
            {
              list_Ran_fec=  OBus.Obtener_Listado_Rango_fechas();

              cmbTipoBusqueda.Properties.DataSource = list_Ran_fec;



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        private void Calculando_Rango_Fecha()
        {

            try
            {

               // tb_rango_fecha_busqueda_x_periodo_Info item = ((List<tb_rango_fecha_busqueda_x_periodo_Info>)(cmbTipoBusqueda.Properties.DataSource)).FirstOrDefault(v => v.Id == Convert.ToInt32(cmbTipoBusqueda.EditValue));

                tb_rango_fecha_busqueda_x_periodo_Info item2 = (tb_rango_fecha_busqueda_x_periodo_Info)cmbTipoBusqueda.Properties.View.GetFocusedRow();

                Fecha_desde = DateTime.Now;
                Fecha_hast = DateTime.Now;


                DateTime FechaInicial = DateTime.Now;

                Boolean checked_fdesde = true;
                Boolean checked_fhast = true;



                switch (item2.Id)
                {
                       
                    
                    case 2:
                       
                            DateTime firstDate = GetFirstDateOfWeek(Fecha_hast, DayOfWeek.Monday);
                            DateTime lastDate = GetLastDateOfWeek(Fecha_hast, DayOfWeek.Sunday);

                            Fecha_desde = firstDate;
                            Fecha_hast = lastDate;
                        break;
                    case 3:

                            
                            Fecha_desde = new DateTime(Fecha_desde.Year,Fecha_desde.Month,1);
                            Fecha_hast = Fecha_desde.AddMonths(1).AddDays(-1);
                            


                        
                        break;
                    case 4:
                        MessageBox.Show("Seleccione Rango de Fechas por favor..","" );
                        Fecha_desde = DateTime.Now;
                        Fecha_hast = DateTime.Now;
                        checked_fdesde = false;
                        checked_fhast = false;

                        break;
                 
                    default:

                        FechaInicial = Fecha_desde;

                            switch (item2.uni_medida)
                            {
                                case "DIA":


                                    Fecha_desde = FechaInicial.AddDays(item2.valor_ini);
                                    Fecha_hast = FechaInicial.AddDays(item2.valor_fin);
                                    break;
                                case "MES":
                                    Fecha_desde = FechaInicial.AddMonths(item2.valor_ini);
                                    Fecha_hast = FechaInicial.AddMonths(item2.valor_fin);
                                    break;
                                case "ANIO":
                                    Fecha_desde = FechaInicial.AddYears(item2.valor_ini);
                                    Fecha_hast = FechaInicial.AddYears(item2.valor_fin);
                                    break;

                            }
                        break;
                }


                dtpDesde.Value = Fecha_desde;
                dtpHasta.Value = Fecha_hast;
                dtpDesde.Checked = checked_fdesde;
                dtpHasta.Checked = checked_fhast;
               



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        
        }


       

        public static DateTime GetFirstDateOfWeek(DateTime dayInWeek, DayOfWeek firstDay)
        {           
                DateTime firstDayInWeek = dayInWeek.Date;
                while (firstDayInWeek.DayOfWeek != firstDay)
                    firstDayInWeek = firstDayInWeek.AddDays(-1);

                return firstDayInWeek;
           
        }
        public static DateTime GetLastDateOfWeek(DateTime dayInWeek, DayOfWeek firstDay)
        {
                DateTime lastDayInWeek = dayInWeek.Date;
                while (lastDayInWeek.DayOfWeek != firstDay)
                    lastDayInWeek = lastDayInWeek.AddDays(1);

                return lastDayInWeek;
            
        }


        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                Fecha_desde = dtpDesde.Value;
               // Fecha_hast = dtpHasta.Value;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {

             //   Fecha_desde = dtpDesde.Value;
                Fecha_hast = dtpHasta.Value;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {

                Fecha_desde = dtpDesde.Value;
                Fecha_hast = dtpHasta.Value;
                this.Close();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void cmbTipoBusqueda_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                Calculando_Rango_Fecha();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

    }
}
