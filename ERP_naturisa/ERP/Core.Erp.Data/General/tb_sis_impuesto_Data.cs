using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.General;
using Core.Erp.Data.General;




namespace Core.Erp.Data.General
{
  public  class tb_sis_impuesto_Data
    {

      string mensaje = "";

      public List<tb_sis_impuesto_Info> Get_List_impuesto()
        {
            try
            {
                List<tb_sis_impuesto_Info> lst = new List<tb_sis_impuesto_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_sis_Impuesto
                             select q;
                foreach (var item in bancos)
                {
                    tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

                    info.IdCod_Impuesto = item.IdCod_Impuesto;
                    info.nom_impuesto = item.nom_impuesto;
                    info.Usado_en_Ventas = item.Usado_en_Ventas;
                    info.Usado_en_Compras = item.Usado_en_Compras;
                    info.porcentaje = item.porcentaje;
                    info.IdCodigo_SRI = item.IdCodigo_SRI;
                    info.estado = item.estado;
                    info.IdTipoImpuesto = item.IdTipoImpuesto;


                    lst.Add(info);
                }
                return lst;
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


      public tb_sis_impuesto_Info Get_Info_impuesto(string IdCod_Impuesto)
      {
          try
          {
              tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

              EntitiesGeneral oEnti = new EntitiesGeneral();

              var bancos = from q in oEnti.tb_sis_Impuesto
                           where q.IdCod_Impuesto == IdCod_Impuesto
                           select q;
              foreach (var item in bancos)
              {

                  info.IdCod_Impuesto = item.IdCod_Impuesto;
                  info.nom_impuesto = item.nom_impuesto;
                  info.Usado_en_Ventas = item.Usado_en_Ventas;
                  info.Usado_en_Compras = item.Usado_en_Compras;
                  info.porcentaje = item.porcentaje;
                  info.IdCodigo_SRI = item.IdCodigo_SRI;
                  info.estado = item.estado;
                  info.IdTipoImpuesto = item.IdTipoImpuesto;


                  
              }
              return info;
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

      public List<tb_sis_impuesto_Info> Get_List_impuesto(string IdTipoImpuesto)
      {
          try
          {
              List<tb_sis_impuesto_Info> lst = new List<tb_sis_impuesto_Info>();

              EntitiesGeneral oEnti = new EntitiesGeneral();

              var bancos = from q in oEnti.tb_sis_Impuesto
                           where q.IdTipoImpuesto == IdTipoImpuesto
                           select q;
              foreach (var item in bancos)
              {
                  tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

                  info.IdCod_Impuesto = item.IdCod_Impuesto;
                  info.nom_impuesto = item.nom_impuesto;
                  info.Usado_en_Ventas = item.Usado_en_Ventas;
                  info.Usado_en_Compras = item.Usado_en_Compras;
                  info.porcentaje = item.porcentaje;
                  info.IdCodigo_SRI = item.IdCodigo_SRI;
                  info.estado = item.estado;
                  info.IdTipoImpuesto = item.IdTipoImpuesto;


                  lst.Add(info);
              }
              return lst;
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


      public List<tb_sis_impuesto_Info> Get_List_impuesto_x_CtaCble(int IdEmpresa ,string IdTipoImpuesto)
      {
          try
          {
              List<tb_sis_impuesto_Info> lst = new List<tb_sis_impuesto_Info>();

              EntitiesGeneral oEnti = new EntitiesGeneral();

              var bancos = from q in oEnti.tb_sis_Impuesto
                           join cta in oEnti.tb_sis_Impuesto_x_ctacble on q.IdCod_Impuesto equals cta.IdCod_Impuesto
                           where q.IdTipoImpuesto == IdTipoImpuesto
                           && cta.IdEmpresa_cta == IdEmpresa
                           select new {cta.IdEmpresa_cta, q.IdCod_Impuesto,q.nom_impuesto,q.Usado_en_Ventas,q.Usado_en_Compras,q.porcentaje,q.IdCodigo_SRI,q.estado,q.IdTipoImpuesto
                           ,cta.IdCtaCble};

              foreach (var item in bancos)
              {
                  tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

                  info.IdCod_Impuesto = item.IdCod_Impuesto;
                  info.nom_impuesto = item.nom_impuesto;
                  info.Usado_en_Ventas = item.Usado_en_Ventas;
                  info.Usado_en_Compras = item.Usado_en_Compras;
                  info.porcentaje = item.porcentaje;
                  info.IdCodigo_SRI = item.IdCodigo_SRI;
                  info.estado = item.estado;
                  info.IdTipoImpuesto = item.IdTipoImpuesto;
                  info.Info_sis_Impuesto_x_ctacble.IdCod_Impuesto = item.IdCod_Impuesto;
                  info.Info_sis_Impuesto_x_ctacble.IdCtaCble = item.IdCtaCble;
                  info.Info_sis_Impuesto_x_ctacble.IdEmpresa_cta = item.IdEmpresa_cta;

                  lst.Add(info);
              }
              return lst;
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

      public List<tb_sis_impuesto_Info> Get_List_impuesto_para_Compras(string IdTipoImpuesto)
      {
          try
          {
              List<tb_sis_impuesto_Info> lst = new List<tb_sis_impuesto_Info>();

              EntitiesGeneral oEnti = new EntitiesGeneral();

              var bancos = from q in oEnti.tb_sis_Impuesto
                           where q.Usado_en_Compras==true
                           && q.IdTipoImpuesto == IdTipoImpuesto
                           select q;
              foreach (var item in bancos)
              {
                  tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

                  info.IdCod_Impuesto = item.IdCod_Impuesto;
                  info.nom_impuesto = item.nom_impuesto;
                  info.Usado_en_Ventas = item.Usado_en_Ventas;
                  info.Usado_en_Compras = item.Usado_en_Compras;
                  info.porcentaje = item.porcentaje;
                  info.IdCodigo_SRI = item.IdCodigo_SRI;
                  info.estado = item.estado;
                  info.IdTipoImpuesto = item.IdTipoImpuesto;


                  lst.Add(info);
              }
              return lst;
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

      public List<tb_sis_impuesto_Info> Get_List_impuesto_para_Ventas(string IdTipoImpuesto)
      {
          try
          {
              List<tb_sis_impuesto_Info> lst = new List<tb_sis_impuesto_Info>();

              EntitiesGeneral oEnti = new EntitiesGeneral();

              var bancos = from q in oEnti.tb_sis_Impuesto
                           where q.Usado_en_Ventas == true
                            && q.IdTipoImpuesto == IdTipoImpuesto
                           select q;
              foreach (var item in bancos)
              {
                  tb_sis_impuesto_Info info = new tb_sis_impuesto_Info();

                  info.IdCod_Impuesto = item.IdCod_Impuesto;
                  info.nom_impuesto = item.nom_impuesto;
                  info.Usado_en_Ventas = item.Usado_en_Ventas;
                  info.Usado_en_Compras = item.Usado_en_Compras;
                  info.porcentaje = item.porcentaje;
                  info.IdCodigo_SRI = item.IdCodigo_SRI;
                  info.estado = item.estado;
                  info.IdTipoImpuesto = item.IdTipoImpuesto;


                  lst.Add(info);
              }
              return lst;
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

      public Boolean GrabarDB(tb_sis_impuesto_Info Info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = new tb_sis_Impuesto();

                    address.IdCod_Impuesto = Info.IdCod_Impuesto;
                    address.nom_impuesto = Info.nom_impuesto;
                    address.Usado_en_Ventas = Info.Usado_en_Ventas;
                    address.Usado_en_Compras = Info.Usado_en_Compras;
                    address.porcentaje = Info.porcentaje;
                    address.IdCodigo_SRI = Info.IdCodigo_SRI;
                    address.estado = true;
                    address.IdTipoImpuesto = Info.IdTipoImpuesto;


                    context.tb_sis_Impuesto.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido grabar el Banco #: " + address.IdCod_Impuesto.ToString() + " exitosamente.";
                    resultado = true;
                }
                return resultado;
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

      public Boolean ActualizarDB(tb_sis_impuesto_Info Info, ref string msg)
        {
            try
            {
                bool resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = context.tb_sis_Impuesto.FirstOrDefault(v => v.IdCod_Impuesto == Info.IdCod_Impuesto);
                    if (address != null)
                    {


                        address.nom_impuesto = Info.nom_impuesto;
                        address.Usado_en_Ventas = Info.Usado_en_Ventas;
                        address.Usado_en_Compras = Info.Usado_en_Compras;
                        address.porcentaje = Info.porcentaje;
                        address.IdCodigo_SRI = Info.IdCodigo_SRI;
                        address.estado = Info.estado;
                        address.IdTipoImpuesto = Info.IdTipoImpuesto;


                        context.SaveChanges();
                        msg = "Se ha modificado el Banco #: " + address.IdCod_Impuesto.ToString() + " exitosamente.";
                        resultado = true;
                    }
                }
                return resultado;
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

      public Boolean AnulaDB(tb_sis_impuesto_Info Info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = context.tb_sis_Impuesto.FirstOrDefault(q => q.IdCod_Impuesto == Info.IdCod_Impuesto);
                    if (address != null)
                    {
                        address.estado = false;
                        context.SaveChanges();
                        msg = "Se ha procedido anular  #: " + Info.IdCod_Impuesto.ToString() + " exitosamente.";
                        resultado = true;
                    }
                }
                return resultado;
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
