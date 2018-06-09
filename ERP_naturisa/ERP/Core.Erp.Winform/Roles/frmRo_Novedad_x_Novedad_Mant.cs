/*CLASE: frmRo_Novedad_x_Novedad_Mant
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 09-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
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
using Core.Erp.Info.General;
using System.IO;
using System.Data.OleDb;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Novedad_x_Novedad_Mant : Form
    {
        #region variables
        //BUS
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        ro_rubro_tipo_Bus busRubro = new ro_rubro_tipo_Bus();
        ro_Nomina_Tipoliqui_Bus busProc = new ro_Nomina_Tipoliqui_Bus();
        ro_Nomina_Tipo_Bus busNominaTip = new ro_Nomina_Tipo_Bus();
        ro_Empleado_Novedad_Bus BusCab = new ro_Empleado_Novedad_Bus();
        ro_Empleado_Novedad_Det_Bus BusDet = new ro_Empleado_Novedad_Det_Bus();
        ro_Novedad_x_Empleado_Bus oRo_Novedad_x_Empleado_Bus = new ro_Novedad_x_Empleado_Bus();
        ro_Catalogo_Bus bus_estadoCob = new ro_Catalogo_Bus();
        ro_Empleado_Bus busEmpleado = new ro_Empleado_Bus();
        vwro_empleado_por_novedades_cabecera_Bus oVwro_empleado_por_novedades_cabecera_Bus = new vwro_empleado_por_novedades_cabecera_Bus();

        //INFO
        BindingList<ro_Empleado_Novedad_Det_Info> ListaBind ;//= new BindingList<ro_Empleado_Novedad_Det_Info>();
        BindingList<ro_Empleado_Novedad_Det_Info> BindListMarc = new BindingList<ro_Empleado_Novedad_Det_Info>();
        List<ro_Empleado_Novedad_Info> LstInfoCab = new List<ro_Empleado_Novedad_Info>();
        List<ro_Empleado_Novedad_Det_Info> ListaPrestamoQuirogra = new List<ro_Empleado_Novedad_Det_Info>();
        ro_Empleado_Novedad_Info infoCabecera = new ro_Empleado_Novedad_Info();
        ro_Empleado_Novedad_Det_Info infoCabeceraDetalle = new ro_Empleado_Novedad_Det_Info();
        vwro_empleado_por_novedades_cabecera_Info vwInfoCabecera = new vwro_empleado_por_novedades_cabecera_Info();
        public ro_Empleado_Novedad_Det_Info InfoHistoricoSueldo = new ro_Empleado_Novedad_Det_Info();
        ro_Empleado_Novedad_Info CabAnu = new ro_Empleado_Novedad_Info();
        ro_Empleado_Novedad_Det_Info DetAnu = new ro_Empleado_Novedad_Det_Info();
        ro_Empleado_Novedad_Det_Info row = new ro_Empleado_Novedad_Det_Info();
 
        //VARIABLES
        string Mensaje = "";
        Cl_Enumeradores.eTipo_action iAccion = new Cl_Enumeradores.eTipo_action();
        Boolean banderaCargaBatch = false;
        string motivoAnulacion = "";
       
        #endregion
        
        public frmRo_Novedad_x_Novedad_Mant()
        {
            try
            {
                InitializeComponent();

//                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;

                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;

                System.Globalization.CultureInfo Cultura = new System.Globalization.CultureInfo("es-EC");

                gridViewNovxEmp.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }



        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            PU_ANULAR();
        }


        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e) {
            try
            {
                this.cmbNovedad.Focus();

                //VALIDA QUE NO ESTE ACIVADO 
                //if (this.btnCargaExcel.Enabled == false)
                 if (banderaCargaBatch){
                    foreach (var item in BindListMarc){
                        if (item.existeerror == "ERROR"){
                            MessageBox.Show("Imposible guardar el registro, por favor verifique los datos en ROJO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }
                    PU_GRABAR_ACTUALIZAR();
                }else{
                    PU_GRABAR_ACTUALIZAR();
                }
            }catch (Exception ex){
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (PU_GRABAR_ACTUALIZAR())
                    this.Close();
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


        private void PU_ANULAR()
        {
            try{
                FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                if (MessageBox.Show("Está seguro que desea ANULAR el registro, recuerde que se procederá a eliminar todos los registros del detalle?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string msg = "";
                    oFrm.ShowDialog();
                    motivoAnulacion = oFrm.motivoAnulacion;
                    getInfo();

                    if (PU_MODIFICAR()){
                        setInfo(vwInfoCabecera);
                        lblAnulado.Visible = true;
                        ucGe_Menu.Enabled_bntAnular = false;

                    }else{
                        MessageBox.Show("Imposible anular el Registro No. " + txtIdTransaccion.Text + " , débido a: "
                        + msg, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }catch (Exception ex){
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


    
       
        private void cmbTipoNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cmbTipoNomina.EditValue) != 0)
                {
                    var listadoprocesoliq = busProc.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbTipoNomina.EditValue));
                    cmbProcesoLiqNomina.Properties.DataSource = listadoprocesoliq;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        List<ro_Empleado_Novedad_Det_Info> LstEmp = new List<ro_Empleado_Novedad_Det_Info>();
               
        void PU_CARGAR_COMBOS()
        {
            try
            {
                var lstRubro = (from a in busRubro.ConsultaGeneralPorEmpresa(param.IdEmpresa)
                                where a.rub_concep==true
                                select a).ToList();
                
                cmbNovedad.Properties.DataSource = lstRubro;

                var lstTipNomina = busNominaTip.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbTipoNomina.Properties.DataSource = lstTipNomina;
                LstEmp = new List<ro_Empleado_Novedad_Det_Info>();
                 var lstEmpleados = busEmpleado.Get_List_Empleado_(param.IdEmpresa);
                foreach (var item in lstEmpleados)
                {
                    ro_Empleado_Novedad_Det_Info infoempTemp = new ro_Empleado_Novedad_Det_Info();
                    infoempTemp.em_cedula = item.InfoPersona.pe_cedulaRuc;
                    infoempTemp.em_codigo = item.em_codigo;
                    infoempTemp.em_nombre = item.InfoPersona.pe_nombreCompleto;
                    infoempTemp.IdEmpleado = item.IdEmpleado;
                    infoempTemp.IdEmpresa = item.IdEmpresa;
                    LstEmp.Add(infoempTemp);
                }
                cmbEmpleado.DataSource = LstEmp;

                var lstEstadoCob = bus_estadoCob.Get_List_CatalogoEstadoPrestamo();
                this.cmbEstadoCobro.DataSource = lstEstadoCob;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setAccion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                gpCabecera.Enabled = true;
                gpDetalle.Enabled = true;

                iAccion = Accion;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;


                        this.cmbTipoNomina.Enabled = false;
                        this.cmbTipoNomina.BackColor = System.Drawing.Color.White;
                        this.cmbTipoNomina.ForeColor = System.Drawing.Color.Black;

                          this.cmbNovedad.Enabled = false;
                          this.cmbNovedad.BackColor = System.Drawing.Color.White;
                          this.cmbNovedad.ForeColor = System.Drawing.Color.Black;


                          this.cmbProcesoLiqNomina.Enabled = false;
                          this.cmbProcesoLiqNomina.BackColor = System.Drawing.Color.White;
                          this.cmbProcesoLiqNomina.ForeColor = System.Drawing.Color.Black;

                          this.gridViewNovxEmp.OptionsBehavior.Editable = false;

                          this.dtpFecha.Enabled = false;
                          this.txtObservacion.Enabled = false;

                        break;

                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;

                        this.colIdEmpleado.OptionsColumn.AllowEdit = true;
                        this.colEstadoCobro.OptionsColumn.AllowEdit = false;

                        ListaBind = new BindingList<ro_Empleado_Novedad_Det_Info>();
                        gridControlNovxEmp.DataSource = ListaBind;

                        lblAnulado.Visible = false;


                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;

                         this.cmbTipoNomina.Enabled = false;
                         this.cmbTipoNomina.BackColor = System.Drawing.Color.White;
                         this.cmbTipoNomina.ForeColor = System.Drawing.Color.Black;

                         this.cmbNovedad.Enabled = false;
                         this.cmbNovedad.BackColor = System.Drawing.Color.White;
                         this.cmbNovedad.ForeColor = System.Drawing.Color.Black;

                         this.cmbProcesoLiqNomina.Enabled = false;
                         this.cmbProcesoLiqNomina.BackColor = System.Drawing.Color.White;
                         this.cmbProcesoLiqNomina.ForeColor = System.Drawing.Color.Black;

                         this.dtpFecha.Enabled = false;
                         

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;


                        this.cmbTipoNomina.Enabled = false;
                        this.cmbTipoNomina.BackColor = System.Drawing.Color.White;
                        this.cmbTipoNomina.ForeColor = System.Drawing.Color.Black;

                          this.cmbNovedad.Enabled = false;
                          this.cmbNovedad.BackColor = System.Drawing.Color.White;
                          this.cmbNovedad.ForeColor = System.Drawing.Color.Black;


                          this.cmbProcesoLiqNomina.Enabled = false;
                          this.cmbProcesoLiqNomina.BackColor = System.Drawing.Color.White;
                          this.cmbProcesoLiqNomina.ForeColor = System.Drawing.Color.Black;

                          this.gridViewNovxEmp.OptionsBehavior.Editable = false;

                          this.dtpFecha.Enabled = false;
                          this.txtObservacion.Enabled = false;
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



        public void setInfo(vwro_empleado_por_novedades_cabecera_Info info)
        {
            try
            {
                vwInfoCabecera = info;

                //ASIGNO LOS DATOS A LOS CONTROLES
                txtIdTransaccion.Text = Convert.ToString(info.IdTransaccion);
                cmbNovedad.EditValue = info.IdRubro;
                cmbTipoNomina.EditValue = info.TipoNomina;
                cmbProcesoLiqNomina.EditValue = info.TipoLiquidacion;
                txtObservacion.Text = info.Observacion;
                dtpFecha.DateTime=info.Fecha;
                
                //QUEDA PENDIENTE SE DEBE AGREGAR ESTE CAMPO EN LA VISTA DE LA B/D
                var listaDetalle = BusDet.Get_List_Empleado_Novedad_Det_x_Rubro(param.IdEmpresa, info.IdTransaccion, info.IdRubro);

                infoCabecera.LstDetalle = listaDetalle;
               
                lblAnulado.Visible = info.Estado == "I" ? true : false;

                if (listaDetalle.Count != 0)
                {
                    listaDetalle.ForEach(var => var.check = true);
                    ListaBind = new BindingList<ro_Empleado_Novedad_Det_Info>(listaDetalle);
                    gridControlNovxEmp.DataSource = ListaBind;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
            
        private void frmRo_Novedad_x_Novedad_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFecha.EditValue = DateTime.Now;
           
                PU_CARGAR_COMBOS();
                event_frmRo_Novedad_x_Novedad_Mant_FormClosing += frmRo_Novedad_x_Novedad_Mant_event_frmRo_Novedad_x_Novedad_Mant_FormClosing;
               
                cmbTipoNomina.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void frmRo_Novedad_x_Novedad_Mant_event_frmRo_Novedad_x_Novedad_Mant_FormClosing(object sender, FormClosingEventArgs e){}

        private void PU_IMPRIMIR() {
            try
            {
                this.gridControlNovxEmp.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }

        public Boolean control_Datos_Detalle()
        {
            try
            {
                int cuenta = 0;
                int i = 0;
                int focus = gridViewNovxEmp.FocusedRowHandle;
                gridViewNovxEmp.FocusedRowHandle = focus + 1;


                foreach (var item in ListaBind)
                {
                   

                    if (item.FechaPago == null)
                    {
                        MessageBox.Show("La Fecha de Pago es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }

                    if (item.FechaPago == Convert.ToDateTime("01-01-0001") || item.FechaPago == Convert.ToDateTime("01-01-0001"))
                    {
                        MessageBox.Show("La Fecha de Pago tiene un formato no válido, revise por favor","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        return false;
                    }

                    if (item.Valor == null)
                    {
                        MessageBox.Show("EL Valor del Rubro es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }

                    if (item.Valor <= 0)
                    {
                        MessageBox.Show("El Valor del Rubro debe ser mayor a 0, reviser por favor","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        return false;
                        }

                    if (item.Observacion == null)
                    {
                        MessageBox.Show("La Observación es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }


                    if (Convert.ToDateTime(item.FechaPago.ToShortDateString()) < Convert.ToDateTime(dtpFecha.EditValue.ToString()))
                    {                                        
                        MessageBox.Show("La Fecha de Pago es menor a la fecha del registro en el :" + " " + "\nregistro" + " " + i + " Por favor ingrese una fecha igual o mayor al del registro","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        return false;
                    }


                    cuenta++;
                }
               
                if (cuenta <= 0)
                {
                    MessageBox.Show("El Rubro de la Novedad es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private Boolean PU_VERIFICAR_REPETIDOS(decimal idempleado, Boolean eliminar, int tipo)
        {
            try
            {
                int cont=0;

                if (banderaCargaBatch)
                {
                    cont = (from C in BindListMarc
                           where C.IdEmpleado == idempleado
                           select C).Count();

                }
                else {
                    cont = (from C in ListaBind
                               where C.IdEmpleado == idempleado
                               select C).Count();
                }


                if (cont== tipo)
                {
                    return true;
                }
                else
                {
                    if (eliminar == true)
                    {
                        gridViewNovxEmp.DeleteRow(gridViewNovxEmp.FocusedRowHandle);
                        MessageBox.Show("El código ya se encuentra ingresado, se procederá con su eliminación.","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("El código ya se encuentra ingresado.","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }

        }


        private void gridViewNovxEmp_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                row = (ro_Empleado_Novedad_Det_Info)gridViewNovxEmp.GetRow(e.RowHandle);

                
                if (row != null)
                {
                    if (e.Column.Name == "colIdEmpleado")
                    {
                        if (PU_VERIFICAR_REPETIDOS(Convert.ToDecimal(e.Value), true, 1))
                        {
                            var emp = busEmpleado.Get_Info_Empleado(param.IdEmpresa, Convert.ToDecimal(e.Value));

                            foreach (var item in ListaBind)
                            {
                                if (item.IdEmpleado == Convert.ToDecimal(e.Value))
                                {
                                    item.em_nombre = emp.InfoPersona.pe_nombreCompleto;
                                    item.em_codigo = emp.em_codigo;
                                    item.em_cedula = emp.InfoPersona.pe_cedulaRuc;
                                    item.FechaPago = DateTime.Now;
                                    item.check = true;

                                }
                            }
                        }


                    }
                    else if (e.Column.Name == "colValor")
                    {

                        if (row.IdEmpleado == 0)
                        {
                            MessageBox.Show("El Nombre del Empleado es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            gridViewNovxEmp.DeleteRow(gridViewNovxEmp.FocusedRowHandle);
                        }
                        else
                        {
                            foreach (var item in ListaBind)
                            {
                                if (item.IdEmpleado == row.IdEmpleado)
                                {
                                    item.check = true;

                                }
                            }

                        }


                    }


                    else if (e.Column.Name == "colObservacion")
                    {

                        if (row.IdEmpleado == 0)
                        {
                            MessageBox.Show("Seleccione primero el empleado a registrar","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            gridViewNovxEmp.DeleteRow(gridViewNovxEmp.FocusedRowHandle);
                        }
                        else
                        {
                            foreach (var item in ListaBind)
                            {
                                if (item.IdEmpleado == row.IdEmpleado)
                                {
                                    item.check = true;

                                }
                            }

                        }
                    }
                    else if (e.Column.Name == "colFechaPago")
                    {
                        if (row.IdEmpleado == 0)
                        {
                            MessageBox.Show("Seleccione primero el empleado a registrar","ATENCION", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            gridViewNovxEmp.DeleteRow(gridViewNovxEmp.FocusedRowHandle);
                        }
                        else
                        {
                            foreach (var item in ListaBind)
                            {
                                if (item.IdEmpleado == row.IdEmpleado)
                                {
                                    item.check = true;

                                }
                            }

                        }

                    }

                    if (e.Column.Name == "colIdEmpleado")
                    {
                        try
                        {
                            if (gridViewNovxEmp.GetFocusedRowCellValue(colEstadoCobro) == null)
                            {
                            gridViewNovxEmp.SetFocusedRowCellValue(colEstadoCobro, "PEN");
                            gridViewNovxEmp.SetFocusedRowCellValue(colEstado, "A");

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            Log_Error_bus.Log_Error(ex.ToString()); return;
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

        private Boolean PU_VALIDACIONES()
        {
                       
            int a = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            //int b = Convert.ToInt32(dtpFecha.Value.ToString("yyyy"));
             int b = Convert.ToDateTime(this.dtpFecha.EditValue).Year;

             int c = a - 1;
             int i = 0;
             int focus = gridViewNovxEmp.FocusedRowHandle;
             gridViewNovxEmp.FocusedRowHandle = focus + 1;
                      
            try
            {
                if (Convert.ToInt32(cmbNovedad.EditValue) == 0)
                {
                    MessageBox.Show("La Novedad es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbNovedad.Focus();
                    return false;
                
                }
                if (Convert.ToInt32(cmbProcesoLiqNomina.EditValue) == 0)
                {
                    MessageBox.Show("El Proceso es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbProcesoLiqNomina.Focus(); return false;

                }
                if (Convert.ToInt32(cmbTipoNomina.EditValue) == 0)
                {
                    MessageBox.Show("La Nómina es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbTipoNomina.Focus(); return false;
                }

            
                if (b <= c)
                {
                    MessageBox.Show("La fecha de registro es menor al año actual..\n Ingrese una fecha igual o mayor al año actual","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return false;
                }

                //var Info = (ro_prestamo_detalle_Info)this.gridViewNovxEmp.GetFocusedRow();
                
                foreach (var item in ListaBind)
                {

                    if (item.FechaPago == null)
                    {
                        MessageBox.Show("La Fecha de Pago  es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }

                    if (item.FechaPago == Convert.ToDateTime("01-01-0001") || item.FechaPago == Convert.ToDateTime("01-01-0001"))
                    {
                        MessageBox.Show("La Fecha de Pago tiene un formato no válido","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        return false;
                    }

                    if (item.Valor == null)
                    {
                        MessageBox.Show("El Valor del Rubro es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }

                    if (item.Valor <= 0)
                    {
                        MessageBox.Show("El Valor del Rubro debe ser mayor a 0 ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }

                    if (item.Observacion == null)
                    {
                        MessageBox.Show("La Observación es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    DateTime y = item.FechaPago;
                    DateTime x =Convert.ToDateTime( Convert.ToDateTime(this.dtpFecha.EditValue).ToShortDateString());

                    if (  y < x  )
                    {
                        MessageBox.Show("La Fecha de Pago : " + item.FechaPago + "  es menor a la fecha del registro :" + x + ".  Ingrese una fecha igual o mayor al registro","ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
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

        private Boolean getInfo()
        {
            try
            {
                LstInfoCab = new List<ro_Empleado_Novedad_Info>();

                //DATOS CARGADOS MANUALMENTE
                if (banderaCargaBatch==false){                   
                    if (ListaBind.Count > 0){//VALIDA QUE EXISTAN ITEMS
                        foreach (var item in ListaBind)
                        {
                            ro_Empleado_Novedad_Info Cab = new ro_Empleado_Novedad_Info();
                            ro_Empleado_Novedad_Det_Info Det = new ro_Empleado_Novedad_Det_Info();
                            ro_Novedad_x_Empleado_Info CabDet = new ro_Novedad_x_Empleado_Info();

                            Cab.IdEmpresa = Det.IdEmpresa = CabDet.IdEmpresa = CabDet.IdEmpresa_Emp_Novedad = param.IdEmpresa;
                            Cab.IdEmpleado = Det.IdEmpleado = CabDet.IdEmpleado_Emp_Novedad = item.IdEmpleado;

                            Cab.Fecha = CabDet.Fecha = Convert.ToDateTime(dtpFecha.EditValue);
                            Cab.TotalValor = Det.Valor = item.Valor;
                            Cab.IdNomina_Tipo = CabDet.IdNomina_Tipo = Convert.ToInt32(cmbTipoNomina.EditValue);
                            Cab.IdNomina_TipoLiqui = CabDet.IdNomina_TipoLiqui = Convert.ToInt32(cmbProcesoLiqNomina.EditValue);

                            //infoCabecera.Estado = lblAnulado.Visible == true ? "I" : "A";

                            Det.IdRubro = Cab.IdRubro = CabDet.IdRubro = Convert.ToString(cmbNovedad.EditValue);
                            //Det.EstadoCobro = "PEN";
                            Det.EstadoCobro = item.EstadoCobro;
                            Det.Estado = CabDet.estado = item.Estado;
                            // Det.Estado = lblAnulado.Visible==true?"I":"A";
                            Det.FechaPago = item.FechaPago;
                            Det.Observacion = item.Observacion;
                            CabDet.IdNovedad_Emp_Novedad = Cab.IdNovedad = Det.IdNovedad = item.IdNovedad;
                            //  LstDetalle.Add(Det);
                            CabDet.Observacion = txtObservacion.Text;

                            if (txtIdTransaccion.Text != null && txtIdTransaccion.Text != "")
                            {
                                CabDet.IdTransaccion = decimal.Parse(txtIdTransaccion.Text);
                            }

                            //SETEA EL ESTADO EN EL CASO QUE EL USUARIO ANULE TODO EL REGISTRO
                            if (iAccion == Cl_Enumeradores.eTipo_action.Anular && Det.EstadoCobro != "CAN")
                            {
                                Cab.Estado = Det.Estado = CabDet.estado = "I";
                                Cab.MotiAnula = motivoAnulacion;
                                Cab.IdUsuarioUltAnu = param.IdUsuario;
                                Cab.Fecha_UltAnu = param.Fecha_Transac;   
                            }
                            else
                            {
                                Cab.Estado = Det.Estado = CabDet.estado = "A";
                            }

                            Cab.LstDetalle.Add(Det);
                            Cab.lstNovedadEmpleado.Add(CabDet);

                            Cab.InfoNovedadDet = Det;
                            LstInfoCab.Add(Cab);
                        }
                    }

                }else{//DATOS CARGADOS MEDIANTE UN ARCHIVO EN EXCEL
                    if (BindListMarc.Count > 0){//VALIDA QUE EXISTAN ITEMS
                        foreach (var item in BindListMarc){
                            ro_Empleado_Novedad_Info Cab = new ro_Empleado_Novedad_Info();
                            ro_Empleado_Novedad_Det_Info Det = new ro_Empleado_Novedad_Det_Info();
                            ro_Novedad_x_Empleado_Info CabDet = new ro_Novedad_x_Empleado_Info();

                            Cab.IdEmpresa = Det.IdEmpresa = CabDet.IdEmpresa = CabDet.IdEmpresa_Emp_Novedad = param.IdEmpresa;
                            Cab.IdEmpleado = Det.IdEmpleado = CabDet.IdEmpleado_Emp_Novedad = item.IdEmpleado;

                            Cab.Fecha = CabDet.Fecha = Convert.ToDateTime(dtpFecha.EditValue);
                            Cab.TotalValor = Det.Valor = item.Valor;
                            Cab.IdNomina_Tipo = CabDet.IdNomina_Tipo = Convert.ToInt32(cmbTipoNomina.EditValue);
                            Cab.IdNomina_TipoLiqui = CabDet.IdNomina_TipoLiqui = Convert.ToInt32(cmbProcesoLiqNomina.EditValue);

                            Det.IdRubro = Cab.IdRubro = CabDet.IdRubro = Convert.ToString(cmbNovedad.EditValue);
                            Det.EstadoCobro = item.EstadoCobro;
                            Det.Estado = CabDet.estado = item.Estado;
                            Det.FechaPago = item.FechaPago;
                            Det.Observacion = item.Observacion;
                            CabDet.IdNovedad_Emp_Novedad = Cab.IdNovedad = Det.IdNovedad = item.IdNovedad;
                            CabDet.Observacion = txtObservacion.Text;

                            if (txtIdTransaccion.Text != null && txtIdTransaccion.Text != "")
                            {
                                CabDet.IdTransaccion = decimal.Parse(txtIdTransaccion.Text);
                            }

                            //SETEA EL ESTADO EN EL CASO QUE EL USUARIO ANULE TODO EL REGISTRO
                            if (iAccion == Cl_Enumeradores.eTipo_action.Anular && Det.EstadoCobro != "CAN")
                            {
                                Cab.Estado = Det.Estado = CabDet.estado = "I";
                            }
                            else
                            {
                                Cab.Estado = Det.Estado = CabDet.estado = "A";
                            }

                            Cab.LstDetalle.Add(Det);
                            Cab.lstNovedadEmpleado.Add(CabDet);

                            Cab.InfoNovedadDet = Det;
                            LstInfoCab.Add(Cab);
                            
                            banderaCargaBatch=false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        
        }
 
        void AnularCabNovedad()
        {
            try
            {

                //GETINFO();

              if (CabAnu.Estado != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (ValidarEstadoCabecera())
                    {

                        if (CabAnu.Estado == "A")
                        {


                            if (MessageBox.Show("¿Está seguro que desea anular la novedad # : " + CabAnu.IdNovedad + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string msg = "";
                                oFrm.ShowDialog();

                                CabAnu.MotiAnula = oFrm.motivoAnulacion;
                                CabAnu.IdUsuarioUltAnu = param.IdUsuario;
                                CabAnu.Fecha_UltAnu = param.Fecha_Transac;

                                if (BusCab.AnularDB(CabAnu))
                                {
                                    MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                                    MessageBox.Show("Anulado con éxito la novedad # : " + CabAnu.IdNovedad);
                                    // checkBoxEstado.Checked = false;

                                        lblAnulado.Visible = true;
                                        //this.btn_guardar.Enabled = false;
                                    
                                }
                                else MessageBox.Show("No se pudo anular la novedad # : " + CabAnu.IdNovedad + " debido a: "
                                    + msg, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo anular la novedad # : " + CabAnu.IdNovedad, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        Boolean ValidarEstadoCabecera()
        {
            try
            {
                if (CabAnu.Estado == "I")
                {
                    MessageBox.Show("La novedad # : " + CabAnu.IdNovedad + " ya fue anulada", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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




        string msg = "";
        
        private Boolean PU_GRABAR_ACTUALIZAR()
        {
            try
            {
                //if (control_Datos_Detalle() == false)
                //{
                //    return false;
                //}

                if (PU_VALIDACIONES())
                {
                    if (iAccion == Cl_Enumeradores.eTipo_action.actualizar)
                        if (PU_MODIFICAR())
                            return true;
                        else return false;
                    else
                        if (PU_GUARDAR())
                            return true;
                        else return false;
                }
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;                
            } 
        }

        private Boolean PU_GUARDAR()
        {
            try
            {
                getInfo(); //esta linea agregue AMS

                if (LstInfoCab.Count> 0) //esta linea agregue AMS
                {
                    decimal idnovedad = 0;
  
                    //OBTENER LA SECUENCIA 
                    decimal idTransaccion = oRo_Novedad_x_Empleado_Bus.getId(param.IdEmpresa);
   
                    foreach (var item in LstInfoCab)
                    {
                        item.IdUsuario = param.IdUsuario;
                        item.Fecha_Transac = param.Fecha_Transac;
                        item.nom_pc = param.nom_pc;
                        item.ip = param.ip;
                        item.Estado = "A";

                        if (!BusCab.GrabarDB(item, ref msg, ref idnovedad,ref idTransaccion))
                        {
                            MessageBox.Show(msg);
                            return false;
                        }
                    }

                    txtIdTransaccion.Text = idTransaccion.ToString();

                  //  infoCabecera = BusCab.Get_Info_Empleado_Novedad_Cab(param.IdEmpresa, idnovedad, Convert.ToString(cmbNovedad.EditValue));
                  //  vwInfoCabecera = oVwro_empleado_por_novedades_cabecera_Bus.ConsultaById(param.IdEmpresa, idTransaccion);
            
                    setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    setInfo(vwInfoCabecera);

                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else { return false; }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }

        private Boolean PU_MODIFICAR()
        {
            try
            {

               getInfo();

                if (LstInfoCab.Count > 0)
                {
                    foreach (var item in LstInfoCab)
                    {
                        item.IdUsuario = param.IdUsuario;
                        item.Fecha_Transac = param.Fecha_Transac;
                        item.Fecha_UltMod = param.Fecha_Transac;
                        item.IdUsuario = param.IdUsuario;

                        if (!BusCab.ModificarDB(item, ref msg,decimal.Parse(txtIdTransaccion.Text)))
                        {
                            MessageBox.Show(msg,"ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }


        List<ro_Empleado_Novedad_Det_Info> ListEliminar = new List<ro_Empleado_Novedad_Det_Info>();

        private Boolean PU_ELIMINAR(ro_Empleado_Novedad_Det_Info reg_anular)
        {
            try
            {
                getInfo();
               
                if (BusDet.AnularDB(reg_anular))
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }


        
        private void gridViewNovxEmp_KeyDown(object sender, KeyEventArgs e)
        {
                       
            try{
                
                #region delete
                if (e.KeyCode.ToString() == "Delete" && iAccion == Cl_Enumeradores.eTipo_action.grabar)
                    gridViewNovxEmp.DeleteSelectedRows();
                else if (e.KeyCode.ToString() == "Delete" && iAccion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    row = new ro_Empleado_Novedad_Det_Info();
                    row = (ro_Empleado_Novedad_Det_Info)gridViewNovxEmp.GetFocusedRow();
                    if (row.check == false)
                    {
                        gridViewNovxEmp.DeleteSelectedRows();
                    }
                    else if (row.IdEmpleado == 0)
                    {
                        gridViewNovxEmp.DeleteSelectedRows();
                    }
                    else
                    {

                        if (row.Estado == "I" )//1
                        {
                            MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;

                        }//1

                        if (row.EstadoCobro == "CAN")//1
                        {

                           MessageBox.Show("No se puede anular la novedad # : " + row.IdNovedad + ". \r La novedad ya fue cancelada","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                           return;

                        }//1

                        else//1
                        { //1

                            if (MessageBox.Show("Está seguro que desea anular este registro", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                row.IdEmpresa = param.IdEmpresa;
                                //row.IdNovedad = (decimal)gridViewNovxEmp.GetFocusedDataRow()["colIdNovedad"];

                                if (PU_ELIMINAR(row))
                                {
                                    MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //row.Estado = "I";
                                    //ListEliminar.Add(row);
                                    // gridViewNovxEmp.DeleteSelectedRows();
                                  
                                  //ACTUALIZA LA GRILLA
                                  this.setInfo(vwInfoCabecera);
                                }

                            }

                        }//1

                    }
                }

                #endregion 
                #region pegar
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    cargadata();
                }
                #endregion
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

       }



       


        public delegate void delegate_frmRo_Novedad_x_Novedad_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Novedad_x_Novedad_Mant_FormClosing event_frmRo_Novedad_x_Novedad_Mant_FormClosing;
       
        private void frmRo_Novedad_x_Novedad_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 event_frmRo_Novedad_x_Novedad_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


     
        #region prueba copy paste
        

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
  
        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            try
            {
                cargadata();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private Boolean AddRow(string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });
                ro_Empleado_Novedad_Det_Info newRow = new ro_Empleado_Novedad_Det_Info();
                if (rowData.Count() >= 3) //return false;            if (!(string.IsNullOrWhiteSpace(rowData[2])))
                {

                    string cod_cedula = rowData[0];

                    ro_Empleado_Novedad_Det_Info emp = new ro_Empleado_Novedad_Det_Info();
                    foreach (var item in LstEmp)
                    {
                        if ((item.em_codigo.Trim() == cod_cedula.Trim()) || (item.em_cedula.Trim() == cod_cedula.Trim()))
                        {
                            emp = item;
                            break;
                        }
                    }

                    if (emp.em_cedula != null && !string.IsNullOrWhiteSpace(emp.em_cedula))
                    {
                        if (PU_VERIFICAR_REPETIDOS(emp.IdEmpleado, false, 0))
                        {
                            newRow.IdEmpleado = emp.IdEmpleado;
                            newRow.em_cedula = emp.em_cedula;
                            newRow.em_codigo = emp.em_codigo;
                            newRow.em_nombre = emp.em_nombre;

                            DateTime dt;
                            if (DateTime.TryParse(rowData[1], out dt))
                            {
                                newRow.FechaPago = Convert.ToDateTime(rowData[1]);
                            }
                            else
                            {
                                MessageBox.Show("Por favor ingrese una fecha válida. \n Formato fecha: 30/12/2000");
                                return false;
                            }
                            double sad;
                            if (double.TryParse(rowData[2], out sad))
                            {
                                //newRow.FechaPago = Convert.ToDateTime(rowData[1]);
                                newRow.Valor = Convert.ToDouble(rowData[2]);
                            }
                            else
                            {
                                MessageBox.Show("Por favor ingrese un valor válido. \n Formato númerico");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra registrado el empleado con cod/ced # :" + cod_cedula);
                            return false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado al empleado con cod/ced # :" + cod_cedula);
                        return false;
                    }

                    ListaBind.Add(newRow);
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
                Log_Error_bus.Log_Error(ex.ToString());
                return false;       
            }                                
        }

        void cargadata()
        {
            try
            {
                string[] data = ClipboardData.Split('\n');
                if (data.Length < 1) return;
                foreach (string row in data)
                {
                    if (!AddRow(row))
                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }       
        }
      
        #endregion

        private void gridViewNovxEmp_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

                var data = gridViewNovxEmp.GetRow(e.RowHandle) as ro_Empleado_Novedad_Det_Info;
                if (data == null)
                    return;
                if (data.Estado == "I" || data.existeerror == "ERROR")
                    e.Appearance.ForeColor = Color.Red;

                if (data.EstadoCobro == "CAN")
                    e.Appearance.ForeColor = Color.Blue;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewNovxEmp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (this.txtIdTransaccion.Text != "0")
                {

                    var item = (ro_Empleado_Novedad_Det_Info)gridViewNovxEmp.GetRow(e.FocusedRowHandle);
                

                    if (item != null)
                    {

                        if (item.EstadoCobro == "CAN")
                        {


                            // MessageBox.Show("Seguro");


                            this.colIdEmpleado.OptionsColumn.AllowEdit = false;
                            this.colFechaPago.OptionsColumn.AllowEdit = false;

                            this.colValor.OptionsColumn.AllowEdit = false;
                            this.colObservacion.OptionsColumn.AllowEdit = false;
                            this.colEstado.OptionsColumn.AllowEdit = false;

                            this.colEstadoCobro.OptionsColumn.AllowEdit = false;
                            //  gridColumnEstadoPago.OptionsColumn.AllowEdit = false;
                        }
                        else
                        {
                            if (item.Estado == "I")
                            {
                                this.colIdEmpleado.OptionsColumn.AllowEdit = false;
                                this.colFechaPago.OptionsColumn.AllowEdit = false;

                                this.colValor.OptionsColumn.AllowEdit = false;
                                this.colObservacion.OptionsColumn.AllowEdit = false;
                                this.colEstado.OptionsColumn.AllowEdit = false;

                                this.colEstadoCobro.OptionsColumn.AllowEdit = false;
                            }

                            else
                            {
                                this.colIdEmpleado.OptionsColumn.AllowEdit = true;
                                this.colFechaPago.OptionsColumn.AllowEdit = true;

                                this.colValor.OptionsColumn.AllowEdit = true;
                                this.colObservacion.OptionsColumn.AllowEdit = true;

                                this.colEstadoCobro.OptionsColumn.AllowEdit = true;

                                this.colEstado.OptionsColumn.AllowEdit = false;
                            }
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

        private void gridViewNovxEmp_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e){}

        #region Carga Excel Prestamos Quirografarios
        //haac 16/01/2014

        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";


      

        DataTable ds = new DataTable();
       // string msg;

      

        public void PU_CARGA_EXCEL()
        {
            try{
                DateTime fecha = new DateTime();
                fecha = Convert.ToDateTime(this.dtpFecha.EditValue);
                
                ListaPrestamoQuirogra = new List<ro_Empleado_Novedad_Det_Info>();
                ListaPrestamoQuirogra = BusDet.ProcesarDataTableAInfo_Prestamo_Quirografario(ds, param.IdEmpresa,fecha, ref msg);

            }catch (Exception ex){
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

    

        #endregion

        private void frmRo_Novedad_x_Novedad_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cmbProcesoLiqNomina_EditValueChanged(object sender, EventArgs e)
        {

        }

       

       

      

    }
}
