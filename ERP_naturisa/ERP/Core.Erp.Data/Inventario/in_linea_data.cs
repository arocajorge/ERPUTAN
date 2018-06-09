using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
  public   class in_linea_data
    {
      string mensaje = "";

      public int GetIdLinea(int IdEmpresa, string Idcategoria)
      {
          try
          {
              int IdLinea = 0;
              EntitiesInventario OELinea = new EntitiesInventario();
              var selecte = OELinea.in_linea.Count(q => q.IdEmpresa == IdEmpresa && q.IdCategoria == Idcategoria);
              if (selecte == 0)
              {
                  IdLinea = 1;
              }
              else
              {
                  OELinea = new EntitiesInventario();
                  var selectLinea = (from linea in OELinea.in_linea
                                     where linea.IdEmpresa == IdEmpresa
                                        && linea.IdCategoria == Idcategoria
                                     select linea.IdLinea).Max();
                  IdLinea = Convert.ToInt32(selectLinea.ToString()) + 1;



              }
              return IdLinea;
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

      public List<in_linea_info> Get_List_Linea(int IdEmpresa,string idcategoria)
      {
          try
          {
              List<in_linea_info> lM = new List<in_linea_info>();

              EntitiesInventario OEUser = new EntitiesInventario();

              var select_ = from TI in OEUser.in_linea
                            where TI.IdEmpresa == IdEmpresa
                            && TI.IdCategoria == idcategoria
                            select TI;


              foreach (var item in select_)
              {
                  in_linea_info dat_ = new in_linea_info();
                  dat_.IdEmpresa = item.IdEmpresa;
                  dat_.IdLinea = item.IdLinea;
                  dat_.cod_linea = item.cod_linea;
                  dat_.nom_linea = item.nom_linea;
                  dat_.abreviatura = item.abreviatura;
                  dat_.Estado = item.Estado;
                  dat_.IdCategoria = item.IdCategoria;
                  dat_.Observacion = item.observacion;
                  dat_.nom_linea2 = "["+item.IdLinea.ToString()+"] "+item.nom_linea;
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

      public List<in_linea_info> Get_List_Linea(int IdEmpresa)
      {
          try
          {
              List<in_linea_info> lM = new List<in_linea_info>();

              EntitiesInventario OEUser = new EntitiesInventario();

              var select_ = from TI in OEUser.in_linea
                            where TI.IdEmpresa == IdEmpresa
                           
                            select TI;


              foreach (var item in select_)
              {
                  in_linea_info dat_ = new in_linea_info();
                  dat_.IdEmpresa = item.IdEmpresa;
                  dat_.IdLinea = item.IdLinea;
                  dat_.cod_linea = item.cod_linea;
                  dat_.nom_linea = item.nom_linea;
                  dat_.abreviatura = item.abreviatura;
                  dat_.Estado = item.Estado;
                  dat_.IdCategoria = item.IdCategoria;
                  dat_.Observacion = item.observacion;

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

      public Boolean GrabarDB(in_linea_info info,ref int IdLinea, ref string msg)
      {
          try
          {
              using (EntitiesInventario context = new EntitiesInventario())
              {

                  var lst = from q in context.in_linea
                            where q.IdEmpresa == info.IdEmpresa
                            && q.IdCategoria == info.IdCategoria
                            && q.IdLinea == info.IdLinea
                            select q;

                  if (lst.Count()==0)
                  {
                      in_linea objLinea = new in_linea();

                      objLinea.IdEmpresa = info.IdEmpresa;
                      objLinea.IdCategoria = info.IdCategoria;
                      objLinea.IdLinea = IdLinea = (info.IdLinea == null || info.IdLinea == 0) ? GetIdLinea(info.IdEmpresa, info.IdCategoria) : info.IdLinea;
                      if (info.cod_linea == null || info.cod_linea == "")
                          info.cod_linea = objLinea.IdLinea.ToString();

                      objLinea.cod_linea = info.cod_linea.Trim();
                      objLinea.nom_linea = info.nom_linea.Trim();
                      if (info.abreviatura == null || info.abreviatura == "")
                          info.abreviatura = info.cod_linea.Trim();

                      objLinea.abreviatura = info.abreviatura;
                      objLinea.Estado = "A";

                      if (info.Observacion == "" || info.Observacion == null)
                          info.Observacion = "";

                      objLinea.observacion = info.Observacion;
                      objLinea.IdUsuario = (info.IdUsuario == null) ? "SysAdmin" : info.IdUsuario;
                      objLinea.Fecha_Transac = DateTime.Now;
                      objLinea.nom_pc = info.nom_pc;
                      objLinea.ip = info.ip;

                      context.in_linea.Add(objLinea);
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

      public Boolean ModificarDB(in_linea_info info, ref string msg)
      {
          try
          {
              using (EntitiesInventario context = new EntitiesInventario())
              {
                  var contact = context.in_linea.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdLinea == info.IdLinea && var.IdCategoria == info.IdCategoria);
                  if (contact != null)
                  {
                      contact.cod_linea = info.cod_linea;
                      contact.nom_linea = info.nom_linea;
                      contact.abreviatura = info.abreviatura;
                      contact.observacion = info.Observacion;
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

      public Boolean AnularDB(in_linea_info info,ref string msg)
      {
          try
          {
              using (EntitiesInventario context = new EntitiesInventario())
              {
                  var contact = context.in_linea.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdLinea == info.IdLinea && var.IdCategoria==info.IdCategoria);
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

      public int Get_IdLinea(int IdEmpresa, string IdCategoria, string Nom_Linea)
      {
          EntitiesInventario oEnti = new EntitiesInventario();
          try
          {
              int IdLinea = 0;

              var Objeto = oEnti.in_linea.FirstOrDefault(var => var.IdEmpresa == IdEmpresa && var.IdCategoria == IdCategoria && var.nom_linea == Nom_Linea);
              if (Objeto != null)
              {
                  IdLinea = Objeto.IdLinea;
              }
              return IdLinea;
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
