using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad_Fj;
using Core.Erp.Business.Contabilidad_Fj;

namespace Core.Erp.Winform.Contabilidad_FJ
{
    public partial class frmCon_distribucion_gastos_x_punto_cargo_mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();

        
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        BindingList<ct_distribucion_gastos_x_periodo_det_gastos_Info> blst_gastos = new BindingList<ct_distribucion_gastos_x_periodo_det_gastos_Info>();
        BindingList<ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info> blst_punto_cargo = new BindingList<ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info>();
        ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Bus bus_distribucion_x_punto_de_cargo = new ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Bus();
        ct_distribucion_gastos_x_periodo_det_gastos_Bus bus_distribucion_x_gasto = new ct_distribucion_gastos_x_periodo_det_gastos_Bus();
        ct_distribucion_gastos_x_periodo_Bus bus_distribucion = new ct_distribucion_gastos_x_periodo_Bus();
        ct_distribucion_gastos_x_periodo_Info info_distribucion = new ct_distribucion_gastos_x_periodo_Info();
        #endregion

        #region Delegados
        public delegate void delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed event_delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed;
        #endregion

        public frmCon_distribucion_gastos_x_punto_cargo_mant()
        {
            InitializeComponent();
            event_delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed += frmCon_distribucion_gastos_x_punto_cargo_mant_event_delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed;
        }

        void frmCon_distribucion_gastos_x_punto_cargo_mant_event_delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        public void set_accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
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

        private void set_accion_in_controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        set_info_in_controls();
                        break;
                }
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

        public void set_info(ct_distribucion_gastos_x_periodo_Info _info)
        {
            try
            {
                info_distribucion = _info;
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

        private void set_info_in_controls()
        {
            try
            {
                txt_IdDistribucion.Text = info_distribucion.IdDistribucion.ToString();
                de_fecha.EditValue = info_distribucion.Fecha;
                txt_observacion.Text = info_distribucion.Observacion;
                ucCon_Periodo1.Set_Periodo(info_distribucion.IdPeriodo);

                info_distribucion.lst_x_gastos = bus_distribucion_x_gasto.get_list(info_distribucion.IdEmpresa, info_distribucion.IdDistribucion);
                blst_gastos = new BindingList<ct_distribucion_gastos_x_periodo_det_gastos_Info>(info_distribucion.lst_x_gastos);
                gridControl_saldo_cuentas.DataSource = blst_gastos;

                info_distribucion.lst_x_punto_cargo = bus_distribucion_x_punto_de_cargo.get_list(info_distribucion.IdEmpresa, info_distribucion.IdDistribucion);
                blst_punto_cargo = new BindingList<ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info>(info_distribucion.lst_x_punto_cargo);
                gridControl_saldo_cuentas.DataSource = blst_punto_cargo;
                
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ucCon_Periodo1.Get_Periodo_Info() == null)
                {
                    MessageBox.Show("Seleccione el periodo",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                 blst_gastos = new BindingList<ct_distribucion_gastos_x_periodo_det_gastos_Info>(bus_distribucion_x_gasto.get_list_para_distribucion(param.IdEmpresa, ucCon_Periodo1.Get_Periodo_Info().IdPeriodo));
                 gridControl_saldo_cuentas.DataSource = blst_gastos;               
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

        private bool Validar()
        {
            try
            {
                txt_IdDistribucion.Focus();

                if (de_fecha.EditValue == null)
                {
                    MessageBox.Show("Ingrese la fecha",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucCon_Periodo1.Get_Periodo_Info() == null)
                {
                    MessageBox.Show("Seleccione el periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void limpiar()
        {
            try
            {
                txt_IdDistribucion.Text = "";
                de_fecha.EditValue = null;
                txt_observacion.Text = null;
                ucCon_Periodo1.Set_Periodo(0);
                blst_gastos = new BindingList<ct_distribucion_gastos_x_periodo_det_gastos_Info>();
                gridControl_saldo_cuentas.DataSource = blst_gastos;
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                Cargar_combo();
                set_accion_in_controls();
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

        private void frmCon_distribucion_gastos_x_punto_cargo_Load(object sender, EventArgs e)
        {
            try
            {
                de_fecha.EditValue = DateTime.Now.Date;
                Cargar_combo();
                set_accion_in_controls();
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

        private void Cargar_combo()
        {
            try
            {
                ucCon_Periodo1.Cargar_combos();
                List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
                lst_punto_cargo = bus_punto_cargo.Get_List_punto_Cargo_con_subcentro(param.IdEmpresa);
                foreach (var item in lst_punto_cargo)
                {
                    ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info info_pc = new ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info();
                    info_pc.IdEmpresa = item.IdEmpresa;
                    info_pc.IdPunto_cargo = item.IdPunto_cargo;
                    info_pc.nom_punto_cargo = item.nom_punto_cargo;
                    info_pc.Porcentaje = 0;
                    info_pc.Checked = false;
                    blst_punto_cargo.Add(info_pc);
                }
                gridControl_punto_cargo.DataSource = blst_punto_cargo;
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

        private void frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed(sender, e);
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

        private void get_info()
        {
            try
            {
                info_distribucion.IdEmpresa = param.IdEmpresa;
                info_distribucion.IdDistribucion = txt_IdDistribucion.Text == "" ? 0 : Convert.ToDecimal(txt_IdDistribucion.Text);
                info_distribucion.IdPeriodo = ucCon_Periodo1.Get_Periodo_Info().IdPeriodo;
                info_distribucion.Fecha = Convert.ToDateTime(de_fecha.EditValue).Date;
                info_distribucion.Observacion = txt_observacion.Text;

                info_distribucion.lst_x_gastos = new List<ct_distribucion_gastos_x_periodo_det_gastos_Info>(blst_gastos.Where(q=>q.Checked==true));
                info_distribucion.lst_x_punto_cargo = new List<ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info>(blst_punto_cargo.Where(q=>q.Checked == true));
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

        private void gridView_punto_cargo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info row_pc = new ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info();
                row_pc = (ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info)gridView_punto_cargo.GetRow(e.RowHandle);
                
                if (row_pc == null)
                    return;
                if (e.Column == col_check_pc)
                {
                    calcular_porcentaje();
                }
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

        private void calcular_porcentaje()
        {
            try
            {
                int contador_check = blst_punto_cargo.Where(q => q.Checked == true).Count();
                if (contador_check != 0)
                {
                    double valor = 100 / contador_check;
                    foreach (var item in blst_punto_cargo)
                    {
                        if (item.Checked)
                            item.Porcentaje = valor;
                        else
                            item.Porcentaje = 0;                        
                    }
                    gridControl_punto_cargo.RefreshDataSource();
                }
                
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

        private void gridView_punto_cargo_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_check_pc)
                {
                    gridView_punto_cargo.SetRowCellValue(e.RowHandle, e.Column, e.Value);
                }
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_grabar())
                {
                    
                }
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_grabar())
                {
                    this.Close();
                }
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

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_grabar())
                {
                    this.Close();
                }
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

        private bool Accion_grabar()
        {
            try
            {
                bool res = false;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res = GuardarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res = ModificarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        res = AnularDB();
                        break;
                }

                return res;
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

        private bool GuardarDB()
        {
            try
            {
                if (!Validar())
                    return false;

                get_info();

                if (bus_distribucion.GuardarDB(info_distribucion))
                {
                    MessageBox.Show("Registro guardado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
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

        private bool ModificarDB()
        {
            try
            {
                if (!Validar())
                    return false;

                get_info();

                if (bus_distribucion.ModificarDB(info_distribucion))
                {
                    MessageBox.Show("Registro modificado exitosamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
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

        private bool AnularDB()
        {
            try
            {
                if (bus_distribucion.AnularDB(info_distribucion.IdEmpresa, info_distribucion.IdDistribucion))
                {
                    MessageBox.Show("Registro anulado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
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
    }
}
