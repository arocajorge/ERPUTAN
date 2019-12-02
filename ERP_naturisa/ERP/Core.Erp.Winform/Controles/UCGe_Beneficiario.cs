using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Winform.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;


using Core.Erp.Winform.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;


using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;

using Core.Erp.Winform.General;



namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Beneficiario : UserControl
    {


        frmCP_Proveedor_Mant frmProvee;
        frmFa_Clientes_Mant frmCliente;
        frmGe_MantPersona frmPersona;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        tb_persona_tipo_Bus Bus_Tipo_Persona = new tb_persona_tipo_Bus();
        List<tb_persona_tipo_Info> list_Persona_Tipo = new List<tb_persona_tipo_Info>();
        List<vwtb_persona_beneficiario_Info> list_Beneficiario = new List<vwtb_persona_beneficiario_Info>();
        vwtb_persona_beneficiario_Info Info_Beneficiario = new vwtb_persona_beneficiario_Info();

        vwtb_persona_beneficiario_Bus Bus_Persona_Beneficiario = new vwtb_persona_beneficiario_Bus();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        private Cl_Enumeradores.eTipo_action _Accion;
        public Cl_Enumeradores.eTipoPersona IdTipo_Persona { get; set; }


       public  delegate void delegate_cmb_beneficiario_EditValueChanged(object sender, EventArgs e);
       public event delegate_cmb_beneficiario_EditValueChanged event_cmb_beneficiario_EditValueChanged;





        public UCGe_Beneficiario()
        {
            InitializeComponent();

            event_cmb_beneficiario_EditValueChanged += UCGe_Beneficiario_event_cmb_beneficiario_EditValueChanged;
                

        }

        void UCGe_Beneficiario_event_cmb_beneficiario_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        string STipo_Persona = "";

        private void Cargar_Combos()
        {
            try
            {
                

                list_Persona_Tipo = Bus_Tipo_Persona.Get_List_persona_tipo();
                list_Persona_Tipo.Add(new Info.General.tb_persona_tipo_Info("TODOS", "TODOS"));
                cmb_Persona_Tipo.Properties.DataSource = list_Persona_Tipo;
                cmb_Persona_Tipo.EditValue = IdTipo_Persona;

                if (IdTipo_Persona == 0)
                {  
                   IdTipo_Persona = Cl_Enumeradores.eTipoPersona.PROVEE;
                }



                if ((cmb_Persona_Tipo.EditValue.ToString() ?? "") != IdTipo_Persona.ToString() || list_Beneficiario.Count == 0)
                {
                    Cargar_combo_beneficiario();
                }

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_Beneficiario()
        {
            try
            {
                //cmb_Persona_Tipo.EditValue = null;
                cmb_beneficiario.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Tipo_Persona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Persona_Tipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Persona_Tipo.EditValue != null)
                {
                    string sIdTipo_Persona = Convert.ToString(cmb_Persona_Tipo.EditValue);
                    IdTipo_Persona = (Cl_Enumeradores.eTipoPersona)Enum.Parse(typeof(Cl_Enumeradores.eTipoPersona), sIdTipo_Persona);
                }
                else
                {
                    IdTipo_Persona = Info.General.Cl_Enumeradores.eTipoPersona.TODOS;
                }

                if ((cmb_Persona_Tipo.EditValue.ToString() ?? "") != IdTipo_Persona.ToString())
                {
                    Cargar_combo_beneficiario();    
                }
                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cargar_combo_beneficiario()
        {
            try
            {
                tb_persona_tipo_Info InfoPersona_Tipo = list_Persona_Tipo.FirstOrDefault(v => v.IdTipo_Persona == IdTipo_Persona.ToString());



                if (IdTipo_Persona == Info.General.Cl_Enumeradores.eTipoPersona.TODOS)
                {
                    List<Info.General.vwtb_persona_beneficiario_Info> LisBenefeciario= new List<Info.General.vwtb_persona_beneficiario_Info>();
                    Info.General.vwtb_persona_beneficiario_Info InfoBenefi= new Info.General.vwtb_persona_beneficiario_Info();
                    InfoBenefi.IdEmpresa = param.IdEmpresa;
                    InfoBenefi.IdBeneficiario = "TODOS-0-0";
                    InfoBenefi.IdPersona = 0;
                    InfoBenefi.IdTipo_Persona = "TODOS";
                    InfoBenefi.IdEntidad = 0;
                    InfoBenefi.Nombre = "TODOS";
                    InfoBenefi.NombreCompleto = "TODOS";
                    InfoBenefi.Estado = "A";
                    LisBenefeciario.Add(InfoBenefi);
                    list_Beneficiario = LisBenefeciario;
                }
                else
                {
                    list_Beneficiario = Bus_Persona_Beneficiario.Get_List_PersonaBeneficiario(param.IdEmpresa, IdTipo_Persona.ToString());
                }

                cmb_beneficiario.Properties.DataSource = list_Beneficiario;


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
        }

        private void UCGe_Beneficiario_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        public vwtb_persona_beneficiario_Info Get_Persona_beneficiario_Info()
        {
            try
            {
                vwtb_persona_beneficiario_Info Info_Beneficiario = new vwtb_persona_beneficiario_Info();
                if (cmb_beneficiario.EditValue != null)
                {
                    Info_Beneficiario = list_Beneficiario.FirstOrDefault(v => v.IdBeneficiario == Convert.ToString(cmb_beneficiario.EditValue));
                }
                return Info_Beneficiario;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new vwtb_persona_beneficiario_Info();
            }

        }

        public void set_Persona_beneficiario_Info(Cl_Enumeradores.eTipoPersona eTipo_Persona, decimal IdEntidad)
        {
            try
            {
                string sIdEntidad = "";
                cmb_Persona_Tipo.EditValue = eTipo_Persona.ToString();
                if (IdEntidad != 0)
                {
                    vwtb_persona_beneficiario_Info InfoPersona = list_Beneficiario.FirstOrDefault(v => v.IdTipo_Persona == eTipo_Persona.ToString() && v.IdEntidad == IdEntidad);

                    if (InfoPersona != null)
                    { sIdEntidad = InfoPersona.IdBeneficiario; }

                    cmb_beneficiario.EditValue = sIdEntidad;
                }
                else
                    cmb_beneficiario.EditValue = null;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void cmb_Acciones_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones.Show(cmb_Acciones, new Point(0, cmb_Acciones.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public cp_proveedor_Info Get_Info_Proveedor()
        {
            try
            {
                cp_proveedor_Info InfoProveedor= new cp_proveedor_Info();


                if (cmb_beneficiario.EditValue != null && IdTipo_Persona==Cl_Enumeradores.eTipoPersona.PROVEE)
                {
                    Info_Beneficiario = list_Beneficiario.FirstOrDefault(v => v.IdBeneficiario == Convert.ToString(cmb_beneficiario.EditValue));
                    cp_proveedor_Bus BusProvee = new cp_proveedor_Bus();
                    
                   InfoProveedor= BusProvee.Get_Info_Proveedor(param.IdEmpresa, Info_Beneficiario.IdEntidad);
                }



                return InfoProveedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new cp_proveedor_Info();
                
            }
        }

        public fa_Cliente_Info Get_Info_Cliente()
        {
            try
            {
                fa_Cliente_Info InfoCliente = new fa_Cliente_Info();


                if (cmb_beneficiario.EditValue != null && IdTipo_Persona == Cl_Enumeradores.eTipoPersona.CLIENTE)
                {
                    Info_Beneficiario = list_Beneficiario.FirstOrDefault(v => v.IdBeneficiario == Convert.ToString(cmb_beneficiario.EditValue));
                    fa_Cliente_Bus BusProvee = new fa_Cliente_Bus();

                    InfoCliente = BusProvee.Get_Info_Cliente(param.IdEmpresa, Info_Beneficiario.IdEntidad);
                }



                return InfoCliente;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_Cliente_Info();

            }
        }

        public ro_Empleado_Info Get_Info_Empleado()
        {
            try
            {
                ro_Empleado_Info InfoEmpleado = new ro_Empleado_Info();


                if (cmb_beneficiario.EditValue != null && IdTipo_Persona == Cl_Enumeradores.eTipoPersona.EMPLEA)
                {
                    Info_Beneficiario = list_Beneficiario.FirstOrDefault(v => v.IdBeneficiario == Convert.ToString(cmb_beneficiario.EditValue));
                    ro_Empleado_Bus BusProvee = new ro_Empleado_Bus();

                    InfoEmpleado = BusProvee.Get_Info_Empleado(param.IdEmpresa, Info_Beneficiario.IdEntidad);
                }



                return InfoEmpleado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ro_Empleado_Info();

            }
        }

        public tb_persona_Info Get_Info_Persona()
        {
            try
            {
                tb_persona_Info InfoPersona = new tb_persona_Info();


                if (cmb_beneficiario.EditValue != null && IdTipo_Persona == Cl_Enumeradores.eTipoPersona.PERSONA)
                {
                    Info_Beneficiario = list_Beneficiario.FirstOrDefault(v => v.IdBeneficiario == Convert.ToString(cmb_beneficiario.EditValue));
                    tb_persona_bus BusPersona = new tb_persona_bus();
                    InfoPersona = BusPersona.Get_Info_Persona(Info_Beneficiario.IdPersona);
                }

                return InfoPersona;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_persona_Info();

            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {

                if (IdTipo_Persona == Cl_Enumeradores.eTipoPersona.PROVEE)
                {
                    frmProvee = new frmCP_Proveedor_Mant();
                    frmProvee.event_frmCP_MantProveedor_FormClosing += frmProvee_event_frmCP_MantProveedor_FormClosing;
                    if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                    {
                        frmProvee.set_ProveedorInfo(Get_Info_Proveedor());
                        frmProvee.set_Accion(Accion);
                    }
                    else
                        frmProvee.set_Accion(Accion);

                    frmProvee.Show();

                }

                

                if (IdTipo_Persona == Cl_Enumeradores.eTipoPersona.CLIENTE)
                {
                    frmCliente = new frmFa_Clientes_Mant();
                    frmCliente.event_frmFA_Clientes_Mant_FormClosing += frmCliente_event_frmFA_Clientes_Mant_FormClosing;
                    if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                    {
                        frmCliente.set_Cliente(Get_Info_Cliente());
                        frmCliente.set_Accion(Accion);
                    }
                    else
                        frmCliente.set_Accion(Accion);

                    frmCliente.Show();

                }

                


                if (IdTipo_Persona == Cl_Enumeradores.eTipoPersona.PERSONA)
                {
                    frmPersona = new frmGe_MantPersona();
                    frmPersona.event_frmGe_MantPersona_FormClosing += frmPersona_event_frmGe_MantPersona_FormClosing;
                    if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                    {
                        frmPersona.set_Persona(Get_Info_Persona());
                        frmPersona.set_Accion(Accion);
                    }
                    else
                        frmPersona.set_Accion(Accion);

                    frmPersona.Show();

                }


                


                if (IdTipo_Persona == Cl_Enumeradores.eTipoPersona.EMPLEA)
                {
                 
                }



            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmEmpleado_event_frmRo_MantEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cargar_Combos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
                
            }
        }

        void frmPersona_event_frmGe_MantPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void frmCliente_event_frmFA_Clientes_Mant_FormClosing()
        {
            
        }

        void frmProvee_event_frmCP_MantProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_beneficiario_EditValueChanged(object sender, EventArgs e)
        {
            event_cmb_beneficiario_EditValueChanged(sender, e);
        }
    }
}
