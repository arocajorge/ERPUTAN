/*CLASE: frmRo_Generar_Periodo
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 20-03-2015
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

// haac
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using System.Globalization;
using Core.Erp.Business.Roles;

using System.Threading;


using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Generar_Periodo : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Catalogo_Bus BusPrestamo_Pago = new ro_Catalogo_Bus();
        ct_AnioFiscal_Bus Bus_AnioFiscal = new ct_AnioFiscal_Bus();
        BindingList<ro_periodo_Info> DataSource = new BindingList<ro_periodo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_periodo_Bus Bus_Periodos = new ro_periodo_Bus();
        #endregion

        public frmRo_Generar_Periodo()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {

            try
            {
                this.ucGe_Menu_event_btnGuardar_Click(sender, e);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void LoadDatos()
        {
            try
            {
                // Cargando combo Periodo de pago
                var lstPago = BusPrestamo_Pago.Get_List_CatalogoTipoPago();
                this.cmbPeriodo.Properties.DataSource = lstPago;

                // Cargando combo año fiscal



                ro_Catalogo_Bus oRo_Catalogo_Bus = new Business.Roles.ro_Catalogo_Bus();
                List<ro_Catalogo_Info> ListAnioFiscal = new List<ro_Catalogo_Info>();
                ListAnioFiscal = oRo_Catalogo_Bus.Get_List_Catalogo_x_AnioFiscal(param.IdEmpresa);
                cmbAnio.EditValue = "IdCatalogo";
                cmbAnio.Properties.DataSource = ListAnioFiscal;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmRo_Generar_Periodo_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void generarMensual()
        {

            try
            {

                int periodo = 12;

                List<ro_periodo_Info> listaDetalle = new List<ro_periodo_Info>();

                for (int i = 1; i <= periodo; i++)
                {

                    ro_periodo_Info item = new ro_periodo_Info();

                    int dayMes = 0;
                    int aniox = Convert.ToInt32(this.cmbAnio.Text);

                    DateTime k = new DateTime(aniox, i, 1);
                    int mes = k.Month;
                    int anio = k.Year;

                    dayMes = System.DateTime.DaysInMonth(anio, mes);

                    DateTime p = new DateTime(anio, i, 1);
                    DateTime q = new DateTime(anio, i, dayMes);

                    //string Id = Convert.ToString(aniox) + mes;
                    //int IdPeriodo = Convert.ToInt32(Id);


                    string Id = "";
                    int IdPeriodo = 0;
                    if (i >= 1 && i <= 9)
                    {
                        Id = Convert.ToString(aniox) + 0 + mes;
                        IdPeriodo = Convert.ToInt32(Id);

                    }

                    else
                    {
                        Id = Convert.ToString(aniox) + mes;
                        IdPeriodo = Convert.ToInt32(Id);
                    }

                    item.IdPeriodo = IdPeriodo;
                    item.pe_anio = anio;
                    item.pe_mes = mes;
                    item.pe_FechaIni = p;
                    item.pe_FechaFin = q;
                    item.pe_estado = "A";


                    listaDetalle.Add(item);

                }

                DataSource = new BindingList<ro_periodo_Info>(listaDetalle);
                this.gridControlPeriodo.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void generarQuincenal()
        {

            try
            {

                int periodo = 12;

                List<ro_periodo_Info> listaDetalle = new List<ro_periodo_Info>();

                for (int i = 1; i <= periodo; i++)
                {

                    int dayMes = 0;
                    int aniox = Convert.ToInt32(this.cmbAnio.Text);

                    DateTime k = new DateTime(aniox, i, 1);
                    int mes = k.Month;
                    int anio = k.Year;

                    dayMes = System.DateTime.DaysInMonth(anio, mes);

                    for (int j = 1; j <= 2; j++)
                    {

                        ro_periodo_Info item = new ro_periodo_Info();

                        if (j == 1)
                        {
                            DateTime p = new DateTime(anio, i, 1);
                            DateTime q = new DateTime(anio, i, 15);

                            //string Id = Convert.ToString(aniox) + mes + j;
                            //int IdPeriodo = Convert.ToInt32(Id);

                            string Id = "";
                            int IdPeriodo = 0;
                            if (i >= 1 && i <= 9)
                            {
                                Id = Convert.ToString(aniox) + 0 + mes + 0 + j;
                                IdPeriodo = Convert.ToInt32(Id);

                            }

                            else
                            {

                                Id = Convert.ToString(aniox) + mes + 0 + j;
                                IdPeriodo = Convert.ToInt32(Id);
                            }

                            item.IdPeriodo = IdPeriodo;
                            item.pe_anio = anio;
                            item.pe_mes = mes;
                            item.pe_FechaIni = p;
                            item.pe_FechaFin = q;
                            item.pe_estado = "A";
                            listaDetalle.Add(item);

                        }

                        else
                        {

                            if (j == 2)
                            {
                                DateTime p = new DateTime(anio, i, 16);
                                DateTime q = new DateTime(anio, i, dayMes);

                                //string Id = Convert.ToString(aniox) + mes + j;
                                //int IdPeriodo = Convert.ToInt32(Id);

                                string Id = "";
                                int IdPeriodo = 0;
                                if (i >= 1 && i <= 9)
                                {
                                    Id = Convert.ToString(aniox) + 0 + mes + 0 + j;
                                    IdPeriodo = Convert.ToInt32(Id);

                                }

                                else
                                {

                                    Id = Convert.ToString(aniox) + mes + 0 + j;
                                    IdPeriodo = Convert.ToInt32(Id);
                                }

                                item.IdPeriodo = IdPeriodo;
                                item.pe_anio = anio;
                                item.pe_mes = mes;
                                item.pe_FechaIni = p;
                                item.pe_FechaFin = q;
                                item.pe_estado = "A";
                                listaDetalle.Add(item);
                            }

                        }

                    }

                    DataSource = new BindingList<ro_periodo_Info>(listaDetalle);
                    this.gridControlPeriodo.DataSource = DataSource;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void generarSem()
        {
            try
            {
                ro_periodo_Info item = new ro_periodo_Info();

                int aniox = Convert.ToInt32(this.cmbAnio.Text);
                string Id = "";

                DateTime SemIni = new DateTime();
                DateTime SemFin = new DateTime();

                DateTime fecha = new DateTime(aniox, 1, 1);

                DateTime fecha2 = new DateTime(aniox, 1, 1);

                while (fecha.DayOfWeek != DayOfWeek.Monday)
                {
                    //if (fecha.DayOfWeek == DayOfWeek.Tuesday)
                    //{
                    //    fecha = fecha.AddDays(5);
                    //}                    
                    fecha = fecha.AddDays(1);
                }

                int periodos = 52;
                int IdPeriodo = 0;
                int j = 0;

                List<ro_periodo_Info> listaDetalle = new List<ro_periodo_Info>();

                //ro_periodo_Info item = new ro_periodo_Info();
                for (int i = 0; i <= periodos; i++)
                {
                    // ro_periodo_Info item = new ro_periodo_Info();

                    #region codigo Optener digitos

                   


                    #endregion

                    IdPeriodo = (aniox * 1000) + i;

                    SemIni = (fecha.AddDays(i * 7));
                    SemFin = (fecha.AddDays((i * 7) + 6));

                    item.IdPeriodo = IdPeriodo;
                    item.pe_anio = aniox;
                    item.pe_mes = 0;
                    item.pe_FechaIni = SemIni;
                    item.pe_FechaFin = SemFin;

                    int anioIni = SemIni.Year;
                    int anioFin = SemFin.Year;

                    if ((item.pe_anio != anioIni) && (item.pe_anio != anioFin))
                    {
                    }
                    else
                    {
                        listaDetalle.Add(item);
                    }
                }

                DataSource = new BindingList<ro_periodo_Info>(listaDetalle);
                this.gridControlPeriodo.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void generarSemanal()
        {
            try
            {
                int aniox = Convert.ToInt32(this.cmbAnio.Text);
                DateTime FIniSemana = new DateTime(1900, 1, 1);
                DateTime FFinSemana = new DateTime(1900, 1, 1);

                int IdSemana = 0;
                int IdSemanaAux = 1;

                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = dfi.Calendar;


                DateTime fecha = new DateTime(aniox, 1, 1);
                if (Convert.ToString( fecha.DayOfWeek) == "Sunday")
                {
                    fecha = fecha.AddDays(1);
                }
                if (Convert.ToString( fecha.DayOfWeek) == "Saturday")
                {
                    fecha = fecha.AddDays(2);
                }
                List<ro_periodo_Info> listaSemana = new List<ro_periodo_Info>();

                //contador dias del año
                int dias;
                // DateTime fechar = new DateTime(aniox, 1, 1);
                int contaDiasAnio = 0;
                for (int i = 1; i <= 12; i++)
                {
                    DateTime fechAnio = new DateTime(aniox, i, 1);
                    dias = DateTime.DaysInMonth(fechAnio.Year, fechAnio.Month);
                    contaDiasAnio = contaDiasAnio + dias;
                    //MessageBox.Show("Dias" + dias);
                }
                //contador dias del año  

                FIniSemana = fecha;
                int j = 1;
                for (int i = 1; i <= contaDiasAnio; i++)
                {
                    IdSemana = cal.GetWeekOfYear(fecha, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                    FFinSemana = fecha;

                    if (IdSemanaAux != IdSemana)
                    {
                        int cont = (aniox * 1000) + j;
                        ro_periodo_Info item = new ro_periodo_Info();

                        item.IdPeriodo = cont;
                        item.pe_anio = aniox;
                        item.pe_mes = fecha.Month;
                        item.pe_FechaIni = FIniSemana;
                        item.pe_FechaFin = FFinSemana;
                        item.pe_estado = "A";

                        listaSemana.Add(item);
                        // lista.Add("Semana : " + IdSemana + "fecha desde:" + FIniSemana.ToString() + "   Hasta:" + FFinSemana.ToString());
                        FIniSemana = fecha.AddDays(1);
                        IdSemanaAux = IdSemana;
                        j = j + 1;
                    }
                    fecha = fecha.AddDays(1);
                }

                DataSource = new BindingList<ro_periodo_Info>(listaSemana);
                this.gridControlPeriodo.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        Boolean Validar()
        {

            try
            {
                if (this.cmbPeriodo.EditValue == null || cmbPeriodo.EditValue == "")
                {
                    MessageBox.Show("Por favor ingrese el periodo ", "Sistemas");
                    return false;
                }

                if (this.cmbAnio.EditValue == null || cmbAnio.EditValue == "")
                {
                    MessageBox.Show("Por favor ingrese el año  ", "Sistemas");
                    return false;
                }

                if (this.gridViewPeriodo.RowCount == 0)
                {
                    MessageBox.Show("Por favor genere el periodo ", "Sistemas");

                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        Boolean ValidarGeneracionPeriodo()
        {

            try
            {
                if (this.cmbPeriodo.EditValue == null || cmbPeriodo.EditValue == "")
                {
                    MessageBox.Show("Por favor ingrese el periodo ", "Sistemas");
                    return false;
                }

                if (this.cmbAnio.EditValue == null || cmbAnio.EditValue == "")
                {
                    MessageBox.Show("Por favor ingrese el año  ", "Sistemas");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }



        public Boolean Guardar()
        {
            try
            {
                if (Validar() == false)
                {
                    return false;
                }

                string msg = "";

                List<ro_periodo_Info> list_Periodo = new List<ro_periodo_Info>();
                for (int i = 0; i <= gridViewPeriodo.RowCount; i++)
                {
                    var inf = (ro_periodo_Info)gridViewPeriodo.GetRow(i);

                    if (inf != null)
                    {
                        ro_periodo_Info Item = new ro_periodo_Info();

                        Item.IdEmpresa = param.IdEmpresa;

                        Item.IdPeriodo = inf.IdPeriodo;
                        Item.pe_anio = inf.pe_anio;
                        Item.pe_mes = inf.pe_mes;

                        Item.pe_FechaIni = inf.pe_FechaIni;
                        Item.pe_FechaFin = inf.pe_FechaFin;
                        Item.pe_estado = inf.pe_estado;

                        list_Periodo.Add(Item);
                    }
                }


                if (Bus_Periodos.GuardarPeriodos(list_Periodo, ref msg))
                {
                    MessageBox.Show("Periodos guardados correctamente", "Sistemas");
                    Limpiar();
                }


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }


        }

        public Boolean GenerarPeriodos()
        {
            try
            {
                if (ValidarGeneracionPeriodo() == false)
                {
                    return false;
                }

                if (Convert.ToString(this.cmbPeriodo.EditValue) == "MEN")
                {
                    generarMensual();
                }

                else
                {
                    if (Convert.ToString(this.cmbPeriodo.EditValue) == "QUINCE")
                    {
                        generarQuincenal();
                    }

                    else
                    {
                        if (Convert.ToString(this.cmbPeriodo.EditValue) == "SEM")
                        {
                            generarSemanal();

                        }

                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }


        }

        private void button1_Click(object sender, EventArgs e) { }

        private static void GetWeek(DateTime now, CultureInfo cultureInfo, out DateTime begining, out DateTime end)
        {
            try
            {

                if (now == null)
                    throw new ArgumentNullException("now");
                if (cultureInfo == null)
                    throw new ArgumentNullException("cultureInfo");

                var firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;

                int offset = firstDayOfWeek - now.DayOfWeek;
                if (offset != 1)
                {
                    DateTime weekStart = now.AddDays(offset);
                    DateTime endOfWeek = weekStart.AddDays(6);
                    begining = weekStart;
                    end = endOfWeek;
                }
                else
                {
                    begining = now.AddDays(-6);
                    end = now;
                }

                end = now;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                throw;

            }
        }

        private static DateTime GetFirstDayOfWeek(DateTime sourceDateTime)
        {

            try
            {
                var daysAhead = (DayOfWeek.Sunday - (int)sourceDateTime.DayOfWeek);

                sourceDateTime = sourceDateTime.AddDays((int)daysAhead);

                return sourceDateTime;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public static DateTime GetLastDayOfWeek(DateTime sourceDateTime)
        {
            var daysAhead = DayOfWeek.Saturday - (int)sourceDateTime.DayOfWeek;

            sourceDateTime = sourceDateTime.AddDays((int)daysAhead);

            return sourceDateTime;
        }

        private void frmRo_Generar_Periodo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                GenerarPeriodos();

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
            { cmbPeriodo.EditValue=null;
              cmbAnio.EditValue=null;
              DataSource = new BindingList<ro_periodo_Info>();
              gridControlPeriodo.DataSource = DataSource;
              LoadDatos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
