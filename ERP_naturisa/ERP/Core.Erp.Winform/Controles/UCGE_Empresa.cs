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
    public partial class UCGe_Empresa : UserControl
    {
       
        public UCGe_Empresa()
        {
            try
            {
                
            InitializeComponent();
            Event_gridViewEmpresa_RowCellClick +=UCGE_Empresa_Event_gridViewEmpresa_RowCellClick;
            loaddata();
            gridControlEmpresa.DataSource = bindEmp;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        void UCGE_Empresa_Event_gridViewEmpresa_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e){}

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<tb_Empresa_Info> bindEmp = new BindingList<tb_Empresa_Info>();
        List<tb_Empresa_Info> empresas = new List<tb_Empresa_Info>();
        void loaddata()
        {
            try
            {
                empresas = new List<tb_Empresa_Info>();
                tb_Empresa_Bus busEmpr = new tb_Empresa_Bus();
                empresas = busEmpr.Get_List_Empresa();
                bindEmp = new BindingList<tb_Empresa_Info>(empresas);
                gridControlEmpresa.DataSource = bindEmp;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        
        }

        public void seleccionartodas(Boolean check)
        {
            try
            {
                foreach (var item in bindEmp)
                {
                    item.check = check;
                }
                gridControlEmpresa.DataSource = bindEmp;
                gridControlEmpresa.RefreshDataSource();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }
        public List<tb_Empresa_Info> EmpresasSeleccionadas()
        {
            List<tb_Empresa_Info> resultado = new List<tb_Empresa_Info>();
            try
            {
                empresas = new List<tb_Empresa_Info>();
                empresas = bindEmp.ToList();
                resultado = empresas.FindAll(var => var.check == true);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                resultado = new List<tb_Empresa_Info>();
            }
            return resultado;
        
        }

        private void gridViewEmpresa_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e){}
        public delegate void Delegate_gridViewEmpresa_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e);
        public event Delegate_gridViewEmpresa_RowCellClick Event_gridViewEmpresa_RowCellClick;

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(chkTodos.Checked == true)
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

        private void gridViewEmpresa_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column == colcheck)
                {
                    tb_Empresa_Info row = (tb_Empresa_Info)gridViewEmpresa.GetFocusedRow();

                    if (row != null)
                    {
                        if (row.check == true)
                        {
                            gridViewEmpresa.SetFocusedRowCellValue("check", false);
                        }
                        else
                        {
                            gridViewEmpresa.SetFocusedRowCellValue("check", true);
                        }
                    }
                }
                Event_gridViewEmpresa_RowCellClick(sender, e);
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
