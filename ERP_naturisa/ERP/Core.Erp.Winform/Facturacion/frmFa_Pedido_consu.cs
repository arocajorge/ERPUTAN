using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;


namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Pedido_consu : Form
    {
        int fila = -1;
        fa_pedido_Info info = new fa_pedido_Info();
        frmFa_Pedido_Mant frm = new frmFa_Pedido_Mant();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<fa_pedido_Info> lista_pedido = new List<fa_pedido_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_pedido_Bus bus_pers = new fa_pedido_Bus();
        fa_pedido_det_Bus pedido_det_bus = new fa_pedido_det_Bus();
        tb_Bodega_Info info_bodega = new tb_Bodega_Info();
        tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();

        public frmFa_Pedido_consu()
        {
            try
            {
                InitializeComponent();
                frm.Event_frmFA_Pedido_Mant_FormClosing += new frmFa_Pedido_Mant.delegate_frmFA_Pedido_Mant_FormClosing(frm_Event_frmFA_Pedido_Mant_FormClosing);

                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;

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
                Close();
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

                this.gridControlPedido.ShowPrintPreview();
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
                frm = new frmFa_Pedido_Mant();
                frm.Accion = Cl_Enumeradores.eTipo_action.Anular;
                info.lista_detalle = pedido_det_bus.Get_List_pedido_det(param.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdPedido);
                frm.obj = info;
                frm.ShowDialog();
                gridControlPedido.Refresh();
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
                frm = new frmFa_Pedido_Mant(info.IdSucursal, info.IdBodega);
                frm.Event_frmFA_Pedido_Mant_FormClosing += new frmFa_Pedido_Mant.delegate_frmFA_Pedido_Mant_FormClosing(frm_Event_frmFA_Pedido_Mant_FormClosing);
                info.lista_detalle = pedido_det_bus.Get_List_pedido_det(param.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdPedido);

                frm.obj = info;
                frm.Accion = Cl_Enumeradores.eTipo_action.consultar;
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
                CargaGrid(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
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

                tb_Sucursal_Info InfoSu = new tb_Sucursal_Info();
                tb_Bodega_Info InfoBo = new tb_Bodega_Info();

                InfoSu = ucGe_Menu_Mantenimiento_x_usuario.getSucursal_Info;
                InfoBo = ucGe_Menu_Mantenimiento_x_usuario.getBodega_Info;

                frm = new frmFa_Pedido_Mant(InfoSu.IdSucursal, 1);

                frm.Event_frmFA_Pedido_Mant_FormClosing += new frmFa_Pedido_Mant.delegate_frmFA_Pedido_Mant_FormClosing(frm_Event_frmFA_Pedido_Mant_FormClosing);
                info.lista_detalle = pedido_det_bus.Get_List_pedido_det(param.IdEmpresa, InfoSu.IdSucursal, InfoBo.IdBodega, info.IdPedido);
                frm.obj = info;

                if (info.Estado == "I")
                { frm.Accion = Cl_Enumeradores.eTipo_action.consultar; }
                else
                { frm.Accion = Cl_Enumeradores.eTipo_action.actualizar; }

                frm.MdiParent = this.MdiParent;
                frm.Show();
               
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
                info = new fa_pedido_Info();
                
                info_sucursal = new tb_Sucursal_Info();
                info_sucursal = ucGe_Menu_Mantenimiento_x_usuario.getSucursal_Info;

                info_bodega = new tb_Bodega_Info();
                info_bodega = ucGe_Menu_Mantenimiento_x_usuario.getBodega_Info;

                info.IdSucursal = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                info.IdBodega = 1;// ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
              
                frm = new frmFa_Pedido_Mant();
                frm.Event_frmFA_Pedido_Mant_FormClosing += new frmFa_Pedido_Mant.delegate_frmFA_Pedido_Mant_FormClosing(frm_Event_frmFA_Pedido_Mant_FormClosing);
                frm.idsucursal = info.IdSucursal;
                frm.idbodega = info.IdBodega;

                frm.Accion = Cl_Enumeradores.eTipo_action.grabar;
                frm.MdiParent = this.MdiParent;
                frm.Show();
                CargaGrid(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

             
        void frm_Event_frmFA_Pedido_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {             
                CargaGrid(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }


        public void vaciar_grid()
        {
            try
            {
                List<fa_pedido_Info> lm = new List<fa_pedido_Info>();           
                gridControlPedido.DataSource = lm;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

          
        private void CargaGrid(int idempresa, DateTime fecha_ini, DateTime fecha_fin)
        {
            try
            {
                info_sucursal = ucGe_Menu_Mantenimiento_x_usuario.getSucursal_Info;
                info_bodega = ucGe_Menu_Mantenimiento_x_usuario.getBodega_Info;
                lista_pedido = new List<fa_pedido_Info>();
             
                gridControlPedido.Refresh();

                lista_pedido = bus_pers.Get_List_pedido(idempresa, fecha_ini, fecha_fin
                    , info_sucursal.IdSucursal, info_bodega.IdBodega); 
               
                //var sele = from q in lista_pedido
                //           orderby q.IdPedido descending
                //           select q;

               // gridControlPedido.DataSource = (List<fa_pedido_Info>)sele.ToList();
                bindingSource1.DataSource = lista_pedido;
                //(List<fa_pedido_Info>)sele.ToList();
                gridControlPedido.DataSource = lista_pedido;
                //bindingSource1;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        
        private void frmFA_Pedido_General_Load(object sender, EventArgs e)
        {
            try
            {
                CargaGrid(param.IdEmpresa, DateTime.Now.AddMonths(-1), DateTime.Now.AddMonths(1));          
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private fa_pedido_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {

            try
            {
                return (fa_pedido_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new fa_pedido_Info();
            }
        }
        
        private List<fa_pedido_valor_Info> obtener_valores_pedido(decimal idpedido)
        {
            List<fa_pedido_valor_Info> lm = new List<fa_pedido_valor_Info>();
            try
            {
              //  lm = pedido_total_bus.ObtenerPedido(param.IdEmpresa, info.IdSucursal, info.IdBodega, idpedido);
                return lm;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<fa_pedido_valor_Info>();
            }
        }


        private void gridViewPedidos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
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

        private void gridViewPedidos_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewPedidos.GetRow(e.RowHandle) as fa_pedido_Info;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                frm = new frmFa_Pedido_Mant();
                frm.Event_frmFA_Pedido_Mant_FormClosing += new frmFa_Pedido_Mant.delegate_frmFA_Pedido_Mant_FormClosing(frm_Event_frmFA_Pedido_Mant_FormClosing);
                frm.Accion = Cl_Enumeradores.eTipo_action.Anular;
                frm.obj = info;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                gridControlPedido.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void dtpFechaIni_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (dtpFechaIni.Value > dtpFechaFin.Value)
                //{
                //    MessageBox.Show("La Fecha Inicial no puede ser mayor a la final");
                //    return;
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (dtpFechaIni.Value > dtpFechaFin.Value)
                //{
                //    MessageBox.Show("La Fecha Inicial no puede ser mayor a la final");
                //    return;
                //}
            }   
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

       
        

    }
}
