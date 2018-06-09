using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Persona_cmb : UserControl
    {

        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        List<tb_persona_Info> ListPersona = new List<tb_persona_Info>();
        tb_persona_bus BusPersona = new tb_persona_bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        frmGe_MantPersona frm;

        tb_persona_Info InfoPersona = new tb_persona_Info();


        public delegate void delegate_cmbPersona_Vta_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbPersona_Vta_EditValueChanged event_cmbPersona_Vta_EditValueChanged;


        public delegate void delegate_cmbPersona_Vta_Validating(object sender, EventArgs e);
        public event delegate_cmbPersona_Vta_Validating event_cmbPersona_Vta_Validating;


        public delegate void delegate_cmbPersona_Vta_Validated(object sender, EventArgs e);
        public event delegate_cmbPersona_Vta_Validated event_cmbPersona_Vta_Validated;


        #endregion

        public UCGe_Persona_cmb()
        {
            InitializeComponent();

            event_cmbPersona_Vta_EditValueChanged += UCFa_Motivo_venta_event_cmbPersona_Vta_EditValueChanged;
            event_cmbPersona_Vta_Validated += UCFa_Motivo_venta_event_cmbPersona_Vta_Validated;
            event_cmbPersona_Vta_Validating += UCFa_Motivo_venta_event_cmbPersona_Vta_Validating;
            cargar();
        }
          

        

        void UCFa_Motivo_venta_event_cmbPersona_Vta_Validating(object sender, EventArgs e)
        {
            
        }

        void UCFa_Motivo_venta_event_cmbPersona_Vta_Validated(object sender, EventArgs e)
        {
            
        }

        void UCFa_Motivo_venta_event_cmbPersona_Vta_EditValueChanged(object sender, EventArgs e)
        {
            
        }


        private void cmbPersona_Vta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbPersona_Vta_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbPersona_Vta_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbPersona_Vta_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbPersona_Vta_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbPersona_Vta_Validated(sender, e);
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
                ListPersona = new List<tb_persona_Info>();
                ListPersona = BusPersona.Get_List_Persona();
                cmbPersona.Properties.DataSource = ListPersona;
                if (ListPersona.Count > 0)
                {
                    cmbPersona.EditValue = ListPersona.FirstOrDefault().IdPersona;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCFa_Motivo_venta_Load(object sender, EventArgs e)
        {
            try
            {
              //  cargar();
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
                frm = new frmGe_MantPersona();
                frm.event_frmGe_MantPersona_FormClosing += frm_event_frmGe_MantPersona_FormClosing;

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_Persona(InfoPersona);
                    frm.set_Accion(Accion);
                }
                else
                    frm.set_Accion(Accion);

                frm.Show();

                MessageBox.Show("En construccion disculpe las molestias", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_frmGe_MantPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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
                get_Info();
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

        public tb_persona_Info get_Info()
        {
            try
            {
                InfoPersona = new tb_persona_Info();
                if (cmbPersona.EditValue != null)
                    InfoPersona = ListPersona.FirstOrDefault(v => v.IdPersona == Convert.ToDecimal(cmbPersona.EditValue));

                return InfoPersona;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_persona_Info();
            }

        }

        public void set_Info(int IdMotivo_Vta)
        {
            try
            {
                cmbPersona.EditValue = IdMotivo_Vta;
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
