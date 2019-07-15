using Core.Erp.Business.Compras;
using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Compras;

namespace Core.Erp.Winform.Compras
{
    public partial class frmCom_OrdenPedidoPlantillaAsignar : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_OrdenPedidoPlantilla_Bus bus_Orden;
        public com_OrdenPedidoPlantilla_Info info_plantilla { get; set; } 
        #endregion

        public frmCom_OrdenPedidoPlantillaAsignar()
        {
            InitializeComponent();
            bus_Orden = new com_OrdenPedidoPlantilla_Bus();
        }

        private void frmCom_OrdenPedidoPlantillaAsignar_Load(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Buscar()
        {
            try
            {
                var lst = bus_Orden.GetList(param.IdEmpresa, false);
                gc_Consulta.DataSource = lst;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmb_Imagen_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                info_plantilla = (com_OrdenPedidoPlantilla_Info)gv_Consulta.GetFocusedRow();
                this.Close();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
