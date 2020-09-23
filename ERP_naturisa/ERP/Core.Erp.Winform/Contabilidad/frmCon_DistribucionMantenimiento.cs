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

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_DistribucionMantenimiento : Form
    {
        #region Variables
        Cl_Enumeradores.eTipo_action Accion;
        ct_Plancta_Bus busPlancta;
        List<ct_Plancta_Info> ListaPlancta;
        ct_Distribucion_Info info;
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
            ListaPlancta = new List<ct_Plancta_Info>();
            info = new ct_Distribucion_Info();
            event_delegate_frmCon_DistribucionMantenimiento_FormClosed += frmCon_DistribucionMantenimiento_event_delegate_frmCon_DistribucionMantenimiento_FormClosed;
        }

        private void frmCon_DistribucionMantenimiento_Load(object sender, EventArgs e)
        {
            SetAccionInControls();
        }

        #region metodos
        public void SetAccion(Cl_Enumeradores.eTipo_action _Accion, ct_Distribucion_Info _info)
        {
            Accion = _Accion;
            info = _info;
        }

        private void SetAccionInControls()
        {
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
        #endregion
    }
}
