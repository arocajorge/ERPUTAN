using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Reportes.Controles
{
public partial class UCInv_MenuReportes_2 : UserControl
    {
        #region Data
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus busSucursal = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> lstSucuInfo = new List<tb_Sucursal_Info>();
        tb_Bodega_Bus busBodega = new tb_Bodega_Bus();
        List<tb_Bodega_Info> lstBodegaInfo = new List<tb_Bodega_Info>();
        in_producto_Bus busProducto = new in_producto_Bus();
        List<in_Producto_Info> lstProductoInfo = new List<in_Producto_Info>();
        in_movi_inven_tipo_Bus busMoviTip = new in_movi_inven_tipo_Bus();
        List<in_movi_inven_tipo_Info> lstMoviTipiInfo = new List<in_movi_inven_tipo_Info>();
        cp_proveedor_Bus busProveedor = new cp_proveedor_Bus();
        List<cp_proveedor_Info> listProveedor = new List<cp_proveedor_Info>();
        ct_Centro_costo_Bus busCentro_costo = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> lstCentro_costo = new List<ct_Centro_costo_Info>();
        List<ct_centro_costo_sub_centro_costo_Info> lstSubcentro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus busSubcentro_costo = new ct_centro_costo_sub_centro_costo_Bus();

        List<in_categorias_Info> lst_Categoria = new List<in_categorias_Info>();
        in_categorias_Info info_Categoria = new in_categorias_Info();
        in_categorias_bus bus_Categoria = new in_categorias_bus();

        List<in_linea_info> lst_Linea = new List<in_linea_info>();
        in_linea_info info_Linea = new in_linea_info();
        in_linea_Bus bus_Linea = new in_linea_Bus();
        #endregion

        #region Event
        public delegate void delegate_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnConsultar_ItemClick event_tnConsultar_ItemClick;
        public delegate void delegate_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImprimir_ItemClick event_btnImprimir_ItemClick;
        public delegate void delegate_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnSalir_ItemClick event_btnSalir_ItemClick;
        #endregion

        #region Visible_Enable
        public Boolean VisibleGrupoSucursal
        {
            get { return this.GrupoSucu_bod.Visible; }
            set { this.GrupoSucu_bod.Visible = value; }
        }
        public Boolean VisibleGrupoCategoriaLinea
        {
            get { return this.GrupoCategoriaLinea.Visible; }
            set { this.GrupoCategoriaLinea.Visible = value; }
        }
        public Boolean VisibleGrupoMovimiento
        {
            get { return this.GrupoMovimiento.Visible; }
            set { this.GrupoMovimiento.Visible = value; }
        }
        public Boolean VisibleGrupoFecha
        {
            get { return this.GrupoFecha.Visible; }
            set { this.GrupoFecha.Visible = value; }
        }
        public Boolean VisibleGrupoBotones
        {
            get { return this.GrupoBotones.Visible; }
            set { this.GrupoBotones.Visible = value; }
        }
        public Boolean VisibleGrupoCentro_Subcentro_costo
        {
            get { return this.ribbonPageGroupCentroCosto.Visible; }
            set { this.ribbonPageGroupCentroCosto.Visible = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbProveedor
        {
            get { return this.cmbProveedor.Visibility; }
            set { this.cmbProveedor.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbSucursal
        {
            get { return this.cmbSucursal.Visibility; }
            set { this.cmbSucursal.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleCmbBodega
        {
            get { return this.cmbBodega.Visibility; }
            set { this.cmbBodega.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleCmbProducto
        {
            get { return this.cmbProducto.Visibility; }
            set { this.cmbProducto.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleCmbTipoMovInve
        {
            get { return this.cmbTipoMovInve.Visibility; }
            set { this.cmbTipoMovInve.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleDtpDesde
        {
            get { return this.dtpDesde.Visibility; }
            set { this.dtpDesde.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleDtpHasta
        {
            get { return this.dtpHasta.Visibility; }
            set { this.dtpHasta.Visibility = value; }
        }
        
        
        public DevExpress.XtraBars.BarItemVisibility VisiblebtnImprimir
        {
            get { return this.btnImprimir.Visibility; }
            set { this.btnImprimir.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisiblebtnSalir
        {
            get { return this.btnSalir.Visibility; }
            set { this.btnSalir.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmb_CentroCosto
        {
            get { return this.barEditItemCentroCosto.Visibility; }
            set { this.barEditItemCentroCosto.Visibility = value; }
        }

        


        public Boolean EnableBotonImprimir
        {
            get { return this.btnImprimir.Enabled; }
            set { this.btnImprimir.Enabled = value; }
        }

        public Boolean EnableBotonConsultar
        {
            get { return this.btnConsultar.Enabled; }
            set { this.btnConsultar.Enabled = value; }
        }

        public Boolean EnableBotonSalir
        {
            get { return this.btnSalir.Enabled; }
            set { this.btnSalir.Enabled = value; }
        }

        #endregion


        public UCInv_MenuReportes_2()
        {
            InitializeComponent();
            event_btnImprimir_ItemClick += UCInv_MenuReportes_2_event_btnImprimir_ItemClick;
            event_btnSalir_ItemClick += UCInv_MenuReportes_2_event_btnSalir_ItemClick;
            event_tnConsultar_ItemClick += UCInv_MenuReportes_2_event_tnConsultar_ItemClick;            
        }
    
        void UCInv_MenuReportes_2_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCInv_MenuReportes_2_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCInv_MenuReportes_2_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UCInv_MenuReportes_2_Load(object sender, EventArgs e)
        {
            try
            {
                in_Producto_Info infoProducto = new in_Producto_Info();
                in_movi_inven_tipo_Info infoMoviTipi = new in_movi_inven_tipo_Info();
                cp_proveedor_Info infoProvee = new cp_proveedor_Info();
                ct_Centro_costo_Info infoCentro_costo = new ct_Centro_costo_Info();
                ct_centro_costo_sub_centro_costo_Info infoSubcentro_costo = new ct_centro_costo_sub_centro_costo_Info();
                in_movi_inven_tipo_Info info_movimiento = new in_movi_inven_tipo_Info();

                string msg="";

                dtpDesde.EditValue = DateTime.Now.AddMonths(-1);
                dtpHasta.EditValue = DateTime.Now.AddMonths(1);

                lstSucuInfo = busSucursal.Get_List_Sucursal_Todos(param.IdEmpresa);
                cmbSucursal_Grid.DataSource = lstSucuInfo;

                lstBodegaInfo = busBodega.Get_List_Bodega(param.IdEmpresa, Cl_Enumeradores.eTipoFiltro.todos);
                cmbBodega_Grid.DataSource = lstBodegaInfo;

                infoProducto.IdProducto = 0;
                infoProducto.pr_descripcion = "Todos";

                infoProvee.IdProveedor = 0;
                infoProvee.pr_nombre = "Todos";

                infoMoviTipi.IdMovi_inven_tipo = 0;
                infoMoviTipi.tm_descripcion = "Todos";

                infoCentro_costo.IdCentroCosto = "Todos";
                infoCentro_costo.Centro_costo = "Todos";

                infoSubcentro_costo.IdCentroCosto_sub_centro_costo = "Todos";
                infoSubcentro_costo.Centro_costo = "Todos";

                lstProductoInfo = busProducto.Get_list_Producto(param.IdEmpresa);
                lstProductoInfo.Add(infoProducto);
                cmbProducto_Grid.DataSource = lstProductoInfo.OrderBy(q => q.IdProducto).ToList();

                lstMoviTipiInfo = busMoviTip.Get_List_movi_inven_tipo(param.IdEmpresa);
                lstMoviTipiInfo.Add(infoMoviTipi);
                CmbTipoMov_Grid.DataSource = lstMoviTipiInfo.OrderBy(q => q.IdMovi_inven_tipo).ToList();

                listProveedor = busProveedor.Get_List_proveedor(param.IdEmpresa);
                listProveedor.Add(infoProvee);
                cmbProveedor_Grid.DataSource = listProveedor;

                lstCentro_costo = busCentro_costo.Get_list_Centro_Costo(param.IdEmpresa,ref msg);
                lstCentro_costo.Add(infoCentro_costo);
                cmb_centroCosto.DataSource = lstCentro_costo;

                lstSubcentro_costo = busSubcentro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                lstSubcentro_costo.Add(infoSubcentro_costo);
                cmb_subCentro_costo.DataSource = lstSubcentro_costo;

                lst_Categoria = bus_Categoria.Get_List_categorias(param.IdEmpresa);
                cmb_Categoria.DataSource = lst_Categoria;

                lst_Linea = bus_Linea.Get_List_Linea(param.IdEmpresa, "");
                cmb_Linea.DataSource = lst_Linea;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_tnConsultar_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnImprimir_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnSalir_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbSucursal_Grid_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbBodega_Grid_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbBodega_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Convert.ToInt32(cmbBodega.EditValue) != 5000)
            //    {
            //        cmbProducto_Grid.DataSource = new List<tb_Bodega_Info>();
            //        cmbProducto_Grid.DataSource = lstProductoInfo.Where(q => q.IdBodega == Convert.ToInt32(cmbBodega.EditValue) || q.IdProducto == 0);
            //    }
            //}
            //catch (Exception ex)
            //{
                
            //    throw;
            //}
        }

        private void barEditItemTipoMovimiento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    in_movi_inven_tipo_Info infoMoviTipi = new in_movi_inven_tipo_Info();
                    infoMoviTipi.IdMovi_inven_tipo = 0;
                    infoMoviTipi.tm_descripcion = "Todos";

                    if ((string)barEditItemTipoMovimiento.EditValue == "(+)Ingresos")
                    {
                        lstMoviTipiInfo = busMoviTip.Get_list_movi_inven_tipo(param.IdEmpresa, "+");
                        lstMoviTipiInfo.Add(infoMoviTipi);
                        CmbTipoMov_Grid.DataSource = lstMoviTipiInfo.OrderBy(q => q.IdMovi_inven_tipo).ToList();

                    }
                    if ((string)barEditItemTipoMovimiento.EditValue == "Todos" || barEditItemTipoMovimiento.EditValue==null)
                    {
                        lstMoviTipiInfo = busMoviTip.Get_List_movi_inven_tipo(param.IdEmpresa);
                        lstMoviTipiInfo.Add(infoMoviTipi);
                        CmbTipoMov_Grid.DataSource = lstMoviTipiInfo.OrderBy(q => q.IdMovi_inven_tipo).ToList();
                    }
                    if ((string)barEditItemTipoMovimiento.EditValue == "(-)Egresos")
                    {
                        lstMoviTipiInfo = busMoviTip.Get_list_movi_inven_tipo(param.IdEmpresa, "-");
                        lstMoviTipiInfo.Add(infoMoviTipi);
                        CmbTipoMov_Grid.DataSource = lstMoviTipiInfo.OrderBy(q => q.IdMovi_inven_tipo).ToList();
                    }

                    
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void barEditItemCentroCosto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ct_Centro_costo_Info Info = new ct_Centro_costo_Info();
                ct_centro_costo_sub_centro_costo_Info InfoSubcentro_costo = new ct_centro_costo_sub_centro_costo_Info();
                string centro_costo = (string)barEditItemCentroCosto.EditValue;
                
                InfoSubcentro_costo.IdCentroCosto_sub_centro_costo = "Todos";
                InfoSubcentro_costo.Centro_costo = "Todos";
                
                if (centro_costo == "Todos" || centro_costo == null)
                {
                    
                    lstSubcentro_costo = busSubcentro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                    
                    cmb_subCentro_costo.DataSource = lstSubcentro_costo;
                    lstSubcentro_costo.Add(InfoSubcentro_costo);
                    barEditItemCentroCosto.EditValue = centro_costo;
                    barEditItemSubCentroCosto.EditValue = "Todos";
                }
                else
                {
                    lstSubcentro_costo =busSubcentro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, centro_costo);
                    lstSubcentro_costo.Add(InfoSubcentro_costo);
                    cmb_subCentro_costo.DataSource = lstSubcentro_costo;
                    barEditItemSubCentroCosto.EditValue = "Todos";
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cmbSucursal.EditValue) != 0)
                {
                    int idSucursal = Convert.ToInt32(cmbSucursal.EditValue);
                    List<tb_Bodega_Info> Lista_bodega_temp = new List<tb_Bodega_Info>();
                    Lista_bodega_temp = lstBodegaInfo.Where(q => q.IdSucursal == idSucursal || q.IdBodega == 0).ToList();
                    cmbBodega_Grid.DataSource = null;
                    cmbBodega_Grid.DataSource = Lista_bodega_temp;
                }
                else
                    cmbBodega_Grid.DataSource = lstBodegaInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void bei_Categoria_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bei_Categoria.EditValue != null)
                {
                    string idCategoria = Convert.ToString(bei_Categoria.EditValue);
                    List<in_linea_info> ListLinea_temp = new List<in_linea_info>();

                    lst_Linea =bus_Linea.Get_List_Linea(param.IdEmpresa, idCategoria);

                    ListLinea_temp = lst_Linea.Where(q => q.IdCategoria.Contains(idCategoria)).ToList();
                    cmb_Linea.DataSource = null;
                    cmb_Linea.DataSource = ListLinea_temp;
                }
                else
                    cmb_Linea.DataSource = lst_Linea;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void beiLinea_EditValueChanged(object sender, EventArgs e)
        {

        }

        public in_categorias_Info Get_info_categoria()
        {
            try
            {
                info_Categoria = new in_categorias_Info();

                if (bei_Categoria.EditValue != null)
                {
                    info_Categoria = lst_Categoria.FirstOrDefault(q => q.IdCategoria == bei_Categoria.EditValue.ToString());
                }
                else
                    info_Categoria = null;

                return info_Categoria;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public in_linea_info Get_info_linea()
        {
            try
            {
                info_Linea = new in_linea_info();

                if (beiLinea.EditValue != null && bei_Categoria.EditValue!=null)
                {
                    info_Linea = lst_Linea.FirstOrDefault(q => q.IdLinea == Convert.ToInt32(beiLinea.EditValue) && q.IdCategoria == bei_Categoria.EditValue.ToString());
                }
                else
                    info_Linea = null;

                return info_Linea;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }



        
    }
}
