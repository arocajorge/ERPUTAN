using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCBa_Menu_Reportes : UserControl
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        #region Delegados

       /* public delegate void delegate_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImprimir_ItemClick event_btnImprimir_ItemClick;*/

        public delegate void delegate_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnRefrescar_ItemClick event_btnRefrescar_ItemClick;

        public delegate void delegate_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnsalir_ItemClick event_btnsalir_ItemClick;
        #endregion
        #region Data
        List<ba_Banco_Cuenta_Info> Banco_Cuenta_List = new List<ba_Banco_Cuenta_Info>();
        ba_Banco_Cuenta_Bus bancoB = new ba_Banco_Cuenta_Bus();
        //ba_Banco_Cuenta_Info bancos;
        List<ba_Cbte_Ban_tipo_Info> Banco_Tipo_Cbte_List = new List<ba_Cbte_Ban_tipo_Info>();
        ba_Cbte_Ban_tipo_Bus bancoCbteTipoB = new ba_Cbte_Ban_tipo_Bus();
        
        ba_TipoFlujo_Bus bus_tipo_flujo = new ba_TipoFlujo_Bus();
        List<ba_TipoFlujo_Info> lstTipoFlujo = new List<ba_TipoFlujo_Info>();

        tb_persona_bus busPersona = new tb_persona_bus();
        List<tb_persona_Info> pers = new List<tb_persona_Info>();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public UCBa_Menu_Reportes()
        {
            InitializeComponent();
            event_btnRefrescar_ItemClick += UCBa_Menu_Reportes_event_btnRefrescar_ItemClick;
            event_btnsalir_ItemClick += UCBa_Menu_Reportes_event_btnsalir_ItemClick;
            this.Dock = DockStyle.Top;
        }
        #endregion

        #region Void Delegados



        void UCBa_Menu_Reportes_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCBa_Menu_Reportes_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCBa_Menu_Reportes_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        #endregion
        #region propiedades

        public DevExpress.XtraBars.BarItemVisibility Visible_bei_chk_TipoFlujo
        {
            get { return this.bei_chk_TipoFlujo.Visibility; }
            set { this.bei_chk_TipoFlujo.Visibility = value; } 
        }

        public Boolean Visible_Grupo_tipo_flujo
        {
            get { return this.GrupoTipoFlujo.Visible; }
            set { this.GrupoTipoFlujo.Visible = value; }
        }
        public string Caption_chkImpreso { get { return this.chkImpreso.Caption; } set { this.chkImpreso.Caption = value; } }
        public Boolean Visible_GroupBancos
        {
            get { return this.GroupBancos.Visible; }
            set { this.GroupBancos.Visible = value; }
        }


        public Boolean Visible_GrupoFechas
        {
            get { return this.GroupFechas.Visible; }
            set { this.GroupFechas.Visible = value; }
        }

        public Boolean Visible_Beneficiario
        {
            get { return this.GroupBeneficiario.Visible; }
            set { this.GroupBeneficiario.Visible= value; }
        }

        public Boolean Visible_Chks
        {
            get { return this.GroupChks.Visible; }
            set { this.GroupChks.Visible = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_Cheques
        {
            get { return this.txtCheque.Visibility; }
            set { this.txtCheque.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_cmbTipoDocumento
        {
            get { return this.cmbTipoDocumento.Visibility; }
            set { this.cmbTipoDocumento.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_chkFacs
        {
            get { return this.chkFacs.Visibility; }
            set { this.chkFacs.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_chkImpreso
        {
            get { return this.chkImpreso.Visibility; }
            set { this.chkImpreso.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_bei_chk_Detallado
        {
            get { return this.bei_chk_Detallado.Visibility; }
            set { this.bei_chk_Detallado.Visibility = value; }
        }

        public Boolean Enable_Doc
        {
            get { return this.cmbTipoDocumento.Enabled; }
            set { this.cmbTipoDocumento.Enabled = value; }
        }

        public bool get_chkfaks()
        {
            return Convert.ToBoolean(this.chkFacs.EditValue);
        }
        public bool get_chkImpreso()
        {
            return Convert.ToBoolean(this.chkImpreso.EditValue);
        }
        public int get_cmbBeneficiario()
        {
            return Convert.ToInt32(this.cmbBeneficiario.EditValue);
        }
        tb_persona_Info info = new tb_persona_Info();

       // public string get_cmbNomBeneficiario()
        public tb_persona_Info get_cmbNomBeneficiario()
        {
            if (cmbBeneficiario.EditValue != null)
                // return pers.First(v => v.IdPersona == Convert.ToDecimal(this.cmbBeneficiario.EditValue)).pe_nombreCompleto;
                return pers.First(v => v.IdPersona == Convert.ToDecimal(this.cmbBeneficiario.EditValue));
            else
                // return "TODOS";
                return info = new tb_persona_Info();
        }
        //
        public int? idBancos{ get; set; }
        public int? get_idBanco()
        {
            try
            {
                idBancos = Convert.ToInt32(this.cmbBanco.EditValue);
                return idBancos;
            }
            catch (Exception ex)
            {
                return idBancos;
            }
        }
        public DateTime get_FchIni()
        {
            return Convert.ToDateTime(this.dtpDesde.EditValue);
        }
        public DateTime get_FchFin()
        {
            return Convert.ToDateTime(this.dtpHasta.EditValue);
        }
        public bool get_Mostrar_detallado()
        {
            try
            {
                return Convert.ToBoolean(bei_chk_Detallado.EditValue);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string get_tipoCbtes()
        {
            if (cmbTipoDocumento.EditValue != null)
                return Convert.ToString(this.cmbTipoDocumento.EditValue);
            else
                return "";
        }

        public string cmbTipoDoc
        {
            get { return Convert.ToString(this.cmbTipoDocumento.EditValue); }
            set { this.cmbTipoDocumento.EditValue = value; }
        }

        public string caption_check
        {
            get { return this.chkFacs.Caption; }
            set { this.chkFacs.Caption = value; }
        }
        public string get_NomBanco()
        {
            if (cmbBanco.EditValue != null)
                return Banco_Cuenta_List.First(v => v.IdBanco == Convert.ToInt32(this.cmbBanco.EditValue)).ba_descripcion;
            else
                return "TODOS LOS BANCOS";
        }
        public string get_DesTipoCbtes()
        {
            if (cmbTipoDocumento.EditValue != null && cmbTipoDocumento.EditValue != "")
            return  Banco_Tipo_Cbte_List.First(v => v.CodTipoCbteBan == Convert.ToString(this.cmbTipoDocumento.EditValue)).Descripcion;
            else
                return "TODOS LOS DOCUMENTOS";
        }
        #endregion
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void UCBa_Menu_Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDesde.EditValue = DateTime.Now.AddMonths(-1);
                dtpHasta.EditValue = DateTime.Now.AddMonths(1);

                Banco_Tipo_Cbte_List = bancoCbteTipoB.Get_List_Cbte_Ban_tipo();
                this.gridDocumento.DataSource = Banco_Tipo_Cbte_List;

                Banco_Cuenta_List = bancoB.Get_list_Banco_Cuenta(param.IdEmpresa);
                gridBanco.DataSource = Banco_Cuenta_List;

                pers = busPersona.Get_List_Persona();
                gridBeneficiario.DataSource = pers.OrderBy(q=>q.IdPersona);

                Cargar_tipo_flujo_chk();

                this.chkFacs.EditValue = false;
                this.chkImpreso.EditValue = false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            

        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ParentForm.Close();

                event_btnsalir_ItemClick(sender, e);
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

                event_btnRefrescar_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Cargar_tipo_flujo_chk()
        {
            try
            {                
                lstTipoFlujo = bus_tipo_flujo.Get_List_TipoFlujo(param.IdEmpresa);

                cmb_chk_tipoFlujo.Items.Clear();
                foreach (var item in lstTipoFlujo)
                {
                    if (item.IdTipoFlujo != 0)
                    {
                        string linea = item.Descricion2 + "                                                                                                                                                          " + item.IdTipoFlujo.ToString().PadLeft(10, '0');
                        cmb_chk_tipoFlujo.Items.Add(linea);
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

        public List<int> Get_list_tipo_flujo_chk()
        {
            try
            {
                List<int> lst_chk_bodegas = new List<int>();

                foreach (var item in cmb_chk_tipoFlujo.Items.GetCheckedValues())
                {
                    string s_IdTipoFlujo = item.ToString().Substring(item.ToString().Length - 10, 10);
                    lst_chk_bodegas.Add(Convert.ToInt32(s_IdTipoFlujo));
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

        private void cmbBanco_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridBanco_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
