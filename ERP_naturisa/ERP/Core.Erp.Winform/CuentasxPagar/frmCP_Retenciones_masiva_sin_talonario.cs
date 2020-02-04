using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Retenciones_masiva_sin_talonario : Form
    {
        List<vwcp_orden_giro_sin_retenciones_Info> ListinReten = new List<vwcp_orden_giro_sin_retenciones_Info>();
        cp_retencion_Bus BusReten = new cp_retencion_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<cp_codigo_SRI_Info> lst_codigo_SRI = new List<cp_codigo_SRI_Info>();
        cp_codigo_SRI_Bus bus_codigo_SRI = new cp_codigo_SRI_Bus();
        cp_codigo_SRI_Info info_codigo = new cp_codigo_SRI_Info();
        // BindingList
        BindingList<vwcp_orden_giro_sin_retenciones_Info> BindSinReten = new BindingList<vwcp_orden_giro_sin_retenciones_Info>();

        cp_retencion_Info info_retencion = new cp_retencion_Info();
        cp_retencion_Bus bus_retencion = new cp_retencion_Bus();

        public frmCP_Retenciones_masiva_sin_talonario()
        {
            InitializeComponent();
        }

        private void frmCP_Retenciones_masiva_sin_talonario_Load(object sender, EventArgs e)
        {
            try
            {
                ucCon_Periodo1.Cargar_combos();
                lst_codigo_SRI = bus_codigo_SRI.Get_List_codigo_SRI("COD_RET_FUE");
                cmb_codigo.Properties.DataSource = lst_codigo_SRI;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cargaGrid()
        {
            try
            {
                ListinReten = BusReten.Get_List_cp_orden_giro_sin_retenciones(param.IdEmpresa
                    , ucCon_Periodo1.Get_Periodo_Info().pe_FechaIni
                    , ucCon_Periodo1.Get_Periodo_Info().pe_FechaFin);

                BindSinReten = new BindingList<vwcp_orden_giro_sin_retenciones_Info>(ListinReten);
                gridControlFact_sin_ret.DataSource = BindSinReten;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ucCon_Periodo1.Get_Periodo_Info() == null)
                {
                    MessageBox.Show("Seleccione el periodo",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                cargaGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_seleccionar_todo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewFact_sin_ret.RowCount; i++)
                {
                    gridViewFact_sin_ret.SetRowCellValue(i, col_check, chk_seleccionar_todo.Checked);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDB())
                {
                    cargaGrid();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDB())
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

        private bool Validar()
        {
            try
            {
                ucCon_Periodo1.Focus();
                if (ucCon_Periodo1.Get_Periodo_Info() == null)
                {
                    MessageBox.Show("Seleccione el periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (cmb_codigo.EditValue == null)
                {
                    MessageBox.Show("Seleccione el código de retención", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool GuardarDB()
        {
            try
            {
                if (!Validar()) return false;
                info_codigo = lst_codigo_SRI.First(q => q.IdCodigo_SRI == Convert.ToInt32(cmb_codigo.EditValue));
                foreach (var item in BindSinReten.Where(q=>q.Checked == true))
                {
                    info_retencion = new cp_retencion_Info();
                    info_retencion = Get_info(item);
                    if (info_retencion != null)
                    {
                        bus_retencion.GrabarDB(info_retencion);
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

        private cp_retencion_Info Get_info(vwcp_orden_giro_sin_retenciones_Info item)
        {
            try
            {
                cp_retencion_Info I_retencion = new cp_retencion_Info();
                I_retencion.IdEmpresa = param.IdEmpresa;
                I_retencion.IdEmpresa_Ogiro = item.Idempresa;
                I_retencion.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                I_retencion.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                I_retencion.CodDocumentoTipo = "RETEN";
                I_retencion.fecha = item.co_FechaFactura;
                I_retencion.observacion = "Ret x prov: " + item.pr_nombre + " x F# " + item.co_factura;
                I_retencion.re_EstaImpresa = "S";
                I_retencion.re_Tiene_RFuente = "S";
                I_retencion.re_Tiene_RTiva = "N";
                I_retencion.Estado = "A";

                cp_retencion_det_Info info_det = new cp_retencion_det_Info();
                info_det.IdEmpresa = param.IdEmpresa;
                info_det.IdCodigo_SRI = info_codigo.IdCodigo_SRI;
                info_det.re_tipoRet = "RTF";
                info_det.re_Codigo_impuesto = info_codigo.co_codigoBase;
                info_det.re_Porcen_retencion = info_codigo.co_porRetencion;
                info_det.re_valor_retencion = info_codigo.co_porRetencion == 0 ? 0 : item.co_baseImponible * (info_codigo.co_porRetencion / 100);
                info_det.re_baseRetencion = item.co_baseImponible;
                info_det.re_estado = "A";
                I_retencion.ListDetalle.Add(info_det);
                return I_retencion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


    }
}
