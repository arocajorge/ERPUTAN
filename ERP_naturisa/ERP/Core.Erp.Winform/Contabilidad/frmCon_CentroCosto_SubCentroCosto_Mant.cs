using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_CentroCosto_SubCentroCosto_Mant : Form
    {

        frmCon_CentroCosto_SubCentroCosto_Mant_Handler frmHandler = new frmCon_CentroCosto_SubCentroCosto_Mant_Handler();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing;
        public Cl_Enumeradores.eTipo_action enu { get; set; }
        public ct_centro_costo_sub_centro_costo_Info SetInfo { get; set; }

        public frmCon_CentroCosto_SubCentroCosto_Mant()
        {
            try
            {
                InitializeComponent();

                frmHandler.ucGe_Menu = this.ucGe_Menu;
                frmHandler.ckbActivo = this.ckbActivo;
                frmHandler.lblAnulado = this.lblAnulado;
                frmHandler.txtCentroCosto = this.txtCentroCosto;
                frmHandler.txtIdSubCentro = this.txtIdSubCentro;
                frmHandler.cmb_ctacble = this.cmb_ctacble;
                frmHandler.cmbCentroCosto = this.cmbCentroCosto;
                
                ucGe_Menu.event_btnGuardar_Click += frmHandler.ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += frmHandler.ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnlimpiar_Click += frmHandler.ucGe_Menu_event_btnlimpiar_Click;
                ucGe_Menu.event_btnAnular_Click += frmHandler.ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnSalir_Click += frmHandler.ucGe_Menu_event_btnSalir_Click;
                this.event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing += frmHandler.frmCon_CentroCosto_SubCentroCosto_Mant_event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing;
                this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing);
                this.Load += new System.EventHandler(frmHandler.frmCon_CentroCosto_SubCentroCosto_Mant_Load);
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
         }

        public void frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        

        private void frmCon_CentroCosto_SubCentroCosto_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                frmHandler.Set_frmChildren(this);
                frmHandler.Set_frmParent(this.MdiParent);
                frmHandler.enu = this.enu;
                frmHandler.SetInfo = this.SetInfo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        
    }
}
