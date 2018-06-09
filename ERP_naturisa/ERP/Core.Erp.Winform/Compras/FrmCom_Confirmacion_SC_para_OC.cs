using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Confirmacion_SC_para_OC : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<com_solicitud_compra_det_aprobacion_Info> lstSolCompra = new BindingList<com_solicitud_compra_det_aprobacion_Info>();
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus busSucur = new tb_Sucursal_Bus();        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public FrmCom_Confirmacion_SC_para_OC()
        {
            InitializeComponent();
        }

        private void FrmCom_Confirmacion_SC_para_OC_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        void CargarCombo()
        {
            try
            {
                listSucursal = new List<tb_Sucursal_Info>();
                listSucursal = busSucur.Get_List_Sucursal(param.IdEmpresa);
                cmb_Sucursal.DataSource = listSucursal;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Grid(List<com_solicitud_compra_det_aprobacion_Info> lstComp)
        {
            try
            {


                foreach (var item in lstComp)
                {
                    item.IdSucursal_x_OC = item.IdSucursal_SC; 
                }

                lstSolCompra = new BindingList<com_solicitud_compra_det_aprobacion_Info>(lstComp);
                gridConfirmacionSC.DataSource = lstSolCompra;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }



        public List<com_solicitud_compra_det_aprobacion_Info> get_Grid()
        {
            try
            {
                int IdSucursal = 0;

                if (chkSucursalConsolidada.Checked)
                {
                    IdSucursal = ucGe_Sucursal.get_SucursalInfo().IdSucursal;

                    foreach (var item in lstSolCompra)
                    {
                            item.IdSucursal_x_OC = IdSucursal;
                    }

                }

                return new List<com_solicitud_compra_det_aprobacion_Info>(lstSolCompra);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<com_solicitud_compra_det_aprobacion_Info>();
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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
