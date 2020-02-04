using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.Caja;
using Core.Erp.Info.Caja;
using Core.Erp.Business.General;
using Core.Erp.Winform.Caja;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCaj_MovIngresoCaj_cmb : UserControl
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus= new tb_sis_Log_Error_Vzen_Bus();




        List<caj_Caja_Movimiento_Tipo_Info> listMovimiento;
        caj_Caja_Movimiento_Tipo_Bus BusMovimiento = new caj_Caja_Movimiento_Tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        caj_Caja_Movimiento_Tipo_Info InfoMovimiento = new caj_Caja_Movimiento_Tipo_Info();
        FrmCa_caj_Caja_Movimiento_Tipo frm;
        string MensajeError = "";

        public delegate void delegate_cmb_CajMovIngreso_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_CajMovIngreso_EditValueChanged event_cmb_CajMovIngreso_EditValueChanged;

        public delegate void delegate_cmb_CajMovIngreso_Validating(object sender, EventArgs e);
        public event delegate_cmb_CajMovIngreso_Validating event_cmb_CajMovIngreso_Validating;

        public delegate void delegate_cmb_CajMovIngreso_Validated(object sender, EventArgs e);
        public event delegate_cmb_CajMovIngreso_Validated event_cmb_CajMovIngreso_Validated;

        #endregion
        
        
        
        public UCCaj_MovIngresoCaj_cmb()
        {
            InitializeComponent();
            event_cmb_CajMovIngreso_EditValueChanged += UCCaj_MovIngresoCaj_cmb_event_cmb_CajMovIngreso_EditValueChanged;
            event_cmb_CajMovIngreso_Validating += UCCaj_MovIngresoCaj_cmb_event_cmb_CajMovIngreso_Validating;
            event_cmb_CajMovIngreso_Validated += UCCaj_MovIngresoCaj_cmb_event_cmb_CajMovIngreso_Validated;
        }

        void UCCaj_MovIngresoCaj_cmb_event_cmb_CajMovIngreso_Validated(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void UCCaj_MovIngresoCaj_cmb_event_cmb_CajMovIngreso_Validating(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void UCCaj_MovIngresoCaj_cmb_event_cmb_CajMovIngreso_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCCaj_MovIngresoCaj_cmb_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_Movimiento();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void cargar_Movimiento()
        {
            try
            {
                listMovimiento = new List<caj_Caja_Movimiento_Tipo_Info>();
                listMovimiento = BusMovimiento.Get_list_Caja_Movimiento_Tipo(param.IdEmpresa,Cl_Enumeradores.eTipo_Ing_Egr.INGRESOS, ref MensajeError);
                cmb_CajMovIngreso.Properties.DataSource = listMovimiento;
                cmb_CajMovIngreso.Properties.DisplayMember = "tm_descripcion";
                cmb_CajMovIngreso.Properties.ValueMember = "IdTipoMovi";

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_CajMovIngreso_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmb_CajMovIngreso_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_CajMovIngreso_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmb_CajMovIngreso_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_CajMovIngreso_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmb_CajMovIngreso_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cmb_Acciones_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones.Show(cmb_Acciones, new Point(0, cmb_Acciones.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new FrmCa_caj_Caja_Movimiento_Tipo();
                frm.event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing += frm_event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing;
                

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_accion(Accion);
                    frm.set_TipoMovi(InfoMovimiento);

                }
                else
                    frm.set_accion(Accion);

                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_Movimiento();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Perfil_Lectura()
        {
            try
            {
                cmb_Acciones.Enabled = false;
                cmb_CajMovIngreso.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmb_comprador()
        {
            try
            {
                cmb_Acciones.Enabled = true;//opin2017/03/27
                cmb_CajMovIngreso.Properties.ReadOnly = false;//opin2017/03/27
                cmb_CajMovIngreso.EditValue = null;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_MovimientoInfo(int? IdTipoMovi)
        {
            try
            {
                cmb_CajMovIngreso.EditValue = IdTipoMovi;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public caj_Caja_Movimiento_Tipo_Info get_MovimientoInfo()
        {
            try
            {
                InfoMovimiento = new caj_Caja_Movimiento_Tipo_Info();
                if (cmb_CajMovIngreso.EditValue != null)
                    InfoMovimiento = listMovimiento.FirstOrDefault(v => v.IdTipoMovi == Convert.ToInt32(cmb_CajMovIngreso.EditValue));
                return InfoMovimiento;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new caj_Caja_Movimiento_Tipo_Info();
            }

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            try
            {
                get_MovimientoInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                get_MovimientoInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
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
