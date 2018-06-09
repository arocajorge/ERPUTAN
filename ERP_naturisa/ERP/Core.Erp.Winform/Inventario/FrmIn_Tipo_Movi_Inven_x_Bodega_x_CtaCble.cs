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
using DevExpress.XtraTreeList.Nodes;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Inventario;
namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Tipo_Movi_Inven_x_Bodega_x_CtaCble : Form
    {
        #region Declaracion Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<in_movi_inven_tipo_Info> DataSource = new BindingList<in_movi_inven_tipo_Info>();
        tb_Bodega_Bus Bodega_B = new tb_Bodega_Bus();
        tb_Sucursal_Bus Sucursales = new tb_Sucursal_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<tb_Bodega_Info> ListaBodegas = new List<tb_Bodega_Info>();
        
        in_movi_inven_tipo_Bus inMoviInvenTipo_B = new in_movi_inven_tipo_Bus();

        ct_Plancta_Bus ctplnCta_B = new ct_Plancta_Bus();
        List<in_movi_inven_tipo_x_tb_bodega_Info> ListaGuardar;
        BindingList<tb_Bodega_Info> ListaData = new BindingList<tb_Bodega_Info>();
        string MensajeError = "";
        in_movi_inven_tipo_Bus BUS = new in_movi_inven_tipo_Bus();
        Boolean UnaVez = true;
        #endregion

        public FrmIn_Tipo_Movi_Inven_x_Bodega_x_CtaCble()
        {
            try
            {
                InitializeComponent();
                ListaBodegas = Bodega_B.Get_List_Bodega(param.IdEmpresa);
                cmbCuentaContable.DataSource = ctplnCta_B.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                List<in_movi_inven_tipo_Info> temp = inMoviInvenTipo_B.Get_List_movi_inven_tipo(param.IdEmpresa);
                if (temp != null)
                    DataSource = new BindingList<in_movi_inven_tipo_Info>(temp);
                gridControl_movi_inven.DataSource = DataSource;

                
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cargar_sucursal_bodega_x_cta()
        {
            try
            {
                var Sucu = Sucursales.Get_List_Sucursal(param.IdEmpresa);
                var Lista = Bodega_B.Get_List_Bodega(param.IdEmpresa);
                int i = 1;
                foreach (var item in Sucu)
                {
                    tb_Bodega_Info Bodega_I = new tb_Bodega_Info();
                    Bodega_I.NomSucursal = item.Su_Descripcion;
                    Bodega_I.IdSucursal = 0;
                    Bodega_I.IdBodega = i;
                    Bodega_I.bo_Descripcion = item.Su_Descripcion;
                    i++;
                    Lista.Add(Bodega_I);


                }
                int c = Sucu.Count + 1;

                Lista.ForEach(v => { if (v.IdSucursal != 0) { v.IdBodega = c; c++; } });
                ListaData = new BindingList<tb_Bodega_Info>(Lista);
                treeList1.DataSource = ListaData;
                treeList1.ExpandAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmIN_MovimientoInventarioTipoXBodegaxCtaCtble_Load(object sender, EventArgs e)
        {

            try
            {
                cargar_sucursal_bodega_x_cta();

              
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                treeList1.OptionsBehavior.Editable = true;
                var item = ListaBodegas.First(v => v.NomSucursal == e.Node.ParentNode.GetDisplayText(colbo_Descripcion) && v.bo_Descripcion == e.Node.GetDisplayText(colbo_Descripcion));

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                treeList1.OptionsBehavior.Editable = false;
           
            }
            
        }

        private void treeList1_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            try
            {
              
                var item = ListaBodegas.First(v => v.NomSucursal == e.Node.ParentNode.GetDisplayText(colbo_Descripcion) && v.bo_Descripcion == e.Node.GetDisplayText(colbo_Descripcion));


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                e.CanCheck = false;
            }
        }

        private void treeList1_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {

            try
            {
                TreeListNode childNode = (TreeListNode)e.Node;
                foreach (TreeListNode item in treeList1.Nodes)
                {
                    item.UncheckAll();
                }

                childNode.UncheckAll();

                childNode.Checked = true;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

               
        }
        
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridView_movi_inven.FocusedColumn.Caption == "*")
                {
                    gridView_movi_inven.SetRowCellValue(e.PrevFocusedRowHandle, colChek, false);
                    gridView_movi_inven.SetRowCellValue(e.FocusedRowHandle, colChek, true);

                    in_movi_inven_tipo_x_tb_bodega_Bus BUSTipo = new in_movi_inven_tipo_x_tb_bodega_Bus();



                    var Consulta = BUSTipo.Get_List_movi_inven_tipo_x_tb_bodega(param.IdEmpresa, Convert.ToInt32(gridView_movi_inven.GetFocusedRowCellValue(colIdMovi_inven_tipo)));
                    foreach (var item1 in Consulta)
                    {
                        foreach (var item in ListaBodegas)
                        {
                            if (item.IdBodega == item1.IdBodega && item.IdSucursal == item1.IdSucucursal)
                            {
                                item1.Sucursal = item.NomSucursal;
                                item1.Bodega = item.bo_Descripcion;

                            }
                        }
                    }
                    foreach (var item in ListaData)
                    {
                        item.ip = null;
                        item.EstaEnBase = "N";
                        foreach (var item1 in Consulta)
                        {
                            if (item.bo_Descripcion == item1.Bodega && item.NomSucursal == item1.Sucursal)
                            {
                                item.ip = item1.IdCtaCble;
                                item.EstaEnBase = "S";
                            }
                        }
                    }


                    treeList1.ExpandAll();
                }

                if (UnaVez)
                {
                    foreach (var item in DataSource)
                    {
                        item.Chek = false;
                    }
                    UnaVez = false;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt.Focus();
                ListaGuardar = new List<in_movi_inven_tipo_x_tb_bodega_Info>();
                List<in_movi_inven_tipo_x_tb_bodega_Info> ListaModificar = new List<in_movi_inven_tipo_x_tb_bodega_Info>();
                foreach (var item in ListaData)
                {
                    if (!string.IsNullOrEmpty(item.ip))
                    {
                        in_movi_inven_tipo_x_tb_bodega_Info Obj = new in_movi_inven_tipo_x_tb_bodega_Info();
                        Obj.IdMovi_inven_tipo = Convert.ToInt32(gridView_movi_inven.GetFocusedRowCellValue(colIdMovi_inven_tipo));
                        var items = ListaBodegas.First(v => v.NomSucursal == item.NomSucursal && v.bo_Descripcion == item.bo_Descripcion);
                        Obj.IdSucucursal = items.IdSucursal;
                        Obj.IdBodega = items.IdBodega;
                        Obj.IdCtaCble = item.ip;
                        Obj.IdEmpresa = param.IdEmpresa;
                        if (item.EstaEnBase == "N")
                            ListaGuardar.Add(Obj);
                        else
                            ListaModificar.Add(Obj);
                    }

                }
                string Menjsa = "";
                string mensajeRecurso = "";


                in_movi_inven_tipo_x_tb_bodega_Bus BusinMoviInvenTipo_B = new in_movi_inven_tipo_x_tb_bodega_Bus();


                if (BusinMoviInvenTipo_B.GrabarDB(ListaGuardar, ref Menjsa))
                    if (BusinMoviInvenTipo_B.ModificarDB(ListaModificar, ref Menjsa))
                    {
                        mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                        MessageBox.Show(mensajeRecurso,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                ucGe_Menu_event_btnGuardar_Click(sender,e);
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

    }
}
