using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Recursos.Properties;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Periodo_Mant : Form
    {
        #region Variables

        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Periodo_Info Info_Periodo = new Aca_Periodo_Info();
        Aca_Periodo_Bus Bus_Periodo = new Aca_Periodo_Bus();
        Aca_Anio_Lectivo_Bus Bus_Anio_Lectivo = new Aca_Anio_Lectivo_Bus();
        List<Aca_Anio_Lectivo_Info> Lista = new List<Aca_Anio_Lectivo_Info>();

        public delegate void delegate_FrmAca_Periodo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAca_Periodo_Mant_FormClosing event_FrmAca_Periodo_Mant_FormClosing;

        #endregion
        public FrmAca_Periodo_Mant()
        {
            InitializeComponent();
            event_FrmAca_Periodo_Mant_FormClosing += FrmAca_Periodo_Mant_event_FrmAca_Periodo_Mant_FormClosing;
            LLenar_AnioLectivo();
        }

        void FrmAca_Periodo_Mant_event_FrmAca_Periodo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmAca_Periodo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAca_Periodo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #region "Funciones Set y Get"

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Set_Periodo(Aca_Periodo_Info Info)
        {
            try
            {
                Info_Periodo = Info;
                txtIdPeriodo.Text = Info_Periodo.IdPeriodo.ToString();
                searchLookUpAnio_Lectivo.EditValue = Info_Periodo.IdAnioLectivo;
                dtFechaIni.Text = Convert.ToString(Info_Periodo.pe_FechaIni);
                dtFechaFin.Text = Convert.ToString(Info_Periodo.pe_FechaFin);
                CheckEstado.Checked = (Info_Periodo.pe_estado == "A") ? true : false;
                lblEstado.Visible = (Info_Periodo.pe_estado == "I") ? true : false;

                if (Info_Periodo.pe_estado == "I")
                    lblEstado.Visible = true;
                else
                    lblEstado.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public Aca_Periodo_Info Get_Periodo()
        {
            try
            {
                Info_Periodo.IdInstitucion = param.IdInstitucion;

                //Info_Periodo.IdAnioLectivo = Convert.ToString(searchLookUpAnio_Lectivo.EditValue);
                Info_Periodo.IdAnioLectivo = Convert.ToInt16(searchLookUpAnio_Lectivo.EditValue);

                Info_Periodo.IdPeriodo = ((dtFechaIni.Value.Year) * 100 + dtFechaIni.Value.Month); 
                Info_Periodo.pe_FechaIni = Convert.ToDateTime(dtFechaIni.Text);
                Info_Periodo.pe_FechaFin = Convert.ToDateTime(dtFechaFin.Text);
                Info_Periodo.pe_anio = Convert.ToInt32(dtFechaIni.Value.Year);
                Info_Periodo.pe_mes = Convert.ToInt32(dtFechaIni.Value.Month);
                Info_Periodo.pe_estado = (CheckEstado.Checked == true) ? "A" : "I";
                Info_Periodo.est_apertura = (CheckEstado.Checked == true) ? "A" : "I";

                return Info_Periodo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return new Aca_Periodo_Info();
            }
        }

        #endregion

        #region "Procesos"

        private Boolean Validar()
        {
            try
            {
                if (dtFechaIni.Text == null || dtFechaIni.Text == "" || CheckEstado.Text.Length == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " fecha inicial ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtFechaFin.Focus();
                    return false;
                }

                if (dtFechaFin.Text == null || dtFechaFin.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " fecha fin ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtFechaIni.Focus();
                    return false;
                }

                if (CheckEstado.Text.Length == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Estado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CheckEstado.Focus();
                    return false;
                }

                if (Convert.ToDateTime(dtFechaIni.Text) > Convert.ToDateTime(dtFechaFin.Text))
                {
                    MessageBox.Show("La fecha de inicio :  " + Convert.ToDateTime(dtFechaIni.Text) + " ,  no puede ser mayor a la fecha final : " + Convert.ToDateTime(dtFechaFin.Text), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtFechaIni.Focus();
                    return false;
                }

                if (searchLookUpAnio_Lectivo.EditValue == null || searchLookUpAnio_Lectivo.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " año lectivo ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    searchLookUpAnio_Lectivo.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void Limpiar()
        {
            try
            {
                txtIdPeriodo.Text = "";
                txtIdPeriodo.ReadOnly = true;
                dtFechaFin.Value = DateTime.Now;
                dtFechaIni.Value = DateTime.Now;
                CheckEstado.Checked = true;
                searchLookUpAnio_Lectivo.EditValue = null;
                searchLookUpAnio_Lectivo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private Boolean Grabar()
        {
            try
            {

                string msg = "";
                if (Validar())
                {
                    Get_Periodo();
                    bool resultado = PeriodoExiste(param.IdInstitucion, Info_Periodo.IdPeriodo);
                    if (resultado == false)
                    {
                        if (Bus_Periodo.GrabarDB(Info_Periodo, ref msg))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private Boolean Modificar()
        {
            try
            {
                string msg = "";

                if (Validar())
                {
                    Get_Periodo();
                
                        if (Bus_Periodo.ModificarDB(Info_Periodo, ref msg))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Accion = Cl_Enumeradores.eTipo_action.grabar;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_modificaron_los_datos) + ": " + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private Boolean Anular()
        {
            try
            {
                Boolean resultB = false;
                string mensaje = "";
                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) +" periodo?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    Info_Periodo.IdUsuarioUltAnu = param.IdUsuario;
                    Info_Periodo.Fecha_UltMod = DateTime.Now;
                    Info_Periodo.MotivoAnulacion = ofrm.motivoAnulacion;
                    Get_Periodo();
                    if (Info_Periodo.pe_estado != "I")
                    {
                        if (Bus_Periodo.AnularDB(Info_Periodo, ref mensaje))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Anulada_corectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resultB = true;
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resultB = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultB = false;
                    }
                }
                return resultB;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }

        void LLenar_AnioLectivo()
        {
            try
            {
                Bus_Anio_Lectivo = new Aca_Anio_Lectivo_Bus();
                Lista = new List<Aca_Anio_Lectivo_Info>();
                Lista = Bus_Anio_Lectivo.Get_List_Anio_Lectivo(param.IdInstitucion);
                searchLookUpAnio_Lectivo.Properties.DataSource = Lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
           
        }



        #endregion

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(guardarDatos())
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if(guardarDatos())
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if(Anular())
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private Boolean guardarDatos()
        {
            try
            {
                Boolean respuesta = false;
                if (Validar())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            respuesta = Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            respuesta =Modificar();
                            break;
                    }                    
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FrmAca_Periodo_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        lblEstado.Visible = false;
                        CheckEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set_Periodo(Info_Periodo);
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        searchLookUpAnio_Lectivo.Enabled = false;
                        txtIdPeriodo.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set_Periodo(Info_Periodo);
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ValidarDatos();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set_Periodo(Info_Periodo);
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        ValidarDatos();
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        void ValidarDatos()
        {
            txtIdPeriodo.ReadOnly = true;
            searchLookUpAnio_Lectivo.Enabled = false;
            dtFechaFin.Enabled = false;
            dtFechaIni.Enabled = false;
        }
        
          bool PeriodoExiste(int IdInstitucion, int IdPeriodo)
          {
              try
              {
                  bool resultado = false;
                  resultado = Bus_Periodo.ExistePeriodo(param.IdInstitucion, IdPeriodo);                  
                 
                  return resultado;
              }
              catch (Exception ex)
              {
                  MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                  MessageBox.Show(ex.Message);
                  return false;
              }
          }
      
    }
}
