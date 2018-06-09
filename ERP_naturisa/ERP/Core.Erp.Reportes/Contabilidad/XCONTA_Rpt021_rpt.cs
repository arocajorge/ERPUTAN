using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.IO;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt021_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XCONTA_Rpt021_rpt()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt021_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLfecha.Text = DateTime.Now.ToString();
            xrLusuario.Text = param.IdUsuario;
            try
            {
                string msg = "";
                XCONTA_Rpt021_Bus Bus = new XCONTA_Rpt021_Bus();
                List<XCONTA_Rpt021_Info> lista = new List<XCONTA_Rpt021_Info>();

                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                DateTime FechaIni;
                DateTime FechaFin;
                string IdCentroCosto = "";
                int IdPuntoCargo = 0;
                int IdPuntoCargo_Grupo = 0;
                bool Mostrar_Reg_en_cero = false;
                bool Mostrar_CC = false;
                bool Considerar_Asiento_cierre_anual = false;
                

                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                FechaIni = Convert.ToDateTime(PFechaIni.Value);
                FechaFin = Convert.ToDateTime(PFechaFin.Value);

                IdPuntoCargo = Convert.ToInt32(PIdPunto_Cargo.Value);
                IdPuntoCargo_Grupo = Convert.ToInt32(PIdPunto_Cargo_Grupo.Value);

                IdCentroCosto = Convert.ToString(PIdCentroCosto.Value);
                IdNivel_a_mostrar = Convert.ToInt32(PIdNivel_a_mostrar.Value);
                Mostrar_Reg_en_cero = Convert.ToBoolean(PMostrar_Reg_en_cero.Value);
                Mostrar_CC = Convert.ToBoolean(P_Mostrar_CC.Value);
                Considerar_Asiento_cierre_anual = Convert.ToBoolean(PConsiderar_Asiento_cierre_anual.Value);


                lista = Bus.consultar_data(IdEmpresa, FechaIni, FechaFin, IdCentroCosto, IdNivel_a_mostrar, 
                    IdPuntoCargo_Grupo, IdPuntoCargo, Mostrar_Reg_en_cero, Mostrar_CC,Considerar_Asiento_cierre_anual,param.IdUsuario , ref msg);

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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt021_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt021_rpt) };   
            }
                
           
        }

        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
               
                

                    
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
