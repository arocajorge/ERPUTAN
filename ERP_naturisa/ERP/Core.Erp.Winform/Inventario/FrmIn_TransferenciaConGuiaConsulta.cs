﻿using System;
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
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_TransferenciaConGuiaConsulta : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus busLogError;
        cl_parametrosGenerales_Bus param;
        in_transferencia_bus busTransferencia;
        #endregion

        public FrmIn_TransferenciaConGuiaConsulta()
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


                ultrTransFerencia.DataSource = busTransferencia.ObtenerTransferencias(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta
                    , idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin);

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

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.grabar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.actualizar);
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

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.Anular);
        }

        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            in_transferencia_Info row = (in_transferencia_Info)gridViewTransferencias.GetFocusedRow();

            if (Accion != Cl_Enumeradores.eTipo_action.grabar && row == null)
            {
                MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            if (row != null && (Accion != Cl_Enumeradores.eTipo_action.consultar && Accion != Cl_Enumeradores.eTipo_action.grabar) && row.Estado == "I")
            {
                MessageBox.Show("El registro se encuentra anulado",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            if (row != null && (Accion != Cl_Enumeradores.eTipo_action.consultar || Accion != Cl_Enumeradores.eTipo_action.grabar) && row.Estado == "A" && (row.IdEstadoAproba_egr == "APRO" || row.IdEstadoAproba_ing == "APRO"))
            {
                MessageBox.Show("No se puede modificar transferencias con movimientos aprobados", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FrmIn_TransferenciaConGuiaMantenimiento frm = new FrmIn_TransferenciaConGuiaMantenimiento();
            frm.SetAccion(Accion, row ?? new in_transferencia_Info());
            frm.MdiParent = this.MdiParent;
            frm.event_delegate_FrmIn_TransferenciaConGuiaMantenimiento_FormClosed += frm_event_delegate_FrmIn_TransferenciaConGuiaMantenimiento_FormClosed;
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
                    if (row.IdEstadoAproba_egr == "APRO" || row.IdEstadoAproba_ing == "APRO")
                    {
                        e.Appearance.ForeColor = Color.Blue;
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
