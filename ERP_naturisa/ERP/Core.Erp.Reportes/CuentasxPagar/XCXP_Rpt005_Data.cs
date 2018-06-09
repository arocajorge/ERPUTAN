using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt005_Data
    {
       public List<XCXP_Rpt005_Info> consultar_data(int IdEmpresa,decimal IdOrdenPago,decimal IdEntidad, ref string mensaje )
       {
           try
           {
               List<XCXP_Rpt005_Info> listadedatos = new List<XCXP_Rpt005_Info>();
               using (EntitiesCXP_General facturaProvee = new EntitiesCXP_General())
               {
                   var select = from h in facturaProvee.vwCXP_Rpt005
                                where h.IdEmpresa == IdEmpresa
                                && h.IdOrdenPago == IdOrdenPago
                                && h.IdEntidad == IdEntidad
                                select h;
                   foreach (var item in select)
                   {
                       XCXP_Rpt005_Info itemInfo = new XCXP_Rpt005_Info();
                       itemInfo.Estado = item.Estado;
                       itemInfo.Fecha = item.Fecha;
                       itemInfo.fecha_hora_Aproba = Convert.ToDateTime(item.fecha_hora_Aproba);
                       itemInfo.Fecha_Pago = item.Fecha_Pago;
                       itemInfo.IdBanco = Convert.ToInt32(item.IdBanco);
                       itemInfo.IdCbteCble_cxp = Convert.ToDecimal(item.IdCbteCble_cxp);
                       itemInfo.IdEmpresa = item.IdEmpresa;
                       itemInfo.IdEmpresa_cxp = Convert.ToInt32(item.IdEmpresa_cxp);
                       itemInfo.IdEntidad = Convert.ToDecimal(item.IdEntidad);
                       itemInfo.IdEstadoAprobacion = item.IdEstadoAprobacion;
                       itemInfo.IdFormaPago = item.IdFormaPago;
                       itemInfo.IdOrdenPago = item.IdOrdenPago;
                       itemInfo.IdPersona = item.IdPersona;
                       itemInfo.IdTipo_op = item.IdTipo_op;
                       itemInfo.IdTipo_Persona = item.IdTipo_Persona;
                       itemInfo.IdTipoCbte_cxp = Convert.ToInt32(item.IdTipoCbte_cxp);
                       itemInfo.IdUsuario_Aprobacion = item.IdUsuario_Aprobacion;
                       itemInfo.Motivo_aproba = item.Motivo_aproba;
                       itemInfo.nom_Banco = item.nom_Banco;
                       itemInfo.nom_beneficiario = item.nom_beneficiario;
                       itemInfo.nom_EstadoAprobacion = item.nom_EstadoAprobacion;
                       itemInfo.nom_FormaPago = item.nom_FormaPago;
                       itemInfo.nom_PagoTipo = item.nom_PagoTipo;
                       itemInfo.Observacion = item.Observacion;
                       itemInfo.Referencia = item.Referencia;
                       itemInfo.Secuencia = item.Secuencia;
                       itemInfo.Valor_a_pagar = item.Valor_a_pagar;
                       itemInfo.num_CuentaBanco = item.num_CuentaBanco;
                       itemInfo.saldo = Convert.ToDouble(item.saldo);
                       itemInfo.valor_factura = Convert.ToDouble(item.valor_factura);

                       itemInfo.em_nombre = item.em_nombre;

                       itemInfo.co_total = Convert.ToDouble(item.co_total);
                       itemInfo.Total_Retencion = item.Total_Retencion;


                       listadedatos.Add(itemInfo);
                   }
               }
               return listadedatos;

           }
           catch (Exception ex)
           {

               return new List<XCXP_Rpt005_Info>();
           }
	}
    }
}
