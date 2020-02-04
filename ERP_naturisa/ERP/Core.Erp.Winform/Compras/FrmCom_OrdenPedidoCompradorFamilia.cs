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
    using Core.Erp.Business.Compras;
    using Core.Erp.Info.Compras;

    public partial class FrmCom_OrdenPedidoCompradorFamilia : Form
    {
        #region Variables
        List<com_comprador_familia_Info> Lista;
        com_comprador_familia_Bus bus_det;
        public decimal IdOrdenPedido { get; set; }
        cl_parametrosGenerales_Bus param;
        #endregion

        public FrmCom_OrdenPedidoCompradorFamilia()
        {
            Lista = new List<com_comprador_familia_Info>();
            bus_det = new com_comprador_familia_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            InitializeComponent();
        }

        private void FrmCom_OrdenPedidoCompradorFamilia_Load(object sender, EventArgs e)
        {
            try
            {
                Lista = bus_det.GetListPorPedido(param.IdEmpresa, IdOrdenPedido);
                gc_consulta.DataSource = Lista;
            }
            catch (Exception)
            {
                
            }
        }
    }
}
