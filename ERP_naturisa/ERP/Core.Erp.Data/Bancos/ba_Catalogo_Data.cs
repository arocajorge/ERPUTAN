using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_Catalogo_Data
    {
        string mensaje = "";
        public List<ba_Catalogo_Info> Get_List_PeriocidadPago()
        {


                List<ba_Catalogo_Info> listado = new List<ba_Catalogo_Info>();
                        try
                        {
                            EntitiesBanco oent = new EntitiesBanco();
                            string query = "Select * from vwba_PeriocidadPago";
                            listado = oent.Database.SqlQuery<ba_Catalogo_Info>(query).ToList();
                        }
                        catch (Exception ex)
                        {
                            string arreglo = ToString();
                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                                "", "", "", "", DateTime.Now);
                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                            mensaje = ex.InnerException + " " + ex.Message;
                            throw new Exception(ex.InnerException.ToString());
                        }
                  return listado;

        }

        public List<ba_Catalogo_Info> Get_List_MetodoCalculo()
        {
          
                 List<ba_Catalogo_Info> listado = new List<ba_Catalogo_Info>();
                    try
                    {
                        EntitiesBanco oent = new EntitiesBanco();
                        string query = "Select * from vwba_MetodoCalculo";
                        listado = oent.Database.SqlQuery<ba_Catalogo_Info>(query).ToList();
                        return listado;
                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                            "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                        mensaje = ex.InnerException + " " + ex.Message;
                        throw new Exception(ex.InnerException.ToString());
                    }            
        }

        public List<ba_Catalogo_Info> Get_List_MotivoPrestamo()
        {
           
                 List<ba_Catalogo_Info> listado = new List<ba_Catalogo_Info>();
                    try
                    {
                        EntitiesBanco oent = new EntitiesBanco();
                        string query = "Select * from vwba_MotivoPrestamo";
                        listado = oent.Database.SqlQuery<ba_Catalogo_Info>(query).ToList();
                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                            "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                        mensaje = ex.InnerException + " " + ex.Message;
                        listado = new List<ba_Catalogo_Info>();
                    }
                    return listado;
        }


       public List<ba_Catalogo_Info> Get_List_Estado_Cbte_ban()
        {
            List<ba_Catalogo_Info> listado = new List<ba_Catalogo_Info>();
            try
            {
                EntitiesBanco oent = new EntitiesBanco();
                string query = "Select * from vwba_Estado_cbte_ban";
                listado = oent.Database.SqlQuery<ba_Catalogo_Info>(query).ToList();
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ba_Catalogo_Info> Get_List_EstadoPago()
        {
            List<ba_Catalogo_Info> listado = new List<ba_Catalogo_Info>();
            try
            {
                EntitiesBanco oent = new EntitiesBanco();
                string query = "Select * from vwba_EstadoPago";
                listado = oent.Database.SqlQuery<ba_Catalogo_Info>(query).ToList();
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public string GetId()
        {
            try
            {
                string Id = "";
                EntitiesBanco context = new EntitiesBanco();
                var select = from q in context.vwba_Catalogo_IdAuto_numeric
                             select q;
                foreach (var item in select)
                {
                    Id = (item.IdCatalogo == null) ? "" : Convert.ToString(item.IdCatalogo);
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
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public List<ba_Catalogo_Info> Get_List_Catalogo()
        {
                List<ba_Catalogo_Info> lista = new List<ba_Catalogo_Info>();
                EntitiesBanco oEnt = new EntitiesBanco();
            try
            {
                var select = from q in oEnt.ba_Catalogo
                             select q;

                foreach (var item in select)
                {
                    ba_Catalogo_Info info = new ba_Catalogo_Info();
                    info.IdCatalogo = item.IdCatalogo;
                    info.ca_descripcion = item.ca_descripcion;

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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ba_Catalogo_Info Get_Info_Catalogo(string id)
        {
                EntitiesBanco context = new EntitiesBanco();
                ba_Catalogo_Info ba_cata_Info = new ba_Catalogo_Info();
            try
            {
                var contenido = context.ba_Catalogo.FirstOrDefault(var => var.IdCatalogo == id);
                if (contenido != null)
                {
                    ba_cata_Info.IdCatalogo = contenido.IdCatalogo;
                    ba_cata_Info.IdTipoCatalogo = contenido.IdTipoCatalogo;
                    ba_cata_Info.ca_descripcion = contenido.ca_descripcion;
                    ba_cata_Info.ca_estado = contenido.ca_estado;
                    ba_cata_Info.ca_orden = contenido.ca_orden;
                }
                return ba_cata_Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                EntitiesBanco context = new EntitiesBanco();

                var Existe = from q in context.ba_Catalogo
                             where q.IdCatalogo == Cod
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
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean GuardarDB(ref ba_Catalogo_Info Info)
        {
            try
            {
                using (EntitiesBanco Context = new EntitiesBanco())
                {
                    var Address = new ba_Catalogo();
                    Address.IdCatalogo = Info.IdCatalogo;
                    Address.IdTipoCatalogo = Info.IdTipoCatalogo;
                    Address.ca_descripcion = Info.ca_descripcion;
                    Address.ca_estado = "A";
                    Address.ca_orden = Info.ca_orden;
                    Context.ba_Catalogo.Add(Address);
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
                return false; 
            }
        }

        public List<ba_Catalogo_Info> Get_List_Catalogo(string cod)
        {
                List<ba_Catalogo_Info> lista = new List<ba_Catalogo_Info>();
                EntitiesBanco context = new EntitiesBanco();
            try
            {
                var Existe = from q in context.ba_Catalogo
                             where q.IdTipoCatalogo == cod
                             select q;

                foreach (var item in Existe)
                {
                    ba_Catalogo_Info info = new ba_Catalogo_Info();

                    info.IdCatalogo = item.IdCatalogo;
                    info.IdTipoCatalogo = item.IdTipoCatalogo;
                    info.ca_descripcion = item.ca_descripcion;
                    info.ca_orden = item.ca_orden;
                    info.ca_estado = item.ca_estado;
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
                return new List<ba_Catalogo_Info>();
            }
        }

        public bool ModificarDB(ba_Catalogo_Info info)
        {
            try
            {
                EntitiesBanco context = new EntitiesBanco();
                var contenido = context.ba_Catalogo.FirstOrDefault(var => var.IdCatalogo == info.IdCatalogo);
                if (contenido != null)
                {
                    contenido.ca_descripcion = info.ca_descripcion;
                    contenido.ca_orden = info.ca_orden;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
       }

        public Boolean AnularDB(ba_Catalogo_Info Info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Catalogo.FirstOrDefault(var => var.IdCatalogo == Info.IdCatalogo && var.IdTipoCatalogo == Info.IdTipoCatalogo);
                    if (contact != null)
                    {
                        contact.ca_estado = "I";
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarIdTipoCatalogo_Descripcion(string idTipoCatalogo, string ca_descripcion)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var Existe = from q in context.ba_Catalogo
                                 where q.ca_descripcion==ca_descripcion && q.IdTipoCatalogo == idTipoCatalogo 
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
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
