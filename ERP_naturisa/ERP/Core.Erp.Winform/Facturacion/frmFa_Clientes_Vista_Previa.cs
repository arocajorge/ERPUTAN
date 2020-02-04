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
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Clientes_Vista_Previa : DevExpress.XtraEditors.XtraForm
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_Cliente_Info InfoClient = new fa_Cliente_Info();
        fa_Cliente_Bus BusClient = new fa_Cliente_Bus();
        #endregion

        public frmFa_Clientes_Vista_Previa()
        {
            InitializeComponent();
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
            }
        }

        public void set_ClienteInfo(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                InfoClient = BusClient.Get_Info_Cliente(IdEmpresa, IdCliente);
                txtapellido.Text = InfoClient.Persona_Info.pe_apellido;
                txtcentrcostant.Text = InfoClient.IdCentroCosto_Anticipo;
                txtcentrocostcxc.Text = InfoClient.IdCentroCosto_CXC;
                txtcodigo.Text = InfoClient.Codigo;
                txtctacbleant.Text = InfoClient.IdCtaCble_Anti;
                txtctacblecxc.Text = InfoClient.IdCtaCble_cxc;
                txtdireccion.Text = InfoClient.Persona_Info.pe_direccion;
                txtdocumento.Text = InfoClient.Persona_Info.pe_cedulaRuc;
                txtfax.Text = InfoClient.cl_fax;
                txtidpersona.Text = Convert.ToString(InfoClient.IdPersona);
                txtidcliente.Text =  Convert.ToString(InfoClient.IdCliente);
                txtmail.Text = InfoClient.Mail_Principal;
                txtnomcliente.Text = InfoClient.Nombre_Cliente;
                txtobservacion.Text = InfoClient.cl_observacion;
                txtrazonsocial.Text = InfoClient.Persona_Info.pe_razonSocial;
                txtsucursal.Text = InfoClient.nomSucursal;
                txttelefono.Text = InfoClient.Persona_Info.pe_telefonoCasa;
                txtubicacion.Text = InfoClient.Ubicacion;
                txtdesc.Text = Convert.ToString(InfoClient.cl_porcentaje_descuento);
                txtcredasig.Text = Convert.ToString(InfoClient.cl_Cupo);
                txtcredmax.Text = Convert.ToString(InfoClient.cl_plazo);
                if (InfoClient.Estado == "I")
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
            }
        }

    }
}