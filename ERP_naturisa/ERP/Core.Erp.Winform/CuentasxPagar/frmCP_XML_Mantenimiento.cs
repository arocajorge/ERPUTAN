using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_XML_Mantenimiento : Form
    {
        #region Variables
        cp_XML_Documento_Info info;
        Cl_Enumeradores.eTipo_action Accion;
        #endregion

        public frmCP_XML_Mantenimiento()
        {
            InitializeComponent();
            info = new cp_XML_Documento_Info();
        }

        private void frmCP_XML_Mantenimiento_Load(object sender, EventArgs e)
        {
            SetAccion();
        }

        public void SetInfo(cp_XML_Documento_Info _info, Cl_Enumeradores.eTipo_action _Accion)
        {
            info = _info;
            Accion = _Accion;
        }

        private void SetAccion()
        {
            SetInfoInControls();
            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucGe_Menu_Superior_Mant1.btnAnular.Visible = false;
                    ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Visible = true;
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    ucGe_Menu_Superior_Mant1.btnAnular.Visible = true;
                    ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Visible = false;
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu_Superior_Mant1.btnAnular.Visible = false;
                    ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Visible = false;
                    break;
             }
        }

        private void SetInfoInControls()
        {
            try
            {
                txtID.Text = info.IdDocumento.ToString();
                txtTipo.Text = info.Tipo;
                txtCodDocumento.Text = info.CodDocumento;
                txtEstablecimiento.Text = info.Establecimiento;
                txtPuntoEmision.Text = info.PuntoEmision;
                txtNumDocumento.Text = info.NumeroDocumento;
                txtClaveAcceso.Text = info.ClaveAcceso;
                txtIdentificacion.Text = info.emi_Ruc;
                txtRazonSocial.Text = info.emi_RazonSocial;
                txtNombreComercial.Text = info.emi_NombreComercial;
                txtDireccion.Text = info.emi_DireccionMatriz;
                txtSubtotal0.Text = info.Subtotal0.ToString();
                txtSubtotalIVA.Text = info.SubtotalIVA.ToString();
                txtPorcentaje.Text = info.Porcentaje.ToString();
                txtIVA.Text = info.ValorIVA.ToString();
                txtTotal.Text = info.Total.ToString();
                deFecha.DateTime = Convert.ToDateTime(info.FechaEmision).Date;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
