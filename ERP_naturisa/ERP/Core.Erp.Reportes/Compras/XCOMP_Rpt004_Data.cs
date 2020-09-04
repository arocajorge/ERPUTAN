using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Core.Erp.Reportes.Compras
{
   public class XCOMP_Rpt004_Data
    {

       public List<XCOMP_Rpt004_Info> Cargar_data(int idempresa , DateTime FechaIni ,DateTime FechaFin)
       {

           try
           {

               List<XCOMP_Rpt004_Info> listadedatos = new List<XCOMP_Rpt004_Info>();
               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

               using (EntitiesCompra_reporte_Ge ListadoOrdenCompra = new EntitiesCompra_reporte_Ge())
               {


                   var select = ListadoOrdenCompra.vwCOMP_Rpt004.Where(h => h.IdEmpresa == idempresa
                                && h.oc_fecha >= FechaIni && h.oc_fecha <= FechaFin).ToList();

                   foreach (var item in select)
                   {

                       XCOMP_Rpt004_Info itemInfo = new XCOMP_Rpt004_Info{
                         IdEmpresa= item.IdEmpresa,
                         IdSucursal= item.IdSucursal,
                         IdOrdenCompra= item.IdOrdenCompra,
                         documento= item.documento,
                         oc_fecha= item.oc_fecha,
                         oc_observacion= item.oc_observacion,
                         IdComprador= item.IdComprador,
                         nom_comprador= item.nom_comprador,
                         IdProveedor= item.IdProveedor,
                         nom_proveedor= item.nom_proveedor,
                         IdMotivo= item.IdMotivo,
                         Nom_motivo_oc= item.Nom_motivo_oc,
                         IdProducto= item.IdProducto,
                         nom_producto= item.nom_producto,
                         do_Cantidad= item.do_Cantidad,
                         precio= item.precio,
                         do_subtotal= item.do_subtotal,
                         do_iva= item.do_iva,
                         do_total= item.do_total,
                         IdPunto_cargo= item.IdPunto_cargo,
                         nom_punto_cargo= item.nom_punto_cargo,
                         IdCentroCosto= item.IdCentroCosto,
                         Centro_costo= item.Centro_costo,
                         IdCentroCosto_sub_centro_costo= item.IdCentroCosto_sub_centro_costo,
                         sub_centro_costo= item.sub_centro_costo,

                         Anio = item.oc_fecha.Year,
                         Mes = item.oc_fecha.Month,
                         Dia = item.oc_fecha.Day
                   };

                       listadedatos.Add(itemInfo);

                   }
               }
               return listadedatos;
           }
           catch (Exception ex)
           {
               string MensajeError = "";
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
               MensajeError = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt004_Data) };
           }
           
       
       }

    }
}
