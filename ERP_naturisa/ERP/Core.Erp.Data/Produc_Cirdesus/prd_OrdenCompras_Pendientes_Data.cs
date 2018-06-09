using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Facturacion;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Data.Compras;


namespace Core.Erp.Data.Produc_Cirdesus
{
  public  class prd_OrdenCompras_Pendientes_Data
  {
      string mensaje = "";
      public List<prd_OrdenesComprasPendientes_Info> Get_lisOrdenesPendientesAprobar(int IdEmpresa, string IdStado, DateTime Fdesde,DateTime Fhasta)
      {
          try
          {
              Fdesde =Convert.ToDateTime( Fdesde.ToShortDateString());
              Fhasta = Convert.ToDateTime(Fhasta.ToShortDateString());
              prd_OrdenesComprasPendientes_Info Info ;
              List<prd_OrdenesComprasPendientes_Info> ListadoOrdenCompraPendientes = new List<prd_OrdenesComprasPendientes_Info>();
              EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
              var registros = from A in OEEtapa.vwin_GeneracionCompraCidersus
                              where A.IdEmpresa == IdEmpresa
                              && A.IdEstadoAprobacion==IdStado
                              && A.oc_fecha<=Fhasta
                              && A.oc_fecha >= Fdesde
                              orderby A.IdOrdenCompra
                              select A;
              foreach (var item in registros)
              {
                  Info = new prd_OrdenesComprasPendientes_Info();
                  Info.check = false;
                  Info.IdEmpresa = item.IdEmpresa;
                  Info.IdSucursal=item.IdSucursal;
                  Info.IdOrdenCompra = item.IdOrdenCompra;
                  Info.IdProveedor = item.IdProveedor;
                  Info.oc_NumDocumento = item.oc_NumDocumento;
                  Info.oc_observacion = item.oc_observacion;
                  Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                  Info.do_total = item.do_total;
                  Info.do_iva = item.do_iva;
                  Info.do_subtotal = item.do_subtotal;
                  Info.do_descuento = item.do_descuento;
                  Info.do_Cantidad = item.do_Cantidad;
                  Info.NomProducto = item.pr_descripcion;
                  Info.do_precioCompra = item.do_precioCompra;
                  Info.IdProducto =Convert.ToInt32( item.IdProducto);
                  Info.Secuencia = item.Secuencia;
                  ListadoOrdenCompraPendientes.Add(Info);
                  
              }
              return ListadoOrdenCompraPendientes;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.ToString() + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.ToString());
          }
      }

      public bool AprobarOrdenesCompras(List<prd_OrdenesComprasPendientes_Info> ListadosOCAprobar)
      {
          try
          {
              using (EntitiesCompras context = new EntitiesCompras())
              {
                  foreach (var item in ListadosOCAprobar)
                  {
                      var contact = context.com_ordencompra_local.FirstOrDefault(A => A.IdEmpresa == item.IdEmpresa && A.IdOrdenCompra == item.IdOrdenCompra);
                      if (contact != null)
                      {
                          contact.IdEstadoAprobacion_cat = item.IdEstadoAprobacion;
                          context.SaveChanges();
                      }
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.ToString() + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.ToString());
          }
      }
    }
}
