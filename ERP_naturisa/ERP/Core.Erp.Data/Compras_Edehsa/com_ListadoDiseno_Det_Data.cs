using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Compras_Edehsa
{
    public class com_ListadoDiseno_Det_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(List<com_ListadoDiseno_Det_Info> LstInfo, string IdEstado)
        {
            try
            {
                int sec = 1;
                foreach (var item in LstInfo)
                {

                    using (EntitiesCompras_Edehsa Context = new EntitiesCompras_Edehsa())
                    {
                        var Address = new com_ListadoDiseno_Det();

                        Address.IdEmpresa = item.IdEmpresa;

                        Address.IdOrdenTaller = item.IdOrdenTaller;
                        Address.IdListadoDiseno = item.IdListadoDiseno;
                        Address.CodObra = item.CodObra;
                        Address.IdDetalle = sec;
                        sec++;
                        Address.IdProducto = item.IdProducto;
                        Address.Unidades = item.Unidades;
                        Address.Det_Kg = item.Det_Kg;
                        Address.IdEstadoAprob = IdEstado;
                        Context.com_ListadoDiseno_Det.Add(Address);
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

        public List<com_ListadoDiseno_Det_Info> Get_List_ListadoDiseno_Det(int IdEmpresa, decimal idLstMater)
        {
            List<com_ListadoDiseno_Det_Info> Lst = new List<com_ListadoDiseno_Det_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_ListadoDiseno_Detalle
                            where q.IdEmpresa == IdEmpresa && q.IdListadoDiseno == idLstMater
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoDiseno_Det_Info Obj = new com_ListadoDiseno_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;

                   
                    Obj.IdListadoDiseno = item.IdListadoDiseno;
                    Obj.IdDetalle = item.IdDetalle;
                    Obj.IdProducto = item.IdProducto;
                    Obj.Unidades = item.Unidades;
                    Obj.Det_Kg = item.Det_Kg;
                    Obj.CodObra = item.CodObra;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.lm_IdEstadoAprobado = item.IdEstadoAprob;


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

        public Boolean EliminarDB(List<com_ListadoDiseno_Det_Info> LstInfo, ref string msg)
        {
            try
            {

                using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                {
                    foreach (var item in LstInfo)
                    {
                        var address = context.com_ListadoDiseno_Det.FirstOrDefault
                            (A => A.IdEmpresa == item.IdEmpresa &&
                                A.IdOrdenTaller == item.IdOrdenTaller && A.IdListadoDiseno == item.IdListadoDiseno);

                        if (address != null)
                        {
                            context.com_ListadoDiseno_Det.Remove(address);
                            context.SaveChanges();
                        }

                    }

                }
                msg = "Guardado con exito";
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

                msg = "Error no se guardó " + ex.Message + " ";
                throw new Exception(ex.ToString());
            }
        }

        //public List<com_ListadoDiseno_Det_Info> Get_List_ListadoDiseno_Det(int IdEmpresa)
        //{
        //    List<com_ListadoDiseno_Det_Info> Lst = new List<com_ListadoDiseno_Det_Info>();
        //    EntitiesCompras oEnti = new EntitiesCompras();
        //    try
        //    {
        //        var Query = from q in oEnti.vwcom_AllListDetMateriales
        //                    where q.IdEmpresa == IdEmpresa
        //                    select q;
        //        foreach (var item in Query)
        //        {

        //            com_ListadoDiseno_Det_Info Obj = new com_ListadoDiseno_Det_Info();
        //            Obj.IdEmpresa = item.IdEmpresa;
        //            Obj.IdOrdenTaller = item.IdOrdenTaller;
        //            Obj.ot_IdSucursal = item.IdSucursal;
        //            Obj.IdListadoDiseno = item.IdListadoDiseno;
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
        //            Obj.ot_codigo = item.ot_descripcion;
        //            Obj.obra = item.ob_descripcion;
        //            Obj.producto = item.pr_descripcion + "[" + item.pr_codigo + "/" + item.IdProducto + "] ";
        //            Obj.solicitante = item.Usuario;

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

        //public Boolean ActualizarEstadoAprob(com_ListadoDiseno_Det_Info Info, ref string msg)
        //{
        //    try
        //    {
        //        using (EntitiesCompras context = new EntitiesCompras())
        //        {
        //            var contact = context.com_ListadoDiseno_Det.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa
        //                && obj.IdListadoDiseno == Info.IdListadoDiseno && obj.IdDetalle == Info.IdDetalle);

        //            if (contact != null)
        //            {
        //                contact.IdEstadoAprob = Info.lm_IdEstadoAprobado;

        //                context.SaveChanges();
        //                msg = "Se ha procedido actualizar elListado de Materiales #: " + Info.IdListadoDiseno.ToString() + " exitosamente.";
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

        public com_ListadoDiseno_Det_Info Get_List_ListadoDiseno_Det(int IdEmpresa, decimal IdListadoMat, int IdDetalle)
        {
            com_ListadoDiseno_Det_Info Obj = new com_ListadoDiseno_Det_Info();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_ListadoDiseno_Detalle
                            where q.IdEmpresa == IdEmpresa
                            && q.IdListadoDiseno == IdListadoMat
                            && q.IdDetalle == IdDetalle
                            select q;
                foreach (var item in Query)
                {

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdListadoDiseno = item.IdListadoDiseno;
                    Obj.IdDetalle = item.IdDetalle;
                    Obj.CodObra = item.CodObra;
                    
                    Obj.IdProducto = item.IdProducto;
                    Obj.Unidades = item.Unidades;
                    Obj.Det_Kg = item.Det_Kg;
                    Obj.lm_IdEstadoAprobado = item.IdEstadoAprob;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.producto = "[" + item.IdProducto + "] [" + item.pr_codigo + "] " + item.pr_descripcion;
                }
                return (Obj);
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
    }
}
