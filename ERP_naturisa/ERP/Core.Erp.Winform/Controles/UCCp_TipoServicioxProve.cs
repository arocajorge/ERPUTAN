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
    public partial class UCCp_TipoServicioxProve : UserControl
    {
        public UCCp_TipoServicioxProve()
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



        public cp_TipoServicioxProvee_Info _TipoServxProve { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public cp_TipoServicioxProvee_Info get_Dato()
        {

            try
            {
                _TipoServxProve = (cp_TipoServicioxProvee_Info)cmb_tipoServicioxProve.SelectedItem;
                return _TipoServxProve;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
                return new cp_TipoServicioxProvee_Info();
            }

        }


        public void set_TipoServixProvee(String codigo)
        {
            try
            {
                cmb_tipoServicioxProve.SelectedValue = codigo;
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
                cp_catalogo_Bus CatBus = new cp_catalogo_Bus();
                List<cp_TipoServicioxProvee_Info> lEstado = new List<cp_TipoServicioxProvee_Info>();
                List<cp_catalogo_Info> lEstado1 = new List<cp_catalogo_Info>();


                lEstado1 = CatBus.Get_List_catalogo("T_SERVI");

                foreach (var item in lEstado1)
                {
                    lEstado.Add(new cp_TipoServicioxProvee_Info(item.IdCatalogo, item.Nombre));
                }

                this.cmb_tipoServicioxProve.DataSource = lEstado;
                this.cmb_tipoServicioxProve.DisplayMember = "descripcion";
                this.cmb_tipoServicioxProve.ValueMember = "codigo";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        private void cmb_tipoServicioxProve_SelectedIndexChanged(object sender, EventArgs e){}

    }
}
