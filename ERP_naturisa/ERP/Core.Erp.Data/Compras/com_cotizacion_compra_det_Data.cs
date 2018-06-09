using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Compras
{
    public class com_cotizacion_compra_det_Data
    {

        string mensaje = "";
        public List<com_cotizacion_compra_det_Info> Get_list_Cotizacion_detalle(int IdEmpresa, ref string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {

                    string Query = "declare @IdEmpresa int = " + IdEmpresa +
                        "select * from com_cotizacion_compra where IdEmpresa not in(select IdEmpresa from com_cotizacion_compra_det where " +
                        " IdCotizacion not in (select IdCotizacion from com_cotizacion_compra_det where IdEmpresa ="
                        + IdEmpresa + "  ) and IdEmpresa = " + IdEmpresa + ") and IdEmpresa =" + IdEmpresa;

                    msg = "Proceso exitoso";
                    return context.Database.SqlQuery<com_cotizacion_compra_det_Info>(Query).ToList();
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
        
        public List<com_cotizacion_compra_det_Info> Get_list_Cotizacion_detalle(int IdEmpresa, int IdSucursal,string IdCategoria)
        {
            try
            {
                List<com_cotizacion_compra_det_Info> lm = new List<com_cotizacion_compra_det_Info>();
                EntitiesCompras OEEtapa = new EntitiesCompras();
                 var registros = from A in OEEtapa.vwcom_ListadoMateriales_Detalle_Saldos
                                where A.IdEmpresa == IdEmpresa
                                && A.IdSucursal == IdSucursal
                                && A.IdCategoria==IdCategoria
                                && A.saldo>0
                             
                                orderby A.IdEmpresa
                                select A;
                foreach (var item in registros)
                {
                    com_cotizacion_compra_det_Info info = new com_cotizacion_compra_det_Info();

                    info.IdEmpresa_lq = item.IdEmpresa;
                    info.IdListadoMateriales_lq = item.IdListadoMateriales;
                    info.IdDetalle_lq = item.IdDetalle;
                 
                    info.Su_Descripcion = item.Su_Descripcion;
                    info.FechaReg = item.FechaReg;                  
                    info.IdProducto = item.IdProducto;
                    info.Cant_soli = item.Unidades;
                    info.Cant_a_cotizar = 0;
                    info.Cant_soli_AUX = item.Unidades;
                    info.pr_descripcion = item.pr_descripcion;
                    info.IdCategoria = item.IdCategoria;
                    info.saldo = item.saldo;
                    info.saldo_AUX = item.saldo;
                    lm.Add(info);
                }
                return lm;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
        
        public List<com_cotizacion_compra_det_Info> Get_list_Cotizacion_detalle(int IdEmpresa,int IdSucursal, decimal IdCotizacion)
        {
            try
            {
                List<com_cotizacion_compra_det_Info> lm = new List<com_cotizacion_compra_det_Info>();
                EntitiesCompras OEEtapa = new EntitiesCompras();

                var registros = from A in OEEtapa.vwcom_cotizacion_compra_det_Saldos
                                where A.IdEmpresa == IdEmpresa
                                && A.IdSucursal == IdSucursal
                                && A.IdCotizacion == IdCotizacion
                                orderby A.IdEmpresa
                                select A;
                foreach (var item in registros)
                {
                    com_cotizacion_compra_det_Info info = new com_cotizacion_compra_det_Info();

                    info.IdEmpresa_lq = item.IdEmpresa;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCotizacion = IdCotizacion;

                    info.IdListadoMateriales_lq = Convert.ToDecimal(item.IdListadoMateriales_lq);
                    info.IdDetalle_lq = Convert.ToInt32(item.IdDetalle_lq);
                    info.Su_Descripcion = item.nom_sucursal;
                    info.FechaReg = Convert.ToDateTime(item.FechaReg);
                    info.IdProducto = Convert.ToDecimal(item.Idproducto);
                    info.Cant_soli = Convert.ToDouble(item.Cant_soli);
                    info.Cant_a_cotizar = Convert.ToDouble(item.Cant_a_cotizar);
                    info.Secuencia = item.Secuencia;
                    info.Cant_a_cotizar_AUX = Convert.ToDouble(item.Cant_a_cotizar);
                    info.Cant_soli_AUX = Convert.ToDouble(item.Cant_soli);

                    info.pr_descripcion = item.pr_descripcion;
                    info.saldo = item.saldo;
                    info.saldo_AUX = item.saldo;

                    lm.Add(info);
                }
                return lm;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
        
        public com_cotizacion_compra_det_Info Get_Info_Cotizacion_detalle(int IdEmpresa, string CodObra)
        {
            throw new NotImplementedException();
        }

        public decimal getId(int IdEmpresa)
        {
            decimal Id = 0;
            try
            {
                EntitiesCompras contex = new EntitiesCompras();
                var selecte = contex.com_cotizacion_compra.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.com_cotizacion_compra
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdCotizacion).Max();
                    Id = Convert.ToDecimal(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(List<com_cotizacion_compra_det_Info> lista, ref string msg)
        {
            try
            {                       
                    int sec = 0;
                    foreach (var item in lista)
                    {
                        using (EntitiesCompras Context = new EntitiesCompras())
                        {
                            sec = sec + 1;

                            var Address = new com_cotizacion_compra_det();

                            Address.IdEmpresa = item.IdEmpresa;
                            Address.IdCotizacion = item.IdCotizacion;                         
                            Address.Secuencia = sec;
                            Address.Idproducto = item.IdProducto;

                            Address.Cant_soli = item.Cant_soli;
                            Address.Cant_a_cotizar = item.Cant_a_cotizar;
                            Address.Observacion = item.Observacion;
                            Address.IdEmpresa_lq = Convert.ToInt32(item.IdEmpresa_lq);
                            Address.IdListadoMateriales_lq = Convert.ToDecimal(item.IdListadoMateriales_lq);
                            Address.IdDetalle_lq = Convert.ToInt32(item.IdDetalle_lq);  
                      
                            Context.com_cotizacion_compra_det.Add(Address);
                            Context.SaveChanges();

                        }
                    }
                               
                msg = "Grabación exitosa..";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(com_cotizacion_compra_det_Info info, ref string msg)
        {
            try
            {
                using (EntitiesCompras Context = new EntitiesCompras())
                {
                    var contact = Context.com_cotizacion_compra.FirstOrDefault(A => A.IdEmpresa == info.IdEmpresa && A.IdEmpresa == info.IdEmpresa);

                    if (contact != null)
                    {
                        contact.Observacion = info.Observacion;
                        Context.SaveChanges();
                    }
                }
                msg = "Grabación exitosa..";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VerificarExisteCodigo(string CodObra)
        {
            try
            {

                EntitiesCompras oen = new EntitiesCompras();

                var select = from q in oen.com_ListadoMateriales_Det
                             where q.CodObra == CodObra
                             select q;

                if (select.ToList().Count() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(int idempresa, decimal IdCotizacion, ref string msg)
        {
            try
            {

                using (EntitiesCompras Entity = new EntitiesCompras())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete com_cotizacion_compra_det where IdEmpresa = " + idempresa
                        + " and IdCotizacion = " + IdCotizacion);
                }
                msg = "Eliminado con éxito";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public List<com_cotizacion_compra_det_Info> Get_list_Cotizacion_detalle(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<com_cotizacion_compra_det_Info> lm = new List<com_cotizacion_compra_det_Info>();
                EntitiesCompras OEEtapa = new EntitiesCompras();
                var registros = from A in OEEtapa.vwcom_ListadoMateriales_Detalle_Saldos
                                where A.IdEmpresa == IdEmpresa
                                && A.IdSucursal == IdSucursal
                               
                                && A.saldo > 0

                                orderby A.IdEmpresa
                                select A;
                foreach (var item in registros)
                {
                    com_cotizacion_compra_det_Info info = new com_cotizacion_compra_det_Info();

                    info.IdEmpresa_lq = item.IdEmpresa;
                    info.IdListadoMateriales_lq = item.IdListadoMateriales;
                    info.IdDetalle_lq = item.IdDetalle;
                    info.Su_Descripcion = item.Su_Descripcion;
                    info.FechaReg = item.FechaReg;
                    info.IdProducto = item.IdProducto;
                    info.Cant_soli = item.Unidades;
                    info.Cant_a_cotizar = 0;
                    info.Cant_soli_AUX = item.Unidades;
                    info.pr_descripcion = item.pr_descripcion;
                    info.IdCategoria = item.IdCategoria;
                    info.saldo = item.saldo;
                    info.saldo_AUX = item.saldo;
                    lm.Add(info);
                }
                return lm;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
