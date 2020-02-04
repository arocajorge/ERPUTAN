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
    public partial class frmIn_CategoriaConsulta : Form
    {
        in_categorias_bus _cateBu = new in_categorias_bus();
        List<in_categorias_Info> _listCategoria = new List<in_categorias_Info>();
        in_categorias_Info _iCategoria = new in_categorias_Info();
        in_categorias_Info _iCategoriaPadre = new in_categorias_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public frmIn_CategoriaConsulta()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            fr = new frmIn_CategoriaMantenimiento();
            fr.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
            fr.Text = fr.Text + " ***NUEVO REGISTRO***";
            fr.ReloadGrid += fr_ReloadGrid;
            fr.Show();
            //fr.Dispose();
        }

        void fr_ReloadGrid()
        {
            Cargar_Categorias();

        }

        private void Cargar_Categorias()
        {
            try
            {
                _listCategoria = _cateBu.Obtener_listCategoria(param.IdEmpresa);
               treeListCategorias.DataSource = _listCategoria;
               treeListCategorias.RefreshDataSource();
            }
            catch (Exception)
            {
            }
        }

        private void frmIn_CategoriaConsulta_Load(object sender, EventArgs e)
        {
            try 
            {
                Cargar_Categorias();
            }
            catch (Exception)
            {
		
            }
            
        }

        private void treeListCategorias_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                TreeListNode childNode = (TreeListNode)e.Node;

                _iCategoria = (in_categorias_Info)treeListCategorias.GetDataRecordByNode(childNode);
                _iCategoriaPadre = _listCategoria.Find(delegate(in_categorias_Info ca) { return ca.IdCategoria == _iCategoria.IdCategoriaPadre && ca.IdEmpresa == _iCategoria.IdEmpresa; });
            }
            catch (Exception)
            {
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        frmIn_CategoriaMantenimiento fr ;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            fr = new frmIn_CategoriaMantenimiento();
            fr.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
            fr.set_categoria(_iCategoria);
            fr.set_categoriaPadre(_iCategoriaPadre);
            fr.MdiParent = MdiParent;
            fr.ReloadGrid += fr_ReloadGrid;
            fr.Show();
           // fr.Dispose();

        }

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            fr = new frmIn_CategoriaMantenimiento();
            fr.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
            fr.set_categoria(_iCategoria);
            fr.set_categoriaPadre(_iCategoriaPadre);
            fr.MdiParent = MdiParent;
            fr.ReloadGrid += fr_ReloadGrid;
            fr.Show();

            //fr.Dispose();
        }

      

        

        //private void treeListCategorias_AfterCheckNode(object sender, NodeEventArgs e)
        //{
        //    TreeListNode childNode = (TreeListNode)e.Node;

        //    foreach (TreeListNode childNode2 in treeListCategorias.Nodes)
        //    {

        //        childNode2.UncheckAll();

        //    }

        //    childNode.UncheckAll();
        //    childNode.Checked = true;
        //}
    }
}
