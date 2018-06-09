using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info;
using Core.Erp.Business;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using Core.Erp.Info.General;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_PrestamosQuirografarios_ImportacionWizard : Form
    {
        //Carlos C.
        // bus grabar Novedad

        DateTime Fecha_Excle;
        string IdCalendario = "";
        string NombreArchivo = "";
        //GrabarDBCabyDet
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        int NumeroPeriodoNominaSemanal = 0, NumeroPeriodoNominaMensual = 0;
        double ValorNovedad = 0;
        Int32 IdNomina = 0;
        bool Bandera_ValidarPagina;
        bool BanderaSiPeriodoProcesado = false;
        string PeriodoProcesado = "";
        // instancias bisne
        ro_Novedad_Subida_Bach_Bus BusControlSubidaNovedad = new Business.Roles.ro_Novedad_Subida_Bach_Bus();
        ro_Empleado_Novedad_Bus BusNovedadXempleado = new ro_Empleado_Novedad_Bus();


        tb_Calendario_Info InfoCalendario = new tb_Calendario_Info();
        tb_Calendario_Bus Bus_Calendario = new tb_Calendario_Bus();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_periodo_Bus Bus = new ro_periodo_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus Bus_Periodo = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
        ro_Empleado_Bus dataEmp = new ro_Empleado_Bus();

        // instancia info
        ro_Empleado_Novedad_Det_Info InfoNovedadGrabarDetalle = new ro_Empleado_Novedad_Det_Info();
        ro_Empleado_Novedad_Info InfoNovedadGrabarCAB = new ro_Empleado_Novedad_Info();
        ro_Novedad_x_Empleado_Info InfoNovedadGrabar_x_Empleado = new ro_Novedad_x_Empleado_Info();
        ro_rubro_tipo_Info InfoRubros = new ro_rubro_tipo_Info();

   
        // total de lista de periodo
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ListadoPeriodos = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ListadoPeriodosSemanal = new BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ListadoPeriodosMensual = new BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ListadoPeriodosQuincenal = new BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        // lista de periodos seleccionados

        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ListadoPeriodosSemanal_Seleccionado = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ListadoPeriodosMensual_Seleccionado = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ListadoPeriodosQuincenal_Seleccionado = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        // lista empleados
        List<ro_Empleado_Info> lstTodosEmp = new List<ro_Empleado_Info>();
        List<ro_Empleado_Novedad_Det_Info> ListaEmpleadoSemanal = new List<ro_Empleado_Novedad_Det_Info>();
        List<ro_Empleado_Novedad_Det_Info> ListaEmpleadoMensual = new List<ro_Empleado_Novedad_Det_Info>();


        // lista para grabar
        List<ro_Empleado_Novedad_Det_Info> lista = new List<ro_Empleado_Novedad_Det_Info>();
        List<ro_Empleado_Novedad_Det_Info> listaNovedadGrabar_Detalle = new List<ro_Empleado_Novedad_Det_Info>();
        List<ro_Empleado_Novedad_Info> ListaNovedadesGrabarCab = new List<ro_Empleado_Novedad_Info>();
        List<ro_Novedad_x_Empleado_Info> ListaNovedadesGraba_x_empleado = new List<ro_Novedad_x_Empleado_Info>();

        List<ro_Empleado_Novedad_Det_Info> listaNovedadGrabar_Detalle_TMP = new List<ro_Empleado_Novedad_Det_Info>();


         
           


        #region Variables Para Carga de Excel
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        string plantilla = "Plantilla";
        DataTable dt;
        #endregion

        public frmRo_PrestamosQuirografarios_ImportacionWizard()
        {
            InitializeComponent();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            try
            {
              PU_OBTENER_RUTA();
            if (!CargarHojasCombo())
                MessageBox.Show("Archivo de excel no valido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

        //obtener archivo
        void PU_OBTENER_RUTA()
        {
            try
            {
                //Te Declaras un Objeto de Tipo OpenFileDialog
                OpenFileDialog dialogo = new OpenFileDialog();
               // dialogo.Filter = "All files ";
                dialogo.InitialDirectory = @"C:\";
                //para mostrar el cuadro de seleccion de archivo hacemos asi:
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    fileName = System.IO.Path.GetFileName(dialogo.FileName);
                    path = Path.GetDirectoryName(dialogo.FileName);
                    tipofile = System.IO.Path.GetExtension(dialogo.FileName);
                    ruta = path + "\\" + fileName;
                    TxtRuraFile.Text = ruta;

                    NombreArchivo = fileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        // lleno combo con las hohas del file
        bool CargarHojasCombo()
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                bool flag = false;
                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;
                if (ruta != "")
                {
                    if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                    {
                        cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                        cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                    }
                    else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                    {
                        cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                        cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                    }

                    OleDbConnection mconn2 = new OleDbConnection(cb.ConnectionString);
                    //abre una conexion de tipo oledb
                    mconn2.Open();
                    dt = mconn2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    //Lo agrega a mi datatable
                    if (dt != null)
                    {
                        String[] excelSheets = new String[dt.Rows.Count];
                        int i = 0;

                        // Add the sheet name to the string array.
                        cmbHoja.Items.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            excelSheets[i] = row["TABLE_NAME"].ToString();
                            cmbHoja.Items.Add(excelSheets[i].Substring(0, excelSheets[i].Length - 1)); //$
                            i++;
                        }
                        cmbHoja.SelectedIndex = 0;
                        //cierra una conexion de tipo oledb                
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                    mconn2.Close();
                    return flag;
                }
                else
                {
                    return flag;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); dt = new DataTable();
                return false;
            }
        }

        // llenar grid con datos hoja seleccionada
        public void GetListaDelExcel(string RutaFile)
        {
            lista = new List<ro_Empleado_Novedad_Det_Info>();
            int Secuencia = 0;
            try
            {
                // leo el excel
                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = RutaFile;
                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }
                using (OleDbConnection conexion = new OleDbConnection(cb.ConnectionString))
                {

                    
                   string Hoja =LimpiarCadena( cmbHoja.Text );                                     
                    conexion.Open();
                    string Sql = "SELECT Cedula,Nombre,Concepto,sum(Valor),Fecha " +
                      "FROM [" + Hoja + "$]  where Valor > 0 " +
                      "group by Cedula,Nombre,Concepto,Fecha";

                   OleDbCommand Cmd = new OleDbCommand(Sql, conexion);
                   OleDbDataReader Reader = Cmd.ExecuteReader();
                   while (Reader.Read())
                   {
                       Secuencia = Secuencia + 1;
                       string Cedula = "";
                       ro_Empleado_Novedad_Det_Info Info = new ro_Empleado_Novedad_Det_Info();

                       if (Reader.IsDBNull(0) == false)
                       {
                           // verifico si empleado existe en la base
                           Cedula = Reader.GetString(0);
                           if (Cedula.Length == 9)
                           {
                               Cedula = "0" + Cedula;
                           }
                         

                           ro_Empleado_Info emp = new ro_Empleado_Info();
                           try
                           {
                               emp = lstTodosEmp.First(var => var.InfoPersona.pe_cedulaRuc == Cedula);

                           }
                           catch (Exception)
                           {
                               
                               
                           }
                           if (emp.IdEmpleado != 0 && emp.IdEmpleado!=null)// si existe en la base
                           {
                               
                               
                               Info.IdEmpresa = param.IdEmpresa;
                               Info.IdEmpleado = emp.IdEmpleado;
                               Info.em_codigo = emp.em_codigo;
                               Info.em_cedula = emp.InfoPersona.pe_cedulaRuc;
                               Info.em_nombre = emp.NomCompleto;
                               Info.EstadoCobro = "PEN";
                               Info.Estado = "A";
                               Info.existeerror = "N";
                               Info.Valor = Reader.GetDouble(3);
                               Info.Fecha_Excel = Reader.GetDateTime(4);
                               Fecha_Excle = Info.Fecha_Excel;
                               Info.IdNovedad = Secuencia;
                               Info.IdNomina = emp.IdNomina_Tipo;
                               Info.Nomina = emp.Nomina;
                               Info.Nombre = emp.InfoPersona.pe_nombre;
                               Info.Apellidos = emp.InfoPersona.pe_apellido;
                          
                           }

                           else
                           {
                               Info.IdEmpresa = param.IdEmpresa;
                               Info.IdEmpleado = 0;
                               Info.em_cedula = Reader.GetString(0); 
                               Info.em_codigo = "";
                               Info.em_nombre = Reader.GetString(1); 
                               Info.EstadoCobro = "PEN";
                               Info.Estado = "I";
                               Info.existeerror = "ERROR";
                               Info.Observacion = "Empleado no existe en la Base ó Ya fue Liquidado";
                               Info.IdNovedad = Secuencia;
                               Info.Nomina = "";
                               Info.Valor = Reader.GetDouble(3);
                               Info.IdNomina = emp.IdNomina_Tipo;
                           }
                           lista.Add(Info);
                       }
                   }
                    // obtengo idCalendario
                   InfoCalendario = Bus_Calendario.Get_Info_Calendario(Convert.ToDateTime(Fecha_Excle));
                   IdCalendario = InfoCalendario.IdCalendario.ToString(); 

                   Reader.Close();
                    conexion.Close();
                }

                            
            }
            catch (Exception ex)
            {
                Bandera_ValidarPagina = false;
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void wizardImportacionPQ_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {

            try
            {
                switch (e.Page.Name)
                {
                    case "WizardPaginainicio":
                        break;
                    case "wizardPaginaSeleccionFile":
                        if (ValidarSiSeleccionofile())
                        {
                            GetListaDelExcel(TxtRuraFile.Text);
                            gridControlNovxEmp.DataSource = lista;
                            LbNombreFile.Text = "Archivo Seleccionado: " + NombreArchivo;
                        }
                        break;
                    case "wizardPaginaempleados":
                        SepararNomina();
                        break;
                    case "wizardPaginaDividirNomina":
                        CargarPeriodos();
                        break;
                    case "wizardPaginaFormadeDescontar_Periodos":
                        if (ValidarSeleccionDePeriodos())
                        {
                            AsignarValor_Novedad();
                        }
                        break;

                    case "wizardPaginaNovedadesCreadas":
                        if (MessageBox.Show("¿Está seguro que desea Subir las novedades Creadas ?", "Importacion de Novedades", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (BanderaSiPeriodoProcesado == true)
                            {
                                if (MessageBox.Show("¿Uno o varios periodos ya han sido procesados desea agregar las novedades?", "Importacion de Novedades", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Bandera_ValidarPagina = true;
                                    GrabarDB();
                                }
                                else
                                {
                                    Bandera_ValidarPagina = false;
                                }
                            }
                            else
                            {
                                Bandera_ValidarPagina = true;
                                GrabarDB();
                            }
                        }
                        else
                        {
                            Bandera_ValidarPagina = false;

                        }
                        break;

                    default:
                        break;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void wizardImportacionPQ_CancelClick(object sender, CancelEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea Salir Del Asistente de Importacion de Novedades?", "Importacion de Novedades", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                    Bandera_ValidarPagina = true;

                }
                else
                {
                    Bandera_ValidarPagina = false;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void wizardImportacionPQ_FinishClick(object sender, CancelEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmRo_PrestamosQuirografarios_ImportacionWizard_Load(object sender, EventArgs e)
        {
            try
            {
                lstTodosEmp = dataEmp.Get_List_Empleado_x_Nomina(param.IdEmpresa).Where(v => v.em_estado == "A" && v.em_status != "EST_LIQ").ToList();
                CargarRubrosNovedad();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void CargarPeriodos()
        {
            try
            {
                ListadoPeriodos = Bus_Periodo.ConsultaPerNomTipLiq(param.IdEmpresa).ToList();

                // obtengo periodos semanales
                ListadoPeriodosMensual = new BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info>(ListadoPeriodos.Where(v => v.IdNomina_Tipo == 1 ).ToList());
                gridControlPeriodoMensual.DataSource = ListadoPeriodosMensual;
                // obtengo periodos mensuales

                ListadoPeriodosSemanal= new BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info>(ListadoPeriodos.Where(v => v.IdNomina_Tipo==2 ).ToList());
                gridCtrlPeriodoSemanal.DataSource = ListadoPeriodosSemanal;

                //obtengo los periodos quincenales
                ListadoPeriodosQuincenal = new BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info>(ListadoPeriodos.Where(v => v.IdPeriodo.ToString().Length == 8).ToList());
                gridControlPeriodoQuincenal.DataSource = ListadoPeriodosQuincenal; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void SepararNomina()
        {
            try
            {
                ListaEmpleadoSemanal = new List<ro_Empleado_Novedad_Det_Info>();
                ListaEmpleadoMensual = new List<ro_Empleado_Novedad_Det_Info>();
                foreach (var item in lista)
                {
                    if (item.existeerror != "ERROR")
                    {
                        if (item.IdNomina == 2)
                        {
                            ListaEmpleadoSemanal.Add(item);
                        }
                        else
                        {
                            ListaEmpleadoMensual.Add(item);
                        }
                    }
                }

                gridControlNominaSemanal.DataSource = ListaEmpleadoSemanal;
                gridControlNominaMensual.DataSource = ListaEmpleadoMensual;


                // pregunto si hay empleados de  nominas semanal

                if (ListaEmpleadoSemanal.Count == 0)
                {
                    groupBoxPeriodoSemanal.Text = "No ubieron empleado para el Proceso de Pago semanal";
                    groupBoxPeriodoSemanal.Enabled = false;

                }
                else
                {
                    groupBoxPeriodoSemanal.Text = "Periodos de Pago Semanal";
                }

                // pregunto si hay empleados de  nominas mensual

                if (ListaEmpleadoMensual.Count == 0)
                {
                    groupBoxPagosMemsuAL.Text = "No ubieron empleado para el Proceso de Pago Mensual";
                    groupBoxPagosMemsuAL.Enabled = false;

                }
                else
                {
                    groupBoxPagosMemsuAL.Text = "Periodos de Pago Mensual";
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void CargarRubrosNovedad()
        {
            try
            {
                ro_rubro_tipo_Bus busRubro = new ro_rubro_tipo_Bus();

                var lstRubro = (from a in busRubro.Get_List_Formulas(param.IdEmpresa)
                                where a.rub_concep == true
                                select a).ToList();




                
                cmbNovedad.Properties.DataSource = lstRubro;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void AsignarValor_Novedad()
        {
            BanderaSiPeriodoProcesado = false;
            ListaNovedadesGrabarCab = new List<ro_Empleado_Novedad_Info>();
            listaNovedadGrabar_Detalle_TMP = new List<ro_Empleado_Novedad_Det_Info>();
            int Sec_Detalle = 0, IdNomina_TipoLiqui = 0;
            DateTime Fecha_PrimerPago = DateTime.Now;
            listaNovedadGrabar_Detalle = new List<ro_Empleado_Novedad_Det_Info>();
            try
            {
                NumeroPeriodoNominaMensual = ListadoPeriodosMensual.Where(v => v.check == true).Count();
                NumeroPeriodoNominaSemanal = ListadoPeriodosSemanal.Where(v => v.check == true).Count();

                // recoro mi lista obtenida desde excell
                foreach (var item in lista)
                {
                    


                    Sec_Detalle = 0;
                    if (item.existeerror != "ERROR")// solo tomo a los empleado que existen en la base
                    {

                        listaNovedadGrabar_Detalle = new List<ro_Empleado_Novedad_Det_Info>();
                        ListaNovedadesGraba_x_empleado = new List<ro_Novedad_x_Empleado_Info>();

                        // para crear la lista detalle de novedad
                        InfoNovedadGrabarDetalle = new ro_Empleado_Novedad_Det_Info();
                        ValorNovedad = 0;

                        // llenar la lista para la tabla ro_Empleado_Novedad_Det

                        if (item.IdNomina == 2) // pregunto si es nomina semanal
                        {
                            ValorNovedad = Math.Round(item.Valor / NumeroPeriodoNominaSemanal, 2); // obtego el valor de novedad en caso de ser nomina semanal
                            foreach (var item_P in ListadoPeriodosSemanal.Where(v => v.check == true).ToList())
                            {
                                if (item_P.Procesado == "S")
                                {
                                    BanderaSiPeriodoProcesado = true;
                                    PeriodoProcesado = item_P.IdPeriodo.ToString();
                                    
                                }
                               

                                Sec_Detalle = Sec_Detalle + 1;
                                IdNomina_TipoLiqui = item_P.IdNomina_TipoLiqui;
                                if (Sec_Detalle == 1)
                                {
                                    Fecha_PrimerPago = item_P.pe_FechaIni;
                                }
                                InfoNovedadGrabarDetalle = new ro_Empleado_Novedad_Det_Info();
                                InfoNovedadGrabarDetalle.em_cedula = item.em_cedula;
                                InfoNovedadGrabarDetalle.Nombre = item.Nombre;
                                InfoNovedadGrabarDetalle.Apellidos = item.Apellidos;

                                InfoNovedadGrabarDetalle.Nomina = item.Nomina;
                                InfoNovedadGrabarDetalle.em_nombre = item.em_nombre;
                                InfoNovedadGrabarDetalle.IdEmpresa = param.IdEmpresa;
                                InfoNovedadGrabarDetalle.IdNovedad = 0;
                                InfoNovedadGrabarDetalle.IdEmpleado = item.IdEmpleado;
                                InfoNovedadGrabarDetalle.Secuencia = Sec_Detalle;
                                InfoNovedadGrabarDetalle.IdRol = "";
                                InfoNovedadGrabarDetalle.IdRubro = "";
                                InfoNovedadGrabarDetalle.FechaPago = item_P.pe_FechaIni.AddDays(1);
                                InfoNovedadGrabarDetalle.Valor = ValorNovedad;
                                InfoNovedadGrabarDetalle.EstadoCobro = "PEN";
                                InfoNovedadGrabarDetalle.Observacion = cmbNovedad.Text;
                                InfoNovedadGrabarDetalle.Estado = "A";
                                InfoNovedadGrabarDetalle.IdRubro = Convert.ToString(cmbNovedad.EditValue);
                                InfoNovedadGrabarDetalle.IdCalendario = IdCalendario;
                                listaNovedadGrabar_Detalle.Add(InfoNovedadGrabarDetalle);
                                
                                listaNovedadGrabar_Detalle_TMP.Add(InfoNovedadGrabarDetalle);


                                // creo la lista para la tabla ro_Novedad_x_Empleado


                            }

                        }

                        else
                        {

                            ValorNovedad = Math.Round(item.Valor / NumeroPeriodoNominaMensual, 2);// obtego el valor de novedad en caso de ser nomina mensual
                            foreach (var item_P in ListadoPeriodosMensual.Where(v => v.check == true).ToList())
                            {
                                if (item_P.Procesado == "S")
                                {
                                    BanderaSiPeriodoProcesado = true;
                                    PeriodoProcesado = item_P.IdPeriodo.ToString();

                                }

                                Sec_Detalle = Sec_Detalle + 1;
                                if (Sec_Detalle == 1)
                                {
                                    Fecha_PrimerPago = item_P.pe_FechaIni;
                                }
                                IdNomina_TipoLiqui = item_P.IdNomina_TipoLiqui;

                                InfoNovedadGrabarDetalle = new ro_Empleado_Novedad_Det_Info();
                                InfoNovedadGrabarDetalle.em_cedula = item.em_cedula;
                                InfoNovedadGrabarDetalle.Nombre = item.Nombre;
                                InfoNovedadGrabarDetalle.Apellidos = item.Apellidos;
                                InfoNovedadGrabarDetalle.Nomina = item.Nomina;
                                InfoNovedadGrabarDetalle.em_nombre = item.em_nombre;
                                InfoNovedadGrabarDetalle.IdEmpresa = param.IdEmpresa;
                                InfoNovedadGrabarDetalle.IdNovedad = 0;
                                InfoNovedadGrabarDetalle.IdEmpleado = item.IdEmpleado;
                                InfoNovedadGrabarDetalle.Secuencia = Sec_Detalle;
                                InfoNovedadGrabarDetalle.IdRol = "";
                                InfoNovedadGrabarDetalle.IdRubro = "";
                                InfoNovedadGrabarDetalle.FechaPago = item_P.pe_FechaIni.AddDays(1);
                                InfoNovedadGrabarDetalle.Valor = ValorNovedad;
                                InfoNovedadGrabarDetalle.EstadoCobro = "PEN";
                                InfoNovedadGrabarDetalle.Observacion = cmbNovedad.Text;
                                InfoNovedadGrabarDetalle.Estado = "A";
                                InfoNovedadGrabarDetalle.IdRubro = Convert.ToString(cmbNovedad.EditValue);
                                InfoNovedadGrabarDetalle.IdCalendario = IdCalendario;

                                listaNovedadGrabar_Detalle.Add(InfoNovedadGrabarDetalle);
                                listaNovedadGrabar_Detalle_TMP.Add(InfoNovedadGrabarDetalle);



                                // creo la lista para la tabla ro_Novedad_x_Empleado


                            }

                        }


                                // creo la lista para la tabla ro_Empleado_Novedad
                                InfoNovedadGrabarCAB = new ro_Empleado_Novedad_Info();
                                InfoNovedadGrabarCAB.IdEmpresa = param.IdEmpresa;
                                InfoNovedadGrabarCAB.IdNovedad = Convert.ToInt32(cmbNovedad.EditValue);
                                InfoNovedadGrabarCAB.IdEmpleado = item.IdEmpleado;
                                InfoNovedadGrabarCAB.IdNomina_Tipo = item.IdNomina;
                                InfoNovedadGrabarCAB.IdNomina_TipoLiqui = IdNomina_TipoLiqui;
                                InfoNovedadGrabarCAB.Fecha = Fecha_Excle;
                                InfoNovedadGrabarCAB.TotalValor = item.Valor;
                                InfoNovedadGrabarCAB.Fecha_PrimerPago = Fecha_PrimerPago;
                                InfoNovedadGrabarCAB.NumCoutas = Sec_Detalle;
                                InfoNovedadGrabarCAB.IdUsuario = param.IdUsuario;
                                InfoNovedadGrabarCAB.Fecha_Transac = DateTime.Now;
                                InfoNovedadGrabarCAB.IdCalendario = IdCalendario;

                       


                               
                                // asigno los detalle a la cabecera
                                InfoNovedadGrabarCAB.LstDetalle = listaNovedadGrabar_Detalle;
                               // InfoNovedadGrabarCAB.lstNovedadEmpleado = ListaNovedadesGraba_x_empleado;
                               
                             
                                ListaNovedadesGrabarCab.Add(InfoNovedadGrabarCAB);
                                
                        


                    }

                    gridControlNovedades.DataSource = listaNovedadGrabar_Detalle_TMP;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public bool GrabarDB()
        {
            bool SiGrabo = false;
            string MsgError="";
            decimal Idtransaccion=0, IdNovedad=0;
            try
            {

                if (BusControlSubidaNovedad.SiArchivoFueSubido(param.IdEmpresa, IdCalendario, Convert.ToString(cmbNovedad.EditValue)))
                {
                    MessageBox.Show("El Archivo Seleccionado se subio con la Novedad " + cmbNovedad.Text);
                    Bandera_ValidarPagina = false;
                    return false;
                }

                foreach (var item in ListaNovedadesGrabarCab)
                {
                    if (BusNovedadXempleado.GrabarDB(item, ref MsgError, ref IdNovedad, ref Idtransaccion))
                    {
                        SiGrabo = true;
                    }
                    
                }

               
                    BusControlSubidaNovedad.GrabarDB(param.IdEmpresa, IdCalendario, Convert.ToString(cmbNovedad.EditValue));
                

                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void cmbNovedad_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoRubros = (ro_rubro_tipo_Info)cmbNovedad.Properties.View.GetFocusedRow();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        public bool ValidarSiSeleccionofile()
        {
            bool Bande = true;
            try
            {
                if (TxtRuraFile.Text == "")
                {
                    MessageBox.Show("Seleccione un Archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    Bande = false;
                }

                if (cmbHoja.Text == "")
                {
                    MessageBox.Show("Seleccione la hoja de Datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    Bande = false;
                }
                Bandera_ValidarPagina = Bande;
                return Bande;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public bool ValidarSeleccionDePeriodos()
        {
            bool Bande = true;
            try
            {
                if (ListadoPeriodosSemanal.Where(v => v.check == true).Count()>4)
                {
                    MessageBox.Show("No Puede Seleccionar mas de 4 Periodos de pagos Para la Nomina Semanal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    Bande = false;
                }
                if (ListaEmpleadoSemanal.Count > 0)
                {
                    if (ListadoPeriodosSemanal.Where(v => v.check == true).Count() == 0)
                    {
                        MessageBox.Show("Existe Empleado de Nomina Semanal Seleccione Periodo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        Bande = false;
                    }



                }



                if (ListadoPeriodosMensual.Where(v => v.check == true).Count() > 1)
                {
                    MessageBox.Show("No Puede Seleccionar mas de 1 Periodos de pagos Para la Nomina Mensual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    Bande = false;
                }
                if (ListaEmpleadoMensual.Count > 0)
                {

                    if (ListadoPeriodosMensual.Where(v => v.check == true).Count() == 0)
                    {
                        MessageBox.Show("Existe Empleado de Nomina Mensual Seleccione Periodo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        Bande = false;
                    }
                }





                if (cmbNovedad.Text == "" || cmbNovedad.EditValue==null)
                {
                    MessageBox.Show("Seleccione Novedad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    Bande = false;
                }
                Bandera_ValidarPagina = Bande;
                return Bande;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void wizardImportacionNovedad_Empleado_PrevClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            try
            {
                Bandera_ValidarPagina = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void wizardPaginaSeleccionFile_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = ValidarSiSeleccionofile();
        }

        private void wizardPaginaSeleccionFile_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            try
            {
              e.Valid=Bandera_ValidarPagina;
             }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void wizardPaginaFormadeDescontar_Periodos_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            try
            {
                e.Valid = Bandera_ValidarPagina;
               
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void wizardPaginaNovedadesCreadas_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            try
            {
                e.Valid = Bandera_ValidarPagina;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_PrestamosQuirografarios_ImportacionWizard_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 27)
                {
                    if (MessageBox.Show("¿Esta seguro que desea Salir Del Asistente de Importacion de Novedades?", "Importacion de Novedades", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        Bandera_ValidarPagina = true;

                    }
                    else
                    {
                        Bandera_ValidarPagina = false;

                    }


                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void wizardImportacionNovedad_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 27)
                {
                    if (MessageBox.Show("¿Esta seguro que desea Salir Del Asistente de Importacion de Novedades?", "Importacion de Novedades", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        Bandera_ValidarPagina = true;

                    }
                    else
                    {
                        Bandera_ValidarPagina = false;

                    }



                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void gridViewNovxEmp_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewNovxEmp.GetRow(e.RowHandle) as ro_Empleado_Novedad_Det_Info;
                if (data == null)
                    return;

                if (data.existeerror == "ERROR")
                    e.Appearance.ForeColor = Color.Red;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewNovxEmp_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewNovxEmp.GetRow(e.RowHandle) as ro_Empleado_Novedad_Det_Info;
                if (data == null)
                    return;

                if (data.existeerror == "ERROR")
                    e.Appearance.ForeColor = Color.Red;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public string LimpiarCadena(string strIn)
       {
        // Replace invalid characters with empty strings.
        try {
           return Regex.Replace(strIn, @"[^\w\.@-]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5)); 
        }
        
        catch (RegexMatchTimeoutException) {
           return String.Empty;   
        }
    }
        
    }
}
