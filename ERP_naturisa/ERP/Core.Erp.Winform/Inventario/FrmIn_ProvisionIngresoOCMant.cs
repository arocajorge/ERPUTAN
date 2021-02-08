using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_ProvisionIngresoOCMant : Form
    {
        #region Delegado
        public delegate void delegateFrmIn_ProvisionIngresoOCMant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegateFrmIn_ProvisionIngresoOCMant_FormClosed event_delegateFrmIn_ProvisionIngresoOCMant_FormClosed;
        void FrmIn_ProvisionIngresoOCMant_event_delegateFrmIn_ProvisionIngresoOCMant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmIn_ProvisionIngresoOCMant_FormClosed(object sender, FormClosedEventArgs e)
        {
            event_delegateFrmIn_ProvisionIngresoOCMant_FormClosed(sender, e);
        }
        #endregion

        #region Variables
        Cl_Enumeradores.eTipo_action Accion;
        in_ProvisionIngresosPorOC_Info info;
        in_ProvisionIngresosPorOC_Bus bus;
        in_ProvisionIngresosPorOCDet_Bus busDet;
        BindingList<in_ProvisionIngresosPorOCDet_Info> blstDet;
        ct_Cbtecble_tipo_Bus busTipoCbte;
        ct_Centro_costo_Bus busCentroCosto;
        ct_centro_costo_sub_centro_costo_Bus busSubcentro;
        BindingList<ct_Cbtecble_det_Info> blstDetCuenta;

        ct_Plancta_Bus busPlancta;
        cl_parametrosGenerales_Bus param;
        ct_Cbtecble_det_Bus busDetConta;
        string MensajeError = string.Empty;
        #endregion

        public FrmIn_ProvisionIngresoOCMant()
        {
            InitializeComponent();
            info = new in_ProvisionIngresosPorOC_Info();
            bus = new in_ProvisionIngresosPorOC_Bus();
            busDet = new in_ProvisionIngresosPorOCDet_Bus();
            busPlancta = new ct_Plancta_Bus();
            blstDet = new BindingList<in_ProvisionIngresosPorOCDet_Info>();
            param = cl_parametrosGenerales_Bus.Instance;
            busTipoCbte = new ct_Cbtecble_tipo_Bus();
            busCentroCosto = new ct_Centro_costo_Bus();
            busSubcentro = new ct_centro_costo_sub_centro_costo_Bus();
            blstDetCuenta = new BindingList<ct_Cbtecble_det_Info>();
            busDetConta = new ct_Cbtecble_det_Bus();
            event_delegateFrmIn_ProvisionIngresoOCMant_FormClosed += FrmIn_ProvisionIngresoOCMant_event_delegateFrmIn_ProvisionIngresoOCMant_FormClosed;
        }

        public void SetInfo(Cl_Enumeradores.eTipo_action _Accion, in_ProvisionIngresosPorOC_Info _info)
        {
            Accion = _Accion;
            info = _info;
        }

        private void FrmIn_ProvisionIngresoOCMant_Load(object sender, EventArgs e)
        {
            gcDet.DataSource = blstDet;
            gcDiario.DataSource = blstDetCuenta;
            SetAccionInControls();
        }

        private void CargarCombos()
        {
            deFecha.DateTime = DateTime.Now.Date;
            deFechaIni.DateTime = DateTime.Now.Date;
            deFechaFin.DateTime = DateTime.Now.Date;

            var lstTipoCbte = busTipoCbte.Get_list_Cbtecble_tipo(param.IdEmpresa);
            cmbTipoCbte.Properties.DataSource = lstTipoCbte;
            cmbTipoCbte.EditValue = 1;

            var lstPlancta = busPlancta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa);
            cmbPlanctaCabecera.Properties.DataSource = lstPlancta;
            cmbCuentaDiario.DataSource = lstPlancta;

            var lstCentroCosto = busCentroCosto.Get_list_Centro_Costo(param.IdEmpresa);
            cmbCentroCostoDiario.DataSource = lstCentroCosto;

            var lstSubCentro = busSubcentro.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
            cmbSubcentroDiario.DataSource = lstSubCentro;
        }

        private void Limpiar()
        {
            Accion = Cl_Enumeradores.eTipo_action.grabar;
            txtIdProvision.Text = string.Empty;
            cmbPlanctaCabecera.EditValue = null;
            cmbTipoCbte.EditValue = 1;
            txtObservacion.Text = string.Empty;
            deFecha.DateTime = DateTime.Now.Date;
            deFechaIni.DateTime = DateTime.Now.Date;
            deFechaFin.DateTime = DateTime.Now.Date;
            blstDet = new BindingList<in_ProvisionIngresosPorOCDet_Info>();
            cmbTipoCbte.Properties.ReadOnly = false;
            gcDet.DataSource = blstDet;
            SetAccionInControls();
        }

        private void SetAccionInControls()
        {
            CargarCombos();
            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    menu.btnAnular.Visible = false;
                    menu.btnGuardar.Visible = true;
                    menu.btnGuardar_y_Salir.Visible = true;
                    menu.btnlimpiar.Visible = true;
                    cmbTipoCbte.Properties.ReadOnly = false ;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    menu.btnAnular.Visible = false;
                    menu.btnGuardar.Visible = true;
                    menu.btnGuardar_y_Salir.Visible = true;
                    menu.btnlimpiar.Visible = true;
                    cmbTipoCbte.Properties.ReadOnly = true;
                    SetInfoInControls();
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    menu.btnAnular.Visible = true;
                    menu.btnGuardar.Visible = false;
                    menu.btnGuardar_y_Salir.Visible = false;
                    menu.btnlimpiar.Visible = true;
                    cmbTipoCbte.Properties.ReadOnly = true;
                    SetInfoInControls();
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    menu.btnAnular.Visible = false;
                    menu.btnGuardar.Visible = false;
                    menu.btnGuardar_y_Salir.Visible = false;
                    menu.btnlimpiar.Visible = false;
                    cmbTipoCbte.Properties.ReadOnly = true;
                    SetInfoInControls();
                    break;
            }
        }

        private void SetInfoInControls()
        {
            if (info!= null)
            {
                info = bus.GetInfo(param.IdEmpresa, info.IdProvision);
                if (info != null)
                {
                    txtIdProvision.Text = info.IdProvision.ToString();
                    cmbPlanctaCabecera.EditValue = info.IdCtaCble;
                    cmbTipoCbte.EditValue = info.IdTipoCbte;
                    txtObservacion.Text = info.Observacion;
                    deFecha.DateTime = info.Fecha;
                    deFechaIni.DateTime = info.FechaIni;
                    deFechaFin.DateTime = info.FechaFin;
                    blstDet = new BindingList<in_ProvisionIngresosPorOCDet_Info>(busDet.GetList(info.IdEmpresa,info.IdProvision));
                    blstDetCuenta = new BindingList<ct_Cbtecble_det_Info>(busDetConta.Get_list_Cbtecble_det(info.IdEmpresa,info.IdTipoCbte,info.IdCbteCble,ref MensajeError));
                    gcDet.DataSource = blstDet;
                    gcDiario.DataSource = blstDetCuenta;
                }
            }            
        }

        private void GetInfo()
        {
            info = info ?? new in_ProvisionIngresosPorOC_Info();
            info.IdEmpresa = param.IdEmpresa;
            info.IdProvision = string.IsNullOrEmpty(txtIdProvision.Text) ? 0 : Convert.ToDecimal(txtIdProvision.Text);
            info.IdCtaCble = cmbPlanctaCabecera.EditValue.ToString();
            info.IdTipoCbte = Convert.ToInt32(cmbTipoCbte.EditValue);
            info.Observacion = txtObservacion.Text;
            info.Fecha = deFecha.DateTime;
            info.FechaIni = deFechaIni.DateTime;
            info.FechaFin = deFechaFin.DateTime;
            info.ListaDetalle = new List<in_ProvisionIngresosPorOCDet_Info>(blstDet);
            info.ListaDiario = new List<ct_Cbtecble_det_Info>(blstDetCuenta);
        }

        private bool Validar()
        {
            if (cmbTipoCbte.EditValue == null)
            {
                MessageBox.Show("Seleccione el tipo de comprobante",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }
            if (cmbPlanctaCabecera.EditValue == null)
            {
                MessageBox.Show("Seleccione la cuenta contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtObservacion.Text))
            {
                MessageBox.Show("Ingrese la observacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (deFecha.EditValue == null)
            {
                MessageBox.Show("Seleccione la fecha del diario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (deFechaIni.EditValue == null)
            {
                MessageBox.Show("Seleccione la fecha desde", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (deFechaFin.EditValue == null)
            {
                MessageBox.Show("Seleccione la fecha hasta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (blstDet.Count == 0)
            {
                MessageBox.Show("No hay registros que procesar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private bool AccionGuardar()
        {
            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    if (!Validar())
                        return false;
                    return Guardar();
                case Cl_Enumeradores.eTipo_action.actualizar:
                    if (!Validar())
                        return false;
                    return Modificar();
                case Cl_Enumeradores.eTipo_action.Anular:
                    return Anular();
            }

            return true;
        }

        private bool Guardar()
        {
            GetInfo();
            if (bus.GuardarDB(info))
            {
                MessageBox.Show("Registro guardado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else
            {
                MessageBox.Show("No se pudo guardar el registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            
        }

        private bool Modificar()
        {
            GetInfo();
            if (bus.ModificarDB(info))
            {
                MessageBox.Show("Registro modificado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else
            {
                MessageBox.Show("No se pudo modificar el registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        private bool Anular()
        {
            GetInfo();
            if (bus.AnularDB(info))
            {
                MessageBox.Show("Registro anulado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else
            {
                MessageBox.Show("No se pudo anular el registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {

            if (cmbPlanctaCabecera.EditValue == null)
            {
                MessageBox.Show("Seleccione la cuenta contable de provisión",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            gcDet.DataSource = null;
            blstDet = new BindingList<in_ProvisionIngresosPorOCDet_Info>(busDet.GetList(param.IdEmpresa, deFechaIni.DateTime, deFechaFin.DateTime));
            gcDet.DataSource = blstDet;

            if (blstDet.Where(q => string.IsNullOrEmpty(q.IdCtaCtble_Inve)).Count() > 0)
            {
                MessageBox.Show("Existen bodegas sin cuenta contable de inventario y no se puede generar el diario contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ArmarDiario();            
        }

        private void ArmarDiario()
        {
            var lstAgrupada = (from a in blstDet
                               group a by a.IdCtaCtble_Inve into g
                               select new ct_Cbtecble_det_Info
                               {
                                   IdCtaCble = g.Key,
                                   dc_Valor = g.Sum(q => q.Costo),
                                   dc_Valor_D = g.Sum(q => q.Costo)
                               }).ToList();


            lstAgrupada.ForEach(q => { q.dc_Valor = Math.Round(q.dc_Valor, 2, MidpointRounding.AwayFromZero); q.dc_Valor_D = Math.Round(q.dc_Valor_D, 2, MidpointRounding.AwayFromZero); });
            lstAgrupada.Add(new ct_Cbtecble_det_Info
            {
                IdCtaCble = cmbPlanctaCabecera.EditValue.ToString(),
                dc_Valor = Math.Round(lstAgrupada.Sum(q => q.dc_Valor) * -1, 2, MidpointRounding.AwayFromZero),
                dc_Valor_H = Math.Round(lstAgrupada.Sum(q => q.dc_Valor), 2, MidpointRounding.AwayFromZero)
            });
            blstDetCuenta = new BindingList<ct_Cbtecble_det_Info>(lstAgrupada);
            gcDiario.DataSource = blstDetCuenta;
        }

        private void menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            if (AccionGuardar())
            {
                this.Close();
            }
        }

        private void menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (AccionGuardar())
            {
                Limpiar();
            }
        }

        private void menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (AccionGuardar())
            {
                this.Close();
            }
        }

        private void menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            gcDet.ShowPrintPreview();
        }

        private void gvDet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gvDet.DeleteSelectedRows();
                    ArmarDiario();
                }
            }
        }
    }
}
