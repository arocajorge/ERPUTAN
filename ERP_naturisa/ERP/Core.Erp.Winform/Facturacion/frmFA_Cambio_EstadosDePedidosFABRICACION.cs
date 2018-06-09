using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Cambio_EstadosDePedidosFABRICACION : Form
    {
        UCIn_Sucursal_Bodega UC_Sucursal = new UCIn_Sucursal_Bodega();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public frmFa_Cambio_EstadosDePedidosFABRICACION()
        {
            try
            {
                InitializeComponent();
                UC_Sucursal.Dock = DockStyle.Fill;
                UC_Sucursal.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                this.pnl_SucBod.Controls.Add(UC_Sucursal);
                dtpFechaIni.Value = dtpFechaIni.Value.AddDays(-30);
                CargaGrid(dtpFechaIni.Value, dtpFechaFin.Value);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        BindingList<fa_pedido_Info> DataSource;


        private void CargaGrid(DateTime fecha_ini, DateTime fecha_fin)
        {
            try
            {

                List<fa_pedido_Info> lista_pedido = new List<fa_pedido_Info>();
                fa_pedido_Bus bus_pers = new fa_pedido_Bus();
                lista_pedido = bus_pers.Get_List_pedido(param.IdEmpresa, fecha_ini, fecha_fin, Convert.ToInt32(UC_Sucursal.cmb_sucursal.EditValue), Convert.ToInt32(UC_Sucursal.cmb_bodega.EditValue));//.FindAll(v => v.IdEstadoAprobacion == "N");
                DataSource = new BindingList<fa_pedido_Info>(lista_pedido);
                gridControlPedido.DataSource = DataSource;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
              CargaGrid(dtpFechaIni.Value, dtpFechaFin.Value);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmFa_Cambio_EstadosDePedidosFABRICACION_Load(object sender, EventArgs e)
        {

        }
    }
}
