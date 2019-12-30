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
    public partial class FrmIn_TransferenciaConGuiaAprobacion : Form
    {
        #region Variables
        in_transferencia_bus busTransferencia;
        in_Transferencia_det_Bus busDet;
        cl_parametrosGenerales_Bus param;
        tb_Sucursal_Bus busSucursal;
        BindingList<in_transferencia_det_Info> blstDet;
        in_UnidadMedida_Bus busUnidadMedida;
        #endregion

        public FrmIn_TransferenciaConGuiaAprobacion()
        {
            InitializeComponent();
            busTransferencia = new in_transferencia_bus();
            busDet = new in_Transferencia_det_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            busSucursal = new tb_Sucursal_Bus();
            blstDet = new BindingList<in_transferencia_det_Info>();
            busUnidadMedida = new in_UnidadMedida_Bus();
        }

        private void gvDetalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                in_transferencia_det_Info row = (in_transferencia_det_Info)gvDetalle.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (colChecked == e.Column)
                {
                    if (row.check)
                    {
                        row.cantidad_enviar = row.dt_cantidad;
                    }else
                        row.cantidad_enviar = 0;
                    row.Saldo = row.dt_cantidad - row.cantidad_enviar;
                }

                if (colCantidadIngresada == e.Column)
                {
                    if (row.cantidad_enviar > 0)
                        row.check = true;
                    else
                        row.check = false;
                    row.Saldo = row.dt_cantidad - row.cantidad_enviar;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FrmIn_TransferenciaConGuiaAprobacion_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            try
            {
                cmbSucursalDestino.Properties.DataSource = busSucursal.Get_List_Sucursal(param.IdEmpresa);
                cmbSucursalDestino.EditValue = param.IdSucursal;
                cmbUnidadMedida.DataSource = busUnidadMedida.Get_list_UnidadMedida();
                blstDet = new BindingList<in_transferencia_det_Info>(busDet.GetLisParaAprobacion(param.IdEmpresa,param.IdSucursal));
                gcDetalle.DataSource = blstDet;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            if (Aprobar())
            {
                this.Close();
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobar_Click(object sender, EventArgs e)
        {
            if (Aprobar())
            {
                CargarDetalle();
            }
        }

        private void CargarDetalle()
        {
            try
            {
                int IdSucursal = cmbSucursalDestino.EditValue == null ? 0 : Convert.ToInt32(cmbSucursalDestino.EditValue);
                blstDet = new BindingList<in_transferencia_det_Info>(busDet.GetLisParaAprobacion(param.IdEmpresa, IdSucursal));
                gcDetalle.DataSource = blstDet;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void cmbSucursalDestino_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDetalle();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private bool Validar()
        {
            try
            {
                if (blstDet.Where(q=> q.check == true).Count() == 0)
                {
                    MessageBox.Show("Seleccione registros para aceptar la transferecia",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }
                if (blstDet.Where(q=> q.check == true).GroupBy(q=> new {q.IdEmpresa, q.IdSucursalOrigen, q.IdBodegaOrigen, q.IdTransferencia}).Count() > 1)
                {
                    MessageBox.Show("Debe aceptar una transferencia a la vez",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private bool Aprobar()
        {
            try
            {
                gvDetalle.MoveNext();
                cmbSucursalDestino.Focus();
                if (!Validar())
                    return false;
                var temp = blstDet.Where(q => q.check == true).GroupBy(q => new { q.IdEmpresa, q.IdSucursalOrigen, q.IdBodegaOrigen, q.IdTransferencia }).FirstOrDefault();
                in_transferencia_Info info = new in_transferencia_Info
                {
                    IdEmpresa = temp.Key.IdEmpresa,
                    IdSucursalOrigen = temp.Key.IdSucursalOrigen,
                    IdBodegaOrigen = temp.Key.IdBodegaOrigen,
                    IdTransferencia = temp.Key.IdTransferencia,
                    IdUsuario = param.IdUsuario
                };
                info = busTransferencia.Get_Info_transferencia(param.IdEmpresa, info.IdSucursalOrigen, info.IdBodegaOrigen, info.IdTransferencia);
                info.IdUsuario = param.IdUsuario;
                info.lista_detalle_transferencia = blstDet.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursalOrigen == info.IdSucursalOrigen && q.IdBodegaOrigen == info.IdBodegaOrigen && q.IdTransferencia == info.IdTransferencia).ToList();
                if (busTransferencia.Aprobar(info))
                {
                    MessageBox.Show("Transferencia aprobada exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return true;
                }else
                    MessageBox.Show("Ha ocurrido un error", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
