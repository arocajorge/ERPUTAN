using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxPagar;
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

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_XML_Consulta : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_RutaPorEmpresaPorUsuario_Bus bus_ruta;
        BindingList<cp_XML_Documento_Info> blst;
        cp_XML_Documento_Bus bus_xml;
        
        #endregion

        public frmCP_XML_Consulta()
        {
            InitializeComponent();
            bus_ruta = new cp_RutaPorEmpresaPorUsuario_Bus();
            blst = new BindingList<cp_XML_Documento_Info>();
            bus_xml = new cp_XML_Documento_Bus();
        }

        private void frmCP_XML_Consulta_Load(object sender, EventArgs e)
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
                gcDetalle.DataSource = bus_xml.GetList(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta);
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

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCP_DigitalizacionXML frm = new frmCP_DigitalizacionXML();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcDetalle.ShowPrintPreview();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.Anular);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.consultar);
        }

        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                cp_XML_Documento_Info row = (cp_XML_Documento_Info)gvDetalle.GetFocusedRow();
                if (row == null)
                {
                    MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                frmCP_XML_Mantenimiento frm = new frmCP_XML_Mantenimiento();
                frm.SetInfo(row, Accion);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LlamarFormulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
