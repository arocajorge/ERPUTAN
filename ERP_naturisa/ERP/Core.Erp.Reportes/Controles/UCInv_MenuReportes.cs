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
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCInv_MenuReportes : UserControl
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
        cp_proveedor_Info info_proveedor = new cp_proveedor_Info();
        in_categorias_bus Bus_Categoria = new in_categorias_bus();
        List<in_categorias_Info> ListCategoria = new List<in_categorias_Info>();
        in_linea_Bus BusLinea = new in_linea_Bus();
        List<in_linea_info> ListLinea = new List<in_linea_info>();
        List<ct_Centro_costo_Info> lst_centro_costo = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Info info_centro_costo = new ct_Centro_costo_Info();
        ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> lst_sub_centro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus bus_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Bus();
        string MensajeError = "";
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

        public Boolean VisibleGrupoProveedorProducto
        {
            get { return this.GrupoProveedorProducto.Visible; }
            set { this.GrupoProveedorProducto.Visible = value; }
        }

        public Boolean VisibleGrupoCentroCosto
        {
            get { return this.GrupoCentroCosto.Visible; }
            set { this.GrupoCentroCosto.Visible = value; }
        }

        public Boolean VisibleGrupoCheck
        {
            get { return this.GrupoCheck.Visible; }
            set { this.GrupoCheck.Visible = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisiblebeiCheck1
        {
            get { return this.beiCheck1.Visibility; }
            set { this.beiCheck1.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisiblebeiCheck2
        {
            get { return this.beiCheck2.Visibility; }
            set { this.beiCheck2.Visibility = value; }
        }
        public string CaptionCheck1
        {
            get { return this.beiCheck1.Caption; }
            set { this.beiCheck1.Caption = value; }
        }

        public string CaptionCheck2
        {
            get { return this.beiCheck2.Caption; }
            set { this.beiCheck2.Caption = value; }
        }

        public Boolean VisibleGrupoDias
        {
            get { return this.GrupoDias.Visible; }
            set { this.GrupoDias.Visible = value; }
        }

        public Boolean VisibleGrupoSucursal
        {
            get { return this.GrupoSucursal.Visible; }
            set { this.GrupoSucursal.Visible = value; }
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
        public DevExpress.XtraBars.BarItemVisibility VisibleCmbBodega_chk
        {
            get { return this.bei_bodega.Visibility; }
            set { this.bei_bodega.Visibility = value; }
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
        public DevExpress.XtraBars.BarItemVisibility VisiblecmbCategoria
        {
            get { return this.cmbCategoria.Visibility; }
            set { this.cmbCategoria.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisiblecmbLinea
        {
            get { return this.cmbLinea.Visibility; }
            set { this.cmbLinea.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility Visibletxt_num_transaccion
        {
            get { return this.txt_num_transaccion.Visibility; }
            set { this.txt_num_transaccion.Visibility = value; }
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
        public DevExpress.XtraBars.BarItemVisibility VisibleOptOpciones
        {
            get { return this.optOpciones.Visibility; }
            set { this.optOpciones.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisiblebtnConsultar
        {
            get { return this.btnConsultar.Visibility; }
            set { this.btnConsultar.Visibility = value; }
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
        
        public UCInv_MenuReportes()
        {
            InitializeComponent();
            event_btnImprimir_ItemClick += UCInv_MenuReportes_event_btnImprimir_ItemClick;
            event_btnSalir_ItemClick += UCInv_MenuReportes_event_btnSalir_ItemClick;
            event_tnConsultar_ItemClick += UCInv_MenuReportes_event_tnConsultar_ItemClick;
        }

        void UCInv_MenuReportes_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCInv_MenuReportes_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCInv_MenuReportes_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public List<int> Get_list_bodega_chk()
        {
            try
            {
                List<int> lst_chk_bodegas = new List<int>();

                foreach (var item in cmb_chk_bodega.Items.GetCheckedValues())
                {
                    string s_IdBodega = item.ToString().Substring(item.ToString().Length-10,10);
                    lst_chk_bodegas.Add(Convert.ToInt32(s_IdBodega));
                }

                return lst_chk_bodegas;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<int>();
            }
        }

        private void Cargar_subcentros_x_centro()
        {
            try
            {
                cmb_subcentro_costo_chk.Items.Clear();
                foreach (var item in lst_sub_centro_costo)
                {
                    cmb_subcentro_costo_chk.Items.Add(item.IdCentroCosto_sub_centro_costo, item.Centro_costo2);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<string> Get_list_sub_centro_chk()
        {
            try
            {
                List<string> Lista = new List<string>();
                foreach (var item in cmb_subcentro_costo_chk.Items.GetCheckedValues())
                {
                    Lista.Add(item.ToString());
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<string>();
            }
        }

        private void Cargar_bodegas_chk(List<tb_Bodega_Info> lstBodega)
        {
            try
            {
                cmb_chk_bodega.Items.Clear();                
                foreach (var item in lstBodega)
                {                    
                    if (item.IdBodega != 0)
                    {
                        string linea = item.bo_Descripcion + "                                                                                                                                                          " + item.IdBodega.ToString().PadLeft(10, '0');
                        cmb_chk_bodega.Items.Add(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UCInv_MenuReportes_Load(object sender, EventArgs e)
        {
            try
            {
                in_Producto_Info infoProducto = new in_Producto_Info();
                in_movi_inven_tipo_Info infoMoviTipi = new in_movi_inven_tipo_Info();
                cp_proveedor_Info infoProvee = new cp_proveedor_Info();
                in_categorias_Info InfoCategoria = new in_categorias_Info();
                in_linea_info InfoLinea = new in_linea_info();

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

                InfoCategoria.IdCategoria = "";
                InfoCategoria.ca_Categoria = "Todos";

                InfoLinea.IdLinea = 0;
                InfoLinea.nom_linea = "Todos";

                lstProductoInfo = busProducto.Get_list_Producto(param.IdEmpresa);
                lstProductoInfo.Add(infoProducto);
                cmbProducto_Grid.DataSource = lstProductoInfo.OrderBy(q => q.IdProducto).ToList();

                lstMoviTipiInfo = busMoviTip.Get_List_movi_inven_tipo(param.IdEmpresa);
                lstMoviTipiInfo.Add(infoMoviTipi);
                CmbTipoMov_Grid.DataSource = lstMoviTipiInfo.OrderBy(q => q.IdMovi_inven_tipo).ToList();

                listProveedor = busProveedor.Get_List_proveedor(param.IdEmpresa);
                listProveedor.Add(infoProvee);
                cmbProveedor_Grid.DataSource = listProveedor;

                ListCategoria = Bus_Categoria.Get_List_categorias(param.IdEmpresa);
                ListCategoria.Add(InfoCategoria);
                cmb_categoria.DataSource = ListCategoria;

                ListLinea = BusLinea.Get_List_Linea(param.IdEmpresa, "");
                ListLinea.Add(InfoLinea);
                cmb_Linea.DataSource = ListLinea;

                lst_centro_costo = bus_centro_costo.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);
                cmb_centro_costo.DataSource = lst_centro_costo;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSucursal.EditValue != null)
                {
                    int idSucursal = Convert.ToInt32(cmbSucursal.EditValue);
                    List<tb_Bodega_Info> Lista_bodega_temp = new List<tb_Bodega_Info>();
                    Lista_bodega_temp = lstBodegaInfo.Where(q => q.IdSucursal == idSucursal || q.IdBodega == 0).ToList();
                    cmbBodega_Grid.DataSource = null;
                    cmbBodega_Grid.DataSource = Lista_bodega_temp;

                    Cargar_bodegas_chk(Lista_bodega_temp);
                }
                else
                    cmbBodega_Grid.DataSource = lstBodegaInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbCategoria_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSucursal.EditValue != null)
                {
                    string idCategoria = Convert.ToString(cmbCategoria.EditValue);
                    List<in_linea_info> ListLinea_temp = new List<in_linea_info>();

                    ListLinea = BusLinea.Get_List_Linea(param.IdEmpresa, idCategoria);

                    ListLinea_temp = ListLinea.Where(q => q.IdCategoria.Contains(idCategoria)).ToList();
                    cmb_Linea.DataSource = null;
                    cmb_Linea.DataSource = ListLinea_temp;
                }
                else
                    cmb_Linea.DataSource = ListLinea;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public tb_Sucursal_Info Get_info_sucursal()
        {
            try
            {
                tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();
                if (cmbSucursal.EditValue != null)
                {
                    info_sucursal = lstSucuInfo.FirstOrDefault(q => q.IdSucursal == Convert.ToInt32(cmbSucursal.EditValue));
                }
                else
                    info_sucursal = null;
                return info_sucursal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public tb_Bodega_Info Get_info_bodega()
        {
            try
            {
                tb_Bodega_Info info_bodega = new tb_Bodega_Info();

                if (cmbSucursal.EditValue != null && cmbBodega.EditValue != null)
                {
                    info_bodega = lstBodegaInfo.FirstOrDefault(q => q.IdSucursal == Convert.ToInt32(cmbSucursal.EditValue) && q.IdBodega == Convert.ToInt32(cmbBodega.EditValue));
                }
                else
                    info_bodega = null;
                return info_bodega;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public in_Producto_Info Get_info_producto()
        {
            try
            {
                in_Producto_Info info_producto = new in_Producto_Info();

                if (cmbProducto.EditValue != null)
                {
                    info_producto = lstProductoInfo.FirstOrDefault(q => q.IdProducto == Convert.ToDecimal(cmbProducto.EditValue));
                }
                else
                    info_producto = null;
                return info_producto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public cp_proveedor_Info Get_info_proveedor()
        {
            try
            {
                if (cmbProveedor.EditValue == null)
                    return null;
                info_proveedor = listProveedor.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdProveedor == Convert.ToDecimal(cmbProveedor.EditValue));
                return info_proveedor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public ct_Centro_costo_Info Get_info_centro_costo()
        {
            try
            {
                if (beiCentro_costo.EditValue == null) 
                    return null;
                info_centro_costo = lst_centro_costo.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdCentroCosto == beiCentro_costo.EditValue.ToString());
                return info_centro_costo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        private void beiCentro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (beiCentro_costo.EditValue == null)
                    lst_sub_centro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();
                else
                    lst_sub_centro_costo = bus_sub_centro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa,beiCentro_costo.EditValue.ToString());
                Cargar_subcentros_x_centro();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
