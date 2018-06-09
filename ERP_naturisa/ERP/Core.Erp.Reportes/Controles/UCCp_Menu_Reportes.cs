using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCCp_Menu_Reportes : UserControl
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        #region Visible
        public DevExpress.XtraBars.BarItemVisibility Visible_dtpDesde { get { return this.dtpDesde.Visibility; } set { this.dtpDesde.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visble_dtpHasta { get { return this.dtpHasta.Visibility; } set { this.dtpHasta.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visble_bei_clase_proveedor { get { return this.bei_clase_proveedor.Visibility; } set { this.bei_clase_proveedor.Visibility = value; } }
        public string Text_dtpHasta { get { return this.dtpHasta.Caption; } set { this.dtpHasta.Caption = value; } }
        public string Text_dtpDesde { get { return this.dtpDesde.Caption; } set { this.dtpDesde.Caption = value; } }
        public Boolean Visible_groupCheck { get { return this.groupCheck.Visible; } set { this.groupCheck.Visible = value; } }
        public string CaptionCheck1 { get { return beiCheck1.Caption; } set { this.beiCheck1.Caption = value; } }
        public string CaptionCheck2 { get { return beiCheck2.Caption; } set { this.beiCheck2.Caption = value; } }
        public string CaptionCheck3 { get { return beiCheck3.Caption; } set { this.beiCheck3.Caption = value; } }
        #endregion

        #region Delegados



        public delegate void delegate_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnRefrescar_ItemClick event_btnRefrescar_ItemClick;

        public delegate void delegate_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnsalir_ItemClick event_btnsalir_ItemClick;

        public delegate void delegate_btnimprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnimprimir_ItemClick event_btnimprimir_ItemClick;
        #endregion

        #region data
        List<cp_proveedor_Info> Proveedor_list = new List<cp_proveedor_Info>();
        cp_proveedor_Bus ProveedorB = new cp_proveedor_Bus();
        cp_proveedor_Info info_proveedor = new cp_proveedor_Info();
        cp_proveedor_clase_Bus bus_clase_prov = new cp_proveedor_clase_Bus();
        List<cp_proveedor_clase_Info> lst_clase_prov = new List<cp_proveedor_clase_Info>();
        cp_proveedor_clase_Info info_clase_prov = new cp_proveedor_clase_Info();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        #region propiedades

        public DateTime get_FchIni()
        {
            return Convert.ToDateTime(this.dtpDesde.EditValue);
        }
        public DateTime get_FchFin()
        {
            return Convert.ToDateTime(this.dtpHasta.EditValue);

        }
        public int get_cmbProveedor()
        {
            return Convert.ToInt32(this.cmbProveedor.EditValue);
        }
        public string get_cmbNomProveedor()
        {
            if (cmbProveedor.EditValue != null)
                return Proveedor_list.First(v => v.IdProveedor == Convert.ToInt32(this.cmbProveedor.EditValue)).pr_nombre;
            else
                return "TODOS";
        }

        public Boolean Visible_Imprimir
        {
            get { return this.groupImprimir.Visible; }
            set { this.groupImprimir.Visible = value; }
        }

     


        #endregion

        public UCCp_Menu_Reportes()
        {
            InitializeComponent();
            event_btnRefrescar_ItemClick += UCCp_Menu_Reportes_event_btnRefrescar_ItemClick;
            event_btnsalir_ItemClick += UCCp_Menu_Reportes_event_btnsalir_ItemClick;
            event_btnimprimir_ItemClick += UCCp_Menu_Reportes_event_btnImprimir_ItemClick;

            this.Dock = DockStyle.Top;


            
            

        }

        #region voids delegados
        void UCCp_Menu_Reportes_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCCp_Menu_Reportes_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCCp_Menu_Reportes_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                event_btnRefrescar_ItemClick(sender, e);
            }
            catch (Exception ex)
            {

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

            }
        }

        public cp_proveedor_Info Get_info_proveedor()
        {
            try
            {
                if (cmbProveedor.EditValue == null) return null;

                info_proveedor = Proveedor_list.FirstOrDefault(q => q.IdProveedor == Convert.ToDecimal(cmbProveedor.EditValue));
                return info_proveedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public cp_proveedor_clase_Info Get_info_clase_proveedor()
        {
            try
            {
                if (bei_clase_proveedor.EditValue == null) return null;

                info_clase_prov = lst_clase_prov.FirstOrDefault(q => q.IdClaseProveedor == Convert.ToInt32(bei_clase_proveedor.EditValue));
                return info_clase_prov;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }


        private void UCCp_Menu_Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDesde.EditValue = DateTime.Now.AddMonths(-1);
                dtpHasta.EditValue = DateTime.Now;

                Proveedor_list = ProveedorB.Get_List_proveedor(param.IdEmpresa);
                this.risProveedor.DataSource = Proveedor_list;

                lst_clase_prov = bus_clase_prov.Get_List_proveedor_clase(param.IdEmpresa);
                this.risClase.DataSource = lst_clase_prov;
                
            }
            catch (Exception ex)
            {
                //Environment.

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
            
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                event_btnimprimir_ItemClick(sender, e);
            }
            catch (Exception ex)
            {

            }
        }

        private void bei_clase_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bei_clase_proveedor.EditValue == null)
                {
                    Proveedor_list = ProveedorB.Get_List_proveedor(param.IdEmpresa);
                }
                else
                {
                    Proveedor_list = ProveedorB.Get_List_proveedor_x_clase(param.IdEmpresa,Convert.ToInt32(bei_clase_proveedor.EditValue));                    
                }
                this.risProveedor.DataSource = Proveedor_list;
                cmbProveedor.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void beiCheck1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(beiCheck1.EditValue))
                {
                    beiCheck2.EditValue = false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void beiCheck2_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (Convert.ToBoolean(beiCheck2.EditValue))
                {
                    beiCheck1.EditValue = false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }       
    }
}
