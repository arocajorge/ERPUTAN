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
    public class in_Orden_servicio_x_Activo_fijo_det_Data
    {
        string mensaje = "";

        public List<in_Orden_servicio_x_Activo_fijo_det_Info> Get_Lista_det_x_Orden_servicio(int idEmpresa, int idSucursal, decimal IdOrdenSer_x_Af)
        {
            try
            {
                List<in_Orden_servicio_x_Activo_fijo_det_Info> Lista = new List<in_Orden_servicio_x_Activo_fijo_det_Info>();

                using (EntitiesInventario_Fj Conexion = new EntitiesInventario_Fj())
                {
                    Lista = (from q in Conexion.in_Orden_servicio_x_Activo_fijo_det
                             where q.IdEmpresa == idEmpresa && q.IdSucursal == idSucursal && q.IdOrdenSer_x_Af == IdOrdenSer_x_Af
                             select new in_Orden_servicio_x_Activo_fijo_det_Info{
                                     IdEmpresa = q.IdEmpresa,
                                     IdSucursal = q.IdSucursal,
                                     IdOrdenSer_x_Af = q.IdOrdenSer_x_Af,
                                     Secuencia = q.Secuencia,
                                     IdProducto = q.IdProducto,
                                     Cantidad = q.Cantidad,
                                     Costo = q.Costo,
                                     SubTotal = q.SubTotal,
                                     Iva = q.Iva,
                                     Total = q.Total,
                                     Maneja_Iva = q.Maneja_Iva,
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

        public Boolean GuardarDB(List<in_Orden_servicio_x_Activo_fijo_det_Info> info)
        {
            try
            {
                int sec = 1;
                foreach (var item in info)
                {
                    using (EntitiesInventario_Fj Conexion = new EntitiesInventario_Fj())
                    {
                        in_Orden_servicio_x_Activo_fijo_det Orden = new in_Orden_servicio_x_Activo_fijo_det();
                        Orden.IdEmpresa = item.IdEmpresa;
                        Orden.IdSucursal = item.IdSucursal;
                        Orden.IdOrdenSer_x_Af = item.IdOrdenSer_x_Af;
                        Orden.Secuencia = sec;
                        Orden.IdProducto = item.IdProducto;
                        Orden.Cantidad = item.Cantidad;
                        Orden.Costo = item.Costo;
                        Orden.SubTotal = item.SubTotal;
                        Orden.Iva = item.Iva;
                        Orden.Total = item.Total;
                        Orden.Maneja_Iva = item.Maneja_Iva;

                        Conexion.in_Orden_servicio_x_Activo_fijo_det.Add(Orden);
                        Conexion.SaveChanges();
                    }
                    sec++;
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

        public Boolean EliminarDB(in_Orden_servicio_x_Activo_fijo_Info info)
        {
            try
            {
                EntitiesInventario_Fj Conexion = new EntitiesInventario_Fj();

                var Comando = Conexion.Database.ExecuteSqlCommand("delete from in_Orden_servicio_x_Activo_fijo_det where IdEmpresa = " + info.IdEmpresa + " and IdSucursal = " + info.IdSucursal + " and IdOrdenSer_x_Af = " + info.IdOrdenSer_x_Af + "");

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

       
    }
}
