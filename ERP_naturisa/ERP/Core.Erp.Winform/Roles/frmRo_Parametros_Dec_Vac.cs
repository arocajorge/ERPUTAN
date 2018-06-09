using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Parametros_Dec_Vac : Form
    {
        public frmRo_Parametros_Dec_Vac()
        {
            try
            {
                InitializeComponent();
                //gridControlRubrosIess.DataSource = bindListRubrosIess;

                gridControlSBanio.DataSource = bindListAnios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //ro_Config_Rubros_x_Empresa_AportaIess_Bus Bus_Ru_Iess = new ro_Config_Rubros_x_Empresa_AportaIess_Bus();
        ro_Config_SueldoBasico_x_anio_Bus Bus_SbAnio = new ro_Config_SueldoBasico_x_anio_Bus();
        ro_Parametros_Bus Bus_RolesParam = new ro_Parametros_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       // ro_Config_Rubros_x_empresa_Bus busRu_x_Emp = new ro_Config_Rubros_x_empresa_Bus();
       // BindingList<ro_Config_Rubros_x_empresa_Info> bindListRubrosIess = new BindingList<ro_Config_Rubros_x_empresa_Info>();
       
        BindingList<ro_Config_SueldoBasico_x_anio_Info> bindListAnios = new BindingList<ro_Config_SueldoBasico_x_anio_Info>();
        string msg = "";
        List<ro_Config_Rubros_x_Empresa_AportaIess_Info> listagrabarrubrosiess = new List<ro_Config_Rubros_x_Empresa_AportaIess_Info>();
        List<ro_Config_SueldoBasico_x_anio_Info> listagrabaranios = new List<ro_Config_SueldoBasico_x_anio_Info>();

        ro_rubro_tipo_Bus busRu = new ro_rubro_tipo_Bus();
     
        private void mnu_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void mnu_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                { MessageBox.Show("Grabado satisfactoriamente"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private Boolean grabar()
        {
            Boolean grabado = false;
            cmb_anio.Focus();
            try
            {
                listagrabaranios = new List<ro_Config_SueldoBasico_x_anio_Info>();
                listagrabarrubrosiess = new List<ro_Config_Rubros_x_Empresa_AportaIess_Info>();
                foreach (var item in bindListAnios)
                {
                    ro_Config_SueldoBasico_x_anio_Info info = new ro_Config_SueldoBasico_x_anio_Info();
                    info = item;
                    
                    info.Fecha_Transac = DateTime.Now;
                    info.ip = param.ip;
                    info.nom_pc = param.nom_pc;
                    info.IdUsuario = param.IdUsuario;
                    listagrabaranios.Add(info);
                }

                
                if (cmb_anio.EditValue == null) { MessageBox.Show("Seleccione el sueldo básico."); }
                if (Bus_SbAnio.Eliminar(param.IdEmpresa))
                    Bus_SbAnio.Grabar(listagrabaranios);
                //if (Bus_Ru_Iess.Eliminar(param.IdEmpresa))

                    //Bus_Ru_Iess.Grabar(listagrabarrubrosiess);

                Bus_RolesParam.grabarSBasico(param.IdEmpresa, Convert.ToDouble(cmb_anio.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            return grabado;
        }


        private void mnu_GuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                { MessageBox.Show("Grabado satisfactoriamente"); this.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_Superior_Mant1_Load(object sender, EventArgs e)
        {

        }

        private void frmRo_Parametros_Dec_Vac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
            }
        }
    }
}
