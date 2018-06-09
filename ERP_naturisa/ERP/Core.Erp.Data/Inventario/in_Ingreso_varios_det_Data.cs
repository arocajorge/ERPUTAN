using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
  public  class in_Ingreso_varios_det_Data
    {

        string mensaje = "";

        //public Boolean GuardarDB(List<in_Ingreso_varios_det_Info> LstInfo)
        //{
        //    try
        //    {
        //        int sec = 0;

        //        foreach (var item in LstInfo)
        //        {
        //            using (EntitiesInventario Context = new EntitiesInventario())
        //            {
        //                sec = sec + 1;

        //                var Address = new in_Ingreso_varios_det();

        //                Address.IdEmpresa = item.IdEmpresa;
        //                Address.IdSucursal = item.IdSucursal;
        //                Address.IdBodega = item.IdBodega;
        //                Address.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
        //                Address.IdNumMovi = item.IdNumMovi;
        //                Address.Secuencia = sec;
        //                Address.IdProducto = item.IdProducto;
        //                Address.dm_cantidad = item.dm_cantidad;
        //                Address.dm_stock_ante = item.dm_stock_ante;
        //                Address.dm_stock_actu = item.dm_stock_actu;
        //                Address.dm_observacion = item.dm_observacion;
        //                Address.dm_precio = item.dm_precio;
        //                Address.mv_costo = item.mv_costo;
        //                Address.dm_peso = item.dm_peso;
        //                Address.IdCentroCosto = item.IdCentroCosto;
        //                Address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

        //                Address.IdUnidadMedida = item.IdUnidadMedida;


                                    
        //                Context.in_Ingreso_varios_det.Add(Address);
        //                Context.SaveChanges();
        //            }
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;


        //        return false;
        //    }
        //}


        //public List<in_Ingreso_varios_det_Info> Consulta_IngreVariosDet(int Idempresa,int IdSucursal,int IdBodega,int IdMovi_inven_tipo, decimal IdNumMovi)
        //{
        //    try
        //    {
        //        EntitiesInventario OEInventario = new EntitiesInventario();

        //        List<in_Ingreso_varios_det_Info> lM = new List<in_Ingreso_varios_det_Info>();

        //        var select = from C in OEInventario.in_Ingreso_varios_det
        //                     where C.IdEmpresa == Idempresa && C.IdNumMovi == IdNumMovi
        //                     && C.IdSucursal == IdSucursal && C.IdBodega == IdBodega && C.IdMovi_inven_tipo == IdMovi_inven_tipo
        //                     orderby C.Secuencia ascending
        //                     select C;

        //        foreach (var item in select)
        //        {
        //            in_Ingreso_varios_det_Info info = new in_Ingreso_varios_det_Info();

        //            info.IdEmpresa = item.IdEmpresa;
        //            info.IdSucursal = item.IdSucursal;
        //            info.IdBodega = item.IdBodega;
        //            info.IdNumMovi = item.IdNumMovi;
        //            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
        //            info.Secuencia = item.Secuencia;
        //            info.IdProducto = item.IdProducto;
        //            info.dm_cantidad = item.dm_cantidad;
        //            info.dm_stock_ante = item.dm_stock_ante;
        //            info.dm_stock_actu = item.dm_stock_actu;
        //            info.dm_observacion = item.dm_observacion;
        //            info.dm_precio = item.dm_precio;
        //            info.mv_costo = item.mv_costo;
        //            info.dm_peso = Convert.ToDouble(item.dm_peso);
        //            info.IdCentroCosto = item.IdCentroCosto;
        //            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

        //            info.IdEstadoAproba = item.IdEstadoAproba;
        //            info.IdUnidadMedida = item.IdUnidadMedida;
                               
        //            lM.Add(info);
        //        }
        //        return lM;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return new List<in_Ingreso_varios_det_Info>();
        //    }
        //}

    }
}
