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
    public partial class UCGe_FechaCorte : UserControl
    {
        public delegate void Delegate_dTFechaCorte_ValueChanged(object sender, EventArgs e);
        public event Delegate_dTFechaCorte_ValueChanged event_dTFechaCorte_ValueChanged;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void Delegate_btn_generar_Click(object sender, EventArgs e);
        public event Delegate_btn_generar_Click event_btn_generar_Click;



        public UCGe_FechaCorte()
        {
            try
            {
                InitializeComponent();
                event_btn_generar_Click += UCGe_FechaCorte_event_btn_generar_Click;
                event_dTFechaCorte_ValueChanged += UCGe_FechaCorte_event_dTFechaCorte_ValueChanged;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void UCGe_FechaCorte_event_dTFechaCorte_ValueChanged(object sender, EventArgs e){}
        void UCGe_FechaCorte_event_btn_generar_Click(object sender, EventArgs e){}

        

        
        public void btn_generar_Click(object sender, EventArgs e)
        {
            try
            {
                  event_btn_generar_Click(sender, e);
            }
            catch (Exception ex) 
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
 
        }


        
        private void dTFechaCorte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                 dTFechaCorte_ValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }     
        }
    }
}
