using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using System.Xml;
using Core.Erp.Winform.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Cus.Erp.Reports.Cidersus.Produccion;
namespace Core.Erp.Winform.Compras
{
    public partial class FrmPrd_CotizacionCompra_Mantenimiento : Form
    {
        #region Variables
         com_cotizacion_compra_Info Info = new com_cotizacion_compra_Info();
        com_cotizacion_compra_Bus Bus = new com_cotizacion_compra_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        com_cotizacion_compra_Info infoCotiza = new com_cotizacion_compra_Info();
        com_cotizacion_compra_Bus Bus_Tip_movi = new com_cotizacion_compra_Bus();
        Cl_Enumeradores.eTipo_action Accion;
        com_cotizacion_compra_det_Bus Busllenagrid = new com_cotizacion_compra_det_Bus();
        List<cp_proveedor_Info> ListaProveedores = new List<cp_proveedor_Info>();
        cp_proveedor_Bus BusProveedor = new cp_proveedor_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_categorias_bus busCateg = new in_categorias_bus();
        public delegate void delegate_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing;
        List<tb_Sucursal_Info> ListadoSucursal = new List<tb_Sucursal_Info>();
        string msg = "";
        BindingList<com_cotizacion_compra_det_Info> ListaBind;
        List<com_cotizacion_compra_det_Info> Listdet;
        List<com_cotizacion_compra_det_Info> lista;
        #endregion

        public void set_InfoCotiza(com_cotizacion_compra_Info _SetInfo)
        {
            try
            {             
                txtnumcotizaion.Text = Convert.ToString(_SetInfo.IdCotizacion);
                txtobservacion.Text = _SetInfo.Observacion;
                ucGe_Sucursal_combo1.set_SucursalInfo(_SetInfo.IdSucursal);
                ucCp_Proveedor1.set_ProveedorInfo(_SetInfo.IdProveedor);

                gridControlcotizamant.DataSource = Busllenagrid.Get_list_Cotizacion_detalle(param.IdEmpresa, _SetInfo.IdCotizacion, _SetInfo.IdSucursal);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        public void get_Cotiza()
        {
            try
            {
                infoCotiza = new com_cotizacion_compra_Info();
                infoCotiza.IdEmpresa = param.IdEmpresa;
                infoCotiza.IdCotizacion = txtnumcotizaion.Text == "" ? 0 : Convert.ToDecimal(txtnumcotizaion.Text);
                infoCotiza.Observacion = txtobservacion.Text.ToString();
                infoCotiza.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                infoCotiza.estado = "A";
                infoCotiza.IdProveedor = Convert.ToInt32(ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);
                GetDetalle();
                infoCotiza.Detalle = Listdet;
                infoCotiza.Fecha_Transac = dtpFechareg.Value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        public void anular()
        {
             get_Cotiza();
             if (infoCotiza.estado =="I")
                           {
                            if (MessageBox.Show("¿Esta seguro que desea anular la cotizacion #: " + txtnumcotizaion.Text + " ?", "Anulación de cotizacion de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                                fr.ShowDialog();
                                infoCotiza.motiAnulacion = fr.motivoAnulacion;

                                //Info.motiAnulacion = motiAnulacion;
                                infoCotiza.idUsuario = param.IdUsuario;
                                infoCotiza.Fecha_Transac = param.Fecha_Transac;
                                if (Bus_Tip_movi.AnularDB(infoCotiza))
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Anulación de cotizacion de compra", txtnumcotizaion.Text);
                                    MessageBox.Show(smensaje, param.Nombre_sistema);
                                    //MessageBox.Show("Tipo Movimiento de caja #: " + txt_idTipoMovi.Text + " Anulada correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   // lb_Anulado.Visible = true;
                                }
                                else
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    //MessageBox.Show("No se puedo Anular el Tipo Movimiento de caja #: " + txt_idTipoMovi.Text, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                    
                            }
                          }
                        else
                            MessageBox.Show("cotizacion ya estas anulada", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               
        public void GetDetalle()
        {
            try
            {
                int focus = this.gridViewcotizamant.FocusedRowHandle;
                gridViewcotizamant.FocusedRowHandle = focus + 1;

                Listdet = new List<com_cotizacion_compra_det_Info>();
          
                foreach (var item in ListaBind)
                {
                    com_cotizacion_compra_det_Info info = new com_cotizacion_compra_det_Info();

     
                          if (item.Check == true)
                           {


                               info.IdEmpresa = infoCotiza.IdEmpresa;
                               info.IdCotizacion =Convert.ToDecimal( txtnumcotizaion.Text);
                               info.IdProducto = item.IdProducto;
                               info.Cant_a_cotizar = item.Cant_a_cotizar;
                               info.Cant_soli = item.Cant_soli_AUX;
                               info.IdEmpresa_lq = item.IdEmpresa_lq;
                               info.IdListadoMateriales_lq = item.IdListadoMateriales_lq;
                               info.IdDetalle_lq = item.IdDetalle_lq;

                              Listdet.Add(info);
                            }
                        }                                                                                                                                    
                //    }
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private Boolean Validar()
        {
            try
            {               

                if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                {
                    MessageBox.Show("Seleccione el Proveedor", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucCp_Proveedor1.Focus();
                    return false;
                }

                if (txtobservacion.Text == string.Empty)
                {
                    MessageBox.Show("Asigne una observación", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtobservacion.Focus();
                    return false;
                }
                if (cmbcategoria.EditValue == null)
                {
                    MessageBox.Show("Seleccione la Categoria", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbcategoria.Focus();
                    return false;
                }

              

                else if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                } return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); return false;
            }

        }

        public void set_Acccion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        txtnumcotizaion.BackColor = System.Drawing.Color.White;
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        txtnumcotizaion.ReadOnly = true;
                        txtnumcotizaion.BackColor = System.Drawing.Color.White;

                        //ucGe_Sucursal_combo1.Properties.ReadOnly = true;
                        ucGe_Sucursal_combo1.BackColor = System.Drawing.Color.White;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        txtnumcotizaion.ReadOnly = true;
                        txtnumcotizaion.BackColor = System.Drawing.Color.White;

                        //cmbSucursal.Properties.ReadOnly = true;
                        ucGe_Sucursal_combo1.BackColor = System.Drawing.Color.White;

                        txtobservacion.ReadOnly = true;
                        txtobservacion.BackColor = System.Drawing.Color.White;

                        this.colCant_a_cotizar.OptionsColumn.AllowEdit = false;
                        
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                      
                        txtnumcotizaion.ReadOnly = true;
                        txtnumcotizaion.BackColor = System.Drawing.Color.White;

                        //cmbSucursal.Properties.ReadOnly = true;
                        ucGe_Sucursal_combo1.BackColor = System.Drawing.Color.White;

                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }

        private Boolean Grabar()
        {
            try
            {
                if (Validar() == false)
                {
                    MessageBox.Show("No se Guardó", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    get_Cotiza();
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                                                                                
                            if (Bus_Tip_movi.GuardarDB(infoCotiza, ref msg))
                            {
                                this.txtnumcotizaion.Text = Convert.ToString(infoCotiza.IdCotizacion);
                                MessageBox.Show("Se ha grabado correctamente la Cotización #: " + infoCotiza.IdCotizacion);
                                ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                                return true;
                            }
                            else return false;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                           
                            if (Bus_Tip_movi.ModificarDB(infoCotiza, ref msg))
                            {
                                MessageBox.Show("Se ha actualizado correctamente la Cotización #: " + infoCotiza.IdCotizacion);
                                ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                                return true;
                            }
                            else return false;
                       
                        default:
                            return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); return false;
            }
        }
         
        public FrmPrd_CotizacionCompra_Mantenimiento()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
              
            event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing+=FrmPrd_CotizacionCompra_Mantenimiento_event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing;
        }

        void frm_event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        void FrmPrd_CotizacionCompra_Mantenimiento_event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                { this.Close(); }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XPRO_CUS_CID_Rpt003 XReport = new XPRO_CUS_CID_Rpt003();
                List<XPRO_CUS_CID_Rpt003_Info> data = new List<XPRO_CUS_CID_Rpt003_Info>();
                XPRO_CUS_CID_Rpt003_Bus busSpRpt = new XPRO_CUS_CID_Rpt003_Bus();

                data = busSpRpt.Get_cotizacion(param.IdEmpresa, Convert.ToInt32(txtnumcotizaion.Text), param.IdSucursal);
                XReport.loadData(data.ToList());
                XReport.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void FrmPrd_CotizacionCompra_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {           
            event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing(sender, e);
        }

        private void FrmPrd_CotizacionCompra_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                         
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                      
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }

        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lista = new List<com_cotizacion_compra_det_Info>();
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {

                    //lista = Busllenagrid.Get_list_Cotizacion_detalle(param.IdEmpresa, _SetInfo.IdCotizacion, ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal);


                }
                                                             
                 ListaBind = new BindingList<com_cotizacion_compra_det_Info>(lista);
                 gridControlcotizamant.DataSource = ListaBind;
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewcotizamant_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                          
                com_cotizacion_compra_det_Info row1 = new com_cotizacion_compra_det_Info();
                row1 = (com_cotizacion_compra_det_Info)gridViewcotizamant.GetRow(e.RowHandle);

                e.HitInfo.Column.FieldName = gridViewcotizamant.FocusedColumn.FieldName;

                    if (e.HitInfo.Column.FieldName == "Check")
                    {
                        if ((bool)gridViewcotizamant.GetFocusedRowCellValue(col_Check))
                        {
                            gridViewcotizamant.SetFocusedRowCellValue(col_Check, false);                         
                            gridViewcotizamant.SetFocusedRowCellValue(colCant_a_cotizar, 0);                         
                        }

                        else
                        {
                            gridViewcotizamant.SetFocusedRowCellValue(col_Check, true);                        
                            gridViewcotizamant.SetFocusedRowCellValue(colsaldo, 0); 
                        }                    
                    }
            }
            catch (Exception ex)
            {  
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void FrmPrd_CotizacionCompra_Mantenimiento_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing(sender,e);

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        com_cotizacion_compra_det_Info Info1;
           
        private void cmbcategoria_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lista = new List<com_cotizacion_compra_det_Info>();
                if (cmbcategoria.EditValue.ToString() == "001")
                {
                    lista = Busllenagrid.Get_list_Cotizacion_detalle(param.IdEmpresa, ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal);
                }
                else
                {
                    lista = Busllenagrid.Get_list_Cotizacion_detalle(param.IdEmpresa, ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal, Convert.ToString(cmbcategoria.EditValue));
                }
                if (lista.Count() == 0)
                {
                    MessageBox.Show("No existen registros a cotizar para la categoría : " + cmbcategoria.Text);
                    gridControlcotizamant.RefreshDataSource();
                    return;
                }
                else 
                {
                    ListaBind = new BindingList<com_cotizacion_compra_det_Info>(lista);
                    gridControlcotizamant.DataSource = ListaBind;
                
                }
                                            
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void  getId(decimal IdCotizacion)
           {
               try
               {
                   txtnumcotizaion.Text = Convert.ToString(IdCotizacion);

               }
               catch (Exception ex)
               {
                   Log_Error_bus.Log_Error(ex.ToString());
                 
               }
           }
       private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
       {
           try
           {

               anular();
           }
           catch (Exception ex)
           {

               Log_Error_bus.Log_Error(ex.ToString());
           }
       }

       public void CargarCombos()
       {
           try
           {
             
             cmbcategoria.Properties.DataSource = busCateg.Get_List_categorias(param.IdEmpresa);
             cmbcategoria.Properties.DisplayMember = "ca_Categoria";
             cmbcategoria.Properties.ValueMember = "IdCategoria";
             
           }
           catch (Exception ex)
           {

               Log_Error_bus.Log_Error(ex.ToString());
           }
       }

       private void gridViewcotizamant_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
       {
           try
           {
               com_cotizacion_compra_det_Info info = new com_cotizacion_compra_det_Info();
               Info1 = (com_cotizacion_compra_det_Info)this.gridViewcotizamant.GetFocusedRow();
               info = ListaBind.FirstOrDefault(q => q.IdProducto == Info1.IdProducto && q.IdListadoMateriales_lq == Info1.IdListadoMateriales_lq && q.IdDetalle_lq == Info1.IdDetalle_lq && q.IdSucursal == Info1.IdSucursal);

               if (e.Column.Name == "colCant_a_cotizar")
               {
                   double Cant_a_cotizar = Convert.ToDouble(gridViewcotizamant.GetFocusedRowCellValue(colCant_a_cotizar));
                   double saldo = Convert.ToDouble(gridViewcotizamant.GetFocusedRowCellValue(colsaldo));

                   foreach (var item in ListaBind)
                   {
                       if (item.IdProducto == info.IdProducto && item.IdListadoMateriales_lq == info.IdListadoMateriales_lq && item.IdDetalle_lq == info.IdDetalle_lq && item.IdSucursal == info.IdSucursal)
                       {
                           if (Cant_a_cotizar < 0 || Cant_a_cotizar > saldo || saldo == 0 || Cant_a_cotizar == 0)
                           {
                               item.Cant_a_cotizar = item.Cant_a_cotizar_AUX;
                               item.saldo = item.saldo_AUX;
                               item.Check = false;
                               return;

                           }

                           if (Cant_a_cotizar <= saldo)
                           {
                               item.saldo = item.saldo_AUX - item.Cant_a_cotizar;
                               item.Check = true;
                               return;
                           }
                       }
                   }
               }
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
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

               MessageBox.Show(ex.Message);
           }
       }

    }
}
