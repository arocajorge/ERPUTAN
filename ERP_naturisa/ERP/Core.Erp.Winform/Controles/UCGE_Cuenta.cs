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
    public partial class UCGe_Cuenta : UserControl
    {
        public delegate void delegatecmbcuenta_SelectedIndexChanged(object sender, EventArgs e);
        public event delegatecmbcuenta_SelectedIndexChanged Event_cmbcuenta_SelectedIndexChanged;
        public ct_Plancta_Info _PlanCtaInfo = new ct_Plancta_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";

        public UCGe_Cuenta()
        {
            try
            {
                InitializeComponent();
                this.Event_cmbcuenta_SelectedIndexChanged += new delegatecmbcuenta_SelectedIndexChanged(UCGE_Cuenta_Event_cmbcuenta_SelectedIndexChanged);                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }           
        }

        public void UCGE_Cuenta_Event_cmbcuenta_SelectedIndexChanged(object sender, EventArgs e){}


       

        public void Carga_datos()
        {
            try
            {
                ct_Plancta_Bus _PlanCtaB = new ct_Plancta_Bus();
                ct_Plancta_Info _PlanCtaI = new ct_Plancta_Info();
                cmbcuenta.DataSource = _PlanCtaB.Get_List_Plan_ctaPadre(1, ref MensajeError);
                cmbcuenta.DisplayMember = "pc_Cuenta2";
                cmbcuenta.ValueMember = "IdCtaCble";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public ct_Plancta_Info get_current_PlanctaInfo()
        {
            try
            {
              return _PlanCtaInfo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Plancta_Info();
            }

        }
        

        public void set_enable_cta(Boolean f)
        {
            try
            {
                 this.cmbcuenta.Enabled = f;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        


        public void set_indexcta(string cta )
        {

            try
            {
                if (cmbcuenta.Items.Count == 0)
                {
                    Carga_datos();
                }

                cmbcuenta.SelectedValue = cta;
                _PlanCtaInfo = (ct_Plancta_Info)cmbcuenta.SelectedItem;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
     

        }

        public string get_cta()
        {
            try
            {
                _PlanCtaInfo = (ct_Plancta_Info)cmbcuenta.SelectedItem;
                return _PlanCtaInfo.pc_Cuenta.ToString();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
              return null;
            }

        }

        public string get_PlanCtaInfo(string idCtaPadre)
        {
            try
            {
                string cuenta = "";
                return cuenta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                    return null;
            }

        }

        private void UCGE_Cuenta_Load(object sender, EventArgs e)
        {
            try
            {
                if (cmbcuenta.Items.Count == 0)
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

        private void cmbcuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _PlanCtaInfo = (ct_Plancta_Info)cmbcuenta.SelectedItem;
                this.Event_cmbcuenta_SelectedIndexChanged(sender, e);
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
