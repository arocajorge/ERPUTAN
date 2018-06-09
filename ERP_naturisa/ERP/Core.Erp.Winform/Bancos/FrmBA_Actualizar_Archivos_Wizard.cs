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
//using Microsoft.Office.Interop.Excel;


namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Actualizar_Archivos_Wizard : Form
    {
        #region atributos y variables
        string NombreArchivo = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<ba_Archivo_Transferencia_Det_Info> BList_Archivo_Excel = new BindingList<ba_Archivo_Transferencia_Det_Info>();
        BindingList<ba_Archivo_Transferencia_Det_Info> BList_Archivo_Actualizado = new BindingList<ba_Archivo_Transferencia_Det_Info>();
        ba_Archivo_Transferencia_Bus bus_Archivo = new ba_Archivo_Transferencia_Bus();
        ba_Archivo_Transferencia_Det_Bus bus_Archivo_Det = new ba_Archivo_Transferencia_Det_Bus();
        List<tb_banco_estado_reg__resp_bancaria_Info> List_Estados_x_banco = new List<tb_banco_estado_reg__resp_bancaria_Info>();
        tb_banco_estado_reg__resp_bancaria_Bus bus_Estados_x_banco = new tb_banco_estado_reg__resp_bancaria_Bus();
        public ba_Archivo_Transferencia_Info  info_Archivo { get; set; }
        ba_Res_Guayaquil_Bus bus_Guayaquil = new ba_Res_Guayaquil_Bus();
        ba_Res_Pichincha_Bus bus_Pichincha = new ba_Res_Pichincha_Bus();
        bool Bandera_pagina = true;
        bool Reg_inCorrecto = false;
        string MensajeError = "";
            
        #endregion

        #region Delegados
        public delegate void delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosed event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosed;

        public delegate void delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosing event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosing;
        #endregion

        #region Variables Para Carga de Excel
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        string plantilla = "Plantilla";
        DataTable dt;
        #endregion

        public FrmBA_Actualizar_Archivos_Wizard()
        {
            InitializeComponent();
            this.event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosed += FrmBA_Actualizar_Archivos_Wizard_event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosed;
            this.event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosing += FrmBA_Actualizar_Archivos_Wizard_event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosing;
        }

        void FrmBA_Actualizar_Archivos_Wizard_event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void FrmBA_Actualizar_Archivos_Wizard_event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                PU_OBTENER_RUTA();               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void PU_OBTENER_RUTA()
        {
            try
            {
                //Te Declaras un Objeto de Tipo OpenFileDialog
                OpenFileDialog dialogo = new OpenFileDialog();
                dialogo.Filter = "Todos los archivos (*.xls;*.xlsx)|*.xls;*.xlsx|Todos los archivos (*.*)|*.*";
                dialogo.InitialDirectory = @"C:\";
                //para mostrar el cuadro de seleccion de archivo hacemos asi:
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    fileName = System.IO.Path.GetFileName(dialogo.FileName);
                    path = Path.GetDirectoryName(dialogo.FileName);
                    tipofile = System.IO.Path.GetExtension(dialogo.FileName);
                    ruta = path + "\\" + fileName;
                    TxtRuraFile.Text = ruta;

                    NombreArchivo = fileName;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void Leer_y_Cargar_Excel()
        {
            try
            {
                string id_orden_bancaria = string.Empty;

                switch (info_Archivo.CodigoLegal)
                {
                    case "10":
                        BList_Archivo_Excel = new BindingList<ba_Archivo_Transferencia_Det_Info>(bus_Pichincha.Get_Res_Pichincha(info_Archivo,TxtRuraFile.Text, ref id_orden_bancaria));
                        if (BList_Archivo_Excel.Count != 0)
                        {
                            info_Archivo.IdOrden_Bancaria = id_orden_bancaria;
                            //info_Archivo.Fecha_Proceso = Convert.ToDateTime(BList_Archivo_Excel[0].Fecha_Proceso);
                        }
                        break;
                    case "17":
                        BList_Archivo_Excel = new BindingList<ba_Archivo_Transferencia_Det_Info>(bus_Guayaquil.Get_Res_Guayaquil(info_Archivo,TxtRuraFile.Text,ref id_orden_bancaria));
                        if (BList_Archivo_Excel.Count!=0)
                        {
                            info_Archivo.IdOrden_Bancaria = id_orden_bancaria;
                            info_Archivo.Fecha_Proceso = Convert.ToDateTime(BList_Archivo_Excel[0].Fecha_Proceso);
                        }
                        break;
                    default:
                        break;
                }
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

                info_Archivo.Archivo = bus_Archivo.Get_Archivo(info_Archivo.IdEmpresa, info_Archivo.IdArchivo,info_Archivo.IdProceso_bancario, info_Archivo.IdBanco);
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
                        switch (info_Archivo.CodigoLegal)
                        {
                            case "10" /*Pichincha*/:
                                Leer_y_Cargar_Excel();
                                Reg_inCorrecto = ValidarRegistros_Pichincha();
                                break;
                            case "17" /*Guayaquil*/:
                                Leer_y_Cargar_Excel();
                                Reg_inCorrecto = ValidarRegistros_Guayaquil();
                                break;
                            default:
                                break;
                        }
                        
                        lblError.Visible = !Reg_inCorrecto;
                        Bandera_pagina = Reg_inCorrecto;
                        break;
                    case "wpArchivo_Actualizado":
                        switch (info_Archivo.CodigoLegal)
                        {
                            case "10" /*Pichincha*/:
                                //Cargar_Grilla_Actualizacion_Pichincha();
                                Cargar_Grilla_Actualizacion_Guayaquil();
                                break;
                            case "17" /*Guayaquil*/:
                                switch (info_Archivo.IdProceso_bancario)
                                {
                                    case "ROL_ELECTRONICO_BG":
                                        Cargar_Grilla_Transferencia_Actualizacion_Guayaquil();
                                        break;
                                    default:
                                        Cargar_Grilla_Actualizacion_Guayaquil();
                                        break;
                                }
                                
                                break;
                            default:
                                break;
                        }
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
                gridViewArchivo_Plano.ViewCaption ="["+info_Archivo.IdArchivo.ToString()+"] "+ info_Archivo.Nom_Archivo;
                gridViewArchivo_Excel.ViewCaption = Path.GetFileNameWithoutExtension(TxtRuraFile.Text);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean ValidarRegistros_Guayaquil()
        {
            try
            {
                if (BList_Archivo_Excel.Count == 0)
                    return false;

                if (info_Archivo.Lst_Archivo_Transferencia_Det.Count != BList_Archivo_Excel.Count)
                    return false;
                if (info_Archivo.IdProceso_bancario!="TRANSFERENCIA_BANCARIA")
                {
                    int registros = 0;
                    foreach (ba_Archivo_Transferencia_Det_Info item_A in info_Archivo.Lst_Archivo_Transferencia_Det)
                    {
                        foreach (ba_Archivo_Transferencia_Det_Info item_E in BList_Archivo_Excel)
                        {
                            if ((item_A.pe_cedulaRuc.ToString().PadLeft(13, '0') == item_E.pe_cedulaRuc.ToString().PadLeft(13, '0') || (item_A.num_cta_acreditacion.ToString().PadLeft(13, '0') == item_E.pe_cedulaRuc.ToString().PadLeft(13, '0'))) && item_A.Valor == item_E.Valor)
                            {
                                registros++;
                                item_E.Secuencia = item_A.Secuencia;
                                item_E.pe_cedulaRuc = item_A.pe_cedulaRuc;
                                
                                item_E.IdEmpresa_pago = item_A.IdEmpresa_pago;
                                item_E.IdTipoCbte_pago = item_A.IdTipoCbte_pago;
                                item_E.IdCbteCble_pago = item_A.IdCbteCble_pago;
                                item_A.Genera_anulacion = item_E.Genera_anulacion;
                            }
                        }
                    }

                    if (registros != info_Archivo.Lst_Archivo_Transferencia_Det.Count)
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

        private Boolean ValidarRegistros_Pichincha()
        {
            try
            {
                if (BList_Archivo_Excel.Count == 0)
                    return false;

                if (info_Archivo.Lst_Archivo_Transferencia_Det.Count != BList_Archivo_Excel.Count)
                    return false;

                int registros = 0;
                foreach (ba_Archivo_Transferencia_Det_Info item_A in info_Archivo.Lst_Archivo_Transferencia_Det)
                {
                    foreach (ba_Archivo_Transferencia_Det_Info item_E in BList_Archivo_Excel)
                    {
                        if ((item_A.pe_cedulaRuc.ToString().PadLeft(13, '0') == item_E.pe_cedulaRuc.ToString().PadLeft(13, '0') || (item_A.num_cta_acreditacion.ToString().PadLeft(13, '0') == item_E.pe_cedulaRuc.ToString().PadLeft(13, '0'))) && item_A.Valor == item_E.Valor)
                        {
                            registros++;
                            item_E.Secuencia = item_A.Secuencia;
                            item_E.pe_cedulaRuc = item_A.pe_cedulaRuc;

                            item_E.IdEmpresa_pago = item_A.IdEmpresa_pago;
                            item_E.IdTipoCbte_pago = item_A.IdTipoCbte_pago;
                            item_E.IdCbteCble_pago = item_A.IdCbteCble_pago;
                            item_A.Genera_anulacion = item_E.Genera_anulacion;
                        }
                    }
                }

                if (registros != info_Archivo.Lst_Archivo_Transferencia_Det.Count)
                    return false;

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

        private void FrmBA_Actualizar_Archivos_Wizard_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListas();
                Configurar_grillas();
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
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info InfoParam_Banco = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus BusParam_Banco = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();

                InfoParam_Banco = BusParam_Banco.Get_info_Cbte_Ban_tipo_x_ct_CbteCble_tipo(param.IdEmpresa, "NDBA");
                int IdTipo_rev = InfoParam_Banco.IdTipoCbteCble_Anu;
                Boolean Actualizado = false;

                if (info_Archivo.IdProceso_bancario == "ROL_ELECTRONICO_BG")
                {
                    BList_Archivo_Excel[0].Secuencia = 1;
                }

                var lst = (from A in BList_Archivo_Actualizado
                           join E in BList_Archivo_Excel
                           on A.Id_Item equals E.Id_Item
                           select new
                           {
                               id_Item = A.Id_Item,
                               IdEstadoRegistro_cat = A.IdEstadoRegistro_cat,
                               nom_EstadoRegistro = E.nom_EstadoRegistro,
                               IdArchivo = E.IdArchivo,
                               IdEmpresa = E.IdEmpresa,
                               Secuencia = E.Secuencia,
                               Valor_cobrado = E.Valor_procesado,
                               Genera_anulacion = A.Genera_anulacion,

                               IdEmpresa_pago = A.IdEmpresa_pago,
                               IdTipoCbte_pago = A.IdTipoCbte_pago,
                               IdCbteCble_pago = A.IdCbteCble_pago,
                               cb_Estado = A.cb_Estado
                           });
                progressBarActualizacion.Properties.Step = 1;
                progressBarActualizacion.Properties.PercentView = true;
                progressBarActualizacion.Properties.Maximum = lst.Count();
                progressBarActualizacion.Properties.Minimum = 0;

                foreach (var item in lst)
                {
                    info_Archivo.Lst_Archivo_Transferencia_Det.FirstOrDefault(q => q.Secuencia == item.Secuencia).IdEstadoRegistro_cat = BList_Archivo_Actualizado.FirstOrDefault(q => q.Id_Item == item.id_Item).IdEstadoRegistro_cat = item.IdEstadoRegistro_cat;
                    info_Archivo.Lst_Archivo_Transferencia_Det.FirstOrDefault(q => q.Secuencia == item.Secuencia).nom_EstadoRegistro = BList_Archivo_Actualizado.FirstOrDefault(q => q.Id_Item == item.id_Item).nom_EstadoRegistro = item.nom_EstadoRegistro;
                    BList_Archivo_Actualizado.FirstOrDefault(q => q.Id_Item == item.id_Item).IdArchivo = item.IdArchivo;
                    BList_Archivo_Actualizado.FirstOrDefault(q => q.Id_Item == item.id_Item).IdEmpresa = item.IdEmpresa;
                    BList_Archivo_Actualizado.FirstOrDefault(q => q.Id_Item == item.id_Item).Secuencia = item.Secuencia;
                    BList_Archivo_Actualizado.FirstOrDefault(q => q.Id_Item == item.id_Item).Valor_cobrado = item.Valor_cobrado;
                    BList_Archivo_Actualizado.FirstOrDefault(q => q.Id_Item == item.id_Item).IdProceso_bancario = info_Archivo.IdProceso_bancario;
                    Actualizado= BList_Archivo_Actualizado.FirstOrDefault(q => q.Id_Item == item.id_Item).Actualizado = bus_Archivo_Det.Actualizar_registro(BList_Archivo_Actualizado.FirstOrDefault(q => q.Id_Item == item.id_Item));

                    if (!Actualizado)
                    {
                        MessageBox.Show("No se pudo actualizar los registros", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    }
                    else
                    {
                        if (item.Genera_anulacion == true && item.cb_Estado == "A")
                        {
                            ba_Cbte_Ban_Bus bus_cbteBan = new ba_Cbte_Ban_Bus();
                            ba_Cbte_Ban_Info info_cbteBan = new ba_Cbte_Ban_Info();
                            info_cbteBan = bus_cbteBan.Get_Info_Cbte_Ban(Convert.ToInt32(item.IdEmpresa_pago), Convert.ToInt32(item.IdTipoCbte_pago), Convert.ToDecimal(item.IdCbteCble_pago), ref MensajeError);
                            if (info_cbteBan != null && info_cbteBan.IdEmpresa != 0)
                            {
                                ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
                                ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();

                                info_cbteBan.MotivoAnulacion = "Anulado x actualización de archivo";
                                info_cbteBan.IdUsuario_Anu = param.IdUsuario;
                                info_cbteBan.FechaAnulacion = param.Fecha_Transac;
                                decimal IdCbteCble_rev = 0;
                                CbteCble_B.ReversoCbteCble(Convert.ToInt32(item.IdEmpresa_pago), Convert.ToDecimal(item.IdCbteCble_pago), Convert.ToInt32(item.IdTipoCbte_pago), IdTipo_rev, ref IdCbteCble_rev, ref MensajeError, info_cbteBan.MotivoAnulacion);
                                
                                info_cbteBan.IdTipoCbte_Anulacion = IdTipo_rev;
                                info_cbteBan.IdCbteCble_Anulacion = IdCbteCble_rev;
                                cp_orden_pago_cancelaciones_Bus OGPagos_B = new cp_orden_pago_cancelaciones_Bus();
                                OGPagos_B.Eliminar_OrdenPagoCancelaciones(info_cbteBan.IdEmpresa, info_cbteBan.IdTipocbte, info_cbteBan.IdCbteCble, ref MensajeError);
                                bus_cbteBan.AnularDB(info_cbteBan, ref MensajeError);
                            }
                        }
                    }
                    progressBarActualizacion.PerformStep();
                    progressBarActualizacion.Update();
                    gridControlActualizacion.RefreshDataSource();
                }
                BList_Archivo_Actualizado = new BindingList<ba_Archivo_Transferencia_Det_Info>(bus_Archivo_Det.Get_List_Archivo_transferencia_Det(info_Archivo.IdEmpresa, info_Archivo.IdArchivo));
                gridControlActualizacion.RefreshDataSource();

                Actualizado = bus_Archivo.Actualizar_Archivo(info_Archivo);
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

        private void Cargar_Grilla_Actualizacion_Guayaquil()
        {
            try
            {
                BList_Archivo_Actualizado = new BindingList<ba_Archivo_Transferencia_Det_Info>();

                var lst = (from A in info_Archivo.Lst_Archivo_Transferencia_Det
                                             join E in BList_Archivo_Excel 
                           on A.pe_cedulaRuc equals E.pe_cedulaRuc
                                             select new 
                                             {
                                                 Actualizado = A.IdEstadoRegistro_cat == E.IdEstadoRegistro_cat ? true : false,
                                                 Id_Item = E.Id_Item,
                                                 pe_cedulaRuc = A.pe_cedulaRuc,
                                                 pe_nombreCompleto = A.pe_nombreCompleto,
                                                 Valor = E.Valor,
                                                 Valor_cobrado = E.Valor_cobrado,
                                                 Saldo = E.Saldo,
                                                 IdEstadoRegistro_cat = E.IdEstadoRegistro_cat,
                                                 nom_EstadoRegistro = E.nom_EstadoRegistro,

                                                 IdEmpresa_pago = A.IdEmpresa_pago,
                                                 IdTipoCbte_pago = A.IdTipoCbte_pago,
                                                 IdCbteCble_pago = A.IdCbteCble_pago,
                                                 Genera_anulacion = A.Genera_anulacion,

                                             }).OrderBy(q=>q.Actualizado);

                foreach (var item in lst)
                {
                    ba_Archivo_Transferencia_Det_Info Info = new ba_Archivo_Transferencia_Det_Info();
                    Info.Actualizado = item.Actualizado;
                    Info.Id_Item = item.Id_Item;
                    Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    Info.Valor = item.Valor;
                    Info.Valor_cobrado = item.Valor_cobrado;
                    Info.Saldo = item.Saldo;
                    Info.IdEstadoRegistro_cat = item.IdEstadoRegistro_cat;
                    Info.nom_EstadoRegistro = item.nom_EstadoRegistro;

                    Info.IdEmpresa_pago = item.IdEmpresa_pago;
                    Info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                    Info.IdCbteCble_pago = item.IdCbteCble_pago;

                    Info.Genera_anulacion = item.Genera_anulacion;
                    BList_Archivo_Actualizado.Add(Info);
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

        private void Cargar_Grilla_Transferencia_Actualizacion_Guayaquil()
        {
            try
            {
                BList_Archivo_Actualizado = new BindingList<ba_Archivo_Transferencia_Det_Info>();

                var lst = (from A in info_Archivo.Lst_Archivo_Transferencia_Det
                           from E in BList_Archivo_Excel
                           select new
                           {
                               Actualizado = A.IdEstadoRegistro_cat == E.IdEstadoRegistro_cat ? true : false,
                               Id_Item = E.Id_Item,
                               pe_cedulaRuc = E.pe_cedulaRuc,
                               Nombre = E.pe_nombreCompleto,
                               Valor = E.Valor,
                               Valor_cobrado = E.Valor_cobrado,
                               Saldo = E.Saldo,
                               IdEstadoRegistro_cat = A.IdEstadoRegistro_cat,
                               nom_EstadoRegistro = A.nom_EstadoRegistro,
                           }).OrderBy(q => q.Actualizado);

                foreach (var item in lst)
                {
                    ba_Archivo_Transferencia_Det_Info Info = new ba_Archivo_Transferencia_Det_Info();
                    Info.Actualizado = item.Actualizado;
                    Info.Id_Item = item.Id_Item;
                    Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    Info.pe_nombreCompleto = item.Nombre;
                    Info.Valor = item.Valor;
                    Info.Valor_cobrado = item.Valor_cobrado;
                    Info.Saldo = item.Saldo;
                    Info.IdEstadoRegistro_cat = item.IdEstadoRegistro_cat;
                    Info.nom_EstadoRegistro = item.nom_EstadoRegistro;
                    BList_Archivo_Actualizado.Add(Info);
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

        private void Cargar_Grilla_Actualizacion_Pichincha()
        {
            try
            {
                BList_Archivo_Actualizado = new BindingList<ba_Archivo_Transferencia_Det_Info>();

                var lst = (from A in info_Archivo.Lst_Archivo_Transferencia_Det
                           join E in BList_Archivo_Excel on
                           A.num_cta_acreditacion equals E.pe_cedulaRuc
                           select new
                           {
                               Actualizado = A.IdEstadoRegistro_cat == E.IdEstadoRegistro_cat ? true : false,
                               Id_Item = E.Id_Item,
                               pe_cedulaRuc = E.pe_cedulaRuc,
                               Nombre = A.pe_nombreCompleto,
                               Valor = E.Valor,
                               Valor_cobrado = E.Valor_cobrado,
                               Saldo = E.Saldo,
                               IdEstadoRegistro_cat = A.IdEstadoRegistro_cat,
                               nom_EstadoRegistro = A.nom_EstadoRegistro,
                               Secuencia = A.Secuencia,
                           }).OrderBy(q => q.Actualizado);

                foreach (var item in lst)
                {
                    ba_Archivo_Transferencia_Det_Info Info = new ba_Archivo_Transferencia_Det_Info();
                    Info.Actualizado = item.Actualizado;
                    Info.Id_Item = item.Id_Item;
                    Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    Info.pe_nombreCompleto = item.Nombre;
                    Info.Valor = item.Valor;
                    //Info.Valor_cobrado = item.Valor_cobrado;
                    //Info.Saldo = item.Saldo;
                    Info.IdEstadoRegistro_cat = item.IdEstadoRegistro_cat;
                    Info.nom_EstadoRegistro = item.nom_EstadoRegistro;
                    Info.Secuencia = item.Secuencia;
                    BList_Archivo_Actualizado.Add(Info);
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

        private void CargarListas()
        {
            try
            {
                List_Estados_x_banco = bus_Estados_x_banco.Get_Lista_Estados();
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
                    case "wpSeleccion_archivo_excel":
                        Bandera_pagina = Validar_seleccion_excel();
                        break;
                    case "wpArchivo_Seleccionado":
                       
                        break;
                    case "wpArchivos_actuales":
                        Bandera_pagina = Reg_inCorrecto;
                        if (!Bandera_pagina)
                        {
                            MessageBox.Show("Existe inconsistencia de registros, favor seleccione el archivo correcto.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case "wpArchivo_Actualizado":
                        switch (info_Archivo.CodigoLegal)
                        {
                            case "10" /*Pichincha*/:
                                Bandera_pagina = ValidarRegistros_Pichincha();
                                break;
                            case "17" /*Guayaquil*/:
                                Bandera_pagina = ValidarRegistros_Guayaquil();
                                break;
                            default:
                                break;
                        }
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

        private Boolean Validar_seleccion_excel()
        {
            try
            {
                bool res = true;

                if (TxtRuraFile.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione el archivo de excel enviado por el banco.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    res = false;
                }
                else
                    res = true;

                return res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void wpSeleccion_archivo_excel_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
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

        private void Configurar_grillas()
        {
            try
            {
                switch (info_Archivo.CodigoLegal)
                {
                    case "10" /*Pichincha*/:

                        colpe_cedulaRuc_E.Caption = "Cuenta";
                        colValor_E.Caption = "Valor";
                        colValor_procesado.Visible = true;
                        colSaldo.Visible = true;

                        colNum_cta.Visible = true;
                        colCedula.Visible = false;

                        colValor_procesadoAct.Visible = false;
                        colSaldoAct.Visible = false;
                        colIdentificacion.Caption = "Cuenta";
                        
                        break;
                    case "17" /*Guayaquil*/:
                        colpe_cedulaRuc_E.Caption = "Identificación";
                        colValor_E.Caption = "Valor enviado";
                        colValor_procesado.Visible = true;
                        colSaldo.Visible = true;

                        colNum_cta.Visible = false;
                        colCedula.Visible = true;

                        colValor_procesadoAct.Visible = true;
                        colSaldoAct.Visible = true;
                        colIdentificacion.Caption = "Identificación";

                        switch (info_Archivo.IdProceso_bancario)
                        {
                            case "TRANSFERENCIA_BANCARIA":
                                colNombre.Visible = false;
                                colCedula.Visible = false;
                                break;
                            default:

                                break;
                        }
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

        private void FrmBA_Actualizar_Archivos_Wizard_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmBA_Actualizar_Archivos_Wizard_event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosed(sender, e);
        }

        private void FrmBA_Actualizar_Archivos_Wizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmBA_Actualizar_Archivos_Wizard_event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosing(sender, e);
        }

        private string Get_IdOrden_Guayaquil(string Cadena)
        {
            try
            {
                string remover_cadena = "Detalle de la orden ";
                Cadena = Cadena.Substring(remover_cadena.Length,8).Trim();
                return Cadena;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return string.Empty;
            }
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
        
    }
}
