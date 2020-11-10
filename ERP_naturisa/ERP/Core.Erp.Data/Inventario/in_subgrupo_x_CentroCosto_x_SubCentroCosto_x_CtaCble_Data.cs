using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Data.Entity.Validation;
using System.Data.SqlClient;

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
                   using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                   {
                       connection.Open();
                       SqlCommand command = new SqlCommand();
                       command.Connection = connection;
                       command.CommandTimeout = 3000;
                       command.CommandText = "SELECT        rel.IdEmpresa, rel.IdCategoria, '[' + rel.IdCategoria + '] ' + c.ca_Categoria AS nom_categoria, rel.IdLinea, '[' + CAST(rel.IdLinea AS varchar(10)) + '] ' + l.nom_linea AS nom_linea, rel.IdGrupo, '[' + CAST(rel.IdGrupo AS varchar(10)) "
                                        +" + '] ' + g.nom_grupo AS nom_grupo, rel.IdSubgrupo, '[' + CAST(rel.IdSubgrupo AS varchar(10)) + '] ' + sg.nom_subgrupo AS nom_subgrupo, rel.IdCentroCosto, '[' + rel.IdCentroCosto + '] ' + cc.Centro_costo AS nom_centro_costo, "
                                        +" rel.IdSub_centro_costo, '[' + rel.IdSub_centro_costo + '] ' + scc.Centro_costo AS nom_sub_centro_costo, rel.IdCtaCble"
                                        +" FROM            dbo.ct_centro_costo AS cc INNER JOIN"
                                        +" dbo.ct_centro_costo_sub_centro_costo AS scc ON cc.IdEmpresa = scc.IdEmpresa AND cc.IdCentroCosto = scc.IdCentroCosto RIGHT OUTER JOIN"
                                        +" dbo.in_subgrupo AS sg INNER JOIN"
                                        +" dbo.in_grupo AS g INNER JOIN"
                                        +" dbo.in_linea AS l ON g.IdEmpresa = l.IdEmpresa AND g.IdCategoria = l.IdCategoria AND g.IdLinea = l.IdLinea INNER JOIN"
                                        +" dbo.in_categorias AS c ON l.IdEmpresa = c.IdEmpresa AND l.IdCategoria = c.IdCategoria ON sg.IdEmpresa = g.IdEmpresa AND sg.IdCategoria = g.IdCategoria AND sg.IdLinea = g.IdLinea AND "
                                        +" sg.IdGrupo = g.IdGrupo RIGHT OUTER JOIN"
                                        +" dbo.in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble AS rel ON sg.IdEmpresa = rel.IdEmpresa AND sg.IdCategoria = rel.IdCategoria AND sg.IdLinea = rel.IdLinea AND sg.IdGrupo = rel.IdGrupo AND "
                                        +" sg.IdSubgrupo = rel.IdSubgrupo ON scc.IdEmpresa = rel.IdEmpresa AND scc.IdCentroCosto = rel.IdCentroCosto AND scc.IdCentroCosto_sub_centro_costo = rel.IdSub_centro_costo"
                                        +" WHERE        (rel.IdEmpresa = "+IdEmpresa.ToString()+")";
                       SqlDataReader reader = command.ExecuteReader();
                       while (reader.Read())
                       {
                           Listdat_.Add(new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info
                           {

                               IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                               IdCategoria = Convert.ToString(reader["IdCategoria"]),
                               nom_categoria = Convert.ToString(reader["nom_categoria"]),
                               IdLinea = Convert.ToInt32(reader["IdLinea"]),
                               nom_linea = Convert.ToString(reader["nom_linea"]),
                               IdGrupo = Convert.ToInt32(reader["IdGrupo"]),
                               nom_grupo = Convert.ToString(reader["nom_grupo"]),
                               IdSubgrupo = Convert.ToInt32(reader["IdSubgrupo"]),
                               nom_subgrupo = Convert.ToString(reader["nom_subgrupo"]),
                               nom_centro_costo = Convert.ToString(reader["nom_centro_costo"]),
                               IdCentroCosto = Convert.ToString(reader["IdCentroCosto"]),
                               IdSub_centro_costo = Convert.ToString(reader["IdSub_centro_costo"]),
                               nom_sub_centro_costo = Convert.ToString(reader["nom_sub_centro_costo"]),
                               IdCtaCble = Convert.ToString(reader["IdCtaCble"])
                           });
                       }
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

       public List<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info> Get_List_Info_in_subgrupo_no_parametrizados(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
       {
           try
           {
               try
               {
                   List<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info> Listdat_ = new List<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info>();
                   Fecha_ini = Fecha_ini.Date;
                   Fecha_fin = Fecha_fin.Date;
                   using (EntitiesInventario Context = new EntitiesInventario())
                   {
                       Context.SetCommandTimeOut(5000);
                       var lst = Context.spINV_relaciones_no_parametrizadas(IdEmpresa, Fecha_ini, Fecha_fin).ToList();
                       foreach (var q in lst)
                       {
                           Listdat_.Add(new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info
                                                     {
                                                         IdEmpresa = q.IdEmpresa,
                                                         IdCategoria = q.IdCategoria,
                                                         nom_categoria = q.ca_Categoria,
                                                         IdLinea = q.IdLinea,
                                                         nom_linea = q.nom_linea,
                                                         IdGrupo = q.IdGrupo,
                                                         nom_grupo = q.nom_grupo,
                                                         IdSubgrupo = q.IdSubGrupo,
                                                         nom_subgrupo = q.nom_subgrupo,

                                                         IdCentroCosto = q.IdCentroCosto,
                                                         nom_centro_costo = q.Centro_costo,
                                                         IdSub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                                         nom_sub_centro_costo = q.NomSubcentro,

                                                         IdCtaCble = null,
                                                     });
                       }
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
                           objSubGrupo.IdLinea = Convert.ToInt32(info.IdLinea);
                           objSubGrupo.IdGrupo = Convert.ToInt32(info.IdGrupo);
                           objSubGrupo.IdSubgrupo = Convert.ToInt32(info.IdSubgrupo);
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
