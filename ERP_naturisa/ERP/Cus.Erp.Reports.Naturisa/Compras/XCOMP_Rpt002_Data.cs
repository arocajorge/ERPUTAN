using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_Rpt002_Data
    {
        public List<XCOMP_Rpt002_Info> consultar_data(int idempresa, int idsucursal ,decimal IdSolicitudCompra)
        { 
            try
            {
                List<XCOMP_Rpt002_Info> listadatos= new List<XCOMP_Rpt002_Info>();

                using (EntitiesCompras_natu_rpt ESolicitud = new EntitiesCompras_natu_rpt())
                {
                    var select = from j in ESolicitud.vwCOMP_Rpt002
                                 where j.IdEmpresa == idempresa
                                 && j.IdSucursal == idsucursal
                                 && j.IdSolicitudCompra == IdSolicitudCompra
                                 select j;

                    foreach (var item in select)
                    {
                       XCOMP_Rpt002_Info itemInfo = new XCOMP_Rpt002_Info();
                       itemInfo.do_Cantidad = item.do_Cantidad;
                       itemInfo.em_direccion = item.em_direccion;
                       itemInfo.em_ruc = item.em_ruc;
                       itemInfo.em_telefonos = item.em_telefonos;
                       itemInfo.fecha = item.fecha;
                       itemInfo.IdDepartamento =Convert.ToInt32( item.IdDepartamento);
                       itemInfo.IdEmpresa = item.IdEmpresa;
                       itemInfo.IdPersona_comprador = item.IdPersona_comprador;
                       itemInfo.IdPersona_Solicita = item.IdPersona_Solicita;
                       itemInfo.IdProducto = Convert.ToDecimal(item.IdProducto);
                       itemInfo.IdSolicitudCompra = item.IdSolicitudCompra;
                       itemInfo.IdSucursal = item.IdSucursal;
                       itemInfo.nom_departamento = item.nom_departamento;
                       itemInfo.nom_empresa = item.nom_empresa;
                       itemInfo.nom_personaComp = item.nom_personaComp;
                       itemInfo.nom_personaSol = item.nom_personaSol;
                       itemInfo.nom_producto = item.nom_producto;
                       itemInfo.nom_sucursal = item.nom_sucursal;
                       itemInfo.observacion = item.observacion;
                       itemInfo.IdPunto_cargo = Convert.ToInt32(item.IdPunto_cargo);
                       itemInfo.nom_punto_cargo = item.nom_punto_cargo;
                       itemInfo.IdCentroCosto = item.IdCentroCosto;
                       itemInfo.nom_Centro_Costo = item.nom_Centro_Costo;
                       itemInfo.IdSubCentroCosto = item.IdSubCentroCosto;
                       itemInfo.nom_SubCentroCosto = item.nom_SubCentroCosto;
                       itemInfo.nom_unidad = item.nom_unidad;
                       itemInfo.pr_codigo = item.pr_codigo;                                                                                                                                                                                                
                       listadatos.Add(itemInfo);
                    }                                    
                }
                return listadatos;
            }
            catch (Exception ex)           
            {
                return new List<XCOMP_Rpt002_Info>();
            }

                        
        }

    }
}
