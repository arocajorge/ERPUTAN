using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Compras
{
    public class com_Catalogo_Data
    {
        string mensaje = "";

        public List<com_Catalogo_Info> Get_List_MotivoRequerimiento()
        {
                
            try
            {
                List<com_Catalogo_Info> Lst = new List<com_Catalogo_Info>();
                EntitiesCompras oEnti = new EntitiesCompras();

                var Query = from q in oEnti.vwcom_MotivoRequerimiento
                            select q;
                foreach (var item in Query)
                {
                    com_Catalogo_Info Obj = new com_Catalogo_Info();
                    Obj.IdTipoCatalogo = item.IdTipoCatalogo;
                    Obj.CodCatalogo = item.Codigo;
                    Obj.IdCatalogocompra = item.Id;
                    Obj.descripcion = item.descripcion;
                    Obj.estado = item.Estado;
                    Obj.orden = (item.Orden == null)?0:(Int32)item.Orden;
                    Obj.name = (item.name == null) ? "" : item.name;
                    Obj.Nombre = item.descripcion;

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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
   
        public com_Catalogo_Info Get_Info_EstadoAprobacion(string IdEAprob)
        {
            try
            {
                com_Catalogo_Info info = new com_Catalogo_Info();
                EntitiesCompras oEnti = new EntitiesCompras();
                var select = from q in oEnti.vwcom_EstadoAprobacion
                             where q.Codigo == IdEAprob
                             select q;

                foreach (var item in select)
                {
                    
                    info.IdTipoCatalogo = item.IdTipoCatalogo;
                    info.CodCatalogo = item.Codigo;
                    info.IdCatalogocompra = item.Id;
                    info.descripcion = item.descripcion;
                    info.estado = item.Estado;
                    info.orden = (item.Orden == null) ? 0 : (Int32)item.Orden;

                    info.name = (item.name == null) ? "" : item.name;
                    info.Nombre = item.descripcion;
                    
                }
                return info;
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
        
        public List<com_Catalogo_Info> Get_ListEstadoAnulacion()
        {
                List<com_Catalogo_Info> Lst = new List<com_Catalogo_Info>();
                EntitiesCompras oEnti = new EntitiesCompras();
            try
            {
                var Query = from q in oEnti.vwcom_EstadoAnulacion
                            select q;
                foreach (var item in Query)
                {
                    com_Catalogo_Info Obj = new com_Catalogo_Info();
                    Obj.IdTipoCatalogo = item.IdTipoCatalogo;
                    Obj.CodCatalogo = item.Codigo;
                    Obj.IdCatalogocompra = item.Id;
                    Obj.descripcion = item.descripcion;
                    Obj.estado = item.Estado;
                    Obj.orden = (item.Orden == null) ? 0 : (Int32)item.Orden;
                    Obj.name = (item.name == null) ? "" : item.name;
                    Obj.Nombre = item.descripcion;


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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public List<com_Catalogo_Info> Get_ListEstadoAprobacion()
        {
            List<com_Catalogo_Info> Lst = new List<com_Catalogo_Info>();
            EntitiesCompras oEnti = new EntitiesCompras();
            try
            {
                var Query = from q in oEnti.vwcom_EstadoAprobacion
                            select q;
                foreach (var item in Query)
                {
                    com_Catalogo_Info Obj = new com_Catalogo_Info();
                    Obj.IdTipoCatalogo = item.IdTipoCatalogo;
                    Obj.CodCatalogo = item.Codigo;
                    Obj.IdCatalogocompra = item.Id;
                    Obj.descripcion = item.descripcion;
                    Obj.estado = item.Estado;
                    Obj.orden = (item.Orden == null) ? 0 : (Int32)item.Orden;

                    Obj.name = (item.name == null) ? "" : item.name;
                    Obj.Nombre = item.descripcion;

                    Obj.IdEstadoAprobacion = item.Id;

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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public List<com_Catalogo_Info> Get_ListEstadoRecepcion()
        {
            List<com_Catalogo_Info> Lst = new List<com_Catalogo_Info>();
            EntitiesCompras oEnti = new EntitiesCompras();
            try
            {
                var Query = from q in oEnti.vwcom_EstadoRecibido
                            select q;
                foreach (var item in Query)
                {
                    com_Catalogo_Info Obj = new com_Catalogo_Info();
                    Obj.IdTipoCatalogo = item.IdTipoCatalogo;
                    Obj.CodCatalogo = item.Codigo;
                    Obj.IdCatalogocompra = item.Id;
                    Obj.descripcion = item.descripcion;
                    Obj.estado = item.Estado;
                    Obj.orden = (item.Orden == null) ? 0 : (Int32)item.Orden;
                    Obj.name = (item.name == null) ? "" : item.name;
                    Obj.Nombre = item.descripcion;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public List<com_Catalogo_Info> Get_ListEstadoAprobacion_solicitud_compra()
        {
            List<com_Catalogo_Info> Lst = new List<com_Catalogo_Info>();
            EntitiesCompras oEnti = new EntitiesCompras();
            try
            {

                var Query = from q in oEnti.vwcom_EstadoAprobacion_sol_compra
                            select q;
                foreach (var item in Query)
                {
                    com_Catalogo_Info Obj = new com_Catalogo_Info();
                    Obj.IdTipoCatalogo = item.IdTipoCatalogo;
                    Obj.CodCatalogo = item.Codigo;
                    Obj.IdCatalogocompra = item.Id;
                    Obj.descripcion = item.descripcion;
                    Obj.estado = item.Estado;
                    Obj.orden = (item.Orden == null) ? 0 : (Int32)item.Orden;
                    Obj.name = (item.name == null) ? "" : item.name;
                    Obj.Nombre = item.descripcion;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                EntitiesCompras context = new EntitiesCompras();

                var Existe = from q in context.com_catalogo
                             where q.CodCatalogo == Cod
                             select q;
                if (Existe.ToList().Count() > 0)
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        

        public List<com_Catalogo_Info> Get_List_Catalogo()
        {
            try
            {
                List<com_Catalogo_Info> lista = new List<com_Catalogo_Info>();

                EntitiesCompras oEnt = new EntitiesCompras();



                var select = from q in oEnt.com_catalogo
                             select q;

                foreach (var item in select)
                {
                    com_Catalogo_Info info = new com_Catalogo_Info();


                    info.IdCatalogocompra = item.IdCatalogocompra;
                    info.Nombre = item.Nombre;
                    info.Abrebiatura = item.Abrebiatura;
                    info.CodCatalogo = item.CodCatalogo;
                    info.name = item.NombreIngles;
                    info.orden = item.Orden;
                    info.estado = item.Estado;

                    lista.Add(info);
                }
                return lista;
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

        public List<com_Catalogo_Info> Get_list_IdTipoLista(string cod)
        {
            try
            {
                List<com_Catalogo_Info> lista = new List<com_Catalogo_Info>();

                EntitiesCompras context = new EntitiesCompras();
                var Existe = from q in context.com_catalogo
                             where q.IdCatalogocompra_tipo == cod
                             select q;

                foreach (var item in Existe)
                {
                    com_Catalogo_Info info = new com_Catalogo_Info();

                    info.IdCatalogocompra = item.IdCatalogocompra;
                    info.IdCatalogocompra_tipo = item.IdCatalogocompra_tipo;
                    info.Nombre = item.Nombre;
                    info.orden = item.Orden;
                    info.Abrebiatura = item.Abrebiatura;
                    info.estado = item.Estado;
                    lista.Add(info);
                }
                return lista;

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

        public string GetId()
        {
            try
            {
                string Id = "";
                EntitiesCompras context = new EntitiesCompras();
                var select = from q in context.vwcom_Catalogo_IdAuto_numeric
                             select q;
                foreach (var item in select)
                {
                    Id = (string)item.IdCatalogocompra;
                }

                return Id;
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

        public Boolean GuardarDB(com_Catalogo_Info Info)
        {
            try
            {
                using (EntitiesCompras Context = new EntitiesCompras())
                {
                    var Address = new com_catalogo();
                    Address.IdCatalogocompra = Info.IdCatalogocompra;

                    Address.IdCatalogocompra_tipo = Info.IdCatalogocompra_tipo;
                    Address.Nombre = Info.Nombre;
                    Address.Estado = "A";
                    Address.Orden = Info.orden;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Context.com_catalogo.Add(Address);
                    Context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(com_Catalogo_Info info)
        {
            try
            {
                EntitiesCompras context = new EntitiesCompras();
                var contenido = context.com_catalogo.FirstOrDefault(var => var.IdCatalogocompra == info.IdCatalogocompra);
                if (contenido != null)
                {
                    contenido.Nombre = info.Nombre;
                    contenido.Orden = info.orden;
                    contenido.Estado = info.estado;
                    contenido.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    contenido.FechaUltMod = info.FechaUltMod;
                    context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }

        }

        public Boolean AnularDB(com_Catalogo_Info Info)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {

                    var contact = context.com_catalogo.FirstOrDefault(var => var.IdCatalogocompra == Info.IdCatalogocompra && var.IdCatalogocompra_tipo == Info.IdCatalogocompra_tipo);

                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.FechaHoraAnul;
                        contact.MotiAnula = Info.MotivoAnulacion;
                        context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarIdTipoCatalogo_Descripcion(string IdCatalogocompra_tipo, string Descripcion)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {

                    var Existe = from q in context.com_catalogo
                                 where q.Nombre == Descripcion && q.IdCatalogocompra_tipo == IdCatalogocompra_tipo
                                 select q;
                    if (Existe.ToList().Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

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
    }
}
