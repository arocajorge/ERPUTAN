using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Cancelacion_Cuotas : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> listParaBan = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus paramBa_B = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info paramBa_I = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();

        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();

        ba_prestamo_detalle_Info Info_DetCancela = new ba_prestamo_detalle_Info();
        ba_parametros_Info parametro_banco_info = new ba_parametros_Info();
        ba_parametros_Bus parametro_banco_bus = new ba_parametros_Bus();
        ba_prestamo_detalle_cancelacion_Bus bus_PrestamoCan = new ba_prestamo_detalle_cancelacion_Bus();
        public ba_prestamo_detalle_Info Info_DetPrestamo { get; set; }


        public FrmBA_Cancelacion_Cuotas()
        {
            try
            {

                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;


                listParaBan = paramBa_B.Get_List_Banco_Parametros(param.IdEmpresa);
                paramBa_I = listParaBan.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "NDBA"; });


                if (paramBa_I == null)
                {
                    MessageBox.Show("No puede continuar porque no han ingresado los parámetros de banco.. Ingréselos desde la pantalla de parámetros de banco", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    if (paramBa_I.IdCtaCble == null || paramBa_I.IdCtaCble == "" || paramBa_I.IdTipoCbteCble == null || paramBa_I.IdTipoCbteCble < 1 || paramBa_I.IdTipoCbteCble_Anu == null || paramBa_I.IdTipoCbteCble_Anu < 1)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco.. Ingréselos desde la pantalla de parámetros de banco", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaColumna())
                {
                    GetInfo();

                    if (bus_PrestamoCan.GuardarDetallePrestamosCancelados(Info_DetCancela, ref mensaje))
                    {
                        MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, param.Nombre_sistema);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        string mensaje = "";

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (validaColumna())
                {
                  
                    GetInfo();

                    if (bus_PrestamoCan.GuardarDetallePrestamosCancelados(Info_DetCancela, ref mensaje))
                    {

                        MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, param.Nombre_sistema);
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                              
                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        public void setInfo()
        {
            try
            {
                txe_IdPrestamo.EditValue = Info_DetPrestamo.IdPrestamo;
                txe_Banco.EditValue = Info_DetPrestamo.NomBanco;
                dte_Fecha.EditValue = Info_DetPrestamo.FechaPago;  
                txe_numCuota.EditValue = Info_DetPrestamo.NumCuota;
                txe_ValorCuota.EditValue = Info_DetPrestamo.TotalCuota;
                txe_SaldoPendiente.EditValue = Info_DetPrestamo.Saldo_Canc;
                txt_Observacion.Text = Info_DetPrestamo.Observacion_canc;
                txe_Mon_x_Can.EditValue = Info_DetPrestamo.TotalCuota;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               
            }
        
        
        }
        public Boolean validaColumna()
       {
           try
           {
               string MensajeError = "";
               Boolean estado = true;
               Per_I = Per_B.Get_Info_Periodo(Info_DetPrestamo.IdEmpresa, Convert.ToDateTime(dte_Fecha.EditValue), ref MensajeError);

               if (Per_I.IdPeriodo == 0)
               {

                   MessageBox.Show("El Periodo no se encuentra ingresado en la Base de Datos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   estado = false;

               }
              
                   if (Per_I.pe_cerrado == "S")
                   {
                       MessageBox.Show("No se procedio a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                       estado = false;
                       
                   }


                   if (cmb_banco.get_BaCuentaInfo()==null)
                   {
                       MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el)+" banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                       estado = false;

                   }


                   if (parametro_banco_info.IdCtaCble_prestamos==null || parametro_banco_info.IdCtaCble_Interes == null)
                   {
                       MessageBox.Show(" Falta cuentas contable en paramatros de bancos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                       estado = false;

                   }


               return estado;
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               NameMetodo = NameMetodo + " - " + ex.ToString();
               MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                   , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               return false;
           }
       }

        void get_detalle()
       {
           try
           {          // se crea el comprobante contable 
                       string cod_CbteCble = "";
                       ba_Cbte_Ban_Info comprobante_bancario_info = new ba_Cbte_Ban_Info();
                       comprobante_bancario_info.IdEmpresa = param.IdEmpresa;
                       comprobante_bancario_info.IdCbteCble = 0;
                       comprobante_bancario_info.IdTipocbte =(int)parametro_banco_info.IdTipoCbte_x_Prestamo;
                       comprobante_bancario_info.Cod_Cbtecble = (comprobante_bancario_info.Cod_Cbtecble == "" || comprobante_bancario_info.Cod_Cbtecble == null || comprobante_bancario_info.Cod_Cbtecble == "0") ? cod_CbteCble : comprobante_bancario_info.Cod_Cbtecble;
                       comprobante_bancario_info.IdPeriodo = Convert.ToInt32(Convert.ToDateTime(dte_Fecha.EditValue).Year.ToString() + Convert.ToDateTime(dte_Fecha.EditValue).Month.ToString().PadLeft(2,'0'));
                       comprobante_bancario_info.IdBanco = cmb_banco.get_BaCuentaInfo().IdBanco;
                       comprobante_bancario_info.IdProveedor = null;                      
                       comprobante_bancario_info.cb_Fecha = Convert.ToDateTime(dte_Fecha.EditValue);    //duda
                       comprobante_bancario_info.cb_Observacion = "Nota de Débtio de la Cuota#: " + Info_DetPrestamo.NumCuota + " ,del Préstamo#: " + Info_DetPrestamo.IdPrestamo + " y Valor: " + txe_Mon_x_Can.EditValue;
                       comprobante_bancario_info.cb_secuencia = (comprobante_bancario_info.cb_secuencia == 0) ? 0 : comprobante_bancario_info.cb_secuencia;
                       comprobante_bancario_info.cb_Valor = Convert.ToDouble(txe_Mon_x_Can.EditValue);
                       comprobante_bancario_info.Estado = "A";
                       comprobante_bancario_info.IdUsuario = param.IdUsuario;
                       comprobante_bancario_info.Fecha_Transac = param.Fecha_Transac;
                       comprobante_bancario_info.cb_ChequeImpreso = "N";
                       comprobante_bancario_info.ip = param.ip;
                       comprobante_bancario_info.nom_pc = param.nom_pc;
                       Info_DetCancela.Info_CbteBan = comprobante_bancario_info;                                

               // creo el diario contable
                       ct_Cbtecble_Info comprobante_contable_info = new ct_Cbtecble_Info();

                       comprobante_contable_info.IdEmpresa = Info_DetPrestamo.IdEmpresa;
                       comprobante_contable_info.IdTipoCbte =(int) parametro_banco_info.IdTipoCbte_x_Prestamo;
                       comprobante_contable_info.IdPeriodo  = Convert.ToInt32(Convert.ToDateTime(dte_Fecha.EditValue).Year.ToString() + Convert.ToDateTime(dte_Fecha.EditValue).Month.ToString().PadLeft(2,'0'));
                       comprobante_contable_info.cb_Fecha = Convert.ToDateTime(dte_Fecha.EditValue);
                       comprobante_contable_info.cb_Valor = Convert.ToDouble(txe_Mon_x_Can.EditValue);
                       comprobante_contable_info.cb_Observacion = "Nota de Débtio de la Cuota#: " + Info_DetPrestamo.NumCuota + " ,del Préstamo#: " + Info_DetPrestamo.IdPrestamo + " y Valor: " + txe_Mon_x_Can.EditValue;
                       comprobante_contable_info.Secuencia = 0;
                       comprobante_contable_info.Estado = "A";
                       comprobante_contable_info.Anio = Convert.ToDateTime(dte_Fecha.EditValue).Year;
                       comprobante_contable_info.Mes = Convert.ToDateTime(dte_Fecha.EditValue).Month;
                       comprobante_contable_info.IdUsuario = param.IdUsuario;

                       comprobante_contable_info.cb_FechaTransac = param.Fecha_Transac;

                       comprobante_contable_info.Mayorizado = "N";

                       //Detalle Diario

                       //Debe cuota 
                       ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                       debe.IdEmpresa = Info_DetPrestamo.IdEmpresa;
                       debe.IdTipoCbte = (int)parametro_banco_info.IdTipoCbte_x_Prestamo;
                       debe.IdCtaCble = parametro_banco_info.IdCtaCble_prestamos;
                       debe.dc_Observacion = "Abono capital de la cuota#: " + Info_DetPrestamo.NumCuota + " ,del Préstamo#: " + Info_DetPrestamo.IdPrestamo + "por: " + Info_DetPrestamo.AbonoCapital;
                       debe.dc_Valor = Convert.ToDouble(Info_DetPrestamo.AbonoCapital); ;
                       comprobante_contable_info._cbteCble_det_lista_info.Add(debe);

                       //Debe interes 
                       ct_Cbtecble_det_Info debe_In = new ct_Cbtecble_det_Info();
                       debe_In.IdEmpresa = Info_DetPrestamo.IdEmpresa;
                       debe_In.IdTipoCbte = (int)parametro_banco_info.IdTipoCbte_x_Prestamo;
                       debe_In.IdCtaCble = parametro_banco_info.IdCtaCble_Interes;
                       debe_In.dc_Observacion = "Intere de la cuota#: " + Info_DetPrestamo.NumCuota + " ,del Préstamo#: " + Info_DetPrestamo.IdPrestamo + " por : " + Info_DetPrestamo.Interes;
                       debe_In.dc_Valor = Convert.ToDouble(Info_DetPrestamo.Interes);

                       comprobante_contable_info._cbteCble_det_lista_info.Add(debe_In);

                       //Haber
                       ct_Cbtecble_det_Info Haber = new ct_Cbtecble_det_Info();
                       Haber.IdEmpresa = Info_DetPrestamo.IdEmpresa;
                       Haber.IdTipoCbte = (int)parametro_banco_info.IdTipoCbte_x_Prestamo;
                       Haber.IdCtaCble = cmb_banco.get_BaCuentaInfo().IdCtaCble; //Info_DetPrestamo.IdCtaCble_Prestamo;
                       Haber.dc_Observacion = "Nota de Débito de la Cuota#: " + Info_DetPrestamo.NumCuota + " ,del Préstamo#: " + Info_DetPrestamo.IdPrestamo + " por: " + txe_Mon_x_Can.EditValue;
                       Haber.dc_Valor = Convert.ToDouble(txe_Mon_x_Can.EditValue) * -1;
                       comprobante_contable_info._cbteCble_det_lista_info.Add(Haber);


                       Info_DetCancela.Info_CbteCble = comprobante_contable_info;
                   
              
                       
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               NameMetodo = NameMetodo + " - " + ex.ToString();
               MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                   , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

           }
       }

     

        private Boolean GetInfo()
       {
           Boolean res = false;
           try
           {
                          
                   Info_DetCancela.IdEmpresa = param.IdEmpresa;
                   Info_DetCancela.IdPrestamo = Info_DetPrestamo.IdPrestamo;
                   Info_DetCancela.FechaPago = Convert.ToDateTime(dte_Fecha.EditValue);
                   Info_DetCancela.NumCuota = Convert.ToInt32(txe_numCuota.EditValue);
                   Info_DetCancela.Observacion_canc = txt_Observacion.Text;
                   Info_DetCancela.TotalCuota = Info_DetPrestamo.TotalCuota;
                   Info_DetCancela.IdUsuario = param.IdUsuario;
                   Info_DetCancela.Fecha_Transac = param.Fecha_Transac;
                   Info_DetCancela.Saldo = Convert.ToDouble(Math.Round(Convert.ToDouble(txe_SaldoPendiente.EditValue), 2));
                   Info_DetCancela.Monto_Canc = Convert.ToDouble(Math.Round(Convert.ToDouble(txe_Mon_x_Can.EditValue), 2));
                   Info_DetCancela.ip = param.ip;
                   Info_DetCancela.nom_pc = param.nom_pc;

                   get_detalle();
              
               res = true;
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               NameMetodo = NameMetodo + " - " + ex.ToString();
               MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                   , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
           }
           return res;
       }

        private void FrmBA_Cancelacion_Cuotas_Load(object sender, EventArgs e)
        {
            try
            {
                parametro_banco_info = parametro_banco_bus.Get_Info_Banco_Otros_Parametros(param.IdEmpresa);
                setInfo();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txe_Mon_x_Can_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txe_Mon_x_Can.EditValue) == 0)
                {
                    txe_SaldoPendiente.EditValue = Info_DetPrestamo.Saldo_Canc;
                    return;
                }

                if (Convert.ToDouble(txe_Mon_x_Can.EditValue) > Math.Round(Convert.ToDouble(txe_Mon_x_Can.EditValue), 2))
                {
                    txe_Mon_x_Can.EditValue = 0;
                    txe_SaldoPendiente.EditValue = Info_DetPrestamo.Saldo_Canc;
                    return;
                }

                if (Convert.ToDouble(txe_Mon_x_Can.EditValue) < 0)
                {
                    txe_Mon_x_Can.EditValue = 0;
                    txe_SaldoPendiente.EditValue = Info_DetPrestamo.Saldo_Canc;
                    return;
                }

                double saldo = Math.Round(Convert.ToDouble(txe_Mon_x_Can.EditValue), 2) - Convert.ToDouble(txe_Mon_x_Can.EditValue);

                txe_SaldoPendiente.EditValue = saldo;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }    
    }
}
