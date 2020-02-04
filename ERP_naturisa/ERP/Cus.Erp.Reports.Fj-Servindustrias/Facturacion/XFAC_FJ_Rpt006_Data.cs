using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Cus.Erp.Reports.FJ.Facturacion
{
   public class XFAC_FJ_Rpt006_Data
   {
       tb_Empresa_Info Cbt = new tb_Empresa_Info();
       tb_Empresa_Data empresaData = new tb_Empresa_Data();

       public List<XFAC_FJ_Rpt006_Info> Get_List(int idEmpresa, int IdPeriodo)
       {
           try
           {
               List<XFAC_FJ_Rpt006_Info> Lista = new List<XFAC_FJ_Rpt006_Info>();
               Cbt = empresaData.Get_Info_Empresa(idEmpresa);

               using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
               {
                   var lst = from q in Context.vwFAC_FJ_Rpt006
                             where q.IdEmpresa == idEmpresa
                             && q.IdPeriodo == IdPeriodo
                           //  && q.IdPreFacturacion == IdPrefacturacion
                             select q;

                   foreach (var item in lst)
                   {
                       XFAC_FJ_Rpt006_Info Info = new XFAC_FJ_Rpt006_Info();
                       Info.IdEmpresa = item.IdEmpresa;
                       Info.IdPreFacturacion = item.IdPreFacturacion;
                       Info.observacion_det = item.observacion_det;
                       Info.Cantidad = item.Cantidad;
                       Info.Costo_Uni = item.Costo_Uni;
                       Info.Subtotal = item.Subtotal;
                       Info.Aplica_Iva = item.Aplica_Iva;
                       Info.Por_Iva = item.Por_Iva;
                       Info.Valor_Iva = item.Valor_Iva;
                       Info.IdPeriodo = item.IdPeriodo;
                       Info.Total = item.Total;
                       Info.cm_fecha = item.cm_fecha;
                       Info.oc_NumDocumento = item.oc_NumDocumento;
                       Info.IdProveedor = item.IdProveedor;                     
                       Info.nom_Cliente = item.nom_Cliente;
                       Info.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                       Info.nom_Centro_costo = item.nom_Centro_costo;
                       Info.nom_punto_cargo = item.nom_punto_cargo;
                       Info.nom_Producto = item.nom_Producto;
                       Info.IdProveedor = item.IdProveedor;                      
                       Info.co_factura = item.co_factura;
                       Info.IdPeriodo = item.IdPeriodo;                       
                       Info.em_nombre = Cbt.em_nombre;
                       Info.em_logo = Cbt.em_logo;
                       Info.IdNumMovi_mov_inv = item.IdNumMovi_mov_inv;
                       Info.nom_Proveedor = item.nom_Proveedor;
                       Info.nom_punto_cargo = item.nom_punto_cargo;
                       Info.Valor =Convert.ToDecimal( item.Subtotal);
                       Lista.Add(Info);


       

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
