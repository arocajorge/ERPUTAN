using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_Liquidacion_Import_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public frmImp_Liquidacion_Import_Consulta()
        {
            try
            {
                  InitializeComponent();
                  ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                  ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
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
                CargarGrid();
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
                imp_ordencompra_ext_Info importacion = (imp_ordencompra_ext_Info)gridViewPedidos.GetFocusedRow();
                frmImp_Liquidacion_Import_Mant ofrm = new frmImp_Liquidacion_Import_Mant();
                ofrm.MdiParent = this.MdiParent;
                ofrm.btnLiquidar.Enabled = false;
                ofrm.btnAnular.Enabled = false;
                ofrm.Obj = importacion;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                imp_ordencompra_ext_Info importacion = (imp_ordencompra_ext_Info)gridViewPedidos.GetFocusedRow();
                frmImp_Liquidacion_Import_Mant ofrm = new frmImp_Liquidacion_Import_Mant();
                ofrm.MdiParent = this.MdiParent;
                ofrm.Obj = importacion;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        imp_ordencompra_ext_Bus bus = new imp_ordencompra_ext_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        private void frmImp_Liquidacion_Importacion_Load(object sender, EventArgs e)
        {
            try
            {
                
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public void CargarGrid()
        {
            try
            {
                var data = bus.Get_List_ordencompra_ext(param.IdEmpresa
                    ,ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);//.FindAll(var => var.Estado =="A");
                //data.FindAll(var => var.Tipo_Importacion == "IMPORTACION");
                data.ForEach
                (var =>
                {
                    if (var.IdEstadoLiquidacion == "XLQDAR")
                    { var.IdEstadoLiquidacion = "Por Liquidar"; }
                    else
                    { var.IdEstadoLiquidacion = "Liquidado"; }
                });
                gridControlOrdeCompra.DataSource = data.ToList().FindAll(var => var.Estado == "A" && var.Tipo_Importacion == "IMPORTACION");

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }



        private void gridViewPedidos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewPedidos.RowCount; i++)
                {
                    if ((Boolean)gridViewPedidos.GetRowCellValue(i, Chek))
                    {
                        gridViewPedidos.SetRowCellValue(i, Chek, false);
                    }
                }

                gridViewPedidos.SetFocusedRowCellValue(Chek, true);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmImp_ordencompra_ext_Consulta ofr = new frmImp_ordencompra_ext_Consulta();
                ofr.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                frmImp_GastosImportacion_Consulta ofr = new frmImp_GastosImportacion_Consulta();
                ofr.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


        }


    }
}
