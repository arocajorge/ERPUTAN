using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using System.Reflection;
using System.Runtime.Remoting;

namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Menu_Mantenimiento_x_usuario : UserControl
    {
        private System.Reflection.Assembly Ensamblado;

        #region "Declararion de delegados y eventos"
        public delegate void delegate__btn_imprimir_lote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate__btn_imprimir_lote_ItemClick event_btn_imprimir_lote_ItemClick;

        public delegate void delegate_btnDescargar_Marca_Base_exter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnDescargar_Marca_Base_exter_ItemClick event_btnDescargar_Marca_Base_exter_ItemClick;

        public delegate void delegate_btnNuevoChq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnNuevoChq_ItemClick event_btnNuevoChq_ItemClick;

        public delegate void delegate_btnLoteChq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnLoteChq_ItemClick event_btnLoteChq_ItemClick;

        public delegate void delegate_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnNuevo_ItemClick event_btnNuevo_ItemClick;

        public delegate void delegate_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnModificar_ItemClick event_btnModificar_ItemClick;

        public delegate void delegate_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnconsultar_ItemClick event_btnconsultar_ItemClick;

        public delegate void delegate_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnAnular_ItemClick event_btnAnular_ItemClick;

        public delegate void delegate_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImprimir_ItemClick event_btnImprimir_ItemClick;

        public delegate void delegate_btnfiltro_fecha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnfiltro_fecha_ItemClick event_btnfiltro_fecha_ItemClick;

        public delegate void delegate_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnSalir_ItemClick event_btnSalir_ItemClick;

        public delegate void delegate_btnDuplicar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnDuplicar_ItemClick event_btnDuplicar_ItemClick;

        public delegate void delegate_btnCancelarCuotas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnCancelarCuotas_ItemClick event_btnCancelarCuotas_ItemClick;

        public delegate void delegate_btnDiseñoCheque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnDiseñoCheque_ItemClick event_btnDiseñoCheque_ItemClick;

        public delegate void delegate_btn_Habilitar_Reg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_Habilitar_Reg_ItemClick event_btn_Habilitar_Reg_ItemClick;

        public delegate void delegate_btn_Importar_XML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btn_Importar_XML_ItemClick event_btn_Importar_XML_ItemClick;
     
        public delegate void delegate_btnGenerarXml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnGenerarXml_ItemClick event_btnGenerarXml_ItemClick;

        public delegate void delegate_btnImpExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImpExcel_ItemClick event_btnImpExcel_ItemClick;

        public delegate void delegate_btnCargaMarcaciónExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnCargaMarcaciónExcel_ItemClick event_btnCargaMarcaciónExcel_ItemClick;

        public delegate void delegate_btnGenerarPeriodos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnGenerarPeriodos_ItemClick event_btnGenerarPeriodos_ItemClick;

        public delegate void delegate_btnBuscar_Click(object sender, EventArgs e);
        public event delegate_btnBuscar_Click event_btnBuscar_Click;

        public delegate void delegate_BtnDisChqCbte_Click(object sender, EventArgs e);
        public event delegate_BtnDisChqCbte_Click event_BtnDisChqCbte_Click;

        public delegate void delegate_btnDisenioReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnDisenioReport_ItemClick event_btnDisenioReport_ItemClick;

        #endregion

        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus SucuBus = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> listSucu_info = new List<tb_Sucursal_Info>();
        tb_Sucursal_Info _Sucu_item_info = new tb_Sucursal_Info();
        tb_Bodega_Bus BodeBus = new tb_Bodega_Bus();
        tb_Bodega_Info _Bodega_item_info = new tb_Bodega_Info();
        List<tb_Bodega_Info> listBodega_info = new List<tb_Bodega_Info>();
        Boolean CargarBodegas = false;
        Boolean CargarSucursales = true;
        public Form FormMain { get; set; }
        public Form FormConsulta { get; set; }
        
        public string Perfil_x_usuario { get; set; }


        string NombreFormulario = "";
        string RutaPantalla = "";
        string Asamble = "";

        Form FormContenedor = new Form();
        #endregion

        

        public UCGe_Menu_Mantenimiento_x_usuario()
        {
            try
            {
                InitializeComponent();
                event_btnNuevo_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                event_btnModificar_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                event_btnconsultar_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                event_btnAnular_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                event_btnImprimir_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                event_btnfiltro_fecha_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnfiltro_fecha_ItemClick;
                event_btnSalir_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                event_btnBuscar_Click += UCGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                event_BtnDisChqCbte_Click += UCGe_Menu_Mantenimiento_x_usuario_event_BtnDisChqCbte_Click;
                event_btnDuplicar_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnDuplicar_ItemClick;
                event_btnCancelarCuotas_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnCancelarCuotas_ItemClick;
                event_btnDiseñoCheque_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnDiseñoCheque_ItemClick;
                event_btnGenerarXml_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnGenerarXml_ItemClick;
                event_btnImpExcel_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnImpExcel_ItemClick;
                event_btnCargaMarcaciónExcel_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnCargaMarcaciónExcel_ItemClick;
                event_btnGenerarPeriodos_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnGenerarPeriodos_ItemClick;
                event_btnNuevoChq_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnNuevoChq_ItemClick;
                event_btnLoteChq_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnLoteChq_ItemClick;

                event_btn_Habilitar_Reg_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btn_Habilitar_Reg_ItemClick;

                event_btn_Importar_XML_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btn_Importar_XML_ItemClick;
                event_btnDisenioReport_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnDisenioReport_ItemClick;

                event_btnDescargar_Marca_Base_exter_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btnDescargar_Marca_Base_exter_ItemClick;
                event_btn_imprimir_lote_ItemClick += UCGe_Menu_Mantenimiento_x_usuario_event_btn_imprimir_lote_ItemClick;
                this.Dock = DockStyle.Top;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }


        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btn_imprimir_lote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

       

                   
        #region "void de eventos delegados"

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnDescargar_Marca_Base_exter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnDisenioReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btn_Importar_XML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btn_Habilitar_Reg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnNuevoChq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnLoteChq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnGenerarPeriodos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_BtnDisChqCbte_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnCargaMarcaciónExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }


        void UCGe_Menu_Mantenimiento_x_usuario_event_btnGenerarXml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)

        {
          
        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnImpExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        void UCGe_Menu_Mantenimiento_x_usuario_event_btnDiseñoCheque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnCancelarCuotas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        void UCGe_Menu_Mantenimiento_x_usuario_event_btnDuplicar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnfiltro_fecha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        #endregion

        #region "propiedades"

        public DateTime fecha_desde { get; set; }
        public DateTime fecha_hasta { get; set; }

        public int getIdSucursal 
        {    get
            {
                return _Sucu_item_info.IdSucursal;
                }
        }

        public int getIdBodega
        {
            get
            {
                return _Bodega_item_info.IdBodega;
            }
        }

        public tb_Sucursal_Info  getSucursal_Info
        {
            get
            {
                return _Sucu_item_info;
            }
        }

        public tb_Bodega_Info getBodega_Info
        {
            get
            {
                return _Bodega_item_info;
            }
        }

        //public vwSe_Perfil_x_Usuario_Info Perfil_x_usuario
        //{
        //    get { return _Perfil_x_usuario; }
        //    set { _Perfil_x_usuario = value; } 
        //}
      
        public void carga_Sucursal_Todas()
        {
          cmbsucursal.EditValue = 0;   
         }

        #region "fx perfiles"
        

        private void Perfil_Lectura()
        {
            try
            {
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnAnular.Enabled = false;
                btnconsultar.Enabled = true;
                btnImprimir.Enabled = true;


            }
            catch (Exception ex)
            {
                
                
            }
        }


        private void Perfil_Escritura()
        {
            try
            {
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnconsultar.Enabled = true;
                btnAnular.Enabled = false;
                btnImprimir.Enabled = true;
           }
            catch (Exception ex)
            {


            }
        }

        private void Perfil_Anulacion()
        {
            try
            {

                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnconsultar.Enabled = true;
                btnAnular.Enabled = true;
                btnImprimir.Enabled = true;
            }
            catch (Exception ex)
            {


            }
        }

        private void Perfil_Habilitado_todo()
        {
            try
            {

                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnconsultar.Enabled = true;
                btnAnular.Enabled = true;
                btnImprimir.Enabled = true;

            }
            catch (Exception ex)
            {


            }
        }

        /// <summary>
        /// Estos botones se deshabilitan por default el usuario debe manualmente habilitarlos
        /// </summary>
        private void Deshabilitar_Otros_botones()
        {
            try
            {

                btnDuplicar.Enabled = true;
                btnCancelarCuotas.Enabled = true;
                btnDiseñoCheque.Enabled = true;
                btnGenerarXml.Enabled = true;
                btnImpExcel.Enabled = true;
                btnCargaMarcaciónExcel.Enabled = true;
                btnGenerarPeriodos.Enabled = true;
                btnNuevoChq.Enabled = true;
                btnLoteChq.Enabled = true;
                BtnDisChqCbte.Enabled = true;
            }
            catch (Exception ex)
            {


            }
        }

        #endregion

        #endregion

        private void Habilitar_botones_x_usuario_x_menu()
        {
            try
            {

                //if (_Perfil_x_usuario != null)
                //{
                // //   _Perfil_x_usuario = MenuxUserBus.ObtenerMenuxUser_item(param.IdEmpresa, param.IdUsuario, _Perfil_x_usuario.IdMenu);

                //    if (_Perfil_x_usuario.Lectura == true && _Perfil_x_usuario.Escritura == true && _Perfil_x_usuario.Eliminacion == true)
                //    {
                //        Perfil_Habilitado_todo();
                //    }
                //    else
                //    {
                //        if (_Perfil_x_usuario.Lectura == true)
                //        {
                //            Perfil_Lectura();
                //        }

                //        if (_Perfil_x_usuario.Escritura == true)
                //        {
                //            Perfil_Escritura();
                //        }


                //        if (_Perfil_x_usuario.Eliminacion == true)
                //        {
                //            Perfil_Anulacion();
                //        }
                //    }
                   
                //}
                //else
                //{
                //    _Perfil_x_usuario = null;// no hay perfil q asignar habilito todo 
                //    Perfil_Habilitado_todo();
                //}

                //Deshabilitar_Otros_botones();
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
        }

        #region 'Propiedades publica de funcionamiento del control visibilidad y enable'


        public Boolean Visible_ribbon_control { get { return this.ribbonControl_mantenimiento.Visible; } set { this.ribbonControl_mantenimiento.Visible = value; } }


        public DevExpress.XtraBars.BarItemVisibility Visible_Descargar_Marca_Base_exter
        {
            get { return this.btnDescargar_Marca_Base_exter.Visibility; }
            set { this.btnDescargar_Marca_Base_exter.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_btn_imprimir_lote
        {
            get { return this.btn_imprimir_lote.Visibility; }
            set { this.btn_imprimir_lote.Visibility = value; }
        }


        public Boolean Visible_Pie_fechas_Boton_buscar
        {
            get { return this.panel_pie_fechas.Visible; }
            set { this.panel_pie_fechas.Visible = value; }
        }

        public Boolean Visible_Grupo_Diseño_Reporte
        {
            get { return this.ribbonPageGroup_Disenio.Visible; }
            set { this.ribbonPageGroup_Disenio.Visible = value; }
        }

        public Boolean Visible_Grupo_filtro
        {
            get { return this.ribbonPageGroup_filtros.Visible; }
            set { this.ribbonPageGroup_filtros.Visible = value; }
        }

        public Boolean Visible_Grupo_Transacciones
        {
            get { return this.ribbonPageGroup_Transacciones.Visible; }
            set { this.ribbonPageGroup_Transacciones.Visible = value; }
        }

        public Boolean Visible_Grupo_Cancelaciones
        {
            get { return this.ribbonPageGroup_Cancelaciones.Visible; }
            set { this.ribbonPageGroup_Cancelaciones.Visible = value; }
        }

        public Boolean Visible_Grupo_Impresion
        {
            get { return this.ribbonPageGroup_Impresion.Visible; }
            set { this.ribbonPageGroup_Impresion.Visible = value; }
        }

        public Boolean Visible_Grupo_Otras_Trans
        {
            get { return this.ribbonPageGroup_otras_Trans.Visible; }
            set { this.ribbonPageGroup_otras_Trans.Visible = value; }
        }

        public Boolean Visible_bodega
        {
            get { 
                return this.cmbsucursal.Visible; }
            set
            {
                lblSucursal.Visible = value;
                this.cmbsucursal.Visible = value; 
            }
        }

        public Boolean Visible_sucursal
        {
            get
            {
                return this.cmbbodega.Visible;
            }
            set
            {
                lblbodega.Visible = value;
                this.cmbbodega.Visible = value;
            }
        }

        public Boolean CargarTodasSucursales { 
            get { return this.CargarSucursales; } 
            set { this.CargarSucursales = value; } 
        }

        public Boolean CargarTodasBodegas
        {
            get {
                return CargarBodegas;
            }
            set {
                CargarBodegas = value;
            }
        }


        public DevExpress.XtraBars.BarItemVisibility Visible_boton_DiseNoReport
        {
            get { return this.btnDisenioReport.Visibility; }
            set { this.btnDisenioReport.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_GenerarPeriodos
        {
            get { return this.btnGenerarPeriodos.Visibility; }
            set { this.btnGenerarPeriodos.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_NuevoCheque
        {
            get { return this.btnNuevoChq.Visibility; }
            set { this.btnNuevoChq.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_LoteCheque
        {
            get { return this.btnLoteChq.Visibility; }
            set { this.btnLoteChq.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_CargaMarcaciónExcel
        {
            get { return this.btnCargaMarcaciónExcel.Visibility; }
            set { this.btnCargaMarcaciónExcel.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_GenerarXml
        {
            get { return this.btnGenerarXml.Visibility; }
            set { this.btnGenerarXml.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_btnImpExcel
        {
            get { return this.btnImpExcel.Visibility; }
            set { this.btnImpExcel.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_DiseñoCheque
        {
            get { return this.btnDiseñoCheque.Visibility; }
            set { this.btnDiseñoCheque.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_Habilitar_Reg
        {
            get { return this.btn_Habilitar_Reg.Visibility; }
            set { this.btn_Habilitar_Reg.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility Visible_boton_Importar_XML
        {
            get { return this.btn_Importar_XML.Visibility; }
            set { this.btn_Importar_XML.Visibility = value; }
        }


        public DevExpress.XtraBars.BarItemVisibility Visible_boton_DiseñoChequeComprobante
        {
            get { return this.BtnDisChqCbte.Visibility; }
            set { this.BtnDisChqCbte.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_CancelarCuotas
        {
            get { return this.btnCancelarCuotas.Visibility; }
            set { this.btnCancelarCuotas.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_Duplicar
        {
            get { return this.btnDuplicar.Visibility; }
            set { this.btnDuplicar.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_nuevo
        {
            get { return this.btnNuevo.Visibility ; }
            set { this.btnNuevo.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_modificar
        {
            get { return this.btnModificar.Visibility; }
            set { this.btnModificar.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_consular
        {
            get { return this.btnconsultar.Visibility; }
            set { this.btnconsultar.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_anular
        {
            get { return this.btnAnular.Visibility; }
            set { this.btnAnular.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_imprimir
        {
            get { return this.btnImprimir.Visibility; }
            set { this.btnImprimir.Visibility = value; }
        }





        public Boolean Enable_Descargar_Marca_Base_exter
        {
            get { return this.btnDescargar_Marca_Base_exter.Enabled; }
            set { this.btnDescargar_Marca_Base_exter.Enabled = value; }
        }

        public Boolean Enable_boton_nuevo
        {
            get { return this.btnNuevo.Enabled; }
            set { this.btnNuevo.Enabled = value; }
        }

        public Boolean Enable_boton_GenerarPeriodos
        {
            get { return this.btnGenerarPeriodos.Enabled; }
            set { this.btnGenerarPeriodos.Enabled = value; }
        }

        public Boolean Enable_boton_NuevoCheque
        {
            get { return this.btnNuevoChq.Enabled; }
            set { this.btnNuevoChq.Enabled = value; }
        }

        public Boolean Enable_boton_LoteCheque
        {
            get { return this.btnLoteChq.Enabled; }
            set { this.btnLoteChq.Enabled = value; }
        }

        public Boolean Enable_boton_CargaMarcaciónExcel
        {
            get { return this.btnCargaMarcaciónExcel.Enabled; }
            set { this.btnCargaMarcaciónExcel.Enabled = value; }
        }

        public Boolean Enable_boton_GenerarXml
        {
            get { return this.btnGenerarXml.Enabled; }
            set { this.btnGenerarXml.Enabled = value; }
        }
       
        public Boolean Enable_btnImpExcel
        {
            get { return this.btnImpExcel.Enabled; }
            set { this.btnImpExcel.Enabled = value; }
        }

        public Boolean Enable_boton_DiseñoCheque
        {
            get { return this.btnDiseñoCheque.Enabled; }
            set { this.btnDiseñoCheque.Enabled = value; }
        }


        public Boolean Enable_boton_Habilitar_Reg
        {
            get { return this.btn_Habilitar_Reg.Enabled; }
            set { this.btn_Habilitar_Reg.Enabled = value; }
        }

        public Boolean Enable_boton_Importar_XML
        {
            get { return this.btn_Importar_XML.Enabled; }
            set { this.btn_Importar_XML.Enabled = value; }
        }
        
        public Boolean Enable_boton_DiseñoChequeComprobante
        {
            get { return this.BtnDisChqCbte.Enabled; }
            set { this.BtnDisChqCbte.Enabled = value; }
        }

        public Boolean Enable_boton_CancelarCuotas
        {
            get { return this.btnCancelarCuotas.Enabled; }
            set { this.btnCancelarCuotas.Enabled = value; }
        }

        public Boolean Enable_boton_Duplicar
        {
            get { return this.btnDuplicar.Enabled; }
            set { this.btnDuplicar.Enabled = value; }
        }

        public Boolean Enable_boton_modificar
        {
            get { return this.btnModificar.Enabled; }
            set { this.btnModificar.Enabled = value; }
        }

        public Boolean Enable_boton_consultar
        {
            get { return this.btnconsultar.Enabled; }
            set { this.btnconsultar.Enabled = value; }
        }

        public Boolean Enable_boton_anular
        {
            get { return this.btnAnular.Enabled; }
            set { this.btnAnular.Enabled = value; }
        }

        public Boolean Enable_boton_imprimir
        {
            get { return this.btnImprimir.Enabled; }
            set { this.btnImprimir.Enabled = value; }
        }

        public Boolean Enable_boton_periodo
        {
            get { return this.btnfiltro_fecha.Enabled; }
            set { this.btnfiltro_fecha.Enabled = value; }
        }

        public Boolean Enable_boton_salir
        {
            get { return this.btnSalir.Enabled; }
            set { this.btnSalir.Enabled = value; }
        }

        public Boolean Visible_fechas
        {
            get
            {
                return this.dtpFechaDesde.Visible ;
            }
            set
            {
                lblFdesde.Visible = value;
                dtpFechaDesde.Visible = value;
                lblFHasta.Visible = value;
                dtpFechaHasta.Visible = value;
                lblCriterioBusq.Visible = value;
                cmb_CriterioBusqueda.Visible = value;
            }
        }

        #endregion

        private void UCGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {
            try
            {
                Habilitar_botones_x_usuario_x_menu();
                Cargar_sucursal();
                cmb_CriterioBusqueda.SelectedIndex = 0;
                dtpFechaDesde.Value = DateTime.Now.AddMonths(-1);
                dtpFechaHasta.Value = DateTime.Now.AddMonths(1);

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            

        }

        private void Cargar_sucursal()
        {
            try
            {
                listSucu_info = SucuBus.Get_List_Sucursal(param.IdEmpresa);
                if (CargarSucursales)
                {
                    tb_Sucursal_Info todos = new tb_Sucursal_Info();
                    todos.IdSucursal = 0;
                    todos.Su_Descripcion = "TODAS";
                    todos.Su_Descripcion2 = "[0]-" + todos.Su_Descripcion;
                    listSucu_info.Add(todos);    
                }
                listSucu_info = listSucu_info.OrderBy(q => q.IdSucursal).ToList();
                cmbsucursal.Properties.DataSource = listSucu_info;
                cmbsucursal.EditValue = ((List<tb_Sucursal_Info>)(cmbsucursal.Properties.DataSource)).FirstOrDefault().IdSucursal;
                

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
        }

        private void Cargar_bodega(int idSucursal)
        {
            try
            {

                listBodega_info = BodeBus.Get_List_Bodega(param.IdEmpresa, idSucursal);
                
                if (listBodega_info.Count > 0)
                {
                    tb_Bodega_Info todos = new tb_Bodega_Info();
                    todos.IdBodega = 0;
                    todos.bo_Descripcion = "TODAS";
                    todos.bo_Descripcion2 = "[0]-" + todos.bo_Descripcion;
                    listBodega_info.Add(todos);
                    listBodega_info = listBodega_info.OrderBy(q => q.IdBodega).ToList();
                    cmbbodega.Properties.DataSource = listBodega_info;
                    cmbbodega.EditValue = ((List<tb_Bodega_Info>)(cmbbodega.Properties.DataSource)).FirstOrDefault().IdBodega;
                }
                else
                    if (idSucursal==0 && listBodega_info.Count()==0)
                        Cargar_bodegaTodas();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Cargar_bodegaTodas()
        {
            try
            {
               
                    tb_Bodega_Info todos = new tb_Bodega_Info();
                    todos.IdBodega = 0;
                    todos.bo_Descripcion = "TODAS";
                    todos.bo_Descripcion2 = "[0]-"+todos.bo_Descripcion;
                    listBodega_info.Add(todos);
                    listBodega_info = listBodega_info.OrderBy(q => q.IdBodega).ToList();
                    cmbbodega.Properties.DataSource = listBodega_info;
                    cmbbodega.EditValue = ((List<tb_Bodega_Info>)(cmbbodega.Properties.DataSource)).FirstOrDefault().IdBodega;   
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //this.ParentForm.Close();

                event_btnSalir_ItemClick(sender, e);
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void cmbsucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                _Sucu_item_info = ((List<tb_Sucursal_Info>)(cmbsucursal.Properties.DataSource)).FirstOrDefault(v=>v.IdSucursal == Convert.ToInt32(cmbsucursal.EditValue));
                Cargar_bodega(_Sucu_item_info.IdSucursal);
                if (cmbbodega.EditValue != null)
                {
                    _Bodega_item_info = ((List<tb_Bodega_Info>)(cmbbodega.Properties.DataSource)).FirstOrDefault(v => v.IdBodega == Convert.ToInt32(cmbbodega.EditValue));
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnNuevo_ItemClick(sender, e);
            
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnModificar_ItemClick(sender, e);
        }

        private void btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnconsultar_ItemClick(sender, e);
        }

        private void btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnAnular_ItemClick(sender, e);
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnImprimir_ItemClick(sender, e);
        }

        private void btnfiltro_fecha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                FrmGe_Rango_Fechas_x_Periodo_Busqueda form1 = new FrmGe_Rango_Fechas_x_Periodo_Busqueda();

                form1.ShowDialog();

                dtpFechaDesde.Value = form1.Fecha_desde;
                dtpFechaHasta.Value = form1.Fecha_hast ;

                event_btnfiltro_fecha_ItemClick(sender, e);
                btnBuscar_Click(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                fecha_desde= dtpFechaDesde.Value;
                fecha_hasta = dtpFechaHasta.Value;



            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                fecha_desde = dtpFechaDesde.Value;
                fecha_hasta = dtpFechaHasta.Value;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnBuscar_Click(sender, e);
            }
            catch (Exception ex)
            {
                
             Log_Error_bus.Log_Error(ex.ToString());
            }

           

        }

        private void cmbbodega_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _Bodega_item_info = ((List<tb_Bodega_Info>)(cmbbodega.Properties.DataSource)).FirstOrDefault(v => v.IdBodega == Convert.ToInt32(cmbbodega.EditValue));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void Cargar_formulario(Cl_Enumeradores.eTipo_action tipo_accion)
        {


            try
            {


                Object ObjFrm;
                string textform = "";


                if (FormConsulta == null)
                {
                    MessageBox.Show("El nombre del formulario de consulta no esta establecido esta en null : variable FormConsulta " + NombreFormulario, "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                textform = ", Text: " + FormConsulta.Text;
                NombreFormulario = FormConsulta.ToString();
                NombreFormulario = NombreFormulario.Replace(textform, "");
                NombreFormulario = NombreFormulario.Replace("_Cons", "_Mant");
                NombreFormulario = NombreFormulario.Trim();



                if (NombreFormulario == "")
                {
                    MessageBox.Show("El nombre del formulario de consulta no esta establecido " + NombreFormulario, "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    Type tipo = Ensamblado.GetType(NombreFormulario);
                   



                    if (tipo == null)
                    {
                        MessageBox.Show("No se encontró el formulario de mantenimiento  Formulario:" + NombreFormulario, "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!this.FormularioEstaAbierto(NombreFormulario))
                        {
                            ObjFrm = Activator.CreateInstance(tipo);

                            PropertyInfo prop = tipo.GetProperty("_Accion");
                            if (prop != null)
                                prop.SetValue(ObjFrm, tipo_accion, null);



                            Form Formulario = (Form)ObjFrm;
                            Formulario.Text = "***NUEVO***";
                            if (FormMain != null)
                            { Formulario.MdiParent = FormMain; }
                            Formulario.Tag = this.Tag;
                            Formulario.WindowState = FormWindowState.Maximized;
                            Formulario.Show();

                        }
                    }

                }


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            
            }
        }

        private Boolean FormularioEstaAbierto(String NombreDelFrm)
        {
            try
            {
                if (FormMain.MdiChildren.Length > 0)
                {
                    for (int i = 0; i < FormMain.MdiChildren.Length; i++)
                    {

                        if (FormMain.MdiChildren[i].Name == NombreDelFrm.Substring(NombreDelFrm.IndexOf("frm"), NombreDelFrm.Length - NombreDelFrm.IndexOf("frm")))
                        {
                            FormMain.MdiChildren[i].Focus();
                            MessageBox.Show("El formulario solicitado ya se encuentra abierto");
                            return true;
                        }
                    }
                    return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        private void btnDuplicar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnDuplicar_ItemClick(sender, e);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
           

        }

        private void btnCancelarCuotas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnCancelarCuotas_ItemClick(sender, e);
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

           


           

        }

        private void btnDiseñoCheque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnDiseñoCheque_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());         
                
            }
        }

        private void btnGenerarXml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnGenerarXml_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void btnImpExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnImpExcel_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void btnCargaMarcaciónExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnCargaMarcaciónExcel_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void btnGenerarPeriodos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnGenerarPeriodos_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        private void panel_pie_fechas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoChq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnNuevoChq_ItemClick(sender, e);
        }

        private void btnLoteChq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnLoteChq_ItemClick(sender, e);
        }

        private void BtnDisChqCbte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_BtnDisChqCbte_Click(sender,e);
        }

        public DevExpress.XtraGrid.GridControl ObjGridControl_;
       
        public DevExpress.XtraGrid.GridControl GridControlConsulta
        {
            get { return this.ObjGridControl_; }
            set { ObjGridControl_  = value; }
        }

        private void btnGuardarLayoutGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ObjGridControl_.MainView.SaveLayoutToXml(ObjGridControl_.MainView.Name + ".xml");
                MessageBox.Show("Diseño de la consulta Grabado en su maquina..");
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }

        }

        private void btn_Habilitar_Reg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btn_Habilitar_Reg_ItemClick(sender,e);
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_Importar_XML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btn_Importar_XML_ItemClick(sender,e);
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnDisenioReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnDisenioReport_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnDescargar_Marca_Base_exter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            event_btnDescargar_Marca_Base_exter_ItemClick(sender, e);
        }

        

        private void cmb_CriterioBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int DiasTranscurridos = 0;
                DateTime fecha = DateTime.Now;
                switch (cmb_CriterioBusqueda.SelectedItem.ToString())
                {
                    case "Rango de fechas":
                        dtpFechaDesde.Value =Convert.ToDateTime( DateTime.Now.Date.AddMonths(-1).ToShortDateString());
                        dtpFechaHasta.Value =Convert.ToDateTime( DateTime.Now.Date.AddMonths(1).ToShortDateString());
                        break;
                    case "Última semana":
                        dtpFechaDesde.Value =Convert.ToDateTime( DateTime.Now.Date.AddDays(-7).ToShortDateString());
                        dtpFechaHasta.Value =Convert.ToDateTime( DateTime.Now.AddDays(1).ToShortDateString());
                        break;
                    case "Último mes":
                        dtpFechaDesde.Value =Convert.ToDateTime( DateTime.Now.Date.AddMonths(-1).ToShortDateString());
                        dtpFechaHasta.Value =Convert.ToDateTime( DateTime.Now.AddDays(1).ToShortDateString());
                        break;
                    case "Último trimestre":
                        dtpFechaDesde.Value =Convert.ToDateTime( DateTime.Now.Date.AddMonths(-3).ToShortDateString());
                        dtpFechaHasta.Value =Convert.ToDateTime( DateTime.Now.AddDays(1).ToShortDateString());
                        break;
                    case "Año pasado":
                        DiasTranscurridos = DateTime.Now.DayOfYear;
                        fecha = fecha.AddDays(-DiasTranscurridos+1);
                        dtpFechaDesde.Value =Convert.ToDateTime( fecha.Date.AddYears(-1).ToShortDateString());
                        dtpFechaHasta.Value =Convert.ToDateTime( fecha.AddDays(-1).ToShortDateString());
                        break;
                    case "Año actual":
                        DiasTranscurridos = DateTime.Now.DayOfYear;
                        fecha = fecha.AddDays(-DiasTranscurridos + 1);
                        dtpFechaDesde.Value  =Convert.ToDateTime( fecha.Date.ToShortDateString());
                        dtpFechaHasta.Value =Convert.ToDateTime( fecha.AddYears(1).AddDays(-1).ToShortDateString());
                        break;
                    case "Hoy":
                        dtpFechaDesde.Value = Convert.ToDateTime(DateTime.Now.Date.ToShortDateString());
                        dtpFechaHasta.Value =Convert.ToDateTime( DateTime.Now.ToShortDateString());
                        break;
                    default:
                        break;
                }

                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_imprimir_lote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btn_imprimir_lote_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

       



       




       


    }
}
