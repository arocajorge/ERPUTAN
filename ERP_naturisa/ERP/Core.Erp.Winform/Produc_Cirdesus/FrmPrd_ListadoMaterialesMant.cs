using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Cus.Erp.Reports.Cidersus;
using Core.Erp.Reportes.Inventario;
using DevExpress.XtraGrid.Views.Grid;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Business.Compras_Edehsa;
using Core.Erp.Info.Compras_Edehsa;
using DevExpress.XtraPrinting;
namespace Core.Erp.Winform.Produc_Cirdesus
{
   
    public partial class FrmPrd_ListadoMaterialesMant : Form
    {
       

        #region declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        //d_Obra Obra = new UCPrd_Obra();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_OrdenTaller_Bus BUSOT = new prd_OrdenTaller_Bus();
        com_ListadoMateriales_Det_Bus BusDetLMat = new com_ListadoMateriales_Det_Bus();
        List<com_ListadoMateriales_Det_Info> LstInfoLMat = new List<com_ListadoMateriales_Det_Info>();
        List<com_ListadoMateriales_Det_Info> LstInfoLMatxObra = new List<com_ListadoMateriales_Det_Info>();

        com_ListadoElementos_x_OT_Det_Bus BusListadoElementosDet = new com_ListadoElementos_x_OT_Det_Bus();
        List<com_ListadoElementos_x_OT_Det_Info> ListInfoListadoElementosDet_x_Obra = new List<com_ListadoElementos_x_OT_Det_Info>();


        com_ListadoMateriales_Info InfoLMat = new com_ListadoMateriales_Info();
        com_ListadoMateriales_Bus BUsLMat = new com_ListadoMateriales_Bus();
        List<in_Producto_paraGrilla_Info> LstProducto = new List<in_Producto_paraGrilla_Info>();

        List<in_Producto_Info> listProducto;

        in_producto_Bus BusProd = new in_producto_Bus();
        List<com_Catalogo_Info> LstMotivoReq = new List<com_Catalogo_Info>();
        com_Catalogo_Info MotivoREq = new com_Catalogo_Info();
        com_Catalogo_Bus BusMotivoReq = new com_Catalogo_Bus();

        List<com_Catalogo_Info> ListaCatalogoOC = new List<com_Catalogo_Info>();
        com_Catalogo_Bus BusCatalogoOC = new com_Catalogo_Bus();

        com_ListadoMateriales_Det_Info InfoDet;
        BindingList<com_ListadoMateriales_Det_Info> ListaBind = new BindingList<com_ListadoMateriales_Det_Info>();

        prd_parametros_CusCidersus_Bus param_Produccion = new prd_parametros_CusCidersus_Bus();
        prd_parametros_CusCidersus_Info _Parametros_Info = new prd_parametros_CusCidersus_Info();

        in_movi_inve_detalle_x_Producto_CusCider_Bus BusInve = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Info InfoProductoSobrante = new in_movi_inve_detalle_x_Producto_CusCider_Info();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> listaInfoProductoSobrante= new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();

        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus BusMPPreasignado = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus();
        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info InfoMPPreasignado = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
        List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstMPPreasignado = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
        BindingList<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstBindMPPreasignado = new BindingList<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();

        List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstMPDespunte = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
        BindingList<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstBindMPDespunte = new BindingList<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();

        #endregion

        public FrmPrd_ListadoMaterialesMant()
        {
            try
            {

              InitializeComponent();
              ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
              ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
              ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
              ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
              ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
              _Parametros_Info = param_Produccion.ObtenerObjeto(param.IdEmpresa);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void FrmPrd_ListadoMaterialesMant_Load(object sender, EventArgs e)
        {
            try
            {
                //ListaBind = new BindingList<com_ListadoMateriales_Det_Info>();
                gridCtrlDetListMateriales.DataSource = ListaBind;

                cargacontrol();
                cargacombos();
                carga_Todos_Despuntes_MPPreasignado();
                //cmb_producto.DataSource = BusProd.Get_list_Producto(param.IdEmpresa).
                //    FindAll(var => var.IdProductoTipo == 1);
                BusProd = new in_producto_Bus();
                listProducto = new List<in_Producto_Info>();

                listProducto = BusProd.Get_list_ProductosMateriaPrimaDimension_x_TipoProducto(param.IdEmpresa, Convert.ToInt32(_Parametros_Info.IdProductoTipo_MateriaPrima));
                cmb_producto.DataSource = listProducto;

                cmb_estado.DataSource = BusEA.Get_ListEstadoAprobacion();
                Event_FrmPrd_ListadoMaterialesMant_FormClosing += new Delegate_FrmPrd_ListadoMaterialesMant_FormClosing(FrmPrd_ListadoMaterialesMant_Event_FrmPrd_ListadoMaterialesMant_FormClosing);
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
                        
        }

        #region delegado actualiza

        void FrmPrd_ListadoMaterialesMant_Event_FrmPrd_ListadoMaterialesMant_FormClosing(object sender, FormClosingEventArgs e){}

        public delegate void Delegate_FrmPrd_ListadoMaterialesMant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmPrd_ListadoMaterialesMant_FormClosing Event_FrmPrd_ListadoMaterialesMant_FormClosing;

        private void FrmPrd_ListadoMaterialesMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 Event_FrmPrd_ListadoMaterialesMant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        #endregion

        void cargacontrol()
        {
            try
            {
                Obra.cargaCmb_Obra();
                //PanelObra.Controls.Add(Obra);
               // Obra.Dock = DockStyle.Fill;
                Obra.Event_UCObra_SelectionChanged += new UCPrd_Obra.delegadoUCObra_SelectionChanged(Obra_Event_UCObra_SelectionChanged);

                Obra.Event_UCObra_EditValueChanged += Obra_Event_UCObra_EditValueChanged;

                Obra.Event_UCObra_Validating += new UCPrd_Obra.delegadoUCObra_Validating(Obra_Event_UCObra_Validating);

                //ucPrd_OrdenTaller.Event_UCOrdenTaller_SelectionChanged += new UCPrd_OrdenTaller.delegadoUCOrdenTaller_SelectionChanged(ucPrd_OrdenTaller_Event_UCOrdenTaller_SelectionChanged);
                //size y location de controles
                //Obra.label.Location = new Point(10, 0);
               // Obra.UC_Obra.Location = new Point(83, 1);
               // Obra.UC_Obra.Size = new System.Drawing.Size(315, 21);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);

            }



        }

        void Obra_Event_UCObra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                cargar_grids();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void cargar_grids()
        {
            try
            {
                if (ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal != null)
                {
                    if (Obra.get_item_info() != null)
                    {

                        ListInfoListadoElementosDet_x_Obra = BusListadoElementosDet.Get_List_ListadoElementos_x_OT_Det(param.IdEmpresa, Obra.get_item());
                        gridCtrlDetListMaterialesxObra.DataSource = ListInfoListadoElementosDet_x_Obra;
                        gridvwDetListMaterialesxObra.ExpandAllGroups();
                        //cargagrid_InventarioFisico();
                        carga_MPPreasignado_x_Obra();
                    }
                    else
                        setearcampos();
                }
                else
                    setearcampos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
           
        }
        void cargacombos()
        {

            try
            {
                LstMotivoReq = BusMotivoReq.Get_List_MotivoRequerimiento();
                ListaCatalogoOC = BusCatalogoOC.Get_ListEstadoAprobacion();
                cmbEstadoApro.Properties.DataSource = ListaCatalogoOC;
                cmbEstadoApro.Properties.ValueMember = "IdCatalogocompra";
                cmbEstadoApro.Properties.DisplayMember = "descripcion";
                cmbEstadoApro.EditValue = "xAPRO";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }


        }

        void carga_MPPreasignado_x_Obra()
        {

            try
            {
                LstMPPreasignado = BusMPPreasignado.Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det(param.IdEmpresa, Obra.get_item());
                //gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = LstInfoLMat;

                LstBindMPPreasignado = new BindingList<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>(LstMPPreasignado);
                gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = LstBindMPPreasignado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        void carga_Todos_Despuntes_MPPreasignado()
        {

            try
            {
                LstMPDespunte = BusMPPreasignado.Get_List_All_DespuntesMP_Preasignado(param.IdEmpresa);
                //gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = LstInfoLMat;

                LstBindMPDespunte = new BindingList<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>(LstMPDespunte);
                gridCtrlDetListDespuntesMP_PreAsignado.DataSource = LstBindMPDespunte;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        void Obra_Event_UCObra_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Obra.validating == 1)
                {
                    setearcampos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void setearcampos()
        {
            try
            {
                //UltraCmbOrdenTaller.EditValue = null;
                //txtCodOT.Text = "";
                //txtPesoUnit.Text = "";
                //txtUnit.Text = "";
                //txtTtPeso.Text = "";
                //txtProdTerm.Text = "";
                //txtIdOT.Text = "";
                //dTPFecRegOT.Value = DateTime.Now;
                //gridCtrlDetListMateriales.DataSource = null;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }



        }

        void Obra_Event_UCObra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal != null)
                {
                    if (Obra.get_item_info() != null)
                    {
                       // UltraCmbOrdenTaller.Properties.DataSource = BUSOT.ObtenerListaOT(param.IdEmpresa).FindAll(var =>
                       //var.IdSucursal == ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal && var.CodObra == Obra.get_item());
                    }
                    else
                        setearcampos();
                }
                else
                    setearcampos();
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

                       
                        this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        lblAnulado.Visible = false;


                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        
                        
                        this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        lblAnulado.Visible = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        lblAnulado.Visible = false;
                        ucGe_Sucursal_combo1.Enabled = false;
                        //UltraCmbOrdenTaller.Enabled = false;
                        txtObservacion.Enabled = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = false;
                        
                       
                        Obra.Enabled = false;
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
                        lblAnulado.Visible = false;
                        ucGe_Sucursal_combo1.Enabled = false;
                        ////UltraCmbOrdenTaller.Enabled = false;



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

        public void setCab(com_ListadoMateriales_Info InfoLisMat)
        {
            prd_OrdenTaller_Info InfoOT = new prd_OrdenTaller_Info();
            try
            {
                // LLENAR LOS COMBOS DE LOS DATOS DE LA ORDEN

                InfoLMat = InfoLisMat;
                ucGe_Sucursal_combo1.set_SucursalInfo(InfoLisMat.IdSucursal);
                Obra.set_item(InfoLisMat.CodObra);
                dtpFechareg.Value = InfoLisMat.FechaReg;
                //UltraCmbOrdenTaller.EditValue = InfoLisMat.IdOrdenTaller;
                //InfoOT = BUSOT.ObtenerUnaOT(param.IdEmpresa, InfoLisMat.IdSucursal, InfoLisMat.IdOrdenTaller, InfoLisMat.CodObra);
                //txtCodOT.Text = InfoOT.Codigo;
                //txtProdTerm.Text = "[" + InfoOT.IdProducto + "][" + InfoOT.NomProducto + "]";
                //txtPesoUnit.Text = Convert.ToString(InfoOT.PesoUnitario);
                //txtUnit.Text = Convert.ToString(InfoOT.CantidadPieza);
                //txtTtPeso.Text = Convert.ToString(InfoOT.TotalPeso);
                txtIdLMat.Text = Convert.ToString(InfoLisMat.IdListadoMateriales);
                //dTPFecRegOT.Value = InfoOT.FechaReg;
                txtUsuario.Text = InfoLisMat.Usuario;
                txtObservacion.Text = InfoLisMat.lm_Observacion;
                //txtIdOT.Text =Convert.ToString( InfoOT.IdOrdenTaller);
                if (InfoLisMat.Estado == "I")
                {
                    lblAnulado.Visible = true;
                    set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                }
                cargagrid(InfoLisMat);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean getCab()
        {
            try
            {
                InfoLMat.IdEmpresa = param.IdEmpresa;

                InfoLMat.IdListadoMateriales = (txtIdLMat.Text == "") ? 0 : Convert.ToInt32(txtIdLMat.Text);

                InfoLMat.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                ////InfoLMat.IdOrdenTaller = (decimal)UltraCmbOrdenTaller.EditValue;
                InfoLMat.FechaReg = dtpFechareg.Value;
                InfoLMat.Motivo = "EST_APR_LIS_REQ";
                InfoLMat.CodObra = Obra.get_item();
                InfoLMat.Estado = "A";
                InfoLMat.Usuario = param.IdUsuario;
                InfoLMat.lm_Observacion = txtObservacion.Text;

                if (getDet() == false)
                    return false;
                return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;

            }


        }

        public Boolean getDet()
        {
            try
            {
                List<com_ListadoMateriales_Det_Info> lsttemp = new List<com_ListadoMateriales_Det_Info>();


                for (int i = 0; i < gridvwDetListMateriales.RowCount; i++)
                {
                    var ass = (com_ListadoMateriales_Det_Info)gridvwDetListMateriales.GetRow(i);
                    if (ass != null)
                    {
                        com_ListadoMateriales_Det_Info row = new com_ListadoMateriales_Det_Info();

                        row.IdEmpresa = param.IdEmpresa;

                        row.CodObra = Obra.get_item();
                        //row.IdOrdenTaller = Convert.ToInt32(UltraCmbOrdenTaller.EditValue);
                        row.Det_Kg = ass.Det_Kg;
                        row.IdDetalle = 0;
                        row.IdListadoMateriales = 0;
                        row.IdProducto = ass.IdProducto;
                        row.lm_IdEstadoAprobado = "PEN";

                        row.pr_largo = ass.pr_largo;
                        row.largo_total = ass.largo_total;
                        row.largo_restante = ass.largo_restante;

                        row.largo_pieza_entera = ass.largo_pieza_entera;
                        row.cantidad_pieza_entera = ass.cantidad_pieza_entera;
                        row.largo_pieza_complementaria = ass.largo_pieza_complementaria;
                        row.cantidad_pieza_complementaria = ass.cantidad_pieza_complementaria;
                        row.cantidad_total_pieza_complementaria = ass.cantidad_total_pieza_complementaria;
                        row.largo_despunte1 = ass.largo_despunte1;
                        row.cantidad_despunte1 = ass.cantidad_despunte1;
                        row.es_despunte_usable1 = ass.es_despunte_usable1;
                        row.largo_despunte2 = ass.largo_despunte2;
                        row.cantidad_despunte2 = ass.cantidad_despunte2;
                        row.es_despunte_usable2 = ass.es_despunte_usable2;

                        if (ass.IdProducto == 0)
                        {
                            MessageBox.Show("Debe corregir su seleccion de productos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;

                        }
                        row.Unidades = ass.Unidades;
                        row.pr_codigo = ass.pr_codigo;
                        row.pr_descripcion = ass.pr_descripcion;
                        if (row.Unidades > 0)
                            lsttemp.Add(row);
                        else
                        {
                            MessageBox.Show("Debe corregir la cantidad de los productos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;

                        }

                    }
                }


                //gridCtrlDetListMateriales.DataSource  = lsttemp;
                LstInfoLMat = lsttemp;
                //LstInfoLMat  = (List<com_ListadoMateriales_Det_Info>)gridvwDetListMateriales.DataSource;
                if (LstInfoLMat.Count < 1)
                {
                    MessageBox.Show("Debe ingresar los Materiales para la Orden de Taller", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;

            }


        }

        List<com_Catalogo_Info> LstEstApro = new List<com_Catalogo_Info>();

        com_Catalogo_Bus BusEA = new com_Catalogo_Bus();

        void cargagrid(com_ListadoMateriales_Info InfoLMat)
        {

            try
            {

                LstInfoLMat = BusDetLMat.Get_List_ListadoMateriales_Det(InfoLMat.IdEmpresa, InfoLMat.IdListadoMateriales);
                //gridCtrlDetListMateriales.DataSource = LstInfoLMat;

                ListaBind = new BindingList<com_ListadoMateriales_Det_Info>(LstInfoLMat);
                gridCtrlDetListMateriales.DataSource = ListaBind;


                ListInfoListadoElementosDet_x_Obra = new List<com_ListadoElementos_x_OT_Det_Info>();
                ListInfoListadoElementosDet_x_Obra = BusListadoElementosDet.Get_List_ListadoElementos_x_OT_Det(InfoLMat.IdEmpresa, InfoLMat.CodObra);
                gridCtrlDetListMaterialesxObra.DataSource = ListInfoListadoElementosDet_x_Obra;
                gridvwDetListMaterialesxObra.ExpandAllGroups();
                //cargagrid_InventarioFisico();
                carga_MPPreasignado_x_Obra();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
       
       


        void Limpiar()
        {
            gridCtrlDetListMateriales.DataSource = null;
            gridCtrlDetListMateriales.DataSource = ListaBind;
            //gridvwDetListMateriales.Columns.Clear();
        }
        private void UltraCmbOrdenTaller_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //if (UltraCmbOrdenTaller.EditValue ==null)
                //{
                //    UltraCmbOrdenTaller.Text = "";
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void grabar()
        {

            try
            {
                int id = 0;
                string msg = "";
               


                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (BUsLMat.GrabarDB(InfoLMat, ref id, ref msg))
                        {

                            LstInfoLMat.ForEach(var => var.IdListadoMateriales = id);
                            int iddetail = 0;
                            LstInfoLMat.ForEach(var => var.IdDetalle = iddetail++);
                            if (BusDetLMat.GuardarDB(LstInfoLMat, cmbEstadoApro.EditValue.ToString()))
                            {
                                {

                                    MessageBox.Show("Se ha procedido a grabar el Listado de Materiales #: " + id.ToString() + " exitosamente.", "Operación Exitosa");
                                }
                                InfoLMat.IdListadoMateriales = id;
                                txtIdLMat.Text = Convert.ToString(id);
                                txtUsuario.Text = param.IdUsuario;
                                //setCab(InfoLMat);


                                set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                gridvwDetListMateriales.SelectAll();
                                gridvwDetListMateriales.DeleteSelectedRows();
                                cargagrid(InfoLMat);
                            }
                        }
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (BUsLMat.ModificarDB(InfoLMat, ref  msg))
                        {
                            List<com_ListadoMateriales_Det_Info> templst = new List<com_ListadoMateriales_Det_Info>();
                            templst = BusDetLMat.Get_List_ListadoMateriales_Det(param.IdEmpresa, InfoLMat.IdListadoMateriales);

                            if (templst.Count != 0)
                            {
                                if (BusDetLMat.EliminarDB(templst, ref msg))
                                {
                                    LstInfoLMat.ForEach(var => var.IdListadoMateriales = InfoLMat.IdListadoMateriales);
                                    int iddetail = 0;
                                    LstInfoLMat.ForEach(var => var.IdDetalle = iddetail++);
                                    LstInfoLMat.ForEach(var => var.lm_IdEstadoAprobado = "X APRO");
                                    if (BusDetLMat.GuardarDB(LstInfoLMat, ""))
                                    {
                                        MessageBox.Show("Se ha procedido a grabar el Listado de Materiales #: " + InfoLMat.IdListadoMateriales.ToString() + " exitosamente.", "Operación Exitosa");
                                    }
                                }
                                //MessageBox.Show(msg+"No se Actualizo el registro de la Orden/Compra #: " + InfoLMat.IdListadoMateriales.ToString(), "Operación Fallida");

                            }
                        }
                        else
                        {
                            MessageBox.Show(msg+ "No se ha grabado el registro de la Orden/Compra #: " + InfoLMat.IdListadoMateriales.ToString(), "Operación Fallida");
                        }
                        break;


                    default: break;

                }

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
                if (MessageBox.Show("¿Está seguro que desea anular la Lista de Materiales N#: " + InfoLMat.IdListadoMateriales + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InfoLMat.lm_Observacion = "***ANULADO***" + InfoLMat.lm_Observacion;
                    lblAnulado.Visible = true;
                    BUsLMat.AnularDB(InfoLMat, ref msg);
                    
                    set_Accion(Cl_Enumeradores.eTipo_action.consultar);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }



        }

        private Boolean validaciones()
        {
            bool B_ValidarCajasTextos = false;
            try
            {

                //if (txtIdOT.Text == "")
                //{
                //    errorProviderValidarTxt.SetError(txtIdOT, "Error Campo Obligatorio");
                //    B_ValidarCajasTextos = true;
                //}

                if (txtObservacion.Text == "")
                {
                    errorProviderValidarTxt.SetError(txtObservacion, "Ingrese una Observacion");
                    B_ValidarCajasTextos = true;
                }

                //if (txtPesoUnit.Text == "")
                //{
                //    errorProviderValidarTxt.SetError(txtPesoUnit, "Error Campo Obligatorio");
                //    B_ValidarCajasTextos = true;
                //}

                //if (txtTtPeso.Text == "")
                //{
                //    errorProviderValidarTxt.SetError(txtTtPeso, "Error Campo Obligatorio");
                //    B_ValidarCajasTextos = true;
                //}

                //if (txtProdTerm.Text == "")
                //{
                //    errorProviderValidarTxt.SetError(txtProdTerm, "Error Campo Obligatorio");
                //    B_ValidarCajasTextos = true;
                //}

                return B_ValidarCajasTextos;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return B_ValidarCajasTextos;

            }

        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaciones() == true)
                {return;}

                getDet();
                getCab();
                
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
                if (validaciones() == false)
                {
                    return;
                }
                    getDet();
                    getCab();
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

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            
            try
            {
                
               anular();
               lblAnulado.Visible = true;
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

                xrpt_prd_ListadoMateriales Xrpt_ListMat = new xrpt_prd_ListadoMateriales();
                com_rpt_ListadoMateriales_Info InfoRptListMat = new com_rpt_ListadoMateriales_Info();
                prd_ObtenerReporte_Bus ObtDatos = new prd_ObtenerReporte_Bus();
                List<com_rpt_ListadoMateriales_Info> LstInfoRep = new List<com_rpt_ListadoMateriales_Info>();


                var cab = (com_ListadoMateriales_Info)BUsLMat.Get_Info_ListadoMateriales(param.IdEmpresa, InfoLMat.IdListadoMateriales);
                if (cab != null)
                {
                    List<tbPRO_CUS_CID_Rpt003_Info> data = new List<tbPRO_CUS_CID_Rpt003_Info>();
                    //data = ObtDatos.OptenerData_spPRD_Rpt_RPRD003(param.IdEmpresa, Convert.ToInt32(param.IdSucursal), cab.IdListadoMateriales);
                    //Xrpt_ListMat.loadData(data.ToArray());
                    //Xrpt_ListMat.ShowPreviewDialog();

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al cargar los datos. "
                        + "Por favor comuniquese con sistemas...");
                }

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                  cargagrid(InfoLMat);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        //private void cmbMotivo_Validating(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        if (cmbMotivo.SelectedItem == null)
        //        {
        //            cmbMotivo.Text = "";
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString());
        //    }


        //}

        private void gridvwDetListMateriales_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                com_ListadoMateriales_Det_Info Temp = new com_ListadoMateriales_Det_Info();
                Temp = (com_ListadoMateriales_Det_Info)gridvwDetListMateriales.GetFocusedRow();
                if ((e.KeyChar == (char)8))
                {
                    if (MessageBox.Show("¿Desea eliminar el producto: " + Temp.pr_descripcion + " de la Lista ?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        List<com_ListadoMateriales_Det_Info> lsttemp = new List<com_ListadoMateriales_Det_Info>();


                        for (int i = 0; i < gridvwDetListMateriales.RowCount; i++)
                        {
                            if (i != gridvwDetListMateriales.FocusedRowHandle)
                            {
                                var ass = (com_ListadoMateriales_Det_Info)gridvwDetListMateriales.GetRow(i);
                                if (ass != null)
                                {
                                    com_ListadoMateriales_Det_Info row = new com_ListadoMateriales_Det_Info();

                                    row.IdEmpresa = param.IdEmpresa;

                                    row.CodObra = Obra.get_item();
                                    //row.IdOrdenTaller = Convert.ToInt32(UltraCmbOrdenTaller.EditValue);
                                    row.Det_Kg = ass.Det_Kg;
                                    row.IdDetalle = 0;
                                    row.IdListadoMateriales = 0;
                                    row.IdProducto = ass.IdProducto;
                                    if (ass.IdProducto == 0)
                                    {
                                        MessageBox.Show("Debe corregir su seleccion de productos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                                    }
                                    row.Unidades = ass.Unidades;
                                    row.pr_codigo = ass.pr_codigo;
                                    row.pr_descripcion = ass.pr_descripcion;
                                    if (row.Unidades != 0 && row.Det_Kg != 0)
                                        lsttemp.Add(row);

                                }
                            }
                        }


                        gridCtrlDetListMateriales.DataSource = lsttemp;

                        LstInfoLMat = (List<com_ListadoMateriales_Det_Info>)gridvwDetListMateriales.DataSource;

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        //private void cmbMotivo_ValueChanged_1(object sender, EventArgs e) { }

        private void gridvwDetListMateriales_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            try
            {

                com_ListadoMateriales_Det_Info Info = new com_ListadoMateriales_Det_Info();
                int i = 0;
                //idprod 
                //i = gridvwDetListMateriales.FocusedRowHandle;
                Info = (com_ListadoMateriales_Det_Info)gridvwDetListMateriales.GetFocusedRow();
                in_Producto_Info prod = new in_Producto_Info();
                if (Info != null)
                {
                    prod = BusProd.Get_Info_BuscarProducto(Info.IdProducto, param.IdEmpresa);
                    gridvwDetListMateriales.SetFocusedRowCellValue(colDet_Kg, prod.pr_peso);
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void cmbSucursal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal == null)
                {
                    ucGe_Sucursal_combo1.Text = "";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void cmbSucursal_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal != null)
                {
                    if (Obra.get_item_info() != null)
                    {
                        //UltraCmbOrdenTaller.Properties.DataSource = BUSOT.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, Obra.get_item());
                        //BUSOT.ObtenerListaOT(param.IdEmpresa).FindAll(var => var.IdSucursal == ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal && var.CodObra == Obra.get_item());
                        ////UltraCmbOrdenTaller.DisplayMember = "Codigo";
                        ////UltraCmbOrdenTaller.ValueMember = "IdOrdenTaller";
                        //UltraCmbOrdenTaller.Text = "";
                    }
                    else
                        setearcampos();
                }
                else
                    setearcampos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }


       

        private void _cmbMotivo_EditValueChanged(object sender, EventArgs e)
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

        public void IdMateriales (Int32 idEmpresa)
       { string mensaje = "";
           try
           {
               txtIdLMat.Text = BUsLMat.GetId(idEmpresa, ref   mensaje).ToString();
           }
           catch (Exception ex)
           {
               
              Log_Error_bus.Log_Error(ex.ToString());
           }
       }

        private void ucGe_Menu_Superior_Mant1_Load(object sender, EventArgs e)
        {

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

        private void cmb_producto_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void gridvwDetListMateriales_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                InfoDet = new com_ListadoMateriales_Det_Info();
                InfoDet = (com_ListadoMateriales_Det_Info)this.gridvwDetListMateriales.GetFocusedRow();
                Double LongitudProductoOT; 

                //LongitudProductoOT = Convert.ToDouble(txtLongitudProductoOT.Text);


                if (e.Column.Name == "col_IdProducto" || e.Column.Name == "ColCantidad_pieza_entera" || e.Column.Name == "ColCantidad_total_pieza_complementaria")
                {
                    foreach (var item in ListaBind)
                    {
                        var itemProd = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto);
                        double? suma_largo_restante_pedido = LstInfoLMatxObra.AsEnumerable().Where(row => row.IdProducto == InfoDet.IdProducto).Sum(row => row.largo_restante);

                        if (item.IdProducto == InfoDet.IdProducto)
                        {
                             item.pr_largo = itemProd.pr_largo;
                            //if (LongitudProductoOT <= itemProd.pr_largo) 
                            //{
                            //    item.largo_pieza_entera = LongitudProductoOT;
                            //}
                            //else
                            //{
                            //    item.largo_pieza_entera = itemProd.pr_largo;
                            //    item.largo_pieza_complementaria = LongitudProductoOT - Convert.ToDouble(itemProd.pr_largo);
                            //}
                        }
                        item.Unidades = Convert.ToDouble(item.cantidad_pieza_entera) + Convert.ToDouble(item.cantidad_total_pieza_complementaria);
                    }
                    
                }

                

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridvwDetListMateriales_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                //gridControlObra.ShowPrintPreview();
                string leftColumn = "Fecha: [Date Printed][Time Printed]";
                string middleColumn = "Página:[Page # of Pages #]";
                string rightColumn = "Usuario:" + param.IdUsuario;

                // Create a PageHeaderFooter object and initializing it with
                // the link's PageHeaderFooter.
                if (this.ActiveControl.Name == "gridCtrlDetListMaterialesxObra")
                {
                    PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;
                    // Clear the PageHeaderFooter's contents.
                    phf.Header.Content.Clear();
                    phf.Footer.Content.Clear();
                    Font fte = new System.Drawing.Font("Tahoma", 8.5f, FontStyle.Bold, GraphicsUnit.Point);
                    // Add custom information to the link's header.
                    phf.Header.Font = fte;
                    phf.Footer.Font = fte;
                    phf.Header.Content.AddRange(new string[] { leftColumn, "", rightColumn, "hola" });
                    phf.Header.LineAlignment = BrickAlignment.Center;
                    phf.Footer.Content.AddRange(new string[] { "", "", middleColumn });
                    phf.Footer.LineAlignment = BrickAlignment.Center;
                    printableComponentLink1.Landscape = true;
                    //printableComponentLink1.Component = gridCtrlDetListMaterialesxObra;
                    //printableComponentLink1.Component = this.;
                    printableComponentLink1.Component = gridCtrlDetListMaterialesxObra;
                    printableComponentLink1.ShowPreview();

                }

                if (this.ActiveControl.Name == "gridCtrlDetListMateriales")
                {
                    PageHeaderFooter phf2 = printableComponentLink2.PageHeaderFooter as PageHeaderFooter;
                    // Clear the PageHeaderFooter's contents.
                    phf2.Header.Content.Clear();
                    phf2.Footer.Content.Clear();
                    Font fte = new System.Drawing.Font("Tahoma", 8.5f, FontStyle.Bold, GraphicsUnit.Point);
                    // Add custom information to the link's header.
                    phf2.Header.Font = fte;
                    phf2.Footer.Font = fte;
                    phf2.Header.Content.AddRange(new string[] { leftColumn, "", rightColumn, "hola" });
                    phf2.Header.LineAlignment = BrickAlignment.Center;
                    phf2.Footer.Content.AddRange(new string[] { "", "", middleColumn });
                    phf2.Footer.LineAlignment = BrickAlignment.Center;
                    printableComponentLink2.Landscape = true;
                    //printableComponentLink1.Component = gridCtrlDetListMaterialesxObra;
                    //printableComponentLink1.Component = this.;
                    printableComponentLink2.Component = gridCtrlDetListMateriales;
                    printableComponentLink2.ShowPreview();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
