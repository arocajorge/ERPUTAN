using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Caja;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;


namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Parametro_x_OrdenPago : Form
    {       
        #region Declaracion de Variables
        #region business
            tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            cp_orden_pago_tipo_Bus BusordenTipo = new cp_orden_pago_tipo_Bus();
            cp_orden_pago_tipo_x_empresa_Bus BusordenTipoEmpresa = new cp_orden_pago_tipo_x_empresa_Bus();
            cp_trans_a_generar_x_FormaPago_OP_Bus BusTipoTransac = new cp_trans_a_generar_x_FormaPago_OP_Bus();
            cp_orden_pago_estado_aprob_Bus BusestadoApro = new cp_orden_pago_estado_aprob_Bus();
            cp_orden_pago_formapago_Bus BusformaPago = new cp_orden_pago_formapago_Bus();
            ct_Plancta_Bus planBus = new ct_Plancta_Bus();
            ct_Centro_costo_Bus centerCostoBus = new ct_Centro_costo_Bus();
            ct_Cbtecble_tipo_Bus BusCbtecble_tipo = new ct_Cbtecble_tipo_Bus();
            caj_Caja_Movimiento_Tipo_Bus cajaMoviBus = new caj_Caja_Movimiento_Tipo_Bus();
            tb_modulo_Bus moduloBus = new tb_modulo_Bus();
        #endregion
        #region Info
        cp_orden_pago_tipo_Info Info_Pago_Tipo = new cp_orden_pago_tipo_Info();
        cp_orden_pago_tipo_x_empresa_Info Info_x_Emp = new cp_orden_pago_tipo_x_empresa_Info();
        cp_orden_pago_estado_aprob_Info Info_Estado = new cp_orden_pago_estado_aprob_Info();
        cp_orden_pago_formapago_Info Info_FormaPago = new cp_orden_pago_formapago_Info();
        cp_trans_a_generar_x_FormaPago_OP_Info Info_TipoTransac = new cp_trans_a_generar_x_FormaPago_OP_Info();
        #endregion
        #region BindingList

            List<cp_orden_pago_tipo_Info> tempPagoTipo = new List<cp_orden_pago_tipo_Info>();
            List<cp_orden_pago_estado_aprob_Info> tempEstado = new List<cp_orden_pago_estado_aprob_Info>();
            List<cp_orden_pago_formapago_Info> tempForma = new List<cp_orden_pago_formapago_Info>();
            List<cp_trans_a_generar_x_FormaPago_OP_Info> tempTrans = new List<cp_trans_a_generar_x_FormaPago_OP_Info>();
            List<ct_Cbtecble_tipo_Info> List_Cbtecble_tipo = new List<ct_Cbtecble_tipo_Info>();


            //BindingList<cp_orden_pago_tipo_Info> BindingList_Pago_Tipo;
            BindingList<cp_orden_pago_tipo_x_empresa_Info> BindingList_x_orden_pago_tipo_x_empresa;
            BindingList<cp_orden_pago_estado_aprob_Info> BindingList_orden_pago_estado_aprob;
            BindingList<cp_orden_pago_formapago_Info> BindingList_orden_pago_formapago;
            BindingList<cp_trans_a_generar_x_FormaPago_OP_Info> BindingList_TipoTransac;
            

        #endregion
        #region Contadores
        int bandPago = 0;
        int bandEstado = 0;
        int bandtransac = 0;
        int bandForma = 0;
        #endregion
        string MensajeError = "";

        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        void generarBinding()
        {
            try
            {
                //BindingList_Pago_Tipo = new BindingList<cp_orden_pago_tipo_Info>(BusordenTipo.Get_List_orden_pago_tipo());
                BindingList_x_orden_pago_tipo_x_empresa = new BindingList<cp_orden_pago_tipo_x_empresa_Info>(BusordenTipoEmpresa.Get_List_orden_pago_tipo_x_empresa(param.IdEmpresa));
                BindingList_orden_pago_estado_aprob = new BindingList<cp_orden_pago_estado_aprob_Info>(BusestadoApro.Get_List_orden_pago_estado_aprob());
                BindingList_orden_pago_formapago = new BindingList<cp_orden_pago_formapago_Info>(BusformaPago.Get_List_orden_pago_formapago());
                BindingList_TipoTransac = new BindingList<cp_trans_a_generar_x_FormaPago_OP_Info>(BusTipoTransac.Get_List_trans_a_generar_x_FormaPago_OP());
                List_Cbtecble_tipo = BusCbtecble_tipo.Get_list_Cbtecble_tipo(param.IdEmpresa,ref MensajeError);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        public frmCP_Parametro_x_OrdenPago()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (validarOT_Empre())
                {
                    Grabar();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grabar()
        {
            try
            {
                string msgError = "";
                xtraTabControlOrden.Focus();

                foreach (var Info_Tipo_Pago_x_Emp in BindingList_x_orden_pago_tipo_x_empresa)
                {

                    cp_orden_pago_tipo_Info Info_Orden_Pago_tipo = new cp_orden_pago_tipo_Info();

                    Info_Orden_Pago_tipo.IdTipo_op = Info_Tipo_Pago_x_Emp.IdTipo_op;
                    Info_Orden_Pago_tipo.Descripcion = Info_Tipo_Pago_x_Emp.nom_Tipo_op;
                    Info_Orden_Pago_tipo.Estado = Info_Tipo_Pago_x_Emp.Estado;
                    Info_Orden_Pago_tipo.GeneraDiario = Info_Tipo_Pago_x_Emp.GeneraDiario;
                    Info_Orden_Pago_tipo.Dispara_Alerta = Info_Tipo_Pago_x_Emp.Dispara_Alerta;


                        if (BusordenTipo.ValidarCodigoExiste(Info_Orden_Pago_tipo.IdTipo_op ))
                        {
                            BusordenTipo.ModificarDB(Info_Orden_Pago_tipo);
                        }
                        else
                        {
                            BusordenTipo.GuardarDB(Info_Orden_Pago_tipo);
                        }


                        if (BusordenTipoEmpresa.ValidarCodigoExiste(Info_Tipo_Pago_x_Emp.IdTipo_op, Info_Tipo_Pago_x_Emp.IdEmpresa))
                        {
                            if (BusordenTipoEmpresa.ModificarDB(Info_Tipo_Pago_x_Emp, ref msgError))
                            {
                                //MessageBox.Show("Ha sido guardado el registro con éxito", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                        }
                        else
                        {
                            if (BusordenTipoEmpresa.GuardarDB(Info_Tipo_Pago_x_Emp, ref msgError))
                            {
                                //MessageBox.Show("Ha sido guardado el registro con éxito", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                        }

                }

                MessageBox.Show("Ha sido guardado el registro con éxito", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (xtraTabControlOrden.SelectedTabPage == xtraTabTipoTransacciones)
                    {
                        int focus = this.gridViewTransaccion.FocusedRowHandle;
                        gridViewTransaccion.FocusedRowHandle = focus + 1;

                        bandtransac = 0;
                        if (BusTipoTransac.ModificarDB(new List<cp_trans_a_generar_x_FormaPago_OP_Info>(BindingList_TipoTransac)))
                        {
                            MessageBox.Show("Se Ha guardado exitosamente el Tipo de Transacción de Orden de Pago", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridCmbTipoTransaccion.DataSource = BusTipoTransac.Get_List_trans_a_generar_x_FormaPago_OP();
                        }
                        gridControlTransaccion.DataSource = BindingList_TipoTransac = null;
                        gridControlTransaccion.DataSource = BindingList_TipoTransac = new BindingList<cp_trans_a_generar_x_FormaPago_OP_Info>(BusTipoTransac.Get_List_trans_a_generar_x_FormaPago_OP());
                    }

                    if (xtraTabControlOrden.SelectedTabPage == xtraTabEstado)
                    {
                        int focus = this.gridViewEstado.FocusedRowHandle;
                        gridViewEstado.FocusedRowHandle = focus + 1;

                        bandEstado = 0;
                        if (BusestadoApro.ModificarDB(new List<cp_orden_pago_estado_aprob_Info>(BindingList_orden_pago_estado_aprob)))
                        {
                            MessageBox.Show("Se ha guardado exitosamente los Estados de Orden de Pago", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        gridControlEstado.DataSource = BindingList_orden_pago_estado_aprob = null;
                        gridControlEstado.DataSource = BindingList_orden_pago_estado_aprob = new BindingList<cp_orden_pago_estado_aprob_Info>(BusestadoApro.Get_List_orden_pago_estado_aprob());
                    }
                    if (xtraTabControlOrden.SelectedTabPage == xtraTabForma)
                    {
                        int focus = this.gridViewForma.FocusedRowHandle;
                        gridViewForma.FocusedRowHandle = focus + 1;

                        bandForma = 0;
                        gridViewForma.FocusedRowHandle = -1;
                        BindingList<cp_orden_pago_formapago_Info> DataSources = new BindingList<cp_orden_pago_formapago_Info>(BindingList_orden_pago_formapago);
                        if (BusformaPago.ModificarDB(new List<cp_orden_pago_formapago_Info>(DataSources)))
                        {
                            MessageBox.Show("Se ha guardado exitosamente la Forma de Cancelación de Ordenes de Pago", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        gridControlForma.DataSource = BindingList_orden_pago_formapago = null;
                        gridControlForma.DataSource = BindingList_orden_pago_formapago = new BindingList<cp_orden_pago_formapago_Info>(BusformaPago.Get_List_orden_pago_formapago());
                    }


                    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                             
                if (validarOT_Empre())
                {
                    Grabar();
                }              
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void loadDataPanel()
        {
            try
            {
                cp_orden_pago_tipo_Bus bus_TipoPago = new cp_orden_pago_tipo_Bus();
                List<cp_orden_pago_tipo_Info> lista_pagoTipo = new List<cp_orden_pago_tipo_Info>();
                lista_pagoTipo = bus_TipoPago.Get_List_orden_pago_tipo_x_Empresa(param.IdEmpresa);

                List<ct_Plancta_Info> listPlanCta = new List<ct_Plancta_Info>();
                ct_Plancta_Bus BusPlanCta = new ct_Plancta_Bus();
                listPlanCta = BusPlanCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);


                cmbEstadoAproba.DataSource = BusestadoApro.Get_List_orden_pago_estado_aprob();
                generarBinding();


                gridControlTipoOrden_x_Empresa.DataSource = BindingList_x_orden_pago_tipo_x_empresa;



                gridControlForma.DataSource = BindingList_orden_pago_formapago;
                gridControlEstado.DataSource = BindingList_orden_pago_estado_aprob;
                gridControlTransaccion.DataSource = BindingList_TipoTransac;
                gridCmbCodModulo.DataSource = moduloBus.Get_list_Modulo();
                gridCmbTipoTransaccion.DataSource = BusTipoTransac.Get_List_trans_a_generar_x_FormaPago_OP();


                cmbIdTipoCaja.DataSource = cajaMoviBus.Get_list_Caja_Movimiento_Tipo( ref  MensajeError);
                cmb_ctacble_x_tipo_op.DataSource = listPlanCta;
                cmb_ctaCble_Acre.DataSource = listPlanCta;


                cmb_tipo_cbte_op.DataSource = List_Cbtecble_tipo;
                cmb_tipo_cbte_op_x_anu.DataSource = List_Cbtecble_tipo;
                
                

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void frmCP_Parametro_x_OrdenPago_Load(object sender, EventArgs e)
        {
            try
            {
                loadDataPanel();                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void limpiarCombo()
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
        
        void set_Info_x_Empresa()
        {
            try
            {
                //if (Info_x_Emp.IdCtaCble == null)
                //{
                //    //cmbCtaCtble.Text = "";
                //}
                //else { cmbCtaCtble.set_PlanCtarInfo(Info_x_Emp.IdCtaCble);  }
                //if (Info_x_Emp.IdTipoCbte_OP == null)
                //{
                //    cmbCbteCtble.Text = "";
                //}
                //else { cmbCbteCtble.set_TipoCbteCble(Convert.ToInt32(Info_x_Emp.IdTipoCbte_OP)); }
                //if (Info_x_Emp.IdCentroCosto == null)
                //{
                //    cmbCentroCosto.Text = "";
                //}
                //else { cmbCentroCosto.set_item(Info_x_Emp.IdCentroCosto); }
                //if (Info_x_Emp.IdTipoCbte_OP_anulacion == null )
                //{
                //    cmbCbteCbleAnulacion.Text = "";
                //}
                //else { cmbCbteCbleAnulacion.set_TipoCbteCble(Convert.ToInt32(Info_x_Emp.IdTipoCbte_OP_anulacion)); }
                //if (Info_x_Emp.IdEstadoAprobacion == null)
                //{
                //    cmbEstadoAproba.Text = "";
                //}
                ////else { cmbEstadoAproba.EditValue = Info_x_Emp.IdEstadoAprobacion; }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
       
        private bool validarOT_Empre()
        {
            try
            {                             
                //if(cmbEstadoAproba.EditValue == null )
                //{
                //    MessageBox.Show("Falta ingresar Estado de Aprobación", "Sistema");
                //    return false;
                //}

                //foreach (var item in BindingList_Pago_Tipo)
                //{
                //    if (item.Descripcion == null || item.Descripcion == "")
                //    {
                //            MessageBox.Show("Falta ingresar Descripción al Tipo Orden Pago: " + item.IdTipo_op + " , ó Libere el Focus de la celda", "Sistema");
                //            return false;
                //    }
                //}


                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
                            
        #region cp_transaccion
   
           
        
        private void gridViewTransaccion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                try
                {                                                         
                    // borrarChekgridTransaccion(); 
                    
                 //   gridViewTransaccion.SetFocusedRowCellValue(colcheckTransaccion, true);
                    //gridViewTransaccion.SetRowCellValue(e.FocusedRowHandle, colCheckForma, true);
                    cp_trans_a_generar_x_FormaPago_OP_Info data = (cp_trans_a_generar_x_FormaPago_OP_Info)gridViewTransaccion.GetRow(e.FocusedRowHandle);

                    if (e.FocusedRowHandle != BindingList_TipoTransac.Count - 1)
                    {
                        colIdTipoTransaccion1.OptionsColumn.AllowEdit = false;
                        var info = BindingList_TipoTransac.Last();

                        if ((info.IdTipoTransaccion == "" || info.Descripcion== "" || info.IdTipoTransaccion == null || info.Descripcion == null))
                        {
                            BindingList_TipoTransac.Remove(info); bandtransac = 0;
                        }
                        
                    }
                    else
                    {
                        if (BindingList_TipoTransac.Last().IdTipoTransaccion == "" || BindingList_TipoTransac.Last().IdTipoTransaccion == null)
                        {
                            colIdTipoTransaccion1.OptionsColumn.AllowEdit = true;
                            gridViewTransaccion.FocusedColumn = gridViewTipoOrden_x_Empresa.VisibleColumns[0];
                            gridViewTransaccion.ShowEditor();
                            gridViewTransaccion.GetShowEditorMode();

                        }
                    }

                    gridControlTransaccion.Update();

                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnNuevoTransaccion_Click(object sender, EventArgs e)
            {
                try
                {
                    if (BindingList_TipoTransac.Count > 0)
                    {
                        var temp = (cp_trans_a_generar_x_FormaPago_OP_Info)gridViewTransaccion.GetRow(gridViewTransaccion.RowCount - 1);
                        if (temp.IdTipoTransaccion != "" && temp.Descripcion != "" && temp.IdTipoTransaccion != null && temp.Descripcion != null)
                        {
                            Info_TipoTransac = new cp_trans_a_generar_x_FormaPago_OP_Info();
                            //Info_TipoTransac.IdTipoTransaccion = "";
                            Info_TipoTransac.Descripcion = "";
                            BindingList_TipoTransac.Add(Info_TipoTransac);
                            bandtransac = 1;
                            gridControlTransaccion.Refresh();
                        }
                    }
                    else
                    {
                        colIdTipoTransaccion.OptionsColumn.AllowEdit = true;
                        gridViewTransaccion.AddNewRow();
                        BindingList_TipoTransac = new BindingList<cp_trans_a_generar_x_FormaPago_OP_Info>();
                        bandtransac = 1;
                        Info_TipoTransac.IdTipoTransaccion = "";
                        Info_TipoTransac.Descripcion = "";
                        BindingList_TipoTransac.Add(Info_TipoTransac);
                        gridControlTransaccion.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString()); 
                    
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

        #endregion

        #region cp_orden_formapago

      
            private void btnNuevoForma_Click(object sender, EventArgs e)
            {
                try
                {
                    if (BindingList_orden_pago_formapago.Count > 0)
                    {
                        var temp = (cp_orden_pago_formapago_Info)gridViewForma.GetRow(gridViewForma.RowCount - 1);
                        if (temp.IdFormaPago != "" && temp.descripcion != "" && temp.IdFormaPago != null && temp.descripcion != null)
                        {
                            bandForma = 1;

                            Info_FormaPago = new cp_orden_pago_formapago_Info();
                            BindingList_orden_pago_formapago.Add(Info_FormaPago);
                            gridControlForma.Refresh();
                        }
                    }
                    else
                    {
                        colIdFormaPago.OptionsColumn.AllowEdit = true;
                        gridViewForma.AddNewRow();
                        BindingList_orden_pago_formapago = new BindingList<cp_orden_pago_formapago_Info>();
                        bandForma = 1;
                        Info_FormaPago.IdFormaPago = "";
                        Info_FormaPago.descripcion = "";
                        Info_FormaPago.IdTipoTransaccion = "";
                        Info_FormaPago.CodModulo = "";
                        Info_FormaPago.IdTipoMovi_caj = 0;
                        BindingList_orden_pago_formapago.Add(Info_FormaPago);
                        gridControlForma.Refresh();

                    }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString()); 
                    
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

         
            private void gridViewForma_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                try
                {                                 
                    //  borrarChekgridForma();
                 //   gridViewForma.SetFocusedRowCellValue(colCheckForma, true);
                    //gridViewForma.SetRowCellValue(e.FocusedRowHandle, colCheckForma, true);
                    cp_orden_pago_formapago_Info data = (cp_orden_pago_formapago_Info)gridViewForma.GetRow(e.FocusedRowHandle);
                    if (e.FocusedRowHandle != BindingList_orden_pago_formapago.Count - 1)
                    {
                        colIdFormaPago.OptionsColumn.AllowEdit = false;
                        var info = BindingList_orden_pago_formapago.Last();
                        if ((info.IdFormaPago == null || info.descripcion == null))
                        { BindingList_orden_pago_formapago.Remove(info); bandForma = 0; }
                       
                    }
                    else
                    {
                        if (BindingList_orden_pago_formapago.Last().IdFormaPago == null || BindingList_orden_pago_formapago.Last().IdFormaPago == "")
                        {
                            colIdFormaPago.OptionsColumn.AllowEdit = true;

                        }
                    }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        #endregion

        #region cp_orden_tipo_EstadoApro
        
            private void gridViewEstado_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                try
                {
                   // borrarChekgridEstado();

                    //gridViewEstado.SetRowCellValue(e.FocusedRowHandle, colchekEstado, true);
                  //  gridViewEstado.SetFocusedRowCellValue(colchekEstado, true);
                    cp_orden_pago_estado_aprob_Info data = (cp_orden_pago_estado_aprob_Info)gridViewEstado.GetRow(e.FocusedRowHandle);

                    if (e.FocusedRowHandle != BindingList_orden_pago_estado_aprob.Count - 1)
                    {
                        colIdEstadoAprobacion.OptionsColumn.AllowEdit = false;
                        var info = BindingList_orden_pago_estado_aprob.Last();
                        if (info.IdEstadoAprobacion == "" || info.Descripcion == "" || info.IdEstadoAprobacion == null || info.Descripcion == null)
                        {
                            BindingList_orden_pago_estado_aprob.Remove(info); bandEstado = 0;
                        }
                        
                    }
                    else
                    {
                        if (BindingList_orden_pago_estado_aprob.Last().IdEstadoAprobacion == "" || BindingList_orden_pago_estado_aprob.Last().IdEstadoAprobacion == null)
                        {
                            colIdEstadoAprobacion.OptionsColumn.AllowEdit = true;
                            gridViewEstado.FocusedColumn = gridViewTipoOrden_x_Empresa.VisibleColumns[0];
                            gridViewEstado.ShowEditor();
                            gridViewEstado.GetShowEditorMode();

                        }
                    }

                    gridControlEstado.Update();

                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnNuevoEstado_Click(object sender, EventArgs e)
            {
                try
                {
                                                      
                    if (BindingList_orden_pago_estado_aprob.Count > 0)
                    {
                                           
                        var temp = (cp_orden_pago_estado_aprob_Info)gridViewEstado.GetRow(gridViewEstado.RowCount - 1);
                        if (temp.IdEstadoAprobacion != "" && temp.Descripcion != "" && temp.IdEstadoAprobacion != null && temp.Descripcion != null)
                        {
                            bandEstado = 1;
                            Info_Estado = new cp_orden_pago_estado_aprob_Info();
                            BindingList_orden_pago_estado_aprob.Add(Info_Estado);
                            gridControlEstado.Refresh();
                        }
                    }
                    else
                    {
                        colIdEstadoAprobacion.OptionsColumn.AllowEdit = true;
                        gridViewEstado.AddNewRow();
                        BindingList_orden_pago_estado_aprob = new BindingList<cp_orden_pago_estado_aprob_Info>();
                        Info_Estado.IdEstadoAprobacion = "";
                        Info_Estado.Descripcion = "";
                        BindingList_orden_pago_estado_aprob.Add(Info_Estado);
                        bandEstado = 1;
                        gridControlEstado.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
        
        #endregion

        #region cp_orden_tipo_pago

         

            private void gridTipoOrden_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                try
                {
                    cp_orden_pago_tipo_x_empresa_Info data = (cp_orden_pago_tipo_x_empresa_Info)gridViewTipoOrden_x_Empresa.GetRow(e.FocusedRowHandle);
                   //limpiarCombo();
                    Info_x_Emp = BusordenTipoEmpresa.Get_Info_orden_pago_tipo_x_empresa(param.IdEmpresa, data.IdTipo_op);
                    if (Info_x_Emp.IdEmpresa != 0)
                    {
                        set_Info_x_Empresa();
                        

                        //if (e.FocusedRowHandle != BindingList_Pago_Tipo.Count - 1)
                        //{
                        //    colIdTipo_op.OptionsColumn.AllowEdit = false;
                        //    var info = BindingList_Pago_Tipo.Last();
                        //    if (info.IdTipo_op == null || info.Descripcion == null || info.IdTipo_op == "" || info.Descripcion == "")
                        //    { BindingList_Pago_Tipo.Remove(info); bandPago = 0; }

                        //}
                        //else
                        //{
                        //    if (BindingList_Pago_Tipo.Last().IdTipo_op == "" || BindingList_Pago_Tipo.Last().IdTipo_op == null)
                        //    {
                        //        colIdTipo_op.OptionsColumn.AllowEdit = true;
                        //        gridViewTipoOrden_x_Empresa.FocusedColumn = gridViewTipoOrden_x_Empresa.VisibleColumns[0];
                        //        gridViewTipoOrden_x_Empresa.ShowEditor();
                        //        gridViewTipoOrden_x_Empresa.GetShowEditorMode();

                        //    }
                        //}

                        gridControlTipoOrden_x_Empresa.Update();
                    }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString()); 
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //private void btnNuevo_Click(object sender, EventArgs e)
            //{
            //    try
            //    {
            //        //if (BindingList_Pago_Tipo.Count > 0)
            //        //{
            //        //    var temp = (cp_orden_pago_tipo_Info)gridViewTipoOrden_x_Empresa.GetRow(gridViewTipoOrden_x_Empresa.RowCount - 1);
            //        //    if (temp.IdTipo_op != "" && temp.Descripcion != "" && temp.IdTipo_op != null && temp.Descripcion != null)
            //        //    {
            //        //        bandPago = 1;
            //        //        Info_Pago_Tipo = new cp_orden_pago_tipo_Info();
            //        //        Info_Pago_Tipo.Estado = "A";
            //        //        Info_Pago_Tipo.GeneraDiario = "No";
            //        //        //BindingList_Pago_Tipo.Add(Info_Pago_Tipo);

            //        //    }
            //        //}
            //        //else
            //        //{
            //        //    colIdTipo_op.OptionsColumn.AllowEdit = true;
            //        //    gridViewTipoOrden_x_Empresa.AddNewRow();
            //        //    BindingList_Pago_Tipo = new BindingList<cp_orden_pago_tipo_Info>();
            //        //    bandPago = 1;
            //        //    Info_Pago_Tipo.Descripcion = "";
            //        //    Info_Pago_Tipo.Estado = "";
            //        //    Info_Pago_Tipo.IdTipo_op = "";
            //        //    BindingList_Pago_Tipo.Add(Info_Pago_Tipo);
            //        //}
            //    }
            //    catch (Exception ex)
            //    {
            //        Log_Error_bus.Log_Error(ex.ToString()); 
                    
            //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        
        
        #endregion
          
        private void gridTipoOrden_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
            {
                try
                {
                    var data = gridViewTipoOrden_x_Empresa.GetRow(e.RowHandle) as cp_orden_pago_tipo_Info;
                    if (data == null)
                        return;
                    if (data.Estado == "I")
                        e.Appearance.ForeColor = Color.Red;
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void cmb__Click(object sender, EventArgs e)
        {
            try
            {
                cp_orden_pago_tipo_x_empresa_Info Info_fila_pago_tipo_x_empresa = new cp_orden_pago_tipo_x_empresa_Info();

                if (BindingList_x_orden_pago_tipo_x_empresa.Count > 0)
                {

                    var temp = (cp_orden_pago_tipo_x_empresa_Info)gridViewTipoOrden_x_Empresa.GetRow(gridViewTipoOrden_x_Empresa.RowCount - 1);

                    if (temp.IdTipo_op != "" && temp.nom_Tipo_op != "" && temp.IdEstadoAprobacion != null)
                    {
                        bandEstado = 1;
                        Info_fila_pago_tipo_x_empresa = new cp_orden_pago_tipo_x_empresa_Info();

                        Info_fila_pago_tipo_x_empresa.IdEmpresa = param.IdEmpresa;
                        Info_fila_pago_tipo_x_empresa.Viene_de_Base = false;
                        Info_fila_pago_tipo_x_empresa.IdEstadoAprobacion = "APRO";
                        Info_fila_pago_tipo_x_empresa.Estado = "A";
                        Info_fila_pago_tipo_x_empresa.IdTipoCbte_OP = 1;
                        Info_fila_pago_tipo_x_empresa.IdTipoCbte_OP_anulacion = 1;
                        Info_fila_pago_tipo_x_empresa.GeneraDiario = "N";

                        BindingList_x_orden_pago_tipo_x_empresa.Add(Info_fila_pago_tipo_x_empresa);

                        gridControlTipoOrden_x_Empresa.Refresh();
                    }
                }
                else
                {


                    colIdTipo_op.OptionsColumn.AllowEdit = true;
                    gridViewTipoOrden_x_Empresa.AddNewRow();

                    BindingList_x_orden_pago_tipo_x_empresa = new BindingList<cp_orden_pago_tipo_x_empresa_Info>();

                    Info_fila_pago_tipo_x_empresa = new cp_orden_pago_tipo_x_empresa_Info();

                    Info_fila_pago_tipo_x_empresa.IdEmpresa = param.IdEmpresa;
                    Info_fila_pago_tipo_x_empresa.Viene_de_Base = false;
                    Info_fila_pago_tipo_x_empresa.IdEstadoAprobacion = "APRO";
                    Info_fila_pago_tipo_x_empresa.Estado = "A";
                    Info_fila_pago_tipo_x_empresa.IdTipoCbte_OP = 1;
                    Info_fila_pago_tipo_x_empresa.IdTipoCbte_OP_anulacion = 1;
                    Info_fila_pago_tipo_x_empresa.GeneraDiario = "N";

                    BindingList_x_orden_pago_tipo_x_empresa.Add(Info_fila_pago_tipo_x_empresa);
                    bandEstado = 1;

                    gridControlTipoOrden_x_Empresa.Refresh();

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
