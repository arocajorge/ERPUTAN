using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Proveedor_Vista_Previa : DevExpress.XtraEditors.XtraForm
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_proveedor_Info InfoProvee = new cp_proveedor_Info();
        cp_proveedor_Bus bus = new cp_proveedor_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion
       
        public frmCP_Proveedor_Vista_Previa()
        {
            InitializeComponent();
        }

        public void set_ProveedorInfo(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                InfoProvee = bus.Get_Info_ProveedorVistaPrevia(param.IdEmpresa, IdProveedor);
                txtidproveedor.Text = Convert.ToString(InfoProvee.IdProveedor);
                txtcentrocosto.Text = InfoProvee.IdCentroCosoto;
                txtchqgirar.Text = InfoProvee.pr_girar_cheque_a;
                txtclaseproveedor.Text = Convert.ToString(InfoProvee.IdClaseProveedor);
                txtcodigo.Text = InfoProvee.pr_codigo;
                txtcodigo101.Text = InfoProvee.nom_codigoSRI_101;
                txtcomentario.Text = InfoProvee.comentario;
                txtcontacto.Text = InfoProvee.contacto;
                txtctacbleantic.Text = InfoProvee.IdCtaCble_Anticipo;
                txtctacblecxp.Text = InfoProvee.IdCtaCble_CXP;
                txtctacblegasto.Text = InfoProvee.IdCtaCble_Gasto;
                txtdireccion.Text = InfoProvee.Persona_Info.pe_direccion;
                txtdocumento.Text = InfoProvee.Persona_Info.pe_cedulaRuc;
                txtgasto.Text = InfoProvee.IdTipoGasto;
                txtice.Text = InfoProvee.nom_codigoSRI_ICE;
                txtidentificacioncred.Text = InfoProvee.nom_Credito_Predeter;
                txtidpersona.Text = Convert.ToString(InfoProvee.Persona_Info.IdPersona);
                txtnomproveedor.Text = InfoProvee.pr_nombre;
                txtresponsable.Text = InfoProvee.responsable;
                txtservicetype.Text = InfoProvee.IdTipoServicio;
                txttelefono.Text = InfoProvee.Persona_Info.pe_telefonoCasa;
                txtubicacion.Text = InfoProvee.IdCiudad;
                txtrazonsocial.Text = InfoProvee.Persona_Info.pe_razonSocial;
                chk_contEspecial.Checked = (InfoProvee.pr_contribuyenteEspecial == "S") ? true : false;
                txtfax.Text = InfoProvee.Persona_Info.pe_fax;
                txtmail.Text = InfoProvee.Persona_Info.pe_correo;
                txtdiasconcedidos.Text = Convert.ToString(InfoProvee.pr_plazo);
                if (InfoProvee.pr_estado == "I")
                {
                    lblAnulado.Visible = true;
                }
                else
                {
                    lblAnulado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("En Construcción, Gracias por su comprensión");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

     
    }
}