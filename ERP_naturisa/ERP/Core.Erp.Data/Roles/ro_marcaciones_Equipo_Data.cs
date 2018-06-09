using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Roles
{
    public class ro_marcaciones_Equipo_Data
    {
        string mensaje = "";
        public List<ro_marcaciones_Equipo_Info> Get_List_marcaciones_Equipo(int IdEmpresa, int IdSucursal)
        {
            List<ro_marcaciones_Equipo_Info> Lista = new List<ro_marcaciones_Equipo_Info>();

            try
            {
                using (EntitiesRoles oEnti = new EntitiesRoles())
                {
                    var registros = from C in oEnti.ro_marcaciones_Equipo
                                    where  C.IdEmpresa==IdEmpresa 
                                    && C.IdSucursal==IdSucursal
                                        select C;
                    foreach (var tipo in registros)
                    {
                        ro_marcaciones_Equipo_Info info = new ro_marcaciones_Equipo_Info();

                        info.IdEmpresa = tipo.IdEmpresa;
                        info.IdEquipoMar = tipo.IdEquipoMar;
                        info.FormatoFecha = tipo.FormatoFecha;
                        info.Nombre_Equipo=tipo.Nombre_Equipo;
                        info.Modelo_Equipo=tipo.Modelo_Equipo;
                        info.Tabla_Vista=tipo.Tabla_Vista;
                        info.CadenaConexion=tipo.CadenaConexion;
                        info.FormatoFecha=tipo.FormatoFecha;
                        info.FormatoHora=tipo.FormatoHora;
                        info.Estado = tipo.Estado;
                        info.IdUsuario = tipo.IdUsuario;
                        info.FechaUltimaImportacionMarcaiones=tipo.FechaUltimaImportacionMarcaiones;
                       
                        Lista.Add(info);

                    }
                     return Lista;
                }
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(ro_marcaciones_Equipo_Info info)
        {
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    ro_marcaciones_Equipo address = new ro_marcaciones_Equipo();

                    address.IdEmpresa = info.IdEmpresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdEquipoMar = info.IdEquipoMar = getId();
                    address.Modelo_Equipo = info.Modelo_Equipo;
                    address.Nombre_Equipo = info.Nombre_Equipo;
                    address.TipoBd = info.TipoBd;
                    address.CadenaConexion = info.CadenaConexion;
                    address.Tabla_Vista = info.Tabla_Vista;
                    address.FormatoFecha = info.FormatoFecha;
                    address.FormatoHora = info.FormatoHora;
                    address.FechaUltimaImportacionMarcaiones = DateTime.Now;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.nom_pc = info.nom_pc;
                    address.Ip = info.Ip;
                    address.Estado = "A";
                    Context.ro_marcaciones_Equipo.Add(address); // hace lo mismo Context.ro_marcaciones_Equipo.Add(address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public ro_marcaciones_Equipo_Info Get_Info_marcaciones_Equipo(int id)
        {
            ro_marcaciones_Equipo_Info Info = new ro_marcaciones_Equipo_Info();
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contenido = context.ro_marcaciones_Equipo.First(var => var.IdEquipoMar == id);

                    Info.IdEquipoMar = contenido.IdEquipoMar;
                    Info.Nombre_Equipo = contenido.Nombre_Equipo;
                    Info.Modelo_Equipo = contenido.Modelo_Equipo;
                    Info.CadenaConexion = contenido.CadenaConexion;
                    Info.Tabla_Vista = contenido.Tabla_Vista;
                    Info.FormatoHora = contenido.FormatoHora;
                    Info.FormatoFecha = contenido.FormatoFecha;
                    Info.TipoBd = contenido.TipoBd;
                    Info.FechaUltimaImportacionMarcaiones = contenido.FechaUltimaImportacionMarcaiones;
                    Info.Estado = contenido.Estado;

                    return Info;
                }

            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(ro_marcaciones_Equipo_Info info)
        {
            try
            {
                EntitiesRoles context = new EntitiesRoles();

                var contenido = context.ro_marcaciones_Equipo.First(var => var.IdEquipoMar == info.IdEquipoMar);

                    contenido.Estado = "I";
                    contenido.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    contenido.Fecha_UltAnu = info.Fecha_UltAnu;

                    context.SaveChanges();
                    return true;
                
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
           
        }

        public Boolean ModificarDB(ro_marcaciones_Equipo_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var address = context.ro_marcaciones_Equipo.First(var => var.IdEquipoMar == info.IdEquipoMar);

                    address.Modelo_Equipo = info.Modelo_Equipo;
                    address.Nombre_Equipo = info.Nombre_Equipo;
                    address.TipoBd = info.TipoBd;
                    address.CadenaConexion = info.CadenaConexion;
                    address.Tabla_Vista = info.Tabla_Vista;
                    address.FormatoFecha = info.FormatoFecha;
                    address.FormatoHora = info.FormatoHora;
                    address.FechaUltimaImportacionMarcaiones = info.FechaUltimaImportacionMarcaiones;
                    address.IdUsuario = info.IdUsuario;
                    address.nom_pc = info.nom_pc;
                    address.Ip = info.Ip;
                    address.Estado = info.Estado;
                    address.IdUsuarioUltModi = info.IdUsuarioUltModi;
                    address.Fecha_UltMod = info.Fecha_UltMod;
                    context.SaveChanges();                    
                }

                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public int getId()
        {
            try
            {
                int Id;
                EntitiesRoles context = new EntitiesRoles();
                var select = from q in context.ro_marcaciones_Equipo
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in context.ro_marcaciones_Equipo
                                     select q.IdEquipoMar).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean ValidarIdMarcEqui(int id)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contenido = from q in context.ro_marcaciones_Equipo
                                    where q.IdEquipoMar == id
                                    select q;

                    if (contenido.ToList().Count() > 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean ActualizaUltimaFechaCorte(ro_marcaciones_Equipo_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var address = context.ro_marcaciones_Equipo.First(var => var.IdEquipoMar == info.IdEquipoMar);
                    address.FechaUltimaImportacionMarcaiones = info.FechaUltimaImportacionMarcaiones;
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }


    }
}

