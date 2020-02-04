using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;


namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_ElementosAContabilizar : Form
    {
        public FrmIn_ElementosAContabilizar()
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
        BindingList<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info> DataSource;
        string MensajeError = "";

        
       
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        DateTime fechatransa;
        Boolean banderaParaContabilizar = true;
        in_movi_inve_x_ct_cbteCble_Bus inMovi_x_cbteCble_B = new in_movi_inve_x_ct_cbteCble_Bus();
               
        public Boolean Validar()
        {
            try
            {
                

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
            
        }
      
        private void frmIn_ElementosAContabilizar_Load(object sender, EventArgs e){}
        
    }
}
