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

using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;



using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

using Core.Erp.Business.General;


namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt011_frm : Form
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
        

        List<XCONTA_Rpt011_Info> lista = new List<XCONTA_Rpt011_Info>();
        XCONTA_Rpt011_Info Info_Fila = new XCONTA_Rpt011_Info();

        #endregion

        public XCONTA_Rpt011_frm()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            try
            {
                if (cmb_Periodo.EditValue==null)
                {
                    MessageBox.Show("Seleccione el periodo.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (cmb_Estado.SelectedItem == "")
                {
                    MessageBox.Show("Seleccione el estado financiero que desea visualizar.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;

                if (cmb_Estado.SelectedItem.ToString() == "ESTADO DE RESULTADO")
                {
                    Llamar_rpt_estado_resultado();
                }
                if (cmb_Estado.SelectedItem.ToString() == "BALANCE GENERAL")
                {
                    Llamar_rpt_balance_general();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Llamar_rpt_estado_resultado()
        {
            try
            {
                XCONTA_Rpt011_Rpt Reporte = new XCONTA_Rpt011_Rpt();
                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                int IdPunto_cargo_grupo = 0;
                int IdPunto_cargo = 0;
                ct_Periodo_Info Info_Periodo = new ct_Periodo_Info();
                
                DateTime FechaIni;
                DateTime FechaFin;

                string IdCentroCosto = "";
                string Nom_centro_Costo = "";
                string Nom_Punto_Cargo_Grupo = "";
                string Nom_Punto_Cargo = "";

                IdEmpresa = param.IdEmpresa;
                FechaIni = dtpFechaDesde.Value;
                FechaFin = dtpFechaHasta.Value;

                Info_Periodo = listPeriodo.FirstOrDefault(v => v.IdPeriodo == Convert.ToInt32(cmb_Periodo.EditValue));

                IdCentroCosto = cmb_centro_costo.EditValue == null ? "" : cmb_centro_costo.EditValue.ToString();
                Nom_centro_Costo = cmb_centro_costo.Text;
                IdNivel_a_mostrar = (int)cmb_nivel.SelectedValue;

                IdPunto_cargo_grupo = uCct_Pto_Cargo_Grupo.Get_Id_grupo();
                Nom_Punto_Cargo_Grupo = (uCct_Pto_Cargo_Grupo.Get_info_grupo() == null) ? "" : uCct_Pto_Cargo_Grupo.Get_info_grupo().nom_punto_cargo_grupo;

                IdPunto_cargo = uCct_Pto_Cargo_Grupo.Get_Id_punto_cargo();
                Nom_Punto_Cargo = (uCct_Pto_Cargo_Grupo.Get_info_punto_cargo() == null) ? "" : uCct_Pto_Cargo_Grupo.Get_info_punto_cargo().nom_punto_cargo;

                Reporte.PIdEmpresa.Value = IdEmpresa;
                Reporte.PIdPeriodo.Value = Info_Periodo.IdPeriodo;
                Reporte.PIdCentroCosto.Value = IdCentroCosto;
                Reporte.PIdNivel_a_mostrar.Value = IdNivel_a_mostrar;
                Reporte.PIdPunto_Cargo.Value = IdPunto_cargo;
                Reporte.PIdPunto_Cargo_Grupo.Value = IdPunto_cargo_grupo;
                Reporte.PMostrar_Reg_en_cero.Value = chkMostrar_Reg_Cero.Checked;
                Reporte.P_MostrarCC.Value = chkMostrar_CC.Checked;
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

        private void Llamar_rpt_balance_general()
        {
            try
            {
                XCONTA_Rpt013_rpt Reporte = new XCONTA_Rpt013_rpt();
                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                int IdPunto_cargo_grupo = 0;
                int IdPunto_cargo = 0;
                ct_Periodo_Info Info_Periodo = new ct_Periodo_Info();

                DateTime FechaIni;
                DateTime FechaFin;

                string IdCentroCosto = "";
                string Nom_centro_Costo = "";
                string Nom_Punto_Cargo_Grupo = "";
                string Nom_Punto_Cargo = "";

                IdEmpresa = param.IdEmpresa;
                FechaIni = dtpFechaDesde.Value;
                FechaFin = dtpFechaHasta.Value;

                Info_Periodo = listPeriodo.FirstOrDefault(v => v.IdPeriodo == Convert.ToInt32(cmb_Periodo.EditValue));

                IdCentroCosto = cmb_centro_costo.EditValue == null ? "" : cmb_centro_costo.EditValue.ToString();
                Nom_centro_Costo = cmb_centro_costo.Text;
                IdNivel_a_mostrar = (int)cmb_nivel.SelectedValue;

                IdPunto_cargo_grupo = uCct_Pto_Cargo_Grupo.Get_Id_grupo();
                Nom_Punto_Cargo_Grupo = (uCct_Pto_Cargo_Grupo.Get_info_grupo() == null) ? "" : uCct_Pto_Cargo_Grupo.Get_info_grupo().nom_punto_cargo_grupo;

                IdPunto_cargo = uCct_Pto_Cargo_Grupo.Get_Id_punto_cargo();
                Nom_Punto_Cargo = (uCct_Pto_Cargo_Grupo.Get_info_punto_cargo() == null) ? "" : uCct_Pto_Cargo_Grupo.Get_info_punto_cargo().nom_punto_cargo;

                Reporte.PIdEmpresa.Value = IdEmpresa;
                Reporte.PIdPeriodo.Value = Info_Periodo.IdPeriodo;
                Reporte.PIdCentroCosto.Value = IdCentroCosto;
                Reporte.PIdNivel_a_mostrar.Value = IdNivel_a_mostrar;
                Reporte.PIdPunto_Cargo.Value = IdPunto_cargo;
                Reporte.PIdPunto_Cargo_Grupo.Value = IdPunto_cargo_grupo;
                Reporte.PMostrar_Reg_en_cero.Value = chkMostrar_Reg_Cero.Checked;
                Reporte.PMostrar_CC.Value = chkMostrar_CC.Checked;

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

        private void XCONTA_Rpt011_frm_Load(object sender, EventArgs e)
        {
            cmb_Estado.SelectedItem = "ESTADO DE RESULTADO";
            carga_combos();
        }

        private void cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Periodo.EditValue != null)
                {
                    int IdPerido = Convert.ToInt32(cmb_Periodo.EditValue);
                    infoPeriodo = listPeriodo.FirstOrDefault(q => q.IdPeriodo == IdPerido);
                    if (infoPeriodo != null)
                    {
                        dtpFechaHasta.Value = infoPeriodo.pe_FechaFin;
                        dtpFechaDesde.Value = infoPeriodo.pe_FechaIni;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void carga_combos()
        {
            try
            {
                string msg = "";

                uCct_Pto_Cargo_Grupo.Cargar_combos();

                ct_Plancta_nivel_Bus BusNivel = new ct_Plancta_nivel_Bus();
                List<ct_Plancta_nivel_Info> listNiveles = new List<ct_Plancta_nivel_Info>();

                listPeriodo = busPeriodo.Get_List_PeriodoCombo(param.IdEmpresa, ref msg);
                cmb_Periodo.Properties.DataSource = listPeriodo;
                cmb_Periodo.Properties.ValueMember = "IdPeriodo";
                cmb_Periodo.Properties.DisplayMember = "nom_periodo";

                listNiveles = BusNivel.Get_list_Plancta_nivel(param.IdEmpresa);

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

                
                cmb_nivel.SelectedIndex = 4;
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
    
    }
}
