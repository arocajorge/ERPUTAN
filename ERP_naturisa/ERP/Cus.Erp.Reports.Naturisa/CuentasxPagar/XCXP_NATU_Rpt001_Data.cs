using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt001_Data
    {
       public List<XCXP_NATU_Rpt001_Info> consultar_data(int IdEmpresa, string TipoPersona, Decimal IdProveedorIni, Decimal IdProveedorFin, DateTime co_fechaOg_Ini, DateTime co_fechaOg_Fin, ref String mensaje)
        {
            try
            {
                List<XCXP_NATU_Rpt001_Info> listadedatos = new List<XCXP_NATU_Rpt001_Info>();

                DateTime FechaIni = Convert.ToDateTime(co_fechaOg_Ini.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(co_fechaOg_Fin.ToShortDateString());

                string SNombreProveedorFiltro = "";
                decimal ProveIni = 0;
                decimal ProveFin = 0;

                if (IdProveedorIni == 0 && IdProveedorFin == 0)
                {
                    ProveIni = 1;
                    ProveFin = 900000;
                    SNombreProveedorFiltro = "TODOS";
                }
                else
                {
                    ProveIni = IdProveedorIni;
                    ProveFin = IdProveedorFin;
                    SNombreProveedorFiltro = "POR RANGO DE PROVEEDOR";
                }

                if (TipoPersona == "TODOS")
                {
                    TipoPersona = "";
                }

                using (EntitiesCXP_Rpt_Naturisa clasedeproveedor = new EntitiesCXP_Rpt_Naturisa())
                {
                    //esto es un linQ
                    var select = from h in clasedeproveedor.vwCXP_NATU_Rpt001
                                 where  h.IdEmpresa == IdEmpresa
                                 && h.IdProveedor >= ProveIni && h.IdProveedor <= ProveFin                               
                                 && h.co_fechaOg >= FechaIni && h.co_fechaOg <=FechaFin
                                      select h;

                    if (TipoPersona != "")
                    {
                        select = select.Where(q => q.Tipo_persona.Trim() == TipoPersona.Trim());
                    }
                    Nullable<double> sum = 0;
                    foreach (var item in select)
                    {
                        XCXP_NATU_Rpt001_Info itemInfo = new XCXP_NATU_Rpt001_Info();
                        itemInfo.co_fechaOg = item.co_fechaOg;
                        itemInfo.cod_sucursal = item.cod_sucursal;
                        itemInfo.cod_tipo_doc = item.cod_tipo_doc;
                        itemInfo.Documento = item.Documento;
                        itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        itemInfo.IdClaseProveedor = item.IdClaseProveedor;
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        itemInfo.Tipo_persona = item.Tipo_persona;
                        itemInfo.IdProveedor = item.IdProveedor;
                        itemInfo.IdPersona = item.IdPersona;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        itemInfo.nom_clase_proveedor = item.nom_clase_proveedor;
                        itemInfo.nom_proveedor = item.nom_proveedor;
                        itemInfo.nom_sucursal = item.nom_sucursal;
                        itemInfo.nom_tipo_doc = item.nom_tipo_doc;
                        itemInfo.Observacion = item.Observacion;
                        itemInfo.Valor_debe = item.Valor_debe;
                        sum = sum + itemInfo.Valor_debe;
                        itemInfo.Valor_Haber = item.Valor_Haber;
                        sum = sum - itemInfo.Valor_Haber;
                        itemInfo.Valor_a_pagar = item.Valor_a_pagar;
                        itemInfo.nom_TipoPersona = item.nom_TipoPersona;
                        listadedatos.Add(itemInfo);
               }
                    sum = sum + 0;
             }
                
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_NATU_Rpt001_Info>();
            }
        }

    }
}
