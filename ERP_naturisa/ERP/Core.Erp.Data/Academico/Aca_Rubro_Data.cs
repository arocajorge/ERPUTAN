using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Academico
{
  public  class Aca_Rubro_Data
  {
      #region "Get"
      public int GetId()
      {
          int Id = 0;
          try
          {
              Entities_Academico Base = new Entities_Academico();
              int select = (from q in Base.Aca_Rubro                            
                            select q).Count();

              if (select == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_as = (from q in Base.Aca_Rubro
                                   select q.IdRubro).Max();
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

      public List<Aca_Rubro_Info> Get_List_Rubro()
      {
          List<Aca_Rubro_Info> lista = new List<Aca_Rubro_Info>();
          Aca_Rubro_Info rubroInfo;
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var rubro = from r in Base.Aca_Rubro
                              orderby r.IdRubro
                              select r;

                  foreach (var item in rubro)
                  {
                      rubroInfo = new Aca_Rubro_Info();
                      rubroInfo.IdInstitucion = item.IdInstitucion;
                      rubroInfo.IdRubro = item.IdRubro;
                      rubroInfo.Descripcion_rubro = item.Descripcion_rubro;
                      rubroInfo.Deb_cred = item.deb_cred;
                      //rubroInfo.CodRubro = item.CodRubro;
                      rubroInfo.CodRubro = "[" + item.CodRubro + "]" + item.Descripcion_rubro;
                      rubroInfo.CodAlterno = item.CodAlterno;
                      rubroInfo.IdTipoServicio = item.IdTipoServicio_cata;
                      rubroInfo.IdTipoRubro = item.IdTipoRubro;
                      rubroInfo.IdGrupoFE = item.IdGrupoFE;
                      rubroInfo.NumeroCoutas = item.Num_coutas;
                      rubroInfo.estado = item.estado;
                      rubroInfo.IdCtaCble = item.IdCtaCble;
                      rubroInfo.IdEmpresa_inv = item.IdEmpresa_inv;
                      rubroInfo.IdProducto_inv = item.IdProducto_inv;
                      rubroInfo.IdCentroCosto_ct = item.IdCentroCosto_ct;
                      lista.Add(rubroInfo);
                  }
              }
              return lista;
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

      public Aca_Rubro_Info Get_Info_Rubro_x_Producto(decimal IdProducto)
      {
         
          try
          {
              Aca_Rubro_Info rubroInfo = new Aca_Rubro_Info();
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var rubro = from r in Base.Aca_Rubro
                              where r.IdProducto_inv == IdProducto
                              orderby r.IdRubro
                              select r;
                  foreach (var item in rubro)
                  {
                      rubroInfo.IdInstitucion = item.IdInstitucion;
                      rubroInfo.IdRubro = item.IdRubro;
                      rubroInfo.Descripcion_rubro = item.Descripcion_rubro;
                      rubroInfo.Deb_cred = item.deb_cred;
                      //rubroInfo.CodRubro = item.CodRubro;
                      rubroInfo.CodRubro = "[" + item.CodRubro + "]" + item.Descripcion_rubro;
                      rubroInfo.CodAlterno = item.CodAlterno;
                      rubroInfo.IdTipoServicio = item.IdTipoServicio_cata;
                      rubroInfo.IdTipoRubro = item.IdTipoRubro;
                      rubroInfo.IdGrupoFE = item.IdGrupoFE;
                      rubroInfo.NumeroCoutas = item.Num_coutas;
                      rubroInfo.estado = item.estado;
                      rubroInfo.IdCtaCble = item.IdCtaCble;
                      rubroInfo.IdEmpresa_inv = item.IdEmpresa_inv;
                      rubroInfo.IdProducto_inv = item.IdProducto_inv;
                      rubroInfo.IdCentroCosto_ct = item.IdCentroCosto_ct;              
                  }             
              }
              return rubroInfo;
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
      #endregion

      #region "Grabar,Actualizar,Eliminar"

      public bool GrabarDB(Aca_Rubro_Info info, ref int idRubro, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  Aca_Rubro addressRubro = new Aca_Rubro();
                  idRubro = GetId();
                  addressRubro.IdRubro = idRubro;
                  addressRubro.IdInstitucion = info.IdInstitucion;
                  addressRubro.CodRubro = string.IsNullOrEmpty( info.CodRubro) ? idRubro.ToString():info.CodRubro;
                  addressRubro.CodAlterno = string.IsNullOrEmpty( info.CodAlterno)?"":info.CodAlterno.ToString();
                  addressRubro.Descripcion_rubro = info.Descripcion_rubro;
                  addressRubro.IdTipoRubro = info.IdTipoRubro;
                  addressRubro.estado = info.estado;
                  addressRubro.deb_cred = info.Deb_cred;
                  addressRubro.IdTipoServicio_cata = info.IdTipoServicio;
                  addressRubro.Num_coutas = info.NumeroCoutas;
                  addressRubro.IdCtaCble = info.IdCtaCble;
                  addressRubro.IdGrupoFE = info.IdGrupoFE;
                  addressRubro.FechaCreacion = DateTime.Now;
                  addressRubro.UsuarioCreacion = info.UsuarioCreacion;
                  addressRubro.IdEmpresa_inv = info.IdEmpresa_inv;
                  addressRubro.IdProducto_inv = info.IdProducto_inv;
                  addressRubro.IdEmpresa_ct = info.IdEmpresa_ct;
                  addressRubro.IdCentroCosto_ct = info.IdCentroCosto_ct;
                  Base.Aca_Rubro.Add(addressRubro);
                  Base.SaveChanges();
                  mensaje = "Se ha procedido a grabar el Rubro #: " + idRubro.ToString() + " exitosamente.";
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

      public bool ActualizarDB(Aca_Rubro_Info info, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var vRubro = Base.Aca_Rubro.FirstOrDefault(j => j.IdRubro==info.IdRubro);
                  if (vRubro != null)
                  {
                      vRubro.IdInstitucion = info.IdInstitucion;
                      //vRubro.CodRubro = string.IsNullOrEmpty(info.CodRubro) ? info.IdRubro.ToString() : info.CodRubro == "0" ? info.IdRubro.ToString() : info.CodRubro;
                      //vRubro.CodAlterno = string.IsNullOrEmpty(info.CodAlterno) ? "" : info.CodAlterno.ToString();
                      vRubro.Descripcion_rubro = info.Descripcion_rubro;
                      vRubro.IdGrupoFE = info.IdGrupoFE;
                      vRubro.deb_cred = info.Deb_cred;
                      vRubro.IdTipoRubro = info.IdTipoRubro;
                      vRubro.IdTipoServicio_cata = info.IdTipoServicio;
                      vRubro.Num_coutas = info.NumeroCoutas;                      
                      vRubro.IdCtaCble = info.IdCtaCble;
                      vRubro.UsuarioModificacion = info.UsuarioModificacion;
                      vRubro.FechaModificacion = DateTime.Now;
                      vRubro.estado = info.estado;
                      vRubro.IdProducto_inv = info.IdProducto_inv;
                      vRubro.IdCentroCosto_ct = info.IdCentroCosto_ct;
                      vRubro.IdEmpresa_ct = info.IdEmpresa_ct;
                      //vRubro.IdEmpresa_inv = info.IdEmpresa_inv;
                      Base.SaveChanges();
                      mensaje = "Se ha procedido actualizar el Rubro #: " + info.IdRubro.ToString() + " exitosamente.";
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

      public Boolean AnularDB(Aca_Rubro_Info info, ref string msg)
      {
          try
          {
              using (Entities_Academico context = new Entities_Academico())
              {
                  var address = context.Aca_Rubro.FirstOrDefault(a => a.IdRubro==info.IdRubro);
                  if (address != null)
                  {
                      address.estado = "I";
                      address.FechaAnulacion = DateTime.Now;
                      address.UsuarioAnulacion = info.UsuarioAnulacion;
                      address.MotivoAnulacion = info.MotivoAnulacion;
                      context.SaveChanges();
                      msg = "Se ha procedido anular el rubro #: " + info.IdRubro.ToString() + " exitosamente.";
                  }
                  return true;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msg = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
              msg = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      #endregion
    }
}
