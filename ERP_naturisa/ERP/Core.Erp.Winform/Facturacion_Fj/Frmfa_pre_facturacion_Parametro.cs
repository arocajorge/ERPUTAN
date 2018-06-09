using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class Frmfa_pre_facturacion_Parametro : Form
    {
        #region Declaracion de Variables
        //generales
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //Clase Bus
        fa_pre_facturacion_Parametro_Bus Bus_Param = new fa_pre_facturacion_Parametro_Bus();
        fa_liquidaciones_tipo_proceso_Bus Bus_TipoPro = new fa_liquidaciones_tipo_proceso_Bus();
        fa_liquidacion_gastos_producto_Bus Bus_GasProd = new fa_liquidacion_gastos_producto_Bus();

        //clase info
        fa_pre_facturacion_Parametro_Info Info_Param = new fa_pre_facturacion_Parametro_Info();
        fa_liquidaciones_tipo_proceso_Info Info_Tipo_Proc = new fa_liquidaciones_tipo_proceso_Info();

        //listas
        List<fa_liquidaciones_tipo_proceso_Info> Lista_Tipo_Proc = new List<fa_liquidaciones_tipo_proceso_Info>();
        List<fa_liquidacion_gastos_producto_Info> Lista_Liqui_Gastos_Producto = new List<fa_liquidacion_gastos_producto_Info>();

        //otras variables
        FrmFa_Liquidaciones_x_Tipo_Proceso_Mant frm;
        List<ro_fuerza_Info> lista_fuerza = new List<ro_fuerza_Info>();
        ro_fuerza_Bus bus_fuerza = new ro_fuerza_Bus();
        List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info> lista_periodo_por_fuerza = new List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info>();
        fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Bus bus_margenes_por_mes = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Bus();


        List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info> lista_periodo = new List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info>();

        

        string MensajeError = "";

        #endregion

        public Frmfa_pre_facturacion_Parametro()
        {
            InitializeComponent();
        }

        void Cargar_Combo()
        {
            try
            {
                ucFa_Catalogos_Cmb.cargar_Catalogos(12);
                lista_fuerza = bus_fuerza.Get_List_Fuerza(param.IdEmpresa);
                cmb_fuerza.Properties.DataSource = lista_fuerza;


               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Set_Info_Parametro()
        {
            try
            {
                Info_Param = Bus_Param.Get_Info(param.IdEmpresa);
                chk_se_cobra_iva.Checked = Info_Param.Se_Cobra_Iva;
                ucFa_Catalogos_Cmb.set_CatalogosInfo(Info_Param.Tipo_Cobro_Poliza_X);
                chk_se_liquida_x_grupos.Checked = Info_Param.Liquidar_x_grupo;
              //  txt_Margen_Ganancia_por_BS.EditValue = Info_Param.Margen_Ganancia_por_BS;
              //  txt_Margen_Ganancia_por_MO.EditValue = Info_Param.Margen_Ganancia_por_MO;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get_Info_Parametro()
        {
            try
            {
                Info_Param.IdEmpresa = param.IdEmpresa;
                Info_Param.Se_Cobra_Iva = chk_se_cobra_iva.Checked;
                Info_Param.Tipo_Cobro_Poliza_X = ucFa_Catalogos_Cmb.get_CatalogosInfo().IdCatalogo;
                Info_Param.Liquidar_x_grupo = chk_se_liquida_x_grupos.Checked;
                Info_Param.lis_param_x_fuerza = lista_periodo_por_fuerza;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean Validar()
        {
            try
            {
                if (ucFa_Catalogos_Cmb.get_CatalogosInfo() == null)
                {
                    MessageBox.Show("Ingrese el tipo de cobro de poliza ", "Sistemas");
                    ucFa_Catalogos_Cmb.Focus();
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

        Boolean Guardar_Datos()
        {
            try
            {
                Boolean resultado = false;
                if (Validar())
                {
                    Get_Info_Parametro();

                    string mensaje = "";
                    resultado=Bus_Param.ModificarDB(Info_Param, ref mensaje);
                    if (resultado)
                    {
                        MessageBox.Show("Parámetros Guardados Exitosamente");
                        //ucGe_Menu.Visible_btnGuardar = false;
                    }
                    else
                    {
                        MessageBox.Show("Error " + mensaje);
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #region "Liquidacion Gastos"

        private void Llamar_formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new FrmFa_Liquidaciones_x_Tipo_Proceso_Mant();
                frm.Event_FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_FormClosing += frm_Event_FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_FormClosing;
                frm.SetAccion(Accion);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Info_Tipo_Proc != null)
                    {
                        frm.SetInfo(Info_Tipo_Proc);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Por Favor seleccione un registro para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_Event_FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cargar_Grid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Cargar_Grid()
        {
            try
            {
                Lista_Liqui_Gastos_Producto = Bus_GasProd.Get_List_Liqui_Gas_Producto(param.IdEmpresa, ref MensajeError);
                cmb_Liqui_Gasto_Producto.DataSource = Lista_Liqui_Gastos_Producto;

                Lista_Tipo_Proc = Bus_TipoPro.Get_List_Liqui_Tipo_Proceso(ref MensajeError);
                gc_Liqui_tipo_proc.DataSource = Lista_Tipo_Proc;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gw_Liqui_tipo_proc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info_Tipo_Proc = gw_Liqui_tipo_proc.GetRow(e.FocusedRowHandle) as fa_liquidaciones_tipo_proceso_Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion

        private void Frmfa_pre_facturacion_Parametro_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combo();
                Cargar_Grid();
                Set_Info_Parametro();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar_Datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Generar_Periodos(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            try
            {
                lista_periodo_por_fuerza = new List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info>();
                while (Fecha_Inicio<=Fecha_Fin)
                {
                    fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info info = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdFuerza =Convert.ToInt32( cmb_fuerza.EditValue);
                    info.Porcentaje_Calculo_BS =Convert.ToDecimal( txt_Margen_Ganancia_por_BS.EditValue);
                    info.Porcentaje_Calculo_MO = Convert.ToDecimal(txt_Margen_Ganancia_por_MO.EditValue);
                    info.Fecha_Fin = dtp_Fecha_Fin.Value;
                    info.Fecha_Inicio = dtp_Fecha_Inicio.Value;
                    info.Anio = Fecha_Inicio.Year;
                    info.Mes = Fecha_Inicio.Month;
                    Fecha_Inicio = Fecha_Inicio.AddMonths(1);
                    lista_periodo_por_fuerza.Add(info);

                    gridControl_margen_ganancia_por_fuerza.DataSource = lista_periodo_por_fuerza;
                    gridControl_margen_ganancia_por_fuerza.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp_Fecha_Inicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Generar_Periodos(dtp_Fecha_Inicio.Value,dtp_Fecha_Fin.Value);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp_Fecha_Fin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Generar_Periodos(dtp_Fecha_Inicio.Value, dtp_Fecha_Fin.Value);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Margen_Ganancia_por_MO_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Generar_Periodos(dtp_Fecha_Inicio.Value, dtp_Fecha_Fin.Value);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Margen_Ganancia_por_BS_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Generar_Periodos(dtp_Fecha_Inicio.Value, dtp_Fecha_Fin.Value);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_fuerza_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lista_periodo = bus_margenes_por_mes.Get_List_marge_ganacia_RRHH(param.IdEmpresa, Convert.ToInt32(cmb_fuerza.EditValue));
                cmb_periodo.Properties.DataSource = lista_periodo;
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info info_=new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info();
                info_ = (fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info)cmb_periodo.Properties.View.GetFocusedRow();
                lista_periodo_por_fuerza = bus_margenes_por_mes.Get_List_marge_ganacia_RRHH(param.IdEmpresa, info_.Fecha_Inicio, info_.Fecha_Fin, info_.IdFuerza);
                gridControl_margen_ganancia_por_fuerza.DataSource = lista_periodo_por_fuerza;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
