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
    public partial class FrmAca_Contrato_Mant : Form
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


        Aca_Contrato_x_Estudiante_det_Bus BusContrato_x_Estudiante_det = new Aca_Contrato_x_Estudiante_det_Bus();
        List<Aca_Contrato_x_Estudiante_det_Info> LstContrato_x_Estudiante_det = new List<Aca_Contrato_x_Estudiante_det_Info>();
        Aca_Contrato_x_Estudiante_det_Info InfoContrato_x_Estudiante_det = new Aca_Contrato_x_Estudiante_det_Info();

        vwAca_AnioPeriodo_Activo_Bus BusAnioPeriodoActivo = new vwAca_AnioPeriodo_Activo_Bus();
        vwAca_AnioPeriodo_Activo_Info InfovwAca_AnioPeriodo_Activo = new vwAca_AnioPeriodo_Activo_Info();

        private Cl_Enumeradores.eTipo_action Accion;
        #endregion

        public FrmAca_Contrato_Mant()
        {
            InitializeComponent();
        }

        #region CargarDatos
        public void CargarDatos()
        {
            string mensaje="";


            LstContrato_x_Estudiante_det = BusContrato_x_Estudiante_det.Get_Lista_Contrato_x_Estudiante_det(InfoContrato.IdInstitucion, InfoContrato.IdContrato);
            gridCtrlRubros_x_Estudiante.DataSource = LstContrato_x_Estudiante_det;

           
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

        public void Set(Aca_Contrato_x_Estudiante_Info ContratoInfo)
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
                InfoContrato = ContratoInfo;
                chkActivo.Checked = InfoContrato.estado;
                chkActivo.Properties.ReadOnly = true;
                txtCodigoEstudiante.Text = InfoContrato.cod_estudiante;
                txtSeccion.Text = Convert.ToString(InfoContrato.Seccion);
                txtCurso.Text = Convert.ToString(InfoContrato.Curso);
                //ucAca_Estudiante1.
                ucAca_Estudiante1.set_Estudiante(InfoContrato.IdEstudiante);
                ucAca_Estudiante1.cmbEstudiante.Properties.ReadOnly = true;
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

        private void FrmContrato_Mant_Load(object sender, EventArgs e)
        {
            ucAca_Estudiante1.CargarListEstudiante();
            CargaAnioPeriodo();
            ////this.setInfo();
        }
 

        #endregion

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
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #region "Grabar,Actualizar,Eliminar"
        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                ////LstContrato_x_Estudiante_det = new List<Aca_Contrato_x_Estudiante_det_Info>();

                ////LstContrato_x_Estudiante_det = (List<Aca_Contrato_x_Estudiante_det_Info>)gridvwRubro_x_Estudiante.DataSource;

                foreach (var item in LstContrato_x_Estudiante_det)
                {
                    //item.estado_rubro_contrato = false;
                    item.UsuarioModificacion = param.IdUsuario;


                    BusContrato_x_Estudiante_det.ActualizarDB(item,ref mensaje);
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion

        private void gridvwRubro_x_Estudiante_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                //LstContrato_x_Estudiante_det = new List<Aca_Contrato_x_Estudiante_det_Info>();

                //LstContrato_x_Estudiante_det = (List<Aca_Contrato_x_Estudiante_det_Info>)gridvwRubro_x_Estudiante.DataSource;

                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //private void gridvwRubro_x_Estudiante_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    //LstContrato_x_Estudiante_det = new List<Aca_Contrato_x_Estudiante_det_Info>();

        //    //LstContrato_x_Estudiante_det = (List<Aca_Contrato_x_Estudiante_det_Info>)gridvwRubro_x_Estudiante.DataSource;
        //}

        //private void gridvwRubro_x_Estudiante_Click(object sender, EventArgs e)
        //{
        //    //LstContrato_x_Estudiante_det = new List<Aca_Contrato_x_Estudiante_det_Info>();

        //    //LstContrato_x_Estudiante_det = (List<Aca_Contrato_x_Estudiante_det_Info>)gridvwRubro_x_Estudiante.DataSource;
        //}

        //private void gridvwRubro_x_Estudiante_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    //LstContrato_x_Estudiante_det = new List<Aca_Contrato_x_Estudiante_det_Info>();

        //    //LstContrato_x_Estudiante_det = (List<Aca_Contrato_x_Estudiante_det_Info>)gridvwRubro_x_Estudiante.DataSource;
        //}

        private void gridvwRubro_x_Estudiante_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            LstContrato_x_Estudiante_det = new List<Aca_Contrato_x_Estudiante_det_Info>();

            LstContrato_x_Estudiante_det = (List<Aca_Contrato_x_Estudiante_det_Info>)gridvwRubro_x_Estudiante.DataSource;
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region "Validaciones"

        #endregion

    }
}
