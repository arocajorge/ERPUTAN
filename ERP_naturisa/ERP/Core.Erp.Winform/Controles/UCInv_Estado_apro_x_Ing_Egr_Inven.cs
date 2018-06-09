using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Inventario;


namespace Core.Erp.Winform.Controles
{
    public partial class UCInv_Estado_apro_x_Ing_Egr_Inven : UserControl
    {
        public UCInv_Estado_apro_x_Ing_Egr_Inven()
        {
            InitializeComponent();

            event_cmbEstado_Apro_x_ing_Egr_Inven_EditValueChanged += UCInv_Estado_apro_x_Ing_Egr_Inven_event_cmbEstado_Apro_x_ing_Egr_Inven_EditValueChanged;
            event_cmbEstado_Apro_x_ing_Egr_Inven_Validated += UCInv_Estado_apro_x_Ing_Egr_Inven_event_cmbEstado_Apro_x_ing_Egr_Inven_Validated;
            event_cmbEstado_Apro_x_ing_Egr_Inven_Validating += UCInv_Estado_apro_x_Ing_Egr_Inven_event_cmbEstado_Apro_x_ing_Egr_Inven_Validating;

        }

        void UCInv_Estado_apro_x_Ing_Egr_Inven_event_cmbEstado_Apro_x_ing_Egr_Inven_Validating(object sender, CancelEventArgs e)
        {
            
        }

        void UCInv_Estado_apro_x_Ing_Egr_Inven_event_cmbEstado_Apro_x_ing_Egr_Inven_Validated(object sender, EventArgs e)
        {
            
        }

        void UCInv_Estado_apro_x_Ing_Egr_Inven_event_cmbEstado_Apro_x_ing_Egr_Inven_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbEstado_Apro_x_ing_Egr_Inven_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbEstado_Apro_x_ing_Egr_Inven_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        List<in_Ing_Egr_Inven_estado_apro_Info> lstestado_apro = new List<in_Ing_Egr_Inven_estado_apro_Info>();
        in_Ing_Egr_Inven_estado_apro_Info Infoestado_apro_Info = new in_Ing_Egr_Inven_estado_apro_Info();
        in_Ing_Egr_Inven_estado_apro_Bus UniB = new in_Ing_Egr_Inven_estado_apro_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_Parametro_Info Info_Patam_x_Inv = new in_Parametro_Info();
        in_Parametro_Bus busInfo = new in_Parametro_Bus();

        public delegate void delegate_cmbEstado_Apro_x_ing_Egr_Inven_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbEstado_Apro_x_ing_Egr_Inven_EditValueChanged event_cmbEstado_Apro_x_ing_Egr_Inven_EditValueChanged;

        public delegate void delegate_cmbEstado_Apro_x_ing_Egr_Inven_EditValueChanged_Validated(object sender, EventArgs e);
        public event delegate_cmbEstado_Apro_x_ing_Egr_Inven_EditValueChanged_Validated event_cmbEstado_Apro_x_ing_Egr_Inven_Validated;

        public delegate void delegate_cmbEstado_Apro_x_ing_Egr_Inven_Validating(object sender, CancelEventArgs e);
        public event delegate_cmbEstado_Apro_x_ing_Egr_Inven_Validating event_cmbEstado_Apro_x_ing_Egr_Inven_Validating;

        public void CargarCombo()
        {
            try
            {
                Info_Patam_x_Inv = new in_Parametro_Info();
                Info_Patam_x_Inv = busInfo.Get_Info_Parametro(param.IdEmpresa);

                lstestado_apro = new List<in_Ing_Egr_Inven_estado_apro_Info>();
                lstestado_apro = UniB.Get_List_Ing_Egr_Inven_estado_apro();
                cmbEstado_Apro_x_ing_Egr_Inven.Properties.DataSource = lstestado_apro;
                cmbEstado_Apro_x_ing_Egr_Inven.EditValue = Info_Patam_x_Inv.IdEstadoAproba_x_Ing;

             
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public in_Ing_Egr_Inven_estado_apro_Info get_Info()
        {
            try
            {
                Infoestado_apro_Info = lstestado_apro.FirstOrDefault(v => v.IdEstadoAproba == Convert.ToString(cmbEstado_Apro_x_ing_Egr_Inven.EditValue));
                return Infoestado_apro_Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new in_Ing_Egr_Inven_estado_apro_Info();
            }
        }

        public string get_IdEstadoAproba()
        {
            try
            {
                Infoestado_apro_Info = lstestado_apro.FirstOrDefault(v => v.IdEstadoAproba == Convert.ToString(cmbEstado_Apro_x_ing_Egr_Inven.EditValue));
                return Infoestado_apro_Info.IdEstadoAproba;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }
        }

        public void Inicializar_combo()
        {
            try
            {
                cmbEstado_Apro_x_ing_Egr_Inven.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Info(string IdEstadoAproba)
        {
            try
            {
                cmbEstado_Apro_x_ing_Egr_Inven.EditValue = IdEstadoAproba;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbEstado_Apro_x_ing_Egr_Inven_Validated_1(object sender, EventArgs e)
        {
            try
            {
                event_cmbEstado_Apro_x_ing_Egr_Inven_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbEstado_Apro_x_ing_Egr_Inven_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbEstado_Apro_x_ing_Egr_Inven_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCInv_Estado_apro_x_Ing_Egr_Inven_Load(object sender, EventArgs e)
        {

            try
            {
                CargarCombo();
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
