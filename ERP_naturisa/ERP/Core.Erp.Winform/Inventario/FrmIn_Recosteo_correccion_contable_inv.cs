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
using Core.Erp.Info.General;

using System.Threading;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Recosteo_correccion_contable_inv : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        BindingList<in_transferencia_Info> blst_transferencia = new BindingList<in_transferencia_Info>();
        in_transferencia_bus bus_transferencia = new in_transferencia_bus();
        string mens = string.Empty;
        List<tb_Bodega_Info> lst_bodega = new List<tb_Bodega_Info>();
        tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();
        in_producto_x_tb_bodega_Costo_Historico_Bus bus_costo_historico = new in_producto_x_tb_bodega_Costo_Historico_Bus();
        BindingList<in_producto_x_tb_bodega_Costo_Historico_Info> blst_costo_historico = new BindingList<in_producto_x_tb_bodega_Costo_Historico_Info>();
        in_Ing_Egr_Inven_Bus bus_inger = new in_Ing_Egr_Inven_Bus();
        in_movi_inve_Info info_movi_inven = new in_movi_inve_Info();
        BindingList<in_movi_inve_Info> lst_movi_inven = new BindingList<in_movi_inve_Info>();
        in_movi_inve_Bus bus_movi_inven = new in_movi_inve_Bus();
        tb_Bodega_Bus busBodega = new tb_Bodega_Bus();
        
        List<in_movi_inven_tipo_Info> ListaTipoMovi = new List<in_movi_inven_tipo_Info>();
        in_movi_inven_tipo_Bus busTipoMovi = new in_movi_inven_tipo_Bus();

        tb_Sucursal_Bus busSucursal = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> ListaSucursal = new List<tb_Sucursal_Info>();

        bool recosteo = false;
        bool correccion_transferencias = false;
        bool recosteo_x_producto = false;
        List<in_Producto_Info> lst_producto = new List<in_Producto_Info>();
        in_producto_Bus bus_producto = new in_producto_Bus();
        int RowHandle_cont = 0;
        BindingList<in_Ing_Egr_Inven_Info> blstDiferencias = new BindingList<in_Ing_Egr_Inven_Info>();
        BindingList<in_producto_x_tb_bodega_Costo_Historico_Info> blsDetHistorico = new BindingList<in_producto_x_tb_bodega_Costo_Historico_Info>();
        #endregion

        public FrmIn_Recosteo_correccion_contable_inv()
        {
            InitializeComponent();
        }

        private void FrmIn_Recosteo_correccion_contable_inv_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_combos();
                cmb_estado_contabilizacion.SelectedItem = "NO CONTABILIZADO";
                ucIn_Sucursal_Bodega1.Visible_cmb_bodega = true;
                blsDetHistorico = new BindingList<in_producto_x_tb_bodega_Costo_Historico_Info>();
                gcHistorico.DataSource = blsDetHistorico;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, "+ ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_combos()
        {
            try
            {
                ucIn_Sucursal_Bodega_multiple1.Cargar_combos();
                de_Fecha_ini_recosteo.EditValue = DateTime.Now.Date;
                de_fecha_transferencias.EditValue = DateTime.Now.Date;
                de_fecha_ini_cont.EditValue = DateTime.Now.Date.AddMonths(-1);
                de_fecha_fin_cont.EditValue = DateTime.Now.Date;
                de_fecha_x_prod.EditValue = DateTime.Now;
                lst_producto = bus_producto.Get_list_Producto(param.IdEmpresa);
                cmb_producto.Properties.DataSource = lst_producto;
                deFechaIniD.DateTime = DateTime.Now.Date.AddMonths(-1);
                deFechaFinD.DateTime = DateTime.Now.Date;

                ListaSucursal = busSucursal.Get_List_Sucursal(param.IdEmpresa);
                ListaTipoMovi = busTipoMovi.GetList(param.IdEmpresa);
                cmbTipoMovimientoCambioFecha.Properties.DataSource = ListaTipoMovi;
                cmbSucursalCambioFecha.Properties.DataSource = ListaSucursal;
                cmbSucursalOrigen.Properties.DataSource = ListaSucursal;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_recostear_Click(object sender, EventArgs e)
        {
            try
            {
                Recostear();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_corregir_transferencias_Click(object sender, EventArgs e)
        {
            try
            {
                CorregirTrans();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_transferencias_Click(object sender, EventArgs e)
        {
            try
            {                
                toolStripCabecera.Focus();
                blst_transferencia = new BindingList<in_transferencia_Info>(bus_transferencia.Get_List_transferencias_para_recosteo(param.IdEmpresa,Convert.ToDateTime(de_fecha_transferencias.EditValue)));
                gridControlTransferencias.DataSource = blst_transferencia;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucIn_Sucursal_Bodega_multiple1_event_delegate_cmb_sucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_sucursal = ucIn_Sucursal_Bodega_multiple1.Get_info_sucursal();
                if (info_sucursal == null) return;

                DateTime Fecha_recomendada_costeo = bus_movi_inven.Get_fecha_costeo_recomendada(param.IdEmpresa, ucIn_Sucursal_Bodega_multiple1.Get_info_sucursal().IdSucursal);
                
                if (Fecha_recomendada_costeo == DateTime.Now.Date) return;

                if (MessageBox.Show("Se recomienda hacer un recosteo para la sucursal " + info_sucursal.Su_Descripcion2 + " desde " + Fecha_recomendada_costeo.ToShortDateString() + " \n¿Desea utilizar la fecha recomendada?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    de_Fecha_ini_recosteo.EditValue = Fecha_recomendada_costeo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Recostear()
        {
            try
            {
                recosteo = true;
                recosteo_x_producto = false;
                correccion_transferencias = false;
                if (!Validar()) return;

                toolStripCabecera.Focus();

                List<in_producto_x_tb_bodega_Costo_Historico_Info> lista_resultado = new List<in_producto_x_tb_bodega_Costo_Historico_Info>();
                blst_costo_historico = new BindingList<in_producto_x_tb_bodega_Costo_Historico_Info>();

                int IdSucursal = ucIn_Sucursal_Bodega_multiple1.Get_info_sucursal() == null ? 0 : ucIn_Sucursal_Bodega_multiple1.Get_info_sucursal().IdSucursal;
                lst_bodega = ucIn_Sucursal_Bodega_multiple1.Get_list_bodegas();
                DateTime Fecha_ini = de_Fecha_ini_recosteo.EditValue == null ? DateTime.Now : Convert.ToDateTime(de_Fecha_ini_recosteo.EditValue);
                ProgressBar_recosteo.EditValue = 0;
                ProgressBar_recosteo.Properties.Minimum = 1;
                ProgressBar_recosteo.Properties.Maximum = lst_bodega.Count;
                ProgressBar_recosteo.Properties.Step = 1;
                ProgressBar_recosteo.Properties.PercentView = true;
                splashScreenManager1.ShowWaitForm();
                foreach (var item in lst_bodega)
                {
                    lista_resultado = bus_costo_historico.Proceso_recosteo_y_correccion_contable_inv(param.IdEmpresa, IdSucursal, item.IdBodega, Fecha_ini, 5);
                    item.Chek = true;
                    foreach (var item_res in lista_resultado)
                        blst_costo_historico.Add(item_res);
                    gridControlRecosteo.DataSource = blst_costo_historico;
                    gridControlRecosteo.RefreshDataSource();
                    gridControlRecosteo.Refresh();
                    ProgressBar_recosteo.PerformStep();
                    ProgressBar_recosteo.Update();
                    Application.DoEvents();
                }
                splashScreenManager1.CloseWaitForm();
                gridControlRecosteo.DataSource = blst_costo_historico.OrderBy(q => q.IdSucursal).ThenBy(q => q.IdBodega).ThenBy(q => q.IdProducto).ThenBy(q => q.IdFecha).ThenBy(q => q.Secuencia).ToList();

                if (lst_bodega.Count == lst_bodega.Where(q => q.Chek == true).ToList().Count)
                    MessageBox.Show("Recosteo exitoso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("Fallo al momento de realizar el recosteo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CorregirTrans()
        {
            try
            {
                recosteo = false;
                recosteo_x_producto = false;
                correccion_transferencias = true;
                if (!Validar()) return;

                toolStripCabecera.Focus();
                ProgressBar_transferencias.EditValue = 0;
                ProgressBar_transferencias.Properties.Minimum = 1;
                ProgressBar_transferencias.Properties.Maximum = blst_transferencia.Count;
                ProgressBar_transferencias.Properties.Step = 1;
                ProgressBar_transferencias.Properties.PercentView = true;

                if (blst_transferencia.Count == 0)
                {
                    MessageBox.Show("No existen transferencias desde esa fecha", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DateTime Fecha_ini = DateTime.Now;
                in_transferencia_Info info_transferencia = new in_transferencia_Info();
                foreach (var item in blst_transferencia)
                {
                    info_transferencia = blst_transferencia.OrderBy(q => q.IdEmpresa).ThenBy(q => q.IdSucursalOrigen).ThenBy(q => q.IdBodegaOrigen).ThenByDescending(q => q.tr_fecha).ToList().FirstOrDefault(q => q.IdSucursalOrigen == item.IdSucursalOrigen && q.IdBodegaOrigen == item.IdBodegaOrigen && q.Check == true && q.tr_fecha < item.tr_fecha);
                    Fecha_ini = info_transferencia == null ? Convert.ToDateTime(de_fecha_transferencias.EditValue) : info_transferencia.tr_fecha.Date;

                    if (bus_costo_historico.Proceso_recosteo_y_correccion_contable_inv(param.IdEmpresa, item.IdSucursalOrigen, item.IdBodegaOrigen, Fecha_ini, item.tr_fecha, 5))
                        item.Check = true;
                    gridControlTransferencias.RefreshDataSource();
                    gridControlTransferencias.Refresh();
                    ProgressBar_transferencias.PerformStep();
                    ProgressBar_transferencias.Update();
                    Application.DoEvents();
                }

                if (blst_transferencia.Count == blst_transferencia.Where(q => q.Check == true).ToList().Count)
                    MessageBox.Show("Corrección de transferencias completas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("No se puedieron corregir todas las transferencias", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            try
            {
                if (recosteo)
                {
                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(de_Fecha_ini_recosteo.EditValue)))
                        return false;
                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(de_Fecha_ini_recosteo.EditValue)))
                        return false;
                }
                if (correccion_transferencias)
                {
                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(de_fecha_transferencias.EditValue)))
                        return false;
                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(de_fecha_transferencias.EditValue)))
                        return false;
                }

                if (recosteo_x_producto)
                {
                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(de_fecha_x_prod.EditValue)))
                        return false;
                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(de_fecha_x_prod.EditValue)))
                        return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void rdb_egresos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdb_egresos.Checked)
                {
                    rdb_ingresos.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdb_ingresos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdb_ingresos.Checked)
                {
                    rdb_egresos.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        private void btn_buscar_movimientos_btn_buscar_movimientos_para_cont_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar_movimientos_para_contabilizar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar_movimientos_para_contabilizar()
        {
            try
            {
                cmb_estado_contabilizacion.Focus();
                string signo = rdb_egresos.Checked == true ? "-" : "+";
                lst_movi_inven = new BindingList<in_movi_inve_Info>(bus_movi_inven.Get_list_Movi_inven_para_contabilizar(param.IdEmpresa, signo, Convert.ToDateTime(de_fecha_ini_cont.EditValue).Date, Convert.ToDateTime(de_fecha_fin_cont.EditValue), cmb_estado_contabilizacion.SelectedItem.ToString()));

                gridControlContabilizacion.DataSource = lst_movi_inven;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewContabilizacion.RowCount; i++)
                {
                    gridViewContabilizacion.SetRowCellValue(i, col_check_cont, chk_seleccionar_visibles.Checked);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_contabilizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Contabilizar())
                {
                    MessageBox.Show("Se han contabilizado los movimientos exitósamente.");
                    Buscar_movimientos_para_contabilizar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Contabilizar()
        {
            try
            {
                cmb_estado_contabilizacion.Focus();

                if (cmb_estado_contabilizacion.SelectedItem.ToString() == "CONTABILIZADO")
                {
                    MessageBox.Show("Los movimientos seleccionados, ya se encuentran contabilizados", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                string mensaje_cbte = "";
                string mensaje_error = "";
                foreach (var item in lst_movi_inven.Where(q => q.Checked == true).ToList())
                {            
                    if (!bus_movi_inven.ContabilizacionData(item.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdMovi_inven_tipo, item.IdNumMovi, param.IdUsuario, ref mensaje_error))
                    {
                        MessageBox.Show("Sucursal: " + item.nom_sucursal.Trim() + "\nBodega: " + item.nom_bodega.Trim() + "\nTipo movimiento: " + item.tipo_movi_inven + "\n# Movi: " + item.IdNumMovi.ToString() + "\n" + mensaje_error, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Buscar_movimientos_para_contabilizar();
                        return false;
                    }
                }                

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }        
        private void gridViewContabilizacion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle_cont = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_recostear_x_producto_Click(object sender, EventArgs e)
        {
            try
            {
                recosteo = false;
                correccion_transferencias = false;
                recosteo_x_producto = true;
                if (!Validar()) return;

                toolStrip4.Focus();

                int IdSucursal = ucIn_Sucursal_Bodega1.get_IdSucursal();
                int IdBodega = ucIn_Sucursal_Bodega1.get_IdBodega();
                if (cmb_producto.EditValue == null)
                {
                    return;
                }
                decimal IdProducto = Convert.ToDecimal(cmb_producto.EditValue);
                lst_bodega = ucIn_Sucursal_Bodega_multiple1.Get_list_bodegas();
                DateTime Fecha_ini = de_fecha_x_prod.EditValue == null ? DateTime.Now : Convert.ToDateTime(de_fecha_x_prod.EditValue);
                splashScreenManager1.ShowWaitForm();
                bus_costo_historico.Proceso_recosteo_y_correccion_contable_inv(param.IdEmpresa, IdSucursal, IdBodega, IdProducto, Fecha_ini, 5);
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Recosteo exitoso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarDiferencias_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarDiferencias();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BuscarDiferencias()
        {
            blstDiferencias = new BindingList<in_Ing_Egr_Inven_Info>(bus_inger.GetListDiferenciasContable(param.IdEmpresa, deFechaIniD.DateTime.Date, deFechaFinD.DateTime.Date));
            gcDiferencias.DataSource = null;
            gcDiferencias.DataSource = blstDiferencias;
        }

        private void btnReversarContabilizacion_Click(object sender, EventArgs e)
        {
            try
            {
                gvDiferencias.MoveNext();
                deFechaIniD.Focus();
                bool TodoOK = true;
                foreach (var item in blstDiferencias.Where(q=> q.Checked == true).ToList())
                {
                    if (!bus_inger.ReversarContabilizacion(item.IdEmpresa, item.IdSucursal, item.IdMovi_inven_tipo, item.IdNumMovi))
                    {
                        MessageBox.Show("No se ha podido reversar la transacción:\nSucursal: "+item.nom_sucursal.Trim()+"\nTipo movimiento: "+item.tm_descripcion+"\nNúmero movimiento: "+item.IdNumMovi.ToString(),param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                        TodoOK = false;
                        break;
                    }
                }
                if (TodoOK)
                {
                    MessageBox.Show("Transacciones reversadas exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                 BuscarDiferencias();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void chkSeleccionarVisiblesReversos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gvDiferencias.RowCount; i++)
                {
                    gvDiferencias.SetRowCellValue(i, col_check_cont, chkSeleccionarVisiblesReversos.Checked);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Comuníquese con sistemas, " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarCambioFecha_Click(object sender, EventArgs e)
        {
            try
            {
                deFechaActualCambioFecha.DateTime = DateTime.Now.Date;
                txtObservacionCambioFecha.Text = string.Empty;

                if (cmbSucursalCambioFecha.EditValue == null)
                {
                    MessageBox.Show("Seleccione la sucursal",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                if (cmbTipoMovimientoCambioFecha.EditValue == null)
                {
                    MessageBox.Show("Seleccione el tipo de movimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtNumMovimiento.Text))
                {
                    MessageBox.Show("Ingrese el numero de movimiento",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                var info =  bus_inger.Get_Info_Ing_Egr_Inven(param.IdEmpresa, Convert.ToInt32(cmbSucursalCambioFecha.EditValue), Convert.ToInt32(cmbTipoMovimientoCambioFecha.EditValue), Convert.ToDecimal(txtNumMovimiento.Text));
                if (info == null || info.IdEmpresa == 0)
                {
                    MessageBox.Show("El movimiento ingresado no existe",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                deFechaActualCambioFecha.DateTime = info.cm_fecha.Date;
                txtObservacionCambioFecha.Text = info.cm_observacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error \n"+ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCambiarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSucursalCambioFecha.EditValue == null)
                {
                    MessageBox.Show("Seleccione la sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (cmbTipoMovimientoCambioFecha.EditValue == null)
                {
                    MessageBox.Show("Seleccione el tipo de movimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(txtNumMovimiento.Text))
                {
                    MessageBox.Show("Ingrese el numero de movimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var info = bus_inger.Get_Info_Ing_Egr_Inven(param.IdEmpresa, Convert.ToInt32(cmbSucursalCambioFecha.EditValue), Convert.ToInt32(cmbTipoMovimientoCambioFecha.EditValue), Convert.ToDecimal(txtNumMovimiento.Text));
                if (info == null)
                {
                    MessageBox.Show("El movimiento ingresado no existe", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (deFechaNuevaCambio.EditValue == null)
                {
                    MessageBox.Show("Ingrese la nueva fecha", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (bus_inger.CambiarFecha(param.IdEmpresa,Convert.ToInt32(cmbSucursalCambioFecha.EditValue), Convert.ToInt32(cmbTipoMovimientoCambioFecha.EditValue), Convert.ToDecimal(txtNumMovimiento.Text),deFechaNuevaCambio.DateTime.Date,param.IdUsuario))
                {
                    MessageBox.Show("Cambio de fecha exitoso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    btnBuscarCambioFecha_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error \n"+ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void btnBuscarTransFecha_Click(object sender, EventArgs e)
        {
            if (cmbSucursalOrigen.EditValue == null)
            {
                MessageBox.Show("Seleccione la sucursal origen", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cmbBodegaOrigen.EditValue == null)
            {
                MessageBox.Show("Seleccione la bodega origen", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtIdTransferencia.Text))
            {
                MessageBox.Show("Ingrese el número de la transferencia", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var Transferencia = bus_transferencia.GetInfoCambioFecha(param.IdEmpresa, Convert.ToInt32(cmbSucursalOrigen.EditValue), Convert.ToInt32(cmbBodegaOrigen.EditValue), Convert.ToDecimal(txtIdTransferencia.Text));
            if (Transferencia == null)
            {
                txtObservacion.Text = string.Empty;
                deFechaTrans.EditValue = null;
                deFechaIngresoTrans.EditValue = null;
                deFechaEgresoTrans.EditValue = null;
                MessageBox.Show("La transferencia no existe", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                txtObservacion.Text = Transferencia.tr_Observacion;
                deFechaTrans.EditValue = Transferencia.tr_fecha;
                deFechaIngresoTrans.EditValue = Transferencia.FechaIngreso;
                deFechaEgresoTrans.EditValue = Transferencia.FechaEgreso;
            }
        }

        private void btnTransCambiarFecha_Click(object sender, EventArgs e)
        {
            if (cmbSucursalOrigen.EditValue == null)
            {
                MessageBox.Show("Seleccione la sucursal origen", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cmbBodegaOrigen.EditValue == null)
            {
                MessageBox.Show("Seleccione la bodega origen", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtIdTransferencia.Text))
            {
                MessageBox.Show("Ingrese el número de la transferencia", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var Transferencia = bus_transferencia.GetInfoCambioFecha(param.IdEmpresa, Convert.ToInt32(cmbSucursalOrigen.EditValue), Convert.ToInt32(cmbBodegaOrigen.EditValue), Convert.ToDecimal(txtIdTransferencia.Text));
            if (Transferencia == null)
            {
                txtObservacion.Text = string.Empty;
                deFechaTrans.EditValue = null;
                deFechaIngresoTrans.EditValue = null;
                deFechaEgresoTrans.EditValue = null;
                MessageBox.Show("La transferencia no existe", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (bus_transferencia.ModificarFecha(param.IdEmpresa, Transferencia.IdSucursalOrigen, Transferencia.IdBodegaOrigen, Transferencia.IdTransferencia, deFechaTrans.DateTime))
                {
                    if (Transferencia.IdNumMovi_Ing_Egr_Inven_Origen != null)
                    {
                        if (bus_inger.CambiarFecha(param.IdEmpresa, Transferencia.IdSucursal_Ing_Egr_Inven_Origen ?? 0, Transferencia.IdMovi_inven_tipo_SucuOrig ?? 0, Transferencia.IdNumMovi_Ing_Egr_Inven_Origen ?? 0, deFechaEgresoTrans.DateTime, param.IdUsuario))
                        {
                        }
                    }
                    if (Transferencia.IdNumMovi_Ing_Egr_Inven_Destino != null)
                    {
                        if (bus_inger.CambiarFecha(param.IdEmpresa, Transferencia.IdSucursal_Ing_Egr_Inven_Destino ?? 0, Transferencia.IdMovi_inven_tipo_SucuDest ?? 0, Transferencia.IdNumMovi_Ing_Egr_Inven_Destino ?? 0, deFechaIngresoTrans.DateTime, param.IdUsuario))
                        {
                            
                        }    
                    }
                    MessageBox.Show("Cambio de fecha exitoso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void cmbSucursalOrigen_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbSucursalOrigen.EditValue != null)
            {
                cmbBodegaOrigen.Properties.DataSource = busBodega.Get_List_Bodega(param.IdEmpresa, Convert.ToInt32(cmbSucursalOrigen.EditValue));   
            }
            cmbBodegaOrigen.EditValue = null;
        }

        private void btnEliminarTransferencia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar la transferencia?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            
            if (cmbSucursalOrigen.EditValue == null)
            {
                MessageBox.Show("Seleccione la sucursal origen", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cmbBodegaOrigen.EditValue == null)
            {
                MessageBox.Show("Seleccione la bodega origen", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtIdTransferencia.Text))
            {
                MessageBox.Show("Ingrese el número de la transferencia", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (bus_transferencia.Eliminar(param.IdEmpresa,Convert.ToInt32(cmbSucursalOrigen.EditValue), Convert.ToInt32(cmbBodegaOrigen.EditValue),Convert.ToDecimal(txtIdTransferencia.Text)))
            {
                MessageBox.Show("Transferencia eliminada exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }else
                MessageBox.Show("No se pudo eliminar la transferencia", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gvHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gvHistorico.DeleteSelectedRows();
                }
            }
        }

        private void gvHistorico_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            in_producto_x_tb_bodega_Costo_Historico_Info row = (in_producto_x_tb_bodega_Costo_Historico_Info)gvHistorico.GetRow(e.RowHandle);
            if (row == null)
                return;

            if (e.Column == colCostoPromedio)
            {
                if (row.Secuencia == 0)
                {
                    string mens = string.Empty;
                    if (row.fecha != DateTime.MinValue && row.costo > 0)
                    {
                        row.IdEmpresa = param.IdEmpresa;
                        row.IdSucursal = ucIn_Sucursal_Bodega1.get_IdSucursal();
                        row.IdBodega = ucIn_Sucursal_Bodega1.get_IdBodega();
                        row.IdProducto = Convert.ToDecimal(cmb_producto.EditValue);
                        row.IdFecha = Convert.ToInt32(row.fecha.ToString("yyyyMMdd"));
                        row.fecha = row.fecha;
                        row.Stock_a_la_fecha = 0;
                        row.Observacion = param.IdUsuario + " " + DateTime.Now.ToString("dd/MM/yyyy");

                        bus_costo_historico.GuardarDB(row, ref mens);
                    }
                }
                else
                {
                    bus_costo_historico.ModificarDB(row);
                }
                gcHistorico.RefreshDataSource();    
            }            
        }

        private void btnBuscarHistorico_Click(object sender, EventArgs e)
        {
            if (ucIn_Sucursal_Bodega1.get_IdSucursal() == 0)
            {
                MessageBox.Show("Seleccione la sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ucIn_Sucursal_Bodega1.get_IdBodega() == 0)
            {
                MessageBox.Show("Seleccione la bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cmb_producto.EditValue == null)
            {
                MessageBox.Show("Seleccione el producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            blsDetHistorico = new BindingList<in_producto_x_tb_bodega_Costo_Historico_Info>(bus_costo_historico.GetList(param.IdEmpresa, ucIn_Sucursal_Bodega1.get_IdSucursal(), ucIn_Sucursal_Bodega1.get_IdBodega(), Convert.ToDecimal(cmb_producto.EditValue)));
            gcHistorico.DataSource = blsDetHistorico;
        }
    }
}
