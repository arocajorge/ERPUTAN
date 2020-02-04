using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform
{
    public partial class FrmFa_PuntoVta_mant : Form
    {
        #region Declaracion de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        fa_PuntoVta_Info Info_fa_PuntoVta = new fa_PuntoVta_Info();
        fa_PuntoVta_Bus Bus_Fa_PuntoVta = new fa_PuntoVta_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string msg = "";

        List<tb_Sucursal_Info> List_Sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus Bus_Sucursal = new tb_Sucursal_Bus();

        List<tb_Bodega_Info> lst_bodega = new List<tb_Bodega_Info>();
        tb_Bodega_Bus bus_bodega = new tb_Bodega_Bus();
        #endregion

        #region Delegados
        public delegate void delegate_FrmFa_PuntoVta_mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmFa_PuntoVta_mant_FormClosing event_delegate_FrmFa_PuntoVta_mant_FormClosing;
        #endregion

        public FrmFa_PuntoVta_mant()
        {
            InitializeComponent();
            event_delegate_FrmFa_PuntoVta_mant_FormClosing += FrmFa_PuntoVta_mant_event_delegate_FrmFa_PuntoVta_mant_FormClosing;
        }

        void FrmFa_PuntoVta_mant_event_delegate_FrmFa_PuntoVta_mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Get_Info()
        {
            try
            {
                Info_fa_PuntoVta.IdEmpresa = param.IdEmpresa;
                Info_fa_PuntoVta.cod_PuntoVta = txt_codigo.Text;
                Info_fa_PuntoVta.nom_PuntoVta = txt_nom_PuntoVta.Text;
                Info_fa_PuntoVta.IdSucursal = cmbSucursal.EditValue == null ? 0 : Convert.ToInt32(cmbSucursal.EditValue);
                Info_fa_PuntoVta.IdBodega = cmb_bodega.EditValue == null ? 0 : Convert.ToInt32(cmb_bodega.EditValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Info(fa_PuntoVta_Info info)
        {
            try
            {
                Info_fa_PuntoVta = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_Accion_in_controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        txtIdPuntoVta.ReadOnly = true;
                        txt_codigo.ReadOnly = false;
                        txt_nom_PuntoVta.ReadOnly = false;
                        cmbSucursal.Properties.ReadOnly = false;
                        cmbSucursal.EditValue = null;                        
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        txtIdPuntoVta.ReadOnly = true;
                        txt_codigo.ReadOnly = true;
                        txt_nom_PuntoVta.ReadOnly = true;
                        cmbSucursal.Properties.ReadOnly = true;                        
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        Set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        txtIdPuntoVta.ReadOnly = true;
                        txt_codigo.ReadOnly = true;
                        txt_nom_PuntoVta.ReadOnly = true;
                        cmbSucursal.Properties.ReadOnly = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;                        
                        Set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        txtIdPuntoVta.ReadOnly = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        cmbSucursal.Properties.ReadOnly = true;                        
                        Set_info_in_controls();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                List_Sucursal = Bus_Sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmbSucursal.Properties.DataSource = List_Sucursal;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_info_in_controls()
        {
            try
            {
                cmbSucursal.EditValue = Info_fa_PuntoVta.IdSucursal;
                cmb_bodega.EditValue = Info_fa_PuntoVta.IdBodega;
                txtIdPuntoVta.Text =Convert.ToString(Info_fa_PuntoVta.IdPuntoVta);
                txt_codigo.Text = Convert.ToString(Info_fa_PuntoVta.cod_PuntoVta);
                txt_nom_PuntoVta.Text = Info_fa_PuntoVta.nom_PuntoVta;
                lblEstado.Visible = !Info_fa_PuntoVta.estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool grabar()
        {
            try
            {
                if (!Validar())  return false;

                bool res = false;
                Get_Info();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res = GuardarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res = ModificarDB();
                        break;
                    default:
                        break;
                }
                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool GuardarDB()
        {
            try
            {
                if (Bus_Fa_PuntoVta.GrabarDB(Info_fa_PuntoVta, ref msg))
                {
                    MessageBox.Show(msg.ToString(),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(msg);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ModificarDB()
        {
            try
            {
                if (Bus_Fa_PuntoVta.ModificarDB(Info_fa_PuntoVta, ref msg))
                {
                    MessageBox.Show(msg.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show(msg);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool AnularDB()
        {
            try
            {
                if (Bus_Fa_PuntoVta.AnularDB(Info_fa_PuntoVta, ref msg))
                {
                    MessageBox.Show(msg.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                    return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Limpiar()
        {
            try
            {
                Info_fa_PuntoVta = new fa_PuntoVta_Info();
                Accion = Cl_Enumeradores.eTipo_action.grabar;

                Set_Accion_in_controls();

                txtIdPuntoVta.Text = "";
                cmbSucursal.EditValue = null;
                txt_codigo.Text = "";
                txt_nom_PuntoVta.Text = "";
                lblEstado.Visible = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            try
            {
                txtIdPuntoVta.Focus();
                if (txt_nom_PuntoVta.Text == "" )
                {
                    MessageBox.Show("Ingrese el nombre",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }
                if (txt_codigo.Text == "")
                {
                    MessageBox.Show("Ingrese el código del punto de venta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if(cmbSucursal.EditValue==null)
                {
                    MessageBox.Show("Seleccione la sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (cmb_bodega.EditValue == null)
                {
                    MessageBox.Show("Seleccione la bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (AnularDB())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmFa_PuntoVta_mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
                Set_Accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        private void FrmFa_PuntoVta_mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_delegate_FrmFa_PuntoVta_mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lst_bodega = new List<tb_Bodega_Info>();

                if (cmbSucursal.EditValue != null)
                    lst_bodega = bus_bodega.Get_List_Bodega(param.IdEmpresa,Convert.ToInt32(cmbSucursal.EditValue));

                cmb_bodega.Properties.DataSource = lst_bodega;
                cmb_bodega.EditValue = null;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
