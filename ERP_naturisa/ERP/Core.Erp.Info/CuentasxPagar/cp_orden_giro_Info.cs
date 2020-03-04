using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Core.Erp.Info.Contabilidad;
using System.Xml.Serialization;
using Core.Erp.Info.General;

using System.Drawing;

namespace Core.Erp.Info.CuentasxPagar
{
    [DataContract]
    [Serializable]
    [XmlRoot("Ordenes")]
    public class cp_orden_giro_Info
    {
         [XmlElement("IdEmpresa")]
        public int IdEmpresa { get; set; }

         [XmlElement("tpIdProv")]
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public decimal IdProveedor { get; set; }
        public DateTime co_fechaOg { get; set; }
        public string co_serie { get; set; }
        public string co_factura { get; set; }
        public DateTime co_FechaFactura { get; set; }
        public DateTime co_FechaFactura_vct { get; set; }
        public int co_plazo { get; set; }
        public string co_observacion { get; set; }
        public double co_subtotal_iva { get; set; }
        public double co_subtotal_siniva { get; set; }
        public double co_baseImponible { get; set; }
        public double co_Por_iva { get; set; }
        public double co_valoriva { get; set; }
        public int? IdCod_ICE { get; set; }
        public double co_Ice_base { get; set; }
        public double co_Ice_por { get; set; }
        public double co_Ice_valor { get; set; }
        public double co_Serv_por { get; set; }
        public double co_Serv_valor { get; set; }
        public double co_OtroValor_a_descontar { get; set; }
        public double co_OtroValor_a_Sumar { get; set; }
        public double co_BaseSeguro { get; set; }
        public double co_total { get; set; }
        public double co_valorpagar { get; set; }
        public string co_vaCoa { get; set; }
        public int? IdIden_credito { get; set; }
        public int? IdCod_101 { get; set; }
        public string IdTipoServicio { get; set; }
        public string IdCtaCble_Gasto { get; set; }
        public string IdUsuario { get; set; }
        public DateTime ? Fecha_Transac { get; set; }
        public string Estado { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }

        public string IdCtaCble_IVA { get; set; }
        public bool En_conciliacion { get; set; }
        public string co_retencionManual { get; set; }
        public decimal? IdCbteCble_Anulacion { get; set; }
        public int? IdTipoCbte_Anulacion { get; set; }
        public double? saldo { get; set; }
        public double ? Total_Retencion { get; set; }
        public string EstaEnBase  { get; set; }

        public string sIdCredito { get; set; }
        
        public string IdCentroCosto { get; set; }
        public int? IdSucursal { get; set; }

        public string tc_TipoCbte { get; set; }
        public decimal? IdTipoFlujo  { get; set; }

        public string TipoFlujo  { get; set; }
        public string PagoLocExt { get; set; }
        public string PaisPago { get; set; }
        public string ConvenioTributacion { get; set; }
        public string PagoSujetoRetencion { get; set; }

      
        public DateTime fecha_autorizacion { get; set; }

        public string Num_Autorizacion { get; set; }
        public string Num_Autorizacion_Imprenta { get; set; }

        public string IdCtaCble_CXP { get; set; }

        public int? IdEmpresa_ret { get; set; }
        public decimal? IdRetencion { get; set; }
        public string re_serie { get; set; }
        public string re_NumRetencion { get; set; }
        public string re_EstaImpresa { get; set; }

        public double co_propina { get; set; }
        public double co_IRBPNR { get; set; }

        public string IdEstadoAprobacion { get; set; }
        public string IdEstadoAprobacion_aux { get; set; }
        public int IdBanco { get; set; }
        public string nom_tipo_Documento { get; set; }
        public string IdTipo_op { get; set; }
        public bool check { get; set; }
        public string nom_flujo { get; set; }
        public string IdFormaPago { set; get; }

        public string Referencia { get; set; }

        public Bitmap Icono { get; set; }
        public int Dias_Vencidos { get; set; }
        public Cl_Enumeradores.eTipoVencimiento_x_OG Tipo_Vcto{ get; set; }

        public double Total_Pagado { get; set; }
        public double Saldo_OG { get; set; }

        public double Saldo_OG_AUX { get; set; }

        public double Valor_a_Pagar { get; set; }

        public string Estado_Cancelacion { get; set; }
        public string cod_Documento { get; set; }

        public DateTime? co_FechaContabilizacion { get; set; }

        public double? BseImpNoObjDeIva { get; set; }
        
        public string nomEmpresa { get; set; }

        public decimal IdPersona { get; set; }

        
        public cp_proveedor_Info InfoProveedor { get; set; }
        

        public ct_Cbtecble_Info Info_CbteCble_x_OG { get; set; }
        
        public cp_retencion_Info Info_Retencion { get; set; }
        public cp_orden_pago_Info Info_Orden_Pago { get; set; }
        public cp_cuotas_x_doc_Info Info_cuotas_x_doc { get; set; }
        public List<cp_reembolso_Info> lst_reembolso { get; set; }

        public List<cp_orden_giro_pagos_sri_Info> lst_formasPagoSRI{ get; set; }
        public List<cp_orden_giro_x_imp_ordencompra_ext_Info> LisImportacion { get; set; }
        public List<cp_orden_giro_x_com_ordencompra_local_Info> LstImportacionOC  { get; set; }
        public List<cp_orden_giro_det_Info> ListDet { get; set; }

        public Nullable<Boolean> es_retencion_electronica { get; set; }
        public Nullable<Boolean> cp_es_comprobante_electronico { get; set; }

        public Nullable<int> IdTipoMovi { get; set; }

        public string Tipodoc_a_Modificar { get; set; }
        public string estable_a_Modificar { get; set; }
        public string ptoEmi_a_Modificar { get; set; }
        public string num_docu_Modificar { get; set; }
        public string aut_doc_Modificar { get; set; }

        public Nullable<bool> Tiene_ingresos { get; set; }
        //Campos cuota
        public Nullable<decimal> IdCuota { get; set; }
        public Nullable<int> Secuencia { get; set; }
        public Nullable<double> Valor_cuota { get; set; }
        
        public cp_orden_giro_Info()
        {
        
            Info_CbteCble_x_OG = new ct_Cbtecble_Info();
            Info_Retencion = new cp_retencion_Info();
            Info_Orden_Pago = new cp_orden_pago_Info();
            Info_cuotas_x_doc = new cp_cuotas_x_doc_Info();
            lst_reembolso = new List<cp_reembolso_Info>();

            lst_formasPagoSRI= new List<cp_orden_giro_pagos_sri_Info>();
            LisImportacion = new List<cp_orden_giro_x_imp_ordencompra_ext_Info>();
            LstImportacionOC = new List<cp_orden_giro_x_com_ordencompra_local_Info>();
            InfoProveedor = new cp_proveedor_Info();

        }
    }

    public class cp_orden_giro_consulta_Info
    {

        public int IdEmpresa { get; set; }

        public int IdTipoCbte_Ogiro { get; set; }

        public decimal IdCbteCble_Ogiro { get; set; }

        public string co_factura { get; set; }

        public DateTime co_fechaOg { get; set; }

        public DateTime co_FechaFactura { get; set; }

        public string co_observacion { get; set; }

        public double co_subtotal_iva { get; set; }

        public double co_subtotal_siniva { get; set; }

        public double co_valoriva { get; set; }

        public double co_baseImponible { get; set; }

        public string Estado { get; set; }

        public double Total_Retencion { get; set; }

        public double saldo { get; set; }

        public double co_total { get; set; }

        public string re_NumRetencion { get; set; }

        public decimal? IdTipoFlujo { get; set; }

        public string descripcion_clas_prove { get; set; }

        public string pr_nombre { get; set; }

        public string Estado_Cancelacion { get; set; }
    }
}

