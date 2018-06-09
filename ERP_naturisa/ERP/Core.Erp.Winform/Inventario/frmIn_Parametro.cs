using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Parametro : Form
    {
        #region Declaracion Variable
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        in_Parametro_Bus bus = new in_Parametro_Bus();
        in_Parametro_Info info = new in_Parametro_Info();
        ct_Centro_costo_Bus CentroCbus = new ct_Centro_costo_Bus();
        ct_Centro_costo_Info CentroCinfo = new ct_Centro_costo_Info();
        ct_Plancta_Bus ctacleBus = new ct_Plancta_Bus();
        BindingList<ct_Plancta_Info> lst = new BindingList<ct_Plancta_Info>();
        in_movi_inven_tipo_Bus busTipo = new in_movi_inven_tipo_Bus();
        in_movi_inven_tipo_Info infoTipo = new in_movi_inven_tipo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<in_movi_inven_tipo_Info> lmtipoPos = new List<in_movi_inven_tipo_Info>();
        List<in_movi_inven_tipo_Info> lmtipoNeg = new List<in_movi_inven_tipo_Info>();
        List<ct_Centro_costo_Info> centrocostolm = new List<ct_Centro_costo_Info>();
        ct_Plancta_Bus PlanCus = new ct_Plancta_Bus();
        ct_Cbtecble_tipo_Bus TipoCbteBus = new ct_Cbtecble_tipo_Bus();
        tb_Sucursal_Bus sucuBus = new tb_Sucursal_Bus();
        tb_Bodega_Bus BodeBus = new tb_Bodega_Bus();
        string MensajeError = "";

        #endregion

        public FrmIn_Parametro()
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

        public Boolean Validar()
        {
            try
            {
                cmbStockNeg.Focus();

                if (cmbStockNeg.Text == "")
                {
                    MessageBox.Show("Por Favor Indique Corfirme el campo de Stock");
                    cmbStockNeg.Focus();
                    return false;
                }

                if (cmbEstadoAproba_Ingr.EditValue == "" || cmbEstadoAproba_Ingr.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Estado de Aprobación para los Ingreso de Inventario");
                    cmbEstadoAproba_Ingr.Focus();
                    return false;
                }

                if (cmbEstadoAproba_Egre.EditValue == "" || cmbEstadoAproba_Egre.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Estado de Aprobación para los Egresos de Inventario");
                    cmbEstadoAproba_Egre.Focus();
                    return false;
                } 

                if (ucIn_Sucursal_Bodega1.get_bodega() == null)
                {
                    MessageBox.Show("Por Favor Seleccione la Bodega");
                    ucIn_Sucursal_Bodega1.Focus();
                    return false;
                }
                if (ucIn_Sucursal_Bodega1.get_sucursal() == null)
                {
                    MessageBox.Show("Por Favor Seleccione la Sucursal");
                    ucIn_Sucursal_Bodega1.Focus();
                    return false;
                }
                if (cmb_tipo_movi_inven_anu_egr.get_TipoMoviInvInfo() == null) 
                {
                    MessageBox.Show("Por Favor Seleccione el Tipo de Movimiento de Inventario cuando se anule Egresos");
                    cmb_tipo_movi_inven_anu_egr.Focus();
                    return false;
                }
                if (cmb_tipo_movi_inven_anu_ing.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Por Favor Seleccione el Tipo de Movimiento de Inventario cuando se anule Ingresos");
                    cmb_tipo_movi_inven_anu_ing.Focus();
                    return false;
                }
                if (cmbTipoCbteCble_Trans_costo_Inven.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione el Comprobante Contable para Costo de Inventario");
                    cmbTipoCbteCble_Trans_costo_Inven.Focus();
                    return false;
                }
                if (cmbTipoCbteCble_Trans_Anu_costo_Inven.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione el Comprobante Contable para Anulacion de Costo de Inventario");
                    cmbTipoCbteCble_Trans_Anu_costo_Inven.Focus();
                    return false;
                }
                if (cmb_tipo_movi_inven_x_transf_egr.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Por Favor Indique Tipo de Movimiento de Inventario para Egreso de Bodega Origen");
                    cmb_tipo_movi_inven_x_transf_egr.Focus();
                    return false;
                }
                if (cmb_tipo_movi_inven_x_transf_ing.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Movimiento de Inventario para Ingreso de Bodega Origen");
                    cmb_tipo_movi_inven_x_transf_ing.Focus();
                    return false;
                }
                if (cmbUsuatioEscogeMot.Text == "")
                {
                    MessageBox.Show("Por Favor indique si el usuario puede escoger el Tipo de Movimiento de Inventario ");
                    cmbUsuatioEscogeMot.Focus();
                    return false;
                }
                if (cmb_tipo_movi_inven_egr_x_ajus_fisico.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Movimiento de Inventario  para Egreso por Ajuste Fisico");
                    cmb_tipo_movi_inven_egr_x_ajus_fisico.Focus();
                    return false;
                }
                if (cmb_tipo_movi_inven_ing_x_ajus_fisico.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Movimiento de Inventario  para Ingreso por Ajuste Fisico");
                    cmb_tipo_movi_inven_ing_x_ajus_fisico.Focus();
                    return false;
                }
                if (cmb_tipo_movi_inven_egr_x_ajus.get_TipoMoviInvInfo() == null) 
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Movimiento de Inventario  para Egreso por Ajuste");
                    cmb_tipo_movi_inven_egr_x_ajus.Focus();
                    return false;
                }
                if (cmb_tipo_movi_inven_ing_x_ajus.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Movimiento de Inventario  para Ingreso por Ajuste");
                    cmb_tipo_movi_inven_ing_x_ajus.Focus();
                    return false;
                }
                if (cmb_catalogo_Fecha_conta.Get_CatalogosInfo()==null)
                {
                    MessageBox.Show("Por Favor seleccione la fecha para la contabilización de los ingresos a bodega");
                    cmb_tipo_movi_inven_ing_x_ajus.Focus();
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

        private void frminv_parametro_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_combos();

                info = bus.Get_Info_Parametro(param.IdEmpresa);
                if (info != null)
                {
                    cmbStockNeg.SelectedItem = (info.Maneja_Stock_Negativo == "S") ? "Si" : "No";
                    cmb_ctacble_Inven.set_PlanCtarInfo(info.IdCtaCble_Inven);
                    cmb_ctacble_costo_inven.set_PlanCtarInfo(info.IdCtaCble_CostoInven);

                    cmbTipoCbteCble_Trans_costo_Inven.set_TipoCbteCble(Convert.ToInt32(info.IdTipoCbte_CostoInven));
                    cmbTipoCbteCble_Trans_Anu_costo_Inven.set_TipoCbteCble(Convert.ToInt32(info.IdTipoCbte_CostoInven_Reverso));
                    cmbCCostoTran.SelectedItem = (info.Mostrar_CentroCosto_en_transacciones == "S") ? "Si" : "No";
                    cmb_tipo_movi_inven_anu_egr.set_TipoMoviInvInfo(Convert.ToInt32(info.IdMovi_Inven_tipo_x_anu_Egr));
                    cmb_tipo_movi_inven_anu_ing.set_TipoMoviInvInfo(Convert.ToInt32(info.IdMovi_Inven_tipo_x_anu_Ing));
                    ucIn_Sucursal_Bodega1.set_Idbodega(info.IdSucursalSuministro, info.IdBodegaSuministro);
                    cmb_tipo_movi_inven_x_transf_ing.set_TipoMoviInvInfo(Convert.ToInt32(info.IdMovi_inven_tipo_ingresoBodegaDestino));
                    cmb_tipo_movi_inven_x_transf_egr.set_TipoMoviInvInfo(Convert.ToInt32(info.IdMovi_inven_tipo_egresoBodegaOrigen));
                    cmbUsuatioEscogeMot.SelectedItem = (info.Usuario_Escoge_Motivo == "S") ? "Si" : "No";
                    cmb_tipo_movi_inven_egr_x_ajus_fisico.set_TipoMoviInvInfo(Convert.ToInt32(info.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa));
                    cmb_tipo_movi_inven_ing_x_ajus_fisico.set_TipoMoviInvInfo(Convert.ToInt32(info.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa));
                    ckAjust.Checked = (info.ApruebaAjusteFisicoAuto == "S" ? true : false);
                    cmb_tipo_movi_inven_ing_x_ajus.set_TipoMoviInvInfo(Convert.ToInt32(info.IdMovi_inven_tipo_ingresoAjuste));
                    cmb_tipo_movi_inven_egr_x_ajus.set_TipoMoviInvInfo(Convert.ToInt32(info.IdMovi_inven_tipo_egresoAjuste));
                    cmbEstadoAproba_Ingr.EditValue = info.IdEstadoAproba_x_Ing;
                    cmbEstadoAproba_Egre.EditValue = info.IdEstadoAproba_x_Egr;
                    chk_Registrar_ingreso_x_item.Checked = info.P_Grabar_Items_x_Cada_Movi_Inven == null ? false : (bool)info.P_Grabar_Items_x_Cada_Movi_Inven;
                    cmb_catalogo_Fecha_conta.set_CatalogosInfo(info.P_Fecha_para_contabilizacion_ingr_egr);
                    chk_para_conta_oblig_produ_ten_ctaInv.Checked = info.P_se_valida_parametrizacion_x_producto == null ? false : (bool)info.P_se_valida_parametrizacion_x_producto;
                    cmb_PlanCta.set_PlanCtarInfo( info.P_IdCtaCble_transitoria_transf_inven);

                    cmb_dev_inven_x_ing.set_TipoMoviInvInfo(Convert.ToInt32(info.IdMovi_Inven_tipo_x_Dev_Inv_x_Ing));
                    cmb_dev_inven_x_egr.set_TipoMoviInvInfo(Convert.ToInt32(info.IdMovi_Inven_tipo_x_Dev_Inv_x_Erg));

                
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    getParametrosInventario();
                    if (bus.ModificarDB(info, param.IdEmpresa))
                    { 
                        MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk);
                       
                    }
                    else { MessageBox.Show("Parametros de Inventario no pueden ser Ingresados"); }
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

        public void getParametrosInventario()
        {
            try
            {
                if (info == null) { info = new in_Parametro_Info(); }

                info.Maneja_Stock_Negativo = (cmbStockNeg.SelectedItem == "Si") ? "S" : "N";
                info.Usuario_Escoge_Motivo = (cmbUsuatioEscogeMot.SelectedItem == "Si") ? "S" : "N";
                info.Mostrar_CentroCosto_en_transacciones = (cmbCCostoTran.SelectedItem == "Si") ? "S" : "N";
                info.LabelCentroCosto = "";
                info.IdTipoCbte_CostoInven = cmbTipoCbteCble_Trans_costo_Inven.get_TipoCbteCble().IdTipoCbte;
                info.IdTipoCbte_CostoInven_Reverso = cmbTipoCbteCble_Trans_Anu_costo_Inven.get_TipoCbteCble().IdTipoCbte;
                info.IdCtaCble_Inven = cmb_ctacble_Inven.get_PlanCtaInfo().IdCtaCble;
                info.IdCtaCble_CostoInven = cmb_ctacble_costo_inven.get_PlanCtaInfo().IdCtaCble;
                

                info.IdMovi_Inven_tipo_x_anu_Ing = cmb_tipo_movi_inven_anu_ing.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                info.IdMovi_Inven_tipo_x_anu_Egr = cmb_tipo_movi_inven_anu_egr.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                info.IdSucursalSuministro = ucIn_Sucursal_Bodega1.get_bodega().IdSucursal;
                info.IdBodegaSuministro = ucIn_Sucursal_Bodega1.get_bodega().IdBodega;
                info.IdMovi_inven_tipo_ingresoBodegaDestino = cmb_tipo_movi_inven_x_transf_ing.get_TipoMoviInvInfo().IdMovi_inven_tipo; 
                info.IdMovi_inven_tipo_egresoBodegaOrigen = cmb_tipo_movi_inven_x_transf_egr.get_TipoMoviInvInfo().IdMovi_inven_tipo; 
                info.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa = cmb_tipo_movi_inven_egr_x_ajus_fisico.get_TipoMoviInvInfo().IdMovi_inven_tipo; 
                info.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa = cmb_tipo_movi_inven_ing_x_ajus_fisico.get_TipoMoviInvInfo().IdMovi_inven_tipo; 
                info.ApruebaAjusteFisicoAuto = (ckAjust.Checked == true ? "S" : "N");
                info.IdMovi_inven_tipo_ingresoAjuste = cmb_tipo_movi_inven_ing_x_ajus.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                info.IdMovi_inven_tipo_egresoAjuste = cmb_tipo_movi_inven_egr_x_ajus.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                info.IdEstadoAproba_x_Ing = Convert.ToString(cmbEstadoAproba_Ingr.EditValue);
                info.IdEstadoAproba_x_Egr = Convert.ToString(cmbEstadoAproba_Egre.EditValue);
                info.P_Grabar_Items_x_Cada_Movi_Inven = chk_Registrar_ingreso_x_item.Checked == true ? true : false;
                info.P_Fecha_para_contabilizacion_ingr_egr = cmb_catalogo_Fecha_conta.Get_CatalogosInfo().IdCatalogo;
                info.P_se_valida_parametrizacion_x_producto = chk_para_conta_oblig_produ_ten_ctaInv.Checked;

                info.P_IdCtaCble_transitoria_transf_inven = cmb_PlanCta.get_PlanCtaInfo().IdCtaCble;
                //info.P_Al_Conta_CtaCosto_Buscar_en =(ein_TipoContabilizacion_Cta_Inven_Costo) Enum.Parse(typeof(ein_TipoContabilizacion_Cta_Inven_Costo), cmb_al_conta_cta_costo_buscar_en.Get_CatalogosInfo().IdCatalogo);
                //info.P_Al_Conta_CtaInven_Buscar_en = (ein_TipoContabilizacion_Cta_Inven_Costo)Enum.Parse(typeof(ein_TipoContabilizacion_Cta_Inven_Costo), cmb_al_conta_cta_inv_buscar_en.Get_CatalogosInfo().IdCatalogo);


                info.IdMovi_Inven_tipo_x_Dev_Inv_x_Ing = cmb_dev_inven_x_ing.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                info.IdMovi_Inven_tipo_x_Dev_Inv_x_Erg = cmb_dev_inven_x_egr.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_combos()
        {
            try
            {
                in_Ing_Egr_Inven_estado_apro_Bus busEstado = new in_Ing_Egr_Inven_estado_apro_Bus();
                List<in_Ing_Egr_Inven_estado_apro_Info> lstEstado = new List<in_Ing_Egr_Inven_estado_apro_Info>();
                lstEstado = busEstado.Get_List_Ing_Egr_Inven_estado_apro();
                cmbEstadoAproba_Egre.Properties.DataSource = lstEstado;
                cmbEstadoAproba_Ingr.Properties.DataSource = lstEstado;

                cmb_tipo_movi_inven_anu_egr.cargar_TipoMotivo(0, 0, "+", "");
                cmb_tipo_movi_inven_anu_ing.cargar_TipoMotivo(0, 0, "-", "");
                cmb_tipo_movi_inven_x_transf_egr.cargar_TipoMotivo(0, 0, "-", "");
                cmb_tipo_movi_inven_x_transf_ing.cargar_TipoMotivo(0, 0, "+", "");
                cmb_tipo_movi_inven_ing_x_ajus_fisico.cargar_TipoMotivo(0, 0, "+", "");
                cmb_tipo_movi_inven_egr_x_ajus_fisico.cargar_TipoMotivo(0, 0, "-", "");
                cmb_tipo_movi_inven_ing_x_ajus.cargar_TipoMotivo(0, 0, "+", "");
                cmb_tipo_movi_inven_egr_x_ajus.cargar_TipoMotivo(0, 0, "-", "");

                cmb_dev_inven_x_ing.cargar_TipoMotivo(0, 0, "-", "");
                cmb_dev_inven_x_egr.cargar_TipoMotivo(0, 0, "+", "");

                cmb_catalogo_Fecha_conta.cargar_Catalogos(4);
                cmb_PlanCta.cargar_PlanCta();
                //cmb_al_conta_cta_inv_buscar_en.cargar_Catalogos(6);
                //cmb_al_conta_cta_costo_buscar_en.cargar_Catalogos(6);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
