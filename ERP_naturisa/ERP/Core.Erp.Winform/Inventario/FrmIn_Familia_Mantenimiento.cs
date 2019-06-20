using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Inventario
{
    using Core.Erp.Info.Inventario;
    using Core.Erp.Business.Inventario;
    using Core.Erp.Info.General;
    using Core.Erp.Business.General;

    public partial class FrmIn_Familia_Mantenimiento : Form
    {
        #region Delegados
        public delegate void delegate_FrmIn_Familia_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Familia_Mantenimiento_FormClosing event_FrmIn_Familia_Mantenimiento_FormClosing;

        void FrmIn_Familia_Mantenimiento_event_FrmIn_Familia_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmIn_Familia_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmIn_Familia_Mantenimiento_FormClosing(sender, e);
        }
        #endregion

        #region Variables
        in_Familia_Bus bus_familia;
        in_Familia_Info info_familia;
        cl_parametrosGenerales_Bus param;
        Cl_Enumeradores.eTipo_action Accion;
        #endregion

        public FrmIn_Familia_Mantenimiento()
        {
            InitializeComponent();
            event_FrmIn_Familia_Mantenimiento_FormClosing += FrmIn_Familia_Mantenimiento_event_FrmIn_Familia_Mantenimiento_FormClosing;
            bus_familia = new in_Familia_Bus();
            info_familia = new in_Familia_Info();
            param = cl_parametrosGenerales_Bus.Instance;
            Accion = Cl_Enumeradores.eTipo_action.grabar;
        }

        public void SetAccion(Cl_Enumeradores.eTipo_action _Accion, in_Familia_Info _info)
        {
            info_familia = _info;
            Accion = _Accion;
        }

        private void FrmIn_Familia_Mantenimiento_Load(object sender, EventArgs e)
        {
            SetAccionInControls();
        }

        private void SetAccionInControls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        uc_menu.Visible_bntAnular = false;
                        uc_menu.Visible_btnGuardar = true;
                        uc_menu.Visible_bntGuardar_y_Salir = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        uc_menu.Visible_bntAnular = false;
                        uc_menu.Visible_btnGuardar = true;
                        uc_menu.Visible_bntGuardar_y_Salir = true;
                        SetInfoInControls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        uc_menu.Visible_bntAnular = true;
                        uc_menu.Visible_btnGuardar = false;
                        uc_menu.Visible_bntGuardar_y_Salir = false;
                        SetInfoInControls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        uc_menu.Visible_bntAnular = false;
                        uc_menu.Visible_btnGuardar = false;
                        uc_menu.Visible_bntGuardar_y_Salir = false;
                        SetInfoInControls();
                        break;                 
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void SetInfoInControls()
        {
            try
            {
                if (info_familia.IdFamilia != 0)
                {
                    txt_ID.Text = info_familia.IdFamilia.ToString();
                    txt_Codigo.Text = info_familia.fa_Codigo;
                    txt_Descripcion.Text = info_familia.fa_Descripcion;
                    lbl_Estado.Visible = !!info_familia.Estado;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetInfo()
        {
            try
            {
                info_familia = new in_Familia_Info
                {
                    IdEmpresa = param.IdEmpresa,
                    IdFamilia = string.IsNullOrEmpty(txt_ID.Text) ? 0 : Convert.ToInt32(txt_ID.Text),
                    fa_Codigo = txt_Codigo.Text,
                    fa_Descripcion = txt_Descripcion.Text
                };
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Limpiar()
        {
            txt_ID.Text = string.Empty;
            txt_Codigo.Text = string.Empty;
            txt_Descripcion.Text = string.Empty;
            lbl_Estado.Visible = false;
            Accion = Cl_Enumeradores.eTipo_action.grabar;
            info_familia = new in_Familia_Info();
            SetAccionInControls();
        }

        private bool Validar()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Descripcion.Text))
                {
                    MessageBox.Show("El campo descripción es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool AccionGrabar()
        {
            try
            {
                if (Accion != Cl_Enumeradores.eTipo_action.Anular && !Validar())
                    return false;

                GetInfo();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        return Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        return Modificar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        return Anular();
                        break;
                 }
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private bool Guardar()
        {
            try
            {
                if (bus_familia.GuardarDB(info_familia))
                {
                    MessageBox.Show("Registro creado exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private bool Modificar()
        {
            try
            {
                if (bus_familia.ModificarDB(info_familia))
                {
                    MessageBox.Show("Registro actualizado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool Anular()
        {
            try
            {
                if (bus_familia.AnularDB(info_familia))
                {
                    MessageBox.Show("Registro anulado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void uc_menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uc_menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void uc_menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
            {
                this.Close();
            }
        }

        private void uc_menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
            {
                Limpiar();
            }
        }

        private void uc_menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
            {
                this.Close();
            }
        }
    }
}
