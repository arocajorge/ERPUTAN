using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt019_Data
    {
       public List<XCXP_Rpt019_Info> consultar_data(int idempresa, decimal IdConciliacion_Caja, ref string mensaje)
       {
           tb_Empresa_Data dataEmp = new tb_Empresa_Data();
           tb_Empresa_Info infoEmp = new tb_Empresa_Info();

           List<XCXP_Rpt019_Info> listadatos = new List<XCXP_Rpt019_Info>();
           try
           {

               using (EntitiesCXP_General OEnti = new EntitiesCXP_General())
               {

                   var select = from q in OEnti.vwCXP_Rpt019
                                where q.IdEmpresa == idempresa
                                && q.IdConciliacion_Caja == IdConciliacion_Caja
                                select q;
                   infoEmp = dataEmp.Get_Info_Empresa(idempresa);
                   foreach (var item in select)
                   {

                       XCXP_Rpt019_Info itemInfo = new XCXP_Rpt019_Info();

                       itemInfo.IdEmpresa = item.IdEmpresa;

                       itemInfo.IdConciliacion_Caja = item.IdConciliacion_Caja;
                       itemInfo.Fecha = item.Fecha;
                       itemInfo.IdCaja = item.IdCaja;
                       itemInfo.IdEstadoCierre = item.IdEstadoCierre;
                       itemInfo.Observacion = item.Observacion;
                       itemInfo.IdEmpresa_op = item.IdEmpresa_op;
                       itemInfo.IdOrdenPago_op = item.IdOrdenPago_op;
                       itemInfo.ca_Descripcion = item.ca_Descripcion;
                       itemInfo.IdEmpresa_OGiro = item.IdEmpresa_OGiro;
                       itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                       itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                       itemInfo.co_serie = item.co_serie;
                       itemInfo.co_factura = item.co_factura;
                       itemInfo.co_valorpagar = item.co_valorpagar;
                       itemInfo.co_observacion = item.co_observacion;
                       itemInfo.Nombre = item.Nombre;
                       itemInfo.co_FechaFactura = item.co_FechaFactura;
                       itemInfo.co_fechaOg = item.co_fechaOg;
                       itemInfo.Beneficiario = item.pr_nombre;
                       itemInfo.nomEmpresa = infoEmp.NombreComercial;

                       listadatos.Add(itemInfo);
                   }
               }
               return listadatos;

           }
           catch (Exception ex)
           {

               return new List<XCXP_Rpt019_Info>(); ;
           }

       }
    }
}
