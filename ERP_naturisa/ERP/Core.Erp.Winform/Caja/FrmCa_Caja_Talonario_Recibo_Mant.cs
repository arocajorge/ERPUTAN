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
using Core.Erp.Business.Caja;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Info.Caja;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Winform.Caja
{
    public partial class FrmCa_Caja_Talonario_Recibo_Mant : Form
    {
        #region Variables

        Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //bus
        Caj_Talonario_Recibo_Bus Bus_Talonario_Recibo = new Caj_Talonario_Recibo_Bus();
        fa_PuntoVta_Bus Bus_PuntoVta = new fa_PuntoVta_Bus();
        tb_Sucursal_Bus Bus_Sucursal = new tb_Sucursal_Bus();
        caj_catalogo_Bus Bus_cata = new caj_catalogo_Bus(); //opin 2017/03/23
        //info
        Caj_Talonario_Recibo_Info Info_Talonario_Recibo = new Caj_Talonario_Recibo_Info();
                
        //listas
        List<fa_PuntoVta_Info> Lista_PuntoVta = new List<fa_PuntoVta_Info>();
        List<tb_Sucursal_Info> Lista_Sucursal = new List<tb_Sucursal_Info>();
        List<caj_catalogo_Info> Lista_Cata = new List<caj_catalogo_Info>(); //opin 2017/03/23

        public delegate void delegate_FrmCa_Caja_Talonario_Recibo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCa_Caja_Talonario_Recibo_Mant_FormClosing event_FrmCa_Caja_Talonario_Recibo_Mant_FormClosing;

        int numDocActual = 0;
        int sig_num_recibo=0;
        string msg, msg2 = "";
        int cantidad_a_generar = 0;

        #endregion

        public FrmCa_Caja_Talonario_Recibo_Mant()
        {
            InitializeComponent();
            event_FrmCa_Caja_Talonario_Recibo_Mant_FormClosing += FrmCa_Caja_Talonario_Recibo_Mant_event_FrmCa_Caja_Talonario_Recibo_Mant_FormClosing;
        }

        void FrmCa_Caja_Talonario_Recibo_Mant_event_FrmCa_Caja_Talonario_Recibo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void Cargar_Combos()
        {
            try
            {
                Lista_Sucursal = new List<tb_Sucursal_Info>(Bus_Sucursal.Get_List_Sucursal(param.IdEmpresa));
                cmb_sucursal.Properties.DataSource = Lista_Sucursal;
                Lista_Cata = new List<caj_catalogo_Info>(Bus_cata.Lista_catalogo());
                cmb_TipoDoc.Properties.DataSource = Lista_Cata;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Accion_in_controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        ucGe_Menu.Enabled_btnGuardar = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
                        lbl_doc_inicial.Text = "Dcto. Inicial:";
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Enabled_btnGuardar = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
                        lbl_doc_inicial.Text = "Recibo N°:";
                        lbl_a_generar.Visible = false;
                        txt_cantidad_generar.Visible = false;
                        lbl_doc_final.Visible = false;
                        txt_doc_inicial.Visible = false;
                        Set_Info_in_Controls();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntAnular = true;
                        lbl_doc_inicial.Text = "Recibo N°:";
                        lbl_a_generar.Visible = false;
                        txt_cantidad_generar.Visible = false;
                        lbl_doc_final.Visible = false;
                        txt_doc_inicial.Visible = false;
                        Set_Info_in_Controls();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        lbl_doc_inicial.Text = "Recibo N°:";
                        lbl_a_generar.Visible = false;
                        txt_cantidad_generar.Visible = false;
                        lbl_doc_final.Visible = false;
                        txt_doc_inicial.Visible = false;
                        Set_Info_in_Controls();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Info(Caj_Talonario_Recibo_Info Info)
        {
            try
            {
                Info_Talonario_Recibo = Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Info_in_Controls()
        {
            try
            {
                txt_idRecibo.Text = Info_Talonario_Recibo.IdRecibo.ToString();
                cmb_sucursal.EditValue = Info_Talonario_Recibo.IdSucursal;
                cmb_puntoVta.EditValue = Info_Talonario_Recibo.IdPuntoVta;
                txt_doc_inicial.Text = Info_Talonario_Recibo.Num_Recibo;
                chk_activo.Checked = Info_Talonario_Recibo.Estado;
                chk_usado.Checked = Info_Talonario_Recibo.Usado;
                cmb_TipoDoc.EditValue = Info_Talonario_Recibo.IdTipo_Docu_cat;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Caj_Talonario_Recibo_Info Get_Info_Talonario()
        {
            try
            {
                Info_Talonario_Recibo = new Caj_Talonario_Recibo_Info();

                Info_Talonario_Recibo.IdEmpresa = param.IdEmpresa;
                Info_Talonario_Recibo.IdRecibo = Convert.ToDecimal(txt_idRecibo.Text);
                Info_Talonario_Recibo.IdSucursal = Convert.ToInt32(cmb_sucursal.EditValue);
                Info_Talonario_Recibo.IdPuntoVta = Convert.ToInt32(cmb_puntoVta.EditValue);
                Info_Talonario_Recibo.Num_Recibo = txt_doc_inicial.Text;
                Info_Talonario_Recibo.IdUsuario = param.IdUsuario;
                Info_Talonario_Recibo.Fecha_Transac = DateTime.Now;
                Info_Talonario_Recibo.Estado = chk_activo.Checked;
                Info_Talonario_Recibo.Usado = chk_usado.Checked;
                Info_Talonario_Recibo.IdTipo_Docu_cat = Convert.ToString(cmb_TipoDoc.EditValue);//opin 2017/03/23
                return Info_Talonario_Recibo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                throw;
            }
        }

        public void Limpiar()
        {
            try
            {
                cmb_puntoVta.EditValue = null;
                cmb_sucursal.EditValue = null;
                txt_doc_final.Text = "";
                txt_doc_inicial.Text = "";
                txt_cantidad_generar.Text = "";
                cmb_TipoDoc.EditValue = null;//opin 2017/03/23
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean Grabar_Datos()
        {
            try
            {
                Boolean respuesta = false;

                if (!Validar_Datos())
                    return false;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        respuesta = Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        respuesta = Actualizar();
                        break;
                    
                    default:
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public Boolean Grabar()
        {
            try
            {
                bool resultado = false;
                txt_doc_final.Focus();
                if (!Validar_Datos())
                    return false;

                cantidad_a_generar = Convert.ToInt32(txt_cantidad_generar.Text);

                for (int i = 0; i < cantidad_a_generar; i++)
                {
                    Info_Talonario_Recibo = new Caj_Talonario_Recibo_Info();
                    Info_Talonario_Recibo.IdEmpresa = param.IdEmpresa;
                    Info_Talonario_Recibo.IdSucursal = Convert.ToInt32(cmb_sucursal.EditValue);
                    Info_Talonario_Recibo.IdPuntoVta = Convert.ToInt32(cmb_puntoVta.EditValue);
                    Info_Talonario_Recibo.Num_Recibo = Convert.ToString(i + Convert.ToInt32(txt_doc_inicial.EditValue)).PadLeft(9, '0');
                    Info_Talonario_Recibo.Usado = chk_usado.Checked;
                    Info_Talonario_Recibo.Estado = chk_activo.Checked;
                    Info_Talonario_Recibo.IdUsuario = param.IdUsuario;
                    Info_Talonario_Recibo.Fecha_Transac = DateTime.Now;
                    Info_Talonario_Recibo.IdTipo_Docu_cat = Convert.ToString(cmb_TipoDoc.EditValue);//opin 2017/03/23
                    if (!Bus_Talonario_Recibo.GuardarDB(Info_Talonario_Recibo, ref msg))
                    {
                        msg2 = msg;
                    }
                    else
                    {
                       resultado = true;
                    }
                }
                if (resultado)//opin 2017/03/23
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information); //opin 2017/03/23
                }
                    return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public Boolean Actualizar()
        {
            try
            {
                txt_doc_final.Focus();
                Get_Info_Talonario();

                cantidad_a_generar = Convert.ToInt32(txt_cantidad_generar.Text);

                Info_Talonario_Recibo.IdUsuarioUltMod = param.IdUsuario;
                Info_Talonario_Recibo.Fecha_UltMod = DateTime.Now;

                if(!Bus_Talonario_Recibo.ModificarDB(Info_Talonario_Recibo, ref msg))
                {
                    msg2 = msg;
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);//opin 2017/03/23
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public Boolean Validar_Datos()
        {
            try
            {
                if (cmb_sucursal.EditValue == null)
                {
                    MessageBox.Show("Favor seleccione una Sucursal para continuar", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (cmb_puntoVta.EditValue == null)
                {
                    MessageBox.Show("Favor seleccione una Punto de venta para continuar", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txt_doc_inicial.Text == null || txt_doc_inicial.Text == "")
                {
                    MessageBox.Show("Favor ingrese el número de documento inicial", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txt_cantidad_generar.Text == null || txt_cantidad_generar.Text == "")
                {
                    MessageBox.Show("Favor ingrese la cantidad de documentos a generar", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (cmb_TipoDoc.EditValue == null)//opin 2017/03/23
                {
                    MessageBox.Show("Favor seleccione un Tipo de Documento para continuar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_TipoDoc.Focus();
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void FrmCa_Caja_Talonario_Recibo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combos();
                switch (Accion)//opin 2017/03/23
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set_Info_in_Controls();
                        break;                   
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar_Datos())
                    Limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar_Datos())
                    Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmCa_Caja_Talonario_Recibo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmCa_Caja_Talonario_Recibo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_sucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_puntoVta.EditValue = null;
                Lista_PuntoVta = new List<fa_PuntoVta_Info>(Bus_PuntoVta.Get_List_PuntoVta(param.IdEmpresa, Convert.ToInt32(cmb_sucursal.EditValue)));
                cmb_puntoVta.Properties.DataSource = Lista_PuntoVta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_doc_inicial_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string StrNumDoc = "";
                if (cmb_sucursal.EditValue != null)
                {
                    if (cmb_sucursal.EditValue.ToString() != "")
                    {
                        if (cmb_puntoVta.EditValue != null)
                        {
                            if (cmb_puntoVta.EditValue.ToString() != "")
                            {
                                if (txt_doc_inicial.Text != "")
                                {
                                    numDocActual = Convert.ToInt32(txt_doc_inicial.Text.Trim());
                                    StrNumDoc = Convert.ToString(numDocActual);
                                    txt_doc_inicial.Text = StrNumDoc.PadLeft(9, '0');
                                    if (txt_cantidad_generar.Text != "")
                                    {
                                        StrNumDoc = Convert.ToString(numDocActual + Convert.ToInt32(txt_cantidad_generar.Text));
                                        txt_doc_final.Text = StrNumDoc.PadLeft(9, '0');
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_cantidad_generar_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((txt_doc_inicial.Text != "") && (txt_cantidad_generar.Text != ""))
                {
                    string final = Convert.ToString(Convert.ToDouble(txt_doc_inicial.Text) + Convert.ToDouble(txt_cantidad_generar.Text));
                    txt_doc_final.Text = final.PadLeft(9, '0');
                }
                else
                {
                    txt_doc_final.Text = "";
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }           
        }

        private void cmb_TipoDoc_EditValueChanged(object sender, EventArgs e)//opin 2017/03/23
        {
            try
            {
                if (cmb_TipoDoc.EditValue != null || cmb_TipoDoc.Text != "[Vacío]")
                {
                    txt_doc_inicial.Text = "";
                    txt_doc_inicial.Text = Bus_Talonario_Recibo.Get_Num_ultimo_Recibo(param.IdEmpresa, Convert.ToInt32(cmb_sucursal.EditValue), Convert.ToInt32(cmb_puntoVta.EditValue), Convert.ToString(cmb_TipoDoc.EditValue), ref msg);
                }
                else
                    txt_doc_inicial.Text = "";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
