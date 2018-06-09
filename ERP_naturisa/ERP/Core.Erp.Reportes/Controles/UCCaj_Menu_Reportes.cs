using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Caja;
using Core.Erp.Business.Caja;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCCaj_Menu_Reportes : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        #region Visibilidad

        public DevExpress.XtraBars.BarItemVisibility Visiblecmb_TipoIngEgr
        {
            get { return this.cmb_TipoIngEgr.Visibility; }
            set { this.cmb_TipoIngEgr.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visiblebei_punto_cargo
        {
            get { return this.bei_punto_cargo.Visibility; }
            set { this.bei_punto_cargo.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visiblecmb_Beneficiario
        {
            get { return this.cmb_Beneficiario.Visibility; }
            set { this.cmb_Beneficiario.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility Visibletxt_IdConciliacion
        {
            get { return this.txt_IdConciliacion.Visibility; }
            set { this.txt_IdConciliacion.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility Visiblecmb_TipoFlujo
        {
            get { return this.cmb_TipoFlujo.Visibility; }
            set { this.cmb_TipoFlujo.Visibility = value; }
        }
        public Boolean VisibleGrupoBeneficiario_flujo
        {
            get { return this.GrupoBeneficiario_flujo.Visible; }
            set { this.GrupoBeneficiario_flujo.Visible = value; }
        }
        #endregion

        #region Variables
        //informacion para el beneficiario
        vwtb_persona_beneficiario_Bus busPersona = new vwtb_persona_beneficiario_Bus();
        List<vwtb_persona_beneficiario_Info> list_Beneficiario = new List<vwtb_persona_beneficiario_Info>();
        vwtb_persona_beneficiario_Info Info_pers = new vwtb_persona_beneficiario_Info();
        //informaciòn de las cajas
        caj_Caja_Bus BusCaja = new caj_Caja_Bus();
        List<caj_Caja_Info> ListCaja = new List<caj_Caja_Info>();
        caj_Caja_Info Info_Caja = new caj_Caja_Info();

        //información de los tipos de movimientos
        ct_Cbtecble_tipo_Bus Bus_TipoCbte = new ct_Cbtecble_tipo_Bus();
        List<ct_Cbtecble_tipo_Info> ListTipo_Cbte = new List<ct_Cbtecble_tipo_Info>();
        ct_Cbtecble_tipo_Info Info_TipoCbte = new ct_Cbtecble_tipo_Info();

        //Información del tipo de flujo
        ba_TipoFlujo_Bus BusTipoFlujo = new ba_TipoFlujo_Bus();
        List<ba_TipoFlujo_Info> List_TipoFlujo = new List<ba_TipoFlujo_Info>();
        ba_TipoFlujo_Info Info_TipoFlujo = new ba_TipoFlujo_Info();

        List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        string MensajeError = "";

        #region Delegados
        public delegate void delegate_btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnGenerar_ItemClick event_btnGenerar_ItemClick;

        public delegate void delegate_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnGenerar_ItemClick event_btnSalir_ItemClick;

        #endregion
        #endregion

        public UCCaj_Menu_Reportes()
        {
            InitializeComponent();
            event_btnGenerar_ItemClick += UCCaj_Menu_Reportes_event_btnGenerar_ItemClick;
            event_btnSalir_ItemClick += UCCaj_Menu_Reportes_event_btnSalir_ItemClick;
        }

        public int get_cmbCaja()
        {
            if (cmb_Caja.EditValue != null || cmb_Caja.EditValue != "")
                return Convert.ToInt32(cmb_Caja.EditValue);
            else
                return 0;
        }

        public int get_TipoMovi()
        {
            if (this.cmb_TipoMovi.EditValue != null || cmb_TipoMovi.EditValue != "")
                return Convert.ToInt32(this.cmb_TipoMovi.EditValue);
            else
                return 0;
        }

        public string get_TipoIngrEgr()
        {
            if (cmb_TipoIngEgr.EditValue != null || cmb_TipoIngEgr.EditValue != "")
                return Convert.ToString(cmb_TipoIngEgr.EditValue);
            else
                return "Todos";
        }


        public string get_Id_Beneficiario()
        {
            if (cmb_Beneficiario.EditValue != null || cmb_Beneficiario.EditValue != "")
                return Convert.ToString(this.cmb_Beneficiario.EditValue);
            else
                return "";
        }


        public vwtb_persona_beneficiario_Info get_Info_Beneficiario()
        {
            vwtb_persona_beneficiario_Info Info= new vwtb_persona_beneficiario_Info();
            Info = list_Beneficiario.FirstOrDefault(v => v.IdBeneficiario == Convert.ToString(cmb_Beneficiario.EditValue));
            return Info;
        }

        public int get_TipoFlujo()
        {
            if (cmb_TipoFlujo.EditValue != null || cmb_TipoFlujo.EditValue != "")
                return Convert.ToInt32(cmb_TipoFlujo.EditValue);
            else
                return 0;
        }

        public DateTime get_FechaIni()
        {
            return Convert.ToDateTime(this.dtFechaIni.EditValue);
        }

        public DateTime get_FechaFin()
        {
            return Convert.ToDateTime(this.dtFechaFin.EditValue);
        }

        public void Cargar_Combos()
        {
            try
            {
                dtFechaIni.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtFechaFin.EditValue = DateTime.Now;

                list_Beneficiario = busPersona.Get_List_PersonaBeneficiario(param.IdEmpresa);
                Info_pers.IdBeneficiario = "";
                Info_pers.Nombre = "Todos";
                list_Beneficiario.Add(Info_pers);
                this.cmbBeneficiario.DataSource = list_Beneficiario;
                cmbBeneficiario.ValueMember = "IdBeneficiario";
                cmbBeneficiario.DisplayMember = "Nombre";
                cmb_Beneficiario.EditValue = "";

                ListCaja = BusCaja.Get_list_caja(param.IdEmpresa, ref MensajeError);
                Info_Caja.IdCaja = 0;
                Info_Caja.ca_Descripcion = "Todos";
                ListCaja.Add(Info_Caja);
                cmbCaja.DataSource = ListCaja;
                cmbCaja.ValueMember = "IdCaja";
                cmbCaja.DisplayMember = "ca_Descripcion";
                cmb_Caja.EditValue = 0;

                ListTipo_Cbte = Bus_TipoCbte.Get_list_Cbtecble_tipo(param.IdEmpresa,ref MensajeError);
                Info_TipoCbte.IdTipoCbte = 0;
                Info_TipoCbte.tc_TipoCbte = "Todos";
                ListTipo_Cbte.Add(Info_TipoCbte);
                cmbTipoMovi.DataSource = ListTipo_Cbte;
                cmbTipoMovi.ValueMember = "IdTipoCbte";
                cmbTipoMovi.DisplayMember = "tc_TipoCbte";
                cmb_TipoMovi.EditValue = 0;

                List_TipoFlujo = BusTipoFlujo.Get_List_TipoFlujo(param.IdEmpresa);
                Info_TipoFlujo.IdTipoFlujo = 0;
                Info_TipoFlujo.Descricion = "Todos";
                List_TipoFlujo.Add(Info_TipoFlujo);
                cmbTipoFlujo.DataSource = List_TipoFlujo;
                cmbTipoFlujo.ValueMember = "IdTipoFlujo";
                cmbTipoFlujo.DisplayMember = "Descricion";
                cmb_TipoFlujo.EditValue = 0;

                cmb_TipoIngEgr.EditValue = "Todos";

                lst_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_punto_cargo.DataSource = lst_punto_cargo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #region Eventos Delegados

        void UCCaj_Menu_Reportes_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void UCCaj_Menu_Reportes_event_btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        #endregion

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

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ParentForm.Close();
                event_btnSalir_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UCCaj_Menu_Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
