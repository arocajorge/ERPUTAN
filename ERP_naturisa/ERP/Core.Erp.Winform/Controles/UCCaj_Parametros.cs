using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Caja;
using Core.Erp.Info.Caja;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCaj_Parametros : UserControl
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ct_Plancta_Bus Cta_B = new ct_Plancta_Bus();
        List<ct_Plancta_Info> LstCta = new List<ct_Plancta_Info>();
        List<ct_Cbtecble_tipo_Info> LstTipoCbte = new List<ct_Cbtecble_tipo_Info>();
        ct_Cbtecble_tipo_Bus TipoCbte_B = new ct_Cbtecble_tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        caj_Caja_Movimiento_Tipo_Bus moviTipo_B = new caj_Caja_Movimiento_Tipo_Bus();
        List<caj_Caja_Movimiento_Tipo_Info> LstMoviTipo = new List<caj_Caja_Movimiento_Tipo_Info>();
        caj_parametro_Info ParamCaja_I = new caj_parametro_Info();
        List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info> LstTipoxCta = new List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info>();
        caj_parametro_Bus parameCaja_B = new caj_parametro_Bus();
        string MensajeError = "";

        #endregion

        public UCCaj_Parametros()
        {
            InitializeComponent();
            
            try
            {
                CargaTipoCbt();
                CargaGrid();
                CargaComboGrid();
                set();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        private void CargaTipoCbt()
        {
            try
            {
                LstTipoCbte = TipoCbte_B.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set()
        {
            try
            {
                ParamCaja_I = parameCaja_B.Get_Info_Parametro(param.IdEmpresa);

                ultraCmbE_TipoCbte_Ingreso.set_TipoCbteCble(ParamCaja_I.IdTipoCbteCble_MoviCaja_Ing);
                ultraCmbE_TipoCbte_AnulaEgreso.set_TipoCbteCble(ParamCaja_I.IdTipoCbteCble_MoviCaja_Egr_Anu);
                ultraCmbE_TipoCbte_AnulaIngreso.set_TipoCbteCble(ParamCaja_I.IdTipoCbteCble_MoviCaja_Ing_Anu);
                ultraCmbE_TipoCbte_Egreso.set_TipoCbteCble( ParamCaja_I.IdTipoCbteCble_MoviCaja_Egr);
                uccaj_tipo_movi_ingreso.set_MovimientoInfo(ParamCaja_I.IdTipo_movi_ing_x_reposicion);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void CargaComboGrid()
        {
            try
            {
                repositoryItemSearchLookUpEdit_TipoMovi.DataSource = LstMoviTipo;
                LstCta = Cta_B.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                repositoryItemSearchLookUpEdit_Cta.DataSource = LstCta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void CargaGrid()
        {
            try
            {
                LstMoviTipo = moviTipo_B.Get_list_Caja_Movimiento_Tipo(ref  MensajeError);
                gridControl_tipoXCta.DataSource = LstMoviTipo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void get_Info()
        {
            try
            {


                ParamCaja_I.IdEmpresa = param.IdEmpresa;
                ParamCaja_I.IdTipoCbteCble_MoviCaja_Egr = ultraCmbE_TipoCbte_Egreso.get_TipoCbteCble().IdTipoCbte;
                ParamCaja_I.IdTipoCbteCble_MoviCaja_Egr_Anu = ultraCmbE_TipoCbte_AnulaEgreso.get_TipoCbteCble().IdTipoCbte;
                ParamCaja_I.IdTipoCbteCble_MoviCaja_Ing = ultraCmbE_TipoCbte_Ingreso.get_TipoCbteCble().IdTipoCbte;
                ParamCaja_I.IdTipoCbteCble_MoviCaja_Ing_Anu = ultraCmbE_TipoCbte_AnulaIngreso.get_TipoCbteCble().IdTipoCbte;
                if (uccaj_tipo_movi_ingreso.get_MovimientoInfo() != null)
                    ParamCaja_I.IdTipo_movi_ing_x_reposicion = Convert.ToInt32(uccaj_tipo_movi_ingreso.get_MovimientoInfo().IdTipoMovi);
                else
                    ParamCaja_I.IdTipo_movi_ing_x_reposicion = null;
                ParamCaja_I.IdUsuario = param.IdUsuario;
                ParamCaja_I.IdUsuarioUltMod = param.IdUsuario;
                ParamCaja_I.Fecha_Transac = param.Fecha_Transac;
                ParamCaja_I.FechaUltMod = param.Fecha_Transac;

                int focus = 0;
                focus = gridView_tipoXCta.FocusedRowHandle;
                gridView_tipoXCta.FocusedRowHandle = focus + 1;

                var c = (List<caj_Caja_Movimiento_Tipo_Info>)gridControl_tipoXCta.DataSource;

                foreach (var item in c)
                {
                    caj_Caja_Movimiento_Tipo_x_CtaCble_Info inf = new caj_Caja_Movimiento_Tipo_x_CtaCble_Info();
                    inf.IdEmpresa = param.IdEmpresa;
                    inf.IdTipoMovi = item.IdTipoMovi;
                    inf.IdCtaCble = item.IdCtaCble;

                    LstTipoxCta.Add(inf);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean Validar()
        {
            try
            {
                ultraCmbE_TipoCbte_Ingreso.Focus();

                if (ultraCmbE_TipoCbte_Ingreso.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Por Favor seleccione el Tipo de Comprobante Contable para el Ingreso de Caja");
                    ultraCmbE_TipoCbte_Ingreso.Focus();
                    return false;
                }
                if (ultraCmbE_TipoCbte_AnulaIngreso.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Por Favor seleccione el Tipo de Comprobante Contable para Anular el Ingreso de Caja");
                    ultraCmbE_TipoCbte_AnulaIngreso.Focus();
                    return false;
                }
                if (ultraCmbE_TipoCbte_Egreso.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Por Favor seleccione el Tipo de Comprobante Contable para el Egreso de Caja");
                    ultraCmbE_TipoCbte_Egreso.Focus();
                    return false;
                }
                if (ultraCmbE_TipoCbte_AnulaEgreso.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Por Favor seleccione el Tipo de Comprobante Contable para Anular el Egreso de Caja");
                    ultraCmbE_TipoCbte_AnulaEgreso.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void Grabar()
        {
            try
            {
                if (Validar())
                {
                    get_Info();
                    if (parameCaja_B.ModificarDB(ParamCaja_I, LstTipoxCta))
                        MessageBox.Show("Los parametros de Caja se Guardaron correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo Guardar los parametros de Caja ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void ultraCmbE_TipoCbte_Ingreso_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmbE_TipoCbte_Ingreso.get_TipoCbteCble() == null)
                {
                    ultraCmbE_TipoCbte_Ingreso.Inicializar_cmbTipoCbteCble();
                    return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ultraCmbE_TipoCbte_AnulaIngreso_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmbE_TipoCbte_AnulaIngreso.get_TipoCbteCble() == null)
                {
                    ultraCmbE_TipoCbte_AnulaIngreso.Inicializar_cmbTipoCbteCble();
                    return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ultraCmbE_TipoCbte_Egreso_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmbE_TipoCbte_Egreso.get_TipoCbteCble() == null)
                {
                    ultraCmbE_TipoCbte_Egreso.Inicializar_cmbTipoCbteCble();
                    return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ultraCmbE_TipoCbte_AnulaEgreso_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmbE_TipoCbte_AnulaEgreso.get_TipoCbteCble() == null)
                {
                    ultraCmbE_TipoCbte_AnulaEgreso.Inicializar_cmbTipoCbteCble();
                    return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ultraCmbE_TipoCbte_Ingreso_Load(object sender, EventArgs e)
        {

        }
   

       }
}
