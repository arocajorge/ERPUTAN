﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.SqlClient;

namespace Core.Erp.Data.Contabilidad
{
  public  class ct_punto_cargo_Data
    {
      string mensaje = "";

      public List<ct_punto_cargo_Info> Get_list_PuntoCargo(int IdEmpresa)
      {
          try
          {
              List<ct_punto_cargo_Info> Lst = new List<ct_punto_cargo_Info>();
              using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
              {
                  connection.Open();
                  string query = "select IdEmpresa, IdPunto_cargo, codPunto_cargo, nom_punto_cargo, IdPunto_cargo_grupo, Estado, '['+cast(IdPunto_cargo as varchar)+'] '+nom_punto_cargo nom_punto_cargo2 from ct_punto_cargo where IdEmpresa = " + IdEmpresa.ToString();
                  SqlCommand command = new SqlCommand(query, connection);
                  SqlDataReader reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      Lst.Add(new ct_punto_cargo_Info
                      {
                          IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                          IdPunto_cargo = Convert.ToInt32(reader["IdPunto_cargo"]),
                          codPunto_cargo = Convert.ToString(reader["codPunto_cargo"]),
                          nom_punto_cargo = Convert.ToString(reader["nom_punto_cargo"]),
                          IdPunto_cargo_grupo = string.IsNullOrEmpty(reader["IdPunto_cargo_grupo"].ToString()) ? null : (int?)reader["IdPunto_cargo_grupo"],
                          Estado = Convert.ToString(reader["Estado"]),
                          nom_punto_cargo2 = Convert.ToString(reader["nom_punto_cargo2"]),
                      });
                  }
                  reader.Close();
              }
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public List<ct_punto_cargo_Info> Get_list_PuntoCargo_x_grupo(int IdEmpresa, int IdPunto_cargo_grupo)
      {
          List<ct_punto_cargo_Info> Lst = new List<ct_punto_cargo_Info>();
          try
          {
              EntitiesDBConta oEnti = new EntitiesDBConta();
              var Query = from q in oEnti.ct_punto_cargo
                          where q.IdEmpresa == IdEmpresa
                          && q.IdPunto_cargo_grupo == IdPunto_cargo_grupo
                          select q;
              foreach (var item in Query)
              {
                  ct_punto_cargo_Info Obj = new ct_punto_cargo_Info();

                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdPunto_cargo = item.IdPunto_cargo;
                  Obj.codPunto_cargo = item.codPunto_cargo;
                  Obj.nom_punto_cargo =  item.nom_punto_cargo;
                  Obj.nom_punto_cargo2 = "[" + item.IdPunto_cargo.ToString() + "] " + item.nom_punto_cargo;
                  Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                  Obj.Estado = item.Estado.TrimEnd();

                  Lst.Add(Obj);
              }
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean GuardarDB(ct_punto_cargo_Info Info,int IdEmpresa)
      {
          try
          {
              using(EntitiesDBConta oEnti = new EntitiesDBConta())
              {
                  var consulta = from q in oEnti.ct_punto_cargo
                          where q.IdEmpresa == IdEmpresa && q.IdPunto_cargo == Info.IdPunto_cargo         
                          select q;

                  if (consulta.ToList().Count == 0)
                  {
                    var registo = new ct_punto_cargo();

                    registo.IdEmpresa = IdEmpresa;
                    registo.IdPunto_cargo = Info.IdPunto_cargo = GetIdPunto_Cargo(IdEmpresa);
                    registo.codPunto_cargo = (Info.codPunto_cargo == "" || Info.codPunto_cargo == "0" || Info.codPunto_cargo==null) ? Convert.ToString(Info.IdPunto_cargo) : Info.codPunto_cargo;
                    registo.nom_punto_cargo = Info.nom_punto_cargo;
                    registo.IdPunto_cargo_grupo = Info.IdPunto_cargo_grupo == 0 ? null : Info.IdPunto_cargo_grupo;
                    registo.Estado = Info.Estado;

                    oEnti.ct_punto_cargo.Add(registo);
                    oEnti.SaveChanges();

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
              mensaje = ex.ToString();
              throw new Exception(ex.ToString()); 
          }
      }

      public int GetIdPunto_Cargo(int IdEmpresa)
      {
          int Id = 0;
          try
          {
              EntitiesDBConta oEnti = new EntitiesDBConta();

              var q = from C in oEnti.ct_punto_cargo
                        where C.IdEmpresa == IdEmpresa 
                        select C;

              if (q.ToList().Count == 0)
                  return 1;
              else
              {
                  var consulta = (from C in oEnti.ct_punto_cargo
                                  where C.IdEmpresa == IdEmpresa
                                  select C.IdPunto_cargo).Max();

                  Id = Convert.ToInt32(consulta) + 1;
              
              }
              return Id;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public ct_punto_cargo_Info Get_Info_Punto_cargo(int idEmpresa, int idPunto_cargo)
      {  
          try
          {
              ct_punto_cargo_Info Obj = new ct_punto_cargo_Info();

              using (EntitiesDBConta oEnti = new EntitiesDBConta())
              {
                  var Query = from q in oEnti.ct_punto_cargo
                              where q.IdEmpresa == idEmpresa
                              && q.IdPunto_cargo == idPunto_cargo
                              select q;
                  foreach (var item in Query)
                  {
                      Obj.IdEmpresa = item.IdEmpresa;
                      Obj.IdPunto_cargo = item.IdPunto_cargo;
                      Obj.codPunto_cargo = item.codPunto_cargo;
                      Obj.nom_punto_cargo = item.nom_punto_cargo;
                      Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                      Obj.Estado = item.Estado.TrimEnd();
                  }    
              } 
              return Obj;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean ModificarDB(ct_punto_cargo_Info Info)
      {
          try
          {
              using (EntitiesDBConta oEnti = new EntitiesDBConta())
              {
                  var registro = oEnti.ct_punto_cargo.FirstOrDefault(A => A.IdEmpresa == Info.IdEmpresa && A.IdPunto_cargo == Info.IdPunto_cargo);

                  if (registro != null)
                  {
                      registro.codPunto_cargo = (Info.codPunto_cargo == "") ? Convert.ToString(Info.IdPunto_cargo) : Info.codPunto_cargo;
                      registro.nom_punto_cargo = Info.nom_punto_cargo;
                      registro.IdPunto_cargo_grupo = Info.IdPunto_cargo_grupo == 0 ? null : Info.IdPunto_cargo_grupo;
                      registro.Estado = Info.Estado;
                      oEnti.SaveChanges();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
          }
      }

      public Boolean AnularDB(ct_punto_cargo_Info Info)
      {
          try
          {
              using (EntitiesDBConta oEnti = new EntitiesDBConta())
              {
                  var registro = oEnti.ct_punto_cargo.FirstOrDefault(A => A.IdEmpresa == Info.IdEmpresa && A.IdPunto_cargo == Info.IdPunto_cargo);

                  if (registro != null)
                  {
                      registro.Estado = "I";
                      oEnti.SaveChanges();
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
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean VericarCodigoExiste(string codigo, ref string mensaje)
      {
          try
          {
              Boolean Existe;
              string scodigo;

              scodigo = codigo.Trim();
              mensaje = "";
              Existe = false;

              EntitiesDBConta oEnti = new EntitiesDBConta();

              var consulta = from q in oEnti.ct_punto_cargo
                             where q.codPunto_cargo == scodigo
                             select q;

              foreach (var item in consulta)
              {
                  mensaje = mensaje + " " + item.nom_punto_cargo + " ";
                  Existe = true;
              }

              return Existe;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public List<ct_punto_cargo_Info> Get_list_PuntoCargo_x_grupo(int IdEmpresa)
      {
          List<ct_punto_cargo_Info> Lst = new List<ct_punto_cargo_Info>();
          try
          {
              EntitiesDBConta oEnti = new EntitiesDBConta();
              var Query = from q in oEnti.ct_punto_cargo
                          where q.IdEmpresa == IdEmpresa
                          select q;
              foreach (var item in Query)
              {
                  ct_punto_cargo_Info Obj = new ct_punto_cargo_Info();

                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdPunto_cargo = item.IdPunto_cargo;
                  Obj.codPunto_cargo = item.codPunto_cargo;
                  Obj.nom_punto_cargo = item.nom_punto_cargo;
                  Obj.nom_punto_cargo2 = "[" + item.IdPunto_cargo.ToString() + "] " + item.nom_punto_cargo;
                  Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                  Obj.Estado = item.Estado.TrimEnd();

                  Lst.Add(Obj);
              }
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }
    }
}
