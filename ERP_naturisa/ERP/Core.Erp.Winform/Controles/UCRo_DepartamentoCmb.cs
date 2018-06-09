using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.Roles;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCRo_DepartamentoCmb : UserControl
    {
        #region Variables
        ro_Departamento_Bus DepartamentoBus = new ro_Departamento_Bus();
        List<ro_Departamento_Info> listDepartamento = new List<ro_Departamento_Info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Departamento_Info InfoDepartamento = new ro_Departamento_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_cmb_departamento_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_departamento_EditValueChanged event_cmb_departamento_EditValueChanged;
        private int _IdDepartamento;
        frmRo_Departamento_Mant frm;
        #endregion



        public Boolean Visible_btn_Acciones
        {
            get
            {
                return this.btn_Acciones.Visible;
            }
            set
            {
                this.btn_Acciones.Visible = value;
            }
        }


        public Boolean Enable_btn_Acciones
        {
            get
            {
                return this.btn_Acciones.Enabled;
            }
            set
            {
                this.btn_Acciones.Enabled = value;
            }
        }

        public UCRo_DepartamentoCmb()
        {
            InitializeComponent();
            event_cmb_departamento_EditValueChanged += UCRo_DepartamentoCmb_event_cmb_departamento_EditValueChanged;
        }

        void UCRo_DepartamentoCmb_event_cmb_departamento_EditValueChanged(object sender, EventArgs e)
        {
            
        }
       
        public void cargar_combo()
        {
            try
            {
                listDepartamento = new List<ro_Departamento_Info>();
                listDepartamento = DepartamentoBus.Get_List_Departamento(param.IdEmpresa);
                cmb_departamento.Properties.DataSource = listDepartamento;
                if (listDepartamento.Count() != 0)
                {
                   // cmb_departamento.EditValue = listDepartamento.First().IdDepartamento;
                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        
        public void set_departamentoInfo( decimal IdDepartamento)
        {
            try
            {
                cmb_departamento.EditValue = IdDepartamento;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ro_Departamento_Info get_departamentoInfo()
        {
            try
            {
                InfoDepartamento = listDepartamento.FirstOrDefault(v => v.IdDepartamento == Convert.ToDecimal(cmb_departamento.EditValue));
                return InfoDepartamento;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }

        }

        private void cmb_departamento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmb_departamento_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCRo_DepartamentoCmb_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combo();
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
                MenuAcciones.Show(btn_Acciones, new Point(0, btn_Acciones.Height));
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
                get_departamentoInfo();
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
                get_departamentoInfo();
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
                frm = new frmRo_Departamento_Mant();
                frm.Event_frmRo_Departamento_Mant_FormClosing += new frmRo_Departamento_Mant.delegate_frmRo_Departamento_Mant_FormClosing(frm_Event_frmRo_Departamento_Mant_FormClosing);

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_Info(InfoDepartamento);
                    frm.set_Accion(Accion);

                }
                else
                    frm.set_Accion(Accion);

                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_Event_frmRo_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_combo();
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
                btn_Acciones.Enabled = false;
                cmb_departamento.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmb_departamento()
        {
            try
            {
                cmb_departamento.EditValue = null;

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
