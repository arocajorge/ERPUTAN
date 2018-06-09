
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Recursos.Properties;
using DevExpress.XtraEditors.Controls;
using Core.Erp.Reportes.Roles;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Empleado_Novedad_Mant : Form
    {
        double NumHoras = 0;
        double valoHora = 0;
        double Sueldo = 0;
        #region Declaracion Variable
        ro_HistoricoSueldo_Bus BusSueldo = new ro_HistoricoSueldo_Bus();
        ro_rubro_tipo_Info Rubro_Info = new ro_rubro_tipo_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();
        ro_Nomina_Tipo_Bus Bus_TipoNo = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus Bus_TipoL = new ro_Nomina_Tipoliqui_Bus();
        ro_Empleado_Novedad_Det_Bus OEmpDetalle = new ro_Empleado_Novedad_Det_Bus();
        ro_Empleado_Novedad_Bus OEmpDCabecera = new ro_Empleado_Novedad_Bus();      
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_rubro_tipo_Info> DataRubro;
        ro_rubro_tipo_Bus OCBUS2 = new ro_rubro_tipo_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;       
        public ro_Empleado_Novedad_Info InfoCabNove = new ro_Empleado_Novedad_Info();
        //public ro_Ing_Egre_x_Empleado_Info InfoCabNoveIngEgre = new ro_Ing_Egre_x_Empleado_Info();
        public ro_Empleado_Novedad_Det_Info InfoDetNove = new ro_Empleado_Novedad_Det_Info();       
        double Total = 0;
        string mensaje = "";      
        public delegate void delegate_frmRo_Empleado_Novedad_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Empleado_Novedad_Mant_FormClosing Event_frmRo_Empleado_Novedad_Mant_FormClosing;
        List<ro_Empleado_Novedad_Det_Info> empNove = new List<ro_Empleado_Novedad_Det_Info>();
        ro_Catalogo_Bus BusPrestamo_Pago = new ro_Catalogo_Bus();
        //BindingList<ro_Empleado_Novedad_Det_Info> DataSourcce;
        BindingList<ro_Empleado_Novedad_Det_Info> Obj_DNovedad = new BindingList<ro_Empleado_Novedad_Det_Info>();
        List<ro_Empleado_Info> lista_empleados = new List<ro_Empleado_Info>();

        ro_Empleado_Info InfoEmpleado = new ro_Empleado_Info();


        int _idNominaTipo = 0;
        int _idNominaTipoLiqui = 0;
        int _idPeriodo = 0;


        //INFO
        ro_periodo_x_ro_Nomina_TipoLiqui_Info oRo_PeriodoInfo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();


        //BUS
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();



        #endregion

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
               _Accion = iAccion; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public frmRo_Empleado_Novedad_Mant()
        {
            try
            {
             InitializeComponent();
             pu_CargaInicial();
             ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
             ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
             ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
             Event_frmRo_Empleado_Novedad_Mant_FormClosing+=frmRo_Empleado_Novedad_Mant_Event_frmRo_Empleado_Novedad_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (pu_Grabar() == false)
                { return; }
                this.Close();
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
                if (pu_Grabar() == false)
                {
         //           MessageBox.Show("No se guardó la información");
                    MessageBox.Show("El registro no se pudo guardar, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        private void frmRo_Empleado_Novedad_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Event_frmRo_Empleado_Novedad_Mant_FormClosing += new delegate_frmRo_Empleado_Novedad_Mant_FormClosing(frmRo_Empleado_Novedad_Mant_Event_frmRo_Empleado_Novedad_Mant_FormClosing);

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntReImprimir = false;


                        RubroId.OptionsColumn.AllowEdit = true;
                        colFechaPago.OptionsColumn.AllowEdit = true;
                        Valor.OptionsColumn.AllowEdit = true;
                        Observacion.OptionsColumn.AllowEdit = true;
                        colru_tipo.OptionsColumn.AllowEdit = true;
                        colEstadoCobro.OptionsColumn.AllowEdit = false;
                        colEstado.OptionsColumn.AllowEdit = false;

                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        groupControlMotivoModificacion.Visible = true;
                        groupControlMotivoModificacion.Enabled = true;
                      
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;

                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntReImprimir = false;
                        //BloquearControles();     

                        this.cmbTipoNomina.Enabled = false;
                        this.cmbTipoNomina.BackColor = System.Drawing.Color.White;
                        this.cmbTipoNomina.ForeColor = System.Drawing.Color.Black;

                        this.cmbTipoLiq.Enabled = false;
                        this.cmbTipoLiq.BackColor = System.Drawing.Color.White;
                        this.cmbTipoLiq.ForeColor = System.Drawing.Color.Black;

                        this.cmbEmpleados.Enabled = false;
                        this.cmbEmpleados.BackColor = System.Drawing.Color.White;
                        this.cmbEmpleados.ForeColor = System.Drawing.Color.Black;

                        this.txtNovedad.ReadOnly = true;
                        this.txtNovedad.BackColor = System.Drawing.Color.White;

                        this.textTotal.ReadOnly = true;
                        this.textTotal.BackColor = System.Drawing.Color.White;


                        this.dtpFecha.Enabled = false;

                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntReImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                      

                        this.cmbTipoNomina.Enabled = false;
                        this.cmbTipoNomina.BackColor = System.Drawing.Color.White;
                        this.cmbTipoNomina.ForeColor = System.Drawing.Color.Black;

                        this.cmbTipoLiq.Enabled = false;
                        this.cmbTipoLiq.BackColor = System.Drawing.Color.White;
                        this.cmbTipoLiq.ForeColor = System.Drawing.Color.Black;

                        this.cmbEmpleados.Enabled = false;
                        this.cmbEmpleados.BackColor = System.Drawing.Color.White;
                        this.cmbEmpleados.ForeColor = System.Drawing.Color.Black;

                        this.txtNovedad.ReadOnly = true;
                        this.txtNovedad.BackColor = System.Drawing.Color.White;

                        this.textTotal.ReadOnly = true;
                        this.textTotal.BackColor = System.Drawing.Color.White;


                        this.dtpFecha.Enabled = false;

                        this.gridView.OptionsBehavior.Editable = false;
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

        void frmRo_Empleado_Novedad_Mant_Event_frmRo_Empleado_Novedad_Mant_FormClosing(object sender, FormClosingEventArgs e){}

        public void BloquearControles()
        {
            try
            {
                cmbTipoNomina.Enabled = false;
                cmbEmpleados.Enabled = false;
                cmbTipoLiq.Enabled = false;
                dtpFecha.Enabled = false;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
         
        }

        Boolean flag = true; // en el caso de llamarlo de la pantalla de liquidacion de rol no limpia los combos

        public void setCab(ro_Empleado_Novedad_Info cab)
        {
            try
            {
                InfoCabNove = cab;
                flag = false;               
                cmbTipoNomina.EditValue = cab.IdNomina_Tipo;
                cmbTipoLiq.EditValue = cab.IdNomina_TipoLiqui;
                cmbEmpleados.EditValue = cab.IdEmpleado;
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar || Cl_Enumeradores.eTipo_action.consultar == _Accion)
                {
                    dtpFecha.Value = cab.Fecha;
                }
                else
                {
                    dtpFecha.Value = DateTime.Now;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }

        void pu_CargaInicial()
        {
            try
            {
                // Cargando combo de Empleado
                lista_empleados = BusEmpleado.Get_List_Empleado_(param.IdEmpresa);
                cmbEmpleados.Properties.DataSource = lista_empleados;

                // Cargando Combo de Tipo de Nomina
                List<ro_Nomina_Tipo_Info> InfoTipoNomina = new List<ro_Nomina_Tipo_Info>();
                InfoTipoNomina = Bus_TipoNo.Get_List_Nomina_Tipo(param.IdEmpresa);
                this.cmbTipoNomina.Properties.DataSource = InfoTipoNomina;

                // Cargando rubros       //OBTIENE UNICAMENTE RUBROS DE TIPO CONCEPTO
                //DataRubro = OCBUS2.ConsultaGeneral();
                DataRubro = (from a in OCBUS2.Get_List_Formulas(param.IdEmpresa)
                             where a.rub_concep == true || a.IdRubro == "976"
                                select a).ToList();


                // cmbRubro.DataSource = DataRubro;
                repositoryItemGridLookUpEdit_Rubro.DataSource = DataRubro;

                //Carga Datos Estado Rubro
                List<ro_Catalogo_Info> lstEstado = new List<ro_Catalogo_Info>();
                lstEstado = BusPrestamo_Pago.Get_List_CatalogoEstadoCobro();
                repositoryItemGridLookUpEdit1.DataSource = lstEstado;

                //Carga Datos Detalle
                ro_Empleado_Novedad_Det_Bus Bus_DNovedad = new ro_Empleado_Novedad_Det_Bus();
                //Obj_DNovedad = new BindingList<ro_Empleado_Novedad_Det_Info>(Bus_DNovedad.Get_List_Empleado_Novedad_Det(param.IdEmpresa, InfoCabNove.IdEmpleado, InfoCabNove.IdNovedad, InfoCabNove.Secuencia));

                foreach (var item in Obj_DNovedad)
                {
                    item.Valor = Math.Abs(item.Valor);
                }
                grdLista.DataSource = Obj_DNovedad;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
                                                                  
        }

       

        public Boolean pu_Grabar()
        {
            try
            {
                string msg = "";
                int focus = gridView.FocusedRowHandle;
                gridView.FocusedRowHandle = focus + 1;
                bool bandera_si_grabo = false;
                //Controlando Datos
                if (control_Datos_Cabecera() == false)
                {
                    return false;
                }

                if (control_Datos_Detalle() == false)
                {
                    return false;
                }

                if (Calculo_Total() == false)
                {
                    return false;
                }

                get_Cabecera();
                if (!get_Detalle())
                {
                    MessageBox.Show("no se Puede modificar un registro cancelado, VZEN", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return  false;
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    decimal idNovedad = 0;
                    if (OEmpDCabecera.GrabarDB(InfoCabNove, ref idNovedad, ref msg))
                    {
                        foreach (var item in InfoCabNove.LstDetalle)
                        {
                            item.IdNovedad = idNovedad;
                          bandera_si_grabo=  OEmpDetalle.GrabarDB(item, ref msg);
                            
                        }
                        if (bandera_si_grabo)
                        {
                            MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (MessageBox.Show("¿Desea imprimir el reporte de la novedad?.", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Imprimir(Convert.ToInt32( InfoCabNove.IdEmpleado),Convert.ToInt32( idNovedad));
                            }
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }      
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    string ms = "";
                    decimal idNovedad = 0;
                    Calculo_Total();
                   

                    if (OEmpDCabecera.ModificarDB(InfoCabNove, ref ms, idNovedad))
                    {
                        foreach (var item in InfoCabNove.LstDetalle)
                        {
                            item.IdNovedad = Convert.ToDecimal(txtNovedad.Text);
                          bandera_si_grabo=  OEmpDetalle.ModificarDB(item, ref msg);

                        }
                        if (bandera_si_grabo)
                        {
                            MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (MessageBox.Show("¿Desea imprimir el reporte de la novedad?.", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Imprimir(Convert.ToInt32(InfoCabNove.IdEmpleado), Convert.ToInt32(InfoCabNove.IdNovedad));
                            }
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Problemas al actualizar la novedad","ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }


                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {


                    if (MessageBox.Show("¿Está seguro que desea anular dicho rubro?.", "Anulación de rubro por empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                        frm.ShowDialog();
                        InfoCabNove.MotiAnula = frm.motivoAnulacion;
                        InfoCabNove.IdUsuarioUltAnu = param.IdUsuario;
                        InfoCabNove.Fecha_UltAnu = DateTime.Now;

                        if (OEmpDCabecera.AnularDB(InfoCabNove))
                        {
                           

                       
                        foreach (var item in InfoCabNove.LstDetalle)
                        {
                            if (OEmpDetalle.AnularDB(item))
                            {
                                


                                MessageBox.Show(Resources.msgConfirmaAnulacionOk + " - Rubro: " + InfoCabNove.RubroDescp, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();

                            }

                            else
                                MessageBox.Show("Imposibe anular el item", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            
                        }
                        }
                            
                    }

                }
                
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
            
        }

        public Boolean Calculo_Total()
        {
            try
            {
                foreach (var item in Obj_DNovedad)
                {
                    var Item = DataRubro.First(v => v.IdRubro == item.IdRubro);

                    //if (Item.ru_tipo == "E")
                    //    InfoDetNove.Valor = item.Valor * -1;
                    //else
                    //    InfoDetNove.Valor = item.Valor;

                    InfoDetNove.Valor = item.Valor;

                    Total = Total + InfoDetNove.Valor;
                }

                if (Total == 0)
                {
                    MessageBox.Show("El valor total no puede ser 0 por favor ingrese datos.. ","ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
        
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
            

        }

        public Boolean control_Datos_Cabecera()
        {
            //Cambio
            int a = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int b = Convert.ToInt32(dtpFecha.Value.ToString("yyyy"));            
            //int c = a - 1;
            //

            try
            {
                 if (cmbEmpleados.EditValue == null)
                    {
                        MessageBox.Show("El Empleado es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
             
                    if (cmbTipoNomina.EditValue == null)
                    {
                        MessageBox.Show("El tipo de nómina es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }

                    if (cmbTipoLiq.EditValue == null)
                    {
                        MessageBox.Show("El tipo de liquidación  es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }                   
                    
                           
                    //if (b<a) 
                    //{
                    //    MessageBox.Show("La fecha de registro es menor al año actual, por favor ingrese una fecha igual o mayor al año actual...", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    return false;
                    //}
                

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
           
            }
        
        public Boolean control_Datos_Detalle()
        {
            try 
	        {
                int cuenta = 0;
                int i = 1;
                int focus = gridView.FocusedRowHandle;                
                gridView.FocusedRowHandle = focus + 1;
                //nuevo
                //rows.count

                ro_Empleado_Novedad_Det_Bus Bus_dnovedad = new ro_Empleado_Novedad_Det_Bus();

                foreach (var item in Obj_DNovedad)
                    { 
                        ro_Empleado_Novedad_Det_Info Info_NovDetalle = new ro_Empleado_Novedad_Det_Info();

                        if (item.IdRubro == null)
                        {
                            MessageBox.Show("El Rubro es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                            return false;
                        }

                        if (item.FechaPago == null)
                        {
                            MessageBox.Show("La Fecha de Pago es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                        }
                    //-----------------------------------------------------------------------
                        //if (item.FechaPago.Month != dtpFecha.Value.Month || item.FechaPago.Year != dtpFecha.Value.Year)
                        //{
                        //    //if (B == 1) {

                        //    //}
                        //    //else
                        //    //{
                        //    MessageBox.Show("El mes del pago en el registro" + " " + i + " " + " debe ser igual al del registro.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //        return false;
                        //    //}
                        //}
                      //-----------------------------------------------------------------------
                        if (item.FechaPago == Convert.ToDateTime("01-01-0001") || item.FechaPago == Convert.ToDateTime("01-01-0001"))
                        {
                            MessageBox.Show("La fecha de pago tiene un formato no válido.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                        }

                        i++;

                    //Cambio
                        //if (Convert.ToDateTime(item.FechaPago.ToShortDateString()) < Convert.ToDateTime(dtpFecha.Value.ToShortDateString()))
                        //{
                        //    MessageBox.Show("La Fecha Pago es menor a la Fecha del Registro en el:" + " " + "\nRegistro" + " " + i + ".", "Favor Ingrese una Fecha Igual o Mayor al Registro");
                        //    return false;
                        //}

                        //int g = Convert.ToInt32(DateTime.Now.Month.ToString("d2"));
                        //int f = Convert.ToInt32(item.FechaPago.Month.ToString("d2"));

                        //if(g < f || g > f){
                        //    MessageBox.Show("La Fecha Pago es menor a la Fecha del Registro en el:" + " " + "\nRegistro" + " " + i + ".", "Favor Ingrese una Fecha en la cual los dias"+"\nesten en el rango del mes actual");
                        //    return false;
                        //}
                    //                    

                        if (item.Valor == null)
                        {
                            MessageBox.Show("El Valor del Rubro es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                        }

                        if (item.Valor <= 0)
                        {
                            MessageBox.Show("El Valor debe ser mayor a 0, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                        }

                        /*if (item.Observacion == null)
                        {
                            MessageBox.Show("La Observación sin datos..", "Favor ingrese datos");
                            return false;
                        }*/

                        cuenta++;
                    }
                /*}
                else
                {
                    MessageBox.Show("Ingrese el los Rubros");
                    return false;
                }*/
                if (cuenta <= 0)
                {
                    MessageBox.Show("Los rubros de la novedad son obligatorios, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        public void get_Cabecera()
        {
            try
            {
                string msg = "";
                int cuenta = 0;
                decimal idNovedad = 0;

                InfoCabNove.IdEmpresa = param.IdEmpresa;
                InfoCabNove.Fecha = dtpFecha.Value;
                InfoCabNove.TotalValor=Total;
                InfoCabNove.IdNomina_Tipo = Convert.ToInt32(cmbTipoNomina.EditValue == null ? 0 : cmbTipoNomina.EditValue);
                InfoCabNove.IdNomina_TipoLiqui = Convert.ToInt32(cmbTipoLiq.EditValue == null ? 0 : cmbTipoLiq.EditValue);
                InfoCabNove.IdEmpleado = Convert.ToDecimal(cmbEmpleados.EditValue);
                InfoCabNove.IdUsuario = param.IdUsuario;
                InfoCabNove.Fecha_Transac = DateTime.Now;
                InfoCabNove.ip = param.ip;
                InfoCabNove.nom_pc = param.nom_pc;
                this.CheckEstado.Checked = (InfoCabNove.Estado == "A") ? true : false;
                if (InfoCabNove.MotivoModifica != "")
                {
                    TxtMotivoModifica.Text = InfoCabNove.MotivoModifica;
                    groupControlMotivoModificacion.Visible=true;
                }                                          
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

     
        public bool get_Detalle()
        {
            try
            {
                bool bandera_SiEsta_Cancelada = true;
                InfoCabNove.LstDetalle = new List<ro_Empleado_Novedad_Det_Info>();
                int c = 1;

                if (Obj_DNovedad.Where(v => v.EstadoCobro == "CAN").Count() > 0)
                {
                    bandera_SiEsta_Cancelada = false;
                }
                else
                {
                    foreach (var item in Obj_DNovedad)
                    {
                        InfoDetNove = new ro_Empleado_Novedad_Det_Info();
                        if (Cl_Enumeradores.eTipo_action.grabar == _Accion)
                        {

                            InfoDetNove.Secuencia = c;
                            c++;
                        }
                        else
                        {

                            InfoDetNove.Secuencia = item.Secuencia;
                        }
                        InfoDetNove.IdEmpresa = param.IdEmpresa;
                        InfoDetNove.IdNovedad = InfoCabNove.IdNovedad;
                        InfoDetNove.IdEmpleado = InfoCabNove.IdEmpleado;
                        InfoDetNove.IdNomina = InfoCabNove.IdNomina_Tipo;
                        InfoDetNove.IdNominaLiqui = InfoCabNove.IdNomina_TipoLiqui;
                        InfoDetNove.FechaPago = item.FechaPago.Date;
                        this.CheckEstado.Checked = (InfoDetNove.Estado == "A") ? true : false;
                        var Item = DataRubro.First(v => v.IdRubro == item.IdRubro);
                        InfoDetNove.Valor = item.Valor;
                        InfoDetNove.EstadoCobro = item.EstadoCobro;
                        InfoDetNove.EstadoCobro = "PEN";
                        InfoDetNove.Estado = "A";
                        InfoDetNove.Estado = item.Estado;
                        InfoDetNove.NumHoras = item.NumHoras;
                        InfoDetNove.Observacion = item.Observacion;
                        InfoDetNove.IdRol = (Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(cmbTipoNomina.EditValue));
                        InfoDetNove.IdRubro = item.IdRubro;
                        InfoCabNove.LstDetalle.Add(InfoDetNove);

                    }
                    bandera_SiEsta_Cancelada = true;
                }

                return bandera_SiEsta_Cancelada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
            
        }

        public void set_Info(ro_Empleado_Novedad_Info info)
        {
            
            try
            {
                InfoCabNove = info;
                txtNovedad.Text = info.IdNovedad.ToString();
                textTotal.Text = (info.TotalValor == null ? 0 : info.TotalValor).ToString();
                cmbTipoNomina.EditValue = info.IdNomina_Tipo;
                cmbTipoLiq.EditValue = info.IdNomina_TipoLiqui;
                cmbEmpleados.EditValue = info.IdEmpleado;
                dtpFecha.Value = info.Fecha;
                //Detalle
                empNove=Consulta_Detalle(param.IdEmpresa,Convert.ToDecimal(info.IdEmpleado),info.IdNovedad,info.Secuencia);
                Obj_DNovedad = new BindingList<ro_Empleado_Novedad_Det_Info>(empNove);
                grdLista.DataSource = Obj_DNovedad;
                CheckEstado.Checked = (info.Estado =="A") ? true : false;               
                groupControlMotivoModificacion.Visible = true;
                TxtMotivoModifica.Text = info.MotivoModifica;
                InfoCabNove = info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); MessageBox.Show(ex.ToString());
            }
        }



        public List<ro_Empleado_Novedad_Det_Info> Consulta_Detalle(int Empresa, decimal idEmpleado, decimal idNovedad,decimal Secuencia)
        {
            try
            {
                return OEmpDetalle.Get_List_Empleado_Novedad_Det(Empresa, idEmpleado, idNovedad, Secuencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return new List<ro_Empleado_Novedad_Det_Info>(); 
              
            }
            
           
        }


        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
              // bloqueo();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

         
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpFecha.Value == DateTime.Now)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }           
         
        }

        private void frmRo_Empleado_Novedad_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  Event_frmRo_Empleado_Novedad_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void cmbTipoNomina_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Cargando Combo de Proceso
                int value_tnomina = 0;                
                value_tnomina = Convert.ToInt32(cmbTipoNomina.EditValue == null ? 0 : cmbTipoNomina.EditValue);
                //MessageBox.Show(Convert.ToString(value_tnomina));
                List<ro_Nomina_Tipoliqui_Info> InfoTipoLiqui = new List<ro_Nomina_Tipoliqui_Info>();
                InfoTipoLiqui = Bus_TipoL.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, value_tnomina);            
                this.cmbTipoLiq.Properties.DataSource = InfoTipoLiqui;                
                cmbEmpleados.Text = null;
                cmbTipoLiq.Text = null;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {

                  
                        if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            gridView.DeleteSelectedRows();
                        }
                    
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbRubro_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //ultraCmb_idtCredito.Properties.GetRowByKeyValue(ultraCmb_idtCredito.EditValue);
               // var r = this.cmbRubro.get
              //  this.gridView.SetFocusedRowCellValue(colru_tipo,r);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void repositoryItemGridLookUpEdit_Rubro_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ro_rubro_tipo_Info Rub = (ro_rubro_tipo_Info)repositoryItemGridLookUpEdit_Rubro.GetRowByKeyValue(rub_ti);
                if (Rub != null)
                {
                    gridView.SetFocusedRowCellValue(colru_tipo, (Rub.ru_tipo == "I") ? "Ingreso" : "Egreso");
                    gridView.SetFocusedRowCellValue(colEstadoCobro, "PEN");
                    gridView.SetFocusedRowCellValue(colEstado, "A");
                  


                    Rubro_Info = Rub;
                    if (Rub.rub_codigo == "A_8_8" || Rub.rub_codigo == "A_7_7" || Rub.rub_codigo == "A_9_9" || Rub.rub_codigo=="977")
                    {
                        gridView.Columns[2].Visible = true;

                        lbSueldo.Text = "$ SUE: " + Convert.ToString(Sueldo) + " $VH " + Convert.ToString(valoHora);

                        gridView.SetFocusedRowCellValue(ColNumHoras, 0);
                    }
                   

                }
               

              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }
        decimal rub_ti;
        private void repositoryItemGridLookUpEdit_Rubro_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
               
                rub_ti = Convert.ToDecimal(e.NewValue);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e){}

        private void grdLista_TextChanged(object sender, EventArgs e){}

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string idRubro="";
            try
            {
              

                if (e.Column.Name == "ColNumHoras")
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (Obj_DNovedad.Count() > 0)
                        {
                            idRubro = Obj_DNovedad.FirstOrDefault().IdRubro;
                         Rubro_Info=   DataRubro.Where(v => v.IdRubro == idRubro).FirstOrDefault();
                        }
                    }


                    if (Rubro_Info.rub_codigo == "A_7_7")//0.25
                    {
                        // Info.base_no_sujetoIva = string.Format("{0:0.00}", Reader.GetDouble(13));
                         NumHoras = Convert.ToDouble(gridView.GetFocusedRowCellValue(ColNumHoras));
                        double ValoHoraExtra =Math.Round( Convert.ToDouble(NumHoras * (valoHora * 1.25)),2);
                        gridView.SetFocusedRowCellValue(Valor, ValoHoraExtra);
                    }


                    if (Rubro_Info.rub_codigo == "A_8_8")//0.5
                    {

                        NumHoras = Convert.ToDouble(gridView.GetFocusedRowCellValue(ColNumHoras));
                        double ValoHoraExtra =Math.Round( Convert.ToDouble(NumHoras * (valoHora*1.5)),2);
                        gridView.SetFocusedRowCellValue(Valor, ValoHoraExtra);


                    }
                    if (Rubro_Info.rub_codigo == "A_9_9")// 100
                    {
                        NumHoras = Convert.ToDouble(gridView.GetFocusedRowCellValue(ColNumHoras));
                        double ValoHoraExtra =Math.Round( Convert.ToDouble(NumHoras * (valoHora * 2)),2);
                        gridView.SetFocusedRowCellValue(Valor, ValoHoraExtra);
                    }



                    if (Rubro_Info.rub_codigo == "977")// descuento por dias
                    {
                        NumHoras = Convert.ToDouble(gridView.GetFocusedRowCellValue(ColNumHoras));
                        double ValoHoraExtra = Math.Round(Convert.ToDouble(NumHoras * (valoHora)), 2);
                        gridView.SetFocusedRowCellValue(Valor, ValoHoraExtra);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return;
            }
            
        }

        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    var data = gridView.GetRow(e.RowHandle) as ro_Empleado_Novedad_Det_Info;
                    if (data == null)
                        return;

                    if (data.Estado == "I")
                    {
                        e.Appearance.ForeColor = Color.Red;

                        RubroId.OptionsColumn.AllowEdit = false;
                        colFechaPago.OptionsColumn.AllowEdit = false;
                        Valor.OptionsColumn.AllowEdit = false;
                        Observacion.OptionsColumn.AllowEdit = false;
                        colru_tipo.OptionsColumn.AllowEdit = false;
                        colEstadoCobro.OptionsColumn.AllowEdit = false;
                        colEstado.OptionsColumn.AllowEdit = false;
                    }

                    if (data.EstadoCobro == "CAN")
                    {
                        e.Appearance.ForeColor = Color.Blue;
                        RubroId.OptionsColumn.AllowEdit = false;
                        colFechaPago.OptionsColumn.AllowEdit = false;
                        Valor.OptionsColumn.AllowEdit = false;
                        Observacion.OptionsColumn.AllowEdit = false;
                        colru_tipo.OptionsColumn.AllowEdit = false;
                        colEstadoCobro.OptionsColumn.AllowEdit = false;
                        colEstado.OptionsColumn.AllowEdit = false;
                    }






                    if (data.EstadoCobro == "PEN" || data.Estado == "A")
                    {
                        RubroId.OptionsColumn.AllowEdit = true;
                        colFechaPago.OptionsColumn.AllowEdit = true;
                        Valor.OptionsColumn.AllowEdit = true;
                        Observacion.OptionsColumn.AllowEdit = true;
                        colru_tipo.OptionsColumn.AllowEdit = false;
                        colEstadoCobro.OptionsColumn.AllowEdit = true;
                        colEstado.OptionsColumn.AllowEdit = false;
                    }










                }



                                              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_Click(object sender, EventArgs e)
        {
            try
            {
            // bloqueo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

     

        private void groupBox1_Enter(object sender, EventArgs e){}

        private void frmRo_Empleado_Novedad_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

      

        private void pu_ObternerNominaPeriodo() {
            try { 
               //OBTENER PERIODO ACTUAL
                if(cmbTipoNomina.EditValue.ToString()!="" && cmbTipoLiq.EditValue.ToString()!=""){

                    _idNominaTipo = Convert.ToInt32(cmbTipoNomina.EditValue);
                    _idNominaTipoLiqui = Convert.ToInt32(cmbTipoLiq.EditValue);

                    oRo_PeriodoInfo = oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.GetInfoPeriodoActual(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, ref mensaje);

                    _idPeriodo = oRo_PeriodoInfo.IdPeriodo;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                gridView.OptionsBehavior.Editable = true;
            } 

        
        }



        private Boolean pu_ValidarFechaPagoPeriodoCerrado(ro_Empleado_Novedad_Det_Info oFila)
        { 
            try{
                Boolean valorRetornar = false;

                int rowHandle = gridView.FocusedRowHandle;

                //DateTime fecha = Convert.ToDateTime(gridView.GetRowCellValue(rowHandle, colFechaPago));
                DateTime fecha = oFila.FechaPago;

                ro_periodo_x_ro_Nomina_TipoLiqui_Info info=new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
                
                pu_ObternerNominaPeriodo();

                info = oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.GetInfoConsultaPeriodoPorFecha(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, fecha, ref mensaje);

                if(info.Cerrado=="S"){
                    valorRetornar = true;
                }

                return valorRetornar;
            } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Log_Error_bus.Log_Error(ex.ToString()); return false;
                } 
        }


        private void dtpFechaPago_EditValueChanged(object sender, EventArgs e)
        {
            gridView.CloseEditor();
            gridView.UpdateCurrentRow();
        }

        private void dtpFechaPago_Validating(object sender, CancelEventArgs e)
        {
      
            //if (pu_ValidarFechaPagoPeriodoCerrado())
            //{
            //    e.Cancel = true;
            //}
            //else {
            //    e.Cancel = false;
            //}


        }

        private void dtpFechaPago_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //int rowHandle = gridView.FocusedRowHandle;
            //DateTime fecha = Convert.ToDateTime(gridView.GetRowCellValue(rowHandle, colFechaPago));

        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                ro_Empleado_Novedad_Det_Info oFila = (ro_Empleado_Novedad_Det_Info)gridView.GetRow(e.RowHandle);


                if (pu_ValidarFechaPagoPeriodoCerrado(oFila))
                {
                    e.Valid = false;
                    gridView.SetColumnError(colFechaPago, "La fecha que está ingresando corresponde a un Período que actualmente está cerrado, revise por favor");

                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
           

        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (pu_Grabar() == false)
                {
                    MessageBox.Show("El registro no se pudo guardar, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
                // habilitar controles

                this.cmbTipoNomina.Enabled = true;
                this.cmbTipoLiq.Enabled = true;
                this.cmbEmpleados.Enabled = true;
                this.txtNovedad.ReadOnly = true;
                cmbTipoLiq.EditValue = null;
                cmbTipoNomina.EditValue = null;
                cmbEmpleados.EditValue = null;
                cmbRubro.ValueMember = "0";
              
                Obj_DNovedad = new BindingList<ro_Empleado_Novedad_Det_Info>();              
                grdLista.DataSource = Obj_DNovedad;
                grdLista.DataSource = null;
                grdLista.RefreshDataSource();
                this.textTotal.Text = "";
                txtNovedad.Text = "";
                CheckEstado.Checked = true;
                
                pu_CargaInicial();

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public void Set_IdEmpleado(int IdEmpleao, int IdNomina_Tipo, int IdNomina_Tipo_Liq)
        {
            try
            {
                cmbTipoNomina.EditValue = IdNomina_Tipo;
                cmbTipoLiq.EditValue = IdNomina_Tipo_Liq;
                cmbEmpleados.EditValue = IdEmpleao;



                cmbEmpleados.Enabled = false;
                cmbTipoNomina.Enabled = false;
                cmbTipoLiq.Enabled = false;



            }
            catch (Exception ex)
            {
                
              
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }

        private void cmbEmpleados_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoEmpleado = (ro_Empleado_Info)cmbEmpleados.Properties.View.GetFocusedRow();


                if (InfoEmpleado == null)
                {
                    try
                    {
                        InfoEmpleado = lista_empleados.Where(q => q.IdEmpleado == InfoCabNove.IdEmpleado).FirstOrDefault();
                    }
                    catch (Exception)
                    {
                        
                        
                    }

                }

                if (InfoEmpleado != null)
                {
                    Sueldo = BusSueldo.GetSueldoActual(param.IdEmpresa, InfoEmpleado.IdEmpleado);


                    valoHora = Convert.ToDouble(Sueldo / 240);
                }
                
            }
            catch (Exception ex )
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       
        public void SetEmpleado(int Idnominatipo, int IdEmpleado)
        {
            try
            {
                cmbEmpleados.EditValue = IdEmpleado;
                cmbTipoNomina.EditValue = Idnominatipo;
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
                cmbEmpleados.Properties.DataSource = lista_empleados.Where(v => v.IdNomina_Tipo ==Convert.ToInt32( cmbTipoNomina.EditValue)).ToList();

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

        private void ucGe_Menu_event_btnImpRep_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir(Convert.ToInt32(cmbEmpleados.EditValue), Convert.ToInt32(txtNovedad.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir(Convert.ToInt32(cmbEmpleados.EditValue), Convert.ToInt32(txtNovedad.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
                   
    }
}
