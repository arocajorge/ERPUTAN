/*CLASE: frmRo_Empleado_Gastos_Personales_Mant
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 03-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Info.SRI;
using Core.Erp.Business.Roles;
using Core.Erp.Business.SRI;

using System.Xml;
using System.Xml.Schema;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;

using Core.Erp.Info.Roles.AGP;
using Core.Erp.Recursos.Properties;

//Derek Mejía Soria 16/12/2013
//Gastos Personales
//Derek Mejía Soria
//ultima modificacion : 08/01/2014
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Empleado_Gastos_Personales_Mant : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; 

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }
        Boolean controlDeGB1 = false;
        Boolean controlDeGB2 = false;
        Boolean controlDeGB3 = false;


        string direcDoc = "";


        //INFO Y BUS
        //*

        //Consulta
        //BindingList<ro_empleado_gastos_perso_Info> DSEmpleadoGP = new BindingList<ro_empleado_gastos_perso_Info>();
        //ro_empleado_gastos_perso_Bus EmpleadoGPBus = new ro_empleado_gastos_perso_Bus();
        //ro_tabla_impu_renta
        BindingList<ro_tabla_Impu_Renta_Info> BLTablaImpuRenta = new BindingList<ro_tabla_Impu_Renta_Info>();
        ro_Tabla_Impu_Renta_Bus TablaImpuRentaBus = new ro_Tabla_Impu_Renta_Bus();
        //empleado
        List<ro_Empleado_Info> empLInfo = new List<ro_Empleado_Info>();
        ro_Empleado_Info empinfo = new ro_Empleado_Info();
        ro_Empleado_Bus empBus = new ro_Empleado_Bus();
        //año
        List<tb_Calendario_Info> calenInfo = new List<tb_Calendario_Info>();
        tb_Calendario_Bus calenBus = new tb_Calendario_Bus();
        //año Imp.Renta
        List<tb_Calendario_Info> calenIRInfo = new List<tb_Calendario_Info>();
        tb_Calendario_Bus calenIRBus = new tb_Calendario_Bus();
        //tipo identificacion
        List<sri_tipoIdentificacion_Info> tipoidenInfo = new List<sri_tipoIdentificacion_Info>();
        sri_tipoIdentificacion_Bus tipoidenBus = new sri_tipoIdentificacion_Bus();
        //provincia
        List<sri_provincia_Info> provInfo = new List<sri_provincia_Info>();
        sri_provincia_Bus provBus = new sri_provincia_Bus();
        //ciudad
        List<sri_ciudad_Info> ciuInfo = new List<sri_ciudad_Info>();
        sri_ciudad_Bus ciuBus = new sri_ciudad_Bus();
        //TipoGasto
        List<sri_tipo_Gasto_Info> tipoGastoInfo = new List<sri_tipo_Gasto_Info>();
        sri_tipo_Gasto_Bus tipoGastoBus = new sri_tipo_Gasto_Bus();
        //Catalogo
        //List<ro_Catalogo_Info> catalogoInfo = new List<ro_Catalogo_Info>();
        //BindingList<ro_Catalogo_Info> CatalogoHijoinfo = new BindingList<ro_Catalogo_Info>();
        //BindingList<ro_Catalogo_Info> CatalogoConyugueinfo = new BindingList<ro_Catalogo_Info>();
        //BindingList<ro_Catalogo_Info> CatalogoDiscapacitadoinfo = new BindingList<ro_Catalogo_Info>();
        //ro_Catalogo_Bus CatalogoBus = new ro_Catalogo_Bus();
        //
        //Carga Familiar
        BindingList<ro_CargaFamiliar_Info> CargaFamHijoinfo = new BindingList<ro_CargaFamiliar_Info>();
        BindingList<ro_CargaFamiliar_Info> CargaFamConyugueinfo = new BindingList<ro_CargaFamiliar_Info>();
        BindingList<ro_CargaFamiliar_Info> CargaFamDiscapacitadoinfo = new BindingList<ro_CargaFamiliar_Info>();
        ro_CargaFamiliar_Bus CargaFamBus = new ro_CargaFamiliar_Bus();
       
        //GASTOS PERSONALES
        ro_empleado_gastos_perso_Info _Info = new ro_empleado_gastos_perso_Info();
        ro_empleado_gastos_perso_Bus GPBus = new ro_empleado_gastos_perso_Bus();
        
        //GASTOS PERSONALES PROVEEDOR
        BindingList<ro_empleado_gastos_perso_x_Gastos_deduci_Info> EGPinfo = new BindingList<ro_empleado_gastos_perso_x_Gastos_deduci_Info>();
        //List<ro_empleado_gastos_perso_x_Gastos_deduci_Info> lstGP = new List<ro_empleado_gastos_perso_x_Gastos_deduci_Info>();
        ro_empleado_gastos_perso_x_Gastos_deduci_Bus EGPbus = new ro_empleado_gastos_perso_x_Gastos_deduci_Bus();
        
        //GASTOS PERSONALES SIN PROVEEDOR
        BindingList<ro_empleado_gastos_perso_x_otros_gast_deduci_Info> EOGPinfo = new BindingList<ro_empleado_gastos_perso_x_otros_gast_deduci_Info>();
        //List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info> LstOGP = new List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info>();
        ro_empleado_gastos_perso_x_otros_gast_deduci_Bus EOGPbus = new ro_empleado_gastos_perso_x_otros_gast_deduci_Bus();

        //frmRo_Empleado_Gastos_Personales_Cons_Identificacion
        frmRo_Empleado_Gastos_Personales_Cons_Identificacion EMGPCI = new frmRo_Empleado_Gastos_Personales_Cons_Identificacion();
        //variable: la uso para q no se me borren los datos ya puestos en los campos
        //int primeravezConsulta = 0;
        //

       //public ro_empleado_gastos_perso_Info SETINFO_ { get; set; }


        string mensaje = "";

        public Boolean getInfo()
        {
            try
            {
                //DATOS GASTOS PERSONALES
                _Info = new ro_empleado_gastos_perso_Info();
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdEmpleado = Convert.ToInt32(cmbEmpleado.EditValue);
                _Info.Anio_fiscal = Convert.ToInt32(cmbAnio.EditValue);
                DateTime FechaActual = Convert.ToDateTime(dtpFecha.EditValue);
                _Info.fecha = Convert.ToDateTime(FechaActual.ToShortDateString());
                _Info.observacion = Convert.ToString(txtObservacion.EditValue);
                _Info.Estado = "A";
                _Info.Tipo_Iden = Convert.ToString(cmbTipoIdentificacion.EditValue);
                _Info.Num_Identificacion = Convert.ToString(txtNumeroIdentificacion.EditValue);
                _Info.Apellidos_Nombres = Convert.ToString(txtApellidoNombre.EditValue);
                _Info.telefono = Convert.ToString(txtTelefono.EditValue);
                _Info.calle_prin = Convert.ToString(txtCallePrincipal.EditValue);
                _Info.Numero = Convert.ToString(txtNumero.EditValue);
                _Info.Intersecion = Convert.ToString(txtInterseccion.EditValue);
                _Info.IdProvincia = Convert.ToString(cmbProvincia.EditValue);
                _Info.IdCidudad = Convert.ToString(cmbCiudad.EditValue);

                return pu_getInfoDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }
        }


        private Boolean pu_getInfoDetalle() {
            try {


                if (_Info != null)
                {

                    foreach (ro_empleado_gastos_perso_x_Gastos_deduci_Info item in EGPinfo)
                    {
                        item.IdEmpresa = _Info.IdEmpresa;
                        item.IdEmpleado = _Info.IdEmpleado;
                        item.Anio_fiscal = _Info.Anio_fiscal;

                        _Info.oListRo_empleado_gastos_perso_x_Gastos_deduci_Info.Add(item);
                    }

                    foreach (ro_empleado_gastos_perso_x_otros_gast_deduci_Info item in EOGPinfo)
                    {
                        item.IdEmpresa = _Info.IdEmpresa;
                        item.IdEmpleado = _Info.IdEmpleado;
                        item.Anio_fiscal = _Info.Anio_fiscal;

                        _Info.oListRo_empleado_gastos_perso_x_otros_gast_deduci_Info.Add(item);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }
        }




        public Boolean setInfo(ro_empleado_gastos_perso_Info info)
        {
            try
            {
                _Info = info;

                //DATOS GASTOS PERSONALES
                cmbEmpleado.EditValue	=	_Info.IdEmpleado	;
                cmbAnio.EditValue	=	_Info.Anio_fiscal;
                dtpFecha.EditValue	=	_Info.fecha;
                txtObservacion.EditValue	=	_Info.observacion;
                cmbTipoIdentificacion.EditValue	=	_Info.Tipo_Iden;
                txtNumeroIdentificacion.EditValue	=	_Info.Num_Identificacion;
                txtApellidoNombre.EditValue	=	_Info.Apellidos_Nombres;
                txtTelefono.EditValue	=	_Info.telefono;
                txtCallePrincipal.EditValue	= _Info.calle_prin;
                txtNumero.EditValue	= _Info.Numero;
                txtInterseccion.EditValue	= _Info.Intersecion;
                cmbProvincia.EditValue	=	_Info.IdProvincia;
                cmbCiudad.EditValue	=	_Info.IdCidudad;

                if (_Info.Estado == "I")
                {
                    lblAnulado.Visible = true;
                }
                else {
                    lblAnulado.Visible = false;                
                }

                //GASTOS PERSONALES PROVEEDOR
                pu_CargarGP(info.IdEmpleado, info.Anio_fiscal);

                //GASTOS PERSONALES SIN PROVEEDOR
                loadxEmpleado(Convert.ToInt32(_Info.IdEmpleado));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }
        }

        public frmRo_Empleado_Gastos_Personales_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            try
            {
                tb_Catalogo_Bus buscatalogo = new tb_Catalogo_Bus();
                List<tb_Catalogo_Info> listsexo = new List<tb_Catalogo_Info>();
                listsexo = buscatalogo.Get_List_Catalogo(Cl_Enumeradores.TipoCatalogo.SEXO);
                cmbSexo.DataSource = listsexo;
                cmbSexo1.DataSource = listsexo;
                cmbSexo2.DataSource = listsexo;


                 pu_CargaInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {

        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        
        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (pu_Guardar())
                {
                    this.Close();
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
                pu_Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            } 
        }




        public void pu_CargaInicial() 
        {
            try
            {
               
                
            //Cargar Empleado
            empLInfo = new List<ro_Empleado_Info>();
            empLInfo.Add(new ro_Empleado_Info());
            empLInfo.AddRange(empBus.Get_List_Empleado_(param.IdEmpresa));
            cmbEmpleado.Properties.DataSource = empLInfo;


            //Cargar año fiscal
            calenInfo = new List<tb_Calendario_Info>();
            calenInfo.Add(new tb_Calendario_Info());
            calenInfo.AddRange(calenBus.ConsultaGeneralGP());
            cmbAnio.Properties.DataSource = calenInfo;
            //Cargar año Fiscal imp.Renta
            calenIRInfo = new List<tb_Calendario_Info>();
            calenIRInfo.Add(new tb_Calendario_Info());
            calenIRInfo.AddRange(calenIRBus.ConsultaGeneralGP());
            //cmbAñoIR.Properties.DataSource = calenInfo;
            //Cargar Tipo de identificacion
            tipoidenInfo = new List<sri_tipoIdentificacion_Info>();
            tipoidenInfo.Add(new sri_tipoIdentificacion_Info());
            tipoidenInfo.AddRange(tipoidenBus.ConsultaSRITipoIdentificacion());
            cmbTipoIdentificacion.Properties.DataSource = tipoidenInfo;
            //Cargar Provincia
            provInfo = new List<sri_provincia_Info>();
            provInfo.Add(new sri_provincia_Info());
            provInfo.AddRange(provBus.ConsultaGeneralProv());
            cmbProvincia.Properties.DataSource = provInfo;
            //Cargar Ciudad General
            ciuInfo = new List<sri_ciudad_Info>();
            ciuInfo.Add(new sri_ciudad_Info());
            ciuInfo.AddRange(ciuBus.ConsultaGeneralCiu());
            cmbCiudad.Properties.DataSource = ciuInfo;
            //Cargar Tipo de Gasto
            tipoGastoInfo = new List<sri_tipo_Gasto_Info>();
            tipoGastoInfo.Add(new sri_tipo_Gasto_Info());
            cmbTipoGasto.Properties.DataSource = tipoGastoInfo; 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }
        
        public void loadxEmpleado(int IdEmpleado) {
            try
            {
                //Encera
                CargaFamHijoinfo = new BindingList<ro_CargaFamiliar_Info>();
                CargaFamConyugueinfo = new BindingList<ro_CargaFamiliar_Info>();
                CargaFamDiscapacitadoinfo = new BindingList<ro_CargaFamiliar_Info>();

                //Cargas Familiares
                CargaFamHijoinfo = new BindingList<ro_CargaFamiliar_Info>(CargaFamBus.Obtener_CargaFamiliarHijo(param.IdEmpresa, IdEmpleado));
                CargaFamConyugueinfo = new BindingList<ro_CargaFamiliar_Info>(CargaFamBus.Obtener_CargaFamiliarConyugue(param.IdEmpresa, IdEmpleado));
                CargaFamDiscapacitadoinfo = new BindingList<ro_CargaFamiliar_Info>(CargaFamBus.Obtener_CargaFamiliarDiscapacitado(param.IdEmpresa, IdEmpleado));

                //ENCERA
                gridControlHijo.DataSource = null;
                gridControlConyuge.DataSource = null;
                gridControlDiscapacitado.DataSource = null;

                gridControlHijo.DataSource = CargaFamHijoinfo;
                gridControlConyuge.DataSource = CargaFamConyugueinfo;
                gridControlDiscapacitado.DataSource = CargaFamDiscapacitadoinfo;

                //if (primeravezConsulta != 0)
                //{           
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    foreach (var item in empLInfo)
                    {
                        if (item.IdEmpleado == IdEmpleado)
                        {
                            txtApellidoNombre.EditValue = item.NomCompleto;
                            txtTelefono.EditValue = item.InfoPersona.pe_telefonoCasa;
                            if (item.InfoPersona.IdTipoDocumento == "RUC")
                            {
                                cmbTipoIdentificacion.EditValue = "R";
                            }
                            else
                            {
                                if (item.InfoPersona.IdTipoDocumento == "PASS")
                                {
                                    cmbTipoIdentificacion.EditValue = "P";
                                }
                                else
                                {
                                    cmbTipoIdentificacion.EditValue = "C";
                                }
                            }
                            txtNumeroIdentificacion.EditValue = item.InfoPersona.pe_cedulaRuc;
                            txtCallePrincipal.EditValue = item.InfoPersona.pe_direccion;
                            break;
                        }
                        //}
                        //primeravezConsulta++;
                    }
                }        
          





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }          
        }



        public void pu_CargarGP(decimal IdEmpleado, int anio) {
            try
            {
               
                EOGPinfo = new BindingList<ro_empleado_gastos_perso_x_otros_gast_deduci_Info>(EOGPbus.Get_List_empleado_gastos_perso_x_otros_gast_deduc(param.IdEmpresa, IdEmpleado, anio));
                if (EOGPinfo != null)
                    //LstOGP = new List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info>(EOGPinfo);
                gridControlOGastosDeducibles.DataSource = EOGPinfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }



        private Boolean pu_Validar() {
            try {

                if (cmbEmpleado.EditValue == null)
                {
                    MessageBox.Show("El Empleado es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (cmbAnio.EditValue == null)
                {
                    MessageBox.Show("El año es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                else
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (EGPbus.consultarAnio(param.IdEmpresa, Convert.ToInt32(cmbEmpleado.EditValue), Convert.ToInt32(cmbAnio.EditValue)) == true)
                        {
                            MessageBox.Show("Debe seleccionar otro año, porque ya existen registrados gastos personales para este período.", "ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            return false;
                        }

                        if (EOGPbus.consultarAnio(param.IdEmpresa, Convert.ToInt32(cmbEmpleado.EditValue), Convert.ToInt32(cmbAnio.EditValue)) == true)
                        {
                            MessageBox.Show("Seleccione otro Año porque ya existen registrados\notros gastos personales en este Año.", "Operación Fallida");
                            return false;
                        }
                    }

                }


                if (cmbProvincia.EditValue == null)
                {
                    MessageBox.Show("El Empleado no tiene registrada la Provincia, revise por favor", "ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return false;
                }

                if (cmbCiudad.EditValue == null)
                {
                    MessageBox.Show("El Empleado no tiene registrada la Ciudad, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }




                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }
        }




        public Boolean pu_Guardar()
        {
            try
            {                
               
               if(pu_Validar()){

                   if (getInfo())
                   {
                       if (GPBus.GuardarBD(_Info, ref mensaje))
                       {
                           _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                           cmbEmpleado.Properties.ReadOnly = true;
                           cmbAnio.Properties.ReadOnly = true;
                           MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                       else {
                           MessageBox.Show("El registro no se pudo guardar, revise por favor: " + mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);        
                       }
                   }
                   else {
                       MessageBox.Show("Existen datos incorrectos, revise por favor: " + mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);        
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
       
        //Delegado
        public delegate void delegate_frmRo_Empleado_Gastos_Personales_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Empleado_Gastos_Personales_Mant_FormClosing event_frmRo_Empleado_Gastos_Personales_Mant_FormClosing;

        private void frmRo_Empleado_Gastos_Personales_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               event_frmRo_Empleado_Gastos_Personales_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
 
        }

        //Metodo para abrir y cerrar groupbox
        private void ultraExpandableGroupBox1_ExpandedStateChanging(object sender, CancelEventArgs e)
        {
            try
            {
                //if (controlDeGB2==false)
                //{
                //     if (ultraExpandableGroupBox1.Expanded == false) {
                //        ultraExpandableGroupBox2.Location = new Point(24, 208);
                //        ultraExpandableGroupBox3.Location = new Point(24, 227);
                //        controlDeGB1 = true;
                //        controlDeGB3 = true;
                //        ultraExpandableGroupBox2.Expanded = false;
                //        ultraExpandableGroupBox3.Expanded = false;
                //        controlDeGB1 = false;
                //        controlDeGB3 = false;
                //    }
                //    else
                //    {
                //        ultraExpandableGroupBox2.Location = new Point(24, 41);
                //        ultraExpandableGroupBox3.Location = new Point(24, 64);                       
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }
                
        private void ultraExpandableGroupBox2_ExpandedStateChanging(object sender, CancelEventArgs e)
        {
            try
            {
                    //if (controlDeGB1==false)
                    //{
                    //    if (ultraExpandableGroupBox2.Expanded == false) {
                    //        ultraExpandableGroupBox1.Location = new Point(24, 15);
                    //        ultraExpandableGroupBox2.Location = new Point(24, 41);
                    //        ultraExpandableGroupBox3.Location = new Point(24, 233);
                    //        controlDeGB2 = true;
                    //        controlDeGB3 = true;
                    //        ultraExpandableGroupBox1.Expanded = false;
                    //        ultraExpandableGroupBox3.Expanded = false;
                    //        controlDeGB2 = false;
                    //        controlDeGB3 = false;
                    //    }
                    //    else
                    //    {              
                    //       ultraExpandableGroupBox3.Location = new Point(24, 64);            
                    //    }
                    //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ultraExpandableGroupBox3_ExpandedStateChanging(object sender, CancelEventArgs e)
        {
            try
            {
                // if (controlDeGB3 == false)
                //{
                //    if (ultraExpandableGroupBox3.Expanded == false)
                //    {
                //        ultraExpandableGroupBox1.Location = new Point(24, 15);
                //        ultraExpandableGroupBox2.Location = new Point(24, 41);
                //        ultraExpandableGroupBox3.Location = new Point(24, 64);
                //        controlDeGB2 = true;
                //        controlDeGB1 = true;
                //        ultraExpandableGroupBox1.Expanded = false;
                //        ultraExpandableGroupBox2.Expanded = false;
                //        controlDeGB2 = false;
                //        controlDeGB1 = false;
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

       private void frmRo_Empleado_Gastos_Personales_Mant_Load(object sender, EventArgs e)
        {
           
            try
            {


                cmbEmpleado.Properties.ReadOnly = true;
                cmbAnio.Properties.ReadOnly = true;


            switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:                        
                        cmbAnio.EditValue = DateTime.Now.Year;
                        gridViewGastosDeducibles.OptionsBehavior.Editable= false;
                        gridViewOGastosDeducibles.OptionsBehavior.Editable = false;
                        dtpFecha.DateTime = param.Fecha_Transac;

                        lblAnulado.Visible = false;
                        cmbEmpleado.Properties.ReadOnly = false;
                        cmbAnio.Properties.ReadOnly = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        //cmbEmpleado.Enabled = false;
                        dtpFecha.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
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


        private Boolean pu_ValidarGP() {
            try {
                if (txtRUC.Text == "")
                {
                    MessageBox.Show("El RUC del Proveedor es obligatorio, revise por favor...", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtRUC.Focus();
                    return false;
                }

                if (txtNumeroComprobantes.Text == "")
                {
                    MessageBox.Show("El No.del Comprobante es obligatorio, revise por favor...", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNumeroComprobantes.Focus();
                    return false;
                }

                if (txtBaseImponible.Text == "")
                {
                    MessageBox.Show("El Valor de la Base Imponible es obligatorio, revise por favor...", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtBaseImponible.Focus();
                    return false;
                }

                if (Convert.ToDouble(txtBaseImponible.Text)<=0)
                {
                    MessageBox.Show("El Valor de la Base Imponible debe ser mayor que cero, revise por favor...", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtBaseImponible.Focus();
                    return false;
                }

                if (cmbTipoGasto.Text == "")
                {
                    MessageBox.Show("El Tipo de Gasto es obligatorio, revise por favor...", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbTipoGasto.Focus();
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }
        }



        private void pu_AgregarGP() {
            try
            {

                if (pu_ValidarGP())
                {
                    SubirGridGD();                
                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        
        }




        private void btnAgregarGD_Click(object sender, EventArgs e)
        {
            pu_AgregarGP();
        }


        Boolean SubirGridGD() {
            try
            {                
                ro_empleado_gastos_perso_x_Gastos_deduci_Info info = new ro_empleado_gastos_perso_x_Gastos_deduci_Info();
              
                info.IdEmpresa = param.IdEmpresa;
                info.IdEmpleado = Convert.ToInt32(cmbEmpleado.EditValue);
                int contador =0;

                foreach (var item in EGPinfo)
	            {
                    contador++;
	            }

                info.Secuencia = contador + 1;
                info.Ruc = Convert.ToString(txtRUC.EditValue);
                info.Num_CbteVta = Convert.ToString(txtNumeroComprobantes.EditValue);
                info.Base_Imponible = Convert.ToDouble(txtBaseImponible.EditValue);
                info.IdTipoGastos = Convert.ToString(cmbTipoGasto.EditValue);
                info.descTipoGasto = Convert.ToString(cmbTipoGasto.Text);
                info.Anio_fiscal = Convert.ToInt32(cmbAnio.EditValue);
                
                EGPinfo.Add(info);
                
                gridControlGastosDeducibles.DataSource = EGPinfo;

                //Encera
                txtRUC.EditValue = "";
                txtNumeroComprobantes.EditValue = "";
                txtBaseImponible.EditValue = "";
                cmbTipoGasto.EditValue = "";                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }        
        }

        private void cmbProvincia_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
             if (cmbProvincia.EditValue != null || cmbProvincia.EditValue != "")
                        {
                            //Cargar Ciudad
                            ciuInfo = new List<sri_ciudad_Info>();
                            ciuInfo.Add(new sri_ciudad_Info());
                            ciuInfo.AddRange(ciuBus.ConsultaGeneralCiuxProv(Convert.ToString(cmbProvincia.EditValue)));
                            cmbCiudad.Properties.DataSource = ciuInfo;
                        }
                        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void pu_AgregarOGD() {
            try
            {
                if (cmbEmpleado.EditValue != null || cmbEmpleado.EditValue != "" || cmbAnio.EditValue == null || cmbAnio.EditValue == "")
                {
                    gridControlOGastosDeducibles.DataSource = null;
                    SubirGridOGD();
                }
                else
                {
                    if (cmbEmpleado.EditValue != null || cmbEmpleado.EditValue != "")
                    {
                        MessageBox.Show("Seleccione un empleado", "Mensaje");
                    }
                    else
                    {
                        MessageBox.Show("Seleccione Año", "Mensaje");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        
        }


        private void btnAgregarOGD_Click(object sender, EventArgs e)
        {
            try
            {
                pu_AgregarOGD();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        Boolean SubirGridOGD()
        {
            try
            {
                ro_empleado_gastos_perso_x_otros_gast_deduci_Info info = new ro_empleado_gastos_perso_x_otros_gast_deduci_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.IdEmpleado = Convert.ToInt32(cmbEmpleado.EditValue);
                int contador = 0;
                foreach (var item in EOGPinfo)
                {
                    contador++;
                }
                info.secuencia = contador + 1;
                info.Valor_no_cub_x_aseg = Convert.ToDouble(txtValornoCubierto.EditValue);
                info.Valor_Pension_alim = Convert.ToDouble(txtPensionAlimenticia.EditValue);        
                info.Anio_fiscal = Convert.ToInt32(cmbAnio.EditValue);
                EOGPinfo.Add(info);
                gridControlOGastosDeducibles.DataSource = EOGPinfo;

                //Encera
                txtValornoCubierto.EditValue = "";
                txtPensionAlimenticia.EditValue = "";                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void btn_guardarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (pu_Guardar() == true)
                {
                    Close();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }           
        }

        private void pu_NuevoConyuge() {
            try
            {
                //frmRo_Empleado_Gastos_Personales_Cons_Identificacion EMGPCI = new frmRo_Empleado_Gastos_Personales_Cons_Identificacion();
                EMGPCI = new frmRo_Empleado_Gastos_Personales_Cons_Identificacion();
                EMGPCI.event_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing += new frmRo_Empleado_Gastos_Personales_Cons_Identificacion.delegate_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing(frm_event_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing);
                EMGPCI.IdEmpresa = param.IdEmpresa;
                EMGPCI.IdEmpleado = Convert.ToDecimal(cmbEmpleado.EditValue);
                EMGPCI.Idcatalogo = 20;
                List<ro_CargaFamiliar_Info> info = new List<ro_CargaFamiliar_Info>(CargaFamConyugueinfo);
                EMGPCI.SEtInfo(info);
                EMGPCI.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }       
        
        }



        private void btnNuevoConyu_Click(object sender, EventArgs e)
        {
                 
        }

        private void frm_event_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
            //load();
            try
            {
                loadxEmpleado(Convert.ToInt32(cmbEmpleado.EditValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }            
        }

        private void pu_NuevoHijo() {
            try
            {
                //frmRo_Empleado_Gastos_Personales_Cons_Identificacion EMGPCI = new frmRo_Empleado_Gastos_Personales_Cons_Identificacion();
                EMGPCI = new frmRo_Empleado_Gastos_Personales_Cons_Identificacion();
                EMGPCI.event_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing += new frmRo_Empleado_Gastos_Personales_Cons_Identificacion.delegate_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing(frm_event_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing);
                EMGPCI.IdEmpresa = param.IdEmpresa;
                EMGPCI.IdEmpleado = Convert.ToDecimal(cmbEmpleado.EditValue);
                EMGPCI.Idcatalogo = 36;
                List<ro_CargaFamiliar_Info> info = new List<ro_CargaFamiliar_Info>(CargaFamHijoinfo);
                EMGPCI.SEtInfo(info);
                EMGPCI.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            } 
        
        }


        private void btnNuevoHijo_Click(object sender, EventArgs e)
        {
            
        }

        private void pu_NuevoDiscapacitado() {
            try
            {
                //frmRo_Empleado_Gastos_Personales_Cons_Identificacion EMGPCI = new frmRo_Empleado_Gastos_Personales_Cons_Identificacion();
                EMGPCI = new frmRo_Empleado_Gastos_Personales_Cons_Identificacion();
                EMGPCI.event_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing += new frmRo_Empleado_Gastos_Personales_Cons_Identificacion.delegate_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing(frm_event_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing);
                EMGPCI.IdEmpresa = param.IdEmpresa;
                EMGPCI.IdEmpleado = Convert.ToDecimal(cmbEmpleado.EditValue);
                EMGPCI.Idcatalogo = 21;
                List<ro_CargaFamiliar_Info> info = new List<ro_CargaFamiliar_Info>(CargaFamDiscapacitadoinfo);
                EMGPCI.SEtInfo(info);
                EMGPCI.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }        
        }


        private void btnNuevoDiscapacitado_Click(object sender, EventArgs e)
        {
           
        }



        int anio = 0;
        int no = 0;
        private void cmbAnio_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (cmbAnio.EditValue != null || cmbAnio.EditValue != "")
            //    {
            //        if (lstGP.Count != 0 || LstOGP.Count != 0)
            //        {
            //            if (no == 0)
            //            {
            //                var result = MessageBox.Show("Esta seguro de cambiar el Año,\n si decide cambiar se perderan los cambios realizados", "Advertencia",
            //                    MessageBoxButtons.YesNo,
            //                    MessageBoxIcon.Question);

            //                if (result == System.Windows.Forms.DialogResult.Yes)
            //                {
            //                    pu_CargarGP(Convert.ToInt32(cmbEmpleado.EditValue), Convert.ToInt32(cmbAnio.EditValue));
            //                    anio = Convert.ToInt32(cmbAnio.EditValue);
            //                    lstGP = new List<ro_empleado_gastos_perso_x_Gastos_deduci_Info>();
            //                    LstOGP = new List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info>();
            //                }
            //                else
            //                {
            //                    no++;
            //                    cmbAnio.EditValue = anio;
            //                    no = 0;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            pu_CargarGP(Convert.ToInt32(cmbEmpleado.EditValue), Convert.ToInt32(cmbAnio.EditValue));
            //            anio = Convert.ToInt32(cmbAnio.EditValue);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Log_Error_bus.Log_Error(ex.ToString());
            //}
        }

        private void gridViewGastosDeducibles_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pu_QuitarGP();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void gridViewOGastosDeducibles_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                 if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       

                        pu_QuitarOGP();
                    }             
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        
        }

        private void txtNumeroIdentificacion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeroIdentificacion.EditValue != null || txtNumeroIdentificacion.EditValue !="")
                {
                    tb_persona_bus bus = new tb_persona_bus();
                    string mens = "";

                    if (!bus.Verifica_Ruc(Convert.ToString(txtNumeroIdentificacion.EditValue), ref mens))
                    {
                        MessageBox.Show(mens, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void txtRUC_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRUC.EditValue != null || txtRUC.EditValue != "")
                {
                    string numero = Convert.ToString(txtRUC.EditValue);
                    if (numero.Length == 10 || (numero.Length > 10 && numero.Length < 13))
                    {
                        tb_persona_bus bus = new tb_persona_bus();
                        string mens = "";

                        if (!bus.Verifica_Ruc(Convert.ToString(txtRUC.EditValue), ref mens))
                        {
                            MessageBox.Show(mens, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        //private gastosPersonales CargaDatos()
        //{
        //    try
        //    {

        //        gastosPersonales Data = new gastosPersonales();

        //        Data.identificacion = "0918051392";
        //        Data.nombresApellidos = "luis yanza";
        //        Data.tipoIdentificacion = "C";
        //        Data.dirCalle = "PRINCIPAL";
        //        Data.dirNumero = "15";
        //        Data.dirInterseccion = "INTERSECCION";
        //        Data.dirProvincia = "108";
        //        Data.dirCanton = "10801";
        //        Data.telefono = "062908578";
        //        Data.periodoFiscal = "2008";

        //        //detallesHijosDependientes
                
        //        List<detallesHijosDependientes> Detallehijo = new List<detallesHijosDependientes>();

        //        detallesHijosDependientes ItemDetallehijo = new detallesHijosDependientes();

        //        ItemDetallehijo.identificacion="0924953858001";
        //        ItemDetallehijo.nombres="derek";
        //        ItemDetallehijo.tipoIdentificacion="R";                

        //        Detallehijo.Add(ItemDetallehijo);

        //        //detalleConyugueDependiente

        //        List<detalleConyugueDependiente> DetalleConyugue = new List<detalleConyugueDependiente>();

        //        detalleConyugueDependiente ItemDetalleConyugue = new detalleConyugueDependiente();

        //        ItemDetalleConyugue.identificacion="0924953858001";
        //        ItemDetalleConyugue.nombres="Maria";
        //        ItemDetalleConyugue.tipoIdentificacion="C";                

        //        DetalleConyugue.Add(ItemDetalleConyugue);

        //        //detalleDiscapacitadosDependientes

        //        List<detalleDiscapacitadosDependientes> DetalleDiscapacitados = new List<detalleDiscapacitadosDependientes>();

        //        detalleDiscapacitadosDependientes ItemDetalleDiscapacitados = new detalleDiscapacitadosDependientes();

        //        ItemDetalleDiscapacitados.identificacion = "0924953858001";
        //        ItemDetalleDiscapacitados.nombres = "Fernando";
        //        ItemDetalleDiscapacitados.tipoIdentificacion = "F";

        //        DetalleDiscapacitados.Add(ItemDetalleDiscapacitados);

        //        //detalleGasto
        //        List<detalleGasto> DetalleGasto = new List<detalleGasto>();

        //        foreach (var item in EGPinfo)
        //        {
        //            detalleGasto ItemDetalleGasto = new detalleGasto();

        //            ItemDetalleGasto.rucProveedor = item.Ruc;
        //            ItemDetalleGasto.totalComprobantesVenta = Convert.ToDecimal(item.Num_CbteVta);
        //            ItemDetalleGasto.totalBaseImponible = Convert.ToDecimal(item.Base_Imponible);
        //            ItemDetalleGasto.tipoGasto = Convert.ToInt32(item.IdTipoGastos);
        //            DetalleGasto.Add(ItemDetalleGasto);
        //        }

        //        //detalleRubrosNoIdentificanProveedor
        //        List<detalleRubrosNoIdentificanProveedor> DetalleOGasto = new List<detalleRubrosNoIdentificanProveedor>();

        //        foreach (var item in EOGPinfo)
        //        {
        //            detalleRubrosNoIdentificanProveedor ItemDetalleOGasto = new detalleRubrosNoIdentificanProveedor();

        //            ItemDetalleOGasto.totalPencionesAlimenticias = Convert.ToDecimal(item.Valor_Pension_alim);
        //            ItemDetalleOGasto.totalValoresAseguradoras = Convert.ToDecimal(item.Valor_no_cub_x_aseg);
        //            DetalleOGasto.Add(ItemDetalleOGasto);
        //        }

        //        //
        //        Data.conyugueDependiente = DetalleConyugue;
        //        Data.hijosDependientes = Detallehijo;
        //        Data.discapacitadosDependientes = DetalleDiscapacitados;
        //        Data.gastos = DetalleGasto;
        //        Data.rubrosNoIdentificanProveedor = DetalleOGasto;              

        //        return Data;

        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //        MessageBox.Show(ex.Message);

        //    }

        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

                gastosPersonales DataGastos = new gastosPersonales();

                //DataGastos = CargaDatos();
                DataGastos = empBus.Get_GastosPersonales_x_Empleado(param.IdEmpresa, Convert.ToInt32(cmbEmpleado.EditValue), Convert.ToInt32(cmbAnio.EditValue));


                string ruta = "";
                saveFileDialog1.FileName = "prueba.xml";
                saveFileDialog1.Filter = "All files (*.xml)|*.xml";
                saveFileDialog1.InitialDirectory = @direcDoc;

                this.saveFileDialog1.ShowDialog();
                ruta = saveFileDialog1.FileName;                

                if (SerializeToXML(DataGastos, ruta))
                {
                   




                }
                else
                {
                    //progressBar1.Value = 0;
                    MessageBox.Show("Ocurrio un inconveniente al guardar el archivo ATS XML", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }
        //

        static public Boolean SerializeToXML(gastosPersonales data, string ruta)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(gastosPersonales));
                TextWriter textWriter = new StreamWriter(@ruta);
                serializer.Serialize(textWriter, data);
                textWriter.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //06/01/2014 Derek Mejía Soria
        private void cmbAñoIR_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    CargarGridDatosImp(Convert.ToInt32(cmbAñoIR.EditValue));
            //}
            //catch (Exception ex)
            //{
            //    Log_Error_bus.Log_Error(ex.ToString());
            //}
        }

        //void CargarGridDatosImp(int AnioIR) {
        //    try
        //    //{
        //    //    BLTablaImpuRenta = new BindingList<ro_tabla_Impu_Renta_Info>();
        //    //    BLTablaImpuRenta = new BindingList<ro_tabla_Impu_Renta_Info>(TablaImpuRentaBus.ConsultaTablaImpuAnio(AnioIR));
        //    //    gridControlRenta.DataSource = BLTablaImpuRenta; 
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
            
        //}

        private void frmRo_Empleado_Gastos_Personales_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
            }
        }

        private void cmdAgregarGP_Click(object sender, EventArgs e)
        {
            try
            {
                pu_AgregarGP();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);

            }
        }

        private void cmdAgregarOGP_Click(object sender, EventArgs e)
        {
            
            try
            {
                pu_AgregarOGD();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);

            }
        }

        private void cmdNuevoConyuge_Click(object sender, EventArgs e)
        {
           

            try
            {
                pu_NuevoConyuge();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);

            }
        }

        private void cmdNuevoHijo_Click(object sender, EventArgs e)
        {
           
            try
            {
                pu_NuevoHijo();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);

            }
        }

        private void cmdNuevoDiscapacitado_Click(object sender, EventArgs e)
        {
            
            try
            {
                pu_NuevoDiscapacitado();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        private void pu_QuitarGP() {
            try {

                if (EGPinfo.Count>0)
                {
                    ro_empleado_gastos_perso_x_Gastos_deduci_Info item = (ro_empleado_gastos_perso_x_Gastos_deduci_Info)this.gridViewGastosDeducibles.GetFocusedRow();
                    EGPinfo.Remove(item);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        private void pu_QuitarOGP()
        {
            try
            {

                if (EOGPinfo.Count > 0)
                {
                    ro_empleado_gastos_perso_x_otros_gast_deduci_Info item = (ro_empleado_gastos_perso_x_otros_gast_deduci_Info)this.gridViewOGastosDeducibles.GetFocusedRow();
                    EOGPinfo.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void cmdQuitarGP_Click(object sender, EventArgs e)
        {
            pu_QuitarGP();
        }

        private void cmdQuitarOGP_Click(object sender, EventArgs e)
        {
            pu_QuitarOGP();
        }


   


        //private void cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //         if (cmbEmpleado.EditValue !=null || cmbEmpleado.EditValue != "")
        //    {
        //        //if (lstGP.Count != 0 || LstOGP.Count != 0)
        //        //{
        //            //if (no == 0)
        //            //{
        //            //    var result = MessageBox.Show("Esta seguro de cambiar de empleado,\n si decide cambiar se perderan los cambios realizados", "Advertencia",
        //            //        MessageBoxButtons.YesNo,
        //            //        MessageBoxIcon.Question);

        //            //    if (result == System.Windows.Forms.DialogResult.Yes)
        //            //    {
        //                    //loadxEmpleado(Convert.ToInt32(cmbEmpleado.EditValue));
        //                    //empleado = Convert.ToInt32(cmbEmpleado.EditValue);
        //                    //lstGP = new List<ro_empleado_gastos_perso_x_Gastos_deduci_Info>();
        //                    //LstOGP = new List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info>();
        //                //}
        //                //else
        //                //{
        //                    //no++;
        //                    //cmbEmpleado.EditValue = empleado;
        //                    //no = 0;
        //        //        }           
        //        //    }
        //        //}
        //        //else
        //        //{

        //            loadxEmpleado(Convert.ToInt32(cmbEmpleado.EditValue));

        //            //empleado = Convert.ToInt32(cmbEmpleado.EditValue);
        //        //}
        //    }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());              
        //    }

        // }


        //private void cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbEmpleado.EditValue != null || cmbEmpleado.EditValue != "")
        //        {
        //            loadxEmpleado(Convert.ToInt32(cmbEmpleado.EditValue));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}


        private void cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpleado.EditValue != null || cmbEmpleado.EditValue != "")
                {
                    loadxEmpleado(Convert.ToInt32(cmbEmpleado.EditValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }




    }
}
