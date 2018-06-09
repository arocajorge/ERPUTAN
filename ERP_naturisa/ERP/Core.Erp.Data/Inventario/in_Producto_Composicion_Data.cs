using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Inventario
{
    public class in_Producto_Composicion_Data
    {
        string mensaje = "";
        public List<in_Producto_Composicion_Info> Get_List_Producto_Composicion(int IdEmpresa, int IdProductoPadre)
        {
            try
            {
                List<in_Producto_Composicion_Info> lM = new List<in_Producto_Composicion_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();


                var select = (from A in OEInventario.in_Producto_Composicion
                              join B in OEInventario.in_Producto
                               on new { A.IdEmpresa } equals new { B.IdEmpresa }

                              where A.IdEmpresa == IdEmpresa && A.IdProductoPadre == IdProductoPadre && A.IdProductoHijo == B.IdProducto
                              select new
                              {
                                  A.IdEmpresa,
                                  A.IdProductoPadre,
                                  A.IdProductoHijo,
                                  A.Cantidad,
                                  B.pr_descripcion
                              });

                foreach (var item in select)
                {
                    in_Producto_Composicion_Info info = new in_Producto_Composicion_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProductoPadre = item.IdProductoPadre;
                    info.IdProductoHijo = item.IdProductoHijo;
                    info.Cantidad = item.Cantidad;
                    info.NomProdcutoHijo = item.pr_descripcion;
                    lM.Add(info);
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }

        }

        public Boolean GrabarDB(List<in_Producto_Composicion_Info> ListInfo, int IdProductoPadre, ref string mensaje)
        {

            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    foreach (var item in ListInfo)
                    {
                        var address = new in_Producto_Composicion();

                        address.IdEmpresa = item.IdEmpresa;
                        address.IdProductoPadre = IdProductoPadre;
                        address.IdProductoHijo = item.IdProductoHijo;
                        address.Cantidad = item.Cantidad;

                        context.in_Producto_Composicion.Add(address);
                        context.SaveChanges();
                    }
                    context.Dispose();
                    mensaje = "Guardado con exito";
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);

            }
        }

        public Boolean eliminarregistrotabla(List<in_Producto_Composicion_Info> lst, int idEmpresa, int IdProductoPadre, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario contex1 = new EntitiesInventario())
                {
                    foreach (var item in lst)
                    {
                        var address = contex1.in_Producto_Composicion.FirstOrDefault(A => A.IdEmpresa == idEmpresa && A.IdProductoPadre == IdProductoPadre);
                        if (address != null)
                        {
                            address.IdEmpresa = idEmpresa;
                            address.IdProductoPadre = IdProductoPadre;
                            address.IdProductoHijo = address.IdProductoHijo;
                            address.Cantidad = item.Cantidad;

                            //contac1 = address;
                            contex1.in_Producto_Composicion.Remove(address);
                            contex1.SaveChanges();
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public Boolean eliminarRegistro_x_producto(int idEmpresa, int IdProductoPadre, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario entity = new EntitiesInventario())
                {
                    entity.Database.ExecuteSqlCommand("delete in_Producto_Composicion where IdEmpresa = " + idEmpresa + " and IdProductoPadre = " + IdProductoPadre);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}
