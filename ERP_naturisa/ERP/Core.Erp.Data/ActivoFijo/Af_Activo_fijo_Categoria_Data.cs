using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.ActivoFijo
{
   public  class Af_Activo_fijo_Categoria_Data
    {
       string mensaje = "";

       public List<Af_Activo_fijo_Categoria_Info> Get_List_Activo_fijo_Categoria(int IdEmpresa, ref string MensajeError)
       {
           List<Af_Activo_fijo_Categoria_Info> lista = new List<Af_Activo_fijo_Categoria_Info>();

           try
           {
               using (EntitiesActivoFijo DBase = new EntitiesActivoFijo())
               {
                   var q = from C in DBase.vwAf_Activo_fijo_Categoria
                           where C.IdEmpresa == IdEmpresa
                           select C;

                   foreach (var item in q)
                   {
                       Af_Activo_fijo_Categoria_Info Info= new Af_Activo_fijo_Categoria_Info();
                       Info.IdEmpresa = item.IdEmpresa;
                       Info.IdCategoriaAF = item.IdCategoriaAF;
                       Info.IdActivoFijoTipo = item.IdActivoFijoTipo;
                       Info.Tipo_Descripcion = item.Af_Descripcion;
                       Info.CodCategoriaAF = item.CodCategoriaAF;
                       Info.Descripcion = item.Descripcion;
                       Info.Estado = item.Estado;
                       lista.Add(Info);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               //saca la excepción controlada a la proxima capa
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public List<Af_Activo_fijo_Categoria_Info> Get_List_Activo_fijo_Categoria(int IdEmpresa, int IdActivoFijoTipo, ref string MensajeError)
       {
           List<Af_Activo_fijo_Categoria_Info> lista = new List<Af_Activo_fijo_Categoria_Info>();

           try
           {
               using (EntitiesActivoFijo DBase = new EntitiesActivoFijo())
               {
                   var q = from C in DBase.vwAf_Activo_fijo_Categoria
                           where C.IdEmpresa == IdEmpresa
                           && C.IdActivoFijoTipo == IdActivoFijoTipo
                           select C;

                   foreach (var item in q)
                   {
                       Af_Activo_fijo_Categoria_Info Info = new Af_Activo_fijo_Categoria_Info();
                       Info.IdEmpresa = item.IdEmpresa;
                       Info.IdCategoriaAF = item.IdCategoriaAF;
                       Info.IdActivoFijoTipo = item.IdActivoFijoTipo;
                       Info.Tipo_Descripcion = item.Af_Descripcion;
                       Info.CodCategoriaAF = item.CodCategoriaAF;
                       Info.Descripcion = item.Descripcion;
                       Info.Descripcion2 = "[" +item.IdCategoriaAF + "]-" + item.Descripcion;
                       Info.Estado = item.Estado;
                       lista.Add(Info);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public Boolean GrabarDB(Af_Activo_fijo_Categoria_Info Info, int IdCategoria, ref string MensajeError)
       {
           try
           {
               using (EntitiesActivoFijo BaseDB = new EntitiesActivoFijo())
               {
                   var address = new Af_Activo_fijo_Categoria();

                        address.IdEmpresa=Info.IdEmpresa;
                        address.IdCategoriaAF = Info.IdCategoriaAF = GetId(Info.IdEmpresa, Info.IdActivoFijoTipo);
                        address.IdActivoFijoTipo=Info.IdActivoFijoTipo;
                        address.CodCategoriaAF=Info.CodCategoriaAF;
                        address.Descripcion=Info.Descripcion;
                        address.IdUsuario=Info.IdUsuario;
                        address.Fecha_Transac=DateTime.Now;
                        address.IdUsuarioUltMod=Info.IdUsuarioUltMod;
                        address.Fecha_UltMod=DateTime.Now;
                        address.nom_pc=Info.nom_pc;
                        address.ip=Info.ip;
                        address.Estado = Info.Estado;
                        BaseDB.Af_Activo_fijo_Categoria.Add(address);
                        BaseDB.SaveChanges();
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public Boolean ModificarDB(Af_Activo_fijo_Categoria_Info Info, ref string MensajeError)
       {
           try
           {
               using (EntitiesActivoFijo BaseDB = new EntitiesActivoFijo())
               {
                   var address = BaseDB.Af_Activo_fijo_Categoria.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdCategoriaAF == Info.IdCategoriaAF);
                   if (address != null)
                   {
                       address.IdActivoFijoTipo = Info.IdActivoFijoTipo;
                       address.CodCategoriaAF = Info.CodCategoriaAF;
                       address.Descripcion = Info.Descripcion;
                       address.IdUsuario = Info.IdUsuario;
                       address.Fecha_UltMod = DateTime.Now;
                       address.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                       address.Estado = Info.Estado;
                       BaseDB.SaveChanges();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }

       public Boolean AnularDB(Af_Activo_fijo_Categoria_Info Info, ref string MensajeError)
       {
           try
           {
               using (EntitiesActivoFijo BaseDB = new EntitiesActivoFijo())
               {
                   var address = BaseDB.Af_Activo_fijo_Categoria.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdActivoFijoTipo == Info.IdActivoFijoTipo
                       && v.IdCategoriaAF == Info.IdCategoriaAF);
                   if (address != null)
                   {
                       address.Fecha_UltAnu = DateTime.Now;
                       address.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                       address.Estado = "I";
                       BaseDB.SaveChanges();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }

       public int GetId(int IdEmpresa,int IdActivoFijoTipo)
       {
           try
           {
               int Id;
               EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
               var select = from q in OEPActivoFijo.Af_Activo_fijo_Categoria
                            where q.IdEmpresa == IdEmpresa
                            //&& q.IdActivoFijoTipo == IdActivoFijoTipo
                            select q;

               if (select.ToList().Count < 1)
               {
                   Id = 1;
               }
               else
               {
                   EntitiesActivoFijo OEPActivoFijoTipo = new EntitiesActivoFijo();
                   var select_pv = (from q in OEPActivoFijoTipo.Af_Activo_fijo_Categoria
                                    where q.IdEmpresa == IdEmpresa
                              //      && q.IdActivoFijoTipo == IdActivoFijoTipo
                                    select q.IdCategoriaAF).Max();
                   Id = Convert.ToInt32(select_pv.ToString()) + 1;
               }
               return Id;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.InnerException.ToString());
           }
       }
    }
}
