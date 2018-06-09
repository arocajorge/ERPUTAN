using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
    public class in_producto_x_cp_proveedor_Data
    {
        string mensaje = "";
        public List<in_producto_x_cp_proveedor_Info> Get_List_producto_x_cp_proveedor(int IdEmpresa)
        {
            try
            {
                List<in_producto_x_cp_proveedor_Info> lm = new List<in_producto_x_cp_proveedor_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var registros = from A in OEInventario.in_producto_x_cp_proveedor
                                where A.IdEmpresa_prod == IdEmpresa
                                select A;

                foreach (var item in registros)
                {
                    in_producto_x_cp_proveedor_Info infopxp = new in_producto_x_cp_proveedor_Info();
                    infopxp.IdEmpresa_prod = item.IdEmpresa_prod;
                    infopxp.IdEmpresa_prov = item.IdEmpresa_prov;
                    infopxp.IdProducto = item.IdProducto;
                    infopxp.IdProveedor = item.IdProveedor;
                    infopxp.NomProducto_en_Proveedor = item.NomProducto_en_Proveedor;
                    lm.Add(infopxp);
                }
                return lm;
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

        public Boolean ModificarDB(in_producto_x_cp_proveedor_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_producto_x_cp_proveedor.FirstOrDefault(A => A.IdEmpresa_prod == Info.IdEmpresa_prod && A.IdProducto == Info.IdProducto && A.IdProveedor == Info.IdProveedor);
                    if (contact != null)
                    {
                        contact.NomProducto_en_Proveedor = Info.NomProducto_en_Proveedor;

                        context.SaveChanges();
                        mensaje = "Grabacion ok...";
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

        public Boolean Eliminarregistro(List<in_producto_x_cp_proveedor_Info> lst, int IdEmpresa, int IdProducto,  ref string mensaje)
        {
            try
            {
                using (EntitiesInventario contex1 = new EntitiesInventario())
                {
                    foreach (var item in lst)
                    {
                        var address1 = contex1.in_producto_x_cp_proveedor.FirstOrDefault(A => A.IdEmpresa_prod == IdEmpresa && A.IdProducto == IdProducto);
                        if (address1 != null)
                        {
                            address1.IdEmpresa_prod = IdEmpresa;
                            address1.IdProducto = IdProducto;
                            address1.IdEmpresa_prov = IdEmpresa;
                            address1.NomProducto_en_Proveedor = item.NomProducto_en_Proveedor;
                            contex1.in_producto_x_cp_proveedor.Remove(address1);
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

        public Boolean EliminarRegistro(int IdEmpresa, int IdProductoPadre, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario entity = new EntitiesInventario())
                {
                    var LIST = entity.in_producto_x_cp_proveedor.Where(v => v.IdEmpresa_prod == IdEmpresa && v.IdProducto == IdProductoPadre);
                    string qry = string.Format("delete in_producto_x_cp_proveedor where IdEmpresa_prod = " + IdEmpresa + " and IdProducto = " + IdProductoPadre + "and IdEmpresa_prov  = " +IdEmpresa);
                   var s = entity.Database.ExecuteSqlCommand(qry);
                    
                    entity.Database.ExecuteSqlCommand("delete in_Producto_Composicion where IdEmpresa = " + IdEmpresa + " and IdProductoPadre = " + IdProductoPadre);
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

        public Boolean ModificarDB(List<in_producto_x_cp_proveedor_Info> lst, int IdEmpresa, int IdProducto, ref string mensaje)
        {
            try
            {
                foreach (var item in lst)
                {
                    GrabarDB(item, IdEmpresa, IdProducto, ref mensaje);
                }
                mensaje = "Acualizado Correctamente";
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

        public Boolean GrabarDB(List<in_producto_x_cp_proveedor_Info> Lista, int IdEmpresa, decimal IdProducto, ref string mensaje)
        {
            try
            {


                    using (EntitiesInventario contex = new EntitiesInventario())
                    {

                        foreach (var itemP in Lista)
                        {
                            var address = new in_producto_x_cp_proveedor();
                            address.IdEmpresa_prod = itemP.IdEmpresa_prod;
                            address.IdEmpresa_prov = IdEmpresa;
                            address.IdProducto = IdProducto;
                            address.IdProveedor = itemP.IdProveedor;
                            address.NomProducto_en_Proveedor = itemP.NomProducto_en_Proveedor;
                            contex.in_producto_x_cp_proveedor.Add(address);
                            contex.SaveChanges();
                        }

                        contex.Dispose();
                    }

                


                mensaje = "Guardado con exito";
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

        public Boolean GrabarDB(in_producto_x_cp_proveedor_Info item, int IdEmpresa, decimal IdProducto, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario contex = new EntitiesInventario())
                {
                    var address = new in_producto_x_cp_proveedor();
                    address.IdEmpresa_prod = item.IdEmpresa_prod;
                    address.IdEmpresa_prov = IdEmpresa;
                    address.IdProducto = IdProducto;
                    address.IdProveedor = item.IdProveedor;
                    address.NomProducto_en_Proveedor = item.NomProducto_en_Proveedor;

                    contex.in_producto_x_cp_proveedor.Add(address);
                    contex.SaveChanges();
                    contex.Dispose();
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

        public Boolean Eliminarregistro(in_producto_x_cp_proveedor_Info item, int IdEmpresa, decimal IdProducto, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario contex1 = new EntitiesInventario())
                {
                    var address1 = contex1.in_producto_x_cp_proveedor.FirstOrDefault(A => A.IdEmpresa_prod == IdEmpresa && A.IdProducto == IdProducto);
                    if (address1 != null)
                    {
                        address1.IdEmpresa_prod = IdEmpresa;
                        address1.IdProducto = IdProducto;
                        address1.IdEmpresa_prov = IdEmpresa;
                        address1.NomProducto_en_Proveedor = item.NomProducto_en_Proveedor;

                        contex1.in_producto_x_cp_proveedor.Remove(address1);
                        contex1.SaveChanges();
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
    }
}
