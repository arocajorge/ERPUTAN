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
    public partial class UCCom_Departamento_cmb : UserControl
    {
        public bool Cargar_Departamento 
        { set {  cargar_Departemento();}
        }


        public UCCom_Departamento_cmb()
        {
            InitializeComponent();

             event_cmb_Departamento_EditValueChanged += UCCom_Departamento_event_cmb_Departamento_EditValueChanged;
            event_cmb_Departamento_Validating += UCCom_Departamento_event_cmb_Departamento_Validating;
            event_cmb_Departamento_Validated += UCCom_Departamento_event_cmb_Departamento_Validated;
        }

        #region Variables



            tb_sis_Log_Error_Vzen_Bus Log_Error_bus= new tb_sis_Log_Error_Vzen_Bus();

            List<com_departamento_Info> listSolicitante = new List<com_departamento_Info>();
            com_departamento_Bus BusSolicitante = new com_departamento_Bus();

            cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
            com_departamento_Info InfoDepartamento = new com_departamento_Info();

            FrmCom_Departamento_Mant frm;

            public delegate void delegate_cmb_Departamento_EditValueChanged(object sender, EventArgs e);
            public event delegate_cmb_Departamento_EditValueChanged event_cmb_Departamento_EditValueChanged;

            public delegate void delegate_cmb_Departamento_Validating(object sender, EventArgs e);
            public event delegate_cmb_Departamento_Validating event_cmb_Departamento_Validating;

            public delegate void delegate_cmb_Departamento_Validated(object sender, EventArgs e);
            public event delegate_cmb_Departamento_Validated event_cmb_Departamento_Validated;

        #endregion
       
        void UCCom_Departamento_event_cmb_Departamento_Validated(object sender, EventArgs e)
        {

        }

        void UCCom_Departamento_event_cmb_Departamento_Validating(object sender, EventArgs e)
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

        void UCCom_Departamento_event_cmb_Departamento_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Departamento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               event_cmb_Departamento_EditValueChanged(sender, e);
              
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_Departamento_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmb_Departamento_Validating(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Departamento_Validated(object sender, EventArgs e)
        {
            try
            {
                 event_cmb_Departamento_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cargar_Departemento()
        {
            try
            {
                listSolicitante = new List<com_departamento_Info>();
                listSolicitante = BusSolicitante.Get_List_Departamento(param.IdEmpresa);
                cmb_Departamento.Properties.DataSource = listSolicitante;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_DepartamentoInfo(decimal IdComprador)
        {
            try
            {
                cmb_Departamento.EditValue = IdComprador;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public com_departamento_Info Get_Info_Departamento()
        {
            try
            {
                InfoDepartamento = listSolicitante.FirstOrDefault(v => v.IdDepartamento == Convert.ToDecimal(cmb_Departamento.EditValue));
                return InfoDepartamento;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new com_departamento_Info();
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
                Get_Info_Departamento();
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
                Get_Info_Departamento();
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
                frm = new FrmCom_Departamento_Mant();

                frm.set_Accion(Accion);

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.Set_Info_Departamento(InfoDepartamento);
                }

                frm.event_FrmCom_Departamento_Mant_FormClosing += frm_event_FrmCom_Departamento_Mant_FormClosing;
                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_FrmCom_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_Departemento();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmb_Departamento()
        {
            try
            {
                cmb_Departamento.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCCom_Departamento_cmb_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_Departemento();
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
