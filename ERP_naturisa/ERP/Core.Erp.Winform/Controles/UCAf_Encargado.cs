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
    public partial class UCAf_Encargado : UserControl
    {       
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<Af_Encargado_Info> List_Encargado = new List<Af_Encargado_Info>();
        Af_Encargado_Bus Bus_Encargado = new Af_Encargado_Bus();
        Af_Encargado_Info Info_Encargado = new Af_Encargado_Info();

        frmAf_Encargado_Mant frm;

        public delegate void delegate_cmbEncargado_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbEncargado_EditValueChanged event_cmbEncargado_EditValueChanged;

        public delegate void delegate_cmbEncargado_Validating(object sender, EventArgs e);
        public event delegate_cmbEncargado_Validating event_cmbEncargado_Validating;

        public delegate void delegate_cmbEncargado_Validated(object sender, EventArgs e);
        public event delegate_cmbEncargado_Validated event_cmbEncargado_Validated;

        #endregion

        #region Propiedades
        public Boolean Visible_cmb_Accion { get { return this.cmb_Acciones.Visible; } set { this.cmb_Acciones.Visible = value; } }
        public Boolean ReadOnly_cmb_Encargago { get { return this.cmbEncargado.Properties.ReadOnly; } set { this.cmbEncargado.Properties.ReadOnly = value; } }
        #endregion

        public UCAf_Encargado()
        {
            InitializeComponent();
            event_cmbEncargado_EditValueChanged += UCAf_Encargado_event_cmbEncargado_EditValueChanged;
            event_cmbEncargado_Validated += UCAf_Encargado_event_cmbEncargado_Validated;
            event_cmbEncargado_Validating += UCAf_Encargado_event_cmbEncargado_Validating;
            
        }

        void UCAf_Encargado_event_cmbEncargado_Validated(object sender, EventArgs e)
        {
            
        }

        void UCAf_Encargado_event_cmbEncargado_Validating(object sender, EventArgs e)
        {

        }

        void UCAf_Encargado_event_cmbEncargado_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbEncargado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbEncargado_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbEncargado_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbEncargado_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbEncargado_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbEncargado_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void cargar()
        {
            try
            {
                List_Encargado = new List<Af_Encargado_Info>();
                List_Encargado = Bus_Encargado.Get_List_Encargado(param.IdEmpresa);
                cmbEncargado.Properties.DataSource = List_Encargado;
                if (List_Encargado.Count > 0)
                {
                    cmbEncargado.EditValue = List_Encargado.First().IdEncargado;
                }
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
                frm = new frmAf_Encargado_Mant();
                frm.event_frmAf_Encargado_FormClosing += frm_event_frmAf_Encargado_FormClosing;
                frm.Set_Accion(Accion);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Info_Encargado != null)
                    {
                        if (Info_Encargado.IdEncargado != 0)
                        {
                            frm.Set_Info(Info_Encargado);
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

        void frm_event_frmAf_Encargado_FormClosing(object sender, FormClosingEventArgs e)
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
                Info_Encargado = get_Info();
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

        public Af_Encargado_Info get_Info()
        {
            try
            {
                Info_Encargado = new Af_Encargado_Info();

                if (cmbEncargado.EditValue != null)
                    Info_Encargado = List_Encargado.FirstOrDefault(v => v.IdEncargado == Convert.ToDecimal(cmbEncargado.EditValue));

                return Info_Encargado;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Af_Encargado_Info();
            }

        }

        public void set_Info(decimal IdEncargado)
        {
            try
            {
                if (IdEncargado!=0)
                {
                    cmbEncargado.EditValue = IdEncargado;    
                }else
                    cmbEncargado.EditValue = null;
                
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

        private void UCAf_Encargado_Load(object sender, EventArgs e)
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

        public void Inicializar_Encargado()
        {
            try
            {
                cmbEncargado.EditValue = null;

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
