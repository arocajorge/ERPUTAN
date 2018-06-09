using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

using System.IO;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt015_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; 

        public XCXC_Rpt015_frm()
        {
            InitializeComponent();
            uccxC_MenuReportes.event_btnConsultar_ItemClick += uccxC_Menu_event_btnConsultar_ItemClick;
            uccxC_MenuReportes.event_btnSalir_ItemClick += uccxC_Menu_event_btnSalir_ItemClick;
        }

        void uccxC_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void uccxC_Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ConsultarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ConsultarDatos()
        {
            try
            {
                XCXC_Rpt015_rpt Reporte = new XCXC_Rpt015_rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.IdEmpresa.Value = param.IdEmpresa;               
                Reporte.IdSucursalIni.Value = (uccxC_MenuReportes.beiSucursal.EditValue == null) ? 0 : uccxC_MenuReportes.beiSucursal.EditValue;
                Reporte.IdSucursalFin.Value = (uccxC_MenuReportes.beiSucursal.EditValue == null || Convert.ToInt32(uccxC_MenuReportes.beiSucursal.EditValue) == 0) ? 999999 : uccxC_MenuReportes.beiSucursal.EditValue;
                Reporte.p_FechaIni.Value = uccxC_MenuReportes.dtpDesde.EditValue;
                Reporte.p_FechaFin.Value = uccxC_MenuReportes.dtpHasta.EditValue;
                if (checkClientes_legales.Checked == true)
                {
                    Reporte.Clientes_legales.Value = 2;

                }
                else
                {
                    Reporte.Clientes_legales.Value = 1;
                }
                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCXC_Rpt015_frm_Load(object sender, EventArgs e)
        {
            try
            {
                checkClientes_legales.Checked = false;
                uccxC_MenuReportes.dtpDesde.EditValue = DateTime.Now.AddMonths(-1);
                uccxC_MenuReportes.dtpHasta.EditValue = DateTime.Now;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uccxC_MenuReportes_event_btnGenerar_File_txt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ConsultarDatos_para_inardap();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ConsultarDatos_para_inardap()
        {
            try
            {
                XCXC_Rpt015_Bus rptBus = new XCXC_Rpt015_Bus();
                List<XCXC_Rpt015_Info> lstRpt = new List<XCXC_Rpt015_Info>();
                ct_Periodo_Info InfoPeriodo = new ct_Periodo_Info();
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                int IdPeriodo = 0;
                string msg = "";

                IdSucursalIni = (uccxC_MenuReportes.beiSucursal.EditValue == null) ? 0 : Convert.ToInt32(uccxC_MenuReportes.beiSucursal.EditValue);
                IdSucursalFin = (uccxC_MenuReportes.beiSucursal.EditValue == null || Convert.ToInt32(uccxC_MenuReportes.beiSucursal.EditValue) == 0) ? 999999 : Convert.ToInt32(uccxC_MenuReportes.beiSucursal.EditValue);

                IdPeriodo = (Int32)uccxC_MenuReportes.bei_Periodo.EditValue;

                if (IdPeriodo == 0)
                { MessageBox.Show("el reporte para Dinardap se ejecuta por periodo seleccion un periodo"); return; }

                ct_Periodo_Bus busPeriodo = new ct_Periodo_Bus();
                InfoPeriodo = busPeriodo.Get_Info_Periodo(param.IdEmpresa, IdPeriodo, ref msg);

                lstRpt = rptBus.get_DetalleCarteraVencida(param.IdEmpresa, 0, IdSucursalIni, IdSucursalFin, InfoPeriodo.pe_FechaIni, InfoPeriodo.pe_FechaFin, 0);

                List<Dinardap_Registros_cxc_Info> ListInfoDinardap = new List<Dinardap_Registros_cxc_Info>();

                foreach (var item in lstRpt)
                {
                    Dinardap_Registros_cxc_Info InfoDinardap = new Dinardap_Registros_cxc_Info();

                    InfoDinardap.FechaDatos = InfoPeriodo.pe_FechaFin.ToString("dd/MM/yyyy");
                    switch (item.IdTipoDocumento)
                    {
                        case "CED": InfoDinardap.TipoIden = "C"; break;
                        case "PAS": InfoDinardap.TipoIden = "E"; break;
                        case "RUC": InfoDinardap.TipoIden = "R"; break;
                        default:
                            InfoDinardap.TipoIden = "C"; break;
                    }
                    InfoDinardap.Identificacion = item.pe_cedulaRuc;
                    InfoDinardap.Nom_apellido = item.pe_nombreCompleto;

                    switch (item.Naturaleza)
                    {
                        case "JURI": InfoDinardap.clase_suje = "J"; InfoDinardap.sexo = ""; InfoDinardap.estado_civil = ""; InfoDinardap.Origen_Ing = ""; break;
                        case "NATU": InfoDinardap.clase_suje = "N";
                            InfoDinardap.sexo = (item.sexo == "SEXO_MAS") ? "M" : "F";
                            InfoDinardap.Origen_Ing = "V";
                            switch (item.IdEstadoCivil)
                            {
                                case "CASAD": InfoDinardap.estado_civil = "C"; break;
                                case "DIVOR": InfoDinardap.estado_civil = "D"; break;
                                case "SOLTE": InfoDinardap.estado_civil = "S"; break;
                                case "UNILI": InfoDinardap.estado_civil = "U"; break;
                                case "VIUD": InfoDinardap.estado_civil = "V"; break;
                                default: InfoDinardap.estado_civil = "S"; break;
                            }
                            break;

                        case "OTRO": InfoDinardap.clase_suje = "N"; InfoDinardap.sexo = ""; InfoDinardap.estado_civil = ""; InfoDinardap.Origen_Ing = ""; break;
                        case "RISE": InfoDinardap.clase_suje = "N"; InfoDinardap.sexo = ""; InfoDinardap.estado_civil = ""; InfoDinardap.Origen_Ing = ""; break;
                    }


                    InfoDinardap.Provincia = item.Cod_Provincia;
                    InfoDinardap.canton = item.Cod_Ciudad;
                    InfoDinardap.parroquia = item.Cod_Parroquia;



                    InfoDinardap.num_operacion = item.vt_serie1 != null ? item.vt_serie1 + "-" + item.vt_serie2 + "-" + item.vt_NumFactura : item.CodCbteVta;

                    InfoDinardap.valor_ope = Math.Round(Math.Abs(Convert.ToDecimal(item.Valor_Original)), 2, MidpointRounding.AwayFromZero);

                    InfoDinardap.saldo_ope = Math.Abs(Convert.ToDecimal(item.Dias_Vencidos) != 0 ? Math.Round(Math.Abs(Convert.ToDecimal(item.Valor_x_Vencer)), 2, MidpointRounding.AwayFromZero) + Math.Round(Math.Abs(Convert.ToDecimal(item.Valor_cobrado)), 2, MidpointRounding.AwayFromZero) : Math.Round(Math.Abs(Convert.ToDecimal(item.Valor_x_Vencer)), 2, MidpointRounding.AwayFromZero) + Math.Round(Math.Abs(Convert.ToDecimal(item.Valor_cobrado)), 2, MidpointRounding.AwayFromZero) + Math.Round(Math.Abs(Convert.ToDecimal(item.Valor_Vencido)), 2, MidpointRounding.AwayFromZero));

                    InfoDinardap.fecha_conse = item.vt_fecha.ToString("dd/MM/yyyy");
                    InfoDinardap.fecha_vct = Convert.ToDateTime(item.vt_fech_venc).ToString("dd/MM/yyyy");
                    InfoDinardap.fecha_exigi = Convert.ToDateTime(item.vt_fech_venc).ToString("dd/MM/yyyy");

                    //
                    InfoDinardap.Plazo_op = item.Plazo;
                    InfoDinardap.Periodicidad_pago = item.Plazo;

                    if (InfoDinardap.Plazo_op <= 0) { InfoDinardap.Plazo_op = 1; }
                    if (InfoDinardap.Plazo_op > 99999) { InfoDinardap.Plazo_op = 99999; }

                    if (InfoDinardap.Periodicidad_pago <= 0) { InfoDinardap.Periodicidad_pago = 1; }
                    if (InfoDinardap.Periodicidad_pago > 99999) { InfoDinardap.Periodicidad_pago = 99999; }

                    InfoDinardap.dias_morosidad = Math.Abs(Convert.ToDecimal(item.Dias_Vencidos));
                    InfoDinardap.monto_morosidad = InfoDinardap.dias_morosidad == 0 ? 0 : Math.Round(Math.Abs(Convert.ToDecimal(item.Valor_Vencido)), 2, MidpointRounding.AwayFromZero);
                    InfoDinardap.monto_inte_mora = 0;
                    if (item.x_Vencer_1_30_Dias != 0 || item.x_Vencer_31_90_Dias != 0 || item.x_Vencer_91_180_Dias != 0 || item.x_Vencer_181_360_Dias != 0 || item.x_Vencer_Mayor_a_360Dias != 0
                        || item.Vencido_1_30_Dias != 0 || item.Vencido_31_90_Dias != 0 || item.Vencido_91_180_Dias != 0 || item.Vencido_181_360_Dias != 0 || item.Vencido_Mayor_a_360Dias != 0)
                    {
                        //VALORES POR VENCER SE DEBEN CONSIDERAR EN MORA?
                    }

                    InfoDinardap.valor_x_vencer_1_30 = Math.Round(Math.Abs(Convert.ToDecimal(item.x_Vencer_1_30_Dias)), 2, MidpointRounding.AwayFromZero);
                    InfoDinardap.valor_x_vencer_31_90 = Math.Round(Math.Abs(Convert.ToDecimal(item.x_Vencer_31_90_Dias)), 2, MidpointRounding.AwayFromZero);
                    InfoDinardap.valor_x_vencer_91_180 = Math.Round(Math.Abs(Convert.ToDecimal(item.x_Vencer_91_180_Dias)), 2, MidpointRounding.AwayFromZero);
                    InfoDinardap.valor_x_vencer_181_360 = Math.Round(Math.Abs(Convert.ToDecimal(item.x_Vencer_181_360_Dias)), 2, MidpointRounding.AwayFromZero);
                    InfoDinardap.valor_x_vencer_mas_360 = Math.Round(Math.Abs(Convert.ToDecimal(item.x_Vencer_Mayor_a_360Dias)), 2, MidpointRounding.AwayFromZero);

                    InfoDinardap.valor_vencido_1_30 = Math.Round(Math.Abs(Convert.ToDecimal(item.Vencido_1_30_Dias)), 2, MidpointRounding.AwayFromZero);
                    InfoDinardap.valor_vencido_31_90 = Math.Round(Math.Abs(Convert.ToDecimal(item.Vencido_31_90_Dias)), 2, MidpointRounding.AwayFromZero);
                    InfoDinardap.valor_vencido_91_180 = Math.Round(Math.Abs(Convert.ToDecimal(item.Vencido_91_180_Dias)), 2, MidpointRounding.AwayFromZero);
                    InfoDinardap.valor_vencido_181_360 = Math.Round(Math.Abs(Convert.ToDecimal(item.Vencido_181_360_Dias)), 2, MidpointRounding.AwayFromZero);
                    InfoDinardap.valor_vencido_mas_360 = Math.Round(Math.Abs(Convert.ToDecimal(item.Vencido_Mayor_a_360Dias)), 2, MidpointRounding.AwayFromZero);
                    InfoDinardap.valor_en_demand_judi = 0;
                    InfoDinardap.cartera_castigada = 0;
                    InfoDinardap.couta_credito = Math.Round(Math.Abs(Convert.ToDecimal(item.Valor_cobrado)), 2, MidpointRounding.AwayFromZero);
                    //Fecha de cobro
                    InfoDinardap.fecha_cancela = item.cr_fechaCobro == null || item.Total_Pagado == 0 ? "" : Convert.ToDateTime(item.cr_fechaCobro).ToString("dd/MM/yyyy");
                    InfoDinardap.forma_cance = item.cr_fechaCobro == null ? "" : "E";
                    InfoDinardap.CodEntidad = item.cod_entidad_dinardap;



                    ListInfoDinardap.Add(InfoDinardap);

                }


                if (ListInfoDinardap.Count() > 0)
                {
                    GuardarFile_txt(ListInfoDinardap, InfoPeriodo);
                }
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GuardarFile_txt(List<Dinardap_Registros_cxc_Info> lstRpt,ct_Periodo_Info infoPeriodo)
        {
            try
            {
                int col = 0;
                string sLinea = String.Empty;
                string fileName = "";
                string nombre_file = "";
                
                nombre_file = param.InfoEmpresa.em_ruc + infoPeriodo.pe_FechaFin.Day.ToString("00") + infoPeriodo.pe_FechaFin.Month.ToString("00") + infoPeriodo.pe_FechaFin.Year + ".txt";

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = nombre_file;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;


                    StreamWriter sw = new StreamWriter(fileName, false, Encoding.Default);

                    //sLinea = "\"" + "CodEntidad" + "\"" + ',' + "\"" + "FechaDatos" + "\"" + ',' + "\"" + "TipoIden" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "Identificacion" + "\"" + ',' + "\"" + "Nom_apellido" + "\"" + ',' + "\"" + "clase_suje" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "Provincia" + "\"" + ',' + "\"" + "canton" + "\"" + ',' + "\"" + "parroquia" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "sexo" + "\"" + ',' + "\"" + "estado_civil" + "\"" + ',' + "\"" + "Origen_Ing" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "num_operacion" + "\"" + ',' + "\"" + "valor_ope" + "\"" + ',' + "\"" + "saldo_ope" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "fecha_conse" + "\"" + ',' + "\"" + "fecha_vct" + "\"" + ',' + "\"" + "fecha_exigi" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "Plazo_op" + "\"" + ',' + "\"" + "Periodicidad_pago" + "\"" + ',' + "\"" + "dias_morosidad" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "monto_morosidad" + "\"" + ',' + "\"" + "monto_inte_mora" + "\"" + ',' + "\"" + "valor_x_vencer_1_30" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "valor_x_vencer_31_90" + "\"" + ',' + "\"" + "valor_x_vencer_91_180" + "\"" + ',' + "\"" + "valor_x_vencer_181_360" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "valor_x_vencer_mas_360" + "\"" + ',' + "\"" + "valor_vencido_1_30" + "\"" + ',' + "\"" + "valor_vencido_31_90" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "valor_vencido_91_180" + "\"" + ',' + "\"" + "valor_vencido_181_360" + "\"" + ',' + "\"" + "valor_vencido_mas_360" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "valor_en_demand_judi" + "\"" + ',' + "\"" + "cartera_castigada" + "\"" + ',' + "\"" + "couta_credito" + "\"" + ",";
                    //sLinea = sLinea + "\"" + "fecha_cancela" + "\"" + ',' + "\"" + "forma_cance " + "\"" ;

                    //sw.WriteLine(sLinea);



                    foreach (Dinardap_Registros_cxc_Info InfoData in lstRpt)
                    {
                        //cabecera

                        sLinea = "";

                        sLinea = InfoData.CodEntidad + "|" + InfoData.FechaDatos + "|" + InfoData.TipoIden ;
                        sLinea = sLinea + "|" + InfoData.Identificacion + "|" + InfoData.Nom_apellido + "|" + InfoData.clase_suje;
                        sLinea = sLinea + "|" + InfoData.Provincia + "|" + InfoData.canton + "|" + InfoData.parroquia;
                        sLinea = sLinea + "|" + InfoData.sexo + "|" + InfoData.estado_civil + "|" + InfoData.Origen_Ing;
                        sLinea = sLinea + "|" + InfoData.num_operacion + "|" + InfoData.valor_ope + "|" + InfoData.saldo_ope ;
                        sLinea = sLinea + "|" + InfoData.fecha_conse + "|" + InfoData.fecha_vct + "|" + InfoData.fecha_exigi ;
                        sLinea = sLinea + "|" + InfoData.Plazo_op + "|" + InfoData.Periodicidad_pago + "|" + InfoData.dias_morosidad ;
                        sLinea = sLinea + "|" + InfoData.monto_morosidad + "|" + InfoData.monto_inte_mora + "|" + InfoData.valor_x_vencer_1_30 ;
                        sLinea = sLinea + "|" + InfoData.valor_x_vencer_31_90 + "|" + InfoData.valor_x_vencer_91_180 + "|" + InfoData.valor_x_vencer_181_360;
                        sLinea = sLinea + "|" + InfoData.valor_x_vencer_mas_360 + "|" + InfoData.valor_vencido_1_30 + "|" + InfoData.valor_vencido_31_90 ;
                        sLinea = sLinea + "|" + InfoData.valor_vencido_91_180 + "|" + InfoData.valor_vencido_181_360 + "|" + InfoData.valor_vencido_mas_360;
                        sLinea = sLinea + "|" + InfoData.valor_en_demand_judi + "|" + InfoData.cartera_castigada + "|" + InfoData.couta_credito ;
                        sLinea = sLinea + "|" + InfoData.fecha_cancela + "|" + InfoData.forma_cance;


                        sw.WriteLine(sLinea);
                    }

                    sw.Close();

                }

                MessageBox.Show("Generacion de File DINARDAP ok..", param.Nombre_sistema, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
