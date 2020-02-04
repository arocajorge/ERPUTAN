using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Caja;
using Core.Erp.Info.Caja;

namespace Core.Erp.Winform.CuentasxPagar
{//02/04/2013  11:21 AM
    public partial class frmCP_Parametros : Form
    {
        #region variables
        caj_Caja_Movimiento_Tipo_Info f = new caj_Caja_Movimiento_Tipo_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<caj_Caja_Movimiento_Tipo_Info> lstMoviCaja = new List<caj_Caja_Movimiento_Tipo_Info>();
        ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();
        ct_Cbtecble_tipo_Bus busTipo = new ct_Cbtecble_tipo_Bus();
        ct_Plancta_Bus busCuenta = new ct_Plancta_Bus();
        cp_parametros_Info info = new cp_parametros_Info();
        cp_parametros_Bus BusPara = new cp_parametros_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ct_Cbtecble_tipo_Info> lmtipo = new List<ct_Cbtecble_tipo_Info>();
        List<ct_Plancta_Info> lmCuenta = new List<ct_Plancta_Info>();
        caj_Caja_Movimiento_Tipo_Bus caja_B = new caj_Caja_Movimiento_Tipo_Bus();
        bool BANDER = false;
        string MensajeError = "";
        #endregion

        public frmCP_Parametros()
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

        public void setUltaCmb()
        {
            try
            {
                lmtipo = busTipo.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setUltaCmbCuenta()
        {
            try
            {
                lmCuenta = busCuenta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                lmCuenta.ForEach(c => c.pc_Cuenta = "[" + c.IdCtaCble + "] - " + c.pc_Cuenta);

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
        private void frmCP_Parametros_Load(object sender, EventArgs e)
        {
            try
            {
                setUltaCmb();
                setUltaCmbCuenta();
                info = BusPara.Get_Info_parametros(param.IdEmpresa);
                ucGe_Menu.Visible_btnGuardar = false;
                if (info != null)
                {
                    if (info.IdEmpresa != 0)
                    {
                        cmbAnulacionOGCxP.set_TipoCbteCble(info.pa_TipoCbte_OG_anulacion);
                        cmbAnulacionOGCxP.set_TipoCbteCble(cmbAnulacionOGCxP.get_TipoCbteCble().IdTipoCbte);
                        cmbTipoCC_OgiroCxP.set_TipoCbteCble(info.pa_TipoCbte_OG);
                        cmbTipoCC_OgiroCxP.set_TipoCbteCble(cmbTipoCC_OgiroCxP.get_TipoCbteCble().IdTipoCbte);
                        cmbCtaDeudora.set_PlanCtarInfo(info.pa_ctacble_deudora);
                        cmbCtaIvaxPagar.set_PlanCtarInfo(info.pa_ctacble_iva);
                        cmbctaProveedor.set_PlanCtarInfo(info.pa_ctacble_Proveedores_default);
                        cmbTipoMoviCaja.set_MovimientoInfo(Convert.ToInt32(info.pa_TipoEgrMoviCaja_Conciliacion));
                        cmbTipoCbt_NC.set_TipoCbteCble(Convert.ToInt32(info.pa_TipoCbte_NC));
                        cmbTipoCbtAnu_NC.set_TipoCbteCble(Convert.ToInt32(info.pa_TipoCbte_NC_anulacion));
                        cmbTipoCbt_ND.set_TipoCbteCble(Convert.ToInt32(info.pa_TipoCbte_ND));
                        cmbTipoCbtAnu_ND.set_TipoCbteCble(Convert.ToInt32(info.pa_TipoCbte_ND_anulacion));
                        cmbTipoCbt_RetFte.set_TipoCbteCble(Convert.ToInt32(info.pa_IdTipoCbte_x_Retencion));
                        cmbTipoCbt_x_anu_RetFte.set_TipoCbteCble(Convert.ToInt32(info.pa_IdTipoCbte_x_Anu_Retencion));
                        txtRutaXml.Text = info.pa_ruta_descarga_xml_fac_elct;
                        cmb_TipoCbte_Conci_x_Anticipo.set_TipoCbteCble(info.pa_TipoCbte_para_conci_x_antcipo);
                        cmb_TipoCbte_Conci_x_Anticipo_anulacion.set_TipoCbteCble(info.pa_TipoCbte_para_conci_anulacion_x_antcipo == null ? 0 : Convert.ToInt32(info.pa_TipoCbte_para_conci_anulacion_x_antcipo));
                        ucCtacbleRetFte.set_PlanCtarInfo(info.pa_ctacble_x_RetFte_default);
                        ucCtacbleRetIva.set_PlanCtarInfo(info.pa_ctacble_x_RetIva_default);
                        ucBa_CuentaBanco1.set_BaCuentaInfo(info.pa_IdBancoCuenta_default_para_OP == null ? 0 : Convert.ToInt32(info.pa_IdBancoCuenta_default_para_OP));
                        rbt_Ret_Doc_elect.Checked = (info.pa_X_Defecto_la_Retencion_es_cbte_elect == null) ? false : Convert.ToBoolean(info.pa_X_Defecto_la_Retencion_es_cbte_elect);

                        rbt_Ret_Pre_Impre.Checked = !rbt_Ret_Doc_elect.Checked;
                    }
                }
                BANDER = true;
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Grabar()
        {
            try
            {
                cmbTipoCC_OgiroCxP.Focus();

                info.IdEmpresa = param.IdEmpresa;
                info.pa_TipoCbte_OG_anulacion = cmbAnulacionOGCxP.get_TipoCbteCble().IdTipoCbte;
                info.pa_TipoCbte_OG = cmbTipoCC_OgiroCxP.get_TipoCbteCble().IdTipoCbte;
                info.pa_ctacble_deudora = cmbCtaDeudora.get_PlanCtaInfo().IdCtaCble;
                info.pa_ctacble_iva = cmbCtaIvaxPagar.get_PlanCtaInfo().IdCtaCble;
                info.pa_ctacble_Proveedores_default = cmbctaProveedor.get_PlanCtaInfo().IdCtaCble;
                info.pa_TipoEgrMoviCaja_Conciliacion = Convert.ToInt32(cmbTipoMoviCaja.get_MovimientoInfo().IdTipoMovi); ;
                info.pa_TipoCbte_NC = cmbTipoCbt_NC.get_TipoCbteCble().IdTipoCbte;
                info.pa_TipoCbte_NC_anulacion = cmbTipoCbtAnu_NC.get_TipoCbteCble().IdTipoCbte;
                info.pa_TipoCbte_ND = cmbTipoCbt_ND.get_TipoCbteCble().IdTipoCbte;
                info.pa_TipoCbte_ND_anulacion = cmbTipoCbtAnu_ND.get_TipoCbteCble().IdTipoCbte;
                info.pa_IdTipoCbte_x_Retencion = cmbTipoCbt_RetFte.get_TipoCbteCble().IdTipoCbte;
                info.pa_TipoCbte_para_conci_x_antcipo = cmb_TipoCbte_Conci_x_Anticipo.get_TipoCbteCble().IdTipoCbte;
                info.pa_IdTipoCbte_x_Anu_Retencion = cmbTipoCbt_x_anu_RetFte.get_TipoCbteCble().IdTipoCbte;
                info.pa_ctacble_x_RetFte_default = ucCtacbleRetFte.get_PlanCtaInfo().IdCtaCble;
                info.pa_ctacble_x_RetIva_default = ucCtacbleRetIva.get_PlanCtaInfo().IdCtaCble;
                info.pa_IdBancoCuenta_default_para_OP = ucBa_CuentaBanco1.get_BaCuentaInfo().IdBanco;
                if (cmb_TipoCbte_Conci_x_Anticipo_anulacion.get_TipoCbteCble() == null) info.pa_TipoCbte_para_conci_anulacion_x_antcipo = null; 
                else info.pa_TipoCbte_para_conci_anulacion_x_antcipo = cmb_TipoCbte_Conci_x_Anticipo_anulacion.get_TipoCbteCble().IdTipoCbte;
              
                info.pa_obligaOC = null;
                info.IdUsuario = param.ip;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.nom_pc = param.nom_pc;
                info.pa_ruta_descarga_xml_fac_elct = txtRutaXml.Text;

                info.pa_X_Defecto_la_Retencion_es_cbte_elect = rbt_Ret_Doc_elect.Checked;

                try
                {
                    byte[] readBuffer = System.IO.File.ReadAllBytes(openFileDialog1.FileName);

                    if (readBuffer != null)
                    {
                        info.pa_xsd_de_atsSRI = readBuffer;
                    }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                }

                try
                {
                    byte[] readBuffer2 = System.IO.File.ReadAllBytes(openFileDialog2.FileName);

                    if (readBuffer2 != null)
                    {
                        info.pa_Formulario103_104 = readBuffer2;
                    }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                }

                if (BusPara.ModificarDB(info))
                {
                    MessageBox.Show("Parámetros de Cuentas por Pagar ingresados con Exito");
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    //ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar los parámetros de Cuentas por Pagar", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean validar()
        {
            try
            {
               
                if (cmbTipoCC_OgiroCxP.get_TipoCbteCble() ==  null)
                {
                    MessageBox.Show("Ingrese Tipo de Comprobante Contable para Orden de Giro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbTipoCC_OgiroCxP.Focus();
                    return false;
                }

                if (cmbAnulacionOGCxP.get_TipoCbteCble()  == null)
                {
                    MessageBox.Show("Ingrese Tipo Comprobante de Anulacion de Orden de Giro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbAnulacionOGCxP.Focus();
                    return false;
                }

                if (cmbCtaDeudora.get_PlanCtaInfo()  == null)
                {
                    MessageBox.Show("Ingrese Cuenta Deudora", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCtaDeudora.Focus();
                    return false;
                }

                if (cmbCtaIvaxPagar.get_PlanCtaInfo() ==  null)
                {
                    MessageBox.Show("Ingrese Cuenta de Iva por Pagar Default", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCtaIvaxPagar.Focus();
                    return false;
                }

                if (cmbctaProveedor.get_PlanCtaInfo() == null)
                {
                    MessageBox.Show("Ingrese Cuenta default para Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbctaProveedor.Focus();
                    return false;
                }

                if (cmbTipoMoviCaja.get_MovimientoInfo() == null)
                {
                    MessageBox.Show("Ingrese Movimiento de Egreso de Caja para Conciliación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbTipoMoviCaja.Focus();
                    return false;
                } 

                if (cmbTipoCbt_NC.get_TipoCbteCble() ==  null)
                {
                    MessageBox.Show("Ingrese Comprobante Contable para Nota de Crédito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbTipoCbt_NC.Focus();
                    return false;
                }

                if (cmbTipoCbtAnu_NC.get_TipoCbteCble()  == null)
                {
                    MessageBox.Show("Ingrese Comprobante de Anulacion de Nota de Crédito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbTipoCbtAnu_NC.Focus();
                    return false;
                }

                if (cmbTipoCbt_ND.get_TipoCbteCble()  == null)
                {
                    MessageBox.Show("Ingrese Comprobante Contable para Nota de Débito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbTipoCbt_ND.Focus();
                    return false;
                }

                if (cmbTipoCbtAnu_ND.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Ingrese Comprobante de Anulacion de Nota de Débito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbTipoCbtAnu_ND.Focus();
                    return false;
                }

                if (cmbTipoCbt_RetFte.get_TipoCbteCble()  == null)
                {
                    MessageBox.Show("Ingrese Comprobante Contable para Retencion en la Fuente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbTipoCbt_RetFte.Focus();
                    return false;
                }

                if (cmbTipoCbt_x_anu_RetFte.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Ingrese Comprobante Contable para Anulación por Retención en la Fuente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbTipoCbt_x_anu_RetFte.Focus();
                    return false;
                }

                if (cmb_TipoCbte_Conci_x_Anticipo.get_TipoCbteCble() ==  null)
                {
                    MessageBox.Show("Ingrese Tipo de Comprobante Contable para Orden de Giro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_TipoCbte_Conci_x_Anticipo.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    Grabar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Grabar();
                Close();
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void cmbTipoMoviCaja_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                caj_Caja_Movimiento_Tipo_Info obj_cmbCajTipMov = cmbTipoMoviCaja.get_MovimientoInfo();
                if (BANDER == true)
                    if (obj_cmbCajTipMov != null)
                    {
                        if (obj_cmbCajTipMov.IdCtaCble == "" || obj_cmbCajTipMov.IdCtaCble == null)
                            MessageBox.Show("El item seleccionado no tiene cuenta contable\n Por favor seleccione uno que tenga cuenta contable o modifique el tipo de movimiento de caja desde la pantalla de Mantenimiento de Caja asignándole la cuenta contable", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRutaXml_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Reset();
                folder.Description = " Seleccionar una carpeta ";
                folder.SelectedPath = txtRutaXml.Text;

                folder.ShowNewFolderButton = false;
                DialogResult ret = new DialogResult();
                ret = folder.ShowDialog();  
                txtRutaXml.Text = folder.SelectedPath + @"\";
                folder.Dispose();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
    }
}
