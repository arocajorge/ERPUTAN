using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Core.Erp.Info.SeguridadAcceso;

namespace Core.Erp.Data.SeguridadAcceso
{
    public class seg_Menu_x_Empresa_data
    {
        public List<seg_Menu_x_Empresa_info> Get_List_DescripcionMenu_x_Empresa(int idEmpresa, ref string MensajeError)
        {
            List<seg_Menu_x_Empresa_info> returnValue = new List<seg_Menu_x_Empresa_info>();

            try
            {
                EntitiesSeguAcceso OEselectMenuEmpresa = new EntitiesSeguAcceso();
                var selectMenu_x_Empresa = from menu in OEselectMenuEmpresa.seg_Menu
                                           join filtro in OEselectMenuEmpresa.seg_Menu_x_Empresa
                                           on menu.IdMenu equals filtro.IdMenu
                                           where filtro.IdEmpresa == idEmpresa
                                           select new { 
                                               filtro.IdEmpresa,
                                               menu.DescripcionMenu,
                                               filtro.IdMenu,
                                               menu.IdMenuPadre,
                                               filtro.NombreAsambly_x_Emp,
                                               filtro.NomFormulario_x_Emp
                                           };
                foreach (var item in selectMenu_x_Empresa)
                {
                    seg_Menu_x_Empresa_info info = new seg_Menu_x_Empresa_info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.DescripcionMenu = item.DescripcionMenu;
                    info.IdMenu = item.IdMenu;
                    info.IdMenuPadre = (int)item.IdMenuPadre;
                    info.NombreAsambly_x_Emp = item.NombreAsambly_x_Emp;
                    info.NomFormulario_x_Emp = item.NomFormulario_x_Emp;
                    info.Existe = true;
                    info.Checkeado = true;
                    returnValue.Add(info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_info>();
            }
        }

        public List<seg_Menu_x_Empresa_info> Get_No_List_DescripcionMenu_x_Empresa(int idEmpresa, ref string MensajeError)
        {
            List<seg_Menu_x_Empresa_info> returnValue = new List<seg_Menu_x_Empresa_info>();
            try
            {
                //EntitiesSeguAcceso OEselectMenuEmpresa = new EntitiesSeguAcceso();
                //var listaId = from ids in OEselectMenuEmpresa.seg_Menu_x_Empresa
                //              where ids.IdEmpresa == idEmpresa
                //              select ids.IdMenu;
                //var menu_sin_empresa = from menu in OEselectMenuEmpresa.seg_Menu
                //                       where menu.IdMenu ! in listaId
                //                           select new
                //                           {
                //                               menu.DescripcionMenu,
                //                               filtro.IdMenu,
                //                               menu.IdMenuPadre,
                //                               filtro.NombreAsambly_x_Emp,
                //                               filtro.NomFormulario_x_Emp
                //                           };
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                var selectMenu_sin_Empresa = from c in entity.seg_Menu
                            where !(from o in entity.seg_Menu_x_Empresa
                                    where o.IdEmpresa == idEmpresa
                                    select o.IdMenu).Contains(c.IdMenu)
                            select c;
                foreach (var item in selectMenu_sin_Empresa)
                {
                    seg_Menu_x_Empresa_info info = new seg_Menu_x_Empresa_info();
                    info.IdEmpresa = idEmpresa;
                    info.DescripcionMenu = item.DescripcionMenu;
                    info.IdMenu = item.IdMenu;
                    info.IdMenuPadre = (int)item.IdMenuPadre;
                    info.NombreAsambly_x_Emp = item.nom_Asembly;
                    info.NomFormulario_x_Emp = item.nom_Formulario;
                    returnValue.Add(info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_info>();
            }
        }

        public bool GrabarDB(List<seg_Menu_x_Empresa_info> listaMenu_x_Empresa_Modificada, ref string MensajeError)
        {
            try
            {
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                foreach (seg_Menu_x_Empresa_info item in listaMenu_x_Empresa_Modificada)
                {
                    var Listaregistros = (from c in entity.seg_Menu_x_Empresa
                                          where c.IdEmpresa == item.IdEmpresa
                                          && c.IdMenu == item.IdMenu
                                          select c);
                    seg_Menu_x_Empresa registro = new seg_Menu_x_Empresa();
                    if ((Listaregistros.Count() == 0) && (item.Checkeado))
                    {                        
                        registro.IdMenu = item.IdMenu;
                        registro.IdEmpresa = item.IdEmpresa;
                        registro.Habilitado = true;
                        registro.NombreAsambly_x_Emp = item.NombreAsambly_x_Emp;
                        registro.NomFormulario_x_Emp = item.NomFormulario_x_Emp;
                        entity.seg_Menu_x_Empresa.Add(registro);
                    }
                    else if ((Listaregistros.Count() > 0) && (item.Checkeado))
                    {
                        registro = Listaregistros.First();
                        registro.NombreAsambly_x_Emp = item.NombreAsambly_x_Emp;
                        registro.NomFormulario_x_Emp = item.NomFormulario_x_Emp;
                    }
                    else if ((Listaregistros.Count() > 0) && (!item.Checkeado))
                    {
                        registro=Listaregistros.First();
                        var registrosReferencia = from c in entity.seg_Menu_x_Empresa_x_Usuario
                                                  where c.IdEmpresa == registro.IdEmpresa
                                                  && c.IdMenu == registro.IdMenu
                                                  select c;
                        foreach (seg_Menu_x_Empresa_x_Usuario registro_a_eliminar in registrosReferencia)
                        {
                            entity.seg_Menu_x_Empresa_x_Usuario.Remove(registro_a_eliminar);
                        }
                        entity.seg_Menu_x_Empresa.Remove(registro);
                    }
                    else if ((Listaregistros.Count() == 0) && (!item.Checkeado))
                    {

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

        public bool ExisteRelacion(List<seg_Menu_x_Empresa_info> listaMenu_x_Empresa_x_Modificar, ref string MensajeError)
        {
            try
            {
                bool existe = false;
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                foreach (seg_Menu_x_Empresa_info item in listaMenu_x_Empresa_x_Modificar)
                {
                    var Listaregistros = (from c in entity.seg_Menu_x_Empresa
                                          where c.IdEmpresa == item.IdEmpresa
                                          && c.IdMenu == item.IdMenu
                                          select c);
                    seg_Menu_x_Empresa registro = new seg_Menu_x_Empresa();
                    if ((Listaregistros.Count() > 0) && (!item.Checkeado))
                    {
                        registro=Listaregistros.First();
                        var registrosReferencia = from c in entity.seg_Menu_x_Empresa_x_Usuario
                                                  where c.IdEmpresa == registro.IdEmpresa
                                                  && c.IdMenu == registro.IdMenu
                                                  select c;
                        if (registrosReferencia.Count() > 0)
                        {
                            existe = true;
                            break;
                        }
                    }
                }
                return existe;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return true;
            }
        }
    }
}
