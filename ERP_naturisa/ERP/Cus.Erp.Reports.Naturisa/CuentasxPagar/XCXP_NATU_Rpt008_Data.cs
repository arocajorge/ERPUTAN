using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
   public class XCXP_NATU_Rpt008_Data
    {

       public List<XCXP_NATU_Rpt008_Info> consultar_Data(int IdEmpresa, decimal ClaseProveedorIni, decimal ClaseProveedorFin, decimal IdProveedorIni, decimal IdProveedorFin, DateTime FechaIni, DateTime FechaFin,bool Mostrar_saldo_cero ,ref string mensaje)
       {
           try
           {
               string format = "dd/MM/yyyy";
               
               List<XCXP_NATU_Rpt008_Info> listadedatos = new List<XCXP_NATU_Rpt008_Info>();

               DateTime Fecha_Ini = Convert.ToDateTime(FechaIni.ToShortDateString());
               DateTime Fecha_Fin = Convert.ToDateTime(FechaFin.ToShortDateString());

               decimal ClaseProveIni = 0;
               decimal ClaseProveFin = 0;

               if (ClaseProveedorIni == 0 && ClaseProveedorFin == 0)
               {
                   ClaseProveIni = 1;
                   ClaseProveFin = 99999999;

               }
               else
               {
                   ClaseProveIni = ClaseProveedorIni;
                   ClaseProveFin = ClaseProveedorFin;

               }


               using (EntitiesCXP_Rpt_Naturisa facturaProvee = new EntitiesCXP_Rpt_Naturisa())
               {
                   var select = from h in facturaProvee.vwCXP_NATU_Rpt008
                                where h.IdEmpresa == IdEmpresa
                                && h.IdClaseProveedor >= ClaseProveIni && h.IdClaseProveedor <= ClaseProveFin
                                && h.co_fechaOg >= Fecha_Ini && h.co_fechaOg <= Fecha_Fin
                                && IdProveedorIni <= h.IdProveedor && h.IdProveedor <= IdProveedorFin
                                select h;

                   foreach (var item in select)
                   {
                       XCXP_NATU_Rpt008_Info itemInfo = new XCXP_NATU_Rpt008_Info();

                       itemInfo.IdEmpresa = item.IdEmpresa;
                       itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                       itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                       itemInfo.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                       itemInfo.co_serie = item.co_serie;
                       itemInfo.co_FechaFactura = item.co_FechaFactura;
                       itemInfo.co_fechaOg = item.co_fechaOg;                                                                                                        
                       itemInfo.IdProveedor = item.IdProveedor;                                                          
                       itemInfo.nom_proveedor = item.nom_proveedor;
                       itemInfo.co_factura = item.co_factura;
                       itemInfo.co_observacion = item.co_observacion;
                       itemInfo.co_subtotal_iva = item.co_subtotal_iva;
                       itemInfo.co_subtotal_siniva = item.co_subtotal_siniva;
                       itemInfo.co_baseImponible = item.co_baseImponible;
                       itemInfo.co_Por_iva = item.co_Por_iva;
                       itemInfo.co_total = item.co_total;
                       itemInfo.co_valorpagar = item.co_valorpagar;
                       itemInfo.Total_Retencion = item.Total_Retencion;
                       itemInfo.Total_Pagos = item.Total_Pagos;
                       itemInfo.Total_NC = item.Total_NC;
                       itemInfo.Saldo = item.Saldo == null ? 0 : (double)item.Saldo;
                       itemInfo.IdTipoFlujo = item.IdTipoFlujo;
                       itemInfo.IdTipoServicio = item.IdTipoServicio;
                       itemInfo.IdSucursal = item.IdSucursal;
                       itemInfo.cod_TipoDocumento = item.cod_TipoDocumento;
                       itemInfo.nom_TipoDocumento = item.nom_TipoDocumento;
                       itemInfo.nom_TipoFlujo = item.nom_TipoFlujo;
                       itemInfo.nom_Sucursal = item.nom_Sucursal;
                       itemInfo.IdClaseProveedor = item.IdClaseProveedor;
                       itemInfo.nom_claseProveedor = item.nom_claseProveedor;

                       itemInfo.S_co_fechaOg = item.co_fechaOg == null ? "" :item.co_fechaOg.ToString(format);

                       listadedatos.Add(itemInfo);
                   }
               }

               if (!Mostrar_saldo_cero)
               {
                   listadedatos = listadedatos.Where(q => q.Saldo != 0).ToList();
               }

               return listadedatos;
           }
           catch (Exception ex)
           {
               return new List<XCXP_NATU_Rpt008_Info>();
           }
       }
    }
}
