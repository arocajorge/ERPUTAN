using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Orden_Despacho_cons : Form
    {
        public frmFa_Orden_Despacho_cons()
        {
            try
            {
                 InitializeComponent();
                frm.Event_frmFA_OrdenDespacho_Mant_FormClosing += new frmFa_Orden_Despacho_Mant.Delegate_frmFA_OrdenDespacho_Mant_FormClosing(frm_Event_frmFA_OrdenDespacho_Mant_FormClosing);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;

                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewOrdenDespacho.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                frm = new frmFa_Orden_Despacho_Mant();
                frm.Event_frmFA_OrdenDespacho_Mant_FormClosing += new frmFa_Orden_Despacho_Mant.Delegate_frmFA_OrdenDespacho_Mant_FormClosing(frm_Event_frmFA_OrdenDespacho_Mant_FormClosing);
                frm.SetInfo = info;
                frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);

                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmFa_Orden_Despacho_Mant();
                frm.Event_frmFA_OrdenDespacho_Mant_FormClosing += new frmFa_Orden_Despacho_Mant.Delegate_frmFA_OrdenDespacho_Mant_FormClosing(frm_Event_frmFA_OrdenDespacho_Mant_FormClosing);
                frm.SetInfo = info;
                frm.setAccion(Cl_Enumeradores.eTipo_action.consultar);

                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmFa_Orden_Despacho_Mant();
                frm.Event_frmFA_OrdenDespacho_Mant_FormClosing += new frmFa_Orden_Despacho_Mant.Delegate_frmFA_OrdenDespacho_Mant_FormClosing(frm_Event_frmFA_OrdenDespacho_Mant_FormClosing);
                frm.SetInfo = info;
                frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);

                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmFa_Orden_Despacho_Mant();
                frm.Event_frmFA_OrdenDespacho_Mant_FormClosing += new frmFa_Orden_Despacho_Mant.Delegate_frmFA_OrdenDespacho_Mant_FormClosing(frm_Event_frmFA_OrdenDespacho_Mant_FormClosing);
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frm_Event_frmFA_OrdenDespacho_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        frmFa_Orden_Despacho_Mant frm = new frmFa_Orden_Despacho_Mant();
        #region Declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCIn_Sucursal_Bodega ctrl_SucBod = new UCIn_Sucursal_Bodega();
        tb_Sucursal_Info _SucursalInfo = new tb_Sucursal_Info();
        tb_Bodega_Info _BodegaInfo = new tb_Bodega_Info();
        List<fa_orden_Desp_Info> lst = new List<fa_orden_Desp_Info>();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_orden_Desp_Bus oBus = new fa_orden_Desp_Bus();
        fa_orden_Desp_Info info = new fa_orden_Desp_Info();
        #endregion
        #region Eventos
        private void frmFA_Orden_Despacho_Load(object sender, EventArgs e)
        {
            try
            {
                //    dtpFechaIni.Value = dtpFechaFin.Value.AddDays(-30);
                // pnlBodegaSucrusal.Dock = DockStyle.Fill;
                //ctrl_SucBod.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                //pnlBodegaSucrusal.Controls.Add(ctrl_SucBod);
            CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }

        }

         
        private void gridViewOrdenDespacho_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                 info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }

        private void gridViewOrdenDespacho_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewOrdenDespacho.GetRow(e.RowHandle) as fa_orden_Desp_Info;
            if (data == null)
                return;

            if (data.Estado == "I")
                e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }
        #endregion
        #region Funciones

        public void CargarGrid()
        {

            try
            {
            //     _BodegaInfo = ctrl_SucBod.get_bodega();
            //_SucursalInfo = ctrl_SucBod.get_sucursal();
         


            //lst = oBus.getlist_OrdenDespachi(param.IdEmpresa
            //    , _SucursalInfo.IdSucursal, _SucursalInfo.IdSucursal
            //    , _BodegaInfo.IdBodega, _BodegaInfo.IdBodega
            //    , Convert.ToDateTime(dtpFechaIni.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaFin.Value.ToShortDateString()));
                lst = oBus.Get_List_orden_Desp(param.IdEmpresa
                                            , ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal, ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal
                                            ,ucGe_Menu_Mantenimiento_x_usuario.getIdBodega, ucGe_Menu_Mantenimiento_x_usuario.getIdBodega
                                            , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde,ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);

            lst.ForEach(var =>
            {
                if (var.od_DespAbierto == "S")
                {
                    var.od_DespAbierto = "Desp. Abierto";
                }
                else
                {
                    var.od_DespAbierto = "Desp. Con Pedido";
                }
            });

                var sele = from q in lst
                       orderby q.IdOrdenDespacho descending
                       select q;
            ultrOrdenDespacho1.DataSource = sele.ToList();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }


        }
        private fa_orden_Desp_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {

            try
            {
                return (fa_orden_Desp_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new fa_orden_Desp_Info();
            }
        }

        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {//imprimir
            //XRpt_fa_orden_despacho xprt = new XRpt_fa_orden_despacho();


            //fa_rpt_orden_Desp_Info lODes = new fa_rpt_orden_Desp_Info();


           
            //    fa_rpt_orden_Desp_Info info = new fa_rpt_orden_Desp_Info();
                
            //    lODes = oBus.rpt_orde_Despacho(param.IdEmpresa, _SucursalInfo.IdSucursal, _SucursalInfo.IdSucursal, _BodegaInfo.IdBodega, _BodegaInfo.IdBodega, dtpFechaIni.Value, dtpFechaFin.Value);


            //    lODes.empresainfo.em_logo = param.EmpresaInfo.em_logo;
            //    lODes.empresainfo.em_direccion = param.EmpresaInfo.em_direccion;

            //    lODes.empresainfo.em_telefonos = param.EmpresaInfo.em_telefonos;
            //    List<fa_rpt_orden_Desp_Info> LstODes = new List<fa_rpt_orden_Desp_Info>();
            //   // lODes.idUsuario = param.IdUsuario;    
            //LstODes.Add(lODes);


              
          

           
        //    xprt.loadData(LstODes.ToArray());
        //    xprt.ShowPreviewDialog();
        //
        }

       





      

    }
}
