using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;



namespace Core.Erp.Data.Inventario
{
   public  class in_Egreso_varios_det_Data
    {


        string mensaje = "";



        //public List<in_Egreso_varios_det_Info> Consultar_info(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi)
        //{
        //    try
        //    {

        //        List<in_Egreso_varios_det_Info> lista = new List<in_Egreso_varios_det_Info>();
        //        in_Egreso_varios_det_Info oItem = new in_Egreso_varios_det_Info();


        //        EntitiesInventario oEnti = new EntitiesInventario();


        //        var Query = from q in oEnti.in_Egreso_varios_det
        //                    join p in oEnti.in_Producto
        //                    on new { q.IdEmpresa, q.IdProducto } equals new { p.IdEmpresa, p.IdProducto }
        //                    where q.IdEmpresa == IdEmpresa
        //                    && q.IdSucursal == IdSucursal
        //                    && q.IdBodega == IdBodega
        //                    && q.IdMovi_inven_tipo == IdMovi_inven_tipo
        //                    && q.IdNumMovi == IdNumMovi
        //                    select new
        //                    {
        //                        q.IdEmpresa,
        //                        q.IdSucursal,
        //                        q.IdBodega,
        //                        q.IdMovi_inven_tipo,
        //                        q.IdNumMovi,
        //                        q.Secuencia,
        //                        q.IdProducto,
        //                        q.dm_cantidad,
        //                        q.dm_stock_ante,
        //                        q.dm_stock_actu,
        //                        q.dm_observacion,
        //                        q.dm_precio,
        //                        q.mv_costo,
        //                        q.dm_peso,
        //                        q.IdCentroCosto,
        //                        q.IdCentroCosto_sub_centro_costo,
        //                        q.IdEstadoAproba,
        //                        q.IdPunto_cargo,
        //                        q.IdUnidadMedida,
        //                        p.pr_descripcion,
        //                        p.pr_codigo

                
        //                    };


        //        foreach (var item in Query)
        //        {

        //            oItem = new in_Egreso_varios_det_Info();

        //            oItem.IdEmpresa = item.IdEmpresa;
        //            oItem.IdSucursal = item.IdSucursal;
        //            oItem.IdBodega = item.IdBodega;
        //            oItem.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
        //            oItem.IdNumMovi = item.IdNumMovi;

        //            oItem.Secuencia = item.Secuencia;
        //            oItem.IdProducto = item.IdProducto;
        //            oItem.dm_cantidad = item.dm_cantidad;
        //            oItem.dm_stock_ante = item.dm_stock_ante;
        //            oItem.dm_stock_actu = item.dm_stock_actu;
        //            oItem.dm_observacion = item.dm_observacion;
        //            oItem.dm_precio = item.dm_precio;
        //            oItem.mv_costo = item.mv_costo;
        //            oItem.dm_peso = item.dm_peso;
        //            oItem.IdCentroCosto = item.IdCentroCosto;
        //            oItem.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
        //            oItem.cod_producto = item.pr_codigo;
        //            oItem.nom_producto = item.pr_descripcion;
                

        //            lista.Add(oItem);

        //        }

        //        return lista;


        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return new List<in_Egreso_varios_det_Info>();

        //    }



        //}

        //public Boolean GuardarDB(List<in_Egreso_varios_det_Info> ListInfo, ref decimal id, ref string mensaje1)
        //{
        //    try
        //    {
        //        foreach (var item in ListInfo)
        //        {
                    

        //            GuardarDB(item, ref id, ref mensaje1);

        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {

        //        return false;
        //    }
        
        //}

       // public Boolean GuardarDB(in_Egreso_varios_det_Info Info, ref decimal id, ref string mensaje1)
       //{
       //    try
       //    {
       //        using (EntitiesInventario Context = new EntitiesInventario())
       //        {

       //            var Address = new in_Egreso_varios_det();
                   
       //             Address.IdEmpresa= Info.IdEmpresa;
       //             Address.IdSucursal= Info.IdSucursal;
       //             Address.IdBodega= Info.IdBodega;
       //             Address.IdMovi_inven_tipo= Info.IdMovi_inven_tipo;
       //             Address.IdNumMovi= Info.IdNumMovi;
       //             Address.Secuencia = Info.Secuencia;
       //             Address.IdProducto = Info.IdProducto;
       //             Address.dm_cantidad = Info.dm_cantidad;
       //             Address.dm_stock_ante = Info.dm_stock_ante;
       //             Address.dm_stock_actu = Info.dm_stock_actu;
       //             Address.dm_observacion = Info.dm_observacion;
       //             Address.dm_precio = Info.dm_precio;
       //             Address.mv_costo = Info.mv_costo;
       //             Address.dm_peso = Info.dm_peso;
       //             Address.IdCentroCosto = Info.IdCentroCosto;
       //             Address.IdCentroCosto_sub_centro_costo = Info.IdCentroCosto_sub_centro_costo;
       //             Address.IdEstadoAproba = Info.IdEstadoAproba;
       //             Address.IdPunto_cargo = Info.IdPunto_cargo;
       //             Address.IdUnidadMedida = Info.IdUnidadMedida;

       //            Context.in_Egreso_varios_det.Add(Address);
       //            Context.SaveChanges();

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

        //public Boolean ModificarDB(in_Egreso_varios_det_Info Info, ref  string msg)
        //{
        //    try
        //    {
        //        using (EntitiesInventario context = new EntitiesInventario())
        //        {
        //            var contact = context.in_Egreso_varios_det.First
        //                (obj => obj.IdEmpresa == Info.IdEmpresa
        //                 && obj.IdSucursal == Info.IdSucursal
        //                 && obj.IdNumMovi == Info.IdNumMovi
        //                 && obj.IdMovi_inven_tipo == Info.IdMovi_inven_tipo);



        //            contact.dm_observacion = Info.dm_observacion;
        //            contact.dm_precio = Info.dm_precio;
        //            contact.IdCentroCosto = Info.IdCentroCosto;
        //            contact.IdCentroCosto_sub_centro_costo = Info.IdCentroCosto_sub_centro_costo;

        //            context.SaveChanges();

        //            msg = "Se ha procedido a modificar el registro de Egreso Varios  #: " + Info.IdNumMovi.ToString() + " exitosamente";

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

        //        msg = "Se ha producido el siguiente error: " + ex.Message;
        //        return false;
        //    }
        //}

        

        

    }
}

