using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;




namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Devolucion_Inven_Mant : Form
    {

        public delegate void Delegate_FrmIn_Devolucion_Inven_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmIn_Devolucion_Inven_Mant_FormClosing event_FrmIn_Devolucion_Inven_Mant_FormClosing;


        #region declaraciones
            string msg = "";
            string mensaje = "";

            tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
            private Cl_Enumeradores.eTipo_action _Accion;

            in_devolucion_inven_Info infoDetDev = new in_devolucion_inven_Info();
            BindingList<in_devolucion_inven_det_Info> Lista_dev_detalle = new BindingList<in_devolucion_inven_det_Info>();
            in_devolucion_inven_Bus BusDevolucion = new in_devolucion_inven_Bus();
            in_devolucion_inven_det_Bus BusDevolucion_det = new in_devolucion_inven_det_Bus();

            in_movi_inve_detalle_Bus BusMovi_Inv = new in_movi_inve_detalle_Bus();
            in_Ing_Egr_Inven_Info info_ing_egr = new in_Ing_Egr_Inven_Info();
            in_Ing_Egr_Inven_Bus bus_ing_egr = new in_Ing_Egr_Inven_Bus();
        #endregion

        public FrmIn_Devolucion_Inven_Mant()
        {
            InitializeComponent();
            event_FrmIn_Devolucion_Inven_Mant_FormClosing += FrmIn_Devolucion_Inven_Mant_event_FrmIn_Devolucion_Inven_Mant_FormClosing;
        }

        void FrmIn_Devolucion_Inven_Mant_event_FrmIn_Devolucion_Inven_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmIn_Devolucion_Inven_Mant_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }

                cargar_combo();
                set_accion_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Devolucion_Inven_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmIn_Devolucion_Inven_Mant_FormClosing(sender, e);
        }
 
        private Boolean validar()
        {
            try
            {
                txtObservacion.Focus();
                if (ucIn_Sucursal_Bodega.get_sucursal().IdSucursal==0)
                {
                    MessageBox.Show("No ha escogido la sucursal" ,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    ucIn_Sucursal_Bodega.Focus();
                    return false;
                }               

                if (txtObservacion.Text=="")
                {
                    MessageBox.Show("Debe ingresar la observacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtObservacion.Focus();
                    return false;
                }
                int tamaño_lista = Lista_dev_detalle.Count();
                if (tamaño_lista==0)
                {
                    MessageBox.Show("Debe escoger un item en el detalle", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                int cont = Lista_dev_detalle.Where(q => q.Checked == true).Count();
                if (cont == 0)
                {
                    MessageBox.Show("Debe escoger al menos un item del detalle para devolver", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                foreach (var item in Lista_dev_detalle)
                {
                    if (item.Checked)
                    {
                        if (item.cantidad_a_devolver==0)
                        {
                            MessageBox.Show("La cantidad a devolver no puede ser 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;        
                        }
                        if (item.cantidad_devuelta+item.cantidad_a_devolver > item.cantidad_egresada)
                        {
                            MessageBox.Show("Esta intentando devolver mas productos que los egresados, favor corrija", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;        
                        }
                    }
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(dtpFecha.Value)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void set_info(in_devolucion_inven_Info _InfoDev)
        {
            try
            {
                infoDetDev = _InfoDev;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info_controls()
        {
            try
            {
                dtpFecha.Value=infoDetDev.Fecha;
                txtCodDev.Text=infoDetDev.cod_Dev_Inven;
                txtidDev.Text=infoDetDev.IdDev_Inven.ToString();
                txtObservacion.Text=infoDetDev.observacion;
                ucIn_Sucursal_Bodega.set_Idsucursal(infoDetDev.IdSucursal_movi_inven);                
                lblAnulado.Visible = (infoDetDev.estado=="I")?true:false;

                chkDevolver_toda_trans.Checked=infoDetDev.Devuelve_toda_tran;
                ucIn_TipoMoviInv_Cmb.set_TipoMoviInvInfo(infoDetDev.IdMovi_inven_tipo);
                txtIdMovi_Inv.Text=infoDetDev.IdNumMovi.ToString();
               
                Lista_dev_detalle= new BindingList<in_devolucion_inven_det_Info>(BusDevolucion_det.Get_List_in_devolucion_inven_det(infoDetDev.IdEmpresa,infoDetDev.IdDev_Inven));
                gridDevolucion_det.DataSource = Lista_dev_detalle;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }       
        
        void ucGe_Menu_Superior_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void anular()
        {
            try
            {

                if (infoDetDev != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (infoDetDev.estado == "A" )
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular la Devolucion  N#: " + infoDetDev.IdDev_Inven + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();

                            infoDetDev.observacion = "***ANULADO****" + infoDetDev.observacion;
                            infoDetDev.MotivoAnulacion = oFrm.motivoAnulacion;

                            infoDetDev.Fecha_UltAnu = param.Fecha_Transac;
                            infoDetDev.IdusuarioUltAnu = param.IdUsuario;

                            infoDetDev.observacion = "***ANULADO****" + infoDetDev.observacion;

                            if (BusDevolucion.AnularDB(infoDetDev, ref msg))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Devolución", infoDetDev.IdDev_Inven);
                                MessageBox.Show(smensaje, param.Nombre_sistema);                                
                                infoDetDev.estado = "I";


                                _Accion = Cl_Enumeradores.eTipo_action.consultar;
                                
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular, "");
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (infoDetDev.estado == "I")
                    {
                        MessageBox.Show("No se puede anular la devolucion de Compra N#: " + infoDetDev.IdDev_Inven +
                             ", ya se encuentra anulada", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    grabar();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_Superior_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    grabar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_Superior_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void ucGe_Menu_Superior_event_btnSalir_Click(object sender, EventArgs e)
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

        public void set_accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion=iAccion;
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion_controls()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.txtidDev.Enabled = false;
                        this.txtidDev.BackColor = System.Drawing.Color.White;
                        this.txtidDev.ForeColor = System.Drawing.Color.Black;
                        LimpiarDatos();
                        ucGe_Menu_Superior.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu_Superior.Visible_bntAnular = false;
                        ucGe_Menu_Superior.Visible_bntLimpiar = false;

                        this.txtidDev.Enabled = false;
                        this.txtidDev.BackColor = System.Drawing.Color.White;
                        this.txtidDev.ForeColor = System.Drawing.Color.Black;

                        this.ucIn_Sucursal_Bodega.Enabled = false;
                        this.ucIn_Sucursal_Bodega.BackColor = System.Drawing.Color.White;
                        this.ucIn_Sucursal_Bodega.ForeColor = System.Drawing.Color.Black;

                        gridView_devol_inven.OptionsBehavior.Editable = false;
                        this.btnImportar.Enabled = false;
                        btnImportar.Enabled = false;
                        btnBusquedaAvanza.Enabled = false;
                        ucIn_TipoMoviInv_Cmb.Enabled = false;
                        txtIdMovi_Inv.Enabled = false;
                        chkDevolver_toda_trans.Enabled = false;

                        set_info_controls();

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu_Superior.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior.Visible_btnGuardar = false;
                        ucGe_Menu_Superior.Visible_bntGuardar_y_Salir = false;

                        this.txtidDev.Enabled = false;
                        this.txtidDev.BackColor = System.Drawing.Color.White;
                        this.txtidDev.ForeColor = System.Drawing.Color.Black;

                        this.ucIn_Sucursal_Bodega.Enabled = false;
                        this.ucIn_Sucursal_Bodega.BackColor = System.Drawing.Color.White;
                        this.ucIn_Sucursal_Bodega.ForeColor = System.Drawing.Color.Black;

                        gridView_devol_inven.OptionsBehavior.Editable = false;
                        this.btnImportar.Enabled = false;
                        btnBusquedaAvanza.Enabled = false;
                        ucIn_TipoMoviInv_Cmb.Enabled = false;
                        chkDevolver_toda_trans.Enabled = false;

                        set_info_controls();

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior.Visible_btnGuardar = false;
                        ucGe_Menu_Superior.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior.Visible_bntAnular = false;


                        this.txtidDev.Enabled = false;
                        this.txtidDev.BackColor = System.Drawing.Color.White;
                        this.txtidDev.ForeColor = System.Drawing.Color.Black;

                        this.txtCodDev.Enabled = false;
                        this.txtCodDev.BackColor = System.Drawing.Color.White;
                        this.txtCodDev.ForeColor = System.Drawing.Color.Black;

                        
                        this.txtObservacion.Enabled = false;
                        this.txtObservacion.BackColor = System.Drawing.Color.White;
                        this.txtObservacion.ForeColor = System.Drawing.Color.Black;

                        this.ucIn_Sucursal_Bodega.Enabled = false;
                        this.ucIn_Sucursal_Bodega.BackColor = System.Drawing.Color.White;
                        this.ucIn_Sucursal_Bodega.ForeColor = System.Drawing.Color.Black;

                        gridView_devol_inven.OptionsBehavior.Editable = false;
                        btnImportar.Enabled = false;
                        btnBusquedaAvanza.Enabled = false;
                        ucIn_TipoMoviInv_Cmb.Enabled = false;
                        chkDevolver_toda_trans.Enabled = false;

                        set_info_controls();
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

        private void cargar_combo()
        {
            try
            {
                int IdSucursal = 0;
                int IdBodega = 0;
                IdSucursal = ucIn_Sucursal_Bodega.get_IdSucursal();
                IdBodega = ucIn_Sucursal_Bodega.get_IdBodega();

                ucIn_TipoMoviInv_Cmb.cargar_TipoMotivo(IdSucursal, IdBodega, "-", "N");

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarDatos()
        {
            try
            {
                txtidDev.Text = "0";
                txtCodDev.Text = "";
                txtObservacion.Text = "";
                dtpFecha.Value = DateTime.Now;
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Lista_dev_detalle = new BindingList<in_devolucion_inven_det_Info>();
                gridDevolucion_det.DataSource = Lista_dev_detalle;
                lblAnulado.Visible = false;
                chkDevolver_toda_trans.Checked = false;
                infoDetDev = new in_devolucion_inven_Info();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grabar()
        {
            try
            {
                txtCodDev.Focus();
                GetInfo();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Actualizar();
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

        void Guardar()
        {
            try
            {
                infoDetDev.Fecha_Transac= param.Fecha_Transac;
                decimal IdDev_compra = 0;



                if (BusDevolucion.GuardarDB(infoDetDev ,ref IdDev_compra , ref  mensaje))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Devolución", infoDetDev.IdDev_Inven);
                    MessageBox.Show(smensaje, param.Nombre_sistema);                   
                    txtidDev.Text= infoDetDev.ToString();
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, mensaje);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Actualizar()
        {
            try
            {
               infoDetDev.Fecha_UltMod = param.Fecha_Transac;
               infoDetDev.IdUsuarioUltModi = param.IdUsuario;


               if (BusDevolucion.ModificarDB(infoDetDev, ref  mensaje))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Devolución", infoDetDev.IdDev_Inven);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar, mensaje);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetInfo()
        {
            try
            {
                infoDetDev = new in_devolucion_inven_Info();


                infoDetDev.IdEmpresa = param.IdEmpresa;
                infoDetDev.IdSucursal_movi_inven = ucIn_Sucursal_Bodega.get_sucursal().IdSucursal;
                infoDetDev.Fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                infoDetDev.observacion = txtObservacion.Text;
                infoDetDev.IdDev_Inven = (txtidDev.Text == "") ? 0 : Convert.ToDecimal(txtidDev.Text);
                infoDetDev.estado = (lblAnulado.Visible == true) ? "I" : "A";
                infoDetDev.Fecha_UltMod = param.GetDateServer();
                infoDetDev.IdUsuarioUltModi = param.IdUsuario;

                infoDetDev.cod_Dev_Inven = txtCodDev.Text;
                infoDetDev.Devuelve_toda_tran = chkDevolver_toda_trans.Checked;
                infoDetDev.IdMovi_inven_tipo = ucIn_TipoMoviInv_Cmb.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                infoDetDev.IdNumMovi = Convert.ToDecimal(txtIdMovi_Inv.Text);
                infoDetDev.IdUsuario = param.IdUsuario;

                infoDetDev.lista_detalle = new List<in_devolucion_inven_det_Info>(Lista_dev_detalle.Where(q=>q.Checked==true).ToList());


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_Movi_Inven( in_Ing_Egr_Inven_Info info_ing_egr)
        {
            try
            {
                if (info_ing_egr != null)
                {
                    txtObservacion.Text = "";
                    txtObservacion.Text =  "Dev/Inventario x Trans#" + info_ing_egr.IdNumMovi + " " + info_ing_egr.cm_observacion;
                    ucIn_Sucursal_Bodega.set_Idsucursal(info_ing_egr.IdSucursal);
                    ucIn_Sucursal_Bodega.set_Idbodega(info_ing_egr.IdSucursal, Convert.ToInt32(info_ing_egr.IdBodega));
                    dtpFecha.Value = DateTime.Now;
                    txtIdMovi_Inv.Text = infoDetDev.IdNumMovi.ToString();
                    Lista_dev_detalle = new BindingList<in_devolucion_inven_det_Info>();
                    txtIdMovi_Inv.Text = info_ing_egr.IdNumMovi.ToString();
                    ucIn_TipoMoviInv_Cmb.set_TipoMoviInvInfo(info_ing_egr.IdMovi_inven_tipo);

                    int c = 1;

                    foreach (var item in info_ing_egr.listMovi_inven_det)
                    {

                        in_devolucion_inven_det_Info ItemDv = new in_devolucion_inven_det_Info();

                        ItemDv.IdBodega_movi_inv = item.IdBodega;
                        ItemDv.IdDev_Inven = 0;
                        ItemDv.IdEmpresa = item.IdEmpresa;
                        ItemDv.IdEmpresa_movi_inv = item.IdEmpresa;
                        ItemDv.IdMovi_inven_tipo_movi_inv = item.IdMovi_inven_tipo;
                        ItemDv.IdNumMovi_movi_inv = item.IdNumMovi;
                        ItemDv.IdSucursal_movi_inv = item.IdSucursal;
                        ItemDv.Secuencia_movi_inv = item.Secuencia;
                        ItemDv.nom_punto_cargo = item.nom_punto_cargo;
                        c++;
                        ItemDv.secuencia = c;
                        
                        ItemDv.cantidad_egresada = item.dm_cantidad * - 1;
                        ItemDv.cantidad_devuelta = BusDevolucion_det.Get_cantidad_devuelta(item.IdEmpresa, item.IdBodega, item.IdSucursal, item.IdMovi_inven_tipo, item.IdNumMovi, item.Secuencia);
                        ItemDv.cantidad_a_devolver = 0;

                        ItemDv.nom_producto = item.nom_producto;
                        ItemDv.cod_producto = item.cod_producto;
                        ItemDv.Info_movi_inven_det = item;
                        ItemDv.Checked = false;
                        if (ItemDv.cantidad_devuelta < Math.Abs(ItemDv.cantidad_egresada))
                        {
                            Lista_dev_detalle.Add(ItemDv);    
                        }
                        
                    }

                    gridDevolucion_det.DataSource = Lista_dev_detalle;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnBusquedaAvanza_Click(object sender, EventArgs e)
        {

            try
            {
                if (ucIn_Sucursal_Bodega.get_sucursal() == null)
                {
                    MessageBox.Show("Debe escoger la sucursal", param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (ucIn_Sucursal_Bodega.get_bodega() == null)
                {
                    MessageBox.Show("Debe escoger la bodega", param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int IdSucursal = ucIn_Sucursal_Bodega.get_sucursal().IdSucursal;
                int IdBodega = ucIn_Sucursal_Bodega.get_bodega().IdBodega;

                FrmIn_Consulta_Mov_Inven frm = new FrmIn_Consulta_Mov_Inven();

                if (info_ing_egr != null)
                {
                    frm.ShowDialog();
                    info_ing_egr = frm.Get_Info_Movi_Inv();

                    info_ing_egr.listMovi_inven_det = BusMovi_Inv.Get_list_Movi_inven_det_x_ing_egr(info_ing_egr.IdEmpresa, info_ing_egr.IdSucursal,
                        info_ing_egr.IdMovi_inven_tipo, info_ing_egr.IdNumMovi);

                    Cargar_Movi_Inven(info_ing_egr);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkDevolver_toda_trans_CheckedChanged(object sender, EventArgs e)
        {

            try
            {

                if (chkDevolver_toda_trans.Checked == true)
                {

                    foreach (var item in Lista_dev_detalle)
                    {
                        item.cantidad_a_devolver = item.cantidad_egresada;
                    }

                }
                else
                {

                    foreach (var item in Lista_dev_detalle)
                    {
                        item.cantidad_a_devolver = 0;

                    }
                }
                gridDevolucion_det.DataSource = null;
                gridDevolucion_det.DataSource = Lista_dev_detalle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {


                if (ucIn_Sucursal_Bodega.get_sucursal() == null)
                {
                    MessageBox.Show("Debe escoger la sucursal", param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                /*
                if (ucIn_Sucursal_Bodega.get_bodega() == null)
                {
                    MessageBox.Show("Debe escoger la bodega", param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }*/

                int IdSucursal = ucIn_Sucursal_Bodega.get_sucursal().IdSucursal;
                //int IdBodega = ucIn_Sucursal_Bodega.get_bodega().IdBodega;
                int IdMovi_inven_tipo = 0;
                decimal IdNumMovi = 0;

                if (txtIdMovi_Inv.Text == "" || txtIdMovi_Inv.Text =="0")
                {
                    MessageBox.Show("Debe Ingresar el numero de Transaccion de Inventario .." , param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

                IdMovi_inven_tipo = ucIn_TipoMoviInv_Cmb.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                IdNumMovi = Convert.ToDecimal(txtIdMovi_Inv.Text);
                info_ing_egr = bus_ing_egr.Get_Info_Ing_Egr_Inven(param.IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi);
                info_ing_egr.listMovi_inven_det = BusMovi_Inv.Get_list_Movi_inven_det_x_ing_egr(param.IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi);
                if (info_ing_egr.listMovi_inven_det.Count != 0)
                {
                    Cargar_Movi_Inven(info_ing_egr);
                }
                else
                {
                    MessageBox.Show("No Existe Datos para esta Transaccion", param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridView_devol_inven_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                in_devolucion_inven_det_Info row = new in_devolucion_inven_det_Info();
                row = (in_devolucion_inven_det_Info)gridView_devol_inven.GetRow(e.RowHandle);
                if (row!=null)
                {
                    if (e.Column == ColCant_a_devol)
                    {
                        if (row.cantidad_a_devolver > 0)
                            row.Checked = true;
                        else
                            row.Checked = false;
                    }
                    if (e.Column == ColCheck)
                    {
                        if (row.Checked)
                        {
                            row.cantidad_a_devolver = Math.Abs(row.cantidad_egresada) - row.cantidad_devuelta;
                        }
                        else
                            row.cantidad_a_devolver = 0;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void gridView_devol_inven_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == ColCant_a_devol)
                {
                    if (e.Value != "")
                    {
                        gridView_devol_inven.SetRowCellValue(e.RowHandle, ColCant_a_devol, e.Value);    
                    }                    
                }
                if (e.Column == ColCheck)
                {
                    gridView_devol_inven.SetRowCellValue(e.RowHandle, ColCheck, e.Value);    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
