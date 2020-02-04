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
    public partial class UCGe_EstadoCivil : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public UCGe_EstadoCivil()
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


        public Cl_EstadoCivil_Info _estadoCivil { get; set; }


        public Cl_EstadoCivil_Info get_estadoCivil()
        {
           try
            {
                _estadoCivil = (Cl_EstadoCivil_Info)cmb_estadoCivil.SelectedItem;
                 return _estadoCivil;
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Cl_EstadoCivil_Info();
            }
        }


        public void cargar_Combo()
        {

            try
            {

                tb_Catalogo_Bus CatBus = new tb_Catalogo_Bus();
                List<Cl_EstadoCivil_Info> lEstado = new List<Cl_EstadoCivil_Info>();


                lEstado = CatBus.Get_List_EstadoCivil();

                this.cmb_estadoCivil.DataSource = lEstado;
                this.cmb_estadoCivil.DisplayMember = "descripcion";
                this.cmb_estadoCivil.ValueMember = "codigo";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


        public void set_estadoCivil(string idEstadoCivil)
        {
            try
            {
                cmb_estadoCivil.SelectedValue = idEstadoCivil;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        private void cmb_estadoCivil_SelectedIndexChanged(object sender, EventArgs e){}

        private void UCGe_EstadoCivil_Load(object sender, EventArgs e)
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
