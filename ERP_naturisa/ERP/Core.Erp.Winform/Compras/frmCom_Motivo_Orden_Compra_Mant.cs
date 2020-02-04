using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Compras
{
    public partial class frmCom_Motivo_Orden_Compra_Mant : Form
    {
        #region Declaración de Variables
        Cl_Enumeradores.eTipo_action Accion;
        string mensaje = "";
        public delegate void Delegate_frmCom_Motivo_Orden_Compra_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmCom_Motivo_Orden_Compra_Mant_FormClosing Event_frmCom_Motivo_Orden_Compra_Mant_FormClosing;
        private com_Motivo_Orden_Compra_Info _Info { get; set; }
        public List<com_Motivo_Orden_Compra_Info> _ListInfo_Moti_OC { get; set; }
        public com_Motivo_Orden_Compra_Bus Bus_Motivo_OC = new com_Motivo_Orden_Compra_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        #endregion
        
        public frmCom_Motivo_Orden_Compra_Mant()
        {
            InitializeComponent();
            
            this.ucSeg_Menu.event_btnGuardar_Click+=ucSeg_Menu_event_btnGuardar_Click;
            this.ucSeg_Menu.event_btnGuardar_y_Salir_Click+=ucSeg_Menu_event_btnGuardar_y_Salir_Click;
            this.ucSeg_Menu.event_btnlimpiar_Click+=ucSeg_Menu_event_btnlimpiar_Click;
            this.ucSeg_Menu.event_btnAnular_Click+=ucSeg_Menu_event_btnAnular_Click;
            this.ucSeg_Menu.event_btnSalir_Click+=ucSeg_Menu_event_btnSalir_Click;

            Event_frmCom_Motivo_Orden_Compra_Mant_FormClosing += frmCom_Motivo_Orden_Compra_Mant_Event_frmCom_Motivo_Orden_Compra_Mant_FormClosing;

        }

        void frmCom_Motivo_Orden_Compra_Mant_Event_frmCom_Motivo_Orden_Compra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void ucSeg_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        void ucSeg_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        void ucSeg_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Anular())
                    Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        void ucSeg_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {

            try
            {

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Guardar() == true)
                    {
                        this.Close();
                    }
                }

                if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (Modificar() == true)
                    {
                        this.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

        }

        void ucSeg_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Guardar();
                }

                if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    Modificar();
                }



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            
        }

        private Boolean Anular()
        {
            bool resultado = false;
            try
            {
                if (_Info.IdMotivo != 0)
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Motivo Compra #: " + _Info.IdMotivo + " ?", "Anulación de Motivo Compra ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        _Info.IdUsuarioUltAnu = param.IdUsuario;
                        _Info.FechaHoraAnul = DateTime.Now;
                        _Info.MotivoAnulacion = ofrm.motivoAnulacion;

                        if (_Info.estado == "A")
                        {
                            if (Bus_Motivo_OC.AnularDB(_Info, ref mensaje))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El Motivo", _Info.IdMotivo);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                lblAnulado.Visible = true;
                                Accion = Cl_Enumeradores.eTipo_action.consultar;
                                set_Accion(Accion);
                                resultado = true;
                            }
                            else
                            { MessageBox.Show(mensaje); resultado = false; }
                            return resultado;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo anular el Motivo Compra: " + _Info.IdMotivo + " debido a que ya se encuentra anulado", "Anulación de Motivo de OC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resultado = false;
                        }
                        return resultado;
                    }
                    return resultado;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un item a anular", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void set_Info(com_Motivo_Orden_Compra_Info Info_i)
        {
            try
            {
                _Info = Info_i;

                if (_Info == null)
                {
                    _Info = new com_Motivo_Orden_Compra_Info();
                }
                else
                {
                    txtid.Text = _Info.IdMotivo.ToString();
                    txtcodigo.Text = _Info.Cod_Motivo;
                    txtdescripcion.Text = _Info.Descripcion;
                    chkEstado.Checked = (_Info.estado == "A") ? true : false;
                    if (_Info.estado == "I")
                    {
                        lblAnulado.Visible = true;
                    }
                    else
                    {
                        lblAnulado.Visible = false;
                    }                   
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action  _Accion)
        {
            try
            {
                Accion = _Accion;

        
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        chkEstado.Checked = true;
                        
                        ucSeg_Menu.Visible_bntAnular = false;
                        ucSeg_Menu.Visible_bntImprimir = false;
                        ucSeg_Menu.Visible_bntLimpiar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        txtid.ReadOnly= false;
                        
                        ucSeg_Menu.Visible_bntAnular = false;
                        ucSeg_Menu.Visible_bntImprimir = false;
                        ucSeg_Menu.Visible_bntLimpiar = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        txtid.ReadOnly = false;

                        ucSeg_Menu.Visible_bntAnular = true;
                        ucSeg_Menu.Visible_bntImprimir = false;
                        ucSeg_Menu.Visible_bntLimpiar = false;
                        ucSeg_Menu.Visible_bntGuardar_y_Salir = false;
                        ucSeg_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        txtid.ReadOnly = false;
                        ucSeg_Menu.Visible_bntAnular = false;
                        ucSeg_Menu.Visible_bntImprimir = false;
                        ucSeg_Menu.Visible_bntLimpiar = false;
                        ucSeg_Menu.Visible_bntGuardar_y_Salir = false;
                        ucSeg_Menu.Visible_btnGuardar = false;
                        break;
                    default:
                        break;
                }



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public com_Motivo_Orden_Compra_Info get_Info()
        {
            try
            {
                _Info = new com_Motivo_Orden_Compra_Info();
               
                _Info.estado=(chkEstado.Checked == true) ? "A" : "I";
                if(txtid.Text!="")
                {
                _Info.IdMotivo =Convert.ToInt32(txtid.Text);
                }
                _Info.Cod_Motivo = txtcodigo.Text;
                _Info.Descripcion=txtdescripcion.Text;
                _Info.IdEmpresa = param.IdEmpresa;

                return _Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new com_Motivo_Orden_Compra_Info();
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                _Info = new com_Motivo_Orden_Compra_Info();
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_Accion(Accion);

                chkEstado.Checked = true;
                txtid.Text = "";
                txtcodigo.Text = "";
                txtdescripcion.Text = "";
               
               lblAnulado.Visible = false;
               chkEstado.Checked = true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Guardar()
        {
            try
            {
                Boolean res = true;
                int IdMotivo = 0;

                get_Info();


                res = Bus_Motivo_OC.GuardarDB(_Info,ref IdMotivo,ref mensaje);

                if (res)
                {


                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Motivo", _Info.IdMotivo);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    //Accion = Cl_Enumeradores.eTipo_action.consultar;
                    //set_Accion(Accion);
                    LimpiarDatos();
                }
                else
                { MessageBox.Show(mensaje); }

                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        private Boolean Modificar()
        {
            try
            {
                Boolean res = false;

                get_Info();

                res = Bus_Motivo_OC.ModificarDB(_Info, ref mensaje);

                if (res)
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Motivo", _Info.IdMotivo);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    Accion = Cl_Enumeradores.eTipo_action.grabar;
                    LimpiarDatos();
                }
                else
                { MessageBox.Show(mensaje); }


                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        private void frmCom_Motivo_Orden_Compra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmCom_Motivo_Orden_Compra_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmCom_Motivo_Orden_Compra_Mant_Load(object sender, EventArgs e)
        {

        }
    }
}