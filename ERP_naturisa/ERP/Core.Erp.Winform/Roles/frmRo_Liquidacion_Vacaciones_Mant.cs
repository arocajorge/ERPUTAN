using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Liquidacion_Vacaciones_Mant : Form
    {
        public frmRo_Liquidacion_Vacaciones_Mant()
        {
            InitializeComponent();
            CarGarEmpleado();
            ucGe_Beneficiario.IdTipo_Persona = Cl_Enumeradores.eTipoPersona.EMPLEA;
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_historico_liquidacion_vacaciones_Bus Bus_liquidacion_vacaciones = new ro_historico_liquidacion_vacaciones_Bus();
        ro_historico_liquidacion_vacaciones_Info Info_historico_cancelacion = new ro_historico_liquidacion_vacaciones_Info();
        ro_SolicitudVacaciones_Info Info_General = new ro_SolicitudVacaciones_Info();


        cp_orden_pago_Bus Bus_Orden_pago = new Business.CuentasxPagar.cp_orden_pago_Bus();
        List<cp_orden_pago_det_Info> Detalle_op = new List<Info.CuentasxPagar.cp_orden_pago_det_Info>();
        cp_orden_pago_Info Info_Orden_Pago = new cp_orden_pago_Info();



        vwtb_persona_beneficiario_Info Info_Beneficiario = new vwtb_persona_beneficiario_Info();

        ct_Cbtecble_Info Info_comprobante_Contable = new ct_Cbtecble_Info();
        List<ct_Cbtecble_det_Info> Lista_Comprobante_Contable = new List<ct_Cbtecble_det_Info>();
        ct_Cbtecble_Bus Bus_comprobante_contable = new ct_Cbtecble_Bus();
        ro_Empleado_Bus bus_empleado = new ro_Empleado_Bus();

        ro_Parametros_Bus bus_parametro = new ro_Parametros_Bus();
        ro_Parametros_Info info_parametro = new ro_Parametros_Info();

        double totaRemuneracion = 0;
        double totalVacaciones = 0;
        double remuneracion = 0;
        double vacaciones = 0;
        double cancelar = 0;


        cp_orden_pago_tipo_x_empresa_Bus bus_tipoOP = new cp_orden_pago_tipo_x_empresa_Bus();
        cp_orden_pago_tipo_x_empresa_Info info_tipoOP = new cp_orden_pago_tipo_x_empresa_Info();
        double Sueldo_Actual = 0;
        double IESS = 0;
        double Total_Ganado = 0;
        double Valor_Vacaciones_ganadas_anual = 0;
        double Valor_Vacaciones_tomadas = 0;
        double Valor_Neto = 0;

        string CtaVacaciones = "";
        string ctaIess = "";
        string ctaGasto = "";

        BindingList<ro_Historico_Liquidacion_Vacaciones_Det_Info> detalle = new BindingList<ro_Historico_Liquidacion_Vacaciones_Det_Info>();
        ro_Historico_Liquidacion_Vacaciones_Det_Bus bus_detalle = new ro_Historico_Liquidacion_Vacaciones_Det_Bus();


        private void frmRo_Liquidacion_Vacaciones_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                info_parametro = bus_parametro.Get_Parametros(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                
               
            }
        }




        public bool validar()
        {
            bool bandera_validar = true;
            try
            {



                info_tipoOP = bus_tipoOP.Get_Info_orden_pago_tipo_x_empresa(param.IdEmpresa,info_parametro.IdTipoOP_LiquidacionVacaciones);

                if (txttotal_cancelar.EditValue == null || txttotal_cancelar.EditValue == "")
                {
                    MessageBox.Show("El valor a cancelar es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bandera_validar = false;
                }
                else
                {
                    if (Convert.ToInt32(txttotal_cancelar.EditValue) <= 0)
                    {
                        MessageBox.Show("El valor a cancelar no puede ser cero", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bandera_validar = false;
                    }
                }


                if (Convert.ToDateTime(dtpanio_desde.Value).Year == Convert.ToDateTime(dtp_anio_hasta.Value).Year)
                {
                    MessageBox.Show("El periodo de liquidacion de vacaciones no puede ser el mismo año", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bandera_validar = false;
                }

                if (info_parametro.IdFormaOP_LiquidacionVacaciones == null )
                {
                    MessageBox.Show("Faltan parametros ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bandera_validar = false;
                    return bandera_validar;
                }
                if (info_parametro.IdBancoOP_LiquidacionVacaciones==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bandera_validar = false;
                    return bandera_validar;
                }

                if (info_parametro.IdTipoCbte_AsientoSueldoXPagar == null)
                {
                    MessageBox.Show("Seleccione el tipo de comprobante contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bandera_validar = false;
                    return bandera_validar;
                }




                if (info_tipoOP.IdCtaCble == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Cta Credito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bandera_validar = false;
                    return bandera_validar;
                }


                if (info_parametro.IdFormaOP_LiquidacionVacaciones == null )
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Forma de pago", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bandera_validar = false;
                    return bandera_validar;
                }


                
               
                
                return bandera_validar;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
        public void Get_OrdenPago()
        {
            try
            {
                Detalle_op = new List<cp_orden_pago_det_Info>();
                Info_Orden_Pago = new Info.CuentasxPagar.cp_orden_pago_Info();
                Info_Beneficiario = ucGe_Beneficiario.Get_Persona_beneficiario_Info();
                Info_Orden_Pago.IdEmpresa = param.IdEmpresa;
                Info_Orden_Pago.IdOrdenPago =0;
                Info_Orden_Pago.Observacion = Info_General.Observacion;
                Info_Orden_Pago.IdTipo_op = info_parametro.IdTipoOP_LiquidacionVacaciones;
                Info_Orden_Pago.IdTipo_Persona = Info_Beneficiario.IdTipo_Persona;
                Info_Orden_Pago.IdPersona = Info_Beneficiario.IdPersona;
                Info_Orden_Pago.IdEntidad = Info_Beneficiario.IdEntidad;
                Info_Orden_Pago.Fecha = dtpFechaPago.Value;
                Info_Orden_Pago.IdEstadoAprobacion = "PENDI";
                Info_Orden_Pago.IdFormaPago = info_parametro.IdFormaOP_LiquidacionVacaciones;
                Info_Orden_Pago.IdBanco =info_parametro.IdBancoOP_LiquidacionVacaciones;
                Info_Orden_Pago.Fecha_Pago = dtpFechaPago.Value;
                Info_Orden_Pago.Estado = "A";
                Info_Orden_Pago.Fecha = dtpFechaHasta.Value;
                Info_Orden_Pago.IdUsuario = param.IdUsuario;
                Info_Orden_Pago.IdTipoFlujo = info_parametro.IdTipoFlujoOP_LiquidacionVacaciones;
                // detalle

                cp_orden_pago_det_Info info_detalle = new Info.CuentasxPagar.cp_orden_pago_det_Info();
                info_detalle.IdEmpresa = param.IdEmpresa;
                info_detalle.IdOrdenPago = 0;
                info_detalle.Secuencia = 1;
                info_detalle.Valor_a_pagar = Convert.ToDouble(txttotal_cancelar.EditValue);
                info_detalle.Referencia = "Cancelacion Vacaciones";
                info_detalle.IdFormaPago = info_parametro.IdFormaOP_LiquidacionVacaciones;
                info_detalle.Fecha_Pago = dtpFechaPago.Value;
                info_detalle.IdEstadoAprobacion = "PENDI";
                info_detalle.Idbanco = info_parametro.IdBancoOP_LiquidacionVacaciones;
                Detalle_op.Add(info_detalle);

                Info_Orden_Pago.Detalle = Detalle_op;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public void Get_Comprobante_contable()
        {
            try
            {
                Info_comprobante_Contable = new ct_Cbtecble_Info();
                Info_comprobante_Contable._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                Lista_Comprobante_Contable = new List<ct_Cbtecble_det_Info>();
                Info_comprobante_Contable.IdEmpresa = param.IdEmpresa;
                Info_comprobante_Contable.IdTipoCbte =Convert.ToInt32( info_parametro.IdTipoCbte_AsientoSueldoXPagar);
                Info_comprobante_Contable.IdPeriodo = Convert.ToInt32(Convert.ToDateTime(dtpFechaPago.Value).Year.ToString() + Convert.ToDateTime(dtpFechaPago.Value).Month.ToString().PadLeft(2, '0'));
                Info_comprobante_Contable.cb_Fecha = dtpFechaPago.Value;
                Info_comprobante_Contable.cb_Observacion = Info_General.Observacion;
                Info_comprobante_Contable.Secuencia = 0;
                Info_comprobante_Contable.cb_Valor = Convert.ToDouble(txttotal_cancelar.EditValue);
                Info_comprobante_Contable.Estado = "A";
                Info_comprobante_Contable.Anio = Convert.ToDateTime(dtpFechaPago.Value).Year;
                Info_comprobante_Contable.Mes = Convert.ToDateTime(dtpFechaPago.Value).Month;
                Info_comprobante_Contable.IdUsuario = param.IdUsuario;
                Info_comprobante_Contable.cb_FechaTransac = DateTime.Now;
                Info_comprobante_Contable.Mayorizado = "N";
                // detalle
                ct_Cbtecble_det_Info inf_comp_cont_de_debito = new ct_Cbtecble_det_Info();
                inf_comp_cont_de_debito.IdEmpresa = param.IdEmpresa;
                inf_comp_cont_de_debito.IdTipoCbte = Convert.ToInt32(info_parametro.IdTipoCbte_AsientoSueldoXPagar);
                inf_comp_cont_de_debito.secuencia = 1;
                inf_comp_cont_de_debito.IdCtaCble = info_tipoOP.IdCtaCble;
                inf_comp_cont_de_debito.dc_Valor = cancelar;
                inf_comp_cont_de_debito.dc_Observacion = Info_General.Observacion;
                Lista_Comprobante_Contable.Add(inf_comp_cont_de_debito);

                if (info_parametro.DescuentaIESS_LiquidacionVacaciones == true)
                {
                    if(Info_General.Gozadas_Pgadas==true)
                    {
                    ct_Cbtecble_det_Info inf_comp_cont_de_Credito = new ct_Cbtecble_det_Info();
                    inf_comp_cont_de_Credito.IdEmpresa = param.IdEmpresa;
                    inf_comp_cont_de_Credito.IdTipoCbte = Convert.ToInt32(info_parametro.IdTipoCbte_AsientoSueldoXPagar);
                    inf_comp_cont_de_Credito.secuencia = 2;
                    inf_comp_cont_de_Credito.IdCtaCble = info_parametro.cta_contable_IESS_Vacaciones;
                    inf_comp_cont_de_Credito.dc_Valor =Convert.ToDouble( txtiess.EditValue)*-1;
                    inf_comp_cont_de_Credito.dc_Observacion = Info_General.Observacion;
                    Lista_Comprobante_Contable.Add(inf_comp_cont_de_Credito);
                    }
                }

                    ct_Cbtecble_det_Info inf_comp_cont_de_IESS_Personal = new ct_Cbtecble_det_Info();
                    inf_comp_cont_de_IESS_Personal.IdEmpresa = param.IdEmpresa;
                    inf_comp_cont_de_IESS_Personal.IdTipoCbte = Convert.ToInt32(info_parametro.IdTipoCbte_AsientoSueldoXPagar);
                    inf_comp_cont_de_IESS_Personal.secuencia = 3;
                    inf_comp_cont_de_IESS_Personal.IdCtaCble = info_tipoOP.IdCtaCble_Credito;

                    if (info_parametro.DescuentaIESS_LiquidacionVacaciones == true)
                    {
                        if (Info_General.Gozadas_Pgadas == true)
                        {

                            inf_comp_cont_de_IESS_Personal.dc_Valor = cancelar - Convert.ToDouble(txtiess.EditValue);
                        }
                        else
                            inf_comp_cont_de_IESS_Personal.dc_Valor = vacaciones*-1;
                    }
                    else
                    {
                        inf_comp_cont_de_IESS_Personal.dc_Valor = vacaciones ;
                    }
                    inf_comp_cont_de_IESS_Personal.dc_Observacion= Info_General.Observacion;
                    Lista_Comprobante_Contable.Add(inf_comp_cont_de_IESS_Personal);
                
                Info_comprobante_Contable._cbteCble_det_lista_info = Lista_Comprobante_Contable;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public void Get_Historico_cancelacion()
        {
            try
            {
                Info_historico_cancelacion.IdEmpleado = Info_General.IdEmpresa;
                Info_historico_cancelacion.IdNomina_Tipo = Info_General.IdNomina_Tipo;
                Info_historico_cancelacion.IdEmpleado = Info_General.IdEmpleado;
                Info_historico_cancelacion.IdSolicitud_Vacaciones = Info_General.IdSolicitudVaca;
                Info_historico_cancelacion.ValorCancelado = Convert.ToDouble(txttotal_cancelar.EditValue);
                Info_historico_cancelacion.FechaPago = dtpFechaPago.Value;
                Info_historico_cancelacion.Fecha_Transac = DateTime.Now;
                Info_historico_cancelacion.IdUsuario = param.IdUsuario;
                Info_historico_cancelacion.Observaciones = "Cancelacion de vacaciones de " + Info_Beneficiario.NombreCompleto + " del periodo" + dtpanio_desde.Value + "al " + dtp_anio_hasta.Value;
                Info_historico_cancelacion.detalle = detalle.ToList();
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public bool GrabarDB()
        {
            try
            {
                Get_OrdenPago();
                Get_Comprobante_contable();
                Get_Historico_cancelacion();
                bool bandera_sigrabo = false;
                decimal id_OP = 0;
                decimal id_detalle_OP = 0;
                string mensajeError = "";

                decimal IdCbteCble = 0;
                if (Bus_Orden_pago.GuardaDB(Info_Orden_Pago, ref id_OP, ref mensajeError))
                {
                    int sec = 0;
                    if (Bus_comprobante_contable.GrabarDB(Info_comprobante_Contable, ref IdCbteCble, ref mensajeError))
                    {
                        cp_orden_pago_det_Bus detalle = new cp_orden_pago_det_Bus();

                        foreach (var item in Info_Orden_Pago.Detalle)
                        {
                            item.IdOrdenPago = id_OP;
                            item.IdEmpresa = Info_comprobante_Contable.IdEmpresa;
                            item.IdEmpresa_cxp = param.IdEmpresa;
                            item.IdCbteCble_cxp = IdCbteCble;
                            item.IdTipoCbte_cxp = Info_comprobante_Contable.IdTipoCbte;

                            if (detalle.ModificarDB(item,ref id_detalle_OP,ref mensajeError))
                            {
                                Info_historico_cancelacion.IdEmpresa = param.IdEmpresa;
                                Info_historico_cancelacion.IdOrdenPago = id_OP;
                                Info_historico_cancelacion.IdEmpresa_OP = Info_Orden_Pago.IdEmpresa;
                                if (Bus_liquidacion_vacaciones.GrabarBD(Info_historico_cancelacion))
                                {
                                    bandera_sigrabo = true;
                                    if (bandera_sigrabo)
                                    {
                                        foreach (var item_ in Info_historico_cancelacion.detalle)
                                        {
                                            sec = sec + 1;
                                            if
                                            (sec == 1)                                        
                                            bus_detalle.Eliminar(item_);
                                            item_.Sec = sec;
                                            item_.IdEmpresa = Info_historico_cancelacion.IdEmpresa;
                                            item_.IdEmpleado = Convert.ToInt32(Info_historico_cancelacion.IdEmpleado);
                                            item_.IdSolicitud_Vacaciones = Info_historico_cancelacion.IdSolicitud_Vacaciones;
                                            item_.IdNominatipo = Info_historico_cancelacion.IdNomina_Tipo;
                                            bandera_sigrabo = bus_detalle.Guardar_DB(item_);
                                        }

                                      
                                    }
                                }

                            }

                        }

                      

                    }
                }

                return bandera_sigrabo;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }
       






        public void CarGarEmpleado()
        {
            try
            {
                //ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();
                //List<ro_Empleado_Info> InfoSup = new List<ro_Empleado_Info>();
                //InfoSup = BusEmpleado.Get_List_Empleado_(param.IdEmpresa);
                //this.cmbEmpleado.Properties.DataSource = InfoSup;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public void ObtenerValor()
        {
            try
            {
                Total_Ganado = Bus_liquidacion_vacaciones.Get_Valor_vacaciones(Info_General.IdEmpresa, 1,Convert.ToInt32( Info_General.IdEmpleado),  Convert.ToDateTime( dtpanio_desde.Value), Convert.ToDateTime(dtp_anio_hasta.Value),"4");
                if (Total_Ganado > 0)
                {
                    txttotal_remuneracion.EditValue = Total_Ganado;

                    Valor_Vacaciones_ganadas_anual = Total_Ganado / 24;

                }
                else
                {
                    Valor_Vacaciones_ganadas_anual =Convert.ToDouble( txttotal_remuneracion.EditValue) / 24;
                }
                Valor_Vacaciones_tomadas=(Valor_Vacaciones_ganadas_anual/15)*Info_General.Dias_a_disfrutar;
                IESS=(Sueldo_Actual/30)*Info_General.Dias_a_disfrutar*0.0945;
                Valor_Neto=Valor_Vacaciones_tomadas-IESS;



                txttotal_vacaciones.EditValue = Valor_Vacaciones_ganadas_anual;
                txtiess.EditValue = IESS;
                txttotal_cancelar.EditValue =Valor_Neto;





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }




        public void Set(ro_SolicitudVacaciones_Info info)
        {
            try
            {
                Info_General = info;
                ucGe_Beneficiario.set_Persona_beneficiario_Info(Cl_Enumeradores.eTipoPersona.EMPLEA, info.IdEmpleado);
                if (info.Fecha_Desde.Year == 1)
                    dtpFechaSalida.Value = DateTime.Now;
                else
                    dtpFechaSalida.Value = info.Fecha_Desde;
                if (info.Fecha_Hasta.Year == 1)
                    dtpFechaSalida.Value = DateTime.Now;
                else
                dtpFechaHasta.Value = info.Fecha_Hasta;
                if (info.Fecha_Retorno.Year==1)
                    dtpFechaSalida.Value = DateTime.Now;
                    else
                dtpFechaRetorno.Value = info.Fecha_Retorno;
                dtp_anio_hasta.Value = info.Anio_Hasta;
                dtpanio_desde.Value = info.Anio_Desde;
                txtdias.EditValue = info.Dias_a_disfrutar;
                Sueldo_Actual = bus_empleado.GetSueldoActual(info.IdEmpresa, info.IdEmpleado);
                DateTime fechaDesde = info.Anio_Desde;

                detalle =new BindingList<ro_Historico_Liquidacion_Vacaciones_Det_Info>( bus_detalle.Get_Lis(info.IdEmpresa,Convert.ToInt32( info.IdEmpleado), info.IdSolicitudVaca));
                gridControl_Detalle.DataSource = detalle;

                txttotal_remuneracion.EditValue = detalle.Sum(v => v.Total_Remuneracion);

                txttotal_vacaciones.EditValue = detalle.Sum(v => v.Total_Vacaciones);
                txttotal_cancelar.EditValue = detalle.Sum(v => v.Valor_Cancelar);

                if (detalle.Count() == 0)
                {
                    while (fechaDesde <= info.Anio_Hasta)
                    {
                        ro_Historico_Liquidacion_Vacaciones_Det_Info infod = new ro_Historico_Liquidacion_Vacaciones_Det_Info();
                        infod.IdEmpresa = param.IdEmpresa;
                        infod.IdEmpleado = Convert.ToInt32(info.IdEmpleado);
                        infod.IdSolicitud_Vacaciones = info.IdSolicitudVaca;
                        infod.Anio = fechaDesde.Year;
                        infod.Mes = fechaDesde.Month;
                        infod.IdNominatipo = info.IdNomina_Tipo;
                        fechaDesde = fechaDesde.AddMonths(1);

                        detalle.Add(infod);
                    }
                }
                gridControl_Detalle.DataSource = detalle;
             //   ObtenerValor();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            //ObtenerValor();
        }

        private void dtpFechaRetorno_ValueChanged(object sender, EventArgs e)
        {
           // ObtenerValor();
        }

        private void dtpanio_desde_ValueChanged(object sender, EventArgs e)
        {
           // ObtenerValor();
        }

        private void dtp_anio_hasta_ValueChanged(object sender, EventArgs e)
        {
           // ObtenerValor();
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validar())
                    return;
                if (GrabarDB())
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                
                  MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txttotal_vacaciones_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               // ObtenerValor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txttotal_remuneracion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               // ObtenerValor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtiess_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
              //  ObtenerValor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txttotal_cancelar_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               // txttotal_cancelar.EditValue =Convert.ToDouble( txttotal_vacaciones.EditValue) -Convert.ToDouble( txtiess.EditValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_vacaciones_Load(object sender, EventArgs e)
        {

        }

        private void gridView_Detalle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gridView_Detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double iess = 0;
              
                if (e.Column.Name == "Col_Total_Remuneracion")
                {
                     totaRemuneracion = 0;
                     totalVacaciones = 0;
                     remuneracion = 0;
                     vacaciones = 0;
                     cancelar = 0;
                    totaRemuneracion = (Convert.ToDouble(gridView_Detalle.GetFocusedRowCellValue(Col_Total_Remuneracion)));
                    totalVacaciones =(totaRemuneracion / 24);
                    gridView_Detalle.SetFocusedRowCellValue(Col_Total_Vacaciones, totalVacaciones);
                    gridView_Detalle.SetFocusedRowCellValue(Col_Valor_Cancelar, (totalVacaciones / 15) * Convert.ToInt32(txtdias.EditValue));



                    remuneracion = detalle.Sum(v => v.Total_Remuneracion);
                    vacaciones = detalle.Sum(v => v.Total_Vacaciones);
                    cancelar=detalle.Sum(v => v.Valor_Cancelar);

                    txttotal_remuneracion.EditValue = remuneracion;
                    txttotal_vacaciones.EditValue = vacaciones;
                    txttotal_cancelar.EditValue = cancelar;

                    if (info_parametro.DescuentaIESS_LiquidacionVacaciones == true)
                    {
                        if(Info_General.Gozadas_Pgadas==true)
                        {
                        iess = ((Sueldo_Actual / 30) * (Convert.ToInt32(txtdias.EditValue)) * 9.45) / 100;
                        txttotal_cancelar.EditValue = Convert.ToDouble(cancelar) - iess;
                        txtiess.EditValue = iess;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
               
            }
        }
  
    }
}
