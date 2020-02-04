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
    public partial class UCCaj_MovEgresoCaj_cmb : UserControl
    {
        #region Variables

        List<caj_Caja_Movimiento_Tipo_Info> listMovimiento;
        caj_Caja_Movimiento_Tipo_Bus BusMovimiento = new caj_Caja_Movimiento_Tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        caj_Caja_Movimiento_Tipo_Info InfoMovimiento = new caj_Caja_Movimiento_Tipo_Info();
        FrmCa_caj_Caja_Movimiento_Tipo frm;
        string MensajeError = "";

        public delegate void delegate_cmbTipoMoviCaja_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbTipoMoviCaja_EditValueChanged event_cmbTipoMoviCaja_EditValueChanged;

        public delegate void delegate_cmbTipoMoviCaja_Validating(object sender, EventArgs e);
        public event delegate_cmbTipoMoviCaja_Validating event_cmbTipoMoviCaja_Validating;

        public delegate void delegate_cmbTipoMoviCaja_Validated(object sender, EventArgs e);
        public event delegate_cmbTipoMoviCaja_Validated event_cmbTipoMoviCaja_Validated;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        

        #endregion

        public UCCaj_MovEgresoCaj_cmb()
        {
            InitializeComponent();
            event_cmbTipoMoviCaja_EditValueChanged += UCCaj_MovEgresoCaj_cmb_event_cmbTipoMoviCaja_EditValueChanged;
            event_cmbTipoMoviCaja_Validating += UCCaj_MovEgresoCaj_cmb_event_cmbTipoMoviCaja_Validating;
            event_cmbTipoMoviCaja_Validated += UCCaj_MovEgresoCaj_cmb_event_cmbTipoMoviCaja_Validated;
        }

        void UCCaj_MovEgresoCaj_cmb_event_cmbTipoMoviCaja_Validated(object sender, EventArgs e)
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

        void UCCaj_MovEgresoCaj_cmb_event_cmbTipoMoviCaja_Validating(object sender, EventArgs e)
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

        void UCCaj_MovEgresoCaj_cmb_event_cmbTipoMoviCaja_EditValueChanged(object sender, EventArgs e)
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

        private void UCCaj_MovEgresoCaj_cmb_Load(object sender, EventArgs e)
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
                listMovimiento = BusMovimiento.Get_list_Caja_Movimiento_Tipo(param.IdEmpresa,Cl_Enumeradores.eTipo_Ing_Egr.EGRESOS, ref MensajeError);
                cmbTipoMoviCaja.Properties.DataSource = listMovimiento;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbTipoMoviCaja_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbTipoMoviCaja_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbTipoMoviCaja_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbTipoMoviCaja_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbTipoMoviCaja_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbTipoMoviCaja_Validating(sender, e);
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new FrmCa_caj_Caja_Movimiento_Tipo();
                frm.event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing += new FrmCa_caj_Caja_Movimiento_Tipo.delegate_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing(frm_event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing);

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
                cmbTipoMoviCaja.Properties.ReadOnly = true;

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
                cmbTipoMoviCaja.Properties.ReadOnly = false;//opin2017/03/27
                cmbTipoMoviCaja.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_MovimientoInfo(int IdTipoMovi)
        {
            try
            {
                if (IdTipoMovi == 0)                
                    cmbTipoMoviCaja.EditValue = null;
                else
                    cmbTipoMoviCaja.EditValue = IdTipoMovi;
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
                if (cmbTipoMoviCaja.EditValue != null)
                {
                    InfoMovimiento = listMovimiento.FirstOrDefault(v => v.IdTipoMovi == Convert.ToInt32(cmbTipoMoviCaja.EditValue));
                }
                else
                    InfoMovimiento = null;
                return InfoMovimiento;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }

        }

    }
}
