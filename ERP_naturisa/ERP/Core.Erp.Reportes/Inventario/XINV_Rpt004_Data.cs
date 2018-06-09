using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Inventario
{
     public class XINV_Rpt004_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

         public List<XINV_Rpt004_Info> consultar_data(int IdEmpresa, int IdSucursal_inv_Ini, int IdSucursal_inv_Fin, decimal IdProductoIni, decimal IdProductoFin
             , decimal IdProveedorIni, decimal IdProveedorFin, DateTime Fecha_oc_Ini, DateTime Fecha_oc_Fin, ref String mensaje)
       {
           
             try
           {
               List<XINV_Rpt004_Info> lista = new List<XINV_Rpt004_Info>();
               using (Entities_Inventario_General IngporCom = new Entities_Inventario_General())
               {
                   double tot = 0;

                   Fecha_oc_Ini = Convert.ToDateTime(Fecha_oc_Ini.ToShortDateString());
                   Fecha_oc_Fin = Convert.ToDateTime(Fecha_oc_Fin.ToShortDateString());


                   var select = from h in IngporCom.vwINV_Rpt004
                                where h.Fecha_oc >= Fecha_oc_Ini
                                && h.Fecha_oc <= Fecha_oc_Fin
                                && h.IdEmpresa == IdEmpresa
                                && h.IdSucursal_inv >= IdSucursal_inv_Ini && h.IdSucursal_inv <= IdSucursal_inv_Fin
                                && h.IdProducto >= IdProductoIni && h.IdProducto <= IdProductoFin                       
                                && IdProveedorIni <= h.IdProveedor && h.IdProveedor <= IdProveedorFin
                                select h;

                   infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                   foreach (var item in select)
                   {
                       XINV_Rpt004_Info itemInfo = new XINV_Rpt004_Info();
                       itemInfo.IdEmpresa = item.IdEmpresa;
                       itemInfo.IdSucursal_oc = item.IdSucursal_oc;
                       itemInfo.IdOrdenCompra = item.IdOrdenCompra;
                       itemInfo.Fecha_oc = item.Fecha_oc;
                       itemInfo.Observacion_oc = item.Observacion_oc;
                       itemInfo.Estado_oc = item.Estado_oc;
                       itemInfo.IdProveedor = item.IdProveedor;
                       itemInfo.nom_proveedor = item.nom_proveedor;
                       itemInfo.IdProducto = item.IdProducto;
                       itemInfo.nom_producto = item.nom_producto;
                       itemInfo.IdSucursal_inv = item.IdSucursal_inv;
                       itemInfo.IdBodega_inv = item.IdBodega_inv;
                       itemInfo.Cant_Pedida_oc = item.Cant_Pedida_oc;
                       itemInfo.Cant_Recibida_inv = item.Cant_Recibida_inv;
                       itemInfo.Cant_x_Recivir_inv = item.Cant_x_Recivir_inv;
                       itemInfo.EstadoPago = item.EstadoPago;
                       itemInfo.Logo = infoEmp.em_logo_Image;
                       itemInfo.Empresa = infoEmp.em_nombre;
                       lista.Add(itemInfo);
                   }

               }
              return lista;
            }
           catch (Exception ex)
           {
                       
              return new List<XINV_Rpt004_Info>();
               
           }
     
     
       }
            
    }

 }