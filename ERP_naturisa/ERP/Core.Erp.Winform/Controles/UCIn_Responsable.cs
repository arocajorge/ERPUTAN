using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Winform.Inventario;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_Responsable : UserControl
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<in_responsable_Info> listComprador = new List<in_responsable_Info>();
        in_responsable_Bus BusComprador = new in_responsable_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_responsable_Info InfoComprador = new in_responsable_Info();
        FrmIn_responsable_Mant frm;
        public delegate void delegate_cmb_comprador_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_comprador_EditValueChanged event_cmb_comprador_EditValueChanged;

        public delegate void delegate_cmb_comprador_Validating(object sender, EventArgs e);
        public event delegate_cmb_comprador_Validating event_cmb_comprador_Validating;

        public delegate void delegate_cmb_comprador_Validated(object sender, EventArgs e);
        public event delegate_cmb_comprador_Validated event_cmb_comprador_Validated;

        #endregion

        public UCIn_Responsable()
        {
            InitializeComponent();
        }

        public void set_Info_Responsable(decimal IdResponsable)
        {
            try
            {
                if(IdResponsable != 0)
                    cmb_responsable.EditValue = IdResponsable;
                else
                    cmb_responsable.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public in_responsable_Info get_Info_Responsable()
        {
            try
            {
                InfoComprador = listComprador.FirstOrDefault(v => v.IdResponsable == Convert.ToDecimal(cmb_responsable.EditValue));
                return InfoComprador;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new in_responsable_Info();
            }
        }

        void cargar_Responsable()
        {
            try
            {
                listComprador = new List<in_responsable_Info>();
                listComprador = BusComprador.Get_List_Responsable(param.IdEmpresa);
                cmb_responsable.Properties.DataSource = listComprador;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                FrmIn_responsable_Mant frm1 = new FrmIn_responsable_Mant();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm1 = new FrmIn_responsable_Mant(Accion);
                    frm1._SetInfo = InfoComprador;
                }
                else
                    frm1 = new FrmIn_responsable_Mant(Accion);

                frm1.event_delegate_FrmIn_responsable_Mant_FormClosing += frm1_event_delegate_FrmIn_responsable_Mant_FormClosing;
                frm1.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm1_event_delegate_FrmIn_responsable_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_Responsable();
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
                get_Info_Responsable();
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
                get_Info_Responsable();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
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
                cmb_responsable.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCIn_Responsable_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_Responsable();
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
