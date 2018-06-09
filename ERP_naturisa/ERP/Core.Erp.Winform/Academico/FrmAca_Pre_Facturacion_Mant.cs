using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Recursos.Properties;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Pre_Facturacion_Mant : Form
    {

        public FrmAca_Pre_Facturacion_Mant()
        {
            InitializeComponent();
            Cargar_Data();
        }

        #region variable
        string msg = "";
        string mensaje = "";
        int c = 1;
        int Total_Reg = 0;
        int NumDocumentoTalonarioDisponible = 0;

        public Cl_Enumeradores.eTipo_action accion { get; set; }
        List<Aca_Anio_Lectivo_Info> lista_anio_lectivo = new List<Aca_Anio_Lectivo_Info>();
        List<Aca_Periodo_Info> lista_periodo = new List<Aca_Periodo_Info>();
        BindingList<Aca_Pre_Facturacion_det_Info> lista_detalle = new BindingList<Aca_Pre_Facturacion_det_Info>();
        List<Aca_Curso_Info> lista_curso = new List<Aca_Curso_Info>();
        List<Aca_Pre_Facturacion_det_Info> lis_detalle_facturar = new List<Aca_Pre_Facturacion_det_Info>();


        Aca_Anio_Lectivo_Bus bus_anio_lectivo = new Aca_Anio_Lectivo_Bus();
        Aca_Periodo_Bus bus_periodo = new Aca_Periodo_Bus();
        Aca_Pre_Facturacion_det_Bus bus_detalle = new Aca_Pre_Facturacion_det_Bus();
        Aca_Curso_Bus bus_curso = new Aca_Curso_Bus();
        Aca_Pre_Facturacion_Bus bus_pre_facturacion = new Aca_Pre_Facturacion_Bus();
        Aca_Pre_Facturacion_det_Bus bus_pre_facturacion_det = new Aca_Pre_Facturacion_det_Bus();



        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<fa_factura_aca_Info> lista_facturas = new List<fa_factura_aca_Info>();
        fa_factura_aca_Bus bus_facturas = new fa_factura_aca_Bus();
        Aca_Periodo_Info info_periodo = new Aca_Periodo_Info();

        Aca_Pre_Facturacion_Info info_prefac = new Aca_Pre_Facturacion_Info();

        tb_Sucursal_Bus BusSucu = new tb_Sucursal_Bus();
        fa_PuntoVta_Bus BusPtoVta = new fa_PuntoVta_Bus();
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        List<fa_PuntoVta_Info> listPuntoVta = new List<fa_PuntoVta_Info>();
        tb_Sucursal_Info Info_Sucursal = new tb_Sucursal_Info();
        fa_PuntoVta_Info Info_PuntoVta = new fa_PuntoVta_Info();

        Aca_Sede_Bus BusSede = new Aca_Sede_Bus();
        Aca_Sede_Info InfoSede = new Aca_Sede_Info();
        List<Aca_Sede_Info> ListInfoSede = new List<Aca_Sede_Info>();
        

        tb_sis_Documento_Tipo_Talonario_Bus bus_talonario = new tb_sis_Documento_Tipo_Talonario_Bus();

        #endregion


        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Cargar_Data()
        {
            try
            {
                //string anio = "";
                int anio = 0;

                int periodo = 0;
                lista_anio_lectivo = bus_anio_lectivo.Get_List_Anio_Lectivo(param.IdInstitucion);
                cmb_anio_lectivo.Properties.DataSource = lista_anio_lectivo;
                anio = lista_anio_lectivo.FirstOrDefault().IdAnioLectivo;
                cmb_anio_lectivo.EditValue = anio;
                lista_periodo = bus_periodo.Get_List_PeriodoActivo_x_AnioLectivo(param.IdInstitucion, Convert.ToInt16(cmb_anio_lectivo.EditValue.ToString()));
                cmb_periodo.Properties.DataSource = lista_periodo;
                periodo = lista_periodo.FirstOrDefault().IdPeriodo;
                cmb_periodo.EditValue = periodo;

                //ucAca_SedeJornadaSeccionCurso.CargarCombos();


                cmbSede.Properties.DataSource = BusSede.Get_List_Sede(param.IdInstitucion);

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_procesar_pre_fac_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;

                Get();
                info_prefac.Estado_Pre_factutacion_Cat = "PEN";

                //if (bus_pre_facturacion.Procesar_Pre_Fact(info_prefac, Convert.ToInt32( ucAca_SedeJornadaSeccionCurso.cmbSede.EditValue), ref msg))
                    if (bus_pre_facturacion.Procesar_Pre_Fact(info_prefac, Convert.ToInt32(cmbSede.EditValue), ref msg))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente) , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_id.EditValue = bus_pre_facturacion.getId_pre_Facturacion(Convert.ToInt32( info_prefac.IdAnioLectivo), info_prefac.IdPeriodo).ToString();
                    info_prefac.IdPreFacturacion = Convert.ToInt32(txt_id.EditValue);
                    lista_detalle = new BindingList<Aca_Pre_Facturacion_det_Info>(bus_detalle.Get_list(info_prefac.IdInstitucion, Convert.ToInt32(info_prefac.IdPreFacturacion)));
                    gridControl_pre_fac.DataSource = lista_detalle;
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_facturar_Click(object sender, EventArgs e)
        {
            ProcesarFacturacion();
        }

        private bool Validar()
        {
            bool bandeta = true;
            try
            {
                if (cmb_anio_lectivo.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el)+" Ano lectivo", param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    bandeta = false;
                }


                if (cmb_periodo.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bandeta = false;
                }

                if (cmbSede.EditValue == "" || cmbSede.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Sede ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bandeta = false;
                }

                return bandeta;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Set(Aca_Pre_Facturacion_Info info_)
        {
            try
            {
                info_prefac = info_;
                cmb_anio_lectivo.EditValue = info_.IdAnioLectivo;
                cmb_periodo.EditValue = Convert.ToInt32(info_.IdPeriodo);
                txt_observacion.Text = info_.observacion_fact;
                txt_id.EditValue = info_.IdPreFacturacion;
                if (info_.Estado_Pre_factutacion_Cat == "FAC")
                {
                    cmb_facturar.Enabled = false;
                    cmb_procesar_pre_fac.Enabled = false;
                }
                lista_detalle = new BindingList<Aca_Pre_Facturacion_det_Info>(bus_detalle.Get_list(info_.IdInstitucion,Convert.ToInt32( info_.IdPreFacturacion)));
                gridControl_pre_fac.DataSource = lista_detalle;

                lista_facturas = bus_facturas.Get_list(info_.IdInstitucion,Convert.ToInt32( info_.IdAnioLectivo), info_.IdPeriodo, ref mensaje);
                gridControl_Facturas.DataSource = lista_facturas;
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void Get()
        {
            try
            {
                info_prefac.IdEmpresa_fact = param.IdEmpresa;
                info_prefac.IdInstitucion = param.IdInstitucion;

                //info_prefac.IdAnioLectivo = cmb_anio_lectivo.EditValue.ToString();
                info_prefac.IdAnioLectivo = Convert.ToInt16(cmb_anio_lectivo.EditValue.ToString());

                info_prefac.IdPeriodo = Convert.ToInt32(cmb_periodo.EditValue);
                info_prefac.observacion_fact = txt_observacion.Text;
                info_prefac.fecha_prefacturacion=Convert.ToDateTime( dtp_Fecha_Fact.EditValue);

                //info_prefac.IdSede = Convert.ToInt16(cmbSede.EditValue);
                info_prefac.IdSucursal_fact = Convert.ToInt16(InfoSede.IdSucursal);

                info_prefac.IdPtoVta_fact = Convert.ToInt16(cmb_PtoVta.EditValue);
                get_InfoSede();
                get_InfoPto_Vta();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_periodo = (Aca_Periodo_Info)cmb_periodo.Properties.View.GetFocusedRow();
                if (info_periodo == null)
                    info_periodo = lista_periodo.Where(v => v.IdPeriodo == info_prefac.IdPeriodo).FirstOrDefault();
                dtp_Fecha_Fact.EditValue = info_prefac.pe_FechaIni;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAca_Pre_Facturacion_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                dtp_Fecha_Fact.EditValue = DateTime.Now;
                dtp_fecha_pre_fact.EditValue = DateTime.Now;
                txt_id.EditValue = 0;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl_pre_fac_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ProcesarFacturacion()
        {
            try
            {
                              

                bool siProceso_ok = false;
                lis_detalle_facturar = bus_detalle.Get_list_Pre_Fact_a_Fecturar(param.IdInstitucion, Convert.ToInt32(info_prefac.IdPreFacturacion));

                NumDocumentoTalonarioDisponible = bus_talonario.Get_List_Doc_disponible(param.IdEmpresa, Info_PuntoVta.cod_PuntoVta, InfoSede.Su_CodigoEstablecimiento, "FACT", true).Count();
                Total_Reg = lis_detalle_facturar.Count();
                progressBar.Maximum = Total_Reg;
                progressBar.Minimum = 1;
                progressBar.Step = 1;
                lblNumRegistros.Text = "0 registros de " + Total_Reg;
                c = 1;

                if (Total_Reg + 100 >= NumDocumentoTalonarioDisponible) 
                {
                    MessageBox.Show(" El Numero de Documentos a Generar es mayor al Disponible!!!, Favor Genere Nuevo Talonario ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var item in lis_detalle_facturar)
                {
                    //item.idEstablecimiento = InfoSede.Su_CodigoEstablecimiento;
                    item.IdSucursal = Convert.ToInt32(InfoSede.IdSucursal);
                    item.IdSucursal_fac = Convert.ToInt32(InfoSede.IdSucursal);
                    item.Su_CodigoEstablecimiento = InfoSede.Su_CodigoEstablecimiento;
                    item.idPtoEmision = Info_PuntoVta.IdPuntoVta;
                    item.cod_PuntoVta_fact = Info_PuntoVta.cod_PuntoVta.ToString();
                    item.IdBodega_fac = Info_PuntoVta.IdBodega;

                    siProceso_ok = bus_pre_facturacion_det.Generar_Factura(item);


                    progressBar.Value = c;
                    lblNumRegistros.Text = c + " registros de " + Total_Reg;
                    progressBar.Refresh();
                    Application.DoEvents();
                    c++;

                }

                if (siProceso_ok)
                {
                    bus_pre_facturacion.Modificar_Estado_Prefacturacion_DB(info_prefac, ref mensaje);
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lista_facturas = bus_facturas.Get_list(info_prefac.IdInstitucion, Convert.ToInt32(info_prefac.IdAnioLectivo), info_prefac.IdPeriodo, ref mensaje);
                    gridControl_Facturas.DataSource = lista_facturas;
                    cmb_facturar.Enabled = false;
                    cmb_procesar_pre_fac.Enabled = false;
                }
                else
                {

                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSede_EditValueChanged(object sender, EventArgs e)
        {
            get_InfoSede();
        }


        public void cargar_PtoVta_en_Combo(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<fa_PuntoVta_Info> listDS_PtoVta = new List<fa_PuntoVta_Info>();

                var qPtoVta = from bo in listPuntoVta
                              where bo.IdEmpresa == IdEmpresa
                              && bo.IdSucursal == IdSucursal
                              select bo;

                foreach (fa_PuntoVta_Info item in qPtoVta)
                {
                    fa_PuntoVta_Info obodega = new fa_PuntoVta_Info();

                    obodega.IdEmpresa = item.IdEmpresa;
                    obodega.IdSucursal = item.IdSucursal;
                    obodega.IdPuntoVta = item.IdPuntoVta;
                    obodega.cod_PuntoVta = item.cod_PuntoVta;
                    obodega.nom_PuntoVta2 = "[" + item.IdPuntoVta + "]-" + item.nom_PuntoVta;
                    obodega.nom_PuntoVta = item.nom_PuntoVta;
                    obodega.estado = item.estado;

                    listDS_PtoVta.Add(obodega);
                }
                if (listDS_PtoVta != null)
                {
                    if (listDS_PtoVta.Count != 0)
                    {
                        cmb_PtoVta.Properties.DataSource = listDS_PtoVta;
                        cmb_PtoVta.Properties.DisplayMember = "nom_PuntoVta2";
                        cmb_PtoVta.Properties.ValueMember = "IdPuntoVta";
                        cmb_PtoVta.EditValue = listDS_PtoVta.FirstOrDefault().IdPuntoVta;
                    }
                    else
                    {
                        MessageBox.Show("La sucursal seleccionada no tiene Punto de Ventas asignadas.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_PtoVta.Properties.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_PtoVta_EditValueChanged(object sender, EventArgs e)
        {
            get_InfoPto_Vta();
        }

        public void get_InfoPto_Vta()
        {
            try
            {
                if (cmb_PtoVta.EditValue != null && cmb_PtoVta.EditValue != "")
                {
                    Info_PuntoVta = (fa_PuntoVta_Info)(listPuntoVta.FirstOrDefault(v => v.IdSucursal == Convert.ToInt32(cmbSede.EditValue) && v.IdPuntoVta == Convert.ToInt32(cmb_PtoVta.EditValue)));
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        public void get_InfoSede()
        {
            try
            {
                if (cmbSede.EditValue != null && cmbSede.EditValue != "")
                {
                    //Aca_Jornada_Bus negJornada = new Aca_Jornada_Bus();
                    //cmbJornada.Properties.DataSource = negJornada.Get_List_Jornada(param.IdInstitucion, Convert.ToInt16(cmbSede.EditValue));
                    //listSucursal = BusSucu.Get_List_Sucursal(param.IdEmpresa);
                    listPuntoVta = BusPtoVta.Get_List_PuntoVta(param.IdEmpresa);
                    ListInfoSede = BusSede.Get_List_Sede(param.IdInstitucion);

                    InfoSede = (Aca_Sede_Info)(ListInfoSede.FirstOrDefault(v => v.IdSede == Convert.ToInt32(cmbSede.EditValue)));


                    //Info_Sucursal = (tb_Sucursal_Info)(listSucursal.FirstOrDefault(v => v.IdSucursal == Convert.ToInt32(cmbSede.EditValue)));

                    if (InfoSede != null)
                    {
                        cargar_PtoVta_en_Combo(Convert.ToInt16(InfoSede.IdEmpresa), Convert.ToInt16(InfoSede.IdSucursal));
                        //Event_cmb_sucursal_EditValueChanged(sender, e);
                    }



                    //cmb_PtoVta.Properties.DataSource = listPuntoVta;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
