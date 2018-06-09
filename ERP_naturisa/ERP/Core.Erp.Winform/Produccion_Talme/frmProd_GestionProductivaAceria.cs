using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_GestionProductivaAceria : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        prod_horno_CusTalme_Bus Horno_Bus = new prod_horno_CusTalme_Bus();
        in_producto_Bus Producto_Bus = new in_producto_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus sucursales_Bus = new tb_Sucursal_Bus();
        prod_GestionProductivaAcero_CusTalme_Bus _Bus = new prod_GestionProductivaAcero_CusTalme_Bus();
        prod_Parametro_Info _Parametros = new prod_Parametro_Info();
        prod_Parametro_Bus _Para_b = new prod_Parametro_Bus();
        in_movi_inve_Bus BusMOvi_B = new in_movi_inve_Bus();
        prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Bus BusInter = new prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public frmProd_GestionProductivaAceria()
        {
            try
            {
                 InitializeComponent();
                _Parametros = _Para_b.ConsultaGeneral(param.IdEmpresa);
                cmbHorno.Properties.DataSource = Horno_Bus.ConsultaGeneral();
                cmbTipo.Properties.DataSource = (List<in_Producto_Info>)Producto_Bus.Get_list_ProductosXModeloProduccio(param.IdEmpresa, 5);
                cmbSucursal.Properties.DataSource = sucursales_Bus.Get_List_Sucursal(param.IdEmpresa);
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }

        private void txtTiempoEncendido_EditValueChanged(object sender, EventArgs e){}

        private void txtTiempoApagado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               //CalcularTiempoTotal();
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtTiempoFundicion_EditValueChanged(object sender, EventArgs e){}

        private void txtTiempoVaciado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
             //CalcularTiempoTotal();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtTiempoTotal_EditValueChanged(object sender, EventArgs e){}

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                return;
                if (Validar()) 
                {
                    Get();
                    decimal IdGestion = 0;
                    string Mensaje = "";
                    if (_Bus.GuardarDB(_Info, ref IdGestion, ref Mensaje))
                    {
                        MessageBox.Show(Mensaje);
                        BtnGuardar.Enabled = false;
                        btnGuardarySalir.Enabled = false;
                        btnAnular.Enabled = true;
                        GenerarMovimientos(IdGestion);
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtTiempoApagado_Leave(object sender, EventArgs e)
        {
            try
            {
               CalCularTiempoFundicion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        private void txtTiempoEncendido_Leave(object sender, EventArgs e)
        {
            try
            {
                 CalCularTiempoFundicion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void CalCularTiempoFundicion() {}

        private void txtTiempoVaciado_Leave(object sender, EventArgs e)
        {
            try
            {
                //CalcularTiempoTotal();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        void CalcularTotal() 
        {
            try
            {
                string[] tiempoEncendido = txtTiempoEncendido.Text.Split(':');
                string[] tiempoApagado = txtTiempoApagado.Text.Split(':');
                TimeSpan HoraEncen = new TimeSpan(Convert.ToInt32(tiempoEncendido[0]), Convert.ToInt32(tiempoEncendido[1]), 0);
                TimeSpan HoraApagado = new TimeSpan(Convert.ToInt32(tiempoApagado[0]), Convert.ToInt32(tiempoApagado[1]), 0);
                //string[] tiempoApagado = txtTiempoApagado.Text.Split(':');
                string[] tiempoVaciado = txtTiempoVaciado.Text.Split(':');
                string[] tiempoFundicion = txtTiempoFundicion.Text.Split(':');
                //TimeSpan HoraApagado = new TimeSpan(Convert.ToInt32(tiempoApagado[0]), Convert.ToInt32(tiempoApagado[1]), 0);
                TimeSpan HoraVaciado = new TimeSpan(Convert.ToInt32(tiempoVaciado[0]), Convert.ToInt32(tiempoVaciado[1]), 0);
                TimeSpan HoraFundicion = new TimeSpan(Convert.ToInt32(tiempoFundicion[0]), Convert.ToInt32(tiempoFundicion[1]), 0);
                TimeSpan Total = HoraFundicion.Add((HoraVaciado.Subtract(HoraApagado)));
                txtTiempoTotal.EditValue = Total.ToString("hh':'mm");
                txtTiempoTotal.Text = txtTiempoTotal.Text;
                double Valor = 0;
                if (double.TryParse(Convert.ToDouble(Convert.ToDouble(txtEnergiaEr.Text) - Convert.ToDouble(txtEnergiaEa.Text)).ToString(), out Valor))
                {
                    txtEnergiaTotal.EditValue = Valor;
                }
                else
                {
                    txtEnergiaTotal.EditValue = 0;
                }

                Double TotalPositivos = Convert.ToDouble(Convert.ToDouble(txtChatarraHorno.Text) + Convert.ToDouble(txtchatarraCargada.Text));
                Double Totalnegativos = Convert.ToDouble(Convert.ToDouble(txtVaciadoAcero.Text) + Convert.ToDouble(TxtHornoAcero.Text));
                Double TotalD = TotalPositivos - Totalnegativos;
                txtHornoPerdida.EditValue = TotalD;


                Double AceroVaciado = Convert.ToDouble(txtVaciadoAcero.Text);
                Double AceroEnHorno = Convert.ToDouble(TxtHornoAcero.Text);
                Valor = (Math.Round((AceroVaciado / (TotalPositivos - AceroEnHorno)) * 100, 1));
                if (double.IsInfinity(Valor) || double.IsNaN(Valor))
                {
                    txtIndicadoresRendimiento.EditValue = 0;
                }
                else
                {
                    txtIndicadoresRendimiento.EditValue = Valor;

                }
                //txtIndicadoresRendimiento.EditValue = (Math.Round((AceroVaciado /(TotalPositivos-AceroEnHorno))*100,1));



                string[] tiempoTotal = txtTiempoTotal.Text.Split(':');
                TimeSpan HoraTotal = new TimeSpan(Convert.ToInt32(tiempoTotal[0]), Convert.ToInt32(tiempoTotal[1]), 0);
                Valor = (Math.Round(((AceroVaciado / 1000) / ((HoraTotal.TotalMinutes) * (0.000694444))), 2));
                if (double.IsInfinity(Valor) || double.IsNaN(Valor))
                {
                    txtIndicadoresProductividad.EditValue = 0;
                }
                else
                {
                    txtIndicadoresProductividad.EditValue = Valor;

                }

                string[] tiempoInicio = txtIncioCC.Text.Split(':');
                string[] tiempofin = txtFinCC.Text.Split(':');
                TimeSpan HoraInicio = new TimeSpan(Convert.ToInt32(tiempoInicio[0]), Convert.ToInt32(tiempoInicio[1]), 0);
                TimeSpan HoraFin = new TimeSpan(Convert.ToInt32(tiempofin[0]), Convert.ToInt32(tiempofin[1]), 0);
                txtTiempo.Text = HoraFin.Subtract(HoraInicio).ToString("hh':'mm");

                txtPerdidaCC.EditValue = Convert.ToDouble(Convert.ToDouble(txtAceroCldo.Text) - Convert.ToDouble(txtPalanquilla.Text) - Convert.ToDouble(txtMarrano.Text) - Convert.ToDouble(txtEscoria.Text));


                txtPerdida.EditValue = Math.Round(Convert.ToDouble(txtHornoPerdida.Text) + Convert.ToDouble(txtEscoria.Text), 2);

                Valor = Math.Round(Convert.ToDouble(txtPalanquilla.Text) / (Convert.ToDouble(txtAceroCldo.Text) + Convert.ToDouble(txtMarrano.Text)) * 100, 2);
                if (double.IsInfinity(Valor) || double.IsNaN(Valor))
                {
                    txtRendtCC.EditValue = 0;
                }
                else
                {
                    txtRendtCC.EditValue = Valor;
                }


                double Divisor = (Convert.ToDouble(txtchatarraCargada.Text) + Convert.ToDouble(txtChatarraHorno.Text)) - (Convert.ToDouble(txtMarrano.Text) + Convert.ToDouble(TxtHornoAcero.Text));
                Valor = Math.Round((Convert.ToDouble(txtPalanquilla.Text) / Divisor) * 100, 2);

                if (double.IsInfinity(Valor) || double.IsNaN(Valor))
                {
                    txtProdRendt.EditValue = 0;
                }
                else
                {
                    txtProdRendt.EditValue = Valor;
                }


                string[] tiempo = txtTiempo.Text.Split(':');
                TimeSpan Hora = new TimeSpan(Convert.ToInt32(tiempo[0]), Convert.ToInt32(tiempo[1]), 0);
                Valor = Math.Round((Convert.ToDouble(txtPalanquilla.Text) / 1000) / (Hora.TotalMinutes * (0.000694444)), 2);
                if (double.IsInfinity(Valor) || double.IsNaN(Valor))
                {
                    txtProductvCC.EditValue = 0;
                }
                else
                {
                    txtProductvCC.EditValue = Valor;
                }



                // string[] tiempoTotal = txtTiempoTotal.Text.Split(':');
                HoraTotal = new TimeSpan(Convert.ToInt32(tiempo[0]), Convert.ToInt32(tiempo[1]), 0);
                Valor = Math.Round((Convert.ToDouble(txtPalanquilla.Text) / 1000) / (HoraFin.Subtract(HoraEncen).TotalMinutes * (0.000694444)), 2);
                //Valor = Math.Round(((Convert.ToDouble(txtPalanquilla.Text) / 1000) / (HoraTotal.Add(Hora).TotalMinutes * (0.000694444))), 2);
                if (double.IsInfinity(Valor) || double.IsNaN(Valor))
                {
                    txtPrdoProducto.EditValue = 0;
                }
                else
                {
                    txtPrdoProducto.EditValue = Valor;
                }


                Valor = Math.Round((Convert.ToDouble(txtPalanquilla.Text) / Convert.ToDouble(txtUnidades.Text)), 2);
                if (double.IsInfinity(Valor) || double.IsNaN(Valor))
                {
                    txtPesoUnitario.EditValue = 0;
                }
                else
                {
                    txtPesoUnitario.EditValue = Valor;
                }

                Valor = Math.Round((Convert.ToDouble(txtPesoUnitario.Text) / Convert.ToDouble(txtLongitud.Text)), 2);
                if (double.IsInfinity(Valor) || double.IsNaN(Valor))
                {
                    txtPesoMetro.EditValue = 0;
                }
                else
                {
                    txtPesoMetro.EditValue = Valor;
                }


                txtTiempoFundicion.EditValue = HoraApagado.Subtract(HoraEncen).ToString("hh':'mm");
                txtTiempoFundicion.Text = txtTiempoFundicion.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        private void txtEnergiaEr_Leave(object sender, EventArgs e)
        {
            try
            {
                 //txtEnergiaTotal.EditValue = 
                //txtEnergiaTotal.EditValue = Convert.ToDouble(Convert.ToDouble(txtEnergiaEr.Text) - Convert.ToDouble(txtEnergiaEa.Text));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }      
        }

        private void TxtHornoAcero_Leave(object sender, EventArgs e)
        {
            try
            {
                //txtIndicadoresProductividad.EditValue = (Math.Round(((AceroVaciado / 1000) / ((HoraTotal.TotalMinutes)*(0.000694444))), 2));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtIndicadoresRendimiento_EditValueChanged(object sender, EventArgs e){}

        private void TxtHornoAcero_EditValueChanged(object sender, EventArgs e){}

        private void txtIncioCC_EditValueChanged(object sender, EventArgs e){}

        private void txtFinCC_Leave(object sender, EventArgs e){}

        private void txtFinCC_EditValueChanged(object sender, EventArgs e){}

        private void txtEscoria_Leave(object sender, EventArgs e){}

        private void txtMarrano_Leave(object sender, EventArgs e){}

        private void txtPalanquilla_Leave(object sender, EventArgs e){}

        private void txtUnidades_Leave(object sender, EventArgs e){}

        private void txtLongitud_Leave(object sender, EventArgs e){}


        prod_GestionProductivaAcero_CusTalme_Info _Info;

        void Get() 
        {
            try
            {
                _Info = new prod_GestionProductivaAcero_CusTalme_Info();

                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdSucursal = Convert.ToInt32(cmbSucursal.EditValue);
                _Info.Fecha = Convert.ToDateTime(Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString());


                _Info.IdHorno = Convert.ToInt16(cmbHorno.EditValue);
                _Info.IdColada = Convert.ToDecimal(txtColada.EditValue);

                _Info.chat_En_Horno = Convert.ToDouble(txtChatarraHorno.EditValue);
                _Info.chat_Cargada = Convert.ToDouble(txtchatarraCargada.EditValue);

                _Info.Vaci_TempC = Convert.ToDouble(txtVaciado.EditValue);
                _Info.Vaci_acero = Convert.ToDouble(txtVaciadoAcero.EditValue);

                _Info.EnHor_Acero = Convert.ToDouble(TxtHornoAcero.EditValue);
                _Info.EnHor_Perdida = Convert.ToDouble(txtHornoPerdida.EditValue);

                _Info.Comps_C = Convert.ToDouble(txtComposicionC.EditValue);
                _Info.Comps_Si = Convert.ToDouble(txtComposicionSi.EditValue);
                _Info.Comps_Mn = Convert.ToDouble(txtComposicionMn.EditValue);
                _Info.Comps_P = Convert.ToDouble(txtComposicionP.EditValue);
                _Info.Comps_S = Convert.ToDouble(txtComposicionS.EditValue);
                _Info.Comps_SAE = Convert.ToDouble(txtComposicionSAE.EditValue);

                _Info.AdiMet_Carburante = Convert.ToDouble(txtAdicionalesCarburante.EditValue);
                _Info.AdiMet_Cal = Convert.ToDouble(txtAdicionalesCal.EditValue);
                _Info.AdiMet_Desercoriante = Convert.ToDouble(txtAdicionalesDeserCoriante.EditValue);


                string[] tiempoEncendido = txtTiempoEncendido.Text.Split(':');
                string[] tiempoApagado = txtTiempoApagado.Text.Split(':');
                string[] tiempoFundicion = txtTiempoFundicion.Text.Split(':');
                string[] tiempoVaciado = txtTiempoVaciado.Text.Split(':');
                string[] tiempototal = txtTiempoTotal.Text.Split(':');
                _Info.Tiem_Encendido = new TimeSpan(Convert.ToInt32(tiempoEncendido[0]), Convert.ToInt32(tiempoEncendido[1]), 0);
                _Info.Tiem_Apagado = new TimeSpan(Convert.ToInt32(tiempoApagado[0]), Convert.ToInt32(tiempoApagado[1]), 0);
                _Info.Tiem_Fundicion = new TimeSpan(Convert.ToInt32(tiempoFundicion[0]), Convert.ToInt32(tiempoFundicion[1]), 0);
                _Info.Tiem_Vaciado = new TimeSpan(Convert.ToInt32(tiempoVaciado[0]), Convert.ToInt32(tiempoVaciado[1]), 0);
                _Info.Tiem_Total = new TimeSpan(Convert.ToInt32(tiempototal[0]), Convert.ToInt32(tiempototal[1]), 0);

                _Info.Ener_Ea = Convert.ToDouble(txtEnergiaEa.EditValue);
                _Info.Ener_Er = Convert.ToDouble(txtEnergiaEr.EditValue);
                _Info.Ener_Total = Convert.ToDouble(txtEnergiaTotal.EditValue);

                _Info.Ferroa_FeSi = Convert.ToDouble(txtFerroaleacionesFesi.EditValue);
                _Info.Ferroa_FeMn = Convert.ToDouble(txtFerroaleacionesFeMn.EditValue);

                _Info.IndiHor_Productividad = Convert.ToDouble(txtIndicadoresProductividad.EditValue);
                _Info.IndiHor_Rendimiento = Convert.ToDouble(txtIndicadoresRendimiento.EditValue);

                _Info.Observacion = txtObservacion.Text;

                _Info.Tundish = Convert.ToDecimal(txtTundish.EditValue);

                string[] InicioCC = txtIncioCC.Text.Split(':');
                string[] FinCC = txtFinCC.Text.Split(':');
                string[] Tiempo = txtTiempo.Text.Split(':');
                _Info.InicioCC = new TimeSpan(Convert.ToInt32(InicioCC[0]), Convert.ToInt32(InicioCC[1]), 0);
                _Info.FinCC = new TimeSpan(Convert.ToInt32(FinCC[0]), Convert.ToInt32(FinCC[1]), 0);
                _Info.Tiempo = new TimeSpan(Convert.ToInt32(Tiempo[0]), Convert.ToInt32(Tiempo[1]), 0);


                _Info.AceroCldo = Convert.ToDouble(txtAceroCldo.EditValue);
                _Info.Palanquilla = Convert.ToDouble(txtPalanquilla.EditValue);
                _Info.Marrano = Convert.ToDouble(txtMarrano.EditValue);
                _Info.Escoria = Convert.ToDouble(txtEscoria.EditValue);
                _Info.PerdidaCC = Convert.ToDouble(txtPerdidaCC.EditValue);
                _Info.RendtCC = Convert.ToDouble(txtRendtCC.EditValue);
                _Info.ProductivCC = Convert.ToDouble(txtProductvCC.EditValue);
                _Info.IdProducto_TipoPalanquilla = Convert.ToDouble(cmbTipo.EditValue);
                _Info.Unidades = Convert.ToDouble(txtUnidades.EditValue);
                _Info.Longitud = Convert.ToDouble(txtLongitud.EditValue);
                _Info.PesoUnitario = Convert.ToDouble(txtPesoUnitario.EditValue);
                _Info.PesoMetro = Convert.ToDouble(txtPesoMetro.EditValue);
                _Info.Perdida = Convert.ToDouble(txtPerdida.EditValue);
                _Info.ProdRend = Convert.ToDouble(txtProdRendt.EditValue);
                _Info.ProdProduct = Convert.ToDouble(txtPrdoProducto.EditValue);

                _Info.IdGestionAceria = Convert.ToDecimal(txtIdGestion.EditValue);


                _Info.FeSiMn = Convert.ToDouble(txtFESIMN.EditValue);
                _Info.Termopares = Convert.ToDouble(txtTermoPares.EditValue);




                prod_ParametrosPorCampos_Bus BusParamentroscampos = new prod_ParametrosPorCampos_Bus();
                in_movi_inve_Info MovimientoCabecera = new in_movi_inve_Info();
                in_producto_Bus BusProducto = new in_producto_Bus();
                List<in_movi_inve_detalle_Info> MovimientoDetalle = new List<in_movi_inve_detalle_Info>();
                MovimientoCabecera.IdEmpresa = param.IdEmpresa;
                
                foreach (var item in BusParamentroscampos.Consulta(param.IdEmpresa))
                {
                    foreach (Control control in panel.Controls)
                    {
                        if (control.HasChildren) 
                        {
                            foreach (Control textbox in control.Controls)
                            {
                                if (item.NompreCampo == textbox.Name)
                                {
                                    in_movi_inve_detalle_Info obj = new in_movi_inve_detalle_Info();
                                    obj.IdEmpresa = param.IdEmpresa;
                                    in_Producto_Info Producto = BusProducto.Get_Info_BuscarProducto(Convert.ToDecimal(item.IdProducto), param.IdEmpresa);
                                    obj.IdProducto = Convert.ToInt32(item.IdProducto);
                                    obj.IdSucursal = Convert.ToInt32(cmbSucursal.EditValue);
                                    obj.dm_cantidad = Convert.ToDouble(textbox.Text);
                                    obj.mv_costo = Producto.pr_costo_promedio;
                                    obj.mv_tipo_movi = "-";
                                    //obj.dm_stock_ante = Producto.kr_stockActual;
                                    obj.dm_stock_actu = obj.dm_stock_ante - obj.dm_cantidad;
                                    obj.dm_precio = obj.dm_precio;
                                    obj.peso = obj.peso;
                          
                                    MovimientoDetalle.Add(obj); 
                                }
                            }
                        }                        
                    }                    
                }
                MovimientoCabecera.listmovi_inve_detalle_Info = MovimientoDetalle;
               
                foreach (Control item in this.Controls)
                {
                    if (item.Name == "") 
                    {
                    
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }


        public prod_GestionProductivaAcero_CusTalme_Info _SetInfo { get; set; }

        void Set() 
        {

            try
            {
                cmbSucursal.EditValue = _SetInfo.IdSucursal;
                dtpFecha.EditValue = _SetInfo.Fecha;
                txtIdGestion.EditValue = _SetInfo.IdGestionAceria;

                cmbHorno.EditValue = _SetInfo.IdHorno;
                txtColada.EditValue = _SetInfo.IdColada;

                txtChatarraHorno.EditValue = _SetInfo.chat_En_Horno;
                txtchatarraCargada.EditValue = _SetInfo.chat_Cargada;

                txtVaciado.EditValue = _SetInfo.Vaci_TempC;
                txtVaciadoAcero.EditValue = _SetInfo.Vaci_acero;

                TxtHornoAcero.EditValue = _SetInfo.EnHor_Acero;
                txtHornoPerdida.EditValue = _SetInfo.EnHor_Perdida;

                txtComposicionC.EditValue = _SetInfo.Comps_C;
                txtComposicionSi.EditValue = _SetInfo.Comps_Si;
                txtComposicionMn.EditValue = _SetInfo.Comps_Mn;
                txtComposicionP.EditValue = _SetInfo.Comps_P;
                txtComposicionS.EditValue = _SetInfo.Comps_S;
                txtComposicionSAE.EditValue = _SetInfo.Comps_SAE;

                txtAdicionalesCarburante.EditValue = _SetInfo.AdiMet_Carburante;
                txtAdicionalesCal.EditValue = _SetInfo.AdiMet_Cal;
                txtAdicionalesDeserCoriante.EditValue = _SetInfo.AdiMet_Desercoriante;


                txtTiempoEncendido.EditValue = _SetInfo.Tiem_Encendido;
                txtTiempoApagado.EditValue = _SetInfo.Tiem_Apagado;
                txtTiempoFundicion.EditValue = _SetInfo.Tiem_Fundicion;
                txtTiempoVaciado.EditValue = _SetInfo.Tiem_Vaciado;
                txtTiempoTotal.EditValue = _SetInfo.Tiem_Total;

                txtEnergiaEa.EditValue = _SetInfo.Ener_Ea;
                txtEnergiaEr.EditValue = _SetInfo.Ener_Er;
                txtEnergiaTotal.EditValue = _SetInfo.Ener_Total;

                txtFerroaleacionesFesi.EditValue = _SetInfo.Ferroa_FeSi;
                txtFerroaleacionesFeMn.EditValue = _SetInfo.Ferroa_FeMn;

                txtIndicadoresProductividad.EditValue = _SetInfo.IndiHor_Productividad;
                txtIndicadoresRendimiento.EditValue = _SetInfo.IndiHor_Rendimiento;

                txtObservacion.Text = _SetInfo.Observacion;

                txtTundish.EditValue = _SetInfo.Tundish;


                txtIncioCC.EditValue = _SetInfo.InicioCC;
                txtFinCC.EditValue = _SetInfo.FinCC;
                txtTiempo.EditValue = _SetInfo.Tiempo;


                txtAceroCldo.EditValue = _SetInfo.AceroCldo;
                txtPalanquilla.EditValue = _SetInfo.Palanquilla;
                txtMarrano.EditValue = _SetInfo.Marrano;
                txtEscoria.EditValue = _SetInfo.Escoria;
                txtPerdidaCC.EditValue = _SetInfo.PerdidaCC;
                txtRendtCC.EditValue = _SetInfo.RendtCC;
                txtProductvCC.EditValue = _SetInfo.ProductivCC;
                cmbTipo.EditValue = _SetInfo.IdProducto_TipoPalanquilla;
                txtUnidades.EditValue = _SetInfo.Unidades;
                txtLongitud.EditValue = _SetInfo.Longitud;
                txtPesoUnitario.EditValue = _SetInfo.PesoUnitario;
                txtPesoMetro.EditValue = _SetInfo.PesoMetro;
                txtPerdida.EditValue = _SetInfo.Perdida;
                txtProdRendt.EditValue = _SetInfo.ProdRend;
                txtPrdoProducto.EditValue = _SetInfo.ProdProduct;

                txtFESIMN.EditValue = _SetInfo.FeSiMn;
                txtTermoPares.EditValue = _SetInfo.Termopares;

                if (_SetInfo.Estado == "I")
                {
                    lblEstado.Visible = true;
                    BtnGuardar.Enabled = false;
                    btnGuardarySalir.Enabled = false;
                    btnAnular.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmProd_GestionProductivaAceria_Load(object sender, EventArgs e)
        {
            try
            {
                Event_frmProd_GestionProductivaAceria_FormClosing += new Delegate_frmProd_GestionProductivaAceria_FormClosing(frmProd_GestionProductivaAceria_Event_frmProd_GestionProductivaAceria_FormClosing);
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        btnAnular.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        BtnGuardar.Enabled = false;
                        btnGuardarySalir.Enabled = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        BtnGuardar.Enabled = false;
                        btnGuardarySalir.Enabled = false;
                        btnAnular.Enabled = false;
                        Set();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        void frmProd_GestionProductivaAceria_Event_frmProd_GestionProductivaAceria_FormClosing(object sender, FormClosingEventArgs e){}

        public delegate void Delegate_frmProd_GestionProductivaAceria_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmProd_GestionProductivaAceria_FormClosing Event_frmProd_GestionProductivaAceria_FormClosing;
        
        private void frmProd_GestionProductivaAceria_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmProd_GestionProductivaAceria_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta Seguro que desea Eliminar la Compra ?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Get();
                    string Mensaje = "";
                    if (_Bus.Anular(_Info, ref Mensaje))
                    {
                        MessageBox.Show(Mensaje);
                        btnAnular.Enabled = false;



                        prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Bus BusInte = new prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Bus();


                        var MovimientosInventario = BusInte.ConsultaGenera(param.IdEmpresa, _Info.IdSucursal, _Info.IdGestionAceria);
                        foreach (var item in MovimientosInventario)
                        {
                            in_movi_inve_Info _in_movi_inven_I = new in_movi_inve_Info();
                            _in_movi_inven_I.IdSucursal = item.mv_IdSucursal;
                            _in_movi_inven_I.IdBodega = item.mv_IdBodega;
                            _in_movi_inven_I.IdEmpresa = item.mv_IdEmpresa;
                            _in_movi_inven_I.IdMovi_inven_tipo = item.mv_IdMovi_inven_tipo;
                            _in_movi_inven_I.IdNumMovi = item.mv_IdNumMovi;
                            if (BusMOvi_B.AnularDB(_in_movi_inven_I,Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref Mensaje) == false)
                            {
                                MessageBox.Show(Mensaje);
                            }
                        }
                    }
                }
            }
                
            
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
 

        Boolean Validar()
        {
            try
            {
                if (string.IsNullOrEmpty(txtObservacion.Text)) 
                {
                    MessageBox.Show("Por favor Ingrese Observacion");
                    return false;
                }
                if (string.IsNullOrEmpty(cmbSucursal.Text) || cmbSucursal.EditValue == null || cmbSucursal.Text == "[Vacio]") 
                {
                    MessageBox.Show("Por Seleccione Sucursal");
                    return false;
                }
                if (string.IsNullOrEmpty(cmbHorno.Text) || cmbHorno.EditValue == null || cmbHorno.Text == "[Vacio]")
                {
                    MessageBox.Show("Por Seleccione Horno");
                    return false;
                }
                if (string.IsNullOrEmpty(cmbTipo.Text) || cmbTipo.EditValue == null || cmbTipo.Text == "[Vacio]")
                {
                    MessageBox.Show("Por Seleccione Tipo Producto");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
        void GenerarMovimientos(decimal IdGestion)
        {
            try
            {
                #region MovimientoxIngresoPalanquilla

                string mensaje_cbte_cble = "";


                in_producto_Bus Prod_b = new in_producto_Bus();
                var ProductoTerminado = Prod_b.Get_info_Product(param.IdEmpresa, Convert.ToDecimal(cmbTipo.EditValue));
                in_movi_inve_Info _in_movi_inven_I = new in_movi_inve_Info();
                _in_movi_inven_I.IdEmpresa = param.IdEmpresa;
                _in_movi_inven_I.IdSucursal = _Parametros.IdSucursal_IngxProduc;
                _in_movi_inven_I.IdBodega = _Parametros.IdBodega_IngxProduc;
                _in_movi_inven_I.cm_tipo = "+";
                _in_movi_inven_I.cm_observacion = txtObservacion.Text + " IdGestionPrdAceria #" + IdGestion;
                _in_movi_inven_I.cm_fecha = Convert.ToDateTime(Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString());
                _in_movi_inven_I.IdMovi_inven_tipo = _Parametros.IdMovi_inven_tipo_x_IngXProdAceriaProdTerm;
                in_movi_inve_detalle_Info Det_in_movi_inven = new in_movi_inve_detalle_Info();
                Det_in_movi_inven.dm_cantidad = Convert.ToDouble(txtPalanquilla.EditValue);
                Det_in_movi_inven.dm_observacion = _in_movi_inven_I.cm_observacion;
                Det_in_movi_inven.dm_precio = ProductoTerminado.pr_precio_publico;
                //Det_in_movi_inven.dm_stock_actu = ProductoTerminado.kr_stockActual + Det_in_movi_inven.dm_cantidad;
                //Det_in_movi_inven.dm_stock_ante = ProductoTerminado.kr_stockActual;
                Det_in_movi_inven.IdMovi_inven_tipo = _in_movi_inven_I.IdMovi_inven_tipo;
                Det_in_movi_inven.IdBodega = _in_movi_inven_I.IdBodega;
                Det_in_movi_inven.IdSucursal = _in_movi_inven_I.IdSucursal;
                Det_in_movi_inven.IdEmpresa = _in_movi_inven_I.IdEmpresa;
                Det_in_movi_inven.IdProducto = Convert.ToDecimal(cmbTipo.EditValue);
                Det_in_movi_inven.mv_tipo_movi = _in_movi_inven_I.cm_tipo;
                _in_movi_inven_I.listmovi_inve_detalle_Info.Add(Det_in_movi_inven);

                decimal IdMovimientoInventario = 0;
                string Mensaje = "";
                if (BusMOvi_B.GrabarDB(_in_movi_inven_I, ref IdMovimientoInventario,ref mensaje_cbte_cble, ref Mensaje) == false)
                {
                    MessageBox.Show(Mensaje, "Error Movimiento Inventario");
                }

                prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info InfoXMovi = new prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info();
                InfoXMovi.gp_IdEmpresa = param.IdEmpresa;
                InfoXMovi.gp_IdGestionAceria = IdGestion;
                InfoXMovi.gp_IdSucursal = _Info.IdSucursal;
                InfoXMovi.mv_IdMovi_inven_tipo = _in_movi_inven_I.IdMovi_inven_tipo;
                InfoXMovi.mv_IdBodega = _in_movi_inven_I.IdBodega;
                InfoXMovi.mv_IdSucursal = _in_movi_inven_I.IdSucursal;
                InfoXMovi.mv_IdEmpresa = param.IdEmpresa;
                InfoXMovi.mv_IdNumMovi = IdMovimientoInventario;
                BusInter.GuardarDB(InfoXMovi);

                #endregion
                #region MOvimientoChatarraNoProcesada  


                var ProductoChatarraNoProcesada = Prod_b.Get_info_Product(param.IdEmpresa, 822);
                _in_movi_inven_I.IdNumMovi = 0;
                _in_movi_inven_I.IdMovi_inven_tipo = 53;
                _in_movi_inven_I.IdSucursal = _Parametros.IdSucursal_IngxProduc;
                _in_movi_inven_I.IdBodega = _Parametros.IdBodega_IngxProduc;

                Det_in_movi_inven.IdMovi_inven_tipo = _in_movi_inven_I.IdMovi_inven_tipo;
                Det_in_movi_inven.dm_cantidad = Convert.ToDouble(txtMarrano.EditValue);
                Det_in_movi_inven.dm_precio = ProductoChatarraNoProcesada.pr_precio_publico;
                //Det_in_movi_inven.dm_stock_actu = ProductoChatarraNoProcesada.kr_stockActual + Det_in_movi_inven.dm_cantidad;
                //Det_in_movi_inven.dm_stock_ante = ProductoChatarraNoProcesada.kr_stockActual;
                Det_in_movi_inven.IdBodega = _in_movi_inven_I.IdBodega;
                Det_in_movi_inven.IdSucursal = _in_movi_inven_I.IdSucursal;
                Det_in_movi_inven.IdProducto = 822;
                if (BusMOvi_B.GrabarDB(_in_movi_inven_I, ref IdMovimientoInventario,ref mensaje_cbte_cble, ref Mensaje) == false)
                {
                    MessageBox.Show(Mensaje, "Error Movimiento Inventario");
                }

                InfoXMovi = new prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info();
                InfoXMovi.gp_IdEmpresa = param.IdEmpresa;
                InfoXMovi.gp_IdGestionAceria = IdGestion;
                InfoXMovi.gp_IdSucursal = _Info.IdSucursal;
                InfoXMovi.mv_IdMovi_inven_tipo = _in_movi_inven_I.IdMovi_inven_tipo;
                InfoXMovi.mv_IdBodega = _in_movi_inven_I.IdBodega;
                InfoXMovi.mv_IdSucursal = _in_movi_inven_I.IdSucursal;
                InfoXMovi.mv_IdEmpresa = param.IdEmpresa;
                InfoXMovi.mv_IdNumMovi = IdMovimientoInventario;
                BusInter.GuardarDB(InfoXMovi);

                #endregion
                #region MovimientoChatarraProcesada //OJO             //Ojo Valores Quemados


                var ProductoChatarraProcesada = Prod_b.Get_info_Product(param.IdEmpresa, 823);
                _in_movi_inven_I = new in_movi_inve_Info();
                _in_movi_inven_I.IdEmpresa = param.IdEmpresa;
                _in_movi_inven_I.IdSucursal = 2;
                _in_movi_inven_I.IdBodega = 1;
                _in_movi_inven_I.cm_tipo = "-";
                _in_movi_inven_I.cm_observacion = txtObservacion.Text + " IdGestionPrdAceria #" + IdGestion;
                _in_movi_inven_I.cm_fecha = Convert.ToDateTime(Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString());
                _in_movi_inven_I.IdMovi_inven_tipo = 54;
                Det_in_movi_inven = new in_movi_inve_detalle_Info();
                Det_in_movi_inven.dm_cantidad = Convert.ToDouble(txtPalanquilla.EditValue);
                Det_in_movi_inven.dm_observacion = _in_movi_inven_I.cm_observacion;
                Det_in_movi_inven.dm_precio = ProductoChatarraProcesada.pr_precio_publico;
                //Det_in_movi_inven.dm_stock_actu = ProductoChatarraProcesada.kr_stockActual - Det_in_movi_inven.dm_cantidad;
                //Det_in_movi_inven.dm_stock_ante = ProductoChatarraProcesada.kr_stockActual;
                Det_in_movi_inven.IdMovi_inven_tipo = _in_movi_inven_I.IdMovi_inven_tipo;
                Det_in_movi_inven.IdBodega = _in_movi_inven_I.IdBodega;
                Det_in_movi_inven.IdSucursal = _in_movi_inven_I.IdSucursal;
                Det_in_movi_inven.IdEmpresa = _in_movi_inven_I.IdEmpresa;
                Det_in_movi_inven.IdProducto = Convert.ToDecimal(cmbTipo.EditValue);
                Det_in_movi_inven.mv_tipo_movi = _in_movi_inven_I.cm_tipo;
                _in_movi_inven_I.listmovi_inve_detalle_Info.Add(Det_in_movi_inven);


                if (BusMOvi_B.GrabarDB(_in_movi_inven_I, ref IdMovimientoInventario,ref mensaje_cbte_cble, ref Mensaje) == false)
                {
                    MessageBox.Show(Mensaje, "Error Movimiento Inventario " + Mensaje );
                }

                InfoXMovi = new prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info();
                InfoXMovi.gp_IdEmpresa = param.IdEmpresa;
                InfoXMovi.gp_IdGestionAceria = IdGestion;
                InfoXMovi.gp_IdSucursal = _Info.IdSucursal;
                InfoXMovi.mv_IdMovi_inven_tipo = _in_movi_inven_I.IdMovi_inven_tipo;
                InfoXMovi.mv_IdBodega = _in_movi_inven_I.IdBodega;
                InfoXMovi.mv_IdSucursal = _in_movi_inven_I.IdSucursal;
                InfoXMovi.mv_IdEmpresa = param.IdEmpresa;
                InfoXMovi.mv_IdNumMovi = IdMovimientoInventario;
                BusInter.GuardarDB(InfoXMovi);

                #endregion
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtChatarraHorno_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTiempoEncendido.Text = txtTiempoEncendido.Text;
                txtTiempoApagado.Text = txtTiempoApagado.Text;
                txtTiempoFundicion.Text = txtTiempoFundicion.Text;
                txtTiempoVaciado.Text = txtTiempoVaciado.Text;
                txtTiempoTotal.Text = txtTiempoTotal.Text;
                txtIncioCC.Text = txtIncioCC.Text;
                txtFinCC.Text = txtFinCC.Text;
                CalcularTotal();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
      
      

    }
}
