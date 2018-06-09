using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Academico
{
  public  class Aca_matricula_Bus
    {

      Aca_Matricula_Data da;
      private vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Data OdataEstMatriculaConSinContrato = new vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Data();
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Bus bus_Tipo_Doc = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Bus();
      public Aca_matricula_Bus() {
          da = new Aca_Matricula_Data();
      }

      //public bool ValidaEstudiante(decimal IdEstudiante, string IdAnioLectivo)
      public bool ValidaEstudiante(decimal IdEstudiante, int IdAnioLectivo)
      {
          try
          {
              return da.ValidaEstudiante(IdEstudiante, IdAnioLectivo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidaEstudiante", ex.Message), ex) { EntityType = typeof(Aca_matricula_Bus) };
          }
      }

      public List<Aca_Matricula_Info> Get_List_Matricula(int IDInstitucion) {
          try
          {
             return  da.Get_List_Matricula(IDInstitucion);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Matricula", ex.Message), ex) { EntityType = typeof(Aca_matricula_Bus) };
          }
          
      }
      public Aca_Matricula_Info Get_Info(decimal IdMatricula) 
      {
          try
          {
              return da.Get_Info(IdMatricula);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Matricula", ex.Message), ex) { EntityType = typeof(Aca_matricula_Bus) };
          }
      }

      public List<Aca_Matricula_Info> Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(int IdInstitucion, int IdSede)
      {
          try
          {
              List<Aca_Matricula_Info> lista = new List<Aca_Matricula_Info>();
              lista = da.Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(IdInstitucion, IdSede);
              return lista;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiante_Matricula_Con_y_Sin_Contrato", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
          }
      }


      public bool GrabarDB(Aca_Matricula_Info infoMatricula, ref decimal IdMatricula,ref string mensaje ) 
      {
          bool resultado = false;
          try
          {
              resultado = ValidaEstudiante(infoMatricula.IdEstudiante, infoMatricula.IdAnioLectivo);
              if (resultado==true)
              {
                  mensaje = "El Estudiante ya se encuentra matriculado.";
                  return false;
              }

              Aca_Familiar_Bus negFamiliar = new Aca_Familiar_Bus();
              resultado = negFamiliar.GrabarDB(infoMatricula.listaFamiliar, infoMatricula.estudianteInfo, ref mensaje);
              if (resultado)
              {
                  resultado = da.GrabarDB(infoMatricula, ref IdMatricula, ref mensaje);
                  if (resultado)
                  {  // Insertar Documento
                      Aca_Material_x_Documento_Bus negDoc = new Aca_Material_x_Documento_Bus();
                      foreach (var itemDocumento in infoMatricula.listaDocumento)
                      {
                          infoMatricula.IdMatricula = IdMatricula;
                          
                          resultado = negDoc.GrabarDB(itemDocumento, infoMatricula, ref mensaje);
                      }                      
                  }                
              }

              if (resultado)
              {
                  infoMatricula.Forma_Debito.IdEstudiante = infoMatricula.IdEstudiante;
                  infoMatricula.Forma_Debito.IdMatricula = IdMatricula;
                  
                  resultado = bus_Tipo_Doc.GrabarDB(infoMatricula.Forma_Debito, ref mensaje);
              }
              return resultado;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_matricula_Bus) };
           
          }
          
      }




      public bool ActualizarDB(Aca_Matricula_Info infoMatricula, ref string mensaje)
      {
          bool resultado = false;
          try
          {
              //Actualiza Familiar
              Aca_Familiar_Bus negFamiliar = new Aca_Familiar_Bus();
              resultado = negFamiliar.ActualizarDB(infoMatricula.listaFamiliar, infoMatricula.estudianteInfo, ref mensaje);
             
              // Actualiza Matricula
              if (da.ActualizarDB(infoMatricula, ref mensaje))
              {
                  resultado = bus_Tipo_Doc.GrabarDB(infoMatricula.Forma_Debito, ref mensaje);

                  ////Actualizar el estado de la matricula en la base del postgres
                  if (resultado)
                  {
                      if(infoMatricula.Estado == "A" && infoMatricula.listaFamiliar.Count() == 4)
                      resultado = da.actualizar_Estado_Matricula_Postgres(infoMatricula, ref mensaje);
                  }
              }
              return resultado;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_matricula_Bus) };
          }
          
      }

      public bool AnularDB(Aca_Matricula_Info info, ref string mensaje)
      {
          try
          {
              return da.AnularDB(info, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "DeleteDB", ex.Message), ex) { EntityType = typeof(Aca_matricula_Bus) };
          }
          
      }


      public decimal Busca_Matricula(decimal idEstudiante)
      {
          try
          {
              return da.Busca_Matricula(idEstudiante);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Busca_Matricula", ex.Message), ex) { EntityType = typeof(Aca_matricula_Bus) };
          }
      }
    }
}
