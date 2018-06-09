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
using Core.Erp.Business.Bancos;
using Core.Erp.Winform.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCBa_CuentaBanco : UserControl
    {
        #region "Declaración Variables"
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Banco_Cuenta_Bus bancoB = new ba_Banco_Cuenta_Bus();


        List<ba_Banco_Cuenta_Info> list_ba_Banco_Cuenta_Info = new List<ba_Banco_Cuenta_Info>();

        ba_Banco_Cuenta_Info InfoBaCuenta = new ba_Banco_Cuenta_Info();


        public delegate void delegate_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_CuentaBanco_EditValueChanged event_cmb_CuentaBanco_EditValueChanged;

        FrmBA_Banco_Cuenta_Mant frm;
        #endregion

        public UCBa_CuentaBanco()
        {
            InitializeComponent();
            event_cmb_CuentaBanco_EditValueChanged += UCBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged;
        }

        void UCBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
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

        public   void cargar_CuentaBanco(int IdEmpresa=0)
        {
            try
            {
                if (IdEmpresa == 0)
                {
                    list_ba_Banco_Cuenta_Info = bancoB.Get_list_Banco_Cuenta(param.IdEmpresa);
                }
                else
                {
                    list_ba_Banco_Cuenta_Info = bancoB.Get_list_Banco_Cuenta(IdEmpresa);
                }
               cmb_CuentaBanco.Properties.DataSource = list_ba_Banco_Cuenta_Info;
               cmb_CuentaBanco.Properties.DisplayMember = "ba_descripcion2";
               cmb_CuentaBanco.Properties.ValueMember = "IdBanco";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCBa_CuentaBanco_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_CuentaBanco();
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

                frm = new FrmBA_Banco_Cuenta_Mant();
                frm.event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing += frm_event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing;

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                  
                    frm.set_Accion(Accion);
                    frm.set_Info(InfoBaCuenta);
                

                    

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

        void frm_event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_CuentaBanco();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
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

        private void MenuAcciones_Click(object sender, EventArgs e)
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

        public void Perfil_Lectura(Cl_Enumeradores.eTipo_action _Nuevo)
        {
            try
            {
                if (_Nuevo != Cl_Enumeradores.eTipo_action.grabar)
                {
                    cmb_Acciones.Enabled = false;
                    cmb_CuentaBanco.Properties.ReadOnly = true;
                }
                else
                {
                    cmb_Acciones.Enabled = true;
                    cmb_CuentaBanco.Properties.ReadOnly = false;
                }
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmbPlanCta()
        {
            try
            {
                cmb_CuentaBanco.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_BaCuentaInfo(int IdBanco)
        {
            try
            {
                if(IdBanco!=0)
                    cmb_CuentaBanco.EditValue = IdBanco;
                else
                    cmb_CuentaBanco.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ba_Banco_Cuenta_Info get_BaCuentaInfo()
        {
            try
            {
                if (cmb_CuentaBanco.EditValue != null)
                {
                    InfoBaCuenta = list_ba_Banco_Cuenta_Info.FirstOrDefault(v => v.IdBanco == Convert.ToInt32(cmb_CuentaBanco.EditValue));


                }
                else
                {
                    InfoBaCuenta = new ba_Banco_Cuenta_Info();
                }

                return InfoBaCuenta;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Banco_Cuenta_Info();
            }

        }

        public void cmb_CuentaBanco_Enable(Boolean valor)
        {
            try
            {
                cmb_CuentaBanco.Properties.ReadOnly = valor;
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
                get_BaCuentaInfo();
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
                get_BaCuentaInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmb_CuentaBanco_EditValueChanged(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
              
            }
        }

        private void cmb_Acciones_Click_1(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones.Show(cmb_Acciones, new Point(0, cmb_Acciones.Height));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
