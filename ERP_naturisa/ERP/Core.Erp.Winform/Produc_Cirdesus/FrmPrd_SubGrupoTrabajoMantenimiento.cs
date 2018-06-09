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
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using DevExpress.XtraEditors;


namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_SubGrupoTrabajoMantenimiento : Form
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //DELEGADO
        public delegate void delegate_FrmPrd_GrupoTrabajoMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_GrupoTrabajoMantenimiento_FormClosing EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing;
        List< prd_GrupoTrabajo_Info> ListaGt= new List<prd_GrupoTrabajo_Info>();
        prd_GrupoTrabajo_Bus BusGt= new prd_GrupoTrabajo_Bus();

        //instancias de Cabecera de GT
        prd_SubGrupoTrabajo_Info InfoCabeceraGT_Nueva = new prd_SubGrupoTrabajo_Info(); //esta es para el get
        prd_SubGrupoTrabajo_Bus BusCabeceraGT = new prd_SubGrupoTrabajo_Bus();

        //instancias de Detalle GT
        prd_SubGrupoTrabajoDetalle_Bus BusDetalleGT = new prd_SubGrupoTrabajoDetalle_Bus();
        List<prd_SubGrupoTrabajoDetalle_Info> LmInfoDetalleGT_Original = new List<prd_SubGrupoTrabajoDetalle_Info>(); //esta es del set
        List<prd_SubGrupoTrabajoDetalle_Info> _LmInfoDetalleGT_Nueva = new List<prd_SubGrupoTrabajoDetalle_Info>(); //esta es del get
        DataTable dt = new DataTable("detalle");
        List<prd_SubGrupoTrabajoDetalle_Info> DetGT = new List<prd_SubGrupoTrabajoDetalle_Info>();

        //instancias de centro de costo
        UCPrd_Obra UCObra = new UCPrd_Obra();

        //instancias de modelo produccion x centro costo
        prd_ProcesoProductivo_Bus BusModeloxCC = new prd_ProcesoProductivo_Bus();
        prd_EtapaProduccion_Bus BusEtapasProduccion = new prd_EtapaProduccion_Bus();

        //instancia de orden taller
        prd_OrdenTaller_Bus BusOT = new prd_OrdenTaller_Bus();
        DataTable dtOT = new DataTable("detalle");
        List<prd_OrdenTaller_Info> lmOT = new List<prd_OrdenTaller_Info>();
        //sucursal
        UCIn_Sucursal_Bodega UCSuc = new UCIn_Sucursal_Bodega();

        //instancias de empleado
        ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();

        //instancias generales
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;
        #endregion
        
        public FrmPrd_SubGrupoTrabajoMantenimiento()
        {
            try
            {
             InitializeComponent();
                cmb_empleado.DataSource = BusEmpleado.Get_List_Empleado_persona(param.IdEmpresa);
                EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing += new delegate_FrmPrd_GrupoTrabajoMantenimiento_FormClosing(FrmPrd_GrupoTrabajoMantenimiento_EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing);
                UCObra.Event_UCObra_SelectionChanged += new UCPrd_Obra.delegadoUCObra_SelectionChanged(UCObra_Event_UCObra_SelectionChanged);

                UCObra.Event_UCObra_EditValueChanged += UCObra_Event_UCObra_EditValueChanged;

                ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                UCObra.Event_UCObra_Validating += new UCPrd_Obra.delegadoUCObra_Validating(UCObra_Event_UCObra_Validating);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void UCObra_Event_UCObra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                setearcombos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void FrmPrd_GrupoTrabajoMantenimiento_EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing(object sender, FormClosingEventArgs e){}

        void UCObra_Event_UCObra_Validating(object sender, CancelEventArgs e)
        {
            try
            {
              setearcombos();
            }
            catch (Exception ex)
            { 
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void FrmPrd_GrupoTrabajoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                     EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing(sender, e);
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
                Accion = iAccion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       // this.btnGrabar.Text = "Grabar Registro";
                    //    this.btnGrabarySalir.Text = "Grabar y Salir";
                        this.lblAnulado.Visible = false;
                        this.txt_numGrupo.Text = "0";


                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        this.UCSuc.cmb_sucursal.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                        this.UCSuc.cmb_sucursal.Enabled = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                        this.UCSuc.cmb_sucursal.Enabled = false;

                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }


        private void iniciar_controles()
        {
            try
            {
                UCObra.cargaCmb_Obra();
              
                UCObra.Dock = DockStyle.Fill;
                UCObra.Event_UCObra_SelectionChanged += new UCPrd_Obra.delegadoUCObra_SelectionChanged(UCObra_Event_UCObra_SelectionChanged);
                cargaCmbE_Lider();

                UCSuc.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                UCSuc.cargar_sucursal(param.IdEmpresa);
                panelSucursal.Controls.Add(UCSuc);
                UCSuc.Dock = DockStyle.Fill;

                //size y location de controles
               // UCObra.label.Location = new Point(10, 0);
                UCObra.UC_Obra.Location = new Point(66, 1);
                UCObra.UC_Obra.Size = new System.Drawing.Size(290, 21);
                UCSuc.label1.Location = new Point(10, 4);
                UCSuc.cmb_sucursal.Location = new Point(66, 1);
                UCSuc.cmb_sucursal.Size = new Size(290, 21);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void setearcombos()
        {
            try
            {
                cmbEtapas.Properties.DataSource = null;
                cmbEtapas.Text = "";
                cmbModeloProductivo.Properties.DataSource = null;
                cmbModeloProductivo.Text = "";

                           
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


        }

        private void cargaCmbE_ModeloProduccion()
        {
            try
            {
                cmbModeloProductivo.Properties.DataSource = BusModeloxCC.ObtenerProcesProductivo(param.IdEmpresa);
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargaCmbE_EtapasProduccion(int IdModelo)
        {
            try
            {
                if (IdModelo != null)
                {

                    cmbEtapas.Properties.DataSource = BusEtapasProduccion.ObtenerListaEtapas(param.IdEmpresa, IdModelo);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

      

        private void cargaCmbE_Lider()
        {
            try
            {
                
                ultraCmbELiderGrupo.Properties.DataSource = BusEmpleado.Get_List_Empleado_persona(param.IdEmpresa);
                this.ultraCmbELiderGrupo.Properties.DisplayMember = "NomCompleto";
                this.ultraCmbELiderGrupo.Properties.ValueMember = "IdEmpleado";




                // grupos trabajos



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void UCObra_Event_UCObra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                setearcombos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        public void setCab(prd_SubGrupoTrabajo_Info info)
        {
            try
            {
                InfoCabeceraGT_Nueva = info;
                txt_numGrupo.Text = info.IdGrupoTrabajo.ToString().Trim();
                txt_nomGrupo.Text = info.Descripcion.Trim();
                UCObra.set_item(info.CodObra);
                ultraCmbELiderGrupo.EditValue = info.IdLider;
                UCSuc.cmb_sucursal.EditValue = info.IdSucursal;
                cmbEtapas.EditValue = info.IdEtapa;
                cmbModeloProductivo.EditValue = info.IdProcesoProductivo;
                cmbGrupoTrabajo.EditValue = info.idGrupo;
                cmbEtapas.EditValue = info.IdEtapa;
                if (info.Estado == "I")
                {
                    lblAnulado.Visible = true;
                    chkEstado.Checked = false;
                }
                else
                    chkEstado.Checked = true;

               
                setDet(info.CodObra, info.IdGrupoTrabajo);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public void setDet(string IdCentroCosto, decimal IdGrupoTrabajo)
        {
            try
            {
                LmInfoDetalleGT_Original = BusDetalleGT.ObtenerGrupoTrabDetalle(IdGrupoTrabajo, param.IdEmpresa, param.IdSucursal);
                carga_gridPre(LmInfoDetalleGT_Original);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        int sec = 1;

        private void carga_gridPre(List<prd_SubGrupoTrabajoDetalle_Info> lm)
        {
            try
            {
                if (lm.Count > 0)
                {


                    foreach (var item in lm)
                    {
                        gridViewGT.AddNewRow();
                        gridViewGT.SetFocusedRowCellValue(colCodObra, item.CodObra);
                        gridViewGT.SetFocusedRowCellValue(colIdEmpleado, item.IdEmpleado);
                        gridViewGT.SetFocusedRowCellValue(colIdEmpresa, item.IdEmpresa);
                        gridViewGT.SetFocusedRowCellValue(colIdGrupotrabajo, item.IdGrupotrabajo);
                        gridViewGT.SetFocusedRowCellValue(colIdSucursal, item.IdSucursal);
                        gridViewGT.SetFocusedRowCellValue(colObservacion, item.Observacion);


                    }

                }
                ///
   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void getCab()
        {
            try
            {
                InfoCabeceraGT_Nueva.IdEmpresa = param.IdEmpresa;
                InfoCabeceraGT_Nueva.IdSucursal = UCSuc.get_sucursal().IdSucursal;
                InfoCabeceraGT_Nueva.IdGrupoTrabajo = Convert.ToDecimal(txt_numGrupo.Text);
                InfoCabeceraGT_Nueva.CodObra = UCObra.get_item();
                InfoCabeceraGT_Nueva.IdProcesoProductivo = Convert.ToInt32(cmbModeloProductivo.EditValue);
                InfoCabeceraGT_Nueva.IdEtapa = Convert.ToInt32(cmbEtapas.EditValue);
               
                InfoCabeceraGT_Nueva.IdLider = Convert.ToDecimal(ultraCmbELiderGrupo.EditValue);
                InfoCabeceraGT_Nueva.Estado = (this.chkEstado.Checked == true) ? "A" : "I";
                InfoCabeceraGT_Nueva.Descripcion = txt_nomGrupo.Text.Trim();
                InfoCabeceraGT_Nueva.FechaCreacion = DateTime.Now;
                InfoCabeceraGT_Nueva.idGrupo = Convert.ToInt32( cmbGrupoTrabajo.EditValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
              
            }
        }

        private Boolean getDet()
        {
            try
            {
                DetGT = new List<prd_SubGrupoTrabajoDetalle_Info>();
                _LmInfoDetalleGT_Nueva = new List<prd_SubGrupoTrabajoDetalle_Info>();


                for (int i = 0; i <= gridViewGT.RowCount; i++)
                {
                    prd_SubGrupoTrabajoDetalle_Info infolider = new prd_SubGrupoTrabajoDetalle_Info();

                    var row = (prd_SubGrupoTrabajoDetalle_Info)gridViewGT.GetRow(i);
                    if (row != null)
                    {
                        prd_SubGrupoTrabajoDetalle_Info info = new prd_SubGrupoTrabajoDetalle_Info();
                        info.IdEmpleado = row.IdEmpleado;
                        info.Pe_NombreCompeto = row.Pe_NombreCompeto;
                        info.CodObra = InfoCabeceraGT_Nueva.CodObra;
                        info.IdEmpresa = InfoCabeceraGT_Nueva.IdEmpresa;
                        info.IdGrupotrabajo = InfoCabeceraGT_Nueva.IdGrupoTrabajo;
                        info.IdSucursal = InfoCabeceraGT_Nueva.IdSucursal;

                        info.Observacion = row.Observacion;

                        if (info.IdEmpleado == 0 || info.IdEmpleado == null)
                        {
                            MessageBox.Show("Debe seleccionar un empleado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;

                        }
                        else
                            info.IdEmpleado = row.IdEmpleado;
                        DetGT.Add(info);


                    }

                }
                DetGT = DetGT.FindAll(var => var.IdEmpleado != (decimal)ultraCmbELiderGrupo.EditValue);

                prd_SubGrupoTrabajoDetalle_Info lider = new prd_SubGrupoTrabajoDetalle_Info();
                lider.IdEmpleado = (decimal)ultraCmbELiderGrupo.EditValue;
                lider.Observacion = "Lider de Grupo";
                lider.CodObra = InfoCabeceraGT_Nueva.CodObra;
                lider.IdEmpresa = InfoCabeceraGT_Nueva.IdEmpresa;
                lider.IdGrupotrabajo = InfoCabeceraGT_Nueva.IdGrupoTrabajo;
                lider.IdSucursal = InfoCabeceraGT_Nueva.IdSucursal;

                DetGT.Add(lider);
                //}

                _LmInfoDetalleGT_Nueva = DetGT;



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
                txt_nomGrupo.Focus();
                if (validaciones() == true)
                {
                    MessageBox.Show("No se Guardó", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    grabar();
                }
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
                txt_nomGrupo.Focus();
                    if (validaciones() == false)
                    {
                        MessageBox.Show("No se Guardó", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        grabar();this.Close();
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
            
        }


        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                anular();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
      
        void anular()
        {
            try
            {
                string msg = "";
                InfoCabeceraGT_Nueva.Estado = "I";
                if (BusCabeceraGT.AnularReactiva(param.IdEmpresa, InfoCabeceraGT_Nueva, ref msg))
                {
                    MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    set_Accion(Cl_Enumeradores.eTipo_action.consultar); lblAnulado.Visible = true;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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

        private void FrmPrd_GrupoTrabajoMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                iniciar_controles(); //REVISAE  
                carga_gridPre(LmInfoDetalleGT_Original);
                 cargaCmbE_ModeloProduccion(); //REVISAE

                CargarGT();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private Boolean validaciones()
        {
            bool B_Verifica_Objetos_Vacios = false;
            try
            {
                 if (cmbModeloProductivo.EditValue == null)
                 {
                     errorProviderValidarTxt.SetError(cmbModeloProductivo,"Debe seleccionar un Modelo de producción");
                    B_Verifica_Objetos_Vacios = true; 
                }
                 else if (cmbEtapas.Text == "[Vacío]")
                {
                    errorProviderValidarTxt.SetError(cmbEtapas,"Debe seleccionar una etapa de producción");
                    return false;
                }
               
                 else if (ultraCmbELiderGrupo.Text == "[Vacío]")
                {
                    errorProviderValidarTxt.SetError(ultraCmbELiderGrupo,"Debe seleccionar un lider para este grupo");
                    B_Verifica_Objetos_Vacios = true;
                }
                else if (txt_nomGrupo.Text == string.Empty)
                {
                    errorProviderValidarTxt.SetError(txt_nomGrupo,"Escriba la Descripcion(Nombre) del Grupo");
                    B_Verifica_Objetos_Vacios = true;
                }
                 if (txt_nomGrupo.Text == "")
                 {
                     errorProviderValidarTxt.SetError(txt_nomGrupo, "Ingrese Nombre Grupo");
                     B_Verifica_Objetos_Vacios = true;
                 }
                 return B_Verifica_Objetos_Vacios;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return B_Verifica_Objetos_Vacios;










            }
        }

        private void grabar()
        {
            try
            {

                
                    
                getCab();
                getDet();
                    string msg = "";
                    decimal idgenerada = 0;
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (BusCabeceraGT.GrabarCabeceraDB(param.IdEmpresa, InfoCabeceraGT_Nueva, _LmInfoDetalleGT_Nueva, ref msg, ref idgenerada))
                            {
                                txt_numGrupo.Text = idgenerada.ToString();
                                set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                            }
                            MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            if (BusCabeceraGT.ModificarDB(param.IdEmpresa, InfoCabeceraGT_Nueva, ref msg))
                            {
                                LmInfoDetalleGT_Original = BusDetalleGT.ObtenerGrupoTrabDetalle(InfoCabeceraGT_Nueva.IdGrupoTrabajo, InfoCabeceraGT_Nueva.IdEmpresa, InfoCabeceraGT_Nueva.IdSucursal);
                                _LmInfoDetalleGT_Nueva.ForEach(var => var.CodObra = InfoCabeceraGT_Nueva.CodObra);
                                if (BusDetalleGT.eliminarregistrotabla(LmInfoDetalleGT_Original, param.IdEmpresa, InfoCabeceraGT_Nueva.IdGrupoTrabajo, ref msg))
                                    if (BusDetalleGT.grabarDB(_LmInfoDetalleGT_Nueva, param.IdEmpresa, InfoCabeceraGT_Nueva.IdGrupoTrabajo, ref msg))
                                        txt_numGrupo.Text = InfoCabeceraGT_Nueva.IdGrupoTrabajo.ToString();


                            }
                            gridViewGT.SelectAll();
                            gridViewGT.DeleteSelectedRows();
                            carga_gridPre(_LmInfoDetalleGT_Nueva);

                            MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        default:
                            break;
                    }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void ultraCmbELiderGrupo_AfterExitEditMode(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ultraCmbELiderGrupo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (ultraCmbELiderGrupo.EditValue == null)
                {
                    ultraCmbELiderGrupo.Text = "";

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


        }


        private void ultraCmbEEtapaProduccion_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (cmbEtapas.EditValue == null)
                {
                    cmbEtapas.Text = "";

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewGT_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                    gridViewGT.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                //-- CARLOS ACTALIZACION

                //XPRO_CUS_CID_Rpt009 Xreport = new XPRO_CUS_CID_Rpt009();
                //prd_ObtenerReporte_Bus busSpRpt = new prd_ObtenerReporte_Bus();
                //List<tbPRO_CUS_CID_Rpt009_Info> data = new List<tbPRO_CUS_CID_Rpt009_Info>();
                //data = busSpRpt.OptenerData_spPRD_Rpt_RPRD009(param.IdEmpresa, InfoCabeceraGT_Nueva.IdSucursal, InfoCabeceraGT_Nueva.IdGrupoTrabajo ,param.IdUsuario, param.nom_pc);
                //Xreport.loadData(data.ToArray());
                //Xreport.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraCmbEModeloProductivo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargaCmbE_EtapasProduccion(Convert.ToInt32(cmbModeloProductivo.EditValue));

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraCmbEModeloProductivo_Click(object sender, EventArgs e)
        {
            try
            {
                cargaCmbE_EtapasProduccion(Convert.ToInt32(cmbModeloProductivo.EditValue));

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_ordenTaller_EditValueChanged(object sender, EventArgs e)
        {

        }



        public void CargarGT()
        {
            try
            {
               
                ListaGt = BusGt.ObtenerGrupoTrabajoCab(param.IdEmpresa);
                cmbGrupoTrabajo.Properties.DataSource = ListaGt;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
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
