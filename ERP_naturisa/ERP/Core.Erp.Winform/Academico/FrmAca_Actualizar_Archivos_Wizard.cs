using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Office;
using DevExpress.XtraRichEdit.Utils;
using System.Text.RegularExpressions;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.Bancos.Respuesta_Bancos;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
//using Microsoft.Office.Interop.Excel;


namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Actualizar_Archivos_Wizard : Form
    {
        #region atributos y variables
        string NombreArchivo = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<ba_Archivo_Transferencia_Det_Info> BList_Archivo_Excel = new BindingList<ba_Archivo_Transferencia_Det_Info>();
        BindingList<ba_Archivo_Transferencia_Det_Info> BList_Archivo_Actualizado = new BindingList<ba_Archivo_Transferencia_Det_Info>();
        ba_Archivo_Transferencia_Bus bus_Archivo = new ba_Archivo_Transferencia_Bus();
        ba_Archivo_Transferencia_Det_Bus bus_Archivo_Det = new ba_Archivo_Transferencia_Det_Bus();
        public ba_Archivo_Transferencia_Info info_Archivo { get; set; }        
        bool Bandera_pagina = true;
        bool Reg_inCorrecto = false;
        string MensajeError = "";

        cxc_cobro_Bus bus_cobro = new cxc_cobro_Bus();
        cxc_cobro_Info info_cobro = new cxc_cobro_Info();
        cxc_parametro_Info info_parametro_cxc = new cxc_parametro_Info();
        cxc_parametro_Bus bus_parametro_cxc = new cxc_parametro_Bus();
        fa_factura_Info info_factura = new fa_factura_Info();
        fa_factura_Bus bus_factura = new fa_factura_Bus();
        #endregion

        #region Delegados
        public delegate void delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosed event_delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosed;

        public delegate void delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosing event_delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosing;
        #endregion

        #region Variables Para Carga de Excel
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        string plantilla = "Plantilla";
        DataTable dt;
        #endregion

        public FrmAca_Actualizar_Archivos_Wizard()
        {
            InitializeComponent();
            this.event_delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosed += FrmAca_Actualizar_Archivos_Wizard_event_delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosed;
            this.event_delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosing += FrmAca_Actualizar_Archivos_Wizard_event_delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosing;
        }

        void FrmAca_Actualizar_Archivos_Wizard_event_delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void FrmAca_Actualizar_Archivos_Wizard_event_delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        void Leer_y_Cargar_Excel()
        {
            try
            {
                string id_orden_bancaria = string.Empty;

                BList_Archivo_Excel = new BindingList<ba_Archivo_Transferencia_Det_Info>();

                info_Archivo.Lst_Archivo_Transferencia_Det = bus_Archivo_Det.Get_List_Archivo_transferencia_Det(info_Archivo.IdEmpresa, info_Archivo.IdArchivo);
                BList_Archivo_Actualizado = new BindingList<ba_Archivo_Transferencia_Det_Info>(info_Archivo.Lst_Archivo_Transferencia_Det);
                gridControlArchivo_Plano.DataSource = BList_Archivo_Actualizado;

                gridControlArchivo_Excel.DataSource = null;
                gridControlArchivo_Excel.DataSource = BList_Archivo_Excel;
            }
            catch (Exception ex)
            {
                Bandera_pagina = false;
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public string LimpiarCadena(string strIn)
        {
            // Replace invalid characters with empty strings.
            try
            {
                return Regex.Replace(strIn, @"[^\w\.@-]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }

            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }

        public void Setear_Archivo()
        {
            try
            {

                info_Archivo.Archivo = bus_Archivo.Get_Archivo(info_Archivo.IdEmpresa, info_Archivo.IdArchivo, info_Archivo.IdProceso_bancario, info_Archivo.IdBanco);
                if (info_Archivo.Archivo.Length != 0)
                {
                    Stream myStream = new MemoryStream(info_Archivo.Archivo);
                    RTBArchivo_Plano.LoadFile(myStream, RichTextBoxStreamType.PlainText);
                    txtNom_Archivo.Text = info_Archivo.Nom_Archivo;
                    txtBanco.Text = info_Archivo.nom_banco;
                    txtProceso.Text = info_Archivo.nom_proceso_bancario;
                    txtId.Text = info_Archivo.IdArchivo.ToString();
                }
                else
                    MessageBox.Show("No existe archivo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void wizardControlActualizar_Archivo_SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
            try
            {
                switch (e.Page.Name)
                {
                    case "wpArchivo_Seleccionado":
                        Setear_Archivo();
                        break;
                    case "wpArchivos_actuales":
                        LlenarGridViewArchivo_Plano();
                        Leer_y_Cargar_Excel();
                        break;
                    case "wpArchivo_Actualizado":
                        Cargar_Grilla_Actualizacion_academico();
                        progressBarActualizacion.ResetText();
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

        private void LlenarGridViewArchivo_Plano()
        {
            try
            {
                gridControlArchivo_Plano.DataSource = info_Archivo.Lst_Archivo_Transferencia_Det;
                gridViewArchivo_Plano.ViewCaption = "[" + info_Archivo.IdArchivo.ToString() + "] " + info_Archivo.Nom_Archivo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean ValidarRegistros_academico()
        {
            try
            {
                if (Math.Round(info_Archivo.Lst_Archivo_Transferencia_Det.Sum(q=>q.Saldo),2,MidpointRounding.AwayFromZero) == 0)
                {
                    MessageBox.Show("No existen valores pendientes por cobrar en el archivo seleccionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (BList_Archivo_Excel.Count == 0)
                {
                    MessageBox.Show("Ingrese el archivo de respuesta del banco",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (info_Archivo.Lst_Archivo_Transferencia_Det.Count != BList_Archivo_Excel.Count)
                {
                    MessageBox.Show("La cantidad de registros de respuesta son distintos a los del archivo seleccionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (info_Archivo.Lst_Archivo_Transferencia_Det.Where(q => q.IdEmpresa_fac == null).Count() > 0)
                {
                    MessageBox.Show("Los registros del archivo no han sido facturados", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                int registros = 0;
                foreach (ba_Archivo_Transferencia_Det_Info item_A in info_Archivo.Lst_Archivo_Transferencia_Det)
                {
                    foreach (ba_Archivo_Transferencia_Det_Info item_E in BList_Archivo_Excel)
                    {
                        if ((item_A.pe_cedulaRuc.ToString().PadLeft(30, '0') == item_E.pe_cedulaRuc.ToString().PadLeft(30, '0')) && (item_A.Valor == item_E.Valor))
                        {
                            item_E.IdEmpresa = item_A.IdEmpresa;
                            item_E.IdArchivo = item_A.IdArchivo;
                            item_E.Secuencia = item_A.Secuencia;
                            item_A.Id_Item = item_E.Id_Item;
                            break;
                        }
                    }
                }

                registros = BList_Archivo_Excel.Where(q => q.IdArchivo != 0).Count();
                    if (registros != info_Archivo.Lst_Archivo_Transferencia_Det.Count)
                    {
                        MessageBox.Show("No se pudo relacionar todos los registros del archivo enviado con los de la respuesta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void FrmAca_Actualizar_Archivos_Wizard_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Actualizar_Registros();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Actualizar_Registros()
        {
            try
            {
                Boolean Actualizado = false;

                info_parametro_cxc = bus_parametro_cxc.Get_Info_parametro(param.IdEmpresa);                

                progressBarActualizacion.Properties.Step = 1;
                progressBarActualizacion.Properties.PercentView = true;
                progressBarActualizacion.Properties.Maximum = BList_Archivo_Actualizado.Count();
                progressBarActualizacion.Properties.Minimum = 0;

                foreach (var item in BList_Archivo_Actualizado)
                {
                    if (item.Saldo > 0)
                    {
                        if (item.Valor_cobrado != 0)
                        {
                            info_factura = bus_factura.Get_Info_factura(Convert.ToInt32(item.IdEmpresa_fac), Convert.ToInt32(item.IdSucursal_fac), Convert.ToInt32(item.IdBodega_fac), Convert.ToDecimal(item.IdCbteVta_fac));
                            if (info_factura.IdEmpresa != 0)
                            {
                                //Hago cobro normal
                                if (bus_cobro.generar_cobro_x_factura(info_factura, Convert.ToDouble(item.Valor_cobrado), info_parametro_cxc.pa_IdCobro_tipo_default, DateTime.Now.Date, info_Archivo.IdBanco))
                                {
                                    item.Fecha_Proceso = BList_Archivo_Excel.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdArchivo == item.IdArchivo && q.Secuencia == item.Secuencia).Fecha_Proceso;
                                    item.Contabilizado = true;
                                    item.Valor_cobrado = item.Valor_cobrado;
                                    item.Actualizado = bus_Archivo_Det.Actualizar_registro(item);
                                    Actualizado = item.Actualizado;
                                }
                                if (item.Valor_comision != 0)
                                {
                                    //Cobro por comision
                                    if (bus_cobro.generar_cobro_x_factura(info_factura, Convert.ToDouble(item.Valor_comision), info_parametro_cxc.pa_IdCobro_tipo_Comision_TC, DateTime.Now.Date, info_Archivo.IdBanco))
                                    {
                                        item.Valor_cobrado = item.Valor_cobrado + item.Valor_comision;
                                        item.Actualizado = bus_Archivo_Det.Actualizar_registro(item);
                                        Actualizado = item.Actualizado;
                                    }
                                }
                            }

                            if (!Actualizado)
                            {
                                MessageBox.Show("No se pudo actualizar los registros", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                break;
                            }
                        }

                    }
                    info_Archivo.Fecha_Proceso = item.Fecha_Proceso;

                    progressBarActualizacion.PerformStep();
                    progressBarActualizacion.Update();
                    gridControlActualizacion.RefreshDataSource();
                }
                info_Archivo.Contabilizado = Actualizado;
                info_Archivo.Contabilizado = true;
                gridControlActualizacion.RefreshDataSource();
                if (bus_Archivo.Generar_deposito(info_Archivo))
                {
                    Actualizado = bus_Archivo.Actualizar_Archivo(info_Archivo);    
                }                
                if (Actualizado)
                {
                    MessageBox.Show("Archivo actualizado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Cargar_Grilla_Actualizacion_academico()
        {
            try
            {
                BList_Archivo_Actualizado = new BindingList<ba_Archivo_Transferencia_Det_Info>();

                var lst = from A in info_Archivo.Lst_Archivo_Transferencia_Det
                          join E in BList_Archivo_Excel
                          on new { A.IdEmpresa, A.IdArchivo, A.Secuencia } equals new { E.IdEmpresa, E.IdArchivo, E.Secuencia }
                          select new
                          {
                              A.IdEmpresa,
                              A.IdArchivo,
                              A.Secuencia,
                              E.Valor,
                              E.Valor_cobrado,
                              E.Valor_comision,
                              A.Saldo,
                              Actualizado = false,
                              A.pe_nombreCompleto,
                              A.pe_cedulaRuc,
                              A.Id_Item,

                              A.IdEmpresa_fac,
                              A.IdSucursal_fac,
                              A.IdBodega_fac,
                              A.IdCbteVta_fac
                          };

                foreach (var item in lst)
                {
                    ba_Archivo_Transferencia_Det_Info info = new ba_Archivo_Transferencia_Det_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdArchivo = item.IdArchivo;
                    info.Secuencia = item.Secuencia;
                    info.Valor = item.Valor;
                    info.Valor_cobrado = item.Valor_cobrado;
                    info.Valor_comision = item.Valor_comision;
                    info.Saldo = item.Saldo;
                    info.Actualizado = item.Actualizado;
                    info.pe_nombreCompleto = item.pe_nombreCompleto;
                    info.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.Id_Item = item.Id_Item;

                    info.IdEmpresa_fac = item.IdEmpresa_fac;
                    info.IdSucursal_fac = item.IdSucursal_fac;
                    info.IdBodega_fac = item.IdBodega_fac;
                    info.IdCbteVta_fac = item.IdCbteVta_fac;

                    BList_Archivo_Actualizado.Add(info);
                }


                gridControlActualizacion.DataSource = BList_Archivo_Actualizado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void wizardControlActualizar_Archivo_CancelClick(object sender, CancelEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea Salir Del Asistente de Actualización de archivos?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void wizardControlActualizar_Archivo_FinishClick(object sender, CancelEventArgs e)
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

        private void wizardControlActualizar_Archivo_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            try
            {
                switch (e.Page.Name)
                {
                    case "wpArchivo_Seleccionado":

                        break;
                    case "wpArchivos_actuales":
                        Reg_inCorrecto = ValidarRegistros_academico();
                        lblError.Visible = !Reg_inCorrecto;
                        Bandera_pagina = Reg_inCorrecto;
                        break;
                    case "wpArchivo_Actualizado":
                        ValidarRegistros_academico();
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

        private void wpArchivos_Actuales_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            try
            {



                e.Valid = Bandera_pagina;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void wizardControlActualizar_Archivo_PrevClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            try
            {
                Bandera_pagina = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmAca_Actualizar_Archivos_Wizard_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAca_Actualizar_Archivos_Wizard_event_delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosed(sender, e);
        }

        private void FrmAca_Actualizar_Archivos_Wizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAca_Actualizar_Archivos_Wizard_event_delegate_FrmAca_Actualizar_Archivos_Wizard_FormClosing(sender, e);
        }

        private DateTime Get_Fecha_Proceso(int SerialDate)
        {
            try
            {
                if (SerialDate > 59) SerialDate -= 1; //Excel/Lotus 2/29/1900 bug   
                return new DateTime(1899, 12, 31).AddDays(SerialDate);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new DateTime();
            }
        }

       
        private void gridViewArchivo_Excel_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // para pegar en las columnas en el mismo orden 
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    Pegar_Data();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return "";

                if (iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return "";
            }
            set { Clipboard.SetDataObject(value); }
        }

        private void Pegar_Data()
        {
            try
            {
                string[] data = ClipboardData.Split('\n');
                if (data.Length < 1) return;
                foreach (string row in data)
                {
                    if (!Agregar_fila_copiada(row))
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private Boolean Agregar_fila_copiada(string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });


                //posicion de la fila pegada
                //cod_alumno |  nom_alumno | num_cuenta_tarjeta | Fecha_proceso | valor | valor_cobrado | valor_comision |

                ba_Archivo_Transferencia_Det_Info newRow = new ba_Archivo_Transferencia_Det_Info();
                if (rowData.Count() >= 3) //return false;          
                {

                    string cod_alumno = rowData[0];
                    string nom_alumno = rowData[2];
                    string num_cuenta_tarjeta = rowData[1];
                    string fecha_proceso = rowData[3];
                    string valor = rowData[4];
                    string valor_cobrado = rowData[5];
                    string Valor_comision = rowData[6];

                    ba_Archivo_Transferencia_Det_Info emp = new ba_Archivo_Transferencia_Det_Info();
                    if (!string.IsNullOrWhiteSpace(cod_alumno))
                    {
                        newRow.Id_Item = cod_alumno;
                        newRow.pe_nombreCompleto = nom_alumno;
                        newRow.pe_cedulaRuc = cod_alumno;
                        newRow.num_cta_acreditacion = num_cuenta_tarjeta;
                        newRow.Fecha_Proceso = fecha_proceso == "" ? DateTime.Now.Date : Convert.ToDateTime(fecha_proceso);
                        newRow.Valor = valor == "" ? 0 : Convert.ToDecimal(valor);
                        newRow.Valor_cobrado = valor_cobrado == "" ? 0 : Convert.ToDecimal(valor_cobrado);
                        newRow.Valor_comision = Valor_comision == "" ? 0 : Convert.ToDecimal(Valor_comision);
                    }

                    BList_Archivo_Excel.Add(newRow);
                    return true;
                }
                else
                {
                    MessageBox.Show("No hay las columnas necesarias para insertar al registros");
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + "El formato debe ser el siguiente\n" + "cod_alumno |  nom_alumno | num_cuenta_tarjeta | Fecha_proceso | valor | valor_cobrado | valor_comision |", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gridControlArchivo_Plano.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void lbl_plantilla_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string filePath = null;
                sfdWizard.Filter = "(*.xls)|*.xls|Excel 97 - 2003 (*.*)|*.*";
                if (sfdWizard.ShowDialog() == DialogResult.OK)
                {
                    filePath = sfdWizard.FileName;
                    File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_respuesta_colecturia);
                    MessageBox.Show("Archivo descargado con exito.\r\n\r\n" + filePath, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
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
