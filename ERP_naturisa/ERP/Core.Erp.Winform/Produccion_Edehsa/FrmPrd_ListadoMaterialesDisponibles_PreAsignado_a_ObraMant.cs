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

namespace Core.Erp.Winform.Produccion_Edehsa
{
    public partial class FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant : Form
    {
        #region declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        //d_Obra Obra = new UCPrd_Obra();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_OrdenTaller_Bus BUSOT = new prd_OrdenTaller_Bus();
        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus BusDetLMat = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus();
        List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstInfoLMat = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
        List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstInfoLMatxObra = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();

        List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Info_LstMPDisponible = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus BusDetLstMPDisponible = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus();

        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info InfoLMat = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info();
        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Bus BUsLMat = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Bus();
        List<in_Producto_paraGrilla_Info> LstProducto = new List<in_Producto_paraGrilla_Info>();

        List<in_Producto_Info> listProducto;

        in_producto_Bus BusProd = new in_producto_Bus();
        List<com_Catalogo_Info> LstMotivoReq = new List<com_Catalogo_Info>();
        com_Catalogo_Info MotivoREq = new com_Catalogo_Info();
        com_Catalogo_Bus BusMotivoReq = new com_Catalogo_Bus();

        List<com_Catalogo_Info> ListaCatalogoOC = new List<com_Catalogo_Info>();
        com_Catalogo_Bus BusCatalogoOC = new com_Catalogo_Bus();

        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info InfoDet;
        BindingList<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> ListaBind;

        prd_parametros_CusCidersus_Bus param_Produccion = new prd_parametros_CusCidersus_Bus();
        prd_parametros_CusCidersus_Info _Parametros_Info = new prd_parametros_CusCidersus_Info();

        in_movi_inve_detalle_x_Producto_CusCider_Bus BusInve = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Info InfoProductoSobrante = new in_movi_inve_detalle_x_Producto_CusCider_Info();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> listaInfoProductoSobrante= new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();

        in_movi_inve_detalle_x_Producto_CusCider_Bus BusInMoviInvexProducto_CusCider = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Info InfoInMoviInvexProducto_CusCider = new in_movi_inve_detalle_x_Producto_CusCider_Info();

        #endregion

        public FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant()
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

        private void FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_Load(object sender, EventArgs e)
        {
            try
            {
                ListaBind = new BindingList<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
                gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = ListaBind;

                carga_mp_disponible();

                cargacontrol();
                cargacombos();
                //cmb_producto.DataSource = BusProd.Get_list_Producto(param.IdEmpresa).
                //    FindAll(var => var.IdProductoTipo == 1);
                BusProd = new in_producto_Bus();
                listProducto = new List<in_Producto_Info>();

                listProducto = BusProd.Get_list_ProductosMateriaPrimaDimension(param.IdEmpresa);
                Event_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing += new Delegate_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing(FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_Event_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing);
                //cargagrid_InventarioFisico();
                cargagrid_InventarioFisico_Sobrante();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
                        
        }

        #region delegado actualiza

        void FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_Event_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing(object sender, FormClosingEventArgs e) { }

        public delegate void Delegate_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing Event_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing;

        private void FrmPrd_ListadoMaterialesDisponiblesMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_FrmPrd_ListadoMaterialesDisponibles_PreAsignado_a_ObraMant_FormClosing(sender, e);
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

                //Obra.Event_UCObra_EditValueChanged += Obra_Event_UCObra_EditValueChanged;

                Obra.Event_UCObra_Validating += new UCPrd_Obra.delegadoUCObra_Validating(Obra_Event_UCObra_Validating);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);

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
                //gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = null;

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

        public void setCab(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info InfoLisMat)
        {
            prd_OrdenTaller_Info InfoOT = new prd_OrdenTaller_Info();
            try
            {
                //// LLENAR LOS COMBOS DE LOS DATOS DE LA ORDEN

                //InfoLMat = InfoLisMat;
                //ucGe_Sucursal_combo1.set_SucursalInfo(InfoLisMat.IdSucursal);
                //Obra.set_item(InfoLisMat.CodObra_preasignada);
                //dtpFechareg.Value = InfoLisMat.FechaReg;
                //txtIdLMat.Text = Convert.ToString(InfoLisMat.IdNumMovi);
                ////dTPFecRegOT.Value = InfoOT.FechaReg;
                //txtUsuario.Text = InfoLisMat.Usuario;
                //txtObservacion.Text = InfoLisMat.lm_Observacion;
                ////txtIdOT.Text =Convert.ToString( InfoOT.IdOrdenTaller);
                //if (InfoLisMat.Estado == "I")
                //{
                //    lblAnulado.Visible = true;
                //    set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                //}
                //cargagrid(InfoLisMat);

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
                InfoLMat.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                InfoLMat.CodObra_preasignada = Obra.get_item();
                //InfoLMat.IdNumMovi = (txtIdLMat.Text == "") ? 0 : Convert.ToInt32(txtIdLMat.Text);

                
                ////InfoLMat.IdOrdenTaller = (decimal)UltraCmbOrdenTaller.EditValue;
                InfoLMat.FechaReg = dtpFechareg.Value;
                InfoLMat.Motivo = "EST_APR_LIS_REQ";
                
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
                List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> lsttemp = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();


                for (int i = 0; i < gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.RowCount; i++)
                {
                    var ass = (com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info)gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.GetRow(i);
                    if (ass != null && ass.pre_asignar == true)
                    {
                        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info row = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();

                        row.IdEmpresa = param.IdEmpresa;
                        row.IdSucursal = param.IdSucursal;
                        row.IdBodega = ass.IdBodega;
                        row.IdMovi_inven_tipo = ass.IdMovi_inven_tipo;
                        row.IdNumMovi = ass.IdNumMovi;
                        row.mv_Secuencia = ass.mv_Secuencia;
                        row.Secuencia = ass.Secuencia;

                        row.CodObra_preasignada = Obra.get_item();
                        row.IdProducto = ass.IdProducto;
                        row.CodigoBarra = ass.CodigoBarra;

                        row.longitud = ass.longitud;
                        row.alto = ass.alto;
                        row.espesor = ass.espesor;
                        

                        row.Det_Kg = ass.Det_Kg;
                      
                        //row.IdNumMovi = 0;
                       
                        row.IdEstadoAprob = "PEN";

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
                        row.dm_cantidad = ass.dm_cantidad;
                        row.pr_codigo = ass.pr_codigo;
                        row.pr_descripcion = ass.pr_descripcion;
                        if (row.dm_cantidad > 0)
                            lsttemp.Add(row);
                        else
                        {
                            MessageBox.Show("Debe corregir la cantidad de los productos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;

                        }

                    }
                }


                //gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource  = lsttemp;
                LstInfoLMat = lsttemp;
                //LstInfoLMat  = (List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>)gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource;
                if (LstInfoLMat.Count < 1)
                {
                    MessageBox.Show("Debe ingresar los MaterialesDisponibles_PreAsignado_a_Obra para la Orden de Taller", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        void cargagrid(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info InfoLMat)
        {

            try
            {

                LstInfoLMat = BusDetLMat.Get_List_All_MP_Disponibles(InfoLMat.IdEmpresa);
                //gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = LstInfoLMat;

                ListaBind = new BindingList<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>(LstInfoLMat);
                gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = ListaBind;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        void carga_mp_disponible()
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    Info_LstMPDisponible = BusDetLstMPDisponible.Get_List_All_MP_Disponibles(param.IdEmpresa);

                    gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = Info_LstMPDisponible;
                    gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        void cargagrid_InventarioFisico_Sobrante()
        {
            string msg = "";
           

            listaInfoProductoSobrante = BusInve.TraeProductoSobrante(Convert.ToInt16(_Parametros_Info.IdMovi_inven_tipo_ing_Conversion));

            //gridCtrlDetListInventarioFisico.DataSource = listaInfoProductoSobrante;

        }


        void Limpiar()
        {
            gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = null;
            gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = ListaBind;
            //gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.Columns.Clear();
        }


        void grabar()
        {

            try
            {
                decimal id = 0;
                string msg = "";
               


                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (BusDetLstMPDisponible.GuardarDB(LstInfoLMat, cmbEstadoApro.EditValue.ToString()))
                            {
                                

                                MessageBox.Show("Se ha procedido a grabar Los Materiales Disponibles a la Obra #: " + Obra.get_item().ToString() + " exitosamente.", "Operación Exitosa");

                                ActulizarInMoviInveDet_Producto_CusCider(InfoLMat, ref  msg);
                                
                                InfoLMat.IdNumMovi = id;
                                txtIdLMat.Text = Convert.ToString(id);
                                txtUsuario.Text = param.IdUsuario;
                                //setCab(InfoLMat);
                                
                                
                                

                                set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.SelectAll();
                                gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.DeleteSelectedRows();
                                gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.ViewCaption = Obra.get_item();
                                gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = LstInfoLMat;
                                
                                gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.RefreshDataSource();

                                //cargagrid(InfoLMat);
                            }
                        
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        //if (BUsLMat.ModificarDB(InfoLMat, ref  msg))
                        //{
                        //    List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> templst = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
                        //    templst = BusDetLMat.Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det(param.IdEmpresa, InfoLMat.IdNumMovi);

                        //    if (templst.Count != 0)
                        //    {
                        //        if (BusDetLMat.EliminarDB(templst, ref msg))
                        //        {
                        //            LstInfoLMat.ForEach(var => var.IdNumMovi = InfoLMat.IdNumMovi);
                        //            int iddetail = 0;
                        //            LstInfoLMat.ForEach(var => var.IdDetalle = iddetail++);
                        //            LstInfoLMat.ForEach(var => var.lm_IdEstadoAprobado = "X APRO");
                        //            if (BusDetLMat.GuardarDB(LstInfoLMat, ""))
                        //            {
                        //                MessageBox.Show("Se ha procedido a grabar el Listado de MaterialesDisponibles_PreAsignado_a_Obra #: " + InfoLMat.IdNumMovi.ToString() + " exitosamente.", "Operación Exitosa");
                        //            }
                        //        }
                        //        //MessageBox.Show(msg+"No se Actualizo el registro de la Orden/Compra #: " + InfoLMat.IdListadoMaterialesDisponibles_PreAsignado_a_Obra.ToString(), "Operación Fallida");

                        //    }
                        //}
                        //else
                        //{
                        //    MessageBox.Show(msg+ "No se ha grabado el registro de la Orden/Compra #: " + InfoLMat.IdNumMovi.ToString(), "Operación Fallida");
                        //}
                        //break;


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
            //try
            //{
                
            //    string msg = "";
            //    if (MessageBox.Show("¿Está seguro que desea anular la Lista de MaterialesDisponibles_PreAsignado_a_Obra N#: " + InfoLMat.IdListadoMaterialesDisponibles_PreAsignado_a_Obra + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        InfoLMat.lm_Observacion = "***ANULADO***" + InfoLMat.lm_Observacion;
            //        lblAnulado.Visible = true;
            //        BUsLMat.AnularDB(InfoLMat, ref msg);
                    
            //        set_Accion(Cl_Enumeradores.eTipo_action.consultar);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    Log_Error_bus.Log_Error(ex.ToString());
            //    MessageBox.Show(ex.ToString());
            //}



        }
        public Boolean ActulizarInMoviInveDet_Producto_CusCider(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info InfoLMat, ref  string msg) 
        {
            try
            {
                foreach (var item in LstInfoLMat)
                {
                    InfoInMoviInvexProducto_CusCider.IdEmpresa = item.IdEmpresa;
                    InfoInMoviInvexProducto_CusCider.IdSucursal = item.IdSucursal;
                    InfoInMoviInvexProducto_CusCider.IdBodega = item.IdBodega;
                    InfoInMoviInvexProducto_CusCider.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    InfoInMoviInvexProducto_CusCider.IdNumMovi = item.IdNumMovi;
                    InfoInMoviInvexProducto_CusCider.mv_Secuencia = item.mv_Secuencia;
                    InfoInMoviInvexProducto_CusCider.Secuencia = item.Secuencia;
                    InfoInMoviInvexProducto_CusCider.IdProducto = item.IdProducto;
                    InfoInMoviInvexProducto_CusCider.CodigoBarra = item.CodigoBarra;

                    InfoInMoviInvexProducto_CusCider.CodObra_preasignada = item.CodObra_preasignada;

                    BusInMoviInvexProducto_CusCider.ActualizarCodObra_preasignada(InfoInMoviInvexProducto_CusCider, ref msg);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;

            }
            

            return true;
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

                //gridControlObra.ShowPrintPreview();
                string leftColumn = "Fecha: [Date Printed][Time Printed]"
                                    +" Obra: " + Obra.get_item_info().Descripcion;
                string middleColumn = "Página:[Page # of Pages #]";
                string rightColumn = "Usuario:" + param.IdUsuario;

                 //Create a PageHeaderFooter object and initializing it with
                 //the link's PageHeaderFooter.

                PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;

                 //Clear the PageHeaderFooter's contents.
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
               
                printableComponentLink1.Component = gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra;

                printableComponentLink1.ShowPreview();

               
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

        private void gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Temp = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
                Temp = (com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info)gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.GetFocusedRow();
                if ((e.KeyChar == (char)8))
                {
                    if (MessageBox.Show("¿Desea eliminar el producto: " + Temp.pr_descripcion + " de la Lista ?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> lsttemp = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();


                        for (int i = 0; i < gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.RowCount; i++)
                        {
                            if (i != gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.FocusedRowHandle)
                            {
                                var ass = (com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info)gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.GetRow(i);
                                if (ass != null)
                                {
                                    com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info row = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();

                                    row.IdEmpresa = param.IdEmpresa;

                                    row.CodObra_preasignada = Obra.get_item();
                                    //row.IdOrdenTaller = Convert.ToInt32(UltraCmbOrdenTaller.EditValue);
                                    row.Det_Kg = ass.Det_Kg;
                                    //row.IdDetalle = 0;
                                    row.IdNumMovi = ass.IdNumMovi;
                                    row.IdProducto = ass.IdProducto;
                                    if (ass.IdProducto == 0)
                                    {
                                        MessageBox.Show("Debe corregir su seleccion de productos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                                    }
                                    row.dm_cantidad = ass.dm_cantidad;
                                    row.pr_codigo = ass.pr_codigo;
                                    row.pr_descripcion = ass.pr_descripcion;
                                    if (row.dm_cantidad != 0 && row.Det_Kg != 0)
                                        lsttemp.Add(row);

                                }
                            }
                        }


                        gridCtrlDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource = lsttemp;

                        LstInfoLMat = (List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>)gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource;

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }



        private void gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            try
            {

                com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Info = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
                int i = 0;
                //idprod 
                //i = gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.FocusedRowHandle;
                Info = (com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info)gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.GetFocusedRow();
                in_Producto_Info prod = new in_Producto_Info();
                if (Info != null)
                {
                    prod = BusProd.Get_Info_BuscarProducto(Info.IdProducto, param.IdEmpresa);
                    gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.SetFocusedRowCellValue(colDet_Kg, prod.pr_peso);
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

        public void IdMaterialesDisponibles_PreAsignado_a_Obra (Int32 idEmpresa)
       { string mensaje = "";
           try
           {
               //txtIdLMat.Text = BUsLMat.GetId(idEmpresa, ref   mensaje).ToString();
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

        private void gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                InfoDet = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
                InfoDet = (com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info)this.gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.GetFocusedRow();
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
                        item.dm_cantidad = Convert.ToDouble(item.cantidad_pieza_entera) + Convert.ToDouble(item.cantidad_total_pieza_complementaria);
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
