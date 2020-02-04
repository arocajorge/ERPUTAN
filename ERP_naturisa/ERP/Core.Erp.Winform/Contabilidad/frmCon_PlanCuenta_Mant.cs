using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;




namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_PlanCuenta_Mant : Form
    {
        #region Declaración de variables
        string MensajeError = "";
        string IdCbleHijo;
        ct_Plancta_nivel_Bus BusNivel = new ct_Plancta_nivel_Bus();
        List<ct_Plancta_nivel_Info> ListNivelCta = new List<ct_Plancta_nivel_Info>();
        ct_Plancta_Bus PlanCtaBus = new ct_Plancta_Bus();
        List<ct_Plancta_Info> listPlanCta = new List<ct_Plancta_Info>();
        ct_grupo_x_Tipo_Gasto_Bus bus_grupo_x_tipo_gasto = new ct_grupo_x_Tipo_Gasto_Bus();
        ct_grupo_x_Tipo_Gasto_Info info_grupo_x_tipo_gasto = new ct_grupo_x_Tipo_Gasto_Info();
        List<ct_grupo_x_Tipo_Gasto_Info> list_grupo_x_tipo_gasto = new List<ct_grupo_x_Tipo_Gasto_Info>();
        public ct_Plancta_Info InfoPlanCta { get; set; }
        public ct_Plancta_Info InfoPlanCta_padre { get; set; }
        public Cl_Enumeradores.eTipo_action _Accion { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmCon_PlanCuenta_Mant frm;
        public delegate void delegate_frmCon_PlanCuenta_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_PlanCuenta_Mant_FormClosing event_frmCon_PlanCuenta_Mant_FormClosing; 
        #endregion

        public frmCon_PlanCuenta_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_Superior_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_Superior_event_btnlimpiar_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_Superior_event_btnSalir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_Superior_event_btnAnular_Click;

            event_frmCon_PlanCuenta_Mant_FormClosing += frmCon_PlanCuenta_Mant_event_frmCon_PlanCuenta_Mant_FormClosing;

        }

        void ucGe_Menu_Superior_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (anular())
                    this.Close();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        void frmCon_PlanCuenta_Mant_event_frmCon_PlanCuenta_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void ucGe_Menu_Superior_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }            
        }

        void ucGe_Menu_Superior_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }            
        }

        void ucGe_Menu_Superior_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar()==true)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
            }
        }

        void ucGe_Menu_Superior_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                grabar();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
            }
        }

        private void frmCon_PlanCuenta_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combo();
                set_accion(_Accion);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
            }
        }

        private Boolean validar()
        {

            try
            {
                Boolean res = true;

                if (txt_codigo.Text == "")
                {
                    MessageBox.Show( "No Ha Ingresado el Codigo de la Cuenta",param.Nombre_sistema,MessageBoxButtons.OK);
                    return false;
                }

                if (txt_nom_cta.Text == "")
                {
                    MessageBox.Show("No Ha Ingresado el Nombre de la Cuenta", param.Nombre_sistema, MessageBoxButtons.OK);
                    return false;
                }


                if (cmb_nivel.ValueMember=="0")
                {
                    MessageBox.Show("El nivel no puede ser 0", param.Nombre_sistema, MessageBoxButtons.OK);
                    return false;
                }




                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }
        }

        public void set_info()
        {

            try
            {

                txt_codigo.Text = InfoPlanCta.IdCtaCble.ToString();
                //chk_cuenta_raiz.Checked = (InfoPlanCta.IdNivelCta == 0) ? true : false;
                txt_clave.Text = InfoPlanCta.pc_clave_corta;
                txt_nom_cta.Text = InfoPlanCta.pc_Cuenta;
                cmb_cuenta_padre.EditValue = InfoPlanCta.IdCtaCblePadre;
                cmb_naturaleza.Text = (InfoPlanCta.pc_Naturaleza == "D") ? "Deudora" : "Acreedora";
                cmb_grupo_cble.SelectedValue = InfoPlanCta.IdGrupoCble;
                cmb_nivel.SelectedValue = InfoPlanCta.IdNivelCta;
                chk_es_cta_movi.Checked = (InfoPlanCta.pc_EsMovimiento == "S") ? true : false;
                chk_esta_cta_afecta_flujo.Checked = (InfoPlanCta.pc_es_flujo_efectivo == "S") ? true : false;
                chk_estado.Checked = (InfoPlanCta.pc_Estado == "A") ? true : false;
                cmb_Grupo_x_tipo_gasto.EditValue = InfoPlanCta.IdTipo_Gasto;


                if (InfoPlanCta.pc_Estado == "I")
                {
                    lblAnulado.Visible = true;
                }
                else
                {
                    lblAnulado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 

            }

        }

        public void get_info()
        {

            try
            {

                InfoPlanCta.IdEmpresa = param.IdEmpresa;
                InfoPlanCta.IdCtaCble = txt_codigo.Text;
                InfoPlanCta.pc_clave_corta = txt_clave.Text;
                InfoPlanCta.pc_Cuenta = txt_nom_cta.Text;
                InfoPlanCta.IdCtaCblePadre = (cmb_cuenta_padre.EditValue == null) ? null :(string) cmb_cuenta_padre.EditValue;
                InfoPlanCta.pc_Naturaleza =(cmb_naturaleza.Text=="Deudora")?"D" : "C";
                InfoPlanCta.IdGrupoCble=cmb_grupo_cble.SelectedValue.ToString();
                InfoPlanCta.IdNivelCta =(Int32) cmb_nivel.SelectedValue;
                InfoPlanCta.pc_EsMovimiento =   (chk_es_cta_movi.Checked) ? "S": "N";
                InfoPlanCta.pc_es_flujo_efectivo  =   (chk_esta_cta_afecta_flujo.Checked) ? "S" : "N";
                InfoPlanCta.pc_Estado  =   (chk_estado.Checked) ? "A": "I";
                InfoPlanCta.IdUsuario = param.IdUsuario;
                InfoPlanCta.IdUsuarioUltMod = param.IdUsuario;
                

                if (cmb_Grupo_x_tipo_gasto.EditValue != null) InfoPlanCta.IdTipo_Gasto = Convert.ToInt32(cmb_Grupo_x_tipo_gasto.EditValue); else InfoPlanCta.IdTipo_Gasto = null;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 

            }

        }

        public void set_accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                                                
                        limpiar();
                        ucGe_Menu.Visible_bntAnular = false;                       

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntLimpiar = false;


                        this.txt_codigo.Enabled = false;
                        this.txt_codigo.BackColor = System.Drawing.Color.White;
                        this.txt_codigo.ForeColor = System.Drawing.Color.Black;
                        this.cmb_cuenta_padre.Enabled = false;
                        set_info();

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        this.cmb_cuenta_padre.Enabled = false;
                        this.txt_codigo.Enabled = false;
                        this.txt_codigo.BackColor = System.Drawing.Color.White;
                        this.txt_codigo.ForeColor = System.Drawing.Color.Black;

                        
                        set_info();

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        this.cmb_cuenta_padre.Enabled = false;

                        this.txt_codigo.Enabled = false;
                        this.txt_codigo.BackColor = System.Drawing.Color.White;
                        this.txt_codigo.ForeColor = System.Drawing.Color.Black;

                        

                        set_info();
                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void limpiar()
        {
            try
            {
                _Accion = Info.General.Cl_Enumeradores.eTipo_action.grabar;
                InfoPlanCta = new ct_Plancta_Info();
                txt_codigo.Text = "";
                txt_clave.Text = "";
                txt_nom_cta.Text = "";
                cmb_cuenta_padre.EditValue = "";
                cmb_naturaleza.SelectedText = "";
                cmb_grupo_cble.SelectedValue = "";
                cmb_nivel.SelectedValue= 1;
                chk_es_cta_movi.Checked = false;
                chk_esta_cta_afecta_flujo.Checked = false;
                InfoPlanCta = new ct_Plancta_Info();
                chk_estado.Checked = true;
                lblAnulado.Visible = false;
                cmb_Grupo_x_tipo_gasto.EditValue = null;
                cargar_combo();
             }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
            }
        }

        private void cargar_combo()
        {
            try
            {

                listPlanCta = PlanCtaBus.Get_List_Plan_ctaPadre(param.IdEmpresa, ref MensajeError);
                cmb_cuenta_padre.Properties.DataSource= listPlanCta;

                ct_Grupocble_Bus GrupoCbteBus = new ct_Grupocble_Bus();
                List<ct_Grupocble_Info> listGrupoCble = new List<ct_Grupocble_Info>();

                if (cmb_grupo_cble.DataSource==null)
                {
                    listGrupoCble = GrupoCbteBus.Get_list_Grupocble();
                    cmb_grupo_cble.DataSource = listGrupoCble;
                    cmb_grupo_cble.ValueMember = "IdGrupoCble";
                    cmb_grupo_cble.DisplayMember = "gc_GrupoCble";    
                }                

                if (cmb_naturaleza.DataSource == null)
                {
                    List<tb_Catalogo_Info> listCat_Naturaleza = new List<Info.General.tb_Catalogo_Info>();
                    listCat_Naturaleza.Add(new Info.General.tb_Catalogo_Info(0, "D", "Deudora", "A", 0, 0));
                    listCat_Naturaleza.Add(new Info.General.tb_Catalogo_Info(0, "C", "Acreedora", "A", 0, 0));
                    cmb_naturaleza.DataSource = listCat_Naturaleza;
                    cmb_naturaleza.ValueMember = "CodCatalogo";
                    cmb_naturaleza.DisplayMember = "ca_descripcion";
                }

                if (cmb_nivel.DataSource == null)
                {
                    ListNivelCta = BusNivel.Get_list_Plancta_nivel(param.IdEmpresa);
                    cmb_nivel.DataSource = ListNivelCta;
                    cmb_nivel.ValueMember = "IdNivelCta";
                    cmb_nivel.DisplayMember = "IdNivelCta";
                }
                

                list_grupo_x_tipo_gasto = bus_grupo_x_tipo_gasto.Get_list_grupo_x_tipo_Gasto_nivel_3(param.IdEmpresa);
                cmb_Grupo_x_tipo_gasto.Properties.DataSource = list_grupo_x_tipo_gasto;
                cmb_Grupo_x_tipo_gasto.Properties.ValueMember = "IdTipo_Gasto";
                cmb_Grupo_x_tipo_gasto.Properties.DisplayMember = "nom_tipo_Gasto";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_cuenta_padre_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string IdCbleHijo = "";

                InfoPlanCta_padre  = listPlanCta.FirstOrDefault(v => v.IdCtaCble == Convert.ToString(cmb_cuenta_padre.EditValue));
                string MensajeError="";

                if (_Accion == Info.General.Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (InfoPlanCta_padre != null)
                    {
                        IdCbleHijo = PlanCtaBus.Get_Id(InfoPlanCta_padre.IdEmpresa, InfoPlanCta_padre.IdCtaCble, ref MensajeError);
                        if (IdCbleHijo == "")
                            MessageBox.Show("No se Encuentran Parametrizados la Cantidad de Digitos x Nivel", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        txt_codigo.Text = InfoPlanCta_padre.IdCtaCble + IdCbleHijo;
                        txt_nom_cta.Text = InfoPlanCta_padre.pc_Cuenta;
                        cmb_nivel.SelectedValue = InfoPlanCta_padre.IdNivelCta + 1;
                        cmb_grupo_cble.SelectedValue = InfoPlanCta_padre.IdGrupoCble;
                        cmb_naturaleza.SelectedValue = InfoPlanCta_padre.pc_Naturaleza;

                        var maxvalue = ListNivelCta.Max(x => x.IdNivelCta);

                        if ((Int32)maxvalue == InfoPlanCta_padre.IdNivelCta + 1)
                        { chk_es_cta_movi.Checked = true; }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
            }
        }

        Boolean Guardar()
        {
            try
            {
                Boolean Res = false;
                ct_Plancta_Info Cuenta= new ct_Plancta_Info();
                get_info();
                
                if(PlanCtaBus.ValidaIdCtaCble(InfoPlanCta.IdEmpresa, InfoPlanCta.IdCtaCble, ref MensajeError))
                {
                    InfoPlanCta_padre  = listPlanCta.FirstOrDefault(v => v.IdCtaCble == Convert.ToString(cmb_cuenta_padre.EditValue));
                    IdCbleHijo = PlanCtaBus.Get_Id(InfoPlanCta_padre.IdEmpresa, InfoPlanCta_padre.IdCtaCble, ref MensajeError);
                    InfoPlanCta.IdCtaCble = InfoPlanCta_padre.IdCtaCble + IdCbleHijo;
                }

                Res =PlanCtaBus.GrabarDB(InfoPlanCta, ref  MensajeError);

                if (Res)
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Cuenta Contable", InfoPlanCta.IdCtaCble + "-" + InfoPlanCta.pc_Cuenta);
                    MessageBox.Show(smensaje, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);


                    limpiar();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                    MessageBox.Show(MensajeError +" " + smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;               
            }

        }

        Boolean Actualizar()
        {
            try
            {
                Boolean Res = false;
                Res =PlanCtaBus.ModificarDB(InfoPlanCta, ref  MensajeError);

                if (Res)
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "la Cuenta ","");
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        limpiar();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return Res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }
        }

        Boolean grabar()
        {
            try
            {
                Boolean Res = false;
                
                get_info();


                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Res =Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Res =Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                         break;
                    default:
                        break;
                }

                return Res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;                
            }
        }

        public Boolean anular()
        {
            try
            {
                if (InfoPlanCta != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (InfoPlanCta.pc_Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular la cuenta " + InfoPlanCta.pc_Cuenta2, "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();
                            
                            InfoPlanCta.MotivoAnulacion = oFrm.motivoAnulacion;
                            InfoPlanCta.Fecha_UltAnu = param.Fecha_Transac;
                            InfoPlanCta.IdUsuarioUltAnu = param.IdUsuario;

                            if (PlanCtaBus.AnularDB(InfoPlanCta, ref msg))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La cuenta", InfoPlanCta.pc_Cuenta2);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                InfoPlanCta.pc_Estado = "I";
                                lblAnulado.Visible = true;
                                _Accion = Cl_Enumeradores.eTipo_action.consultar;
                                return true;
                            }
                            else 
                                return false;
                        }
                    }
                    else if (InfoPlanCta.pc_Estado == "I")
                    {
                        MessageBox.Show("No se puede anular la cuenta : " + InfoPlanCta.pc_Cuenta2 + ", ya se encuentra anulada", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void frmCon_PlanCuenta_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCon_PlanCuenta_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }            
        }

        private void cmb_nivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_formulario_tipo_gasto(Info.General.Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Grupo_x_tipo_gasto.EditValue == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;                    
                }
                
                info_grupo_x_tipo_gasto = list_grupo_x_tipo_gasto.FirstOrDefault(q => q.IdTipo_Gasto == Convert.ToInt32(cmb_Grupo_x_tipo_gasto.EditValue));

                if (info_grupo_x_tipo_gasto.estado==false)
                {
                    MessageBox.Show("El registro se encuentra anulado y no se puede modificar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Llamar_formulario_tipo_gasto(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Grupo_x_tipo_gasto.EditValue == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                info_grupo_x_tipo_gasto = list_grupo_x_tipo_gasto.FirstOrDefault(q => q.IdTipo_Gasto == Convert.ToInt32(cmb_Grupo_x_tipo_gasto.EditValue));
                Llamar_formulario_tipo_gasto(Info.General.Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void Llamar_formulario_tipo_gasto(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmCon_grupo_x_Tipo_Gasto_Mant frm_tipo_gasto = new frmCon_grupo_x_Tipo_Gasto_Mant();
                frm_tipo_gasto.Set_Accion(Accion);
                if (Accion!=Info.General.Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm_tipo_gasto.Set_info(info_grupo_x_tipo_gasto);
                }
                frm_tipo_gasto.ShowDialog();
                cargar_combo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btn_accion_tipo_gasto_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_accion.Show(this.btn_accion_tipo_gasto, new Point(0, btn_accion_tipo_gasto.Height));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
    }
}
