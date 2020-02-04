using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCon_CentroCosto_ctas_Movi : UserControl
    {
        #region Variables


        in_Parametro_Info info = new in_Parametro_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ct_Centro_costo_Bus BusCC = new ct_Centro_costo_Bus();
        public string IdCentroCostoPadre { get; set; } 
        public ct_Centro_costo_Info InfoCentroCosto { get; set; }        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string MensajeError = "";
        public delegate void delegate_cmbCentroCosto_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbCentroCosto_EditValueChanged Event_cmbCentroCosto_EditValueChanged;
        List<ct_Centro_costo_Info> listCentroCosto_Info = new List<ct_Centro_costo_Info>();
        frmCon_CentroCostos_Man frm;
        #endregion

        public UCCon_CentroCosto_ctas_Movi()
        {
            InitializeComponent();
            Event_cmbCentroCosto_EditValueChanged += UCCon_CentroCosto_ctas_Movi_Event_cmbCentroCosto_EditValueChanged;
        }

        void UCCon_CentroCosto_ctas_Movi_Event_cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
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

        public void cargaCmb_centroCostos()
        {
            try
            {
                listCentroCosto_Info = BusCC.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa,  ref MensajeError);
                cmbCentroCosto.Properties.DataSource = listCentroCosto_Info;
                cmbCentroCosto.Properties.DisplayMember = "Centro_costo2";
                cmbCentroCosto.Properties.ValueMember = "IdCentroCosto";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }

        public void cmbCentroCosto_Enable(Boolean valor)
        {
            try
            {
                cmbCentroCosto.Properties.ReadOnly = valor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public string get_item()
        {
            try
            {
                return Convert.ToString(cmbCentroCosto.EditValue);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }



        public string Get_IdCentroCosto()
        {
            try
            {
                return Convert.ToString(cmbCentroCosto.EditValue);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }
       

        public void set_item(string IdCC)
        {
            try
            {
                cmbCentroCosto.EditValue = IdCC;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_IdCentroCosto(string IdCentroCosto)
        {
            try
            {
                if (IdCentroCosto != "")
                {
                    cmbCentroCosto.EditValue = IdCentroCosto;
                }
                else
                    cmbCentroCosto.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoCentroCosto = (ct_Centro_costo_Info)cmbCentroCosto.Properties.View.GetFocusedRow();

                this.Event_cmbCentroCosto_EditValueChanged(sender, e);
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
                frm = new frmCon_CentroCostos_Man();
                frm.event_frmCon_CentroCostos_Man_FormClosing += new frmCon_CentroCostos_Man.delegate_frmCon_CentroCostos_Man_FormClosing(frm_event_frmCon_CentroCostos_Man_FormClosing);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (InfoCentroCosto != null)
                    {
                        //if(info
                        frm.Info_centro_costo = InfoCentroCosto;
                        frm._Accion = Accion;
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Para continuar seleccione un registro.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm._Accion = Accion;
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

        void frm_event_frmCon_CentroCostos_Man_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargaCmb_centroCostos();
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
                cmbCentroCosto.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmbCentroCosto()
        {
            try
            {
                cmbCentroCosto.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCCon_CentroCosto_ctas_Movi_Load(object sender, EventArgs e)
        {
            try
            {
                cargaCmb_centroCostos();
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
