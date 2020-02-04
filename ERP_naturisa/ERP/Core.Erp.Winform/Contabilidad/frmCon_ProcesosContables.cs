using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;

using System.Threading;



namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_ProcesosContables : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";

        enum TipoProceso
        {
            Mayorizar = 1,
            CierrePerido = 2,
            Reverso = 3
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string Mensaje = "";
        ct_Periodo_Bus PeB = new ct_Periodo_Bus();
        List<ct_Periodo_Info> ListaPeriodos = new List<ct_Periodo_Info>();
                ct_Periodo_Info periodoSelect = new ct_Periodo_Info();
        ct_Periodo_Info UltperiodoxAnioActual = new ct_Periodo_Info();
        ct_AnioFiscal_Info AnioActual = new ct_AnioFiscal_Info();
        Thread oThreadMayorizar;
        Thread oThreadReverso;
        Thread oThreadCierre;

        public frmCon_ProcesosContables()
        {
            try
            {
                IniciarListPeriodo();
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }



        }

        private void IniciarListPeriodo()
        {
            try
            {
                ListaPeriodos = PeB.Get_List_PeriodoCombo(param.IdEmpresa,ref MensajeError);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void EstadoBotones(TipoProceso TipoProceso)
        {
            try
            {
                if (TipoProceso == frmCon_ProcesosContables.TipoProceso.Mayorizar)
                {
                    btn_mayorizar.Enabled = true;
                    btn_cierre.Enabled = false;
                    btn_ReversoMayo.Enabled = true;
                }

                if (TipoProceso == frmCon_ProcesosContables.TipoProceso.CierrePerido)
                {
                    btn_mayorizar.Enabled = false;
                    btn_cierre.Enabled = true;
                    btn_ReversoMayo.Enabled = false;
                }

                if (TipoProceso == frmCon_ProcesosContables.TipoProceso.Reverso)
                {
                    btn_mayorizar.Enabled = true;
                    btn_cierre.Enabled = false;
                    btn_ReversoMayo.Enabled = true;
                }
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_ProcesosContables_Load(object sender, EventArgs e)
        {
            try
            {
                EstadoBotones(TipoProceso.Mayorizar);
                CargaAnioFiscal();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void CalcularUltimoPeriodoxAnioActual()
        {
            try
            {

                var UltPerxAnioActuAux = from per in ListaPeriodos
                                         where per.IdEmpresa == periodoSelect.IdEmpresa
                                         && per.IdanioFiscal == periodoSelect.IdanioFiscal
                                         group per by new { per.IdEmpresa, per.IdanioFiscal }
                                             into grouping
                                             select new { grouping.Key, UltiPeriodo = grouping.Max(p => p.IdPeriodo) };


                foreach (var item in UltPerxAnioActuAux)
                {
                    var UltPerxAnioActu = from per in ListaPeriodos
                                          where per.IdEmpresa == item.Key.IdEmpresa
                                          && per.IdanioFiscal == item.Key.IdanioFiscal
                                          && per.IdPeriodo == item.UltiPeriodo
                                          select per;

                    foreach (var item2 in UltPerxAnioActu)
                    {
                        UltperiodoxAnioActual.IdPeriodo = item2.IdPeriodo;
                        UltperiodoxAnioActual.IdanioFiscal = item2.IdanioFiscal;
                        UltperiodoxAnioActual.IdEmpresa = item2.IdEmpresa;
                        UltperiodoxAnioActual.pe_cerrado = item2.pe_cerrado;
                        UltperiodoxAnioActual.pe_estado = item2.pe_estado;
                        UltperiodoxAnioActual.pe_FechaFin = item2.pe_FechaFin;
                        UltperiodoxAnioActual.pe_FechaIni = item2.pe_FechaIni;

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }
        
        private void cmb_anioF_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AnioActual = (ct_AnioFiscal_Info)cmb_anioF.SelectedItem;


                CargaPeridosxAnio(AnioActual);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void CargaAnioFiscal()
        {
            try
            {
                List<ct_AnioFiscal_Info> listAnioF = new List<ct_AnioFiscal_Info>();
                    try
                    {
                        var Listanios = from per in ListaPeriodos
                                        where per.IdEmpresa == param.IdEmpresa
                                        && per.pe_cerrado == "N"
                                        orderby per.IdanioFiscal
                                        group per by new { per.IdEmpresa, per.IdanioFiscal }
                                            into grouping
                                            select new { grouping.Key };

                        foreach (var item in Listanios)
                        {
                            ct_AnioFiscal_Info oanio = new ct_AnioFiscal_Info();
                            oanio.IdanioFiscal = item.Key.IdanioFiscal;
                            listAnioF.Add(oanio);
                        }
                    }
                    catch (Exception ex)
                    { Log_Error_bus.Log_Error(ex.ToString()); }


                    cmb_anioF.DataSource = listAnioF;
                    cmb_anioF.DisplayMember = "IdanioFiscal";
                    cmb_anioF.ValueMember = "IdanioFiscal";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }           
        }

        private void CargaPeridosxAnio(ct_AnioFiscal_Info aniof)
        {
            try
            {
                var VPeriodos = from per in ListaPeriodos
                                where per.IdEmpresa == param.IdEmpresa
                                && per.IdanioFiscal == aniof.IdanioFiscal
                                && per.pe_cerrado == "N"
                                orderby per.IdPeriodo
                                select per;

                List<ct_Periodo_Info> liP = new List<ct_Periodo_Info>();

                foreach (var item in VPeriodos)
                {
                    ct_Periodo_Info pe = new ct_Periodo_Info();
                    pe.IdEmpresa = item.IdEmpresa;
                    pe.IdanioFiscal = item.IdanioFiscal;
                    pe.IdPeriodo = item.IdPeriodo;
                    pe.pe_cerrado = item.pe_cerrado;
                    pe.pe_estado = item.pe_estado;
                    pe.pe_FechaIni = item.pe_FechaIni;
                    pe.pe_FechaFin = item.pe_FechaFin;
                    pe.nom_periodo = item.nom_periodo;
                    pe.pe_mes = item.pe_mes;
                    liP.Add(pe);
                }

                
                cmb_periodo.DataSource = liP;                
                cmb_periodo.DisplayMember = "nom_periodo";
                cmb_periodo.ValueMember = "IdPeriodo";
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_periodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ct_Periodo_Info oPeriO = (ct_Periodo_Info)cmb_periodo.SelectedItem;
                periodoSelect = oPeriO;
                lblFechaIni.Text = oPeriO.pe_FechaIni.ToShortDateString();
                lblfechaFin.Text = oPeriO.pe_FechaFin.ToShortDateString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DateTime start = DateTime.Now;
                e.Result = "";
                for (int i = 0; i <= 100; i++)
                {
                    if (i == 100) { i = 0; }


                    System.Threading.Thread.Sleep(50); //simulamos trabajo

                    backgroundWorker.ReportProgress(i, DateTime.Now);

                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                TimeSpan duration = DateTime.Now - start;

                e.Result = "Duration: " + duration.TotalMilliseconds.ToString() + " ms.";
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                PbarEstado.EditValue = e.ProgressPercentage; //actualizamos la barra de progreso
                DateTime time = Convert.ToDateTime(e.UserState); //obtenemos información adicional si procede
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PbarEstado.EditValue = 100;
        }

        private void TimerMayorizacion_Tick(object sender, EventArgs e)
        {
            try
            {
                if (oThreadMayorizar.IsAlive == false) //esta ejecutandoce
                {
                    backgroundWorker.CancelAsync();
                    TimerMayorizacion.Enabled = false;
                    PbarEstado.EditValue = 100;
                    MessageBox.Show(Mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimerReverso_Tick(object sender, EventArgs e)
        {
            try
            {
                if (oThreadReverso.IsAlive == false) //esta ejecutandoce
                {
                    backgroundWorker.CancelAsync();
                    TimerReverso.Enabled = false;
                    PbarEstado.EditValue = 100;


                    IniciarListPeriodo();
                    CargaAnioFiscal();
                    CargaPeridosxAnio(AnioActual);

                    MessageBox.Show(Mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimerCierre_Tick(object sender, EventArgs e)
        {
            try
            {
                if (oThreadCierre.IsAlive == false) //esta ejecutandoce
                {
                    backgroundWorker.CancelAsync();
                    TimerCierre.Enabled = false;
                    PbarEstado.EditValue = 100;
                    IniciarListPeriodo();
                    CargaAnioFiscal();
                    CargaPeridosxAnio(AnioActual);

                    MessageBox.Show(Mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_mayorizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                PbarEstado.EditValue = 0;
                periodoSelect = (ct_Periodo_Info)cmb_periodo.SelectedItem;

                if (periodoSelect == null)
                {
                    return;
                }


                EstadoBotones(TipoProceso.CierrePerido);


                TimerMayorizacion.Enabled = true;
                backgroundWorker.RunWorkerAsync();
                Mensaje = "Proceso de Mayorizacion Generado Ok...";

                ct_ProcesosContables_Bus ProceMayoB = new ct_ProcesosContables_Bus(periodoSelect);
                //oThreadMayorizar = new Thread(new ThreadStart(ProceMayoB.Mayorizar));

                oThreadMayorizar.Start();
                Thread.Sleep(1);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_cierre_Click_1(object sender, EventArgs e)
        {
            try
            {
                EstadoBotones(TipoProceso.Mayorizar);
                periodoSelect = (ct_Periodo_Info)cmb_periodo.SelectedItem;

                if (periodoSelect == null)
                {
                    return;
                }



                TimerCierre.Enabled = true;
                backgroundWorker.RunWorkerAsync();
                Mensaje = "Proceso de Cierre Generado Ok...";

                ct_ProcesosContables_Bus ProceMayoB = new ct_ProcesosContables_Bus(periodoSelect);
                //oThreadCierre = new Thread(new ThreadStart(ProceMayoB.CierreMensual));

                oThreadCierre.Start();
                Thread.Sleep(1);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ReversoMayo_Click_1(object sender, EventArgs e)
        {
            try
            {
                EstadoBotones(TipoProceso.Reverso);

                periodoSelect = (ct_Periodo_Info)cmb_periodo.SelectedItem;

                if (periodoSelect == null)
                {
                    return;
                }


                TimerReverso.Enabled = true;
                backgroundWorker.RunWorkerAsync();
                Mensaje = "Proceso de Reverso de Mayorizacion Generado Ok...";

                ct_ProcesosContables_Bus ProceMayoB = new ct_ProcesosContables_Bus(periodoSelect);
                //oThreadReverso = new Thread(new ThreadStart(ProceMayoB.ReversoMayorizar));

                oThreadReverso.Start();
                Thread.Sleep(1);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EstadoBotones(TipoProceso.Mayorizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
