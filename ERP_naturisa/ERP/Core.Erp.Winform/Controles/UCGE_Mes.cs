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
    public partial class UCGe_Mes : UserControl
    {
        public delegate void delegatecmbmes_SelectedIndexChanged(object sender, EventArgs e);
        public event delegatecmbmes_SelectedIndexChanged Event_cmbmes_SelectedIndexChanged;
        public tb_Mes_info _mesI = new tb_Mes_info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        tb_Mes_Bus Mesb = new tb_Mes_Bus();
        tb_Mes_info Mesi = new tb_Mes_info();
        List<tb_Mes_info> listMeses = new List<tb_Mes_info>();



        public UCGe_Mes()
        {
            try
            {
                InitializeComponent();
                this.Event_cmbmes_SelectedIndexChanged += new delegatecmbmes_SelectedIndexChanged(UCGE_Mes_Event_cmbmes_SelectedIndexChanged);                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void UCGE_Mes_Event_cmbmes_SelectedIndexChanged(object sender, EventArgs e){}

        private void UCGE_Mes_Load(object sender, EventArgs e)
        {
            try
            {
                if (cmbmes.Items.Count == 0)
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
                listMeses = Mesb.Get_List_Mes();
                cmbmes.DataSource = listMeses;
                cmbmes.DisplayMember = "sMes";
                cmbmes.ValueMember = "idMes";
            
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }      
        }

        public void set_indexmes(int idmes)
        {
            try
            {
                if (cmbmes.Items.Count == 0)
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
           
            cmbmes.SelectedValue = idmes;

        }

        public int get_idMes()
        {
            try
            {
                int IdMes=0;

                _mesI = (tb_Mes_info)cmbmes.SelectedItem;
                if (_mesI != null)
                {
                    IdMes = _mesI.idMes;
                }


                return IdMes;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                  return 0;
            }

        
        }

        public void set_enable_cmbmes(Boolean f)
        {
            try
            {
              this.cmbmes.Enabled = f;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cmbmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _mesI = (tb_Mes_info)cmbmes.SelectedItem;
                this.Event_cmbmes_SelectedIndexChanged(sender, e);
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
