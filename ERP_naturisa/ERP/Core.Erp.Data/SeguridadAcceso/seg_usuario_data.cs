using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.SeguridadAcceso
{
    public class seg_usuario_data
    {            
        public List<seg_usuario_info> Get_List_Usuario(ref string MensajeError)
        {
            List<seg_usuario_info> lU = new List<seg_usuario_info>();
            try
            {                
                EntitiesSeguAcceso OEUser = new EntitiesSeguAcceso();
                var selectUsers = from C in OEUser.seg_usuario
                                  select C;

                foreach (var item in selectUsers)
                {
                    seg_usuario_info user_info = new seg_usuario_info();
                    user_info.IdUsuario = item.IdUsuario;
                    user_info.Contrasena = item.Contrasena;       
                    user_info.estado = item.estado;
                    user_info.Nombre = item.Nombre;
                    user_info.ExigirDirectivaContrasenia = item.ExigirDirectivaContrasenia;
                    user_info.CambiarContraseniaSgtSesion = item.CambiarContraseniaSgtSesion;
                    lU.Add(user_info);
                }
                return (lU);
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_usuario_info>();
            }
        }

        public List<seg_usuario_info> Get_List_Usuario_x_Empresa(int idEmpresa, ref string MensajeError)
        {
            List<seg_usuario_info> returnValue = new List<seg_usuario_info>();
            try
            {
                EntitiesSeguAcceso OEUser = new EntitiesSeguAcceso();
                var selectUsers = from C in OEUser.seg_usuario
                                  join E in OEUser.seg_Usuario_x_Empresa
                                  on C.IdUsuario equals E.IdUsuario
                                  where E.IdEmpresa==idEmpresa
                                  select C;
                foreach (var item in selectUsers)
                {
                    seg_usuario_info user_info = new seg_usuario_info();
                    user_info.IdUsuario = item.IdUsuario;
                    user_info.Contrasena = item.Contrasena;
                    user_info.estado = item.estado; 
                    user_info.Nombre = item.Nombre;
                    returnValue.Add(user_info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return returnValue;
            }
        }

        public seg_usuario_info Get_Info_Usuario(string IdUsuario, ref string MensajeError)
        {           
            try
            {
                seg_usuario_info user_info = new seg_usuario_info();
                EntitiesSeguAcceso OEUser = new EntitiesSeguAcceso();
                var selectUsers = from C in OEUser.seg_usuario
                                  where C.IdUsuario==IdUsuario
                                  select C;

                foreach (var item in selectUsers)
                {                   
                    user_info.IdUsuario = item.IdUsuario;
                    user_info.Contrasena = item.Contrasena;
                    user_info.estado = item.estado;
                    user_info.Nombre = item.Nombre;                  
                }
                return (user_info);
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new seg_usuario_info();
            }
        }

        public Boolean Get_Estado_Usuario(string IdUsuario, ref string MensajeError)
        {
            Boolean estado = false;
            try
            {
                EntitiesSeguAcceso OEUser = new EntitiesSeguAcceso();
                var selectUsers = from C in OEUser.seg_usuario
                                  where C.IdUsuario == IdUsuario
                                  select C;

                if (selectUsers.ToList().Count > 0)
                {
                    foreach (var item in selectUsers)
                    {
                        estado = (item.estado == "A") ? true : false;
                    }
                }
                return estado;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return estado;
            }

        }

        public Boolean Update_only_user(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    var contact = context.seg_usuario.FirstOrDefault(dinfo => dinfo.IdUsuario == info.IdUsuario);
                    if (contact != null)
                    {
                        contact.IdUsuario = info.IdUsuario;
                        contact.Contrasena = info.Contrasena;
                        contact.estado = info.estado;
                        contact.Nombre = info.Nombre;
                        contact.Fecha_UltMod = DateTime.Now;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean Update_usuario_referencias(seg_usuario_info user,List<tb_Empresa_Info> lEmpresa, ref string MensajeError)
        {
            try
            {
                using(EntitiesSeguAcceso entity = new EntitiesSeguAcceso())
                {
                    var contact = (from c in entity.seg_usuario where c.IdUsuario == user.IdUsuario select c).First();
                    contact.IdUsuario = user.IdUsuario;
                    contact.Contrasena = user.Contrasena;
                    contact.estado = user.estado;
                    contact.Nombre = user.Nombre;
                    contact.ExigirDirectivaContrasenia = user.ExigirDirectivaContrasenia;
                    contact.CambiarContraseniaSgtSesion = user.CambiarContraseniaSgtSesion;


                    //context.SaveChanges();


                    ////List<tb_Empresa_Info> anterior_lista_empresas_del_usuario = new tb_Empresa_Data().Get_List_Empresa_x_Usuario(user.IdUsuario);


                    
                    //foreach (tb_Empresa_Info anterior_empresa in anterior_lista_empresas_del_usuario)
                    //{
                    //    bool existe=false;
                    //    foreach (tb_Empresa_Info nueva_empresa in lEmpresa)
                    //        if (nueva_empresa.IdEmpresa == anterior_empresa.IdEmpresa)
                    //            existe = true;
                    //    if (!existe)
                    //    {
                    //        var empresa_x_usuario = (from c in entity.seg_Usuario_x_Empresa
                    //                                 where c.IdUsuario == user.IdUsuario
                    //                                 && c.IdEmpresa == anterior_empresa.IdEmpresa
                    //                                 select c).First();
                    //        entity.seg_Usuario_x_Empresa.Remove(empresa_x_usuario);
                    //        //entity.SaveChanges();
                    //    }
                    //}

                    //foreach (tb_Empresa_Info nueva_empresa in lEmpresa)
                    //{
                    //    bool existe = false;
                    //    foreach (tb_Empresa_Info anterior_empresa in anterior_lista_empresas_del_usuario)
                    //        if (anterior_empresa.IdEmpresa == nueva_empresa.IdEmpresa)
                    //            existe = true;
                    //    if (!existe)
                    //    {
                    //        seg_Usuario_x_Empresa objUser_x_empresa = new seg_Usuario_x_Empresa();
                    //        objUser_x_empresa.IdEmpresa = nueva_empresa.IdEmpresa;
                    //        objUser_x_empresa.IdUsuario = user.IdUsuario;
                    //        entity.seg_Usuario_x_Empresa.Add(objUser_x_empresa);
                    //        //entity.SaveChanges();
                    //    }
                    //}


                    entity.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean Existe_Usuario(string IdUsuario, ref string MensajeError)
        {
            try
            {
                EntitiesSeguAcceso EDB = new EntitiesSeguAcceso();
                var Q = from per in EDB.seg_usuario
                        where per.IdUsuario == IdUsuario
                        select per;
                int filasAfectadas = Q.ToList().Count;
                return (filasAfectadas > 0) ? true : false;

            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean GrabarDB(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    EntitiesSeguAcceso EDB = new EntitiesSeguAcceso();
                    var Q = from per in EDB.seg_usuario
                            where per.IdUsuario == info.IdUsuario
                            select per;
                    if (Q.ToList().Count == 0)
                    {
                        var address = new seg_usuario();
                        address.IdUsuario = info.IdUsuario;
                        address.Contrasena = info.Contrasena;                        
                        address.estado = info.estado;
                        address.Fecha_Transaccion = DateTime.Now;
                        address.IdUsuario = info.IdUsuario;

                        context.seg_usuario.Add(address);                        
                        context.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean GrabarUser_x_Empresa(seg_usuario_info info,List<int> idEmpresas, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso DBentidad = new EntitiesSeguAcceso())
                {
                    seg_usuario user = new seg_usuario 
                    { 
                        IdUsuario = info.IdUsuario,
                        Contrasena=info.Contrasena,
                        estado=info.estado,
                        Nombre=info.Nombre, 
                        CambiarContraseniaSgtSesion = info.CambiarContraseniaSgtSesion,
                        ExigirDirectivaContrasenia = info.ExigirDirectivaContrasenia
                    };
                    DBentidad.seg_usuario.Add(user);
                    foreach (int id in idEmpresas)
                    {
                        seg_Usuario_x_Empresa user_x_empresa = new seg_Usuario_x_Empresa
                        {
                            IdEmpresa = id,
                            IdUsuario=user.IdUsuario,
                            Observacion="",
                            seg_usuario = user
                        };
                        DBentidad.seg_Usuario_x_Empresa.Add(user_x_empresa);
                    }
                    DBentidad.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean EliminarDB(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    
                    var contact = (from c in context.seg_usuario where c.IdUsuario == info.IdUsuario select c).First();
                    contact.estado = "I";
                    contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    contact.Fecha_UltAnu = DateTime.Now;
                    contact.MotivoAnulacion = info.MotivoAnulacion;
                    context.SaveChanges();



                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean Anular(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso EAnular = new EntitiesSeguAcceso())
                {
                    var selectUser = (from C in EAnular.seg_usuario where C.IdUsuario == info.IdUsuario select C).FirstOrDefault();
                    if (selectUser != null)
                    {
                        selectUser.MotivoAnulacion = info.MotivoAnulacion;
                        selectUser.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        selectUser.Fecha_UltAnu = info.Fecha_UltAnu;
                        selectUser.estado = "I";
                        EAnular.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean Validar_Credenciales(seg_usuario_info oUser, ref string MensajeError)
        
        {
            try
            {

                EntitiesSeguAcceso OEseg = new EntitiesSeguAcceso();

                var Q_User = from User in OEseg.seg_usuario
                             where User.IdUsuario.Equals(oUser.IdUsuario)
                             && User.Contrasena.Equals(oUser.Contrasena)
                             && User.estado == "A"
                             select User;


                foreach (var item in Q_User)
                {
                    oUser.estado = item.estado;
                    oUser.CambiarContraseniaSgtSesion = item.CambiarContraseniaSgtSesion;
                    oUser.ExigirDirectivaContrasenia = item.ExigirDirectivaContrasenia;
                }

                var OUsera = Q_User.ToList();

                if (OUsera.Count == 0)
                {
                    return (false);
                }
                else
                {
                    return (true);
                }
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;                
            }
        }

        public Boolean Validar_Directiva_Contrasena(seg_usuario_info oUser, ref string MensajeError)
        {
            try
            {
                EntitiesSeguAcceso OEseg = new EntitiesSeguAcceso();
                var Q_User = from User in OEseg.seg_usuario
                             where User.IdUsuario.Equals(oUser.IdUsuario)
                             && User.estado == "A"
                             select User;
                foreach (var item in Q_User)
                {
                    oUser.estado = item.estado;
                    oUser.CambiarContraseniaSgtSesion = item.CambiarContraseniaSgtSesion;
                    oUser.ExigirDirectivaContrasenia = item.ExigirDirectivaContrasenia;
                }

                var OUsera = Q_User.ToList();

                if (OUsera.Count == 0)
                {
                    return (false);
                }
                else
                {
                    return (true);
                }
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }
        
        public Boolean Actualizar_Password(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    var contact = context.seg_usuario.FirstOrDefault(dinfo => dinfo.IdUsuario == info.IdUsuario);
                    if (contact != null)
                    {
                        contact.Contrasena = info.Contrasena;
                        contact.CambiarContraseniaSgtSesion = info.CambiarContraseniaSgtSesion;
                        contact.ExigirDirectivaContrasenia = info.ExigirDirectivaContrasenia;
                        contact.IdUsuarioUltModi = info.IdUsuarioUltModi;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }
        
        public Boolean Validar_IngresoUsuarioXEmpresa(string IdUsuario, int IdEmpresa, string clave, ref string MensajeError)
        {
            try
            {
                EntitiesSeguAcceso OEseg = new EntitiesSeguAcceso();
                var sel = from u in OEseg.seg_usuario
                          where u.IdUsuario == IdUsuario
                          select u;

                if (sel.ToList().Count == 0)
                {
                    MensajeError = "El Usuario " + IdUsuario + " No se encuentra ingresado en Base";
                    return false;
                }

                foreach (var item in sel)
                {
                    if (item.estado == "I")
                    {
                        MensajeError = "El Usuario " + IdUsuario + " está Inactivo";
                        return false;
                    }
                    if (item.Contrasena.Trim() != clave.Trim())
                    {
                        MensajeError = "La Contraseña del Usuario " + IdUsuario + " es Incorrecta";
                        return false;
                    }
                }

                var Q_User = from User in OEseg.seg_usuario
                             join pp in OEseg.seg_Usuario_x_Empresa on new { } equals new { }
                             where User.IdUsuario == IdUsuario && User.IdUsuario == pp.IdUsuario && User.estado == "A" && pp.IdEmpresa == IdEmpresa
                             select new
                             {
                                 User.IdUsuario
                             };

                if (Q_User.ToList().Count == 0)
                {
                    MensajeError = "Acceso Incorrecto";
                    return false;
                }
                else
                {
                    MensajeError = "Acceso Correcto";
                    return true;
                }
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }
    }
}
