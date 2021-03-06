﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt007_Data
    {
        public List<XCXP_Rpt007_Info> consultar_data(int IdEmpresa,int IdTipoCbteCble, decimal IdCbteCble_Nota,  ref string mensaje)
        {
            try
            {
                List<XCXP_Rpt007_Info> listadedatos = new List<XCXP_Rpt007_Info>();
                using (EntitiesCXP_General facturaProvee = new EntitiesCXP_General())
                {
                    var select = from h in facturaProvee.vwCXP_Rpt007
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdCbteCble_Nota == IdCbteCble_Nota
                                 && h.IdTipoCbte_Nota == IdTipoCbteCble
                                 select h;
                    foreach (var item in select)
                    {
                        XCXP_Rpt007_Info itemInfo = new XCXP_Rpt007_Info();
                        itemInfo.clave = item.clave;
                        itemInfo.cn_Nota = item.clave;
                        itemInfo.dc_Observacion = item.dc_Observacion;
                        itemInfo.dc_Valor = item.dc_Valor;
                        itemInfo.DebCre = item.DebCre;
                        itemInfo.Detalle = item.Detalle;
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.IdCbteCble_Nota = item.IdCbteCble_Nota;
                        itemInfo.IdCtaCble = item.IdCtaCble;
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdProveedor = item.IdProveedor;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdTipoCbte_Nota = item.IdTipoCbte_Nota;
                        itemInfo.IdTipoNota = item.IdTipoNota;
                        itemInfo.nom_Cuenta = item.nom_Cuenta;
                        itemInfo.nom_Proveedor = item.nom_Proveedor;
                        itemInfo.nom_Sucursal = item.nom_Sucursal;
                        itemInfo.nom_TipoCbte = item.nom_TipoCbte;
                        itemInfo.Nombre = item.Nombre;
                        itemInfo.secuencia = item.secuencia;
                        //itemInfo.valor_debe = Convert.ToDouble(item.valor_debe);
                        //itemInfo.valor_haber = Convert.ToDouble(item.valor_haber);
                        itemInfo.debe = item.valor_debe == 0 ? "" : Convert.ToString(item.valor_debe);
                        itemInfo.haber = item.valor_haber == 0 ? "" : Convert.ToString(item.valor_haber);
                        itemInfo.em_nombre = item.em_nombre;
                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt007_Info>();
            }
	}
          

                     
    }
}
