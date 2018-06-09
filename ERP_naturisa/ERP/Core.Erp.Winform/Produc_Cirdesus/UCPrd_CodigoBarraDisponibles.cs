using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class UCPrd_CodigoBarraDisponibles : UserControl
    {
        public UCPrd_CodigoBarraDisponibles()
        {
            try
            {
                  InitializeComponent();
                this.event_gridCtrlCodigoBarraDisp_DoubleClick += new delegate_gridCtrlCodigoBarraDisp_DoubleClick(UCPrd_CodigoBarraDisponibles_event_gridCtrlCodigoBarraDisp_DoubleClick);
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
               event_gridCtrlCodigoBarraDisp_DoubleClick(sender, e);
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_gridCtrlCodigoBarraDisp_DoubleClick(object sender, EventArgs e);
        public event delegate_gridCtrlCodigoBarraDisp_DoubleClick event_gridCtrlCodigoBarraDisp_DoubleClick;

        private void gridCtrlCodigoBarraDisp_DoubleClick(object sender, EventArgs e){}

        public void cargadatos(List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstInfo)
        {
            try
            { 

            
            
            }
            catch (Exception ex) 
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
                MessageBox.Show(ex.InnerException.ToString());
            }

        }
        
        
        
        

        
    }
}
