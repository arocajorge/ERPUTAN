using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_CausalesdeModificacio_Anulacion : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_catalogo_Bus BusCatalogo = new fa_catalogo_Bus();
        public frmFa_CausalesdeModificacio_Anulacion()
        {
            try
            {
                InitializeComponent();
                cmbMotivo.Properties.DataSource = BusCatalogo.Get_List_catalogo(2);
                RetornodelId += frmFa_CausalesdeModificacio_Anulacion_RetornodelId;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void frmFa_CausalesdeModificacio_Anulacion_RetornodelId(string TipoAnulacion){}

        public delegate void delegate_RetortaTIpoModificcacio(string TipoAnulacion);
        public event delegate_RetortaTIpoModificcacio RetornodelId;
        private void frmFa_CausalesdeModificacio_Anulacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                RetornodelId(cmbMotivo.EditValue.ToString());
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
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

        private void frmFa_CausalesdeModificacio_Anulacion_Load(object sender, EventArgs e)
        {

        }

    }
}
