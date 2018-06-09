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
    public partial class FrmAca_Rubros_Asigandos_x_Estudiante_x_Periodo : Form
    {
        #region "Variables"
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public Aca_Contrato_x_Estudiante_Info InfoContrato { get; set; }
        Aca_Contrato_x_Estudiante_Info MatriculaInfo = new Aca_Contrato_x_Estudiante_Info();

        Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus busExepciones = new Aca_Contrato_x_Estudiante_x_det_Excepcion_Bus();
        List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info> LstExcepciones = new List<Aca_Contrato_x_Estudiante_x_det_Excepcion_Info>();
        Aca_Contrato_x_Estudiante_x_det_Excepcion_Info InfoExcepciones =  new Aca_Contrato_x_Estudiante_x_det_Excepcion_Info();


        vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Bus BusEstudiante = new vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Bus();
        BindingList<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info> LstEstudiante = new BindingList<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info>();
        vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info InfoEstudiante = new vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info();


        vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Bus BusContrato_Rubro_y_Beca = new vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Bus();
        List<vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info> LstContrato_Rubro_y_Beca = new List<vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info>();
        vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info InfoContrato_Rubro_y_Beca = new vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info();

        vwAca_AnioPeriodo_Activo_Bus BusAnioPeriodoActivo = new vwAca_AnioPeriodo_Activo_Bus();
        vwAca_AnioPeriodo_Activo_Info InfovwAca_AnioPeriodo_Activo = new vwAca_AnioPeriodo_Activo_Info();

        private Cl_Enumeradores.eTipo_action Accion;
        #endregion


        public FrmAca_Rubros_Asigandos_x_Estudiante_x_Periodo()
        {
            InitializeComponent();
        }
        #region CargarDatos
        public void CargarDatos()
        {
            string mensaje="";
            LstEstudiante = BusEstudiante.Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(param.IdInstitucion);
            gridCtrlEstudiantes.DataSource = LstEstudiante;

            LstContrato_Rubro_y_Beca = BusContrato_Rubro_y_Beca.Get_List_Contrato_x_Estudiante_x_Rubro_y_Beca(InfoContrato.IdInstitucion, InfoContrato.IdContrato, InfoContrato.IdAnioLectivo, Convert.ToInt32(txtPeriodo.Text));
            gridCtrlRubros_x_Estudiante.DataSource = LstContrato_Rubro_y_Beca;
        }
        public void CargaAnioPeriodo()
        {
            InfovwAca_AnioPeriodo_Activo = BusAnioPeriodoActivo.Get_vwAca_AnioPeriodo_Activo_Info(ref mensaje);

            txtAnioLectivo.Text = InfovwAca_AnioPeriodo_Activo.AnioLectivo;
            txtPeriodo.Text = InfovwAca_AnioPeriodo_Activo.IdPeriodo.ToString();
        }

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

                CargarDatos();
                
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

        private void FrmRubros_Asigandos_x_Estudiante_x_Periodo_Load(object sender, EventArgs e)
        {
            ucAca_Estudiante1.CargarListEstudiante();
            CargaAnioPeriodo();
            this.setInfo();
        }
 

        #endregion

        private void gridvwEstudiantes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                pu_CheckTodos();
                //if (e.HitInfo.Column.Name == "chequeo")
                //{
                    if ((bool)gridvwEstudiantes.GetFocusedRowCellValue(Col_Chequeo))
                    {
                        //limpia gridControl
                        this.LstContrato_Rubro_y_Beca = new List<vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info>();
                        this.gridCtrlRubros_x_Estudiante.DataSource = LstContrato_Rubro_y_Beca;

                        vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info info = (vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info)this.gridvwEstudiantes.GetFocusedRow();

                        LstContrato_Rubro_y_Beca = BusContrato_Rubro_y_Beca.Get_List_Contrato_x_Estudiante_x_Rubro_y_Beca(info.IdInstitucion, Convert.ToDecimal(info.IdContrato), info.IdAnioLectivo, Convert.ToInt32(txtPeriodo.Text));

                        if (LstContrato_Rubro_y_Beca != null)
                        {
                            gridCtrlRubros_x_Estudiante.DataSource = LstContrato_Rubro_y_Beca;
                        }
                        
                       
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridvwEstudiantes_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                pu_CheckTodos();
                if (e.HitInfo.Column.Name == "chequeo")
                {
                    if ((bool)gridvwEstudiantes.GetFocusedRowCellValue(Col_Chequeo))
                    {
                        //limpia gridControl
                        this.LstContrato_Rubro_y_Beca = new List<vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info>();
                        this.gridCtrlRubros_x_Estudiante.DataSource = LstContrato_Rubro_y_Beca;

                        vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info info = (vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info)this.gridvwEstudiantes.GetFocusedRow();

                        LstContrato_Rubro_y_Beca = BusContrato_Rubro_y_Beca.Get_List_Contrato_x_Estudiante_x_Rubro_y_Beca(info.IdInstitucion, info.IdContrato, info.IdAnioLectivo_Per, Convert.ToInt32(txtPeriodo.Text));

                        if (LstContrato_Rubro_y_Beca != null)
                        {
                            gridCtrlRubros_x_Estudiante.DataSource = LstContrato_Rubro_y_Beca;
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void pu_CheckTodos()
        {
            //int contador = 0;
            try
            {

                foreach (var item in LstEstudiante)
                    {
                        item.chequeo = false;
                        //contador++;
                    }
                    gridCtrlEstudiantes.RefreshDataSource();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #region "Grabar,Actualizar,Eliminar"

        #endregion



        #region "Validaciones"

        #endregion
    }
}
