using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Winform.ActivoFijo;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCAF_Activo_fijo_Tipo_cmb : UserControl
    {

        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<Af_Activo_fijo_tipo_Info> List_Activo_fijo_tipo = new List<Af_Activo_fijo_tipo_Info>();
        Af_Activo_fijo_tipo_Bus Bus_Activo_fijo_tipo = new Af_Activo_fijo_tipo_Bus();
        Af_Activo_fijo_tipo_Info Info_Activo_fijo_tipo = new Af_Activo_fijo_tipo_Info();


        frmAF_ActivoFijoTipo_Mant frm;

        public delegate void delegate_cmbActivoFijo_Tipo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbActivoFijo_Tipo_EditValueChanged event_cmbActivoFijo_Tipo_EditValueChanged;

        public delegate void delegate_cmbActivoFijo_Tipo_Validating(object sender, EventArgs e);
        public event delegate_cmbActivoFijo_Tipo_Validating event_cmbActivoFijo_Tipo_Validating;

        public delegate void delegate_cmbActivoFijo_Tipo_Validated(object sender, EventArgs e);
        public event delegate_cmbActivoFijo_Tipo_Validated event_cmbActivoFijo_Tipo_Validated;



        #endregion

        public UCAF_Activo_fijo_Tipo_cmb()
        {
            InitializeComponent();

            event_cmbActivoFijo_Tipo_EditValueChanged += UCAF_Activo_fijo_Tipo_cmb_event_cmbActivoFijo_Tipo_EditValueChanged;
            event_cmbActivoFijo_Tipo_Validated += UCAF_Activo_fijo_Tipo_cmb_event_cmbActivoFijo_Tipo_Validated;
            event_cmbActivoFijo_Tipo_Validating += UCAF_Activo_fijo_Tipo_cmb_event_cmbActivoFijo_Tipo_Validating;
        }

        void UCAF_Activo_fijo_Tipo_cmb_event_cmbActivoFijo_Tipo_Validating(object sender, EventArgs e)
        {

        }

        void UCAF_Activo_fijo_Tipo_cmb_event_cmbActivoFijo_Tipo_Validated(object sender, EventArgs e)
        {

        }

        void UCAF_Activo_fijo_Tipo_cmb_event_cmbActivoFijo_Tipo_EditValueChanged(object sender, EventArgs e)
        {

        }

        public void cargar()
        {
            try
            {
                List_Activo_fijo_tipo = new List<Af_Activo_fijo_tipo_Info>();
                List_Activo_fijo_tipo = Bus_Activo_fijo_tipo.Get_List_ActivoFijoTipo(param.IdEmpresa);
                cmbActivoFijo_Tipo.Properties.DataSource = List_Activo_fijo_tipo;

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
                frm = new frmAF_ActivoFijoTipo_Mant();
                frm.event_frmAF_ActivoFijoTipo_Mant_FormClosing += frm_event_frmAF_ActivoFijoTipo_Mant_FormClosing;

                frm.set_Accion(Accion);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Info_Activo_fijo_tipo != null)
                    {
                        if (Info_Activo_fijo_tipo.IdActivoFijoTipo != 0)
                        {
                            frm.set_ActivoFijoTipo(Info_Activo_fijo_tipo);
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("No ha seleccionado ningún registro.\n Seleccione un registro.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ningún registro.\n Seleccione un registro.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_frmAF_ActivoFijoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            cargar();
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
                Info_Activo_fijo_tipo = get_Info();
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
                get_Info();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Af_Activo_fijo_tipo_Info get_Info()
        {
            try
            {
                Info_Activo_fijo_tipo = new Af_Activo_fijo_tipo_Info();

                if (cmbActivoFijo_Tipo.EditValue != null)
                    Info_Activo_fijo_tipo = List_Activo_fijo_tipo.FirstOrDefault(v => v.IdActivoFijoTipo == Convert.ToDecimal(cmbActivoFijo_Tipo.EditValue));
                else
                {
                    Info_Activo_fijo_tipo = null;
                }

                return Info_Activo_fijo_tipo;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Af_Activo_fijo_tipo_Info();
            }

        }

        public void set_Info(int IdActivo_fijo_tipo)
        {
            try
            {
                if (IdActivo_fijo_tipo != 0)
                {
                    cmbActivoFijo_Tipo.EditValue = IdActivo_fijo_tipo;
                }
                else cmbActivoFijo_Tipo.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void MenuAcciones_Opening(object sender, CancelEventArgs e)
        {

        }

        public void Inicializar_cmb_ActivoFijo()
        {
            try
            {
                cmbActivoFijo_Tipo.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCAF_Activo_fijo_Tipo_cmb_Load(object sender, EventArgs e)
        {
            try
            {
                cargar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cmbActivoFijo_Tipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbActivoFijo_Tipo_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbActivoFijo_Tipo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbActivoFijo_Tipo_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbActivoFijo_Tipo_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbActivoFijo_Tipo_Validated(sender, e);
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
