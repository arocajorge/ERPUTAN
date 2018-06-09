using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Winform.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;

//HISTORICO DE VACACIONES
//DEREK MEJÍA SORIA
//ULT.MOD=13/01/2014-16/01/2014
namespace Core.Erp.Winform.Controles
{
    public partial class UCRo_Historico_Vacaciones : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        BindingList<ro_historico_vacaciones_x_empleado_Info> bHistorico = new BindingList<ro_historico_vacaciones_x_empleado_Info>();//= new BindingList<Ro_Historico_Vacaciones_Info>();
        //DEREK 16/01/2014
        public List<ro_historico_vacaciones_x_empleado_Info> RoHistoricoVacaInfoLst { get; set; }
        //
        List<ro_historico_vacaciones_x_empleado_Info> lHistorico = new List<ro_historico_vacaciones_x_empleado_Info>();
        frmRo_Consulta_Historico_vacaciones ConsultaHistorico = new frmRo_Consulta_Historico_vacaciones();
        //frmRo_Solicitud_Vacaciones_Mant frmSolicitudVacaciones = new frmRo_Solicitud_Vacaciones_Mant();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_SolicitudVacaciones_Bus busSolicitudVaca = new ro_SolicitudVacaciones_Bus();
        ro_historico_vacaciones_x_empleado_Info histoinfo = new ro_historico_vacaciones_x_empleado_Info();
        ro_Empleado_Info empinfoVaca = new ro_Empleado_Info();
        ro_historico_vacaciones_x_empleado_Info historico = new ro_historico_vacaciones_x_empleado_Info();
        int mayor6 = 0;

        //DEREK 16/01/2014
        ro_historico_vacaciones_x_empleado_Bus HistoricoVacacionesBus = new ro_historico_vacaciones_x_empleado_Bus();
        public int valortotalDiasPEndientes { get; set; }
        public int valortotalDiasTomados { get; set; }
        public int SumatotalDiasGanados { get; set; }
        //
        //DEREK 17/01/2014
        decimal IdEmpleado = 0;
        

        public UCRo_Historico_Vacaciones()
        {
            try
            {
                InitializeComponent();
                event_gridViewHistorico_CellValueChanging += UCRo_Historico_Vacaciones_event_gridViewHistorico_CellValueChanging;
                event_gridViewHistorico_CellValueChanged += UCRo_Historico_Vacaciones_event_gridViewHistorico_CellValueChanged;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());          
            }
        }

        void UCRo_Historico_Vacaciones_event_gridViewHistorico_CellValueChanged(int Cantidad)
        {
            try
            {
             
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void UCRo_Historico_Vacaciones_event_gridViewHistorico_CellValueChanging(int Cantidad)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());       
            }

        }
        

        public int Presentar(ro_Empleado_Info empinfo)
        {
            try
            {
                empinfoVaca = empinfo;
                DateTime FI = new DateTime();
                FI = Convert.ToDateTime(empinfo.em_fecha_ingreso);
                TimeSpan dias = DateTime.Now.Date - FI.Date;

                IdEmpleado = Convert.ToDecimal(empinfo.IdEmpleado);

                //if (FI.Year == DateTime.Now.Year)
                if (dias.Days < 365)
                {
                    MessageBox.Show("El empleado " + empinfo.NomCompleto + " no tiene mas de un año laborando, porque ingreso en: " + Convert.ToString(Convert.ToDateTime(empinfo.em_fecha_ingreso).ToShortDateString()), "AVISO");
                    gridControlHistorico.DataSource = new BindingList<ro_historico_vacaciones_x_empleado_Info>();
                }
                else
                {
                    //DEREK 16/01/2014
                    if (HistoricoVacacionesBus.ExisteHistoricoVaca(IdEmpleado, param.IdEmpresa) == true)
                    {
                        bHistorico = new BindingList<ro_historico_vacaciones_x_empleado_Info>();
                        List<ro_historico_vacaciones_x_empleado_Info> lst = new List<ro_historico_vacaciones_x_empleado_Info>(HistoricoVacacionesBus.ConsultarHistoricoVaca(IdEmpleado, param.IdEmpresa));
                        foreach (var item in lst)
                        {
                            item.Ico = (Bitmap)imageList1.Images[0];
                            if (item.DiasTomados > 0)
                            {
                                item.check = true;
                            }
                            else
                            {
                                item.check = false;
                            }
                            bHistorico.Add(item);
                        }
                        //gridControlHistorico.RefreshDataSource();
                        gridControlHistorico.DataSource = bHistorico;
                        RoHistoricoVacaInfoLst = new List<ro_historico_vacaciones_x_empleado_Info>(bHistorico);
                    }
                    else
                    {
                        HistoricoDeVacaciones(FI, IdEmpleado);
                        RoHistoricoVacaInfoLst = new List<ro_historico_vacaciones_x_empleado_Info>(bHistorico);
                    }
                    //
                }
                return valortotalDiasPEndientes = Convert.ToInt32(colDiasPendientes.SummaryText);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());       
                return 0;          
            }
        }

        //DEREK 11/10/2014//mod DEREK 13/10/2014//mod DEREK 16/01/2014
        void HistoricoDeVacaciones(DateTime FI,decimal IdEmpleado)
        {
            try
            {
                bHistorico = new BindingList<ro_historico_vacaciones_x_empleado_Info>();
                lHistorico = new List<ro_historico_vacaciones_x_empleado_Info>();
                //DateTime fechaIngreso = new DateTime(2011, 01, 13); 
                if (FI.Date == Convert.ToDateTime("01/01/0001"))
                {
                    MessageBox.Show("El Empleado no tiene Fecha de ingreso, vaya al mantenimiento de empleado y agreguele una Fecha nueva.","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }               
                DateTime fechaIngreso = FI;
                int anio = fechaIngreso.Year;                

                //DateTime fechaIngreso1 = fechaIngreso.AddDays(-1);
                //fechaIngreso1 = fechaIngreso1.AddYears(1);
                DateTime fechaIngreso1 = fechaIngreso;
                DateTime fechaIngreso2;
                //int a = 0;
                //mayor6 = DateTime.Now.Year - fechaIngreso.Year;
                //int cm = DateTime.Now.Month - fechaIngreso.Month;
                TimeSpan cm = DateTime.Now.Date - fechaIngreso.Date;            

                double CA = 0;
                mayor6 = 0;
                double meses = (cm.Days/31)/12;

                double x = meses -(Math.Abs(meses));

                if (x>0)
	            {
                    CA = Math.Abs(meses) + 1;
	            }
                else
	            {
                    CA = meses;
	            }

                //while (anio <= DateTime.Now.Year)
                //{
                //historico = new Ro_Historico_Vacaciones_Info();
                int contador = 0;
                for (int i = 0; i <= CA; i++)
			      {
                    historico = new ro_historico_vacaciones_x_empleado_Info();
                    fechaIngreso2 = fechaIngreso1;
                    fechaIngreso1 = fechaIngreso1.AddDays(-1);
                    fechaIngreso1 = fechaIngreso1.AddYears(1);
                    mayor6++;
                    //a++;
                    //if (a == 1)
                    if(i==0)
                    {
                        historico.Tipo = "Ingreso";
                        historico.IdEmpresa = param.IdEmpresa;
                        historico.IdEmpleado = IdEmpleado;
                        historico.FechaInicio = fechaIngreso2;
                        historico.FechaFin = fechaIngreso1;
                        historico.DiasGanados = calculoDiasGanados(historico.FechaInicio, historico.FechaFin);
                        historico.DiasTomados = busSolicitudVaca.CalculoDiasTrabajos(param.IdEmpresa, historico.FechaInicio, historico.FechaFin, IdEmpleado);
                        historico.DiasPendientes = (historico.DiasTomados == 0) ? historico.DiasGanados : (historico.DiasGanados - historico.DiasTomados);
                    }
                    else
                    {                       
                        //if (fechaIngreso2.Year == DateTime.Now.Year)
                        if (i == CA)
                        {
                            historico.Tipo = "Hoy";
                            historico.IdEmpresa = param.IdEmpresa;
                            historico.IdEmpleado = IdEmpleado;
                            historico.FechaInicio = fechaIngreso2;
                            historico.FechaFin = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            historico.DiasGanados = Math.Abs(calculoDiasGanados(historico.FechaInicio, historico.FechaFin));
                            historico.DiasTomados = busSolicitudVaca.CalculoDiasTrabajos(param.IdEmpresa, historico.FechaInicio, historico.FechaFin, IdEmpleado);
                            historico.DiasPendientes = (historico.DiasTomados == 0) ? Math.Abs(historico.DiasGanados) : (Math.Abs(historico.DiasGanados) - historico.DiasTomados);                   
                        }
                        else
                        {
                            //if (fechaIngreso2.Year < DateTime.Now.Year)
                            if (i < CA)
                            {
                                historico.Tipo = "Historico";
                                historico.IdEmpresa = param.IdEmpresa;
                                historico.IdEmpleado = IdEmpleado;
                                historico.FechaInicio = fechaIngreso2;
                                historico.FechaFin = fechaIngreso1;
                                historico.DiasGanados = calculoDiasGanados(historico.FechaInicio, historico.FechaFin);
                                historico.DiasTomados = busSolicitudVaca.CalculoDiasTrabajos(param.IdEmpresa, historico.FechaInicio, historico.FechaFin, IdEmpleado);
                                historico.DiasPendientes = (historico.DiasTomados == 0) ? historico.DiasGanados : (historico.DiasGanados - historico.DiasTomados);                             
                            }
                        }
                    }
                    contador++;
                    historico.Secuencia = contador;
                    historico.IdHis_Vacaciones = contador;
                    historico.check = false;
                    historico.Ico = (Bitmap)imageList1.Images[0];
                    lHistorico.Add(historico);
                    fechaIngreso1 = fechaIngreso1.AddDays(1);
                    anio = fechaIngreso1.Year;
                }
                
                bHistorico = new BindingList<ro_historico_vacaciones_x_empleado_Info>(lHistorico);
                gridControlHistorico.DataSource = bHistorico;                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        int calculoDiasGanados(DateTime FI, DateTime FF)
        {
            try
            {
                TimeSpan ts = FF - FI;
                int total = 0;
                decimal CALCULO = 0;
                int sumats = ts.Days + 1;
                if (sumats >= 365)
                {
                    if (mayor6 > 5)
                    {
                        total = 15;
                        for (int i = 6; i < mayor6; i++)
                        {
                            total = total + 1;
                            if (total == 30)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        total = 15;
                    }
                }
                else
                {
                    CALCULO = (ts.Days * 100) / 365;
                    CALCULO = (CALCULO * 15) / 100;
                    total = Convert.ToInt32(decimal.Round(CALCULO));
                }

                return total;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());           
                return 0;
            }

        }

        private void gridViewHistorico_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colIco")
                {
                    ConsultaHistorico = new frmRo_Consulta_Historico_vacaciones();
                    ConsultaHistorico.Consultar(empinfoVaca,histoinfo);
                    ConsultaHistorico.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewHistorico_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                histoinfo = new ro_historico_vacaciones_x_empleado_Info();
                histoinfo = (ro_historico_vacaciones_x_empleado_Info)gridViewHistorico.GetFocusedRow();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());          
            }
            
        }

        private void gridViewHistorico_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                historico = new ro_historico_vacaciones_x_empleado_Info();
                historico = (ro_historico_vacaciones_x_empleado_Info)gridViewHistorico.GetFocusedRow();

            
                List<ro_historico_vacaciones_x_empleado_Info> LST = new List<ro_historico_vacaciones_x_empleado_Info>();

                if (e.Column == colcheck && Convert.ToBoolean(e.Value) == false)
                {
                    foreach (var item in bHistorico)
                    {
                        if (item.IdHis_Vacaciones == historico.IdHis_Vacaciones)
                        {
                            item.DiasGanados = historico.DiasGanados;
                            item.DiasTomados = 0;
                            item.DiasPendientes = historico.DiasGanados - historico.DiasTomados;
                            item.check = false;
                        }
                        LST.Add(item);
                    }
                }

                if (e.Column == colcheck && Convert.ToBoolean(e.Value) == true)
                {
                    foreach (var item in bHistorico)
                    {
                        if (item.IdHis_Vacaciones == historico.IdHis_Vacaciones)
                        {
                            item.DiasGanados = historico.DiasGanados;
                            //item.DiasTomados = (historico.DiasGanados>15)?(historico.DiasGanados):15;
                            item.DiasTomados = historico.DiasGanados;
                            item.DiasPendientes = historico.DiasGanados - historico.DiasTomados;
                            item.check = true;
                        }
                        LST.Add(item);
                    }
                }
                string Diastomados = (Convert.ToString(e.Value) == "") ? "0" : Convert.ToString(e.Value);
                if (e.Column == colDiasTomados)
                {
                    foreach (var item in bHistorico)
                    {
                        if (item.IdHis_Vacaciones == historico.IdHis_Vacaciones)
                        {
                            item.DiasGanados = historico.DiasGanados;
                            //item.DiasTomados = (historico.DiasGanados>15)?(historico.DiasGanados):15;
                            item.DiasTomados = (Diastomados == "") ? 0 : Convert.ToInt32(Diastomados);
                            item.DiasPendientes = historico.DiasGanados - historico.DiasTomados;
                            item.check = true;
                        }
                        LST.Add(item);
                    }
                }
                //bHistorico = new BindingList<Ro_Historico_Vacaciones_Info>();
                //bHistorico = new BindingList<Ro_Historico_Vacaciones_Info>(LST);            
                gridControlHistorico.RefreshDataSource();

                //Valores Totales
                valortotalDiasPEndientes = Convert.ToInt32(colDiasPendientes.SummaryText);

                valortotalDiasTomados = 0;
                foreach (var item in LST)
                {
                    valortotalDiasTomados = valortotalDiasTomados + item.DiasTomados;
                }

                SumatotalDiasGanados = 0;
                foreach (var item in LST)
                {
                    SumatotalDiasGanados = SumatotalDiasGanados + item.DiasGanados;
                }
                //valortotalDiasTomados = Convert.ToInt32(colDiasTomados.SummaryText);
                //Usando delegados
                event_gridViewHistorico_CellValueChanging( SumarDiasTomados());
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());    
            }
            
        }

        public delegate void delegate_gridViewHistorico_CellValueChanging(int Cantidad);
        public event delegate_gridViewHistorico_CellValueChanging event_gridViewHistorico_CellValueChanging;

        public int SumarDiasTomados() {
            try
            {
                int totalDiasTomados = 0;
                foreach (var item in bHistorico)
                {
                    totalDiasTomados = totalDiasTomados + item.DiasTomados;
                }
                return totalDiasTomados;              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());         
                return 0;           
            }
        }

        private void gridViewHistorico_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                historico = new ro_historico_vacaciones_x_empleado_Info();
                historico = (ro_historico_vacaciones_x_empleado_Info)gridViewHistorico.GetFocusedRow();
                List<ro_historico_vacaciones_x_empleado_Info> LST = new List<ro_historico_vacaciones_x_empleado_Info>();
                if (historico.DiasTomados > historico.DiasGanados)
                {
                    MessageBox.Show("Los dias Tomados no pueden pasarse de los Dias Ganados", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (HistoricoVacacionesBus.ExisteHistoricoVaca(IdEmpleado, param.IdEmpresa) == true)
                    {
                        bHistorico = new BindingList<ro_historico_vacaciones_x_empleado_Info>();
                        List<ro_historico_vacaciones_x_empleado_Info> lst = new List<ro_historico_vacaciones_x_empleado_Info>(HistoricoVacacionesBus.ConsultarHistoricoVaca(IdEmpleado, param.IdEmpresa));
                        foreach (var item in lst)
                        {
                            item.Ico = (Bitmap)imageList1.Images[0];
                            bHistorico.Add(item);
                        }
                        //gridControlHistorico.RefreshDataSource();
                        gridControlHistorico.DataSource = bHistorico;
                        //RoHistoricoVacaInfoLst = new List<ro_historico_vacaciones_x_empleado_Info>(bHistorico);
                    }
                    else
                    {
                        foreach (var item in bHistorico)
                        {
                            if (item.IdHis_Vacaciones == historico.IdHis_Vacaciones)
                            {
                                item.DiasTomados = 0;
                                item.check = false;
                                item.DiasPendientes = item.DiasGanados;
                            }
                            LST.Add(item);
                        }
                        gridControlHistorico.RefreshDataSource();
                        //Valores Totales
                        valortotalDiasPEndientes = Convert.ToInt32(colDiasPendientes.SummaryText);

                        valortotalDiasTomados = 0;
                        foreach (var item in bHistorico)
                        {
                            valortotalDiasTomados = valortotalDiasTomados + item.DiasTomados;
                        }

                        SumatotalDiasGanados = 0;
                        foreach (var item in bHistorico)
                        {
                            SumatotalDiasGanados = SumatotalDiasGanados + item.DiasGanados;
                        }
                        event_gridViewHistorico_CellValueChanged(SumarDiasTomados());
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                              
            }
        }

        public delegate void delegate_gridViewHistorico_CellValueChanged(int Cantidad);
        public event delegate_gridViewHistorico_CellValueChanged event_gridViewHistorico_CellValueChanged;

    }
}
