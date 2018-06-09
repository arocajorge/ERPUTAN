using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Data.Inventario_Edehsa;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;
namespace Core.Erp.Data.Inventario_Edehsa
{
    public class in_Producto_Dimensiones_Data
    {
        string mensaje = "";
        public List<in_Producto_Dimensiones> Get_ListProducto_Dimensiones()
        {
            try
            {
                List<in_Producto_Dimensiones> lM = new List<in_Producto_Dimensiones>();
                EntitiesInventarioEdehsa OEUser = new EntitiesInventarioEdehsa();
                //Core.Erp.Data.Inventario_Edehsa.
                var select_ = from TI in OEUser.in_Producto_Dimensiones
                              select TI;


                foreach (var item in select_)
                {
                    in_Producto_Dimensiones dat_ = new in_Producto_Dimensiones();

                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdProducto = item.IdProducto;
                    //dat_.Secuencia = item.Secuencia;
                    dat_.longitud = item.longitud;
                    dat_.espesor = item.espesor;
                    dat_.ancho = item.ancho;
                    dat_.alto = item.alto;
                    dat_.ceja = item.ceja;
                    dat_.diametro = item.diametro;
                    dat_.estado = item.estado;

                    lM.Add(dat_);
                }
                return (lM);
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


        public in_Producto_Dimensiones Get_Info_Producto_Dimensiones(int IdProducto, int IdEmpresa)
        {
            try
            {
                in_Producto_Dimensiones producto_dimensiones = new in_Producto_Dimensiones();
                EntitiesInventarioEdehsa OEt = new EntitiesInventarioEdehsa();
                var productodimensiones = OEt.in_Producto_Dimensiones.First(var =>
                    var.IdProducto == IdProducto && var.IdEmpresa == IdEmpresa);

                //producto_dimensiones.Secuencia = productodimensiones.Secuencia;
                producto_dimensiones.longitud = productodimensiones.longitud;
                producto_dimensiones.espesor = productodimensiones.espesor;
                producto_dimensiones.ancho = productodimensiones.ancho;
                producto_dimensiones.alto = productodimensiones.alto;
                producto_dimensiones.ceja = productodimensiones.ceja;
                producto_dimensiones.diametro = productodimensiones.diametro;
                producto_dimensiones.estado = productodimensiones.estado;


                return producto_dimensiones;
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


        public List<in_Producto_Dimensiones_Info> Get_List_Producto_Dimensiones(int idEmpresa, int IdProducto)
        {
            try
            {
                List<in_Producto_Dimensiones_Info> lM = new List<in_Producto_Dimensiones_Info>();
                EntitiesInventarioEdehsa OEProducto_Dimensines_Info = new EntitiesInventarioEdehsa();
                var selectProducto_Dimensiones_Info = from C in OEProducto_Dimensines_Info.in_Producto_Dimensiones
                                                where C.IdEmpresa == idEmpresa
                                                 && C.IdProducto == IdProducto
                                                select C;

                foreach (var item in selectProducto_Dimensiones_Info)
                {
                    //in_Categoria_x_Formula_Info 
                    in_Producto_Dimensiones_Info info = new in_Producto_Dimensiones_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    
                    //info.Secuencia = item.Secuencia;
                    info.longitud = item.longitud;
                    info.espesor = item.espesor;
                    info.ancho = item.ancho;
                    info.alto = item.alto;
                    info.ceja = item.ceja;
                    info.diametro = item.diametro;
                    info.estado = item.estado;
                    //prd.estado = (item.estado eq 1) ? "ACTIVO" : "*ANULADO*";

                    // prd.Sestado = (item.Estado == "A") ? "ACTIVO" : "*ANULADO*";
                    lM.Add(info);
                    //lM.Add(info);
                }
                return (lM);
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


        public Boolean GrabarDB(in_Producto_Dimensiones_Info info, ref decimal IdProducto, ref string mensaje)
        {
            try
            {
                using (EntitiesInventarioEdehsa context = new EntitiesInventarioEdehsa())
                {

                    var address = new in_Producto_Dimensiones();
                    //int idpv = GetSecuencia(info.IdEmpresa,);
                   // id = idpv;
                    address.IdEmpresa = info.IdEmpresa;
                    //address.Secuencia = GetSecuencia(info.IdEmpresa,1);

                    address.IdProducto = IdProducto;
                    address.longitud = info.longitud;
                    address.espesor = info.espesor;
                    address.ancho = info.ancho;
                    address.alto = info.alto;
                    address.ceja = info.ceja;
                    address.diametro = info.diametro;
                    address.estado = info.estado;


                    context.in_Producto_Dimensiones.Add(address);
                    context.SaveChanges();
                    mensaje = "Se ha procedido a grabar el registro de las Dimensiones del Producto"
                        //+ info.tp_descripcion 
                        + " exitosamente.";
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
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(mensaje);
            }
        }
        public in_Producto_Dimensiones_Info Get_Info_BuscarProducto_Dimensiones(decimal IdProducto, int IdEmpresa)
        {
            try
            {
                in_Producto_Dimensiones_Info prdDimension = new in_Producto_Dimensiones_Info();
                EntitiesInventarioEdehsa OEprdDimension = new EntitiesInventarioEdehsa();
                var selectCbtecble = from C in OEprdDimension.in_Producto_Dimensiones
                                     where C.IdEmpresa == IdEmpresa && C.IdProducto == IdProducto
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    prdDimension.IdEmpresa = item.IdEmpresa;
                    prdDimension.IdProducto = item.IdProducto;
                    prdDimension.longitud = item.longitud;
                    prdDimension.espesor = item.espesor;
                    prdDimension.ancho = item.ancho;
                    prdDimension.alto = item.alto;
                    prdDimension.ceja = item.ceja;
                    prdDimension.diametro = item.diametro;
                    prdDimension.estado = item.estado;

                }
                return (prdDimension);
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
        //public int GetSecuencia(int IdEmpresa, int IdProducto)
        //{
        //    try
        //    {
        //        decimal Secuencia;
        //        EntitiesInventarioEdehsa OEProDim = new EntitiesInventarioEdehsa();
        //        var select = (from q in OEProDim.in_Producto_Dimensiones
        //                      where q.IdEmpresa == IdEmpresa
        //                      select q.Secuencia).Max();

        //        if (select == null)
        //        {
        //            Secuencia = 1;
        //        }
        //        else
        //        {
        //            Secuencia = Convert.ToDecimal(select.ToString()) + 1;
        //        }
        //        return Secuencia;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        throw new Exception(ex.InnerException.ToString());
        //    }

        //}
        public Boolean ModificarDB(in_Producto_Dimensiones_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesInventarioEdehsa context = new EntitiesInventarioEdehsa())
                {
                    var contact = context.in_Producto_Dimensiones.FirstOrDefault(VProdu => VProdu.IdEmpresa == info.IdEmpresa && VProdu.IdProducto == info.IdProducto);
                    if (contact != null)
                    {


                        contact.IdProducto = info.IdProducto;
                        contact.longitud = info.longitud;

                        contact.espesor = info.espesor;
                        contact.ancho = info.ancho;
                        contact.alto = info.alto;
                        contact.ceja = info.ceja;
                        contact.diametro = info.diametro;
                        contact.estado = info.estado;
                        //contact.Fe = DateTime.Now;

                        context.SaveChanges();
                        mensaje = "Actualizacion ok...";
                    }
                }
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Error al Grabar" + ex.Message;
                throw new Exception(ex.ToString());
            }

        }
    }
}
