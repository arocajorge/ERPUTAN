using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.SeguridadAcceso
{
    public class seg_Menu_data
    {

        public List<seg_Menu_info> Get_List_Menu(ref string MensajeError)
        {
            List<seg_Menu_info> returnValue = new List<seg_Menu_info>();
            try
            {
                EntitiesSeguAcceso OESeguridad = new EntitiesSeguAcceso();

                var selectMenu = from C in OESeguridad.seg_Menu
                                 orderby C.PosicionMenu
                                 select C;

                foreach (var item in selectMenu)
                {
                    seg_Menu_info oM = new seg_Menu_info();
                    oM.IdMenu = item.IdMenu;
                    oM.IdMenuPadre = (int)item.IdMenuPadre;
                    oM.DescripcionMenu = item.DescripcionMenu;
                    oM.PosicionMenu = item.PosicionMenu;
                    oM.Habilitado = item.Habilitado;
                    oM.Tiene_FormularioAsociado = item.Tiene_FormularioAsociado;
                    
                    oM.nom_Formulario = item.nom_Formulario;
                    oM.nom_Asembly = item.nom_Asembly;

                    oM.imagen_peque = item.imagen_peque;
                    oM.imagen_grande = item.imagen_grande;
                    oM.icono = item.icono;
                    oM.nivel = (item.nivel == null) ? 0 : Convert.ToInt32(item.nivel);
                    
                    returnValue.Add(oM);
                }

                return (returnValue);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public List<seg_Menu_info> Get_List_Menu_x_Empresa(int idEmpresa,ref string MensajeError)
        {
            List<seg_Menu_info> returnValue = new List<seg_Menu_info>();
            
            try
            {                
                EntitiesSeguAcceso OEselectMenuEmpresa = new EntitiesSeguAcceso();                
                var selectMenu_x_Empresa = from menu in OEselectMenuEmpresa.seg_Menu
                                           join filtro in OEselectMenuEmpresa.seg_Menu_x_Empresa
                                           on menu.IdMenu equals filtro.IdMenu
                                           where filtro.IdEmpresa == idEmpresa
                                           select menu;
                foreach (var item in selectMenu_x_Empresa)
                {
                    seg_Menu_info info = new seg_Menu_info();
                    
                    info.IdMenu = item.IdMenu;
                    info.IdMenuPadre = item.IdMenuPadre;
                    info.DescripcionMenu = item.DescripcionMenu;
                    info.PosicionMenu = item.PosicionMenu;
                    info.Habilitado = item.Habilitado;
                    info.Tiene_FormularioAsociado = item.Tiene_FormularioAsociado;
                    info.nom_Formulario = item.nom_Formulario;
                    info.nom_Asembly = item.nom_Asembly;
                    info.imagen_grande = item.imagen_grande;
                    info.imagen_peque = item.imagen_peque;
                    info.icono = item.icono;
                    info.nivel = item.nivel;

                    returnValue.Add(info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public List<seg_Menu_info> Get_List_Menu_x_Empresa_x_Usuario(string idUsuario, int idEmpresa, ref string MensajeError)
        {
            List<seg_Menu_info> returnValue = new List<seg_Menu_info>();
            try
            {                
                EntitiesSeguAcceso entidadMenu = new EntitiesSeguAcceso();
                var consulta = from m in entidadMenu.vw_Seg_Menu_x_Usuario_x_Empresa
                               where m.IdEmpresa == idEmpresa && m.IdUsuario == idUsuario
                               select m;
                
                foreach (var item in consulta)
                {
                    seg_Menu_info info = new seg_Menu_info();
                    info.IdMenu = item.IdMenu;
                    info.IdMenuPadre = item.IdMenuPadre;
                    info.DescripcionMenu = item.DescripcionMenu;
                    info.PosicionMenu = item.PosicionMenu;
                    info.Habilitado = item.Habilitado;
                    info.Tiene_FormularioAsociado = item.Tiene_FormularioAsociado;
                    info.nom_Formulario = item.nom_Formulario;
                    info.nom_Asembly = item.nom_Asembly;
                    info.imagen_grande = item.imagen_grande;
                    info.imagen_peque = item.imagen_peque;
                    info.icono = item.icono;
                    info.nivel = item.nivel;

                    returnValue.Add(info);
                }
                               
                return returnValue;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public seg_Menu_info Get_Info_Menu(int idmenu,ref string MensajeError)
        {
            seg_Menu_info info = new seg_Menu_info();
            try
            {
                EntitiesSeguAcceso OESeguridad = new EntitiesSeguAcceso();

                var selectMenu = from C in OESeguridad.seg_Menu
                                 orderby C.PosicionMenu
                                 where C.IdMenu == idmenu
                                 select C;

                foreach (var item in selectMenu)
                {
                    seg_Menu_info oM = new seg_Menu_info();
                    oM.IdMenu = item.IdMenu;
                    oM.DescripcionMenu = item.DescripcionMenu;
                    oM.Tiene_FormularioAsociado = item.Tiene_FormularioAsociado;
                    oM.Habilitado = item.Habilitado;
                    oM.IdMenuPadre = (int)item.IdMenuPadre;
                    oM.PosicionMenu = item.PosicionMenu;
                    
                    oM.nom_Formulario = item.nom_Formulario;
                    oM.nom_Asembly = item.nom_Asembly;

                    oM.imagen_peque = item.imagen_peque;
                    oM.imagen_grande = item.imagen_grande;
                    oM.icono = item.icono;
                    oM.nivel = (item.nivel == null) ? 0 : Convert.ToInt32(item.nivel);
                    
                    info = oM;
                }

                return info;
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }

        }
        
        #region Modificar

        public Boolean ModificarDB(seg_Menu_info info, ref string MensajeError)
        {
            try
            {
                int resultado = 0;
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    var contact = context.seg_Menu.FirstOrDefault(dinfo => dinfo.IdMenu == info.IdMenu);
                    if (contact != null)
                    {
                        contact.IdMenuPadre = info.IdMenuPadre;
                        contact.DescripcionMenu = info.DescripcionMenu;
                        contact.PosicionMenu = info.PosicionMenu;
                        contact.Habilitado = info.Habilitado;
                        contact.Tiene_FormularioAsociado = info.Tiene_FormularioAsociado;
                        info.nom_Asembly = (info.nom_Asembly == null) ? "" : info.nom_Asembly;
                        info.nom_Formulario = (info.nom_Formulario == null) ? "" : info.nom_Formulario;
                        contact.nom_Formulario = info.nom_Formulario;
                        contact.nom_Asembly = info.nom_Asembly;

                        contact.imagen_peque = info.imagen_peque;
                        contact.imagen_grande = info.imagen_grande;
                        contact.icono = info.icono;
                        contact.nivel = (info.nivel == null) ? 0 : Convert.ToInt32(info.nivel);

                        resultado = context.SaveChanges();
                    }
                    if (resultado > 0)
                    {
                        info.IdMenu = contact.IdMenu;
                        info.DescripcionMenu = contact.DescripcionMenu;
                        
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<seg_Menu_info> lista, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    foreach (var item in lista)
                    {
                        var contact = context.seg_Menu.FirstOrDefault(menu => menu.IdMenu == item.IdMenu);
                        if (contact != null)
                        {
                            contact.DescripcionMenu = item.DescripcionMenu;
                            contact.PosicionMenu = item.PosicionMenu;
                            contact.nom_Asembly = item.nom_Asembly;
                            contact.nom_Formulario = item.nom_Formulario;
                            contact.Habilitado = item.Habilitado;
                            contact.Tiene_FormularioAsociado = item.Tiene_FormularioAsociado;
                            contact.imagen_peque = item.imagen_peque;
                            contact.imagen_grande = item.imagen_grande;
                            contact.icono = item.icono;
                            contact.nivel = item.nivel;
                            context.SaveChanges();
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
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Anular(int idMenu, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    var contact = context.seg_Menu.FirstOrDefault(dinfo => dinfo.IdMenu == idMenu);
                    if (contact != null)
                    {
                        contact.Habilitado = false;

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
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        #endregion

        #region Id Maximo
        public int getIdMenu_Max(ref string MensajeError)
        {
            try
            {                
                int Idsecuencia;
                EntitiesSeguAcceso OEPermisos = new EntitiesSeguAcceso();
                var selectMax = (from C in OEPermisos.seg_Menu
                                 select C.IdMenu).Max();
                Idsecuencia = Convert.ToInt32(selectMax.ToString()) + 1;
                return Idsecuencia;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region Grabar
        public Boolean GrabarDB(seg_Menu_info info, ref string MensajeError)
        {            
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {                    
                    var address = new seg_Menu();
                    address.IdMenu = getIdMenu_Max(ref MensajeError);
                    address.IdMenuPadre = info.IdMenuPadre;
                    address.DescripcionMenu = info.DescripcionMenu;
                    address.PosicionMenu = info.PosicionMenu;
                    address.Habilitado = info.Habilitado;
                    address.Tiene_FormularioAsociado = info.Tiene_FormularioAsociado;
                    address.nom_Formulario = info.nom_Formulario;
                    address.nom_Asembly = info.nom_Asembly;                                        
                    address.imagen_peque = info.imagen_peque;
                    address.imagen_grande = info.imagen_grande;
                    address.icono = info.icono;
                    address.nivel = (info.nivel == null) ? 0 : Convert.ToInt32(info.nivel);                                        
                    context.seg_Menu.Add(address);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region Eliminar

        public Boolean EliminarDB(List<seg_Menu_info> Lista, ref string MensajeError)
        {
            try
            {
                foreach (var item in Lista)
                {
                    EliminarDB(item,ref MensajeError);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        public Boolean EliminarDB(seg_Menu_info info,ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {                                                            
                    var contact = context.seg_Menu.FirstOrDefault(dinfo => dinfo.IdMenu == info.IdMenu);
                    if (contact != null)
                    {
                        context.seg_Menu.Remove(contact);
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
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        public Boolean ExisteRelacionMenu(int idMenu, ref string MensajeError)
        {
            try
            {
                Boolean existe = false;
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    var menu_empresa = (from c in context.seg_Menu_x_Empresa
                                        where c.IdMenu == idMenu
                                        select c);
                    if (menu_empresa.Count() > 0)
                        existe = true;
                }
                return existe;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        #endregion

    }
}
