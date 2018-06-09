using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.Facturacion;
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
using DevExpress.XtraTreeList.Nodes;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Microsoft.Office.Interop.Excel;
using Core.Erp.Winform.General;
namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class FrmFa_PreFacturacion_Mantenimiento : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;

        fa_pre_facturacion_Info info_Pre_facturacion = new fa_pre_facturacion_Info();
        fa_pre_facturacion_Bus bus_Pre_facturacion = new fa_pre_facturacion_Bus();
        List<fa_cliente_x_ct_centro_costo_Info> lst_Cliente_x_Centro_costo = new List<fa_cliente_x_ct_centro_costo_Info>();
        fa_cliente_x_ct_centro_costo_Info info_Cliente_x_Centro_costo = new fa_cliente_x_ct_centro_costo_Info();
        fa_cliente_x_ct_centro_costo_Bus bus_Cliente_x_Centro_costo = new fa_cliente_x_ct_centro_costo_Bus();
        BindingList<Af_Activo_fijo_Info> blst_Activo = new BindingList<Af_Activo_fijo_Info>();
        Af_Activo_fijo_Bus bus_Activo_fijo = new Af_Activo_fijo_Bus();
        // Parametros de prefacturacion
        fa_pre_facturacion_Parametro_Info param_prefacturacion = new fa_pre_facturacion_Parametro_Info();
        fa_pre_facturacion_Parametro_Bus bus_param_prefacturacion = new fa_pre_facturacion_Parametro_Bus();
        //Detalle de egresos
        fa_pre_facturacion_det_egr_x_bod_Bus bus_prefacturacion_det_egr = new fa_pre_facturacion_det_egr_x_bod_Bus();
        BindingList<fa_pre_facturacion_det_egr_x_bod_Info> blst_prefacturacion_det_egr = new BindingList<fa_pre_facturacion_det_egr_x_bod_Info>();
        //Detalle de poliza
        fa_pre_facturacion_det_cobro_x_Poliza_Bus bus_prefacturacion_det_poliza = new fa_pre_facturacion_det_cobro_x_Poliza_Bus();
        BindingList<fa_pre_facturacion_det_cobro_x_Poliza_Info> blst_prefacturacion_det_poliza = new BindingList<fa_pre_facturacion_det_cobro_x_Poliza_Info>();
        //Detalle de gasto x facturas
        fa_pre_facturacion_det_Fact_x_Gastos_Bus bus_prefacturacion_det_fact_x_gastos = new fa_pre_facturacion_det_Fact_x_Gastos_Bus();
        BindingList<fa_pre_facturacion_det_Fact_x_Gastos_Info> blst_prefacturacion_det_fact_x_gastos = new BindingList<fa_pre_facturacion_det_Fact_x_Gastos_Info>();
        //Detalle de Movilizacion
        fa_pre_facturacion_det_cobro_x_Movilizacion_Bus bus_prefacturacion_det_movilizacion = new fa_pre_facturacion_det_cobro_x_Movilizacion_Bus();
        BindingList<fa_pre_facturacion_det_cobro_x_Movilizacion_Info> blst_prefacturacion_det_Movilizacion = new BindingList<fa_pre_facturacion_det_cobro_x_Movilizacion_Info>();
        //Detalle de Unidades
        fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Bus bus_prefacturacion_det_unidades = new fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Bus();
        BindingList<fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info> blst_prefacturacion_det_Unidades = new BindingList<fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info>();
        //Detalle de depreciacion
        fa_pre_facturacion_det_Cobro_x_Depreciacion_Bus bus_prefacturacion_det_depreciacion = new fa_pre_facturacion_det_Cobro_x_Depreciacion_Bus();
        BindingList<fa_pre_facturacion_det_Cobro_x_Depreciacion_Info> blst_prefacturacion_det_Depreciacion = new BindingList<fa_pre_facturacion_det_Cobro_x_Depreciacion_Info>();
        //Parametros de prefacturacion
        fa_pre_facturacion_Parametro_Info info_prefacturacion_param = new fa_pre_facturacion_Parametro_Info();
        fa_pre_facturacion_Parametro_Bus bus_prefacturacion_param = new fa_pre_facturacion_Parametro_Bus();
        // DETALLE DE MANO DE OBRA

        List<fa_pre_facturacion_det_gasto_mano_obra_Info> lista_mano_obra = new List<fa_pre_facturacion_det_gasto_mano_obra_Info>();
        fa_pre_facturacion_det_gasto_mano_obra_Bus bus_mano_obra = new fa_pre_facturacion_det_gasto_mano_obra_Bus();


        //Detalle de otros

        BindingList<fa_pre_facturacion_det_Otros_Info> lista_otros = new BindingList<fa_pre_facturacion_det_Otros_Info>();
        fa_pre_facturacion_det_Otros_Bus bus_otros = new fa_pre_facturacion_det_Otros_Bus();




        //Detalle de otros

        BindingList<fa_pre_facturacion_det_gasto_Interes_Banc_Info> lista_intereses = new BindingList<fa_pre_facturacion_det_gasto_Interes_Banc_Info>();
        fa_pre_facturacion_det_gasto_Interes_Banc_Bus bus_Intereses = new fa_pre_facturacion_det_gasto_Interes_Banc_Bus();

        #endregion

        #region variablesExcel
                  Microsoft.Office.Interop.Excel.Application app = null;
                 Microsoft.Office.Interop.Excel.Workbook workbook = null;
                 Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                 Microsoft.Office.Interop.Excel.Range workSheet_range = null;
#endregion

        public FrmFa_PreFacturacion_Mantenimiento()
        {
            InitializeComponent();
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucCon_Periodo1.event_delegate_cmb_Periodo_EditValueChanged += ucCon_Periodo1_event_delegate_cmb_Periodo_EditValueChanged;
        }

        void ucCon_Periodo1_event_delegate_cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Accion==Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (ucCon_Periodo1.Get_Periodo_Info() != null)
                    {
                        int IdPeriodo = 0;
                        IdPeriodo = ucCon_Periodo1.Get_Periodo_Info().IdPeriodo;
                        info_Pre_facturacion = bus_Pre_facturacion.Get_Info_x_periodo(param.IdEmpresa, IdPeriodo);
                        if (info_Pre_facturacion.IdPreFacturacion != 0)
                        {
                            if (MessageBox.Show("Ya existe una prefacturación para este periodo, ¿Desea cargarla?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                Cargar_Prefacturación();
                        }
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

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (AnularDB())
                {
                    lblAnulado.Visible = true;
                    ucGe_Menu.Visible_bntAnular = false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
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
                if (Grabar())
                    this.Close();                
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
                if (Grabar())
                    Limpiar();
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

        public void Set_Info(fa_pre_facturacion_Info info)
        {
            try
            {
                info_Pre_facturacion = info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Iniciar_treelist()
        {
            try
            {
                TreeListNode nodeTodos;
                TreeListNode nodeCliente;
                lst_Cliente_x_Centro_costo = bus_Cliente_x_Centro_costo.Get_Vista_Clientes_x_Centro_costo(param.IdEmpresa);
                if (lst_Cliente_x_Centro_costo.Count!=0)
                {
                    tlClientes.BeginUnboundLoad();
                    fa_cliente_x_ct_centro_costo_Info info = new fa_cliente_x_ct_centro_costo_Info();
                    info.nom_Cliente = "Todos";

                    nodeTodos = tlClientes.AppendNode(new object[] { info.nom_Cliente, info }, null);
                    nodeTodos.HasChildren = true;
                    nodeTodos.Tag = info;
                    foreach (var item in lst_Cliente_x_Centro_costo)
                    {
                        nodeCliente = tlClientes.AppendNode(new object[] { item.nom_Cliente, item }, nodeTodos);
                        nodeCliente.HasChildren = false;
                        nodeCliente.Tag = item;
                    }
                    tlClientes.ExpandAll();
                    tlClientes.EndUnboundLoad();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Cargar_Combos()
        {
            try
            {
                de_Fecha.EditValue = DateTime.Now;

                ucCon_Periodo1.Cargar_combos();

                ucFa_CatalogosCmb1.cargar_Catalogos(10);//10 - Estado de facturación
                ucFa_CatalogosCmb1.set_CatalogosInfo("EST_FAC_PENDI");
                ucFa_CatalogosCmb1.Perfil_Lectura();

                blst_Activo = new BindingList<Af_Activo_fijo_Info>(bus_Activo_fijo.Get_List_Vista_Af(param.IdEmpresa));
                gridControlActivos.DataSource = blst_Activo;

                gridControlEgresos_bodega.DataSource = blst_prefacturacion_det_egr;
                gridControlPoliza.DataSource = blst_prefacturacion_det_poliza;
                gridControlGastos.DataSource = blst_prefacturacion_det_fact_x_gastos;
                gridControlMovilizacion.DataSource = blst_prefacturacion_det_Movilizacion;

                Iniciar_treelist();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmFa_PreFacturacion_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl_mano_obra.DataSource = lista_otros;
                Cargar_Combos();
                Set_Controles();
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
                if (ucCon_Periodo1.Get_Periodo_Info()==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " periodo a pre-facturar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }                
                if (de_Fecha.EditValue==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " fecha", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (ucFa_CatalogosCmb1.get_CatalogosInfo()==null || ucFa_CatalogosCmb1.get_CatalogosInfo().IdCatalogo=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " estado de facturación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (Procesar_Pre_facturacion())
                    {
                        splashScreenManagereEspera.ShowWaitForm();
                        
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        splashScreenManagereEspera.CloseWaitForm();
                        MessageBox.Show("Proceso ok", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                       

                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                splashScreenManagereEspera.CloseWaitForm();
            }
        }

        private void Cargar_Prefacturación()
        {
            try
            {
                txt_IdPreFacturacion.Text = info_Pre_facturacion.IdPreFacturacion.ToString();
                //Carga detalle de egresos
                info_Pre_facturacion.lst_det_egr_x_bod = bus_prefacturacion_det_egr.Get_List(info_Pre_facturacion);                
                blst_prefacturacion_det_egr = new BindingList<fa_pre_facturacion_det_egr_x_bod_Info>(info_Pre_facturacion.lst_det_egr_x_bod);
                gridControlEgresos_bodega.DataSource = blst_prefacturacion_det_egr;
                //Carga detalle de poliza
                info_Pre_facturacion.lst_det_poliza = bus_prefacturacion_det_poliza.Get_List(info_Pre_facturacion.IdEmpresa, info_Pre_facturacion.IdPreFacturacion);
                blst_prefacturacion_det_poliza = new BindingList<fa_pre_facturacion_det_cobro_x_Poliza_Info>(info_Pre_facturacion.lst_det_poliza);
                gridControlPoliza.DataSource = blst_prefacturacion_det_poliza;
                //Carga detalle de gastos x factura
                info_Pre_facturacion.lst_det_fact = bus_prefacturacion_det_fact_x_gastos.Get_List(info_Pre_facturacion.IdEmpresa, info_Pre_facturacion.IdPreFacturacion);
                blst_prefacturacion_det_fact_x_gastos = new BindingList<fa_pre_facturacion_det_Fact_x_Gastos_Info>(info_Pre_facturacion.lst_det_fact);
                gridControlGastos.DataSource = blst_prefacturacion_det_fact_x_gastos;
                //Carga detalle de movilizacion
                info_Pre_facturacion.lst_det_Movi =bus_prefacturacion_det_movilizacion.Get_List(info_Pre_facturacion.IdEmpresa, info_Pre_facturacion.IdPreFacturacion);
                blst_prefacturacion_det_Movilizacion = new BindingList<fa_pre_facturacion_det_cobro_x_Movilizacion_Info>(info_Pre_facturacion.lst_det_Movi);
                gridControlMovilizacion.DataSource = blst_prefacturacion_det_Movilizacion;
                //Carga detalle de unidades
                info_Pre_facturacion.lst_det_Unidades = bus_prefacturacion_det_unidades.Get_List(info_Pre_facturacion.IdEmpresa, info_Pre_facturacion.IdPreFacturacion);
                blst_prefacturacion_det_Unidades = new BindingList<fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info>(info_Pre_facturacion.lst_det_Unidades);
                gridControlMarcaciones.DataSource = blst_prefacturacion_det_Unidades;
                //Carga detalle de depreciacion
                info_Pre_facturacion.lst_det_Depreciacion = bus_prefacturacion_det_depreciacion.Get_List(info_Pre_facturacion.IdEmpresa, info_Pre_facturacion.IdPreFacturacion);
                blst_prefacturacion_det_Depreciacion = new BindingList<fa_pre_facturacion_det_Cobro_x_Depreciacion_Info>(info_Pre_facturacion.lst_det_Depreciacion);
                gridControlDepreciacion.DataSource = blst_prefacturacion_det_Depreciacion;

                // cargar mano de obra
                lista_mano_obra = bus_mano_obra.Get_List(param.IdEmpresa, info_Pre_facturacion.IdPreFacturacion, ucCon_Periodo1.Get_Periodo_Info().pe_FechaIni);
                gridControl_mano_obra.DataSource = lista_mano_obra;

                // cargar otros

                lista_otros =new BindingList<fa_pre_facturacion_det_Otros_Info>( bus_otros.Get_Lids(param.IdEmpresa,Convert.ToInt32( info_Pre_facturacion.IdPreFacturacion)));
                gridControl_otros.DataSource=lista_otros;

                // cargar otros

                lista_intereses = new BindingList<fa_pre_facturacion_det_gasto_Interes_Banc_Info>(bus_Intereses.Get_List(param.IdEmpresa, Convert.ToInt32(info_Pre_facturacion.IdPreFacturacion)));
                gridControl_Intereses.DataSource = lista_intereses; 


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean Procesar_Pre_facturacion()
        {
            try
            {
                Get_Pre_facturacion();
                info_Pre_facturacion.IdPreFacturacion = bus_Pre_facturacion.PreFacturar_x_periodo(info_Pre_facturacion);

                if (info_Pre_facturacion.IdPreFacturacion != 0)
                {
                   bus_prefacturacion_det_egr.Procesar_egresos(info_Pre_facturacion.IdEmpresa, info_Pre_facturacion.IdPreFacturacion);
                    Cargar_Prefacturación();
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

        private void Limpiar()
        {
            try
            {
                info_Pre_facturacion = new fa_pre_facturacion_Info();

                txt_IdPreFacturacion.Text = "";
                txt_Observacion.Text = "";
                ucCon_Periodo1.Inicializar_Combos();
                de_Fecha.EditValue = DateTime.Now;
                progressBarControlProceso.EditValue = 0;
                progressBarControlProceso.Update();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }        

        private Boolean Grabar()
        {
            try
            {
                Boolean res = true;
                res = Validar();
                if (res)
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            res = GuardarDB();
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            res = ModificarDB();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            res = AnularDB();
                            break;
                        default:
                            break;
                    }    
                }
                return res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean GuardarDB()
        {
            try
            {
                Get_Pre_facturacion();
                if (bus_Pre_facturacion.ModificarDB(info_Pre_facturacion))
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private Boolean ModificarDB()
        {
            try
            {
                Get_Pre_facturacion();
                if (bus_Pre_facturacion.ModificarDB(info_Pre_facturacion))
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
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

        private Boolean AnularDB()
        {
            try
            {
                Get_Pre_facturacion();
                if (bus_Pre_facturacion.AnularDB(info_Pre_facturacion))
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
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

        private void Set_Pre_facturacion()
        {
            try
            {
                txt_IdPreFacturacion.Text = info_Pre_facturacion.IdPreFacturacion.ToString();
                txt_Observacion.Text = info_Pre_facturacion.Observacion;
                ucCon_Periodo1.Set_Periodo(info_Pre_facturacion.IdPeriodo);
                de_Fecha.EditValue = info_Pre_facturacion.fecha;
                ucFa_CatalogosCmb1.set_CatalogosInfo(info_Pre_facturacion.IdEstado_Proceso);
                if (info_Pre_facturacion.estado == "I")
                    lblAnulado.Visible = true;

                Cargar_Prefacturación();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Get_Pre_facturacion()
        {
            try
            {
                info_Pre_facturacion.IdEmpresa = param.IdEmpresa;
                info_Pre_facturacion.IdPreFacturacion = txt_IdPreFacturacion.Text == "" ? 0 : Convert.ToDecimal(txt_IdPreFacturacion.Text);
                info_Pre_facturacion.fecha = Convert.ToDateTime(de_Fecha.EditValue);
                info_Pre_facturacion.IdPeriodo = ucCon_Periodo1.Get_Periodo_Info().IdPeriodo;
                info_Pre_facturacion.Observacion = txt_Observacion.Text;
                info_Pre_facturacion.IdEstado_Proceso = ucFa_CatalogosCmb1.get_CatalogosInfo().IdCatalogo;

                //Get Detalle de egresos
                info_Pre_facturacion.lst_det_egr_x_bod = new List<fa_pre_facturacion_det_egr_x_bod_Info>(blst_prefacturacion_det_egr);
                //Get Detalle de poliza
                info_Pre_facturacion.lst_det_poliza = new List<fa_pre_facturacion_det_cobro_x_Poliza_Info>(blst_prefacturacion_det_poliza);
                //Get Detalle de gastos x factura 
                info_Pre_facturacion.lst_det_fact = new List<fa_pre_facturacion_det_Fact_x_Gastos_Info>(blst_prefacturacion_det_fact_x_gastos);
                //Get Detalle de movilizacion
                info_Pre_facturacion.lst_det_Movi = new List<fa_pre_facturacion_det_cobro_x_Movilizacion_Info>(blst_prefacturacion_det_Movilizacion);
                //Get Detalle de unidades
                info_Pre_facturacion.lst_det_Unidades = new List<fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info>(blst_prefacturacion_det_Unidades);
                //Get Detalle de depreciacion
                info_Pre_facturacion.lst_det_Depreciacion = new List<fa_pre_facturacion_det_Cobro_x_Depreciacion_Info>(blst_prefacturacion_det_Depreciacion);
                // get detalle otros 
                info_Pre_facturacion.lst_det_Otros = new List<fa_pre_facturacion_det_Otros_Info>(lista_otros);


                // get detalle gastos intereses 
                info_Pre_facturacion.list_Intereses = new List<fa_pre_facturacion_det_gasto_Interes_Banc_Info>(lista_intereses);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void tlClientes_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                info_Cliente_x_Centro_costo = e.Node.Tag as fa_cliente_x_ct_centro_costo_Info;
                if (info_Cliente_x_Centro_costo!=null)
                {
                    Filtrar_grillas();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Filtrar_grillas()
        {
            try
            {
                if (info_Cliente_x_Centro_costo.IdCliente_cli != 0)
                {
                    gridControlEgresos_bodega.DataSource = blst_prefacturacion_det_egr.Where(q => q.IdCliente == info_Cliente_x_Centro_costo.IdCliente_cli);
                    gridControlActivos.DataSource = blst_Activo.Where(q => q.IdCentroCosto == info_Cliente_x_Centro_costo.IdCentroCosto_cc);
                    gridControlPoliza.DataSource = blst_prefacturacion_det_poliza.Where(q => q.IdCliente == info_Cliente_x_Centro_costo.IdCliente_cli);
                    gridControlMovilizacion.DataSource = blst_prefacturacion_det_Movilizacion.Where(q => q.IdCliente_cli == info_Cliente_x_Centro_costo.IdCliente_cli);
                    gridControlMarcaciones.DataSource = blst_prefacturacion_det_Unidades.Where(q => q.IdCliente_cli == info_Cliente_x_Centro_costo.IdCliente_cli);
                    gridControlDepreciacion.DataSource = blst_prefacturacion_det_Depreciacion.Where(q => q.IdCliente_cli == info_Cliente_x_Centro_costo.IdCliente_cli);
                }
                else
                {
                    gridControlEgresos_bodega.DataSource = blst_prefacturacion_det_egr;
                    gridControlPoliza.DataSource = blst_prefacturacion_det_poliza;
                    gridControlGastos.DataSource = blst_prefacturacion_det_fact_x_gastos;
                    gridControlMovilizacion.DataSource = blst_prefacturacion_det_Movilizacion;
                    gridControlDepreciacion.DataSource = blst_prefacturacion_det_Depreciacion;
                    gridControlMarcaciones.DataSource = blst_prefacturacion_det_Unidades;
                }
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
                Mostrar_grillas_x_parametros();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_bntLimpiar = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set_Pre_facturacion();
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_bntLimpiar = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set_Pre_facturacion();
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        btn_Procesar.Enabled = false;
                        
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set_Pre_facturacion();
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        btn_Procesar.Enabled = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        
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

        private void Mostrar_grillas_x_parametros()
        {
            try
            {
                param_prefacturacion = bus_prefacturacion_param.Get_Info(param.IdEmpresa);
                if (param_prefacturacion!=null)
                {
                    if (param_prefacturacion.Se_Cobra_Iva)
                    {
                        colIva_egr.Visible = true;
                        colIva_gas.Visible = true;
                        colIva_mar.Visible = true;
                        colIva_pol.Visible = true;
                    }
                    else
                    {
                        colIva_egr.Visible = false;
                        colIva_gas.Visible = false;
                        colIva_mar.Visible = false;
                        colIva_pol.Visible = false;
                    }
                    switch (param_prefacturacion.Tipo_Cobro_Poliza_X)
                    {
                        case "X_ACTIVO":
                            colCostoUnitario_pol.Visible = true;
                            colSubtotal_pol.Visible = true;
                            colActivo_pol.Visible = true;
                            colEstadoFacturacion.Visible = false;
                            colCodigo_pol.Visible = false;
                            break;
                        case "X_CUOTAS":
                            colCostoUnitario_pol.Visible = false;
                            colEstadoFacturacion.Visible = true;
                            colSubtotal_pol.Visible = false;
                            colActivo_pol.Visible = false;
                            colCodigo_pol.Visible = true;
                            break;
                        default:
                            break;
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

        private void gridViewEgresos_bodega_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_pre_facturacion_det_egr_x_bod_Info row = new fa_pre_facturacion_det_egr_x_bod_Info();
                row = (fa_pre_facturacion_det_egr_x_bod_Info)gridViewEgresos_bodega.GetRow(e.RowHandle);

                if (e.Column == colCantidad_egr || e.Column == colCostoUnitario_egr)
                {
                    gridViewEgresos_bodega.SetFocusedRowCellValue(colSubtotal_egr, row.Cantidad * row.Costo_Uni);
                    if ((bool)row.Aplica_Iva)
                    {
                        gridViewEgresos_bodega.SetFocusedRowCellValue(colIva_egr, row.Subtotal * row.Por_Iva);
                        gridViewEgresos_bodega.SetFocusedRowCellValue(colTotal_egr, row.Subtotal + row.Valor_Iva);
                    }
                    else
                    {
                        gridViewEgresos_bodega.SetFocusedRowCellValue(colTotal_egr, row.Subtotal);
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

        private void gridViewGastos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_pre_facturacion_det_Fact_x_Gastos_Info row = new fa_pre_facturacion_det_Fact_x_Gastos_Info();
                row = (fa_pre_facturacion_det_Fact_x_Gastos_Info)gridViewGastos.GetRow(e.RowHandle);

                if (e.Column == colCantidad_gas || e.Column == colCostoUnitario_gas)
                {
                    gridViewGastos.SetFocusedRowCellValue(colSubtotal_gas, row.Cantidad * row.Costo_Uni);
                    if ((bool)row.Aplica_Iva)
                    {
                        gridViewGastos.SetFocusedRowCellValue(colIva_gas, row.Subtotal * row.Por_Iva);
                        gridViewGastos.SetFocusedRowCellValue(colTotal_gas, row.Subtotal + row.Valor_Iva);
                    }
                    else
                    {
                        gridViewGastos.SetFocusedRowCellValue(colTotal_gas, row.Subtotal);
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

        private void gridViewPoliza_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_pre_facturacion_det_cobro_x_Poliza_Info row = new fa_pre_facturacion_det_cobro_x_Poliza_Info();
                row = (fa_pre_facturacion_det_cobro_x_Poliza_Info)gridViewPoliza.GetRow(e.RowHandle);

                if (e.Column == colCantidad_pol || e.Column == colCostoUnitario_pol)
                {
                    gridViewPoliza.SetFocusedRowCellValue(colSubtotal_pol, row.Cantidad * row.Costo_Uni);
                    if ((bool)row.Aplica_Iva)
                    {
                        gridViewPoliza.SetFocusedRowCellValue(colIva_pol, row.Subtotal * row.Por_Iva);
                        gridViewPoliza.SetFocusedRowCellValue(colTotal_pol, row.Subtotal + row.Valor_Iva);
                    }
                    else
                    {
                        gridViewPoliza.SetFocusedRowCellValue(colTotal_pol, row.Subtotal);
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

        private void gridViewMarcaciones_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info row = new fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info();
                row = (fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info)gridViewMarcaciones.GetRow(e.RowHandle);

                if (e.Column == colCantidad_mar || e.Column == colCostoUnitario_mar)
                {
                    gridViewMarcaciones.SetFocusedRowCellValue(colSubtotal_mar, row.Cantidad * row.Costo_Uni);
                    if ((bool)row.Aplica_Iva)
                    {
                        gridViewMarcaciones.SetFocusedRowCellValue(colIva_mar, row.Subtotal * row.Por_Iva);
                        gridViewMarcaciones.SetFocusedRowCellValue(colTotal_mar, row.Subtotal + row.Valor_Iva);
                    }
                    else
                    {
                        gridViewMarcaciones.SetFocusedRowCellValue(colTotal_mar, row.Subtotal);
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

        private void cmb_Generar_Liq_Click(object sender, EventArgs e)
        {
            try
            {

                 


                 app = new Microsoft.Office.Interop.Excel.Application();
                 app.Visible = true;
                 workbook = app.Workbooks.Add(1);
                 worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                createHeaders(2,2,"Prueba","cel1","cel2",5,"blue",true,10,"blue");

                
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
           
            }
        }
        


        public void createHeaders(int row, int col, string htext, string cell1,
        string cell2, int mergeColumns,string b, bool font,int size,string
        fcolor)
        {
            worksheet.Cells[row, col] = htext;
            workSheet_range = worksheet.get_Range(cell1, cell2);
            workSheet_range.Merge(mergeColumns);
            switch(b)
            {
                case "YELLOW":
                workSheet_range.Interior.Color = System.Drawing.Color.Yellow.ToArgb();
                break;
                case "GRAY":
                    workSheet_range.Interior.Color = System.Drawing.Color.Gray.ToArgb();
                break;
                case "GAINSBORO":
                    workSheet_range.Interior.Color = 
			System.Drawing.Color.Gainsboro.ToArgb();
                    break;
                case "Turquoise":
                    workSheet_range.Interior.Color = 
			System.Drawing.Color.Turquoise.ToArgb();
                    break;
                case "PeachPuff":
                    workSheet_range.Interior.Color = 
			System.Drawing.Color.PeachPuff.ToArgb();
                    break;
                default:
                  //  workSheet_range.Interior.Color = System.Drawing.Color..ToArgb();
                    break;
            }
         
            workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            workSheet_range.Font.Bold = font;
            workSheet_range.ColumnWidth = size;
            if (fcolor.Equals(""))
            {
                workSheet_range.Font.Color = System.Drawing.Color.White.ToArgb();
            }
            else {
                workSheet_range.Font.Color = System.Drawing.Color.Black.ToArgb();
            }
        }

        public void addData(int row, int col, string data, 
			string cell1, string cell2,string format)
        {
            worksheet.Cells[row, col] = data;
            workSheet_range = worksheet.get_Range(cell1, cell2);
            workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            workSheet_range.NumberFormat = format;
        }

        private void btnImprimir_Egresos_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Gastos_Click(object sender, EventArgs e)
        {
            try
            {
                gridControlGastos.ShowPrintPreview();
            }
            catch (Exception)
            {
                
               
            }
        }    
    }
}
    

