using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public partial class UCCon_SubCentroCosto : UserControl
    {
        #region Variables
       // in_Parametro_Info info = new in_Parametro_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ct_centro_costo_sub_centro_costo_Bus BusSCC = new ct_centro_costo_sub_centro_costo_Bus();

        public Cl_Enumeradores.eTipoCargaSubCentroCosto IdCargaSubCentroCosto { get; set; }

       // public string IdCentroCostoPadre { get; set; }
        public ct_centro_costo_sub_centro_costo_Info InfoSubCentroCosto { get; set; }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string MensajeError = "";

        //public delegate void delegate_cmbCentroCosto_EditValueChanged(object sender, EventArgs e);
        //public event delegate_cmbCentroCosto_EditValueChanged Event_cmbCentroCosto_EditValueChanged;

        List<ct_centro_costo_sub_centro_costo_Info> list_SubCentroCosto_Info = new List<ct_centro_costo_sub_centro_costo_Info>();

        frmCon_CentroCosto_SubCentroCosto_Mant frm;
        #endregion
        
        
        public UCCon_SubCentroCosto()
        {
            InitializeComponent();
        }

        public void cargaCmb_SubcentroCostos()
        {
            try
            {
                list_SubCentroCosto_Info = BusSCC.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_SubCentroCosto.Properties.DataSource = list_SubCentroCosto_Info;
                cmb_SubCentroCosto.Properties.DisplayMember = "Centro_costo2";
                cmb_SubCentroCosto.Properties.ValueMember = "IdCentroCosto_sub_centro_costo";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        public void cargaCmb_SubcentroCostos_x_IdCentroCosto(int IdEmpresa,string IdCentroCosto)
        {
            try
            {
                list_SubCentroCosto_Info = BusSCC.Get_list_centro_costo_sub_centro_costo(IdEmpresa, IdCentroCosto);
                cmb_SubCentroCosto.Properties.DataSource = list_SubCentroCosto_Info;
                cmb_SubCentroCosto.Properties.DisplayMember = "Centro_costo2";
                cmb_SubCentroCosto.Properties.ValueMember = "IdCentroCosto_sub_centro_costo";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cmb_SubCentroCosto_Enable(Boolean valor)
        {
            try
            {
                cmb_SubCentroCosto.Properties.ReadOnly = valor;
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
                return Convert.ToString(cmb_SubCentroCosto.EditValue);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        public void set_item(string IdSCC)
        {
            try
            {
                cmb_SubCentroCosto.EditValue = IdSCC;
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
                frm = new frmCon_CentroCosto_SubCentroCosto_Mant();
                frm.event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing += frm_event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing;

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.SetInfo = InfoSubCentroCosto;
                    frm.enu = Accion;
                }
                else
                    frm.enu = Accion;

                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            cargaCmb_SubcentroCostos();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
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

        private void btn_Modificar_Click(object sender, EventArgs e)
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

        private void btn_Consultar_Click(object sender, EventArgs e)
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

        public void Perfil_Lectura()
        {
            try
            {
                cmb_Acciones.Enabled = false;
                cmb_SubCentroCosto.Properties.ReadOnly = true;

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
                cmb_SubCentroCosto.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

      

        private void UCCon_SubCentroCosto_Load(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(IdCargaSubCentroCosto) == "SIN_CENTRO_COSTO")
                {
                    cargaCmb_SubcentroCostos();
                }                                                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_SubCentroCosto_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                InfoSubCentroCosto = (ct_centro_costo_sub_centro_costo_Info)cmb_SubCentroCosto.Properties.View.GetFocusedRow();
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
