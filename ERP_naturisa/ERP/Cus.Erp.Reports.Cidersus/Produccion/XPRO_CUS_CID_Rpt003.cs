using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
namespace Cus.Erp.Reports.Cidersus.Produccion
{
    public partial class XPRO_CUS_CID_Rpt003 : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XPRO_CUS_CID_Rpt003()
        {
            InitializeComponent();
        }



        public void loadData(List< XPRO_CUS_CID_Rpt003_Info> data)
        {
            try
            {
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                this.xrPictureBox1.Image = Funciones.ArrayAImage(param.InfoEmpresa.em_logo);
                DataSource = data;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "loadData", ex.Message), ex) { EntityType = typeof(XPRO_CUS_CID_Rpt003) };   
            }
        }

        }

    }

