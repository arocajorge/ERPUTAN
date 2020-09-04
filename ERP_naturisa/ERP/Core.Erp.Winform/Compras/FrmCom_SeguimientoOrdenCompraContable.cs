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
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_SeguimientoOrdenCompraContable : Form
    {
        #region Variables
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        com_SeguimientoOrdenCompraContable_Bus busSeguimiento;
        tb_Sucursal_Bus busSucursal;
        cl_parametrosGenerales_Bus param;
        #endregion

        #region Constructor
        public FrmCom_SeguimientoOrdenCompraContable()
        {
            InitializeComponent();
            busSeguimiento = new com_SeguimientoOrdenCompraContable_Bus();
            busSucursal = new tb_Sucursal_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
        }
        #endregion

        #region Eventos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void FrmCom_SeguimientoOrdenCompraContable_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                if (IdOrdenCompra != 0)
                    Buscar();
            }
            catch (Exception)
            {
                
            }
        }
        #endregion
        
        #region Metodos
        private void CargarCombos()
        {
            cmbSucursalOC.Properties.DataSource = busSucursal.Get_List_Sucursal(param.IdEmpresa);
        }

        private void Buscar()
        {
            try
            {
                if (cmbSucursalOC.EditValue != null)
                    IdSucursal = Convert.ToInt32(cmbSucursalOC.EditValue);
                else
                    IdSucursal = 0;

                if (!string.IsNullOrEmpty(txtOC.Text))
                    IdOrdenCompra = Convert.ToDecimal(txtOC.Text);
                else
                    IdOrdenCompra = 0;

                gcDetalle.DataSource = busSeguimiento.GetList(param.IdEmpresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception)
            {
            }
        }
        #endregion
    }
}
