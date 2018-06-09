using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using DevExpress.Utils;


namespace Core.Erp.Reportes.Controles
{
    public partial class UCFa_Menu_Reportes : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Bus busSucursal = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> lstSucuInfo = new List<tb_Sucursal_Info>();
        fa_catalogo_Bus CatalogoBus = new fa_catalogo_Bus();
        List<fa_catalogo_Info> lstCatalogo = new List<fa_catalogo_Info>();
        List<fa_catalogo_Info> lstNota = new List<fa_catalogo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<fa_TipoNota_Info> lstTipoNota = new List<fa_TipoNota_Info>();
        fa_TipoNota_Bus busTipoNota = new fa_TipoNota_Bus();
        List<fa_Vendedor_Info> ListVendedor = new List<fa_Vendedor_Info>();
        fa_Vendedor_Bus BusVendedor = new fa_Vendedor_Bus();
        List<string> lst_tipoNota = new List<string>();
        fa_catalogo_Info Info_Nota = new fa_catalogo_Info();
        fa_Vendedor_Info Info_Vendedor = new fa_Vendedor_Info();

        List<fa_Cliente_Info> lstCliente = new List<fa_Cliente_Info>();
        fa_Cliente_Bus busCliente = new fa_Cliente_Bus();

        List<fa_motivo_venta_Info> lstInfoMotiVta = new List<fa_motivo_venta_Info>();
        fa_motivo_venta_Bus busMotiVta = new fa_motivo_venta_Bus();

        public delegate void delegate_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnConsultar_ItemClick event_btnConsultar_ItemClick;

        public delegate void delegate_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImprimir_ItemClick event_btnImprimir_ItemClick;

        public delegate void delegate_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnSalir_ItemClick event_btnSalir_ItemClick;
            

        #region Visible y Enable

        public DevExpress.XtraBars.BarItemVisibility VisiblechkCombo_Tipo_nota
        {
            get { return this.chkCombo_Tipo_nota.Visibility; }
            set { this.chkCombo_Tipo_nota.Visibility = value; } 
        }

        public Boolean VisibleGrupoSucursal
        {
            get { return this.ribbonPageGroupSucursal.Visible; }
            set { this.ribbonPageGroupSucursal.Visible = value; }
        }

        public Boolean VisibleGrupoFecha
        {
            get { return this.ribbonPageGroupFecha.Visible; }
            set { this.ribbonPageGroupFecha.Visible = value; }
        }

        public Boolean VisibleGrupoOtros
        {
            get { return this.ribbonPageGroupOtros.Visible; }
            set { this.ribbonPageGroupOtros.Visible = value; }
        }

        public Boolean VisibleTipo
        {
            get { return this.ribbonPageGroup1.Visible; }
            set { this.ribbonPageGroup1.Visible = value; }
        }
        


        public Boolean VisibleGrupoMotivo
        {
            get { return this.ribbonTipoNota.Visible; }
            set { this.ribbonTipoNota.Visible = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbTipoDocumento
        {
            get { return this.cmbTipoDocumento.Visibility; }
            set { this.cmbTipoDocumento.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisiblecmbVendedor
        {
            get { return this.cmbVendedor.Visibility; }
            set { this.cmbVendedor.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbMotivo
        {
            get { return this.cmbMotivo.Visibility; }
            set { this.cmbMotivo.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visiblecmb_TipoNota
        {
            get { return this.cmb_TipoNota.Visibility; }
            set { this.cmb_TipoNota.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbSucursal
        {
            get { return this.cmbSucursal.Visibility; }
            set { this.cmbSucursal.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbCliente
        {
            get { return this.cmbCliente.Visibility; }
            set { this.cmbCliente.Visibility = value; }
        }


        public DevExpress.XtraBars.BarItemVisibility VisibleCmbTipoPago
        {
            get { return this.cmbTipoPago.Visibility; }
            set { this.cmbTipoPago.Visibility = value; }
        }


        public DevExpress.XtraBars.BarItemVisibility VisibleCmbTipoProducto
        {
            get { return this.cmbTipoProducto.Visibility; }
            set { this.cmbTipoProducto.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleBotonImprimir
        {
            get { return this.btnImprimir.Visibility; }
            set { this.btnImprimir.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleBotonRefrescar
        {
            get { return this.btnConsultar.Visibility; }
            set { this.btnConsultar.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleBotonSalir
        {
            get { return this.btnSalir.Visibility; }
            set { this.btnSalir.Visibility = value; }
        }

        public Boolean EnableBotonImprimir
        {
            get { return this.btnImprimir.Enabled; }
            set { this.btnImprimir.Enabled = value; }
        }

        public Boolean EnableBotonRefrescar
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
            

        public UCFa_Menu_Reportes()
        {
            InitializeComponent();
            event_btnConsultar_ItemClick += UCFa_Menu_Reportes_event_btnConsultar_ItemClick;
            event_btnImprimir_ItemClick += UCFa_Menu_Reportes_event_btnImprimir_ItemClick;
            event_btnSalir_ItemClick += UCFa_Menu_Reportes_event_btnSalir_ItemClick;
        }

        void UCFa_Menu_Reportes_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void UCFa_Menu_Reportes_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void UCFa_Menu_Reportes_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }



        private void UCFa_Menu_Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDesde.EditValue = DateTime.Now.AddMonths(-1);
                dtpHasta.EditValue = DateTime.Now.AddMonths(1);

                Info_Nota.IdCatalogo = "";
                Info_Nota.Nombre = "TODOS";
                Info_Vendedor.IdVendedor = 0;
                Info_Vendedor.Ve_Vendedor = "TODOS";
                
                lstSucuInfo = busSucursal.Get_List_Sucursal_Todos(param.IdEmpresa);
                gridSucursal.DataSource = lstSucuInfo;

                lstCatalogo = CatalogoBus.Get_List_catalogo(8);
                gridTipoDocumento.DataSource = lstCatalogo;

                lstNota = CatalogoBus.Get_List_catalogo(12);
                
                lstNota.Add(Info_Nota);
                cmbTipoNota.DataSource = lstNota;

                lstCliente = busCliente.Get_List_Cliente(param.IdEmpresa);
                gridViewCliente.DataSource = lstCliente;

                lstTipoNota = busTipoNota.Get_List_TipoNota_Todos();
                gridViewMotivo.DataSource = lstTipoNota;

                lst_tipoNota = new List<string>();
                foreach (var item in lstTipoNota)
                {
                    if (item.no_Descripcion!="TODOS")
                    {
                        string tipo_nota = item.no_Descripcion + "                                                                                                                                                           */" + item.IdTipoNota.ToString("0000");
                        lst_tipoNota.Add(tipo_nota);
                    }                    
                }
                checkedCombo_TipoNota.DataSource = lst_tipoNota;


                lstInfoMotiVta = busMotiVta.Get_List_fa_motivo_venta(param.IdEmpresa);
                gridViewTipoItem.DataSource = lstInfoMotiVta;

                ListVendedor = BusVendedor.Get_List_Vendedores(param.IdEmpresa);
                ListVendedor.Add(Info_Vendedor);
                cmb_Vendedor.DataSource = ListVendedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }

            

        }

        public void cargarTipoDocumento_NC_ND()
        {
            try
            {                
                var s = from q in lstCatalogo where q.IdCatalogo == "NTCR" || q.IdCatalogo == "NTDB" select q;
                gridTipoDocumento.DataSource = new List<fa_catalogo_Info>(s);
                cmbTipoDocumento.EditValue = "NTCR";
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
                event_btnConsultar_ItemClick(sender, e);
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

        public List<int> Get_lst_chk_Tipo_nota()
        {
            try
            {
                List<int> lst_check = new List<int>();
                int Id = 0;
                foreach (var item in checkedCombo_TipoNota.Items.GetCheckedValues().ToList())
                {
                    Id = Convert.ToInt32(item.ToString().Substring(item.ToString().Length-4, 4));
                    lst_check.Add(Id);
                }

                return lst_check;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<int>();
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



    }
}
