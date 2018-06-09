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
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Winform.Inventario;
using Core.Erp.Reportes.Compras;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Aprob_Gene_Orden_Compra_Mant : Form
    {
        #region Declaración de Variables
         //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus ;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus bus_sucursal ;
        cp_proveedor_Bus bus_proveedor ;
        com_solicitud_compra_Bus bus_solicitid ;
        ct_punto_cargo_Bus bus_puntocargo;
        vwcom_solicitud_compra_x_items_con_saldos_Bus bus_solicitudxItems ;    
        com_solicitud_compra_det_aprobacion_Bus bus_SoliAprob ;     
        com_ordencompra_local_det_x_com_solicitud_compra_det_Bus busOCxSCDet ;
        in_UnidadMedida_Bus bus_UniMedida ;     
        com_comprador_Bus busCom ;

        string MensajeError = "";

        //Listas
        List<tb_Sucursal_Info> listSucursal ;
        List<cp_proveedor_Info> listProveedor ;
        List<com_solicitud_compra_Info> listSolicitud = new List<com_solicitud_compra_Info>();
        List<ct_punto_cargo_Info> listpuntoCargo ;
        List<vwcom_solicitud_compra_x_items_con_saldos_Info> listSolicitudxItems;
        List<com_solicitud_compra_det_aprobacion_Info> listSoliAprob;
        List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listOCxSCDet = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();       
        List<in_UnidadMedida_Info> listUniMedidad;
        List<com_comprador_Info> listComprador ;
        List<XCOMP_Rpt006_Info> lstIdPresupuestoCompra = new List<XCOMP_Rpt006_Info>();
        List<com_Motivo_Orden_Compra_Info> listMotivo = new List<com_Motivo_Orden_Compra_Info>();

        BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info> ListaBind = new BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info>();
        //Infos
        vwcom_solicitud_compra_x_items_con_saldos_Info Info;

        ct_Centro_costo_Bus BusCentroCosto;
        List<ct_Centro_costo_Info> listCentroCosto;
        BindingList<ct_centro_costo_sub_centro_costo_Info> BindListaSubCentro;
        //Variables
        int IdSucursal = 0;
        
        string IdEstadoAprobacion = "";
        string IdEstadoPreAprobacion = "";
        string validaMotivo = "";
        decimal IdComprador = 0;
        
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto;
        com_solicitud_compra_det_Bus bus;
        com_solicitud_compra_det_aprobacion_Bus bus_Det_Aproba;
        string Graba_Estado = "";

        string msg = "";
        List<com_solicitud_compra_det_aprobacion_Info> listSoli_Apro_Repro;
        List<com_solicitud_compra_det_pre_aprobacion_Info> listSoli_PreApro_Repro;


        tb_sis_impuesto_Bus BusImpuesto = new tb_sis_impuesto_Bus();
        List<tb_sis_impuesto_Info> listImpuestoIva = new List<tb_sis_impuesto_Info>();


        #endregion

        public FrmCom_Aprob_Gene_Orden_Compra_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnEstadosOC_Click += ucGe_Menu_event_btnEstadosOC_Click;
            ucGe_Menu.event_btnAprobar_Click += ucGe_Menu_event_btnAprobar_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Info != null)
                {
                    foreach (var item in ListaBind)
                    {
                        if (item.Checked == true && item.IdEstadoPreAprobacion == "APR_SOL")
                        {
                            cmbSucursal.Focus();
                            validaMotivo = "N";
                            Graba_Estado = "S";
                            Grabar_Estado(validaMotivo);

                        }
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione la solicitud que desea aprobar", "Sistemas");
                }
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

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                getIdSolicitud();
                XCOMP_Rpt006_rpt reporte = new XCOMP_Rpt006_rpt();
                reporte.RequestParameters = false;
                reporte.lstIdPresupuestoCompra = lstIdPresupuestoCompra;

                reporte.CreateDocument();
                reporte.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void getIdSolicitud()
        {
            try
            {
                lstIdPresupuestoCompra = new List<XCOMP_Rpt006_Info>();
                if (ListaBind.Count > 0)
                {
                    foreach (var item in ListaBind)
                    {
                        if (item.Checked == true)
                        {
                            XCOMP_Rpt006_Info infoRpt = new XCOMP_Rpt006_Info();

                            infoRpt.IdEmpresa = item.IdEmpresa;
                            infoRpt.IdSucursal = item.IdSucursal;
                            infoRpt.IdSolicitudCompra = item.IdSolicitudCompra;
                            infoRpt.Secuencia_SC = item.Secuencia;

                            lstIdPresupuestoCompra.Add(infoRpt);
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


        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cmbSucursal.Focus();
                validaMotivo = "N";
                Graba_Estado = "N";
                Grabar_Estado(validaMotivo);

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnEstadosOC_Click(object sender, EventArgs e)
        {
            try
            {
                cmbSucursal.Focus();

                if (Info != null)
                {

                    if (Validar_Objeto(ListaBind) == false)
                    { return; }
                  
                    Graba_Estado = "T";
                    validaMotivo = "S";
                    Grabar_Estado(validaMotivo);
                }
                else
                {
                    MessageBox.Show("Seleccione la solicitud que desea aprobar Estados y generar orden de Compra", "Sistemas");
                }

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void carga_combos()
        {
            try
            {
                cmbSucursal.cargar_comboTodos();


                listImpuestoIva  = BusImpuesto.Get_List_impuesto_para_Compras("IVA");
                cmbImpuesto_Iva.DataSource = listImpuestoIva;
                
                // carga combo Estado Aprobacion
                bus_solicitid = new com_solicitud_compra_Bus();
                listSolicitud = bus_solicitid.Get_List_solicitud_compra_EstadoApro_SC();

                com_solicitud_compra_Info todosEst = new com_solicitud_compra_Info();
                todosEst.Id = "TODOS";
                todosEst.descripcion = "TODOS";
                listSolicitud.Add(todosEst);

                cmbEstAproSC.Properties.DataSource = listSolicitud;
                cmbEstPreAproSC.Properties.DataSource = listSolicitud;
          
                com_solicitud_compra_Info infoSoliComp = new com_solicitud_compra_Info();
                infoSoliComp = listSolicitud.FirstOrDefault(q => q.Id == "PEN_SOL");
                cmbEstAproSC.EditValue = infoSoliComp.Id;

                cmbEstPreAproSC.EditValue = "TODOS";



                

                cp_proveedor_Bus BusProve = new cp_proveedor_Bus();

                // carga combo Proveedor en el grid
                listProveedor = BusProve.Get_List_proveedor(param.IdEmpresa);
                cmbProveedor_grid.DataSource = listProveedor;

                // carga combo Punto de cargo en el grid
                bus_puntocargo = new ct_punto_cargo_Bus();
                listpuntoCargo = new List<ct_punto_cargo_Info>();
                listpuntoCargo = bus_puntocargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmbIdPunto_cargo_grid.DataSource = listpuntoCargo;

                //carga combo Motivo en grid
                //List<com_Motivo_Orden_Compra_Info> listMotivo = new List<com_Motivo_Orden_Compra_Info>();
                com_Motivo_Orden_Compra_Bus bus_Motivo = new com_Motivo_Orden_Compra_Bus();
                listMotivo = bus_Motivo.Get_List_Motivo_Orden_Compra(param.IdEmpresa);
                cmbMotivo_grid.DataSource = listMotivo;

                

                //carga combo unidad medida en detalle solicitud  
                bus_UniMedida = new in_UnidadMedida_Bus();
                listUniMedidad = new List<in_UnidadMedida_Info>();
                listUniMedidad = bus_UniMedida.Get_list_UnidadMedida();
                cmbUniMedida_grid.DataSource = listUniMedidad;
                cmbUniMedida_grid.DisplayMember = "Descripcion";
                cmbUniMedida_grid.ValueMember = "IdUnidadMedida";

               //carga centro costo                           
                BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();
                BusCentroCosto = new ct_Centro_costo_Bus();
                listCentroCosto = new List<ct_Centro_costo_Info>();
                listCentroCosto = BusCentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmb_centro_costo_grid.DataSource = listCentroCosto;
                cmb_centro_costo_grid.DisplayMember= "Centro_costo";
                cmb_centro_costo_grid.ValueMember= "IdCentroCosto";



//                Sin Orden de Compra
//Con Orden de Compra
//Todas

    //cmb_Estado_OC.Items.Add(



            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                    
        }
        
        void carga_grid()
        {
            try
            {

                IdSucursal = cmbSucursal.get_SucursalInfo().IdSucursal;
                IdEstadoAprobacion = cmbEstAproSC.EditValue.ToString();

                IdEstadoPreAprobacion = cmbEstPreAproSC.EditValue.ToString();



                IdComprador = (cmbComprador.get_CompradorInfo() == null) ? 0 : cmbComprador.get_CompradorInfo().IdComprador;
            
                
                                
                listSolicitudxItems = new List<vwcom_solicitud_compra_x_items_con_saldos_Info>();
                bus_solicitudxItems = new vwcom_solicitud_compra_x_items_con_saldos_Bus();
                listSolicitudxItems = bus_solicitudxItems.Get_List_SoliComxItemSaldos(param.IdEmpresa, dtpFechaIni.Value, dtpFechaFin.Value, IdEstadoAprobacion,IdEstadoPreAprobacion, IdSucursal, IdComprador);

                if (listSolicitudxItems.Count()==0)
                {
                    ListaBind = new BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info>();
                    gridControlConsulta.DataSource = ListaBind;
                    gridViewConsulta.OptionsBehavior.Editable = false;
                  

                    return;
                }


                foreach (var item in listSolicitudxItems)
                {
                    if(item.IdProducto==0)
                    {                    
                        item.Ico1 = (Bitmap)imageListAgregarEdit.Images[0];
                        item.Ico2 = (Bitmap)imageListAgregarEdit.Images[1];                     
                    }
                   
                }        
                
                ListaBind = new BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info>(listSolicitudxItems);                                                    
                gridControlConsulta.DataSource = ListaBind;

                gridViewConsulta.OptionsBehavior.Editable = true;
                
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }              
        }

        private void FrmCom_Aprob_Gene_Orden_Compra_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaFin.Value = param.Fecha_Transac;
                dtpFechaIni.Value = Convert.ToDateTime(dtpFechaFin.Value).AddDays(-30);
                               
                ListaBind = new BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info>();
                gridControlConsulta.DataSource = ListaBind;
                         
                carga_combos();
            
                IdSucursal = 0;
              //  IdEstadoAprobacion = "TODOS";
                IdEstadoAprobacion = "PEN_SOL";
                carga_grid();

               // cmbEstAproSC.EditValue = "TODOS";
                cmbEstAproSC.EditValue = "PEN_SOL";

                // consultar tabla intermedia com_ordencompra_local_det_x_com_solicitud_compra_det 
                busOCxSCDet = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();  
       
                listOCxSCDet = busOCxSCDet.Get_List_ordencompra_local_det_x_com_solicitud_compra_det(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void gridViewConsulta_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                double iva = 0;
                double Porc_Iva = 0;    
                
                vwcom_solicitud_compra_x_items_con_saldos_Info info = new vwcom_solicitud_compra_x_items_con_saldos_Info();  
                Info = (vwcom_solicitud_compra_x_items_con_saldos_Info)this.gridViewConsulta.GetFocusedRow();
                if (Info!=null)
                {
                    /*N*/
                    info = ListaBind.FirstOrDefault(q => q.IdProducto == Info.IdProducto && q.Secuencia == Info.Secuencia && q.IdSolicitudCompra == Info.IdSolicitudCompra && q.IdSucursal == Info.IdSucursal);

                    if (e.HitInfo.Column != null)
                    {
                        if (gridViewConsulta.FocusedColumn.FieldName == "Tiene_OC")
                        {
                            if (info.ocd_IdOrdenCompra != null)
                            {
                                frmCom_OrdenCompra_Mant frmOC = new frmCom_OrdenCompra_Mant();
                                frmOC.MdiParent = this.MdiParent;
                                frmOC.Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                com_ordencompra_local_Bus BusOC = new com_ordencompra_local_Bus();
                                com_ordencompra_local_Info InfoCab = new com_ordencompra_local_Info();
                                InfoCab = BusOC.Get_Info_ordencompra_local(Convert.ToInt32(info.ocd_IdEmpresa), Convert.ToInt32(info.ocd_IdSucursal), Convert.ToDecimal(info.ocd_IdOrdenCompra));
                                frmOC.Set_Info(InfoCab);
                                frmOC.Show();
                            }
                        }

                        if (gridViewConsulta.FocusedColumn.FieldName == colIdCodImpuesto_Iva.Name )
                        {
                            double subtotal = Math.Round(Convert.ToDouble(gridViewConsulta.GetFocusedRowCellValue(coldo_subtotal)), 2);


                            tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                            InfoTipoImpuesto = listImpuestoIva.FirstOrDefault(v => v.IdCod_Impuesto == info.IdCod_Impuesto_Iva);
                            iva = 0;
                            Porc_Iva = 0;

                            if (InfoTipoImpuesto != null)
                            {
                                iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                                Porc_Iva = InfoTipoImpuesto.porcentaje;
                            }

                                gridViewConsulta.SetFocusedRowCellValue(coldo_iva, iva);
                                gridViewConsulta.SetFocusedRowCellValue(coldo_total, subtotal);
                                return;
                            


                        }

                        if (gridViewConsulta.FocusedColumn.FieldName == "Checked_Estado")
                        {
                            if ((Boolean)gridViewConsulta.GetFocusedRowCellValue(colChecked_Estado))
                            {
                                gridViewConsulta.SetFocusedRowCellValue(colChecked_Estado, false);
                                gridViewConsulta.SetFocusedRowCellValue(this.colcmb_Estado_AproSC, gridViewConsulta.GetFocusedRowCellValue(colIdEstadoAprobacion_AUX));
                                gridViewConsulta.SetFocusedRowCellValue(colChecked, false);

                                gridViewConsulta.SetFocusedRowCellValue(colcant_ing_SolCom, gridViewConsulta.GetFocusedRowCellValue(colcant_ing_SolCom_AUX));
                                gridViewConsulta.SetFocusedRowCellValue(colSaldo_cant_SolCom, gridViewConsulta.GetFocusedRowCellValue(colSaldo_cant_SolCom_AUX));
                                gridViewConsulta.SetFocusedRowCellValue(colChecked, false);
                                
                            }
                            else
                            {
                                gridViewConsulta.SetFocusedRowCellValue(colChecked_Estado, true);
                                gridViewConsulta.SetFocusedRowCellValue(this.colcmb_Estado_AproSC, "APR_SOL");
                                gridViewConsulta.SetFocusedRowCellValue(colChecked, true);
                                double saldo_aux = Convert.ToDouble(gridViewConsulta.GetFocusedRowCellValue(colSaldo_cant_SolCom_AUX));
                                double cant_ing = Convert.ToDouble(gridViewConsulta.GetFocusedRowCellValue(colcant_ing_SolCom));
                                double saldo = (saldo_aux != 0) ? saldo = saldo_aux - cant_ing : saldo = cant_ing;
                                gridViewConsulta.SetFocusedRowCellValue(colcant_ing_SolCom, cant_ing);
                                gridViewConsulta.SetFocusedRowCellValue(colChecked, true);
                            }
                        }
                        if (gridViewConsulta.FocusedColumn.FieldName == "Checked")
                        {
                            if ((Boolean)gridViewConsulta.GetFocusedRowCellValue(colChecked))
                            {
                                gridViewConsulta.SetFocusedRowCellValue(colChecked, false);

                                if ((Boolean)gridViewConsulta.GetFocusedRowCellValue(colChecked) == false)
                                {
                                    var asd = gridViewConsulta.GetRow(gridViewConsulta.FocusedRowHandle);
                                }
                                gridViewConsulta.SetFocusedRowCellValue(colcant_ing_SolCom, gridViewConsulta.GetFocusedRowCellValue(colcant_ing_SolCom_AUX));
                                gridViewConsulta.SetFocusedRowCellValue(colSaldo_cant_SolCom, gridViewConsulta.GetFocusedRowCellValue(colSaldo_cant_SolCom_AUX));
                                gridViewConsulta.SetFocusedRowCellValue(colChecked, false);
                                
                                return;
                            }
                            else
                            {
                                if (Info.IdProducto == 0)
                                {
                                    MessageBox.Show("El item: " + Info.NomProducto + " , no existe en el Maestro de Productos", "Sistemas");
                                    return;
                                }
                                var itemVeri = listOCxSCDet.FirstOrDefault(q => q.scd_IdEmpresa == Info.IdEmpresa && q.scd_IdSucursal == Info.IdSucursal && q.scd_IdSolicitudCompra == Info.IdSolicitudCompra && q.scd_Secuencia == Info.Secuencia);
                                if (itemVeri != null)
                                {
                                    MessageBox.Show("La solicitud #: [" + Info.IdSolicitudCompra + "], tiene asociada una Orden de Compra ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                                }
                                gridViewConsulta.SetFocusedRowCellValue(colcant_ing_SolCom, gridViewConsulta.GetFocusedRowCellValue(colSaldo_cant_SolCom_AUX));
                                double saldo_aux = Convert.ToDouble(gridViewConsulta.GetFocusedRowCellValue(colSaldo_cant_SolCom_AUX));
                                double cant_ing = Convert.ToDouble(gridViewConsulta.GetFocusedRowCellValue(colcant_ing_SolCom));
                                double saldo = saldo_aux - cant_ing;
                                gridViewConsulta.SetFocusedRowCellValue(colSaldo_cant_SolCom, saldo);
                                gridViewConsulta.SetFocusedRowCellValue(colChecked, true);
                            }
                        }

                        in_Producto_Info infoP = new in_Producto_Info();
                        if (gridViewConsulta.FocusedColumn.FieldName == "Ico2")
                        {
                            if (Info.IdProducto == 0)
                            { //insertar
                                FrmIn_Producto_Mant frmManProd = new FrmIn_Producto_Mant();
                                frmManProd.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar);
                                //frmManProd.Producto = Info.NomProducto;
                                frmManProd.ShowDialog();
                                infoP = frmManProd.Get_producto();
                                if (infoP != null)
                                {
                                    if (infoP.IdProducto != 0)
                                    {
                                        //codigo para actualizar idproducto en solicitud de la fila seleccionada y solicitud detalle aprobacion                  
                                        bus = new com_solicitud_compra_det_Bus();
                                        bus_Det_Aproba = new com_solicitud_compra_det_aprobacion_Bus();
                                        foreach (var item in ListaBind)
                                        {
                                            if (item.IdProducto == Info.IdProducto && item.Secuencia == Info.Secuencia && item.IdSolicitudCompra == Info.IdSolicitudCompra && item.IdSucursal == Info.IdSucursal)
                                            {
                                                string mensaje = "";
                                                if (bus.Actualizar_Producto_Creado(Info.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra, Info.Secuencia, infoP.IdProducto, infoP.pr_descripcion, ref mensaje))
                                                {
                                                    if (bus_Det_Aproba.Actualizar_Producto_Creado_Det_Aproba(Info.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra, Info.Secuencia, infoP.IdProducto, infoP.pr_descripcion, ref mensaje))
                                                    {
                                                        item.IdProducto = infoP.IdProducto;
                                                        item.NomProducto = infoP.pr_descripcion;

                                                        //item.Paga_Iva = infoP.pr_ManejaIva == "S" ? true : false;
                                                        item.Ico2 = null;
                                                        item.Ico1 = null;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                frmManProd.event_FrmIn_Producto_Mant_FormClosing += frmManProd_event_FrmIn_Producto_Mant_FormClosing;
                            }
                        }

                        if (gridViewConsulta.FocusedColumn.FieldName == "Ico1")
                        {
                            if (Info.IdProducto == 0)
                            { //editar
                                FrmIn_Producto_Cons frmProduC = new FrmIn_Producto_Cons();
                                frmProduC.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Never;
                                frmProduC.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
                                frmProduC.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Never;
                                frmProduC.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
                                frmProduC.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Never;
                                frmProduC.llamado_externamente = true;
                                frmProduC.ShowDialog();
                                infoP = frmProduC.Get_Info_Producto();
                                if (infoP.IdProducto != 0)
                                {
                                    //codigo para actualizar idproducto en solicitud de la fila seleccionada y solicitud detalle aprobacion                  
                                    bus = new com_solicitud_compra_det_Bus();
                                    bus_Det_Aproba = new com_solicitud_compra_det_aprobacion_Bus();
                                    foreach (var item in ListaBind)
                                    {
                                        if (item.IdProducto == Info.IdProducto && item.Secuencia == Info.Secuencia && item.IdSolicitudCompra == Info.IdSolicitudCompra && item.IdSucursal == Info.IdSucursal)
                                        {
                                            string mensaje = "";
                                            if (bus.Actualizar_Producto_Creado(Info.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra, Info.Secuencia, infoP.IdProducto, infoP.pr_descripcion, ref mensaje))
                                            {
                                                if (bus_Det_Aproba.Actualizar_Producto_Creado_Det_Aproba(Info.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra, Info.Secuencia, infoP.IdProducto, infoP.pr_descripcion, ref mensaje))
                                                {
                                                    item.IdProducto = infoP.IdProducto;
                                                    item.NomProducto = infoP.pr_descripcion;
                                                    //item.Paga_Iva = infoP.pr_ManejaIva == "S" ? true : false;
                                                    item.Ico2 = null;
                                                    item.Ico1 = null;
                                                }
                                            }
                                        }
                                    }
                                }
                                frmProduC.event_FrmIn_Producto_Cons_FormClosing += frmProduC_event_FrmIn_Producto_Cons_FormClosing;
                            }
                        }
                    }
                    calculos(ListaBind);
                }

                gridControlConsulta.RefreshDataSource();
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConsulta_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                vwcom_solicitud_compra_x_items_con_saldos_Info info = new vwcom_solicitud_compra_x_items_con_saldos_Info();               
                Info = (vwcom_solicitud_compra_x_items_con_saldos_Info)this.gridViewConsulta.GetFocusedRow();       
                info = ListaBind.FirstOrDefault(q => q.IdProducto == Info.IdProducto && q.Secuencia == Info.Secuencia && q.IdSolicitudCompra == Info.IdSolicitudCompra && q.IdSucursal == Info.IdSucursal);

                                    
                if (e.Column.Name == "colcant_ing_SolCom")
                {
                    var itemVeri = listOCxSCDet.FirstOrDefault(q => q.scd_IdEmpresa == info.IdEmpresa && q.scd_IdSucursal == info.IdSucursal && q.scd_IdSolicitudCompra == info.IdSolicitudCompra && q.scd_Secuencia == info.Secuencia);
                    if (itemVeri != null)
                    {
                        MessageBox.Show("La solicitud #: [" + info.IdSolicitudCompra + "], tiene asociada una Orden de Compra ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                                      
                        foreach (var item in ListaBind)
                        {
                            if (item.IdProducto == info.IdProducto && item.Secuencia == info.Secuencia && item.IdSolicitudCompra == info.IdSolicitudCompra)
                            {                                                            
                                item.cant_ing_SolCom = item.cant_solicitada - item.Saldo_cant_SolCom_AUX;
                            }
                        }
                        return;
                    }    
                                                                                                                                   
                    double cant_ing_SolCom = Convert.ToDouble(gridViewConsulta.GetFocusedRowCellValue(colcant_ing_SolCom));
                    double Saldo_cant_SolCom = Convert.ToDouble(gridViewConsulta.GetFocusedRowCellValue(colSaldo_cant_SolCom));
                    double cant_solicitada =  Convert.ToDouble(gridViewConsulta.GetFocusedRowCellValue(colcant_solicitada));

                   
                
                    if (info.Saldo_cant_SolCom_AUX == 0)
                    {
                        foreach (var item in ListaBind)
                        {
                            
                        }
                    }
                    else
                    {                     
                        if (cant_ing_SolCom < 0)
                        {
                            foreach (var item in ListaBind)
                            {
                                if (item.IdProducto == info.IdProducto && item.Secuencia == info.Secuencia && item.IdSolicitudCompra == info.IdSolicitudCompra && item.IdSucursal == info.IdSucursal)
                                {
                                    item.cant_ing_SolCom = item.cant_ing_SolCom_AUX;
                                    item.Saldo_cant_SolCom = item.Saldo_cant_SolCom_AUX;
                                    item.Checked = false;

                                    return;
                                }
                            }
                        }
                        if (cant_ing_SolCom == 0)
                        {
                            foreach (var item in ListaBind)
                            {
                                if (item.IdProducto == info.IdProducto && item.Secuencia == info.Secuencia && item.IdSolicitudCompra == info.IdSolicitudCompra && item.IdSucursal == info.IdSucursal)
                                {
                                   
                                    item.Saldo_cant_SolCom = item.cant_solicitada;
                                    item.Checked = true;

                                    return;
                                }
                            }
                        }

                        
                         double tot = cant_solicitada - cant_ing_SolCom;

                        if (tot < 0)
                        {
                            foreach (var item in ListaBind)
                            {
                                if (item.IdProducto == info.IdProducto && item.Secuencia == info.Secuencia && item.IdSolicitudCompra == info.IdSolicitudCompra && item.IdSucursal == info.IdSucursal)
                                {                                                                     
                                    item.cant_ing_SolCom = item.cant_ing_SolCom_AUX;
                                    item.Saldo_cant_SolCom = item.Saldo_cant_SolCom_AUX;
                                    item.Checked = false;
                               
                                    return;
                                }
                            }
                        }
                        else
                        {
                            foreach (var item in ListaBind)
                            {
                                if (item.IdProducto == info.IdProducto && item.Secuencia == info.Secuencia && item.IdSolicitudCompra == info.IdSolicitudCompra && item.IdSucursal == info.IdSucursal)
                                {
                                    item.Saldo_cant_SolCom = tot;
                                    item.Checked = true;
                        
                                }
                            }
                        }
                    }
                }

                if (e.Column.Name == "colcmbEstAproSC_grid" || e.Column.Name == "colcmbProveedor_grid" || e.Column.Name == "colIdPunto_cargo_grid" || e.Column.Name == "colcant_ing_SolCom")
                {
                    if (e.Column.Name == "colcmbEstAproSC_grid")
                    {
                        foreach (var item in ListaBind)
                        {
                            if (item.IdProducto == info.IdProducto && item.Secuencia == info.Secuencia && item.IdSolicitudCompra == info.IdSolicitudCompra && item.IdSucursal == info.IdSucursal && (item.IdEstadoAprobacion == "PEN_SOL" || item.IdEstadoAprobacion == "REP_SOL"))
                            {
                                
                            }
                        }                   
                    }                                                                           
                                                     
                }

 ct_centro_costo_sub_centro_costo_Bus busSubCen = new ct_centro_costo_sub_centro_costo_Bus();
               if (e.Column == colNomsub_centro_costo)
                  
                {
                    if (!String.IsNullOrEmpty(Convert.ToString(Info.Nomsub_centro_costo)))
                    {                                            
                        foreach (var item in ListaBind)
                        {
                            if (item.IdProducto == info.IdProducto && item.Secuencia == info.Secuencia && item.IdSolicitudCompra == info.IdSolicitudCompra && item.IdSucursal == info.IdSucursal /*&& (item.IdEstadoAprobacion == "PEN_SOL" || item.IdEstadoAprobacion == "REP_SOL")*/)
                            {

                               if(item.IdCentroCosto == null)
                               {
                                   item.Nomsub_centro_costo = null;
                                   item.IdCentroCosto_sub_centro_costo= null;
                                   return;
                               }
                                
                                BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();
                                  BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>
                                (busSubCen.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, item.IdCentroCosto));
                                
                                string idSubcentro = "";
                               idSubcentro = BindListaSubCentro.FirstOrDefault
                               (q => Info.Nomsub_centro_costo == "[" + q.IdCentroCosto_sub_centro_costo.Trim() + "] - " + q.Centro_costo.Trim()).IdCentroCosto_sub_centro_costo;
                          
                                item.IdCentroCosto_sub_centro_costo = idSubcentro;
                            }
                        }                                                                     
                    }
                }
                calculos(ListaBind);
            
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        void calculos( BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info> ListaBind)
        {
            try
            {               
                foreach (var item in ListaBind)
                {                   
                    item.do_descuento = Math.Round(((item.cant_ing_SolCom * item.do_precioCompra) * (item.do_porc_des / 100)), 2);
                    item.do_subtotal = Math.Round(((item.cant_ing_SolCom * item.do_precioCompra) - item.do_descuento), 2);
                    
                    //if (item.Paga_Iva== true)
                    //{                                             
                       item.do_iva = Math.Round(item.do_subtotal*(param.iva.porcentaje / 100), 2);
                       item.do_total = Math.Round((item.do_subtotal + item.do_iva), 2);
                    //}
                    //else
                    //{
                    //    item.do_iva = 0;
                    //    item.do_total = item.do_subtotal;                                           
                    //}                                    
                }                           
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void gridViewConsulta_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colIdCentroCosto")
                {                  
                    cmb_sub_centro_grid.Items.Clear();
                    Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();

                    foreach (var item in Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, Convert.ToString(e.Value)))
                    {                      
                        item.NomSubCentroCosto = "[" + item.IdCentroCosto_sub_centro_costo.Trim() + "] - " + item.Centro_costo.Trim();
                        cmb_sub_centro_grid.Items.Add(item.NomSubCentroCosto);
                    }

                    gridViewConsulta.SetFocusedRowCellValue(colIdCentroCosto, Convert.ToString(e.Value));
                    gridViewConsulta.SetFocusedRowCellValue(colNomsub_centro_costo, null);
              
                    if (gridViewConsulta.GetFocusedRowCellValue(colIdCentroCosto) == "" || 
                        gridViewConsulta.GetFocusedRowCellValue(colIdCentroCosto) == null)
                    {
                        gridViewConsulta.SetFocusedRowCellValue(colIdCentroCosto_sub_centro_costo, null);
                    }
                }

                if (e.Column.Name == colcmbProveedor_grid.Name)
                {
                    if (e.Value != null)
                    {
                        decimal IdProveedor = 0;
                        IdProveedor = Convert.ToDecimal(e.Value);
                        cp_proveedor_Info InfoProvee = listProveedor.FirstOrDefault(v => v.IdProveedor == IdProveedor);
                        if (InfoProvee.pr_estado == "I")
                        {
                            MessageBox.Show("No se puede escoger un proveedor Anulado ....", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            gridViewConsulta.SetFocusedRowCellValue(colcmbProveedor_grid, null);
                            return;
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

        void Grabar_Estado(string validaMotivo)
        {
            try
            {                              
                listSoli_Apro_Repro = new List<com_solicitud_compra_det_aprobacion_Info>();
                
                List<com_solicitud_compra_det_aprobacion_Info> lstSol_Genera_OC = new List<com_solicitud_compra_det_aprobacion_Info>();

                string estado = "";

                 foreach (var item in ListaBind.Where(q=>q.Checked == true))
                {
                   decimal idsolicitud = 0;
                   com_solicitud_compra_det_aprobacion_Info infoSoliApro = new com_solicitud_compra_det_aprobacion_Info();
                        idsolicitud = item.IdSolicitudCompra;
                        infoSoliApro.Checked = item.Checked;
                        infoSoliApro.Checked_Estado = item.Checked_Estado;
                        infoSoliApro.IdEmpresa = item.IdEmpresa;                                         
                        infoSoliApro.IdSucursal_SC = item.IdSucursal;
                        infoSoliApro.IdSolicitudCompra = item.IdSolicitudCompra;                     
                        infoSoliApro.Secuencia_SC = item.Secuencia;                    
                        infoSoliApro.IdProducto_SC = item.IdProducto;                    
                        infoSoliApro.NomProducto_SC = item.nom_producto=item.NomProducto.Trim();                  
                        infoSoliApro.Cantidad_aprobada = item.cant_ing_SolCom;
                        infoSoliApro.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        infoSoliApro.IdEstadoAprobacion_AUX = item.IdEstadoAprobacion_AUX;
                        infoSoliApro.Graba_Estado = Graba_Estado;
                        estado = infoSoliApro.Graba_Estado = Graba_Estado;                   
                        infoSoliApro.IdProveedor_SC = item.IdProveedor;

                        cp_proveedor_Info InfoProvee_x_Fila=   (cp_proveedor_Info)listProveedor.FirstOrDefault(v => v.IdProveedor == item.IdProveedor);
                        infoSoliApro.Nom_Proveedor_SC = InfoProvee_x_Fila.pr_nombre;

                        if (listMotivo.Count >0) 
                        infoSoliApro.IdMotivo = listMotivo.First().IdMotivo;
                        infoSoliApro.IdUnidadMedida = item.IdUnidadMedida;
                        infoSoliApro.IdUsuarioAprueba = param.IdUsuario;
                        infoSoliApro.FechaHoraAprobacion= param.Fecha_Transac;
                        infoSoliApro.observacion =item.observacion;                   
                        infoSoliApro.do_precioCompra = item.do_precioCompra;
                        infoSoliApro.do_porc_des = item.do_porc_des;
                        infoSoliApro.do_descuento = item.do_descuento;
                        infoSoliApro.do_subtotal = item.do_subtotal;
                        infoSoliApro.do_iva = item.do_iva;
                        infoSoliApro.do_total = item.do_total;
                        //infoSoliApro.do_ManejaIva = item.do_ManejaIva;
                        infoSoliApro.IdCentroCosto = item.IdCentroCosto;
                        infoSoliApro.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        infoSoliApro.IdPunto_cargo = item.IdPunto_cargo;
                        infoSoliApro.do_observacion = item.do_observacion;
                        infoSoliApro.fecha = item.fecha;
                        infoSoliApro.Solicitante = item.Solicitante;
                        infoSoliApro.IdComprador = item.IdComprador;
                        infoSoliApro.IdPersona_Solicita = item.IdPersona_Solicita;
                        infoSoliApro.IdDepartamento = item.IdDepartamento;

                        infoSoliApro.IdEstadoPreAprobacion = item.IdEstadoPreAprobacion;
                        

                        //verificar si tiene orden compra asociada
                        List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listSolicitud = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
                        com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_Solicitud = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();                    
                        listSolicitud = bus_Solicitud.Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(item.IdEmpresa, item.IdSucursal, item.IdSolicitudCompra, item.Secuencia);

                        if (listSolicitud.Count() != 0)
                        {                         
                            MessageBox.Show("El item : " + item.nom_producto.Trim() + ", de la solicitud #: [" + item.IdSolicitudCompra + "], tiene asociada una Orden de Compra. No se puede modificar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }
                        else
                        {
                            listSoli_Apro_Repro.Add(infoSoliApro);
                        }                                 
                    }                  
                
                  string msg1 = "";

                bus_SoliAprob = new com_solicitud_compra_det_aprobacion_Bus();

                //verifico las sucursales para las OC
                if (listSoli_Apro_Repro.Where(q => q.Checked == true && q.IdEstadoAprobacion == "APR_SOL" && q.IdEstadoPreAprobacion == "APR_SOL" ).Count() > 0)
                {
                    FrmCom_Confirmacion_SC_para_OC frm = new FrmCom_Confirmacion_SC_para_OC();
                    frm.set_Grid(listSoli_Apro_Repro);
                    frm.ShowDialog();
                    lstSol_Genera_OC = frm.get_Grid();
                }

                if (bus_SoliAprob.Actualizar_EstadoReproba(listSoli_Apro_Repro, lstSol_Genera_OC, validaMotivo, ref msg1))
                {
                    if (MessageBox.Show("¿Desea Imprimir el Soporte?" + "\n" + "Imprimir", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ucGe_Menu_event_btnImprimir_Click(null, null);
                    }

                    if (estado=="N")
                    {                        
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Solicitud de Compra ", Info.IdSolicitudCompra);
                        MessageBox.Show(smensaje, param.Nombre_sistema ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        carga_grid();
                    }
                    if (estado == "S")
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Solicitud de Compra ", Info.IdSolicitudCompra);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        carga_grid();
                    }
                    if (estado == "T")
                    {
                           //llamar formulario                  
                           // consulta tabla com_ordencompra_local_det_x_com_solicitud_compra_det                    
                            com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_DetCOxDetSC = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
                            List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> lista = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
                            
                            lista = bus_DetCOxDetSC.Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud (listSoli_Apro_Repro);

                            if (lista.Count !=0)
                            {
                                List<com_ordencompra_local_Info> list_OrdComp = new List<com_ordencompra_local_Info>();
                                var ListaGroup = lista.GroupBy(v => v.ocd_IdOrdenCompra).Select(g => new
                                {
                                    Key = g.Key,

                                    IdEmpresa = g.First().ocd_IdEmpresa,
                                    IdSucursal = g.First().ocd_IdSucursal,
                                    IdOrdenCompra = g.First().ocd_IdOrdenCompra

                                });

                                foreach (var item in ListaGroup)
                                {
                                    com_ordencompra_local_Info info = new com_ordencompra_local_Info();
                                    info.IdEmpresa = item.IdEmpresa;
                                    info.IdSucursal = item.IdSucursal;
                                    info.IdOrdenCompra = item.IdOrdenCompra;
                                    info.oc_fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                                    list_OrdComp.Add(info);
                                }

                                FrmCom_OrdenCompra_Gene_x_Solicitud_Cons frm = new FrmCom_OrdenCompra_Gene_x_Solicitud_Cons();
                                frm.list_OrdComp = list_OrdComp;
                                frm.Show();
                            }
                           carga_grid();
                           
                    }
                    LimpiarDatos();
                }
                else
                {
                    if (estado == "N")
                    {
                        MessageBox.Show("Error al Grabar" + msg1 + "", "Sistemas");
                    }
                    if (estado == "S")
                    {
                        MessageBox.Show("Error al Grabar Estado." + msg1 + "", "Sistemas");
                    }
                    if (estado == "T")
                    {
                        MessageBox.Show("Error al Generar la Orden Compra" + msg1 + "", "Sistemas");
                    }
                  
                }
          
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                      
        }
                 
        Boolean Validar_Objeto(BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info> lista)
        {

            try
            {
                cmbComprador.Focus();

              

                foreach (var item in lista)
                {
                    if (item.Checked == true)
                    {
                        if (item.IdProveedor == 0 )
                        {
                            MessageBox.Show("Ingrese el Proveedor.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }


                        if (item.cant_ing_SolCom <= 0)
                        {
                            MessageBox.Show("La Cantidad Ingresada debe de ser mayor a 0.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }


                        if (item.IdProducto == 0)
                        {
                            MessageBox.Show("Hay solicitudes sin un producto en base ",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;       
            }
        }

        private void gridViewConsulta_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                cmb_sub_centro_grid.Items.Clear();
                Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();

                foreach (var item in Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, Convert.ToString(gridViewConsulta.GetFocusedRowCellValue(colIdCentroCosto))))
                {
                    item.NomSubCentroCosto = "[" + item.IdCentroCosto_sub_centro_costo.Trim() + "] - " + item.Centro_costo.Trim();
                    cmb_sub_centro_grid.Items.Add(item.NomSubCentroCosto);                                     
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        void frmManProd_event_FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info)
        {
            //codigo para actualizar idproducto en solicitud de la fila seleccionada y solicitud detalle aprobacion                  
            bus = new com_solicitud_compra_det_Bus();
            bus_Det_Aproba = new com_solicitud_compra_det_aprobacion_Bus();
            foreach (var item in ListaBind)
            {
                if (item.IdProducto == Info.IdProducto && item.Secuencia == Info.Secuencia && item.IdSolicitudCompra == Info.IdSolicitudCompra && item.IdSucursal == Info.IdSucursal)
                {
                    string mensaje = "";
                    if (bus.Actualizar_Producto_Creado(Info.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra, Info.Secuencia, info.IdProducto, info.pr_descripcion, ref mensaje))
                    {
                        if (bus_Det_Aproba.Actualizar_Producto_Creado_Det_Aproba(Info.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra, Info.Secuencia, info.IdProducto, info.pr_descripcion, ref mensaje))
                        {
                            item.IdProducto = info.IdProducto;
                            item.NomProducto = info.pr_descripcion;
                            //item.Paga_Iva = info.pr_ManejaIva== "S" ? true : false;
                          
                            item.Ico2 = null;
                            item.Ico1 = null;
                        }
                    }
                }
            }                
        }
      
        void frmProduC_event_FrmIn_Producto_Cons_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info)
        {
            //codigo para actualizar idproducto en solicitud de la fila seleccionada y solicitud detalle aprobacion              
            bus = new com_solicitud_compra_det_Bus();
            bus_Det_Aproba = new com_solicitud_compra_det_aprobacion_Bus();

            foreach (var item in ListaBind)
            {
                if (item.IdProducto == Info.IdProducto && item.Secuencia == Info.Secuencia && item.IdSolicitudCompra == Info.IdSolicitudCompra && item.IdSucursal == Info.IdSucursal)
                {
                    string mensaje = "";
                    if (bus.Actualizar_Producto_Creado(Info.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra, Info.Secuencia, info.IdProducto,info.pr_descripcion, ref mensaje))
                    {
                        if (bus_Det_Aproba.Actualizar_Producto_Creado_Det_Aproba(Info.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra, Info.Secuencia, info.IdProducto,info.pr_descripcion, ref mensaje))
                        {
                            item.IdProducto = info.IdProducto;
                            item.NomProducto = info.pr_descripcion;
                            item.Ico2 = null;
                            item.Ico1 = null;
                        }
                    }
                }
            }           
        }
      
        private void gridViewConsulta_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colNomProducto")
                {
                    var IdProducto = Convert.ToDecimal(gridViewConsulta.GetRowCellValue(e.RowHandle, colIdProducto));
                    if (IdProducto == 0)
                    {                        
                        e.Appearance.ForeColor = Color.Orange;
                    }                     
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
               
                
                carga_grid();
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

        private void btnImprimirGrid_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewConsulta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimpiarDatos()
        {
            try
            {
                ListaBind = new BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info>();
                listSoli_Apro_Repro = new List<com_solicitud_compra_det_aprobacion_Info>();
                dtpFechaFin.Value = param.Fecha_Transac;
                dtpFechaIni.Value = Convert.ToDateTime(dtpFechaFin.Value).AddDays(-30);
                
                gridControlConsulta.DataSource = ListaBind;

                IdSucursal = 0;
                IdEstadoAprobacion = "PEN_SOL";
                carga_grid();

                cmbEstAproSC.EditValue = "PEN_SOL";

                busOCxSCDet = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();  
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}
