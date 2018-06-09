using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxCobrar;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxcMantenimiento_Cheques_Multa : Form
    {
        public frmCxcMantenimiento_Cheques_Multa()
        {
            try
            {
             InitializeComponent();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<ba_Banco_Cuenta_Info> ListaBanco = new List<ba_Banco_Cuenta_Info>();
        ba_Banco_Cuenta_Bus BusBanco = new ba_Banco_Cuenta_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cxc_cobro_Bus Buscxc = new cxc_cobro_Bus();

        public Boolean protestar { get; set; }
        public decimal idCobro { get; set; }
        public int idSucursal { get; set; }


        private void frmCo_cxcMantenimiento_Cheques_Multa_Load(object sender, EventArgs e)
        {
            try
            {
                ListaBanco = BusBanco.Get_list_Banco_Cuenta(param.IdEmpresa);

                //ultraComboEditorCtaBanco.DataSource = ListaBanco;
                //ultraComboEditorCtaBanco.ValueMember = "IdBanco";
                //ultraComboEditorCtaBanco.DisplayMember = "ba_descripcion";
                //ultraComboEditorCtaBanco.SelectedIndex = 0;

                cmbCtaBanco.Properties.DataSource = ListaBanco;
                cmbCtaBanco.Properties.DisplayMember = "ba_descripcion";
                cmbCtaBanco.Properties.ValueMember = "IdBanco";

                var item = ListaBanco.FirstOrDefault();
                cmbCtaBanco.EditValue = item.IdBanco;

                gridControl.DataSource = Buscxc.Get_List_cobros_x_depositados(param.IdEmpresa, idSucursal, idCobro);
                if(Buscxc.Get_List_cobros_x_depositados(param.IdEmpresa, idSucursal, idCobro).ToList().Count()==0){
                    btnProtestar.Enabled=false;
                    lblProtestar.Visible = true;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnProtestar_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                protestar = true;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnu_salir_Click(object sender, EventArgs e)
        {
            try
            {
                protestar = false;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
