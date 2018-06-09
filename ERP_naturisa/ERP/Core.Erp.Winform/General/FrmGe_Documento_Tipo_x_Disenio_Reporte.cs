using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Reportes.Facturacion;
using Core.Erp.Reportes.CuentasxPagar;
using Cus.Erp.Reports.FJ.Facturacion;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Documento_Tipo_x_Disenio_Reporte : DevExpress.XtraEditors.XtraForm
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        vwtb_sis_Documento_Tipo_x_Disenio_Report_Bus busVwDoc = new vwtb_sis_Documento_Tipo_x_Disenio_Report_Bus();
        List<vwtb_sis_Documento_Tipo_x_Disenio_Report_Info> lstVwDoc = new List<vwtb_sis_Documento_Tipo_x_Disenio_Report_Info>();
        vwtb_sis_Documento_Tipo_x_Disenio_Report_Info _Info = new vwtb_sis_Documento_Tipo_x_Disenio_Report_Info();
        
        public FrmGe_Documento_Tipo_x_Disenio_Reporte()
        {
            InitializeComponent();
            ucGe_Menu.event_btnDisenioReport_ItemClick += ucGe_Menu_event_btnDisenioReport_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnDisenioReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_Info != null)
                {
                    if (_Info.codDocumentoTipo == Cl_Enumeradores.eTipoDocumento_Talonario.FACT.ToString())
                    {
                        switch (param.IdCliente_Ven_x_Default)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.FJ:
                                XFAC_FJ_Rpt014_frm frmFact_fj = new XFAC_FJ_Rpt014_frm(_Info);
                                frmFact_fj.Show();
                                break;
                            default:
                                XFAC_Rpt008_frm frmFact = new XFAC_Rpt008_frm(_Info);
                                frmFact.Show();
                                break;
                        }                        
                    }

                    if ((_Info.codDocumentoTipo == Cl_Enumeradores.eTipoDocumento_Talonario.NTCR.ToString())
                        || (_Info.codDocumentoTipo == Cl_Enumeradores.eTipoDocumento_Talonario.NTDB.ToString()))
                    {
                        XFAC_Rpt010_frm frmNtc = new XFAC_Rpt010_frm(_Info);
                        frmNtc.Show();
                    }

                    if (_Info.codDocumentoTipo == Cl_Enumeradores.eTipoDocumento_Talonario.RETEN.ToString())
                    {
                        XCXP_Rpt015_frm frmRet = new XCXP_Rpt015_frm(_Info);
                        frmRet.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_Documento_Tipo_x_Disenio_Reporte_Load(object sender, EventArgs e)
        {
            try
            {
                ConsultarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ConsultarGrid()
        {
            try
            {
                lstVwDoc = busVwDoc.Get_List_sis_Documento_Tipo_x_Disenio_Report(param.IdEmpresa, "S");
                griDisenioReport.DataSource = lstVwDoc;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDisenioReport_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _Info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private vwtb_sis_Documento_Tipo_x_Disenio_Report_Info  GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (vwtb_sis_Documento_Tipo_x_Disenio_Report_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new vwtb_sis_Documento_Tipo_x_Disenio_Report_Info();
            }
        }

    }
}