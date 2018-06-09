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
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using Core.Erp.Info.General;



namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Categoria_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        in_categorias_bus _cateBu = new in_categorias_bus();
        List<in_categorias_Info> _listCategoria = new List<in_categorias_Info>();
        in_categorias_Info _iCategoria = new in_categorias_Info();
        in_categorias_Info _iCategoriaPadre = new in_categorias_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public FrmIn_Categoria_Cons()
        {
            try
            {
              InitializeComponent();
              ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_iCategoria != null)
                {
                    if (_iCategoria.Estado == "I")
                    {
                        MessageBox.Show("El registro seleccionado ya fue anulado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {

                        fr = new FrmIn_Categoria_Mant();
                        fr.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                        fr.set_categoria(_iCategoria);
                        fr.set_categoriaPadre(_iCategoriaPadre);
                        fr.MdiParent = MdiParent;
                        fr.ReloadGrid += fr_ReloadGrid;
                        fr.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.treeListCategorias.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_iCategoria != null)
                {
                    fr = new FrmIn_Categoria_Mant();
                    fr.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    fr.set_categoria(_iCategoria);
                    fr.set_categoriaPadre(_iCategoriaPadre);
                    fr.MdiParent = MdiParent;
                    fr.ReloadGrid += fr_ReloadGrid;
                    fr.Show();

                    //fr.Dispose();
                }

                else
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
                }                           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_iCategoria != null)
                {
                    if (_iCategoria.Estado == "I")
                    {
                        MessageBox.Show("No se pueden modificar registros inactivos (I)", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        fr = new FrmIn_Categoria_Mant();
                        fr.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        fr.set_categoria(_iCategoria);
                        fr.set_categoriaPadre(_iCategoriaPadre);
                        fr.MdiParent = MdiParent;
                        fr.ReloadGrid += fr_ReloadGrid;
                        fr.Show();
                        // fr.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }                                                            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                fr = new FrmIn_Categoria_Mant();
                fr.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                fr.Text = fr.Text + " ***NUEVO REGISTRO***";
                fr.ReloadGrid += fr_ReloadGrid;
                fr.Show();
                //fr.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void fr_ReloadGrid()
        {
            try
            {
             Cargar_Categorias();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Cargar_Categorias()
        {
            try
            {
                _listCategoria = _cateBu.Get_List_categorias(param.IdEmpresa);
               treeListCategorias.DataSource = _listCategoria;
               treeListCategorias.RefreshDataSource();
            }
            catch (Exception ex)              
            { 
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmIn_CategoriaConsulta_Load(object sender, EventArgs e)
        {
            try 
            {
                Cargar_Categorias();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void treeListCategorias_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                TreeListNode childNode = (TreeListNode)e.Node;

                _iCategoria = (in_categorias_Info)treeListCategorias.GetDataRecordByNode(childNode);
                if (_iCategoriaPadre != null)
                {
                    _iCategoriaPadre = _listCategoria.Find(delegate(in_categorias_Info ca)
                    {
                        return ca.IdCategoria == _iCategoria.IdCategoriaPadre && ca.IdEmpresa == _iCategoria.IdEmpresa;
                    }
                        );
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        FrmIn_Categoria_Mant fr ;

        private void treeListCategorias_MouseUp(object sender, MouseEventArgs e)
        {
         
            if (e.Button == MouseButtons.Right)
            {               
                Point p = new Point(e.X, e.Y);
                             
                if (_iCategoria != null)
                {
                    contextMenuStripMant.Show(treeListCategorias, p);               
                }

            }
        }

        private void treeListCategorias_StyleChanged(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
         
    
    }
}
