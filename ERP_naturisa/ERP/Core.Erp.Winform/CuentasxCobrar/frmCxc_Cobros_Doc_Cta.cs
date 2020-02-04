using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;

//V26022014 CJ 515
namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_Cobros_Doc_Cta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        /// <summary>
        /// Business de datos
        /// </summary>
        #region Business

        tb_Sucursal_Bus sucuBus = new tb_Sucursal_Bus();
        cxc_EstadoCobro_Bus estadoCobroBus = new cxc_EstadoCobro_Bus();
        cxc_cobro_tipo_Bus cobroTipoBus = new cxc_cobro_tipo_Bus();
        vwcxc_cobro_x_documentos_x_cobrar_Bus vwBus = new vwcxc_cobro_x_documentos_x_cobrar_Bus();

        BindingList<cxc_EstadoCobro_Info> lstEs = new BindingList<cxc_EstadoCobro_Info>();
        BindingList<cxc_cobro_tipo_Info> lstTipoDoc = new BindingList<cxc_cobro_tipo_Info>();
        BindingList<tb_Sucursal_Info> lstSucu = new BindingList<tb_Sucursal_Info>();

        #endregion


        public frmCxc_Cobros_Doc_Cta()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        private void loadpanel()
        {
            try
            {
                lstEs = new BindingList<cxc_EstadoCobro_Info>(estadoCobroBus.Get_List_EstadoCobro());
                lstSucu = new BindingList<tb_Sucursal_Info>(sucuBus.Get_List_Sucursal(param.IdEmpresa));
                lstEs.Insert(0, new cxc_EstadoCobro_Info() { IdEstadoCobro = "", Descripcion = "Todos" });
                cmbSucursal.Properties.DataSource = lstSucu;
                lstTipoDoc = new BindingList<cxc_cobro_tipo_Info>(cobroTipoBus.Get_List_Cobro_Tipo("S"));
                lstTipoDoc.Insert(0, new cxc_cobro_tipo_Info() { IdCobro_tipo = "", tc_descripcion = "Todos" });
                cmbEstadoCobro.Properties.DataSource = lstEs;
                dtHasta.EditValue = param.Fecha_Transac;
                dtDesde.EditValue = Convert.ToDateTime(dtHasta.EditValue).AddDays(-30);
                cmbTipoDoc.Properties.DataSource = lstTipoDoc;
                cmbEstadoCobro.EditValue = lstEs.ElementAt(3).IdEstadoCobro;
                cmbTipoDoc.EditValue = lstTipoDoc.ElementAt(0).IdCobro_tipo;
                cmbSucursal.EditValue = lstSucu.ElementAt(0).IdSucursal;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void frmCxc_Cobros_Doc_Cta_Load(object sender, EventArgs e)
        {
            try
            {
                loadpanel();
                ucfA_Cliente_Facturacion1.cmb_cliente.EditValueChanged += new EventHandler(cmbCliente_EditValueChanged);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        vwcxc_cobro_x_documentos_x_cobrar_Info Info = new vwcxc_cobro_x_documentos_x_cobrar_Info();

        private void get()
        {
            try
            {
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdSucursal = Convert.ToInt32(cmbSucursal.EditValue);
                Info.cr_fecha = Convert.ToDateTime(dtDesde.EditValue);
                Info.cr_fechaCobro = Convert.ToDateTime(dtHasta.EditValue);
                Info.IdEstadoCobro = cmbEstadoCobro.EditValue.ToString();
                Info.IdCliente = Convert.ToDecimal(ucfA_Cliente_Facturacion1.cmb_cliente.EditValue);
                Info.IdCobro_tipo = cmbTipoDoc.EditValue.ToString();
                if (rdFechaCobro.Checked == true)
                {
                    Tipo = Cl_Enumeradores.eTipo_Fecha_buscar_cobro.PorFechaCobro;
                }
                else
                {
                    Tipo = Cl_Enumeradores.eTipo_Fecha_buscar_cobro.PorFechaEdicion;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public Cl_Enumeradores.eTipo_Fecha_buscar_cobro Tipo { get; set; }


        private void vaciarGrid()
        {
            try
            {
                gridControlCobros.DataSource = null;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void formMantenimiento(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                frmCxc_Cobros_Doc_Cta_Mantenimiento frmMant = new frmCxc_Cobros_Doc_Cta_Mantenimiento();
                frmMant._Accion = _Accion;
                frmMant.setInfoVista((vwcxc_cobro_x_documentos_x_cobrar_Info)gridViewCobros.GetFocusedRow());
                frmMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                formMantenimiento(Cl_Enumeradores.eTipo_action.grabar);
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
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private Boolean validar()
        {
            try
            {
                if (cmbSucursal.EditValue == null || cmbSucursal.Text == "")
                {
                    MessageBox.Show("Debe seleccionar una sucursal", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (ucfA_Cliente_Facturacion1.cmb_cliente.EditValue == null || ucfA_Cliente_Facturacion1.cmb_cliente.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un cliente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (cmbEstadoCobro.EditValue == null)
                {
                    MessageBox.Show("Debe seleccionar el estado de Cobro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (cmbTipoDoc.EditValue == null)
                {
                    MessageBox.Show("Debe seleccionar el tipo de documento", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    get();
                    gridControlCobros.DataSource = vwBus.ListarVista(Info.IdEmpresa, Info.IdSucursal, Info.IdCliente, Info.IdEstadoCobro, Convert.ToDateTime(dtDesde.EditValue), Convert.ToDateTime(dtHasta.EditValue), Tipo, Info.IdCobro_tipo);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                vaciarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void cmbEstadoCobro_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                vaciarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void cmbTipoDoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                vaciarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void dtDesde_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(dtDesde.EditValue).ToShortDateString() != Convert.ToDateTime(dtHasta.EditValue).ToShortDateString())
                {
                    if (Convert.ToDateTime(dtDesde.EditValue).Date > Convert.ToDateTime(dtHasta.EditValue).Date)
                    {
                        MessageBox.Show("La fecha no debe ser mayor");
                        dtDesde.EditValue = param.Fecha_Transac;
                    }
                }
                vaciarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void dtHasta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                vaciarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void cmbCliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                vaciarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridControlCobros_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



    }
}
////OK 302
//V26022014 CJ 515 303