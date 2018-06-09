using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Bodega : Form
    {
        #region DEclaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        private tb_Bodega_Info info;
        private int idBod = 0;
        //public int IdSurculsa { get; set; }
        public delegate void delegate_frmFA_Bodega_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFA_Bodega_FormClosing Event_frmFA_Bodega_FormClosing;
        in_Ing_Egr_Inven_estado_apro_Bus busAproEstado = new in_Ing_Egr_Inven_estado_apro_Bus();
        List<in_Ing_Egr_Inven_estado_apro_Info> lstInfoAproEstado = new List<in_Ing_Egr_Inven_estado_apro_Info>();

        #endregion

        public frmFa_Bodega()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            }
            catch ( Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDatos())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                AnularDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        Boolean GuardarDatos()
        {
            try
            {
                Boolean bolResult = false;
                string msg = "";
                get_Bodega();
                tb_Bodega_Bus bus_pvta = new tb_Bodega_Bus();
                if (ValidarDatos())
                {

                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (bus_pvta.GrabarDB(info, ref idBod, ref msg))
                            {
                                bolResult = true;
                                ucGe_Menu.Enabled_btnGuardar = false;
                                ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                MessageBox.Show("Bodega Guardada Exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:

                           if (bus_pvta.ModificarDB(info, ref msg))
                           {
                                bolResult = true;
                                ucGe_Menu.Enabled_btnGuardar = false;
                                ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                MessageBox.Show("Bodega Modificada Exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            break;
                        
                        default:
                            break;
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        Boolean AnularDatos()
        {
            try
            {
                string msg = "";
                get_Bodega();
                tb_Bodega_Bus bus_pvta = new tb_Bodega_Bus();
                if (ValidarDatos())
                {
                           if (bus_pvta.EliminarDB(info, ref msg))
                           {
                                ucGe_Menu.Enabled_bntAnular = false;
                                MessageBox.Show("Bodega Anulada Exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        Boolean ValidarDatos()
        {
            try
            {
                if (this.txt_bodega.Text == "")
                {
                    MessageBox.Show("Por favor ingrese el nombre de la Bodega", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_bodega.Focus();
                    return false;
                }

                if (Convert.ToInt32(txtPuntoEmi.EditValue) == 0 || txtPuntoEmi.EditValue == null)
                {
                    MessageBox.Show("Por favor ingrese el punto de emisión", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPuntoEmi.Focus();
                    return false;
                }

              

                if (this.chk_bodega.Checked == false && this.chk_manejaFacturacion.Checked == false)
                {
                    MessageBox.Show("Por favor escoja al menos una opción para " + "\n" + "determinar si es Bodega o Punto de Venta", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public void iniciar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.actualizar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Bodega(tb_Bodega_Info info_bodega)
        {
            try
            {
                CargarCombo();
                this.lbl_id_sucursal.Text = info_bodega.IdSucursal.ToString();
                this.lbl_id_bodega.Text = info_bodega.IdBodega.ToString();
                this.txt_bodega.Text = info_bodega.bo_Descripcion;
                this.chk_bodega.Checked = (info_bodega.bo_esBodega == "S") ? true : false;
                this.chk_manejaFacturacion.Checked = (info_bodega.bo_manejaFacturacion == "S") ? true : false;
                this.chk_estado.Checked = (info_bodega.Estado == true) ? true : false;
                this.txtPuntoEmi.EditValue = info_bodega.cod_punto_emision;
                ucCon_CentroCosto_ctas_Movi.set_item(info_bodega.IdCentroCosto);
                cmbEstadoAproba.EditValue = info_bodega.IdEstadoAproba_x_Ing_Egr_Inven;
                if (!chk_estado.Checked) 
                {
                    ucGe_Menu.Visible_btnGuardar = false;
                }
                info = info_bodega;

                cmb_ctacble_Inv.set_IdCtaCble(info_bodega.IdCtaCtble_Inve);

                cmb_ctacble_costo.set_IdCtaCble(info_bodega.IdCtaCtble_Costo);


                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public tb_Bodega_Info get_Bodega()
        {
            try
            {
                info = new tb_Bodega_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.bo_Descripcion = this.txt_bodega.Text;
                info.IdSucursal = Convert.ToInt32(lbl_id_sucursal.Text);
                info.IdBodega =  !String.IsNullOrEmpty(lbl_id_bodega.Text)? Convert.ToInt32(lbl_id_bodega.Text):0;
                info.bo_manejaFacturacion = (this.chk_manejaFacturacion.Checked == true) ? "S" : "N";
                info.bo_esBodega = (this.chk_bodega.Checked == true) ? "S" : "N";
                info.cod_punto_emision = Convert.ToString(this.txtPuntoEmi.EditValue);
                info.IdCentroCosto = ucCon_CentroCosto_ctas_Movi.get_item();

                info.Estado = (this.chk_estado.Checked == true) ? true : false;
                info.IdUsuario = param.IdUsuario;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_Transac = DateTime.Now;
                info.Fecha_UltMod = DateTime.Now;
                info.Fecha_UltAnu = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                info.IdEstadoAproba_x_Ing_Egr_Inven = (cmbEstadoAproba.EditValue == "") ? null : Convert.ToString(cmbEstadoAproba.EditValue);


                info.IdCtaCtble_Costo = cmb_ctacble_costo.get_CuentaInfo().IdCtaCble;
                info.IdCtaCtble_Inve = cmb_ctacble_Inv.get_CuentaInfo().IdCtaCble;

                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new tb_Bodega_Info();
            }
            
        }
      
        private void txt_serie1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_serie2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ultfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFA_PVenta_Load(object sender, EventArgs e)
        {
            try
            {
                
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        CargarCombo();
                        ucGe_Menu.Enabled_bntAnular  = false;
                        this.lbl_title_id_bodega.Visible = false;
                        this.lbl_id_bodega.Visible = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.lbl_title_id_bodega.Visible = true;
                        this.lbl_id_bodega.Visible = true;
                        this.chk_estado.Enabled = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        this.lbl_id_bodega.Visible = true;
                        this.txt_bodega.Enabled = false;
                        this.chk_estado.Enabled = false;
                        this.chk_manejaFacturacion.Enabled = false;
                        this.chk_bodega.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        this.txt_bodega.Enabled = false;
                        this.chk_estado.Enabled = false;
                        this.chk_manejaFacturacion.Enabled = false;
                        this.chk_bodega.Enabled = false;

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


        void CargarCombo()
        {
            try
            {
                lstInfoAproEstado = new List<in_Ing_Egr_Inven_estado_apro_Info>();
                lstInfoAproEstado = busAproEstado.Get_List_Ing_Egr_Inven_estado_apro();
                cmbEstadoAproba.Properties.DataSource = lstInfoAproEstado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFA_Bodega_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
             Event_frmFA_Bodega_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      

        private void txtPuntoEmi_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtPuntoEmi.Text.Length == 2)
                    txtPuntoEmi.EditValue = "0" + txtPuntoEmi.Text;
                
                if (txtPuntoEmi.Text.Length == 1)
                    txtPuntoEmi.EditValue = "00" + txtPuntoEmi.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
