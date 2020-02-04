using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;



namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Kardex : Form
    {
        UCIn_Sucursal_Bodega UCSucursalBodega = new UCIn_Sucursal_Bodega();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_movi_inve_detalle_Bus b_in_movi_det = new in_movi_inve_detalle_Bus();
        in_producto_x_tb_bodega_Bus pr_x_Bo = new in_producto_x_tb_bodega_Bus();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public FrmIn_Kardex()
        {
            InitializeComponent();
            try
            {
                UCSucursalBodega.Dock = DockStyle.Fill;
                UCSucursalBodega.TipoCarga = Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
                this.panelSucuBod.Controls.Add(UCSucursalBodega);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public decimal IdProducto { get; set; }
        public DateTime FechaIncio { get; set; }
        public DateTime FechaFin { get; set; }
        Boolean desdeDisponibilidad = true;
        public FrmIn_Kardex(decimal _IdProducto,DateTime _FechaIncio, DateTime _FechaFin) : this  ()
        {
            try
            {
                IdProducto = _IdProducto;
                FechaFin = _FechaFin;
                FechaIncio = _FechaIncio;
                desdeDisponibilidad = true;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        class prod
        {
            public string Descripcion { get; set; }
            public string Codigo { get; set; }
            public decimal IdProducto { get; set; }
        }


        private void frmIn_Kardex_Load(object sender, EventArgs e)
        {
            try
            {
                List<prod> comb = new List<prod>();
                foreach (var item in pr_x_Bo.Get_List_ProductoxBodegaxSucursal_x_Bodega(param.IdEmpresa, Convert.ToInt32(UCSucursalBodega.cmb_bodega.EditValue), Convert.ToInt32(UCSucursalBodega.cmb_sucursal.EditValue)))
                {
                    prod det = new prod();
                    det.Codigo = item.pr_codigo;
                    det.Descripcion = item.pr_descripcion;
                    det.IdProducto = item.IdProducto;
                    comb.Add(det);
                }
                cmbProductos.Properties.DataSource = comb;

                if (desdeDisponibilidad) 
                {
                    cmbProductos.EditValue = IdProducto;
                    dtpFechaIncial.Value = FechaIncio;
                    dtpFechaFinal.Value = FechaFin;
                    btn_Procesar_Click(new Object(), new EventArgs());
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e){}

        private void btn_Procesar_Click(object sender, EventArgs e)
        {


            try
            {
                List<in_movi_inve_detalle_Info> DataSource = new List<in_movi_inve_detalle_Info>();
                var saldoInicial = b_in_movi_det.Get_Info_StockAFechaPorProduct(param.IdEmpresa, Convert.ToInt32(UCSucursalBodega.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursalBodega.cmb_bodega.EditValue), Convert.ToDecimal(cmbProductos.EditValue), Convert.ToDateTime(dtpFechaIncial.Value.ToShortDateString()));
                saldoInicial.Fecha = dtpFechaIncial.Value;
                saldoInicial.TipoMoviInven = "Saldo Incial";
                saldoInicial.Sucursal = UCSucursalBodega.cmb_sucursal.Text;
                saldoInicial.Bodega = UCSucursalBodega.cmb_bodega.Text;
                saldoInicial.NomProducto = cmbProductos.Text;
                DataSource.Add(saldoInicial);

                DataSource.AddRange(b_in_movi_det.Get_List_CuerpoKardex(param.IdEmpresa, Convert.ToInt32(UCSucursalBodega.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursalBodega.cmb_bodega.EditValue), Convert.ToDecimal(cmbProductos.EditValue), Convert.ToDateTime(dtpFechaIncial.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaFinal.Value.ToShortDateString())));

                var SALDOFINAL = b_in_movi_det.Get_Info_StockAFechaPorProduct(param.IdEmpresa, Convert.ToInt32(UCSucursalBodega.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursalBodega.cmb_bodega.EditValue), Convert.ToDecimal(cmbProductos.EditValue), Convert.ToDateTime(dtpFechaFinal.Value.ToShortDateString()));
                SALDOFINAL.Fecha = dtpFechaFinal.Value;
                SALDOFINAL.TipoMoviInven = "Saldo Final";
                SALDOFINAL.Sucursal = UCSucursalBodega.cmb_sucursal.Text;
                SALDOFINAL.NomProducto = cmbProductos.Text;
                SALDOFINAL.Bodega = UCSucursalBodega.cmb_bodega.Text;
                DataSource.Add(SALDOFINAL);

                gridControl.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e){}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
               Close();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
    }
}
