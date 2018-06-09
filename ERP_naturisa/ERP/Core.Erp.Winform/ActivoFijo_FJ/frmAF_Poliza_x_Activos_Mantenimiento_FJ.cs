using Core.Erp.Business.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Info.ActivoFijo;
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
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Business.ActivoFijo_FJ;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Winform.General;
namespace Core.Erp.Winform.ActivoFijo_FJ
{
    public partial class frmAF_Poliza_x_Activos_Mantenimiento_FJ : Form
    {
        #region Variables
        // listas
        Af_Activo_fijo_Info info_Activo = new Af_Activo_fijo_Info();
        List<Af_Activo_fijo_Info> list_Activos = new List<Af_Activo_fijo_Info>();
        BindingList<Af_Poliza_x_AF_det_Info> list_Detalle_x_Activo_info = new BindingList<Af_Poliza_x_AF_det_Info>();
        BindingList<Af_Poliza_x_AF_det_cuota_Info> list_Detalle_x_Cuota_info = new BindingList<Af_Poliza_x_AF_det_cuota_Info>();
        List<fa_catalogo_Info> list_catalogo_facturacion = new List<fa_catalogo_Info>();
        List<cp_catalogo_Info> lista_catalogo_CxP = new List<cp_catalogo_Info>();
        // bus
        Af_Activo_fijo_Bus bus_Activos = new Af_Activo_fijo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Af_Poliza_x_AF_Bus Poliza_Bus = new Af_Poliza_x_AF_Bus();
        fa_catalogo_Bus Catalogo_Facturacion_Bus = new fa_catalogo_Bus();
        cp_catalogo_Bus catalogo_CxP_bus = new cp_catalogo_Bus();
        Af_Poliza_x_AF_det_Bus detalle_Activo_bus = new Af_Poliza_x_AF_det_Bus();
        Af_Poliza_x_AF_det_cuota_Bus detalle_cuota_bus = new Af_Poliza_x_AF_det_cuota_Bus();
        // info
        Af_Poliza_x_AF_Info poliza_info = new Af_Poliza_x_AF_Info();


        // general
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;

        double Subtotal_0 = 0;
        double Subtotal_12 = 0;
        Boolean check_ = false;
        #endregion

        #region Delegados
        public delegate void delegate_frmAF_Poliza_x_Activos_Mantenimiento_FJ_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmAF_Poliza_x_Activos_Mantenimiento_FJ_FormClosing event_delegate_frmAF_Poliza_x_Activos_Mantenimiento_FJ_FormClosing;
        #endregion

        public frmAF_Poliza_x_Activos_Mantenimiento_FJ()
        {
            InitializeComponent();
            event_delegate_frmAF_Poliza_x_Activos_Mantenimiento_FJ_FormClosing += frmAF_Poliza_x_Activos_Mantenimiento_FJ_event_delegate_frmAF_Poliza_x_Activos_Mantenimiento_FJ_FormClosing;
        }

        void frmAF_Poliza_x_Activos_Mantenimiento_FJ_event_delegate_frmAF_Poliza_x_Activos_Mantenimiento_FJ_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public void Set_Info( Af_Poliza_x_AF_Info info_)
        {
            try
            {
                poliza_info = info_;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Set_Poliza()
        {
            try
            {
                deFechaPrimerCuota.EditValue = poliza_info.fecha_1era_cuota;
                txtPorcIva.EditValue = poliza_info.porc_iva.ToString();
                txt_base12.EditValue = poliza_info.subtotal.ToString();
                txtTotal.EditValue = poliza_info.Total.ToString();
                deHasta.EditValue = poliza_info.fecha_vigencia_hasta;
                deDesde.EditValue = poliza_info.fecha_vigencia_desde;
                txt_num_cuotas.Text = poliza_info.num_cuotas.ToString();
                txtobservacion.Text = poliza_info.observacion;
                da_fecha.EditValue = poliza_info.fecha;
                txt_valorCuota.EditValue = poliza_info.valor_cuota.ToString();
                txtIdPoliza.Text = poliza_info.IdPoliza.ToString();
                txtIva.EditValue = poliza_info.iva.ToString();
                txtCodigo.EditValue = poliza_info.cod_poliza;
                cmb_proveedor.set_ProveedorInfo(poliza_info.IdProveedor);
                txt_pago_contado.Text = poliza_info.pago_contado.ToString();
                if(poliza_info.subtotal_noIva!=null)
                txt_base0.Text = poliza_info.subtotal_noIva.ToString();
                txtobservacion.Text = poliza_info.observacion;
                list_Detalle_x_Cuota_info = new BindingList<Af_Poliza_x_AF_det_cuota_Info>( detalle_cuota_bus.Get_List_Poliza_Detalle_Cuota(poliza_info.IdEmpresa, Convert.ToInt32(poliza_info.IdPoliza)));
                list_Detalle_x_Activo_info =new BindingList<Af_Poliza_x_AF_det_Info>( detalle_Activo_bus.Get_List_Poliza_Detalle_Cuota(poliza_info.IdEmpresa, Convert.ToInt32(poliza_info.IdPoliza)));
                ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo(poliza_info.IdCentroCosto);
                ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo_sub_centro_costo(poliza_info.IdCentroCosto_sub_centro_costo);


                gridControl_Detalle_Cuotas.DataSource = list_Detalle_x_Cuota_info;
                gridControlActivos.DataSource = list_Detalle_x_Activo_info;
                gridControlActivos.RefreshDataSource();


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                this._Accion = Accion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_Controles()
        {
            try
            {
                Cargar_combos();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntLimpiar = true;
                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(false);
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntLimpiar = true;
                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
                        Set_Poliza();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
                        Set_Poliza();

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
                        Set_Poliza();

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Cargar_combos()
        {
            try
            {
                list_Activos = bus_Activos.Get_List_ActivoFijo(param.IdEmpresa);
                ucFa_Cliente_x_centro_costo_cmb1.Cargar_combos();


                list_catalogo_facturacion = Catalogo_Facturacion_Bus.Get_List_catalogo(10);
                cmb_Estado_Facturacion.DataSource = list_catalogo_facturacion;
                cmb_Estado_Facturacion.ValueMember = "IdCatalogo";
                cmb_Estado_Facturacion.DisplayMember = "Nombre";

                cmb_EstadoFacturacion_Activo.DataSource = list_catalogo_facturacion;
                cmb_EstadoFacturacion_Activo.ValueMember = "IdCatalogo";
                cmb_EstadoFacturacion_Activo.DisplayMember = "Nombre";

                lista_catalogo_CxP = catalogo_CxP_bus.Get_List_catalogo("EST_DOC");
                cmb_Estado_Cancelacion.DataSource = lista_catalogo_CxP;
                cmb_Estado_Cancelacion.ValueMember = "IdCatalogo";
                cmb_Estado_Cancelacion.DisplayMember = "Nombre";
                
                    foreach (var item in list_Activos)
                    {
                        Af_Poliza_x_AF_det_Info info_ = new Af_Poliza_x_AF_det_Info();
                        info_.IdActivoFijo = item.IdActivoFijo;
                        info_.Af_Nombre = item.Af_Nombre;

                        list_Detalle_x_Activo_info.Add(info_);

                    }
                gridControlActivos.DataSource = list_Detalle_x_Activo_info;






                txt_base0.EditValue = 0;
                txt_base12.EditValue = 0;
                txt_pago_contado.EditValue = 0;
                txt_valorCuota.EditValue = 0;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmAF_Poliza_x_Activos_Mantenimiento_FJ_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_delegate_frmAF_Poliza_x_Activos_Mantenimiento_FJ_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmAF_Poliza_x_Activos_Mantenimiento_FJ_Load(object sender, EventArgs e)
        {
            try
            {
                da_fecha.EditValue = DateTime.Now;
                Set_Controles();
                txtPorcIva.Text =Convert.ToString( param.iva.porcentaje);
              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Get()
        {
            try
            {

                // info
                poliza_info = new Af_Poliza_x_AF_Info();
                poliza_info.IdEmpresa = param.IdEmpresa;
                if (txtIdPoliza.Text != "")
                {
                    poliza_info.IdPoliza =Convert.ToInt32( txtIdPoliza.Text);
                }
                if (txtCodigo.Text != "")
                {
                    poliza_info.cod_poliza = txtCodigo.Text;
                }
                if (txtCodigo.Text == "")
                {
                    poliza_info.cod_poliza = " ";
                }

                if (txt_base0.Text != "0" || txt_base0.Text == "")
                {
                    poliza_info.subtotal_noIva = Convert.ToDouble(txt_base0.EditValue);
                }

                if (txt_pago_contado.Text != "0" || txt_pago_contado.Text == "")
                {
                    poliza_info.pago_contado = Convert.ToDouble(txt_pago_contado.EditValue);
                }


                poliza_info.IdProveedor = cmb_proveedor.get_ProveedorInfo().IdProveedor;
                poliza_info.fecha =Convert.ToDateTime( da_fecha.EditValue);
                poliza_info.observacion = txtobservacion.EditValue.ToString();
                poliza_info.fecha_vigencia_desde =Convert.ToDateTime( deDesde.EditValue);
                poliza_info.fecha_vigencia_hasta =Convert.ToDateTime( deHasta.EditValue);
                poliza_info.num_cuotas = Convert.ToInt32(txt_num_cuotas.EditValue);
                poliza_info.valor_cuota = Convert.ToDouble( txt_valorCuota.Text);
                poliza_info.fecha_1era_cuota = Convert.ToDateTime( deFechaPrimerCuota.EditValue);
                poliza_info.suma_asegurada = Convert.ToDouble(txtTotal.EditValue);
                poliza_info.porc_iva = Convert.ToDouble(txtPorcIva.EditValue);
                poliza_info.iva = Convert.ToDouble( txtIva.EditValue);
                poliza_info.Total = Convert.ToDouble(txtTotal.EditValue);
                poliza_info.total_meses = Convert.ToInt32(txt_num_cuotas.EditValue);
                poliza_info.subtotal = Convert.ToDouble(txt_base12.EditValue);
              
                //Datos para facturar
                poliza_info.IdCentroCosto = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo()==null ? null : ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo().IdCentroCosto;
                poliza_info.IdCentroCosto_sub_centro_costo = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo_sub_centro_costo()==null ? null : ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;

                poliza_info.lst_Det = list_Detalle_x_Activo_info.Where(v=>v.check==true).ToList();
                foreach (var item in poliza_info.lst_Det)
                {
                    item.IdEmpresa = param.IdEmpresa;
                }
                poliza_info.lst_Det_cuota = list_Detalle_x_Cuota_info.ToList();

            }
            catch (Exception ex)
            {
                
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private bool Validar()
        {
            try
            {
                bool Bandera = true;

                if (txt_base12.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el)+" subtotal",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Bandera = false;
                }

                if (txt_num_cuotas .Text== "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " # cuotas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bandera = false;
                }



                if (Convert.ToDateTime( deDesde.EditValue) >=Convert.ToDateTime( deHasta.EditValue))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Fecha_final_debe_ser_mayor_que_fecha_inicial) , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bandera = false;
                }


                if (txtobservacion.EditValue==null || txtobservacion.EditValue=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la)+" observacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bandera = false;
                }

                if (cmb_proveedor.get_ProveedorInfo()==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el)+"Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bandera = false;
                }

                if (list_Detalle_x_Activo_info.Count() == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + ", 0 los activos Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bandera = false;
                }




                double sum = (double)list_Detalle_x_Activo_info.Sum(v => v.Prima);
                    sum = sum * -1;
                    sum =Math.Round( sum + Convert.ToDouble(txtTotal.EditValue));
                    if(sum!=0)
                    {
                        
                    MessageBox.Show("La Suma de de los activos es diferente al valor ingresado [Total]", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bandera = false;
                
                  }


                return Bandera;

            }
            catch (Exception ex)
            {
                
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public bool Grabar()
        {
            int idpoliza=0;
            try
            {
                Get();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Poliza_Bus.GuardarDB(poliza_info, ref idpoliza);
                        return true;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Poliza_Bus.ModificarDB(poliza_info);
                        return true;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        if (MessageBox.Show("¿Está seguro que desea anular el registro?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                            string msg = "";
                            oFrm.ShowDialog();
                            // poliza_info.Fecha_UltMod = oFrm.motivoAnulacion;
                            poliza_info.IdUsuarioUltAnu = param.IdUsuario;
                            poliza_info.Fecha_UltAnu = param.Fecha_Transac;
                            Poliza_Bus.AnularDB(poliza_info);
                            return true;
                        }
                        return true;
                   
                    default:
                        break;
                }
                return true;

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

                return false;
                
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (Grabar())
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                       
                }
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
        }

        private void txtSubtotal_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
       {
            try
            {
                              Calcular_Cuotas();
                detalle_Activo();
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txtSubtotal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                Calcular_Cuotas();
                detalle_Activo();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void txt_num_cuotas_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
               Calcular_Cuotas();
            }
            catch (Exception ex)
            {
                
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
       
            }
        }

        public void Calcular_Cuotas()
        {
            try
            {
                double Subt_total_12 = 0;
                double Subt_total_0 = 0;
                double iva_por_activo = 0;
                double valor_prima = 0;
                double iva=0;
                double pago_contado = 0;
                //if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                //    return;


               
                    if (txt_base12.Text != "")
                    {
                        iva = (Convert.ToDouble(txt_base12.EditValue) * param.iva.porcentaje) / 100;
                        txtIva.EditValue = string.Format("{0:0.00}", iva);
                        txtTotal.EditValue = string.Format("{0:0.00}", iva + Convert.ToDouble(txt_base12.EditValue) + Convert.ToDouble(txt_base0.EditValue)); //- Convert.ToDouble(txt_pago_contado.EditValue));
                    }
                    else
                    {
                        txtIva.Text = "";
                        txtTotal.Text = "";
                    }

                    if (txt_base12.EditValue != "" || txt_num_cuotas.EditValue != "")
                    {
                        Subt_total_12 = Convert.ToDouble(txt_base12.Text == "" ? 0 : txt_base12.EditValue) / Convert.ToDouble(txt_num_cuotas.Text == "" ? 0 : txt_num_cuotas.EditValue);
                        Subt_total_0 = Convert.ToDouble(txt_base0.Text == "" ? 0 : txt_base0.EditValue) / Convert.ToDouble(txt_num_cuotas.Text == "" ? 0 : txt_num_cuotas.EditValue);
                        iva_por_activo = Convert.ToDouble(txtIva.Text == "" ? 0 : txtIva.EditValue) / Convert.ToDouble(txt_num_cuotas.Text == "" ? 0 : txt_num_cuotas.EditValue);
                        if (txt_num_cuotas.Text == "" || txt_num_cuotas.Text == "0")
                        {
                            valor_prima = 0;
                        }
                        else
                        {
                            valor_prima = Convert.ToDouble(txtTotal.EditValue) / Convert.ToDouble(txt_num_cuotas.Text == "" ? 0 : txt_num_cuotas.EditValue);
                        }
                        txt_valorCuota.EditValue = Convert.ToString(valor_prima);
                        pago_contado = Convert.ToDouble(txt_pago_contado.Text == "" ? 0 : txt_pago_contado.EditValue) / Convert.ToDouble(txt_num_cuotas.Text == "" ? 0 : txt_num_cuotas.EditValue);
                    }

                    list_Detalle_x_Cuota_info = new BindingList<Af_Poliza_x_AF_det_cuota_Info>();
                    if (txt_num_cuotas.Text != "")
                    {
                        // detalle por cuota
                        int num_Cuotas = Convert.ToInt32(txt_num_cuotas.Text);
                        int cont_cuotas = 0;
                        while (cont_cuotas < num_Cuotas)
                        {
                            cont_cuotas = cont_cuotas + 1;

                            Af_Poliza_x_AF_det_cuota_Info info_ = new Af_Poliza_x_AF_det_cuota_Info();
                            info_.IdEmpresa = param.IdEmpresa;
                            info_.IdEstadoCancelacion_cat = "EST_DOC_PEN";
                            info_.IdEstadoFacturacion_cat = "EST_FAC_PENDI";
                            if (cont_cuotas == 0)
                            {
                                info_.Fecha_Pago = (DateTime)deFechaPrimerCuota.EditValue;
                            }
                            else
                            {
                                info_.Fecha_Pago = Convert.ToDateTime(deFechaPrimerCuota.EditValue).AddMonths(cont_cuotas);
                            }
                            info_.Sub_total_12 = Subt_total_12;
                            info_.Sub_total_0 = Subt_total_0;
                            info_.Iva = iva / num_Cuotas;
                            info_.cod_couta = cont_cuotas + "/" + num_Cuotas;
                            info_.valor_prima = (Subt_total_12 + Subt_total_0 + info_.Iva);//-pago_contado;
                            list_Detalle_x_Cuota_info.Add(info_);
                        }


                    }
                gridControl_Detalle_Cuotas.DataSource = list_Detalle_x_Cuota_info;
                gridControl_Detalle_Cuotas.RefreshDataSource();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
       
            }
        }

        private void gridViewActivos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {
                    gridViewActivos.DeleteSelectedRows();
                    detalle_Activo();
                }
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }

        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (Grabar())
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void gridViewActivos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Af_Poliza_x_AF_det_Info row = new Af_Poliza_x_AF_det_Info();
                row = (Af_Poliza_x_AF_det_Info)gridViewActivos.GetRow(e.RowHandle);

                if (e.Column.Name == "ColCheck")
                {
                    detalle_Activo();
                    if (row.check)
                        gridViewActivos.SetRowCellValue(e.RowHandle, colIdEstadoFact_cat_x_Act, "EST_FAC_PENDI");
                    else
                        gridViewActivos.SetRowCellValue(e.RowHandle, colIdEstadoFact_cat_x_Act, null);
                    
                }
                if (e.Column.Name == "ColSubtotal_12" || e.Column.Name == "colSubtotal_0")
                {
                    Subtotal_12 = Convert.ToDouble(gridViewActivos.GetFocusedRowCellValue(ColSubtotal_12));
                    Subtotal_0 = Convert.ToDouble(gridViewActivos.GetFocusedRowCellValue(col_Sub_total_0));
                    check_ = Convert.ToBoolean(gridViewActivos.GetFocusedRowCellValue(ColCheck));
                    if (Subtotal_12 != 0 || Subtotal_0 != 0)
                    {
                        if (check_ == true)
                        {
                            if (Subtotal_0 != 0)
                            {
                                row.Subtotal_0 = Subtotal_0;
                                Subtotal_0 = 0;
                            }
                            if (Subtotal_12 != 0)
                            {
                                row.Subtotal_12 = Subtotal_12;
                                Subtotal_12 = 0;
                                row.Iva = Convert.ToDouble((row.Subtotal_12 * param.iva.porcentaje) / 100);
                            }
                            row.Prima = (double)(row.Subtotal_0 + row.Subtotal_12 + row.Iva) - (Convert.ToDouble(txt_pago_contado.EditValue));
                        }
                        else
                        {
                            row.Subtotal_0 = 0;
                            row.Subtotal_12 = 0;
                            row.Iva = 0;
                            row.Prima = 0;
                        }
                    
                    }
                    if (row.check)
                        gridViewActivos.SetRowCellValue(e.RowHandle, colIdEstadoFact_cat_x_Act, "EST_FAC_PENDI");
                    else
                        gridViewActivos.SetRowCellValue(e.RowHandle, colIdEstadoFact_cat_x_Act, null);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
           
        }

        private void cmb_Activos_grid_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
           // txtobservacion.Focus();
        }
        
        public void Limpiar()
        {
            try
            {
                txt_valorCuota.Text = "0";
                txt_num_cuotas.Text = "0";
                txtCodigo.Text = "";
                txtIdPoliza.Text = "";
                txtIva.Text = "0";
                txtobservacion.Text = "";
                txtPorcIva.Text = "";
                txtTotal.Text = "0";
                list_Detalle_x_Cuota_info = new BindingList<Af_Poliza_x_AF_det_cuota_Info>();
                list_Detalle_x_Activo_info = new BindingList<Af_Poliza_x_AF_det_Info>();
                gridControl_Detalle_Cuotas.DataSource =  list_Detalle_x_Cuota_info;
                gridControlActivos.DataSource = list_Detalle_x_Activo_info;

            }
            catch (Exception ex)
            {
                
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception ex)
            {
                
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_BarraEstadoInferior_Forms1_Load(object sender, EventArgs e)
        {

        }

        private void panelCabecera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deDesde_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular_Cuotas();
            }
            catch (Exception ex)
            {
                
                 
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
      
            }
        }

        private void deHasta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular_Cuotas();
            }
            catch (Exception ex)
            {


                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void txt_base0_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular_Cuotas();
                

            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void txt_pago_contado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                Calcular_Cuotas();
                detalle_Activo();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void txt_base12_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones fx = new Funciones();
                e.Handled = fx.Validanumero_decimal(e.KeyChar);
                if (e.KeyChar == 44)
                {
                    e.Handled = true;
                }
                Calcular_Cuotas();
                detalle_Activo();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_base12_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                Calcular_Cuotas();
                detalle_Activo();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_base0_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
               
                Calcular_Cuotas();
                detalle_Activo();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_pago_contado_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
               
                Calcular_Cuotas();
                detalle_Activo();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridControlActivos_Click(object sender, EventArgs e)
        {

        }

        private void deFechaPrimerCuota_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular_Cuotas();
                detalle_Activo();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_base0_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                 Funciones fx = new Funciones();
                e.Handled = fx.Validanumero_decimal(e.KeyChar);
                if (e.KeyChar == 44)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_pago_contado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones fx = new Funciones();
                e.Handled = fx.Validanumero_decimal(e.KeyChar);
                if (e.KeyChar == 44)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_num_cuotas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular_Cuotas();

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void detalle_Activo()
        {
            try
            {
                if (list_Detalle_x_Activo_info.Count > 0)
                {
                   
                        int activos_seleccionados = list_Detalle_x_Activo_info.Where(v => v.check == true).Count();


                        foreach (var item in list_Detalle_x_Activo_info)
                        {
                            
                                if (item.check == true)
                                {
                                    item.Subtotal_0 = Convert.ToDouble(txt_base0.Text == "" ? 0 : txt_base0.EditValue) / activos_seleccionados;
                                    item.Subtotal_12 = Convert.ToDouble(txt_base0.Text == "" ? 0 : txt_base12.EditValue) / activos_seleccionados;
                                    item.Iva = Convert.ToDouble(txtIva.Text == "" ? 0 : txtIva.EditValue) / activos_seleccionados;
                                    item.Prima = (item.Subtotal_0 + item.Subtotal_12 + item.Iva);
                                }
                                else
                                {
                                    item.Subtotal_0 = 0;
                                    item.Subtotal_12 = 0;
                                    item.Iva = 0;
                                    item.Prima = 0;
                                }
                        }

                        gridControlActivos.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_base0_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {        
                 Calcular_Cuotas();
                 detalle_Activo();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

    }
}
