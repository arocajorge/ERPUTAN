using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;




namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Parametros : Form
    {
        


        #region Variables

                private Cl_Enumeradores.eTipo_action Accion;
                tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
                string mensaje = "";


                BindingList<tb_parametro_Info> ListParametro = new BindingList<tb_parametro_Info>();
                tb_parametro_Bus BusParametro = new tb_parametro_Bus();


        #region Delegados

        
        #endregion

        #endregion

        public FrmGe_Parametros()
        {
            InitializeComponent();
        }

        private void cargar_parametros()
        {

            try
            {
                ListParametro = new BindingList<tb_parametro_Info>(BusParametro.Get_List_parametro());
               gridControlParametro.DataSource = ListParametro;

            }
            catch (Exception ex)
            {

            }

        }

        private void FrmGe_Parametros_Load(object sender, EventArgs e)
        {
            ucGe_Menu.btnGuardar.Text = "Guardar";
            cargar_parametros();


        }

        public Boolean Grabar()
        {
            try
            {
                bool resultado = false;


                foreach (var item in ListParametro)
                {
                    resultado = BusParametro.ModificarDB(item, ref mensaje);
                
                        if (resultado==false)
                        {
                            MessageBox.Show("No se guardaron los datos para este parametro" + item.IdParametro , "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }

                if (resultado == true)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {

            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                { this.Close(); }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
