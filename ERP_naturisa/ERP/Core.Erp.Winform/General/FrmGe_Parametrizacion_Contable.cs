using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;


namespace Core.Erp.Winform.General
{    

    public partial class FrmGe_Parametrizacion_Contable : Form
    {
        #region Declaración de Variables
        //error        
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError;

        
        FrmGe_ProcesosaContabilizarMant PCMant = new FrmGe_ProcesosaContabilizarMant();
        //sucursal
        

        //por categoria
        
        //ct_plancta
        ct_Plancta_Bus ctplactaBus = new ct_Plancta_Bus();
        List<ct_Plancta_Info> ctplactaInfo = new List<ct_Plancta_Info>();

        //ct_centro_costo
        ct_Centro_costo_Bus centroCostoBus = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> centroCostoInfo = new List<ct_Centro_costo_Info>();

        //in_categorias
        in_categorias_bus incategoriabus = new in_categorias_bus();
        in_categorias_Info incategoriaInfo = new in_categorias_Info();

        

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //Tipo Contabilizacion
        tb_sis_Param_Cont_Tipo_Contabilizacion_Bus ParamContTipoContaBus = new tb_sis_Param_Cont_Tipo_Contabilizacion_Bus();

        // info
        
        //Bus
        

        //Sucursales
        tb_Sucursal_Bus sucubBUS = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> lstSucu = new List<tb_Sucursal_Info>();

        // Pestaña Tipo de Prametros
        
        //listas
        List<dc> lstDebito_Credito = new List<dc>();

        vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Bus vistSucuBus = new vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Bus();
        

        in_categorias_bus catBus = new in_categorias_bus();

        int tab = 0;
        #endregion
               
        public FrmGe_Parametrizacion_Contable()
        {
            try
            {
                InitializeComponent();
                combcreditodebito();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                PCMant = new FrmGe_ProcesosaContabilizarMant();
                PCMant.event_FrmGe_ProcesosaContabilizarMant_FormClosing += new FrmGe_ProcesosaContabilizarMant.delegate_FrmGe_ProcesosaContabilizarMant_FormClosing(frm_event_FrmGe_ProcesosaContabilizarMant_FormClosing);
                PCMant.MdiParent = this.MdiParent;

                
                PCMant.set_Accion(Accion);
                PCMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_event_FrmGe_ProcesosaContabilizarMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                
                load();
                BlanquearGrillas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void FrmGe_Parametrizacion_Contable_Load(object sender, EventArgs e)
        {
            try
            {
                  load();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }

        void combcreditodebito()
        {
            try
            {
                dc _dc = new dc();
                _dc.Dbcr = "D";
                _dc.descripcion = "Debito";
                lstDebito_Credito.Add(_dc);
                _dc = new dc();
                _dc.Dbcr = "C";
                _dc.descripcion = "Credito";
                lstDebito_Credito.Add(_dc);
                repositorycomboCreditoDebito.ValueMember = repositoryCreditoDebitoCmbCat.ValueMember = "Dbcr";
                repositorycomboCreditoDebito.DisplayMember = repositoryCreditoDebitoCmbCat.DisplayMember = "descripcion";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void load() 
        {
            try
            {
                string MensajeError = "";

                
                
                groupBox1.Focus();

                repositorySucursal.DataSource = repositorySucursalCat.DataSource = sucubBUS.Get_List_Sucursal(param.IdEmpresa);
                repositoryCategoria.DataSource = catBus.Get_List_categorias(param.IdEmpresa);
                
                repositoryItemSearchLookUpEdit1.DataSource = ParamContTipoContaBus.ConsultarParamConta();
                repositorycomboCreditoDebito.DataSource = repositoryCreditoDebitoCmbCat.DataSource = lstDebito_Credito;
                ctplactaInfo = new List<ct_Plancta_Info>(ctplactaBus.Get_List_Plancta(param.IdEmpresa, ref MensajeError));
                repositoryItemSearchLookUpEditCCS.DataSource = repositoryItemSearchLookUpEditCCC.DataSource = ctplactaInfo;


                centroCostoInfo = new List<ct_Centro_costo_Info>(centroCostoBus.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError));
                repositoryItemSearchLookUpEditCentroCosto.DataSource = repositoryItemGridLookUpEditCentroCostoCategoria.DataSource = centroCostoInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btn_guardarysalir_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (xtraTabControl1.SelectedTabPage == tabParametroCble)
                {
                    Btn_Nuevo.Focus();
                    grabar();
                    modificarParamContProceso();
                }
                if (xtraTabControl1.SelectedTabPage == tabTipoParametro)
                {
                    btnNuevo.Focus();
                    modifiTipo();
                    actualizarGridParametro();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        void modifiTipo()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void modificarParamContProceso()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean grabarNoExiste()
        {
            try
            {
                
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean grabarNoExisteC()
        {
            try
            {
                
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void grabar() {
            try
            {
                if (tabControl1.SelectedTab == tabPage1)
	            {
                    grabarNoExiste();


                }
                else
                {
                    grabarNoExisteC();
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
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

        private void gridViewParamCantProc_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BlanquearGridControlPCxS()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BlanquearGrillas()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BlanquearGridControlPCxSxC()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGe_sis_Param_Cont_x_Parametro_Mant frmParametro = new FrmGe_sis_Param_Cont_x_Parametro_Mant();
                frmParametro.Event_frmGe_sis_Param_Cont_x_Parametro_Mant_FormClosing += new FrmGe_sis_Param_Cont_x_Parametro_Mant.delegate_frmGe_sis_Param_Cont_x_Parametro_Mant_FormClosing(frmParametro_Event_frmGe_sis_Param_Cont_x_Parametro_Mant_FormClosing);
                frmParametro.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void actualizarGridParametro()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmParametro_Event_frmGe_sis_Param_Cont_x_Parametro_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                actualizarGridParametro();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
     
        private void gridViewParamCantProc_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void vaciarGridViewParamCantProc()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewParamCantProc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                vaciarGridViewParamCantProc();
                gridViewParamCantProc.SetFocusedRowCellValue(colCheck, true);

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewPCxS_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        void TransformarDOC()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        void blanquearGrid()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ActualizarGridAsigna()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
             try
             {
                
                

             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
                 
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void btnAllNext_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAllPrevius_Click(object sender, EventArgs e)
        {
             
        }

        private void cmbProcesoContable_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProcesoContable.EditValue == null || cmbProcesoContable.Text == "")
                {
                    blanquearGrid();
                }
                else 
                {
                    ActualizarGridAsigna();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewProcesoParametros_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void gridViewPCxSxC_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }
    }
  
    public class dc
    {

        public string Dbcr { get; set; }
        public string descripcion { get; set; }
    }


}
