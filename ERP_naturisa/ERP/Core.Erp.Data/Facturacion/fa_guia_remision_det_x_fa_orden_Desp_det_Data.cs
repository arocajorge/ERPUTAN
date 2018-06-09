using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_guia_remision_det_x_fa_orden_Desp_det_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(fa_guia_remision_Info Info,ref string mensaje2 ) 
        {
            try
            {
                foreach (var item in Info.ListaDetalle)
                {
                    using (EntitiesFacturacion Context = new EntitiesFacturacion())
                    {
                       
                        var Address = new fa_guia_remision_det_x_fa_orden_Desp_det();


                        Address.od_IdEmpresa = item.IdEmpresa;
                        Address.od_IdSucursal = item.IdSucursal;
                        Address.od_IdBodega = item.IdBodega;
                        Address.od_IdOrdenDespacho = item.od_IdOrdenDespacho;
                        Address.od_Secuencia = item.Secuencia;
                        Address.od_IdProducto = item.IdProducto;
                        Address.gi_cantidad = item.gi_cantidad;
                        Address.gi_IdEmpresa = item.IdEmpresa;
                        Address.gi_IdSucursal = item.IdSucursal;
                        Address.gi_IdBodega = item.IdBodega;
                        Address.gi_IdGuiaRemision= item.IdGuiaRemision;
                        Address.gi_Secuencia = item.Secuencia;
                        Address.gi_IdProducto = item.IdProducto;

                        Context.fa_guia_remision_det_x_fa_orden_Desp_det.Add(Address);
                        Context.SaveChanges();
                        Context.Dispose();                    
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                mensaje2 = mensaje;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_guia_remision_Info Info)
        {
            try
            {
                foreach (var item in Info.ListaDetalle)
                {                 
                    using (EntitiesFacturacion Context = new EntitiesFacturacion())
                    {

                        var Contact = Context.fa_guia_remision_det_x_fa_orden_Desp_det.FirstOrDefault(Address =>
                        Address.od_IdEmpresa == item.IdEmpresa &&
                        Address.od_IdSucursal == item.IdSucursal &&
                        Address.od_IdBodega == item.IdBodega &&
                        Address.od_IdOrdenDespacho == item.od_IdOrdenDespacho &&
                        Address.od_Secuencia == item.Secuencia &&
                        Address.od_IdProducto == item.IdProducto &&
                        Address.gi_IdEmpresa == item.IdEmpresa &&
                        Address.gi_IdSucursal == item.IdSucursal &&
                        Address.gi_IdBodega == item.IdBodega &&
                        Address.gi_IdGuiaRemision == item.IdGuiaRemision &&
                        Address.gi_Secuencia == item.Secuencia &&
                        Address.gi_IdProducto == item.IdProducto);

                        if (Contact != null)
                        {
                            Contact.gi_cantidad = item.gi_cantidad;

                            Context.SaveChanges();
                            Context.Dispose();
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
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public decimal GetIdOrdenDespacho(fa_guia_remision_Info Info) 
        {

            try
            {
                decimal IdOrdDespacho =0 ;


                EntitiesFacturacion oen = new EntitiesFacturacion();



                var id = from q in oen.fa_guia_remision_det_x_fa_orden_Desp_det
                          where q.gi_IdGuiaRemision == Info.IdGuiaRemision && q.gi_IdEmpresa == Info.IdEmpresa && q.gi_IdSucursal == Info.IdSucursal && q.gi_IdBodega == Info.IdBodega
                          select q.od_IdOrdenDespacho;
                
                foreach (decimal item in id)
                {
                    IdOrdDespacho = item;
                }               

                return IdOrdDespacho;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        
        }

        public List<fa_guia_remision_det_x_fa_orden_Desp_det_Info> Get_List_fa_guia_remision_det_x_fa_orden_Desp_det(fa_orden_Desp_Info Info)
        {
            try
            {
                EntitiesFacturacion oen = new EntitiesFacturacion();

                List<fa_guia_remision_det_x_fa_orden_Desp_det_Info> lista = new List<fa_guia_remision_det_x_fa_orden_Desp_det_Info>();

                var consulta = from q in oen.fa_guia_remision_det_x_fa_orden_Desp_det
                               where q.od_IdOrdenDespacho == Info.IdOrdenDespacho && q.gi_IdEmpresa == Info.IdEmpresa && q.gi_IdSucursal == Info.IdSucursal && q.gi_IdBodega == Info.IdBodega
                               select q;

                foreach (var item in consulta)
                {
                    fa_guia_remision_det_x_fa_orden_Desp_det_Info info = new fa_guia_remision_det_x_fa_orden_Desp_det_Info();

                    info.gi_IdEmpresa = item.gi_IdEmpresa;
                    info.gi_IdSucursal = item.gi_IdSucursal;
                    info.gi_IdBodega = item.gi_IdBodega;
                    info.gi_IdGuiaRemision = item.gi_IdGuiaRemision;
                    info.gi_Secuencia = item.gi_Secuencia;

                    info.gi_IdProducto = item.gi_IdProducto;
                    info.gi_cantidad = item.gi_cantidad;

                    info.od_IdEmpresa = item.od_IdEmpresa;
                    info.od_IdSucursal = item.od_IdSucursal;
                    info.od_IdBodega = item.od_IdBodega;
                    info.od_IdOrdenDespacho = item.od_IdOrdenDespacho;

                    info.od_Secuencia = item.od_Secuencia;
                    info.od_IdProducto = item.od_IdProducto;

                    lista.Add(info);

                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Eliminar_fa_guia_remision_det_x_fa_orden_Desp_det(fa_orden_Desp_Info info)
        {
            try
            {
                foreach (var item in info.ListaGuiaRemision)
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        var contact = context.fa_guia_remision_det_x_fa_orden_Desp_det.FirstOrDefault(obj => obj.od_IdEmpresa == item.od_IdEmpresa && obj.od_IdSucursal == item.od_IdSucursal && obj.od_IdBodega == item.od_IdBodega && obj.od_IdOrdenDespacho == item.od_IdOrdenDespacho && obj.od_Secuencia == item.od_Secuencia && obj.od_IdProducto == item.od_IdProducto &&
                                                                                             obj.gi_IdEmpresa == item.gi_IdEmpresa && obj.gi_IdSucursal == item.gi_IdSucursal && obj.gi_IdBodega == item.gi_IdBodega && obj.gi_IdGuiaRemision == item.gi_IdGuiaRemision && obj.gi_Secuencia == item.gi_Secuencia && obj.gi_IdProducto == item.gi_IdProducto);
                        if (contact != null)
                        {
                            context.fa_guia_remision_det_x_fa_orden_Desp_det.Remove(contact);
                            context.SaveChanges();
                            context.Dispose();
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
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
