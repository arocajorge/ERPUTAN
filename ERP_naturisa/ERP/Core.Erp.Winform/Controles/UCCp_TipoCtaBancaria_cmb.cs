using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;


namespace Core.Erp.Winform.Controles
{
    public partial class UCCp_TipoCtaBancaria_cmb : UserControl
    {
        public cp_TipoGasto_Info _TipoServxProve { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_catalogo_Info _TipoGasto = new cp_catalogo_Info();
        string IdTipoCatalogo = "T_TIP_CTA_ACRE";

        public UCCp_TipoCtaBancaria_cmb()
        {
            InitializeComponent();
            cargar_Combo();
        }

        private void cmb_TipoGasto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public cp_catalogo_Info Get_Info_Catalogo()
        {
            try
            {
                _TipoGasto = (cp_catalogo_Info)cmb_TipoGasto.SelectedItem;//cp_catalogo_Info
                return _TipoGasto;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new cp_catalogo_Info();
            }
        }


        public void Set_IdCatalogo(String codigo)
        {
            try
            {
                cmb_TipoGasto.SelectedValue = codigo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

      


        public void cargar_Combo()
        {

            try
            {
                List<cp_catalogo_Info> catalogoInfoList = new List<cp_catalogo_Info>();
                cp_catalogo_Bus catalogoBus = new cp_catalogo_Bus();

                catalogoInfoList = new List<cp_catalogo_Info>();
                catalogoInfoList = catalogoBus.Get_List_catalogo(IdTipoCatalogo);

                this.cmb_TipoGasto.DataSource = catalogoInfoList;
                this.cmb_TipoGasto.DisplayMember = "Nombre";
                this.cmb_TipoGasto.ValueMember = "Idcatalogo";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void UCCp_Catalogo_x_Tipo_cmb_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                
            }
        }

    }
}
