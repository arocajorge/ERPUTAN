using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Cotizacion_Consulta : Form
    {


        #region Declariaciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_cotizacion_Bus oBus = new fa_cotizacion_Bus();
        UCIn_Sucursal_Bodega Ctrl_SucBod = new UCIn_Sucursal_Bodega();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Info _SucursalInfo = new tb_Sucursal_Info();
        tb_Bodega_Info _BodegaInfo = new tb_Bodega_Info();
        fa_cotizacion_info info = new fa_cotizacion_info();
        private Cl_Enumeradores.eTipo_action _Accion;
        public decimal IdCotizacion;
        public string estado;
        #endregion


        public frmFa_Cotizacion_Consulta()
        {
            try
            {
                InitializeComponent();
                Ctrl_SucBod.Event_cmb_bodega_SelectedIndexChanged += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectedIndexChanged(Ctrl_SucBod_Event_cmb_bodega_SelectedIndexChanged);
                ucGe_Menu_Mantenimiento.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Ctrl_SucBod_Event_cmb_bodega_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ucGe_Menu_Mantenimiento_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                frmFa_Cotizacion_Mant frm = new frmFa_Cotizacion_Mant();
                if (info.IdCotizacion == 0)
                { return; }
                if (info.cc_estado == "I")
                {
                    MessageBox.Show("No se puede anular cotizacion por que ya se encuentra anulada");
                    return;
                }

                if (info.IdCotizacion == 0) { return; }

                frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                frm.IdCotizacion = info.IdCotizacion;
                frm.IdBodega = info.IdBodega;
                frm.IdSucursal = info.IdSucursal;
                frm.Text = "Cotizacion de Cliente - ANULACION";
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_frmFA_Cotizacion_Mant_FormClosing += new frmFa_Cotizacion_Mant.delegate_frmFA_Cotizacion_Mant_FormClosing(frm_event_frmFA_Cotizacion_Mant_FormClosing);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdCotizacion == 0) { return; }
                frmFa_Cotizacion_Mant frm = new frmFa_Cotizacion_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                frm.IdCotizacion = info.IdCotizacion;
                frm.IdBodega = info.IdBodega;
                frm.IdSucursal = info.IdSucursal;
                //frm.infocotizacion = info;
                if (info.cc_estado == "I") { frm.lblAnulado.Visible = true; }
                frm.Text = "Cotizacion de Cliente - CONSULTA";
                //frm.Vendedor = info.Vendedor;
                //frm.Cliente = info.Cliente;
                frm.MdiParent = this.MdiParent;
                frm.Show();

                frm.event_frmFA_Cotizacion_Mant_FormClosing += new frmFa_Cotizacion_Mant.delegate_frmFA_Cotizacion_Mant_FormClosing(frm_event_frmFA_Cotizacion_Mant_FormClosing);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_Mantenimiento_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdCotizacion == 0) { return; }

                if (info.cc_estado == "I")
                {
                    MessageBox.Show("No se puede Modificar cotizacion No. " + info.IdCotizacion + " por que ya se encuentra anulada");
                    return;
                }
                frmFa_Cotizacion_Mant frm = new frmFa_Cotizacion_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                frm.IdCotizacion = info.IdCotizacion;
                frm.IdBodega = info.IdBodega;
                frm.IdSucursal = info.IdSucursal;
                frm.infocotizacion = info;
                frm.Text = "Cotizacion de Cliente - MODIFICACION";
                //frm.Vendedor = info.Vendedor;
                //frm.Cliente = info.Cliente;
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_frmFA_Cotizacion_Mant_FormClosing += new frmFa_Cotizacion_Mant.delegate_frmFA_Cotizacion_Mant_FormClosing(frm_event_frmFA_Cotizacion_Mant_FormClosing);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_Mantenimiento_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewConsultaCot.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmFa_Cotizacion_Mant frm = new frmFa_Cotizacion_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.IdBodega = 1;
                frm.IdSucursal = ucGe_Menu_Mantenimiento.getIdSucursal;
                frm.IdCotizacion = 0;
                frm.Text = "Cotizacion de Cliente - NUEVO";
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_frmFA_Cotizacion_Mant_FormClosing += new frmFa_Cotizacion_Mant.delegate_frmFA_Cotizacion_Mant_FormClosing(frm_event_frmFA_Cotizacion_Mant_FormClosing);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmFA_Cotizacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #region Funciones
        public void VaciarGrid()
        {
            try
            {
                List<fa_cotizacion_info> VACIO = new List<fa_cotizacion_info>();
                gridConsultaCot.DataSource = VACIO;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void cargarGrid()
        {
            try
            {
                _BodegaInfo = Ctrl_SucBod.get_bodega();
                _SucursalInfo = Ctrl_SucBod.get_sucursal();
                List<fa_cotizacion_info> lst = new List<fa_cotizacion_info>();


                lst = oBus.Get_List_cotizacion(param.IdEmpresa, _SucursalInfo.IdSucursal, _SucursalInfo.IdSucursal, _BodegaInfo.IdBodega, _BodegaInfo.IdBodega, ucGe_Menu_Mantenimiento.fecha_desde, ucGe_Menu_Mantenimiento.fecha_hasta);
                gridConsultaCot.DataSource = lst;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void frmCO_Cotizacion_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        #endregion



    }
 }
