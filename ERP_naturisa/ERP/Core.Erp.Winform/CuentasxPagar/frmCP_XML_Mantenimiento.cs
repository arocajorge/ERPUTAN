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
        cp_codigo_SRI_Bus bus_codigoSRI;
        BindingList<cp_XML_Documento_Retencion_Info> blst;
        cp_XML_Documento_Retencion_Bus bus_det;
        List<cp_codigo_SRI_Info> lst_codigoSRI;
        cl_parametrosGenerales_Bus param;
        cp_XML_Documento_Bus bus_xml;
        cp_XML_DocumentoDet_Bus bus_xml_det;
        #endregion

        public frmCP_XML_Mantenimiento()
        {
            InitializeComponent();
            info = new cp_XML_Documento_Info();
            bus_codigoSRI = new cp_codigo_SRI_Bus();
            lst_codigoSRI = new List<cp_codigo_SRI_Info>();
            blst = new BindingList<cp_XML_Documento_Retencion_Info>();
            bus_det = new cp_XML_Documento_Retencion_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            bus_xml = new cp_XML_Documento_Bus();
            bus_xml_det = new cp_XML_DocumentoDet_Bus();
        }

        private void frmCP_XML_Mantenimiento_Load(object sender, EventArgs e)
        {
            blst = new BindingList<cp_XML_Documento_Retencion_Info>();
            gcRetencion.DataSource = blst;
            SetAccion();
        }

        public void SetInfo(cp_XML_Documento_Info _info, Cl_Enumeradores.eTipo_action _Accion)
        {
            info = _info;
            Accion = _Accion;
        }

        private void SetAccion()
        {
            CargarCombos();
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
                txtContribuyente.Text = info.emi_ContribuyenteEspecial;
                txtRetEstablecimiento.Text = info.ret_Establecimiento;
                txtRetPuntoEmision.Text = info.ret_PuntoEmision;
                txtRetNumeroDocumento.Text = info.ret_NumeroDocumento;
                txtRetAutorizacion.Text = info.ret_NumeroAutorizacion;
                deRetFechaAutorizacion.DateTime = info.ret_FechaAutorizacion ?? DateTime.Now.Date;
                deRetFecha.DateTime = info.ret_Fecha ?? DateTime.Now.Date;

                deRetFecha.DateTime = Convert.ToDateTime(info.FechaEmision).Date;
                blst = new BindingList<cp_XML_Documento_Retencion_Info>(bus_det.GetList(param.IdEmpresa, info.IdDocumento));
                gcRetencion.DataSource = blst;

                if (!string.IsNullOrEmpty(info.ret_NumeroDocumento))
                    btnEliminarRetencion.Visible = true;
                else
                    btnEliminarRetencion.Visible = false;
                

                gcDetalleXML.DataSource = bus_xml_det.GetList(param.IdEmpresa, info.IdDocumento);
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

        private void gvRetencion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                cp_XML_Documento_Retencion_Info row = (cp_XML_Documento_Retencion_Info)gvRetencion.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (colCodigoSRI == e.Column)
                {
                    if (e.Value != null)
                    {
                        var codigo = lst_codigoSRI.Where(q => q.IdCodigo_SRI == row.IdCodigo_SRI).FirstOrDefault();
                        if (codigo != null)
                        {
                            row.re_baseRetencion = (codigo.IdTipoSRI == "COD_RET_FUE" ? (info.Subtotal0 + info.SubtotalIVA) : info.ValorIVA) ?? 0;
                            row.re_Codigo_impuesto = codigo.codigoSRI;
                            row.re_Porcen_retencion = codigo.co_porRetencion;
                            row.re_tipoRet = (codigo.IdTipoSRI == "COD_RET_FUE" ? "RTF" : "IVA");
                            row.re_valor_retencion = Math.Round(row.re_baseRetencion * (row.re_Porcen_retencion / 100),2,MidpointRounding.AwayFromZero);
                        }
                    }
                }
                if (colBaseImponible == e.Column)
                {
                    if (e.Value != null)
                    {
                        var codigo = lst_codigoSRI.Where(q => q.IdCodigo_SRI == row.IdCodigo_SRI).FirstOrDefault();
                        if (codigo != null)
                        {
                            row.re_valor_retencion = Math.Round(row.re_baseRetencion * (row.re_Porcen_retencion / 100),2,MidpointRounding.AwayFromZero);
                        }
                    }
                }
                gcRetencion.Refresh();
            }
            catch (Exception)
            {
                
            }
        }

        private void CargarCombos()
        {
            try
            {
                txtEstablecimiento.Text = param.InfoSucursal.Su_CodigoEstablecimiento;

                lst_codigoSRI = bus_codigoSRI.Get_List_codigo_SRI_IvaRet(param.IdEmpresa);
                cmbCodigoSRI.DataSource = lst_codigoSRI;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void GetInfo()
        {
            try
            {
                txtTipo.Focus();
                info.ret_Fecha = deRetFecha.DateTime.Date;
                info.ret_CodDocumentoTipo = "RETEN";
                info.ret_Establecimiento = txtRetEstablecimiento.Text;
                info.ret_PuntoEmision = txtRetPuntoEmision.Text;
                info.lstRetencion = new List<cp_XML_Documento_Retencion_Info>(blst);
            }
            catch (Exception)
            {
                
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (blst.Count == 0)
                {
                    MessageBox.Show("No ha ingresado códigos de retención para el documento",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                if (txtTipo.Text != "FACTURA")
                {
                    MessageBox.Show("No se puede grabar una retención para el documento "+txtTipo.Text,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                if (!String.IsNullOrEmpty(txtRetAutorizacion.Text))
                {
                    MessageBox.Show("La retención se encuentra autorizada y no puede ser modificada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                } 
                GetInfo();
                if (bus_xml.ModificarDB(info))
                {
                    MessageBox.Show("Registro modificado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (MessageBox.Show("Generar XML", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        GenerarXML();
                    }
                    this.Close();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btn_Generar_XML_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(info.ret_NumeroDocumento))
                {
                    GenerarXML();    
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void GenerarXML()
        {
            try
            {
                string MensajeError = string.Empty;
                if (bus_xml.Generacion_xml_SRI(param.IdEmpresa, info.IdDocumento, ref MensajeError))
                {
                    MessageBox.Show("XML generado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show(MensajeError == "" ? "No se ha podido generar el XML" : MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus_xml.AnularDB(info))
                {
                    MessageBox.Show("Registro anulado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void gvRetencion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                gvRetencion.DeleteSelectedRows();
            }
        }

        private void btnEliminarRetencion_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus_xml.EliminarRetencion(info.IdEmpresa, info.IdDocumento))
                {
                    txtRetAutorizacion.Text = "";
                    txtRetNumeroDocumento.Text = "";
                    blst = new BindingList<cp_XML_Documento_Retencion_Info>();
                    gcRetencion.DataSource = null;
                    gcRetencion.DataSource = blst;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
