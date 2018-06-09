using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Inventario
{
    public class in_Catalogo_Data
    {
        string mensaje = "";

        public List<in_Catalogo_Info> Get_List_Catalogo(int IdTIpoCatalogo) 
        {
            List<in_Catalogo_Info> lista = new List<in_Catalogo_Info>();
            EntitiesInventario oEnt = new EntitiesInventario();
            try
            {
                var select = from q in oEnt.in_Catalogo
                             where q.IdCatalogo_tipo == IdTIpoCatalogo
                             select q;

                foreach (var item in select)
                {
                    in_Catalogo_Info info = new in_Catalogo_Info();


                    info.IdCatalogo = item.IdCatalogo.Trim();
                    info.IdCatalogo_tipo = item.IdCatalogo_tipo;
                    info.Nombre = item.Nombre.Trim();
                    info.NombreIngles = item.NombreIngles;
                    info.Orden = item.Orden;
                    info.Estado = item.Estado;
                    info.Abrebiatura = item.Abrebiatura;
                    lista.Add(info);
                }


                return lista;
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

        public Boolean EliminarDB(in_Catalogo_Info info)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Catalogo.FirstOrDefault(catalogo => catalogo.IdCatalogo == info.IdCatalogo && catalogo.IdCatalogo_tipo == info.IdCatalogo_tipo);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(in_Catalogo_Info info, ref string Mensaje)
        {
            try
            {
                using (EntitiesInventario oEnti = new EntitiesInventario())
                {

                    var Q = (from per in oEnti.in_Catalogo
                             select per.Orden).Max() + 1;


                    if ((from per in oEnti.in_Catalogo where per.IdCatalogo == info.IdCatalogo select per).Count() != 0)
                    {
                        Mensaje = "El Codigo Ingresado Ya existe por favor ingrese uno distinto";
                        return false;
                    }


                    var registo = new in_Catalogo();

                    registo.IdCatalogo = info.IdCatalogo;
                    registo.IdCatalogo_tipo = info.IdCatalogo_tipo;
                    registo.Nombre = info.Nombre;
                    registo.NombreIngles = info.NombreIngles;
                    registo.Abrebiatura = info.Abrebiatura;
                    registo.Orden = Q;
                    registo.Estado = "A";

                    oEnti.in_Catalogo.Add(registo);
                    oEnti.SaveChanges();
                    Mensaje = "Registro Ingresado Correctamente";
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
                mensaje = ex.ToString() + " " + ex.Message;
                Mensaje = "Error al ingresar el registro ";
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(in_Catalogo_Info info)
        {
            try
            {
                using (EntitiesInventario oEnti = new EntitiesInventario())
                {
                    var registro = oEnti.in_Catalogo.FirstOrDefault(cata => cata.IdCatalogo == info.IdCatalogo && cata.IdCatalogo_tipo == info.IdCatalogo_tipo);
                    if (registro != null)
                    {
                        registro.Nombre = info.Nombre;
                        registro.NombreIngles = info.NombreIngles;
                        registro.Abrebiatura = info.Abrebiatura;
                        registro.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        registro.FechaUltMod = info.FechaUltMod;
                        oEnti.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Catalogo_Info> Get_List_Catalogo()
        {
            List<in_Catalogo_Info> lista = new List<in_Catalogo_Info>();
            EntitiesInventario oEnt = new EntitiesInventario();
            try
            {
                var select = from q in oEnt.in_Catalogo
                             select q;

                foreach (var item in select)
                {
                    in_Catalogo_Info info = new in_Catalogo_Info();

                    info.IdCatalogo = item.IdCatalogo.Trim();
                    info.IdCatalogo_tipo = item.IdCatalogo_tipo;
                    info.Nombre = item.Nombre.Trim();
                    info.NombreIngles = item.NombreIngles;
                    info.Orden = item.Orden;
                    info.Estado = item.Estado;
                    info.Abrebiatura = item.Abrebiatura;
                    lista.Add(info);
                }
                return lista;
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
    }
}
