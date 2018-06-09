using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_ParametrizacionContableFacturacion : Form
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ct_Plancta_Info> PlanCuenta = new List<ct_Plancta_Info>();
        ct_Plancta_Bus PlnCta_Bus = new ct_Plancta_Bus();

        
        tb_Sucursal_Bus sucur_b = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> LstSucursales = new List<tb_Sucursal_Info>();
        
        
        in_categorias_bus cat_B = new in_categorias_bus();
        ct_Centro_costo_Bus CentroCosto_B = new ct_Centro_costo_Bus();

        
        string MensajeError = "";

        #endregion

        public frmFa_ParametrizacionContableFacturacion()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                CargarTodo();
                cmbPlnCtaCategoria.EditValueChanging += cmbPlnCtaCategoria_EditValueChanging;
                cmbCentroCostoCat.EditValueChanging += cmbPlnCtaCategoria_EditValueChanging; 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                rbSucursal.Focus();

                
                sucursalsss();
                Categoria();

                MessageBox.Show("Registros Guardados Correctamente"); CargarTodo();
                prgrssBarCate.EditValue = 0;
                prgrssBarSucursal.EditValue = 0;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void cmbPlnCtaCategoria_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
             gridViewXCategoria.SetFocusedRowCellValue(colModificado, "S");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
       
        void CargarTodo() 
        {
            try
            {

                var ListCentroCosto = CentroCosto_B.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);

                
                LstSucursales = sucur_b.Get_List_Sucursal(param.IdEmpresa);
                PlanCuenta = PlnCta_Bus.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                
                cmbCategoria.DataSource = cat_B.Get_List_categorias(param.IdEmpresa);

                cmbCentroCostoCat.DataSource = ListCentroCosto;
                cmbcentroCostoSuc.DataSource = ListCentroCosto;

                

                

                cmbCtasCblesSucursal.DataSource = PlanCuenta;
                CmbSucursalCategoria.DataSource = LstSucursales;
                cmbPlnCtaCategoria.DataSource = PlanCuenta;

                prgrssBarCate.Reset();
                prgrssBarCate.Properties.Step = 1;
                prgrssBarCate.Properties.PercentView = true;
               
                prgrssBarCate.Properties.Minimum = 0;

                prgrssBarSucursal.Reset();
                prgrssBarSucursal.Properties.Step = 1;
                prgrssBarSucursal.Properties.PercentView = true;
                
                prgrssBarSucursal.Properties.Minimum = 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmfa_ParametrizacionContableFacturacion_Load(object sender, EventArgs e) {}

        void Checkear() 
        {
            try
            {
                if (rbSucursal.Checked)
                    tabb.SelectedTabPage = tabScursal;
                else
                    tabb.SelectedTabPage = tabCategoria;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }

        }
        
        private void rbSucursal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Checkear() ;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void rdbXCategoria_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
               Checkear() ;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
  
        }
        
        private void tabb_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                if (tabb.SelectedTabPage == tabScursal)
                {
                    rbSucursal.Checked = true;
                    rdbXCategoria.Checked = false;
                }
                else
                {
                    rbSucursal.Checked = false;
                    rdbXCategoria.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }
        
        void Categoria()
        {
            
        }

        void sucursalsss() 
        {
            
        }

        //private void btnGuardar_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        rbSucursal.Focus();
        //        //System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(sucursalsss));
                
        //        prgrssBarCate.Properties.Maximum = DataSourceCategoria.ToList().FindAll(v=> v.Modificado=="S").Count();
        //        prgrssBarSucursal.Properties.Maximum = DataSourceSucursal.Count();
        //        sucursalsss();
        //        Categoria();

        //        MessageBox.Show("Registros Guardados Correctamente"); CargarTodo();
        //        prgrssBarCate.EditValue = 0;
        //        prgrssBarSucursal.EditValue=0;
            

        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
                
        //    }
        //}

        //private void btnSalir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }

        //}
    }
}
