using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.General;
using Core.Erp.Data.General;

using Core.Erp.Info.Facturacion;

namespace Core.Erp.Data.Facturacion
{
   public class fa_pedido_x_formaPago_Data
    {
       string mensaje = "";

       public Boolean GuardarDB(List<fa_pedido_x_formaPago_Info> Lista, ref string mensajeE)
       {
           try
           {
               int secuencia = 0;
               
               foreach (var item in Lista)
               {
                   using (EntitiesFacturacion Context = new EntitiesFacturacion())
                   {

                       fa_pedido_x_formaPago Address = new fa_pedido_x_formaPago();

                       secuencia = secuencia + 1;

                       Address.IdEmpresa = item.IdEmpresa;
                       Address.IdSucursal = item.IdSucursal;
                       Address.IdBodega = item.IdBodega;
                       Address.IdPedido = item.IdPedido;
                       Address.IdTipoFormaPago = item.IdTipoFormaPago;
                       Address.Secuencia = secuencia;                    
                       Address.Fecha = item.Fecha;
                       Address.Fecha_vct = item.Fecha_vtc;
                       Address.Dias_Plazo = item.Dias_Plazo;
                       Address.Por_Distribucion = item.Por_Distribucion;
                       Address.Valor = item.Valor;
                     
                       Context.fa_pedido_x_formaPago.Add(Address);
                       Context.SaveChanges();
                   }
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
               mensajeE = mensaje;
               throw new Exception(ex.ToString());
           }
       }

       public List<fa_pedido_x_formaPago_Info> Get_List_pedido_x_formaPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido)
       {
           try
           {
               List<fa_pedido_x_formaPago_Info> Lst = new List<fa_pedido_x_formaPago_Info>();
               EntitiesFacturacion oEnti = new EntitiesFacturacion();
               var Query = from q in oEnti.fa_pedido_x_formaPago
                           where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdPedido == IdPedido
                           select q;

               foreach (var item in Query)
               {
                   fa_pedido_x_formaPago_Info Obj = new fa_pedido_x_formaPago_Info();

                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdSucursal = item.IdSucursal;
                   Obj.IdBodega = item.IdBodega;
                   Obj.IdPedido = item.IdPedido;
                   Obj.IdTipoFormaPago = item.IdTipoFormaPago;
                   Obj.Secuencia = item.Secuencia;
                   Obj.Fecha = item.Fecha;
                   Obj.Fecha_vtc = item.Fecha_vct;
                   Obj.Dias_Plazo = item.Dias_Plazo;
                   Obj.Por_Distribucion = item.Por_Distribucion;
                   Obj.Valor = item.Valor;
                 

                   Lst.Add(Obj);
               }
               return Lst;
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
    
   }
}
