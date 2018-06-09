using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_Parametro : UserControl
    {
        public UCIn_Parametro()
        {
            try
            {
              InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

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

        private void UCIn_Parametro_Load(object sender, EventArgs e)
        {
            try
            {
                
                cargar_planCuenta_combos();
                cargar_TipoCbteCble_combos();
                cargar_centroCosto_combos();
                cargar_TipoMovi_Inven_combos();
                cargar_centroCosto_padre_combos();
                info=bus.Get_Info_Parametro(param.IdEmpresa);
                cmbStockNeg.SelectedItem = (info.Maneja_Stock_Negativo == "S") ? "Si" : "No";               
                cmb_ctacble_Inven.EditValue = info.IdCtaCble_Inven;
                cmb_ctacble_costo_inven.EditValue = info.IdCtaCble_CostoInven;
                cmb_centro_costo_inven.EditValue=info.IdCentro_Costo_Inventario;
                cmb_centro_costo_cta_centro_costo.EditValue = info.IdCentro_Costo_Costo;
                cmb_centro_costo_padre_costo_inven.EditValue = info.IdCentroCosto_Padre_a_cargar;
                cmbTipoCbteCble_Trans_costo_Inven.EditValue=info.IdTipoCbte_CostoInven;
                cmbTipoCbteCble_Trans_Anu_costo_Inven.EditValue = info.IdTipoCbte_CostoInven_Reverso;
                cmbCCostoTran.SelectedItem = (info.Mostrar_CentroCosto_en_transacciones == "S") ? "Si" : "No";
                txtTituloCC.Text = info.LabelCentroCosto;
                cmb_tipo_movi_inven_anu_egr.EditValue = info.IdMovi_Inven_tipo_x_anu_Egr;
                cmb_tipo_movi_inven_anu_ing.EditValue = info.IdMovi_Inven_tipo_x_anu_Ing;
                ucIn_Sucursal_Bodega1.set_Idbodega( info.IdSucursalSuministro,info.IdBodegaSuministro);
                cmb_tipo_movi_inven_x_transf_ing.EditValue = info.IdMovi_inven_tipo_ingresoBodegaDestino;
                cmb_tipo_movi_inven_x_transf_egr.EditValue = info.IdMovi_inven_tipo_egresoBodegaOrigen;
                cmbUsuatioEscogeMot.SelectedItem = (info.Usuario_Escoge_Motivo == "S") ? "Si" : "No";
                cmb_tipo_movi_inven_egr_x_ajus_fisico.EditValue = info.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa;
                cmb_tipo_movi_inven_ing_x_ajus_fisico.EditValue = info.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa;
                ckAjust.Checked = (info.ApruebaAjusteFisicoAuto == "S" ? true : false);
                cmb_tipo_movi_inven_ing_x_ajus.EditValue = info.IdMovi_inven_tipo_ingresoAjuste;
                cmb_tipo_movi_inven_egr_x_ajus.EditValue = info.IdMovi_inven_tipo_egresoAjuste;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        private void cargar_planCuenta_combos()
        {
           try
            {
               string mensaje = "";
               List<ct_Plancta_Info> listPlanCta = new List<ct_Plancta_Info>();
               listPlanCta = PlanCus.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);

               this.cmb_ctacble_Inven.Properties.DataSource = listPlanCta;
               this.cmb_ctacble_costo_inven.Properties.DataSource = listPlanCta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        
        }

        private void cargar_TipoCbteCble_combos()
        {
            try
            {
                List<ct_Cbtecble_tipo_Info> lista = new List<ct_Cbtecble_tipo_Info>();
                lista = TipoCbteBus.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);
                cmbTipoCbteCble_Trans_Anu_costo_Inven.Properties.DataSource = lista;
                cmbTipoCbteCble_Trans_costo_Inven.Properties.DataSource = lista;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cargar_centroCosto_combos()
        {
            try
            {
                List<ct_Centro_costo_Info> lista = new List<ct_Centro_costo_Info>();
                lista = CentroCbus.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmb_centro_costo_inven.Properties.DataSource = lista;
                cmb_centro_costo_cta_centro_costo.Properties.DataSource = lista;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cargar_centroCosto_padre_combos()
        {
            try
            {
                string MensajeError = "";

                List<ct_Centro_costo_Info> lista = new List<ct_Centro_costo_Info>();
                lista = CentroCbus.Get_list_Centro_Costo(param.IdEmpresa,ref MensajeError);

                cmb_centro_costo_padre_costo_inven.Properties.DataSource = lista;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cargar_TipoMovi_Inven_combos()
        {
            try
            {
                List<in_movi_inven_tipo_Info> lista_ing = new List<in_movi_inven_tipo_Info>();
                List<in_movi_inven_tipo_Info> lista_egr = new List<in_movi_inven_tipo_Info>();
                lista_ing = busTipo.Get_list_movi_inven_tipo(param.IdEmpresa,"+","", "");
                lista_egr = busTipo.Get_list_movi_inven_tipo(param.IdEmpresa, "-", "", "");
                cmb_tipo_movi_inven_anu_egr.Properties.DataSource = lista_egr;
                cmb_tipo_movi_inven_anu_ing.Properties.DataSource = lista_ing;
                cmb_tipo_movi_inven_x_transf_egr.Properties.DataSource = lista_egr;
                cmb_tipo_movi_inven_x_transf_ing.Properties.DataSource = lista_ing;
                cmb_tipo_movi_inven_ing_x_ajus_fisico.Properties.DataSource = lista_ing;
                cmb_tipo_movi_inven_egr_x_ajus_fisico.Properties.DataSource = lista_egr;
                cmb_tipo_movi_inven_ing_x_ajus.Properties.DataSource = lista_ing;
                cmb_tipo_movi_inven_egr_x_ajus.Properties.DataSource = lista_egr; 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void getParametrosInventario(){
            try
            {
                info.Maneja_Stock_Negativo = (cmbStockNeg.SelectedItem == "Si") ? "S" : "N";
                info.Usuario_Escoge_Motivo = (cmbUsuatioEscogeMot.SelectedItem == "Si") ? "S" : "N";
                info.Mostrar_CentroCosto_en_transacciones = (cmbCCostoTran.SelectedItem == "Si") ? "S" : "N";
                info.LabelCentroCosto = txtTituloCC.Text;
                info.IdTipoCbte_CostoInven = Convert.ToInt32(cmbTipoCbteCble_Trans_costo_Inven.EditValue);
                info.IdTipoCbte_CostoInven_Reverso = Convert.ToInt32(cmbTipoCbteCble_Trans_Anu_costo_Inven.EditValue);
                info.IdCtaCble_Inven = (cmb_ctacble_Inven.EditValue == null ? null : cmb_ctacble_Inven.EditValue.ToString());
                info.IdCtaCble_CostoInven = (cmb_ctacble_costo_inven.EditValue == null ? null : cmb_ctacble_costo_inven.EditValue.ToString());
                info.IdCentro_Costo_Inventario = (cmb_centro_costo_inven.EditValue == null ? null : cmb_centro_costo_inven.EditValue.ToString());
                info.IdCentro_Costo_Costo = (cmb_centro_costo_cta_centro_costo.EditValue == null ? null : cmb_centro_costo_cta_centro_costo.EditValue.ToString());
                info.IdCentroCosto_Padre_a_cargar = (cmb_centro_costo_padre_costo_inven.EditValue == null ? null : cmb_centro_costo_padre_costo_inven.EditValue.ToString());               
                info.IdMovi_Inven_tipo_x_anu_Ing = Convert.ToInt32(cmb_tipo_movi_inven_anu_ing.EditValue);
                info.IdMovi_Inven_tipo_x_anu_Egr = Convert.ToInt32(cmb_tipo_movi_inven_anu_egr.EditValue);
                info.IdSucursalSuministro = ucIn_Sucursal_Bodega1.get_bodega().IdSucursal;
                info.IdBodegaSuministro = ucIn_Sucursal_Bodega1.get_bodega().IdBodega;
                if (cmb_tipo_movi_inven_x_transf_ing.EditValue == null)
                { info.IdMovi_inven_tipo_ingresoBodegaDestino = null; }
                else
                { info.IdMovi_inven_tipo_ingresoBodegaDestino = Convert.ToInt32(cmb_tipo_movi_inven_x_transf_ing.EditValue); }
                if (cmb_tipo_movi_inven_x_transf_egr.EditValue == null)
                { info.IdMovi_inven_tipo_egresoBodegaOrigen = null; }
                else
                { info.IdMovi_inven_tipo_egresoBodegaOrigen = Convert.ToInt32(cmb_tipo_movi_inven_x_transf_egr.EditValue); }
                if (cmb_tipo_movi_inven_egr_x_ajus_fisico.EditValue == null)
                { info.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa = null; }
                else
                { info.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa = Convert.ToInt32(cmb_tipo_movi_inven_egr_x_ajus_fisico.EditValue); }
                if (cmb_tipo_movi_inven_ing_x_ajus_fisico.EditValue == null)
                { info.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa = null; }
                else
                { info.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa = Convert.ToInt32(cmb_tipo_movi_inven_ing_x_ajus_fisico.EditValue); }
                info.ApruebaAjusteFisicoAuto = (ckAjust.Checked==true?"S":"N");
                if (cmb_tipo_movi_inven_ing_x_ajus.EditValue == null)
                { info.IdMovi_inven_tipo_ingresoAjuste = null; }
                else
                { info.IdMovi_inven_tipo_ingresoAjuste = Convert.ToInt32(cmb_tipo_movi_inven_ing_x_ajus.EditValue); }
                if (cmb_tipo_movi_inven_egr_x_ajus.EditValue == null)
                { info.IdMovi_inven_tipo_egresoAjuste = null; }
                else
                { info.IdMovi_inven_tipo_egresoAjuste = Convert.ToInt32(cmb_tipo_movi_inven_egr_x_ajus.EditValue); }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                getParametrosInventario();
                if (bus.ModificarDB(info, param.IdEmpresa)) 
                { MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk); } 
                else { MessageBox.Show("Parametros de Inventario no pueden ser Ingresados"); }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }
     
        private void btnsalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.ParentForm.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbStockNeg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
