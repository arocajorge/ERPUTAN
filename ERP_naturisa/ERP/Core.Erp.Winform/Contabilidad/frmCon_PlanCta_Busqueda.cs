using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using DevExpress.XtraTreeList.Nodes;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_PlanCta_Busqueda : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";

        public frmCon_PlanCta_Busqueda()
        {
            try
            {
                InitializeComponent();
                cargartree();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }   
        List<ct_Plancta_Info> _ListPlanCtaInfo = new List<ct_Plancta_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public void cargartree()
        {
            try
            {
                ct_Plancta_Bus _PlanCtaBus = new ct_Plancta_Bus();


                _ListPlanCtaInfo = _PlanCtaBus.Get_List_Plancta(param.IdEmpresa, ref MensajeError);
                _ListPlanCtaInfo.ForEach(var => var.IdCtaCblePadre = BuscarPadre(var.IdCtaCblePadre));
                this.treeListPlanCta.DataSource = _ListPlanCtaInfo.FindAll(var => var.IdNivelCta == 6);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        string BuscarPadre(string idcuenta) 
        {
            try
            {
                if (idcuenta != "0")
                {
                    return _ListPlanCtaInfo.Find(var => var.IdCtaCble == idcuenta).pc_Cuenta;
                }
                else return "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            
        }
        private void treeListPlanCta_DoubleClick(object sender, EventArgs e)
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
      
        public delegate void Delegate_SetObj(string IdcbteCble);
        public event Delegate_SetObj Event_SetObj;
        public void SetObj(string IdcbteCble) 
        {
            try
            {
               Event_SetObj(IdcbteCble);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      
        
        ct_Plancta_Info _PlanCtaInfo = new ct_Plancta_Info();
        private void treeListPlanCta_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                TreeListNode childNode = (TreeListNode)e.Node;
                 _PlanCtaInfo = (ct_Plancta_Info)treeListPlanCta.GetDataRecordByNode(childNode);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void frmCon_PlanCta_Busqueda_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              Event_SetObj(_PlanCtaInfo.IdCtaCble);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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
    }
}
