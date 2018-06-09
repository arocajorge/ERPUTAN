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
  public  class fa_factura_aca_Data
  {
      #region "Insertar, Actualizar, Eliminar"
      public bool Grabar(fa_factura_aca_Info info, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  fa_factura_aca address = new fa_factura_aca();
                  address.IdEmpresa = info.IdEmpresa;
                  address.IdSucursal = info.IdSucursal;
                  address.IdBodega = info.IdBodega;
                  address.IdCbteVta = info.IdCbteVta;
                  address.IdInstitucion = info.IdInstitucion;
                  address.IdEstudiante = info.IdEstudiante;
                  address.IdFamiliar = info.IdFamiliar;
                  address.IdParentesco_cat = info.IdParentesco_cat;


                  address.IdAnioLectivo = info.IdAnioLectivo;
                  address.IdPeriodo = info.IdPeriodo;
                  address.IdRubro = info.IdRubro;
                         
                  Base.fa_factura_aca.Add(address);
                  Base.SaveChanges();
                  mensaje = "Se ha procedido ingresar un nuevo periodo lectivo exitosamente ";


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
              mensaje = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public bool Actualizar(fa_factura_aca_Info info, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var address = Base.fa_factura_aca.FirstOrDefault(o => o.IdInstitucion == info.IdInstitucion && o.IdCbteVta == info.IdCbteVta);
                  if (address != null)
                  {
                      address.IdEmpresa = info.IdEmpresa;
                      address.IdBodega = info.IdBodega;
                      address.IdCbteVta = info.IdCbteVta;
                      address.IdInstitucion = info.IdInstitucion;
                      address.IdEstudiante = info.IdEstudiante;
                      address.IdFamiliar = info.IdFamiliar;
                      address.IdParentesco_cat = info.IdParentesco_cat;

                      address.IdAnioLectivo = info.IdAnioLectivo;
                      address.IdPeriodo = info.IdPeriodo;
                      address.IdRubro = info.IdRubro;
                      Base.SaveChanges();
                      mensaje = "Se ha procedido actualizar el periodo lectivo exitosamente ";
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
              mensaje = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public bool AnularDB(fa_factura_aca_Info info, ref string mensaje)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var address = Base.fa_factura_aca.FirstOrDefault(o => o.IdInstitucion == info.IdInstitucion && o.IdCbteVta == info.IdCbteVta);
                  if (address != null)
                  {
                      
                      Base.SaveChanges();
                      mensaje = "Se ha procedido actualizar el periodo lectivo exitosamente ";
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
              mensaje = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }


      public List<fa_factura_aca_Info> Get_list(int IdInstitucion, int InAnio_Lectivo, int idPeriodo, ref string mensaje)
      {
          try
          {
              List<fa_factura_aca_Info> lista = new List<fa_factura_aca_Info>();


              using (Entities_Academico Context = new Entities_Academico())
              {

                  var contact = from q in Context.vwACA_fa_factura_aca_Det
                                // where q.IdInstitucion == IdInstitucion
                                //&& q.IdPreFacturacion == IdPrefacturacion

                                select q;

                  foreach (var item in contact)
                  {
                      fa_factura_aca_Info add = new fa_factura_aca_Info();
                      add.IdInstitucion = item.IdInstitucion;
                      add.vt_cantidad = item.vt_cantidad;
                      add.vt_Precio = item.vt_Precio;
                      add.vt_PorDescUnitario = item.vt_PorDescUnitario;
                      add.vt_DescUnitario = item.vt_DescUnitario;
                      add.vt_PrecioFinal = item.vt_PrecioFinal;
                      add.vt_Subtotal = item.vt_Subtotal;
                      add.Descripcion_paralelo = item.Descripcion_paralelo;
                      add.Descripcion_cur = item.Descripcion_cur;
                      add.Descripcion_secc = item.Descripcion_secc;
                      add.Nom_Estud = item.Apell_Estu + " " + item.Nom_Estud;
                      add.Nombre_Fam = item.Apellido_Fam + " " + item.Nombre_Fam;
                      add.vt_serie1 = item.vt_serie1;
                      add.vt_serie2 = item.vt_serie2;
                      add.vt_NumFactura = item.vt_NumFactura;
                      add.Comprobante = item.vt_Observacion+" "+ item.vt_serie1 + "-" + item.vt_serie2 + "-" + item.vt_NumFactura;

                      lista.Add(add);
                  }
              }
              return lista;
          }
          catch (Exception ex)
          {
              string array = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public fa_factura_aca_Info Get_Info(decimal IdFactura, ref string mensaje)
      {
          try
          {
              fa_factura_aca_Info Info = new fa_factura_aca_Info();
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var address = Base.fa_factura_aca.FirstOrDefault(o => o.IdCbteVta == IdFactura);
                  if (address != null)
                  {  
                      Info.IdEstudiante = address.IdEstudiante;
                      Info.IdPeriodo = address.IdPeriodo;
                      Info.IdRubro = address.IdRubro;                    
                  }
              }
              return Info;
          }
          catch (Exception ex)
          {
              string array = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
      
      #endregion
    }
}
