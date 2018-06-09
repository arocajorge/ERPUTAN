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
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_motivo_venta_Consulta : Form
    {
        #region "Variables"

        //variable para almacenar en la tabla log de errores
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //variable para obtener la información del usuario que se instancia al momento de correr la aplicación
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //variable que representa el formulario
        frmFa_motivo_venta_Mant frm;
        //variable que representa a una clase info
        fa_motivo_venta_Info MotivoVenta_Info = new fa_motivo_venta_Info();

        #endregion

        public frmFa_motivo_venta_Consulta()
        {
            InitializeComponent();
        }
        
        #region "Cargar Datos"

        public void LLenar_Grid()
        {
            try
            {
                List<fa_motivo_venta_Info> Lista_Motivo_Venta = new List<fa_motivo_venta_Info>();
                fa_motivo_venta_Bus MotivoVenta_Bus = new fa_motivo_venta_Bus();
                Lista_Motivo_Venta = MotivoVenta_Bus.Get_List_fa_motivo_venta(param.IdEmpresa);
                gridControl_MotivoVenta.DataSource = Lista_Motivo_Venta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Preparar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmFa_motivo_venta_Mant();
                frm.MdiParent = this.MdiParent;
                frm.event_frmFa_motivo_venta_Mant_FormClosing += frm_event_frmFa_motivo_venta_Mant_FormClosing;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                    frm.Set_Motivo_Venta(MotivoVenta_Info);

                frm.Set_Accion(Accion);
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmFa_motivo_venta_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                LLenar_Grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void ucGe_Menu_Mantenimiento_MotivoVenta_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_MotivoVenta_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridControl_MotivoVenta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFa_motivo_venta_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                LLenar_Grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFa_motivo_venta_Consulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                LLenar_Grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_MotivoVenta_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_MotivoVenta_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //asigna un valor a una variable para realizar la busqueda
                MotivoVenta_Info = (fa_motivo_venta_Info)this.gridViewMotivoVenta.GetFocusedRow();
                //Pregunta si esta seleccionado un registro
                if (MotivoVenta_Info == null)
                    MessageBox.Show("Por Favor seleccione un registro.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_MotivoVenta_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //asigna un valor a una variable para realizar la busqueda
                MotivoVenta_Info = (fa_motivo_venta_Info)this.gridViewMotivoVenta.GetFocusedRow();
                //Pregunta si esta seleccionado un registro
                if (MotivoVenta_Info == null)
                    MessageBox.Show("Por Favor seleccione un registro.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    if (MotivoVenta_Info.Estado != "I")
                        Preparar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
                    else
                        MessageBox.Show("El registro seleccionado ya se encuentra anulado.\n\n Por favor seleccione otro registro.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_MotivoVenta_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //asigna un valor a una variable para realizar la busqueda
                MotivoVenta_Info = (fa_motivo_venta_Info)this.gridViewMotivoVenta.GetFocusedRow();
                //Pregunta si esta seleccionado un registro
                if (MotivoVenta_Info == null)
                    MessageBox.Show("Por Favor seleccione un registro.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewMotivoVenta_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewMotivoVenta.GetRow(e.RowHandle) as fa_motivo_venta_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
