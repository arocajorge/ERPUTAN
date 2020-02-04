using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Winform.ActivoFijo;


namespace Core.Erp.Winform.Controles
{
    public partial class UCAF_Activo_Categoria_cmb : UserControl
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<Af_Activo_fijo_Categoria_Info> List_Activo_fijo_Categoria = new List<Af_Activo_fijo_Categoria_Info>();
        Af_Activo_fijo_Categoria_Bus Bus_Activo_fijo_Categoria = new Af_Activo_fijo_Categoria_Bus();
        Af_Activo_fijo_Categoria_Info Info_Activo_fijo_Categoria = new Af_Activo_fijo_Categoria_Info();


        frmAf_Activo_fijo_Categoria_Mant frm;

        public delegate void delegate_cmbActivoFijo_Categoria_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbActivoFijo_Categoria_EditValueChanged event_cmbActivoFijo_Categoria_EditValueChanged;

        public delegate void delegate_cmbActivoFijo_Categoria_Validating(object sender, EventArgs e);
        public event delegate_cmbActivoFijo_Categoria_Validating event_cmbActivoFijo_Categoria_Validating;

        public delegate void delegate_cmbActivoFijo_Categoria_Validated(object sender, EventArgs e);
        public event delegate_cmbActivoFijo_Categoria_Validated event_cmbActivoFijo_Categoria_Validated;

        int IdTipo = 0;
        string MensajeError = "";
        #endregion

        public UCAF_Activo_Categoria_cmb()
        {
            InitializeComponent();

            event_cmbActivoFijo_Categoria_EditValueChanged += UCAF_Activo_Categoria_cmb_event_cmbActivoFijo_Categoria_EditValueChanged;
            event_cmbActivoFijo_Categoria_Validated += UCAF_Activo_Categoria_cmb_event_cmbActivoFijo_Categoria_Validated;
            event_cmbActivoFijo_Categoria_Validating += UCAF_Activo_Categoria_cmb_event_cmbActivoFijo_Categoria_Validating;
        }

        void UCAF_Activo_Categoria_cmb_event_cmbActivoFijo_Categoria_Validating(object sender, EventArgs e)
        {
            
        }

        void UCAF_Activo_Categoria_cmb_event_cmbActivoFijo_Categoria_Validated(object sender, EventArgs e)
        {
            
        }

        void UCAF_Activo_Categoria_cmb_event_cmbActivoFijo_Categoria_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        public void cargar(int IdActivoFijoTipo)
        {
            try
            {
                IdTipo = IdActivoFijoTipo;
                List_Activo_fijo_Categoria = new List<Af_Activo_fijo_Categoria_Info>();
                List_Activo_fijo_Categoria = Bus_Activo_fijo_Categoria.Get_List_Activo_fijo_Categoria(param.IdEmpresa, IdTipo, ref MensajeError);
                cmbActivoFijo_Categoria.Properties.DataSource = List_Activo_fijo_Categoria;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void llamar_formulario(Cl_Enumeradores.eTipo_action accion)
        {
            try
            {
                frm = new frmAf_Activo_fijo_Categoria_Mant();
                frm.event_frmAf_Activo_fijo_Categoria_Mant_FormClosing += frm_event_frmAf_Activo_fijo_Categoria_Mant_FormClosing;

                frm.set_Accion(accion);

                if (accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Info_Activo_fijo_Categoria != null)
                    {
                        if (Info_Activo_fijo_Categoria.IdCategoriaAF != 0)
                        {
                            frm.Set_Info_Categoria(Info_Activo_fijo_Categoria);
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("no ha seleccionado ningún registro.\n seleccione un registro.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("no ha seleccionado ningún registro.\n seleccione un registro.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void frm_event_frmAf_Activo_fijo_Categoria_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            cargar(IdTipo);
        }

        private void nuevotoolstripmenuitem_click(object sender, EventArgs e)
        {
            try
            {
                llamar_formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void modificartoolstripmenuitem_click(object sender, EventArgs e)
        {
            try
            {
                Info_Activo_fijo_Categoria = get_info();
                llamar_formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void consultartoolstripmenuitem_click(object sender, EventArgs e)
        {
            try
            {
                get_info();
                llamar_formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Af_Activo_fijo_Categoria_Info get_info()
        {
            try
            {
                Info_Activo_fijo_Categoria = new Af_Activo_fijo_Categoria_Info();

                if (cmbActivoFijo_Categoria.EditValue != null)
                    Info_Activo_fijo_Categoria = List_Activo_fijo_Categoria.FirstOrDefault(v => v.IdCategoriaAF == Convert.ToDecimal(cmbActivoFijo_Categoria.EditValue));
                else
                {
                    Info_Activo_fijo_Categoria = null;
                }

                return Info_Activo_fijo_Categoria;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Af_Activo_fijo_Categoria_Info();
            }
        }

        public void set_info(int IdActivo_fijo_Categoria)
        {
            try
            {
                if (IdActivo_fijo_Categoria != 0)
                {
                    cmbActivoFijo_Categoria.EditValue = IdActivo_fijo_Categoria;
                }
                else cmbActivoFijo_Categoria.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void menuacciones_opening(object sender, CancelEventArgs e)
        {

        }

        public void inicializar_cmb_activofijo_Categoria()
        {
            try
            {
                cmbActivoFijo_Categoria.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCAF_Activo_Categoria_cmb_Load(object sender, EventArgs e)
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

        private void cmbActivoFijo_Categoria_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbActivoFijo_Categoria_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbActivoFijo_Categoria_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbActivoFijo_Categoria_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbActivoFijo_Categoria_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbActivoFijo_Categoria_Validating(sender, e);
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
    }
}
