using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using  Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
  public class in_Motivo_Inven_Bus
  {
      #region

      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      in_Motivo_Inven_Data odata = new in_Motivo_Inven_Data();
      cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
      string mensaje = "";
      #endregion

      public Boolean validarobjeto( in_Motivo_Inven_Info Info,ref string msj) 
      {
          try
          {
              if (Info.IdEmpresa==0)
                  {
                      msj = "Error Id Empresa = 0";

                      return false;
              }

              return true;

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validarobjeto", ex.Message), ex) { EntityType = typeof(in_Motivo_Inven_Bus) };

          }
      
      }


      public in_Motivo_Inven_Info Get_Info_Motivo_Inven(int IdEmpresa, int IdMotivo_Inv)
      {
          try
          {
              return odata.Get_Info_Motivo_Inven(IdEmpresa, IdMotivo_Inv);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "in_Motivo_Inven_Info", ex.Message), ex) { EntityType = typeof(in_Motivo_Inven_Bus) };

          }                 
      }

      




      public Boolean GuardarDB(in_Motivo_Inven_Info Imfo, ref int Id, ref string msg)
      {
          try
          {


              if (validarobjeto(Imfo, ref msg)==false)
              {
                  return false;
              }

              Imfo.IdUsuarioUltMod = param.IdUsuario;
              Imfo.Fecha_Transac = param.Fecha_Transac;

              return odata.GuardarDB(Imfo, ref Id, ref  msg);
          }

          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Motivo_Inven_Bus) };

          }
      }


      public Boolean ModificarDB(in_Motivo_Inven_Info Imfo, ref int Id, ref string msg)
      {

          try

          {
              if (validarobjeto(Imfo, ref msg) == false)
              {
                  return false;
              }
              Imfo.IdUsuarioUltMod = param.IdUsuario;
              Imfo.Fecha_UltMod = param.Fecha_Transac;

              return odata.ModificarDB(Imfo, ref Id, ref  msg);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_Motivo_Inven_Bus) };
          }
      }


      public Boolean AnularDB(in_Motivo_Inven_Info Imfo, ref int Id, ref string msg)
      {
          try
          {
              Imfo.IdUsuarioUltAnu = param.IdUsuario;
              Imfo.FechaHoraAnul = param.Fecha_Transac;
              return odata.AnularDB(Imfo, ref Id, ref  msg);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_Motivo_Inven_Bus) };

          }
      }


      public List<in_Motivo_Inven_Info> Get_List_Motivo_Inven(int IdEmpresa,string Tipo_Ing_Egr="")
      {
          try
          {

              return odata.Get_List_Motivo_Inven(IdEmpresa, Tipo_Ing_Egr);

          }
          catch (Exception ex)
          {

             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(in_Motivo_Inven_Bus) };
          }
      }
  }
}
