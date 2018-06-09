using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Reportes.CuentasxCobrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cus.Erp.Reports.Naturisa.CuentasxCobrar
{
    public partial class XCXC_NATU_Rpt001_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<XCXC_NATU_Rpt001_Info> Lista_rpt = new List<XCXC_NATU_Rpt001_Info>();
        XCXC_NATU_Rpt001_Bus bus_rpt = new XCXC_NATU_Rpt001_Bus();

        public XCXC_NATU_Rpt001_frm()
        {
            InitializeComponent();
        }

        private void uccxC_MenuReportes1_event_btnGenerar_File_txt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //string conv_num = "";

                ct_Periodo_Bus busPeriodo = new ct_Periodo_Bus();
                Lista_rpt = bus_rpt.Get_list(param.IdEmpresa, Convert.ToDateTime(uccxC_MenuReportes1.dtpDesde.EditValue), Convert.ToDateTime(uccxC_MenuReportes1.dtpHasta.EditValue));
                gridControlDinardap.DataSource = Lista_rpt;
                List<Dinardap_Registros_cxc_Info> ListInfoDinardap = new List<Dinardap_Registros_cxc_Info>();

                foreach (var item in Lista_rpt)
                {
                    Dinardap_Registros_cxc_Info InfoDinardap = new Dinardap_Registros_cxc_Info();

                    InfoDinardap.FechaDatos = Convert.ToDateTime(uccxC_MenuReportes1.dtpHasta.EditValue).ToString("dd/MM/yyyy");

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

                    switch (item.pe_Naturaleza)
                    {
                        case "JURI": InfoDinardap.clase_suje = "J"; InfoDinardap.sexo = ""; InfoDinardap.estado_civil = ""; InfoDinardap.Origen_Ing = ""; break;
                        case "NATU": InfoDinardap.clase_suje = "N";
                            InfoDinardap.sexo = (item.pe_sexo == "SEXO_MAS") ? "M" : "F";
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
                    InfoDinardap.parroquia = item.cod_parroquia;

                    InfoDinardap.num_operacion = item.num_factura;

                    InfoDinardap.valor_ope = Math.Round(Math.Abs(Convert.ToDecimal(item.Valor_operacion)), 2, MidpointRounding.AwayFromZero);
                    //conv_num = string.Format("{0:f2}", InfoDinardap.valor_ope);
                    //InfoDinardap.valor_ope = string.Format("{0:f2}", InfoDinardap.valor_ope);
                    //InfoDinardap.valor_ope = Convert.ToDecimal(conv_num);

                    InfoDinardap.saldo_ope = 0;

                    InfoDinardap.fecha_conse = item.vt_fecha.ToString("dd/MM/yyyy");
                    InfoDinardap.fecha_vct = item.vt_fecha.ToString("dd/MM/yyyy");
                    InfoDinardap.fecha_exigi = item.vt_fecha.ToString("dd/MM/yyyy");

                    InfoDinardap.Plazo_op = 30;
                    InfoDinardap.Periodicidad_pago = 30;

                    InfoDinardap.dias_morosidad = 0;
                    InfoDinardap.monto_morosidad = 0;
                    InfoDinardap.monto_inte_mora = 0;                    

                    InfoDinardap.valor_x_vencer_1_30 = 0;
                    InfoDinardap.valor_x_vencer_31_90 = 0;
                    InfoDinardap.valor_x_vencer_91_180 = 0;
                    InfoDinardap.valor_x_vencer_181_360 = 0;
                    InfoDinardap.valor_x_vencer_mas_360 = 0;

                    InfoDinardap.valor_vencido_1_30 = 0;
                    InfoDinardap.valor_vencido_31_90 = 0;
                    InfoDinardap.valor_vencido_91_180 = 0;
                    InfoDinardap.valor_vencido_181_360 = 0;
                    InfoDinardap.valor_vencido_mas_360 = 0;
                    InfoDinardap.valor_en_demand_judi = 0;
                    InfoDinardap.cartera_castigada = 0;
                    InfoDinardap.couta_credito = 0;
                    //Fecha de cobro
                    InfoDinardap.fecha_cancela = item.vt_fecha.ToString("dd/MM/yyyy");
                    InfoDinardap.forma_cance = "E";
                    InfoDinardap.CodEntidad = param.InfoEmpresa.cod_entidad_dinardap;

                    ListInfoDinardap.Add(InfoDinardap);
                }

                if (ListInfoDinardap.Count() > 0)
                {
                    GuardarFile_txt(ListInfoDinardap);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void uccxC_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void GuardarFile_txt(List<Dinardap_Registros_cxc_Info> lstRpt)
        {
            try
            {
                int col = 0;
                string sLinea = String.Empty;
                string fileName = "";
                string nombre_file = "";

                nombre_file = param.InfoEmpresa.em_ruc + Convert.ToDateTime(uccxC_MenuReportes1.dtpHasta.EditValue).Day.ToString("00") + Convert.ToDateTime(uccxC_MenuReportes1.dtpHasta.EditValue).Month.ToString("00") + Convert.ToDateTime(uccxC_MenuReportes1.dtpHasta.EditValue).Year + ".txt";

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = nombre_file;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;

                    StreamWriter sw = new StreamWriter(fileName, false, Encoding.Default);

                    foreach (Dinardap_Registros_cxc_Info InfoData in lstRpt)
                    {
                        sLinea = "";

                        sLinea = InfoData.CodEntidad + "|" + InfoData.FechaDatos + "|" + InfoData.TipoIden;
                        sLinea = sLinea + "|" + InfoData.Identificacion + "|" + InfoData.Nom_apellido + "|" + InfoData.clase_suje;
                        sLinea = sLinea + "|" + InfoData.Provincia + "|" + InfoData.canton + "|" + InfoData.parroquia;
                        sLinea = sLinea + "|" + InfoData.sexo + "|" + InfoData.estado_civil + "|" + InfoData.Origen_Ing;
                        sLinea = sLinea + "|" + InfoData.num_operacion + "|" + string.Format("{0:f2}",InfoData.valor_ope) + "|" + string.Format("{0:f2}",InfoData.saldo_ope);
                        sLinea = sLinea + "|" + InfoData.fecha_conse + "|" + InfoData.fecha_vct + "|" + InfoData.fecha_exigi;
                        sLinea = sLinea + "|" + InfoData.Plazo_op + "|" + InfoData.Periodicidad_pago + "|" + InfoData.dias_morosidad;
                        sLinea = sLinea + "|" + string.Format("{0:f2}",InfoData.monto_morosidad) + "|" + string.Format("{0:f2}",InfoData.monto_inte_mora) + "|" + string.Format("{0:f2}",InfoData.valor_x_vencer_1_30);
                        sLinea = sLinea + "|" + string.Format("{0:f2}",InfoData.valor_x_vencer_31_90) + "|" + string.Format("{0:f2}",InfoData.valor_x_vencer_91_180) + "|" + string.Format("{0:f2}",InfoData.valor_x_vencer_181_360);
                        sLinea = sLinea + "|" + string.Format("{0:f2}",InfoData.valor_x_vencer_mas_360) + "|" + string.Format("{0:f2}",InfoData.valor_vencido_1_30) + "|" + string.Format("{0:f2}",InfoData.valor_vencido_31_90);
                        sLinea = sLinea + "|" + string.Format("{0:f2}",InfoData.valor_vencido_91_180) + "|" + string.Format("{0:f2}",InfoData.valor_vencido_181_360) + "|" + string.Format("{0:f2}",InfoData.valor_vencido_mas_360);
                        sLinea = sLinea + "|" + string.Format("{0:f2}",InfoData.valor_en_demand_judi) + "|" + string.Format("{0:f2}",InfoData.cartera_castigada) + "|" + string.Format("{0:f2}",InfoData.couta_credito);
                        sLinea = sLinea + "|" + InfoData.fecha_cancela + "|" + InfoData.forma_cance;

                        sw.WriteLine(sLinea);
                    }


                    sw.Close();



                }

                MessageBox.Show("Generacion de File DINARDAP ok..", param.Nombre_sistema, MessageBoxButtons.OK);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }



        }

        private void uccxC_MenuReportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Lista_rpt = bus_rpt.Get_list(param.IdEmpresa, Convert.ToDateTime(uccxC_MenuReportes1.dtpDesde.EditValue), Convert.ToDateTime(uccxC_MenuReportes1.dtpHasta.EditValue));
                gridControlDinardap.DataSource = Lista_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
