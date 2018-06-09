using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;

namespace Core.Erp.Business.Academico
{
  public  class Aca_Documento_Bancario_x_Rep_Economico_Bus
  {
      string mensaje = "";
      Aca_Documento_Bancario_x_Rep_Economico_Data data = new Aca_Documento_Bancario_x_Rep_Economico_Data();
      public List<Aca_Documento_Bancario_x_Rep_Economico_Info> Get_List_Matricula_Tipo_Documento(int IdInstitucion, int idfamiliar)
      {
          try
          {
              return data.Get_List_Matricula_Tipo_Documento(IdInstitucion, idfamiliar);   
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "Get_List_Matricula_Tipo_Documento", ex.Message), ex) { EntityType = typeof(Aca_Documento_Bancario_x_Rep_Economico_Bus) };
           
          }
      }
      public Aca_Documento_Bancario_x_Rep_Economico_Info Get_Info_Documento_Bancario_x_Rep_Economico(int IdInstitucion, int idfamiliar)
      {
          try
          {
              return data.Get_Info_Documento_Bancario_x_Rep_Economico(IdInstitucion, idfamiliar);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "Get_Info_Documento_Bancario_x_Rep_Economico", ex.Message), ex) { EntityType = typeof(Aca_Documento_Bancario_x_Rep_Economico_Bus) };

          }
      }



      public bool GrabarDB(List< Aca_Documento_Bancario_x_Rep_Economico_Info> lista, ref int IdDocumentoBancario, ref string mensaje)
      {
          try
          {
              return data.GrabarDB(lista, ref IdDocumentoBancario, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Documento_Bancario_x_Rep_Economico_Bus) };
           
          }
      }


      public bool ActualizarDB(Aca_Documento_Bancario_x_Rep_Economico_Info info, ref string mensaje)
      {
          try
          {
              return data.ActualizarDB(info, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Documento_Bancario_x_Rep_Economico_Bus) };

          }
      }
    }
}
