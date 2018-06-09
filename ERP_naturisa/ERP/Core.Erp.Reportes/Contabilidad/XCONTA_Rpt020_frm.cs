using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;

using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

using Core.Erp.Business.General;


namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt020_frm : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Periodo_Bus busPeriodo = new ct_Periodo_Bus();
        List<ct_Periodo_Info> listPeriodo = new List<ct_Periodo_Info>();
        ct_Periodo_Info infoPeriodo = new ct_Periodo_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        int dia_mes = DateTime.Now.Day;
        int mes = DateTime.Now.Month;
        int año = DateTime.Now.Year;
        string nom_mes = "";

        List<XCONTA_Rpt020_Info> lista = new List<XCONTA_Rpt020_Info>();


        XCONTA_Rpt020_Info Info_Fila = new XCONTA_Rpt020_Info();
        #endregion
       
        public XCONTA_Rpt020_frm()
        {
            InitializeComponent();
        }

        void carga_combos()
        {
            try
            {
                string msg="";

                uCct_Pto_Cargo_Grupo.Cargar_combos();

                ct_Plancta_nivel_Bus BusNivel = new ct_Plancta_nivel_Bus();
                List<ct_Plancta_nivel_Info> listNiveles = new List<ct_Plancta_nivel_Info>();

                listPeriodo = busPeriodo.Get_List_PeriodoCombo(param.IdEmpresa, ref msg);
                cmb_Periodo.Properties.DataSource = listPeriodo;
                cmb_Periodo.Properties.ValueMember = "IdPeriodo";
                cmb_Periodo.Properties.DisplayMember = "nom_periodo";

                listNiveles=BusNivel.Get_list_Plancta_nivel(param.IdEmpresa);

                cmb_nivel.DisplayMember = "IdNivelCta";
                cmb_nivel.ValueMember = "IdNivelCta";
                cmb_nivel.DataSource = listNiveles;
                cmb_nivel.SelectedValue = 3;

                ct_Centro_costo_Bus BusCentro = new ct_Centro_costo_Bus();
                List<ct_Centro_costo_Info> listCentro = new List<ct_Centro_costo_Info>();
                listCentro = BusCentro.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref msg);

                cmb_centro_costo.Properties.DisplayMember = "Centro_costo";
                cmb_centro_costo.Properties.ValueMember = "IdCentroCosto"; 
                cmb_centro_costo.Properties.DataSource = listCentro;

                cmb_Mostrar_a.SelectedItem = "Mes actual";
                cmb_nivel.SelectedIndex = 5;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCONTA_Rpt020_frm_Load(object sender, EventArgs e)
        {
            try
            {
                carga_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();//Inicio splash
                            
                string msg = "";
                XCONTA_Rpt020_Bus Bus = new XCONTA_Rpt020_Bus();
                

                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                int IdPunto_cargo_grupo=0;
                int IdPunto_cargo = 0;

                DateTime FechaIni;
                DateTime FechaFin;

                string IdCentroCosto = "";
                string Nom_centro_Costo = "";
                string Nom_Punto_Cargo_Grupo="";
                string Nom_Punto_Cargo="";



                IdEmpresa = param.IdEmpresa;
                FechaIni = dtpFechaDesde.Value;
                FechaFin = dtpFechaHasta.Value;

                IdCentroCosto = cmb_centro_costo.EditValue == null ? "" : cmb_centro_costo.EditValue.ToString();
                Nom_centro_Costo = cmb_centro_costo.Text;
                IdNivel_a_mostrar = (int)cmb_nivel.SelectedValue;

                IdPunto_cargo_grupo = uCct_Pto_Cargo_Grupo.Get_Id_grupo();
                Nom_Punto_Cargo_Grupo=(uCct_Pto_Cargo_Grupo.Get_info_grupo()==null)?"": uCct_Pto_Cargo_Grupo.Get_info_grupo().nom_punto_cargo_grupo;

                IdPunto_cargo = uCct_Pto_Cargo_Grupo.Get_Id_punto_cargo();
                Nom_Punto_Cargo=(uCct_Pto_Cargo_Grupo.Get_info_punto_cargo()==null)?"": uCct_Pto_Cargo_Grupo.Get_info_punto_cargo().nom_punto_cargo;


                lista = Bus.consultar_data(IdEmpresa, FechaIni,FechaFin, IdCentroCosto, IdNivel_a_mostrar, 
                    IdPunto_cargo_grupo, IdPunto_cargo, chkMostrar_Reg_Cero.Checked,chkMostrar_CC.Checked,true,param.IdUsuario , ref msg);


                gc_balance.DataSource = lista;
                gc_balance.RefreshDataSource();
                
              

                string Titulo = "";
                Titulo = "BALANCE GENERAL \n";
                Titulo = Titulo + " " + cmb_Mostrar_a.Text + ":" + ((cmb_Mostrar_a.Text == "Por periodo") ? cmb_Periodo.Text : "") + "\n";
                Titulo = Titulo + " Desde:" + dtpFechaDesde.Value.ToShortDateString() + "  Hasta:" + dtpFechaHasta.Value.ToShortDateString() + "\n";

                if (IdCentroCosto!="")
                {
                    Titulo = Titulo + " Centro Costo:" + "[" + IdCentroCosto + "] - " + Nom_centro_Costo + "\n";
                }

                if (IdPunto_cargo_grupo>0)
                {
                    Titulo = Titulo + " Grupo:" +  Nom_Punto_Cargo_Grupo + "\n";
                }

                if (IdPunto_cargo > 0)
                {
                    Titulo = Titulo + " Punto Cargo:" + Nom_Punto_Cargo + "\n";
                }


                gw_balance_comp.ViewCaption = Titulo;
                
                splashScreenManager.CloseWaitForm();//terminar splash
            }
            catch (Exception ex)
            {
                splashScreenManager.CloseWaitForm();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Periodo.EditValue!=null)
                {
                    lista.Clear();
                    gc_balance.DataSource = lista;
                    gc_balance.RefreshDataSource();


                    int IdPerido = Convert.ToInt32(cmb_Periodo.EditValue);
                    infoPeriodo = listPeriodo.FirstOrDefault(q => q.IdPeriodo == IdPerido);
                    if (infoPeriodo!=null)
                    {
                        dtpFechaHasta.Value = infoPeriodo.pe_FechaFin;
                        dtpFechaDesde.Value = infoPeriodo.pe_FechaIni;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void cmb_Mostrar_a_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int dias_mes = 0;
                int dia_mes = DateTime.Now.Day;
                int mes = DateTime.Now.Month;
                int año = DateTime.Now.Year;
                DateTime fecha = DateTime.Now;

                lista.Clear();
                gc_balance.DataSource = lista;
                gc_balance.RefreshDataSource();

                lblPeriodo.Text = "";
                lblPeriodo.Visible = false;
                cmb_Periodo.Visible = false;
                
                switch (cmb_Mostrar_a.SelectedItem.ToString())
                {

                    case "Mes actual":
                        dias_mes = DateTime.DaysInMonth(DateTime.Now.Year, mes);
                        dtpFechaHasta.Value = DateTime.Now.AddDays(dias_mes - dia_mes);
                        dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                        break;
                    case "Mes anterior":
                        dtpFechaHasta.Value = DateTime.Now.AddDays(-dia_mes);
                        dtpFechaDesde.Value = dtpFechaHasta.Value.AddMonths(-1).AddDays(1);
                        break;
                    case "Todo el año":
                         DateTime.DaysInMonth(año, 12);
                        dtpFechaDesde.Value = Convert.ToDateTime("01/01/"+año.ToString());;
                        dtpFechaHasta.Value = Convert.ToDateTime("31/12/"+año.ToString());;
                        break;
                    case "Año pasado":
                        año = año-1;
                        dtpFechaDesde.Value = Convert.ToDateTime("01/01/"+año.ToString());;
                        dtpFechaHasta.Value = Convert.ToDateTime("31/12/" + año.ToString());
                        break;
                    case "Por periodo":
                        lblPeriodo.Text = "Periodo:";
                        lblPeriodo.Visible = true;
                        cmb_Periodo.Visible = true;
                        cmb_Periodo.EditValue = (DateTime.Now.Year * 100) + DateTime.Now.Month;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFechaCorte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dia_mes = dtpFechaHasta.Value.Day;
                mes = dtpFechaHasta.Value.Month;
                año = dtpFechaHasta.Value.Year;
                nom_mes = Get_nombre_mes(mes);

                lista.Clear();
                gc_balance.DataSource = lista;
                gc_balance.RefreshDataSource();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XCONTA_Rpt020_rpt Reporte = new XCONTA_Rpt020_rpt();


                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                int IdPunto_cargo_grupo=0;
                int IdPunto_cargo = 0;

                DateTime FechaIni;
                DateTime FechaFin;

                string IdCentroCosto = "";
                string Nom_centro_Costo = "";
                string Nom_Punto_Cargo_Grupo="";
                string Nom_Punto_Cargo="";



                IdEmpresa = param.IdEmpresa;
                FechaIni = dtpFechaDesde.Value;
                FechaFin = dtpFechaHasta.Value;

                IdCentroCosto = cmb_centro_costo.EditValue == null ? "" : cmb_centro_costo.EditValue.ToString();
                Nom_centro_Costo = cmb_centro_costo.Text;
                IdNivel_a_mostrar = (int)cmb_nivel.SelectedValue;

                IdPunto_cargo_grupo = uCct_Pto_Cargo_Grupo.Get_Id_grupo();
                Nom_Punto_Cargo_Grupo=(uCct_Pto_Cargo_Grupo.Get_info_grupo()==null)?"": uCct_Pto_Cargo_Grupo.Get_info_grupo().nom_punto_cargo_grupo;

                IdPunto_cargo = uCct_Pto_Cargo_Grupo.Get_Id_punto_cargo();
                Nom_Punto_Cargo=(uCct_Pto_Cargo_Grupo.Get_info_punto_cargo()==null)?"": uCct_Pto_Cargo_Grupo.Get_info_punto_cargo().nom_punto_cargo;


                Reporte.PIdEmpresa.Value = IdEmpresa;
                Reporte.PIdCentroCosto.Value = IdCentroCosto;
                Reporte.PFechaIni.Value = FechaIni;
                Reporte.PFechaFin.Value = FechaFin;
                Reporte.PIdNivel_a_mostrar.Value = IdNivel_a_mostrar;
                Reporte.PIdPunto_Cargo.Value = IdPunto_cargo;
                Reporte.PIdPunto_Cargo_Grupo.Value = IdPunto_cargo_grupo;
                Reporte.PMostrar_Reg_en_cero.Value = chkMostrar_Reg_Cero.Checked;
                Reporte.P_Mostrar_CC.Value = chkMostrar_CC.Checked;
                

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.ShowPreview();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeListBG_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            try
            {

                Info_Fila = new XCONTA_Rpt020_Info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lista.Clear();
                gc_balance.DataSource = lista;
                gc_balance.RefreshDataSource();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_nivel_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lista.Clear();
                gc_balance.DataSource = lista;
                gc_balance.RefreshDataSource();
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
                Info_Fila = (XCONTA_Rpt020_Info)gw_balance_comp.GetFocusedRow();

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

                        FechaIni = dtpFechaDesde.Value;
                        FechaFin = dtpFechaHasta.Value;
                       
                      
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

        private void btn_imprimir_grilla_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            gc_balance.ShowPrintPreview();

        }
      }
   }
