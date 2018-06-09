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


                   var select = from h in ListadoOrdenCompra.vwCOMP_Rpt004
                                where h.IdEmpresa == idempresa
                                && h.oc_fecha >= FechaIni && h.oc_fecha <= FechaFin
                                select h;

                   foreach (var item in select)
                   {

                       XCOMP_Rpt004_Info itemInfo = new XCOMP_Rpt004_Info();


                        itemInfo.IdEmpresa= item.IdEmpresa;
                        itemInfo.IdSucursal= item.IdSucursal;
                        itemInfo.IdOrdenCompra= item.IdOrdenCompra;
                        itemInfo.documento= item.documento;
                        itemInfo.oc_fecha= item.oc_fecha;
                        itemInfo.oc_observacion= item.oc_observacion;
                        itemInfo.IdComprador= item.IdComprador;
                        itemInfo.nom_comprador= item.nom_comprador;
                        itemInfo.IdProveedor= item.IdProveedor;
                        itemInfo.nom_proveedor= item.nom_proveedor;
                        itemInfo.IdMotivo= item.IdMotivo;
                        itemInfo.Nom_motivo_oc= item.Nom_motivo_oc;
                        itemInfo.IdProducto= item.IdProducto;
                        itemInfo.nom_producto= item.nom_producto;
                        itemInfo.do_Cantidad= item.do_Cantidad;
                        itemInfo.precio= item.precio;
                        itemInfo.do_subtotal= item.do_subtotal;
                        itemInfo.do_iva= item.do_iva;
                        itemInfo.do_total= item.do_total;
                        itemInfo.IdPunto_cargo= item.IdPunto_cargo;
                        itemInfo.nom_punto_cargo= item.nom_punto_cargo;
                        itemInfo.IdCentroCosto= item.IdCentroCosto;
                        itemInfo.Centro_costo= item.Centro_costo;
                        itemInfo.IdCentroCosto_sub_centro_costo= item.IdCentroCosto_sub_centro_costo;
                        itemInfo.sub_centro_costo= item.sub_centro_costo;


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
