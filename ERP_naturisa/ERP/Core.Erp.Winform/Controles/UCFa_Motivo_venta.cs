using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Info.General;



namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_Motivo_venta : UserControl
    {



        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        List<fa_motivo_venta_Info> listMotivo = new List<fa_motivo_venta_Info>();
        fa_motivo_venta_Bus BusTipoFlujo = new fa_motivo_venta_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //variable que representa el formulario
        frmFa_motivo_venta_Mant frm;
        //variable que representa a una clase info
        fa_motivo_venta_Info Info = new fa_motivo_venta_Info();


        public delegate void delegate_cmbMotivo_Vta_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbMotivo_Vta_EditValueChanged event_cmbMotivo_Vta_EditValueChanged;


        public delegate void delegate_cmbMotivo_Vta_Validating(object sender, EventArgs e);
        public event delegate_cmbMotivo_Vta_Validating event_cmbMotivo_Vta_Validating;


        public delegate void delegate_cmbMotivo_Vta_Validated(object sender, EventArgs e);
        public event delegate_cmbMotivo_Vta_Validated event_cmbMotivo_Vta_Validated;


        #endregion

        public UCFa_Motivo_venta()
        {
            InitializeComponent();
            event_cmbMotivo_Vta_EditValueChanged += UCFa_Motivo_venta_event_cmbMotivo_Vta_EditValueChanged;
            event_cmbMotivo_Vta_Validated += UCFa_Motivo_venta_event_cmbMotivo_Vta_Validated;
            event_cmbMotivo_Vta_Validating += UCFa_Motivo_venta_event_cmbMotivo_Vta_Validating;
        }

        void UCFa_Motivo_venta_event_cmbMotivo_Vta_Validating(object sender, EventArgs e)
        {
            
        }

        void UCFa_Motivo_venta_event_cmbMotivo_Vta_Validated(object sender, EventArgs e)
        {
            
        }

        void UCFa_Motivo_venta_event_cmbMotivo_Vta_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbMotivo_Vta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbMotivo_Vta_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbMotivo_Vta_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbMotivo_Vta_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbMotivo_Vta_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbMotivo_Vta_Validated(sender, e);
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
                listMotivo = new List<fa_motivo_venta_Info>();
                listMotivo = BusTipoFlujo.Get_List_fa_motivo_venta(param.IdEmpresa);
                cmbMotivo_Vta.Properties.DataSource = listMotivo;
                if (listMotivo.Count > 0)
                {
                    cmbMotivo_Vta.EditValue = listMotivo.First().IdMotivo_Vta;
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
                cargar();
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
                frm = new frmFa_motivo_venta_Mant();
                //este evento es una sobrecarga, no lo puedes copiar, tienes que digitarlo y sobrcargarlo, "+= + Tecla TAB"
                frm.event_frmFa_motivo_venta_Mant_FormClosing += frm_event_frmFa_motivo_venta_Mant_FormClosing;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Info != null)
                    {
                        if (Info.IdMotivo_Vta != 0)
                        {
                            frm.Set_Motivo_Venta(Info);
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
                    frm.Set_Accion(Accion);
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

        void frm_event_frmFa_motivo_venta_Mant_FormClosing(object sender, FormClosingEventArgs e)
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

        public fa_motivo_venta_Info get_Info()
        {
            try
            {
                Info = new fa_motivo_venta_Info();
                if (cmbMotivo_Vta.EditValue != null)
                    Info = listMotivo.FirstOrDefault(v => v.IdMotivo_Vta == Convert.ToDecimal(cmbMotivo_Vta.EditValue));

                return Info;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_motivo_venta_Info();
            }

        }

        public void set_Info(int IdMotivo_Vta)
        {
            try
            {
                cmbMotivo_Vta.EditValue = IdMotivo_Vta;
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
    }
}
