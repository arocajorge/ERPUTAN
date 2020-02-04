using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Confirmacion_NumRetencion : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public frmCP_Confirmacion_NumRetencion()
        {
            InitializeComponent();
        }

        public string serie = "";
        public string NAutorizacion = "";
        public string NumRetencion = "";

        private void frmCP_Confirmacion_NumRetencion_Load(object sender, EventArgs e)
        {
            try
            {
                //UC_NumRetencion.Obtener_Ult_Documento_no_usado(param.IdEmpresa, param.IdSucursal, 1, "RETEN");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }
             
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                serie = Convert.ToString(UC_NumRetencion.txe_Serie.EditValue);
                //NAutorizacion = UC_NumRetencion.txtAutorizacion.Text;
                NumRetencion = Convert.ToString(UC_NumRetencion.txtNumDoc.EditValue);

                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                     
        }

    }
}
