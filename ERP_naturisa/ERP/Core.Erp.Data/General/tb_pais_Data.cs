using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.General
{
  public  class tb_pais_Data
    {
      string mensaje = "";

      public Boolean GuardarDB(tb_pais_Info Info_Pais, ref string IdPais, ref string msjError)
      {
          try
          {
              using (EntitiesGeneral Context = new EntitiesGeneral())
              {
                  var Address = new tb_pais();
                  Address.IdPais = Info_Pais.IdPais = IdPais = GetId();
                  Address.CodPais = (Info_Pais.CodPais == "" || Info_Pais.CodPais == null) ? "Pais_" + Info_Pais.IdPais : Info_Pais.CodPais;
                  Address.Nombre = Info_Pais.Nombre;
                  Address.Nacionalidad = Info_Pais.Nacionalidad;
                  Address.estado = "A";

                  Address.IdUsuario = Info_Pais.IdUsuario;
                  Address.Fecha_Transac = Info_Pais.Fecha_Transac;
                  Address.nom_pc = Info_Pais.nom_pc;
                  Address.ip = Info_Pais.ip;

                  Context.tb_pais.Add(Address);
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
              var select = (from q in ocxc.tb_pais
                            select q);

              if (select.ToList().Count == 0)
              {
                  Id = Convert.ToString(1);
              }
              else
              {
                  var select_pv = (from q in ocxc.tb_pais
                                   select q.IdPais).Max();

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

      public Boolean ModificarDB(tb_pais_Info Info_Pais, ref string msjError)
      {
          try
          {
              using (EntitiesGeneral Context = new EntitiesGeneral())
              {
                  var contact = Context.tb_pais.FirstOrDefault(af => af.IdPais == Info_Pais.IdPais);
                  if (contact != null)
                  {
                      contact.CodPais = Info_Pais.CodPais;
                      contact.Nombre = Info_Pais.Nombre;
                      contact.Nacionalidad = Info_Pais.Nacionalidad;
                      contact.IdUsuarioUltMod = Info_Pais.IdUsuarioUltMod;
                      contact.Fecha_UltMod = Info_Pais.Fecha_UltMod;
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

      public Boolean AnularDB(tb_pais_Info Info_Pais, ref string msjError)
      {
          try
          {
              using (EntitiesGeneral Context = new EntitiesGeneral())
              {
                  var contact = Context.tb_pais.FirstOrDefault(af => af.IdPais == Info_Pais.IdPais);
                  if (contact != null)
                  {
                      contact.estado = "I";
                      contact.IdUsuarioUltAnu = Info_Pais.IdUsuarioUltAnu;
                      contact.Fecha_UltAnu = Info_Pais.Fecha_UltAnu;
                      contact.MotivoAnula = Info_Pais.MotivoAnula;
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

      public List<tb_pais_Info> Get_List_pais()
      {             
          try {
              List<tb_pais_Info> lstPais = new List<tb_pais_Info>();
              EntitiesGeneral objEnti = new EntitiesGeneral();
              var pais = from p in objEnti.tb_pais
                         select p;
              foreach (var item in pais)
              {
                  tb_pais_Info info = new tb_pais_Info();
                  info.CodPais = item.CodPais;
                  info.Nombre = item.Nombre;
                  info.Nacionalidad = item.Nacionalidad;
                  info.IdPais = item.IdPais;
                  info.estado = item.estado;
                  lstPais.Add(info);                  
              }

              return lstPais;
          }
          catch (Exception ex) {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }      
      }

      public tb_pais_Info Get_Info_pais(string IdPais)
      {
          try
          {
              tb_pais_Info info = new tb_pais_Info();
              EntitiesGeneral objEnti = new EntitiesGeneral();
              var pais = from p in objEnti.tb_pais
                         where p.IdPais == IdPais
                         select p;
              foreach (var item in pais)
              {
                  info = new tb_pais_Info();
                  info.CodPais = item.CodPais;
                  info.Nombre = item.Nombre;
                  info.Nacionalidad = item.Nacionalidad;
                  info.IdPais = item.IdPais;
                  info.estado = item.estado;                  
              }

              return info;
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

      public string GetIdPais(string IdProvincia) {
          string idPais = string.Empty;
          try
          {
              using (EntitiesGeneral Base=new EntitiesGeneral())
              {
                  var provincia = Base.tb_provincia.FirstOrDefault(p=>p.IdProvincia==IdProvincia);
                  if(provincia!=null)
                      idPais = provincia.IdPais;
              }
              return idPais;
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
