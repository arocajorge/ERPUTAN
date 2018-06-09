using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt022_frm : Form
    {
        public XCONTA_Rpt022_frm()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        private void XCONTA_Rpt022_frm_Load(object sender, EventArgs e)
        {
            try
            {
                uCct_Menu_Reportes1.Cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void uCct_Menu_Reportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                XCONTA_Rpt022_Rpt rpt = new XCONTA_Rpt022_Rpt();
                rpt.P_Fecha_ini.Value = uCct_Menu_Reportes1.bei_Desde.EditValue == null ? DateTime.Now : uCct_Menu_Reportes1.bei_Desde.EditValue;
                rpt.P_Fecha_ini.Visible = false;
                
                rpt.P_Fecha_fin.Value = uCct_Menu_Reportes1.bei_Hasta.EditValue == null ? DateTime.Now : uCct_Menu_Reportes1.bei_Hasta.EditValue;
                rpt.P_Fecha_fin.Visible = false;

                rpt.P_Mostrar_reg_en_cero.Value = uCct_Menu_Reportes1.bei_Check.EditValue == null ? false : uCct_Menu_Reportes1.bei_Check.EditValue;
                rpt.P_Mostrar_reg_en_cero.Visible = false;

                rpt.P_Mostrar_CC.Value = uCct_Menu_Reportes1.bei_Check2.EditValue == null ? false : uCct_Menu_Reportes1.bei_Check2.EditValue;
                rpt.P_Mostrar_CC.Visible = false;

                rpt.P_Mostrar_asiento_cierre.Value = uCct_Menu_Reportes1.bei_Check3.EditValue == null ? false : uCct_Menu_Reportes1.bei_Check3.EditValue;
                rpt.P_Mostrar_asiento_cierre.Visible = false;
                
                rpt.P_IdCentroCosto.Value = uCct_Menu_Reportes1.Get_info_Centro_costo() == null ? "" : uCct_Menu_Reportes1.Get_info_Centro_costo().IdCentroCosto;
                rpt.P_IdCentroCosto.Visible = false;

                rpt.P_IdNivel_a_mostrar.Value = uCct_Menu_Reportes1.bei_Nivel.EditValue;
                rpt.P_IdNivel_a_mostrar.Visible = false;

                rpt.P_IdPuntoCargo_grupo.Value = uCct_Menu_Reportes1.Get_info_punto_cargo_grupo() == null ? 0 : Convert.ToInt32(uCct_Menu_Reportes1.Get_info_punto_cargo_grupo().IdPunto_cargo_grupo);
                rpt.P_IdPuntoCargo_grupo.Visible = false;

                rpt.P_IdPuntoCargo.Value = 0;
                rpt.P_IdPuntoCargo.Visible = false;

                

                //ReportPrintTool pt = new ReportPrintTool(rpt);
                //printControl1.PrintingSystem = rpt.PrintingSystem;
                //rpt.RequestParameters = false;
                //rpt.CreateDocument();
                rpt.ShowPreview();                
                    splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                    splashScreenManager1.CloseWaitForm();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uCct_Menu_Reportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void uCct_Menu_Reportes1_event_btn_Mostrar_en_tabla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();//Inicio splash
                List<XCONTA_Rpt001_Info> lista = new List<XCONTA_Rpt001_Info>();
                string msg = "";
                XCONTA_Rpt001_Bus Bus = new XCONTA_Rpt001_Bus();
                bool Mostrar_reg_cero = false;
                bool Mostrar_cc = false;
                bool Considerar_asiento_cierre = false;

                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                int IdPunto_cargo_grupo = 0;
                int IdPunto_cargo = 0;

                DateTime FechaIni;
                DateTime FechaFin;

                string IdCentroCosto = "";
                string Nom_centro_Costo = "";
                string Nom_Punto_Cargo_Grupo = "";
                string Nom_Punto_Cargo = "";

                Mostrar_reg_cero = Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check.EditValue == null ? false : uCct_Menu_Reportes1.bei_Check.EditValue);
                Mostrar_cc = Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check2.EditValue == null ? false : uCct_Menu_Reportes1.bei_Check2.EditValue);
                Considerar_asiento_cierre = Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check3.EditValue == null ? false : uCct_Menu_Reportes1.bei_Check3.EditValue);

                IdEmpresa = param.IdEmpresa;
                FechaIni = uCct_Menu_Reportes1.bei_Desde.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Desde.EditValue);
                FechaFin = uCct_Menu_Reportes1.bei_Hasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Hasta.EditValue);

                IdCentroCosto = uCct_Menu_Reportes1.Get_info_Centro_costo() == null ? "" : uCct_Menu_Reportes1.Get_info_Centro_costo().IdCentroCosto;
                Nom_centro_Costo = uCct_Menu_Reportes1.Get_info_Centro_costo() == null ? "" : uCct_Menu_Reportes1.Get_info_Centro_costo().Centro_costo;
                IdNivel_a_mostrar = (int)uCct_Menu_Reportes1.bei_Nivel.EditValue;

                IdPunto_cargo_grupo = 0;
                Nom_Punto_Cargo_Grupo = uCct_Menu_Reportes1.Get_info_punto_cargo_grupo() == null ? "" : uCct_Menu_Reportes1.Get_info_punto_cargo_grupo().nom_punto_cargo_grupo;

                IdPunto_cargo = 0;
                Nom_Punto_Cargo = "";


                lista = Bus.consultar_data(IdEmpresa, FechaIni, FechaFin, IdCentroCosto, IdNivel_a_mostrar,
                    IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_cero, Mostrar_cc, Considerar_asiento_cierre, param.IdUsuario, ref msg);


                gc_balance.DataSource = lista;
                gc_balance.RefreshDataSource();



                string Titulo = "";
                Titulo = "BALANCE GENERAL \n";               
                Titulo = Titulo + " Desde:" + FechaIni.ToShortDateString() + "  Hasta:" + FechaFin.ToShortDateString() + "\n";

                if (IdCentroCosto != "")
                {
                    Titulo = Titulo + " Centro Costo:" + "[" + IdCentroCosto + "] - " + Nom_centro_Costo + "\n";
                }

                if (IdPunto_cargo_grupo > 0)
                {
                    Titulo = Titulo + " Grupo:" + Nom_Punto_Cargo_Grupo + "\n";
                }

                if (IdPunto_cargo > 0)
                {
                    Titulo = Titulo + " Punto Cargo:" + Nom_Punto_Cargo + "\n";
                }


                gw_balance_comp.ViewCaption = Titulo;

                splashScreenManager1.CloseWaitForm();//terminar splash
            }
            catch (Exception ex)
            {
                if(splashScreenManager1.IsSplashFormVisible)
                    splashScreenManager1.CloseWaitForm();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llamada_movi_x_cta(XCONTA_Rpt001_Info Info_Fila)
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

                        IdPunto_Cargo_Grupo = uCct_Menu_Reportes1.Get_info_punto_cargo_grupo() == null ? 0 : uCct_Menu_Reportes1.Get_info_punto_cargo_grupo().IdPunto_cargo_grupo;
                        IdPunto_Cargo = 0;
                        IdCentroCosto = uCct_Menu_Reportes1.Get_info_Centro_costo() == null ? "" : uCct_Menu_Reportes1.Get_info_Centro_costo().IdCentroCosto;

                        FechaIni = uCct_Menu_Reportes1.bei_Desde.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Desde.EditValue);
                        FechaFin = uCct_Menu_Reportes1.bei_Hasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Hasta.EditValue);


                        XCONTA_Rpt006_rpt Reporte = new XCONTA_Rpt006_rpt();

                        Reporte.RequestParameters = false;
                        ReportPrintTool pt = new ReportPrintTool(Reporte);
                        pt.AutoShowParametersPanel = false;

                        Reporte.Visible_col_CentroCosto = false;
                        Reporte.Visible_col_PuntoCargo = false;
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

        private void gw_balance_comp_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                XCONTA_Rpt001_Info Info_Fila = new XCONTA_Rpt001_Info();
                Info_Fila = (XCONTA_Rpt001_Info)gw_balance_comp.GetFocusedRow();

                if (col_pc_EsMovimiento.Name == e.Column.Name)
                {
                    llamada_movi_x_cta(Info_Fila);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_grilla_Click(object sender, EventArgs e)
        {
            try
            {
                gc_balance.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
