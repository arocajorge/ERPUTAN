using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Compras_Edehsa
{
    public class com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstInfo, string IdEstado)
        {
            try
            {
                int sec = 1;
                foreach (var item in LstInfo)
                {

                    using (EntitiesCompras_Edehsa Context = new EntitiesCompras_Edehsa())
                    {
                        var Address = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det();

                        Address.IdEmpresa = item.IdEmpresa;


                        Address.IdSucursal = item.IdSucursal;
                        Address.IdBodega = item.IdBodega;
                        Address.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        Address.IdNumMovi = item.IdNumMovi;
                        Address.CodigoBarra = item.CodigoBarra;
                        Address.CodObra_preasignada = item.CodObra_preasignada;
                        
                        sec++;
                        Address.IdProducto = item.IdProducto;
                        Address.dm_cantidad = item.dm_cantidad;
                        Address.Det_Kg = item.Det_Kg;

                        Address.pr_largo = item.pr_largo;
                        Address.largo_total = item.largo_total;
                        Address.largo_restante = item.largo_restante;

                        Address.largo_pieza_entera = item.largo_pieza_entera;
                        Address.cantidad_pieza_entera = item.cantidad_pieza_entera;
                        Address.largo_pieza_complementaria = item.largo_pieza_complementaria;
                        Address.cantidad_pieza_complementaria = item.cantidad_pieza_complementaria;
                        Address.cantidad_total_pieza_complementaria = item.cantidad_total_pieza_complementaria;
                        Address.largo_despunte1 = item.largo_despunte1;
                        Address.cantidad_despunte1 = item.cantidad_despunte1;
                        Address.es_despunte_usable1 = item.es_despunte_usable1;
                        Address.largo_despunte2 = item.largo_despunte2;
                        Address.cantidad_despunte2 = item.cantidad_despunte2;
                        Address.es_despunte_usable2 = item.es_despunte_usable2;

                        Address.IdEstadoAprob = IdEstado;
                        Context.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.Add(Address);
                        Context.SaveChanges();

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det(int IdEmpresa, string CodObra)
        {
            List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Lst = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Detalle
                            where q.IdEmpresa == IdEmpresa && q.CodObra_preasignada == CodObra
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Obj = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;


                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.CodObra_preasignada = item.CodObra_preasignada;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.dm_cantidad = item.dm_cantidad;
                    Obj.Det_Kg = item.Det_Kg;
                    
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.IdEstadoAprob = item.IdEstadoAprob;

                    Obj.espesor = item.espesor;
                    Obj.longitud = item.longitud;
                    Obj.alto = item.alto;
                    Obj.ancho = item.ancho;


                    Obj.largo_pieza_entera = item.largo_pieza_entera;
                    Obj.cantidad_pieza_entera = item.cantidad_pieza_entera;
                    Obj.largo_pieza_complementaria = item.largo_pieza_complementaria;
                    Obj.cantidad_pieza_complementaria = item.cantidad_pieza_complementaria;
                    Obj.cantidad_total_pieza_complementaria = item.cantidad_total_pieza_complementaria;
                    Obj.largo_despunte1 = item.largo_despunte1;
                    Obj.cantidad_despunte1 = item.cantidad_despunte1;
                    Obj.es_despunte_usable1 = item.es_despunte_usable1;
                    Obj.largo_despunte2 = item.largo_despunte2;
                    Obj.cantidad_despunte2 = item.cantidad_despunte2;
                    Obj.es_despunte_usable2 = item.es_despunte_usable2;


                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Get_List_All_DespuntesMP_Preasignado(int IdEmpresa)
        {
            List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Lst = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Detalle
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Obj = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;


                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.CodObra_preasignada = item.CodObra_preasignada;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.dm_cantidad = item.dm_cantidad;
                    Obj.Det_Kg = item.Det_Kg;

                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.IdEstadoAprob = item.IdEstadoAprob;

                    Obj.espesor = item.espesor;
                    Obj.longitud = item.longitud;
                    Obj.alto = item.alto;
                    Obj.ancho = item.ancho;


                    Obj.largo_pieza_entera = item.largo_pieza_entera;
                    Obj.cantidad_pieza_entera = item.cantidad_pieza_entera;
                    Obj.largo_pieza_complementaria = item.largo_pieza_complementaria;
                    Obj.cantidad_pieza_complementaria = item.cantidad_pieza_complementaria;
                    Obj.cantidad_total_pieza_complementaria = item.cantidad_total_pieza_complementaria;
                    Obj.largo_despunte1 = item.largo_despunte1;
                    Obj.cantidad_despunte1 = item.cantidad_despunte1;
                    Obj.es_despunte_usable1 = item.es_despunte_usable1;
                    Obj.largo_despunte2 = item.largo_despunte2;
                    Obj.cantidad_despunte2 = item.cantidad_despunte2;
                    Obj.es_despunte_usable2 = item.es_despunte_usable2;


                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }



        //public Boolean EliminarDB(List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstInfo, ref string msg)
        //{
        //    try
        //    {

        //        using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
        //        {
        //            foreach (var item in LstInfo)
        //            {
        //                var address = context.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.FirstOrDefault
        //                    (A => A.IdEmpresa == item.IdEmpresa &&
        //                       A.IdListadoMaterialesDisponibles_PreAsignado_a_Obra == item.IdListadoMaterialesDisponibles_PreAsignado_a_Obra);

        //                if (address != null)
        //                {
        //                    context.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.Remove(address);
        //                    context.SaveChanges();
        //                }

        //            }

        //        }
        //        msg = "Guardado con exito";
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

        //        msg = "Error no se guardó " + ex.Message + " ";
        //        throw new Exception(ex.ToString());
        //    }
        //}

        public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> TraerMP_Preasignado_a_Obra(int IdEmpresa)
        {
            List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Lst = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_AllListDetMaterialesDisponibles_PreAsignado_a_Obra
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Obj = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;


                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.CodObra_preasignada = item.CodObra_preasignada;
                    Obj.Obra = item.Obra;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.dm_cantidad = item.dm_cantidad;
                    Obj.Det_Kg = item.Det_Kg;
                    Obj.CodObra_preasignada = item.CodObra_preasignada;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.IdEstadoAprob = item.IdEstadoAprob;

                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                  

                    Obj.largo_pieza_entera = item.largo_pieza_entera;
                    Obj.cantidad_pieza_entera = item.cantidad_pieza_entera;
                    Obj.largo_pieza_complementaria = item.largo_pieza_complementaria;
                    Obj.cantidad_pieza_complementaria = item.cantidad_pieza_complementaria;
                    Obj.cantidad_total_pieza_complementaria = item.cantidad_total_pieza_complementaria;
                    Obj.largo_despunte1 = item.largo_despunte1;
                    Obj.cantidad_despunte1 = item.cantidad_despunte1;
                    Obj.es_despunte_usable1 = item.es_despunte_usable1;
                    Obj.largo_despunte2 = item.largo_despunte2;
                    Obj.cantidad_despunte2 = item.cantidad_despunte2;
                    Obj.es_despunte_usable2 = item.es_despunte_usable2;



                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> TraerTodoMP_Preasignado_a_Obra(int IdEmpresa)
        {
            List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Lst = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_AllListDetMateriales_PreAsignado_a_Obra
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Obj = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;


                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.Secuencia = item.Secuencia;
                    Obj.mv_Secuencia = item.mv_Secuencia;

                    Obj.CodObra_preasignada = item.CodObra_preasignada;
                    Obj.Obra = item.Obra;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.dm_cantidad = Convert.ToDouble(item.dm_cantidad);
                    Obj.Det_Kg = item.pr_peso;
                    Obj.CodObra_preasignada = item.CodObra_preasignada;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    //Obj.IdEstadoAprob = item.IdEstadoAprob;

                  


                    //Obj.largo_pieza_entera = item.largo_pieza_entera;
                    //Obj.cantidad_pieza_entera = item.cantidad_pieza_entera;
                    //Obj.largo_pieza_complementaria = item.largo_pieza_complementaria;
                    //Obj.cantidad_pieza_complementaria = item.cantidad_pieza_complementaria;
                    //Obj.cantidad_total_pieza_complementaria = item.cantidad_total_pieza_complementaria;
                    //Obj.largo_despunte1 = item.largo_despunte1;
                    //Obj.cantidad_despunte1 = item.cantidad_despunte1;
                    //Obj.es_despunte_usable1 = item.es_despunte_usable1;
                    //Obj.largo_despunte2 = item.largo_despunte2;
                    //Obj.cantidad_despunte2 = item.cantidad_despunte2;
                    //Obj.es_despunte_usable2 = item.es_despunte_usable2;



                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Get_List_All_MP_Disponibles(int IdEmpresa)
        {
            List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Lst = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_ListadoMaterialesDisponibles
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Obj = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.mv_Secuencia = item.mv_Secuencia;
                    Obj.Secuencia = item.Secuencia;


                    Obj.IdProducto = item.IdProducto;
                    Obj.dm_cantidad = Convert.ToDouble(item.dm_cantidad);
                    //Obj.Det_Kg = item.Det_Kg;
                    Obj.CodObra_preasignada = item.CodObra_preasignada;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.CodigoBarra = item.CodigoBarra;

                    Obj.longitud = item.longitud;
                    Obj.alto = item.alto;
                    Obj.espesor = item.espesor;
                    //Obj.IdEstadoAprob = item.IdEstadoAprob;
                    
                    //Obj.Motivo = item.Motivo;
                    //Obj.ob_descripcion = item.ob_descripcion;
                    
                    //Obj.obra = item.ob_descripcion;
                    //Obj.producto = item.pr_descripcion + "[" + item.pr_codigo + "/" + item.IdProducto + "] ";
                    //Obj.solicitante = item.Usuario;

                    //Obj.largo_pieza_entera = item.largo_pieza_entera;
                    //Obj.cantidad_pieza_entera = item.cantidad_pieza_entera;
                    //Obj.largo_pieza_complementaria = item.largo_pieza_complementaria;
                    //Obj.cantidad_pieza_complementaria = item.cantidad_pieza_complementaria;
                    //Obj.cantidad_total_pieza_complementaria = item.cantidad_total_pieza_complementaria;
                    //Obj.largo_despunte1 = item.largo_despunte1;
                    //Obj.cantidad_despunte1 = item.cantidad_despunte1;
                    //Obj.es_despunte_usable1 = item.es_despunte_usable1;
                    //Obj.largo_despunte2 = item.largo_despunte2;
                    //Obj.cantidad_despunte2 = item.cantidad_despunte2;
                    //Obj.es_despunte_usable2 = item.es_despunte_usable2;



                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        //public Boolean ActualizarCodObra_preasignada(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Info, ref string msg)
        //{
        //    try
        //    {
        //        using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
        //        {
        //            var contact = context.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa
        //                && obj.IdListadoMaterialesDisponibles_PreAsignado_a_Obra == Info.IdListadoMaterialesDisponibles_PreAsignado_a_Obra && obj.IdDetalle == Info.IdDetalle);

        //            if (contact != null)
        //            {
        //                contact.IdEstadoAprob = Info.lm_IdEstadoAprobado;

        //                context.SaveChanges();
        //                msg = "Se ha procedido actualizar elListado de Materiales #: " + Info.IdListadoMaterialesDisponibles_PreAsignado_a_Obra.ToString() + " exitosamente.";
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
        //        msg = "Se ha producido el siguiente error: " + ex.Message;
        //        throw new Exception(ex.ToString());
        //    }
        //}

        //public com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det(int IdEmpresa, decimal IdListadoMat, int IdDetalle)
        //{
        //    com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Obj = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
        //    EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
        //    try
        //    {
        //        var Query = from q in oEnti.vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Detalle
        //                    where q.IdEmpresa == IdEmpresa
        //                    && q.IdListadoMaterialesDisponibles_PreAsignado_a_Obra == IdListadoMat
        //                    && q.IdDetalle == IdDetalle
        //                    select q;
        //        foreach (var item in Query)
        //        {

        //            Obj.IdEmpresa = item.IdEmpresa;
        //            Obj.IdListadoMaterialesDisponibles_PreAsignado_a_Obra = item.IdListadoMaterialesDisponibles_PreAsignado_a_Obra;
        //            Obj.IdDetalle = item.IdDetalle;
        //            Obj.CodObra = item.CodObra;
                    
        //            Obj.IdProducto = item.IdProducto;
        //            Obj.Unidades = item.Unidades;
        //            Obj.Det_Kg = item.Det_Kg;
        //            Obj.lm_IdEstadoAprobado = item.IdEstadoAprob;
        //            Obj.pr_descripcion = item.pr_descripcion;
        //            Obj.pr_codigo = item.pr_codigo;
        //            Obj.producto = "[" + item.IdProducto + "] [" + item.pr_codigo + "] " + item.pr_descripcion;

        //            Obj.largo_pieza_entera = item.largo_pieza_entera;
        //            Obj.cantidad_pieza_entera = item.cantidad_pieza_entera;
        //            Obj.largo_pieza_complementaria = item.largo_pieza_complementaria;
        //            Obj.cantidad_pieza_complementaria = item.cantidad_pieza_complementaria;
        //            Obj.cantidad_total_pieza_complementaria = item.cantidad_total_pieza_complementaria;
        //            Obj.largo_despunte1 = item.largo_despunte1;
        //            Obj.cantidad_despunte1 = item.cantidad_despunte1;
        //            Obj.es_despunte_usable1 = item.es_despunte_usable1;
        //            Obj.largo_despunte2 = item.largo_despunte2;
        //            Obj.cantidad_despunte2 = item.cantidad_despunte2;
        //            Obj.es_despunte_usable2 = item.es_despunte_usable2;

        //        }
        //        return (Obj);
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        throw new Exception(ex.ToString());
        //    }

        //}

        //public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det(int IdEmpresa, string CodObra)
        //{
        //    List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Lst = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
        //    EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
        //    try
        //    {
        //        var Query = from q in oEnti.vwcom_AllListDetMaterialesDisponibles_PreAsignado_a_Obra
        //                    where q.IdEmpresa == IdEmpresa
        //                    && q.CodObra == CodObra
        //                    select q;
        //        foreach (var item in Query)
        //        {

        //            com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Obj = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
        //            Obj.IdEmpresa = item.IdEmpresa;
                    

        //            Obj.ot_IdSucursal = item.IdSucursal;
        //            Obj.IdListadoMaterialesDisponibles_PreAsignado_a_Obra = item.IdListadoMaterialesDisponibles_PreAsignado_a_Obra;
        //            Obj.IdDetalle = item.IdDetalle;
        //            Obj.IdProducto = item.IdProducto;
        //            Obj.Unidades = item.Unidades;
        //            Obj.Det_Kg = item.Det_Kg;
        //            Obj.CodObra = item.CodObra;
        //            Obj.pr_codigo = item.pr_codigo;
        //            Obj.pr_descripcion = item.pr_descripcion;
        //            Obj.lm_IdEstadoAprobado = item.IdEstadoAprob;
        //            Obj.ea_codigo = item.IdEstadoAprob;
        //            Obj.ea_descripcion = item.ea_descripcion;
        //            Obj.FechaRequer = item.FechaReg;
        //            Obj.mr_descripcion = item.mr_descripcion;
        //            Obj.Motivo = item.Motivo;
        //            Obj.ob_descripcion = item.ob_descripcion;
                    
        //            Obj.obra = item.ob_descripcion;
        //            Obj.largo_restante = item.largo_restante;
        //            Obj.producto = item.pr_descripcion + "[" + item.pr_codigo + "/" + item.IdProducto + "] ";
        //            Obj.solicitante = item.Usuario;

        //            Obj.largo_pieza_entera = item.largo_pieza_entera;
        //            Obj.cantidad_pieza_entera = item.cantidad_pieza_entera;
        //            Obj.largo_pieza_complementaria = item.largo_pieza_complementaria;
        //            Obj.cantidad_pieza_complementaria = item.cantidad_pieza_complementaria;
        //            Obj.cantidad_total_pieza_complementaria = item.cantidad_total_pieza_complementaria;
        //            Obj.largo_despunte1 = item.largo_despunte1;
        //            Obj.cantidad_despunte1 = item.cantidad_despunte1;
        //            Obj.es_despunte_usable1 = item.es_despunte_usable1;
        //            Obj.largo_despunte2 = item.largo_despunte2;
        //            Obj.cantidad_despunte2 = item.cantidad_despunte2;
        //            Obj.es_despunte_usable2 = item.es_despunte_usable2;


        //            Lst.Add(Obj);
        //        }
        //        return Lst;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.ToString();
        //        throw new Exception(ex.ToString());
        //    }
        //}

        //public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Get_List_ListadoDespunteMaterialesDisponibles_PreAsignado_a_Obra_Det(int IdEmpresa, string CodObra)
        //{
        //    List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Lst = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>();
        //    EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
        //    try
        //    {
        //        var Query = from q in oEnti.vwcom_AllListDetMaterialesDisponibles_PreAsignado_a_Obra
        //                    where q.IdEmpresa == IdEmpresa
        //                    && q.CodObra == CodObra
        //                    //&& q.largo_despunte1 != null
        //                    select q;
        //        foreach (var item in Query)
        //        {

        //            com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Obj = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info();
        //            Obj.IdEmpresa = item.IdEmpresa;
                    

        //            Obj.ot_IdSucursal = item.IdSucursal;
        //            Obj.IdListadoMaterialesDisponibles_PreAsignado_a_Obra = item.IdListadoMaterialesDisponibles_PreAsignado_a_Obra;
        //            Obj.IdDetalle = item.IdDetalle;
        //            Obj.IdProducto = item.IdProducto;
        //            Obj.Unidades = item.Unidades;
        //            Obj.Det_Kg = item.Det_Kg;
        //            Obj.CodObra = item.CodObra;
        //            Obj.pr_codigo = item.pr_codigo;
        //            Obj.pr_descripcion = item.pr_descripcion;
        //            Obj.lm_IdEstadoAprobado = item.IdEstadoAprob;
        //            Obj.ea_codigo = item.IdEstadoAprob;
        //            Obj.ea_descripcion = item.ea_descripcion;
        //            Obj.FechaRequer = item.FechaReg;
        //            Obj.mr_descripcion = item.mr_descripcion;
        //            Obj.Motivo = item.Motivo;
        //            Obj.ob_descripcion = item.ob_descripcion;
                    
        //            Obj.obra = item.ob_descripcion;
        //            Obj.largo_restante = item.largo_restante;
        //            Obj.producto = item.pr_descripcion + "[" + item.pr_codigo + "/" + item.IdProducto + "] ";
        //            Obj.solicitante = item.Usuario;

        //            Obj.largo_pieza_entera = item.largo_pieza_entera;
        //            Obj.cantidad_pieza_entera = item.cantidad_pieza_entera;
        //            Obj.largo_pieza_complementaria = item.largo_pieza_complementaria;
        //            Obj.cantidad_pieza_complementaria = item.cantidad_pieza_complementaria;
        //            Obj.cantidad_total_pieza_complementaria = item.cantidad_total_pieza_complementaria;
        //            Obj.largo_despunte1 = item.largo_despunte1;
        //            Obj.cantidad_despunte1 = item.cantidad_despunte1;
        //            Obj.es_despunte_usable1 = item.es_despunte_usable1;
        //            Obj.largo_despunte2 = item.largo_despunte2;
        //            Obj.cantidad_despunte2 = item.cantidad_despunte2;
        //            Obj.es_despunte_usable2 = item.es_despunte_usable2;

        //            Obj.largo_total = item.largo_total;
        //            Lst.Add(Obj);
        //        }
        //        return Lst;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.ToString();
        //        throw new Exception(ex.ToString());
        //    }
        //}
    }
}
