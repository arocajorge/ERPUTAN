using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario_Fj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Inventario_Fj
{
    public class in_Orden_servicio_x_Activo_fijo_Data
    {
        string mensaje = "";

        public decimal Get_Id(int idEmpresa, int idSucursal)
        {
            try
            {
                decimal x = 0;
                using (EntitiesInventario_Fj Conexion = new EntitiesInventario_Fj())
                {
                    x = (from q in Conexion.in_Orden_servicio_x_Activo_fijo
                         where q.IdEmpresa == idEmpresa && q.IdSucursal == idSucursal
                         select q.IdOrdenSer_x_Af).Max()+1;
                }
                
                return x;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                return 1;
            }
        }

        public List<in_Orden_servicio_x_Activo_fijo_Info> Get_Lista_Orden_servicio(int idEmpresa)
        {
            try
            {
                List<in_Orden_servicio_x_Activo_fijo_Info> Lista = new List<in_Orden_servicio_x_Activo_fijo_Info>();

                using (EntitiesInventario_Fj Conexion = new EntitiesInventario_Fj())
                {
                    Lista = (from q in Conexion.in_Orden_servicio_x_Activo_fijo
                             where q.IdEmpresa == idEmpresa 
                             select new in_Orden_servicio_x_Activo_fijo_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdOrdenSer_x_Af = q.IdOrdenSer_x_Af,
                                 IdBodega = q.IdBodega,
                                 IdActivoFijo = q.IdActivoFijo,
                                 IdProveedor = q.IdProveedor,
                                 Fecha = q.Fecha,
                                 Num_Fact = q.Num_Fact,
                                 Num_Documento = q.Num_Documento,
                                 IdCentroCosto = q.IdCentroCosto,
                                 Observacion = q.Observacion,
                                 IdUsuarioUltAnu = q.IdUsuarioUltAnu,
                                 motivoAnulacion = q.motivoAnulacion,
                                 FechaHoraAnul = q.FechaHoraAnul,
                                 Estado = q.Estado
                                 
                             }).ToList();
                }
                return Lista;
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

        public List<in_Orden_servicio_x_Activo_fijo_Info> Get_Lista_Orden_servicio_x_Sucursal_y_Bodega(int idEmpresa, int idSucursal, int idBodega)
        {
            try
            {
                List<in_Orden_servicio_x_Activo_fijo_Info> Lista = new List<in_Orden_servicio_x_Activo_fijo_Info>();

                using (EntitiesInventario_Fj Conexion = new EntitiesInventario_Fj())
                {
                    Lista = (from q in Conexion.in_Orden_servicio_x_Activo_fijo
                             where q.IdEmpresa == idEmpresa && q.IdSucursal == idSucursal
                             && q.IdBodega == idBodega
                             select new in_Orden_servicio_x_Activo_fijo_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdOrdenSer_x_Af = q.IdOrdenSer_x_Af,
                                 IdBodega = q.IdBodega,
                                 IdActivoFijo = q.IdActivoFijo,
                                 IdProveedor = q.IdProveedor,
                                 Fecha = q.Fecha,
                                 Num_Fact = q.Num_Fact,
                                 Num_Documento = q.Num_Documento,
                                 IdCentroCosto = q.IdCentroCosto,
                                 Observacion = q.Observacion,
                                 IdUsuarioUltAnu = q.IdUsuarioUltAnu,
                                 motivoAnulacion = q.motivoAnulacion,
                                 FechaHoraAnul = q.FechaHoraAnul,
                                 Estado = q.Estado
                             }).ToList();
                }
                return Lista;
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

        public Boolean GuardarDB(in_Orden_servicio_x_Activo_fijo_Info info)
        {
            try
            {
                using (EntitiesInventario_Fj Conexion = new EntitiesInventario_Fj())
                {
                    in_Orden_servicio_x_Activo_fijo Orden = new in_Orden_servicio_x_Activo_fijo();

                    Orden.IdEmpresa = info.IdEmpresa;
                    Orden.IdSucursal = info.IdSucursal;
                    Orden.IdOrdenSer_x_Af = info.IdOrdenSer_x_Af = Get_Id(info.IdEmpresa,info.IdSucursal);
                    Orden.IdBodega = info.IdBodega;
                    Orden.IdActivoFijo = info.IdActivoFijo;
                    Orden.IdProveedor = info.IdProveedor;
                    Orden.Fecha = info.Fecha;
                    Orden.Num_Fact = info.Num_Fact;
                    Orden.Num_Documento = info.Num_Documento;
                    Orden.IdCentroCosto = info.IdCentroCosto;
                    Orden.Observacion = info.Observacion;
                    Orden.Estado = info.Estado;

                    Conexion.in_Orden_servicio_x_Activo_fijo.Add(Orden);
                    Conexion.SaveChanges();

                    in_Orden_servicio_x_Activo_fijo_det_Data Data = new in_Orden_servicio_x_Activo_fijo_det_Data();
                    foreach (var item in info.List_in_Orden_servicio_x_Activo_fijo_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdOrdenSer_x_Af = info.IdOrdenSer_x_Af;
                    }
                    Data.GuardarDB(info.List_in_Orden_servicio_x_Activo_fijo_det);
                    
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

        public Boolean ActualizarDB(in_Orden_servicio_x_Activo_fijo_Info info)
        {
            try
            {
                using (EntitiesInventario_Fj Conexion = new EntitiesInventario_Fj())
                {
                    in_Orden_servicio_x_Activo_fijo Orden = Conexion.in_Orden_servicio_x_Activo_fijo.FirstOrDefault(q => q.IdOrdenSer_x_Af == info.IdOrdenSer_x_Af && q.IdEmpresa == info.IdEmpresa
                        && q.IdSucursal == info.IdSucursal);

                    Orden.IdEmpresa = info.IdEmpresa;
                    Orden.IdSucursal = info.IdSucursal;
                    Orden.IdOrdenSer_x_Af = info.IdOrdenSer_x_Af;
                    Orden.IdBodega = info.IdBodega;
                    Orden.IdActivoFijo = info.IdActivoFijo;
                    Orden.IdProveedor = info.IdProveedor;
                    Orden.Fecha = info.Fecha;
                    Orden.Num_Fact = info.Num_Fact;
                    Orden.Num_Documento = info.Num_Documento;
                    Orden.IdCentroCosto = info.IdCentroCosto;
                    Orden.Observacion = info.Observacion;
                    Orden.Estado = info.Estado;

                    in_Orden_servicio_x_Activo_fijo_det_Data Data = new in_Orden_servicio_x_Activo_fijo_det_Data();
                    List<in_Orden_servicio_x_Activo_fijo_det_Info> Lista_det_OS;
                    Lista_det_OS = new List<in_Orden_servicio_x_Activo_fijo_det_Info>(Data.Get_Lista_det_x_Orden_servicio(info.IdEmpresa, info.IdSucursal, info.IdOrdenSer_x_Af));

                    if (Lista_det_OS.Count() != 0)
                        Data.EliminarDB(info);

                    foreach (var item in info.List_in_Orden_servicio_x_Activo_fijo_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdOrdenSer_x_Af = info.IdOrdenSer_x_Af;
                    }
                    Data.GuardarDB(info.List_in_Orden_servicio_x_Activo_fijo_det);

                    Conexion.SaveChanges();
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

        public Boolean AnularDB(in_Orden_servicio_x_Activo_fijo_Info info)
        {
            try
            {
                using (EntitiesInventario_Fj Conexion = new EntitiesInventario_Fj())
                {
                    in_Orden_servicio_x_Activo_fijo Orden = Conexion.in_Orden_servicio_x_Activo_fijo.FirstOrDefault(q=>q.IdOrdenSer_x_Af == info.IdOrdenSer_x_Af && q.IdEmpresa
                         == info.IdEmpresa && q.IdSucursal == info.IdSucursal);

                    Orden.Estado = "I";
                    Orden.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    Orden.motivoAnulacion = info.motivoAnulacion;
                    Orden.FechaHoraAnul = info.FechaHoraAnul;
                    
                    in_Orden_servicio_x_Activo_fijo_det_Data Data = new in_Orden_servicio_x_Activo_fijo_det_Data();
                    List<in_Orden_servicio_x_Activo_fijo_det_Info> Lista_det_OS;
                    Lista_det_OS = new List<in_Orden_servicio_x_Activo_fijo_det_Info>(Data.Get_Lista_det_x_Orden_servicio(info.IdEmpresa, info.IdSucursal, info.IdOrdenSer_x_Af));

                    if (Lista_det_OS.Count() != 0)
                        Data.EliminarDB(info);

                    Conexion.SaveChanges();
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

        public List<in_Orden_servicio_x_Activo_fijo_Info> Get_Lista_Vista(int idEmpresa, ref string mensaje)
        {
            try
            {
                List<in_Orden_servicio_x_Activo_fijo_Info> Lista = new List<in_Orden_servicio_x_Activo_fijo_Info>();

                using (EntitiesInventario_Fj Conexion = new EntitiesInventario_Fj())
                {
                    Lista = (from q in Conexion.vwin_Orden_servicio_x_activo_fijo
                             where q.IdEmpresa == idEmpresa
                             select new in_Orden_servicio_x_Activo_fijo_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdOrdenSer_x_Af = q.IdOrdenSer_x_Af,
                                 IdBodega = q.IdBodega,
                                 IdActivoFijo = q.IdActivoFijo,
                                 IdProveedor = q.IdProveedor,
                                 Fecha = q.Fecha,
                                 Num_Fact = q.Num_Fact,
                                 Num_Documento = q.Num_Documento,
                                 IdCentroCosto = q.IdCentroCosto,
                                 Observacion = q.Observacion,
                                 Estado = q.Estado,
                                 bo_Descripcion = q.bo_Descripcion,
                                 Af_Nombre = q.Af_Nombre,
                                 Centro_costo = q.Centro_costo,
                                 pr_nombre = q.pr_nombre,
                                 Su_Descripcion = q.Su_Descripcion
                             }).ToList();
                }
                return Lista;
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

        public List<in_Orden_servicio_x_Activo_fijo_Info> Get_Lista_Vista_x_sucursal_x_bodega(int idEmpresa, int idSucursal, int idSucursalFin, int idBodega, int idBodegaFin, DateTime fechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                List<in_Orden_servicio_x_Activo_fijo_Info> Lista = new List<in_Orden_servicio_x_Activo_fijo_Info>();

                using (EntitiesInventario_Fj Conexion = new EntitiesInventario_Fj())
                {
                    Lista = (from q in Conexion.vwin_Orden_servicio_x_activo_fijo
                             where q.IdEmpresa == idEmpresa && 
                             idSucursal<= q.IdSucursal && q.IdSucursal <= idSucursalFin && 
                             idBodega<= q.IdBodega && q.IdBodega <= idBodegaFin
                             && fechaIni<=q.Fecha && q.Fecha<=FechaFin
                             select new in_Orden_servicio_x_Activo_fijo_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdOrdenSer_x_Af = q.IdOrdenSer_x_Af,
                                 IdBodega = q.IdBodega,
                                 IdActivoFijo = q.IdActivoFijo,
                                 IdProveedor = q.IdProveedor,
                                 Fecha = q.Fecha,
                                 Num_Fact = q.Num_Fact,
                                 Num_Documento = q.Num_Documento,
                                 IdCentroCosto = q.IdCentroCosto,
                                 Observacion = q.Observacion,
                                 Estado = q.Estado,
                                 bo_Descripcion = q.bo_Descripcion,
                                 Af_Nombre = q.Af_Nombre,
                                 Centro_costo = q.Centro_costo,
                                 pr_nombre = q.pr_nombre,
                                 Su_Descripcion = q.Su_Descripcion
                             }).ToList();
                }
                return Lista;
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
