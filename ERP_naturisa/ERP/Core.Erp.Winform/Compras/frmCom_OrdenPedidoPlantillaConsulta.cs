using Core.Erp.Business.Compras;
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
using Core.Erp.Info.General;
using Core.Erp.Info.Compras;

namespace Core.Erp.Winform.Compras
{
    public partial class frmCom_OrdenPedidoPlantillaConsulta : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_OrdenPedidoPlantilla_Bus bus_Orden;
        #endregion

        public frmCom_OrdenPedidoPlantillaConsulta()
        {
            InitializeComponent();
            bus_Orden = new com_OrdenPedidoPlantilla_Bus();
        }

        private void frmCom_OrdenPedidoPlantillaConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Buscar()
        {
            try
            {
                var lst = bus_Orden.GetList(param.IdEmpresa, true);
                gc_Consulta.DataSource = lst;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gc_Consulta.ShowPrintPreview();
        }

        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                com_OrdenPedidoPlantilla_Info row = (com_OrdenPedidoPlantilla_Info)gv_Consulta.GetFocusedRow();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar && row == null)
                {
                    MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                if (Accion == Cl_Enumeradores.eTipo_action.Anular && row.Estado == false)
                {
                    MessageBox.Show("El registro se encuentra anulado",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                frmCom_OrdenPedidoPlantillaMantenimiento frm = new frmCom_OrdenPedidoPlantillaMantenimiento();
                frm.SetInfo(row ?? new com_OrdenPedidoPlantilla_Info(), Accion);
                frm.MdiParent = this.MdiParent;
                frm.event_delegate_frmCom_OrdenPedidoPlantillaMantenimiento_FormClosing += event_delegate_frmCom_OrdenPedidoPlantillaMantenimiento_FormClosing;
                frm.Show();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        void event_delegate_frmCom_OrdenPedidoPlantillaMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Buscar();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.grabar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.actualizar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.consultar);
        }

        private void gv_Consulta_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                com_OrdenPedidoPlantilla_Info row = (com_OrdenPedidoPlantilla_Info)gv_Consulta.GetRow(e.RowHandle);
                if (row != null)
                {
                    if (!row.Estado)
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void gv_Consulta_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                com_OrdenPedidoPlantilla_Info row = (com_OrdenPedidoPlantilla_Info)gv_Consulta.GetRow(e.FocusedRowHandle);
                if (row != null)
                {

                    if (!row.Estado)
                    {
                        gv_Consulta.Appearance.FocusedRow.ForeColor = Color.Red;
                        gv_Consulta.Appearance.FocusedCell.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
