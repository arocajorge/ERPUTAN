using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_ProveedorBusqueda : Form
    {
        #region Declación de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        #endregion
        
        public FrmCom_ProveedorBusqueda()
        {
            try
            {
             InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }            
        }
        
        private void FrmCom_ProveedorBusqueda_Load(object sender, EventArgs e)
        {
            loadgrid(param.IdEmpresa);
            //event_FrmCom_ProveedorBusqueda_FormClosing += FrmCom_ProveedorBusqueda_event_FrmCom_ProveedorBusqueda_FormClosing;
        }

        public cp_proveedor_Info infoprovee { get; set; }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {

                infoprovee = new cp_proveedor_Info();
                infoprovee = (cp_proveedor_Info)gridVwProveedor.GetFocusedRow();
                if (infoprovee != null)
                    this.Close();
                else
                    MessageBox.Show("Seleccione un Proveedor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        public void cargagrid(decimal idproducto, int idempresa)
        {
            try
            {
                List<in_producto_x_cp_proveedor_Info> tabint = new List<in_producto_x_cp_proveedor_Info>();
                in_producto_x_cp_proveedor_Bus busTabint = new in_producto_x_cp_proveedor_Bus();
                
                List<cp_proveedor_Info> LstProvee = new List<cp_proveedor_Info>();
                cp_proveedor_Bus busProvee = new cp_proveedor_Bus();

                tabint = busTabint.ObtenerProducto_Proveedor(idempresa).FindAll(var => var.IdProducto == idproducto);

                foreach (var item in tabint)
                {
                    cp_proveedor_Info provee = new cp_proveedor_Info();
                    provee = busProvee.Get_Info_Proveedor(item.IdEmpresa_prov, item.IdProveedor);
                    LstProvee.Add(provee);
                }

                gridCtrlProveedor.DataSource = LstProvee;

            }
            catch (Exception ex) 
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
             
        }

        public void loadgrid(int idempresa)
        {
            try
            {
                List<in_producto_x_cp_proveedor_Info> tabint = new List<in_producto_x_cp_proveedor_Info>();
                in_producto_x_cp_proveedor_Bus busTabint = new in_producto_x_cp_proveedor_Bus();

                List<cp_proveedor_Info> LstProvee = new List<cp_proveedor_Info>();
                cp_proveedor_Bus busProvee = new cp_proveedor_Bus();

                tabint = busTabint.ObtenerProducto_Proveedor(idempresa);

                foreach (var item in tabint)
                {
                    cp_proveedor_Info provee = new cp_proveedor_Info();
                    provee = busProvee.Get_Info_Proveedor(item.IdEmpresa_prov, item.IdProveedor);
                    LstProvee.Add(provee);
                }

                gridCtrlProveedor.DataSource = LstProvee;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void gridVwProveedor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                infoprovee = new cp_proveedor_Info();
                infoprovee = (cp_proveedor_Info)gridVwProveedor.GetFocusedRow();
                if (infoprovee != null)
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
