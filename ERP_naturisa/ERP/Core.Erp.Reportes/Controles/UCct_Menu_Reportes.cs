using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using DevExpress.XtraEditors.Controls;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCct_Menu_Reportes : UserControl
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        ct_Grupocble_Bus bus_GrupoCble = new ct_Grupocble_Bus();
        List<ct_Grupocble_Info> lst_GrupoCble = new List<ct_Grupocble_Info>();
        ct_Grupocble_Info info_GrupoCble = new ct_Grupocble_Info();

        ct_Plancta_Bus bus_Plancta = new ct_Plancta_Bus();
        List<ct_Plancta_Info> lst_Plancta = new List<ct_Plancta_Info>();
        ct_Plancta_Info info_Plancta = new ct_Plancta_Info();

        List<ct_Plancta_nivel_Info> lst_nivel = new List<ct_Plancta_nivel_Info>();
        ct_Plancta_nivel_Bus bus_nivel = new ct_Plancta_nivel_Bus();
        ct_Plancta_nivel_Info info_nivel = new ct_Plancta_nivel_Info();

        ct_Centro_costo_Info info_Centro_costo = new ct_Centro_costo_Info();
        ct_Centro_costo_Bus bus_Centro_costo = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> lst_Centro_costo = new List<ct_Centro_costo_Info>();

        ct_centro_costo_sub_centro_costo_Info info_Centro_costo_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Info();
        ct_centro_costo_sub_centro_costo_Bus bus_Centro_costo_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> lst_Centro_costo_sub_centro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();

        List<string> lst_GrupoCble_chk = new List<string>();
        List<string> lst_id_GrupoCble_chk = new List<string>();

        List<ct_punto_cargo_grupo_Info> lst_punto_cargo_grupo = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus bus_punto_cargo_grupo = new ct_punto_cargo_grupo_Bus();
        ct_punto_cargo_grupo_Info info_punto_cargo_grupo = new ct_punto_cargo_grupo_Info();

        List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
        #endregion

        #region Delegados
        public delegate void delegate_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnConsultar_ItemClick event_btnConsultar_ItemClick;

        public delegate void delegate_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnSalir_ItemClick event_btnSalir_ItemClick;

        public delegate void delegate_btn_Mostrar_en_tabla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_Mostrar_en_tabla_ItemClick event_btn_Mostrar_en_tabla_ItemClick;

        #endregion

        #region Visibilidad

        public bool Visible_Grupo_cuentas 
        {
            get { return this.Grupo_cuentas.Visible; }
            set { this.Grupo_cuentas.Visible = value; }
        }

        public bool Visible_Grupo_centro_costo
        {
            get { return this.Grupo_centro_costo.Visible; }
            set { this.Grupo_centro_costo.Visible = value; }
        }

        public bool Visible_Grupo_Check
        {
            get { return this.Grupo_Check.Visible; }
            set { this.Grupo_Check.Visible = value; }
        }

        public bool Visible_Grupo_Punto_cargo
        {
            get { return this.Grupo_Punto_cargo.Visible; }
            set { this.Grupo_Punto_cargo.Visible = value; }
        }

        public string caption_bei_Check
        {
            get { return this.bei_Check.Caption; }
            set { this.bei_Check.Caption = value; }
        }

        public string caption_bei_Check2
        {
            get { return this.bei_Check2.Caption; }
            set { this.bei_Check2.Caption = value; }
        }

        public string caption_bei_Check3
        {
            get { return this.bei_Check3.Caption; }
            set { this.bei_Check3.Caption = value; }
        }

        public string caption_bei_Check4
        {
            get { return this.bei_Check4.Caption; }
            set { this.bei_Check4.Caption = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_bei_Desde { get { return this.bei_Desde.Visibility; } set { this.bei_Desde.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_Hasta { get { return this.bei_Hasta.Visibility; } set { this.bei_Hasta.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_Nivel { get { return this.bei_Nivel.Visibility; } set { this.bei_Nivel.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_Check2 { get { return this.bei_Check2.Visibility; } set { this.bei_Check2.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_Check3 { get { return this.bei_Check3.Visibility; } set { this.bei_Check3.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_Check4 { get { return this.bei_Check4.Visibility; } set { this.bei_Check4.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_CtaCble { get { return this.bei_CtaCble.Visibility; } set { this.bei_CtaCble.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_GrupoCble { get { return this.bei_GrupoCble.Visibility; } set { this.bei_GrupoCble.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_GrupoCble_chk { get { return this.bei_GrupoCble_chk.Visibility; } set { this.bei_GrupoCble_chk.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_btn_Mostrar_en_tabla { get { return this.btn_Mostrar_en_tabla.Visibility; } set { this.btn_Mostrar_en_tabla.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_punto_cargo { get { return this.bei_punto_cargo.Visibility; } set { this.bei_punto_cargo.Visibility = value; } }
        #endregion

        public UCct_Menu_Reportes()
        {
            InitializeComponent();
            event_btnConsultar_ItemClick += UCct_Menu_Reportes_event_btnConsultar_ItemClick;
            event_btnSalir_ItemClick += UCct_Menu_Reportes_event_btnSalir_ItemClick;
            event_btn_Mostrar_en_tabla_ItemClick += UCct_Menu_Reportes_event_btn_Mostrar_en_tabla_ItemClick;
        }

        void UCct_Menu_Reportes_event_btn_Mostrar_en_tabla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
                
        #region Eventos delegados
        void UCct_Menu_Reportes_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        void UCct_Menu_Reportes_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnConsultar_ItemClick(sender, e);
        }
        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnSalir_ItemClick(sender, e);
        }
        #endregion

        public void Cargar_combos()
        {
            try
            {
                string mensaje = "";

                lst_GrupoCble = bus_GrupoCble.Get_list_Grupocble();
                cmb_GrupoCble.DataSource = lst_GrupoCble;                

                lst_Plancta = bus_Plancta.Get_Plancta_x_Grupo(param.IdEmpresa, "");
                cmb_CtaCble.DataSource = lst_Plancta;

                lst_Centro_costo = bus_Centro_costo.Get_list_Centro_Costo(param.IdEmpresa, ref mensaje);
                cmb_Centro_costo.DataSource = lst_Centro_costo;

                lst_Centro_costo_sub_centro_costo = bus_Centro_costo_sub_centro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_Centro_costo_sub_centro_costo.DataSource = lst_Centro_costo_sub_centro_costo;

                bei_Desde.EditValue = DateTime.Now.AddMonths(-1);
                bei_Hasta.EditValue = DateTime.Now;

                bei_GrupoCble.EditValue = "GS_OP";

                foreach (var item in lst_GrupoCble)
                {
                    string tipo = item.gc_GrupoCble;
                    lst_GrupoCble_chk.Add(tipo);
                }
                cmb_GrupoCble_chk.DataSource = lst_GrupoCble_chk;

                lst_punto_cargo_grupo = bus_punto_cargo_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref mensaje);
                cmb_punto_cargo_grupo.DataSource = lst_punto_cargo_grupo;

                lst_nivel = bus_nivel.Get_list_Plancta_nivel(param.IdEmpresa);
                foreach (var item in lst_nivel)
                {
                    cmb_nivel.Items.Add(item.IdNivelCta);
                }
                if(lst_nivel.Count > 0)
                    bei_Nivel.EditValue = lst_nivel.Max(q => q.IdNivelCta);

                lst_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_punto_cargo.DataSource = lst_punto_cargo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public string Get_grupo_checked_nombres()
        {
            try
            {
                string nombre = "";
                var listIdTipoCobro_Cheked = (from CheckedListBoxItem item in cmb_GrupoCble_chk.Items
                                              where item.CheckState == CheckState.Checked
                                              select (string)item.Value).ToArray();
                int cont = 0;
                foreach (var item in listIdTipoCobro_Cheked)
                {
                    if(cont==0)
                        nombre += (item.ToString().Trim());
                    else
                        nombre += " / "+(item.ToString().Trim());
                    cont++;
                }
                
                return nombre;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }
        }

        public List<string> Get_grupo_checked()
        {
            try
            {
                List<string> lista = new List<string>();
                lst_id_GrupoCble_chk = new List<string>();

                var listIdTipoCobro_Cheked = (from CheckedListBoxItem item in cmb_GrupoCble_chk.Items
                                              where item.CheckState == CheckState.Checked
                                              select (string)item.Value).ToArray();

                foreach (var item in listIdTipoCobro_Cheked)
                {
                    lst_id_GrupoCble_chk.Add(item.ToString());                        
                }
                foreach (var item in lst_id_GrupoCble_chk)
                {
                    ct_Grupocble_Info info_grupo = new ct_Grupocble_Info();
                    info_grupo = lst_GrupoCble.FirstOrDefault(q => q.gc_GrupoCble == item.ToString());
                    if (info_grupo != null)
                    {
                        lista.Add(info_grupo.IdGrupoCble);
                    }
                }

                
                return lista;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<string>();
            }
        }

        public ct_Plancta_Info Get_info_plancta()
        {
            try
            {
                if (bei_CtaCble.EditValue != null)
                {
                    info_Plancta = lst_Plancta.FirstOrDefault(q => q.IdCtaCble == bei_CtaCble.EditValue.ToString());
                    return info_Plancta;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public ct_Grupocble_Info Get_info_grupo()
        {
            try
            {
                if (bei_GrupoCble.EditValue != null)
                {
                    info_GrupoCble = lst_GrupoCble.FirstOrDefault(q => q.IdGrupoCble == bei_GrupoCble.EditValue.ToString());
                    return info_GrupoCble;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        private void bei_GrupoCble_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bei_GrupoCble.EditValue != null)
                {
                    info_GrupoCble = lst_GrupoCble.FirstOrDefault(q => q.IdGrupoCble == bei_GrupoCble.EditValue.ToString());
                    if (info_GrupoCble != null)
                    {
                        lst_Plancta = bus_Plancta.Get_Plancta_x_Grupo(param.IdEmpresa, info_GrupoCble.IdGrupoCble);
                    }
                    else
                        lst_Plancta = bus_Plancta.Get_Plancta_x_Grupo(param.IdEmpresa, "");
                }
                else
                    lst_Plancta = bus_Plancta.Get_Plancta_x_Grupo(param.IdEmpresa, "");
                cmb_CtaCble.DataSource = lst_Plancta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void bei_Centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bei_Centro_costo.EditValue != null)
                {
                    info_Centro_costo = lst_Centro_costo.FirstOrDefault(q => q.IdCentroCosto == bei_Centro_costo.EditValue.ToString());
                    if (info_Centro_costo != null)
                    {
                        lst_Centro_costo_sub_centro_costo = bus_Centro_costo_sub_centro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, info_Centro_costo.IdCentroCosto);
                    }
                    else
                        lst_Centro_costo_sub_centro_costo = bus_Centro_costo_sub_centro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                }
                else
                    lst_Centro_costo_sub_centro_costo = bus_Centro_costo_sub_centro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_Centro_costo_sub_centro_costo.DataSource = lst_Centro_costo_sub_centro_costo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        public ct_Centro_costo_Info Get_info_Centro_costo()
        {
            try
            {
                if (bei_Centro_costo.EditValue != null)
                {
                    info_Centro_costo = lst_Centro_costo.FirstOrDefault(q => q.IdCentroCosto == bei_Centro_costo.EditValue.ToString());
                    return info_Centro_costo;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public ct_centro_costo_sub_centro_costo_Info Get_info_Centro_costo_sub_centro_costo()
        {
            try
            {
                if (bei_Centro_costo_sub_centro_costo.EditValue != null)
                {
                    info_Centro_costo_sub_centro_costo = lst_Centro_costo_sub_centro_costo.FirstOrDefault(q => q.IdCentroCosto_sub_centro_costo == bei_Centro_costo_sub_centro_costo.EditValue.ToString());
                    return info_Centro_costo_sub_centro_costo;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        private void bei_GrupoCble_chk_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lst_Plancta = new List<ct_Plancta_Info>();
                if (bei_GrupoCble_chk.EditValue != null)
                {
                        lst_id_GrupoCble_chk = Get_grupo_checked();
                        foreach (var item in lst_id_GrupoCble_chk)
                        {
                            List<ct_Plancta_Info> lst_temp_plancta = new List<ct_Plancta_Info>();
                            lst_temp_plancta = bus_Plancta.Get_Plancta_x_Grupo(param.IdEmpresa, item.ToString());
                            foreach (var CtaCble in lst_temp_plancta)
                            {
                                lst_Plancta.Add(CtaCble);
                            }
                        }
                }
                else
                    lst_Plancta = bus_Plancta.Get_Plancta_x_Grupo(param.IdEmpresa, "");                
                
                cmb_CtaCble.DataSource = lst_Plancta;        
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ct_punto_cargo_grupo_Info Get_info_punto_cargo_grupo()
        {
            try
            {
                if (bei_punto_cargo_grupo.EditValue != null)
                {
                    info_punto_cargo_grupo = lst_punto_cargo_grupo.FirstOrDefault(q => q.IdPunto_cargo_grupo == Convert.ToInt32(bei_punto_cargo_grupo.EditValue));
                    return info_punto_cargo_grupo;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public ct_punto_cargo_Info Get_info_punto_cargo()
        {
            try
            {
                if (bei_punto_cargo.EditValue != null)
                {
                    info_punto_cargo_grupo = lst_punto_cargo_grupo.FirstOrDefault(q => q.IdPunto_cargo_grupo == Convert.ToInt32(bei_punto_cargo_grupo.EditValue));
                    return info_punto_cargo;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        private void btn_Mostrar_en_tabla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btn_Mostrar_en_tabla_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void bei_punto_cargo_grupo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bei_punto_cargo_grupo.EditValue != null)
                    lst_punto_cargo = bus_punto_cargo.Get_list_PuntoCargo_x_grupo(param.IdEmpresa, Convert.ToInt32(bei_punto_cargo_grupo));
                else                
                    lst_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);                    
                cmb_punto_cargo.DataSource = lst_punto_cargo;
                bei_punto_cargo.EditValue = null;
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
