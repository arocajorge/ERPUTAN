using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt023_frm : Form
    {
        List<XCONTA_Rpt023_Info> blst = new List<XCONTA_Rpt023_Info>();
        XCONTA_Rpt023_Bus bus = new XCONTA_Rpt023_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public XCONTA_Rpt023_frm()
        {
                        
            InitializeComponent();
        }

        private void uCct_Menu_Reportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ct_Cbtecble_Bus bus_diario = new ct_Cbtecble_Bus();
                splashScreenManager1.ShowWaitForm();
                blst = new List<XCONTA_Rpt023_Info>();
                List<string> CentroCosto = new List<string>();
                CentroCosto = uCct_Menu_Reportes1.Get_CentroCosto_checked();
                int Nivel = uCct_Menu_Reportes1.bei_Nivel.EditValue == null ? 0 : Convert.ToInt32(uCct_Menu_Reportes1.bei_Nivel.EditValue);
                DateTime FechaCorte = uCct_Menu_Reportes1.bei_Hasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Hasta.EditValue);
                foreach (var item in CentroCosto)
                {
                    var lst = bus_diario.GetList(param.IdEmpresa,item,Nivel,FechaCorte,param.IdUsuario,"ER",Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check.EditValue));
                    
                    //blst.AddRange(bus.GetList(param.IdEmpresa,item,Nivel,FechaCorte,param.IdUsuario,"ER",Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check.EditValue)));
                    pivotBalance.DataSource = null;
                    pivotBalance.DataSource = blst;
                    
                }
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception)
            {
                if(splashScreenManager1.IsSplashFormVisible)
                    splashScreenManager1.CloseWaitForm();
            }
        }

        private void uCct_Menu_Reportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void XCONTA_Rpt023_frm_Load(object sender, EventArgs e)
        {
            try
            {
                uCct_Menu_Reportes1.Cargar_combos();
                uCct_Menu_Reportes1.bei_Check.EditValue = false;
            }
            catch (Exception)
            {
                
            }
            
        }

        private void pivotBalance_CustomAppearance(object sender, DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs e)
        {
            try
            {
                if (e.DataField == col_SaldoNaturaleza)
                {
                    if (e.Value != null && Convert.ToDouble(e.Value) < 0)
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }else
                        e.Appearance.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                pivotBalance.ShowPrintPreview();
            }
            catch (Exception)
            {
                
            }
        }

        private void pivotBalance_CustomDrawFieldValue(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventArgs e)
        {
            
        }
    }
}
