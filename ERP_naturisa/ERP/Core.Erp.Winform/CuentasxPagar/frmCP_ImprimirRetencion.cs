using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;


using Cus.Erp.Reports.Naturisa.CuentasxPagar;
using Core.Erp.Reportes.CuentasxPagar;

using System.IO;
using System.Xml;
using System.Xml.Serialization;


using Core.Erp.Reportes.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_ImprimirRetencion : Form
    {
        string mensaje = "";
        string TipoDocumento = "";

        public delegate void delegate_frmCP_ImprimirRetencion_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_ImprimirRetencion_FormClosing event_frmCP_ImprimirRetencion_FormClosing;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_retencion_Bus Bus_Retencion = new cp_retencion_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_orden_giro_Info Info_OrdenGiro = new cp_orden_giro_Info();
        cp_retencion_Info Info_Retencion = new cp_retencion_Info();

        public frmCP_ImprimirRetencion()
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

        private void frmCP_ImprimirRetencion_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void set_numRetencion(string serie, string numero,cp_orden_giro_Info[] OG_info, decimal idRentecion, int IdTipoCbte_Ogiro, string IdTipoDocumento)
        {

            try
            {
                Info_Retencion.IdRetencion = idRentecion;
                Info_Retencion.IdTipoCbte_Ogiro = IdTipoCbte_Ogiro;

                UC_Docu.txe_Serie.EditValue = serie;
                UC_Docu.txtNumDoc.EditValue = numero;

                TipoDocumento = IdTipoDocumento;

                foreach (var item in OG_info)
                {
                    Info_OrdenGiro = item;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_ImprimirRetencion_Load(object sender, EventArgs e)
        {
            try
            {

                Info_Retencion = Bus_Retencion.Get_Info_retencion(param.IdEmpresa, Info_OrdenGiro.IdCbteCble_Ogiro, Info_OrdenGiro.IdTipoCbte_Ogiro);

                if (Info_Retencion.re_EstaImpresa == "S")
                {
                    this.Text = "Reimpresión de Retención ";
                    UC_Docu.Enabled = false; UC_Docu.ForeColor = Color.Black;
                    dtp_fechaEmision.Enabled = false; dtp_fechaEmision.CalendarForeColor = Color.Black;
                    dtp_fechaEmision.Value = Info_Retencion.fecha;
                }
                else
                {

                    this.Text = "Impresión de Retención y Actualización de Talonario de Retención.";
                }

                event_frmCP_ImprimirRetencion_FormClosing += frmCP_ImprimirRetencion_event_frmCP_ImprimirRetencion_FormClosing;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCP_ImprimirRetencion_event_frmCP_ImprimirRetencion_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private Boolean txtNumRetencion_Validating()
        {
            try
            {
                string msg = "";

                
                if (Bus_Retencion.VericarNumRetencion(Convert.ToString(UC_Docu.txtNumDoc.EditValue),
               Convert.ToString(UC_Docu.txe_Serie.EditValue),
               param.IdEmpresa, Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdCbteCble_Ogiro, Info_OrdenGiro.IdTipoCbte_Ogiro, ref msg) == true)
                {
                    MessageBox.Show("Ya existe dicho #Retención ingresado en Base, Con la Orden de Giro #: " + msg + ", Cambie el #Retención", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    UC_Docu.txtNumDoc.Focus(); return false;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {

                if (Info_Retencion.re_EstaImpresa == "S")
                {
                    Imprimir_Reporte_Ret(Info_Retencion.re_EstaImpresa);
                }
                else
                {
                    if (this.UC_Docu.txtNumDoc.Text == "" || Convert.ToDecimal(this.UC_Docu.txtNumDoc.EditValue) == 0)
                    {
                        MessageBox.Show("Por favor ingrese el #Retención para poder Continuar  ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show("Esta Seguro que desea Imprimir La Retención #:" + UC_Docu.txtNumDoc.Text, "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Imprimir_Reporte_Ret(Info_Retencion.re_EstaImpresa);
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Imprimir_Reporte_Ret(string EstaImpresa)
        {
            try
            {
                XCXP_Rpt015_rpt reportes = new XCXP_Rpt015_rpt();

                string RootReporte = System.IO.Path.GetTempPath() + "reporteRetencionComprobante..repx";
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus busDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus();
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Info InfoDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Info();

                InfoDoc_x_Emp = busDoc_x_Emp.get_DisenioRpt(Info_Retencion.IdEmpresa, Cl_Enumeradores.eTipoDocumento_Talonario.RETEN.ToString());

                if (InfoDoc_x_Emp.IdEmpresa != 0 && InfoDoc_x_Emp.File_Disenio_Reporte != null)
                {
                    if (EstaImpresa == "N")
                    {

                        if (!txtNumRetencion_Validating())
                        {
                            Actualizar_Retencion_y_Documento_Talonario();

                            File.WriteAllBytes(RootReporte, InfoDoc_x_Emp.File_Disenio_Reporte);
                            reportes.LoadLayout(RootReporte);

                            reportes.set_parametros(Convert.ToInt32(Info_Retencion.IdEmpresa_Ogiro), Convert.ToDecimal(Info_Retencion.IdCbteCble_Ogiro), Convert.ToInt32(Info_Retencion.IdTipoCbte_Ogiro));
                            reportes.RequestParameters = true;
                            reportes.ShowPreviewDialog();
                        }

                    }
                    else
                    {
                        File.WriteAllBytes(RootReporte, InfoDoc_x_Emp.File_Disenio_Reporte);
                        reportes.LoadLayout(RootReporte);

                        reportes.set_parametros(Convert.ToInt32(Info_Retencion.IdEmpresa_Ogiro), Convert.ToDecimal(Info_Retencion.IdCbteCble_Ogiro), Convert.ToInt32(Info_Retencion.IdTipoCbte_Ogiro));
                        reportes.RequestParameters = true;
                        reportes.ShowPreviewDialog();


                    }
                }
                else
                {

                    if (EstaImpresa == "N")
                    {

                        if (!txtNumRetencion_Validating())
                        {
                            Actualizar_Retencion_y_Documento_Talonario();

                            XCXP_Rpt023_Rpt rpt = new XCXP_Rpt023_Rpt();
                            rpt.RequestParameters = true;

                            int IdEmpresa = 0;
                            decimal IdOrdenPago = 0;

                            IdEmpresa = param.IdEmpresa;
                            IdOrdenPago = Convert.ToDecimal(Info_Retencion.IdCbteCble_Ogiro);

                            rpt.Parameters["idOrdenGiro"].Value = IdOrdenPago;
                            rpt.Print();
                            this.Close();
                        }
                    }
                    else
                    {
                        XCXP_Rpt023_Rpt rpt = new XCXP_Rpt023_Rpt();
                        rpt.RequestParameters = true;

                        int IdEmpresa = 0;
                        decimal IdOrdenPago = 0;

                        IdEmpresa = param.IdEmpresa;
                        IdOrdenPago = Convert.ToDecimal(Info_Retencion.IdCbteCble_Ogiro);

                        rpt.Parameters["idOrdenGiro"].Value = IdOrdenPago;
                        rpt.Print();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Actualizar_Retencion_y_Documento_Talonario()
        {
            try
            {
                Info_Retencion.NumRetencion = Convert.ToString(UC_Docu.txtNumDoc.EditValue);
                string[] serie = Convert.ToString(UC_Docu.txe_Serie.EditValue).Split('-');
                Info_Retencion.serie1 = serie[0];
                Info_Retencion.serie2 = serie[1];
                Info_Retencion.CodDocumentoTipo = UC_Docu.IdTipoDocumento.ToString();
                Info_Retencion.EsDocumentoElectronico = Convert.ToBoolean(UC_Docu.Get_Info_Talonario().es_Documento_electronico);

                Info_Retencion.IdUsuarioUltMod = param.IdUsuario;
                Info_Retencion.Fecha_UltMod = param.Fecha_Transac;
                Info_Retencion.fecha = dtp_fechaEmision.Value;

                Info_Retencion.re_EstaImpresa = "S";
                Bus_Retencion.Modificar_Num_Retencion(Info_Retencion, ref mensaje);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
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

        private void txt_nRetencion_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

