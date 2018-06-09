using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Compras_Edehsa
{
    public class com_ListadoElementos_x_OT_Det_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(List<com_ListadoElementos_x_OT_Det_Info> LstInfo, string IdEstado)
        {
            try
            {
                int sec = 1;
                foreach (var item in LstInfo)
                {

                    using (EntitiesCompras_Edehsa Context = new EntitiesCompras_Edehsa())
                    {
                        var Address = new com_ListadoElementos_x_OT_Det();

                        Address.IdEmpresa = item.IdEmpresa;

                        Address.IdOrdenTaller = item.IdOrdenTaller;
                        Address.IdListadoElementos_x_OT = item.IdListadoElementos_x_OT;
                        Address.CodObra = item.CodObra;
                        Address.IdDetalle = sec;
                        sec++;
                        Address.IdProducto = item.IdProducto;
                        Address.Unidades = item.Unidades;
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
                        Context.com_ListadoElementos_x_OT_Det.Add(Address);
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

        public List<com_ListadoElementos_x_OT_Det_Info> Get_List_ListadoElementos_x_OT_Det(int IdEmpresa, decimal idLstMater)
        {
            List<com_ListadoElementos_x_OT_Det_Info> Lst = new List<com_ListadoElementos_x_OT_Det_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_ListadoElementos_x_OT_Detalle
                            where q.IdEmpresa == IdEmpresa && q.IdListadoElementos_x_OT == idLstMater
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoElementos_x_OT_Det_Info Obj = new com_ListadoElementos_x_OT_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;

                    Obj.IdOrdenTaller = item.IdOrdenTaller;
                    Obj.IdListadoElementos_x_OT = item.IdListadoElementos_x_OT;
                    Obj.IdDetalle = item.IdDetalle;
                    Obj.IdProducto = item.IdProducto;
                    Obj.pr_largo = item.pr_largo;
                    Obj.largo_total = item.largo_total;
                    Obj.Unidades = item.Unidades;
                    Obj.Det_Kg = item.Det_Kg;
                    Obj.CodObra = item.CodObra;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.lm_IdEstadoAprobado = item.IdEstadoAprob;

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

        public Boolean EliminarDB(List<com_ListadoElementos_x_OT_Det_Info> LstInfo, ref string msg)
        {
            try
            {

                using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                {
                    foreach (var item in LstInfo)
                    {
                        var address = context.com_ListadoElementos_x_OT_Det.FirstOrDefault
                            (A => A.IdEmpresa == item.IdEmpresa &&
                                A.IdOrdenTaller == item.IdOrdenTaller && A.IdListadoElementos_x_OT == item.IdListadoElementos_x_OT);

                        if (address != null)
                        {
                            context.com_ListadoElementos_x_OT_Det.Remove(address);
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

        public List<com_ListadoElementos_x_OT_Det_Info> Get_List_ListadoElementos_x_OT_Det(int IdEmpresa)
        {
            List<com_ListadoElementos_x_OT_Det_Info> Lst = new List<com_ListadoElementos_x_OT_Det_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_AllListDetElementos_x_OT
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoElementos_x_OT_Det_Info Obj = new com_ListadoElementos_x_OT_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdOrdenTaller = item.IdOrdenTaller;
                    Obj.ot_IdSucursal = item.IdSucursal;
                    Obj.IdListadoElementos_x_OT = item.IdListadoElementos_x_OT;
                    Obj.IdDetalle = item.IdDetalle;
                    Obj.IdProducto = item.IdProducto;
                    Obj.Unidades = item.Unidades;
                    Obj.Det_Kg = item.Det_Kg;
                    Obj.CodObra = item.CodObra;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.lm_IdEstadoAprobado = item.IdEstadoAprob;
                    Obj.ea_codigo = item.IdEstadoAprob;
                    //Obj.ea_descripcion = item.ea_descripcion;
                    Obj.FechaRequer = item.FechaReg;
                    Obj.mr_descripcion = item.mr_descripcion;
                    Obj.Motivo = item.Motivo;
                    Obj.ob_descripcion = item.ob_descripcion;
                    Obj.ot_codigo = item.ot_descripcion;
                    Obj.obra = item.ob_descripcion;
                    Obj.producto = item.pr_descripcion + "[" + item.pr_codigo + "/" + item.IdProducto + "] ";
                    Obj.solicitante = item.Usuario;

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

        public Boolean ActualizarEstadoAprob(com_ListadoElementos_x_OT_Det_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                {
                    var contact = context.com_ListadoElementos_x_OT_Det.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa
                        && obj.IdListadoElementos_x_OT == Info.IdListadoElementos_x_OT && obj.IdDetalle == Info.IdDetalle);

                    if (contact != null)
                    {
                        contact.IdEstadoAprob = Info.lm_IdEstadoAprobado;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar elListado de Elementos #: " + Info.IdListadoElementos_x_OT.ToString() + " exitosamente.";
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

        public com_ListadoElementos_x_OT_Det_Info Get_List_ListadoElementos_x_OT_Det(int IdEmpresa, decimal IdListadoElemento, int IdDetalle)
        {
            com_ListadoElementos_x_OT_Det_Info Obj = new com_ListadoElementos_x_OT_Det_Info();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_ListadoElementos_x_OT_Detalle
                            where q.IdEmpresa == IdEmpresa
                            && q.IdListadoElementos_x_OT == IdListadoElemento
                            && q.IdDetalle == IdDetalle
                            select q;
                foreach (var item in Query)
                {

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdListadoElementos_x_OT = item.IdListadoElementos_x_OT;
                    Obj.IdDetalle = item.IdDetalle;
                    Obj.CodObra = item.CodObra;
                    Obj.IdOrdenTaller = item.IdOrdenTaller;
                    Obj.IdProducto = item.IdProducto;
                    Obj.Unidades = item.Unidades;
                    Obj.Det_Kg = item.Det_Kg;
                    Obj.lm_IdEstadoAprobado = item.IdEstadoAprob;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.producto = "[" + item.IdProducto + "] [" + item.pr_codigo + "] " + item.pr_descripcion;

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

        public List<com_ListadoElementos_x_OT_Det_Info> Get_List_ListadoElementos_x_OT_Det(int IdEmpresa, string CodObra)
        {
            List<com_ListadoElementos_x_OT_Det_Info> Lst = new List<com_ListadoElementos_x_OT_Det_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_AllListDetElementos_x_OT
                            where q.IdEmpresa == IdEmpresa
                            && q.CodObra == CodObra
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoElementos_x_OT_Det_Info Obj = new com_ListadoElementos_x_OT_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdOrdenTaller = item.IdOrdenTaller;

                    Obj.ot_IdSucursal = item.IdSucursal;
                    Obj.IdListadoElementos_x_OT = item.IdListadoElementos_x_OT;
                    Obj.IdDetalle = item.IdDetalle;
                    Obj.IdProducto = item.IdProducto;
                    Obj.Unidades = item.Unidades;
                    Obj.Det_Kg = item.Det_Kg;

                    Obj.pr_largo = item.pr_largo;
                    //Obj.largo_total = item.largo_total;
                    Obj.largo_total = item.Unidades * item.pr_largo;

                    Obj.CodObra = item.CodObra;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.lm_IdEstadoAprobado = item.IdEstadoAprob;
                    Obj.ea_codigo = item.IdEstadoAprob;
                    
                    Obj.FechaRequer = item.FechaReg;
                    Obj.mr_descripcion = item.mr_descripcion;
                    Obj.Motivo = item.Motivo;
                    Obj.ob_descripcion = item.ob_descripcion;
                    Obj.ot_codigo = item.ot_descripcion;
                    Obj.obra = item.ob_descripcion;
                    Obj.largo_restante = item.largo_restante;
                    Obj.producto = item.pr_descripcion + "[" + item.pr_codigo + "/" + item.IdProducto + "] ";
                    Obj.solicitante = item.Usuario;

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

        public List<com_ListadoElementos_x_OT_Det_Info> Get_List_ListadoDespunteMateriales_Det(int IdEmpresa, string CodObra)
        {
            List<com_ListadoElementos_x_OT_Det_Info> Lst = new List<com_ListadoElementos_x_OT_Det_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_AllListDetElementos_x_OT
                            where q.IdEmpresa == IdEmpresa
                            && q.CodObra == CodObra
                            && q.largo_despunte1 != null
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoElementos_x_OT_Det_Info Obj = new com_ListadoElementos_x_OT_Det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdOrdenTaller = item.IdOrdenTaller;

                    Obj.ot_IdSucursal = item.IdSucursal;
                    Obj.IdListadoElementos_x_OT = item.IdListadoElementos_x_OT;
                    Obj.IdDetalle = item.IdDetalle;
                    Obj.IdProducto = item.IdProducto;
                    Obj.Unidades = item.Unidades;
                    Obj.Det_Kg = item.Det_Kg;
                    Obj.CodObra = item.CodObra;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.lm_IdEstadoAprobado = item.IdEstadoAprob;
                    Obj.ea_codigo = item.IdEstadoAprob;
                    
                    Obj.FechaRequer = item.FechaReg;
                    Obj.mr_descripcion = item.mr_descripcion;
                    Obj.Motivo = item.Motivo;
                    Obj.ob_descripcion = item.ob_descripcion;
                    Obj.ot_codigo = item.ot_descripcion;
                    Obj.obra = item.ob_descripcion;
                    Obj.largo_restante = item.largo_restante;
                    Obj.producto = item.pr_descripcion + "[" + item.pr_codigo + "/" + item.IdProducto + "] ";
                    Obj.solicitante = item.Usuario;

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



    }
}
