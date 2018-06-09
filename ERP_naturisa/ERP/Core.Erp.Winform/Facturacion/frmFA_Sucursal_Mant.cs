using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Sucursal_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public List<tb_Bodega_Info> lista_bodegas = new List<tb_Bodega_Info>();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        private tb_Sucursal_Info info;
        tb_Sucursal_Bus bus = new tb_Sucursal_Bus();
        private tb_Bodega_Info info_bod;
        public delegate void delegate_frmFA_Sucursal_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFA_Sucursal_Mant_FormClosing event_frmFA_Sucursal_Mant_FormClosing;

        #endregion

        public frmFa_Sucursal_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                event_frmFA_Sucursal_Mant_FormClosing += new delegate_frmFA_Sucursal_Mant_FormClosing(frmFA_Sucursal_Mant_event_frmFA_Sucursal_Mant_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    Anular();
                    this.Close();
                    this.Dispose();
                }
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


        Boolean GuardarDatos()
        {
            try
            {
                Boolean bolResult = true;
                tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();
                string msg = "";
                int id = 0;

                if (validarDatos())
                {
                    get_Sucursal();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:

                            //if (bus_sucursal.ValidarCodigoExiste(param.IdEmpresa, info.Su_Ruc, info.Su_CodigoEstablecimiento) != false)
                            //{
                                if (bus_sucursal.GrabarDB(info, ref id, ref msg))
                                {
                                    this.lbl_id_sucursal.Text = id.ToString();
                                    //this.lbl_title_id_sucursal.Visible = true;
                                    //this.lbl_id_sucursal.Visible = true;
                                    
                                    MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                    //ucGe_Menu.Visible_btnGuardar = false;
                                    LimpiarDatos();
                                    bolResult = true;
                                }
                                else
                                {
                                    this.lbl_title_id_sucursal.Visible = false;
                                    this.lbl_id_sucursal.Visible = false;
                                    bolResult = false;
                                    MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                this.txt_vendedor.Enabled = true;
                                this.chk_estado.Enabled = true;
                            //}
                            //else
                            //{
                            //    MessageBox.Show("El codigo Ingresado Ya existe \nPor favor ingrese uno diferente");
                            //    bolResult = false;
                            //}
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:

                            if (bus_sucursal.ModificarDB(info, ref msg))
                            {
                                MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Visible_btnGuardar = false;
                                LimpiarDatos();
                                bolResult = true;
                            }
                            else
                            {
                                bolResult = false;
                                MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            this.txt_vendedor.Enabled = false;
                            this.chk_estado.Enabled = false;

                            break;
                    }
                }

                else
                {

                    bolResult = false;
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



        public Boolean validarDatos()
        {
            try
            {
                if (txtCodSucursal.Text == null || txtCodSucursal.Text == "")
                {
                    MessageBox.Show("Ingrese el Código de la Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txt_vendedor.Text == null || txt_vendedor.Text == "")
                {
                    MessageBox.Show("Ingrese la Sucursal",param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txtRuc.Text == null || txtRuc.Text == "")
                {
                    MessageBox.Show("Ingrese el Ruc", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txtJefeSucursal.Text == null || txtJefeSucursal.Text == "")
                {
                    MessageBox.Show("Ingrese el Jefe de Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txtDireccion.Text == null || txtDireccion.Text == "")
                {
                    MessageBox.Show("Ingrese la Direccion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txtUbicacion.Text == null || txtUbicacion.Text == "")
                {
                    MessageBox.Show("Ingrese la Ubicacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txtEstablecimiento.Text == null || txtEstablecimiento.Text == "")
                {
                    MessageBox.Show("Ingrese el Establecimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        void frmFA_Sucursal_Mant_event_frmFA_Sucursal_Mant_FormClosing(object sender, FormClosingEventArgs e) {}

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

        public void set_Sucursal(tb_Sucursal_Info info_sucursal)
        {
            try
            {
                info = new tb_Sucursal_Info();
                this.txt_vendedor.Text = info_sucursal.Su_Descripcion;
                this.lbl_id_sucursal.Text = info_sucursal.IdSucursal.ToString();
                chk_estado.Checked = info_sucursal.Estado;
                if (!chk_estado.Checked) 
                {
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                }
                chk_es_Establecimiento.Checked = info_sucursal.Es_establecimiento == null ? false : Convert.ToBoolean(info_sucursal.Es_establecimiento);
                txtCodSucursal.Text = info_sucursal.codigo;
                txtUbicacion.Text = info_sucursal.Su_Ubicacion;
                txtRuc.Text = info_sucursal.Su_Ruc;
                txtJefeSucursal.Text = info_sucursal.Su_JefeSucursal;
                txtTelefono.Text = info_sucursal.Su_Telefonos;
                txtDireccion.Text = info_sucursal.Su_Direccion;
                txtEstablecimiento.Text = info_sucursal.Su_CodigoEstablecimiento;
                
                info = info_sucursal;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public tb_Sucursal_Info get_Sucursal()
        {
            try
            {
                info = new tb_Sucursal_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.IdUsuario = param.IdUsuario;
                info.Fecha_Transac = DateTime.Now;
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_UltAnu = DateTime.Now;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.Fecha_UltMod = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                info.IdSucursal = (this.lbl_id_sucursal.Text != "") ? Convert.ToInt32(this.lbl_id_sucursal.Text) : 0;
                info.Su_Descripcion = this.txt_vendedor.Text;
                info.Es_establecimiento = chk_es_Establecimiento.Checked;
                info.codigo  = txtCodSucursal.Text;
                info.Su_Ubicacion=txtUbicacion.Text;
                info.Su_Ruc= txtRuc.Text;
                info.Su_JefeSucursal= txtJefeSucursal.Text;
                info.Su_Telefonos= txtTelefono.Text;
                info.Su_Direccion = txtDireccion.Text;
                info.Su_CodigoEstablecimiento = txtEstablecimiento.Text;

                info.Estado = this.chk_estado.Checked;
                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new tb_Sucursal_Info();
            }
        }

        public void load_PVenta(int id)
        {
            try
            {
                tb_Bodega_Bus bus_pvta = new tb_Bodega_Bus();
                
                lista_bodegas = bus_pvta.Get_List_Bodega(param.IdEmpresa, id); ;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void frmFA_Sucursal_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        chk_estado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        txtCodSucursal.Enabled = false;
                        this.chk_estado.Enabled = true;
                        this.lbl_title_id_sucursal.Visible = true;
                        this.lbl_id_sucursal.Visible = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        this.lbl_title_id_sucursal.Visible = true;
                        this.txt_vendedor.Enabled = false;
                        this.lbl_id_sucursal.Visible = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.lbl_title_id_sucursal.Visible = true;
                        this.lbl_id_sucursal.Visible = true;
                        //this.btn_nuevo_pvta.Enabled = false;
                        this.txt_vendedor.Enabled = false;
                        break;
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
            try
            {
                Boolean resultB = false;
                string mensaje = "";

                if (MessageBox.Show("¿Está seguro que desea anular la Sucursal ?", "Anulación de Sucursal  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    info.IdUsuarioUltAnu = param.IdUsuario;
                    info.Fecha_UltMod = DateTime.Now;
                    info.MotiAnula = ofrm.motivoAnulacion;

                    if (bus.EliminarDB(info, ref mensaje))
                    {
                        MessageBox.Show("Sucursal # " + info.IdSucursal + " ANULADA SATISFACTORIAMENTE", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultB = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al ANULAR DEPARTAMENTO verifique con sistemas ...: " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resultB = false;
                    }
                }
                return resultB;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Punto_Venta(int id_pvta, string pvta, Boolean estado, string cod_punto_emision, string vta, string bod, Cl_Enumeradores.eTipo_action accion)
        {
            try
            {
                frmFa_Bodega frm = new frmFa_Bodega();
                frm.set_Accion(accion);
                tb_Bodega_Info info_pvta = new tb_Bodega_Info();
                info_pvta.IdEmpresa = param.IdEmpresa;
                info_pvta.IdSucursal = Convert.ToInt32(this.lbl_id_sucursal.Text);
                info_pvta.IdBodega = (id_pvta != 0) ? id_pvta : 0;
                info_pvta.bo_Descripcion = (pvta != "") ? pvta : "";
                info_pvta.cod_punto_emision = cod_punto_emision;
                info_pvta.bo_manejaFacturacion = vta;
                info_pvta.bo_esBodega = bod;
                info_pvta.Estado = estado;
                info_pvta.ip = info.ip;
                info_pvta.nom_pc = info.nom_pc;
                info_pvta.IdUsuario = info.IdUsuario;
                info_pvta.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                info_pvta.IdUsuarioUltMod = info.IdUsuarioUltMod;
                info_pvta.Fecha_Transac = info.Fecha_Transac;
                info_pvta.Fecha_UltAnu = info.Fecha_UltAnu;
                info_pvta.Fecha_UltMod = info.Fecha_UltMod;
                frm.set_Bodega(info_pvta);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_nuevo_pvta_Click(object sender, EventArgs e)
        {
            try
            {
                Punto_Venta(0, "", true, "", "", "", Cl_Enumeradores.eTipo_action.grabar);
                load_PVenta(Convert.ToInt32(this.lbl_id_sucursal.Text));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgPVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void frmFA_Sucursal_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
             event_frmFA_Sucursal_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtEstablecimiento_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtEstablecimiento.Text.Length == 2)
                    txtEstablecimiento.EditValue = "0" + txtEstablecimiento.Text;

                if (txtEstablecimiento.Text.Length == 1)
                    txtEstablecimiento.EditValue = "00" + txtEstablecimiento.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void LimpiarDatos()
        {
            try
            {
                info = new tb_Sucursal_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                this.lbl_id_sucursal.Text = "";
                this.txt_vendedor.Text = "";
                txtCodSucursal.Text = "";
                txtUbicacion.Text = "";
                txtRuc.Text = "";
                txtJefeSucursal.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";
                txtEstablecimiento.Text = "";

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
    }
}
