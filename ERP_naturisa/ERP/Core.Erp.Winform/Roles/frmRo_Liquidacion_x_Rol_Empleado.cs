
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// haac
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;

using Core.Erp.Reportes.Roles;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Liquidacion_x_Rol_Empleado : Form
    {
        int secuencia ;
        string OrgCopy;

        #region Declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        ro_Rol_Detalle_Bus ro_rol_detalle_Bus = new ro_Rol_Detalle_Bus();


        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Nomina_Tipo_Bus Bus_TipoNo = new ro_Nomina_Tipo_Bus();

        ro_periodo_Bus Bus_Periodo = new ro_periodo_Bus();

        ro_Empleado_Bus OEmplBus = new ro_Empleado_Bus();


        ro_Nomina_Tipoliqui_Bus Bus_TipoNominaLiqui = new ro_Nomina_Tipoliqui_Bus();

        ro_Departamento_Bus Bus_Depar = new ro_Departamento_Bus();


        frmRo_Empleado_Novedad_Mant frm;


        ro_Empleado_Novedad_Info Info_CabNovedad = new ro_Empleado_Novedad_Info();


        ro_Rol_Detalle_Info Info_IngEgrEmpleado = new ro_Rol_Detalle_Info();

        ro_Empleado_Novedad_Bus bus_Novedad = new ro_Empleado_Novedad_Bus();
        ro_prestamo_Bus bus_Prestamo = new ro_prestamo_Bus();

        List<ro_Empleado_Info> ListEmpleados = new List<ro_Empleado_Info>();

        List<ro_Empleado_Info> oRo_EmpleadoSaldoNegativo_Info = new List<ro_Empleado_Info>();
        List<ro_Empleado_Info> oRo_EmpleadoSaldoPositivo_Info = new List<ro_Empleado_Info>();
        List<ro_Rol_Detalle_Info> ListIng = new List<ro_Rol_Detalle_Info>();
        List<ro_Rol_Detalle_Info> ListEgre = new List<ro_Rol_Detalle_Info>();

#endregion

        int contador;
        int i;//bandera para controlar check
        int j;//bandera para validar si se esta selccionando un check

        int band = 0;

        //procesar rol
        ro_Procesar_Rol_Bus Proceso_bus = new ro_Procesar_Rol_Bus();
        List<ro_periodo_Info> InfoPeriodo = new List<ro_periodo_Info>();





        //Valores
        int _idNominaTipo;
        int _idNominaTipoLiqui;
        int _idPeriodo;
        int _idEmpresa;
        //decimal _idEmpleado;

        string mensaje = "";
        
      //  decimal _idEmpleado = 0;
        
        //INFO
        ro_periodo_x_ro_Nomina_TipoLiqui_Info oRo_PeriodoInfo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

        List<ro_periodo_Info> oLst_InfoPeriodo = new List<ro_periodo_Info>();
        ro_Empleado_Info Info = new ro_Empleado_Info();



       
        public frmRo_Liquidacion_x_Rol_Empleado()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Properties.Settings.Default.ConfRegional);

            try
            {
                InitializeComponent();


                ucGe_Menu_Superior_Mant.event_btnSalir_Click += ucGe_Menu_Superior_Mant_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant.event_btnImprimir_Click += ucGe_Menu_Superior_Mant_event_btnImprimir_Click;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }



  



        void ucGe_Menu_Superior_Mant_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Imprimir();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void frmRo_Liquidacion_x_Rol_Empleado_Load(object sender, EventArgs e)
        {
            try
            {
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;

                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Properties.Settings.Default.ConfRegional);
                pu_CargaInicial();


                this.Empleado.OptionsColumn.AllowEdit = false;
              //  this.Sucursal_Descripcion.OptionsColumn.AllowEdit = false;
                this.Departamento.OptionsColumn.AllowEdit = false;
                this.check.OptionsColumn.AllowEdit = false;

                this.gridViewIng.OptionsBehavior.Editable = false;
                this.gridViewEgr.OptionsBehavior.Editable = false;

         
   
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
                _idEmpresa = param.IdEmpresa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


   
        
       void setInfo(ro_Empleado_Info info)
        {                      
            try
            {
                Info = info;
                
                this.txtCedula.Text =Info.InfoPersona.pe_cedulaRuc;
                this.txtNombre.Text= Info.NomCompleto;
                this.txtDepartamento.Text = Info.de_descripcion;
                this.txtCargo.Text = Info.cargo_Descripcion;
                this.txtCodigo.Text = Info.em_codigo;
           


                pu_CargarValores();


                ////PROCESA LOS RUBROS DE INGRESOS/EGRESOS DEL ROL
                //pu_ActualizarRubroEmpleado(Info.IdEmpleado,info.em_status);

                List<ro_Rol_Detalle_Info> lista_Ingreso_Tmp = new List<ro_Rol_Detalle_Info>();
                List<ro_Rol_Detalle_Info> lista_Egreso_Tmp = new List<ro_Rol_Detalle_Info>();
                decimal ingreso = 0;
                decimal egreso = 0;
                lista_Ingreso_Tmp =ListIng.Where(v=>v.IdEmpresa==param.IdEmpresa && v.IdNominaTipo==_idNominaTipo && v.IdNominaTipoLiqui==_idNominaTipoLiqui && v.IdPeriodo==_idPeriodo && v.IdEmpleado==Convert.ToInt32( info.IdEmpleado)).ToList();               

               //cargar imagen en boton grilla
                foreach (var item in ListIng)
                {
                    
                    item.Ico1 = (Bitmap)imageList1.Images[0];
                    item.Ico2 = (Bitmap)imageList1.Images[1];
                    ingreso = ingreso +Convert.ToDecimal( item.Valor);
                }
                this.gridControlIng.DataSource = lista_Ingreso_Tmp;
              
                //Obtener Egresos

                lista_Egreso_Tmp = ListEgre.Where(v => v.IdEmpresa == param.IdEmpresa && v.IdNominaTipo == _idNominaTipo && v.IdNominaTipoLiqui == _idNominaTipoLiqui && v.IdPeriodo == _idPeriodo && v.IdEmpleado == Convert.ToInt32(info.IdEmpleado)).ToList();                            
              
                //cargar imagen en boton grilla
                foreach (var item in ListEgre)
                {               
                    item.Ico1 = (Bitmap)imageList1.Images[0];
                    item.Ico2 = (Bitmap)imageList1.Images[1];
                    egreso = egreso + Convert.ToDecimal(item.Valor);

                }
                this.gridControlEgr.DataSource = lista_Egreso_Tmp;

                lblTotalRecibir.Text = "Neto Recibír: " + (ingreso - egreso).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //limpia grid gridControl
        BindingList<ro_Empleado_Novedad_Info> DataSource = new BindingList<ro_Empleado_Novedad_Info>();

        private void gridViewEmp_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {                      
            try
            {
                pu_CheckTodos();
                if (e.HitInfo.Column.Name == "check")
                {
                    if ((bool)gridViewPositivos.GetFocusedRowCellValue(check))
                    {
                        gridViewPositivos.SetFocusedRowCellValue(check, false);
                        this.txtCedula.Text = "";
                        this.txtNombre.Text = "";
                        this.txtDepartamento.Text = "";
                        this.txtCargo.Text = "";
                        this.txtCodigo.Text = "";

                        //limpia gridControl
                        this.DataSource = new BindingList<ro_Empleado_Novedad_Info>();
                        this.gridControlIng.DataSource = DataSource;
                        this.gridControlEgr.DataSource = DataSource;

                       
                        this.lblTotalRecibir.Text = "Neto a Recibir:  ";

                        // this.cmbTipoNomina.Enabled = false;
                    }
                    else
                    {
                        if (cmbnomina.EditValue == null)
                        {
                            MessageBox.Show("Ingrese el tipo de nómina", "ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            return;
                        }
                        else
                        {
                            if (cmbnominaTipo.EditValue == null)
                            {
                                MessageBox.Show("Ingrese el tipo de proceso", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }
                            else
                            {
                                if (cmbPeriodos.EditValue== null)
                                {
                                    MessageBox.Show("Ingrese el periodo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    return;
                                }
                                else
                                {
                                    band = 1;

                                   // pu_CheckTodos();

                                    gridViewPositivos.SetFocusedRowCellValue(check, true);

                                    ro_Empleado_Info info = (ro_Empleado_Info)this.gridViewPositivos.GetFocusedRow();

                                    setInfo(info);

                                }
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
     

        Boolean VerificaGridEmpleadosMuchos()
        {
            try
            {
                int cuenta = 0;
                
                for (int i = 0; i < gridViewPositivos.RowCount - 1; i++)
                {

                  ro_Empleado_Info info = (ro_Empleado_Info)gridViewPositivos.GetRow(i);

                  if (cuenta > 0)
                  {
                     // MessageBox.Show("No se puede consultar más de un empleado");
                      return false;
                  }
                  else
                  {
                      if (info.check == true)
                      {
                          cuenta++;

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
    
      
        
        frmRo_Prestamos frmMant = new frmRo_Prestamos();

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmRo_Empleado_Novedad_Mant();


                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (Info_IngEgrEmpleado.TipoRegistro == "OTR")
                        {
                            MessageBox.Show("El Rubro no es editable", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        if (Info_IngEgrEmpleado.TipoRegistro == "NOV" && Info_IngEgrEmpleado.IdNovedad != 0 )
                        {
                            // Consultando Novedades
                            ro_Empleado_Novedad_Info InfoNovedad = new ro_Empleado_Novedad_Info();
                            InfoNovedad = bus_Novedad.Get_Info_Empleado_Novedad_Cab_x_Rubro(param.IdEmpresa, Info_IngEgrEmpleado.IdNovedad, Info_IngEgrEmpleado.IdRubro, Info.IdEmpleado);

                            frmMant.Text = frmMant.Text + " ***ACTUALIZAR REGISTRO***";
                            frm.set_Accion(Accion);
                            frm.set_Info(InfoNovedad);
                            frm.ShowDialog();

                            return;
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                         if (Info_IngEgrEmpleado.TipoRegistro == "OTR")
                        {
                            MessageBox.Show("El rubro no se puede anular", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (Info_IngEgrEmpleado.TipoRegistro == "NOV" && Info_IngEgrEmpleado.IdNovedad != 0 )
                        {
                            // Consultando Novedades
                            ro_Empleado_Novedad_Info InfoNovedad = new ro_Empleado_Novedad_Info();
                            InfoNovedad = bus_Novedad.Get_Info_Empleado_Novedad_Cab_x_Rubro(param.IdEmpresa, Info_IngEgrEmpleado.IdNovedad, Info_IngEgrEmpleado.IdRubro, Info.IdEmpleado);

                            frmMant.Text = frmMant.Text + " ***ACTUALIZAR REGISTRO***";
                            frm.set_Accion(Accion);
                            frm.set_Info(InfoNovedad);
                            frm.ShowDialog();

                            return;
                        }



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
                Log_Error_bus.Log_Error(ex.ToString()); MessageBox.Show(ex.ToString());
            }
        }

        void frm_Event_frmRo_Empleado_Novedad_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               //load_datos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        //Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();      

        private void gridViewIng_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {                  
            try
            {

                if (e.Column.Name == "gridColumnIng_edit")
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.actualizar);

                    pu_ActualizarRubroEmpleado(Info.IdEmpleado,Info.em_status);

                }

                if (e.Column.Name == "gridColumnIng_x")
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.Anular);

                    pu_ActualizarRubroEmpleado(Info.IdEmpleado,Info.em_status);

                }

                
                            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }             
             
        }

        private void gridViewIng_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                //Info_vwRo_IngEgrEmpleado = new vwRo_Ing_Egr_x_Empleado_Info();
                //Info_vwRo_IngEgrEmpleado = gridViewIng.GetFocusedRow() as vwRo_Ing_Egr_x_Empleado_Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewEgr_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

                if (e.Column.Name == "gridColumnEgre_x" || e.Column.Name == "gridColumnEgre_edit")
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                }

                if (e.Column.Name == "gridColumnEgre_x")
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.Anular);
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }             
             
        }

        private void gridViewEgr_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
               //Info_vwRo_IngEgrEmpleado = new vwRo_Ing_Egr_x_Empleado_Info();
               //Info_vwRo_IngEgrEmpleado = gridViewEgr.GetFocusedRow() as vwRo_Ing_Egr_x_Empleado_Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

    

       private void pu_CargarValores() 
       {
           try {

               _idNominaTipo = Convert.ToInt32(cmbnomina.EditValue);
               _idNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
               _idPeriodo = Convert.ToInt32(cmbPeriodos.EditValue == null ? 0 : Convert.ToInt32(cmbPeriodos.EditValue));
               _idEmpresa = param.IdEmpresa;


               if (cmbPeriodos.EditValue != null)
               {
                   oRo_PeriodoInfo = (ro_periodo_x_ro_Nomina_TipoLiqui_Info) cmbPeriodos.Properties.View.GetFocusedRow();
                   if (oRo_PeriodoInfo.IdPeriodo == 0)
                   {
                       oRo_PeriodoInfo = listadoPeriodo.Where(v => v.IdPeriodo ==Convert.ToInt32( cmbPeriodos.EditValue)).FirstOrDefault();

                   }
               }


           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
               Log_Error_bus.Log_Error(ex.ToString());
           } 
       
       }



       private void pu_ActualizarRubroEmpleado(decimal idEmpleado, string em_status)
        {

            try
            {

                pu_CargarValores();

                ro_Rol_Bus oRo_Rol_Bus = new ro_Rol_Bus(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, oRo_PeriodoInfo);

            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }




  



      private Boolean pu_Validar()
        {

            try
            {
                if (cmbnomina.EditValue == null)
                {
                    MessageBox.Show("Ingrese el tipo de nómina ", "Sistemas");

                    return false;
                }
                else

                {

                    if (cmbnominaTipo.EditValue== null)
                    {
                        MessageBox.Show("Ingrese el proceso del rol ", "Sistemas");
                        return false;
                    }

                    else
                    {

                        if (cmbPeriodos.EditValue== null)
                        {
                            MessageBox.Show("Ingrese el periodo ", "Sistemas");
                            return false;
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
      
      
        private void cmbPeriodo_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {
                 //this.CargaEmpSalNeg();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        private void gridViewIng_Click(object sender, EventArgs e)
        {
            try
            {
                Info_IngEgrEmpleado = new ro_Rol_Detalle_Info();
                Info_IngEgrEmpleado = gridViewIng.GetFocusedRow() as ro_Rol_Detalle_Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void gridViewEgr_Click(object sender, EventArgs e)
        {
            try
            {
                Info_IngEgrEmpleado = new ro_Rol_Detalle_Info();
                Info_IngEgrEmpleado = gridViewEgr.GetFocusedRow() as ro_Rol_Detalle_Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        private void pu_AbrirPrestamos() {
            try
            {
                ro_prestamo_Info cab = new ro_prestamo_Info();
                ro_periodo_Info period = new ro_periodo_Info();

                if (period != null)
                    cab.IdEmpleado = Info.IdEmpleado;
                cab.IdNomina_Tipo = _idNominaTipo;


                frmRo_Prestamos frmPrestamo = new frmRo_Prestamos();
                frmPrestamo = new frmRo_Prestamos(Cl_Enumeradores.eTipo_action.grabar);
                frmPrestamo.setCabPrestamo(cab);

                frmPrestamo.ShowDialog();

                //btnRefresh_Click(sender, e);

                //setInfo();

                //this.CargaEmpSalNeg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void pu_AbrirNovedad()
        {
            try
            {
                ro_Empleado_Novedad_Info cab = new ro_Empleado_Novedad_Info();
                ro_periodo_Info period = new ro_periodo_Info();


                if (_idPeriodo != null)

                    cab.Fecha = period.pe_FechaIni;
                cab.IdEmpleado = Info.IdEmpleado;
                cab.IdNomina_Tipo = _idNominaTipo;
                cab.IdNomina_TipoLiqui = _idNominaTipoLiqui;

                frmRo_Empleado_Novedad_Mant frm = new frmRo_Empleado_Novedad_Mant();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.setCab(cab);
                frm.ShowDialog();

               
                //this.CargaEmpSalNeg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
           
        
        }



        private void btnNuevaNovedad_Click(object sender, EventArgs e)
        {
           
                       
        }
     
    public ro_Empleado_Novedad_Info Info_Novedad = new ro_Empleado_Novedad_Info();

     public void getInfo()
       {
           try
           {
                Info_Novedad.IdEmpresa = param.IdEmpresa;
                Info_Novedad.IdNomina_Tipo = _idNominaTipo;
                Info_Novedad.IdNomina_TipoLiqui = _idNominaTipoLiqui;
                Info_Novedad.IdEmpleado = Info.IdEmpleado;     
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
               Log_Error_bus.Log_Error(ex.ToString());
           }
               
        }

     ro_Rol_Detalle_Info InfoEmpSalNeg = new ro_Rol_Detalle_Info();
    




 
  private void pu_CheckTodos()
  {
         try
         {
             if (band == 1)//POSITVOS
             {
                 foreach (var item in oRo_EmpleadoSaldoPositivo_Info)
                 {
                     item.check = false;
                     contador++;                     
                 }
                 gridControlConsEmp.RefreshDataSource();               
             }
             else            
             {
                 if (band == 2)//NEGATIVOS
                 {
                     foreach (var item in oRo_EmpleadoSaldoNegativo_Info)
                     {
                         item.check = false;
                         contador++;
                     }
                     
                     gridControlEmpSalNeg.RefreshDataSource();                  
                 }                                      
             }             
         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.ToString());
             Log_Error_bus.Log_Error(ex.ToString());
         }         
     }

  private void toolStripButton1_Click(object sender, EventArgs e){}

  private void gridControlIng_Click(object sender, EventArgs e)
     {

     }

 



     private void toolStripComboBoxImprimir_Click(object sender, EventArgs e)
     {

     }




     private void pu_GetEmpleadosSaldoNegativo(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo)
     {
         try
         {
             List<ro_Empleado_Info> tmp = new List<ro_Empleado_Info>();
 
             //PERMITE CARGAR UNICAMENTE LOS EMPLEADOS ACTIVOS Y CON SALDO NEGATIVO
             tmp = OEmplBus.Get_List_Empleado_Info_PorNominaSaldoNegativo(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref mensaje).Where(v => v.em_status != "EST_LIQ" && v.em_status != "EST_PLQ").ToList();

             oRo_EmpleadoSaldoPositivo_Info = (from a in tmp
                                               where a.checkSaldoNegativo == false
                                               select a).ToList();



             //EMPLEADOS CON SALDO POSITIVO
             gridControlConsEmp.DataSource = oRo_EmpleadoSaldoPositivo_Info;

            // GENERO LOS ROL INDIVIDUAL
             foreach (var item in oRo_EmpleadoSaldoPositivo_Info)
             {
                 setInfo(item);


                 
             }
             oRo_EmpleadoSaldoNegativo_Info=(from a in tmp
                                                where a.checkSaldoNegativo == true
                                                select a).ToList();

             //EMPLEADOS CON SALDO NEGATIVO
             gridControlEmpSalNeg.DataSource = oRo_EmpleadoSaldoNegativo_Info;


         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.ToString());
             Log_Error_bus.Log_Error(ex.ToString());
         }
     }



     private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
     {





     }


     private void gridViewNegativos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
     {
         try
         {
             //band = 1;
             pu_CheckTodos();
             //gridViewEmp.SetFocusedRowCellValue(check, true);


             if (e.HitInfo.Column.Name == "colCheck")
             {
                 if ((bool)gridViewNegativos.GetFocusedRowCellValue(colCheck))
                 {
                     gridViewPositivos.SetFocusedRowCellValue(colCheck, false);

                     this.txtCedula.Text = "";
                     this.txtNombre.Text = "";
                     this.txtDepartamento.Text = "";
                     this.txtCargo.Text = "";
                     this.txtCodigo.Text = "";


                     //limpia gridControl
                     this.DataSource = new BindingList<ro_Empleado_Novedad_Info>();
                     this.gridControlIng.DataSource = DataSource;
                     this.gridControlEgr.DataSource = DataSource;

                   
                     this.lblTotalRecibir.Text = "Neto a Recibir:  $0.00";

                     // this.cmbTipoNomina.Enabled = false;
                 }
                 else
                 {
                     if (cmbnomina.EditValue== null)
                     {
                         MessageBox.Show("Ingrese el tipo de nómina", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                         return;
                     }
                     else
                     {
                         if (cmbnominaTipo.EditValue == null)
                         {
                             MessageBox.Show("Ingrese el tipo de proceso", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                             return;
                         }
                         else
                         {
                             if (cmbPeriodos.EditValue == null)
                             {
                                 MessageBox.Show("Ingrese el periodo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                 return;
                             }
                             else
                             {
                                 band = 2;

                                 pu_CheckTodos();

                                 gridViewNegativos.SetFocusedRowCellValue(colCheck, true);

                                 ro_Empleado_Info info = (ro_Empleado_Info)this.gridViewNegativos.GetFocusedRow();
                                 setInfo(info);
                                 
                             }
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



  
     private void frmRo_Liquidacion_x_Rol_Empleado_KeyPress(object sender, KeyPressEventArgs e)
     {
         
     }

    

     private void cmdNuevoNovedad_Click(object sender, EventArgs e)
     {
         try
         {

            


             pu_AbrirNovedad();




         }
         catch (Exception ex)
         {
             
             MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
         }
     }

     private void cmdNuevoPrestamos_Click(object sender, EventArgs e)
     {
         
         try
         {
             pu_AbrirPrestamos(); 
         }
         catch (Exception ex)
         {
             
 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
         }
     }

     private void cmdActualizar_Click(object sender, EventArgs e)
     {
         try
         {
         }
         catch (Exception ex)
         {
             
             MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
         } 

     }


     private void pu_Imprimir()
     {
         try
         {
             if (Info != null) {
                 pu_CargarValores();

                 XROL_Rpt003_rpt oXROL_Rpt003_frm = new XROL_Rpt003_rpt();
                 oXROL_Rpt003_frm.Parameters["s_idEmpresa"].Value=_idEmpresa;
                  oXROL_Rpt003_frm.Parameters["s_idEmpleado"].Value=Info.IdEmpleado;
                  oXROL_Rpt003_frm.Parameters["s_idNominaTipo"].Value=_idNominaTipo;
                  oXROL_Rpt003_frm.Parameters["s_idNominaTipoLiqui"].Value=_idNominaTipoLiqui;
                  oXROL_Rpt003_frm.Parameters["s_idPeriodo"].Value = _idPeriodo;
                 

                 oXROL_Rpt003_frm.ShowPreview();
             }
     
         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.ToString());
             Log_Error_bus.Log_Error(ex.ToString());
         }


     }

     private void cmbnomina_EditValueChanged(object sender, EventArgs e)
     {
         try
         {
             ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
             cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

         }
         catch (System.Exception ex)
         {

             MessageBox.Show(ex.ToString());
         }
     }

     private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
     {
         try
         {
             listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
             cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
         }
         catch (System.Exception ex)
         {

             MessageBox.Show(ex.ToString());
         }
     }

     private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
     {
         try
         {
             splashScreenManagerEsperar.ShowWaitForm();
            
             




             _idNominaTipo = Convert.ToInt32(cmbnomina.EditValue);
             _idNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
             _idPeriodo = Convert.ToInt32(cmbPeriodos.EditValue == null ? 0 : Convert.ToInt32(cmbPeriodos.EditValue));
             _idEmpresa = param.IdEmpresa;
             List<ro_Empleado_Info> tmp = new List<ro_Empleado_Info>();

             //PERMITE CARGAR UNICAMENTE LOS EMPLEADOS ACTIVOS Y CON SALDO NEGATIVO
             tmp = OEmplBus.Get_List_Empleado_Info_PorNominaSaldoNegativo(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo, ref mensaje).Where(v => v.em_status != "EST_LIQ" && v.em_status != "EST_PLQ").ToList();

             oRo_EmpleadoSaldoPositivo_Info = (from a in tmp
                                               where a.checkSaldoNegativo == false
                                               select a).ToList();

             oRo_EmpleadoSaldoNegativo_Info = (from a in tmp
                                              where a.checkSaldoNegativo == true
                                              select a).ToList();
             
             //EMPLEADOS CON SALDO POSITIVO
             gridControlConsEmp.DataSource = oRo_EmpleadoSaldoPositivo_Info;
             gridControlEmpSalNeg.DataSource = oRo_EmpleadoSaldoNegativo_Info;

             List<ro_Rol_Detalle_Info> tm_registro = new List<ro_Rol_Detalle_Info>();
             tm_registro = ro_rol_detalle_Bus.Get_List_Ing_Egr_x_Empleado_x_Ingresos(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo);

             ListEgre = tm_registro.Where(v => v.ru_tipo == "E").ToList();
             
             ListIng = tm_registro.Where(v => v.ru_tipo == "I").ToList();

             splashScreenManagerEsperar.CloseWaitForm();


         }
         catch (Exception ex)
         {

             MessageBox.Show(ex.ToString());
             Log_Error_bus.Log_Error(ex.ToString());
         }
     }

          
    }
}
