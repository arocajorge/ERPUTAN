using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar.Archivos_Pagos_Bancos;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Winform.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Core.Erp.Business.CuentasxPagar.Archivos_Bancos;
using Core.Erp.Info.Bancos.Archivos_PreAviso_x_Banco;
namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_GeneracionFile_Banco_x_cxp_Mant : Form
    {
        string Estado_Transferencia_OP = "";

        #region variables
        string codigo_archivo = "";
        string nombre_file = "";
        int IdArchivo = 0;
        string MensajeError = "";
        bool ba_si_genero_Archivo = true;


        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        ba_Banco_Cuenta_Info InfoBanco = new Info.Bancos.ba_Banco_Cuenta_Info();     
        // bus
        ba_Banco_Cuenta_Bus Cuentas_x_Bancos_BUS = new ba_Banco_Cuenta_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        vwcp_orden_pago_con_cancelacion_Bus Pagos_Bus = new vwcp_orden_pago_con_cancelacion_Bus();
        cp_Archivo_Banco_Pichincha_Pago_Bus Generar_Archivo_Bus_BP = new cp_Archivo_Banco_Pichincha_Pago_Bus();
        cp_Archivo_Banco_Guayaquil_Pago_Bus Generar_Archivo_Bus_BG = new cp_Archivo_Banco_Guayaquil_Pago_Bus();
        cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus Generar_Archivo_Bus_BB = new cp_Archivo_Banco_Bolivariano_pago_proveedores_Bus();

        ba_Archivo_Transferencia_Bus Archivo_Bus = new Business.Bancos.ba_Archivo_Transferencia_Bus();
        ba_Archivo_Transferencia_Det_Bus Archivo_Detalle_Bus = new Business.Bancos.ba_Archivo_Transferencia_Det_Bus();

        tb_persona_bus Persona_bus = new tb_persona_bus();
        tb_Empresa_Bus Empresa_B = new tb_Empresa_Bus();
        tb_Empresa_Info Empresa_Info = new tb_Empresa_Info();
        ba_Catalogo_Bus Catalo_Banco_Bus = new ba_Catalogo_Bus();
        
        //listas
        List<vwcp_orden_pago_con_cancelacion_Info> list = new List<vwcp_orden_pago_con_cancelacion_Info>();
        BindingList<ba_Archivo_Transferencia_Det_Info> BindingList_Archivo_Detalle = new BindingList<ba_Archivo_Transferencia_Det_Info>();
        BindingList<ba_Archivo_Transferencia_Det_Info> BindingList_Archivo_Detalle_x_Cheq = new BindingList<ba_Archivo_Transferencia_Det_Info>();



        ba_Archivo_Transferencia_Info Archivo_Info = new Info.Bancos.ba_Archivo_Transferencia_Info();
        List< ba_Banco_Cuenta_Info> ListasCtasBanco = new List< Info.Bancos.ba_Banco_Cuenta_Info>();
        List<tb_Empresa_Info> lisEmp = new List<tb_Empresa_Info>();
        List<ba_Banco_Cuenta_Info> ListaCuentasBancarias = new List<ba_Banco_Cuenta_Info>();
        List<ba_Catalogo_Info> List_Catalo_Bancos = new List<ba_Catalogo_Info>();
        List<Secuencial_registro_x_persona> list_secuencial_x_Persona = new List<Secuencial_registro_x_persona>();

        // info
        ba_Banco_Cuenta_Info Cuenta_Destino_Info= new ba_Banco_Cuenta_Info();
        tb_Empresa_Info Empresa_Destino_Info =new tb_Empresa_Info();

        List<tb_banco_procesos_bancarios_x_empresa_Info> lst_procesos_bancarios = new List<tb_banco_procesos_bancarios_x_empresa_Info>();
        tb_banco_procesos_bancarios_x_empresa_Bus bus_procesos_bancarios = new tb_banco_procesos_bancarios_x_empresa_Bus();


        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus BusTipoCbte_x_CbteCble = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info InfoTipoCbte_x_CbteCble = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();



        ba_Cbte_Ban_Bus BusCbteBan = new ba_Cbte_Ban_Bus();
        List<ba_Cbte_Ban_Info> ListCbteBan = new List<ba_Cbte_Ban_Info>();

        tb_banco_procesos_bancarios_x_empresa_Info Proceso_Info = new tb_banco_procesos_bancarios_x_empresa_Info();
        public ebanco_procesos_bancarios_tipo Tipo_Proceso { get; set; }


        List<tb_banco_Info> lista_bancos = new List<tb_banco_Info>();
        tb_banco_Bus bus_bancos = new tb_banco_Bus();
        #endregion 

        #region delegados

        public delegate void Delegate_frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing event_frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing;


        #endregion

        public frmCP_GeneracionFile_Banco_x_cxp_Mant()
        {
            InitializeComponent();
            ucBa_Proceso_x_Banco.cmbProceso.EditValueChanged += cmbProceso_EditValueChanged;
            ucBa_Proceso_x_Banco.cmb_Banco.EditValueChanged += cmb_Banco_EditValueChanged;
            event_frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing += frmCP_GeneracionFile_Banco_x_cxp_Mant_event_frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing;
            
        }

        void frmCP_GeneracionFile_Banco_x_cxp_Mant_event_frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void cmb_Banco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucBa_Proceso_x_Banco.get_BaCuentaInfo().CodigoLegal == "17")
                {
                    txtNombreArc.Enabled = false;
                }
                else
                {
                    txtNombreArc.Enabled = true;

                }
          
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_proceso()
        {
            try
            {
                Proceso_Info = ucBa_Proceso_x_Banco.get_Proceso_Info();
                txtNombreArc.Properties.ReadOnly = false;
                if ( Proceso_Info.cod_Proceso == ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BOL)
                {
                    if (!tabControlDetalle.TabPages.Contains(tabPageOP))
                    {
                        tabControlDetalle.TabPages.Add(tabPageOP);

                    }

                    if (tabControlDetalle.TabPages.Contains(tabPagePreavisoCheq))
                    {
                        tabControlDetalle.TabPages.Remove(tabPagePreavisoCheq);

                    }

                    if (tabControlDetalle.TabPages.Contains(tabPageTrasnferencia))
                    {
                        tabControlDetalle.TabPages.Remove(tabPageTrasnferencia);    
                    }                    
                }

               else
                {
                    if (tabControlDetalle.TabPages.Contains(tabPageTrasnferencia))
                    {
                        tabControlDetalle.TabPages.Remove(tabPageTrasnferencia);

                    }

                    if (tabControlDetalle.TabPages.Contains(tabPagePreavisoCheq))
                    {
                        tabControlDetalle.TabPages.Remove(tabPagePreavisoCheq);

                    }

                    if (!tabControlDetalle.TabPages.Contains(tabPageOP))
                    {
                        tabControlDetalle.TabPages.Add(tabPageOP);
                    }
                    if (Proceso_Info.IdProceso_bancario_tipo == "PAGO_PROVEEDORES_BOL")
                    {
                        txtNombreArc.Properties.ReadOnly = true;
                        switch (Accion)
                        {
                            case Cl_Enumeradores.eTipo_action.grabar:
                                txtSecuencial.Text = Archivo_Detalle_Bus.Get_Secuencial_registro_BB(param.IdEmpresa, "PAGO_PROVEEDORES_BOL").ToString();
                                break;
                            case Cl_Enumeradores.eTipo_action.actualizar:
                                txtSecuencial.Text = Archivo_Detalle_Bus.Get_secuencial_registro_BB_modificar(param.IdEmpresa, "PAGO_PROVEEDORES_BOL", Convert.ToDecimal(txtId.Text == "" ? "0" : txtId.Text)).ToString();
                                break;
                        }
                    }
                }

                if (Proceso_Info.Tipo_Proc == "PREAV_CHQ")
                {

                    if (tabControlDetalle.TabPages.Contains(tabPageTrasnferencia))
                    {
                        tabControlDetalle.TabPages.Remove(tabPageTrasnferencia);

                    }

                    if (tabControlDetalle.TabPages.Contains(tabPageOP))
                    {
                        tabControlDetalle.TabPages.Remove(tabPageOP);
                    }


                    if (!tabControlDetalle.TabPages.Contains(tabPagePreavisoCheq))
                    {
                        tabControlDetalle.TabPages.Add(tabPagePreavisoCheq);

                    }
                   
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cmbProceso_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Set_proceso();
                limpiar();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_GeneracionFile_Banco_x_cxp_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                Cargar_Bancos();

                if (Accion == 0) { Accion = Cl_Enumeradores.eTipo_action.grabar; }
               
                Empresa_Info = Empresa_B.Get_Info_Empresa(param.IdEmpresa);

                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                cmbRuta.Text=filePath+@"\";

                ucBa_Proceso_x_Banco.cargar_CuentaBanco();
                Cargar_Datos();

                dtpFechadesde.Value = DateTime.Now.AddMonths(-1);
                dtpFechaHasta.Value = DateTime.Now.AddDays(+1);


                InfoTipoCbte_x_CbteCble = BusTipoCbte_x_CbteCble.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(param.IdEmpresa).FirstOrDefault(v => v.CodTipoCbteBan == "CHEQ");
                dtpFechadesde_cheq.Value = DateTime.Now.AddMonths(-1);
                dtpFechaHasta_cheq.Value = DateTime.Now.AddMonths(1);

                
                if (Accion == 0) { Accion = Cl_Enumeradores.eTipo_action.grabar; }
                Set_Accion_in_controls();

               
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cargar_Datos()
        {
            try
            {
                lisEmp = Empresa_B.Get_List_Empresa();
                ultraCmbE_empresaDest.Properties.DataSource = lisEmp;
                ultraCmbE_empresaDest.Properties.DisplayMember = "em_nombre";
                ultraCmbE_empresaDest.Properties.ValueMember = "IdEmpresa";
                ultraCmbE_empresaDest.EditValue = param.IdEmpresa;

                List_Catalo_Bancos = Catalo_Banco_Bus.Get_List_Catalogo("MOT_FIL_BA");
                cmb_Motivo_Transferencia.Properties.DataSource = List_Catalo_Bancos;
                cmb_Motivo_Transferencia.EditValue = "MTFI_PG_PV";//Parametrizar luego, se hizo en Naturisa

                
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void BuscarOP()
        {
            try
            {
                decimal IdArchivo = 0;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                    IdArchivo = Convert.ToDecimal(txtId.Text);

                BindingList_Archivo_Detalle = new BindingList<ba_Archivo_Transferencia_Det_Info>();
                list = Pagos_Bus.Get_List_orden_pago_con_transferencia(param.IdEmpresa,IdArchivo, dtpFechadesde.Value, dtpFechaHasta.Value,param.IdUsuario);
                if (list.Count() == 0)
                {
                    MessageBox.Show("No hay registro para la consulta", param.Nombre_sistema,
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                foreach (var item in list)
                {
                    ba_Archivo_Transferencia_Det_Info Detalle_Info = new Info.Bancos.ba_Archivo_Transferencia_Det_Info();
                    if (BindingList_Archivo_Detalle.Where(v => v.IdOrdenPago == item.IdOrdenPago).ToList().Count() == 0)
                    {
                        Detalle_Info.IdOrdenPago =(int) item.IdOrdenPago;
                        Detalle_Info.IdEmpresa = item.IdEmpresa;
                        Detalle_Info.Valor = Convert.ToDecimal(item.Valor_estimado_a_pagar_OP);
                        Detalle_Info.Beneficiario = item.Nom_Beneficiario;
                        Detalle_Info.fecha_op = item.Fecha_OP;
                        Detalle_Info.IdOrdenPago =Convert.ToInt32( item.IdOrdenPago);
                        Detalle_Info.IdPersona = item.IdPersona;
                        Detalle_Info.Observacion_op = item.Observacion;
                        Detalle_Info.Estado_OP = item.IdEstadoAprobacion;
                        Detalle_Info.IdEmpresa_OP = item.IdEmpresa;
                        Detalle_Info.Secuencia_OP =(int) item.Secuencia_OP;
                        Detalle_Info.IdTipo_Persona = item.IdTipoPersona;
                        Detalle_Info.Estado_Transferencia = item.Estado_Transferencia;
                        Detalle_Info.IdTipo_Persona = item.IdTipoPersona;
                        Detalle_Info.IdEntidad =Convert.ToInt32( item.IdEntidad);
                        //Detalle_Info.nom_banco_destino = item.Beneficiario.ba_descripcion;
                        Detalle_Info.pe_cedulaRuc = item.Beneficiario.pe_cedulaRuc;
                        Detalle_Info.num_cta_acreditacion = item.Beneficiario.num_cta_acreditacion;
                        Detalle_Info.IdTipoCta_acreditacion_cat = item.Beneficiario.IdTipoCta_acreditacion_cat;
                        Detalle_Info.IdTipoDocumento = item.Beneficiario.IdTipoDocumento;
                        Detalle_Info.CodigoLegal = item.Beneficiario.CodigoLegal;
                        Detalle_Info.Referencia = item.Referencia2;
                        //Detalle_Info.IdBanco_cta_Destino_trans = item.IdBanco_acreditacion;
                        Detalle_Info.check = item.Check;
                        BindingList_Archivo_Detalle.Add(Detalle_Info);
                        
                    }
                }
                gridControlDetalleOP.DataSource = BindingList_Archivo_Detalle;
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRuta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (FolderBrowserDialog dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "Select a folder";
                    if (dlg.ShowDialog() == DialogResult.OK)                       
                    {
                        
                        cmbRuta.Text = dlg.SelectedPath +@"\";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        public bool GenerarArchivo()
        {
            try
            {
              int IdCodigoLegalBanco = Convert.ToInt32(ucBa_Proceso_x_Banco.get_BaCuentaInfo().CodigoLegal);
              Tipo_Proceso = ucBa_Proceso_x_Banco.get_Proceso_Info().cod_Proceso;
              switch (IdCodigoLegalBanco)
              {
                  case 10://BANCO DEL PICHINCHA
                      switch (Tipo_Proceso)
	                    {
                            case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BP:
                              return  FileBPichincha_PagoProveedores();
                            case ebanco_procesos_bancarios_tipo.TRANSF_BANCARIA_BP:
                              return FileBPichincha_PagoProveedores();
                        
                        default:
                           return false;
	                     }
                      break;
                  case 17://BANCO DE guayaquil
                      switch (Tipo_Proceso)
                      {
                          case ebanco_procesos_bancarios_tipo.ROL_ELECTRONICO_BG:
                             return File_BGuayaquil_PagosCta_Virtuales();
                          case ebanco_procesos_bancarios_tipo.NCR:
                             return File_BGuayaquil_PagoProveedores_Otros_Banco();
                          case ebanco_procesos_bancarios_tipo.PAGOS_MULTICASH:
                           return File_BGuayaquil_PagoProveedores_Mismo_Banco();
                          default:
                              MessageBox.Show("No existe Programacion para el proceso seleccionado", param.Nombre_sistema,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                              return false;
                      }
                      break;
                  case 34:
                      switch (Tipo_Proceso)
	                     {

                             case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BOL:
                              return  File_BBolivariano_PagoProveedores();
                            case ebanco_procesos_bancarios_tipo.PREAVISO_CHEQ:
                              return  File_BBolivariano_PreAvisoCheques();
                            default:
                                MessageBox.Show("No existe Programacion para el proceso seleccionado", param.Nombre_sistema,
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                         }
                      break;
                  default:
                      MessageBox.Show("No existe Programacion para el banco seleccionado", param.Nombre_sistema,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                      return false;
              }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }        

        public bool Validar()
        {
            try
            {
                bool Bandera = true;
                if (cmbRuta.Text == "")
                {
                    // are complete
                    MessageBox.Show("Seleccione la ruta para el archivo", param.Nombre_sistema,
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bandera = false;
                    return Bandera;
                }
                if ((cmb_Motivo_Transferencia.EditValue == "" || cmb_Motivo_Transferencia.EditValue==null) && ucBa_Proceso_x_Banco.get_Proceso_Info().IdProceso_bancario_tipo != "PAGO_PROVEEDORES_BOL")
                {
                    // are complete
                    MessageBox.Show("Seleccione el motivo de transferencia", param.Nombre_sistema,
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bandera = false;
                    return Bandera;
                }

                if (ucBa_Proceso_x_Banco.get_Proceso_Info().Tipo_Proc == "PAGO")
                {
                    if (BindingList_Archivo_Detalle.Count() == 0)
                    {
                        MessageBox.Show("No hay ordenes de pago", param.Nombre_sistema,
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;
                    }

                    if (BindingList_Archivo_Detalle.Count() > 0 && BindingList_Archivo_Detalle.Where(v => v.check == true).ToList().Count() == 0)
                    {
                        // are complete
                        MessageBox.Show("No hay seleccionado ningun Registro", param.Nombre_sistema,
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;
                    }


                    if (ucBa_Proceso_x_Banco.get_BaCuentaInfo().IdBanco == 0)
                    {
                        MessageBox.Show("Seleccione un banco", param.Nombre_sistema,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;
                    }


                    if (ucBa_Proceso_x_Banco.get_Proceso_Info().IdProceso_bancario_tipo == null)
                    {
                        MessageBox.Show("Seleccione un proceso", param.Nombre_sistema,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;
                    }
                    /*
                    if (ucBa_Proceso_x_Banco.get_BaCuentaInfo().CodigoLegal == "10")
                    {
                        if (txtNombreArc.Text == "")
                        {
                            
                            MessageBox.Show("El nombre del Archivo Es obligatorio", param.Nombre_sistema,
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Bandera = false;
                            return Bandera;
                        }
                    }
                    
                    */
                }
                
                if (ucBa_Proceso_x_Banco.get_Proceso_Info().Tipo_Proc == "TRANSF")
                {
                    if (txt_monto.Text == "")
                    {
                        MessageBox.Show("Ingrese monto a trasnferir", param.Nombre_sistema,
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;

                    }


                    if (Empresa_Destino_Info.IdEmpresa==0)
                    {
                        MessageBox.Show("Selecione la empresa acredita", param.Nombre_sistema,
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;

                    }



                   

                    if (Cuenta_Destino_Info.ba_Num_Cuenta == "")
                    {
                        MessageBox.Show("Selecione Cuenta que acredita", param.Nombre_sistema,
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;

                    }




                    if (param.IdEmpresa==Empresa_Destino_Info.IdEmpresa && ucBa_Proceso_x_Banco.get_BaCuentaInfo().ba_Num_Cuenta==Cuenta_Destino_Info.ba_Num_Cuenta)
                    {
                        MessageBox.Show("No puede hacer transferencia entre la mismam empresa y la misma cuenta", param.Nombre_sistema,
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;

                    }



                    if (ucBa_Proceso_x_Banco.get_BaCuentaInfo().CodigoLegal == "10")
                    {
                        if (txtNombreArc.Text == "")
                        {
                            MessageBox.Show("El nombre del Archivo Es obligatorio", param.Nombre_sistema,
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Bandera = false;
                            return Bandera;
                        }
                    }
                }


                if (ucBa_Proceso_x_Banco.get_Proceso_Info().Tipo_Proc == "PREAV_CHQ")
                {

                    if (BindingList_Archivo_Detalle_x_Cheq.Count() == 0)
                    {
                        MessageBox.Show("No hay Cheques seleccionado", param.Nombre_sistema,
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;
                    }

                    if (BindingList_Archivo_Detalle_x_Cheq.Count() > 0 && BindingList_Archivo_Detalle_x_Cheq.Where(v => v.check == true).ToList().Count() == 0)
                    {
                        // are complete
                        MessageBox.Show("No hay seleccionado ningun Registro de cheque", param.Nombre_sistema,
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;
                    }


                    if (ucBa_Proceso_x_Banco.get_BaCuentaInfo().IdBanco == 0)
                    {
                        MessageBox.Show("Seleccione un banco", param.Nombre_sistema,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;
                    }


                    if (ucBa_Proceso_x_Banco.get_Proceso_Info().IdProceso_bancario_tipo == null)
                    {
                        MessageBox.Show("Seleccione un proceso", param.Nombre_sistema,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bandera = false;
                        return Bandera;
                    }


                }
                return Bandera;

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
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
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarProcesos())
                {
                    if (Validar())
                    {
                        if (!GenerarArchivo())
                        {
                            MessageBox.Show("No se pudo generar el archivo",param.Nombre_sistema,
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (Guardar())
                        {
                            MessageBox.Show("El archivo fue generado exitosamente en: " + cmbRuta.Text, param.Nombre_sistema,
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (MessageBox.Show("Desea ver el Archivo...?", "INFORMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                if (File.Exists(cmbRuta.Text + nombre_file + ".txt"))
                                {
                                    Process.Start(cmbRuta.Text + nombre_file + ".txt");
                                }
                                else
                                    if (File.Exists(cmbRuta.Text + nombre_file + ".BIZ"))
                                    { Process.Start(cmbRuta.Text + nombre_file + ".BIZ"); }
                                    else
                                        MessageBox.Show("No se posble encontrar el archivo debido a su extensión en la ruta " + cmbRuta.Text + nombre_file, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            limpiar();
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
        
        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarProcesos())
                {
                    if (Validar())
                    {
                        GenerarArchivo();
                        if (Guardar())
                        {
                            MessageBox.Show("El archivo fue generado exitosamente en: " + cmbRuta.Text, param.Nombre_sistema,
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (MessageBox.Show("Desea ver el Archivo...?", "INFORMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                if (File.Exists(cmbRuta.Text + nombre_file + ".txt"))
                                {
                                    Process.Start(cmbRuta.Text + nombre_file + ".txt");
                                }
                                else
                                    if (File.Exists(cmbRuta.Text + nombre_file + ".BIZ"))
                                    { Process.Start(cmbRuta.Text + nombre_file + ".BIZ"); }
                                    else
                                        MessageBox.Show("No se posble encontrar el archivo debido a su extensión en la ruta "+cmbRuta.Text + nombre_file,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            this.Close();
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

        public bool Guardar()
        {
            txtObservacion.Focus();
            bool Bandera = false;
            try
            {
                Get();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Bandera = GrabarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Bandera = ModificarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Bandera = AnularDB();
                        break;
                    default:
                        break;
                }
                if (Bandera)
                {
                    Accion = Cl_Enumeradores.eTipo_action.actualizar;
                    Set_proceso();
                    Bandera = Contabilizar();    
                }
                return Bandera;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public bool GrabarDB()
        {
            try
            {
                bool Bandera = false;

                if (Archivo_Bus.GrabarDB(Archivo_Info, ref IdArchivo))
                {
                    MessageBox.Show("Registro Guardado Correctamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bandera = true;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Bandera = false;
                }

                return Bandera;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public bool ModificarDB()
        {
            try
            {
                bool Bandera = false;
                if (Archivo_Bus.ModificarDB(Archivo_Info))
                {
                    MessageBox.Show("Registro Actualizado Correctamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    Bandera = true;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Bandera = false;
                }
                return Bandera;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public bool AnularDB()
        {
            try
            {
                bool Bandera = false;

                if (MessageBox.Show("¿Está seguro que desea anular el Departamento...?", "Anulación de Departamento  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    Archivo_Info.IdUsuarioUltAnu = param.IdUsuario;
                    Archivo_Info.Fecha_UltMod = DateTime.Now;
                    Archivo_Info.Motivo_anulacion = ofrm.motivoAnulacion;

                    if (Archivo_Bus.AnularDB(Archivo_Info))
                    {
                        foreach (var item in Archivo_Info.Lst_Archivo_Transferencia_Det)
                        {
                            item.IdArchivo = Archivo_Info.IdArchivo;
                            item.IdProceso_bancario = Archivo_Info.IdProceso_bancario;
                        }

                        if (Archivo_Detalle_Bus.AnularDB(Archivo_Info.Lst_Archivo_Transferencia_Det))
                        {
                            MessageBox.Show("Registro Anulado Correctamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Bandera = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Anular el registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Bandera = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Anular el registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bandera = false;
                    }
                }

                return Bandera;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public void Get()
        {
            try
            {
                Archivo_Info.IdEmpresa = param.IdEmpresa;
                Archivo_Info.IdBanco =(int) ucBa_Proceso_x_Banco.get_BaCuentaInfo().IdBanco;                
                Archivo_Info.Observacion = txtObservacion.Text;
                Archivo_Info.IdUsuario = param.IdUsuario;
                Archivo_Info.Nom_Archivo =  nombre_file;
                Archivo_Info.Fecha =dtpFEchaPago.Value;
                Archivo_Info.cod_archivo = codigo_archivo;
                Archivo_Info.Fecha_Transac = DateTime.Now;
                Archivo_Info.Estado = true;
                Archivo_Info.IdEstadoArchivo_cat = "FIL_EMITID";
                Archivo_Info.IdProceso_bancario = ucBa_Proceso_x_Banco.get_Proceso_Info().IdProceso_bancario_tipo;
                Archivo_Info.IdMotivoArchivo_cat =Convert.ToString(cmb_Motivo_Transferencia.EditValue);
                if (Accion != Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (File.Exists(cmbRuta.Text + nombre_file + ".txt"))
                    {
                        Archivo_Info.Archivo = StreamFile(cmbRuta.Text + nombre_file + ".txt");
                    }
                    else
                    {
                        switch (param.IdCliente_Ven_x_Default)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                Archivo_Info.Archivo = StreamFile(cmbRuta.Text + nombre_file + ".BIZ");//Formato para el bolivariano, se hizo en naturisa  
                                break;
                             default:
                                Archivo_Info.Archivo = StreamFile(cmbRuta.Text + nombre_file + ".txt");
                                break;
                        }
                                
                            
                    }
                }
                Archivo_Info.Lst_Archivo_Transferencia_Det = new List<Info.Bancos.ba_Archivo_Transferencia_Det_Info>();
                Archivo_Info.Origen_Archivo = "CXP";
                Archivo_Info.Cod_Empresa = ucBa_Proceso_x_Banco.get_Proceso_Info().cod_banco;


                ///
                Archivo_Info.Lst_Archivo_Transferencia_Det = BindingList_Archivo_Detalle.Where(q => q.check == true).ToList();
                ////

                if (Archivo_Info.IdProceso_bancario == "PAGO_PROVEEDORES_BOL")
                {
                    foreach (var item in Archivo_Info.Lst_Archivo_Transferencia_Det)
                    {
                        foreach (var item_secuencial in list_secuencial_x_Persona)
                        {
                            if (item.IdTipo_Persona == item_secuencial.IdTipoPersona && item.IdPersona == item_secuencial.IdPersona && item.IdEntidad == item_secuencial.IdEntidad)
                            {
                                item.Secuencial_reg_x_proceso = item_secuencial.Secuencial_reg_x_archivo;
                                break;
                            }
                        }
                    }
                }
                /*
                if (ucBa_Proceso_x_Banco.get_Proceso_Info().Tipo_Proc == "TRANSF")
                {
                    ba_Archivo_Transferencia_Det_Info Archivo_Detalle_Info = new ba_Archivo_Transferencia_Det_Info();
                    Archivo_Detalle_Info.IdEmpresa = param.IdEmpresa;

                    Archivo_Detalle_Info.IdEmpresa_Origen_Trans = param.IdEmpresa;
                    Archivo_Detalle_Info.IdBanco_cta_Origen_trans = ucBa_Proceso_x_Banco.get_Proceso_Info().IdBanco;

                    Archivo_Detalle_Info.IdEmpresa_Destino_Trans = Empresa_Destino_Info.IdEmpresa;
                    Archivo_Detalle_Info.IdBanco_cta_Destino_trans = Cuenta_Destino_Info.IdBanco;
                    Archivo_Detalle_Info.Valor =Convert.ToDecimal( txt_monto.Text);
                    Archivo_Detalle_Info.IdProceso_bancario = ucBa_Proceso_x_Banco.get_Proceso_Info().IdProceso_bancario_tipo;
                    Archivo_Info.Lst_Archivo_Transferencia_Det.Add(Archivo_Detalle_Info);
                }
                */

                if (ucBa_Proceso_x_Banco.get_Proceso_Info().Tipo_Proc == "PREAV_CHQ")
                {
                    Archivo_Info.Lst_Archivo_Transferencia_Det = new List<ba_Archivo_Transferencia_Det_Info>();
                    Archivo_Info.Lst_Archivo_Transferencia_Det = BindingList_Archivo_Detalle_x_Cheq.Where(q => q.check == true).ToList();
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Set_Accion_in_controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_btn_Generar_XML = false;
                        ucGe_Menu.Visible_bntImprimir = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_btn_Generar_XML = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        Set_Info_In_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_btn_Generar_XML = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        Set_Info_In_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_btn_Generar_XML = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        Set_Info_In_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
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

        public void Set_Info(ba_Archivo_Transferencia_Info Info_)
        {
            try
            {
                Archivo_Info = Info_;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Set_Info_In_Controls()
        {
            try
            {
                txtObservacion.Text = Archivo_Info.Observacion;
                dtpFEchaPago.Value = Archivo_Info.Fecha;
                ucBa_Proceso_x_Banco.SetIdBanco(Archivo_Info.IdBanco);
                ucBa_Proceso_x_Banco.SetIdProceso(Archivo_Info.IdProceso_bancario);
                txtId.Text = Convert.ToString(Archivo_Info.IdArchivo);
                Set_proceso();
                txtObservacion.Text = Archivo_Info.Observacion;                
                txtNombreArc.Text = Archivo_Info.Nom_Archivo;
                if (Archivo_Info.IdMotivoArchivo_cat != null)
                {
                    cmb_Motivo_Transferencia.EditValue = Archivo_Info.IdMotivoArchivo_cat;
                }
                string s = ucBa_Proceso_x_Banco.get_Proceso_Info().IdProceso_bancario_tipo;
                /*
                if (ucBa_Proceso_x_Banco.get_Proceso_Info().Tipo_Proc == "TRANSF" )
                {

                    Archivo_Info.Lst_Archivo_Transferencia_Det = Archivo_Detalle_Bus.Get_List_Archivo_transferencia_Det(Archivo_Info.IdEmpresa, Convert.ToDecimal(Archivo_Info.IdArchivo));
                    ba_Archivo_Transferencia_Det_Info Archivo_Infodetalle = Archivo_Info.Lst_Archivo_Transferencia_Det.FirstOrDefault();
                    ultraCmbE_empresaDest.EditValue = Archivo_Infodetalle.IdEmpresa_Destino_Trans;
                    cmbCuentaDestino.EditValue = Convert.ToInt32(Archivo_Infodetalle.IdBanco_cta_Destino_trans);
                    txt_monto.Text = Convert.ToString(Archivo_Infodetalle.Valor);
                    tabControlDetalle.TabPages.Remove(tabPageOP);
                    tabControlDetalle.TabPages.Remove(tabPagePreavisoCheq);
                    tabControlDetalle.TabPages.Remove(tabPageRRHH);

                }*/
                
                if (ucBa_Proceso_x_Banco.get_Proceso_Info().Tipo_Proc == "PAGO")
                {
                    if (Archivo_Info.Origen_Archivo == "RRHH")
                    {
                        //tabControlDetalle.TabPages.Add(tabPageRRHH);
                        Archivo_Info.Lst_Archivo_Transferencia_Det = Archivo_Detalle_Bus.Get_List_Archivo_transferencia_Det(Archivo_Info.IdEmpresa, Convert.ToDecimal(Archivo_Info.IdArchivo));
                        BindingList_Archivo_Detalle = new BindingList<ba_Archivo_Transferencia_Det_Info>(Archivo_Info.Lst_Archivo_Transferencia_Det);
                        gridControlRRHH.DataSource = BindingList_Archivo_Detalle;
                        tabControlDetalle.TabPages.Remove(tabPageOP);

                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_btnContabilizar = true;
                    }
                    else
                    {
                        BuscarOP();
                        tabControlDetalle.TabPages.Remove(tabPageRRHH);
                    }
                    tabControlDetalle.TabPages.Remove(tabPageTrasnferencia);
                    tabControlDetalle.TabPages.Remove(tabPagePreavisoCheq);
                   
                }


                if (ucBa_Proceso_x_Banco.get_Proceso_Info().Tipo_Proc == "PREAV_CHQ")
                {
                    Archivo_Info.Lst_Archivo_Transferencia_Det = Archivo_Detalle_Bus.Get_List_Archivo_transferencia_Det(Archivo_Info.IdEmpresa, Convert.ToInt32(Archivo_Info.IdArchivo));
                    BindingList_Archivo_Detalle_x_Cheq = new BindingList<Info.Bancos.ba_Archivo_Transferencia_Det_Info>(Archivo_Detalle_Bus.Get_List_Archivo_transferencia_Det(Archivo_Info.IdEmpresa, Convert.ToInt32(Archivo_Info.IdArchivo)));
                    gridControlDetalleCheques.DataSource = BindingList_Archivo_Detalle_x_Cheq;
                    tabControlDetalle.TabPages.Remove(tabPageTrasnferencia);
                    tabControlDetalle.TabPages.Remove(tabPageOP);

                }              
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public byte[] StreamFile(string filename)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
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

        private void cmbRuta_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewDetalleOP_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    var data = gridViewDetalleOP.GetRow(e.RowHandle) as ba_Archivo_Transferencia_Det_Info;
                    if (data == null)
                        return;
                    if (!data.Estado )
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //ARCHIVOS BANCO BOLIVARIANO
        public bool File_BBolivariano_PagoProveedores()
        {
            try
            {
                list_secuencial_x_Persona = new List<Secuencial_registro_x_persona>();

                InfoBanco = ucBa_Proceso_x_Banco.get_BaCuentaInfo();
                Proceso_Info = (tb_banco_procesos_bancarios_x_empresa_Info)ucBa_Proceso_x_Banco.get_Proceso_Info();
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    string secuenci_file = Archivo_Bus.GetId_codigoArchivo_bolivariano(param.IdEmpresa, Convert.ToInt32(ucBa_Proceso_x_Banco.get_BaCuentaInfo().IdBanco), dtpFEchaPago.Value).ToString();
                    codigo_archivo = secuenci_file;
                    //nombre_file = "NOMBRECOMERCIALEMPRESA AAAA MM DD SEC 1.BIZ";// ???
                    nombre_file = param.InfoEmpresa.NombreComercial.ToUpper() + secuenci_file;
                    txtNombreArc.Text = nombre_file + ".BIZ";
                }
                else
                {
                    nombre_file = txtNombreArc.Text;
                }
                if (File.Exists(cmbRuta.Text + nombre_file + ".BIZ"))
                {
                    File.Delete(cmbRuta.Text + nombre_file + ".BIZ");
                }
                int Secuencial_detalle = 1;
                decimal Secuencial_detalle_archivo = 1;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Secuencial_detalle_archivo = Archivo_Detalle_Bus.Get_Secuencial_registro_BB(param.IdEmpresa, "PAGO_PROVEEDORES_BOL");
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Secuencial_detalle_archivo = Archivo_Detalle_Bus.Get_secuencial_registro_BB_modificar(param.IdEmpresa, "PAGO_PROVEEDORES_BOL",Convert.ToDecimal(txtId.Text=="" ? "0" : txtId.Text));
                        break;
                }
                if (txtSecuencial.Text != "0" && txtSecuencial.Text != "") Secuencial_detalle_archivo = Convert.ToInt32(txtSecuencial.Text);//Permite escoger desde que secuencial se pone por archivo

                var query_agrupado = (from q in BindingList_Archivo_Detalle
                                      where q.check == true
                                      group q by new { q.IdEmpresa, q.IdTipo_Persona, q.IdEntidad, q.IdPersona, q.IdTipoDocumento, q.pe_cedulaRuc, q.Beneficiario }
                                      into Lista_agrupada                                          
                                          select new
                                          {
                                              Lista_agrupada.Key.IdEmpresa,
                                              Lista_agrupada.Key.IdTipo_Persona,
                                              Lista_agrupada.Key.IdEntidad,
                                              Lista_agrupada.Key.IdPersona,
                                              Lista_agrupada.Key.IdTipoDocumento,
                                              Lista_agrupada.Key.pe_cedulaRuc,
                                              Lista_agrupada.Key.Beneficiario,                                              
                                              Valor = Lista_agrupada.Sum(q => q.Valor)
                                          });

                //foreach (var item in List_Archivo_Detalle)
                foreach (var item in query_agrupado.OrderBy(q=>q.Beneficiario))
                {
                    Archivo_Banco_Bolivariano_pago_proveedores_Info info_bolivariano = new Archivo_Banco_Bolivariano_pago_proveedores_Info();
                    info_bolivariano.PagTer_BZDET = "BZDET";
                    info_bolivariano.PagTer_secuencial = Secuencial_detalle.ToString(); Secuencial_detalle++;
                    info_bolivariano.PagTer_codigoBeneficiario = item.IdEntidad.ToString();
                    switch (item.IdTipoDocumento)
                    {
                        case "CED":
                            info_bolivariano.PagTer_tipoIdentificacion = "C";
                            break;
                        case "RUC":
                            info_bolivariano.PagTer_tipoIdentificacion = "R";
                            break;
                        case "PAS":
                            info_bolivariano.PagTer_tipoIdentificacion = "P";
                            break;
                    }
                    info_bolivariano.PagTer_numeroIdentificacion = item.pe_cedulaRuc;
                    info_bolivariano.PagTer_nombreBeneficiario = item.Beneficiario.Trim();
                    info_bolivariano.PagTer_formaPago = "CHE";
                    info_bolivariano.PagTer_codigoPais = "001";
                    info_bolivariano.PagTer_codigoBanco = " ";
                    info_bolivariano.PagTer_tipoCuenta = " ";
                    info_bolivariano.PagTer_numeroCuenta = " ";
                    info_bolivariano.PagTer_codigoMoneda = "1";
                    decimal valor_entero = Math.Truncate(item.Valor);
                    decimal valor_fraccion = Math.Round((item.Valor - valor_entero), 2, MidpointRounding.AwayFromZero);
                    info_bolivariano.PagTer_valorTotalPago = valor_entero.ToString("0000000000000") + (valor_fraccion *100).ToString("00");

                    string referencia = "";
                    foreach (var item_referencia in BindingList_Archivo_Detalle.Where(q=>q.IdTipo_Persona == item.IdTipo_Persona && q.IdPersona == item.IdPersona && q.IdEntidad == item.IdEntidad && q.check == true).ToList())
                    {
                        referencia += " " + item_referencia.Referencia;
                    }

                    info_bolivariano.PagTer_concepto = " " + item.IdTipo_Persona.Trim() + ": " + item.IdEntidad.ToString() + " " + referencia;

                    //OBJETO PARA LLEVAR EL SECUENCIAL DE LAS OP
                    Secuencial_registro_x_persona Info_secuencial_x_persona = new Secuencial_registro_x_persona();
                    Info_secuencial_x_persona.IdTipoPersona = item.IdTipo_Persona;
                    Info_secuencial_x_persona.IdPersona = item.IdPersona;
                    Info_secuencial_x_persona.IdEntidad = Convert.ToDecimal(item.IdEntidad);
                    Info_secuencial_x_persona.Secuencial_reg_x_archivo = Secuencial_detalle_archivo;
                    list_secuencial_x_Persona.Add(Info_secuencial_x_persona);

                    info_bolivariano.PagTer_numeroComprobante = Secuencial_detalle_archivo.ToString(); Secuencial_detalle_archivo++;
                    info_bolivariano.PagTer_numeroComprobanteRetencion = "0";
                    info_bolivariano.PagTer_numeroComprobanteIVA = "0";
                    info_bolivariano.PagTer_numeroFacturaSRI = "0";
                    info_bolivariano.PagTer_codigoGrupo = " ";
                    info_bolivariano.PagTer_descripcionGrupo = " ";
                    info_bolivariano.PagTer_direccionBeneficiario = " ";
                    info_bolivariano.PagTer_telefono = " ";
                    info_bolivariano.PagTer_codigoServicio = "PRO";
                    info_bolivariano.PagTer_cedula1PersonaRetirarChequePago = " ";
                    info_bolivariano.PagTer_cedula2PersonaRetirarChequePago = " ";
                    info_bolivariano.PagTer_cedula3PersonaRetirarChequePago = " ";
                    info_bolivariano.PagTer_seniaControlHorarioAtencion = " ";
                    info_bolivariano.PagTer_codigoEmpresaAsignadoPorBanco = ucBa_Proceso_x_Banco.get_Proceso_Info().Codigo_Empresa;
                    info_bolivariano.PagTer_nemonicoSubEmpresaQuienOrdenaPago = " ";
                    info_bolivariano.PagTer_subMotivoPagoCobro = "RPA";

                  ba_si_genero_Archivo=  Generar_Archivo_Bus_BB.Guardar_Archivo_Banco_Bolivariano(info_bolivariano, Proceso_Info, cmbRuta.Text, nombre_file);
                }

                return ba_si_genero_Archivo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public bool File_BBolivariano_PreAvisoCheques()
        {
            try
            {
                list_secuencial_x_Persona = new List<Secuencial_registro_x_persona>();

                InfoBanco = ucBa_Proceso_x_Banco.get_BaCuentaInfo();
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    string secuenci_file = Archivo_Bus.GetId_codigoArchivo_bolivariano(param.IdEmpresa, Convert.ToInt32(ucBa_Proceso_x_Banco.get_BaCuentaInfo().IdBanco), dtpFEchaPago.Value).ToString();
                    codigo_archivo = secuenci_file;
                  
                    nombre_file = "";
                    nombre_file = param.InfoEmpresa.NombreComercial.ToUpper() + secuenci_file;
                    txtNombreArc.Text = nombre_file + ".BIZ";
                }
                else
                {
                    nombre_file = txtNombreArc.Text;
                }
                if (File.Exists(cmbRuta.Text + nombre_file + ".BIZ"))
                {
                    File.Delete(cmbRuta.Text + nombre_file + ".BIZ");
                }
                int Secuencial_detalle = 1;



                //secuencia por proceso
                decimal Secuencial_detalle_archivo = Archivo_Detalle_Bus.Get_Secuencial_registro_BB(param.IdEmpresa, "PREAVISO_CHEQ");




                var query_x_Cbte_Ban = from q in BindingList_Archivo_Detalle_x_Cheq
                                      where q.check == true
                                       orderby q.num_cheq
                                      select q;
                                          

                //foreach (var item in List_Archivo_Detalle)
                foreach (var item in query_x_Cbte_Ban)
                {

                    Archivo_Banco_Bolivariano_preAviso_Cheq_Info info_bolivariano_x_Preaviso = new Archivo_Banco_Bolivariano_preAviso_Cheq_Info();
                    info_bolivariano_x_Preaviso.PagTer_BZDET = "BZDET";
                    info_bolivariano_x_Preaviso.PagTer_secuencial = Secuencial_detalle.ToString(); Secuencial_detalle++;
                    info_bolivariano_x_Preaviso.PagTer_codigoBeneficiario = item.pe_cedulaRuc;



                    switch (item.IdTipoDocumento)
                    {
                        case "CED":
                            info_bolivariano_x_Preaviso.PagTer_tipoIdentificacion = "C";
                            break;
                        case "RUC":
                            info_bolivariano_x_Preaviso.PagTer_tipoIdentificacion = "R";
                            break;
                        case "PAS":
                            info_bolivariano_x_Preaviso.PagTer_tipoIdentificacion = "P";
                            break;
                    }
                    info_bolivariano_x_Preaviso.PagTer_numeroIdentificacion = item.pe_cedulaRuc;


                    info_bolivariano_x_Preaviso.PagTer_nombreBeneficiario = item.giradoA_cheq.Trim();
                    info_bolivariano_x_Preaviso.PagTer_formaPago = "CHE";
                    info_bolivariano_x_Preaviso.PagTer_codigoPais = "001";
                    info_bolivariano_x_Preaviso.PagTer_codigoBanco = "34";
                    info_bolivariano_x_Preaviso.PagTer_tipoCuenta = "03";
                    info_bolivariano_x_Preaviso.PagTer_numeroCuenta = InfoBanco.ba_Num_Cuenta.Trim();
                    info_bolivariano_x_Preaviso.PagTer_numeroCheque = item.num_cheq.Trim();
                    info_bolivariano_x_Preaviso.PagTer_codigoMoneda = "1";

                    decimal valor_entero = Math.Truncate(item.Valor);
                    decimal valor_fraccion = Math.Round((item.Valor - valor_entero), 2, MidpointRounding.AwayFromZero);
                    info_bolivariano_x_Preaviso.PagTer_valorCheq_Ordenado = valor_entero.ToString("0000000000000") + (valor_fraccion*100).ToString("00");
                    info_bolivariano_x_Preaviso.PagTer_concepto = "";//"Chq·:" + item.num_cheq + " Para:" + item.giradoA_cheq;
                    info_bolivariano_x_Preaviso.PagTer_espacio_blanco1 = "";
                    info_bolivariano_x_Preaviso.PagTer_espacio_blanco2 = "";
                    info_bolivariano_x_Preaviso.PagTer_Tipo_de_cheque = "N"; // Especifique el tipo de cheque como:N.- No valida el tipo de cheque o espacio blanco.  C .- Cruzado.

                    info_bolivariano_x_Preaviso.PagTer_codigoServicio = "CCH";
                    info_bolivariano_x_Preaviso.PagTer_codigoEmpresaAsignadoPorBanco = ucBa_Proceso_x_Banco.get_Proceso_Info().Codigo_Empresa;
                    
                  ba_si_genero_Archivo=  Generar_Archivo_Bus_BB.Guardar_Archivo_Banco_Bolivariano_PreAviso(info_bolivariano_x_Preaviso, cmbRuta.Text, nombre_file);
                }

                return ba_si_genero_Archivo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        // ARCHIVOS BANCO PICHINCHA
        public bool FileBPichincha_PagoProveedores()
        {
           
                string msg = "";
                try
                {                  
                           

                            if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                            {
                                string secuenci_file = Archivo_Bus.GetId_codigoArchivo(param.IdEmpresa, dtpFEchaPago.Value).ToString();
                                nombre_file = ucBa_Proceso_x_Banco.get_Proceso_Info().Iniciales_Archivo + secuenci_file.Substring(0, 8) + ucBa_Proceso_x_Banco.get_Proceso_Info().cod_banco + "_" + secuenci_file.Substring(9, secuenci_file.Length - 9);
             
                            }
                            else
                            {
                                nombre_file = txtNombreArc.Text;
                            }
                            if (File.Exists(cmbRuta.Text + nombre_file+".txt"))
                            {
                                File.Delete(cmbRuta.Text + nombre_file + ".txt");
                            }   
                            foreach (var item in BindingList_Archivo_Detalle)
                            {
                                if (item.check == true)
                                {

                                   
                                    Archivo_Banco_Pichincha_Pago_Info info_pichincha = new Archivo_Banco_Pichincha_Pago_Info();
                                    info_pichincha.codigoOrientacion = "PA";
                                    info_pichincha.contraPartida = item.pe_cedulaRuc.ToString();
                                    info_pichincha.moneda = "USD";
                                    decimal valor = item.Valor;
                                    info_pichincha.valor = string.Format("{0:0.00}", valor);
                                    info_pichincha.valor = info_pichincha.valor.ToString().Replace(".", "");
                                    if (item.IdTipoCta_acreditacion_cat == "COR" || item.IdTipoCta_acreditacion_cat == "AHO")
                                    {

                                           
                                            info_pichincha.formaCobroPago = "CTA";
                                            info_pichincha.numeroCuenta = item.num_cta_acreditacion;
                                            if (item.IdTipoCta_acreditacion_cat == "COR")
                                            info_pichincha.tipoCuenta = "CTE";
                                        else
                                                info_pichincha.tipoCuenta = item.IdTipoCta_acreditacion_cat;

                                      
                                    }

                                    else//PAGO EN CHEQUE
                                    {
                                        MessageBox.Show("Tipo de Cuenta no valida " + item.IdTipoCta_acreditacion_cat);
                                        return false;
                                    }


                                    if (item.Observacion_op.Length > 40)
                                        info_pichincha.referencia = item.Observacion_op.Substring(0, 39);
                                    else
                                        info_pichincha.referencia = item.Observacion_op;

                                    if (item.IdTipoDocumento == "RUC")
                                    {

                                        info_pichincha.tipoIdCliente = "R";
                                    }
                                    else
                                    {
                                        if (item.IdTipoDocumento == "CED")
                                        {
                                            info_pichincha.tipoIdCliente = "C";
                                        }
                                        else
                                            if (item.IdTipoDocumento == "PAS")
                                            {
                                                info_pichincha.tipoIdCliente = "P";
                                            }
                                            else
                                            {
                                                info_pichincha.tipoIdCliente = "N";
                                            }
                                    }

                                    info_pichincha.numeroIdCliente = item.pe_cedulaRuc;
                                    info_pichincha.nombreCliente = item.Beneficiario.ToUpper().Replace("Ñ", "N");
                                    info_pichincha.cobroBaseImponible = item.Valor.ToString();
                                    info_pichincha.cobroBaseImponible = item.Valor.ToString();
                                    info_pichincha.tipoCuenta = item.IdTipoCta_acreditacion_cat;
                                    info_pichincha.pagoCodigoBanco = item.CodigoLegal;
                                    if (item.IdTipoCta_acreditacion_cat == "COR" || item.IdTipoCta_acreditacion_cat == "AHO")
                                    {
                                     ba_si_genero_Archivo=   Generar_Archivo_Bus_BP.Guardar_Archivo_Banco_Pichinca(info_pichincha, Proceso_Info, cmbRuta.Text, nombre_file, "");
                                    }



                                }

                            }

                            return ba_si_genero_Archivo;     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Log_Error_bus.Log_Error(ex.ToString());
                    return false;
                }

           
        }
        public bool FileBPichinchaTransf_CuentaCompania()
        {


            string msg = "";
            try
            {


                nombre_file = txtNombreArc.Text;
                if (File.Exists(cmbRuta.Text + nombre_file + ".txt"))
                {
                    File.Delete(cmbRuta.Text + nombre_file + ".txt");
                }

                Archivo_Banco_Pichincha_Pago_Info info_pichincha = new Archivo_Banco_Pichincha_Pago_Info();
                info_pichincha.codigoOrientacion = "PA";
                info_pichincha.contraPartida = Empresa_Info.em_ruc;
                info_pichincha.moneda = "USD";
                decimal valor = Convert.ToDecimal(txt_monto.Text);
                info_pichincha.valor = string.Format("{0:0.00}", valor);
                info_pichincha.valor = info_pichincha.valor.ToString().Replace(".", "");
                info_pichincha.formaCobroPago = "CTA";
                if (Cuenta_Destino_Info.ba_Tipo == "Cuenta corriente")
                {
                    info_pichincha.tipoCuenta = "CTE";
                }
                else
                {
                    info_pichincha.tipoCuenta = "AHO";

                }
                info_pichincha.numeroCuenta = Cuenta_Destino_Info.ba_Num_Cuenta;
                info_pichincha.referencia = txtObservacion.Text;
                info_pichincha.tipoIdCliente = "R";
                info_pichincha.numeroIdCliente = Empresa_Destino_Info.em_ruc;
                info_pichincha.nombreCliente = Empresa_Destino_Info.RazonSocial;
                info_pichincha.pagoCodigoBanco = Cuenta_Destino_Info.CodigoLegal;

             ba_si_genero_Archivo=   Generar_Archivo_Bus_BP.Guardar_Archivo_Banco_Pichinca(info_pichincha, Proceso_Info, cmbRuta.Text, nombre_file, "");
             return ba_si_genero_Archivo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        // ARCHIVOS BANCO GUAYAQUL FORMATO DE ARCHIVO MULTICHAS (TRANSFERENCIA AL MISMO BANCO)
        public bool File_BGuayaquil_PagoProveedores_Mismo_Banco()
        {
           
                string msg = "";
                int Secuencia = 0;
                InfoBanco = ucBa_Proceso_x_Banco.get_BaCuentaInfo();
                try
                {
                    if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {

                        string secuenci_file = Archivo_Bus.GetId_codigoArchivo(param.IdEmpresa, dtpFEchaPago.Value).ToString();
                        nombre_file = ucBa_Proceso_x_Banco.get_Proceso_Info().Iniciales_Archivo + "_" + secuenci_file;
                    }
                    else
                    {
                        nombre_file = txtNombreArc.Text;
                    }

                    if (File.Exists(cmbRuta.Text + nombre_file + ".txt"))
                    {
                        File.Delete(cmbRuta.Text + nombre_file + ".txt");
                    }   

                    foreach (var item in BindingList_Archivo_Detalle)
                    {
                        if (item.check == true)
                        {
                            Secuencia = Secuencia + 1;

                            Archivo_Banco_Guayaquil_Pagos_Info info_guayaquil = new Archivo_Banco_Guayaquil_Pagos_Info();
                            info_guayaquil.Multi_codigoOrientación = "PA";
                            info_guayaquil.Multi_cuentaEmpresa = ucBa_Proceso_x_Banco.get_BaCuentaInfo().ba_Num_Cuenta;
                            info_guayaquil.Multi_secuencialPago = "1";
                            info_guayaquil.Multi_comprobantedePago = "";
                            if (item.IdTipoCta_acreditacion_cat == "AHO" || item.IdTipoCta_acreditacion_cat == "COR")
                            {
                                info_guayaquil.Multi_codigo = item.num_cta_acreditacion.PadLeft(10,'0');
                            }
                            else
                            {
                                info_guayaquil.Multi_codigo = item.pe_cedulaRuc;
                            }
                            info_guayaquil.Multi_moneda = "USD";
                            decimal valor = item.Valor;
                            info_guayaquil.valor = string.Format("{0:0.00}", valor);
                            info_guayaquil.valor = info_guayaquil.valor.ToString().Replace(".", "");

                            if (item.IdTipoCta_acreditacion_cat != "CHE")
                            {


                                if (item.IdTipoCta_acreditacion_cat == "EFE")
                                {
                                    info_guayaquil.Multi_formaPago = "EFE";
                                }
                                else
                                {
                                    if (item.IdTipoCta_acreditacion_cat == "AHO" || item.IdTipoCta_acreditacion_cat == "COR")
                                    {
                                        info_guayaquil.Multi_formaPago = "CTA";
                                        info_guayaquil.Multi_numeroDeCuenta = item.num_cta_acreditacion;
                                        info_guayaquil.Multi_tipoCuenta = item.IdTipoCta_acreditacion_cat;
                                    }
                                    else
                                    {
                                        info_guayaquil.Multi_formaPago = "EFE";


                                    }

                                }
                            }

                            else//PAGO EN CHEQUE
                            {

                            }


                            if (info_guayaquil.Multi_formaPago == "EFE" || info_guayaquil.Multi_formaPago == "CHQ")
                            {
                             info_guayaquil.Multi_codigoDeInstitucionFinanciera=   "0017";   
                            }
                            else
                            {
                                info_guayaquil.Multi_codigoDeInstitucionFinanciera = item.CodigoLegal;   

                            }
                            if (info_guayaquil.Multi_tipoCuenta == "COR" || info_guayaquil.Multi_tipoCuenta=="AHO")
                            {
                                info_guayaquil.Multi_tipoCuenta = item.IdTipoCta_acreditacion_cat;
                            }
                            else
                            {
                                info_guayaquil.Multi_tipoCuenta = "";
                            }

                            if (info_guayaquil.Multi_tipoCuenta == "COR" || info_guayaquil.Multi_tipoCuenta == "AHO")
                            {
                                info_guayaquil.Multi_numeroDeCuenta = item.num_cta_acreditacion.ToString().PadLeft(10, '0');
                            }
                            else
                            {
                                info_guayaquil.Multi_numeroDeCuenta = "";
                            }


                            if (item.IdTipoDocumento == "RUC")
                            {

                                info_guayaquil.Multi_tipoIdClienteBeneficiario = "R";
                            }
                            else
                            {
                                if (item.IdTipoDocumento == "CED")
                                {
                                    info_guayaquil.Multi_tipoIdClienteBeneficiario = "C";
                                }
                                else
                                    if (item.IdTipoDocumento == "PAS")
                                    {
                                        info_guayaquil.Multi_tipoIdClienteBeneficiario = "P";
                                    }
                                    else
                                    {
                                        info_guayaquil.Multi_tipoIdClienteBeneficiario = "N";
                                    }
                            }
                            info_guayaquil.Multi_numeroIdClienteBeneficiario = item.pe_cedulaRuc;
                            info_guayaquil.Multi_nombreClienteBeneficiario = item.Beneficiario.Replace("Ñ", "N").ToUpper();
                            info_guayaquil.Multi_direccionBeneficiario = "";
                            info_guayaquil.Multi_ciudadBeneficiario = "";
                            info_guayaquil.Multi_telefonoBeneficiario = "";
                            info_guayaquil.Multi_localidadPago = "";
                            if (item.Observacion_op.Length > 100)
                                info_guayaquil.Multi_referencia = item.Observacion_op.Substring(0, 99);
                            else
                                info_guayaquil.Multi_referencia = item.Observacion_op;
                            info_guayaquil.Multi_referenciaAdicional = "";

                            
                            ba_si_genero_Archivo= Generar_Archivo_Bus_BG.Guardar_Archivo_BG(info_guayaquil, Proceso_Info, cmbRuta.Text, nombre_file, "");
                        }
                    }

                    return ba_si_genero_Archivo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Log_Error_bus.Log_Error(ex.ToString());
                    return false;
                }
        }
        public bool FileBGuayaquil_Transf_Commpania_mismo_Banco()
        {
            try
            {

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    string secuenci_file = Archivo_Bus.GetId_codigoArchivo(param.IdEmpresa, dtpFEchaPago.Value).ToString();
                    //nombre_file = ucBa_Proceso_x_Banco.get_Proceso_Info().Nombre_Archivo + "_" + secuenci_file;
                }
                else
                {
                    nombre_file = txtNombreArc.Text;
                }
                if (File.Exists(cmbRuta.Text + nombre_file+".txt"))
                {
                    File.Delete(cmbRuta.Text + nombre_file + ".txt");
                }

                        Archivo_Banco_Guayaquil_Pagos_Info info_guayaquil = new Archivo_Banco_Guayaquil_Pagos_Info();
                        info_guayaquil.Multi_codigoOrientación = "PA";
                        info_guayaquil.Multi_cuentaEmpresa = ucBa_Proceso_x_Banco.get_BaCuentaInfo().ba_Num_Cuenta;
                        info_guayaquil.Multi_secuencialPago = "1";
                        info_guayaquil.Multi_comprobantedePago = "";
                        info_guayaquil.Multi_codigo = Cuenta_Destino_Info.ba_Num_Cuenta;
                        info_guayaquil.Multi_moneda = "USD";
                        decimal valor = Convert.ToDecimal(txt_monto.Text);
                        info_guayaquil.valor = string.Format("{0:0.00}", valor);
                        info_guayaquil.valor = info_guayaquil.valor.ToString().Replace(".","");
                        info_guayaquil.Multi_formaPago = "CTA";
                        info_guayaquil.Multi_codigoDeInstitucionFinanciera = Cuenta_Destino_Info.CodigoLegal;
                        if (Cuenta_Destino_Info.ba_Tipo == "Cuenta corriente")
                        {
                            info_guayaquil.Multi_tipoCuenta = "CTE";
                        }
                        else
                        {
                            info_guayaquil.Multi_tipoCuenta = "AHO";

                        }

                        info_guayaquil.Multi_numeroDeCuenta = Cuenta_Destino_Info.ba_Num_Cuenta;
                        info_guayaquil.Multi_tipoIdClienteBeneficiario = "R";
                        info_guayaquil.Multi_numeroIdClienteBeneficiario = Empresa_Destino_Info.em_ruc;
                        info_guayaquil.Multi_nombreClienteBeneficiario = Empresa_Destino_Info.RazonSocial;
                        info_guayaquil.Multi_direccionBeneficiario = "";
                        info_guayaquil.Multi_ciudadBeneficiario = "";
                        info_guayaquil.Multi_telefonoBeneficiario = "";
                        info_guayaquil.Multi_localidadPago = "";
                        info_guayaquil.Multi_referencia =txtObservacion.Text;
                        info_guayaquil.Multi_referenciaAdicional = "";
                    return    Generar_Archivo_Bus_BG.Guardar_Archivo_BG(info_guayaquil, Proceso_Info, cmbRuta.Text, nombre_file, "");

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ARCHIVOS BANCO DE GUAYAQUIL FORMATO NCR (TRANSFERENCIA OTROS BANCOS)
        public bool File_BGuayaquil_PagoProveedores_Otros_Banco()
        {

            int Secuencia = 0;
            InfoBanco = ucBa_Proceso_x_Banco.get_BaCuentaInfo();
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    string secuenci_file = Archivo_Bus.GetId_codigoArchivo(param.IdEmpresa, dtpFEchaPago.Value).ToString();
                    nombre_file = ucBa_Proceso_x_Banco.get_Proceso_Info().Iniciales_Archivo + secuenci_file.Substring(0, 8) + ucBa_Proceso_x_Banco.get_Proceso_Info().cod_banco + "_" + secuenci_file.Substring(9, secuenci_file.Length - 9);
                }
                else
                {
                    nombre_file = txtNombreArc.Text;
                }
                if (File.Exists(cmbRuta.Text + nombre_file + ".txt"))
                {
                    File.Delete(cmbRuta.Text + nombre_file + ".txt");
                }

                foreach (var item in BindingList_Archivo_Detalle)
                {
                    bool bandera = true;
                    if (item.check == true)
                    {
                        Secuencia = Secuencia + 1;
                       
                        Archivo_Banco_Guayaquil_Pagos_Info info_guayaquil = new Archivo_Banco_Guayaquil_Pagos_Info();

                        if (item.IdTipoCta_acreditacion_cat == "AHO")
                        {
                            info_guayaquil.NCR_TiposdeCuenta = "A";
                        }
                        else
                        {
                            if (item.IdTipoCta_acreditacion_cat == "CTE")
                            {
                                info_guayaquil.NCR_TiposdeCuenta = "C";
                            }
                            else
                            {
                                bandera = false;
                            }
                        }
                        if(item.CodigoLegal=="17")
                        info_guayaquil.NCR_NumerodeCuentaBancoGuayaquil = item.num_cta_acreditacion.PadLeft(10,'0');
                        else
                        info_guayaquil.NCR_NumerodeCuentaBancoGuayaquil = "0000000000";
                        info_guayaquil.NCR_Motivo = "";
                        info_guayaquil.NCR_TipoNota = "";
                        info_guayaquil.NCR_Agencia = "";
                        info_guayaquil.NCR_CodigoBancoParaPagoInterbancario = item.CodigoLegal;
                        info_guayaquil.NCR_NumeroCuentaOtrosBancos = item.num_cta_acreditacion;
                        info_guayaquil.NCR_NombreTitularCuentaOtrosBancos = item.Beneficiario.ToUpper();
                        info_guayaquil.NCR_NuevoMotivo = ucBa_Proceso_x_Banco.get_Proceso_Info().Codigo_Empresa;
                        info_guayaquil.NCR_Email = "";
                        info_guayaquil.NCR_Celular ="";
                        decimal valor = item.Valor;
                        info_guayaquil.valor = string.Format("{0:0.00}", valor);
                        info_guayaquil.valor = info_guayaquil.valor.ToString().Replace(".", "");
                        if (item.IdTipoDocumento == "RUC")
                        {

                           info_guayaquil.NCR_TipoIdentificaciónBeneficiario  = "R";
                        }
                        else
                        {
                            if (item.IdTipoDocumento == "CED")
                            {
                            info_guayaquil.NCR_TipoIdentificaciónBeneficiario = "C";
                            }
                            else
                                if (item.IdTipoDocumento == "PAS")
                                {
                                    info_guayaquil.NCR_TipoIdentificaciónBeneficiario = "P";
                                }
                                else
                                {
                                    MessageBox.Show("Tipos documento no Validod");
                                }
                        }
                        info_guayaquil.NCR_NúmeroIdentificacionBeneficiario = item.pe_cedulaRuc;
                        if(bandera)
                     ba_si_genero_Archivo=   Generar_Archivo_Bus_BG.Guardar_Archivo_BG(info_guayaquil, Proceso_Info, cmbRuta.Text, nombre_file, "");
                    }
                }
                return ba_si_genero_Archivo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }



        }
        public bool File_BGuayaquil_Transferencia_Otros_Banco()
        {   
            try
            {
                InfoBanco = ucBa_Proceso_x_Banco.get_BaCuentaInfo();

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    string secuenci_file = Archivo_Bus.GetId_codigoArchivo(param.IdEmpresa, dtpFEchaPago.Value).ToString();
                    nombre_file = ucBa_Proceso_x_Banco.get_Proceso_Info().Iniciales_Archivo + secuenci_file.Substring(0, 8) + ucBa_Proceso_x_Banco.get_Proceso_Info().cod_banco + "_" + secuenci_file.Substring(9, secuenci_file.Length - 9);
                }
                else
                {
                    nombre_file = txtNombreArc.Text;
                }
                if (File.Exists(cmbRuta.Text + nombre_file + ".txt"))
                {
                    File.Delete(cmbRuta.Text + nombre_file + ".txt");
                }

                Archivo_Banco_Guayaquil_Pagos_Info info_guayaquil = new Archivo_Banco_Guayaquil_Pagos_Info();

                if (Cuenta_Destino_Info.ba_Tipo == "Cuenta corriente")
                {
                    info_guayaquil.NCR_TiposdeCuenta = "C";
                }
                else
                {
                    info_guayaquil.NCR_TiposdeCuenta = "A";

                }
                info_guayaquil.NCR_NumerodeCuentaBancoGuayaquil = InfoBanco.ba_Num_Cuenta;
                decimal valor = Convert.ToDecimal(txt_monto.Text); ;
                info_guayaquil.valor = string.Format("{0:0.00}", valor);
                info_guayaquil.valor = info_guayaquil.valor.ToString().Replace(".", "");
                info_guayaquil.NCR_Motivo = "XX";
                info_guayaquil.NCR_TipoNota = "Y";
                info_guayaquil.NCR_Agencia = "01";
                info_guayaquil.NCR_CodigoBancoParaPagoInterbancario = "XX";
                info_guayaquil.NCR_NumeroCuentaOtrosBancos = Cuenta_Destino_Info.ba_Num_Cuenta;
                info_guayaquil.NCR_NombreTitularCuentaOtrosBancos = Empresa_Destino_Info.RazonSocial.ToUpper().Replace("S.A", "");
                info_guayaquil.NCR_NuevoMotivo = ucBa_Proceso_x_Banco.get_Proceso_Info().cod_banco;
                info_guayaquil.NCR_Email = "";
                info_guayaquil.NCR_Celular = "";
                info_guayaquil.NCR_BancoDestinopagointerbancario = InfoBanco.CodigoLegal;
                info_guayaquil.NCR_TipoIdentificaciónBeneficiario = "R";
                info_guayaquil.NCR_NúmeroIdentificacionBeneficiario = Empresa_Destino_Info.em_ruc;

              return  Generar_Archivo_Bus_BG.Guardar_Archivo_BG(info_guayaquil, Proceso_Info, cmbRuta.Text, nombre_file, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        // ARCHIVO PARA EL BANCO DE GUAYAQUIL FORMATO ROL ELECTRONICO (PAGOS A CUENTAS VIRTUALES)
        public bool File_BGuayaquil_PagosCta_Virtuales()
        {
            List<Archivo_Banco_Guayaquil_Pagos_Info> Lista_Banco_G = new List<Archivo_Banco_Guayaquil_Pagos_Info>();

            InfoBanco = ucBa_Proceso_x_Banco.get_BaCuentaInfo();
            Archivo_Banco_Guayaquil_Pagos_Info info_guayaquil = null;

            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    string secuenci_file = Archivo_Bus.GetId_codigoArchivo(param.IdEmpresa, dtpFEchaPago.Value).ToString();
                    string codigo_empresa = ucBa_Proceso_x_Banco.get_Proceso_Info().Codigo_Empresa;
                    nombre_file = ucBa_Proceso_x_Banco.get_Proceso_Info().Iniciales_Archivo + secuenci_file.Substring(0, 8) + codigo_empresa +  "_" + secuenci_file.Substring(9, secuenci_file.Length - 9);
               
                }
                else
                {
                    nombre_file = txtNombreArc.Text;
                }
                if (File.Exists(cmbRuta.Text + nombre_file + ".txt"))
                {
                    File.Delete(cmbRuta.Text + nombre_file + ".txt");
                }


                // crea la cabcerara del archivo 
                if (BindingList_Archivo_Detalle.Where(v => v.check == true).ToList().Count > 0)
                {


                    info_guayaquil = new Archivo_Banco_Guayaquil_Pagos_Info();
                    info_guayaquil.Rol_Elect_TipoRegistro = "C";
                    info_guayaquil.Rol_Elect_CodigoEmpresa = ucBa_Proceso_x_Banco.get_Proceso_Info().Codigo_Empresa;
                    info_guayaquil.Rol_Elect_NumCtaEmpresa = InfoBanco.ba_Num_Cuenta;
                    info_guayaquil.Rol_Elect_Nombre = Empresa_Info.RazonSocial.Replace("S.A", "");
                    info_guayaquil.Rol_Elect_CobroServicio = "C";
                    decimal valor = BindingList_Archivo_Detalle.Where(v => v.check == true).Sum(v => v.Valor);
                    info_guayaquil.Rol_Elect_Monto = string.Format("{0:0.00}", valor);
                    info_guayaquil.Rol_Elect_Monto = info_guayaquil.Rol_Elect_Monto.ToString().Replace(".", "");
                    DateTime FechaEnvio = dtpFEchaPago.Value;
                    info_guayaquil.Rol_Elect_Fecha_Envio = Convert.ToString(FechaEnvio.Year) + Convert.ToString(FechaEnvio.Month).PadLeft(2, '0') + Convert.ToString(FechaEnvio.Day).PadLeft(2, '0');
                    info_guayaquil.Rol_Elect_NumCreditos = Convert.ToString(BindingList_Archivo_Detalle.Where(v => v.check == true).Count());
                    info_guayaquil.NCR_NuevoMotivo = "";
                    Lista_Banco_G.Add(info_guayaquil);
                }
                foreach (var item in BindingList_Archivo_Detalle)
                {

                    if (item.check == true)
                    {

                        info_guayaquil = new Archivo_Banco_Guayaquil_Pagos_Info();
                        info_guayaquil.Rol_Elect_TipoRegistro = "D";
                        info_guayaquil.Rol_Elect_CodigoEmpresa = ucBa_Proceso_x_Banco.get_Proceso_Info().Codigo_Empresa;
                        info_guayaquil.Rol_Elect_CodigoEmpleado = item.pe_cedulaRuc;
                        info_guayaquil.Rol_Elect_NumCtaEmpresa = item.pe_cedulaRuc;
                        info_guayaquil.Rol_Elect_Nombre = item.Beneficiario.Replace("Ñ", "N").ToUpper();
                        info_guayaquil.Rol_Elect_CobroServicio = "N";
                        decimal valor = BindingList_Archivo_Detalle.Where(v => v.check == true).Sum(v => v.Valor);
                        info_guayaquil.Rol_Elect_Monto = string.Format("{0:0.00}", item.Valor);
                        info_guayaquil.Rol_Elect_Monto = info_guayaquil.Rol_Elect_Monto.ToString().Replace(".", "");
                        DateTime FechaEnvio = dtpFEchaPago.Value;
                        info_guayaquil.Rol_Elect_Fecha_Envio = Convert.ToString(FechaEnvio.Year) + Convert.ToString(FechaEnvio.Month).PadLeft(2, '0') + Convert.ToString(FechaEnvio.Day).PadLeft(2, '0');
                        info_guayaquil.Rol_Elect_NumCreditos = Convert.ToString(BindingList_Archivo_Detalle.Where(v => v.check == true).Count());
                        info_guayaquil.NCR_NuevoMotivo = "";
                        info_guayaquil.Rol_Elect_Motivo3 = "";
                        info_guayaquil.Rol_Elect_Filler = "";
                        info_guayaquil.Rol_Elect_Filler2 = "";
                        info_guayaquil.Rol_Elect_Email = param.em_Email;
                        info_guayaquil.Rol_Elect_Celular = "";
                        if (item.pe_cedulaRuc.Length == 10)
                        {
                            Lista_Banco_G.Add(info_guayaquil);
                        }
                        else
                        {
                            MessageBox.Show("Destinatario no valido " + item.Beneficiario + " para el tipo de transferencia", param.Nombre_sistema,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
             return  Generar_Archivo_Bus_BG.Guardar_Archivo_BG(Lista_Banco_G, ucBa_Proceso_x_Banco.get_Proceso_Info(), cmbRuta.Text, nombre_file, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public void limpiar()
        {
            try
            {
                gridControlDetalleOP.DataSource = new ba_Archivo_Transferencia_Det_Info();
                txtObservacion.Text = "";
                ucBa_Proceso_x_Banco.cargar_CuentaBanco();
                 
                BindingList_Archivo_Detalle = new BindingList<ba_Archivo_Transferencia_Det_Info>();
                gridControlDetalleOP.DataSource = BindingList_Archivo_Detalle;


                
                gridControlDetalleCheques.DataSource =  new BindingList<ba_Archivo_Transferencia_Det_Info>();;

                

                dtpFechadesde.Value = DateTime.Now.AddMonths(-1);
                dtpFechaHasta.Value = DateTime.Now.AddDays(+1);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void cmbBuscar_Click(object sender, EventArgs e)
        {
            try
            {                
                BuscarOP();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ultraCmbE_empresaDest_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Empresa_Destino_Info = (tb_Empresa_Info)ultraCmbE_empresaDest.Properties.View.GetFocusedRow();
                if (Empresa_Destino_Info == null)
                {
                    Empresa_Destino_Info = lisEmp.Where(v => v.IdEmpresa == Convert.ToInt32(ultraCmbE_empresaDest.EditValue)).FirstOrDefault();
                }

                ListaCuentasBancarias = Cuentas_x_Bancos_BUS.Get_list_Banco_Cuenta(Convert.ToInt32( ultraCmbE_empresaDest.EditValue));
                cmbCuentaDestino.Properties.DataSource = ListaCuentasBancarias;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarProcesos()
        {
            try
            {
                bool bandera = false;
                txtObservacion.Focus();
                int IdCodigoLegalBanco = Convert.ToInt32(ucBa_Proceso_x_Banco.get_BaCuentaInfo().CodigoLegal);
                string IdProceso = ucBa_Proceso_x_Banco.get_Proceso_Info().IdProceso_bancario_tipo;
                switch (IdCodigoLegalBanco)
                {                        
                   case 10:    //PICHINCHA
                        switch (ucBa_Proceso_x_Banco.get_Proceso_Info().cod_Proceso)
                        {
                            case ebanco_procesos_bancarios_tipo.ROL_ELECTRONICO_BG:
                                bandera = true;
                                break;
                            case ebanco_procesos_bancarios_tipo.NCR:
                                bandera = true;
                                break;
                            
                            case ebanco_procesos_bancarios_tipo.TRANSF_BANCARIA_BP:
                                bandera = true;
                                break;
                            case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BP:
                                bandera = true;
                                break;
                            case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BOL:
                                bandera = true;
                                break;
                            case ebanco_procesos_bancarios_tipo.PREAVISO_CHEQ:
                                bandera = true;
                                break;
                            case ebanco_procesos_bancarios_tipo.PAGO_BANCO_PACIFICO_BPA:
                                bandera = true;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 17://GUAYAQUIL
                       switch (ucBa_Proceso_x_Banco.get_Proceso_Info().cod_Proceso)
	                    {
                            case ebanco_procesos_bancarios_tipo.ROL_ELECTRONICO_BG:
                                bandera = true;

                            break;
                           
                        case ebanco_procesos_bancarios_tipo.NCR:
                            bandera = true;

                            break;
                        case ebanco_procesos_bancarios_tipo.TRANSF_BANCARIA_BP:
                            bandera = true;

                            break;
                        case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BP:
                            bandera = true;

                            break;
                        case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BOL:
                            bandera = true;

                            break;
                        case ebanco_procesos_bancarios_tipo.PREAVISO_CHEQ:
                            bandera = true;

                            break;
                        case ebanco_procesos_bancarios_tipo.PAGO_BANCO_PACIFICO_BPA:
                            bandera = true;
                            break;
                        case ebanco_procesos_bancarios_tipo.PAGOS_MULTICASH:
                            bandera = true;
                            break;
                        default:
                            MessageBox.Show("No existe Programacion para el proceso seleccionado", param.Nombre_sistema,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
	                }

                        break;
                    case 34://BOLIVARIANO
                        switch (ucBa_Proceso_x_Banco.get_Proceso_Info().cod_Proceso)
	                       {
                            case ebanco_procesos_bancarios_tipo.ROL_ELECTRONICO_BG:
                                   bandera = true;
                                break;
                            
                            case ebanco_procesos_bancarios_tipo.NCR:
                                bandera = true;
                                break;
                            case ebanco_procesos_bancarios_tipo.TRANSF_BANCARIA_BP:
                                bandera = true;
                                break;
                            case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BP:
                                bandera = true;
                                break;
                            case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BOL:
                                bandera = true;
                                break;
                            case ebanco_procesos_bancarios_tipo.PREAVISO_CHEQ:
                                bandera = true;
                                break;
                            case ebanco_procesos_bancarios_tipo.PAGO_BANCO_PACIFICO_BPA:
                                bandera = true;
                                break;
                            default:
                                break;
 	                    }
                        break;
                    default:
                        MessageBox.Show("No existe Programacion para el banco seleccionado", param.Nombre_sistema,
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return bandera;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void cmbCuentaDestino_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cuenta_Destino_Info =(ba_Banco_Cuenta_Info) cmbCuentaDestino.Properties.View.GetFocusedRow();
                if (Cuenta_Destino_Info == null)
                {
                    Cuenta_Destino_Info = ListaCuentasBancarias.Where(v => v.IdBanco ==Convert.ToInt32( cmbCuentaDestino.EditValue)).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevaOP_Click(object sender, EventArgs e)
        {
            try
            {
                frmCP_Orden_Pago_Mant frmOP = new frmCP_Orden_Pago_Mant();
                frmOP = new frmCP_Orden_Pago_Mant(Cl_Enumeradores.eTipo_action.grabar);
                frmOP.Text = " ***NUEVO REGISTRO***";
                frmOP.MdiParent = this.MdiParent;
                frmOP.Show();
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_cheq_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_Cheques();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void Cargar_Cheques()
        {
            try
            {
                string sIdEstadoPreavisoCheq = "";
                DateTime FechaIni = dtpFechadesde_cheq.Value;
                DateTime FechaFin = dtpFechaHasta_cheq.Value;

                sIdEstadoPreavisoCheq = (chkMostar_che_Preavisados.Checked == true) ? "" : eEstado_Preaviso_Cheque.ES_CH_XPREAVISO_CH.ToString();

                ListCbteBan = BusCbteBan.Get_List_Cbte_Ban(param.IdEmpresa, InfoTipoCbte_x_CbteCble.IdTipoCbteCble, FechaIni, FechaFin, sIdEstadoPreavisoCheq, ref MensajeError);

                if (ListCbteBan.Count() == 0)
                {
                    MessageBox.Show("No hay cheques  para la consulta", param.Nombre_sistema,
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                BindingList_Archivo_Detalle_x_Cheq = new BindingList<ba_Archivo_Transferencia_Det_Info>();

                foreach (var item in ListCbteBan)
                {
                    ba_Archivo_Transferencia_Det_Info Detalle_Info = new Info.Bancos.ba_Archivo_Transferencia_Det_Info();
                    
                    Detalle_Info.IdEmpresa = item.IdEmpresa;
                    Detalle_Info.Valor = Convert.ToDecimal(item.cb_Valor);
                    Detalle_Info.Beneficiario = item.cb_giradoA;
                    Detalle_Info.IdTipoDocumento = item.IdTipoDocumento;
                    Detalle_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    Detalle_Info.Observacion_cheq = item.cb_Observacion;
                    Detalle_Info.cb_Fecha_cheq = item.cb_Fecha;
                    Detalle_Info.num_cheq = item.cb_Cheque;
                    Detalle_Info.giradoA_cheq = item.cb_giradoA;
                    Detalle_Info.IdEstado_Preaviso_ch_cat = item.IdEstado_Preaviso_ch_cat.ToString();
                    Detalle_Info.check = false;
                    Detalle_Info.IdEmpresa_mvba = item.IdEmpresa;
                    Detalle_Info.IdTipocbte_mvba = item.IdTipocbte;
                    Detalle_Info.IdCbteCble_mvba = item.IdCbteCble;

                    BindingList_Archivo_Detalle_x_Cheq.Add(Detalle_Info);
                }
                gridControlDetalleCheques.DataSource = BindingList_Archivo_Detalle_x_Cheq;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chk_selec_op_visible_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewDetalleOP.RowCount; i++)
                {
                    gridViewDetalleOP.SetRowCellValue(i, Colcheck_op, chk_selec_op_visible.Checked);    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDetalleOP_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == Colcheck_op)
                {
                    Sumar_op();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sumar_op()
        {
            try
            {
                decimal Total_op = 0;

                foreach (var item in BindingList_Archivo_Detalle)
                {
                    if(item.check)
                        Total_op += item.Valor;
                }

                txt_total_op.Text = Math.Round(Total_op, 2, MidpointRounding.AwayFromZero).ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDetalleOP_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == Colcheck_op)
                {
                    gridViewDetalleOP.SetRowCellValue(e.RowHandle, Colcheck_op, e.Value);    
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_selec_cheq_visible_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewDetalleCheq.RowCount; i++)
                {
                    gridViewDetalleCheq.SetRowCellValue(i, colchecked, chk_selec_cheq_visible.Checked);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDetalleCheq_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == colchecked)
                {
                    Sumar_cheque();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDetalleCheq_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == colchecked)
                {
                    gridViewDetalleCheq.SetRowCellValue(e.RowHandle, colchecked, e.Value);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sumar_cheque()
        {
            try
            {
                decimal total = 0;
                foreach (var item in BindingList_Archivo_Detalle_x_Cheq)
                {
                    if (item.check)                    
                        total += item.Valor;
                }
                txt_total_cheque.Text = Math.Round(total, 2, MidpointRounding.AwayFromZero).ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDetalleOP_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                Sumar_op();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDetalleCheq_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                Sumar_cheque();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Contabilizar()
        {
            try
            {
                bool res = true;
                if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    bool Se_contabiliza = ucBa_Proceso_x_Banco.get_Proceso_Info().Se_contabiliza == null ? false : Convert.ToBoolean(ucBa_Proceso_x_Banco.get_Proceso_Info().Se_contabiliza);
                    bool contabilizado = Archivo_Info.Contabilizado == null ? false : Convert.ToBoolean(Archivo_Info.Contabilizado);
                    if (Se_contabiliza && !contabilizado)
                    {
                        if (MessageBox.Show("¿Desea contabilizar el proceso " + ucBa_Proceso_x_Banco.get_Proceso_Info().nom_proceso_bancario + " # " + Archivo_Info.IdArchivo + "?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            splashScreenManager1.ShowWaitForm();
                            if (Archivo_Bus.Contabilizar_proceso(Archivo_Info, ucBa_Proceso_x_Banco.get_Proceso_Info(),Archivo_Info.Origen_Archivo))
                            {
                                MessageBox.Show("Se contabilizó el proceso correctamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                res = true;
                            }
                            splashScreenManager1.CloseWaitForm();
                        }
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                return false;
            }
        }

        private void Cargar_Bancos()
        {
            try
            {
                lista_bancos = bus_bancos.Get_List_Banco();
                cmb_banco.DataSource = lista_bancos;
                cmb_banco.ValueMember = "IdBanco_cta_Destino_trans";
                cmb_banco.DisplayMember = "ba_descripcion";
            }
            catch (Exception ex)
            {   
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnImprimir_pago_prov_Click(object sender, EventArgs e)
        {
            try
            {
                gridControlDetalleOP.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgrupar_x_proveedor_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btnAgrupar_x_proveedor.Text)
                {
                    case "Agrupar por proveedor":
                        btnAgrupar_x_proveedor.Text = "Eliminar agrupación";
                        Colproveedor.GroupIndex = 1;
                        break;
                    default:
                        btnAgrupar_x_proveedor.Text = "Agrupar por proveedor";
                        Colproveedor.GroupIndex = -1;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing(sender, e);
        }

        private void cmb_Motivo_Transferencia_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnContabilizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Contabilizar())
                {
                    MessageBox.Show("Contabilización exitosa", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    public class Secuencial_registro_x_persona
    {
        public string IdTipoPersona { get; set; }
        public decimal IdPersona { get; set; }
        public decimal IdEntidad { get; set; }
        public decimal Secuencial_reg_x_archivo { get; set; }
    }
}
