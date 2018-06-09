using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Business.Inventario ;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_PuenteGruaMovilizacion_Mantenimiento : Form
    {

        public FrmPrd_PuenteGruaMovilizacion_Mantenimiento()
        {
            try
            {
                InitializeComponent();
                infoparametros = busParametros.ObtenerObjeto(param.IdEmpresa);
                iniciar_controles();
                ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
               // UCSucursal.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
            
                cargacombos();

                //gridControlDisponible.DataSource = ListadoDisponible;
            
                event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing += FrmPrd_PuenteGruaMovilizacion_Mantenimiento_event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing;
                //cargacombos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        #region variables
        string msg = "";

        UCPrd_Obra UCObra = new UCPrd_Obra();  
     
        // instancias Info
        prd_MovPteGrua_Info Info = new prd_MovPteGrua_Info(); //esta es para el get
        prd_ProcesoProductivo_x_prd_obra_Info InfoModelo = new prd_ProcesoProductivo_x_prd_obra_Info();
        prd_parametros_CusCidersus_Info infoparametros = new prd_parametros_CusCidersus_Info();
        tb_Sucursal_Info _sucursal = new tb_Sucursal_Info();
        prd_SubGrupoTrabajo_Info GrupoTrabajoInfo = new prd_SubGrupoTrabajo_Info();
        in_movi_inve_detalle_x_Producto_CusCider_Info InfoProducto = new in_movi_inve_detalle_x_Producto_CusCider_Info();
               // instancias Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        prd_ProcesoProductivo_x_prd_obra_Bus BusModeloxCC = new prd_ProcesoProductivo_x_prd_obra_Bus();
        prd_Operador_Bus BusOperador = new prd_Operador_Bus();
        prd_PuenteGrua_Bus BusPuenteGrua = new prd_PuenteGrua_Bus();
        prd_OrdenTaller_Bus BusOT = new prd_OrdenTaller_Bus();
        prd_EtapaProduccion_Bus BusEta = new prd_EtapaProduccion_Bus();
        prd_parametros_CusCidersus_Bus busParametros = new prd_parametros_CusCidersus_Bus();
        prd_PuenteGruaMovimiento_Bus MovimientoPuenteGrua_Bus = new prd_PuenteGruaMovimiento_Bus();
        prd_EtapaProduccion_Bus BusEtapas = new prd_EtapaProduccion_Bus();
        prd_SubGrupoTrabajo_Bus BusGrupoTrabajo = new prd_SubGrupoTrabajo_Bus();
        prd_ProcesoProductivo_Bus BusProcesoProductivo = new prd_ProcesoProductivo_Bus();
        prd_SubGrupoTrabajoDetalle_Bus BusDetalleGT = new prd_SubGrupoTrabajoDetalle_Bus();
        in_producto_Bus BusProduct = new in_producto_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Bus BusTablaIntermedia = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        //Listas
        List<prd_PuenteGrua_Info> ListadoPuenteGrua = new List<Info.Produc_Cirdesus.prd_PuenteGrua_Info>();
        BindingList<prd_MovPteGrua_Det_Info> Prod = new BindingList<prd_MovPteGrua_Det_Info>();
        BindingList<prd_MovPteGrua_Det_Info> ListadoDisponible = new BindingList<prd_MovPteGrua_Det_Info>();
        List<prd_EtapaProduccion_Info> ListadosEtapas = new List<Info.Produc_Cirdesus.prd_EtapaProduccion_Info>();
        List<prd_SubGrupoTrabajo_Info> ListadoGrupoTrbajo = new List<prd_SubGrupoTrabajo_Info>();
        List<prd_ProcesoProductivo_Info> ListadoProcesoProductivo = new List<prd_ProcesoProductivo_Info>();
        List<prd_SubGrupoTrabajoDetalle_Info> DetalleGrupoTrabajo = new List<prd_SubGrupoTrabajoDetalle_Info>();

        //instancias generales
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();


        #endregion 

        void FrmPrd_PuenteGruaMovilizacion_Mantenimiento_event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e){}
        public delegate void delegate_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing;
        private void FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        //this.btnGrabar.Text = "Grabar Registro";
                        //this.btnGrabarySalir.Text = "Grabar y Salir";
                        
                      //  txtIdMov.Text = "00000";
                        break;
                   case Cl_Enumeradores.eTipo_action.consultar:
                        //this.btnGrabar.Enabled = false;
                        //this.btnGrabarySalir.Enabled = false;
                        bloquearcab();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            Accion = iAccion;
           
        }

        void cargacombos()
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString()); 
            }
        
        
        }
        private void bloquearcab()
        {
            try
            {
                ucGe_Sucursal_combo1.Enabled = false;
                UCObra.UC_Obra.Enabled = false;
                


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
             
            }
        }
        private void iniciar_controles()
        {
            try
            {
                UCObra.cargaCmb_Obra();
               // PanelObra.Controls.Add(UCObra);
                UCObra.Dock = DockStyle.Fill;
                UCObra.Event_UCObra_SelectionChanged += new UCPrd_Obra.delegadoUCObra_SelectionChanged(UCObra_Event_UCObra_SelectionChanged);
               // UCObra.UC_Obra.SelectedIndex = 0;
                cargaobras();
                //UCSucursal.cargar_sucursal(param.IdEmpresa);
                _sucursal.IdEmpresa = param.IdEmpresa;
                _sucursal.IdSucursal = infoparametros.IdSucursal_Produccion;
                ucGe_Sucursal_combo1.set_SucursalInfo(_sucursal.IdSucursal);
               // PanelSuc.Controls.Add(UCSucursal);
                //UCSucursal.Dock = DockStyle.Fill;
                //UCSucursal.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(UCSucursal_Event_cmb_sucursal_SelectionChangeCommitted);
                //UCObra.label.Location = new Point(6, 0);
                //UCObra.UC_Obra.Location = new Point(110, 1);
                //UCObra.UC_Obra.Size = new System.Drawing.Size(308, 20);
               // UCSucursal.label1.Location = new Point(6, 3);
                
                //ucGe_Sucursal_combo1.cmb_sucursal.DropDownStyle = ComboBoxStyle.DropDown;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString()); 
            }
        }

        void UCSucursal_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                ListadoDisponible = new BindingList<prd_MovPteGrua_Det_Info>();
                //gridControlDisponible.DataSource = ListadoDisponible;
               // gridControlDisponible.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
            
        }

        void UCObra_Event_UCObra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
               cargaobras();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       void cargaobras()
       {

           try
           {

               if (UCObra.get_item_info() != null)
               {
                   string obra = UCObra.get_item();
                   InfoModelo = BusModeloxCC.Obtener1ProcesProductivo_x_CentroCosto(param.IdEmpresa, obra);
                   if (InfoModelo.IdProcesoProductivo != 0)
                   {
                       //cmbOperador.Value = InfoModelo.IdProcesoProductivo;
                       CargaDatos(UCObra.get_item(), InfoModelo.IdProcesoProductivo);
                   }
               }

           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
           }
       
       }

        private void CargaDatos(string CodObra, int IdModelo)
        {
             try
            {
                

               // InfoModelo = BusModeloxCC.Obtener1ProcesProductivo_x_CentroCosto(param.IdEmpresa, IdCentroCosto);
               // txtModProd.Text = InfoModelo.NombreModelo;

                 // ComboEtaInicial
               
                //if (cmbEtInicial.SelectedIndex == -1)
                //    cmbEtInicial.SelectedIndex = 0;


                
                 // ComboEtafinal
                
               
                
             
             //   this.cmbOrdenTaller.Properties.DataSource = BusOT.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, CodObra);
                
               


            }
            catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        
        
        }

        public void LlenarSaldos()
        {
            try
            {
               int calculosaldofin = 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

       

        }

        List<prd_MovPteGrua_Det_Info> LstMovPteGruaDet = new List<prd_MovPteGrua_Det_Info>();
      



        private Boolean grabar()
        {
            try
            {               
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            Get();
                            if (MovimientoPuenteGrua_Bus.GrabarDB(Info, ref msg))
                            {
                                MessageBox.Show("Se procedio a grabar el Reg.# " + txtidMovimiento.Text, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                            }
                            else
                            {
                                MessageBox.Show("No procedio a grabar el Reg.# " + txtidMovimiento.Text, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                          
                            return true;
                            
                        case Cl_Enumeradores.eTipo_action.actualizar:
                             Get();


                            if (MovimientoPuenteGrua_Bus.ModificarDB(Info, ref msg))
                            {
                               
                                set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                MessageBox.Show("Se procedio a grabar el Reg.#" + txtidMovimiento.Text, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                             else
                            {
                                MessageBox.Show("No procedio a grabar el Reg.# " + txtidMovimiento.Text, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return true;
                            
                        default:
                            return false;
                    }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private Boolean Get()
        {
            try
            {
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                Info.IdPuenteGrua =Convert.ToInt32(cmbPteGrua.EditValue);
                Info.IdOperador =Convert.ToInt32(cmbOperador.EditValue);
                Info.IdOperador =Convert.ToInt32( cmbOperador.EditValue);
                Info.IdProcesoProductivo = Convert.ToInt32(cmbProcesoProductivo.EditValue);
                Info.IdMovimiento =Convert.ToInt32( txtidMovimiento.Text);
                Info.IdEtapaInicio = Convert.ToInt32(CmbEtapaInicial.EditValue);
                Info.IdEtapaSiguiente = Convert.ToInt32(cmbetapaSiguiente.EditValue);
                Info.CodigoBarra = txtCodigoBarra.Text;
                Info.DescripcionPieza = txtdescripcion.Text;
                Info.ToneladasMover =Convert.ToInt32( txttoneladas.Text);
                Info.Observacion = txtObservacion.Text;
                Info.FechaTransaccion = dtPFechaReg.Value;
                Info.IdUsuario = param.IdUsuario;
                if (checkBoxEstado.Checked == true)
                {
                    Info.Estado = "A";
                }
                else
                {
                    Info.Estado = "I";
                }
               // Info.IdGrupoTrabajo =Convert.ToInt32( CmbGrupoTrabajo.EditValue);
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
        
        private Boolean validaciones()
        {
            try
            {

               
               
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaObjetos())
                    return;
             grabar();
                
                
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
                if (ValidaObjetos())
                    return;
                grabar();
                this.Close();
               
            }
            catch (Exception ex)
            {
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

        private Boolean  validar()
        {
            try
            {
                
                    //if (UCObra.get_item_info() == null)
                    //{
                    //    MessageBox.Show("Debe seleccionar la Obra Asignada y la Orden de Taller", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    PanelObra.Focus();
                        

                   // }
                    //else if (UCObra.get_item_info() == null)
                    //{
                    //    MessageBox.Show("Debe seleccionar la Obra Asignada y la Orden de Taller", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    PanelObra.Focus();
                    //    return false;

                    //}
                    //else if (cmbOrdenTaller.EditValue == null || cmbOrdenTaller.EditValue == "")
                    //{
                    //    MessageBox.Show("Debe seleccionar la Orden de Taller Asignada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    cmbOrdenTaller.Focus();
                    //    return false;

                  //  }
                   
                    
                    return true;
                   
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); return false;
            }
        }
  
        List<vwprd_MovPteGruaSaldo_Info> LstSaldos = new List<vwprd_MovPteGruaSaldo_Info>();
        in_producto_Bus busProd = new in_producto_Bus(); 
        prd_OrdenTaller_Bus busOT = new prd_OrdenTaller_Bus();
        prd_OrdenTaller_Info OT = new prd_OrdenTaller_Info();
        List<prd_EtapaProduccion_Info> ListEtapas = new List<prd_EtapaProduccion_Info>();


        private void cmbEtInicial_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmPrd_PuenteGruaMovilizacion_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();


               
                
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error "+ex.Message);
            }
        }

        List<vwprd_Ensamblado_CabDet_CusCider_Info> LstEnsab = new List<vwprd_Ensamblado_CabDet_CusCider_Info>();
        prd_Ensamblado_CusCider_Bus BusEnsa = new prd_Ensamblado_CusCider_Bus();

     
        Boolean preguntar = false;
        private void txtIngCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewDisponible_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Checked")
                {
                    KeyPressEventArgs v = new KeyPressEventArgs(Convert.ToChar("\r"));

                    //
                    if (Convert.ToBoolean(e.CellValue) == true)
                    {
                        //  gridViewDisponible.SetFocusedRowCellValue("Checked", false);
                    }
                    else
                    {

                      

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbOrdenTaller_EditValueChanged(object sender, EventArgs e)
        {
           
        }


        public void CargarCombos()
        {
            try
            {
                ListadoPuenteGrua = BusPuenteGrua.ListadoPuenteGrua(param.IdEmpresa);
                cmbPteGrua.Properties.DataSource = ListadoPuenteGrua;
                cmbOperador.Properties.DataSource = BusOperador.ListadoOperadores();
                cmbPteGrua.EditValue = ListadoPuenteGrua.FirstOrDefault().idPuenteGrua;
                cmbOperador.EditValue = ListadoPuenteGrua.FirstOrDefault().IdOperador;
              // cargar etapas
                ListadosEtapas = BusEtapas.ObtenerListaEtapas(param.IdEmpresa);
                CmbEtapaInicial.Properties.DataSource = ListadosEtapas;
                cmbetapaSiguiente.Properties.DataSource = ListadosEtapas;


                ListadoProcesoProductivo = BusProcesoProductivo.ObtenerProcesProductivo(param.IdEmpresa);
                cmbProcesoProductivo.Properties.DataSource = ListadoProcesoProductivo;

               
               
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error "+ex.Message);
            }
        }




        public void SetInfo(prd_MovPteGrua_Info Info)
        {
            try
            {
                txtdescripcion.Text = Info.DescripcionPieza;
              //  txtdestino.Text = Info.Destino;
               // txtOrigen.Text = Info.Origen;
                txtObservacion.Text = Info.Observacion;
                cmbOperador.EditValue=Info.IdOperador;
                cmbPteGrua.EditValue=Info.IdPuenteGrua;
                //cmbOrdenTaller.EditValue=Info.IdOrdenTaller;
                txtCodigoBarra.Text=Info.CodigoBarra;
                dtPFechaReg.Value=Info.FechaTransaccion;
                if(Info.Estado=="A")
                {
                   checkBoxEstado.Checked=true;
                }
                else
                {
                    checkBoxEstado.Checked=false;
                }
                txtidMovimiento.Text =Convert.ToString( Info.IdMovimiento);
              //  cmbOrdenTaller.EditValue = Info.IdOrdenTaller;
                txttoneladas.Text = Convert.ToString(Info.ToneladasMover);
              //  cmbOperador.EditValue = Info.IdOperador;

            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error "+ex.Message);
            }
        }


        public void GetIdMovimiento()
        {
            try
            {
               txtidMovimiento.Text=Convert.ToString( MovimientoPuenteGrua_Bus.getIdMovimiento(ref msg));

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error "+ex.Message);
            }
        }




        public bool ValidaObjetos()
        {
            bool B_Valida = false;
            try
            {
                if (cmbPteGrua.Text == "")
                {
                    errorPValidaObjetos.SetError(cmbPteGrua, "Escoja Puente Grua");
                    B_Valida = true;
                }

                if (cmbOperador.Text == "")
                {
                    errorPValidaObjetos.SetError(cmbOperador, "Selecione Operador");
                    B_Valida = true;
                }
                //if (cmbOrdenTaller.Text == "")
                //{
                //    errorPValidaObjetos.SetError(cmbOrdenTaller, "Escoja Orden de Taller");
                //    B_Valida = true;
                //}


                //if (txtOrigen.Text == "")
                //{
                //    errorPValidaObjetos.SetError(txtOrigen, "Ingrese Origen");
                //    B_Valida = true;
                //}



                //if (txtdestino.Text == "")
                //{
                //    errorPValidaObjetos.SetError(txtdestino, "Ingrese Destino");
                //    B_Valida = true;
                //}

                if (txttoneladas.Text == "")
                {
                    errorPValidaObjetos.SetError(txttoneladas, "Ingrese Tonelada ha mover");
                    B_Valida = true;
                }

                if (txtCodigoBarra.Text == "")
                {
                    errorPValidaObjetos.SetError(txtCodigoBarra, "Ingrese producto a mover");
                    B_Valida = true;
                }

                if (txtdescripcion.Text == "")
                {
                    errorPValidaObjetos.SetError(txtdescripcion, "Ingrese detalle producto a mover");
                    B_Valida = true;
                }


                return B_Valida;
            }
            catch (Exception)
            {

                return B_Valida;

            }
        }

        private void cmbPteGrua_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error "+ex.Message);
            }
        }


        private void cmbProcesoProductivo_EditValueChanged(object sender, EventArgs e)
        {
            try
            { var EtapasF = from item in ListadosEtapas
                              where item.IdProcesoProductivo ==Convert.ToInt32( cmbProcesoProductivo.EditValue)
                              select item;
                ListadosEtapas = EtapasF.ToList();
                CmbEtapaInicial.Properties.DataSource = ListadosEtapas;
                cmbetapaSiguiente.Properties.DataSource = ListadosEtapas;

            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error "+ex.Message);
            }
        }

        private void CmbEtapaInicial_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DetalleGrupoTrabajo = BusDetalleGT.ObtenerGrupoTrabDetalle(Convert.ToInt32(CmbEtapaInicial.EditValue), Convert.ToInt32(cmbProcesoProductivo.EditValue));//
                gridControlEtapaInicial.DataSource = DetalleGrupoTrabajo;
               // gridControlEtapaInicial.DataSource=
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error "+ex.Message);
            }
        }

        private void cmbetapaSiguiente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DetalleGrupoTrabajo = BusDetalleGT.ObtenerGrupoTrabDetalle(Convert.ToInt32(CmbEtapaInicial.EditValue), Convert.ToInt32(cmbProcesoProductivo.EditValue));
                gridControlEtapaSiguiente.DataSource = DetalleGrupoTrabajo;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    BuscarProducto(e.KeyChar);
                }
             }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message);
            }

        }


        public void BuscarProducto( int codAscii)
        {
            try
            {
               
                 if (txtCodigoBarra.Text == "")
                 {
                     MessageBox.Show("Ingrese Codigo Barra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
                 }
                 InfoProducto = BusTablaIntermedia.TraeProductoxCodigoBarra( txtCodigoBarra.Text,param.IdEmpresa);
                if (InfoProducto.IdProducto == 0)
                {
                    MessageBox.Show("El Codigo Barra no Esta Asignado a un Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtdescripcion.Text = InfoProducto.pr_descripcion;
                    txttoneladas.Text = Convert.ToString(InfoProducto.pr_peso);
                    txtObservacion.Text = InfoProducto.pr_Observacion;
                }
            }

            
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        
    }
}
