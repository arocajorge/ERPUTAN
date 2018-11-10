using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Compras;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Confirmacion_SC_para_OC : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<com_solicitud_compra_det_aprobacion_Info> lstSolCompra = new BindingList<com_solicitud_compra_det_aprobacion_Info>();
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus busSucur = new tb_Sucursal_Bus();        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<com_GeneracionOcCabecera> blst_cabecera = new BindingList<com_GeneracionOcCabecera>();

        List<com_TerminoPago_Info> lst_termino_pago = new List<com_TerminoPago_Info>();
        com_TerminoPago_Bus bus_termino_pago = new com_TerminoPago_Bus();

        public FrmCom_Confirmacion_SC_para_OC()
        {
            InitializeComponent();
        }

        private void FrmCom_Confirmacion_SC_para_OC_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        void CargarCombo()
        {
            try
            {
                listSucursal = new List<tb_Sucursal_Info>();
                listSucursal = busSucur.Get_List_Sucursal(param.IdEmpresa);
                cmb_Sucursal.DataSource = listSucursal;

                lst_termino_pago = bus_termino_pago.Get_List_TerminoPago();
                cmbTerminoPago.DataSource = lst_termino_pago;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Grid(List<com_solicitud_compra_det_aprobacion_Info> lstComp)
        {
            try
            {


                foreach (var item in lstComp)
                {
                    item.IdSucursal_x_OC = item.IdSucursal_SC; 
                }

                lstSolCompra = new BindingList<com_solicitud_compra_det_aprobacion_Info>(lstComp);

                var ListXProveedor = lstComp.GroupBy(q => q.IdProveedor_SC);
                foreach (var item in ListXProveedor)
                {


                    var prov = lstComp.Where(q => q.IdProveedor_SC == item.Key).FirstOrDefault();

                    if (prov != null)
                    {
                        var tp = lst_termino_pago.Where(q => q.Dias == prov.pr_plazo).FirstOrDefault();
                        blst_cabecera.Add(new com_GeneracionOcCabecera
                        {
                            IdProveedor = item.Key == null ? 0 : Convert.ToDecimal(item.Key),
                            NomProveedor = prov.Nom_Proveedor_SC,
                            IdTerminoPago = tp == null ? "1" : tp.IdTerminoPago,
                            Observacion = string.Empty,
                            Plazo = prov.pr_plazo
                        });
                    }
                }
                gridControlCabecera.DataSource = blst_cabecera;
                gridConfirmacionSC.DataSource = lstSolCompra;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public List<com_solicitud_compra_det_aprobacion_Info> get_Grid()
        {
            try
            {
                foreach (var item in blst_cabecera)
                {
                    lstSolCompra.Where(q => q.IdProveedor_SC == item.IdProveedor).ToList().ForEach(q => { q.pr_plazo = item.Plazo; q.observacion = item.Observacion; q.IdTerminoPago = item.IdTerminoPago; });
                }
                return new List<com_solicitud_compra_det_aprobacion_Info>(lstSolCompra);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<com_solicitud_compra_det_aprobacion_Info>();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewCabecera_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                com_GeneracionOcCabecera row = (com_GeneracionOcCabecera)gridViewCabecera.GetRow(e.RowHandle);
                if (row == null) return;

                var tp = lst_termino_pago.Where(q => q.IdTerminoPago == row.IdTerminoPago).FirstOrDefault();
                if (tp != null)
                    row.Plazo = tp.Dias;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewCabecera_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == ColTerminoPago)
                {
                    gridViewCabecera.SetRowCellValue(e.RowHandle, ColTerminoPago, e.Value);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


    }

    public class com_GeneracionOcCabecera
    {
        public decimal IdProveedor { get; set; }
        public string NomProveedor { get; set; }
        public string Observacion { get; set; }
        public string IdTerminoPago { get; set; }
        public int Plazo { get; set; }
    }
}
