using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt013_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public XCONTA_Rpt013_rpt()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt013_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLfecha.Text = DateTime.Now.ToString();
            try
            {
                string msg = "";
                XCONTA_Rpt013_Bus Bus = new XCONTA_Rpt013_Bus();
                List<XCONTA_Rpt013_Info> lista = new List<XCONTA_Rpt013_Info>();

                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                int IdPeriodo = 0;
                string IdCentroCosto = "";
                int IdPuntoCargo = 0;
                int IdPuntoCargo_Grupo = 0;
                bool Mostrar_Reg_en_cero = false;
                bool Mostrar_CC = false;

                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                IdPeriodo = Convert.ToInt32(PIdPeriodo.Value);

                IdPuntoCargo = Convert.ToInt32(PIdPunto_Cargo.Value);
                IdPuntoCargo_Grupo = Convert.ToInt32(PIdPunto_Cargo_Grupo.Value);

                IdCentroCosto = Convert.ToString(PIdCentroCosto.Value);
                IdNivel_a_mostrar = Convert.ToInt32(PIdNivel_a_mostrar.Value);
                Mostrar_Reg_en_cero = Convert.ToBoolean(PMostrar_Reg_en_cero.Value);
                Mostrar_CC = Convert.ToBoolean(PMostrar_CC.Value);


                lista = Bus.consultar_data(IdEmpresa, IdPeriodo, IdCentroCosto, IdNivel_a_mostrar, IdPuntoCargo_Grupo,
                    IdPuntoCargo, Mostrar_Reg_en_cero,Mostrar_CC, param.IdUsuario ,ref msg);

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt013_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt013_rpt) };
            }
        }

    }
}
