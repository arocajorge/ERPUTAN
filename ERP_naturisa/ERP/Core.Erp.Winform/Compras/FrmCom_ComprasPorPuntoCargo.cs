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
    using Core.Erp.Info.Compras;
    using Core.Erp.Business.Compras;
    using Core.Erp.Info.General;
    using Core.Erp.Business.General;

    public partial class FrmCom_ComprasPorPuntoCargo : Form
    {
        #region Variables
        public int IdPunto_cargo { get; set; }
        BindingList<com_ordencompra_local_det_Info> blst;
        com_ordencompra_local_det_Bus bus_det;
        cl_parametrosGenerales_Bus param;
        #endregion

        public FrmCom_ComprasPorPuntoCargo()
        {
            blst = new BindingList<com_ordencompra_local_det_Info>();
            bus_det = new com_ordencompra_local_det_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            InitializeComponent();
        }

        private void FrmCom_ComprasPorPuntoCargo_Load(object sender, EventArgs e)
        {
            try
            {
                blst = new BindingList<com_ordencompra_local_det_Info>(bus_det.GetListComprasPorPuntoCargo(param.IdEmpresa, IdPunto_cargo));
                gc_consulta.DataSource = blst;
            }
            catch (Exception)
            {
                
            }
        }
    }
}
