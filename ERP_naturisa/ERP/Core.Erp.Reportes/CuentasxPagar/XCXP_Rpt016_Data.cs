using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt016_Data
    {
       public List<XCXP_Rpt016_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin)
       {

           try
           {

               List<XCXP_Rpt016_Info> listadedatos = new List<XCXP_Rpt016_Info>();
               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());


               using (EntitiesCXP_General Oenti = new EntitiesCXP_General())
               {


                   var select = from h in Oenti.vwCXP_Rpt016
                                where h.IdEmpresa == idempresa
                                && h.co_fechaOg >= FechaIni && h.co_fechaOg <= FechaFin
                                select h;

                   foreach (var item in select)
                   {

                       XCXP_Rpt016_Info itemInfo = new XCXP_Rpt016_Info();


                       itemInfo.IdEmpresa = item.IdEmpresa;
                       itemInfo.IdSucursal = item.IdSucursal == null ? 0 : Convert.ToInt32(item.IdSucursal);
                       itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                       itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                       itemInfo.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                       itemInfo.IdProveedor = item.IdProveedor;
                       itemInfo.num_factura = item.num_factura;
                       itemInfo.co_FechaFactura = item.co_FechaFactura;
                       itemInfo.IdProveedor = item.IdProveedor;
                       itemInfo.nom_proveedor = item.nom_proveedor;
                       itemInfo.IdEstadoAprobacion = item.IdEstadoAprobacion;
                       itemInfo.co_observacion = item.co_observacion;
                       itemInfo.co_fechaOg = item.co_fechaOg;
                       itemInfo.co_subtotal_iva = item.co_subtotal_iva;
                       itemInfo.co_subtotal_siniva = item.co_subtotal_siniva;
                       itemInfo.co_baseImponible = item.co_baseImponible;
                       itemInfo.co_Por_iva = item.co_Por_iva;
                       itemInfo.co_valoriva = item.co_valoriva;
                       itemInfo.co_total = item.co_total;
                       itemInfo.co_valorpagar = item.co_valorpagar;
                       itemInfo.nom_tipo_Documento = item.nom_tipo_Documento;
                       itemInfo.nom_proveedor = item.nom_proveedor;
                       itemInfo.CodTipoCbte = item.CodTipoCbte;
                       itemInfo.tc_TipoCbte = item.tc_TipoCbte;
                       itemInfo.IdTipo_op = item.IdTipo_op;
                       itemInfo.IdEstadoAprobacion = item.IdEstadoAprobacion;
                       itemInfo.co_FechaFactura_vct = item.co_FechaFactura_vct;
                       itemInfo.IdTipoFlujo = item.IdTipoFlujo == null ? 0 : Convert.ToDecimal(item.IdTipoFlujo);
                       itemInfo.nom_flujo = item.nom_flujo;
                       itemInfo.IdPersona = item.IdPersona;
                       itemInfo.cod_Documento = item.cod_Documento;
                       itemInfo.nom_Estado_Aproba = item.nom_Estado_Aproba;
                       itemInfo.Su_Descripcion = item.Su_Descripcion;
          
                       listadedatos.Add(itemInfo);

                   }
               }
               return listadedatos;
           }
           catch (Exception ex)
           {
               return new List<XCXP_Rpt016_Info>();
           }


       }
    }
}
