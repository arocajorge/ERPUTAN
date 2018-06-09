using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Aprobacion_Ing_Egr : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        in_movi_inven_tipo_Bus tipoMoviBus = new in_movi_inven_tipo_Bus();
        vwin_Ingr_Egr_Inven_det_Bus bus_IngEgrDet = new vwin_Ingr_Egr_Inven_det_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<in_movi_inven_tipo_Info> _listMovi_inve_tipo_info = new List<in_movi_inven_tipo_Info>();
        in_Ing_Egr_Inven_estado_apro_Bus busEstado = new in_Ing_Egr_Inven_estado_apro_Bus();
        List<in_Ing_Egr_Inven_estado_apro_Info> lstEstadoApro = new List<in_Ing_Egr_Inven_estado_apro_Info>();
        List<vwin_Ing_Egr_Inven_det_Info> list_validar = new List<vwin_Ing_Egr_Inven_det_Info>();
        vwin_Ing_Egr_Inven_det_Info Info_validar = new vwin_Ing_Egr_Inven_det_Info();
        List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        BindingList<vwin_Ing_Egr_Inven_det_Info> ListaBind;
        string tipo = "";
        vwin_Ing_Egr_Inven_det_Info Info;
        #endregion
        
        public FrmIn_Aprobacion_Ing_Egr()
        {
            InitializeComponent();

      
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAprobar_Click += ucGe_Menu_Superior_Mant1_event_btnAprobar_Click;
            ucGe_Menu_Superior_Mant1.event_btnAprobarGuardarSalir_Click += ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click;
            
        }

        void ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Actualizar_Estados())
                { Close(); } 
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Actualizar_Estados())
                {
                    Limpiar();
                }  
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        public Boolean Actualizar_Estados()
        {
            try
            {
                ucIn_Sucursal_Bodega1.Focus();
                list_validar = new List<vwin_Ing_Egr_Inven_det_Info>(ListaBind.Where(q => q.Checked == true).ToList());
                Buscar();
                foreach (var item in list_validar)
                {
                    Info_validar = ListaBind.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi && q.secuencia == item.secuencia);

                    if (Info_validar != null)
                    {
                        ListaBind.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi && q.secuencia == item.secuencia).Checked = true;
                        ListaBind.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi && q.secuencia == item.secuencia).IdEstadoAproba = "APRO";
                    }
                }
                gridControlCons.DataSource = ListaBind;

                List<in_Ing_Egr_Inven_det_Info> lista = new List<in_Ing_Egr_Inven_det_Info>();
                foreach (var item in ListaBind.Where(q=>q.Checked == true).ToList())
                {
                    in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info
                    {
                         IdEmpresa = item.IdEmpresa,
                         IdSucursal = item.IdSucursal,
                         IdMovi_inven_tipo = item.IdMovi_inven_tipo,
                         IdNumMovi = item.IdNumMovi,
                         Secuencia = item.secuencia,

                         IdBodega = item.IdBodega,
                         IdProducto = item.IdProducto,                        
                         dm_cantidad = item.dm_cantidad,
                         dm_stock_ante = item.dm_stock_ante,
                         dm_stock_actu = item.dm_stock_actu,
                         dm_observacion = item.dm_observacion,
                         dm_precio = item.dm_precio,
                         mv_costo = item.mv_costo,
                         dm_peso = item.dm_peso,
                         IdCentroCosto = item.IdCentroCosto,
                         IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo,
                         IdPunto_cargo = item.IdPunto_cargo,
                         IdUnidadMedida = item.IdUnidadMedida,
                         IdEstadoAproba = item.IdEstadoAproba,
                         Motivo_Aprobacion = item.Motivo_Aprobacion,
                         IdMotivo_Inv = item.IdMotivo_Inv,

                         IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion,
                         dm_cantidad_sinConversion = item.dm_cantidad_sinConversion,
                         mv_costo_sinConversion = item.mv_costo_sinConversion,
                    };
                        lista.Add(info);
                }
               
                var itemTipMov = cmbTipoMovInv.get_TipoMoviInvInfo();

                if (itemTipMov != null)
                {
                    tipo = itemTipMov.cm_tipo_movi;
                }
                string mensaje = "";
                if (bus_IngEgrDet.Modificar_Estado_IngEgr_Det(lista, tipo, ref mensaje))
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error al Actualizar Estados, " + mensaje, param.Nombre_sistema);
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

        public void Limpiar()
        {
            try
            {
                ListaBind = new BindingList<vwin_Ing_Egr_Inven_det_Info>();
                gridControlCons.DataSource = ListaBind;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void carga_combo()
        {
            try
            {
                lstEstadoApro = busEstado.Get_List_Ing_Egr_Inven_estado_apro();
                cmbEstadoAproba.DataSource = lstEstadoApro;

                lst_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_punto_cargo.DataSource = lst_punto_cargo;
                
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarTipoMovimiento()
        {
            try
            {                
                if (opt_ingreso.Checked)
                    opt_ingreso_CheckedChanged(null, null);

                if (opt_egreso.Checked)
                    opt_egreso_CheckedChanged(null, null);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Buscar()
        {
            try
            {
                List<vwin_Ing_Egr_Inven_det_Info> list_IngEgrDet = new List<vwin_Ing_Egr_Inven_det_Info>();
                if (cmbTipoMovInv.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Seleccione el Tipo de Movimiento", "Sistemas");
                    return;
                }
                DateTime Fecha_ini = DateTime.Now.Date;
                DateTime Fecha_fin = DateTime.Now.Date;

                Fecha_ini = Convert.ToDateTime(de_Fecha_ini.EditValue);
                Fecha_fin = Convert.ToDateTime(de_Fecha_fin.EditValue);

                list_IngEgrDet = bus_IngEgrDet.Get_List_in_Ing_Egr_Inven_det(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue), Convert.ToInt32(cmbTipoMovInv.get_TipoMoviInvInfo().IdMovi_inven_tipo), Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString(),Fecha_ini, Fecha_fin);
                if (list_IngEgrDet.Count() == 0)
                {
                    MessageBox.Show("No existe información para la Sucursal : " + ucIn_Sucursal_Bodega1.cmb_sucursal.Text + " , Bodega: " + ucIn_Sucursal_Bodega1.cmb_bodega.Text + " y Tipo de Movimiento: " + cmbTipoMovInv.Text + " ", "Sistemas");
                    return;
                }

                ListaBind = new BindingList<vwin_Ing_Egr_Inven_det_Info>(list_IngEgrDet.Where(q => q.Estado == "A").ToList());
                gridControlCons.DataSource = ListaBind;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_tipoMovi_Inven(int IdSucursal , int IdBodega, string tipo, string interno)
        {
            try
            {
                cmbTipoMovInv.cargar_TipoMotivo(IdSucursal, IdBodega, tipo, interno);
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
                if (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue != null && ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue != null)
                    cargar_tipoMovi_Inven(Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue), "+", "");
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
                if (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue != null && ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue != null)
                    cargar_tipoMovi_Inven(Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue), "-", "");
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Aprobacion_Ing_Egr_Load(object sender, EventArgs e)
        {
            try
            {
                ListaBind = new BindingList<vwin_Ing_Egr_Inven_det_Info>();
                gridControlCons.DataSource = ListaBind;

                de_Fecha_ini.EditValue = DateTime.Now.Date.AddMonths(-1);
                de_Fecha_fin.EditValue = DateTime.Now.Date.AddMonths(1);

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        colPunto_cargo.Visible = true;
                        break;
                    default:
                        colPunto_cargo.Visible = false;
                        break;
                }

                carga_combo();
                opt_ingreso.Checked = true;
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

        private void gridViewCons_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.HitInfo.Column != null)
                {
                    e.HitInfo.Column.FieldName = gridViewCons.FocusedColumn.FieldName;
                    if (e.HitInfo.Column.FieldName == "Checked")
                    {
                        if ((Boolean)gridViewCons.GetFocusedRowCellValue(colChecked))
                        {
                            gridViewCons.SetFocusedRowCellValue(colChecked, false);

                            if ((Boolean)gridViewCons.GetFocusedRowCellValue(colChecked) == false)
                            {
                                gridViewCons.SetFocusedRowCellValue(colIdEstadoAproba, gridViewCons.GetFocusedRowCellValue(colIdEstadoAproba_AUX));
                                gridViewCons.SetFocusedRowCellValue(colmv_costo, gridViewCons.GetFocusedRowCellValue(colmv_costo_AUX));
                                gridViewCons.SetFocusedRowCellValue(colsubtotal, gridViewCons.GetFocusedRowCellValue(colsubtotal_AUX));
                                return;
                            }
                        }
                        else
                        {
                            gridViewCons.SetFocusedRowCellValue(colChecked, true);
                            gridViewCons.SetFocusedRowCellValue(colIdEstadoAproba, Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString());
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
     
        private void gridViewCons_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Info = (vwin_Ing_Egr_Inven_det_Info)this.gridViewCons.GetFocusedRow();
            
                if (e.Column.Name == "colmv_costo")
                {
                    foreach (var item in ListaBind)
                    {                       
                        if(item.IdNumMovi==Info.IdNumMovi && item.secuencia==Info.secuencia && item.IdProducto==Info.IdProducto)
                        {
                            if (item.mv_costo <= 0)
                            {
                                item.mv_costo = item.mv_costo_AUX;
                                item.IdEstadoAproba = item.IdEstadoAproba_AUX;
                                item.Checked = false;
                                item.subtotal = item.mv_costo_AUX * item.dm_cantidad;
                            }
                            else
                            {
                                if (item.mv_costo != item.mv_costo_AUX)
                               {
                                   item.IdEstadoAproba = Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString();
                                   item.Checked = true;
                                   item.subtotal = item.mv_costo * item.dm_cantidad;
                               }
                            }                                               
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

        private void ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarTipoMovimiento();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_Seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewCons.RowCount; i++)
                {
                    gridViewCons.SetRowCellValue(i, colChecked, chk_Seleccionar_visibles.Checked);
                    gridViewCons.SetRowCellValue(i, colIdEstadoAproba, chk_Seleccionar_visibles.Checked == true ? "APRO" : "PEND");
                }
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
                foreach (var item in ListaBind.Where(q=>q.IdEstadoAproba == "APRO"))
                {
                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(item.cm_fecha)))
                        return false;
                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(item.cm_fecha)))
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
       
       
    }
}
