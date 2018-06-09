using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using System.Globalization;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Generar_Periodo : Form
    {
        #region "Declaración de Variables"

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Aca_Catalogo_Bus Bus_Catalogo = new Aca_Catalogo_Bus();
        List<Aca_Catalogo_Info> lstPago = new List<Aca_Catalogo_Info>();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Periodo_Bus Bus_Periodos = new Aca_Periodo_Bus();
        Aca_Anio_Lectivo_Info Info_AnioLectivo = new Aca_Anio_Lectivo_Info();
        Aca_Anio_Lectivo_Bus Bus_AnioLectivo = new Aca_Anio_Lectivo_Bus();

        List<Aca_Anio_Lectivo_Info> ListAnioLectivo = new List<Aca_Anio_Lectivo_Info>();

        BindingList<Aca_Periodo_Info> lista_Periodo = new BindingList<Aca_Periodo_Info>();




        #endregion

        public FrmAca_Generar_Periodo()
        {
            InitializeComponent();
        }

        void generarMensual()
        {
            try
            {


                DateTime fecha;
                string IdPeriodo = "";
                int rangoMeses = 0;
                rangoMeses = Math.Abs((dt_FechaFin.Value.Month - dt_FechaDesde.Value.Month) + 12 * (dt_FechaFin.Value.Year - dt_FechaDesde.Value.Year));


                for (int i = 0; i < rangoMeses + 1; i++)
                {
                    Aca_Periodo_Info item = new Aca_Periodo_Info();
                    int dayMes = 0;

                    fecha = dt_FechaDesde.Value.AddMonths(i);

                    IdPeriodo = ((fecha.Year) * 100 + fecha.Month).ToString();
                    dayMes = System.DateTime.DaysInMonth(fecha.Year, fecha.Month);
                    DateTime p = new DateTime(fecha.Year, fecha.Month, 1);
                    DateTime q = new DateTime(fecha.Year, fecha.Month, dayMes);

                    item.IdPeriodo = Convert.ToInt32(IdPeriodo);
                    item.pe_anio = fecha.Year;
                    item.pe_mes = fecha.Month;
                    item.pe_FechaIni = p;
                    item.pe_FechaFin = q;
                    item.pe_estado = "A";
                    if (i == 0) 
                    {
                        item.est_apertura = "A";
                    }
                    else
                    {
                        item.est_apertura = "I";
                    }


                    //item.IdAnioLectivo = cmbAnio.EditValue.ToString();
                    item.IdAnioLectivo = Convert.ToInt16(cmbAnio.EditValue.ToString());

                    item.IdInstitucion = param.IdInstitucion;

                    lista_Periodo.Add(item);
                }

                this.gridControlPeriodo.DataSource = lista_Periodo;



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        Boolean Validar()
        {
            try
            {
                if (this.cmbPeriodo.EditValue == null || cmbPeriodo.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Periodo ", param.Nombre_sistema);
                    cmbPeriodo.Focus();
                    return false;
                }

                if (this.cmbAnio.EditValue == null || cmbAnio.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " año lectivo ", param.Nombre_sistema);
                    cmbAnio.Focus();
                    return false;
                }

                if (this.gridViewPeriodo.RowCount == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_genere_el) + " Periodo Lectivo " , param.Nombre_sistema);

                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean ValidarGeneracionPeriodo()
        {
            try
            {
                if (this.cmbPeriodo.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Periodo ", param.Nombre_sistema);
                    return false;
                }

                if (this.cmbAnio.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " año lectivo ", param.Nombre_sistema);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                Bus_Periodos = new Aca_Periodo_Bus();
                if (Bus_Periodos.GrabarDB_Periodos(new List<Aca_Periodo_Info>(lista_Periodo), ref msg))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public void Limpiar()
        {
            try
            {
                cmbPeriodo.EditValue = null;
                cmbAnio.EditValue = null;
                lista_Periodo = new BindingList<Aca_Periodo_Info>();
                gridControlPeriodo.DataSource = lista_Periodo;
                gridControlPeriodo.RefreshDataSource();

            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
                    Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
                    Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                GenerarPeriodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

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

        void Cargar_Datos()
        {
            try
            {
                // Cargando combo Periodo de pago
                lstPago = Bus_Catalogo.Get_List_CatalogoXtipo("PERI");
                this.cmbPeriodo.Properties.DataSource = lstPago;
                if (lstPago.Count != 0)
                {
                    cmbPeriodo.EditValue = "MEN";
                }

                ListAnioLectivo = Bus_AnioLectivo.Get_List_Anio_Lectivo(param.IdInstitucion);
                cmbAnio.Properties.DataSource = ListAnioLectivo;
                cmbAnio.Properties.DisplayMember = "Descripcion";
                cmbAnio.Properties.ValueMember = "IdAnioLectivo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void FrmAca_Generar_Periodo_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Datos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbAnio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAnio.EditValue != null)
                {
                    Aca_Anio_Lectivo_Info InfoAnio = ListAnioLectivo.FirstOrDefault(v => v.IdInstitucion == param.IdInstitucion && v.IdAnioLectivo == Convert.ToInt16(cmbAnio.EditValue));
                    if (InfoAnio != null)
                    {
                        dt_FechaFin.Value = InfoAnio.FechaFin;
                        dt_FechaDesde.Value = InfoAnio.FechaInicio;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
