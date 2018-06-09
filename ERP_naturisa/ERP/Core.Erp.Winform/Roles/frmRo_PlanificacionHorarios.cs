
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
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Recursos.Properties;

using System.Globalization;

using System.Threading;
using DevExpress.XtraEditors;

namespace Core.Erp.Winform.Roles
{
    


    public partial class frmRo_PlanificacionHorarios : Form
    {
      frmRo_WaitForm_Espera frmEspera = new frmRo_WaitForm_Espera();

        //INFO
        BindingList<ro_horario_planificacion_Grid_Info> DataSource = new BindingList<ro_horario_planificacion_Grid_Info>();

        
        //BUS 
        ro_horario_planificacion_Bus ro_horario_planificacion_Bus = new ro_horario_planificacion_Bus();
        ro_horario_planificacion_Bus busHorario = new ro_horario_planificacion_Bus();

        private void cmb_Turno_EditValueChanged(object sender, EventArgs e) { }



        public frmRo_PlanificacionHorarios()
        {
            InitializeComponent();
            try
            {
                RolesParam = busParam.Get_List_Parametros(param.IdEmpresa).FirstOrDefault();
                    
                inicializarfiltros();
                gridControlPlanHorario.DataSource = DTgrilla;

                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;

                UC_Emp.event_cmbEmpleado_EditValueChanged += UC_Emp_event_cmbEmpleado_EditValueChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());            

            }

        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            pu_Grabar();
            this.Close();
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            pu_Grabar();
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }








   
        void UC_Emp_event_cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        {
             try
             {
                 ro_Empleado_Info info = new ro_Empleado_Info();
                 info = UC_Emp.getEmpleado();
                 if (info != null)
                 {
                     ListaEmpleados = new List<ro_Empleado_Info>();

                     ListaEmpleados.Add(info);
                 }
                 BindLista = new BindingList<ro_horario_planificacion_Grid_Info>();
                 gridControlPlanHorario.DataSource = BindLista;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
                 Log_Error_bus.Log_Error(ex.ToString());
             }
        }

   

       
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Parametros_Info RolesParam = new ro_Parametros_Info();
   



        UCRo_Empleado UC_Emp = new UCRo_Empleado();

        List<ro_Departamento_Info> ListaDepartamento = new List<ro_Departamento_Info>();
        ro_Horario_Bus busturno = new ro_Horario_Bus();
        List<ro_Horario_Info> ListaTurnos = new List<ro_Horario_Info>();
        ro_Departamento_Bus busDep = new ro_Departamento_Bus();
        List<ro_Empleado_Info> ListaEmpleados = new List<ro_Empleado_Info>();

        BindingList<ro_Empleado_Info> oListRo_Empleado_Info = new BindingList<ro_Empleado_Info>();

        DataTable DTgrilla = new DataTable();
        BindingList<ro_horario_planificacion_Grid_Info> BindLista = new BindingList<ro_horario_planificacion_Grid_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        List<ro_horario_planificacion_Grid_Info> ListaGrabar = new List<ro_horario_planificacion_Grid_Info>();

        Thread oThreadGrabar;

        void inicializarfiltros()
        {
            try
            {
                ListaEmpleados = new List<ro_Empleado_Info>();
                UC_Emp.cargaempleados(Cl_Enumeradores.eTipoFiltro.todos);
                PanelEm.Controls.Add(UC_Emp);
                tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();
                var sucursales = BusSuc.Get_List_Sucursal(param.IdEmpresa);
                if (sucursales != null || sucursales.Count > 0)
                {
                    cmb_Sucursal.Properties.DataSource = sucursales;
                    cmb_Sucursal.EditValue = sucursales[0].IdSucursal;
                   
                }



                var departamentos = busDep.Get_List_Departamento(param.IdEmpresa);
                ro_Departamento_Info todos = new ro_Departamento_Info();
                todos.IdDepartamento = 0;
                todos.de_descripcion = "Todos";
                ListaDepartamento.Add(todos);
                foreach (var item in departamentos)
                {
                    ListaDepartamento.Add(item);
                }
                cmbDepartamento.Properties.DataSource = ListaDepartamento;
                cmbDepartamento.EditValue = 0;

                ListaTurnos = busturno.Get_List_Horario(param.IdEmpresa);
                cmb_Turno.Properties.DataSource = ListaTurnos;
                cmb_turno2.DataSource = ListaTurnos;
                cmb_turno4.DataSource = ListaTurnos;
                cmb_turno5.DataSource = ListaTurnos;
                cmb_turno1.DataSource = ListaTurnos;
                


                dTPFechaFin.Value = DateTime.Now.AddDays(7);
                var x = dTPFechaFin.Value - dTPFechaIni.Value;
                dias = x.Days;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e){}

        private void mnu_salir_Click(object sender, EventArgs e)
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

     

     



     

        
        void CargaDataGrid()
        {
            try
            {
                int fila = 0;
                foreach (var item in ListaEmpleados)
                {
                    gridViewPlanHorario.AddNewRow();


                    //DataRow 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        
        
        }


        class prubMyClass
        {
            public int Empleado { get; set; }
            public DateTime dia { get; set; }
        }

        class TurnoClass {            
            public string Descripcion { get; set; }
            public decimal  IdTurno { get; set; }
        }
        
        
        private void DisenarGrid()
        {
            try
            {
                gridViewPlanHorario.Columns.Clear();
                List<TurnoClass> listaturn = new List<TurnoClass>();
                foreach (var item in ListaTurnos)
                {
                    TurnoClass info = new TurnoClass();
                    info.IdTurno = item.IdHorario;
                    info.Descripcion = item.Descripcion;
                    listaturn.Add(info);

                }
                List<prubMyClass> fechas = new List<prubMyClass>();

                TimeSpan Num = dTPFechaFin.Value - dTPFechaIni.Value;
                int columnas = 0;
                columnas = Num.Days;

                for (int i = 0; i < columnas + 1; i++)
                {
                    prubMyClass fecha = new prubMyClass();
                    fecha.dia = dTPFechaIni.Value;
                    fecha.Empleado = i;
                    fechas.Add(fecha);
                }
                int c = 0;

                //agregar columnas principales
                {
                    DevExpress.XtraGrid.Columns.GridColumn colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
                    colIdSucursal.FieldName = "IdSucursal";
                    colIdSucursal.Name = "colIdSucursal";
                    colIdSucursal.Visible = false;
                    // colIdEmpleado.VisibleIndex = 1;
                    gridViewPlanHorario.Columns.Add(colIdSucursal);

                    DevExpress.XtraGrid.Columns.GridColumn colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
                    colSucursal.FieldName = "Sucursal";
                    colSucursal.Name = "colSucursal";
                    colSucursal.Visible = true;
                    colSucursal.VisibleIndex = 1;
                    gridViewPlanHorario.Columns.Add(colSucursal);

                    DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
                    colIdEmpleado.FieldName = "IdEmpleado";
                    colIdEmpleado.Name = "colIdEmpleado";
                    colIdEmpleado.Visible = false;
                    // colIdEmpleado.VisibleIndex = 1;
                    gridViewPlanHorario.Columns.Add(colIdEmpleado);

                    DevExpress.XtraGrid.Columns.GridColumn colEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
                    colEmpleado.FieldName = "Empleado";
                    colEmpleado.Name = "colEmpleado";
                    colEmpleado.Visible = true;
                    colEmpleado.VisibleIndex = 2;
                    gridViewPlanHorario.Columns.Add(colEmpleado);

                    DevExpress.XtraGrid.Columns.GridColumn colIdTurno = new DevExpress.XtraGrid.Columns.GridColumn();
                    colIdTurno.FieldName = "IdTurno";
                    colIdTurno.Name = "colIdTurno";
                    colIdTurno.Visible = false;
                    // colIdTurno.VisibleIndex = 3;
                    gridViewPlanHorario.Columns.Add(colIdTurno);

                    DevExpress.XtraGrid.Columns.GridColumn colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
                    colTurno.FieldName = "Turno";
                    colTurno.Name = "colTurno";
                    colTurno.Visible = true;
                    colTurno.VisibleIndex = 3;
                    gridViewPlanHorario.Columns.Add(colTurno);

                }
               
               
                foreach (var item in fechas)
                {

                    DevExpress.XtraGrid.Columns.GridColumn colHorario = new DevExpress.XtraGrid.Columns.GridColumn();


                    string Dia_Semana = diacalendario(item.dia.AddDays(c));
                    //item.dia.AddDays(c).ToString("dddd", new CultureInfo("es-Ec"));
                    colHorario.FieldName = Dia_Semana;
                    colHorario.Name = "colCodigo_Producto1";
                    colHorario.Visible = true;
                    colHorario.VisibleIndex = c + 4;
                    //DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmb_turno = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
                    DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmb_turno = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
                    
                    //cmb_turno.Items.Add("HOLA");
                    //cmb_turno.Items.Add("HOLA1");
                    //cmb_turno.Items.Add("HOLA2");
                    
                    cmb_turno.DataSource = listaturn;
                    cmb_turno.ValueMember = "IdTurno";
                    cmb_turno.DisplayMember = "Descripcion";
                    
                       

                    colHorario.ColumnEdit = cmb_turno;
                    c++;
                    gridViewPlanHorario.Columns.Add(colHorario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void crearDT()
        {
            try
            {
                DTgrilla = new DataTable();
                DTgrilla.Columns.Add("IdSucursal", typeof(int));
                DTgrilla.Columns.Add("Sucursal", typeof(string));
                DTgrilla.Columns.Add("IdEmpleado", typeof(decimal));
                DTgrilla.Columns.Add("NomCompleto", typeof(string));
                DTgrilla.Columns.Add("ca_descripcion", typeof(string));
                DTgrilla.Columns.Add("Departamento", typeof(string));
                DTgrilla.Columns.Add("IdTurno", typeof(int));
                DTgrilla.Columns.Add("Turno", typeof(object));


                List<prubMyClass> fechas = new List<prubMyClass>();

                TimeSpan Num = dTPFechaFin.Value - dTPFechaIni.Value;
                int columnas = 0;
                columnas = Num.Days;

                for (int i = 0; i < columnas + 1; i++)
                {
                    prubMyClass fecha = new prubMyClass();
                    fecha.dia = dTPFechaIni.Value;
                    fecha.Empleado = i;
                    fechas.Add(fecha);
                }
                int c = 0;

                foreach (var item in fechas)
                {
                    string Dia_Semana = diacalendario(item.dia.AddDays(c));
                    DTgrilla.Columns.Add(Dia_Semana, typeof(object));
                    c++;
                }

                foreach (var item in ListaEmpleados)
                {
                    DataRow filas;
                    filas = DTgrilla.NewRow();
                    filas["IdSucursal"] = item.IdSucursal;
                    filas["Sucursal"] = item.Sucursal_Descripcion.Trim();
                    filas["IdEmpleado"] = item.IdEmpleado;
                    filas["NomCompleto"] = item.NomCompleto.Trim();
                    filas["ca_descripcion"] = item.cargo_Descripcion.Trim();
                    filas["Departamento"] = item.de_descripcion.Trim();
                    filas["IdTurno"] = 0;                  

                    DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmb_turno = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();

                    DTgrilla.Rows.Add(filas);
                    DTgrilla.AcceptChanges();
                }

                //gridViewPlanHorario.Columns[1].Visible = false;
                //gridViewPlanHorario.Columns[3].Visible = false;
                //gridViewPlanHorario.Columns[5].Visible = false;
                gridControlPlanHorario.DataSource = DTgrilla;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void DisenarGridDT()
        {
            try
            {
                gridViewPlanHorario.Columns.Clear();

                
                List<TurnoClass> listaturn = new List<TurnoClass>();
                foreach (var item in ListaTurnos)
                {
                    TurnoClass info = new TurnoClass();
                    info.IdTurno = item.IdHorario;
                    info.Descripcion = item.Descripcion;
                    listaturn.Add(info);

                }
                List<prubMyClass> fechas = new List<prubMyClass>();

                TimeSpan Num = dTPFechaFin.Value - dTPFechaIni.Value;
                int columnas = 0;
                columnas = Num.Days;

                for (int i = 0; i < columnas + 1; i++)
                {
                    prubMyClass fecha = new prubMyClass();
                    fecha.dia = dTPFechaIni.Value;
                    fecha.Empleado = i;
                    fechas.Add(fecha);
                }
                int c = 0;

                //agregar columnas principales
                {
                    DevExpress.XtraGrid.Columns.GridColumn colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
                    colIdSucursal.FieldName = "IdSucursal";
                    colIdSucursal.Name = "colIdSucursal";
                    colIdSucursal.Visible = false;
                    // colIdEmpleado.VisibleIndex = 1;
                    gridViewPlanHorario.Columns.Add(colIdSucursal);

                    DevExpress.XtraGrid.Columns.GridColumn colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
                    colSucursal.FieldName = "Sucursal";
                    colSucursal.Name = "colSucursal";
                    colSucursal.Visible = true;
                    colSucursal.VisibleIndex = 1;
                    gridViewPlanHorario.Columns.Add(colSucursal);

                    DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
                    colIdEmpleado.FieldName = "IdEmpleado";
                    colIdEmpleado.Name = "colIdEmpleado";
                    colIdEmpleado.Visible = false;
                    // colIdEmpleado.VisibleIndex = 1;
                    gridViewPlanHorario.Columns.Add(colIdEmpleado);

                    DevExpress.XtraGrid.Columns.GridColumn colEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
                    colEmpleado.FieldName = "Empleado";
                    colEmpleado.Name = "colEmpleado";
                    colEmpleado.Visible = true;
                    colEmpleado.VisibleIndex = 2;
                    gridViewPlanHorario.Columns.Add(colEmpleado);

                    DevExpress.XtraGrid.Columns.GridColumn colIdTurno = new DevExpress.XtraGrid.Columns.GridColumn();
                    colIdTurno.FieldName = "IdTurno";
                    colIdTurno.Name = "colIdTurno";
                    colIdTurno.Visible = false;
                    // colIdTurno.VisibleIndex = 3;
                    gridViewPlanHorario.Columns.Add(colIdTurno);

                    DevExpress.XtraGrid.Columns.GridColumn colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
                    colTurno.FieldName = "Turno";
                    colTurno.Name = "colTurno";
                    colTurno.Visible = true;
                    colTurno.VisibleIndex = 3;
                    gridViewPlanHorario.Columns.Add(colTurno);

                }
               
               
                foreach (var item in fechas)
                {

                    DevExpress.XtraGrid.Columns.GridColumn colHorario = new DevExpress.XtraGrid.Columns.GridColumn();


                    string Dia_Semana = diacalendario(item.dia.AddDays(c));
                    //item.dia.AddDays(c).ToString("dddd", new CultureInfo("es-Ec"));
                    colHorario.FieldName = Dia_Semana;
                    colHorario.Name = "colCodigo_Producto1";
                    colHorario.Visible = true;
                    colHorario.VisibleIndex = c + 4;
                    //DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmb_turno = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
                    DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmb_turno = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
                    
                    //cmb_turno.Items.Add("HOLA");
                    //cmb_turno.Items.Add("HOLA1");
                    //cmb_turno.Items.Add("HOLA2");
                    
                    cmb_turno.DataSource = listaturn;
                    cmb_turno.ValueMember = "IdTurno";
                    cmb_turno.DisplayMember = "Descripcion";
                    
                       

                    colHorario.ColumnEdit = cmb_turno;
                    c++;
                    gridViewPlanHorario.Columns.Add(colHorario);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void funcioncaptionvisiblecolumnas(string[] fechas, Boolean[] visibles)
        {
            try
            {
                   colIdTurnoDia0.Caption = fechas[0];
                    colIdTurnoDia1.Caption = fechas[1];
                    colIdTurnoDia2.Caption = fechas[2];
                    colIdTurnoDia3.Caption = fechas[3];
                    colIdTurnoDia4.Caption = fechas[4];
                    colIdTurnoDia5.Caption = fechas[5];
                    colIdTurnoDia6.Caption = fechas[6];
                    colIdTurnoDia7.Caption = fechas[7];
                    colIdTurnoDia8.Caption = fechas[8];
                    colIdTurnoDia9.Caption = fechas[9];
                    colIdTurnoDia10.Caption = fechas[10];
                    colIdTurnoDia11.Caption = fechas[11];
                    colIdTurnoDia12.Caption = fechas[12];
                    colIdTurnoDia13.Caption = fechas[13];
                    colIdTurnoDia14.Caption = fechas[14];
                    colIdTurnoDia15.Caption = fechas[15];
                    colIdTurnoDia16.Caption = fechas[16];
                    colIdTurnoDia17.Caption = fechas[17];
                    colIdTurnoDia18.Caption = fechas[18];
                    colIdTurnoDia19.Caption = fechas[19];
                    colIdTurnoDia20.Caption = fechas[20];
                    colIdTurnoDia21.Caption = fechas[21];
                    colIdTurnoDia22.Caption = fechas[22];
                    colIdTurnoDia23.Caption = fechas[23];
                    colIdTurnoDia24.Caption = fechas[24];
                    colIdTurnoDia25.Caption = fechas[25];
                    colIdTurnoDia26.Caption = fechas[26];
                    colIdTurnoDia27.Caption = fechas[27];
                    colIdTurnoDia28.Caption = fechas[28];
                    colIdTurnoDia29.Caption = fechas[29];
                    colIdTurnoDia30.Caption = fechas[30];
                    colIdTurnoDia31.Caption = fechas[31];


                    colIdTurnoDia0.Visible = visibles[0]; colIdTurnoDia0.VisibleIndex = (visibles[0] == true) ? 10 : -1;
                    colIdTurnoDia1.Visible = visibles[1]; colIdTurnoDia1.VisibleIndex = (visibles[1] == true) ? 11 : -1;
                    colIdTurnoDia2.Visible = visibles[2]; colIdTurnoDia2.VisibleIndex = (visibles[2] == true) ? 12 : -1;
                    colIdTurnoDia3.Visible = visibles[3]; colIdTurnoDia3.VisibleIndex = (visibles[3] == true) ? 13 : -1;
                    colIdTurnoDia4.Visible = visibles[4]; colIdTurnoDia4.VisibleIndex = (visibles[4] == true) ? 14 : -1;
                    colIdTurnoDia5.Visible = visibles[5]; colIdTurnoDia5.VisibleIndex = (visibles[5] == true) ? 15 : -1;
                    colIdTurnoDia6.Visible = visibles[6]; colIdTurnoDia6.VisibleIndex = (visibles[6] == true) ? 16 : -1;
                    colIdTurnoDia7.Visible = visibles[7]; colIdTurnoDia7.VisibleIndex = (visibles[7] == true) ? 17 : -1;
                    colIdTurnoDia8.Visible = visibles[8]; colIdTurnoDia8.VisibleIndex = (visibles[8] == true) ? 18 : -1;
                    colIdTurnoDia9.Visible = visibles[9]; colIdTurnoDia9.VisibleIndex = (visibles[9] == true) ? 19 : -1;
                    colIdTurnoDia10.Visible = visibles[10]; colIdTurnoDia10.VisibleIndex = (visibles[10] == true) ? 20 : -1;
                    colIdTurnoDia11.Visible = visibles[11]; colIdTurnoDia11.VisibleIndex = (visibles[11] == true) ? 21 : -1;
                    colIdTurnoDia12.Visible = visibles[12]; colIdTurnoDia12.VisibleIndex = (visibles[12] == true) ? 22 : -1;
                    colIdTurnoDia13.Visible = visibles[13]; colIdTurnoDia13.VisibleIndex = (visibles[13] == true) ? 23 : -1;
                    colIdTurnoDia14.Visible = visibles[14]; colIdTurnoDia14.VisibleIndex = (visibles[14] == true) ? 24 : -1;
                    colIdTurnoDia15.Visible = visibles[15]; colIdTurnoDia15.VisibleIndex = (visibles[15] == true) ? 25 : -1;
                    colIdTurnoDia16.Visible = visibles[16]; colIdTurnoDia16.VisibleIndex = (visibles[16] == true) ? 26 : -1;
                    colIdTurnoDia17.Visible = visibles[17]; colIdTurnoDia17.VisibleIndex = (visibles[17] == true) ? 27 : -1;
                    colIdTurnoDia18.Visible = visibles[18]; colIdTurnoDia18.VisibleIndex = (visibles[18] == true) ? 28 : -1;
                    colIdTurnoDia19.Visible = visibles[19]; colIdTurnoDia19.VisibleIndex = (visibles[19] == true) ? 29 : -1;
                    colIdTurnoDia20.Visible = visibles[20]; colIdTurnoDia20.VisibleIndex = (visibles[20] == true) ? 30 : -1;
                    colIdTurnoDia21.Visible = visibles[21]; colIdTurnoDia21.VisibleIndex = (visibles[21] == true) ? 31 : -1;
                    colIdTurnoDia22.Visible = visibles[22]; colIdTurnoDia22.VisibleIndex = (visibles[22] == true) ? 32 : -1;
                    colIdTurnoDia23.Visible = visibles[23]; colIdTurnoDia23.VisibleIndex = (visibles[23] == true) ? 33 : -1;
                    colIdTurnoDia24.Visible = visibles[24]; colIdTurnoDia24.VisibleIndex = (visibles[24] == true) ? 34 : -1;
                    colIdTurnoDia25.Visible = visibles[25]; colIdTurnoDia25.VisibleIndex = (visibles[25] == true) ? 35 : -1;
                    colIdTurnoDia26.Visible = visibles[26]; colIdTurnoDia26.VisibleIndex = (visibles[26] == true) ? 36 : -1;
                    colIdTurnoDia27.Visible = visibles[27]; colIdTurnoDia27.VisibleIndex = (visibles[27] == true) ? 37 : -1;
                    colIdTurnoDia28.Visible = visibles[28]; colIdTurnoDia28.VisibleIndex = (visibles[28] == true) ? 38 : -1;
                    colIdTurnoDia29.Visible = visibles[29]; colIdTurnoDia29.VisibleIndex = (visibles[29] == true) ? 39 : -1;
                    colIdTurnoDia30.Visible = visibles[30]; colIdTurnoDia30.VisibleIndex = (visibles[30] == true) ? 40 : -1;
                    colIdTurnoDia31.Visible = visibles[31]; colIdTurnoDia31.VisibleIndex = (visibles[31] == true) ? 41 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            

                         
        
        }
        private void pu_AgregarNombreCabeceraColumnas()
        {

            try
            {
                int dias = 0;
                var x = dTPFechaFin.Value - dTPFechaIni.Value;
                dias = x.Days;
                
                //validar que fecha no sea mas de 30 días
                if (dias > 31)
                {
                    MessageBox.Show("Solo se puede planificar 30 días, revise por favor","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop); 
                    dTPFechaFin.Value = dTPFechaIni.Value.AddDays(dias); 
                    return; 
                }
                
                string[] fechas;
                Boolean[] visibles;
                
                visibles = new Boolean[32];
                for (int i = 0; i < 32; i++)
                {
                    visibles[i] = false;
                }
                
                fechas = new string[32];
                gridControlPlanHorario.RefreshDataSource();
                gridControlPlanHorario.Refresh();

                funcioncaptionvisiblecolumnas(fechas, visibles);

                for (int i = 0; i <=dias; i++)
                {                    
                    fechas[i] = diacalendario(dTPFechaIni.Value.AddDays(i));
                    visibles[i] = true;
                }

                funcioncaptionvisiblecolumnas(fechas, visibles);                       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private string diacalendario(DateTime fecha)
        {
            try
            {
                var s = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar;
                string Dia_Semana = fecha.ToString("dddd", new CultureInfo("es-Ec"));
                return Dia_Semana.ToUpper().Substring(0,3) + " " + fecha.ToShortDateString();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return null;                
            }
        }
                
        private ro_horario_planificacion_Grid_Info  getarrayhorario(int[] arreglo)
        {
            ro_horario_planificacion_Grid_Info info = new ro_horario_planificacion_Grid_Info();

            try
            {
                info.IdHorarioDia0 = Convert.ToInt32(arreglo[0]);
                info.IdHorarioDia1 = Convert.ToInt32(arreglo[1]);
                info.IdHorarioDia2 = Convert.ToInt32(arreglo[2]);
                info.IdHorarioDia3 = Convert.ToInt32(arreglo[3]);
                info.IdHorarioDia4 = Convert.ToInt32(arreglo[4]);
                info.IdHorarioDia5 = Convert.ToInt32(arreglo[5]);
                info.IdHorarioDia6 = Convert.ToInt32(arreglo[1]);
                info.IdHorarioDia7 = Convert.ToInt32(arreglo[2]);
                info.IdHorarioDia8 = Convert.ToInt32(arreglo[3]);
                info.IdHorarioDia9 = Convert.ToInt32(arreglo[4]);
                info.IdHorarioDia5 = Convert.ToInt32(arreglo[5]);
                info.IdHorarioDia1 = Convert.ToInt32(arreglo[1]);
                info.IdHorarioDia2 = Convert.ToInt32(arreglo[2]);
                info.IdHorarioDia3 = Convert.ToInt32(arreglo[3]);
                info.IdHorarioDia4 = Convert.ToInt32(arreglo[4]);
                info.IdHorarioDia5 = Convert.ToInt32(arreglo[5]);
                info.IdHorarioDia1 = Convert.ToInt32(arreglo[1]);
                info.IdHorarioDia2 = Convert.ToInt32(arreglo[2]);
                info.IdHorarioDia3 = Convert.ToInt32(arreglo[3]);
                info.IdHorarioDia4 = Convert.ToInt32(arreglo[4]);
                info.IdHorarioDia5 = Convert.ToInt32(arreglo[5]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
              
                info = null;
            }
            return info;        
        }






        int i = 0;
        int dias = 0;


        private void dTPFechaIni_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                var x = dTPFechaFin.Value - dTPFechaIni.Value;
                dias = x.Days;
                           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }            
        }


        private void pu_AgregarTurno() {

            try
            {
                ro_horario_planificacion_Grid_Info item = (ro_horario_planificacion_Grid_Info)gridViewPlanHorario.GetFocusedRow();

                if (item == null)
                {
                    MessageBox.Show("Seleccione un empleado para agregar una fila adicional para turnos partidos","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                else
                {
                    if (dias < 1)
                    {
                        MessageBox.Show("Las fechas son inválidas, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    ro_horario_planificacion_Grid_Info info = new ro_horario_planificacion_Grid_Info();
                    info.NomCompleto = item.NomCompleto;
                    info.IdEmpleado = item.IdEmpleado;
                    info.Sucursal = item.Sucursal;
                    info.ca_descripcion = item.ca_descripcion;
                    info.Departamento = item.Departamento;
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdHorario =1;
                    info.secuencia = ++i;

                    for (int ix = 0; ix < dias + 1; ix++)
                    {
                        info.IdHorarioDia[ix] = 1;
                    }
                    
                    
                    DataSource.Add(info);
                    gridControlPlanHorario.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void gridViewPlanHorario_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colcheckcambiaturno")
                {
                    var reg = (ro_horario_planificacion_Grid_Info)gridViewPlanHorario.GetFocusedRow();
                    if (reg != null)
                    {
                        if (Convert.ToBoolean(e.CellValue) == false)
                        {
                            foreach (var item in DataSource)
                            {
                                if (reg.secuencia == item.secuencia)
                                {
                                    reg.checkcambiaturno = true;
                                    if (colIdTurnoDia0.Visible == true) { reg.IdHorarioDia0 = reg.IdHorario; }
                                    if (colIdTurnoDia1.Visible == true) { reg.IdHorarioDia1 = reg.IdHorario; }
                                    if (colIdTurnoDia2.Visible == true) { reg.IdHorarioDia2 = reg.IdHorario; }
                                    if (colIdTurnoDia3.Visible == true) { reg.IdHorarioDia3 = reg.IdHorario; }
                                    if (colIdTurnoDia4.Visible == true) { reg.IdHorarioDia4 = reg.IdHorario; }
                                    if (colIdTurnoDia5.Visible == true) { reg.IdHorarioDia5 = reg.IdHorario; }
                                    if (colIdTurnoDia6.Visible == true) { reg.IdHorarioDia6 = reg.IdHorario; }
                                    if (colIdTurnoDia7.Visible == true) { reg.IdHorarioDia7 = reg.IdHorario; }
                                    if (colIdTurnoDia8.Visible == true) { reg.IdHorarioDia8 = reg.IdHorario; }
                                    if (colIdTurnoDia9.Visible == true) { reg.IdHorarioDia9 = reg.IdHorario; }
                                    if (colIdTurnoDia10.Visible == true) { reg.IdHorarioDia10 = reg.IdHorario; }
                                    if (colIdTurnoDia11.Visible == true) { reg.IdHorarioDia11 = reg.IdHorario; }
                                    if (colIdTurnoDia12.Visible == true) { reg.IdHorarioDia12 = reg.IdHorario; }
                                    if (colIdTurnoDia13.Visible == true) { reg.IdHorarioDia13 = reg.IdHorario; }
                                    if (colIdTurnoDia14.Visible == true) { reg.IdHorarioDia14 = reg.IdHorario; }
                                    if (colIdTurnoDia15.Visible == true) { reg.IdHorarioDia15 = reg.IdHorario; }
                                    if (colIdTurnoDia16.Visible == true) { reg.IdHorarioDia16 = reg.IdHorario; }
                                    if (colIdTurnoDia17.Visible == true) { reg.IdHorarioDia17 = reg.IdHorario; }
                                    if (colIdTurnoDia18.Visible == true) { reg.IdHorarioDia18 = reg.IdHorario; }
                                    if (colIdTurnoDia19.Visible == true) { reg.IdHorarioDia19 = reg.IdHorario; }
                                    if (colIdTurnoDia20.Visible == true) { reg.IdHorarioDia20 = reg.IdHorario; }
                                    if (colIdTurnoDia21.Visible == true) { reg.IdHorarioDia21 = reg.IdHorario; }
                                    if (colIdTurnoDia22.Visible == true) { reg.IdHorarioDia22 = reg.IdHorario; }
                                    if (colIdTurnoDia23.Visible == true) { reg.IdHorarioDia23 = reg.IdHorario; }
                                    if (colIdTurnoDia24.Visible == true) { reg.IdHorarioDia24 = reg.IdHorario; }
                                    if (colIdTurnoDia25.Visible == true) { reg.IdHorarioDia25 = reg.IdHorario; }
                                    if (colIdTurnoDia26.Visible == true) { reg.IdHorarioDia26 = reg.IdHorario; }
                                    if (colIdTurnoDia27.Visible == true) { reg.IdHorarioDia27 = reg.IdHorario; }
                                    if (colIdTurnoDia28.Visible == true) { reg.IdHorarioDia28 = reg.IdHorario; }
                                    if (colIdTurnoDia29.Visible == true) { reg.IdHorarioDia29 = reg.IdHorario; }
                                    if (colIdTurnoDia30.Visible == true) { reg.IdHorarioDia30 = reg.IdHorario; }
                                    if (colIdTurnoDia31.Visible == true) { reg.IdHorarioDia31 = reg.IdHorario; }

                                }
                            }
                        }
                        else
                        {
                            foreach (var item in DataSource)
                            {
                                if (reg.secuencia == item.secuencia)
                                {
                                    reg.checkcambiaturno = false;
                                    if (colIdTurnoDia0.Visible == true) { reg.IdHorarioDia0 = 1; }
                                    if (colIdTurnoDia1.Visible == true) { reg.IdHorarioDia1 = 1; }
                                    if (colIdTurnoDia2.Visible == true) { reg.IdHorarioDia2 = 1; }
                                    if (colIdTurnoDia3.Visible == true) { reg.IdHorarioDia3 = 1; }
                                    if (colIdTurnoDia4.Visible == true) { reg.IdHorarioDia4 = 1; }
                                    if (colIdTurnoDia5.Visible == true) { reg.IdHorarioDia5 = 1; }
                                    if (colIdTurnoDia6.Visible == true) { reg.IdHorarioDia6 = 1; }
                                    if (colIdTurnoDia7.Visible == true) { reg.IdHorarioDia7 = 1; }
                                    if (colIdTurnoDia8.Visible == true) { reg.IdHorarioDia8 = 1; }
                                    if (colIdTurnoDia9.Visible == true) { reg.IdHorarioDia9 = 1; }
                                    if (colIdTurnoDia10.Visible == true) { reg.IdHorarioDia10 = 1; }
                                    if (colIdTurnoDia11.Visible == true) { reg.IdHorarioDia11 = 1; }
                                    if (colIdTurnoDia12.Visible == true) { reg.IdHorarioDia12 = 1; }
                                    if (colIdTurnoDia13.Visible == true) { reg.IdHorarioDia13 = 1; }
                                    if (colIdTurnoDia14.Visible == true) { reg.IdHorarioDia14 = 1; }
                                    if (colIdTurnoDia15.Visible == true) { reg.IdHorarioDia15 = 1; }
                                    if (colIdTurnoDia16.Visible == true) { reg.IdHorarioDia16 = 1; }
                                    if (colIdTurnoDia17.Visible == true) { reg.IdHorarioDia17 = 1; }
                                    if (colIdTurnoDia18.Visible == true) { reg.IdHorarioDia18 = 1; }
                                    if (colIdTurnoDia19.Visible == true) { reg.IdHorarioDia19 = 1; }
                                    if (colIdTurnoDia20.Visible == true) { reg.IdHorarioDia20 = 1; }
                                    if (colIdTurnoDia21.Visible == true) { reg.IdHorarioDia21 = 1; }
                                    if (colIdTurnoDia22.Visible == true) { reg.IdHorarioDia22 = 1; }
                                    if (colIdTurnoDia23.Visible == true) { reg.IdHorarioDia23 = 1; }
                                    if (colIdTurnoDia24.Visible == true) { reg.IdHorarioDia24 = 1; }
                                    if (colIdTurnoDia25.Visible == true) { reg.IdHorarioDia25 = 1; }
                                    if (colIdTurnoDia26.Visible == true) { reg.IdHorarioDia26 = 1; }
                                    if (colIdTurnoDia27.Visible == true) { reg.IdHorarioDia27 = 1; }
                                    if (colIdTurnoDia28.Visible == true) { reg.IdHorarioDia28 = 1; }
                                    if (colIdTurnoDia29.Visible == true) { reg.IdHorarioDia29 = 1; }
                                    if (colIdTurnoDia30.Visible == true) { reg.IdHorarioDia30 = 1; }
                                    if (colIdTurnoDia31.Visible == true) { reg.IdHorarioDia31 = 1; }

                                }
                            }
                        }
                    }
                
                    cmb_Sucursal.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        ro_Parametros_Bus busParam = new ro_Parametros_Bus();

        private Boolean getinfo()
        {
            Boolean result = false;

            try
            {
                ListaGrabar = new List<ro_horario_planificacion_Grid_Info>();
                if (DataSource.Count < 1)
                {
                    MessageBox.Show("Por favor escoja un empleado para planificar el horario");
                    return result;
                }


                foreach (var item in DataSource)
                {
                    ro_horario_planificacion_Grid_Info info = new ro_horario_planificacion_Grid_Info();
                    info = busHorario.Getarray(item.IdHorarioDia, item);
                    info.Observacion = TxtObservacion.Text;
                    info.FechaFin = dTPFechaIni.Value;
                    info.FechaFin = dTPFechaFin.Value;
                    if (cmbDepartamento.EditValue != "" && cmbDepartamento.EditValue != null)
                    {
                        info.IdDepartamento = Convert.ToInt32(cmbDepartamento.EditValue);
                    }
                    else
                    {
                        info.IdDepartamento = 0;

                    }
                    ListaGrabar.Add(info);
                }
                
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
                result = false;
            } 
            
            return result;
        }

        void ejecutar()
        {
            try
            {
               // frmEspera.ShowDialog();
                if (busHorario.GrabarDB(1, dTPFechaIni.Value, dTPFechaFin.Value, ListaGrabar))
                {
                    MessageBox.Show("La planificacion de hoarario se grabar correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo grabar la planificacion de horario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            finally
            {
              //  frmEspera.Close();

            }
        }


        public Boolean  pu_Grabar()
        {
           splashScreenManager_Espera.ShowWaitForm();
                      

            Boolean retorna = false;
            try
            {                                

                if (getinfo())
                {
                    ejecutar();
                }
                splashScreenManager_Espera.CloseWaitForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

            
            return retorna;
        }

    

        private void dTPFechaFin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var x = dTPFechaFin.Value - dTPFechaIni.Value;
                dias = x.Days;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

   

        

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
           // PbarEstado.Value = e.ProgressPercentage; //actualizamos la barra de progreso
            DateTime time = Convert.ToDateTime(e.UserState); //obtenemos información adicional si procede
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {

                }
                else if (e.Error != null)
                {
                    MessageBox.Show("Detalle Error: " + (e.Error as Exception).ToString());
                }
                else
                {
                    MessageBox.Show("Proceso completado satisfactoriamente: " + e.Result.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
           // PbarEstado.Value = 100;
        }

        private void frmRo_PlanificacionHorarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
            }
        }

        private void frmRo_PlanificacionHorarios_Load(object sender, EventArgs e)
        {

        }

        private void btn_CargarEmpleados_Click(object sender, EventArgs e)
        {
            pu_CargarEmpleado();
        }

        private void cmdAgregarTurnoAdicional_Click(object sender, EventArgs e)
        {
            pu_AgregarTurno();
        }

        private void cmb_Sucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartamento.EditValue == "")
                {
                    cmbDepartamento.EditValue = 0;
                }
                ListaEmpleados = new List<ro_Empleado_Info>();
                UC_Emp.CargaEmpleadosxDepxSuc(param.IdEmpresa, Convert.ToInt32(cmbDepartamento.EditValue), Convert.ToInt32(cmb_Sucursal.EditValue));
                ListaEmpleados = (List<ro_Empleado_Info>)UC_Emp.cmbEmpleado.Properties.DataSource;
                BindLista = new BindingList<ro_horario_planificacion_Grid_Info>();
                gridControlPlanHorario.DataSource = BindLista;
                UC_Emp.cmbEmpleado.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbDepartamento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListaEmpleados = new List<ro_Empleado_Info>();
                UC_Emp.CargaEmpleadosxDepxSuc(param.IdEmpresa, Convert.ToInt32(cmbDepartamento.EditValue), Convert.ToInt32(cmb_Sucursal.EditValue));
                ListaEmpleados = (List<ro_Empleado_Info>)UC_Emp.cmbEmpleado.Properties.DataSource;
                BindLista = new BindingList<ro_horario_planificacion_Grid_Info>();
                gridControlPlanHorario.DataSource = BindLista;
                UC_Emp.cmbEmpleado.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void pu_CambiarTurnoTodos() {
            try
            {
                //if (chkCargaTurno.Checked == true)
                //{
                    if (Convert.ToDecimal(cmb_Turno.EditValue) == 0)
                    {
                        MessageBox.Show("Elija un turno valido para asignar"); 
                        //chkCargaTurno.Checked = false;
                        return;
                    }
                    else
                    {

                        if (dias < 1)
                        {
                            MessageBox.Show("Fechas Invalidas.");
                            //chkCargaTurno.Checked = false;
                            return;
                        }


                        if (DataSource.Count < 1)
                        {
                            MessageBox.Show("Seleccione los empleados.");
                            //chkCargaTurno.Checked = false;
                            return;
                        }


                        List<ro_horario_planificacion_Grid_Info> temp = new List<ro_horario_planificacion_Grid_Info>();

                        foreach (var item in DataSource)
                        {
                            temp.Add(item);
                        }

                        temp = busHorario.setIdHorario(Convert.ToDecimal(cmb_Turno.EditValue), Convert.ToDateTime(dTPFechaIni.Value),
     
                            Convert.ToDateTime(dTPFechaFin.Value), temp);
                        DataSource = new BindingList<ro_horario_planificacion_Grid_Info>(temp);
                        gridControlPlanHorario.DataSource = DataSource;
                    }
                //}
                //else
                //{
                //    cmb_Turno.EditValue = 0;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }   
        
        }




        private void chkCargaTurno_CheckedChanged(object sender, EventArgs e)
        {
            pu_CambiarTurnoTodos();
        }


        private void pu_CargarEmpleado()
        {
            try
            {
               // splashScreenManagerEspera.ShowWaitForm();
                ListaGrabar = new List<ro_horario_planificacion_Grid_Info>();

                ro_horario_planificacion_Bus busHorario = new ro_horario_planificacion_Bus();

                foreach (var item in ListaEmpleados)
                {
                    ro_horario_planificacion_Grid_Info info = new ro_horario_planificacion_Grid_Info();
                    info.NomCompleto = item.InfoPersona.pe_nombreCompleto;
                    info.IdEmpleado = item.IdEmpleado;
                    info.Sucursal = item.Sucursal_Descripcion;
                    info.ca_descripcion = item.cargo_Descripcion;
                    info.Departamento = item.de_descripcion;
                    info.IdEmpresa = param.IdEmpresa;
                    ListaGrabar.Add(info);
                }

                pu_AgregarNombreCabeceraColumnas();


                ListaGrabar = busHorario.Get_List_horario_planificacion_Grid(Convert.ToDateTime(dTPFechaIni.Value.ToShortDateString()),
                    Convert.ToDateTime(dTPFechaFin.Value.ToShortDateString()), ListaGrabar);


                if (ListaGrabar != null)
                {
                    i = 0;
                    
                   // ListaGrabar.ForEach(var => { var.secuencia = ++i; var.IdHorario = 1; });
                    ListaGrabar.ForEach(var => { var.secuencia = ++i;  });

                    DataSource = new BindingList<ro_horario_planificacion_Grid_Info>(ListaGrabar);
                    gridControlPlanHorario.DataSource = DataSource;
                    gridViewPlanHorario.RefreshData();
                }
              //  splashScreenManagerEspera.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }            
        }

        private void cmdCambiarTurno_Click(object sender, EventArgs e)
        {
            pu_CambiarTurnoTodos();
        }

        private void pu_CambiarTurnoLinea(int idHorario) {
            try {
        
                ro_horario_planificacion_Grid_Info fila = (ro_horario_planificacion_Grid_Info)gridViewPlanHorario.GetFocusedRow();
                
                //DataSource.IndexOf(fila);

                foreach (ro_horario_planificacion_Grid_Info item in DataSource)
                {
                    if (item.IdEmpresa == fila.IdEmpresa && item.IdEmpleado == fila.IdEmpleado
                         && item.IdRegistro == fila.IdRegistro && item.secuencia==fila.secuencia)
                    {

                        for (int i = 0; i <= dias; i++)
                        {
                            item.IdHorarioDia[i] = idHorario;
                        }

                        ro_horario_planificacion_Grid_Info tmp = new ro_horario_planificacion_Grid_Info();
                   
                        item.IdHorarioDia0 = Convert.ToInt32(item.IdHorarioDia[0]);
                        item.IdHorarioDia1 = Convert.ToInt32(item.IdHorarioDia[1]);
                        item.IdHorarioDia2 = Convert.ToInt32(item.IdHorarioDia[2]);
                        item.IdHorarioDia3 = Convert.ToInt32(item.IdHorarioDia[3]);
                        item.IdHorarioDia4 = Convert.ToInt32(item.IdHorarioDia[4]);
                        item.IdHorarioDia5 = Convert.ToInt32(item.IdHorarioDia[5]);
                        item.IdHorarioDia6 = Convert.ToInt32(item.IdHorarioDia[6]);
                        item.IdHorarioDia7 = Convert.ToInt32(item.IdHorarioDia[7]);
                        item.IdHorarioDia8 = Convert.ToInt32(item.IdHorarioDia[8]);
                        item.IdHorarioDia9 = Convert.ToInt32(item.IdHorarioDia[9]);
                        item.IdHorarioDia10 = Convert.ToInt32(item.IdHorarioDia[10]);
                        item.IdHorarioDia11 = Convert.ToInt32(item.IdHorarioDia[11]);
                        item.IdHorarioDia12 = Convert.ToInt32(item.IdHorarioDia[12]);
                        item.IdHorarioDia13 = Convert.ToInt32(item.IdHorarioDia[13]);
                        item.IdHorarioDia14 = Convert.ToInt32(item.IdHorarioDia[14]);
                        item.IdHorarioDia15 = Convert.ToInt32(item.IdHorarioDia[15]);
                        item.IdHorarioDia16 = Convert.ToInt32(item.IdHorarioDia[16]);
                        item.IdHorarioDia17 = Convert.ToInt32(item.IdHorarioDia[17]);
                        item.IdHorarioDia18 = Convert.ToInt32(item.IdHorarioDia[18]);
                        item.IdHorarioDia19 = Convert.ToInt32(item.IdHorarioDia[19]);
                        item.IdHorarioDia20 = Convert.ToInt32(item.IdHorarioDia[20]);
                        item.IdHorarioDia21 = Convert.ToInt32(item.IdHorarioDia[21]);
                        item.IdHorarioDia22 = Convert.ToInt32(item.IdHorarioDia[22]);
                        item.IdHorarioDia23 = Convert.ToInt32(item.IdHorarioDia[23]);
                        item.IdHorarioDia24 = Convert.ToInt32(item.IdHorarioDia[24]);
                        item.IdHorarioDia25 = Convert.ToInt32(item.IdHorarioDia[25]);
                        item.IdHorarioDia26 = Convert.ToInt32(item.IdHorarioDia[26]);
                        item.IdHorarioDia27 = Convert.ToInt32(item.IdHorarioDia[27]);
                        item.IdHorarioDia28 = Convert.ToInt32(item.IdHorarioDia[28]);
                        item.IdHorarioDia29 = Convert.ToInt32(item.IdHorarioDia[29]);
                        item.IdHorarioDia30 = Convert.ToInt32(item.IdHorarioDia[30]);
                        item.IdHorarioDia31 = Convert.ToInt32(item.IdHorarioDia[31]);

                        break;
                    }

                }
                gridControlPlanHorario.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }


        private void cmb_turno1_EditValueChanged(object sender, EventArgs e)
        {
            try {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }

        private void gridViewPlanHorario_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridViewPlanHorario.FocusedColumn.Name == "colIdTurno1")
            {
                if(MessageBox.Show("Está seguro que desea cambiar el horario del Empleado seleccionado...?","CONFIRMACION",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
                    pu_CambiarTurnoLinea(Convert.ToInt32(e.Value));                
                }
            }
        }


        private void cmdAgregarTurno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea AGREGAR un nuevo turno al Empleado seleccionado...?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pu_AgregarTurno();
            }
            
        }


        private void gridViewPlanHorario_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "colAgregaTurno")
            {
                e.Value = "";
            }
        }

        private void gridControlPlanHorario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            { if (e.KeyCode.ToString() == "Delete")
            {

                if (MessageBox.Show("Está seguro que desea ELIMINAR el registro seleccionado...?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ro_horario_planificacion_Grid_Info fila = (ro_horario_planificacion_Grid_Info)gridViewPlanHorario.GetFocusedRow();

                    int indice = DataSource.IndexOf(fila);
                    DataSource.RemoveAt(indice);

                    gridControlPlanHorario.RefreshDataSource();
                }

            }

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
                BindLista = new BindingList<ro_horario_planificacion_Grid_Info>();
                 gridControlPlanHorario.DataSource = BindLista;
                 inicializarfiltros();
                 TxtObservacion.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       

    }
}
