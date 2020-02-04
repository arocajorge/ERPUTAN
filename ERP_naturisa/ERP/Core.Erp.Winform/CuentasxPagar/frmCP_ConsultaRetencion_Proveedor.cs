using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_ConsultaRetencion_Proveedor : Form
    {
        //Bus
        cp_retencion_Bus BusReten = new cp_retencion_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        // BindingList
        BindingList<vwcp_orden_giro_sin_retenciones_Info> BindSinReten = new BindingList<vwcp_orden_giro_sin_retenciones_Info>();
     
        public vwcp_orden_giro_sin_retenciones_Info Info { get; set; }
 
        public frmCP_ConsultaRetencion_Proveedor()
        {
            try
            {
                    InitializeComponent();
                    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        List<vwcp_orden_giro_sin_retenciones_Info> ListinReten = new List<vwcp_orden_giro_sin_retenciones_Info>();

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargaGrid();
                
                if (ListinReten.Count == 0)
                {
                    MessageBox.Show("No existe Información para el periodo seleccionado", "Sistemas");
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cargaGrid()
        {
            try
            {
                ListinReten = BusReten.Get_List_cp_orden_giro_sin_retenciones(param.IdEmpresa
                    ,ucGe_Menu_Mantenimiento_x_usuario.fecha_desde
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
              
                    BindSinReten = new BindingList<vwcp_orden_giro_sin_retenciones_Info>(ListinReten);
                    gridControlConsRetProv.DataSource = BindSinReten;
                                             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void frmCP_ConsultaRetencion_Proveedor_Load(object sender, EventArgs e)
        {
            try
            {

                cargaGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gridViewConsRetProv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Info = (vwcp_orden_giro_sin_retenciones_Info)this.gridViewConsRetProv.GetFocusedRow();
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

     
    }
}
