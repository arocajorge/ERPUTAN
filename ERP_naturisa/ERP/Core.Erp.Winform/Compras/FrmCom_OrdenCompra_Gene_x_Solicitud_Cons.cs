using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;

using Cus.Erp.Reports.Naturisa.Compras;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_OrdenCompra_Gene_x_Solicitud_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        BindingList<com_ordencompra_local_Info> ListaBind;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public FrmCom_OrdenCompra_Gene_x_Solicitud_Cons()
        {
            InitializeComponent();
        }
        
        public List<com_ordencompra_local_Info> list_OrdComp { get; set; }
   
        void carga_grid()
        {
            try
            {
                if (list_OrdComp.Count !=0)
                {
                    com_ordencompra_local_Bus bus_OrdComp = new com_ordencompra_local_Bus();
                    com_ordencompra_local_Info info_OrdComp = new com_ordencompra_local_Info();
                    List<com_ordencompra_local_Info> lista_OrdComp = new List<com_ordencompra_local_Info>();

                    foreach (var item in list_OrdComp)
                    {
                        info_OrdComp = bus_OrdComp.Get_Info_ordencompra_local(item.IdEmpresa, item.IdSucursal, item.IdOrdenCompra);

                        lista_OrdComp.Add(info_OrdComp);
                    }

                    ListaBind = new BindingList<com_ordencompra_local_Info>(lista_OrdComp);
                    gridControlOrdComp.DataSource = ListaBind;
                }                                                                                                                          
            }
            catch (Exception ex)
            {
                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }        
        }

        private void FrmCom_OrdenCompra_Gene_x_Solicitud_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                carga_grid();
            }
            catch (Exception ex)
            {

                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void ucGe_Menu_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Ordenes de compra generadas exitósamente", param.Nombre_sistema);
                Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                if (list_OrdComp.Count != 0)
                {
                    MessageBox.Show("Se procederá a imprimir todas las Ordenes de Compras", param.Nombre_sistema);

                    foreach (var item in ListaBind)
                    {
                        XCOMP_NATU_Rpt007_Rpt Reporte_Natu = new XCOMP_NATU_Rpt007_Rpt();
                        Reporte_Natu.RequestParameters = false;
                        ReportPrintTool pt_Natu = new ReportPrintTool(Reporte_Natu);
                        pt_Natu.AutoShowParametersPanel = false;
                        Reporte_Natu.PIdEmpresa.Value = param.IdEmpresa;
                        Reporte_Natu.PIdSucursal.Value = item.IdSucursal;
                        Reporte_Natu.PIdOrdenCompra.Value = item.IdOrdenCompra;
                        Reporte_Natu.ShowPreviewDialog();
                    }
                }

            }
            catch (Exception ex)
            {

                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void cmb_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                com_ordencompra_local_Info Info_OC = (com_ordencompra_local_Info)gridViewOrdComp.GetFocusedRow();
                if (Info_OC == null)
                    return;

                XCOMP_NATU_Rpt007_Rpt Reporte_Natu = new XCOMP_NATU_Rpt007_Rpt();
                Reporte_Natu.RequestParameters = false;
                ReportPrintTool pt_Natu = new ReportPrintTool(Reporte_Natu);
                pt_Natu.AutoShowParametersPanel = false;
                Reporte_Natu.PIdEmpresa.Value = param.IdEmpresa;
                Reporte_Natu.PIdSucursal.Value = Info_OC.IdSucursal;
                Reporte_Natu.PIdOrdenCompra.Value = Info_OC.IdOrdenCompra;
                Reporte_Natu.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
