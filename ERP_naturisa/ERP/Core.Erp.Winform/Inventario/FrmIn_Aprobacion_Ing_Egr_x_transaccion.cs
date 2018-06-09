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
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Aprobacion_Ing_Egr_x_transaccion : Form
    {
        #region
        BindingList<in_Ing_Egr_Inven_Info> blist_ing_egr = new BindingList<in_Ing_Egr_Inven_Info>();
        in_Ing_Egr_Inven_Bus bus_ingr_egr = new in_Ing_Egr_Inven_Bus();
        in_Ing_Egr_Inven_det_Bus bus_ingr_egr_det = new in_Ing_Egr_Inven_det_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<in_Ing_Egr_Inven_Info> list_validar = new List<in_Ing_Egr_Inven_Info>();
        List<in_Ing_Egr_Inven_det_Info> list_aprobar = new List<in_Ing_Egr_Inven_det_Info>();
        in_Ing_Egr_Inven_Info Info_validar = new in_Ing_Egr_Inven_Info();
        vwin_Ingr_Egr_Inven_det_Bus bus_IngEgrDet = new vwin_Ingr_Egr_Inven_det_Bus();

        int IdSucursal = 0;
        int IdBodega = 0;
        string Signo = "";
        int IdTipoMovi = 0;
        string tipo = "";
        #endregion

        public FrmIn_Aprobacion_Ing_Egr_x_transaccion()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (Aprobar())
                    {
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (Aprobar())
                    {
                        this.Close();
                    }                    
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        private bool Validar()
        {
            try
            {
                opt_egreso.Focus();

                if (blist_ing_egr.Where(q=>q.Checked==true).Count()==0)
                {
                    MessageBox.Show("Debe seleccionar una transacción para aprobar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool Aprobar()
        {
            try
            {
                Get_trans_checked();

                var itemTipMov = cmbTipoMovInv.get_TipoMoviInvInfo();

                if (itemTipMov != null)
                {
                    tipo = itemTipMov.cm_tipo_movi;
                }
                string mensaje = "";
                if (bus_IngEgrDet.Modificar_Estado_IngEgr_Det(list_aprobar, tipo, ref mensaje))
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error al Actualizar Estados, " + mensaje, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void Limpiar()
        {
            try
            {
                blist_ing_egr = new BindingList<in_Ing_Egr_Inven_Info>();
                cmb_Sucursal_Bodega.InicializarSucursal();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar()
        {
            try
            {
                Get_signo();
                IdSucursal = cmb_Sucursal_Bodega.get_sucursal() == null ? 0 : cmb_Sucursal_Bodega.get_sucursal().IdSucursal;
                IdBodega = cmb_Sucursal_Bodega.get_bodega() == null ? 0 : cmb_Sucursal_Bodega.get_bodega().IdBodega;
                IdTipoMovi = cmbTipoMovInv.get_TipoMoviInvInfo() == null ? 0 : cmbTipoMovInv.get_TipoMoviInvInfo().IdMovi_inven_tipo;

                blist_ing_egr = new BindingList<in_Ing_Egr_Inven_Info>(bus_ingr_egr.Get_List_Ing_Egr_Inven(param.IdEmpresa,IdSucursal,IdBodega,IdTipoMovi,Signo).Where(q=>q.Estado=="A").ToList());
                gridControlAprobación.DataSource = blist_ing_egr;
              
                if (blist_ing_egr.Count==0)
                {
                    MessageBox.Show("No existen movimientos pendientes por aprobar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void opt_ingreso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Get_signo();
                cmbTipoMovInv.Inicializar_Catalogos();
                cmbTipoMovInv.cargar_TipoMotivo(IdSucursal, IdBodega, Signo, "");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void opt_egreso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Get_signo();
                cmbTipoMovInv.Inicializar_Catalogos();
                cmbTipoMovInv.cargar_TipoMotivo(IdSucursal, IdBodega, Signo, "");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Sucursal_Bodega_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbTipoMovInv.Inicializar_Catalogos();
                cmbTipoMovInv.cargar_TipoMotivo(IdSucursal, IdBodega, Signo, "");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_signo()
        {
            try
            {
                if (opt_egreso.Checked)
                    Signo = "-";
                else
                    if (opt_ingreso.Checked)
                        Signo = "+";
                    else
                        Signo = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_trans_checked()
        {
            try
            {
                cmbTipoMovInv.Focus();
                list_aprobar = new List<in_Ing_Egr_Inven_det_Info>();
                list_validar = new List<in_Ing_Egr_Inven_Info>(blist_ing_egr.Where(q => q.Checked == true).ToList());
                //validación para el caso de que dos personas aprueben el mismo desde dos máquinas distintas.
                Buscar();
                foreach (var item in list_validar)
                {
                    Info_validar = blist_ing_egr.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi);

                    if (Info_validar != null)
                    {
                        blist_ing_egr.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi).Checked = true;
                        blist_ing_egr.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi).IdEstadoAproba = "APRO";
                    }
                }
                gridControlAprobación.DataSource = blist_ing_egr;

                foreach (var cabecera in blist_ing_egr)
                {
                    if (cabecera.Checked == true)
                    {
                        List<in_Ing_Egr_Inven_det_Info> lista = new List<in_Ing_Egr_Inven_det_Info>();
                        lista = bus_ingr_egr_det.Get_List_Ing_Egr_Inven_det_x_Num_Movimiento(cabecera.IdEmpresa,cabecera.IdSucursal,cabecera.IdMovi_inven_tipo, cabecera.IdNumMovi);

                        foreach (var item in lista)
                        {
                            in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdNumMovi = item.IdNumMovi;
                            info.Secuencia = item.Secuencia;
                            info.IdBodega = item.IdBodega;
                            info.IdProducto = item.IdProducto;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.dm_cantidad = item.dm_cantidad;
                            info.dm_stock_ante = item.dm_stock_ante;
                            info.dm_stock_actu = item.dm_stock_actu;
                            info.dm_observacion = item.dm_observacion;
                            info.dm_precio = item.dm_precio;
                            info.mv_costo = item.mv_costo;
                            info.dm_peso = item.dm_peso;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            info.IdPunto_cargo = item.IdPunto_cargo;
                            info.IdUnidadMedida = item.IdUnidadMedida;
                            info.IdEstadoAproba = Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString();
                            info.Motivo_Aprobacion = "APROBADO POR SISTEMAS";
                            info.IdMotivo_Inv = item.IdMotivo_Inv;

                            info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                            info.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                            info.Checked = true;
                            info.do_subtotal = item.mv_costo * item.dm_cantidad;

                            list_aprobar.Add(info);
                        }
                    }                
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAprobacion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                in_Ing_Egr_Inven_Info row = new in_Ing_Egr_Inven_Info();
                row = (in_Ing_Egr_Inven_Info)gridViewAprobacion.GetRow(e.RowHandle);
                if (row!=null)
                {
                    if (e.Column == colCheck)
                    {
                        if (row.Checked)
                        {
                            gridViewAprobacion.SetRowCellValue(e.RowHandle, colEstado, "APRO");
                        }
                        else
                            gridViewAprobacion.SetRowCellValue(e.RowHandle, colEstado, "PEND");
                    }    
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_Aprobacion_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                gridViewAprobacion.SetRowCellValue(gridViewAprobacion.FocusedRowHandle, colCheck, e.NewValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
