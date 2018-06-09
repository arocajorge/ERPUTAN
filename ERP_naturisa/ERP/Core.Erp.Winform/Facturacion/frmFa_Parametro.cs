using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Roles;

using Core.Erp.Info.Caja;
using Core.Erp.Business.Caja;
using Core.Erp.Business.CuentasxCobrar;


namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Parametro : Form
    {
        #region Declaración de variables
        ct_Cbtecble_tipo_Bus BusPlan = new ct_Cbtecble_tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        caj_Caja_Bus Bus_caja = new caj_Caja_Bus();
        List<caj_Caja_Info> list_caja = new List<caj_Caja_Info>();
        List<ct_Plancta_Info> ListaPlanAntList = new List<ct_Plancta_Info>();
        ct_Plancta_Bus bus_plan = new ct_Plancta_Bus();
        #endregion

        #region ParametrosFacturacion
        in_movi_inven_tipo_Bus BusMovi = new in_movi_inven_tipo_Bus();
        fa_parametro_Bus busFac = new fa_parametro_Bus();
        fa_parametro_info infoFac = new fa_parametro_info();
        ro_Departamento_Bus BusDep = new ro_Departamento_Bus();
        fa_TipoNota_Bus BusTipNot = new fa_TipoNota_Bus();

        string MensajeError = "";


        public void ParametrosFactura()
        {

            try
            {
                List<fa_TipoNota_Info> lstTipoNota = new List<fa_TipoNota_Info>();
                string mensaje = "";
                var TipoMovi = BusMovi.Get_List_movi_inven_tipo(param.IdEmpresa);
                var tipoCbte = BusPlan.Get_list_Cbtecble_tipo(param.IdEmpresa,Info.General.Cl_Enumeradores.eTipoFiltro.todos, ref MensajeError);

                cmbMoviInvenFactura.Properties.DataSource = TipoMovi;
                cmbMoviInvenFactura_Anul.Properties.DataSource = TipoMovi;

                DEVcmbTipoMoviInv.Properties.DataSource = TipoMovi;
                DEVcmbTipoMoviInvAnu.Properties.DataSource = TipoMovi;

                lstTipoNota = BusTipNot.Get_List_TipoNota(param.IdEmpresa);
                DEVcmbNCxDev.Properties.DataSource = lstTipoNota;
                cmbTipoNC_x_Fact.Properties.DataSource = lstTipoNota;

                //haac 14/03/2014
                list_caja = Bus_caja.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                cmbCaja.Properties.DataSource = list_caja;

                ListaPlanAntList = bus_plan.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
               

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        #endregion

        public frmFa_Parametro()
        {
            try
            {
                InitializeComponent(); ParametrosFactura();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valida())
                {
                    Get();

                    string mensaje = "";
                    if (busFac.ModificarDB(infoFac, ref mensaje))
                    {
                        MessageBox.Show("Parámetros Guardados Exitosamente");
                        //ucGe_Menu.Visible_btnGuardar = false;
                    }
                    else {
                        MessageBox.Show("Error " + mensaje);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_Combo_Estad_Apr_Ped()
        {
            try
            {

                fa_pedido_estadoAprobacion_Bus PedEsApBus = new fa_pedido_estadoAprobacion_Bus();
                List<fa_pedido_estadoAprobacion_Info> listEstaPed = new List<fa_pedido_estadoAprobacion_Info>();

                listEstaPed= PedEsApBus.Get_List_EstadoAprobacion();


                cmb_estado_Apro_x_Pedido.Properties.DataSource = listEstaPed;



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void fa_Parametro_Load(object sender, EventArgs e)
        {
            try
            {
                cxc_cobro_tipo_Bus busTipoCobro = new cxc_cobro_tipo_Bus();
                Cargar_Combo_Estad_Apr_Ped();
                string mensaje = "";
                cmbTipoCobroFac.Properties.DataSource = busTipoCobro.Get_List_Cobro_Tipo();
                DEVcmbDepxDev.cargar_combo();
                
                infoFac = busFac.Get_Info_parametro(param.IdEmpresa);

                                               
                if (infoFac.IdMovi_inven_tipo_Factura == 0)
                {cmbMoviInvenFactura.EditValue = null;}
                else
                {cmbMoviInvenFactura.EditValue = infoFac.IdMovi_inven_tipo_Factura;}

                if (infoFac.IdMovi_inven_tipo_Factura_Anulacion==0)
                {cmbMoviInvenFactura_Anul.EditValue = null;}
                else
                {cmbMoviInvenFactura_Anul.EditValue=infoFac.IdMovi_inven_tipo_Factura_Anulacion;}

               
                cmbTipoCCDiario.set_TipoCbteCble(infoFac.IdTipoCbteCble_Factura);

                cmbCCDiarioAnulacion.set_TipoCbteCble(infoFac.IdTipoCbteCble_Factura_Reverso);

                cmbCCDiarioCV.set_TipoCbteCble(infoFac.IdTipoCbteCble_Factura_Costo_VTA);

                cmbCCDiarioAnuCV.set_TipoCbteCble(infoFac.IdTipoCbteCble_Factura_Costo_VTA_Reverso);

                
                nud_NumeroDeItemp.Value = Convert.ToInt32(infoFac.NumeroDeItemFact)        ;
                cmbTipoCobroFac.EditValue = infoFac.TipoCobroDafaultFactu;
                //
                DEVcmbDepxDev.set_departamentoInfo(infoFac.IdDepartamento_x_DevVta);
                DEVcmbNCxDev.EditValue=infoFac.Tipo_NC_x_DevVta;
                cmbTipoNC_x_Fact.EditValue = infoFac.pa_IdTipoNota_NC_x_Anulacion;
                DEVcmbTipoMoviInv.EditValue=infoFac.IdMovi_inven_tipo_Dev_Vta;
                DEVcmbTipoMoviInvAnu.EditValue = infoFac.IdMovi_inven_tipo_Dev_Vta_Anulacion;
                //
                spinEdit.Value = Convert.ToDecimal(infoFac.pa_porc_max_total_item_x_despa_Guia);
                cbxImpresionAutoma.Checked = (infoFac.SeImprimiGuiaRemiAuto == "S") ? true : false; 
                //
                NCcmbCC.set_TipoCbteCble(infoFac.IdTipoCbteCble_NC);
                NDcmbCC.set_TipoCbteCble(infoFac.IdTipoCbteCble_ND);
                NCcmbCCAnu.set_TipoCbteCble(infoFac.IdTipoCbteCble_NC_Reverso);
                NDcmbCCAnu.set_TipoCbteCble(infoFac.IdTipoCbteCble_ND_Reverso);

                //haac 14/03/2014
                cmbCaja.EditValue = infoFac.IdCaja_Default_Factura;
                cmbCtaCbleCli.set_PlanCtarInfo(infoFac.IdCtaCble_x_anticipo_cliente);

                cmbCtaCble_IVA.set_PlanCtarInfo(infoFac.IdCtaCble_IVA);

                cmb_estado_Apro_x_Pedido.EditValue = infoFac.IdEstadoAprobacion;
                txtRutaXml.Text = infoFac.pa_ruta_descarga_xml_fac_elct;


                rbt_Fact_Doc_elect.Checked = (infoFac.pa_X_Defecto_la_factura_es_cbte_elect == null) ? false : Convert.ToBoolean(infoFac.pa_X_Defecto_la_factura_es_cbte_elect);
                rbt_GUIA_Doc_Elect.Checked = (infoFac.pa_X_Defecto_la_guia_es_cbte_elect == null) ? false : Convert.ToBoolean(infoFac.pa_X_Defecto_la_guia_es_cbte_elect);
                rbt_NC_Doc_Elect.Checked = (infoFac.pa_X_Defecto_la_NC_es_cbte_elect == null) ? false : Convert.ToBoolean(infoFac.pa_X_Defecto_la_NC_es_cbte_elect);
                rbt_ND_Doc_Elect.Checked = (infoFac.pa_X_Defecto_la_ND_es_cbte_elect == null) ? false : Convert.ToBoolean(infoFac.pa_X_Defecto_la_ND_es_cbte_elect);



                rbt_Fact_Pre_Impre.Checked = !rbt_Fact_Doc_elect.Checked;
                rbt_GUIA_Pre_Impre.Checked = !rbt_GUIA_Doc_Elect.Checked;
                rbt_NC_Pre_Impre.Checked = !rbt_NC_Doc_Elect.Checked;
                rbt_ND_Pre_Impre.Checked = !rbt_ND_Doc_Elect.Checked;

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void carga_ComboCaja(){}

        Boolean Valida()
        {
            try
            {
                if (cmbTipoCobroFac.EditValue==null)
                {
                    MessageBox.Show("Ingrese el tipo de cobro predefinido al generar factura ","Sistemas");
                    labelControl17.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (cmbMoviInvenFactura.EditValue == null)
                {
                    MessageBox.Show("Ingrese el tipo movimiento inventario ", "Sistemas");
                    labelControl1.ForeColor = System.Drawing.Color.Red;
                    return false;
                }


                if (cmbMoviInvenFactura_Anul.EditValue == null)
                {
                    MessageBox.Show("Ingrese el tipo movimiento inventario anulación ", "Sistemas");
                    labelControl2.ForeColor = System.Drawing.Color.Red;
                    return false;
                }


                if (cmb_estado_Apro_x_Pedido.EditValue == null)
                {
                    MessageBox.Show("Ingrese el Estado de la Aprobación ", "Sistemas");
                    return false;
                }

                if (cmbTipoCCDiario.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Ingrese el tipo Cbte contable para generar diario factura ", "Sistemas");
                    labelControl3.ForeColor = System.Drawing.Color.Red;
                    cmbTipoCCDiario.Focus();
                    return false;
                }

                if (cmbCCDiarioAnulacion.get_TipoCbteCble().IdTipoCbte == null )
                {
                    MessageBox.Show("Ingrese el tipo Cbte contable para anular diario factura ", "Sistemas");
                    labelControl4.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (cmbCCDiarioAnuCV.get_TipoCbteCble().IdTipoCbte == null  )
                {
                    MessageBox.Show("Ingrese el tipo Cbte contable para generar diario costo de venta ", "Sistemas");
                    labelControl6.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (cmbCCDiarioCV.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Ingrese el tipo Cbte contable para anular diario costo de venta ", "Sistemas");
                    labelControl5.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (this.nud_NumeroDeItemp.Value == null || Convert.ToInt32(this.nud_NumeroDeItemp.Value) == 0)
                {
                    MessageBox.Show("Ingrese el número de items por factura ", "Sistemas");
                    labelControl16.ForeColor = System.Drawing.Color.Red;
                    return false;
                }


                if (DEVcmbTipoMoviInv.EditValue == null || Convert.ToInt32(DEVcmbTipoMoviInv.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese el tipo movimiento inventario por Dev. en venta", "Sistemas");
                    labelControl7.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (DEVcmbTipoMoviInvAnu.EditValue == null || Convert.ToInt32(DEVcmbTipoMoviInvAnu.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese el tipo movimiento inventario por Dev. en venta anulación ", "Sistemas");
                    labelControl8.ForeColor = System.Drawing.Color.Red;
                    return false;
                }


                if (DEVcmbNCxDev.EditValue == null || Convert.ToInt32(DEVcmbNCxDev.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese el tipo nota de crédito por Dev. en venta ", "Sistemas");
                    labelControl13.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (cmbTipoNC_x_Fact.EditValue == null || Convert.ToInt32(cmbTipoNC_x_Fact.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese el tipo nota de crédito por Anulación de Factura ", "Sistemas");
                    labelControl18.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                
                

                if (NCcmbCC.get_TipoCbteCble() == null )
                {
                    MessageBox.Show("Ingrese el tipo Cbte contable para generar nota Crédito ", "Sistemas");
                    labelControl9.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (NDcmbCC.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Ingrese el tipo Cbte contable para generar nota Dédito ", "Sistemas");
                    labelControl10.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (NCcmbCCAnu.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Ingrese el tipo Cbte contable para generar nota Crédito anulación ", "Sistemas");
                    labelControl11.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (NDcmbCCAnu.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Ingrese el tipo Cbte contable para generar nota Dédito anulación ", "Sistemas");
                    labelControl12.ForeColor = System.Drawing.Color.Red;
                    return false;
                }


                if (cmbCaja.EditValue == null || Convert.ToInt32(cmbCaja.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese la caja predefinida para generar factura ", "Sistemas");
                    label1.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (this.cmbCtaCbleCli.get_PlanCtaInfo().IdCtaCble == null )
                {
                    MessageBox.Show("Ingrese la cuenta contable por anticipo cliente ", "Sistemas");
                    label2.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (this.cmbCtaCble_IVA.get_PlanCtaInfo().IdCtaCble == null )
                {
                    MessageBox.Show("Ingrese la cuenta contable para el IVA ", "Sistemas");
                    label2.ForeColor = System.Drawing.Color.Red;
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

        void Get() 
        {
            try
            {
                             
                infoFac.TipoCobroDafaultFactu = cmbTipoCobroFac.EditValue.ToString();
                infoFac.IdTipoCbteCble_Factura_Costo_VTA_Reverso = cmbCCDiarioAnuCV.get_TipoCbteCble().IdTipoCbte;
                infoFac.IdTipoCbteCble_Factura_Reverso = cmbCCDiarioAnulacion.get_TipoCbteCble().IdTipoCbte;


                infoFac.IdTipoCbteCble_Factura_Costo_VTA = cmbCCDiarioCV.get_TipoCbteCble().IdTipoCbte;
                infoFac.IdMovi_inven_tipo_Factura = Convert.ToInt32(cmbMoviInvenFactura.EditValue);
                infoFac.IdMovi_inven_tipo_Factura_Anulacion = Convert.ToInt32(cmbMoviInvenFactura_Anul.EditValue);
                infoFac.IdTipoCbteCble_Factura = cmbTipoCCDiario.get_TipoCbteCble().IdTipoCbte;
                infoFac.NumeroDeItemFact = Convert.ToInt32(nud_NumeroDeItemp.Value);
                //

                infoFac.IdDepartamento_x_DevVta = 1;

                infoFac.Tipo_NC_x_DevVta = Convert.ToInt32(DEVcmbNCxDev.EditValue);
                infoFac.pa_IdTipoNota_NC_x_Anulacion = Convert.ToInt32(cmbTipoNC_x_Fact.EditValue);
                infoFac.IdMovi_inven_tipo_Dev_Vta = Convert.ToInt32(DEVcmbTipoMoviInv.EditValue);
                infoFac.IdMovi_inven_tipo_Dev_Vta_Anulacion = Convert.ToInt32(DEVcmbTipoMoviInvAnu.EditValue);
                //
                infoFac.pa_porc_max_total_item_x_despa_Guia = Convert.ToDouble(spinEdit.Value);
                infoFac.SeImprimiGuiaRemiAuto = (cbxImpresionAutoma.Checked == true) ? "S" : "N";
                //
                infoFac.IdTipoCbteCble_NC = NCcmbCC.get_TipoCbteCble().IdTipoCbte;
                infoFac.IdTipoCbteCble_ND = NDcmbCC.get_TipoCbteCble().IdTipoCbte;
                infoFac.IdTipoCbteCble_NC_Reverso = NCcmbCCAnu.get_TipoCbteCble().IdTipoCbte;
                infoFac.IdTipoCbteCble_ND_Reverso = NDcmbCCAnu.get_TipoCbteCble().IdTipoCbte;
                infoFac.pa_compania = param.IdEmpresa;
                
                infoFac.IdCaja_Default_Factura = Convert.ToInt32(cmbCaja.EditValue);
                infoFac.IdCtaCble_x_anticipo_cliente = cmbCtaCbleCli.get_PlanCtaInfo().IdCtaCble;

                infoFac.IdEstadoAprobacion = Convert.ToString(cmb_estado_Apro_x_Pedido.EditValue);

                infoFac.pa_ruta_descarga_xml_fac_elct = txtRutaXml.Text;
                infoFac.IdCtaCble_IVA = cmbCtaCble_IVA.get_PlanCtaInfo().IdCtaCble;

                infoFac.pa_X_Defecto_la_factura_es_cbte_elect = rbt_Fact_Doc_elect.Checked;
                infoFac.pa_X_Defecto_la_guia_es_cbte_elect = rbt_GUIA_Doc_Elect.Checked;
                infoFac.pa_X_Defecto_la_NC_es_cbte_elect = rbt_NC_Doc_Elect.Checked;
                infoFac.pa_X_Defecto_la_ND_es_cbte_elect = rbt_ND_Doc_Elect.Checked;



            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                                      
        }

        private void cmbTipoCobroFac_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoCobroFac.EditValue != null)
                {
                    labelControl17.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void cmbMoviInvenFactura_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                    if (cmbMoviInvenFactura.EditValue != null)
                    {
                        labelControl1.ForeColor = System.Drawing.Color.Black;

                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbMoviInvenFactura_Anul_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMoviInvenFactura_Anul.EditValue != null)
                {
                    labelControl2.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbTipoCCDiario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoCCDiario.get_TipoCbteCble() != null)
                {
                    labelControl3.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
     
        private void cmbCCDiarioCV_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCCDiarioCV.get_TipoCbteCble() != null)
                {
                    labelControl5.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbCCDiarioAnuCV_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCCDiarioAnuCV.get_TipoCbteCble() != null)
                {
                    labelControl6.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbCCDiarioAnulacion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCCDiarioAnulacion.get_TipoCbteCble() != null)
                {
                    labelControl4.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DEVcmbTipoMoviInv_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DEVcmbTipoMoviInv.EditValue != null)
                {
                    labelControl7.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DEVcmbTipoMoviInvAnu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DEVcmbTipoMoviInvAnu.EditValue != null)
                {
                    labelControl8.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DEVcmbNCxDev_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DEVcmbNCxDev.EditValue != null)
                {
                    labelControl13.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DEVcmbDepxDev_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DEVcmbDepxDev.get_departamentoInfo() != null)
                {
                    labelControl14.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NCcmbCC_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NCcmbCC.get_TipoCbteCble() != null)
                {
                    labelControl9.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NDcmbCC_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NDcmbCC.get_TipoCbteCble() != null)
                {
                    labelControl10.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NCcmbCCAnu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NCcmbCCAnu.get_TipoCbteCble() != null)
                {
                    labelControl11.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NDcmbCCAnu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NDcmbCCAnu.get_TipoCbteCble() != null)
                {
                    labelControl12.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbCaja_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCaja.EditValue != null)
                {
                    label1.ForeColor = System.Drawing.Color.Black;

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

        private void nud_NumeroDeItemp_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (nud_NumeroDeItemp.Value != null)
                {
                    labelControl16.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NCcmbCC_event_cmbTipoCbteCble_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NCcmbCC.get_TipoCbteCble() != null)
                {
                    labelControl9.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NDcmbCC_event_cmbTipoCbteCble_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NDcmbCC.get_TipoCbteCble() != null)
                {
                    labelControl10.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NCcmbCCAnu_event_cmbTipoCbteCble_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NCcmbCCAnu.get_TipoCbteCble() != null)
                {
                    labelControl11.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NDcmbCCAnu_event_cmbTipoCbteCble_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (NDcmbCCAnu.get_TipoCbteCble() != null)
                {
                    labelControl12.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbCtaCbleCli_event_cmbPlanCta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCtaCbleCli.get_PlanCtaInfo() != null)
                {
                    label2.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelControl17_Click(object sender, EventArgs e)
        {

        }

      

   
    }
}
