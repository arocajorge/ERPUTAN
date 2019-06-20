using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Compras
{
    using Core.Erp.Info.General;
    using Core.Erp.Business.General;
    using Core.Erp.Info.Compras;
    using Core.Erp.Business.Compras;

    public partial class FrmCom_CotizacionConsulta : Form
    {
        #region Variables
        public com_CotizacionPedido_Info info { get; set; }
        com_CotizacionPedido_Bus bus_pedido;
        cl_parametrosGenerales_Bus param;
        BindingList<com_CotizacionPedido_Info> blst;
        public string Cargo { get; set; }
        #endregion

        public FrmCom_CotizacionConsulta()
        {
            bus_pedido = new com_CotizacionPedido_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            blst = new BindingList<com_CotizacionPedido_Info>();
            InitializeComponent();
        }

        private void FrmCom_CotizacionConsulta_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                blst= new BindingList<com_CotizacionPedido_Info>(bus_pedido.GetListAprobar(param.IdEmpresa,param.IdUsuario,Cargo));
                gc_consulta.DataSource = blst;
            }
            catch (Exception)
            {
            }
        }

        private void gv_consulta_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                com_CotizacionPedido_Info row = (com_CotizacionPedido_Info)gv_consulta.GetFocusedRow();
                if (row == null)
                    return;

                info = row;
                this.Close();
            }
            catch (Exception)
            {
                
            }
        }

        private void cmb_imagen_Click(object sender, EventArgs e)
        {
            try
            {
                com_CotizacionPedido_Info row = (com_CotizacionPedido_Info)gv_consulta.GetFocusedRow();
                if (row == null)
                    return;

                info = row;
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
