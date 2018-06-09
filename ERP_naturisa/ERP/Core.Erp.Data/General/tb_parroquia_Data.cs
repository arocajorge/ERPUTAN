using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
   public class tb_parroquia_Data
    {


       public tb_parroquia_Data() { }

      string mensaje = "";
      public Boolean Guardar_DB(tb_parroquia_Info Info_Pro, ref string IdParroquia, ref string msjError)
      {
          try
          {
              using (EntitiesGeneral Context = new EntitiesGeneral())
              {            
                  var Address = new tb_parroquia();


                  Address.IdParroquia = Info_Pro.IdParroquia = IdParroquia = GetId();
                  Address.cod_parroquia = (Info_Pro.cod_parroquia == "" || Info_Pro.cod_parroquia == null) ? Info_Pro.IdParroquia : Info_Pro.cod_parroquia;
                  Address.nom_parroquia = Info_Pro.nom_parroquia;
                  Address.estado = true;

                  Address.IdCiudad_Canton = Info_Pro.IdCiudad_Canton;

                  Address.IdUsuario = Info_Pro.IdUsuario;
                  Address.Fecha_Transac = Info_Pro.Fecha_Transac;
                  Address.nom_pc = Info_Pro.nom_pc;
                  Address.ip = Info_Pro.ip;

                  Context.tb_parroquia.Add(Address);
                  Context.SaveChanges();
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              msjError = mensaje;
              throw new Exception(ex.ToString());
          }
      }

      public string GetId()
      {
          try
          {
              string Id;
              EntitiesGeneral ocxc = new EntitiesGeneral();
              var select = (from q in ocxc.tb_parroquia
                            select q);

              if (select.ToList().Count == 0)
              {
                  Id = Convert.ToString(1);
              }
              else
              {
                  var select_pv = (from q in ocxc.tb_parroquia
                                   select q.IdParroquia).Max();

                  Id = Convert.ToString(Convert.ToInt32(select_pv.ToString()) + 1);
              }
              return Id;

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

      public Boolean Modificar_DB(tb_parroquia_Info Info_Pro, ref string msjError)
      {
          try
          {
              using (EntitiesGeneral Context = new EntitiesGeneral())
              {
                  var contact = Context.tb_parroquia.FirstOrDefault(af => af.IdParroquia == Info_Pro.IdParroquia);
                  if (contact != null)
                  {
                      contact.cod_parroquia = Info_Pro.cod_parroquia;
                      contact.nom_parroquia = Info_Pro.nom_parroquia;
                      contact.IdCiudad_Canton = Info_Pro.IdCiudad_Canton;
                      contact.IdUsuarioUltMod = Info_Pro.IdUsuarioUltMod;
                      contact.Fecha_UltMod = Info_Pro.Fecha_UltMod;
                      Context.SaveChanges();
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              msjError = mensaje;
              throw new Exception(ex.ToString());
          }
      }

      public Boolean Anular_DB(tb_parroquia_Info Info_Pro, ref string msjError)
      {
          try
          {
               using (EntitiesGeneral Context = new EntitiesGeneral())
              {
                  var contact = Context.tb_parroquia.FirstOrDefault(af => af.IdParroquia == Info_Pro.IdParroquia);
                  if (contact != null)
                  {
                      contact.estado = false;
                      contact.IdUsuarioUltAnu = Info_Pro.IdUsuarioUltAnu;
                      contact.Fecha_UltAnu = Info_Pro.Fecha_UltAnu;
                      contact.MotivoAnula = Info_Pro.MotivoAnula;
                      Context.SaveChanges();
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              msjError = mensaje;
              throw new Exception(ex.ToString());
          }
      }



      public List<tb_parroquia_Info> Get_List_Parroquias(string IdCiudad_Canton)
      {
          try
          {
              List<tb_parroquia_Info> lstProvincia = new List<tb_parroquia_Info>();
              using (EntitiesGeneral Base = new EntitiesGeneral())
              {
                  var vProvincia = from p in Base.tb_parroquia
                                   where p.IdCiudad_Canton == IdCiudad_Canton
                                   select p;

                  foreach (var item in vProvincia)
                  {
                      tb_parroquia_Info infoProvincia = new tb_parroquia_Info();


                      infoProvincia.IdParroquia = item.IdParroquia;
                      infoProvincia.cod_parroquia = item.cod_parroquia;
                      infoProvincia.nom_parroquia = item.nom_parroquia;
                      infoProvincia.estado = item.estado;
                      infoProvincia.IdCiudad_Canton = item.IdCiudad_Canton;


                      lstProvincia.Add(infoProvincia);
                  }
              }
              return lstProvincia;
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

      public List<tb_parroquia_Info> Get_List_Parroquia() 
      {                    
          try
          {
              List<tb_parroquia_Info> lstProvincia = new List<tb_parroquia_Info>();
              using(EntitiesGeneral Base=new EntitiesGeneral())
              {
                  var vProvincia = from p in Base.tb_parroquia
                                   select p;

                  foreach (var item in vProvincia)
                  {
                      tb_parroquia_Info infoParroquia = new tb_parroquia_Info();


                      infoParroquia.IdParroquia = item.IdParroquia;
                      infoParroquia.cod_parroquia = item.cod_parroquia;
                      infoParroquia.nom_parroquia = item.nom_parroquia;
                      infoParroquia.estado = item.estado;
                      infoParroquia.IdCiudad_Canton = item.IdCiudad_Canton;

                      
                      lstProvincia.Add(infoParroquia);                      
                  }
              }
              return lstProvincia;
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


        public tb_parroquia_Info Get_Info_Parroquia(string IdParroquia)
        {
            try
            {
                tb_parroquia_Info infoParroquia = new tb_parroquia_Info();
                using (EntitiesGeneral Base = new EntitiesGeneral())
                {
                    var vProvincia = from p in Base.tb_parroquia
                                    where p.IdParroquia == IdParroquia
                                    select p;

                    foreach (var item in vProvincia)
                    {
                        infoParroquia = new tb_parroquia_Info();

                        infoParroquia.IdParroquia = item.IdParroquia;
                        infoParroquia.cod_parroquia = item.cod_parroquia;
                        infoParroquia.nom_parroquia = item.nom_parroquia;
                        infoParroquia.estado = item.estado;
                        infoParroquia.IdCiudad_Canton = item.IdCiudad_Canton;
                                    
                    }
                }
                return infoParroquia;
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

           //public string Get_IdProvincia(string IdCiudad) 
           //{
           //    string IdProvincia = string.Empty;
           //    try
           //    {
           //        using (EntitiesGeneral Base=new EntitiesGeneral())
           //        {
                    
           //           var ciudad = Base.tb_ciudad.FirstOrDefault(c=>c.IdCiudad==IdCiudad);
           //            if(ciudad!=null)
           //                IdProvincia = ciudad.IdProvincia;
                   
           //        }
           //        return IdProvincia;
           //    }
           //    catch (Exception ex)
           //    {
           //        string arreglo = ToString();
           //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
           //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
           //                            "", "", "", "", DateTime.Now);
           //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
           //        mensaje = ex.ToString() + " " + ex.Message;
           //        throw new Exception(ex.ToString());
           //    }
           //}
    }
}
