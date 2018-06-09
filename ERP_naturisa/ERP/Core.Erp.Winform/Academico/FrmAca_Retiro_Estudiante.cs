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
    public partial class FrmAca_Retiro_Estudiante : Form
    {
        #region variables
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_contrato_x_estudiante_det_beca_Bus bus_beca_estudiante = new Aca_contrato_x_estudiante_det_beca_Bus();

        List<Aca_Beca_Info> lista_beca = new List<Aca_Beca_Info>();
        Aca_Beca_Bus bus_beca = new Aca_Beca_Bus();
        Aca_Contrato_x_Estudiante_Info ContratoInfo;
        Aca_Contrato_x_Estudiante_Bus Bus_Contrato = new Aca_Contrato_x_Estudiante_Bus();
        BindingList<Aca_contrato_x_estudiante_det_beca_Info> lista_detalle = new BindingList<Aca_contrato_x_estudiante_det_beca_Info>();

        Aca_matricula_Bus Bus_Matricula = new Aca_matricula_Bus();
        Aca_Matricula_Info matriculaInfo = new Aca_Matricula_Info();

        #endregion 

        public FrmAca_Retiro_Estudiante()
        {
            InitializeComponent();
        }


        public void Set(Aca_Contrato_x_Estudiante_Info info)
        {
            try
            {
                ContratoInfo = new Aca_Contrato_x_Estudiante_Info();
                ContratoInfo = info;
                ucAca_Estudiante1.set_Estudiante(info.IdEstudiante);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRetirarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dialogResult = MessageBox.Show("Esta Seguro de Retirar al estudiante", "RETIRAR ESTUDIANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    DialogResult dialogResult2 = MessageBox.Show("Se procedera a RETIRAR al Estudiante: " + ContratoInfo.nombreCompleto + "para proceder haga clic en SI, o no para cancelar", "RETIRAR ESTUDIANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        ContratoInfo.MotivoAnulacion = txtMotivoAnulacion.Text;
                        matriculaInfo = Bus_Matricula.Get_Info(ContratoInfo.IdMatricula);
                        matriculaInfo.MotivoAnulacion = txtMotivoAnulacion.Text;

                        Bus_Matricula.AnularDB(matriculaInfo, ref mensaje);
                        Bus_Contrato.AnularDB(ContratoInfo, ref mensaje);

                        MessageBox.Show("Estudiante Retirado", "Sistemas");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAca_Retiro_Estudiante_Load(object sender, EventArgs e)
        {
            ucAca_Estudiante1.CargarListEstudiante();
            ucAca_Estudiante1.set_Estudiante(ContratoInfo.IdEstudiante);
            ucAca_Estudiante1.Enabled = false;
        }


    }
}
