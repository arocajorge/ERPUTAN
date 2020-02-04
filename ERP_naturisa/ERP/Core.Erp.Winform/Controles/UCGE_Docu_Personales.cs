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
    public partial class UCGe_Docu_Personales : UserControl
    {

        public delegate void Delegate_cmb_Docum_perso_SelectedValueChanged(object sender, EventArgs e);
        public event Delegate_cmb_Docum_perso_SelectedValueChanged event_cmb_Docum_perso_SelectedValueChanged;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<Cl_TipoDoc_Personales_Info> lEstado = new List<Cl_TipoDoc_Personales_Info>();
        tb_Catalogo_Bus CatBus = new tb_Catalogo_Bus();

        public Cl_TipoDoc_Personales_Info _TipoDocPer { get; set; }

        public Cl_TipoDoc_Personales_Info get_TipoDoc_Personales()
        {
            try
            {
                _TipoDocPer = (Cl_TipoDoc_Personales_Info)cmb_Docum_perso.SelectedItem;
                return _TipoDocPer;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Cl_TipoDoc_Personales_Info();
            }
        }



        public UCGe_Docu_Personales()
        {
            try
            {
                InitializeComponent();               
                event_cmb_Docum_perso_SelectedValueChanged += UCGE_Docu_Personales_event_cmb_Docum_perso_SelectedValueChanged;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
  
        }
        

        void UCGE_Docu_Personales_event_cmb_Docum_perso_SelectedValueChanged(object sender, EventArgs e){}

        private void UCGE_Docu_Personales_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_Combo();
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }

        


        public void set_TipoDoc_Personales(String codigo)
        {
            try
            {

                cmb_Docum_perso.SelectedValue = codigo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public int SelectedIndex()
        {
            try
            {
                return cmb_Docum_perso.SelectedIndex; 

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            }
        }
        public string SelectedValue()
        {
            return cmb_Docum_perso.SelectedValue.ToString();
        }

        private void cargar_Combo()
        {
            try
            {
                CatBus = new tb_Catalogo_Bus();
                lEstado = new List<Cl_TipoDoc_Personales_Info>();
                lEstado = CatBus.Get_List_TipoDoc_Personales();
                this.cmb_Docum_perso.DataSource = lEstado;
                this.cmb_Docum_perso.DisplayMember = "descripcion";
                this.cmb_Docum_perso.ValueMember = "codigo";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
       

        private void cmb_Docum_perso_SelectedIndexChanged(object sender, EventArgs e){}
        


        private void cmb_Docum_perso_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
               event_cmb_Docum_perso_SelectedValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cmb_Docum_perso_Click(object sender, EventArgs e)
        {
           
        }
    }
}
