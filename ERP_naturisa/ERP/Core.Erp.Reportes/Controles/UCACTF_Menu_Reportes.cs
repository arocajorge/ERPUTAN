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
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Reportes.Compras;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCACTF_Menu_Reportes : UserControl
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<tb_Sucursal_Info> lstSucuInfo = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus busSucursal = new tb_Sucursal_Bus();
        Af_Activo_fijo_tipo_Bus bus_tipo_ActFij = new Af_Activo_fijo_tipo_Bus();
        List<Af_Activo_fijo_tipo_Info> lista_tipo_activo_fijo = new List<Af_Activo_fijo_tipo_Info>();
        Af_Activo_fijo_tipo_Info info_Tip_Af = new Af_Activo_fijo_tipo_Info();
        Af_Tipo_Depreciacion_Bus bus_depre = new Af_Tipo_Depreciacion_Bus();
        List<Af_Tipo_Depreciacion_Info> lista_depre = new List<Af_Tipo_Depreciacion_Info>();
        Af_Tipo_Depreciacion_Info info_Depre = new Af_Tipo_Depreciacion_Info();
        Af_Catalogo_Bus busCatalogo = new Af_Catalogo_Bus();
        List<Af_Catalogo_Info> lstCatalogo = new List<Af_Catalogo_Info>();
        Af_Catalogo_Info info_Cata = new Af_Catalogo_Info();
        ct_Periodo_Bus busPeriodo = new ct_Periodo_Bus();
        List<ct_Periodo_Info> lstPeriodo = new List<ct_Periodo_Info>();
        Af_Activo_fijo_Bus busActivoFijo = new Af_Activo_fijo_Bus();
        List<Af_Activo_fijo_Info> lstActivoFijo = new List<Af_Activo_fijo_Info>();
        Af_Activo_fijo_Info info_AF = new Af_Activo_fijo_Info();
        XCOMP_Rpt007_Info.eAlerta eAlerta_info = new XCOMP_Rpt007_Info.eAlerta();
        string MensajeError = "";


        #region delegados
        public delegate void delegate_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImprimir_ItemClick event_btnImprimir_ItemClick;

        public delegate void delegate_btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnGenerar_ItemClick event_btnGenerar_ItemClick;

        public delegate void delegate_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnSalir_ItemClick event_btnSalir_ItemClick;

        public delegate void delegate_cmb_tipoActivo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_tipoActivo_EditValueChanged event_delegate_cmb_tipoActivo_EditValueChanged;

        #endregion

        #region visible_enable


        public Boolean VisibleGroupTipoQuiebre
        {
            get { return this.grp_Quiebre.Visible; }
            set { this.grp_Quiebre.Visible = value; }
        }
        public Boolean VisibleGroupFechaCorte_Sucursal
        {
            get { return this.grp_FechaCorte_Sucursal.Visible; }
            set { this.grp_FechaCorte_Sucursal.Visible = value; }
        }

            public Boolean VisibleGrupoSucursal
            {
                get { return this.grp_Sucursal_tipo.Visible; }
                set { this.grp_Sucursal_tipo.Visible = value; }
            }

            public Boolean VisibleGrupoTipo
            {
                get { return this.grp_TipoActivo.Visible; }
                set { this.grp_TipoActivo.Visible = value; }
            }
        
            public Boolean VisibleGrupoFecha
            {
                get { return this.grp_Rango_Fecha.Visible; }
                set { this.grp_Rango_Fecha.Visible = value; }
            }
        
            public Boolean VisibleGrupoBotones
            {
                get { return this.grp_Botones_Impre.Visible; }
                set { this.grp_Botones_Impre.Visible = value; }
            }
        
            public Boolean VisibleGrupoPeriodo
            {
                get { return this.grp_Periodo.Visible; }
                set { this.grp_Periodo.Visible = value; }
            }
        
            public Boolean VisibleGrupoSucursal_Departamento
            {
                get { return this.grp_sucu_depa.Visible; }
                set { this.grp_sucu_depa.Visible = value; }
            }
        
            public Boolean VisibleGrupoTipoActi_Categoria
            {
                get { return this.grp_TipoActivo_categ.Visible; }
                set { this.grp_TipoActivo_categ.Visible = value; }
            }
        
            public Boolean VisibleGrupoFechaCorte
            {
                get { return this.grp_fechaCorte.Visible; }
                set { this.grp_fechaCorte.Visible = value; }
            }
        
            public DevExpress.XtraBars.BarItemVisibility VisiblecmbMejoBaj_AF
            {
                get { return this.cmbMejoBaj_AF.Visibility; }
                set { this.cmbMejoBaj_AF.Visibility = value; }
            }
        
            public DevExpress.XtraBars.BarItemVisibility VisibleCmbActivoFijo
            {
                get { return this.barEditActivo.Visibility; }
                set { this.barEditActivo.Visibility = value; }
            }
        
            public DevExpress.XtraBars.BarItemVisibility VisibleCmbPeriodoIni
            {
                get { return this.barPeriodoIni.Visibility; }
                set { this.barPeriodoIni.Visibility = value; }
            }
        
            public DevExpress.XtraBars.BarItemVisibility VisibleCmbPeriodoFin
            {
                get { return this.barPeriodoFin.Visibility; }
                set { this.barPeriodoFin.Visibility = value; }
            }
        
            public DevExpress.XtraBars.BarItemVisibility VisibleCmbSucursal
            {
                get { return this.barEditItemSucursal.Visibility; }
                set { this.barEditItemSucursal.Visibility = value; }
            }
        
            public DevExpress.XtraBars.BarItemVisibility VisibleCmbTipoActivo
            {
                get { return this.barEditItemTipoActivo.Visibility; }
                set { this.barEditItemTipoActivo.Visibility = value; }
            }
        
            public DevExpress.XtraBars.BarItemVisibility VisibleCmbTipoDepre
            {
                get { return this.barEditItemTipo.Visibility; }
                set { this.barEditItemTipo.Visibility = value; }
            }
        
            public DevExpress.XtraBars.BarItemVisibility VisibleCmbEstado
            {
                get { return this.barEditItemEstado.Visibility; }
                set { this.barEditItemEstado.Visibility = value; }
            }
        
            public DevExpress.XtraBars.BarItemVisibility VisibleCmbFechaIni
            {
                get { return this.dtpFechaIni.Visibility; }
                set { this.dtpFechaIni.Visibility = value; }
            }

            public DevExpress.XtraBars.BarItemVisibility VisibleCmbFechaFin
            {
                get { return this.dtpFechaFin.Visibility; }
                set { this.dtpFechaFin.Visibility = value; }
            }        

            public DevExpress.XtraBars.BarItemVisibility VisibleBtnGenerar
            {
                get { return this.btnGenerar.Visibility; }
                set { this.btnGenerar.Visibility = value; }

            }
        
            public DevExpress.XtraBars.BarItemVisibility VisibleBtnImprimir
            {
                get { return this.btnImprimir.Visibility; }
                set { this.btnImprimir.Visibility = value; }
            }
        
            public DevExpress.XtraBars.BarItemVisibility VisibleBtnSalir
            {
                get { return this.btnSalir.Visibility; }
                set { this.btnSalir.Visibility = value; }
            }

            public DevExpress.XtraBars.BarItemVisibility VisiblecmbTipoImpresion
            {
                get
                {
                    return barEditItemTipoImpresion.Visibility;
                }
                set
                {
                    this.barEditItemTipoImpresion.Visibility = value;
                }
            }

            public Boolean EnableBotonImprimir
            {
                get { return this.btnImprimir.Enabled; }
                set { this.btnImprimir.Enabled = value; }
            }

            public Boolean EnableBotonGenerar
            {
                get { return this.btnGenerar.Enabled; }
                set { this.btnGenerar.Enabled = value; }
            }

            public Boolean EnableBotonSalir
            {
                get { return this.btnSalir.Enabled; }
                set { this.btnSalir.Enabled = value; }
            }
        #endregion


        public XCOMP_Rpt007_Info.eAlerta Get_Alerta_Info
            {
                get 
                {
                    eAlerta_info = ((XCOMP_Rpt007_Info.eAlerta)barEditItemAlert.EditValue == null) ? XCOMP_Rpt007_Info.eAlerta.Todos : (XCOMP_Rpt007_Info.eAlerta)barEditItemAlert.EditValue;
                    return eAlerta_info;
                }
            }
            
        public tb_Sucursal_Info Get_Sucursal_info
        {
                get
                {
                    return lstSucuInfo.FirstOrDefault(q => q.IdSucursal == (int)barEditItemSucursal.EditValue);
                }
        }

       
        public UCACTF_Menu_Reportes()
        {
            InitializeComponent();
            event_btnGenerar_ItemClick += UCACTF_Menu_Reportes_event_btnGenerar_ItemClick;
            event_btnImprimir_ItemClick += UCACTF_Menu_Reportes_event_btnImprimir_ItemClick;
            event_btnSalir_ItemClick += UCACTF_Menu_Reportes_event_btnSalir_ItemClick;
            event_delegate_cmb_tipoActivo_EditValueChanged += UCACTF_Menu_Reportes_event_delegate_cmb_tipoActivo_EditValueChanged;
            LlenarCombo_EnumerdoresAlerta();
        }

        public void LlenarCombo_EnumerdoresAlerta()
        {
            try
            {
                var query = (from int n in Enum.GetValues(typeof(Core.Erp.Reportes.Compras.XCOMP_Rpt007_Info.eAlerta))
                             select new
                             {
                                 n,
                                 key = Enum.GetName(typeof(Core.Erp.Reportes.Compras.XCOMP_Rpt007_Info.eAlerta), n)
                             });
                slue_Alerta.DataSource = query.ToList();
                slue_Alerta.DisplayMember = "key";
                slue_Alerta.ValueMember = "n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

            
        }

        void UCACTF_Menu_Reportes_event_delegate_cmb_tipoActivo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCACTF_Menu_Reportes_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCACTF_Menu_Reportes_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCACTF_Menu_Reportes_event_btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnGenerar_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UCACTF_Menu_Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();

                barEditItemFechaCorte.EditValue = DateTime.Now;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void CargarCombos()
        {
            try
            {
                 string msjError = "";
                dtpFechaIni.EditValue = DateTime.Now.AddMonths(-1);
                dtpFechaFin.EditValue = DateTime.Now.AddMonths(1);

                lstSucuInfo = busSucursal.Get_List_Sucursal_Todos(param.IdEmpresa);
                cmb_Sucursal.DataSource = lstSucuInfo;

                CargarInfo();

                lista_tipo_activo_fijo = bus_tipo_ActFij.Get_List_ActivoFijoTipo(param.IdEmpresa);
                lista_tipo_activo_fijo.Add(info_Tip_Af);
                cmb_tipoActivo.DataSource = lista_tipo_activo_fijo.OrderBy(q => q.IdActivoFijoTipo).ToList();
                barEditItemTipoActivo.EditValue = 0;

               
                lista_depre = bus_depre.Get_List_ActivoFijo(param.IdEmpresa);
                lista_depre.Add(info_Depre);
                cmb_Tipo_Depre.DataSource = lista_depre.OrderBy(q => q.IdTipoDepreciacion).ToList();

             
                lstCatalogo = busCatalogo.Get_List_Catalogo("TIP_ESTADO_AF");
                lstCatalogo.Add(info_Cata);
                cmb_Estado.DataSource = lstCatalogo.OrderBy(q => q.IdCatalogo).ToList();

                lstPeriodo = busPeriodo.Get_List_Periodo(param.IdEmpresa, ref msjError);             
                cmbPeriodoIni.DataSource = lstPeriodo;
                cmbPeriodoFin.DataSource = lstPeriodo;
                barPeriodoIni.EditValue = (DateTime.Today.Year.ToString()) + ((DateTime.Today.Month.ToString().Length == 1) ? "0" + DateTime.Today.Month.ToString() : DateTime.Today.Month.ToString());
                barPeriodoFin.EditValue = (DateTime.Today.Year.ToString()) + ((DateTime.Today.Month.ToString().Length == 1) ? "0" + DateTime.Today.Month.ToString() : DateTime.Today.Month.ToString());

                lstActivoFijo = busActivoFijo.Get_List_ActivoFijo(param.IdEmpresa, "");
                lstActivoFijo.Add(info_AF);
                cmbActivoFijo.DataSource = lstActivoFijo.OrderBy(q => q.IdActivoFijo).ToList();

                Af_Departamento_Bus BusDep = new  Af_Departamento_Bus();
                List<Af_Departamento_Info> listDep = new List<Af_Departamento_Info>();

                listDep =  BusDep.Get_List_Departamento(param.IdEmpresa);
                listDep.Add(new Af_Departamento_Info(param.IdEmpresa, 0, "A", "Todos"));
                cmb_departamento.DataSource = listDep;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public  void Cargar_categoria_AF(int IdTipoAF)
        {
            try
            {
                Af_Activo_fijo_Categoria_Bus BusCataAF = new Af_Activo_fijo_Categoria_Bus();
                List<Af_Activo_fijo_Categoria_Info> ListaCateAF = new List<Af_Activo_fijo_Categoria_Info>();
                ListaCateAF = BusCataAF.Get_List_Activo_fijo_Categoria(param.IdEmpresa,IdTipoAF, ref MensajeError);
                cmb_categoria_subGrupo.DataSource = ListaCateAF;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void CargarInfo()
        {
            try
            {
                info_Tip_Af.IdActivoFijoTipo = 0;
                info_Tip_Af.CodActivoFijo = "TOD";
                info_Tip_Af.Af_Descripcion2 = "Todos";

                info_Depre.IdTipoDepreciacion = 0;
                info_Depre.cod_tipo_depreciacion = "TOD";
                info_Depre.nom_tipo_depreciacion = "Todos";

                info_Cata.IdCatalogo = "0";
                info_Cata.IdTipoCatalogo = "TOD";
                info_Cata.Descripcion = "Todos";

                info_AF.IdActivoFijo = 0;
                info_AF.CodActivoFijo = "TOD";
                info_AF.Af_Nombre = "Todos";   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbPeriodoIni_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    
        private void cmbPeriodoFin_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        Boolean validarPeriodo()
        {
            try
            {
                ct_Periodo_Info PeriodoIni = lstPeriodo.Where(q => q.IdPeriodo == Convert.ToInt32(barPeriodoIni.EditValue)).First();
                //var PeriodoFin = (ct_Periodo_Info)barPeriodoFin.EditValue;
                ct_Periodo_Info PeriodoFin = lstPeriodo.Where(q => q.IdPeriodo == Convert.ToInt32(barPeriodoFin.EditValue)).First();
                
                int intPeriodo = 0;
                if (PeriodoFin.IdanioFiscal > PeriodoIni.IdanioFiscal)
                {
                    intPeriodo = PeriodoFin.IdanioFiscal - PeriodoIni.IdanioFiscal;
                    if (intPeriodo > 1)
                    {
                        MessageBox.Show("Los periodos a consultar no pueden ser mayor a 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (intPeriodo == 1)
                    {
                        if (PeriodoFin.pe_mes >= PeriodoIni.pe_mes)
                        {
                            MessageBox.Show("Los periodos a consultar no pueden ser mayor a 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else
                {
                    if (PeriodoFin.IdanioFiscal == PeriodoIni.IdanioFiscal)
                    {
                        if (PeriodoFin.pe_mes < PeriodoIni.pe_mes)
                        {
                            MessageBox.Show("El periodo final no puede ser menor que el inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El periodo final no puede ser menor que el inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
                return false;
            }
        }

        private void barEditItemTipo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barEditActivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int valor = Convert.ToInt32(barEditItemTipoActivo.EditValue);
        }

        private void cmb_tipoActivo_EditValueChanged(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(barEditItemTipoActivo.EditValue);
            event_delegate_cmb_tipoActivo_EditValueChanged(sender, e);

        }

        private void barEditItemTipoActivo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int IdTipoAF = 0;

                IdTipoAF = Convert.ToInt32(barEditItemTipoActivo.EditValue);
                barEditItemCategoria.EditValue = 0;
                Cargar_categoria_AF(IdTipoAF);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
    }
}
