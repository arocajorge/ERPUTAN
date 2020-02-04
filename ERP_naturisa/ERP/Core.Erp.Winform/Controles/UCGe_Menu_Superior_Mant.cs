using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Menu_Superior_Mant : UserControl
    {
        #region Declaración de Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        #endregion

        #region Fx Visible


        public Boolean Visible_btn_Imprimir_Reten
        {
            get
            {
                return this.btn_Imprimir_Reten.Visible;
            }
            set
            {
                this.btn_Imprimir_Reten.Visible = value;
            }
        }

        public Boolean Visible_btnModificar
        {
            get
            {
                return this.btnModificar.Visible;
            }
            set
            {
                this.btnModificar.Visible = value;
            }
        }

        public Boolean Visible_btnContabilizar
        {
            get { return this.btnContabilizar.Visible; }
            set { this.btnContabilizar.Visible = value; }
        }

        public Boolean Visible_btn_Imprimir_Cheq
        {
            get
            {
                return this.btn_Imprimir_Cheq.Visible;
            }
            set
            {
                this.btn_Imprimir_Cheq.Visible = value;
            }
        }

        public Boolean Visible_btn_Actualizar
        {
            get
            {
                return this.btn_Actualizar.Visible;
            }
            set
            {
                this.btn_Actualizar.Visible = value;
            }
        }

        public Boolean Visible_btn_conciliacion_Auto
        {
            get
            {
                return this.btn_conciliacion_Auto.Visible;
            }
            set
            {
                this.btn_conciliacion_Auto.Visible = value;
            }
        }

        public Boolean Visible_btn_Imprimir_Cbte
        {
            get
            {
                return this.btn_Imprimir_Cbte.Visible;
            }
            set
            {
                this.btn_Imprimir_Cbte.Visible = value;
            }
        }

        


        public Boolean Visible_btnAceptar
        {
            get
            {
                return this.btnAceptar.Visible;
            }
            set
            {
                this.btnAceptar.Visible = value;
            }
        }

        public Boolean Visible_btnGuardar
        {
            get
            {
                return this.btnGuardar.Visible;
            }
            set
            {
                this.btnGuardar.Visible = value;
            }
        }

        public Boolean Visible_btnImprimirSoporte
        {
            get
            {
                return this.btnImprimirSoporte.Visible;
            }
            set
            {
                this.btnImprimirSoporte.Visible = value;
            }
        }

        public Boolean Visible_bntGuardar_y_Salir
        {
            get
            {
                return this.btnGuardar_y_Salir.Visible;
            }
            set
            {
                this.btnGuardar_y_Salir.Visible = value;
            }
        }

        public Boolean Visible_bntLimpiar
        {
            get
            {
                return this.btnlimpiar.Visible;
            }
            set
            {
                this.btnlimpiar.Visible = value;
            }
        }

        public Boolean Visible_bntImprimir
        {
            get
            {
                return this.btnImprimir.Visible;
            }
            set
            {
                this.btnImprimir.Visible = value;
            }
        }

        public Boolean Visible_bntReImprimir
        {
            get
            {
                return this.btnReImprimir.Visible;
            }
            set
            {
                this.btnReImprimir.Visible = value;
            }
        }

        public Boolean Visible_bntImprimir_Guia
        {
            get
            {
                return this.btnImprimir_guia.Visible;
            }
            set
            {
                this.btnImprimir_guia.Visible = value;
            }
        }

        public Boolean Visible_bntAprobar
        {
            get
            {
                return this.btnAprobar.Visible;
            }
            set
            {
                this.btnAprobar.Visible = value;
            }
        }

        public Boolean Visible_bntAnular
        {
            get
            {
                return this.btnAnular.Visible;
            }
            set
            {
                this.btnAnular.Visible = value;
            }
        }

        public Boolean Visible_bntSalir
        {
            get
            {
                return this.btnSalir.Visible;
            }
            set
            {
                this.btnSalir.Visible = value;
            }
        }

        public Boolean Visible_btnAprobarGuardarSalir
        {
            get
            {
                return this.btnAprobarGuardarSalir.Visible;
            }
            set
            {
                this.btnAprobarGuardarSalir.Visible = value;
            }
        }

        public Boolean Visible_btnEstadosOC
        {
            get
            {
                return this.btnEstadosOC.Visible;
            }
            set
            {
                this.btnEstadosOC.Visible = value;
            }

        }

        public Boolean Visible_btnImpRep
        {
            get
            {
                return this.btnImpRep.Visible;
            }
            set
            {
                this.btnImpRep.Visible = value;
            }

        }

        public Boolean Visible_btnImpFrm
        {
            get
            {
                return this.btnImpFrm.Visible;
            }
            set
            {
                this.btnImpFrm.Visible = value;
            }

        }

        public Boolean Visible_btnproductos
        {
            get
            {
                return this.btnproductos.Visible;
            }
            set
            {
                this.btnproductos.Visible = value;
            }
        }

        public Boolean Visible_btnImpLote
        {
            get
            {
                return this.btnImpLote.Visible;
            }
            set
            {
                this.btnImpLote.Visible = value;
            }
        }

        public Boolean Visible_btn_Generar_XML
        {
            get
            {
                return this.btn_Generar_XML.Visible;
            }
            set
            {
                this.btn_Generar_XML.Visible = value;
            }
        }

        public Boolean Visible_bntDiseñoReporte
        {
            get
            {
                return this.btn_DiseñoReporte.Visible;
            }
            set
            {
                this.btn_DiseñoReporte.Visible = value;
            }
        }
        
        #endregion
        
        #region Fx Enable






        public Boolean Enabled_btn_Imprimir_Reten
        {
            get
            {
                return this.btn_Imprimir_Reten.Enabled;
            }
            set
            {
                this.btn_Imprimir_Reten.Enabled = value;
            }
        }


        public Boolean Enabled_btn_Imprimir_Cheq
        {
            get
            {
                return this.btn_Imprimir_Cheq.Enabled;
            }
            set
            {
                this.btn_Imprimir_Cheq.Enabled = value;
            }
        }

        public Boolean Enabled_btn_Imprimir_Cbte
        {
            get
            {
                return this.btn_Imprimir_Cbte.Enabled;
            }
            set
            {
                this.btn_Imprimir_Cbte.Enabled = value;
            }
        }

        public Boolean Enabled_btn_conciliacion_Auto
        {
            get
            {
                return this.btn_conciliacion_Auto.Enabled;
            }
            set
            {
                this.btn_conciliacion_Auto.Enabled = value;
            }
        }

        public Boolean Enabled_btnAceptar
        {
            get
            {
                return this.btnAceptar.Enabled;
            }
            set
            {
                this.btnAceptar.Enabled = value;
            }
        }

        public Boolean Enabled_btnGuardar
        {
            get
            {
                return this.btnGuardar.Enabled;
            }
            set
            {
                this.btnGuardar.Enabled  = value;
            }
        }

        public Boolean Enabled_btnImprimirSoporte
        {
            get
            {
                return this.btnImprimirSoporte.Enabled;
            }
            set
            {
                this.btnImprimirSoporte.Enabled = value;
            }
        }

        public Boolean Enabled_bntGuardar_y_Salir
        {
            get
            {
                return this.btnGuardar_y_Salir.Enabled;
            }
            set
            {
                this.btnGuardar_y_Salir.Enabled = value;
            }
        }

        public Boolean Enabled_bntLimpiar
        {
            get
            {
                return this.btnlimpiar.Enabled;
            }
            set
            {
                this.btnlimpiar.Enabled  = value;
            }
        }

        public Boolean Enabled_bntImprimir
        {
            get
            {
                return this.btnImprimir.Enabled;
            }
            set
            {
                this.btnImprimir.Enabled  = value;
            }
        }

        public Boolean Enabled_bnRetImprimir
        {
            get
            {
                return this.btnReImprimir.Enabled;
            }
            set
            {
                this.btnReImprimir.Enabled = value;
            }
        }

        public Boolean Enabled_bntImprimir_Guia
        {
            get
            {
                return this.btnImprimir_guia.Enabled;
            }
            set
            {
                this.btnImprimir_guia.Enabled = value;
            }
        }

        public Boolean Enabled_bntAprobar
        {
            get
            {
                return this.btnAprobar.Enabled;
            }
            set
            {
                this.btnAprobar.Enabled = value;
            }
        }

        public Boolean Enabled_bntAnular
        {
            get
            {
                return this.btnAnular.Enabled;
            }
            set
            {
                this.btnAnular.Enabled = value;
            }
        }

        public Boolean Enabled_bntSalir
        {
            get
            {
                return this.btnSalir.Enabled;
            }
            set
            {
                this.btnSalir.Enabled = value;
            }
        }

        public Boolean Enabled_btnAprobarGuardarSalir
        {
            get
            {
                return this.btnAprobarGuardarSalir.Enabled;
            }
            set
            {
                this.btnAprobarGuardarSalir.Enabled  = value;
            }
        }

        public Boolean Enabled_btnEstadosOC
        {

            get
            {
                return this.btnEstadosOC.Enabled;
            }
            set
            {
                this.btnEstadosOC.Enabled = value;
            }

        }

        public Boolean Enabled_btnImpRep
        {
            get
            {
                return this.btnImpRep.Enabled;
            }
            set
            {
                this.btnImpRep.Enabled = value;
            }
        }

        public Boolean Enabled_btnImpFrm
        {
            get
            {
                return this.btnImpFrm.Enabled;
            }
            set
            {
                this.btnImpFrm.Enabled = value;
            }
        }

        public Boolean Enabled_btnproductos
        {
            get
            {
                return this.btnproductos.Enabled;
            }
            set
            {
                this.btnproductos.Enabled = value;
            }
        }

        public Boolean Enabled_btnImpLote
        {
            get
            {
                return this.btnImpLote.Enabled;
            }
            set
            {
                this.btnImpLote.Enabled = value;
            }
        }

        public Boolean Enabled_btn_Generar_XML
        {
            get
            {
                return this.btn_Generar_XML.Enabled;
            }
            set
            {
                this.btn_Generar_XML.Enabled = value;
            }
        }

        public Boolean Enabled_btn_DiseñoReporte
        {
            get
            {
                return this.btn_DiseñoReporte.Enabled;
            }
            set
            {
                this.btn_DiseñoReporte.Enabled = value;
            }
        }

        #endregion

        #region declaracion de delegados y eventos

        public delegate void delegate_btnContabilizar_Click(object sender, EventArgs e);
        public event delegate_btnContabilizar_Click event_btnContabilizar_Click;

        public delegate void delegate_btn_Actualizar_Click(object sender, EventArgs e);
        public event delegate_btn_Actualizar_Click event_btnActualizar_Click;

        public delegate void delegate_btn_Imprimir_Reten_Click(object sender, EventArgs e);
        public event delegate_btn_Imprimir_Reten_Click event_btn_Imprimir_Reten_Click;

        public delegate void delegate_btn_Imprimir_Cheq_Click(object sender, EventArgs e);
        public event delegate_btn_Imprimir_Cheq_Click event_btn_Imprimir_Cheq_Click;

        public delegate void delegate_btn_Imprimir_Cbte_Click(object sender, EventArgs e);
        public event delegate_btn_Imprimir_Cbte_Click event_btn_Imprimir_Cbte_Click;

        public delegate void delegate_btn_conciliacion_Auto_Click(object sender, EventArgs e);
        public event delegate_btn_conciliacion_Auto_Click event_btn_conciliacion_Auto_Click;

        public delegate void delegate_btnGuardar_Click(object sender, EventArgs e);
        public event delegate_btnGuardar_Click event_btnGuardar_Click;

        public delegate void delegate_btnGuardar_y_Salir_Click(object sender, EventArgs e);
        public event delegate_btnGuardar_y_Salir_Click event_btnGuardar_y_Salir_Click;

        public delegate void delegate_btnAprobarGuardarSalir_Click(object sender, EventArgs e);
        public event delegate_btnAprobarGuardarSalir_Click event_btnAprobarGuardarSalir_Click;

        public delegate void delegate_btnlimpiar_Click(object sender, EventArgs e);
        public event delegate_btnlimpiar_Click event_btnlimpiar_Click;

        public delegate void delegate_btnImprimir_Click(object sender, EventArgs e);
        public event delegate_btnImprimir_Click event_btnImprimir_Click;

        public delegate void delegate_btnReImprimir_Click(object sender, EventArgs e);
        public event delegate_btnReImprimir_Click event_btnReImprimir_Click;

        public delegate void delegate_btnAprobar_Click(object sender, EventArgs e);
        public event delegate_btnAprobar_Click event_btnAprobar_Click;

        public delegate void delegate_btnAnular_Click(object sender, EventArgs e);
        public event delegate_btnAnular_Click event_btnAnular_Click;

        public delegate void delegate_btnSalir_Click(object sender, EventArgs e);
        public event delegate_btnSalir_Click event_btnSalir_Click;

        public delegate void delegate_btnAceptar_Click(object sender, EventArgs e);
        public event delegate_btnAceptar_Click event_btnAceptar_Click;

        public delegate void delegate_btnImprimir_guia_Click(object sender, EventArgs e);
        public event delegate_btnImprimir_guia_Click event_btnImprimir_guia_Click;

        public delegate void delegate_btnEstadosOC_Click(object sender, EventArgs e);
        public event delegate_btnEstadosOC_Click event_btnEstadosOC_Click;

        public delegate void delegate_btnImpRep_Click(object sender, EventArgs e);
        public event delegate_btnImpRep_Click event_btnImpRep_Click;

        public delegate void delegate_btnImpFrm_Click(object sender, EventArgs e);
        public event delegate_btnImpFrm_Click event_btnImpFrm_Click;

        public delegate void delegate_btnImprimirSoporte_Click(object sender, EventArgs e);
        public event delegate_btnImprimirSoporte_Click event_btnImprimirSoporte_Click;

        public delegate void delegate_btnproductos_Click(object sender, EventArgs e);
        public event delegate_btnproductos_Click event_btnproductos_Click;

        public delegate void delegate_btnImpLote_Click(object sender, EventArgs e);
        public event delegate_btnImpLote_Click event_btnImpLote_Click;

        public delegate void delegate_btn_Generar_XML_Click(object sender, EventArgs e);
        public event delegate_btn_Generar_XML_Click event_btn_Generar_XML_Click;

        public delegate void delegate_btn_DiseñoReporte_Click(object sender, EventArgs e);
        public event delegate_btn_DiseñoReporte_Click event_btn_DiseñoReporte_Click;

        public delegate void delegate_btnModificar_Click(object sender, EventArgs e);
        public event delegate_btnModificar_Click event_btnModificar_Click;
        #endregion
       
        public UCGe_Menu_Superior_Mant()
        {
            try
            {
                InitializeComponent();

                event_btnAnular_Click += UCGe_Menu_Superior_Mant_event_btnAnular_Click;
                event_btnGuardar_Click += UCGe_Menu_Superior_Mant_event_btnGuardar_Click;
                event_btnGuardar_y_Salir_Click += UCGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click;
                event_btnImprimir_Click += UCGe_Menu_Superior_Mant_event_btnImprimir_Click;
                event_btnlimpiar_Click += UCGe_Menu_Superior_Mant_event_btnlimpiar_Click;
                event_btnSalir_Click += UCGe_Menu_Superior_Mant_event_btnSalir_Click;
                event_btnAceptar_Click += UCGe_Menu_Superior_Mant_event_btnAceptar_Click;
                event_btnAprobar_Click += UCGe_Menu_Superior_Mant_event_btnAprobar_Click;
                event_btnAprobarGuardarSalir_Click += UCGe_Menu_Superior_Mant_event_btnAprobarGuardarSalir_Click;
                event_btnImprimir_guia_Click += UCGe_Menu_Superior_Mant_event_btnImprimir_guia_Click;
                event_btnEstadosOC_Click += UCGe_Menu_Superior_Mant_event_btnEstadosOC_Click;
                event_btnReImprimir_Click += UCGe_Menu_Superior_Mant_event_btnReImprimir_Click;
                event_btnImpFrm_Click += UCGe_Menu_Superior_Mant_event_btnImpFrm_Click;
                event_btnImpRep_Click += UCGe_Menu_Superior_Mant_event_btnImpRep_Click;
                event_btnImprimirSoporte_Click += UCGe_Menu_Superior_Mant_event_btnImprimirSoporte_Click;
                event_btnImpLote_Click += UCGe_Menu_Superior_Mant_event_btnImpLote_Click;
                event_btn_Generar_XML_Click += UCGe_Menu_Superior_Mant_event_btn_Generar_XML_Click;
                event_btnContabilizar_Click += UCGe_Menu_Superior_Mant_event_btnContabilizar_Click;
                event_btn_DiseñoReporte_Click += UCGe_Menu_Superior_Mant_event_btn_DiseñoReporte_Click;

                event_btn_conciliacion_Auto_Click += UCGe_Menu_Superior_Mant_event_btn_conciliacion_Auto_Click;

                event_btn_Imprimir_Cbte_Click += UCGe_Menu_Superior_Mant_event_btn_Imprimir_Cbte_Click;

                event_btn_Imprimir_Cheq_Click += UCGe_Menu_Superior_Mant_event_btn_Imprimir_Cheq_Click;
                event_btn_Imprimir_Reten_Click += UCGe_Menu_Superior_Mant_event_btn_Imprimir_Reten_Click;
                event_btnActualizar_Click += UCGe_Menu_Superior_Mant_event_btnActualizar_Click;
                event_btnModificar_Click += UCGe_Menu_Superior_Mant_event_btnModificar_Click;
                btnAceptar.Visible = false;
                btnAprobar.Visible = false;
                btnAprobarGuardarSalir.Visible = true;
                btnImprimir_guia.Visible = false;
                btnEstadosOC.Visible = false;
                btnReImprimir.Visible = false;
                btnImpFrm.Visible = false;
                btnImpRep.Visible = false;
                btnImprimirSoporte.Visible = false;
                btnproductos.Visible = false;
                btnImpLote.Visible = false;
                btn_Generar_XML.Visible = false;
                btn_DiseñoReporte.Visible = false;
                btn_conciliacion_Auto.Visible = false;
                btn_Imprimir_Cbte.Visible = false;
                btn_Imprimir_Cheq.Visible = false;
                btn_Imprimir_Reten.Visible = false;
                btn_Actualizar.Visible = false;

                this.Dock = DockStyle.Top;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCGe_Menu_Superior_Mant_event_btnContabilizar_Click(object sender, EventArgs e)
        {
            
        }

        void UCGe_Menu_Superior_Mant_event_btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        void UCGe_Menu_Superior_Mant_event_btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        void UCGe_Menu_Superior_Mant_event_btn_Imprimir_Reten_Click(object sender, EventArgs e)
        {
            
        }

        void UCGe_Menu_Superior_Mant_event_btn_Imprimir_Cheq_Click(object sender, EventArgs e)
        {
            
        }

        void UCGe_Menu_Superior_Mant_event_btn_Imprimir_Cbte_Click(object sender, EventArgs e)
        {
            
        }

        #region void de eventos

        void UCGe_Menu_Superior_Mant_event_btn_conciliacion_Auto_Click(object sender, EventArgs e)
        {

        }
        
        void UCGe_Menu_Superior_Mant_event_btn_DiseñoReporte_Click(object sender, EventArgs e)
        {

        }
        
        void UCGe_Menu_Superior_Mant_event_btn_Generar_XML_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnImpLote_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnImprimirSoporte_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnEstadosOC_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnImprimir_guia_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
        
        }

        void UCGe_Menu_Superior_Mant_event_btnAceptar_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnlimpiar_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnImprimir_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnAprobar_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnAnular_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnReImprimir_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnImpRep_Click(object sender, EventArgs e)
        {

        }

        void UCGe_Menu_Superior_Mant_event_btnImpFrm_Click(object sender, EventArgs e)
        {

        }
        #endregion
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnGuardar_Click(sender, e);
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {

            try
            {
                event_btnGuardar_y_Salir_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnlimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            try
            {
                event_btnImprimir_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnAprobar_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnAnular_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {


                event_btnSalir_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnAceptar_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnAprobarGuardarSalir_Click(sender, e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            
            _Accion = iAccion;
            switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    btnAnular.Enabled = false;
                    btnImprimir.Enabled = false;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:

                    btnImprimir.Enabled = false;
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:

                    btnGuardar.Enabled = false;
                    btnGuardar_y_Salir.Enabled = false;
                    btnAnular.Enabled = true;
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:

                    btnGuardar.Visible = false;
                    btnGuardar_y_Salir.Visible = false;
                    btnAnular.Visible = false;
                    break;
                default:
                    break;
            }
        
        }

        private void btnImprimir_guia_Click(object sender, EventArgs e)
        {

            try
            {
                event_btnImprimir_guia_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnEstadosOC_Click(object sender, EventArgs e)
        {

            try
            {
                event_btnEstadosOC_Click(sender,e);
                event_btnImprimir_guia_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnReImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnReImprimir_Click(sender,e);
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnImpRep_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnImpRep_Click(sender,e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnImpFrm_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnImpFrm_Click(sender,e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnImprimirSoporte_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnImprimirSoporte_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnproductos_Click(sender,e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnImpLote_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnImpLote_Click(sender,e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btn_Generar_XML_Click(object sender, EventArgs e)
        {
            try
            {
                event_btn_Generar_XML_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_DiseñoReporte_Click(object sender, EventArgs e)
        {
            try
            {
              
                event_btn_DiseñoReporte_Click(sender,e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        private void btn_conciliacion_Auto_Click(object sender, EventArgs e)
        {
            try
            {
                event_btn_conciliacion_Auto_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_Imprimir_Cbte_Click(object sender, EventArgs e)
        {
            try
            {
                event_btn_Imprimir_Cbte_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
            
        }

        private void btn_Imprimir_Cheq_Click(object sender, EventArgs e)
        {
            try
            {
                event_btn_Imprimir_Cheq_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_Imprimir_Reten_Click(object sender, EventArgs e)
        {
            try
            {
                event_btn_Imprimir_Reten_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnActualizar_Click(sender, e);
            }
            catch (Exception)
            {                
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnModificar_Click(sender, e);
            }
            catch (Exception)
            {
            }
        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            try
            {
                event_btnContabilizar_Click(sender, e);
            }
            catch (Exception)
            {
            }
        }

        
       
    }
}
