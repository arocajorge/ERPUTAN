using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCp_RetencionOG : UserControl
    {
        public UCCp_RetencionOG()
        {

        }

        //public UCCp_RetencionOG(decimal DvalorIVA, decimal DBaseImponible, cp_retencion_Info CabRetencion, decimal IdProveedor, DateTime fechaRetencion, Boolean VerNumRetencion = false, decimal NRetencion = 0)
        //{


        //    try
        //    {
        //        InitializeComponent();

        //        valorIVA = DvalorIVA;
        //        BaseImponible=DBaseImponible;

        //        panel_Retencion.Controls.Add(UC_Retencion);
        //        UC_Retencion.Dock = DockStyle.Fill;
        //        lista_codigo_sri = dat_ti.Get_List_codigo_SRI_x_codigo(CodRetencion,param.IdEmpresa);

        //        dtC.Columns.Add("IdEmpresa", typeof(int));
        //        dtC.Columns.Add("IdProveedor", typeof(decimal));
        //        dtC.Columns.Add("Retención SRI", typeof(int));
        //        dtC.Columns.Add("Tipo", typeof(string));
        //        dtC.Columns.Add("%");
        //        dtC.Columns.Add("Base Imponible", typeof(decimal));
        //        dtC.Columns.Add("Monto Retencion", typeof(decimal));
        //        dtC.Columns.Add("Cta. Contable", typeof(string));
        //        dtC.Columns.Add("Fecha Vigente", typeof(string));
        //        dtC.Columns.Add("Modificado", typeof(Boolean));
        //        dtC.AcceptChanges();

        //        creaTablaCta();

        //        creaTabla(lista_codigo_sri, TablaCodigoSRI);

        //        if(UC_Retencion.txtNumDoc.Text == "")
        //        {
        //        }
        //        if (CabRetencion != null)
        //        {
        //            _CabRetencion = CabRetencion;
        //           set_CabRetencionOld(CabRetencion, IdProveedor);
        //            set_ListaRetencionOld(CabRetencion.ListDetalle, IdProveedor);
        //        }
        //        else
        //            set_CodiProveeLista();

        //        dtp_fechaEmisionRetencion.Value = fechaRetencion;

        //        if (VerNumRetencion==false)


        //        gb_NumRetencion.Visible = VerNumRetencion;

        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }
        //}

        //tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //List<cp_codigo_SRI_Info> lista_codigo_sri = new List<cp_codigo_SRI_Info>();
        //cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //List<cp_retencion_det_Info> _ListaRetencion = new List<cp_retencion_det_Info>();
        //cp_retencion_Info _CabRetencion = new cp_retencion_Info();

        //string[] CodRetencion = new string[] { "COD_RET_FUE", "COD_RET_IVA" };
        //UCGe_NumeroDocTrans UC_Retencion = new UCGe_NumeroDocTrans(true);
        //List<ct_Plancta_Info> listaPlan = new List<ct_Plancta_Info>();
        //cp_codigo_SRI_Bus dat_ti = new cp_codigo_SRI_Bus();
        //ct_Plancta_Bus _PlanCta_bus = new ct_Plancta_Bus();
        //DataTable TablaCodigoSRI = new DataTable("ivaRF");
        //DataTable TablaCta = new DataTable("Items");
        //DataTable dtC = new DataTable("CodigoSRI");
        //String format = "MM/dd/yyyy";
        //decimal valorIVA, BaseImponible;
        //string MensajeError = "";

        //Boolean _TieneRtIva;
        //Boolean _TieneRtFte;



        //private void creaTablaCta()
        //{
        //    try
        //    {
        //        listaPlan = _PlanCta_bus.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);


        //        TablaCta.Columns.Add("pc_Cuenta2");
        //        TablaCta.Columns.Add("Descripcion                         .");
        //        TablaCta.Columns.Add("IdCtaCble");

        //        foreach (var item in listaPlan)
        //        {
        //            DataRow filas;
        //            filas = TablaCta.NewRow();
        //            filas[0] = item.pc_Cuenta2;
        //            filas[1] = item.pc_Cuenta;
        //            filas[2] = item.IdCtaCble.Trim();

        //            TablaCta.Rows.Add(filas);
        //            TablaCta.AcceptChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }
        //}

        //private void creaTabla(List<cp_codigo_SRI_Info> Lista, DataTable tablaNCombo)
        //{
        //    try
        //    {
        //        tablaNCombo.Columns.Add("CodigoSRI                              .");
        //        tablaNCombo.Columns.Add("Tipo");
        //        tablaNCombo.Columns.Add("%Retencion");
        //        tablaNCombo.Columns.Add("Desde");
        //        tablaNCombo.Columns.Add("Hasta");
        //        tablaNCombo.Columns.Add("IdCodigo_SRI");
        //        tablaNCombo.Columns.Add("Detalle");
        //        tablaNCombo.Columns.Add("CtaCble");

        //        foreach (var item in Lista)
        //        {
        //            DataRow filas;
        //            filas = tablaNCombo.NewRow();
        //            filas[0] = "[" + item.codigoSRI + "] - " + item.co_descripcion;
        //            filas[1] = item.IdTipoSRI;
        //            filas[2] = item.co_porRetencion;
        //            filas[3] = item.co_f_vigente_desde.ToString(format);
        //            filas[4] = item.co_f_vigente_hasta.ToString(format);
        //            filas[5] = item.IdCodigo_SRI;
        //            filas[6] = "[" + item.codigoSRI + "] - " + item.co_descripcion + " " + item.co_porRetencion + "%";
        //            filas[7] = item.IdCtaCble;
        //            tablaNCombo.Rows.Add(filas);
        //            tablaNCombo.AcceptChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }
        //}

        //public void set_CodiProveeLista()
        //{
        //    try
        //    {
        //        cp_proveedor_codigo_SRI_Bus codPro_B = new cp_proveedor_codigo_SRI_Bus();
        //        List<cp_proveedor_codigo_SRI_Info> lm = new List<cp_proveedor_codigo_SRI_Info>();
        //        lm=codPro_B.Get_List_proveedor_codigo_SRI(param.IdEmpresa, 1);

        //        var tab = from A in lm.DefaultIfEmpty()
        //                  join B in lista_codigo_sri.DefaultIfEmpty() on new { A.IdCodigo_SRI } equals new { B.IdCodigo_SRI }

        //                  select new
        //                  {
        //                      A.IdCodigo_SRI,
        //                     // A.IdCtaCble,
        //                      A.IdEmpresa,
        //                      A.IdProveedor,
        //                      B.IdTipoSRI,
        //                      B.co_porRetencion,
        //                      B.co_f_vigente_desde,
        //                      B.co_f_vigente_hasta
        //                  };

        //        foreach (var item in tab)
        //        {
        //            DataRow filas;
        //            filas = dtC.NewRow();
        //            filas[0] = item.IdEmpresa;
        //            filas[1] = item.IdProveedor;
        //            filas[2] = item.IdCodigo_SRI;
        //            filas[3] = (item.IdTipoSRI == "COD_RET_IVA") ? "IVA" : "RTF";
        //            filas[4] = item.co_porRetencion;
        //            filas[5] = (item.IdTipoSRI == "COD_RET_IVA") ? valorIVA : BaseImponible;
        //            filas[6] = ((item.IdTipoSRI == "COD_RET_IVA") ? valorIVA : BaseImponible) * Convert.ToDecimal(item.co_porRetencion)/100;
        //          //  filas[7] = item.IdCtaCble;
        //            filas[8] = item.co_f_vigente_desde.ToString(format) + " - " + item.co_f_vigente_hasta.ToString(format);
        //            filas[9] = false;
        //            dtC.Rows.Add(filas);
        //            dtC.AcceptChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }
        //}

        //public void set_CabRetencionOld(cp_retencion_Info cabecera, decimal IdProveedor)
        //{
        //    try
        //    {

        //        _CabRetencion.IdEmpresa = cabecera.IdEmpresa;
        //        _CabRetencion.IdRetencion = cabecera.IdRetencion;
        //        _CabRetencion.re_Tiene_RTiva = cabecera.re_Tiene_RTiva;
        //        _CabRetencion.re_Tiene_RFuente = cabecera.re_Tiene_RFuente;
        //        _CabRetencion.fecha = cabecera.fecha;
        //        string SSerieRT = "";
        //        SSerieRT = cabecera.serie1 + '-'+cabecera.serie2; 

        //        if (SSerieRT  != null)
        //        {
        //           this.dtp_fechaEmisionRetencion.Value = cabecera.fecha;

        //        }

        //        _CabRetencion.NumRetencion = UC_Retencion.Get_Info_Talonario().NumDocumento;
        //        _CabRetencion.re_EstaImpresa = cabecera.re_EstaImpresa;
        //        _CabRetencion.Estado = cabecera.Estado;

        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }
        //}

        //public void set_ListaRetencionOld(List<cp_retencion_det_Info> lm, decimal IdProveedor)
        //{
        //    try
        //    {
        //        var tab = from A in lm.DefaultIfEmpty()
        //                  join B in lista_codigo_sri.DefaultIfEmpty() on new { A.IdCodigo_SRI } equals new { B.IdCodigo_SRI }

        //                  select new
        //                  {
        //                      A.IdCodigo_SRI,
        //                      A.IdCtaCble,
        //                      A.IdEmpresa,
        //                      A.re_tipoRet,
        //                      A.re_Porcen_retencion,
        //                      A.re_valor_retencion,
        //                      A.re_baseRetencion,
        //                      B.co_f_vigente_desde,
        //                      B.co_f_vigente_hasta
                            
                            
        //                  };

        //        foreach (var item in tab)
        //        {
        //            DataRow filas;
        //            filas = dtC.NewRow();
        //            filas[0] = item.IdEmpresa;
        //            filas[1] = IdProveedor;
        //            filas[2] = item.IdCodigo_SRI;
        //            filas[3] = item.re_tipoRet;
        //            filas[4] = item.re_Porcen_retencion;
        //            filas[5] = item.re_baseRetencion;
        //            filas[6] = item.re_valor_retencion;
        //            filas[7] = item.IdCtaCble;
        //            filas[8] = item.co_f_vigente_desde.ToString(format) + " - " + item.co_f_vigente_hasta.ToString(format);
        //            filas[9] = false;
        //            dtC.Rows.Add(filas);
        //            dtC.AcceptChanges();

        //            if (UC_Retencion.txtNumDoc.Text == "")
        //            {
                        
        //            }

        //            dtp_fechaEmisionRetencion.Value = _CabRetencion.fecha;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //    }
        //}

        //public cp_retencion_Info get_CabRetencion(ref bool ValidaReten)
        //{
        //    try
        //    {

        //        _CabRetencion.IdEmpresa = param.IdEmpresa;
        //        _CabRetencion.IdRetencion = 0;
        //        _CabRetencion.re_Tiene_RTiva = (_TieneRtIva)?"S":"N" ;
        //        _CabRetencion.re_Tiene_RFuente = (_TieneRtFte) ? "S" : "N";
        //        _CabRetencion.fecha = Convert.ToDateTime( dtp_fechaEmisionRetencion.Value.ToShortDateString() );
        //        _CabRetencion.serie1 = UC_Retencion.Get_Info_Talonario().Establecimiento;
        //        _CabRetencion.serie2 = UC_Retencion.Get_Info_Talonario().PuntoEmision;
        //        _CabRetencion.NAutorizacion = UC_Retencion.Get_Info_Talonario().NumAutorizacion;
        //        _CabRetencion.NumRetencion = Convert.ToString(UC_Retencion.txtNumDoc.EditValue);
        //        _CabRetencion.re_EstaImpresa = "N";
        //        _CabRetencion.Estado = "A";
        //        _CabRetencion.IdUsuario = param.IdUsuario;
        //        _CabRetencion.Fecha_Transac = DateTime.Now;
        //        _CabRetencion.ip = param.ip;
        //        _CabRetencion.nom_pc = param.nom_pc;

        //        return _CabRetencion;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //        return new cp_retencion_Info();        
        //    }
        //}
        
        //public List<cp_retencion_det_Info> get_lisRetencion(ref bool ValidaReten)
        //{
        //    try
        //    {

        //        ValidaReten = true;
        //        _ListaRetencion.Clear();
        //        dtp_fechaEmisionRetencion.Focus();
        //        double b_iva=0, b_rtf=0;
        //        int c = 0;
        //        return _ListaRetencion;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
        //        return new List<cp_retencion_det_Info>();
        //    }
        //}

        private void UCCp_RetencionOG_Load(object sender, EventArgs e)
        {

        }


    }
}

