using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt016_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XCONTA_Rpt016_rpt()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<XCONTA_Rpt016_Info> lst_rpt = new List<XCONTA_Rpt016_Info>();
        XCONTA_Rpt016_Bus bus_rpt = new XCONTA_Rpt016_Bus();
        List<ct_Periodo_Info> lista_periodo_a_buscar = new List<ct_Periodo_Info>();

        public void set_periodo(List<ct_Periodo_Info> lista_periodo_a_buscar_)
        {
            try
            {
                lista_periodo_a_buscar = lista_periodo_a_buscar_;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt016_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt016_rpt) };
            }
        }

        private void XCONTA_Rpt016_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLusuario.Text = param.IdUsuario;
                xrLfecha.Text = param.Fecha_Transac.ToString();
                lblEmpresa.Text = param.NombreEmpresa;

                int Anio = 0;
                bool Mostrar_CC = false;

                Anio = Convert.ToInt32(p_Anio.Value);
                Mostrar_CC = Convert.ToBoolean(p_Mostrar_CC.Value);

                lst_rpt = bus_rpt.Get_list_reporte(lista_periodo_a_buscar, param.IdEmpresa, Anio, Mostrar_CC);

                foreach (var item in lst_rpt)
                {
                    if (item.nom_Periodo_1 == "")
                    {
                //        cel_cab_01.Visible = false;
                        cel_det_01.Visible = false;
                        cel_gr1_01.Visible = false;
                        cel_gr2_01.Visible = false;
                        cel_gr3_01.Visible = false;
                        cel_rep_01.Visible = false;
                    }
                    if (item.nom_Periodo_2== "")
                    {
                  //      cel_cab_02.Visible = false;
                        cel_det_02.Visible = false;
                        cel_gr1_02.Visible = false;
                        cel_gr2_02.Visible = false;
                        cel_gr3_02.Visible = false;
                        cel_rep_02.Visible = false;
                    }
                    if (item.nom_Periodo_3 == "")
                    {
                    //    cel_cab_03.Visible = false;
                        cel_det_03.Visible = false;
                        cel_gr1_03.Visible = false;
                        cel_gr2_03.Visible = false;
                        cel_gr3_03.Visible = false;
                        cel_rep_03.Visible = false;
                    }
                    if (item.nom_Periodo_4=="")
                    {
                      //  cel_cab_04.Visible = false;
                        cel_det_04.Visible = false;
                        cel_gr1_04.Visible = false;
                        cel_gr2_04.Visible = false;
                        cel_gr3_04.Visible = false;
                        cel_rep_04.Visible = false;
                    }
                    if (item.nom_Periodo_5 == "")
                    {
                        //cel_cab_05.Visible = false;
                        cel_det_05.Visible = false;
                        cel_gr1_05.Visible = false;
                        cel_gr2_05.Visible = false;
                        cel_gr3_05.Visible = false;
                        cel_rep_05.Visible = false;
                    }
                    if (item.nom_Periodo_6 == "")
                    {
                    //    cel_cab_06.Visible = false;
                        cel_det_06.Visible = false;
                        cel_gr1_06.Visible = false;
                        cel_gr2_06.Visible = false;
                        cel_gr3_06.Visible = false;
                        cel_rep_06.Visible = false;
                    }
                    if (item.nom_Periodo_7 == "")
                    {
                      //  cel_cab_07.Visible = false;
                        cel_det_07.Visible = false;
                        cel_gr1_07.Visible = false;
                        cel_gr2_07.Visible = false;
                        cel_gr3_07.Visible = false;
                        cel_rep_07.Visible = false;
                    }
                    if (item.nom_Periodo_8 == "")
                    {
                       // cel_cab_08.Visible = false;
                        cel_det_08.Visible = false;
                        cel_gr1_08.Visible = false;
                        cel_gr2_08.Visible = false;
                        cel_gr3_08.Visible = false;
                        cel_rep_08.Visible = false;
                    }
                    if (item.nom_Periodo_9 == "")
                    {
                        //cel_cab_09.Visible = false;
                        cel_det_09.Visible = false;
                        cel_gr1_09.Visible = false;
                        cel_gr2_09.Visible = false;
                        cel_gr3_09.Visible = false;
                        cel_rep_09.Visible = false;
                    }
                    if (item.nom_Periodo_10 == "")
                    {
                        //cel_cab_10.Visible = false;
                        cel_det_10.Visible = false;
                        cel_gr1_10.Visible = false;
                        cel_gr2_10.Visible = false;
                        cel_gr3_10.Visible = false;
                        cel_rep_10.Visible = false;
                    }
                    if (item.nom_Periodo_11 == "")
                    {
                        //cel_cab_11.Visible = false;
                        cel_det_11.Visible = false;
                        cel_gr1_11.Visible = false;
                        cel_gr2_11.Visible = false;
                        cel_gr3_11.Visible = false;
                        cel_rep_11.Visible = false;
                    }
                    if (item.nom_Periodo_12 == "")
                    {
                        //cel_cab_12.Visible = false;
                        cel_det_12.Visible = false;
                        cel_gr1_12.Visible = false;
                        cel_gr2_12.Visible = false;
                        cel_gr3_12.Visible = false;
                        cel_rep_12.Visible = false;
                    }
                    break;
                }
                
                if (lst_rpt.Count == 0)
                {
                    xrLmensaje.Visible = true;
                    xrLmensaje.Text = "No existen datos para la consulta realizada";
                }
                this.DataSource = lst_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt016_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt016_rpt) };
            }
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                /*if (Convert.ToBoolean(p_Mostrar_CC.Value) == false)
                {
                    e.Cancel = true;
                }*/
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GroupHeader2_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt016_rpt) };
            }
        }

        private void GroupFooter2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                /*
                if (Convert.ToBoolean(p_Mostrar_CC.Value) == false)
                {
                    e.Cancel = true;
                }*/
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GroupHeader2_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt016_rpt) };
            }
        }

        private void GroupHeader3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(p_Mostrar_CC.Value) == false)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GroupHeader2_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt016_rpt) };
            }
        }

        private void GroupFooter3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(p_Mostrar_CC.Value) == false)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GroupHeader2_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt016_rpt) };
            }
        }
    }
}
