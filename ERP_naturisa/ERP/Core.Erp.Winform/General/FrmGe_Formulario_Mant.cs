using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.IO;
using System.Data.SqlClient;
using System.Reflection;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;


namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Formulario_Mant : Form
    {
        public delegate void delegate_FrmGe_Formulario_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_Formulario_Mant_FormClosing event_FrmGe_Formulario_Mant_FormClosing;

        
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        tb_modulo_Bus Bus_Modulo = new tb_modulo_Bus();
        List<tb_modulo_Info> ListInfo_Modulo = new List<tb_modulo_Info>();

        tb_sis_formulario_Info Info_Formulario = new tb_sis_formulario_Info();
        tb_sis_formulario_Bus Bus_Formulario = new tb_sis_formulario_Bus();


        List<tb_sis_formulario_Info> ListInfo_Formularios = new List<tb_sis_formulario_Info>();
        List<tb_sis_formulario_Info> ListInfo_Formulario_Combo_filtrado = new List<tb_sis_formulario_Info>();



        private Cl_Enumeradores.eTipo_action _Accion;
        List<String> lstTipo = new List<String>();

        private Assembly Ensamblado;
        

        public FrmGe_Formulario_Mant()
        {
            try
            {
                InitializeComponent();
                event_FrmGe_Formulario_Mant_FormClosing += FrmGe_Formulario_Mant_event_FrmGe_Formulario_Mant_FormClosing;
                
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

        void FrmGe_Formulario_Mant_event_FrmGe_Formulario_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        void Set_Info_in_controls()
        {

            try
            {


                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        chkestado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        txt_CodFormulario.ReadOnly = true;
                        txt_CodFormulario.ReadOnly = true;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        Set_Info_in_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set_Info_in_Controls();

                        txt_CodFormulario.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Visible_bntDiseñoReporte = false;
                        txt_CodFormulario.ReadOnly = true;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        Set_Info_in_Controls();

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                
                
            }

        }


        private void FrmGe_Formulario_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }

                Cargar_Combos();

                Set_Info_in_controls();


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

        private bool valida()
        {
            try
            {

                if (cmb_modulo.EditValue == null || cmb_modulo.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Modulo al que pertenece el formulario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_formulario.EditValue == null || cmb_formulario.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " formulario ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Get_Info()
        {
            try
            {
                Info_Formulario.CodModulo = cmb_modulo.EditValue.ToString();
                Info_Formulario.estado = chkestado.Checked;
                Info_Formulario.IdFormulario = txt_CodFormulario.Text;
                Info_Formulario.nom_Asembly = txt_asembly.Text;
                Info_Formulario.nom_Formulario = cmb_formulario.Text;
                Info_Formulario.observacion = txt_observacion.Text;
                Info_Formulario.Text = txt_texto.Text;

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



        private void Set_Info_in_Controls()
        {

            try
            {
                txt_IdFormulario.Text = Info_Formulario.IdFormulario;
                txt_CodFormulario.Text = Info_Formulario.cod_Formulario;
                cmb_modulo.EditValue = Info_Formulario.CodModulo;
                chkestado.Checked = Info_Formulario.estado;
                txt_asembly.Text =Info_Formulario.nom_Asembly ;
                cmb_formulario.EditValue = Info_Formulario.nom_Formulario;
                txt_observacion.Text =Info_Formulario.observacion;
                txt_texto.Text = Info_Formulario.Text;


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

        public void Set_Info(tb_sis_formulario_Info _info)
        {
            try
            {

                Info_Formulario = _info;

                
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

        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;

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
       
        private void Grabar()
        {
            try
            {
                if(valida())
                {
                   
                    Get_Info();

                    

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                       

                            if (Bus_Formulario.GuardarDB(Info_Formulario))
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente)  , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                            }
                            else
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos) , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (Bus_Formulario.ModificarDB(Info_Formulario))
                        {

                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente)  , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                        }
                        else
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_modificaron_los_datos) , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }

        void limpiar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu.Visible_btnGuardar = true;


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




        


        private void Cargar_Combo_Formulario(string Nom_Asambly,string cod_modelo)
        {
            try
            {

                


                ListInfo_Formulario_Combo_filtrado = new List<tb_sis_formulario_Info>();


                ListInfo_Formularios = new List<tb_sis_formulario_Info>();

                string sNom_Asembly= txt_asembly.Text;
                string sNom_Asembly_sin_extencion = sNom_Asembly.Replace(".exe","");
                sNom_Asembly_sin_extencion = sNom_Asembly_sin_extencion.Replace(".dll", "");
                sNom_Asembly_sin_extencion = sNom_Asembly_sin_extencion + ".";

                   
                System.Reflection.Assembly Ensamblado;
                Ensamblado = System.Reflection.Assembly.LoadFrom(Nom_Asambly);

                foreach (Type type in Ensamblado.GetTypes())
                {

                    tb_sis_formulario_Info InfoItem= new tb_sis_formulario_Info();

                    InfoItem.IdFormulario = type.FullName;
                    InfoItem.nom_Formulario = type.FullName.Replace(sNom_Asembly_sin_extencion , "");
                    InfoItem.nom_Asembly = sNom_Asembly;
                    try
                    {
                        InfoItem.CodModulo = InfoItem.nom_Formulario.Substring(0, InfoItem.nom_Formulario.IndexOf("."));
                    }
                    catch (Exception ex)
                    {
                    }
                    

                    ListInfo_Formularios.Add(InfoItem);
                }


                ListInfo_Formulario_Combo_filtrado = ListInfo_Formularios.FindAll(v => v.CodModulo == cod_modelo);
                cmb_formulario.Properties.DataSource = ListInfo_Formulario_Combo_filtrado; ;

      
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

        private void ucGe_Menu_event_btnImpRep_Click(object sender, EventArgs e)
        {

            try
            {

                string nombre_dll = "";
                string Nom_asambly = "";
                string NombreReporte = "";
                string RutaPantalla = "";

                //Nom_asambly = txt_asembly.Text.Trim();
                //NombreReporte = txt_class_rpt.Text.Trim();

                nombre_dll = Nom_asambly + ".dll";

                //cargando la dll
                Ensamblado = Assembly.LoadFrom(nombre_dll);

                // Load the object
                string nAsambly2 ;//= txt_asembly.Text;

                Object ObjFrm;
                Type tipo = Ensamblado.GetType(Nom_asambly + "." + NombreReporte);

                AssemblyName assemName = Ensamblado.GetName();
                Version ver = assemName.Version;
                //
                RutaPantalla = Nom_asambly + "." + NombreReporte;

                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el Reporte Emsamblado:" + Nom_asambly + "  Reporte:" + NombreReporte, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ObjFrm = Activator.CreateInstance(tipo);
                    DevExpress.XtraReports.UI.XtraReport reporte1 = (DevExpress.XtraReports.UI.XtraReport)ObjFrm;
                    reporte1.ShowPreviewDialog();
                    
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

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
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

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valida())
                {
                    Grabar();
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

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {

                if (valida())
                {
                      Grabar();
                        this.Close();
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

        private void FrmGe_Formulario_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmGe_Formulario_Mant_FormClosing(sender, e);
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

     
        private void txt_nom_formulario_TextChanged(object sender, EventArgs e)
        {

        }


        private void Cargar_Combos()
        {
            try
            {
                ListInfo_Modulo= Bus_Modulo.Get_list_Modulo();
                cmb_modulo.Properties.DataSource = ListInfo_Modulo;

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

        

        private void cmb_modulo_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
           
        }

        private void cmb_formulario_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

            

        }

        private void cmb_modulo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sModulo = "";

                sModulo = ListInfo_Modulo.FirstOrDefault(v => v.CodModulo == Convert.ToString(cmb_modulo.EditValue)).Nom_Carpeta;
                Cargar_Combo_Formulario(txt_asembly.Text, sModulo);
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

        private void cmb_formulario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tb_sis_formulario_Info InfoFormulario = ListInfo_Formulario_Combo_filtrado.FirstOrDefault(v => v.IdFormulario == Convert.ToString(cmb_formulario.EditValue));

                txt_CodFormulario.Text = InfoFormulario.IdFormulario;
                txt_texto.Text = InfoFormulario.Text;
            }
            catch (Exception ex)
            {


            }
        }
      

    }
}
