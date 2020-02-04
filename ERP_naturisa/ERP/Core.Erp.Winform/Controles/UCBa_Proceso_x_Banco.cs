using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Bancos;

namespace Core.Erp.Winform.Controles
{
    public partial class UCBa_Proceso_x_Banco : UserControl
    {
        #region "Declaración Variables"
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<ba_Banco_Cuenta_Info> list_ba_Banco_Cuenta_Info = new List<ba_Banco_Cuenta_Info>();
        ba_Banco_Cuenta_Bus bancoB = new ba_Banco_Cuenta_Bus();

        ba_Banco_Cuenta_Info InfoBaCuenta = new ba_Banco_Cuenta_Info();
        tb_banco_procesos_bancarios_x_empresa_Info infoProceso = new tb_banco_procesos_bancarios_x_empresa_Info();
        FrmBA_Banco_Cuenta_Mant frm;


        List<tb_banco_procesos_bancarios_x_empresa_Info> List_Proceso_x_Banco = new List<tb_banco_procesos_bancarios_x_empresa_Info>();
        tb_banco_procesos_bancarios_x_empresa_Bus Proceso_Bus = new tb_banco_procesos_bancarios_x_empresa_Bus();

        //FrmBA_Banco_Cuenta_Mant frm;
        #endregion
        public UCBa_Proceso_x_Banco()
        {
            InitializeComponent();
            cargar_CuentaBanco();
        }
       
        private void UCBa_Proceso_x_Banco_Load(object sender, EventArgs e)
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

        public void cargar_CuentaBanco()
        {
            try
            {

                list_ba_Banco_Cuenta_Info = bancoB.Get_list_Banco_Cuenta(param.IdEmpresa);
                cmb_Banco.Properties.DataSource = list_ba_Banco_Cuenta_Info;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Banco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
              ba_Banco_Cuenta_Info info_Banco = new ba_Banco_Cuenta_Info();
              if (cmb_Banco.EditValue!=null)
              {
                  info_Banco = list_ba_Banco_Cuenta_Info.FirstOrDefault(q => q.IdBanco == Convert.ToInt32(cmb_Banco.EditValue));
                  List_Proceso_x_Banco = Proceso_Bus.Get_list_procesos_bancarios_x_empresa(param.IdEmpresa, Convert.ToInt32(info_Banco.IdBanco_Financiero));
                  cmbProceso.Properties.DataSource = List_Proceso_x_Banco;    
              }             
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

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {

                frm = new FrmBA_Banco_Cuenta_Mant();
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

        public ba_Banco_Cuenta_Info get_BaCuentaInfo()
        {
            try
            {
                if (cmb_Banco.EditValue != null)
                {
                    InfoBaCuenta = list_ba_Banco_Cuenta_Info.FirstOrDefault(v => v.IdBanco == Convert.ToInt32(cmb_Banco.EditValue));
                }
                else
                    InfoBaCuenta = null;
                return InfoBaCuenta;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }

        }

        public tb_banco_procesos_bancarios_x_empresa_Info get_Proceso_Info()
        {
            try
            {
                if (cmbProceso.EditValue != null)
                {
                    infoProceso = List_Proceso_x_Banco.FirstOrDefault(v => v.IdProceso_bancario_tipo ==Convert.ToString( cmbProceso.EditValue));                    
                }

                return infoProceso;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_banco_procesos_bancarios_x_empresa_Info();
            }

        }

        public void SetIdBanco(int idBanco)
        {
            try
            {
                if(idBanco != 0)
                    cmb_Banco.EditValue = idBanco;
                else
                    cmb_Banco.EditValue = null;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void SetIdProceso(string idProceso)
        {
            try
            {
                if(idProceso!="")
                    cmbProceso.EditValue = idProceso;
                else
                    cmbProceso.EditValue = null;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbProceso_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
