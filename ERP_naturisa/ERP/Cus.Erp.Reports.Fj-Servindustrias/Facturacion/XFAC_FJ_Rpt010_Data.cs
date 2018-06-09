using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;

namespace Cus.Erp.Reports.FJ.Facturacion
{
   public class XFAC_FJ_Rpt010_Data
   {
       tb_Empresa_Info Cbt = new tb_Empresa_Info();
       tb_Empresa_Data empresaData = new tb_Empresa_Data();

       public List<XFAC_FJ_Rpt010_Info> Get_List(int idEmpresa, int IdPeriodo)
       {
           try
           {
               List<XFAC_FJ_Rpt010_Info> Lista = new List<XFAC_FJ_Rpt010_Info>();

               Cbt = empresaData.Get_Info_Empresa(idEmpresa);

               using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
               {
                   var lst = from q in Context.GatosTransgandia_Rpt
                             where q.IdEmpresa == idEmpresa
                             && q.IdPeriodo == IdPeriodo
                             //  && q.IdPreFacturacion == IdPrefacturacion
                             select q;
                   foreach (var item in lst)
                   {
                       XFAC_FJ_Rpt010_Info info = new XFAC_FJ_Rpt010_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdPeriodo = item.IdPeriodo;
                       info.Proveedor = item.Proveedor;
                       info.Fecha = item.Fecha;
                       info.Proveedor = item.Proveedor;                    
                       info.Cantidad = item.Cantidad;
                       info.Total = item.Total;
                       info.Costounitario = item.Costounitario;
                       info.Factura = item.Factura;
                       info.Descripcion = item.Descripcion;
                       info.Fuerza = item.Fuerza;
                       info.NombreServicio = item.NombreServicio;
                       info.em_nombre = Cbt.em_nombre;
                       info.em_logo=Cbt.em_logo;
                       Lista.Add(info);
                   }
               }
               return Lista;
           }
           catch (Exception ex)
           {
               string mensaje = "";
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }
   
    }
}
