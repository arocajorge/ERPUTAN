using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Parametros_para_calculo_horas_Extras_x_empresa : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Parametro_calculo_Horas_Extras_Bus bus_parametros = new ro_Parametro_calculo_Horas_Extras_Bus();
        ro_Parametro_calculo_Horas_Extras_Info info = new ro_Parametro_calculo_Horas_Extras_Info();
        List<ro_rubro_tipo_Info> lista_rubros = new List<ro_rubro_tipo_Info>();
        ro_rubro_tipo_Bus bus_rubro = new ro_rubro_tipo_Bus();
        public frmRo_Parametros_para_calculo_horas_Extras_x_empresa()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
              
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                {
                    return;
                }
                Get();
                if (bus_parametros.Guardar_DB(info))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.No_se_modificaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }


        public void Cargar_configuracion()
        {
            try
            {
                info = bus_parametros.Get_info(param.IdEmpresa);
                if (info != null)
                {
                    check_se_paga_horasal100.Checked = info.Se_calcula_horas_Extras_al100;
                    check_se_paga_horasal25.Checked = info.Se_calcula_horas_Extras_al25;
                    check_se_paga_horasal50.Checked = info.Se_calcula_horas_Extras_al50;
                    txt_diasCorte.EditValue = info.Corte_Horas_extras;
                    check_reverso.Checked = info.Se_Crea_reverso_h_extras_si_Emp_tiene_remplazo;

                    if (info.Se_Crea_reverso_h_extras_si_Emp_tiene_remplazo)
                    {
                        cmb_rubros.EditValue = info.IdRubro_rev_Horas;
                    }
                    txtMinutoLoch.EditValue = info.MinutosLunch;
                    cmb_Desahucio.EditValue = info.IdRubro_Rebaja_Desahucio;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void frmRo_Parametros_para_calculo_horas_Extras_x_empresa_Load(object sender, EventArgs e)
        {
            try
            {
                lista_rubros = bus_rubro.Get_list_rubros_concepto(param.IdEmpresa);
                cmb_rubros.Properties.DataSource = lista_rubros;

                cmb_Desahucio.Properties.DataSource = lista_rubros;

                
                txt_diasCorte.Properties.MaxLength = 2;
                Cargar_configuracion();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Get()
        {
            try
            {
                info = new ro_Parametro_calculo_Horas_Extras_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.Se_calcula_horas_Extras_al100 = check_se_paga_horasal100.Checked;
                info.Se_calcula_horas_Extras_al25 = check_se_paga_horasal25.Checked;
                info.Se_calcula_horas_Extras_al50 = check_se_paga_horasal50.Checked;
                info.Corte_Horas_extras = Convert.ToInt32(txt_diasCorte.EditValue);
                info.Se_Crea_reverso_h_extras_si_Emp_tiene_remplazo = check_reverso.Checked;
                if (check_reverso.Checked == true)
                {
                    info.IdRubro_rev_Horas = cmb_rubros.EditValue.ToString();
                }
                if(cmb_Desahucio.EditValue!=null)
                info.IdRubro_Rebaja_Desahucio = cmb_Desahucio.EditValue.ToString();
                if(txtMinutoLoch.EditValue!=null)
                info.MinutosLunch =Convert.ToInt32( txtMinutoLoch.EditValue);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public bool Validar()
        {
            bool bansera_si_valido = true;
            try
            {
                if (txt_diasCorte.EditValue == null || txt_diasCorte.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Ingrese_el) + " día para el corte de horas extras", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bansera_si_valido= false;
                }

                if (txt_diasCorte.EditValue != null || txt_diasCorte.EditValue != "")
                {                                      
                    if (Convert.ToInt32(txt_diasCorte.EditValue) == 0 || Convert.ToInt32(txt_diasCorte.EditValue) > 31)
                    {
                        MessageBox.Show("El Número ingresado no es valido", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bansera_si_valido = false;
                    }

                    string num_caracter = txt_diasCorte.EditValue.ToString();
                    if (num_caracter.Length > 1)
                    {
                        if (num_caracter.Substring(0, 1) == "0")
                        {
                            MessageBox.Show("El Número ingresado no es valido", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            bansera_si_valido = false;
                        }
                    }
                }

                return bansera_si_valido;
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}
