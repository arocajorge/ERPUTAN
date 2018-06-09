using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using System.Collections.Generic;
using Core.Erp.Business.Contabilidad;
using System.Linq;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt015_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XCONTA_Rpt015_rpt()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<ct_Periodo_Info> lista_periodo_a_buscar = new List<ct_Periodo_Info>();

        public void set_periodo(List<ct_Periodo_Info> lista_periodo_a_buscar_)
        {
            try
            {
                lista_periodo_a_buscar = lista_periodo_a_buscar_;

            }
            catch (Exception ex)
            {

            }
        }

        private void XCONTA_Rpt015_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLfecha.Text = DateTime.Now.ToString();
            xrLusuario.Text = param.IdUsuario;
            lblEmpresa.Text = param.NombreEmpresa;
            try
            {
                string msg = "";
                XCONTA_Rpt015_Bus Bus = new XCONTA_Rpt015_Bus();
                List<XCONTA_Rpt015_Info> lista = new List<XCONTA_Rpt015_Info>();

                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;


                bool Mostrar_Reg_en_cero = false;
                bool Mostrar_CC = false;
                int IdPeriodo_Corte = 0;


                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                IdNivel_a_mostrar = Convert.ToInt32(PIdNivel_a_mostrar.Value);
                Mostrar_Reg_en_cero = Convert.ToBoolean(PMostrar_Reg_en_cero.Value);
                Mostrar_CC = Convert.ToBoolean(P_MostrarCC.Value);

                if (lista_periodo_a_buscar.Count == 0)
                {
                    ct_Periodo_Bus BusPeriodo = new ct_Periodo_Bus();
                    List<ct_Periodo_Info> listPeriodo_aux = new List<ct_Periodo_Info>();
                    List<ct_Periodo_Info> listPeriodo = new List<ct_Periodo_Info>();
                    listPeriodo_aux = BusPeriodo.Get_List_Periodo(param.IdEmpresa, ref msg);

                    IdPeriodo_Corte = (DateTime.Now.Year * 100) + DateTime.Now.Month;
                    int fila = 1;

                    foreach (var item in listPeriodo_aux.OrderByDescending(q => q.IdPeriodo).ToList())
                    {
                        if (fila <= 12)
                        {
                            lista_periodo_a_buscar.Add(item);
                        }
                        fila++;
                    }
                }

                lista = Bus.consultar_data(IdEmpresa, lista_periodo_a_buscar, "", IdNivel_a_mostrar, 0, 0, Mostrar_Reg_en_cero, Mostrar_CC,param.IdUsuario , ref msg);

                foreach (var item in lista)
                {
                    if (item.nom_Periodo_1 == "")
                    {
                        cel_det_01.Visible = false;
                        cel_may_1.Visible = false;
                        cel_rep_1.Visible = false;
                        cel_gru_1.Visible = false;
                    }
                    if (item.nom_Periodo_2 == "")
                    {
                        cel_det_02.Visible = false;
                        cel_rep_2.Visible = false;
                        cel_may_2.Visible = false;
                        cel_gru_2.Visible = false;
                    }
                    if (item.nom_Periodo_3 == "")
                    {
                        cel_det_03.Visible = false;
                        cel_rep_3.Visible = false;
                        cel_may_3.Visible = false;
                        cel_gru_3.Visible = false;
                    }
                    if (item.nom_Periodo_4 == "")
                    {
                        cel_det_04.Visible = false;
                        cel_rep_4.Visible = false;
                        cel_may_4.Visible = false;
                        cel_gru_4.Visible = false;
                    }
                    if (item.nom_Periodo_5 == "")
                    {
                        cel_det_05.Visible = false;
                        cel_rep_5.Visible = false;
                        cel_may_5.Visible = false;
                        cel_gru_5.Visible = false;
                    }
                    if (item.nom_Periodo_6 == "")
                    {
                        cel_det_06.Visible = false;
                        cel_rep_6.Visible = false;
                        cel_may_6.Visible = false;
                        cel_gru_6.Visible = false;
                    }
                    if (item.nom_Periodo_7 == "")
                    {
                        cel_det_07.Visible = false;
                        cel_rep_7.Visible = false;
                        cel_may_7.Visible = false;
                        cel_gru_7.Visible = false;
                    }
                    if (item.nom_Periodo_8 == "")
                    {
                        cel_det_08.Visible = false;
                        cel_rep_8.Visible = false;
                        cel_may_8.Visible = false;
                        cel_gru_8.Visible = false;
                    }
                    if (item.nom_Periodo_9 == "")
                    {
                        cel_det_09.Visible = false;
                        cel_rep_9.Visible = false;
                        cel_may_9.Visible = false;
                        cel_gru_9.Visible = false;
                    }
                    if (item.nom_Periodo_10 == "")
                    {
                        cel_det_10.Visible = false;
                        cel_rep_10.Visible = false;
                        cel_may_10.Visible = false;
                        cel_gru_10.Visible = false;
                    }
                    if (item.nom_Periodo_11 == "")
                    {
                        cel_det_11.Visible = false;
                        cel_rep_11.Visible = false;
                        cel_may_11.Visible = false;
                        cel_gru_11.Visible = false;
                    }
                    if (item.nom_Periodo_12 == "")
                    {
                        cel_det_12.Visible = false;
                        cel_rep_12.Visible = false;
                        cel_may_12.Visible = false;
                        cel_gru_12.Visible = false;
                    }
                    break;
                }


                if (lista.Count == 0)
                {
                    xrLmensaje.Visible = true;
                    xrLmensaje.Text = "No hay datos encontrados para estos filtros";
                }
                else
                {
                    xrLmensaje.Visible = false;
                }


                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt001_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt001_rpt) };
            }
        }
    }
}
