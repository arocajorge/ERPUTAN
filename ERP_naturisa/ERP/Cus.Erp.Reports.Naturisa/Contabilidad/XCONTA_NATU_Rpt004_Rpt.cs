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

namespace Cus.Erp.Reports.Naturisa.Contabilidad
{
    public partial class XCONTA_NATU_Rpt004_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        int IdNivel_a_mostrar = 0;

        public XCONTA_NATU_Rpt004_Rpt()
        {
            InitializeComponent();
        }

        private void XCONTA_NATU_Rpt004_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
            try
            {
                string msg = "";
                XCONTA_NATU_Rpt004_Bus Bus = new XCONTA_NATU_Rpt004_Bus();
                List<XCONTA_NATU_Rpt004_Info> lista = new List<XCONTA_NATU_Rpt004_Info>();

                int IdEmpresa = 0;
                
                DateTime FechaIni;
                DateTime FechaFin;
                string IdCentroCosto = "";
                int IdPunto_Cargo = 0;
                int IdPunto_Cargo_Grupo = 0;
                bool Mostrar_Reg_en_cero = false;
                bool Mostrar_CC = false;
                bool Considerar_Asiento_cierre_anual = false;

                lblEmpresa.Text = param.NombreEmpresa;                



                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                FechaIni = Convert.ToDateTime(PFechaIni.Value);
                FechaFin = Convert.ToDateTime(PFechaFin.Value);

                IdCentroCosto = Convert.ToString(PIdCentroCosto.Value);
                IdNivel_a_mostrar = Convert.ToInt32(PIdNivel_a_mostrar.Value);

                IdPunto_Cargo = Convert.ToInt32(PIdPunto_Cargo.Value);
                IdPunto_Cargo_Grupo = Convert.ToInt32(PIdPunto_Cargo_Grupo.Value);

                Mostrar_Reg_en_cero = Convert.ToBoolean(PMostrar_Reg_en_cero.Value);
                Mostrar_CC = Convert.ToBoolean(P_MostrarCC.Value);

                Considerar_Asiento_cierre_anual = Convert.ToBoolean(PConsiderar_Asiento_cierre_anual.Value);



                lista = Bus.consultar_data(IdEmpresa, FechaIni, FechaFin, IdCentroCosto, IdNivel_a_mostrar, IdPunto_Cargo,
                    IdPunto_Cargo_Grupo, Mostrar_Reg_en_cero,Mostrar_CC,Considerar_Asiento_cierre_anual,param.IdUsuario , ref msg);

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_NATU_Rpt004_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_NATU_Rpt004_Rpt) };   

            }
                
           
        }

        private void Grupo_nivel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (IdNivel_a_mostrar <= 2)
            {
                e.Cancel = true;
            }
        }

        private void Grupo_nivel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (IdNivel_a_mostrar <= 3)
            {
                e.Cancel = true;
            }
        }

        private void Grupo_nivel_4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (IdNivel_a_mostrar <= 4)
            {
                e.Cancel = true;
            }
        }

        private void Grupo_nivel5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (IdNivel_a_mostrar <= 5)
            {
                e.Cancel = true;
            }
        }

        private void Grupo_nivel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (IdNivel_a_mostrar <= 6)
            {
                e.Cancel = true;
            }
        }

     
    }
}
