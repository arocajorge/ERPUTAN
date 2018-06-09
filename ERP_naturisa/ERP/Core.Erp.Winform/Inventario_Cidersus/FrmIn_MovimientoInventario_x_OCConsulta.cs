using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.CuentasxPagar;
using DevExpress.XtraPrinting;

///version: 26-06-2013 16:50

namespace Core.Erp.Winform.Inventario_Cidersus
{
    public partial class FrmIn_MovimientoInventario_x_OCConsulta : Form
    {
        public FrmIn_MovimientoInventario_x_OCConsulta()
        {
            try
            {
             InitializeComponent();
             ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
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
                cargarData();
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
                if (Info == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmIn_MovimientoInventario_x_OCMantenimiento frm = new FrmIn_MovimientoInventario_x_OCMantenimiento();
                    frm.set_Action(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show(); frm.setcab(Info);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info != null)
                {
                    if (Info.Estado == "I")
                        MessageBox.Show("La Lista de Materiales # " + Info.IdNumMovi + " ya fue anulada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {

                        if (Info == null)
                            MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                        {
                            FrmIn_MovimientoInventario_x_OCMantenimiento frm = new FrmIn_MovimientoInventario_x_OCMantenimiento();
                            frm.set_Action(Cl_Enumeradores.eTipo_action.Anular);
                            frm.Text = frm.Text + " ***ANULAR REGISTRO***";
                            frm.Show(); frm.setcab(Info);
                            frm.Event_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing += new FrmIn_MovimientoInventario_x_OCMantenimiento.Delegate_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing(frm_Event_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //gridControlObra.ShowPrintPreview();
                string leftColumn = "Fecha: [Date Printed][Time Printed]";
                string middleColumn = "Página:[Page # of Pages #]";
                string rightColumn = "Usuario:" + param.IdUsuario;

                // Create a PageHeaderFooter object and initializing it with
                // the link's PageHeaderFooter.

                PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;

                // Clear the PageHeaderFooter's contents.
                phf.Header.Content.Clear();
                phf.Footer.Content.Clear();
                Font fte = new System.Drawing.Font("Tahoma", 8.5f, FontStyle.Bold, GraphicsUnit.Point);

                // Add custom information to the link's header.
                phf.Header.Font = fte;
                phf.Footer.Font = fte;
                phf.Header.Content.AddRange(new string[] { leftColumn, "", rightColumn, "hola" });
                phf.Header.LineAlignment = BrickAlignment.Center;
                phf.Footer.Content.AddRange(new string[] { "", "", middleColumn });
                phf.Footer.LineAlignment = BrickAlignment.Center;
                //printableComponentLink1.Component = null;
                printableComponentLink1.Component = gridCtrlListRepcMat;

                printableComponentLink1.ShowPreview();
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmIn_MovimientoInventario_x_OCMantenimiento frm = new FrmIn_MovimientoInventario_x_OCMantenimiento();
                frm.set_Action(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.Event_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing += new FrmIn_MovimientoInventario_x_OCMantenimiento.Delegate_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing(frm_Event_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());

            }
        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<in_movi_inve_Info> LstInfo = new List<in_movi_inve_Info>();
        in_movi_inve_Bus BusInfo = new in_movi_inve_Bus();
        cp_proveedor_Bus BusProv = new cp_proveedor_Bus();
        UCIn_Sucursal_Bodega UCSucu = new UCIn_Sucursal_Bodega();
        tb_Sucursal_Info _sucuI = new tb_Sucursal_Info();
        tb_Bodega_Info _bodegaI = new tb_Bodega_Info();
        //int idSucuIni = 0;
        //int idSucuFin = 0;
        //int idBodegaIni = 0;
        //int idBodegaFin = 0;
       
        //DateTime fechaIni;
        //DateTime fechaFin;

        private void cargarData()
        {

            try
            {
                //_sucuI = UCSucu.get_sucursal();

                //idSucuIni = _sucuI.IdSucursal;
                //idSucuFin = _sucuI.IdSucursal;

                //_bodegaI = UCSucu.get_bodega();
                //idBodegaIni = _bodegaI.IdBodega;
                //idBodegaFin = idBodegaIni;
                //fechaIni = dtpDesde.Value;
                //fechaFin = dtpHasta.Value;
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }        
        void cargagrid()
        {
            try
            {
           //  LstInfo = BusInfo.Obtener_list_Movi_inven_Recepcion(param.IdEmpresa,idSucuIni,idSucuFin,idBodegaIni,idBodegaFin,fechaIni,fechaFin);
                //LstInfo.ForEach(var => var.prov_nombre = BusProv.ObtenerProveedor(param.IdEmpresa, Convert.ToDecimal(var.IdProvedor)).pr_nombre);
                LstInfo = BusInfo.Get_list_Movi_inven_Recepcion(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal, ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdBodega, ucGe_Menu_Mantenimiento_x_usuario.getIdBodega
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde,ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);

                if (LstInfo != null)
                {
                    foreach (var item in LstInfo)
                    {
                        var prov = BusProv.Get_Info_Proveedor(param.IdEmpresa, Convert.ToDecimal(item.IdProvedor));
                        if (prov != null)
                        {
                            item.prov_nombre = prov.pr_nombre;
                        }
                    }
                    gridCtrlListRepcMat.DataSource = LstInfo;
                    gridViewRepcMat.FocusedRowHandle = 0;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }
        void frm_Event_FrmIn_MovientoInventario_x_OCMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  cargarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        in_movi_inve_Info Info = new in_movi_inve_Info();

        private void gridViewRepcMat_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = (in_movi_inve_Info)gridViewRepcMat.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void gridViewRepcMat_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewRepcMat.GetRow(e.RowHandle) as in_movi_inve_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        
        private void FrmIn_MovimientoInventario_x_OCConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                //panelSucursal.Controls.Add(UCSucu);
                //UCSucu.Dock = DockStyle.Fill;
                //dtpHasta.Value = dtpHasta.Value.AddDays(1);
                //dtpDesde.Value = dtpDesde.Value.AddDays(-60);
                cargarData();
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
