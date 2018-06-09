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

namespace Core.Erp.Winform.Produccion_Edehsa
{
    public partial class FrmPrd_ListadoMaterialesDisponiblesMant : Form
    {
        #region declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        //d_Obra Obra = new UCPrd_Obra();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_OrdenTaller_Bus BUSOT = new prd_OrdenTaller_Bus();
        com_ListadoMaterialesDisponibles_Det_Bus BusDetLMat = new com_ListadoMaterialesDisponibles_Det_Bus();
        List<com_ListadoMaterialesDisponibles_Det_Info> LstInfoLMat = new List<com_ListadoMaterialesDisponibles_Det_Info>();
        List<com_ListadoMaterialesDisponibles_Det_Info> LstInfoLMatxObra = new List<com_ListadoMaterialesDisponibles_Det_Info>();

        com_ListadoElementos_x_OT_Det_Bus BusListadoElementosDet = new com_ListadoElementos_x_OT_Det_Bus();
        List<com_ListadoElementos_x_OT_Det_Info> ListInfoListadoElementosDet_x_Obra = new List<com_ListadoElementos_x_OT_Det_Info>();


        com_ListadoMaterialesDisponibles_Info InfoLMat = new com_ListadoMaterialesDisponibles_Info();
        com_ListadoMaterialesDisponibles_Bus BUsLMat = new com_ListadoMaterialesDisponibles_Bus();
        List<in_Producto_paraGrilla_Info> LstProducto = new List<in_Producto_paraGrilla_Info>();

        List<in_Producto_Info> listProducto;

        in_producto_Bus BusProd = new in_producto_Bus();
        List<com_Catalogo_Info> LstMotivoReq = new List<com_Catalogo_Info>();
        com_Catalogo_Info MotivoREq = new com_Catalogo_Info();
        com_Catalogo_Bus BusMotivoReq = new com_Catalogo_Bus();

        List<com_Catalogo_Info> ListaCatalogoOC = new List<com_Catalogo_Info>();
        com_Catalogo_Bus BusCatalogoOC = new com_Catalogo_Bus();

        com_ListadoMaterialesDisponibles_Det_Info InfoDet;
        BindingList<com_ListadoMaterialesDisponibles_Det_Info> ListaBind;

        prd_parametros_CusCidersus_Bus param_Produccion = new prd_parametros_CusCidersus_Bus();
        prd_parametros_CusCidersus_Info _Parametros_Info = new prd_parametros_CusCidersus_Info();

        in_movi_inve_detalle_x_Producto_CusCider_Bus BusInve = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Info InfoProductoSobrante = new in_movi_inve_detalle_x_Producto_CusCider_Info();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> listaInfoProductoSobrante= new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();

        #endregion

        public FrmPrd_ListadoMaterialesDisponiblesMant()
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

        private void FrmPrd_ListadoMaterialesDisponiblesMant_Load(object sender, EventArgs e)
        {
            try
            {
                ListaBind = new BindingList<com_ListadoMaterialesDisponibles_Det_Info>();
                gridCtrlDetListMaterialesDisponibles.DataSource = ListaBind;

                cargacontrol();
                cargacombos();
                //cmb_producto.DataSource = BusProd.Get_list_Producto(param.IdEmpresa).
                //    FindAll(var => var.IdProductoTipo == 1);
                BusProd = new in_producto_Bus();
                listProducto = new List<in_Producto_Info>();

                listProducto = BusProd.Get_list_ProductosMateriaPrimaDimension(param.IdEmpresa);
                cmb_producto.DataSource = listProducto;

                cmb_estado.DataSource = BusEA.Get_ListEstadoAprobacion();
                Event_FrmPrd_ListadoMaterialesDisponiblesMant_FormClosing += new Delegate_FrmPrd_ListadoMaterialesDisponiblesMant_FormClosing(FrmPrd_ListadoMaterialesDisponiblesMant_Event_FrmPrd_ListadoMaterialesDisponiblesMant_FormClosing);
                //cargagrid_InventarioFisico();
                cargagrid_InventarioFisico_Sobrante();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
                        
        }

        #region delegado actualiza

        void FrmPrd_ListadoMaterialesDisponiblesMant_Event_FrmPrd_ListadoMaterialesDisponiblesMant_FormClosing(object sender, FormClosingEventArgs e){}

        public delegate void Delegate_FrmPrd_ListadoMaterialesDisponiblesMant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmPrd_ListadoMaterialesDisponiblesMant_FormClosing Event_FrmPrd_ListadoMaterialesDisponiblesMant_FormClosing;

        private void FrmPrd_ListadoMaterialesDisponiblesMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 Event_FrmPrd_ListadoMaterialesDisponiblesMant_FormClosing(sender, e);
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
                if (ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal != null)
                {
                    if (Obra.get_item_info() != null)
                    {

                        ListInfoListadoElementosDet_x_Obra = BusListadoElementosDet.Get_List_ListadoElementos_x_OT_Det(param.IdEmpresa, Obra.get_item());
                        gridCtrlDetListMaterialesDisponiblesxObra.DataSource = ListInfoListadoElementosDet_x_Obra;

                        //cargagrid_InventarioFisico();
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
                //gridCtrlDetListMaterialesDisponibles.DataSource = null;

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

        public void setCab(com_ListadoMaterialesDisponibles_Info InfoLisMat)
        {
            prd_OrdenTaller_Info InfoOT = new prd_OrdenTaller_Info();
            try
            {
                // LLENAR LOS COMBOS DE LOS DATOS DE LA ORDEN

                InfoLMat = InfoLisMat;
                ucGe_Sucursal_combo1.set_SucursalInfo(InfoLisMat.IdSucursal);
                Obra.set_item(InfoLisMat.CodObra);
                dtpFechareg.Value = InfoLisMat.FechaReg;
                txtIdLMat.Text = Convert.ToString(InfoLisMat.IdListadoMaterialesDisponibles);
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

                InfoLMat.IdListadoMaterialesDisponibles = (txtIdLMat.Text == "") ? 0 : Convert.ToInt32(txtIdLMat.Text);

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
                List<com_ListadoMaterialesDisponibles_Det_Info> lsttemp = new List<com_ListadoMaterialesDisponibles_Det_Info>();


                for (int i = 0; i < gridvwDetListMaterialesDisponibles.RowCount; i++)
                {
                    var ass = (com_ListadoMaterialesDisponibles_Det_Info)gridvwDetListMaterialesDisponibles.GetRow(i);
                    if (ass != null)
                    {
                        com_ListadoMaterialesDisponibles_Det_Info row = new com_ListadoMaterialesDisponibles_Det_Info();

                        row.IdEmpresa = param.IdEmpresa;

                        row.CodObra = Obra.get_item();
                        //row.IdOrdenTaller = Convert.ToInt32(UltraCmbOrdenTaller.EditValue);
                        row.Det_Kg = ass.Det_Kg;
                        row.IdDetalle = 0;
                        row.IdListadoMaterialesDisponibles = 0;
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


                //gridCtrlDetListMaterialesDisponibles.DataSource  = lsttemp;
                LstInfoLMat = lsttemp;
                //LstInfoLMat  = (List<com_ListadoMaterialesDisponibles_Det_Info>)gridvwDetListMaterialesDisponibles.DataSource;
                if (LstInfoLMat.Count < 1)
                {
                    MessageBox.Show("Debe ingresar los MaterialesDisponibles para la Orden de Taller", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        void cargagrid(com_ListadoMaterialesDisponibles_Info InfoLMat)
        {

            try
            {

                LstInfoLMat = BusDetLMat.Get_List_ListadoMaterialesDisponibles_Det(InfoLMat.IdEmpresa, InfoLMat.IdListadoMaterialesDisponibles);
                //gridCtrlDetListMaterialesDisponibles.DataSource = LstInfoLMat;

                ListaBind = new BindingList<com_ListadoMaterialesDisponibles_Det_Info>(LstInfoLMat);
                gridCtrlDetListMaterialesDisponibles.DataSource = ListaBind;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        void cargagrid_InventarioFisico()
        {
            string msg = "";
            XINV_Rpt009_Bus Bus = new XINV_Rpt009_Bus();
            List<XINV_Rpt009_Info> lista = new List<XINV_Rpt009_Info>();

            int IdEmpresa = 0;
            int IdBodega = 0;
            int IdSucursal = 0;
            int IdBodegaFin = 0;
            int IdSucursalFin = 0;
            string IdCategoria = "";
            int IdLinea = 0;
            Boolean Registro_Cero = false;
            DateTime Fecha_corte = DateTime.Now;
            IdEmpresa = param.IdEmpresa;

            lista = Bus.Get_data(IdEmpresa, IdSucursal, IdBodega, IdCategoria, IdLinea, Registro_Cero, Fecha_corte, ref msg);

            gridCtrlDetListInventarioFisico.DataSource = lista;

        }

        void cargagrid_InventarioFisico_Sobrante()
        {
            string msg = "";
           

            listaInfoProductoSobrante = BusInve.TraeProductoSobrante(Convert.ToInt16(_Parametros_Info.IdMovi_inven_tipo_ing_Conversion));

            gridCtrlDetListInventarioFisico.DataSource = listaInfoProductoSobrante;

        }



        void Limpiar()
        {
            gridCtrlDetListMaterialesDisponibles.DataSource = null;
            gridCtrlDetListMaterialesDisponibles.DataSource = ListaBind;
            //gridvwDetListMaterialesDisponibles.Columns.Clear();
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

                            LstInfoLMat.ForEach(var => var.IdListadoMaterialesDisponibles = id);
                            int iddetail = 0;
                            LstInfoLMat.ForEach(var => var.IdDetalle = iddetail++);
                            if (BusDetLMat.GuardarDB(LstInfoLMat, cmbEstadoApro.EditValue.ToString()))
                            {
                                {

                                    MessageBox.Show("Se ha procedido a grabar el Listado de MaterialesDisponibles #: " + id.ToString() + " exitosamente.", "Operación Exitosa");
                                }
                                InfoLMat.IdListadoMaterialesDisponibles = id;
                                txtIdLMat.Text = Convert.ToString(id);
                                txtUsuario.Text = param.IdUsuario;
                                //setCab(InfoLMat);


                                set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                gridvwDetListMaterialesDisponibles.SelectAll();
                                gridvwDetListMaterialesDisponibles.DeleteSelectedRows();
                                cargagrid(InfoLMat);
                            }
                        }
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (BUsLMat.ModificarDB(InfoLMat, ref  msg))
                        {
                            List<com_ListadoMaterialesDisponibles_Det_Info> templst = new List<com_ListadoMaterialesDisponibles_Det_Info>();
                            templst = BusDetLMat.Get_List_ListadoMaterialesDisponibles_Det(param.IdEmpresa, InfoLMat.IdListadoMaterialesDisponibles);

                            if (templst.Count != 0)
                            {
                                if (BusDetLMat.EliminarDB(templst, ref msg))
                                {
                                    LstInfoLMat.ForEach(var => var.IdListadoMaterialesDisponibles = InfoLMat.IdListadoMaterialesDisponibles);
                                    int iddetail = 0;
                                    LstInfoLMat.ForEach(var => var.IdDetalle = iddetail++);
                                    LstInfoLMat.ForEach(var => var.lm_IdEstadoAprobado = "X APRO");
                                    if (BusDetLMat.GuardarDB(LstInfoLMat, ""))
                                    {
                                        MessageBox.Show("Se ha procedido a grabar el Listado de MaterialesDisponibles #: " + InfoLMat.IdListadoMaterialesDisponibles.ToString() + " exitosamente.", "Operación Exitosa");
                                    }
                                }
                                //MessageBox.Show(msg+"No se Actualizo el registro de la Orden/Compra #: " + InfoLMat.IdListadoMaterialesDisponibles.ToString(), "Operación Fallida");

                            }
                        }
                        else
                        {
                            MessageBox.Show(msg+ "No se ha grabado el registro de la Orden/Compra #: " + InfoLMat.IdListadoMaterialesDisponibles.ToString(), "Operación Fallida");
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
                if (MessageBox.Show("¿Está seguro que desea anular la Lista de MaterialesDisponibles N#: " + InfoLMat.IdListadoMaterialesDisponibles + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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



                if (txtObservacion.Text == "")
                {
                    errorProviderValidarTxt.SetError(txtObservacion, "Ingrese una Observacion");
                    B_ValidarCajasTextos = true;
                }



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

                ////-- CARLOS ACTALIZACION

                //xrpt_prd_ListadoMaterialesDisponibles Xrpt_ListMat = new xrpt_prd_ListadoMaterialesDisponibles();
                //com_rpt_ListadoMaterialesDisponibles_Info InfoRptListMat = new com_rpt_ListadoMaterialesDisponibles_Info();
                //prd_ObtenerReporte_Bus ObtDatos = new prd_ObtenerReporte_Bus();
                //List<com_rpt_ListadoMaterialesDisponibles_Info> LstInfoRep = new List<com_rpt_ListadoMaterialesDisponibles_Info>();


                //var cab = (com_ListadoMaterialesDisponibles_Info)BUsLMat.Get_Info_ListadoMaterialesDisponibles(param.IdEmpresa, InfoLMat.IdListadoMaterialesDisponibles);
                //if (cab != null)
                //{
                //    List<tbPRO_CUS_CID_Rpt003_Info> data = new List<tbPRO_CUS_CID_Rpt003_Info>();
                //    //data = ObtDatos.OptenerData_spPRD_Rpt_RPRD003(param.IdEmpresa, Convert.ToInt32(param.IdSucursal), cab.IdListadoMaterialesDisponibles);
                //    //Xrpt_ListMat.loadData(data.ToArray());
                //    //Xrpt_ListMat.ShowPreviewDialog();

                //}
                //else
                //{
                //    MessageBox.Show("Ha ocurrido un error al cargar los datos. "
                //        + "Por favor comuniquese con sistemas...");
                //}

               
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

        private void gridvwDetListMaterialesDisponibles_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                com_ListadoMaterialesDisponibles_Det_Info Temp = new com_ListadoMaterialesDisponibles_Det_Info();
                Temp = (com_ListadoMaterialesDisponibles_Det_Info)gridvwDetListMaterialesDisponibles.GetFocusedRow();
                if ((e.KeyChar == (char)8))
                {
                    if (MessageBox.Show("¿Desea eliminar el producto: " + Temp.pr_descripcion + " de la Lista ?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        List<com_ListadoMaterialesDisponibles_Det_Info> lsttemp = new List<com_ListadoMaterialesDisponibles_Det_Info>();


                        for (int i = 0; i < gridvwDetListMaterialesDisponibles.RowCount; i++)
                        {
                            if (i != gridvwDetListMaterialesDisponibles.FocusedRowHandle)
                            {
                                var ass = (com_ListadoMaterialesDisponibles_Det_Info)gridvwDetListMaterialesDisponibles.GetRow(i);
                                if (ass != null)
                                {
                                    com_ListadoMaterialesDisponibles_Det_Info row = new com_ListadoMaterialesDisponibles_Det_Info();

                                    row.IdEmpresa = param.IdEmpresa;

                                    row.CodObra = Obra.get_item();
                                    //row.IdOrdenTaller = Convert.ToInt32(UltraCmbOrdenTaller.EditValue);
                                    row.Det_Kg = ass.Det_Kg;
                                    row.IdDetalle = 0;
                                    row.IdListadoMaterialesDisponibles = 0;
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


                        gridCtrlDetListMaterialesDisponibles.DataSource = lsttemp;

                        LstInfoLMat = (List<com_ListadoMaterialesDisponibles_Det_Info>)gridvwDetListMaterialesDisponibles.DataSource;

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }



        private void gridvwDetListMaterialesDisponibles_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            try
            {

                com_ListadoMaterialesDisponibles_Det_Info Info = new com_ListadoMaterialesDisponibles_Det_Info();
                int i = 0;
                //idprod 
                //i = gridvwDetListMaterialesDisponibles.FocusedRowHandle;
                Info = (com_ListadoMaterialesDisponibles_Det_Info)gridvwDetListMaterialesDisponibles.GetFocusedRow();
                in_Producto_Info prod = new in_Producto_Info();
                if (Info != null)
                {
                    prod = BusProd.Get_Info_BuscarProducto(Info.IdProducto, param.IdEmpresa);
                    gridvwDetListMaterialesDisponibles.SetFocusedRowCellValue(colDet_Kg, prod.pr_peso);
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

        public void IdMaterialesDisponibles (Int32 idEmpresa)
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

        private void gridvwDetListMaterialesDisponibles_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                InfoDet = new com_ListadoMaterialesDisponibles_Det_Info();
                InfoDet = (com_ListadoMaterialesDisponibles_Det_Info)this.gridvwDetListMaterialesDisponibles.GetFocusedRow();
                Double LongitudProductoOT; 

                if (e.Column.Name == "col_IdProducto" || e.Column.Name == "ColCantidad_pieza_entera" || e.Column.Name == "ColCantidad_total_pieza_complementaria")
                {
                    foreach (var item in ListaBind)
                    {
                        var itemProd = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto);
                        double? suma_largo_restante_pedido = LstInfoLMatxObra.AsEnumerable().Where(row => row.IdProducto == InfoDet.IdProducto).Sum(row => row.largo_restante);

                        if (item.IdProducto == InfoDet.IdProducto)
                        {

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


    }
}
