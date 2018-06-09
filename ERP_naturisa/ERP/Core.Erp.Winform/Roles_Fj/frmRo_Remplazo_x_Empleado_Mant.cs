using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Reportes.Roles;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Remplazo_x_Empleado_Mant : Form
    {
        #region variable
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<ro_Catalogo_Info> lista_licencia_para_permisos = new List<ro_Catalogo_Info>();
        List<ro_Catalogo_Info> lista_tipo_remplazo = new List<ro_Catalogo_Info>();
        ro_Remplazo_x_emplado_Info info = new ro_Remplazo_x_emplado_Info();
        ro_Catalogo_Bus catBus = new ro_Catalogo_Bus();
        List<ro_Empleado_Info> lista_empleado = new List<ro_Empleado_Info>();
        ro_Empleado_Bus empBus = new ro_Empleado_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Remplazo_x_emplado_Bus bus_remplazo = new ro_Remplazo_x_emplado_Bus();
        List<ro_Remplazo_x_emplado_Info> listado_historico_remplazo = new List<ro_Remplazo_x_emplado_Info>();
        List<ro_rubro_tipo_Info> lista_rubros = new List<ro_rubro_tipo_Info>();
        ro_rubro_tipo_Bus bus_rubro = new ro_rubro_tipo_Bus();


        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_perido = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        decimal IdPersona = 0;
     #endregion

        public frmRo_Remplazo_x_Empleado_Mant()
        {
            InitializeComponent();
        }

        public void Cargar_datos()
        {
            try
            {

                //LLENA EL COMBO TIPO DE LICENCIA
                lista_licencia_para_permisos.AddRange(catBus.Get_List_Catalogo_x_Tipo(23));
                cmb_motivo_ausencia.Properties.ValueMember = "IdCatalogo";
                cmb_motivo_ausencia.Properties.DisplayMember = "ca_descripcion";
                cmb_motivo_ausencia.Properties.DataSource = lista_licencia_para_permisos;



                lista_tipo_remplazo.AddRange(catBus.Get_List_Catalogo_x_Tipo(36));
                cmb_tipo_remplazo.Properties.ValueMember = "IdCatalogo";
                cmb_tipo_remplazo.Properties.DisplayMember = "ca_descripcion";
                cmb_tipo_remplazo.Properties.DataSource = lista_tipo_remplazo;


                lista_empleado = empBus.Get_List_Empleado_(param.IdEmpresa);
                cmbEmpleado.Properties.DataSource = lista_empleado;




                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;


                // cargar rubros

                lista_rubros = bus_rubro.Get_list_rubros_concepto(param.IdEmpresa);
                cmb_rubros.Properties.DataSource=lista_rubros;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public Cl_Enumeradores.eTipo_action Accion { get; set; } 

        private void Get()
        {
            try
            {
                info.IdEmpresa = param.IdEmpresa;
                info.IdPersona = IdPersona;
                info.IdEmpleado =Convert.ToInt32( cmbEmpleado.EditValue);
                info.IdEmpleado_Remplazo =Convert.ToInt32( cmb_empleado_remplazante.EditValue);
                info.Observacion = txtopbsrvacion.Text;
                info.Fecha_Salida =Convert.ToDateTime( dtFechaSalida.EditValue);
                info.Fecha_Entrada = Convert.ToDateTime( dtFechaEntrada.EditValue);
                if (time_desde.Visible == true)
                {
                  //  info.Hora_salida = TxtHoraS.Text;
                }

                if (timeHasta.Visible == true)
                {
                    //  info.Hora_salida = TxtHoraS.Text;
                }
                info.Id_Motivo_Ausencia_Cat = Convert.ToInt32(cmb_motivo_ausencia.EditValue);
                info.Id_Tipo_tipo_Remplazo_Cat = Convert.ToInt32(cmb_tipo_remplazo.EditValue);
                if (txtIdRemplazo.EditValue != null)
                {
                    info.Id_remplazo = Convert.ToInt32(txtIdRemplazo.EditValue);
                }
                info.Fecha = Convert.ToDateTime( dtp_fecha.EditValue);

                if (rb_si.Checked == true)
                {
                    info.IdRubro = cmb_rubros.EditValue.ToString();
                    info.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                    info.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                    info.IdNomina_TipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                    info.Valor_descuento_empleado = Convert.ToDouble(txt_valor_descuento.EditValue);
                    info.Fecha_descuenta_rol = info_perido.pe_FechaIni;
                    info.Descuenta_rol = rb_si.Checked;
                }
                else
                {
                    info.Descuenta_rol=rb_si.Checked;
                }
                info.valor_x_dia_remplazo =Convert.ToDouble( txt_valor_x_dia.EditValue);
                info.Total_pagar_remplazo = Convert.ToDouble(txt_total_a_pagar.EditValue);
                info.IdUsuario = param.IdUsuario;
            }
            catch (Exception ex)
            {
                
              MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public void Set(ro_Remplazo_x_emplado_Info remplazo_info)
        {
            try
            {

                info = remplazo_info;
                cmbEmpleado.EditValue = remplazo_info.IdEmpleado;
                cmb_empleado_remplazante.EditValue = remplazo_info.IdEmpleado_Remplazo;
                cmb_tipo_remplazo.EditValue = remplazo_info.Id_Tipo_tipo_Remplazo_Cat;
                cmb_motivo_ausencia.EditValue = remplazo_info.Id_Motivo_Ausencia_Cat;
                txtopbsrvacion.Text = remplazo_info.Observacion;
                dtp_fecha.EditValue = remplazo_info.Fecha;
                dtFechaSalida.EditValue = remplazo_info.Fecha_Salida;
                dtFechaEntrada.EditValue = remplazo_info.Fecha_Entrada;
                txtIdRemplazo.EditValue = remplazo_info.Id_remplazo;

                if (remplazo_info.Descuenta_rol == true)
                {
                    rb_si.Checked = true;
                    cmbnomina.EditValue = remplazo_info.IdNomina_Tipo;
                    cmbnominaTipo.EditValue = remplazo_info.IdNomina_TipoLiqui;
                    cmbPeriodos.EditValue = remplazo_info.IdPeriodo;
                    cmb_rubros.EditValue = remplazo_info.IdRubro;
                }
                else
                {
                    tb_no.Checked = true;
                }
              //  Ocultar_controles(remplazo_info.Descuenta_rol);
                if (remplazo_info.Descuenta_rol == true)
                {
                    cmb_rubros.EditValue = remplazo_info.IdRubro;
//                    dtp_fecha_descuento_rol.EditValue = remplazo_info.Fecha_descuenta_rol;
                    txt_valor_descuento.EditValue = remplazo_info.Valor_descuento_empleado;
                }

                txt_valor_x_dia.EditValue= remplazo_info.valor_x_dia_remplazo;
                txt_total_a_pagar.EditValue=remplazo_info.Total_pagar_remplazo;





                // cosbultar el historico de remplazo

                listado_historico_remplazo = bus_remplazo.listado_remplazo_Historico(remplazo_info.IdEmpresa,remplazo_info.IdEmpleado);
                gridControl_remplazo_x_empleado.DataSource = listado_historico_remplazo;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public bool Guardar()
        {
            try
            {
                decimal idnoveda = 0;

                int Id_Remplazo=0;
                Get();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (bus_remplazo.Guardar_DB(info,ref Id_Remplazo, ref idnoveda))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente),param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Information);
                            if (rb_si.Checked)
                                Imprimir(Convert.ToInt32( info.IdEmpleado),Convert.ToInt32( idnoveda));
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos),param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Information);

                        }
                        return true;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (bus_remplazo.Modificar_DB(info))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente),param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos),param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Information);

                        }
                        return true;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        if (bus_remplazo.Anular_DB(info))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Anulada_corectamente),param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos),param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Information);

                        }
                        return true;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        return true;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        return true;
                    default:
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
        public void Bloquear_Objetos()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
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

        private void frmRo_Remplazo_x_Empleado_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        dtp_fecha.EditValue = DateTime.Now;
                        //dtp_fecha_descuento_rol.EditValue = DateTime.Now;
                        dtFechaEntrada.EditValue = DateTime.Now;
                        dtFechaSalida.EditValue = DateTime.Now;
                        rb_si.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.btnGuardar_y_Salir.Visible = false;
                        ucGe_Menu.btnGuardar.Visible = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
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

        private void cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_empleado_remplazante.Properties.DataSource = lista_empleado.Where(v=>v.IdEmpleado!=Convert.ToInt32(cmbEmpleado.EditValue)).ToList();
                ro_Empleado_Info info_em = new ro_Empleado_Info();
                info_em = (ro_Empleado_Info)cmbEmpleado.Properties.View.GetFocusedRow();
                if (info_em == null)
                {
                    info_em = lista_empleado.Where(v => v.IdEmpleado == Convert.ToInt32(cmbEmpleado.EditValue)).FirstOrDefault();
                }
                txtCargo.Text = info_em.cargo;
                txtDepartamento.Text = info_em.de_descripcion;

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
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
                if (Validar())
                {
                    Guardar();
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
                if (Validar())
                {
                    if (Guardar())
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Registro...?", "Anulación de Remplazo por empleado  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        info.IdUsuarioUltAnu= param.IdUsuario;
                        info.Fecha_UltAnu = DateTime.Now;
                        info.MotiAnula = ofrm.motivoAnulacion;
                    }

                    if (Guardar())
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public bool Validar()
        {
            bool ba_si_valida = true;
            try
            {


                if (txt_total_a_pagar.EditValue == null || txt_total_a_pagar.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " valor total", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ba_si_valida = false;
                }



                if (txt_valor_x_dia.EditValue == null || txt_valor_x_dia.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " valor por día", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ba_si_valida = false;
                }

                
                
                
                
                if (cmb_empleado_remplazante.EditValue == null || cmb_empleado_remplazante.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " El Empleado remplazante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ba_si_valida = false;
                }


                if (cmbEmpleado.EditValue == null || cmbEmpleado.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " un empleado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ba_si_valida = false;
                }


                if (cmb_motivo_ausencia.EditValue == null || cmb_motivo_ausencia.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " motivo de ausencia", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ba_si_valida = false;
                }


                if (cmb_tipo_remplazo.EditValue == null || cmb_tipo_remplazo.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + "  tipo de remplazo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ba_si_valida = false;
                }



                if (txtopbsrvacion.Text == null || txtopbsrvacion.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + "  observacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ba_si_valida = false;
                }


                if (dtp_fecha.EditValue == null || dtp_fecha.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + "  fecha", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ba_si_valida = false;
                }




                if (dtFechaEntrada.EditValue == null || dtFechaEntrada.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + "  fecha de ingreso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ba_si_valida = false;
                }

                if (dtFechaSalida.EditValue == null || dtFechaSalida.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + "  fecha de inicio ausencia", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ba_si_valida = false;
                }


                if (rb_si.Checked == true)
                {
                    if (cmb_rubros.EditValue == null || cmb_rubros.EditValue == "")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el ) + "  concepto para el descuento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        ba_si_valida = false;
                    }

                    if (cmbnomina.EditValue == null || cmbnomina.EditValue == "")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + "  Nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        ba_si_valida = false;
                    }


                    if (cmbnominaTipo.EditValue == null || cmbnominaTipo.EditValue == "")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + "  proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        ba_si_valida = false;
                    }

                    if (cmbPeriodos.EditValue == null || cmbPeriodos.EditValue == "")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + "  periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        ba_si_valida = false;
                    }

                }

                return ba_si_valida;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

     

        public void Ocultar_controles( bool valor)
        {
            try
            {
                if (valor)
                {
                    cmb_rubros.Visible = true;
                    lb_rubro.Visible = true;
                    
                    txt_valor_descuento.Visible = true;
                    lb_valor_descuento.Visible = true;


                    lb_nomina.Visible = true;
                    lb_proceso.Visible = true;
                    lb_periodo.Visible = true;
                    cmbnomina.Visible = true;
                    cmbnominaTipo.Visible = true;
                    cmbPeriodos.Visible = true;
                }
                else
                {
                    cmb_rubros.Visible = false;
                    lb_rubro.Visible = false;
                    lb_nomina.Visible = false;
                    lb_proceso.Visible = false;
                    lb_periodo.Visible = false;
                    cmbnomina.Visible = false;
                    cmbnominaTipo.Visible = false;
                    cmbPeriodos.Visible = false;
                    txt_valor_descuento.Visible = false;
                    lb_valor_descuento.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void rb_si_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb_si.Checked == true)
                {
                    Ocultar_controles(true);
                }

                else
                {
                    Ocultar_controles(false);
                }
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void tb_no_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_no.Checked == true)
                {
                    Ocultar_controles(false);
                }

                else
                {
                    Ocultar_controles(true);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void dtFechaSalida_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtFechaEntrada.EditValue != null && dtFechaSalida.EditValue != null)
                {

                    if (Convert.ToDateTime(Convert.ToDateTime(dtFechaEntrada.EditValue).ToShortDateString()) < Convert.ToDateTime(Convert.ToDateTime(dtFechaSalida.EditValue).ToShortDateString()))
                    {
                        MessageBox.Show("La fecha final debe ser mayor o igual fecha inicial", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                } 
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void dtFechaEntrada_EditValueChanged(object sender, EventArgs e)
        {
            if (dtFechaEntrada.EditValue != null && dtFechaSalida.EditValue != null)
            {
                if (Convert.ToDateTime(Convert.ToDateTime(dtFechaEntrada.EditValue).ToShortDateString()) < Convert.ToDateTime(Convert.ToDateTime(dtFechaSalida.EditValue).ToShortDateString()))
                {
                    MessageBox.Show("La fecha final debe ser mayor o igual fecha inicial", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }


        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
           
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_perido = (ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txt_total_a_pagar_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_valor_descuento.EditValue = txt_total_a_pagar.EditValue;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Limpiar()
        {
            try
            {
                cmbEmpleado.EditValue = null;
                cmb_empleado_remplazante.EditValue = null;
                cmb_rubros.EditValue = null;
                cmb_motivo_ausencia.EditValue = null;
                cmbnomina.EditValue = null;
                cmbnominaTipo.EditValue = null;
                cmbPeriodos.EditValue = null;
                txtopbsrvacion.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Imprimir(int IdEmpleado, int IdNonvedad)
        {
            try
            {
                XROL_Rpt023_Rpt Reporte = new XROL_Rpt023_Rpt();

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdEmpleado"].Value = IdEmpleado;
                Reporte.Parameters["IdNovedad"].Value = IdNonvedad;

                Reporte.ShowPreview();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_tipo_remplazo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_empleado_remplazante_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                ro_Empleado_Info info=new ro_Empleado_Info();
                info=(ro_Empleado_Info)cmb_empleado_remplazante.Properties.View.GetFocusedRow();
                if (info == null)
                    info = lista_empleado.Where(v => v.IdEmpleado ==Convert.ToDecimal( cmb_empleado_remplazante.EditValue)).FirstOrDefault();
                txtopbsrvacion.Text = "PAGO REMPLAZO DE :" + cmbEmpleado.Text + " POR " + cmb_empleado_remplazante.Text;
                IdPersona = info.InfoPersona.IdPersona;
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
    }
}
