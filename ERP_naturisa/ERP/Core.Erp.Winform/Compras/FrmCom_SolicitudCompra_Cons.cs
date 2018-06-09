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
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_SolicitudCompra_Cons : Form
    {
        #region Declración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        com_solicitud_compra_Bus Bus_SoliciCompra = new com_solicitud_compra_Bus();
        com_solicitud_compra_det_aprobacion_Bus bus_DetSoliApro = new com_solicitud_compra_det_aprobacion_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_solicitud_compra_Info Info = new com_solicitud_compra_Info();
        FrmCom_SolicitudCompra_Mant frm = new FrmCom_SolicitudCompra_Mant();
        com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_Solicitud = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
        List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listSolicitud = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
        List<com_solicitud_compra_det_aprobacion_Info> listDetSoliApro = new List<com_solicitud_compra_det_aprobacion_Info>();
        //Variables
        int idEmpresa = 0;
        int idSucursal = 0;
        decimal idSoliComp = 0;
        int IdSucursal = 0;

        #endregion
                
        public FrmCom_SolicitudCompra_Cons()
        {
            try
            {
                InitializeComponent();

                ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click;

                ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }                      
        }
               
        Boolean Verifica_Estado()
        {
            try
            {                            
                listDetSoliApro = bus_DetSoliApro.Get_List_solicitud_compra_det_aprobacion(idEmpresa, idSucursal, idSoliComp);

                if (listDetSoliApro.Count()!=0)
                {
                    int conta = listDetSoliApro.Count(q => q.IdEstadoAprobacion == "APR_SOL");

                    if (conta>0)
                    {
                        MessageBox.Show("La solicitud #: [" + Info.IdSolicitudCompra + "], ya ha sido aprobada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
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

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               Info = (com_solicitud_compra_Info)gridViewConsulta.GetFocusedRow();
                if (Info != null)
                {
                   if (Info.Estado=="I")
                   { MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                   else
                   {
                       listSolicitud = bus_Solicitud.ConsultaDetalleSolicitud_x_Solicitud(Info.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra);

                       if (listSolicitud.Count() != 0)
                       {
                           MessageBox.Show("La solicitud #: [" + Info.IdSolicitudCompra + "], tiene asociada una Orden de Compra ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                       }
                                             
                          idEmpresa = Info.IdEmpresa;
                          idSucursal = Info.IdSucursal;
                          idSoliComp = Info.IdSolicitudCompra;

                       if (Verifica_Estado())
                       {
                           frm = new FrmCom_SolicitudCompra_Mant(Cl_Enumeradores.eTipo_action.Anular);
                           frm.Text = frm.Text + "***ANULAR REGISTRO***";
                           frm.MdiParent = this.MdiParent;
                           frm._SetInfo = Info;
                           frm.Show();
                           frm.event_FrmCom_SolicitudCompraMantenimiento_FormClosing += frm_event_FrmCom_SolicitudCompraMantenimiento_FormClosing;
                        }
                   }                                      
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {               
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void cargagrid()
        {
            try
            {
                List<com_solicitud_compra_Info> LstOC = new List<com_solicitud_compra_Info>();
                LstOC = Bus_SoliciCompra.Get_List_solicitud_compra(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal, ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta);

                gridControlConsulta.DataSource = LstOC;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        
        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IdSucursal = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (com_solicitud_compra_Info)gridViewConsulta.GetFocusedRow();
                if (Info != null)
                {
                    frm = new FrmCom_SolicitudCompra_Mant(Cl_Enumeradores.eTipo_action.consultar);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm._SetInfo = Info;
                    frm.Show();
                    frm.event_FrmCom_SolicitudCompraMantenimiento_FormClosing += frm_event_FrmCom_SolicitudCompraMantenimiento_FormClosing;
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (com_solicitud_compra_Info)gridViewConsulta.GetFocusedRow();
                if (Info != null)
                {
                                                                                                      
                       listSolicitud = bus_Solicitud.ConsultaDetalleSolicitud_x_Solicitud(Info.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra);

                       if (listSolicitud.Count() != 0)
                       {
                           MessageBox.Show("La solicitud #: [" + Info.IdSolicitudCompra + "], tiene asociadas Ordenes de Compra ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                       }
                  
                       idEmpresa = Info.IdEmpresa;
                       idSucursal = Info.IdSucursal;
                       idSoliComp = Info.IdSolicitudCompra;

                       if (Verifica_Estado())
                       {
                           llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                           
                       }                 
                                                       
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                llama_frm(Cl_Enumeradores.eTipo_action.grabar);

                
                
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void frm_event_FrmCom_SolicitudCompraMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                IdSucursal = 0;
                cargagrid();
                ucGe_Menu_Mantenimiento_x_usuario1.carga_Sucursal_Todas();
              
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void gridViewConsulta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewConsulta.GetRow(e.RowHandle) as com_solicitud_compra_Info;
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

        private void gridViewConsulta_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = (com_solicitud_compra_Info)gridViewConsulta.GetFocusedRow();


                if (e.HitInfo.Column != null)
                {
                    if (gridViewConsulta.FocusedColumn.Name == ColOrdenesCompra.Name )
                    {
                        com_ordencompra_local_Bus BusOC = new com_ordencompra_local_Bus();
                        List<com_ordencompra_local_Info> listOc = new List<com_ordencompra_local_Info>();
                        listOc=BusOC.Get_List_ordencompra_local_x_Solicitud(param.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra);
                        FrmCom_Ordenes_Compra_x_Solicitud frm = new FrmCom_Ordenes_Compra_x_Solicitud();
                        frm.set_grid_x_oc(listOc);
                        //frm.MdiParent = this.MdiParent;
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void FrmCom_SolicitudCompraConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                IdSucursal = param.IdSucursal;                            
                cargagrid();
                ucGe_Menu_Mantenimiento_x_usuario1.carga_Sucursal_Todas();
            }
            catch (Exception ex)
            {              
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_Load(object sender, EventArgs e)
        {

        }

      
        
        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new FrmCom_SolicitudCompra_Mant(Accion);
                frm.MdiParent = this.MdiParent;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        frm.Text = "***NUEVO REGISTRO**";
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        frm.Text = "***NUEVO MODIFICAR**";
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        frm.Text = "***CONSULTAR**";
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        frm.Text = "***ELIMINAR**";
                        break;
                }

                
                frm.event_FrmCom_SolicitudCompraMantenimiento_FormClosing +=frm_event_FrmCom_SolicitudCompraMantenimiento_FormClosing;
                frm._SetInfo = Info;
                frm.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
    }
}
