using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Inventario;




namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Ingreso_x_Orden_compra_cons : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        vwIn_Movi_Inven_x_Ing_x_OC_Bus OMoviIngBus = new vwIn_Movi_Inven_x_Ing_x_OC_Bus();
        List<vwIn_Movi_Inven_x_Ing_x_OC_Info> OMoviIng_list = new List<vwIn_Movi_Inven_x_Ing_x_OC_Info>();
        vwIn_Movi_Inven_x_Ing_x_OC_Info MoviInven_Ing_Info = new vwIn_Movi_Inven_x_Ing_x_OC_Info();



        FrmIn_Ingreso_x_Orden_compra_Mant  frm = new FrmIn_Ingreso_x_Orden_compra_Mant();



        public FrmIn_Ingreso_x_Orden_compra_cons()
        {
            

            try
            {
                InitializeComponent();

                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

                cargar_grid();

            }
            catch (Exception ex)
            {
                
                
            }

            
        }

        #region Eventos Click Botones

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

                        frm = new FrmIn_Ingreso_x_Orden_compra_Mant();
                        frm.Event_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing += frm_Event_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing;
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                        frm.MdiParent = this.MdiParent;
                        frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                        frm.Show();

                    }
                    catch (Exception ex)
                    {

                        Log_Error_bus.Log_Error(ex.ToString());
                    }

            
                }

                void frm_Event_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing(object sender, FormClosingEventArgs e)
                {
                    try
                    {
                        cargar_grid();
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
                        if (MoviInven_Ing_Info.IdNumMovi==0)
                        {
                            MessageBox.Show("Seleccione una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (MoviInven_Ing_Info.Estado == "I")
                            {
                                MessageBox.Show("No se pueden modificar registros inactivos", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                frm = new FrmIn_Ingreso_x_Orden_compra_Mant();


                                frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                                frm.set_Info(MoviInven_Ing_Info);
                                frm.Event_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing += frm_Event_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing;
                                frm.MdiParent=this.MdiParent;
                                frm.Text = frm.Text + " ***MODIFICAR REGISTRO***";
                                frm.Show();
                            }
                        }
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
                        this.gridView_Movi_Inven_Ing.ShowPrintPreview();
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

                        frm = new FrmIn_Ingreso_x_Orden_compra_Mant();
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                        frm.set_Info(MoviInven_Ing_Info);
                        frm.Event_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing += frm_Event_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing;
                        frm.MdiParent = this.MdiParent;
                        frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                        frm.Show();
                        //CargarGrid();
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
                        frm = new FrmIn_Ingreso_x_Orden_compra_Mant();
                        frm.set_Info(MoviInven_Ing_Info);
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.borrar);
                        frm.Event_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing += frm_Event_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing;
                        frm.Text = frm.Text + " ***ANULAR REGISTRO***";
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
                        cargar_grid();

                    }
                    catch (Exception ex)
                    {

                        Log_Error_bus.Log_Error(ex.ToString());
                    }
            
                }

        #endregion



                private void cargar_grid()
                {
                    try
                    {

                        OMoviIng_list = OMoviIngBus.Obtener_datos_list(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal, ucGe_Menu_Mantenimiento_x_usuario.getIdBodega,
                            ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);


                        gridControl_movi_inv_ing.DataSource = OMoviIng_list;


                    }
                    catch (Exception ex)
                    {

                        Log_Error_bus.Log_Error(ex.ToString());
                    }
                }

        private void FrmIn_Ingreso_x_Orden_compra_cons_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void gridView_Movi_Inven_Ing_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_Movi_Inven_Ing.GetRow(e.RowHandle) as vwIn_Movi_Inven_x_Ing_x_OC_Info;
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

        private void gridView_Movi_Inven_Ing_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {

                MoviInven_Ing_Info = (vwIn_Movi_Inven_x_Ing_x_OC_Info)gridView_Movi_Inven_Ing.GetRow(gridView_Movi_Inven_Ing.FocusedRowHandle);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }
    }
}
