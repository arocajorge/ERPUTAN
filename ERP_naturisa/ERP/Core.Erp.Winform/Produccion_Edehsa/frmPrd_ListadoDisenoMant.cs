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
using Core.Erp.Business.Compras_Edehsa;
using Core.Erp.Info.Compras_Edehsa;
using Cus.Erp.Reports.Cidersus;

namespace Core.Erp.Winform.Produccion_Edehsa
{
    public partial class frmPrd_ListadoDisenoMant : Form
    {
       #region declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        //d_Obra Obra = new UCPrd_Obra();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_OrdenTaller_Bus BUSOT = new prd_OrdenTaller_Bus();

        com_ListadoMateriales_Det_Bus BusDetLMat = new com_ListadoMateriales_Det_Bus();
        List<com_ListadoMateriales_Det_Info> LstInfoLMat = new List<com_ListadoMateriales_Det_Info>();
        com_ListadoMateriales_Info InfoLMat = new com_ListadoMateriales_Info();
        com_ListadoMateriales_Bus BUsLMat = new com_ListadoMateriales_Bus();

        //com_ListadoDiseno
        com_ListadoDiseno_Det_Bus BusDetLDiseno = new com_ListadoDiseno_Det_Bus();
        List<com_ListadoDiseno_Det_Info> LstInfoLDiseno = new List<com_ListadoDiseno_Det_Info>();
        com_ListadoDiseno_Info InfoLDiseno = new com_ListadoDiseno_Info();
        com_ListadoDiseno_Bus BUsLDiseno = new com_ListadoDiseno_Bus();


        List<in_Producto_paraGrilla_Info> LstProducto = new List<in_Producto_paraGrilla_Info>();
        in_producto_Bus BusProd = new in_producto_Bus();


        List<com_Catalogo_Info> LstMotivoReq = new List<com_Catalogo_Info>();
        com_Catalogo_Info MotivoREq = new com_Catalogo_Info();
        com_Catalogo_Bus BusMotivoReq = new com_Catalogo_Bus();

        List<com_Catalogo_Info> ListaCatalogoOC = new List<com_Catalogo_Info>();
        com_Catalogo_Bus BusCatalogoOC = new com_Catalogo_Bus();

        com_ListadoDisenoTipo_Bus BusListadoDisenoTipo = new com_ListadoDisenoTipo_Bus();

        #endregion

        public frmPrd_ListadoDisenoMant()
        {
            try
            {

              InitializeComponent();
              ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
              ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
              ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
              ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
              ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmPrd_ListadoDisenoMant_Load(object sender, EventArgs e)
        {
            try
            {
                cargacontrol();
                cargacombos();
                //cmb_producto.DataSource = BusProd.Get_list_Producto(param.IdEmpresa).
                //    FindAll(var => var.IdProductoTipo == 1);

                //cmb_producto.DataSource = BusProd.Get_list_ProductosMateriaPrima(param.IdEmpresa);
                //Se cambia de Materia Prima a Productos terminados, pues el formulario es para Listado de Diseno

                cmb_producto.DataSource = BusProd.Get_list_ProductosTerminados(param.IdEmpresa);

                cmbListadoDisenoTipo.Properties.DataSource = BusListadoDisenoTipo.ObtenerListadoDisenoTipo(param.IdEmpresa);
                cmb_estado.DataSource = BusEA.Get_ListEstadoAprobacion();
                Event_frmPrd_ListadoDisenoMant_FormClosing += new Delegate_frmPrd_ListadoDisenoMant_FormClosing(frmPrd_ListadoDisenoMant_Event_frmPrd_ListadoDisenoMant_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
                        
        }

        #region delegado actualiza

        void frmPrd_ListadoDisenoMant_Event_frmPrd_ListadoDisenoMant_FormClosing(object sender, FormClosingEventArgs e){}

        public delegate void Delegate_frmPrd_ListadoDisenoMant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmPrd_ListadoDisenoMant_FormClosing Event_frmPrd_ListadoDisenoMant_FormClosing;

        private void frmPrd_ListadoDisenoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 Event_frmPrd_ListadoDisenoMant_FormClosing(sender, e);
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
                if (ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal != null)
                {
                    if (Obra.get_item_info() != null)
                    {
                        //UltraCmbOrdenTaller.DataSource = BUSOT.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, Obra.get_item());
                        //BUSOT.ObtenerListaOT(param.IdEmpresa).FindAll(var => var.IdSucursal == Convert.ToInt32(cmbSucursal.Value) && var.CodObra == Obra.get_item());

                        

                       
                        
                        //UltraCmbOrdenTaller.Properties.DataSource = BUSOT.ObtenerListaOT(param.IdEmpresa).FindAll(var =>
                        //    var.IdSucursal == Convert.ToInt32(cmbSucursal.Value) && var.CodObra == Obra.get_item());                       

                        //UltraCmbOrdenTaller.DisplayMember = "Codigo";
                        //UltraCmbOrdenTaller.ValueMember = "IdOrdenTaller";
                        //UltraCmbOrdenTaller.Text = "";

                      

                       // InfoOT = listOrdTaller.FirstOrDefault(v => v.IdEmpresa == param.IdEmpresa && v.IdSucursal == Convert.ToInt32(cmbSucursal.Value)&& v.IdOrdenTaller==item);

                     
                  
                        //InfoOT = (prd_OrdenTaller_Info)UltraCmbOrdenTaller.Properties.View.GetFocusedRow();//.ListObject

                 
                        //InfoOT = BUSOT.ObtenerUnaOT(param.IdEmpresa, param.IdSucursal, (decimal)UltraCmbOrdenTaller.Value , Obra.get_item());
                        
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

        public void setCab(com_ListadoDiseno_Info InfoLisMat)
        {
            prd_OrdenTaller_Info InfoOT = new prd_OrdenTaller_Info();
            try
            {
                // LLENAR LOS COMBOS DE LOS DATOS DE LA ORDEN

                InfoLDiseno = InfoLisMat;
                ucGe_Sucursal_combo1.set_SucursalInfo(InfoLisMat.IdSucursal);
                Obra.set_item(InfoLisMat.CodObra);
                dtpFechareg.Value = InfoLisMat.FechaReg;
                
                cmbListadoDisenoTipo.EditValue = InfoLisMat.tipo_listado;
                InfoOT = BUSOT.ObtenerUnaOT(param.IdEmpresa, InfoLisMat.IdSucursal, InfoLisMat.IdOrdenTaller, InfoLisMat.CodObra);
               
                txtUsuario.Text = InfoLisMat.Usuario;
                txtObservacion.Text = InfoLisMat.lm_Observacion;
                
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
                InfoLDiseno.IdEmpresa = param.IdEmpresa;

                InfoLDiseno.IdListadoDiseno = (txtIdLMat.Text == "") ? 0 : Convert.ToInt32(txtIdLMat.Text);

                InfoLDiseno.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                
                InfoLDiseno.FechaReg = dtpFechareg.Value;
                InfoLDiseno.Motivo = "EST_APR_LIS_REQ";
                InfoLDiseno.CodObra = Obra.get_item();
                InfoLDiseno.Estado = "A";
                InfoLDiseno.Usuario = param.IdUsuario;
                InfoLDiseno.lm_Observacion = txtObservacion.Text;
                InfoLDiseno.tipo_listado = cmbListadoDisenoTipo.EditValue.ToString();

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
                List<com_ListadoDiseno_Det_Info> lsttemp = new List<com_ListadoDiseno_Det_Info>();


                for (int i = 0; i < gridvwDetListMateriales.RowCount; i++)
                {
                    var ass = (com_ListadoDiseno_Det_Info)gridvwDetListMateriales.GetRow(i);
                    if (ass != null)
                    {
                        com_ListadoDiseno_Det_Info row = new com_ListadoDiseno_Det_Info();

                        row.IdEmpresa = param.IdEmpresa;

                        row.CodObra = Obra.get_item();
                        
                        row.Det_Kg = ass.Det_Kg;
                        row.IdDetalle = 0;
                        row.IdListadoDiseno = 0;
                        row.IdProducto = ass.IdProducto;
                        row.lm_IdEstadoAprobado = "PEN";
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
                LstInfoLDiseno = lsttemp;
                //LstInfoLDiseno  = (List<com_ListadoMateriales_Det_Info>)gridvwDetListMateriales.DataSource;
                if (LstInfoLDiseno.Count < 1)
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

        void cargagrid(com_ListadoDiseno_Info InfoLDiseno)
        {

            try
            {

                LstInfoLDiseno = BusDetLDiseno.Get_List_ListadoDiseno_Det(InfoLDiseno.IdEmpresa, InfoLDiseno.IdListadoDiseno);
                gridCtrlDetListMateriales.DataSource = LstInfoLDiseno;
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

                        if (BUsLDiseno.GrabarDB(InfoLDiseno, ref id, ref msg))
                        {

                            LstInfoLDiseno.ForEach(var => var.IdListadoDiseno = id);
                            int iddetail = 0;
                            LstInfoLDiseno.ForEach(var => var.IdDetalle = iddetail++);
                            if (BusDetLDiseno.GuardarDB(LstInfoLDiseno, cmbEstadoApro.EditValue.ToString()))
                            {
                                {

                                    MessageBox.Show("Se ha procedido a grabar el Listado de Materiales #: " + id.ToString() + " exitosamente.", "Operación Exitosa");
                                }
                                InfoLDiseno.IdListadoDiseno = id;
                                txtIdLMat.Text = Convert.ToString(id);
                                txtUsuario.Text = param.IdUsuario;
                                //setCab(InfoLDiseno);


                                set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                gridvwDetListMateriales.SelectAll();
                                gridvwDetListMateriales.DeleteSelectedRows();
                                cargagrid(InfoLDiseno);
                            }
                        }
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (BUsLDiseno.ModificarDB(InfoLDiseno, ref  msg))
                        {
                            List<com_ListadoDiseno_Det_Info> templst = new List<com_ListadoDiseno_Det_Info>();
                            templst = BusDetLDiseno.Get_List_ListadoDiseno_Det(param.IdEmpresa, InfoLDiseno.IdListadoDiseno);

                            if (templst.Count != 0)
                            {
                                if (BusDetLDiseno.EliminarDB(templst, ref msg))
                                {
                                    LstInfoLDiseno.ForEach(var => var.IdListadoDiseno = InfoLDiseno.IdListadoDiseno);
                                    int iddetail = 0;
                                    LstInfoLDiseno.ForEach(var => var.IdDetalle = iddetail++);
                                    LstInfoLDiseno.ForEach(var => var.lm_IdEstadoAprobado = "X APRO");
                                    if (BusDetLDiseno.GuardarDB(LstInfoLDiseno, ""))
                                    {
                                        MessageBox.Show("Se ha procedido a grabar el Listado de Materiales #: " + InfoLDiseno.IdListadoDiseno.ToString() + " exitosamente.", "Operación Exitosa");
                                    }
                                }
                                //MessageBox.Show(msg+"No se Actualizo el registro de la Orden/Compra #: " + InfoLDiseno.IdListadoDiseno.ToString(), "Operación Fallida");

                            }
                        }
                        else
                        {
                            MessageBox.Show(msg+ "No se ha grabado el registro de la Orden/Compra #: " + InfoLDiseno.IdListadoDiseno.ToString(), "Operación Fallida");
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
                if (MessageBox.Show("¿Está seguro que desea anular la Lista de Materiales N#: " + InfoLDiseno.IdListadoDiseno + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InfoLDiseno.lm_Observacion = "***ANULADO***" + InfoLDiseno.lm_Observacion;
                    lblAnulado.Visible = true;
                    BUsLDiseno.AnularDB(InfoLDiseno, ref msg);
                    
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

                //xrpt_prd_ListadoDiseno Xrpt_ListMat = new xrpt_prd_ListadoDiseno();
                //com_rpt_ListadoDiseno_Info InfoRptListMat = new com_rpt_ListadoDiseno_Info();
                //prd_ObtenerReporte_Bus ObtDatos = new prd_ObtenerReporte_Bus();
                //List<com_rpt_ListadoDiseno_Info> LstInfoRep = new List<com_rpt_ListadoDiseno_Info>();


                //var cab = (com_ListadoDiseno_Info)BUsLDiseno.Get_Info_ListadoDiseno(param.IdEmpresa, InfoLDiseno.IdListadoDiseno);
                //if (cab != null)
                //{
                //    List<tbPRO_CUS_CID_Rpt003_Info> data = new List<tbPRO_CUS_CID_Rpt003_Info>();
                //    //data = ObtDatos.OptenerData_spPRD_Rpt_RPRD003(param.IdEmpresa, Convert.ToInt32(param.IdSucursal), cab.IdListadoMateriales);
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
                  cargagrid(InfoLDiseno);
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



                com_ListadoDiseno_Det_Info Temp = new com_ListadoDiseno_Det_Info();
                Temp = (com_ListadoDiseno_Det_Info)gridvwDetListMateriales.GetFocusedRow();
                if ((e.KeyChar == (char)8))
                {
                    if (MessageBox.Show("¿Desea eliminar el producto: " + Temp.pr_descripcion + " de la Lista ?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        List<com_ListadoDiseno_Det_Info> lsttemp = new List<com_ListadoDiseno_Det_Info>();


                        for (int i = 0; i < gridvwDetListMateriales.RowCount; i++)
                        {
                            if (i != gridvwDetListMateriales.FocusedRowHandle)
                            {
                                var ass = (com_ListadoDiseno_Det_Info)gridvwDetListMateriales.GetRow(i);
                                if (ass != null)
                                {
                                    com_ListadoDiseno_Det_Info row = new com_ListadoDiseno_Det_Info();

                                    row.IdEmpresa = param.IdEmpresa;

                                    row.CodObra = Obra.get_item();
                                   
                                    row.Det_Kg = ass.Det_Kg;
                                    row.IdDetalle = 0;
                                    row.IdListadoDiseno = 0;
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

                        LstInfoLDiseno = (List<com_ListadoDiseno_Det_Info>)gridvwDetListMateriales.DataSource;

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

                com_ListadoDiseno_Det_Info Info = new com_ListadoDiseno_Det_Info();
                int i = 0;
                //idprod 
                //i = gridvwDetListMateriales.FocusedRowHandle;
                Info = (com_ListadoDiseno_Det_Info)gridvwDetListMateriales.GetFocusedRow();
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
               txtIdLMat.Text = BUsLDiseno.GetId(idEmpresa, ref   mensaje).ToString();
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
    }
}
