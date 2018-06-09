
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using System.Diagnostics;
using Core.Erp.Recursos.Properties;
using Core.Erp.Reportes.Roles;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Generacion_Archivos_Transferencia : Form
    {
        #region Declaración de Variables
        XROL_Rpt011_Bus oReporteBus = new XROL_Rpt011_Bus();
        List<XROL_Rpt011_Info> oListado = new List<XROL_Rpt011_Info>();
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Nomina_Tipo_Bus Bus_TipoNo = new ro_Nomina_Tipo_Bus();
        ro_periodo_Bus Bus_Periodo = new ro_periodo_Bus();
        ro_Empleado_Bus OEmplBus = new ro_Empleado_Bus();
        ro_Nomina_Tipoliqui_Bus Bus_TipoNominaLiqui = new ro_Nomina_Tipoliqui_Bus();
        ro_Catalogo_Bus Bus_Catalogo= new ro_Catalogo_Bus();
        ro_Archivo_Bancos_Generacion_Detalle_Bus bus_archivo = new ro_Archivo_Bancos_Generacion_Detalle_Bus();
        ro_Archivos_Bancos_Generacion_Bus oRo_Archivos_Bancos_Generacion_Bus = new ro_Archivos_Bancos_Generacion_Bus();
        List<ro_Catalogo_Info> lista_catalogo = new List<ro_Catalogo_Info>();
        public ro_Archivos_Bancos_Generacion_Info _Info = new ro_Archivos_Bancos_Generacion_Info();
        tb_banco_Bus oTb_banco_Bus = new tb_banco_Bus();
        List<string> listabancos = new List<string>();
        List<string> listatipoCuenta = new List<string>();


        


        
         ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();


        
        List<tb_banco_Info> lstBanco = new List<tb_banco_Info>();

        tb_banco_Info Info_Banco = new tb_banco_Info();


        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        public ro_Empleado_Info oRo_Empleado_Info = new ro_Empleado_Info();
        ro_division_Bus Bus_Division = new ro_division_Bus();
        public delegate void delegate_frmRo_Generacion_Archivos_Transferencia_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Generacion_Archivos_Transferencia_FormClosing event_frmRo_Generacion_Archivos_Transferencia_FormClosing;

        tb_banco_procesos_bancarios_x_empresa_Info info_proceso_Bancario = new tb_banco_procesos_bancarios_x_empresa_Info();
        ba_Banco_Cuenta_Info info_Cuenta_Banco = new ba_Banco_Cuenta_Info();


        // CARGAR txt
        OpenFileDialog ofdDoc;//txt
        SaveFileDialog sfdDoc;//txt
        byte[] readBuffer;//txt
        string borrar = "";
        //
        int A = 0;
        string fileName = "";
        string path = "";
        string tipofile = "";
        string borrar1 = "";

        //int _idNominaTipo = 0;
        //int _idNominaTipoLiqui = 0;
        //int _idPeriodo = 0;
        string mensaje = "";
       
      
        
        //INFO
        BindingList<ro_Rol_Detalle_Info> oListro_Rol_Detalle_Info = new BindingList<ro_Rol_Detalle_Info>();

        //BUS
        ro_Rol_Detalle_Bus oRo_Rol_Detalle_Bus = new ro_Rol_Detalle_Bus();
        ro_archivos_bancos_generacion_x_empleado_Bus oRo_archivos_bancos_generacion_x_empleado_Bus = new ro_archivos_bancos_generacion_x_empleado_Bus();

        #endregion

        public frmRo_Generacion_Archivos_Transferencia()
        {
            try
            {
                InitializeComponent();
                ucBa_Proceso_x_Banco1.cmb_Banco.EditValueChanged += cmb_Banco_EditValueChanged;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmRo_Generacion_Archivos_Transferencia_FormClosing += frmRo_Generacion_Archivos_Transferencia_event_frmRo_Generacion_Archivos_Transferencia_FormClosing;
                
                ofdDoc = new OpenFileDialog();
                sfdDoc = new SaveFileDialog();

                ofdDoc.InitialDirectory = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);
                sfdDoc.InitialDirectory = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);

                ofdDoc.Filter = "(*.txt, *.biz)|*.txt;*.biz";
                //sfdDoc.Filter = "(*.txt)|*.txt";
                sfdDoc.Filter = "(*.txt, *.biz)|*.txt;*.biz";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
                    
        }

        void cmb_Banco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tb_banco_Info info_banco = new tb_banco_Info();
                if (ucBa_Proceso_x_Banco1.get_BaCuentaInfo().CodigoLegal == "34") 
                {
                    
                        List<ro_Catalogo_Info> info_catalogo = new List<ro_Catalogo_Info>();
                        ro_Catalogo_Bus bus_catalogo = new ro_Catalogo_Bus();
                        info_catalogo = bus_catalogo.Get_List_Catalogo_x_Tipo(38);

                        txtCodEmpresa.EditValue = info_catalogo.FirstOrDefault().CodCatalogo;
                    
                }
            }
            catch (Exception ex)
            {


            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Imprimir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }       
        }

        private void pu_Imprimir()
        {
            try
            {
                XROL_Rpt011_Bus oReporteBus = new XROL_Rpt011_Bus();
                List<XROL_Rpt011_Info> oListado = new List<XROL_Rpt011_Info>();

                XROL_Rpt011_rpt reporte = new XROL_Rpt011_rpt();
                 oListado = oReporteBus.GetListPorArchivo(param.IdEmpresa,Convert.ToInt32(cmbnomina.EditValue),Convert.ToInt32( cmbnominaTipo.EditValue),Convert.ToInt32(cmbPeriodos.EditValue));
                 reporte.Set_Listado(oListado);
                 reporte.ShowRibbonPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                pu_Grabar();
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            
        }

        void frmRo_Generacion_Archivos_Transferencia_event_frmRo_Generacion_Archivos_Transferencia_FormClosing(object sender, FormClosingEventArgs e){}

       public  void pu_CargarDatos()
        {
            try
            {
                // Cargando combo Bancos
                lstBanco = oTb_banco_Bus.Get_List_Banco();                               
                // cargarTipoCuenta
                lista_catalogo = Bus_Catalogo.Get_List_Catalogo_x_Tipo(9);

                // Cargando Combo Division
                List<ro_division_Info> InfoDivision = new List<ro_division_Info>();
                InfoDivision = Bus_Division.ConsultaGeneral(param.IdEmpresa);
                this.cmbDivision.Properties.DataSource = InfoDivision;
                // cargar Nomina
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;

                if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.EDEHSA)
                {
                    lista_catalogo = Bus_Catalogo.Get_List_Catalogo_x_Tipo(36);
                    if (lista_catalogo.Count > 0)
                    {
                        txtCodEmpresa.Text = lista_catalogo.FirstOrDefault().CodCatalogo;
                    }
                }
              

               

                foreach (var item in lstBanco)
                {
                    listabancos.Add(item.ba_descripcion);
                }


                foreach (var item in lista_catalogo)
                {
                    listatipoCuenta.Add(item.CodCatalogo);
                }

                // nuevos combos
                chkCombo_Bancos.Properties.DataSource = listabancos;
                chkCombo_Cuentas.Properties.DataSource = listatipoCuenta;



                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        A = 1;

                        this.txtIdArchivo.Enabled = false;
                        this.txtIdArchivo.BackColor = System.Drawing.Color.White;
                        this.txtIdArchivo.ForeColor = System.Drawing.Color.Black;

                         this.txtRuta.Enabled = false;
                         this.txtRuta.BackColor = System.Drawing.Color.White;
                         this.txtRuta.ForeColor = System.Drawing.Color.Black;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntImprimir = true;
                    
                        this.txtIdArchivo.Enabled = false;
                        this.txtIdArchivo.BackColor = System.Drawing.Color.White;
                        this.txtIdArchivo.ForeColor = System.Drawing.Color.Black;
             
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntImprimir = false;

                     this.txtIdArchivo.Enabled = false;
                     this.txtIdArchivo.BackColor = System.Drawing.Color.White;
                     this.txtIdArchivo.ForeColor = System.Drawing.Color.Black;

                     //setInfo();
                   
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        A = 2;
                        
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntImprimir = true;

                                                
                   
                     this.txtIdArchivo.Enabled = false;
                     this.txtIdArchivo.BackColor = System.Drawing.Color.White;
                     this.txtIdArchivo.ForeColor = System.Drawing.Color.Black;


                

                  
                    this.cmbDivision.Enabled = false;
                    this.cmbDivision.BackColor = System.Drawing.Color.White;
                    this.cmbDivision.ForeColor = System.Drawing.Color.Black;

                     this.txtCodEmpresa.Enabled = false;
                     this.txtCodEmpresa.BackColor = System.Drawing.Color.White;
                     this.txtCodEmpresa.ForeColor = System.Drawing.Color.Black;

                     this.txtRuta.Enabled = false;
                     this.txtRuta.BackColor = System.Drawing.Color.White;
                     this.txtRuta.ForeColor = System.Drawing.Color.Black;

                     this.btnDestino.Enabled = false;
                     this.dteFecha.Enabled = false;


                     this.gridViewEmpleado.OptionsBehavior.Editable = false;



                    break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }                                              
          
        }

        public void setInfo(ro_Archivos_Bancos_Generacion_Info info)
        {
            try
            {
                _Info = info;

                txtIdArchivo.EditValue = _Info.IdArchivo;
                cmbnomina.EditValue = _Info.IdNomina;
                cmbnominaTipo.EditValue = _Info.IdNominaTipo;
                cmbPeriodos.EditValue = _Info.IdPeriodo;
                ucBa_Proceso_x_Banco1.SetIdBanco(Convert.ToInt32( _Info.IdBanco));
                ucBa_Proceso_x_Banco1.SetIdProceso(_Info.IdProceso_Bancario);
                cmbDivision.EditValue = _Info.IdDivision;
                txtNomArchivo.Text = _Info.Nom_Archivo;
                txtCodEmpresa.EditValue = _Info.Cod_Empresa;
                dteFecha.EditValue = _Info.Fecha_Genera;
                readBuffer = _Info.Archivo;


                oListro_Rol_Detalle_Info = new BindingList<ro_Rol_Detalle_Info>(oRo_Rol_Detalle_Bus.GetListConsultaGeneralPorRubro(_Info.IdEmpresa, _Info.IdNomina, _Info.IdNominaTipo, _Info.IdPeriodo, Convert.ToInt32( _Info.IdArchivo)));
                gridControlEmpleado.DataSource = oListro_Rol_Detalle_Info;

                int totemP = oListro_Rol_Detalle_Info.Count();
                lbTotal_empleados.Text = totemP + "  Empleados considerados para el pago del periodo actual";
                /*
                pu_CargarNomina();

                setDetalle();

                pu_ObtenerTotalSeleccionados();
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     
        public frmRo_Generacion_Archivos_Transferencia(Cl_Enumeradores.eTipo_action Numerador)
             : this()
         {
             try
             {
                   enu = Numerador;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
                 Log_Error_bus.Log_Error(ex.ToString());
             }           
        }

        private void frmRo_Generacion_Archivos_Transferencia_Load(object sender, EventArgs e)
         {
             try
             {
                 dteFecha.EditValue = DateTime.Now;

             
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
                 Log_Error_bus.Log_Error(ex.ToString());
             }

             
        }

        private void cmbTipoNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (cmbTipoNomina.EditValue != null)
                //{
                //    int numero;
                //    numero = Convert.ToInt32(cmbTipoNomina.EditValue);
                //    // Cargando Combo Proceso 
                //    List<ro_Nomina_Tipoliqui_Info> InfoNominaTipoliqui = new List<ro_Nomina_Tipoliqui_Info>();
                //    InfoNominaTipoliqui = Bus_TipoNominaLiqui.ObtenerLstxNomina_Tipo(param.IdEmpresa, numero);
                //    this.cmbTipoProceso.Properties.DataSource = InfoNominaTipoliqui;
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void pu_CargarArchivo(string ruta)
        {
            try
            {
                info_Cuenta_Banco = ucBa_Proceso_x_Banco1.get_BaCuentaInfo();
                info_proceso_Bancario = ucBa_Proceso_x_Banco1.get_Proceso_Info();


                string a = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string nom_archivo ="";

                string rutaTemp = a + "/" + nom_archivo + ".biz";


                //NOMBRE AUTOMATICO


                sfdDoc.FileName = oRo_Archivos_Bancos_Generacion_Bus.pu_GenerarNombreArchivo(Convert.ToDecimal(txtIdArchivo.Text == "" ? 1 : Convert.ToDecimal(txtIdArchivo.Text)), info_Cuenta_Banco, info_proceso_Bancario,Convert.ToDateTime(dteFecha.EditValue), cmbDivision.EditValue == null ? "" : cmbDivision.Text.Trim());
                nom_archivo = sfdDoc.FileName;
                if (sfdDoc.ShowDialog() == DialogResult.OK)
                {

                    if (File.Exists(sfdDoc.FileName))
                    {
                        File.Delete(sfdDoc.FileName);
                    }

                    Generar_Archivo_Transferencia();


                    try
                    {
                        readBuffer = System.IO.File.ReadAllBytes(sfdDoc.FileName);
                    }
                    catch (Exception)
                    {
                        
                        
                    }
                    if(readBuffer==null)
                        readBuffer=new byte[000];
                    MessageBox.Show("El archivo se genero correctamente en: " + sfdDoc.FileName,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtNomArchivo.Text = nom_archivo;
                    txtRuta.Text = sfdDoc.FileName;
                    txtRuta.EditValue = sfdDoc.FileName;
                    if (MessageBox.Show("Desea ver el Archivo...?", "INFORMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                       Process.Start(sfdDoc.FileName);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     
        public Boolean getInfo()
        {
            try
            {
                _Info.oListRo_archivos_bancos_generacion_x_empleado_Info = new List<ro_archivos_bancos_generacion_x_empleado_Info>();
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdNomina = Convert.ToInt32(cmbnomina.EditValue);
                _Info.IdNominaTipo = Convert.ToInt32(cmbnominaTipo.EditValue);
                _Info.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                _Info.IdBanco = Convert.ToString(ucBa_Proceso_x_Banco1.get_BaCuentaInfo().IdBanco);
                _Info.IdProceso_Bancario = Convert.ToString(ucBa_Proceso_x_Banco1.get_Proceso_Info().IdProceso_bancario_tipo);
                _Info.IdDivision = Convert.ToInt32(this.cmbDivision.EditValue);
                _Info.Cod_Empresa = Convert.ToString(this.txtCodEmpresa.EditValue);
                _Info.Nom_Archivo = this.txtNomArchivo.Text.Trim();
                _Info.Archivo = readBuffer;
                _Info.Fecha_Genera = Convert.ToDateTime(this.dteFecha.EditValue);
                if (txtIdArchivo.Text != "")
                {
                    _Info.IdArchivo = Convert.ToInt32(txtIdArchivo.Text);
                }
                else
                {
                    _Info.IdArchivo = 0;
                }
                _Info.IdBanco_Acredita =ucBa_Proceso_x_Banco1.get_BaCuentaInfo().IdBanco;
                _Info.pe_FechaIni = listadoPeriodo.Where(v => v.IdPeriodo == _Info.IdPeriodo).FirstOrDefault().pe_FechaIni;


                if (oListro_Rol_Detalle_Info.Count > 0)
                {
                    txtCodEmpresa.Focus();

                    //ELIMINA REGISTROS PREVIOS

                    //RECORRE LA GRILLA
                    foreach (ro_Rol_Detalle_Info item in oListro_Rol_Detalle_Info)
                    {
                        //VERIFICA LOS REGISTROS SELECCIONADOS
                        if (Convert.ToBoolean(item.check))
                        {
                            ro_archivos_bancos_generacion_x_empleado_Info info = new ro_archivos_bancos_generacion_x_empleado_Info();
                            info.IdEmpresa = _Info.IdEmpresa;
                            info.IdArchivo = _Info.IdArchivo;
                            info.IdEmpleado = item.IdEmpleado;
                            info.Valor =Convert.ToDouble( item.PendientePago);
                            info.pagacheque = Convert.ToBoolean(item.pagacheque);
                            _Info.oListRo_archivos_bancos_generacion_x_empleado_Info.Add(info);

                        }
                    }

                }

                _Info.Archivo = StreamFile(txtRuta.EditValue.ToString());


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }  
            
                              
       }        

     
        public void pu_Grabar()
        {
            try
            {
                decimal id = 0;
              
                if (pu_Validar())
                {
                    if (getInfo())
                    {
                        decimal Id = 0;
                        string mensaje = "";

                        if (oRo_Archivos_Bancos_Generacion_Bus.GrabarBD(_Info, ref id, ref mensaje))
                        {

                            txtIdArchivo.Text = id.ToString();
                            _Info.IdArchivo = id;

                            
                                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                            
                          
                        }
                        else
                            MessageBox.Show("El registro no se pudo guardar, revise por favor: " , "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
          
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
           
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {

         
            
                          

        }

        private void groupBox3_Enter(object sender, EventArgs e){}

        private void gridViewEmpleado_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (A == 2)
                {
                    check.OptionsColumn.AllowEdit = false;
                                
                }

                if (A == 1)
                {
                                   
                    if ((bool)gridViewEmpleado.GetFocusedRowCellValue(check))
                    {

                        gridViewEmpleado.SetFocusedRowCellValue(check, false);
                    }
                    else
                    {
                        gridViewEmpleado.SetFocusedRowCellValue(check, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbPeriodo_EditValueChanged(object sender, EventArgs e){}

        Boolean pu_Validar()
        {

            try
            {
                if (this.dteFecha.EditValue == null)
                {
                    MessageBox.Show("Ingrese la Fecha de Generación, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dteFecha.Focus();
                    return false;
                }
              
                if (this.txtCodEmpresa.EditValue == null)
                {
                    MessageBox.Show("Debe ingresar el  Código de la Empresa proporcionado por la Institución Financiera, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtCodEmpresa.Focus();
                        return false;
                }

                if (this.gridViewEmpleado.RowCount == 0)
                {
                    MessageBox.Show("Genere la carga de los Empleados, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }


                if (ucBa_Proceso_x_Banco1.get_BaCuentaInfo() == null)
                {
                    MessageBox.Show("Debe ingresar el Banco es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }


                       
                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }

        private void frmRo_Generacion_Archivos_Transferencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               event_frmRo_Generacion_Archivos_Transferencia_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
       public void CrearPdfTemp()
        {
            try
            {            
                string a = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string rutaTemp = a + "/" + _Info.Nom_Archivo;//JUNTANDO Y HACIENDO UN SOLO PATH

                if (File.Exists(rutaTemp))
                    File.Delete(rutaTemp);

                File.WriteAllBytes(rutaTemp, _Info.Archivo);
                Process.Start(rutaTemp);
                borrar1 = rutaTemp;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void frmRo_Generacion_Archivos_Transferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnDestino_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (pu_Validar())
                {

                    pu_CargarArchivo(Convert.ToString(txtRuta.EditValue));

                    string dir = this.txtRuta.Text;

                   string[] parts = dir.Split('\\');
                    foreach (string part in parts)
                    {
                        Console.WriteLine(part);

                        this.txtNomArchivo.Text = part;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void pu_CargarNomina() 
        {
            try
            {
                List<string> bancosTmp = new List<string>();
                List<string> CuentasTmp = new List<string>();

                foreach (var item in chkCombo_Bancos.Properties.Items.GetCheckedValues().ToList())
                {
                    bancosTmp.Add(item.ToString());
                }


                foreach (var item in chkCombo_Cuentas.Properties.Items.GetCheckedValues().ToList())
                {
                    CuentasTmp.Add(item.ToString());
                }

         
                if(cmbDivision.EditValue!=null )
                {
                   
                        oListro_Rol_Detalle_Info = new BindingList<ro_Rol_Detalle_Info>(oRo_Rol_Detalle_Bus.GetListConsultaGeneralPorRubro(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue), Convert.ToInt32(cmbPeriodos.EditValue),Convert.ToInt32( cmbDivision.EditValue), "950",bancosTmp,CuentasTmp, ref mensaje));

                }
                else
                {
                    oListro_Rol_Detalle_Info = new BindingList<ro_Rol_Detalle_Info>(oRo_Rol_Detalle_Bus.GetListConsultaGeneralPorRubro(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue), Convert.ToInt32(cmbPeriodos.EditValue), "950", bancosTmp, CuentasTmp, ref mensaje));
                   
                }

                if (cmb_Departamento.get_departamentoInfo() != null)
                {
                   // oListro_Rol_Detalle_Info = new BindingList<ro_Rol_Detalle_Info>(oRo_Rol_Detalle_Bus.GetListConsultaGeneralPorRubro(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue), Convert.ToInt32(cmbPeriodos.EditValue), "950", ref mensaje).Where(v=>v.IdDepartamento==cmb_Departamento.get_departamentoInfo().IdDepartamento).ToList());

                }


                ro_periodo_x_ro_Nomina_TipoLiqui_Info info_Peiodo  =(ro_periodo_x_ro_Nomina_TipoLiqui_Info) cmbPeriodos.Properties.View.GetFocusedRow();
                if(info_Peiodo!=null)
                {

                if (info_Peiodo.pe_FechaFin.Month == 12 && info_Peiodo.pe_FechaIni.Month == 1)
                {
                    oListro_Rol_Detalle_Info = new BindingList<ro_Rol_Detalle_Info>(oRo_Rol_Detalle_Bus.GetListConsultaGeneralPorRubroDivision(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue), Convert.ToInt32(cmbPeriodos.EditValue), "550", _Info.IdDivision, ref mensaje));
                   
                }
                }

                /*
                if (Info_Banco != null)
                {
                    if(Info_Banco.IdBanco!=0)
                    oListro_Rol_Detalle_Info = new BindingList<ro_Rol_Detalle_Info>(oListro_Rol_Detalle_Info.Where(v => v.CodigoLegal == Info_Banco.CodigoLegal).ToList());
                }
                if (cmb_tipo_cuenta.EditValue != null && cmbBanco.EditValue != "")
                    oListro_Rol_Detalle_Info = new BindingList<ro_Rol_Detalle_Info>(oListro_Rol_Detalle_Info.Where(v => v.TipoCuenta == cmb_tipo_cuenta.EditValue.ToString().Trim()).ToList());
                gridControlEmpleado.DataSource = oListro_Rol_Detalle_Info;
                */


                gridControlEmpleado.DataSource = oListro_Rol_Detalle_Info;


                if (oListro_Rol_Detalle_Info.Count() == 0)
                    MessageBox.Show("No hay datos para la consulta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }

        private void cmbPeriodo_event_cmbPeriodo_EditValueChanged(object sender, EventArgs e)
        {
            //pu_CargarNomina();
        }

        private void Generar_Archivo_Transferencia() 
        {
            try
            {
                ro_Archivos_Bancos_Generacion_Bus oRo_Archivos_Bancos_Generacion_Bus = new ro_Archivos_Bancos_Generacion_Bus();
                _Info.rutaArchivo = sfdDoc.FileName;
                _Info.ro_rol_detalle.Clear();

                if (oListro_Rol_Detalle_Info.Count() == 0)
                {
                    MessageBox.Show("No hay Datos ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;

                }
                else
                {
                    if (oListro_Rol_Detalle_Info.Where(v => v.check == true).Count() == 0)
                    {
                        MessageBox.Show("No ha seleccionado ningun registro ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                }

                info_Cuenta_Banco = ucBa_Proceso_x_Banco1.get_BaCuentaInfo();
                info_proceso_Bancario = ucBa_Proceso_x_Banco1.get_Proceso_Info();

                _Info.ro_rol_detalle = oListro_Rol_Detalle_Info.Where(v => v.check == true && v.pagacheque == false).ToList();

                foreach (var item in oListro_Rol_Detalle_Info)
                {
                    item.Valor =Convert.ToDouble( item.PendientePago);
                }
                bus_archivo.GrabarBD(_Info.ro_rol_detalle, info_Cuenta_Banco, info_proceso_Bancario,_Info.rutaArchivo, "", txtCodEmpresa.EditValue.ToString(), ref mensaje);                                      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }       
        }

       

        private void setDetalle() {
            try
            {

                if (oListro_Rol_Detalle_Info.Count > 0) {

                    List<ro_archivos_bancos_generacion_x_empleado_Info> listado = new List<ro_archivos_bancos_generacion_x_empleado_Info>();
                    listado = oRo_archivos_bancos_generacion_x_empleado_Bus.GetListConsultaPorIdArchivo(_Info.IdEmpresa, _Info.IdArchivo);

                    foreach (ro_Rol_Detalle_Info item in oListro_Rol_Detalle_Info)
                    {
                        foreach(var item2 in listado){
                            if(item.IdEmpleado==item2.IdEmpleado){
                                item.check=true;
                                break;
                            }
                        
                        }

                    }               
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }          
        }

        private double pu_ObtenerTotalSeleccionados() {
            try {
                int num_empleados = 0;
                double valorDevolver = 0;

                foreach (ro_Rol_Detalle_Info item in oListro_Rol_Detalle_Info)
                {
                    if (Convert.ToBoolean(item.check))
                    {
                        valorDevolver += item.Valor;
                        num_empleados += 1;
                    }
                }

              //  txtTotal.Text = valorDevolver.ToString("N2");
                lbTotal_empleados.Text = num_empleados + "  Empleados considerados para el pago del periodo actual";
                return valorDevolver;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return 0;
            }  
        }

        private void gridViewEmpleado_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                pu_ObtenerTotalSeleccionados();


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void chkIncluir_CheckedChanged(object sender, EventArgs e)
        {
            
            try
            {
                pu_ObtenerTotalSeleccionados();
                txtCodEmpresa.Focus();
                gridControlEmpleado.Focus();
            }
            catch (Exception ex)
            {
                
             MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Limpiar()
        {
            try
            {
                cmbDivision.EditValue=null;
                txtNomArchivo.Text="";
                txtRuta.Text="";
              //  txtTotal.Text="";
                gridControlEmpleado.DataSource = null;
                cmbPeriodos.EditValue = null;
                cmbnominaTipo.EditValue = null;
                cmbnominaTipo.EditValue = null;
                txtCodEmpresa.Text = "";
                txtIdArchivo.Text = "";
                pu_CargarDatos();

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridControlEmpleado_Click(object sender, EventArgs e)
        {

        }
        
        private void cmbBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tb_banco_Info info_banco = new tb_banco_Info();
               
                if (info_banco == null)
                {
                    info_banco = lstBanco.Where(v => v.CodigoLegal == _Info.IdBanco).FirstOrDefault();
                }
                if (info_banco.CodigoLegal == "34")
                {
                   List< ro_Catalogo_Info> info_catalogo = new List<ro_Catalogo_Info>();
                    ro_Catalogo_Bus bus_catalogo = new ro_Catalogo_Bus();
                    info_catalogo = bus_catalogo.Get_List_Catalogo_x_Tipo(38);

                    txtCodEmpresa.EditValue = info_catalogo.FirstOrDefault().CodCatalogo;
                }

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            pu_CargarNomina();
            pu_ObtenerTotalSeleccionados();
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                if (enu == Cl_Enumeradores.eTipo_action.grabar)
                {
                    cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
                }
                else
                {
                    cmbPeriodos.Properties.DataSource = listadoPeriodo;
                }
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

       


        public byte[] StreamFile(string filename)
        {
            try
            {

               // FileStream fs = new FileStream(System.Diagnostics.Process.Start(System.IO.Path.GetFullPath(filename)).ToString(), FileMode.Open, FileAccess.Read);



                string s = "@"+filename;

                FileStream fs = new FileStream(filename.Trim(), FileMode.Open, FileAccess.Read);
                byte[] ImageData = new byte[fs.Length];
                fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                return ImageData; //return the byte data


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return new byte[000];

            }
        }

        private void chkCombo_Bancos_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnImprimirSoporte_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewEmpleado.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                
                                MessageBox.Show(ex.ToString());

            }
        }

    }
}
