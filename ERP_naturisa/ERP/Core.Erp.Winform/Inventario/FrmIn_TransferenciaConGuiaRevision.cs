using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_TransferenciaConGuiaRevision : Form
    {
       
        #region Variables
        tb_sis_Log_Error_Vzen_Bus busLogError;
        cl_parametrosGenerales_Bus param;
        in_transferencia_bus busTransferencia;
        #endregion

        public FrmIn_TransferenciaConGuiaRevision()
        {
            InitializeComponent();
            busLogError = new tb_sis_Log_Error_Vzen_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            busTransferencia = new in_transferencia_bus();
        }

        private void FrmIn_TransferenciaConGuiaConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarGrid()
        {
            try
            {
                int idSucursalIni = 0;
                int idSucursalFin = 0;
                int idBodegaFin = 0;
                int idBodegaIni = 0;

                idSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal == 0 ? 1 : ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                idSucursalFin = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;

                idBodegaIni = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega == 0 ? 1 : ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                idBodegaFin = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;


                ultrTransFerencia.DataSource = busTransferencia.Get_List_transferenciaParaRevision(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta,"P");

            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.consultar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            in_transferencia_Info row = (in_transferencia_Info)gridViewTransferencias.GetFocusedRow();

            if (Accion != Cl_Enumeradores.eTipo_action.grabar)
            {
                if (row == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Accion != Cl_Enumeradores.eTipo_action.consultar && row.Estado == "I")
                {
                    MessageBox.Show("El registro se encuentra anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Accion != Cl_Enumeradores.eTipo_action.consultar && row.EstadoRevision != "P")
                {
                    MessageBox.Show("El registro se encuentra procesado y no puede ser modificado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            FrmIn_TransferenciaConGuiaRevisionM frm = new FrmIn_TransferenciaConGuiaRevisionM();
            frm.SetAccion(Accion, row ?? new in_transferencia_Info());
            frm.MdiParent = this.MdiParent;
            frm.event_delegate_FrmIn_TransferenciaConGuiaRevisionM_FormClosed += frm_event_delegate_FrmIn_TransferenciaConGuiaMantenimiento_FormClosed;
            frm.Show();
        }

        void frm_event_delegate_FrmIn_TransferenciaConGuiaMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarGrid();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ultrTransFerencia.ShowPrintPreview();
        }

        private void gridViewTransferencias_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                in_transferencia_Info row = (in_transferencia_Info)gridViewTransferencias.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (row.Estado == "I")
                {
                    e.Appearance.ForeColor = Color.Red;
                    return;
                }
                else
                    if (row.Estado == "A" || row.EstadoRevision == "R")
                    {
                        e.Appearance.ForeColor = Color.Blue;
                        return;
                    }
                    else
                        if (row.Estado == "A" || row.EstadoRevision == "E")
                        {
                            e.Appearance.ForeColor = Color.OrangeRed;
                            return;
                        }
                        else
                            if (row.Estado == "A" || row.EstadoRevision == "A")
                            {
                                e.Appearance.ForeColor = Color.Green;
                                return;
                            }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
