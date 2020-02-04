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
    public partial class UCAf_DepartamentoCmb : UserControl
    {

                
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<Af_Departamento_Info> List_Departamento = new List<Af_Departamento_Info>();
        Af_Departamento_Bus Bus_Departamento = new Af_Departamento_Bus();
        Af_Departamento_Info Info_Departamento = new Af_Departamento_Info();

        frmAF_Departamento_Mant frm;

        public delegate void delegate_cmbDepartamento_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbDepartamento_EditValueChanged event_cmbDepartamento_EditValueChanged;

        public delegate void delegate_cmbDepartamento_Validating(object sender, EventArgs e);
        public event delegate_cmbDepartamento_Validating event_cmbDepartamento_Validating;

        public delegate void delegate_cmbDepartamento_Validated(object sender, EventArgs e);
        public event delegate_cmbDepartamento_Validated event_cmbDepartamento_Validated;



        #endregion

        public UCAf_DepartamentoCmb()
        {
            InitializeComponent();
            event_cmbDepartamento_EditValueChanged += UCFa_Motivo_venta_event_cmbDepartamento_EditValueChanged;
            event_cmbDepartamento_Validated += UCFa_Motivo_venta_event_cmbDepartamento_Validated;
            event_cmbDepartamento_Validating += UCFa_Motivo_venta_event_cmbDepartamento_Validating;

            
        }

        void UCFa_Motivo_venta_event_cmbDepartamento_Validating(object sender, EventArgs e)
        {
            
        }

        void UCFa_Motivo_venta_event_cmbDepartamento_Validated(object sender, EventArgs e)
        {
            
        }

        void UCFa_Motivo_venta_event_cmbDepartamento_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbDepartamento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbDepartamento_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbDepartamento_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbDepartamento_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbDepartamento_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbDepartamento_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void cargar()
        {
            try
            {
                List_Departamento = new List<Af_Departamento_Info>();
                List_Departamento = Bus_Departamento.Get_List_Departamento(param.IdEmpresa);
                cmbDepartamento.Properties.DataSource = List_Departamento;
                //if (List_Departamento.Count > 0)
                //{
                //    cmbDepartamento.EditValue = List_Departamento.First().IdDepartamento;
                //}
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
                frm = new frmAF_Departamento_Mant();
                frm.event_frmAF_Departamento_Mant_FormClosing +=frm_event_frmAF_Departamento_Mant_FormClosing;
                frm.Set_Accion(Accion);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Info_Departamento != null)
                    {
                        if (Info_Departamento.IdDepartamento != 0)
                        {
                            frm.Set_Info(Info_Departamento);
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

        void frm_event_frmAF_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
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
                Info_Departamento=get_Info();
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

        public Af_Departamento_Info get_Info()
        {
            try
            {
                Info_Departamento = new Af_Departamento_Info();

                if (cmbDepartamento.EditValue != null)
                    Info_Departamento = List_Departamento.FirstOrDefault(v => v.IdDepartamento == Convert.ToDecimal(cmbDepartamento.EditValue));
                else
                {
                    Info_Departamento = null;
                }

                return Info_Departamento;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Af_Departamento_Info();
            }

        }

        public void set_Info(int IdDepartamento)
        {
            try
            {
                if (IdDepartamento != 0)
                {
                    cmbDepartamento.EditValue = IdDepartamento;
                }
                else cmbDepartamento.EditValue = null;
                
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

        private void UCAf_DepartamentoCmb_Load(object sender, EventArgs e)
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
        public void Inicializar_cmb_departamento()
        {
            try
            {
                cmbDepartamento.EditValue = null;

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
