using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Academico
{
  public  class Aca_Institucion_Data
    {
      public Aca_Institucion_Data() { }

      #region "Get"

      public int GetId(int IdEmpresa)
      {
          int Id = 0;
          try
          {
              Entities_Academico Base = new Entities_Academico();
              int select = (from q in Base.Aca_Institucion
                            where q.IdEmpresa == IdEmpresa
                            select q).Count();

              if (select == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_as = (from q in Base.Aca_Institucion
                                   where q.IdEmpresa == IdEmpresa
                                   select q.IdInstitucion).Max();
                  Id = Convert.ToInt32(select_as.ToString()) + 1;
              }
              return Id;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string MensajeError = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.ToString());
          }
      }

      public List<Aca_Institucion_Info> Get_List_Institucion(int IdEmpresa)
      {
          List<Aca_Institucion_Info> listaInstitucion = new List<Aca_Institucion_Info>();
          Aca_Institucion_Info infoInstitucion;
          
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var Institucion = from x in Base.Aca_Institucion
                                    where x.IdEmpresa == IdEmpresa
                                    select x;

                  foreach (var item in Institucion)
                  {
                      infoInstitucion = new Aca_Institucion_Info();
                      infoInstitucion.IdEmpresa = item.IdEmpresa;
                      infoInstitucion.IdInstitucion = item.IdInstitucion;
                      infoInstitucion.Ruc = item.Ruc;
                      infoInstitucion.Nombre = item.Nombre;
                      infoInstitucion.Rector = item.Rector;
                      infoInstitucion.Resolucion_Academica = item.Resolucion_academica;
                      infoInstitucion.Secretario = item.Secretario;
                      infoInstitucion.SitioWeb = item.Sitio_web;
                      infoInstitucion.Telefono = item.Telefono;
                                            
                      using(EntitiesGeneral BaseG=new EntitiesGeneral())
	                    {                      
                             var  vPais = BaseG.tb_pais.First(o=>o.IdPais==item.IdPais);
                             infoInstitucion.paisInfo.IdPais = vPais.IdPais;
                             infoInstitucion.paisInfo.CodPais = vPais.CodPais;
                             infoInstitucion.paisInfo.Nombre = vPais.Nombre;
                             infoInstitucion.paisInfo.estado = vPais.estado;

                             var vProvincia = BaseG.tb_provincia.First(p=>p.IdPais==item.IdPais);
                             infoInstitucion.provinciaInfo.IdProvincia = vProvincia.IdProvincia;
                             infoInstitucion.provinciaInfo.CodProvincia = vProvincia.Cod_Provincia;
                             infoInstitucion.provinciaInfo.IdPais = vProvincia.IdPais;
                             infoInstitucion.provinciaInfo.Descripcion = vProvincia.Descripcion_Prov;
                             infoInstitucion.provinciaInfo.Estado = vProvincia.Estado;

                             var vCiudad = BaseG.tb_ciudad.FirstOrDefault(c=>c.IdProvincia==item.IdProvincia);
                             infoInstitucion.ciudadInfo.IdCiudad = vCiudad.IdCiudad;
                             infoInstitucion.ciudadInfo.IdProvincia = vCiudad.IdProvincia;
                             infoInstitucion.ciudadInfo.Descripcion = vCiudad.Descripcion_Ciudad;
                             infoInstitucion.ciudadInfo.CodCiudad = vCiudad.Cod_Ciudad;
                             infoInstitucion.ciudadInfo.Estado = vCiudad.Estado;                             
	                    }
                      
                      infoInstitucion.CodInstitucion = item.codInstitucion;
                      infoInstitucion.Coordinador = item.Cordinador;
                      infoInstitucion.Direccion = item.Direccion;
                      infoInstitucion.Fax = item.Fax;
                      infoInstitucion.Estado = item.Estado;
                      infoInstitucion.FechaCreacion = item.FechaCreacion;
                      infoInstitucion.FechaMoficacion = item.FechaModificacion;
                      infoInstitucion.UsuarioCreacion = item.UsuarioCreacion;
                      infoInstitucion.UsuarioModificacion = item.UsuarioModificacion;
                      listaInstitucion.Add(infoInstitucion);
                  }
              }
              return listaInstitucion;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string mensaje = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
      

      public Aca_Institucion_Info Get_Info_Institucion(int IdInstitucion)
      {

          Aca_Institucion_Info infoInstitucion = new Aca_Institucion_Info();

          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var Institucion = from x in Base.Aca_Institucion
                                    where x.IdInstitucion == IdInstitucion
                                    select x;

                  foreach (var item in Institucion)
                  {
                      infoInstitucion = new Aca_Institucion_Info();
                      infoInstitucion.IdEmpresa = item.IdEmpresa;
                      infoInstitucion.IdInstitucion = item.IdInstitucion;
                      infoInstitucion.Ruc = item.Ruc;
                      infoInstitucion.Nombre = item.Nombre;
                      infoInstitucion.Rector = item.Rector;
                      infoInstitucion.Resolucion_Academica = item.Resolucion_academica;
                      infoInstitucion.Secretario = item.Secretario;
                      infoInstitucion.SitioWeb = item.Sitio_web;
                      infoInstitucion.Telefono = item.Telefono;

                      using (EntitiesGeneral BaseG = new EntitiesGeneral())
                      {
                          var vPais = BaseG.tb_pais.First(o => o.IdPais == item.IdPais);
                          infoInstitucion.paisInfo.IdPais = vPais.IdPais;
                          infoInstitucion.paisInfo.CodPais = vPais.CodPais;
                          infoInstitucion.paisInfo.Nombre = vPais.Nombre;
                          infoInstitucion.paisInfo.estado = vPais.estado;

                          var vProvincia = BaseG.tb_provincia.First(p => p.IdPais == item.IdPais);
                          infoInstitucion.provinciaInfo.IdProvincia = vProvincia.IdProvincia;
                          infoInstitucion.provinciaInfo.CodProvincia = vProvincia.Cod_Provincia;
                          infoInstitucion.provinciaInfo.IdPais = vProvincia.IdPais;
                          infoInstitucion.provinciaInfo.Descripcion = vProvincia.Descripcion_Prov;
                          infoInstitucion.provinciaInfo.Estado = vProvincia.Estado;

                          var vCiudad = BaseG.tb_ciudad.FirstOrDefault(c => c.IdProvincia == item.IdProvincia);
                          infoInstitucion.ciudadInfo.IdCiudad = vCiudad.IdCiudad;
                          infoInstitucion.ciudadInfo.IdProvincia = vCiudad.IdProvincia;
                          infoInstitucion.ciudadInfo.Descripcion = vCiudad.Descripcion_Ciudad;
                          infoInstitucion.ciudadInfo.CodCiudad = vCiudad.Cod_Ciudad;
                          infoInstitucion.ciudadInfo.Estado = vCiudad.Estado;
                      }

                      infoInstitucion.CodInstitucion = item.codInstitucion;
                      infoInstitucion.Coordinador = item.Cordinador;
                      infoInstitucion.Direccion = item.Direccion;
                      infoInstitucion.Fax = item.Fax;
                      infoInstitucion.Estado = item.Estado;
                      infoInstitucion.FechaCreacion = item.FechaCreacion;
                      infoInstitucion.FechaMoficacion = item.FechaModificacion;
                      infoInstitucion.UsuarioCreacion = item.UsuarioCreacion;
                      infoInstitucion.UsuarioModificacion = item.UsuarioModificacion;
                      
                  }
              }
              return infoInstitucion;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string mensaje = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public int GetIdInstitucion(int IdEmpresa) 
      {
          int IdInstitucion = 0;
          try
          {
              using(Entities_Academico Base= new Entities_Academico())
	            {
                    var vIntitucion = Base.Aca_Institucion.FirstOrDefault(i=> i.IdEmpresa==IdEmpresa);
                    if (vIntitucion != null)
                        IdInstitucion = vIntitucion.IdInstitucion;
                    else
                        IdInstitucion = 0;
	            }
              return IdInstitucion;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string mensaje = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
         

      #endregion

      #region "Grabar, Actualizar, Eliminar"
      public bool GrabarDB(Aca_Institucion_Info info,ref int idInstitucion,ref string mensaje) {
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  Aca_Institucion addressInst = new Aca_Institucion();
                  idInstitucion = GetId(info.IdEmpresa);
                  addressInst.IdEmpresa = info.IdEmpresa;
                  addressInst.IdInstitucion = idInstitucion;
                  addressInst.codInstitucion = string.IsNullOrEmpty(info.CodInstitucion) ? idInstitucion.ToString(): info.CodInstitucion;
                  addressInst.IdPais = info.paisInfo.IdPais;
                  addressInst.IdProvincia = info.provinciaInfo.IdProvincia;
                  addressInst.IdCiudad = info.ciudadInfo.IdCiudad;
                  addressInst.Ruc = info.Ruc;
                  addressInst.Nombre = info.Nombre;
                  addressInst.Rector = info.Rector;
                  addressInst.Cordinador = info.Coordinador;                  
                  addressInst.Secretario = info.Secretario;
                  addressInst.Resolucion_academica = info.Resolucion_Academica;
                  addressInst.Sitio_web = info.SitioWeb;
                  addressInst.Telefono = info.Telefono;
                  addressInst.Fax = info.Fax;
                  addressInst.Logo = info.Logo;
                  addressInst.Direccion = info.Direccion;
                  addressInst.UsuarioCreacion = info.UsuarioCreacion;
                  addressInst.UsuarioModificacion = info.UsuarioCreacion;
                  addressInst.FechaCreacion = DateTime.Now;
                  addressInst.FechaModificacion = DateTime.Now;
                  addressInst.Estado = info.Estado;
                  Base.Aca_Institucion.Add(addressInst);
                  Base.SaveChanges();
                  mensaje = "Se ha procedido a grabar la Institución #: " + idInstitucion.ToString() + " exitosamente.";
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
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public bool ActualizarDB(Aca_Institucion_Info info,ref string mensaje) {
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var vInstitucion = Base.Aca_Institucion.FirstOrDefault(o=>o.IdEmpresa==info.IdEmpresa && o.IdInstitucion==info.IdInstitucion);

                  if (vInstitucion != null)
                  {
                      vInstitucion.codInstitucion = (string.IsNullOrEmpty(info.CodInstitucion.ToString())) ? info.IdInstitucion.ToString() : info.CodInstitucion;
                      vInstitucion.IdPais = info.paisInfo.IdPais;
                      vInstitucion.IdProvincia = info.provinciaInfo.IdProvincia;
                      vInstitucion.IdCiudad = info.ciudadInfo.IdCiudad;
                      vInstitucion.Cordinador = info.Coordinador;
                      vInstitucion.Direccion = info.Direccion;
                      vInstitucion.Estado = info.Estado;
                      vInstitucion.Fax = info.Fax;
                      vInstitucion.Logo = info.Logo;
                      vInstitucion.Ruc = info.Ruc;
                      vInstitucion.Nombre = info.Nombre;
                      vInstitucion.Rector = info.Rector;
                      vInstitucion.Resolucion_academica = info.Resolucion_Academica;
                      vInstitucion.Secretario = info.Secretario;
                      vInstitucion.Sitio_web = info.SitioWeb;
                      vInstitucion.Telefono = info.Telefono;
                      vInstitucion.FechaModificacion = DateTime.Now;
                      vInstitucion.UsuarioModificacion = info.UsuarioModificacion;
                      Base.SaveChanges();
                      mensaje = "Se ha procedido actualizar la Institución #: " + info.IdInstitucion.ToString() + " exitosamente.";
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
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public bool AnularDB(Aca_Institucion_Info info,ref string mensaje) {
          try
          {
              using (Entities_Academico context = new Entities_Academico())
              {
                  var address = context.Aca_Institucion.FirstOrDefault(a => a.IdEmpresa == info.IdEmpresa && a.IdInstitucion == info.IdInstitucion);
                  if (address != null)
                  {
                      address.Estado = "I";
                      address.FechaAnulacion = DateTime.Now;
                      address.UsuarioAnulacion = info.UsuarioAnulacion;
                      address.MotivoAnulacion = info.MotivoAnulacion;
                      context.SaveChanges();
                      mensaje = "Se ha procedido anular la Institución #: " + info.IdInstitucion.ToString() + " exitosamente.";
                  }
                  return true;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      #endregion

      #region "Validaciones"
      public bool  ExisteInstitucion(int idEmpresa) 
      {
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  int valida = (from v in Base.Aca_Institucion
                                where v.IdEmpresa == idEmpresa && v.Estado!="I"                               
                                select v).Count();
                  if (valida==0)
                  {
                      return true;    
                  }
              }
              return false;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string mensaje = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
      #endregion
    }
}
