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

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Periodos_x_Nomina_Mant : Form
    {
        #region Declaraciones
        //Listas        
        BindingList<ro_periodo_Info> LstInfoIzquir = new BindingList<ro_periodo_Info>();
        BindingList<ro_periodo_Info> ListaPeriodosdisponibles = new BindingList<ro_periodo_Info>();


        BindingList<ro_periodo_Info> Derecha = new BindingList<ro_periodo_Info>();
        
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> lista;

        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Nomina_Tipo_Bus Bus_TipoNo = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus Bus_TipoNominaLiqui = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus Bus_PerNomTipoliq = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
        ro_periodo_Bus Bus_Rubro = new ro_periodo_Bus();

        //BindingList
        BindingList<ro_periodo_Info> PeriodoAsig = new BindingList<ro_periodo_Info>();     
        BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info> PeriodoAsignado = new BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info> PeriodoDisponible = new BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
   
       //Variables
        string Mensaje = "";
        int IdNomina = 0;
        int IdProceso = 0;
        #endregion

        public frmRo_Periodos_x_Nomina_Mant()
        {
            try
            {
               InitializeComponent();
               ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
               ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
               ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
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
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.ucGe_Menu_event_btnGuardar_Click(sender, e);
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }   
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    int msg = 0;
                    int focus = gridViewPerAsignado.FocusedRowHandle;
                    gridViewPerAsignado.FocusedRowHandle = focus + 1;

                    lista = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
                    lista = Bus_PerNomTipoliq.ConsultaPerNomTipLiq(param.IdEmpresa, IdNomina, IdProceso);

                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No existen períodos que guardar, revise por favor","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }

                    foreach (var item in lista)
                    {
                        ro_periodo_x_ro_Nomina_TipoLiqui_Info Info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

                        Info.IdEmpresa = param.IdEmpresa;
                        Info.IdPeriodo = item.IdPeriodo;
                        Info.IdNomina_Tipo = Convert.ToInt32(this.cmbNomina.EditValue);
                        Info.IdNomina_TipoLiqui = Convert.ToInt32(this.cmbProceso.EditValue);

                        if (Bus_PerNomTipoliq.ModificarDB(Info) == false)
                        {
                            MessageBox.Show("Imposible guardar el registro, revise por favor la nómina o el proceso", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        msg++;
                    }

                    if (msg > 0) MessageBox.Show("El registro ha sido guardado con éxito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
             }       
        }

        void LoadDatos()
        {

            try
            {
                // Cargando Combo de Tipo de Nomina
                List<ro_Nomina_Tipo_Info> InfoTipoNomina = new List<ro_Nomina_Tipo_Info>();
                InfoTipoNomina = Bus_TipoNo.Get_List_Nomina_Tipo(param.IdEmpresa);
                this.cmbNomina.Properties.DataSource = InfoTipoNomina;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
             }
                         
        }
 
        private void frmRo_Periodos_x_Nomina_Mant_Load(object sender, EventArgs e)
        {
                      
            try
            {
                LoadDatos();          
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }                               
        }
        
        private void btnDerechaUno_Click(object sender, EventArgs e)
        {          
            try
            {
                if (Validar())
                {
                   ro_periodo_Info Item = (ro_periodo_Info)gridViewPerDisponible.GetFocusedRow();
                
                    if (Item != null)
                    {
                        if (Item.check == true)
                        {
                            PeriodoAsig = new BindingList<ro_periodo_Info>();
                            PeriodoAsig.Add(Item);
                            ro_periodo_x_ro_Nomina_TipoLiqui_Info Info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
                            Info.IdEmpresa = param.IdEmpresa;
                            Info.IdPeriodo = Item.IdPeriodo;
                            Info.IdNomina_Tipo = Convert.ToInt32(this.cmbNomina.EditValue);
                            Info.IdNomina_TipoLiqui = Convert.ToInt32(this.cmbProceso.EditValue);
                            Bus_PerNomTipoliq.GuardarDB(Info);
                            cmbNomina.EditValue = null;
                            cmbProceso.EditValue = null;
                            cmbNomina.EditValue = Info.IdNomina_Tipo;
                            cmbProceso.EditValue = Info.IdNomina_TipoLiqui;
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

        private void cmbNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbNomina.EditValue != null)
                {
                   
                    IdNomina = Convert.ToInt32(cmbNomina.EditValue);
                    
                    List<ro_Nomina_Tipoliqui_Info> InfoNominaTipoliqui = new List<ro_Nomina_Tipoliqui_Info>();
                    InfoNominaTipoliqui = Bus_TipoNominaLiqui.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, IdNomina);
                    cmbProceso.Properties.DataSource = InfoNominaTipoliqui; 
                    
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewPerDisponible_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e){}

        private void btnDerechaTodos_Click(object sender, EventArgs e)
        {
            try
            {
               if(Validar())
               {


                   LstInfoIzquir = (BindingList<ro_periodo_Info>)gridControlPerDisponible.DataSource;
                            
                   int nomina = 0;
                   int proceso = 0;
                   nomina = Convert.ToInt32(this.cmbNomina.EditValue); 
                   proceso = Convert.ToInt32(this.cmbProceso.EditValue);
               
                   foreach (var item in LstInfoIzquir)
                  {
                      if (item.check == true)
                      {
                          ro_periodo_x_ro_Nomina_TipoLiqui_Info Info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

                          Info.IdEmpresa = param.IdEmpresa;
                          Info.IdPeriodo = item.IdPeriodo;
                          Info.IdNomina_Tipo = Convert.ToInt32(this.cmbNomina.EditValue);
                          Info.IdNomina_TipoLiqui = Convert.ToInt32(this.cmbProceso.EditValue);

                          Bus_PerNomTipoliq.GuardarDB(Info);
                      }
                                   
                }
               
                   if (LstInfoIzquir != null && LstInfoIzquir.Count > 0)
                   {
                       cmbNomina.EditValue = null;
                       cmbProceso.EditValue = null;
                       cmbNomina.EditValue = nomina;
                       cmbProceso.EditValue = proceso;
                   }               
               }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }                       
        }

        private void btnIzquierdaTodos_Click(object sender, EventArgs e)
        {                  
            try
            {
               if(Validar())
               {

                   lista = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
                   lista = Bus_PerNomTipoliq.ConsultaPerNomTipLiq(param.IdEmpresa, IdNomina, IdProceso);
                                                                                                                                                                                                                           
                   PeriodoAsignado = new BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info>(lista);   
             
                   int nomina = 0;
                   int proceso = 0;
                   nomina = Convert.ToInt32(this.cmbNomina.EditValue);
                   proceso = Convert.ToInt32(this.cmbProceso.EditValue);
                foreach (var item in PeriodoAsignado)
                {
                    
                    PeriodoDisponible.Add(item);
                    ro_periodo_x_ro_Nomina_TipoLiqui_Info Info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

                    Info.IdEmpresa = param.IdEmpresa;
                    Info.IdPeriodo = item.IdPeriodo;
                    Info.IdNomina_Tipo = Convert.ToInt32(this.cmbNomina.EditValue);
                    Info.IdNomina_TipoLiqui = Convert.ToInt32(this.cmbProceso.EditValue);

                    Bus_PerNomTipoliq.Borrar(Info, ref Mensaje);

                    gridControlPerDisponible.DataSource = null;                            
                }

                if (PeriodoAsignado != null && PeriodoAsignado.Count > 0)
                {
                    cmbNomina.EditValue = null;
                    cmbProceso.EditValue = null;
                    cmbNomina.EditValue = nomina;
                    cmbProceso.EditValue = proceso;
                }              
               }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }                                                                        
        }
     
        private void gridViewPerAsignado_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e){}
 
        private void btnIzquierdaUno_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                                                     
                   ro_periodo_x_ro_Nomina_TipoLiqui_Info Item = (ro_periodo_x_ro_Nomina_TipoLiqui_Info)gridViewPerAsignado.GetFocusedRow();

                    if (Item != null)
                    {

                        PeriodoDisponible = new BindingList<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
                        PeriodoDisponible.Add(Item);
                        ro_periodo_x_ro_Nomina_TipoLiqui_Info Info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

                        Info.IdEmpresa = param.IdEmpresa;
               
                        Info.IdPeriodo = Item.IdPeriodo;
                        Info.IdNomina_Tipo = Convert.ToInt32(this.cmbNomina.EditValue);
                        Info.IdNomina_TipoLiqui = Convert.ToInt32(this.cmbProceso.EditValue);

                        if ((Bus_PerNomTipoliq.Borrar(Info, ref Mensaje)) == false)
                        {
                            MessageBox.Show(Mensaje, "Sistemas");                                        
                        }
                        else 
                        {
                            cmbNomina.EditValue = null;
                            cmbProceso.EditValue = null;
                            cmbNomina.EditValue = Info.IdNomina_Tipo;
                            cmbProceso.EditValue = Info.IdNomina_TipoLiqui;
                                            
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
                if (this.cmbNomina.EditValue == "" || this.cmbNomina.EditValue == null)
                {
                    MessageBox.Show("Ingrese la Nómina, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                else
                {
                    if (this.cmbProceso.EditValue == "" || this.cmbProceso.EditValue == null)
                    {
                        MessageBox.Show("Ingrese el Proceso, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void cmbProceso_EditValueChanged(object sender, EventArgs e)
        {
            Consultar_periodo();
        }


        public void Consultar_periodo()
        {
            try
            {
                gridControlPerAsignado.DataSource = null;
                gridControlPerDisponible.DataSource = null;
                if (cmbProceso.EditValue != null)
                {
                   if(check_mostar_periodo_asignados.Checked)
                   
                    LstInfoIzquir = new BindingList<ro_periodo_Info>(Bus_Rubro.Get_periodos(param.IdEmpresa));
                    else
                       LstInfoIzquir = new BindingList<ro_periodo_Info>(Bus_Rubro.Get_periodos_disponibles(param.IdEmpresa));

                    var TxEmpre = Bus_PerNomTipoliq.ConsultaPerNomTipLiq_Asignado(param.IdEmpresa, IdNomina, Convert.ToInt32(cmbProceso.EditValue));
                    var ids = from q in TxEmpre
                              select q.IdPeriodo;

                    if (ids.Count() != null && ids.Count() != 0)
                    {
                        
                            var Derecha = from q in LstInfoIzquir
                                          where ids.Contains(q.IdPeriodo)
                                          select q;
                            ListaPeriodosdisponibles = new BindingList<ro_periodo_Info>(Derecha.ToList());

                            gridControlPerDisponible.DataSource = ListaPeriodosdisponibles;
                       
                    }

                    lista = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
                    lista = Bus_PerNomTipoliq.ConsultaPerNomTipLiq(param.IdEmpresa, IdNomina, Convert.ToInt32(cmbProceso.EditValue));
                    gridControlPerAsignado.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmRo_Periodos_x_Nomina_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void checkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in ListaPeriodosdisponibles)
                {
                    if (checkSeleccionarTodos.Checked == true)
                    {
                        item.check = true;
                    }
                    else
                    {
                        item.check = false;
                    }
                    
                }

                gridControlPerDisponible.RefreshDataSource();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void check_mostar_periodo_asignados_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Consultar_periodo();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }      
    }
}
