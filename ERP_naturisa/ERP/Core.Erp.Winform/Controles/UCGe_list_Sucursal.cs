using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_list_Sucursal : UserControl
    {

        public UCGe_list_Sucursal()
        {
            try
            {
                InitializeComponent();
                event_gridViewSucursales_CellValueChanged += UCGE_Sucursal_event_gridViewSucursales_CellValueChanged;
                gridControlSucursales.DataSource = bindSuc;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void UCGE_Sucursal_event_gridViewSucursales_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e){}
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        tb_Sucursal_Bus busSuc = new tb_Sucursal_Bus();
        BindingList<tb_Sucursal_Info> bindSuc = new BindingList<tb_Sucursal_Info>();
        public void setSucursal(List<tb_Empresa_Info> empresas)
        {
            List<tb_Sucursal_Info> sucursales = new List<tb_Sucursal_Info>();
            try
            {
                List<tb_Sucursal_Info> tempSuc = new List<tb_Sucursal_Info>();
                foreach (var item in empresas)
                {
                    tempSuc = busSuc.Get_List_Sucursal(item.IdEmpresa);
                    tempSuc.ForEach(var=>var.NomEmpresa = item.em_nombre);
                    sucursales.AddRange(tempSuc);
                }
                bindSuc = new BindingList<tb_Sucursal_Info>(sucursales);
                gridControlSucursales.DataSource = bindSuc;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        List<tb_Sucursal_Info> sucursales = new List<tb_Sucursal_Info>();
                
        public List<tb_Sucursal_Info> getSucursalSeleccionadas()
        {
            List<tb_Sucursal_Info> tempsucursales = new List<tb_Sucursal_Info>();
            try
            {
                sucursales = new List<tb_Sucursal_Info>();
                sucursales = bindSuc.ToList();
                tempsucursales  = sucursales.FindAll(var => var.Chek == true);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());


                tempsucursales  = new List<tb_Sucursal_Info>();
            }
            return tempsucursales;
        }

        public void seleccionartodas(Boolean check)
        { 
            try
            {
                foreach (var item in bindSuc)
                {
                    item.Chek = check;
                }
                gridControlSucursales.DataSource = bindSuc;
                gridControlSucursales.RefreshDataSource();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        
        }

        private void gridViewSucursales_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                 event_gridViewSucursales_CellValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


        public delegate void Delegate_gridViewSucursales_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e);
        public event Delegate_gridViewSucursales_CellValueChanged event_gridViewSucursales_CellValueChanged;

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkTodos.Checked == true)
                    seleccionartodas(Convert.ToBoolean(true));
                else seleccionartodas(Convert.ToBoolean(false));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        
    }
}
