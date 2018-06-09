using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Inventario
{
    public  class in_grupo_data
    {
        string mensaje = "";

        public int GetIdgrupo(int idempresa, string idcategoria,int idlinea)
        {
            try
            {
                int IdGrupo = 0;
                EntitiesInventario OEGrupo = new EntitiesInventario();

                var selecte = OEGrupo.in_grupo.Count(q => q.IdEmpresa == idempresa && q.IdCategoria == idcategoria && q.IdLinea == idlinea);

                if (selecte == 0)
                {
                    IdGrupo = 1;
                }
                else
                {
                    OEGrupo = new EntitiesInventario();
                    var selectGrupo = (from grupo in OEGrupo.in_grupo
                                       where grupo.IdEmpresa == idempresa
                                          && grupo.IdCategoria == idcategoria
                                          && grupo.IdLinea == idlinea
                                       select grupo.IdGrupo).Max();
                    IdGrupo = Convert.ToInt32(selectGrupo.ToString()) + 1;
                }
                return IdGrupo;
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

        public Boolean GrabarDB(in_grupo_info info, ref int IdGrupo, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {

                    var lst = from q in context.in_grupo
                              where q.IdEmpresa == info.IdEmpresa
                              && q.IdCategoria == info.IdCategoria
                              && q.IdLinea == info.IdLinea
                              && q.IdGrupo == info.IdGrupo
                              select q;

                    if (lst.Count()==0)
                    {
                        in_grupo objGrupo = new in_grupo();

                        objGrupo.IdEmpresa = info.IdEmpresa;
                        objGrupo.IdCategoria = info.IdCategoria;
                        objGrupo.IdLinea = info.IdLinea;

                        objGrupo.IdGrupo = IdGrupo = (info.IdGrupo == null || info.IdGrupo == 0) ? GetIdgrupo(info.IdEmpresa, info.IdCategoria, info.IdLinea) : info.IdGrupo;

                        if (info.cod_grupo == null || info.cod_grupo == "")
                        {
                            info.cod_grupo = objGrupo.IdGrupo.ToString();
                        }

                        objGrupo.cod_grupo = info.cod_grupo.Trim();
                        objGrupo.nom_grupo = info.nom_grupo.Trim();

                        if (info.abreviatura == null || info.abreviatura == "")
                        {
                            info.abreviatura = info.cod_grupo.Trim();
                        }

                        objGrupo.abreviatura = info.abreviatura;
                        objGrupo.Estado = "A";

                        if (info.observacion == "" || info.observacion == null)
                        {
                            info.observacion = "";
                        }

                        objGrupo.observacion = info.observacion;
                        objGrupo.IdUsuario = (info.IdUsuario == null) ? "" : info.IdUsuario;
                        objGrupo.Fecha_Transac = DateTime.Now;
                        objGrupo.nom_pc = info.nom_pc;
                        objGrupo.ip = info.ip;

                        context.in_grupo.Add(objGrupo);
                        context.SaveChanges();    
                    }
                    msg = "Grabación ok..";
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

        public Boolean ModificarDB(in_grupo_info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_grupo.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdLinea == info.IdLinea && var.IdGrupo==info.IdGrupo && var.IdCategoria==info.IdCategoria);
                    if (contact != null)
                    {
                        contact.cod_grupo = info.cod_grupo;
                        contact.nom_grupo = info.nom_grupo;
                        contact.abreviatura = info.abreviatura;
                        contact.observacion = info.observacion;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        context.SaveChanges();
                        msg = "Grabación ok..";
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

        public Boolean AnularDB(in_grupo_info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_grupo.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdLinea == info.IdLinea && var.IdGrupo == info.IdGrupo && var.IdCategoria == info.IdCategoria);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.MotiAnula = info.MotiAnula;
                        context.SaveChanges();
                        msg = "Anulación ok..";
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
               
        public List<in_grupo_info> Get_List_Grupo(int IdEmpresa,string IdCategoria,int IdLinea)
        {
            try
            {
                List<in_grupo_info> lM = new List<in_grupo_info>();

                EntitiesInventario OEUser = new EntitiesInventario();

                var select_ = from TI in OEUser.in_grupo
                             where TI.IdEmpresa == IdEmpresa
                              && TI.IdCategoria == IdCategoria
                              && TI.IdLinea == IdLinea
                              select TI;

                foreach (var item in select_)
                {
                    in_grupo_info dat_ = new in_grupo_info();
                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdCategoria = item.IdCategoria;
                    dat_.IdLinea = item.IdLinea;
                    dat_.IdGrupo = item.IdGrupo;
                    dat_.nom_grupo = item.nom_grupo;
                    dat_.observacion = item.observacion;
                    dat_.cod_grupo = item.cod_grupo;
                    dat_.abreviatura = item.abreviatura;
                    dat_.Estado = item.Estado;
                    
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

        public List<in_grupo_info> Get_List_Grupo(int IdEmpresa)
        {
            try
            {
                List<in_grupo_info> lM = new List<in_grupo_info>();

                EntitiesInventario OEUser = new EntitiesInventario();

                var select_ = from TI in OEUser.in_grupo
                              where TI.IdEmpresa == IdEmpresa
                              
                              select TI;

                foreach (var item in select_)
                {
                    in_grupo_info dat_ = new in_grupo_info();
                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdCategoria = item.IdCategoria;
                    dat_.IdLinea = item.IdLinea;
                    dat_.IdGrupo = item.IdGrupo;
                    dat_.nom_grupo = item.nom_grupo;
                    dat_.observacion = item.observacion;
                    dat_.cod_grupo = item.cod_grupo;
                    dat_.abreviatura = item.abreviatura;
                    dat_.Estado = item.Estado;

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

        public int Get_IdGrupo(int IdEmpresa, string IdCategoria, int IdLinea, string Nom_Linea)
        {
            EntitiesInventario oEnti = new EntitiesInventario();
            try
            {
                int IdGrupo = 0;

                var Objeto = oEnti.in_grupo.FirstOrDefault(var => var.IdEmpresa == IdEmpresa && var.IdCategoria == IdCategoria && var.IdLinea == IdLinea && var.nom_grupo == Nom_Linea);
                if (Objeto != null)
                {
                    IdGrupo = Objeto.IdGrupo;
                }
                return IdGrupo;
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
