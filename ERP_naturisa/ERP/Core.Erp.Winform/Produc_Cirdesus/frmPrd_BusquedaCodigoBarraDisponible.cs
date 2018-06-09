using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_BusquedaCodigoBarraDisponible : Form
    {
        public FrmPrd_BusquedaCodigoBarraDisponible()
        {
            try
            {
                  InitializeComponent();
                this.event_gridCtrlCodigoBarraDisp_DoubleClick += new delegate_gridCtrlCodigoBarraDisp_DoubleClick(UCPrd_CodigoBarraDisponibles_event_gridCtrlCodigoBarraDisp_DoubleClick);
                this.event_frmPrd_BusquedaCodigoBarraDisponible_FormClosing += new delegate_frmPrd_BusquedaCodigoBarraDisponible_FormClosing(frmPrd_BusquedaCodigoBarraDisponible_event_frmPrd_BusquedaCodigoBarraDisponible_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void frmPrd_BusquedaCodigoBarraDisponible_event_frmPrd_BusquedaCodigoBarraDisponible_FormClosing(object sender, EventArgs e)
        {
            try
            {
                event_frmPrd_BusquedaCodigoBarraDisponible_FormClosing(Info, e);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCPrd_CodigoBarraDisponibles_event_gridCtrlCodigoBarraDisp_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                 event_gridCtrlCodigoBarraDisp_DoubleClick(Info, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_gridCtrlCodigoBarraDisp_DoubleClick(object sender, EventArgs e);
        public event delegate_gridCtrlCodigoBarraDisp_DoubleClick event_gridCtrlCodigoBarraDisp_DoubleClick;
        public in_movi_inve_detalle_x_Producto_CusCider_Info Info { get; set; }

        private void gridCtrlCodigoBarraDisp_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                obtieneinfo();
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void cargadatos(List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstInfo)
        {
            try
            {
                gridCtrlCodigoBarraDisp.DataSource = LstInfo;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }

        }
        void obtieneinfo()
        {
            try
            {
                in_movi_inve_detalle_x_Producto_CusCider_Info Info = null;

                Info = (in_movi_inve_detalle_x_Producto_CusCider_Info)gridVwCodigoBarraDisp.GetFocusedRow();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); 
            }
        }

        private void gridVwCodigoBarraDisp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                   obtieneinfo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridCtrlCodigoBarraDisp_Enter(object sender, EventArgs e)
        {
            try
            {
               obtieneinfo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridVwCodigoBarraDisp_DoubleClick(object sender, EventArgs e)
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

        private void frmPrd_BusquedaCodigoBarraDisponible_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               //obtieneinfo();
                //Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
 
        }

        public delegate void delegate_frmPrd_BusquedaCodigoBarraDisponible_FormClosing(object sender, EventArgs e);
        public event delegate_frmPrd_BusquedaCodigoBarraDisponible_FormClosing event_frmPrd_BusquedaCodigoBarraDisponible_FormClosing;
       
    }
}
