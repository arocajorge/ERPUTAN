using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Documentos_Consulta : Form
    {//version 23042013 1852
        /// <summary>
        /// ver
        /// </summary>
        public frmFa_Documentos_Consulta()
        {
            try
            {
              InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_guia_remision_Bus bus = new fa_guia_remision_Bus();
        List<fa_guia_remision_Info> lmCuentaGuir = new List<fa_guia_remision_Info>();
        List<fa_cotizacion_info> lmCuentaCot = new List<fa_cotizacion_info>();
        DataTable TablaInfo = new DataTable();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal TOTAL { get; set; }


        public string TipoDoc { get; set; }
        public string Id { get; set; }

        private void creaTabla(List<fa_guia_remision_Info> Lista, DataTable tablaNCombo)
        {
            try
            {
                tablaNCombo.Columns.Add("Sucursal");
                tablaNCombo.Columns.Add("Bodega");
                tablaNCombo.Columns.Add("Id");
                tablaNCombo.Columns.Add("Cliente");
                tablaNCombo.Columns.Add("Vendedor");
                tablaNCombo.Columns.Add("Fecha");
                tablaNCombo.Columns.Add("FechaVenc");
                tablaNCombo.Columns.Add("Observacion");
                tablaNCombo.Columns.Add("IVA");
                tablaNCombo.Columns.Add("SubTotal");
                tablaNCombo.Columns.Add("Total");
                tablaNCombo.Columns.Add("IdS");
                tablaNCombo.Columns.Add("IdB");
                foreach (var item in Lista)
                {
                    DataRow filas;
                    filas = tablaNCombo.NewRow();
                    filas[0] = item.Sucursal;
                    filas[1] = item.Bodega;
                    filas[2] = item.IdGuiaRemision;
                    filas[3] = item.Cliente;
                    filas[4] = item.Vendedor;
                    filas[5] = item.gi_fecha;
                    filas[6] = item.gi_fech_venc;
                    filas[7] = item.gi_Observacion;
                    filas[8] = item.Iva;
                    filas[9] = item.Subtotal;
                    filas[10] = item.Total;
                    filas[11] = item.IdSucursal;
                    filas[12] = item.IdBodega;
                    tablaNCombo.Rows.Add(filas);
                    tablaNCombo.AcceptChanges();
                }
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString()); }
        }
        public void setUltaCmbGuir()
        {
            try
            {
                TablaInfo = new DataTable();
                lmCuentaGuir = bus.Get_List_guia_remision(param.IdEmpresa, IdSucursal, IdBodega,dtpFechaIni.Value,dtpFechaFin.Value);
                creaTabla(lmCuentaGuir, TablaInfo);
                this.gridConsulta.DataSource = TablaInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        //
        fa_cotizacion_Bus busCot = new fa_cotizacion_Bus();
        fa_factura_Bus busFact = new fa_factura_Bus();

        List<fa_cotizacion_info> listacotinfo = new List<fa_cotizacion_info>();
        List<fa_factura_Info> listaFactinfo = new List<fa_factura_Info>();

        private void creaTablaCot(List<fa_cotizacion_info> Lista, DataTable tablaNCombo)
        {
            try
            {
                tablaNCombo.Columns.Add("Sucursal");
                tablaNCombo.Columns.Add("Bodega");
                tablaNCombo.Columns.Add("Id");
                tablaNCombo.Columns.Add("Cliente");
                tablaNCombo.Columns.Add("Vendedor");
                tablaNCombo.Columns.Add("Fecha");
                tablaNCombo.Columns.Add("FechaVenc");
                tablaNCombo.Columns.Add("Observacion");
                tablaNCombo.Columns.Add("IVA");
                tablaNCombo.Columns.Add("SubTotal");
                tablaNCombo.Columns.Add("Total");
                tablaNCombo.Columns.Add("IdS");
                tablaNCombo.Columns.Add("IdB");
                foreach (var item in Lista)
                {
                    DataRow filas;
                    filas = tablaNCombo.NewRow();
                    filas[0] = item.Sucursal;
                    filas[1] = item.Bodega;
                    filas[2] = item.IdCotizacion;
                    filas[3] = item.Cliente;
                    filas[4] = item.Vendedor;
                    filas[5] = item.cc_fecha;
                    filas[6] = item.cc_fechaVencimiento;
                    filas[7] = item.cc_observacion;
                    filas[8] = item.iva;
                    filas[9] = item.subtotal;
                    filas[10] = item.total;
                    filas[11] = item.IdSucursal;
                    filas[12] = item.IdBodega;
                    tablaNCombo.Rows.Add(filas);
                    tablaNCombo.AcceptChanges();
                }
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString()); }
        }
        public void setUltaCmbcot()
        {
            try
            {
                TablaInfo = new DataTable();
                listacotinfo = busCot.Get_List_cotizacion_para_facturacion(param.IdEmpresa, IdSucursal, IdBodega,dtpFechaIni.Value,dtpFechaFin.Value);
                creaTablaCot(listacotinfo, TablaInfo);
                this.gridConsulta.DataSource = TablaInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void creaTablaFAC(List<fa_factura_Info> Lista, DataTable tablaNCombo)
        {
            try
            {
                tablaNCombo.Columns.Add("Sucursal");
                tablaNCombo.Columns.Add("Bodega");
                tablaNCombo.Columns.Add("Id");
                tablaNCombo.Columns.Add("Cliente");
                tablaNCombo.Columns.Add("Vendedor");
                tablaNCombo.Columns.Add("Fecha");
                tablaNCombo.Columns.Add("FechaVenc");
                tablaNCombo.Columns.Add("Observacion");
                tablaNCombo.Columns.Add("IVA");
                tablaNCombo.Columns.Add("SubTotal");
                tablaNCombo.Columns.Add("Total");
                tablaNCombo.Columns.Add("IdS");
                tablaNCombo.Columns.Add("IdB");
                tablaNCombo.Columns.Add("IdCliente");
                tablaNCombo.Columns.Add("IdVendedor");
                tablaNCombo.Columns.Add("vt_flete");
                tablaNCombo.Columns.Add("vt_interes");
                tablaNCombo.Columns.Add("vt_OtroValor1");
                tablaNCombo.Columns.Add("vt_OtroValor2");
                tablaNCombo.Columns.Add("vt_seguro");
                tablaNCombo.Columns.Add("Numero_Factura");

                foreach (var item in Lista)
                {
                    DataRow filas;
                    filas = tablaNCombo.NewRow();
                    filas[0] = item.Sucursal;
                    filas[1] = item.Bodega;
                    filas[2] = item.IdCbteVta;
                    filas[3] = item.Cliente;
                    filas[4] = item.Vendedor;
                    filas[5] = item.vt_fecha;
                    filas[6] = item.vt_fech_venc;
                    filas[7] = item.vt_Observacion;
                    filas[8] = item.IVA;
                    filas[9] = item.Subtotal;
                    filas[10] = item.Total;
                    filas[11] = item.IdSucursal;
                    filas[12] = item.IdBodega;
                    filas[13] = item.IdCliente;
                    filas[14] = item.IdVendedor;
                    filas[15] = item.vt_flete;
                    filas[16] = item.vt_interes;
                    filas[17] = item.vt_OtroValor1;
                    filas[18] = item.vt_OtroValor2;
                    filas[19] = item.vt_seguro;
                    filas[20] = item.vt_serie1+"-"+item.vt_serie2+"-"+item.vt_NumFactura;
                    tablaNCombo.Rows.Add(filas);
                    tablaNCombo.AcceptChanges();
                }
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString()); }
        }
        public void setUltaCmbFAC()
        {
            try
            {
                TablaInfo = new DataTable();
                listaFactinfo = busFact.Get_Lits_FacturaDEV(param.IdEmpresa, IdSucursal, IdBodega, dtpFechaIni.Value, dtpFechaFin.Value);
                creaTablaFAC(listaFactinfo, TablaInfo);
                Numero_Factura.Visible = true;
                this.gridConsulta.DataSource = TablaInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void frmFA_Documentos_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
            dtpFechaIni.Value = dtpFechaIni.Value.AddDays(-30);
            CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        public void CargarGrid()
        {
            try
            {
                if (TipoDoc == "COTIZ") { setUltaCmbcot(); } if (TipoDoc == "GUIR") { setUltaCmbGuir(); }
                if (TipoDoc == "FACT") { setUltaCmbFAC(); }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public int idcliente { get; set; }
        public int idvendedor { get; set; }

        private void gridViewConsulta_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Id = gridViewConsulta.GetFocusedRowCellValue(ID).ToString();
                if (TipoDoc == "FACT") {
                    idcliente  = Convert.ToInt32(gridViewConsulta.GetFocusedRowCellValue(IdCliente));
                    idvendedor = Convert.ToInt32(gridViewConsulta.GetFocusedRowCellValue(IdVendedor));

                    TOTAL = Convert.ToDecimal(gridViewConsulta.GetFocusedRowCellValue(Total));

                }

                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
