using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;


using Core.Erp.Info.Facturacion;

namespace Core.Erp.Data.Facturacion
{
  public  class fa_factura_det_otros_campos_Data
    {
      string mensaje = "";

      public Boolean GuardarDB(List<fa_factura_det_otros_campos_Info> Lst)
      {
          try
          {           
              foreach (var Item in Lst)
              {
                  //using (EntitiesFacturacion Context = new EntitiesFacturacion())
                  //{
                  //    fa_factura_det_otros_campos Deta = new fa_factura_det_otros_campos();
                     
                  //    Deta.IdEmpresa = Item.IdEmpresa;
                  //    Deta.IdSucursal = Item.IdSucursal;
                  //    Deta.IdBodega = Item.IdBodega;
                  //    Deta.IdCbteVta = Item.IdCbteVta;
                  //    Deta.Secuencia = Item.Secuencia;
                  //    Deta.IdPunto_Cargo = Item.IdPunto_Cargo;
                  //    Deta.Precio_Iva = Item.Precio_Iva;

                  //    Context.fa_factura_det_otros_campos.Add(Deta);
                  //    Context.SaveChanges();
                  //}
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
    }
}
