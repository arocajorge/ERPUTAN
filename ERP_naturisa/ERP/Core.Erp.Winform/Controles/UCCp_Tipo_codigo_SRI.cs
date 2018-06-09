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
    public partial class UCCp_Tipo_codigo_SRI : UserControl
    {
        public delegate void delegatecmb_tipo_cod_SRI_SelectedIndexChanged(object sender, EventArgs e);
        public event delegatecmb_tipo_cod_SRI_SelectedIndexChanged Event_cmb_tipo_cod_SRI_SelectedIndexChanged;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public UCCp_Tipo_codigo_SRI()
        {
            try
            {
                InitializeComponent();
                Event_cmb_tipo_cod_SRI_SelectedIndexChanged += new delegatecmb_tipo_cod_SRI_SelectedIndexChanged(UCGE_Aniof_Event_cmbanio_SelectedIndexChanged);

                cargar_Combo();
            
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
            
        }

        void UCGE_Aniof_Event_cmbanio_SelectedIndexChanged(object sender, EventArgs e){}


        public cp_codigo_SRI_tipo_Info _Tipo { get; set; }

        private void cargar_Combo()
        {
            try
            {

                cp_codigo_SRI_tipo_Bus CatBus = new cp_codigo_SRI_tipo_Bus();
                List<cp_codigo_SRI_tipo_Info> tipo_Codigo_SRI = new List<cp_codigo_SRI_tipo_Info>();


                tipo_Codigo_SRI = CatBus.Get_List_codigo_SRI_tipo();

                this.cmb_tipo_cod_SRI.DataSource = tipo_Codigo_SRI;
                this.cmb_tipo_cod_SRI.DisplayMember = "descripcion";
                this.cmb_tipo_cod_SRI.ValueMember = "IdTipoSRI";


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

     
        public cp_codigo_SRI_tipo_Info get_Dato()
        {

            try
            {

                _Tipo = (cp_codigo_SRI_tipo_Info)cmb_tipo_cod_SRI.SelectedItem;

                return _Tipo;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
                return new cp_codigo_SRI_tipo_Info();
            }

        }


        public void set_Tipo(String codigo)
        {
            try
            {
                cmb_tipo_cod_SRI.SelectedValue = codigo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
            
        }

        private void cmb_tipo_cod_SRI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _Tipo = (cp_codigo_SRI_tipo_Info)cmb_tipo_cod_SRI.SelectedItem;

                this.Event_cmb_tipo_cod_SRI_SelectedIndexChanged(sender, e);
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
