using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Caja;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Winform.General;
using Core.Erp.Reportes.Bancos;
//version 23122013 
///
//katiuska franco
///

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_ConciliacionBancaria_Mant : Form
    {
        
        #region Declaración de Variables
        string EstadoConciliacion = "";
        decimal IdConciliacion = 0;
        decimal saldo = 0;
        string motiAnulacion = "";
        int xx = 1;
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        Boolean CANCEL;
        string MensajeError = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        ct_Periodo_Info Info_Periodo = new ct_Periodo_Info();
        ct_Periodo_Bus PeB = new ct_Periodo_Bus();
        ct_Periodo_Bus BusPeriodo = new ct_Periodo_Bus();

        ct_Cbtecble_det_Bus CbtDet_B = new ct_Cbtecble_det_Bus();
        ba_Conciliacion_Info Info_Conciliacion_Generarl = new ba_Conciliacion_Info();
        ct_Plancta_Bus _PlanCtaBus = new ct_Plancta_Bus();
        List<ct_Plancta_Info> LstCta = new List<ct_Plancta_Info>();

        caj_Caja_Bus caj_B = new caj_Caja_Bus();

        ba_Banco_Cuenta_Info Info_Banco = new ba_Banco_Cuenta_Info();
        ba_Banco_Cuenta_Bus bancoB = new ba_Banco_Cuenta_Bus();
        List<ba_Banco_Cuenta_Info> Banco_Cuenta_List = new List<ba_Banco_Cuenta_Info>();

        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus _BusCbtBanXCtbtCble = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();

        ba_Cbte_Ban_tipo_x_CodBancoExterno_Bus bus_CodBcoExt = new ba_Cbte_Ban_tipo_x_CodBancoExterno_Bus();
        List<ba_Cbte_Ban_tipo_x_CodBancoExterno_Info> lst_ba_Info = new List<ba_Cbte_Ban_tipo_x_CodBancoExterno_Info>();
        List<ba_Banco_Cuenta_Info> ListadoBancos = new List<ba_Banco_Cuenta_Info>();
        List<ct_Periodo_Info> ListaPeriodo = new List<ct_Periodo_Info>();
        ba_Conciliacion_Bus Concil_B = new ba_Conciliacion_Bus();
        ba_Conciliacion_Info Concil_I = new ba_Conciliacion_Info();

        ba_cbte_ban_verificado_Bus BUSVERIFICACION = new ba_cbte_ban_verificado_Bus();

        List<vwba_TransaccionesAConciliar_Info> ListTransaccionesAConciliar = new List<vwba_TransaccionesAConciliar_Info>();
        List<vwba_TransaccionesAConciliar_Info> ListTransaccionesAConciliar_TMP = new List<vwba_TransaccionesAConciliar_Info>();

        BindingList<vwba_TransaccionesAConciliar_Info> list_Ingreso = new BindingList<vwba_TransaccionesAConciliar_Info>();
        BindingList<vwba_TransaccionesAConciliar_Info> list_Egreso = new BindingList<vwba_TransaccionesAConciliar_Info>();
        List<vwba_TransaccionesAConciliar_Info> ListaSumatoriaIngresos = new List<vwba_TransaccionesAConciliar_Info>();
        List<vwba_TransaccionesAConciliar_Info> ListaSumatoriaEgresos = new List<vwba_TransaccionesAConciliar_Info>();
        BindingList<vwba_TransaccionesAConciliar_Info> BindLstSistema = new BindingList<vwba_TransaccionesAConciliar_Info>();
        BindingList<vwba_TransaccionesAConciliar_Info> ListExcel = new BindingList<vwba_TransaccionesAConciliar_Info>();

        ba_Conciliacion_det_IngEgr_Bus ConciIngEgr_B = new ba_Conciliacion_det_IngEgr_Bus();
        List<vwba_TransaccionesAConciliar_Info> ListaIngEgr = new List<vwba_TransaccionesAConciliar_Info>();

        ba_Conciliacion_det_no_conciliado_Bus NoConci_B = new ba_Conciliacion_det_no_conciliado_Bus();
        List<ba_Conciliacion_det_no_conciliado_Info> ListaNoConciliados = new List<ba_Conciliacion_det_no_conciliado_Info>();

        DataTable ds = new DataTable();

        public delegate void delegate_FrmBa_ConciliacionBancaria_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBa_ConciliacionBancaria_FormClosing event_FrmBa_ConciliacionBancaria_FormClosing;
        #endregion

        public FrmBA_ConciliacionBancaria_Mant()
        {
            try
            {
                InitializeComponent();
                
                event_FrmBa_ConciliacionBancaria_FormClosing += new delegate_FrmBa_ConciliacionBancaria_FormClosing(FrmBa_ConciliacionBancaria_event_FrmBa_ConciliacionBancaria_FormClosing);

                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                btn_cargarMovimientos.Enabled = true;
                ultraCmbE_periodo.Enabled = true;
                txt_NConciliacion.Text = "";
                ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu.Visible_btnGuardar = true;                
                Info_Banco = null;
                ultraCmbE_periodo.EditValue = null;
                ultraCmbCtaBanco.EditValue = null;
                Info_Periodo = null;
                Concil_I = null;
                dtp_desde.Value = DateTime.Now;
                dtp_hasta.Value = DateTime.Now;
                ListaSumatoriaIngresos.Clear();
                ListaSumatoriaEgresos.Clear();
                gridControl_Egresos.DataSource = "";
                gridControl_Ingresos.DataSource = "";
                BindLstSistema.Clear();
                gridControlExcel.DataSource = BindLstSistema;
                txe_SaldoCtbleAnterior.EditValue = 0;
                txe_ingresos.EditValue = 0;
                txe_egreso.EditValue = 0;
                txe_saldoConciliado.EditValue = 0;
              //  txe_saldoBanco.EditValue = 0;
                txe_diferencia.EditValue = 0;
                txt_Saldo_anterior_banco.EditValue = 0.00;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ImprimiConciliacion(int idBanco,int Idconciliacion)
        {
            try
            {
                XBAN_Rpt011_rpt reporte = new XBAN_Rpt011_rpt();
               
                IdConciliacion = Convert.ToInt32(txt_NConciliacion.Text);
                reporte.set_parametros(param.IdEmpresa, idBanco, Idconciliacion);
                reporte.RequestParameters = true;
                reporte.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if(GrabarAccion())
                    this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GrabarAccion();

                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.Anular;
                Grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void FrmBa_ConciliacionBancaria_event_FrmBa_ConciliacionBancaria_FormClosing(object sender, FormClosingEventArgs e)
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

        public ba_Conciliacion_Info get_Conciliacion()
        {
            try
            {
                Concil_I.IdEmpresa=param.IdEmpresa;
                Concil_I.IdConciliacion=Convert.ToInt32(txt_NConciliacion.Text);
                if (Info_Banco == null)
                {
                    Info_Banco = ListadoBancos.Where(v => v.IdBanco == Info_Conciliacion_Generarl.IdBanco).FirstOrDefault();
                }
                if (Info_Periodo == null)
                {
                    Info_Periodo = ListaPeriodo.Where(v => v.IdPeriodo == Convert.ToInt32(Info_Conciliacion_Generarl.IdPeriodo)).FirstOrDefault();
                }

                Concil_I.IdBanco=Info_Banco.IdBanco;
                Concil_I.IdPeriodo=Info_Periodo.IdPeriodo;
                Concil_I.co_Fecha=param.Fecha_Transac ;
                Concil_I.co_SaldoContable_MesAnt=Math.Round( Convert.ToDouble(txe_SaldoCtbleAnterior.EditValue),2);
                Concil_I.co_totalIng=Convert.ToDouble(txe_ingresos.EditValue);
                Concil_I.co_totalEgr=Convert.ToDouble(txe_egreso.EditValue);
                Concil_I.co_SaldoContable_MesAct=Convert.ToDouble(txe_saldoConciliado.EditValue);
                Concil_I.co_SaldoBanco_EstCta =Convert.ToDouble(txe_saldoBanco.EditValue);
                Concil_I.co_Observacion = txt_observacion.Text;
                Concil_I.co_SaldoBanco_anterior = txt_Saldo_anterior_banco.EditValue == null ? 0 : Convert.ToDouble(txt_Saldo_anterior_banco.EditValue);
                if (Convert.ToDouble(txe_SaldoCtbleAnterior.Text) > 0)
                {
                    Concil_I.co_SaldoContable_MesAnt = Convert.ToDouble(txe_SaldoCtbleAnterior.Text);
                }
                if (txe_saldoBanco.Text != "")
                {
                    if (Convert.ToDouble(txe_saldoBanco.Text) > 0)
                    {
                        Concil_I.co_SaldoBanco_EstCta = Convert.ToDouble(txe_saldoBanco.Text);
                    }
                }
                var GroupXTipoySunIng = from ing in list_Ingreso
                              group ing by new { ing.CodTipoCbteBan }
                                  into grouping
                                  select new { grouping.Key, CantxTipo = grouping.Count(), TotalxTipo = grouping.Sum(p => p.dc_Valor) };


                var GroupXTipoySunEgr = from ing in list_Egreso 
                              group ing by new { ing.CodTipoCbteBan }
                                  into grouping
                                  select new { grouping.Key, CantxTipo = grouping.Count(), TotalxTipo = grouping.Sum(p => p.dc_Valor) };

                foreach (var item in GroupXTipoySunIng)
                {
                    if(item.Key.CodTipoCbteBan=="DESP")
                    {
                         Concil_I.co_Cant_Deposito = item.CantxTipo ; Concil_I.co_TotalDepositos=item.TotalxTipo ;
                    }
                    else if(item.Key.CodTipoCbteBan=="NCBA")
                    {
                         Concil_I.co_Cant_NC = item.CantxTipo ; Concil_I.co_totalNC=item.TotalxTipo ;
                    }
                    else 
                    {
                        Concil_I.co_Cant_OtrosIng = item.CantxTipo ; Concil_I.co_TotalOtrosIng =item.TotalxTipo ;
                    }
                }

                foreach (var item in GroupXTipoySunEgr)
                {
                    if(item.Key.CodTipoCbteBan=="CHEQ")
                    {
                         Concil_I.co_Cant_Cheque = item.CantxTipo ; Concil_I.co_TotalCheque=item.TotalxTipo ;
                    }
                    else if (item.Key.CodTipoCbteBan == "NDBA")
                    {
                         Concil_I.co_Cant_ND = item.CantxTipo; Concil_I.co_TotalND = item.TotalxTipo;
                    }
                    else
                    {
                        Concil_I.co_Cant_OtrosEgr = item.CantxTipo; Concil_I.co_TotalOtrosEgr = item.TotalxTipo;
                    }
                }


                Concil_I.Estado = (lb_Anulado.Visible == false) ? "A" : "I";
                Concil_I.IdUsuario = param.IdUsuario;
                Concil_I.IdUsuario_Anu = param.IdUsuario;
                Concil_I.FechaAnulacion = param.Fecha_Transac;
                Concil_I.Fecha_Transac = param.Fecha_Transac;
                Concil_I.Fecha_UltMod = param.Fecha_Transac;
                Concil_I.IdUsuarioUltMod = param.IdUsuario;
                Concil_I.ip = param.ip;
                Concil_I.nom_pc = param.nom_pc;
                foreach (var item in list_Egreso)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdUsuario = param.IdUsuario;
                    item.Fecha_Transac = DateTime.Now;
                    item.Estado = "A";
                    ListaIngEgr.Add(item);
                }
                foreach (var item in list_Ingreso)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdUsuario = param.IdUsuario;
                    item.Fecha_Transac = DateTime.Now;
                    item.Estado = "A";
                    ListaIngEgr.Add(item);
                }
              
                Concil_I.LstConciliadas = ListaIngEgr;

                return Concil_I;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Conciliacion_Info();
            }
        }

        public void set_Conciliacion(ba_Conciliacion_Info info)
        {
            try
            {

                Info_Conciliacion_Generarl = info;

                

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Conciliacion_Controles()
        {
            try
            {
                if (Info_Conciliacion_Generarl.IdConciliacion == 0)
                    return;

                double ingreso_con = 0;
                double Egreso_con = 0;
                ultraCmbCtaBanco.EditValue = Info_Conciliacion_Generarl.IdBanco;
                lb_EstadoConciliacion.Text = Info_Conciliacion_Generarl.Estado_Conciliacion;
                
                if (Info_Conciliacion_Generarl.Estado_Conciliacion == "CONCILIADO")
                {
                    lb_EstadoConciliacion.Text = lb_EstadoConciliacion.Text + " y CERRADO NO SE PUEDE MODIFICAR";
                    ucGe_Menu.Enabled_btnGuardar = false;
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                }


                btnCargaExcel.Enabled = false;
                button1.Enabled = false;
                txt_NConciliacion.Text = Info_Conciliacion_Generarl.IdConciliacion.ToString();

                this.ultraCmbE_periodo.EditValue = Info_Conciliacion_Generarl.IdPeriodo;
                
                if (Info_Periodo == null)
                {
                    Info_Periodo = ListaPeriodo.Where(v => v.IdPeriodo == Convert.ToInt32(Info_Conciliacion_Generarl.IdPeriodo)).FirstOrDefault();
                }
                

                txe_ingresos.EditValue = (double)Info_Conciliacion_Generarl.co_totalIng;
                txe_egreso.EditValue = (double)Info_Conciliacion_Generarl.co_totalEgr;

                
                txe_SaldoCtbleAnterior.EditValue = Math.Round((double)Info_Conciliacion_Generarl.co_SaldoContable_MesAnt,2);
                
                txe_saldoConciliado.EditValue = (double)Info_Conciliacion_Generarl.co_SaldoContable_MesAct;

                txe_saldoBanco.EditValue = (double)Info_Conciliacion_Generarl.co_SaldoBanco_EstCta;
                lb_Anulado.Visible = (Info_Conciliacion_Generarl.Estado == "I") ? true : false;
                txt_observacion.Text = Info_Conciliacion_Generarl.co_Observacion;
                

                List<vwba_TransaccionesAConciliar_Info> ListConciliados = new List<vwba_TransaccionesAConciliar_Info>();
                List<vwba_TransaccionesAConciliar_Info> ListNOConciliados = new List<vwba_TransaccionesAConciliar_Info>();

                if (Info_Banco == null)
                {
                    Info_Banco = ListadoBancos.Where(v => v.IdBanco == Info_Conciliacion_Generarl.IdBanco).FirstOrDefault();
                }

                

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    ListTransaccionesAConciliar = Concil_B.Get_List_Transacciones_x_Conciliar(param.IdEmpresa, Info_Banco.IdCtaCble.ToString(), Info_Periodo.pe_FechaIni, Info_Periodo.pe_FechaFin);

                }
                else
                {
                    ListTransaccionesAConciliar = Concil_B.Get_List_Transacciones_x_Conciliar(param.IdEmpresa, Info_Banco.IdCtaCble.ToString(), Info_Periodo.pe_FechaIni, Info_Periodo.pe_FechaFin, Convert.ToInt32(txt_NConciliacion.Text),Info_Conciliacion_Generarl.IdBanco);

                }
                if (ListTransaccionesAConciliar.Count == 0)
                {
                    MessageBox.Show("No existe información bancaria a conciliar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //INGRESOS
               list_Ingreso = new BindingList<vwba_TransaccionesAConciliar_Info>(ListTransaccionesAConciliar.Where(c => c.Tipo == "+").ToList());
                 ListaSumatoriaIngresos = new List<vwba_TransaccionesAConciliar_Info>(list_Ingreso.Where(q=>q.chk==true).ToList());

                //EGRESOS
                list_Egreso = new BindingList<vwba_TransaccionesAConciliar_Info>(ListTransaccionesAConciliar.Where(c => c.Tipo == "-").ToList());
                ListaSumatoriaEgresos =  new List<vwba_TransaccionesAConciliar_Info>(list_Egreso.Where(q=>q.chk==true).ToList());


                foreach (var item in ListTransaccionesAConciliar)
                {
                    if (item.chk == true)
                    {
                        if (item.Tipo == "+")
                        {
                            ingreso_con = ingreso_con + item.dc_Valor;
                        }
                        else
                        {
                            Egreso_con = ingreso_con + item.dc_Valor;

                        }

                    }

                }

                gridControl_Egresos.DataSource = list_Egreso;
                gridControl_Ingresos.DataSource = list_Ingreso;



                List<vwba_TransaccionesAConciliar_Info> temp = new List<vwba_TransaccionesAConciliar_Info>();

                BindLstSistema = new BindingList<vwba_TransaccionesAConciliar_Info>(temp);
                gridControlSistema.DataSource = BindLstSistema;

                txt_CtaCble.Text = Info_Banco.IdCtaCble.ToString();
                dtp_desde.Value = Info_Periodo.pe_FechaIni;
                dtp_hasta.Value = Info_Periodo.pe_FechaFin;


                txt_Saldo_anterior_banco.EditValue = Info_Conciliacion_Generarl.co_SaldoBanco_anterior;
                Calculo_Saldos();
                

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmBa_ConciliacionBancaria_Load(object sender, EventArgs e)
        {
            try
            {
                dtp_hasta.Enabled = false;
                dtp_desde.Enabled = false;
                Cargar_Datos();
                set_Conciliacion_Controles();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void ultraCmbCtaBanco_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var cta_I=LstCta.First(c => c.IdCtaCble == Info_Banco.IdCtaCble);
                txt_nombreCta.Text = (cta_I.pc_Cuenta == null) ? "" : cta_I.pc_Cuenta.Trim();

                gridControl_Ingresos.DataSource = ""; gridControl_Egresos.DataSource = "";
                txe_ingresos.EditValue = 0;
                txe_egreso.EditValue = 0;               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_cargarMovimientos_Click(object sender, EventArgs e)
        {
            try
            {
                xx = 1;
                DateTime FechaIni;
                DateTime FechaParaSaldoInicial;
                DateTime FechaFin; 
                ListaSumatoriaIngresos.Clear(); 
                ListaSumatoriaEgresos.Clear();
                gridControl_Ingresos.DataSource = "";
                gridControl_Egresos.DataSource = "";
                
                txe_SaldoCtbleAnterior.EditValue = 0;
                txe_ingresos.EditValue = 0;
                txe_egreso.EditValue = 0;
                txt_Saldo_anterior_banco.EditValue = 0.00;
                if (Info_Periodo == null)
                {
                    Info_Periodo = ListaPeriodo.Where(v => v.IdPeriodo ==Convert.ToInt32( Info_Conciliacion_Generarl.IdPeriodo)).FirstOrDefault();
                }


                if (Info_Banco == null)
                {
                    Info_Banco =ListadoBancos .Where(v => v.IdBanco == Convert.ToInt32(Info_Conciliacion_Generarl.IdBanco)).FirstOrDefault();
                }

                if (Info_Banco.IdBanco > 0 || ultraCmbCtaBanco.EditValue != null)
                {
               if(Info_Periodo.IdPeriodo>0 || Info_Periodo!=null )
                {
                   
                    FechaParaSaldoInicial = Convert.ToDateTime(dtp_desde.Value.ToShortDateString());

                    FechaIni =Convert.ToDateTime(dtp_desde.Value.ToShortDateString());
                    FechaFin = Convert.ToDateTime(dtp_hasta.Value.ToShortDateString());
                    string MensajeError = "";

                    CbtDet_B.Get_SaldoContableMesAnterior(param.IdEmpresa, Info_Banco.IdCtaCble, FechaParaSaldoInicial, ref saldo, ref MensajeError);
                    txe_SaldoCtbleAnterior.EditValue   = Math.Round(saldo,2);

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {// trae todas las transacciones menor que fecha fin y de estado que no esten check
                        ListTransaccionesAConciliar = Concil_B.Get_List_Transacciones_x_Conciliar(param.IdEmpresa, Info_Banco.IdCtaCble.ToString(), FechaIni, FechaFin);

                    }
                    else
                    {
                        if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                        {
                            // trae todas las transacciones menor que fecha fin y de estado que no esten check
                            ListTransaccionesAConciliar_TMP = Concil_B.Get_List_Transacciones_x_Conciliar(param.IdEmpresa, Info_Banco.IdCtaCble.ToString(), FechaIni, FechaFin);
                            //trae todas las transacciones correspondiente a la concilicacion de estado check=tru y check =false
                            ListTransaccionesAConciliar = Concil_B.Get_List_Transacciones_x_Conciliar(param.IdEmpresa, Info_Banco.IdCtaCble.ToString(), FechaIni, FechaFin, Convert.ToInt32(txt_NConciliacion.Text), Info_Conciliacion_Generarl.IdBanco);

                            foreach (var item in ListTransaccionesAConciliar_TMP)
                            {
                                ListTransaccionesAConciliar.Add(item);
                            }
                        }
                        else
                        {
                            ListTransaccionesAConciliar = Concil_B.Get_List_Transacciones_x_Conciliar(param.IdEmpresa, Info_Banco.IdCtaCble.ToString(), FechaIni, FechaFin, Convert.ToInt32(txt_NConciliacion.Text),Info_Conciliacion_Generarl.IdBanco);


                        }
                    }
                        if (ListTransaccionesAConciliar.Count==0)
                        {
                            MessageBox.Show("No existe información bancaria a conciliar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                
                        //INGRESOS
                         list_Ingreso =new BindingList<vwba_TransaccionesAConciliar_Info>( ListTransaccionesAConciliar.Where<vwba_TransaccionesAConciliar_Info>(c => c.Tipo=="+").ToList());
                                         
                        //EGRESOS
                         list_Egreso = new BindingList<vwba_TransaccionesAConciliar_Info>(ListTransaccionesAConciliar.Where<vwba_TransaccionesAConciliar_Info>(c => c.Tipo == "-").ToList());

                        gridControl_Egresos.DataSource = list_Egreso;
                        gridControl_Ingresos.DataSource = list_Ingreso;
                      

                     var TotalIngresos = BindLstSistema.ToList().FindAll(v => v.Tipo == "+" && v.chk == true).Sum(v => v.dc_Valor);
                        txe_ingresos.EditValue = Convert.ToDouble(TotalIngresos);
                        //}
                        //else
                        //{
                        var TotalEgresos = BindLstSistema.ToList().FindAll(v => v.Tipo == "-" && v.chk == true).Sum(v => v.dc_Valor);
                        txe_egreso.EditValue = Convert.ToDouble(TotalEgresos);
                   //eeee
                        gridControlSistema.DataSource = BindLstSistema;
              }
               else
                   MessageBox.Show("Favor seleccione el Periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

               Calculo_Saldos();

            }
            else
                MessageBox.Show("Favor seleccione la Cuenta Bancaria", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ultraCmbE_periodo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                
                txe_SaldoCtbleAnterior.EditValue = 0;
                txe_ingresos.EditValue = 0;
                txe_egreso.EditValue = 0;
                txe_saldoConciliado.EditValue = 0;
                txe_saldoBanco.EditValue = null;
                txe_diferencia.EditValue = 0;
                txt_Saldo_anterior_banco.EditValue = 0.00;
                
                gridControl_Ingresos.DataSource = null;
                gridControl_Egresos.DataSource = null;
                
                if (ultraCmbE_periodo.EditValue == null)
                    return;
                int IdPeriodo = (int)ultraCmbE_periodo.EditValue;
                Info_Periodo = ListaPeriodo.FirstOrDefault(q => q.IdPeriodo == IdPeriodo);
                
                Boolean MesAnteriorConciliado;
                label14.Visible = false;
                
                if (Concil_B.VerificarConciliacionPrimeraVez(param.IdEmpresa, Convert.ToInt32(ultraCmbCtaBanco.EditValue)))
                {
                    label14.Visible = false;
                    MesAnteriorConciliado = true;
                }
                else
                {
                    ct_Periodo_Info PeriodoAnterior = BusPeriodo.Get_Info_PeriodoAnterior(param.IdEmpresa,Info_Periodo== null ? 0 : Info_Periodo.IdPeriodo, ref MensajeError);
                    MesAnteriorConciliado = Concil_B.VerificarPeriodoConciliado(param.IdEmpresa, PeriodoAnterior.IdPeriodo, Convert.ToInt32(ultraCmbCtaBanco.EditValue));
                }
                if (!MesAnteriorConciliado)
                {
                   // MessageBox.Show("El periodo anterior aun no ha sido conciliado por favor verifique ");
                    label14.Text="PERIODO ANTERIOR NO CONCILIADO";
                    label14.Visible = true;
                }
                else
                {
                    bool MesActual = Concil_B.VerificarPeriodoConciliado(param.IdEmpresa, Info_Periodo.IdPeriodo, Convert.ToInt32(ultraCmbCtaBanco.EditValue));
                    if (MesActual)
                    {
                       // MessageBox.Show("El periodo Actual ya ha sido conciliado por favor verifique ");
                        label14.Text = "PERIODO ACTUAL YA FUE CONCILIADO";
                        label14.Visible = true;
                    }
                }



                //_p = (ct_Periodo_Info)item.ListObject;
                dtp_desde.Value = Info_Periodo.pe_FechaIni;
                dtp_hasta.Value = Info_Periodo.pe_FechaFin;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_Ingresos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //if (e.Column.Caption == "*")
                //{
                //    double Tta = 0;

                //    var data = gridView_Ingresos.GetRow(e.RowHandle) as vwba_TransaccionesAConciliar_Info;
                //    if (data.chk == true)
                //    {
                //        ListaSumatoriaIngresos.Add(data);
                //    }
                //    else
                //    {
                //        ListaSumatoriaIngresos.Remove(data);
                //    }
                //    Tta = 0;
                //    foreach (var item in ListaSumatoriaIngresos)
                //    {
                //        Tta = Tta + item.dc_Valor;
                //    }
                //    this.txt_ingresos.Value = Convert.ToDecimal(Tta);
                //}
                //Calculo_Saldos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_Egresos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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

        private void Calculo_Saldos()
        {
            try
            {
                    txe_saldoConciliado.EditValue = Math.Round(Convert.ToDouble(txt_Saldo_anterior_banco.EditValue),2)+ Math.Round(Convert.ToDouble(txe_ingresos.EditValue) - Convert.ToDouble(txe_egreso.EditValue), 2);
                    txe_diferencia.EditValue = Math.Round(Convert.ToDouble(txe_saldoConciliado.EditValue) - Convert.ToDouble(txe_saldoBanco.EditValue), 2);
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_saldoBanco_ValueChanged(object sender, EventArgs e)
        {
            try
            {
              Calculo_Saldos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public Boolean validaColumna()
        {
            try
            {
                Boolean estado = true;

                if (this.ultraCmbCtaBanco.EditValue == null)
                {
                    MessageBox.Show("Antes de continuar seleccione la Cta. Bancaria", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (this.ultraCmbE_periodo.EditValue == null)
                {
                    MessageBox.Show("Antes de continuar seleccione el Periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (Math.Round(Convert.ToDouble(txe_diferencia.EditValue), 2) > 0 || Math.Round(Convert.ToDouble(txe_diferencia.EditValue), 2) < 0)
                {
                    if (MessageBox.Show("Hay diferencia  en la conciliacion ¿Desea guardar una preconciliacion ?", "Conciliacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        estado = true;
                        EstadoConciliacion = "PRE_CONCIL";
                    }
                    else
                    {
                        estado = false;
                    }


                }

                else
                {
                    if (MessageBox.Show("Para cerrar la Conciliacion [SI]  Para preconciliar [NO], ", "Conciliacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        EstadoConciliacion = "CONCILIADO";
                        estado = true;
                    }
                    else
                    {
                        EstadoConciliacion = "PRE_CONCIL";
                        estado = true;
                    }

                }

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

        private bool Grabar()
        {
            try
            {
                bool res = false;
                if (validaColumna())
                {                   
                    txt_NConciliacion.Focus();
                    get_Conciliacion();
                    string msg = "";

                    Concil_I.Estado_Conciliacion = EstadoConciliacion;
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (Concil_B.GrabarDB(Concil_I,ref IdConciliacion,ref msg))
                        {
                            txt_NConciliacion.Text = IdConciliacion.ToString();

                            if (MessageBox.Show("Se guardo la Conciliación del periodo " + Info_Periodo.nom_periodo + " Correctamente con el #: " + txt_NConciliacion.Text + "\n ¿ Desea Imprimir la Conciliación #: " + txt_NConciliacion.Text+" ?", " Imprimir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                           
                               ImprimiConciliacion(Concil_I.IdBanco,Convert.ToInt32( txt_NConciliacion.Text));
                            }

                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            res = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Grabar la Conciliación.. ( " + msg + " )", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (Concil_B.ModificarDB(Concil_I))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente)+" la conciliación #: " + txt_NConciliacion.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (MessageBox.Show("Se guardo la Conciliación del periodo " + Info_Periodo.nom_periodo + " Correctamente con el #: " + txt_NConciliacion.Text + "\n ¿ Desea Imprimir la Conciliación #: " + txt_NConciliacion.Text+" ?", " Imprimir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                ImprimiConciliacion(Concil_I.IdBanco, Convert.ToInt32(txt_NConciliacion.Text));
                            }
                            res = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar la conciliación #: " + this.txt_NConciliacion.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular la Conciliación #: " + txt_NConciliacion.Text + " Se procedera a liberar los comprobantes aplicados", "Anulación de Conciliación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (MessageBox.Show("Acontinuación se procederá a eliminar físicamente de la base de datos esta conciliación, ¿Está realmente seguro que desea anular la Conciliación #: " + txt_NConciliacion.Text, param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                /*
                                Se decidió eliminar por completo de la base para asegurar consistencia de registros 
                                Aprobado por RICARDO YANZA
                                
                                FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                                fr.ShowDialog();
                                motiAnulacion = fr.motivoAnulacion;
                                Concil_I.MotivoAnulacion = motiAnulacion;
                                
                                if (Concil_B.AnularDB(Concil_I)) 
                                */
                                if (Concil_B.EliminarDB(Concil_I))
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Conciliación ", txt_NConciliacion.Text);
                                    MessageBox.Show(smensaje, param.Nombre_sistema);
                                    res = true;
                                }
                                else
                                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Anular, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);    
                            }
                            
                        }
                    }
                }
                else
                    MessageBox.Show("No se puede grabar Conciliación...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool GrabarAccion() 
        {
            try
            {
                return Grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        
        }
       
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
 
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        btn_cargarMovimientos.Enabled = false;
                        ultraCmbE_periodo.Enabled = false;

                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        btn_cargarMovimientos.Enabled = false;
                        ultraCmbE_periodo.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        btn_cargarMovimientos.Enabled = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        btn_cargarMovimientos.Enabled = false;
                        ultraCmbE_periodo.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        btn_cargarMovimientos.Enabled = false;
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
       
        private void ultraCmbCtaBanco_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmbCtaBanco.EditValue == null)
                {
                    ultraCmbCtaBanco.EditValue = ""; 
                    txt_CtaCble.Text = "";
                    txt_nombreCta.Text = "";
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ultraCmbE_periodo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmbE_periodo.EditValue == null)
                { ultraCmbE_periodo.EditValue = ""; }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
       
        private void FrmBa_ConciliacionBancaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FrmBa_ConciliacionBancaria_event_FrmBa_ConciliacionBancaria_FormClosing(sender,e);
                event_FrmBa_ConciliacionBancaria_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void gridControl_Ingresos_Click(object sender, EventArgs e)
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

        private void txt_nombreCta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //gpB_Resumen.Text = "Resumen CtaCble: " + txt_nombreCta.Text.Trim();
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
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
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

        void ObtenerRuta()
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

                    ruta = path + "\\" + fileName;
                    CANCEL = false;
                }
                else
                {
                    CANCEL = true;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void CargarArchivoExcelADataTable()
        {
            try
            {

                String strconn = "";
                strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta+ ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(strconn);
                //
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [MOVI_BAN$]", mconn);

                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(ds);
                //cierra una conexion de tipo oledb
                mconn.Close();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                ds = new DataTable();
            }
        }

        private void btnCargaExcel_Click(object sender, EventArgs e)
        {
            try
            {

                FrmBA_Bancos ofr = new FrmBA_Bancos();
             
                ofr.ShowDialog();
                int IdBancoTipo = ofr.IdBanco;
                ObtenerRuta();
                if (CANCEL)
                {

                }
                else
                {
                    ds = new DataTable();
                    ListExcel.Clear();
                    gridControlExcel.DataSource = ListExcel;
                    
                    CargarArchivoExcelADataTable();
                    ListExcel.Clear();
                    ListExcel = new BindingList<vwba_TransaccionesAConciliar_Info>(ProcesarDataTableAInfo(ds));

                    foreach (var item in ListExcel)
                    {
                        item.IdHASH = string.Format("{0}-MOVI_BAN$-s{1}-{2}-{3}-d{4}-{5}-{6}", fileName, item.SecuenciaRelacionado, item.cb_Fecha, item.CodTipoCbteBan, item.cb_Cheque, item.cb_Observacion, item.dc_Valor);
                    }
                    if (ListExcel.Count == 0) 
                    {
                        MessageBox.Show("El excel no cumple con el formato por favor consulte con sistemas",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        ListExcel = new BindingList<vwba_TransaccionesAConciliar_Info>();
                        gridControlExcel.DataSource = ListExcel;
                        return;
                    }
                    gridControlExcel.DataSource = ListExcel;
                    btn_cargarMovimientos_Click(sender, e);
                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());         
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (ultraCmbCtaBanco.EditValue == null || Convert.ToString(ultraCmbCtaBanco.EditValue) == "") 
                    {
                        MessageBox.Show("Por favor seleccione Cta. Bancaria");
                        return;
                    }
                if (ultraCmbE_periodo.EditValue == null || Convert.ToString(ultraCmbE_periodo.EditValue) == "")
                    {
                        MessageBox.Show("Por favor seleccione Perido");
                        return;
                    }
                    List<vwba_TransaccionesAConciliar_Info> Sistema = ListExcel.ToList();//.FindAll(v => v.chk == true);

                    Sistema.ForEach(v => { v.chk = false; v.IdCtaCble = null; v.IdCentroCosto = null; v.IdTipoNota = 0; });
                    if (Sistema.FindAll(v => v.CodTipoCbteBan != "NDBA" && v.CodTipoCbteBan != "NCBA").Count() != 0)
                    {
                        MessageBox.Show("Se Han encontrado Cheques o depositos solo se migraran Notas de Credito y Debito");
                
                    }
                    FrmBA_ImportarND_NC ofr = new FrmBA_ImportarND_NC(Sistema.FindAll(v => v.CodTipoCbteBan == "NDBA" || v.CodTipoCbteBan== "NCBA"));
                    ofr.IdCtaCbleBanco = txt_CtaCble.Text.Trim();
                    ofr.IdBanco = Convert.ToInt32(ultraCmbCtaBanco.EditValue);
                    ofr.GetList_NotadasDeb_Cred += ofr_GetList_NotadasDeb_Cred;
                    ofr.fileName = fileName;
                    ofr.ShowDialog();
                    return;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void ofr_GetList_NotadasDeb_Cred(List<vwba_TransaccionesAConciliar_Info> Sistema)
        {
            try
            {
                List<vwba_TransaccionesAConciliar_Info> Temp = new List<vwba_TransaccionesAConciliar_Info>();
                List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> _Parametros_ = _BusCbtBanXCtbtCble.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(param.IdEmpresa);
                ba_Cbte_Ban_Bus BusSave = new ba_Cbte_Ban_Bus();
                foreach (var item in Sistema)
                {
                    var CANT = (from q in BindLstSistema where q.SecuenciaRelacionado == item.SecuenciaConciliacion select q).Count();
                    if (CANT == 0)
                    {

                        item.chk = false;
                        item.SecuenciaRelacionado = item.SecuenciaConciliacion;
                        item.SecuenciaConciliacion = xx;
                        item.ReferenciaCbte = item.CodTipoCbteBan;
                        xx++;
                        Temp.Add(item);
                    }
                }
                foreach (var item in Temp)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    if (item.CodTipoCbteBan == "NDBA")
                    {
                        item.Tipo = "+";
                    }
                    else
                    {
                        item.Tipo = "-";
                    }
                    BindLstSistema.Add(item);
                }
                gridControlSistema.DataSource = BindLstSistema;
                gridControlSistema.RefreshDataSource();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());  
            }
        }

        private void btnConciliar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListExcel.Count == 0) 
                    {
                        MessageBox.Show("No existen datos importados para verificar");
                        return;
            
                    }
                    foreach (var item in BindLstSistema)
                    {
                
                        foreach (var item1 in ListExcel)
                        {

                            if (item.Equals(item1))
                            {
                                item.chk = true;
                                if (item.SecuenciaRelacionado == 0)
                                {
                                    item.SecuenciaRelacionado = item1.SecuenciaConciliacion;
                                    item.Orden = item.SecuenciaRelacionado;
                                    item1.chk = true;
                                    break;
                                }
                        
                            }

                    
                        }

                    }
                    ListExcel.ToList().ForEach(v => { if(v.chk==false) v.SecuenciaRelacionado = 10000; });
                    gridControlExcel.DataSource = ListExcel;
                    Orden.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                    gridColumn31.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                    gridControlExcel.RefreshDataSource();
                    gridControlSistema.RefreshDataSource();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }

        private void gridView_Ingresos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "*")
                {
                    double Tta = 0;

                    var data = gridView_Ingresos.GetRow(e.RowHandle) as vwba_TransaccionesAConciliar_Info;
                    if (data!=null)
                    {
                        if (Convert.ToBoolean(e.Value) == true)
                        {
                            ListaSumatoriaIngresos.Add(data);
                        }
                        else
                        {
                            ListaSumatoriaIngresos.Remove(data);
                        }
                        Tta = 0;
                        foreach (var item in ListaSumatoriaIngresos)
                        {
                            Tta = Tta + item.dc_Valor;
                        }
                        txe_ingresos.EditValue = Convert.ToDouble(Tta);
                    }
                }
                Calculo_Saldos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_Egresos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "*")
                {
                    double Tta = 0;

                    var data = gridView_Egresos.GetRow(e.RowHandle) as vwba_TransaccionesAConciliar_Info;
                    if (data!=null)
                    {
                        if (Convert.ToBoolean(e.Value) == true)
                        {
                            ListaSumatoriaEgresos.Add(data);
                        }
                        else
                        {
                            ListaSumatoriaEgresos.Remove(data);
                        }
                        Tta = 0;
                        foreach (var item in ListaSumatoriaEgresos)
                        {
                            Tta = Tta + item.dc_Valor;
                        }
                        txe_egreso.EditValue = Convert.ToDouble(Tta);
                    }
                }
                Calculo_Saldos();
                //txt_observacion.Focus();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewSistema_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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

        private void gridViewSistema_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "*")
                {
                    if (Convert.ToBoolean(gridViewSistema.GetFocusedRowCellValue(chkcolum)))
                    {
                        gridViewSistema.SetFocusedRowCellValue(chkcolum, false);
                    }
                    else
                    {
                        gridViewSistema.SetFocusedRowCellValue(chkcolum, true);
                    }

                    vwba_TransaccionesAConciliar_Info item = gridViewSistema.GetFocusedRow() as vwba_TransaccionesAConciliar_Info;
                    //if (item.CodTipoCbteBan == "NDBA")
                    //{
                    var TotalIngresos = BindLstSistema.ToList().FindAll(v => v.Tipo == "+" && v.chk == true).Sum(v => v.dc_Valor);
                    txe_ingresos.EditValue = Convert.ToDouble(TotalIngresos);
                    //}
                    //else
                    //{
                    var TotalEgresos = BindLstSistema.ToList().FindAll(v => v.Tipo == "-" && v.chk == true).Sum(v => v.dc_Valor);
                    txe_egreso.EditValue = Convert.ToDouble(TotalEgresos);
                    //}
                    Calculo_Saldos();

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        ListaSumatoriaIngresos.Clear();
                        ListaSumatoriaEgresos.Clear();
                        txe_SaldoCtbleAnterior.EditValue = 0;
                        txe_ingresos.EditValue = 0;
                        txe_egreso.EditValue = 0;
                        txe_saldoConciliado.EditValue = 0;
                      //  txe_saldoBanco.EditValue = 0;
                        txe_diferencia.EditValue = 0;
                        txt_Saldo_anterior_banco.EditValue = 0.00;
                        btn_cargarMovimientos_Click(new object(), new EventArgs());
                    }   
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
           
        }

        private void ultraCmbE_periodo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ultraCmbE_periodo.EditValue == null)
                    return;

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    var Verif = Concil_B.VerificarPeriodoConciliado(param.IdEmpresa,Convert.ToInt32( ultraCmbE_periodo.EditValue), Convert.ToInt32(ultraCmbCtaBanco.EditValue));

                    if (Verif)
                    {
                        MessageBox.Show("El Perdiodo seleccionado ya se encuentra conciliado", param.Nombre_sistema);
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                    }
                    else
                    {
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
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

        public List<vwba_TransaccionesAConciliar_Info> ProcesarDataTableAInfo(DataTable ds)
        {
            try
            {
                List<vwba_TransaccionesAConciliar_Info> lista = new List<vwba_TransaccionesAConciliar_Info>();
                try
                {
                    lst_ba_Info = bus_CodBcoExt.Get_List_Cbte_Ban_tipo_x_CodBancoExterno();
                    //ro_Empleado_Data dataEmp = new ro_Empleado_Data();
                    if (ds.Columns.Count > 5)
                    {
                        foreach (DataRow row in ds.Rows)
                        {
                            vwba_TransaccionesAConciliar_Info info = new vwba_TransaccionesAConciliar_Info();
                            Boolean grabar = true;
                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                switch (col)
                                {
                                    case 0:
                                        string SecuencialPropio = Convert.ToString(row[col]);
                                        //int fe = Convert.ToInt32(fechaTrans);
                                        int sec = 0;
                                        if (Int32.TryParse(SecuencialPropio, out sec))
                                        {
                                            info.SecuenciaConciliacion = Convert.ToInt32(SecuencialPropio);
                                        }
                                        else
                                        {
                                            col = ds.Columns.Count + 1; grabar = false;
                                            //MessageBox.Show("El formato del excel no es el correcto por favor confirmar con sisetmas");

                                            break;

                                        }

                                        break;

                                    case 1:
                                        string fechaTrans = Convert.ToString(row[col]);
                                        //int fe = Convert.ToInt32(fechaTrans);
                                        DateTime dt;
                                        if (DateTime.TryParse(fechaTrans, out dt))
                                        {
                                            info.cb_Fecha = Convert.ToDateTime(fechaTrans);
                                        }
                                        else
                                        {
                                            col = ds.Columns.Count + 1; grabar = false;
                                            //MessageBox.Show("El formato del excel no es el correcto por favor confirmar con sisetmas"); 
                                            break;
                                        }

                                        break;
                                    case 2:

                                        string Tipo = Convert.ToString(row[col]);
                                        try
                                        {
                                            var a = lst_ba_Info.First(var => var.CodBanco == Tipo.Trim());
                                            if (a != null)
                                            {
                                                info.CodTipoCbteBan = a.CodTipoCbteBan;
                                                info.CodTipoCbte = Tipo.Trim();

                                            }
                                        }
                                        catch (Exception)
                                        {

                                            col = ds.Columns.Count + 1; grabar = false;
                                            MessageBox.Show("El Codigo del tipo de comprobante '" + Tipo +
                                                "' no esta configurado...\rComuniquese con Sistemas.", param.Nombre_sistema,
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;
                                        }

                                        break;
                                    case 3:
                                        string NumDoc = Convert.ToString(row[col]);
                                        if (!String.IsNullOrWhiteSpace(NumDoc))
                                            info.cb_Cheque = NumDoc;
                                        break;
                                    case 4:
                                        string Concepto = Convert.ToString(row[col]);
                                        if (!String.IsNullOrWhiteSpace(Concepto))
                                            info.cb_Observacion = Concepto;
                                        break;
                                    case 5:
                                        String Valor = Convert.ToString(row[col]);
                                        string ab = Valor.Substring(0, 1);
                                        if (ab == "$")
                                            Valor = Valor.Substring(1);

                                        Valor = Valor.Replace('.', ',');
                                        int q = 0;
                                        int index = 0;
                                        for (int i = 0; i < Valor.Length; i++)
                                        {
                                            if (Valor[i] == ',')
                                            {
                                                q++;
                                                index = i;
                                            }
                                        }
                                        if (q != 0)
                                        {
                                            Valor.Remove(index);
                                        }

                                        Double val = 0;
                                        if (Double.TryParse(Valor, out val))
                                        {
                                            info.dc_Valor = Convert.ToDouble(Valor);
                                        }
                                        else
                                        {
                                            col = ds.Columns.Count + 1; grabar = false;
                                            //MessageBox.Show("El formato del excel no es el correcto por favor confirmar con sisetmas");
                                            break;
                                        }
                                        break;
                                    case 6:
                                        string Ref = Convert.ToString(row[col]);
                                        if (!String.IsNullOrWhiteSpace(Ref))
                                            info.cb_Observacion = info.cb_Observacion + " Ref:" + Ref;
                                        break;
                                    default:
                                        //grabar = false;
                                        break;
                                }
                            }
                            if (grabar != false)
                                lista.Add(info);
                            //else { return new List<vwba_TransaccionesAConciliar_Info>(); }
                        }


                    }
                    else
                    {
                        MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 6  columnas.";
                        lista = new List<vwba_TransaccionesAConciliar_Info>();
                    }
                    int k = 0; lista.ForEach(var => var.SecuenciaConciliacion = ++k);
                }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                    lista = new List<vwba_TransaccionesAConciliar_Info>();
                }
                return lista;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<vwba_TransaccionesAConciliar_Info>();
            }
        }

        private void ultraCmbCtaBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                txt_nombreCta.Text = "";
                txt_CtaCble.Text = "";
                txt_observacion.Text = "";
                txe_SaldoCtbleAnterior.EditValue = 0;
                txe_ingresos.EditValue = 0;
                txe_egreso.EditValue = 0;
                txe_saldoConciliado.EditValue = 0;
                txe_saldoBanco.EditValue = null;
                txe_diferencia.EditValue = 0;
                txt_Saldo_anterior_banco.EditValue = 0.00;
                if (ultraCmbCtaBanco.EditValue == null)
                    return;
                int IdBanco = (int)ultraCmbCtaBanco.EditValue;
                //Info_Banco = (ba_Banco_Cuenta_Info)gridView3.GetFocusedRow();
                Info_Banco = ListadoBancos.FirstOrDefault(q => q.IdBanco == IdBanco);
                if (Info_Banco != null)
                {
                    txt_CtaCble.Text = Info_Banco.IdCtaCble.ToString();
                    var cta_I = LstCta.FirstOrDefault(c => c.IdCtaCble == Info_Banco.IdCtaCble);
                    txt_nombreCta.Text = (cta_I.pc_Cuenta == null) ? "" : cta_I.pc_Cuenta.Trim();
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }



        }

        private void txe_saldoBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calculo_Saldos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btn_conciliacion_Auto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBA_ConciliacionBancaria_Auto_x_Excel frm = new FrmBA_ConciliacionBancaria_Auto_x_Excel();
                frm.Show();

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                int IdBanco=Convert.ToInt32( ultraCmbCtaBanco.EditValue);
                ImprimiConciliacion(IdBanco, Convert.ToInt32( txt_NConciliacion.Text));

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Cargar_Datos()
        {
            try
            {    ListadoBancos = bancoB.Get_list_Banco_Cuenta(param.IdEmpresa);
                this.ultraCmbCtaBanco.Properties.DataSource = ListadoBancos;
                ListaPeriodo = PeB.Get_List_PeriodoCombo(param.IdEmpresa, ref MensajeError);
                ultraCmbE_periodo.Properties.DataSource = ListaPeriodo;
                LstCta = _PlanCtaBus.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Limpiar()
        {
            try
            {
                txt_NConciliacion.Text = "";
                txt_nombreCta.Text = "";
                txt_CtaCble.Text = "";
                txt_observacion.Text = "";
                txe_egreso.Text = "";
                txe_ingresos.Text = "";
                txe_saldoBanco.Text = "";

                gridControl_Egresos.DataSource = null;
                gridControl_Ingresos.DataSource = null;
                ListTransaccionesAConciliar = new List<vwba_TransaccionesAConciliar_Info>();

                list_Ingreso = new BindingList<vwba_TransaccionesAConciliar_Info>();
                list_Egreso = new BindingList<vwba_TransaccionesAConciliar_Info>();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                ultraCmbCtaBanco.EditValue = null;
                ultraCmbE_periodo.EditValue = null;
                Cargar_Datos();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_Saldo_anterior_banco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                double saldo = txt_Saldo_anterior_banco.EditValue == null ? 0 : Convert.ToDouble(txt_Saldo_anterior_banco.EditValue);
                Calculo_Saldos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_imprimir_ingresos_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl_Ingresos.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_imprimir_egresos_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl_Egresos.ShowPrintPreview();
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
