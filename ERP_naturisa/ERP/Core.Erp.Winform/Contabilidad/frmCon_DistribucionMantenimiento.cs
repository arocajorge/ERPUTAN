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
        ct_Cbtecble_tipo_Bus busTipoCbte;
        cl_parametrosGenerales_Bus param;
        ct_Centro_costo_Bus busCentroCosto;
        ct_centro_costo_sub_centro_costo_Bus busSubcentro;
        List<ct_centro_costo_sub_centro_costo_Info> lstSubCentro;
        List<ct_Centro_costo_Info> lstCentroCosto;
        BindingList<ct_DistribucionDet_Info> blstDet;
        
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
            blstDet = new BindingList<ct_DistribucionDet_Info>();
            event_delegate_frmCon_DistribucionMantenimiento_FormClosed += frmCon_DistribucionMantenimiento_event_delegate_frmCon_DistribucionMantenimiento_FormClosed;
        }

        private void frmCon_DistribucionMantenimiento_Load(object sender, EventArgs e)
        {
            deFechaCorte.DateTime = DateTime.Now.Date;
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

                lstCentroCosto = busCentroCosto.Get_list_Centro_Costo(param.IdEmpresa);
                cmbCentroCosto.DataSource = lstCentroCosto;

                lstSubCentro = busSubcentro.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmbSubCentro.DataSource = lstSubCentro;
            }
            catch (Exception)
            {

            }
        }

        private void CargarCuentas()
        {
            try
            {
                var lst = busPlancta.GetListCuentasConSaldo(param.IdEmpresa, deFechaCorte.DateTime.Date);
                treeListMenu_x_Usuario_x_Empresa.DataSource = null;
                treeListMenu_x_Usuario_x_Empresa.DataSource = lst;
            }
            catch (Exception)
            {
                
                throw;
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

        private void btnCargarCuentas_Click(object sender, EventArgs e)
        {
            CargarCuentas();
        }

        private void btnDistribuir_Click(object sender, EventArgs e)
        {

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
    }
}
