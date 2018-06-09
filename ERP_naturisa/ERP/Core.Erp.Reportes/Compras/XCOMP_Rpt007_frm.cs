using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Compras
{
    public partial class XCOMP_Rpt007_frm : Form
    {
        List<XCOMP_Rpt007_Info> Lista = new List<XCOMP_Rpt007_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        XCOMP_Rpt007_Bus Bus = new XCOMP_Rpt007_Bus();
        XCOMP_Rpt007_Info.eAlerta eAlerta_info = new XCOMP_Rpt007_Info.eAlerta();
        XtraReport Rpt;

        public XCOMP_Rpt007_frm()
        {
            InitializeComponent();
            ucactF_Menu_Reportes1.event_btnGenerar_ItemClick += ucactF_Menu_Reportes1_event_btnGenerar_ItemClick;
            ucactF_Menu_Reportes1.event_btnImprimir_ItemClick += ucactF_Menu_Reportes1_event_btnImprimir_ItemClick;
            ucactF_Menu_Reportes1.event_btnSalir_ItemClick += ucactF_Menu_Reportes1_event_btnSalir_ItemClick;
        }

        void ucactF_Menu_Reportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucactF_Menu_Reportes1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Rpt != null)
                {
                    Rpt.PrintDialog();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucactF_Menu_Reportes1_event_btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                int IdEmpresa = param.IdEmpresa;
                int IdSucursal = 0;
                int IdSucursalFin = 0;
                string nom_Sucursal = string.Empty;
                int Alerta = 0;
                int AlertaFin = 0;
                string sAlerta = string.Empty;
                DateTime FechaCorte = DateTime.Now;

                IdSucursal = (Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemSucursal.EditValue)) == 0 ? 0 : (Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemSucursal.EditValue));
                IdSucursalFin = (Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemSucursal.EditValue)) == 0 ? 99999 : (Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemSucursal.EditValue));
                FechaCorte = ((DateTime)ucactF_Menu_Reportes1.barEditItemFechaCorte.EditValue) == null ? DateTime.Now : ((DateTime)ucactF_Menu_Reportes1.barEditItemFechaCorte.EditValue);
                tb_Sucursal_Info infoSucursal = ucactF_Menu_Reportes1.Get_Sucursal_info;
                if (infoSucursal != null)
                    nom_Sucursal = infoSucursal.Su_Descripcion;

                Alerta = ucactF_Menu_Reportes1.barEditItemAlert.EditValue == null ? 0 : Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemAlert.EditValue);
                AlertaFin = (Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemAlert.EditValue) == 0 || ucactF_Menu_Reportes1.barEditItemAlert.EditValue == null) ? 99999 : Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemAlert.EditValue);
                sAlerta = getNombre_Alerta(Alerta);


                Lista = Bus.Get_Lista(IdEmpresa, IdSucursal, IdSucursalFin, FechaCorte, Alerta, AlertaFin);
                Rpt = new XCOMP_Rpt007_Rpt(Lista, nom_Sucursal, sAlerta);
                ReportPrintTool pt = new ReportPrintTool(Rpt);
                printControl1.PrintingSystem = Rpt.PrintingSystem;
                Rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        public string getNombre_Alerta(int numero)
        {
            try
            {

                string Alerta = string.Empty;
                switch (numero)
                {
                    case (int)XCOMP_Rpt007_Info.eAlerta.Todos:
                        Alerta = XCOMP_Rpt007_Info.eAlerta.Todos.ToString();
                        break;
                    case (int)XCOMP_Rpt007_Info.eAlerta.Aceptable:
                        Alerta = XCOMP_Rpt007_Info.eAlerta.Aceptable.ToString();
                        break;
                    case (int)XCOMP_Rpt007_Info.eAlerta.Por_Quebrar:
                        Alerta = XCOMP_Rpt007_Info.eAlerta.Por_Quebrar.ToString();
                        break;
                    case (int)XCOMP_Rpt007_Info.eAlerta.Quebrados:
                        Alerta = XCOMP_Rpt007_Info.eAlerta.Quebrados.ToString();
                        break;
                    default:
                        break;
                }
                return Alerta;


            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }
    }
}
