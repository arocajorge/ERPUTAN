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
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;
using Cus.Erp.Reports.FJ.Facturacion;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars;
namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmfa_liquidaciones_Mant : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_liquidaciones_Info liquidaciones_info = new fa_liquidaciones_Info();
        fa_liquidaciones_Bus liquidaciones_bus = new fa_liquidaciones_Bus();
        List<fa_liquidaciones_det_Info> lista_liquidaciones = new List<fa_liquidaciones_det_Info>();

        List<fa_liquidacion_gastos_Info> lista_liquidaciones_gastos = new List<fa_liquidacion_gastos_Info>();
        fa_liquidacion_gastos_Bus liquidaciones_gastos_bus = new fa_liquidacion_gastos_Bus();
        fa_liquidacion_gastos_Info liquidacion_gasto_info;
        ct_Periodo_Info periodo_info = new ct_Periodo_Info();
        decimal id_factura;
        string mensajeError = "";
        decimal Idcliente = 0;
        double fee = 0;
        fa_tarifario_facturacion_x_cliente_Por_comision_Bus bus_margen_ganancia = new fa_tarifario_facturacion_x_cliente_Por_comision_Bus();


        public frmfa_liquidaciones_Mant()
        {
            InitializeComponent();
            ucFa_Cliente.Cargar_combos();
        }


       


       
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmfa_liquidacion_gastos_Mant frm = new frmfa_liquidacion_gastos_Mant();
                frm.MdiParent = this.MdiParent;
                frm.Set_Accion ( Cl_Enumeradores.eTipo_action.actualizar);
                frm.Show();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmfa_liquidaciones_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                de_Fecha.EditValue = DateTime.Now;

                cargar_datos();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cargar_datos()
        {
            try
            {
                cmb_periodo.Cargar_combos();
                cmb_facturacion_catalogo.cargar_Catalogos(10);
            }
            catch (Exception ex)
            {
                
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_periodo_event_delegate_cmb_Periodo_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                 periodo_info = cmb_periodo.Get_Periodo_Info();
                 buscar_liquidaciones();
                 Set();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmfa_liquidacion_gastos_Mant frm = new frmfa_liquidacion_gastos_Mant();
                frm.MdiParent = this.MdiParent;
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                buscar_liquidaciones();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (liquidacion_gasto_info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frmfa_liquidacion_gastos_Mant frm = new frmfa_liquidacion_gastos_Mant();
                frm.MdiParent = this.MdiParent;
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                frm.Set_Info(liquidacion_gasto_info);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                buscar_liquidaciones();

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
     
        private void gridView_detalleGastos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                liquidacion_gasto_info = new fa_liquidacion_gastos_Info();
                liquidacion_gasto_info = (fa_liquidacion_gastos_Info)gridView_detalleGastos.GetFocusedRow();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (liquidacion_gasto_info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frmfa_liquidacion_gastos_Mant frm = new frmfa_liquidacion_gastos_Mant();
                frm.MdiParent = this.MdiParent;
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void buscar_liquidaciones()
        {
            try
            {
                lista_liquidaciones_gastos = liquidaciones_gastos_bus.Get_List_Liquidacion_Gastos_x_periodo(param.IdEmpresa, cmb_periodo.Get_Periodo_Info().IdPeriodo);
                gridControlDetalle_Gastos.DataSource = lista_liquidaciones_gastos;
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

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (liquidaciones_bus.Procesar_Liquidaciones(param.IdEmpresa, periodo_info.IdPeriodo, periodo_info.pe_FechaIni, periodo_info.pe_FechaFin))
                    MessageBox.Show("Proceso ok", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudieron procesar los datos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                buscar_liquidaciones();
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
                lista_liquidaciones = new List<fa_liquidaciones_det_Info>();


                liquidaciones_info.IdEmpresa = param.IdEmpresa;
                if (txtid_liquidaciones.EditValue != null)
                {
                    liquidaciones_info.IdLiquidaciones = Convert.ToDecimal(txtid_liquidaciones.EditValue);
                }
                liquidaciones_info.IdPeriodo = periodo_info.IdPeriodo;
                liquidaciones_info.fecha =Convert.ToDateTime( de_Fecha.EditValue);
                liquidaciones_info.Observacion = txt_Observacion.Text;
                liquidaciones_info.Estado_Proceso = cmb_facturacion_catalogo.get_CatalogosInfo().IdCatalogo;
                liquidaciones_info.Estado = true;
                liquidaciones_info.Fecha_Transaccion = DateTime.Now;
                foreach (var item in lista_liquidaciones_gastos)
                {
                    fa_liquidaciones_det_Info info = new fa_liquidaciones_det_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdEmpresa_liqui_gastos = item.IdEmpresa;
                    info.IdLiquidacion_liqui_gastos =Convert.ToInt32(item.IdLiquidacion);
                    lista_liquidaciones.Add(info);
                    
                }
                liquidaciones_info.lista = lista_liquidaciones;

            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public bool Grabar()
        {
            try
            {
                Get();
                return liquidaciones_bus.GuardarDB(liquidaciones_info);
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
                if (Grabar())
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void btn_Facturar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in lista_liquidaciones_gastos)
                {
                    liquidaciones_gastos_bus.Convert_Liquidacion_a_Factura(item.IdEmpresa, item.IdLiquidacion, ref id_factura,ref mensajeError);
                }
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        private void Set()
        {
            try
            {
              liquidaciones_info=  liquidaciones_bus.Get_liquidaciones_info(param.IdEmpresa, periodo_info.IdPeriodo);
              txt_Observacion.Text = liquidaciones_info.Observacion;
              de_Fecha.EditValue = liquidaciones_info.fecha;
              txtid_liquidaciones.EditValue = liquidaciones_info.IdLiquidaciones;
              cmb_facturacion_catalogo.set_CatalogosInfo(liquidaciones_info.Estado_Proceso);

            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                fa_cliente_x_ct_centro_costo_Info info = new fa_cliente_x_ct_centro_costo_Info();
                info = ucFa_Cliente.Get_Info_Cliente_x_Centro_costo();
                fee = bus_margen_ganancia.Get_Fee(param.IdEmpresa, periodo_info.IdanioFiscal, info.IdCliente_cli);
                Idcliente = ucFa_Cliente.Get_Info_Centro_costo().IdCliente_cli;
        
                switch (param.IdCliente_Ven_x_Default)
                {
                    
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                     XFAC_FJ_Rpt004_Rpt Reporte4 = new XFAC_FJ_Rpt004_Rpt();
                    foreach (var item in lista_liquidaciones_gastos)
                    {
                        item.Periodo = "Periodo " + periodo_info.smes + " " + periodo_info.IdanioFiscal; ;
                    }
                    Reporte4.Set(lista_liquidaciones_gastos);
                    Reporte4.CreateDocument();
                    Reporte4.ShowPreview();




                    // imprimir resume por subcentro 
                    XFAC_FJ_Rpt006_Rpt reporte6 = new XFAC_FJ_Rpt006_Rpt();
                    reporte6.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                    reporte6.Parameters["IdPeriodo"].Value = periodo_info.IdPeriodo;
                    reporte6.Parameters["Mes"].Value = periodo_info.smes + " " + periodo_info.IdanioFiscal;
                    reporte6.Parameters["fee"].Value = periodo_info.smes;

                    reporte6.CreateDocument();
                    reporte6.ShowPreview();



                    // imprimir resume por subcentro 
                    XFAC_FJ_Rpt007_Rpt reporte_mo = new XFAC_FJ_Rpt007_Rpt();
                    reporte_mo.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                    reporte_mo.Parameters["IdPeriodo"].Value = periodo_info.IdPeriodo;
                    reporte_mo.Parameters["Periodo"].Value = periodo_info.smes + " " + periodo_info.IdanioFiscal;
                    reporte_mo.Parameters["fee"].Value = periodo_info.smes;

                    reporte_mo.Parameters["Anio"].Value = periodo_info.IdanioFiscal;
                    reporte_mo.Parameters["Mes"].Value = periodo_info.pe_mes;

                    reporte_mo.CreateDocument();
                    reporte_mo.ShowPreview();
                        break;                    
                    case Cl_Enumeradores.eCliente_Vzen.TRANSGANDIA:

                        // imprimir mano de obra
                        XFAC_FJ_Rpt008_Rpt reporte_mo_tra = new XFAC_FJ_Rpt008_Rpt();
                        reporte_mo_tra.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                        reporte_mo_tra.Parameters["IdPeriodo"].Value = periodo_info.IdPeriodo;
                        reporte_mo_tra.Parameters["Periodo"].Value = periodo_info.smes + " " + periodo_info.IdanioFiscal;
                        reporte_mo_tra.Parameters["fee"].Value = periodo_info.smes;

                        reporte_mo_tra.Parameters["Anio"].Value = periodo_info.IdanioFiscal;
                        reporte_mo_tra.Parameters["Mes"].Value = periodo_info.pe_mes;

                        reporte_mo_tra.CreateDocument();
                        reporte_mo_tra.ShowPreview();


                        // imprimir depreciacion
                        XFAC_FJ_Rpt009_Rpt reporte_Depreciacion = new XFAC_FJ_Rpt009_Rpt();
                        reporte_Depreciacion.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                        reporte_Depreciacion.Parameters["IdPeriodo"].Value = periodo_info.IdPeriodo;
                        reporte_Depreciacion.Parameters["Anio"].Value = periodo_info.IdanioFiscal;
                        reporte_Depreciacion.Parameters["IdCliente"].Value = ucFa_Cliente.Get_Info_Cliente_x_Centro_costo().IdCliente_cli;              
                        reporte_Depreciacion.CreateDocument();
                        reporte_Depreciacion.ShowPreview();


                        // imprimir gastos
                        XFAC_FJ_Rpt010_Rpt reporte_gasto = new XFAC_FJ_Rpt010_Rpt();
                        reporte_gasto.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                        reporte_gasto.Parameters["IdPeriodo"].Value = periodo_info.IdPeriodo;
                        reporte_gasto.Parameters["Anio"].Value = periodo_info.IdanioFiscal;
                        reporte_gasto.Parameters["IdCliente"].Value = ucFa_Cliente.Get_Info_Cliente_x_Centro_costo().IdCliente_cli;
                        reporte_gasto.CreateDocument();
                        reporte_gasto.ShowPreview();





                        XFAC_FJ_Rpt004_Rpt Reporte_liq = new XFAC_FJ_Rpt004_Rpt();
                        foreach (var item in lista_liquidaciones_gastos)
                        {
                            item.Periodo = "Periodo " + periodo_info.smes + " " + periodo_info.IdanioFiscal; ;
                        }
                        Reporte_liq.Set(lista_liquidaciones_gastos);
                        Reporte_liq.CreateDocument();
                        Reporte_liq.ShowPreview();



                        // impremision de tabla de amortizacion
                        XFAC_FJ_Rpt012_Rpt Reporte_Interes = new XFAC_FJ_Rpt012_Rpt();
                        Reporte_Interes.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                        Reporte_Interes.Parameters["IdPeriodo"].Value = periodo_info.IdPeriodo;
                        
                        Reporte_Interes.CreateDocument();
                        Reporte_Interes.ShowPreview();


                        // impresion de seguro
                        XFAC_FJ_Rpt013_Rpt Reporte_Seguro = new XFAC_FJ_Rpt013_Rpt();
                        Reporte_Seguro.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                        Reporte_Seguro.Parameters["IdPeriodo"].Value = periodo_info.IdPeriodo;
                        Reporte_Seguro.Parameters["IdCentroCosto"].Value = ucFa_Cliente.Get_Info_Centro_costo().IdCentroCosto;

                        Reporte_Seguro.CreateDocument();
                        Reporte_Seguro.ShowPreview();


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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                

                XFAC_FJ_Rpt004_Rpt Reporte = new XFAC_FJ_Rpt004_Rpt();
                Reporte.Set(lista_liquidaciones_gastos);
                Reporte.ShowPreview();

            }
            catch (Exception ex)
            {
                
               
            }
        }

       
    }
}
