using Core.Erp.Business.ActivoFijo_FJ;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Winform.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class FrmFa_Registro_de_horas_x_equipo_Mantenimiento : Form
    {
        #region Variables
        Cl_Enumeradores.eTipo_action _Accion;
        fa_registro_unidades_x_equipo_Info info_Registro = new fa_registro_unidades_x_equipo_Info();
        fa_registro_unidades_x_equipo_Bus bus_Registros = new fa_registro_unidades_x_equipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_FrmFa_Registro_de_horas_x_equipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmFa_Registro_de_horas_x_equipo_Mantenimiento_FormClosing event_delegate_FrmFa_Registro_de_horas_x_equipo_Mantenimiento_FormClosing;
        tb_Calendario_Bus bus_Calendario = new tb_Calendario_Bus();
        List<tb_Calendario_Info> list_Calendario = new List<tb_Calendario_Info>();
        List<fa_cliente_x_ct_centro_costo_Info> list_Cliente_x_Centro_costo = new List<fa_cliente_x_ct_centro_costo_Info>();
        fa_cliente_x_ct_centro_costo_Bus bus_Cliente_x_Centro_costo = new fa_cliente_x_ct_centro_costo_Bus();
        fa_cliente_x_ct_centro_costo_Info info_Cliente_x_Centro_costo = new fa_cliente_x_ct_centro_costo_Info();
        BindingList<Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info> list_ActF_x_CC = new BindingList<Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info>();
        Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info info_ActF_x_CC = new Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info();
        Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Bus bus_ActF_x_CC = new Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Bus();
        List<in_UnidadMedida_Info> list_UnidadMedida = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Bus bus_UnidadMedida = new in_UnidadMedida_Bus();
        fa_registro_unidades_x_equipo_det_Info info_Registro_det = new fa_registro_unidades_x_equipo_det_Info();
        ct_Periodo_Bus bus_Periodo = new ct_Periodo_Bus();
        List<ct_Periodo_Info> list_Periodo = new List<ct_Periodo_Info>();
        ct_Periodo_Info info_Periodo = new ct_Periodo_Info();
        
        #endregion

        public FrmFa_Registro_de_horas_x_equipo_Mantenimiento()
        {
            InitializeComponent();
            event_delegate_FrmFa_Registro_de_horas_x_equipo_Mantenimiento_FormClosing += FrmFa_Registro_de_horas_x_equipo_Mantenimiento_event_delegate_FrmFa_Registro_de_horas_x_equipo_Mantenimiento_FormClosing;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucFa_Cliente_x_centro_costo_cmb1.event_delegate_cmb_Sub_centro_costo_EditValueChanged += ucFa_Cliente_x_centro_costo_cmb1_event_delegate_cmb_Sub_centro_costo_EditValueChanged;
            ucCon_Periodo1.event_delegate_de_Desde_EditValueChanged += ucCon_Periodo1_event_delegate_de_Desde_EditValueChanged;
            ucCon_Periodo1.event_delegate_de_Hasta_EditValueChanged += ucCon_Periodo1_event_delegate_de_Hasta_EditValueChanged;
        }

        void ucCon_Periodo1_event_delegate_de_Hasta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucCon_Periodo1.Get_Periodo_Info() != null)
                {
                    if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo() != null)
                    {
                        Crear_tabla();
                    }
                    else
                        Limpiar_Tabla();
                }
                else
                    Limpiar_Tabla();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        void ucCon_Periodo1_event_delegate_de_Desde_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucCon_Periodo1.Get_Periodo_Info() != null)
                {
                    if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo() != null)
                    {
                        Crear_tabla();
                    }
                    else
                        Limpiar_Tabla();
                }
                else
                    Limpiar_Tabla();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        void ucFa_Cliente_x_centro_costo_cmb1_event_delegate_cmb_Sub_centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo() != null)
                {
                    if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo_sub_centro_costo() != null)
                    {
                        string idCentro_costo = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo().IdCentroCosto;
                        string idCentro_costo_sub_centro_costo = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;
                        if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                            list_ActF_x_CC = new BindingList<Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info>(bus_ActF_x_CC.Get_List_Af_x_SCC(param.IdEmpresa, idCentro_costo, idCentro_costo_sub_centro_costo));
                        else
                            list_ActF_x_CC = new BindingList<Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info>(bus_ActF_x_CC.Get_List_Af_x_SCC_x_Registro(param.IdEmpresa, idCentro_costo, idCentro_costo_sub_centro_costo, info_Registro.IdRegistro));
                        gridControlEquiposAsignados.DataSource = list_ActF_x_CC;
                        if (ucCon_Periodo1.Get_Periodo_Info() != null)
                        {
                            Crear_tabla();
                        }
                        else
                            Limpiar_Tabla();
                    }
                    else
                        Limpiar_Tabla();
                }
                else
                    Limpiar_Tabla();
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
                if (Validar())
                {
                    if (Grabar())
                    {
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

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (Grabar())
                    {
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

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        void FrmFa_Registro_de_horas_x_equipo_Mantenimiento_event_delegate_FrmFa_Registro_de_horas_x_equipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Info(fa_registro_unidades_x_equipo_Info info) 
        {
            try
            {
                info_Registro = info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        private void FrmFa_Registro_de_horas_x_equipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_delegate_FrmFa_Registro_de_horas_x_equipo_Mantenimiento_FormClosing(sender, e);
        }

        private void Cargar_combos()
        {
            try
            {
                deFecha.EditValue = DateTime.Now;

                ucFa_Cliente_x_centro_costo_cmb1.Cargar_combos();
                ucCon_Periodo1.Cargar_combos();

                list_UnidadMedida = bus_UnidadMedida.Get_list_UnidadMedida();
                cmb_UnidadMedida.DataSource = list_UnidadMedida;
                cmb_UnidadMedida.DisplayMember = "Descripcion";
                cmb_UnidadMedida.ValueMember = "IdUnidadMedida";

                ucFa_CatalogosCmb1.cargar_Catalogos(9);
                ucFa_CatalogosCmb1.set_CatalogosInfo("0082");
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        private void Limpiar_Tabla()
        {
            try
            {
                gridViewRegistros.Columns.Clear();
                gridControlRegistros.DataSource = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        private void Crear_tabla()
        {
            try
            {               
                gridViewRegistros.Columns.Clear();                

                DateTime Fecha_Ini = DateTime.Now;
                DateTime Fecha_Fin = DateTime.Now;

                Fecha_Ini = ucCon_Periodo1.Get_Periodo_Info().pe_FechaIni;
                Fecha_Fin = ucCon_Periodo1.Get_Periodo_Info().pe_FechaFin;

                list_Calendario = bus_Calendario.Get_List_Calendario_x_rango_fechas(Fecha_Ini, Fecha_Fin).OrderBy(q => q.fecha).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("IdFecha",typeof(int));
                dt.Columns["IdFecha"].ReadOnly = true;
                dt.Columns.Add("Día", typeof(string));
                dt.Columns["Día"].ReadOnly = true;
                dt.Columns.Add("Fecha", typeof(DateTime));
                dt.Columns["Fecha"].ReadOnly = true;
                foreach (var item in list_ActF_x_CC)
                {
                    if (item.Asignado)
                    {
                        dt.Columns.Add(item.Af_DescripcionCorta, typeof(double));    
                    }
                }
                foreach (var item in list_Calendario)
                {
                    dt.Rows.Add(item.IdCalendario, item.NombreDia, item.fecha.Date.ToShortDateString());
                }

                if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    foreach (DataRow dtRow in dt.Rows)
                    {
                        info_Registro_det = info_Registro.Lst_det.FirstOrDefault(q => q.IdFecha == Convert.ToUInt32(dtRow[0])  );
                        if (info_Registro_det!=null)
                        {
                            int idFecha = info_Registro_det.IdFecha;

                            foreach (DataColumn dc in dt.Columns)                            
                            {

                                string CodigoActivo = dc.ColumnName;
                                if (dc != dt.Columns["Día"] && dc != dt.Columns["Fecha"] && dc != dt.Columns["IdFecha"])
                                {
                                    int contador =0;
                                    int idactivo = 0;

                                    try
                                    {
                                         contador = info_Registro.Lst_det.Where(q => q.CodActivoFijo == CodigoActivo && idFecha == q.IdFecha).Count();
                                         idactivo = info_Registro.Lst_det.Where(q => q.CodActivoFijo == CodigoActivo).FirstOrDefault().IdActivoFijo;

                                    }
                                    catch (Exception)
                                    {
                                        
                                       
                                    }
                                  



                                        if (contador != 0)
                                        {
                                            try
                                            {
                                                dtRow[dc] = info_Registro.Lst_det.Where(q => q.CodActivoFijo == info_Registro_det.CodActivoFijo && idFecha == q.IdFecha && q.IdActivoFijo==idactivo).FirstOrDefault().Valor;
                                            }
                                            catch (Exception)
                                            {
                                                
                                               
                                            }
                                            //break;
                                        }
                                    
                                   
                                }
                            }
                        }
                    }
                }
                                                
                gridControlRegistros.DataSource = dt;               
                gridViewRegistros.BestFitColumns();
                gridViewRegistros.Columns["IdFecha"].Visible = false;
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
                Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                Set_Controles();
                info_Registro = new fa_registro_unidades_x_equipo_Info();
                info_Registro.Lst_det = new List<fa_registro_unidades_x_equipo_det_Info>();

                txtObservacion.Text = "";
                ucFa_Cliente_x_centro_costo_cmb1.Inicializar_Combos();
                ucCon_Periodo1.Inicializar_Combos();
                deFecha.EditValue = DateTime.Now;
                                
                gridViewRegistros.Columns.Clear();
                gridControlEquiposAsignados.DataSource = null;
                gridControlRegistros.DataSource = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }        

        private void FrmFa_Registro_de_horas_x_equipo_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_combos();
                deFecha.EditValue = DateTime.Now.Date;                
                Set_Controles();
                if (_Accion!=Cl_Enumeradores.eTipo_action.grabar)
                {
                    Set_Registro();    
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        private void gridViewRegistros_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info info_activo = new Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info();
                if (e.Column !=  gridViewRegistros.Columns["Fecha"] && e.Column!= gridViewRegistros.Columns["Día"])
                {
                    if (info_Registro.Lst_det == null) 
                        info_Registro.Lst_det = new List<fa_registro_unidades_x_equipo_det_Info>();

                    int IdFecha = Convert.ToInt32(gridViewRegistros.GetRowCellValue(e.RowHandle, gridViewRegistros.Columns["IdFecha"]));
                    string CodActivoFijo = e.Column.ToString();
                    info_activo = list_ActF_x_CC.Where(v => v.Af_DescripcionCorta == CodActivoFijo).FirstOrDefault();
                    double Valor = get_Valor(e.Value.ToString());

                    info_Registro_det = info_Registro.Lst_det.FirstOrDefault(q => q.IdActivoFijo == info_activo.IdActivoFijo && q.IdFecha == IdFecha);
                    if (info_Registro_det == null)
                    {
                        if (Valor != 0)
                        {
                            info_Registro_det = new fa_registro_unidades_x_equipo_det_Info();
                            info_Registro_det.IdEmpresa = param.IdEmpresa;
                            info_Registro_det.IdFecha = IdFecha;
                            info_Registro_det.IdActivoFijo = info_activo.IdActivoFijo;
                            info_Registro_det.Valor = Valor;
                            info_Registro_det.IdPeriodo = ucCon_Periodo1.Get_Periodo_Info().IdPeriodo;
                            if (Validar_Registro_det(info_Registro_det))
                                info_Registro.Lst_det.Add(info_Registro_det);
                            else
                            {
                                info_ActF_x_CC = list_ActF_x_CC.FirstOrDefault(q => q.IdEmpresa_AF == param.IdEmpresa && q.IdActivoFijo_AF == info_activo.IdActivoFijo);
                                gridViewRegistros.SetRowCellValue(e.RowHandle,  info_ActF_x_CC.Af_DescripcionCorta, null);
                            }
                        }
                    }
                    else
                        if (Valor != 0 && Valor!=null)
                        {
                            info_Registro_det.Valor = Valor;
                            if (Validar_Registro_det(info_Registro_det))
                                info_Registro.Lst_det.FirstOrDefault(q => q.IdActivoFijo == info_activo.IdActivoFijo && q.IdFecha == IdFecha).Valor = Valor;
                            else
                            {
                                info_ActF_x_CC = list_ActF_x_CC.FirstOrDefault(q => q.IdEmpresa_AF == param.IdEmpresa && q.IdActivoFijo_AF == info_activo.IdActivoFijo);
                                gridViewRegistros.SetRowCellValue(e.RowHandle, info_ActF_x_CC.Af_DescripcionCorta, null);                                
                            }
                        }
                        else
                            info_Registro.Lst_det.Remove(info_Registro.Lst_det.FirstOrDefault(q => q.IdActivoFijo == info_activo.IdActivoFijo && q.IdFecha == IdFecha));
                }                                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        private void gridViewEquiposAsignados_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {   
                if (e.Column == colAsignado)
                {
                    if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo() == null)
                        return;
                    if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo_sub_centro_costo() == null)
                        return;
                    if (ucCon_Periodo1.Get_Periodo_Info() == null)
                        return;
                    Crear_tabla();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }
        
        private void check_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtObservacion.Focus();                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        private void cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucCon_Periodo1.Get_Periodo_Info() != null)
                {
                    int idPeriodo = ucCon_Periodo1.Get_Periodo_Info().IdPeriodo;
                    info_Periodo = list_Periodo.FirstOrDefault(q => q.IdPeriodo == idPeriodo);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        private double get_Valor(string cadena)
        {
            try
            {
                double Valor = 0;

                if (cadena.Length==0)
                    return 0;

                if (cadena.Length!=0)
                {
                    char id = cadena.ToCharArray().FirstOrDefault();
                    if (id<='9' && id>='0')
                    {
                        Valor = Convert.ToDouble(cadena);
                    }
                }

                return Valor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            }
        }

        private int Get_IdActivo_fijo(string cadena)
        {
            try
            {
                int idActivo_fijo = 0;
                string[] arreglo = Regex.Split(cadena," ");
                idActivo_fijo = Convert.ToInt32(arreglo[0]);
                return idActivo_fijo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            } 
        }

        private void Set_Controles()
        {
            try
            {                
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        //ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;

                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(false);
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        //ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;

                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        //ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;

                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        //ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;

                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
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

        private Boolean Grabar()
        {
            try
            {
                Boolean res = true;

                switch (_Accion)
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

        private void Get_Registro()
        {
            try
            {
                info_Registro.IdRegistro = txtIdRegistro.Text == "" ? 0 : Convert.ToDecimal(txtIdRegistro.Text);
                info_Registro.Lst_det_x_Af_ini = new List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info>();
                info_Registro.IdEstadoRegistro_cat = ucFa_CatalogosCmb1.get_CatalogosInfo().IdCatalogo;
                info_Registro.Observacion = txtObservacion.Text;
                info_Registro.IdPeriodo = ucCon_Periodo1.Get_Periodo_Info().IdPeriodo;
                info_Registro.IdCentroCosto = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo().IdCentroCosto;
                info_Registro.IdCentroCosto_sub_centro_costo = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;
                info_Registro.Fecha = Convert.ToDateTime(deFecha.EditValue);
                foreach (var item in list_ActF_x_CC)
                {
                    if (item.Asignado)
                    {    
                        fa_registro_unidades_x_equipo_det_ini_x_Af_Info info = new fa_registro_unidades_x_equipo_det_ini_x_Af_Info();
                        info.IdEmpresa = item.IdEmpresa_AF;
                        info.IdActivoFijo = item.IdActivoFijo_AF;
                        info.IdRegistro = info_Registro.IdRegistro;
                        info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                    
                        info_Registro.Lst_det_x_Af_ini.Add(info);
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

        private void Set_Registro()
        {
            try
            {
                info_Registro = bus_Registros.Get_Info(info_Registro.IdEmpresa, info_Registro.IdRegistro);
                if (info_Registro!=null)
                {
                    txtIdRegistro.Text = info_Registro.IdRegistro.ToString();
                    txtObservacion.Text = info_Registro.Observacion;
                    ucCon_Periodo1.Set_Periodo(info_Registro.IdPeriodo);
                    deFecha.EditValue = info_Registro.Fecha;
                    ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo(info_Registro.IdCentroCosto);
                    ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo_sub_centro_costo(info_Registro.IdCentroCosto_sub_centro_costo);
                    ucFa_CatalogosCmb1.set_CatalogosInfo(info_Registro.IdEstadoRegistro_cat);
                }                
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
                Boolean res = true;
                Get_Registro();
                res = bus_Registros.GuardarDB(info_Registro);
                if (res)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private Boolean ModificarDB()
        {
            try
            {
                Boolean res = true;
                Get_Registro();
                res = bus_Registros.ModificarDB(info_Registro);
                if (res)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private Boolean AnularDB()
        {
            try
            {
                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    oFrm.ShowDialog();
                    info_Registro.MotiAnula = oFrm.motivoAnulacion;
                    if (bus_Registros.AnularDB(info_Registro))
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        lblAnulado.Visible = true;
                        return true;
                    }
                } return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean Validar()
        {
            try
            {
                if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Cliente_x_Centro_costo()== null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo_sub_centro_costo()==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " sub centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucCon_Periodo1.Get_Periodo_Info()==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }                

                if (txtObservacion.Text=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (deFecha.EditValue==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " Fecha", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }                

                if (ucFa_CatalogosCmb1.get_CatalogosInfo().IdCatalogo == null )
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Estado de registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucFa_CatalogosCmb1.get_CatalogosInfo().Nombre == "Todos" )
                {
                    MessageBox.Show("Registro no permitido [Todos]", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                
                int cont = list_ActF_x_CC.Where(q=>q.Asignado==true).Count();
                if (cont==0)
                {
                    MessageBox.Show("Debe asignar al menos un equipo a este registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (info_Registro.Lst_det==null)
                {
                    MessageBox.Show("Debe ingresar al menos un registro de unidades para este periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (info_Registro.Lst_det.Count==0)
                {
                    MessageBox.Show("Debe ingresar al menos un registro de unidades para este periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private Boolean Validar_Registro_det(fa_registro_unidades_x_equipo_det_Info info_det)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_det_Info> lst_Detalles_x_Activo = new List<fa_registro_unidades_x_equipo_det_Info>();

                info_ActF_x_CC = list_ActF_x_CC.FirstOrDefault(q => q.IdEmpresa_AF == info_det.IdEmpresa && q.IdActivoFijo_AF == info_det.IdActivoFijo);

                if (info_det.Valor <= info_ActF_x_CC.Af_ValorUnidad_Actu)
                {
                    MessageBox.Show("El valor ingresado es menor al valor actual del equipo " + info_ActF_x_CC.Af_DescripcionCorta + ", por favor ingrese un valor mayor.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                lst_Detalles_x_Activo = info_Registro.Lst_det.Where(q => q.IdEmpresa == info_det.IdEmpresa && q.IdActivoFijo == info_det.IdActivoFijo).ToList();

                foreach (var item in lst_Detalles_x_Activo)
                {
                    if (item.IdFecha < info_det.IdFecha)
                    {
                        if (item.Valor > info_det.Valor)
                        {
                            MessageBox.Show("Existe un registro de menor fecha con un valor mayor al que ha ingresado, por favor ingrese un valor mayor.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                    else
                    {
                        if (item.Valor < info_det.Valor)
                        {
                            MessageBox.Show("Existe un registro de mayor fecha con un valor menor al que ha ingresado, por favor ingrese un valor menor.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
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

    }
}
