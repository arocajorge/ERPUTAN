using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.General;



namespace Core.Erp.Reportes.Controles
{
    public partial class UCFa_Cliente_Combo : UserControl
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public UCFa_Cliente_Combo()
        {
            InitializeComponent();
        }

        public void Cargar_cliente()
        {
            try
            {
                fa_Cliente_Bus BusCliente = new fa_Cliente_Bus();

               cmb_cliente.Properties.DataSource= BusCliente.Get_List_Clientes(param.IdEmpresa);


            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
