using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_grupo_x_Tipo_Gasto_Mant : Form
    {
        #region 'Declaracion Generales param '
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_frmCon_CbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_CbteCble_Mant_FormClosing event_frmCon_CbteCble_Mant_FormClosing;
        Cl_Enumeradores.eTipo_action _Accion;
        public Cl_MotivoAnulacion Cl_Motivo = new Cl_MotivoAnulacion();
        #endregion

        #region Variables
        ct_grupo_x_Tipo_Gasto_Info info_tipo_gasto = new ct_grupo_x_Tipo_Gasto_Info();
        ct_grupo_x_Tipo_Gasto_Info info_tipo_gasto_padre = new ct_grupo_x_Tipo_Gasto_Info();
        List<ct_grupo_x_Tipo_Gasto_Info> list_tipo_gasto_padre = new List<ct_grupo_x_Tipo_Gasto_Info>();
        ct_grupo_x_Tipo_Gasto_Bus bus_tipo_gasto = new ct_grupo_x_Tipo_Gasto_Bus();
        #endregion

        #region Delegados
        public delegate void delegate_frmCon_grupo_x_Tipo_Gasto_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_grupo_x_Tipo_Gasto_Mant_FormClosing event_delegate_frmCon_grupo_x_Tipo_Gasto_Mant_FormClosing;
        void frmCon_grupo_x_Tipo_Gasto_Mant_event_delegate_frmCon_grupo_x_Tipo_Gasto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        public frmCon_grupo_x_Tipo_Gasto_Mant()
        {
            InitializeComponent();
            event_delegate_frmCon_grupo_x_Tipo_Gasto_Mant_FormClosing += frmCon_grupo_x_Tipo_Gasto_Mant_event_delegate_frmCon_grupo_x_Tipo_Gasto_Mant_FormClosing;
        }

        

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                AnularDB();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_tipo_gasto_padre_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_tipo_gasto_padre.EditValue == null)
                {
                    info_tipo_gasto_padre = null;
                    txt_nivel.Value = 1;
                    txt_orden.Value = bus_tipo_gasto.Get_orden(param.IdEmpresa, null);
                    return;
                }
                else
                {
                    info_tipo_gasto_padre = list_tipo_gasto_padre.FirstOrDefault(q => q.IdTipo_Gasto == Convert.ToInt32(cmb_tipo_gasto_padre.EditValue));
                    if (info_tipo_gasto_padre != null)
                    {
                        txt_nivel.Value = info_tipo_gasto_padre.nivel == 0 ? 1 : Convert.ToInt32(info_tipo_gasto_padre.nivel) + 1;
                        txt_orden.Value = bus_tipo_gasto.Get_orden(param.IdEmpresa, info_tipo_gasto_padre.IdTipo_Gasto);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_Accion_in_controls()
        {
            try
            {
                Cargar_combos();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        Set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        Set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        Set_info_in_controls();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_info(ct_grupo_x_Tipo_Gasto_Info info)
        {
            try
            {
                info_tipo_gasto = info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_info_in_controls()
        {
            try
            {
                txt_id_tipo_gasto.Text = info_tipo_gasto.IdTipo_Gasto.ToString();
                cmb_tipo_gasto_padre.EditValue = info_tipo_gasto.IdTipo_Gasto_Padre;
                txt_nivel.Value = info_tipo_gasto.nivel == null ? 0 : Convert.ToDecimal(info_tipo_gasto.nivel);
                txt_orden.Value = info_tipo_gasto.orden == null ? 0 : Convert.ToDecimal(info_tipo_gasto.orden);
                txt_Tipo_gasto.Text = info_tipo_gasto.nom_tipo_Gasto;
                txt_anulado.Visible = !info_tipo_gasto.estado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Get_info()
        {
            try
            {
                info_tipo_gasto.IdEmpresa = param.IdEmpresa;
                info_tipo_gasto.IdTipo_Gasto = txt_id_tipo_gasto.Text == "" ? 0 : Convert.ToInt32(txt_id_tipo_gasto.Text);
                if (cmb_tipo_gasto_padre.EditValue == null) info_tipo_gasto.IdTipo_Gasto_Padre = null; else info_tipo_gasto.IdTipo_Gasto_Padre =  Convert.ToInt32(cmb_tipo_gasto_padre.EditValue);
                info_tipo_gasto.nom_tipo_Gasto = txt_Tipo_gasto.Text;
                info_tipo_gasto.nivel = Convert.ToInt32(txt_nivel.Value);
                info_tipo_gasto.orden = Convert.ToInt32(txt_orden.Value);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Cargar_combos()
        {
            try
            {
                list_tipo_gasto_padre = bus_tipo_gasto.Get_list_grupo_x_tipo_Gasto_nivel_menor_3(param.IdEmpresa);
                cmb_tipo_gasto_padre.Properties.DataSource = list_tipo_gasto_padre;
                txt_orden.Value = bus_tipo_gasto.Get_orden(param.IdEmpresa, null);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmCon_grupo_x_Tipo_Gasto_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Set_Accion_in_controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private bool Accion_Grabar()
        {
            try
            {
                bool res = false;

                if (Validar())
                {
                    Get_info();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                           res = GrabarDB();
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            res = ModificarDB();
                            break;
                    }    
                }
                return res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool GrabarDB()
        {
            try
            {
                if (bus_tipo_gasto.GuardarDB(info_tipo_gasto))
                {
                    MessageBox.Show("La transacción se ha realizado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool ModificarDB()
        {
            try
            {
                if (bus_tipo_gasto.ModificarDB(info_tipo_gasto))
                {
                    MessageBox.Show("La transacción se ha realizado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool AnularDB()
        {
            try
            {
                if (bus_tipo_gasto.AnularDB(info_tipo_gasto))
                {
                    MessageBox.Show("La transacción se ha realizado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool Validar() 
        {
            try
            {
                if (txt_Tipo_gasto.Text == "")
                {
                    MessageBox.Show("Ingrese el nombre del tipo de gasto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void Limpiar()
        {
            try
            {
                info_tipo_gasto = new ct_grupo_x_Tipo_Gasto_Info();
                txt_anulado.Visible = false;
                txt_id_tipo_gasto.Text = "";
                cmb_tipo_gasto_padre.EditValue = null;
                txt_Tipo_gasto.Text = "";
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Set_Accion_in_controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmCon_grupo_x_Tipo_Gasto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_delegate_frmCon_grupo_x_Tipo_Gasto_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
