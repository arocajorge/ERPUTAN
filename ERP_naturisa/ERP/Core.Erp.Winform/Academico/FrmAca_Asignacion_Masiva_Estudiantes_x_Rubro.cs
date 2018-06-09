using Core.Erp.Info.General;
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
using Core.Erp.Business.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Asignacion_Masiva_Estudiantes_x_Rubro : Form
    {
        #region "Variables"
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Rubro_Info rubroInfo = new Aca_Rubro_Info();

        //public delegate void delegate_FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        //public event delegate_FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing event_FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing;

        List<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> Lista_Periodo_x_Rubro = new List<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
        Aca_Rubro_x_Aca_Periodo_Lectivo_Bus Periodo_x_Rubro_Bus = new Aca_Rubro_x_Aca_Periodo_Lectivo_Bus();
        BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> BLista_Periodo_x_rubro = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
        Aca_Rubro_x_Aca_Periodo_Lectivo_Info InfoRubroPeriodo = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();
        //BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> lsttemp = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
        //Aca_RubroTipo_Bus BusTipoRubro = new Aca_RubroTipo_Bus();
        //List<Aca_RubroTipo_Info> Lista_TipoRubro = new List<Aca_RubroTipo_Info>();

        //Aca_Periodo_Bus BusPeriodo = new Aca_Periodo_Bus();
        //Aca_Periodo_Info Info_Periodo = new Aca_Periodo_Info();
        //List<Aca_Periodo_Info> List_Periodo = new List<Aca_Periodo_Info>();
        Aca_Contrato_x_Estudiante_Bus BusContratoEstudiante = new Aca_Contrato_x_Estudiante_Bus();
        Aca_Contrato_x_Estudiante_Info InfoContratoEstudiante = new Aca_Contrato_x_Estudiante_Info();
        List<Aca_Contrato_x_Estudiante_Info> ListaContratoEstudiante = new List<Aca_Contrato_x_Estudiante_Info>();

        Aca_Contrato_x_Estudiante_det_Bus BusContratoEstudianteDet = new Aca_Contrato_x_Estudiante_det_Bus();
        Aca_Contrato_x_Estudiante_det_Info InfoContratoEstudianteDet = new Aca_Contrato_x_Estudiante_det_Info();
        List<Aca_Contrato_x_Estudiante_det_Info> ListaContratoEstudianteDet = new List<Aca_Contrato_x_Estudiante_det_Info>();

        #endregion
        public FrmAca_Asignacion_Masiva_Estudiantes_x_Rubro()
        {
            InitializeComponent();
            
        }



         #region "Eventos"
        private void FrmAca_Asignacion_Masiva_Estudiantes_x_Rubro_Load(object sender, EventArgs e)
        {
            try
            {
                //gridCtrlEstudiantesContrato.DataSource = ListaContratoEstudiante;
                CargarCombos();
                CargarDatos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        //chkActivo.Checked = true;
                        //Cargar_Periodos(param.IdInstitucion, Convert.ToInt16(ucAca_Rubro1.get_item()));
                        //CargarDatos();
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucAca_Rubro1.Enabled(false);
                        //CargarDatos();
                        //Cargar_Datos_a_Modificar(param.IdInstitucion, Convert.ToInt16(ucAca_Rubro1.get_item()));
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        CargarDatos();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        CargarDatos();
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }


        

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        //private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        //{
        //    bool resultado = GuardarDatos();
        //    if (resultado)
        //    {
        //        Close();
        //    }
        //}

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            //Anular();
        }
        private void ucAca_Rubro1_Event_UCRubro_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                BLista_Periodo_x_rubro = Periodo_x_Rubro_Bus.Get_List_rubro_x_periodo(param.IdInstitucion, Convert.ToInt16(ucAca_Rubro1.get_item()));
                if (BLista_Periodo_x_rubro == null) 
                {
                    MessageBox.Show("El Rubro no tiene Periodos Asignados, favor Asignar Periodos al Rubro Elegido");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
         #endregion

        #region "CargarDatos"
        public void CargarCombos()
        {
            try
            {
                ucAca_Anio_Lectivo1.cargaCmb_Anio_Lectivo_Activo();
                ucAca_Rubro1.cargaCmb_Rubro();
                ucAca_Rubro1.set_item(rubroInfo.IdRubro);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        public void CargarDatos()
        {
            try
            {

                lblAnulado.Visible = (rubroInfo.estado == "I") ? true : false;

                ListaContratoEstudiante = BusContratoEstudiante.Get_List_Estudiante_con_Contrato(param.IdInstitucion, 1);
                gridCtrlEstudiantesContrato.DataSource = ListaContratoEstudiante;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Proceso"
       
        public bool Grabar()
        {
            bool resultado = false;
            try
            {
                string mensaje = string.Empty;
                int id = 0;

                if (BusContratoEstudianteDet.GuardarDB(GetContratoEstudianteDet()))
                    {
                        resultado = true;
                    }
               
                if (resultado == true)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucAca_Rubro1.Inicializar_Combo();
                    CargarDatos();
                   
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            return resultado;
        }

        public bool Actualizar()
        {  bool resultado=false;
            try
            {
                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            return resultado;
        }

        private void Anular()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool GuardarDatos()
        {
            bool resultado = false;
            try
            {
                if (validaciones())
                {   
                   resultado =  Grabar();                    
                }                
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
            return resultado;
        }

        public bool validaciones()
        {
            try
            {
                if (ucAca_Rubro1.get_item_info().IdRubro == 0 || ucAca_Rubro1.get_item_info() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Rubro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucAca_Rubro1.UC_Rubro.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region "GET"
        public List<Aca_Contrato_x_Estudiante_det_Info> GetContratoEstudianteDet() 
        {
            try
            {
                ListaContratoEstudianteDet = new List<Aca_Contrato_x_Estudiante_det_Info>();
                InfoContratoEstudianteDet = new Aca_Contrato_x_Estudiante_det_Info();
                DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e;// = new DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs;
                foreach (var rubro in BLista_Periodo_x_rubro)
                {
                   
                    for (int i = 0; i < gridvwEstudiantesContrato.RowCount; i++)
                    {
                        
                         var contrato = (Aca_Contrato_x_Estudiante_Info)gridvwEstudiantesContrato.GetRow(i);
                         if (contrato != null && contrato.chequear == true)
                         {
                             InfoContratoEstudianteDet.IdInstitucion = contrato.IdInstitucion;
                             InfoContratoEstudianteDet.IdContrato = contrato.IdContrato;
                             InfoContratoEstudianteDet.IdRubro = rubro.IdRubro;
                             InfoContratoEstudianteDet.IdInstitucion_Per = rubro.IdInstitucion_per;
                             InfoContratoEstudianteDet.IdAnioLectivo_Per = rubro.IdAnioLectivo;
                             InfoContratoEstudianteDet.IdPeriodo_Per = rubro.IdPeriodo;
                             InfoContratoEstudianteDet.FechaCreacion = DateTime.Now;
                             InfoContratoEstudianteDet.UsuarioCreacion = param.InfoUsuario.IdUsuario;
                             InfoContratoEstudianteDet.Observacion = "Asignaicon masiva de Estudiante x Rubro";

                             ListaContratoEstudianteDet.Add(InfoContratoEstudianteDet);
                         }
                    }
                }
                return ListaContratoEstudianteDet;
              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return new List<Aca_Contrato_x_Estudiante_det_Info>();
            }
            
        }
        #endregion

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDatos())
                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
