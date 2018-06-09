using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt010_Data
    {
       public List<XCXP_Rpt010_Info> consultar_data(int IdEmpresa, decimal ProveedorIni, decimal ProveedorFin, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
       {
           try
           {
               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
               
               List<XCXP_Rpt010_Info> listadedatos = new List<XCXP_Rpt010_Info>();
               tb_Empresa_Info Cbt = new tb_Empresa_Info();
               tb_Empresa_Data empresaData = new tb_Empresa_Data();

               using (EntitiesCXP_General facturaProvee = new EntitiesCXP_General())
               {
                   var select = from h in facturaProvee.vwCXP_Rpt010
                                where h.IdEmpresa == IdEmpresa
                                && h.co_fechaOg >=FechaIni && h.co_fechaOg<=FechaFin
                                && h.IdProveedor>=ProveedorIni && h.IdProveedor<=ProveedorFin
                                select h;

                   Cbt = empresaData.Get_Info_Empresa(IdEmpresa);
                   foreach (var item in select)
                   {
                       XCXP_Rpt010_Info itemInfo = new XCXP_Rpt010_Info();
                       itemInfo.IdEmpresa = item.IdEmpresa;
                       itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                       itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                       itemInfo.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                       itemInfo.Documento = item.Documento;
                       itemInfo.nom_tipo_doc = item.nom_tipo_doc;
                       itemInfo.cod_tipo_doc = item.cod_tipo_doc;
                       itemInfo.co_fechaOg = item.co_fechaOg;
                       itemInfo.IdProveedor = item.IdProveedor;
                       itemInfo.nom_proveedor = item.nom_proveedor;
                       itemInfo.Valor_a_pagar = item.Valor_a_pagar;
                       itemInfo.Valor_debe = item.Valor_debe;
                       itemInfo.Valor_Haber = item.Valor_Haber;
                       itemInfo.Observacion = item.Observacion;
                       itemInfo.Ruc_Proveedor = item.Ruc_Proveedor;
                       itemInfo.representante_legal = item.representante_legal;
                       itemInfo.co_FechaFactura_vct = item.co_FechaFactura_vct;
                       listadedatos.Add(itemInfo);
                   }
               }
               return listadedatos;

           }
           catch (Exception ex)
           {

               return new List<XCXP_Rpt010_Info>();
           }
       }



    }
}
