using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.Remoting;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCCom_Menu_Reportes : UserControl
    {
        #region Listas
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<tb_Sucursal_Info> lst_sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();

        List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();

        List<ct_punto_cargo_grupo_Info> lst_grupo = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus bus_grupo = new ct_punto_cargo_grupo_Bus();

        List<in_Producto_Info> lst_producto = new List<in_Producto_Info>();
        in_producto_Bus bus_producto = new in_producto_Bus();

        List<cp_proveedor_Info> lst_proveedor = new List<cp_proveedor_Info>();
        cp_proveedor_Bus bus_proveedor = new cp_proveedor_Bus();

        string msg = "";
        #endregion

        #region Delegados

        public delegate void delegate_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImprimir_ItemClick event_btnImprimir_ItemClick;

        public delegate void delegate_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnRefrescar_ItemClick event_btnRefrescar_ItemClick;

        public delegate void delegate_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnsalir_ItemClick event_btnsalir_ItemClick;
        #endregion

        public UCCom_Menu_Reportes()
        {
            InitializeComponent();
            event_btnImprimir_ItemClick += UCGe_Menu_Reportes_Compras_event_btnImprimir_ItemClick;
            event_btnRefrescar_ItemClick += UCGe_Menu_Reportes_Compras_event_btnRefrescar_ItemClick;
            event_btnsalir_ItemClick += UCGe_Menu_Reportes_Compras_event_btnsalir_ItemClick;
            this.Dock = DockStyle.Top;
        }

        public void Cargar_combos()
        {
            try
            {
                lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdSucursal);
                cmb_sucursal.DataSource = lst_sucursal;

                lst_producto = bus_producto.Get_list_Producto(param.IdEmpresa);
                cmb_producto.DataSource = lst_producto;

                lst_grupo = bus_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref msg);
                cmb_grupo.DataSource = lst_grupo;

                lst_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_punto_cargo.DataSource = lst_punto_cargo;

                lst_grupo = bus_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref msg);
                cmb_grupo.DataSource = lst_grupo;

                lst_proveedor = bus_proveedor.Get_List_proveedor(param.IdEmpresa);
                cmb_proveedor.DataSource = lst_proveedor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        #region Void Delegados
        void UCGe_Menu_Reportes_Compras_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Reportes_Compras_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Reportes_Compras_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        #endregion

        #region Visible y Enable
       
        public Boolean Visible_Grupo_filtro
        {
            get { return this.ribbonPageGrupo_filtro.Visible; }
            set { this.ribbonPageGrupo_filtro.Visible = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_bei_producto { get { return this.bei_producto.Visibility; } set { this.bei_producto.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_grupo { get { return this.bei_grupo.Visibility; } set { this.bei_grupo.Visibility = value; } }

        public Boolean Visible_Grupo_acciones
        {
            get { return this.ribbonPageGrupo_acciones.Visible; }
            set { this.ribbonPageGrupo_acciones.Visible = value; }
        }

        public Boolean Visible_GrupoSucursal_producto
        {
            get { return this.GrupoSucursal_producto.Visible; }
            set { this.GrupoSucursal_producto.Visible = value; }
        }

        public Boolean Visible_GrupoPuntoCargo
        {
            get { return this.GrupoPuntoCargo.Visible; }
            set { this.GrupoPuntoCargo.Visible = value; }
        }

        public Boolean Visible_GrupoProveedor
        {
            get { return this.GrupoProveedor.Visible; }
            set { this.GrupoProveedor.Visible = value; }
        }


        public DevExpress.XtraBars.BarItemVisibility Visible_boton_Imprimir
        {
            get { return this.btnImprimir.Visibility; }
            set { this.btnImprimir.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_Refrescar
        {
            get { return this.btnRefrescar.Visibility; }
            set { this.btnRefrescar.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_Salir
        {
            get { return this.btnsalir.Visibility; }
            set { this.btnsalir.Visibility = value; }
        }

        public Boolean Enable_boton_Imprimir
        {
            get { return this.btnImprimir.Enabled; }
            set { this.btnImprimir.Enabled = value; }
        }

        public Boolean Enable_boton_Refrescar
        {
            get { return this.btnRefrescar.Enabled; }
            set { this.btnRefrescar.Enabled = value; }
        }
        
        public Boolean Enable_boton_Salir
        {
            get { return this.btnsalir.Enabled; }
            set { this.btnsalir.Enabled = value; }
        }

        #endregion

        public in_Producto_Info Get_info_producto()
        {
            try
            {
                in_Producto_Info info_producto = new in_Producto_Info();

                if (bei_producto.EditValue == null)
                    info_producto = null;
                else
                    info_producto = lst_producto.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdProducto == Convert.ToDecimal(bei_producto.EditValue));

                return info_producto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public cp_proveedor_Info Get_info_proveedor()
        {
            try
            {
                cp_proveedor_Info info_proveedor = new cp_proveedor_Info();

                if (bei_proveedor.EditValue == null)
                    info_proveedor = null;
                else
                    info_proveedor = lst_proveedor.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdProveedor == Convert.ToDecimal(bei_proveedor.EditValue));

                return info_proveedor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public ct_punto_cargo_Info Get_info_punto_cargo()
        {
            try
            {
                ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();

                if (bei_punto_cargo.EditValue == null)
                    info_punto_cargo = null;
                else
                    info_punto_cargo = lst_punto_cargo.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdPunto_cargo == Convert.ToInt32(bei_punto_cargo.EditValue));

                return info_punto_cargo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public ct_punto_cargo_grupo_Info Get_info_punto_cargo_grupo()
        {
            try
            {
                ct_punto_cargo_grupo_Info info_punto_cargo_grupo = new ct_punto_cargo_grupo_Info();

                if (bei_grupo.EditValue == null)
                    info_punto_cargo_grupo = null;
                else
                    info_punto_cargo_grupo = lst_grupo.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdPunto_cargo_grupo == Convert.ToInt32(bei_grupo.EditValue));

                return info_punto_cargo_grupo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public tb_Sucursal_Info Get_info_sucursal()
        {
            try
            {
                tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();

                if (bei_sucursal.EditValue == null)
                    info_sucursal = null;
                else
                    info_sucursal = lst_sucursal.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdSucursal == Convert.ToInt32(bei_sucursal.EditValue));

                return info_sucursal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnImprimir_ItemClick(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnRefrescar_ItemClick(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ParentForm.Close();

                event_btnsalir_ItemClick(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UCGe_Menu_Reportes_Compras_Load(object sender, EventArgs e)
        {
            dtp_fechaIni.EditValue = DateTime.Now.AddMonths(-1);
            dtp_fechaFin.EditValue = DateTime.Now.AddMonths(1);
        }

        private void ribbonControlMenu_Click(object sender, EventArgs e)
        {

        }

        private void bei_grupo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bei_grupo.EditValue == null)
                    lst_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                else
                    lst_punto_cargo = bus_punto_cargo.Get_list_PuntoCargo_x_grupo(param.IdEmpresa, Convert.ToInt32(bei_grupo.EditValue));
                cmb_punto_cargo.DataSource = lst_punto_cargo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
    }
}
