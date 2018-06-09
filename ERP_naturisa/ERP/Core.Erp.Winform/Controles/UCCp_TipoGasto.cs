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
using Core.Erp.Info.CuentasxPagar;

using Core.Erp.Business.CuentasxPagar;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCp_TipoGasto : UserControl
    {
        public cp_TipoGasto_Info _TipoServxProve { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public UCCp_TipoGasto()
        {
            try
            {
                InitializeComponent();
                cargar_Combo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
            
        }

        


        public cp_catalogo_Info get_Dato()
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

        public void set_TipoGasto(String codigo)
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


        private void cargar_Combo()
        {

            try
            {



                string TipodeCatalogo = "T_GASTOS";

                List<cp_catalogo_Info> catalogoInfoList = new List<cp_catalogo_Info>();
                cp_catalogo_Bus catalogoBus = new cp_catalogo_Bus();

                catalogoInfoList = new List<cp_catalogo_Info>();
                catalogoInfoList = catalogoBus.Get_List_catalogo(TipodeCatalogo);

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


        public cp_catalogo_Info _TipoGasto { get; set; }

        private void cmb_TipoGasto_SelectedIndexChanged(object sender, EventArgs e){}
    }
}
