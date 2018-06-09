using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Cus.Erp.Reports.FJ.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class FrmFa_orden_trabajo_plataforma_Mantenimiento : Form
    {
        #region Variables y atributos
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_orden_trabajo_plataforma_Bus bus_Orden = new fa_orden_trabajo_plataforma_Bus();
        fa_orden_trabajo_plataforma_Info info_Orden = new fa_orden_trabajo_plataforma_Info();
        Cl_Enumeradores.eTipo_action _Accion;
        BindingList<fa_orden_trabajo_plataforma_det_Info> bList_Orden = new BindingList<fa_orden_trabajo_plataforma_det_Info>();
        fa_orden_trabajo_plataforma_det_Bus bus_Orden_det = new fa_orden_trabajo_plataforma_det_Bus();

        public delegate void delegate_FrmFa_orden_trabajo_plataforma_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmFa_orden_trabajo_plataforma_Mantenimiento_FormClosing event_delegate_FrmFa_orden_trabajo_plataforma_Mantenimiento_FormClosing;
        #endregion

        public FrmFa_orden_trabajo_plataforma_Mantenimiento()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            this.event_delegate_FrmFa_orden_trabajo_plataforma_Mantenimiento_FormClosing += FrmFa_orden_trabajo_plataforma_Mantenimiento_event_delegate_FrmFa_orden_trabajo_plataforma_Mantenimiento_FormClosing;
        }

        void FrmFa_orden_trabajo_plataforma_Mantenimiento_event_delegate_FrmFa_orden_trabajo_plataforma_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }        

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Focus();
                if (Validar())
                {   
                    bool exito = false;
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            exito = GuardarDB();
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            exito = ModificarDB();
                            break;
                        default:
                            break;
                    }
                    if (exito) this.Close();    
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Focus();
                if (Validar())
                {                    
                    bool exito = false;
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            exito = GuardarDB();
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            exito = ModificarDB();
                            break;
                        default:
                            break;
                    }
                    if (exito) Limpiar();    
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                AnularDB();
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
                deFecha.EditValue = DateTime.Now;
                _Accion = Accion;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        txtCodigo.Properties.ReadOnly = false;
                        ucFa_ClienteCmb1.cmb_cliente.Properties.ReadOnly = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        txtCodigo.Properties.ReadOnly = true;
                        ucFa_ClienteCmb1.cmb_cliente.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        txtCodigo.Properties.ReadOnly = true;
                        ucFa_ClienteCmb1.cmb_cliente.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        txtCodigo.Properties.ReadOnly = false;
                        ucFa_ClienteCmb1.cmb_cliente.Properties.ReadOnly = true;
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

        public void Set_Info(fa_orden_trabajo_plataforma_Info info)
        {
            try
            {
                info_Orden = bus_Orden.Get_Info_Orden_trabajo(info.IdEmpresa, info.IdOrdenTrabajo_Pla);
                

                txtCodigo.Text = info.codOrdenTrabajo_Pla;
                txtCon_atencion_a.Text = info.con_atencion_a;
                txtDescripcion.Text = info.Descripcion;
                txtEquipo.Text = info.Equipo;
                txtKilometraje_llegada.Text = info.km_llegada.ToString();
                txtKilometraje_salida.Text = info.km_salida.ToString();
                txtSerie.Text = info.serie;
                ucFa_ClienteCmb1.set_ClienteInfo(info.IdCliente);
                deFecha.EditValue = info.Fecha;

                if (info_Orden.Estado == "I") lblanulado.Visible = true;

                bList_Orden = new BindingList<fa_orden_trabajo_plataforma_det_Info>(info_Orden.lst_Det_Orden);
                gridControlOrden_Det.DataSource = bList_Orden;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Get_Info()
        {
            try
            {
                info_Orden.IdEmpresa = param.IdEmpresa;
                info_Orden.codOrdenTrabajo_Pla = txtCodigo.Text;
                info_Orden.Descripcion = txtDescripcion.Text;
                info_Orden.Equipo = txtEquipo.Text;
                info_Orden.Estado = "A";
                info_Orden.Fecha = deFecha.EditValue==null ? DateTime.Now: Convert.ToDateTime(deFecha.EditValue);
                info_Orden.con_atencion_a = txtCon_atencion_a.Text;
                info_Orden.km_llegada = txtKilometraje_llegada.Text=="" ? 0: Convert.ToDouble(txtKilometraje_llegada.Text);
                info_Orden.km_salida = txtKilometraje_salida.Text == "" ? 0 : Convert.ToDouble(txtKilometraje_salida.Text);
                info_Orden.serie = txtSerie.Text;
                info_Orden.IdCliente = ucFa_ClienteCmb1.get_ClienteInfo().IdCliente;
                info_Orden.ip = param.ip;
                info_Orden.nom_pc = param.nom_pc;

                info_Orden.lst_Det_Orden = new List<fa_orden_trabajo_plataforma_det_Info>(bList_Orden);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean GuardarDB()
        {
            try
            {
                decimal IdOrden_trabajo = 0;
                Get_Info();
                if (bus_Orden.GuardarDB(info_Orden,ref IdOrden_trabajo))
                {
                    info_Orden.IdOrdenTrabajo_Pla = IdOrden_trabajo;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la Orden de trabajo # " + info_Orden.IdOrdenTrabajo_Pla, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Desea_Imprimir), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Imprimir();
                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean ModificarDB()
        {
            try
            {
                Get_Info();
                if (bus_Orden.ModificarDB(info_Orden))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " la Orden de trabajo # " + info_Orden.IdOrdenTrabajo_Pla, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Desea_Imprimir), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Imprimir();
                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean AnularDB()
        {
            try
            {
                FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + " la Orden de trabajo #: " + info_Orden.IdOrdenTrabajo_Pla + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oFrm.ShowDialog();
                    info_Orden.MotiAnula = oFrm.motivoAnulacion;
                    if (bus_Orden.AnularDB(info_Orden))
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " la Orden de trabajo # " + info_Orden.IdOrdenTrabajo_Pla, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        info_Orden.Estado = "I";
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        lblanulado.Visible = true;
                        Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void Imprimir()
        {
            try
            {
                XFAC_FJ_Rpt001_Rpt rpt = new XFAC_FJ_Rpt001_Rpt();
                rpt.idEmpresa_P.Value = param.IdEmpresa;
                rpt.idOrdenTrabajo.Value = info_Orden.IdOrdenTrabajo_Pla;
                rpt.RequestParameters = false;
                rpt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Limpiar()
        {
            try
            {
                info_Orden = new fa_orden_trabajo_plataforma_Info();
                lblanulado.Visible = false;
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Set_Accion(_Accion);
                txtCodigo.Text = string.Empty;
                txtCon_atencion_a.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                txtEquipo.Text = string.Empty;
                txtKilometraje_llegada.Text = string.Empty;
                txtKilometraje_salida.Text = string.Empty;
                txtSerie.Text = string.Empty;
                ucFa_ClienteCmb1.Inicializar_cmb_cliente();
                deFecha.EditValue = DateTime.Now;

                bList_Orden = new BindingList<fa_orden_trabajo_plataforma_det_Info>();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        private void FrmFa_orden_trabajo_plataforma_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {                
                gridControlOrden_Det.DataSource = bList_Orden;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmFa_orden_trabajo_plataforma_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_delegate_FrmFa_orden_trabajo_plataforma_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        private Boolean Validar()
        {
            try
            {
                if (bList_Orden.Count==0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el)+"detalle de la orden de trabajo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (Convert.ToDecimal(ucFa_ClienteCmb1.cmb_cliente.EditValue)==0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el)+"cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (txtDescripcion.Text == string.Empty)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la)+"descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (txtEquipo.Text == string.Empty)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el)+"equipo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
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
        
        private void gridViewOrden_Det_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar la fila seleccionada?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewOrden_Det.DeleteRow(gridViewOrden_Det.FocusedRowHandle);
                        e.Handled = true;
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
    }
}
