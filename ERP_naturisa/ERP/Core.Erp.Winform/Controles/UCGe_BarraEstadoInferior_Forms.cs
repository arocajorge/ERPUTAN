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
    public partial class UCGe_BarraEstadoInferior_Forms : UserControl
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();



        public UCGe_BarraEstadoInferior_Forms()
        {
            InitializeComponent();

            
            this.Dock = DockStyle.Bottom;

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreSys_Click(object sender, EventArgs e)
        {

        }

        private void UCGe_BarraEstadoInferior_Forms_Load(object sender, EventArgs e)
        {
            try
            {
                lblusuario.Text = "Usuario:" + param.IdUsuario;
                lblempresa.Text = "Empresa:" + "[" + param.IdEmpresa + "] " + param.InfoEmpresa.em_nombre;
                lblNombreSys.Text = param.Nombre_sistema;
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
