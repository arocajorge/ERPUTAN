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
    public class com_cotizacion_compra_Data
    {
        string mensaje = "";
        public List<com_cotizacion_compra_Info> Get_List_cotizacion_compra(int IdEmpresa, ref string msg)
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
                    return context.Database.SqlQuery<com_cotizacion_compra_Info>(Query).ToList();
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

        public List<com_cotizacion_compra_Info> Get_List_cotizacion_compra(int IdEmpresa)
        {
            try
            {
                List<com_cotizacion_compra_Info> lm = new List<com_cotizacion_compra_Info>();
                EntitiesCompras OEEtapa = new EntitiesCompras();
                var registros = from A in OEEtapa.vwcom_cotizacion_compra
                                where A.IdEmpresa == IdEmpresa
                                orderby A.IdEmpresa
                                select A;
                foreach (var item in registros)
                {
                    com_cotizacion_compra_Info info = new com_cotizacion_compra_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = Convert.ToInt32(item.IdSucursal);
                    info.IdCotizacion = item.IdCotizacion;
                    info.Observacion = item.Observacion;
                    info.nom_sucursal = item.nom_sucursal;
                    info.estado = item.Estado;
                    info.IdProveedor =Convert.ToInt32( item.IdProveedor);
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

        public decimal GetId(int IdEmpresa)
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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GuardarDB(com_cotizacion_compra_Info info, ref string msg)
        {
            try
            {
               decimal idcotiza=0;
                using (EntitiesCompras Context = new EntitiesCompras())
                {

                    var Address = new com_cotizacion_compra();

                    Address.IdEmpresa = info.IdEmpresa;
                    Address.IdCotizacion =idcotiza= GetId(info.IdEmpresa);
                    Address.Fecha = DateTime.Now;
                    Address.IdSucursal = info.IdSucursal;
                    Address.Observacion = info.Observacion;
                    Address.Estado =Convert.ToString( info.estado);
                    Address.IdProveedor = info.IdProveedor;
                    Address.Fecha_Transac = info.Fecha_Transac;
                    Context.com_cotizacion_compra.Add(Address);

                    Context.SaveChanges();
                    
                    //grabar detalle
                    com_cotizacion_compra_det_Data odata = new com_cotizacion_compra_det_Data();

                    if (odata.GuardarDB(info.Detalle, ref msg))
                    {
                        msg = "Grabación exitosa..";
                    
                    }
                               
                }
               
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

        public Boolean ModificarDB(com_cotizacion_compra_Info info, ref string msg)
        {
            try
            {
                using (EntitiesCompras Context = new EntitiesCompras())
                {
                    var contact = Context.com_cotizacion_compra.FirstOrDefault(A => A.IdEmpresa == info.IdEmpresa && A.IdCotizacion == info.IdCotizacion);

                    if (contact !=null)
                    {
                    contact.Observacion = info.Observacion;
                    contact.Fecha_UltMod = DateTime.Now;
                    contact.IdProveedor = info.IdProveedor;
                    contact.IdUsuarioUltAnu = info.IdUsuarioUltMod;
                    Context.SaveChanges();

                                //Eliminar detalle
                                com_cotizacion_compra_det_Data odata = new com_cotizacion_compra_det_Data();
                                if (odata.EliminarDB(Convert.ToInt32(info.IdEmpresa), Convert.ToDecimal(info.IdCotizacion), ref  msg))
                                {
                                    //grabo nuevo detalle

                                    foreach (var item in info.Detalle)
                                    {
                                        item.IdEmpresa = info.IdEmpresa;
                                        item.IdCotizacion = info.IdCotizacion;

                                    }

                                    if (odata.GuardarDB(info.Detalle, ref msg))
                                    {

                                        msg = "Actualización exitosa..";
                                    }
                                }
                    }
                }
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

        public com_cotizacion_compra_Info Get_Info_cotizacion_compra(int IdEmpresa, string CodObra)
        {
            throw new NotImplementedException();
        }
        
        public bool AnularDB(com_cotizacion_compra_Info Info)
        {
            try
            {
                using (EntitiesCompras Context = new EntitiesCompras())
                {
                    var contact = Context.com_cotizacion_compra.First(A => A.IdEmpresa == Info.IdEmpresa && A.IdCotizacion == Info.IdCotizacion);
                    contact.FechaHoraAnul = Info.Fecha_Transac;
                    contact.IdUsuarioUltAnu = Info.idUsuario;
                    contact.MotivoAnulacion = Info.motiAnulacion;
                    contact.Estado= "I";
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                throw new Exception(ex.ToString());
            }
        }
    }
}
