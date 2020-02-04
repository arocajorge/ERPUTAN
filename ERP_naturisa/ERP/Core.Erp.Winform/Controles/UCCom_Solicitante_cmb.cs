using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;
using Core.Erp.Winform.Compras;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCCom_Solicitante_cmb : UserControl
    {

        public UCCom_Solicitante_cmb()
        {
            InitializeComponent();

            event_cmb_Solicitante_EditValueChanged += UCCom_Comprador_event_cmb_Solicitante_EditValueChanged;
            event_cmb_Solicitante_Validating += UCCom_Comprador_event_cmb_Solicitante_Validating;
            event_cmb_Solicitante_Validated += UCCom_Comprador_event_cmb_Solicitante_Validated;

        }

        #region Variables



        tb_sis_Log_Error_Vzen_Bus Log_Error_bus= new tb_sis_Log_Error_Vzen_Bus();

        List<com_solicitante_Info> listSolicitante = new List<com_solicitante_Info>();
        com_solicitante_Bus BusSolicitante = new com_solicitante_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_solicitante_Info InfoSolicitante = new com_solicitante_Info();
        FrmCom_Solicitante_Mant frm;

        public delegate void delegate_cmb_Solicitante_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_Solicitante_EditValueChanged event_cmb_Solicitante_EditValueChanged;

        public delegate void delegate_cmb_Solicitante_Validating(object sender, EventArgs e);
        public event delegate_cmb_Solicitante_Validating event_cmb_Solicitante_Validating;

        public delegate void delegate_cmb_Solicitante_Validated(object sender, EventArgs e);
        public event delegate_cmb_Solicitante_Validated event_cmb_Solicitante_Validated;

        #endregion
       
        void UCCom_Comprador_event_cmb_Solicitante_Validated(object sender, EventArgs e)
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

        void UCCom_Comprador_event_cmb_Solicitante_Validating(object sender, EventArgs e)
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

        void UCCom_Comprador_event_cmb_Solicitante_EditValueChanged(object sender, EventArgs e)
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

        private void cmb_Solicitante_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               event_cmb_Solicitante_EditValueChanged(sender, e);
              
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_Solicitante_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmb_Solicitante_Validating(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Solicitante_Validated(object sender, EventArgs e)
        {
            try
            {
                 event_cmb_Solicitante_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void cargar_Solicitante()
        {
            try
            {
                listSolicitante = new List<com_solicitante_Info>();
                listSolicitante = BusSolicitante.Get_List_Solicitante(param.IdEmpresa);
                cmb_Solicitante.Properties.DataSource = listSolicitante;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        

        public void set_SolicitanteInfo(decimal IdComprador)
        {
            try
            {
                cmb_Solicitante.EditValue = IdComprador;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public com_solicitante_Info get_SolicitanteInfo()
        {
            try
            {
                InfoSolicitante = listSolicitante.FirstOrDefault(v => v.IdSolicitante == Convert.ToDecimal(cmb_Solicitante.EditValue));
                return InfoSolicitante;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new com_solicitante_Info();
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
                get_SolicitanteInfo();
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
                get_SolicitanteInfo();
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
                frm = new FrmCom_Solicitante_Mant();

                frm.Set_Accion(Accion);

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.Set_Info(InfoSolicitante);
                }

                frm.event_FrmCom_Solicitante_Mant_FormClosing += frm_event_FrmCom_Solicitante_Mant_FormClosing;
                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_FrmCom_Solicitante_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_Solicitante();
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
                cmb_Solicitante.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmb_Solicitante()
        {
            try
            {
                cmb_Solicitante.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCCom_Solicitante_cmb_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_Solicitante();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Solicitante_EditValueChanged_1(object sender, EventArgs e)
        {

        }

      


    }
}
