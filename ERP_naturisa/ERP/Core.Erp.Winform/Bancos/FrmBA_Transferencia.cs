using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Winform.General;
using System.Diagnostics;
using System.IO;
using Core.Erp.Info.CuentasxPagar.Archivos_Pagos_Bancos;
namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Transferencia : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private int IdEmpresaDestino = 0;
        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> listParaBan = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info paramBa_I_ND = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info paramBa_I_NC = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();

        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus paramBa_B = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        tb_Empresa_Bus Empresa_B = new tb_Empresa_Bus();
        List<tb_Empresa_Info> lisEmp = new List<tb_Empresa_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        string ctaCble_acreedoraCredito, ctaCble_acreedoraDebito;
        DataTable dt_ND = new DataTable("diarioCtbl_ND");
        DataTable dt_NC = new DataTable("diarioCtbl_NC");
        ba_Banco_Cuenta_Info _b_ND = new ba_Banco_Cuenta_Info();
        ba_Banco_Cuenta_Info _b_NC = new ba_Banco_Cuenta_Info();
        public List<ct_Cbtecble_det_Info> _ListaCbteCbleDetAnt_ND = new List<ct_Cbtecble_det_Info>();
        public List<ct_Cbtecble_det_Info> _ListaCbteCbleDetAnt_NC = new List<ct_Cbtecble_det_Info>();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        public List<ct_Cbtecble_det_Info> _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
        ct_Cbtecble_Info CbteCble_I_ND = new ct_Cbtecble_Info();
        ct_Cbtecble_Info CbteCble_I_NC = new ct_Cbtecble_Info();
        private Cl_Enumeradores.eTipo_action _Accion;
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        decimal idCbteCble = 0;
        string cod_CbteCble = "";
        string cod_CbteCble_ND = "";
        string cod_CbteCble_NC = "";
        ba_transferencia_Info transf_I = new ba_transferencia_Info();
        ba_transferencia_Bus transf_B = new ba_transferencia_Bus();
        ba_Cbte_Ban_Info Info_CbteBan_I = new ba_Cbte_Ban_Info();
        ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
        UCGe_ModificaCbte UC_BtnValidadModifCbt = new UCGe_ModificaCbte();
        decimal NTransf;
        int _IdTipoCbte_ND = 0;
        int _IdTipoCbte_NC = 0;
        decimal IdCbtCble_ND = 0;
        decimal IdCbtCble_NC = 0;
        string MensajeError = "";
        public delegate void delegate_FrmBA_Transferencia_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBA_Transferencia_FormClosing event_FrmBA_Transferencia_FormClosing;

      
         

        #endregion

        public FrmBA_Transferencia()
        {
            try
            {
                InitializeComponent();
                event_FrmBA_Transferencia_FormClosing+=FrmBA_Transferencia_event_FrmBA_Transferencia_FormClosing;
                UC_BtnValidadModifCbt.Dock = DockStyle.Fill;
                UC_BtnValidadModifCbt.event_btn_PermisoModiCbt_Click += new UCGe_ModificaCbte.delegate_btn_PermisoModiCbt_Click(UC_BtnValidadModifCbt_event_btn_PermisoModiCbt_Click);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
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

      

        private void ultraCmbE_empresaDest_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmbE_empresaDest.EditValue == null)
                    ultraCmbE_empresaDest.EditValue = "";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

       

        private void validaParametrosOtraEmpresa(int IdEmpresa)
        {
            try
            {
                List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> lst = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info par = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
                lst = paramBa_B.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(IdEmpresa);

                par = lst.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "NCBA"; });

                if (par == null)
                {
                    MessageBox.Show("No puede continuar porque no han ingresado los parámetros de banco para la Empresa " + ultraCmbE_empresaDest.Text + " .. \n Ingréselos desde la pantalla de parámetros de banco o comuníquese  con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_grabar.Enabled = false;
                    btn_grabarysalir.Enabled = false;
                    //  this.Close();
                }
                else
                {
                    if (par.IdTipoCbteCble < 1)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco para la Empresa " + ultraCmbE_empresaDest.Text + " (Falta ingresar el tipo de Cbte. para las notas de Credito)..\n Ingréselos desde la pantalla Banco Parámetros o, comuníquese  con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btn_grabar.Enabled = false;
                        btn_grabarysalir.Enabled = false;
                        this.Close();
                    }
                    else if (par.IdCtaCble == null || par.IdCtaCble == "")
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco  para la Empresa " + ultraCmbE_empresaDest.Text + " (Falta ingresar la Cuenta Cble. para las notas de Credito)..\n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btn_grabar.Enabled = false;
                        btn_grabarysalir.Enabled = false;
                        //this.Close();
                    }
                    else
                    {
                        if (_Accion != Cl_Enumeradores.eTipo_action.consultar)
                        {
                            btn_grabar.Enabled = true;
                            btn_grabarysalir.Enabled = true;
                        }
                    }
                }

                ctaCble_acreedoraCredito = par.IdCtaCble;
                _IdTipoCbte_NC = par.IdTipoCbteCble;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void ultraCmbE_empresaDest_SelectionChanged(object sender, EventArgs e)
        {
 

        }
        
        private void generaDiario()
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    decimal debe = 0;
                    decimal haber = 0;
                    string ctaCbleP = "", ctaCbleB = "", banco = "";

                    //********Nota/Debito**********

                    ctaCbleP = (ctaCble_acreedoraDebito == null ? null : ((ctaCble_acreedoraDebito.Length > 0) ? ctaCble_acreedoraDebito.Trim() : ""));
                    ba_Banco_Cuenta_Info ctaBancariaO = ucBa_CuentaBanco_Origen.get_BaCuentaInfo();
                    ctaCbleB = ctaBancariaO.IdCtaCble;

                    banco = ctaBancariaO.ba_descripcion;

                    ct_Cbtecble_det_Info debeND = new ct_Cbtecble_det_Info();
                    debeND.IdCtaCble = ctaCbleP;
                    debeND.dc_Valor = Convert.ToDouble(txt_monto.EditValue); debe = Convert.ToDecimal(txt_monto.EditValue);
                   
                   // debeND.dc_Observacion = "Transf. Interban. " + banco + " N/D " + txt_Memo.Text;
                    debeND.dc_Observacion =  txt_Memo.Text.Trim();

                    ct_Cbtecble_det_Info haberND = new ct_Cbtecble_det_Info();
                    haberND.IdCtaCble = ctaCbleB;
                    haberND.dc_Valor = Convert.ToDouble(txt_monto.EditValue) * -1; haber = Convert.ToDecimal(txt_monto.EditValue);
                   
                  //  haberND.dc_Observacion = "Transf. Interban. " + banco + " N/D " + txt_Memo.Text;
                    haberND.dc_Observacion = txt_Memo.Text.Trim();

                    List<ct_Cbtecble_det_Info> LstND = new List<ct_Cbtecble_det_Info>();
                    LstND.Add(debeND);
                    LstND.Add(haberND);
                    UC_DiarioND.setDetalle(LstND);


                    //********Nota/Credito**********
                    ctaCbleP = (ctaCble_acreedoraCredito == null ? null : ((ctaCble_acreedoraCredito.Length > 0) ? ctaCble_acreedoraCredito.Trim() : ""));
                    ba_Banco_Cuenta_Info ctaBancariaD = ucBa_CuentaBanco_Destino.get_BaCuentaInfo();
                    ctaCbleB = ctaBancariaD.IdCtaCble;
                    //ctaCbleB = (this.ultraCmbCtaBancoDest.EditValue == null) ? "" : (_b_NC.IdCtaCble == null ? null : _b_NC.IdCtaCble.Trim());
                    banco = (ucBa_CuentaBanco_Destino.get_BaCuentaInfo().ba_descripcion=="" ) ? "" : _b_NC.ba_descripcion;

                    ct_Cbtecble_det_Info debeNC = new ct_Cbtecble_det_Info();
                    debeNC.IdCtaCble = ctaCbleB;
                    debeNC.dc_Valor = Convert.ToDouble(txt_monto.EditValue); debe = Convert.ToDecimal(txt_monto.EditValue);

                   // debeNC.dc_Observacion = "Transf. Interban. " + banco + " N/C " + txt_Memo.Text;
                    debeNC.dc_Observacion = txt_Memo.Text.Trim();

                    ct_Cbtecble_det_Info haberNC = new ct_Cbtecble_det_Info();
                    haberNC.IdCtaCble = ctaCbleP;
                    haberNC.dc_Valor = Convert.ToDouble(txt_monto.EditValue) * -1; haber = Convert.ToDecimal(txt_monto.EditValue);


                   // haberNC.dc_Observacion = "Transf. Interban. " + banco + " N/C " + txt_Memo.Text;
                    haberNC.dc_Observacion = txt_Memo.Text.Trim();

                    List<ct_Cbtecble_det_Info> LstNC = new List<ct_Cbtecble_det_Info>();
                    LstNC.Add(debeNC); 
                    LstNC.Add(haberNC);
                    UC_DiarioNC.setDetalle(LstNC);
                }


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void ultraCmbCtaBancoOrigen_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
               
                generaDiario();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void ultraCmbCtaBancoDest_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
               
                generaDiario();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        
        private void txt_Memo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                generaDiario();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_monto_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                generaDiario();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ultraGrid_diarioND_Validating(object sender, CancelEventArgs e)
        {
        }

        public Boolean validaColumna()
        {
            try
            {
                Boolean estado = true;

                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value,ref MensajeError);

                if (Per_I.pe_estado == "I")
                {
                    MessageBox.Show("No se procedio a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (ucBa_CuentaBanco_Origen.get_BaCuentaInfo() == null)
                {
                    MessageBox.Show("Antes de continuar seleccione la Cta. Bancaria Origen", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (ucBa_CuentaBanco_Origen.get_BaCuentaInfo().IdBanco == 0)
                    {
                        MessageBox.Show("Antes de continuar seleccione la Cta. Bancaria Origen", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                
                }

                if (ucBa_CuentaBanco_Destino.get_BaCuentaInfo() == null)
                {
                    MessageBox.Show("Antes de continuar seleccione la Cta. Bancaria Destino", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (ucBa_CuentaBanco_Destino.get_BaCuentaInfo().IdBanco==0)
                    {
                        MessageBox.Show("Antes de continuar seleccione la Cta. Bancaria Destino", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                
                }
               



                if (this.txt_monto.EditValue == null)
                {
                    MessageBox.Show("Por favor Ingrese el Monto...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!UC_DiarioND.ValidarAsientosContables()) return false;
                if (!UC_DiarioNC.ValidarAsientosContables()) return false;

                if (UC_DiarioND.Get_Info_CbteCble()._cbteCble_det_lista_info.Count < 1)
                {
                    MessageBox.Show("Por favor ingrese el  Comprobante Contable(Nota de Débito) para poder continuar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (UC_DiarioNC.Get_Info_CbteCble()._cbteCble_det_lista_info.Count < 1)
                {
                    MessageBox.Show("Por favor ingrese el  Comprobante Contable(Nota de Crédito) para poder continuar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (Convert.ToInt32(ultraCmbE_empresaOrig.EditValue) == Convert.ToInt32(ultraCmbE_empresaDest.EditValue))
                {
                    if (ucBa_CuentaBanco_Origen.get_BaCuentaInfo().IdBanco == ucBa_CuentaBanco_Destino.get_BaCuentaInfo().IdBanco )
                    {
                        MessageBox.Show("No se puede grabar, Pretende realizar una transferencia a la misma empresa y cuenta , verifique...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.BAN, Convert.ToDateTime(dt_fechaCbte.Value)))
                    return false; 

                return estado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public List<ct_Cbtecble_det_Info> get_CbteCble_det(int IdEmpresa, int _IdTipoCbte, List<ct_Cbtecble_det_Info> detalle, decimal NCbt)
        {
            _ListaCbteCbleDet.Clear();
            try
            {
                foreach (var dte in detalle)
                {
                    dte.IdTipoCbte = _IdTipoCbte;
                    dte.IdEmpresa = IdEmpresa;
                    dte.IdCbteCble = NCbt;
                    _ListaCbteCbleDet.Add(dte);
                }
                return _ListaCbteCbleDet;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<ct_Cbtecble_det_Info>();
            }
        }

        public ba_transferencia_Info get_transferencia()
        {
            try
            {
                transf_I.IdEmpresa_destino = (int)this.ultraCmbE_empresaDest.EditValue;
                transf_I.IdEmpresa_origen = (int)this.ultraCmbE_empresaOrig.EditValue;
                transf_I.IdTipocbte_destino = _IdTipoCbte_NC;
                transf_I.IdTipocbte_origen = _IdTipoCbte_ND;
                transf_I.IdCbteCble_destino = IdCbtCble_NC;
                transf_I.IdCbteCble_origen = IdCbtCble_ND;
                transf_I.IdUsuario = param.IdUsuario;
                transf_I.IdUsuario_Anu = param.IdUsuario;
                transf_I.IdUsuarioUltMod = param.IdUsuario;
                transf_I.tr_fecha = this.dt_fechaCbte.Value;
                transf_I.Fecha_Transac = param.Fecha_Transac;
                transf_I.Fecha_UltMod = param.Fecha_Transac;
                transf_I.FechaAnulacion = param.Fecha_Transac;
                transf_I.tr_observacion = txt_Memo.Text;
                transf_I.tr_valor = Convert.ToDouble(txt_monto.EditValue);
                transf_I.tr_estado = (lblAnulado.Visible == false) ? "A" : "I";
                transf_I.IdBanco_origen = ucBa_CuentaBanco_Origen.get_BaCuentaInfo().IdBanco;
                transf_I.IdBanco_destino = ucBa_CuentaBanco_Destino.get_BaCuentaInfo().IdBanco;
                transf_I.nom_pc = param.nom_pc;
                transf_I.ip = param.ip;


                return transf_I;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_transferencia_Info();
            }
        }

        public ct_Cbtecble_Info get_Cbtecble(ct_Cbtecble_Info CbteCble_I, int IdEmpresa, int _IdTipoCbte,string Nom_Banco, decimal txt_NCbt)
        {
            try
            {
                CbteCble_I.IdEmpresa = IdEmpresa;
                CbteCble_I.IdTipoCbte = _IdTipoCbte;
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                CbteCble_I.cb_Fecha = dt_fechaCbte.Value;
                CbteCble_I.cb_Valor = Convert.ToDouble(this.txt_monto.EditValue);
                CbteCble_I.cb_Observacion = "Transf. Interban. " + Nom_Banco + " " + txt_Memo.Text.Trim();
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = dt_fechaCbte.Value.Year;
                CbteCble_I.Mes = dt_fechaCbte.Value.Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                CbteCble_I.Mayorizado = "N";
                CbteCble_I.IdCbteCble = txt_NCbt;
                CbteCble_I._cbteCble_det_lista_info = _ListaCbteCbleDet;
                

                return CbteCble_I;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Cbtecble_Info();
            }
        }

        Boolean  Grabar()
        {
            try 
            {
                Boolean res=false;


                txt_Memo.Focus();
                if (validaColumna())
                {
                    get_CbteCble_det((int)ultraCmbE_empresaOrig.EditValue, _IdTipoCbte_ND,
                        UC_DiarioND.Get_Info_CbteCble()._cbteCble_det_lista_info, IdCbtCble_ND);

                    get_Cbtecble(CbteCble_I_ND, (int)ultraCmbE_empresaOrig.EditValue, _IdTipoCbte_ND, ucBa_CuentaBanco_Origen.get_BaCuentaInfo().ba_descripcion, IdCbtCble_ND);
                    string msg = "";

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (CbteCble_B.GrabarDB(CbteCble_I_ND, ref idCbteCble, ref msg))
                        {
                            IdCbtCble_ND = idCbteCble;
                            tabPage_ND.Text = tabPage_ND.Text + " # CbtCble: " + idCbteCble.ToString();
                            cod_CbteCble_ND = "NDB";
                            get_CbteBan(_IdTipoCbte_ND, idCbteCble, ucBa_CuentaBanco_Origen.get_BaCuentaInfo().IdBanco, cod_CbteCble_ND, (int)ultraCmbE_empresaOrig.EditValue,Convert.ToDecimal(ucBa_TipoFlujo_origen.get_TipoFlujoInfo().IdTipoFlujo),Convert.ToInt32(ucbA_Tipo_NDBA.get_TipoNotaInfo().IdTipoNota));

                            if (CbteBan_B.GrabarDB(Info_CbteBan_I, ref MensajeError) == false)
                                MessageBox.Show("No se pudo Grabar el Comprobante de Débito" + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            idCbteCble = 0;
                            cod_CbteCble = "";

                            get_CbteCble_det((int)ultraCmbE_empresaDest.EditValue, _IdTipoCbte_NC,
                                UC_DiarioNC.Get_Info_CbteCble()._cbteCble_det_lista_info, IdCbtCble_NC);
                            get_Cbtecble(CbteCble_I_NC, (int)ultraCmbE_empresaDest.EditValue, _IdTipoCbte_NC, ucBa_CuentaBanco_Destino.get_BaCuentaInfo().ba_descripcion, IdCbtCble_NC);


                            if (CbteCble_B.GrabarDB(CbteCble_I_NC, ref idCbteCble, ref msg))
                            {
                                IdCbtCble_NC = idCbteCble;
                                tabPage_NC.Text = tabPage_NC.Text + " # CbtCble: " + idCbteCble.ToString();
                                cod_CbteCble_NC = "NCB";

                                get_CbteBan(_IdTipoCbte_NC, idCbteCble, ucBa_CuentaBanco_Destino.get_BaCuentaInfo().IdBanco, cod_CbteCble_NC, (int)ultraCmbE_empresaDest.EditValue,Convert.ToDecimal(ucBa_TipoFlujo_destino.get_TipoFlujoInfo().IdTipoFlujo),Convert.ToInt32(ucbA_Tipo_NCBA.get_TipoNotaInfo().IdTipoNota));
                                if (CbteBan_B.GrabarDB(Info_CbteBan_I, ref MensajeError) == false)
                                    MessageBox.Show("No se pudo Grabar el Comprobante de Crédito " + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                                get_transferencia();
                                if (transf_B.GrabarDB(transf_I, ref NTransf))
                                {
                                    txt_NTransferencia.Text = (NTransf != null) ? Convert.ToString(NTransf) : "";
                                    transf_I.IdTransferencia = NTransf;
                                    if (MessageBox.Show("Se Guardó la Transferencia #: " + txt_NTransferencia.Text + " correctamente con el Comprobante de ND #: " + IdCbtCble_ND + " y el Comprobante de NC #: " + IdCbtCble_NC + "\n ¿ Desea Imprimir la Transferencia #: " + txt_NTransferencia.Text + " ?", " Imprimir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        Imprimir();
                                    }
                                    btn_grabar.Enabled = false;
                                    btn_grabarysalir.Enabled = false;
                                    _Accion = Cl_Enumeradores.eTipo_action.consultar; set_transferencia(transf_I);
                                    res = true;
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo Grabar el Comprobante de Transferencia: " + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    res = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo Grabar el Comprobante de Transferencia, Contabilidad NC: " + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                res = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Grabar el Comprobante de Transferencia, Contabilidad ND: " + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            res = false;
                        }
                    }
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        get_transferencia();
                        if (transf_B.ModificarDB(transf_I, ref msg))
                        {
                            ba_Cbte_Ban_Info InfCbteBan_ND = new ba_Cbte_Ban_Info();
                            ba_Cbte_Ban_Info InfCbteBan_NC = new ba_Cbte_Ban_Info();

                            InfCbteBan_ND = CbteBan_B.Get_Info_Cbte_Ban(transf_I.IdEmpresa_origen, transf_I.IdTipocbte_origen, transf_I.IdCbteCble_origen, ref msg);
                            InfCbteBan_ND.cb_Observacion = transf_I.tr_observacion;
                            CbteBan_B.ActualizarObservacion(InfCbteBan_ND, ref MensajeError);

                            InfCbteBan_NC = CbteBan_B.Get_Info_Cbte_Ban(transf_I.IdEmpresa_destino, transf_I.IdTipocbte_destino, transf_I.IdCbteCble_destino, ref msg);
                            InfCbteBan_NC.cb_Observacion = transf_I.tr_observacion;
                            CbteBan_B.ActualizarObservacion(InfCbteBan_NC, ref MensajeError);


                            if (MessageBox.Show("Se Actualizó la Transferencia #: " + txt_NTransferencia.Text + " correctamente \n ¿ Desea Imprimir la Transferencia #: " + txt_NTransferencia.Text + " ?", " Imprimir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Imprimir();
                            }
                            btn_grabar.Enabled = false;
                            btn_grabarysalir.Enabled = false;
                            _Accion = Cl_Enumeradores.eTipo_action.consultar; set_transferencia(transf_I); 
                            res = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Grabar el Comprobante de Transferencia: " + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            res = false;
                        }

                    }

                }
                else
                    res = false;
                    //MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);


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

        public void Imprimir()
        {
            try
            {
                ba_rpt_transferencia_Info transf_rpt_I = new ba_rpt_transferencia_Info();
                transf_rpt_I = transf_B.Get_Info_rpt_transferencia(transf_I.IdEmpresa_origen, (int)transf_I.IdTransferencia);

                UC_DiarioNC.setAccion(_Accion);
                UC_DiarioND.setAccion(_Accion);
                UC_DiarioND.setInfo(transf_I.IdEmpresa_origen, _IdTipoCbte_ND, transf_I.IdCbteCble_origen);
                UC_DiarioNC.setInfo(transf_I.IdEmpresa_destino, _IdTipoCbte_NC, transf_I.IdCbteCble_destino);
                
                UC_DiarioND.btnImprimir_Click(null, null);
                UC_DiarioNC.btnImprimir_Click(null, null);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ba_Cbte_Ban_Info get_CbteBan(int _IdTipoCbte, decimal comprobante, int banco, string Cod_Cbt, int IdEmpresa, decimal IdTipoFlujo, int IdTipoNota)
        {
            try
            {
                Info_CbteBan_I.IdEmpresa = IdEmpresa;
                Info_CbteBan_I.IdTipocbte = _IdTipoCbte;
                Info_CbteBan_I.IdCbteCble = comprobante;
                Info_CbteBan_I.Cod_Cbtecble = Cod_Cbt; ;
                Info_CbteBan_I.IdPeriodo = Per_I.IdPeriodo;

                Info_CbteBan_I.IdTipoFlujo = IdTipoFlujo;
                Info_CbteBan_I.IdTipoNota = IdTipoNota;

                Info_CbteBan_I.IdBanco = banco;
                Info_CbteBan_I.cb_Fecha = dt_fechaCbte.Value;
                Info_CbteBan_I.cb_Observacion = "Transf. Interbancaria " + txt_Memo.Text.Trim();
                Info_CbteBan_I.cb_secuencia = (Info_CbteBan_I.cb_secuencia == 0 || Info_CbteBan_I.cb_secuencia == null) ? 0 : Info_CbteBan_I.cb_secuencia;
                Info_CbteBan_I.cb_Valor = Convert.ToDouble(this.txt_monto.EditValue);
                Info_CbteBan_I.Estado = "A";
                Info_CbteBan_I.IdUsuario = param.IdUsuario;
                Info_CbteBan_I.IdUsuario_Anu = param.IdUsuario;
                Info_CbteBan_I.FechaAnulacion = param.Fecha_Transac;
                Info_CbteBan_I.Fecha_Transac = param.Fecha_Transac;
                Info_CbteBan_I.Fecha_UltMod = param.Fecha_Transac;
                Info_CbteBan_I.IdUsuarioUltMod = param.IdUsuario;
                Info_CbteBan_I.ip = param.ip;
                Info_CbteBan_I.nom_pc = param.nom_pc;

                return Info_CbteBan_I;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Cbte_Ban_Info();
            }
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                 Grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void FrmBA_Transferencia_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }

                lisEmp = Empresa_B.Get_List_Empresa();

                this.ultraCmbE_empresaOrig.Properties.DataSource = lisEmp;
                this.ultraCmbE_empresaDest.Properties.DataSource = lisEmp;

                ultraCmbE_empresaOrig.Properties.DisplayMember = "em_nombre";
                ultraCmbE_empresaOrig.EditValue = param.IdEmpresa;
                ultraCmbE_empresaOrig.Properties.ValueMember = "IdEmpresa";
                ultraCmbE_empresaDest.Properties.DisplayMember = "em_nombre";
                ultraCmbE_empresaDest.Properties.ValueMember = "IdEmpresa";
                ultraCmbE_empresaDest.EditValue = param.IdEmpresa;

                listParaBan = paramBa_B.Get_List_Banco_Parametros(param.IdEmpresa);

                paramBa_I_ND = listParaBan.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "NDBA"; });
                paramBa_I_NC = listParaBan.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "NCBA"; });

                ucbA_Tipo_NCBA.set_primer_TipoNota();
                ucbA_Tipo_NDBA.set_primer_TipoNota();

                if (paramBa_I_ND == null || paramBa_I_NC==null)
                {
                    MessageBox.Show("No puede continuar porque no han ingresado los parámetros de banco ND o NC.. \n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_grabar.Enabled = false;
                    btn_grabarysalir.Enabled = false;
                    this.Close();
                }
                else
                {
                    if (paramBa_I_ND.IdTipoCbteCble == null || paramBa_I_ND.IdTipoCbteCble < 1)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco (Falta ingresar el tipo de Cbte. para las notas de Debito)..\n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btn_grabar.Enabled = false;
                        btn_grabarysalir.Enabled = false;
                        this.Close();
                    }
                    if (paramBa_I_ND.IdCtaCble == null || paramBa_I_ND.IdCtaCble == "")
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco (Falta ingresar la Cuenta Cble. para las notas de Debito)..\n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btn_grabar.Enabled = false;
                        btn_grabarysalir.Enabled = false;
                        this.Close();
                    }
                }

                _IdTipoCbte_ND = paramBa_I_ND.IdTipoCbteCble;
                _IdTipoCbte_NC = paramBa_I_NC.IdTipoCbteCble;

                ctaCble_acreedoraDebito = paramBa_I_ND.IdCtaCble;
                ultraCmbE_empresaDest.Properties.DataSource = lisEmp; // lis;

                
                IdEmpresaDestino = 0;
                
                set_Accion_Controls();
              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }



        }

        void UC_BtnValidadModifCbt_event_btn_PermisoModiCbt_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean b = UC_BtnValidadModifCbt.ValidaPermiso();
                UC_DiarioND.HabilitarGrid(b);
                UC_DiarioNC.HabilitarGrid(b);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void FrmBA_Transferencia_event_FrmBA_Transferencia_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }




        private void set_Accion_Controls()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        UC_DiarioND.HabilitarGrid(false);
                        UC_DiarioNC.HabilitarGrid(false);
                        ultraCmbE_empresaOrig.Enabled = false;
                        ultraCmbE_empresaDest.Enabled = false;

                        ucBa_CuentaBanco_Destino.Enabled = false;
                        ucBa_CuentaBanco_Origen.Enabled = false;

                        btn_grabar.Enabled = true;
                        btn_grabarysalir.Enabled = true;
                        btnAnular.Visible = false;
                        set_transferencia_controls();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        btn_grabar.Enabled = false;
                        btn_grabarysalir.Enabled = false;
                        btnAnular.Visible = true;
                        set_transferencia_controls();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        btn_grabar.Enabled = false;
                        btn_grabarysalir.Enabled = false;
                        UC_DiarioND.HabilitarGrid(false);
                        UC_DiarioNC.HabilitarGrid(false);
                        ultraCmbE_empresaOrig.Enabled = false;
                        ultraCmbE_empresaDest.Enabled = false;
                        ucBa_CuentaBanco_Destino.Enabled = false;
                        ucBa_CuentaBanco_Origen.Enabled = false;
                        btnAnular.Visible = false;
                        txt_Memo.Enabled = false;
                        txt_monto.Enabled = false;
                        set_transferencia_controls();
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

        public void set_transferencia(ba_transferencia_Info info)
        {
            try
            {
                transf_I = info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_transferencia_controls()
        {
            try
            {

                UC_DiarioNC.setAccion(_Accion);
                UC_DiarioND.setAccion(_Accion);

                txt_NTransferencia.Text = transf_I.IdTransferencia.ToString();
                this.ultraCmbE_empresaDest.EditValue = transf_I.IdEmpresa_destino;
                this.ultraCmbE_empresaOrig.EditValue = transf_I.IdEmpresa_origen;


                tabPage_NC.Text = tabPage_NC.Text + " # CbtCble: " + transf_I.IdCbteCble_destino.ToString();
                tabPage_ND.Text = tabPage_ND.Text + " # CbtCble: " + transf_I.IdCbteCble_origen.ToString();
                this.dt_fechaCbte.Value = transf_I.tr_fecha;
                txt_Memo.Text = transf_I.tr_observacion;
                txt_monto.EditValue = (decimal)transf_I.tr_valor;
                lblCbt_TipoAnulacion.Visible = false;
                if (transf_I.tr_estado == "I")
                {
                    lblAnulado.Visible = true;
                    ct_cbtecble_Reversado_Info cbtervsoNC = new ct_cbtecble_Reversado_Info();
                    ct_cbtecble_Reversado_Info cbtervsoND = new ct_cbtecble_Reversado_Info();
                    ct_cbtecble_Reversado_Bus busRev = new ct_cbtecble_Reversado_Bus();
                    cbtervsoNC = busRev.Get_Info_cbtecble_Reversado(param.IdEmpresa, transf_I.IdTipocbte_destino, transf_I.IdCbteCble_destino);
                    cbtervsoND = busRev.Get_Info_cbtecble_Reversado(param.IdEmpresa, transf_I.IdTipocbte_origen, transf_I.IdCbteCble_origen);

                    string anulado = "Rvso NCBA Tipo#" + cbtervsoNC.IdTipoCbte_Anu + " Cbte#" + cbtervsoNC.IdCbteCble_Anu
                        + "\r Rvso NDBA Tipo#" + cbtervsoND.IdTipoCbte_Anu + " Cbte#" + cbtervsoND.IdCbteCble_Anu;

                    lblCbt_TipoAnulacion.Text = anulado;
                    lblCbt_TipoAnulacion.Visible = true;

                }

                ucBa_CuentaBanco_Origen.set_BaCuentaInfo(transf_I.IdBanco_origen);
                ucBa_CuentaBanco_Destino.set_BaCuentaInfo(transf_I.IdBanco_destino);

                
                IdCbtCble_NC = transf_I.IdCbteCble_destino;
                IdCbtCble_ND = transf_I.IdCbteCble_origen;

                UC_DiarioNC.setAccion(_Accion);
                UC_DiarioND.setAccion(_Accion);
                UC_DiarioND.setInfo(transf_I.IdEmpresa_origen, _IdTipoCbte_ND, transf_I.IdCbteCble_origen);
                UC_DiarioNC.setInfo(transf_I.IdEmpresa_destino, _IdTipoCbte_NC, transf_I.IdCbteCble_destino);

                _ListaCbteCbleDetAnt_ND = UC_DiarioND.Get_Info_CbteCble()._cbteCble_det_lista_info;
                _ListaCbteCbleDetAnt_NC = UC_DiarioNC.Get_Info_CbteCble()._cbteCble_det_lista_info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_CbteCbleInfo(int IdEmpresa, int _IdTipoCbte, decimal IdCbte, DataTable dt, List<ct_Cbtecble_det_Info> _ListaCbteCbleDetAnt)
        {
            try
            {
                dt.Clear();
                if (transf_I.IdTransferencia != 0)
                {
                    ct_Cbtecble_det_Bus _CbteCbleBus = new ct_Cbtecble_det_Bus();
                    List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                    string MensajeError = "";

                    lm = _CbteCbleBus.Get_list_Cbtecble_det(IdEmpresa, _IdTipoCbte, IdCbte, ref MensajeError);

                    _ListaCbteCbleDetAnt = lm;

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_grabarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
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

        private void FrmBA_Transferencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_FrmBA_Transferencia_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ultraCmbE_empresaDest_ValueChanged(object sender, EventArgs e)
        { 
        
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
              anular();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void anular()
        {
            try
            {
                if (transf_I != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (transf_I.tr_estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el reg #: " + transf_I.IdTransferencia +
                            " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();
                            transf_I.tr_MotivoAnulacion = oFrm.motivoAnulacion;
                            transf_I.IdUsuario_Anu = param.IdUsuario;
                            transf_I.tr_observacion = "***ANULADO***" + transf_I.tr_observacion;
                            transf_I.FechaAnulacion = param.Fecha_Transac;

                            if (transf_B.AnularDB(transf_I, ref msg))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El registro", transf_I.IdTransferencia);
                                MessageBox.Show(smensaje, param.Nombre_sistema);                        
                                MessageBox.Show("Anulado con éxito el reg #: " + transf_I.IdTransferencia);

                                lblAnulado.Visible = true;
                                this.btnAnular.Enabled = false;
                                set_transferencia(transf_I);
                            }
                            else MessageBox.Show("No se pudo anular el reg #: " + transf_I.IdTransferencia + " debido a: "
                                + msg, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        
        

        

        private void txt_monto_EditValueChanged(object sender, EventArgs e)
        {
             try
            {
                generaDiario();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucBa_CuentaBanco_Origen_event_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                generaDiario();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void ucBa_CuentaBanco_Destino_event_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                    IdEmpresaDestino = Convert.ToInt32(ultraCmbE_empresaDest.EditValue);
                    validaParametrosOtraEmpresa(IdEmpresaDestino);
                    UC_DiarioNC.carga_Combo_x_Empresa((int)ultraCmbE_empresaDest.EditValue);

                    UC_DiarioNC.LimpiarGrid(); 
                    UC_DiarioND.LimpiarGrid();
               
                    generaDiario();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ultraCmbE_empresaOrig_EditValueChanged(object sender, EventArgs e)
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

        private void ultraCmbE_empresaDest_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                IdEmpresaDestino = Convert.ToInt32(ultraCmbE_empresaDest.EditValue);
                ucBa_CuentaBanco_Destino.cargar_CuentaBanco(IdEmpresaDestino);
                ucBa_CuentaBanco_Destino.set_BaCuentaInfo(1);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
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


