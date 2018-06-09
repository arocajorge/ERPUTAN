using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Compras_Edehsa
{
    public class com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Data
    {
        string mensaje = "";

        public decimal GetIdMovi_Inven(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo)
        {
            try
            {
                decimal IdMovi_inven_tipo1;

                EntitiesCompras_Edehsa OECbtecble = new EntitiesCompras_Edehsa();
                var q = from A in OECbtecble.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra
                        where A.IdEmpresa == IdEmpresa
                        && A.IdBodega==IdBodega 
                        && A.IdMovi_inven_tipo==IdMovi_inven_tipo
                        && A.IdSucursal == IdSucursal
                        select A;

                if (q.ToList().Count < 1)
                {
                    IdMovi_inven_tipo1 = 1;
                }
                else
                {
                    OECbtecble = new EntitiesCompras_Edehsa();
                    var selectCbtecble = (from CbtCble in OECbtecble.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra
                                          where CbtCble.IdEmpresa == IdEmpresa
                                            && CbtCble.IdBodega == IdBodega
                                            && CbtCble.IdMovi_inven_tipo == IdMovi_inven_tipo
                                            && CbtCble.IdSucursal == IdSucursal
                                          select CbtCble.IdNumMovi).Max();
                    IdMovi_inven_tipo1 = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return IdMovi_inven_tipo1;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        //public Boolean AnularDB(in_movi_inve_Info MoviInfo, ref  string mensaje)
        //{
        //    try
        //    {
        //        using (EntitiesInventario context = new EntitiesInventario())
        //        {
        //            var contact = context.in_movi_inve.FirstOrDefault(prod1 => prod1.IdEmpresa == MoviInfo.IdEmpresa && prod1.IdSucursal == MoviInfo.IdSucursal && prod1.IdBodega == MoviInfo.IdBodega && prod1.IdMovi_inven_tipo == MoviInfo.IdMovi_inven_tipo && prod1.IdNumMovi == MoviInfo.IdNumMovi);
        //            //no elimino el registro solo cambia el estado de activo a inactivo
        //            if (contact != null)
        //            {
        //                contact.Estado = "I"; //cambio el estado de activo por inactivo
        //                contact.cm_observacion = " ***ANULADO***" + contact.cm_observacion;
        //                contact.IdusuarioUltAnu = MoviInfo.IdusuarioUltAnu;
        //                contact.Fecha_UltAnu = DateTime.Now;
        //                contact.Fecha_UltMod = DateTime.Now;
        //                contact.IdUsuarioUltModi = MoviInfo.IdUsuarioUltModi;
        //                contact.MotivoAnulacion = MoviInfo.MotivoAnulacion;
        //                contact.IdEmpresa_x_Anu = MoviInfo.IdEmpresa_x_Anu;
        //                contact.IdSucursal_x_Anu = MoviInfo.IdSucursal_x_Anu;
        //                contact.IdBodega_x_Anu = MoviInfo.IdBodega_x_Anu;
        //                contact.IdMovi_inven_tipo_x_Anu = MoviInfo.IdMovi_inven_tipo_x_Anu;
        //                contact.IdNumMovi_x_Anu = MoviInfo.IdNumMovi_x_Anu;
        //                contact.MotivoAnulacion = MoviInfo.MotivoAnulacion;
        //                context.SaveChanges();
        //                mensaje = "Anulacion Exitosa..";
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.ToString() + " " + ex.Message;
        //        mensaje = "Error al Anular:  " + ex.Message;
        //        throw new Exception(ex.ToString());
        //    }
        //}

        public Boolean GrabarDB(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info info, ref decimal id, ref string msg)
        {
            try
            {
                using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                {
                    var address = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra();
                    decimal idEmp = GetIdMovi_Inven(info.IdEmpresa,info.IdSucursal,info.IdBodega,info.IdMovi_inven_tipo);
                    id = idEmp;

                    address.IdNumMovi = id;
                    address.IdEmpresa = info.IdEmpresa;
                    
                    address.CodObra_preasignada = info.CodObra_preasignada;
                  
                    address.FechaReg = info.FechaReg;
                    address.Estado = info.Estado;
                    address.Usuario = info.Usuario;
                    address.Motivo = info.Motivo.Trim();
                    address.lm_Observacion = info.lm_Observacion;

                    context.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el Listado de Materiales #: " + id.ToString() + " exitosamente.";
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
                mensaje = ex.InnerException + " " + ex.Message;

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info info, ref string msg)
        {
            try
            {
                using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                {
                    var contact = context.com_ListadoMaterialesDisponibles_PreAsignado_a_Obra.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa
                        && obj.IdSucursal == info.IdSucursal && obj.IdBodega == info.IdBodega && obj.IdMovi_inven_tipo == info.IdMovi_inven_tipo
                        && obj.IdNumMovi == info.IdNumMovi);


                    if (contact != null)
                    {
                        contact.FechaReg = info.FechaReg;
                        contact.Motivo = info.Motivo;
                        contact.Usuario = info.Usuario;
                        contact.lm_Observacion = info.lm_Observacion;
                        contact.Estado = info.Estado;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el Listado de Materiales #: " + info.IdNumMovi.ToString() + " exitosamente.";
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
                mensaje = ex.InnerException + " " + ex.Message;

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info> Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra(int idempresa)
        {

            List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info> Lst = new List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra
                            where q.IdEmpresa == idempresa
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info Obj = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;

                    Obj.FechaReg = item.FechaReg;
                    Obj.Estado = item.Estado;
                    Obj.ob_descripcion = "[" + item.CodObra_preasignada + "] " + item.ob_descripcion;

                    Obj.lm_Observacion = item.lm_Observacion;
                    Obj.CodObra_preasignada = item.CodObra_preasignada;
                    Obj.Usuario = item.Usuario;
                    Obj.Motivo = item.Motivo;
                    Obj.su_descripcion = item.Su_Descripcion;

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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        //public com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra(int idempresa, decimal idLstMater)
        //{
        //    com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info info = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info();
        //    EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
        //    try
        //    {
        //        var select = from A in oEnti.vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra
        //                     where A.IdEmpresa == idempresa
        //                     && A.IdListadoMaterialesDisponibles_PreAsignado_a_Obra == idLstMater

        //                     select A;

        //        foreach (var item in select)
        //        {
        //            info.IdEmpresa = item.IdEmpresa;
        //            info.IdSucursal = item.IdSucursal;
                    
        //            info.IdListadoMaterialesDisponibles_PreAsignado_a_Obra = item.IdListadoMaterialesDisponibles_PreAsignado_a_Obra;
        //            info.FechaReg = item.FechaReg;
        //            info.Estado = item.Estado;
        //            info.ob_descripcion = item.ob_descripcion;
                    
        //            info.lm_Observacion = item.lm_Observacion;
        //            info.su_descripcion = item.Su_Descripcion;
        //            info.CodObra = item.CodObra;
        //            info.Motivo = item.Motivo;
        //            info.Usuario = item.Usuario;
        //        }
        //        return (info);
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

        //public com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info Get_Info_ListadoMaterialesDisponibles_PreAsignado_a_Obra(int idempresa, decimal idLstMater)
        //{
        //    com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info info = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Info();
        //    EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
        //    try
        //    {
        //        var select = from A in oEnti.vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra
        //                     where A.IdEmpresa == idempresa
        //                     && A.IdListadoMaterialesDisponibles_PreAsignado_a_Obra == idLstMater

        //                     select A;

        //        foreach (var item in select)
        //        {
        //            info.IdEmpresa = item.IdEmpresa;
        //            info.IdSucursal = item.IdSucursal;
                    
        //            info.IdListadoMaterialesDisponibles_PreAsignado_a_Obra = item.IdListadoMaterialesDisponibles_PreAsignado_a_Obra;
        //            info.FechaReg = item.FechaReg;
        //            info.Estado = item.Estado;
        //            info.ob_descripcion = item.ob_descripcion;
                    
        //            info.lm_Observacion = item.lm_Observacion;
        //            info.su_descripcion = item.Su_Descripcion;
        //            info.CodObra = item.CodObra;
        //            info.Motivo = item.Motivo;
        //            info.Usuario = item.Usuario;
        //        }
        //        return (info);
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

    }
}
