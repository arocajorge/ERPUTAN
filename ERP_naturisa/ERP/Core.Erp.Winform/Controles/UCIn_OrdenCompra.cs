using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_OrdenCompra : UserControl
    {
        public UCIn_OrdenCompra()
        {
            try
            {
                InitializeComponent();
                this.Event_cmbOrdCompra_EditValueChanged += UCIn_OrdenCompra_Event_cmbOrdCompra_EditValueChanged;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void UCIn_OrdenCompra_Event_cmbOrdCompra_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public in_OrdenCompraLocal_Info _InfoOC { get; set; }

        
         public delegate void delegate_cmbOrdCompra_EditValueChanged(object sender, EventArgs e);
         public event delegate_cmbOrdCompra_EditValueChanged Event_cmbOrdCompra_EditValueChanged;

        
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void cargaCboOrdenes()
        {
            try
            {

                

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCIn_OrdenCompra_Load(object sender, EventArgs e)
        {
            try
            {
                  cargaCboOrdenes();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void setItem(decimal IdOrdenCompra)
        {
            try
            {
                cargaCboOrdenes();
                cmbOrdCompra.EditValue = Convert.ToString(IdOrdenCompra);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public in_OrdenCompraLocal_Info getitem()
        {
            try
            {
                _InfoOC.IdOrdenCompra = Convert.ToDecimal(cmbOrdCompra.EditValue);
                return _InfoOC;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new in_OrdenCompraLocal_Info();
            }

        }


        private void cmbOrdCompra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               
                _InfoOC = (in_OrdenCompraLocal_Info)cmbOrdCompra.Properties.View.GetFocusedRow();
                this.Event_cmbOrdCompra_EditValueChanged(sender, e);
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