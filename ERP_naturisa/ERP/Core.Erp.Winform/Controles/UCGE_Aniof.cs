using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Aniof : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public delegate void delegatecmbanio_SelectedIndexChanged(object sender, EventArgs e);
        public event delegatecmbanio_SelectedIndexChanged Event_cmbanio_SelectedIndexChanged;
        public ct_AnioFiscal_Info _oanioF = new ct_AnioFiscal_Info();

        List<ct_AnioFiscal_Info> listaAnioF = new List<ct_AnioFiscal_Info>();


        public UCGe_Aniof()
        {
            try
            {
                InitializeComponent();
                this.Event_cmbanio_SelectedIndexChanged += new delegatecmbanio_SelectedIndexChanged(UCGE_Aniof_Event_cmbanio_SelectedIndexChanged);                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void UCGE_Aniof_Event_cmbanio_SelectedIndexChanged(object sender, EventArgs e){}

       

        private void UCGE_Aniof_Load(object sender, EventArgs e)
        {
            try
            {
                if (cmbanio.Items.Count == 0)
                {
                    Carga_datos();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void Carga_datos()
        {
            try
            {
                ct_AnioFiscal_Info anioinfo = new ct_AnioFiscal_Info();
                ct_AnioFiscal_Bus aniobus = new ct_AnioFiscal_Bus();

                listaAnioF=aniobus.Get_list_AnioFiscal();

                cmbanio.DataSource = listaAnioF;
                cmbanio.DisplayMember = "IdanioFiscal";
                cmbanio.ValueMember = "IdanioFiscal"; 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


        public void set_enable_cmbanio(Boolean f)
        {
            try
            {
                 this.cmbanio.Enabled = f;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_indexanio(int idanio)
        {
            try
            {
                if (cmbanio.Items.Count == 0)
                {
                    Carga_datos();
                }

                cmbanio.SelectedValue = idanio;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        public int get_anio()
        {
            try
            {
                int anioF = 0;

                if (cmbanio.SelectedValue != null)
                { 
                    anioF =(int)cmbanio.SelectedValue;
                }

                return anioF;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " +this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            }           
        }

        private void cmbanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _oanioF = (ct_AnioFiscal_Info)cmbanio.SelectedItem;
                this.Event_cmbanio_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cmbanio_Click(object sender, EventArgs e){}
    }
}
