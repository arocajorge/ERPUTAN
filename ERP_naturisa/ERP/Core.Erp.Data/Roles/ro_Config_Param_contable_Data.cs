

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
   public class ro_Config_Param_contable_Data
    {
       string mensaje = "";


       public List<ro_Config_Param_contable_Info> Get_List_Config_Param_contable_Provisiones(int IdEmpresa)
        {
            try
            {
                List<ro_Config_Param_contable_Info> listado = new List<ro_Config_Param_contable_Info>();

                string query = "select * from vwRo_Division_Area_dep_rubro where IdEmpresa='" + IdEmpresa + "' and rub_provision=1";

               
                using (EntitiesRoles db = new EntitiesRoles())
                {
                  

                    var result = db.Database.SqlQuery<ro_Config_Param_contable_Info>(query).ToList(); ;


                    foreach (var item in result)
                    {
                        ro_Config_Param_contable_Info info = new ro_Config_Param_contable_Info();
                        info.IdEmpresa =Convert.ToInt32( item.IdEmpresa);
                        info.IdDivision =Convert.ToInt32( item.IdDivision);
                        info.IdArea =Convert.ToInt32( item.IdArea);
                        info.IdDepartamento =Convert.ToInt32( item.IdDepartamento);
                        info.IdRubro = item.IdRubro;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.DebCre = item.DebCre;
                        info.ru_tipo = item.ru_tipo;
                        info.DescripcionDiv = item.DescripcionDiv;
                        info.DescripcionArea = item.DescripcionArea;
                        info.de_descripcion = item.de_descripcion;
                        info.ru_descripcion = item.ru_descripcion;
                        info.rub_provision = item.rub_provision;
                        info.rub_nocontab = (bool)item.rub_nocontab;
                        info.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;
                        info.IdCtaCble_Haber = item.IdCtaCble_Haber;

                        if (item.IdCtaCble == null)
                            info.IdCtaCble = item.rub_ctacon;
                        listado.Add(info);
                    }
                }
                return listado;
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

       public List<ro_Config_Param_contable_Info> Get_List_Config_Param_contable_Sueldo_x_pagar(int IdEmpresa)
       {
           try
           {
               List<ro_Config_Param_contable_Info> listado = new List<ro_Config_Param_contable_Info>();

               string query = "select * from vwRo_Division_Area_dep_rubro where IdEmpresa='" + IdEmpresa + "' and rub_provision=0";


               using (EntitiesRoles db = new EntitiesRoles())
               {


                   var result = db.Database.SqlQuery<ro_Config_Param_contable_Info>(query).ToList(); ;


                   foreach (var item in result)
                   {
                       ro_Config_Param_contable_Info info = new ro_Config_Param_contable_Info();
                       info.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                       info.IdDivision = Convert.ToInt32(item.IdDivision);
                       info.IdArea = Convert.ToInt32(item.IdArea);
                       info.IdDepartamento = Convert.ToInt32(item.IdDepartamento);
                       info.IdRubro = item.IdRubro;
                       info.IdCtaCble = item.IdCtaCble;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.DebCre = item.DebCre;
                       info.ru_tipo = item.ru_tipo;
                       info.DescripcionDiv = item.DescripcionDiv;
                       info.DescripcionArea = item.DescripcionArea;
                       info.de_descripcion = item.de_descripcion;
                       info.ru_descripcion = item.ru_descripcion;
                       info.rub_provision = item.rub_provision;
                       info.rub_nocontab = (bool)item.rub_nocontab;
                       info.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;
                       info.IdCtaCble_Haber = item.IdCtaCble_Haber;

                       if (item.IdCtaCble == null)
                           info.IdCtaCble = item.rub_ctacon;
                       listado.Add(info);
                   }
               }
               return listado;
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

       public List<ro_Config_Param_contable_Info> Get_List_Config_Param_contable_Contabilizar_provisiones(int idEmpresa, ref string msg)
       {
           try
           {
               List<ro_Config_Param_contable_Info> listado = new List<ro_Config_Param_contable_Info>();

               using (EntitiesRoles db = new EntitiesRoles())
               {

                   string query = "select * from vwRo_Division_Area_dep_rubro where IdEmpresa='" + idEmpresa + "' and rub_provision=1";
                    var result = db.Database.SqlQuery<ro_Config_Param_contable_Info>(query).ToList(); ;


                    foreach (var item in result)
                   {
                       ro_Config_Param_contable_Info info = new ro_Config_Param_contable_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdDivision = item.IdDivision;
                       info.IdArea = item.IdArea;
                       info.IdDepartamento = item.IdDepartamento;
                       info.IdRubro = item.IdRubro;
                       info.IdCtaCble = item.IdCtaCble;
                       info.IdCtaCble_Haber = item.IdCtaCble_Haber;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.DebCre = item.DebCre;
                       info.ru_tipo = item.ru_tipo;
                       //DATOS DE LA VISTA
                       info.DescripcionDiv = item.DescripcionDiv;
                       info.DescripcionArea = item.DescripcionArea;
                       info.de_descripcion = item.de_descripcion;
                       info.ru_descripcion = item.ru_descripcion;
                       info.rub_provision = item.rub_provision;
                       info.rub_nocontab =(bool) item.rub_nocontab;
                       info.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;
                       listado.Add(info);
                   }
               }
               return listado;
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

       public List<ro_Config_Param_contable_Info> Get_List_Config_Param_contable_Contabilizar_Sueldo_x_pagar(int idEmpresa, ref string msg)
       {
           try
           {
               List<ro_Config_Param_contable_Info> listado = new List<ro_Config_Param_contable_Info>();

               using (EntitiesRoles db = new EntitiesRoles())
               {

                   string query = "select * from vwRo_Division_Area_dep_rubro where IdEmpresa='" + idEmpresa + "' and rub_provision=0";
                   var result = db.Database.SqlQuery<ro_Config_Param_contable_Info>(query).ToList(); ;


                   foreach (var item in result)
                   {
                       ro_Config_Param_contable_Info info = new ro_Config_Param_contable_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdDivision = item.IdDivision;
                       info.IdArea = item.IdArea;
                       info.IdDepartamento = item.IdDepartamento;
                       info.IdRubro = item.IdRubro;
                       info.IdCtaCble = item.IdCtaCble;
                       info.IdCtaCble_Haber = item.IdCtaCble_Haber;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.DebCre = item.DebCre;
                       info.ru_tipo = item.ru_tipo;
                       //DATOS DE LA VISTA
                       info.DescripcionDiv = item.DescripcionDiv;
                       info.DescripcionArea = item.DescripcionArea;
                       info.de_descripcion = item.de_descripcion;
                       info.ru_descripcion = item.ru_descripcion;
                       info.rub_provision = item.rub_provision;
                       info.rub_nocontab = (bool)item.rub_nocontab;
                       info.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;
                       listado.Add(info);
                   }
               }
               return listado;
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


       public Boolean GrabarDB(List<ro_Config_Param_contable_Info> lista, ref string msg)
       {
           try
           {
               using (EntitiesRoles context = new EntitiesRoles())
               {

                   foreach (var item in lista)
                   {
                       var _sel = from q in context.ro_Config_Param_contable
                                  where q.IdEmpresa == item.IdEmpresa && q.IdDivision == item.IdDivision
                                  && q.IdArea==item.IdArea && q.IdDepartamento==item.IdDepartamento && q.IdRubro==item.IdRubro
                                  select q;

                       if (_sel.Count() > 0)
                       {
                           var contact = context.ro_Config_Param_contable.First(
                                  var => var.IdEmpresa == item.IdEmpresa
                                   && var.IdDivision == item.IdDivision && var.IdArea==item.IdArea && var.IdDepartamento== item.IdDepartamento
                                   && var.IdRubro==item.IdRubro);


                           contact.IdCtaCble = item.IdCtaCble;
                           contact.IdCentroCosto =item.IdCentroCosto;
                           contact.DebCre = item.DebCre;
                           contact.IdCtaCble_Haber = item.IdCtaCble_Haber;

                           context.SaveChanges();
                       }
                       else
                       {

                       ro_Config_Param_contable obj = new ro_Config_Param_contable();


                           obj.IdEmpresa = item.IdEmpresa;
                           obj.IdDivision = item.IdDivision;
                           obj.IdArea = item.IdArea;
                           obj.IdDepartamento = item.IdDepartamento;
                           obj.IdRubro = item.IdRubro;
                           obj.IdCtaCble = item.IdCtaCble;
                           obj.IdCentroCosto = item.IdCentroCosto;
                           obj.DebCre = item.DebCre;
                           obj.IdCtaCble_Haber = item.IdCtaCble_Haber;


                           context.ro_Config_Param_contable.Add(obj);
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
               mensaje = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.InnerException.ToString());
           }

       }


      
    }
}
