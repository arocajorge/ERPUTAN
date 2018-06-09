using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Winform.General;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Winform.Roles;
using Core.Erp.Winform.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Nuevo_Beneficiario : Form
    {
        #region Variables
        tb_persona_tipo_Bus bus_TipoPersona = new tb_persona_tipo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        #endregion
        
        public frmCP_Nuevo_Beneficiario()
        {
            try
            {
              InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmCP_Nuevo_Beneficiario_Load(object sender, EventArgs e)
        {
            try
            {
                List<tb_persona_tipo_Info> info_TipoPersona = new List<tb_persona_tipo_Info>();
                info_TipoPersona = bus_TipoPersona.Get_List_persona_tipo();
                cmbPersonaTipo.Properties.DataSource = info_TipoPersona;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         

        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            try
            {
                tb_persona_tipo_Info obj_pertip = (tb_persona_tipo_Info)cmbPersonaTipo.Properties.View.GetFocusedRow();
                if (obj_pertip.IdTipo_Persona == "CLIENTE")
                {
                    frmFa_Clientes_Mant frmCliente = new frmFa_Clientes_Mant();
                    frmCliente.ShowDialog();
                }

                if (obj_pertip.IdTipo_Persona == "EMPLEA")
                {
                    frmRo_Empleado_Mant frmEmpleado = new frmRo_Empleado_Mant();
                    frmEmpleado.ShowDialog();
                }

                if (obj_pertip.IdTipo_Persona == "PERSONA")
                {
                    frmGe_MantPersona frmPersona = new frmGe_MantPersona();
                    frmPersona.ShowDialog();
                }

                if (obj_pertip.IdTipo_Persona == "PROVEE")
                {
                    frmCP_Proveedor_Mant frmProveedor = new frmCP_Proveedor_Mant();
                    frmProveedor.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
