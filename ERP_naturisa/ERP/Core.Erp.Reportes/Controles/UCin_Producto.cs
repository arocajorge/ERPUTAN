using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCin_Producto : UserControl
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<in_Producto_Info> Lista_Producto = new List<in_Producto_Info>();
        in_producto_Bus BusProducto = new in_producto_Bus();
        public Boolean Mostrar_Registro_Todos { get; set; }

        public UCin_Producto()
        {
            InitializeComponent();
        }

        public decimal Get_Id_ProductoIni()
        {
            try
            {
                in_Producto_Info Info = Lista_Producto.FirstOrDefault(v => v.IdProducto == Convert.ToDecimal(cmb_ProductoIni.EditValue));
                return Info.IdProducto;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return 0;
            }
        }

        public decimal Get_Id_ProductoFin()
        {
            try
            {
                in_Producto_Info Info = Lista_Producto.FirstOrDefault(v => v.IdProducto == Convert.ToDecimal(cmb_ProductoFin.EditValue));
                return Info.IdProducto;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return 0;
            }
        }

        public in_Producto_Info Get_ProductoIni()
        {
            try
            {
                in_Producto_Info Info = Lista_Producto.FirstOrDefault(v => v.IdProducto == Convert.ToDecimal(cmb_ProductoIni.EditValue));
                return Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return new in_Producto_Info();
            }
        }

        public in_Producto_Info Get_ProductoFin()
        {
            try
            {
                in_Producto_Info Info = Lista_Producto.FirstOrDefault(v => v.IdProducto == Convert.ToDecimal(cmb_ProductoFin.EditValue));
                return Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return new in_Producto_Info();
            }
        }

        public void Cargar_Combos()
        {
            try
            {
                Lista_Producto = BusProducto.Get_list_Producto(param.IdEmpresa);
                if (Mostrar_Registro_Todos == true)
                {
                    in_Producto_Info InfoTodos = new in_Producto_Info();
                    InfoTodos.IdEmpresa = param.IdEmpresa;
                    InfoTodos.IdProducto = 0;
                    InfoTodos.pr_descripcion = "TODOS";
                    Lista_Producto.Add(InfoTodos);
                }
                cmb_ProductoIni.Properties.DataSource = Lista_Producto;
                cmb_ProductoFin.Properties.DataSource = Lista_Producto;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UCin_Producto_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combos();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
