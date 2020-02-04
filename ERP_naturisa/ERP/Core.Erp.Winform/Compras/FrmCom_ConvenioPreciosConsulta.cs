using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Compras
{
    using Core.Erp.Business.Compras;
    using Core.Erp.Business.General;
    using Core.Erp.Info.Compras;
    using Core.Erp.Info.General;
    public partial class FrmCom_ConvenioPreciosConsulta : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param;
        com_ConvenioPreciosPorProducto_Bus bus_convenio;
        #endregion

        public FrmCom_ConvenioPreciosConsulta()
        {
            param = cl_parametrosGenerales_Bus.Instance;
            bus_convenio = new com_ConvenioPreciosPorProducto_Bus();
            InitializeComponent();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.Anular);
        }

        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                com_ConvenioPreciosPorProducto_Info row = (com_ConvenioPreciosPorProducto_Info)gv_Consulta.GetFocusedRow();
                if (Accion != Cl_Enumeradores.eTipo_action.grabar && row == null)
                {
                    MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                FrmCom_ConvenioPreciosMantenimiento frm = new FrmCom_ConvenioPreciosMantenimiento();
                frm.event_delegate_FrmCom_ConvenioPreciosMantenimiento_FormClosing+=frm_event_delegate_FrmCom_ConvenioPreciosMantenimiento_FormClosing;
                frm.SetAccion(Accion, row ?? new com_ConvenioPreciosPorProducto_Info());
                frm.MdiParent = this.MdiParent;
                frm.Show();
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
                gc_Consulta.DataSource = bus_convenio.GetList(param.IdEmpresa);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void frm_event_delegate_FrmCom_ConvenioPreciosMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmCom_ConvenioPreciosConsulta_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gc_Consulta.ShowPrintPreview();
        }
    }
}
