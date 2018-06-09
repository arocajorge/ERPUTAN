using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
   public class fa_notaCreDeb_x_cxc_cobro_Data
    {
       public Boolean GuardarDB(fa_notaCreDeb_x_cxc_cobro_Info Item, ref string mensaje)
       {
           try
           {
               using (EntitiesFacturacion oEnti = new EntitiesFacturacion())
               {

                   fa_notaCreDeb_x_cxc_cobro fa_nota = new fa_notaCreDeb_x_cxc_cobro();

                   fa_nota.IdEmpresa_cbr = Item.IdEmpresa_cbr;
                   fa_nota.IdSucursal_cbr= Item.IdSucursal_cbr;
                   fa_nota.IdCobro_cbr= Item.IdCobro_cbr;
                   fa_nota.IdEmpresa_nt = Item.IdEmpresa_nt;
                   fa_nota.IdSucursal_nt = Item.IdSucursal_nt;
                   fa_nota.IdBodega_nt = Item.IdBodega_nt;
                   fa_nota.IdNota_nt = Item.IdNota_nt;
                   fa_nota.Valor_cobro=Item.Valor_cobro;

                   oEnti.fa_notaCreDeb_x_cxc_cobro.Add(fa_nota);
                   oEnti.SaveChanges();
               }

               return true;
           }
           catch (Exception ex)
           {            
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }

       public fa_notaCreDeb_x_cxc_cobro_Info Get_info_cobro_x_nc(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
       {
           try
           {
               fa_notaCreDeb_x_cxc_cobro_Info info = new fa_notaCreDeb_x_cxc_cobro_Info();

               using (EntitiesFacturacion context = new EntitiesFacturacion())
               {
                   var lst = from q in context.fa_notaCreDeb_x_cxc_cobro
                             where q.IdEmpresa_nt == IdEmpresa
                             && q.IdSucursal_nt == IdSucursal
                             && q.IdBodega_nt == IdBodega
                             && q.IdNota_nt == IdNota
                             select q;

                   foreach (var item in lst)
                   {
                       info.IdEmpresa_cbr = item.IdEmpresa_cbr;
                       info.IdSucursal_cbr = item.IdSucursal_cbr;
                       info.IdCobro_cbr = item.IdCobro_cbr;
                       info.IdEmpresa_nt = item.IdEmpresa_nt;
                       info.IdSucursal_nt = item.IdSucursal_nt;
                       info.IdBodega_nt = item.IdBodega_nt;
                       info.IdNota_nt = item.IdNota_nt;
                       info.Valor_cobro = item.Valor_cobro;
                   }
               }

               return info;
           }
           catch (Exception ex)
           {
               string mensaje = "";
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }
    
   }
}
