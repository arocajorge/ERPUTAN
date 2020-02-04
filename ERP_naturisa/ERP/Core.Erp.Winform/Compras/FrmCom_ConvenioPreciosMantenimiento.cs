using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Compras
{
    using Core.Erp.Business.Compras;
    using Core.Erp.Business.General;
    using Core.Erp.Info.Compras;
    using Core.Erp.Info.General;
    using Core.Erp.Business.Inventario;
    using Core.Erp.Info.Inventario;
    using Core.Erp.Business.CuentasxPagar;
    using Core.Erp.Info.CuentasxPagar;
    public partial class FrmCom_ConvenioPreciosMantenimiento : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param;
        com_ConvenioPreciosPorProducto_Info info;
        com_ConvenioPreciosPorProducto_Bus bus_convenio;
        Cl_Enumeradores.eTipo_action Accion;
        cp_proveedor_Bus bus_prov;
        in_producto_Bus bus_prod;
        com_TerminoPago_Bus bus_termino;
        com_comprador_Bus bus_comp;
        in_UnidadMedida_Bus bus_unidad;
        List<in_Producto_Combo> lst_producto;
        #endregion

        #region Delegados
        public delegate void delegate_FrmCom_ConvenioPreciosMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCom_ConvenioPreciosMantenimiento_FormClosing event_delegate_FrmCom_ConvenioPreciosMantenimiento_FormClosing;
        void FrmCom_ConvenioPreciosMantenimiento_event_delegate_FrmCom_ConvenioPreciosMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmCom_ConvenioPreciosMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_delegate_FrmCom_ConvenioPreciosMantenimiento_FormClosing(sender, e);
        }
        #endregion

        public FrmCom_ConvenioPreciosMantenimiento()
        {
            param = cl_parametrosGenerales_Bus.Instance;
            info = new com_ConvenioPreciosPorProducto_Info();
            bus_convenio = new com_ConvenioPreciosPorProducto_Bus();
            bus_prov = new cp_proveedor_Bus();
            bus_prod = new in_producto_Bus();
            bus_termino = new com_TerminoPago_Bus();
            bus_comp = new com_comprador_Bus();
            bus_unidad = new in_UnidadMedida_Bus();
            InitializeComponent();
            event_delegate_FrmCom_ConvenioPreciosMantenimiento_FormClosing += FrmCom_ConvenioPreciosMantenimiento_event_delegate_FrmCom_ConvenioPreciosMantenimiento_FormClosing;
        }

        public void SetAccion(Cl_Enumeradores.eTipo_action _Accion, com_ConvenioPreciosPorProducto_Info _info)
        {
            Accion = _Accion;
            info = _info;
        }

        private void CargarCombos()
        {
            try
            {
                de_Fecha.DateTime = DateTime.Now.Date;
                lst_producto = bus_prod.GetListCombo(param.IdEmpresa);
                cmbProducto.Properties.DataSource = lst_producto;
                cmbUnidad.Properties.DataSource = bus_unidad.Get_list_UnidadMedida();
                cmbProveedor.Properties.DataSource = bus_prov.GetListCombo(param.IdEmpresa);
                cmbTermino.Properties.DataSource = bus_termino.Get_List_TerminoPago();
                cmbComprador.Properties.DataSource = bus_comp.Get_List_comprador(param.IdEmpresa);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SetAccionInControls()
        {
            try
            {
                CargarCombos();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        var comprador = bus_comp.GetInfo(param.IdEmpresa, param.IdUsuario);
                        if (comprador != null)
                        {
                            cmbComprador.EditValue = comprador.IdComprador;
                        }
                        cmbProducto.Properties.ReadOnly = false;
                        ucMenu.Visible_bntAnular = false;
                        ucMenu.Visible_bntGuardar_y_Salir = true;
                        ucMenu.Visible_btnGuardar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        cmbProducto.Properties.ReadOnly = true;
                        ucMenu.Visible_bntAnular = false;
                        ucMenu.Visible_bntGuardar_y_Salir = true;
                        ucMenu.Visible_btnGuardar = true;
                        SetInfoInControls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        cmbProducto.Properties.ReadOnly = true;
                        ucMenu.Visible_bntAnular = true;
                        ucMenu.Visible_bntGuardar_y_Salir = false;
                        ucMenu.Visible_btnGuardar = false;
                        SetInfoInControls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucMenu.Visible_bntAnular = false;
                        ucMenu.Visible_bntGuardar_y_Salir = false;
                        ucMenu.Visible_btnGuardar = false;
                        cmbProducto.Properties.ReadOnly = true;
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
                if (info != null)
                {
                    cmbProducto.EditValue = info.IdProducto;
                    cmbUnidad.EditValue = info.IdUnidadMedida;
                    cmbProveedor.EditValue = info.IdProveedor;
                    cmbTermino.EditValue = info.IdTerminoPago;
                    cmbComprador.EditValue = info.IdComprador;
                    txtPrecioUni.Text = info.PrecioUnitario.ToString();
                    txtPorDesc.Text = info.PorDescuento.ToString();
                    txtDescUni.Text = info.Descuento.ToString();
                    txtPrecioFinal.Text = info.PrecioFinal.ToString();
                    txtDiasEntrega.Text = info.TiempoEntrega.ToString();
                    de_Fecha.DateTime = info.FechaFin;
                    chkPaso2.Checked = info.SaltaPaso2;
                    chkPaso3.Checked = info.SaltaPaso3;
                    chkPaso4.Checked = info.SaltoPaso4;
                    chkPaso5.Checked = info.SaltoPaso5;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Limpiar()
        {
            try
            {
                cmbProducto.EditValue = null;
                cmbUnidad.EditValue = null;
                cmbProveedor.EditValue = null;
                cmbTermino.EditValue = null;
                cmbComprador.EditValue = null;
                txtPrecioUni.Text = "0";
                txtPorDesc.Text = "0";
                txtDescUni.Text = "0";
                txtPrecioFinal.Text = "0";
                txtDiasEntrega.Text = "0";
                de_Fecha.DateTime = DateTime.Now;
                chkPaso2.Checked = false;
                chkPaso3.Checked = false;
                chkPaso4.Checked = false;
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                info = new com_ConvenioPreciosPorProducto_Info();
                SetAccionInControls();
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
                info = new com_ConvenioPreciosPorProducto_Info
                {
                    IdEmpresa = param.IdEmpresa,
                    IdProducto = Convert.ToDecimal(cmbProducto.EditValue),
                    IdUnidadMedida = cmbUnidad.EditValue.ToString(),
                    IdProveedor = Convert.ToDecimal(cmbProveedor.EditValue),
                    IdTerminoPago = cmbTermino.EditValue.ToString(),
                    IdComprador = Convert.ToInt32(cmbComprador.EditValue),
                    FechaFin = de_Fecha.DateTime,
                    PrecioUnitario = Convert.ToDouble(string.IsNullOrEmpty(txtPrecioUni.Text) ? "0" : txtPrecioUni.Text),
                    PorDescuento = Convert.ToDouble(string.IsNullOrEmpty(txtPorDesc.Text) ? "0" : txtPorDesc.Text),
                    Descuento = Convert.ToDouble(string.IsNullOrEmpty(txtDescUni.Text) ? "0" : txtDescUni.Text),
                    PrecioFinal = Convert.ToDouble(string.IsNullOrEmpty(txtPrecioFinal.Text) ? "0" : txtPrecioFinal.Text),
                    TiempoEntrega = Convert.ToInt32(string.IsNullOrEmpty(txtDiasEntrega.Text) ? "0" : txtDiasEntrega.Text),
                    SaltaPaso2 = chkPaso2.Checked,
                    SaltaPaso3 = chkPaso3.Checked,
                    SaltoPaso4 = chkPaso4.Checked,
                    SaltoPaso5 = chkPaso5.Checked
                };
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FrmCom_ConvenioPreciosMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                SetAccionInControls();
            }
            catch (Exception)
            {
                
            }
        }

        private void ucMenu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ucMenu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validar()
        {
            try
            {
                if (cmbProducto.EditValue == null)
                {
                    MessageBox.Show("El campo producto es obligatorio",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbUnidad.EditValue == null)
                {
                    MessageBox.Show("El campo unidad de medida es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbProveedor.EditValue == null)
                {
                    MessageBox.Show("El campo proveedor es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbTermino.EditValue == null)
                {
                    MessageBox.Show("El campo término de pago es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbComprador.EditValue == null)
                {
                    MessageBox.Show("El campo comprador es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (de_Fecha.EditValue == null)
                {
                    MessageBox.Show("El campo válido hasta es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (chkPaso3.Checked && Convert.ToDouble(string.IsNullOrEmpty(txtPrecioUni.Text) ? "0" : txtPrecioUni.Text) == 0)
                {
                    MessageBox.Show("No se puede saltar el paso 3 (Cotización) sin tener precio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (!Validar())
                    return false;

                GetInfo();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        return GuardarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        return ModificarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        return AnularDB();
                        break;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool GuardarDB()
        {
            try
            {
                if (bus_convenio.GuardarDB(info))
                {
                    MessageBox.Show("Convenio guardado exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return true;
                } 
                return false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private bool ModificarDB()
        {
            try
            {
                if (bus_convenio.ModificarDB(info))
                {
                    MessageBox.Show("Convenio modificado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool AnularDB()
        {
            try
            {
                if (bus_convenio.EliminarDB(info))
                {
                    MessageBox.Show("Convenio anulado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ucMenu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
            {
                this.Limpiar();
            }
        }

        private void ucMenu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
            {
                this.Close();
            }
        }

        private void ucMenu_event_btnAnular_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
            {
                this.Close();
            }
        }

        private void txtPrecioUni_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular();
            }
            catch (Exception)
            {
                
            }
        }

        private void txtPorDesc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular();
            }
            catch (Exception)
            {

            }
        }

        private void Calcular()
        {
            try
            {
                double PrecioUnitario = Convert.ToDouble(string.IsNullOrEmpty(txtPrecioUni.Text) ? "0" : txtPrecioUni.Text);
                double PorcDescuento = Convert.ToDouble(string.IsNullOrEmpty(txtPorDesc.Text) ? "0" : txtPorDesc.Text);
                double Descuento = PrecioUnitario * (PorcDescuento / 100);
                double PrecioFinal = PrecioUnitario - Descuento;

                txtDescUni.Text = Descuento.ToString();
                txtPrecioFinal.Text = PrecioFinal.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void cmbProducto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.EditValue != null)
                {
                    in_Producto_Combo producto;
                    producto = lst_producto.Where(q => q.IdProducto == Convert.ToDecimal(cmbProducto.EditValue)).FirstOrDefault();
                    if (producto != null)
                        cmbUnidad.EditValue = producto.IdUnidadMedida;
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
