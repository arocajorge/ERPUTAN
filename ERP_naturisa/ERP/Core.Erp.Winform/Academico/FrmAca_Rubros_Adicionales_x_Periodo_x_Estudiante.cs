using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Rubros_Adicionales_x_Periodo_x_Estudiante : Form
    {
        #region "Variables"
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public Aca_Contrato_x_Estudiante_Info InfoContrato { get; set; }
        Aca_Contrato_x_Estudiante_Info MatriculaInfo = new Aca_Contrato_x_Estudiante_Info();

        Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus busExepciones = new Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus();
        List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info> LstExcepciones = new List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info>();
        Aca_Contrato_x_Estudiante_x_det_Excepcion_Info InfoExcepciones =  new Aca_Contrato_x_Estudiante_x_det_Excepcion_Info();

        private Cl_Enumeradores.eTipo_action Accion;
        #endregion


        public FrmAca_Rubros_Adicionales_x_Periodo_x_Estudiante()
        {
            InitializeComponent();
        }
        #region CargarDatos
            
        #endregion



        #region "Set"
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;

                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:



                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:


                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:



                        break;

                    default:

                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


        }

        private void setInfo()
        {
            try
            {
                //if(InfoMatricula != null)
                //{
                //    MatriculaInfo = InfoMatricula;
                //}else
                //{
                //    InfoMatricula = MatriculaInfo;
                //}


                txtCodigoEstudiante.Text = InfoContrato.cod_estudiante;
                txtSeccion.Text = Convert.ToString(InfoContrato.IdSeccion);
                txtCurso.Text = Convert.ToString(InfoContrato.IdCurso);
                //ucAca_Estudiante1.
                ucAca_Estudiante1.set_Estudiante(InfoContrato.IdEstudiante);

                LstExcepciones = busExepciones.Get_List_Rubros_Contrato(InfoContrato);
                gridCtrlRubros_Adicionales_x_Periodo_x_Estudiante.DataSource = LstExcepciones;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

       



        #region "Get"

        #endregion



        #region "Eventos"

        private void FrmAca_Rubros_Adicionales_x_Periodo_x_Estudiante_Load(object sender, EventArgs e)
        {
            ucAca_Estudiante1.CargarListEstudiante();
            this.setInfo();
        }
 

        #endregion



        #region "Grabar,Actualizar,Eliminar"

        #endregion



        #region "Validaciones"

        #endregion
    }
}
