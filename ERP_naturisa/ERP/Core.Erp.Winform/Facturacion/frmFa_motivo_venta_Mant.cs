using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_motivo_venta_Mant : Form
    {


        #region "Declaracion de Variables y Eventos"

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_motivo_venta_Info MotivoVenta_Info = new fa_motivo_venta_Info();
        fa_motivo_venta_Bus Bus_MotivoVenta = new fa_motivo_venta_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        string mensaje;

        #region "Eventos y Delegados"

        //el delegado para el evento FormClosing debe de llamarse de la misma forma de donde lo mandas a llamar con los mismo parametros solamente le aumentas la palabra delegate_
        //lo mandas a llamar desde las pantallas de consulta
        public delegate void delegate_motivo_venta_Consulta_FormClosing(object sender, FormClosingEventArgs e);
        //el evento debe de llamarse de la misma forma que el evento del Form de mantenimiento, solo que le aumentas la palabra event_
        public event delegate_motivo_venta_Consulta_FormClosing event_frmFa_motivo_venta_Mant_FormClosing;

        #endregion

        #endregion

        public frmFa_motivo_venta_Mant()
        {
            InitializeComponent();
            event_frmFa_motivo_venta_Mant_FormClosing += frmFa_motivo_venta_Mant_event_frmFa_motivo_venta_Mant_FormClosing;
        }

        void frmFa_motivo_venta_Mant_event_frmFa_motivo_venta_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #region "Set, Get y Cargar Datos"

        public void Set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public void Set_Motivo_Venta(fa_motivo_venta_Info Motivo)
        {
            try
            {
                MotivoVenta_Info = Motivo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public fa_motivo_venta_Info Get_Motivo_Venta(ref string mensaje)
        {
            try
            {
                fa_motivo_venta_Info Info = new fa_motivo_venta_Info();
                Info.IdEmpresa= param.IdEmpresa;
                Info.IdMotivo_Vta=Convert.ToInt32(txt_IdMotivo.Text);
                Info.codMotivo_Vta=txtCodigo.Text;
                Info.descripcion_motivo_vta=txtDescripcion.Text;
                Info.FechaCreacion=DateTime.Now;
                Info.UsuarioCreacion=param.IdUsuario;
                
                if(Accion==Cl_Enumeradores.eTipo_action.grabar)
                    chkEstado.Checked=true;

                Info.Estado=(chkEstado.Checked==true)? "A" : "I";

                if(chkEstado.Checked)
                    lbl_Estado.Visible=false;
                else
                    lbl_Estado.Visible=true;

                return Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        public void Cargar_Datos()
        {
            try
            {
                if (MotivoVenta_Info.IdMotivo_Vta != 0)
                {
                    txt_IdMotivo.Text = "0";
                    if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                        txt_IdMotivo.Text = MotivoVenta_Info.IdMotivo_Vta.ToString();

                    txtCodigo.Text = MotivoVenta_Info.codMotivo_Vta.ToString();
                    txtDescripcion.Text = MotivoVenta_Info.descripcion_motivo_vta.ToString();
                    chkEstado.Checked = (MotivoVenta_Info.Estado == "A") ? true : false;
                    if (chkEstado.Checked)
                        lbl_Estado.Visible = false;
                    else
                        lbl_Estado.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        #endregion

        #region "Funciones y Procesos"

        public void Limpiar()
        {
            try
            {
                txt_IdMotivo.Text = "0";
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        public Boolean Validar()
        {
            try
            {
                if (txtDescripcion.Text == "" || txtDescripcion.EditValue == null)
                {
                    MessageBox.Show("Por favor ingrese un motivo de venta", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Anular()
        {
            try
            {
                if (MotivoVenta_Info.Estado == "I")
                {
                    MessageBox.Show("El registro ya se encuentra anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Tipo de Rubro #:" + txt_IdMotivo.Text.Trim() + " ?", "Anulación de Mantenimiento Tipo Rubro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        fa_motivo_venta_Bus neg = new fa_motivo_venta_Bus();
                        fa_motivo_venta_Info moInfo = new fa_motivo_venta_Info();
                        string mensaje = string.Empty;

                        moInfo = Get_Motivo_Venta(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        moInfo.UsuarioAnulacion = param.IdUsuario;
                        moInfo.MotivoAnulacion = fr.motivoAnulacion;
                        bool resultado = neg.Anular(moInfo, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Guardar()
        {
            bool resultado = false;
            try
            {
                fa_motivo_venta_Info InfoMotivo = new fa_motivo_venta_Info();
                fa_motivo_venta_Bus BusMotivo = new fa_motivo_venta_Bus();
                mensaje="";
                int id = 0;

                InfoMotivo = Get_Motivo_Venta(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }
                
                if (BusMotivo.Get_List_fa_motivo_venta_Existe(InfoMotivo, ref mensaje))
                {
                    resultado = BusMotivo.Grabar(InfoMotivo, ref id, ref mensaje);
                    txt_IdMotivo.Text = id.ToString();
                }
                else
                    MessageBox.Show("el codigo ingresado: " + InfoMotivo.codMotivo_Vta.ToString() + " ya existe.\nPor favor ingrese un codigo diferente");

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, " Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                    this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return resultado;
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Modificar()
        {
            bool resultado = false;
            try
            {
                fa_motivo_venta_Info InfoMotivo = new fa_motivo_venta_Info();
                fa_motivo_venta_Bus BusMotivo = new fa_motivo_venta_Bus();
                mensaje = "";
                InfoMotivo=Get_Motivo_Venta(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }

                resultado = BusMotivo.Modificar(InfoMotivo, ref mensaje);

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                    this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return resultado;
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Guardar_Datos()
        {
            bool resultado = false;
            try
            {
                if (Validar())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            resultado = Guardar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            resultado = Modificar();
                            break;
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Anular())
                    MessageBox.Show("El registro se anuló satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro se no se anuló.Consulte con su departamento de Sistemas", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void frmFa_motivo_venta_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmFa_motivo_venta_Mant_FormClosing(sender, e);
        }

        private void frmFa_motivo_venta_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Datos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        txt_IdMotivo.Enabled = false;
                        chkEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        txt_IdMotivo.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        txt_IdMotivo.Enabled = false;
                        txtCodigo.Enabled = false;
                        txtDescripcion.Enabled = false;
                        chkEstado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        txt_IdMotivo.Enabled = false;
                        txtCodigo.Enabled = false;
                        txtDescripcion.Enabled = false;
                        chkEstado.Enabled = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }
    }
}
