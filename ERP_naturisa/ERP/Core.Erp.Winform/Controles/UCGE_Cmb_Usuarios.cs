using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Cmb_Usuarios : UserControl
    {
        public UCGe_Cmb_Usuarios()
        {
            try
            {
                 InitializeComponent();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        private void ultraCmbE_responsable_ValueChanged(object sender, EventArgs e){}

        private void UCGE_Cmb_Usuarios_Load(object sender, EventArgs e){}

        private void cmbUsuario_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
