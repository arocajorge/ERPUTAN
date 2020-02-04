using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General ;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Tabla_Empresa : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Empresa_Info Empi = new tb_Empresa_Info();
        List<tb_Empresa_Info> listEm = new List<tb_Empresa_Info>();
        public Cl_Parametros_info DatosGenerales { get; set; }

        public UCGe_Tabla_Empresa()
        {
            InitializeComponent();
            try
            {
                if (DatosGenerales == null)
                {
                    DatosGenerales = new Cl_Parametros_info();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            

            dgEmpresa.AutoGenerateColumns = false;
            Cargar_Empresas();

        }


        private void Cargar_Empresas()
        {
            try
            {
                tb_Empresa_Bus Em = new tb_Empresa_Bus();
                tb_Empresa_Info inf = new tb_Empresa_Info();
                listEm = Em.Get_List_Empresa();
                this.dgEmpresa.DataSource = listEm;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_empresas();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void cargar_empresas()
        {
            try
            {
                tb_Empresa_Bus Em = new tb_Empresa_Bus();
                listEm = Em.Get_List_Empresa();
                tb_Empresa_Info inf = new tb_Empresa_Info();
                this.dgEmpresa.DataSource = listEm;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                
                UCGe_Mant_Empresa UCEm = new UCGe_Mant_Empresa();
                frmCon_Mantenimiento frM = new frmCon_Mantenimiento();
                frM.Height = UCEm.Height + 150;
                frM.Width = UCEm.Width + 20;
                UCEm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frM.Controls.Add(UCEm);
                frM.ShowDialog();

                cargar_empresas();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dgEmpresa.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciones una fila" , "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                foreach (DataGridViewRow row in this.dgEmpresa.SelectedRows)
                {
                    //Customer cust = row.DataBoundItem as Customer;
                    tb_Empresa_Info Emprei = row.DataBoundItem as tb_Empresa_Info;

                    if (Emprei != null)
                    {
                        UCGe_Mant_Empresa UCEm = new UCGe_Mant_Empresa();
                        frmCon_Mantenimiento frM = new frmCon_Mantenimiento();
                        frM.Height = UCEm.Height + 150;
                        frM.Width = UCEm.Width + 20;
                        UCEm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        UCEm.set_empresa(Emprei);
                        frM.Controls.Add(UCEm);
                        frM.ShowDialog();

                        cargar_empresas();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgEmpresa.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                foreach (DataGridViewRow row in this.dgEmpresa.SelectedRows)
                {
                    //Customer cust = row.DataBoundItem as Customer;
                    tb_Empresa_Info Emprei = row.DataBoundItem as tb_Empresa_Info;

                    if (Emprei != null)
                    {

                        UCGe_Mant_Empresa UCEm = new UCGe_Mant_Empresa();
                        frmCon_Mantenimiento frM = new frmCon_Mantenimiento();
                        frM.Height = UCEm.Height + 150;
                        frM.Width = UCEm.Width + 20;
                        UCEm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                        UCEm.set_empresa(Emprei);
                        UCEm.set_enable_btn_Grabar(false);

                        frM.Controls.Add(UCEm);
                        frM.ShowDialog();

                        cargar_empresas();
                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }   

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e){}

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e){}

        private void dgEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e){}

      
    }

}