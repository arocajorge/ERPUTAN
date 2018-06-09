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
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;


namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaBecas_Mant : Form
    {
        #region " Constructor "
        public FrmAcaBecas_Mant()
        {
            InitializeComponent();
            event_FrmAcaBecas_Mant_FormClosing += FrmAcaBecas_Mant_event_FrmAcaBecas_Mant_FormClosing;
        }
        #endregion

        #region "Load"
        private void FrmAcaBecas_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Rubro.cargaCmb_Rubro();
                               
                if (Accion == 0)
                { Accion = Cl_Enumeradores.eTipo_action.grabar; }

                set_Accion_In_Controls();    
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Variables"
        private Cl_Enumeradores.eTipo_action Accion;
            tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
            Aca_Beca_Info Info = new Aca_Beca_Info();
            Aca_Beca_Bus BusBeca = new Aca_Beca_Bus();




            public delegate void delegate_FrmAcaBecas_Mant_FormClosing(object sender, FormClosingEventArgs e);
            public event delegate_FrmAcaBecas_Mant_FormClosing event_FrmAcaBecas_Mant_FormClosing;
        #endregion
               
        #region "Set"
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Info(Aca_Beca_Info _info)
        {
            try
            {
                Info = _info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void set_Accion_In_Controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        chkActivo.Checked = true;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        set_Info_in_Controls();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        set_Info_in_Controls();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        set_Info_in_Controls();
                        Rubro.UC_Rubro.Properties.ReadOnly = true;
                        txt_porcentaje.Properties.ReadOnly = true;
                        txt_descripcion.ReadOnly = true;
                        chkActivo.Enabled = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void set_Info_in_Controls()
        {
            try
            {
                txt_descripcion.Text = Info.nom_beca;
                txtIdBeca.Text = Info.IdBeca.ToString();
                txt_porcentaje.Text = Info.porcentaje.ToString();
                chkActivo.Checked = (Info.estado == "A") ? true : false;
                lblAnulado.Visible = (Info.estado == "I") ? true : false;
                Rubro.set_item(Convert.ToInt16(Info.IdRubro));

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region"Get" 

        public Aca_Beca_Info GetInfo()
        {
            Aca_Beca_Info rInfo = new Aca_Beca_Info();
            try
            {
                rInfo.IdInstitucion = param.IdInstitucion;
                rInfo.IdBeca = (txtIdBeca.Text == "") ? 0 : Convert.ToInt32(txtIdBeca.Text);
                rInfo.nom_beca = txt_descripcion.Text;
                rInfo.porcentaje = Convert.ToDouble(txt_porcentaje.Text);
                rInfo.estado = (chkActivo.Checked == true) ? "A" : "I";
                rInfo.IdUsuarioUltMod = param.IdUsuario;
                rInfo.IdRubro = Convert.ToInt32(Rubro.get_item());

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rInfo;
        }
        #endregion

        #region "Proceso"
            private bool Guardar()
            {
                bool resultado = false;
                try
                {
                    Aca_Beca_Info InfoBeca = new Aca_Beca_Info();

                    string mensaje = string.Empty;
                    int IdBeca = 0;

                    InfoBeca = GetInfo();
                    resultado = BusBeca.GrabarDB(InfoBeca, ref IdBeca, ref mensaje);
                

                    if (resultado == true)
                    {
                        txtIdBeca.Text = IdBeca.ToString();
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la Beca #" + InfoBeca.IdBeca , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    NameMetodo = NameMetodo + " - " + ex.ToString();
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                    MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                        , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return resultado;
            }

            private bool Actualizar()
            {  bool resultado=false;
                try
                {
                
                    Aca_Beca_Info InfoBeca = new Aca_Beca_Info();
                    string mensaje = string.Empty;

                    InfoBeca = GetInfo();
                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje);
                        return false;
                    }
                
                    resultado = BusBeca.ActualizarDB(InfoBeca, ref mensaje);
                    if (resultado)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " la Beca #" + InfoBeca.IdBeca, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return resultado;
                }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    NameMetodo = NameMetodo + " - " + ex.ToString();
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                    MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                        , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            private bool Anular()
            {
                bool resultado = false;
                try
                {
                    

                    if (Info.estado != "I")
                    {
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + " la Beca #:" + txtIdBeca.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                            fr.ShowDialog();   


                            Aca_Beca_Info InfoBeca = new Aca_Beca_Info();
                            string mensaje = string.Empty;

                            InfoBeca = GetInfo();
                            if (mensaje != "")
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            InfoBeca.UsuarioAnulacion = param.IdUsuario;
                            InfoBeca.MotivoAnulacion = fr.motivoAnulacion;
                            resultado =BusBeca.AnularDB(InfoBeca, ref mensaje);
                            if (resultado)
                            {
                                MessageBox.Show(mensaje + InfoBeca.IdBeca, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                         
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else {
                        MessageBox.Show("La Beca #:"+txtIdBeca.Text.Trim() + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return resultado;
                }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    NameMetodo = NameMetodo + " - " + ex.ToString();
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                    MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                        , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            private bool Proceso_Guardar()
            {
                bool resultado = false;
                try
                {
                    if (Validaciones())
                    {
                        switch (Accion)
                        {
                            case Cl_Enumeradores.eTipo_action.grabar:
                                resultado =  Guardar();
                                break;

                            case Cl_Enumeradores.eTipo_action.actualizar:
                                resultado = Actualizar();
                                break;
                        }
                    }                
                }

                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    NameMetodo = NameMetodo + " - " + ex.ToString();
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                    MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                        , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return resultado;
            }

            private bool Validaciones()
            {
                try
                {

                    if (Rubro.get_item_info().IdRubro == 0)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " Rubro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Rubro.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(txt_descripcion.Text))
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) +" descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_descripcion.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(txt_porcentaje.Text))
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " porcentaje", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_porcentaje.Focus();
                        return false;
                    }
             
                    return true;
                }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    NameMetodo = NameMetodo + " - " + ex.ToString();
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                    MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                        , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            private void Limpiar()
            {
                try
                {
                    txtIdBeca.Text = "0";
                    Rubro.Inicializar_Combo();
                    txt_descripcion.Text = string.Empty;
                    txt_porcentaje.Text = "0";

                }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    NameMetodo = NameMetodo + " - " + ex.ToString();
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                    MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                        , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
        
        #endregion

        #region "Eventos"

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }      

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (Proceso_Guardar() == true)
            {
                Limpiar();
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_Accion_In_Controls();
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            bool resultado = Proceso_Guardar();
            if (resultado)
            {
                
                Close();    
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Anular() == true)
                {
                    this.Close();
                    //Accion = Cl_Enumeradores.eTipo_action.grabar;
                    //Limpiar();
                    //set_Accion_In_Controls();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FrmAcaBecas_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAcaBecas_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                Limpiar();
                set_Accion_In_Controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void FrmAcaBecas_Mant_event_FrmAcaBecas_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
     
        #endregion

    }
}
