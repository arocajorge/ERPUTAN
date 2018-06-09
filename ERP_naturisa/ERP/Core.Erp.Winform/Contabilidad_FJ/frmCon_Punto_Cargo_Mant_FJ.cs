using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Business.ActivoFijo_FJ;
using Core.Erp.Info.Contabilidad_Fj;
using Core.Erp.Business.Contabilidad_Fj;

namespace Core.Erp.Winform.Contabilidad_FJ
{
    public partial class frmCon_Punto_Cargo_Mant_FJ : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        ct_punto_cargo_Bus Bus = new ct_punto_cargo_Bus();
        ct_punto_cargo_Info Info = new ct_punto_cargo_Info();
        List<Af_Activo_fijo_Info> List_Activo_fijo = new List<Af_Activo_fijo_Info>();
        Af_Activo_fijo_Info Info_Activo_fijo = new Af_Activo_fijo_Info();
        Af_Activo_fijo_Bus bus_Activo_fijo = new Af_Activo_fijo_Bus();
        Af_Activo_fijo_x_ct_punto_cargo_Info info_af_x_ct = new Af_Activo_fijo_x_ct_punto_cargo_Info();
        Af_Activo_fijo_x_ct_punto_cargo_Bus bus_af_x_ct = new Af_Activo_fijo_x_ct_punto_cargo_Bus();
        List<ct_punto_cargo_grupo_Info> lista_grupos = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus bus_grupo = new ct_punto_cargo_grupo_Bus();

        List<ct_Centro_costo_Info> lst_centro_costo = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();

        List<ct_centro_costo_sub_centro_costo_Info> lst_sub_centro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus bus_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Bus();

        ct_punto_cargo_FJ_Bus bus_punto_cargo_fj = new ct_punto_cargo_FJ_Bus();

        #endregion
        
        public frmCon_Punto_Cargo_Mant_FJ()
        {
            InitializeComponent();

            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public frmCon_Punto_Cargo_Mant_FJ(Cl_Enumeradores.eTipo_action Numerador): this()
          {
              try
              {
                   enu = Numerador;
              }
              catch (Exception ex)
              {
                  string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                  MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                  Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
              }
          }

        private void limpiar()
        {
            try
            {
                enu = Cl_Enumeradores.eTipo_action.grabar;
                Info = new ct_punto_cargo_Info();
                txt_codPunto_cargo.Text = "";
                txt_nombre.Text = "";
                ckbActivo.Checked = true;

                txt_codPunto_cargo.Focus();
                cmb_Activo_fijo.EditValue = null;
                Cargar_Combos();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void grabar()
        {
            try
            {
                txt_codPunto_cargo.Focus();
                GetPuntoCargo();

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        string ver = "";
                        string variable = (this.txt_codPunto_cargo.Text).TrimEnd();

                        if (variable != "")
                        {
                            if (Bus.VericarCodigoExiste(variable, ref  ver))
                            {
                                MessageBox.Show("El Codigo #: " + txt_codPunto_cargo.Text + " , ya se encuentra ingresado ", param.Nombre_sistema);
                                return;
                            }

                        }

                        Guardar();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        Anular();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Guardar()
        {
            try
            {
                if (txt_nombre.Text == "" || txt_nombre.Text == null)
                {
                    MessageBox.Show("Ingrese el nombre del Punto de Cargo", param.Nombre_sistema);
                    txt_nombre.Focus();
                    return;
                }

                if (Bus.GuardarDB(Info, param.IdEmpresa))
                {
                    Info.info_punto_cargo_Fj.IdPunto_cargo = Info.IdPunto_cargo;
                    bus_punto_cargo_fj.GuardarDB(Info.info_punto_cargo_Fj);

                    Crear_Punto_cargo_x_Activo_fijo();

                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro : ", Info.IdPunto_cargo);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_codPunto_cargo.Text = Info.codPunto_cargo;
                    limpiar();
                }
                else
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void Actualizar()
        {
            try
            {
                if (Bus.ModificarDB(Info))
                {
                    Info.info_punto_cargo_Fj.IdPunto_cargo = Info.IdPunto_cargo;
                    bus_punto_cargo_fj.GuardarDB(Info.info_punto_cargo_Fj);

                    Crear_Punto_cargo_x_Activo_fijo();
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El registro ", "");
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Modificar,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Anular()
        {
            try
            {
                if (Bus.AnularDB(Info))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgTituloAnular, "El registro ", "");
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Anular, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ct_punto_cargo_Info _SetInfo { get; set; }

        void SetPuntoCargo()
        {
            try
            {
                txt_IdPunto_cargo.EditValue = _SetInfo.IdPunto_cargo;
                txt_codPunto_cargo.Text = _SetInfo.codPunto_cargo;
                txt_nombre.Text = _SetInfo.nom_punto_cargo;

                if (_SetInfo.Estado.TrimEnd() == "I")
                {
                    this.ckbActivo.Checked = false;
                }
                else
                {
                    ckbActivo.Checked = true;
                }

                info_af_x_ct = bus_af_x_ct.Get_Info_x_Punto_cargo(_SetInfo.IdEmpresa, _SetInfo.IdPunto_cargo);
                if (info_af_x_ct.IdActivoFijo_AF!=0)
                {
                    cmb_Activo_fijo.EditValue = info_af_x_ct.IdActivoFijo_AF;    
                }
                cmb_grupo.EditValue = _SetInfo.IdPunto_cargo_grupo;

                _SetInfo.info_punto_cargo_Fj = bus_punto_cargo_fj.Get_info_punto_cargo(_SetInfo.IdEmpresa, _SetInfo.IdPunto_cargo);
                
                if (_SetInfo.IdEmpresa != 0)
                {
                    cmb_centro_costo.EditValue = _SetInfo.info_punto_cargo_Fj.IdCentroCosto;
                    cmb_centro_costo_sub_centro_costo.EditValue = _SetInfo.info_punto_cargo_Fj.IdCentroCosto_sub_centro_costo;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void GetPuntoCargo()
        {
            try
            {
                Info.codPunto_cargo = Convert.ToString((txt_codPunto_cargo.Text == "") ? "" : Convert.ToString(txt_codPunto_cargo.Text).Trim());
                Info.IdPunto_cargo = Convert.ToInt32(txt_IdPunto_cargo.EditValue);
                Info.IdEmpresa = param.IdEmpresa;
                Info.nom_punto_cargo = Convert.ToString(txt_nombre.Text);
                Info.Estado = (ckbActivo.Checked == true) ? "A" : "I";
                Info.IdPunto_cargo_grupo =Convert.ToInt32( cmb_grupo.EditValue);

                //Campos personalizados para FJ
                Info.info_punto_cargo_Fj.IdEmpresa = param.IdEmpresa;
                Info.info_punto_cargo_Fj.IdPunto_cargo = Info.IdPunto_cargo;
                Info.info_punto_cargo_Fj.IdCentroCosto = cmb_centro_costo.EditValue == null ? null : cmb_centro_costo.EditValue.ToString();
                Info.info_punto_cargo_Fj.IdCentroCosto_sub_centro_costo = cmb_centro_costo_sub_centro_costo.EditValue == null ? null : cmb_centro_costo_sub_centro_costo.EditValue.ToString();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Cargar_Combos()
        {
            try
            {
                string mensaje = "";
                List_Activo_fijo = bus_Activo_fijo.Get_List_ActivoFijo(param.IdEmpresa);
                cmb_Activo_fijo.Properties.DataSource = List_Activo_fijo;
                cmb_Activo_fijo.Properties.ValueMember = "IdActivoFijo";
                cmb_Activo_fijo.Properties.DisplayMember = "Af_Nombre";

                lst_centro_costo = bus_centro_costo.Get_list_Centro_Costo(param.IdEmpresa, ref mensaje);
                cmb_centro_costo.Properties.DataSource = lst_centro_costo;

                //lst_sub_centro_costo = bus_sub_centro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_centro_costo_sub_centro_costo.Properties.DataSource = lst_sub_centro_costo;

                lista_grupos = bus_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref mensaje);
                cmb_grupo.Properties.DataSource = lista_grupos;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        int C = 0;

        private void frmCon_Punto_Cargo_Mant_FJ_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combos();
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        C = 1;
                        Inhabilita_Campos(C);

                        txt_codPunto_cargo.Focus();
                        ckbActivo.Checked = true;
                        ckbActivo.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        C = 3;
                        Inhabilita_Campos(C);

                        SetPuntoCargo();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = true;

                        ucGe_Menu.Enabled_bntLimpiar = false;

                        C = 4;
                        Inhabilita_Campos(C);

                        SetPuntoCargo();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;

                        C = 4;
                        Inhabilita_Campos(C);

                        SetPuntoCargo();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Inhabilita_Campos(int C)
        {
            try
            {
                if (C == 1)
                {
                    
                }
                if (C == 4)
                {

                    txt_codPunto_cargo.Enabled = false;
                    txt_codPunto_cargo.BackColor = System.Drawing.Color.White;
                    txt_codPunto_cargo.ForeColor = System.Drawing.Color.Black;

                    txt_nombre.Enabled = false;
                    txt_nombre.BackColor = System.Drawing.Color.White;
                    txt_nombre.ForeColor = System.Drawing.Color.Black;

                    ckbActivo.Enabled = false;
                    ckbActivo.BackColor = System.Drawing.Color.White;
                    ckbActivo.ForeColor = System.Drawing.Color.Black;
                }

                if (C == 3)
                {

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_codPunto_cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
           
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public delegate void delegate_frmCon_Punto_Cargo_Mant_FJ_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_Punto_Cargo_Mant_FJ_FormClosing event_frmCon_Punto_Cargo_Mant_FJ_FormClosing;

        private void frmCon_Punto_Cargo_Mant_FJ_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCon_Punto_Cargo_Mant_FJ_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Activo_fijo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Activo_fijo.EditValue != null)
                {
                    Info_Activo_fijo = List_Activo_fijo.FirstOrDefault(q => q.IdActivoFijo == Convert.ToInt32(cmb_Activo_fijo.EditValue));
                    if (enu == Cl_Enumeradores.eTipo_action.grabar)
                        txt_nombre.Text = Info_Activo_fijo.Af_Nombre;
                    else
                    {
                        txt_nombre.Text = _SetInfo.nom_punto_cargo;
                    }
                    cmb_centro_costo.EditValue = null;
                    cmb_centro_costo_sub_centro_costo.EditValue = null;
                    cmb_centro_costo.Properties.ReadOnly = true;
                    cmb_centro_costo_sub_centro_costo.Properties.ReadOnly = true;
                }
                else
                {
                    Info_Activo_fijo = null;
                    cmb_centro_costo.EditValue = null;
                    cmb_centro_costo_sub_centro_costo.EditValue = null;
                    cmb_centro_costo.Properties.ReadOnly = false;
                    cmb_centro_costo_sub_centro_costo.Properties.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean Crear_Punto_cargo_x_Activo_fijo()
        {
            try
            {
                if (cmb_Activo_fijo.EditValue != null)
                {
                    info_af_x_ct.IdEmpresa_PC = Info.IdEmpresa;
                    info_af_x_ct.IdPunto_cargo_PC = Info.IdPunto_cargo;
                    info_af_x_ct.IdEmpresa_AF = Info_Activo_fijo.IdEmpresa;
                    info_af_x_ct.IdActivoFijo_AF = Info_Activo_fijo.IdActivoFijo;

                    bus_af_x_ct.MergeDB(info_af_x_ct);
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }        

        private void cmb_centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_centro_costo.EditValue == null)
                    lst_sub_centro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();
                else
                    lst_sub_centro_costo = bus_sub_centro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, cmb_centro_costo.EditValue.ToString());
                cmb_centro_costo_sub_centro_costo.Properties.DataSource = lst_sub_centro_costo;
                cmb_centro_costo_sub_centro_costo.EditValue = null;
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
