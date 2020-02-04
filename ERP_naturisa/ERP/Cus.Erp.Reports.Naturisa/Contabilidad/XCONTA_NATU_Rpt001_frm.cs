using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

namespace Cus.Erp.Reports.Naturisa.Contabilidad
{
    public partial class XCONTA_Rpt007_frm : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        ct_Periodo_Bus busPeriodo = new ct_Periodo_Bus();
        List<ct_Periodo_Info> listPeriodo = new List<ct_Periodo_Info>();
        ct_Periodo_Info infoPeriodo = new ct_Periodo_Info();

        XCONTA_Rpt007_Info Info_Fila = new XCONTA_Rpt007_Info();

        
        int dia_mes = DateTime.Now.Day;
        int mes = DateTime.Now.Month;
        int año = DateTime.Now.Year;
        string nom_mes = "";
        string msg = "";
        #endregion

        public XCONTA_Rpt007_frm()
        {
            InitializeComponent();
        }

        

        private string Get_nombre_mes(int dia)
        {
            string nombre_mes = "";
            try
            {
                switch (dia)
                {
                    case 1:
                        nombre_mes = "enero";
                        break;
                    case 2:
                        nombre_mes = "febrero";
                        break;
                    case 3:
                        nombre_mes = "marzo";
                        break;
                    case 4:
                        nombre_mes = "abril";
                        break;
                    case 5:
                        nombre_mes = "mayo";
                        break;
                    case 6:
                        nombre_mes = "junio";
                        break;
                    case 7:
                        nombre_mes = "julio";
                        break;
                    case 8:
                        nombre_mes = "agosto";
                        break;
                    case 9:
                        nombre_mes = "septiembre";
                        break;
                    case 10:
                        nombre_mes = "octubre";
                        break;
                    case 11:
                        nombre_mes = "noviembre";
                        break;
                    case 12:
                        nombre_mes = "diciembre";
                        break;
                    default:
                        break;
                }
                return nombre_mes;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();//Inicio splash
                
                XCONTA_Rpt007_Bus Bus = new XCONTA_Rpt007_Bus();
                List<XCONTA_Rpt007_Info> lista = new List<XCONTA_Rpt007_Info>();
                string IdCentroCosto = "";
                string Nom_centro_Costo = "";
                string Nom_Punto_Cargo_Grupo = "";
                string Nom_Punto_Cargo = "";
                int IdPunto_cargo_grupo = 0;
                int IdPunto_cargo = 0;


                int IdEmpresa = 0;
                DateTime FechaCorte, FechaInicio;
                

                IdEmpresa = param.IdEmpresa;
                FechaCorte = dtpFechaHasta.Value;
                FechaInicio = dt_FechaDesde.Value;

                IdPunto_cargo_grupo = uCct_Pto_Cargo_Grupo.Get_Id_grupo();
                Nom_Punto_Cargo_Grupo = (uCct_Pto_Cargo_Grupo.Get_info_grupo() == null) ? "" : uCct_Pto_Cargo_Grupo.Get_info_grupo().nom_punto_cargo_grupo;

                IdPunto_cargo = uCct_Pto_Cargo_Grupo.Get_Id_punto_cargo();
                Nom_Punto_Cargo = (uCct_Pto_Cargo_Grupo.Get_info_punto_cargo() == null) ? "" : uCct_Pto_Cargo_Grupo.Get_info_punto_cargo().nom_punto_cargo;

                IdCentroCosto = cmb_centro_costo.EditValue == null ? "" : cmb_centro_costo.EditValue.ToString();
                Nom_centro_Costo = cmb_centro_costo.Text;


                lista = Bus.Get_List_Reporte(IdEmpresa, FechaInicio, FechaCorte, IdCentroCosto, IdPunto_cargo_grupo, IdPunto_cargo, chkMostrar_Cero.Checked,chkMostrarCC.Checked);
                gc_balance_comp.DataSource = lista;

                string Titulo = "";
                Titulo = "BALANCE DE COMPROBACION  \n\n";
                Titulo = Titulo + "Desde:" +  dt_FechaDesde.Value.ToShortDateString() + " hasta: " + dtpFechaHasta.Value.ToShortDateString() + "\n\n";

                if (IdCentroCosto != "")
                {
                    Titulo = Titulo + "Centro Costo:" + "[" + IdCentroCosto + "] - " + Nom_centro_Costo + "\n\n";
                }

                if (IdPunto_cargo_grupo > 0)
                {
                    Titulo = Titulo + "Grupo:" + Nom_Punto_Cargo_Grupo + "\n\n";
                }

                if (IdPunto_cargo > 0)
                {
                    Titulo = Titulo + "Punto Cargo:" + Nom_Punto_Cargo + "\n\n";
                }


                gw_balance_comp.ViewCaption = Titulo;

                splashScreenManager.CloseWaitForm();//terminar splash

            }
           
            catch (Exception ex)
            {
                splashScreenManager.CloseWaitForm();

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmb_Periodo_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //try
            //{
            //   var item = (List<ct_Periodo_Info>)cmb_Periodo.Properties.DataSource;
            //   info = item.FirstOrDefault(q => q.IdPeriodo == Convert.ToInt32(cmb_Periodo.EditValue));

            //   lblFechaIni.Text = Convert.ToString(info.pe_FechaIni.ToShortDateString());
            //   lblFechaFin.Text = Convert.ToString(info.pe_FechaFin.ToShortDateString());
            //}
            //catch (Exception ex)
            //{


            //}

        }
       

        private void dtpFechaCorte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dia_mes = dtpFechaHasta.Value.Day;
                mes = dtpFechaHasta.Value.Month;
                año = dtpFechaHasta.Value.Year;
                nom_mes = Get_nombre_mes(mes);
                gw_balance_comp.ViewCaption = "Balance de Comprobación";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                XCONTA_Rpt007_Rpt Reporte = new XCONTA_Rpt007_Rpt();


                int IdEmpresa = 0;
                //int IdNivel_a_mostrar = 0;
                int IdPunto_cargo_grupo = 0;
                int IdPunto_cargo = 0;

                DateTime FechaIni;
                DateTime FechaFin;

                string IdCentroCosto = "";
                string Nom_centro_Costo = "";
                string Nom_Punto_Cargo_Grupo = "";
                string Nom_Punto_Cargo = "";



                IdEmpresa = param.IdEmpresa;
                FechaIni = dt_FechaDesde.Value;
                FechaFin = dtpFechaHasta.Value;

                IdCentroCosto = cmb_centro_costo.EditValue == null ? "" : cmb_centro_costo.EditValue.ToString();
                Nom_centro_Costo = cmb_centro_costo.Text;
                //IdNivel_a_mostrar = (int)cmb_nivel.SelectedValue;

                IdPunto_cargo_grupo = uCct_Pto_Cargo_Grupo.Get_Id_grupo();
                Nom_Punto_Cargo_Grupo = (uCct_Pto_Cargo_Grupo.Get_info_grupo() == null) ? "" : uCct_Pto_Cargo_Grupo.Get_info_grupo().nom_punto_cargo_grupo;

                IdPunto_cargo = uCct_Pto_Cargo_Grupo.Get_Id_punto_cargo();
                Nom_Punto_Cargo = (uCct_Pto_Cargo_Grupo.Get_info_punto_cargo() == null) ? "" : uCct_Pto_Cargo_Grupo.Get_info_punto_cargo().nom_punto_cargo;


                Reporte.PIdEmpresa.Value = IdEmpresa;
                Reporte.PIdCentroCosto.Value = IdCentroCosto;
                Reporte.PFechaIni.Value = FechaIni;
                Reporte.PFechaFin.Value = FechaFin;
                Reporte.PIdPunto_Cargo.Value = IdPunto_cargo;
                Reporte.PIdPunto_Cargo_Grupo.Value = IdPunto_cargo_grupo;
                Reporte.PMostrar_Reg_en_cero.Value = chkMostrar_Cero.Checked;



                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.ShowPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gw_balance_comp_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Info_Fila = (XCONTA_Rpt007_Info)gw_balance_comp.GetFocusedRow();

                if (col_pc_EsMovimiento.Name == e.Column.Name)
                {
                    llamada_movi_x_cta();

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCONTA_Rpt007_frm_Load(object sender, EventArgs e)
        {
            try
            {

                ct_Plancta_nivel_Bus BusNivel = new ct_Plancta_nivel_Bus();
                List<ct_Plancta_nivel_Info> listNiveles = new List<ct_Plancta_nivel_Info>();

                ct_Centro_costo_Bus BusCentro = new ct_Centro_costo_Bus();
                List<ct_Centro_costo_Info> listCentro = new List<ct_Centro_costo_Info>();
                listCentro = BusCentro.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref msg);

                cmb_centro_costo.Properties.DisplayMember = "Centro_costo";
                cmb_centro_costo.Properties.ValueMember = "IdCentroCosto";
                cmb_centro_costo.Properties.DataSource = listCentro;
                uCct_Pto_Cargo_Grupo.Cargar_combos();


                //listNiveles = BusNivel.Get_list_Plancta_nivel(param.IdEmpresa);

                //cmb_nivel.DisplayMember = "IdNivelCta";
                //cmb_nivel.ValueMember = "IdNivelCta";
                //cmb_nivel.DataSource = listNiveles;
                //cmb_nivel.SelectedValue = 3;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void llamada_movi_x_cta()
        {
            try
            {

                if (Info_Fila != null)
                {
                    if (Info_Fila.pc_EsMovimiento == "S")
                    {
                        DateTime FechaIni = DateTime.Now;
                        DateTime FechaFin = DateTime.Now;


                        int IdPunto_Cargo_Grupo = 0;
                        int IdPunto_Cargo = 0;
                        string IdCentroCosto = "";


                        IdPunto_Cargo_Grupo = uCct_Pto_Cargo_Grupo.Get_Id_grupo();
                        IdPunto_Cargo = uCct_Pto_Cargo_Grupo.Get_Id_punto_cargo();
                        IdCentroCosto = cmb_centro_costo.EditValue == null ? "" : cmb_centro_costo.EditValue.ToString();

                        FechaIni = dt_FechaDesde.Value.Date;
                        FechaFin = dtpFechaHasta.Value.Date;


                        XCONTA_Rpt006_rpt Reporte = new XCONTA_Rpt006_rpt();

                        Reporte.RequestParameters = false;
                        ReportPrintTool pt = new ReportPrintTool(Reporte);
                        pt.AutoShowParametersPanel = false;

                        Reporte.P_IdEmpresa.Value = param.IdEmpresa;
                        Reporte.P_FechaIni.Value = FechaIni;
                        Reporte.P_FechaFin.Value = FechaFin;
                        Reporte.P_IdCtaCble.Value = Info_Fila.IdCtaCble;
                        Reporte.P_IdPuntoCargo.Value = IdPunto_Cargo;
                        Reporte.P_IdPuntoCargo_Grupo.Value = IdPunto_Cargo_Grupo;
                        Reporte.P_IdCentro_Costo.Value = IdCentroCosto;

                        Reporte.ShowPreview();

                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
