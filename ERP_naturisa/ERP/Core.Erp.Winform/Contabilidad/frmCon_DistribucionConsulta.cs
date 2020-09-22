using Core.Erp.Business.Contabilidad;
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
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_DistribucionConsulta : Form
    {
        #region Variable
        ct_Distribucion_Bus busDistribucion;
        cl_parametrosGenerales_Bus param;
        #endregion
        public frmCon_DistribucionConsulta()
        {
            InitializeComponent();
            busDistribucion = new ct_Distribucion_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
        }

        private void frmCon_DistribucionConsulta_Load(object sender, EventArgs e)
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
                gcDetalle.DataSource = busDistribucion.GetList(param.IdEmpresa,ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta);
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

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                ct_Distribucion_Info row = (ct_Distribucion_Info)gvDetalle.GetFocusedRow();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (row == null)
                    {
                        MessageBox.Show("Seleccione un registro",param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (!row.Estado && (Accion == Cl_Enumeradores.eTipo_action.actualizar || Accion == Cl_Enumeradores.eTipo_action.Anular))
                    {
                        MessageBox.Show("El registro se encuentra anulado",param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                frmCon_DistribucionMantenimiento frm = new frmCon_DistribucionMantenimiento();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
