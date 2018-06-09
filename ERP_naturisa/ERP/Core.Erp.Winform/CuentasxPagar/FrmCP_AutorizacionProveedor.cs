using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_AutorizacionProveedor : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public cp_proveedor_Autorizacion_Info OtroFrm_Aut_I { get; set; }


        public frmCP_AutorizacionProveedor(decimal IdProveedor)
        {
            try
            {
                InitializeComponent();
          
                uccP_Proveedor_Autoriza1.set_IdProveedor(IdProveedor);
                uccP_Proveedor_Autoriza1.event_gridView_AutoriProvee_DoubleClick += uccP_Proveedor_Autoriza1_event_gridView_AutoriProvee_DoubleClick;
                uccP_Proveedor_Autoriza1.event_gridView_AutoriProvee_KeyDown += uccP_Proveedor_Autoriza1_event_gridView_AutoriProvee_KeyDown;
                uccP_Proveedor_Autoriza1.event_btn_Seleccionar_Click += uccP_Proveedor_Autoriza1_event_btn_Seleccionar_Click;
                uccP_Proveedor_Autoriza1.event_btn_Salir_Click += uccP_Proveedor_Autoriza1_event_btn_Salir_Click;
                uccP_Proveedor_Autoriza1.event_btn_Nuevo_Click += uccP_Proveedor_Autoriza1_event_btn_Nuevo_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void uccP_Proveedor_Autoriza1_event_btn_Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void uccP_Proveedor_Autoriza1_event_btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void uccP_Proveedor_Autoriza1_event_btn_Seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                OtroFrm_Aut_I = uccP_Proveedor_Autoriza1.OtroFrm_Aut_I;
                
                this.Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void uccP_Proveedor_Autoriza1_event_gridView_AutoriProvee_KeyDown(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void uccP_Proveedor_Autoriza1_event_gridView_AutoriProvee_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OtroFrm_Aut_I=uccP_Proveedor_Autoriza1.OtroFrm_Aut_I;
                
                this.Close();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        private void FrmCP_AutorizacionProveedor_Load(object sender, EventArgs e)
        {

        }
     
    }
}
