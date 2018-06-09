using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
  public  class tb_Provincia_Data
    {

      public tb_Provincia_Data() { }

      string mensaje = "";
      public Boolean Guardar_DB(tb_provincia_Info Info_Pro, ref string IdProvincia, ref string msjError)
      {
          try
          {
              using (EntitiesGeneral Context = new EntitiesGeneral())
              {            
                  var Address = new tb_provincia();
                  Address.IdProvincia = Info_Pro.IdProvincia = IdProvincia = GetId();
                  Address.Cod_Provincia = (Info_Pro.CodProvincia == "" || Info_Pro.CodProvincia == null) ? "Prov_" + Info_Pro.IdProvincia : Info_Pro.CodProvincia;
                  Address.Descripcion_Prov = Info_Pro.Descripcion;
                  Address.Estado = "A";
                  Address.IdPais = Info_Pro.IdPais;

                  Address.IdUsuario = Info_Pro.IdUsuario;
                  Address.Fecha_Transac = Info_Pro.Fecha_Transac;
                  Address.nom_pc = Info_Pro.nom_pc;
                  Address.ip = Info_Pro.ip;
                  Address.Cod_Region = Info_Pro.Cod_Region;
                  Context.tb_provincia.Add(Address);
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
              var select = (from q in ocxc.tb_provincia
                            select q);

              if (select.ToList().Count == 0)
              {
                  Id = Convert.ToString(1);
              }
              else
              {
                  var select_pv = (from q in ocxc.tb_provincia
                                   select q.IdProvincia).Max();

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

      public Boolean Modificar_DB(tb_provincia_Info Info_Pro, ref string msjError)
      {
          try
          {
              using (EntitiesGeneral Context = new EntitiesGeneral())
              {
                  var contact = Context.tb_provincia.FirstOrDefault(af => af.IdProvincia == Info_Pro.IdProvincia);
                  if (contact != null)
                  {
                      contact.Cod_Provincia = Info_Pro.CodProvincia;
                      contact.Descripcion_Prov = Info_Pro.Descripcion;
                      contact.IdPais = Info_Pro.IdPais;
                      contact.IdUsuarioUltMod = Info_Pro.IdUsuarioUltMod;
                      contact.Fecha_UltMod = Info_Pro.Fecha_UltMod;
                      contact.Cod_Region = Info_Pro.Cod_Region;
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

      public Boolean Anular_DB(tb_provincia_Info Info_Pro, ref string msjError)
      {
          try
          {
               using (EntitiesGeneral Context = new EntitiesGeneral())
              {
                  var contact = Context.tb_provincia.FirstOrDefault(af => af.IdProvincia == Info_Pro.IdProvincia);
                  if (contact != null)
                  {
                      contact.Estado = "I";
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

      public List<tb_provincia_Info> Get_List_Provincia(string idPais)
      {
          try
          {
              List<tb_provincia_Info> lstProvincia = new List<tb_provincia_Info>();
              using (EntitiesGeneral Base = new EntitiesGeneral())
              {
                  var vProvincia = from p in Base.tb_provincia
                                   where p.IdPais == idPais
                                   select p;

                  foreach (var item in vProvincia)
                  {
                      tb_provincia_Info infoProvincia = new tb_provincia_Info();
                      infoProvincia.IdPais = item.IdPais;
                      infoProvincia.IdProvincia = item.IdProvincia;
                      infoProvincia.CodProvincia = item.Cod_Provincia;
                      infoProvincia.Descripcion = item.Descripcion_Prov;
                      infoProvincia.Estado = item.Estado;
                      infoProvincia.Cod_Region = item.Cod_Region;
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

      public List<tb_provincia_Info> Get_List_Provincia() 
      {                    
          try
          {
              List<tb_provincia_Info> lstProvincia = new List<tb_provincia_Info>();
              using(EntitiesGeneral Base=new EntitiesGeneral())
              {
                  var vProvincia = from p in Base.tb_provincia
                                   select p;

                  foreach (var item in vProvincia)
                  {
                      tb_provincia_Info infoProvincia = new tb_provincia_Info();
                      infoProvincia.IdPais = item.IdPais;
                      infoProvincia.IdProvincia = item.IdProvincia;
                      infoProvincia.CodProvincia = item.Cod_Provincia;
                      infoProvincia.Descripcion = item.Descripcion_Prov;
                      infoProvincia.Estado = item.Estado;
                      infoProvincia.Cod_Region = item.Cod_Region;
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


        public tb_provincia_Info Get_Info_Provincia(string IdProvincia)
        {
            try
            {
                tb_provincia_Info infoProvincia = new tb_provincia_Info();
                using (EntitiesGeneral Base = new EntitiesGeneral())
                {
                    var vProvincia = from p in Base.tb_provincia
                                    where p.IdProvincia == IdProvincia
                                    select p;

                    foreach (var item in vProvincia)
                    {
                        infoProvincia = new tb_provincia_Info();
                        infoProvincia.IdPais = item.IdPais;
                        infoProvincia.IdProvincia = item.IdProvincia;
                        infoProvincia.CodProvincia = item.Cod_Provincia;
                        infoProvincia.Descripcion = item.Descripcion_Prov;
                        infoProvincia.Estado = item.Estado;
                        infoProvincia.Cod_Region = item.Cod_Region;
                    }
                }
                return infoProvincia;
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

           public string Get_IdProvincia(string IdCiudad) 
           {
               string IdProvincia = string.Empty;
               try
               {
                   using (EntitiesGeneral Base=new EntitiesGeneral())
                   {
                    
                      var ciudad = Base.tb_ciudad.FirstOrDefault(c=>c.IdCiudad==IdCiudad);
                       if(ciudad!=null)
                           IdProvincia = ciudad.IdProvincia;
                   
                   }
                   return IdProvincia;
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
    }
}
