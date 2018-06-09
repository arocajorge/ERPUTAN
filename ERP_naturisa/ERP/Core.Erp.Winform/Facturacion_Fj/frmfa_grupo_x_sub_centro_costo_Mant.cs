using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmfa_grupo_x_sub_centro_costo_Mant : Form
    {
        #region Declaracion de Variables
        //generales
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;
        
        //clases bus
        fa_grupo_x_sub_centro_costo_Bus Bus_Grup_Subcentro = new fa_grupo_x_sub_centro_costo_Bus();
        fa_grupo_x_sub_centro_costo_det_Bus Bus_Det_Grup = new fa_grupo_x_sub_centro_costo_det_Bus();

        //clases info
        fa_grupo_x_sub_centro_costo_Info Info_Grup_Sub_Centro = new fa_grupo_x_sub_centro_costo_Info();
        fa_grupo_x_sub_centro_costo_det_Info Info_Det_Grup_Sub = new fa_grupo_x_sub_centro_costo_det_Info();

        //listas y BindingList
        List<fa_grupo_x_sub_centro_costo_det_Info> Lista_Grupo_Sub_Det = new List<fa_grupo_x_sub_centro_costo_det_Info>();
        BindingList<fa_grupo_x_sub_centro_costo_det_Info> BindList_Grup_Sub = new BindingList<fa_grupo_x_sub_centro_costo_det_Info>();
        
        //delegados y eventos
        public delegate void delegate_frmfa_grupo_x_sub_centro_costo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmfa_grupo_x_sub_centro_costo_Mant_FormClosing event_delegate_frmfa_grupo_x_sub_centro_costo_Mant_FormClosing;

        //otro
        string mensaje = "";
        string IdCentro_Costo = "";
        decimal IdGrupo = 0;
        #endregion

        public frmfa_grupo_x_sub_centro_costo_Mant()
        {
            InitializeComponent();
            event_delegate_frmfa_grupo_x_sub_centro_costo_Mant_FormClosing += frmfa_grupo_x_sub_centro_costo_Mant_event_delegate_frmfa_grupo_x_sub_centro_costo_Mant_FormClosing;
        }

        void frmfa_grupo_x_sub_centro_costo_Mant_event_delegate_frmfa_grupo_x_sub_centro_costo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmfa_grupo_x_sub_centro_costo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_delegate_frmfa_grupo_x_sub_centro_costo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #region Funciones Set y Get

        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Info(fa_grupo_x_sub_centro_costo_Info _Info_Grup_Sub_Centro)
        {
            try
            {
                Info_Grup_Sub_Centro = _Info_Grup_Sub_Centro;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_Accion_in_controls()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = false;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = true;
                        txt_nombreGrupo.Properties.ReadOnly = false;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = true;
                        txt_nombreGrupo.Properties.ReadOnly = false;

                        Set_Info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = false;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
                        txt_nombreGrupo.Properties.ReadOnly = false;

                        Set_Info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
                        txt_nombreGrupo.Properties.ReadOnly = false;

                        Set_Info_in_controls();
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

        private void Set_Info_in_controls()
        {
            try
            {
                txt_IdGrupo.Text = Info_Grup_Sub_Centro.IdGrupo.ToString();
                txt_nombreGrupo.Text = Info_Grup_Sub_Centro.nom_Grupo;
                dt_fecha.Value = Info_Grup_Sub_Centro.Fecha;
                ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo(Info_Grup_Sub_Centro.IdCentroCosto);
                lbl_anulado.Visible = (Info_Grup_Sub_Centro.Estado == true) ? false : true;

                //Cargo la grilla
                Info_Grup_Sub_Centro.List_Detalle = Bus_Det_Grup.Get_List_Grup_Sub_Det(Info_Grup_Sub_Centro.IdEmpresa, Info_Grup_Sub_Centro.IdGrupo, ref mensaje);
                BindList_Grup_Sub = new BindingList<fa_grupo_x_sub_centro_costo_det_Info>(Info_Grup_Sub_Centro.List_Detalle);
                gc_subcentro_detalle.DataSource = BindList_Grup_Sub;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public fa_grupo_x_sub_centro_costo_Info Get_Grup_Sub_Centro()
        {
            try
            {
                Info_Grup_Sub_Centro.IdEmpresa = param.IdEmpresa;
                Info_Grup_Sub_Centro.nom_Grupo = txt_nombreGrupo.Text;
                Info_Grup_Sub_Centro.nom_Cliente = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Cliente_x_Centro_costo().nom_Cliente;
                Info_Grup_Sub_Centro.IdCentroCosto = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Cliente_x_Centro_costo().IdCentroCosto_cc;
                Info_Grup_Sub_Centro.Fecha = dt_fecha.Value;
                Info_Grup_Sub_Centro.Estado = (lbl_anulado.Visible == true) ? false : true;
                Info_Grup_Sub_Centro.IdUsuario = param.IdUsuario;
                Info_Grup_Sub_Centro.Fecha_Transaccion = DateTime.Now;

                Info_Grup_Sub_Centro.List_Detalle = new List<fa_grupo_x_sub_centro_costo_det_Info>(BindList_Grup_Sub);

                return Info_Grup_Sub_Centro;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_grupo_x_sub_centro_costo_Info();
            }
        }

        #endregion

        #region Funciones Guardar, Modificar, Alunar, Validar, limpiar
        
        Boolean Guardar_Datos()
        {
            try
            {
                Boolean respuesta = false;
                txt_nombreGrupo.Focus();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        respuesta = GuardarDB();
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        respuesta = ModificarDB();
                        break;
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean GuardarDB()
        {
            try
            {
                Boolean respuesta = false;
                //txt_IdGrupo.Focus();
                Get_Grup_Sub_Centro();
                if (validar())
                {
                    respuesta = Bus_Grup_Subcentro.GuardarDB(Info_Grup_Sub_Centro, ref IdGrupo, ref mensaje);
                    if (respuesta)
                    {
                        Info_Grup_Sub_Centro.IdGrupo = IdGrupo;
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la Liquidación # " + Info_Grup_Sub_Centro.IdGrupo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Desea_Imprimir), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Imprimir();
                        }
                        return respuesta;
                    }
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean ModificarDB()
        {
            try
            {
                bool respuesta = false;
                //txt_IdGrupo.Focus();
                Get_Grup_Sub_Centro();
                if (validar())
                {
                    respuesta = Bus_Grup_Subcentro.ModificarDB(Info_Grup_Sub_Centro, ref mensaje);
                    if (respuesta)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " la Liquidación # " + Info_Grup_Sub_Centro.IdGrupo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Desea_Imprimir), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Imprimir();
                        }
                        return respuesta;
                    }
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean AnularDB()
        {
            try
            {
                FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + " la Liquidación #: " + Info_Grup_Sub_Centro.IdGrupo + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oFrm.ShowDialog();
                    Info_Grup_Sub_Centro.MotivoAnulacion = oFrm.motivoAnulacion;
                    Info_Grup_Sub_Centro.Fecha_UltAnu = param.Fecha_Transac;
                    Info_Grup_Sub_Centro.IdUsuarioUltAnu = param.IdUsuario;
                    if (Bus_Grup_Subcentro.AnularDB(Info_Grup_Sub_Centro, ref mensaje))
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " la Liquidación # " + Info_Grup_Sub_Centro.IdGrupo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Info_Grup_Sub_Centro.Estado = false;
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        lbl_anulado.Visible = true;
                        Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public Boolean validar()
        {
            try
            {
                if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo() == null)
                {
                    MessageBox.Show("No ha ingresado Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txt_nombreGrupo.Text == null || txt_nombreGrupo.Text == "")
                {
                    MessageBox.Show("Ingrese una Observación ", param.Nombre_sistema);
                    return false;
                }

                if (BindList_Grup_Sub.Count == 0)
                {
                    MessageBox.Show("No ha agregado ningún Subcentro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void limpiar()
        {
            try
            {
                gc_subcentro_detalle.DataSource = null;
                txt_IdGrupo.Text = "";
                txt_nombreGrupo.Text = "";
                ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Cliente_x_Centro_costo(0);
                dt_fecha.Value = DateTime.Now;
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                BindList_Grup_Sub = new BindingList<fa_grupo_x_sub_centro_costo_det_Info>();
                Set_Accion_in_controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion

        void Cargar_Combos()
        {
            try
            {
                dt_fecha.Value = DateTime.Now;

                ucFa_Cliente_x_centro_costo_cmb1.Cargar_combos();

                gc_subcentro_detalle.DataSource = BindList_Grup_Sub;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Cargar_Grid()
        {
            try
            {
                IdCentro_Costo = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Cliente_x_Centro_costo().IdCentroCosto_cc;
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    Lista_Grupo_Sub_Det = Bus_Det_Grup.Get_List_Grup_Sub_Det(param.IdEmpresa, IdCentro_Costo, ref mensaje);
                else
                    Lista_Grupo_Sub_Det = Bus_Det_Grup.Get_List_Grup_Sub_Det(Info_Grup_Sub_Centro.IdEmpresa, IdCentro_Costo, Info_Grup_Sub_Centro.IdGrupo, ref mensaje);

                cmb_IdCentroCosto_sub_centro_costo.DataSource = Lista_Grupo_Sub_Det;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnImprimir_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_Superior_Mant_event_btnlimpiar_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_Superior_Mant_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                AnularDB();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
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

        private void frmfa_grupo_x_sub_centro_costo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combos();
                Set_Accion_in_controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucFa_Cliente_x_centro_costo_cmb1_event_delegate_cmb_Centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_IdCentroCosto_sub_centro_costo_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                gw_subcentro_detalle.SetFocusedRowCellValue(col_IdCentroCosto, IdCentro_Costo);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gw_subcentro_detalle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == (char)Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gw_subcentro_detalle.DeleteRow(gw_subcentro_detalle.FocusedRowHandle);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gw_subcentro_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_IdCentroCosto_sub_centro_costo)
                {
                    string idSub_Centro_Costo = Convert.ToString(gw_subcentro_detalle.GetRowCellValue(e.RowHandle, col_IdCentroCosto_sub_centro_costo));
                    if (idSub_Centro_Costo != null)
                    {
                        if (Lista_Grupo_Sub_Det.Where(q => q.IdCentroCosto_sub_centro_costo == idSub_Centro_Costo).Count() > 1)
                        {
                            MessageBox.Show("Ya existe un registro con ese subcentro de costo, se procederá a eliminar la fila", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gw_subcentro_detalle.DeleteRow(gw_subcentro_detalle.FocusedRowHandle);
                        }
                    }
                    else
                        gw_subcentro_detalle.DeleteRow(gw_subcentro_detalle.FocusedRowHandle);
                }
                
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
