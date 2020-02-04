using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.General
{

    public partial class FrmGe_Empresa : Form
    {
        UCGe_Tabla_Empresa UCTEm = new UCGe_Tabla_Empresa();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Cl_Parametros_info DatosGenerales { get; set; }




        public FrmGe_Empresa()
        {

            try
            {
                InitializeComponent();

            if (DatosGenerales == null)
            {
                DatosGenerales = new Cl_Parametros_info(); 
            }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void frmGe_Empresa_Load(object sender, EventArgs e)
        {
            try
            {
                this.splitContainer.Panel1.Controls.Clear();
                UCGe_Tabla_Empresa UCTE = new UCGe_Tabla_Empresa();
                UCTE.Dock = DockStyle.Fill;
                splitContainer.Panel1.Controls.Add(UCTE);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void ucGe_Tabla_Empresa1_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Mant_Empresa1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
