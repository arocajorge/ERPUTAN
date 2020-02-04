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

using Core.Erp.Info.General;
using Core.Erp.Business.General;



namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Consulta_Mov_Inven : Form
    {
        List<in_Ing_Egr_Inven_Info> lista_movi_inv = new List<in_Ing_Egr_Inven_Info>();
        in_Ing_Egr_Inven_Bus BusMovi_Inven = new in_Ing_Egr_Inven_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        in_Ing_Egr_Inven_Info Info_Movi_Inven = new in_Ing_Egr_Inven_Info();


        public in_Ing_Egr_Inven_Info Get_Info_Movi_Inv()
        {
            try
            {
                
                return Info_Movi_Inven;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void set_busqueda(int IdSucursal, string sTipoMovi)
        {
            try
            {
                ucIn_Sucursal_Bodega.set_Idsucursal(IdSucursal);
                //ucIn_Sucursal_Bodega.set_Idbodega(IdSucursal, IdBodega);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmIn_Consulta_Mov_Inven()
        {
            InitializeComponent();
            dtpFecha_desde.Value = DateTime.Now.AddMonths(-1);
            dtpFecha_hasta.Value = DateTime.Now.AddMonths(1);
        }

        private void FrmIn_Consulta_Mov_Inven_Load(object sender, EventArgs e)
        {


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdSucursal = ucIn_Sucursal_Bodega.get_sucursal().IdSucursal;
                //int IdBodega = ucIn_Sucursal_Bodega.get_bodega().IdBodega;
                DateTime Fecha_ini = Convert.ToDateTime(dtpFecha_desde.Value);
                DateTime Fecha_fin = Convert.ToDateTime(dtpFecha_hasta.Value);
                lista_movi_inv = BusMovi_Inven.Get_List_Ing_Egr_Inven_para_devolucion(param.IdEmpresa, IdSucursal, 0, "-", Fecha_ini, Fecha_fin);

                gridControl_Egresos_Varios.DataSource = lista_movi_inv;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridView_Egreso_varios_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info_Movi_Inven = new in_Ing_Egr_Inven_Info();
                Info_Movi_Inven = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private in_Ing_Egr_Inven_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (in_Ing_Egr_Inven_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new in_Ing_Egr_Inven_Info();
            }
        }

        private void gridView_Egreso_varios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Info_Movi_Inven = new in_Ing_Egr_Inven_Info();
                Info_Movi_Inven = GetSelectedRow(gridView_Egreso_varios);
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Info_Movi_Inven = new in_Ing_Egr_Inven_Info();
                Info_Movi_Inven = GetSelectedRow(gridView_Egreso_varios);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
