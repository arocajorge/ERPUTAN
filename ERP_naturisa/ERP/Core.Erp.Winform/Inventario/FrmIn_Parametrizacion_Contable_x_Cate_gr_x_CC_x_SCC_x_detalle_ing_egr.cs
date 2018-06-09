using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_x_detalle_ing_egr : Form
    {
        #region 
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<in_Ing_Egr_Inven_det_Info> list_ing_egr = new List<in_Ing_Egr_Inven_det_Info>();
        in_Ing_Egr_Inven_det_Bus bus_ing_egr = new in_Ing_Egr_Inven_det_Bus();

        int IdEmpresa = 0;
        string IdCategoria = "";
        int IdLinea = 0;
        int IdGrupo = 0;
        int IdSubgrupo = 0;
        string IdCentroCosto = "";
        string IdCentroCosto_sub_centro_costo = "";

        #endregion

        public FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_x_detalle_ing_egr()
        {
            InitializeComponent();
        }

        public void Set_parametros(int _IdEmpresa, string _IdCategoria, int _IdLinea, int _IdGrupo, int _IdSubgrupo, string _IdCentroCosto, string _IdCentroCosto_sub_centro_costo)
        {
            try
            {
                IdEmpresa = _IdEmpresa;
                IdCategoria = _IdCategoria;
                IdLinea = _IdLinea;
                IdGrupo = _IdGrupo;
                IdSubgrupo = _IdSubgrupo;
                IdCentroCosto = _IdCentroCosto;
                IdCentroCosto_sub_centro_costo = _IdCentroCosto_sub_centro_costo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_x_detalle_ing_egr_Load(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar()
        {
            try
            {
                list_ing_egr = bus_ing_egr.Get_List_Ing_Egr_det_x_Cat_lin_gru_sub_Centro_subcentro(IdEmpresa, IdCategoria, IdLinea, IdGrupo, IdSubgrupo, IdCentroCosto, IdCentroCosto_sub_centro_costo);
                gridControl_ing_egr_det.DataSource = list_ing_egr;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
