using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri.Retencion;
using Core.Erp.Info.class_sri.NotaDebito;
using Core.Erp.Info.class_sri.NotaCredito;
using Core.Erp.Info.class_sri.GuiaRemision;

namespace Core.Erp.Info.SRI
{
   public  class Comprobante_Info
    {
        public string IdComprobante { get; set; }
        public DateTime Fecha { get; set; }
        public Core.Erp.Info.General.Cl_Enumeradores.eTipoComprobante TipoCbte { get; set; }
        public string Observacion { get; set; }

        public factura CbteFactura { get; set; }
        public comprobanteRetencion cbteRet { get; set; }
        public notaCredito cbteNC { get; set; }
        public notaDebito cbteDeb { get; set; }
        public guiaRemision cbtGR { get; set; }
        public factura cbtFacruraR { get; set; }
        public Boolean Checked { get; set; }
        public string xml { get; set; }

        public Comprobante_Info()
        {

        }

        public Comprobante_Info(string _IdComprobante, DateTime _Fecha, Core.Erp.Info.General.Cl_Enumeradores.eTipoComprobante _TipoCbte
            , string _Observacion, factura _CbteFactura)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            CbteFactura = _CbteFactura;
        }

        public Comprobante_Info(string _IdComprobante, DateTime _Fecha, Core.Erp.Info.General.Cl_Enumeradores.eTipoComprobante _TipoCbte
             , string _Observacion, guiaRemision _cbtGR)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbtGR = _cbtGR;
        }




        public Comprobante_Info(string _IdComprobante, DateTime _Fecha, Core.Erp.Info.General.Cl_Enumeradores.eTipoComprobante _TipoCbte
              , string _Observacion, notaCredito _cbteNC)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbteNC = _cbteNC;

        }




        public Comprobante_Info(string _IdComprobante, DateTime _Fecha, Core.Erp.Info.General.Cl_Enumeradores.eTipoComprobante _TipoCbte
               , string _Observacion, notaDebito _cbteDeb)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbteDeb = _cbteDeb;

        }

        public Comprobante_Info(string _IdComprobante, DateTime _Fecha, Core.Erp.Info.General.Cl_Enumeradores.eTipoComprobante _TipoCbte
                , string _Observacion, comprobanteRetencion _cbteRet)
        {
            IdComprobante = _IdComprobante;
            Fecha = _Fecha;
            TipoCbte = _TipoCbte;
            Observacion = _Observacion;
            cbteRet = _cbteRet;

        }



        //public Comprobante_Info(string _IdComprobante, DateTime _Fecha, eTipoComprobante _TipoCbte
        //        , string _Observacion, factura _cbteFacR)
        //{
        //    IdComprobante = _IdComprobante;
        //    Fecha = _Fecha;
        //    TipoCbte = _TipoCbte;
        //    Observacion = _Observacion;
        //    cbtFacruraR = _cbteFacR;

        //}



    }
}
