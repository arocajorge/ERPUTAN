
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.IO;
using Core.Erp.Winform.Controles;
using System.Xml;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.SRI;
using Core.Erp.Business.SRI;
using System.Diagnostics;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Info.Roles_Fj;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Empleado_Mant : Form
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";

        private Cl_Enumeradores.eTipo_action _Accion;
        private Funciones func = new Funciones();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;

        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();
        ro_Empleado_Info infoEmpleado = new ro_Empleado_Info();
        List<tb_Sucursal_Info> sucursalInfo = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus sucursalBus = new tb_Sucursal_Bus();
        tb_persona_Info infoPersona = new tb_persona_Info();
        tb_persona_bus oTb_persona_bus = new tb_persona_bus();
        
        ro_Departamento_Info Info_departamento = new ro_Departamento_Info();
        ro_Departamento_Bus bus_depa = new ro_Departamento_Bus();

        ro_Empleado_TipoNomina_Info Info_TNomina = new ro_Empleado_TipoNomina_Info();
  
        // este catalogo viene de tb_catalogo es general por la persona
        UCGe_Catalogo UCCatalogo_EstadoCivil = new UCGe_Catalogo( ); 
        UCGe_Catalogo UCCatalogo_sexo = new UCGe_Catalogo(); 
        UCGe_Catalogo UCCatalogo_tipoDoc = new UCGe_Catalogo(); 
        UCGe_Catalogo UCCatalogo_SexoFamiliar = new UCGe_Catalogo();
        
        /*catalogos de roles */
        UCRo_Catalogo UCCatalogo_tipoSangreEmp = new UCRo_Catalogo();
        UCRo_Catalogo UCCatalogo_claseEmpleado = new UCRo_Catalogo();
        UCRo_Catalogo UCCatalogo_tipoCuentaEmp = new UCRo_Catalogo();
        UCRo_Catalogo UCCatalogo_tipoLicencia = new UCRo_Catalogo();

        /*catalogos de ro_depatamento */
        UCRo_Departamento UCRDep = new UCRo_Departamento();

        DataTable dt = new DataTable("detalle");

        Boolean Valido;

        Funciones funcion = new Funciones();

        //15112013 D CARGAR PDF
        OpenFileDialog ofdDoc;//PDF
        SaveFileDialog sfdDoc;//PDF        
        byte[] readBuffer;//PDF
        string borrar = "";
        //                

        public ro_Departamento_Info _dptInfoPadre { get; set; }

        //DELEGADO
        public delegate void delegate_frmRo_MantEmpleado_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_MantEmpleado_FormClosing event_frmRo_MantEmpleado_FormClosing;


        string fileName = "";
        string path = "";
        string tipofile = "";

        ro_DocumentoxEmp_Bus BusDoc = new ro_DocumentoxEmp_Bus();
        ro_DocumentoxEmp_Info InfoDoc = new ro_DocumentoxEmp_Info();

        int idDoc = 0;
        List<ro_DocumentoxEmp_Info> oListRo_DocumentoxEmp_InfoElim = new List<ro_DocumentoxEmp_Info>();

        ro_empleado_x_Proyeccion_Gastos_Personales_Info InfoGastosPersonales = new ro_empleado_x_Proyeccion_Gastos_Personales_Info();
        ro_CargaFamiliar_Info row = new ro_CargaFamiliar_Info();
        ro_empleado_x_titulos_Info row_tit = new ro_empleado_x_titulos_Info();

        #endregion

        #region Listas

        BindingList<ro_CargaFamiliar_Info> Obj_cafa = new BindingList<ro_CargaFamiliar_Info>();
        BindingList<ro_contrato_Info> obj_co = new BindingList<ro_contrato_Info>();
        BindingList<ro_empleado_x_titulos_Info> ro_Capacitaciones_x_Empleado_Info = new BindingList<ro_empleado_x_titulos_Info>();
        BindingList<ro_Empleado_estudios_Info> obj_estudios = new BindingList<ro_Empleado_estudios_Info>();
        BindingList<ro_empleado_x_ro_rubro_Info> obj_rubros = new BindingList<ro_empleado_x_ro_rubro_Info>();
        BindingList<ro_Nomina_Tipo_Info> obj_nomina = new BindingList<ro_Nomina_Tipo_Info>();
        BindingList<ro_empleado_x_titulos_Info> ListaBi;
        BindingList<ro_Capacitaciones_x_Empleado_Info> ListCapacitaciones = new BindingList<ro_Capacitaciones_x_Empleado_Info>();
        BindingList<ro_empleado_x_ro_rubro_Info> DataSourcce1;
        List<ct_Plancta_Info> listaPlan = new List<ct_Plancta_Info>();
        ct_Plancta_Bus _PlanCta_bus = new ct_Plancta_Bus();
        ro_empleado_x_Proyeccion_Gastos_Personales_Bus BusGastosPersonales = new ro_empleado_x_Proyeccion_Gastos_Personales_Bus();
        BindingList<ro_HistoricoSueldo_Info> ListHsueldo = new BindingList<ro_HistoricoSueldo_Info>();
        List<ro_tipo_gastos_personales_tabla_valores_x_anio_Info> LisValorGP_x_xAnio = new List<ro_tipo_gastos_personales_tabla_valores_x_anio_Info>();
        ro_tipo_gastos_personales_tabla_valores_x_anio_Bus BusValorGP_x_Anio = new ro_tipo_gastos_personales_tabla_valores_x_anio_Bus();
        //Derek 12/12/2013
        List<ro_division_Info> infoDivision = new List<ro_division_Info>();
        List<ro_area_Info> infoArea = new List<ro_area_Info>();
        ro_division_Bus busDivision = new ro_division_Bus();
        ro_area_Bus busArea = new ro_area_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> infoCCSCC = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus busCCSCC = new ct_centro_costo_sub_centro_costo_Bus();


        List<ro_Nomina_Tipo_Info> oListRo_Nomina_Tipo_Info = new List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> oListRo_Nomina_Tipoliqui_Info = new List<ro_Nomina_Tipoliqui_Info>();
        ro_Nomina_Tipoliqui_Bus oRo_Nomina_Tipoliqui_Bus = new ro_Nomina_Tipoliqui_Bus();
        List<ro_Empleado_Info> InfoSup = new List<ro_Empleado_Info>();
        List<ro_Departamento_Info> ListDepartamento = new List<ro_Departamento_Info>();

        List<ro_rubro_tipo_Info> oListRo_rubro_tipo_Info = new List<ro_rubro_tipo_Info>();
        ro_rubro_tipo_Bus oRo_rubro_tipo_Bus = new ro_rubro_tipo_Bus();
        List<ro_Catalogo_Info> oRo_EstadoEmpleado_Info = new List<ro_Catalogo_Info>();
        ro_Catalogo_Bus oRo_Catalogo_Bus = new ro_Catalogo_Bus();
        List<ro_Catalogo_Info> oListRo_CondicionDiscapacidad_Info = new List<ro_Catalogo_Info>();
        ro_Departamento_Bus BusDepartamento = new ro_Departamento_Bus();
        List<ro_Catalogo_Info> oListRo_TipoResidencia_Info = new List<ro_Catalogo_Info>();

        List<ro_Catalogo_Info> oListRo_AplicaConvenioDobleImposicion_Info = new List<ro_Catalogo_Info>();

        List<ro_Catalogo_Info> oListRo_TipoIdentDiscapacitadoSustituye_Info = new List<ro_Catalogo_Info>();

        List<ro_Catalogo_Info> oListRo_TipoSalarioNeto_Info = new List<ro_Catalogo_Info>();

        List<ro_Catalogo_Info> oListRo_TipoAnticipo_Info = new List<ro_Catalogo_Info>();


        List<tb_Calendario_Info> calenIRInfo = new List<tb_Calendario_Info>();
        tb_Calendario_Bus calenIRBus = new tb_Calendario_Bus();

        //año Proyeccion Gastos Personales 10/01/2014
        List<tb_Calendario_Info> calenPGPInfo = new List<tb_Calendario_Info>();
        tb_Calendario_Bus calenPGPBus = new tb_Calendario_Bus();

        //ro_tabla_impu_renta 10/01/2014
        BindingList<ro_tabla_Impu_Renta_Info> BLTablaImpuRenta = new BindingList<ro_tabla_Impu_Renta_Info>();
        ro_Tabla_Impu_Renta_Bus TablaImpuRentaBus = new ro_Tabla_Impu_Renta_Bus();

        ro_Catalogo_Bus bus_cat = new ro_Catalogo_Bus();
        //bindinglistProyeccion Gastos Personales 10/01/2014
        BindingList<ro_empleado_x_Proyeccion_Gastos_Personales_Info> BLPGP = new BindingList<ro_empleado_x_Proyeccion_Gastos_Personales_Info>();
        ro_empleado_x_Proyeccion_Gastos_Personales_Bus PGPBus = new ro_empleado_x_Proyeccion_Gastos_Personales_Bus();
        //

        //SRI Tipo Gasto 10/01/2014
        List<sri_tipo_Gasto_Info> LSRITipoGastoInfo = new List<sri_tipo_Gasto_Info>();
        sri_tipo_Gasto_Bus SriTipoGastoBus = new sri_tipo_Gasto_Bus();
        //


        //CONFIGURACION DE NOMINA X EMPLEADO
        BindingList<ro_Nomina_Tipo_Info> oBindingListRo_Nomina_Tipo_Info = new BindingList<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();

        ro_Empleado_TipoNomina_Bus oRo_Empleado_TipoNomina_Bus = new ro_Empleado_TipoNomina_Bus();
        List<ro_Empleado_TipoNomina_Info> oListRo_Empleado_TipoNomina_Info = new List<ro_Empleado_TipoNomina_Info>();



        //CONFIGRACION DE RUBROS ACUMULADOS
        BindingList<ro_ConfRubrosAcumulado_Info> oBindingListRo_ConfRubrosAcumulado_Info = new BindingList<ro_ConfRubrosAcumulado_Info>();
        BindingList<ro_ConfRubrosAcumulado_Info> oBindingListRo_ConfRubrosAcumulado = new BindingList<ro_ConfRubrosAcumulado_Info>();

        ro_ConfRubrosAcumulados_Bus oRo_ConfRubrosAcumulados_Bus = new ro_ConfRubrosAcumulados_Bus();

        //RUBROS ACUMULADOS X EMPLEADO
        List<ro_empleado_x_rubro_acumulado_Info> oListRo_empleado_x_rubro_acumulado_Info = new List<ro_empleado_x_rubro_acumulado_Info>();
        ro_empleado_x_rubro_acumulado_Bus oRo_empleado_x_rubro_acumulado_Bus = new ro_empleado_x_rubro_acumulado_Bus();

        //CENTRO DE COSTO X EMPLEADO
        List<ro_empleado_x_centro_costo_Info> oListRo_empleado_x_centro_costo_Info = new List<ro_empleado_x_centro_costo_Info>();
        ro_empleado_x_centro_costo_Bus oRo_empleado_x_centro_costo_Bus = new ro_empleado_x_centro_costo_Bus();
        
        //CENTRO DE COSTO DE CONTABILIDAD
        List<ct_Centro_costo_Info> oListCt_Centro_costo_Info = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus oCt_Centro_costo_Bus = new ct_Centro_costo_Bus();

        //DOCUMENTOS X EMPLEADO
        List<ro_DocumentoxEmp_Info> oListRo_DocumentoxEmp_Info = new List<ro_DocumentoxEmp_Info>();

        //CARGA FAMILIAR X EMPLEADO
        List<ro_CargaFamiliar_Info> oListRo_CargaFamiliar_Info = new List<ro_CargaFamiliar_Info>();

        //RUBROS FIJOS
        BindingList<ro_empleado_x_ro_rubro_Info> oBindingListRo_empleado_x_ro_rubro_Info = new BindingList<ro_empleado_x_ro_rubro_Info>();
        ro_empleado_x_ro_rubro_Bus oRo_empleado_x_ro_rubro_Bus = new ro_empleado_x_ro_rubro_Bus();

        //PGP
        BindingList<ro_empleado_x_Proyeccion_Gastos_Personales_Info> ListaGastosPersonales = new BindingList<ro_empleado_x_Proyeccion_Gastos_Personales_Info>();
        sri_tipo_Gasto_Bus oSri_tipo_Gasto_Bus = new sri_tipo_Gasto_Bus();

        //HORARIOS
        BindingList<ro_Horario_Info> oBindingListRo_Horario_Info = new BindingList<ro_Horario_Info>();
        ro_Horario_Bus oRo_Horario_Bus = new ro_Horario_Bus();

        //RUBROS ACUMULADOS X EMPLEADO
        List<ro_Empleado_X_Horario_Info> oListRo_Empleado_X_Horario_Info = new List<ro_Empleado_X_Horario_Info>();
        ro_Empleado_X_Horario_Bus oRo_Empleado_X_Horario_Bus = new ro_Empleado_X_Horario_Bus();

        // grupo por de empleados
        List<ro_Grupo_empleado_Info> lista_grupo = new List<ro_Grupo_empleado_Info>();
        ro_Grupo_empleado_Bus bus_grupo = new ro_Grupo_empleado_Bus();
        #endregion

        public frmRo_Empleado_Mant()
        {
            try
            {
                    InitializeComponent();
                    pu_IniciarControles();
                    pu_CargarCombos();
                    ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                    ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                    ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                    ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;

                    event_frmRo_MantEmpleado_FormClosing += frmRo_Empleado_Mant_event_frmRo_MantEmpleado_FormClosing;

                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

                  
        }


      void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (pu_Validar())
                {
                    this.ucGe_Menu_event_btnGuardar_Click(sender, e);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ver = "";
                string variable = (this.txt_cedulaRucEmpleado.Text).TrimEnd();
                decimal idEmpleado = 0;

              
             
              

                //VALIDACIONES
                if (pu_Validar())
                {
                    


                    //PERMITE GUARDAR LOS DATOS DEL EMPLEADO
                    if (pu_Grabar(ref idEmpleado))
                    {
                        txt_idEmpleado.Text = idEmpleado.ToString();
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Accion = Cl_Enumeradores.eTipo_action.grabar;
                        Limpiar();
                    }
                    else {
                        MessageBox.Show("Imposible guardar el registro, revise por favor", Resources.msgError_Grabar, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }



        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                getEmpleado();



                if (MessageBox.Show("Está seguro que desea anular el empleado...?", "ANULACION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    oFrm.ShowDialog();
                    infoEmpleado.MotivoAnulacion = oFrm.motivoAnulacion;

                    if (oRo_Empleado_Bus.AnularDB(infoEmpleado, ref msg))
                    {
                        MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chkEstado.Visible = true;
                    }
                    else {
                        MessageBox.Show("El registro no se pudo guardar, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
 
        }


        private void pu_IniciarControles()
        {
            try
            {

                UCCatalogo_EstadoCivil.set_cargar_combo_x_tipo(Cl_Enumeradores.TipoCatalogo.ESTCIVIL);
                this.panelEstadoCivil.Controls.Add(this.UCCatalogo_EstadoCivil);
                UCCatalogo_EstadoCivil.Dock = DockStyle.Fill;

                UCCatalogo_sexo.set_cargar_combo_x_tipo(Cl_Enumeradores.TipoCatalogo.SEXO);
                this.panelSexo.Controls.Add(this.UCCatalogo_sexo);
                this.UCCatalogo_sexo.Dock = DockStyle.Fill;

                UCCatalogo_tipoDoc.set_cargar_combo_x_tipo(Cl_Enumeradores.TipoCatalogo.TIPODOC);
                this.panelTipoDocumento.Controls.Add(this.UCCatalogo_tipoDoc);
                UCCatalogo_tipoDoc.Dock = DockStyle.Fill;

              
                UCCatalogo_claseEmpleado.set_cargar_combo_x_tipo(8);
                this.panelTipoEmp.Controls.Add(this.UCCatalogo_claseEmpleado);
                UCCatalogo_claseEmpleado.Dock = DockStyle.Fill;

                UCCatalogo_tipoCuentaEmp.set_cargar_combo_x_tipo(9);
                this.panel_TipoCta.Controls.Add(this.UCCatalogo_tipoCuentaEmp);
                UCCatalogo_tipoCuentaEmp.Dock = DockStyle.Fill;

                UCCatalogo_tipoSangreEmp.set_cargar_combo_x_tipo(7);
                this.panelTipoSangre.Controls.Add(this.UCCatalogo_tipoSangreEmp);
                UCCatalogo_tipoSangreEmp.Dock = DockStyle.Fill;

                UCCatalogo_tipoLicencia.set_cargar_combo_x_tipo(10);
                this.txtTipoLic.Controls.Add(this.UCCatalogo_tipoLicencia);
                UCCatalogo_tipoLicencia.Dock = DockStyle.Fill;

                UCRDep.set_Treelist_SelectMultiple(false);
                UCRDep.TreeListDepartamento.OptionsSelection.MultiSelect = false;
                UCRDep._Solo_chequea_unItem = true;
                UCRDep.Dock = DockStyle.Fill;

                UCRDep.ExpandAll();

                tb_Catalogo_Bus busCatalogo = new tb_Catalogo_Bus();
                List<tb_Catalogo_Info> listadosexoCargaFam = new List<tb_Catalogo_Info>();
                listadosexoCargaFam = busCatalogo.Get_List_Catalogo(Cl_Enumeradores.TipoCatalogo.SEXO);
                cmbSexoCargasFam.DataSource = listadosexoCargaFam; 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
             }

        }

        private void pu_CargarCombos()
        {
            try
            {
                ListDepartamento = BusDepartamento.Get_List_Departamento(param.IdEmpresa);
                cmbDepartamento.Properties.DataSource = ListDepartamento;


                string MensajeError = "";

                 //Cargar año Fiscal imp.Renta
                calenIRInfo = new List<tb_Calendario_Info>();
                calenIRInfo.Add(new tb_Calendario_Info());
                calenIRInfo.AddRange(calenIRBus.ConsultaGeneralGP());
              //  cmbAñoIR.Properties.DataSource = calenIRInfo;

                //Cargar año Fiscal Proyeccion Gastos Personales
                calenPGPInfo = new List<tb_Calendario_Info>();
                calenPGPInfo.Add(new tb_Calendario_Info());
                calenPGPInfo.AddRange(calenIRBus.ConsultaGeneralGP());
             //   cmbAnioFiscalPGP.Properties.DataSource = calenPGPInfo;

                //Carga combo Sucursal

                sucursalInfo = sucursalBus.Get_List_Sucursal(param.IdEmpresa);
                this.cmb_sucursal.Properties.DataSource = sucursalInfo;
                //this.cmb_sucursal.DisplayMember = "Su_Descripcion";
                //this.cmb_sucursal.ValueMember = "IdSucursal";
            
                //Carga combo Nacionalidad
                ucGe_PaisProvinciaCiudad.CargarComboPais();        

                //Cargo Cuenta Contable

                listaPlan = _PlanCta_bus.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                cmb_ctacbleCxp.Properties.DataSource = listaPlan;



                //Carga combo Supervisor
                InfoSup = oRo_Empleado_Bus.Get_List_Empleado_ (param.IdEmpresa);
                cmb_supervisor.Properties.DataSource = InfoSup;

                
                // Cargando combo Bancos
                tb_banco_Bus oTb_banco_Bus = new tb_banco_Bus();
                var lstBanco = oTb_banco_Bus.Get_List_Banco();
                 this.cmbBanco.Properties.DataSource = lstBanco;
                



                //Carga combo departamento
                List<ro_Departamento_Info> depaInfo = new List<ro_Departamento_Info>();
                ro_Departamento_Bus depaBus = new ro_Departamento_Bus();
                depaInfo = depaBus.Get_List_Departamento(param.IdEmpresa);

                //Carga datos en la grilla de familiares
                repositoryParentezco.DataSource = bus_cat.Get_List_Catalogo_x_Tipo(3);
                repositoryInstitucion_es.DataSource = bus_cat.Get_List_Catalogo_x_Tipo(5);
                repositoryInstitucion.DataSource = bus_cat.Get_List_Catalogo_x_Tipo(5);
                repositoryEstudios.DataSource = bus_cat.Get_List_Catalogo_x_Tipo(6);
                repositoryTitulo_em.DataSource = bus_cat.Get_List_Catalogo_x_Tipo(4);

                //Carga datos combo division
                infoDivision.Add(new ro_division_Info());
                infoDivision.AddRange(busDivision.ConsultaGeneral(param.IdEmpresa));
                cmbDivision.Properties.DataSource = infoDivision;

                infoArea.Add(new ro_area_Info());
                infoArea.AddRange(busArea.ConsultaGeneral(param.IdEmpresa));
                cmbArea.Properties.DataSource = infoArea;

                //Carga datos combo centro_costo_sub_centro_costo
                infoCCSCC.Add(new ct_centro_costo_sub_centro_costo_Info());
                infoCCSCC.AddRange(busCCSCC.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa));
                //cmbSubCentroCosto.Properties.DataSource = infoCCSCC;


                //CARGAR LOS RUBROS ACUMULADOS


                //CARGAR LOS HORARIOS
                oBindingListRo_Horario_Info = new BindingList<ro_Horario_Info>(oRo_Horario_Bus.Get_List_Horario(param.IdEmpresa));
                gridHorario.DataSource = oBindingListRo_Horario_Info;
            
                
                //CARGAR TIPO DE NOMINA
                oBindingListRo_Nomina_Tipo_Info = new BindingList<ro_Nomina_Tipo_Info>(oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa));
                gridCtrlNomina.DataSource = oBindingListRo_Nomina_Tipo_Info;


                //CARGAR CENTRO DE COSTO EN LA GRILLA
              
                //CARGAR COMBO NOMINA TIPO - RUBROS FIJOS


                oListRo_Nomina_Tipo_Info = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbNomina.DataSource = oListRo_Nomina_Tipo_Info;
                cmbNomina.DisplayMember = "Descripcion";
                cmbNomina.ValueMember = "IdNomina_Tipo";



                oListRo_Nomina_Tipoliqui_Info = oRo_Nomina_Tipoliqui_Bus.Get_List_Nomina_Tipoliqui(param.IdEmpresa);
                cmbNominaLiqui.DataSource = oListRo_Nomina_Tipoliqui_Info;
                cmbNominaLiqui.DisplayMember = "DescripcionProcesoNomina";
                cmbNominaLiqui.ValueMember = "IdNomina_TipoLiqui";


                cmbCentroCosto1.DataSource = oListCt_Centro_costo_Info;
                cmbCentroCosto1.DisplayMember = "Centro_costo";
                cmbCentroCosto1.ValueMember = "IdCentroCosto";



                oListRo_rubro_tipo_Info = oRo_rubro_tipo_Bus.Get_List_Formulas(param.IdEmpresa).Where(v=>v.rub_concep==true).ToList();

                cmbRubro1.DataSource = oListRo_rubro_tipo_Info;
                cmbRubro1.DisplayMember = "ru_descripcion";
                cmbRubro1.ValueMember = "IdRubro";

                cmbRubro.Properties.DataSource = oListRo_rubro_tipo_Info;
                cmbRubro.Properties.DisplayMember = "ru_descripcion";
                cmbRubro.Properties.ValueMember = "IdRubro";


                //LLENA EL COMBO - STATUS DEL EMPLEADO


                oRo_EstadoEmpleado_Info.AddRange(oRo_Catalogo_Bus.Get_List_Catalogo_x_Tipo(25));
                cmbStatus.Properties.ValueMember = "CodCatalogo";
                cmbStatus.Properties.DisplayMember = "ca_descripcion";
                cmbStatus.Properties.DataSource = oRo_EstadoEmpleado_Info;

                //LLENA EL COMBO - CONDICION EMPLEADO CON DISCAPACIDAD
                oListRo_CondicionDiscapacidad_Info.AddRange(oRo_Catalogo_Bus.Get_List_Catalogo_x_Tipo(26));
                cmbCondicionDiscapacidad.Properties.ValueMember = "CodCatalogo";
                cmbCondicionDiscapacidad.Properties.DisplayMember = "ca_descripcion";
                cmbCondicionDiscapacidad.Properties.DataSource = oListRo_CondicionDiscapacidad_Info;

                //LLENA EL COMBO -TIPO DE RESIDENCIA
                oListRo_TipoResidencia_Info.AddRange(oRo_Catalogo_Bus.Get_List_Catalogo_x_Tipo(27));
                cmbTipoResidencia.Properties.ValueMember = "CodCatalogo";
                cmbTipoResidencia.Properties.DisplayMember = "ca_descripcion";
                cmbTipoResidencia.Properties.DataSource = oListRo_TipoResidencia_Info;

                //LLENA EL COMBO -APLICA CONVENIO DOBLE IMPOSICION
                oListRo_AplicaConvenioDobleImposicion_Info.AddRange(oRo_Catalogo_Bus.Get_List_Catalogo_x_Tipo(28));
                cmbAplicaConvenioDobleImposicion.Properties.ValueMember = "CodCatalogo";
                cmbAplicaConvenioDobleImposicion.Properties.DisplayMember = "ca_descripcion";
                cmbAplicaConvenioDobleImposicion.Properties.DataSource = oListRo_AplicaConvenioDobleImposicion_Info;

                //LLENA EL COMBO - TIPO IDENTIFICACION DISCAPACITADO SUSTITUYE
                oListRo_TipoIdentDiscapacitadoSustituye_Info.AddRange(oRo_Catalogo_Bus.Get_List_Catalogo_x_Tipo(29));
                cmbTipoIdentificacionDiscapacitadoSustituye.Properties.ValueMember = "CodCatalogo";
                cmbTipoIdentificacionDiscapacitadoSustituye.Properties.DisplayMember = "ca_descripcion";
                cmbTipoIdentificacionDiscapacitadoSustituye.Properties.DataSource = oListRo_TipoIdentDiscapacitadoSustituye_Info;

                //LLENA EL COMBO -TIPO DE SISTEMA SALARIO NETO
                oListRo_TipoSalarioNeto_Info.AddRange(oRo_Catalogo_Bus.Get_List_Catalogo_x_Tipo(30));
                cmbTipoSistemaSalarioNeto.Properties.ValueMember = "CodCatalogo";
                cmbTipoSistemaSalarioNeto.Properties.DisplayMember = "ca_descripcion";
                cmbTipoSistemaSalarioNeto.Properties.DataSource = oListRo_TipoSalarioNeto_Info;

                //LLENA EL COMBO -TIPO ANTICIPO
                oListRo_TipoAnticipo_Info.AddRange(oRo_Catalogo_Bus.Get_List_Catalogo_x_Tipo(32));
                cmbTipoAnticipo.Properties.ValueMember = "CodCatalogo";
                cmbTipoAnticipo.Properties.DisplayMember = "ca_descripcion";
                cmbTipoAnticipo.Properties.DataSource = oListRo_TipoAnticipo_Info;
                // lleno el combro de grupos de empleado

                lista_grupo = bus_grupo.listado_Grupos(param.IdEmpresa);
                cmb_grupo.Properties.DataSource = lista_grupo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.Message);
            }
                    
        }

     

#region DETALLES DEL EMPLEADO

        private Boolean pu_GetEmpleadoDetalle() {
            try {
                infoEmpleado.oListRo_empleado_x_Proyeccion_Gastos_Personales_Info = new List<ro_empleado_x_Proyeccion_Gastos_Personales_Info>();
                Boolean valorRetornar = false;

                if(infoEmpleado!=null){

                    //DOCUMENTOS
                    oListRo_DocumentoxEmp_Info = (List<ro_DocumentoxEmp_Info>)gridCtrlDocumento.DataSource;

                    if (oListRo_DocumentoxEmp_Info!=null) 
                    {
                        foreach (var item in oListRo_DocumentoxEmp_Info)
                        {
                            if (item.check == true)
                            {
                                item.IdEmpresa = infoEmpleado.IdEmpresa;
                                item.IdEmpleado = infoEmpleado.IdEmpleado;
                                infoEmpleado.oListRo_DocumentoxEmp_Info.Add(item);
                            }
                        }
                       
                     }
                    //CARGAS FAMILIARES

                    BindingList<ro_CargaFamiliar_Info> oBindingListRo_CargaFamiliar_Info = (BindingList<ro_CargaFamiliar_Info>)gridCargaFam.DataSource;
                    //oListRo_CargaFamiliar_Info = (BindingList<ro_CargaFamiliar_Info>)gridCargaFam.DataSource;
                    foreach (ro_CargaFamiliar_Info oRro_CargaFamiliar_Info in oBindingListRo_CargaFamiliar_Info)
                    {
                        oRro_CargaFamiliar_Info.IdEmpresa = infoEmpleado.IdEmpresa;
                        oRro_CargaFamiliar_Info.IdEmpleado = infoEmpleado.IdEmpleado;
                        infoEmpleado.oListRo_CargaFamiliar_Info.Add(oRro_CargaFamiliar_Info);
                    }


                    //TITULOS
                    BindingList<ro_empleado_x_titulos_Info> oBindingListRo_empleado_x_titulos_Info = (BindingList<ro_empleado_x_titulos_Info>)gridTitulo.DataSource;

                   //List<ro_empleado_x_titulos_Info> oListRo_empleado_x_titulos_Info = new List<ro_empleado_x_titulos_Info>();
                    //oListRo_empleado_x_titulos_Info = (List<ro_empleado_x_titulos_Info>)gridTitulo.DataSource;
                    foreach (ro_empleado_x_titulos_Info oRo_empleado_x_titulos_Info in oBindingListRo_empleado_x_titulos_Info)
                    {
                        oRo_empleado_x_titulos_Info.IdEmpresa = infoEmpleado.IdEmpresa;
                        oRo_empleado_x_titulos_Info.IdEmpleado = infoEmpleado.IdEmpleado;
                        infoEmpleado.oListRo_empleado_x_titulos_Info.Add(oRo_empleado_x_titulos_Info);
                    }

                    //ESTUDIOS
                    BindingList<ro_Empleado_estudios_Info> oBindingListRo_Empleado_estudios_Info = (BindingList<ro_Empleado_estudios_Info>)gridEstudios.DataSource;

                    //List<ro_Empleado_estudios_Info> oListRo_Empleado_estudios_Info = new List<ro_Empleado_estudios_Info>();
                    //oListRo_Empleado_estudios_Info = (List<ro_Empleado_estudios_Info>)gridEstudios.DataSource;

                    foreach (ro_Empleado_estudios_Info oRo_Empleado_estudios_Info in oBindingListRo_Empleado_estudios_Info)
                    {
                        oRo_Empleado_estudios_Info.IdEmpresa = infoEmpleado.IdEmpresa;
                        oRo_Empleado_estudios_Info.IdEmpleado = infoEmpleado.IdEmpleado;
                        infoEmpleado.oListRo_Empleado_estudios_Info.Add(oRo_Empleado_estudios_Info);
                    }

                    //PROYECCION GASTOS PERSONALES
                    List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> oListRo_empleado_x_Proyeccion_Gastos_Personales_Info = new List<ro_empleado_x_Proyeccion_Gastos_Personales_Info>();
                    infoEmpleado.oListRo_empleado_x_Proyeccion_Gastos_Personales_Info.Clear();

                    foreach (var item in ListaGastosPersonales)
                    {
                        ro_empleado_x_Proyeccion_Gastos_Personales_Info oRo_empleado_x_Proyeccion_Gastos_Personales_Info = new ro_empleado_x_Proyeccion_Gastos_Personales_Info();
                        oRo_empleado_x_Proyeccion_Gastos_Personales_Info.IdEmpresa = infoEmpleado.IdEmpresa;
                        oRo_empleado_x_Proyeccion_Gastos_Personales_Info.IdEmpleado = infoEmpleado.IdEmpleado;
                        oRo_empleado_x_Proyeccion_Gastos_Personales_Info.AnioFiscal = item.AnioFiscal;
                        oRo_empleado_x_Proyeccion_Gastos_Personales_Info.IdTipoGasto = item.IdTipoGasto;
                        oRo_empleado_x_Proyeccion_Gastos_Personales_Info.Valor = item.Valor;
                        if (item.Valor > item.Monto_max)
                        {
                            oRo_empleado_x_Proyeccion_Gastos_Personales_Info.Valor = item.Monto_max;
                        }
                        infoEmpleado.oListRo_empleado_x_Proyeccion_Gastos_Personales_Info.Add(oRo_empleado_x_Proyeccion_Gastos_Personales_Info);
                        gridPGP.RefreshDataSource();
                    }
                   


                    //RUBROS ACUMULADOS
                    oListRo_empleado_x_rubro_acumulado_Info = new List<ro_empleado_x_rubro_acumulado_Info>();
                    oListRo_empleado_x_rubro_acumulado_Info.Clear();


                    foreach (ro_ConfRubrosAcumulado_Info item in oBindingListRo_ConfRubrosAcumulado)
                    {
                       // oBindingListRo_ConfRubrosAcumulado
                        
                            if (item.Ckeck == true )
                            {

                                ro_empleado_x_rubro_acumulado_Info oRo_empleado_x_rubro_acumulado_Info = new ro_empleado_x_rubro_acumulado_Info();
                                oRo_empleado_x_rubro_acumulado_Info.IdEmpresa = infoEmpleado.IdEmpresa;
                                oRo_empleado_x_rubro_acumulado_Info.IdEmpleado = infoEmpleado.IdEmpleado;
                                oRo_empleado_x_rubro_acumulado_Info.IdRubro = item.IdRubro;
                                oRo_empleado_x_rubro_acumulado_Info.FechaIngresa = param.Fecha_Transac;
                                oRo_empleado_x_rubro_acumulado_Info.UsuarioIngresa = param.IdUsuario;
                                oRo_empleado_x_rubro_acumulado_Info.Fec_Inicio_Acumulacion = item.FechaInicio;
                                oRo_empleado_x_rubro_acumulado_Info.Fec_Fin_Acumulacion = item.FechaFin;

                                infoEmpleado.oListRo_empleado_x_rubro_acumulado_Info.Add(oRo_empleado_x_rubro_acumulado_Info);
                               
                            }
                            
                        
                           
 
                        
                    }


                    //CENTROS DE COSTO DEL EMPLEADO
                    oListRo_empleado_x_centro_costo_Info = new List<ro_empleado_x_centro_costo_Info>();
                    oListRo_empleado_x_centro_costo_Info.Clear();

                    if (cmb_centroCosto.get_item() != null && cmb_subcentro.get_item() != "")
                    {
                               
                         
                         ro_empleado_x_centro_costo_Info oRo_empleado_x_centro_costo_Info = new ro_empleado_x_centro_costo_Info();

                                oRo_empleado_x_centro_costo_Info.IdEmpresa = infoEmpleado.IdEmpresa;
                                oRo_empleado_x_centro_costo_Info.IdEmpleado = infoEmpleado.IdEmpleado;
                                oRo_empleado_x_centro_costo_Info.IdCentroCosto = cmb_centroCosto.get_item();
                              //  oRo_empleado_x_centro_costo_Info.IdCentroCosto_sub_centro_costo = uCct_CentroCosto1.Get_IdSubCentro_Costo();

                                oRo_empleado_x_centro_costo_Info.FechaIngresa = param.Fecha_Transac;
                                oRo_empleado_x_centro_costo_Info.UsuarioIngresa = param.IdUsuario;
                                infoEmpleado.oListro_empleado_x_centro_costo_Info.Add(oRo_empleado_x_centro_costo_Info);
                           
                    }




                    //NOMINA X EMPLEADO
                    BindingList<ro_Nomina_Tipo_Info> BindingListRo_Nomina_Tipo_Info = (BindingList<ro_Nomina_Tipo_Info>)gridCtrlNomina.DataSource;

                    if (BindingListRo_Nomina_Tipo_Info.Count > 0)
                    {
                        foreach (ro_Nomina_Tipo_Info item in BindingListRo_Nomina_Tipo_Info)
                        {
                            if (item.check)
                            {
                                ro_Empleado_TipoNomina_Info oRo_Empleado_TipoNomina_Info = new ro_Empleado_TipoNomina_Info();

                                oRo_Empleado_TipoNomina_Info.IdEmpresa = item.IdEmpresa;
                                oRo_Empleado_TipoNomina_Info.IdEmpleado = infoEmpleado.IdEmpleado;
                                oRo_Empleado_TipoNomina_Info.IdNomina_Tipo = item.IdNomina_Tipo;
                                oRo_Empleado_TipoNomina_Info.Descripcion = "";
                                infoEmpleado.oListRo_Empleado_TipoNomina_Info.Add(oRo_Empleado_TipoNomina_Info);
                            }
                        }
                    }




                    BindingList<ro_empleado_x_ro_rubro_Info> oBindingListRo_empleado_x_ro_rubro_Info = (BindingList<ro_empleado_x_ro_rubro_Info>)gridControlRubro.DataSource;

                    //if (oBindingListRo_empleado_x_ro_rubro_Info.Count > 0)
                    //{

                        //ELIMINAR RUBROS FIJOS PREVIOS
                    oRo_empleado_x_ro_rubro_Bus.EliminarBD(infoEmpleado.IdEmpresa, infoEmpleado.IdEmpleado, ref MensajeError);

                        foreach (ro_empleado_x_ro_rubro_Info item in oBindingListRo_empleado_x_ro_rubro_Info)
                        {
                            if (item.Valor > 0)
                            {
                                ro_empleado_x_ro_rubro_Info oRo_empleado_x_ro_rubro_Info = new ro_empleado_x_ro_rubro_Info();

                                oRo_empleado_x_ro_rubro_Info.IdEmpresa = item.IdEmpresa;
                                oRo_empleado_x_ro_rubro_Info.IdNomina_Tipo = item.IdNomina_Tipo;
                                oRo_empleado_x_ro_rubro_Info.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                                oRo_empleado_x_ro_rubro_Info.IdEmpleado = item.IdEmpleado;
                                oRo_empleado_x_ro_rubro_Info.IdRubro = item.IdRubro;
                                oRo_empleado_x_ro_rubro_Info.IdCentroCosto = item.IdCentroCosto;
                                oRo_empleado_x_ro_rubro_Info.Valor = item.Valor;

                                infoEmpleado.oListRo_empleado_x_ro_rubro_Info.Add(oRo_empleado_x_ro_rubro_Info);
                            }
                        }
                    //}


                    //HORARIOS
                    foreach (ro_Horario_Info item in oBindingListRo_Horario_Info)
                    {

                        if (item.Check)
                        {
                            ro_Empleado_X_Horario_Info oRo_Empleado_X_Horario_Info = new ro_Empleado_X_Horario_Info();

                            oRo_Empleado_X_Horario_Info.IdEmpresa = infoEmpleado.IdEmpresa;
                            oRo_Empleado_X_Horario_Info.IdEmpleado = infoEmpleado.IdEmpleado;
                            oRo_Empleado_X_Horario_Info.IdHorario = item.IdHorario;
                            oRo_Empleado_X_Horario_Info.EsPredeterminado= item.CheckDefault;

                            infoEmpleado.oListRo_Empleado_X_Horario_Info.Add(oRo_Empleado_X_Horario_Info);

                        }
                    }


                    // sueldo

                    if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (ListHsueldo.Count() == 0)
                        {
                            MessageBox.Show("Ingrese sueldo actual Para el empleado");
                            return false;
                        }
                        

                        foreach (var item in ListHsueldo)
                        {
                            if (item.SueldoActual > 0)
                            {
                                item.Fecha = dtp_FechaIngresoIESS.Value;
                                item.Fecha_Transac = DateTime.Now;
                                item.IdEmpresa = param.IdEmpresa;
                                item.Secuencia = 1;
                                item.idUsuario = param.IdUsuario;
                                item.SueldoAnterior = 0;
                                item.PorIncrementoSueldo = 0;
                                item.ValorIncrementoSueldo = 0;
                                item.Motivo = "Sueldo inicual";
                                infoEmpleado.InfoSueldo = item;
                                break;
                            }

                        }


                        if (infoEmpleado.InfoSueldo.SueldoActual == 0)
                        {
                            MessageBox.Show("Ingrese sueldo actual Para el empleado");
                            return false;
                        }
                    }
                    valorRetornar = true;
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            return false;
            }
        }

#endregion

        public Boolean getEmpleado()
        {
            try
            {
                Boolean valorRetornar = false;

                tb_Catalogo_Bus busCatalog = new tb_Catalogo_Bus();

                List<tb_Catalogo_Info> ListNat = new List<tb_Catalogo_Info>();

                /*datos de persona*/
                #region DATOS DE PERSONA

                infoEmpleado = new ro_Empleado_Info();

                infoEmpleado.InfoPersona.IdPersona = Convert.ToDecimal((txtIdPersona.Text == "") ? "0" : txtIdPersona.Text.Trim());
                infoEmpleado.InfoPersona.CodPersona = null;
                ListNat = busCatalog.Get_List_Catalogo(Cl_Enumeradores.TipoCatalogo.TIPONATPER);
                infoEmpleado.InfoPersona.pe_Naturaleza = ListNat[0].CodCatalogo; //QUEMADO: NATU
                infoEmpleado.InfoPersona.pe_nombreCompleto = txtApellido.Text.Trim() + txt_nombresEmpleado.Text.Trim();
                infoEmpleado.InfoPersona.pe_apellido = txtApellido.Text.Trim();
                infoEmpleado.InfoPersona.pe_nombre = txt_nombresEmpleado.Text.Trim();
                infoEmpleado.InfoPersona.IdTipoPersona = 4; // tb_PersonaTipo = 4 (TIPO: EMPLEADO)
                infoEmpleado.InfoPersona.pe_cedulaRuc = txt_cedulaRucEmpleado.Text.Trim();
                infoEmpleado.InfoPersona.pe_direccion = txt_Direccion.Text.Trim();
                infoEmpleado.InfoPersona.pe_telfono_Contacto = txt_telefono.Text.Trim();
                infoEmpleado.InfoPersona.pe_celular = txt_celular.Text.Trim();
                infoEmpleado.InfoPersona.pe_correo = textEmail.Text.Trim();
                infoEmpleado.InfoPersona.pe_fechaNacimiento = dtp_fechaNacimiento.Value;
                infoEmpleado.InfoPersona.pe_estado = "A";

                //VALIDACIONES DEBEN ESTAR EN OTRA FUNCION
                if ((tb_Catalogo_Info)UCCatalogo_tipoDoc.cmb_catalogo.SelectedItem != null)
                    infoEmpleado.InfoPersona.IdTipoDocumento = this.UCCatalogo_tipoDoc.get_Catalogo().CodCatalogo;

                if ((tb_Catalogo_Info)UCCatalogo_sexo.cmb_catalogo.SelectedItem != null)
                    infoEmpleado.InfoPersona.pe_sexo = this.UCCatalogo_sexo.get_Catalogo().CodCatalogo;

                if ((tb_Catalogo_Info)UCCatalogo_EstadoCivil.cmb_catalogo.SelectedItem != null)
                    infoEmpleado.InfoPersona.IdEstadoCivil = UCCatalogo_EstadoCivil.get_Catalogo().CodCatalogo;

                #endregion



                #region DATOS DEL EMPLEADO
                infoEmpleado.IdEmpresa = param.IdEmpresa;
                infoEmpleado.IdEmpleado = Convert.ToInt32((txt_idEmpleado.Text == "") ? "0" : txt_idEmpleado.Text.Trim());
                infoEmpleado.IdPersona = Convert.ToDecimal((txtIdPersona.Text == "") ? "0" : txtIdPersona.Text.Trim());
                infoEmpleado.IdSucursal = Convert.ToInt32(cmb_sucursal.EditValue);
                infoEmpleado.IdTipoEmpleado = this.UCCatalogo_claseEmpleado.get_Catalogo().CodCatalogo;
                infoEmpleado.em_codigo = Convert.ToString((txt_codigoEmpleado.Text == "" ? "" : txt_codigoEmpleado.Text).Trim());
                infoEmpleado.em_lugarNacimiento = txt_lugarNacimiento.Text.Trim();
                infoEmpleado.CodigoSectorialIESS = txtCodigoSectorial.Text.Trim();
                infoEmpleado.em_cedulaMil = txt_cedulaMilitar.Text.Trim();
                infoEmpleado.por_discapacidad = Convert.ToDouble((txt_porcdisc.Text == "") ? "0" : txt_porcdisc.Text.Trim());
                infoEmpleado.carnet_conadis = txt_carnetconds.Text.Trim();
                infoEmpleado.recibi_uniforme = (chk_uniforme.Checked == true) ? "S" : "N";
                infoEmpleado.talla_camisa = txt_camisa.Text.Trim();
                infoEmpleado.talla_pant = Convert.ToDouble((txt_pant.Text == "") ? "0" : txt_pant.Text.Trim());
                infoEmpleado.talla_zapato = Convert.ToDouble((txt_zapato.Text == "") ? "0" : txt_zapato.Text.Trim());
                infoEmpleado.em_SeAcreditaBanco = (chk_acredita.Checked == true) ? "S" : "N";
                infoEmpleado.em_NumCta = txt_numeroCuenta.Text.Trim();
                infoEmpleado.em_empEspecial = (chk_empleadoEspecial.Checked == true) ? "S" : "N";
                infoEmpleado.es_AcreditaHorasExtras = chkAcreditaHorasExtras.Checked;
                infoEmpleado.em_huella = null;
                infoEmpleado.em_mail = textEmail.Text.Trim();
               
                infoEmpleado.em_estado = (chkEstado.Checked == true) ? "A" : "I";
                infoEmpleado.em_status = cmbStatus.EditValue.ToString();

              
                //ANTICIPO
                if (cmbTipoAnticipo.EditValue != null)
                    infoEmpleado.IdTipoAnticipo = cmbTipoAnticipo.EditValue.ToString();

                infoEmpleado.em_AnticipoSueldo = Convert.ToDouble((txtValorAnticipo.Text == "") ? "0" : txtValorAnticipo.Text.Trim());
                infoEmpleado.es_TruncarDecimalAnticipo = chkTruncarDecimales.Checked;
                


                //VALIDACIONES DEBEN ESTAR EN OTRA FUNCION
                if (cmbDivision.EditValue == null || cmbDivision.EditValue.ToString() == "")
                {
                    infoEmpleado.IdDivision = null;
                }
                else
                {
                    infoEmpleado.IdDivision = Convert.ToInt32(cmbDivision.EditValue);
                }

                if (cmbArea.EditValue == null || cmbArea.EditValue.ToString() == "")
                {
                    infoEmpleado.IdArea = null;
                }
                else
                {
                    infoEmpleado.IdArea = Convert.ToInt32(cmbArea.EditValue);
                }


                if (cmb_supervisor.EditValue == null || cmb_supervisor.EditValue == "")
                    infoEmpleado.IdEmpleado_Supervisor = null;
                else
                    infoEmpleado.IdEmpleado_Supervisor = (decimal)(cmb_supervisor.EditValue);

                /*fechas*/
               
                if (dtp_fechaSalida.Checked == true)
                { infoEmpleado.em_fechaSalida = dtp_fechaSalida.Value; }
                else infoEmpleado.em_fechaSalida = null;

                if (dtp_fechaTerminoContrato.Checked == true)
                { infoEmpleado.em_fechaTerminoContra = dtp_fechaTerminoContrato.Value; }
                else infoEmpleado.em_fechaTerminoContra = null;

                if (dtp_FechaIngresoIESS.Checked == true)
                { infoEmpleado.em_fechaIngaRol = dtp_FechaIngresoIESS.Value; }
                else infoEmpleado.em_fechaIngaRol = null;

                if ((ro_Catalogo_Info)UCCatalogo_tipoCuentaEmp.cmb_catalogo.SelectedItem != null)
                    infoEmpleado.em_tipoCta = this.UCCatalogo_tipoCuentaEmp.get_Catalogo().CodCatalogo;

                if (pic_foto.Image == null)
                { infoEmpleado.em_foto = null; }
                else infoEmpleado.em_foto = Funciones.ImageAArray(pic_foto.Image);

                if ((ro_Catalogo_Info)UCCatalogo_tipoSangreEmp.cmb_catalogo.SelectedItem != null)
                    infoEmpleado.IdTipoSangre = this.UCCatalogo_tipoSangreEmp.get_Catalogo().CodCatalogo;

                if (cmb_Cargo.get_TipoCargo() != null)
                    infoEmpleado.IdCargo = cmb_Cargo.get_TipoCargo().IdCargo;

                if (cmb_ctacbleCxp.EditValue == null || cmb_ctacbleCxp.EditValue == "")
                    infoEmpleado.IdCtaCble_Emplea = null;
                else
                    infoEmpleado.IdCtaCble_Emplea = cmb_ctacbleCxp.EditValue.ToString().Trim();


                if (ucGe_PaisProvinciaCiudad.get_Info_Ciudad() != null)
                    infoEmpleado.IdUbicacion = ucGe_PaisProvinciaCiudad.get_Info_Ciudad().IdCiudad;

  
                if ((ro_Catalogo_Info)UCCatalogo_tipoLicencia.cmb_catalogo.SelectedItem != null)
                    infoEmpleado.IdTipoLicencia = this.UCCatalogo_tipoLicencia.get_Catalogo().CodCatalogo;

                if (cmbBanco.EditValue != null)
                    infoEmpleado.IdBanco = Convert.ToString(cmbBanco.EditValue);



                if (cmbDepartamento.EditValue!=null && cmbDepartamento.EditValue!="")
                {
                    
                    infoEmpleado.IdDepartamento =Convert.ToInt32( cmbDepartamento.EditValue);
                }
                
                //SRI
                if(cmbCondicionDiscapacidad.EditValue!=null){
                    infoEmpleado.IdCondicionDiscapacidadSRI = cmbCondicionDiscapacidad.EditValue.ToString();
                }

                if (cmbTipoIdentificacionDiscapacitadoSustituye.EditValue!= null)
                {
                    infoEmpleado.IdTipoIdentDiscapacitadoSustitutoSRI = cmbTipoIdentificacionDiscapacitadoSustituye.EditValue.ToString();
                }

                infoEmpleado.IdentDiscapacitadoSustitutoSRI = txtIdentificacionDiscapacitadoSustituye.Text.Trim();



                if (cmbAplicaConvenioDobleImposicion.EditValue != null)
                {
                    infoEmpleado.IdAplicaConvenioDobleImposicionSRI = cmbAplicaConvenioDobleImposicion.EditValue.ToString();
                }

                if (cmbTipoResidencia.EditValue != null)
                {
                    infoEmpleado.IdTipoResidenciaSRI = cmbTipoResidencia.EditValue.ToString();
                }

                if (cmbTipoSistemaSalarioNeto.EditValue != null)
                {
                    infoEmpleado.IdTipoSistemaSalarioNetoSRI = cmbTipoSistemaSalarioNeto.EditValue.ToString();
                }

                if (cmb_grupo.EditValue != null)
                    infoEmpleado.IdGrupo =Convert.ToInt32(cmb_grupo.EditValue);
                infoEmpleado.Marca_Biometrico = check_marca_biometrico.Checked;
                if (txtMotivoSalida.Text != "")
                    infoEmpleado.em_motivo_salisa = txtMotivoSalida.Text;
                else
                    infoEmpleado.em_motivo_salisa = "";
                
                #endregion

                valorRetornar=pu_GetEmpleadoDetalle();

                return valorRetornar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }

        }
        
        public void set_Empleado(ro_Empleado_Info info)
        {
            try
            {
                //Datos_TNomina();

                infoEmpleado = info;

                if (infoEmpleado.em_estado == "I")
                {                   
                      this.lblAnulado.Visible = true;             
                 }
                else
                {
                      this.lblAnulado.Visible = false;
                }


                #region Seteo - EMPLEADO

                txtIdPersona.Text = infoEmpleado.IdPersona.ToString();
                txt_idEmpleado.Text = infoEmpleado.IdEmpleado.ToString();
                cmbDivision.EditValue = infoEmpleado.IdDivision;
                cmbArea.EditValue = infoEmpleado.IdArea;
                txt_codigoEmpleado.Text = infoEmpleado.em_codigo;
                txt_lugarNacimiento.Text = infoEmpleado.em_lugarNacimiento;
                txtCodigoSectorial.Text = infoEmpleado.CodigoSectorialIESS;
                txt_cedulaMilitar.Text = infoEmpleado.em_cedulaMil;
                txt_porcdisc.Text = Convert.ToString(infoEmpleado.por_discapacidad);
                txt_carnetconds.Text = infoEmpleado.carnet_conadis;
                chk_uniforme.Checked = (infoEmpleado.recibi_uniforme == "S") ? true : false;
                txt_camisa.Text = infoEmpleado.talla_camisa;
                txt_pant.Text = Convert.ToString(infoEmpleado.talla_pant);
                txt_zapato.Text = Convert.ToString(infoEmpleado.talla_zapato);
                chkEstado.Checked = (infoEmpleado.em_estado == "A") ? true : false;
                chk_acredita.Checked = (infoEmpleado.em_SeAcreditaBanco == "S") ? true : false;
                txt_numeroCuenta.Text = infoEmpleado.em_NumCta;
                chk_empleadoEspecial.Checked = (infoEmpleado.em_empEspecial == "S") ? true : false;
                cmb_Cargo.set_TipoCargo(Convert.ToInt32(infoEmpleado.IdCargo));


                
                ucGe_PaisProvinciaCiudad.set_InfoPais(infoEmpleado.IdPais);
                ucGe_PaisProvinciaCiudad.set_InfoProvincia(infoEmpleado.IdProvincia);
                ucGe_PaisProvinciaCiudad.set_InfoCiudad(infoEmpleado.IdUbicacion);
                
                textEmail.Text = infoEmpleado.em_mail;
                chkAcreditaHorasExtras.Checked = Convert.ToBoolean(infoEmpleado.es_AcreditaHorasExtras);

                cmbTipoAnticipo.EditValue = infoEmpleado.IdTipoAnticipo;
                txtValorAnticipo.Text = infoEmpleado.em_AnticipoSueldo.ToString();
                chkTruncarDecimales.Checked = Convert.ToBoolean(infoEmpleado.es_TruncarDecimalAnticipo);

                cmbStatus.EditValue = infoEmpleado.em_status;

                if (infoEmpleado.IdEmpleado_Supervisor != null)
                {
                    this.cmb_supervisor.EditValue = infoEmpleado.IdEmpleado_Supervisor;
                }


                if (infoEmpleado.IdSucursal > 0)
                {
                    cmb_sucursal.EditValue = infoEmpleado.IdSucursal;
                }
                
                if (infoEmpleado.IdTipoEmpleado != null)
                {
                    this.UCCatalogo_claseEmpleado.set_item(infoEmpleado.IdTipoEmpleado);
                }

                //FECHAS
               
                dtp_fechaSalida.Value = Convert.ToDateTime((infoEmpleado.em_fechaSalida != null) ? Convert.ToDateTime(infoEmpleado.em_fechaSalida) : DateTime.Now.AddYears(-200));
                dtp_fechaSalida.Checked = (infoEmpleado.em_fechaSalida != null) ? true : false;

                dtp_fechaTerminoContrato.Value = Convert.ToDateTime((infoEmpleado.em_fechaTerminoContra != null) ? Convert.ToDateTime(infoEmpleado.em_fechaTerminoContra) : DateTime.Now.AddYears(-200));
                dtp_fechaTerminoContrato.Checked = (infoEmpleado.em_fechaTerminoContra != null) ? true : false;

                dtp_FechaIngresoIESS.Value = Convert.ToDateTime((infoEmpleado.em_fechaIngaRol != null) ? Convert.ToDateTime(infoEmpleado.em_fechaIngaRol) : DateTime.Now.AddYears(-200));
                dtp_FechaIngresoIESS.Checked = (infoEmpleado.em_fechaIngaRol != null) ? true : false;

                
                if (infoEmpleado.em_tipoCta != null)
                {
                    this.UCCatalogo_tipoCuentaEmp.set_item(infoEmpleado.em_tipoCta);
                }
                
                
                if (infoEmpleado.em_foto != null)
                {    pic_foto.Image =Funciones.ArrayAImage(infoEmpleado.em_foto);}

                      
                if (infoEmpleado.IdTipoSangre != null)
                { this.UCCatalogo_tipoSangreEmp.set_item(infoEmpleado.IdTipoSangre); }
                

                if (infoEmpleado.IdCtaCble_Emplea != null)
                    cmb_ctacbleCxp.EditValue = infoEmpleado.IdCtaCble_Emplea.Trim();


                if (infoEmpleado.IdTipoLicencia != null)
                {this.UCCatalogo_tipoLicencia.set_item(infoEmpleado.IdTipoLicencia); }

                if (infoEmpleado.IdBanco != null)
                    {this.cmbBanco.EditValue = infoEmpleado.IdBanco; } 

          

                if (infoEmpleado.IdDepartamento != null)
                {
                    cmbDepartamento.EditValue = infoEmpleado.IdDepartamento;
                }

                if (info.IdGrupo != null)
                    cmb_grupo.EditValue = infoEmpleado.IdGrupo;

                if (info.Marca_Biometrico != null)
                    check_marca_biometrico.Checked =Convert.ToBoolean( info.Marca_Biometrico);
                txtMotivoSalida.Text = infoEmpleado.em_motivo_salisa;
                #endregion

                #region Seteo datos Persona
                txtIdPersona.Text = Convert.ToString((infoEmpleado.InfoPersona.IdPersona == null)? 0:infoEmpleado.InfoPersona.IdPersona);
                txtApellido.Text = infoEmpleado.InfoPersona.pe_apellido;
                txt_nombresEmpleado.Text = infoEmpleado.InfoPersona.pe_nombre;
                
                if (infoEmpleado.InfoPersona.IdTipoDocumento != null)
                {
                    this.UCCatalogo_tipoDoc.set_item(infoEmpleado.InfoPersona.IdTipoDocumento.Trim());
                }

                txt_cedulaRucEmpleado.Text = infoEmpleado.InfoPersona.pe_cedulaRuc;
                txt_Direccion.Text = infoEmpleado.InfoPersona.pe_direccion;
                txt_telefono.Text = infoEmpleado.InfoPersona.pe_telfono_Contacto;
                txt_celular.Text = infoEmpleado.InfoPersona.pe_celular;

                if (infoEmpleado.InfoPersona.pe_sexo != null)
                {
                    this.UCCatalogo_sexo.set_item(infoEmpleado.InfoPersona.pe_sexo);
                }

                if (infoEmpleado.InfoPersona.IdEstadoCivil != null)
                {
                    this.UCCatalogo_EstadoCivil.set_item(infoEmpleado.InfoPersona.IdEstadoCivil);
                }

                dtp_fechaNacimiento.Value = Convert.ToDateTime((infoEmpleado.InfoPersona.pe_fechaNacimiento != null) ? Convert.ToDateTime(infoEmpleado.InfoPersona.pe_fechaNacimiento) : DateTime.Now.AddYears(-200));
                dtp_fechaNacimiento.Checked = (infoEmpleado.InfoPersona.pe_fechaNacimiento != null) ? true : false;

                #endregion

                #region Seteo Documentos
                    
                    set_gridDoc();

                #endregion

                #region Seteo Familiares

                    pu_CargaFamiliar();

                #endregion

                #region Seteo Datos del Titulo

                    pu_CargarRegistroAcademico();
                
                #endregion

                #region Seteo Datos de los Estudios

                    pu_GargarEstudios();

                #endregion

                 #region SETEO DE DATOS - TIPO DE NOMINA

                    oListRo_Empleado_TipoNomina_Info = oRo_Empleado_TipoNomina_Bus.Get_List_Empleado_TipoNomina_x_IdEmpleado(infoEmpleado.IdEmpresa,infoEmpleado.IdEmpleado);

                    foreach (var item3 in oListRo_Empleado_TipoNomina_Info)
                    {
                        foreach (var item4 in oBindingListRo_Nomina_Tipo_Info)
                        {
                            if(item3.IdNomina_Tipo==item4.IdNomina_Tipo){
                                item4.check = true;
                                break;
                            }
                        
                        }

                    }

                    

                #endregion

                #region SETEO DE DATOS - RUBROS ACUMULADOS
                oListRo_empleado_x_rubro_acumulado_Info = oRo_empleado_x_rubro_acumulado_Bus.Get_List_empleado_x_rubro_acumulado(param.IdEmpresa, infoEmpleado.IdEmpleado);
                foreach (var item1 in oListRo_empleado_x_rubro_acumulado_Info)
                {
                    foreach (var item2 in oBindingListRo_ConfRubrosAcumulado_Info)
                        {
                            if (item1.IdEmpresa==item2.IdEmpresa && item1.IdRubro==item2.IdRubro){
                                item2.Ckeck = true;
                                break;
                            }        
                            
                            
                        }
                 }
                #endregion

                #region SETEO DE DATOS - HORARIOS
                oListRo_Empleado_X_Horario_Info = oRo_Empleado_X_Horario_Bus.Get_List_Empleado_X_Horario(param.IdEmpresa, infoEmpleado.IdEmpleado);
                foreach (var item1 in oListRo_Empleado_X_Horario_Info)
                {
                    foreach (var item2 in oBindingListRo_Horario_Info)
                    {
                        if (item1.IdEmpresa == item2.IdEmpresa  &&item1.IdHorario == item2.IdHorario)
                        {
                            item2.Check= true;
                            item2.CheckDefault = item1.EsPredeterminado;
                            break;
                        }


                    }
                }
                #endregion


                #region SETEO DE DATOS - CENTRO DE COSTO POR EMPLEADO
                oListRo_empleado_x_centro_costo_Info = oRo_empleado_x_centro_costo_Bus.Get_List_empleado_x_centro_costo(param.IdEmpresa,ref MensajeError);

                
                    foreach (var item2 in oListCt_Centro_costo_Info)
                    {
                         



                    }
                

                #endregion

                #region SETEO DE DATOS - RUBROS FIJOS

                
                ucRo_NominaTipo.setIdEmpleado(infoEmpleado.IdEmpleado);

                oBindingListRo_empleado_x_ro_rubro_Info = new BindingList<ro_empleado_x_ro_rubro_Info>(oRo_empleado_x_ro_rubro_Bus.Get_List_empleado_x_ro_rubro_x_Empleado(param.IdEmpresa, infoEmpleado.IdEmpleado));
                gridControlRubro.DataSource = oBindingListRo_empleado_x_ro_rubro_Info;

                #endregion

          




                if (infoEmpleado.IdCondicionDiscapacidadSRI!=null)
                {
                    cmbCondicionDiscapacidad.EditValue = infoEmpleado.IdCondicionDiscapacidadSRI;
                }

                if (infoEmpleado.IdTipoIdentDiscapacitadoSustitutoSRI != null)
                {
                    cmbTipoIdentificacionDiscapacitadoSustituye.EditValue = infoEmpleado.IdTipoIdentDiscapacitadoSustitutoSRI;
                }

                if (infoEmpleado.IdAplicaConvenioDobleImposicionSRI != null)
                {
                    cmbAplicaConvenioDobleImposicion.EditValue = infoEmpleado.IdAplicaConvenioDobleImposicionSRI;
                }

                if (infoEmpleado.IdTipoResidenciaSRI != null)
                {
                    cmbTipoResidencia.EditValue = infoEmpleado.IdTipoResidenciaSRI;
                }

                if (infoEmpleado.IdTipoSistemaSalarioNetoSRI != null)
                {
                    cmbTipoSistemaSalarioNeto.EditValue = infoEmpleado.IdTipoSistemaSalarioNetoSRI;
                }

                txtIdentificacionDiscapacitadoSustituye.Text = infoEmpleado.IdentDiscapacitadoSustitutoSRI == null ? "" : infoEmpleado.IdentDiscapacitadoSustitutoSRI;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public void set_DatosPersona(tb_persona_Info InfoPersona)
        {
            try
            {
                #region Seteo datos Persona
                txtIdPersona.Text = Convert.ToString((InfoPersona.IdPersona == null) ? 0 : InfoPersona.IdPersona);
                txtApellido.Text = InfoPersona.pe_apellido;
                txt_nombresEmpleado.Text = InfoPersona.pe_nombre;

                if (InfoPersona.IdTipoDocumento != null)
                {
                    this.UCCatalogo_tipoDoc.set_item(InfoPersona.IdTipoDocumento.Trim());
                }

                txt_cedulaRucEmpleado.Text = InfoPersona.pe_cedulaRuc;
                txt_Direccion.Text = InfoPersona.pe_direccion;
                txt_telefono.Text = InfoPersona.pe_telfono_Contacto;
                txt_celular.Text = InfoPersona.pe_celular;

                if (InfoPersona.pe_sexo != null)
                {
                    this.UCCatalogo_sexo.set_item(InfoPersona.pe_sexo);
                }

                if (InfoPersona.IdEstadoCivil != null)
                {
                    this.UCCatalogo_EstadoCivil.set_item(InfoPersona.IdEstadoCivil);
                }

                dtp_fechaNacimiento.Value = Convert.ToDateTime((InfoPersona.pe_fechaNacimiento != null) ? Convert.ToDateTime(InfoPersona.pe_fechaNacimiento) : DateTime.Now.AddYears(-200));
                dtp_fechaNacimiento.Checked = (InfoPersona.pe_fechaNacimiento != null) ? true : false;

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public void set_DatosEmpleado(ro_Empleado_Info infoEmpleado)
        {
            try
            {

                #region Seteo datos empleado

                txt_idEmpleado.Text = infoEmpleado.IdEmpleado.ToString();

             

                if (infoEmpleado.IdDivision != null)
                {
                    cmbDivision.EditValue = infoEmpleado.IdDivision;
                
                }

                if (infoEmpleado.IdArea != null)
                {
                    cmbArea.EditValue = infoEmpleado.IdArea;

                }


              
              





                if (infoEmpleado.IdEmpleado_Supervisor != null)
                {
                    this.cmb_supervisor.EditValue = infoEmpleado.IdEmpleado_Supervisor;
                }

                txtIdPersona.Text = infoEmpleado.IdPersona.ToString();

                if (infoEmpleado.IdSucursal != null)
                {
                    cmb_sucursal.EditValue = infoEmpleado.IdSucursal;
                }

                if (infoEmpleado.IdTipoEmpleado != null)
                {
                    this.UCCatalogo_claseEmpleado.set_item(infoEmpleado.IdTipoEmpleado);
                }

                
                txt_codigoEmpleado.Text = infoEmpleado.em_codigo;
                txt_lugarNacimiento.Text = infoEmpleado.em_lugarNacimiento;
                txtCodigoSectorial.Text = infoEmpleado.CodigoSectorialIESS;
                txt_cedulaMilitar.Text = infoEmpleado.em_cedulaMil;

                
                dtp_fechaSalida.Value = Convert.ToDateTime((infoEmpleado.em_fechaSalida != null) ? Convert.ToDateTime(infoEmpleado.em_fechaSalida) : DateTime.Now.AddYears(-200));
                dtp_fechaSalida.Checked = (infoEmpleado.em_fechaSalida != null) ? true : false;

                dtp_fechaTerminoContrato.Value = Convert.ToDateTime((infoEmpleado.em_fechaTerminoContra != null) ? Convert.ToDateTime(infoEmpleado.em_fechaTerminoContra) : DateTime.Now.AddYears(-200));
                dtp_fechaTerminoContrato.Checked = (infoEmpleado.em_fechaTerminoContra != null) ? true : false;

                dtp_FechaIngresoIESS.Value = Convert.ToDateTime((infoEmpleado.em_fechaIngaRol != null) ? Convert.ToDateTime(infoEmpleado.em_fechaIngaRol) : DateTime.Now.AddYears(-200));
                dtp_FechaIngresoIESS.Checked = (infoEmpleado.em_fechaIngaRol != null) ? true : false;

              

                chk_acredita.Checked = (infoEmpleado.em_SeAcreditaBanco == "S") ? true : false;

                if (infoEmpleado.em_tipoCta != null)
                {
                    this.UCCatalogo_tipoCuentaEmp.set_item(infoEmpleado.em_tipoCta);
                }

                txt_numeroCuenta.Text = infoEmpleado.em_NumCta;
           
                chkEstado.Checked = (infoEmpleado.em_estado == "A") ? true : false;
           
               

                if (infoEmpleado.em_foto != null)
                { pic_foto.Image =Funciones.ArrayAImage(infoEmpleado.em_foto); }


                chk_empleadoEspecial.Checked = (infoEmpleado.em_empEspecial == "S") ? true : false;

           

                if (infoEmpleado.IdTipoSangre != null)
                { this.UCCatalogo_tipoSangreEmp.set_item(infoEmpleado.IdTipoSangre); }

                cmb_Cargo.set_TipoCargo(Convert.ToInt32(infoEmpleado.IdCargo));

                if (infoEmpleado.IdCtaCble_Emplea != null)
                    cmb_ctacbleCxp.EditValue = infoEmpleado.IdCtaCble_Emplea.Trim();

                //corregir
                ucGe_PaisProvinciaCiudad.set_InfoPais(infoEmpleado.IdPais);
                ucGe_PaisProvinciaCiudad.set_InfoProvincia(infoEmpleado.IdProvincia);
                ucGe_PaisProvinciaCiudad.set_InfoCiudad(infoEmpleado.IdUbicacion);

                textEmail.Text = infoEmpleado.em_mail;

                if (infoEmpleado.IdTipoLicencia != null)
                { this.UCCatalogo_tipoLicencia.set_item(infoEmpleado.IdTipoLicencia); }

                if (infoEmpleado.IdBanco != null)
                {    this.cmbBanco.EditValue = infoEmpleado.IdBanco; } 


                if (infoEmpleado.IdDepartamento != null)
                {
                    Info_departamento = bus_depa.Get_Info_Departamento(infoEmpleado.IdEmpresa, Convert.ToInt32(infoEmpleado.IdDepartamento));
                    this.UCRDep.set_DepartamentoCheckedSelection(Info_departamento);

                }
                if(infoEmpleado.IdGrupo!=null)
                cmb_grupo.EditValue = infoEmpleado.IdGrupo;

                /*fin datos de empleado*/

                #endregion

                #region Seteo Datos del Titulo

                pu_CargarRegistroAcademico();

                #endregion
                
                #region Seteo Datos de los Estudios

                    pu_GargarEstudios();

                #endregion


                #region Seteo Datos del Tipo de Nomina

               // Datos_TNomina();

                #endregion

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        private void frmRo_MantEmpleado_Load(object sender, EventArgs e)
        {
            try
                {


                   // pu_IniciarControles();
                  //  pu_CargarCombos();

                    gridCtrlDocumento.DataSource = oListRo_DocumentoxEmp_Info;
                    gridCargaFam.DataSource = Obj_cafa;
                    gridTitulo.DataSource = ro_Capacitaciones_x_Empleado_Info;
                    gridEstudios.DataSource = obj_estudios;
                    gridControlRubro.DataSource = oBindingListRo_empleado_x_ro_rubro_Info;

                    gridControlconsult.DataSource = obj_co;

                    ofdDoc = new OpenFileDialog();
                    sfdDoc = new SaveFileDialog();

                    //Busca en el folder de 'Mis documentos'
                    ofdDoc.InitialDirectory = Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments);
                    sfdDoc.InitialDirectory = Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments);

                    //Para que solo se puedan elegir archivos .docx y .doc
                    //puedes agregar los otros formatos...            
                    ofdDoc.Filter = "(*.pdf)|*.pdf";
                    sfdDoc.Filter = "(*.pdf)|*.pdf";


                 List<ro_Catalogo_Info> ListAnioFiscal = new List<ro_Catalogo_Info>();
                 ListAnioFiscal = oRo_Catalogo_Bus.Get_List_Catalogo_x_AnioFiscal(param.IdEmpresa);

                 cmbAnioFiscal.ValueMember = "IdCatalogo";
                 cmbAnioFiscal.DisplayMember = "ca_descripcion";
                 cmbAnioFiscal.DataSource = ListAnioFiscal;
                  lblAnulado.Visible = false;

                    if (infoEmpleado.em_estado == "I")
                    {
                        this.lblAnulado.Visible = true;
                    }
                    else
                    {
                        this.lblAnulado.Visible = false;
                    }

                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                           oBindingListRo_ConfRubrosAcumulado_Info = new BindingList<ro_ConfRubrosAcumulado_Info>(oRo_ConfRubrosAcumulados_Bus.ConsultaGeneral(param.IdEmpresa));
                            gridRubroAcum.DataSource = oBindingListRo_ConfRubrosAcumulado_Info;
                            gridControlCapacitaciones.DataSource = ListCapacitaciones;
                            ucRo_CentroCosto.Accion = Accion;
                           
                           
                             ListHsueldo = new BindingList<ro_HistoricoSueldo_Info>();
                            gridControlSueldoH.DataSource = ListHsueldo;

                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                            ucGe_Menu.Enabled_bntAnular = false;
                            this.txt_idEmpleado.Enabled = false; //el id debe ser secuencial
                            this.chkEstado.Enabled = false;
                            this.chkEstado.Checked = true; 

                            this.txtIdPersona.Enabled = false;
                            this.txtIdPersona.BackColor = System.Drawing.Color.White;
                            this.txtIdPersona.ForeColor = System.Drawing.Color.Black;

                              cmbStatus.EditValue = "EST_ACT";

                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            


                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Enabled_bntAnular = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            ucGe_Menu.Visible_bntSalir = true;
                            this.txt_idEmpleado.Enabled = false; //el id debe ser secuencial
                            // busco rubros acumulados
                            oBindingListRo_ConfRubrosAcumulado = new BindingList<ro_ConfRubrosAcumulado_Info>(oRo_ConfRubrosAcumulados_Bus.ConsultaGeneral(param.IdEmpresa));
                           // busco los rubros acumulados por empleados
                            oBindingListRo_ConfRubrosAcumulado_Info = new BindingList<ro_ConfRubrosAcumulado_Info>(oRo_ConfRubrosAcumulados_Bus.ConsultaGeneral(param.IdEmpresa, infoEmpleado.IdEmpleado));

                            foreach (var item in oBindingListRo_ConfRubrosAcumulado)
                            {
                                foreach (var itemR in oBindingListRo_ConfRubrosAcumulado_Info)
                                {
                                    if (item.IdEmpresa == itemR.IdEmpresa && item.IdRubro == itemR.IdRubro)
                                    {
                                        item.FechaInicio = itemR.FechaInicio;
                                        item.FechaFin = itemR.FechaFin;
                                        item.Ckeck = true;
                                    }
                                    
                                }
                                
                            }
                            gridRubroAcum.DataSource = oBindingListRo_ConfRubrosAcumulado;

    
                         
                            ucRo_CentroCosto.Accion = Accion;
                            ucRo_CentroCosto._idEmpleado = infoEmpleado.IdEmpleado;

                            //set_Empleado(infoEmpleado);

                              this.txtIdPersona.Enabled = false;
                              this.txtIdPersona.BackColor = System.Drawing.Color.White;
                              this.txtIdPersona.ForeColor = System.Drawing.Color.Black;
                  
                            break;

                        case Cl_Enumeradores.eTipo_action.Anular:
                           // set_Empleado(infoEmpleado);
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            ucGe_Menu.Enabled_bntAnular = true;
                            break;

                        case Cl_Enumeradores.eTipo_action.consultar:

                            gridControlSueldoH.Enabled = false;
                            gridControlSueldoH.ForeColor = System.Drawing.Color.Black;

                            ucRo_CentroCosto.Accion = Accion;
                            ucRo_CentroCosto._idEmpleado = infoEmpleado.IdEmpleado;
                            cmbDepartamento.Enabled = false;


                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            ucGe_Menu.Enabled_bntAnular = false;
                            this.txt_idEmpleado.Enabled = false; //el id debe ser secuencial

                            Inhabilitar_Controles();
                            //set_Empleado(infoEmpleado);

                            break;

                        default:
                            break;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        private void pu_Abrir_Imagen() {

            try
            {
                OpenFileDialog EscojaFoto = new OpenFileDialog();
                EscojaFoto.InitialDirectory = "c:\\";
                EscojaFoto.Filter = "JPG FILES (*.JPG)|*.jpg|GIF FILES (*.GIF)|*.gif|JPEG FILES (*.JPEG)|*.jpeg";
                EscojaFoto.RestoreDirectory = true;
                EscojaFoto.ShowDialog();

                if (EscojaFoto.FileName != "")
                {
                    pic_foto.Image = Image.FromFile(EscojaFoto.FileName);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        public Boolean pu_Validar()
        {
            try
            {
                Valido = true;

                if (txt_cedulaRucEmpleado.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar la Cédula/Ruc o Identificador", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                    txt_cedulaRucEmpleado.Focus();
                }
                 else if (txt_nombresEmpleado.Text == string.Empty)
                 {
                    MessageBox.Show("Debe ingresar los nombres del empleado ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                    txt_nombresEmpleado.Focus();
                 }

                else if (txtApellido.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar los apellidos del empleado ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                    txtApellido.Focus();
                }

                else if (txt_Direccion.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar la dirección del empleado ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                    txt_Direccion.Focus();
                }

                
                else if (UCCatalogo_claseEmpleado.cmb_catalogo.SelectedValue ==null )
                {
                    MessageBox.Show("Debe ingresar el tipo de empleado ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                }else if (cmb_sucursal.EditValue == null || cmb_sucursal.EditValue == "")
                 {
                     MessageBox.Show("Debe seleccionar la sucursal del empleado ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     Valido = false;
                     cmb_sucursal.Focus();
                 }

                else if (ucGe_PaisProvinciaCiudad.get_Info_Ciudad() == null)
                {
                    MessageBox.Show("Debe seleccionar una nacionalidad para este empleado ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                    ucGe_PaisProvinciaCiudad.Focus();
                }else if (cmb_Cargo.get_TipoCargo() == null)
                {
                    MessageBox.Show("Debe seleccionar un cargo para este empleado ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                    cmb_Cargo.Focus();
                }
                else if (cmbDivision.EditValue == null || cmbDivision.EditValue == "")
                {
                    MessageBox.Show("Debe seleccionar la División del empleado ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                    cmbDivision.Focus();
                }
           


                
              


                return Valido;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }

        }

        private Boolean CargaArchivo()
        {

            try
            {
                
                byte[] readBuffer = System.IO.File.ReadAllBytes(txtRuta.Text);
                
                if (readBuffer!= null)
                {
                    if (gridvwDocum.RowCount>0)
                        oListRo_DocumentoxEmp_Info = (List<ro_DocumentoxEmp_Info>)gridCtrlDocumento.DataSource;

                    idDoc++;
                    InfoDoc = new ro_DocumentoxEmp_Info();
                    InfoDoc.Documento = readBuffer;
                    InfoDoc.Dc_Nombre = fileName;
                    InfoDoc.IdDocumento = idDoc;
                    InfoDoc.tipo = tipofile;
                    InfoDoc.IdEmpresa = param.IdEmpresa;
                    InfoDoc.FechaReg = DateTime.Now;
                    InfoDoc.Dc_Descripcion = "";
                    InfoDoc.Estado = "A";
                    InfoDoc.Descargar = "Descargar";
                    oListRo_DocumentoxEmp_Info.Add(InfoDoc);
                    verificatpo();
                    gridCtrlDocumento.DataSource = null;
                    gridCtrlDocumento.DataSource = oListRo_DocumentoxEmp_Info;
                   // grabardoc();
                
                }else
                    MessageBox.Show("Ingrese una dirección de archivo válida", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
             //   idDoc;
               
            }

            }



        private void Limpiar()
        {
            try
            {
                cmb_sucursal.EditValue = null;
                cmbDivision.EditValue = null;
                cmbArea.EditValue = null;
                cmb_supervisor.EditValue = null;
                this.cmb_Cargo.Inicializar_cmb_Cargo();
                ucGe_PaisProvinciaCiudad.CargarComboCiudad("0");
                ucGe_PaisProvinciaCiudad.CargarComboProvincia("0");
                ucGe_PaisProvinciaCiudad.set_InfoPais("0");
                ucGe_PaisProvinciaCiudad.CargarComboPais();
                cmbDepartamento.EditValue = null;
                txtApellido.Text = "";
                txt_Direccion.Text = "";
                txt_nombresEmpleado.Text = "";
                txtRuta.Text = "";
                gridCtrlDocumento.DataSource = null;

                gridControlSueldoH.RefreshDataSource();
                ListCapacitaciones = new BindingList<Info.Roles.ro_Capacitaciones_x_Empleado_Info>();
                gridControlCapacitaciones.DataSource = ListCapacitaciones;


                obj_estudios = new BindingList<ro_Empleado_estudios_Info>();
                gridEstudios.DataSource = obj_estudios;
                ro_Capacitaciones_x_Empleado_Info
                ro_Capacitaciones_x_Empleado_Info=new ro_Capacitaciones_x_Empleado_Info();
                gridTitulo.DataSource = ro_Capacitaciones_x_Empleado_Info;

                gridCargaFam.DataSource = null;
                gridEstudios.DataSource = null;
                gridTitulo.DataSource = null;
                gridPGP.DataSource = null;
                txtCodigoSectorial.Text = "";
                cmbArea.Properties.DataSource = infoArea;
                cmbDivision.Properties.DataSource =null;
                txtApellido.Text = "";
                txt_codigoEmpleado.Text = "";
                txt_idEmpleado.Text = "";
                txtIdPersona.Text = "";
                txt_cedulaRucEmpleado.Text = "";
                txtApellido.Text = "";
                chkEstado.Checked = true;                
                txtValorAnticipo.Text="";
                oBindingListRo_ConfRubrosAcumulado_Info = new BindingList<ro_ConfRubrosAcumulado_Info>(oRo_ConfRubrosAcumulados_Bus.ConsultaGeneral(param.IdEmpresa).Where(v => v.Configurable == true).ToList());
                oBindingListRo_Horario_Info = new BindingList<ro_Horario_Info>(oRo_Horario_Bus.Get_List_Horario(param.IdEmpresa));
                oBindingListRo_Nomina_Tipo_Info = new BindingList<ro_Nomina_Tipo_Info>(oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa));
                cmbNomina.DataSource = oListRo_Nomina_Tipo_Info;
                cmbNominaLiqui.DataSource = oListRo_Nomina_Tipoliqui_Info;

                oBindingListRo_ConfRubrosAcumulado_Info = new BindingList<ro_ConfRubrosAcumulado_Info>(oRo_ConfRubrosAcumulados_Bus.ConsultaGeneral(param.IdEmpresa).Where(v => v.Configurable == true).ToList());
                gridRubroAcum.DataSource = oBindingListRo_ConfRubrosAcumulado_Info;

                cmbCentroCosto1.DataSource = oListCt_Centro_costo_Info;
                cmbRubro1.DataSource = oListRo_rubro_tipo_Info;
                cmbRubro.Properties.DataSource = oListRo_rubro_tipo_Info;
                cmbStatus.Properties.DataSource = oRo_EstadoEmpleado_Info;
                cmbTipoResidencia.Properties.DataSource = oListRo_TipoResidencia_Info;
                cmbAplicaConvenioDobleImposicion.Properties.DataSource = oListRo_AplicaConvenioDobleImposicion_Info;
                cmbTipoIdentificacionDiscapacitadoSustituye.Properties.DataSource = oListRo_TipoIdentDiscapacitadoSustituye_Info;
                cmbTipoAnticipo.Properties.DataSource = oListRo_TipoAnticipo_Info;







                //Datos Personales   
                this.txtIdPersona.Text = "";
                this.txt_idEmpleado.Text = "";
                this.txt_codigoEmpleado.Text = "";
                this.txt_nombresEmpleado.Text = "";
                this.txtApellido.Text = "";
                this.txt_Direccion.Text = "";
                this.txt_lugarNacimiento.Text = "";
                this.textEmail.Text = "";
                this.txt_telefono.Text = "";
                this.txt_celular.Text = "";
                this.txt_cedulaMilitar.Text = "";

                //Datos Nomina
                this.txtCodigoSectorial.Text = "";
                this.txt_numeroCuenta.Text = "";

                //Datos Laborales
                this.cmb_sucursal.Properties.DataSource = sucursalInfo;
                this.cmbDivision.Properties.DataSource = infoDivision;
                this.cmbArea.Properties.DataSource = infoArea;
                this.cmb_Cargo.get_TipoCargo();
                this.cmb_supervisor.Properties.DataSource=InfoSup;

                //Cargos Familiares
                this.gridCargaFam.DataSource = null;
                //Informacion academica
                this.gridTitulo.DataSource = null;
                this.gridEstudios.DataSource = null;

                gridControlSueldoH.DataSource = null;


                this.cmb_ctacbleCxp.Properties.DataSource=listaPlan;

                //Historial de contratos
                this.gridControlconsult.DataSource = null;
                //Documentos
                this.txtRuta.Text = "";
                this.gridCtrlDocumento.DataSource = null;

                pu_IniciarControles();
                pu_CargarCombos();
                ListHsueldo = new BindingList<ro_HistoricoSueldo_Info>();
                gridControlSueldoH.DataSource = ListHsueldo;
            }
            catch (Exception ex)
            {
                
                
            }

        }

        private void set_gridDoc()
        {
            try
            {
                oListRo_DocumentoxEmp_Info = new List<ro_DocumentoxEmp_Info>();
                oListRo_DocumentoxEmp_Info = BusDoc.ConsultaXEmpleado(param.IdEmpresa, infoEmpleado.IdEmpleado).FindAll(var => var.Estado == "A");
                oListRo_DocumentoxEmp_InfoElim = BusDoc.ConsultaXEmpleado(param.IdEmpresa, infoEmpleado.IdEmpleado).FindAll(var => var.Estado == "I");
                idDoc = oListRo_DocumentoxEmp_Info.Count + oListRo_DocumentoxEmp_InfoElim.Count;
                oListRo_DocumentoxEmp_Info.ForEach(var => var.Descargar = "Descargar");
                verificatpo();
                gridCtrlDocumento.DataSource = oListRo_DocumentoxEmp_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void verificatpo()
        {

            try
            {
                 foreach (var item in oListRo_DocumentoxEmp_Info)
                    {
                        if (item.tipo.Trim() == ".docx" || item.tipo.Trim() == ".doc")
                        {
                            Bitmap ima = (Bitmap)imageList1.Images[4];

                            item.Ico = ima;
                        }
                        else if (item.tipo.Trim() == ".xlsx" || item.tipo.Trim() == ".xls")
                        {
                            Bitmap ima = (Bitmap)imageList1.Images[0];
                            item.Ico = ima;
                        }
                        else if (item.tipo.Trim() == ".zip" || item.tipo.Trim() == ".rar")
                        {
                            Bitmap ima = (Bitmap)imageList1.Images[5];
                            item.Ico = ima;
                        }
                        else if (item.tipo.Trim() == ".pptx" || item.tipo.Trim() == ".ppt")
                        {
                            Bitmap ima = (Bitmap)imageList1.Images[3];
                            item.Ico = ima;
                        }
                        else if (item.tipo.Trim() == ".jpeg" || item.tipo.Trim() == ".ico" || item.tipo.Trim() == ".png" || item.tipo.Trim() == ".bmp" || item.tipo.Trim() == ".gif" || item.tipo.Trim() == ".jpg")
                        {
                            Bitmap ima = (Bitmap)imageList1.Images[2];
                            item.Ico = ima;
                        }
                        else if (item.tipo.Trim() == ".pdf")
                        {
                            Bitmap ima = (Bitmap)imageList1.Images[6];
                            item.Ico = ima;
                        }

                        else
                        {
                            Bitmap ima = (Bitmap)imageList1.Images[1];
                            item.Ico = ima;
                        }

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        } 

        public Boolean grabardoc()
        {
            try
            {
                string msg1 = "";
                List<ro_DocumentoxEmp_Info> oListRo_DocumentoxEmp_Info = new List<ro_DocumentoxEmp_Info>();
                oListRo_DocumentoxEmp_Info = BusDoc.ConsultaXEmpleado(param.IdEmpresa, infoEmpleado.IdEmpleado);

                oListRo_DocumentoxEmp_Info = (List<ro_DocumentoxEmp_Info>)gridCtrlDocumento.DataSource;
                if (oListRo_DocumentoxEmp_Info != null && oListRo_DocumentoxEmp_Info.Count != 0)
                {
                    oListRo_DocumentoxEmp_Info.ForEach(q => q.IdEmpleado = infoEmpleado.IdEmpleado);
                    foreach (var item in oListRo_DocumentoxEmp_InfoElim)
                    {
                        oListRo_DocumentoxEmp_Info.Add(item);
                    }
                    BusDoc.GuardarDB(oListRo_DocumentoxEmp_Info);
                    set_gridDoc();
                }
                

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); 
                return false;
            }
            

        }

        

  

        private void TabControl_Click(object sender, EventArgs e)
        {
            try
            {
                //if (TabControl.SelectedTabPage.Name == "TabRubroFijo")
                //{
                //    //pu_CargarRubrosFijos();
                    
                //}

                if (TabControl.SelectedTabPage.Name == "TabContrato")
                {
                    pu_CargarContratos();
                }

                if (TabControl.SelectedTabPage.Name == "TabHistSuel")
                {
                    pu_CargarSueldoHistorico();
                }

                if (TabControl.SelectedTabPage.Name == "TabRubroFijo" && infoEmpleado != null)
                {
                    ucRo_NominaTipo.setIdEmpleado(infoEmpleado.IdEmpleado);
                    ucRo_CentroCosto.setCentroCosto(param.IdEmpresa, infoEmpleado.IdEmpleado);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
           
        }

        public void pu_CargarContratos()
        {
            try
            {
                ro_contrato_bus BusContrato = new ro_contrato_bus();
                BindingList<ro_contrato_Info> ListContrato = new BindingList<ro_contrato_Info>(BusContrato.GetListPorEmpleado(infoEmpleado.IdEmpresa, infoEmpleado.IdEmpleado));

                gridControlconsult.DataSource = ListContrato;

                string msg = "";
                //gridControlconsult.DataSource = ListContrato; 
                
                            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
            
        }

        public void pu_CargarSueldoHistorico()
        {
            try
            {
                ro_HistoricoSueldo_Bus BusHsueldo = new ro_HistoricoSueldo_Bus();
                 ListHsueldo = new BindingList<ro_HistoricoSueldo_Info>(BusHsueldo.Get_List_HistoricoSueldo(param.IdEmpresa, infoEmpleado.IdEmpleado));

                string msg = "";
                gridControlSueldoH.DataSource = ListHsueldo;
                gridControlSueldoH.RefreshDataSource();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public void pu_CargaFamiliar()
        {
            try
            {
                ro_CargaFamiliar_Bus BusFamiliar = new ro_CargaFamiliar_Bus();
                Obj_cafa = new BindingList<ro_CargaFamiliar_Info>(BusFamiliar.Obtener_CargaFamiliar(param.IdEmpresa, Convert.ToInt32(infoEmpleado.IdEmpleado)));
                gridCargaFam.DataSource = Obj_cafa;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        public void pu_CargarRegistroAcademico()
        {
            try
            {
                ro_empleado_x_titulos_Bus Bus_Titulos = new ro_empleado_x_titulos_Bus();
                ro_Capacitaciones_x_Empleado_Info = new BindingList<ro_empleado_x_titulos_Info>(Bus_Titulos.Get_List_empleado_x_titulos(param.IdEmpresa, infoEmpleado.IdEmpleado));
                gridTitulo.DataSource = ro_Capacitaciones_x_Empleado_Info;
      


                //  c.c
                ro_Capacitaciones_x_Empleado_Bus BuscCapac= new ro_Capacitaciones_x_Empleado_Bus();
                ListCapacitaciones = new BindingList<ro_Capacitaciones_x_Empleado_Info>(BuscCapac.ConsultaXEmpleado(param.IdEmpresa, infoEmpleado.IdEmpleado));
                gridControlCapacitaciones.DataSource = ListCapacitaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        public void pu_GargarEstudios()
        {
            try
            {
                ro_Empleado_estudios_Bus Bus_Estudios = new ro_Empleado_estudios_Bus();
                obj_estudios = new BindingList<ro_Empleado_estudios_Info>(Bus_Estudios.Get_List_Empleado_estudios(param.IdEmpresa, infoEmpleado.IdEmpleado));
                gridEstudios.DataSource = obj_estudios;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }







       

        private Boolean ValidaFamiliar()
        {
            try
            {
                  foreach (var item in Obj_cafa)
                    {
                        ro_CargaFamiliar_Info Info_familiar = new ro_CargaFamiliar_Info();

                        Info_familiar.Sexo = item.Sexo;

                        if (Info_familiar.Sexo == null)
                        {
                            MessageBox.Show("No ha ingresado el sexo del familiar ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        Info_familiar.TipoFamiliar = item.TipoFamiliar;

                        if (Info_familiar.TipoFamiliar == null)
                        {
                            MessageBox.Show("No ha ingresado  el parentezco del familiar ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        Info_familiar.Nombres = item.Nombres;

                        if (Info_familiar.Nombres == null)
                        {
                            MessageBox.Show("No ha ingresado los nombres del familiar ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        Info_familiar.Cedula = item.Cedula;
                
                        if (Info_familiar.Cedula == null)
                        {
                            MessageBox.Show("No ha ingresado la cédula del familiar ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }                           
                    }
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
          
        }
     
      

        private Boolean ValidaTitulos()
        {
            try
            {
                 foreach (var item in ro_Capacitaciones_x_Empleado_Info)
                    {
                        ro_empleado_x_titulos_Info info_titulos = new ro_empleado_x_titulos_Info();

                        info_titulos.fecha = item.fecha;

                        if (info_titulos.fecha == null)
                        {
                            MessageBox.Show("No ha ingresado la fecha del título ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        info_titulos.IdInstitucion = item.IdInstitucion;

                        if (info_titulos.IdInstitucion == null)
                        {
                            MessageBox.Show("No ha ingresado  la institución del título ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        info_titulos.IdTitulo = item.IdTitulo;

                        if (info_titulos.IdTitulo == null)
                        {
                            MessageBox.Show("No ha ingresado  el título ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        info_titulos.Observacion = item.Observacion;

                        if (info_titulos.Observacion == null)
                        {
                            MessageBox.Show("No ha ingresado la observación ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
           
        }

       
        private Boolean ValidaEstudios()
        {
            try
            {
                foreach (var item in obj_estudios)
                    {
                        ro_Empleado_estudios_Info info_estudios = new ro_Empleado_estudios_Info();

                        info_estudios.IdInstitucion = item.IdInstitucion;

                        if (info_estudios.IdInstitucion == null)
                        {
                            MessageBox.Show("No ha ingresado la institución de los estudios ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        info_estudios.IdEstudios = item.IdEstudios;

                        if (info_estudios.IdEstudios == null)
                        {
                            MessageBox.Show("No ha ingresado el estudio realizado  ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        info_estudios.Carrera = item.Carrera;

                        if (info_estudios.Carrera == null)
                        {
                            MessageBox.Show("No ha ingresado el nombre de la carrera  ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        info_estudios.Observacion = item.Observacion;

                        if (info_estudios.Observacion == null)
                        {
                            MessageBox.Show("No ha ingresado la observación ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                    return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }            
        }

        public void pu_CargarRubrosFijos()
        {
            try
            {

                if (txt_idEmpleado.Text == string.Empty)
                {
                    ucRo_NominaTipo.setIdEmpleado(infoEmpleado.IdEmpleado);
                }
                else
                {
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        private void gridViewNomina_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.HitInfo.Column != null)
                {

                    if (e.HitInfo.Column.Name == "colchech")
                    {
                        if (Convert.ToBoolean(gridViewNomina.GetFocusedRowCellValue(colchech)))
                        {
                            gridViewNomina.SetFocusedRowCellValue(colchech, false);
                        }
                        else
                        {
                            gridViewNomina.SetFocusedRowCellValue(colchech, true);
                        }

                        //MessageBox.Show(colchech.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e){}

        private void txt_cedulaRucEmpleado_TextChanged(object sender, EventArgs e){}      

        private void panelTipoDocumento_Leave(object sender, EventArgs e){}

       

        private void txtIdPersona_TextChanged(object sender, EventArgs e){} 

        private void txt_cedulaRucEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //string a = txt_cedulaRucEmpleado.Text;
                    if (funcion.ValidaNumero(e.KeyChar) == true)
                    {
                        MessageBox.Show("Ingrese números");
                        //txt_cedulaRucEmpleado.Text = a;
                    }
                    //      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }  
            
        }


        private void txtIdPersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Para obligar a que sólo se introduzcan números
                    if (Char.IsDigit(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                        if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            //el resto de teclas pulsadas se desactivan
                            e.Handled = true;
                        } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void txt_cedulaRucEmpleado_KeyPress_1(object sender, KeyPressEventArgs e)
      {
          try
          {
               //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    } 
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
              Log_Error_bus.Log_Error(ex.Message);
          }
        }

        private void txt_codigoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    } 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txt_nombresEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //if (Char.IsLetter(e.KeyChar))
                //{
                //    e.Handled = false;
                //}
                //else
                //    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                //    {
                //        e.Handled = false;
                //    }
                //    else
                //    {
                //        //el resto de teclas pulsadas se desactivan
                //        e.Handled = true;
                //    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //if (Char.IsLetter(e.KeyChar))
                //{
                //    e.Handled = false;
                //}
                //else
                //    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                //    {
                //        e.Handled = false;
                //    }
                //    else
                //    {
                //        //el resto de teclas pulsadas se desactivan
                //        e.Handled = true;
                //    } 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }       

        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
              //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
            
        }

        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
            
        }

        private void txt_cedulaMilitar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void txt_numeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
             //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
            
        }

        private void txt_sueldoBasico_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
            
        }

        private void txt_sueldoExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Para obligar a que sólo se introduzcan números
                    if (Char.IsDigit(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                        if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            //el resto de teclas pulsadas se desactivan
                            e.Handled = true;
                        } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
            
        }

        private void txt_movilizaciónQuincenal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
              //Para obligar a que sólo se introduzcan números
                    if (Char.IsDigit(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                        if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            //el resto de teclas pulsadas se desactivan
                            e.Handled = true;
                        } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
            
        }

        private void txt_carnetIess_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
           
        }

        private void panelDepartamento_Paint(object sender, PaintEventArgs e){}

        //Derek 12/12/2013
        private void cmbDivision_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Carga datos combo area 
                infoArea = new List<ro_area_Info>();
                infoArea.Add(new ro_area_Info());
                infoArea.AddRange(busArea.ConsultaPorDivision(param.IdEmpresa,Convert.ToInt32(cmbDivision.EditValue)));
                cmbArea.Properties.DataSource = infoArea;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void cmb_centrocosto_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                //Carga datos combo Sub centro de costos
                infoCCSCC = new List<ct_centro_costo_sub_centro_costo_Info>();
                infoCCSCC.Add(new ct_centro_costo_sub_centro_costo_Info());
                //infoCCSCC.AddRange(busCCSCC.ConsultaxCentroCosto(param.IdEmpresa,Convert.ToString(cmb_centrocosto.EditValue)));
                //cmbSubCentroCosto.Properties.DataSource = infoCCSCC;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void gridViewRubro_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e){}



        private void repositoryItemHyperLinkEdit2_Click(object sender, EventArgs e)
        {
            //Te Declaras un Objeto de Tipo OpenFileDialog
            SaveFileDialog dialogo = new SaveFileDialog();
            try
            {
                dialogo.Filter = "All files (*.*)|*.*";
                dialogo.Title = "Guardar un archivo";

                ro_DocumentoxEmp_Info tempdoc = new ro_DocumentoxEmp_Info();
                tempdoc = (ro_DocumentoxEmp_Info)gridvwDocum.GetFocusedRow();
                byte[] readBuffer = tempdoc.Documento;
                string filname = dialogo.FileName = tempdoc.Dc_Nombre;
                dialogo.InitialDirectory = @"D:\";

                dialogo.ShowDialog();
                //para mostrar el cuadro de seleccion de archivo hacemos asi:
                if (dialogo.FileName != "")
                {
                    if (dialogo.FileName != filname)
                    {
                        dialogo.FileName = dialogo.FileName + tempdoc.tipo;

                        System.IO.File.WriteAllBytes(dialogo.FileName, readBuffer);
                    }
                    else
                        System.IO.File.WriteAllBytes(dialogo.FileName, readBuffer);
                    MessageBox.Show("Descarga exitosa. \n A continuacion se abrira el archivo.", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string command = ("\"" + dialogo.FileName + "\"");

                    System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo.FileName = command;
                    //p.StartInfo.Arguments = "-f E:\\FreeLing-1.5win\\config\\es.cfg < E:\\FreeLing-1.5win\\Text.txt > E:\\FreeLing-1.5win\\Text_parser.txt";
                    p.Start();
                    p.WaitForExit();

                    //Funciones t = new Funciones();
                    //if (t.ExecuteCommand(command) == false)
                    //    MessageBox.Show("Error al abrir archivo.", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Escriba el nombre del archivo a grabar");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }

        }

       

        void CargarGridDatosImp(int AnioIR)
        {
            try
            {
                BLTablaImpuRenta = new BindingList<ro_tabla_Impu_Renta_Info>();
                BLTablaImpuRenta = new BindingList<ro_tabla_Impu_Renta_Info>(TablaImpuRentaBus.ConsultaTablaImpuAnio(AnioIR));
                //gridControlRenta.DataSource = BLTablaImpuRenta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

      



        private void txt_cedulaRucEmpleado_Leave(object sender, EventArgs e)
           {
            try
            {
                string msg = "";

                if (txt_cedulaRucEmpleado.Text != string.Empty /*&& Accion == Cl_Enumeradores.eTipo_action.grabar*/)
                {
                    if (oTb_persona_bus.VericarCedulaExiste(txt_cedulaRucEmpleado.Text, ref  msg))
                    {
                        infoPersona = oTb_persona_bus.Get_Info_Persona(txt_cedulaRucEmpleado.Text);

                        if (oRo_Empleado_Bus.ExisteEmpleado(param.IdEmpresa, infoPersona.IdPersona))
                        {
                            infoEmpleado = oRo_Empleado_Bus.Get_Info_Empleado_vs_Persona(param.IdEmpresa, infoPersona.IdPersona);
                            set_DatosEmpleado(infoEmpleado);
                            //set_Empleado(infoEmpleado);


                            infoPersona = oTb_persona_bus.Get_Info_Persona(txt_cedulaRucEmpleado.Text);
                            set_DatosPersona(infoPersona);

                            Accion = Cl_Enumeradores.eTipo_action.actualizar;
                            // MessageBox.Show("El empleado ya existe", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                            this.txt_idEmpleado.Enabled = false; //el id debe ser secuencial

                            pu_CargarSueldoHistorico();
                            pu_CargaFamiliar();

                            //Ingresa_titulos();
                           
                            pu_GargarEstudios();

                            set_gridDoc();


                            // haac 27/12/2013
                            List<ro_Empleado_TipoNomina_Info> InfoTipoNomina = new List<ro_Empleado_TipoNomina_Info>();
                            InfoTipoNomina = oRo_Empleado_TipoNomina_Bus.Get_List_Empleado_TipoNomina_x_IdEmpleado(param.IdEmpresa, infoEmpleado.IdEmpleado);
                            //this.cmbNomina.Properties.DataSource = InfoTipoNomina;



                        }
                        else
                        {
                            infoPersona = oTb_persona_bus.Get_Info_Persona(txt_cedulaRucEmpleado.Text);
                            set_DatosPersona(infoPersona);
                       
                            infoEmpleado.IdEmpleado = 0;

                            //Datos_TNomina();

                            pu_CargaFamiliar();
                            pu_GargarEstudios();
                            pu_CargarRegistroAcademico();
                            //Datos Personales   
                           
                            this.txt_idEmpleado.Text = "";
                            this.txt_codigoEmpleado.Text = "";
                       
                            //Datos Nomina
                            this.txtCodigoSectorial.Text = "";
                            this.txt_numeroCuenta.Text = "";

                            //Datos Laborales
                            this.cmb_sucursal.Properties.DataSource = sucursalInfo;
                            this.cmbDivision.Properties.DataSource = infoDivision;
                            this.cmbArea.EditValue = "";
                            this.cmb_Cargo.Inicializar_cmb_Cargo();
                            this.cmb_supervisor.Properties.DataSource = InfoSup;



                            gridControlSueldoH.DataSource = null;


                            this.cmb_ctacbleCxp.Properties.DataSource = listaPlan;

                            //Historial de contratos
                            this.gridControlconsult.DataSource = null;
                            //Documentos
                            this.txtRuta.Text = "";
                            this.gridCtrlDocumento.DataSource = null;

                            Accion = Cl_Enumeradores.eTipo_action.grabar;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                            ucGe_Menu.Enabled_bntAnular = false;
                            this.txt_idEmpleado.Enabled = false;
                        }

                    }

                    else
                    {

                        Accion = Cl_Enumeradores.eTipo_action.grabar;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.txt_idEmpleado.Enabled = false;
                        
                        infoEmpleado.IdEmpleado = 0;

                        //Datos_TNomina();

                        pu_CargaFamiliar();
                        pu_GargarEstudios();
                        pu_CargarRegistroAcademico();

                        //Datos Nomina
                        this.txtCodigoSectorial.Text = "";
                        this.txt_numeroCuenta.Text = "";

                        //Datos Laborales
                        this.cmb_sucursal.EditValue = "";
                        this.cmbDivision.EditValue = "";
                        this.cmbArea.EditValue = "";
                        cmb_Cargo.Inicializar_cmb_Cargo();
                        this.cmb_supervisor.EditValue = "";
                    

                        gridControlSueldoH.DataSource = null;


                        this.cmb_ctacbleCxp.EditValue = "";

                        //Historial de contratos
                        this.gridControlconsult.DataSource = null;
                        //Documentos
                        this.txtRuta.Text = "";
                        this.gridCtrlDocumento.DataSource = null;

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }


        }

        private void txt_cedulaRucEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
           //   this.Clean_Controles(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
 
        }

    

        void Inhabilitar_Controles()
        {
            try
            {
         //Datos Personales   
          
                    this.txtIdPersona.Enabled = false;
                    this.txtIdPersona.BackColor = System.Drawing.Color.White;
                    this.txtIdPersona.ForeColor = System.Drawing.Color.Black;

                    this.txt_idEmpleado.Enabled = false;
                    this.txt_idEmpleado.BackColor = System.Drawing.Color.White;
                    this.txt_idEmpleado.ForeColor = System.Drawing.Color.Black;

                    this.txt_codigoEmpleado.Enabled = false;
                    this.txt_codigoEmpleado.BackColor = System.Drawing.Color.White;
                    this.txt_codigoEmpleado.ForeColor = System.Drawing.Color.Black;

                    this.txt_nombresEmpleado.Enabled = false;
                    this.txt_nombresEmpleado.BackColor = System.Drawing.Color.White;
                    this.txt_nombresEmpleado.ForeColor = System.Drawing.Color.Black;

                    this.txtApellido.Enabled = false;
                    this.txtApellido.BackColor = System.Drawing.Color.White;
                    this.txtApellido.ForeColor = System.Drawing.Color.Black;

                    this.txt_Direccion.Enabled = false;
                    this.txt_Direccion.BackColor = System.Drawing.Color.White;
                    this.txt_Direccion.ForeColor = System.Drawing.Color.Black;

                    this.txt_lugarNacimiento.Enabled = false;
                    this.txt_lugarNacimiento.BackColor = System.Drawing.Color.White;
                    this.txt_lugarNacimiento.ForeColor = System.Drawing.Color.Black;

                    this.textEmail.Enabled = false;
                    this.textEmail.BackColor = System.Drawing.Color.White;
                    this.textEmail.ForeColor = System.Drawing.Color.Black;

                    this.txt_telefono.Enabled = false;
                    this.txt_telefono.BackColor = System.Drawing.Color.White;
                    this.txt_telefono.ForeColor = System.Drawing.Color.Black;

                    this.txt_celular.Enabled = false;
                    this.txt_celular.BackColor = System.Drawing.Color.White;
                    this.txt_celular.ForeColor = System.Drawing.Color.Black;

                    this.txt_cedulaMilitar.Enabled = false;
                    this.txt_cedulaMilitar.BackColor = System.Drawing.Color.White;
                    this.txt_cedulaMilitar.ForeColor = System.Drawing.Color.Black;

                    this.txt_cedulaRucEmpleado.Enabled = false;
                    this.txt_cedulaRucEmpleado.BackColor = System.Drawing.Color.White;
                    this.txt_cedulaRucEmpleado.ForeColor = System.Drawing.Color.Black;

                    this.chk_empleadoEspecial.Enabled = false;
                    this.panelSexo.Enabled = false;
                    this.dtp_fechaNacimiento.Enabled = false;

                    this.panelTipoDocumento.Enabled = false;
                    this.panelTipoSangre.Enabled = false;
                    this.panelEstadoCivil.Enabled = false;
                    this.txtTipoLic.Enabled = false;
                   // this.btn_foto.Enabled = false;


                    //Datos Nomina
        

                    this.txtCodigoSectorial.Enabled = false;
                    this.txtCodigoSectorial.BackColor = System.Drawing.Color.White;
                    this.txtCodigoSectorial.ForeColor = System.Drawing.Color.Black;

                    this.txt_numeroCuenta.Enabled = false;
                    this.txt_numeroCuenta.BackColor = System.Drawing.Color.White;
                    this.txt_numeroCuenta.ForeColor = System.Drawing.Color.Black;

                    this.gridViewNomina.OptionsBehavior.Editable = false;
                    //colchech.OptionsColumn.AllowEdit = false;
                    this.panelTipoEmp.Enabled = false;
                    this.dtp_FechaIngresoIESS.Enabled = false;

                    this.dtp_fechaSalida.Enabled = false;
                    this.dtp_fechaTerminoContrato.Enabled = false;
                    //this.cmb_codigoSectorial.Enabled = false;
                    this.cmbBanco.Enabled = false;
                    this.panel_TipoCta.Enabled = false;
                    this.chk_acredita.Enabled = false;

                    //this.chkAcumulaFR.Enabled = false;
                //    this.chk_acreditaTablaSectorial.Enabled = false;
               //     this.chk_beneficios.Enabled = false;


                    //Datos Laborales
                    this.cmb_sucursal.Enabled = false;
                    this.cmbDivision.Enabled = false;
                    this.cmbArea.Enabled = false;
                    this.cmb_Cargo.Enabled = false;
                    this.cmb_supervisor.Enabled = false;
                   // this.panelDepartamento.Enabled = false;

                    //Cargos Familiares
                    this.gridViewCafa.OptionsBehavior.Editable = false;

                    //Informacion academica
                    this.gridViewTitulo.OptionsBehavior.Editable = false;
                    this.gridViewEstu.OptionsBehavior.Editable = false;


                    //Rubros empleado
        
                    this.gridViewRubro.OptionsBehavior.Editable = false;

                    this.gridViewSueldoH.OptionsBehavior.Editable = false;


                    this.cmb_ctacbleCxp.Enabled = false;

                    //Historial de contratos
                    this.gridViewCons.OptionsBehavior.Editable = false;
                    //Documentos
                    this.txtRuta.Enabled = false;

                    this.cmdAbrirDocumento.Enabled = false;

                    this.gridvwDocum.OptionsBehavior.Editable = false;
                                          

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
                 
        }       

        private void gridViewCafa_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                row = (ro_CargaFamiliar_Info)gridViewCafa.GetRow(e.RowHandle);

                if (row != null)
                {
                   if (e.Column.Name == "colTipoFamiliar")               

                    {
                        if (verificar_Conyugue(Convert.ToString(e.Value)))
                        { 
                        
                        }
                                            
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private Boolean verificar_Conyugue(string IdCargaFamiliar)
        {
            try
            {
                var cont = from C in Obj_cafa
                           where C.TipoFamiliar == IdCargaFamiliar
                           select C;

                int cuenta = 0;
                foreach (var item in cont)
                {
                    if (item.TipoFamiliar == "T_CFA04")
                    {
                        cuenta++;                                            
                        //gridViewCafa.DeleteRow(gridViewCafa.FocusedRowHandle);
                        //MessageBox.Show("Ya existe un registro de conyugue ingresado. Se procederá con su eliminación.","Sistemas");
                        //return false;
                    }

                    if(cuenta >1)
                    {
                        gridViewCafa.DeleteRow(gridViewCafa.FocusedRowHandle);
                        MessageBox.Show("Ya existe un registro de conyugue ingresado. Se procederá con su eliminación.", "Sistemas");
                        return false;
                    
                    }
                }       
                  return true;        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString()); return false;
            }
        }
        
        private void gridViewProyeccionGP_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                //Info = new ro_empleado_x_Proyeccion_Gastos_Personales_Info();
                //Info = this.gridViewProyeccionGP.GetFocusedRow() as ro_empleado_x_Proyeccion_Gastos_Personales_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
          

        }    
        
        private void gridViewTitulo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                //row_tit = (ro_empleado_x_titulos_Info)gridViewTitulo.GetRow(e.RowHandle);

                ////if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                ////{
                ////    lista.Add(row);
                ////}

                //if (row != null)
                //{
                //    if (e.Column.Name == "gridTituloempl")
                //    {
                //        if (verificarrepetidos(Convert.ToString(e.Value), true, 1/*, _Accion*/))
                //        {

                //        }
                //    }
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }

        }

        private Boolean verificarrepetidos(string IdTitulo, Boolean eliminar, int tipo /*, Cl_Enumeradores.eTipo_action _Accion*/)
        {
            try
            {
                //if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                //{
                //    ListaBind = new BindingList<cxc_cobro_tipo_Param_conta_x_sucursal_Info>(lista);
                //}

                var cont = from C in ListaBi
                           where C.IdTitulo == IdTitulo
                           select C;
                if (cont.Count() == tipo)
                {
                    return true;
                }
                else
                {
                    if (eliminar == true)
                    {
                        gridViewTitulo.DeleteRow(gridViewTitulo.FocusedRowHandle);
                        MessageBox.Show("El título ya se encuentra ingresado. Se procederá con su eliminación.");
                    }
                    else
                    {

                        MessageBox.Show("El código ya se encuentra ingresado.");
                    }
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString()); return false;
            }

        }

    
        private void frmRo_Empleado_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                if (MessageBox.Show("Desea Salir de la Aplicacion?", "VZEN",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {

                    this.Close();
                }
            }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

    
        private void cmdNuevoSueldo_Click(object sender, EventArgs e)
        {
            try {

                if (infoEmpleado != null)
                {
                    frmRo_Act_SueldoXEmpleado_Mant oFrmRo_Act_SueldoXEmpleado_Mant = new frmRo_Act_SueldoXEmpleado_Mant(infoEmpleado);
                    oFrmRo_Act_SueldoXEmpleado_Mant.pu_CargaInicial();
                    oFrmRo_Act_SueldoXEmpleado_Mant.ShowDialog();
                }
                else {
                    MessageBox.Show("El registro del Empleado no ha sido creado, revise por favor","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }


            }catch (Exception ex){
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }       
      
        private void chkItem_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 txtApellido.Focus();
            gridRubroAcum.Focus();
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }

        }

        private void chkCentroCosto_EditValueChanged(object sender, EventArgs e)
        {
            

            try
            {
                txtApellido.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void ucRo_CentroCosto_event_cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        {
            //int numFilas = gridViewRubro.RowCount;

            //string idCentroCosto=ucRo_CentroCosto.getIdCentroCosto().Trim();

            //                            //RECORRE LAS FILAS
            //for (int i = 0; i < numFilas; i++)
            //{
            //    gridViewRubro.SetRowCellValue(i, colIdCentroCosto, idCentroCosto);
            
            //}
            
        }

        private void ucRo_NominaTipoLiqui_event_cmbNominaTipoLiqui_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            //if (ucRo_NominaTipo.getIdNominaTipo() != null)
            //{

            //    int idNominaTipo = Convert.ToInt32(ucRo_NominaTipo.getIdNominaTipo());
            //    int idNominaTipoLiqui = Convert.ToInt32(ucRo_NominaTipoLiqui.getNominaTipoLiqui());

            //    oBindingListRo_empleado_x_ro_rubro_Info = new BindingList<ro_empleado_x_ro_rubro_Info>(oRo_empleado_x_ro_rubro_Bus.ConsultaRubrosXEmpleadoXNominaLiqui(param.IdEmpresa, infoEmpleado.IdEmpleado, idNominaTipo, idNominaTipoLiqui));
            //    gridControlRubro.DataSource = oBindingListRo_empleado_x_ro_rubro_Info;

            //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }   


        }

        private void cmdImportarImagen_Click(object sender, EventArgs e)
        {
            pu_Abrir_Imagen();
        }

       public Boolean pu_Grabar(ref decimal idEmpleado)
        {
            try
            {
                decimal ID_Perona=0;
                Boolean valorRetornar = false;
                cmbStatus.Focus();

                //OBTENER LOS DATOS DEL EMPLEADO
               if(getEmpleado())
               {
                   //GRABAR EL EMPLEADO
                   infoEmpleado.ListCapacitaciones = ListCapacitaciones.ToList();
                   valorRetornar = oRo_Empleado_Bus.GrabarDB(infoEmpleado, ref idEmpleado, ref ID_Perona, ref MensajeError);
                   txtIdPersona.Text = Convert.ToString(ID_Perona);
               }
               else{
                   MessageBox.Show("Existen errores en la información ingresada, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }

               return valorRetornar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString()); return false;
            }

        }

      

        private void cmdAbrirDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                //Te Declaras un Objeto de Tipo OpenFileDialog
                OpenFileDialog dialogo = new OpenFileDialog();

                dialogo.Filter = "All files (*.*)|*.*";
                dialogo.InitialDirectory = @"C:\";
                //para mostrar el cuadro de seleccion de archivo hacemos asi:

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    fileName = System.IO.Path.GetFileName(dialogo.FileName);

                    path = Path.GetDirectoryName(dialogo.FileName);
                    tipofile = System.IO.Path.GetExtension(dialogo.FileName);
                    txtRuta.Text = path + "\\" + fileName;
                    CargaArchivo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        void frmRo_Empleado_Mant_event_frmRo_MantEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        private void frmRo_Empleado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_MantEmpleado_FormClosing(sender, e);

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }

        }


        private void ucRo_NominaTipo_event_cmbNominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idNominaTipo = Convert.ToInt32(ucRo_NominaTipo.getIdNominaTipo());
                ucRo_NominaTipoLiqui.setIdNominaTipo(idNominaTipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }

        }


        private Boolean pu_ValidarItemRubroFijo() { 
            try{
                Boolean valorDevolver = false;

                if (ucRo_NominaTipo.getIdNominaTipo() != null && ucRo_NominaTipoLiqui.getNominaTipoLiqui()!=null && ucRo_CentroCosto.getIdCentroCosto()!=null && cmbRubro.EditValue!=null)
                {
                    valorDevolver = true;
                }


                return valorDevolver;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString()); 
                return false;
            }
        
        }


        private void pu_AgregarItemRubroFijo() {
            try
            {

                if (pu_ValidarItemRubroFijo())
                {
                    int idNominaTipo = Convert.ToInt32(ucRo_NominaTipo.getIdNominaTipo());
                    int idNomiTipoLiqui = Convert.ToInt32(ucRo_NominaTipoLiqui.getNominaTipoLiqui());
                    string idCentroCosto = ucRo_CentroCosto.getIdCentroCosto();
                    string idRubro = cmbRubro.EditValue.ToString() ;
                    decimal valor = Convert.ToDecimal(txtValor.Text);

                    //BindingList<ro_empleado_x_ro_rubro_Info> oBindingListRo_empleado_x_ro_rubro_Info = (BindingList<ro_empleado_x_ro_rubro_Info>)gridControlRubro.DataSource;

                    ro_empleado_x_ro_rubro_Info item = new ro_empleado_x_ro_rubro_Info();
                    item.IdEmpresa = infoEmpleado.IdEmpresa;
                    item.IdEmpleado = infoEmpleado.IdEmpleado;
                    item.IdNomina_Tipo = idNominaTipo;
                    item.IdNomina_TipoLiqui = idNomiTipoLiqui;
                    item.IdRubro = idRubro;
                    item.IdCentroCosto = idCentroCosto;
                    item.Valor = valor;

                    oBindingListRo_empleado_x_ro_rubro_Info.Add(item);

                }
                else {
                    MessageBox.Show("Existen datos obligatorios, revise por favor","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }



        }


        private void cmdAgregarRubroFijo_Click(object sender, EventArgs e)
        {
            try
            {
                pu_AgregarItemRubroFijo();

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void gridViewRubro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                 if (e.KeyCode.ToString() == "Delete") {
                gridViewRubro.DeleteSelectedRows();
            }
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void gridViewTitulo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                 if (e.KeyCode.ToString() == "Delete")
            {
                gridViewTitulo.DeleteSelectedRows();
            }
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }

        }

        private void gridViewEstu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                 if (e.KeyCode.ToString() == "Delete")
            {
                gridViewEstu.DeleteSelectedRows();
            }
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void gridViewCafa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
            if (e.KeyCode.ToString() == "Delete")
            {
                gridViewCafa.DeleteSelectedRows();
            }
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void pic_foto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                 pu_Abrir_Imagen();
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

      






        private void txt_cedulaRucEmpleado_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string msg = "Cedula No Valida";

                string tipo = UCCatalogo_tipoDoc.get_Catalogo().CodCatalogo;

                string s = UCCatalogo_tipoDoc.get_Catalogo().CodCatalogo;
                if (UCCatalogo_tipoDoc.get_Catalogo().CodCatalogo != "PAS")
                {

                    if (!oTb_persona_bus.Verifica_Ruc(this.txt_cedulaRucEmpleado.Text, ref msg))
                    {
                        MessageBox.Show(msg, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_cedulaRucEmpleado.Text = "";
                        return;
                    }
                }

                if (txt_cedulaRucEmpleado.Text != string.Empty && Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    //EXISTE PERSONA
                    if (oTb_persona_bus.VericarCedulaExiste(txt_cedulaRucEmpleado.Text, ref  msg))
                    {
                        infoPersona = oTb_persona_bus.Get_Info_Persona(txt_cedulaRucEmpleado.Text);
                        set_DatosPersona(infoPersona);
                        //EXISTE EMPLEADO
                        if (oRo_Empleado_Bus.ExisteEmpleado(param.IdEmpresa, infoPersona.IdPersona))
                        {
                            infoEmpleado = oRo_Empleado_Bus.Get_Info_Empleado_x_Persona(param.IdEmpresa, infoPersona.IdPersona);
                            infoEmpleado.InfoPersona = infoPersona;

                            set_Empleado(infoEmpleado);
                            Accion = Cl_Enumeradores.eTipo_action.actualizar;
                            MessageBox.Show("El número de cédula ya está asignado al Empleado: " + infoPersona.pe_nombreCompleto.Trim() + ", continue por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El número de cédula ya existe en nuestra base de datos: " + infoPersona.pe_nombreCompleto.Trim() + ",por favor completar datos para el empleado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }

        }

        private void chkDefault_CheckedChanged(object sender, EventArgs e)
        {
           

            try
            {
                if (Convert.ToBoolean(chkDefault.ValueChecked))
                {
                    //CHEQUEA EL HORARIO
                    viewHorario.SetFocusedRowCellValue(colCheck1, true);

                    foreach (var item in oBindingListRo_Horario_Info)
                    {
                        item.CheckDefault = false;
                    }

                    gridHorario.RefreshDataSource();

                }
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }

        }

        private void viewHorario_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            

            try
            {
                if (e.Column.Name == "colCheckDefault")
                {
                    if (Convert.ToBoolean(chkDefault.ValueChecked))
                    {
                        //                    viewHorario.SetRowCellValue(viewHorario.FocusedRowHandle, viewHorario.Columns["colCheck1"], true);

                        viewHorario.SetRowCellValue(e.RowHandle, viewHorario.Columns["colCheck1"], true);

                    }

                }

                gridHorario.RefreshDataSource();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void cmbTipoAnticipo_EditValueChanged(object sender, EventArgs e)
        {

            try
            {if (cmbTipoAnticipo.EditValue!="")
            {
                if (cmbTipoAnticipo.EditValue.ToString()=="ANT01") {
                    txtValorAnticipo.Text = "0";
                }
            
            }

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }

        }

        private void gridViewCapacitaciones_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {
                    gridViewCapacitaciones.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

     

        private void viewRubroAcum_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colFechaInicio_Acumula")
                {
                    DateTime FechaFin =Convert.ToDateTime( viewRubroAcum.GetFocusedRowCellValue(colFechaInicio_Acumula));
                    int Anio = FechaFin.Year+3;
                    int Mes = FechaFin.Month;
                    int Dia = FechaFin.Day-1;
                   // viewRubroAcum.SetFocusedRowCellValue(colFechaFin_acumula, Convert.ToDateTime(Dia+"/"+Mes+"/"+Anio));
                    
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void cmbAnioFiscal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (cmbAnioFiscal.Text != "")
                    {

                        LisValorGP_x_xAnio = BusValorGP_x_Anio.ConsultaGeneral(Convert.ToInt32(cmbAnioFiscal.Text));
                    }
                    if (LisValorGP_x_xAnio.Count() > 0)
                    {
                        if (LisValorGP_x_xAnio.FirstOrDefault().Monto_max == 0)
                        {
                            if (MessageBox.Show("No Existe Datos Regitrados para el Año Fiscal Selecionado ¿Desea Registrar?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                frmRo_Gastos_Personales_Techo_Mant Frm = new frmRo_Gastos_Personales_Techo_Mant();
                                Frm.ShowDialog();
                            }
                        }
                        else
                        {

                            foreach (var item in LisValorGP_x_xAnio)
                            {
                                ro_empleado_x_Proyeccion_Gastos_Personales_Info info_ = new ro_empleado_x_Proyeccion_Gastos_Personales_Info();
                                info_.IdEmpresa = param.IdEmpresa;
                                info_.IdEmpleado = 0;
                                info_.AnioFiscal = Convert.ToInt32(cmbAnioFiscal.Text);
                                info_.Estado = "A";
                                info_.Fecha_Transac = DateTime.Now;
                                info_.IdUsuario = param.IdUsuario;
                                info_.Monto_max = (int)item.Monto_max;
                                info_.nom_tipo_gasto = item.nom_tipo_gasto;
                                info_.IdTipoGasto = item.IdTipoGasto;

                                ListaGastosPersonales.Add(info_);

                            }
                        }

                    }
                }



                if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    ListaGastosPersonales = new BindingList<ro_empleado_x_Proyeccion_Gastos_Personales_Info>(BusGastosPersonales.Get_List_empleado_x_Proyeccion_Gastos_Personales(param.IdEmpresa, Convert.ToDecimal(txt_idEmpleado.Text), Convert.ToInt32(cmbAnioFiscal.Text)));
                    gridPGP.DataSource = ListaGastosPersonales;
                    if (ListaGastosPersonales.Count() == 0)
                    {
                        LisValorGP_x_xAnio = BusValorGP_x_Anio.ConsultaGeneral(Convert.ToInt32(cmbAnioFiscal.Text));
                        if (LisValorGP_x_xAnio.Count() == 0)
                        {
                            if (MessageBox.Show("No Existe Datos Regitrados para el Año Fiscal Selecionado ¿Desea Registrar?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                frmRo_Gastos_Personales_Techo_Mant Frm = new frmRo_Gastos_Personales_Techo_Mant();
                                Frm.ShowDialog();
                            }
                        }
                        else
                        {

                            foreach (var item in LisValorGP_x_xAnio)
                            {
                                ro_empleado_x_Proyeccion_Gastos_Personales_Info info_ = new ro_empleado_x_Proyeccion_Gastos_Personales_Info();
                                info_.IdEmpresa = param.IdEmpresa;
                                info_.IdEmpleado = Convert.ToInt32(txt_idEmpleado.Text);
                                info_.AnioFiscal = Convert.ToInt32(cmbAnioFiscal.Text);
                                info_.Estado = "A";
                                info_.Fecha_Transac = DateTime.Now;
                                info_.IdUsuario = param.IdUsuario;
                                info_.Monto_max = (int)item.Monto_max;
                                info_.nom_tipo_gasto = item.nom_tipo_gasto;
                                info_.IdTipoGasto = item.IdTipoGasto;

                                ListaGastosPersonales.Add(info_);

                            }
                        }
                        gridPGP.DataSource = ListaGastosPersonales;
                    }

                }
                else
                {
                    gridPGP.DataSource = ListaGastosPersonales;
                }
                if (Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    ListaGastosPersonales = new BindingList<ro_empleado_x_Proyeccion_Gastos_Personales_Info>(BusGastosPersonales.Get_List_empleado_x_Proyeccion_Gastos_Personales(param.IdEmpresa, Convert.ToDecimal(txt_idEmpleado.Text), Convert.ToInt32(cmbAnioFiscal.Text)));
                    gridPGP.DataSource = ListaGastosPersonales;

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void viewRubroAcum_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colFechaInicio_Acumula")
                {
                    DateTime FechaFin = Convert.ToDateTime(viewRubroAcum.GetFocusedRowCellValue(colFechaInicio_Acumula));
                    int Anio = FechaFin.Year + 3;
                    int Mes = FechaFin.Month;
                    int Dia = FechaFin.Day - 1;
                    viewRubroAcum.SetFocusedRowCellValue(colFechaFin_acumula, Convert.ToDateTime(Dia + "/" + Mes + "/" + Anio));


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void viewPGP_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                gridPGP.RefreshDataSource();

                if (e.Column.Name == "colValorPGP")
                {
                    int ValorMax = (int)viewPGP.GetFocusedRowCellValue(ColMonto_max);

                    string ValorIngresado =Convert.ToString( viewPGP.GetFocusedRowCellValue(colValorPGP));
                    int valorIng = Convert.ToInt32(ValorIngresado);
                    if (valorIng > ValorMax)
                   {
                       MessageBox.Show("Error el valor ingresado supera el Estipulado por la Ley");
                       return;
                   }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void viewPGP_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                if (e.Column.Name == "colValorPGP")
                {
                    int ValorMax = (int)viewPGP.GetFocusedRowCellValue(ColMonto_max);

                    string ValorIngresado = Convert.ToString(viewPGP.GetFocusedRowCellValue(colValorPGP));
                    int valorIng = Convert.ToInt32(ValorIngresado);
                    if (valorIng > ValorMax)
                    {
                        MessageBox.Show("Error el valor ingresado supera el Estipulado por la Ley");
                        return;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void gridViewSueldoH_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void gridViewSueldoH_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colSueldoActual")
                {
                    gridViewSueldoH.SetFocusedRowCellValue( colFecha, dtp_FechaIngresoIESS.Value);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void cmbStatus_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string motivo = cmbStatus.EditValue.ToString();
                if (motivo == "EST_VB" || motivo == "EST_PLQ")
                {
                    gp_MotivoSalida.Visible = true;
                }
                else
                {
                    gp_MotivoSalida.Visible = false;

                }

            }
            catch (Exception ex)
            {
             MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void uCct_CentroCosto1_Load(object sender, EventArgs e)
        {

        }

        private void groupControl17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucCon_CentroCosto_ctas_Movi1_Event_cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_subcentro.cargaCmb_SubcentroCostos_x_IdCentroCosto(param.IdEmpresa, cmb_centroCosto.Get_IdCentroCosto());
            }
            catch (Exception ex)
            {
                
                  MessageBox.Show(ex.InnerException.ToString());
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
        
            }
        }

        private void txt_cedulaRucEmpleado_EditValueChanged_1(object sender, EventArgs e)
        {

        }





    }
}

