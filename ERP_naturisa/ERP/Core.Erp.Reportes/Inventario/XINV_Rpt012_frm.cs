using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt012_frm : DevExpress.XtraEditors.XtraForm
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;   

        public XINV_Rpt012_frm()
        {
            InitializeComponent();
            ucInv_Menu.event_btnSalir_ItemClick += ucInv_Menu_event_btnSalir_ItemClick;
            ucInv_Menu.event_tnConsultar_ItemClick += ucInv_Menu_event_tnConsultar_ItemClick;
            ucInv_Menu.event_btnImprimir_ItemClick += ucInv_Menu_event_btnImprimir_ItemClick;
        }

        void ucInv_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pivotGridMoviInve.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucInv_Menu_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ConsultarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucInv_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartControl1.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ConsultarGrid()
        {
            try
            {
                if (ValdarDatos())
                {
                    XINV_Rpt012_Bus rptBus = new XINV_Rpt012_Bus();
                    DateTime FechaIni = DateTime.Now;
                    DateTime FechaFin = DateTime.Now;
                    int IdSucursal = 0;
                    int IdBodega = 0;
                    int IdMoviInven = 0;
                    decimal IdProducto = 0;
                    string TipoMovi = "";

                    IdSucursal = Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue);
                    IdBodega = Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue);
                    IdMoviInven = Convert.ToInt32(ucInv_Menu.cmbTipoMovInve.EditValue);
                    IdProducto = Convert.ToDecimal(ucInv_Menu.cmbProducto.EditValue);
                    FechaIni = Convert.ToDateTime(ucInv_Menu.dtpDesde.EditValue);
                    FechaFin = Convert.ToDateTime(ucInv_Menu.dtpHasta.EditValue);
                    TipoMovi = (ucInv_Menu.optOpciones.EditValue == null) ? "" : Convert.ToString(ucInv_Menu.optOpciones.EditValue);

                    this.pivotGridMoviInve.DataSource = rptBus.get_List_MoviInveMatriz(param.IdEmpresa, IdSucursal, IdBodega, IdMoviInven, IdProducto, TipoMovi, FechaIni, FechaFin);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean ValdarDatos()
        {
            try
            {
                if (ucInv_Menu.cmbSucursal.EditValue == null)
                {
                    MessageBox.Show("Seleccione la Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (ucInv_Menu.cmbBodega.EditValue == null)
                {
                    MessageBox.Show("Seleccione la Bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (ucInv_Menu.cmbTipoMovInve.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Tipo de Movimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (ucInv_Menu.cmbProducto.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}