using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;


namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Archivo_Transferencia_Det : Form
    {
        public ba_Archivo_Transferencia_Info Archivo_Info { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ba_Archivo_Transferencia_Det_Bus bus_Archivo = new ba_Archivo_Transferencia_Det_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        vwcp_orden_pago_con_cancelacion_Bus Pagos_Bus = new vwcp_orden_pago_con_cancelacion_Bus();
        List<vwcp_orden_pago_con_cancelacion_Info> list = new List<vwcp_orden_pago_con_cancelacion_Info>();
        public FrmBA_Archivo_Transferencia_Det()
        {
            InitializeComponent();
        }

        public void Set_Info(ba_Archivo_Transferencia_Info Info)
        {
            try
            {
                switch (Info.IdBanco)
                {
                    case 3:
                        colFecha_Proceso.Visible = false;
                        break;
                    default:
                        break;
                }
                Archivo_Info = Info;
                switch (Info.IdProceso_bancario)
                {                       
                    case "PAGO_PROVEEDORES_BOL":
                        colBeneficiario.Visible = true;
                        colReferencia.Visible = true;
                        ColOB.Visible = true;
                        colValor.Visible = true;
                        col_tipo_cbte_pago.Visible = true;
                        col_IdCbtePago.Visible = true;
                        break;
                    case "PREAVISO_CHEQ":
                        colBeneficiario.Visible = true;                        
                        colcb_Fecha_cheq.Visible = true;
                        colCHEQUE.Visible = true;
                        colObservacion_cheq.Visible = true;
                        colValor.Visible = true;
                        break;                        
                    default:
                        colBeneficiario.Visible = true;
                        colReferencia.Visible = true;
                        colValor.Visible = true;
                        col_tipo_cbte_pago.Visible = true;
                        col_IdCbtePago.Visible = true;
                        break;
                }

                switch (Info.IdProceso_bancario)
                {
                    case "PREAVISO_CHEQ":
                        Archivo_Info.Lst_Archivo_Transferencia_Det = bus_Archivo.Get_List_Archivo_transferencia_Det(Info.IdEmpresa, Info.IdArchivo);
                        gridControlArchivo_Det.DataSource = Archivo_Info.Lst_Archivo_Transferencia_Det;
                        break;
                    default:
                        BuscarOP();
                        break;
                }
                    
                this.Text = this.Text+" "+ Info.Nom_Archivo;
                txtBanco.Text = Info.nom_banco; 
                txtProceso.Text = Info.nom_proceso_bancario;
                txtMotivo.Text = Info.nom_MotivoArchivo;

                gridViewArchivo_Det.ViewCaption = Info.nom_proceso_bancario + " - " + Info.nom_banco;
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

        public void BuscarOP()
        {
            try
            {
                Archivo_Info.Lst_Archivo_Transferencia_Det = new List<ba_Archivo_Transferencia_Det_Info>();
                list = Pagos_Bus.Get_List_orden_pago_con_transferencia(param.IdEmpresa, Archivo_Info.IdArchivo, DateTime.Now, DateTime.Now, param.IdUsuario);
                if (list.Count() == 0)
                {
                    MessageBox.Show("No hay registro para la consulta", param.Nombre_sistema,
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                foreach (var item in list.Where(q => q.Check == true).ToList())
                {
                    ba_Archivo_Transferencia_Det_Info Detalle_Info = new Info.Bancos.ba_Archivo_Transferencia_Det_Info();

                    Detalle_Info.IdOrdenPago = (int)item.IdOrdenPago;
                    Detalle_Info.IdEmpresa = item.IdEmpresa;
                    Detalle_Info.Valor = Convert.ToDecimal(item.Valor_estimado_a_pagar_OP);
                    Detalle_Info.pe_nombreCompleto = item.Nom_Beneficiario;
                    Detalle_Info.fecha_op = item.Fecha_OP;
                    Detalle_Info.IdOrdenPago = Convert.ToInt32(item.IdOrdenPago);
                    Detalle_Info.IdPersona = item.IdPersona;
                    Detalle_Info.Observacion_op = item.Observacion;
                    Detalle_Info.Estado_OP = item.IdEstadoAprobacion;
                    Detalle_Info.IdEmpresa_OP = item.IdEmpresa;
                    Detalle_Info.Secuencia_OP = (int)item.Secuencia_OP;
                    Detalle_Info.IdTipo_Persona = item.IdTipoPersona;
                    Detalle_Info.Estado_Transferencia = item.Estado_Transferencia;
                    Detalle_Info.IdTipo_Persona = item.IdTipoPersona;
                    Detalle_Info.IdEntidad = Convert.ToInt32(item.IdEntidad);
                    //Detalle_Info.nom_banco_destino = item.Beneficiario.ba_descripcion;
                    Detalle_Info.pe_cedulaRuc = item.Beneficiario.pe_cedulaRuc;
                    Detalle_Info.num_cta_acreditacion = item.Beneficiario.num_cta_acreditacion;
                    Detalle_Info.IdTipoCta_acreditacion_cat = item.Beneficiario.IdTipoCta_acreditacion_cat;
                    Detalle_Info.IdTipoDocumento = item.Beneficiario.IdTipoDocumento;
                    Detalle_Info.CodigoLegal = item.Beneficiario.CodigoLegal;
                    Detalle_Info.Referencia = item.Referencia2;
                    //Detalle_Info.IdBanco_cta_Destino_trans = item.IdBanco_acreditacion;
                    Detalle_Info.check = item.Check;
                    Detalle_Info.IdEmpresa_mvba = item.IdEmpresa_pago;
                    Detalle_Info.IdTipocbte_mvba = item.IdTipoCbte_pago;
                    Detalle_Info.IdCbteCble_pago = item.IdCbteCble_pago;
                    Detalle_Info.tipo_cbte_pago = item.tipo_cbte_pago;
                    Detalle_Info.Secuencial_reg_x_proceso = item.Secuencial_reg_x_proceso;

                    Archivo_Info.Lst_Archivo_Transferencia_Det.Add(Detalle_Info);                    
                }
                gridControlArchivo_Det.DataSource = Archivo_Info.Lst_Archivo_Transferencia_Det.OrderBy(q=>q.pe_nombreCompleto);
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.gridControlArchivo_Det.ShowPrintPreview();
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

        private void FrmBA_Archivo_Transferencia_Det_Load(object sender, EventArgs e)
        {

        }

        private void btn_agrupar_x_beneficiario_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btn_agrupar_x_beneficiario.Text)
                {
                    case "Agrupar por beneficiario":
                        btn_agrupar_x_beneficiario.Text = "Eliminar agrupación";
                        colBeneficiario.GroupIndex = 1;
                        break;
                    default:
                        btn_agrupar_x_beneficiario.Text = "Agrupar por beneficiario";
                        colBeneficiario.GroupIndex = -1;
                        break;
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

        
    }
}
