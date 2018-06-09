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
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Collections;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;



namespace Core.Erp.Reportes.Controles
{
    public partial class UCCXC_MenuReportes : UserControl
    {
        #region Data
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Bus busSucursal = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> lstSucuInfo = new List<tb_Sucursal_Info>();
        cxc_cobro_tipo_Bus CobroBus = new cxc_cobro_tipo_Bus();
        List<cxc_cobro_tipo_Info> lstCobro = new List<cxc_cobro_tipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<fa_cliente_tipo_Info> lstTipoCli = new List<fa_cliente_tipo_Info>();
        fa_cliente_tipo_Bus busTipoCli = new fa_cliente_tipo_Bus();

        List<fa_Cliente_Info> lstCliente = new List<fa_Cliente_Info>();
        fa_Cliente_Bus busCliente = new fa_Cliente_Bus();
        List<fa_Vendedor_Info> lst_Vendedor = new List<fa_Vendedor_Info>();
        fa_Vendedor_Bus bus_Vendedor = new fa_Vendedor_Bus();
        BindingList<cxc_cobro_tipo_Info> Bind_List_Cobro = new BindingList<cxc_cobro_tipo_Info>();

        ct_Periodo_Bus BusPeriodo = new ct_Periodo_Bus();
        List<ct_Periodo_Info> listPeriodo = new List<ct_Periodo_Info>();


        #endregion 

        #region delegados
        public delegate void delegate_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnConsultar_ItemClick event_btnConsultar_ItemClick;

        public delegate void delegate_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImprimir_ItemClick event_btnImprimir_ItemClick;

        public delegate void delegate_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnSalir_ItemClick event_btnSalir_ItemClick;

        public delegate void delegate_btnGenerar_File_txt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnGenerar_File_txt_ItemClick event_btnGenerar_File_txt_ItemClick;

        
        

        #endregion 


        #region
        public Boolean VisibleGrupoSucursal
        {
            get { return this.GrupoSucursal.Visible; }
            set { this.GrupoSucursal.Visible = value; }
        }

        public Boolean VisibleGrupoVendedorCliente
        {
            get { return this.GrupoVendedorCliente.Visible; }
            set { this.GrupoVendedorCliente.Visible = value; }
        }

        public Boolean VisibleGrupoTipo
        {
            get { return this.GrupoTipo.Visible; }
            set { this.GrupoTipo.Visible = value; }
        }

        public Boolean VisibleGrupoFecha
        {
            get { return this.GrupoFecha.Visible; }
            set { this.GrupoFecha.Visible = value; }
        }

        public Boolean VisibleGrupoBusqueda
        {
            get { return this.GrupoBusqueda.Visible; }
            set { this.GrupoBusqueda.Visible = value; }
        }



        public DevExpress.XtraBars.BarItemVisibility VisibleCmbPeriodo
        {
            get { return this.bei_Periodo.Visibility; }
            set { this.bei_Periodo.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbSucursal
        {
            get { return this.beiSucursal.Visibility; }
            set { this.beiSucursal.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbCliente
        {
            get { return this.beiCliente.Visibility; }
            set { this.beiCliente.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbVendedor
        {
            get { return this.beiVendedor.Visibility; }
            set { this.beiVendedor.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbTipoCobro
        {
            get { return this.beiTipoCobro.Visibility; }
            set { this.beiTipoCobro.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisiblebeiDiasCredito
        {
            get { return this.beiDiasCredito.Visibility; }
            set { this.beiDiasCredito.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleTipoCobro
        {
            get { return this.BiTipoCobro.Visibility; }
            set { this.BiTipoCobro.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleCmbTipoCliente
        {
            get { return this.beiTipoCliente.Visibility; }
            set { this.beiTipoCliente.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleFechaDesde
        {
            get { return this.dtpDesde.Visibility; }
            set { this.dtpDesde.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleFechaHasta
        {
            get { return this.dtpHasta.Visibility; }
            set { this.dtpHasta.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleRbtFiltro
        {
            get { return this.beiOpciones.Visibility; }
            set { this.beiOpciones.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleBtnImprimir
        {
            get { return this.btnImprimir.Visibility; }
            set { this.btnImprimir.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleBtnGenerar
        {
            get { return this.btnGenerarReporte.Visibility; }
            set { this.btnGenerarReporte.Visibility = value; }
        }
       
        public DevExpress.XtraBars.BarItemVisibility VisibleBtnSalir
        {
            get { return this.btnSalir.Visibility; }
            set { this.btnSalir.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleBtnGenerar_txt
        {
            get { return this.btnGenerar_File_txt.Visibility; }
            set { this.btnGenerar_File_txt.Visibility = value; }
        }



        public string set_get_btnGenerar_File_txt_Caption
        {
            get { return this.btnGenerar_File_txt.Caption; }
            set { this.btnGenerar_File_txt.Caption = value; }
        }
       

        public Boolean EnableBotonImprimir
        {
            get { return this.btnImprimir.Enabled; }
            set { this.btnImprimir.Enabled = value; }
        }

        public Boolean EnableBotonGenerar
        {
            get { return this.btnGenerarReporte.Enabled; }
            set { this.btnGenerarReporte.Enabled = value; }
        }

        public Boolean EnableBotonSalir
        {
            get { return this.btnSalir.Enabled; }
            set { this.btnSalir.Enabled = value; }
        }

        public Boolean VisibleGrupoCheck
        {
            get { return this.GrupoChk.Visible; }
            set { this.GrupoChk.Visible = value; }
        }

        public string TextCheck
        {
            get { return this.barEditItemChk.Caption; }
            set { this.barEditItemChk.Caption = value; }
        }
                
        #endregion 

        public UCCXC_MenuReportes()
        {
            InitializeComponent();
            event_btnConsultar_ItemClick += UCCXC_Menu_Reportes_event_btnConsultar_ItemClick;
            event_btnImprimir_ItemClick += UCCXC_Menu_Reportes_event_btnImprimir_ItemClick;
            event_btnSalir_ItemClick += UCCXC_Menu_Reportes_event_btnSalir_ItemClick;
            event_btnGenerar_File_txt_ItemClick += UCCXC_MenuReportes_event_btnGenerar_File_txt_ItemClick;
            btnGenerar_File_txt.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            bei_Periodo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        void UCCXC_MenuReportes_event_btnGenerar_File_txt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        
        void UCCXC_Menu_Reportes_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCCXC_Menu_Reportes_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCCXC_Menu_Reportes_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void UCCXC_MenuReportes_Load(object sender, EventArgs e)
        {
            try
            {
                string msg="";

                fa_cliente_tipo_Info Info = new fa_cliente_tipo_Info();
                dtpDesde.EditValue = DateTime.Now.AddMonths(-1);
                dtpHasta.EditValue = DateTime.Now.AddMonths(1);

                lstSucuInfo = busSucursal.Get_List_Sucursal_Todos(param.IdEmpresa);
                this.risSucursal.DataSource = lstSucuInfo;

                

                lst_Vendedor = bus_Vendedor.Get_List_Vendedores(param.IdEmpresa);
                cmbVendedor.DataSource = lst_Vendedor;
                cmbVendedor.ValueMember = "IdVendedor";
                cmbVendedor.DisplayMember = "Ve_Vendedor";


                lstCobro = CobroBus.Get_List_Cobro_Tipo_Todos();
                Bind_List_Cobro = new BindingList<cxc_cobro_tipo_Info>(lstCobro);
                this.risTipoCobro.DataSource = lstCobro;
                this.chkTipoCobro.DataSource = Bind_List_Cobro;

                lstCliente = busCliente.Get_List_Cliente(param.IdEmpresa);
                this.risCliente.DataSource = lstCliente;
                beiOpciones.EditValue = "x_fecha";

                lstTipoCli = busTipoCli.Get_List_fa_cliente_tipo(param.IdEmpresa);
                Info.IdEmpresa = param.IdEmpresa;
                Info.Idtipo_cliente = 0;
                Info.Descripcion_tip_cliente = "Todos";
                lstTipoCli.Add(Info);

                cmbTipoCli.DataSource = lstTipoCli;
                beiTipoCliente.EditValue = Info.Idtipo_cliente;

                
                listPeriodo = BusPeriodo.Get_List_Periodo(param.IdEmpresa , ref msg);

                cmb_periodo.DataSource = listPeriodo;
                bei_Periodo.EditValue = (DateTime.Now.Year * 100) + DateTime.Now.Month;
                

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }            
        }

        private void btnGenerarReporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void beiOpciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void repositoryItemRadioGroup1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void BiTipoCobro_EditValueChanged(object sender, EventArgs e)
        {

        }

        public List<string> Get_list_cobros_chequeados()
        {
            List<string> lista = new List<string>();
            var listIdTipoCobro_Cheked = (from CheckedListBoxItem item in chkTipoCobro.Items
                                          where item.CheckState == CheckState.Checked
                                          select (string)item.Value).ToArray();


            foreach (var item in listIdTipoCobro_Cheked)
            {
                lista.Add(item.ToString());
            }

            return lista;
        }

        private void btnGenerar_File_txt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnGenerar_File_txt_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void cmb_periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                    
            }
            catch (Exception ex)
            {

            }
        }

        private void barItem_periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bei_Periodo.EditValue != null)
                {
                    ct_Periodo_Info InfoP = new ct_Periodo_Info();
                    InfoP  =listPeriodo.FirstOrDefault(v => v.IdPeriodo == Convert.ToInt32(bei_Periodo.EditValue));
                    dtpDesde.EditValue = InfoP.pe_FechaIni;
                    dtpHasta.EditValue = InfoP.pe_FechaFin;
                }


            }
            catch (Exception ex)
            {
                
                
            }
        }
    }
}
