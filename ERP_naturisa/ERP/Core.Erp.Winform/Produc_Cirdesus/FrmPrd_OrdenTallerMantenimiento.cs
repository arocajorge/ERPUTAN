using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.Compras_Edehsa;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using System.Xml;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
//version 240620113 13:31
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_OrdenTallerMantenimiento : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public FrmPrd_OrdenTallerMantenimiento()
        {
            try
            {
                InitializeComponent();
                inicia_controles();
                this.event_FrmPrd_OrdenTallerMantenimiento_FormClosing += new delegate_FrmPrd_OrdenTallerMantenimiento_FormClosing(FrmPrd_OrdenTallerMantenimiento_event_FrmPrd_OrdenTallerMantenimiento_FormClosing);


                ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                //ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;

                //   event_FrmPrd_ObraMantemiento_FormClosing += FrmIn_Motivo_Inven_Mant_event_FrmIn_Motivo_Inven_Mant_FormClosing;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void FrmPrd_OrdenTallerMantenimiento_event_FrmPrd_OrdenTallerMantenimiento_FormClosing(object sender, FormClosingEventArgs e) { }
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        private Cl_Enumeradores.eTipo_action _Accion;
        //delegado para actualizar consulta de ordenes de taller
        public delegate void delegate_FrmPrd_OrdenTallerMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_OrdenTallerMantenimiento_FormClosing event_FrmPrd_OrdenTallerMantenimiento_FormClosing;
        private void FrmPrd_OrdenTallerMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmPrd_OrdenTallerMantenimiento_FormClosing(sender, e);
        }


        //instancias de centro de costo


        //instancias de obra
        UCPrd_Obra UCOBra = new UCPrd_Obra();
        prd_Obra_Bus BusObra = new prd_Obra_Bus();
        prd_Obra_Info InfoObra = new prd_Obra_Info();
        UCIn_Sucursal_Bodega UCSuc = new UCIn_Sucursal_Bodega();


        //instancicas de bodega
        tb_Bodega_Bus busBodega = new tb_Bodega_Bus();
        List<tb_Bodega_Info> lmBodega = new List<tb_Bodega_Info>();
        tb_Bodega_Info infoBodega = new tb_Bodega_Info();

        //instancias de orden de taller
        prd_OrdenTaller_Bus busOrdenTaller = new prd_OrdenTaller_Bus();
        prd_OrdenTaller_Info InfoOrdenTaller = new prd_OrdenTaller_Info();

        //instancia de parametros generales
       // cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //instancias de categoria de producto (tipo de pieza)
        List<in_categorias_Info> lstCategoria = new List<in_categorias_Info>();
        in_categorias_bus BusCategoria = new in_categorias_bus();

        //instancias de producto de la bodega productos terminados
        List<in_Producto_Info> lstProductosTerminados = new List<in_Producto_Info>();
        in_producto_Bus BusProducto = new in_producto_Bus();

        com_ListadoDiseno_Bus BusListadoDiseno = new com_ListadoDiseno_Bus();
      


        #endregion
        public void iniciar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.actualizar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void FrmPrd_RegOrdenTaller_Load(object sender, EventArgs e)
        {
            try
            {
                UCOBra.Event_UCObra_Validating += new UCPrd_Obra.delegadoUCObra_Validating(UCOBra_Event_UCObra_Validating);
                ucFa_Cliente_Facturacion1.Size = new System.Drawing.Size(380, 20);
                //carga_CmbListadoDiseno();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


            fa_Cliente_Bus busCateg = new fa_Cliente_Bus();
            List<fa_Cliente_Info> lista = new List<fa_Cliente_Info>();
            lista = busCateg.Get_List_Clientes(param.IdEmpresa);



        }


        void setearprodterm(int IdEmpresa, int IdSucursal, string CodObra)
        {
            try
            {
                CmbProductos.Properties.DataSource = null;
                CmbProductos.Text = "";
                cargaBodega(UCOBra.get_item());
                //carga_UltraCmbEProdTerm();
                carga_CmbListadoDiseno(IdEmpresa, IdSucursal, CodObra);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCOBra_Event_UCObra_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                setearprodterm(param.IdEmpresa, ucGe_Sucursal.get_SucursalInfo().IdSucursal, UCOBra.get_item());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void inicia_controles()
        {
            try
            {
                UCOBra.cargaCmb_Obra();
                PanelObra.Controls.Add(UCOBra);
                UCOBra.Dock = DockStyle.Fill;
                UCOBra.Event_UCObra_SelectionChanged += new UCPrd_Obra.delegadoUCObra_SelectionChanged(UCOBra_Event_UCObra_SelectionChanged);
                UCOBra.Event_UCObra_SelectionChanged +=UCOBra_Event_UCObra_SelectionChanged;
                //cambio 14052013 1337
                //  cargaBodega(UCOBra.get_item());
                //
                carga_UltraCmbEProdTerm();

                UCSuc.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                UCSuc.cargar_sucursal(param.IdEmpresa);
               
                UCSuc.Dock = DockStyle.Fill;

                //size y location de controles
                //  UCOBra.label.Location = new Point(10, 0);
                UCOBra.UC_Obra.Location = new Point(94, 1);
                UCOBra.UC_Obra.Size = new System.Drawing.Size(308, 20);
                UCSuc.label1.Location = new Point(10, 3);
                UCSuc.cmb_sucursal.Location = new Point(94, 1);
                UCSuc.cmb_sucursal.Size = new Size(308, 20);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCOBra_Event_UCObra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                setearprodterm(param.IdEmpresa, ucGe_Sucursal.get_SucursalInfo().IdSucursal, UCOBra.get_item());
                ucFa_Cliente_Facturacion1.cmb_cliente.EditValue = UCOBra.get_item_info().IdCliente;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        public void set_OT(prd_OrdenTaller_Info OTinfo)
        {
            try
            {
                InfoOrdenTaller = OTinfo;
                txt_IDOT.Text = OTinfo.IdOrdenTaller.ToString();
                txt_CodigoOT.Text = OTinfo.Codigo;
                ucGe_Sucursal.set_SucursalInfo(Convert.ToInt32(OTinfo.IdSucursal));
                UCOBra.set_item(OTinfo.CodObra);

                carga_CmbListadoDiseno(param.IdEmpresa, OTinfo.IdSucursal, OTinfo.CodObra);
                cmbListadoDiseno.EditValue = Convert.ToInt32(OTinfo.IdListadoDiseno);

                TxtDescripcion.Text = OTinfo.ob_descripcion;
                
                CmbProductos.EditValue = OTinfo.IdProducto;
                ucFa_Cliente_Facturacion1.cmb_cliente.EditValue = OTinfo.IdCliente;
                if (OTinfo.Estado == "A")
                {
                    lblAnulado.Visible = false;
                    
                }
                else
                {
                    lblAnulado.Visible = true;
                    
                }
       
                txt_Cantidad.EditValue = OTinfo.CantidadPieza;
                txt_PesoTotal.EditValue = OTinfo.TotalPeso;
                txt_PesoUnit.EditValue = OTinfo.PesoUnitario;
                txt_Observacion.Text = OTinfo.Observacion;
                txt_CodigoOT.Text = Convert.ToString(OTinfo.Codigo) ?? "0";
                if (txt_IDOT.Text == "")
                {
                    txt_CodigoOT.Text = txt_IDOT.Text;

                }

                cmbListadoDiseno.EditValue = OTinfo.IdListadoDiseno;
                setearprodterm(param.IdEmpresa, OTinfo.IdSucursal,OTinfo.CodObra);
                
                carga_UltraCmbEProdTerm();
                CmbProductos.EditValue = OTinfo.IdProducto;
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public void get_OT()
        {
            try
            {
                InfoOrdenTaller.IdEmpresa = param.IdEmpresa;
                InfoOrdenTaller.IdSucursal = ucGe_Sucursal.get_SucursalInfo().IdSucursal;
                InfoOrdenTaller.IdCliente = Convert.ToDecimal(ucFa_Cliente_Facturacion1.cmb_cliente.EditValue);
                InfoOrdenTaller.CodObra = UCOBra.get_item();
                InfoOrdenTaller.FechaReg = dateTimePicker1.Value;
                //InfoOrdenTaller.FechaReg = DateTime.Now;

                InfoOrdenTaller.IdListadoDiseno = Convert.ToInt32(cmbListadoDiseno.EditValue);
                InfoOrdenTaller.IdOrdenTaller = Convert.ToInt32(txt_IDOT.Text);
                InfoOrdenTaller.IdProducto = Convert.ToDecimal(this.CmbProductos.EditValue);
                InfoOrdenTaller.CantidadPieza = Convert.ToDecimal(txt_Cantidad.EditValue);
                InfoOrdenTaller.TotalPeso = Convert.ToDecimal(txt_PesoTotal.EditValue);
                InfoOrdenTaller.PesoUnitario = Convert.ToDecimal(txt_PesoUnit.EditValue);
                InfoOrdenTaller.Estado = (this.lblAnulado.Visible == true) ? "I" : "A";
                InfoOrdenTaller.Observacion = txt_Observacion.Text.Trim().ToString();
                InfoOrdenTaller.ob_descripcion = TxtDescripcion.Text.Trim().ToString();
                InfoOrdenTaller.Codigo = txt_CodigoOT.Text.Trim();
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void carga_UltraCmbEProdTerm()
        {
            try
            {

                this.CmbProductos.Properties.DataSource = BusProducto.Get_list_ProductosTerminados_x_ListadoDiseno(param.IdEmpresa,Convert.ToInt32(cmbListadoDiseno.EditValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }
        private void carga_CmbListadoDiseno(int IdEmpresa, int IdSucursal, string Cod_Obra)
        {
            try
            {
                this.cmbListadoDiseno.Properties.DataSource = BusListadoDiseno.Get_List_ListadoDisenoCMB(IdEmpresa,IdSucursal, Cod_Obra);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void cargaBodega(string CodObra)
        {
            try
            {
                lmBodega = busBodega.Get_List_Bodegas_x_CentroCosto(param.IdEmpresa, CodObra);

                var li = lmBodega.Where<tb_Bodega_Info>(C => C.bo_manejaFacturacion == "S");

                if (li.ToList().Count == 1)
                    foreach (var item in li)
                        infoBodega = item;
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
                        //if (Validaciones() == true)
                        //{
                        //    return;
                        //}
                        string msg="";

                        txt_IDOT.Text =Convert.ToString(busOrdenTaller.getNumDoc(param.IdEmpresa, param.IdSucursal));
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
                       // busOrdenTaller.ObtenerIDOrdenTaller();
                        this.lblAnulado.Visible = false;
                        //  sep1.Visible = false;

                        
                        txt_Cantidad.Text = "";
                        txt_PesoTotal.Text = "";
                        txt_PesoUnit.Text = "";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        txt_CodigoOT.Enabled = false;
                        // UCOBra.UC_Obra.Enabled = false;
                        UCSuc.cmb_sucursal.Enabled = false;
                        //this.btn_Anular.Visible = false;
                        //sep1.Visible = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        //this.btn_Anular.Visible = false;
                        // sep1.Visible = false;
                        txt_CodigoOT.Enabled = false;
                        UCOBra.UC_Obra.Enabled = false;
                        UCSuc.cmb_sucursal.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        //this.btn_Anular.Visible = true;
                        // sep1.Visible = true;
                        txt_CodigoOT.Enabled = false;
                        UCOBra.UC_Obra.Enabled = false;
                        UCSuc.cmb_sucursal.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        public Boolean Validaciones()
        {
            bool B_ValidaTxt_Vacios = false;
            try
            {
                

                if (txt_IDOT.Text=="")
                {
                    errorProviderValidaTxt.SetError(txt_IDOT, "Falta Id Registro");
                    B_ValidaTxt_Vacios = true;
                }

                if (txt_CodigoOT.Text == "")
                {
                    errorProviderValidaTxt.SetError(txt_CodigoOT, "Ingrese Orden de Taller");
                    B_ValidaTxt_Vacios = true;
                }

                if (ucGe_Sucursal.get_SucursalInfo()==null)
                {
                    errorProviderValidaTxt.SetError(ucGe_Sucursal, "Escoja una Sucrusal");
                    B_ValidaTxt_Vacios = true;
                }


                
                //if (TxtDescripcion.Text == "")
                //{
                //    errorProviderValidaTxt.SetError(TxtDescripcion, "Ingrese descripcion");
                //    B_ValidaTxt_Vacios = true;
                //}

                if (CmbProductos.Text == "")
                {
                    errorProviderValidaTxt.SetError(CmbProductos, "Escoga Producto Terminado");
                    B_ValidaTxt_Vacios = true;
                }

                if (txt_Cantidad.Text == "0")
                {
                    errorProviderValidaTxt.SetError(txt_Cantidad, "Ingrese Cantidad");
                    B_ValidaTxt_Vacios = true;
                }

                if (txt_PesoUnit.Text == "")
                {
                    errorProviderValidaTxt.SetError(txt_PesoUnit, "Ingrese Peso por Cantidad");
                    B_ValidaTxt_Vacios = true;
                }
                if (txt_PesoTotal.Text == "")
                {
                    errorProviderValidaTxt.SetError(txt_PesoTotal, "Falta Total Peso");
                    B_ValidaTxt_Vacios = true;
                }

                return B_ValidaTxt_Vacios;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return B_ValidaTxt_Vacios;
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
                InfoOrdenTaller.Estado = "I";
                busOrdenTaller.Anular(param.IdEmpresa, InfoOrdenTaller, ref msg);
                MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                set_Accion(Cl_Enumeradores.eTipo_action.consultar);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void Grabar()
        {
            try
            {
                
                get_OT();
                string msg = "";
                decimal idgeneradaOC = 0;
                string numDoc = "";
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (Validaciones())
                        {
                            return;
                        }
                        if (busOrdenTaller.GrabarDB(param.IdEmpresa, InfoOrdenTaller, ref msg, ref idgeneradaOC, ref numDoc))
                        {

                            this.txt_CodigoOT.Text = numDoc;
                            this.txt_IDOT.Text = idgeneradaOC.ToString();
                            LimpiarDatos();
                            txt_IDOT.Text = Convert.ToString(busOrdenTaller.getNumDoc(param.IdEmpresa, param.IdSucursal));
                        }
                        //set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // btnGrabar.Enabled = false; btnGrabarySalir.Enabled = false;
                        //txt_CodigoOT.Enabled = true;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Validaciones())
                        {
                            return;
                        }
                        busOrdenTaller.ModificarDB(param.IdEmpresa, InfoOrdenTaller, ref msg);
                        MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        void LimpiarDatos()
        {
            try
            {
                txt_IDOT.Text = "";
                txt_CodigoOT.Text = "";
                //UCOBra.set_item("");
                TxtDescripcion.Text = "";
                txt_Observacion.Text = "";
                txt_Cantidad.Text = "";
                txt_PesoUnit.Text = "";
                txt_PesoTotal.Text = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                //if (Grabar() == true)
                //{
                //    this.Close();
                //}
                Grabar();

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
                
                    Grabar();


               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void ultraComboE_ProdTerm_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (CmbProductos.EditValue == null)
                    CmbProductos.Text = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        //private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        Funciones f = new Funciones();  
        //        e.Handled = f.Validanumero_decimal(e.KeyChar);
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        private void txt_PesoUnit_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txt_PesoUnit.Text == string.Empty)
                    txt_PesoUnit.Text = "0";
                if (txt_Cantidad.Text == string.Empty)
                    txt_Cantidad.Text = "0";
                txt_PesoTotal.EditValue = Convert.ToString(Convert.ToDecimal(txt_PesoUnit.EditValue) * Convert.ToDecimal(txt_Cantidad.EditValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Cantidad.Text == string.Empty)
                    txt_Cantidad.Text = "0";
                if (txt_PesoUnit.Text == string.Empty)
                    txt_PesoUnit.Text = "0";
                txt_PesoTotal.Text = Convert.ToString(Convert.ToDecimal(txt_PesoUnit.EditValue) * Convert.ToDecimal(txt_Cantidad.EditValue));


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void ucGe_Menu_Superior_Mant1_Load(object sender, EventArgs e)
        {

        }

        private void ucFa_ClienteCmb1_Load(object sender, EventArgs e)
        {

        }

        private void panel_cliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucFa_ClienteCmb1_Load_1(object sender, EventArgs e)
        {

        }

        private void ucFa_Cliente_Facturacion1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucFa_Cliente_Facturacion1_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PanelObra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbListadoDiseno_EditValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Aqui va el asunto");
            carga_UltraCmbEProdTerm();

        }

        private void CmbProductos_EditValueChanged(object sender, EventArgs e)
        {
            //txt_Cantidad = Lista
            //cmbListadoDiseno.sele
         
            txt_PesoTotal.EditValue = Convert.ToString(Convert.ToDecimal(txt_PesoUnit.EditValue) * Convert.ToDecimal(txt_Cantidad.EditValue));
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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







    }
}
