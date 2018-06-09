using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.SeguridadAcceso;

namespace Core.Erp.Data.SeguridadAcceso
{
    public class seg_Menu_x_Empresa_x_Usuario_data
    {
        public List<seg_Menu_x_Empresa_x_Usuario_info> Get_List_DescripcionMenu_x_Empresa_x_Usuario(int idEmpresa, string idUsuario, ref string MensajeError)
        {
            try
            {
                List<seg_Menu_x_Empresa_x_Usuario_info> returnValue = new List<seg_Menu_x_Empresa_x_Usuario_info>();
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                var select_menu_x_empresa_x_usuario = from c in entity.vw_Seg_Menu_x_Usuario_x_Empresa
                                                      where c.IdEmpresa == idEmpresa && c.IdUsuario == idUsuario
                                                      select c;
                foreach (var item in select_menu_x_empresa_x_usuario.ToList())
                {
                    seg_Menu_x_Empresa_x_Usuario_info info = new seg_Menu_x_Empresa_x_Usuario_info();
                    info.Checkeado = true;
                    info.DescripcionMenu = item.DescripcionMenu;
                    info.Eliminacion = item.Eliminacion;
                    info.Escritura = item.Escritura;
                    info.Existe = true;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdMenu = item.IdMenu;
                    info.IdMenuPadre = (int)item.IdMenuPadre;
                    info.IdUsuario = item.IdUsuario;
                    info.Lectura = item.Lectura;
                    info.SeModificoValor = false;
                    returnValue.Add(info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_x_Usuario_info>();
            }
        }




        public seg_Menu_x_Empresa_x_Usuario_info Get_Info_Menu_x_Empresa_x_Usuario(int idEmpresa, string idUsuario,string Name_Formunalrio, ref string MensajeError)
        {
            try
            {
                seg_Menu_x_Empresa_x_Usuario_info info = new seg_Menu_x_Empresa_x_Usuario_info();
                
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                var select_menu_x_empresa_x_usuario = from c in entity.vw_Seg_Menu_x_Usuario_x_Empresa
                                                      where c.IdEmpresa == idEmpresa 
                                                      && c.IdUsuario == idUsuario
                                                      && c.nom_Formulario == Name_Formunalrio
                                                      select c;
                foreach (var item in select_menu_x_empresa_x_usuario.ToList())
                {
                
                    info.Checkeado = true;
                    info.DescripcionMenu = item.DescripcionMenu;
                    info.Lectura = item.Lectura;
                    info.Escritura = item.Escritura;
                    info.Eliminacion = item.Eliminacion;
                    info.Existe = true;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdMenu = item.IdMenu;
                    info.IdMenuPadre = (int)item.IdMenuPadre;
                    info.IdUsuario = item.IdUsuario;
                    info.SeModificoValor = false;
                    
                }
                return info;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new seg_Menu_x_Empresa_x_Usuario_info();
            }
        }

        public List<seg_Menu_x_Empresa_x_Usuario_info> Get_No_List_DescripcionMenu_x_Empresa_x_Usuario(int idEmpresa, string idUsuario, ref string MensajeError)
        {
            try
            {
                List<seg_Menu_x_Empresa_x_Usuario_info> returnValue = new List<seg_Menu_x_Empresa_x_Usuario_info>();
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                seg_Menu_x_Empresa_data data = new seg_Menu_x_Empresa_data();
                MensajeError="";
                List<seg_Menu_x_Empresa_info> lMenu_x_empresa = data.Get_List_DescripcionMenu_x_Empresa(idEmpresa, ref MensajeError);
                if(!MensajeError.Equals(""))
                {
                    return new List<seg_Menu_x_Empresa_x_Usuario_info>();
                }
                var select_no_menu_x_empresa_x_usuario = from c in lMenu_x_empresa
                                                         where !(from filtro in entity.vw_Seg_Menu_x_Usuario_x_Empresa
                                                                 where filtro.IdEmpresa == idEmpresa && filtro.IdUsuario == idUsuario
                                                                 select filtro.IdMenu).Contains(c.IdMenu)
                                                         select c;
                foreach (var item in select_no_menu_x_empresa_x_usuario)
                {
                    seg_Menu_x_Empresa_x_Usuario_info info = new seg_Menu_x_Empresa_x_Usuario_info();
                    info.Checkeado = false;
                    info.DescripcionMenu = item.DescripcionMenu;
                    info.Eliminacion = false;
                    info.Escritura = false;
                    info.Existe = false;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdMenu = item.IdMenu;
                    info.IdMenuPadre = item.IdMenuPadre;
                    info.IdUsuario = idUsuario;
                    info.Lectura = false;
                    info.SeModificoValor = false;
                    returnValue.Add(info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_x_Usuario_info>();
            }
        }

        public bool GrabarDB(List<seg_Menu_x_Empresa_x_Usuario_info> listaMenu_x_Empresa_Modificada, ref string MensajeError)
        {
            try
            {
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                foreach (seg_Menu_x_Empresa_x_Usuario_info item in listaMenu_x_Empresa_Modificada)
                {
                    var Listaregistros = (from c in entity.seg_Menu_x_Empresa_x_Usuario
                                          where c.IdEmpresa == item.IdEmpresa
                                          && c.IdMenu == item.IdMenu
                                          && c.IdUsuario == item.IdUsuario
                                          select c);
                    seg_Menu_x_Empresa_x_Usuario registro = new seg_Menu_x_Empresa_x_Usuario();
                    if ((Listaregistros.Count() == 0) && (item.Checkeado))
                    {
                        registro.IdMenu = item.IdMenu;
                        registro.IdEmpresa = item.IdEmpresa;
                        registro.IdUsuario = item.IdUsuario;
                        registro.Lectura = item.Lectura;
                        registro.Escritura = item.Escritura;
                        registro.Eliminacion = item.Eliminacion;
                        entity.seg_Menu_x_Empresa_x_Usuario.Add(registro);
                    }
                    else if ((Listaregistros.Count() > 0) && (item.Checkeado))
                    {
                        registro = Listaregistros.First();
                        registro.Lectura = item.Lectura;
                        registro.Escritura = item.Escritura;
                        registro.Eliminacion = item.Eliminacion;
                    }
                    else if ((Listaregistros.Count() > 0) && (!item.Checkeado))
                    {
                        registro = Listaregistros.First();
                        entity.seg_Menu_x_Empresa_x_Usuario.Remove(registro);
                    }
                    else if ((Listaregistros.Count() == 0) && (!item.Checkeado))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

    }
}
