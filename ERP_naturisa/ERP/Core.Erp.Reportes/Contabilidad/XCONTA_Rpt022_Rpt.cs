using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt022_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        int IdNivel_a_mostrar = 0;
        public XCONTA_Rpt022_Rpt()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt022_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                
                string msg = "";
                XCONTA_Rpt022_Bus Bus = new XCONTA_Rpt022_Bus();
                List<XCONTA_Rpt022_Info> lista = new List<XCONTA_Rpt022_Info>();

                
                DateTime FechaIni;
                DateTime FechaFin;
                string IdCentroCosto = "";
                int IdPuntoCargo = 0;
                int IdPuntoCargo_Grupo = 0;
                bool Mostrar_Reg_en_cero = true;
                bool Mostrar_CC = false;
                bool Mostrar_asiento_cierre = false;
                /*
                IdNivel_a_mostrar = 3;
                FechaIni = new DateTime ( 2017, 01, 01 );
                FechaFin = new DateTime(2017, 01, 31);
                */
                FechaIni = Convert.ToDateTime(P_Fecha_ini.Value);
                FechaFin = Convert.ToDateTime(P_Fecha_fin.Value);
                lblFecha_corte.Text = "Al " + FechaFin.ToLongDateString();
                IdPuntoCargo = Convert.ToInt32(P_IdPuntoCargo.Value);
                IdPuntoCargo_Grupo = Convert.ToInt32(P_IdPuntoCargo_grupo.Value);

                IdCentroCosto = Convert.ToString(P_IdCentroCosto.Value);
                IdNivel_a_mostrar = Convert.ToInt32(P_IdNivel_a_mostrar.Value);
                Mostrar_Reg_en_cero = Convert.ToBoolean(P_Mostrar_reg_en_cero.Value);
                Mostrar_CC = Convert.ToBoolean(P_Mostrar_CC.Value);
                Mostrar_asiento_cierre = Convert.ToBoolean(P_Mostrar_asiento_cierre.Value);


                lista = Bus.consultar_data(param.IdEmpresa, FechaIni, FechaFin,
                    IdCentroCosto, IdNivel_a_mostrar, IdPuntoCargo_Grupo, IdPuntoCargo, Mostrar_Reg_en_cero, Mostrar_CC, Mostrar_asiento_cierre, param.IdUsuario, ref msg);
                this.DataSource = lista;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt001_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt001_rpt) };
            }
        }

        private void Grupo_nivel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (IdNivel_a_mostrar <= 3)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt001_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt001_rpt) };
            }
        }

        private void Grupo_nivel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (IdNivel_a_mostrar <= 4)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt001_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt001_rpt) };
            }
        }

        private void Grupo_nivel5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (IdNivel_a_mostrar <= 5)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt001_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt001_rpt) };
            }
        }

        private void Grupo_nivel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (IdNivel_a_mostrar <= 6)
                {
                    e.Cancel = true;
                }
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
