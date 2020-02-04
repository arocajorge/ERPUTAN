using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Estado : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public UCGe_Estado()
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

        public Cl_Estado_Info _estado { get; set; }



        public Cl_Estado_Info get_estado()
        {
            try
            {
                _estado = (Cl_Estado_Info)cmb_estado.SelectedItem;

                return _estado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Cl_Estado_Info();
            }
        }



        private void cargar_Combo()
        {
            try
            {
                tb_Catalogo_Bus CatBus = new tb_Catalogo_Bus();
                List<Cl_Estado_Info> lEstado = new List<Cl_Estado_Info>();


                lEstado = CatBus.Get_List_Estado();
                this.cmb_estado.DataSource = lEstado;
                this.cmb_estado.DisplayMember = "descripcion";
                this.cmb_estado.ValueMember = "codigo";

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


        public void set_estado(String codigo)
        {
            try
            {
                cmb_estado.SelectedValue = codigo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }




        private void cmb_estado_SelectedIndexChanged(object sender, EventArgs e){}

        private void UCGe_Estado_Load(object sender, EventArgs e)
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
