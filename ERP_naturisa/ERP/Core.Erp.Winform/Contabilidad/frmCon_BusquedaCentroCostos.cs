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


using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;


namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_BusquedaCentroCostos : Form
    {      
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ct_Centro_costo_Info _CentroCostoInfo = new ct_Centro_costo_Info();
        ct_Centro_costo_Bus _CentroCostoBus = new ct_Centro_costo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public ct_Centro_costo_Info CentroCostoInfo { get; set; }
        #endregion

        public frmCon_BusquedaCentroCostos()
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

        private void frmCon_BusquedaCentroCostos_Load(object sender, EventArgs e)
        {
            try
            {
                string MensajeError = "";
                treeList_CentroCosto.DataSource = _CentroCostoBus.Get_list_Centro_Costo(param.IdEmpresa,ref MensajeError);
                treeList_CentroCosto.ExpandAll();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void btn_salir_Click(object sender, EventArgs e)
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

        private void treeList_CentroCosto_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                TreeListColumn Centro_costo = treeList_CentroCosto.Columns["Centro_costo"];
                TreeListColumn Centro_costoPadre = treeList_CentroCosto.Columns["Centro_costoPadre"];
                TreeListColumn IdCentroCosto = treeList_CentroCosto.Columns["IdCentroCosto"];
                TreeListColumn IdCtaCble = treeList_CentroCosto.Columns["IdCtaCble"];

                _CentroCostoInfo.Centro_costo = Convert.ToString(e.Node.GetValue(Centro_costo));
                _CentroCostoInfo.Centro_costoPadre = Convert.ToString(e.Node.GetValue(Centro_costoPadre));
                _CentroCostoInfo.IdCentroCosto = Convert.ToString(e.Node.GetValue(IdCentroCosto));
                _CentroCostoInfo.IdCtaCble = Convert.ToString(e.Node.GetValue(IdCtaCble));

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                CentroCostoInfo = _CentroCostoInfo;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeList_CentroCosto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CentroCostoInfo = _CentroCostoInfo;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
