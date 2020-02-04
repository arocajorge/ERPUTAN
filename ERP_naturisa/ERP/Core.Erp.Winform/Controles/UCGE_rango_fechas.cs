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
    public partial class UCGe_rango_fechas : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public UCGe_rango_fechas()
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

        void compararFechas()
        {
            try
            {
                if (dtFechaInicio.Value >  dtfechaFin.Value)
                { MessageBox.Show("Por favor seleccione un rango de fechas válido.", "Sistemas"); dtfechaFin.Value = dtFechaInicio.Value; }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        
        }

        private void UCGe_rango_fechas_Load(object sender, EventArgs e)
        {

        }
        
    }
}
