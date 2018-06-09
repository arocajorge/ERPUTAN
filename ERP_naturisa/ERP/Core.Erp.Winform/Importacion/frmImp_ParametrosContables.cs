using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;


namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_ParametrosContables : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        imp_gastosximport_x_empresa_Bus _GastoxImpxEmpre_B = new imp_gastosximport_x_empresa_Bus();
        imp_gastosxImport_Bus _GastXimp_B = new imp_gastosxImport_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Plancta_Bus _plancta_bus = new ct_Plancta_Bus();
        List<imp_gastosxImport_Info> LstGastosXimport = new List<imp_gastosxImport_Info>();
        List<imp_gastosximport_x_empresa_Info> LstGastoXImprXEmpresa = new List<imp_gastosximport_x_empresa_Info>();
        imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Bus BusTipoDoc = new imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Bus();
        List<ct_Plancta_Info> ct_Plancta_Info = new List<ct_Plancta_Info>();

        string MensajeError = "";

        public frmImp_ParametrosContables()
        {
            try
            {

                InitializeComponent();
                CargarGridGastoXImportacionXEmpresa();
                CargarTipoDocPagoXEmpresXTipo();
                CargarCombosTab3();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
       
        #region Tab1

        void CargarGridGastoXImportacionXEmpresa() 
        {

            try
            {
                LstGastosXimport = _GastXimp_B.Get_List_gastosxImport();
                LstGastoXImprXEmpresa = _GastoxImpxEmpre_B.Get_List_gastosximport_x_empresa();

                var Lst = from q in LstGastoXImprXEmpresa
                          join e in LstGastosXimport
                          on new { q.IdGastoImp } equals new { e.IdGastoImp }
                          where q.IdEmpresa == param.IdEmpresa
                          select new { q.IdEmpresa, q.IdGastoImp, q.IdCtaCble, q.debCre_Provicion, q.debcre_DebBanco, e.ga_decripcion, e.CodGastoImp, q.AfectaLiquidacion };

                LstGastoXImprXEmpresa = new List<imp_gastosximport_x_empresa_Info>();

                foreach (var item in Lst.ToList())
                {
                    imp_gastosximport_x_empresa_Info obj = new imp_gastosximport_x_empresa_Info();
                    obj.CodGastoImp = item.CodGastoImp;
                    obj.debcre_DebBanco = (item.debcre_DebBanco == "C") ? "CREDITO" : "DEBITO";
                    obj.debCre_Provicion = (item.debCre_Provicion == "C") ? "CREDITO" : "DEBITO"; ;
                    obj.ga_decripcion = item.ga_decripcion;
                    obj.IdCtaCble = item.IdCtaCble;
                    obj.IdGastoImp = item.IdGastoImp;
                    obj.AfectaLiquidacion = item.AfectaLiquidacion;
                    if (item.IdCtaCble == null)
                        obj.EstaEnBase = "N";
                    else
                        obj.EstaEnBase = "S";
                    LstGastoXImprXEmpresa.Add(obj);
                }
                gridControlParametros.DataSource = LstGastoXImprXEmpresa;
                ct_Plancta_Info = _plancta_bus.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);//.FindAll(var => var.IdNivelCta == 6);
                //ct_Plancta_Info.ForEach(var => var.IdCtaCblePadre = "");

                repositoryItemGridLookUpEdit1.DataSource = ct_Plancta_Info;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_tab1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                txtNADA.Focus();
                //toolStrip1.Focus();

                var Guardar = (List<imp_gastosximport_x_empresa_Info>)gridControlParametros.DataSource;
                Guardar.ForEach(var => var.IdEmpresa = param.IdEmpresa);
                imp_gastosximport_x_empresa_Bus Bus = new imp_gastosximport_x_empresa_Bus();
                foreach (var item in Guardar)
                {
                    if (item.EstaEnBase == "N" && item.IdCtaCble != null)
                    {

                        Bus.Guardar(item);
                    }
                }
                var Actualizar = Guardar.FindAll(var => var.IdCtaCble != null);
                if (Bus.Actualizar(Actualizar))
                {
                    MessageBox.Show("Registros Actualizados Correctamente");
                    CargarGridGastoXImportacionXEmpresa();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_tab1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region Tab2

        void CargarTipoDocPagoXEmpresXTipo()
        {

            try
            {
                ct_Cbtecble_tipo_Bus _cbteCble_B = new ct_Cbtecble_tipo_Bus();
                var Cbtebl = _cbteCble_B.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);


                repositoryItemSearchLookUpEdit1.DataSource = Cbtebl;
                GridControlTipoDoc.DataSource = BusTipoDoc.Get_List_Tipo_docu_pago_x_Empresa_x_tipocbte(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void ucGe_Menu_tab2_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Focus();
                List<imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info> Guardar = (List<imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info>)GridControlTipoDoc.DataSource;
                Guardar.ForEach(var => var.IdEmpresa = param.IdEmpresa);
                if (BusTipoDoc.ModificarDB(Guardar))
                {
                    MessageBox.Show("Registros Actualizados Correctamente");
                    CargarTipoDocPagoXEmpresXTipo();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_tab2_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region Tab3

        void CargarCombosTab3() 
        {
            try
            {
                ct_Cbtecble_tipo_Bus _cbteCble_B = new ct_Cbtecble_tipo_Bus();
                ct_Plancta_Bus Plncta_B = new ct_Plancta_Bus();
                var Cbtebl_Tipo = _cbteCble_B.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);
                //cmbCtaCombleImporta.Properties.DataSource = ct_Plancta_Info;
                //searchLookUpEditFOB.Properties.DataSource = Cbtebl_Tipo;
                //searchLookUpEdit2FOBAnul.Properties.DataSource = Cbtebl_Tipo;
                //searchLookUpEditLiqu.Properties.DataSource = Cbtebl_Tipo;
                //searchLookUpEditLiquAnul.Properties.DataSource = Cbtebl_Tipo;


                imp_Parametros_Bus _Parametros_B = new imp_Parametros_Bus();
                var para = _Parametros_B.Get_Info_Parametros(param.IdEmpresa);
                //cmbCtaCombleImporta.EditValue = para.IdCtaCble_para_Importaciones;
                //searchLookUpEditFOB.EditValue = para.IdTipoCbte_DiarioFob;
                //searchLookUpEdit2FOBAnul.EditValue = para.IdTipoCbte_DiarioFob_Anul;
                //searchLookUpEditLiqu.EditValue = para.IdTipoCbte_DiarioLiquidacion;
                //searchLookUpEditLiquAnul.EditValue = para.IdTipoCbte_DiarioLiquidacion_Anul;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
       
        private void ucGe_Menu_tab3_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                txtNADA.Focus();
                imp_Parametros_Info Info = new imp_Parametros_Info();
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdCtaCble_para_Importaciones = ucCon_PlanCtaCmbCtaCombleImporta.get_PlanCtaInfo().IdCtaCble; //Convert.ToString(cmbCtaCombleImporta.EditValue);
                Info.IdTipoCbte_DiarioFob = ucCon_TipoCbteCbleFOBGenera.get_TipoCbteCble().IdTipoCbte; //(int)searchLookUpEditFOB.EditValue;
                Info.IdTipoCbte_DiarioFob_Anul = ucCon_TipoCbteCbleFOBAnul.get_TipoCbteCble().IdTipoCbte; //(int)searchLookUpEdit2FOBAnul.EditValue;
                Info.IdTipoCbte_DiarioLiquidacion = ucCon_TipoCbteCbleLiquidacion.get_TipoCbteCble().IdTipoCbte; //(int)searchLookUpEditLiqu.EditValue;
                Info.IdTipoCbte_DiarioLiquidacion_Anul = ucCon_TipoCbteCbleAnula_Liqui.get_TipoCbteCble().IdTipoCbte; //(int)searchLookUpEditLiquAnul.EditValue;
                imp_Parametros_Bus _Parametros_B = new imp_Parametros_Bus();
                if (_Parametros_B.ModificarDB(Info))
                {
                    MessageBox.Show("Registros Actualizados Correctamente");
                    CargarCombosTab3();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_tab3_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion
        
        private void searchLookUpEdit2FOBAnul_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmImp_ParametrosContables_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGridGastoXImportacionXEmpresa();
                CargarTipoDocPagoXEmpresXTipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
