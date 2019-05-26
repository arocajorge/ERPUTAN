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
    using Core.Erp.Business.General;
    using Core.Erp.Info.General;
    using Core.Erp.Business.Compras;
    using Core.Erp.Info.Compras;
    using Core.Erp.Business.Contabilidad;

    public partial class frmCom_OrdenPedidoMantenimiento : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_OrdenPedido_Bus bus_orden;
        com_departamento_Bus bus_departamento;
        com_OrdenPedido_Info info_pedido;
        Cl_Enumeradores.eTipo_action Accion;
        com_solicitante_Bus bus_solicitante;
        com_OrdenPedidoDet_Bus bus_detalle;
        BindingList<com_OrdenPedidoDet_Info> blst_det;
        tb_Sucursal_Bus bus_sucursal;
        ct_punto_cargo_Bus bus_punto_cargo;
        #endregion

        #region Delegados
        public delegate void delegate_frmCom_OrdenPedidoMantenimiento_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmCom_OrdenPedidoMantenimiento_FormClosed event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosed;
        #endregion

        public frmCom_OrdenPedidoMantenimiento()
        {
            InitializeComponent();
            bus_orden = new com_OrdenPedido_Bus();
            bus_departamento = new com_departamento_Bus();
            bus_solicitante = new com_solicitante_Bus();
            bus_detalle = new com_OrdenPedidoDet_Bus();
            blst_det = new BindingList<com_OrdenPedidoDet_Info>();
            bus_sucursal = new tb_Sucursal_Bus();
            bus_punto_cargo = new ct_punto_cargo_Bus();
            event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosed += frmCom_OrdenPedidoMantenimiento_event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosed;
        }

        void frmCom_OrdenPedidoMantenimiento_event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void CargarCombos()
        {
            try
            {
                cmb_Departamento.Properties.DataSource = bus_departamento.Get_List_Departamento(param.IdEmpresa);
                var lstSucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetInfo(com_OrdenPedido_Info _info, Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                info_pedido = _info;
                Accion = _Accion;
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
                        lbl_IdOrdenPedido.Visible = false;
                        txt_IdOrdenPedido.Visible = false;
                        uc_menu.btnGuardar.Visible = true;
                        uc_menu.btnGuardar_y_Salir.Visible = true;
                        uc_menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        lbl_IdOrdenPedido.Visible = true;
                        txt_IdOrdenPedido.Visible = true;
                        uc_menu.btnGuardar.Visible = true;
                        uc_menu.btnGuardar_y_Salir.Visible = true;
                        uc_menu.Visible_bntAnular = false;
                        SetInfoInControls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        lbl_IdOrdenPedido.Visible = true;
                        txt_IdOrdenPedido.Visible = true;
                        uc_menu.btnGuardar.Visible = false;
                        uc_menu.btnGuardar_y_Salir.Visible = false;
                        uc_menu.Visible_bntAnular = true;
                        SetInfoInControls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        lbl_IdOrdenPedido.Visible = true;
                        txt_IdOrdenPedido.Visible = true;
                        uc_menu.btnGuardar.Visible = false;
                        uc_menu.btnGuardar_y_Salir.Visible = false;
                        uc_menu.Visible_bntAnular = false;
                        SetInfoInControls();
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        private void SetInfoInControls()
        {
            try
            {
                info_pedido = bus_orden.GetInfo(info_pedido.IdEmpresa, info_pedido.IdOrdenPedido);
                if (info_pedido != null)
                {
                    txt_IdOrdenPedido.Text = info_pedido.IdOrdenPedido.ToString();
                    txt_Observacion.Text = info_pedido.op_Observacion;
                    cmb_Departamento.EditValue = info_pedido.IdDepartamento;
                    de_Fecha.DateTime = info_pedido.op_Fecha.Date;
                    txt_codigo.Text = info_pedido.op_Codigo;
                    blst_det = new BindingList<com_OrdenPedidoDet_Info>(bus_detalle.GetList(info_pedido.IdEmpresa,info_pedido.IdOrdenPedido));
                    gc_detalle.DataSource = blst_det;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool validar()
        {
            try
            {
                if (param.IdSolicitante == 0)
                {
                    var solicitante = bus_solicitante.GetInfo(param.IdEmpresa, param.IdUsuario);
                    if (solicitante == null)
                    {
                        MessageBox.Show("No tiene un usuario solicitante configurado para el módulo de compras, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                        param.IdSolicitante = solicitante.IdSolicitante;
                }

                if (de_Fecha.EditValue == null)
                {
                    MessageBox.Show("El campo fecha es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_Departamento.EditValue == null)
                {
                    MessageBox.Show("El campo departamento es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void limpiar()
        {
            try
            {
                info_pedido = new com_OrdenPedido_Info();
                txt_IdOrdenPedido.Text = string.Empty;
                txt_Observacion.Text = string.Empty;
                cmb_Departamento.EditValue = null;
                de_Fecha.DateTime = DateTime.Now.Date;
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                txt_codigo.Text = string.Empty;
                blst_det = new BindingList<com_OrdenPedidoDet_Info>();
                gc_detalle.DataSource = blst_det;
                SetAccionInControls();
            }
            catch (Exception)
            {

            }
        }

        private void frmCom_OrdenPedidoMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                de_Fecha.DateTime = DateTime.Now.Date;
                gc_detalle.DataSource = blst_det;
                SetAccionInControls();
            }
            catch (Exception)
            {

            }
        }

        public void GetInfo()
        {
            try
            {
                info_pedido = new com_OrdenPedido_Info
                {
                    IdEmpresa = param.IdEmpresa,
                    IdOrdenPedido = Accion == Cl_Enumeradores.eTipo_action.grabar ? 0 : Convert.ToDecimal(txt_IdOrdenPedido.Text),
                    IdDepartamento = Convert.ToInt32(cmb_Departamento.EditValue),
                    IdSolicitante = param.IdSolicitante,
                    IdUsuarioCreacion = param.IdUsuario,
                    op_Codigo = txt_codigo.Text,
                    op_Fecha = de_Fecha.DateTime.Date,
                    op_Observacion = txt_Observacion.Text,
                    ListaDetalle = new List<com_OrdenPedidoDet_Info>(blst_det)
                };
            }
            catch (Exception)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCom_OrdenPedidoMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void uc_menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uc_menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void uc_menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
                this.Close();
        }

        private void uc_menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
                limpiar();
        }

        private void uc_menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
                this.Close();
        }

        private bool AccionGrabar()
        {
            try
            {
                if (Accion != Cl_Enumeradores.eTipo_action.Anular && !validar())
                {
                    return false;
                }
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
                return false;
            }
        }

        private bool Guardar()
        {
            try
            {
                if (bus_orden.GuardarDB(info_pedido))
                {
                    MessageBox.Show("Registro guardado exitósamente");
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool Modificar()
        {
            try
            {
                if (bus_orden.ModificarDB(info_pedido))
                {
                    MessageBox.Show("Registro modificado exitósamente");
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool Anular()
        {
            try
            {
                if (bus_orden.AnularDB(info_pedido))
                {
                    MessageBox.Show("Registro anulado exitósamente");
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
