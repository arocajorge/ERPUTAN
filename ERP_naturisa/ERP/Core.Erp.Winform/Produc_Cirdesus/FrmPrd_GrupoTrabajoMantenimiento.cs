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
using Infragistics.Win.UltraWinGrid;
using Core.Erp.Reports.Produc_Cirdesus;
//verson 24062013 1635
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_GrupoTrabajoMantenimiento : Form
    {

        
        public FrmPrd_GrupoTrabajoMantenimiento()
        {
            try
            {
             InitializeComponent();
                cmb_empleado.DataSource = BusEmpleado.Obtener_Empleado_persona(param.IdEmpresa);
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

        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //DELEGADO
        public delegate void delegate_FrmPrd_GrupoTrabajoMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_GrupoTrabajoMantenimiento_FormClosing EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing;


        //instancias de Cabecera de GT
        prd_GrupoTrabajo_Info InfoCabeceraGT_Nueva = new prd_GrupoTrabajo_Info(); //esta es para el get
        prd_GrupoTrabajo_Bus BusCabeceraGT = new prd_GrupoTrabajo_Bus();

        //instancias de Detalle GT
        prd_GrupoTrabajoDetalle_Bus BusDetalleGT = new prd_GrupoTrabajoDetalle_Bus();
        List<prd_GrupoTrabajoDetalle_Info> LmInfoDetalleGT_Original = new List<prd_GrupoTrabajoDetalle_Info>(); //esta es del set
        List<prd_GrupoTrabajoDetalle_Info> _LmInfoDetalleGT_Nueva = new List<prd_GrupoTrabajoDetalle_Info>(); //esta es del get
        DataTable dt = new DataTable("detalle");
        List<prd_GrupoTrabajoDetalle_Info> DetGT = new List<prd_GrupoTrabajoDetalle_Info>();

        //instancias de centro de costo
        UCPrd_Obra UCObra = new UCPrd_Obra();

        //instancias de modelo produccion x centro costo
        prd_ProcesoProductivo_x_prd_obra_Bus BusModeloxCC = new prd_ProcesoProductivo_x_prd_obra_Bus();
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
                        //this.btnGrabar.Text = "Actualizar Registro";
                        //this.btnGrabarySalir.Text = "Actualizar y Salir";
                        //this.UCObra.UC_Obra.Enabled = false;

                     


                        this.cmb_ordenTaller.Enabled = false;
                        this.UCSuc.cmb_sucursal.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                       // this.btnGrabar.Enabled = false;
                       // this.btnGrabarySalir.Enabled = false;
                       // this.UCObra.UC_Obra.Enabled = false;
                        this.cmb_ordenTaller.Enabled = false;
                        this.UCSuc.cmb_sucursal.Enabled = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.borrar:
                       // this.btnGrabar.Enabled = false;
                       // this.btnGrabarySalir.Enabled = false;
                      //  this.UCObra.UC_Obra.Enabled = false;
                        this.cmb_ordenTaller.Enabled = false;
                        this.UCSuc.cmb_sucursal.Enabled = false;
                       // this.btn_Anular.Visible = true;
                       // this.sep1.Visible = true;
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
                PanelObra.Controls.Add(UCObra);
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

                cmb_ordenTaller.Properties.DataSource = null;
                cmb_ordenTaller.Text = "";

             
                if (UCObra.get_item_info() != null)
                {
                    cargaCmbE_ModeloProduccion(UCObra.get_item());

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


        }

        private void cargaCmbE_ModeloProduccion(string CodObra)
        {
            try
            {
                cmbModeloProductivo.Properties.DataSource = BusModeloxCC.ObtenerProcesProductivo_x_CentroCosto(param.IdEmpresa, CodObra);
                this.cmbModeloProductivo.Properties.DisplayMember = "NombreModelo";
                this.cmbModeloProductivo.Properties.ValueMember = "IdProcesoProductivo";

                if (cmbModeloProductivo.EditValue != null)
                    cmbModeloProductivo.EditValue = 0; //siempre se setea el primero

                if (cmbModeloProductivo.EditValue == null)
                    cmbModeloProductivo.Text = "";

                else
                {
                    cargaCmbE_EtapasProduccion(Convert.ToInt32(cmbModeloProductivo.EditValue));
                    cargaCmbE_OrdenTaller(CodObra);
                }
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

        private void cargaCmbE_OrdenTaller(string CodObra)
        {
            try
            {
                lmOT = BusOT.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, CodObra);
              this.cmb_ordenTaller.Properties.DataSource= lmOT;

              var item = lmOT.FirstOrDefault().IdOrdenTaller;

              cmb_ordenTaller.EditValue = item;    
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
                
                 ultraCmbELiderGrupo.Properties.DataSource = BusEmpleado.Obtener_Empleado_persona(param.IdEmpresa);
                 this.ultraCmbELiderGrupo.Properties.DisplayMember = "NomCompleto";
                this.ultraCmbELiderGrupo.Properties.ValueMember = "IdEmpleado";

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

        public void setCab(prd_GrupoTrabajo_Info info)
        {
            try
            {
                InfoCabeceraGT_Nueva = info;
                txt_numGrupo.Text = info.IdGrupoTrabajo.ToString().Trim();
                txt_nomGrupo.Text = info.Descripcion.Trim();
                
                //cargaCmbE_ModeloProduccion(info.CodObra);
                //cargaCmbE_OrdenTaller(info.CodObra);
                //cmb_ordenTaller.EditValue = info.IdOrdenTaller;
                //ultraCmbELiderGrupo.EditValue = info.IdLider;
                //UCSuc.cmb_sucursal.EditValue = info.IdSucursal;
                //cmbEtapas.EditValue = info.IdEtapa;
                //cmbModeloProductivo.EditValue = info.IdProcesoProductivo;
                if (info.Estado == "I")
                {
                    lblAnulado.Visible = true;
                    chkEstado.Checked = false;
                }
                else
                    chkEstado.Checked = true;

               
               // setDet(info.CodObra, info.IdGrupoTrabajo);
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

        private void carga_gridPre(List<prd_GrupoTrabajoDetalle_Info> lm)
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
                //InfoCabeceraGT_Nueva.IdGrupoTrabajo = Convert.ToDecimal(txt_numGrupo.Text);
                //InfoCabeceraGT_Nueva.CodObra = UCObra.get_item();
                //InfoCabeceraGT_Nueva.IdProcesoProductivo = Convert.ToInt32(cmbModeloProductivo.EditValue);
                //InfoCabeceraGT_Nueva.IdEtapa = Convert.ToInt32(cmbEtapas.EditValue);
                //InfoCabeceraGT_Nueva.IdOrdenTaller = Convert.ToInt32(cmb_ordenTaller.EditValue);
                //InfoCabeceraGT_Nueva.IdLider = Convert.ToDecimal(ultraCmbELiderGrupo.EditValue);
                //InfoCabeceraGT_Nueva.Estado = (this.chkEstado.Checked == true) ? "A" : "I";
                //InfoCabeceraGT_Nueva.Descripcion = txt_nomGrupo.Text.Trim();
                //InfoCabeceraGT_Nueva.FechaCreacion = DateTime.Now;
              
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
                DetGT = new List<prd_GrupoTrabajoDetalle_Info>();
                _LmInfoDetalleGT_Nueva = new List<prd_GrupoTrabajoDetalle_Info>();


                for (int i = 0; i <= gridViewGT.RowCount; i++)
                {
                    prd_GrupoTrabajoDetalle_Info infolider = new prd_GrupoTrabajoDetalle_Info();

                    var row = (prd_GrupoTrabajoDetalle_Info)gridViewGT.GetRow(i);
                    if (row != null)
                    {
                        prd_GrupoTrabajoDetalle_Info info = new prd_GrupoTrabajoDetalle_Info();
                        info.IdEmpleado = row.IdEmpleado;
                        info.Pe_NombreCompeto = row.Pe_NombreCompeto;
                       // info.CodObra = InfoCabeceraGT_Nueva.CodObra;
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

                prd_GrupoTrabajoDetalle_Info lider = new prd_GrupoTrabajoDetalle_Info();
                lider.IdEmpleado = (decimal)ultraCmbELiderGrupo.EditValue;
                lider.Observacion = "Lider de Grupo";
               // lider.CodObra = InfoCabeceraGT_Nueva.CodObra;
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
                //if (BusCabeceraGT.AnularReactiva(param.IdEmpresa, InfoCabeceraGT_Nueva, ref msg))
                //{
                //    MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    set_Accion(Cl_Enumeradores.eTipo_action.consultar); lblAnulado.Visible = true;
                //}

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
                iniciar_controles();
                carga_gridPre(LmInfoDetalleGT_Original);
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
                 else if (cmb_ordenTaller.Text == "[Vacío]")
                {
                    errorProviderValidarTxt.SetError(cmb_ordenTaller,"Debe seleccionar una Orden de Taller");
                    B_Verifica_Objetos_Vacios = true;
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
        {/*
            try
            {

                
                    //txt_numGrupo.Focus();
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
          * */
        }

        private void ultraGridDetalle_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            try
            {
                    ultraGridDetalle.DisplayLayout.Bands[0].Columns["IdEmpleado"].EditorComponent = ultraCmbELiderGrupo;
                    ultraGridDetalle.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
                    ultraGridDetalle.DisplayLayout.Bands[0].Columns["IdEmpleado"].AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
                    ultraGridDetalle.DisplayLayout.Bands[0].Columns["IdEmpleado"].AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;

                    ultraGridDetalle.DisplayLayout.Bands[0].Columns["IdEmpleado"].Hidden = false;
                    ultraGridDetalle.DisplayLayout.Bands[0].Columns["IdEmpresa"].Hidden = true;
                    ultraGridDetalle.DisplayLayout.Bands[0].Columns["IdSucursal"].Hidden = true;
                    ultraGridDetalle.DisplayLayout.Bands[0].Columns["IdGrupotrabajo"].Hidden = true;
                    ultraGridDetalle.DisplayLayout.Bands[0].Columns["Secuencia"].Hidden = false;
                    ultraGridDetalle.DisplayLayout.Bands[0].Columns["Observacion"].Hidden = false;
                    ultraGridDetalle.DisplayLayout.Bands[0].Columns["NombreCompleto"].Hidden = true;

                    ultraGridDetalle.DisplayLayout.Bands[0].Columns["Secuencia"].CellActivation = Activation.NoEdit;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void ultraGridDetalle_AfterRowInsert(object sender, RowEventArgs e)
        {
            try
            {

                ultraGridDetalle.Rows[ultraGridDetalle.Rows.Count - 1].Cells["Secuencia"].Value = ultraGridDetalle.Rows.Count;
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

        private void UltraCmbOrdenTaller_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (cmb_ordenTaller.EditValue == null)
                {
                    cmb_ordenTaller.Text = "";

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
                XPRO_CUS_CID_Rpt009 Xreport = new XPRO_CUS_CID_Rpt009();
                prd_ObtenerReporte_Bus busSpRpt = new prd_ObtenerReporte_Bus();
                List<tbPRO_CUS_CID_Rpt009_Info> data = new List<tbPRO_CUS_CID_Rpt009_Info>();
                data = busSpRpt.OptenerData_spPRD_Rpt_RPRD009(param.IdEmpresa, InfoCabeceraGT_Nueva.IdSucursal, InfoCabeceraGT_Nueva.IdGrupoTrabajo ,param.IdUsuario, param.nom_pc);
                Xreport.loadData(data.ToArray());
                Xreport.ShowPreviewDialog();
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

       
    }
     
}
