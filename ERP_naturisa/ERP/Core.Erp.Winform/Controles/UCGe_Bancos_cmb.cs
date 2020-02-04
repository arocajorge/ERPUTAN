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
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Bancos_cmb : UserControl
    {
        public delegate void delegate_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_CuentaBanco_EditValueChanged event_cmb_CuentaBanco_EditValueChanged;


        #region "Declaración Variables"
                tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

                tb_banco_Bus BusBanco = new tb_banco_Bus();
                List<tb_banco_Info> list_Banco_Info = new List<tb_banco_Info>();
                tb_banco_Info InfoBanco = new tb_banco_Info();
             
        //FrmBA_Banco_Cuenta_Mant frm;
        #endregion


        public UCGe_Bancos_cmb()
        {
            InitializeComponent();
            event_cmb_CuentaBanco_EditValueChanged += UCGe_Bancos_cmb_event_cmb_CuentaBanco_EditValueChanged;
        }

        void UCGe_Bancos_cmb_event_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmb_CuentaBanco_EditValueChanged(sender, e);

            }
            catch (Exception ex)
            {
                  string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        public   void cargar_CuentaBanco()
        {
            try
            {

                      list_Banco_Info = BusBanco.Get_List_Banco();              
                    cmb_Banco.Properties.DataSource = list_Banco_Info;
                    cmb_Banco.Properties.DisplayMember = "ba_descripcion";
                    cmb_Banco.Properties.ValueMember = "IdBanco";
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
            
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {

                //frm = new FrmBA_Banco_Cuenta_Mant();
                //frm.event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing += frm_event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing;

                //if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                //{
                //    frm.set_Accion(Accion);
                //    frm.set_Info(InfoBaCuenta);

                //}
                //else
                //     frm.set_Accion(Accion);

                //frm.Show();
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

        public void Perfil_Lectura()
        {
            try
            {
                cmb_Acciones.Enabled = false;
                cmb_Banco.Properties.ReadOnly = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        


        public void set_BancoInfo(int IdBanco)
        {
            try
            {
                cmb_Banco.EditValue = IdBanco;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public tb_banco_Info get_BancoInfo()
        {
            try
            {
                if (cmb_Banco.EditValue != null)
                {
                    InfoBanco = list_Banco_Info.FirstOrDefault(v => v.IdBanco == Convert.ToInt32(cmb_Banco.EditValue));


                }

                return InfoBanco;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_banco_Info();
            }

        }

        public int get_IdBanco()
        {
            try
            {
                if (cmb_Banco.EditValue != null)
                {
                    InfoBanco = list_Banco_Info.FirstOrDefault(v => v.IdBanco == Convert.ToInt32(cmb_Banco.EditValue));
                }

                return InfoBanco.IdBanco;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            }

        }

        public void cmb_CuentaBanco_Enable(Boolean valor)
        {
            try
            {
                cmb_Banco.Properties.ReadOnly = valor;
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
                get_BancoInfo();
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
                get_BancoInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
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

        private void UCGe_Bancos_cmb_Load(object sender, EventArgs e)
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
    }
}
