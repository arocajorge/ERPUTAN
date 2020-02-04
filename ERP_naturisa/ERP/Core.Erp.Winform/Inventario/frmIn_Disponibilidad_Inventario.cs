using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Disponibilidad_Inventario : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCIn_Categorias ctrl_Categorias = new UCIn_Categorias();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<SpIn_DispInventario_Info> lis;
        #endregion
        
        public FrmIn_Disponibilidad_Inventario()
        {
            try
            {
                InitializeComponent();
                ctrl_Categorias.set_Treelist_SelectMultiple(true);
                ctrl_Categorias.set_Treelist_AllowRecursiveNodeChecking(true);
                ctrl_Categorias.Dock = DockStyle.Fill;
                ctrl_Categorias.ca_Posicion.Visible = false;
                ctrl_Categorias.IdCategoria.Visible = false;
                pnlCategorias.Controls.Add(ctrl_Categorias);
                dtpFecha.EditValue = DateTime.Now;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        private void btnSalir_Click(object sender, EventArgs e)
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

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == " ")
                {
                    SpIn_DispInventario_Info item = gridView.GetFocusedRow() as SpIn_DispInventario_Info;
                    FrmIn_Kardex frm = new FrmIn_Kardex(item.IdProductoSi, Convert.ToDateTime(Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString()).AddDays(-30), Convert.ToDateTime(Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString()));
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    
        private void btSalir_Click(object sender, EventArgs e)//salir
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

        private void btImprimir_Click(object sender, EventArgs e)//imprimir
        {
            try
            {
                IEnumerable<tbINV_Rpt001_Info> rptLst = from q in lis
                                                        select new tbINV_Rpt001_Info { bo_Descripcion = q.bo_Descripcion, ca_Categoria = q.ca_Categoria, pr_descripcion = q.pr_descripcion, Su_Descripcion = q.Su_Descripcion };

                List<tbINV_Rpt001_Info> Lista = new List<tbINV_Rpt001_Info>();
                Lista = rptLst.ToList();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void BTProcesar_Click(object sender, EventArgs e)//consultar
        {
            try
            {
                lis = new List<SpIn_DispInventario_Info>();
                lis.Clear();
                var LstCate_I = ctrl_Categorias.get_CategoriaList();
                SpIn_DispInventario_Bus bus = new SpIn_DispInventario_Bus();
                Nullable<DateTime> FECHA;
                Nullable<int> IdBodega = 0;
                Nullable<int> IdSucursal = 0;
                string Cat = "";
                foreach (var item in LstCate_I)
                {
                    Cat = Cat + "'" + item.IdCategoria + "'" + ",";
                }


                if (checkEdit1.Checked == false)
                {
                    FECHA = null;
                    colstock.Caption = " Stock";
                }
                else
                {
                    FECHA = Convert.ToDateTime(Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString());
                    colstock.Caption = " Stock al: " + Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString();
                }
                if (LstCate_I.Count == 0)
                {
                    Cat = null;
                }
                else
                {
                    Cat = Cat.Substring(0, Cat.Length - 1);
                }
                if (ctrl_Suc_Bod.cmb_bodega.Text == "TODAS LAS BODEGAS")
                {
                    IdBodega = null;

                }
                else
                {
                    IdBodega = Convert.ToInt32(ctrl_Suc_Bod.cmb_bodega.EditValue);
                }
                if (ctrl_Suc_Bod.cmb_sucursal.Text == "TODAS LAS SUCURSALES")
                {
                    IdSucursal = null;
                    IdBodega = null;

                }
                else
                {
                    IdSucursal = Convert.ToInt32(ctrl_Suc_Bod.cmb_sucursal.EditValue);
                }
                lis = bus.Get_List_In_DispInventario(FECHA, IdSucursal, IdBodega, param.IdEmpresa, Cat, param.IdUsuario);
                Bitmap imgImprimir = global::Core.Erp.Winform.Properties.Resources.imprimir;
                foreach (var item in lis)
                {
                    item.Imagen = imgImprimir;

                }
                gridControl.DataSource = lis;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
    }
}
