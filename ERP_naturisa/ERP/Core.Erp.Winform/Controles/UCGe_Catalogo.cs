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
    public partial class UCGe_Catalogo : UserControl
    {
        public UCGe_Catalogo()
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


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public tb_Catalogo_Info CodCatalogo= new tb_Catalogo_Info();

        public tb_Catalogo_Info get_Catalogo()
        {
            try
            {
                CodCatalogo.CodCatalogo = Convert.ToString(cmb_catalogo.SelectedValue);

                return CodCatalogo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_Catalogo_Info();
            }
        }

        public void set_cargar_combo_x_tipo(Cl_Enumeradores.TipoCatalogo Tipo)
        {
            try
            {              

                tb_Catalogo_Bus CatBus = new tb_Catalogo_Bus();
                List<tb_Catalogo_Info> lista = new List<tb_Catalogo_Info>();

                

                lista = CatBus.Get_List_Catalogo(Tipo);

                this.cmb_catalogo.DataSource = lista;
                this.cmb_catalogo.DisplayMember = "ca_descripcion";
                this.cmb_catalogo.ValueMember = "CodCatalogo";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        public void set_item(string codigo)
        {
            try
            {
                  this.cmb_catalogo.SelectedValue = codigo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cmb_catalogo_SelectedIndexChanged(object sender, EventArgs e){}

    }
}
