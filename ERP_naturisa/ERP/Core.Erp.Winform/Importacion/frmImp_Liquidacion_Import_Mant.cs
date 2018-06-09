using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.Importacion;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;


using Core.Erp.Winform.Contabilidad;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxPagar;
namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_Liquidacion_Import_Mant : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public frmImp_Liquidacion_Import_Mant()
        {
            try
            {
                InitializeComponent();
                tip = Data_parametros.Get_Info_Parametros(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        decimal IdCbteLiquidacion=0;
        imp_ordencompra_ext_Bus BUS = new imp_ordencompra_ext_Bus();
        ct_cbtecble_Reversado_Bus BusReverso = new ct_cbtecble_Reversado_Bus();
        imp_ordencompra_ext_x_ct_cbtecble_Bus BusOrdxCbt = new imp_ordencompra_ext_x_ct_cbtecble_Bus();
        imp_Parametros_Bus Data_parametros = new imp_Parametros_Bus();
        imp_OrdenCompraExterna_Liquidacion_Bus BusComprobantes = new imp_OrdenCompraExterna_Liquidacion_Bus();
        ct_Cbtecble_Bus Buscbte = new ct_Cbtecble_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        imp_ordencompra_ext_Bus BusImportacion = new imp_ordencompra_ext_Bus();
        public imp_ordencompra_ext_Info Obj { get; set; }
        imp_Parametros_Info tip = new imp_Parametros_Info();
        in_Parametro_Bus bus_In_Parametros = new in_Parametro_Bus();
        string MensajeError = "";



        public void SetInfo()
        {
            try
            {
                txtCFR.Text = Obj.CFR.ToString().Trim();
                txtCodiImportacion2.Text = Obj.CodOrdenCompraExt.Trim();
                txtCodImportacion.Text = Obj.CodOrdenCompraExt.Trim();
                txtFacturaProveedor.Text = Obj.NumFacturaProvedor.ToString().Trim();
                TxtFlete.Text = Obj.ci_costo_Flete_externo.ToString().Trim();
                txtTonelada.Text = Obj.ci_tonelaje.ToString().Trim();
                txtTotal.Text = Obj.FOB.ToString().Trim();
                txtProveedor.Text = Obj.Proveedor.Trim();
                txtObservacion.Text = Obj.ci_Observacion.Trim();
           
                txtObservacion.ReadOnly = true;
                //ultraGridDiarios.DataSource = BUS.consultaDiariosxImportacion(param.IdEmpresa, Obj.IdSucusal, Obj.IdOrdenCompraExt);
                gridControlLiquidacion.DataSource = BusComprobantes.Get_List_LiquidacionImportacion(param.IdEmpresa, Obj.IdSucusal, Obj.IdOrdenCompraExt);

                var DiarioFob = BusImportacion.Get_List_DiariosxImportacion(param.IdEmpresa, Obj.IdSucusal, Obj.IdOrdenCompraExt).First(var => var.TipoReg == "FOB");
                var Cobte = Buscbte.Get_Info_CbteCble(param.IdEmpresa, DiarioFob.ct_IdTipoCbte, DiarioFob.IdCbte, ref MensajeError);
                txtIdCbteCbl.Text = Cobte.CodCbteCble.ToString();

                var DiarioLiqui = BusImportacion.Get_List_DiariosxImportacion(param.IdEmpresa, Obj.IdSucusal, Obj.IdOrdenCompraExt).Last(var => var.TipoReg == "LQUI");
                var CobteLiquidacion = Buscbte.Get_Info_CbteCble(param.IdEmpresa, DiarioLiqui.ct_IdTipoCbte, DiarioLiqui.IdCbte, ref MensajeError);
                
                txtDiarioLiquidacion.Text = CobteLiquidacion.CodCbteCble.ToString();
                if (Obj.IdEstadoLiquidacion == "Liquidado")
                {
                    lblLiquidado.Visible = true;
                }

                var Diario_Reverso = BusReverso.Get_Info_cbtecble_Reversado(param.IdEmpresa, DiarioLiqui.ct_IdTipoCbte, DiarioLiqui.IdCbte);
                if (Diario_Reverso.IdTipoCbte_Anu != 0)
                {
                    var CobteLiquidacionAnulado = Buscbte.Get_Info_CbteCble(param.IdEmpresa, Diario_Reverso.IdTipoCbte_Anu, Diario_Reverso.IdCbteCble_Anu, ref MensajeError);
                    lblAnulado.Visible = true;
                    lblAnulado.Text = "**Anulado ** Reversado Con diario" + "\n" + CobteLiquidacionAnulado.CodCbteCble;
                    btnAnular.Enabled = false;
                }
                                      
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        double TotGastos = 0;
        private void frmImp_Liquidacion_Load(object sender, EventArgs e)
        {
            try
            {
                SetInfo();
                              
                if (txtTonelada.Text != "" && Convert.ToDouble(txtTonelada.Text) !=0)
                {
                    txtTotalLiquidacion.Text = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal((colValor.SummaryText=="")?"0":colValor.SummaryText)).ToString();                                      
                    txtTotalTonelaje.Text = Math.Round((Convert.ToDecimal(txtTotalLiquidacion.Text) / Convert.ToDecimal(txtTonelada.Text)), 2).ToString();
                    txtTotalNacionala.Text = colValor.SummaryText;

                   // TotGastos = Convert.ToDouble(txtTotalNacionala.Text);
                    Obj.TotGastosImp = Convert.ToDouble(txtTotalNacionala.Text);
                    Obj.TotalLiquidacion = Convert.ToDouble(txtTotalLiquidacion.Text);

                    txtUsdNacionalizacion.Text = Math.Round((Convert.ToDecimal(colValor.SummaryText) / Convert.ToDecimal(txtTonelada.Text)), 2).ToString();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 MessageBox.Show(colValor.SummaryText);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        string mensaje = "";


        Cl_Enumeradores.eTipo_action accion = new Cl_Enumeradores.eTipo_action();

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            try
            {
                Liquidar_Importacion();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void Liquidar_Importacion()
        {
            try
            {
                accion = Cl_Enumeradores.eTipo_action.grabar;

                if (txtDiarioLiquidacion.Text != "" && lblAnulado.Visible == false)
                {
                    MessageBox.Show("La importación Ya se encuentra Liquidada");
                    return;
                }

                if (txtIdCbteCbl.Text == "")
                {
                    MessageBox.Show("Falta Diario FOB No se puede Realizar Liquidación");
                    return;
                }

                var Gasto = (List<vwImp_LiquidacionImportacion_Info>)gridControlLiquidacion.DataSource;
                string Diarios = "";
                Boolean valido = true;
                foreach (var item in Gasto)
                {
                    if (item.CodCbteCble == null)
                    {
                        Diarios += "," + item.ga_decripcion;
                        valido = false;
                    }
                }
                if (!valido)
                {
                    MessageBox.Show("Falta Diario Contable En los Siguientes Gastos" + Diarios, "Mensaje ERP");
                    return;
                }


                cp_proveedor_Bus _Prove_D = new cp_proveedor_Bus();
                var proveedor = _Prove_D.Get_Info_Proveedor(param.IdEmpresa, Obj.IdProveedor);

                if (MessageBox.Show("¿Está seguro que desea Realizar La Liquidación de la Importación  " + txtCodImportacion.Text + "?", "Mensaje ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Obj.ci_fecha_liquidacion = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                    Obj.Fecha_Transac = Convert.ToDateTime(param.Fecha_Transac.ToShortDateString());
                    Obj.IdEstadoLiquidacion = "LIQDADO";
                    //  if (BusImportacion.Liquidar(param.IdEmpresa, Obj.IdSucusal, Obj.IdOrdenCompraExt, Convert.ToDateTime(param.Fecha_Transac.ToShortDateString()), "LIQDADO"))
                    if (BusImportacion.Liquidar(Obj, ref  mensaje, accion))
                    {
                        if (mensaje != "")
                        {
                            MessageBox.Show(mensaje, "Sistemas");
                        }
                        else
                        { MessageBox.Show("Operación Realizada Con Exito", "Mensaje ERP"); }

                        txtDiarioLiquidacion.Text = Obj.CodCbteCble;
                        lblAnulado.Visible = false;
                        btnAnular.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }                   
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                imp_rpt_Liquidacion_Info InfoRpt = new imp_rpt_Liquidacion_Info();
                InfoRpt.CFR = Convert.ToDouble(txtCFR.Text);
                InfoRpt.DiarioCompra = txtIdCbteCbl.Text;
                InfoRpt.DiarioLiquidacion = txtDiarioLiquidacion.Text;
                InfoRpt.FacturaProveedor = txtFacturaProveedor.Text;
                InfoRpt.Flete = Convert.ToDouble(TxtFlete.Text);
                InfoRpt.IdInterno = txtCodiImportacion2.Text;
                InfoRpt.Importacion = txtCodImportacion.Text;
                List<vwImp_LiquidacionImportacion_Info> Gasto = (List<vwImp_LiquidacionImportacion_Info>)gridControlLiquidacion.DataSource;
                InfoRpt.ListaDetalle = Gasto;
                InfoRpt.Llegada = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                InfoRpt.Observacion = txtObservacion.Text;
                InfoRpt.Proveedor = txtProveedor.Text;
                InfoRpt.Tonelada = Convert.ToDouble(txtTonelada.Text);
                InfoRpt.Total = Convert.ToDouble(txtTotal.Text);
                InfoRpt.totalImportacion = Convert.ToDouble(txtTotalLiquidacion.Text);
                InfoRpt.TotalNacionalizacion = Convert.ToDouble(txtTotalNacionala.Text);
                InfoRpt.usdImportacion = Convert.ToDouble(txtTotalTonelaje.Text);
                InfoRpt.USDNacionalizacion = Convert.ToDouble(txtUsdNacionalizacion.Text);
                InfoRpt.InfoEmpresa = param.InfoEmpresa;
                
                List<imp_rpt_Liquidacion_Info> lstReport = new List<imp_rpt_Liquidacion_Info>();
                lstReport.Add(InfoRpt);
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }


        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            try
            {
                Anular_Liquidacion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               
            }
            
        }


        void Anular_Liquidacion()
        {
            try
            {
                accion = Cl_Enumeradores.eTipo_action.Anular;

                if (MessageBox.Show("Está Seguro que desea Anular la Liquidación ?", "Anulación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (txtDiarioLiquidacion.Text == "")
                    {
                        MessageBox.Show("No se puede anular ya que no tiene un diario de liquidación");
                        return;
                    }

                    string motiAnulacion = "";
                    FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                    fr.ShowDialog();
                    motiAnulacion = fr.motivoAnulacion;

                    Obj.motiAnulacion = motiAnulacion;
                    Obj.Fecha_Transac = Convert.ToDateTime(param.Fecha_Transac.ToShortDateString());
                    Obj.IdEstadoLiquidacion = "XLQDAR";
                    BusImportacion.Liquidar(Obj, ref  mensaje, accion);

                    if (Obj.msgAnuladoReverso != "")
                    {
                        lblAnulado.Visible = true;
                        lblAnulado.Text = Obj.msgAnuladoReverso;
                        btnAnular.Enabled = false;
                        lblAnulado.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }              
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                 Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.ToString() == "46")
                    gridView1.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


    }
}
