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
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Winform.Contabilidad_FJ;

namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_Cliente_x_centro_costo_cmb : UserControl
    {
        #region Variables y atributos
        List<ct_centro_costo_sub_centro_costo_Info> list_Centro_costo_sub_centro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Info info_Centro_costo_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Info();
        ct_centro_costo_sub_centro_costo_Bus bus_Centro_costo_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Bus();
        List<fa_cliente_x_ct_centro_costo_Info> list_Cliente_x_Centro_costo = new List<fa_cliente_x_ct_centro_costo_Info>();
        fa_cliente_x_ct_centro_costo_Info info_Cliente_x_centro_costo = new fa_cliente_x_ct_centro_costo_Info();
        fa_cliente_x_ct_centro_costo_Bus bus_Cliente_x_Centro_costo = new fa_cliente_x_ct_centro_costo_Bus();
        List<ct_Centro_costo_Info> list_Centro_costo = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Info info_Centro_costo = new ct_Centro_costo_Info();
        ct_Centro_costo_Bus bus_Centro_costo = new ct_Centro_costo_Bus();        
        fa_Cliente_Info info_Cliente = new fa_Cliente_Info();
        fa_Cliente_Bus bus_Cliente = new fa_Cliente_Bus();
        Boolean foco_Centro_costo = true;
        Boolean foco_Cliente = false;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        #endregion

        #region delegados
        public delegate void delegate_cmb_Cliente_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_Cliente_EditValueChanged event_delegate_cmb_Cliente_EditValueChanged;

        public delegate void delegate_cmb_Centro_costo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_Centro_costo_EditValueChanged event_delegate_cmb_Centro_costo_EditValueChanged;

        public delegate void delegate_cmb_Sub_centro_costo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_Sub_centro_costo_EditValueChanged event_delegate_cmb_Sub_centro_costo_EditValueChanged;
        #endregion

        #region Propiedades
        public Boolean Visible_cmb_Cliente { get{return this.cmb_Cliente.Visible;} set{this.cmb_Cliente.Visible = value;} }
        public Boolean Visible_cmb_Centro_costo { get { return this.cmb_Centro_costo.Visible; } set { this.cmb_Centro_costo.Visible = value; } }
        public Boolean Visible_cmb_Subcentro_costo { get { return this.cmb_Sub_centro_costo.Visible; } set { this.cmb_Sub_centro_costo.Visible = value; } }
        public Boolean Visible_lblCliente { get { return this.lblCliente.Visible; } set { this.lblCliente.Visible = value; } }
        public Boolean Visible_lblCentro_costo { get { return this.lblCentro_costo.Visible; } set { this.lblCentro_costo.Visible = value; } }
        public Boolean Visible_lblSub_centro_costo { get { return this.lblSub_centro_costo.Visible; } set { this.lblSub_centro_costo.Visible = value; } }
        public Boolean Visible_BtnAccion_cc { get { return this.btnAccion_cc.Visible; } set { this.btnAccion_cc.Visible = value; } }
        public Boolean Visible_BtnAccion_cli { get { return this.btnAccion_cli.Visible; } set { this.btnAccion_cli.Visible = value; } }
        public Boolean Visible_btnAccion_Scc { get { return this.btnAccion_Scc.Visible; } set { this.btnAccion_Scc.Visible = value; } }
        
        public Boolean ReadOnly_cmb_Cliente { get { return this.cmb_Cliente.Properties.ReadOnly; } set { this.cmb_Cliente.Properties.ReadOnly = value; } }
        public Boolean ReadOnly_cmb_Centro_costo { get { return this.cmb_Centro_costo.Properties.ReadOnly; } set { this.cmb_Centro_costo.Properties.ReadOnly = value; } }
        public Boolean ReadOnly_cmb_Subcentro_costo { get { return this.cmb_Sub_centro_costo.Properties.ReadOnly; } set { this.cmb_Sub_centro_costo.Properties.ReadOnly = value; } }

        public Boolean Enabled_cmb_Cliente { get { return this.cmb_Cliente.Enabled; } set { this.cmb_Cliente.Enabled = value; } }
        public Boolean Enabled_cmb_Centro_costo { get { return this.cmb_Centro_costo.Enabled; } set { this.cmb_Centro_costo.Enabled = value; } }
        public Boolean Enabled_BtnAccion_cc { get { return this.btnAccion_cc.Enabled; } set { this.btnAccion_cc.Enabled = value; } }
        public Boolean Enabled_BtnAccion_cli { get { return this.btnAccion_cli.Enabled; } set { this.btnAccion_cli.Enabled = value; } }
        public Boolean Enabled_BtnAccion_Scc { get { return this.btnAccion_Scc.Enabled; } set { this.btnAccion_Scc.Enabled = value; } }     
        #endregion

        frmCon_CentroCosto_x_cliente_Mant_FJ frmCentro_costo;
        frmFa_Clientes_Mant frmCliente;
        frmCon_CentroCosto_SubCentroCosto_Mant_FJ frmCentro_costo_sub_centro_costo;

        public fa_cliente_x_ct_centro_costo_Info Get_Info_Cliente_x_Centro_costo()
        {
            try
            {
                if (cmb_Cliente.EditValue != null)
                {
                    decimal idCliente = Convert.ToDecimal(cmb_Cliente.EditValue);
                    info_Cliente_x_centro_costo = list_Cliente_x_Centro_costo.FirstOrDefault(q => q.IdCliente_cli == idCliente);
                }
                else
                    info_Cliente_x_centro_costo = null;
                return info_Cliente_x_centro_costo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public ct_Centro_costo_Info Get_Info_Centro_costo()
        {
            try
            {
                if (cmb_Centro_costo.EditValue != null)
                {
                    string idCentro_costo = cmb_Centro_costo.EditValue.ToString();
                    info_Centro_costo = list_Centro_costo.FirstOrDefault(q => q.IdCentroCosto == idCentro_costo);                    
                }
                else
                    info_Centro_costo = null;
                return info_Centro_costo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public ct_centro_costo_sub_centro_costo_Info Get_Info_Centro_costo_sub_centro_costo()
        {
            try
            {
                if (cmb_Sub_centro_costo.EditValue != null)
                {
                    return info_Centro_costo_sub_centro_costo;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public void Inicializar_Combos()
        {
            try
            {
                cmb_Cliente.EditValue = null;
                cmb_Centro_costo.EditValue = null;
                cmb_Sub_centro_costo.EditValue = null;
                list_Centro_costo_sub_centro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();
                cmb_Sub_centro_costo.Properties.DataSource = list_Centro_costo_sub_centro_costo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }        

        public void Set_Info_Cliente_x_Centro_costo(Nullable<Decimal> _idCliente)
        {
            try
            {
                if (_idCliente != 0)
                {
                    cmb_Cliente.EditValue = _idCliente;
                }
                else
                    cmb_Cliente.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Info_Centro_costo(string _idCentro_costo)
        {
            try
            {
                if (_idCentro_costo != "")
                {
                    cmb_Centro_costo.EditValue = _idCentro_costo;
                }
                else
                    cmb_Centro_costo.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Info_Centro_costo_sub_centro_costo(string _idCentro_costo_sub_centro_costo)
        {
            try
            {
                if (_idCentro_costo_sub_centro_costo != "")
                {
                    cmb_Sub_centro_costo.EditValue = _idCentro_costo_sub_centro_costo;
                }
                else
                    cmb_Sub_centro_costo.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public UCFa_Cliente_x_centro_costo_cmb()
        {
            InitializeComponent();
            event_delegate_cmb_Cliente_EditValueChanged += UCFa_Cliente_x_centro_costo_cmb_event_delegate_cmb_Cliente_EditValueChanged;
            event_delegate_cmb_Centro_costo_EditValueChanged += UCFa_Cliente_x_centro_costo_cmb_event_delegate_cmb_Centro_costo_EditValueChanged;
            event_delegate_cmb_Sub_centro_costo_EditValueChanged += UCFa_Cliente_x_centro_costo_cmb_event_delegate_cmb_Sub_centro_costo_EditValueChanged;
        }

        void UCFa_Cliente_x_centro_costo_cmb_event_delegate_cmb_Sub_centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        void UCFa_Cliente_x_centro_costo_cmb_event_delegate_cmb_Centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        void UCFa_Cliente_x_centro_costo_cmb_event_delegate_cmb_Cliente_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        public void Cargar_combos()
        {
            try
            {
                string MensajeError = "";

                list_Cliente_x_Centro_costo = bus_Cliente_x_Centro_costo.Get_Vista_Clientes_x_Centro_costo(param.IdEmpresa);
                cmb_Cliente.Properties.DataSource = list_Cliente_x_Centro_costo;
                cmb_Cliente.Properties.ValueMember = "IdCliente_cli";
                cmb_Cliente.Properties.DisplayMember = "nom_Cliente";

                list_Centro_costo = bus_Centro_costo.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);
                cmb_Centro_costo.Properties.DataSource = list_Centro_costo;
                cmb_Centro_costo.Properties.ValueMember = "IdCentroCosto";
                cmb_Centro_costo.Properties.DisplayMember = "Centro_costo2";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Cliente.EditValue != null)
                {
                    decimal idCliente = Convert.ToDecimal(cmb_Cliente.EditValue);
                    info_Cliente = bus_Cliente.Get_Info_Cliente(param.IdEmpresa, idCliente);
                    info_Cliente_x_centro_costo = list_Cliente_x_Centro_costo.FirstOrDefault(q => q.IdEmpresa_cli == info_Cliente.IdEmpresa && q.IdCliente_cli == idCliente);
                }
                else
                {
                    info_Cliente = null;
                    info_Cliente_x_centro_costo = null;
                }

                if (foco_Cliente)
                {
                    if (cmb_Cliente.EditValue != null)
                    {
                        if (info_Cliente_x_centro_costo != null)
                        {
                            cmb_Centro_costo.EditValue = info_Cliente_x_centro_costo.IdCentroCosto_cc;
                        }
                        else
                            cmb_Centro_costo.EditValue = null;
                    }
                    else
                        cmb_Centro_costo.EditValue = null;
                }
                event_delegate_cmb_Cliente_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Centro_costo.EditValue != null)
                {
                    string idCentro_costo = cmb_Centro_costo.EditValue.ToString();
                    info_Centro_costo = list_Centro_costo.FirstOrDefault(q => q.IdCentroCosto == idCentro_costo && q.IdEmpresa == param.IdEmpresa);

                    list_Centro_costo_sub_centro_costo = bus_Centro_costo_sub_centro_costo.Get_list_centro_costo_sub_centro_costo(info_Centro_costo.IdEmpresa, info_Centro_costo.IdCentroCosto);
                    cmb_Sub_centro_costo.Properties.DataSource = list_Centro_costo_sub_centro_costo;
                    cmb_Sub_centro_costo.Properties.ValueMember = "IdCentroCosto_sub_centro_costo";
                    cmb_Sub_centro_costo.Properties.DisplayMember = "Centro_costo2";
                }
                else
                {
                    info_Centro_costo = null;
                    cmb_Sub_centro_costo.EditValue = null;
                    list_Centro_costo_sub_centro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();
                    cmb_Sub_centro_costo.Properties.DataSource = list_Centro_costo_sub_centro_costo;
                    cmb_Sub_centro_costo.Properties.ValueMember = "IdCentroCosto_sub_centro_costo";
                    cmb_Sub_centro_costo.Properties.DisplayMember = "Centro_costo2";
                }


                if (foco_Centro_costo)
                {
                    if (info_Centro_costo != null)
                    {
                        info_Cliente_x_centro_costo = list_Cliente_x_Centro_costo.FirstOrDefault(q => q.IdCentroCosto_cc == info_Centro_costo.IdCentroCosto);
                        if (info_Cliente_x_centro_costo != null)
                        {
                            cmb_Cliente.EditValue = info_Cliente_x_centro_costo.IdCliente_cli;
                        }
                        else
                            cmb_Cliente.EditValue = null;
                    }
                    else
                        cmb_Cliente.EditValue = null;
                }
                event_delegate_cmb_Centro_costo_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Sub_centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Centro_costo.EditValue != null)
                {
                    string idCentro_costo = cmb_Centro_costo.EditValue.ToString();
                    info_Centro_costo = list_Centro_costo.FirstOrDefault(q => q.IdCentroCosto == idCentro_costo && param.IdEmpresa == q.IdEmpresa);

                    if (cmb_Sub_centro_costo.EditValue != null)
                    {
                        string idCentro_costo_sub_centro_costo = cmb_Sub_centro_costo.EditValue.ToString();
                        info_Centro_costo_sub_centro_costo = list_Centro_costo_sub_centro_costo.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdCentroCosto_sub_centro_costo == idCentro_costo_sub_centro_costo && q.IdCentroCosto == idCentro_costo);
                    }
                    else
                        info_Centro_costo_sub_centro_costo = null;
                }
                else
                    info_Centro_costo_sub_centro_costo = null;
                event_delegate_cmb_Sub_centro_costo_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Centro_costo_Click(object sender, EventArgs e)
        {
            try
            {
                foco_Centro_costo = true;
                foco_Cliente = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                foco_Centro_costo = false;
                foco_Cliente = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnNuevo_cc_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_Formulario_cc(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnModificar_cc_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Centro_costo.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (info_Centro_costo.pc_Estado=="I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Llamar_Formulario_cc(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnConsultar_cc_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Centro_costo.EditValue != null)
                {
                    Llamar_Formulario_cc(Cl_Enumeradores.eTipo_action.consultar);
                }
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnNuevo_cli_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_Formulario_cli(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnModificar_cli_Click(object sender, EventArgs e)
        {
            try
            {
                if (info_Cliente==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (info_Cliente.Estado=="I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Llamar_Formulario_cli(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnConsultar_cli_Click(object sender, EventArgs e)
        {
            try
            {
                if (info_Cliente != null)
                {
                    Llamar_Formulario_cli(Cl_Enumeradores.eTipo_action.consultar);
                }
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Llamar_Formulario_cc(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmCentro_costo = new frmCon_CentroCosto_x_cliente_Mant_FJ();
                frmCentro_costo.setAccion(Accion);
                frmCentro_costo.event_frmCon_CentroCostos_Man_FormClosing += frmCentro_costo_event_frmCon_CentroCostos_Man_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frmCentro_costo.setInfo(info_Centro_costo);
                }
                frmCentro_costo.ShowDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }        

        private void Llamar_Formulario_cli(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmCliente = new frmFa_Clientes_Mant();
                frmCliente.set_Accion(Accion);                
                frmCliente.event_frmFA_Clientes_Mant_FormClosing += frmCliente_event_frmFA_Clientes_Mant_FormClosing;
                if (Accion!=Cl_Enumeradores.eTipo_action.grabar)
                {
                    frmCliente.set_Cliente(info_Cliente);
                }
                frmCliente.ShowDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Llamar_Formulario_scc(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmCentro_costo_sub_centro_costo = new frmCon_CentroCosto_SubCentroCosto_Mant_FJ();
                frmCentro_costo_sub_centro_costo.set_Accion(Accion);
                frmCentro_costo_sub_centro_costo.event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing += frmCentro_costo_sub_centro_costo_event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frmCentro_costo_sub_centro_costo.set_Info(info_Centro_costo_sub_centro_costo);
                }
                frmCentro_costo_sub_centro_costo.ShowDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmCentro_costo_sub_centro_costo_event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (cmb_Centro_costo.EditValue != null)
                {
                    string idCentro_costo = cmb_Centro_costo.EditValue.ToString();
                    info_Centro_costo = list_Centro_costo.FirstOrDefault(q => q.IdCentroCosto == idCentro_costo && q.IdEmpresa == param.IdEmpresa);

                    list_Centro_costo_sub_centro_costo = bus_Centro_costo_sub_centro_costo.Get_list_centro_costo_sub_centro_costo(info_Centro_costo.IdEmpresa, info_Centro_costo.IdCentroCosto);
                    cmb_Sub_centro_costo.Properties.DataSource = list_Centro_costo_sub_centro_costo;
                    cmb_Sub_centro_costo.Properties.ValueMember = "IdCentroCosto_sub_centro_costo";
                    cmb_Sub_centro_costo.Properties.DisplayMember = "Centro_costo2";
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmCentro_costo_event_frmCon_CentroCostos_Man_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cargar_combos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmCliente_event_frmFA_Clientes_Mant_FormClosing()
        {
            try
            {
                Cargar_combos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnAccion_cc_Click(object sender, EventArgs e)
        {
            try
            {
                MenuCentro_costo.Show(btnAccion_cc,new Point(btnAccion_cc.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnAccion_cli_Click(object sender, EventArgs e)
        {
            try
            {
                MenuCliente_x_Centro_costo.Show(btnAccion_cli, new Point(btnAccion_cli.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }                

        private void btnAccion_Scc_Click(object sender, EventArgs e)
        {
            try
            {
                MenuCentro_costo_sub_centro_costo.Show(btnAccion_Scc, new Point(btnAccion_Scc.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnNuevo_Scc_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_Formulario_scc(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnModificar_Scc_Click(object sender, EventArgs e)
        {
            try
            {
                if (info_Centro_costo_sub_centro_costo==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (info_Centro_costo_sub_centro_costo.pc_Estado=="I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Llamar_Formulario_scc(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnConsultar_Scc_Click(object sender, EventArgs e)
        {
            try
            {
                if (info_Centro_costo_sub_centro_costo == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Llamar_Formulario_scc(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ReadOnly_All(Boolean Bool)
        {
            try
            {
                cmb_Cliente.Properties.ReadOnly = Bool;
                cmb_Centro_costo.Properties.ReadOnly = Bool;
                cmb_Sub_centro_costo.Properties.ReadOnly = Bool;

                btnAccion_cc.Visible = !Bool;
                btnAccion_cli.Visible = !Bool;
                btnAccion_Scc.Visible = !Bool;
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
