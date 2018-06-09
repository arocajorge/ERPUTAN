using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Compras_Edehsa;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using DevExpress.XtraPrinting;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Info.Produc_Cirdesus;

namespace Core.Erp.Winform.Produccion_Edehsa
{
    public partial class FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraConsulta : Form
    {
        public FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraConsulta()
        {
            try
            {
                InitializeComponent();
                cargaGridListMaterialesDisponibles();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                //ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                //ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
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
                frm = new FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.IdMaterialesDisponibles_PreAsignado_a_Obra(param.IdEmpresa);
                frm.Show();

                frm.Event_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing += new FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant.Delegate_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing(frm_Event_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);

            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoListMat == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frm = new FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.setCab(InfoListMat);
                    frm.Show();

                    frm.Event_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing += new FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant.Delegate_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing(frm_Event_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing);

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
                printableComponentLink1.Landscape = true;
                printableComponentLink1.Component = gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra;
                printableComponentLink1.ShowPreview();
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
                if (InfoListMat == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frm = new FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.setCab(InfoListMat);
                    frm.Show(); 


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
            //string msg;
            try
            {
                getDet();
                if (InfoListMat != null)
                {
                    foreach (var item in LstMateriales_a_Liberar)
                    {
                        InfoInMoviInvexProducto_CusCider.IdEmpresa = item.IdEmpresa;
                        InfoInMoviInvexProducto_CusCider.IdSucursal = item.IdSucursal;
                        InfoInMoviInvexProducto_CusCider.IdBodega = item.IdBodega;
                        InfoInMoviInvexProducto_CusCider.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        InfoInMoviInvexProducto_CusCider.IdNumMovi = item.IdNumMovi;
                        InfoInMoviInvexProducto_CusCider.mv_Secuencia = item.mv_Secuencia;
                        InfoInMoviInvexProducto_CusCider.Secuencia = item.Secuencia;
                        InfoInMoviInvexProducto_CusCider.IdProducto = item.IdProducto;
                        InfoInMoviInvexProducto_CusCider.CodigoBarra = item.CodigoBarra;

                        InfoInMoviInvexProducto_CusCider.CodObra_preasignada = item.CodObra_preasignada;

                        BusInMoviInvexProducto_CusCider.LiberarMP_de_Obra_preasignada(InfoInMoviInvexProducto_CusCider);


                        cargaGridListMaterialesDisponibles();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //Instancia de empresa
        public cl_parametrosGenerales_Bus param= cl_parametrosGenerales_Bus.Instance;
        FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant frm = new FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant();
        //Instancias de Listado de MAteriales
        List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstMaterialesPreasignados = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus BusLMater = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus();
        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info InfoListMat = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();

        List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstMateriales_a_Liberar = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus BusInMoviInvexProducto_CusCider = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Info InfoInMoviInvexProducto_CusCider = new in_movi_inve_detalle_x_Producto_CusCider_Info();

        private void cargaGridListMaterialesDisponibles()
        {
            try
            {
                LstMaterialesPreasignados = BusLMater.TraerTodoMP_Preasignado_a_Obra(param.IdEmpresa);

                gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = LstMaterialesPreasignados;

                gridCtrlListMaterialesDisponibles_PreAsignado_a_Obra.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


            
        }
        public Boolean getDet()
        {
            try
            {
                List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> lsttemp = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();


                for (int i = 0; i < gridViewListMaterialesDisponibles_PreAsignado_a_Obra.RowCount; i++)
                {
                    var ass = (com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info)gridViewListMaterialesDisponibles_PreAsignado_a_Obra.GetRow(i);
                    //var ass = (com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info)gridViewListMaterialesDisponibles_PreAsignado_a_Obra.GetFocusedRow();
                    

                    if (ass != null && ass.liberar == true)
                      //  if (ass != null)
                    {
                        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info row = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();

                        row.IdEmpresa = param.IdEmpresa;
                        row.IdSucursal = param.IdSucursal;
                        row.IdBodega = ass.IdBodega;
                        row.IdMovi_inven_tipo = ass.IdMovi_inven_tipo;
                        row.IdNumMovi = ass.IdNumMovi;
                        row.mv_Secuencia = ass.mv_Secuencia;
                        row.Secuencia = ass.Secuencia;

                        row.CodObra_preasignada = ass.CodObra_preasignada;
                        row.IdProducto = ass.IdProducto;
                        row.CodigoBarra = ass.CodigoBarra;

                        row.longitud = ass.longitud;
                        row.alto = ass.alto;
                        row.espesor = ass.espesor;


                        row.Det_Kg = ass.Det_Kg;

                        //row.IdNumMovi = 0;

                        row.IdEstadoAprob = "PEN";

                        row.pr_largo = ass.pr_largo;
                        row.largo_total = ass.largo_total;
                        row.largo_restante = ass.largo_restante;

                        row.largo_pieza_entera = ass.largo_pieza_entera;
                        row.cantidad_pieza_entera = ass.cantidad_pieza_entera;
                        row.largo_pieza_complementaria = ass.largo_pieza_complementaria;
                        row.cantidad_pieza_complementaria = ass.cantidad_pieza_complementaria;
                        row.cantidad_total_pieza_complementaria = ass.cantidad_total_pieza_complementaria;
                        row.largo_despunte1 = ass.largo_despunte1;
                        row.cantidad_despunte1 = ass.cantidad_despunte1;
                        row.es_despunte_usable1 = ass.es_despunte_usable1;
                        row.largo_despunte2 = ass.largo_despunte2;
                        row.cantidad_despunte2 = ass.cantidad_despunte2;
                        row.es_despunte_usable2 = ass.es_despunte_usable2;

                        if (ass.IdProducto == 0)
                        {
                            MessageBox.Show("Debe corregir su seleccion de productos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;

                        }
                        row.dm_cantidad = ass.dm_cantidad;
                        row.pr_codigo = ass.pr_codigo;
                        row.pr_descripcion = ass.pr_descripcion;
                        if (row.dm_cantidad > 0)
                            lsttemp.Add(row);
                        else
                        {
                            MessageBox.Show("Debe corregir la cantidad de los productos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;

                        }

                    }
                }


                //gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource  = lsttemp;
                LstMateriales_a_Liberar = lsttemp;
                //LstInfoLMat  = (List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>)gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource;
                if (LstMateriales_a_Liberar.Count < 1)
                {
                    MessageBox.Show("Seleccionar Materiales a Liberar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;

            }


        }
        void frm_Event_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 cargaGridListMaterialesDisponibles();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
 
        }

        private void gridViewListMaterialesDisponibles_PreAsignado_a_Obra_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoListMat = (com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info)gridViewListMaterialesDisponibles_PreAsignado_a_Obra.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void gridViewListMaterialesDisponibles_PreAsignado_a_Obra_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewListMaterialesDisponibles_PreAsignado_a_Obra.GetRow(e.RowHandle) as com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info;
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

        private void FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraConsulta_Load(object sender, EventArgs e) { }
    }
}
