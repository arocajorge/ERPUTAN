using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCon_Periodo : UserControl
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<ct_Periodo_Info> lst_Periodo = new List<ct_Periodo_Info>();
        ct_Periodo_Info info_Periodo = new ct_Periodo_Info();
        ct_Periodo_Bus bus_Periodo = new ct_Periodo_Bus();
        #endregion

        #region Propiedades
        public Boolean Visible_cmb_Periodo { get { return this.cmb_Periodo.Visible; } set { this.cmb_Periodo.Visible = value; } }
        public Boolean Visible_de_Desde { get { return this.de_Desde.Visible; } set { this.de_Desde.Visible = value; } }
        public Boolean Visible_de_Hasta { get { return this.de_Hasta.Visible; } set { this.de_Hasta.Visible = value; } }

        public Boolean ReadOnly_cmb_Periodo { get { return this.cmb_Periodo.Properties.ReadOnly; } set { this.cmb_Periodo.Properties.ReadOnly = value; } }
        public Boolean ReadOnly_de_Desde { get { return this.de_Desde.Properties.ReadOnly; } set { this.de_Desde.Properties.ReadOnly = value; } }
        public Boolean ReadOnly_de_Hasta { get { return this.de_Hasta.Properties.ReadOnly; } set { this.de_Hasta.Properties.ReadOnly = value; } }

        public Boolean Enabled_cmb_Periodo { get { return this.cmb_Periodo.Properties.Enabled; } set { this.cmb_Periodo.Properties.Enabled = value; } }
        public Boolean Enabled_de_Desde { get { return this.de_Desde.Properties.Enabled; } set { this.de_Desde.Properties.Enabled = value; } }
        public Boolean Enabled_de_Hasta { get { return this.de_Hasta.Properties.Enabled; } set { this.de_Hasta.Properties.Enabled = value; } }

        public Boolean Visible_lblPeriodo { get { return this.lblPeriodo.Visible; } set { this.lblPeriodo.Visible = value; } }
        public Boolean Visible_lblDesde { get { return this.lblDesde.Visible; } set { this.lblDesde.Visible = value; } }
        public Boolean Visible_lblHasta { get { return this.lblHasta.Visible; } set { this.lblHasta.Visible = value; } }
        #endregion

        #region Delegados
        public delegate void delegate_cmb_Periodo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_Periodo_EditValueChanged event_delegate_cmb_Periodo_EditValueChanged;

        public delegate void delegate_de_Desde_EditValueChanged(object sender, EventArgs e);
        public event delegate_de_Desde_EditValueChanged event_delegate_de_Desde_EditValueChanged;

        public delegate void delegate_de_Hasta_EditValueChanged(object sender, EventArgs e);
        public event delegate_de_Hasta_EditValueChanged event_delegate_de_Hasta_EditValueChanged;
        #endregion

        public UCCon_Periodo()
        {
            InitializeComponent();
            event_delegate_cmb_Periodo_EditValueChanged += UCCon_Periodo_event_delegate_cmb_Periodo_EditValueChanged;
            event_delegate_de_Desde_EditValueChanged += UCCon_Periodo_event_delegate_de_Desde_EditValueChanged;
            event_delegate_de_Hasta_EditValueChanged += UCCon_Periodo_event_delegate_de_Hasta_EditValueChanged;
        }

        void UCCon_Periodo_event_delegate_de_Hasta_EditValueChanged(object sender, EventArgs e)
        {

        }

        void UCCon_Periodo_event_delegate_de_Desde_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        void UCCon_Periodo_event_delegate_cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Periodo.EditValue != null)
                {
                    int idPeriodo = Convert.ToInt32(cmb_Periodo.EditValue);
                    info_Periodo = lst_Periodo.FirstOrDefault(q => q.IdPeriodo == idPeriodo);
                    if (info_Periodo!=null)
                    {
                        de_Desde.EditValue = info_Periodo.pe_FechaIni;
                        de_Hasta.EditValue = info_Periodo.pe_FechaFin;
                    }
                    else
                    {
                        cmb_Periodo.EditValue = null;
                        de_Desde.EditValue = null;
                        de_Hasta.EditValue = null;
                    }
                }
                else
                {
                    de_Desde.EditValue = null;
                    de_Hasta.EditValue = null;
                }

                event_delegate_cmb_Periodo_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        public void Cargar_combos()
        {
            try
            {
                string MensajeError ="";
                lst_Periodo = bus_Periodo.Get_List_Periodo(param.IdEmpresa, ref MensajeError);
                cmb_Periodo.Properties.DataSource = lst_Periodo;
                cmb_Periodo.Properties.ValueMember = "IdPeriodo";
                cmb_Periodo.Properties.DisplayMember = "nom_periodo";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Periodo(int idPeriodo)
        {
            try
            {
                if (idPeriodo != 0)
                {
                    cmb_Periodo.EditValue = idPeriodo;
                }
                else
                {
                    cmb_Periodo.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_Combos()
        {
            try
            {
                cmb_Periodo.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ct_Periodo_Info Get_Periodo_Info()
        {
            try
            {
                if (cmb_Periodo.EditValue != null)
                {
                    int idPeriodo = Convert.ToInt32(cmb_Periodo.EditValue);
                    info_Periodo = lst_Periodo.FirstOrDefault(q => q.IdPeriodo == idPeriodo);
                }
                else
                    return null;

                return info_Periodo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        private void de_Desde_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_delegate_de_Desde_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void de_Hasta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_delegate_de_Hasta_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
