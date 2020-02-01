using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;
using System.Collections.Generic;
using System.IO;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt029_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<int> lst_bod = new List<int>();

        public XINV_Rpt029_rpt()
        {
            InitializeComponent();
        }

        public void set_lista(List<int> _lst_bod)
        {
            try
            {
                lst_bod = _lst_bod;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_lista", ex.Message), ex) { EntityType = typeof(XINV_Rpt029_rpt) };
            }
        }

        private void XINV_Rpt029_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblUsuario.Text = param.IdUsuario;
                lblFecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
                lblEmpresa.Text = param.NombreEmpresa;

                string msg = "";
                XINV_Rpt029_Bus Bus = new XINV_Rpt029_Bus();
                List<XINV_Rpt029_Info> lista = new List<XINV_Rpt029_Info>();

                int IdEmpresa = 0;
                int IdSucursal = 0;
                int IdSucursalFin = 0;
                Boolean Registro_Cero = false;
                DateTime Fecha_corte = DateTime.Now;
                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                Registro_Cero = Convert.ToBoolean(this.PRegistro_Cero.Value);
                Fecha_corte = Convert.ToDateTime(FechaFin.Value);

                lista = Bus.Get_data(IdEmpresa, IdSucursal, lst_bod,  Registro_Cero,Fecha_corte, ref msg);
                

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt029_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt029_rpt) };
            }
        }


    }
}
