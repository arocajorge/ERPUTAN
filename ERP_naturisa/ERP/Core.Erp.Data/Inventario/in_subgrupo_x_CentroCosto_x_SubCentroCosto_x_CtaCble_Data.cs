using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Inventario
{
   public class in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Data
    {
       string mensaje = "";

       public List<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info> Get_List_Info_in_subgrupo(int IdEmpresa)
       {
           try
           {
               try
               {
                   List<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info> Listdat_ = new List<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info>();

                   EntitiesInventario OEUser = new EntitiesInventario();

                   var select_ = from TI in OEUser.vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble
                                 where TI.IdEmpresa == IdEmpresa
                                 select TI;

                   foreach (var item in select_)
                   {
                       in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info dat_ = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info();
                       dat_.IdEmpresa = item.IdEmpresa;
                       dat_.IdCategoria = item.IdCategoria;
                       dat_.nom_categoria = "[" + item.IdCategoria + "] " + item.nom_categoria;
                       dat_.IdLinea = item.IdLinea;
                       dat_.nom_linea = "[" + item.IdLinea.ToString() + "] " + item.nom_linea;
                       dat_.IdGrupo = item.IdGrupo;
                       dat_.nom_grupo = "[" + item.IdGrupo.ToString() + "] " + item.nom_grupo;
                       dat_.IdSubgrupo = item.IdSubgrupo;
                       dat_.nom_subgrupo = "[" + item.IdSubgrupo.ToString() + "] " + item.nom_subgrupo;

                       dat_.IdCentroCosto = item.IdCentroCosto;
                       dat_.nom_centro_costo = "[" + item.IdCentroCosto + "] " + item.nom_centro_costo;
                       dat_.IdSub_centro_costo = item.IdSub_centro_costo;
                       dat_.nom_sub_centro_costo = "[" + item.IdSub_centro_costo + "] " + item.nom_sub_centro_costo;

                       dat_.IdCtaCble = item.IdCtaCble;

                       Listdat_.Add(dat_);
                   }


                   return Listdat_;

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
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public List<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info> Get_List_Info_in_subgrupo_no_parametrizados(int IdEmpresa)
       {
           try
           {
               try
               {
                   List<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info> Listdat_ = new List<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info>();

                   EntitiesInventario OEUser = new EntitiesInventario();

                   var select_ = from TI in OEUser.vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_no_parametrizados
                                 where TI.IdEmpresa == IdEmpresa
                                 select TI;

                   foreach (var item in select_)
                   {
                       in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info dat_ = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info();
                       dat_.IdEmpresa = item.IdEmpresa;
                       dat_.IdCategoria = item.IdCategoria;
                       dat_.nom_categoria = "[" + item.IdCategoria + "] " + item.ca_Categoria;
                       dat_.IdLinea = item.IdLinea;
                       dat_.nom_linea = "[" + item.IdLinea.ToString() + "] " + item.nom_linea;
                       dat_.IdGrupo = item.IdGrupo;
                       dat_.nom_grupo = "[" + item.IdGrupo.ToString() + "] " + item.nom_grupo;
                       dat_.IdSubgrupo = item.IdSubGrupo;
                       dat_.nom_subgrupo = "[" + item.IdSubGrupo.ToString() + "] " + item.nom_subgrupo;

                       dat_.IdCentroCosto = item.IdCentroCosto;
                       dat_.nom_centro_costo = "[" + item.IdCentroCosto + "] " + item.nom_Centro;
                       dat_.IdSub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                       dat_.nom_sub_centro_costo = "[" + item.IdCentroCosto_sub_centro_costo + "] " + item.nom_Subcentro;

                       dat_.IdCtaCble = null;

                       Listdat_.Add(dat_);
                   }


                   return Listdat_;

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
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info Get_Info_in_subgrupo(int IdEmpresa,string IdCategoria,int IdLinea,int IdGrupo,int IdSubGrupo,
            string IdCentroCosto,string IdSubCentroCosto )
       {
           try
           {
               try
               {
                   in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info dat_ = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info();

                   

                   EntitiesInventario OEUser = new EntitiesInventario();

                   var select_ = from TI in OEUser.vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble
                                 where TI.IdEmpresa == IdEmpresa
                                 && TI.IdCategoria==IdCategoria
                                 && TI.IdLinea==IdLinea
                                 && TI.IdGrupo==IdGrupo
                                 && TI.IdSubgrupo==IdSubGrupo
                                 && TI.IdCentroCosto==IdCentroCosto
                                 && TI.IdSub_centro_costo==IdSubCentroCosto
                                 select TI;

                   foreach (var item in select_)
                   {
                       
                       dat_.IdEmpresa = item.IdEmpresa;
                       dat_.IdCategoria = item.IdCategoria;
                       dat_.nom_categoria = item.nom_categoria;
                       dat_.IdLinea = item.IdLinea;
                       dat_.nom_linea = item.nom_linea;
                       dat_.IdGrupo = item.IdGrupo;
                       dat_.nom_grupo = item.nom_grupo;
                       dat_.IdSubgrupo = item.IdSubgrupo;
                       dat_.nom_subgrupo = item.nom_subgrupo;

                       dat_.IdCentroCosto = item.IdCentroCosto;
                       dat_.nom_centro_costo = item.nom_centro_costo;
                       dat_.IdSub_centro_costo = item.IdSub_centro_costo;
                       dat_.nom_sub_centro_costo = item.nom_sub_centro_costo;

                       dat_.IdCtaCble = item.IdCtaCble;

                       
                   }


                   return dat_;

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
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public Boolean GrabarDB(in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info info)
       {
           try
           {
               try
               {
                   using (EntitiesInventario context = new EntitiesInventario())
                   {

                       var lst = from q in context.in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble
                                 where q.IdEmpresa == info.IdEmpresa
                                 && q.IdCategoria == info.IdCategoria
                                 && q.IdLinea == info.IdLinea
                                 && q.IdGrupo == info.IdGrupo
                                 && q.IdSubgrupo == info.IdSubgrupo
                                 && q.IdCentroCosto == info.IdCentroCosto
                                 && q.IdSub_centro_costo == info.IdSub_centro_costo
                                 select q;

                       if (lst.Count() == 0)
                       {
                           in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble objSubGrupo = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble();

                           objSubGrupo.IdEmpresa = info.IdEmpresa;
                           objSubGrupo.IdCategoria = info.IdCategoria;
                           objSubGrupo.IdLinea = info.IdLinea;
                           objSubGrupo.IdGrupo = info.IdGrupo;
                           objSubGrupo.IdSubgrupo = info.IdSubgrupo;
                           objSubGrupo.IdCentroCosto = info.IdCentroCosto;
                           objSubGrupo.IdSub_centro_costo = info.IdSub_centro_costo;
                           objSubGrupo.IdCtaCble = info.IdCtaCble;

                           context.in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble.Add(objSubGrupo);
                           context.SaveChanges();
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
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }

       }

       public Boolean ModificarDB(in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info info)
       {
           try
           {
               try
               {
                   using (EntitiesInventario context = new EntitiesInventario())
                   {
                       var contact = context.in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble.FirstOrDefault(
                           var => var.IdEmpresa == info.IdEmpresa
                           && var.IdCategoria == info.IdCategoria
                           && var.IdLinea == info.IdLinea
                           && var.IdGrupo == info.IdGrupo
                           && var.IdSubgrupo == info.IdSubgrupo
                           && var.IdCentroCosto == info.IdCentroCosto
                           && var.IdSub_centro_costo == info.IdSub_centro_costo
                           );
                       if (contact != null)
                       {
                           contact.IdCtaCble = info.IdCtaCble;

                           context.SaveChanges();
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
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public bool Existe_en_base(in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info info)
       {
           try
           {
               using (EntitiesInventario Context = new EntitiesInventario())
               {
                   var lst = from q in Context.in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble
                             where q.IdEmpresa == info.IdEmpresa
                             && q.IdCategoria == info.IdCategoria
                             && q.IdLinea == info.IdLinea
                             && q.IdGrupo == info.IdGrupo
                             && q.IdCentroCosto == info.IdCentroCosto
                             && q.IdSub_centro_costo == info.IdSub_centro_costo
                             select q;

                   if (lst.Count() == 0) return false; else return true;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }
    }
}
