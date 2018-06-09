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
using Core.Erp.Info.General;


using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;


namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt006_frm : Form
    {

        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ct_Plancta_Bus plan_bus = new ct_Plancta_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Periodo_Bus periodo_bus = new ct_Periodo_Bus();
        List<ct_Plancta_Info> lista_planCta = new List<ct_Plancta_Info>();
        List<ct_Periodo_Info> list_Periodo = new List<ct_Periodo_Info>();



        public XCONTA_Rpt006_frm()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt006_frm_Load(object sender, EventArgs e)
        {
            cargar_combo();
            gbx_x_rango_cuentas.Dock = DockStyle.Fill;
            dtpFechaIni.Value = DateTime.Now.AddMonths(-1);
            dtpFechaFin.Value = DateTime.Now.AddMonths(1);
        }

        void cargar_combo()
        {
            try
            {
                
                lista_planCta = plan_bus.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                gridControlPlanCta.DataSource = lista_planCta;

                cmb_cuentas_inicio.Properties.DataSource = lista_planCta;
                cmb_cuentas_fin.Properties.DataSource = lista_planCta;

                cmb_Pto_Cargo_Grupo.Cargar_combos();

                ct_Centro_costo_Bus BusCentro = new ct_Centro_costo_Bus();
                List<ct_Centro_costo_Info> listCentro = new List<ct_Centro_costo_Info>();
                listCentro = BusCentro.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);

                cmb_centro_costo.Properties.DisplayMember = "Centro_costo";
                cmb_centro_costo.Properties.ValueMember = "IdCentroCosto";
                cmb_centro_costo.Properties.DataSource = listCentro;

        
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Procesar()
        {
            try
            {
             
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;
                string IdCentro_costo = "";
                string IdCtaIni = "";
                string IdCtaFin = "";
                int IdGrupo_Punto_cargo = 0;
                int IdPunto_Cargo = 0;


                List<string> listCuentas = new List<string>();


                if (rb_x_rango_cuentas.Checked)
                {
                    IdCtaIni = Convert.ToString(cmb_cuentas_inicio.EditValue);
                    IdCtaFin = Convert.ToString(cmb_cuentas_fin.EditValue);
                    List<ct_Plancta_Info> listaEncontrada = new List<ct_Plancta_Info>();

                    listaEncontrada = lista_planCta.FindAll(v => Convert.ToDecimal(v.IdCtaCble) >= Convert.ToDecimal(IdCtaIni) 
                        && Convert.ToDecimal(v.IdCtaCble) <= Convert.ToDecimal(IdCtaFin));

                    if (listaEncontrada.Count() == 0)
                    {
                        MessageBox.Show("No Existe cuentas en este rango ...");
                        return;
                    }
                    foreach (var item in listaEncontrada)
                    {
                        listCuentas.Add(item.IdCtaCble);

                    }

                }
                if (rb_x_diferentes_cuentas.Checked)
                {

                    var listCtas_Select = ((List<ct_Plancta_Info>)(gridControlPlanCta.DataSource)).FindAll(var => var.Check == true);

                    if (listCtas_Select.Count == 0)
                    {
                        MessageBox.Show("No ha seleccionado Cuentas Contables a mostrar.");
                        return;
                    }

                    foreach (var item in listCtas_Select)
                    {
                        listCuentas.Add(item.IdCtaCble);

                    }

                }
                FechaIni = dtpFechaIni.Value;
                FechaFin = dtpFechaFin.Value;

                IdGrupo_Punto_cargo = cmb_Pto_Cargo_Grupo.Get_Id_grupo();
                IdPunto_Cargo = cmb_Pto_Cargo_Grupo.Get_Id_punto_cargo();

                IdCentro_costo = cmb_centro_costo.EditValue == null ? "" : cmb_centro_costo.EditValue.ToString();

                XCONTA_Rpt006_rpt Reporte = new XCONTA_Rpt006_rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Visible_col_PuntoCargo = chkMostrar_col_Punto_Cargo.Checked;
                Reporte.Visible_col_CentroCosto = chkMostrar_col_centro_costo.Checked;


                Reporte.P_ListIdCtasCbles = listCuentas;
                Reporte.P_IdEmpresa.Value = param.IdEmpresa;
                Reporte.P_FechaIni.Value = FechaIni;
                Reporte.P_FechaFin.Value = FechaFin;
                Reporte.P_IdCtaCble.Value = "";
                Reporte.P_IdPuntoCargo.Value = IdPunto_Cargo;
                Reporte.P_IdPuntoCargo_Grupo.Value = IdGrupo_Punto_cargo;
                Reporte.P_IdCentro_Costo.Value = IdCentro_costo;
                Reporte.P_Mostrar_Asiento_cierre.Value = chk_Mostrar_Asiento_cierre.Checked;


                Reporte.ShowPreview();



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void rb_x_rango_cuentas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Mostrar_ocultar_grupos(rb_x_rango_cuentas.Checked);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        void Mostrar_ocultar_grupos(Boolean Valor)
        {
            try
            {
                gbx_x_rango_cuentas.Visible = Valor;
                gbx_x_rango_cuentas.Dock = DockStyle.Fill;

                gbx_x_cuenta.Visible = !gbx_x_rango_cuentas.Visible;
                gbx_x_cuenta.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rb_x_diferentes_cuentas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Mostrar_ocultar_grupos(rb_x_rango_cuentas.Checked);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btn_procesa_Click(object sender, EventArgs e)
        {
            try
            {
                Procesar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
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

        private void cmb_cuentas_inicio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_cuentas_fin.EditValue = cmb_cuentas_inicio.EditValue;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

    }
}
