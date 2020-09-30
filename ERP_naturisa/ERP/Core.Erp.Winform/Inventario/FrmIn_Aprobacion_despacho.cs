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
using Core.Erp.Reportes.Inventario;


namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Aprobacion_despacho : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_movi_inve_Bus bus_movi_inven = new in_movi_inve_Bus();
        List<in_movi_inve_Info> lst_movi_inven_aprobadas = new List<in_movi_inve_Info>();
        BindingList<in_movi_inve_Info> blist_movi_inven = new BindingList<in_movi_inve_Info>();
        #endregion

        public FrmIn_Aprobacion_despacho()
        {
            InitializeComponent();
        }

        private void UCge_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void UCge_Menu_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Aprobar())
                {
                    Buscar_movi_inven_x_despachar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Buscar_movi_inven_x_despachar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCge_Menu_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Aprobar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Aprobacion_despacho_Load(object sender, EventArgs e)
        {
            try
            {
                Buscar_movi_inven_x_despachar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCge_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        private bool Validar()
        {
            try
            {
                if (ucIn_Sucursal_Bodega1.get_sucursal() == null)
                {
                    MessageBox.Show("Seleccione una sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (ucIn_Sucursal_Bodega1.get_bodega() == null)
                {
                    MessageBox.Show("Seleccione una bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Buscar_movi_inven_x_despachar()
        {
            try
            {
                blist_movi_inven = new BindingList<in_movi_inve_Info>(bus_movi_inven.Get_list_Movi_inven_x_despachar(param.IdEmpresa, ucIn_Sucursal_Bodega1.get_IdSucursal(), ucIn_Sucursal_Bodega1.get_IdBodega()));
                gridControlDespacho.DataSource = blist_movi_inven;
                if (blist_movi_inven.Count==0)
                {
                    MessageBox.Show("No existen egresos pendientes de aprobar de la sucursal: "+ucIn_Sucursal_Bodega1.get_sucursal().Su_Descripcion+" y bodega: "+ucIn_Sucursal_Bodega1.get_bodega().bo_Descripcion,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_Lista_aprobar()
        {
            try
            {
                chk_imprimir_transacciones_aprobadas.Focus();
                lst_movi_inven_aprobadas = new List<in_movi_inve_Info>(blist_movi_inven.Where(q=>q.Checked==true).ToList());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Aprobar()
        {
            try
            {
                Get_Lista_aprobar();

                if (bus_movi_inven.Actualizar_estado_despacho(lst_movi_inven_aprobadas))
                {
                    MessageBox.Show("Se ha realizado la transacción exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if(chk_imprimir_transacciones_aprobadas.Checked)
                        Imprimir();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Imprimir()
        {
            try
            {
                foreach (var item in lst_movi_inven_aprobadas)
                {
                    XINV_Rpt002_Rpt rpt = new XINV_Rpt002_Rpt();
                    rpt.IdEmpresa.Value = item.IdEmpresa;
                    rpt.IdEmpresa.Visible = false;
                    rpt.IdSucursal.Value = item.IdSucursal;
                    rpt.IdSucursal.Visible = false;
                    rpt.IdBodega.Value = item.IdBodega;
                    rpt.IdBodega.Visible = false;
                    rpt.IdMovi_inven_tipo.Value = item.IdMovi_inven_tipo;
                    rpt.IdMovi_inven_tipo.Visible = false;
                    rpt.IdNumMovi.Value = item.num_Trans;
                    rpt.IdNumMovi.Visible = false;
                    rpt.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDespacho_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                in_movi_inve_Info row = (in_movi_inve_Info)gridViewDespacho.GetRow(e.RowHandle);

                if (row == null)
                    return;

                if (e.Column == colReporte)
                {
                    XINV_Rpt002_Rpt rpt = new XINV_Rpt002_Rpt();
                    rpt.IdEmpresa.Value = row.IdEmpresa;
                    rpt.IdEmpresa.Visible = false;
                    rpt.IdSucursal.Value = row.IdSucursal;
                    rpt.IdSucursal.Visible = false;
                    rpt.IdBodega.Value = row.IdBodega;
                    rpt.IdBodega.Visible = false;
                    rpt.IdMovi_inven_tipo.Value = row.IdMovi_inven_tipo;
                    rpt.IdMovi_inven_tipo.Visible = false;
                    rpt.IdNumMovi.Value = row.num_Trans;
                    rpt.IdNumMovi.Visible = false;
                    rpt.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
