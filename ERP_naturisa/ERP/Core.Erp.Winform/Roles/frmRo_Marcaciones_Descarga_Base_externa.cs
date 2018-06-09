using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using System.Collections;
using System.Threading;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Marcaciones_Descarga_Base_externa : Form
    {
        string Ocon = "",Mensaje="";
        bool BanderaSinoCoincidenDatos = false;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_marcaciones_x_empleado_Info info = null;
        tb_Calendario_Info InfoCalendario = new tb_Calendario_Info();
        List<ro_marcaciones_x_empleado_Info> ListMarc = new List<ro_marcaciones_x_empleado_Info>();
        List<ro_marcaciones_x_empleado_Info> ListMarcGrabar = new List<ro_marcaciones_x_empleado_Info>();
        tb_Calendario_Bus Bus_Calendario = new tb_Calendario_Bus();
        List<ro_Empleado_Info> ListadoEmpleados = new List<ro_Empleado_Info>();
         ro_Empleado_Bus BusEmpleado= new ro_Empleado_Bus();
         BindingList<ro_marcaciones_x_empleado_Info> ListaMarcacionesExterna = new BindingList<ro_marcaciones_x_empleado_Info>();
        ro_marcaciones_x_empleado_Bus BusMarcaciones = new ro_marcaciones_x_empleado_Bus();
        public frmRo_Marcaciones_Descarga_Base_externa()
        {
            InitializeComponent();
        }


        public void CargarData()
        {
            try
            {
                if (cmbTipoEquipo.EditValue == null || cmbTipoEquipo.Text == "")
                {
                    MessageBox.Show(" Seleccione el Biometrico");
                    cmbTipoEquipo.Focus();
                    return;

                }

                splashScreenManagereEspera.ShowWaitForm();
                if(param.IdCliente_Ven_x_Default==Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT)
                    ListaMarcacionesExterna = new BindingList<ro_marcaciones_x_empleado_Info>(BusMarcaciones.Get_List_marcaciones_x_empleado_Graf(DtpFechaI.Value, DtpFechaF.Value, Ocon));

                    else

                ListaMarcacionesExterna = new BindingList<ro_marcaciones_x_empleado_Info>( BusMarcaciones.Get_List_marcaciones_x_empleado(DtpFechaI.Value, DtpFechaF.Value, Ocon));
                if (ListaMarcacionesExterna.Count == 0)
                {
                    MessageBox.Show(" No hay marcaciones para la fecha seleccionada");
                    return;
                }
                gridControlMarcacionesBaseExterna.DataSource = ListaMarcacionesExterna;
                VerificaSiEmpleadoExisteBase_VZEN();
                splashScreenManagereEspera.CloseWaitForm();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_Marcaciones_Descarga_Base_externa_Load(object sender, EventArgs e)
        {
            try
            {  ro_marcaciones_Equipo_Bus busEquipos = new ro_marcaciones_Equipo_Bus();
                var listadoequipos = busEquipos.Get_List_marcaciones_Equipo(param.IdEmpresa,param.IdSucursal);
                cmbTipoEquipo.Properties.DataSource = listadoequipos;

                CargarEmpleados();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

      


        public void CargarEmpleados()
        {
            try
            {
                ListadoEmpleados = BusEmpleado.Get_List_Empleado_persona(param.IdEmpresa);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        public void VerificaSiEmpleadoExisteBase_VZEN()
        {
            try
            {
               
                foreach (var item in ListaMarcacionesExterna)
                {
                    string Cedula="";
                    decimal IdEmpleado;
                    string Nombres = "", Apellidos = "", Codigo = "";
                    IdEmpleado = 0;
                    if (item.cedula.Length == 9)
                    {
                       item.cedula= "0" +item.cedula;
                    }
                    try
                    {
                        ro_Empleado_Info InfoEmpleado = new ro_Empleado_Info();
                        var Elemento = from element in ListadoEmpleados
                                       where element.pe_cedulaRuc == item.cedula
                                       select element;
                      InfoEmpleado=(ro_Empleado_Info) Elemento.FirstOrDefault();
                      Cedula = InfoEmpleado.pe_cedulaRuc;
                      Nombres = InfoEmpleado.InfoPersona.pe_nombre;
                      Apellidos = InfoEmpleado.InfoPersona.pe_apellido;
                      Codigo = InfoEmpleado.em_codigo;
                      IdEmpleado = InfoEmpleado.IdEmpleado;
                    }
                    catch (Exception)
                    {
                        
                        
                    }

                    if (Cedula == item.cedula)
                    {
                        item.Si_empleadoExisteBaseVZEN = true;
                        item.IdEmpleado = IdEmpleado;
                        item.Apellidos = Apellidos;
                        item.Nombres = Nombres;
                        item.em_codigo = Codigo;
                        item.IdEmpleado = IdEmpleado;
                    }
                    else
                    {
                        item.Si_empleadoExisteBaseVZEN = false;

                    }
                }
                gridControlMarcacionesBaseExterna.RefreshDataSource();
            }
            catch (Exception  ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


       


        public bool getInfo()
        {
            try
            {
                ListMarc = new List<ro_marcaciones_x_empleado_Info>();
                foreach (var item in ListaMarcacionesExterna)
                {
                    int semana = 0;
                    if (item.Si_empleadoExisteBaseVZEN == true && item.check==true)
                    {
                        // creo el registro de ingreso

                        InfoCalendario = Bus_Calendario.Get_Info_Calendario(Convert.ToDateTime(item.es_fechaRegistro));

                        info = new ro_marcaciones_x_empleado_Info();
                        info.IdEmpresa = param.IdEmpresa;
                        info.IdRegistro = null;
                        info.IdEmpleado = item.IdEmpleado;
                        info.secuencia = 1;
                        info.es_Hora = item.HMarcacion;
                        info.es_fechaRegistro =Convert.ToDateTime( item.es_fechaRegistro.ToString().Substring(0,10));
                        info.es_anio = Convert.ToDateTime(item.es_fechaRegistro).Year;
                        info.es_mes = Convert.ToDateTime(item.es_fechaRegistro).Month;
                        info.es_dia = Convert.ToDateTime(item.es_fechaRegistro).Day;
                        info.es_semana = Convert.ToInt32(InfoCalendario.Semana_x_anio);
                        info.es_idDia = Convert.ToInt32(InfoCalendario.dia_x_mes);
                        info.es_sdia = InfoCalendario.NombreDia;
                        info.es_EsActualizacion = "N";
                        info.IdTipoMarcaciones = item.IdTipoMarcaciones;
                        info.IdTipoMarcaciones_Biometrico = item.IdTipoMarcaciones_Biometrico;
                        semana = Convert.ToDateTime(item.es_fechaRegistro).Month * 4;
                        info.es_semana = semana;
                        info.FechaUltimoCorte = DtpFechaF.Value;
                        info.IdEquipo =Convert.ToInt32( cmbTipoEquipo.EditValue);
                        info.Observacion = "Importada desde el Sistema";
                        info.IdUsuario = param.IdUsuario;
                        info.Fecha_Transac = DateTime.Now;
                        info.Estado = "A";
                        ListMarc.Add(info);

                      
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



       

        

        private void cmbTipoEquipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ro_marcaciones_Equipo_Info Info = new ro_marcaciones_Equipo_Info();

                Info = (ro_marcaciones_Equipo_Info)cmbTipoEquipo.Properties.View.GetFocusedRow();
                Ocon = Info.CadenaConexion;
                DtpFechaI.Value = Info.FechaUltimaImportacionMarcaiones.AddDays(1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        private void CmbGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManagereEspera.ShowWaitForm();
                getInfo();

                if (ListaMarcacionesExterna.Count == 0)
                {
                    MessageBox.Show("No Existen Marcaciones", "Sistema VZEN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (BanderaSinoCoincidenDatos)
                {
                    if (MessageBox.Show("Existen Empleados no registro en VZEN ¿Desea Registrar los empleados?", "Importacion de Marcaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmRo_Empleado_Mant frm = new frmRo_Empleado_Mant();
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                        frm.ShowDialog();
                    }
                    else
                    {
                        if (MessageBox.Show("Ha Escojido no Registrar el empleado ¿Desea Excluir las marcaciones?", "Importacion de Marcaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            splashScreenManagereEspera.ShowWaitForm();
    

                            if (BusMarcaciones.GrabarDB(ListMarc, param.IdEmpresa))
                            {
                                MessageBox.Show("Las Marcaciones se Importaron Exitosamente");
                                splashScreenManagereEspera.CloseWaitForm();
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Ocurro un problema al importar las marcaciones");
                            }
                        }
                    }
                }
                else
                {
                    if (BusMarcaciones.GrabarDB(ListMarc, param.IdEmpresa))
                    {
                        MessageBox.Show("Las Marcaciones se Importaron Exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Ocurro un problema al importar las marcaciones");
                    }

                }

                splashScreenManagereEspera.CloseWaitForm();  
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void CmbDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarData();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        }; 



       


        private void gridViewMarcacionesBaseExterna_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewMarcacionesBaseExterna.GetRow(e.RowHandle) as ro_marcaciones_x_empleado_Info;
                if (data == null)
                    return;




                if (data.Si_empleadoExisteBaseVZEN == false)
                {
                    e.Appearance.ForeColor = Color.Red;
                    data.Error = "Empleado aun no Registrado en Sistema VZEN";
                    BanderaSinoCoincidenDatos = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

     
              

    }
}
