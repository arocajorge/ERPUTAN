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
    public partial class XCONTA_Rpt010_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XCONTA_Rpt010_Rpt()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt010_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLfecha.Text = DateTime.Now.ToString();
            xlblIdReporte.Text = this.Name.ToString();
            try
            {
                string msg = "";
                XCONTA_Rpt010_Bus Bus = new XCONTA_Rpt010_Bus();
                List<XCONTA_Rpt010_Info> lista = new List<XCONTA_Rpt010_Info>();

                int IdEmpresa = 0;
                DateTime FechaIni;
                DateTime FechaFin;
                int IdPunto_Cargo_Grupo = 0;
                bool Mostrar_Reg_Cero = false;


                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                FechaIni = Convert.ToDateTime(PFechaIni.Value);
                FechaFin = Convert.ToDateTime(PFechaFin.Value);
                IdPunto_Cargo_Grupo = Convert.ToInt32(PIdPunto_cargo_grupo.Value);
                Mostrar_Reg_Cero = Convert.ToBoolean(PMostrar_Reg_Cero.Value);


                lista = Bus.Get_list_Data(IdEmpresa, FechaIni, FechaFin, IdPunto_Cargo_Grupo, Mostrar_Reg_Cero);

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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt010_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt010_Rpt) };
            }
        }

    }
}
