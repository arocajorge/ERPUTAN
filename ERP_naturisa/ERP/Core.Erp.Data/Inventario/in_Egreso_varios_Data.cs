using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Core.Erp.Data.Inventario
{
   public  class in_Egreso_varios_Data
    {

       string mensaje = "";

       //public List<in_Egreso_varios_Info> Consultar(int IdEmpresa, int IdSucursal, DateTime fechaIni, DateTime fechaFin)
       // {
       //     try
       //     {
       //         List<in_Egreso_varios_Info> lista = new List<in_Egreso_varios_Info>();
       //         in_Egreso_varios_Info oItem = new in_Egreso_varios_Info();

       //         EntitiesInventario oEnti = new EntitiesInventario();

       //         var Query = from q in oEnti.vwin_Egreso_varios
       //                     where q.IdEmpresa == IdEmpresa
       //                     && q.IdSucursal == IdSucursal
       //                     && q.cm_fecha >= fechaIni && q.cm_fecha  <= fechaFin
       //                     select q;

       //         foreach (var item in Query)
       //         {
       //             oItem = new in_Egreso_varios_Info();

       //             oItem.IdEmpresa=item.IdEmpresa;
       //             oItem.IdSucursal=item.IdSucursal;
       //             oItem.IdBodega=item.IdBodega;
       //             oItem.IdMovi_inven_tipo=item.IdMovi_inven_tipo;
       //             oItem.IdNumMovi=item.IdNumMovi;
       //             oItem.CodMoviInven=item.CodMoviInven;
       //             oItem.cm_observacion=item.cm_observacion;
       //             oItem.cm_fecha = item.cm_fecha;
       //             oItem.Estado = item.Estado;

       //             oItem.nom_bodega = item.nom_bodega;
       //             oItem.nom_sucursal = item.nom_sucursal;
       //             oItem.cod_tipo_inv = item.cod_tipo_inv;
       //             oItem.nom_tipo_inv = item.nom_tipo_inv;
       //             oItem.IdEmpresa_inv = item.IdEmpresa_inv;
       //             oItem.IdSucursal_inv = item.IdSucursal_inv;
       //             oItem.IdBodega_inv = item.IdBodega_inv;
       //             oItem.IdMovi_inven_tipo_inv = item.IdMovi_inven_tipo_inv;
       //             oItem.IdNumMovi_inv = item.IdNumMovi_inv;
                   
       //             lista.Add(oItem);
       //         }

       //         return lista;

       //     }
       //     catch (Exception ex)
       //     {
       //         string arreglo = ToString();
       //         tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       //         tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
       //                             "", "", "", "", DateTime.Now);
       //         oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
       //         mensaje = ex.InnerException + " " + ex.Message;
       //         return new List<in_Egreso_varios_Info>();
       //     }
       // }

       //public in_Egreso_varios_Info ConsultarInfo(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi)
       //{
       //    try
       //    {              
       //        in_Egreso_varios_Info oItem = new in_Egreso_varios_Info();
       //        EntitiesInventario oEnti = new EntitiesInventario();
       //        var Query = from q in oEnti.vwin_Egreso_varios
       //                    where q.IdEmpresa == IdEmpresa
       //                    && q.IdSucursal == IdSucursal
       //                    && q.IdBodega == IdBodega
       //                    && q.IdMovi_inven_tipo == IdMovi_inven_tipo
       //                    && q.IdNumMovi == IdNumMovi
       //                    select q;
       //        foreach (var item in Query)
       //        {

       //            oItem = new in_Egreso_varios_Info();

       //            oItem.IdEmpresa = item.IdEmpresa;
       //            oItem.IdSucursal = item.IdSucursal;
       //            oItem.IdBodega = item.IdBodega;
       //            oItem.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
       //            oItem.IdNumMovi = item.IdNumMovi;
       //            oItem.CodMoviInven = item.CodMoviInven;
       //            oItem.cm_observacion = item.cm_observacion;
       //            oItem.cm_fecha = item.cm_fecha;
       //            oItem.Estado = item.Estado;
       //            oItem.nom_bodega = item.nom_bodega;
       //            oItem.nom_sucursal = item.nom_sucursal;
       //            oItem.cod_tipo_inv = item.cod_tipo_inv;
       //            oItem.nom_tipo_inv = item.nom_tipo_inv;
       //            oItem.IdEmpresa_inv = item.IdEmpresa_inv;
       //            oItem.IdSucursal_inv = item.IdSucursal_inv;
       //            oItem.IdBodega_inv = item.IdBodega_inv;
       //            oItem.IdMovi_inven_tipo_inv = item.IdMovi_inven_tipo_inv;
       //            oItem.IdNumMovi_inv = item.IdNumMovi_inv;
                  
       //        }

       //        return oItem;
       //    }
       //    catch (Exception ex)
       //    {
       //        string arreglo = ToString();
       //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
       //                            "", "", "", "", DateTime.Now);
       //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
       //        mensaje = ex.InnerException + " " + ex.Message;
       //        return new in_Egreso_varios_Info();
       //    }
       //}

       //public Boolean GuardarDB(in_Egreso_varios_Info Info, ref decimal id, ref string mensaje1)
       //{
       //    try
       //    {

       //        decimal idoc = 0;

       //        using (EntitiesInventario Context = new EntitiesInventario())
       //        {

       //            var Address = new in_Egreso_varios();
       //            idoc = getId(Info.IdEmpresa, Info.IdSucursal,Info.IdBodega,Info.IdMovi_inven_tipo);
       //            id = idoc;
       //            Info.IdNumMovi = idoc;

                   


       //             Address.IdEmpresa= Info.IdEmpresa;
       //             Address.IdSucursal= Info.IdSucursal;
       //             Address.IdBodega= Info.IdBodega;
       //             Address.IdMovi_inven_tipo= Info.IdMovi_inven_tipo;
       //             Address.IdNumMovi= Info.IdNumMovi;
       //             Address.CodMoviInven= Info.CodMoviInven;

       //             Address.cm_observacion = Info.cm_observacion;
       //             Address.cm_fecha = Info.cm_fecha;
       //             Address.IdUsuario = Info.IdUsuario;

       //             Address.Fecha_Transac = Info.Fecha_Transac;
                    
       //             Address.nom_pc= Info.nom_pc;
       //             Address.ip= Info.ip;

       //             Address.IdCentroCosto= Info.IdCentroCosto;
       //             Address.IdCentroCosto_sub_centro_costo= Info.IdCentroCosto_sub_centro_costo;
       //             Address.IdEstadoAproba = Info.IdEstadoAproba ;

       //            Address.Estado = (Info.Estado == null) ? "A" : Info.Estado;
                   
       //            Context.in_Egreso_varios.Add(Address);
       //            Context.SaveChanges();



       //        }


       //        foreach (var item in Info.lista_detalle)
       //        {
                   
       //            item.IdEmpresa = Info.IdEmpresa;
       //            item.IdSucursal = Info.IdSucursal;
       //            item.IdBodega = Info.IdBodega;
       //            item.IdMovi_inven_tipo = Info.IdMovi_inven_tipo;
       //            item.IdNumMovi=Info.IdNumMovi;

       //        }

       //        in_Egreso_varios_det_Data ODataEgre = new in_Egreso_varios_det_Data();

       //        ODataEgre.GuardarDB(Info.lista_detalle,ref id, ref mensaje1);


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

       //public Boolean ModificarDB(in_Egreso_varios_Info Info, ref  string msg)
       //{
       //    try
       //    {
       //        using (EntitiesInventario context = new EntitiesInventario())
       //        {
       //            var contact = context.in_Egreso_varios.First
       //                (obj => obj.IdEmpresa == Info.IdEmpresa  
       //                 && obj.IdSucursal == Info.IdSucursal 
       //                 && obj.IdNumMovi == Info.IdNumMovi 
       //                 && obj.IdMovi_inven_tipo==Info.IdMovi_inven_tipo);



       //            contact.CodMoviInven = Info.CodMoviInven;
       //            contact.cm_fecha = Info.cm_fecha;
       //            contact.cm_observacion = Info.cm_observacion;
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

       //public Boolean AnularDB(in_Egreso_varios_Info Info, ref  string msg)
       //{
       //    try
       //    {
       //        using (EntitiesInventario context = new EntitiesInventario())
       //        {
                   

       //            var contact = context.in_Egreso_varios.First
       //                (obj => obj.IdEmpresa == Info.IdEmpresa
       //                 && obj.IdSucursal == Info.IdSucursal
       //                 && obj.IdNumMovi == Info.IdNumMovi
       //                 && obj.IdMovi_inven_tipo == Info.IdMovi_inven_tipo);


       //            contact.Estado = "I";
       //            contact.Fecha_UltAnu = Info.Fecha_UltAnu;
       //            contact.IdusuarioUltAnu = Info.IdusuarioUltAnu;
       //            contact.MotivoAnulacion = Info.MotivoAnulacion;
       //            contact.cm_observacion = "**Anulado**" + Info.cm_observacion;
       //            context.SaveChanges();

       //            msg = "Se ha procedido a anular el registro Egreso varios  #: " + Info.IdNumMovi.ToString() + " exitosamente";
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

       //public decimal getId(int idempresa, int idsucursal, int IdBodega, int IdMovi_inven_tipo)
       //{
       //    try
       //    {
       //        decimal Id;
       //        EntitiesInventario OECompras = new EntitiesInventario();
       //        var select = from q in OECompras.in_Egreso_varios
       //                     where q.IdEmpresa == idempresa &&
       //                             q.IdSucursal == idsucursal
       //                             && q.IdBodega == IdBodega
       //                             && q.IdMovi_inven_tipo == IdMovi_inven_tipo
       //                     select q;

       //        if (select.ToList().Count < 1)
       //        {
       //            Id = 1;
       //        }
       //        else
       //        {
       //            var select_pv = (from q in OECompras.in_Egreso_varios
       //                             where q.IdEmpresa == idempresa 
       //                                 && q.IdSucursal == idsucursal
       //                                 && q.IdBodega == IdBodega
       //                                 && q.IdMovi_inven_tipo == IdMovi_inven_tipo
       //                             select q.IdNumMovi).Max();
       //            Id = Convert.ToDecimal(select_pv.ToString()) + 1;
       //            Id = (Id == 0) ? 1 : Id;
       //        }
       //        return Id;
       //    }
       //    catch (Exception ex)
       //    {
       //        string arreglo = ToString();
       //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
       //                            "", "", "", "", DateTime.Now);
       //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
       //        mensaje = ex.InnerException + " " + ex.Message;

       //        return 1;
       //    }

       //}

       //public Boolean ModificarCabecera_IdMovi_Inven_x_EgreVarios(in_Egreso_varios_Info info, ref string msgs)
       //{
       //    try
       //    {
       //        using (EntitiesInventario context = new EntitiesInventario())
       //        {
       //            var contact = context.in_Egreso_varios.First(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdBodega == info.IdBodega 
       //                && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi);



       //            contact.IdEmpresa_inv = info.IdEmpresa_inv;
       //            contact.IdSucursal_inv = info.IdSucursal_inv;
       //            contact.IdBodega_inv = info.IdBodega_inv;
       //            contact.IdMovi_inven_tipo_inv = info.IdMovi_inven_tipo_inv;
       //            contact.IdNumMovi_inv = info.IdNumMovi_inv;

       //            context.SaveChanges();
       //        }
       //        return true;
       //    }
       //    catch (Exception ex)
       //    {
       //        string arreglo = ToString();
       //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
       //        msgs = ex.InnerException + " " + ex.Message;
       //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
       //        return false;
       //    }
       //}


    }
}
