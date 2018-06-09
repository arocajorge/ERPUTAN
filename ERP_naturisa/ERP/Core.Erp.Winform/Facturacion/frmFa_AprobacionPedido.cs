using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_AprobacionPedido : Form
    {
        public frmFa_AprobacionPedido()
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
        UCIn_Sucursal_Bodega UC_Sucursal = new UCIn_Sucursal_Bodega();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       
        private void frmFa_AprobacionPedido_Load(object sender, EventArgs e)
        {
            try
            {
                UC_Sucursal.Dock = DockStyle.Fill;
                UC_Sucursal.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                this.panel1.Controls.Add(UC_Sucursal);
                dtpFechaIni.Value = dtpFechaIni.Value.AddDays(-30);
                CargaGrid(dtpFechaIni.Value, dtpFechaFin.Value);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        BindingList<fa_pedido_Info> DataSource;

        private void CargaGrid( DateTime fecha_ini, DateTime fecha_fin)
        {
            try
            {
             
               List<fa_pedido_Info> lista_pedido = new List<fa_pedido_Info>();
               fa_pedido_Bus bus_pers = new fa_pedido_Bus();
               lista_pedido = bus_pers.Get_List_pedido(param.IdEmpresa, fecha_ini, fecha_fin, Convert.ToInt32(UC_Sucursal.cmb_sucursal.EditValue), Convert.ToInt32(UC_Sucursal.cmb_bodega.EditValue)).FindAll(v => v.IdEstadoAprobacion == "N");
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                     Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {

                dtpFechaFin.Focus();
                List<fa_pedido_Info> lst = new List<fa_pedido_Info>();
                foreach (var item in DataSource)
                {
                    if (item.Chek)
                        lst.Add(item);
                }
                fa_pedido_Bus bus = new fa_pedido_Bus();
                if (bus.ActualizarEstadoApro(lst, "A"))
                {
                    MessageBox.Show("Pedidos Aprobrados Con exito");
                }
                CargaGrid(dtpFechaIni.Value, dtpFechaFin.Value);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }
    }
}
