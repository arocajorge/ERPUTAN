using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;



namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Sexo : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public UCGe_Sexo()
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


        public Cl_Sexo_Info _sexo { get; set; }


        public Cl_Sexo_Info get_sexo()
        {
            try
            {
                _sexo = (Cl_Sexo_Info)cmb_sexo.SelectedItem;
                return _sexo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
                return new Cl_Sexo_Info();
            }
        }


        public void cargar_combo()
        {
            try
            {
                tb_Catalogo_Bus CatBus = new tb_Catalogo_Bus();
                List<Cl_Sexo_Info> lsexo = new List<Cl_Sexo_Info>();
                lsexo = CatBus.Get_List_Sexo();
                this.cmb_sexo.DataSource = lsexo;
                this.cmb_sexo.DisplayMember = "descripcion";
                this.cmb_sexo.ValueMember = "codigo";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }


        public void set_sexo(string codSexo)
        {
            try
            {
                this.cmb_sexo.SelectedValue = codSexo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
            
        }

        private void cmb_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UCGe_Sexo_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combo();
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
