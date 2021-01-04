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
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_DistribucionMantenimiento : Form
    {
        #region Variables
        Cl_Enumeradores.eTipo_action Accion;
        ct_Plancta_Bus busPlancta;
        List<ct_Plancta_Info> lstPlancta;
        ct_Distribucion_Info info;
        ct_Distribucion_Bus bus;
        ct_Cbtecble_tipo_Bus busTipoCbte;
        cl_parametrosGenerales_Bus param;
        ct_Centro_costo_Bus busCentroCosto;
        ct_centro_costo_sub_centro_costo_Bus busSubcentro;
        List<ct_centro_costo_sub_centro_costo_Info> lstSubCentro;
        List<ct_Centro_costo_Info> lstCentroCosto;
        BindingList<ct_DistribucionDetDistribuido_Info> blstDet;
        BindingList<ct_Cbtecble_det_Info> blstDiario;
        ct_Plancta_Info rowPlancta;
        BindingList<ct_DistribucionDetPorDistribuir_Info> blstPlanctaSaldo;
        #endregion

        #region Delegados
        public delegate void delegate_frmCon_DistribucionMantenimiento_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmCon_DistribucionMantenimiento_FormClosed event_delegate_frmCon_DistribucionMantenimiento_FormClosed;
        private void frmCon_DistribucionMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmCon_DistribucionMantenimiento_FormClosed(sender, e);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        void frmCon_DistribucionMantenimiento_event_delegate_frmCon_DistribucionMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        #endregion

        public frmCon_DistribucionMantenimiento()
        {
            InitializeComponent();
            busPlancta = new ct_Plancta_Bus();
            lstPlancta = new List<ct_Plancta_Info>();
            info = new ct_Distribucion_Info();
            busTipoCbte = new ct_Cbtecble_tipo_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            busCentroCosto = new ct_Centro_costo_Bus();
            busSubcentro = new ct_centro_costo_sub_centro_costo_Bus();
            lstSubCentro = new List<ct_centro_costo_sub_centro_costo_Info>();
            lstCentroCosto = new List<ct_Centro_costo_Info>();
            blstDet = new BindingList<ct_DistribucionDetDistribuido_Info>();
            blstDiario = new BindingList<ct_Cbtecble_det_Info>();
            rowPlancta = new ct_Plancta_Info();
            blstPlanctaSaldo = new BindingList<ct_DistribucionDetPorDistribuir_Info>();
            bus = new ct_Distribucion_Bus();
            event_delegate_frmCon_DistribucionMantenimiento_FormClosed += frmCon_DistribucionMantenimiento_event_delegate_frmCon_DistribucionMantenimiento_FormClosed;
        }

        private void frmCon_DistribucionMantenimiento_Load(object sender, EventArgs e)
        {
            deFechaFin.DateTime = DateTime.Now.Date;
            gcDetalleCuenta.DataSource = blstPlanctaSaldo;
            SetAccionInControls();
        }

        #region metodos
        private void CargarCombos()
        {
            try
            {
                var lstTipoCbte = busTipoCbte.Get_list_Cbtecble_tipo(param.IdEmpresa);
                cmbTipoCbte.Properties.DataSource = lstTipoCbte;
                cmbTipoCbte.EditValue = 1;

                lstPlancta = busPlancta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa);
                cmbCuenta.DataSource = lstPlancta;
                cmbPlanctaCuenta.DataSource = lstPlancta;
                cmbCuentaDiario.DataSource = lstPlancta;
                cmbPlanctaCabecera.Properties.DataSource = lstPlancta;

                lstCentroCosto = busCentroCosto.Get_list_Centro_Costo(param.IdEmpresa);
                cmbCentroCosto.DataSource = lstCentroCosto;
                cmbCentroCostoCuenta.DataSource = lstCentroCosto;
                cmbCentroCostoDiario.DataSource = lstCentroCosto;

                lstSubCentro = busSubcentro.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmbSubCentro.DataSource = lstSubCentro;
                cmbSubCentroCuenta.DataSource = lstSubCentro;
                cmbSubcentroDiario.DataSource = lstSubCentro;
            }
            catch (Exception)
            {

            }
        }
        
        public void SetAccion(Cl_Enumeradores.eTipo_action _Accion, ct_Distribucion_Info _info)
        {
            Accion = _Accion;
            info = _info;
        }

        private void SetAccionInControls()
        {
            gcDetalle.DataSource = blstDet;
            CargarCombos();
            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucMenu.btnGuardar.Visible = true;
                    ucMenu.btnGuardar_y_Salir.Visible = true;
                    ucMenu.btnAnular.Visible = false;
                    ucMenu.btnlimpiar.Visible = true;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucMenu.btnGuardar.Visible = true;
                    ucMenu.btnGuardar_y_Salir.Visible = true;
                    ucMenu.btnAnular.Visible = false;
                    ucMenu.btnlimpiar.Visible = true;
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    ucMenu.btnGuardar.Visible = false;
                    ucMenu.btnGuardar_y_Salir.Visible = false;
                    ucMenu.btnAnular.Visible = true;
                    ucMenu.btnlimpiar.Visible = false;
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucMenu.btnGuardar.Visible = false;
                    ucMenu.btnGuardar_y_Salir.Visible = false;
                    ucMenu.btnAnular.Visible = false;
                    ucMenu.btnlimpiar.Visible = false;
                    break;
            }
        }

        private void SetInfoInControls()
        {
            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion

        #region Eventos
        private void ucMenu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        
        private void EstablecerCheckeo(DevExpress.XtraTreeList.Nodes.TreeListNodes Nodes)
        {
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in Nodes)
            {
                if (nodo.CheckState == CheckState.Unchecked)
                {
                    nodo.SetValue("Seleccionado", false);
                }
                else
                {
                    nodo.SetValue("Seleccionado", true);
                }
                if (nodo.Nodes.Count > 0)
                    EstablecerCheckeo(nodo.Nodes);
            }
        }

        private void btnDistribuir_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdDistribucion.Focus();
                blstDiario = new BindingList<ct_Cbtecble_det_Info>();
                gcDiario.DataSource = blstDiario;
                if (blstDet.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un metodo de distribución");
                    return;
                }
                
                var ValorTotalDistribucion = blstDet.Sum(q => q.F3);
                foreach (var Cta in blstPlanctaSaldo)
                {
                    blstDiario.Add(new ct_Cbtecble_det_Info
                    {
                        IdCtaCble = Cta.IdCtaCble,
                        IdCentroCosto = Cta.IdCentroCosto,
                        IdCentroCosto_sub_centro_costo = Cta.IdCentroCosto_sub_centro_costo,
                        IdRegistro = string.IsNullOrEmpty(Cta.IdCentroCosto) ? null : (Cta.IdCentroCosto + "-" + Cta.IdCentroCosto_sub_centro_costo),
                        dc_Valor = Convert.ToDouble(Math.Round(Cta.Valor * -1,2,MidpointRounding.AwayFromZero)),
                        dc_Valor_D = Convert.ToDouble(Math.Round(Cta.Valor * -1, 2, MidpointRounding.AwayFromZero) > 0 ? Math.Round(Cta.Valor * -1, 2, MidpointRounding.AwayFromZero) : 0),
                        dc_Valor_H = Convert.ToDouble(Math.Round(Cta.Valor * -1, 2, MidpointRounding.AwayFromZero) < 0 ? Math.Abs(Math.Round(Cta.Valor * -1, 2, MidpointRounding.AwayFromZero)) : 0),
                    });

                    foreach (var Dis in blstDet)
                    {
                        blstDiario.Add(new ct_Cbtecble_det_Info
                        {
                            IdCtaCble = Dis.IdCtaCble,
                            IdCentroCosto = Dis.IdCentroCosto,
                            IdCentroCosto_sub_centro_costo = Dis.IdCentroCosto_sub_centro_costo,
                            IdRegistro = string.IsNullOrEmpty(Dis.IdCentroCosto) ? null : (Dis.IdCentroCosto + "-" + Dis.IdCentroCosto_sub_centro_costo),
                            dc_Valor = Convert.ToDouble(Math.Round((Cta.Valor / ValorTotalDistribucion) * Dis.F3, 2, MidpointRounding.AwayFromZero)),
                            dc_Valor_D = Convert.ToDouble(Math.Round((Cta.Valor / ValorTotalDistribucion) * Dis.F3, 2, MidpointRounding.AwayFromZero) > 0 ? Math.Round((Cta.Valor / ValorTotalDistribucion) * Dis.F3, 2, MidpointRounding.AwayFromZero) : 0),
                            dc_Valor_H = Convert.ToDouble(Math.Round((Cta.Valor / ValorTotalDistribucion) * Dis.F3, 2, MidpointRounding.AwayFromZero) < 0 ? Math.Abs(Math.Round((Cta.Valor / ValorTotalDistribucion) * Dis.F3, 2, MidpointRounding.AwayFromZero)) : 0),
                        });
                    }    
                }
                gcDiario.DataSource = null;
                gcDiario.DataSource = blstDiario;
                tabControl1.SelectedTab = tpDiario;    
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void gvDetalle_ShownEditor(object sender, EventArgs e)
        {
            ColumnView view = (ColumnView)sender;
            if (view.FocusedColumn.FieldName == "IdRegistro" && view.ActiveEditor is LookUpEdit)
            {
                LookUpEdit edit = (LookUpEdit)view.ActiveEditor;
                string IdCentroCosto = (string)view.GetFocusedRowCellValue("IdCentroCosto");
                if (!string.IsNullOrEmpty(IdCentroCosto))
                    edit.Properties.DataSource = lstSubCentro.Where(q => q.IdCentroCosto == IdCentroCosto).ToList();
                else
                    edit.Properties.DataSource = null;
            }
        }
        
        private void gvDetalle_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            ct_DistribucionDetDistribuido_Info row = (ct_DistribucionDetDistribuido_Info)gvDetalle.GetRow(e.RowHandle);
            if (row != null)
            {
                if (e.Column == colCuentaDis)
                {
                    row.F1 = 1;
                    row.F2 = 1;
                }                

                if (e.Column == colSCDet)
                {
                    string[] Array = row.IdRegistro.Split('-');
                    if (Array.Count() == 2)
                        row.IdCentroCosto_sub_centro_costo = Array[1];
                    else
                        row.IdCentroCosto_sub_centro_costo = null;    
                }

                row.F3 = row.F1 * row.F2;
            }
        }

        private void gvDetalleCuenta_ShownEditor(object sender, EventArgs e)
        {
            ColumnView view = (ColumnView)sender;
            if (view.FocusedColumn.FieldName == "IdRegistro" && view.ActiveEditor is LookUpEdit)
            {
                LookUpEdit edit = (LookUpEdit)view.ActiveEditor;
                string IdCentroCosto = (string)view.GetFocusedRowCellValue("IdCentroCosto");
                if (!string.IsNullOrEmpty(IdCentroCosto))
                    edit.Properties.DataSource = lstSubCentro.Where(q => q.IdCentroCosto == IdCentroCosto).ToList();
                else
                    edit.Properties.DataSource = null;
            }
        }

        private void gvDetalleCuenta_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            ct_DistribucionDetPorDistribuir_Info row = (ct_DistribucionDetPorDistribuir_Info)gvDetalleCuenta.GetRow(e.RowHandle);
            if (row == null)
                return;

            if (e.Column == CuentaColPlancta)
                row.Valor = Convert.ToDecimal(busPlancta.GetSaldoFechaCorte(param.IdEmpresa, row.IdCtaCble, deFechaIni.DateTime.Date,deFechaFin.DateTime.Date, row.IdCentroCosto, row.IdCentroCosto_sub_centro_costo, chkConsiderarCC.Checked));
            
            if(e.Column == CuentaColSC)
            {
                string[] Array = row.IdRegistro.Split('-');
                if (Array.Count() == 2)
                    row.IdCentroCosto_sub_centro_costo = Array[1];
                else
                    row.IdCentroCosto_sub_centro_costo = null;
            }
            gvDetalleCuenta.UpdateCurrentRow();
        }

        private void cmbImagen_Click(object sender, EventArgs e)
        {
            ct_DistribucionDetPorDistribuir_Info row = (ct_DistribucionDetPorDistribuir_Info)gvDetalleCuenta.GetFocusedRow();
            if (row == null)
                return;

            row.Valor = Convert.ToDecimal(busPlancta.GetSaldoFechaCorte(param.IdEmpresa, row.IdCtaCble, deFechaFin.DateTime.Date, row.IdCentroCosto, row.IdCentroCosto_sub_centro_costo, chkConsiderarCC.Checked));
            gvDetalleCuenta.UpdateCurrentRow();
        }

        private void gvDetalleCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gvDetalleCuenta.DeleteSelectedRows();
                }
            }
        }

        private void gvDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gvDetalle.DeleteSelectedRows();
                }
            }
        }

        private void gvDiario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gvDiario.DeleteSelectedRows();
                }
            }
        }

        private void ucMenu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void ucMenu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {

        }

        private void ucMenu_event_btnAnular_Click(object sender, EventArgs e)
        {

        }

        private bool AccionGuardar()
        {
            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    return Guardar();
                case Cl_Enumeradores.eTipo_action.actualizar:
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    break;
                case Cl_Enumeradores.eTipo_action.duplicar:
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado:
                    break;
                default:
                    break;
            }

            return false;
        }

        private void GetInfo()
        {
            txtIdDistribucion.Focus();

            info = new ct_Distribucion_Info
            {
                IdEmpresa = param.IdEmpresa,
                IdDistribucion = string.IsNullOrEmpty(txtIdDistribucion.Text) ? 0 : Convert.ToDecimal(txtIdDistribucion.Text),
                Fecha = deFechaFin.DateTime,
                Observacion = txtObservacion.Text,
                IdUsuario = param.IdUsuario,
                ListaDistribuido = new List<ct_DistribucionDetDistribuido_Info>(blstDet),
                ListaPorDistribuir = new List<ct_DistribucionDetPorDistribuir_Info>(blstPlanctaSaldo),
                ListaDiario = new List<ct_Cbtecble_det_Info>(blstDiario)
            };
        }

        private bool Guardar()
        {
            GetInfo();
            if (bus.GuardarDB(info))
            {
                MessageBox.Show("Registro guardado exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return true;
            }

            return true;
        }
    }
}
