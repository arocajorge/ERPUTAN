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
    public partial class UCGe_NaturalezaPersona : UserControl
    {
        public delegate void delegate_cmb_naturalezaPersona_SelectedIndexChanged(object sender, EventArgs e);
        public event delegate_cmb_naturalezaPersona_SelectedIndexChanged Event_cmb_naturalezaPersona_SelectedIndexChanged;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public UCGe_NaturalezaPersona()
        {
            try
            {
                InitializeComponent();
                this.Event_cmb_naturalezaPersona_SelectedIndexChanged += new delegate_cmb_naturalezaPersona_SelectedIndexChanged(UCGE_NaturalezaPersona_Event_cmb_naturalezaPersona_SelectedIndexChanged);                        
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }



        void UCGE_NaturalezaPersona_Event_cmb_naturalezaPersona_SelectedIndexChanged(object sender, EventArgs e){}
        
        public Cl_NaturalezaPerso _Naturaleza { get; set; }
        
        public Cl_NaturalezaPerso get_Naturaleza()
        {
            try
            {
                _Naturaleza = (Cl_NaturalezaPerso)cmb_naturalezaPersona.SelectedItem;
                return _Naturaleza;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Cl_NaturalezaPerso();
            }
        }


        public string get_Id_Naturaleza()
        {
            try
            {
                _Naturaleza = (Cl_NaturalezaPerso)cmb_naturalezaPersona.SelectedItem;
                return _Naturaleza.codigo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }
        }




        public void cargar_Combo()
        {
            try
            {

                tb_Catalogo_Bus CatBus = new tb_Catalogo_Bus();
                List<Cl_NaturalezaPerso> lEstado = new List<Cl_NaturalezaPerso>();


                lEstado = CatBus.Get_List_NaturalezaPer();


                this.cmb_naturalezaPersona.DataSource = lEstado;
                this.cmb_naturalezaPersona.DisplayMember = "descripcion";
                this.cmb_naturalezaPersona.ValueMember = "codigo";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Naturaleza(string IdNaturaleza)
        {
            try
            {
                 cmb_naturalezaPersona.SelectedValue = IdNaturaleza;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_naturalezaPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 this.Event_cmb_naturalezaPersona_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }



        }

        private void UCGe_NaturalezaPersona_Load(object sender, EventArgs e)
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


    }
}
