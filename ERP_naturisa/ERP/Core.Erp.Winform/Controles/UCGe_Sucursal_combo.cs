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
    public partial class UCGe_Sucursal_combo : UserControl
    {
        #region Variables
        tb_Sucursal_Bus SucursalBus = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Info InfoSucursal = new tb_Sucursal_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_cmbsucursal_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbsucursal_EditValueChanged event_cmbsucursal_EditValueChanged;
        private int _IdSucursal;
        #endregion

        public UCGe_Sucursal_combo()
        {
            InitializeComponent();
            event_cmbsucursal_EditValueChanged += UCGe_Sucursal_combo_event_cmbsucursal_EditValueChanged;
        }

        void UCGe_Sucursal_combo_event_cmbsucursal_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cargar_combo()
        {
            try
            {
                listSucursal = new List<tb_Sucursal_Info>();
                listSucursal = SucursalBus.Get_List_Sucursal(param.IdEmpresa);
                cmbsucursal.Properties.DataSource = listSucursal;
                if (cmbsucursal.EditValue == null) cmbsucursal.EditValue = listSucursal.First().IdSucursal;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_SucursalInfo(int IdSucursal)
        {
            try
            {
                if (IdSucursal != 0)
                {
                    cmbsucursal.EditValue = IdSucursal;
                }
                else cmbsucursal.EditValue = null;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        public tb_Sucursal_Info get_SucursalInfo()
        {
            try
            {
                if (cmbsucursal.EditValue != null)
                {
                    InfoSucursal = listSucursal.FirstOrDefault(v => v.IdSucursal == Convert.ToInt32(cmbsucursal.EditValue));
                }
                else
                    InfoSucursal.IdSucursal = 0;
                return InfoSucursal;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_Sucursal_Info();
            }

        }

        public int Get_IdSucursal()
        {
            try
            {
                if (Convert.ToInt32(cmbsucursal.EditValue) != 0)
                {
                    InfoSucursal = listSucursal.FirstOrDefault(v => v.IdSucursal == Convert.ToInt32(cmbsucursal.EditValue));
                }
                return InfoSucursal.IdSucursal;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            }

        }

        private void UCGe_Sucursal_combo_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + "UCGe_Sucursal_combo";
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbsucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbsucursal_EditValueChanged(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        public void cargar_comboTodos()
        {
            try
            {
                listSucursal = new List<tb_Sucursal_Info>();
                listSucursal = SucursalBus.Get_List_Sucursal_Todos(param.IdEmpresa);
                cmbsucursal.Properties.DataSource = listSucursal;
                cmbsucursal.EditValue = listSucursal.First().IdSucursal;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }

        }


        public void Incializar_cmbsucursal()
        {
            try
            {
                cmbsucursal.EditValue = null;

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
