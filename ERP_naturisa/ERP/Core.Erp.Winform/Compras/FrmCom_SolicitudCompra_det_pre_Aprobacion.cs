using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Business.General;
using Core.Erp.Reportes.Compras;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;


namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_SolicitudCompra_det_pre_Aprobacion : Form
    {
        com_solicitud_compra_Bus SolComBus = new com_solicitud_compra_Bus();
        BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info> BindList_DetSolCom = new BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<vwcom_solicitud_compra_x_items_con_saldos_Info> listSolicitudxItems = new List<vwcom_solicitud_compra_x_items_con_saldos_Info>();
        vwcom_solicitud_compra_x_items_con_saldos_Bus bus_solicitudxItems = new vwcom_solicitud_compra_x_items_con_saldos_Bus();
        List<XCOMP_Rpt005_Info> lstIdSolicitudCompra = new List<XCOMP_Rpt005_Info>();
        List<com_Catalogo_Info> listEstadoAprobacion = new List<com_Catalogo_Info>();

        com_Catalogo_Bus com_cataBus = new com_Catalogo_Bus();
        com_parametro_Bus ParamBus = new com_parametro_Bus();
        com_parametro_Info ParamInfo = new com_parametro_Info();

        com_solicitud_compra_det_Bus bus_detComSol = new com_solicitud_compra_det_Bus();

        List<com_solicitud_compra_det_Info> lista_DetSolCom = new List<com_solicitud_compra_det_Info>();
        
        
        public FrmCom_SolicitudCompra_det_pre_Aprobacion()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant.event_btnSalir_Click += ucGe_Menu_Superior_Mant_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant.event_btnImprimir_Click += ucGe_Menu_Superior_Mant_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant.event_btnAprobar_Click += ucGe_Menu_Superior_Mant_event_btnAprobar_Click;
            ucGe_Menu_Superior_Mant.event_btnAprobarGuardarSalir_Click += ucGe_Menu_Superior_Mant_event_btnAprobarGuardarSalir_Click;

            ucGe_Menu_Superior_Mant.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant_event_btnlimpiar_Click;
            
        }

        void ucGe_Menu_Superior_Mant_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                getIdSolicitud();
                XCOMP_Rpt005_rpt reporte = new XCOMP_Rpt005_rpt();
                reporte.RequestParameters = false;
                reporte.lstIdSolicitud = lstIdSolicitudCompra;

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
                lstIdSolicitudCompra = new List<XCOMP_Rpt005_Info>();
                if (BindList_DetSolCom.Count > 0)
                {
                    foreach (var item in BindList_DetSolCom)
                    {
                        if (item.Checked == true)
                        {
                            XCOMP_Rpt005_Info infoRpt = new XCOMP_Rpt005_Info();

                            infoRpt.IdEmpresa = item.IdEmpresa;
                            infoRpt.IdSucursal = item.IdSucursal;
                            infoRpt.IdSolicitudCompra = item.IdSolicitudCompra;
                            infoRpt.Secuencia_SC = item.Secuencia;

                            lstIdSolicitudCompra.Add(infoRpt);
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


        void ucGe_Menu_Superior_Mant_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void ucGe_Menu_Superior_Mant_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardar())
               {
                   Close();
               
               }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void ucGe_Menu_Superior_Mant_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                guardar();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        List<com_solicitud_compra_det_pre_aprobacion_Info> lista_DetPreAproba = new List<com_solicitud_compra_det_pre_aprobacion_Info>();

        void get_Det_Pre_Aprobacion()
        {

            try
            {
                if (BindList_DetSolCom.Count >0)
                {

                    foreach (var item in BindList_DetSolCom)
                    {
                        if(item.Checked==true)
                        {
                            com_solicitud_compra_det_pre_aprobacion_Info info = new com_solicitud_compra_det_pre_aprobacion_Info();


                                info.IdEmpresa =item.IdEmpresa;   
                                info.IdSucursal_SC=item.IdSucursal;
                                info.IdSolicitudCompra = item.IdSolicitudCompra;
                                info.Secuencia_SC =item.Secuencia;                                                             
                                info.IdEstadoAprobacion =item.IdEstadoPreAprobacion;                  
                                info.IdUsuarioAprueba =param.IdUsuario; 
                                info.do_observacion = item.do_observacion;
                                info.FechaHoraAprobacion = DateTime.Now;
                                info.Cantidad_aprobada = item.cant_ing_SolCom;


                                lista_DetPreAproba.Add(info);                                          
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

        void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
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


        void carga_grilla()
        {
            try
            {
                string mensaje = "";
                listSolicitudxItems = new List<vwcom_solicitud_compra_x_items_con_saldos_Info>();
                bus_solicitudxItems = new vwcom_solicitud_compra_x_items_con_saldos_Bus();
                listSolicitudxItems = bus_solicitudxItems.Get_List_SoliComxItemSaldos(param.IdEmpresa, dtpFecha_desde.Value, dtpFecha_Hasta.Value, Convert.ToString(cmbEstadoAprobacion.EditValue), Convert.ToString(cmbEstadoPreAprobacion.EditValue), ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal, 0);

                if (listSolicitudxItems.Count > 0)
                {
                    BindList_DetSolCom = new BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info>(listSolicitudxItems);
                    gridControlSolicitud_det_pre_Aprobacion.DataSource = BindList_DetSolCom;

                }
                else
                {
                    BindList_DetSolCom = new BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info>();
                    gridControlSolicitud_det_pre_Aprobacion.DataSource = BindList_DetSolCom;
                
                }
                
             
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        
        
        }
               
        private void cargar_combos()
        {

            try
            {
                ucGe_Sucursal_combo1.cargar_comboTodos();
                ucGe_Sucursal_combo1.set_SucursalInfo(0);

                ParamInfo = ParamBus.Get_Info_parametro(param.IdEmpresa);

                List<com_Catalogo_Info> listEstadoAprob = new List<com_Catalogo_Info>();
                listEstadoAprob = com_cataBus.Get_ListEstadoAprobacion_solicitud_compra();

                com_Catalogo_Info InfoEstaAprob= new com_Catalogo_Info();
                InfoEstaAprob.IdCatalogocompra_tipo = "EST_APRO_SOL";
                InfoEstaAprob.IdCatalogocompra = "TODOS";
                InfoEstaAprob.descripcion = "TODOS";

                listEstadoAprob.Add(InfoEstaAprob);

                // carga combo Punto de cargo en el grid
                ct_punto_cargo_Bus bus_puntocargo = new ct_punto_cargo_Bus();
                List<ct_punto_cargo_Info>  listpuntoCargo = new List<ct_punto_cargo_Info>();
                listpuntoCargo = bus_puntocargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmbIdPunto_cargo_grid.DataSource = listpuntoCargo;

                cp_proveedor_Bus bus_proveedor = new cp_proveedor_Bus();
                List<cp_proveedor_Info> listProveedor = new List<cp_proveedor_Info>();
                listProveedor = bus_proveedor.Get_List_proveedor(param.IdEmpresa);
                cmbProveedor_grid.DataSource = listProveedor;

                cmbEstadoAprobacion.Properties.DataSource = listEstadoAprob;
                cmbEstadoAprobacion.EditValue = "TODOS";

                cmbEstadoPreAprobacion.Properties.DataSource = listEstadoAprob;
                cmbEstadoPreAprobacion.EditValue = "PEN_SOL";

                ucGe_Sucursal_combo1.set_SucursalInfo(param.IdSucursal);

                listEstadoAprobacion = listEstadoAprob.FindAll(q => q.IdCatalogocompra != "PEN_SOL");
                
                cmb_Estado_Aprobacion_grid.DataSource = listEstadoAprobacion;
                cmb_Estado_Aprobacion_grid.DisplayMember = "descripcion";
                cmb_Estado_Aprobacion_grid.ValueMember = "IdCatalogocompra";


                


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }


        private Boolean guardar()
        {
            try
            {
                get_Det_Pre_Aprobacion();

                com_solicitud_compra_det_pre_aprobacion_Bus bus = new com_solicitud_compra_det_pre_aprobacion_Bus();

                if (lista_DetPreAproba.Count >0)
                {
                    if (bus.GuardarDB(lista_DetPreAproba))
                    {
                        MessageBox.Show("Actualización de Estado de Aprobacion ok...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("¿Desea Imprimir el Soporte?" + "\n" + "Imprimir", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ucGe_Menu_Superior_Mant_event_btnImprimir_Click(null, null);
                        }
                        LimpiarDatos();
                    }                  
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


        void LimpiarDatos()
        {
            try
            {
                lista_DetPreAproba = new List<com_solicitud_compra_det_pre_aprobacion_Info>();                
                BindList_DetSolCom = new BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info>();
                gridControlSolicitud_det_pre_Aprobacion.DataSource = BindList_DetSolCom;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }


        private void FrmCom_SolicitudCompra_det_pre_Aprobacion_Load(object sender, EventArgs e)
        {
            try
            {
                BindList_DetSolCom = new BindingList<vwcom_solicitud_compra_x_items_con_saldos_Info>();
                gridControlSolicitud_det_pre_Aprobacion.DataSource = BindList_DetSolCom;

                dtpFecha_Hasta.Value = param.Fecha_Transac;
                dtpFecha_desde.Value = Convert.ToDateTime(dtpFecha_Hasta.Value).AddDays(-30);

                cargar_combos();
                carga_grilla();
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
                carga_grilla();
            }
            catch (Exception ex)
            {               
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void gridViewSolicitud_det_pre_Aprobacion_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                vwcom_solicitud_compra_x_items_con_saldos_Info row = new vwcom_solicitud_compra_x_items_con_saldos_Info();
                row = (vwcom_solicitud_compra_x_items_con_saldos_Info)gridViewSolicitud_det_pre_Aprobacion.GetRow(e.RowHandle);


                if (e.HitInfo.Column != null)
                {
                    e.HitInfo.Column.FieldName = gridViewSolicitud_det_pre_Aprobacion.FocusedColumn.FieldName;

                    if (e.HitInfo.Column.FieldName == "Checked")
                    {
                        if ((Boolean)gridViewSolicitud_det_pre_Aprobacion.GetFocusedRowCellValue(colChecked)) //verdadero
                        {
                            gridViewSolicitud_det_pre_Aprobacion.SetFocusedRowCellValue(colChecked, false);
                            gridViewSolicitud_det_pre_Aprobacion.SetFocusedRowCellValue(colIdEstadoAprobacion, row.IdEstadoAprobacion_AUX);

                            return;
                        }
                        else //false
                        {
                            gridViewSolicitud_det_pre_Aprobacion.SetFocusedRowCellValue(colChecked, true);
                            gridViewSolicitud_det_pre_Aprobacion.SetFocusedRowCellValue(colIdEstadoAprobacion, "APR_SOL");
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

        private void gridViewSolicitud_det_pre_Aprobacion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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

       
    }
}
