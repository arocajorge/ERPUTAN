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
    public partial class Frm_Aca_Apertura_Ciclo_Facturacion : Form
    {
        #region Variables
        string mensaje = "";
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<vwAca_Matricula_x_Estudiante_Info> lista_Matricula_Est = new List<vwAca_Matricula_x_Estudiante_Info>();
        vwAca_Matricula_x_Estudiante_Info Matricula_Est_Info = new vwAca_Matricula_x_Estudiante_Info();
        vwAca_Matricula_x_Estudiante_Bus Matricula_Est_Bus = new vwAca_Matricula_x_Estudiante_Bus();


        Aca_Contrato_x_Estudiante_Bus BusContratoEstudiante = new Aca_Contrato_x_Estudiante_Bus();
        Aca_Contrato_x_Estudiante_Info InfoContratoEstudiante = new Aca_Contrato_x_Estudiante_Info();
        List<Aca_Contrato_x_Estudiante_Info> InfoLstContratoEstudiante = new List<Aca_Contrato_x_Estudiante_Info>();

        Aca_Contrato_x_Estudiante_det_Bus BusContratoEstudiante_Det = new Aca_Contrato_x_Estudiante_det_Bus();
        Aca_Contrato_x_Estudiante_det_Info InfoContratoEstudiante_Det = new Aca_Contrato_x_Estudiante_det_Info();
        List<Aca_Contrato_x_Estudiante_det_Info> InfoLstContratoEstudiante_Det = new List<Aca_Contrato_x_Estudiante_det_Info>();

        vwAca_Estudiante_con_Matricula_Sin_Contrato_Bus BusEstudianteMatricula_Sin_Contrato = new vwAca_Estudiante_con_Matricula_Sin_Contrato_Bus();
        vwAca_Estudiante_con_Matricula_Sin_Contrato_Info InfoEstudianteMatricula_Sin_Contrato = new vwAca_Estudiante_con_Matricula_Sin_Contrato_Info();
        List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Info> InfoLstEstudianteMatricula_Sin_Contrato = new List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Info>();

        vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Bus BusEstudianteMatricula_Sin_Contrato_Det = new vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Bus();
        vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info InfoEstudianteMatricula_Sin_Contrato_Det = new vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info();
        List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info> InfoLstEstudianteMatricula_Sin_Contrato_Det = new List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info>();

        vwAca_AnioPeriodo_Activo_Bus BusAnioPeriodoActivo = new vwAca_AnioPeriodo_Activo_Bus();
        vwAca_AnioPeriodo_Activo_Info InfovwAca_AnioPeriodo_Activo = new vwAca_AnioPeriodo_Activo_Info();

        Aca_Periodo_Bus BusPeriodo = new Aca_Periodo_Bus();



        #endregion
        public Frm_Aca_Apertura_Ciclo_Facturacion()
        {
            InitializeComponent();
        }

        private void Frm_Aca_Apertura_Ciclo_Facturacion_Load(object sender, EventArgs e)
        {
            //Curso.cargaCmb_Curso();
            if (param.IdUsuario == "admin") { 
                btnPeriodoAnterior.Enabled = true; 
            }
            else
            {
                btnPeriodoAnterior.Enabled = false;
            }
            CargarDatos();
        }
        #region "Cargar Datos"
        public void CargarDatos() 
        {
            
            try
            {
                lista_Matricula_Est = Matricula_Est_Bus.Get_List_Matricula_x_Estudiante(param.IdInstitucion);
                gridCtrlEstudianteCurso.DataSource = lista_Matricula_Est;

                CargaAnioPeriodo();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargaAnioPeriodo()
        {
            InfovwAca_AnioPeriodo_Activo = BusAnioPeriodoActivo.Get_vwAca_AnioPeriodo_Activo_Info(ref mensaje);

            txtAnioLectivo.Text = InfovwAca_AnioPeriodo_Activo.AnioLectivo;
            txtPeriodo.Text = InfovwAca_AnioPeriodo_Activo.IdPeriodo.ToString();
        }


        #endregion

        #region "Eventos"
        private void btnAperturaAnual_Click(object sender, EventArgs e)
        {
            bool restultado_Apertura = false;
            try
            {
                int IdContrato_x_Estudiante = 0;
                string mensaje="";

                //InfoLstEstudianteMatricula_Sin_Contrato = BusEstudianteMatricula_Sin_Contrato.Get_List_Estudiante_con_Matricula_Sin_Contrato(param.IdInstitucion, param.IdSucursal);
                InfoLstEstudianteMatricula_Sin_Contrato = BusEstudianteMatricula_Sin_Contrato.Get_List_Estudiante_con_Matricula_Sin_Contrato_AnioLectivoActivo(param.IdInstitucion, InfovwAca_AnioPeriodo_Activo.IdAnioLectivo);

                foreach (var item in InfoLstEstudianteMatricula_Sin_Contrato)
	            {
                    InfoContratoEstudiante = new Aca_Contrato_x_Estudiante_Info();
                    InfoContratoEstudiante.IdInstitucion = item.IdInstitucion;
                    InfoContratoEstudiante.IdSede = item.IdSede;
                    //InfoContratoEstudiante.IdContrato =
                    InfoContratoEstudiante.IdMatricula = item.IdMatricula;
                    InfoContratoEstudiante.IdAnioLectivo = item.IdAnioLectivo;
                    InfoContratoEstudiante.IdEstudiante = item.IdEstudiante;
                    InfoContratoEstudiante.UsuarioCreacion = param.IdUsuario;
                    InfoContratoEstudiante.observacion = " ";

                    if (BusContratoEstudiante.GrabarDB(InfoContratoEstudiante, ref IdContrato_x_Estudiante, ref mensaje) == true)
                    {
                        //MessageBox.Show("Ingresado el Contrato # "  + IdContrato_x_Estudiante);


                        InfoLstEstudianteMatricula_Sin_Contrato_Det = new List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info>();
                        //InfoLstEstudianteMatricula_Sin_Contrato_Det = BusEstudianteMatricula_Sin_Contrato_Det.Get_List_Estudiante_con_Matricula_Sin_Contrato_Detalle(param.IdInstitucion, param.IdSucursal);
                        InfoLstEstudianteMatricula_Sin_Contrato_Det = BusEstudianteMatricula_Sin_Contrato_Det.Get_List_Estudiante_con_Matricula_Sin_Contrato_Detalle_x_Estudiante(param.IdInstitucion, InfovwAca_AnioPeriodo_Activo.IdAnioLectivo, item.IdEstudiante);

                        InfoLstContratoEstudiante_Det = new List<Aca_Contrato_x_Estudiante_det_Info>();

                        foreach (var det in InfoLstEstudianteMatricula_Sin_Contrato_Det)
                        {
                            InfoContratoEstudiante_Det = new Aca_Contrato_x_Estudiante_det_Info();

                            InfoContratoEstudiante_Det.IdInstitucion = det.IdInstitucion;
                            InfoContratoEstudiante_Det.IdContrato = IdContrato_x_Estudiante;//det.IdContrato;
                            //InfoContratoEstudiante_Det.IdContrato = IdContrato_x_Estudiante;
                            InfoContratoEstudiante_Det.IdRubro = det.IdRubro;
                            InfoContratoEstudiante_Det.IdInstitucion_Per = det.IdInstitucion;
                            InfoContratoEstudiante_Det.IdAnioLectivo_Per = det.IdAnioLectivo_Rubro_x_Periodo;
                            InfoContratoEstudiante_Det.IdPeriodo_Per = det.IdPeriodo_Per;
                            InfoContratoEstudiante_Det.Observacion = "";

                            InfoLstContratoEstudiante_Det.Add(InfoContratoEstudiante_Det);
                        }

                        if (InfoLstContratoEstudiante_Det.Count > 0)
                        {
                            if (BusContratoEstudiante_Det.GuardarDB(InfoLstContratoEstudiante_Det))
                            {
                                //MessageBox.Show("Ingresado el Contrato # " + IdContrato_x_Estudiante);
                                restultado_Apertura = true;
                            }
                            else
                            {
                                MessageBox.Show("Error al grabar");
                            }
                        }
                        else
                        {
                            //MessageBox.Show("No existen Contratos con Rubros pendientes a Generarse");
                        }
                        if (restultado_Apertura == true)
                        {
                           // MessageBox.Show("GENERACION DE CONTRATOS EXITOSA");
                        }

                        
                        
                        
                        //restultado_Apertura = true;










                    }
                    else
                    {
                        MessageBox.Show("Error al grabar el Estudiante #" + item.pe_nombre + " " + item.pe_apellido );
                    }
	            }

               

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
        private void btnPeriodoSiguiente_Click(object sender, EventArgs e)
        {
            ActivarPeriodoSiguiente(InfovwAca_AnioPeriodo_Activo);
            CargaAnioPeriodo();
        }

        private void btnPeriodoAnterior_Click(object sender, EventArgs e)
        {
            ActivarPeriodoAnterior(InfovwAca_AnioPeriodo_Activo);
            CargaAnioPeriodo();
        }
        #endregion

        #region "Procesos"
        public void ActivarPeriodoSiguiente(vwAca_AnioPeriodo_Activo_Info infoPeriodoActivo) 
        {
            try
            {
                BusPeriodo.ActivarPeriodoSiguiente(infoPeriodoActivo, ref mensaje);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ActivarPeriodoAnterior(vwAca_AnioPeriodo_Activo_Info infoPeriodoActivo)
        {
            try
            {
                BusPeriodo.ActivarPeriodoAnterior(infoPeriodoActivo, ref mensaje);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        #endregion

        
        //private void btnCerrarPeriodo_Click(object sender, EventArgs e)
        //{
            
        //}
        

    }
}
