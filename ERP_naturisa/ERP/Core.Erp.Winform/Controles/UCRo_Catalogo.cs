using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCRo_Catalogo : UserControl
    {
        List<ro_Catalogo_Info> lista = new List<ro_Catalogo_Info>();

        public UCRo_Catalogo()
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

        public ro_Catalogo_Info CodCatalogo = new ro_Catalogo_Info();

        public ro_Catalogo_Info get_Catalogo()
        {
            try
            {

                ro_Catalogo_Info infoCatalogo = new ro_Catalogo_Info();

                infoCatalogo = (ro_Catalogo_Info)cmb_catalogo.SelectedItem;

                return infoCatalogo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ro_Catalogo_Info();
            }

        }


        public string  get_CodCatalogo()
        {

            try
            {
                string codCatalogo;

                codCatalogo = Convert.ToString(cmb_catalogo.SelectedValue);

                return codCatalogo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }

        }

        public void set_cargar_combo_x_tipo(int  CodTipoCatalogo)
        {
            try
            {
                ro_Catalogo_Bus CatBus = new ro_Catalogo_Bus();

                lista = CatBus.Get_List_Catalogo_x_Tipo(CodTipoCatalogo);

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
